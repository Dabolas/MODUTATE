// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C38{
internal static JClass Build(){var c=new JClass("forge/card/CardRulesPredicates","java/lang/Object",new string[]{},49);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("IS_KEPT_IN_AI_DECKS","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_KEPT_IN_AI_LIMITED_DECKS","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_KEPT_IN_RANDOM_DECKS","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("RESTRICTION_STAT_FILTER","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("IS_PERMANENT","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_CREATURE","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_LEGENDARY","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_ARTIFACT","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_ATTRACTION","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_CONTRAPTION","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_EQUIPMENT","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_LAND","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_BASIC_LAND","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("NOT_BASIC_LAND","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_TRUE_BASIC_LAND","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_NONBASIC_LAND","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("CAN_BE_COMMANDER","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("CAN_BE_PARTNER_COMMANDER","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("CAN_BE_OATHBREAKER","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("CAN_BE_SIGNATURE_SPELL","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_PLANESWALKER","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("CAN_BE_TINY_LEADERS_COMMANDER","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("CAN_BE_BRAWL_COMMANDER","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_BATTLE","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_INSTANT","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_SORCERY","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_ENCHANTMENT","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_NON_CREATURE_SPELL","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_PLANE","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_PHENOMENON","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_PLANE_OR_PHENOMENON","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_SCHEME","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_VANGUARD","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_CONSPIRACY","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_DUNGEON","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_STICKER_SHEET","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_NON_LAND","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_WHITE","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_BLUE","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_BLACK","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_RED","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_GREEN","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_COLORLESS","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_MULTICOLOR","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_MONOCOLOR","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JMethod(678,"forge/card/CardRulesPredicates","<init>","()V",1,1,1,new JHandler[]{},M678));
c.Add(new JMethod(679,"forge/card/CardRulesPredicates","cmc","(Lforge/util/ComparableOp;I)Ljava/util/function/Predicate;",9,2,5,new JHandler[]{},M679));
c.Add(new JMethod(680,"forge/card/CardRulesPredicates","cost","(Lforge/util/PredicateString$StringOp;Ljava/lang/String;)Ljava/util/function/Predicate;",9,2,5,new JHandler[]{},M680));
c.Add(new JMethod(681,"forge/card/CardRulesPredicates","power","(Lforge/util/ComparableOp;I)Ljava/util/function/Predicate;",9,2,5,new JHandler[]{},M681));
c.Add(new JMethod(682,"forge/card/CardRulesPredicates","toughness","(Lforge/util/ComparableOp;I)Ljava/util/function/Predicate;",9,2,5,new JHandler[]{},M682));
c.Add(new JMethod(683,"forge/card/CardRulesPredicates","pt","(Lforge/util/ComparableOp;I)Ljava/util/function/Predicate;",9,2,5,new JHandler[]{},M683));
c.Add(new JMethod(684,"forge/card/CardRulesPredicates","loyalty","(Lforge/util/ComparableOp;I)Ljava/util/function/Predicate;",9,2,5,new JHandler[]{},M684));
c.Add(new JMethod(685,"forge/card/CardRulesPredicates","rules","(Lforge/util/PredicateString$StringOp;Ljava/lang/String;)Ljava/util/function/Predicate;",9,2,5,new JHandler[]{},M685));
c.Add(new JMethod(686,"forge/card/CardRulesPredicates","name","(Lforge/util/PredicateString$StringOp;Ljava/lang/String;)Ljava/util/function/Predicate;",9,2,5,new JHandler[]{},M686));
c.Add(new JMethod(687,"forge/card/CardRulesPredicates","subType","(Ljava/lang/String;)Ljava/util/function/Predicate;",9,1,5,new JHandler[]{},M687));
c.Add(new JMethod(688,"forge/card/CardRulesPredicates","subType","(Lforge/util/PredicateString$StringOp;Ljava/lang/String;)Ljava/util/function/Predicate;",9,2,5,new JHandler[]{},M688));
c.Add(new JMethod(689,"forge/card/CardRulesPredicates","joinedType","(Lforge/util/PredicateString$StringOp;Ljava/lang/String;)Ljava/util/function/Predicate;",9,2,5,new JHandler[]{},M689));
c.Add(new JMethod(690,"forge/card/CardRulesPredicates","hasCreatureType","([Ljava/lang/String;)Ljava/util/function/Predicate;",137,1,1,new JHandler[]{},M690));
c.Add(new JMethod(691,"forge/card/CardRulesPredicates","hasKeyword","(Ljava/lang/String;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M691));
c.Add(new JMethod(692,"forge/card/CardRulesPredicates","deckHas","(Lforge/card/DeckHints$Type;Ljava/lang/String;)Ljava/util/function/Predicate;",9,2,2,new JHandler[]{},M692));
c.Add(new JMethod(693,"forge/card/CardRulesPredicates","deckHasExactly","(Lforge/card/DeckHints$Type;[Ljava/lang/String;)Ljava/util/function/Predicate;",9,2,2,new JHandler[]{},M693));
c.Add(new JMethod(694,"forge/card/CardRulesPredicates","coreType","(Ljava/lang/String;)Ljava/util/function/Predicate;",9,2,2,new JHandler[]{new JHandler(0,12,13,"java/lang/Exception")},M694));
c.Add(new JMethod(695,"forge/card/CardRulesPredicates","coreType","(Lforge/card/CardType$CoreType;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M695));
c.Add(new JMethod(696,"forge/card/CardRulesPredicates","superType","(Lforge/card/CardType$Supertype;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M696));
}

private static void Add1(JClass c){
c.Add(new JMethod(697,"forge/card/CardRulesPredicates","isSplitType","(Lforge/card/CardSplitType;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M697));
c.Add(new JMethod(698,"forge/card/CardRulesPredicates","isVanilla","()Ljava/util/function/Predicate;",9,0,1,new JHandler[]{},M698));
c.Add(new JMethod(699,"forge/card/CardRulesPredicates","hasColor","(B)Ljava/util/function/Predicate;",9,1,4,new JHandler[]{},M699));
c.Add(new JMethod(700,"forge/card/CardRulesPredicates","isColor","(B)Ljava/util/function/Predicate;",9,1,4,new JHandler[]{},M700));
c.Add(new JMethod(701,"forge/card/CardRulesPredicates","canCastWithAvailable","(B)Ljava/util/function/Predicate;",9,1,4,new JHandler[]{},M701));
c.Add(new JMethod(702,"forge/card/CardRulesPredicates","isMonoColor","(B)Ljava/util/function/Predicate;",9,1,4,new JHandler[]{},M702));
c.Add(new JMethod(703,"forge/card/CardRulesPredicates","hasCntColors","(B)Ljava/util/function/Predicate;",9,1,4,new JHandler[]{},M703));
c.Add(new JMethod(704,"forge/card/CardRulesPredicates","hasAtLeastCntColors","(B)Ljava/util/function/Predicate;",9,1,4,new JHandler[]{},M704));
c.Add(new JMethod(705,"forge/card/CardRulesPredicates","hasMoreCntColors","(B)Ljava/util/function/Predicate;",9,1,4,new JHandler[]{},M705));
c.Add(new JMethod(706,"forge/card/CardRulesPredicates","hasAtMostCntColors","(B)Ljava/util/function/Predicate;",9,1,4,new JHandler[]{},M706));
c.Add(new JMethod(707,"forge/card/CardRulesPredicates","hasLessCntColors","(B)Ljava/util/function/Predicate;",9,1,4,new JHandler[]{},M707));
c.Add(new JMethod(708,"forge/card/CardRulesPredicates","hasColorIdentity","(I)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M708));
c.Add(new JMethod(709,"forge/card/CardRulesPredicates","canBePartnerCommanderWith","(Lforge/card/CardRules;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M709));
c.Add(new JMethod(710,"forge/card/CardRulesPredicates","restrictionList","(Ljava/lang/String;)Ljava/util/function/Predicate;",9,9,2,new JHandler[]{},M710));
c.Add(new JMethod(711,"forge/card/CardRulesPredicates","restrictionBranch","(Ljava/lang/String;)Ljava/util/function/Predicate;",10,9,4,new JHandler[]{},M711));
c.Add(new JMethod(712,"forge/card/CardRulesPredicates","restrictionTypeWords","(Ljava/util/List;)Ljava/util/function/Predicate;",10,2,2,new JHandler[]{},M712));
c.Add(new JMethod(713,"forge/card/CardRulesPredicates","restrictionStatFilter","(Ljava/lang/String;Ljava/lang/String;I)Ljava/util/function/Predicate;",10,6,3,new JHandler[]{},M713));
c.Add(new JMethod(714,"forge/card/CardRulesPredicates","restrictionOp","(Ljava/lang/String;)Lforge/util/ComparableOp;",10,3,3,new JHandler[]{},M714));
c.Add(new JMethod(715,"forge/card/CardRulesPredicates","hasChangeling","(Lforge/card/CardRules;)Z",10,1,2,new JHandler[]{},M715));
c.Add(new JMethod(716,"forge/card/CardRulesPredicates","lambda$static$22","(Lforge/card/CardRules;)Z",4106,1,1,new JHandler[]{},M716));
c.Add(new JMethod(717,"forge/card/CardRulesPredicates","lambda$static$21","(Lforge/card/CardRules;)Z",4106,1,2,new JHandler[]{},M717));
c.Add(new JMethod(718,"forge/card/CardRulesPredicates","lambda$static$20","(Lforge/card/CardRules;)Z",4106,1,1,new JHandler[]{},M718));
c.Add(new JMethod(719,"forge/card/CardRulesPredicates","lambda$static$19","(Lforge/card/CardRules;)Z",4106,1,1,new JHandler[]{},M719));
c.Add(new JMethod(720,"forge/card/CardRulesPredicates","lambda$static$18","(Lforge/card/CardRules;)Z",4106,1,1,new JHandler[]{},M720));
c.Add(new JMethod(721,"forge/card/CardRulesPredicates","lambda$restrictionTypeWords$17","(Lforge/card/CardType;Lforge/card/CardRules;)Z",4106,5,2,new JHandler[]{},M721));
c.Add(new JMethod(722,"forge/card/CardRulesPredicates","lambda$restrictionBranch$16","(Lforge/card/CardRules;)Z",4106,1,1,new JHandler[]{},M722));
c.Add(new JMethod(723,"forge/card/CardRulesPredicates","lambda$restrictionList$15","(Lforge/card/CardRules;)Z",4106,1,1,new JHandler[]{},M723));
c.Add(new JMethod(724,"forge/card/CardRulesPredicates","lambda$canBePartnerCommanderWith$14","(Lforge/card/CardRules;Lforge/card/CardRules;)Z",4106,2,2,new JHandler[]{},M724));
c.Add(new JMethod(725,"forge/card/CardRulesPredicates","lambda$hasColorIdentity$13","(ILforge/card/CardRules;)Z",4106,2,2,new JHandler[]{},M725));
c.Add(new JMethod(726,"forge/card/CardRulesPredicates","lambda$isVanilla$12","(Lforge/card/CardRules;)Z",4106,3,2,new JHandler[]{},M726));
c.Add(new JMethod(727,"forge/card/CardRulesPredicates","lambda$isSplitType$11","(Lforge/card/CardSplitType;Lforge/card/CardRules;)Z",4106,2,2,new JHandler[]{},M727));
c.Add(new JMethod(728,"forge/card/CardRulesPredicates","lambda$superType$10","(Lforge/card/CardType$Supertype;Lforge/card/CardRules;)Z",4106,2,2,new JHandler[]{},M728));
c.Add(new JMethod(729,"forge/card/CardRulesPredicates","lambda$coreType$9","(Lforge/card/CardType$CoreType;Lforge/card/CardRules;)Z",4106,2,2,new JHandler[]{},M729));
c.Add(new JMethod(730,"forge/card/CardRulesPredicates","lambda$coreType$8","(Lforge/card/CardRules;)Z",4106,1,1,new JHandler[]{},M730));
c.Add(new JMethod(731,"forge/card/CardRulesPredicates","lambda$deckHasExactly$7","(Lforge/card/DeckHints$Type;[Ljava/lang/String;Lforge/card/CardRules;)Z",4106,4,3,new JHandler[]{},M731));
c.Add(new JMethod(732,"forge/card/CardRulesPredicates","lambda$deckHas$6","(Lforge/card/DeckHints$Type;Ljava/lang/String;Lforge/card/CardRules;)Z",4106,4,3,new JHandler[]{},M732));
c.Add(new JMethod(733,"forge/card/CardRulesPredicates","lambda$hasKeyword$5","(Ljava/lang/String;Lforge/card/CardRules;)Z",4106,2,3,new JHandler[]{},M733));
c.Add(new JMethod(734,"forge/card/CardRulesPredicates","lambda$hasKeyword$4","(Lforge/card/CardRules;Ljava/lang/String;Lforge/card/ICardFace;)Z",4106,3,3,new JHandler[]{},M734));
c.Add(new JMethod(735,"forge/card/CardRulesPredicates","lambda$hasCreatureType$3","([Ljava/lang/String;Lforge/card/CardRules;)Z",4106,2,2,new JHandler[]{},M735));
c.Add(new JMethod(736,"forge/card/CardRulesPredicates","lambda$static$2","(Lforge/card/CardRules;)Z",4106,1,1,new JHandler[]{},M736));
c.Add(new JMethod(737,"forge/card/CardRulesPredicates","lambda$static$1","(Lforge/card/CardRules;)Z",4106,1,1,new JHandler[]{},M737));
c.Add(new JMethod(738,"forge/card/CardRulesPredicates","lambda$static$0","(Lforge/card/CardRules;)Z",4106,1,1,new JHandler[]{},M738));
c.Add(new JMethod(739,"forge/card/CardRulesPredicates","<clinit>","()V",8,0,3,new JHandler[]{},M739));
}

internal static JStep M678(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M679(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafNumber"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafNumber")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","CMC","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","CMC","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafNumber","<init>","(Lforge/card/CardRulesPredicates$LeafNumber$CardField;Lforge/util/ComparableOp;I)V","invokespecial",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M680(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafString"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafString")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafString$CardField","COST","Lforge/card/CardRulesPredicates$LeafString$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafString$CardField","COST","Lforge/card/CardRulesPredicates$LeafString$CardField;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","<init>","(Lforge/card/CardRulesPredicates$LeafString$CardField;Lforge/util/PredicateString$StringOp;Ljava/lang/String;)V","invokespecial",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M681(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafNumber"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafNumber")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","POWER","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","POWER","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafNumber","<init>","(Lforge/card/CardRulesPredicates$LeafNumber$CardField;Lforge/util/ComparableOp;I)V","invokespecial",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M682(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafNumber"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafNumber")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","TOUGHNESS","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","TOUGHNESS","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafNumber","<init>","(Lforge/card/CardRulesPredicates$LeafNumber$CardField;Lforge/util/ComparableOp;I)V","invokespecial",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M683(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafNumber"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafNumber")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","PT","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","PT","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafNumber","<init>","(Lforge/card/CardRulesPredicates$LeafNumber$CardField;Lforge/util/ComparableOp;I)V","invokespecial",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M684(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafNumber"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafNumber")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","LOYALTY","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","LOYALTY","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafNumber","<init>","(Lforge/card/CardRulesPredicates$LeafNumber$CardField;Lforge/util/ComparableOp;I)V","invokespecial",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M685(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafString"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafString")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafString$CardField","ORACLE_TEXT","Lforge/card/CardRulesPredicates$LeafString$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafString$CardField","ORACLE_TEXT","Lforge/card/CardRulesPredicates$LeafString$CardField;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","<init>","(Lforge/card/CardRulesPredicates$LeafString$CardField;Lforge/util/PredicateString$StringOp;Ljava/lang/String;)V","invokespecial",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M686(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafString"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafString")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafString$CardField","NAME","Lforge/card/CardRulesPredicates$LeafString$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafString$CardField","NAME","Lforge/card/CardRulesPredicates$LeafString$CardField;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","<init>","(Lforge/card/CardRulesPredicates$LeafString$CardField;Lforge/util/PredicateString$StringOp;Ljava/lang/String;)V","invokespecial",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M687(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafString"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafString")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafString$CardField","SUBTYPE","Lforge/card/CardRulesPredicates$LeafString$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafString$CardField","SUBTYPE","Lforge/card/CardRulesPredicates$LeafString$CardField;"));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/util/PredicateString$StringOp","CONTAINS","Lforge/util/PredicateString$StringOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/PredicateString$StringOp","CONTAINS","Lforge/util/PredicateString$StringOp;"));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","<init>","(Lforge/card/CardRulesPredicates$LeafString$CardField;Lforge/util/PredicateString$StringOp;Ljava/lang/String;)V","invokespecial",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M688(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafString"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafString")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafString$CardField","SUBTYPE","Lforge/card/CardRulesPredicates$LeafString$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafString$CardField","SUBTYPE","Lforge/card/CardRulesPredicates$LeafString$CardField;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","<init>","(Lforge/card/CardRulesPredicates$LeafString$CardField;Lforge/util/PredicateString$StringOp;Ljava/lang/String;)V","invokespecial",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M689(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafString"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafString")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafString$CardField","JOINED_TYPE","Lforge/card/CardRulesPredicates$LeafString$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafString$CardField","JOINED_TYPE","Lforge/card/CardRulesPredicates$LeafString$CardField;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","<init>","(Lforge/card/CardRulesPredicates$LeafString$CardField;Lforge/util/PredicateString$StringOp;Ljava/lang/String;)V","invokespecial",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M690(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:690:1:java/lang/invoke/LambdaMetafactory.metafactory","([Ljava/lang/String;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M691(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:691:1:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M692(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:692:2:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/DeckHints$Type;Ljava/lang/String;)Ljava/util/function/Predicate;",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M693(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:693:2:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/DeckHints$Type;[Ljava/lang/String;)Ljava/util/function/Predicate;",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M694(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/CardType$CoreType")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardType$CoreType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardRulesPredicates","coreType","(Lforge/card/CardType$CoreType;)Ljava/util/function/Predicate;","invokestatic",12);}
case 12:{return JStep.Return(f.Pop());}
case 13:{f.Locals[1]=f.Pop();f.Pc=14;continue;}
case 14:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:694:14:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",19);}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M695(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:695:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardType$CoreType;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M696(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:696:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardType$Supertype;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M697(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:697:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardSplitType;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M698(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:698:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M699(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafColor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafColor")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","HasAllOf","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","HasAllOf","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor","<init>","(Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;B)V","invokespecial",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M700(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafColor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafColor")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","HasAnyOf","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","HasAnyOf","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor","<init>","(Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;B)V","invokespecial",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M701(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafColor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafColor")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CanCast","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CanCast","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor","<init>","(Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;B)V","invokespecial",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M702(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafColor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafColor")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","Equals","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","Equals","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor","<init>","(Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;B)V","invokespecial",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M703(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafColor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafColor")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColors","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColors","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor","<init>","(Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;B)V","invokespecial",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M704(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafColor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafColor")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsGreaterOrEqual","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsGreaterOrEqual","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor","<init>","(Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;B)V","invokespecial",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M705(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafColor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafColor")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsGreater","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsGreater","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor","<init>","(Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;B)V","invokespecial",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M706(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafColor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafColor")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsSmallerOrEqual","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsSmallerOrEqual","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor","<init>","(Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;B)V","invokespecial",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M707(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRulesPredicates$LeafColor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRulesPredicates$LeafColor")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsSmaller","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsSmaller","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor","<init>","(Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;B)V","invokespecial",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M708(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:708:1:java/lang/invoke/LambdaMetafactory.metafactory","(I)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M709(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:709:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardRules;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M710(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String(",")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=16;continue;}
case 16:{f.Locals[4]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{f.Locals[5]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[5]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?80:28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[5]);f.Pc=31;continue;}
case 31:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=32;continue;}
case 32:{f.Locals[6]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[6]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",39);}
case 39:{f.Locals[7]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[7]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int!=0?74:49;continue;}
case 49:{f.Push(f.Locals[7]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/card/CardRulesPredicates","restrictionBranch","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",54);}
case 54:{f.Locals[8]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Pc=f.Pop().Reference!=null?65:60;continue;}
case 60:{f.Push(f.Locals[8]);f.Pc=62;continue;}
case 62:{f.Pc=73;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[8]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",73);}
case 73:{f.Locals[1]=f.Pop();f.Pc=74;continue;}
case 74:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=77;continue;}
case 77:{f.Pc=21;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{f.Pc=f.Pop().Reference!=null?92:84;continue;}
case 84:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:710:84:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",89);}
case 89:{f.Pc=93;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M711(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("\\.")));f.Pc=11;continue;}
case 11:{f.Push(JValue.I(2));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",23);}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",33);}
case 33:{f.StackOp("pop");f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?53:40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("\\+")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",49);}
case 49:{return rt.Call(f,"java/util/Collections","addAll","(Ljava/util/Collection;[Ljava/lang/Object;)Z","invokestatic",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{f.Push(JValue.R(null));f.Pc=54;continue;}
case 54:{f.Locals[4]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",62);}
case 62:{f.Locals[5]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[5]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",71);}
case 71:{f.Pc=f.Pop().Int==0?213:74;continue;}
case 74:{f.Push(f.Locals[5]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",81);}
case 81:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=84;continue;}
case 84:{f.Locals[6]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[6]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?97:94;continue;}
case 94:{f.Pc=64;continue;}
case 97:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","RESTRICTION_STAT_FILTER","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","RESTRICTION_STAT_FILTER","Ljava/util/regex/Pattern;"));f.Pc=100;continue;}
case 100:{f.Push(f.Locals[6]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",105);}
case 105:{f.Locals[7]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[7]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",112);}
case 112:{f.Pc=f.Pop().Int==0?165:115;continue;}
case 115:{f.Push(f.Locals[7]);f.Pc=117;continue;}
case 117:{f.Push(JValue.I(1));f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",121);}
case 121:{f.Push(f.Locals[7]);f.Pc=123;continue;}
case 123:{f.Push(JValue.I(2));f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",127);}
case 127:{f.Push(f.Locals[7]);f.Pc=129;continue;}
case 129:{f.Push(JValue.I(3));f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",133);}
case 133:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",136);}
case 136:{return rt.Call(f,"forge/card/CardRulesPredicates","restrictionStatFilter","(Ljava/lang/String;Ljava/lang/String;I)Ljava/util/function/Predicate;","invokestatic",139);}
case 139:{f.Locals[8]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[4]);f.Pc=143;continue;}
case 143:{f.Pc=f.Pop().Reference!=null?151:146;continue;}
case 146:{f.Push(f.Locals[8]);f.Pc=148;continue;}
case 148:{f.Pc=160;continue;}
case 151:{f.Push(f.Locals[4]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[8]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",160);}
case 160:{f.Locals[4]=f.Pop();f.Pc=162;continue;}
case 162:{f.Pc=210;continue;}
case 165:{f.Push(f.Locals[6]);f.Pc=167;continue;}
case 167:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",172);}
case 172:{f.Pc=f.Pop().Int==0?201:175;continue;}
case 175:{f.Push(f.Locals[4]);f.Pc=177;continue;}
case 177:{f.Pc=f.Pop().Reference!=null?186:180;continue;}
case 180:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_PERMANENT","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_PERMANENT","Ljava/util/function/Predicate;"));f.Pc=183;continue;}
case 183:{f.Pc=196;continue;}
case 186:{f.Push(f.Locals[4]);f.Pc=188;continue;}
case 188:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_PERMANENT","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_PERMANENT","Ljava/util/function/Predicate;"));f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",196);}
case 196:{f.Locals[4]=f.Pop();f.Pc=198;continue;}
case 198:{f.Pc=210;continue;}
case 201:{f.Push(f.Locals[1]);f.Pc=202;continue;}
case 202:{f.Push(f.Locals[6]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",209);}
case 209:{f.StackOp("pop");f.Pc=210;continue;}
case 210:{f.Pc=64;continue;}
case 213:{f.Push(f.Locals[1]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",219);}
case 219:{f.Pc=f.Pop().Int!=0?249:222;continue;}
case 222:{f.Push(f.Locals[1]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/card/CardRulesPredicates","restrictionTypeWords","(Ljava/util/List;)Ljava/util/function/Predicate;","invokestatic",226);}
case 226:{f.Locals[5]=f.Pop();f.Pc=228;continue;}
case 228:{f.Push(f.Locals[4]);f.Pc=230;continue;}
case 230:{f.Pc=f.Pop().Reference!=null?238:233;continue;}
case 233:{f.Push(f.Locals[5]);f.Pc=235;continue;}
case 235:{f.Pc=247;continue;}
case 238:{f.Push(f.Locals[4]);f.Pc=240;continue;}
case 240:{f.Push(f.Locals[5]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",247);}
case 247:{f.Locals[4]=f.Pop();f.Pc=249;continue;}
case 249:{f.Push(f.Locals[4]);f.Pc=251;continue;}
case 251:{f.Pc=f.Pop().Reference!=null?262:254;continue;}
case 254:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:711:254:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",259);}
case 259:{f.Pc=264;continue;}
case 262:{f.Push(f.Locals[4]);f.Pc=264;continue;}
case 264:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M712(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String(" ")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","join","(Ljava/lang/CharSequence;Ljava/lang/Iterable;)Ljava/lang/String;","invokestatic",6);}
case 6:{f.Push(JValue.I(1));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardType","parse","(Ljava/lang/String;Z)Lforge/card/CardType;","invokestatic",10);}
case 10:{f.Locals[1]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:712:12:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardType;)Ljava/util/function/Predicate;",17);}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M713(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRulesPredicates","restrictionOp","(Ljava/lang/String;)Lforge/util/ComparableOp;","invokestatic",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Locals[4]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.I(-1));f.Pc=9;continue;}
case 9:{f.Locals[5]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[4]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",16);}
case 16:{switch(f.Pop().Int){case 98617:f.Pc=86;break;case 106858757:f.Pc=52;break;case 479073426:f.Pc=69;break;default:f.Pc=100;break;}continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("power")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int==0?100:63;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{f.Locals[5]=f.Pop();f.Pc=66;continue;}
case 66:{f.Pc=100;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.String("toughness")));f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",77);}
case 77:{f.Pc=f.Pop().Int==0?100:80;continue;}
case 80:{f.Push(JValue.I(1));f.Pc=81;continue;}
case 81:{f.Locals[5]=f.Pop();f.Pc=83;continue;}
case 83:{f.Pc=100;continue;}
case 86:{f.Push(f.Locals[4]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String("cmc")));f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int==0?100:97;continue;}
case 97:{f.Push(JValue.I(2));f.Pc=98;continue;}
case 98:{f.Locals[5]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[5]);f.Pc=102;continue;}
case 102:{switch(f.Pop().Int){case 0:f.Pc=128;break;case 1:f.Pc=134;break;case 2:f.Pc=140;break;default:f.Pc=146;break;}continue;}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[2]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/card/CardRulesPredicates","power","(Lforge/util/ComparableOp;I)Ljava/util/function/Predicate;","invokestatic",133);}
case 133:{return JStep.Return(f.Pop());}
case 134:{f.Push(f.Locals[3]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[2]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/card/CardRulesPredicates","toughness","(Lforge/util/ComparableOp;I)Ljava/util/function/Predicate;","invokestatic",139);}
case 139:{return JStep.Return(f.Pop());}
case 140:{f.Push(f.Locals[3]);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[2]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/card/CardRulesPredicates","cmc","(Lforge/util/ComparableOp;I)Ljava/util/function/Predicate;","invokestatic",145);}
case 145:{return JStep.Return(f.Pop());}
case 146:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=149;continue;}
case 149:{f.StackOp("dup");f.Pc=150;continue;}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:713:151:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",156);}
case 156:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",159);}
case 159:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M714(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(JValue.I(-1));f.Pc=3;continue;}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",8);}
case 8:{switch(f.Pop().Int){case 2220:f.Pc=68;break;case 2270:f.Pc=128;break;case 2285:f.Pc=98;break;case 2425:f.Pc=143;break;case 2440:f.Pc=113;break;case 2487:f.Pc=83;break;default:f.Pc=155;break;}continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("EQ")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",75);}
case 75:{f.Pc=f.Pop().Int==0?155:78;continue;}
case 78:{f.Push(JValue.I(0));f.Pc=79;continue;}
case 79:{f.Locals[2]=f.Pop();f.Pc=80;continue;}
case 80:{f.Pc=155;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String("NE")));f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?155:93;continue;}
case 93:{f.Push(JValue.I(1));f.Pc=94;continue;}
case 94:{f.Locals[2]=f.Pop();f.Pc=95;continue;}
case 95:{f.Pc=155;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String("GT")));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Int==0?155:108;continue;}
case 108:{f.Push(JValue.I(2));f.Pc=109;continue;}
case 109:{f.Locals[2]=f.Pop();f.Pc=110;continue;}
case 110:{f.Pc=155;continue;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.String("LT")));f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",120);}
case 120:{f.Pc=f.Pop().Int==0?155:123;continue;}
case 123:{f.Push(JValue.I(3));f.Pc=124;continue;}
case 124:{f.Locals[2]=f.Pop();f.Pc=125;continue;}
case 125:{f.Pc=155;continue;}
case 128:{f.Push(f.Locals[1]);f.Pc=129;continue;}
case 129:{f.Push(JValue.R(rt.String("GE")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",135);}
case 135:{f.Pc=f.Pop().Int==0?155:138;continue;}
case 138:{f.Push(JValue.I(4));f.Pc=139;continue;}
case 139:{f.Locals[2]=f.Pop();f.Pc=140;continue;}
case 140:{f.Pc=155;continue;}
case 143:{f.Push(f.Locals[1]);f.Pc=144;continue;}
case 144:{f.Push(JValue.R(rt.String("LE")));f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",150);}
case 150:{f.Pc=f.Pop().Int==0?155:153;continue;}
case 153:{f.Push(JValue.I(5));f.Pc=154;continue;}
case 154:{f.Locals[2]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[2]);f.Pc=156;continue;}
case 156:{switch(f.Pop().Int){case 0:f.Pc=196;break;case 1:f.Pc=200;break;case 2:f.Pc=204;break;case 3:f.Pc=208;break;case 4:f.Pc=212;break;case 5:f.Pc=216;break;default:f.Pc=220;break;}continue;}
case 196:{if(!rt.StaticReady(f,"forge/util/ComparableOp","EQUALS","Lforge/util/ComparableOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/ComparableOp","EQUALS","Lforge/util/ComparableOp;"));f.Pc=199;continue;}
case 199:{return JStep.Return(f.Pop());}
case 200:{if(!rt.StaticReady(f,"forge/util/ComparableOp","NOT_EQUALS","Lforge/util/ComparableOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/ComparableOp","NOT_EQUALS","Lforge/util/ComparableOp;"));f.Pc=203;continue;}
case 203:{return JStep.Return(f.Pop());}
case 204:{if(!rt.StaticReady(f,"forge/util/ComparableOp","GREATER_THAN","Lforge/util/ComparableOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/ComparableOp","GREATER_THAN","Lforge/util/ComparableOp;"));f.Pc=207;continue;}
case 207:{return JStep.Return(f.Pop());}
case 208:{if(!rt.StaticReady(f,"forge/util/ComparableOp","LESS_THAN","Lforge/util/ComparableOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/ComparableOp","LESS_THAN","Lforge/util/ComparableOp;"));f.Pc=211;continue;}
case 211:{return JStep.Return(f.Pop());}
case 212:{if(!rt.StaticReady(f,"forge/util/ComparableOp","GT_OR_EQUAL","Lforge/util/ComparableOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/ComparableOp","GT_OR_EQUAL","Lforge/util/ComparableOp;"));f.Pc=215;continue;}
case 215:{return JStep.Return(f.Pop());}
case 216:{if(!rt.StaticReady(f,"forge/util/ComparableOp","LT_OR_EQUAL","Lforge/util/ComparableOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/ComparableOp","LT_OR_EQUAL","Lforge/util/ComparableOp;"));f.Pc=219;continue;}
case 219:{return JStep.Return(f.Pop());}
case 220:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=223;continue;}
case 223:{f.StackOp("dup");f.Pc=224;continue;}
case 224:{f.Push(f.Locals[0]);f.Pc=225;continue;}
case 225:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:714:225:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",230);}
case 230:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",233);}
case 233:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M715(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Changeling")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/CardRulesPredicates","hasKeyword","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M716(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardType","isLand","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?24:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/card/CardType","isBasicLand","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int!=0?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M717(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.String("Wastes")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int!=0?27:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",17);}
case 17:{return rt.Call(f,"forge/card/CardType","isBasicLand","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?27:23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Pc=28;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M718(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardType","isBasicLand","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?14:10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Pc=15;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M719(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardType","isBasicLand","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M720(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardType","isPermanent","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M721(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/CardType","getCoreTypes","()Ljava/util/Collection;","invokevirtual",9);}
case 9:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?49:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardType$CoreType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/card/CardType","hasType","(Lforge/card/CardType$CoreType;)Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int!=0?46:44;continue;}
case 44:{f.Push(JValue.I(0));f.Pc=45;continue;}
case 45:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 46:{f.Pc=15;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/card/CardType","getSupertypes","()Ljava/util/Collection;","invokevirtual",53);}
case 53:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",58);}
case 58:{f.Locals[3]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",65);}
case 65:{f.Pc=f.Pop().Int==0?93:68;continue;}
case 68:{f.Push(f.Locals[3]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",74);}
case 74:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardType$Supertype"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=77;continue;}
case 77:{f.Locals[4]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[4]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/card/CardType","hasSupertype","(Lforge/card/CardType$Supertype;)Z","invokevirtual",85);}
case 85:{f.Pc=f.Pop().Int!=0?90:88;continue;}
case 88:{f.Push(JValue.I(0));f.Pc=89;continue;}
case 89:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 90:{f.Pc=59;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/card/CardType","getSubtypes","()Ljava/util/Collection;","invokevirtual",97);}
case 97:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",102);}
case 102:{f.Locals[3]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[3]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",109);}
case 109:{f.Pc=f.Pop().Int==0?152:112;continue;}
case 112:{f.Push(f.Locals[3]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",118);}
case 118:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=121;continue;}
case 121:{f.Locals[4]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[2]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[4]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",129);}
case 129:{f.Pc=f.Pop().Int!=0?149:132;continue;}
case 132:{f.Push(f.Locals[4]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/card/CardType","isACreatureType","(Ljava/lang/String;)Z","invokestatic",137);}
case 137:{f.Pc=f.Pop().Int==0?147:140;continue;}
case 140:{f.Push(f.Locals[1]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/card/CardRulesPredicates","hasChangeling","(Lforge/card/CardRules;)Z","invokestatic",144);}
case 144:{f.Pc=f.Pop().Int!=0?149:147;continue;}
case 147:{f.Push(JValue.I(0));f.Pc=148;continue;}
case 148:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 149:{f.Pc=103;continue;}
case 152:{f.Push(JValue.I(1));f.Pc=153;continue;}
case 153:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M722(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M723(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M724(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardRules","canBePartnerCommanders","(Lforge/card/CardRules;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M725(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getColorIdentity","()Lforge/card/ColorSet;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/ColorSet","hasNoColorsExcept","(I)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M726(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardType","isCreature","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?20:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/card/CardType","isLand","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?37:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/card/CardRules","getSplitType","()Lforge/card/CardSplitType;","invokevirtual",24);}
case 24:{if(!rt.StaticReady(f,"forge/card/CardSplitType","None","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","None","Lforge/card/CardSplitType;"));f.Pc=27;continue;}
case 27:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?37:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/card/CardRules","hasFunctionalVariants","()Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?39:37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/card/CardRules","getMainPart","()Lforge/card/ICardFace;","invokevirtual",43);}
case 43:{f.Locals[1]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/card/ICardFace","getKeywords","()Ljava/lang/Iterable;","invokeinterface",50);}
case 50:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",55);}
case 55:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",60);}
case 60:{f.Pc=f.Pop().Int!=0?167:63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/card/ICardFace","getAbilities","()Ljava/lang/Iterable;","invokeinterface",69);}
case 69:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",74);}
case 74:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",79);}
case 79:{f.Pc=f.Pop().Int!=0?167:82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/card/ICardFace","getStaticAbilities","()Ljava/lang/Iterable;","invokeinterface",88);}
case 88:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",93);}
case 93:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",98);}
case 98:{f.Pc=f.Pop().Int!=0?167:101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/card/ICardFace","getTriggers","()Ljava/lang/Iterable;","invokeinterface",107);}
case 107:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",112);}
case 112:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",117);}
case 117:{f.Pc=f.Pop().Int!=0?167:120;continue;}
case 120:{f.Push(f.Locals[1]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/card/ICardFace","getDraftActions","()Ljava/lang/Iterable;","invokeinterface",126);}
case 126:{f.Pc=f.Pop().Reference==null?148:129;continue;}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/card/ICardFace","getDraftActions","()Ljava/lang/Iterable;","invokeinterface",135);}
case 135:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",140);}
case 140:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",145);}
case 145:{f.Pc=f.Pop().Int!=0?167:148;continue;}
case 148:{f.Push(f.Locals[1]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/card/ICardFace","getReplacements","()Ljava/lang/Iterable;","invokeinterface",154);}
case 154:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",159);}
case 159:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",164);}
case 164:{f.Pc=f.Pop().Int==0?171:167;continue;}
case 167:{f.Push(JValue.I(1));f.Pc=168;continue;}
case 168:{f.Pc=172;continue;}
case 171:{f.Push(JValue.I(0));f.Pc=172;continue;}
case 172:{f.Locals[2]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[2]);f.Pc=174;continue;}
case 174:{f.Pc=f.Pop().Int!=0?181:177;continue;}
case 177:{f.Push(JValue.I(1));f.Pc=178;continue;}
case 178:{f.Pc=182;continue;}
case 181:{f.Push(JValue.I(0));f.Pc=182;continue;}
case 182:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M727(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getSplitType","()Lforge/card/CardSplitType;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardSplitType","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M728(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardType","hasSupertype","(Lforge/card/CardType$Supertype;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M729(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardType","hasType","(Lforge/card/CardType$CoreType;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M730(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M731(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getAiHints","()Lforge/card/CardAiHints;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardAiHints","getDeckHas","()Lforge/card/DeckHints;","invokevirtual",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference==null?32:12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/DeckHints","isValid","()Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?32:19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/card/DeckHints","is","(Lforge/card/DeckHints$Type;[Ljava/lang/String;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?32:28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{f.Pc=33;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M732(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getAiHints","()Lforge/card/CardAiHints;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardAiHints","getDeckHas","()Lforge/card/DeckHints;","invokevirtual",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference==null?32:12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/DeckHints","isValid","()Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?32:19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/card/DeckHints","contains","(Lforge/card/DeckHints$Type;Ljava/lang/String;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?32:28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{f.Pc=33;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M733(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getAllFaces","()Ljava/util/List;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:733:6:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardRules;Ljava/lang/String;)Ljava/util/function/Predicate;",11);}
case 11:{return rt.Call(f,"forge/util/IterableUtil","any","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Z","invokestatic",14);}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M734(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/CardRules","hasStartOfKeyword","(Ljava/lang/String;Lforge/card/ICardFace;)Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M735(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardType","isCreature","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?12:10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/card/CardType","getCreatureTypes","()Ljava/util/Set;","invokevirtual",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",23);}
case 23:{return rt.Call(f,"java/util/Collections","disjoint","(Ljava/util/Collection;Ljava/util/Collection;)Z","invokestatic",26);}
case 26:{f.Pc=f.Pop().Int!=0?33:29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{f.Pc=34;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M736(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardAiHints","isRemovedFromRandomDecks","(Lforge/card/CardRules;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int!=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M737(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardAiHints","isRemovedFromAiDecks","(Lforge/card/CardRules;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int!=0?21:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardRules","getAiHints","()Lforge/card/CardAiHints;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/card/CardAiHints","getRemNonCommanderDecks","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int!=0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M738(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardAiHints","isRemovedFromAiDecks","(Lforge/card/CardRules;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int!=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M739(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:739:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",5);}
case 5:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_KEPT_IN_AI_DECKS","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_KEPT_IN_AI_DECKS","Ljava/util/function/Predicate;",f.Pop());f.Pc=8;continue;}
case 8:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:739:8:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",13);}
case 13:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_KEPT_IN_AI_LIMITED_DECKS","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_KEPT_IN_AI_LIMITED_DECKS","Ljava/util/function/Predicate;",f.Pop());f.Pc=16;continue;}
case 16:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:739:16:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",21);}
case 21:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_KEPT_IN_RANDOM_DECKS","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_KEPT_IN_RANDOM_DECKS","Ljava/util/function/Predicate;",f.Pop());f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("^(power|toughness|cmc)(EQ|NE|GT|LT|GE|LE)(\\d+)$")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",30);}
case 30:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","RESTRICTION_STAT_FILTER","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","RESTRICTION_STAT_FILTER","Ljava/util/regex/Pattern;",f.Pop());f.Pc=33;continue;}
case 33:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:739:33:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",38);}
case 38:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_PERMANENT","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_PERMANENT","Ljava/util/function/Predicate;",f.Pop());f.Pc=41;continue;}
case 41:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Creature","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Creature","Lforge/card/CardType$CoreType;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/card/CardRulesPredicates","coreType","(Lforge/card/CardType$CoreType;)Ljava/util/function/Predicate;","invokestatic",47);}
case 47:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_CREATURE","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_CREATURE","Ljava/util/function/Predicate;",f.Pop());f.Pc=50;continue;}
case 50:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","Legendary","Lforge/card/CardType$Supertype;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Supertype","Legendary","Lforge/card/CardType$Supertype;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/card/CardRulesPredicates","superType","(Lforge/card/CardType$Supertype;)Ljava/util/function/Predicate;","invokestatic",56);}
case 56:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_LEGENDARY","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_LEGENDARY","Ljava/util/function/Predicate;",f.Pop());f.Pc=59;continue;}
case 59:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Artifact","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Artifact","Lforge/card/CardType$CoreType;"));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/card/CardRulesPredicates","coreType","(Lforge/card/CardType$CoreType;)Ljava/util/function/Predicate;","invokestatic",65);}
case 65:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_ARTIFACT","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_ARTIFACT","Ljava/util/function/Predicate;",f.Pop());f.Pc=68;continue;}
case 68:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_ARTIFACT","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_ARTIFACT","Ljava/util/function/Predicate;"));f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.String("Attraction")));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/card/CardRulesPredicates","subType","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",77);}
case 77:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",82);}
case 82:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_ATTRACTION","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_ATTRACTION","Ljava/util/function/Predicate;",f.Pop());f.Pc=85;continue;}
case 85:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_ARTIFACT","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_ARTIFACT","Ljava/util/function/Predicate;"));f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String("Contraption")));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/card/CardRulesPredicates","subType","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",94);}
case 94:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",99);}
case 99:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_CONTRAPTION","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_CONTRAPTION","Ljava/util/function/Predicate;",f.Pop());f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String("Equipment")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/card/CardRulesPredicates","subType","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",108);}
case 108:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_EQUIPMENT","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_EQUIPMENT","Ljava/util/function/Predicate;",f.Pop());f.Pc=111;continue;}
case 111:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Land","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Land","Lforge/card/CardType$CoreType;"));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/card/CardRulesPredicates","coreType","(Lforge/card/CardType$CoreType;)Ljava/util/function/Predicate;","invokestatic",117);}
case 117:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_LAND","Ljava/util/function/Predicate;",f.Pop());f.Pc=120;continue;}
case 120:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:739:120:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",125);}
case 125:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_BASIC_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_BASIC_LAND","Ljava/util/function/Predicate;",f.Pop());f.Pc=128;continue;}
case 128:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:739:128:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",133);}
case 133:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","NOT_BASIC_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","NOT_BASIC_LAND","Ljava/util/function/Predicate;",f.Pop());f.Pc=136;continue;}
case 136:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:739:136:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",141);}
case 141:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_TRUE_BASIC_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_TRUE_BASIC_LAND","Ljava/util/function/Predicate;",f.Pop());f.Pc=144;continue;}
case 144:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:739:144:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",149);}
case 149:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_NONBASIC_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_NONBASIC_LAND","Ljava/util/function/Predicate;",f.Pop());f.Pc=152;continue;}
case 152:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:739:152:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",157);}
case 157:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","CAN_BE_COMMANDER","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","CAN_BE_COMMANDER","Ljava/util/function/Predicate;",f.Pop());f.Pc=160;continue;}
case 160:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:739:160:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",165);}
case 165:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","CAN_BE_PARTNER_COMMANDER","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","CAN_BE_PARTNER_COMMANDER","Ljava/util/function/Predicate;",f.Pop());f.Pc=168;continue;}
case 168:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:739:168:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",173);}
case 173:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","CAN_BE_OATHBREAKER","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","CAN_BE_OATHBREAKER","Ljava/util/function/Predicate;",f.Pop());f.Pc=176;continue;}
case 176:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:739:176:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",181);}
case 181:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","CAN_BE_SIGNATURE_SPELL","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","CAN_BE_SIGNATURE_SPELL","Ljava/util/function/Predicate;",f.Pop());f.Pc=184;continue;}
case 184:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Planeswalker","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Planeswalker","Lforge/card/CardType$CoreType;"));f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/card/CardRulesPredicates","coreType","(Lforge/card/CardType$CoreType;)Ljava/util/function/Predicate;","invokestatic",190);}
case 190:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_PLANESWALKER","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_PLANESWALKER","Ljava/util/function/Predicate;",f.Pop());f.Pc=193;continue;}
case 193:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_LEGENDARY","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_LEGENDARY","Ljava/util/function/Predicate;"));f.Pc=196;continue;}
case 196:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_CREATURE","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_CREATURE","Ljava/util/function/Predicate;"));f.Pc=199;continue;}
case 199:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_PLANESWALKER","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_PLANESWALKER","Ljava/util/function/Predicate;"));f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",207);}
case 207:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",212);}
case 212:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","CAN_BE_TINY_LEADERS_COMMANDER","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","CAN_BE_TINY_LEADERS_COMMANDER","Ljava/util/function/Predicate;",f.Pop());f.Pc=215;continue;}
case 215:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_LEGENDARY","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_LEGENDARY","Ljava/util/function/Predicate;"));f.Pc=218;continue;}
case 218:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_CREATURE","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_CREATURE","Ljava/util/function/Predicate;"));f.Pc=221;continue;}
case 221:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_PLANESWALKER","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_PLANESWALKER","Ljava/util/function/Predicate;"));f.Pc=224;continue;}
case 224:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",229);}
case 229:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",234);}
case 234:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","CAN_BE_BRAWL_COMMANDER","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","CAN_BE_BRAWL_COMMANDER","Ljava/util/function/Predicate;",f.Pop());f.Pc=237;continue;}
case 237:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Battle","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Battle","Lforge/card/CardType$CoreType;"));f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/card/CardRulesPredicates","coreType","(Lforge/card/CardType$CoreType;)Ljava/util/function/Predicate;","invokestatic",243);}
case 243:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_BATTLE","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_BATTLE","Ljava/util/function/Predicate;",f.Pop());f.Pc=246;continue;}
case 246:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Instant","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Instant","Lforge/card/CardType$CoreType;"));f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/card/CardRulesPredicates","coreType","(Lforge/card/CardType$CoreType;)Ljava/util/function/Predicate;","invokestatic",252);}
case 252:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_INSTANT","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_INSTANT","Ljava/util/function/Predicate;",f.Pop());f.Pc=255;continue;}
case 255:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Sorcery","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Sorcery","Lforge/card/CardType$CoreType;"));f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/card/CardRulesPredicates","coreType","(Lforge/card/CardType$CoreType;)Ljava/util/function/Predicate;","invokestatic",261);}
case 261:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_SORCERY","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_SORCERY","Ljava/util/function/Predicate;",f.Pop());f.Pc=264;continue;}
case 264:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Enchantment","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Enchantment","Lforge/card/CardType$CoreType;"));f.Pc=267;continue;}
case 267:{return rt.Call(f,"forge/card/CardRulesPredicates","coreType","(Lforge/card/CardType$CoreType;)Ljava/util/function/Predicate;","invokestatic",270);}
case 270:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_ENCHANTMENT","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_ENCHANTMENT","Ljava/util/function/Predicate;",f.Pop());f.Pc=273;continue;}
case 273:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_CREATURE","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_CREATURE","Ljava/util/function/Predicate;"));f.Pc=276;continue;}
case 276:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_LAND","Ljava/util/function/Predicate;"));f.Pc=279;continue;}
case 279:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",284);}
case 284:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates:739:284:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",289);}
case 289:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",294);}
case 294:{return rt.Call(f,"java/util/function/Predicate","not","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",297);}
case 297:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_NON_CREATURE_SPELL","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_NON_CREATURE_SPELL","Ljava/util/function/Predicate;",f.Pop());f.Pc=300;continue;}
case 300:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Plane","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Plane","Lforge/card/CardType$CoreType;"));f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/card/CardRulesPredicates","coreType","(Lforge/card/CardType$CoreType;)Ljava/util/function/Predicate;","invokestatic",306);}
case 306:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_PLANE","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_PLANE","Ljava/util/function/Predicate;",f.Pop());f.Pc=309;continue;}
case 309:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Phenomenon","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Phenomenon","Lforge/card/CardType$CoreType;"));f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/card/CardRulesPredicates","coreType","(Lforge/card/CardType$CoreType;)Ljava/util/function/Predicate;","invokestatic",315);}
case 315:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_PHENOMENON","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_PHENOMENON","Ljava/util/function/Predicate;",f.Pop());f.Pc=318;continue;}
case 318:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_PLANE","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_PLANE","Ljava/util/function/Predicate;"));f.Pc=321;continue;}
case 321:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_PHENOMENON","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_PHENOMENON","Ljava/util/function/Predicate;"));f.Pc=324;continue;}
case 324:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",329);}
case 329:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_PLANE_OR_PHENOMENON","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_PLANE_OR_PHENOMENON","Ljava/util/function/Predicate;",f.Pop());f.Pc=332;continue;}
case 332:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Scheme","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Scheme","Lforge/card/CardType$CoreType;"));f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/card/CardRulesPredicates","coreType","(Lforge/card/CardType$CoreType;)Ljava/util/function/Predicate;","invokestatic",338);}
case 338:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_SCHEME","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_SCHEME","Ljava/util/function/Predicate;",f.Pop());f.Pc=341;continue;}
case 341:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Vanguard","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Vanguard","Lforge/card/CardType$CoreType;"));f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/card/CardRulesPredicates","coreType","(Lforge/card/CardType$CoreType;)Ljava/util/function/Predicate;","invokestatic",347);}
case 347:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_VANGUARD","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_VANGUARD","Ljava/util/function/Predicate;",f.Pop());f.Pc=350;continue;}
case 350:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Conspiracy","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Conspiracy","Lforge/card/CardType$CoreType;"));f.Pc=353;continue;}
case 353:{return rt.Call(f,"forge/card/CardRulesPredicates","coreType","(Lforge/card/CardType$CoreType;)Ljava/util/function/Predicate;","invokestatic",356);}
case 356:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_CONSPIRACY","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_CONSPIRACY","Ljava/util/function/Predicate;",f.Pop());f.Pc=359;continue;}
case 359:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Dungeon","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Dungeon","Lforge/card/CardType$CoreType;"));f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/card/CardRulesPredicates","coreType","(Lforge/card/CardType$CoreType;)Ljava/util/function/Predicate;","invokestatic",365);}
case 365:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_DUNGEON","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_DUNGEON","Ljava/util/function/Predicate;",f.Pop());f.Pc=368;continue;}
case 368:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Stickers","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Stickers","Lforge/card/CardType$CoreType;"));f.Pc=371;continue;}
case 371:{return rt.Call(f,"forge/card/CardRulesPredicates","coreType","(Lforge/card/CardType$CoreType;)Ljava/util/function/Predicate;","invokestatic",374);}
case 374:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_STICKER_SHEET","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_STICKER_SHEET","Ljava/util/function/Predicate;",f.Pop());f.Pc=377;continue;}
case 377:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Land","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Land","Lforge/card/CardType$CoreType;"));f.Pc=380;continue;}
case 380:{return rt.Call(f,"forge/card/CardRulesPredicates","coreType","(Lforge/card/CardType$CoreType;)Ljava/util/function/Predicate;","invokestatic",383);}
case 383:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_NON_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_NON_LAND","Ljava/util/function/Predicate;",f.Pop());f.Pc=386;continue;}
case 386:{f.Push(JValue.I(1));f.Pc=387;continue;}
case 387:{return rt.Call(f,"forge/card/CardRulesPredicates","isColor","(B)Ljava/util/function/Predicate;","invokestatic",390);}
case 390:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_WHITE","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_WHITE","Ljava/util/function/Predicate;",f.Pop());f.Pc=393;continue;}
case 393:{f.Push(JValue.I(2));f.Pc=394;continue;}
case 394:{return rt.Call(f,"forge/card/CardRulesPredicates","isColor","(B)Ljava/util/function/Predicate;","invokestatic",397);}
case 397:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_BLUE","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_BLUE","Ljava/util/function/Predicate;",f.Pop());f.Pc=400;continue;}
case 400:{f.Push(JValue.I(4));f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/card/CardRulesPredicates","isColor","(B)Ljava/util/function/Predicate;","invokestatic",404);}
case 404:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_BLACK","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_BLACK","Ljava/util/function/Predicate;",f.Pop());f.Pc=407;continue;}
case 407:{f.Push(JValue.I(8));f.Pc=409;continue;}
case 409:{return rt.Call(f,"forge/card/CardRulesPredicates","isColor","(B)Ljava/util/function/Predicate;","invokestatic",412);}
case 412:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_RED","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_RED","Ljava/util/function/Predicate;",f.Pop());f.Pc=415;continue;}
case 415:{f.Push(JValue.I(16));f.Pc=417;continue;}
case 417:{return rt.Call(f,"forge/card/CardRulesPredicates","isColor","(B)Ljava/util/function/Predicate;","invokestatic",420);}
case 420:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_GREEN","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_GREEN","Ljava/util/function/Predicate;",f.Pop());f.Pc=423;continue;}
case 423:{f.Push(JValue.I(0));f.Pc=424;continue;}
case 424:{return rt.Call(f,"forge/card/CardRulesPredicates","hasCntColors","(B)Ljava/util/function/Predicate;","invokestatic",427);}
case 427:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_COLORLESS","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_COLORLESS","Ljava/util/function/Predicate;",f.Pop());f.Pc=430;continue;}
case 430:{f.Push(JValue.I(2));f.Pc=431;continue;}
case 431:{return rt.Call(f,"forge/card/CardRulesPredicates","hasAtLeastCntColors","(B)Ljava/util/function/Predicate;","invokestatic",434);}
case 434:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_MULTICOLOR","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_MULTICOLOR","Ljava/util/function/Predicate;",f.Pop());f.Pc=437;continue;}
case 437:{f.Push(JValue.I(1));f.Pc=438;continue;}
case 438:{return rt.Call(f,"forge/card/CardRulesPredicates","hasCntColors","(B)Ljava/util/function/Predicate;","invokestatic",441);}
case 441:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_MONOCOLOR","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates","IS_MONOCOLOR","Ljava/util/function/Predicate;",f.Pop());f.Pc=444;continue;}
case 444:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C89{
internal static JClass Build(){var c=new JClass("forge/deck/DeckFormat","java/lang/Enum",new string[]{},16417);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("Constructed","Lforge/deck/DeckFormat;",true,JValue.Default("Lforge/deck/DeckFormat;"),null));
c.Add(new JField("QuestDeck","Lforge/deck/DeckFormat;",true,JValue.Default("Lforge/deck/DeckFormat;"),null));
c.Add(new JField("Limited","Lforge/deck/DeckFormat;",true,JValue.Default("Lforge/deck/DeckFormat;"),null));
c.Add(new JField("Commander","Lforge/deck/DeckFormat;",true,JValue.Default("Lforge/deck/DeckFormat;"),null));
c.Add(new JField("CommanderDraft","Lforge/deck/DeckFormat;",true,JValue.Default("Lforge/deck/DeckFormat;"),null));
c.Add(new JField("Oathbreaker","Lforge/deck/DeckFormat;",true,JValue.Default("Lforge/deck/DeckFormat;"),null));
c.Add(new JField("Pauper","Lforge/deck/DeckFormat;",true,JValue.Default("Lforge/deck/DeckFormat;"),null));
c.Add(new JField("Brawl","Lforge/deck/DeckFormat;",true,JValue.Default("Lforge/deck/DeckFormat;"),null));
c.Add(new JField("TinyLeaders","Lforge/deck/DeckFormat;",true,JValue.Default("Lforge/deck/DeckFormat;"),null));
c.Add(new JField("PlanarConquest","Lforge/deck/DeckFormat;",true,JValue.Default("Lforge/deck/DeckFormat;"),null));
c.Add(new JField("Adventure","Lforge/deck/DeckFormat;",true,JValue.Default("Lforge/deck/DeckFormat;"),null));
c.Add(new JField("Vanguard","Lforge/deck/DeckFormat;",true,JValue.Default("Lforge/deck/DeckFormat;"),null));
c.Add(new JField("Planechase","Lforge/deck/DeckFormat;",true,JValue.Default("Lforge/deck/DeckFormat;"),null));
c.Add(new JField("Archenemy","Lforge/deck/DeckFormat;",true,JValue.Default("Lforge/deck/DeckFormat;"),null));
c.Add(new JField("Puzzle","Lforge/deck/DeckFormat;",true,JValue.Default("Lforge/deck/DeckFormat;"),null));
c.Add(new JField("CHOSEN_STICKER_SHEETS","I",true,JValue.I(3),null));
c.Add(new JField("mainRange","Lorg/apache/commons/lang3/Range;",false,JValue.Default("Lorg/apache/commons/lang3/Range;"),null));
c.Add(new JField("sideRange","Lorg/apache/commons/lang3/Range;",false,JValue.Default("Lorg/apache/commons/lang3/Range;"),null));
c.Add(new JField("maxCardCopies","I",false,JValue.Default("I"),null));
c.Add(new JField("cardPoolFilter","Ljava/util/function/Predicate;",false,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("paperCardPoolFilter","Ljava/util/function/Predicate;",false,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("ADVPROCLAMATION","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"Advantageous Proclamation"));
c.Add(new JField("$VALUES","[Lforge/deck/DeckFormat;",true,JValue.Default("[Lforge/deck/DeckFormat;"),null));
c.Add(new JMethod(1421,"forge/deck/DeckFormat","values","()[Lforge/deck/DeckFormat;",9,0,1,new JHandler[]{},M1421));
c.Add(new JMethod(1422,"forge/deck/DeckFormat","valueOf","(Ljava/lang/String;)Lforge/deck/DeckFormat;",9,1,2,new JHandler[]{},M1422));
c.Add(new JMethod(1423,"forge/deck/DeckFormat","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;ILjava/util/function/Predicate;Ljava/util/function/Predicate;)V",2,8,3,new JHandler[]{},M1423));
c.Add(new JMethod(1424,"forge/deck/DeckFormat","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;ILjava/util/function/Predicate;)V",2,7,3,new JHandler[]{},M1424));
c.Add(new JMethod(1425,"forge/deck/DeckFormat","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;I)V",2,6,3,new JHandler[]{},M1425));
c.Add(new JMethod(1426,"forge/deck/DeckFormat","hasCommander","()Z",1,1,2,new JHandler[]{},M1426));
c.Add(new JMethod(1427,"forge/deck/DeckFormat","hasSignatureSpell","()Z",1,1,2,new JHandler[]{},M1427));
c.Add(new JMethod(1428,"forge/deck/DeckFormat","smartValueOf","(Ljava/lang/String;Lforge/deck/DeckFormat;)Lforge/deck/DeckFormat;",9,7,3,new JHandler[]{},M1428));
c.Add(new JMethod(1429,"forge/deck/DeckFormat","getSideRange","()Lorg/apache/commons/lang3/Range;",1,1,1,new JHandler[]{},M1429));
c.Add(new JMethod(1430,"forge/deck/DeckFormat","getMainRange","()Lorg/apache/commons/lang3/Range;",1,1,1,new JHandler[]{},M1430));
c.Add(new JMethod(1431,"forge/deck/DeckFormat","getMaxCardCopies","()I",1,1,1,new JHandler[]{},M1431));
c.Add(new JMethod(1432,"forge/deck/DeckFormat","getMaxCardCopies","(Lforge/item/PaperCard;)I",1,3,2,new JHandler[]{},M1432));
c.Add(new JMethod(1433,"forge/deck/DeckFormat","getExtraSectionMaxCopies","(Lforge/deck/DeckSection;)I",1,2,2,new JHandler[]{},M1433));
c.Add(new JMethod(1434,"forge/deck/DeckFormat","getPrimaryDeckSections","()Ljava/util/EnumSet;",1,2,2,new JHandler[]{},M1434));
c.Add(new JMethod(1435,"forge/deck/DeckFormat","getDeckConformanceProblem","(Lforge/deck/Deck;)Ljava/lang/String;",1,14,4,new JHandler[]{},M1435));
c.Add(new JMethod(1436,"forge/deck/DeckFormat","getCommanderConformanceProblem","(Lforge/deck/Deck;)Ljava/lang/String;",1,7,3,new JHandler[]{},M1436));
c.Add(new JMethod(1437,"forge/deck/DeckFormat","getCommanderConformanceProblem","(Lforge/deck/Deck;Ljava/util/List;)Ljava/lang/String;",2,10,3,new JHandler[]{},M1437));
c.Add(new JMethod(1438,"forge/deck/DeckFormat","allowsOffColorIdentity","(Ljava/util/List;Lforge/card/CardRules;)Z",9,4,2,new JHandler[]{},M1438));
c.Add(new JMethod(1439,"forge/deck/DeckFormat","approvesAdditionalColor","(Ljava/util/List;Lforge/card/CardRules;B)Z",9,5,3,new JHandler[]{},M1439));
c.Add(new JMethod(1440,"forge/deck/DeckFormat","getAttractionDeckConformanceProblem","(Lforge/deck/Deck;)Ljava/lang/String;",1,5,4,new JHandler[]{},M1440));
c.Add(new JMethod(1441,"forge/deck/DeckFormat","getStickerSheetConformanceProblem","(Lforge/deck/Deck;)Ljava/lang/String;",1,5,4,new JHandler[]{},M1441));
c.Add(new JMethod(1442,"forge/deck/DeckFormat","getContraptionDeckConformanceProblem","(Lforge/deck/Deck;)Ljava/lang/String;",1,5,4,new JHandler[]{},M1442));
c.Add(new JMethod(1443,"forge/deck/DeckFormat","canHaveAnyNumberOf","(Lforge/item/IPaperCard;)Z",9,1,2,new JHandler[]{},M1443));
c.Add(new JMethod(1444,"forge/deck/DeckFormat","canHaveSpecificNumberInDeck","(Lforge/item/IPaperCard;)Ljava/lang/Integer;",9,1,2,new JHandler[]{},M1444));
c.Add(new JMethod(1445,"forge/deck/DeckFormat","getPlaneSectionConformanceProblem","(Lforge/deck/CardPool;)Ljava/lang/String;",9,4,2,new JHandler[]{},M1445));
c.Add(new JMethod(1446,"forge/deck/DeckFormat","getSchemeSectionConformanceProblem","(Lforge/deck/CardPool;)Ljava/lang/String;",9,3,4,new JHandler[]{},M1446));
c.Add(new JMethod(1447,"forge/deck/DeckFormat","getCardPool","(Lforge/deck/generation/IDeckGenPool;)Lforge/deck/generation/IDeckGenPool;",1,5,2,new JHandler[]{},M1447));
c.Add(new JMethod(1448,"forge/deck/DeckFormat","adjustCMCLevels","(Ljava/util/List;)V",1,2,0,new JHandler[]{},M1448));
c.Add(new JMethod(1449,"forge/deck/DeckFormat","allowCustomCards","()Z",1,1,1,new JHandler[]{},M1449));
c.Add(new JMethod(1450,"forge/deck/DeckFormat","isLegalCard","(Lforge/item/PaperCard;)Z",1,2,2,new JHandler[]{},M1450));
c.Add(new JMethod(1451,"forge/deck/DeckFormat","isLegalCommander","(Lforge/card/CardRules;)Z",1,2,2,new JHandler[]{},M1451));
c.Add(new JMethod(1452,"forge/deck/DeckFormat","isAllowedCommander","(Lforge/card/CardRules;Z)Z",1,3,2,new JHandler[]{},M1452));
c.Add(new JMethod(1453,"forge/deck/DeckFormat","isAllowedPartnership","(Lforge/card/CardRules;Lforge/card/CardRules;Z)Z",1,4,3,new JHandler[]{},M1453));
c.Add(new JMethod(1454,"forge/deck/DeckFormat","getPartnerableCommander","(Lforge/deck/Deck;Lforge/item/PaperCard;Z)Lforge/item/PaperCard;",1,6,4,new JHandler[]{},M1454));
c.Add(new JMethod(1455,"forge/deck/DeckFormat","getIllegalCommanderWarning","(Lforge/item/PaperCard;Lforge/item/PaperCard;)Ljava/lang/String;",1,3,6,new JHandler[]{},M1455));
c.Add(new JMethod(1456,"forge/deck/DeckFormat","isLegalDeckPredicate","()Ljava/util/function/Predicate;",1,1,1,new JHandler[]{},M1456));
c.Add(new JMethod(1457,"forge/deck/DeckFormat","hasLegalCardsPredicate","(Z)Ljava/util/function/Predicate;",1,2,2,new JHandler[]{},M1457));
c.Add(new JMethod(1458,"forge/deck/DeckFormat","isLegalCardPredicate","()Ljava/util/function/Predicate;",1,1,1,new JHandler[]{},M1458));
c.Add(new JMethod(1459,"forge/deck/DeckFormat","isLegalCommanderPredicate","()Ljava/util/function/Predicate;",1,1,1,new JHandler[]{},M1459));
c.Add(new JMethod(1460,"forge/deck/DeckFormat","isLegalCardForCommanderPredicate","(Ljava/util/List;)Ljava/util/function/Predicate;",1,8,3,new JHandler[]{},M1460));
c.Add(new JMethod(1461,"forge/deck/DeckFormat","lambda$isLegalCardForCommanderPredicate$9","(Ljava/util/List;BLforge/card/CardRules;)Z",4106,3,3,new JHandler[]{},M1461));
}

private static void Add1(JClass c){
c.Add(new JMethod(1462,"forge/deck/DeckFormat","lambda$isLegalCardForCommanderPredicate$8","(Ljava/util/List;Lforge/card/CardRules;)Z",4106,2,2,new JHandler[]{},M1462));
c.Add(new JMethod(1463,"forge/deck/DeckFormat","lambda$isLegalCardForCommanderPredicate$7","(Lforge/item/PaperCard;)Z",4106,1,1,new JHandler[]{},M1463));
c.Add(new JMethod(1464,"forge/deck/DeckFormat","lambda$isLegalCommanderPredicate$6","(Lforge/item/PaperCard;)Z",4098,2,2,new JHandler[]{},M1464));
c.Add(new JMethod(1465,"forge/deck/DeckFormat","lambda$hasLegalCardsPredicate$5","(ZLforge/deck/Deck;)Z",4098,5,3,new JHandler[]{},M1465));
c.Add(new JMethod(1466,"forge/deck/DeckFormat","lambda$isLegalDeckPredicate$4","(Lforge/deck/Deck;)Z",4098,2,2,new JHandler[]{},M1466));
c.Add(new JMethod(1467,"forge/deck/DeckFormat","lambda$getDeckConformanceProblem$3","(Lforge/item/PaperCard;)Ljava/lang/String;",4106,1,2,new JHandler[]{},M1467));
c.Add(new JMethod(1468,"forge/deck/DeckFormat","lambda$static$2","(Lforge/item/PaperCard;)Z",4106,1,2,new JHandler[]{},M1468));
c.Add(new JMethod(1469,"forge/deck/DeckFormat","lambda$static$1","(Lforge/item/PaperCard;)Z",4106,1,2,new JHandler[]{},M1469));
c.Add(new JMethod(1470,"forge/deck/DeckFormat","lambda$static$0","(Lforge/item/PaperCard;)Z",4106,1,2,new JHandler[]{},M1470));
c.Add(new JMethod(1471,"forge/deck/DeckFormat","$values","()[Lforge/deck/DeckFormat;",4106,0,4,new JHandler[]{},M1471));
c.Add(new JMethod(1472,"forge/deck/DeckFormat","<clinit>","()V",8,0,9,new JHandler[]{},M1472));
}

internal static JStep M1421(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","$VALUES","[Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","$VALUES","[Lforge/deck/DeckFormat;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/deck/DeckFormat;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/deck/DeckFormat;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1422(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/deck/DeckFormat")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1423(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckFormat","mainRange","Lorg/apache/commons/lang3/Range;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckFormat","sideRange","Lorg/apache/commons/lang3/Range;",value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[5]);f.Pc=20;continue;}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckFormat","maxCardCopies","I",value);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[6]);f.Pc=26;continue;}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckFormat","cardPoolFilter","Ljava/util/function/Predicate;",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[7]);f.Pc=32;continue;}
case 32:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckFormat","paperCardPoolFilter","Ljava/util/function/Predicate;",value);f.Pc=35;continue;}
case 35:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1424(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckFormat","mainRange","Lorg/apache/commons/lang3/Range;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckFormat","sideRange","Lorg/apache/commons/lang3/Range;",value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[5]);f.Pc=20;continue;}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckFormat","maxCardCopies","I",value);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(null));f.Pc=25;continue;}
case 25:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckFormat","paperCardPoolFilter","Ljava/util/function/Predicate;",value);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[6]);f.Pc=31;continue;}
case 31:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckFormat","cardPoolFilter","Ljava/util/function/Predicate;",value);f.Pc=34;continue;}
case 34:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1425(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckFormat","mainRange","Lorg/apache/commons/lang3/Range;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckFormat","sideRange","Lorg/apache/commons/lang3/Range;",value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[5]);f.Pc=20;continue;}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckFormat","maxCardCopies","I",value);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(null));f.Pc=25;continue;}
case 25:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckFormat","paperCardPoolFilter","Ljava/util/function/Predicate;",value);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(null));f.Pc=30;continue;}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckFormat","cardPoolFilter","Ljava/util/function/Predicate;",value);f.Pc=33;continue;}
case 33:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1426(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Commander","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Commander","Lforge/deck/DeckFormat;"));f.Pc=4;continue;}
case 4:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?35:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","CommanderDraft","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","CommanderDraft","Lforge/deck/DeckFormat;"));f.Pc=11;continue;}
case 11:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?35:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Oathbreaker","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Oathbreaker","Lforge/deck/DeckFormat;"));f.Pc=18;continue;}
case 18:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?35:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","TinyLeaders","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","TinyLeaders","Lforge/deck/DeckFormat;"));f.Pc=25;continue;}
case 25:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?35:28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Brawl","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Brawl","Lforge/deck/DeckFormat;"));f.Pc=32;continue;}
case 32:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?39:35;continue;}
case 35:{f.Push(JValue.I(1));f.Pc=36;continue;}
case 36:{f.Pc=40;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1427(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Oathbreaker","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Oathbreaker","Lforge/deck/DeckFormat;"));f.Pc=4;continue;}
case 4:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1428(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/deck/DeckFormat","values","()[Lforge/deck/DeckFormat;","invokestatic",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=17;continue;}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{f.Locals[5]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[5]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?56:29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[5]);f.Pc=32;continue;}
case 32:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=33;continue;}
case 33:{f.Locals[6]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[6]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/deck/DeckFormat","name","()Ljava/lang/String;","invokevirtual",40);}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/String","compareToIgnoreCase","(Ljava/lang/String;)I","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int!=0?50:47;continue;}
case 47:{f.Push(f.Locals[6]);f.Pc=49;continue;}
case 49:{return JStep.Return(f.Pop());}
case 50:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=53;continue;}
case 53:{f.Pc=22;continue;}
case 56:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=59;continue;}
case 59:{f.StackOp("dup");f.Pc=60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{return rt.DynamicCall(f,"forge/deck/DeckFormat:1428:61:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",66);}
case 66:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",69);}
case 69:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1429(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","sideRange","Lorg/apache/commons/lang3/Range;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1430(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","mainRange","Lorg/apache/commons/lang3/Range;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1431(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","maxCardCopies","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1432(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/DeckFormat","canHaveSpecificNumberInDeck","(Lforge/item/IPaperCard;)Ljava/lang/Integer;","invokestatic",4);}
case 4:{f.Pc=f.Pop().Reference==null?15:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/deck/DeckFormat","canHaveSpecificNumberInDeck","(Lforge/item/IPaperCard;)Ljava/lang/Integer;","invokestatic",11);}
case 11:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",14);}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/deck/DeckFormat","canHaveAnyNumberOf","(Lforge/item/IPaperCard;)Z","invokestatic",19);}
case 19:{f.Pc=f.Pop().Int==0?25:22;continue;}
case 22:{f.Push(JValue.I(2147483647));f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/card/CardRules","isVariant","()Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int==0?68:35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/deck/DeckSection","matchingSection","(Lforge/item/PaperCard;)Lforge/deck/DeckSection;","invokestatic",39);}
case 39:{f.Locals[2]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Planes","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Planes","Lforge/deck/DeckSection;"));f.Pc=44;continue;}
case 44:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?62:47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",51);}
case 51:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",54);}
case 54:{return rt.Call(f,"forge/card/CardType","isPhenomenon","()Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?62:60;continue;}
case 60:{f.Push(JValue.I(2));f.Pc=61;continue;}
case 61:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/deck/DeckFormat","getExtraSectionMaxCopies","(Lforge/deck/DeckSection;)I","invokevirtual",67);}
case 67:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/deck/DeckFormat","getMaxCardCopies","()I","invokevirtual",72);}
case 72:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1433(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/deck/DeckFormat$5","$SwitchMap$forge$deck$DeckSection","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat$5","$SwitchMap$forge$deck$DeckSection","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/DeckSection","ordinal","()I","invokevirtual",7);}
case 7:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8;continue;}
case 8:{switch(f.Pop().Int){case 1:f.Pc=60;break;case 2:f.Pc=60;break;case 3:f.Pc=60;break;case 4:f.Pc=60;break;case 5:f.Pc=60;break;case 6:f.Pc=60;break;case 7:f.Pc=60;break;case 8:f.Pc=64;break;case 9:f.Pc=68;break;default:f.Pc=73;break;}continue;}
case 60:{f.Push(JValue.I(1));f.Pc=61;continue;}
case 61:{f.Pc=77;continue;}
case 64:{f.Push(JValue.I(2));f.Pc=65;continue;}
case 65:{f.Pc=77;continue;}
case 68:{f.Push(JValue.I(2147483647));f.Pc=70;continue;}
case 70:{f.Pc=77;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","maxCardCopies","I"));f.Pc=77;continue;}
case 77:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1434(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Planechase","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Planechase","Lforge/deck/DeckFormat;"));f.Pc=4;continue;}
case 4:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?14:7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Planes","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Planes","Lforge/deck/DeckSection;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",13);}
case 13:{return JStep.Return(f.Pop());}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Archenemy","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Archenemy","Lforge/deck/DeckFormat;"));f.Pc=18;continue;}
case 18:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?28:21;continue;}
case 21:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Schemes","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Schemes","Lforge/deck/DeckSection;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",27);}
case 27:{return JStep.Return(f.Pop());}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Vanguard","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Vanguard","Lforge/deck/DeckFormat;"));f.Pc=32;continue;}
case 32:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?42:35;continue;}
case 35:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",41);}
case 41:{return JStep.Return(f.Pop());}
case 42:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",48);}
case 48:{f.Locals[1]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","sideRange","Lorg/apache/commons/lang3/Range;"));f.Pc=53;continue;}
case 53:{f.Pc=f.Pop().Reference==null?72:56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","sideRange","Lorg/apache/commons/lang3/Range;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"org/apache/commons/lang3/Range","getMaximum","()Ljava/lang/Object;","invokevirtual",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int<=0?80:72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/EnumSet","add","(Ljava/lang/Object;)Z","invokevirtual",79);}
case 79:{f.StackOp("pop");f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/deck/DeckFormat","hasCommander","()Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int==0?95:87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"));f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/EnumSet","add","(Ljava/lang/Object;)Z","invokevirtual",94);}
case 94:{f.StackOp("pop");f.Pc=95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1435(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?7:4;continue;}
case 4:{f.Push(JValue.R(rt.String("is not selected")));f.Pc=6;continue;}
case 6:{return JStep.Return(f.Pop());}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/deck/Deck","getMain","()Lforge/deck/CardPool;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/deck/CardPool","countAll","()I","invokevirtual",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/deck/DeckFormat","getMainRange","()Lorg/apache/commons/lang3/Range;","invokevirtual",19);}
case 19:{return rt.Call(f,"org/apache/commons/lang3/Range","getMinimum","()Ljava/lang/Object;","invokevirtual",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",28);}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/deck/DeckFormat","getMainRange","()Lorg/apache/commons/lang3/Range;","invokevirtual",33);}
case 33:{return rt.Call(f,"org/apache/commons/lang3/Range","getMaximum","()Ljava/lang/Object;","invokevirtual",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",42);}
case 42:{f.Locals[4]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;"));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",51);}
case 51:{f.Locals[5]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[5]);f.Pc=55;continue;}
case 55:{f.Pc=f.Pop().Reference==null?70:58;continue;}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{f.Push(JValue.I(5));f.Pc=60;continue;}
case 60:{f.Push(f.Locals[5]);f.Pc=62;continue;}
case 62:{f.Push(JValue.R(rt.String("Advantageous Proclamation")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/deck/CardPool","countByName","(Ljava/lang/String;)I","invokevirtual",67);}
case 67:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=68;continue;}
case 68:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=69;continue;}
case 69:{f.Locals[3]=f.Pop();f.Pc=70;continue;}
case 70:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=73;continue;}
case 73:{f.StackOp("dup");f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",77);}
case 77:{f.Locals[6]=f.Pop();f.Pc=79;continue;}
case 79:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=82;continue;}
case 82:{f.StackOp("dup");f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",86);}
case 86:{f.Locals[7]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/deck/DeckFormat","hasCommander","()Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int==0?227:95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/deck/Deck","getCommanders","()Ljava/util/List;","invokevirtual",99);}
case 99:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",104);}
case 104:{f.Locals[8]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(f.Locals[8]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",113);}
case 113:{f.Pc=f.Pop().Int==0?227:116;continue;}
case 116:{f.Push(f.Locals[8]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",123);}
case 123:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=126;continue;}
case 126:{f.Locals[9]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[9]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/deck/DeckRule","parseAll","(Lforge/item/PaperCard;)Ljava/util/List;","invokestatic",133);}
case 133:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",138);}
case 138:{f.Locals[10]=f.Pop();f.Pc=140;continue;}
case 140:{f.Push(f.Locals[10]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",147);}
case 147:{f.Pc=f.Pop().Int==0?224:150;continue;}
case 150:{f.Push(f.Locals[10]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",157);}
case 157:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckRule"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=160;continue;}
case 160:{f.Locals[11]=f.Pop();f.Pc=162;continue;}
case 162:{f.Push(f.Locals[11]);f.Pc=164;continue;}
case 164:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"));f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/deck/DeckRule","isActiveFor","(Lforge/deck/DeckSection;)Z","invokevirtual",170);}
case 170:{f.Pc=f.Pop().Int!=0?176:173;continue;}
case 173:{f.Pc=140;continue;}
case 176:{f.Push(f.Locals[11]);f.Pc=178;continue;}
case 178:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/deck/DeckRuleColorIdentity")?1:0));f.Pc=181;continue;}
case 181:{f.Pc=f.Pop().Int==0?200:184;continue;}
case 184:{f.Push(f.Locals[6]);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[11]);f.Pc=188;continue;}
case 188:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckRuleColorIdentity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",196);}
case 196:{f.StackOp("pop");f.Pc=197;continue;}
case 197:{f.Pc=221;continue;}
case 200:{f.Push(f.Locals[11]);f.Pc=202;continue;}
case 202:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/deck/DeckRuleSize")?1:0));f.Pc=205;continue;}
case 205:{f.Pc=f.Pop().Int==0?221:208;continue;}
case 208:{f.Push(f.Locals[7]);f.Pc=210;continue;}
case 210:{f.Push(f.Locals[11]);f.Pc=212;continue;}
case 212:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckRuleSize"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",220);}
case 220:{f.StackOp("pop");f.Pc=221;continue;}
case 221:{f.Pc=140;continue;}
case 224:{f.Pc=106;continue;}
case 227:{f.Push(f.Locals[7]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",234);}
case 234:{f.Locals[8]=f.Pop();f.Pc=236;continue;}
case 236:{f.Push(f.Locals[8]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",243);}
case 243:{f.Pc=f.Pop().Int==0?293:246;continue;}
case 246:{f.Push(f.Locals[8]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",253);}
case 253:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckRuleSize"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=256;continue;}
case 256:{f.Locals[9]=f.Pop();f.Pc=258;continue;}
case 258:{f.Push(f.Locals[9]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/deck/DeckRuleSize","removesMaxDeckSize","()Z","invokevirtual",263);}
case 263:{f.Pc=f.Pop().Int==0?273:266;continue;}
case 266:{f.Push(JValue.I(2147483647));f.Pc=268;continue;}
case 268:{f.Locals[4]=f.Pop();f.Pc=270;continue;}
case 270:{f.Pc=290;continue;}
case 273:{f.Push(f.Locals[4]);f.Pc=275;continue;}
case 275:{f.Push(JValue.I(2147483647));f.Pc=277;continue;}
case 277:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?290:280;continue;}
case 280:{f.Push(f.Locals[4]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[9]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"forge/deck/DeckRuleSize","getMaxDelta","()I","invokevirtual",287);}
case 287:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=288;continue;}
case 288:{f.Locals[4]=f.Pop();f.Pc=290;continue;}
case 290:{f.Pc=236;continue;}
case 293:{f.Push(f.Locals[0]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"forge/deck/DeckFormat","hasCommander","()Z","invokevirtual",297);}
case 297:{f.Pc=f.Pop().Int==0?346:300;continue;}
case 300:{f.Push(f.Locals[0]);f.Pc=301;continue;}
case 301:{f.Push(f.Locals[1]);f.Pc=302;continue;}
case 302:{f.Push(f.Locals[6]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/deck/DeckFormat","getCommanderConformanceProblem","(Lforge/deck/Deck;Ljava/util/List;)Ljava/lang/String;","invokevirtual",307);}
case 307:{f.Locals[8]=f.Pop();f.Pc=309;continue;}
case 309:{f.Push(f.Locals[8]);f.Pc=311;continue;}
case 311:{f.Pc=f.Pop().Reference==null?317:314;continue;}
case 314:{f.Push(f.Locals[8]);f.Pc=316;continue;}
case 316:{return JStep.Return(f.Pop());}
case 317:{f.Push(f.Locals[0]);f.Pc=318;continue;}
case 318:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Oathbreaker","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Oathbreaker","Lforge/deck/DeckFormat;"));f.Pc=321;continue;}
case 321:{return rt.Call(f,"forge/deck/DeckFormat","equals","(Ljava/lang/Object;)Z","invokevirtual",324);}
case 324:{f.Pc=f.Pop().Int!=0?346:327;continue;}
case 327:{f.Push(f.Locals[1]);f.Pc=328;continue;}
case 328:{return rt.Call(f,"forge/deck/Deck","getCommanders","()Ljava/util/List;","invokevirtual",331);}
case 331:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",336);}
case 336:{f.Push(JValue.I(2));f.Pc=337;continue;}
case 337:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?346:340;continue;}
case 340:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(-1)));f.Pc=343;continue;}
case 343:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(-1)));f.Pc=346;continue;}
case 346:{f.Push(f.Locals[2]);f.Pc=347;continue;}
case 347:{f.Push(f.Locals[3]);f.Pc=348;continue;}
case 348:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?378:351;continue;}
case 351:{f.Push(JValue.I(3));f.Pc=352;continue;}
case 352:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=355;continue;}
case 355:{f.StackOp("dup");f.Pc=356;continue;}
case 356:{f.Push(JValue.I(0));f.Pc=357;continue;}
case 357:{f.Push(JValue.R(rt.String("should have at least")));f.Pc=360;continue;}
case 360:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=361;continue;}
case 361:{f.StackOp("dup");f.Pc=362;continue;}
case 362:{f.Push(JValue.I(1));f.Pc=363;continue;}
case 363:{f.Push(f.Locals[3]);f.Pc=364;continue;}
case 364:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",367);}
case 367:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=368;continue;}
case 368:{f.StackOp("dup");f.Pc=369;continue;}
case 369:{f.Push(JValue.I(2));f.Pc=370;continue;}
case 370:{f.Push(JValue.R(rt.String("cards")));f.Pc=373;continue;}
case 373:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=374;continue;}
case 374:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",377);}
case 377:{return JStep.Return(f.Pop());}
case 378:{f.Push(f.Locals[2]);f.Pc=379;continue;}
case 379:{f.Push(f.Locals[4]);f.Pc=381;continue;}
case 381:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?412:384;continue;}
case 384:{f.Push(JValue.I(3));f.Pc=385;continue;}
case 385:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=388;continue;}
case 388:{f.StackOp("dup");f.Pc=389;continue;}
case 389:{f.Push(JValue.I(0));f.Pc=390;continue;}
case 390:{f.Push(JValue.R(rt.String("should have no more than")));f.Pc=393;continue;}
case 393:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=394;continue;}
case 394:{f.StackOp("dup");f.Pc=395;continue;}
case 395:{f.Push(JValue.I(1));f.Pc=396;continue;}
case 396:{f.Push(f.Locals[4]);f.Pc=398;continue;}
case 398:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",401);}
case 401:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=402;continue;}
case 402:{f.StackOp("dup");f.Pc=403;continue;}
case 403:{f.Push(JValue.I(2));f.Pc=404;continue;}
case 404:{f.Push(JValue.R(rt.String("cards")));f.Pc=407;continue;}
case 407:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=408;continue;}
case 408:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",411);}
case 411:{return JStep.Return(f.Pop());}
case 412:{f.Push(f.Locals[0]);f.Pc=413;continue;}
case 413:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","cardPoolFilter","Ljava/util/function/Predicate;"));f.Pc=416;continue;}
case 416:{f.Pc=f.Pop().Reference==null?584:419;continue;}
case 419:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=422;continue;}
case 422:{f.StackOp("dup");f.Pc=423;continue;}
case 423:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",426);}
case 426:{f.Locals[8]=f.Pop();f.Pc=428;continue;}
case 428:{f.Push(f.Locals[1]);f.Pc=429;continue;}
case 429:{return rt.Call(f,"forge/deck/Deck","getAllCardsInASinglePool","()Lforge/deck/CardPool;","invokevirtual",432);}
case 432:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",435);}
case 435:{f.Locals[9]=f.Pop();f.Pc=437;continue;}
case 437:{f.Push(f.Locals[9]);f.Pc=439;continue;}
case 439:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",444);}
case 444:{f.Pc=f.Pop().Int==0?505:447;continue;}
case 447:{f.Push(f.Locals[9]);f.Pc=449;continue;}
case 449:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",454);}
case 454:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=457;continue;}
case 457:{f.Locals[10]=f.Pop();f.Pc=459;continue;}
case 459:{f.Push(f.Locals[0]);f.Pc=460;continue;}
case 460:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","cardPoolFilter","Ljava/util/function/Predicate;"));f.Pc=463;continue;}
case 463:{f.Push(f.Locals[10]);f.Pc=465;continue;}
case 465:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",470);}
case 470:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=473;continue;}
case 473:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",476);}
case 476:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",481);}
case 481:{f.Pc=f.Pop().Int!=0?502:484;continue;}
case 484:{f.Push(f.Locals[8]);f.Pc=486;continue;}
case 486:{f.Push(f.Locals[10]);f.Pc=488;continue;}
case 488:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",493);}
case 493:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=496;continue;}
case 496:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",501);}
case 501:{f.StackOp("pop");f.Pc=502;continue;}
case 502:{f.Pc=437;continue;}
case 505:{f.Push(f.Locals[8]);f.Pc=507;continue;}
case 507:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",512);}
case 512:{f.Pc=f.Pop().Int!=0?584:515;continue;}
case 515:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=518;continue;}
case 518:{f.StackOp("dup");f.Pc=519;continue;}
case 519:{f.Push(JValue.R(rt.String("contains the following illegal cards:\n")));f.Pc=522;continue;}
case 522:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",525);}
case 525:{f.Locals[9]=f.Pop();f.Pc=527;continue;}
case 527:{f.Push(f.Locals[8]);f.Pc=529;continue;}
case 529:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",534);}
case 534:{f.Locals[10]=f.Pop();f.Pc=536;continue;}
case 536:{f.Push(f.Locals[10]);f.Pc=538;continue;}
case 538:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",543);}
case 543:{f.Pc=f.Pop().Int==0?578:546;continue;}
case 546:{f.Push(f.Locals[10]);f.Pc=548;continue;}
case 548:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",553);}
case 553:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=556;continue;}
case 556:{f.Locals[11]=f.Pop();f.Pc=558;continue;}
case 558:{f.Push(f.Locals[9]);f.Pc=560;continue;}
case 560:{f.Push(JValue.R(rt.String("\n")));f.Pc=563;continue;}
case 563:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",566);}
case 566:{f.Push(f.Locals[11]);f.Pc=568;continue;}
case 568:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",571);}
case 571:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",574);}
case 574:{f.StackOp("pop");f.Pc=575;continue;}
case 575:{f.Pc=536;continue;}
case 578:{f.Push(f.Locals[9]);f.Pc=580;continue;}
case 580:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",583);}
case 583:{return JStep.Return(f.Pop());}
case 584:{f.Push(f.Locals[1]);f.Pc=585;continue;}
case 585:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"));f.Pc=588;continue;}
case 588:{return rt.Call(f,"forge/deck/Deck","has","(Lforge/deck/DeckSection;)Z","invokevirtual",591);}
case 591:{f.Pc=f.Pop().Int==0?609:594;continue;}
case 594:{f.Push(f.Locals[0]);f.Pc=595;continue;}
case 595:{f.Push(f.Locals[1]);f.Pc=596;continue;}
case 596:{return rt.Call(f,"forge/deck/DeckFormat","getAttractionDeckConformanceProblem","(Lforge/deck/Deck;)Ljava/lang/String;","invokevirtual",599);}
case 599:{f.Locals[8]=f.Pop();f.Pc=601;continue;}
case 601:{f.Push(f.Locals[8]);f.Pc=603;continue;}
case 603:{f.Pc=f.Pop().Reference==null?609:606;continue;}
case 606:{f.Push(f.Locals[8]);f.Pc=608;continue;}
case 608:{return JStep.Return(f.Pop());}
case 609:{f.Push(f.Locals[1]);f.Pc=610;continue;}
case 610:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"));f.Pc=613;continue;}
case 613:{return rt.Call(f,"forge/deck/Deck","has","(Lforge/deck/DeckSection;)Z","invokevirtual",616);}
case 616:{f.Pc=f.Pop().Int==0?634:619;continue;}
case 619:{f.Push(f.Locals[0]);f.Pc=620;continue;}
case 620:{f.Push(f.Locals[1]);f.Pc=621;continue;}
case 621:{return rt.Call(f,"forge/deck/DeckFormat","getStickerSheetConformanceProblem","(Lforge/deck/Deck;)Ljava/lang/String;","invokevirtual",624);}
case 624:{f.Locals[8]=f.Pop();f.Pc=626;continue;}
case 626:{f.Push(f.Locals[8]);f.Pc=628;continue;}
case 628:{f.Pc=f.Pop().Reference==null?634:631;continue;}
case 631:{f.Push(f.Locals[8]);f.Pc=633;continue;}
case 633:{return JStep.Return(f.Pop());}
case 634:{f.Push(f.Locals[1]);f.Pc=635;continue;}
case 635:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"));f.Pc=638;continue;}
case 638:{return rt.Call(f,"forge/deck/Deck","has","(Lforge/deck/DeckSection;)Z","invokevirtual",641);}
case 641:{f.Pc=f.Pop().Int==0?659:644;continue;}
case 644:{f.Push(f.Locals[0]);f.Pc=645;continue;}
case 645:{f.Push(f.Locals[1]);f.Pc=646;continue;}
case 646:{return rt.Call(f,"forge/deck/DeckFormat","getContraptionDeckConformanceProblem","(Lforge/deck/Deck;)Ljava/lang/String;","invokevirtual",649);}
case 649:{f.Locals[8]=f.Pop();f.Pc=651;continue;}
case 651:{f.Push(f.Locals[8]);f.Pc=653;continue;}
case 653:{f.Pc=f.Pop().Reference==null?659:656;continue;}
case 656:{f.Push(f.Locals[8]);f.Pc=658;continue;}
case 658:{return JStep.Return(f.Pop());}
case 659:{f.Push(f.Locals[0]);f.Pc=660;continue;}
case 660:{return rt.Call(f,"forge/deck/DeckFormat","getMaxCardCopies","()I","invokevirtual",663);}
case 663:{f.Locals[8]=f.Pop();f.Pc=665;continue;}
case 665:{f.Push(f.Locals[1]);f.Pc=666;continue;}
case 666:{f.Push(f.Locals[0]);f.Pc=667;continue;}
case 667:{return rt.Call(f,"forge/deck/DeckFormat","hasCommander","()Z","invokevirtual",670);}
case 670:{f.Push(JValue.I(0));f.Pc=671;continue;}
case 671:{return rt.Call(f,"forge/deck/Deck","getAllCardsInASinglePool","(ZZ)Lforge/deck/CardPool;","invokevirtual",674);}
case 674:{f.Locals[9]=f.Pop();f.Pc=676;continue;}
case 676:{f.Push(f.Locals[9]);f.Pc=678;continue;}
case 678:{return rt.DynamicCall(f,"forge/deck/DeckFormat:1435:678:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",683);}
case 683:{return rt.Call(f,"forge/util/Aggregates","groupSumBy","(Ljava/lang/Iterable;Ljava/util/function/Function;)Ljava/lang/Iterable;","invokestatic",686);}
case 686:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",691);}
case 691:{f.Locals[10]=f.Pop();f.Pc=693;continue;}
case 693:{f.Push(f.Locals[10]);f.Pc=695;continue;}
case 695:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",700);}
case 700:{f.Pc=f.Pop().Int==0?1008:703;continue;}
case 703:{f.Push(f.Locals[10]);f.Pc=705;continue;}
case 705:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",710);}
case 710:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=713;continue;}
case 713:{f.Locals[11]=f.Pop();f.Pc=715;continue;}
case 715:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",718);}
case 718:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",721);}
case 721:{f.Push(f.Locals[11]);f.Pc=723;continue;}
case 723:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",728);}
case 728:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=731;continue;}
case 731:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",734);}
case 734:{f.Locals[12]=f.Pop();f.Pc=736;continue;}
case 736:{f.Push(f.Locals[12]);f.Pc=738;continue;}
case 738:{f.Pc=f.Pop().Reference==null?794:741;continue;}
case 741:{f.Push(f.Locals[12]);f.Pc=743;continue;}
case 743:{return rt.Call(f,"forge/item/IPaperCard","getRules","()Lforge/card/CardRules;","invokeinterface",748);}
case 748:{return rt.Call(f,"forge/card/CardRules","isCustom","()Z","invokevirtual",751);}
case 751:{f.Pc=f.Pop().Int==0?794:754;continue;}
case 754:{f.Push(f.Locals[0]);f.Pc=755;continue;}
case 755:{return rt.Call(f,"forge/deck/DeckFormat","allowCustomCards","()Z","invokevirtual",758);}
case 758:{f.Pc=f.Pop().Int!=0?794:761;continue;}
case 761:{f.Push(JValue.I(3));f.Pc=762;continue;}
case 762:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=765;continue;}
case 765:{f.StackOp("dup");f.Pc=766;continue;}
case 766:{f.Push(JValue.I(0));f.Pc=767;continue;}
case 767:{f.Push(JValue.R(rt.String("contains a Custom Card:")));f.Pc=770;continue;}
case 770:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=771;continue;}
case 771:{f.StackOp("dup");f.Pc=772;continue;}
case 772:{f.Push(JValue.I(1));f.Pc=773;continue;}
case 773:{f.Push(f.Locals[11]);f.Pc=775;continue;}
case 775:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",780);}
case 780:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=783;continue;}
case 783:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=784;continue;}
case 784:{f.StackOp("dup");f.Pc=785;continue;}
case 785:{f.Push(JValue.I(2));f.Pc=786;continue;}
case 786:{f.Push(JValue.R(rt.String("\nPlease Enable Custom Cards in Forge Preferences to use this deck.")));f.Pc=789;continue;}
case 789:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=790;continue;}
case 790:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",793);}
case 793:{return JStep.Return(f.Pop());}
case 794:{f.Push(f.Locals[12]);f.Pc=796;continue;}
case 796:{f.Pc=f.Pop().Reference!=null?852:799;continue;}
case 799:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",802);}
case 802:{return rt.Call(f,"forge/StaticData","getVariantCards","()Lforge/card/CardDb;","invokevirtual",805);}
case 805:{f.Push(f.Locals[11]);f.Pc=807;continue;}
case 807:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",812);}
case 812:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=815;continue;}
case 815:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",818);}
case 818:{f.Locals[12]=f.Pop();f.Pc=820;continue;}
case 820:{f.Push(f.Locals[12]);f.Pc=822;continue;}
case 822:{f.Pc=f.Pop().Reference!=null?852:825;continue;}
case 825:{f.Push(JValue.I(2));f.Pc=826;continue;}
case 826:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=829;continue;}
case 829:{f.StackOp("dup");f.Pc=830;continue;}
case 830:{f.Push(JValue.I(0));f.Pc=831;continue;}
case 831:{f.Push(JValue.R(rt.String("contains the nonexisting card")));f.Pc=834;continue;}
case 834:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=835;continue;}
case 835:{f.StackOp("dup");f.Pc=836;continue;}
case 836:{f.Push(JValue.I(1));f.Pc=837;continue;}
case 837:{f.Push(f.Locals[11]);f.Pc=839;continue;}
case 839:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",844);}
case 844:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=847;continue;}
case 847:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=848;continue;}
case 848:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",851);}
case 851:{return JStep.Return(f.Pop());}
case 852:{f.Push(f.Locals[12]);f.Pc=854;continue;}
case 854:{return rt.Call(f,"forge/deck/DeckFormat","canHaveAnyNumberOf","(Lforge/item/IPaperCard;)Z","invokestatic",857);}
case 857:{f.Pc=f.Pop().Int==0?863:860;continue;}
case 860:{f.Pc=693;continue;}
case 863:{f.Push(f.Locals[12]);f.Pc=865;continue;}
case 865:{return rt.Call(f,"forge/deck/DeckFormat","canHaveSpecificNumberInDeck","(Lforge/item/IPaperCard;)Ljava/lang/Integer;","invokestatic",868);}
case 868:{f.Locals[13]=f.Pop();f.Pc=870;continue;}
case 870:{f.Push(f.Locals[13]);f.Pc=872;continue;}
case 872:{f.Pc=f.Pop().Reference==null?941:875;continue;}
case 875:{f.Push(f.Locals[1]);f.Pc=876;continue;}
case 876:{return rt.Call(f,"forge/deck/Deck","getMain","()Lforge/deck/CardPool;","invokevirtual",879);}
case 879:{f.Push(f.Locals[11]);f.Pc=881;continue;}
case 881:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",886);}
case 886:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=889;continue;}
case 889:{return rt.Call(f,"forge/deck/CardPool","countByName","(Ljava/lang/String;)I","invokevirtual",892);}
case 892:{f.Push(f.Locals[13]);f.Pc=894;continue;}
case 894:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",897);}
case 897:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?941:900;continue;}
case 900:{f.Push(JValue.I(4));f.Pc=901;continue;}
case 901:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=904;continue;}
case 904:{f.StackOp("dup");f.Pc=905;continue;}
case 905:{f.Push(JValue.I(0));f.Pc=906;continue;}
case 906:{f.Push(JValue.R(rt.String("must not contain more than")));f.Pc=909;continue;}
case 909:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=910;continue;}
case 910:{f.StackOp("dup");f.Pc=911;continue;}
case 911:{f.Push(JValue.I(1));f.Pc=912;continue;}
case 912:{f.Push(f.Locals[13]);f.Pc=914;continue;}
case 914:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",917);}
case 917:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=918;continue;}
case 918:{f.StackOp("dup");f.Pc=919;continue;}
case 919:{f.Push(JValue.I(2));f.Pc=920;continue;}
case 920:{f.Push(JValue.R(rt.String("copies of the card")));f.Pc=923;continue;}
case 923:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=924;continue;}
case 924:{f.StackOp("dup");f.Pc=925;continue;}
case 925:{f.Push(JValue.I(3));f.Pc=926;continue;}
case 926:{f.Push(f.Locals[11]);f.Pc=928;continue;}
case 928:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",933);}
case 933:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=936;continue;}
case 936:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=937;continue;}
case 937:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",940);}
case 940:{return JStep.Return(f.Pop());}
case 941:{f.Push(f.Locals[13]);f.Pc=943;continue;}
case 943:{f.Pc=f.Pop().Reference!=null?1005:946;continue;}
case 946:{f.Push(f.Locals[11]);f.Pc=948;continue;}
case 948:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",953);}
case 953:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=956;continue;}
case 956:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",959);}
case 959:{f.Push(f.Locals[8]);f.Pc=961;continue;}
case 961:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1005:964;continue;}
case 964:{f.Push(JValue.I(4));f.Pc=965;continue;}
case 965:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=968;continue;}
case 968:{f.StackOp("dup");f.Pc=969;continue;}
case 969:{f.Push(JValue.I(0));f.Pc=970;continue;}
case 970:{f.Push(JValue.R(rt.String("must not contain more than")));f.Pc=973;continue;}
case 973:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=974;continue;}
case 974:{f.StackOp("dup");f.Pc=975;continue;}
case 975:{f.Push(JValue.I(1));f.Pc=976;continue;}
case 976:{f.Push(f.Locals[8]);f.Pc=978;continue;}
case 978:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",981);}
case 981:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=982;continue;}
case 982:{f.StackOp("dup");f.Pc=983;continue;}
case 983:{f.Push(JValue.I(2));f.Pc=984;continue;}
case 984:{f.Push(JValue.R(rt.String("copies of the card")));f.Pc=987;continue;}
case 987:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=988;continue;}
case 988:{f.StackOp("dup");f.Pc=989;continue;}
case 989:{f.Push(JValue.I(3));f.Pc=990;continue;}
case 990:{f.Push(f.Locals[11]);f.Pc=992;continue;}
case 992:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",997);}
case 997:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1000;continue;}
case 1000:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1001;continue;}
case 1001:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",1004);}
case 1004:{return JStep.Return(f.Pop());}
case 1005:{f.Pc=693;continue;}
case 1008:{f.Push(f.Locals[1]);f.Pc=1009;continue;}
case 1009:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=1012;continue;}
case 1012:{return rt.Call(f,"forge/deck/Deck","has","(Lforge/deck/DeckSection;)Z","invokevirtual",1015);}
case 1015:{f.Pc=f.Pop().Int==0?1031:1018;continue;}
case 1018:{f.Push(f.Locals[1]);f.Pc=1019;continue;}
case 1019:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=1022;continue;}
case 1022:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",1025);}
case 1025:{return rt.Call(f,"forge/deck/CardPool","countAll","()I","invokevirtual",1028);}
case 1028:{f.Pc=1032;continue;}
case 1031:{f.Push(JValue.I(0));f.Pc=1032;continue;}
case 1032:{f.Locals[10]=f.Pop();f.Pc=1034;continue;}
case 1034:{f.Push(f.Locals[0]);f.Pc=1035;continue;}
case 1035:{return rt.Call(f,"forge/deck/DeckFormat","getSideRange","()Lorg/apache/commons/lang3/Range;","invokevirtual",1038);}
case 1038:{f.Locals[11]=f.Pop();f.Pc=1040;continue;}
case 1040:{f.Push(f.Locals[11]);f.Pc=1042;continue;}
case 1042:{f.Pc=f.Pop().Reference==null?1163:1045;continue;}
case 1045:{f.Push(f.Locals[10]);f.Pc=1047;continue;}
case 1047:{f.Pc=f.Pop().Int<=0?1163:1050;continue;}
case 1050:{f.Push(f.Locals[11]);f.Pc=1052;continue;}
case 1052:{f.Push(f.Locals[10]);f.Pc=1054;continue;}
case 1054:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1057);}
case 1057:{return rt.Call(f,"org/apache/commons/lang3/Range","contains","(Ljava/lang/Object;)Z","invokevirtual",1060);}
case 1060:{f.Pc=f.Pop().Int!=0?1163:1063;continue;}
case 1063:{f.Push(f.Locals[11]);f.Pc=1065;continue;}
case 1065:{return rt.Call(f,"org/apache/commons/lang3/Range","getMinimum","()Ljava/lang/Object;","invokevirtual",1068);}
case 1068:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1071;continue;}
case 1071:{f.Push(f.Locals[11]);f.Pc=1073;continue;}
case 1073:{return rt.Call(f,"org/apache/commons/lang3/Range","getMaximum","()Ljava/lang/Object;","invokevirtual",1076);}
case 1076:{return rt.Call(f,"java/lang/Integer","equals","(Ljava/lang/Object;)Z","invokevirtual",1079);}
case 1079:{f.Pc=f.Pop().Int==0?1115:1082;continue;}
case 1082:{f.Push(JValue.I(3));f.Pc=1083;continue;}
case 1083:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=1086;continue;}
case 1086:{f.StackOp("dup");f.Pc=1087;continue;}
case 1087:{f.Push(JValue.I(0));f.Pc=1088;continue;}
case 1088:{f.Push(JValue.R(rt.String("must have a sideboard of")));f.Pc=1091;continue;}
case 1091:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1092;continue;}
case 1092:{f.StackOp("dup");f.Pc=1093;continue;}
case 1093:{f.Push(JValue.I(1));f.Pc=1094;continue;}
case 1094:{f.Push(f.Locals[11]);f.Pc=1096;continue;}
case 1096:{return rt.Call(f,"org/apache/commons/lang3/Range","getMinimum","()Ljava/lang/Object;","invokevirtual",1099);}
case 1099:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1102);}
case 1102:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1103;continue;}
case 1103:{f.StackOp("dup");f.Pc=1104;continue;}
case 1104:{f.Push(JValue.I(2));f.Pc=1105;continue;}
case 1105:{f.Push(JValue.R(rt.String("cards or no sideboard at all")));f.Pc=1108;continue;}
case 1108:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1109;continue;}
case 1109:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",1112);}
case 1112:{f.Pc=1162;continue;}
case 1115:{f.Push(JValue.I(5));f.Pc=1116;continue;}
case 1116:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=1119;continue;}
case 1119:{f.StackOp("dup");f.Pc=1120;continue;}
case 1120:{f.Push(JValue.I(0));f.Pc=1121;continue;}
case 1121:{f.Push(JValue.R(rt.String("must have a sideboard of")));f.Pc=1124;continue;}
case 1124:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1125;continue;}
case 1125:{f.StackOp("dup");f.Pc=1126;continue;}
case 1126:{f.Push(JValue.I(1));f.Pc=1127;continue;}
case 1127:{f.Push(f.Locals[11]);f.Pc=1129;continue;}
case 1129:{return rt.Call(f,"org/apache/commons/lang3/Range","getMinimum","()Ljava/lang/Object;","invokevirtual",1132);}
case 1132:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1135);}
case 1135:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1136;continue;}
case 1136:{f.StackOp("dup");f.Pc=1137;continue;}
case 1137:{f.Push(JValue.I(2));f.Pc=1138;continue;}
case 1138:{f.Push(JValue.R(rt.String("to")));f.Pc=1141;continue;}
case 1141:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1142;continue;}
case 1142:{f.StackOp("dup");f.Pc=1143;continue;}
case 1143:{f.Push(JValue.I(3));f.Pc=1144;continue;}
case 1144:{f.Push(f.Locals[11]);f.Pc=1146;continue;}
case 1146:{return rt.Call(f,"org/apache/commons/lang3/Range","getMaximum","()Ljava/lang/Object;","invokevirtual",1149);}
case 1149:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1152);}
case 1152:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1153;continue;}
case 1153:{f.StackOp("dup");f.Pc=1154;continue;}
case 1154:{f.Push(JValue.I(4));f.Pc=1155;continue;}
case 1155:{f.Push(JValue.R(rt.String("cards or no sideboard at all")));f.Pc=1158;continue;}
case 1158:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1159;continue;}
case 1159:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",1162);}
case 1162:{return JStep.Return(f.Pop());}
case 1163:{f.Push(JValue.R(null));f.Pc=1164;continue;}
case 1164:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1436(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/DeckFormat","hasCommander","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/deck/Deck","getCommanders","()Ljava/util/List;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",26);}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",33);}
case 33:{f.Pc=f.Pop().Int==0?118:36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[4]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/deck/DeckRule","parseAll","(Lforge/item/PaperCard;)Ljava/util/List;","invokestatic",52);}
case 52:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",57);}
case 57:{f.Locals[5]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[5]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",66);}
case 66:{f.Pc=f.Pop().Int==0?115:69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",76);}
case 76:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckRule"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=79;continue;}
case 79:{f.Locals[6]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[6]);f.Pc=83;continue;}
case 83:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/deck/DeckRuleColorIdentity")?1:0));f.Pc=86;continue;}
case 86:{f.Pc=f.Pop().Int==0?112:89;continue;}
case 89:{f.Push(f.Locals[6]);f.Pc=91;continue;}
case 91:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"));f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/deck/DeckRule","isActiveFor","(Lforge/deck/DeckSection;)Z","invokevirtual",97);}
case 97:{f.Pc=f.Pop().Int==0?112:100;continue;}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[6]);f.Pc=103;continue;}
case 103:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckRuleColorIdentity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",111);}
case 111:{f.StackOp("pop");f.Pc=112;continue;}
case 112:{f.Pc=59;continue;}
case 115:{f.Pc=27;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[2]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/deck/DeckFormat","getCommanderConformanceProblem","(Lforge/deck/Deck;Ljava/util/List;)Ljava/lang/String;","invokevirtual",124);}
case 124:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1437(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[3]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{f.Locals[4]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Oathbreaker","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Oathbreaker","Lforge/deck/DeckFormat;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/deck/DeckFormat","equals","(Ljava/lang/Object;)Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int==0?73:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/deck/Deck","getOathbreaker","()Lforge/item/PaperCard;","invokevirtual",19);}
case 19:{f.Locals[5]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[5]);f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Reference!=null?30:26;continue;}
case 26:{f.Push(JValue.R(rt.String("is missing an oathbreaker")));f.Pc=29;continue;}
case 29:{return JStep.Return(f.Pop());}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/deck/Deck","getSignatureSpell","()Lforge/item/PaperCard;","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Reference!=null?41:37;continue;}
case 37:{f.Push(JValue.R(rt.String("is missing a signature spell")));f.Pc=40;continue;}
case 40:{return JStep.Return(f.Pop());}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/deck/Deck","getCommanders","()Ljava/util/List;","invokevirtual",45);}
case 45:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",50);}
case 50:{f.Push(JValue.I(2));f.Pc=51;continue;}
case 51:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?58:54;continue;}
case 54:{f.Push(JValue.R(rt.String("has too many commanders")));f.Pc=57;continue;}
case 57:{return JStep.Return(f.Pop());}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",63);}
case 63:{return rt.Call(f,"forge/card/CardRules","getColorIdentity","()Lforge/card/ColorSet;","invokevirtual",66);}
case 66:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",69);}
case 69:{f.Locals[3]=f.Pop();f.Pc=70;continue;}
case 70:{f.Pc=261;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/deck/Deck","getCommanders","()Ljava/util/List;","invokevirtual",77);}
case 77:{f.Locals[5]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[5]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",86);}
case 86:{f.Pc=f.Pop().Int==0?103:89;continue;}
case 89:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",92);}
case 92:{f.Push(JValue.R(rt.String("lblPlayerDoesntHaveCommander")));f.Pc=95;continue;}
case 95:{f.Push(JValue.I(0));f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",102);}
case 102:{return JStep.Return(f.Pop());}
case 103:{f.Push(f.Locals[5]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",110);}
case 110:{f.Push(JValue.I(2));f.Pc=111;continue;}
case 111:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?118:114;continue;}
case 114:{f.Push(JValue.R(rt.String("has too many commanders")));f.Pc=117;continue;}
case 117:{return JStep.Return(f.Pop());}
case 118:{f.Push(f.Locals[5]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",125);}
case 125:{f.Locals[6]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[6]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",134);}
case 134:{f.Pc=f.Pop().Int==0?204:137;continue;}
case 137:{f.Push(f.Locals[6]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",144);}
case 144:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=147;continue;}
case 147:{f.Locals[7]=f.Pop();f.Pc=149;continue;}
case 149:{f.Push(f.Locals[0]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[7]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",155);}
case 155:{return rt.Call(f,"forge/deck/DeckFormat","isLegalCommander","(Lforge/card/CardRules;)Z","invokevirtual",158);}
case 158:{f.Pc=f.Pop().Int!=0?165:161;continue;}
case 161:{f.Push(JValue.R(rt.String("has an illegal commander")));f.Pc=164;continue;}
case 164:{return JStep.Return(f.Pop());}
case 165:{f.Push(f.Locals[3]);f.Pc=166;continue;}
case 166:{f.Push(f.Locals[7]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",171);}
case 171:{return rt.Call(f,"forge/card/CardRules","getColorIdentity","()Lforge/card/ColorSet;","invokevirtual",174);}
case 174:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",177);}
case 177:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=178;continue;}
case 178:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=179;continue;}
case 179:{f.Locals[3]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[4]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[7]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",187);}
case 187:{return rt.Call(f,"forge/card/CardRules","getAddsWildCardColor","()Z","invokevirtual",190);}
case 190:{f.Pc=f.Pop().Int==0?197:193;continue;}
case 193:{f.Push(JValue.I(1));f.Pc=194;continue;}
case 194:{f.Pc=198;continue;}
case 197:{f.Push(JValue.I(0));f.Pc=198;continue;}
case 198:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=199;continue;}
case 199:{f.Locals[4]=f.Pop();f.Pc=201;continue;}
case 201:{f.Pc=127;continue;}
case 204:{f.Push(f.Locals[5]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",211);}
case 211:{f.Push(JValue.I(2));f.Pc=212;continue;}
case 212:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?261:215;continue;}
case 215:{f.Push(f.Locals[5]);f.Pc=217;continue;}
case 217:{f.Push(JValue.I(0));f.Pc=218;continue;}
case 218:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",223);}
case 223:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=226;continue;}
case 226:{f.Locals[6]=f.Pop();f.Pc=228;continue;}
case 228:{f.Push(f.Locals[5]);f.Pc=230;continue;}
case 230:{f.Push(JValue.I(1));f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",236);}
case 236:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=239;continue;}
case 239:{f.Locals[7]=f.Pop();f.Pc=241;continue;}
case 241:{f.Push(f.Locals[6]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",246);}
case 246:{f.Push(f.Locals[7]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",251);}
case 251:{return rt.Call(f,"forge/card/CardRules","canBePartnerCommanders","(Lforge/card/CardRules;)Z","invokevirtual",254);}
case 254:{f.Pc=f.Pop().Int!=0?261:257;continue;}
case 257:{f.Push(JValue.R(rt.String("has an illegal commander partnership")));f.Pc=260;continue;}
case 260:{return JStep.Return(f.Pop());}
case 261:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=264;continue;}
case 264:{f.StackOp("dup");f.Pc=265;continue;}
case 265:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",268);}
case 268:{f.Locals[5]=f.Pop();f.Pc=270;continue;}
case 270:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=273;continue;}
case 273:{f.StackOp("dup");f.Pc=274;continue;}
case 274:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",277);}
case 277:{f.Locals[6]=f.Pop();f.Pc=279;continue;}
case 279:{f.Push(f.Locals[1]);f.Pc=280;continue;}
case 280:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"));f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",286);}
case 286:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",289);}
case 289:{f.Locals[7]=f.Pop();f.Pc=291;continue;}
case 291:{f.Push(f.Locals[7]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",298);}
case 298:{f.Pc=f.Pop().Int==0?504:301;continue;}
case 301:{f.Push(f.Locals[7]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",308);}
case 308:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=311;continue;}
case 311:{f.Locals[8]=f.Pop();f.Pc=313;continue;}
case 313:{f.Push(f.Locals[3]);f.Pc=314;continue;}
case 314:{f.Pc=f.Pop().Int!=0?374:317;continue;}
case 317:{f.Push(f.Locals[8]);f.Pc=319;continue;}
case 319:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",324);}
case 324:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=327;continue;}
case 327:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",330);}
case 330:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",333);}
case 333:{return rt.Call(f,"forge/card/CardType","isBasicLand","()Z","invokevirtual",336);}
case 336:{f.Pc=f.Pop().Int==0?374:339;continue;}
case 339:{f.Push(f.Locals[6]);f.Pc=341;continue;}
case 341:{f.Push(f.Locals[8]);f.Pc=343;continue;}
case 343:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",348);}
case 348:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",354);}
case 354:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",359);}
case 359:{f.StackOp("pop");f.Pc=360;continue;}
case 360:{f.Push(f.Locals[6]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",367);}
case 367:{f.Push(JValue.I(2));f.Pc=368;continue;}
case 368:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?374:371;continue;}
case 371:{f.Pc=291;continue;}
case 374:{f.Push(f.Locals[2]);f.Pc=375;continue;}
case 375:{f.Push(f.Locals[8]);f.Pc=377;continue;}
case 377:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",382);}
case 382:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=385;continue;}
case 385:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",388);}
case 388:{return rt.Call(f,"forge/deck/DeckFormat","allowsOffColorIdentity","(Ljava/util/List;Lforge/card/CardRules;)Z","invokestatic",391);}
case 391:{f.Pc=f.Pop().Int==0?397:394;continue;}
case 394:{f.Pc=291;continue;}
case 397:{f.Push(f.Locals[2]);f.Pc=398;continue;}
case 398:{f.Push(f.Locals[8]);f.Pc=400;continue;}
case 400:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",405);}
case 405:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=408;continue;}
case 408:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",411);}
case 411:{f.Push(f.Locals[3]);f.Pc=412;continue;}
case 412:{return rt.Call(f,"forge/deck/DeckFormat","approvesAdditionalColor","(Ljava/util/List;Lforge/card/CardRules;B)Z","invokestatic",415);}
case 415:{f.Pc=f.Pop().Int==0?421:418;continue;}
case 418:{f.Pc=291;continue;}
case 421:{f.Push(f.Locals[8]);f.Pc=423;continue;}
case 423:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",428);}
case 428:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=431;continue;}
case 431:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",434);}
case 434:{return rt.Call(f,"forge/card/CardRules","getColorIdentity","()Lforge/card/ColorSet;","invokevirtual",437);}
case 437:{f.Push(f.Locals[3]);f.Pc=438;continue;}
case 438:{return rt.Call(f,"forge/card/ColorSet","getMissingColors","(B)Lforge/card/ColorSet;","invokevirtual",441);}
case 441:{f.Locals[9]=f.Pop();f.Pc=443;continue;}
case 443:{f.Push(f.Locals[9]);f.Pc=445;continue;}
case 445:{return rt.Call(f,"forge/card/ColorSet","countColors","()I","invokevirtual",448);}
case 448:{f.Pc=f.Pop().Int<=0?501:451;continue;}
case 451:{f.Push(f.Locals[9]);f.Pc=453;continue;}
case 453:{return rt.Call(f,"forge/card/ColorSet","countColors","()I","invokevirtual",456);}
case 456:{f.Push(f.Locals[4]);f.Pc=458;continue;}
case 458:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?483:461;continue;}
case 461:{f.Push(f.Locals[4]);f.Pc=463;continue;}
case 463:{f.Push(f.Locals[9]);f.Pc=465;continue;}
case 465:{return rt.Call(f,"forge/card/ColorSet","countColors","()I","invokevirtual",468);}
case 468:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=469;continue;}
case 469:{f.Locals[4]=f.Pop();f.Pc=471;continue;}
case 471:{f.Push(f.Locals[3]);f.Pc=472;continue;}
case 472:{f.Push(f.Locals[9]);f.Pc=474;continue;}
case 474:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",477);}
case 477:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=478;continue;}
case 478:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=479;continue;}
case 479:{f.Locals[3]=f.Pop();f.Pc=480;continue;}
case 480:{f.Pc=501;continue;}
case 483:{f.Push(f.Locals[5]);f.Pc=485;continue;}
case 485:{f.Push(f.Locals[8]);f.Pc=487;continue;}
case 487:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",492);}
case 492:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=495;continue;}
case 495:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",500);}
case 500:{f.StackOp("pop");f.Pc=501;continue;}
case 501:{f.Pc=291;continue;}
case 504:{f.Push(f.Locals[1]);f.Pc=505;continue;}
case 505:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=508;continue;}
case 508:{return rt.Call(f,"forge/deck/Deck","has","(Lforge/deck/DeckSection;)Z","invokevirtual",511);}
case 511:{f.Pc=f.Pop().Int==0?646:514;continue;}
case 514:{f.Push(f.Locals[0]);f.Pc=515;continue;}
case 515:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","CommanderDraft","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","CommanderDraft","Lforge/deck/DeckFormat;"));f.Pc=518;continue;}
case 518:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?646:521;continue;}
case 521:{f.Push(f.Locals[1]);f.Pc=522;continue;}
case 522:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=525;continue;}
case 525:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",528);}
case 528:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",531);}
case 531:{f.Locals[7]=f.Pop();f.Pc=533;continue;}
case 533:{f.Push(f.Locals[7]);f.Pc=535;continue;}
case 535:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",540);}
case 540:{f.Pc=f.Pop().Int==0?646:543;continue;}
case 543:{f.Push(f.Locals[7]);f.Pc=545;continue;}
case 545:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",550);}
case 550:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=553;continue;}
case 553:{f.Locals[8]=f.Pop();f.Pc=555;continue;}
case 555:{f.Push(f.Locals[2]);f.Pc=556;continue;}
case 556:{f.Push(f.Locals[8]);f.Pc=558;continue;}
case 558:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",563);}
case 563:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=566;continue;}
case 566:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",569);}
case 569:{return rt.Call(f,"forge/deck/DeckFormat","allowsOffColorIdentity","(Ljava/util/List;Lforge/card/CardRules;)Z","invokestatic",572);}
case 572:{f.Pc=f.Pop().Int==0?578:575;continue;}
case 575:{f.Pc=533;continue;}
case 578:{f.Push(f.Locals[2]);f.Pc=579;continue;}
case 579:{f.Push(f.Locals[8]);f.Pc=581;continue;}
case 581:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",586);}
case 586:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=589;continue;}
case 589:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",592);}
case 592:{f.Push(f.Locals[3]);f.Pc=593;continue;}
case 593:{return rt.Call(f,"forge/deck/DeckFormat","approvesAdditionalColor","(Ljava/util/List;Lforge/card/CardRules;B)Z","invokestatic",596);}
case 596:{f.Pc=f.Pop().Int==0?602:599;continue;}
case 599:{f.Pc=533;continue;}
case 602:{f.Push(f.Locals[8]);f.Pc=604;continue;}
case 604:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",609);}
case 609:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=612;continue;}
case 612:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",615);}
case 615:{return rt.Call(f,"forge/card/CardRules","getColorIdentity","()Lforge/card/ColorSet;","invokevirtual",618);}
case 618:{f.Push(f.Locals[3]);f.Pc=619;continue;}
case 619:{return rt.Call(f,"forge/card/ColorSet","hasNoColorsExcept","(I)Z","invokevirtual",622);}
case 622:{f.Pc=f.Pop().Int!=0?643:625;continue;}
case 625:{f.Push(f.Locals[5]);f.Pc=627;continue;}
case 627:{f.Push(f.Locals[8]);f.Pc=629;continue;}
case 629:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",634);}
case 634:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=637;continue;}
case 637:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",642);}
case 642:{f.StackOp("pop");f.Pc=643;continue;}
case 643:{f.Pc=533;continue;}
case 646:{f.Push(f.Locals[5]);f.Pc=648;continue;}
case 648:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",653);}
case 653:{f.Pc=f.Pop().Int!=0?725:656;continue;}
case 656:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=659;continue;}
case 659:{f.StackOp("dup");f.Pc=660;continue;}
case 660:{f.Push(JValue.R(rt.String("contains one or more cards that do not match the commanders color identity:")));f.Pc=663;continue;}
case 663:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",666);}
case 666:{f.Locals[7]=f.Pop();f.Pc=668;continue;}
case 668:{f.Push(f.Locals[5]);f.Pc=670;continue;}
case 670:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",675);}
case 675:{f.Locals[8]=f.Pop();f.Pc=677;continue;}
case 677:{f.Push(f.Locals[8]);f.Pc=679;continue;}
case 679:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",684);}
case 684:{f.Pc=f.Pop().Int==0?719:687;continue;}
case 687:{f.Push(f.Locals[8]);f.Pc=689;continue;}
case 689:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",694);}
case 694:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=697;continue;}
case 697:{f.Locals[9]=f.Pop();f.Pc=699;continue;}
case 699:{f.Push(f.Locals[7]);f.Pc=701;continue;}
case 701:{f.Push(JValue.R(rt.String("\n")));f.Pc=704;continue;}
case 704:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",707);}
case 707:{f.Push(f.Locals[9]);f.Pc=709;continue;}
case 709:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",712);}
case 712:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",715);}
case 715:{f.StackOp("pop");f.Pc=716;continue;}
case 716:{f.Pc=677;continue;}
case 719:{f.Push(f.Locals[7]);f.Pc=721;continue;}
case 721:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",724);}
case 724:{return JStep.Return(f.Pop());}
case 725:{f.Push(JValue.R(null));f.Pc=726;continue;}
case 726:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1438(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?39:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckRuleColorIdentity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/deck/DeckRuleColorIdentity","allowsOffColorIdentity","(Lforge/card/CardRules;)Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int==0?36:34;continue;}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 36:{f.Pc=7;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1439(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?42:16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckRuleColorIdentity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/deck/DeckRuleColorIdentity","approvesAdditionalColor","(Lforge/card/CardRules;B)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?39:37;continue;}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 39:{f.Pc=7;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1440(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/deck/CardPool","countAll","()I","invokevirtual",12);}
case 12:{f.Push(JValue.I(10));f.Pc=14;continue;}
case 14:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?21:17;continue;}
case 17:{f.Push(JValue.R(rt.String("must contain at least 10 attractions, or none at all")));f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",25);}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?97:35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",54);}
case 54:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/deck/CardPool","countByName","(Lforge/item/PaperCard;)I","invokevirtual",60);}
case 60:{f.Push(JValue.I(1));f.Pc=61;continue;}
case 61:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?94:64;continue;}
case 64:{f.Push(JValue.I(2));f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{f.Push(JValue.I(0));f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("contains more than 1 copy of the attraction")));f.Pc=73;continue;}
case 73:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=74;continue;}
case 74:{f.StackOp("dup");f.Pc=75;continue;}
case 75:{f.Push(JValue.I(1));f.Pc=76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",83);}
case 83:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",89);}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",93);}
case 93:{return JStep.Return(f.Pop());}
case 94:{f.Pc=26;continue;}
case 97:{f.Push(JValue.R(null));f.Pc=98;continue;}
case 98:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1441(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/deck/CardPool","countAll","()I","invokevirtual",12);}
case 12:{f.Push(JValue.I(10));f.Pc=14;continue;}
case 14:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?21:17;continue;}
case 17:{f.Push(JValue.R(rt.String("must contain at least 10 sticker sheets, or none at all")));f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",25);}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?97:35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",54);}
case 54:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/deck/CardPool","countByName","(Lforge/item/PaperCard;)I","invokevirtual",60);}
case 60:{f.Push(JValue.I(1));f.Pc=61;continue;}
case 61:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?94:64;continue;}
case 64:{f.Push(JValue.I(2));f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{f.Push(JValue.I(0));f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("contains more than 1 copy of the sticker sheet")));f.Pc=73;continue;}
case 73:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=74;continue;}
case 74:{f.StackOp("dup");f.Pc=75;continue;}
case 75:{f.Push(JValue.I(1));f.Pc=76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",83);}
case 83:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",89);}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",93);}
case 93:{return JStep.Return(f.Pop());}
case 94:{f.Pc=26;continue;}
case 97:{f.Push(JValue.R(null));f.Pc=98;continue;}
case 98:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1442(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/deck/CardPool","countAll","()I","invokevirtual",12);}
case 12:{f.Push(JValue.I(15));f.Pc=14;continue;}
case 14:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?21:17;continue;}
case 17:{f.Push(JValue.R(rt.String("must contain at least 15 contraptions, or none at all")));f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",25);}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?97:35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",54);}
case 54:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/deck/CardPool","countByName","(Lforge/item/PaperCard;)I","invokevirtual",60);}
case 60:{f.Push(JValue.I(1));f.Pc=61;continue;}
case 61:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?94:64;continue;}
case 64:{f.Push(JValue.I(2));f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{f.Push(JValue.I(0));f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("contains more than 1 copy of the contraption")));f.Pc=73;continue;}
case 73:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=74;continue;}
case 74:{f.StackOp("dup");f.Pc=75;continue;}
case 75:{f.Push(JValue.I(1));f.Pc=76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",83);}
case 83:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",89);}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",93);}
case 93:{return JStep.Return(f.Pop());}
case 94:{f.Pc=26;continue;}
case 97:{f.Push(JValue.R(null));f.Pc=98;continue;}
case 98:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1443(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/IPaperCard","getRules","()Lforge/card/CardRules;","invokeinterface",6);}
case 6:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/card/CardType","isBasicLand","()Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int!=0?38:15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/item/IPaperCard","getRules","()Lforge/card/CardRules;","invokeinterface",21);}
case 21:{return rt.Call(f,"forge/card/CardRules","getMainPart","()Lforge/card/ICardFace;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/card/ICardFace","getKeywords","()Ljava/lang/Iterable;","invokeinterface",29);}
case 29:{f.Push(JValue.R(rt.String("A deck can have any number of cards named CARDNAME.")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"com/google/common/collect/Iterables","contains","(Ljava/lang/Iterable;Ljava/lang/Object;)Z","invokestatic",35);}
case 35:{f.Pc=f.Pop().Int==0?42:38;continue;}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{f.Pc=43;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1444(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/IPaperCard","getRules","()Lforge/card/CardRules;","invokeinterface",6);}
case 6:{f.Push(JValue.R(rt.String("DeckLimit")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardRules","getKeywordMagnitude","(Ljava/lang/String;)Ljava/lang/Integer;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1445(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?13:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/deck/CardPool","countAll","()I","invokevirtual",8);}
case 8:{f.Push(JValue.I(10));f.Pc=10;continue;}
case 10:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?17:13;continue;}
case 13:{f.Push(JValue.R(rt.String("should have at least 10 planes")));f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{f.Locals[1]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",23);}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int==0?93:33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{f.Locals[3]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",55);}
case 55:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",58);}
case 58:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Phenomenon","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Phenomenon","Lforge/card/CardType$CoreType;"));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/card/CardType","hasType","(Lforge/card/CardType$CoreType;)Z","invokevirtual",64);}
case 64:{f.Pc=f.Pop().Int==0?70:67;continue;}
case 67:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(1)));f.Pc=70;continue;}
case 70:{f.Push(f.Locals[3]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",76);}
case 76:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",82);}
case 82:{f.Push(JValue.I(1));f.Pc=83;continue;}
case 83:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?90:86;continue;}
case 86:{f.Push(JValue.R(rt.String("must not contain multiple copies of any Plane or Phenomena")));f.Pc=89;continue;}
case 89:{return JStep.Return(f.Pop());}
case 90:{f.Pc=24;continue;}
case 93:{f.Push(f.Locals[1]);f.Pc=94;continue;}
case 94:{f.Push(JValue.I(2));f.Pc=95;continue;}
case 95:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?102:98;continue;}
case 98:{f.Push(JValue.R(rt.String("must not contain more than 2 Phenomena")));f.Pc=101;continue;}
case 101:{return JStep.Return(f.Pop());}
case 102:{f.Push(JValue.R(null));f.Pc=103;continue;}
case 103:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1446(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?13:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/deck/CardPool","countAll","()I","invokevirtual",8);}
case 8:{f.Push(JValue.I(20));f.Pc=10;continue;}
case 10:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?17:13;continue;}
case 13:{f.Push(JValue.R(rt.String("must contain at least 20 schemes")));f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",21);}
case 21:{f.Locals[1]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Int==0?110:31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Locals[2]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",53);}
case 53:{f.Push(JValue.I(2));f.Pc=54;continue;}
case 54:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?107:57;continue;}
case 57:{f.Push(JValue.I(4));f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=61;continue;}
case 61:{f.StackOp("dup");f.Pc=62;continue;}
case 62:{f.Push(JValue.I(0));f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("must not contain more than 2 copies of any Scheme, but has")));f.Pc=66;continue;}
case 66:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=67;continue;}
case 67:{f.StackOp("dup");f.Pc=68;continue;}
case 68:{f.Push(JValue.I(1));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",75);}
case 75:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",78);}
case 78:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=79;continue;}
case 79:{f.StackOp("dup");f.Pc=80;continue;}
case 80:{f.Push(JValue.I(2));f.Pc=81;continue;}
case 81:{f.Push(JValue.R(rt.String("of")));f.Pc=84;continue;}
case 84:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=85;continue;}
case 85:{f.StackOp("dup");f.Pc=86;continue;}
case 86:{f.Push(JValue.I(3));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[2]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",93);}
case 93:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",99);}
case 99:{return rt.Call(f,"forge/util/TextUtil","enclosedSingleQuote","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",102);}
case 102:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",106);}
case 106:{return JStep.Return(f.Pop());}
case 107:{f.Pc=22;continue;}
case 110:{f.Push(JValue.R(null));f.Pc=111;continue;}
case 111:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1447(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","cardPoolFilter","Ljava/util/function/Predicate;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?81:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","paperCardPoolFilter","Ljava/util/function/Predicate;"));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Reference!=null?16:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
case 16:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGenPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGenPool")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/deck/generation/DeckGenPool","<init>","()V","invokespecial",23);}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/deck/generation/IDeckGenPool","getAllCards","()Ljava/lang/Iterable;","invokeinterface",30);}
case 30:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",35);}
case 35:{f.Locals[3]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int==0?79:45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{f.Locals[4]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","paperCardPoolFilter","Ljava/util/function/Predicate;"));f.Pc=60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",67);}
case 67:{f.Pc=f.Pop().Int==0?76:70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[4]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/deck/generation/DeckGenPool","add","(Lforge/item/PaperCard;)V","invokevirtual",76);}
case 76:{f.Pc=36;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{return JStep.Return(f.Pop());}
case 81:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGenPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGenPool")));f.Pc=84;continue;}
case 84:{f.StackOp("dup");f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/deck/generation/DeckGenPool","<init>","()V","invokespecial",88);}
case 88:{f.Locals[2]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/deck/generation/IDeckGenPool","getAllCards","()Ljava/lang/Iterable;","invokeinterface",95);}
case 95:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",100);}
case 100:{f.Locals[3]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[3]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",107);}
case 107:{f.Pc=f.Pop().Int==0?147:110;continue;}
case 110:{f.Push(f.Locals[3]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",116);}
case 116:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=119;continue;}
case 119:{f.Locals[4]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","cardPoolFilter","Ljava/util/function/Predicate;"));f.Pc=125;continue;}
case 125:{f.Push(f.Locals[4]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",130);}
case 130:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",135);}
case 135:{f.Pc=f.Pop().Int==0?144:138;continue;}
case 138:{f.Push(f.Locals[2]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[4]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/deck/generation/DeckGenPool","add","(Lforge/item/PaperCard;)V","invokevirtual",144);}
case 144:{f.Pc=101;continue;}
case 147:{f.Push(f.Locals[2]);f.Pc=148;continue;}
case 148:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1448(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1449(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","allowCustomCardsInDecksConformance","()Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1450(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","cardPoolFilter","Ljava/util/function/Predicate;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?27:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","paperCardPoolFilter","Ljava/util/function/Predicate;"));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Reference!=null?16:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","paperCardPoolFilter","Ljava/util/function/Predicate;"));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",26);}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","cardPoolFilter","Ljava/util/function/Predicate;"));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",35);}
case 35:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",40);}
case 40:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1451(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","cardPoolFilter","Ljava/util/function/Predicate;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?22:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","cardPoolFilter","Ljava/util/function/Predicate;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int!=0?22:20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Oathbreaker","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Oathbreaker","Lforge/deck/DeckFormat;"));f.Pc=26;continue;}
case 26:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?34:29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/CardRules","canBeOathbreaker","()Z","invokevirtual",33);}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Brawl","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Brawl","Lforge/deck/DeckFormat;"));f.Pc=38;continue;}
case 38:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?46:41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/card/CardRules","canBeBrawlCommander","()Z","invokevirtual",45);}
case 45:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","TinyLeaders","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","TinyLeaders","Lforge/deck/DeckFormat;"));f.Pc=50;continue;}
case 50:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?58:53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/card/CardRules","canBeTinyLeadersCommander","()Z","invokevirtual",57);}
case 57:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/card/CardRules","canBeCommander","()Z","invokevirtual",62);}
case 62:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1452(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/DeckFormat","isLegalCommander","(Lforge/card/CardRules;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int==0?10:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int!=0?42:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/deck/DeckFormat","hasSignatureSpell","()Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int!=0?42:21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/card/CardRules","canBeCreature","()Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int!=0?38:28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",32);}
case 32:{return rt.Call(f,"forge/card/CardType","isPlaneswalker","()Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?42:38;continue;}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{f.Pc=43;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1453(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardRules","canBePartnerCommanders","(Lforge/card/CardRules;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int==0?34:8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Int==0?28:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/deck/DeckFormat","isLegalCommander","(Lforge/card/CardRules;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?32:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/deck/DeckFormat","isLegalCommander","(Lforge/card/CardRules;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?32:28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{f.Pc=33;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Int!=0?60:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/deck/DeckFormat","isAllowedCommander","(Lforge/card/CardRules;Z)Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int==0?60:47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/deck/DeckFormat","isAllowedCommander","(Lforge/card/CardRules;Z)Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int==0?60:56;continue;}
case 56:{f.Push(JValue.I(1));f.Pc=57;continue;}
case 57:{f.Pc=61;continue;}
case 60:{f.Push(JValue.I(0));f.Pc=61;continue;}
case 61:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1454(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/DeckFormat","hasSignatureSpell","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?9:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/deck/Deck","getCommanders","()Ljava/util/List;","invokevirtual",13);}
case 13:{f.Locals[4]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",22);}
case 22:{f.Push(JValue.I(1));f.Pc=23;continue;}
case 23:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?28:26;continue;}
case 26:{f.Push(JValue.R(null));f.Pc=27;continue;}
case 27:{return JStep.Return(f.Pop());}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[5]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",46);}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",50);}
case 50:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int==0?58:56;continue;}
case 56:{f.Push(JValue.R(null));f.Pc=57;continue;}
case 57:{return JStep.Return(f.Pop());}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[5]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",64);}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",68);}
case 68:{f.Push(f.Locals[3]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/deck/DeckFormat","isAllowedPartnership","(Lforge/card/CardRules;Lforge/card/CardRules;Z)Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?80:75;continue;}
case 75:{f.Push(f.Locals[5]);f.Pc=77;continue;}
case 77:{f.Pc=81;continue;}
case 80:{f.Push(JValue.R(null));f.Pc=81;continue;}
case 81:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1455(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?46:4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",8);}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/card/CardRules","canBePartnerCommanders","(Lforge/card/CardRules;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int!=0?46:18;continue;}
case 18:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",21);}
case 21:{f.Push(JValue.R(rt.String("lblConfirmIllegalPartner")));f.Pc=24;continue;}
case 24:{f.Push(JValue.I(2));f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",34);}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",41);}
case 41:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",45);}
case 45:{return JStep.Return(f.Pop());}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/deck/DeckFormat","hasSignatureSpell","()Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int!=0?64:53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",58);}
case 58:{return rt.Call(f,"forge/deck/DeckFormat","isLegalCommander","(Lforge/card/CardRules;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int==0?66:64;continue;}
case 64:{f.Push(JValue.R(null));f.Pc=65;continue;}
case 65:{return JStep.Return(f.Pop());}
case 66:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",69);}
case 69:{f.Push(JValue.R(rt.String("lblConfirmIllegalCommander")));f.Pc=72;continue;}
case 72:{f.Push(JValue.I(1));f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",82);}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",86);}
case 86:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1456(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/deck/DeckFormat:1456:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/deck/DeckFormat;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1457(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/deck/DeckFormat:1457:2:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/deck/DeckFormat;Z)Ljava/util/function/Predicate;",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1458(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/deck/DeckFormat:1458:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/deck/DeckFormat;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1459(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/deck/DeckFormat:1459:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/deck/DeckFormat;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1460(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",16);}
case 16:{f.Locals[4]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?126:28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[5]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[5]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",46);}
case 46:{return rt.Call(f,"forge/card/CardRules","getColorIdentity","()Lforge/card/ColorSet;","invokevirtual",49);}
case 49:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",52);}
case 52:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=53;continue;}
case 53:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=54;continue;}
case 54:{f.Locals[2]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/deck/DeckRule","parseAll","(Lforge/item/PaperCard;)Ljava/util/List;","invokestatic",60);}
case 60:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",65);}
case 65:{f.Locals[6]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[6]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",74);}
case 74:{f.Pc=f.Pop().Int==0?123:77;continue;}
case 77:{f.Push(f.Locals[6]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",84);}
case 84:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckRule"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=87;continue;}
case 87:{f.Locals[7]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[7]);f.Pc=91;continue;}
case 91:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/deck/DeckRuleColorIdentity")?1:0));f.Pc=94;continue;}
case 94:{f.Pc=f.Pop().Int==0?120:97;continue;}
case 97:{f.Push(f.Locals[7]);f.Pc=99;continue;}
case 99:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"));f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/deck/DeckRule","isActiveFor","(Lforge/deck/DeckSection;)Z","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Int==0?120:108;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[7]);f.Pc=111;continue;}
case 111:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckRuleColorIdentity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",119);}
case 119:{f.StackOp("pop");f.Pc=120;continue;}
case 120:{f.Pc=67;continue;}
case 123:{f.Pc=18;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{f.Push(JValue.I(31));f.Pc=129;continue;}
case 129:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?138:132;continue;}
case 132:{return rt.DynamicCall(f,"forge/deck/DeckFormat:1460:132:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",137);}
case 137:{return JStep.Return(f.Pop());}
case 138:{f.Push(f.Locals[2]);f.Pc=139;continue;}
case 139:{f.Locals[4]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[2]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/card/CardRulesPredicates","hasColorIdentity","(I)Ljava/util/function/Predicate;","invokestatic",145);}
case 145:{f.Push(f.Locals[3]);f.Pc=146;continue;}
case 146:{return rt.DynamicCall(f,"forge/deck/DeckFormat:1460:146:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/List;)Ljava/util/function/Predicate;",151);}
case 151:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",156);}
case 156:{f.Push(f.Locals[3]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[4]);f.Pc=159;continue;}
case 159:{return rt.DynamicCall(f,"forge/deck/DeckFormat:1460:159:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/List;B)Ljava/util/function/Predicate;",164);}
case 164:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",169);}
case 169:{f.Locals[5]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(f.Locals[1]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",177);}
case 177:{f.Push(JValue.I(1));f.Pc=178;continue;}
case 178:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?225:181;continue;}
case 181:{f.Push(f.Locals[1]);f.Pc=182;continue;}
case 182:{f.Push(JValue.I(0));f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",188);}
case 188:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",194);}
case 194:{return rt.Call(f,"forge/card/CardRules","canBePartnerCommander","()Z","invokevirtual",197);}
case 197:{f.Pc=f.Pop().Int==0?225:200;continue;}
case 200:{f.Push(f.Locals[5]);f.Pc=202;continue;}
case 202:{f.Push(f.Locals[1]);f.Pc=203;continue;}
case 203:{f.Push(JValue.I(0));f.Pc=204;continue;}
case 204:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",209);}
case 209:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",215);}
case 215:{return rt.Call(f,"forge/card/CardRulesPredicates","canBePartnerCommanderWith","(Lforge/card/CardRules;)Ljava/util/function/Predicate;","invokestatic",218);}
case 218:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",223);}
case 223:{f.Locals[5]=f.Pop();f.Pc=225;continue;}
case 225:{f.Push(f.Locals[5]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",230);}
case 230:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1461(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/deck/DeckFormat","approvesAdditionalColor","(Ljava/util/List;Lforge/card/CardRules;B)Z","invokestatic",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1462(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/DeckFormat","allowsOffColorIdentity","(Ljava/util/List;Lforge/card/CardRules;)Z","invokestatic",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1463(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1464(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/deck/DeckFormat","isLegalCommander","(Lforge/card/CardRules;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1465(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int!=0?6:4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","cardPoolFilter","Ljava/util/function/Predicate;"));f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Reference==null?71:13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/deck/Deck","getAllCardsInASinglePool","()Lforge/deck/CardPool;","invokevirtual",17);}
case 17:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",20);}
case 20:{f.Locals[3]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int==0?71:30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{f.Locals[4]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","cardPoolFilter","Ljava/util/function/Predicate;"));f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",58);}
case 58:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",63);}
case 63:{f.Pc=f.Pop().Int!=0?68:66;continue;}
case 66:{f.Push(JValue.I(0));f.Pc=67;continue;}
case 67:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 68:{f.Pc=21;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","paperCardPoolFilter","Ljava/util/function/Predicate;"));f.Pc=75;continue;}
case 75:{f.Pc=f.Pop().Reference==null?158:78;continue;}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/deck/Deck","getAllCardsInASinglePool","()Lforge/deck/CardPool;","invokevirtual",82);}
case 82:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",85);}
case 85:{f.Locals[3]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",92);}
case 92:{f.Pc=f.Pop().Int==0?158:95;continue;}
case 95:{f.Push(f.Locals[3]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",101);}
case 101:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=104;continue;}
case 104:{f.Locals[4]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(f.Locals[0]);f.Pc=107;continue;}
case 107:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat","paperCardPoolFilter","Ljava/util/function/Predicate;"));f.Pc=110;continue;}
case 110:{f.Push(f.Locals[4]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",117);}
case 117:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",125);}
case 125:{f.Pc=f.Pop().Int!=0?155:128;continue;}
case 128:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=131;continue;}
case 131:{f.Push(f.Locals[2]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",135);}
case 135:{f.Push(f.Locals[4]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",142);}
case 142:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",145);}
case 145:{return rt.DynamicCall(f,"forge/deck/DeckFormat:1465:145:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",150);}
case 150:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",153);}
case 153:{f.Push(JValue.I(0));f.Pc=154;continue;}
case 154:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 155:{f.Pc=86;continue;}
case 158:{f.Push(JValue.I(1));f.Pc=159;continue;}
case 159:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1466(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/DeckFormat","getDeckConformanceProblem","(Lforge/deck/Deck;)Ljava/lang/String;","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Reference!=null?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1467(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/card/CardDb","getNormalizedName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1468(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","getBrawlPredicate","()Ljava/util/function/Predicate;","invokevirtual",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1469(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","getOathbreakerPredicate","()Ljava/util/function/Predicate;","invokevirtual",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1470(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","getCommanderPredicate","()Ljava/util/function/Predicate;","invokevirtual",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1471(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(15));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/deck/DeckFormat;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","QuestDeck","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","QuestDeck","Lforge/deck/DeckFormat;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Limited","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Limited","Lforge/deck/DeckFormat;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Commander","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Commander","Lforge/deck/DeckFormat;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","CommanderDraft","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","CommanderDraft","Lforge/deck/DeckFormat;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Oathbreaker","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Oathbreaker","Lforge/deck/DeckFormat;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Pauper","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Pauper","Lforge/deck/DeckFormat;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Brawl","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Brawl","Lforge/deck/DeckFormat;"));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","TinyLeaders","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","TinyLeaders","Lforge/deck/DeckFormat;"));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(9));f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","PlanarConquest","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","PlanarConquest","Lforge/deck/DeckFormat;"));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(10));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Adventure","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Adventure","Lforge/deck/DeckFormat;"));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(11));f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Vanguard","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Vanguard","Lforge/deck/DeckFormat;"));f.Pc=82;continue;}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.I(12));f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Planechase","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Planechase","Lforge/deck/DeckFormat;"));f.Pc=89;continue;}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(JValue.I(13));f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Archenemy","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Archenemy","Lforge/deck/DeckFormat;"));f.Pc=96;continue;}
case 96:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{f.Push(JValue.I(14));f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Puzzle","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Puzzle","Lforge/deck/DeckFormat;"));f.Pc=103;continue;}
case 103:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=104;continue;}
case 104:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1472(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/deck/DeckFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckFormat")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Constructed")));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Push(JValue.I(60));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",13);}
case 13:{f.Push(JValue.I(2147483647));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",18);}
case 18:{return rt.Call(f,"org/apache/commons/lang3/Range","of","(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",21);}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",25);}
case 25:{f.Push(JValue.I(15));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",30);}
case 30:{return rt.Call(f,"org/apache/commons/lang3/Range","of","(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",33);}
case 33:{f.Push(JValue.I(4));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/deck/DeckFormat","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;I)V","invokespecial",37);}
case 37:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;",f.Pop());f.Pc=40;continue;}
case 40:{if(!rt.EnsureInitialized(f,"forge/deck/DeckFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckFormat")));f.Pc=43;continue;}
case 43:{f.StackOp("dup");f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("QuestDeck")));f.Pc=47;continue;}
case 47:{f.Push(JValue.I(1));f.Pc=48;continue;}
case 48:{f.Push(JValue.I(40));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",53);}
case 53:{f.Push(JValue.I(2147483647));f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",58);}
case 58:{return rt.Call(f,"org/apache/commons/lang3/Range","of","(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",61);}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",65);}
case 65:{f.Push(JValue.I(15));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",70);}
case 70:{return rt.Call(f,"org/apache/commons/lang3/Range","of","(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",73);}
case 73:{f.Push(JValue.I(4));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/deck/DeckFormat","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;I)V","invokespecial",77);}
case 77:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","QuestDeck","Lforge/deck/DeckFormat;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckFormat","QuestDeck","Lforge/deck/DeckFormat;",f.Pop());f.Pc=80;continue;}
case 80:{if(!rt.EnsureInitialized(f,"forge/deck/DeckFormat$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckFormat$1")));f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String("Limited")));f.Pc=87;continue;}
case 87:{f.Push(JValue.I(2));f.Pc=88;continue;}
case 88:{f.Push(JValue.I(40));f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",93);}
case 93:{f.Push(JValue.I(2147483647));f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",98);}
case 98:{return rt.Call(f,"org/apache/commons/lang3/Range","of","(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",101);}
case 101:{f.Push(JValue.R(null));f.Pc=102;continue;}
case 102:{f.Push(JValue.I(2147483647));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/deck/DeckFormat$1","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;I)V","invokespecial",107);}
case 107:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Limited","Lforge/deck/DeckFormat;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckFormat","Limited","Lforge/deck/DeckFormat;",f.Pop());f.Pc=110;continue;}
case 110:{if(!rt.EnsureInitialized(f,"forge/deck/DeckFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckFormat")));f.Pc=113;continue;}
case 113:{f.StackOp("dup");f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.String("Commander")));f.Pc=117;continue;}
case 117:{f.Push(JValue.I(3));f.Pc=118;continue;}
case 118:{f.Push(JValue.I(99));f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",123);}
case 123:{return rt.Call(f,"org/apache/commons/lang3/Range","is","(Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",126);}
case 126:{f.Push(JValue.I(0));f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",130);}
case 130:{f.Push(JValue.I(10));f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",135);}
case 135:{return rt.Call(f,"org/apache/commons/lang3/Range","of","(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",138);}
case 138:{f.Push(JValue.I(1));f.Pc=139;continue;}
case 139:{f.Push(JValue.R(null));f.Pc=140;continue;}
case 140:{return rt.DynamicCall(f,"forge/deck/DeckFormat:1472:140:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",145);}
case 145:{return rt.Call(f,"forge/deck/DeckFormat","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;ILjava/util/function/Predicate;Ljava/util/function/Predicate;)V","invokespecial",148);}
case 148:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Commander","Lforge/deck/DeckFormat;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckFormat","Commander","Lforge/deck/DeckFormat;",f.Pop());f.Pc=151;continue;}
case 151:{if(!rt.EnsureInitialized(f,"forge/deck/DeckFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckFormat")));f.Pc=154;continue;}
case 154:{f.StackOp("dup");f.Pc=155;continue;}
case 155:{f.Push(JValue.R(rt.String("CommanderDraft")));f.Pc=158;continue;}
case 158:{f.Push(JValue.I(4));f.Pc=159;continue;}
case 159:{f.Push(JValue.I(59));f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",164);}
case 164:{f.Push(JValue.I(99));f.Pc=166;continue;}
case 166:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",169);}
case 169:{return rt.Call(f,"org/apache/commons/lang3/Range","of","(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",172);}
case 172:{f.Push(JValue.R(null));f.Pc=173;continue;}
case 173:{f.Push(JValue.I(2147483647));f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/deck/DeckFormat","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;I)V","invokespecial",178);}
case 178:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","CommanderDraft","Lforge/deck/DeckFormat;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckFormat","CommanderDraft","Lforge/deck/DeckFormat;",f.Pop());f.Pc=181;continue;}
case 181:{if(!rt.EnsureInitialized(f,"forge/deck/DeckFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckFormat")));f.Pc=184;continue;}
case 184:{f.StackOp("dup");f.Pc=185;continue;}
case 185:{f.Push(JValue.R(rt.String("Oathbreaker")));f.Pc=188;continue;}
case 188:{f.Push(JValue.I(5));f.Pc=189;continue;}
case 189:{f.Push(JValue.I(58));f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",194);}
case 194:{return rt.Call(f,"org/apache/commons/lang3/Range","is","(Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",197);}
case 197:{f.Push(JValue.I(0));f.Pc=198;continue;}
case 198:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",201);}
case 201:{f.Push(JValue.I(10));f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",206);}
case 206:{return rt.Call(f,"org/apache/commons/lang3/Range","of","(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",209);}
case 209:{f.Push(JValue.I(1));f.Pc=210;continue;}
case 210:{f.Push(JValue.R(null));f.Pc=211;continue;}
case 211:{return rt.DynamicCall(f,"forge/deck/DeckFormat:1472:211:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",216);}
case 216:{return rt.Call(f,"forge/deck/DeckFormat","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;ILjava/util/function/Predicate;Ljava/util/function/Predicate;)V","invokespecial",219);}
case 219:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Oathbreaker","Lforge/deck/DeckFormat;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckFormat","Oathbreaker","Lforge/deck/DeckFormat;",f.Pop());f.Pc=222;continue;}
case 222:{if(!rt.EnsureInitialized(f,"forge/deck/DeckFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckFormat")));f.Pc=225;continue;}
case 225:{f.StackOp("dup");f.Pc=226;continue;}
case 226:{f.Push(JValue.R(rt.String("Pauper")));f.Pc=229;continue;}
case 229:{f.Push(JValue.I(6));f.Pc=231;continue;}
case 231:{f.Push(JValue.I(60));f.Pc=233;continue;}
case 233:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",236);}
case 236:{return rt.Call(f,"org/apache/commons/lang3/Range","is","(Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",239);}
case 239:{f.Push(JValue.I(0));f.Pc=240;continue;}
case 240:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",243);}
case 243:{f.Push(JValue.I(10));f.Pc=245;continue;}
case 245:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",248);}
case 248:{return rt.Call(f,"org/apache/commons/lang3/Range","of","(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",251);}
case 251:{f.Push(JValue.I(1));f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/deck/DeckFormat","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;I)V","invokespecial",255);}
case 255:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Pauper","Lforge/deck/DeckFormat;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckFormat","Pauper","Lforge/deck/DeckFormat;",f.Pop());f.Pc=258;continue;}
case 258:{if(!rt.EnsureInitialized(f,"forge/deck/DeckFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckFormat")));f.Pc=261;continue;}
case 261:{f.StackOp("dup");f.Pc=262;continue;}
case 262:{f.Push(JValue.R(rt.String("Brawl")));f.Pc=265;continue;}
case 265:{f.Push(JValue.I(7));f.Pc=267;continue;}
case 267:{f.Push(JValue.I(99));f.Pc=269;continue;}
case 269:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",272);}
case 272:{return rt.Call(f,"org/apache/commons/lang3/Range","is","(Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",275);}
case 275:{f.Push(JValue.I(0));f.Pc=276;continue;}
case 276:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",279);}
case 279:{f.Push(JValue.I(15));f.Pc=281;continue;}
case 281:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",284);}
case 284:{return rt.Call(f,"org/apache/commons/lang3/Range","of","(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",287);}
case 287:{f.Push(JValue.I(1));f.Pc=288;continue;}
case 288:{f.Push(JValue.R(null));f.Pc=289;continue;}
case 289:{return rt.DynamicCall(f,"forge/deck/DeckFormat:1472:289:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",294);}
case 294:{return rt.Call(f,"forge/deck/DeckFormat","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;ILjava/util/function/Predicate;Ljava/util/function/Predicate;)V","invokespecial",297);}
case 297:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Brawl","Lforge/deck/DeckFormat;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckFormat","Brawl","Lforge/deck/DeckFormat;",f.Pop());f.Pc=300;continue;}
case 300:{if(!rt.EnsureInitialized(f,"forge/deck/DeckFormat$2"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckFormat$2")));f.Pc=303;continue;}
case 303:{f.StackOp("dup");f.Pc=304;continue;}
case 304:{f.Push(JValue.R(rt.String("TinyLeaders")));f.Pc=307;continue;}
case 307:{f.Push(JValue.I(8));f.Pc=309;continue;}
case 309:{f.Push(JValue.I(49));f.Pc=311;continue;}
case 311:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",314);}
case 314:{return rt.Call(f,"org/apache/commons/lang3/Range","is","(Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",317);}
case 317:{f.Push(JValue.I(0));f.Pc=318;continue;}
case 318:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",321);}
case 321:{f.Push(JValue.I(10));f.Pc=323;continue;}
case 323:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",326);}
case 326:{return rt.Call(f,"org/apache/commons/lang3/Range","of","(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",329);}
case 329:{f.Push(JValue.I(1));f.Pc=330;continue;}
case 330:{if(!rt.EnsureInitialized(f,"forge/deck/DeckFormat$3"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckFormat$3")));f.Pc=333;continue;}
case 333:{f.StackOp("dup");f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/deck/DeckFormat$3","<init>","()V","invokespecial",337);}
case 337:{return rt.Call(f,"forge/deck/DeckFormat$2","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;ILjava/util/function/Predicate;)V","invokespecial",340);}
case 340:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","TinyLeaders","Lforge/deck/DeckFormat;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckFormat","TinyLeaders","Lforge/deck/DeckFormat;",f.Pop());f.Pc=343;continue;}
case 343:{if(!rt.EnsureInitialized(f,"forge/deck/DeckFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckFormat")));f.Pc=346;continue;}
case 346:{f.StackOp("dup");f.Pc=347;continue;}
case 347:{f.Push(JValue.R(rt.String("PlanarConquest")));f.Pc=350;continue;}
case 350:{f.Push(JValue.I(9));f.Pc=352;continue;}
case 352:{f.Push(JValue.I(40));f.Pc=354;continue;}
case 354:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",357);}
case 357:{f.Push(JValue.I(2147483647));f.Pc=359;continue;}
case 359:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",362);}
case 362:{return rt.Call(f,"org/apache/commons/lang3/Range","of","(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",365);}
case 365:{f.Push(JValue.I(0));f.Pc=366;continue;}
case 366:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",369);}
case 369:{return rt.Call(f,"org/apache/commons/lang3/Range","is","(Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",372);}
case 372:{f.Push(JValue.I(1));f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/deck/DeckFormat","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;I)V","invokespecial",376);}
case 376:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","PlanarConquest","Lforge/deck/DeckFormat;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckFormat","PlanarConquest","Lforge/deck/DeckFormat;",f.Pop());f.Pc=379;continue;}
case 379:{if(!rt.EnsureInitialized(f,"forge/deck/DeckFormat$4"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckFormat$4")));f.Pc=382;continue;}
case 382:{f.StackOp("dup");f.Pc=383;continue;}
case 383:{f.Push(JValue.R(rt.String("Adventure")));f.Pc=386;continue;}
case 386:{f.Push(JValue.I(10));f.Pc=388;continue;}
case 388:{f.Push(JValue.I(40));f.Pc=390;continue;}
case 390:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",393);}
case 393:{f.Push(JValue.I(2147483647));f.Pc=395;continue;}
case 395:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",398);}
case 398:{return rt.Call(f,"org/apache/commons/lang3/Range","of","(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",401);}
case 401:{f.Push(JValue.I(0));f.Pc=402;continue;}
case 402:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",405);}
case 405:{f.Push(JValue.I(2147483647));f.Pc=407;continue;}
case 407:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",410);}
case 410:{return rt.Call(f,"org/apache/commons/lang3/Range","of","(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",413);}
case 413:{f.Push(JValue.I(4));f.Pc=414;continue;}
case 414:{return rt.Call(f,"forge/deck/DeckFormat$4","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;I)V","invokespecial",417);}
case 417:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Adventure","Lforge/deck/DeckFormat;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckFormat","Adventure","Lforge/deck/DeckFormat;",f.Pop());f.Pc=420;continue;}
case 420:{if(!rt.EnsureInitialized(f,"forge/deck/DeckFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckFormat")));f.Pc=423;continue;}
case 423:{f.StackOp("dup");f.Pc=424;continue;}
case 424:{f.Push(JValue.R(rt.String("Vanguard")));f.Pc=427;continue;}
case 427:{f.Push(JValue.I(11));f.Pc=429;continue;}
case 429:{f.Push(JValue.I(60));f.Pc=431;continue;}
case 431:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",434);}
case 434:{f.Push(JValue.I(2147483647));f.Pc=436;continue;}
case 436:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",439);}
case 439:{return rt.Call(f,"org/apache/commons/lang3/Range","of","(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",442);}
case 442:{f.Push(JValue.I(0));f.Pc=443;continue;}
case 443:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",446);}
case 446:{return rt.Call(f,"org/apache/commons/lang3/Range","is","(Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",449);}
case 449:{f.Push(JValue.I(4));f.Pc=450;continue;}
case 450:{return rt.Call(f,"forge/deck/DeckFormat","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;I)V","invokespecial",453);}
case 453:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Vanguard","Lforge/deck/DeckFormat;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckFormat","Vanguard","Lforge/deck/DeckFormat;",f.Pop());f.Pc=456;continue;}
case 456:{if(!rt.EnsureInitialized(f,"forge/deck/DeckFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckFormat")));f.Pc=459;continue;}
case 459:{f.StackOp("dup");f.Pc=460;continue;}
case 460:{f.Push(JValue.R(rt.String("Planechase")));f.Pc=463;continue;}
case 463:{f.Push(JValue.I(12));f.Pc=465;continue;}
case 465:{f.Push(JValue.I(60));f.Pc=467;continue;}
case 467:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",470);}
case 470:{f.Push(JValue.I(2147483647));f.Pc=472;continue;}
case 472:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",475);}
case 475:{return rt.Call(f,"org/apache/commons/lang3/Range","of","(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",478);}
case 478:{f.Push(JValue.I(0));f.Pc=479;continue;}
case 479:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",482);}
case 482:{return rt.Call(f,"org/apache/commons/lang3/Range","is","(Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",485);}
case 485:{f.Push(JValue.I(4));f.Pc=486;continue;}
case 486:{return rt.Call(f,"forge/deck/DeckFormat","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;I)V","invokespecial",489);}
case 489:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Planechase","Lforge/deck/DeckFormat;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckFormat","Planechase","Lforge/deck/DeckFormat;",f.Pop());f.Pc=492;continue;}
case 492:{if(!rt.EnsureInitialized(f,"forge/deck/DeckFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckFormat")));f.Pc=495;continue;}
case 495:{f.StackOp("dup");f.Pc=496;continue;}
case 496:{f.Push(JValue.R(rt.String("Archenemy")));f.Pc=499;continue;}
case 499:{f.Push(JValue.I(13));f.Pc=501;continue;}
case 501:{f.Push(JValue.I(60));f.Pc=503;continue;}
case 503:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",506);}
case 506:{f.Push(JValue.I(2147483647));f.Pc=508;continue;}
case 508:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",511);}
case 511:{return rt.Call(f,"org/apache/commons/lang3/Range","of","(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",514);}
case 514:{f.Push(JValue.I(0));f.Pc=515;continue;}
case 515:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",518);}
case 518:{return rt.Call(f,"org/apache/commons/lang3/Range","is","(Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",521);}
case 521:{f.Push(JValue.I(4));f.Pc=522;continue;}
case 522:{return rt.Call(f,"forge/deck/DeckFormat","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;I)V","invokespecial",525);}
case 525:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Archenemy","Lforge/deck/DeckFormat;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckFormat","Archenemy","Lforge/deck/DeckFormat;",f.Pop());f.Pc=528;continue;}
case 528:{if(!rt.EnsureInitialized(f,"forge/deck/DeckFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckFormat")));f.Pc=531;continue;}
case 531:{f.StackOp("dup");f.Pc=532;continue;}
case 532:{f.Push(JValue.R(rt.String("Puzzle")));f.Pc=535;continue;}
case 535:{f.Push(JValue.I(14));f.Pc=537;continue;}
case 537:{f.Push(JValue.I(0));f.Pc=538;continue;}
case 538:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",541);}
case 541:{f.Push(JValue.I(2147483647));f.Pc=543;continue;}
case 543:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",546);}
case 546:{return rt.Call(f,"org/apache/commons/lang3/Range","of","(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",549);}
case 549:{f.Push(JValue.I(0));f.Pc=550;continue;}
case 550:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",553);}
case 553:{return rt.Call(f,"org/apache/commons/lang3/Range","is","(Ljava/lang/Comparable;)Lorg/apache/commons/lang3/Range;","invokestatic",556);}
case 556:{f.Push(JValue.I(4));f.Pc=557;continue;}
case 557:{return rt.Call(f,"forge/deck/DeckFormat","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;I)V","invokespecial",560);}
case 560:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Puzzle","Lforge/deck/DeckFormat;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckFormat","Puzzle","Lforge/deck/DeckFormat;",f.Pop());f.Pc=563;continue;}
case 563:{return rt.Call(f,"forge/deck/DeckFormat","$values","()[Lforge/deck/DeckFormat;","invokestatic",566);}
case 566:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","$VALUES","[Lforge/deck/DeckFormat;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckFormat","$VALUES","[Lforge/deck/DeckFormat;",f.Pop());f.Pc=569;continue;}
case 569:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C123{
internal static JClass Build(){var c=new JClass("forge/game/CardTraitBase","java/lang/Object",new string[]{"forge/game/GameObject","forge/game/card/IHasCardView","forge/game/IHasSVars"},1057);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("hostCard","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("cardState","Lforge/game/card/CardState;",false,JValue.Default("Lforge/game/card/CardState;"),null));
c.Add(new JField("keyword","Lforge/game/keyword/KeywordInterface;",false,JValue.Default("Lforge/game/keyword/KeywordInterface;"),null));
c.Add(new JField("originalMapParams","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("mapParams","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("intrinsic","Z",false,JValue.Default("Z"),null));
c.Add(new JField("suppressed","Z",false,JValue.Default("Z"),null));
c.Add(new JField("sVars","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("intrinsicChangedTextColors","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("intrinsicChangedTextTypes","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("changedTextColors","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("changedTextTypes","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("descriptiveKeys","Lcom/google/common/collect/ImmutableList;",true,JValue.Default("Lcom/google/common/collect/ImmutableList;"),null));
c.Add(new JField("noChangeKeys","Lcom/google/common/collect/ImmutableList;",true,JValue.Default("Lcom/google/common/collect/ImmutableList;"),null));
c.Add(new JMethod(1778,"forge/game/CardTraitBase","<init>","()V",1,1,2,new JHandler[]{},M1778));
c.Add(new JMethod(1779,"forge/game/CardTraitBase","getMapParams","()Ljava/util/Map;",17,1,1,new JHandler[]{},M1779));
c.Add(new JMethod(1780,"forge/game/CardTraitBase","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1,4,2,new JHandler[]{},M1780));
c.Add(new JMethod(1781,"forge/game/CardTraitBase","getParam","(Ljava/lang/String;)Ljava/lang/String;",1,2,2,new JHandler[]{},M1781));
c.Add(new JMethod(1782,"forge/game/CardTraitBase","getOriginalParam","(Ljava/lang/String;)Ljava/lang/String;",1,2,2,new JHandler[]{},M1782));
c.Add(new JMethod(1783,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z",1,2,2,new JHandler[]{},M1783));
c.Add(new JMethod(1784,"forge/game/CardTraitBase","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1,3,3,new JHandler[]{},M1784));
c.Add(new JMethod(1785,"forge/game/CardTraitBase","removeParam","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M1785));
c.Add(new JMethod(1786,"forge/game/CardTraitBase","getOriginalMapParams","()Ljava/util/Map;",17,1,1,new JHandler[]{},M1786));
c.Add(new JMethod(1787,"forge/game/CardTraitBase","isIntrinsic","()Z",1,1,1,new JHandler[]{},M1787));
c.Add(new JMethod(1788,"forge/game/CardTraitBase","setIntrinsic","(Z)V",1,2,2,new JHandler[]{},M1788));
c.Add(new JMethod(1789,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;",1,1,1,new JHandler[]{},M1789));
c.Add(new JMethod(1790,"forge/game/CardTraitBase","setHostCard","(Lforge/game/card/Card;)V",1,2,2,new JHandler[]{},M1790));
c.Add(new JMethod(1791,"forge/game/CardTraitBase","isKeyword","(Lforge/game/keyword/Keyword;)Z",1,2,2,new JHandler[]{},M1791));
c.Add(new JMethod(1792,"forge/game/CardTraitBase","getKeyword","()Lforge/game/keyword/KeywordInterface;",1,1,1,new JHandler[]{},M1792));
c.Add(new JMethod(1793,"forge/game/CardTraitBase","setKeyword","(Lforge/game/keyword/KeywordInterface;)V",1,2,2,new JHandler[]{},M1793));
c.Add(new JMethod(1794,"forge/game/CardTraitBase","isEmbalm","()Z",1,1,2,new JHandler[]{},M1794));
c.Add(new JMethod(1795,"forge/game/CardTraitBase","isEternalize","()Z",1,1,2,new JHandler[]{},M1795));
c.Add(new JMethod(1796,"forge/game/CardTraitBase","isSecondary","()Z",1,1,3,new JHandler[]{},M1796));
c.Add(new JMethod(1797,"forge/game/CardTraitBase","isClassAbility","()Z",17,1,2,new JHandler[]{},M1797));
c.Add(new JMethod(1798,"forge/game/CardTraitBase","isClassLevelNAbility","(I)Z",17,3,3,new JHandler[]{},M1798));
c.Add(new JMethod(1799,"forge/game/CardTraitBase","isManaAbility","()Z",1,1,1,new JHandler[]{},M1799));
c.Add(new JMethod(1800,"forge/game/CardTraitBase","matchesValid","(Ljava/lang/Object;[Ljava/lang/String;Lforge/game/card/Card;)Z",1,7,5,new JHandler[]{},M1800));
c.Add(new JMethod(1801,"forge/game/CardTraitBase","matchesValid","(Ljava/lang/Object;[Ljava/lang/String;Lforge/game/card/Card;Lforge/game/player/Player;)Z",1,13,5,new JHandler[]{},M1801));
c.Add(new JMethod(1802,"forge/game/CardTraitBase","matchesValid","(Ljava/lang/Object;[Ljava/lang/String;)Z",1,3,4,new JHandler[]{},M1802));
c.Add(new JMethod(1803,"forge/game/CardTraitBase","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;Lforge/game/card/Card;)Z",1,5,4,new JHandler[]{},M1803));
c.Add(new JMethod(1804,"forge/game/CardTraitBase","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z",1,3,4,new JHandler[]{},M1804));
c.Add(new JMethod(1805,"forge/game/CardTraitBase","setSuppressed","(Z)V",17,2,2,new JHandler[]{},M1805));
c.Add(new JMethod(1806,"forge/game/CardTraitBase","isSuppressed","()Z",17,1,1,new JHandler[]{},M1806));
c.Add(new JMethod(1807,"forge/game/CardTraitBase","meetsCommonRequirements","(Ljava/util/Map;)Z",4,14,5,new JHandler[]{},M1807));
c.Add(new JMethod(1808,"forge/game/CardTraitBase","getCardView","()Lforge/game/card/CardView;",1,1,1,new JHandler[]{},M1808));
c.Add(new JMethod(1809,"forge/game/CardTraitBase","getSVarFallback","(Ljava/lang/String;)Ljava/util/List;",4,3,2,new JHandler[]{},M1809));
c.Add(new JMethod(1810,"forge/game/CardTraitBase","findSVar","(Ljava/lang/String;)Ljava/util/Optional;",4,2,2,new JHandler[]{},M1810));
c.Add(new JMethod(1811,"forge/game/CardTraitBase","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M1811));
c.Add(new JMethod(1812,"forge/game/CardTraitBase","getSVar","(Ljava/lang/String;)Ljava/lang/String;",1,2,2,new JHandler[]{},M1812));
c.Add(new JMethod(1813,"forge/game/CardTraitBase","hasSVar","(Ljava/lang/String;)Z",1,2,2,new JHandler[]{},M1813));
c.Add(new JMethod(1814,"forge/game/CardTraitBase","getSVarInt","(Ljava/lang/String;)Ljava/lang/Integer;",1,4,2,new JHandler[]{new JHandler(10,17,18,"java/lang/Exception")},M1814));
c.Add(new JMethod(1815,"forge/game/CardTraitBase","setSVar","(Ljava/lang/String;Ljava/lang/String;)V",1,3,3,new JHandler[]{},M1815));
c.Add(new JMethod(1816,"forge/game/CardTraitBase","getSVars","()Ljava/util/Map;",1,4,2,new JHandler[]{},M1816));
c.Add(new JMethod(1817,"forge/game/CardTraitBase","setSVars","(Ljava/util/Map;)V",1,2,2,new JHandler[]{},M1817));
c.Add(new JMethod(1818,"forge/game/CardTraitBase","removeSVar","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M1818));
c.Add(new JMethod(1819,"forge/game/CardTraitBase","getCardState","()Lforge/game/card/CardState;",1,1,1,new JHandler[]{},M1819));
c.Add(new JMethod(1820,"forge/game/CardTraitBase","setCardState","(Lforge/game/card/CardState;)V",1,2,2,new JHandler[]{},M1820));
c.Add(new JMethod(1821,"forge/game/CardTraitBase","getCardStateName","()Lforge/card/CardStateName;",1,1,1,new JHandler[]{},M1821));
c.Add(new JMethod(1822,"forge/game/CardTraitBase","getHostName","(Lforge/game/CardTraitBase;)Lforge/util/ITranslatable;",1,2,2,new JHandler[]{},M1822));
c.Add(new JMethod(1823,"forge/game/CardTraitBase","getOriginalHost","()Lforge/game/card/Card;",1,1,1,new JHandler[]{},M1823));
c.Add(new JMethod(1824,"forge/game/CardTraitBase","isCopiedTrait","()Z",1,1,2,new JHandler[]{},M1824));
c.Add(new JMethod(1825,"forge/game/CardTraitBase","getChangedTextColors","()Ljava/util/Map;",1,1,3,new JHandler[]{},M1825));
c.Add(new JMethod(1826,"forge/game/CardTraitBase","getChangedTextTypes","()Ljava/util/Map;",1,1,3,new JHandler[]{},M1826));
c.Add(new JMethod(1827,"forge/game/CardTraitBase","_combineChangedMap","(Ljava/util/Map;Ljava/util/Map;)Ljava/util/Map;",2,7,5,new JHandler[]{},M1827));
}

private static void Add1(JClass c){
c.Add(new JMethod(1828,"forge/game/CardTraitBase","changeTextIntrinsic","(Ljava/util/Map;Ljava/util/Map;)V",1,7,4,new JHandler[]{},M1828));
c.Add(new JMethod(1829,"forge/game/CardTraitBase","changeText","()V",1,5,3,new JHandler[]{},M1829));
c.Add(new JMethod(1830,"forge/game/CardTraitBase","copyHelper","(Lforge/game/CardTraitBase;Lforge/game/card/Card;)V",4,3,4,new JHandler[]{},M1830));
c.Add(new JMethod(1831,"forge/game/CardTraitBase","copyHelper","(Lforge/game/CardTraitBase;Lforge/game/card/Card;Z)V",4,4,2,new JHandler[]{},M1831));
c.Add(new JMethod(1832,"forge/game/CardTraitBase","getTriggerRemembered","()Ljava/util/List;",1,3,1,new JHandler[]{},M1832));
c.Add(new JMethod(1833,"forge/game/CardTraitBase","lambda$getSVar$2","(Ljava/lang/String;Lforge/game/IHasSVars;)Ljava/lang/String;",4106,2,2,new JHandler[]{},M1833));
c.Add(new JMethod(1834,"forge/game/CardTraitBase","lambda$findSVar$1","(Ljava/lang/String;Lforge/game/IHasSVars;)Z",4106,2,2,new JHandler[]{},M1834));
c.Add(new JMethod(1835,"forge/game/CardTraitBase","lambda$meetsCommonRequirements$0","(Ljava/util/List;Lforge/game/player/Player;)Z",4106,2,2,new JHandler[]{},M1835));
c.Add(new JMethod(1836,"forge/game/CardTraitBase","<clinit>","()V",8,0,5,new JHandler[]{},M1836));
}

internal static JStep M1778(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","cardState","Lforge/game/card/CardState;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","keyword","Lforge/game/keyword/KeywordInterface;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",18);}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","originalMapParams","Ljava/util/Map;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",25);}
case 25:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","mapParams","Ljava/util/Map;",value);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","suppressed","Z",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"com/google/common/collect/Maps","newTreeMap","()Ljava/util/TreeMap;","invokestatic",37);}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","sVars","Ljava/util/Map;",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",44);}
case 44:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","intrinsicChangedTextColors","Ljava/util/Map;",value);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",51);}
case 51:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","intrinsicChangedTextTypes","Ljava/util/Map;",value);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",58);}
case 58:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","changedTextColors","Ljava/util/Map;",value);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",65);}
case 65:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","changedTextTypes","Ljava/util/Map;",value);f.Pc=68;continue;}
case 68:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1779(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","mapParams","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1780(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","mapParams","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Reference==null?22:18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{f.Pc=23;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1781(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","mapParams","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1782(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","originalMapParams","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1783(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","mapParams","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1784(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","mapParams","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",11);}
case 11:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1785(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","mapParams","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1786(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","originalMapParams","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1787(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","intrinsic","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1788(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","intrinsic","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1789(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","hostCard","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1790(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","hostCard","Lforge/game/card/Card;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1791(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","keyword","Lforge/game/keyword/KeywordInterface;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?24:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","keyword","Lforge/game/keyword/KeywordInterface;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getKeyword","()Lforge/game/keyword/Keyword;","invokeinterface",16);}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1792(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","keyword","Lforge/game/keyword/KeywordInterface;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1793(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","keyword","Lforge/game/keyword/KeywordInterface;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1794(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","EMBALM","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","EMBALM","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/CardTraitBase","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1795(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","ETERNALIZE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","ETERNALIZE","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/CardTraitBase","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1796(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Secondary")));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("False")));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/CardTraitBase","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",8);}
case 8:{f.Push(JValue.R(rt.String("True")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1797(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ClassLevel")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1798(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ClassLevel")));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("0")));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/CardTraitBase","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",13);}
case 13:{f.Pc=f.Pop().Int!=0?22:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(2));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",27);}
case 27:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?34:30;continue;}
case 30:{f.Push(JValue.I(1));f.Pc=31;continue;}
case 31:{f.Pc=35;continue;}
case 34:{f.Push(JValue.I(0));f.Pc=35;continue;}
case 35:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1799(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1800(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",10);}
case 10:{f.Locals[4]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Locals[6]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[6]);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/trigger/Trigger")?1:0));f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Int==0?48:23;continue;}
case 23:{f.Push(f.Locals[6]);f.Pc=25;continue;}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[5]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[5]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/trigger/Trigger","getSpawningAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Reference==null?48:38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/trigger/Trigger","getSpawningAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",43);}
case 43:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",46);}
case 46:{f.Locals[4]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/CardTraitBase","matchesValid","(Ljava/lang/Object;[Ljava/lang/String;Lforge/game/card/Card;Lforge/game/player/Player;)Z","invokevirtual",57);}
case 57:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1801(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/GameObject")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?26:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{f.Locals[5]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[5]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[4]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/GameObject","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokeinterface",25);}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/lang/Iterable")?1:0));f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Int==0?84:33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",42);}
case 42:{f.Locals[8]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[8]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",51);}
case 51:{f.Pc=f.Pop().Int==0?81:54;continue;}
case 54:{f.Push(f.Locals[8]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",61);}
case 61:{f.Locals[9]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[9]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[3]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/CardTraitBase","matchesValid","(Ljava/lang/Object;[Ljava/lang/String;Lforge/game/card/Card;Lforge/game/player/Player;)Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int==0?78:76;continue;}
case 76:{f.Push(JValue.I(1));f.Pc=77;continue;}
case 77:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 78:{f.Pc=44;continue;}
case 81:{f.Pc=242;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/lang/String")?1:0));f.Pc=88;continue;}
case 88:{f.Pc=f.Pop().Int==0?101:91;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"org/apache/commons/lang3/ArrayUtils","contains","([Ljava/lang/Object;Ljava/lang/Object;)Z","invokestatic",96);}
case 96:{f.Pc=f.Pop().Int==0?242:99;continue;}
case 99:{f.Push(JValue.I(1));f.Pc=100;continue;}
case 100:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/PlanarDice")?1:0));f.Pc=105;continue;}
case 105:{f.Pc=f.Pop().Int==0?173:108;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/PlanarDice"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=112;continue;}
case 112:{f.Locals[6]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{f.Locals[8]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[8]);f.Pc=119;continue;}
case 119:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=120;continue;}
case 120:{f.Locals[9]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(JValue.I(0));f.Pc=123;continue;}
case 123:{f.Locals[10]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[10]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[9]);f.Pc=129;continue;}
case 129:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?170:132;continue;}
case 132:{f.Push(f.Locals[8]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[10]);f.Pc=136;continue;}
case 136:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=137;continue;}
case 137:{f.Locals[11]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[11]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/PlanarDice","smartValueOf","(Ljava/lang/String;)Lforge/game/PlanarDice;","invokestatic",144);}
case 144:{f.Locals[12]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[6]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/PlanarDice","name","()Ljava/lang/String;","invokevirtual",151);}
case 151:{f.Push(f.Locals[12]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/PlanarDice","name","()Ljava/lang/String;","invokevirtual",156);}
case 156:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",159);}
case 159:{f.Pc=f.Pop().Int==0?164:162;continue;}
case 162:{f.Push(JValue.I(1));f.Pc=163;continue;}
case 163:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 164:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=167;continue;}
case 167:{f.Pc=125;continue;}
case 170:{f.Pc=242;continue;}
case 173:{f.Push(f.Locals[1]);f.Pc=174;continue;}
case 174:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/GameLossReason")?1:0));f.Pc=177;continue;}
case 177:{f.Pc=f.Pop().Int==0?242:180;continue;}
case 180:{f.Push(f.Locals[1]);f.Pc=181;continue;}
case 181:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/GameLossReason"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=184;continue;}
case 184:{f.Locals[7]=f.Pop();f.Pc=186;continue;}
case 186:{f.Push(f.Locals[2]);f.Pc=187;continue;}
case 187:{f.Locals[8]=f.Pop();f.Pc=189;continue;}
case 189:{f.Push(f.Locals[8]);f.Pc=191;continue;}
case 191:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=192;continue;}
case 192:{f.Locals[9]=f.Pop();f.Pc=194;continue;}
case 194:{f.Push(JValue.I(0));f.Pc=195;continue;}
case 195:{f.Locals[10]=f.Pop();f.Pc=197;continue;}
case 197:{f.Push(f.Locals[10]);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[9]);f.Pc=201;continue;}
case 201:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?242:204;continue;}
case 204:{f.Push(f.Locals[8]);f.Pc=206;continue;}
case 206:{f.Push(f.Locals[10]);f.Pc=208;continue;}
case 208:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=209;continue;}
case 209:{f.Locals[11]=f.Pop();f.Pc=211;continue;}
case 211:{f.Push(f.Locals[11]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/player/GameLossReason","smartValueOf","(Ljava/lang/String;)Lforge/game/player/GameLossReason;","invokestatic",216);}
case 216:{f.Locals[12]=f.Pop();f.Pc=218;continue;}
case 218:{f.Push(f.Locals[7]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/player/GameLossReason","name","()Ljava/lang/String;","invokevirtual",223);}
case 223:{f.Push(f.Locals[12]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"forge/game/player/GameLossReason","name","()Ljava/lang/String;","invokevirtual",228);}
case 228:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",231);}
case 231:{f.Pc=f.Pop().Int==0?236:234;continue;}
case 234:{f.Push(JValue.I(1));f.Pc=235;continue;}
case 235:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 236:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=239;continue;}
case 239:{f.Pc=197;continue;}
case 242:{f.Push(JValue.I(0));f.Pc=243;continue;}
case 243:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1802(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/CardTraitBase","matchesValid","(Ljava/lang/Object;[Ljava/lang/String;Lforge/game/card/Card;)Z","invokevirtual",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1803(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/CardTraitBase:1803:2:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",7);}
case 7:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",10);}
case 10:{f.Locals[4]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?42:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/CardTraitBase","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",27);}
case 27:{f.Push(JValue.R(rt.String(",")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/CardTraitBase","matchesValid","(Ljava/lang/Object;[Ljava/lang/String;Lforge/game/card/Card;)Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int!=0?42:39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{f.Pc=f.Pop().Int!=0?51:47;continue;}
case 47:{f.Push(JValue.I(1));f.Pc=48;continue;}
case 48:{f.Pc=52;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1804(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/CardTraitBase","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;Lforge/game/card/Card;)Z","invokevirtual",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1805(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","suppressed","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1806(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","suppressed","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1807(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",17);}
case 17:{return rt.Call(f,"forge/game/zone/MagicStack","isEmpty","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int!=0?63:23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",27);}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/game/zone/MagicStack","isResolving","(Lforge/game/card/Card;)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?63:37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/game/zone/MagicStack","peek","()Lforge/game/spellability/SpellAbilityStackInstance;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",47);}
case 47:{f.Locals[4]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int==0?63:57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",62);}
case 62:{f.Locals[2]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("Metalcraft")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",72);}
case 72:{f.Pc=f.Pop().Int==0?101:75;continue;}
case 75:{f.Push(JValue.R(rt.String("True")));f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("Metalcraft")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",86);}
case 86:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",92);}
case 92:{f.Push(f.Locals[2]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/player/Player","hasMetalcraft","()Z","invokevirtual",96);}
case 96:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?101:99;continue;}
case 99:{f.Push(JValue.I(0));f.Pc=100;continue;}
case 100:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String("Delirium")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",110);}
case 110:{f.Pc=f.Pop().Int==0?139:113;continue;}
case 113:{f.Push(JValue.R(rt.String("True")));f.Pc=115;continue;}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String("Delirium")));f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",124);}
case 124:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",130);}
case 130:{f.Push(f.Locals[2]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/player/Player","hasDelirium","()Z","invokevirtual",134);}
case 134:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?139:137;continue;}
case 137:{f.Push(JValue.I(0));f.Pc=138;continue;}
case 138:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 139:{f.Push(f.Locals[1]);f.Pc=140;continue;}
case 140:{f.Push(JValue.R(rt.String("Threshold")));f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",148);}
case 148:{f.Pc=f.Pop().Int==0?177:151;continue;}
case 151:{f.Push(JValue.R(rt.String("True")));f.Pc=153;continue;}
case 153:{f.Push(f.Locals[1]);f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String("Threshold")));f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",162);}
case 162:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",168);}
case 168:{f.Push(f.Locals[2]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/player/Player","hasThreshold","()Z","invokevirtual",172);}
case 172:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?177:175;continue;}
case 175:{f.Push(JValue.I(0));f.Pc=176;continue;}
case 176:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{f.Push(JValue.R(rt.String("Hellbent")));f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",186);}
case 186:{f.Pc=f.Pop().Int==0?215:189;continue;}
case 189:{f.Push(JValue.R(rt.String("True")));f.Pc=191;continue;}
case 191:{f.Push(f.Locals[1]);f.Pc=192;continue;}
case 192:{f.Push(JValue.R(rt.String("Hellbent")));f.Pc=195;continue;}
case 195:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",200);}
case 200:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",206);}
case 206:{f.Push(f.Locals[2]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/game/player/Player","hasHellbent","()Z","invokevirtual",210);}
case 210:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?215:213;continue;}
case 213:{f.Push(JValue.I(0));f.Pc=214;continue;}
case 214:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 215:{f.Push(f.Locals[1]);f.Pc=216;continue;}
case 216:{f.Push(JValue.R(rt.String("Bloodthirst")));f.Pc=219;continue;}
case 219:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",224);}
case 224:{f.Pc=f.Pop().Int==0?253:227;continue;}
case 227:{f.Push(JValue.R(rt.String("True")));f.Pc=229;continue;}
case 229:{f.Push(f.Locals[1]);f.Pc=230;continue;}
case 230:{f.Push(JValue.R(rt.String("Bloodthirst")));f.Pc=233;continue;}
case 233:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",238);}
case 238:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",244);}
case 244:{f.Push(f.Locals[2]);f.Pc=245;continue;}
case 245:{return rt.Call(f,"forge/game/player/Player","hasBloodthirst","()Z","invokevirtual",248);}
case 248:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?253:251;continue;}
case 251:{f.Push(JValue.I(0));f.Pc=252;continue;}
case 252:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 253:{f.Push(f.Locals[1]);f.Pc=254;continue;}
case 254:{f.Push(JValue.R(rt.String("FatefulHour")));f.Pc=257;continue;}
case 257:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",262);}
case 262:{f.Pc=f.Pop().Int==0?300:265;continue;}
case 265:{f.Push(JValue.R(rt.String("True")));f.Pc=267;continue;}
case 267:{f.Push(f.Locals[1]);f.Pc=268;continue;}
case 268:{f.Push(JValue.R(rt.String("FatefulHour")));f.Pc=271;continue;}
case 271:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",276);}
case 276:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=279;continue;}
case 279:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",282);}
case 282:{f.Push(f.Locals[2]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",286);}
case 286:{f.Push(JValue.I(5));f.Pc=287;continue;}
case 287:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?294:290;continue;}
case 290:{f.Push(JValue.I(1));f.Pc=291;continue;}
case 291:{f.Pc=295;continue;}
case 294:{f.Push(JValue.I(0));f.Pc=295;continue;}
case 295:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?300:298;continue;}
case 298:{f.Push(JValue.I(0));f.Pc=299;continue;}
case 299:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 300:{f.Push(f.Locals[1]);f.Pc=301;continue;}
case 301:{f.Push(JValue.R(rt.String("Monarch")));f.Pc=304;continue;}
case 304:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",309);}
case 309:{f.Pc=f.Pop().Int==0?338:312;continue;}
case 312:{f.Push(JValue.R(rt.String("True")));f.Pc=314;continue;}
case 314:{f.Push(f.Locals[1]);f.Pc=315;continue;}
case 315:{f.Push(JValue.R(rt.String("Monarch")));f.Pc=318;continue;}
case 318:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",323);}
case 323:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=326;continue;}
case 326:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",329);}
case 329:{f.Push(f.Locals[2]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/player/Player","isMonarch","()Z","invokevirtual",333);}
case 333:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?338:336;continue;}
case 336:{f.Push(JValue.I(0));f.Pc=337;continue;}
case 337:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 338:{f.Push(f.Locals[1]);f.Pc=339;continue;}
case 339:{f.Push(JValue.R(rt.String("Revolt")));f.Pc=342;continue;}
case 342:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",347);}
case 347:{f.Pc=f.Pop().Int==0?419:350;continue;}
case 350:{f.Push(JValue.R(rt.String("True")));f.Pc=352;continue;}
case 352:{f.Push(f.Locals[1]);f.Pc=353;continue;}
case 353:{f.Push(JValue.R(rt.String("Revolt")));f.Pc=356;continue;}
case 356:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",361);}
case 361:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=364;continue;}
case 364:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",367);}
case 367:{f.Push(f.Locals[2]);f.Pc=368;continue;}
case 368:{return rt.Call(f,"forge/game/player/Player","hasRevolt","()Z","invokevirtual",371);}
case 371:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?376:374;continue;}
case 374:{f.Push(JValue.I(0));f.Pc=375;continue;}
case 375:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 376:{f.Push(JValue.R(rt.String("None")));f.Pc=379;continue;}
case 379:{f.Push(f.Locals[1]);f.Pc=380;continue;}
case 380:{f.Push(JValue.R(rt.String("Revolt")));f.Pc=383;continue;}
case 383:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",388);}
case 388:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=391;continue;}
case 391:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",394);}
case 394:{f.Pc=f.Pop().Int==0?419:397;continue;}
case 397:{f.Push(f.Locals[3]);f.Pc=398;continue;}
case 398:{return rt.Call(f,"forge/game/Game","getRegisteredPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",401);}
case 401:{return rt.Call(f,"forge/game/player/PlayerCollection","stream","()Ljava/util/stream/Stream;","invokevirtual",404);}
case 404:{return rt.DynamicCall(f,"forge/game/CardTraitBase:1807:404:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",409);}
case 409:{return rt.Call(f,"java/util/stream/Stream","noneMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",414);}
case 414:{f.Pc=f.Pop().Int!=0?419:417;continue;}
case 417:{f.Push(JValue.I(0));f.Pc=418;continue;}
case 418:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 419:{f.Push(f.Locals[1]);f.Pc=420;continue;}
case 420:{f.Push(JValue.R(rt.String("Blessing")));f.Pc=423;continue;}
case 423:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",428);}
case 428:{f.Pc=f.Pop().Int==0?457:431;continue;}
case 431:{f.Push(JValue.R(rt.String("True")));f.Pc=433;continue;}
case 433:{f.Push(f.Locals[1]);f.Pc=434;continue;}
case 434:{f.Push(JValue.R(rt.String("Blessing")));f.Pc=437;continue;}
case 437:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",442);}
case 442:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=445;continue;}
case 445:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",448);}
case 448:{f.Push(f.Locals[2]);f.Pc=449;continue;}
case 449:{return rt.Call(f,"forge/game/player/Player","hasBlessing","()Z","invokevirtual",452);}
case 452:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?457:455;continue;}
case 455:{f.Push(JValue.I(0));f.Pc=456;continue;}
case 456:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 457:{f.Push(f.Locals[1]);f.Pc=458;continue;}
case 458:{f.Push(JValue.R(rt.String("EnduringStory")));f.Pc=461;continue;}
case 461:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",466);}
case 466:{f.Pc=f.Pop().Int==0?495:469;continue;}
case 469:{f.Push(JValue.R(rt.String("True")));f.Pc=471;continue;}
case 471:{f.Push(f.Locals[1]);f.Pc=472;continue;}
case 472:{f.Push(JValue.R(rt.String("EnduringStory")));f.Pc=475;continue;}
case 475:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",480);}
case 480:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=483;continue;}
case 483:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",486);}
case 486:{f.Push(f.Locals[2]);f.Pc=487;continue;}
case 487:{return rt.Call(f,"forge/game/player/Player","hasEnduringStory","()Z","invokevirtual",490);}
case 490:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?495:493;continue;}
case 493:{f.Push(JValue.I(0));f.Pc=494;continue;}
case 494:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 495:{f.Push(f.Locals[1]);f.Pc=496;continue;}
case 496:{f.Push(JValue.R(rt.String("DayTime")));f.Pc=499;continue;}
case 499:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",504);}
case 504:{f.Pc=f.Pop().Int==0?597:507;continue;}
case 507:{f.Push(JValue.R(rt.String("Day")));f.Pc=510;continue;}
case 510:{f.Push(f.Locals[1]);f.Pc=511;continue;}
case 511:{f.Push(JValue.R(rt.String("DayTime")));f.Pc=514;continue;}
case 514:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",519);}
case 519:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=522;continue;}
case 522:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",525);}
case 525:{f.Pc=f.Pop().Int==0?537:528;continue;}
case 528:{f.Push(f.Locals[3]);f.Pc=529;continue;}
case 529:{return rt.Call(f,"forge/game/Game","isDay","()Z","invokevirtual",532);}
case 532:{f.Pc=f.Pop().Int!=0?597:535;continue;}
case 535:{f.Push(JValue.I(0));f.Pc=536;continue;}
case 536:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 537:{f.Push(JValue.R(rt.String("Night")));f.Pc=540;continue;}
case 540:{f.Push(f.Locals[1]);f.Pc=541;continue;}
case 541:{f.Push(JValue.R(rt.String("DayTime")));f.Pc=544;continue;}
case 544:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",549);}
case 549:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=552;continue;}
case 552:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",555);}
case 555:{f.Pc=f.Pop().Int==0?567:558;continue;}
case 558:{f.Push(f.Locals[3]);f.Pc=559;continue;}
case 559:{return rt.Call(f,"forge/game/Game","isNight","()Z","invokevirtual",562);}
case 562:{f.Pc=f.Pop().Int!=0?597:565;continue;}
case 565:{f.Push(JValue.I(0));f.Pc=566;continue;}
case 566:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 567:{f.Push(JValue.R(rt.String("Neither")));f.Pc=570;continue;}
case 570:{f.Push(f.Locals[1]);f.Pc=571;continue;}
case 571:{f.Push(JValue.R(rt.String("DayTime")));f.Pc=574;continue;}
case 574:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",579);}
case 579:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=582;continue;}
case 582:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",585);}
case 585:{f.Pc=f.Pop().Int==0?597:588;continue;}
case 588:{f.Push(f.Locals[3]);f.Pc=589;continue;}
case 589:{return rt.Call(f,"forge/game/Game","isNeitherDayNorNight","()Z","invokevirtual",592);}
case 592:{f.Pc=f.Pop().Int!=0?597:595;continue;}
case 595:{f.Push(JValue.I(0));f.Pc=596;continue;}
case 596:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 597:{f.Push(f.Locals[1]);f.Pc=598;continue;}
case 598:{f.Push(JValue.R(rt.String("Adamant")));f.Pc=601;continue;}
case 601:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",606);}
case 606:{f.Pc=f.Pop().Int==0?750:609;continue;}
case 609:{f.Push(f.Locals[0]);f.Pc=610;continue;}
case 610:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","hostCard","Lforge/game/card/Card;"));f.Pc=613;continue;}
case 613:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",616);}
case 616:{f.Pc=f.Pop().Reference!=null?621:619;continue;}
case 619:{f.Push(JValue.I(0));f.Pc=620;continue;}
case 620:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 621:{f.Push(JValue.I(1));f.Pc=622;continue;}
case 622:{f.Push(JValue.R(rt.NewArray("Ljava/util/List;",f.Pop().Int)));f.Pc=625;continue;}
case 625:{f.StackOp("dup");f.Pc=626;continue;}
case 626:{f.Push(JValue.I(0));f.Pc=627;continue;}
case 627:{f.Push(f.Locals[0]);f.Pc=628;continue;}
case 628:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","hostCard","Lforge/game/card/Card;"));f.Pc=631;continue;}
case 631:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",634);}
case 634:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingMana","()Ljava/util/List;","invokevirtual",637);}
case 637:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=638;continue;}
case 638:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","([Ljava/lang/Object;)Ljava/lang/String;","invokestatic",641);}
case 641:{f.Locals[4]=f.Pop();f.Pc=643;continue;}
case 643:{f.Push(f.Locals[1]);f.Pc=644;continue;}
case 644:{f.Push(JValue.R(rt.String("Adamant")));f.Pc=647;continue;}
case 647:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",652);}
case 652:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=655;continue;}
case 655:{f.Locals[5]=f.Pop();f.Pc=657;continue;}
case 657:{f.Push(JValue.R(rt.String("Any")));f.Pc=660;continue;}
case 660:{f.Push(f.Locals[5]);f.Pc=662;continue;}
case 662:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",665);}
case 665:{f.Pc=f.Pop().Int==0?734:668;continue;}
case 668:{f.Push(JValue.I(0));f.Pc=669;continue;}
case 669:{f.Locals[6]=f.Pop();f.Pc=671;continue;}
case 671:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=674;continue;}
case 674:{f.Locals[7]=f.Pop();f.Pc=676;continue;}
case 676:{f.Push(f.Locals[7]);f.Pc=678;continue;}
case 678:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=679;continue;}
case 679:{f.Locals[8]=f.Pop();f.Pc=681;continue;}
case 681:{f.Push(JValue.I(0));f.Pc=682;continue;}
case 682:{f.Locals[9]=f.Pop();f.Pc=684;continue;}
case 684:{f.Push(f.Locals[9]);f.Pc=686;continue;}
case 686:{f.Push(f.Locals[8]);f.Pc=688;continue;}
case 688:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?724:691;continue;}
case 691:{f.Push(f.Locals[7]);f.Pc=693;continue;}
case 693:{f.Push(f.Locals[9]);f.Pc=695;continue;}
case 695:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=696;continue;}
case 696:{f.Locals[10]=f.Pop();f.Pc=698;continue;}
case 698:{f.Push(f.Locals[4]);f.Pc=700;continue;}
case 700:{f.Push(f.Locals[10]);f.Pc=702;continue;}
case 702:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",705);}
case 705:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","countMatches","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I","invokestatic",708);}
case 708:{f.Push(JValue.I(3));f.Pc=709;continue;}
case 709:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?718:712;continue;}
case 712:{f.Push(JValue.I(1));f.Pc=713;continue;}
case 713:{f.Locals[6]=f.Pop();f.Pc=715;continue;}
case 715:{f.Pc=724;continue;}
case 718:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(1)));f.Pc=721;continue;}
case 721:{f.Pc=684;continue;}
case 724:{f.Push(f.Locals[6]);f.Pc=726;continue;}
case 726:{f.Pc=f.Pop().Int!=0?731:729;continue;}
case 729:{f.Push(JValue.I(0));f.Pc=730;continue;}
case 730:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 731:{f.Pc=750;continue;}
case 734:{f.Push(f.Locals[4]);f.Pc=736;continue;}
case 736:{f.Push(f.Locals[5]);f.Pc=738;continue;}
case 738:{return rt.Call(f,"forge/card/MagicColor","toShortString","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",741);}
case 741:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","countMatches","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I","invokestatic",744);}
case 744:{f.Push(JValue.I(3));f.Pc=745;continue;}
case 745:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?750:748;continue;}
case 748:{f.Push(JValue.I(0));f.Pc=749;continue;}
case 749:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 750:{f.Push(f.Locals[1]);f.Pc=751;continue;}
case 751:{f.Push(JValue.R(rt.String("LifeTotal")));f.Pc=754;continue;}
case 754:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",759);}
case 759:{f.Pc=f.Pop().Int==0?876:762;continue;}
case 762:{f.Push(f.Locals[1]);f.Pc=763;continue;}
case 763:{f.Push(JValue.R(rt.String("LifeTotal")));f.Pc=766;continue;}
case 766:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",771);}
case 771:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=774;continue;}
case 774:{f.Locals[4]=f.Pop();f.Pc=776;continue;}
case 776:{f.Push(f.Locals[0]);f.Pc=777;continue;}
case 777:{f.Push(JValue.R(rt.String("LifeAmount")));f.Pc=780;continue;}
case 780:{f.Push(JValue.R(rt.String("GE1")));f.Pc=783;continue;}
case 783:{return rt.Call(f,"forge/game/CardTraitBase","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",786);}
case 786:{f.Locals[5]=f.Pop();f.Pc=788;continue;}
case 788:{f.Push(JValue.I(1));f.Pc=789;continue;}
case 789:{f.Locals[6]=f.Pop();f.Pc=791;continue;}
case 791:{f.Push(f.Locals[4]);f.Pc=793;continue;}
case 793:{f.Push(JValue.R(rt.String("You")));f.Pc=796;continue;}
case 796:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",799);}
case 799:{f.Pc=f.Pop().Int==0?808:802;continue;}
case 802:{f.Push(f.Locals[2]);f.Pc=803;continue;}
case 803:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",806);}
case 806:{f.Locals[6]=f.Pop();f.Pc=808;continue;}
case 808:{f.Push(f.Locals[4]);f.Pc=810;continue;}
case 810:{f.Push(JValue.R(rt.String("OpponentSmallest")));f.Pc=813;continue;}
case 813:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",816);}
case 816:{f.Pc=f.Pop().Int==0?825:819;continue;}
case 819:{f.Push(f.Locals[2]);f.Pc=820;continue;}
case 820:{return rt.Call(f,"forge/game/player/Player","getOpponentsSmallestLifeTotal","()I","invokevirtual",823);}
case 823:{f.Locals[6]=f.Pop();f.Pc=825;continue;}
case 825:{f.Push(f.Locals[4]);f.Pc=827;continue;}
case 827:{f.Push(JValue.R(rt.String("OpponentGreatest")));f.Pc=830;continue;}
case 830:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",833);}
case 833:{f.Pc=f.Pop().Int==0?842:836;continue;}
case 836:{f.Push(f.Locals[2]);f.Pc=837;continue;}
case 837:{return rt.Call(f,"forge/game/player/Player","getOpponentsGreatestLifeTotal","()I","invokevirtual",840);}
case 840:{f.Locals[6]=f.Pop();f.Pc=842;continue;}
case 842:{f.Push(f.Locals[5]);f.Pc=844;continue;}
case 844:{f.Push(JValue.I(2));f.Pc=845;continue;}
case 845:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",848);}
case 848:{f.Locals[7]=f.Pop();f.Pc=850;continue;}
case 850:{f.Push(f.Locals[0]);f.Pc=851;continue;}
case 851:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",854);}
case 854:{f.Push(f.Locals[7]);f.Pc=856;continue;}
case 856:{f.Push(f.Locals[0]);f.Pc=857;continue;}
case 857:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",860);}
case 860:{f.Locals[8]=f.Pop();f.Pc=862;continue;}
case 862:{f.Push(f.Locals[6]);f.Pc=864;continue;}
case 864:{f.Push(f.Locals[5]);f.Pc=866;continue;}
case 866:{f.Push(f.Locals[8]);f.Pc=868;continue;}
case 868:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",871);}
case 871:{f.Pc=f.Pop().Int!=0?876:874;continue;}
case 874:{f.Push(JValue.I(0));f.Pc=875;continue;}
case 875:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 876:{f.Push(f.Locals[1]);f.Pc=877;continue;}
case 877:{f.Push(JValue.R(rt.String("IsPresent")));f.Pc=880;continue;}
case 880:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",885);}
case 885:{f.Pc=f.Pop().Int==0?1163:888;continue;}
case 888:{f.Push(f.Locals[1]);f.Pc=889;continue;}
case 889:{f.Push(JValue.R(rt.String("IsPresent")));f.Pc=892;continue;}
case 892:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",897);}
case 897:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=900;continue;}
case 900:{f.Locals[4]=f.Pop();f.Pc=902;continue;}
case 902:{f.Push(f.Locals[0]);f.Pc=903;continue;}
case 903:{f.Push(JValue.R(rt.String("PresentCompare")));f.Pc=906;continue;}
case 906:{f.Push(JValue.R(rt.String("GE1")));f.Pc=909;continue;}
case 909:{return rt.Call(f,"forge/game/CardTraitBase","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",912);}
case 912:{f.Locals[5]=f.Pop();f.Pc=914;continue;}
case 914:{f.Push(f.Locals[0]);f.Pc=915;continue;}
case 915:{f.Push(JValue.R(rt.String("PresentPlayer")));f.Pc=918;continue;}
case 918:{f.Push(JValue.R(rt.String("Any")));f.Pc=921;continue;}
case 921:{return rt.Call(f,"forge/game/CardTraitBase","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",924);}
case 924:{f.Locals[6]=f.Pop();f.Pc=926;continue;}
case 926:{f.Push(f.Locals[1]);f.Pc=927;continue;}
case 927:{f.Push(JValue.R(rt.String("PresentDefined")));f.Pc=930;continue;}
case 930:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",935);}
case 935:{f.Pc=f.Pop().Int==0?963:938;continue;}
case 938:{f.Push(f.Locals[0]);f.Pc=939;continue;}
case 939:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",942);}
case 942:{f.Push(f.Locals[1]);f.Pc=943;continue;}
case 943:{f.Push(JValue.R(rt.String("PresentDefined")));f.Pc=946;continue;}
case 946:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",951);}
case 951:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=954;continue;}
case 954:{f.Push(f.Locals[0]);f.Pc=955;continue;}
case 955:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",958);}
case 958:{f.Locals[7]=f.Pop();f.Pc=960;continue;}
case 960:{f.Pc=1107;continue;}
case 963:{f.Push(f.Locals[1]);f.Pc=964;continue;}
case 964:{f.Push(JValue.R(rt.String("PresentZone")));f.Pc=967;continue;}
case 967:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",972);}
case 972:{f.Pc=f.Pop().Int==0?993:975;continue;}
case 975:{f.Push(f.Locals[1]);f.Pc=976;continue;}
case 976:{f.Push(JValue.R(rt.String("PresentZone")));f.Pc=979;continue;}
case 979:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",984);}
case 984:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=987;continue;}
case 987:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",990);}
case 990:{f.Pc=999;continue;}
case 993:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=996;continue;}
case 996:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",999);}
case 999:{f.Locals[8]=f.Pop();f.Pc=1001;continue;}
case 1001:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1004;continue;}
case 1004:{f.StackOp("dup");f.Pc=1005;continue;}
case 1005:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",1008);}
case 1008:{f.Locals[7]=f.Pop();f.Pc=1010;continue;}
case 1010:{f.Push(f.Locals[6]);f.Pc=1012;continue;}
case 1012:{f.Push(JValue.R(rt.String("You")));f.Pc=1015;continue;}
case 1015:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1018);}
case 1018:{f.Pc=f.Pop().Int!=0?1032:1021;continue;}
case 1021:{f.Push(f.Locals[6]);f.Pc=1023;continue;}
case 1023:{f.Push(JValue.R(rt.String("Any")));f.Pc=1026;continue;}
case 1026:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1029);}
case 1029:{f.Pc=f.Pop().Int==0?1044:1032;continue;}
case 1032:{f.Push(f.Locals[7]);f.Pc=1034;continue;}
case 1034:{f.Push(f.Locals[2]);f.Pc=1035;continue;}
case 1035:{f.Push(f.Locals[8]);f.Pc=1037;continue;}
case 1037:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",1040);}
case 1040:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1043);}
case 1043:{f.StackOp("pop");f.Pc=1044;continue;}
case 1044:{f.Push(f.Locals[6]);f.Pc=1046;continue;}
case 1046:{f.Push(JValue.R(rt.String("Opponent")));f.Pc=1049;continue;}
case 1049:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1052);}
case 1052:{f.Pc=f.Pop().Int!=0?1066:1055;continue;}
case 1055:{f.Push(f.Locals[6]);f.Pc=1057;continue;}
case 1057:{f.Push(JValue.R(rt.String("Any")));f.Pc=1060;continue;}
case 1060:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1063);}
case 1063:{f.Pc=f.Pop().Int==0?1081:1066;continue;}
case 1066:{f.Push(f.Locals[7]);f.Pc=1068;continue;}
case 1068:{f.Push(f.Locals[2]);f.Pc=1069;continue;}
case 1069:{return rt.Call(f,"forge/game/player/Player","getOpponents","()Lforge/game/player/PlayerCollection;","invokevirtual",1072);}
case 1072:{f.Push(f.Locals[8]);f.Pc=1074;continue;}
case 1074:{return rt.Call(f,"forge/game/player/PlayerCollection","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollection;","invokevirtual",1077);}
case 1077:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1080);}
case 1080:{f.StackOp("pop");f.Pc=1081;continue;}
case 1081:{f.Push(f.Locals[6]);f.Pc=1083;continue;}
case 1083:{f.Push(JValue.R(rt.String("Any")));f.Pc=1086;continue;}
case 1086:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1089);}
case 1089:{f.Pc=f.Pop().Int==0?1107:1092;continue;}
case 1092:{f.Push(f.Locals[7]);f.Pc=1094;continue;}
case 1094:{f.Push(f.Locals[2]);f.Pc=1095;continue;}
case 1095:{return rt.Call(f,"forge/game/player/Player","getAllies","()Lforge/game/player/PlayerCollection;","invokevirtual",1098);}
case 1098:{f.Push(f.Locals[8]);f.Pc=1100;continue;}
case 1100:{return rt.Call(f,"forge/game/player/PlayerCollection","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollection;","invokevirtual",1103);}
case 1103:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1106);}
case 1106:{f.StackOp("pop");f.Pc=1107;continue;}
case 1107:{f.Push(f.Locals[7]);f.Pc=1109;continue;}
case 1109:{f.Push(f.Locals[4]);f.Pc=1111;continue;}
case 1111:{f.Push(f.Locals[2]);f.Pc=1112;continue;}
case 1112:{f.Push(f.Locals[0]);f.Pc=1113;continue;}
case 1113:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",1116);}
case 1116:{f.Push(f.Locals[0]);f.Pc=1117;continue;}
case 1117:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1120);}
case 1120:{f.Locals[7]=f.Pop();f.Pc=1122;continue;}
case 1122:{f.Push(f.Locals[5]);f.Pc=1124;continue;}
case 1124:{f.Push(JValue.I(2));f.Pc=1125;continue;}
case 1125:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1128);}
case 1128:{f.Locals[8]=f.Pop();f.Pc=1130;continue;}
case 1130:{f.Push(f.Locals[0]);f.Pc=1131;continue;}
case 1131:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",1134);}
case 1134:{f.Push(f.Locals[8]);f.Pc=1136;continue;}
case 1136:{f.Push(f.Locals[0]);f.Pc=1137;continue;}
case 1137:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1140);}
case 1140:{f.Locals[9]=f.Pop();f.Pc=1142;continue;}
case 1142:{f.Push(f.Locals[7]);f.Pc=1144;continue;}
case 1144:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",1147);}
case 1147:{f.Locals[10]=f.Pop();f.Pc=1149;continue;}
case 1149:{f.Push(f.Locals[10]);f.Pc=1151;continue;}
case 1151:{f.Push(f.Locals[5]);f.Pc=1153;continue;}
case 1153:{f.Push(f.Locals[9]);f.Pc=1155;continue;}
case 1155:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",1158);}
case 1158:{f.Pc=f.Pop().Int!=0?1163:1161;continue;}
case 1161:{f.Push(JValue.I(0));f.Pc=1162;continue;}
case 1162:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1163:{f.Push(f.Locals[1]);f.Pc=1164;continue;}
case 1164:{f.Push(JValue.R(rt.String("IsPresent2")));f.Pc=1167;continue;}
case 1167:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1172);}
case 1172:{f.Pc=f.Pop().Int==0?1387:1175;continue;}
case 1175:{f.Push(f.Locals[1]);f.Pc=1176;continue;}
case 1176:{f.Push(JValue.R(rt.String("IsPresent2")));f.Pc=1179;continue;}
case 1179:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1184);}
case 1184:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1187;continue;}
case 1187:{f.Locals[4]=f.Pop();f.Pc=1189;continue;}
case 1189:{f.Push(f.Locals[0]);f.Pc=1190;continue;}
case 1190:{f.Push(JValue.R(rt.String("PresentCompare2")));f.Pc=1193;continue;}
case 1193:{f.Push(JValue.R(rt.String("GE1")));f.Pc=1196;continue;}
case 1196:{return rt.Call(f,"forge/game/CardTraitBase","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1199);}
case 1199:{f.Locals[5]=f.Pop();f.Pc=1201;continue;}
case 1201:{f.Push(f.Locals[0]);f.Pc=1202;continue;}
case 1202:{f.Push(JValue.R(rt.String("PresentPlayer2")));f.Pc=1205;continue;}
case 1205:{f.Push(JValue.R(rt.String("Any")));f.Pc=1208;continue;}
case 1208:{return rt.Call(f,"forge/game/CardTraitBase","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1211);}
case 1211:{f.Locals[6]=f.Pop();f.Pc=1213;continue;}
case 1213:{f.Push(f.Locals[1]);f.Pc=1214;continue;}
case 1214:{f.Push(JValue.R(rt.String("PresentZone2")));f.Pc=1217;continue;}
case 1217:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1222);}
case 1222:{f.Pc=f.Pop().Int==0?1243:1225;continue;}
case 1225:{f.Push(f.Locals[1]);f.Pc=1226;continue;}
case 1226:{f.Push(JValue.R(rt.String("PresentZone2")));f.Pc=1229;continue;}
case 1229:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1234);}
case 1234:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1237;continue;}
case 1237:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",1240);}
case 1240:{f.Pc=1249;continue;}
case 1243:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1246;continue;}
case 1246:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",1249);}
case 1249:{f.Locals[7]=f.Pop();f.Pc=1251;continue;}
case 1251:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1254;continue;}
case 1254:{f.StackOp("dup");f.Pc=1255;continue;}
case 1255:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",1258);}
case 1258:{f.Locals[8]=f.Pop();f.Pc=1260;continue;}
case 1260:{f.Push(f.Locals[6]);f.Pc=1262;continue;}
case 1262:{f.Push(JValue.R(rt.String("You")));f.Pc=1265;continue;}
case 1265:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1268);}
case 1268:{f.Pc=f.Pop().Int!=0?1282:1271;continue;}
case 1271:{f.Push(f.Locals[6]);f.Pc=1273;continue;}
case 1273:{f.Push(JValue.R(rt.String("Any")));f.Pc=1276;continue;}
case 1276:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1279);}
case 1279:{f.Pc=f.Pop().Int==0?1294:1282;continue;}
case 1282:{f.Push(f.Locals[8]);f.Pc=1284;continue;}
case 1284:{f.Push(f.Locals[2]);f.Pc=1285;continue;}
case 1285:{f.Push(f.Locals[7]);f.Pc=1287;continue;}
case 1287:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",1290);}
case 1290:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1293);}
case 1293:{f.StackOp("pop");f.Pc=1294;continue;}
case 1294:{f.Push(f.Locals[6]);f.Pc=1296;continue;}
case 1296:{f.Push(JValue.R(rt.String("Opponent")));f.Pc=1299;continue;}
case 1299:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1302);}
case 1302:{f.Pc=f.Pop().Int!=0?1316:1305;continue;}
case 1305:{f.Push(f.Locals[6]);f.Pc=1307;continue;}
case 1307:{f.Push(JValue.R(rt.String("Any")));f.Pc=1310;continue;}
case 1310:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1313);}
case 1313:{f.Pc=f.Pop().Int==0?1331:1316;continue;}
case 1316:{f.Push(f.Locals[8]);f.Pc=1318;continue;}
case 1318:{f.Push(f.Locals[2]);f.Pc=1319;continue;}
case 1319:{return rt.Call(f,"forge/game/player/Player","getOpponents","()Lforge/game/player/PlayerCollection;","invokevirtual",1322);}
case 1322:{f.Push(f.Locals[7]);f.Pc=1324;continue;}
case 1324:{return rt.Call(f,"forge/game/player/PlayerCollection","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollection;","invokevirtual",1327);}
case 1327:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1330);}
case 1330:{f.StackOp("pop");f.Pc=1331;continue;}
case 1331:{f.Push(f.Locals[8]);f.Pc=1333;continue;}
case 1333:{f.Push(f.Locals[4]);f.Pc=1335;continue;}
case 1335:{f.Push(f.Locals[2]);f.Pc=1336;continue;}
case 1336:{f.Push(f.Locals[0]);f.Pc=1337;continue;}
case 1337:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",1340);}
case 1340:{f.Push(f.Locals[0]);f.Pc=1341;continue;}
case 1341:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1344);}
case 1344:{f.Locals[8]=f.Pop();f.Pc=1346;continue;}
case 1346:{f.Push(f.Locals[5]);f.Pc=1348;continue;}
case 1348:{f.Push(JValue.I(2));f.Pc=1349;continue;}
case 1349:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1352);}
case 1352:{f.Locals[9]=f.Pop();f.Pc=1354;continue;}
case 1354:{f.Push(f.Locals[0]);f.Pc=1355;continue;}
case 1355:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",1358);}
case 1358:{f.Push(f.Locals[9]);f.Pc=1360;continue;}
case 1360:{f.Push(f.Locals[0]);f.Pc=1361;continue;}
case 1361:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1364);}
case 1364:{f.Locals[10]=f.Pop();f.Pc=1366;continue;}
case 1366:{f.Push(f.Locals[8]);f.Pc=1368;continue;}
case 1368:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",1371);}
case 1371:{f.Locals[11]=f.Pop();f.Pc=1373;continue;}
case 1373:{f.Push(f.Locals[11]);f.Pc=1375;continue;}
case 1375:{f.Push(f.Locals[5]);f.Pc=1377;continue;}
case 1377:{f.Push(f.Locals[10]);f.Pc=1379;continue;}
case 1379:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",1382);}
case 1382:{f.Pc=f.Pop().Int!=0?1387:1385;continue;}
case 1385:{f.Push(JValue.I(0));f.Pc=1386;continue;}
case 1386:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1387:{f.Push(f.Locals[1]);f.Pc=1388;continue;}
case 1388:{f.Push(JValue.R(rt.String("CheckDefinedPlayer")));f.Pc=1391;continue;}
case 1391:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1396);}
case 1396:{f.Pc=f.Pop().Int==0?1483:1399;continue;}
case 1399:{f.Push(f.Locals[1]);f.Pc=1400;continue;}
case 1400:{f.Push(JValue.R(rt.String("CheckDefinedPlayer")));f.Pc=1403;continue;}
case 1403:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1408);}
case 1408:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1411;continue;}
case 1411:{f.Locals[4]=f.Pop();f.Pc=1413;continue;}
case 1413:{f.Push(f.Locals[0]);f.Pc=1414;continue;}
case 1414:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",1417);}
case 1417:{f.Push(f.Locals[4]);f.Pc=1419;continue;}
case 1419:{f.Push(f.Locals[0]);f.Pc=1420;continue;}
case 1420:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",1423);}
case 1423:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",1426);}
case 1426:{f.Locals[5]=f.Pop();f.Pc=1428;continue;}
case 1428:{f.Push(f.Locals[0]);f.Pc=1429;continue;}
case 1429:{f.Push(JValue.R(rt.String("DefinedPlayerCompare")));f.Pc=1432;continue;}
case 1432:{f.Push(JValue.R(rt.String("GE1")));f.Pc=1435;continue;}
case 1435:{return rt.Call(f,"forge/game/CardTraitBase","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1438);}
case 1438:{f.Locals[6]=f.Pop();f.Pc=1440;continue;}
case 1440:{f.Push(f.Locals[6]);f.Pc=1442;continue;}
case 1442:{f.Push(JValue.I(0));f.Pc=1443;continue;}
case 1443:{f.Push(JValue.I(2));f.Pc=1444;continue;}
case 1444:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",1447);}
case 1447:{f.Locals[7]=f.Pop();f.Pc=1449;continue;}
case 1449:{f.Push(f.Locals[6]);f.Pc=1451;continue;}
case 1451:{f.Push(JValue.I(2));f.Pc=1452;continue;}
case 1452:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1455);}
case 1455:{f.Locals[8]=f.Pop();f.Pc=1457;continue;}
case 1457:{f.Push(f.Locals[0]);f.Pc=1458;continue;}
case 1458:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",1461);}
case 1461:{f.Push(f.Locals[8]);f.Pc=1463;continue;}
case 1463:{f.Push(f.Locals[0]);f.Pc=1464;continue;}
case 1464:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1467);}
case 1467:{f.Locals[9]=f.Pop();f.Pc=1469;continue;}
case 1469:{f.Push(f.Locals[5]);f.Pc=1471;continue;}
case 1471:{f.Push(f.Locals[7]);f.Pc=1473;continue;}
case 1473:{f.Push(f.Locals[9]);f.Pc=1475;continue;}
case 1475:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",1478);}
case 1478:{f.Pc=f.Pop().Int!=0?1483:1481;continue;}
case 1481:{f.Push(JValue.I(0));f.Pc=1482;continue;}
case 1482:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1483:{f.Push(f.Locals[1]);f.Pc=1484;continue;}
case 1484:{f.Push(JValue.R(rt.String("CheckSVar")));f.Pc=1487;continue;}
case 1487:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1492);}
case 1492:{f.Pc=f.Pop().Int==0?1654:1495;continue;}
case 1495:{f.Push(f.Locals[0]);f.Pc=1496;continue;}
case 1496:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",1499);}
case 1499:{f.Push(f.Locals[1]);f.Pc=1500;continue;}
case 1500:{f.Push(JValue.R(rt.String("CheckSVar")));f.Pc=1503;continue;}
case 1503:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1508);}
case 1508:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1511;continue;}
case 1511:{f.Push(f.Locals[0]);f.Pc=1512;continue;}
case 1512:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1515);}
case 1515:{f.Locals[4]=f.Pop();f.Pc=1517;continue;}
case 1517:{f.Push(f.Locals[0]);f.Pc=1518;continue;}
case 1518:{f.Push(JValue.R(rt.String("SVarCompare")));f.Pc=1521;continue;}
case 1521:{f.Push(JValue.R(rt.String("GE1")));f.Pc=1524;continue;}
case 1524:{return rt.Call(f,"forge/game/CardTraitBase","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1527);}
case 1527:{f.Locals[5]=f.Pop();f.Pc=1529;continue;}
case 1529:{f.Push(f.Locals[5]);f.Pc=1531;continue;}
case 1531:{f.Push(JValue.I(0));f.Pc=1532;continue;}
case 1532:{f.Push(JValue.I(2));f.Pc=1533;continue;}
case 1533:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",1536);}
case 1536:{f.Locals[6]=f.Pop();f.Pc=1538;continue;}
case 1538:{f.Push(f.Locals[5]);f.Pc=1540;continue;}
case 1540:{f.Push(JValue.I(2));f.Pc=1541;continue;}
case 1541:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1544);}
case 1544:{f.Locals[7]=f.Pop();f.Pc=1546;continue;}
case 1546:{f.Push(f.Locals[0]);f.Pc=1547;continue;}
case 1547:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",1550);}
case 1550:{f.Push(f.Locals[7]);f.Pc=1552;continue;}
case 1552:{f.Push(f.Locals[0]);f.Pc=1553;continue;}
case 1553:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1556);}
case 1556:{f.Locals[8]=f.Pop();f.Pc=1558;continue;}
case 1558:{f.Push(f.Locals[4]);f.Pc=1560;continue;}
case 1560:{f.Push(f.Locals[6]);f.Pc=1562;continue;}
case 1562:{f.Push(f.Locals[8]);f.Pc=1564;continue;}
case 1564:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",1567);}
case 1567:{f.Pc=f.Pop().Int!=0?1572:1570;continue;}
case 1570:{f.Push(JValue.I(0));f.Pc=1571;continue;}
case 1571:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1572:{f.Push(f.Locals[0]);f.Pc=1573;continue;}
case 1573:{f.Push(JValue.R(rt.String("CheckSecondSVar")));f.Pc=1576;continue;}
case 1576:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",1579);}
case 1579:{f.Pc=f.Pop().Int==0?1654:1582;continue;}
case 1582:{f.Push(f.Locals[0]);f.Pc=1583;continue;}
case 1583:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","hostCard","Lforge/game/card/Card;"));f.Pc=1586;continue;}
case 1586:{f.Push(f.Locals[0]);f.Pc=1587;continue;}
case 1587:{f.Push(JValue.R(rt.String("CheckSecondSVar")));f.Pc=1590;continue;}
case 1590:{return rt.Call(f,"forge/game/CardTraitBase","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1593);}
case 1593:{f.Push(f.Locals[0]);f.Pc=1594;continue;}
case 1594:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1597);}
case 1597:{f.Locals[9]=f.Pop();f.Pc=1599;continue;}
case 1599:{f.Push(f.Locals[0]);f.Pc=1600;continue;}
case 1600:{f.Push(JValue.R(rt.String("SecondSVarCompare")));f.Pc=1603;continue;}
case 1603:{f.Push(JValue.R(rt.String("GE1")));f.Pc=1606;continue;}
case 1606:{return rt.Call(f,"forge/game/CardTraitBase","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1609);}
case 1609:{f.Locals[10]=f.Pop();f.Pc=1611;continue;}
case 1611:{f.Push(f.Locals[10]);f.Pc=1613;continue;}
case 1613:{f.Push(JValue.I(0));f.Pc=1614;continue;}
case 1614:{f.Push(JValue.I(2));f.Pc=1615;continue;}
case 1615:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",1618);}
case 1618:{f.Locals[11]=f.Pop();f.Pc=1620;continue;}
case 1620:{f.Push(f.Locals[10]);f.Pc=1622;continue;}
case 1622:{f.Push(JValue.I(2));f.Pc=1623;continue;}
case 1623:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1626);}
case 1626:{f.Locals[12]=f.Pop();f.Pc=1628;continue;}
case 1628:{f.Push(f.Locals[0]);f.Pc=1629;continue;}
case 1629:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",1632);}
case 1632:{f.Push(f.Locals[12]);f.Pc=1634;continue;}
case 1634:{f.Push(f.Locals[0]);f.Pc=1635;continue;}
case 1635:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1638);}
case 1638:{f.Locals[13]=f.Pop();f.Pc=1640;continue;}
case 1640:{f.Push(f.Locals[9]);f.Pc=1642;continue;}
case 1642:{f.Push(f.Locals[11]);f.Pc=1644;continue;}
case 1644:{f.Push(f.Locals[13]);f.Pc=1646;continue;}
case 1646:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",1649);}
case 1649:{f.Pc=f.Pop().Int!=0?1654:1652;continue;}
case 1652:{f.Push(JValue.I(0));f.Pc=1653;continue;}
case 1653:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1654:{f.Push(f.Locals[1]);f.Pc=1655;continue;}
case 1655:{f.Push(JValue.R(rt.String("ManaSpent")));f.Pc=1658;continue;}
case 1658:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1663);}
case 1663:{f.Pc=f.Pop().Int==0?1710:1666;continue;}
case 1666:{f.Push(f.Locals[0]);f.Pc=1667;continue;}
case 1667:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",1670);}
case 1670:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",1673);}
case 1673:{f.Locals[4]=f.Pop();f.Pc=1675;continue;}
case 1675:{f.Push(f.Locals[4]);f.Pc=1677;continue;}
case 1677:{f.Pc=f.Pop().Reference!=null?1682:1680;continue;}
case 1680:{f.Push(JValue.I(0));f.Pc=1681;continue;}
case 1681:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1682:{f.Push(f.Locals[4]);f.Pc=1684;continue;}
case 1684:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingColors","()Lforge/card/ColorSet;","invokevirtual",1687);}
case 1687:{f.Push(f.Locals[1]);f.Pc=1688;continue;}
case 1688:{f.Push(JValue.R(rt.String("ManaSpent")));f.Pc=1691;continue;}
case 1691:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1696);}
case 1696:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1699;continue;}
case 1699:{return rt.Call(f,"forge/card/mana/ManaAtom","fromName","(Ljava/lang/String;)B","invokestatic",1702);}
case 1702:{return rt.Call(f,"forge/card/ColorSet","hasAllColors","(I)Z","invokevirtual",1705);}
case 1705:{f.Pc=f.Pop().Int!=0?1710:1708;continue;}
case 1708:{f.Push(JValue.I(0));f.Pc=1709;continue;}
case 1709:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1710:{f.Push(f.Locals[1]);f.Pc=1711;continue;}
case 1711:{f.Push(JValue.R(rt.String("ManaNotSpent")));f.Pc=1714;continue;}
case 1714:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1719);}
case 1719:{f.Pc=f.Pop().Int==0?1764:1722;continue;}
case 1722:{f.Push(f.Locals[0]);f.Pc=1723;continue;}
case 1723:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",1726);}
case 1726:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",1729);}
case 1729:{f.Locals[4]=f.Pop();f.Pc=1731;continue;}
case 1731:{f.Push(f.Locals[4]);f.Pc=1733;continue;}
case 1733:{f.Pc=f.Pop().Reference==null?1764:1736;continue;}
case 1736:{f.Push(f.Locals[4]);f.Pc=1738;continue;}
case 1738:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingColors","()Lforge/card/ColorSet;","invokevirtual",1741);}
case 1741:{f.Push(f.Locals[1]);f.Pc=1742;continue;}
case 1742:{f.Push(JValue.R(rt.String("ManaNotSpent")));f.Pc=1745;continue;}
case 1745:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1750);}
case 1750:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1753;continue;}
case 1753:{return rt.Call(f,"forge/card/mana/ManaAtom","fromName","(Ljava/lang/String;)B","invokestatic",1756);}
case 1756:{return rt.Call(f,"forge/card/ColorSet","hasAllColors","(I)Z","invokevirtual",1759);}
case 1759:{f.Pc=f.Pop().Int==0?1764:1762;continue;}
case 1762:{f.Push(JValue.I(0));f.Pc=1763;continue;}
case 1763:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1764:{f.Push(f.Locals[1]);f.Pc=1765;continue;}
case 1765:{f.Push(JValue.R(rt.String("WerewolfTransformCondition")));f.Pc=1768;continue;}
case 1768:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1773);}
case 1773:{f.Pc=f.Pop().Int==0?1793:1776;continue;}
case 1776:{f.Push(f.Locals[3]);f.Pc=1777;continue;}
case 1777:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",1780);}
case 1780:{return rt.Call(f,"forge/game/zone/MagicStack","getSpellsCastLastTurn","()Ljava/util/List;","invokevirtual",1783);}
case 1783:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1788);}
case 1788:{f.Pc=f.Pop().Int!=0?1793:1791;continue;}
case 1791:{f.Push(JValue.I(0));f.Pc=1792;continue;}
case 1792:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1793:{f.Push(f.Locals[1]);f.Pc=1794;continue;}
case 1794:{f.Push(JValue.R(rt.String("WerewolfUntransformCondition")));f.Pc=1797;continue;}
case 1797:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1802);}
case 1802:{f.Pc=f.Pop().Int==0?1838:1805;continue;}
case 1805:{f.Push(f.Locals[3]);f.Pc=1806;continue;}
case 1806:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",1809);}
case 1809:{return rt.Call(f,"forge/game/zone/MagicStack","getSpellsCastLastTurn","()Ljava/util/List;","invokevirtual",1812);}
case 1812:{f.Locals[4]=f.Pop();f.Pc=1814;continue;}
case 1814:{f.Push(f.Locals[3]);f.Pc=1815;continue;}
case 1815:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",1818);}
case 1818:{return rt.Call(f,"forge/game/player/PlayerCollection","stream","()Ljava/util/stream/Stream;","invokevirtual",1821);}
case 1821:{f.Push(f.Locals[4]);f.Pc=1823;continue;}
case 1823:{return rt.DynamicCall(f,"forge/game/CardTraitBase:1807:1823:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/List;)Ljava/util/function/Predicate;",1828);}
case 1828:{return rt.Call(f,"java/util/stream/Stream","noneMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",1833);}
case 1833:{f.Pc=f.Pop().Int==0?1838:1836;continue;}
case 1836:{f.Push(JValue.I(0));f.Pc=1837;continue;}
case 1837:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1838:{f.Push(f.Locals[1]);f.Pc=1839;continue;}
case 1839:{f.Push(JValue.R(rt.String("ClassLevel")));f.Pc=1841;continue;}
case 1841:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1846);}
case 1846:{f.Pc=f.Pop().Int==0?1883:1849;continue;}
case 1849:{f.Push(f.Locals[0]);f.Pc=1850;continue;}
case 1850:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",1853);}
case 1853:{return rt.Call(f,"forge/game/card/Card","getClassLevel","()I","invokevirtual",1856);}
case 1856:{f.Locals[4]=f.Pop();f.Pc=1858;continue;}
case 1858:{f.Push(f.Locals[1]);f.Pc=1859;continue;}
case 1859:{f.Push(JValue.R(rt.String("ClassLevel")));f.Pc=1861;continue;}
case 1861:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1866);}
case 1866:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1869;continue;}
case 1869:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",1872);}
case 1872:{f.Locals[5]=f.Pop();f.Pc=1874;continue;}
case 1874:{f.Push(f.Locals[4]);f.Pc=1876;continue;}
case 1876:{f.Push(f.Locals[5]);f.Pc=1878;continue;}
case 1878:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1883:1881;continue;}
case 1881:{f.Push(JValue.I(0));f.Pc=1882;continue;}
case 1882:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1883:{f.Push(JValue.I(1));f.Pc=1884;continue;}
case 1884:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1808(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","hostCard","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/game/card/Card;)Lforge/game/card/CardView;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1809(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/CardTraitBase","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Reference==null?59:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/CardTraitBase","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",15);}
case 15:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getStatic","()Lforge/game/staticability/StaticAbility;","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Reference==null?59:23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Reference==null?43:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/CardTraitBase","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",36);}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int==0?59:43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/CardTraitBase","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",48);}
case 48:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getStatic","()Lforge/game/staticability/StaticAbility;","invokeinterface",53);}
case 53:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",58);}
case 58:{f.StackOp("pop");f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/CardTraitBase","getCardState","()Lforge/game/card/CardState;","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Reference==null?77:66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/CardTraitBase","getCardState","()Lforge/game/card/CardState;","invokevirtual",71);}
case 71:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",76);}
case 76:{f.StackOp("pop");f.Pc=77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",82);}
case 82:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",87);}
case 87:{f.StackOp("pop");f.Pc=88;continue;}
case 88:{f.Push(f.Locals[2]);f.Pc=89;continue;}
case 89:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1810(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/CardTraitBase","getSVarFallback","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",10);}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.DynamicCall(f,"forge/game/CardTraitBase:1810:11:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",16);}
case 16:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",21);}
case 21:{return rt.Call(f,"java/util/stream/Stream","findFirst","()Ljava/util/Optional;","invokeinterface",26);}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1811(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1812(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","sVars","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?27:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","sVars","Ljava/util/Map;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{return JStep.Return(f.Pop());}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/CardTraitBase","findSVar","(Ljava/lang/String;)Ljava/util/Optional;","invokevirtual",32);}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.DynamicCall(f,"forge/game/CardTraitBase:1812:33:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Function;",38);}
case 38:{return rt.Call(f,"java/util/Optional","map","(Ljava/util/function/Function;)Ljava/util/Optional;","invokevirtual",41);}
case 41:{f.Push(JValue.R(rt.String("")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Optional","orElse","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1813(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","sVars","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int!=0?24:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/CardTraitBase","findSVar","(Ljava/lang/String;)Ljava/util/Optional;","invokevirtual",18);}
case 18:{return rt.Call(f,"java/util/Optional","isPresent","()Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?28:24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Pc=29;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1814(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/CardTraitBase","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Reference==null?19:10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",14);}
case 14:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",17);}
case 17:{return JStep.Return(f.Pop());}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(JValue.R(null));f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1815(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","sVars","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",11);}
case 11:{f.StackOp("pop");f.Pc=12;continue;}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1816(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/CardTraitBase","getSVarFallback","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",9);}
case 9:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?49:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/IHasSVars"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/IHasSVars","getSVars","()Ljava/util/Map;","invokeinterface",41);}
case 41:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",46);}
case 46:{f.Pc=15;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","sVars","Ljava/util/Map;"));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",59);}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1817(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/Maps","newTreeMap","()Ljava/util/TreeMap;","invokestatic",4);}
case 4:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","sVars","Ljava/util/Map;",value);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","sVars","Ljava/util/Map;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",17);}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1818(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","sVars","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1819(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","cardState","Lforge/game/card/CardState;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1820(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","cardState","Lforge/game/card/CardState;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1821(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/CardTraitBase","getCardState","()Lforge/game/card/CardState;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference!=null?9:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/CardTraitBase","getCardState","()Lforge/game/card/CardState;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/card/CardState","getView","()Lforge/game/card/CardView$CardStateView;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getState","()Lforge/card/CardStateName;","invokevirtual",19);}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1822(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/CardTraitBase","isIntrinsic","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?39:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","cardState","Lforge/game/card/CardState;"));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Reference==null?39:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","cardState","Lforge/game/card/CardState;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",21);}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",25);}
case 25:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",28);}
case 28:{return rt.Call(f,"forge/card/CardStateName","equals","(Ljava/lang/Object;)Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int!=0?39:34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","cardState","Lforge/game/card/CardState;"));f.Pc=38;continue;}
case 38:{return JStep.Return(f.Pop());}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",43);}
case 43:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1823(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/CardTraitBase","getCardState","()Lforge/game/card/CardState;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?15:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/CardTraitBase","getCardState","()Lforge/game/card/CardState;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",14);}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(JValue.R(null));f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1824(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/CardTraitBase","getCardState","()Lforge/game/card/CardState;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference!=null?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",13);}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/CardTraitBase","getCardState","()Lforge/game/card/CardState;","invokevirtual",17);}
case 17:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",20);}
case 20:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int!=0?30:26;continue;}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{f.Pc=31;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1825(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","intrinsicChangedTextColors","Ljava/util/Map;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","changedTextColors","Ljava/util/Map;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/CardTraitBase","_combineChangedMap","(Ljava/util/Map;Ljava/util/Map;)Ljava/util/Map;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1826(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","intrinsicChangedTextTypes","Ljava/util/Map;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","changedTextTypes","Ljava/util/Map;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/CardTraitBase","_combineChangedMap","(Ljava/util/Map;Ljava/util/Map;)Ljava/util/Map;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1827(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",6);}
case 6:{f.Pc=f.Pop().Int==0?11:9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int==0?22:20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return JStep.Return(f.Pop());}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","(Ljava/util/Map;)Ljava/util/HashMap;","invokestatic",26);}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",33);}
case 33:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",38);}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",47);}
case 47:{f.Pc=f.Pop().Int==0?107:50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",57);}
case 57:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=60;continue;}
case 60:{f.Locals[5]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[5]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",69);}
case 69:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=72;continue;}
case 72:{f.Locals[6]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[5]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",82);}
case 82:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[6]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[6]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",95);}
case 95:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",103);}
case 103:{f.StackOp("pop");f.Pc=104;continue;}
case 104:{f.Pc=40;continue;}
case 107:{f.Push(f.Locals[3]);f.Pc=108;continue;}
case 108:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1828(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","intrinsicChangedTextColors","Ljava/util/Map;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","intrinsicChangedTextTypes","Ljava/util/Map;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","mapParams","Ljava/util/Map;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",19);}
case 19:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",24);}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",31);}
case 31:{f.Pc=f.Pop().Int==0?146:34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[4]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","originalMapParams","Ljava/util/Map;"));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",56);}
case 56:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=59;continue;}
case 59:{f.Locals[5]=f.Pop();f.Pc=61;continue;}
case 61:{if(!rt.StaticReady(f,"forge/game/CardTraitBase","noChangeKeys","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/CardTraitBase","noChangeKeys","Lcom/google/common/collect/ImmutableList;"));f.Pc=64;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"com/google/common/collect/ImmutableList","contains","(Ljava/lang/Object;)Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int==0?75:72;continue;}
case 72:{f.Pc=25;continue;}
case 75:{if(!rt.StaticReady(f,"forge/game/CardTraitBase","descriptiveKeys","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/CardTraitBase","descriptiveKeys","Lcom/google/common/collect/ImmutableList;"));f.Pc=78;continue;}
case 78:{f.Push(f.Locals[4]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"com/google/common/collect/ImmutableList","contains","(Ljava/lang/Object;)Z","invokevirtual",83);}
case 83:{f.Pc=f.Pop().Int==0?99:86;continue;}
case 86:{f.Push(f.Locals[5]);f.Pc=88;continue;}
case 88:{f.Push(JValue.I(1));f.Pc=89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/ability/AbilityUtils","applyTextChangeEffects","(Ljava/lang/String;ZLjava/util/Map;Ljava/util/Map;)Ljava/lang/String;","invokestatic",94);}
case 94:{f.Locals[6]=f.Pop();f.Pc=96;continue;}
case 96:{f.Pc=124;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",103);}
case 103:{f.Push(f.Locals[5]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/card/Card","hasSVar","(Ljava/lang/String;)Z","invokevirtual",108);}
case 108:{f.Pc=f.Pop().Int==0?114:111;continue;}
case 111:{f.Pc=25;continue;}
case 114:{f.Push(f.Locals[5]);f.Pc=116;continue;}
case 116:{f.Push(JValue.I(0));f.Pc=117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[2]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/ability/AbilityUtils","applyTextChangeEffects","(Ljava/lang/String;ZLjava/util/Map;Ljava/util/Map;)Ljava/lang/String;","invokestatic",122);}
case 122:{f.Locals[6]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[6]);f.Pc=126;continue;}
case 126:{f.Pc=f.Pop().Reference==null?143:129;continue;}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","mapParams","Ljava/util/Map;"));f.Pc=133;continue;}
case 133:{f.Push(f.Locals[4]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[6]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",142);}
case 142:{f.StackOp("pop");f.Pc=143;continue;}
case 143:{f.Pc=25;continue;}
case 146:{f.Push(f.Locals[0]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[0]);f.Pc=148;continue;}
case 148:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","mapParams","Ljava/util/Map;"));f.Pc=151;continue;}
case 151:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","(Ljava/util/Map;)Ljava/util/HashMap;","invokestatic",154);}
case 154:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","originalMapParams","Ljava/util/Map;",value);f.Pc=157;continue;}
case 157:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1829(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/card/Card","getChangedTextColorWords","()Lcom/google/common/collect/ImmutableMap;","invokevirtual",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","changedTextColors","Ljava/util/Map;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/game/card/Card","getChangedTextTypeWords","()Lcom/google/common/collect/ImmutableMap;","invokevirtual",19);}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","changedTextTypes","Ljava/util/Map;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","mapParams","Ljava/util/Map;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",31);}
case 31:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",36);}
case 36:{f.Locals[1]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",43);}
case 43:{f.Pc=f.Pop().Int==0?148:46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{f.Locals[2]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","originalMapParams","Ljava/util/Map;"));f.Pc=60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",66);}
case 66:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=69;continue;}
case 69:{f.Locals[3]=f.Pop();f.Pc=70;continue;}
case 70:{if(!rt.StaticReady(f,"forge/game/CardTraitBase","noChangeKeys","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/CardTraitBase","noChangeKeys","Lcom/google/common/collect/ImmutableList;"));f.Pc=73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"com/google/common/collect/ImmutableList","contains","(Ljava/lang/Object;)Z","invokevirtual",77);}
case 77:{f.Pc=f.Pop().Int==0?83:80;continue;}
case 80:{f.Pc=37;continue;}
case 83:{if(!rt.StaticReady(f,"forge/game/CardTraitBase","descriptiveKeys","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/CardTraitBase","descriptiveKeys","Lcom/google/common/collect/ImmutableList;"));f.Pc=86;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"com/google/common/collect/ImmutableList","contains","(Ljava/lang/Object;)Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?103:93;continue;}
case 93:{f.Push(f.Locals[3]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/ability/AbilityUtils","applyDescriptionTextChangeEffects","(Ljava/lang/String;Lforge/game/CardTraitBase;)Ljava/lang/String;","invokestatic",98);}
case 98:{f.Locals[4]=f.Pop();f.Pc=100;continue;}
case 100:{f.Pc=127;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",107);}
case 107:{f.Push(f.Locals[3]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/card/Card","hasSVar","(Ljava/lang/String;)Z","invokevirtual",111);}
case 111:{f.Pc=f.Pop().Int==0?120:114;continue;}
case 114:{f.Push(JValue.R(null));f.Pc=115;continue;}
case 115:{f.Locals[4]=f.Pop();f.Pc=117;continue;}
case 117:{f.Pc=127;continue;}
case 120:{f.Push(f.Locals[3]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/ability/AbilityUtils","applyAbilityTextChangeEffects","(Ljava/lang/String;Lforge/game/CardTraitBase;)Ljava/lang/String;","invokestatic",125);}
case 125:{f.Locals[4]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[4]);f.Pc=129;continue;}
case 129:{f.Pc=f.Pop().Reference==null?145:132;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","mapParams","Ljava/util/Map;"));f.Pc=136;continue;}
case 136:{f.Push(f.Locals[2]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[4]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",144);}
case 144:{f.StackOp("pop");f.Pc=145;continue;}
case 145:{f.Pc=37;continue;}
case 148:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1830(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/CardTraitBase","copyHelper","(Lforge/game/CardTraitBase;Lforge/game/card/Card;Z)V","invokevirtual",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1831(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","originalMapParams","Ljava/util/Map;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","(Ljava/util/Map;)Ljava/util/HashMap;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","originalMapParams","Ljava/util/Map;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Int==0?23:16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","mapParams","Ljava/util/Map;"));f.Pc=20;continue;}
case 20:{f.Pc=27;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","originalMapParams","Ljava/util/Map;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","(Ljava/util/Map;)Ljava/util/HashMap;","invokestatic",30);}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","mapParams","Ljava/util/Map;",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","sVars","Ljava/util/Map;"));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/CardTraitBase","setSVars","(Ljava/util/Map;)V","invokevirtual",41);}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","cardState","Lforge/game/card/CardState;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/CardTraitBase","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",49);}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","hostCard","Lforge/game/card/Card;",value);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(rt.GetField(f.Pop(),"forge/game/CardTraitBase","keyword","Lforge/game/keyword/KeywordInterface;"));f.Pc=59;continue;}
case 59:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/CardTraitBase","keyword","Lforge/game/keyword/KeywordInterface;",value);f.Pc=62;continue;}
case 62:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1832(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/SpellAbility")?1:0));f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Int==0?29:9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{f.Locals[1]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?29:21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",25);}
case 25:{return rt.Call(f,"forge/game/trigger/Trigger","getTriggerRemembered","()Ljava/util/List;","invokevirtual",28);}
case 28:{return JStep.Return(f.Pop());}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Locals[2]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/trigger/Trigger")?1:0));f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Int==0?48:38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{f.Locals[1]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/trigger/Trigger","getTriggerRemembered","()Ljava/util/List;","invokevirtual",47);}
case 47:{return JStep.Return(f.Pop());}
case 48:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",51);}
case 51:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1833(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/IHasSVars","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1834(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/IHasSVars","hasSVar","(Ljava/lang/String;)Z","invokeinterface",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1835(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardPredicates","isController","(Lforge/game/player/Player;)Ljava/util/function/Predicate;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/game/card/CardLists","count","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)I","invokestatic",8);}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?16:12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{f.Pc=17;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1836(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/ImmutableList","builder","()Lcom/google/common/collect/ImmutableList$Builder;","invokestatic",3);}
case 3:{f.Push(JValue.I(4));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Description")));f.Pc=12;continue;}
case 12:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=18;continue;}
case 18:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{f.Push(JValue.I(2));f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("StackDescription")));f.Pc=24;continue;}
case 24:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{f.Push(JValue.I(3));f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("TriggerDescription")));f.Pc=30;continue;}
case 30:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=31;continue;}
case 31:{return rt.Call(f,"com/google/common/collect/ImmutableList$Builder","add","([Ljava/lang/Object;)Lcom/google/common/collect/ImmutableList$Builder;","invokevirtual",34);}
case 34:{f.Push(JValue.I(2));f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=38;continue;}
case 38:{f.StackOp("dup");f.Pc=39;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("ChangeTypeDesc")));f.Pc=43;continue;}
case 43:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=44;continue;}
case 44:{f.StackOp("dup");f.Pc=45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("ValidTgtsDesc")));f.Pc=49;continue;}
case 49:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=50;continue;}
case 50:{return rt.Call(f,"com/google/common/collect/ImmutableList$Builder","add","([Ljava/lang/Object;)Lcom/google/common/collect/ImmutableList$Builder;","invokevirtual",53);}
case 53:{return rt.Call(f,"com/google/common/collect/ImmutableList$Builder","build","()Lcom/google/common/collect/ImmutableList;","invokevirtual",56);}
case 56:{if(!rt.StaticReady(f,"forge/game/CardTraitBase","descriptiveKeys","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;rt.PutStatic("forge/game/CardTraitBase","descriptiveKeys","Lcom/google/common/collect/ImmutableList;",f.Pop());f.Pc=59;continue;}
case 59:{return rt.Call(f,"com/google/common/collect/ImmutableList","builder","()Lcom/google/common/collect/ImmutableList$Builder;","invokestatic",62);}
case 62:{f.Push(JValue.I(4));f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=66;continue;}
case 66:{f.StackOp("dup");f.Pc=67;continue;}
case 67:{f.Push(JValue.I(0));f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("TokenScript")));f.Pc=71;continue;}
case 71:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=72;continue;}
case 72:{f.StackOp("dup");f.Pc=73;continue;}
case 73:{f.Push(JValue.I(1));f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("NewName")));f.Pc=77;continue;}
case 77:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=78;continue;}
case 78:{f.StackOp("dup");f.Pc=79;continue;}
case 79:{f.Push(JValue.I(2));f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("DefinedName")));f.Pc=83;continue;}
case 83:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=84;continue;}
case 84:{f.StackOp("dup");f.Pc=85;continue;}
case 85:{f.Push(JValue.I(3));f.Pc=86;continue;}
case 86:{f.Push(JValue.R(rt.String("ChooseFromList")));f.Pc=89;continue;}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{return rt.Call(f,"com/google/common/collect/ImmutableList$Builder","add","([Ljava/lang/Object;)Lcom/google/common/collect/ImmutableList$Builder;","invokevirtual",93);}
case 93:{f.Push(JValue.R(rt.String("AddAbility")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"com/google/common/collect/ImmutableList$Builder","add","(Ljava/lang/Object;)Lcom/google/common/collect/ImmutableList$Builder;","invokevirtual",99);}
case 99:{return rt.Call(f,"com/google/common/collect/ImmutableList$Builder","build","()Lcom/google/common/collect/ImmutableList;","invokevirtual",102);}
case 102:{if(!rt.StaticReady(f,"forge/game/CardTraitBase","noChangeKeys","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;rt.PutStatic("forge/game/CardTraitBase","noChangeKeys","Lcom/google/common/collect/ImmutableList;",f.Pop());f.Pc=105;continue;}
case 105:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C143{
internal static JClass Build(){var c=new JClass("forge/game/GameFormat","java/lang/Object",new string[]{"java/lang/Comparable"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("name","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("formatType","Lforge/game/GameFormat$FormatType;",false,JValue.Default("Lforge/game/GameFormat$FormatType;"),null));
c.Add(new JField("formatSubType","Lforge/game/GameFormat$FormatSubType;",false,JValue.Default("Lforge/game/GameFormat$FormatSubType;"),null));
c.Add(new JField("folder","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("allowedSetCodes","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("allowedRarities","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("bannedCardNames","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("restrictedCardNames","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("additionalCardNames","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("restrictedLegendary","Z",false,JValue.Default("Z"),null));
c.Add(new JField("deckRules","Lforge/game/GameFormat$DeckRules;",false,JValue.Default("Lforge/game/GameFormat$DeckRules;"),null));
c.Add(new JField("effectiveDate","Ljava/util/Date;",false,JValue.Default("Ljava/util/Date;"),null));
c.Add(new JField("formatter","Ljava/text/SimpleDateFormat;",true,JValue.Default("Ljava/text/SimpleDateFormat;"),null));
c.Add(new JField("DEFAULTDATE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"1990-01-01"));
c.Add(new JField("allowedSetCodes_ro","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("bannedCardNames_ro","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("restrictedCardNames_ro","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("additionalCardNames_ro","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("filterRules","Ljava/util/function/Predicate;",false,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("filterPrinted","Ljava/util/function/Predicate;",false,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("index","I",false,JValue.Default("I"),null));
c.Add(new JField("NoFormat","Lforge/game/GameFormat;",true,JValue.Default("Lforge/game/GameFormat;"),null));
c.Add(new JField("editionLegalPredicate","Ljava/util/function/Predicate;",false,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JMethod(2271,"forge/game/GameFormat","<init>","(Ljava/lang/String;Ljava/lang/Iterable;Ljava/util/List;)V",1,4,12,new JHandler[]{},M2271));
c.Add(new JMethod(2272,"forge/game/GameFormat","<init>","(Ljava/lang/String;Ljava/util/Date;Ljava/lang/Iterable;Ljava/util/List;Ljava/util/List;Ljava/lang/Boolean;Ljava/util/List;Ljava/util/List;ILforge/game/GameFormat$FormatType;Lforge/game/GameFormat$FormatSubType;)V",1,12,13,new JHandler[]{},M2272));
c.Add(new JMethod(2273,"forge/game/GameFormat","<init>","(Ljava/lang/String;Ljava/util/Date;Ljava/lang/Iterable;Ljava/util/List;Ljava/util/List;Ljava/lang/Boolean;Ljava/util/List;Ljava/util/List;ILforge/game/GameFormat$FormatType;Lforge/game/GameFormat$FormatSubType;Lforge/game/GameFormat$DeckRules;)V",1,17,3,new JHandler[]{},M2273));
c.Add(new JMethod(2274,"forge/game/GameFormat","buildFilter","(Z)Ljava/util/function/Predicate;",4,6,3,new JHandler[]{},M2274));
c.Add(new JMethod(2275,"forge/game/GameFormat","buildFilterPrinted","()Ljava/util/function/Predicate;",2,1,2,new JHandler[]{},M2275));
c.Add(new JMethod(2276,"forge/game/GameFormat","buildFilterRules","()Ljava/util/function/Predicate;",2,1,2,new JHandler[]{},M2276));
c.Add(new JMethod(2277,"forge/game/GameFormat","getName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M2277));
c.Add(new JMethod(2278,"forge/game/GameFormat","parseDate","(Ljava/lang/String;)Ljava/util/Date;",10,2,2,new JHandler[]{new JHandler(16,23,24,"java/text/ParseException")},M2278));
c.Add(new JMethod(2279,"forge/game/GameFormat","getEffectiveDate","()Ljava/util/Date;",1,1,1,new JHandler[]{},M2279));
c.Add(new JMethod(2280,"forge/game/GameFormat","getFolder","()Ljava/lang/String;",1,1,1,new JHandler[]{},M2280));
c.Add(new JMethod(2281,"forge/game/GameFormat","getFormatType","()Lforge/game/GameFormat$FormatType;",1,1,1,new JHandler[]{},M2281));
c.Add(new JMethod(2282,"forge/game/GameFormat","getFormatSubType","()Lforge/game/GameFormat$FormatSubType;",1,1,1,new JHandler[]{},M2282));
c.Add(new JMethod(2283,"forge/game/GameFormat","getAllowedSetCodes","()Ljava/util/List;",1,1,1,new JHandler[]{},M2283));
c.Add(new JMethod(2284,"forge/game/GameFormat","getBannedCardNames","()Ljava/util/List;",1,1,1,new JHandler[]{},M2284));
c.Add(new JMethod(2285,"forge/game/GameFormat","getRestrictedCards","()Ljava/util/List;",1,1,1,new JHandler[]{},M2285));
c.Add(new JMethod(2286,"forge/game/GameFormat","isRestrictedLegendary","()Ljava/lang/Boolean;",1,1,1,new JHandler[]{},M2286));
c.Add(new JMethod(2287,"forge/game/GameFormat","getAdditionalCards","()Ljava/util/List;",1,1,1,new JHandler[]{},M2287));
c.Add(new JMethod(2288,"forge/game/GameFormat","getMaxPoints","()I",1,1,1,new JHandler[]{},M2288));
c.Add(new JMethod(2289,"forge/game/GameFormat","getDeckPoints","(Ljava/lang/Iterable;)I",1,6,4,new JHandler[]{},M2289));
c.Add(new JMethod(2290,"forge/game/GameFormat","getAllowedRarities","()Ljava/util/List;",1,1,1,new JHandler[]{},M2290));
c.Add(new JMethod(2291,"forge/game/GameFormat","getAllCards","()Ljava/util/List;",1,8,4,new JHandler[]{},M2291));
c.Add(new JMethod(2292,"forge/game/GameFormat","getFilterRules","()Ljava/util/function/Predicate;",1,1,1,new JHandler[]{},M2292));
c.Add(new JMethod(2293,"forge/game/GameFormat","getFilterPrinted","()Ljava/util/function/Predicate;",1,1,1,new JHandler[]{},M2293));
c.Add(new JMethod(2294,"forge/game/GameFormat","isSetLegal","(Ljava/lang/String;)Z",1,2,2,new JHandler[]{},M2294));
c.Add(new JMethod(2295,"forge/game/GameFormat","isDeckLegal","(Lforge/deck/Deck;)Z",1,2,3,new JHandler[]{},M2295));
c.Add(new JMethod(2296,"forge/game/GameFormat","getDeckProblem","(Lforge/deck/Deck;Lforge/deck/CardPool;)Ljava/lang/String;",2,4,6,new JHandler[]{},M2296));
c.Add(new JMethod(2297,"forge/game/GameFormat","getPoolLegalityProblem","(Lforge/deck/CardPool;)Ljava/lang/String;",2,7,5,new JHandler[]{},M2297));
c.Add(new JMethod(2298,"forge/game/GameFormat","getSingletonOrPointsProblem","(Lforge/deck/CardPool;)Ljava/lang/String;",2,9,6,new JHandler[]{},M2298));
c.Add(new JMethod(2299,"forge/game/GameFormat","maxSingletonCopies","(Lforge/item/PaperCard;)I",10,2,1,new JHandler[]{},M2299));
c.Add(new JMethod(2300,"forge/game/GameFormat","getDeckConformanceProblem","(Lforge/deck/Deck;)Ljava/lang/String;",1,2,3,new JHandler[]{},M2300));
c.Add(new JMethod(2301,"forge/game/GameFormat","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M2301));
c.Add(new JMethod(2302,"forge/game/GameFormat","compareTo","(Lforge/game/GameFormat;)I",1,3,2,new JHandler[]{},M2302));
c.Add(new JMethod(2303,"forge/game/GameFormat","getIndex","()I",1,1,1,new JHandler[]{},M2303));
c.Add(new JMethod(2304,"forge/game/GameFormat","compareTo","(Ljava/lang/Object;)I",4161,2,2,new JHandler[]{},M2304));
c.Add(new JMethod(2305,"forge/game/GameFormat","lambda$new$1","(Lforge/card/CardEdition;)Z",4098,2,2,new JHandler[]{},M2305));
c.Add(new JMethod(2306,"forge/game/GameFormat","lambda$getSingletonOrPointsProblem$0","(Lforge/card/CardDb;Lforge/item/PaperCard;)Ljava/lang/String;",4106,2,2,new JHandler[]{},M2306));
c.Add(new JMethod(2307,"forge/game/GameFormat","<clinit>","()V",8,0,13,new JHandler[]{},M2307));
}

internal static JStep M2271(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.String("1990-01-01")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameFormat","parseDate","(Ljava/lang/String;)Ljava/util/Date;","invokestatic",7);}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",14);}
case 14:{f.Push(JValue.R(null));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(null));f.Pc=16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatType","CUSTOM","Lforge/game/GameFormat$FormatType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatType","CUSTOM","Lforge/game/GameFormat$FormatType;"));f.Pc=20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","CUSTOM","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatSubType","CUSTOM","Lforge/game/GameFormat$FormatSubType;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/GameFormat","<init>","(Ljava/lang/String;Ljava/util/Date;Ljava/lang/Iterable;Ljava/util/List;Ljava/util/List;Ljava/lang/Boolean;Ljava/util/List;Ljava/util/List;ILforge/game/GameFormat$FormatType;Lforge/game/GameFormat$FormatSubType;)V","invokespecial",26);}
case 26:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2272(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[5]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[6]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[7]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[8]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[9]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[10]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[11]);f.Pc=20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/game/GameFormat$DeckRules","NONE","Lforge/game/GameFormat$DeckRules;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$DeckRules","NONE","Lforge/game/GameFormat$DeckRules;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/GameFormat","<init>","(Ljava/lang/String;Ljava/util/Date;Ljava/lang/Iterable;Ljava/util/List;Ljava/util/List;Ljava/lang/Boolean;Ljava/util/List;Ljava/util/List;ILforge/game/GameFormat$FormatType;Lforge/game/GameFormat$FormatSubType;Lforge/game/GameFormat$DeckRules;)V","invokespecial",26);}
case 26:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2273(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","restrictedLegendary","Z",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.DynamicCall(f,"forge/game/GameFormat:2273:11:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/GameFormat;)Ljava/util/function/Predicate;",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","editionLegalPredicate","Ljava/util/function/Predicate;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[12]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","deckRules","Lforge/game/GameFormat$DeckRules;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[9]);f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","index","I",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[10]);f.Pc=34;continue;}
case 34:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","formatType","Lforge/game/GameFormat$FormatType;",value);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[11]);f.Pc=40;continue;}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","formatSubType","Lforge/game/GameFormat$FormatSubType;",value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","name","Ljava/lang/String;",value);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","effectiveDate","Ljava/util/Date;",value);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{f.Pc=f.Pop().Reference==null?153:57;continue;}
case 57:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",60);}
case 60:{f.Locals[13]=f.Pop();f.Pc=62;continue;}
case 62:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=65;continue;}
case 65:{f.StackOp("dup");f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",69);}
case 69:{f.Locals[14]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",77);}
case 77:{f.Locals[15]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[15]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",86);}
case 86:{f.Pc=f.Pop().Int==0?141:89;continue;}
case 89:{f.Push(f.Locals[15]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",96);}
case 96:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=99;continue;}
case 99:{f.Locals[16]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[13]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[16]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/StaticData","getCardEdition","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",108);}
case 108:{f.Pc=f.Pop().Reference!=null?128:111;continue;}
case 111:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=114;continue;}
case 114:{f.Push(f.Locals[16]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{return rt.DynamicCall(f,"forge/game/GameFormat:2273:117:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",122);}
case 122:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",125);}
case 125:{f.Pc=79;continue;}
case 128:{f.Push(f.Locals[14]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[16]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",137);}
case 137:{f.StackOp("pop");f.Pc=138;continue;}
case 138:{f.Pc=79;continue;}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[14]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",147);}
case 147:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","allowedSetCodes","Ljava/util/List;",value);f.Pc=150;continue;}
case 150:{f.Pc=164;continue;}
case 153:{f.Push(f.Locals[0]);f.Pc=154;continue;}
case 154:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=157;continue;}
case 157:{f.StackOp("dup");f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",161);}
case 161:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","allowedSetCodes","Ljava/util/List;",value);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{f.Push(f.Locals[4]);f.Pc=167;continue;}
case 167:{f.Pc=f.Pop().Reference!=null?180:170;continue;}
case 170:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=173;continue;}
case 173:{f.StackOp("dup");f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",177);}
case 177:{f.Pc=185;continue;}
case 180:{f.Push(f.Locals[4]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",185);}
case 185:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","bannedCardNames","Ljava/util/List;",value);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[0]);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[5]);f.Pc=191;continue;}
case 191:{f.Pc=f.Pop().Reference!=null?204:194;continue;}
case 194:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=197;continue;}
case 197:{f.StackOp("dup");f.Pc=198;continue;}
case 198:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",201);}
case 201:{f.Pc=209;continue;}
case 204:{f.Push(f.Locals[5]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",209);}
case 209:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","restrictedCardNames","Ljava/util/List;",value);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[0]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[8]);f.Pc=215;continue;}
case 215:{f.Pc=f.Pop().Reference!=null?228:218;continue;}
case 218:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=221;continue;}
case 221:{f.StackOp("dup");f.Pc=222;continue;}
case 222:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",225);}
case 225:{f.Pc=230;continue;}
case 228:{f.Push(f.Locals[8]);f.Pc=230;continue;}
case 230:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","allowedRarities","Ljava/util/List;",value);f.Pc=233;continue;}
case 233:{f.Push(f.Locals[0]);f.Pc=234;continue;}
case 234:{f.Push(f.Locals[6]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",239);}
case 239:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","restrictedLegendary","Z",value);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[0]);f.Pc=243;continue;}
case 243:{f.Push(f.Locals[7]);f.Pc=245;continue;}
case 245:{f.Pc=f.Pop().Reference!=null?258:248;continue;}
case 248:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=251;continue;}
case 251:{f.StackOp("dup");f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",255);}
case 255:{f.Pc=263;continue;}
case 258:{f.Push(f.Locals[7]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",263);}
case 263:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","additionalCardNames","Ljava/util/List;",value);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[0]);f.Pc=267;continue;}
case 267:{f.Push(f.Locals[0]);f.Pc=268;continue;}
case 268:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","allowedSetCodes","Ljava/util/List;"));f.Pc=271;continue;}
case 271:{return rt.Call(f,"java/util/Collections","unmodifiableList","(Ljava/util/List;)Ljava/util/List;","invokestatic",274);}
case 274:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","allowedSetCodes_ro","Ljava/util/List;",value);f.Pc=277;continue;}
case 277:{f.Push(f.Locals[0]);f.Pc=278;continue;}
case 278:{f.Push(f.Locals[0]);f.Pc=279;continue;}
case 279:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","bannedCardNames","Ljava/util/List;"));f.Pc=282;continue;}
case 282:{return rt.Call(f,"java/util/Collections","unmodifiableList","(Ljava/util/List;)Ljava/util/List;","invokestatic",285);}
case 285:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","bannedCardNames_ro","Ljava/util/List;",value);f.Pc=288;continue;}
case 288:{f.Push(f.Locals[0]);f.Pc=289;continue;}
case 289:{f.Push(f.Locals[0]);f.Pc=290;continue;}
case 290:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","restrictedCardNames","Ljava/util/List;"));f.Pc=293;continue;}
case 293:{return rt.Call(f,"java/util/Collections","unmodifiableList","(Ljava/util/List;)Ljava/util/List;","invokestatic",296);}
case 296:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","restrictedCardNames_ro","Ljava/util/List;",value);f.Pc=299;continue;}
case 299:{f.Push(f.Locals[0]);f.Pc=300;continue;}
case 300:{f.Push(f.Locals[0]);f.Pc=301;continue;}
case 301:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","additionalCardNames","Ljava/util/List;"));f.Pc=304;continue;}
case 304:{return rt.Call(f,"java/util/Collections","unmodifiableList","(Ljava/util/List;)Ljava/util/List;","invokestatic",307);}
case 307:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","additionalCardNames_ro","Ljava/util/List;",value);f.Pc=310;continue;}
case 310:{f.Push(f.Locals[0]);f.Pc=311;continue;}
case 311:{f.Push(f.Locals[0]);f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/game/GameFormat","buildFilterRules","()Ljava/util/function/Predicate;","invokevirtual",315);}
case 315:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","filterRules","Ljava/util/function/Predicate;",value);f.Pc=318;continue;}
case 318:{f.Push(f.Locals[0]);f.Pc=319;continue;}
case 319:{f.Push(f.Locals[0]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/game/GameFormat","buildFilterPrinted","()Ljava/util/function/Predicate;","invokevirtual",323);}
case 323:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat","filterPrinted","Ljava/util/function/Predicate;",value);f.Pc=326;continue;}
case 326:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2274(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameFormat","getBannedCardNames","()Ljava/util/List;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/item/PaperCardPredicates","names","(Ljava/util/List;)Ljava/util/function/Predicate;","invokestatic",7);}
case 7:{return rt.Call(f,"java/util/function/Predicate","negate","()Ljava/util/function/Predicate;","invokeinterface",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","ARENA","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatSubType","ARENA","Lforge/game/GameFormat$FormatSubType;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/GameFormat","getFormatSubType","()Lforge/game/GameFormat$FormatSubType;","invokevirtual",20);}
case 20:{return rt.Call(f,"forge/game/GameFormat$FormatSubType","equals","(Ljava/lang/Object;)Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int==0?44:26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_UNREBALANCED","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_UNREBALANCED","Ljava/util/function/Predicate;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/function/Predicate","negate","()Ljava/util/function/Predicate;","invokeinterface",35);}
case 35:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",40);}
case 40:{f.Locals[2]=f.Pop();f.Pc=41;continue;}
case 41:{f.Pc=59;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_REBALANCED","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_REBALANCED","Ljava/util/function/Predicate;"));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/function/Predicate","negate","()Ljava/util/function/Predicate;","invokeinterface",53);}
case 53:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",58);}
case 58:{f.Locals[2]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/GameFormat","getAllowedSetCodes","()Ljava/util/List;","invokevirtual",63);}
case 63:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",68);}
case 68:{f.Pc=f.Pop().Int!=0?106:71;continue;}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Pc=f.Pop().Int==0?87:76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/GameFormat","getAllowedSetCodes","()Ljava/util/List;","invokevirtual",80);}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/item/PaperCardPredicates","printedInSets","(Ljava/util/List;Z)Ljava/util/function/Predicate;","invokestatic",84);}
case 84:{f.Pc=100;continue;}
case 87:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",90);}
case 90:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",93);}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/GameFormat","getAllowedSetCodes","()Ljava/util/List;","invokevirtual",97);}
case 97:{return rt.Call(f,"forge/card/CardDb","wasPrintedInSets","(Ljava/util/Collection;)Ljava/util/function/Predicate;","invokevirtual",100);}
case 100:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",105);}
case 105:{f.Locals[2]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(f.Locals[0]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/GameFormat","getAllowedRarities","()Ljava/util/List;","invokevirtual",110);}
case 110:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",115);}
case 115:{f.Pc=f.Pop().Int!=0?187:118;continue;}
case 118:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",121);}
case 121:{f.Locals[3]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[0]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/GameFormat","getAllowedRarities","()Ljava/util/List;","invokevirtual",126);}
case 126:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",131);}
case 131:{f.Locals[4]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(f.Locals[4]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",140);}
case 140:{f.Pc=f.Pop().Int==0?176:143;continue;}
case 143:{f.Push(f.Locals[4]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",150);}
case 150:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRarity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=153;continue;}
case 153:{f.Locals[5]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[3]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",159);}
case 159:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",162);}
case 162:{f.Push(f.Locals[5]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/card/CardDb","wasPrintedAtRarity","(Lforge/card/CardRarity;)Ljava/util/function/Predicate;","invokevirtual",167);}
case 167:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",172);}
case 172:{f.StackOp("pop");f.Pc=173;continue;}
case 173:{f.Pc=133;continue;}
case 176:{f.Push(f.Locals[2]);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[3]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/util/IterableUtil","or","(Ljava/lang/Iterable;)Ljava/util/function/Predicate;","invokestatic",181);}
case 181:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",186);}
case 186:{f.Locals[2]=f.Pop();f.Pc=187;continue;}
case 187:{f.Push(f.Locals[0]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/GameFormat","getAdditionalCards","()Ljava/util/List;","invokevirtual",191);}
case 191:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",196);}
case 196:{f.Pc=f.Pop().Int!=0?213:199;continue;}
case 199:{f.Push(f.Locals[2]);f.Pc=200;continue;}
case 200:{f.Push(f.Locals[0]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/game/GameFormat","getAdditionalCards","()Ljava/util/List;","invokevirtual",204);}
case 204:{return rt.Call(f,"forge/item/PaperCardPredicates","names","(Ljava/util/List;)Ljava/util/function/Predicate;","invokestatic",207);}
case 207:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",212);}
case 212:{f.Locals[2]=f.Pop();f.Pc=213;continue;}
case 213:{f.Push(f.Locals[2]);f.Pc=214;continue;}
case 214:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2275(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameFormat","buildFilter","(Z)Ljava/util/function/Predicate;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2276(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameFormat","buildFilter","(Z)Ljava/util/function/Predicate;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2277(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2278(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",4);}
case 4:{f.Push(JValue.I(7));f.Pc=6;continue;}
case 6:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?16:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.DynamicCall(f,"forge/game/GameFormat:2278:10:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",15);}
case 15:{f.Locals[0]=f.Pop();f.Pc=16;continue;}
case 16:{if(!rt.StaticReady(f,"forge/game/GameFormat","formatter","Ljava/text/SimpleDateFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat","formatter","Ljava/text/SimpleDateFormat;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/text/SimpleDateFormat","parse","(Ljava/lang/String;)Ljava/util/Date;","invokevirtual",23);}
case 23:{return JStep.Return(f.Pop());}
case 24:{f.Locals[1]=f.Pop();f.Pc=25;continue;}
case 25:{if(!rt.EnsureInitialized(f,"java/util/Date"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/Date")));f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Date","<init>","()V","invokespecial",32);}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2279(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","effectiveDate","Ljava/util/Date;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2280(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","folder","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2281(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","formatType","Lforge/game/GameFormat$FormatType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2282(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","formatSubType","Lforge/game/GameFormat$FormatSubType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2283(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","allowedSetCodes_ro","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2284(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","bannedCardNames_ro","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2285(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","restrictedCardNames_ro","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2286(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","restrictedLegendary","Z"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2287(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","additionalCardNames_ro","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2288(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","deckRules","Lforge/game/GameFormat$DeckRules;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameFormat$DeckRules","cardPoints","()Ljava/util/Map;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",12);}
case 12:{f.Pc=f.Pop().Int==0?19:15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{f.Pc=26;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","deckRules","Lforge/game/GameFormat$DeckRules;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/GameFormat$DeckRules","maxPoints","()I","invokevirtual",26);}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2289(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",8);}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",15);}
case 15:{f.Pc=f.Pop().Int==0?97:18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",24);}
case 24:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=27;continue;}
case 27:{f.Locals[4]=f.Pop();f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",32);}
case 32:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",35);}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",48);}
case 48:{return rt.Call(f,"forge/card/CardDb","getNormalizedName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",51);}
case 51:{f.Locals[5]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","deckRules","Lforge/game/GameFormat$DeckRules;"));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/GameFormat$DeckRules","cardPoints","()Ljava/util/Map;","invokevirtual",61);}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",67);}
case 67:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",72);}
case 72:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",78);}
case 78:{f.Push(f.Locals[4]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",85);}
case 85:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",91);}
case 91:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=92;continue;}
case 92:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=93;continue;}
case 93:{f.Locals[2]=f.Pop();f.Pc=94;continue;}
case 94:{f.Pc=9;continue;}
case 97:{f.Push(f.Locals[2]);f.Pc=98;continue;}
case 98:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2290(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","allowedRarities","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2291(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","ensureAllCardsLoaded","()V","invokevirtual",6);}
case 6:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",13);}
case 13:{f.Locals[1]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","allowedSetCodes_ro","Ljava/util/List;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",23);}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int==0?150:33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{f.Locals[3]=f.Pop();f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",46);}
case 46:{return rt.Call(f,"forge/StaticData","getEditions","()Lforge/card/CardEdition$Collection;","invokevirtual",49);}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",53);}
case 53:{f.Locals[4]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{f.Pc=f.Pop().Reference==null?147:60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/card/CardEdition","getObtainableCards","()Ljava/util/List;","invokevirtual",65);}
case 65:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",70);}
case 70:{f.Locals[5]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[5]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",79);}
case 79:{f.Pc=f.Pop().Int==0?147:82;continue;}
case 82:{f.Push(f.Locals[5]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",89);}
case 89:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=92;continue;}
case 92:{f.Locals[6]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","bannedCardNames_ro","Ljava/util/List;"));f.Pc=98;continue;}
case 98:{f.Push(f.Locals[6]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","name","()Ljava/lang/String;","invokevirtual",103);}
case 103:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",108);}
case 108:{f.Pc=f.Pop().Int!=0?144:111;continue;}
case 111:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",114);}
case 114:{f.Push(f.Locals[6]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","name","()Ljava/lang/String;","invokevirtual",119);}
case 119:{f.Push(f.Locals[3]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[6]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","collectorNumber","()Ljava/lang/String;","invokevirtual",125);}
case 125:{return rt.Call(f,"forge/StaticData","fetchCard","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",128);}
case 128:{f.Locals[7]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[7]);f.Pc=132;continue;}
case 132:{f.Pc=f.Pop().Reference==null?144:135;continue;}
case 135:{f.Push(f.Locals[1]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[7]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",143);}
case 143:{f.StackOp("pop");f.Pc=144;continue;}
case 144:{f.Pc=72;continue;}
case 147:{f.Pc=24;continue;}
case 150:{f.Push(f.Locals[1]);f.Pc=151;continue;}
case 151:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2292(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","filterRules","Ljava/util/function/Predicate;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2293(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","filterPrinted","Ljava/util/function/Predicate;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2294(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameFormat","getAllowedSetCodes","()Ljava/util/List;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int!=0?25:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/GameFormat","getAllowedSetCodes","()Ljava/util/List;","invokevirtual",16);}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?29:25;continue;}
case 25:{f.Push(JValue.I(1));f.Pc=26;continue;}
case 26:{f.Pc=30;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2295(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/deck/Deck","getAllCardsInASinglePool","()Lforge/deck/CardPool;","invokevirtual",6);}
case 6:{return rt.Call(f,"forge/game/GameFormat","getDeckProblem","(Lforge/deck/Deck;Lforge/deck/CardPool;)Ljava/lang/String;","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Reference!=null?16:12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{f.Pc=17;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2296(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/Deck","getMain","()Lforge/deck/CardPool;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/deck/CardPool","countAll","()I","invokevirtual",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","deckRules","Lforge/game/GameFormat$DeckRules;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/GameFormat$DeckRules","minMainDeckSize","()I","invokevirtual",16);}
case 16:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?53:19;continue;}
case 19:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",22);}
case 22:{f.Push(JValue.R(rt.String("lblFormatTooFewCards")));f.Pc=25;continue;}
case 25:{f.Push(JValue.I(2));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",35);}
case 35:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","deckRules","Lforge/game/GameFormat$DeckRules;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/GameFormat$DeckRules","minMainDeckSize","()I","invokevirtual",45);}
case 45:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",48);}
case 48:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",52);}
case 52:{return JStep.Return(f.Pop());}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/GameFormat","getPoolLegalityProblem","(Lforge/deck/CardPool;)Ljava/lang/String;","invokevirtual",58);}
case 58:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2297(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?75:22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/GameFormat","getFilterRules","()Ljava/util/function/Predicate;","invokevirtual",37);}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",44);}
case 44:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",52);}
case 52:{f.Pc=f.Pop().Int!=0?72:55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",71);}
case 71:{f.StackOp("pop");f.Pc=72;continue;}
case 72:{f.Pc=13;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",81);}
case 81:{f.Pc=f.Pop().Int<=0?164:84;continue;}
case 84:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=87;continue;}
case 87:{f.StackOp("dup");f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",91);}
case 91:{f.Push(JValue.R(rt.String("lblFormatIllegalCards")));f.Pc=94;continue;}
case 94:{f.Push(JValue.I(0));f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",101);}
case 101:{return rt.DynamicCall(f,"forge/game/GameFormat:2297:101:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",106);}
case 106:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",109);}
case 109:{f.Locals[3]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[2]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",116);}
case 116:{f.Locals[4]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[4]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",125);}
case 125:{f.Pc=f.Pop().Int==0?159:128;continue;}
case 128:{f.Push(f.Locals[4]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",135);}
case 135:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=138;continue;}
case 138:{f.Locals[5]=f.Pop();f.Pc=140;continue;}
case 140:{f.Push(f.Locals[3]);f.Pc=141;continue;}
case 141:{f.Push(JValue.R(rt.String("\n")));f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",147);}
case 147:{f.Push(f.Locals[5]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/item/PaperCard","getDisplayName","()Ljava/lang/String;","invokevirtual",152);}
case 152:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",155);}
case 155:{f.StackOp("pop");f.Pc=156;continue;}
case 156:{f.Pc=118;continue;}
case 159:{f.Push(f.Locals[3]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",163);}
case 163:{return JStep.Return(f.Pop());}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/GameFormat","getRestrictedCards","()Ljava/util/List;","invokevirtual",168);}
case 168:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",173);}
case 173:{f.Pc=f.Pop().Int==0?186:176;continue;}
case 176:{f.Push(f.Locals[0]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/GameFormat","isRestrictedLegendary","()Ljava/lang/Boolean;","invokevirtual",180);}
case 180:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",183);}
case 183:{f.Pc=f.Pop().Int==0?440:186;continue;}
case 186:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=189;continue;}
case 189:{f.StackOp("dup");f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",193);}
case 193:{f.Locals[2]=f.Pop();f.Pc=194;continue;}
case 194:{f.Push(f.Locals[1]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",198);}
case 198:{f.Locals[3]=f.Pop();f.Pc=199;continue;}
case 199:{f.Push(f.Locals[3]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",205);}
case 205:{f.Pc=f.Pop().Int==0?351:208;continue;}
case 208:{f.Push(f.Locals[3]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",214);}
case 214:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=217;continue;}
case 217:{f.Locals[4]=f.Pop();f.Pc=219;continue;}
case 219:{f.Push(f.Locals[0]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/GameFormat","getRestrictedCards","()Ljava/util/List;","invokevirtual",223);}
case 223:{f.Push(f.Locals[4]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",230);}
case 230:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",236);}
case 236:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",241);}
case 241:{f.Locals[5]=f.Pop();f.Pc=243;continue;}
case 243:{f.Push(f.Locals[4]);f.Pc=245;continue;}
case 245:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",250);}
case 250:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=253;continue;}
case 253:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",256);}
case 256:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",259);}
case 259:{return rt.Call(f,"forge/card/CardType","isLegendary","()Z","invokevirtual",262);}
case 262:{f.Pc=f.Pop().Int==0?301:265;continue;}
case 265:{f.Push(f.Locals[4]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",272);}
case 272:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",278);}
case 278:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",281);}
case 281:{return rt.Call(f,"forge/card/CardType","isPlaneswalker","()Z","invokevirtual",284);}
case 284:{f.Pc=f.Pop().Int!=0?301:287;continue;}
case 287:{f.Push(f.Locals[0]);f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/game/GameFormat","isRestrictedLegendary","()Ljava/lang/Boolean;","invokevirtual",291);}
case 291:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",294);}
case 294:{f.Pc=f.Pop().Int==0?301:297;continue;}
case 297:{f.Push(JValue.I(1));f.Pc=298;continue;}
case 298:{f.Pc=302;continue;}
case 301:{f.Push(JValue.I(0));f.Pc=302;continue;}
case 302:{f.Locals[6]=f.Pop();f.Pc=304;continue;}
case 304:{f.Push(f.Locals[4]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",311);}
case 311:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=314;continue;}
case 314:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",317);}
case 317:{f.Push(JValue.I(1));f.Pc=318;continue;}
case 318:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?348:321;continue;}
case 321:{f.Push(f.Locals[5]);f.Pc=323;continue;}
case 323:{f.Pc=f.Pop().Int!=0?331:326;continue;}
case 326:{f.Push(f.Locals[6]);f.Pc=328;continue;}
case 328:{f.Pc=f.Pop().Int==0?348:331;continue;}
case 331:{f.Push(f.Locals[2]);f.Pc=332;continue;}
case 332:{f.Push(f.Locals[4]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",339);}
case 339:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=342;continue;}
case 342:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",347);}
case 347:{f.StackOp("pop");f.Pc=348;continue;}
case 348:{f.Pc=199;continue;}
case 351:{f.Push(f.Locals[2]);f.Pc=352;continue;}
case 352:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",357);}
case 357:{f.Pc=f.Pop().Int<=0?440:360;continue;}
case 360:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=363;continue;}
case 363:{f.StackOp("dup");f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",367);}
case 367:{f.Push(JValue.R(rt.String("lblFormatRestrictedCopies")));f.Pc=370;continue;}
case 370:{f.Push(JValue.I(0));f.Pc=371;continue;}
case 371:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=374;continue;}
case 374:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",377);}
case 377:{return rt.DynamicCall(f,"forge/game/GameFormat:2297:377:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",382);}
case 382:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",385);}
case 385:{f.Locals[3]=f.Pop();f.Pc=386;continue;}
case 386:{f.Push(f.Locals[2]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",392);}
case 392:{f.Locals[4]=f.Pop();f.Pc=394;continue;}
case 394:{f.Push(f.Locals[4]);f.Pc=396;continue;}
case 396:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",401);}
case 401:{f.Pc=f.Pop().Int==0?435:404;continue;}
case 404:{f.Push(f.Locals[4]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",411);}
case 411:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=414;continue;}
case 414:{f.Locals[5]=f.Pop();f.Pc=416;continue;}
case 416:{f.Push(f.Locals[3]);f.Pc=417;continue;}
case 417:{f.Push(JValue.R(rt.String("\n")));f.Pc=420;continue;}
case 420:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",423);}
case 423:{f.Push(f.Locals[5]);f.Pc=425;continue;}
case 425:{return rt.Call(f,"forge/item/PaperCard","getDisplayName","()Ljava/lang/String;","invokevirtual",428);}
case 428:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",431);}
case 431:{f.StackOp("pop");f.Pc=432;continue;}
case 432:{f.Pc=394;continue;}
case 435:{f.Push(f.Locals[3]);f.Pc=436;continue;}
case 436:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",439);}
case 439:{return JStep.Return(f.Pop());}
case 440:{f.Push(f.Locals[0]);f.Pc=441;continue;}
case 441:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","deckRules","Lforge/game/GameFormat$DeckRules;"));f.Pc=444;continue;}
case 444:{return rt.Call(f,"forge/game/GameFormat$DeckRules","singleton","()Z","invokevirtual",447);}
case 447:{f.Pc=f.Pop().Int!=0?457:450;continue;}
case 450:{f.Push(f.Locals[0]);f.Pc=451;continue;}
case 451:{return rt.Call(f,"forge/game/GameFormat","getMaxPoints","()I","invokevirtual",454);}
case 454:{f.Pc=f.Pop().Int<=0?463:457;continue;}
case 457:{f.Push(f.Locals[0]);f.Pc=458;continue;}
case 458:{f.Push(f.Locals[1]);f.Pc=459;continue;}
case 459:{return rt.Call(f,"forge/game/GameFormat","getSingletonOrPointsProblem","(Lforge/deck/CardPool;)Ljava/lang/String;","invokevirtual",462);}
case 462:{return JStep.Return(f.Pop());}
case 463:{f.Push(JValue.R(null));f.Pc=464;continue;}
case 464:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2298(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"java/util/TreeMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeMap")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/TreeMap","<init>","()V","invokespecial",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.DynamicCall(f,"forge/game/GameFormat:2298:17:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardDb;)Ljava/util/function/Function;",22);}
case 22:{return rt.Call(f,"forge/util/Aggregates","groupSumBy","(Ljava/lang/Iterable;Ljava/util/function/Function;)Ljava/lang/Iterable;","invokestatic",25);}
case 25:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",30);}
case 30:{f.Locals[4]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",39);}
case 39:{f.Pc=f.Pop().Int==0?84:42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{f.Locals[5]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",62);}
case 62:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[5]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",72);}
case 72:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",80);}
case 80:{f.StackOp("pop");f.Pc=81;continue;}
case 81:{f.Pc=32;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","deckRules","Lforge/game/GameFormat$DeckRules;"));f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/GameFormat$DeckRules","singleton","()Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?241:94;continue;}
case 94:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",101);}
case 101:{f.Locals[4]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[3]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",109);}
case 109:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",114);}
case 114:{f.Locals[5]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[5]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",123);}
case 123:{f.Pc=f.Pop().Int==0?209:126;continue;}
case 126:{f.Push(f.Locals[5]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",133);}
case 133:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=136;continue;}
case 136:{f.Locals[6]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[2]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[6]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",146);}
case 146:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",152);}
case 152:{f.Locals[7]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(f.Locals[6]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",161);}
case 161:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",167);}
case 167:{f.Push(f.Locals[7]);f.Pc=169;continue;}
case 169:{f.Pc=f.Pop().Reference!=null?176:172;continue;}
case 172:{f.Push(JValue.I(1));f.Pc=173;continue;}
case 173:{f.Pc=181;continue;}
case 176:{f.Push(f.Locals[7]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/GameFormat","maxSingletonCopies","(Lforge/item/PaperCard;)I","invokestatic",181);}
case 181:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?206:184;continue;}
case 184:{f.Push(f.Locals[4]);f.Pc=186;continue;}
case 186:{f.Push(JValue.R(rt.String("\n")));f.Pc=189;continue;}
case 189:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",192);}
case 192:{f.Push(f.Locals[6]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",199);}
case 199:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",205);}
case 205:{f.StackOp("pop");f.Pc=206;continue;}
case 206:{f.Pc=116;continue;}
case 209:{f.Push(f.Locals[4]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",214);}
case 214:{f.Pc=f.Pop().Int<=0?241:217;continue;}
case 217:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",220);}
case 220:{f.Push(JValue.R(rt.String("lblFormatExtraCopies")));f.Pc=223;continue;}
case 223:{f.Push(JValue.I(0));f.Pc=224;continue;}
case 224:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",230);}
case 230:{f.Push(f.Locals[4]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",235);}
case 235:{return rt.DynamicCall(f,"forge/game/GameFormat:2298:235:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",240);}
case 240:{return JStep.Return(f.Pop());}
case 241:{f.Push(f.Locals[0]);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[1]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/GameFormat","getDeckPoints","(Ljava/lang/Iterable;)I","invokevirtual",246);}
case 246:{f.Locals[4]=f.Pop();f.Pc=248;continue;}
case 248:{f.Push(f.Locals[0]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/game/GameFormat","getMaxPoints","()I","invokevirtual",252);}
case 252:{f.Pc=f.Pop().Int<=0?408:255;continue;}
case 255:{f.Push(f.Locals[4]);f.Pc=257;continue;}
case 257:{f.Push(f.Locals[0]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/GameFormat","getMaxPoints","()I","invokevirtual",261);}
case 261:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?408:264;continue;}
case 264:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=267;continue;}
case 267:{f.StackOp("dup");f.Pc=268;continue;}
case 268:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",271);}
case 271:{f.Locals[5]=f.Pop();f.Pc=273;continue;}
case 273:{f.Push(f.Locals[3]);f.Pc=274;continue;}
case 274:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",279);}
case 279:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",284);}
case 284:{f.Locals[6]=f.Pop();f.Pc=286;continue;}
case 286:{f.Push(f.Locals[6]);f.Pc=288;continue;}
case 288:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",293);}
case 293:{f.Pc=f.Pop().Int==0?366:296;continue;}
case 296:{f.Push(f.Locals[6]);f.Pc=298;continue;}
case 298:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",303);}
case 303:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=306;continue;}
case 306:{f.Locals[7]=f.Pop();f.Pc=308;continue;}
case 308:{f.Push(f.Locals[0]);f.Pc=309;continue;}
case 309:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","deckRules","Lforge/game/GameFormat$DeckRules;"));f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/game/GameFormat$DeckRules","cardPoints","()Ljava/util/Map;","invokevirtual",315);}
case 315:{f.Push(f.Locals[7]);f.Pc=317;continue;}
case 317:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",322);}
case 322:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=325;continue;}
case 325:{f.Locals[8]=f.Pop();f.Pc=327;continue;}
case 327:{f.Push(f.Locals[8]);f.Pc=329;continue;}
case 329:{f.Pc=f.Pop().Reference==null?363:332;continue;}
case 332:{f.Push(f.Locals[5]);f.Pc=334;continue;}
case 334:{f.Push(JValue.R(rt.String("\n")));f.Pc=337;continue;}
case 337:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",340);}
case 340:{f.Push(f.Locals[7]);f.Pc=342;continue;}
case 342:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",345);}
case 345:{f.Push(JValue.R(rt.String(" (")));f.Pc=348;continue;}
case 348:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",351);}
case 351:{f.Push(f.Locals[8]);f.Pc=353;continue;}
case 353:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",356);}
case 356:{f.Push(JValue.R(rt.String(")")));f.Pc=359;continue;}
case 359:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",362);}
case 362:{f.StackOp("pop");f.Pc=363;continue;}
case 363:{f.Pc=286;continue;}
case 366:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",369);}
case 369:{f.Push(JValue.R(rt.String("lblFormatOverPoints")));f.Pc=372;continue;}
case 372:{f.Push(JValue.I(2));f.Pc=373;continue;}
case 373:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=376;continue;}
case 376:{f.StackOp("dup");f.Pc=377;continue;}
case 377:{f.Push(JValue.I(0));f.Pc=378;continue;}
case 378:{f.Push(f.Locals[4]);f.Pc=380;continue;}
case 380:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",383);}
case 383:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=384;continue;}
case 384:{f.StackOp("dup");f.Pc=385;continue;}
case 385:{f.Push(JValue.I(1));f.Pc=386;continue;}
case 386:{f.Push(f.Locals[0]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"forge/game/GameFormat","getMaxPoints","()I","invokevirtual",390);}
case 390:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",393);}
case 393:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=394;continue;}
case 394:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",397);}
case 397:{f.Push(f.Locals[5]);f.Pc=399;continue;}
case 399:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",402);}
case 402:{return rt.DynamicCall(f,"forge/game/GameFormat:2298:402:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",407);}
case 407:{return JStep.Return(f.Pop());}
case 408:{f.Push(JValue.R(null));f.Pc=409;continue;}
case 409:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2299(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/DeckFormat","canHaveAnyNumberOf","(Lforge/item/IPaperCard;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int==0?11:7;continue;}
case 7:{f.Push(JValue.I(2147483647));f.Pc=10;continue;}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/deck/DeckFormat","canHaveSpecificNumberInDeck","(Lforge/item/IPaperCard;)Ljava/lang/Integer;","invokestatic",15);}
case 15:{f.Locals[1]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Reference!=null?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=28;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",28);}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2300(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?8:4;continue;}
case 4:{f.Push(JValue.R(rt.String("is not selected")));f.Pc=7;continue;}
case 7:{return JStep.Return(f.Pop());}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/deck/Deck","getAllCardsInASinglePool","()Lforge/deck/CardPool;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/GameFormat","getDeckProblem","(Lforge/deck/Deck;Lforge/deck/CardPool;)Ljava/lang/String;","invokevirtual",17);}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2301(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2302(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?7:5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","formatType","Lforge/game/GameFormat$FormatType;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","formatType","Lforge/game/GameFormat$FormatType;"));f.Pc=15;continue;}
case 15:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?30:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","formatType","Lforge/game/GameFormat$FormatType;"));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","formatType","Lforge/game/GameFormat$FormatType;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/GameFormat$FormatType","compareTo","(Ljava/lang/Enum;)I","invokevirtual",29);}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","formatSubType","Lforge/game/GameFormat$FormatSubType;"));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","formatSubType","Lforge/game/GameFormat$FormatSubType;"));f.Pc=38;continue;}
case 38:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?53:41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","formatSubType","Lforge/game/GameFormat$FormatSubType;"));f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","formatSubType","Lforge/game/GameFormat$FormatSubType;"));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/GameFormat$FormatSubType","compareTo","(Ljava/lang/Enum;)I","invokevirtual",52);}
case 52:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","formatType","Lforge/game/GameFormat$FormatType;"));f.Pc=57;continue;}
case 57:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatType","ARCHIVED","Lforge/game/GameFormat$FormatType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatType","ARCHIVED","Lforge/game/GameFormat$FormatType;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/GameFormat$FormatType","equals","(Ljava/lang/Object;)Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int==0?94:66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","effectiveDate","Ljava/util/Date;"));f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","effectiveDate","Ljava/util/Date;"));f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Date","compareTo","(Ljava/util/Date;)I","invokevirtual",77);}
case 77:{f.Locals[2]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{f.Pc=f.Pop().Int==0?84:82;continue;}
case 82:{f.Push(f.Locals[2]);f.Pc=83;continue;}
case 83:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","index","I"));f.Pc=88;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","index","I"));f.Pc=92;continue;}
case 92:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=93;continue;}
case 93:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","name","Ljava/lang/String;"));f.Pc=98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","name","Ljava/lang/String;"));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/String","compareTo","(Ljava/lang/String;)I","invokevirtual",105);}
case 105:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2303(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat","index","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2304(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameFormat","compareTo","(Lforge/game/GameFormat;)I","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2305(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/GameFormat","isSetLegal","(Ljava/lang/String;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2306(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/card/CardDb","getNormalizedName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2307(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/text/SimpleDateFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/text/SimpleDateFormat")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("yyyy-MM-dd")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/text/SimpleDateFormat","<init>","(Ljava/lang/String;)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/game/GameFormat","formatter","Ljava/text/SimpleDateFormat;"))return JStep.Continue;rt.PutStatic("forge/game/GameFormat","formatter","Ljava/text/SimpleDateFormat;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/game/GameFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameFormat")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("(none)")));f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("1990-01-01")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/GameFormat","parseDate","(Ljava/lang/String;)Ljava/util/Date;","invokestatic",25);}
case 25:{f.Push(JValue.R(null));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(null));f.Pc=27;continue;}
case 27:{f.Push(JValue.R(null));f.Pc=28;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",32);}
case 32:{f.Push(JValue.R(null));f.Pc=33;continue;}
case 33:{f.Push(JValue.R(null));f.Pc=34;continue;}
case 34:{f.Push(JValue.I(2147483647));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatType","CUSTOM","Lforge/game/GameFormat$FormatType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatType","CUSTOM","Lforge/game/GameFormat$FormatType;"));f.Pc=40;continue;}
case 40:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","CUSTOM","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatSubType","CUSTOM","Lforge/game/GameFormat$FormatSubType;"));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/GameFormat","<init>","(Ljava/lang/String;Ljava/util/Date;Ljava/lang/Iterable;Ljava/util/List;Ljava/util/List;Ljava/lang/Boolean;Ljava/util/List;Ljava/util/List;ILforge/game/GameFormat$FormatType;Lforge/game/GameFormat$FormatSubType;)V","invokespecial",46);}
case 46:{if(!rt.StaticReady(f,"forge/game/GameFormat","NoFormat","Lforge/game/GameFormat;"))return JStep.Continue;rt.PutStatic("forge/game/GameFormat","NoFormat","Lforge/game/GameFormat;",f.Pop());f.Pc=49;continue;}
case 49:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

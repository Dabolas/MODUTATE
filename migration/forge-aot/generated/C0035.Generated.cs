// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C35{
internal static JClass Build(){var c=new JClass("forge/card/CardRules","java/lang/Object",new string[]{"forge/card/ICardCharacteristics"},49);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("normalizedName","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("splitType","Lforge/card/CardSplitType;",false,JValue.Default("Lforge/card/CardSplitType;"),null));
c.Add(new JField("mainPart","Lforge/card/ICardFace;",false,JValue.Default("Lforge/card/ICardFace;"),null));
c.Add(new JField("otherPart","Lforge/card/ICardFace;",false,JValue.Default("Lforge/card/ICardFace;"),null));
c.Add(new JField("specializedParts","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("allFaces","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("aiHints","Lforge/card/CardAiHints;",false,JValue.Default("Lforge/card/CardAiHints;"),null));
c.Add(new JField("colorIdentity","Lforge/card/ColorSet;",false,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("deckbuildingColors","Lforge/card/ColorSet;",false,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("meldWith","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("partnerWith","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("partnerType","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("setColorID","I",false,JValue.Default("I"),null));
c.Add(new JField("custom","Z",false,JValue.Default("Z"),null));
c.Add(new JField("unsupported","Z",false,JValue.Default("Z"),null));
c.Add(new JField("placeholderFaces","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("path","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("deltaHand","I",false,JValue.Default("I"),null));
c.Add(new JField("deltaLife","I",false,JValue.Default("I"),null));
c.Add(new JField("tokens","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("supportedFunctionalVariants","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JMethod(595,"forge/card/CardRules","<init>","([Lforge/card/ICardFace;Lforge/card/CardSplitType;Lforge/card/CardAiHints;)V",1,4,4,new JHandler[]{},M595));
c.Add(new JMethod(596,"forge/card/CardRules","reinitializeFromRules","(Lforge/card/CardRules;)V",0,2,3,new JHandler[]{},M596));
c.Add(new JMethod(597,"forge/card/CardRules","calculateColorIdentity","(Lforge/card/CardRules;)Lforge/card/ColorSet;",10,2,2,new JHandler[]{},M597));
c.Add(new JMethod(598,"forge/card/CardRules","calculateColorIdentity","(Lforge/card/ICardFace;)B",10,8,2,new JHandler[]{},M598));
c.Add(new JMethod(599,"forge/card/CardRules","isVariant","()Z",1,2,2,new JHandler[]{},M599));
c.Add(new JMethod(600,"forge/card/CardRules","getSplitType","()Lforge/card/CardSplitType;",1,1,1,new JHandler[]{},M600));
c.Add(new JMethod(601,"forge/card/CardRules","getMainPart","()Lforge/card/ICardFace;",1,1,1,new JHandler[]{},M601));
c.Add(new JMethod(602,"forge/card/CardRules","getOtherPart","()Lforge/card/ICardFace;",1,1,1,new JHandler[]{},M602));
c.Add(new JMethod(603,"forge/card/CardRules","getSpecializeParts","()Ljava/util/Map;",1,1,1,new JHandler[]{},M603));
c.Add(new JMethod(604,"forge/card/CardRules","getAllFaces","()Ljava/util/List;",1,1,1,new JHandler[]{},M604));
c.Add(new JMethod(605,"forge/card/CardRules","isTransformable","()Z",1,1,2,new JHandler[]{},M605));
c.Add(new JMethod(606,"forge/card/CardRules","getWSpecialize","()Lforge/card/ICardFace;",1,1,2,new JHandler[]{},M606));
c.Add(new JMethod(607,"forge/card/CardRules","getUSpecialize","()Lforge/card/ICardFace;",1,1,2,new JHandler[]{},M607));
c.Add(new JMethod(608,"forge/card/CardRules","getBSpecialize","()Lforge/card/ICardFace;",1,1,2,new JHandler[]{},M608));
c.Add(new JMethod(609,"forge/card/CardRules","getRSpecialize","()Lforge/card/ICardFace;",1,1,2,new JHandler[]{},M609));
c.Add(new JMethod(610,"forge/card/CardRules","getGSpecialize","()Lforge/card/ICardFace;",1,1,2,new JHandler[]{},M610));
c.Add(new JMethod(611,"forge/card/CardRules","getName","()Ljava/lang/String;",1,1,2,new JHandler[]{},M611));
c.Add(new JMethod(612,"forge/card/CardRules","getPreInitName","()Ljava/lang/String;",1,3,2,new JHandler[]{},M612));
c.Add(new JMethod(613,"forge/card/CardRules","getNormalizedName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M613));
c.Add(new JMethod(614,"forge/card/CardRules","getPath","()Ljava/lang/String;",1,1,1,new JHandler[]{},M614));
c.Add(new JMethod(615,"forge/card/CardRules","setPath","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M615));
c.Add(new JMethod(616,"forge/card/CardRules","getAiHints","()Lforge/card/CardAiHints;",1,1,1,new JHandler[]{},M616));
c.Add(new JMethod(617,"forge/card/CardRules","isCustom","()Z",1,1,1,new JHandler[]{},M617));
c.Add(new JMethod(618,"forge/card/CardRules","setCustom","()V",1,1,2,new JHandler[]{},M618));
c.Add(new JMethod(619,"forge/card/CardRules","isUnsupported","()Z",1,1,1,new JHandler[]{},M619));
c.Add(new JMethod(620,"forge/card/CardRules","getType","()Lforge/card/CardType;",1,1,3,new JHandler[]{},M620));
c.Add(new JMethod(621,"forge/card/CardRules","getManaCost","()Lforge/card/mana/ManaCost;",1,1,2,new JHandler[]{},M621));
c.Add(new JMethod(622,"forge/card/CardRules","getColor","()Lforge/card/ColorSet;",1,1,4,new JHandler[]{},M622));
c.Add(new JMethod(623,"forge/card/CardRules","canCastFace","(Lforge/card/ICardFace;B)Z",10,2,2,new JHandler[]{},M623));
c.Add(new JMethod(624,"forge/card/CardRules","canCastWithAvailable","(B)Z",1,2,2,new JHandler[]{},M624));
c.Add(new JMethod(625,"forge/card/CardRules","getIntPower","()I",1,1,1,new JHandler[]{},M625));
c.Add(new JMethod(626,"forge/card/CardRules","getIntToughness","()I",1,1,1,new JHandler[]{},M626));
c.Add(new JMethod(627,"forge/card/CardRules","getPower","()Ljava/lang/String;",1,1,1,new JHandler[]{},M627));
c.Add(new JMethod(628,"forge/card/CardRules","getToughness","()Ljava/lang/String;",1,1,1,new JHandler[]{},M628));
c.Add(new JMethod(629,"forge/card/CardRules","getInitialLoyalty","()Ljava/lang/String;",1,1,1,new JHandler[]{},M629));
c.Add(new JMethod(630,"forge/card/CardRules","getDefense","()Ljava/lang/String;",1,1,1,new JHandler[]{},M630));
c.Add(new JMethod(631,"forge/card/CardRules","getAttractionLights","()Ljava/util/Set;",1,1,1,new JHandler[]{},M631));
c.Add(new JMethod(632,"forge/card/CardRules","getOracleText","()Ljava/lang/String;",1,1,2,new JHandler[]{},M632));
c.Add(new JMethod(633,"forge/card/CardRules","isEnterableDungeon","()Z",1,1,2,new JHandler[]{},M633));
c.Add(new JMethod(634,"forge/card/CardRules","canBeCommander","()Z",1,2,2,new JHandler[]{},M634));
c.Add(new JMethod(635,"forge/card/CardRules","canBePartnerCommanders","(Lforge/card/CardRules;Z)Z",1,3,2,new JHandler[]{},M635));
c.Add(new JMethod(636,"forge/card/CardRules","canBePartnerCommanders","(Lforge/card/CardRules;)Z",1,2,3,new JHandler[]{},M636));
c.Add(new JMethod(637,"forge/card/CardRules","canBePartnerCommander","()Z",1,1,2,new JHandler[]{},M637));
}

private static void Add1(JClass c){
c.Add(new JMethod(638,"forge/card/CardRules","canBeBackground","()Z",1,1,2,new JHandler[]{},M638));
c.Add(new JMethod(639,"forge/card/CardRules","isDoctor","()Z",1,4,2,new JHandler[]{},M639));
c.Add(new JMethod(640,"forge/card/CardRules","canBeOathbreaker","()Z",1,2,2,new JHandler[]{},M640));
c.Add(new JMethod(641,"forge/card/CardRules","canBeSignatureSpell","()Z",1,2,1,new JHandler[]{},M641));
c.Add(new JMethod(642,"forge/card/CardRules","canBeBrawlCommander","()Z",1,2,1,new JHandler[]{},M642));
c.Add(new JMethod(643,"forge/card/CardRules","canBeTinyLeadersCommander","()Z",1,2,1,new JHandler[]{},M643));
c.Add(new JMethod(644,"forge/card/CardRules","canBeCreature","()Z",1,4,2,new JHandler[]{},M644));
c.Add(new JMethod(645,"forge/card/CardRules","getMeldWith","()Ljava/lang/String;",1,1,1,new JHandler[]{},M645));
c.Add(new JMethod(646,"forge/card/CardRules","getPartnerWith","()Ljava/lang/String;",1,1,1,new JHandler[]{},M646));
c.Add(new JMethod(647,"forge/card/CardRules","getAddsWildCardColor","()Z",1,1,2,new JHandler[]{},M647));
c.Add(new JMethod(648,"forge/card/CardRules","getDeckRules","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M648));
c.Add(new JMethod(649,"forge/card/CardRules","getSetColorID","()I",1,1,1,new JHandler[]{},M649));
c.Add(new JMethod(650,"forge/card/CardRules","getTokens","()Ljava/util/List;",1,1,1,new JHandler[]{},M650));
c.Add(new JMethod(651,"forge/card/CardRules","getHand","()I",1,1,1,new JHandler[]{},M651));
c.Add(new JMethod(652,"forge/card/CardRules","getLife","()I",1,1,1,new JHandler[]{},M652));
c.Add(new JMethod(653,"forge/card/CardRules","setVanguardProperties","(Ljava/lang/String;)V",1,3,4,new JHandler[]{},M653));
c.Add(new JMethod(654,"forge/card/CardRules","hasFunctionalVariants","()Z",1,1,1,new JHandler[]{},M654));
c.Add(new JMethod(655,"forge/card/CardRules","getSupportedFunctionalVariants","()Ljava/util/Set;",1,1,1,new JHandler[]{},M655));
c.Add(new JMethod(656,"forge/card/CardRules","getDisplayNameForVariant","(Ljava/lang/String;)Ljava/lang/String;",1,6,2,new JHandler[]{},M656));
c.Add(new JMethod(657,"forge/card/CardRules","findOrCreateVariantForFlavorName","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",0,7,3,new JHandler[]{},M657));
c.Add(new JMethod(658,"forge/card/CardRules","hasPlaceholderFaces","()Z",0,1,1,new JHandler[]{},M658));
c.Add(new JMethod(659,"forge/card/CardRules","getPlaceholderFaceNames","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M659));
c.Add(new JMethod(660,"forge/card/CardRules","supplyPlaceholderFaces","(Ljava/util/Map;)V",0,7,4,new JHandler[]{},M660));
c.Add(new JMethod(661,"forge/card/CardRules","getColorIdentity","()Lforge/card/ColorSet;",1,1,1,new JHandler[]{},M661));
c.Add(new JMethod(662,"forge/card/CardRules","fromScript","(Ljava/lang/Iterable;)Lforge/card/CardRules;",9,4,2,new JHandler[]{},M662));
c.Add(new JMethod(663,"forge/card/CardRules","getUnsupportedCardNamed","(Ljava/lang/String;)Lforge/card/CardRules;",9,4,8,new JHandler[]{},M663));
c.Add(new JMethod(664,"forge/card/CardRules","hasKeyword","(Ljava/lang/String;)Z",1,2,2,new JHandler[]{},M664));
c.Add(new JMethod(665,"forge/card/CardRules","hasStartOfKeyword","(Ljava/lang/String;)Z",1,2,3,new JHandler[]{},M665));
c.Add(new JMethod(666,"forge/card/CardRules","hasStartOfKeyword","(Ljava/lang/String;Lforge/card/ICardFace;)Z",1,5,2,new JHandler[]{},M666));
c.Add(new JMethod(667,"forge/card/CardRules","getKeywordMagnitude","(Ljava/lang/String;)Ljava/lang/Integer;",1,5,2,new JHandler[]{},M667));
c.Add(new JMethod(668,"forge/card/CardRules","getDeckbuildingColors","()Lforge/card/ColorSet;",1,3,3,new JHandler[]{},M668));
}

internal static JStep M595(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","specializedParts","Ljava/util/Map;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Collections","emptyList","()Ljava/util/List;","invokestatic",15);}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","tokens","Ljava/util/List;",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","splitType","Lforge/card/CardSplitType;",value);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=27;continue;}
case 27:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;",value);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=34;continue;}
case 34:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;",value);f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Specialize","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Specialize","Lforge/card/CardSplitType;"));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","splitType","Lforge/card/CardSplitType;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/card/CardSplitType","equals","(Ljava/lang/Object;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?131:50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","specializedParts","Ljava/util/Map;"));f.Pc=54;continue;}
case 54:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeW","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","SpecializeW","Lforge/card/CardStateName;"));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{f.Push(JValue.I(2));f.Pc=59;continue;}
case 59:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","specializedParts","Ljava/util/Map;"));f.Pc=70;continue;}
case 70:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeU","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","SpecializeU","Lforge/card/CardStateName;"));f.Pc=73;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{f.Push(JValue.I(3));f.Pc=75;continue;}
case 75:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",81);}
case 81:{f.StackOp("pop");f.Pc=82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","specializedParts","Ljava/util/Map;"));f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeB","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","SpecializeB","Lforge/card/CardStateName;"));f.Pc=89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{f.Push(JValue.I(4));f.Pc=91;continue;}
case 91:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",97);}
case 97:{f.StackOp("pop");f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","specializedParts","Ljava/util/Map;"));f.Pc=102;continue;}
case 102:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeR","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","SpecializeR","Lforge/card/CardStateName;"));f.Pc=105;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{f.Push(JValue.I(5));f.Pc=107;continue;}
case 107:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",113);}
case 113:{f.StackOp("pop");f.Pc=114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","specializedParts","Ljava/util/Map;"));f.Pc=118;continue;}
case 118:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeG","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","SpecializeG","Lforge/card/CardStateName;"));f.Pc=121;continue;}
case 121:{f.Push(f.Locals[1]);f.Pc=122;continue;}
case 122:{f.Push(JValue.I(6));f.Pc=124;continue;}
case 124:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",130);}
case 130:{f.StackOp("pop");f.Pc=131;continue;}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[1]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/util/Arrays","stream","([Ljava/lang/Object;)Ljava/util/stream/Stream;","invokestatic",136);}
case 136:{return rt.DynamicCall(f,"forge/card/CardRules:595:136:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",141);}
case 141:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",146);}
case 146:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",149);}
case 149:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",154);}
case 154:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=157;continue;}
case 157:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","allFaces","Ljava/util/List;",value);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[3]);f.Pc=162;continue;}
case 162:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","aiHints","Lforge/card/CardAiHints;",value);f.Pc=165;continue;}
case 165:{f.Push(f.Locals[0]);f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.String("")));f.Pc=168;continue;}
case 168:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","meldWith","Ljava/lang/String;",value);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[0]);f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.String("")));f.Pc=174;continue;}
case 174:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","partnerWith","Ljava/lang/String;",value);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[0]);f.Pc=178;continue;}
case 178:{f.Push(JValue.R(rt.String("")));f.Pc=180;continue;}
case 180:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","partnerType","Ljava/lang/String;",value);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[0]);f.Pc=184;continue;}
case 184:{f.Push(JValue.I(0));f.Pc=185;continue;}
case 185:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","setColorID","I",value);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[0]);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[0]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/card/CardRules","calculateColorIdentity","(Lforge/card/CardRules;)Lforge/card/ColorSet;","invokestatic",193);}
case 193:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","colorIdentity","Lforge/card/ColorSet;",value);f.Pc=196;continue;}
case 196:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M596(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?24:14;continue;}
case 14:{if(!rt.EnsureInitialized(f,"java/lang/UnsupportedOperationException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/UnsupportedOperationException")));f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("You cannot rename the card using the same CardRules object")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/UnsupportedOperationException","<init>","(Ljava/lang/String;)V","invokespecial",23);}
case 23:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","splitType","Lforge/card/CardSplitType;"));f.Pc=29;continue;}
case 29:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","splitType","Lforge/card/CardSplitType;",value);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=37;continue;}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;"));f.Pc=45;continue;}
case 45:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;",value);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","specializedParts","Ljava/util/Map;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","(Ljava/util/Map;)Ljava/util/HashMap;","invokestatic",56);}
case 56:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","specializedParts","Ljava/util/Map;",value);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","allFaces","Ljava/util/List;"));f.Pc=64;continue;}
case 64:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","allFaces","Ljava/util/List;",value);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","aiHints","Lforge/card/CardAiHints;"));f.Pc=72;continue;}
case 72:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","aiHints","Lforge/card/CardAiHints;",value);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","colorIdentity","Lforge/card/ColorSet;"));f.Pc=80;continue;}
case 80:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","colorIdentity","Lforge/card/ColorSet;",value);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","meldWith","Ljava/lang/String;"));f.Pc=88;continue;}
case 88:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","meldWith","Ljava/lang/String;",value);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","partnerWith","Ljava/lang/String;"));f.Pc=96;continue;}
case 96:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","partnerWith","Ljava/lang/String;",value);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","setColorID","I"));f.Pc=104;continue;}
case 104:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","setColorID","I",value);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","tokens","Ljava/util/List;"));f.Pc=112;continue;}
case 112:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","tokens","Ljava/util/List;",value);f.Pc=115;continue;}
case 115:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M597(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardRules","calculateColorIdentity","(Lforge/card/ICardFace;)B","invokestatic",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;"));f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference==null?26:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardRules","calculateColorIdentity","(Lforge/card/ICardFace;)B","invokestatic",23);}
case 23:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=24;continue;}
case 24:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=25;continue;}
case 25:{f.Locals[1]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",30);}
case 30:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M598(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/ICardFace","getColor","()Lforge/card/ColorSet;","invokeinterface",12);}
case 12:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",15);}
case 15:{f.Locals[1]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/card/ICardFace","getOracleText","()Ljava/lang/String;","invokeinterface",26);}
case 26:{f.Locals[4]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/card/ICardFace","getStaticAbilities","()Ljava/lang/Iterable;","invokeinterface",34);}
case 34:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",39);}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[5]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",48);}
case 48:{f.Pc=f.Pop().Int==0?89:51;continue;}
case 51:{f.Push(f.Locals[5]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{f.Locals[6]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[6]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("CharacteristicDefining$ True")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",70);}
case 70:{f.Pc=f.Pop().Int==0?86:73;continue;}
case 73:{f.Push(f.Locals[6]);f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("SetColor$ All")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",80);}
case 80:{f.Pc=f.Pop().Int==0?86:83;continue;}
case 83:{f.Push(JValue.I(31));f.Pc=85;continue;}
case 85:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 86:{f.Pc=41;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{f.Push(JValue.I(31));f.Pc=92;continue;}
case 92:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?97:95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 97:{f.Push(f.Locals[4]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",102);}
case 102:{f.Locals[5]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(JValue.I(0));f.Pc=105;continue;}
case 105:{f.Locals[6]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[6]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[5]);f.Pc=111;continue;}
case 111:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?301:114;continue;}
case 114:{f.Push(f.Locals[4]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[6]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",121);}
case 121:{f.Locals[7]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[7]);f.Pc=125;continue;}
case 125:{switch(f.Pop().Int){case 40:f.Pc=168;break;case 41:f.Pc=182;break;case 123:f.Pc=187;break;case 125:f.Pc=192;break;default:f.Pc=197;break;}continue;}
case 168:{f.Push(f.Locals[6]);f.Pc=170;continue;}
case 170:{f.Pc=f.Pop().Int<=0?177:173;continue;}
case 173:{f.Push(JValue.I(1));f.Pc=174;continue;}
case 174:{f.Pc=178;continue;}
case 177:{f.Push(JValue.I(0));f.Pc=178;continue;}
case 178:{f.Locals[2]=f.Pop();f.Pc=179;continue;}
case 179:{f.Pc=295;continue;}
case 182:{f.Push(JValue.I(0));f.Pc=183;continue;}
case 183:{f.Locals[2]=f.Pop();f.Pc=184;continue;}
case 184:{f.Pc=295;continue;}
case 187:{f.Push(JValue.I(1));f.Pc=188;continue;}
case 188:{f.Locals[3]=f.Pop();f.Pc=189;continue;}
case 189:{f.Pc=295;continue;}
case 192:{f.Push(JValue.I(0));f.Pc=193;continue;}
case 193:{f.Locals[3]=f.Pop();f.Pc=194;continue;}
case 194:{f.Pc=295;continue;}
case 197:{f.Push(f.Locals[3]);f.Pc=198;continue;}
case 198:{f.Pc=f.Pop().Int==0?295:201;continue;}
case 201:{f.Push(f.Locals[2]);f.Pc=202;continue;}
case 202:{f.Pc=f.Pop().Int!=0?295:205;continue;}
case 205:{f.Push(f.Locals[7]);f.Pc=207;continue;}
case 207:{switch(f.Pop().Int){case 66:f.Pc=272;break;case 71:f.Pc=289;break;case 82:f.Pc=280;break;case 85:f.Pc=264;break;case 87:f.Pc=256;break;default:f.Pc=295;break;}continue;}
case 256:{f.Push(f.Locals[1]);f.Pc=257;continue;}
case 257:{f.Push(JValue.I(1));f.Pc=258;continue;}
case 258:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=259;continue;}
case 259:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=260;continue;}
case 260:{f.Locals[1]=f.Pop();f.Pc=261;continue;}
case 261:{f.Pc=295;continue;}
case 264:{f.Push(f.Locals[1]);f.Pc=265;continue;}
case 265:{f.Push(JValue.I(2));f.Pc=266;continue;}
case 266:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=267;continue;}
case 267:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=268;continue;}
case 268:{f.Locals[1]=f.Pop();f.Pc=269;continue;}
case 269:{f.Pc=295;continue;}
case 272:{f.Push(f.Locals[1]);f.Pc=273;continue;}
case 273:{f.Push(JValue.I(4));f.Pc=274;continue;}
case 274:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=275;continue;}
case 275:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=276;continue;}
case 276:{f.Locals[1]=f.Pop();f.Pc=277;continue;}
case 277:{f.Pc=295;continue;}
case 280:{f.Push(f.Locals[1]);f.Pc=281;continue;}
case 281:{f.Push(JValue.I(8));f.Pc=283;continue;}
case 283:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=284;continue;}
case 284:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=285;continue;}
case 285:{f.Locals[1]=f.Pop();f.Pc=286;continue;}
case 286:{f.Pc=295;continue;}
case 289:{f.Push(f.Locals[1]);f.Pc=290;continue;}
case 290:{f.Push(JValue.I(16));f.Pc=292;continue;}
case 292:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=293;continue;}
case 293:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=294;continue;}
case 294:{f.Locals[1]=f.Pop();f.Pc=295;continue;}
case 295:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=298;continue;}
case 298:{f.Pc=107;continue;}
case 301:{f.Push(f.Locals[1]);f.Pc=302;continue;}
case 302:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M599(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","placeholderFaces","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?29:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Reference==null?27:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","splitType","Lforge/card/CardSplitType;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/card/CardSplitType","getAggregationMethod","()Lforge/card/CardSplitType$FaceSelectionMethod;","invokevirtual",21);}
case 21:{if(!rt.StaticReady(f,"forge/card/CardSplitType$FaceSelectionMethod","COMBINE","Lforge/card/CardSplitType$FaceSelectionMethod;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType$FaceSelectionMethod","COMBINE","Lforge/card/CardSplitType$FaceSelectionMethod;"));f.Pc=24;continue;}
case 24:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?29:27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",33);}
case 33:{f.Locals[1]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/card/CardType","isVanguard","()Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int!=0?97:41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/card/CardType","isScheme","()Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int!=0?97:48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/card/CardType","isPlane","()Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int!=0?97:55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/card/CardType","isPhenomenon","()Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int!=0?97:62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/card/CardType","isConspiracy","()Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int!=0?97:69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/card/CardType","isDungeon","()Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int!=0?97:76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/card/CardType","isAttraction","()Z","invokevirtual",80);}
case 80:{f.Pc=f.Pop().Int!=0?97:83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/card/CardType","isContraption","()Z","invokevirtual",87);}
case 87:{f.Pc=f.Pop().Int!=0?97:90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/card/CardType","isStickers","()Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int==0?101:97;continue;}
case 97:{f.Push(JValue.I(1));f.Pc=98;continue;}
case 98:{f.Pc=102;continue;}
case 101:{f.Push(JValue.I(0));f.Pc=102;continue;}
case 102:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M600(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","splitType","Lforge/card/CardSplitType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M601(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M602(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M603(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","specializedParts","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M604(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","allFaces","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M605(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Transform","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Transform","Lforge/card/CardSplitType;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardRules","getSplitType","()Lforge/card/CardSplitType;","invokevirtual",7);}
case 7:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?20:10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Modal","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Modal","Lforge/card/CardSplitType;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/card/CardRules","getSplitType","()Lforge/card/CardSplitType;","invokevirtual",17);}
case 17:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M606(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","specializedParts","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeW","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","SpecializeW","Lforge/card/CardStateName;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M607(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","specializedParts","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeU","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","SpecializeU","Lforge/card/CardStateName;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M608(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","specializedParts","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeB","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","SpecializeB","Lforge/card/CardStateName;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M609(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","specializedParts","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeR","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","SpecializeR","Lforge/card/CardStateName;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M610(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","specializedParts","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeG","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","SpecializeG","Lforge/card/CardStateName;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M611(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardRules$1","$SwitchMap$forge$card$CardSplitType$FaceSelectionMethod","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRules$1","$SwitchMap$forge$card$CardSplitType$FaceSelectionMethod","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","splitType","Lforge/card/CardSplitType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardSplitType","getAggregationMethod","()Lforge/card/CardSplitType$FaceSelectionMethod;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/card/CardSplitType$FaceSelectionMethod","ordinal","()I","invokevirtual",13);}
case 13:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=14;continue;}
case 14:{switch(f.Pop().Int){case 1:f.Pc=32;break;default:f.Pc=56;break;}continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",41);}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",50);}
case 50:{return rt.DynamicCall(f,"forge/card/CardRules:611:50:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",55);}
case 55:{return JStep.Return(f.Pop());}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",65);}
case 65:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M612(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","placeholderFaces","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?12:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",11);}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=16;continue;}
case 16:{f.Pc=f.Pop().Reference!=null?38:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","placeholderFaces","Ljava/util/Map;"));f.Pc=23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",27);}
case 27:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",32);}
case 32:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=35;continue;}
case 35:{f.Pc=47;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",47);}
case 47:{f.Locals[1]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","splitType","Lforge/card/CardSplitType;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/card/CardSplitType","getAggregationMethod","()Lforge/card/CardSplitType$FaceSelectionMethod;","invokevirtual",55);}
case 55:{if(!rt.StaticReady(f,"forge/card/CardSplitType$FaceSelectionMethod","COMBINE","Lforge/card/CardSplitType$FaceSelectionMethod;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType$FaceSelectionMethod","COMBINE","Lforge/card/CardSplitType$FaceSelectionMethod;"));f.Pc=58;continue;}
case 58:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?105:61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;"));f.Pc=65;continue;}
case 65:{f.Pc=f.Pop().Reference!=null?87:68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","placeholderFaces","Ljava/util/Map;"));f.Pc=72;continue;}
case 72:{f.Push(JValue.I(1));f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",76);}
case 76:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",81);}
case 81:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=84;continue;}
case 84:{f.Pc=96;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;"));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",96);}
case 96:{f.Locals[2]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{return rt.DynamicCall(f,"forge/card/CardRules:612:99:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",104);}
case 104:{return JStep.Return(f.Pop());}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M613(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","normalizedName","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M614(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","path","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M615(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","path","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M616(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","aiHints","Lforge/card/CardAiHints;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M617(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","custom","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M618(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","custom","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M619(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","unsupported","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M620(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?16:7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/card/CardType","<init>","(Z)V","invokespecial",15);}
case 15:{return JStep.Return(f.Pop());}
case 16:{if(!rt.StaticReady(f,"forge/card/CardRules$1","$SwitchMap$forge$card$CardSplitType$FaceSelectionMethod","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRules$1","$SwitchMap$forge$card$CardSplitType$FaceSelectionMethod","[I"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","splitType","Lforge/card/CardSplitType;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/card/CardSplitType","getAggregationMethod","()Lforge/card/CardSplitType$FaceSelectionMethod;","invokevirtual",26);}
case 26:{return rt.Call(f,"forge/card/CardSplitType$FaceSelectionMethod","ordinal","()I","invokevirtual",29);}
case 29:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=30;continue;}
case 30:{switch(f.Pop().Int){case 1:f.Pc=48;break;default:f.Pc=87;break;}continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;"));f.Pc=52;continue;}
case 52:{f.Pc=f.Pop().Reference!=null?65:55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",64);}
case 64:{return JStep.Return(f.Pop());}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",74);}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;"));f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",83);}
case 83:{return rt.Call(f,"forge/card/CardType","combine","(Lforge/card/CardType;Lforge/card/CardType;)Lforge/card/CardType;","invokestatic",86);}
case 86:{return JStep.Return(f.Pop());}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",96);}
case 96:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M621(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardRules$1","$SwitchMap$forge$card$CardSplitType$FaceSelectionMethod","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRules$1","$SwitchMap$forge$card$CardSplitType$FaceSelectionMethod","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","splitType","Lforge/card/CardSplitType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardSplitType","getAggregationMethod","()Lforge/card/CardSplitType$FaceSelectionMethod;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/card/CardSplitType$FaceSelectionMethod","ordinal","()I","invokevirtual",13);}
case 13:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=14;continue;}
case 14:{switch(f.Pop().Int){case 1:f.Pc=32;break;default:f.Pc=54;break;}continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/card/ICardFace","getManaCost","()Lforge/card/mana/ManaCost;","invokeinterface",41);}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/card/ICardFace","getManaCost","()Lforge/card/mana/ManaCost;","invokeinterface",50);}
case 50:{return rt.Call(f,"forge/card/mana/ManaCost","combine","(Lforge/card/mana/ManaCost;Lforge/card/mana/ManaCost;)Lforge/card/mana/ManaCost;","invokestatic",53);}
case 53:{return JStep.Return(f.Pop());}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/card/ICardFace","getManaCost","()Lforge/card/mana/ManaCost;","invokeinterface",63);}
case 63:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M622(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardRules$1","$SwitchMap$forge$card$CardSplitType$FaceSelectionMethod","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRules$1","$SwitchMap$forge$card$CardSplitType$FaceSelectionMethod","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","splitType","Lforge/card/CardSplitType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardSplitType","getAggregationMethod","()Lforge/card/CardSplitType$FaceSelectionMethod;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/card/CardSplitType$FaceSelectionMethod","ordinal","()I","invokevirtual",13);}
case 13:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=14;continue;}
case 14:{switch(f.Pop().Int){case 1:f.Pc=32;break;default:f.Pc=64;break;}continue;}
case 32:{f.Push(JValue.I(2));f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.NewArray("Lforge/card/ColorSet;",f.Pop().Int)));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/card/ICardFace","getColor","()Lforge/card/ColorSet;","invokeinterface",47);}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(1));f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;"));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/card/ICardFace","getColor","()Lforge/card/ColorSet;","invokeinterface",59);}
case 59:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/card/ColorSet","combine","([Lforge/card/ColorSet;)Lforge/card/ColorSet;","invokestatic",63);}
case 63:{return JStep.Return(f.Pop());}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/card/ICardFace","getColor","()Lforge/card/ColorSet;","invokeinterface",73);}
case 73:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M623(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ICardFace","getManaCost","()Lforge/card/mana/ManaCost;","invokeinterface",6);}
case 6:{return rt.Call(f,"forge/card/mana/ManaCost","isNoCost","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?23:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/ICardFace","getColor","()Lforge/card/ColorSet;","invokeinterface",18);}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/card/ColorSet","hasNoColorsExcept","(I)Z","invokevirtual",22);}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/card/ICardFace","getManaCost","()Lforge/card/mana/ManaCost;","invokeinterface",29);}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/mana/ManaCost","canBePaidWithAvailable","(B)Z","invokevirtual",33);}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M624(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardRules$1","$SwitchMap$forge$card$CardSplitType$FaceSelectionMethod","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRules$1","$SwitchMap$forge$card$CardSplitType$FaceSelectionMethod","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","splitType","Lforge/card/CardSplitType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardSplitType","getAggregationMethod","()Lforge/card/CardSplitType$FaceSelectionMethod;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/card/CardSplitType$FaceSelectionMethod","ordinal","()I","invokevirtual",13);}
case 13:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=14;continue;}
case 14:{switch(f.Pop().Int){case 1:f.Pc=32;break;default:f.Pc=60;break;}continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/card/CardRules","canCastFace","(Lforge/card/ICardFace;B)Z","invokestatic",40);}
case 40:{f.Pc=f.Pop().Int!=0?54:43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;"));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/card/CardRules","canCastFace","(Lforge/card/ICardFace;B)Z","invokestatic",51);}
case 51:{f.Pc=f.Pop().Int==0?58:54;continue;}
case 54:{f.Push(JValue.I(1));f.Pc=55;continue;}
case 55:{f.Pc=59;continue;}
case 58:{f.Push(JValue.I(0));f.Pc=59;continue;}
case 59:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/card/CardRules","canCastFace","(Lforge/card/ICardFace;B)Z","invokestatic",68);}
case 68:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M625(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/ICardFace","getIntPower","()I","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M626(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/ICardFace","getIntToughness","()I","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M627(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/ICardFace","getPower","()Ljava/lang/String;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M628(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/ICardFace","getToughness","()Ljava/lang/String;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M629(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/ICardFace","getInitialLoyalty","()Ljava/lang/String;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M630(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/ICardFace","getDefense","()Ljava/lang/String;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M631(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/ICardFace","getAttractionLights","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M632(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardRules$1","$SwitchMap$forge$card$CardSplitType$FaceSelectionMethod","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRules$1","$SwitchMap$forge$card$CardSplitType$FaceSelectionMethod","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","splitType","Lforge/card/CardSplitType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardSplitType","getAggregationMethod","()Lforge/card/CardSplitType$FaceSelectionMethod;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/card/CardSplitType$FaceSelectionMethod","ordinal","()I","invokevirtual",13);}
case 13:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=14;continue;}
case 14:{switch(f.Pop().Int){case 1:f.Pc=32;break;default:f.Pc=56;break;}continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/card/ICardFace","getOracleText","()Ljava/lang/String;","invokeinterface",41);}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/card/ICardFace","getOracleText","()Ljava/lang/String;","invokeinterface",50);}
case 50:{return rt.DynamicCall(f,"forge/card/CardRules:632:50:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",55);}
case 55:{return JStep.Return(f.Pop());}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/card/ICardFace","getOracleText","()Ljava/lang/String;","invokeinterface",65);}
case 65:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M633(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/ICardFace","getOracleText","()Ljava/lang/String;","invokeinterface",9);}
case 9:{f.Push(JValue.R(rt.String("You can't enter this dungeon unless")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?20:18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/card/CardType","isDungeon","()Z","invokevirtual",27);}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M634(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/ICardFace","getOracleText","()Ljava/lang/String;","invokeinterface",9);}
case 9:{f.Push(JValue.R(rt.String("can be your commander")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int!=0?25:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/card/CardRules","canBeBackground","()Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?27:25;continue;}
case 25:{f.Push(JValue.I(1));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",36);}
case 36:{f.Locals[1]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/card/CardType","isLegendary","()Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int!=0?46:44;continue;}
case 44:{f.Push(JValue.I(0));f.Pc=45;continue;}
case 45:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/card/CardRules","canBeCreature","()Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int!=0?74:53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/card/CardType","isVehicle","()Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int!=0?74:60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/card/CardType","isSpacecraft","()Z","invokevirtual",64);}
case 64:{f.Pc=f.Pop().Int==0?76:67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/card/CardRules","getPower","()Ljava/lang/String;","invokevirtual",71);}
case 71:{f.Pc=f.Pop().Reference==null?76:74;continue;}
case 74:{f.Push(JValue.I(1));f.Pc=75;continue;}
case 75:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 76:{f.Push(JValue.I(0));f.Pc=77;continue;}
case 77:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M635(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int==0?62:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardRules","canBeCommander","()Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?62:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("Partner")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/card/CardRules","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int!=0?32:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/card/CardRules","getColorIdentity","()Lforge/card/ColorSet;","invokevirtual",25);}
case 25:{return rt.Call(f,"forge/card/ColorSet","countColors","()I","invokevirtual",28);}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?62:32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/card/CardRules","canBeCommander","()Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int==0?62:39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("Partner")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/card/CardRules","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int!=0?60:49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/card/CardRules","getColorIdentity","()Lforge/card/ColorSet;","invokevirtual",53);}
case 53:{return rt.Call(f,"forge/card/ColorSet","countColors","()I","invokevirtual",56);}
case 56:{f.Push(JValue.I(1));f.Pc=57;continue;}
case 57:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?62:60;continue;}
case 60:{f.Push(JValue.I(1));f.Pc=61;continue;}
case 61:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("Partner")));f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/card/CardRules","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int==0?84:72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("Partner")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/card/CardRules","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int==0?84:82;continue;}
case 82:{f.Push(JValue.I(1));f.Pc=83;continue;}
case 83:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",88);}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/card/CardRules","getPartnerWith","()Ljava/lang/String;","invokevirtual",92);}
case 92:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",95);}
case 95:{f.Pc=f.Pop().Int==0?114:98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",102);}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/card/CardRules","getPartnerWith","()Ljava/lang/String;","invokevirtual",106);}
case 106:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",109);}
case 109:{f.Pc=f.Pop().Int==0?114:112;continue;}
case 112:{f.Push(JValue.I(1));f.Pc=113;continue;}
case 113:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","partnerType","Ljava/lang/String;"));f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",121);}
case 121:{f.Pc=f.Pop().Int!=0?140:124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","partnerType","Ljava/lang/String;"));f.Pc=128;continue;}
case 128:{f.Push(f.Locals[1]);f.Pc=129;continue;}
case 129:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","partnerType","Ljava/lang/String;"));f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",135);}
case 135:{f.Pc=f.Pop().Int==0?140:138;continue;}
case 138:{f.Push(JValue.I(1));f.Pc=139;continue;}
case 139:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 140:{f.Push(f.Locals[0]);f.Pc=141;continue;}
case 141:{f.Push(JValue.R(rt.String("Choose a Background")));f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/card/CardRules","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",147);}
case 147:{f.Pc=f.Pop().Int==0?157:150;continue;}
case 150:{f.Push(f.Locals[1]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/card/CardRules","canBeBackground","()Z","invokevirtual",154);}
case 154:{f.Pc=f.Pop().Int!=0?174:157;continue;}
case 157:{f.Push(f.Locals[1]);f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.String("Choose a Background")));f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/card/CardRules","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",164);}
case 164:{f.Pc=f.Pop().Int==0?176:167;continue;}
case 167:{f.Push(f.Locals[0]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/card/CardRules","canBeBackground","()Z","invokevirtual",171);}
case 171:{f.Pc=f.Pop().Int==0?176:174;continue;}
case 174:{f.Push(JValue.I(1));f.Pc=175;continue;}
case 175:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 176:{f.Push(f.Locals[0]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/card/CardRules","isDoctor","()Z","invokevirtual",180);}
case 180:{f.Pc=f.Pop().Int==0?193:183;continue;}
case 183:{f.Push(f.Locals[1]);f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String("Doctor's companion")));f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/card/CardRules","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",190);}
case 190:{f.Pc=f.Pop().Int!=0?210:193;continue;}
case 193:{f.Push(f.Locals[0]);f.Pc=194;continue;}
case 194:{f.Push(JValue.R(rt.String("Doctor's companion")));f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/card/CardRules","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",200);}
case 200:{f.Pc=f.Pop().Int==0?212:203;continue;}
case 203:{f.Push(f.Locals[1]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/card/CardRules","isDoctor","()Z","invokevirtual",207);}
case 207:{f.Pc=f.Pop().Int==0?212:210;continue;}
case 210:{f.Push(JValue.I(1));f.Pc=211;continue;}
case 211:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 212:{f.Push(JValue.I(0));f.Pc=213;continue;}
case 213:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M636(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/CardRules","canBePartnerCommanders","(Lforge/card/CardRules;Z)Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M637(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","canBeBackground","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?9:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/card/CardRules","canBeCommander","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int!=0?18:16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("Partner")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/card/CardRules","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int!=0?75:28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","partnerWith","Ljava/lang/String;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?75:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","partnerType","Ljava/lang/String;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int==0?75:48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("Choose a Background")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/card/CardRules","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int!=0?75:58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("Doctor's companion")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/card/CardRules","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int!=0?75:68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/card/CardRules","isDoctor","()Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?79:75;continue;}
case 75:{f.Push(JValue.I(1));f.Pc=76;continue;}
case 76:{f.Pc=80;continue;}
case 79:{f.Push(JValue.I(0));f.Pc=80;continue;}
case 80:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M638(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",9);}
case 9:{f.Push(JValue.R(rt.String("Background")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",15);}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M639(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",17);}
case 17:{return rt.Call(f,"forge/card/CardType","getSubtypes","()Ljava/util/Collection;","invokevirtual",20);}
case 20:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",25);}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?56:35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Locals[3]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{f.Pc=26;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",62);}
case 62:{f.Push(JValue.I(2));f.Pc=63;continue;}
case 63:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?94:66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("Time Lord")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",75);}
case 75:{f.Pc=f.Pop().Int==0?94:78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("Doctor")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",87);}
case 87:{f.Pc=f.Pop().Int==0?94:90;continue;}
case 90:{f.Push(JValue.I(1));f.Pc=91;continue;}
case 91:{f.Pc=95;continue;}
case 94:{f.Push(JValue.I(0));f.Pc=95;continue;}
case 95:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M640(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/card/ICardFace","getOracleText","()Ljava/lang/String;","invokeinterface",19);}
case 19:{f.Push(JValue.R(rt.String("can be your commander")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?30:28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/card/CardType","isPlaneswalker","()Z","invokevirtual",34);}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M641(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/CardType","isInstant","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int!=0?24:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/card/CardType","isSorcery","()Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?28:24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Pc=29;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M642(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/CardType","isLegendary","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int!=0?19:17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardRules","canBeCreature","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int!=0?33:26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/card/CardType","isPlaneswalker","()Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?35:33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M643(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/CardType","isLegendary","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int!=0?19:17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardRules","canBeCreature","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int!=0?33:26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/card/CardType","isPlaneswalker","()Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?35:33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M644(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/CardType","isCreature","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?19:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/card/ICardFace","getStaticAbilities","()Ljava/lang/Iterable;","invokeinterface",28);}
case 28:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",33);}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",40);}
case 40:{f.Pc=f.Pop().Int==0?77:43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{f.Locals[3]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("CharacteristicDefining$ True")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int==0?74:62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("AddType$ Creature")));f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int==0?74:72;continue;}
case 72:{f.Push(JValue.I(1));f.Pc=73;continue;}
case 73:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 74:{f.Pc=34;continue;}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M645(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","meldWith","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M646(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","partnerWith","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M647(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/ICardFace","getOracleText","()Ljava/lang/String;","invokeinterface",9);}
case 9:{f.Push(JValue.R(rt.String(" is your commander, choose a color before the game begins.")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",15);}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M648(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/ICardFace","getDeckRules","()Ljava/lang/Iterable;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M649(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","setColorID","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M650(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","tokens","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M651(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","deltaHand","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M652(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","deltaLife","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M653(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?8:4;continue;}
case 4:{f.Push(JValue.I(-1));f.Pc=5;continue;}
case 5:{f.Pc=14;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.I(47));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(-1));f.Pc=17;continue;}
case 17:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?37:20;continue;}
case 20:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",28);}
case 28:{return rt.DynamicCall(f,"forge/card/CardRules:653:28:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",33);}
case 33:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",36);}
case 36:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Push(JValue.R(rt.String("+")));f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",52);}
case 52:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",55);}
case 55:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","deltaHand","I",value);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{f.Push(JValue.I(1));f.Pc=62;continue;}
case 62:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",66);}
case 66:{f.Push(JValue.R(rt.String("+")));f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("")));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",74);}
case 74:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",77);}
case 77:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","deltaLife","I",value);f.Pc=80;continue;}
case 80:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M654(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","supportedFunctionalVariants","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M655(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","supportedFunctionalVariants","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M656(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","supportedFunctionalVariants","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?20:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","supportedFunctionalVariants","Ljava/util/Set;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int!=0?25:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",24);}
case 24:{return JStep.Return(f.Pop());}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/ICardFace","getFunctionalVariant","(Ljava/lang/String;)Lforge/card/ICardFace;","invokeinterface",35);}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[2]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/card/ICardFace","getDisplayName","()Ljava/lang/String;","invokeinterface",52);}
case 52:{f.Locals[3]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","splitType","Lforge/card/CardSplitType;"));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/card/CardSplitType","getAggregationMethod","()Lforge/card/CardSplitType$FaceSelectionMethod;","invokevirtual",60);}
case 60:{if(!rt.StaticReady(f,"forge/card/CardSplitType$FaceSelectionMethod","COMBINE","Lforge/card/CardSplitType$FaceSelectionMethod;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType$FaceSelectionMethod","COMBINE","Lforge/card/CardSplitType$FaceSelectionMethod;"));f.Pc=63;continue;}
case 63:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?106:66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;"));f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/card/ICardFace","getFunctionalVariant","(Ljava/lang/String;)Lforge/card/ICardFace;","invokeinterface",76);}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;"));f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",83);}
case 83:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=86;continue;}
case 86:{f.Locals[4]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[4]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/card/ICardFace","getDisplayName","()Ljava/lang/String;","invokeinterface",95);}
case 95:{f.Locals[5]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[5]);f.Pc=100;continue;}
case 100:{return rt.DynamicCall(f,"forge/card/CardRules:656:100:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",105);}
case 105:{return JStep.Return(f.Pop());}
case 106:{f.Push(f.Locals[3]);f.Pc=107;continue;}
case 107:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M657(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",4);}
case 4:{f.StackOp("pop");f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",9);}
case 9:{f.Push(JValue.R(rt.String("\\s*//\\s*")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String(" // ")));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/String","join","(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/String;","invokestatic",23);}
case 23:{f.Locals[1]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;"));f.Pc=28;continue;}
case 28:{f.Pc=f.Pop().Reference==null?48:31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=33;continue;}
case 33:{f.Push(JValue.I(2));f.Pc=34;continue;}
case 34:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?48:37;continue;}
case 37:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=40;continue;}
case 40:{f.StackOp("dup");f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("Tried to assign a single flavor name to a multi-faced card. Use ' // ' as a separator in the flavorName parameter.")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",47);}
case 47:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","supportedFunctionalVariants","Ljava/util/Set;"));f.Pc=52;continue;}
case 52:{f.Pc=f.Pop().Reference!=null?66:55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=59;continue;}
case 59:{f.StackOp("dup");f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",63);}
case 63:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","supportedFunctionalVariants","Ljava/util/Set;",value);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","supportedFunctionalVariants","Ljava/util/Set;"));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",75);}
case 75:{f.Locals[4]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",84);}
case 84:{f.Pc=f.Pop().Int==0?118:87;continue;}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",94);}
case 94:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=97;continue;}
case 97:{f.Locals[5]=f.Pop();f.Pc=99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[5]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/card/CardRules","getDisplayNameForVariant","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",105);}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",109);}
case 109:{f.Pc=f.Pop().Int==0?115:112;continue;}
case 112:{f.Push(f.Locals[5]);f.Pc=114;continue;}
case 114:{return JStep.Return(f.Pop());}
case 115:{f.Pc=77;continue;}
case 118:{f.Push(f.Locals[2]);f.Pc=119;continue;}
case 119:{f.Pc=f.Pop().Reference==null?126:122;continue;}
case 122:{f.Push(f.Locals[2]);f.Pc=123;continue;}
case 123:{f.Pc=135;continue;}
case 126:{f.Push(f.Locals[1]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",130);}
case 130:{return rt.DynamicCall(f,"forge/card/CardRules:657:130:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",135);}
case 135:{f.Locals[4]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[0]);f.Pc=138;continue;}
case 138:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","supportedFunctionalVariants","Ljava/util/Set;"));f.Pc=141;continue;}
case 141:{f.Push(f.Locals[4]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",148);}
case 148:{f.Pc=f.Pop().Int==0?164:151;continue;}
case 151:{f.Push(f.Locals[4]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[1]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",157);}
case 157:{return rt.DynamicCall(f,"forge/card/CardRules:657:157:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;I)Ljava/lang/String;",162);}
case 162:{f.Locals[4]=f.Pop();f.Pc=164;continue;}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=168;continue;}
case 168:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[4]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/card/CardFace","getOrCreateFunctionalVariant","(Ljava/lang/String;)Lforge/card/CardFace;","invokevirtual",176);}
case 176:{f.Locals[5]=f.Pop();f.Pc=178;continue;}
case 178:{f.Push(f.Locals[5]);f.Pc=180;continue;}
case 180:{f.Push(f.Locals[3]);f.Pc=181;continue;}
case 181:{f.Push(JValue.I(0));f.Pc=182;continue;}
case 182:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/card/CardFace","setFlavorName","(Ljava/lang/String;)V","invokevirtual",186);}
case 186:{f.Push(f.Locals[0]);f.Pc=187;continue;}
case 187:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=190;continue;}
case 190:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[5]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/card/CardFace","assignMissingFieldsToVariant","(Lforge/card/CardFace;)V","invokevirtual",198);}
case 198:{f.Push(f.Locals[0]);f.Pc=199;continue;}
case 199:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;"));f.Pc=202;continue;}
case 202:{f.Pc=f.Pop().Reference==null?239:205;continue;}
case 205:{f.Push(f.Locals[0]);f.Pc=206;continue;}
case 206:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;"));f.Pc=209;continue;}
case 209:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[4]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/card/CardFace","getOrCreateFunctionalVariant","(Ljava/lang/String;)Lforge/card/CardFace;","invokevirtual",217);}
case 217:{f.Locals[6]=f.Pop();f.Pc=219;continue;}
case 219:{f.Push(f.Locals[6]);f.Pc=221;continue;}
case 221:{f.Push(f.Locals[3]);f.Pc=222;continue;}
case 222:{f.Push(JValue.I(1));f.Pc=223;continue;}
case 223:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/card/CardFace","setFlavorName","(Ljava/lang/String;)V","invokevirtual",227);}
case 227:{f.Push(f.Locals[0]);f.Pc=228;continue;}
case 228:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;"));f.Pc=231;continue;}
case 231:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=234;continue;}
case 234:{f.Push(f.Locals[6]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/card/CardFace","assignMissingFieldsToVariant","(Lforge/card/CardFace;)V","invokevirtual",239);}
case 239:{f.Push(f.Locals[0]);f.Pc=240;continue;}
case 240:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","supportedFunctionalVariants","Ljava/util/Set;"));f.Pc=243;continue;}
case 243:{f.Push(f.Locals[4]);f.Pc=245;continue;}
case 245:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",250);}
case 250:{f.StackOp("pop");f.Pc=251;continue;}
case 251:{f.Push(f.Locals[4]);f.Pc=253;continue;}
case 253:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M658(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","placeholderFaces","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M659(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","placeholderFaces","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?13:7;continue;}
case 7:{return rt.Call(f,"java/util/Collections","emptyList","()Ljava/util/List;","invokestatic",10);}
case 10:{f.Pc=22;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","placeholderFaces","Ljava/util/Map;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",22);}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M660(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","placeholderFaces","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?8:7;continue;}
case 7:{return JStep.ReturnVoid;}
case 8:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","allFaces","Ljava/util/List;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","placeholderFaces","Ljava/util/Map;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",29);}
case 29:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",34);}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",41);}
case 41:{f.Pc=f.Pop().Int==0?159:44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{f.Locals[4]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",62);}
case 62:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",68);}
case 68:{f.Locals[5]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[4]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",78);}
case 78:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",83);}
case 83:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=86;continue;}
case 86:{f.Locals[6]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[6]);f.Pc=90;continue;}
case 90:{f.Pc=f.Pop().Reference!=null?120:93;continue;}
case 93:{if(!rt.EnsureInitialized(f,"java/util/NoSuchElementException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/NoSuchElementException")));f.Pc=96;continue;}
case 96:{f.StackOp("dup");f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","normalizedName","Ljava/lang/String;"));f.Pc=101;continue;}
case 101:{f.Push(f.Locals[4]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",108);}
case 108:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=111;continue;}
case 111:{return rt.DynamicCall(f,"forge/card/CardRules:660:111:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",116);}
case 116:{return rt.Call(f,"java/util/NoSuchElementException","<init>","(Ljava/lang/String;)V","invokespecial",119);}
case 119:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 120:{f.Push(f.Locals[2]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[5]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[6]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/util/List","add","(ILjava/lang/Object;)V","invokeinterface",130);}
case 130:{f.Push(f.Locals[5]);f.Pc=132;continue;}
case 132:{f.Pc=f.Pop().Int!=0?144:135;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[6]);f.Pc=138;continue;}
case 138:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;",value);f.Pc=141;continue;}
case 141:{f.Pc=156;continue;}
case 144:{f.Push(f.Locals[5]);f.Pc=146;continue;}
case 146:{f.Push(JValue.I(1));f.Pc=147;continue;}
case 147:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?156:150;continue;}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{f.Push(f.Locals[6]);f.Pc=153;continue;}
case 153:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","otherPart","Lforge/card/ICardFace;",value);f.Pc=156;continue;}
case 156:{f.Pc=35;continue;}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[2]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/util/Collections","unmodifiableList","(Ljava/util/List;)Ljava/util/List;","invokestatic",164);}
case 164:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","allFaces","Ljava/util/List;",value);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[0]);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[0]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/card/CardRules","calculateColorIdentity","(Lforge/card/CardRules;)Lforge/card/ColorSet;","invokestatic",172);}
case 172:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","colorIdentity","Lforge/card/ColorSet;",value);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[0]);f.Pc=176;continue;}
case 176:{f.Push(JValue.R(null));f.Pc=177;continue;}
case 177:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","placeholderFaces","Ljava/util/Map;",value);f.Pc=180;continue;}
case 180:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M661(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","colorIdentity","Lforge/card/ColorSet;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M662(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRules$Reader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRules$Reader")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardRules$Reader","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?42:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/card/CardRules$Reader","parseLine","(Ljava/lang/String;)V","invokevirtual",39);}
case 39:{f.Pc=15;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/card/CardRules$Reader","getCard","()Lforge/card/CardRules;","invokevirtual",46);}
case 46:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M663(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardAiHints"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardAiHints")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(1));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/card/CardAiHints","<init>","(ZZZLforge/card/DeckHints;Lforge/card/DeckHints;Lforge/card/DeckHints;)V","invokespecial",13);}
case 13:{f.Locals[1]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(JValue.I(7));f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.NewArray("Lforge/card/CardFace;",f.Pop().Int)));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{if(!rt.EnsureInitialized(f,"forge/card/CardFace"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardFace")));f.Pc=24;continue;}
case 24:{f.StackOp("dup");f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/card/CardFace","<init>","(Ljava/lang/String;)V","invokespecial",29);}
case 29:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{f.Push(JValue.R(null));f.Pc=33;continue;}
case 33:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=34;continue;}
case 34:{f.StackOp("dup");f.Pc=35;continue;}
case 35:{f.Push(JValue.I(2));f.Pc=36;continue;}
case 36:{f.Push(JValue.R(null));f.Pc=37;continue;}
case 37:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=38;continue;}
case 38:{f.StackOp("dup");f.Pc=39;continue;}
case 39:{f.Push(JValue.I(3));f.Pc=40;continue;}
case 40:{f.Push(JValue.R(null));f.Pc=41;continue;}
case 41:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.I(4));f.Pc=44;continue;}
case 44:{f.Push(JValue.R(null));f.Pc=45;continue;}
case 45:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=46;continue;}
case 46:{f.StackOp("dup");f.Pc=47;continue;}
case 47:{f.Push(JValue.I(5));f.Pc=48;continue;}
case 48:{f.Push(JValue.R(null));f.Pc=49;continue;}
case 49:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=50;continue;}
case 50:{f.StackOp("dup");f.Pc=51;continue;}
case 51:{f.Push(JValue.I(6));f.Pc=53;continue;}
case 53:{f.Push(JValue.R(null));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.Locals[2]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{f.Push(JValue.I(0));f.Pc=58;continue;}
case 58:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=59;continue;}
case 59:{f.Push(JValue.I(0));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",63);}
case 63:{return rt.Call(f,"forge/card/CardFace","setColor","(Lforge/card/ColorSet;)V","invokevirtual",66);}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{f.Push(JValue.I(0));f.Pc=68;continue;}
case 68:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("")));f.Pc=71;continue;}
case 71:{f.Push(JValue.I(0));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/card/CardType","parse","(Ljava/lang/String;Z)Lforge/card/CardType;","invokestatic",75);}
case 75:{return rt.Call(f,"forge/card/CardFace","setType","(Lforge/card/CardType;)V","invokevirtual",78);}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{f.Push(JValue.I(0));f.Pc=80;continue;}
case 80:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=81;continue;}
case 81:{f.Push(JValue.R(rt.String("This card is not supported by Forge. Whenever you start a game with this card, it will be bugged.")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/card/CardFace","setOracleText","(Ljava/lang/String;)V","invokevirtual",87);}
case 87:{f.Push(f.Locals[2]);f.Pc=88;continue;}
case 88:{f.Push(JValue.I(0));f.Pc=89;continue;}
case 89:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("This card is not supported by Forge.\nWhenever you start a game with this card, it will be bugged.")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/card/CardFace","setNonAbilityText","(Ljava/lang/String;)V","invokevirtual",96);}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{f.Push(JValue.I(0));f.Pc=98;continue;}
case 98:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/card/CardFace","assignMissingFields","()V","invokevirtual",102);}
case 102:{if(!rt.EnsureInitialized(f,"forge/card/CardRules"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRules")));f.Pc=105;continue;}
case 105:{f.StackOp("dup");f.Pc=106;continue;}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{if(!rt.StaticReady(f,"forge/card/CardSplitType","None","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","None","Lforge/card/CardSplitType;"));f.Pc=110;continue;}
case 110:{f.Push(f.Locals[1]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/card/CardRules","<init>","([Lforge/card/ICardFace;Lforge/card/CardSplitType;Lforge/card/CardAiHints;)V","invokespecial",114);}
case 114:{f.Locals[3]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[3]);f.Pc=116;continue;}
case 116:{f.Push(JValue.I(1));f.Pc=117;continue;}
case 117:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","unsupported","Z",value);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[3]);f.Pc=121;continue;}
case 121:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M664(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/ICardFace","getKeywords","()Ljava/lang/Iterable;","invokeinterface",9);}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/collect/Iterables","contains","(Ljava/lang/Iterable;Ljava/lang/Object;)Z","invokestatic",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M665(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/CardRules","hasStartOfKeyword","(Ljava/lang/String;Lforge/card/ICardFace;)Z","invokevirtual",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M666(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ICardFace","getKeywords","()Ljava/lang/Iterable;","invokeinterface",6);}
case 6:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?46:21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[4]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int==0?43:41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 43:{f.Pc=12;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M667(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/ICardFace","getKeywords","()Ljava/lang/Iterable;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?75:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String(":")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",41);}
case 41:{f.Locals[4]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int==0?72:54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{f.Push(JValue.I(1));f.Pc=57;continue;}
case 57:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=58;continue;}
case 58:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",61);}
case 61:{f.Pc=f.Pop().Int==0?72:64;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{f.Push(JValue.I(1));f.Pc=67;continue;}
case 67:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/Integer","valueOf","(Ljava/lang/String;)Ljava/lang/Integer;","invokestatic",71);}
case 71:{return JStep.Return(f.Pop());}
case 72:{f.Pc=15;continue;}
case 75:{f.Push(JValue.R(null));f.Pc=76;continue;}
case 76:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M668(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","deckbuildingColors","Lforge/card/ColorSet;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?119:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Locals[1]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",18);}
case 18:{return rt.Call(f,"forge/card/CardType","isLand","()Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?80:24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/card/CardRules","getColorIdentity","()Lforge/card/ColorSet;","invokevirtual",28);}
case 28:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",31);}
case 31:{f.Locals[1]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Push(JValue.I(5));f.Pc=36;continue;}
case 36:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?77:39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","mainPart","Lforge/card/ICardFace;"));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/card/ICardFace","getOracleText","()Ljava/lang/String;","invokeinterface",48);}
case 48:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"com/google/common/collect/ImmutableList","get","(I)Ljava/lang/Object;","invokevirtual",55);}
case 55:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/CharSequence"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=58;continue;}
case 58:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","containsIgnoreCase","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z","invokestatic",61);}
case 61:{f.Pc=f.Pop().Int==0?71:64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{f.Push(JValue.I(1));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=68;continue;}
case 68:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=69;continue;}
case 69:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=70;continue;}
case 70:{f.Locals[1]=f.Pop();f.Pc=71;continue;}
case 71:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=74;continue;}
case 74:{f.Pc=34;continue;}
case 77:{f.Pc=111;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/card/CardRules","getColor","()Lforge/card/ColorSet;","invokevirtual",84);}
case 84:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",87);}
case 87:{f.Locals[1]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/card/CardRules","getOtherPart","()Lforge/card/ICardFace;","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Reference==null?111:95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/card/CardRules","getOtherPart","()Lforge/card/ICardFace;","invokevirtual",100);}
case 100:{return rt.Call(f,"forge/card/ICardFace","getManaCost","()Lforge/card/mana/ManaCost;","invokeinterface",105);}
case 105:{return rt.Call(f,"forge/card/mana/ManaCost","getColorProfile","()B","invokevirtual",108);}
case 108:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=109;continue;}
case 109:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=110;continue;}
case 110:{f.Locals[1]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",116);}
case 116:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","deckbuildingColors","Lforge/card/ColorSet;",value);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules","deckbuildingColors","Lforge/card/ColorSet;"));f.Pc=123;continue;}
case 123:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

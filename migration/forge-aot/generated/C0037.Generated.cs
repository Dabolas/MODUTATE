// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C37{
internal static JClass Build(){var c=new JClass("forge/card/CardRules$Reader","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("faces","[Lforge/card/CardFace;",false,JValue.Default("[Lforge/card/CardFace;"),null));
c.Add(new JField("curFace","I",false,JValue.Default("I"),null));
c.Add(new JField("altMode","Lforge/card/CardSplitType;",false,JValue.Default("Lforge/card/CardSplitType;"),null));
c.Add(new JField("meldWith","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("partnerWith","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("partnerType","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("setColorID","I",false,JValue.Default("I"),null));
c.Add(new JField("handLife","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("normalizedName","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("supportedFunctionalVariants","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("placeholderFaces","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("tokens","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("removedFromAIDecks","Z",false,JValue.Default("Z"),null));
c.Add(new JField("removedFromRandomDecks","Z",false,JValue.Default("Z"),null));
c.Add(new JField("removedFromNonCommanderDecks","Z",false,JValue.Default("Z"),null));
c.Add(new JField("hints","Lforge/card/DeckHints;",false,JValue.Default("Lforge/card/DeckHints;"),null));
c.Add(new JField("needs","Lforge/card/DeckHints;",false,JValue.Default("Lforge/card/DeckHints;"),null));
c.Add(new JField("has","Lforge/card/DeckHints;",false,JValue.Default("Lforge/card/DeckHints;"),null));
c.Add(new JField("$assertionsDisabled","Z",true,JValue.Default("Z"),null));
c.Add(new JMethod(670,"forge/card/CardRules$Reader","<init>","()V",1,1,5,new JHandler[]{},M670));
c.Add(new JMethod(671,"forge/card/CardRules$Reader","reset","()V",17,1,3,new JHandler[]{},M671));
c.Add(new JMethod(672,"forge/card/CardRules$Reader","getCard","()Lforge/card/CardRules;",17,3,8,new JHandler[]{},M672));
c.Add(new JMethod(673,"forge/card/CardRules$Reader","readCard","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/card/CardRules;",17,5,4,new JHandler[]{},M673));
c.Add(new JMethod(674,"forge/card/CardRules$Reader","readCard","(Ljava/lang/Iterable;)Lforge/card/CardRules;",17,2,3,new JHandler[]{},M674));
c.Add(new JMethod(675,"forge/card/CardRules$Reader","parseLine","(Ljava/lang/String;)V",17,2,4,new JHandler[]{},M675));
c.Add(new JMethod(676,"forge/card/CardRules$Reader","parseLine","(Ljava/lang/String;Lforge/card/CardFace;)V",2,9,5,new JHandler[]{},M676));
c.Add(new JMethod(677,"forge/card/CardRules$Reader","<clinit>","()V",8,0,1,new JHandler[]{},M677));
}

internal static JStep M670(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(7));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.NewArray("Lforge/card/CardFace;",f.Pop().Int)));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{f.Push(JValue.R(null));f.Pc=13;continue;}
case 13:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{f.Push(JValue.R(null));f.Pc=17;continue;}
case 17:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(JValue.I(2));f.Pc=20;continue;}
case 20:{f.Push(JValue.R(null));f.Pc=21;continue;}
case 21:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(JValue.I(3));f.Pc=24;continue;}
case 24:{f.Push(JValue.R(null));f.Pc=25;continue;}
case 25:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=26;continue;}
case 26:{f.StackOp("dup");f.Pc=27;continue;}
case 27:{f.Push(JValue.I(4));f.Pc=28;continue;}
case 28:{f.Push(JValue.R(null));f.Pc=29;continue;}
case 29:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{f.Push(JValue.I(5));f.Pc=32;continue;}
case 32:{f.Push(JValue.R(null));f.Pc=33;continue;}
case 33:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=34;continue;}
case 34:{f.StackOp("dup");f.Pc=35;continue;}
case 35:{f.Push(JValue.I(6));f.Pc=37;continue;}
case 37:{f.Push(JValue.R(null));f.Pc=38;continue;}
case 38:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=39;continue;}
case 39:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;",value);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(JValue.I(0));f.Pc=44;continue;}
case 44:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","curFace","I",value);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{if(!rt.StaticReady(f,"forge/card/CardSplitType","None","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","None","Lforge/card/CardSplitType;"));f.Pc=51;continue;}
case 51:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","altMode","Lforge/card/CardSplitType;",value);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("")));f.Pc=57;continue;}
case 57:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","meldWith","Ljava/lang/String;",value);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("")));f.Pc=63;continue;}
case 63:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","partnerWith","Ljava/lang/String;",value);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("")));f.Pc=69;continue;}
case 69:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","partnerType","Ljava/lang/String;",value);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{f.Push(JValue.I(0));f.Pc=74;continue;}
case 74:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","setColorID","I",value);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(null));f.Pc=79;continue;}
case 79:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","handLife","Ljava/lang/String;",value);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(JValue.R(rt.String("")));f.Pc=85;continue;}
case 85:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","normalizedName","Ljava/lang/String;",value);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(JValue.R(null));f.Pc=90;continue;}
case 90:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","supportedFunctionalVariants","Ljava/util/Set;",value);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(null));f.Pc=95;continue;}
case 95:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","placeholderFaces","Ljava/util/Map;",value);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",102);}
case 102:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","tokens","Ljava/util/List;",value);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{f.Push(JValue.I(0));f.Pc=107;continue;}
case 107:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","removedFromAIDecks","Z",value);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{f.Push(JValue.I(0));f.Pc=112;continue;}
case 112:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","removedFromRandomDecks","Z",value);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{f.Push(JValue.I(0));f.Pc=117;continue;}
case 117:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","removedFromNonCommanderDecks","Z",value);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(null));f.Pc=122;continue;}
case 122:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","hints","Lforge/card/DeckHints;",value);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[0]);f.Pc=126;continue;}
case 126:{f.Push(JValue.R(null));f.Pc=127;continue;}
case 127:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","needs","Lforge/card/DeckHints;",value);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[0]);f.Pc=131;continue;}
case 131:{f.Push(JValue.R(null));f.Pc=132;continue;}
case 132:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","has","Lforge/card/DeckHints;",value);f.Pc=135;continue;}
case 135:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M671(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","setColorID","I",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","curFace","I",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(null));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Push(JValue.R(null));f.Pc=23;continue;}
case 23:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=28;continue;}
case 28:{f.Push(JValue.I(2));f.Pc=29;continue;}
case 29:{f.Push(JValue.R(null));f.Pc=30;continue;}
case 30:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=35;continue;}
case 35:{f.Push(JValue.I(3));f.Pc=36;continue;}
case 36:{f.Push(JValue.R(null));f.Pc=37;continue;}
case 37:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=42;continue;}
case 42:{f.Push(JValue.I(4));f.Pc=43;continue;}
case 43:{f.Push(JValue.R(null));f.Pc=44;continue;}
case 44:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=49;continue;}
case 49:{f.Push(JValue.I(5));f.Pc=50;continue;}
case 50:{f.Push(JValue.R(null));f.Pc=51;continue;}
case 51:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=56;continue;}
case 56:{f.Push(JValue.I(6));f.Pc=58;continue;}
case 58:{f.Push(JValue.R(null));f.Pc=59;continue;}
case 59:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(null));f.Pc=62;continue;}
case 62:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","handLife","Ljava/lang/String;",value);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{if(!rt.StaticReady(f,"forge/card/CardSplitType","None","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","None","Lforge/card/CardSplitType;"));f.Pc=69;continue;}
case 69:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","altMode","Lforge/card/CardSplitType;",value);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{f.Push(JValue.I(0));f.Pc=74;continue;}
case 74:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","removedFromAIDecks","Z",value);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(JValue.I(0));f.Pc=79;continue;}
case 79:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","removedFromRandomDecks","Z",value);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(JValue.I(0));f.Pc=84;continue;}
case 84:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","removedFromNonCommanderDecks","Z",value);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(null));f.Pc=89;continue;}
case 89:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","needs","Lforge/card/DeckHints;",value);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(null));f.Pc=94;continue;}
case 94:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","hints","Lforge/card/DeckHints;",value);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(JValue.R(null));f.Pc=99;continue;}
case 99:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","has","Lforge/card/DeckHints;",value);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("")));f.Pc=105;continue;}
case 105:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","meldWith","Ljava/lang/String;",value);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("")));f.Pc=111;continue;}
case 111:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","partnerWith","Ljava/lang/String;",value);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.String("")));f.Pc=117;continue;}
case 117:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","partnerType","Ljava/lang/String;",value);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("")));f.Pc=123;continue;}
case 123:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","normalizedName","Ljava/lang/String;",value);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(JValue.R(null));f.Pc=128;continue;}
case 128:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","supportedFunctionalVariants","Ljava/util/Set;",value);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{f.Push(JValue.R(null));f.Pc=133;continue;}
case 133:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","placeholderFaces","Ljava/util/Map;",value);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[0]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",140);}
case 140:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","tokens","Ljava/util/List;",value);f.Pc=143;continue;}
case 143:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M672(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardAiHints"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardAiHints")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","removedFromAIDecks","Z"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","removedFromRandomDecks","Z"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","removedFromNonCommanderDecks","Z"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","hints","Lforge/card/DeckHints;"));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","needs","Lforge/card/DeckHints;"));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","has","Lforge/card/DeckHints;"));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/card/CardAiHints","<init>","(ZZZLforge/card/DeckHints;Lforge/card/DeckHints;Lforge/card/DeckHints;)V","invokespecial",31);}
case 31:{f.Locals[1]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(JValue.R(null));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=39;continue;}
case 39:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?54:42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=46;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/card/CardFace","assignMissingFields","()V","invokevirtual",51);}
case 51:{f.Pc=75;continue;}
case 54:{if(!rt.StaticReady(f,"forge/card/CardRules$Reader","$assertionsDisabled","Z"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRules$Reader","$assertionsDisabled","Z"));f.Pc=57;continue;}
case 57:{f.Pc=f.Pop().Int!=0?75:60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","placeholderFaces","Ljava/util/Map;"));f.Pc=64;continue;}
case 64:{f.Pc=f.Pop().Reference!=null?75:67;continue;}
case 67:{if(!rt.EnsureInitialized(f,"java/lang/AssertionError"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/AssertionError")));f.Pc=70;continue;}
case 70:{f.StackOp("dup");f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/AssertionError","<init>","()V","invokespecial",74);}
case 74:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 75:{f.Push(JValue.R(null));f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=80;continue;}
case 80:{f.Push(JValue.I(1));f.Pc=81;continue;}
case 81:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=82;continue;}
case 82:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?94:85;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=89;continue;}
case 89:{f.Push(JValue.I(1));f.Pc=90;continue;}
case 90:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/card/CardFace","assignMissingFields","()V","invokevirtual",94);}
case 94:{f.Push(JValue.R(null));f.Pc=95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=99;continue;}
case 99:{f.Push(JValue.I(2));f.Pc=100;continue;}
case 100:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=101;continue;}
case 101:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?113:104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=108;continue;}
case 108:{f.Push(JValue.I(2));f.Pc=109;continue;}
case 109:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/card/CardFace","assignMissingFields","()V","invokevirtual",113);}
case 113:{f.Push(JValue.R(null));f.Pc=114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=118;continue;}
case 118:{f.Push(JValue.I(3));f.Pc=119;continue;}
case 119:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=120;continue;}
case 120:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?132:123;continue;}
case 123:{f.Push(f.Locals[0]);f.Pc=124;continue;}
case 124:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=127;continue;}
case 127:{f.Push(JValue.I(3));f.Pc=128;continue;}
case 128:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/card/CardFace","assignMissingFields","()V","invokevirtual",132);}
case 132:{f.Push(JValue.R(null));f.Pc=133;continue;}
case 133:{f.Push(f.Locals[0]);f.Pc=134;continue;}
case 134:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=137;continue;}
case 137:{f.Push(JValue.I(4));f.Pc=138;continue;}
case 138:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=139;continue;}
case 139:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?151:142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=146;continue;}
case 146:{f.Push(JValue.I(4));f.Pc=147;continue;}
case 147:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/card/CardFace","assignMissingFields","()V","invokevirtual",151);}
case 151:{f.Push(JValue.R(null));f.Pc=152;continue;}
case 152:{f.Push(f.Locals[0]);f.Pc=153;continue;}
case 153:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=156;continue;}
case 156:{f.Push(JValue.I(5));f.Pc=157;continue;}
case 157:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=158;continue;}
case 158:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?170:161;continue;}
case 161:{f.Push(f.Locals[0]);f.Pc=162;continue;}
case 162:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=165;continue;}
case 165:{f.Push(JValue.I(5));f.Pc=166;continue;}
case 166:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/card/CardFace","assignMissingFields","()V","invokevirtual",170);}
case 170:{f.Push(JValue.R(null));f.Pc=171;continue;}
case 171:{f.Push(f.Locals[0]);f.Pc=172;continue;}
case 172:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=175;continue;}
case 175:{f.Push(JValue.I(6));f.Pc=177;continue;}
case 177:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=178;continue;}
case 178:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?191:181;continue;}
case 181:{f.Push(f.Locals[0]);f.Pc=182;continue;}
case 182:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=185;continue;}
case 185:{f.Push(JValue.I(6));f.Pc=187;continue;}
case 187:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/card/CardFace","assignMissingFields","()V","invokevirtual",191);}
case 191:{if(!rt.EnsureInitialized(f,"forge/card/CardRules"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRules")));f.Pc=194;continue;}
case 194:{f.StackOp("dup");f.Pc=195;continue;}
case 195:{f.Push(f.Locals[0]);f.Pc=196;continue;}
case 196:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=199;continue;}
case 199:{f.Push(f.Locals[0]);f.Pc=200;continue;}
case 200:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","altMode","Lforge/card/CardSplitType;"));f.Pc=203;continue;}
case 203:{f.Push(f.Locals[1]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/card/CardRules","<init>","([Lforge/card/ICardFace;Lforge/card/CardSplitType;Lforge/card/CardAiHints;)V","invokespecial",207);}
case 207:{f.Locals[2]=f.Pop();f.Pc=208;continue;}
case 208:{f.Push(f.Locals[2]);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[0]);f.Pc=210;continue;}
case 210:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","normalizedName","Ljava/lang/String;"));f.Pc=213;continue;}
case 213:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","normalizedName","Ljava/lang/String;",value);f.Pc=216;continue;}
case 216:{f.Push(f.Locals[2]);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[0]);f.Pc=218;continue;}
case 218:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","meldWith","Ljava/lang/String;"));f.Pc=221;continue;}
case 221:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","meldWith","Ljava/lang/String;",value);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[2]);f.Pc=225;continue;}
case 225:{f.Push(f.Locals[0]);f.Pc=226;continue;}
case 226:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","partnerWith","Ljava/lang/String;"));f.Pc=229;continue;}
case 229:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","partnerWith","Ljava/lang/String;",value);f.Pc=232;continue;}
case 232:{f.Push(f.Locals[2]);f.Pc=233;continue;}
case 233:{f.Push(f.Locals[0]);f.Pc=234;continue;}
case 234:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","partnerType","Ljava/lang/String;"));f.Pc=237;continue;}
case 237:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","partnerType","Ljava/lang/String;",value);f.Pc=240;continue;}
case 240:{f.Push(f.Locals[2]);f.Pc=241;continue;}
case 241:{f.Push(f.Locals[0]);f.Pc=242;continue;}
case 242:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","setColorID","I"));f.Pc=245;continue;}
case 245:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","setColorID","I",value);f.Pc=248;continue;}
case 248:{f.Push(f.Locals[0]);f.Pc=249;continue;}
case 249:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","tokens","Ljava/util/List;"));f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",257);}
case 257:{f.Pc=f.Pop().Int!=0?268:260;continue;}
case 260:{f.Push(f.Locals[2]);f.Pc=261;continue;}
case 261:{f.Push(f.Locals[0]);f.Pc=262;continue;}
case 262:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","tokens","Ljava/util/List;"));f.Pc=265;continue;}
case 265:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","tokens","Ljava/util/List;",value);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[0]);f.Pc=269;continue;}
case 269:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","handLife","Ljava/lang/String;"));f.Pc=272;continue;}
case 272:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNotBlank","(Ljava/lang/CharSequence;)Z","invokestatic",275);}
case 275:{f.Pc=f.Pop().Int==0?286:278;continue;}
case 278:{f.Push(f.Locals[2]);f.Pc=279;continue;}
case 279:{f.Push(f.Locals[0]);f.Pc=280;continue;}
case 280:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","handLife","Ljava/lang/String;"));f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/card/CardRules","setVanguardProperties","(Ljava/lang/String;)V","invokevirtual",286);}
case 286:{f.Push(f.Locals[2]);f.Pc=287;continue;}
case 287:{f.Push(f.Locals[0]);f.Pc=288;continue;}
case 288:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","supportedFunctionalVariants","Ljava/util/Set;"));f.Pc=291;continue;}
case 291:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","supportedFunctionalVariants","Ljava/util/Set;",value);f.Pc=294;continue;}
case 294:{f.Push(f.Locals[2]);f.Pc=295;continue;}
case 295:{f.Push(f.Locals[0]);f.Pc=296;continue;}
case 296:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","placeholderFaces","Ljava/util/Map;"));f.Pc=299;continue;}
case 299:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules","placeholderFaces","Ljava/util/Map;",value);f.Pc=302;continue;}
case 302:{f.Push(f.Locals[2]);f.Pc=303;continue;}
case 303:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M673(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules$Reader","reset","()V","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",10);}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int==0?71:20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",26);}
case 26:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=29;continue;}
case 29:{f.Locals[4]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int!=0?11:39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",45);}
case 45:{f.Push(JValue.I(35));f.Pc=47;continue;}
case 47:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?53:50;continue;}
case 50:{f.Pc=11;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","curFace","I"));f.Pc=64;continue;}
case 64:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/card/CardRules$Reader","parseLine","(Ljava/lang/String;Lforge/card/CardFace;)V","invokevirtual",68);}
case 68:{f.Pc=11;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[2]);f.Pc=73;continue;}
case 73:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","normalizedName","Ljava/lang/String;",value);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/card/CardRules$Reader","getCard","()Lforge/card/CardRules;","invokevirtual",80);}
case 80:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M674(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/CardRules$Reader","readCard","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/card/CardRules;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M675(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","curFace","I"));f.Pc=10;continue;}
case 10:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/CardRules$Reader","parseLine","(Ljava/lang/String;Lforge/card/CardFace;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M676(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(58));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int<=0?20:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",17);}
case 17:{f.Pc=21;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Int<=0?40:27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",34);}
case 34:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",37);}
case 37:{f.Pc=41;continue;}
case 40:{f.Push(JValue.R(null));f.Pc=41;continue;}
case 41:{f.Locals[5]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[5]);f.Pc=45;continue;}
case 45:{f.Pc=f.Pop().Reference==null?124:48;continue;}
case 48:{f.Push(f.Locals[5]);f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("TokenScript$")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",55);}
case 55:{f.Locals[6]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{f.Pc=f.Pop().Int<=0?124:62;continue;}
case 62:{f.Push(f.Locals[5]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[6]);f.Pc=66;continue;}
case 66:{f.Push(JValue.I(12));f.Pc=68;continue;}
case 68:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",72);}
case 72:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",75);}
case 75:{f.Locals[7]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[7]);f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("|")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",84);}
case 84:{f.Locals[8]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[8]);f.Pc=88;continue;}
case 88:{f.Pc=f.Pop().Int<=0?104:91;continue;}
case 91:{f.Push(f.Locals[7]);f.Pc=93;continue;}
case 93:{f.Push(JValue.I(0));f.Pc=94;continue;}
case 94:{f.Push(f.Locals[8]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",99);}
case 99:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",102);}
case 102:{f.Locals[7]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","tokens","Ljava/util/List;"));f.Pc=108;continue;}
case 108:{f.Push(f.Locals[7]);f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String(",")));f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",115);}
case 115:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",118);}
case 118:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",123);}
case 123:{f.StackOp("pop");f.Pc=124;continue;}
case 124:{f.Push(f.Locals[4]);f.Pc=126;continue;}
case 126:{f.Push(JValue.I(0));f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",130);}
case 130:{switch(f.Pop().Int){case 65:f.Pc=232;break;case 66:f.Pc=1408;break;case 67:f.Pc=406;break;case 68:f.Pc=514;break;case 69:f.Pc=1408;break;case 70:f.Pc=655;break;case 71:f.Pc=1408;break;case 72:f.Pc=672;break;case 73:f.Pc=1408;break;case 74:f.Pc=1408;break;case 75:f.Pc=692;break;case 76:f.Pc=762;break;case 77:f.Pc=799;break;case 78:f.Pc=863;break;case 79:f.Pc=935;break;case 80:f.Pc=955;break;case 81:f.Pc=1408;break;case 82:f.Pc=975;break;case 83:f.Pc=995;break;case 84:f.Pc=1228;break;case 85:f.Pc=1408;break;case 86:f.Pc=1300;break;default:f.Pc=1408;break;}continue;}
case 232:{f.Push(JValue.R(rt.String("A")));f.Pc=234;continue;}
case 234:{f.Push(f.Locals[4]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",239);}
case 239:{f.Pc=f.Pop().Int==0?251:242;continue;}
case 242:{f.Push(f.Locals[2]);f.Pc=243;continue;}
case 243:{f.Push(f.Locals[5]);f.Pc=245;continue;}
case 245:{return rt.Call(f,"forge/card/CardFace","addAbility","(Ljava/lang/String;)V","invokevirtual",248);}
case 248:{f.Pc=1408;continue;}
case 251:{f.Push(JValue.R(rt.String("AI")));f.Pc=253;continue;}
case 253:{f.Push(f.Locals[4]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",258);}
case 258:{f.Pc=f.Pop().Int==0?366:261;continue;}
case 261:{f.Push(f.Locals[5]);f.Pc=263;continue;}
case 263:{f.Push(JValue.I(58));f.Pc=265;continue;}
case 265:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",268);}
case 268:{f.Locals[3]=f.Pop();f.Pc=269;continue;}
case 269:{f.Push(f.Locals[3]);f.Pc=270;continue;}
case 270:{f.Pc=f.Pop().Int<=0?283:273;continue;}
case 273:{f.Push(f.Locals[5]);f.Pc=275;continue;}
case 275:{f.Push(JValue.I(0));f.Pc=276;continue;}
case 276:{f.Push(f.Locals[3]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",280);}
case 280:{f.Pc=285;continue;}
case 283:{f.Push(f.Locals[5]);f.Pc=285;continue;}
case 285:{f.Locals[6]=f.Pop();f.Pc=287;continue;}
case 287:{f.Push(f.Locals[3]);f.Pc=288;continue;}
case 288:{f.Pc=f.Pop().Int<=0?302:291;continue;}
case 291:{f.Push(f.Locals[5]);f.Pc=293;continue;}
case 293:{f.Push(JValue.I(1));f.Pc=294;continue;}
case 294:{f.Push(f.Locals[3]);f.Pc=295;continue;}
case 295:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=296;continue;}
case 296:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",299);}
case 299:{f.Pc=303;continue;}
case 302:{f.Push(JValue.R(null));f.Pc=303;continue;}
case 303:{f.Locals[5]=f.Pop();f.Pc=305;continue;}
case 305:{f.Push(JValue.R(rt.String("RemoveDeck")));f.Pc=307;continue;}
case 307:{f.Push(f.Locals[6]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",312);}
case 312:{f.Pc=f.Pop().Int==0?363:315;continue;}
case 315:{f.Push(f.Locals[0]);f.Pc=316;continue;}
case 316:{f.StackOp("dup");f.Pc=317;continue;}
case 317:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","removedFromAIDecks","Z"));f.Pc=320;continue;}
case 320:{f.Push(JValue.R(rt.String("All")));f.Pc=322;continue;}
case 322:{f.Push(f.Locals[5]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",327);}
case 327:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=328;continue;}
case 328:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","removedFromAIDecks","Z",value);f.Pc=331;continue;}
case 331:{f.Push(f.Locals[0]);f.Pc=332;continue;}
case 332:{f.StackOp("dup");f.Pc=333;continue;}
case 333:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","removedFromRandomDecks","Z"));f.Pc=336;continue;}
case 336:{f.Push(JValue.R(rt.String("Random")));f.Pc=338;continue;}
case 338:{f.Push(f.Locals[5]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",343);}
case 343:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=344;continue;}
case 344:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","removedFromRandomDecks","Z",value);f.Pc=347;continue;}
case 347:{f.Push(f.Locals[0]);f.Pc=348;continue;}
case 348:{f.StackOp("dup");f.Pc=349;continue;}
case 349:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","removedFromNonCommanderDecks","Z"));f.Pc=352;continue;}
case 352:{f.Push(JValue.R(rt.String("NonCommander")));f.Pc=354;continue;}
case 354:{f.Push(f.Locals[5]);f.Pc=356;continue;}
case 356:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",359);}
case 359:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=360;continue;}
case 360:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","removedFromNonCommanderDecks","Z",value);f.Pc=363;continue;}
case 363:{f.Pc=1408;continue;}
case 366:{f.Push(JValue.R(rt.String("AlternateMode")));f.Pc=368;continue;}
case 368:{f.Push(f.Locals[4]);f.Pc=370;continue;}
case 370:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",373);}
case 373:{f.Pc=f.Pop().Int==0?388:376;continue;}
case 376:{f.Push(f.Locals[0]);f.Pc=377;continue;}
case 377:{f.Push(f.Locals[5]);f.Pc=379;continue;}
case 379:{return rt.Call(f,"forge/card/CardSplitType","smartValueOf","(Ljava/lang/String;)Lforge/card/CardSplitType;","invokestatic",382);}
case 382:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","altMode","Lforge/card/CardSplitType;",value);f.Pc=385;continue;}
case 385:{f.Pc=1408;continue;}
case 388:{f.Push(JValue.R(rt.String("ALTERNATE")));f.Pc=390;continue;}
case 390:{f.Push(f.Locals[4]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",395);}
case 395:{f.Pc=f.Pop().Int==0?1408:398;continue;}
case 398:{f.Push(f.Locals[0]);f.Pc=399;continue;}
case 399:{f.Push(JValue.I(1));f.Pc=400;continue;}
case 400:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","curFace","I",value);f.Pc=403;continue;}
case 403:{f.Pc=1408;continue;}
case 406:{f.Push(JValue.R(rt.String("Colors")));f.Pc=408;continue;}
case 408:{f.Push(f.Locals[4]);f.Pc=410;continue;}
case 410:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",413);}
case 413:{f.Pc=f.Pop().Int==0?437:416;continue;}
case 416:{f.Push(f.Locals[5]);f.Pc=418;continue;}
case 418:{f.Push(JValue.R(rt.String(",")));f.Pc=420;continue;}
case 420:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",423);}
case 423:{return rt.Call(f,"forge/card/ColorSet","fromNames","([Ljava/lang/String;)Lforge/card/ColorSet;","invokestatic",426);}
case 426:{f.Locals[6]=f.Pop();f.Pc=428;continue;}
case 428:{f.Push(f.Locals[2]);f.Pc=429;continue;}
case 429:{f.Push(f.Locals[6]);f.Pc=431;continue;}
case 431:{return rt.Call(f,"forge/card/CardFace","setColor","(Lforge/card/ColorSet;)V","invokevirtual",434);}
case 434:{f.Pc=1408;continue;}
case 437:{f.Push(JValue.R(rt.String("CopyFaceFrom")));f.Pc=439;continue;}
case 439:{f.Push(f.Locals[4]);f.Pc=441;continue;}
case 441:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",444);}
case 444:{f.Pc=f.Pop().Int==0?1408:447;continue;}
case 447:{f.Push(f.Locals[0]);f.Pc=448;continue;}
case 448:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","placeholderFaces","Ljava/util/Map;"));f.Pc=451;continue;}
case 451:{f.Pc=f.Pop().Reference!=null?466:454;continue;}
case 454:{f.Push(f.Locals[0]);f.Pc=455;continue;}
case 455:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=458;continue;}
case 458:{f.StackOp("dup");f.Pc=459;continue;}
case 459:{f.Push(JValue.I(2));f.Pc=460;continue;}
case 460:{return rt.Call(f,"java/util/HashMap","<init>","(I)V","invokespecial",463);}
case 463:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","placeholderFaces","Ljava/util/Map;",value);f.Pc=466;continue;}
case 466:{if(!rt.StaticReady(f,"forge/card/CardRules$Reader","$assertionsDisabled","Z"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRules$Reader","$assertionsDisabled","Z"));f.Pc=469;continue;}
case 469:{f.Pc=f.Pop().Int!=0?492:472;continue;}
case 472:{f.Push(f.Locals[0]);f.Pc=473;continue;}
case 473:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=476;continue;}
case 476:{f.Push(f.Locals[0]);f.Pc=477;continue;}
case 477:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","curFace","I"));f.Pc=480;continue;}
case 480:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=481;continue;}
case 481:{f.Pc=f.Pop().Reference==null?492:484;continue;}
case 484:{if(!rt.EnsureInitialized(f,"java/lang/AssertionError"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/AssertionError")));f.Pc=487;continue;}
case 487:{f.StackOp("dup");f.Pc=488;continue;}
case 488:{return rt.Call(f,"java/lang/AssertionError","<init>","()V","invokespecial",491);}
case 491:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 492:{f.Push(f.Locals[0]);f.Pc=493;continue;}
case 493:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","placeholderFaces","Ljava/util/Map;"));f.Pc=496;continue;}
case 496:{f.Push(f.Locals[0]);f.Pc=497;continue;}
case 497:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","curFace","I"));f.Pc=500;continue;}
case 500:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",503);}
case 503:{f.Push(f.Locals[5]);f.Pc=505;continue;}
case 505:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",510);}
case 510:{f.StackOp("pop");f.Pc=511;continue;}
case 511:{f.Pc=1408;continue;}
case 514:{f.Push(JValue.R(rt.String("DeckHints")));f.Pc=517;continue;}
case 517:{f.Push(f.Locals[4]);f.Pc=519;continue;}
case 519:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",522);}
case 522:{f.Pc=f.Pop().Int==0?541:525;continue;}
case 525:{f.Push(f.Locals[0]);f.Pc=526;continue;}
case 526:{if(!rt.EnsureInitialized(f,"forge/card/DeckHints"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/DeckHints")));f.Pc=529;continue;}
case 529:{f.StackOp("dup");f.Pc=530;continue;}
case 530:{f.Push(f.Locals[5]);f.Pc=532;continue;}
case 532:{return rt.Call(f,"forge/card/DeckHints","<init>","(Ljava/lang/String;)V","invokespecial",535);}
case 535:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","hints","Lforge/card/DeckHints;",value);f.Pc=538;continue;}
case 538:{f.Pc=1408;continue;}
case 541:{f.Push(JValue.R(rt.String("DeckNeeds")));f.Pc=544;continue;}
case 544:{f.Push(f.Locals[4]);f.Pc=546;continue;}
case 546:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",549);}
case 549:{f.Pc=f.Pop().Int==0?568:552;continue;}
case 552:{f.Push(f.Locals[0]);f.Pc=553;continue;}
case 553:{if(!rt.EnsureInitialized(f,"forge/card/DeckHints"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/DeckHints")));f.Pc=556;continue;}
case 556:{f.StackOp("dup");f.Pc=557;continue;}
case 557:{f.Push(f.Locals[5]);f.Pc=559;continue;}
case 559:{return rt.Call(f,"forge/card/DeckHints","<init>","(Ljava/lang/String;)V","invokespecial",562);}
case 562:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","needs","Lforge/card/DeckHints;",value);f.Pc=565;continue;}
case 565:{f.Pc=1408;continue;}
case 568:{f.Push(JValue.R(rt.String("DeckHas")));f.Pc=571;continue;}
case 571:{f.Push(f.Locals[4]);f.Pc=573;continue;}
case 573:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",576);}
case 576:{f.Pc=f.Pop().Int==0?595:579;continue;}
case 579:{f.Push(f.Locals[0]);f.Pc=580;continue;}
case 580:{if(!rt.EnsureInitialized(f,"forge/card/DeckHints"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/DeckHints")));f.Pc=583;continue;}
case 583:{f.StackOp("dup");f.Pc=584;continue;}
case 584:{f.Push(f.Locals[5]);f.Pc=586;continue;}
case 586:{return rt.Call(f,"forge/card/DeckHints","<init>","(Ljava/lang/String;)V","invokespecial",589);}
case 589:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","has","Lforge/card/DeckHints;",value);f.Pc=592;continue;}
case 592:{f.Pc=1408;continue;}
case 595:{f.Push(JValue.R(rt.String("DeckRule")));f.Pc=598;continue;}
case 598:{f.Push(f.Locals[4]);f.Pc=600;continue;}
case 600:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",603);}
case 603:{f.Pc=f.Pop().Int==0?615:606;continue;}
case 606:{f.Push(f.Locals[2]);f.Pc=607;continue;}
case 607:{f.Push(f.Locals[5]);f.Pc=609;continue;}
case 609:{return rt.Call(f,"forge/card/CardFace","addDeckRule","(Ljava/lang/String;)V","invokevirtual",612);}
case 612:{f.Pc=1408;continue;}
case 615:{f.Push(JValue.R(rt.String("Defense")));f.Pc=618;continue;}
case 618:{f.Push(f.Locals[4]);f.Pc=620;continue;}
case 620:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",623);}
case 623:{f.Pc=f.Pop().Int==0?635:626;continue;}
case 626:{f.Push(f.Locals[2]);f.Pc=627;continue;}
case 627:{f.Push(f.Locals[5]);f.Pc=629;continue;}
case 629:{return rt.Call(f,"forge/card/CardFace","setDefense","(Ljava/lang/String;)V","invokevirtual",632);}
case 632:{f.Pc=1408;continue;}
case 635:{f.Push(JValue.R(rt.String("Draft")));f.Pc=638;continue;}
case 638:{f.Push(f.Locals[4]);f.Pc=640;continue;}
case 640:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",643);}
case 643:{f.Pc=f.Pop().Int==0?1408:646;continue;}
case 646:{f.Push(f.Locals[2]);f.Pc=647;continue;}
case 647:{f.Push(f.Locals[5]);f.Pc=649;continue;}
case 649:{return rt.Call(f,"forge/card/CardFace","addDraftAction","(Ljava/lang/String;)V","invokevirtual",652);}
case 652:{f.Pc=1408;continue;}
case 655:{f.Push(JValue.R(rt.String("FlavorName")));f.Pc=658;continue;}
case 658:{f.Push(f.Locals[4]);f.Pc=660;continue;}
case 660:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",663);}
case 663:{f.Pc=f.Pop().Int==0?672:666;continue;}
case 666:{f.Push(f.Locals[2]);f.Pc=667;continue;}
case 667:{f.Push(f.Locals[5]);f.Pc=669;continue;}
case 669:{return rt.Call(f,"forge/card/CardFace","setFlavorName","(Ljava/lang/String;)V","invokevirtual",672);}
case 672:{f.Push(JValue.R(rt.String("HandLifeModifier")));f.Pc=675;continue;}
case 675:{f.Push(f.Locals[4]);f.Pc=677;continue;}
case 677:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",680);}
case 680:{f.Pc=f.Pop().Int==0?1408:683;continue;}
case 683:{f.Push(f.Locals[0]);f.Pc=684;continue;}
case 684:{f.Push(f.Locals[5]);f.Pc=686;continue;}
case 686:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","handLife","Ljava/lang/String;",value);f.Pc=689;continue;}
case 689:{f.Pc=1408;continue;}
case 692:{f.Push(JValue.R(rt.String("K")));f.Pc=695;continue;}
case 695:{f.Push(f.Locals[4]);f.Pc=697;continue;}
case 697:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",700);}
case 700:{f.Pc=f.Pop().Int==0?1408:703;continue;}
case 703:{f.Push(f.Locals[2]);f.Pc=704;continue;}
case 704:{f.Push(f.Locals[5]);f.Pc=706;continue;}
case 706:{return rt.Call(f,"forge/card/CardFace","addKeyword","(Ljava/lang/String;)V","invokevirtual",709);}
case 709:{f.Push(f.Locals[5]);f.Pc=711;continue;}
case 711:{f.Push(JValue.R(rt.String("Partner with:")));f.Pc=714;continue;}
case 714:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",717);}
case 717:{f.Pc=f.Pop().Int==0?734:720;continue;}
case 720:{f.Push(f.Locals[0]);f.Pc=721;continue;}
case 721:{f.Push(f.Locals[5]);f.Pc=723;continue;}
case 723:{f.Push(JValue.R(rt.String(":")));f.Pc=726;continue;}
case 726:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",729);}
case 729:{f.Push(JValue.I(1));f.Pc=730;continue;}
case 730:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=731;continue;}
case 731:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","partnerWith","Ljava/lang/String;",value);f.Pc=734;continue;}
case 734:{f.Push(f.Locals[5]);f.Pc=736;continue;}
case 736:{f.Push(JValue.R(rt.String("Partner:")));f.Pc=739;continue;}
case 739:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",742);}
case 742:{f.Pc=f.Pop().Int==0?1408:745;continue;}
case 745:{f.Push(f.Locals[0]);f.Pc=746;continue;}
case 746:{f.Push(f.Locals[5]);f.Pc=748;continue;}
case 748:{f.Push(JValue.R(rt.String(":")));f.Pc=751;continue;}
case 751:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",754);}
case 754:{f.Push(JValue.I(1));f.Pc=755;continue;}
case 755:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=756;continue;}
case 756:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","partnerType","Ljava/lang/String;",value);f.Pc=759;continue;}
case 759:{f.Pc=1408;continue;}
case 762:{f.Push(JValue.R(rt.String("Loyalty")));f.Pc=765;continue;}
case 765:{f.Push(f.Locals[4]);f.Pc=767;continue;}
case 767:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",770);}
case 770:{f.Pc=f.Pop().Int==0?779:773;continue;}
case 773:{f.Push(f.Locals[2]);f.Pc=774;continue;}
case 774:{f.Push(f.Locals[5]);f.Pc=776;continue;}
case 776:{return rt.Call(f,"forge/card/CardFace","setInitialLoyalty","(Ljava/lang/String;)V","invokevirtual",779);}
case 779:{f.Push(JValue.R(rt.String("Lights")));f.Pc=782;continue;}
case 782:{f.Push(f.Locals[4]);f.Pc=784;continue;}
case 784:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",787);}
case 787:{f.Pc=f.Pop().Int==0?1408:790;continue;}
case 790:{f.Push(f.Locals[2]);f.Pc=791;continue;}
case 791:{f.Push(f.Locals[5]);f.Pc=793;continue;}
case 793:{return rt.Call(f,"forge/card/CardFace","setAttractionLights","(Ljava/lang/String;)V","invokevirtual",796);}
case 796:{f.Pc=1408;continue;}
case 799:{f.Push(JValue.R(rt.String("ManaCost")));f.Pc=802;continue;}
case 802:{f.Push(f.Locals[4]);f.Pc=804;continue;}
case 804:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",807);}
case 807:{f.Pc=f.Pop().Int==0?843:810;continue;}
case 810:{f.Push(f.Locals[2]);f.Pc=811;continue;}
case 811:{f.Push(JValue.R(rt.String("no cost")));f.Pc=814;continue;}
case 814:{f.Push(f.Locals[5]);f.Pc=816;continue;}
case 816:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",819);}
case 819:{f.Pc=f.Pop().Int==0?828:822;continue;}
case 822:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","NO_COST","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","NO_COST","Lforge/card/mana/ManaCost;"));f.Pc=825;continue;}
case 825:{f.Pc=837;continue;}
case 828:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=831;continue;}
case 831:{f.StackOp("dup");f.Pc=832;continue;}
case 832:{f.Push(f.Locals[5]);f.Pc=834;continue;}
case 834:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(Ljava/lang/String;)V","invokespecial",837);}
case 837:{return rt.Call(f,"forge/card/CardFace","setManaCost","(Lforge/card/mana/ManaCost;)V","invokevirtual",840);}
case 840:{f.Pc=1408;continue;}
case 843:{f.Push(JValue.R(rt.String("MeldPair")));f.Pc=846;continue;}
case 846:{f.Push(f.Locals[4]);f.Pc=848;continue;}
case 848:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",851);}
case 851:{f.Pc=f.Pop().Int==0?1408:854;continue;}
case 854:{f.Push(f.Locals[0]);f.Pc=855;continue;}
case 855:{f.Push(f.Locals[5]);f.Pc=857;continue;}
case 857:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","meldWith","Ljava/lang/String;",value);f.Pc=860;continue;}
case 860:{f.Pc=1408;continue;}
case 863:{f.Push(JValue.R(rt.String("Name")));f.Pc=866;continue;}
case 866:{f.Push(f.Locals[4]);f.Pc=868;continue;}
case 868:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",871);}
case 871:{f.Pc=f.Pop().Int==0?1408:874;continue;}
case 874:{if(!rt.StaticReady(f,"forge/card/CardRules$Reader","$assertionsDisabled","Z"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRules$Reader","$assertionsDisabled","Z"));f.Pc=877;continue;}
case 877:{f.Pc=f.Pop().Int!=0?914:880;continue;}
case 880:{f.Push(f.Locals[0]);f.Pc=881;continue;}
case 881:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","placeholderFaces","Ljava/util/Map;"));f.Pc=884;continue;}
case 884:{f.Pc=f.Pop().Reference==null?914:887;continue;}
case 887:{f.Push(f.Locals[0]);f.Pc=888;continue;}
case 888:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","placeholderFaces","Ljava/util/Map;"));f.Pc=891;continue;}
case 891:{f.Push(f.Locals[0]);f.Pc=892;continue;}
case 892:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","curFace","I"));f.Pc=895;continue;}
case 895:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",898);}
case 898:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",903);}
case 903:{f.Pc=f.Pop().Int==0?914:906;continue;}
case 906:{if(!rt.EnsureInitialized(f,"java/lang/AssertionError"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/AssertionError")));f.Pc=909;continue;}
case 909:{f.StackOp("dup");f.Pc=910;continue;}
case 910:{return rt.Call(f,"java/lang/AssertionError","<init>","()V","invokespecial",913);}
case 913:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 914:{f.Push(f.Locals[0]);f.Pc=915;continue;}
case 915:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","faces","[Lforge/card/CardFace;"));f.Pc=918;continue;}
case 918:{f.Push(f.Locals[0]);f.Pc=919;continue;}
case 919:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","curFace","I"));f.Pc=922;continue;}
case 922:{if(!rt.EnsureInitialized(f,"forge/card/CardFace"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardFace")));f.Pc=925;continue;}
case 925:{f.StackOp("dup");f.Pc=926;continue;}
case 926:{f.Push(f.Locals[5]);f.Pc=928;continue;}
case 928:{return rt.Call(f,"forge/card/CardFace","<init>","(Ljava/lang/String;)V","invokespecial",931);}
case 931:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=932;continue;}
case 932:{f.Pc=1408;continue;}
case 935:{f.Push(JValue.R(rt.String("Oracle")));f.Pc=938;continue;}
case 938:{f.Push(f.Locals[4]);f.Pc=940;continue;}
case 940:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",943);}
case 943:{f.Pc=f.Pop().Int==0?1408:946;continue;}
case 946:{f.Push(f.Locals[2]);f.Pc=947;continue;}
case 947:{f.Push(f.Locals[5]);f.Pc=949;continue;}
case 949:{return rt.Call(f,"forge/card/CardFace","setOracleText","(Ljava/lang/String;)V","invokevirtual",952);}
case 952:{f.Pc=1408;continue;}
case 955:{f.Push(JValue.R(rt.String("PT")));f.Pc=958;continue;}
case 958:{f.Push(f.Locals[4]);f.Pc=960;continue;}
case 960:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",963);}
case 963:{f.Pc=f.Pop().Int==0?1408:966;continue;}
case 966:{f.Push(f.Locals[2]);f.Pc=967;continue;}
case 967:{f.Push(f.Locals[5]);f.Pc=969;continue;}
case 969:{return rt.Call(f,"forge/card/CardFace","setPtText","(Ljava/lang/String;)V","invokevirtual",972);}
case 972:{f.Pc=1408;continue;}
case 975:{f.Push(JValue.R(rt.String("R")));f.Pc=978;continue;}
case 978:{f.Push(f.Locals[4]);f.Pc=980;continue;}
case 980:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",983);}
case 983:{f.Pc=f.Pop().Int==0?1408:986;continue;}
case 986:{f.Push(f.Locals[2]);f.Pc=987;continue;}
case 987:{f.Push(f.Locals[5]);f.Pc=989;continue;}
case 989:{return rt.Call(f,"forge/card/CardFace","addReplacementEffect","(Ljava/lang/String;)V","invokevirtual",992);}
case 992:{f.Pc=1408;continue;}
case 995:{f.Push(JValue.R(rt.String("S")));f.Pc=998;continue;}
case 998:{f.Push(f.Locals[4]);f.Pc=1000;continue;}
case 1000:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1003);}
case 1003:{f.Pc=f.Pop().Int==0?1015:1006;continue;}
case 1006:{f.Push(f.Locals[2]);f.Pc=1007;continue;}
case 1007:{f.Push(f.Locals[5]);f.Pc=1009;continue;}
case 1009:{return rt.Call(f,"forge/card/CardFace","addStaticAbility","(Ljava/lang/String;)V","invokevirtual",1012);}
case 1012:{f.Pc=1408;continue;}
case 1015:{f.Push(f.Locals[4]);f.Pc=1017;continue;}
case 1017:{f.Push(JValue.R(rt.String("SPECIALIZE")));f.Pc=1020;continue;}
case 1020:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1023);}
case 1023:{f.Pc=f.Pop().Int==0?1122:1026;continue;}
case 1026:{f.Push(f.Locals[5]);f.Pc=1028;continue;}
case 1028:{f.Push(JValue.R(rt.String("WHITE")));f.Pc=1031;continue;}
case 1031:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1034);}
case 1034:{f.Pc=f.Pop().Int==0?1045:1037;continue;}
case 1037:{f.Push(f.Locals[0]);f.Pc=1038;continue;}
case 1038:{f.Push(JValue.I(2));f.Pc=1039;continue;}
case 1039:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","curFace","I",value);f.Pc=1042;continue;}
case 1042:{f.Pc=1408;continue;}
case 1045:{f.Push(f.Locals[5]);f.Pc=1047;continue;}
case 1047:{f.Push(JValue.R(rt.String("BLUE")));f.Pc=1050;continue;}
case 1050:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1053);}
case 1053:{f.Pc=f.Pop().Int==0?1064:1056;continue;}
case 1056:{f.Push(f.Locals[0]);f.Pc=1057;continue;}
case 1057:{f.Push(JValue.I(3));f.Pc=1058;continue;}
case 1058:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","curFace","I",value);f.Pc=1061;continue;}
case 1061:{f.Pc=1408;continue;}
case 1064:{f.Push(f.Locals[5]);f.Pc=1066;continue;}
case 1066:{f.Push(JValue.R(rt.String("BLACK")));f.Pc=1069;continue;}
case 1069:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1072);}
case 1072:{f.Pc=f.Pop().Int==0?1083:1075;continue;}
case 1075:{f.Push(f.Locals[0]);f.Pc=1076;continue;}
case 1076:{f.Push(JValue.I(4));f.Pc=1077;continue;}
case 1077:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","curFace","I",value);f.Pc=1080;continue;}
case 1080:{f.Pc=1408;continue;}
case 1083:{f.Push(f.Locals[5]);f.Pc=1085;continue;}
case 1085:{f.Push(JValue.R(rt.String("RED")));f.Pc=1088;continue;}
case 1088:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1091);}
case 1091:{f.Pc=f.Pop().Int==0?1102:1094;continue;}
case 1094:{f.Push(f.Locals[0]);f.Pc=1095;continue;}
case 1095:{f.Push(JValue.I(5));f.Pc=1096;continue;}
case 1096:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","curFace","I",value);f.Pc=1099;continue;}
case 1099:{f.Pc=1408;continue;}
case 1102:{f.Push(f.Locals[5]);f.Pc=1104;continue;}
case 1104:{f.Push(JValue.R(rt.String("GREEN")));f.Pc=1107;continue;}
case 1107:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1110);}
case 1110:{f.Pc=f.Pop().Int==0?1408:1113;continue;}
case 1113:{f.Push(f.Locals[0]);f.Pc=1114;continue;}
case 1114:{f.Push(JValue.I(6));f.Pc=1116;continue;}
case 1116:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","curFace","I",value);f.Pc=1119;continue;}
case 1119:{f.Pc=1408;continue;}
case 1122:{f.Push(JValue.R(rt.String("SVar")));f.Pc=1125;continue;}
case 1125:{f.Push(f.Locals[4]);f.Pc=1127;continue;}
case 1127:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1130);}
case 1130:{f.Pc=f.Pop().Int==0?1205:1133;continue;}
case 1133:{f.Push(JValue.R(null));f.Pc=1134;continue;}
case 1134:{f.Push(f.Locals[5]);f.Pc=1136;continue;}
case 1136:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?1150:1139;continue;}
case 1139:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=1142;continue;}
case 1142:{f.StackOp("dup");f.Pc=1143;continue;}
case 1143:{f.Push(JValue.R(rt.String("SVar has no variable name")));f.Pc=1146;continue;}
case 1146:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",1149);}
case 1149:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 1150:{f.Push(f.Locals[5]);f.Pc=1152;continue;}
case 1152:{f.Push(JValue.I(58));f.Pc=1154;continue;}
case 1154:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",1157);}
case 1157:{f.Locals[3]=f.Pop();f.Pc=1158;continue;}
case 1158:{f.Push(f.Locals[3]);f.Pc=1159;continue;}
case 1159:{f.Pc=f.Pop().Int<=0?1172:1162;continue;}
case 1162:{f.Push(f.Locals[5]);f.Pc=1164;continue;}
case 1164:{f.Push(JValue.I(0));f.Pc=1165;continue;}
case 1165:{f.Push(f.Locals[3]);f.Pc=1166;continue;}
case 1166:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",1169);}
case 1169:{f.Pc=1174;continue;}
case 1172:{f.Push(f.Locals[5]);f.Pc=1174;continue;}
case 1174:{f.Locals[6]=f.Pop();f.Pc=1176;continue;}
case 1176:{f.Push(f.Locals[3]);f.Pc=1177;continue;}
case 1177:{f.Pc=f.Pop().Int<=0?1191:1180;continue;}
case 1180:{f.Push(f.Locals[5]);f.Pc=1182;continue;}
case 1182:{f.Push(JValue.I(1));f.Pc=1183;continue;}
case 1183:{f.Push(f.Locals[3]);f.Pc=1184;continue;}
case 1184:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1185;continue;}
case 1185:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1188);}
case 1188:{f.Pc=1192;continue;}
case 1191:{f.Push(JValue.R(null));f.Pc=1192;continue;}
case 1192:{f.Locals[5]=f.Pop();f.Pc=1194;continue;}
case 1194:{f.Push(f.Locals[2]);f.Pc=1195;continue;}
case 1195:{f.Push(f.Locals[6]);f.Pc=1197;continue;}
case 1197:{f.Push(f.Locals[5]);f.Pc=1199;continue;}
case 1199:{return rt.Call(f,"forge/card/CardFace","addSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",1202);}
case 1202:{f.Pc=1408;continue;}
case 1205:{f.Push(f.Locals[4]);f.Pc=1207;continue;}
case 1207:{f.Push(JValue.R(rt.String("SETCOLORID")));f.Pc=1210;continue;}
case 1210:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1213);}
case 1213:{f.Pc=f.Pop().Int==0?1408:1216;continue;}
case 1216:{f.Push(f.Locals[0]);f.Pc=1217;continue;}
case 1217:{f.Push(f.Locals[5]);f.Pc=1219;continue;}
case 1219:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",1222);}
case 1222:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","setColorID","I",value);f.Pc=1225;continue;}
case 1225:{f.Pc=1408;continue;}
case 1228:{f.Push(JValue.R(rt.String("T")));f.Pc=1231;continue;}
case 1231:{f.Push(f.Locals[4]);f.Pc=1233;continue;}
case 1233:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1236);}
case 1236:{f.Pc=f.Pop().Int==0?1248:1239;continue;}
case 1239:{f.Push(f.Locals[2]);f.Pc=1240;continue;}
case 1240:{f.Push(f.Locals[5]);f.Pc=1242;continue;}
case 1242:{return rt.Call(f,"forge/card/CardFace","addTrigger","(Ljava/lang/String;)V","invokevirtual",1245);}
case 1245:{f.Pc=1408;continue;}
case 1248:{f.Push(JValue.R(rt.String("Types")));f.Pc=1251;continue;}
case 1251:{f.Push(f.Locals[4]);f.Pc=1253;continue;}
case 1253:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1256);}
case 1256:{f.Pc=f.Pop().Int==0?1272:1259;continue;}
case 1259:{f.Push(f.Locals[2]);f.Pc=1260;continue;}
case 1260:{f.Push(f.Locals[5]);f.Pc=1262;continue;}
case 1262:{f.Push(JValue.I(0));f.Pc=1263;continue;}
case 1263:{return rt.Call(f,"forge/card/CardType","parse","(Ljava/lang/String;Z)Lforge/card/CardType;","invokestatic",1266);}
case 1266:{return rt.Call(f,"forge/card/CardFace","setType","(Lforge/card/CardType;)V","invokevirtual",1269);}
case 1269:{f.Pc=1408;continue;}
case 1272:{f.Push(JValue.R(rt.String("Text")));f.Pc=1275;continue;}
case 1275:{f.Push(f.Locals[4]);f.Pc=1277;continue;}
case 1277:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1280);}
case 1280:{f.Pc=f.Pop().Int==0?1408:1283;continue;}
case 1283:{f.Push(f.Locals[5]);f.Pc=1285;continue;}
case 1285:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNotBlank","(Ljava/lang/CharSequence;)Z","invokestatic",1288);}
case 1288:{f.Pc=f.Pop().Int==0?1408:1291;continue;}
case 1291:{f.Push(f.Locals[2]);f.Pc=1292;continue;}
case 1292:{f.Push(f.Locals[5]);f.Pc=1294;continue;}
case 1294:{return rt.Call(f,"forge/card/CardFace","setNonAbilityText","(Ljava/lang/String;)V","invokevirtual",1297);}
case 1297:{f.Pc=1408;continue;}
case 1300:{f.Push(JValue.R(rt.String("Variant")));f.Pc=1303;continue;}
case 1303:{f.Push(f.Locals[4]);f.Pc=1305;continue;}
case 1305:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1308);}
case 1308:{f.Pc=f.Pop().Int==0?1408:1311;continue;}
case 1311:{f.Push(f.Locals[5]);f.Pc=1313;continue;}
case 1313:{f.Pc=f.Pop().Reference!=null?1320:1316;continue;}
case 1316:{f.Push(JValue.R(rt.String("")));f.Pc=1318;continue;}
case 1318:{f.Locals[5]=f.Pop();f.Pc=1320;continue;}
case 1320:{f.Push(f.Locals[5]);f.Pc=1322;continue;}
case 1322:{f.Push(JValue.I(58));f.Pc=1324;continue;}
case 1324:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",1327);}
case 1327:{f.Locals[3]=f.Pop();f.Pc=1328;continue;}
case 1328:{f.Push(f.Locals[3]);f.Pc=1329;continue;}
case 1329:{f.Pc=f.Pop().Int>0?1343:1332;continue;}
case 1332:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=1335;continue;}
case 1335:{f.StackOp("dup");f.Pc=1336;continue;}
case 1336:{f.Push(JValue.R(rt.String("Missing variant name")));f.Pc=1339;continue;}
case 1339:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",1342);}
case 1342:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 1343:{f.Push(f.Locals[5]);f.Pc=1345;continue;}
case 1345:{f.Push(JValue.I(0));f.Pc=1346;continue;}
case 1346:{f.Push(f.Locals[3]);f.Pc=1347;continue;}
case 1347:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",1350);}
case 1350:{f.Locals[6]=f.Pop();f.Pc=1352;continue;}
case 1352:{f.Push(f.Locals[2]);f.Pc=1353;continue;}
case 1353:{f.Push(f.Locals[6]);f.Pc=1355;continue;}
case 1355:{return rt.Call(f,"forge/card/CardFace","getOrCreateFunctionalVariant","(Ljava/lang/String;)Lforge/card/CardFace;","invokevirtual",1358);}
case 1358:{f.Locals[7]=f.Pop();f.Pc=1360;continue;}
case 1360:{f.Push(f.Locals[5]);f.Pc=1362;continue;}
case 1362:{f.Push(JValue.I(1));f.Pc=1363;continue;}
case 1363:{f.Push(f.Locals[3]);f.Pc=1364;continue;}
case 1364:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1365;continue;}
case 1365:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1368);}
case 1368:{f.Locals[8]=f.Pop();f.Pc=1370;continue;}
case 1370:{f.Push(f.Locals[0]);f.Pc=1371;continue;}
case 1371:{f.Push(f.Locals[8]);f.Pc=1373;continue;}
case 1373:{f.Push(f.Locals[7]);f.Pc=1375;continue;}
case 1375:{return rt.Call(f,"forge/card/CardRules$Reader","parseLine","(Ljava/lang/String;Lforge/card/CardFace;)V","invokevirtual",1378);}
case 1378:{f.Push(f.Locals[0]);f.Pc=1379;continue;}
case 1379:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","supportedFunctionalVariants","Ljava/util/Set;"));f.Pc=1382;continue;}
case 1382:{f.Pc=f.Pop().Reference!=null?1396:1385;continue;}
case 1385:{f.Push(f.Locals[0]);f.Pc=1386;continue;}
case 1386:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=1389;continue;}
case 1389:{f.StackOp("dup");f.Pc=1390;continue;}
case 1390:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",1393);}
case 1393:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRules$Reader","supportedFunctionalVariants","Ljava/util/Set;",value);f.Pc=1396;continue;}
case 1396:{f.Push(f.Locals[0]);f.Pc=1397;continue;}
case 1397:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRules$Reader","supportedFunctionalVariants","Ljava/util/Set;"));f.Pc=1400;continue;}
case 1400:{f.Push(f.Locals[6]);f.Pc=1402;continue;}
case 1402:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",1407);}
case 1407:{f.StackOp("pop");f.Pc=1408;continue;}
case 1408:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M677(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/CardRules")));f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/lang/Class","desiredAssertionStatus","()Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int!=0?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/card/CardRules$Reader","$assertionsDisabled","Z"))return JStep.Continue;rt.PutStatic("forge/card/CardRules$Reader","$assertionsDisabled","Z",f.Pop());f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

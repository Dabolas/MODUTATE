// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1075{
internal static JClass Build(){var c=new JClass("forge/item/PaperToken","java/lang/Object",new string[]{"forge/item/InventoryItemFromSet","forge/item/IPaperCard"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JField("name","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("collectorNumber","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("artist","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("edition","Lforge/card/CardEdition;",false,JValue.Default("Lforge/card/CardEdition;"),null));
c.Add(new JField("imageFileName","Ljava/util/ArrayList;",false,JValue.Default("Ljava/util/ArrayList;"),null));
c.Add(new JField("cardRules","Lforge/card/CardRules;",false,JValue.Default("Lforge/card/CardRules;"),null));
c.Add(new JField("artIndex","I",false,JValue.Default("I"),null));
c.Add(new JMethod(11368,"forge/item/PaperToken","makeTokenFileName","(Ljava/lang/String;)Ljava/lang/String;",9,4,2,new JHandler[]{},M11368));
c.Add(new JMethod(11369,"forge/item/PaperToken","makeTokenFileName","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",9,4,5,new JHandler[]{},M11369));
c.Add(new JMethod(11370,"forge/item/PaperToken","makeTokenFileName","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",9,7,2,new JHandler[]{},M11370));
c.Add(new JMethod(11371,"forge/item/PaperToken","<init>","(Lforge/card/CardRules;Lforge/card/CardEdition;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V",1,9,6,new JHandler[]{},M11371));
c.Add(new JMethod(11372,"forge/item/PaperToken","getName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11372));
c.Add(new JMethod(11373,"forge/item/PaperToken","getDisplayName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11373));
c.Add(new JMethod(11374,"forge/item/PaperToken","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11374));
c.Add(new JMethod(11375,"forge/item/PaperToken","getEdition","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11375));
c.Add(new JMethod(11376,"forge/item/PaperToken","getCollectorNumber","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11376));
c.Add(new JMethod(11377,"forge/item/PaperToken","getFunctionalVariant","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11377));
c.Add(new JMethod(11378,"forge/item/PaperToken","getMarkedColors","()Lforge/card/ColorSet;",1,1,1,new JHandler[]{},M11378));
c.Add(new JMethod(11379,"forge/item/PaperToken","getArtIndex","()I",1,1,1,new JHandler[]{},M11379));
c.Add(new JMethod(11380,"forge/item/PaperToken","isFoil","()Z",1,1,1,new JHandler[]{},M11380));
c.Add(new JMethod(11381,"forge/item/PaperToken","getRules","()Lforge/card/CardRules;",1,1,1,new JHandler[]{},M11381));
c.Add(new JMethod(11382,"forge/item/PaperToken","getRarity","()Lforge/card/CardRarity;",1,1,1,new JHandler[]{},M11382));
c.Add(new JMethod(11383,"forge/item/PaperToken","getArtist","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11383));
c.Add(new JMethod(11384,"forge/item/PaperToken","getImageFilename","(I)Ljava/lang/String;",1,2,3,new JHandler[]{},M11384));
c.Add(new JMethod(11385,"forge/item/PaperToken","getItemType","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11385));
c.Add(new JMethod(11386,"forge/item/PaperToken","hasBackFace","()Z",1,2,2,new JHandler[]{},M11386));
c.Add(new JMethod(11387,"forge/item/PaperToken","getMainFace","()Lforge/card/ICardFace;",1,1,1,new JHandler[]{},M11387));
c.Add(new JMethod(11388,"forge/item/PaperToken","getOtherFace","()Lforge/card/ICardFace;",1,1,1,new JHandler[]{},M11388));
c.Add(new JMethod(11389,"forge/item/PaperToken","getAllFaces","()Ljava/util/List;",1,1,1,new JHandler[]{},M11389));
c.Add(new JMethod(11390,"forge/item/PaperToken","isToken","()Z",1,1,1,new JHandler[]{},M11390));
c.Add(new JMethod(11391,"forge/item/PaperToken","getCardImageKey","()Ljava/lang/String;",1,1,2,new JHandler[]{},M11391));
c.Add(new JMethod(11392,"forge/item/PaperToken","getCardAltImageKey","()Ljava/lang/String;",1,1,2,new JHandler[]{},M11392));
c.Add(new JMethod(11393,"forge/item/PaperToken","getImageKey","(Z)Ljava/lang/String;",1,4,5,new JHandler[]{},M11393));
c.Add(new JMethod(11394,"forge/item/PaperToken","getImageKey","(I)Ljava/lang/String;",1,2,3,new JHandler[]{},M11394));
c.Add(new JMethod(11395,"forge/item/PaperToken","isRebalanced","()Z",1,1,1,new JHandler[]{},M11395));
}

internal static JStep M11368(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuffer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuffer")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuffer","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",15);}
case 15:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?71:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",23);}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Push(JValue.I(32));f.Pc=27;continue;}
case 27:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?42:30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Push(JValue.I(45));f.Pc=33;continue;}
case 33:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?42:36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{f.Push(JValue.I(95));f.Pc=39;continue;}
case 39:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?52:42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(JValue.I(95));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/StringBuffer","append","(C)Ljava/lang/StringBuffer;","invokevirtual",48);}
case 48:{f.StackOp("pop");f.Pc=49;continue;}
case 49:{f.Pc=65;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/Character","isLetterOrDigit","(C)Z","invokestatic",56);}
case 56:{f.Pc=f.Pop().Int==0?65:59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/StringBuffer","append","(C)Ljava/lang/StringBuffer;","invokevirtual",64);}
case 64:{f.StackOp("pop");f.Pc=65;continue;}
case 65:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=68;continue;}
case 68:{f.Pc=10;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/StringBuffer","toString","()Ljava/lang/String;","invokevirtual",75);}
case 75:{if(!rt.StaticReady(f,"java/util/Locale","ENGLISH","Ljava/util/Locale;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/Locale","ENGLISH","Ljava/util/Locale;"));f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/String","toLowerCase","(Ljava/util/Locale;)Ljava/lang/String;","invokevirtual",81);}
case 81:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11369(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[2]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperToken","makeTokenFileName","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11370(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[5]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Reference==null?20:13;continue;}
case 13:{f.Push(f.Locals[5]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[5]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Pc=f.Pop().Reference==null?49:31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{f.Pc=f.Pop().Reference==null?49:35;continue;}
case 35:{f.Push(f.Locals[5]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{f.Push(f.Locals[5]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",48);}
case 48:{f.StackOp("pop");f.Pc=49;continue;}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",56);}
case 56:{f.StackOp("pop");f.Pc=57;continue;}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("_")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",64);}
case 64:{f.Locals[6]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[6]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/item/PaperToken","makeTokenFileName","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",71);}
case 71:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11371(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperToken","imageFileName","Ljava/util/ArrayList;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperToken","artIndex","I",value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperToken","cardRules","Lforge/card/CardRules;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",30);}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperToken","name","Ljava/lang/String;",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperToken","edition","Lforge/card/CardEdition;",value);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperToken","collectorNumber","Ljava/lang/String;",value);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperToken","artist","Ljava/lang/String;",value);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{f.Pc=f.Pop().Reference==null?211:55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int!=0?211:63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","edition","Lforge/card/CardEdition;"));f.Pc=67;continue;}
case 67:{f.Pc=f.Pop().Reference==null?211:70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","edition","Lforge/card/CardEdition;"));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/card/CardEdition","getTokens","()Lcom/google/common/collect/Multimap;","invokevirtual",77);}
case 77:{f.Push(f.Locals[3]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"com/google/common/collect/Multimap","containsKey","(Ljava/lang/Object;)Z","invokeinterface",83);}
case 83:{f.Pc=f.Pop().Int==0?211:86;continue;}
case 86:{f.Push(JValue.I(0));f.Pc=87;continue;}
case 87:{f.Locals[6]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","edition","Lforge/card/CardEdition;"));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/card/CardEdition","getTokens","()Lcom/google/common/collect/Multimap;","invokevirtual",96);}
case 96:{f.Push(f.Locals[3]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",102);}
case 102:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",107);}
case 107:{f.Locals[7]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[7]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",116);}
case 116:{f.Pc=f.Pop().Int==0?197:119;continue;}
case 119:{f.Push(f.Locals[7]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",126);}
case 126:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=129;continue;}
case 129:{f.Locals[8]=f.Pop();f.Pc=131;continue;}
case 131:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=134;continue;}
case 134:{f.Push(f.Locals[8]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","collectorNumber","()Ljava/lang/String;","invokevirtual",139);}
case 139:{f.Push(f.Locals[4]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",144);}
case 144:{f.Pc=f.Pop().Int!=0?150:147;continue;}
case 147:{f.Pc=109;continue;}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","imageFileName","Ljava/util/ArrayList;"));f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String("%s|%s|%s|%d")));f.Pc=156;continue;}
case 156:{f.Push(JValue.I(4));f.Pc=157;continue;}
case 157:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=160;continue;}
case 160:{f.StackOp("dup");f.Pc=161;continue;}
case 161:{f.Push(JValue.I(0));f.Pc=162;continue;}
case 162:{f.Push(f.Locals[3]);f.Pc=163;continue;}
case 163:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=164;continue;}
case 164:{f.StackOp("dup");f.Pc=165;continue;}
case 165:{f.Push(JValue.I(1));f.Pc=166;continue;}
case 166:{f.Push(f.Locals[0]);f.Pc=167;continue;}
case 167:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","edition","Lforge/card/CardEdition;"));f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",173);}
case 173:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=174;continue;}
case 174:{f.StackOp("dup");f.Pc=175;continue;}
case 175:{f.Push(JValue.I(2));f.Pc=176;continue;}
case 176:{f.Push(f.Locals[4]);f.Pc=178;continue;}
case 178:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=179;continue;}
case 179:{f.StackOp("dup");f.Pc=180;continue;}
case 180:{f.Push(JValue.I(3));f.Pc=181;continue;}
case 181:{f.Push(f.Locals[6]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",186);}
case 186:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=187;continue;}
case 187:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",190);}
case 190:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",193);}
case 193:{f.StackOp("pop");f.Pc=194;continue;}
case 194:{f.Pc=109;continue;}
case 197:{f.Push(f.Locals[0]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[0]);f.Pc=199;continue;}
case 199:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","imageFileName","Ljava/util/ArrayList;"));f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",205);}
case 205:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PaperToken","artIndex","I",value);f.Pc=208;continue;}
case 208:{f.Pc=272;continue;}
case 211:{f.Push(JValue.R(null));f.Pc=212;continue;}
case 212:{f.Push(f.Locals[0]);f.Pc=213;continue;}
case 213:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","edition","Lforge/card/CardEdition;"));f.Pc=216;continue;}
case 216:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?229:219;continue;}
case 219:{if(!rt.StaticReady(f,"forge/card/CardEdition","UNKNOWN","Lforge/card/CardEdition;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition","UNKNOWN","Lforge/card/CardEdition;"));f.Pc=222;continue;}
case 222:{f.Push(f.Locals[0]);f.Pc=223;continue;}
case 223:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","edition","Lforge/card/CardEdition;"));f.Pc=226;continue;}
case 226:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?241:229;continue;}
case 229:{f.Push(f.Locals[0]);f.Pc=230;continue;}
case 230:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","imageFileName","Ljava/util/ArrayList;"));f.Pc=233;continue;}
case 233:{f.Push(f.Locals[3]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",237);}
case 237:{f.StackOp("pop");f.Pc=238;continue;}
case 238:{f.Pc=272;continue;}
case 241:{f.Push(f.Locals[0]);f.Pc=242;continue;}
case 242:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","imageFileName","Ljava/util/ArrayList;"));f.Pc=245;continue;}
case 245:{f.Push(JValue.R(rt.String("%s|%s")));f.Pc=247;continue;}
case 247:{f.Push(JValue.I(2));f.Pc=248;continue;}
case 248:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=251;continue;}
case 251:{f.StackOp("dup");f.Pc=252;continue;}
case 252:{f.Push(JValue.I(0));f.Pc=253;continue;}
case 253:{f.Push(f.Locals[3]);f.Pc=254;continue;}
case 254:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=255;continue;}
case 255:{f.StackOp("dup");f.Pc=256;continue;}
case 256:{f.Push(JValue.I(1));f.Pc=257;continue;}
case 257:{f.Push(f.Locals[0]);f.Pc=258;continue;}
case 258:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","edition","Lforge/card/CardEdition;"));f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",264);}
case 264:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=265;continue;}
case 265:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",268);}
case 268:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",271);}
case 271:{f.StackOp("pop");f.Pc=272;continue;}
case 272:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11372(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11373(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11374(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11375(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","edition","Lforge/card/CardEdition;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?17:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","edition","Lforge/card/CardEdition;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Pc=19;continue;}
case 17:{f.Push(JValue.R(rt.String("???")));f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11376(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","collectorNumber","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?13:10;continue;}
case 10:{f.Push(JValue.R(rt.String("N.A.")));f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","collectorNumber","Ljava/lang/String;"));f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11377(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11378(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11379(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","artIndex","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11380(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11381(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","cardRules","Lforge/card/CardRules;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11382(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardRarity","Token","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Token","Lforge/card/CardRarity;"));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11383(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","artist","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11384(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","imageFileName","Ljava/util/ArrayList;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/ArrayList","get","(I)Ljava/lang/Object;","invokevirtual",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11385(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Token")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11386(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","cardRules","Lforge/card/CardRules;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","cardRules","Lforge/card/CardRules;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/CardRules","getSplitType","()Lforge/card/CardSplitType;","invokevirtual",16);}
case 16:{f.Locals[1]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Transform","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Transform","Lforge/card/CardSplitType;"));f.Pc=21;continue;}
case 21:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?31:24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Modal","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Modal","Lforge/card/CardSplitType;"));f.Pc=28;continue;}
case 28:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?35:31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{f.Pc=36;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11387(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperToken","getRules","()Lforge/card/CardRules;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardRules","getMainPart","()Lforge/card/ICardFace;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11388(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperToken","getRules","()Lforge/card/CardRules;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardRules","getOtherPart","()Lforge/card/ICardFace;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11389(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","cardRules","Lforge/card/CardRules;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardRules","getAllFaces","()Ljava/util/List;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11390(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11391(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/item/PaperToken","getImageKey","(Z)Ljava/lang/String;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11392(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/item/PaperToken","getImageKey","(Z)Ljava/lang/String;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11393(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("")));f.Pc=2;continue;}
case 2:{f.Locals[2]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/item/PaperToken","hasBackFace","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?110:10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int==0?110:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","collectorNumber","Ljava/lang/String;"));f.Pc=18;continue;}
case 18:{f.Pc=f.Pop().Reference==null?107:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","collectorNumber","Ljava/lang/String;"));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int!=0?107:31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","edition","Lforge/card/CardEdition;"));f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Reference==null?107:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","cardRules","Lforge/card/CardRules;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/card/CardRules","getOtherPart","()Lforge/card/ICardFace;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",50);}
case 50:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",53);}
case 53:{f.Push(JValue.R(rt.String(" token")));f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",60);}
case 60:{f.Push(JValue.R(rt.String(" ")));f.Pc=62;continue;}
case 62:{f.Push(JValue.R(rt.String("_")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",67);}
case 67:{f.Locals[3]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("%s|%s|%s%s")));f.Pc=70;continue;}
case 70:{f.Push(JValue.I(4));f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=74;continue;}
case 74:{f.StackOp("dup");f.Pc=75;continue;}
case 75:{f.Push(JValue.I(0));f.Pc=76;continue;}
case 76:{f.Push(f.Locals[3]);f.Pc=77;continue;}
case 77:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=78;continue;}
case 78:{f.StackOp("dup");f.Pc=79;continue;}
case 79:{f.Push(JValue.I(1));f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","edition","Lforge/card/CardEdition;"));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",87);}
case 87:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=88;continue;}
case 88:{f.StackOp("dup");f.Pc=89;continue;}
case 89:{f.Push(JValue.I(2));f.Pc=90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","collectorNumber","Ljava/lang/String;"));f.Pc=94;continue;}
case 94:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=95;continue;}
case 95:{f.StackOp("dup");f.Pc=96;continue;}
case 96:{f.Push(JValue.I(3));f.Pc=97;continue;}
case 97:{f.Push(JValue.R(rt.String("$alt")));f.Pc=99;continue;}
case 99:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",103);}
case 103:{return rt.Call(f,"forge/ImageKeys","getTokenKey","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",106);}
case 106:{return JStep.Return(f.Pop());}
case 107:{f.Push(JValue.R(rt.String("$alt")));f.Pc=109;continue;}
case 109:{f.Locals[2]=f.Pop();f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/concurrent/ThreadLocalRandom","current","()Ljava/util/concurrent/ThreadLocalRandom;","invokestatic",113);}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","artIndex","I"));f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/util/concurrent/ThreadLocalRandom","nextInt","(I)I","invokevirtual",120);}
case 120:{f.Locals[3]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[3]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/item/PaperToken","getImageKey","(I)Ljava/lang/String;","invokevirtual",126);}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{return rt.DynamicCall(f,"forge/item/PaperToken:11393:127:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",132);}
case 132:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11394(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/PaperToken","imageFileName","Ljava/util/ArrayList;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/ArrayList","get","(I)Ljava/lang/Object;","invokevirtual",8);}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String(" ")));f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("_")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/ImageKeys","getTokenKey","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",21);}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11395(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

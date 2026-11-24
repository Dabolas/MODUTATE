// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C81{
internal static JClass Build(){var c=new JClass("forge/deck/CardPool","forge/util/ItemPool",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-5379091255613968393L),null));
c.Add(new JField("p","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JMethod(1274,"forge/deck/CardPool","<init>","()V",1,1,2,new JHandler[]{},M1274));
c.Add(new JMethod(1275,"forge/deck/CardPool","<init>","(Ljava/lang/Iterable;)V",1,2,2,new JHandler[]{},M1275));
c.Add(new JMethod(1276,"forge/deck/CardPool","add","(Ljava/lang/String;I)V",1,4,7,new JHandler[]{},M1276));
c.Add(new JMethod(1277,"forge/deck/CardPool","add","(Ljava/lang/String;Ljava/lang/String;)V",1,3,5,new JHandler[]{},M1277));
c.Add(new JMethod(1278,"forge/deck/CardPool","add","(Ljava/lang/String;Ljava/lang/String;I)V",1,4,5,new JHandler[]{},M1278));
c.Add(new JMethod(1279,"forge/deck/CardPool","add","(Ljava/lang/String;Ljava/lang/String;IZ)V",1,5,7,new JHandler[]{},M1279));
c.Add(new JMethod(1280,"forge/deck/CardPool","add","(Ljava/lang/String;Ljava/lang/String;II)V",1,5,7,new JHandler[]{},M1280));
c.Add(new JMethod(1281,"forge/deck/CardPool","add","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IZLjava/util/Map;)V",2,12,7,new JHandler[]{},M1281));
c.Add(new JMethod(1282,"forge/deck/CardPool","add","(Ljava/lang/String;Ljava/lang/String;IIZLjava/util/Map;)V",2,20,5,new JHandler[]{},M1282));
c.Add(new JMethod(1283,"forge/deck/CardPool","add","(Ljava/lang/Iterable;)V",1,4,2,new JHandler[]{},M1283));
c.Add(new JMethod(1284,"forge/deck/CardPool","get","(I)Lforge/item/PaperCard;",1,4,2,new JHandler[]{},M1284));
c.Add(new JMethod(1285,"forge/deck/CardPool","countByName","(Ljava/lang/String;)I",1,2,2,new JHandler[]{},M1285));
c.Add(new JMethod(1286,"forge/deck/CardPool","countByName","(Lforge/item/PaperCard;)I",1,2,2,new JHandler[]{},M1286));
c.Add(new JMethod(1287,"forge/deck/CardPool","getCardEditionStatistics","(Z)Ljava/util/Map;",1,9,3,new JHandler[]{},M1287));
c.Add(new JMethod(1288,"forge/deck/CardPool","getCardEditionsGroupedByNumberOfCards","(Z)Lcom/google/common/collect/ListMultimap;",1,6,3,new JHandler[]{},M1288));
c.Add(new JMethod(1289,"forge/deck/CardPool","getCardEditionTypeStatistics","(Z)Ljava/util/Map;",1,10,3,new JHandler[]{},M1289));
c.Add(new JMethod(1290,"forge/deck/CardPool","getTheMostFrequentEditionType","()Lforge/card/CardEdition$Type;",1,7,2,new JHandler[]{},M1290));
c.Add(new JMethod(1291,"forge/deck/CardPool","isModern","()Z",1,7,2,new JHandler[]{},M1291));
c.Add(new JMethod(1292,"forge/deck/CardPool","getDominantBorderColor","()Lforge/card/CardEdition$BorderColor;",1,6,2,new JHandler[]{},M1292));
c.Add(new JMethod(1293,"forge/deck/CardPool","getPivotCardEdition","(Z)Lforge/card/CardEdition;",1,14,4,new JHandler[]{},M1293));
c.Add(new JMethod(1294,"forge/deck/CardPool","getMedianEditionByDate","(Ljava/util/Map;)Lforge/card/CardEdition;",10,7,3,new JHandler[]{},M1294));
c.Add(new JMethod(1295,"forge/deck/CardPool","getMedianFrequency","(Ljava/util/List;F)I",10,7,2,new JHandler[]{},M1295));
c.Add(new JMethod(1296,"forge/deck/CardPool","toString","()Ljava/lang/String;",1,5,2,new JHandler[]{},M1296));
c.Add(new JMethod(1297,"forge/deck/CardPool","fromCardList","(Ljava/lang/Iterable;)Lforge/deck/CardPool;",9,7,3,new JHandler[]{},M1297));
c.Add(new JMethod(1298,"forge/deck/CardPool","fromSingleCardRequest","(Ljava/lang/String;)Lforge/deck/CardPool;",9,1,2,new JHandler[]{},M1298));
c.Add(new JMethod(1299,"forge/deck/CardPool","processCardList","(Ljava/lang/Iterable;)Ljava/util/List;",9,9,3,new JHandler[]{},M1299));
c.Add(new JMethod(1300,"forge/deck/CardPool","toCardList","(Ljava/lang/String;)Ljava/lang/String;",1,3,2,new JHandler[]{},M1300));
c.Add(new JMethod(1301,"forge/deck/CardPool","getFilteredPool","(Ljava/util/function/Predicate;)Lforge/deck/CardPool;",1,5,4,new JHandler[]{},M1301));
c.Add(new JMethod(1302,"forge/deck/CardPool","getFilteredPool","(Ljava/util/function/Predicate;)Lforge/util/ItemPool;",4161,2,2,new JHandler[]{},M1302));
c.Add(new JMethod(1303,"forge/deck/CardPool","lambda$toCardList$4","(Ljava/util/Map$Entry;)Ljava/lang/String;",4106,1,2,new JHandler[]{},M1303));
c.Add(new JMethod(1304,"forge/deck/CardPool","lambda$getPivotCardEdition$3","(Lforge/card/CardDb$CardArtPreference;Lforge/card/CardEdition;)Z",4106,2,2,new JHandler[]{},M1304));
c.Add(new JMethod(1305,"forge/deck/CardPool","lambda$getPivotCardEdition$2","(Lforge/card/CardDb$CardArtPreference;Lforge/card/CardEdition;)Z",4106,2,2,new JHandler[]{},M1305));
c.Add(new JMethod(1306,"forge/deck/CardPool","lambda$countByName$1","(Lforge/item/PaperCard;Lforge/item/PaperCard;)Z",4106,2,2,new JHandler[]{},M1306));
c.Add(new JMethod(1307,"forge/deck/CardPool","lambda$countByName$0","(Ljava/lang/String;Lforge/item/PaperCard;)Z",4106,2,2,new JHandler[]{},M1307));
c.Add(new JMethod(1308,"forge/deck/CardPool","<clinit>","()V",8,0,1,new JHandler[]{},M1308));
}

internal static JStep M1274(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.ClassObject("forge/item/PaperCard")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/util/ItemPool","<init>","(Ljava/lang/Class;)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1275(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/CardPool","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/deck/CardPool","addAll","(Ljava/lang/Iterable;)V","invokevirtual",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1276(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardDb$CardRequest","fromString","(Ljava/lang/String;)Lforge/card/CardDb$CardRequest;","invokestatic",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","collectorNumber","Ljava/lang/String;"));f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference==null?56:12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","collectorNumber","Ljava/lang/String;"));f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("N.A.")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int!=0?56:24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;"));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","isFoil","Z"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Z)Ljava/lang/String;","invokestatic",36);}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","edition","Ljava/lang/String;"));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","collectorNumber","Ljava/lang/String;"));f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","flags","Ljava/util/Map;"));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/deck/CardPool","add","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IZLjava/util/Map;)V","invokevirtual",53);}
case 53:{f.Pc=85;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;"));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","isFoil","Z"));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Z)Ljava/lang/String;","invokestatic",68);}
case 68:{f.Push(f.Locals[3]);f.Pc=69;continue;}
case 69:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","edition","Ljava/lang/String;"));f.Pc=72;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","artIndex","I"));f.Pc=76;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{f.Push(f.Locals[3]);f.Pc=79;continue;}
case 79:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","flags","Ljava/util/Map;"));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/deck/CardPool","add","(Ljava/lang/String;Ljava/lang/String;IIZLjava/util/Map;)V","invokevirtual",85);}
case 85:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1277(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(1));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/deck/CardPool","add","(Ljava/lang/String;Ljava/lang/String;II)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1278(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(1));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/deck/CardPool","add","(Ljava/lang/String;Ljava/lang/String;II)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1279(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(-1));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[4]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/deck/CardPool","add","(Ljava/lang/String;Ljava/lang/String;IIZLjava/util/Map;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1280(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/deck/CardPool","add","(Ljava/lang/String;Ljava/lang/String;IIZLjava/util/Map;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1281(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","getAvailableDatabases","()Ljava/util/Map;","invokevirtual",6);}
case 6:{f.Locals[7]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[7]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",15);}
case 15:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",20);}
case 20:{f.Locals[8]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[8]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?85:32;continue;}
case 32:{f.Push(f.Locals[8]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{f.Locals[9]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[9]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardDb"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{f.Locals[10]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[10]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[6]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Lforge/item/PaperCard;","invokevirtual",66);}
case 66:{f.Locals[11]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[11]);f.Pc=70;continue;}
case 70:{f.Pc=f.Pop().Reference==null?82:73;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[11]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;I)V","invokevirtual",81);}
case 81:{return JStep.ReturnVoid;}
case 82:{f.Pc=22;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{f.Push(JValue.R(rt.String("A-")));f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?115:94;continue;}
case 94:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{return rt.DynamicCall(f,"forge/deck/CardPool:1281:98:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",103);}
case 103:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",106);}
case 106:{f.Push(f.Locals[1]);f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.String("A-")));f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/lang/String","replaceFirst","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",114);}
case 114:{f.Locals[1]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[2]);f.Pc=118;continue;}
case 118:{f.Push(JValue.I(-1));f.Pc=119;continue;}
case 119:{f.Push(f.Locals[4]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[5]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[6]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/deck/CardPool","add","(Ljava/lang/String;Ljava/lang/String;IIZLjava/util/Map;)V","invokevirtual",128);}
case 128:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1282(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","getAvailableDatabases","()Ljava/util/Map;","invokevirtual",6);}
case 6:{f.Locals[7]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{f.Locals[8]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("")));f.Pc=13;continue;}
case 13:{f.Locals[9]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",20);}
case 20:{f.Locals[3]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{f.Locals[10]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[8]);f.Pc=26;continue;}
case 26:{f.Pc=f.Pop().Reference!=null?149:29;continue;}
case 29:{f.Push(f.Locals[10]);f.Pc=31;continue;}
case 31:{f.Push(JValue.I(2));f.Pc=32;continue;}
case 32:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?149:35;continue;}
case 35:{f.Push(f.Locals[7]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",42);}
case 42:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",47);}
case 47:{f.Locals[11]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[11]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",56);}
case 56:{f.Pc=f.Pop().Int==0?122:59;continue;}
case 59:{f.Push(f.Locals[11]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",66);}
case 66:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=69;continue;}
case 69:{f.Locals[12]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[12]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",78);}
case 78:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=81;continue;}
case 81:{f.Locals[13]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[12]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",90);}
case 90:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardDb"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=93;continue;}
case 93:{f.Locals[14]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[14]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[3]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[6]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;ILjava/util/Map;)Lforge/item/PaperCard;","invokevirtual",105);}
case 105:{f.Locals[8]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[8]);f.Pc=109;continue;}
case 109:{f.Pc=f.Pop().Reference==null?119:112;continue;}
case 112:{f.Push(f.Locals[13]);f.Pc=114;continue;}
case 114:{f.Locals[9]=f.Pop();f.Pc=116;continue;}
case 116:{f.Pc=122;continue;}
case 119:{f.Pc=49;continue;}
case 122:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=125;continue;}
case 125:{f.Push(f.Locals[8]);f.Pc=127;continue;}
case 127:{f.Pc=f.Pop().Reference!=null?24:130;continue;}
case 130:{f.Push(f.Locals[10]);f.Pc=132;continue;}
case 132:{f.Push(JValue.I(2));f.Pc=133;continue;}
case 133:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?24:136;continue;}
case 136:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",139);}
case 139:{f.Push(f.Locals[1]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[2]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/StaticData","attemptToLoadCard","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",144);}
case 144:{f.Push(JValue.I(1));f.Pc=145;continue;}
case 145:{f.Locals[3]=f.Pop();f.Pc=146;continue;}
case 146:{f.Pc=24;continue;}
case 149:{f.Push(f.Locals[5]);f.Pc=151;continue;}
case 151:{f.Pc=f.Pop().Int==0?175:154;continue;}
case 154:{f.Push(f.Locals[8]);f.Pc=156;continue;}
case 156:{f.Pc=f.Pop().Reference!=null?175:159;continue;}
case 159:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",162);}
case 162:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",165);}
case 165:{f.Push(f.Locals[1]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",169);}
case 169:{f.Locals[8]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(JValue.R(rt.String("Common")));f.Pc=173;continue;}
case 173:{f.Locals[9]=f.Pop();f.Pc=175;continue;}
case 175:{f.Push(f.Locals[8]);f.Pc=177;continue;}
case 177:{f.Pc=f.Pop().Reference!=null?209:180;continue;}
case 180:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=183;continue;}
case 183:{f.Push(f.Locals[1]);f.Pc=184;continue;}
case 184:{f.Push(f.Locals[2]);f.Pc=185;continue;}
case 185:{return rt.DynamicCall(f,"forge/deck/CardPool:1282:185:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",190);}
case 190:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",193);}
case 193:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",196);}
case 196:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",199);}
case 199:{f.Push(f.Locals[1]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/card/CardDb","createUnsupportedCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",203);}
case 203:{f.Locals[8]=f.Pop();f.Pc=205;continue;}
case 205:{f.Push(JValue.R(rt.String("Common")));f.Pc=207;continue;}
case 207:{f.Locals[9]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(f.Locals[7]);f.Pc=211;continue;}
case 211:{f.Push(f.Locals[9]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",216);}
case 216:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",219);}
case 219:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",224);}
case 224:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardDb"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=227;continue;}
case 227:{f.Locals[11]=f.Pop();f.Pc=229;continue;}
case 229:{f.Push(f.Locals[8]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",234);}
case 234:{f.Locals[2]=f.Pop();f.Pc=235;continue;}
case 235:{f.Push(f.Locals[8]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",240);}
case 240:{f.Locals[1]=f.Pop();f.Pc=241;continue;}
case 241:{f.Push(f.Locals[3]);f.Pc=242;continue;}
case 242:{f.Push(JValue.I(1));f.Pc=243;continue;}
case 243:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?257:246;continue;}
case 246:{f.Push(f.Locals[1]);f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/card/CardDb$CardRequest","fromString","(Ljava/lang/String;)Lforge/card/CardDb$CardRequest;","invokestatic",250);}
case 250:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","artIndex","I"));f.Pc=253;continue;}
case 253:{f.Push(JValue.I(-1));f.Pc=254;continue;}
case 254:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?261:257;continue;}
case 257:{f.Push(JValue.I(1));f.Pc=258;continue;}
case 258:{f.Pc=262;continue;}
case 261:{f.Push(JValue.I(0));f.Pc=262;continue;}
case 262:{f.Locals[12]=f.Pop();f.Pc=264;continue;}
case 264:{f.Push(f.Locals[12]);f.Pc=266;continue;}
case 266:{f.Pc=f.Pop().Int==0?275:269;continue;}
case 269:{return rt.Call(f,"java/util/Collections","emptyList","()Ljava/util/List;","invokestatic",272);}
case 272:{f.Pc=282;continue;}
case 275:{f.Push(f.Locals[11]);f.Pc=277;continue;}
case 277:{f.Push(f.Locals[8]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/card/CardDb","getTraditionalFramePrints","(Lforge/item/PaperCard;)Ljava/util/List;","invokevirtual",282);}
case 282:{f.Locals[13]=f.Pop();f.Pc=284;continue;}
case 284:{f.Push(f.Locals[13]);f.Pc=286;continue;}
case 286:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",291);}
case 291:{f.Pc=f.Pop().Int==0?304:294;continue;}
case 294:{f.Push(f.Locals[11]);f.Pc=296;continue;}
case 296:{f.Push(f.Locals[1]);f.Pc=297;continue;}
case 297:{f.Push(f.Locals[2]);f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/card/CardDb","getArtCount","(Ljava/lang/String;Ljava/lang/String;)I","invokevirtual",301);}
case 301:{f.Pc=311;continue;}
case 304:{f.Push(f.Locals[13]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",311);}
case 311:{f.Locals[14]=f.Pop();f.Pc=313;continue;}
case 313:{f.Push(f.Locals[12]);f.Pc=315;continue;}
case 315:{f.Pc=f.Pop().Int!=0?324:318;continue;}
case 318:{f.Push(f.Locals[14]);f.Pc=320;continue;}
case 320:{f.Push(JValue.I(1));f.Pc=321;continue;}
case 321:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?386:324;continue;}
case 324:{f.Push(f.Locals[5]);f.Pc=326;continue;}
case 326:{f.Pc=f.Pop().Int!=0?386:329;continue;}
case 329:{f.Push(f.Locals[13]);f.Pc=331;continue;}
case 331:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",336);}
case 336:{f.Push(JValue.I(1));f.Pc=337;continue;}
case 337:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?375:340;continue;}
case 340:{f.Push(f.Locals[11]);f.Pc=342;continue;}
case 342:{f.Push(f.Locals[8]);f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/card/CardDb","isTraditionalFramePrint","(Lforge/item/PaperCard;)Z","invokevirtual",347);}
case 347:{f.Pc=f.Pop().Int!=0?375:350;continue;}
case 350:{f.Push(f.Locals[11]);f.Pc=352;continue;}
case 352:{f.Push(f.Locals[1]);f.Pc=353;continue;}
case 353:{f.Push(f.Locals[2]);f.Pc=354;continue;}
case 354:{f.Push(f.Locals[13]);f.Pc=356;continue;}
case 356:{f.Push(JValue.I(0));f.Pc=357;continue;}
case 357:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",362);}
case 362:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=365;continue;}
case 365:{return rt.Call(f,"forge/item/PaperCard","getArtIndex","()I","invokevirtual",368);}
case 368:{f.Push(f.Locals[6]);f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;ILjava/util/Map;)Lforge/item/PaperCard;","invokevirtual",373);}
case 373:{f.Locals[8]=f.Pop();f.Pc=375;continue;}
case 375:{f.Push(f.Locals[0]);f.Pc=376;continue;}
case 376:{f.Push(f.Locals[8]);f.Pc=378;continue;}
case 378:{f.Push(f.Locals[4]);f.Pc=380;continue;}
case 380:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;I)V","invokevirtual",383);}
case 383:{f.Pc=484;continue;}
case 386:{f.Push(f.Locals[4]);f.Pc=388;continue;}
case 388:{f.Push(f.Locals[14]);f.Pc=390;continue;}
case 390:{return rt.Call(f,"forge/util/MyRandom","splitIntoRandomGroups","(II)[I","invokestatic",393);}
case 393:{f.Locals[15]=f.Pop();f.Pc=395;continue;}
case 395:{f.Push(JValue.I(1));f.Pc=396;continue;}
case 396:{f.Locals[16]=f.Pop();f.Pc=398;continue;}
case 398:{f.Push(f.Locals[16]);f.Pc=400;continue;}
case 400:{f.Push(f.Locals[15]);f.Pc=402;continue;}
case 402:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=403;continue;}
case 403:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?484:406;continue;}
case 406:{f.Push(f.Locals[15]);f.Pc=408;continue;}
case 408:{f.Push(f.Locals[16]);f.Pc=410;continue;}
case 410:{f.Push(JValue.I(1));f.Pc=411;continue;}
case 411:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=412;continue;}
case 412:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=413;continue;}
case 413:{f.Locals[17]=f.Pop();f.Pc=415;continue;}
case 415:{f.Push(f.Locals[17]);f.Pc=417;continue;}
case 417:{f.Pc=f.Pop().Int>0?423:420;continue;}
case 420:{f.Pc=478;continue;}
case 423:{f.Push(f.Locals[13]);f.Pc=425;continue;}
case 425:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",430);}
case 430:{f.Pc=f.Pop().Int==0?438:433;continue;}
case 433:{f.Push(f.Locals[16]);f.Pc=435;continue;}
case 435:{f.Pc=455;continue;}
case 438:{f.Push(f.Locals[13]);f.Pc=440;continue;}
case 440:{f.Push(f.Locals[16]);f.Pc=442;continue;}
case 442:{f.Push(JValue.I(1));f.Pc=443;continue;}
case 443:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=444;continue;}
case 444:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",449);}
case 449:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=452;continue;}
case 452:{return rt.Call(f,"forge/item/PaperCard","getArtIndex","()I","invokevirtual",455);}
case 455:{f.Locals[18]=f.Pop();f.Pc=457;continue;}
case 457:{f.Push(f.Locals[11]);f.Pc=459;continue;}
case 459:{f.Push(f.Locals[1]);f.Pc=460;continue;}
case 460:{f.Push(f.Locals[2]);f.Pc=461;continue;}
case 461:{f.Push(f.Locals[18]);f.Pc=463;continue;}
case 463:{f.Push(f.Locals[6]);f.Pc=465;continue;}
case 465:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;ILjava/util/Map;)Lforge/item/PaperCard;","invokevirtual",468);}
case 468:{f.Locals[19]=f.Pop();f.Pc=470;continue;}
case 470:{f.Push(f.Locals[0]);f.Pc=471;continue;}
case 471:{f.Push(f.Locals[19]);f.Pc=473;continue;}
case 473:{f.Push(f.Locals[17]);f.Pc=475;continue;}
case 475:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;I)V","invokevirtual",478);}
case 478:{f.Locals[16]=JValue.I(unchecked(f.Locals[16].Int+(1)));f.Pc=481;continue;}
case 481:{f.Pc=398;continue;}
case 484:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1283(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?34:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;)V","invokevirtual",31);}
case 31:{f.Pc=7;continue;}
case 34:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1284(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",11);}
case 11:{f.Pc=f.Pop().Int==0?56:14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",20);}
case 20:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=23;continue;}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",37);}
case 37:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=38;continue;}
case 38:{f.Locals[1]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Pc=f.Pop().Int>0?53:43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{return JStep.Return(f.Pop());}
case 53:{f.Pc=5;continue;}
case 56:{f.Push(JValue.R(null));f.Pc=57;continue;}
case 57:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1285(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/deck/CardPool:1285:2:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",7);}
case 7:{return rt.Call(f,"forge/deck/CardPool","countAll","(Ljava/util/function/Predicate;)I","invokevirtual",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1286(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/deck/CardPool:1286:2:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/item/PaperCard;)Ljava/util/function/Predicate;",7);}
case 7:{return rt.Call(f,"forge/deck/CardPool","countAll","(Ljava/util/function/Predicate;)I","invokevirtual",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1287(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/deck/CardPool","items","Ljava/util/Map;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",17);}
case 17:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?156:32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[4]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{f.Locals[5]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",60);}
case 60:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",63);}
case 63:{return rt.Call(f,"forge/card/CardType","isBasicLand","()Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?76:69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{f.Pc=f.Pop().Int!=0?76:73;continue;}
case 73:{f.Pc=23;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",83);}
case 83:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",89);}
case 89:{f.Locals[6]=f.Pop();f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",94);}
case 94:{f.Push(f.Locals[5]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",99);}
case 99:{return rt.Call(f,"forge/StaticData","getCardEdition","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",102);}
case 102:{f.Locals[7]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[7]);f.Pc=106;continue;}
case 106:{f.Pc=f.Pop().Reference!=null?112:109;continue;}
case 109:{f.Pc=23;continue;}
case 112:{f.Push(f.Locals[2]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[7]);f.Pc=115;continue;}
case 115:{f.Push(JValue.I(0));f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",119);}
case 119:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",124);}
case 124:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",130);}
case 130:{f.Locals[8]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(f.Locals[8]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[6]);f.Pc=136;continue;}
case 136:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=137;continue;}
case 137:{f.Locals[8]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[2]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[7]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[8]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",147);}
case 147:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",152);}
case 152:{f.StackOp("pop");f.Pc=153;continue;}
case 153:{f.Pc=23;continue;}
case 156:{f.Push(f.Locals[2]);f.Pc=157;continue;}
case 157:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1288(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/CardPool","getCardEditionStatistics","(Z)Ljava/util/Map;","invokevirtual",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",13);}
case 13:{return rt.DynamicCall(f,"forge/deck/CardPool:1288:13:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",18);}
case 18:{return rt.Call(f,"com/google/common/collect/Multimaps","newListMultimap","(Ljava/util/Map;Lcom/google/common/base/Supplier;)Lcom/google/common/collect/ListMultimap;","invokestatic",21);}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",28);}
case 28:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",33);}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int==0?87:45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{f.Locals[5]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",75);}
case 75:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=78;continue;}
case 78:{return rt.Call(f,"com/google/common/collect/ListMultimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",83);}
case 83:{f.StackOp("pop");f.Pc=84;continue;}
case 84:{f.Pc=35;continue;}
case 87:{f.Push(f.Locals[3]);f.Pc=88;continue;}
case 88:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1289(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/deck/CardPool","getCardEditionStatistics","(Z)Ljava/util/Map;","invokevirtual",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",20);}
case 20:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",25);}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",34);}
case 34:{f.Pc=f.Pop().Int==0?127:37;continue;}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",44);}
case 44:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=47;continue;}
case 47:{f.Locals[5]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",56);}
case 56:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=59;continue;}
case 59:{f.Locals[6]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",68);}
case 68:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",74);}
case 74:{f.Locals[7]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[6]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;","invokevirtual",81);}
case 81:{f.Locals[8]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[8]);f.Pc=86;continue;}
case 86:{f.Push(JValue.I(0));f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",90);}
case 90:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",95);}
case 95:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",101);}
case 101:{f.Locals[9]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[9]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[7]);f.Pc=107;continue;}
case 107:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=108;continue;}
case 108:{f.Locals[9]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[2]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[8]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[9]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",118);}
case 118:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",123);}
case 123:{f.StackOp("pop");f.Pc=124;continue;}
case 124:{f.Pc=27;continue;}
case 127:{f.Push(f.Locals[2]);f.Pc=128;continue;}
case 128:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1290(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/CardPool","getCardEditionTypeStatistics","(Z)Ljava/util/Map;","invokevirtual",5);}
case 5:{f.Locals[1]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",18);}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",25);}
case 25:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",30);}
case 30:{f.Locals[4]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",39);}
case 39:{f.Pc=f.Pop().Int==0?105:42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{f.Locals[5]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[5]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",61);}
case 61:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",67);}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",71);}
case 71:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?102:74;continue;}
case 74:{f.Push(f.Locals[5]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",81);}
case 81:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=84;continue;}
case 84:{f.Locals[2]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[5]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",93);}
case 93:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$Type"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",101);}
case 101:{f.StackOp("pop");f.Pc=102;continue;}
case 102:{f.Pc=32;continue;}
case 105:{f.Push(f.Locals[3]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",111);}
case 111:{f.Pc=f.Pop().Int==0?116:114;continue;}
case 114:{f.Push(JValue.R(null));f.Pc=115;continue;}
case 115:{return JStep.Return(f.Pop());}
case 116:{f.Push(f.Locals[3]);f.Pc=117;continue;}
case 117:{f.Push(JValue.I(0));f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",123);}
case 123:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$Type"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=126;continue;}
case 126:{f.Locals[4]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(JValue.I(1));f.Pc=129;continue;}
case 129:{f.Locals[5]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[5]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[3]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",139);}
case 139:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?172:142;continue;}
case 142:{f.Push(f.Locals[3]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[5]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",150);}
case 150:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$Type"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=153;continue;}
case 153:{f.Locals[6]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[6]);f.Pc=157;continue;}
case 157:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;"));f.Pc=160;continue;}
case 160:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?166:163;continue;}
case 163:{f.Push(f.Locals[6]);f.Pc=165;continue;}
case 165:{return JStep.Return(f.Pop());}
case 166:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=169;continue;}
case 169:{f.Pc=131;continue;}
case 172:{f.Push(f.Locals[4]);f.Pc=174;continue;}
case 174:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1291(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/deck/CardPool","getCardEditionStatistics","(Z)Ljava/util/Map;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",16);}
case 16:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",21);}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int==0?103:33;continue;}
case 33:{f.Push(f.Locals[4]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[5]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{f.Locals[6]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/card/CardEdition","isModern","()Z","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int==0?84:65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",73);}
case 73:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",79);}
case 79:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=80;continue;}
case 80:{f.Locals[1]=f.Pop();f.Pc=81;continue;}
case 81:{f.Pc=100;continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[5]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",92);}
case 92:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",98);}
case 98:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=99;continue;}
case 99:{f.Locals[2]=f.Pop();f.Pc=100;continue;}
case 100:{f.Pc=23;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[2]);f.Pc=105;continue;}
case 105:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?115:108;continue;}
case 108:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",111);}
case 111:{return rt.Call(f,"forge/StaticData","cardArtPreferenceIsLatest","()Z","invokevirtual",114);}
case 114:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[2]);f.Pc=117;continue;}
case 117:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?124:120;continue;}
case 120:{f.Push(JValue.I(1));f.Pc=121;continue;}
case 121:{f.Pc=125;continue;}
case 124:{f.Push(JValue.I(0));f.Pc=125;continue;}
case 125:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1292(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/deck/CardPool","getCardEditionStatistics","(Z)Ljava/util/Map;","invokevirtual",9);}
case 9:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",14);}
case 14:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",19);}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?109:29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/card/CardEdition","getBorderColor","()Lforge/card/CardEdition$BorderColor;","invokevirtual",53);}
case 53:{f.Locals[5]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;"));f.Pc=60;continue;}
case 60:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?82:63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",71);}
case 71:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",77);}
case 77:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=78;continue;}
case 78:{f.Locals[1]=f.Pop();f.Pc=79;continue;}
case 79:{f.Pc=106;continue;}
case 82:{f.Push(f.Locals[5]);f.Pc=84;continue;}
case 84:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","WHITE","Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$BorderColor","WHITE","Lforge/card/CardEdition$BorderColor;"));f.Pc=87;continue;}
case 87:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?106:90;continue;}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[4]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",98);}
case 98:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",104);}
case 104:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=105;continue;}
case 105:{f.Locals[2]=f.Pop();f.Pc=106;continue;}
case 106:{f.Pc=20;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{f.Pc=f.Pop().Int!=0?119:113;continue;}
case 113:{f.Push(f.Locals[2]);f.Pc=114;continue;}
case 114:{f.Pc=f.Pop().Int!=0?119:117;continue;}
case 117:{f.Push(JValue.R(null));f.Pc=118;continue;}
case 118:{return JStep.Return(f.Pop());}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[2]);f.Pc=121;continue;}
case 121:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?130:124;continue;}
case 124:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;"));f.Pc=127;continue;}
case 127:{f.Pc=133;continue;}
case 130:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","WHITE","Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$BorderColor","WHITE","Lforge/card/CardEdition$BorderColor;"));f.Pc=133;continue;}
case 133:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1293(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/CardPool","getCardEditionStatistics","(Z)Ljava/util/Map;","invokevirtual",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",9);}
case 9:{return rt.Call(f,"forge/StaticData","getCardArtPreference","()Lforge/card/CardDb$CardArtPreference;","invokevirtual",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardArtPreference","filterSets","Z"));f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Int==0?62:20;continue;}
case 20:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/HashMap","<init>","(Ljava/util/Map;)V","invokespecial",28);}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",37);}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.DynamicCall(f,"forge/deck/CardPool:1293:38:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardDb$CardArtPreference;)Ljava/util/function/Predicate;",43);}
case 43:{return rt.Call(f,"java/util/Set","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",48);}
case 48:{f.StackOp("pop");f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",56);}
case 56:{f.Pc=f.Pop().Int!=0?62:59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{f.Locals[2]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardArtPreference","blackBorderOnly","Z"));f.Pc=66;continue;}
case 66:{f.Pc=f.Pop().Int==0?111:69;continue;}
case 69:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=72;continue;}
case 72:{f.StackOp("dup");f.Pc=73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/HashMap","<init>","(Ljava/util/Map;)V","invokespecial",77);}
case 77:{f.Locals[4]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[4]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",86);}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{return rt.DynamicCall(f,"forge/deck/CardPool:1293:87:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardDb$CardArtPreference;)Ljava/util/function/Predicate;",92);}
case 92:{return rt.Call(f,"java/util/Set","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",97);}
case 97:{f.StackOp("pop");f.Pc=98;continue;}
case 98:{f.Push(f.Locals[4]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",105);}
case 105:{f.Pc=f.Pop().Int!=0?111:108;continue;}
case 108:{f.Push(f.Locals[4]);f.Pc=110;continue;}
case 110:{f.Locals[2]=f.Pop();f.Pc=111;continue;}
case 111:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=114;continue;}
case 114:{f.StackOp("dup");f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",118);}
case 118:{return rt.DynamicCall(f,"forge/deck/CardPool:1293:118:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",123);}
case 123:{return rt.Call(f,"com/google/common/collect/Multimaps","newListMultimap","(Ljava/util/Map;Lcom/google/common/base/Supplier;)Lcom/google/common/collect/ListMultimap;","invokestatic",126);}
case 126:{f.Locals[4]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[2]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",134);}
case 134:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",139);}
case 139:{f.Locals[5]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[5]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",148);}
case 148:{f.Pc=f.Pop().Int==0?194:151;continue;}
case 151:{f.Push(f.Locals[5]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",158);}
case 158:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=161;continue;}
case 161:{f.Locals[6]=f.Pop();f.Pc=163;continue;}
case 163:{f.Push(f.Locals[4]);f.Pc=165;continue;}
case 165:{f.Push(f.Locals[6]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",172);}
case 172:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[6]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",182);}
case 182:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=185;continue;}
case 185:{return rt.Call(f,"com/google/common/collect/ListMultimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",190);}
case 190:{f.StackOp("pop");f.Pc=191;continue;}
case 191:{f.Pc=141;continue;}
case 194:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=197;continue;}
case 197:{f.StackOp("dup");f.Pc=198;continue;}
case 198:{f.Push(f.Locals[4]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"com/google/common/collect/ListMultimap","keySet","()Ljava/util/Set;","invokeinterface",205);}
case 205:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",208);}
case 208:{f.Locals[5]=f.Pop();f.Pc=210;continue;}
case 210:{f.Push(f.Locals[5]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"java/util/Comparator","reverseOrder","()Ljava/util/Comparator;","invokestatic",215);}
case 215:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",220);}
case 220:{f.Push(JValue.F(0));f.Pc=221;continue;}
case 221:{f.Locals[6]=f.Pop();f.Pc=223;continue;}
case 223:{f.Push(JValue.I(0));f.Pc=224;continue;}
case 224:{f.Locals[7]=f.Pop();f.Pc=226;continue;}
case 226:{f.Push(f.Locals[5]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",233);}
case 233:{f.Locals[8]=f.Pop();f.Pc=235;continue;}
case 235:{f.Push(f.Locals[8]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",242);}
case 242:{f.Pc=f.Pop().Int==0?301:245;continue;}
case 245:{f.Push(f.Locals[8]);f.Pc=247;continue;}
case 247:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",252);}
case 252:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=255;continue;}
case 255:{f.Locals[9]=f.Pop();f.Pc=257;continue;}
case 257:{f.Push(f.Locals[4]);f.Pc=259;continue;}
case 259:{f.Push(f.Locals[9]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",266);}
case 266:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",271);}
case 271:{f.Locals[10]=f.Pop();f.Pc=273;continue;}
case 273:{f.Push(f.Locals[9]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",278);}
case 278:{f.Push(f.Locals[10]);f.Pc=280;continue;}
case 280:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=281;continue;}
case 281:{f.Locals[11]=f.Pop();f.Pc=283;continue;}
case 283:{f.Push(f.Locals[7]);f.Pc=285;continue;}
case 285:{f.Push(f.Locals[10]);f.Pc=287;continue;}
case 287:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=288;continue;}
case 288:{f.Locals[7]=f.Pop();f.Pc=290;continue;}
case 290:{f.Push(f.Locals[6]);f.Pc=292;continue;}
case 292:{f.Push(f.Locals[11]);f.Pc=294;continue;}
case 294:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=295;continue;}
case 295:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fadd",a,b));f.Pc=296;continue;}
case 296:{f.Locals[6]=f.Pop();f.Pc=298;continue;}
case 298:{f.Pc=235;continue;}
case 301:{f.Push(f.Locals[5]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",308);}
case 308:{f.Pc=f.Pop().Int==0?313:311;continue;}
case 311:{f.Push(JValue.R(null));f.Pc=312;continue;}
case 312:{return JStep.Return(f.Pop());}
case 313:{f.Push(f.Locals[6]);f.Pc=315;continue;}
case 315:{f.Push(JNumbers.Unary("f2i",f.Pop()));f.Pc=316;continue;}
case 316:{f.Locals[8]=f.Pop();f.Pc=318;continue;}
case 318:{f.Push(f.Locals[6]);f.Pc=320;continue;}
case 320:{f.Push(f.Locals[7]);f.Pc=322;continue;}
case 322:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=323;continue;}
case 323:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fdiv",a,b));f.Pc=324;continue;}
case 324:{f.Locals[6]=f.Pop();f.Pc=326;continue;}
case 326:{f.Push(f.Locals[5]);f.Pc=328;continue;}
case 328:{f.Push(JValue.I(0));f.Pc=329;continue;}
case 329:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",334);}
case 334:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=337;continue;}
case 337:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",340);}
case 340:{f.Locals[9]=f.Pop();f.Pc=342;continue;}
case 342:{f.Push(f.Locals[9]);f.Pc=344;continue;}
case 344:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=345;continue;}
case 345:{f.Push(f.Locals[8]);f.Pc=347;continue;}
case 347:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=348;continue;}
case 348:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fdiv",a,b));f.Pc=349;continue;}
case 349:{f.Locals[10]=f.Pop();f.Pc=351;continue;}
case 351:{f.Push(f.Locals[10]);f.Pc=353;continue;}
case 353:{f.Push(JNumbers.Unary("f2d",f.Pop()));f.Pc=354;continue;}
case 354:{f.Push(JValue.D(0.33d));f.Pc=357;continue;}
case 357:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"dcmpg",a,b));f.Pc=358;continue;}
case 358:{f.Pc=f.Pop().Int>=0?366:361;continue;}
case 361:{f.Push(f.Locals[2]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/deck/CardPool","getMedianEditionByDate","(Ljava/util/Map;)Lforge/card/CardEdition;","invokestatic",365);}
case 365:{return JStep.Return(f.Pop());}
case 366:{f.Push(f.Locals[9]);f.Pc=368;continue;}
case 368:{f.Locals[11]=f.Pop();f.Pc=370;continue;}
case 370:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=373;continue;}
case 373:{f.StackOp("dup");f.Pc=374;continue;}
case 374:{f.Push(f.Locals[4]);f.Pc=376;continue;}
case 376:{f.Push(f.Locals[11]);f.Pc=378;continue;}
case 378:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",381);}
case 381:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",386);}
case 386:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",389);}
case 389:{f.Locals[12]=f.Pop();f.Pc=391;continue;}
case 391:{f.Push(f.Locals[12]);f.Pc=393;continue;}
case 393:{return rt.DynamicCall(f,"forge/deck/CardPool:1293:393:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/Comparator;",398);}
case 398:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",403);}
case 403:{f.Push(f.Locals[1]);f.Pc=404;continue;}
case 404:{f.Push(f.Locals[0]);f.Pc=405;continue;}
case 405:{return rt.Call(f,"forge/deck/CardPool","isModern","()Z","invokevirtual",408);}
case 408:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?415:411;continue;}
case 411:{f.Push(JValue.I(1));f.Pc=412;continue;}
case 412:{f.Pc=416;continue;}
case 415:{f.Push(JValue.I(0));f.Pc=416;continue;}
case 416:{f.Locals[13]=f.Pop();f.Pc=418;continue;}
case 418:{f.Push(f.Locals[13]);f.Pc=420;continue;}
case 420:{f.Pc=f.Pop().Int!=0?428:423;continue;}
case 423:{f.Push(f.Locals[12]);f.Pc=425;continue;}
case 425:{return rt.Call(f,"java/util/Collections","reverse","(Ljava/util/List;)V","invokestatic",428);}
case 428:{f.Push(f.Locals[12]);f.Pc=430;continue;}
case 430:{f.Push(JValue.I(0));f.Pc=431;continue;}
case 431:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",436);}
case 436:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=439;continue;}
case 439:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1294(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",6);}
case 6:{f.Pc=f.Pop().Int==0?11:9;continue;}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
case 11:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",21);}
case 21:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",24);}
case 24:{f.Locals[1]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.DynamicCall(f,"forge/deck/CardPool:1294:26:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/Comparator;",31);}
case 31:{return rt.Call(f,"java/util/Map$Entry","comparingByKey","(Ljava/util/Comparator;)Ljava/util/Comparator;","invokestatic",34);}
case 34:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",39);}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{f.Locals[2]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",47);}
case 47:{f.Locals[3]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",54);}
case 54:{f.Pc=f.Pop().Int==0?87:57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{f.Locals[4]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",76);}
case 76:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",82);}
case 82:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=83;continue;}
case 83:{f.Locals[2]=f.Pop();f.Pc=84;continue;}
case 84:{f.Pc=48;continue;}
case 87:{f.Push(f.Locals[2]);f.Pc=88;continue;}
case 88:{f.Push(JValue.I(1));f.Pc=89;continue;}
case 89:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=90;continue;}
case 90:{f.Push(JValue.I(2));f.Pc=91;continue;}
case 91:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"idiv",a,b));f.Pc=92;continue;}
case 92:{f.Locals[3]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(JValue.I(0));f.Pc=94;continue;}
case 94:{f.Locals[4]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",102);}
case 102:{f.Locals[5]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[5]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",111);}
case 111:{f.Pc=f.Pop().Int==0?164:114;continue;}
case 114:{f.Push(f.Locals[5]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",121);}
case 121:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=124;continue;}
case 124:{f.Locals[6]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[4]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[6]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",135);}
case 135:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",141);}
case 141:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=142;continue;}
case 142:{f.Locals[4]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[4]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[3]);f.Pc=147;continue;}
case 147:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?161:150;continue;}
case 150:{f.Push(f.Locals[6]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",157);}
case 157:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=160;continue;}
case 160:{return JStep.Return(f.Pop());}
case 161:{f.Pc=104;continue;}
case 164:{f.Push(f.Locals[1]);f.Pc=165;continue;}
case 165:{f.Push(f.Locals[1]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",171);}
case 171:{f.Push(JValue.I(1));f.Pc=172;continue;}
case 172:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",178);}
case 178:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",186);}
case 186:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=189;continue;}
case 189:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1295(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",13);}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=17;continue;}
case 17:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fsub",a,b));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/Math","abs","(F)F","invokestatic",21);}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(JValue.I(1));f.Pc=23;continue;}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",33);}
case 33:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?81:36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",44);}
case 44:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",50);}
case 50:{f.Locals[5]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[5]);f.Pc=55;continue;}
case 55:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=56;continue;}
case 56:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fsub",a,b));f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/Math","abs","(F)F","invokestatic",60);}
case 60:{f.Locals[6]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[6]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fcmpg",a,b));f.Pc=66;continue;}
case 66:{f.Pc=f.Pop().Int>=0?75:69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{f.Locals[2]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[6]);f.Pc=74;continue;}
case 74:{f.Locals[3]=f.Pop();f.Pc=75;continue;}
case 75:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=78;continue;}
case 78:{f.Pc=25;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1296(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/CardPool","isEmpty","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?11:7;continue;}
case 7:{f.Push(JValue.R(rt.String("[]")));f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(JValue.I(91));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",27);}
case 27:{f.StackOp("pop");f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",32);}
case 32:{f.Locals[3]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",39);}
case 39:{f.Pc=f.Pop().Int==0?107:42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{f.Locals[4]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Pc=f.Pop().Int==0?62:57;continue;}
case 57:{f.Push(JValue.I(0));f.Pc=58;continue;}
case 58:{f.Locals[1]=f.Pop();f.Pc=59;continue;}
case 59:{f.Pc=70;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String(", ")));f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",69);}
case 69:{f.StackOp("pop");f.Pc=70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[4]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",78);}
case 78:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",81);}
case 81:{f.Push(JValue.R(rt.String(" x ")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",87);}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",94);}
case 94:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",100);}
case 100:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",103);}
case 103:{f.StackOp("pop");f.Pc=104;continue;}
case 104:{f.Pc=33;continue;}
case 107:{f.Push(f.Locals[2]);f.Pc=108;continue;}
case 108:{f.Push(JValue.I(93));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",113);}
case 113:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",116);}
case 116:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1297(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/deck/CardPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/CardPool")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/CardPool","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference!=null?14:12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/deck/CardPool","processCardList","(Ljava/lang/Iterable;)Ljava/util/List;","invokestatic",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",25);}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?80:35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{f.Locals[5]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",61);}
case 61:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",67);}
case 67:{f.Locals[6]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[5]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[6]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/deck/CardPool","add","(Ljava/lang/String;I)V","invokevirtual",77);}
case 77:{f.Pc=26;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1298(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isBlank","(Ljava/lang/CharSequence;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int==0?15:7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"forge/deck/CardPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/CardPool")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/deck/CardPool","<init>","()V","invokespecial",14);}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",19);}
case 19:{return rt.Call(f,"forge/deck/CardPool","fromCardList","(Ljava/lang/Iterable;)Lforge/deck/CardPool;","invokestatic",22);}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1299(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference!=null?14:12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int==0?153:30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{f.Locals[3]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String(";")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int!=0?21:50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("#")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?63:60;continue;}
case 60:{f.Pc=21;continue;}
case 63:{if(!rt.StaticReady(f,"forge/deck/CardPool","p","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/CardPool","p","Ljava/util/regex/Pattern;"));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",70);}
case 70:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",73);}
case 73:{f.Locals[4]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",80);}
case 80:{f.Locals[5]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[5]);f.Pc=84;continue;}
case 84:{f.Pc=f.Pop().Int!=0?90:87;continue;}
case 87:{f.Pc=21;continue;}
case 90:{f.Push(f.Locals[4]);f.Pc=92;continue;}
case 92:{f.Push(JValue.I(2));f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",96);}
case 96:{f.Locals[6]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[4]);f.Pc=100;continue;}
case 100:{f.Push(JValue.I(3));f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",104);}
case 104:{f.Locals[7]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(f.Locals[7]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isBlank","(Ljava/lang/CharSequence;)Z","invokestatic",111);}
case 111:{f.Pc=f.Pop().Int==0?117:114;continue;}
case 114:{f.Pc=21;continue;}
case 117:{f.Push(f.Locals[6]);f.Pc=119;continue;}
case 119:{f.Pc=f.Pop().Reference!=null?126:122;continue;}
case 122:{f.Push(JValue.I(1));f.Pc=123;continue;}
case 123:{f.Pc=131;continue;}
case 126:{f.Push(f.Locals[6]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",131);}
case 131:{f.Locals[8]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[7]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[8]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",141);}
case 141:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",144);}
case 144:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",149);}
case 149:{f.StackOp("pop");f.Pc=150;continue;}
case 150:{f.Pc=21;continue;}
case 153:{f.Push(f.Locals[1]);f.Pc=154;continue;}
case 154:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1300(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map$Entry","comparingByKey","()Ljava/util/Comparator;","invokestatic",9);}
case 9:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",14);}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",20);}
case 20:{return rt.DynamicCall(f,"forge/deck/CardPool:1300:20:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",25);}
case 25:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",30);}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/stream/Collectors","joining","(Ljava/lang/CharSequence;)Ljava/util/stream/Collector;","invokestatic",34);}
case 34:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1301(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/deck/CardPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/CardPool")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/CardPool","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/deck/CardPool","items","Ljava/util/Map;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",17);}
case 17:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?80:32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[4]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[4]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",51);}
case 51:{f.Pc=f.Pop().Int==0?77:54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/deck/CardPool","items","Ljava/util/Map;"));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[4]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",68);}
case 68:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",74);}
case 74:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;I)V","invokevirtual",77);}
case 77:{f.Pc=23;continue;}
case 80:{f.Push(f.Locals[2]);f.Pc=81;continue;}
case 81:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1302(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/CardPool","getFilteredPool","(Ljava/util/function/Predicate;)Lforge/deck/CardPool;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1303(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",6);}
case 6:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",15);}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/card/CardDb$CardRequest","compose","(Lforge/item/PaperCard;)Ljava/lang/String;","invokestatic",21);}
case 21:{return rt.DynamicCall(f,"forge/deck/CardPool:1303:21:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",26);}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1304(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","getEditionRank","(Lforge/card/CardEdition;)I","invokevirtual",5);}
case 5:{f.Push(JValue.I(2));f.Pc=6;continue;}
case 6:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?13:9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{f.Pc=14;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1305(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","acceptsSetType","(Lforge/card/CardEdition;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int!=0?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1306(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1307(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1308(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("((\\d+)\\s+)?(.*?)")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",6);}
case 6:{if(!rt.StaticReady(f,"forge/deck/CardPool","p","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/deck/CardPool","p","Ljava/util/regex/Pattern;",f.Pop());f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

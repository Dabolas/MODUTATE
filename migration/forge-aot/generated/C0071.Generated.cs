// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C71{
internal static JClass Build(){var c=new JClass("forge/card/PrintSheet","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("cardsWithWeights","Lforge/util/ItemPool;",false,JValue.Default("Lforge/util/ItemPool;"),null));
c.Add(new JField("name","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(1155,"forge/card/PrintSheet","initializePrintSheets","(Ljava/io/File;Lforge/card/CardEdition$Collection;)Lforge/util/storage/IStorage;",25,7,6,new JHandler[]{},M1155));
c.Add(new JMethod(1156,"forge/card/PrintSheet","<init>","(Ljava/lang/String;)V",1,2,3,new JHandler[]{},M1156));
c.Add(new JMethod(1157,"forge/card/PrintSheet","<init>","(Ljava/lang/String;Lforge/util/ItemPool;)V",1,5,4,new JHandler[]{},M1157));
c.Add(new JMethod(1158,"forge/card/PrintSheet","add","(Lforge/item/PaperCard;)V",1,2,3,new JHandler[]{},M1158));
c.Add(new JMethod(1159,"forge/card/PrintSheet","add","(Lforge/item/PaperCard;I)V",1,3,3,new JHandler[]{},M1159));
c.Add(new JMethod(1160,"forge/card/PrintSheet","addAll","(Ljava/lang/Iterable;)V",1,2,3,new JHandler[]{},M1160));
c.Add(new JMethod(1161,"forge/card/PrintSheet","addAll","(Ljava/lang/Iterable;I)V",1,5,3,new JHandler[]{},M1161));
c.Add(new JMethod(1162,"forge/card/PrintSheet","copyWithoutNames","(Ljava/util/Collection;)Lforge/card/PrintSheet;",1,5,3,new JHandler[]{},M1162));
c.Add(new JMethod(1163,"forge/card/PrintSheet","removeAll","(Ljava/lang/Iterable;)V",1,4,2,new JHandler[]{},M1163));
c.Add(new JMethod(1164,"forge/card/PrintSheet","contains","(Lforge/item/PaperCard;)Z",1,2,2,new JHandler[]{},M1164));
c.Add(new JMethod(1165,"forge/card/PrintSheet","find","(Ljava/util/function/Predicate;)Lforge/item/PaperCard;",1,2,2,new JHandler[]{},M1165));
c.Add(new JMethod(1166,"forge/card/PrintSheet","fetchRoulette","(IILjava/util/Collection;)Lforge/item/PaperCard;",2,8,4,new JHandler[]{},M1166));
c.Add(new JMethod(1167,"forge/card/PrintSheet","getName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1167));
c.Add(new JMethod(1168,"forge/card/PrintSheet","random","(IZ)Ljava/util/List;",1,10,4,new JHandler[]{},M1168));
c.Add(new JMethod(1169,"forge/card/PrintSheet","isEmpty","()Z",1,1,1,new JHandler[]{},M1169));
c.Add(new JMethod(1170,"forge/card/PrintSheet","toFlatList","()Ljava/util/List;",1,1,1,new JHandler[]{},M1170));
c.Add(new JMethod(1171,"forge/card/PrintSheet","toNameLookup","()Ljava/util/Map;",1,1,1,new JHandler[]{},M1171));
}

internal static JStep M1155(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/storage/StorageExtendable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/storage/StorageExtendable")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Special print runs")));f.Pc=6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"forge/card/PrintSheet$Reader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/PrintSheet$Reader")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/PrintSheet$Reader","<init>","(Ljava/io/File;)V","invokespecial",14);}
case 14:{return rt.Call(f,"forge/util/storage/StorageExtendable","<init>","(Ljava/lang/String;Lforge/util/IItemReader;)V","invokespecial",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/card/CardEdition$Collection","iterator","()Ljava/util/Iterator;","invokevirtual",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?96:32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[4]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/card/CardEdition","getPrintSheetsBySection","()Ljava/util/List;","invokevirtual",48);}
case 48:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",53);}
case 53:{f.Locals[5]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",62);}
case 62:{f.Pc=f.Pop().Int==0?93:65;continue;}
case 65:{f.Push(f.Locals[5]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",72);}
case 72:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/PrintSheet"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=75;continue;}
case 75:{f.Locals[6]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[6]);f.Pc=80;continue;}
case 80:{f.Push(rt.GetField(f.Pop(),"forge/card/PrintSheet","name","Ljava/lang/String;"));f.Pc=83;continue;}
case 83:{f.Push(f.Locals[6]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/util/storage/IStorage","add","(Ljava/lang/String;Ljava/lang/Object;)V","invokeinterface",90);}
case 90:{f.Pc=55;continue;}
case 93:{f.Pc=23;continue;}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1156(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/PrintSheet","<init>","(Ljava/lang/String;Lforge/util/ItemPool;)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1157(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/PrintSheet","name","Ljava/lang/String;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{if(!rt.EnsureInitialized(f,"forge/util/ItemPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/ItemPool")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.ClassObject("forge/item/PaperCard")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/util/ItemPool","<init>","(Ljava/lang/Class;)V","invokespecial",19);}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/PrintSheet","cardsWithWeights","Lforge/util/ItemPool;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Reference==null?81:26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/util/ItemPool","iterator","()Ljava/util/Iterator;","invokevirtual",30);}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?81:40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[4]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",59);}
case 59:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",69);}
case 69:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",75);}
case 75:{return rt.Call(f,"forge/card/PrintSheet","add","(Lforge/item/PaperCard;I)V","invokevirtual",78);}
case 78:{f.Pc=31;continue;}
case 81:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1158(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(1));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/PrintSheet","add","(Lforge/item/PaperCard;I)V","invokevirtual",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1159(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?21:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Reference==null?21:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",15);}
case 15:{return rt.Call(f,"forge/card/CardRules","isUnsupported","()Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?22:21;continue;}
case 21:{return JStep.ReturnVoid;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/card/PrintSheet","cardsWithWeights","Lforge/util/ItemPool;"));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/util/ItemPool","add","(Lforge/item/InventoryItem;I)V","invokevirtual",31);}
case 31:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1160(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(1));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/PrintSheet","addAll","(Ljava/lang/Iterable;I)V","invokevirtual",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1161(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?37:16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/card/PrintSheet","add","(Lforge/item/PaperCard;I)V","invokevirtual",34);}
case 34:{f.Pc=7;continue;}
case 37:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1162(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?13:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?15:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
case 15:{if(!rt.EnsureInitialized(f,"forge/card/PrintSheet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/PrintSheet")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/card/PrintSheet","name","Ljava/lang/String;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/card/PrintSheet","<init>","(Ljava/lang/String;)V","invokespecial",26);}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/card/PrintSheet","cardsWithWeights","Lforge/util/ItemPool;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/util/ItemPool","iterator","()Ljava/util/Iterator;","invokevirtual",34);}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",41);}
case 41:{f.Pc=f.Pop().Int==0?107:44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{f.Locals[4]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",69);}
case 69:{return rt.Call(f,"java/util/Collection","contains","(Ljava/lang/Object;)Z","invokeinterface",74);}
case 74:{f.Pc=f.Pop().Int!=0?104:77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[4]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",85);}
case 85:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[4]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",95);}
case 95:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",101);}
case 101:{return rt.Call(f,"forge/card/PrintSheet","add","(Lforge/item/PaperCard;I)V","invokevirtual",104);}
case 104:{f.Pc=35;continue;}
case 107:{f.Push(f.Locals[2]);f.Pc=108;continue;}
case 108:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1163(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?38:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/card/PrintSheet","cardsWithWeights","Lforge/util/ItemPool;"));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/util/ItemPool","remove","(Lforge/item/InventoryItem;)Z","invokevirtual",34);}
case 34:{f.StackOp("pop");f.Pc=35;continue;}
case 35:{f.Pc=7;continue;}
case 38:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1164(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/PrintSheet","cardsWithWeights","Lforge/util/ItemPool;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/ItemPool","contains","(Lforge/item/InventoryItem;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1165(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/PrintSheet","cardsWithWeights","Lforge/util/ItemPool;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/ItemPool","find","(Ljava/util/function/Predicate;)Lforge/item/InventoryItem;","invokevirtual",8);}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1166(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Locals[4]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int<=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{f.Locals[5]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/card/PrintSheet","cardsWithWeights","Lforge/util/ItemPool;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/ItemPool","iterator","()Ljava/util/Iterator;","invokevirtual",21);}
case 21:{f.Locals[6]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[6]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int==0?106:33;continue;}
case 33:{f.Push(f.Locals[6]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[7]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[7]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",54);}
case 54:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",60);}
case 60:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=61;continue;}
case 61:{f.Locals[4]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?103:69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{f.Pc=f.Pop().Reference==null?92:73;continue;}
case 73:{f.Push(f.Locals[3]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[7]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",81);}
case 81:{return rt.Call(f,"java/util/Collection","contains","(Ljava/lang/Object;)Z","invokeinterface",86);}
case 86:{f.Pc=f.Pop().Int==0?92:89;continue;}
case 89:{f.Pc=23;continue;}
case 92:{f.Push(f.Locals[7]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",99);}
case 99:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=102;continue;}
case 102:{return JStep.Return(f.Pop());}
case 103:{f.Pc=23;continue;}
case 106:{f.Push(f.Locals[5]);f.Pc=108;continue;}
case 108:{f.Pc=f.Pop().Int==0?121:111;continue;}
case 111:{if(!rt.EnsureInitialized(f,"java/lang/IllegalStateException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalStateException")));f.Pc=114;continue;}
case 114:{f.StackOp("dup");f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.String("Print sheet does not have enough unique cards")));f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/lang/IllegalStateException","<init>","(Ljava/lang/String;)V","invokespecial",120);}
case 120:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[4]);f.Pc=124;continue;}
case 124:{f.Push(JValue.I(1));f.Pc=125;continue;}
case 125:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=126;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[3]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/card/PrintSheet","fetchRoulette","(IILjava/util/Collection;)Lforge/item/PaperCard;","invokevirtual",131);}
case 131:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1167(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/PrintSheet","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1168(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/card/PrintSheet","cardsWithWeights","Lforge/util/ItemPool;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/util/ItemPool","countAll","()I","invokevirtual",15);}
case 15:{f.Locals[4]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[4]);f.Pc=19;continue;}
case 19:{f.Pc=f.Pop().Int!=0?39:22;continue;}
case 22:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/card/PrintSheet","name","Ljava/lang/String;"));f.Pc=29;continue;}
case 29:{return rt.DynamicCall(f,"forge/card/PrintSheet:1168:29:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",34);}
case 34:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",37);}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return JStep.Return(f.Pop());}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/card/PrintSheet","cardsWithWeights","Lforge/util/ItemPool;"));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/util/ItemPool","countDistinct","()I","invokevirtual",46);}
case 46:{f.Locals[5]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?113:54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(rt.GetField(f.Pop(),"forge/card/PrintSheet","cardsWithWeights","Lforge/util/ItemPool;"));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/util/ItemPool","iterator","()Ljava/util/Iterator;","invokevirtual",61);}
case 61:{f.Locals[6]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[6]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",70);}
case 70:{f.Pc=f.Pop().Int==0?105:73;continue;}
case 73:{f.Push(f.Locals[6]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",80);}
case 80:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=83;continue;}
case 83:{f.Locals[7]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[7]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",93);}
case 93:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",101);}
case 101:{f.StackOp("pop");f.Pc=102;continue;}
case 102:{f.Pc=63;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[5]);f.Pc=108;continue;}
case 108:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=109;continue;}
case 109:{f.Locals[1]=f.Pop();f.Pc=110;continue;}
case 110:{f.Pc=48;continue;}
case 113:{f.Push(f.Locals[2]);f.Pc=114;continue;}
case 114:{f.Pc=f.Pop().Int==0?127:117;continue;}
case 117:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=120;continue;}
case 120:{f.StackOp("dup");f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",124);}
case 124:{f.Pc=128;continue;}
case 127:{f.Push(JValue.R(null));f.Pc=128;continue;}
case 128:{f.Locals[6]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(JValue.I(0));f.Pc=131;continue;}
case 131:{f.Locals[7]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(f.Locals[7]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[1]);f.Pc=136;continue;}
case 136:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?197:139;continue;}
case 139:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",142);}
case 142:{f.Push(f.Locals[4]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",147);}
case 147:{f.Locals[8]=f.Pop();f.Pc=149;continue;}
case 149:{f.Push(f.Locals[0]);f.Pc=150;continue;}
case 150:{f.Push(JValue.I(0));f.Pc=151;continue;}
case 151:{f.Push(f.Locals[8]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[2]);f.Pc=154;continue;}
case 154:{f.Pc=f.Pop().Int==0?162:157;continue;}
case 157:{f.Push(f.Locals[6]);f.Pc=159;continue;}
case 159:{f.Pc=163;continue;}
case 162:{f.Push(JValue.R(null));f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/card/PrintSheet","fetchRoulette","(IILjava/util/Collection;)Lforge/item/PaperCard;","invokevirtual",166);}
case 166:{f.Locals[9]=f.Pop();f.Pc=168;continue;}
case 168:{f.Push(f.Locals[3]);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[9]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",176);}
case 176:{f.StackOp("pop");f.Pc=177;continue;}
case 177:{f.Push(f.Locals[2]);f.Pc=178;continue;}
case 178:{f.Pc=f.Pop().Int==0?191:181;continue;}
case 181:{f.Push(f.Locals[6]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[9]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",190);}
case 190:{f.StackOp("pop");f.Pc=191;continue;}
case 191:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=194;continue;}
case 194:{f.Pc=133;continue;}
case 197:{f.Push(f.Locals[3]);f.Pc=198;continue;}
case 198:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1169(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/PrintSheet","cardsWithWeights","Lforge/util/ItemPool;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/ItemPool","isEmpty","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1170(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/PrintSheet","cardsWithWeights","Lforge/util/ItemPool;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/ItemPool","toFlatList","()Ljava/util/List;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1171(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/PrintSheet","cardsWithWeights","Lforge/util/ItemPool;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/ItemPool","toNameLookup","()Ljava/util/Map;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

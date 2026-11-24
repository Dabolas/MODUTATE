// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C144{
internal static JClass Build(){var c=new JClass("forge/game/GameFormat$Collection","forge/util/storage/StorageBase",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("naturallyOrdered","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("reverseDateOrdered","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("formatsTypeMap","Ljava/util/TreeMap;",false,JValue.Default("Ljava/util/TreeMap;"),null));
c.Add(new JMethod(2308,"forge/game/GameFormat$Collection","<init>","(Lforge/game/GameFormat$Reader;)V",1,2,4,new JHandler[]{},M2308));
c.Add(new JMethod(2309,"forge/game/GameFormat$Collection","getOrderedList","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M2309));
c.Add(new JMethod(2310,"forge/game/GameFormat$Collection","getReverseDateOrderedList","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M2310));
c.Add(new JMethod(2311,"forge/game/GameFormat$Collection","getFormatTypeMap","()Ljava/util/Map;",17,5,4,new JHandler[]{},M2311));
c.Add(new JMethod(2312,"forge/game/GameFormat$Collection","getSanctionedList","()Ljava/lang/Iterable;",1,4,2,new JHandler[]{},M2312));
c.Add(new JMethod(2313,"forge/game/GameFormat$Collection","getFilterList","()Ljava/lang/Iterable;",1,4,2,new JHandler[]{},M2313));
c.Add(new JMethod(2314,"forge/game/GameFormat$Collection","getArchivedList","()Ljava/lang/Iterable;",1,4,2,new JHandler[]{},M2314));
c.Add(new JMethod(2315,"forge/game/GameFormat$Collection","getCasualList","()Ljava/lang/Iterable;",1,4,2,new JHandler[]{},M2315));
c.Add(new JMethod(2316,"forge/game/GameFormat$Collection","getCoreFormatsWithLimitedSets","()Ljava/lang/Iterable;",1,4,2,new JHandler[]{},M2316));
c.Add(new JMethod(2317,"forge/game/GameFormat$Collection","getBlockList","()Ljava/lang/Iterable;",1,4,2,new JHandler[]{},M2317));
c.Add(new JMethod(2318,"forge/game/GameFormat$Collection","getArchivedMap","()Ljava/util/Map;",1,5,4,new JHandler[]{},M2318));
c.Add(new JMethod(2319,"forge/game/GameFormat$Collection","getStandard","()Lforge/game/GameFormat;",1,1,2,new JHandler[]{},M2319));
c.Add(new JMethod(2320,"forge/game/GameFormat$Collection","getExtended","()Lforge/game/GameFormat;",1,1,2,new JHandler[]{},M2320));
c.Add(new JMethod(2321,"forge/game/GameFormat$Collection","getPioneer","()Lforge/game/GameFormat;",1,1,2,new JHandler[]{},M2321));
c.Add(new JMethod(2322,"forge/game/GameFormat$Collection","getHistoric","()Lforge/game/GameFormat;",1,1,2,new JHandler[]{},M2322));
c.Add(new JMethod(2323,"forge/game/GameFormat$Collection","getModern","()Lforge/game/GameFormat;",1,1,2,new JHandler[]{},M2323));
c.Add(new JMethod(2324,"forge/game/GameFormat$Collection","getLegacy","()Lforge/game/GameFormat;",1,1,2,new JHandler[]{},M2324));
c.Add(new JMethod(2325,"forge/game/GameFormat$Collection","getVintage","()Lforge/game/GameFormat;",1,1,2,new JHandler[]{},M2325));
c.Add(new JMethod(2326,"forge/game/GameFormat$Collection","getPremodern","()Lforge/game/GameFormat;",1,1,2,new JHandler[]{},M2326));
c.Add(new JMethod(2327,"forge/game/GameFormat$Collection","getPauper","()Lforge/game/GameFormat;",1,1,2,new JHandler[]{},M2327));
c.Add(new JMethod(2328,"forge/game/GameFormat$Collection","getFormat","(Ljava/lang/String;)Lforge/game/GameFormat;",1,2,2,new JHandler[]{},M2328));
c.Add(new JMethod(2329,"forge/game/GameFormat$Collection","getFormatOfDeck","(Lforge/deck/Deck;)Lforge/game/GameFormat;",1,4,2,new JHandler[]{},M2329));
c.Add(new JMethod(2330,"forge/game/GameFormat$Collection","getAllFormatsOfCard","(Lforge/item/PaperCard;)Ljava/util/Set;",1,5,2,new JHandler[]{},M2330));
c.Add(new JMethod(2331,"forge/game/GameFormat$Collection","getAllFormatsOfDeck","(Lforge/deck/Deck;)Ljava/util/Set;",1,2,3,new JHandler[]{},M2331));
c.Add(new JMethod(2332,"forge/game/GameFormat$Collection","getAllFormatsOfDeck","(Lforge/deck/Deck;Ljava/lang/Boolean;)Ljava/util/Set;",1,8,3,new JHandler[]{},M2332));
c.Add(new JMethod(2333,"forge/game/GameFormat$Collection","add","(Lforge/game/GameFormat;)V",1,2,2,new JHandler[]{},M2333));
c.Add(new JMethod(2334,"forge/game/GameFormat$Collection","add","(Ljava/lang/Object;)V",4161,2,2,new JHandler[]{},M2334));
}

internal static JStep M2308(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Format collections")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/storage/StorageBase","<init>","(Ljava/lang/String;Lforge/util/IItemReader;)V","invokespecial",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Reader","naturallyOrdered","Ljava/util/List;"));f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$Collection","naturallyOrdered","Ljava/util/List;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","naturallyOrdered","Ljava/util/List;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",27);}
case 27:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$Collection","reverseDateOrdered","Ljava/util/List;",value);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","naturallyOrdered","Ljava/util/List;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Comparator","naturalOrder","()Ljava/util/Comparator;","invokestatic",37);}
case 37:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",42);}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","reverseDateOrdered","Ljava/util/List;"));f.Pc=46;continue;}
case 46:{if(!rt.EnsureInitialized(f,"forge/game/GameFormat$InverseDateComparator"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameFormat$InverseDateComparator")));f.Pc=49;continue;}
case 49:{f.StackOp("dup");f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/GameFormat$InverseDateComparator","<init>","()V","invokespecial",53);}
case 53:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",58);}
case 58:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2309(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","naturallyOrdered","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2310(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","reverseDateOrdered","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2311(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","formatsTypeMap","Ljava/util/TreeMap;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?119:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"java/util/TreeMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeMap")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/TreeMap","<init>","()V","invokespecial",15);}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameFormat$Collection","formatsTypeMap","Ljava/util/TreeMap;",value);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/GameFormat$FormatType","values","()[Lforge/game/GameFormat$FormatType;","invokestatic",21);}
case 21:{f.Locals[1]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=24;continue;}
case 24:{f.Locals[2]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?60:32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=35;continue;}
case 35:{f.Locals[4]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","formatsTypeMap","Ljava/util/TreeMap;"));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=46;continue;}
case 46:{f.StackOp("dup");f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",50);}
case 50:{return rt.Call(f,"java/util/TreeMap","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",53);}
case 53:{f.StackOp("pop");f.Pc=54;continue;}
case 54:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=57;continue;}
case 57:{f.Pc=27;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","naturallyOrdered","Ljava/util/List;"));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",69);}
case 69:{f.Locals[1]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",76);}
case 76:{f.Pc=f.Pop().Int==0?119:79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",85);}
case 85:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=88;continue;}
case 88:{f.Locals[2]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[2]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/GameFormat","getFormatType","()Lforge/game/GameFormat$FormatType;","invokevirtual",93);}
case 93:{f.Locals[3]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","formatsTypeMap","Ljava/util/TreeMap;"));f.Pc=98;continue;}
case 98:{f.Push(f.Locals[3]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/TreeMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",102);}
case 102:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=105;continue;}
case 105:{f.Locals[4]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[4]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[2]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",115);}
case 115:{f.StackOp("pop");f.Pc=116;continue;}
case 116:{f.Pc=70;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","formatsTypeMap","Ljava/util/TreeMap;"));f.Pc=123;continue;}
case 123:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2312(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","naturallyOrdered","Ljava/util/List;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?61:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/GameFormat","getFormatType","()Lforge/game/GameFormat$FormatType;","invokevirtual",41);}
case 41:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatType","SANCTIONED","Lforge/game/GameFormat$FormatType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatType","SANCTIONED","Lforge/game/GameFormat$FormatType;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/GameFormat$FormatType","equals","(Ljava/lang/Object;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?58:50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",57);}
case 57:{f.StackOp("pop");f.Pc=58;continue;}
case 58:{f.Pc=18;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2313(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","naturallyOrdered","Ljava/util/List;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?74:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/GameFormat","getFormatType","()Lforge/game/GameFormat$FormatType;","invokevirtual",41);}
case 41:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatType","ARCHIVED","Lforge/game/GameFormat$FormatType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatType","ARCHIVED","Lforge/game/GameFormat$FormatType;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/GameFormat$FormatType","equals","(Ljava/lang/Object;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int!=0?71:50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/GameFormat","getFormatType","()Lforge/game/GameFormat$FormatType;","invokevirtual",54);}
case 54:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatType","DIGITAL","Lforge/game/GameFormat$FormatType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatType","DIGITAL","Lforge/game/GameFormat$FormatType;"));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/GameFormat$FormatType","equals","(Ljava/lang/Object;)Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int!=0?71:63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",70);}
case 70:{f.StackOp("pop");f.Pc=71;continue;}
case 71:{f.Pc=18;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2314(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","naturallyOrdered","Ljava/util/List;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?61:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/GameFormat","getFormatType","()Lforge/game/GameFormat$FormatType;","invokevirtual",41);}
case 41:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatType","ARCHIVED","Lforge/game/GameFormat$FormatType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatType","ARCHIVED","Lforge/game/GameFormat$FormatType;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/GameFormat$FormatType","equals","(Ljava/lang/Object;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?58:50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",57);}
case 57:{f.StackOp("pop");f.Pc=58;continue;}
case 58:{f.Pc=18;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2315(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","naturallyOrdered","Ljava/util/List;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?61:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/GameFormat","getFormatType","()Lforge/game/GameFormat$FormatType;","invokevirtual",41);}
case 41:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatType","CASUAL","Lforge/game/GameFormat$FormatType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatType","CASUAL","Lforge/game/GameFormat$FormatType;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/GameFormat$FormatType","equals","(Ljava/lang/Object;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?58:50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",57);}
case 57:{f.StackOp("pop");f.Pc=58;continue;}
case 58:{f.Pc=18;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2316(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","naturallyOrdered","Ljava/util/List;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?60:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/GameFormat","getAllowedSetCodes","()Ljava/util/List;","invokevirtual",41);}
case 41:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",46);}
case 46:{f.Pc=f.Pop().Int<=0?57:49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",56);}
case 56:{f.StackOp("pop");f.Pc=57;continue;}
case 57:{f.Pc=18;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2317(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/GameFormat$Collection","getArchivedList","()Ljava/lang/Iterable;","invokevirtual",12);}
case 12:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?76:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/GameFormat","getFormatSubType","()Lforge/game/GameFormat$FormatSubType;","invokevirtual",41);}
case 41:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","BLOCK","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatSubType","BLOCK","Lforge/game/GameFormat$FormatSubType;"));f.Pc=44;continue;}
case 44:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?50:47;continue;}
case 47:{f.Pc=18;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/GameFormat","getName","()Ljava/lang/String;","invokevirtual",54);}
case 54:{f.Push(JValue.R(rt.String("Block")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int!=0?65:62;continue;}
case 62:{f.Pc=18;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",72);}
case 72:{f.StackOp("pop");f.Pc=73;continue;}
case 73:{f.Pc=18;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/Collections","sort","(Ljava/util/List;)V","invokestatic",80);}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2318(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","naturallyOrdered","Ljava/util/List;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?109:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/GameFormat","getFormatType","()Lforge/game/GameFormat$FormatType;","invokevirtual",41);}
case 41:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatType","ARCHIVED","Lforge/game/GameFormat$FormatType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatType","ARCHIVED","Lforge/game/GameFormat$FormatType;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/GameFormat$FormatType","equals","(Ljava/lang/Object;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?106:50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/GameFormat","getName","()Ljava/lang/String;","invokevirtual",54);}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{f.Push(JValue.I(1));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",59);}
case 59:{f.Locals[4]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",69);}
case 69:{f.Pc=f.Pop().Int!=0?88:72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[4]);f.Pc=75;continue;}
case 75:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=78;continue;}
case 78:{f.StackOp("dup");f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",82);}
case 82:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",87);}
case 87:{f.StackOp("pop");f.Pc=88;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",96);}
case 96:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[3]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",105);}
case 105:{f.StackOp("pop");f.Pc=106;continue;}
case 106:{f.Pc=18;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2319(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","map","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Standard")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",11);}
case 11:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2320(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","map","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Extended")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",11);}
case 11:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2321(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","map","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Pioneer")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",11);}
case 11:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2322(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","map","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Historic")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",11);}
case 11:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2323(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","map","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Modern")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",11);}
case 11:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2324(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","map","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Legacy")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",11);}
case 11:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2325(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","map","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Vintage")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",11);}
case 11:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2326(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","map","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Premodern")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",11);}
case 11:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2327(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","map","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Pauper")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",11);}
case 11:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2328(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","map","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2329(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","reverseDateOrdered","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?42:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/GameFormat","isDeckLegal","(Lforge/deck/Deck;)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?39:37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return JStep.Return(f.Pop());}
case 39:{f.Pc=10;continue;}
case 42:{if(!rt.StaticReady(f,"forge/game/GameFormat","NoFormat","Lforge/game/GameFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat","NoFormat","Lforge/game/GameFormat;"));f.Pc=45;continue;}
case 45:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2330(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","naturallyOrdered","Ljava/util/List;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?64:27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/GameFormat","getFilterRules","()Ljava/util/function/Predicate;","invokevirtual",43);}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",49);}
case 49:{f.Pc=f.Pop().Int==0?61:52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[4]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",60);}
case 60:{f.StackOp("pop");f.Pc=61;continue;}
case 61:{f.Pc=18;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",70);}
case 70:{f.Pc=f.Pop().Int==0?83:73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{if(!rt.StaticReady(f,"forge/game/GameFormat","NoFormat","Lforge/game/GameFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat","NoFormat","Lforge/game/GameFormat;"));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",82);}
case 82:{f.StackOp("pop");f.Pc=83;continue;}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2331(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",6);}
case 6:{return rt.Call(f,"forge/game/GameFormat$Collection","getAllFormatsOfDeck","(Lforge/deck/Deck;Ljava/lang/Boolean;)Ljava/util/Set;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2332(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/TreeSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeSet")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/TreeSet","<init>","()V","invokespecial",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",15);}
case 15:{f.Locals[4]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/deck/Deck","getAllCardsInASinglePool","()Lforge/deck/CardPool;","invokevirtual",21);}
case 21:{f.Locals[5]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","reverseDateOrdered","Ljava/util/List;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",32);}
case 32:{f.Locals[6]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[6]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",41);}
case 41:{f.Pc=f.Pop().Int==0?172:44;continue;}
case 44:{f.Push(f.Locals[6]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{f.Locals[7]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[7]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/GameFormat","getFormatType","()Lforge/game/GameFormat$FormatType;","invokevirtual",61);}
case 61:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatType","DIGITAL","Lforge/game/GameFormat$FormatType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatType","DIGITAL","Lforge/game/GameFormat$FormatType;"));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/GameFormat$FormatType","equals","(Ljava/lang/Object;)Z","invokevirtual",67);}
case 67:{f.Pc=f.Pop().Int==0?80:70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int!=0?80:77;continue;}
case 77:{f.Pc=34;continue;}
case 80:{f.Push(f.Locals[7]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/GameFormat","getFormatSubType","()Lforge/game/GameFormat$FormatSubType;","invokevirtual",85);}
case 85:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatSubType","COMMANDER","Lforge/game/GameFormat$FormatSubType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatSubType","COMMANDER","Lforge/game/GameFormat$FormatSubType;"));f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/GameFormat$FormatSubType","equals","(Ljava/lang/Object;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?97:94;continue;}
case 94:{f.Pc=34;continue;}
case 97:{f.Push(f.Locals[7]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/GameFormat","getFormatType","()Lforge/game/GameFormat$FormatType;","invokevirtual",102);}
case 102:{if(!rt.StaticReady(f,"forge/game/GameFormat$FormatType","ARCHIVED","Lforge/game/GameFormat$FormatType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat$FormatType","ARCHIVED","Lforge/game/GameFormat$FormatType;"));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/GameFormat$FormatType","equals","(Ljava/lang/Object;)Z","invokevirtual",108);}
case 108:{f.Pc=f.Pop().Int==0?136:111;continue;}
case 111:{f.Push(f.Locals[4]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[7]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/GameFormat","getFormatSubType","()Lforge/game/GameFormat$FormatSubType;","invokevirtual",118);}
case 118:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",123);}
case 123:{f.Pc=f.Pop().Int==0?136:126;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",130);}
case 130:{f.Pc=f.Pop().Int!=0?136:133;continue;}
case 133:{f.Pc=34;continue;}
case 136:{f.Push(f.Locals[7]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[5]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/GameFormat","getDeckProblem","(Lforge/deck/Deck;Lforge/deck/CardPool;)Ljava/lang/String;","invokevirtual",144);}
case 144:{f.Pc=f.Pop().Reference!=null?169:147;continue;}
case 147:{f.Push(f.Locals[3]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[7]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/util/SortedSet","add","(Ljava/lang/Object;)Z","invokeinterface",155);}
case 155:{f.StackOp("pop");f.Pc=156;continue;}
case 156:{f.Push(f.Locals[4]);f.Pc=158;continue;}
case 158:{f.Push(f.Locals[7]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/GameFormat","getFormatSubType","()Lforge/game/GameFormat$FormatSubType;","invokevirtual",163);}
case 163:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",168);}
case 168:{f.StackOp("pop");f.Pc=169;continue;}
case 169:{f.Pc=34;continue;}
case 172:{f.Push(f.Locals[3]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/util/SortedSet","isEmpty","()Z","invokeinterface",178);}
case 178:{f.Pc=f.Pop().Int==0?191:181;continue;}
case 181:{f.Push(f.Locals[3]);f.Pc=182;continue;}
case 182:{if(!rt.StaticReady(f,"forge/game/GameFormat","NoFormat","Lforge/game/GameFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameFormat","NoFormat","Lforge/game/GameFormat;"));f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/util/SortedSet","add","(Ljava/lang/Object;)Z","invokeinterface",190);}
case 190:{f.StackOp("pop");f.Pc=191;continue;}
case 191:{f.Push(f.Locals[3]);f.Pc=192;continue;}
case 192:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2333(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameFormat$Collection","naturallyOrdered","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2334(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameFormat"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameFormat$Collection","add","(Lforge/game/GameFormat;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C0{
internal static JClass Build(){var c=new JClass("forge/CardStorageReader","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("CARD_FILE_DOT_EXTENSION","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),".txt"));
c.Add(new JField("UPCOMING","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"upcoming"));
c.Add(new JField("DEFAULT_CHARSET_NAME","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"UTF-8"));
c.Add(new JField("useThreadPool","Z",false,JValue.Default("Z"),null));
c.Add(new JField("NUMBER_OF_PARTS","I",true,JValue.I(25),null));
c.Add(new JField("progressObserver","Lforge/CardStorageReader$ProgressObserver;",false,JValue.Default("Lforge/CardStorageReader$ProgressObserver;"),null));
c.Add(new JField("loadingTokens","Z",false,JValue.Default("Z"),null));
c.Add(new JField("cardsfolder","Ljava/io/File;",false,JValue.Default("Ljava/io/File;"),null));
c.Add(new JField("zip","Ljava/util/zip/ZipFile;",false,JValue.Default("Ljava/util/zip/ZipFile;"),null));
c.Add(new JField("zipEntriesByCardName","Ljava/util/NavigableMap;",false,JValue.Default("Ljava/util/NavigableMap;"),null));
c.Add(new JField("cardFilesByCardName","Ljava/util/NavigableMap;",false,JValue.Default("Ljava/util/NavigableMap;"),null));
c.Add(new JField("charset","Ljava/nio/charset/Charset;",false,JValue.Default("Ljava/nio/charset/Charset;"),null));
c.Add(new JField("loadCardsLazily","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(0,"forge/CardStorageReader","<init>","(Ljava/lang/String;Lforge/CardStorageReader$ProgressObserver;Z)V",1,6,6,new JHandler[]{new JHandler(136,149,152,"java/lang/Exception")},M0));
c.Add(new JMethod(1,"forge/CardStorageReader","isLoadingCardsLazily","()Z",0,1,1,new JHandler[]{},M1));
c.Add(new JMethod(2,"forge/CardStorageReader","loadCardsInRange","(Ljava/util/List;II)Ljava/util/List;",2,8,4,new JHandler[]{},M2));
c.Add(new JMethod(3,"forge/CardStorageReader","loadCardsInRangeFromZip","(Ljava/util/List;II)Ljava/util/List;",2,8,4,new JHandler[]{},M3));
c.Add(new JMethod(4,"forge/CardStorageReader","transformName","(Ljava/lang/String;)Ljava/lang/String;",2,6,5,new JHandler[]{},M4));
c.Add(new JMethod(5,"forge/CardStorageReader","attemptToLoadCard","(Ljava/lang/String;)Lforge/card/CardRules;",17,6,3,new JHandler[]{},M5));
c.Add(new JMethod(6,"forge/CardStorageReader","buildCardNameIndex","(Ljava/util/List;Ljava/util/function/BiFunction;)Ljava/util/NavigableMap;",2,12,7,new JHandler[]{new JHandler(66,81,84,"java/lang/RuntimeException")},M6));
c.Add(new JMethod(7,"forge/CardStorageReader","putName","(Ljava/util/Map;Ljava/lang/String;Ljava/lang/Object;)V",2,5,3,new JHandler[]{},M7));
c.Add(new JMethod(8,"forge/CardStorageReader","primaryNamesOf","(Lforge/card/CardRules;)Ljava/util/List;",10,4,3,new JHandler[]{},M8));
c.Add(new JMethod(9,"forge/CardStorageReader","loadCards","()Ljava/lang/Iterable;",17,1,1,new JHandler[]{},M9));
c.Add(new JMethod(10,"forge/CardStorageReader","readAllCards","()Ljava/lang/Iterable;",17,10,7,new JHandler[]{},M10));
c.Add(new JMethod(11,"forge/CardStorageReader","getZipEntries","()Ljava/util/List;",2,4,2,new JHandler[]{},M11));
c.Add(new JMethod(12,"forge/CardStorageReader","executeLoadTask","(Ljava/util/Collection;Ljava/util/List;Ljava/util/concurrent/CountDownLatch;)V",2,8,3,new JHandler[]{new JHandler(0,140,143,"java/lang/InterruptedException"),new JHandler(0,140,161,"java/util/concurrent/ExecutionException"),new JHandler(0,140,171,"java/lang/Exception")},M12));
c.Add(new JMethod(13,"forge/CardStorageReader","makeTaskListForZip","(Ljava/util/List;Ljava/util/concurrent/CountDownLatch;)Ljava/util/List;",2,10,7,new JHandler[]{},M13));
c.Add(new JMethod(14,"forge/CardStorageReader","makeTaskListForFiles","(Ljava/util/List;Ljava/util/concurrent/CountDownLatch;)Ljava/util/List;",2,10,7,new JHandler[]{},M14));
c.Add(new JMethod(15,"forge/CardStorageReader","collectCardFiles","(Ljava/util/List;Ljava/io/File;)Ljava/util/List;",9,8,4,new JHandler[]{},M15));
c.Add(new JMethod(16,"forge/CardStorageReader","readScript","(Ljava/io/InputStream;)Ljava/util/List;",2,2,4,new JHandler[]{},M16));
c.Add(new JMethod(17,"forge/CardStorageReader","loadCard","(Lforge/card/CardRules$Reader;Ljava/io/File;)Lforge/card/CardRules;",20,7,4,new JHandler[]{new JHandler(12,51,62,"java/lang/Throwable"),new JHandler(68,72,75,"java/lang/Throwable"),new JHandler(0,59,87,"java/io/FileNotFoundException"),new JHandler(62,87,87,"java/io/FileNotFoundException"),new JHandler(0,59,106,"java/lang/Exception"),new JHandler(62,87,106,"java/lang/Exception")},M17));
c.Add(new JMethod(18,"forge/CardStorageReader","loadCard","(Lforge/card/CardRules$Reader;Ljava/util/zip/ZipEntry;)Lforge/card/CardRules;",20,6,3,new JHandler[]{new JHandler(9,44,55,"java/lang/Throwable"),new JHandler(61,65,68,"java/lang/Throwable"),new JHandler(0,52,80,"java/io/IOException"),new JHandler(55,80,80,"java/io/IOException")},M18));
c.Add(new JMethod(19,"forge/CardStorageReader","lambda$makeTaskListForFiles$1","(Ljava/util/List;IILjava/util/concurrent/CountDownLatch;I)Ljava/util/List;",4098,9,4,new JHandler[]{new JHandler(0,13,41,"java/lang/Exception"),new JHandler(0,13,46,""),new JHandler(41,48,46,"")},M19));
c.Add(new JMethod(20,"forge/CardStorageReader","lambda$makeTaskListForZip$0","(Ljava/util/List;IILjava/util/concurrent/CountDownLatch;I)Ljava/util/List;",4098,7,4,new JHandler[]{},M20));
}

internal static JStep M0(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/ThreadUtil","isMultiCoreSystem","()Z","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/CardStorageReader","useThreadPool","Z",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Reference==null?20:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Pc=23;continue;}
case 20:{if(!rt.StaticReady(f,"forge/CardStorageReader$ProgressObserver","emptyObserver","Lforge/CardStorageReader$ProgressObserver;"))return JStep.Continue;f.Push(rt.GetStatic("forge/CardStorageReader$ProgressObserver","emptyObserver","Lforge/CardStorageReader$ProgressObserver;"));f.Pc=23;continue;}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/CardStorageReader","progressObserver","Lforge/CardStorageReader$ProgressObserver;",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",35);}
case 35:{var value=f.Pop();rt.PutField(f.Pop(),"forge/CardStorageReader","cardsfolder","Ljava/io/File;",value);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("token")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",45);}
case 45:{var value=f.Pop();rt.PutField(f.Pop(),"forge/CardStorageReader","loadingTokens","Z",value);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{var value=f.Pop();rt.PutField(f.Pop(),"forge/CardStorageReader","loadCardsLazily","Z",value);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","cardsfolder","Ljava/io/File;"));f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/io/File","exists","()Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int!=0?83:63;continue;}
case 63:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=66;continue;}
case 66:{f.StackOp("dup");f.Pc=67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","cardsfolder","Ljava/io/File;"));f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/io/File","getAbsolutePath","()Ljava/lang/String;","invokevirtual",74);}
case 74:{return rt.DynamicCall(f,"forge/CardStorageReader:0:74:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",79);}
case 79:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",82);}
case 82:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","cardsfolder","Ljava/io/File;"));f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/io/File","isDirectory","()Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int!=0?113:93;continue;}
case 93:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=96;continue;}
case 96:{f.StackOp("dup");f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","cardsfolder","Ljava/io/File;"));f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/io/File","getAbsolutePath","()Ljava/lang/String;","invokevirtual",104);}
case 104:{return rt.DynamicCall(f,"forge/CardStorageReader:0:104:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",109);}
case 109:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",112);}
case 112:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 113:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=116;continue;}
case 116:{f.StackOp("dup");f.Pc=117;continue;}
case 117:{f.Push(f.Locals[0]);f.Pc=118;continue;}
case 118:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","cardsfolder","Ljava/io/File;"));f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("cardsfolder.zip")));f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/io/File","<init>","(Ljava/io/File;Ljava/lang/String;)V","invokespecial",126);}
case 126:{f.Locals[4]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[4]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/io/File","exists","()Z","invokevirtual",133);}
case 133:{f.Pc=f.Pop().Int==0?190:136;continue;}
case 136:{f.Push(f.Locals[0]);f.Pc=137;continue;}
case 137:{if(!rt.EnsureInitialized(f,"java/util/zip/ZipFile"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/zip/ZipFile")));f.Pc=140;continue;}
case 140:{f.StackOp("dup");f.Pc=141;continue;}
case 141:{f.Push(f.Locals[4]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/util/zip/ZipFile","<init>","(Ljava/io/File;)V","invokespecial",146);}
case 146:{var value=f.Pop();rt.PutField(f.Pop(),"forge/CardStorageReader","zip","Ljava/util/zip/ZipFile;",value);f.Pc=149;continue;}
case 149:{f.Pc=190;continue;}
case 152:{f.Locals[5]=f.Pop();f.Pc=154;continue;}
case 154:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=157;continue;}
case 157:{f.Push(JValue.R(rt.String("Error reading zip file \"%s\": %s. Defaulting to txt files in \"%s\".%n")));f.Pc=159;continue;}
case 159:{f.Push(JValue.I(3));f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=163;continue;}
case 163:{f.StackOp("dup");f.Pc=164;continue;}
case 164:{f.Push(JValue.I(0));f.Pc=165;continue;}
case 165:{f.Push(f.Locals[4]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/io/File","getAbsolutePath","()Ljava/lang/String;","invokevirtual",170);}
case 170:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=171;continue;}
case 171:{f.StackOp("dup");f.Pc=172;continue;}
case 172:{f.Push(JValue.I(1));f.Pc=173;continue;}
case 173:{f.Push(f.Locals[5]);f.Pc=175;continue;}
case 175:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=176;continue;}
case 176:{f.StackOp("dup");f.Pc=177;continue;}
case 177:{f.Push(JValue.I(2));f.Pc=178;continue;}
case 178:{f.Push(f.Locals[0]);f.Pc=179;continue;}
case 179:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","cardsfolder","Ljava/io/File;"));f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/io/File","getAbsolutePath","()Ljava/lang/String;","invokevirtual",185);}
case 185:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/io/PrintStream","printf","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;","invokevirtual",189);}
case 189:{f.StackOp("pop");f.Pc=190;continue;}
case 190:{f.Push(f.Locals[0]);f.Pc=191;continue;}
case 191:{f.Push(JValue.R(rt.String("UTF-8")));f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/nio/charset/Charset","forName","(Ljava/lang/String;)Ljava/nio/charset/Charset;","invokestatic",196);}
case 196:{var value=f.Pop();rt.PutField(f.Pop(),"forge/CardStorageReader","charset","Ljava/nio/charset/Charset;",value);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[3]);f.Pc=200;continue;}
case 200:{f.Pc=f.Pop().Int==0?265:203;continue;}
case 203:{f.Push(f.Locals[0]);f.Pc=204;continue;}
case 204:{f.Push(f.Locals[0]);f.Pc=205;continue;}
case 205:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","zip","Ljava/util/zip/ZipFile;"));f.Pc=208;continue;}
case 208:{f.Pc=f.Pop().Reference!=null?217:211;continue;}
case 211:{return rt.Call(f,"java/util/Collections","emptyNavigableMap","()Ljava/util/NavigableMap;","invokestatic",214);}
case 214:{f.Pc=231;continue;}
case 217:{f.Push(f.Locals[0]);f.Pc=218;continue;}
case 218:{f.Push(f.Locals[0]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/CardStorageReader","getZipEntries","()Ljava/util/List;","invokevirtual",222);}
case 222:{f.Push(f.Locals[0]);f.Pc=223;continue;}
case 223:{return rt.DynamicCall(f,"forge/CardStorageReader:0:223:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/CardStorageReader;)Ljava/util/function/BiFunction;",228);}
case 228:{return rt.Call(f,"forge/CardStorageReader","buildCardNameIndex","(Ljava/util/List;Ljava/util/function/BiFunction;)Ljava/util/NavigableMap;","invokevirtual",231);}
case 231:{var value=f.Pop();rt.PutField(f.Pop(),"forge/CardStorageReader","zipEntriesByCardName","Ljava/util/NavigableMap;",value);f.Pc=234;continue;}
case 234:{f.Push(f.Locals[0]);f.Pc=235;continue;}
case 235:{f.Push(f.Locals[0]);f.Pc=236;continue;}
case 236:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=239;continue;}
case 239:{f.StackOp("dup");f.Pc=240;continue;}
case 240:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",243);}
case 243:{f.Push(f.Locals[0]);f.Pc=244;continue;}
case 244:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","cardsfolder","Ljava/io/File;"));f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/CardStorageReader","collectCardFiles","(Ljava/util/List;Ljava/io/File;)Ljava/util/List;","invokestatic",250);}
case 250:{f.Push(f.Locals[0]);f.Pc=251;continue;}
case 251:{return rt.DynamicCall(f,"forge/CardStorageReader:0:251:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/CardStorageReader;)Ljava/util/function/BiFunction;",256);}
case 256:{return rt.Call(f,"forge/CardStorageReader","buildCardNameIndex","(Ljava/util/List;Ljava/util/function/BiFunction;)Ljava/util/NavigableMap;","invokevirtual",259);}
case 259:{var value=f.Pop();rt.PutField(f.Pop(),"forge/CardStorageReader","cardFilesByCardName","Ljava/util/NavigableMap;",value);f.Pc=262;continue;}
case 262:{f.Pc=279;continue;}
case 265:{f.Push(f.Locals[0]);f.Pc=266;continue;}
case 266:{return rt.Call(f,"java/util/Collections","emptyNavigableMap","()Ljava/util/NavigableMap;","invokestatic",269);}
case 269:{var value=f.Pop();rt.PutField(f.Pop(),"forge/CardStorageReader","zipEntriesByCardName","Ljava/util/NavigableMap;",value);f.Pc=272;continue;}
case 272:{f.Push(f.Locals[0]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"java/util/Collections","emptyNavigableMap","()Ljava/util/NavigableMap;","invokestatic",276);}
case 276:{var value=f.Pop();rt.PutField(f.Pop(),"forge/CardStorageReader","cardFilesByCardName","Ljava/util/NavigableMap;",value);f.Pc=279;continue;}
case 279:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","loadCardsLazily","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRules$Reader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRules$Reader")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardRules$Reader","<init>","()V","invokespecial",7);}
case 7:{f.Locals[4]=f.Pop();f.Pc=9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",16);}
case 16:{f.Locals[5]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Locals[6]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[6]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?62:27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[6]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/io/File"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[7]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[5]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[7]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/CardStorageReader","loadCard","(Lforge/card/CardRules$Reader;Ljava/io/File;)Lforge/card/CardRules;","invokevirtual",50);}
case 50:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=59;continue;}
case 59:{f.Pc=21;continue;}
case 62:{f.Push(f.Locals[5]);f.Pc=64;continue;}
case 64:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardRules$Reader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRules$Reader")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardRules$Reader","<init>","()V","invokespecial",7);}
case 7:{f.Locals[4]=f.Pop();f.Pc=9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",16);}
case 16:{f.Locals[5]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Locals[6]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[6]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?62:27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[6]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/zip/ZipEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[7]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[5]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[7]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/CardStorageReader","loadCard","(Lforge/card/CardRules$Reader;Ljava/util/zip/ZipEntry;)Lforge/card/CardRules;","invokevirtual",50);}
case 50:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=59;continue;}
case 59:{f.Pc=21;continue;}
case 62:{f.Push(f.Locals[5]);f.Pc=64;continue;}
case 64:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.NewArray("C",f.Pop().Int)));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{f.Locals[4]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",18);}
case 18:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?139:21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",27);}
case 27:{return rt.Call(f,"java/lang/Character","toLowerCase","(C)C","invokestatic",30);}
case 30:{f.Locals[5]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{f.Push(JValue.I(39));f.Pc=36;continue;}
case 36:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?42:39;continue;}
case 39:{f.Pc=133;continue;}
case 42:{f.Push(f.Locals[5]);f.Pc=44;continue;}
case 44:{f.Push(JValue.I(97));f.Pc=46;continue;}
case 46:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?56:49;continue;}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{f.Push(JValue.I(122));f.Pc=53;continue;}
case 53:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?125:56;continue;}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{f.Push(JValue.I(48));f.Pc=60;continue;}
case 60:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?70:63;continue;}
case 63:{f.Push(f.Locals[5]);f.Pc=65;continue;}
case 65:{f.Push(JValue.I(57));f.Pc=67;continue;}
case 67:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?125:70;continue;}
case 70:{f.Push(f.Locals[3]);f.Pc=71;continue;}
case 71:{f.Pc=f.Pop().Int<=0?87:74;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[3]);f.Pc=76;continue;}
case 76:{f.Push(JValue.I(1));f.Pc=77;continue;}
case 77:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=78;continue;}
case 78:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=79;continue;}
case 79:{f.Push(JValue.I(95));f.Pc=81;continue;}
case 81:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?87:84;continue;}
case 84:{f.Pc=133;continue;}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{f.Push(JValue.I(44));f.Pc=91;continue;}
case 91:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?121:94;continue;}
case 94:{f.Push(f.Locals[3]);f.Pc=95;continue;}
case 95:{f.Pc=f.Pop().Int<=0?121:98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[3]);f.Pc=100;continue;}
case 100:{f.Push(JValue.I(1));f.Pc=101;continue;}
case 101:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=102;continue;}
case 102:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=103;continue;}
case 103:{f.Push(JValue.I(48));f.Pc=105;continue;}
case 105:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?133:108;continue;}
case 108:{f.Push(f.Locals[2]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[3]);f.Pc=110;continue;}
case 110:{f.Push(JValue.I(1));f.Pc=111;continue;}
case 111:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=112;continue;}
case 112:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=113;continue;}
case 113:{f.Push(JValue.I(57));f.Pc=115;continue;}
case 115:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?121:118;continue;}
case 118:{f.Pc=133;continue;}
case 121:{f.Push(JValue.I(95));f.Pc=123;continue;}
case 123:{f.Locals[5]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[2]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[3]);f.Pc=127;continue;}
case 127:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=130;continue;}
case 130:{f.Push(f.Locals[5]);f.Pc=132;continue;}
case 132:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=133;continue;}
case 133:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=136;continue;}
case 136:{f.Pc=12;continue;}
case 139:{f.Push(f.Locals[3]);f.Pc=140;continue;}
case 140:{f.Pc=f.Pop().Int!=0?146:143;continue;}
case 143:{f.Push(JValue.R(rt.String("")));f.Pc=145;continue;}
case 145:{return JStep.Return(f.Pop());}
case 146:{f.Push(f.Locals[2]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[3]);f.Pc=148;continue;}
case 148:{f.Push(JValue.I(1));f.Pc=149;continue;}
case 149:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=150;continue;}
case 150:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=151;continue;}
case 151:{f.Push(JValue.I(95));f.Pc=153;continue;}
case 153:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?159:156;continue;}
case 156:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(-1)));f.Pc=159;continue;}
case 159:{if(!rt.EnsureInitialized(f,"java/lang/String"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/String")));f.Pc=162;continue;}
case 162:{f.StackOp("dup");f.Pc=163;continue;}
case 163:{f.Push(f.Locals[2]);f.Pc=164;continue;}
case 164:{f.Push(JValue.I(0));f.Pc=165;continue;}
case 165:{f.Push(f.Locals[3]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"java/lang/String","<init>","([CII)V","invokespecial",169);}
case 169:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","stripAccents","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/CardStorageReader","transformName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?18:16;continue;}
case 16:{f.Push(JValue.R(null));f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
case 18:{if(!rt.EnsureInitialized(f,"forge/card/CardRules$Reader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRules$Reader")));f.Pc=21;continue;}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/card/CardRules$Reader","<init>","()V","invokespecial",25);}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","zipEntriesByCardName","Ljava/util/NavigableMap;"));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/NavigableMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/zip/ZipEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{f.Locals[4]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{f.Pc=f.Pop().Reference==null?54:46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/CardStorageReader","loadCard","(Lforge/card/CardRules$Reader;Ljava/util/zip/ZipEntry;)Lforge/card/CardRules;","invokevirtual",53);}
case 53:{return JStep.Return(f.Pop());}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","cardFilesByCardName","Ljava/util/NavigableMap;"));f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/NavigableMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",64);}
case 64:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/io/File"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=67;continue;}
case 67:{f.Locals[5]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{f.Pc=f.Pop().Reference==null?82:74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[3]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[5]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/CardStorageReader","loadCard","(Lforge/card/CardRules$Reader;Ljava/io/File;)Lforge/card/CardRules;","invokevirtual",81);}
case 81:{return JStep.Return(f.Pop());}
case 82:{f.Push(JValue.R(null));f.Pc=83;continue;}
case 83:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"org/apache/commons/lang3/time/StopWatch"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("org/apache/commons/lang3/time/StopWatch")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"org/apache/commons/lang3/time/StopWatch","<init>","()V","invokespecial",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"org/apache/commons/lang3/time/StopWatch","start","()V","invokevirtual",12);}
case 12:{if(!rt.EnsureInitialized(f,"java/util/TreeMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeMap")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/TreeMap","<init>","()V","invokespecial",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{if(!rt.EnsureInitialized(f,"java/util/TreeMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeMap")));f.Pc=24;continue;}
case 24:{f.StackOp("dup");f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/TreeMap","<init>","()V","invokespecial",28);}
case 28:{f.Locals[5]=f.Pop();f.Pc=30;continue;}
case 30:{if(!rt.EnsureInitialized(f,"forge/card/CardRules$Reader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardRules$Reader")));f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/card/CardRules$Reader","<init>","()V","invokespecial",37);}
case 37:{f.Locals[6]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",45);}
case 45:{f.Locals[7]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[7]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",54);}
case 54:{f.Pc=f.Pop().Int==0?194:57;continue;}
case 57:{f.Push(f.Locals[7]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",64);}
case 64:{f.Locals[8]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[6]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[8]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/function/BiFunction","apply","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",76);}
case 76:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=79;continue;}
case 79:{f.Locals[9]=f.Pop();f.Pc=81;continue;}
case 81:{f.Pc=89;continue;}
case 84:{f.Locals[10]=f.Pop();f.Pc=86;continue;}
case 86:{f.Pc=47;continue;}
case 89:{f.Push(f.Locals[9]);f.Pc=91;continue;}
case 91:{f.Pc=f.Pop().Reference!=null?97:94;continue;}
case 94:{f.Pc=47;continue;}
case 97:{f.Push(f.Locals[9]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/CardStorageReader","primaryNamesOf","(Lforge/card/CardRules;)Ljava/util/List;","invokestatic",102);}
case 102:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",107);}
case 107:{f.Locals[10]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[10]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",116);}
case 116:{f.Pc=f.Pop().Int==0?144:119;continue;}
case 119:{f.Push(f.Locals[10]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",126);}
case 126:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=129;continue;}
case 129:{f.Locals[11]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[4]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[11]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[8]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/CardStorageReader","putName","(Ljava/util/Map;Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",141);}
case 141:{f.Pc=109;continue;}
case 144:{f.Push(f.Locals[9]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/card/CardRules","getPlaceholderFaceNames","()Ljava/util/Collection;","invokevirtual",149);}
case 149:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",154);}
case 154:{f.Locals[10]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[10]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",163);}
case 163:{f.Pc=f.Pop().Int==0?191:166;continue;}
case 166:{f.Push(f.Locals[10]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",173);}
case 173:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=176;continue;}
case 176:{f.Locals[11]=f.Pop();f.Pc=178;continue;}
case 178:{f.Push(f.Locals[0]);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[5]);f.Pc=181;continue;}
case 181:{f.Push(f.Locals[11]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[8]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/CardStorageReader","putName","(Ljava/util/Map;Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",188);}
case 188:{f.Pc=156;continue;}
case 191:{f.Pc=47;continue;}
case 194:{f.Push(f.Locals[5]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",201);}
case 201:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",206);}
case 206:{f.Locals[7]=f.Pop();f.Pc=208;continue;}
case 208:{f.Push(f.Locals[7]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",215);}
case 215:{f.Pc=f.Pop().Int==0?258:218;continue;}
case 218:{f.Push(f.Locals[7]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",225);}
case 225:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=228;continue;}
case 228:{f.Locals[8]=f.Pop();f.Pc=230;continue;}
case 230:{f.Push(f.Locals[4]);f.Pc=232;continue;}
case 232:{f.Push(f.Locals[8]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",239);}
case 239:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[8]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",249);}
case 249:{return rt.Call(f,"java/util/NavigableMap","putIfAbsent","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",254);}
case 254:{f.StackOp("pop");f.Pc=255;continue;}
case 255:{f.Pc=208;continue;}
case 258:{f.Push(f.Locals[3]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"org/apache/commons/lang3/time/StopWatch","stop","()V","invokevirtual",262);}
case 262:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=265;continue;}
case 265:{f.Push(JValue.R(rt.String("Lazy card database: indexed %d card names from %d files in %d ms%n")));f.Pc=268;continue;}
case 268:{f.Push(JValue.I(3));f.Pc=269;continue;}
case 269:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=272;continue;}
case 272:{f.StackOp("dup");f.Pc=273;continue;}
case 273:{f.Push(JValue.I(0));f.Pc=274;continue;}
case 274:{f.Push(f.Locals[4]);f.Pc=276;continue;}
case 276:{return rt.Call(f,"java/util/NavigableMap","size","()I","invokeinterface",281);}
case 281:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",284);}
case 284:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=285;continue;}
case 285:{f.StackOp("dup");f.Pc=286;continue;}
case 286:{f.Push(JValue.I(1));f.Pc=287;continue;}
case 287:{f.Push(f.Locals[1]);f.Pc=288;continue;}
case 288:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",293);}
case 293:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",296);}
case 296:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=297;continue;}
case 297:{f.StackOp("dup");f.Pc=298;continue;}
case 298:{f.Push(JValue.I(2));f.Pc=299;continue;}
case 299:{f.Push(f.Locals[3]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"org/apache/commons/lang3/time/StopWatch","getTime","()J","invokevirtual",303);}
case 303:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",306);}
case 306:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=307;continue;}
case 307:{return rt.Call(f,"java/io/PrintStream","printf","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;","invokevirtual",310);}
case 310:{f.StackOp("pop");f.Pc=311;continue;}
case 311:{f.Push(f.Locals[4]);f.Pc=313;continue;}
case 313:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","stripAccents","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/CardStorageReader","transformName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",8);}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int!=0?28:18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Map","putIfAbsent","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",27);}
case 27:{f.StackOp("pop");f.Pc=28;continue;}
case 28:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/card/CardRules","getPreInitName","()Ljava/lang/String;","invokevirtual",13);}
case 13:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",18);}
case 18:{f.StackOp("pop");f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardRules","getAllFaces","()Ljava/util/List;","invokevirtual",23);}
case 23:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",28);}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",35);}
case 35:{f.Pc=f.Pop().Int==0?68:38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",44);}
case 44:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=47;continue;}
case 47:{f.Locals[3]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{f.Pc=f.Pop().Reference==null?65:52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",59);}
case 59:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",64);}
case 64:{f.StackOp("pop");f.Pc=65;continue;}
case 65:{f.Pc=29;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/card/CardRules","getPlaceholderFaceNames","()Ljava/util/Collection;","invokevirtual",72);}
case 72:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",77);}
case 77:{f.Pc=f.Pop().Int==0?131:80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/card/CardRules","getSupportedFunctionalVariants","()Ljava/util/Set;","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Reference==null?131:87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/card/CardRules","getSupportedFunctionalVariants","()Ljava/util/Set;","invokevirtual",91);}
case 91:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",96);}
case 96:{f.Locals[2]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[2]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",103);}
case 103:{f.Pc=f.Pop().Int==0?131:106;continue;}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",112);}
case 112:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=115;continue;}
case 115:{f.Locals[3]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[0]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[3]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/card/CardRules","getDisplayNameForVariant","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",122);}
case 122:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",127);}
case 127:{f.StackOp("pop");f.Pc=128;continue;}
case 128:{f.Pc=97;continue;}
case 131:{f.Push(f.Locals[1]);f.Pc=132;continue;}
case 132:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","loadCardsLazily","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?11:7;continue;}
case 7:{return rt.Call(f,"java/util/Collections","emptyList","()Ljava/util/List;","invokestatic",10);}
case 10:{return JStep.Return(f.Pop());}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/CardStorageReader","readAllCards","()Ljava/lang/Iterable;","invokevirtual",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","progressObserver","Lforge/CardStorageReader$ProgressObserver;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("splash.loading.examining-cards")));f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/CardStorageReader$ProgressObserver","setOperationName","(Ljava/lang/String;Z)V","invokeinterface",25);}
case 25:{if(!rt.EnsureInitialized(f,"java/util/TreeSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeSet")));f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{return rt.DynamicCall(f,"forge/CardStorageReader:10:29:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",34);}
case 34:{if(!rt.StaticReady(f,"java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Comparator","comparing","(Ljava/util/function/Function;Ljava/util/Comparator;)Ljava/util/Comparator;","invokestatic",40);}
case 40:{return rt.Call(f,"java/util/TreeSet","<init>","(Ljava/util/Comparator;)V","invokespecial",43);}
case 43:{f.Locals[2]=f.Pop();f.Pc=44;continue;}
case 44:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=47;continue;}
case 47:{f.StackOp("dup");f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",51);}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","cardsfolder","Ljava/io/File;"));f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/CardStorageReader","collectCardFiles","(Ljava/util/List;Ljava/io/File;)Ljava/util/List;","invokestatic",58);}
case 58:{f.Locals[3]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",65);}
case 65:{f.Pc=f.Pop().Int!=0?275:68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","zip","Ljava/util/zip/ZipFile;"));f.Pc=72;continue;}
case 72:{f.Pc=f.Pop().Reference!=null?80:75;continue;}
case 75:{f.Push(JValue.I(25));f.Pc=77;continue;}
case 77:{f.Pc=82;continue;}
case 80:{f.Push(JValue.I(9));f.Pc=82;continue;}
case 82:{f.Locals[4]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[3]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",90);}
case 90:{f.Push(f.Locals[4]);f.Pc=92;continue;}
case 92:{f.Push(JValue.I(100));f.Pc=94;continue;}
case 94:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=95;continue;}
case 95:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?113:98;continue;}
case 98:{f.Push(JValue.I(1));f.Pc=99;continue;}
case 99:{f.Push(f.Locals[3]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",105);}
case 105:{f.Push(JValue.I(100));f.Pc=107;continue;}
case 107:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"idiv",a,b));f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",111);}
case 111:{f.Locals[4]=f.Pop();f.Pc=113;continue;}
case 113:{if(!rt.EnsureInitialized(f,"java/util/concurrent/CountDownLatch"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/CountDownLatch")));f.Pc=116;continue;}
case 116:{f.StackOp("dup");f.Pc=117;continue;}
case 117:{f.Push(f.Locals[4]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/concurrent/CountDownLatch","<init>","(I)V","invokespecial",122);}
case 122:{f.Locals[5]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[3]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[5]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/CardStorageReader","makeTaskListForFiles","(Ljava/util/List;Ljava/util/concurrent/CountDownLatch;)Ljava/util/List;","invokevirtual",131);}
case 131:{f.Locals[6]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(f.Locals[0]);f.Pc=134;continue;}
case 134:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","progressObserver","Lforge/CardStorageReader$ProgressObserver;"));f.Pc=137;continue;}
case 137:{f.Push(f.Locals[1]);f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("splash.loading.cards-folders")));f.Pc=141;continue;}
case 141:{f.Push(JValue.I(0));f.Pc=142;continue;}
case 142:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",148);}
case 148:{f.Push(JValue.I(1));f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/CardStorageReader$ProgressObserver","setOperationName","(Ljava/lang/String;Z)V","invokeinterface",154);}
case 154:{f.Push(f.Locals[0]);f.Pc=155;continue;}
case 155:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","progressObserver","Lforge/CardStorageReader$ProgressObserver;"));f.Pc=158;continue;}
case 158:{f.Push(JValue.I(0));f.Pc=159;continue;}
case 159:{f.Push(f.Locals[6]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",166);}
case 166:{return rt.Call(f,"forge/CardStorageReader$ProgressObserver","report","(II)V","invokeinterface",171);}
case 171:{if(!rt.EnsureInitialized(f,"org/apache/commons/lang3/time/StopWatch"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("org/apache/commons/lang3/time/StopWatch")));f.Pc=174;continue;}
case 174:{f.StackOp("dup");f.Pc=175;continue;}
case 175:{return rt.Call(f,"org/apache/commons/lang3/time/StopWatch","<init>","()V","invokespecial",178);}
case 178:{f.Locals[7]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[7]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"org/apache/commons/lang3/time/StopWatch","start","()V","invokevirtual",185);}
case 185:{f.Push(f.Locals[0]);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[2]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[6]);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[5]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/CardStorageReader","executeLoadTask","(Ljava/util/Collection;Ljava/util/List;Ljava/util/concurrent/CountDownLatch;)V","invokevirtual",194);}
case 194:{f.Push(f.Locals[7]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"org/apache/commons/lang3/time/StopWatch","stop","()V","invokevirtual",199);}
case 199:{f.Push(f.Locals[7]);f.Pc=201;continue;}
case 201:{if(!rt.StaticReady(f,"java/util/concurrent/TimeUnit","SECONDS","Ljava/util/concurrent/TimeUnit;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/concurrent/TimeUnit","SECONDS","Ljava/util/concurrent/TimeUnit;"));f.Pc=204;continue;}
case 204:{return rt.Call(f,"org/apache/commons/lang3/time/StopWatch","getTime","(Ljava/util/concurrent/TimeUnit;)J","invokevirtual",207);}
case 207:{f.Locals[8]=f.Pop();f.Pc=209;continue;}
case 209:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=212;continue;}
case 212:{f.Push(JValue.R(rt.String("Read cards: %s files in %d ms (%d parts) %s%n")));f.Pc=215;continue;}
case 215:{f.Push(JValue.I(4));f.Pc=216;continue;}
case 216:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=219;continue;}
case 219:{f.StackOp("dup");f.Pc=220;continue;}
case 220:{f.Push(JValue.I(0));f.Pc=221;continue;}
case 221:{f.Push(f.Locals[3]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",227);}
case 227:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",230);}
case 230:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=231;continue;}
case 231:{f.StackOp("dup");f.Pc=232;continue;}
case 232:{f.Push(JValue.I(1));f.Pc=233;continue;}
case 233:{f.Push(f.Locals[8]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",238);}
case 238:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=239;continue;}
case 239:{f.StackOp("dup");f.Pc=240;continue;}
case 240:{f.Push(JValue.I(2));f.Pc=241;continue;}
case 241:{f.Push(f.Locals[6]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",248);}
case 248:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",251);}
case 251:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=252;continue;}
case 252:{f.StackOp("dup");f.Pc=253;continue;}
case 253:{f.Push(JValue.I(3));f.Pc=254;continue;}
case 254:{f.Push(f.Locals[0]);f.Pc=255;continue;}
case 255:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","useThreadPool","Z"));f.Pc=258;continue;}
case 258:{f.Pc=f.Pop().Int==0?267:261;continue;}
case 261:{f.Push(JValue.R(rt.String("using thread pool")));f.Pc=264;continue;}
case 264:{f.Pc=270;continue;}
case 267:{f.Push(JValue.R(rt.String("in same thread")));f.Pc=270;continue;}
case 270:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=271;continue;}
case 271:{return rt.Call(f,"java/io/PrintStream","printf","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;","invokevirtual",274);}
case 274:{f.StackOp("pop");f.Pc=275;continue;}
case 275:{f.Push(f.Locals[0]);f.Pc=276;continue;}
case 276:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","zip","Ljava/util/zip/ZipFile;"));f.Pc=279;continue;}
case 279:{f.Pc=f.Pop().Reference==null?448:282;continue;}
case 282:{if(!rt.EnsureInitialized(f,"java/util/concurrent/CountDownLatch"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/CountDownLatch")));f.Pc=285;continue;}
case 285:{f.StackOp("dup");f.Pc=286;continue;}
case 286:{f.Push(JValue.I(25));f.Pc=288;continue;}
case 288:{return rt.Call(f,"java/util/concurrent/CountDownLatch","<init>","(I)V","invokespecial",291);}
case 291:{f.Locals[4]=f.Pop();f.Pc=293;continue;}
case 293:{f.Push(f.Locals[0]);f.Pc=294;continue;}
case 294:{f.Push(f.Locals[0]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/CardStorageReader","getZipEntries","()Ljava/util/List;","invokevirtual",298);}
case 298:{f.Push(f.Locals[4]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/CardStorageReader","makeTaskListForZip","(Ljava/util/List;Ljava/util/concurrent/CountDownLatch;)Ljava/util/List;","invokevirtual",303);}
case 303:{f.Locals[5]=f.Pop();f.Pc=305;continue;}
case 305:{f.Push(f.Locals[0]);f.Pc=306;continue;}
case 306:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","progressObserver","Lforge/CardStorageReader$ProgressObserver;"));f.Pc=309;continue;}
case 309:{f.Push(f.Locals[1]);f.Pc=310;continue;}
case 310:{f.Push(JValue.R(rt.String("splash.loading.cards-archive")));f.Pc=313;continue;}
case 313:{f.Push(JValue.I(0));f.Pc=314;continue;}
case 314:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=317;continue;}
case 317:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",320);}
case 320:{f.Push(JValue.I(1));f.Pc=321;continue;}
case 321:{return rt.Call(f,"forge/CardStorageReader$ProgressObserver","setOperationName","(Ljava/lang/String;Z)V","invokeinterface",326);}
case 326:{f.Push(f.Locals[0]);f.Pc=327;continue;}
case 327:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","progressObserver","Lforge/CardStorageReader$ProgressObserver;"));f.Pc=330;continue;}
case 330:{f.Push(JValue.I(0));f.Pc=331;continue;}
case 331:{f.Push(f.Locals[5]);f.Pc=333;continue;}
case 333:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",338);}
case 338:{return rt.Call(f,"forge/CardStorageReader$ProgressObserver","report","(II)V","invokeinterface",343);}
case 343:{if(!rt.EnsureInitialized(f,"org/apache/commons/lang3/time/StopWatch"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("org/apache/commons/lang3/time/StopWatch")));f.Pc=346;continue;}
case 346:{f.StackOp("dup");f.Pc=347;continue;}
case 347:{return rt.Call(f,"org/apache/commons/lang3/time/StopWatch","<init>","()V","invokespecial",350);}
case 350:{f.Locals[6]=f.Pop();f.Pc=352;continue;}
case 352:{f.Push(f.Locals[6]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"org/apache/commons/lang3/time/StopWatch","start","()V","invokevirtual",357);}
case 357:{f.Push(f.Locals[0]);f.Pc=358;continue;}
case 358:{f.Push(f.Locals[2]);f.Pc=359;continue;}
case 359:{f.Push(f.Locals[5]);f.Pc=361;continue;}
case 361:{f.Push(f.Locals[4]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"forge/CardStorageReader","executeLoadTask","(Ljava/util/Collection;Ljava/util/List;Ljava/util/concurrent/CountDownLatch;)V","invokevirtual",366);}
case 366:{f.Push(f.Locals[6]);f.Pc=368;continue;}
case 368:{return rt.Call(f,"org/apache/commons/lang3/time/StopWatch","stop","()V","invokevirtual",371);}
case 371:{f.Push(f.Locals[6]);f.Pc=373;continue;}
case 373:{if(!rt.StaticReady(f,"java/util/concurrent/TimeUnit","SECONDS","Ljava/util/concurrent/TimeUnit;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/concurrent/TimeUnit","SECONDS","Ljava/util/concurrent/TimeUnit;"));f.Pc=376;continue;}
case 376:{return rt.Call(f,"org/apache/commons/lang3/time/StopWatch","getTime","(Ljava/util/concurrent/TimeUnit;)J","invokevirtual",379);}
case 379:{f.Locals[7]=f.Pop();f.Pc=381;continue;}
case 381:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=384;continue;}
case 384:{f.Push(JValue.R(rt.String("Read cards: %s archived files in %d ms (%d parts) %s%n")));f.Pc=387;continue;}
case 387:{f.Push(JValue.I(4));f.Pc=388;continue;}
case 388:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=391;continue;}
case 391:{f.StackOp("dup");f.Pc=392;continue;}
case 392:{f.Push(JValue.I(0));f.Pc=393;continue;}
case 393:{f.Push(f.Locals[0]);f.Pc=394;continue;}
case 394:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","zip","Ljava/util/zip/ZipFile;"));f.Pc=397;continue;}
case 397:{return rt.Call(f,"java/util/zip/ZipFile","size","()I","invokevirtual",400);}
case 400:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",403);}
case 403:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=404;continue;}
case 404:{f.StackOp("dup");f.Pc=405;continue;}
case 405:{f.Push(JValue.I(1));f.Pc=406;continue;}
case 406:{f.Push(f.Locals[7]);f.Pc=408;continue;}
case 408:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",411);}
case 411:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=412;continue;}
case 412:{f.StackOp("dup");f.Pc=413;continue;}
case 413:{f.Push(JValue.I(2));f.Pc=414;continue;}
case 414:{f.Push(f.Locals[5]);f.Pc=416;continue;}
case 416:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",421);}
case 421:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",424);}
case 424:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=425;continue;}
case 425:{f.StackOp("dup");f.Pc=426;continue;}
case 426:{f.Push(JValue.I(3));f.Pc=427;continue;}
case 427:{f.Push(f.Locals[0]);f.Pc=428;continue;}
case 428:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","useThreadPool","Z"));f.Pc=431;continue;}
case 431:{f.Pc=f.Pop().Int==0?440:434;continue;}
case 434:{f.Push(JValue.R(rt.String("using thread pool")));f.Pc=437;continue;}
case 437:{f.Pc=443;continue;}
case 440:{f.Push(JValue.R(rt.String("in same thread")));f.Pc=443;continue;}
case 443:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=444;continue;}
case 444:{return rt.Call(f,"java/io/PrintStream","printf","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;","invokevirtual",447);}
case 447:{f.StackOp("pop");f.Pc=448;continue;}
case 448:{f.Push(f.Locals[2]);f.Pc=449;continue;}
case 449:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","zip","Ljava/util/zip/ZipFile;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/zip/ZipFile","entries","()Ljava/util/Enumeration;","invokevirtual",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Enumeration","hasMoreElements","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?69:25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Enumeration","nextElement","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/zip/ZipEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[1]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/zip/ZipEntry","isDirectory","()Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int!=0?16:42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/zip/ZipEntry","getName","()Ljava/lang/String;","invokevirtual",46);}
case 46:{f.Push(JValue.R(rt.String(".txt")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int!=0?58:55;continue;}
case 55:{f.Pc=16;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Pc=16;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","useThreadPool","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?90:7;continue;}
case 7:{f.Push(JValue.F(0.5f));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/ThreadUtil","getComputingPool","(F)Ljava/util/concurrent/ExecutorService;","invokestatic",13);}
case 13:{f.Locals[4]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/concurrent/ExecutorService","invokeAll","(Ljava/util/Collection;)Ljava/util/List;","invokeinterface",23);}
case 23:{f.Locals[5]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/concurrent/ExecutorService","shutdown","()V","invokeinterface",32);}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/concurrent/CountDownLatch","await","()V","invokevirtual",36);}
case 36:{f.Push(f.Locals[5]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",43);}
case 43:{f.Locals[6]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[6]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",52);}
case 52:{f.Pc=f.Pop().Int==0?87:55;continue;}
case 55:{f.Push(f.Locals[6]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",62);}
case 62:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/concurrent/Future"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=65;continue;}
case 65:{f.Locals[7]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[7]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/concurrent/Future","get","()Ljava/lang/Object;","invokeinterface",75);}
case 75:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Collection","addAll","(Ljava/util/Collection;)Z","invokeinterface",83);}
case 83:{f.StackOp("pop");f.Pc=84;continue;}
case 84:{f.Pc=45;continue;}
case 87:{f.Pc=140;continue;}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",96);}
case 96:{f.Locals[4]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[4]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",105);}
case 105:{f.Pc=f.Pop().Int==0?140:108;continue;}
case 108:{f.Push(f.Locals[4]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",115);}
case 115:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/concurrent/Callable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=118;continue;}
case 118:{f.Locals[5]=f.Pop();f.Pc=120;continue;}
case 120:{f.Push(f.Locals[1]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[5]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/util/concurrent/Callable","call","()Ljava/lang/Object;","invokeinterface",128);}
case 128:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/util/Collection","addAll","(Ljava/util/Collection;)Z","invokeinterface",136);}
case 136:{f.StackOp("pop");f.Pc=137;continue;}
case 137:{f.Pc=98;continue;}
case 140:{f.Pc=183;continue;}
case 143:{f.Locals[4]=f.Pop();f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/lang/Thread","currentThread","()Ljava/lang/Thread;","invokestatic",148);}
case 148:{return rt.Call(f,"java/lang/Thread","interrupt","()V","invokevirtual",151);}
case 151:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=154;continue;}
case 154:{f.StackOp("dup");f.Pc=155;continue;}
case 155:{f.Push(f.Locals[4]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/Throwable;)V","invokespecial",160);}
case 160:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 161:{f.Locals[4]=f.Pop();f.Pc=163;continue;}
case 163:{f.Push(f.Locals[4]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/util/concurrent/ExecutionException","printStackTrace","()V","invokevirtual",168);}
case 168:{f.Pc=183;continue;}
case 171:{f.Locals[4]=f.Pop();f.Pc=173;continue;}
case 173:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=176;continue;}
case 176:{f.StackOp("dup");f.Pc=177;continue;}
case 177:{f.Push(f.Locals[4]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/Throwable;)V","invokespecial",182);}
case 182:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 183:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M13(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/concurrent/CountDownLatch","getCount","()J","invokevirtual",11);}
case 11:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=12;continue;}
case 12:{f.Locals[4]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"idiv",a,b));f.Pc=18;continue;}
case 18:{f.Locals[5]=f.Pop();f.Pc=20;continue;}
case 20:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",27);}
case 27:{f.Locals[6]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{f.Locals[7]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[7]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?94:39;continue;}
case 39:{f.Push(f.Locals[7]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[5]);f.Pc=43;continue;}
case 43:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=44;continue;}
case 44:{f.Locals[8]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[7]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=52;continue;}
case 52:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?59:55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{f.Pc=64;continue;}
case 59:{f.Push(f.Locals[8]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=64;continue;}
case 64:{f.Locals[9]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[6]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[8]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[9]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{return rt.DynamicCall(f,"forge/CardStorageReader:13:77:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/CardStorageReader;Ljava/util/List;IILjava/util/concurrent/CountDownLatch;I)Ljava/util/concurrent/Callable;",82);}
case 82:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",87);}
case 87:{f.StackOp("pop");f.Pc=88;continue;}
case 88:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=91;continue;}
case 91:{f.Pc=32;continue;}
case 94:{f.Push(f.Locals[6]);f.Pc=96;continue;}
case 96:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M14(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/concurrent/CountDownLatch","getCount","()J","invokevirtual",11);}
case 11:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=12;continue;}
case 12:{f.Locals[4]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"idiv",a,b));f.Pc=18;continue;}
case 18:{f.Locals[5]=f.Pop();f.Pc=20;continue;}
case 20:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",27);}
case 27:{f.Locals[6]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{f.Locals[7]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[7]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?94:39;continue;}
case 39:{f.Push(f.Locals[7]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[5]);f.Pc=43;continue;}
case 43:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=44;continue;}
case 44:{f.Locals[8]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[7]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=52;continue;}
case 52:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?59:55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{f.Pc=64;continue;}
case 59:{f.Push(f.Locals[8]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=64;continue;}
case 64:{f.Locals[9]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[6]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[8]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[9]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{return rt.DynamicCall(f,"forge/CardStorageReader:14:77:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/CardStorageReader;Ljava/util/List;IILjava/util/concurrent/CountDownLatch;I)Ljava/util/concurrent/Callable;",82);}
case 82:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",87);}
case 87:{f.StackOp("pop");f.Pc=88;continue;}
case 88:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=91;continue;}
case 91:{f.Pc=32;continue;}
case 94:{f.Push(f.Locals[6]);f.Pc=96;continue;}
case 96:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M15(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/io/File","list","()[Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=9;continue;}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{f.Locals[5]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[5]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[4]);f.Pc=18;continue;}
case 18:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?120:21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[5]);f.Pc=24;continue;}
case 24:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=25;continue;}
case 25:{f.Locals[6]=f.Pop();f.Pc=27;continue;}
case 27:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[6]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/io/File","<init>","(Ljava/io/File;Ljava/lang/String;)V","invokespecial",37);}
case 37:{f.Locals[7]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[7]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/io/File","isDirectory","()Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int!=0?73:47;continue;}
case 47:{f.Push(f.Locals[7]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/io/File","getName","()Ljava/lang/String;","invokevirtual",52);}
case 52:{f.Push(JValue.R(rt.String(".txt")));f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int==0?114:61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[7]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",69);}
case 69:{f.StackOp("pop");f.Pc=70;continue;}
case 70:{f.Pc=114;continue;}
case 73:{f.Push(f.Locals[6]);f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String(".")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",81);}
case 81:{f.Pc=f.Pop().Int==0?87:84;continue;}
case 84:{f.Pc=114;continue;}
case 87:{f.Push(f.Locals[6]);f.Pc=89;continue;}
case 89:{f.Push(JValue.R(rt.String("upcoming")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",95);}
case 95:{f.Pc=f.Pop().Int==0?107:98;continue;}
case 98:{return rt.Call(f,"forge/util/BuildInfo","isDevelopmentVersion","()Z","invokestatic",101);}
case 101:{f.Pc=f.Pop().Int!=0?107:104;continue;}
case 104:{f.Pc=114;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[7]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/CardStorageReader","collectCardFiles","(Ljava/util/List;Ljava/io/File;)Ljava/util/List;","invokestatic",113);}
case 113:{f.StackOp("pop");f.Pc=114;continue;}
case 114:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=117;continue;}
case 117:{f.Pc=14;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M16(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/io/InputStreamReader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/InputStreamReader")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","charset","Ljava/nio/charset/Charset;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/io/InputStreamReader","<init>","(Ljava/io/InputStream;Ljava/nio/charset/Charset;)V","invokespecial",12);}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/util/FileUtil","readAllLines","(Ljava/io/Reader;Z)Ljava/util/List;","invokestatic",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M17(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/io/File","toPath","()Ljava/nio/file/Path;","invokevirtual",4);}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.NewArray("Ljava/nio/file/OpenOption;",f.Pop().Int)));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/nio/file/Files","newInputStream","(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/InputStream;","invokestatic",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/CardRules$Reader","reset","()V","invokevirtual",16);}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/CardStorageReader","readScript","(Ljava/io/InputStream;)Ljava/util/List;","invokevirtual",21);}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/io/File","getName","()Ljava/lang/String;","invokevirtual",30);}
case 30:{return rt.Call(f,"com/google/common/io/Files","getNameWithoutExtension","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",33);}
case 33:{return rt.Call(f,"forge/card/CardRules$Reader","readCard","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/card/CardRules;","invokevirtual",36);}
case 36:{f.Locals[5]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/io/File","getPath","()Ljava/lang/String;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/card/CardRules","setPath","(Ljava/lang/String;)V","invokevirtual",47);}
case 47:{f.Push(f.Locals[5]);f.Pc=49;continue;}
case 49:{f.Locals[6]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{f.Pc=f.Pop().Reference==null?59:55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/io/InputStream","close","()V","invokevirtual",59);}
case 59:{f.Push(f.Locals[6]);f.Pc=61;continue;}
case 61:{return JStep.Return(f.Pop());}
case 62:{f.Locals[4]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{f.Pc=f.Pop().Reference==null?84:68;continue;}
case 68:{f.Push(f.Locals[3]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/io/InputStream","close","()V","invokevirtual",72);}
case 72:{f.Pc=84;continue;}
case 75:{f.Locals[5]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[5]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/Throwable","addSuppressed","(Ljava/lang/Throwable;)V","invokevirtual",84);}
case 84:{f.Push(f.Locals[4]);f.Pc=86;continue;}
case 86:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 87:{f.Locals[3]=f.Pop();f.Pc=88;continue;}
case 88:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=91;continue;}
case 91:{f.StackOp("dup");f.Pc=92;continue;}
case 92:{f.Push(f.Locals[2]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/io/File","getPath","()Ljava/lang/String;","invokevirtual",96);}
case 96:{return rt.DynamicCall(f,"forge/CardStorageReader:17:96:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",101);}
case 101:{f.Push(f.Locals[3]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;Ljava/lang/Throwable;)V","invokespecial",105);}
case 105:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 106:{f.Locals[3]=f.Pop();f.Pc=107;continue;}
case 107:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=110;continue;}
case 110:{f.StackOp("dup");f.Pc=111;continue;}
case 111:{f.Push(f.Locals[2]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/io/File","getName","()Ljava/lang/String;","invokevirtual",115);}
case 115:{return rt.DynamicCall(f,"forge/CardStorageReader:17:115:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",120);}
case 120:{f.Push(f.Locals[3]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;Ljava/lang/Throwable;)V","invokespecial",124);}
case 124:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M18(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","zip","Ljava/util/zip/ZipFile;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/zip/ZipFile","getInputStream","(Ljava/util/zip/ZipEntry;)Ljava/io/InputStream;","invokevirtual",8);}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/card/CardRules$Reader","reset","()V","invokevirtual",13);}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/CardStorageReader","readScript","(Ljava/io/InputStream;)Ljava/util/List;","invokevirtual",19);}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/zip/ZipEntry","getName","()Ljava/lang/String;","invokevirtual",23);}
case 23:{return rt.Call(f,"com/google/common/io/Files","getNameWithoutExtension","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",26);}
case 26:{return rt.Call(f,"forge/card/CardRules$Reader","readCard","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/card/CardRules;","invokevirtual",29);}
case 29:{f.Locals[4]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/zip/ZipEntry","getName","()Ljava/lang/String;","invokevirtual",37);}
case 37:{return rt.Call(f,"forge/card/CardRules","setPath","(Ljava/lang/String;)V","invokevirtual",40);}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{f.Pc=f.Pop().Reference==null?52:48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/io/InputStream","close","()V","invokevirtual",52);}
case 52:{f.Push(f.Locals[5]);f.Pc=54;continue;}
case 54:{return JStep.Return(f.Pop());}
case 55:{f.Locals[4]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{f.Pc=f.Pop().Reference==null?77:61;continue;}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/io/InputStream","close","()V","invokevirtual",65);}
case 65:{f.Pc=77;continue;}
case 68:{f.Locals[5]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[5]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/lang/Throwable","addSuppressed","(Ljava/lang/Throwable;)V","invokevirtual",77);}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 80:{f.Locals[3]=f.Pop();f.Pc=81;continue;}
case 81:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=84;continue;}
case 84:{f.StackOp("dup");f.Pc=85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/Throwable;)V","invokespecial",89);}
case 89:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M19(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/CardStorageReader","loadCardsInRange","(Ljava/util/List;II)Ljava/util/List;","invokevirtual",7);}
case 7:{f.Locals[6]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[6]);f.Pc=11;continue;}
case 11:{f.Locals[7]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/concurrent/CountDownLatch","countDown","()V","invokevirtual",18);}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","progressObserver","Lforge/CardStorageReader$ProgressObserver;"));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[5]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/concurrent/CountDownLatch","getCount","()J","invokevirtual",29);}
case 29:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=30;continue;}
case 30:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[5]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/CardStorageReader$ProgressObserver","report","(II)V","invokeinterface",38);}
case 38:{f.Push(f.Locals[7]);f.Pc=40;continue;}
case 40:{return JStep.Return(f.Pop());}
case 41:{f.Locals[6]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[6]);f.Pc=45;continue;}
case 45:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 46:{f.Locals[8]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/concurrent/CountDownLatch","countDown","()V","invokevirtual",53);}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","progressObserver","Lforge/CardStorageReader$ProgressObserver;"));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/concurrent/CountDownLatch","getCount","()J","invokevirtual",64);}
case 64:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=65;continue;}
case 65:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/CardStorageReader$ProgressObserver","report","(II)V","invokeinterface",73);}
case 73:{f.Push(f.Locals[8]);f.Pc=75;continue;}
case 75:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M20(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/CardStorageReader","loadCardsInRangeFromZip","(Ljava/util/List;II)Ljava/util/List;","invokevirtual",7);}
case 7:{f.Locals[6]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[4]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/concurrent/CountDownLatch","countDown","()V","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/CardStorageReader","progressObserver","Lforge/CardStorageReader$ProgressObserver;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[5]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/concurrent/CountDownLatch","getCount","()J","invokevirtual",25);}
case 25:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=26;continue;}
case 26:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[5]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/CardStorageReader$ProgressObserver","report","(II)V","invokeinterface",34);}
case 34:{f.Push(f.Locals[6]);f.Pc=36;continue;}
case 36:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

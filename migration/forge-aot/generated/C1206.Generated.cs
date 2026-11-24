// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1206{
internal static JClass Build(){var c=new JClass("forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","forge/util/storage/StorageReaderBase",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("directory","Ljava/io/File;",false,JValue.Default("Ljava/io/File;"),null));
c.Add(new JField("userDirectory","Ljava/io/File;",false,JValue.Default("Ljava/io/File;"),null));
c.Add(new JField("objectsThatFailedToLoad","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(12506,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","getDirectory","()Ljava/io/File;",1,1,1,new JHandler[]{},M12506));
c.Add(new JMethod(12507,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","getFullPath","()Ljava/lang/String;",1,1,1,new JHandler[]{},M12507));
c.Add(new JMethod(12508,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","<init>","(Ljava/io/File;Ljava/io/File;Ljava/util/function/Function;)V",1,5,3,new JHandler[]{new JHandler(43,91,94,"java/io/IOException")},M12508));
c.Add(new JMethod(12509,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","readAll","()Ljava/util/Map;",1,11,4,new JHandler[]{new JHandler(72,98,155,"java/util/NoSuchElementException"),new JHandler(101,152,155,"java/util/NoSuchElementException")},M12509));
c.Add(new JMethod(12510,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","listFileTree","(Ljava/io/File;)Ljava/util/Collection;",2,7,3,new JHandler[]{},M12510));
c.Add(new JMethod(12511,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","read","(Ljava/io/File;)Ljava/lang/Object;",1028,0,0,new JHandler[]{},null));
c.Add(new JMethod(12512,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","getFileFilter","()Ljava/io/FilenameFilter;",1028,0,0,new JHandler[]{},null));
c.Add(new JMethod(12513,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","getItemKey","(Ljava/lang/Object;)Ljava/lang/String;",1,2,2,new JHandler[]{},M12513));
c.Add(new JMethod(12514,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","getSubFolders","()Ljava/lang/Iterable;",1,2,2,new JHandler[]{},M12514));
c.Add(new JMethod(12515,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","lambda$getSubFolders$0","(Ljava/io/File;)Z",4106,1,1,new JHandler[]{},M12515));
}

internal static JStep M12506(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","directory","Ljava/io/File;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12507(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","directory","Ljava/io/File;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/io/File","getPath","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12508(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[3]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/storage/StorageReaderBase","<init>","(Ljava/util/function/Function;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",13);}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","objectsThatFailedToLoad","Ljava/util/List;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","directory","Ljava/io/File;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","userDirectory","Ljava/io/File;",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","directory","Ljava/io/File;"));f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Reference!=null?43:33;continue;}
case 33:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("No directory specified")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",42);}
case 42:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","directory","Ljava/io/File;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/io/File","isFile","()Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?63:53;continue;}
case 53:{if(!rt.EnsureInitialized(f,"java/io/IOException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/IOException")));f.Pc=56;continue;}
case 56:{f.StackOp("dup");f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String("Not a directory")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/io/IOException","<init>","(Ljava/lang/String;)V","invokespecial",62);}
case 62:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","directory","Ljava/io/File;"));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/io/File","mkdirs","()Z","invokevirtual",70);}
case 70:{f.StackOp("pop");f.Pc=71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","directory","Ljava/io/File;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/io/File","isDirectory","()Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int!=0?91:81;continue;}
case 81:{if(!rt.EnsureInitialized(f,"java/io/IOException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/IOException")));f.Pc=84;continue;}
case 84:{f.StackOp("dup");f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("Directory can't be created")));f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/io/IOException","<init>","(Ljava/lang/String;)V","invokespecial",90);}
case 90:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 91:{f.Pc=114;continue;}
case 94:{f.Locals[4]=f.Pop();f.Pc=96;continue;}
case 96:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=99;continue;}
case 99:{f.StackOp("dup");f.Pc=100;continue;}
case 100:{f.Push(f.Locals[4]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/io/IOException","getMessage","()Ljava/lang/String;","invokevirtual",105);}
case 105:{return rt.DynamicCall(f,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder:12508:105:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",110);}
case 110:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",113);}
case 113:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 114:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12509(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","createMap","()Ljava/util/Map;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","directory","Ljava/io/File;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","listFileTree","(Ljava/io/File;)Ljava/util/Collection;","invokevirtual",13);}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","userDirectory","Ljava/io/File;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","listFileTree","(Ljava/io/File;)Ljava/util/Collection;","invokevirtual",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Collection","addAll","(Ljava/util/Collection;)Z","invokeinterface",30);}
case 30:{f.StackOp("pop");f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.NewArray("Ljava/io/File;",f.Pop().Int)));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Collection","toArray","([Ljava/lang/Object;)[Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Ljava/io/File;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{f.Locals[5]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=53;continue;}
case 53:{f.Locals[6]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(JValue.I(0));f.Pc=56;continue;}
case 56:{f.Locals[7]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[7]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[6]);f.Pc=62;continue;}
case 62:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?205:65;continue;}
case 65:{f.Push(f.Locals[5]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[7]);f.Pc=69;continue;}
case 69:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=70;continue;}
case 70:{f.Locals[8]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[8]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","read","(Ljava/io/File;)Ljava/lang/Object;","invokevirtual",78);}
case 78:{f.Locals[9]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(JValue.R(null));f.Pc=81;continue;}
case 81:{f.Push(f.Locals[9]);f.Pc=83;continue;}
case 83:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?101:86;continue;}
case 86:{f.Push(f.Locals[8]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/io/File","getPath","()Ljava/lang/String;","invokevirtual",91);}
case 91:{return rt.DynamicCall(f,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder:12509:91:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",96);}
case 96:{f.Locals[10]=f.Pop();f.Pc=98;continue;}
case 98:{f.Pc=199;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","keySelector","Ljava/util/function/Function;"));f.Pc=105;continue;}
case 105:{f.Push(f.Locals[9]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",112);}
case 112:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=115;continue;}
case 115:{f.Locals[10]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[10]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",125);}
case 125:{f.Pc=f.Pop().Int==0?141:128;continue;}
case 128:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=131;continue;}
case 131:{f.Push(f.Locals[10]);f.Pc=133;continue;}
case 133:{return rt.DynamicCall(f,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder:12509:133:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",138);}
case 138:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",141);}
case 141:{f.Push(f.Locals[1]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[10]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[9]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",151);}
case 151:{f.StackOp("pop");f.Pc=152;continue;}
case 152:{f.Pc=199;continue;}
case 155:{f.Locals[9]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(JValue.I(3));f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=161;continue;}
case 161:{f.StackOp("dup");f.Pc=162;continue;}
case 162:{f.Push(JValue.I(0));f.Pc=163;continue;}
case 163:{f.Push(f.Locals[8]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/io/File","getName","()Ljava/lang/String;","invokevirtual",168);}
case 168:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=169;continue;}
case 169:{f.StackOp("dup");f.Pc=170;continue;}
case 170:{f.Push(JValue.I(1));f.Pc=171;continue;}
case 171:{f.Push(JValue.R(rt.String("failed to load because ----")));f.Pc=173;continue;}
case 173:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=174;continue;}
case 174:{f.StackOp("dup");f.Pc=175;continue;}
case 175:{f.Push(JValue.I(2));f.Pc=176;continue;}
case 176:{f.Push(f.Locals[9]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/util/NoSuchElementException","getMessage","()Ljava/lang/String;","invokevirtual",181);}
case 181:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",185);}
case 185:{f.Locals[10]=f.Pop();f.Pc=187;continue;}
case 187:{f.Push(f.Locals[0]);f.Pc=188;continue;}
case 188:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","objectsThatFailedToLoad","Ljava/util/List;"));f.Pc=191;continue;}
case 191:{f.Push(f.Locals[10]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",198);}
case 198:{f.StackOp("pop");f.Pc=199;continue;}
case 199:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=202;continue;}
case 202:{f.Pc=58;continue;}
case 205:{f.Push(f.Locals[1]);f.Pc=206;continue;}
case 206:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12510(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference==null?23:12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","getFileFilter","()Ljava/io/FilenameFilter;","invokevirtual",17);}
case 17:{return rt.Call(f,"java/io/File","listFiles","(Ljava/io/FilenameFilter;)[Ljava/io/File;","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Reference!=null?25:23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return JStep.Return(f.Pop());}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","getFileFilter","()Ljava/io/FilenameFilter;","invokevirtual",30);}
case 30:{return rt.Call(f,"java/io/File","listFiles","(Ljava/io/FilenameFilter;)[Ljava/io/File;","invokevirtual",33);}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=36;continue;}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[5]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?93:48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=52;continue;}
case 52:{f.Locals[6]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[6]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/io/File","isFile","()Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int==0?74:62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[6]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",70);}
case 70:{f.StackOp("pop");f.Pc=71;continue;}
case 71:{f.Pc=87;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[6]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","listFileTree","(Ljava/io/File;)Ljava/util/Collection;","invokevirtual",81);}
case 81:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",86);}
case 86:{f.StackOp("pop");f.Pc=87;continue;}
case 87:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=90;continue;}
case 90:{f.Pc=41;continue;}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12513(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","keySelector","Ljava/util/function/Function;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12514(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder","directory","Ljava/io/File;"));f.Pc=4;continue;}
case 4:{return rt.DynamicCall(f,"forge/util/storage/StorageReaderRecursiveFolderWithUserFolder:12514:4:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/io/FileFilter;",9);}
case 9:{return rt.Call(f,"java/io/File","listFiles","(Ljava/io/FileFilter;)[Ljava/io/File;","invokevirtual",12);}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",17);}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12515(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/io/File","isDirectory","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?18:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/io/File","isHidden","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

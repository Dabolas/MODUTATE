// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1205{
internal static JClass Build(){var c=new JClass("forge/util/storage/StorageReaderFolder","forge/util/storage/StorageReaderBase",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("directory","Ljava/io/File;",false,JValue.Default("Ljava/io/File;"),null));
c.Add(new JField("objectsThatFailedToLoad","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(12497,"forge/util/storage/StorageReaderFolder","getDirectory","()Ljava/io/File;",1,1,1,new JHandler[]{},M12497));
c.Add(new JMethod(12498,"forge/util/storage/StorageReaderFolder","getFullPath","()Ljava/lang/String;",1,1,1,new JHandler[]{},M12498));
c.Add(new JMethod(12499,"forge/util/storage/StorageReaderFolder","<init>","(Ljava/io/File;Ljava/util/function/Function;)V",1,4,3,new JHandler[]{new JHandler(38,86,89,"java/io/IOException")},M12499));
c.Add(new JMethod(12500,"forge/util/storage/StorageReaderFolder","readAll","()Ljava/util/Map;",1,9,4,new JHandler[]{new JHandler(39,151,154,"java/util/NoSuchElementException")},M12500));
c.Add(new JMethod(12501,"forge/util/storage/StorageReaderFolder","read","(Ljava/io/File;)Ljava/lang/Object;",1028,0,0,new JHandler[]{},null));
c.Add(new JMethod(12502,"forge/util/storage/StorageReaderFolder","getFileFilter","()Ljava/io/FilenameFilter;",1028,0,0,new JHandler[]{},null));
c.Add(new JMethod(12503,"forge/util/storage/StorageReaderFolder","getItemKey","(Ljava/lang/Object;)Ljava/lang/String;",1,2,2,new JHandler[]{},M12503));
c.Add(new JMethod(12504,"forge/util/storage/StorageReaderFolder","getSubFolders","()Ljava/lang/Iterable;",1,2,2,new JHandler[]{},M12504));
c.Add(new JMethod(12505,"forge/util/storage/StorageReaderFolder","lambda$getSubFolders$0","(Ljava/io/File;)Z",4106,1,1,new JHandler[]{},M12505));
}

internal static JStep M12497(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFolder","directory","Ljava/io/File;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12498(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFolder","directory","Ljava/io/File;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/io/File","getPath","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12499(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/storage/StorageReaderBase","<init>","(Ljava/util/function/Function;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",13);}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/storage/StorageReaderFolder","objectsThatFailedToLoad","Ljava/util/List;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/storage/StorageReaderFolder","directory","Ljava/io/File;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFolder","directory","Ljava/io/File;"));f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Reference!=null?38:28;continue;}
case 28:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("No directory specified")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",37);}
case 37:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFolder","directory","Ljava/io/File;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/io/File","isFile","()Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int==0?58:48;continue;}
case 48:{if(!rt.EnsureInitialized(f,"java/io/IOException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/IOException")));f.Pc=51;continue;}
case 51:{f.StackOp("dup");f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("Not a directory")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/io/IOException","<init>","(Ljava/lang/String;)V","invokespecial",57);}
case 57:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFolder","directory","Ljava/io/File;"));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/io/File","mkdirs","()Z","invokevirtual",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFolder","directory","Ljava/io/File;"));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/io/File","isDirectory","()Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int!=0?86:76;continue;}
case 76:{if(!rt.EnsureInitialized(f,"java/io/IOException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/IOException")));f.Pc=79;continue;}
case 79:{f.StackOp("dup");f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("Directory can't be created")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/io/IOException","<init>","(Ljava/lang/String;)V","invokespecial",85);}
case 85:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 86:{f.Pc=107;continue;}
case 89:{f.Locals[3]=f.Pop();f.Pc=90;continue;}
case 90:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=93;continue;}
case 93:{f.StackOp("dup");f.Pc=94;continue;}
case 94:{f.Push(f.Locals[3]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/io/IOException","getMessage","()Ljava/lang/String;","invokevirtual",98);}
case 98:{return rt.DynamicCall(f,"forge/util/storage/StorageReaderFolder:12499:98:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",103);}
case 103:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",106);}
case 106:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 107:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12500(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/storage/StorageReaderFolder","createMap","()Ljava/util/Map;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFolder","directory","Ljava/io/File;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/storage/StorageReaderFolder","getFileFilter","()Ljava/io/FilenameFilter;","invokevirtual",13);}
case 13:{return rt.Call(f,"java/io/File","listFiles","(Ljava/io/FilenameFilter;)[Ljava/io/File;","invokevirtual",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=21;continue;}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{f.Locals[5]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?204:33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[5]);f.Pc=36;continue;}
case 36:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=37;continue;}
case 37:{f.Locals[6]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[6]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/util/storage/StorageReaderFolder","read","(Ljava/io/File;)Ljava/lang/Object;","invokevirtual",45);}
case 45:{f.Locals[7]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(JValue.R(null));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[7]);f.Pc=50;continue;}
case 50:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?75:53;continue;}
case 53:{f.Push(f.Locals[6]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/io/File","getPath","()Ljava/lang/String;","invokevirtual",58);}
case 58:{return rt.DynamicCall(f,"forge/util/storage/StorageReaderFolder:12500:58:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",63);}
case 63:{f.Locals[8]=f.Pop();f.Pc=65;continue;}
case 65:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{f.Push(f.Locals[8]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",74);}
case 74:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFolder","keySelector","Ljava/util/function/Function;"));f.Pc=79;continue;}
case 79:{f.Push(f.Locals[7]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",86);}
case 86:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=89;continue;}
case 89:{f.Locals[8]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[1]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[8]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",99);}
case 99:{f.Pc=f.Pop().Int==0?116:102;continue;}
case 102:{f.Push(f.Locals[8]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[6]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/io/File","getName","()Ljava/lang/String;","invokevirtual",109);}
case 109:{return rt.DynamicCall(f,"forge/util/storage/StorageReaderFolder:12500:109:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",114);}
case 114:{f.Locals[8]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[8]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",124);}
case 124:{f.Pc=f.Pop().Int==0?140:127;continue;}
case 127:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=130;continue;}
case 130:{f.Push(f.Locals[8]);f.Pc=132;continue;}
case 132:{return rt.DynamicCall(f,"forge/util/storage/StorageReaderFolder:12500:132:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",137);}
case 137:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",140);}
case 140:{f.Push(f.Locals[1]);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[8]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[7]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",150);}
case 150:{f.StackOp("pop");f.Pc=151;continue;}
case 151:{f.Pc=198;continue;}
case 154:{f.Locals[7]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(JValue.I(3));f.Pc=157;continue;}
case 157:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=160;continue;}
case 160:{f.StackOp("dup");f.Pc=161;continue;}
case 161:{f.Push(JValue.I(0));f.Pc=162;continue;}
case 162:{f.Push(f.Locals[6]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/io/File","getName","()Ljava/lang/String;","invokevirtual",167);}
case 167:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=168;continue;}
case 168:{f.StackOp("dup");f.Pc=169;continue;}
case 169:{f.Push(JValue.I(1));f.Pc=170;continue;}
case 170:{f.Push(JValue.R(rt.String("failed to load because ----")));f.Pc=172;continue;}
case 172:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=173;continue;}
case 173:{f.StackOp("dup");f.Pc=174;continue;}
case 174:{f.Push(JValue.I(2));f.Pc=175;continue;}
case 175:{f.Push(f.Locals[7]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/util/NoSuchElementException","getMessage","()Ljava/lang/String;","invokevirtual",180);}
case 180:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",184);}
case 184:{f.Locals[8]=f.Pop();f.Pc=186;continue;}
case 186:{f.Push(f.Locals[0]);f.Pc=187;continue;}
case 187:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFolder","objectsThatFailedToLoad","Ljava/util/List;"));f.Pc=190;continue;}
case 190:{f.Push(f.Locals[8]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",197);}
case 197:{f.StackOp("pop");f.Pc=198;continue;}
case 198:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=201;continue;}
case 201:{f.Pc=26;continue;}
case 204:{f.Push(f.Locals[1]);f.Pc=205;continue;}
case 205:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12503(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFolder","keySelector","Ljava/util/function/Function;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12504(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFolder","directory","Ljava/io/File;"));f.Pc=4;continue;}
case 4:{return rt.DynamicCall(f,"forge/util/storage/StorageReaderFolder:12504:4:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/io/FileFilter;",9);}
case 9:{return rt.Call(f,"java/io/File","listFiles","(Ljava/io/FileFilter;)[Ljava/io/File;","invokevirtual",12);}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",17);}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12505(JRuntime rt,JFrame f)
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

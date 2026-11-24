// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1123{
internal static JClass Build(){var c=new JClass("forge/util/FileUtil","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(11747,"forge/util/FileUtil","<init>","()V",2,1,2,new JHandler[]{},M11747));
c.Add(new JMethod(11748,"forge/util/FileUtil","pathCombine","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",9,4,4,new JHandler[]{},M11748));
c.Add(new JMethod(11749,"forge/util/FileUtil","doesFileExist","(Ljava/lang/String;)Z",9,2,3,new JHandler[]{},M11749));
c.Add(new JMethod(11750,"forge/util/FileUtil","isDirectoryWithFiles","(Ljava/lang/String;)Z",9,3,3,new JHandler[]{},M11750));
c.Add(new JMethod(11751,"forge/util/FileUtil","ensureDirectoryExists","(Ljava/lang/String;)Z",9,1,3,new JHandler[]{},M11751));
c.Add(new JMethod(11752,"forge/util/FileUtil","ensureDirectoryExists","(Ljava/io/File;)Z",9,1,1,new JHandler[]{},M11752));
c.Add(new JMethod(11753,"forge/util/FileUtil","deleteDirectory","(Ljava/io/File;)Z",9,5,4,new JHandler[]{},M11753));
c.Add(new JMethod(11754,"forge/util/FileUtil","deleteFile","(Ljava/lang/String;)Z",9,2,3,new JHandler[]{new JHandler(0,13,14,"java/lang/Exception")},M11754));
c.Add(new JMethod(11755,"forge/util/FileUtil","copyFile","(Ljava/lang/String;Ljava/lang/String;)V",9,7,4,new JHandler[]{new JHandler(49,81,94,"java/lang/Throwable"),new JHandler(101,106,109,"java/lang/Throwable"),new JHandler(29,121,132,"java/lang/Throwable"),new JHandler(138,142,145,"java/lang/Throwable"),new JHandler(17,157,160,"java/lang/Exception")},M11755));
c.Add(new JMethod(11756,"forge/util/FileUtil","writeFile","(Ljava/lang/String;Ljava/lang/String;)V",9,2,3,new JHandler[]{},M11756));
c.Add(new JMethod(11757,"forge/util/FileUtil","writeFile","(Ljava/io/File;Ljava/lang/String;)V",9,5,4,new JHandler[]{new JHandler(9,14,21,"java/lang/Throwable"),new JHandler(22,26,29,"java/lang/Throwable"),new JHandler(0,39,42,"java/lang/Exception")},M11757));
c.Add(new JMethod(11758,"forge/util/FileUtil","writeFile","(Ljava/lang/String;Ljava/util/List;)V",9,2,3,new JHandler[]{},M11758));
c.Add(new JMethod(11759,"forge/util/FileUtil","writeFile","(Ljava/io/File;Ljava/util/Collection;)V",9,5,4,new JHandler[]{new JHandler(9,42,49,"java/lang/Throwable"),new JHandler(50,54,57,"java/lang/Throwable"),new JHandler(0,67,70,"java/lang/Exception")},M11759));
c.Add(new JMethod(11760,"forge/util/FileUtil","readFileToString","(Ljava/lang/String;)Ljava/lang/String;",9,1,3,new JHandler[]{},M11760));
c.Add(new JMethod(11761,"forge/util/FileUtil","readFileToString","(Ljava/io/File;)Ljava/lang/String;",9,1,2,new JHandler[]{},M11761));
c.Add(new JMethod(11762,"forge/util/FileUtil","readFile","(Ljava/lang/String;)Ljava/util/List;",9,1,3,new JHandler[]{},M11762));
c.Add(new JMethod(11763,"forge/util/FileUtil","readFile","(Ljava/io/File;)Ljava/util/List;",9,2,3,new JHandler[]{new JHandler(0,18,25,"java/lang/Exception"),new JHandler(19,24,25,"java/lang/Exception")},M11763));
c.Add(new JMethod(11764,"forge/util/FileUtil","readAllLines","(Ljava/io/Reader;)Ljava/util/List;",9,1,2,new JHandler[]{},M11764));
c.Add(new JMethod(11765,"forge/util/FileUtil","readAllLines","(Ljava/io/Reader;Z)Ljava/util/List;",9,5,3,new JHandler[]{new JHandler(8,54,57,"java/io/IOException")},M11765));
c.Add(new JMethod(11766,"forge/util/FileUtil","readAllLines","(Ljava/io/File;Z)Ljava/util/List;",9,5,6,new JHandler[]{new JHandler(8,74,77,"java/io/IOException")},M11766));
c.Add(new JMethod(11767,"forge/util/FileUtil","readNameUrlFile","(Ljava/lang/String;)Ljava/util/List;",9,10,4,new JHandler[]{},M11767));
c.Add(new JMethod(11768,"forge/util/FileUtil","readFileToString","(Ljava/net/URL;)Ljava/lang/String;",9,1,2,new JHandler[]{},M11768));
c.Add(new JMethod(11769,"forge/util/FileUtil","readFile","(Ljava/net/URL;)Ljava/util/List;",9,2,2,new JHandler[]{},M11769));
c.Add(new JMethod(11770,"forge/util/FileUtil","getParent","(Ljava/lang/String;)Ljava/lang/String;",9,2,3,new JHandler[]{},M11770));
c.Add(new JMethod(11771,"forge/util/FileUtil","lambda$readFile$0","(Ljava/net/URL;Ljava/util/List;)Ljava/lang/Void;",4106,5,5,new JHandler[]{new JHandler(19,39,46,"java/lang/Throwable"),new JHandler(47,51,54,"java/lang/Throwable")},M11771));
}

internal static JStep M11747(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{if(!rt.EnsureInitialized(f,"java/lang/AssertionError"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/AssertionError")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/AssertionError","<init>","()V","invokespecial",11);}
case 11:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11748(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/io/File","<init>","(Ljava/io/File;Ljava/lang/String;)V","invokespecial",18);}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/io/File","getPath","()Ljava/lang/String;","invokevirtual",23);}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11749(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",8);}
case 8:{f.Locals[1]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/io/File","exists","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11750(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",14);}
case 14:{f.Locals[1]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/io/File","list","()[Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Pc=f.Pop().Reference==null?33:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=26;continue;}
case 26:{f.Pc=f.Pop().Int<=0?33:29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{f.Pc=34;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11751(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",8);}
case 8:{return rt.Call(f,"forge/util/FileUtil","ensureDirectoryExists","(Ljava/io/File;)Z","invokestatic",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11752(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/io/File","exists","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?14:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/io/File","isDirectory","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?21:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/io/File","mkdirs","()Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?25:21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Pc=26;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11753(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/io/File","isDirectory","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?51:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/io/File","list","()[Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=14;continue;}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?51:22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=25;continue;}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/io/File","<init>","(Ljava/io/File;Ljava/lang/String;)V","invokespecial",37);}
case 37:{return rt.Call(f,"forge/util/FileUtil","deleteDirectory","(Ljava/io/File;)Z","invokestatic",40);}
case 40:{f.Pc=f.Pop().Int!=0?45:43;continue;}
case 43:{f.Push(JValue.I(0));f.Pc=44;continue;}
case 44:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 45:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=48;continue;}
case 48:{f.Pc=17;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/io/File","delete","()Z","invokevirtual",55);}
case 55:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11754(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",8);}
case 8:{f.Locals[1]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/io/File","delete","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 14:{f.Locals[1]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/Exception","printStackTrace","()V","invokevirtual",19);}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11755(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/io/File","exists","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int!=0?17:16;continue;}
case 16:{return JStep.ReturnVoid;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/io/File","toPath","()Ljava/nio/file/Path;","invokevirtual",21);}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.NewArray("Ljava/nio/file/OpenOption;",f.Pop().Int)));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/nio/file/Files","newInputStream","(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/InputStream;","invokestatic",28);}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=32;continue;}
case 32:{f.StackOp("dup");f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",37);}
case 37:{return rt.Call(f,"java/io/File","toPath","()Ljava/nio/file/Path;","invokevirtual",40);}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.NewArray("Ljava/nio/file/OpenOption;",f.Pop().Int)));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/nio/file/Files","newOutputStream","(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/OutputStream;","invokestatic",47);}
case 47:{f.Locals[4]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(JValue.I(1024));f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.NewArray("B",f.Pop().Int)));f.Pc=54;continue;}
case 54:{f.Locals[5]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/io/InputStream","read","([B)I","invokevirtual",62);}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Locals[6]=f.Pop();f.Pc=65;continue;}
case 65:{f.Pc=f.Pop().Int<=0?81:68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[5]);f.Pc=72;continue;}
case 72:{f.Push(JValue.I(0));f.Pc=73;continue;}
case 73:{f.Push(f.Locals[6]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/io/OutputStream","write","([BII)V","invokevirtual",78);}
case 78:{f.Pc=56;continue;}
case 81:{f.Push(f.Locals[4]);f.Pc=83;continue;}
case 83:{f.Pc=f.Pop().Reference==null?121:86;continue;}
case 86:{f.Push(f.Locals[4]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/io/OutputStream","close","()V","invokevirtual",91);}
case 91:{f.Pc=121;continue;}
case 94:{f.Locals[5]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[4]);f.Pc=98;continue;}
case 98:{f.Pc=f.Pop().Reference==null?118:101;continue;}
case 101:{f.Push(f.Locals[4]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/io/OutputStream","close","()V","invokevirtual",106);}
case 106:{f.Pc=118;continue;}
case 109:{f.Locals[6]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(f.Locals[5]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[6]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/Throwable","addSuppressed","(Ljava/lang/Throwable;)V","invokevirtual",118);}
case 118:{f.Push(f.Locals[5]);f.Pc=120;continue;}
case 120:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 121:{f.Push(f.Locals[3]);f.Pc=122;continue;}
case 122:{f.Pc=f.Pop().Reference==null?157:125;continue;}
case 125:{f.Push(f.Locals[3]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/io/InputStream","close","()V","invokevirtual",129);}
case 129:{f.Pc=157;continue;}
case 132:{f.Locals[4]=f.Pop();f.Pc=134;continue;}
case 134:{f.Push(f.Locals[3]);f.Pc=135;continue;}
case 135:{f.Pc=f.Pop().Reference==null?154:138;continue;}
case 138:{f.Push(f.Locals[3]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/io/InputStream","close","()V","invokevirtual",142);}
case 142:{f.Pc=154;continue;}
case 145:{f.Locals[5]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(f.Locals[4]);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[5]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/lang/Throwable","addSuppressed","(Ljava/lang/Throwable;)V","invokevirtual",154);}
case 154:{f.Push(f.Locals[4]);f.Pc=156;continue;}
case 156:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 157:{f.Pc=165;continue;}
case 160:{f.Locals[3]=f.Pop();f.Pc=161;continue;}
case 161:{f.Push(f.Locals[3]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/lang/Exception","printStackTrace","()V","invokevirtual",165);}
case 165:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11756(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",8);}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/FileUtil","writeFile","(Ljava/io/File;Ljava/lang/String;)V","invokestatic",12);}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11757(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/io/PrintWriter"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/PrintWriter")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/io/PrintWriter","<init>","(Ljava/io/File;)V","invokespecial",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/io/PrintWriter","print","(Ljava/lang/String;)V","invokevirtual",14);}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/io/PrintWriter","close","()V","invokevirtual",18);}
case 18:{f.Pc=39;continue;}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/io/PrintWriter","close","()V","invokevirtual",26);}
case 26:{f.Pc=37;continue;}
case 29:{f.Locals[4]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/Throwable","addSuppressed","(Ljava/lang/Throwable;)V","invokevirtual",37);}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 39:{f.Pc=64;continue;}
case 42:{f.Locals[2]=f.Pop();f.Pc=43;continue;}
case 43:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=46;continue;}
case 46:{f.StackOp("dup");f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",51);}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",55);}
case 55:{return rt.DynamicCall(f,"forge/util/FileUtil:11757:55:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",60);}
case 60:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",63);}
case 63:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 64:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11758(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",8);}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/FileUtil","writeFile","(Ljava/io/File;Ljava/util/Collection;)V","invokestatic",12);}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11759(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/io/PrintWriter"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/PrintWriter")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/io/PrintWriter","<init>","(Ljava/io/File;)V","invokespecial",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?42:25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/io/PrintWriter","println","(Ljava/lang/Object;)V","invokevirtual",39);}
case 39:{f.Pc=16;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/io/PrintWriter","close","()V","invokevirtual",46);}
case 46:{f.Pc=67;continue;}
case 49:{f.Locals[3]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/io/PrintWriter","close","()V","invokevirtual",54);}
case 54:{f.Pc=65;continue;}
case 57:{f.Locals[4]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/Throwable","addSuppressed","(Ljava/lang/Throwable;)V","invokevirtual",65);}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 67:{f.Pc=92;continue;}
case 70:{f.Locals[2]=f.Pop();f.Pc=71;continue;}
case 71:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=74;continue;}
case 74:{f.StackOp("dup");f.Pc=75;continue;}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",79);}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",83);}
case 83:{return rt.DynamicCall(f,"forge/util/FileUtil:11759:83:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",88);}
case 88:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",91);}
case 91:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 92:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11760(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",8);}
case 8:{return rt.Call(f,"forge/util/FileUtil","readFileToString","(Ljava/io/File;)Ljava/lang/String;","invokestatic",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11761(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/FileUtil","readFile","(Ljava/io/File;)Ljava/util/List;","invokestatic",4);}
case 4:{f.Push(JValue.R(rt.String("\n")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/util/TextUtil","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11762(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",8);}
case 8:{return rt.Call(f,"forge/util/FileUtil","readFile","(Ljava/io/File;)Ljava/util/List;","invokestatic",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11763(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?11:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/io/File","exists","()Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int!=0?19:11;continue;}
case 11:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",18);}
case 18:{return JStep.Return(f.Pop());}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/util/FileUtil","readAllLines","(Ljava/io/File;Z)Ljava/util/List;","invokestatic",24);}
case 24:{return JStep.Return(f.Pop());}
case 25:{f.Locals[1]=f.Pop();f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",34);}
case 34:{return rt.DynamicCall(f,"forge/util/FileUtil:11763:34:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",39);}
case 39:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",42);}
case 42:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11764(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/FileUtil","readAllLines","(Ljava/io/Reader;Z)Ljava/util/List;","invokestatic",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11765(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"java/io/BufferedReader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/BufferedReader")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/io/BufferedReader","<init>","(Ljava/io/Reader;)V","invokespecial",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/io/BufferedReader","readLine","()Ljava/lang/String;","invokevirtual",21);}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Reference==null?50:27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Pc=f.Pop().Int==0?38:31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",36);}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",46);}
case 46:{f.StackOp("pop");f.Pc=47;continue;}
case 47:{f.Pc=17;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/io/BufferedReader","close","()V","invokevirtual",54);}
case 54:{f.Pc=75;continue;}
case 57:{f.Locals[3]=f.Pop();f.Pc=58;continue;}
case 58:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=61;continue;}
case 61:{f.StackOp("dup");f.Pc=62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",66);}
case 66:{return rt.DynamicCall(f,"forge/util/FileUtil:11765:66:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",71);}
case 71:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",74);}
case 74:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11766(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"java/io/BufferedReader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/BufferedReader")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{if(!rt.EnsureInitialized(f,"java/io/InputStreamReader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/InputStreamReader")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/io/File","toPath","()Ljava/nio/file/Path;","invokevirtual",20);}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.NewArray("Ljava/nio/file/OpenOption;",f.Pop().Int)));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/nio/file/Files","newInputStream","(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/InputStream;","invokestatic",27);}
case 27:{if(!rt.StaticReady(f,"java/nio/charset/StandardCharsets","UTF_8","Ljava/nio/charset/Charset;"))return JStep.Continue;f.Push(rt.GetStatic("java/nio/charset/StandardCharsets","UTF_8","Ljava/nio/charset/Charset;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/io/InputStreamReader","<init>","(Ljava/io/InputStream;Ljava/nio/charset/Charset;)V","invokespecial",33);}
case 33:{return rt.Call(f,"java/io/BufferedReader","<init>","(Ljava/io/Reader;)V","invokespecial",36);}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/io/BufferedReader","readLine","()Ljava/lang/String;","invokevirtual",41);}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Locals[4]=f.Pop();f.Pc=44;continue;}
case 44:{f.Pc=f.Pop().Reference==null?70:47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Pc=f.Pop().Int==0?58:51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",56);}
case 56:{f.Locals[4]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",66);}
case 66:{f.StackOp("pop");f.Pc=67;continue;}
case 67:{f.Pc=37;continue;}
case 70:{f.Push(f.Locals[3]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/io/BufferedReader","close","()V","invokevirtual",74);}
case 74:{f.Pc=95;continue;}
case 77:{f.Locals[3]=f.Pop();f.Pc=78;continue;}
case 78:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=81;continue;}
case 81:{f.StackOp("dup");f.Pc=82;continue;}
case 82:{f.Push(f.Locals[3]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",86);}
case 86:{return rt.DynamicCall(f,"forge/util/FileUtil:11766:86:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",91);}
case 91:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",94);}
case 94:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 95:{f.Push(f.Locals[2]);f.Pc=96;continue;}
case 96:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11767(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String(" ")));f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/regex/Pattern","quote","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",5);}
case 5:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",8);}
case 8:{f.Locals[1]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("%20")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/regex/Pattern","quote","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",14);}
case 14:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=21;continue;}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",25);}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/util/FileUtil","readFile","(Ljava/lang/String;)Ljava/util/List;","invokestatic",30);}
case 30:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",35);}
case 35:{f.Locals[4]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",44);}
case 44:{f.Pc=f.Pop().Int==0?185:47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",54);}
case 54:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=57;continue;}
case 57:{f.Locals[5]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[5]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isBlank","(Ljava/lang/CharSequence;)Z","invokestatic",64);}
case 64:{f.Pc=f.Pop().Int!=0?37:67;continue;}
case 67:{f.Push(f.Locals[5]);f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("#")));f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int==0?80:77;continue;}
case 77:{f.Pc=37;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[5]);f.Pc=83;continue;}
case 83:{f.Push(JValue.I(2));f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/regex/Pattern","split","(Ljava/lang/CharSequence;I)[Ljava/lang/String;","invokevirtual",87);}
case 87:{f.Locals[6]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(JValue.I(2));f.Pc=90;continue;}
case 90:{f.Push(f.Locals[6]);f.Pc=92;continue;}
case 92:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=93;continue;}
case 93:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?126:96;continue;}
case 96:{f.Push(f.Locals[3]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[2]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[6]);f.Pc=100;continue;}
case 100:{f.Push(JValue.I(0));f.Pc=101;continue;}
case 101:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",105);}
case 105:{f.Push(JValue.R(rt.String(" ")));f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/util/regex/Matcher","replaceAll","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",110);}
case 110:{f.Push(f.Locals[6]);f.Pc=112;continue;}
case 112:{f.Push(JValue.I(1));f.Pc=113;continue;}
case 113:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=114;continue;}
case 114:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",117);}
case 117:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",122);}
case 122:{f.StackOp("pop");f.Pc=123;continue;}
case 123:{f.Pc=182;continue;}
case 126:{f.Push(JValue.R(rt.String("/")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/regex/Pattern","quote","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",131);}
case 131:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",134);}
case 134:{f.Locals[7]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[7]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[6]);f.Pc=140;continue;}
case 140:{f.Push(JValue.I(0));f.Pc=141;continue;}
case 141:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/util/regex/Pattern","split","(Ljava/lang/CharSequence;)[Ljava/lang/String;","invokevirtual",145);}
case 145:{f.Locals[8]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(f.Locals[8]);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[8]);f.Pc=151;continue;}
case 151:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=152;continue;}
case 152:{f.Push(JValue.I(1));f.Pc=153;continue;}
case 153:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=154;continue;}
case 154:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=155;continue;}
case 155:{f.Locals[9]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(f.Locals[3]);f.Pc=158;continue;}
case 158:{f.Push(f.Locals[2]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[9]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",164);}
case 164:{f.Push(JValue.R(rt.String(" ")));f.Pc=166;continue;}
case 166:{return rt.Call(f,"java/util/regex/Matcher","replaceAll","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",169);}
case 169:{f.Push(f.Locals[6]);f.Pc=171;continue;}
case 171:{f.Push(JValue.I(0));f.Pc=172;continue;}
case 172:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=173;continue;}
case 173:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",176);}
case 176:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",181);}
case 181:{f.StackOp("pop");f.Pc=182;continue;}
case 182:{f.Pc=37;continue;}
case 185:{f.Push(f.Locals[3]);f.Pc=186;continue;}
case 186:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11768(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/FileUtil","readFile","(Ljava/net/URL;)Ljava/util/List;","invokestatic",4);}
case 4:{f.Push(JValue.R(rt.String("\n")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/util/TextUtil","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11769(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.DynamicCall(f,"forge/util/FileUtil:11769:10:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/net/URL;Ljava/util/List;)Ljava/util/concurrent/Callable;",15);}
case 15:{f.Push(JValue.I(5000));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/ThreadUtil","executeWithTimeout","(Ljava/util/concurrent/Callable;I)Ljava/lang/Object;","invokestatic",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11770(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",8);}
case 8:{f.Locals[1]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/io/File","getParentFile","()Ljava/io/File;","invokevirtual",13);}
case 13:{return rt.Call(f,"java/io/File","getName","()Ljava/lang/String;","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Reference==null?27:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/io/File","getParentFile","()Ljava/io/File;","invokevirtual",23);}
case 23:{return rt.Call(f,"java/io/File","getName","()Ljava/lang/String;","invokevirtual",26);}
case 26:{return JStep.Return(f.Pop());}
case 27:{f.Push(JValue.R(rt.String("")));f.Pc=30;continue;}
case 30:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11771(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/io/BufferedReader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/BufferedReader")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"java/io/InputStreamReader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/InputStreamReader")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/net/URL","openStream","()Ljava/io/InputStream;","invokevirtual",12);}
case 12:{return rt.Call(f,"java/io/InputStreamReader","<init>","(Ljava/io/InputStream;)V","invokespecial",15);}
case 15:{return rt.Call(f,"java/io/BufferedReader","<init>","(Ljava/io/Reader;)V","invokespecial",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/io/BufferedReader","readLine","()Ljava/lang/String;","invokevirtual",23);}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Reference==null?39:28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{f.Pc=19;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/io/BufferedReader","close","()V","invokevirtual",43);}
case 43:{f.Pc=64;continue;}
case 46:{f.Locals[3]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/io/BufferedReader","close","()V","invokevirtual",51);}
case 51:{f.Pc=62;continue;}
case 54:{f.Locals[4]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/Throwable","addSuppressed","(Ljava/lang/Throwable;)V","invokevirtual",62);}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 64:{f.Push(JValue.R(null));f.Pc=65;continue;}
case 65:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

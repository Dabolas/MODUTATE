// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1111{
internal static JClass Build(){var c=new JClass("forge/util/BuildInfo","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("timestamp","Ljava/util/Date;",true,JValue.Default("Ljava/util/Date;"),null));
c.Add(new JMethod(11676,"forge/util/BuildInfo","<init>","()V",2,1,1,new JHandler[]{},M11676));
c.Add(new JMethod(11677,"forge/util/BuildInfo","getVersionString","()Ljava/lang/String;",9,1,1,new JHandler[]{},M11677));
c.Add(new JMethod(11678,"forge/util/BuildInfo","isDevelopmentVersion","()Z",9,1,2,new JHandler[]{},M11678));
c.Add(new JMethod(11679,"forge/util/BuildInfo","getTimestamp","()Ljava/util/Date;",9,3,3,new JHandler[]{new JHandler(10,41,44,"java/lang/Exception")},M11679));
c.Add(new JMethod(11680,"forge/util/BuildInfo","verifyTimestamp","(Ljava/util/Date;)Z",9,1,4,new JHandler[]{},M11680));
c.Add(new JMethod(11681,"forge/util/BuildInfo","readFromInputStream","(Ljava/io/InputStream;)Ljava/lang/String;",10,5,5,new JHandler[]{new JHandler(24,47,54,"java/lang/Throwable"),new JHandler(55,59,62,"java/lang/Throwable")},M11681));
c.Add(new JMethod(11682,"forge/util/BuildInfo","<clinit>","()V",8,0,1,new JHandler[]{},M11682));
}

internal static JStep M11676(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11677(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/util/BuildInfo")));f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/lang/Class","getPackage","()Ljava/lang/Package;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/lang/Package","getImplementationVersion","()Ljava/lang/String;","invokevirtual",8);}
case 8:{f.Locals[0]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",13);}
case 13:{f.Pc=f.Pop().Int==0?19:16;continue;}
case 16:{f.Push(JValue.R(rt.String("GIT")));f.Pc=18;continue;}
case 18:{return JStep.Return(f.Pop());}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11678(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/BuildInfo","getVersionString","()Ljava/lang/String;","invokestatic",3);}
case 3:{f.Locals[0]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("git")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","containsIgnoreCase","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z","invokestatic",10);}
case 10:{f.Pc=f.Pop().Int!=0?22:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("snapshot")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","containsIgnoreCase","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z","invokestatic",19);}
case 19:{f.Pc=f.Pop().Int==0?26:22;continue;}
case 22:{f.Push(JValue.I(1));f.Pc=23;continue;}
case 23:{f.Pc=27;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11679(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/BuildInfo","timestamp","Ljava/util/Date;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/BuildInfo","timestamp","Ljava/util/Date;"));f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Reference==null?10:6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/util/BuildInfo","timestamp","Ljava/util/Date;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/BuildInfo","timestamp","Ljava/util/Date;"));f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
case 10:{if(!rt.EnsureInitialized(f,"java/text/SimpleDateFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/text/SimpleDateFormat")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("yyyy-MM-dd HH:mm:ss")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/text/SimpleDateFormat","<init>","(Ljava/lang/String;)V","invokespecial",19);}
case 19:{f.Locals[0]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.ClassObject("forge/util/BuildInfo")));f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("/build.txt")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/Class","getResourceAsStream","(Ljava/lang/String;)Ljava/io/InputStream;","invokevirtual",27);}
case 27:{f.Locals[1]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/util/BuildInfo","readFromInputStream","(Ljava/io/InputStream;)Ljava/lang/String;","invokestatic",32);}
case 32:{f.Locals[2]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/text/SimpleDateFormat","parse","(Ljava/lang/String;)Ljava/util/Date;","invokevirtual",38);}
case 38:{if(!rt.StaticReady(f,"forge/util/BuildInfo","timestamp","Ljava/util/Date;"))return JStep.Continue;rt.PutStatic("forge/util/BuildInfo","timestamp","Ljava/util/Date;",f.Pop());f.Pc=41;continue;}
case 41:{f.Pc=49;continue;}
case 44:{f.Locals[0]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/Exception","printStackTrace","()V","invokevirtual",49);}
case 49:{if(!rt.StaticReady(f,"forge/util/BuildInfo","timestamp","Ljava/util/Date;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/BuildInfo","timestamp","Ljava/util/Date;"));f.Pc=52;continue;}
case 52:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11680(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{return rt.Call(f,"forge/util/BuildInfo","getTimestamp","()Ljava/util/Date;","invokestatic",9);}
case 9:{f.Pc=f.Pop().Reference!=null?14:12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 14:{return rt.Call(f,"forge/util/BuildInfo","getTimestamp","()Ljava/util/Date;","invokestatic",17);}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/DateUtil","getElapsedHours","(Ljava/util/Date;Ljava/util/Date;)J","invokestatic",21);}
case 21:{f.Push(JValue.L(23L));f.Pc=24;continue;}
case 24:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Int<=0?32:28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{f.Pc=33;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11681(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"java/io/BufferedReader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/BufferedReader")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{if(!rt.EnsureInitialized(f,"java/io/InputStreamReader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/InputStreamReader")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/io/InputStreamReader","<init>","(Ljava/io/InputStream;)V","invokespecial",20);}
case 20:{return rt.Call(f,"java/io/BufferedReader","<init>","(Ljava/io/Reader;)V","invokespecial",23);}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/io/BufferedReader","readLine","()Ljava/lang/String;","invokevirtual",28);}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Reference==null?47:33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",38);}
case 38:{f.Push(JValue.R(rt.String("\n")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",43);}
case 43:{f.StackOp("pop");f.Pc=44;continue;}
case 44:{f.Pc=24;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/io/BufferedReader","close","()V","invokevirtual",51);}
case 51:{f.Pc=72;continue;}
case 54:{f.Locals[3]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/io/BufferedReader","close","()V","invokevirtual",59);}
case 59:{f.Pc=70;continue;}
case 62:{f.Locals[4]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[4]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/Throwable","addSuppressed","(Ljava/lang/Throwable;)V","invokevirtual",70);}
case 70:{f.Push(f.Locals[3]);f.Pc=71;continue;}
case 71:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",76);}
case 76:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11682(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/util/BuildInfo","timestamp","Ljava/util/Date;"))return JStep.Continue;rt.PutStatic("forge/util/BuildInfo","timestamp","Ljava/util/Date;",f.Pop());f.Pc=4;continue;}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

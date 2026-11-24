// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1203{
internal static JClass Build(){var c=new JClass("forge/util/storage/StorageReaderFile","forge/util/storage/StorageReaderBase",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("file","Ljava/io/File;",false,JValue.Default("Ljava/io/File;"),null));
c.Add(new JMethod(12481,"forge/util/storage/StorageReaderFile","<init>","(Ljava/lang/String;Ljava/util/function/Function;)V",1,3,4,new JHandler[]{},M12481));
c.Add(new JMethod(12482,"forge/util/storage/StorageReaderFile","<init>","(Ljava/io/File;Ljava/util/function/Function;)V",1,3,2,new JHandler[]{},M12482));
c.Add(new JMethod(12483,"forge/util/storage/StorageReaderFile","getFullPath","()Ljava/lang/String;",1,1,1,new JHandler[]{},M12483));
c.Add(new JMethod(12484,"forge/util/storage/StorageReaderFile","readAll","()Ljava/util/Map;",1,7,3,new JHandler[]{},M12484));
c.Add(new JMethod(12485,"forge/util/storage/StorageReaderFile","read","(Ljava/lang/String;I)Ljava/lang/Object;",1028,0,0,new JHandler[]{},null));
c.Add(new JMethod(12486,"forge/util/storage/StorageReaderFile","lineContainsObject","(Ljava/lang/String;)Z",4,2,2,new JHandler[]{},M12486));
c.Add(new JMethod(12487,"forge/util/storage/StorageReaderFile","getItemKey","(Ljava/lang/Object;)Ljava/lang/String;",1,2,2,new JHandler[]{},M12487));
c.Add(new JMethod(12488,"forge/util/storage/StorageReaderFile","alertInvalidLine","(Ljava/lang/String;Ljava/lang/String;)V",4,3,2,new JHandler[]{},M12488));
}

internal static JStep M12481(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",9);}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/storage/StorageReaderFile","<init>","(Ljava/io/File;Ljava/util/function/Function;)V","invokespecial",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12482(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/storage/StorageReaderBase","<init>","(Ljava/util/function/Function;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/storage/StorageReaderFile","file","Ljava/io/File;",value);f.Pc=10;continue;}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12483(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFile","file","Ljava/io/File;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/io/File","getPath","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12484(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/storage/StorageReaderFile","createMap","()Ljava/util/Map;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFile","file","Ljava/io/File;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/util/FileUtil","readFile","(Ljava/io/File;)Ljava/util/List;","invokestatic",14);}
case 14:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",19);}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?144:29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",45);}
case 45:{f.Locals[4]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int==0?58:55;continue;}
case 55:{f.Pc=20;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/util/storage/StorageReaderFile","lineContainsObject","(Ljava/lang/String;)Z","invokevirtual",64);}
case 64:{f.Pc=f.Pop().Int!=0?70:67;continue;}
case 67:{f.Pc=20;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[4]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/util/storage/StorageReaderFile","read","(Ljava/lang/String;I)Ljava/lang/Object;","invokevirtual",77);}
case 77:{f.Locals[5]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[5]);f.Pc=81;continue;}
case 81:{f.Pc=f.Pop().Reference!=null?87:84;continue;}
case 84:{f.Pc=20;continue;}
case 87:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFile","keySelector","Ljava/util/function/Function;"));f.Pc=94;continue;}
case 94:{f.Push(f.Locals[5]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",101);}
case 101:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=104;continue;}
case 104:{f.Locals[6]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(f.Locals[1]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[6]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",114);}
case 114:{f.Pc=f.Pop().Int==0?130:117;continue;}
case 117:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=120;continue;}
case 120:{f.Push(f.Locals[6]);f.Pc=122;continue;}
case 122:{return rt.DynamicCall(f,"forge/util/storage/StorageReaderFile:12484:122:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",127);}
case 127:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",130);}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[6]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[5]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",140);}
case 140:{f.StackOp("pop");f.Pc=141;continue;}
case 141:{f.Pc=20;continue;}
case 144:{f.Push(f.Locals[1]);f.Pc=145;continue;}
case 145:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12486(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isBlank","(Ljava/lang/CharSequence;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int!=0?23:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Push(JValue.R(rt.String("#")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int!=0?23:19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12487(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFile","keySelector","Ljava/util/function/Function;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12488(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[2]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",7);}
case 7:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",14);}
case 14:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFile","file","Ljava/io/File;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/io/File","getPath","()Ljava/lang/String;","invokevirtual",24);}
case 24:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",27);}
case 27:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/io/PrintStream","println","()V","invokevirtual",33);}
case 33:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1204{
internal static JClass Build(){var c=new JClass("forge/util/storage/StorageReaderFileSections","forge/util/storage/StorageReaderBase",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("file","Ljava/io/File;",false,JValue.Default("Ljava/io/File;"),null));
c.Add(new JMethod(12489,"forge/util/storage/StorageReaderFileSections","<init>","(Ljava/lang/String;Ljava/util/function/Function;)V",1,3,4,new JHandler[]{},M12489));
c.Add(new JMethod(12490,"forge/util/storage/StorageReaderFileSections","<init>","(Ljava/io/File;Ljava/util/function/Function;)V",1,3,2,new JHandler[]{},M12490));
c.Add(new JMethod(12491,"forge/util/storage/StorageReaderFileSections","getFullPath","()Ljava/lang/String;",1,1,1,new JHandler[]{},M12491));
c.Add(new JMethod(12492,"forge/util/storage/StorageReaderFileSections","readAll","()Ljava/util/Map;",1,9,4,new JHandler[]{},M12492));
c.Add(new JMethod(12493,"forge/util/storage/StorageReaderFileSections","readItem","(Ljava/lang/String;Ljava/lang/Iterable;I)Ljava/lang/Object;",2,6,4,new JHandler[]{},M12493));
c.Add(new JMethod(12494,"forge/util/storage/StorageReaderFileSections","read","(Ljava/lang/String;Ljava/lang/Iterable;I)Ljava/lang/Object;",1028,0,0,new JHandler[]{},null));
c.Add(new JMethod(12495,"forge/util/storage/StorageReaderFileSections","lineContainsObject","(Ljava/lang/String;)Z",4,2,2,new JHandler[]{},M12495));
c.Add(new JMethod(12496,"forge/util/storage/StorageReaderFileSections","getItemKey","(Ljava/lang/Object;)Ljava/lang/String;",1,2,2,new JHandler[]{},M12496));
}

internal static JStep M12489(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",9);}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/storage/StorageReaderFileSections","<init>","(Ljava/io/File;Ljava/util/function/Function;)V","invokespecial",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12490(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/storage/StorageReaderBase","<init>","(Ljava/util/function/Function;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/storage/StorageReaderFileSections","file","Ljava/io/File;",value);f.Pc=10;continue;}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12491(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFileSections","file","Ljava/io/File;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/io/File","getPath","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12492(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/storage/StorageReaderFileSections","createMap","()Ljava/util/Map;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFileSections","file","Ljava/io/File;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/util/FileUtil","readFile","(Ljava/io/File;)Ljava/util/List;","invokestatic",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",22);}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(JValue.R(null));f.Pc=25;continue;}
case 25:{f.Locals[5]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",33);}
case 33:{f.Locals[6]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[6]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int==0?159:45;continue;}
case 45:{f.Push(f.Locals[6]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{f.Locals[7]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[7]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/util/storage/StorageReaderFileSections","lineContainsObject","(Ljava/lang/String;)Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int!=0?69:66;continue;}
case 66:{f.Pc=35;continue;}
case 69:{f.Push(f.Locals[7]);f.Pc=71;continue;}
case 71:{f.Push(JValue.I(0));f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",75);}
case 75:{f.Push(JValue.I(91));f.Pc=77;continue;}
case 77:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?146:80;continue;}
case 80:{f.Push(f.Locals[5]);f.Pc=82;continue;}
case 82:{f.Pc=f.Pop().Reference==null?127:85;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[5]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[4]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/util/storage/StorageReaderFileSections","readItem","(Ljava/lang/String;Ljava/lang/Iterable;I)Ljava/lang/Object;","invokevirtual",94);}
case 94:{f.Locals[8]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[8]);f.Pc=98;continue;}
case 98:{f.Pc=f.Pop().Reference==null?127:101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFileSections","keySelector","Ljava/util/function/Function;"));f.Pc=106;continue;}
case 106:{f.Push(f.Locals[8]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",113);}
case 113:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[8]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",123);}
case 123:{f.StackOp("pop");f.Pc=124;continue;}
case 124:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=127;continue;}
case 127:{f.Push(f.Locals[7]);f.Pc=129;continue;}
case 129:{f.Push(JValue.R(rt.String("[] ")));f.Pc=131;continue;}
case 131:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","strip","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",134);}
case 134:{f.Locals[5]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[4]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",143);}
case 143:{f.Pc=156;continue;}
case 146:{f.Push(f.Locals[4]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[7]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",155);}
case 155:{f.StackOp("pop");f.Pc=156;continue;}
case 156:{f.Pc=35;continue;}
case 159:{f.Push(f.Locals[4]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",166);}
case 166:{f.Pc=f.Pop().Int!=0?236:169;continue;}
case 169:{f.Push(f.Locals[0]);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[5]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[4]);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[2]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/util/storage/StorageReaderFileSections","readItem","(Ljava/lang/String;Ljava/lang/Iterable;I)Ljava/lang/Object;","invokevirtual",178);}
case 178:{f.Locals[6]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[6]);f.Pc=182;continue;}
case 182:{f.Pc=f.Pop().Reference==null?236:185;continue;}
case 185:{f.Push(f.Locals[0]);f.Pc=186;continue;}
case 186:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFileSections","keySelector","Ljava/util/function/Function;"));f.Pc=189;continue;}
case 189:{f.Push(f.Locals[6]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",196);}
case 196:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=199;continue;}
case 199:{f.Locals[7]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(f.Locals[1]);f.Pc=202;continue;}
case 202:{f.Push(f.Locals[7]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",209);}
case 209:{f.Pc=f.Pop().Int==0?225:212;continue;}
case 212:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=215;continue;}
case 215:{f.Push(f.Locals[7]);f.Pc=217;continue;}
case 217:{return rt.DynamicCall(f,"forge/util/storage/StorageReaderFileSections:12492:217:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",222);}
case 222:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",225);}
case 225:{f.Push(f.Locals[1]);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[7]);f.Pc=228;continue;}
case 228:{f.Push(f.Locals[6]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",235);}
case 235:{f.StackOp("pop");f.Pc=236;continue;}
case 236:{f.Push(f.Locals[1]);f.Pc=237;continue;}
case 237:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12493(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/storage/StorageReaderFileSections","read","(Ljava/lang/String;Ljava/lang/Iterable;I)Ljava/lang/Object;","invokevirtual",7);}
case 7:{f.Locals[4]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?18:15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFileSections","file","Ljava/io/File;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/io/File","getPath","()Ljava/lang/String;","invokevirtual",25);}
case 25:{return rt.DynamicCall(f,"forge/util/storage/StorageReaderFileSections:12493:25:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",30);}
case 30:{f.Locals[5]=f.Pop();f.Pc=32;continue;}
case 32:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(f.Locals[5]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",41);}
case 41:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12495(JRuntime rt,JFrame f)
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

internal static JStep M12496(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageReaderFileSections","keySelector","Ljava/util/function/Function;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1135{
internal static JClass Build(){var c=new JClass("forge/util/LineReader","java/lang/Object",new string[]{"java/lang/Iterable","java/io/Closeable"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("reader","Ljava/io/BufferedReader;",false,JValue.Default("Ljava/io/BufferedReader;"),null));
c.Add(new JMethod(11910,"forge/util/LineReader","<init>","(Ljava/io/InputStream;)V",1,2,3,new JHandler[]{},M11910));
c.Add(new JMethod(11911,"forge/util/LineReader","<init>","(Ljava/io/InputStream;Ljava/nio/charset/Charset;)V",1,3,7,new JHandler[]{},M11911));
c.Add(new JMethod(11912,"forge/util/LineReader","close","()V",1,1,1,new JHandler[]{},M11912));
c.Add(new JMethod(11913,"forge/util/LineReader","finalize","()V",4,1,1,new JHandler[]{},M11913));
c.Add(new JMethod(11914,"forge/util/LineReader","iterator","()Ljava/util/Iterator;",1,1,3,new JHandler[]{},M11914));
c.Add(new JMethod(11915,"forge/util/LineReader","readLines","()Ljava/util/Collection;",1,4,2,new JHandler[]{},M11915));
}

internal static JStep M11910(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/util/LineReader","<init>","(Ljava/io/InputStream;Ljava/nio/charset/Charset;)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11911(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/io/BufferedReader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/BufferedReader")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"java/io/InputStreamReader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/InputStreamReader")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/io/InputStreamReader","<init>","(Ljava/io/InputStream;Ljava/nio/charset/Charset;)V","invokespecial",18);}
case 18:{return rt.Call(f,"java/io/BufferedReader","<init>","(Ljava/io/Reader;)V","invokespecial",21);}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/LineReader","reader","Ljava/io/BufferedReader;",value);f.Pc=24;continue;}
case 24:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11912(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/LineReader","reader","Ljava/io/BufferedReader;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/io/BufferedReader","close","()V","invokevirtual",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11913(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/LineReader","close","()V","invokevirtual",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11914(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/LineReader$LineIterator"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/LineReader$LineIterator")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/LineReader$LineIterator","<init>","(Lforge/util/LineReader;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11915(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/LineReader","iterator","()Ljava/util/Iterator;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?43:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Collection","add","(Ljava/lang/Object;)Z","invokeinterface",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{f.Pc=13;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

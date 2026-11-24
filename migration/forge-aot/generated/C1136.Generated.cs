// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1136{
internal static JClass Build(){var c=new JClass("forge/util/LineReader$LineIterator","java/lang/Object",new string[]{"java/util/Iterator"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("nextLine","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("this$0","Lforge/util/LineReader;",false,JValue.Default("Lforge/util/LineReader;"),null));
c.Add(new JMethod(11916,"forge/util/LineReader$LineIterator","<init>","(Lforge/util/LineReader;)V",2,2,2,new JHandler[]{},M11916));
c.Add(new JMethod(11917,"forge/util/LineReader$LineIterator","bufferNext","()Ljava/lang/String;",1,2,4,new JHandler[]{new JHandler(0,15,16,"java/io/IOException")},M11917));
c.Add(new JMethod(11918,"forge/util/LineReader$LineIterator","hasNext","()Z",1,3,4,new JHandler[]{new JHandler(24,34,37,"java/io/IOException")},M11918));
c.Add(new JMethod(11919,"forge/util/LineReader$LineIterator","next","()Ljava/lang/String;",1,2,2,new JHandler[]{},M11919));
c.Add(new JMethod(11920,"forge/util/LineReader$LineIterator","remove","()V",1,1,2,new JHandler[]{},M11920));
c.Add(new JMethod(11921,"forge/util/LineReader$LineIterator","next","()Ljava/lang/Object;",4161,1,1,new JHandler[]{},M11921));
}

internal static JStep M11916(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/LineReader$LineIterator","this$0","Lforge/util/LineReader;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11917(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/util/LineReader$LineIterator","this$0","Lforge/util/LineReader;"));f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/LineReader","reader","Ljava/io/BufferedReader;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/io/BufferedReader","readLine","()Ljava/lang/String;","invokevirtual",11);}
case 11:{f.StackOp("dup_x1");f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/LineReader$LineIterator","nextLine","Ljava/lang/String;",value);f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
case 16:{f.Locals[1]=f.Pop();f.Pc=17;continue;}
case 17:{if(!rt.EnsureInitialized(f,"java/lang/IllegalStateException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalStateException")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("I/O error while reading stream.")));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/IllegalStateException","<init>","(Ljava/lang/String;Ljava/lang/Throwable;)V","invokespecial",27);}
case 27:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11918(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/LineReader$LineIterator","nextLine","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?14:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/util/LineReader$LineIterator","bufferNext","()Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Reference==null?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{f.Locals[1]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Pc=f.Pop().Int!=0?49:24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/util/LineReader$LineIterator","this$0","Lforge/util/LineReader;"));f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/util/LineReader","reader","Ljava/io/BufferedReader;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/io/BufferedReader","close","()V","invokevirtual",34);}
case 34:{f.Pc=49;continue;}
case 37:{f.Locals[2]=f.Pop();f.Pc=38;continue;}
case 38:{if(!rt.EnsureInitialized(f,"java/lang/IllegalStateException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalStateException")));f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("I/O error when closing stream.")));f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/IllegalStateException","<init>","(Ljava/lang/String;Ljava/lang/Throwable;)V","invokespecial",48);}
case 48:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11919(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/LineReader$LineIterator","hasNext","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?15:7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"java/util/NoSuchElementException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/NoSuchElementException")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/NoSuchElementException","<init>","()V","invokespecial",14);}
case 14:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/util/LineReader$LineIterator","nextLine","Ljava/lang/String;"));f.Pc=19;continue;}
case 19:{f.Locals[1]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(null));f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/LineReader$LineIterator","nextLine","Ljava/lang/String;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11920(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/UnsupportedOperationException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/UnsupportedOperationException")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/UnsupportedOperationException","<init>","()V","invokespecial",7);}
case 7:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11921(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/LineReader$LineIterator","next","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

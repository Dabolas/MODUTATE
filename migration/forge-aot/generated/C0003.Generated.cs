// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C3{
internal static JClass Build(){var c=new JClass("forge/FTrace","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("appStartTime","J",true,JValue.Default("J"),null));
c.Add(new JField("traces","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("name","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("startTime","J",false,JValue.Default("J"),null));
c.Add(new JField("totalTime","J",false,JValue.Default("J"),null));
c.Add(new JMethod(27,"forge/FTrace","initialize","()V",9,0,2,new JHandler[]{},M27));
c.Add(new JMethod(28,"forge/FTrace","get","(Ljava/lang/String;)Lforge/FTrace;",9,2,3,new JHandler[]{},M28));
c.Add(new JMethod(29,"forge/FTrace","formatTimestamp","(Ljava/util/Date;)Ljava/lang/String;",9,1,3,new JHandler[]{},M29));
c.Add(new JMethod(30,"forge/FTrace","dump","()V",9,5,9,new JHandler[]{},M30));
c.Add(new JMethod(31,"forge/FTrace","<init>","(Ljava/lang/String;)V",2,2,2,new JHandler[]{},M31));
c.Add(new JMethod(32,"forge/FTrace","start","()V",1,2,4,new JHandler[]{},M32));
c.Add(new JMethod(33,"forge/FTrace","end","()V",1,4,5,new JHandler[]{},M33));
c.Add(new JMethod(34,"forge/FTrace","<clinit>","()V",8,0,2,new JHandler[]{},M34));
}

internal static JStep M27(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/Date"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/Date")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Date","<init>","()V","invokespecial",7);}
case 7:{return rt.Call(f,"java/util/Date","getTime","()J","invokevirtual",10);}
case 10:{if(!rt.StaticReady(f,"forge/FTrace","appStartTime","J"))return JStep.Continue;rt.PutStatic("forge/FTrace","appStartTime","J",f.Pop());f.Pc=13;continue;}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M28(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/FTrace","traces","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/FTrace","traces","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.DynamicCall(f,"forge/FTrace:28:4:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",9);}
case 9:{return rt.Call(f,"java/util/Map","computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;","invokeinterface",14);}
case 14:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/FTrace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=17;continue;}
case 17:{f.Locals[1]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M29(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/text/SimpleDateFormat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/text/SimpleDateFormat")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("hh:mm:ss.SSS")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/text/SimpleDateFormat","<init>","(Ljava/lang/String;)V","invokespecial",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/text/SimpleDateFormat","format","(Ljava/util/Date;)Ljava/lang/String;","invokevirtual",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M30(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/FTrace","traces","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/FTrace","traces","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",8);}
case 8:{f.Pc=f.Pop().Int==0?12:11;continue;}
case 11:{return JStep.ReturnVoid;}
case 12:{if(!rt.EnsureInitialized(f,"java/util/Date"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/Date")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Date","<init>","()V","invokespecial",19);}
case 19:{return rt.Call(f,"java/util/Date","getTime","()J","invokevirtual",22);}
case 22:{if(!rt.StaticReady(f,"forge/FTrace","appStartTime","J"))return JStep.Continue;f.Push(rt.GetStatic("forge/FTrace","appStartTime","J"));f.Pc=25;continue;}
case 25:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=26;continue;}
case 26:{f.Locals[0]=f.Pop();f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/text/NumberFormat","getPercentInstance","()Ljava/text/NumberFormat;","invokestatic",30);}
case 30:{f.Locals[2]=f.Pop();f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/io/PrintStream","println","()V","invokevirtual",37);}
case 37:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{return rt.DynamicCall(f,"forge/FTrace:30:41:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(J)Ljava/lang/String;",46);}
case 46:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",49);}
case 49:{if(!rt.StaticReady(f,"forge/FTrace","traces","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/FTrace","traces","Ljava/util/Map;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",57);}
case 57:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",62);}
case 62:{f.Locals[3]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",69);}
case 69:{f.Pc=f.Pop().Int==0?120:72;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",78);}
case 78:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/FTrace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=81;continue;}
case 81:{f.Locals[4]=f.Pop();f.Pc=83;continue;}
case 83:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=86;continue;}
case 86:{f.Push(f.Locals[4]);f.Pc=88;continue;}
case 88:{f.Push(rt.GetField(f.Pop(),"forge/FTrace","name","Ljava/lang/String;"));f.Pc=91;continue;}
case 91:{f.Push(f.Locals[4]);f.Pc=93;continue;}
case 93:{f.Push(rt.GetField(f.Pop(),"forge/FTrace","totalTime","J"));f.Pc=96;continue;}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[4]);f.Pc=99;continue;}
case 99:{f.Push(rt.GetField(f.Pop(),"forge/FTrace","totalTime","J"));f.Pc=102;continue;}
case 102:{f.Push(JNumbers.Unary("l2d",f.Pop()));f.Pc=103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(JNumbers.Unary("l2d",f.Pop()));f.Pc=105;continue;}
case 105:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ddiv",a,b));f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/text/NumberFormat","format","(D)Ljava/lang/String;","invokevirtual",109);}
case 109:{return rt.DynamicCall(f,"forge/FTrace:30:109:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;JLjava/lang/String;)Ljava/lang/String;",114);}
case 114:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",117);}
case 117:{f.Pc=63;continue;}
case 120:{if(!rt.StaticReady(f,"forge/FTrace","traces","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/FTrace","traces","Ljava/util/Map;"));f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",128);}
case 128:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M31(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/FTrace","name","Ljava/lang/String;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M32(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/FTrace","startTime","J"));f.Pc=4;continue;}
case 4:{f.Push(JValue.L(0));f.Pc=5;continue;}
case 5:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Int<=0?10:9;continue;}
case 9:{return JStep.ReturnVoid;}
case 10:{if(!rt.EnsureInitialized(f,"java/util/Date"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/Date")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Date","<init>","()V","invokespecial",17);}
case 17:{f.Locals[1]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Date","getTime","()J","invokevirtual",23);}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/FTrace","startTime","J",value);f.Pc=26;continue;}
case 26:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/FTrace","name","Ljava/lang/String;"));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/FTrace","formatTimestamp","(Ljava/util/Date;)Ljava/lang/String;","invokestatic",37);}
case 37:{return rt.DynamicCall(f,"forge/FTrace:32:37:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",42);}
case 42:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",45);}
case 45:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M33(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/FTrace","startTime","J"));f.Pc=4;continue;}
case 4:{f.Push(JValue.L(0));f.Pc=5;continue;}
case 5:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Int!=0?10:9;continue;}
case 9:{return JStep.ReturnVoid;}
case 10:{if(!rt.EnsureInitialized(f,"java/util/Date"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/Date")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Date","<init>","()V","invokespecial",17);}
case 17:{f.Locals[1]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Date","getTime","()J","invokevirtual",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/FTrace","startTime","J"));f.Pc=26;continue;}
case 26:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=27;continue;}
case 27:{f.Locals[2]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(JValue.L(0));f.Pc=30;continue;}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/FTrace","startTime","J",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.StackOp("dup");f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/FTrace","totalTime","J"));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=40;continue;}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/FTrace","totalTime","J",value);f.Pc=43;continue;}
case 43:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(rt.GetField(f.Pop(),"forge/FTrace","name","Ljava/lang/String;"));f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/FTrace","formatTimestamp","(Ljava/util/Date;)Ljava/lang/String;","invokestatic",54);}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{return rt.DynamicCall(f,"forge/FTrace:33:55:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;J)Ljava/lang/String;",60);}
case 60:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",63);}
case 63:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M34(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",7);}
case 7:{if(!rt.StaticReady(f,"forge/FTrace","traces","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/FTrace","traces","Ljava/util/Map;",f.Pop());f.Pc=10;continue;}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

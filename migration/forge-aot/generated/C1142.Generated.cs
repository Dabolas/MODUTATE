// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1142{
internal static JClass Build(){var c=new JClass("forge/util/MyRandom","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("random","Ljava/lang/ThreadLocal;",true,JValue.Default("Ljava/lang/ThreadLocal;"),null));
c.Add(new JField("TRACE","Z",true,JValue.Default("Z"),null));
c.Add(new JField("SITES","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JMethod(11952,"forge/util/MyRandom","<init>","()V",1,1,1,new JHandler[]{},M11952));
c.Add(new JMethod(11953,"forge/util/MyRandom","callCount","()J",9,0,2,new JHandler[]{},M11953));
c.Add(new JMethod(11954,"forge/util/MyRandom","trace","()V",10,7,4,new JHandler[]{},M11954));
c.Add(new JMethod(11955,"forge/util/MyRandom","drainTrace","(I)Ljava/lang/String;",9,2,3,new JHandler[]{},M11955));
c.Add(new JMethod(11956,"forge/util/MyRandom","percentTrue","(I)Z",9,1,3,new JHandler[]{},M11956));
c.Add(new JMethod(11957,"forge/util/MyRandom","getRandom","()Ljava/util/Random;",9,0,1,new JHandler[]{},M11957));
c.Add(new JMethod(11958,"forge/util/MyRandom","setRandom","(Ljava/util/Random;)V",9,1,4,new JHandler[]{},M11958));
c.Add(new JMethod(11959,"forge/util/MyRandom","splitIntoRandomGroups","(II)[I",9,4,4,new JHandler[]{},M11959));
c.Add(new JMethod(11960,"forge/util/MyRandom","lambda$drainTrace$2","(Ljava/lang/StringBuilder;Ljava/util/Map$Entry;)V",4106,2,3,new JHandler[]{},M11960));
c.Add(new JMethod(11961,"forge/util/MyRandom","lambda$drainTrace$1","(Ljava/util/Map$Entry;Ljava/util/Map$Entry;)I",4106,2,4,new JHandler[]{},M11961));
c.Add(new JMethod(11962,"forge/util/MyRandom","lambda$trace$0","(Ljava/lang/String;)Ljava/util/concurrent/atomic/LongAdder;",4106,1,2,new JHandler[]{},M11962));
c.Add(new JMethod(11963,"forge/util/MyRandom","<clinit>","()V",8,0,2,new JHandler[]{},M11963));
}

internal static JStep M11952(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11953(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/MyRandom","random","Ljava/lang/ThreadLocal;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/MyRandom","random","Ljava/lang/ThreadLocal;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/ThreadLocal","get","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/MyRandom$CountingRandom"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/MyRandom$CountingRandom","callCount","()J","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11954(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/Thread","currentThread","()Ljava/lang/Thread;","invokestatic",7);}
case 7:{return rt.Call(f,"java/lang/Thread","getName","()Ljava/lang/String;","invokevirtual",10);}
case 10:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",13);}
case 13:{f.Push(JValue.R(rt.String(" <- ")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",18);}
case 18:{f.Locals[0]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{f.Locals[1]=f.Pop();f.Pc=21;continue;}
case 21:{if(!rt.EnsureInitialized(f,"java/lang/Throwable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/Throwable")));f.Pc=24;continue;}
case 24:{f.StackOp("dup");f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/Throwable","<init>","()V","invokespecial",28);}
case 28:{return rt.Call(f,"java/lang/Throwable","getStackTrace","()[Ljava/lang/StackTraceElement;","invokevirtual",31);}
case 31:{f.Locals[2]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=34;continue;}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?167:44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=48;continue;}
case 48:{f.Locals[5]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/StackTraceElement","getClassName","()Ljava/lang/String;","invokevirtual",55);}
case 55:{f.Locals[6]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("java.")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",64);}
case 64:{f.Pc=f.Pop().Int!=0?161:67;continue;}
case 67:{f.Push(f.Locals[6]);f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("jdk.")));f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int!=0?161:77;continue;}
case 77:{f.Push(f.Locals[6]);f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("forge.util.MyRandom")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int==0?90:87;continue;}
case 87:{f.Pc=161;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[6]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[6]);f.Pc=95;continue;}
case 95:{f.Push(JValue.I(46));f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/String","lastIndexOf","(I)I","invokevirtual",100);}
case 100:{f.Push(JValue.I(1));f.Pc=101;continue;}
case 101:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",105);}
case 105:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",108);}
case 108:{f.Push(JValue.I(46));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",113);}
case 113:{f.Push(f.Locals[5]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/StackTraceElement","getMethodName","()Ljava/lang/String;","invokevirtual",118);}
case 118:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",121);}
case 121:{f.Push(JValue.I(58));f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",126);}
case 126:{f.Push(f.Locals[5]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/StackTraceElement","getLineNumber","()I","invokevirtual",131);}
case 131:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",134);}
case 134:{f.Push(f.Locals[1]);f.Pc=135;continue;}
case 135:{f.Push(JValue.I(3));f.Pc=136;continue;}
case 136:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?144:139;continue;}
case 139:{f.Push(JValue.R(rt.String(" < ")));f.Pc=141;continue;}
case 141:{f.Pc=146;continue;}
case 144:{f.Push(JValue.R(rt.String("")));f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",149);}
case 149:{f.StackOp("pop");f.Pc=150;continue;}
case 150:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(1)));f.Pc=153;continue;}
case 153:{f.Push(f.Locals[1]);f.Pc=154;continue;}
case 154:{f.Push(JValue.I(4));f.Pc=155;continue;}
case 155:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?161:158;continue;}
case 158:{f.Pc=167;continue;}
case 161:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=164;continue;}
case 164:{f.Pc=38;continue;}
case 167:{if(!rt.StaticReady(f,"forge/util/MyRandom","SITES","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/MyRandom","SITES","Ljava/util/Map;"));f.Pc=170;continue;}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",174);}
case 174:{return rt.DynamicCall(f,"forge/util/MyRandom:11954:174:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",179);}
case 179:{return rt.Call(f,"java/util/Map","computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;","invokeinterface",184);}
case 184:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/concurrent/atomic/LongAdder"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=187;continue;}
case 187:{return rt.Call(f,"java/util/concurrent/atomic/LongAdder","increment","()V","invokevirtual",190);}
case 190:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11955(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/util/MyRandom","SITES","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/MyRandom","SITES","Ljava/util/Map;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",16);}
case 16:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",21);}
case 21:{return rt.DynamicCall(f,"forge/util/MyRandom:11955:21:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/Comparator;",26);}
case 26:{return rt.Call(f,"java/util/stream/Stream","sorted","(Ljava/util/Comparator;)Ljava/util/stream/Stream;","invokeinterface",31);}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/stream/Stream","limit","(J)Ljava/util/stream/Stream;","invokeinterface",38);}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.DynamicCall(f,"forge/util/MyRandom:11955:39:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/StringBuilder;)Ljava/util/function/Consumer;",44);}
case 44:{return rt.Call(f,"java/util/stream/Stream","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",49);}
case 49:{if(!rt.StaticReady(f,"forge/util/MyRandom","SITES","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/MyRandom","SITES","Ljava/util/Map;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",57);}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",61);}
case 61:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11956(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",4);}
case 4:{f.Push(JValue.I(100));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",9);}
case 9:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?16:12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{f.Pc=17;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11957(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/MyRandom","random","Ljava/lang/ThreadLocal;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/MyRandom","random","Ljava/lang/ThreadLocal;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/ThreadLocal","get","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Random"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11958(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/MyRandom","random","Ljava/lang/ThreadLocal;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/MyRandom","random","Ljava/lang/ThreadLocal;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/util/MyRandom$CountingRandom")?1:0));f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Int==0?17:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/MyRandom$CountingRandom"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=14;continue;}
case 14:{f.Pc=25;continue;}
case 17:{if(!rt.EnsureInitialized(f,"forge/util/MyRandom$CountingRandom"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/MyRandom$CountingRandom")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/util/MyRandom$CountingRandom","<init>","(Ljava/util/Random;)V","invokespecial",25);}
case 25:{return rt.Call(f,"java/lang/ThreadLocal","set","(Ljava/lang/Object;)V","invokevirtual",28);}
case 28:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11959(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=3;continue;}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{f.Locals[3]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?30:11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",15);}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",19);}
case 19:{f.StackOp("dup2");f.Pc=20;continue;}
case 20:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=23;continue;}
case 23:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=24;continue;}
case 24:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=27;continue;}
case 27:{f.Pc=6;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11960(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("\n    ")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",6);}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",12);}
case 12:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/concurrent/atomic/LongAdder"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/concurrent/atomic/LongAdder","sum","()J","invokevirtual",18);}
case 18:{return rt.Call(f,"java/lang/StringBuilder","append","(J)Ljava/lang/StringBuilder;","invokevirtual",21);}
case 21:{f.Push(JValue.R(rt.String("x ")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",26);}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",32);}
case 32:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",38);}
case 38:{f.StackOp("pop");f.Pc=39;continue;}
case 39:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11961(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/concurrent/atomic/LongAdder"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/concurrent/atomic/LongAdder","sum","()J","invokevirtual",12);}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",18);}
case 18:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/concurrent/atomic/LongAdder"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/concurrent/atomic/LongAdder","sum","()J","invokevirtual",24);}
case 24:{return rt.Call(f,"java/lang/Long","compare","(JJ)I","invokestatic",27);}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11962(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/concurrent/atomic/LongAdder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/atomic/LongAdder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/concurrent/atomic/LongAdder","<init>","()V","invokespecial",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11963(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/MyRandom$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/MyRandom$1")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/MyRandom$1","<init>","()V","invokespecial",7);}
case 7:{if(!rt.StaticReady(f,"forge/util/MyRandom","random","Ljava/lang/ThreadLocal;"))return JStep.Continue;rt.PutStatic("forge/util/MyRandom","random","Ljava/lang/ThreadLocal;",f.Pop());f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("forge.undo.debug")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/Boolean","getBoolean","(Ljava/lang/String;)Z","invokestatic",15);}
case 15:{if(!rt.StaticReady(f,"forge/util/MyRandom","TRACE","Z"))return JStep.Continue;rt.PutStatic("forge/util/MyRandom","TRACE","Z",f.Pop());f.Pc=18;continue;}
case 18:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentHashMap")));f.Pc=21;continue;}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","<init>","()V","invokespecial",25);}
case 25:{if(!rt.StaticReady(f,"forge/util/MyRandom","SITES","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/util/MyRandom","SITES","Ljava/util/Map;",f.Pop());f.Pc=28;continue;}
case 28:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

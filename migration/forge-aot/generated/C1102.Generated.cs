// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1102{
internal static JClass Build(){var c=new JClass("forge/util/AITimeoutTracker","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("SHOW_AFTER_NANOS","J",true,JValue.Default("J"),null));
c.Add(new JField("staleGraceNanos","J",true,JValue.Default("J"),null));
c.Add(new JField("PURGE_THRESHOLD","I",true,JValue.I(64),null));
c.Add(new JField("SLOTS","Ljava/util/concurrent/ConcurrentHashMap;",true,JValue.Default("Ljava/util/concurrent/ConcurrentHashMap;"),null));
c.Add(new JField("repaintHook","Ljava/lang/Runnable;",true,JValue.Default("Ljava/lang/Runnable;"),null));
c.Add(new JField("LIMIT","Ljava/lang/ThreadLocal;",true,JValue.Default("Ljava/lang/ThreadLocal;"),null));
c.Add(new JMethod(11605,"forge/util/AITimeoutTracker","key","(II)J",9,2,6,new JHandler[]{},M11605));
c.Add(new JMethod(11606,"forge/util/AITimeoutTracker","purgeIdle","()V",10,5,3,new JHandler[]{new JHandler(45,80,83,""),new JHandler(83,87,83,"")},M11606));
c.Add(new JMethod(11607,"forge/util/AITimeoutTracker","<init>","()V",2,1,1,new JHandler[]{},M11607));
c.Add(new JMethod(11608,"forge/util/AITimeoutTracker","setRepaintHook","(Ljava/lang/Runnable;)V",9,1,1,new JHandler[]{},M11608));
c.Add(new JMethod(11609,"forge/util/AITimeoutTracker","isStale","(Lforge/util/AITimeoutTracker$Slot;J)Z",10,3,4,new JHandler[]{},M11609));
c.Add(new JMethod(11610,"forge/util/AITimeoutTracker","begin","(JJ)V",9,13,5,new JHandler[]{new JHandler(85,96,168,""),new JHandler(99,165,168,""),new JHandler(168,173,168,"")},M11610));
c.Add(new JMethod(11611,"forge/util/AITimeoutTracker","end","(J)V",9,6,4,new JHandler[]{new JHandler(26,71,74,""),new JHandler(74,79,74,"")},M11611));
c.Add(new JMethod(11612,"forge/util/AITimeoutTracker","isActive","(J)Z",9,3,3,new JHandler[]{},M11612));
c.Add(new JMethod(11613,"forge/util/AITimeoutTracker","deadlineNanos","(JJ)J",9,7,4,new JHandler[]{},M11613));
c.Add(new JMethod(11614,"forge/util/AITimeoutTracker","getRemainingFraction","(J)F",9,11,5,new JHandler[]{},M11614));
c.Add(new JMethod(11615,"forge/util/AITimeoutTracker","arm","(JZ)Ljava/lang/Object;",9,5,5,new JHandler[]{},M11615));
c.Add(new JMethod(11616,"forge/util/AITimeoutTracker","disarm","(Ljava/lang/Object;)V",9,3,5,new JHandler[]{},M11616));
c.Add(new JMethod(11617,"forge/util/AITimeoutTracker","check","()V",9,1,4,new JHandler[]{},M11617));
c.Add(new JMethod(11618,"forge/util/AITimeoutTracker","remainingNanos","()J",9,1,4,new JHandler[]{},M11618));
c.Add(new JMethod(11619,"forge/util/AITimeoutTracker","remainingNanos","(JJ)J",9,4,6,new JHandler[]{},M11619));
c.Add(new JMethod(11620,"forge/util/AITimeoutTracker","lambda$begin$0","(Lforge/util/AITimeoutTracker$Slot;JLjava/lang/Runnable;)V",4106,4,4,new JHandler[]{},M11620));
c.Add(new JMethod(11621,"forge/util/AITimeoutTracker","<clinit>","()V",8,0,3,new JHandler[]{},M11621));
}

internal static JStep M11605(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=2;continue;}
case 2:{f.Push(JValue.I(32));f.Pc=4;continue;}
case 4:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lshl",a,b));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=7;continue;}
case 7:{f.Push(JValue.L(4294967295L));f.Pc=10;continue;}
case 10:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"land",a,b));f.Pc=11;continue;}
case 11:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lor",a,b));f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11606(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","SLOTS","Ljava/util/concurrent/ConcurrentHashMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","SLOTS","Ljava/util/concurrent/ConcurrentHashMap;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","entrySet","()Ljava/util/Set;","invokevirtual",6);}
case 6:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",11);}
case 11:{f.Locals[0]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?93:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[1]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/AITimeoutTracker$Slot"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Locals[2]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Locals[3]=f.Pop();f.Pc=44;continue;}
case 44:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Slot","depth","I"));f.Pc=49;continue;}
case 49:{f.Pc=f.Pop().Int!=0?78:52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Slot","removed","Z"));f.Pc=56;continue;}
case 56:{f.Pc=f.Pop().Int!=0?78:59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{f.Push(JValue.I(1));f.Pc=61;continue;}
case 61:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/AITimeoutTracker$Slot","removed","Z",value);f.Pc=64;continue;}
case 64:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","SLOTS","Ljava/util/concurrent/ConcurrentHashMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","SLOTS","Ljava/util/concurrent/ConcurrentHashMap;"));f.Pc=67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",73);}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","remove","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokevirtual",77);}
case 77:{f.StackOp("pop");f.Pc=78;continue;}
case 78:{f.Push(f.Locals[3]);f.Pc=79;continue;}
case 79:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=80;continue;}
case 80:{f.Pc=90;continue;}
case 83:{f.Locals[4]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 90:{f.Pc=12;continue;}
case 93:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11607(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11608(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","repaintHook","Ljava/lang/Runnable;"))return JStep.Continue;rt.PutStatic("forge/util/AITimeoutTracker","repaintHook","Ljava/lang/Runnable;",f.Pop());f.Pc=4;continue;}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11609(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Slot","depth","I"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int<=0?29:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Slot","startNanos","J"));f.Pc=12;continue;}
case 12:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Slot","timeoutNanos","J"));f.Pc=17;continue;}
case 17:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","staleGraceNanos","J"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","staleGraceNanos","J"));f.Pc=21;continue;}
case 21:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Int<=0?29:25;continue;}
case 25:{f.Push(JValue.I(1));f.Pc=26;continue;}
case 26:{f.Pc=30;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11610(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[4]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(JValue.L(0));f.Pc=4;continue;}
case 4:{f.Locals[5]=f.Pop();f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","SLOTS","Ljava/util/concurrent/ConcurrentHashMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","SLOTS","Ljava/util/concurrent/ConcurrentHashMap;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",13);}
case 13:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/AITimeoutTracker$Slot"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{f.Locals[8]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[8]);f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Reference!=null?75:26;continue;}
case 26:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","SLOTS","Ljava/util/concurrent/ConcurrentHashMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","SLOTS","Ljava/util/concurrent/ConcurrentHashMap;"));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","size","()I","invokevirtual",32);}
case 32:{f.Push(JValue.I(64));f.Pc=34;continue;}
case 34:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?40:37;continue;}
case 37:{return rt.Call(f,"forge/util/AITimeoutTracker","purgeIdle","()V","invokestatic",40);}
case 40:{if(!rt.EnsureInitialized(f,"forge/util/AITimeoutTracker$Slot"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/AITimeoutTracker$Slot")));f.Pc=43;continue;}
case 43:{f.StackOp("dup");f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/util/AITimeoutTracker$Slot","<init>","()V","invokespecial",47);}
case 47:{f.Locals[8]=f.Pop();f.Pc=49;continue;}
case 49:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","SLOTS","Ljava/util/concurrent/ConcurrentHashMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","SLOTS","Ljava/util/concurrent/ConcurrentHashMap;"));f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",56);}
case 56:{f.Push(f.Locals[8]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","putIfAbsent","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",61);}
case 61:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/AITimeoutTracker$Slot"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=64;continue;}
case 64:{f.Locals[9]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[9]);f.Pc=68;continue;}
case 68:{f.Pc=f.Pop().Reference==null?75:71;continue;}
case 71:{f.Push(f.Locals[9]);f.Pc=73;continue;}
case 73:{f.Locals[8]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[8]);f.Pc=77;continue;}
case 77:{f.Locals[7]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[7]);f.Pc=81;continue;}
case 81:{f.StackOp("dup");f.Pc=82;continue;}
case 82:{f.Locals[9]=f.Pop();f.Pc=84;continue;}
case 84:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=85;continue;}
case 85:{f.Push(f.Locals[7]);f.Pc=87;continue;}
case 87:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Slot","removed","Z"));f.Pc=90;continue;}
case 90:{f.Pc=f.Pop().Int==0?99:93;continue;}
case 93:{f.Push(f.Locals[9]);f.Pc=95;continue;}
case 95:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=96;continue;}
case 96:{f.Pc=6;continue;}
case 99:{return rt.Call(f,"java/lang/System","nanoTime","()J","invokestatic",102);}
case 102:{f.Locals[10]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[7]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[10]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/util/AITimeoutTracker","isStale","(Lforge/util/AITimeoutTracker$Slot;J)Z","invokestatic",111);}
case 111:{f.Pc=f.Pop().Int==0?120:114;continue;}
case 114:{f.Push(f.Locals[7]);f.Pc=116;continue;}
case 116:{f.Push(JValue.I(0));f.Pc=117;continue;}
case 117:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/AITimeoutTracker$Slot","depth","I",value);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[7]);f.Pc=122;continue;}
case 122:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Slot","depth","I"));f.Pc=125;continue;}
case 125:{f.Pc=f.Pop().Int!=0?144:128;continue;}
case 128:{f.Push(f.Locals[7]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[10]);f.Pc=132;continue;}
case 132:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/AITimeoutTracker$Slot","startNanos","J",value);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[7]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[2]);f.Pc=138;continue;}
case 138:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/AITimeoutTracker$Slot","timeoutNanos","J",value);f.Pc=141;continue;}
case 141:{f.Push(JValue.I(1));f.Pc=142;continue;}
case 142:{f.Locals[4]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[7]);f.Pc=146;continue;}
case 146:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Slot","startNanos","J"));f.Pc=149;continue;}
case 149:{f.Locals[5]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(f.Locals[7]);f.Pc=153;continue;}
case 153:{f.StackOp("dup");f.Pc=154;continue;}
case 154:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Slot","depth","I"));f.Pc=157;continue;}
case 157:{f.Push(JValue.I(1));f.Pc=158;continue;}
case 158:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=159;continue;}
case 159:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/AITimeoutTracker$Slot","depth","I",value);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[9]);f.Pc=164;continue;}
case 164:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=165;continue;}
case 165:{f.Pc=176;continue;}
case 168:{f.Locals[12]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(f.Locals[9]);f.Pc=172;continue;}
case 172:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=173;continue;}
case 173:{f.Push(f.Locals[12]);f.Pc=175;continue;}
case 175:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 176:{f.Pc=179;continue;}
case 179:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","repaintHook","Ljava/lang/Runnable;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","repaintHook","Ljava/lang/Runnable;"));f.Pc=182;continue;}
case 182:{f.Locals[8]=f.Pop();f.Pc=184;continue;}
case 184:{f.Push(f.Locals[4]);f.Pc=186;continue;}
case 186:{f.Pc=f.Pop().Int==0?235:189;continue;}
case 189:{f.Push(f.Locals[8]);f.Pc=191;continue;}
case 191:{f.Pc=f.Pop().Reference==null?235:194;continue;}
case 194:{f.Push(f.Locals[2]);f.Pc=195;continue;}
case 195:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","SHOW_AFTER_NANOS","J"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","SHOW_AFTER_NANOS","J"));f.Pc=198;continue;}
case 198:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=199;continue;}
case 199:{f.Pc=f.Pop().Int<=0?235:202;continue;}
case 202:{f.Push(f.Locals[7]);f.Pc=204;continue;}
case 204:{f.Locals[9]=f.Pop();f.Pc=206;continue;}
case 206:{f.Push(f.Locals[5]);f.Pc=208;continue;}
case 208:{f.Locals[10]=f.Pop();f.Pc=210;continue;}
case 210:{if(!rt.StaticReady(f,"java/util/concurrent/TimeUnit","NANOSECONDS","Ljava/util/concurrent/TimeUnit;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/concurrent/TimeUnit","NANOSECONDS","Ljava/util/concurrent/TimeUnit;"));f.Pc=213;continue;}
case 213:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","SHOW_AFTER_NANOS","J"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","SHOW_AFTER_NANOS","J"));f.Pc=216;continue;}
case 216:{return rt.Call(f,"java/util/concurrent/TimeUnit","toMillis","(J)J","invokevirtual",219);}
case 219:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=220;continue;}
case 220:{f.Push(f.Locals[9]);f.Pc=222;continue;}
case 222:{f.Push(f.Locals[10]);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[8]);f.Pc=226;continue;}
case 226:{return rt.DynamicCall(f,"forge/util/AITimeoutTracker:11610:226:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/util/AITimeoutTracker$Slot;JLjava/lang/Runnable;)Ljava/lang/Runnable;",231);}
case 231:{return rt.Call(f,"forge/util/ThreadUtil","delay","(ILjava/lang/Runnable;)Ljava/util/concurrent/ScheduledFuture;","invokestatic",234);}
case 234:{f.StackOp("pop");f.Pc=235;continue;}
case 235:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11611(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","SLOTS","Ljava/util/concurrent/ConcurrentHashMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","SLOTS","Ljava/util/concurrent/ConcurrentHashMap;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",7);}
case 7:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/AITimeoutTracker$Slot"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Reference!=null?19:18;continue;}
case 18:{return JStep.ReturnVoid;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{f.Locals[3]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Slot","depth","I"));f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Int<=0?68:33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{f.StackOp("dup");f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Slot","depth","I"));f.Pc=38;continue;}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=40;continue;}
case 40:{f.StackOp("dup_x1");f.Pc=41;continue;}
case 41:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/AITimeoutTracker$Slot","depth","I",value);f.Pc=44;continue;}
case 44:{f.Pc=f.Pop().Int!=0?68:47;continue;}
case 47:{return rt.Call(f,"java/lang/System","nanoTime","()J","invokestatic",50);}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Slot","startNanos","J"));f.Pc=54;continue;}
case 54:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=55;continue;}
case 55:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","SHOW_AFTER_NANOS","J"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","SHOW_AFTER_NANOS","J"));f.Pc=58;continue;}
case 58:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=59;continue;}
case 59:{f.Pc=f.Pop().Int<0?66:62;continue;}
case 62:{f.Push(JValue.I(1));f.Pc=63;continue;}
case 63:{f.Pc=67;continue;}
case 66:{f.Push(JValue.I(0));f.Pc=67;continue;}
case 67:{f.Locals[3]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=71;continue;}
case 71:{f.Pc=82;continue;}
case 74:{f.Locals[5]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=79;continue;}
case 79:{f.Push(f.Locals[5]);f.Pc=81;continue;}
case 81:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 82:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","repaintHook","Ljava/lang/Runnable;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","repaintHook","Ljava/lang/Runnable;"));f.Pc=85;continue;}
case 85:{f.Locals[4]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[3]);f.Pc=88;continue;}
case 88:{f.Pc=f.Pop().Int==0?103:91;continue;}
case 91:{f.Push(f.Locals[4]);f.Pc=93;continue;}
case 93:{f.Pc=f.Pop().Reference==null?103:96;continue;}
case 96:{f.Push(f.Locals[4]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/lang/Runnable","run","()V","invokeinterface",103);}
case 103:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11612(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","SLOTS","Ljava/util/concurrent/ConcurrentHashMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","SLOTS","Ljava/util/concurrent/ConcurrentHashMap;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",7);}
case 7:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/AITimeoutTracker$Slot"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Reference==null?39:18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Slot","depth","I"));f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Int<=0?39:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/System","nanoTime","()J","invokestatic",29);}
case 29:{return rt.Call(f,"forge/util/AITimeoutTracker","isStale","(Lforge/util/AITimeoutTracker$Slot;J)Z","invokestatic",32);}
case 32:{f.Pc=f.Pop().Int!=0?39:35;continue;}
case 35:{f.Push(JValue.I(1));f.Pc=36;continue;}
case 36:{f.Pc=40;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11613(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"java/lang/System","nanoTime","()J","invokestatic",3);}
case 3:{f.Locals[4]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","SLOTS","Ljava/util/concurrent/ConcurrentHashMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","SLOTS","Ljava/util/concurrent/ConcurrentHashMap;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",12);}
case 12:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",15);}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/AITimeoutTracker$Slot"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{f.Locals[6]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[6]);f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Reference==null?55:25;continue;}
case 25:{f.Push(f.Locals[6]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Slot","depth","I"));f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Int<=0?55:33;continue;}
case 33:{f.Push(f.Locals[6]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/util/AITimeoutTracker","isStale","(Lforge/util/AITimeoutTracker$Slot;J)Z","invokestatic",40);}
case 40:{f.Pc=f.Pop().Int!=0?55:43;continue;}
case 43:{f.Push(f.Locals[6]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Slot","startNanos","J"));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[6]);f.Pc=50;continue;}
case 50:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Slot","timeoutNanos","J"));f.Pc=53;continue;}
case 53:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=54;continue;}
case 54:{return JStep.Return(f.Pop());}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=59;continue;}
case 59:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11614(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","SLOTS","Ljava/util/concurrent/ConcurrentHashMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","SLOTS","Ljava/util/concurrent/ConcurrentHashMap;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",7);}
case 7:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/AITimeoutTracker$Slot"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Reference==null?25:18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Slot","depth","I"));f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Int!=0?28:25;continue;}
case 25:{f.Push(JValue.F(-1.0f));f.Pc=27;continue;}
case 27:{return JStep.Return(f.Pop());}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Slot","startNanos","J"));f.Pc=32;continue;}
case 32:{f.Locals[3]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Slot","timeoutNanos","J"));f.Pc=37;continue;}
case 37:{f.Locals[5]=f.Pop();f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/System","nanoTime","()J","invokestatic",42);}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=44;continue;}
case 44:{f.Locals[7]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[5]);f.Pc=48;continue;}
case 48:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","SHOW_AFTER_NANOS","J"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","SHOW_AFTER_NANOS","J"));f.Pc=51;continue;}
case 51:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=52;continue;}
case 52:{f.Locals[9]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[9]);f.Pc=56;continue;}
case 56:{f.Push(JValue.L(0));f.Pc=57;continue;}
case 57:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=58;continue;}
case 58:{f.Pc=f.Pop().Int<=0?78:61;continue;}
case 61:{f.Push(f.Locals[7]);f.Pc=63;continue;}
case 63:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","SHOW_AFTER_NANOS","J"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","SHOW_AFTER_NANOS","J"));f.Pc=66;continue;}
case 66:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=67;continue;}
case 67:{f.Pc=f.Pop().Int<0?78:70;continue;}
case 70:{f.Push(f.Locals[7]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[5]);f.Pc=74;continue;}
case 74:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=75;continue;}
case 75:{f.Pc=f.Pop().Int<0?81:78;continue;}
case 78:{f.Push(JValue.F(-1.0f));f.Pc=80;continue;}
case 80:{return JStep.Return(f.Pop());}
case 81:{f.Push(JValue.F(1));f.Pc=82;continue;}
case 82:{f.Push(f.Locals[7]);f.Pc=84;continue;}
case 84:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","SHOW_AFTER_NANOS","J"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","SHOW_AFTER_NANOS","J"));f.Pc=87;continue;}
case 87:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=88;continue;}
case 88:{f.Push(JNumbers.Unary("l2f",f.Pop()));f.Pc=89;continue;}
case 89:{f.Push(f.Locals[9]);f.Pc=91;continue;}
case 91:{f.Push(JNumbers.Unary("l2f",f.Pop()));f.Pc=92;continue;}
case 92:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fdiv",a,b));f.Pc=93;continue;}
case 93:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fsub",a,b));f.Pc=94;continue;}
case 94:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11615(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","LIMIT","Ljava/lang/ThreadLocal;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","LIMIT","Ljava/lang/ThreadLocal;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/ThreadLocal","get","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/AITimeoutTracker$Limit"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(JValue.I(3));f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.NewArray("J",f.Pop().Int)));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Limit","armed","Z"));f.Pc=19;continue;}
case 19:{f.Pc=f.Pop().Int==0?26:22;continue;}
case 22:{f.Push(JValue.L(1));f.Pc=23;continue;}
case 23:{f.Pc=27;continue;}
case 26:{f.Push(JValue.L(0));f.Pc=27;continue;}
case 27:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Limit","deadlineNanos","J"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(2));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Limit","honourInterrupt","Z"));f.Pc=41;continue;}
case 41:{f.Pc=f.Pop().Int==0?48:44;continue;}
case 44:{f.Push(JValue.L(1));f.Pc=45;continue;}
case 45:{f.Pc=49;continue;}
case 48:{f.Push(JValue.L(0));f.Pc=49;continue;}
case 49:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=50;continue;}
case 50:{f.Locals[4]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Limit","armed","Z"));f.Pc=56;continue;}
case 56:{f.Pc=f.Pop().Int==0?70:59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Limit","deadlineNanos","J"));f.Pc=64;continue;}
case 64:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=65;continue;}
case 65:{f.Push(JValue.L(0));f.Pc=66;continue;}
case 66:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=67;continue;}
case 67:{f.Pc=f.Pop().Int>=0?75:70;continue;}
case 70:{f.Push(f.Locals[3]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/AITimeoutTracker$Limit","deadlineNanos","J",value);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[3]);f.Pc=76;continue;}
case 76:{f.Push(JValue.I(1));f.Pc=77;continue;}
case 77:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/AITimeoutTracker$Limit","armed","Z",value);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[3]);f.Pc=81;continue;}
case 81:{f.StackOp("dup");f.Pc=82;continue;}
case 82:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Limit","honourInterrupt","Z"));f.Pc=85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=87;continue;}
case 87:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/AITimeoutTracker$Limit","honourInterrupt","Z",value);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[4]);f.Pc=92;continue;}
case 92:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11616(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[J"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4;continue;}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","LIMIT","Ljava/lang/ThreadLocal;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","LIMIT","Ljava/lang/ThreadLocal;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/ThreadLocal","get","()Ljava/lang/Object;","invokevirtual",11);}
case 11:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/AITimeoutTracker$Limit"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=14;continue;}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=19;continue;}
case 19:{f.Push(JValue.L(1));f.Pc=20;continue;}
case 20:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=21;continue;}
case 21:{f.Pc=f.Pop().Int!=0?28:24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Pc=29;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/AITimeoutTracker$Limit","armed","Z",value);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=36;continue;}
case 36:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/AITimeoutTracker$Limit","deadlineNanos","J",value);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(JValue.I(2));f.Pc=42;continue;}
case 42:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=43;continue;}
case 43:{f.Push(JValue.L(1));f.Pc=44;continue;}
case 44:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=45;continue;}
case 45:{f.Pc=f.Pop().Int!=0?52:48;continue;}
case 48:{f.Push(JValue.I(1));f.Pc=49;continue;}
case 49:{f.Pc=53;continue;}
case 52:{f.Push(JValue.I(0));f.Pc=53;continue;}
case 53:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/AITimeoutTracker$Limit","honourInterrupt","Z",value);f.Pc=56;continue;}
case 56:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11617(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","LIMIT","Ljava/lang/ThreadLocal;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","LIMIT","Ljava/lang/ThreadLocal;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/ThreadLocal","get","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/AITimeoutTracker$Limit"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{f.Locals[0]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Limit","armed","Z"));f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Int==0?54:17;continue;}
case 17:{return rt.Call(f,"java/lang/System","nanoTime","()J","invokestatic",20);}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Limit","deadlineNanos","J"));f.Pc=24;continue;}
case 24:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=25;continue;}
case 25:{f.Push(JValue.L(0));f.Pc=26;continue;}
case 26:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=27;continue;}
case 27:{f.Pc=f.Pop().Int>=0?46:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Limit","honourInterrupt","Z"));f.Pc=34;continue;}
case 34:{f.Pc=f.Pop().Int==0?54:37;continue;}
case 37:{return rt.Call(f,"java/lang/Thread","currentThread","()Ljava/lang/Thread;","invokestatic",40);}
case 40:{return rt.Call(f,"java/lang/Thread","isInterrupted","()Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int==0?54:46;continue;}
case 46:{if(!rt.EnsureInitialized(f,"forge/util/AITimeoutTracker$Expired"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/AITimeoutTracker$Expired")));f.Pc=49;continue;}
case 49:{f.StackOp("dup");f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/util/AITimeoutTracker$Expired","<init>","()V","invokespecial",53);}
case 53:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 54:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11618(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","LIMIT","Ljava/lang/ThreadLocal;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/AITimeoutTracker","LIMIT","Ljava/lang/ThreadLocal;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/ThreadLocal","get","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/AITimeoutTracker$Limit"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{f.Locals[0]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Limit","armed","Z"));f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Int==0?28:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Limit","deadlineNanos","J"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/System","nanoTime","()J","invokestatic",24);}
case 24:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=25;continue;}
case 25:{f.Pc=31;continue;}
case 28:{f.Push(JValue.L(9223372036854775807L));f.Pc=31;continue;}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11619(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/AITimeoutTracker","remainingNanos","()J","invokestatic",3);}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/AITimeoutTracker","deadlineNanos","(JJ)J","invokestatic",8);}
case 8:{return rt.Call(f,"java/lang/System","nanoTime","()J","invokestatic",11);}
case 11:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/Math","min","(JJ)J","invokestatic",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11620(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Slot","depth","I"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int<=0?22:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/util/AITimeoutTracker$Slot","startNanos","J"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Int!=0?22:16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/Runnable","run","()V","invokeinterface",22);}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11621(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"java/util/concurrent/TimeUnit","SECONDS","Ljava/util/concurrent/TimeUnit;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/concurrent/TimeUnit","SECONDS","Ljava/util/concurrent/TimeUnit;"));f.Pc=3;continue;}
case 3:{f.Push(JValue.L(2L));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/concurrent/TimeUnit","toNanos","(J)J","invokevirtual",9);}
case 9:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","SHOW_AFTER_NANOS","J"))return JStep.Continue;rt.PutStatic("forge/util/AITimeoutTracker","SHOW_AFTER_NANOS","J",f.Pop());f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"java/util/concurrent/TimeUnit","SECONDS","Ljava/util/concurrent/TimeUnit;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/concurrent/TimeUnit","SECONDS","Ljava/util/concurrent/TimeUnit;"));f.Pc=15;continue;}
case 15:{f.Push(JValue.L(2L));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/concurrent/TimeUnit","toNanos","(J)J","invokevirtual",21);}
case 21:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","staleGraceNanos","J"))return JStep.Continue;rt.PutStatic("forge/util/AITimeoutTracker","staleGraceNanos","J",f.Pop());f.Pc=24;continue;}
case 24:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentHashMap")));f.Pc=27;continue;}
case 27:{f.StackOp("dup");f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","<init>","()V","invokespecial",31);}
case 31:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","SLOTS","Ljava/util/concurrent/ConcurrentHashMap;"))return JStep.Continue;rt.PutStatic("forge/util/AITimeoutTracker","SLOTS","Ljava/util/concurrent/ConcurrentHashMap;",f.Pop());f.Pc=34;continue;}
case 34:{return rt.DynamicCall(f,"forge/util/AITimeoutTracker:11621:34:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Supplier;",39);}
case 39:{return rt.Call(f,"java/lang/ThreadLocal","withInitial","(Ljava/util/function/Supplier;)Ljava/lang/ThreadLocal;","invokestatic",42);}
case 42:{if(!rt.StaticReady(f,"forge/util/AITimeoutTracker","LIMIT","Ljava/lang/ThreadLocal;"))return JStep.Continue;rt.PutStatic("forge/util/AITimeoutTracker","LIMIT","Ljava/lang/ThreadLocal;",f.Pop());f.Pc=45;continue;}
case 45:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

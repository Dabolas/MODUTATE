// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C151{
internal static JClass Build(){var c=new JClass("forge/game/GameLog","java/util/Observable",new string[]{"java/io/Serializable"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(6465283802022948827L),null));
c.Add(new JField("log","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("formatter","Lforge/game/GameLogFormatter;",false,JValue.Default("Lforge/game/GameLogFormatter;"),null));
c.Add(new JField("matchStartMillis","J",false,JValue.Default("J"),null));
c.Add(new JMethod(2383,"forge/game/GameLog","markMatchStartIfNeeded","()V",1,1,4,new JHandler[]{},M2383));
c.Add(new JMethod(2384,"forge/game/GameLog","getMatchStartMillis","()J",1,1,2,new JHandler[]{},M2384));
c.Add(new JMethod(2385,"forge/game/GameLog","<init>","()V",1,1,4,new JHandler[]{},M2385));
c.Add(new JMethod(2386,"forge/game/GameLog","add","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V",1,3,5,new JHandler[]{},M2386));
c.Add(new JMethod(2387,"forge/game/GameLog","add","(Lforge/game/GameLogEntry;)V",0,4,2,new JHandler[]{new JHandler(7,20,23,""),new JHandler(23,26,23,"")},M2387));
c.Add(new JMethod(2388,"forge/game/GameLog","snapshot","()Ljava/util/List;",2,3,3,new JHandler[]{new JHandler(7,20,21,""),new JHandler(21,24,21,"")},M2388));
c.Add(new JMethod(2389,"forge/game/GameLog","size","()I",1,3,2,new JHandler[]{new JHandler(7,18,19,""),new JHandler(19,22,19,"")},M2389));
c.Add(new JMethod(2390,"forge/game/GameLog","truncateTo","(I)V",1,4,3,new JHandler[]{new JHandler(7,26,56,""),new JHandler(27,53,56,""),new JHandler(56,59,56,"")},M2390));
c.Add(new JMethod(2391,"forge/game/GameLog","getAllEntries","()Ljava/util/List;",1,1,1,new JHandler[]{},M2391));
c.Add(new JMethod(2392,"forge/game/GameLog","getLogEntries","(Lforge/game/GameLogEntryType;)Ljava/util/List;",1,6,2,new JHandler[]{},M2392));
c.Add(new JMethod(2393,"forge/game/GameLog","getLogEntriesForVerbosity","(Lforge/game/GameLogVerbosity;)Ljava/util/List;",1,2,2,new JHandler[]{},M2393));
c.Add(new JMethod(2394,"forge/game/GameLog","getLogEntriesForTypes","(Ljava/util/Set;)Ljava/util/List;",1,6,2,new JHandler[]{},M2394));
c.Add(new JMethod(2395,"forge/game/GameLog","getLogEntriesExact","(Lforge/game/GameLogEntryType;)Ljava/util/List;",1,6,2,new JHandler[]{},M2395));
c.Add(new JMethod(2396,"forge/game/GameLog","getEventVisitor","()Lforge/game/GameLogFormatter;",1,1,1,new JHandler[]{},M2396));
}

internal static JStep M2383(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLog","matchStartMillis","J"));f.Pc=4;continue;}
case 4:{f.Push(JValue.L(0));f.Pc=5;continue;}
case 5:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Int>=0?16:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/System","currentTimeMillis","()J","invokestatic",13);}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameLog","matchStartMillis","J",value);f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2384(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLog","matchStartMillis","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2385(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Observable","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameLog","log","Ljava/util/List;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{if(!rt.EnsureInitialized(f,"forge/game/GameLogFormatter"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogFormatter")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/GameLogFormatter","<init>","(Lforge/game/GameLog;)V","invokespecial",24);}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameLog","formatter","Lforge/game/GameLogFormatter;",value);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(JValue.L(-1L));f.Pc=31;continue;}
case 31:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameLog","matchStartMillis","J",value);f.Pc=34;continue;}
case 34:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2386(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",10);}
case 10:{return rt.Call(f,"forge/game/GameLog","add","(Lforge/game/GameLogEntry;)V","invokevirtual",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2387(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLog","log","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLog","log","Ljava/util/List;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",17);}
case 17:{f.StackOp("pop");f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=20;continue;}
case 20:{f.Pc=28;continue;}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/GameLog","setChanged","()V","invokevirtual",32);}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/GameLog","notifyObservers","()V","invokevirtual",36);}
case 36:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2388(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLog","log","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Locals[1]=f.Pop();f.Pc=6;continue;}
case 6:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLog","log","Ljava/util/List;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",18);}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2389(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLog","log","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Locals[1]=f.Pop();f.Pc=6;continue;}
case 6:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLog","log","Ljava/util/List;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",16);}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2390(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLog","log","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int<0?24:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLog","log","Ljava/util/List;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",21);}
case 21:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?27:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=26;continue;}
case 26:{return JStep.ReturnVoid;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLog","log","Ljava/util/List;"));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLog","log","Ljava/util/List;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",41);}
case 41:{return rt.Call(f,"java/util/List","subList","(II)Ljava/util/List;","invokeinterface",46);}
case 46:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",51);}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=53;continue;}
case 53:{f.Pc=61;continue;}
case 56:{f.Locals[3]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/GameLog","setChanged","()V","invokevirtual",65);}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/GameLog","notifyObservers","()V","invokevirtual",69);}
case 69:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2391(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameLog","snapshot","()Ljava/util/List;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2392(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameLog","snapshot","()Ljava/util/List;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",19);}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=21;continue;}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Int<0?72:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameLogEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Pc=f.Pop().Reference==null?57:45;continue;}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/GameLogEntry","type","()Lforge/game/GameLogEntryType;","invokevirtual",50);}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/GameLogEntryType","compareTo","(Ljava/lang/Enum;)I","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int>0?66:57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(-1)));f.Pc=69;continue;}
case 69:{f.Pc=23;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2393(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogVerbosity","getIncludedTypes","()Ljava/util/Set;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/GameLog","getLogEntriesForTypes","(Ljava/util/Set;)Ljava/util/List;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2394(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameLog","snapshot","()Ljava/util/List;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",19);}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=21;continue;}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Int<0?70:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameLogEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[5]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/GameLogEntry","type","()Lforge/game/GameLogEntryType;","invokevirtual",47);}
case 47:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",52);}
case 52:{f.Pc=f.Pop().Int==0?64:55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",63);}
case 63:{f.StackOp("pop");f.Pc=64;continue;}
case 64:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(-1)));f.Pc=67;continue;}
case 67:{f.Pc=23;continue;}
case 70:{f.Push(f.Locals[3]);f.Pc=71;continue;}
case 71:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2395(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameLog","snapshot","()Ljava/util/List;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",19);}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=21;continue;}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Int<0?72:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameLogEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Pc=f.Pop().Reference==null?57:45;continue;}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/GameLogEntry","type","()Lforge/game/GameLogEntryType;","invokevirtual",50);}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/GameLogEntryType","compareTo","(Ljava/lang/Enum;)I","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int!=0?66:57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(-1)));f.Pc=69;continue;}
case 69:{f.Pc=23;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2396(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLog","formatter","Lforge/game/GameLogFormatter;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

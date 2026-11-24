// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1025{
internal static JClass Build(){var c=new JClass("forge/game/undo/GameMemento","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("WALK","[Ljava/lang/String;",true,JValue.Default("[Ljava/lang/String;"),null));
c.Add(new JField("SKIP","[Ljava/lang/String;",true,JValue.Default("[Ljava/lang/String;"),null));
c.Add(new JField("P_REF","I",true,JValue.I(0),null));
c.Add(new JField("P_INT","I",true,JValue.I(1),null));
c.Add(new JField("P_LONG","I",true,JValue.I(2),null));
c.Add(new JField("P_BOOL","I",true,JValue.I(3),null));
c.Add(new JField("P_DOUBLE","I",true,JValue.I(4),null));
c.Add(new JField("P_FLOAT","I",true,JValue.I(5),null));
c.Add(new JField("P_BYTE","I",true,JValue.I(6),null));
c.Add(new JField("P_SHORT","I",true,JValue.I(7),null));
c.Add(new JField("P_CHAR","I",true,JValue.I(8),null));
c.Add(new JField("NO_OBJECTS","[Ljava/lang/Object;",true,JValue.Default("[Ljava/lang/Object;"),null));
c.Add(new JField("NO_LONGS","[J",true,JValue.Default("[J"),null));
c.Add(new JField("NO_INTS","[I",true,JValue.Default("[I"),null));
c.Add(new JField("NO_SNAPS","[Lforge/game/undo/GameMemento$Snap;",true,JValue.Default("[Lforge/game/undo/GameMemento$Snap;"),null));
c.Add(new JField("NO_DELTAS","[Lforge/game/undo/GameMemento$HistoryData;",true,JValue.Default("[Lforge/game/undo/GameMemento$HistoryData;"),null));
c.Add(new JField("NO_NODES","[Lforge/game/undo/GameMemento$Node;",true,JValue.Default("[Lforge/game/undo/GameMemento$Node;"),null));
c.Add(new JField("NODE_BYTES","J",true,JValue.L(64L),null));
c.Add(new JField("ENTRY_BYTES","J",true,JValue.L(16L),null));
c.Add(new JField("MEMENTO_BYTES","J",true,JValue.L(96L),null));
c.Add(new JField("MAX_KEPT_SCRATCH","I",true,JValue.I(65536),null));
c.Add(new JField("INITIAL_SCRATCH","I",true,JValue.I(1024),null));
c.Add(new JField("KINDS","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("INFOS","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("targets","[Ljava/lang/Object;",false,JValue.Default("[Ljava/lang/Object;"),null));
c.Add(new JField("snaps","[Lforge/game/undo/GameMemento$Snap;",false,JValue.Default("[Lforge/game/undo/GameMemento$Snap;"),null));
c.Add(new JField("owner","Lforge/game/undo/GameMemento$Recorder;",false,JValue.Default("Lforge/game/undo/GameMemento$Recorder;"),null));
c.Add(new JField("next","Lforge/game/undo/GameMemento;",false,JValue.Default("Lforge/game/undo/GameMemento;"),null));
c.Add(new JField("undoNodes","[Lforge/game/undo/GameMemento$Node;",false,JValue.Default("[Lforge/game/undo/GameMemento$Node;"),null));
c.Add(new JField("undoDeltas","[Lforge/game/undo/GameMemento$HistoryData;",false,JValue.Default("[Lforge/game/undo/GameMemento$HistoryData;"),null));
c.Add(new JField("undoBytes","J",false,JValue.Default("J"),null));
c.Add(new JField("size","I",false,JValue.Default("I"),null));
c.Add(new JField("captureBytes","J",false,JValue.Default("J"),null));
c.Add(new JField("problems","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(10888,"forge/game/undo/GameMemento","arr","(I)J",10,1,6,new JHandler[]{},M10888));
c.Add(new JMethod(10889,"forge/game/undo/GameMemento","<init>","()V",2,1,3,new JHandler[]{},M10889));
c.Add(new JMethod(10890,"forge/game/undo/GameMemento","capture","(Ljava/lang/Object;)Lforge/game/undo/GameMemento;",9,1,2,new JHandler[]{},M10890));
c.Add(new JMethod(10891,"forge/game/undo/GameMemento","objectCount","()I",1,1,1,new JHandler[]{},M10891));
c.Add(new JMethod(10892,"forge/game/undo/GameMemento","deltaSize","()I",1,1,1,new JHandler[]{},M10892));
c.Add(new JMethod(10893,"forge/game/undo/GameMemento","retainedBytes","()J",1,1,6,new JHandler[]{},M10893));
c.Add(new JMethod(10894,"forge/game/undo/GameMemento","captureBytes","()J",0,1,2,new JHandler[]{},M10894));
c.Add(new JMethod(10895,"forge/game/undo/GameMemento","histogram","()Ljava/util/List;",1,6,4,new JHandler[]{},M10895));
c.Add(new JMethod(10896,"forge/game/undo/GameMemento","sharedWith","(Lforge/game/undo/GameMemento;)I",0,5,3,new JHandler[]{},M10896));
c.Add(new JMethod(10897,"forge/game/undo/GameMemento","restore","()Z",1,4,4,new JHandler[]{},M10897));
c.Add(new JMethod(10898,"forge/game/undo/GameMemento","writeFields","(Ljava/lang/Object;Lforge/game/undo/GameMemento$ObjSnap;)V",2,9,5,new JHandler[]{new JHandler(41,99,102,"java/lang/Exception")},M10898));
c.Add(new JMethod(10899,"forge/game/undo/GameMemento","restoreContainer","(Ljava/lang/Object;Lforge/game/undo/GameMemento$Snap;)V",2,6,6,new JHandler[]{new JHandler(0,341,344,"java/lang/RuntimeException")},M10899));
c.Add(new JMethod(10900,"forge/game/undo/GameMemento","sameElements","(Ljava/util/Collection;[Ljava/lang/Object;)Z",10,5,3,new JHandler[]{},M10900));
c.Add(new JMethod(10901,"forge/game/undo/GameMemento","sameMap","(Ljava/util/Map;[Ljava/lang/Object;)Z",10,5,4,new JHandler[]{},M10901));
c.Add(new JMethod(10902,"forge/game/undo/GameMemento","samePrimArray","(Ljava/lang/Object;Ljava/lang/Object;)Z",10,4,2,new JHandler[]{},M10902));
c.Add(new JMethod(10903,"forge/game/undo/GameMemento","sameItems","([Ljava/lang/Object;[Ljava/lang/Object;I)Z",10,4,3,new JHandler[]{},M10903));
c.Add(new JMethod(10904,"forge/game/undo/GameMemento","diff","(Lforge/game/undo/GameMemento;)Ljava/util/List;",1,18,5,new JHandler[]{},M10904));
c.Add(new JMethod(10905,"forge/game/undo/GameMemento","kindOf","(Ljava/lang/Class;)Lforge/game/undo/GameMemento$Kind;",10,2,3,new JHandler[]{},M10905));
c.Add(new JMethod(10906,"forge/game/undo/GameMemento","computeKind","(Ljava/lang/Class;)Lforge/game/undo/GameMemento$Kind;",10,10,2,new JHandler[]{},M10906));
c.Add(new JMethod(10907,"forge/game/undo/GameMemento","infoOf","(Ljava/lang/Class;)Lforge/game/undo/GameMemento$ClassInfo;",10,2,3,new JHandler[]{},M10907));
c.Add(new JMethod(10908,"forge/game/undo/GameMemento","primKind","(Ljava/lang/Class;)I",10,1,2,new JHandler[]{},M10908));
c.Add(new JMethod(10909,"forge/game/undo/GameMemento","readPrim","(Ljava/lang/reflect/Field;ILjava/lang/Object;)J",10,3,2,new JHandler[]{},M10909));
c.Add(new JMethod(10910,"forge/game/undo/GameMemento","writePrim","(Ljava/lang/reflect/Field;ILjava/lang/Object;J)V",10,5,6,new JHandler[]{},M10910));
c.Add(new JMethod(10911,"forge/game/undo/GameMemento","lambda$histogram$0","(Ljava/util/Map$Entry;Ljava/util/Map$Entry;)I",4106,2,2,new JHandler[]{},M10911));
c.Add(new JMethod(10912,"forge/game/undo/GameMemento","<clinit>","()V",8,0,4,new JHandler[]{},M10912));
}

internal static JStep M10888(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int!=0?8:4;continue;}
case 4:{f.Push(JValue.L(0));f.Pc=5;continue;}
case 5:{f.Pc=18;continue;}
case 8:{f.Push(JValue.L(16L));f.Pc=11;continue;}
case 11:{f.Push(JValue.L(8L));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=16;continue;}
case 16:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lmul",a,b));f.Pc=17;continue;}
case 17:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=18;continue;}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10889(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_OBJECTS","[Ljava/lang/Object;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","NO_OBJECTS","[Ljava/lang/Object;"));f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento","targets","[Ljava/lang/Object;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_SNAPS","[Lforge/game/undo/GameMemento$Snap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","NO_SNAPS","[Lforge/game/undo/GameMemento$Snap;"));f.Pc=15;continue;}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento","snaps","[Lforge/game/undo/GameMemento$Snap;",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_NODES","[Lforge/game/undo/GameMemento$Node;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","NO_NODES","[Lforge/game/undo/GameMemento$Node;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento","undoNodes","[Lforge/game/undo/GameMemento$Node;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_DELTAS","[Lforge/game/undo/GameMemento$HistoryData;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","NO_DELTAS","[Lforge/game/undo/GameMemento$HistoryData;"));f.Pc=29;continue;}
case 29:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento","undoDeltas","[Lforge/game/undo/GameMemento$HistoryData;",value);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",40);}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento","problems","Ljava/util/List;",value);f.Pc=43;continue;}
case 43:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10890(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/undo/GameMemento$Recorder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/undo/GameMemento$Recorder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","<init>","()V","invokespecial",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","captureStandalone","(Ljava/lang/Object;)Lforge/game/undo/GameMemento;","invokevirtual",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10891(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","owner","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?14:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","size","I"));f.Pc=11;continue;}
case 11:{f.Pc=19;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","targets","[Ljava/lang/Object;"));f.Pc=18;continue;}
case 18:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10892(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","undoNodes","[Lforge/game/undo/GameMemento$Node;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10893(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","owner","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?16:7;continue;}
case 7:{f.Push(JValue.L(96L));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","undoBytes","J"));f.Pc=14;continue;}
case 14:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
case 16:{f.Push(JValue.L(96L));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","targets","[Ljava/lang/Object;"));f.Pc=23;continue;}
case 23:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=24;continue;}
case 24:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","snaps","[Lforge/game/undo/GameMemento$Snap;"));f.Pc=29;continue;}
case 29:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=30;continue;}
case 30:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=31;continue;}
case 31:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=32;continue;}
case 32:{f.Push(JValue.L(8L));f.Pc=35;continue;}
case 35:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lmul",a,b));f.Pc=36;continue;}
case 36:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=37;continue;}
case 37:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10894(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","captureBytes","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10895(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","owner","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference!=null?71:15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","targets","[Ljava/lang/Object;"));f.Pc=19;continue;}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=22;continue;}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{f.Locals[4]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?68:32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[4]);f.Pc=35;continue;}
case 35:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=36;continue;}
case 36:{f.Locals[5]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",44);}
case 44:{return rt.Call(f,"java/lang/Class","getName","()Ljava/lang/String;","invokevirtual",47);}
case 47:{f.Push(JValue.I(1));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",51);}
case 51:{return rt.DynamicCall(f,"forge/game/undo/GameMemento:10895:51:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/BiFunction;",56);}
case 56:{return rt.Call(f,"java/util/Map","merge","(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;","invokeinterface",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=65;continue;}
case 65:{f.Pc=26;continue;}
case 68:{f.Pc=146;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","owner","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=75;continue;}
case 75:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","last","Lforge/game/undo/GameMemento;"));f.Pc=78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?146:82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","owner","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=86;continue;}
case 86:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","registry","Ljava/util/IdentityHashMap;"));f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/IdentityHashMap","values","()Ljava/util/Collection;","invokevirtual",92);}
case 92:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",97);}
case 97:{f.Locals[2]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",104);}
case 104:{f.Pc=f.Pop().Int==0?146:107;continue;}
case 107:{f.Push(f.Locals[2]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",113);}
case 113:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$Node"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=116;continue;}
case 116:{f.Locals[3]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[3]);f.Pc=119;continue;}
case 119:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","obj","Ljava/lang/Object;"));f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",125);}
case 125:{return rt.Call(f,"java/lang/Class","getName","()Ljava/lang/String;","invokevirtual",128);}
case 128:{f.Push(JValue.I(1));f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",132);}
case 132:{return rt.DynamicCall(f,"forge/game/undo/GameMemento:10895:132:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/BiFunction;",137);}
case 137:{return rt.Call(f,"java/util/Map","merge","(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;","invokeinterface",142);}
case 142:{f.StackOp("pop");f.Pc=143;continue;}
case 143:{f.Pc=98;continue;}
case 146:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=149;continue;}
case 149:{f.StackOp("dup");f.Pc=150;continue;}
case 150:{f.Push(f.Locals[1]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",156);}
case 156:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",159);}
case 159:{f.Locals[2]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(f.Locals[2]);f.Pc=161;continue;}
case 161:{return rt.DynamicCall(f,"forge/game/undo/GameMemento:10895:161:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/Comparator;",166);}
case 166:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",171);}
case 171:{f.Push(f.Locals[2]);f.Pc=172;continue;}
case 172:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10896(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","snaps","[Lforge/game/undo/GameMemento$Snap;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","snaps","[Lforge/game/undo/GameMemento$Snap;"));f.Pc=9;continue;}
case 9:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",13);}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?51:25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","snaps","[Lforge/game/undo/GameMemento$Snap;"));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","snaps","[Lforge/game/undo/GameMemento$Snap;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=39;continue;}
case 39:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?45:42;continue;}
case 42:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=45;continue;}
case 45:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=48;continue;}
case 48:{f.Pc=19;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10897(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","owner","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?34:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","owner","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","restoreTo","(Lforge/game/undo/GameMemento;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?20:18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","problems","Ljava/util/List;"));f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("memento is no longer part of the recorder's history")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",31);}
case 31:{f.StackOp("pop");f.Pc=32;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 34:{f.Push(JValue.I(0));f.Pc=35;continue;}
case 35:{f.Locals[1]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","targets","[Ljava/lang/Object;"));f.Pc=41;continue;}
case 41:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=42;continue;}
case 42:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?81:45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","snaps","[Lforge/game/undo/GameMemento$Snap;"));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=51;continue;}
case 51:{f.Locals[3]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$ObjSnap")?1:0));f.Pc=56;continue;}
case 56:{f.Pc=f.Pop().Int==0?75:59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$ObjSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=63;continue;}
case 63:{f.Locals[2]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","targets","[Ljava/lang/Object;"));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=71;continue;}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/undo/GameMemento","writeFields","(Ljava/lang/Object;Lforge/game/undo/GameMemento$ObjSnap;)V","invokevirtual",75);}
case 75:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(1)));f.Pc=78;continue;}
case 78:{f.Pc=36;continue;}
case 81:{f.Push(JValue.I(0));f.Pc=82;continue;}
case 82:{f.Locals[1]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","targets","[Ljava/lang/Object;"));f.Pc=88;continue;}
case 88:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=89;continue;}
case 89:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?126:92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","snaps","[Lforge/game/undo/GameMemento$Snap;"));f.Pc=96;continue;}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=98;continue;}
case 98:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$ObjSnap")?1:0));f.Pc=101;continue;}
case 101:{f.Pc=f.Pop().Int!=0?120:104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","targets","[Ljava/lang/Object;"));f.Pc=109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","snaps","[Lforge/game/undo/GameMemento$Snap;"));f.Pc=115;continue;}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/undo/GameMemento","restoreContainer","(Ljava/lang/Object;Lforge/game/undo/GameMemento$Snap;)V","invokevirtual",120);}
case 120:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(1)));f.Pc=123;continue;}
case 123:{f.Pc=83;continue;}
case 126:{f.Push(JValue.I(1));f.Pc=127;continue;}
case 127:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10898(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","ci","Lforge/game/undo/GameMemento$ClassInfo;"));f.Pc=4;continue;}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","fields","[Ljava/lang/reflect/Field;"));f.Pc=9;continue;}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{f.Locals[5]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Locals[6]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{f.Locals[7]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[7]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=25;continue;}
case 25:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?133:28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","stored","[Z"));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[7]);f.Pc=34;continue;}
case 34:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Int!=0?41:38;continue;}
case 38:{f.Pc=127;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","pk","[I"));f.Pc=45;continue;}
case 45:{f.Push(f.Locals[7]);f.Pc=47;continue;}
case 47:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=48;continue;}
case 48:{f.Pc=f.Pop().Int!=0?73:51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[7]);f.Pc=55;continue;}
case 55:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","refs","[Ljava/lang/Object;"));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=66;continue;}
case 66:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/reflect/Field","set","(Ljava/lang/Object;Ljava/lang/Object;)V","invokevirtual",70);}
case 70:{f.Pc=99;continue;}
case 73:{f.Push(f.Locals[4]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[7]);f.Pc=77;continue;}
case 77:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=78;continue;}
case 78:{f.Push(f.Locals[3]);f.Pc=79;continue;}
case 79:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","pk","[I"));f.Pc=82;continue;}
case 82:{f.Push(f.Locals[7]);f.Pc=84;continue;}
case 84:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","prims","[J"));f.Pc=90;continue;}
case 90:{f.Push(f.Locals[6]);f.Pc=92;continue;}
case 92:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=95;continue;}
case 95:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/undo/GameMemento","writePrim","(Ljava/lang/reflect/Field;ILjava/lang/Object;J)V","invokestatic",99);}
case 99:{f.Pc=127;continue;}
case 102:{f.Locals[8]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","problems","Ljava/util/List;"));f.Pc=108;continue;}
case 108:{f.Push(f.Locals[4]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[7]);f.Pc=112;continue;}
case 112:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",116);}
case 116:{return rt.DynamicCall(f,"forge/game/undo/GameMemento:10898:116:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",121);}
case 121:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",126);}
case 126:{f.StackOp("pop");f.Pc=127;continue;}
case 127:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=130;continue;}
case 130:{f.Pc=20;continue;}
case 133:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10899(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento$1","$SwitchMap$forge$game$undo$GameMemento$Kind","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento$1","$SwitchMap$forge$game$undo$GameMemento$Kind","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/undo/GameMemento","kindOf","(Ljava/lang/Class;)Lforge/game/undo/GameMemento$Kind;","invokestatic",10);}
case 10:{return rt.Call(f,"forge/game/undo/GameMemento$Kind","ordinal","()I","invokevirtual",13);}
case 13:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=14;continue;}
case 14:{switch(f.Pop().Int){case 1:f.Pc=48;break;case 2:f.Pc=103;break;case 3:f.Pc=174;break;case 4:f.Pc=233;break;case 5:f.Pc=299;break;default:f.Pc=341;break;}continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$PrimArrSnap")?1:0));f.Pc=52;continue;}
case 52:{f.Pc=f.Pop().Int==0?80:55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$PrimArrSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=59;continue;}
case 59:{f.Locals[3]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$PrimArrSnap","copy","Ljava/lang/Object;"));f.Pc=64;continue;}
case 64:{f.Push(JValue.I(0));f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{f.Push(JValue.I(0));f.Pc=67;continue;}
case 67:{f.Push(f.Locals[3]);f.Pc=68;continue;}
case 68:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$PrimArrSnap","copy","Ljava/lang/Object;"));f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/reflect/Array","getLength","(Ljava/lang/Object;)I","invokestatic",74);}
case 74:{return rt.Call(f,"java/lang/System","arraycopy","(Ljava/lang/Object;ILjava/lang/Object;II)V","invokestatic",77);}
case 77:{f.Pc=341;continue;}
case 80:{f.Push(f.Locals[2]);f.Pc=81;continue;}
case 81:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$SeqSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=84;continue;}
case 84:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=87;continue;}
case 87:{f.Locals[4]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{f.Push(JValue.I(0));f.Pc=92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{f.Push(JValue.I(0));f.Pc=94;continue;}
case 94:{f.Push(f.Locals[4]);f.Pc=96;continue;}
case 96:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/System","arraycopy","(Ljava/lang/Object;ILjava/lang/Object;II)V","invokestatic",100);}
case 100:{f.Pc=341;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=107;continue;}
case 107:{f.Locals[3]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[2]);f.Pc=109;continue;}
case 109:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$SeqSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=112;continue;}
case 112:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=115;continue;}
case 115:{f.Locals[4]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[3]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[4]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/undo/GameMemento","sameMap","(Ljava/util/Map;[Ljava/lang/Object;)Z","invokestatic",123);}
case 123:{f.Pc=f.Pop().Int==0?129:126;continue;}
case 126:{f.Pc=341;continue;}
case 129:{f.Push(f.Locals[3]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",135);}
case 135:{f.Push(JValue.I(0));f.Pc=136;continue;}
case 136:{f.Locals[5]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[5]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[4]);f.Pc=142;continue;}
case 142:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=143;continue;}
case 143:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?171:146;continue;}
case 146:{f.Push(f.Locals[3]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[4]);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[5]);f.Pc=151;continue;}
case 151:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=152;continue;}
case 152:{f.Push(f.Locals[4]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[5]);f.Pc=156;continue;}
case 156:{f.Push(JValue.I(1));f.Pc=157;continue;}
case 157:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=158;continue;}
case 158:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=159;continue;}
case 159:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",164);}
case 164:{f.StackOp("pop");f.Pc=165;continue;}
case 165:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(2)));f.Pc=168;continue;}
case 168:{f.Pc=138;continue;}
case 171:{f.Pc=341;continue;}
case 174:{f.Push(f.Locals[1]);f.Pc=175;continue;}
case 175:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=178;continue;}
case 178:{f.Locals[3]=f.Pop();f.Pc=179;continue;}
case 179:{f.Push(f.Locals[2]);f.Pc=180;continue;}
case 180:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$SeqSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=183;continue;}
case 183:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=186;continue;}
case 186:{f.Locals[4]=f.Pop();f.Pc=188;continue;}
case 188:{f.Push(f.Locals[3]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"com/google/common/collect/Multimap","clear","()V","invokeinterface",194);}
case 194:{f.Push(JValue.I(0));f.Pc=195;continue;}
case 195:{f.Locals[5]=f.Pop();f.Pc=197;continue;}
case 197:{f.Push(f.Locals[5]);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[4]);f.Pc=201;continue;}
case 201:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=202;continue;}
case 202:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?230:205;continue;}
case 205:{f.Push(f.Locals[3]);f.Pc=206;continue;}
case 206:{f.Push(f.Locals[4]);f.Pc=208;continue;}
case 208:{f.Push(f.Locals[5]);f.Pc=210;continue;}
case 210:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=211;continue;}
case 211:{f.Push(f.Locals[4]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[5]);f.Pc=215;continue;}
case 215:{f.Push(JValue.I(1));f.Pc=216;continue;}
case 216:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=217;continue;}
case 217:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=218;continue;}
case 218:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",223);}
case 223:{f.StackOp("pop");f.Pc=224;continue;}
case 224:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(2)));f.Pc=227;continue;}
case 227:{f.Pc=197;continue;}
case 230:{f.Pc=341;continue;}
case 233:{f.Push(f.Locals[1]);f.Pc=234;continue;}
case 234:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Table"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=237;continue;}
case 237:{f.Locals[3]=f.Pop();f.Pc=238;continue;}
case 238:{f.Push(f.Locals[2]);f.Pc=239;continue;}
case 239:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$SeqSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=242;continue;}
case 242:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=245;continue;}
case 245:{f.Locals[4]=f.Pop();f.Pc=247;continue;}
case 247:{f.Push(f.Locals[3]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"com/google/common/collect/Table","clear","()V","invokeinterface",253);}
case 253:{f.Push(JValue.I(0));f.Pc=254;continue;}
case 254:{f.Locals[5]=f.Pop();f.Pc=256;continue;}
case 256:{f.Push(f.Locals[5]);f.Pc=258;continue;}
case 258:{f.Push(f.Locals[4]);f.Pc=260;continue;}
case 260:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=261;continue;}
case 261:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?296:264;continue;}
case 264:{f.Push(f.Locals[3]);f.Pc=265;continue;}
case 265:{f.Push(f.Locals[4]);f.Pc=267;continue;}
case 267:{f.Push(f.Locals[5]);f.Pc=269;continue;}
case 269:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=270;continue;}
case 270:{f.Push(f.Locals[4]);f.Pc=272;continue;}
case 272:{f.Push(f.Locals[5]);f.Pc=274;continue;}
case 274:{f.Push(JValue.I(1));f.Pc=275;continue;}
case 275:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=276;continue;}
case 276:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=277;continue;}
case 277:{f.Push(f.Locals[4]);f.Pc=279;continue;}
case 279:{f.Push(f.Locals[5]);f.Pc=281;continue;}
case 281:{f.Push(JValue.I(2));f.Pc=282;continue;}
case 282:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=283;continue;}
case 283:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=284;continue;}
case 284:{return rt.Call(f,"com/google/common/collect/Table","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",289);}
case 289:{f.StackOp("pop");f.Pc=290;continue;}
case 290:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(3)));f.Pc=293;continue;}
case 293:{f.Pc=256;continue;}
case 296:{f.Pc=341;continue;}
case 299:{f.Push(f.Locals[1]);f.Pc=300;continue;}
case 300:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=303;continue;}
case 303:{f.Locals[3]=f.Pop();f.Pc=304;continue;}
case 304:{f.Push(f.Locals[2]);f.Pc=305;continue;}
case 305:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$SeqSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=308;continue;}
case 308:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=311;continue;}
case 311:{f.Locals[4]=f.Pop();f.Pc=313;continue;}
case 313:{f.Push(f.Locals[3]);f.Pc=314;continue;}
case 314:{f.Push(f.Locals[4]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/undo/GameMemento","sameElements","(Ljava/util/Collection;[Ljava/lang/Object;)Z","invokestatic",319);}
case 319:{f.Pc=f.Pop().Int==0?325:322;continue;}
case 322:{f.Pc=341;continue;}
case 325:{f.Push(f.Locals[3]);f.Pc=326;continue;}
case 326:{return rt.Call(f,"java/util/Collection","clear","()V","invokeinterface",331);}
case 331:{f.Push(f.Locals[3]);f.Pc=332;continue;}
case 332:{f.Push(f.Locals[4]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"java/util/Collections","addAll","(Ljava/util/Collection;[Ljava/lang/Object;)Z","invokestatic",337);}
case 337:{f.StackOp("pop");f.Pc=338;continue;}
case 338:{f.Pc=341;continue;}
case 341:{f.Pc=371;continue;}
case 344:{f.Locals[3]=f.Pop();f.Pc=345;continue;}
case 345:{f.Push(f.Locals[0]);f.Pc=346;continue;}
case 346:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","problems","Ljava/util/List;"));f.Pc=349;continue;}
case 349:{f.Push(f.Locals[1]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",353);}
case 353:{return rt.Call(f,"java/lang/Class","getName","()Ljava/lang/String;","invokevirtual",356);}
case 356:{f.Push(f.Locals[3]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",360);}
case 360:{return rt.DynamicCall(f,"forge/game/undo/GameMemento:10899:360:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",365);}
case 365:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",370);}
case 370:{f.StackOp("pop");f.Pc=371;continue;}
case 371:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10900(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",6);}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=8;continue;}
case 8:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?13:11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",21);}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Int==0?55:31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",37);}
case 37:{f.Locals[4]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=46;continue;}
case 46:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=47;continue;}
case 47:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?52:50;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 52:{f.Pc=22;continue;}
case 55:{f.Push(JValue.I(1));f.Pc=56;continue;}
case 56:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10901(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map","size","()I","invokeinterface",6);}
case 6:{f.Push(JValue.I(2));f.Pc=7;continue;}
case 7:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=10;continue;}
case 10:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?15:13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",23);}
case 23:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",28);}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",35);}
case 35:{f.Pc=f.Pop().Int==0?85:38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",44);}
case 44:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=47;continue;}
case 47:{f.Locals[4]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",56);}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=59;continue;}
case 59:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?77:62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",69);}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{f.Push(JValue.I(1));f.Pc=72;continue;}
case 72:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=73;continue;}
case 73:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=74;continue;}
case 74:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?79:77;continue;}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 79:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(2)));f.Pc=82;continue;}
case 82:{f.Pc=29;continue;}
case 85:{f.Push(JValue.I(1));f.Pc=86;continue;}
case 86:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10902(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?7:5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[I")?1:0));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int==0?37:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[I"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[I")?1:0));f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Int==0?37:26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[I"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Arrays","equals","([I[I)Z","invokestatic",36);}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[J")?1:0));f.Pc=41;continue;}
case 41:{f.Pc=f.Pop().Int==0?67:44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[J"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=48;continue;}
case 48:{f.Locals[2]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[J")?1:0));f.Pc=53;continue;}
case 53:{f.Pc=f.Pop().Int==0?67:56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[J"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=60;continue;}
case 60:{f.Locals[3]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Arrays","equals","([J[J)Z","invokestatic",66);}
case 66:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[Z")?1:0));f.Pc=71;continue;}
case 71:{f.Pc=f.Pop().Int==0?97:74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Z"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=78;continue;}
case 78:{f.Locals[2]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[Z")?1:0));f.Pc=83;continue;}
case 83:{f.Pc=f.Pop().Int==0?97:86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Z"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=90;continue;}
case 90:{f.Locals[3]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[3]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/util/Arrays","equals","([Z[Z)Z","invokestatic",96);}
case 96:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[D")?1:0));f.Pc=101;continue;}
case 101:{f.Pc=f.Pop().Int==0?127:104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[D"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=108;continue;}
case 108:{f.Locals[2]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[D")?1:0));f.Pc=113;continue;}
case 113:{f.Pc=f.Pop().Int==0?127:116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[D"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=120;continue;}
case 120:{f.Locals[3]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[2]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[3]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/util/Arrays","equals","([D[D)Z","invokestatic",126);}
case 126:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[F")?1:0));f.Pc=131;continue;}
case 131:{f.Pc=f.Pop().Int==0?157:134;continue;}
case 134:{f.Push(f.Locals[0]);f.Pc=135;continue;}
case 135:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[F"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=138;continue;}
case 138:{f.Locals[2]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[1]);f.Pc=140;continue;}
case 140:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[F")?1:0));f.Pc=143;continue;}
case 143:{f.Pc=f.Pop().Int==0?157:146;continue;}
case 146:{f.Push(f.Locals[1]);f.Pc=147;continue;}
case 147:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[F"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=150;continue;}
case 150:{f.Locals[3]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(f.Locals[2]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[3]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/util/Arrays","equals","([F[F)Z","invokestatic",156);}
case 156:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 157:{f.Push(f.Locals[0]);f.Pc=158;continue;}
case 158:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[B")?1:0));f.Pc=161;continue;}
case 161:{f.Pc=f.Pop().Int==0?187:164;continue;}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[B"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=168;continue;}
case 168:{f.Locals[2]=f.Pop();f.Pc=169;continue;}
case 169:{f.Push(f.Locals[1]);f.Pc=170;continue;}
case 170:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[B")?1:0));f.Pc=173;continue;}
case 173:{f.Pc=f.Pop().Int==0?187:176;continue;}
case 176:{f.Push(f.Locals[1]);f.Pc=177;continue;}
case 177:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[B"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=180;continue;}
case 180:{f.Locals[3]=f.Pop();f.Pc=181;continue;}
case 181:{f.Push(f.Locals[2]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[3]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/util/Arrays","equals","([B[B)Z","invokestatic",186);}
case 186:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 187:{f.Push(f.Locals[0]);f.Pc=188;continue;}
case 188:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[S")?1:0));f.Pc=191;continue;}
case 191:{f.Pc=f.Pop().Int==0?217:194;continue;}
case 194:{f.Push(f.Locals[0]);f.Pc=195;continue;}
case 195:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[S"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=198;continue;}
case 198:{f.Locals[2]=f.Pop();f.Pc=199;continue;}
case 199:{f.Push(f.Locals[1]);f.Pc=200;continue;}
case 200:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[S")?1:0));f.Pc=203;continue;}
case 203:{f.Pc=f.Pop().Int==0?217:206;continue;}
case 206:{f.Push(f.Locals[1]);f.Pc=207;continue;}
case 207:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[S"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=210;continue;}
case 210:{f.Locals[3]=f.Pop();f.Pc=211;continue;}
case 211:{f.Push(f.Locals[2]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[3]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"java/util/Arrays","equals","([S[S)Z","invokestatic",216);}
case 216:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 217:{f.Push(f.Locals[0]);f.Pc=218;continue;}
case 218:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[C")?1:0));f.Pc=221;continue;}
case 221:{f.Pc=f.Pop().Int==0?247:224;continue;}
case 224:{f.Push(f.Locals[0]);f.Pc=225;continue;}
case 225:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[C"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=228;continue;}
case 228:{f.Locals[2]=f.Pop();f.Pc=229;continue;}
case 229:{f.Push(f.Locals[1]);f.Pc=230;continue;}
case 230:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[C")?1:0));f.Pc=233;continue;}
case 233:{f.Pc=f.Pop().Int==0?247:236;continue;}
case 236:{f.Push(f.Locals[1]);f.Pc=237;continue;}
case 237:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[C"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=240;continue;}
case 240:{f.Locals[3]=f.Pop();f.Pc=241;continue;}
case 241:{f.Push(f.Locals[2]);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[3]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"java/util/Arrays","equals","([C[C)Z","invokestatic",246);}
case 246:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 247:{f.Push(JValue.I(0));f.Pc=248;continue;}
case 248:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10903(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?8:6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?32:15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=21;continue;}
case 21:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?26:24;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 26:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=29;continue;}
case 29:{f.Pc=10;continue;}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10904(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","owner","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?14:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","owner","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Reference==null?21:14;continue;}
case 14:{f.Push(JValue.R(rt.String("diff needs full mementos (GameMemento.capture)")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Collections","singletonList","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",20);}
case 20:{return JStep.Return(f.Pop());}
case 21:{if(!rt.EnsureInitialized(f,"java/util/IdentityHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/IdentityHashMap")));f.Pc=24;continue;}
case 24:{f.StackOp("dup");f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","targets","[Ljava/lang/Object;"));f.Pc=29;continue;}
case 29:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=30;continue;}
case 30:{f.Push(JValue.I(2));f.Pc=31;continue;}
case 31:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/IdentityHashMap","<init>","(I)V","invokespecial",37);}
case 37:{f.Locals[2]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{f.Locals[3]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","targets","[Ljava/lang/Object;"));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=46;continue;}
case 46:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?72:49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","targets","[Ljava/lang/Object;"));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","snaps","[Lforge/game/undo/GameMemento$Snap;"));f.Pc=60;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/IdentityHashMap","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=69;continue;}
case 69:{f.Pc=40;continue;}
case 72:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=75;continue;}
case 75:{f.StackOp("dup");f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",79);}
case 79:{f.Locals[3]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(JValue.I(0));f.Pc=81;continue;}
case 81:{f.Locals[4]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[4]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","targets","[Ljava/lang/Object;"));f.Pc=89;continue;}
case 89:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=90;continue;}
case 90:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?520:93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","snaps","[Lforge/game/undo/GameMemento$Snap;"));f.Pc=97;continue;}
case 97:{f.Push(f.Locals[4]);f.Pc=99;continue;}
case 99:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=100;continue;}
case 100:{f.Locals[5]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[2]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","targets","[Ljava/lang/Object;"));f.Pc=107;continue;}
case 107:{f.Push(f.Locals[4]);f.Pc=109;continue;}
case 109:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/IdentityHashMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",113);}
case 113:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$Snap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=116;continue;}
case 116:{f.Locals[6]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","targets","[Ljava/lang/Object;"));f.Pc=122;continue;}
case 122:{f.Push(f.Locals[4]);f.Pc=124;continue;}
case 124:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",128);}
case 128:{return rt.Call(f,"java/lang/Class","getSimpleName","()Ljava/lang/String;","invokevirtual",131);}
case 131:{f.Locals[7]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(f.Locals[6]);f.Pc=135;continue;}
case 135:{f.Pc=f.Pop().Reference!=null?155:138;continue;}
case 138:{f.Push(f.Locals[3]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[7]);f.Pc=141;continue;}
case 141:{return rt.DynamicCall(f,"forge/game/undo/GameMemento:10904:141:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",146);}
case 146:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",151);}
case 151:{f.StackOp("pop");f.Pc=152;continue;}
case 152:{f.Pc=514;continue;}
case 155:{f.Push(f.Locals[5]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[6]);f.Pc=159;continue;}
case 159:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?165:162;continue;}
case 162:{f.Pc=514;continue;}
case 165:{f.Push(f.Locals[5]);f.Pc=167;continue;}
case 167:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$ObjSnap")?1:0));f.Pc=170;continue;}
case 170:{f.Pc=f.Pop().Int==0?368:173;continue;}
case 173:{f.Push(f.Locals[5]);f.Pc=175;continue;}
case 175:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$ObjSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=178;continue;}
case 178:{f.Locals[8]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[6]);f.Pc=182;continue;}
case 182:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$ObjSnap")?1:0));f.Pc=185;continue;}
case 185:{f.Pc=f.Pop().Int==0?368:188;continue;}
case 188:{f.Push(f.Locals[6]);f.Pc=190;continue;}
case 190:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$ObjSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=193;continue;}
case 193:{f.Locals[9]=f.Pop();f.Pc=195;continue;}
case 195:{f.Push(f.Locals[8]);f.Pc=197;continue;}
case 197:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","ci","Lforge/game/undo/GameMemento$ClassInfo;"));f.Pc=200;continue;}
case 200:{f.Push(f.Locals[9]);f.Pc=202;continue;}
case 202:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","ci","Lforge/game/undo/GameMemento$ClassInfo;"));f.Pc=205;continue;}
case 205:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?368:208;continue;}
case 208:{f.Push(JValue.I(0));f.Pc=209;continue;}
case 209:{f.Locals[14]=f.Pop();f.Pc=211;continue;}
case 211:{f.Push(JValue.I(0));f.Pc=212;continue;}
case 212:{f.Locals[15]=f.Pop();f.Pc=214;continue;}
case 214:{f.Push(JValue.I(0));f.Pc=215;continue;}
case 215:{f.Locals[16]=f.Pop();f.Pc=217;continue;}
case 217:{f.Push(f.Locals[16]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[8]);f.Pc=221;continue;}
case 221:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","ci","Lforge/game/undo/GameMemento$ClassInfo;"));f.Pc=224;continue;}
case 224:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","fields","[Ljava/lang/reflect/Field;"));f.Pc=227;continue;}
case 227:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=228;continue;}
case 228:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?365:231;continue;}
case 231:{f.Push(f.Locals[8]);f.Pc=233;continue;}
case 233:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","ci","Lforge/game/undo/GameMemento$ClassInfo;"));f.Pc=236;continue;}
case 236:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","stored","[Z"));f.Pc=239;continue;}
case 239:{f.Push(f.Locals[16]);f.Pc=241;continue;}
case 241:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=242;continue;}
case 242:{f.Pc=f.Pop().Int!=0?248:245;continue;}
case 245:{f.Pc=359;continue;}
case 248:{f.Push(f.Locals[8]);f.Pc=250;continue;}
case 250:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","ci","Lforge/game/undo/GameMemento$ClassInfo;"));f.Pc=253;continue;}
case 253:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","pk","[I"));f.Pc=256;continue;}
case 256:{f.Push(f.Locals[16]);f.Pc=258;continue;}
case 258:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=259;continue;}
case 259:{f.Pc=f.Pop().Int!=0?294:262;continue;}
case 262:{f.Push(f.Locals[8]);f.Pc=264;continue;}
case 264:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","refs","[Ljava/lang/Object;"));f.Pc=267;continue;}
case 267:{f.Push(f.Locals[14]);f.Pc=269;continue;}
case 269:{f.Locals[14]=JValue.I(unchecked(f.Locals[14].Int+(1)));f.Pc=272;continue;}
case 272:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=273;continue;}
case 273:{f.Push(f.Locals[9]);f.Pc=275;continue;}
case 275:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","refs","[Ljava/lang/Object;"));f.Pc=278;continue;}
case 278:{f.Push(f.Locals[14]);f.Pc=280;continue;}
case 280:{f.Push(JValue.I(1));f.Pc=281;continue;}
case 281:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=282;continue;}
case 282:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=283;continue;}
case 283:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?290:286;continue;}
case 286:{f.Push(JValue.I(1));f.Pc=287;continue;}
case 287:{f.Pc=324;continue;}
case 290:{f.Push(JValue.I(0));f.Pc=291;continue;}
case 291:{f.Pc=324;continue;}
case 294:{f.Push(f.Locals[8]);f.Pc=296;continue;}
case 296:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","prims","[J"));f.Pc=299;continue;}
case 299:{f.Push(f.Locals[15]);f.Pc=301;continue;}
case 301:{f.Locals[15]=JValue.I(unchecked(f.Locals[15].Int+(1)));f.Pc=304;continue;}
case 304:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=305;continue;}
case 305:{f.Push(f.Locals[9]);f.Pc=307;continue;}
case 307:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","prims","[J"));f.Pc=310;continue;}
case 310:{f.Push(f.Locals[15]);f.Pc=312;continue;}
case 312:{f.Push(JValue.I(1));f.Pc=313;continue;}
case 313:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=314;continue;}
case 314:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=315;continue;}
case 315:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=316;continue;}
case 316:{f.Pc=f.Pop().Int!=0?323:319;continue;}
case 319:{f.Push(JValue.I(1));f.Pc=320;continue;}
case 320:{f.Pc=324;continue;}
case 323:{f.Push(JValue.I(0));f.Pc=324;continue;}
case 324:{f.Locals[17]=f.Pop();f.Pc=326;continue;}
case 326:{f.Push(f.Locals[17]);f.Pc=328;continue;}
case 328:{f.Pc=f.Pop().Int!=0?359:331;continue;}
case 331:{f.Push(f.Locals[3]);f.Pc=332;continue;}
case 332:{f.Push(f.Locals[7]);f.Pc=334;continue;}
case 334:{f.Push(f.Locals[8]);f.Pc=336;continue;}
case 336:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","ci","Lforge/game/undo/GameMemento$ClassInfo;"));f.Pc=339;continue;}
case 339:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","fields","[Ljava/lang/reflect/Field;"));f.Pc=342;continue;}
case 342:{f.Push(f.Locals[16]);f.Pc=344;continue;}
case 344:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=345;continue;}
case 345:{return rt.Call(f,"java/lang/reflect/Field","getName","()Ljava/lang/String;","invokevirtual",348);}
case 348:{return rt.DynamicCall(f,"forge/game/undo/GameMemento:10904:348:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",353);}
case 353:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",358);}
case 358:{f.StackOp("pop");f.Pc=359;continue;}
case 359:{f.Locals[16]=JValue.I(unchecked(f.Locals[16].Int+(1)));f.Pc=362;continue;}
case 362:{f.Pc=217;continue;}
case 365:{f.Pc=514;continue;}
case 368:{f.Push(f.Locals[5]);f.Pc=370;continue;}
case 370:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$SeqSnap")?1:0));f.Pc=373;continue;}
case 373:{f.Pc=f.Pop().Int==0?437:376;continue;}
case 376:{f.Push(f.Locals[5]);f.Pc=378;continue;}
case 378:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$SeqSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=381;continue;}
case 381:{f.Locals[10]=f.Pop();f.Pc=383;continue;}
case 383:{f.Push(f.Locals[6]);f.Pc=385;continue;}
case 385:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$SeqSnap")?1:0));f.Pc=388;continue;}
case 388:{f.Pc=f.Pop().Int==0?437:391;continue;}
case 391:{f.Push(f.Locals[6]);f.Pc=393;continue;}
case 393:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$SeqSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=396;continue;}
case 396:{f.Locals[11]=f.Pop();f.Pc=398;continue;}
case 398:{f.Push(f.Locals[10]);f.Pc=400;continue;}
case 400:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=403;continue;}
case 403:{f.Push(f.Locals[11]);f.Pc=405;continue;}
case 405:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=408;continue;}
case 408:{f.Push(f.Locals[11]);f.Pc=410;continue;}
case 410:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=413;continue;}
case 413:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=414;continue;}
case 414:{return rt.Call(f,"forge/game/undo/GameMemento","sameItems","([Ljava/lang/Object;[Ljava/lang/Object;I)Z","invokestatic",417);}
case 417:{f.Pc=f.Pop().Int!=0?514:420;continue;}
case 420:{f.Push(f.Locals[3]);f.Pc=421;continue;}
case 421:{f.Push(f.Locals[7]);f.Pc=423;continue;}
case 423:{return rt.DynamicCall(f,"forge/game/undo/GameMemento:10904:423:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",428);}
case 428:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",433);}
case 433:{f.StackOp("pop");f.Pc=434;continue;}
case 434:{f.Pc=514;continue;}
case 437:{f.Push(f.Locals[5]);f.Pc=439;continue;}
case 439:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$PrimArrSnap")?1:0));f.Pc=442;continue;}
case 442:{f.Pc=f.Pop().Int==0?500:445;continue;}
case 445:{f.Push(f.Locals[5]);f.Pc=447;continue;}
case 447:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$PrimArrSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=450;continue;}
case 450:{f.Locals[12]=f.Pop();f.Pc=452;continue;}
case 452:{f.Push(f.Locals[6]);f.Pc=454;continue;}
case 454:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$PrimArrSnap")?1:0));f.Pc=457;continue;}
case 457:{f.Pc=f.Pop().Int==0?500:460;continue;}
case 460:{f.Push(f.Locals[6]);f.Pc=462;continue;}
case 462:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$PrimArrSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=465;continue;}
case 465:{f.Locals[13]=f.Pop();f.Pc=467;continue;}
case 467:{f.Push(f.Locals[12]);f.Pc=469;continue;}
case 469:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$PrimArrSnap","copy","Ljava/lang/Object;"));f.Pc=472;continue;}
case 472:{f.Push(f.Locals[13]);f.Pc=474;continue;}
case 474:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$PrimArrSnap","copy","Ljava/lang/Object;"));f.Pc=477;continue;}
case 477:{return rt.Call(f,"forge/game/undo/GameMemento","samePrimArray","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokestatic",480);}
case 480:{f.Pc=f.Pop().Int!=0?514:483;continue;}
case 483:{f.Push(f.Locals[3]);f.Pc=484;continue;}
case 484:{f.Push(f.Locals[7]);f.Pc=486;continue;}
case 486:{return rt.DynamicCall(f,"forge/game/undo/GameMemento:10904:486:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",491);}
case 491:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",496);}
case 496:{f.StackOp("pop");f.Pc=497;continue;}
case 497:{f.Pc=514;continue;}
case 500:{f.Push(f.Locals[3]);f.Pc=501;continue;}
case 501:{f.Push(f.Locals[7]);f.Pc=503;continue;}
case 503:{return rt.DynamicCall(f,"forge/game/undo/GameMemento:10904:503:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",508);}
case 508:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",513);}
case 513:{f.StackOp("pop");f.Pc=514;continue;}
case 514:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=517;continue;}
case 517:{f.Pc=83;continue;}
case 520:{f.Push(f.Locals[3]);f.Pc=521;continue;}
case 521:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10905(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","KINDS","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","KINDS","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$Kind"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Reference!=null?33:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/undo/GameMemento","computeKind","(Ljava/lang/Class;)Lforge/game/undo/GameMemento$Kind;","invokestatic",21);}
case 21:{f.Locals[1]=f.Pop();f.Pc=22;continue;}
case 22:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","KINDS","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","KINDS","Ljava/util/Map;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",32);}
case 32:{f.StackOp("pop");f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10906(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("java/lang/Enum")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/Class","isAssignableFrom","(Ljava/lang/Class;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?50:10;continue;}
case 10:{f.Push(JValue.R(rt.ClassObject("java/lang/CharSequence")));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/Class","isAssignableFrom","(Ljava/lang/Class;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int!=0?50:20;continue;}
case 20:{f.Push(JValue.R(rt.ClassObject("java/lang/Number")));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/Class","isAssignableFrom","(Ljava/lang/Class;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int!=0?50:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.ClassObject("java/lang/Boolean")));f.Pc=34;continue;}
case 34:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?50:37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.ClassObject("java/lang/Character")));f.Pc=41;continue;}
case 41:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?50:44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.ClassObject("java/lang/Class")));f.Pc=47;continue;}
case 47:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?54:50;continue;}
case 50:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento$Kind","LEAF","Lforge/game/undo/GameMemento$Kind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento$Kind","LEAF","Lforge/game/undo/GameMemento$Kind;"));f.Pc=53;continue;}
case 53:{return JStep.Return(f.Pop());}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/Class","isArray","()Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int==0?65:61;continue;}
case 61:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento$Kind","ARRAY","Lforge/game/undo/GameMemento$Kind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento$Kind","ARRAY","Lforge/game/undo/GameMemento$Kind;"));f.Pc=64;continue;}
case 64:{return JStep.Return(f.Pop());}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/Class","getName","()Ljava/lang/String;","invokevirtual",69);}
case 69:{f.Locals[1]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.ClassObject("java/util/Map")));f.Pc=72;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/lang/Class","isAssignableFrom","(Ljava/lang/Class;)Z","invokevirtual",76);}
case 76:{f.Locals[2]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.ClassObject("com/google/common/collect/Multimap")));f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/Class","isAssignableFrom","(Ljava/lang/Class;)Z","invokevirtual",84);}
case 84:{f.Locals[3]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.ClassObject("com/google/common/collect/Table")));f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/Class","isAssignableFrom","(Ljava/lang/Class;)Z","invokevirtual",92);}
case 92:{f.Locals[4]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.ClassObject("java/util/Collection")));f.Pc=96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/Class","isAssignableFrom","(Ljava/lang/Class;)Z","invokevirtual",100);}
case 100:{f.Locals[5]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[2]);f.Pc=103;continue;}
case 103:{f.Pc=f.Pop().Int!=0?120:106;continue;}
case 106:{f.Push(f.Locals[3]);f.Pc=107;continue;}
case 107:{f.Pc=f.Pop().Int!=0?120:110;continue;}
case 110:{f.Push(f.Locals[4]);f.Pc=112;continue;}
case 112:{f.Pc=f.Pop().Int!=0?120:115;continue;}
case 115:{f.Push(f.Locals[5]);f.Pc=117;continue;}
case 117:{f.Pc=f.Pop().Int==0?217:120;continue;}
case 120:{f.Push(f.Locals[1]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("Immutable")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",127);}
case 127:{f.Pc=f.Pop().Int!=0?140:130;continue;}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{f.Push(JValue.R(rt.String("Unmodifiable")));f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",137);}
case 137:{f.Pc=f.Pop().Int==0?144:140;continue;}
case 140:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento$Kind","LEAF","Lforge/game/undo/GameMemento$Kind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento$Kind","LEAF","Lforge/game/undo/GameMemento$Kind;"));f.Pc=143;continue;}
case 143:{return JStep.Return(f.Pop());}
case 144:{f.Push(f.Locals[1]);f.Pc=145;continue;}
case 145:{f.Push(JValue.R(rt.String("java.util.")));f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",151);}
case 151:{f.Pc=f.Pop().Int!=0?164:154;continue;}
case 154:{f.Push(f.Locals[1]);f.Pc=155;continue;}
case 155:{f.Push(JValue.R(rt.String("com.google.common.")));f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",161);}
case 161:{f.Pc=f.Pop().Int==0?188:164;continue;}
case 164:{f.Push(f.Locals[1]);f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String("$")));f.Pc=168;continue;}
case 168:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",171);}
case 171:{f.Pc=f.Pop().Int==0?188:174;continue;}
case 174:{f.Push(f.Locals[1]);f.Pc=175;continue;}
case 175:{f.Push(JValue.R(rt.String("Synchronized")));f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",181);}
case 181:{f.Pc=f.Pop().Int!=0?188:184;continue;}
case 184:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento$Kind","LEAF","Lforge/game/undo/GameMemento$Kind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento$Kind","LEAF","Lforge/game/undo/GameMemento$Kind;"));f.Pc=187;continue;}
case 187:{return JStep.Return(f.Pop());}
case 188:{f.Push(f.Locals[2]);f.Pc=189;continue;}
case 189:{f.Pc=f.Pop().Int==0?196:192;continue;}
case 192:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento$Kind","MAP","Lforge/game/undo/GameMemento$Kind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento$Kind","MAP","Lforge/game/undo/GameMemento$Kind;"));f.Pc=195;continue;}
case 195:{return JStep.Return(f.Pop());}
case 196:{f.Push(f.Locals[3]);f.Pc=197;continue;}
case 197:{f.Pc=f.Pop().Int==0?204:200;continue;}
case 200:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento$Kind","MULTIMAP","Lforge/game/undo/GameMemento$Kind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento$Kind","MULTIMAP","Lforge/game/undo/GameMemento$Kind;"));f.Pc=203;continue;}
case 203:{return JStep.Return(f.Pop());}
case 204:{f.Push(f.Locals[4]);f.Pc=206;continue;}
case 206:{f.Pc=f.Pop().Int==0?213:209;continue;}
case 209:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento$Kind","TABLE","Lforge/game/undo/GameMemento$Kind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento$Kind","TABLE","Lforge/game/undo/GameMemento$Kind;"));f.Pc=212;continue;}
case 212:{return JStep.Return(f.Pop());}
case 213:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento$Kind","COLLECTION","Lforge/game/undo/GameMemento$Kind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento$Kind","COLLECTION","Lforge/game/undo/GameMemento$Kind;"));f.Pc=216;continue;}
case 216:{return JStep.Return(f.Pop());}
case 217:{f.Push(f.Locals[0]);f.Pc=218;continue;}
case 218:{return rt.Call(f,"java/lang/Class","isAnonymousClass","()Z","invokevirtual",221);}
case 221:{f.Pc=f.Pop().Int!=0?241:224;continue;}
case 224:{f.Push(f.Locals[0]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/lang/Class","isSynthetic","()Z","invokevirtual",228);}
case 228:{f.Pc=f.Pop().Int!=0?241:231;continue;}
case 231:{f.Push(f.Locals[1]);f.Pc=232;continue;}
case 232:{f.Push(JValue.R(rt.String("$$")));f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",238);}
case 238:{f.Pc=f.Pop().Int==0?245:241;continue;}
case 241:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento$Kind","LEAF","Lforge/game/undo/GameMemento$Kind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento$Kind","LEAF","Lforge/game/undo/GameMemento$Kind;"));f.Pc=244;continue;}
case 244:{return JStep.Return(f.Pop());}
case 245:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","SKIP","[Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","SKIP","[Ljava/lang/String;"));f.Pc=248;continue;}
case 248:{f.Locals[6]=f.Pop();f.Pc=250;continue;}
case 250:{f.Push(f.Locals[6]);f.Pc=252;continue;}
case 252:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=253;continue;}
case 253:{f.Locals[7]=f.Pop();f.Pc=255;continue;}
case 255:{f.Push(JValue.I(0));f.Pc=256;continue;}
case 256:{f.Locals[8]=f.Pop();f.Pc=258;continue;}
case 258:{f.Push(f.Locals[8]);f.Pc=260;continue;}
case 260:{f.Push(f.Locals[7]);f.Pc=262;continue;}
case 262:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?291:265;continue;}
case 265:{f.Push(f.Locals[6]);f.Pc=267;continue;}
case 267:{f.Push(f.Locals[8]);f.Pc=269;continue;}
case 269:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=270;continue;}
case 270:{f.Locals[9]=f.Pop();f.Pc=272;continue;}
case 272:{f.Push(f.Locals[1]);f.Pc=273;continue;}
case 273:{f.Push(f.Locals[9]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",278);}
case 278:{f.Pc=f.Pop().Int==0?285:281;continue;}
case 281:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento$Kind","LEAF","Lforge/game/undo/GameMemento$Kind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento$Kind","LEAF","Lforge/game/undo/GameMemento$Kind;"));f.Pc=284;continue;}
case 284:{return JStep.Return(f.Pop());}
case 285:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=288;continue;}
case 288:{f.Pc=258;continue;}
case 291:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","WALK","[Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","WALK","[Ljava/lang/String;"));f.Pc=294;continue;}
case 294:{f.Locals[6]=f.Pop();f.Pc=296;continue;}
case 296:{f.Push(f.Locals[6]);f.Pc=298;continue;}
case 298:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=299;continue;}
case 299:{f.Locals[7]=f.Pop();f.Pc=301;continue;}
case 301:{f.Push(JValue.I(0));f.Pc=302;continue;}
case 302:{f.Locals[8]=f.Pop();f.Pc=304;continue;}
case 304:{f.Push(f.Locals[8]);f.Pc=306;continue;}
case 306:{f.Push(f.Locals[7]);f.Pc=308;continue;}
case 308:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?337:311;continue;}
case 311:{f.Push(f.Locals[6]);f.Pc=313;continue;}
case 313:{f.Push(f.Locals[8]);f.Pc=315;continue;}
case 315:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=316;continue;}
case 316:{f.Locals[9]=f.Pop();f.Pc=318;continue;}
case 318:{f.Push(f.Locals[1]);f.Pc=319;continue;}
case 319:{f.Push(f.Locals[9]);f.Pc=321;continue;}
case 321:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",324);}
case 324:{f.Pc=f.Pop().Int==0?331:327;continue;}
case 327:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento$Kind","OBJECT","Lforge/game/undo/GameMemento$Kind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento$Kind","OBJECT","Lforge/game/undo/GameMemento$Kind;"));f.Pc=330;continue;}
case 330:{return JStep.Return(f.Pop());}
case 331:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=334;continue;}
case 334:{f.Pc=304;continue;}
case 337:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento$Kind","LEAF","Lforge/game/undo/GameMemento$Kind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento$Kind","LEAF","Lforge/game/undo/GameMemento$Kind;"));f.Pc=340;continue;}
case 340:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10907(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","INFOS","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","INFOS","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$ClassInfo"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Reference!=null?37:17;continue;}
case 17:{if(!rt.EnsureInitialized(f,"forge/game/undo/GameMemento$ClassInfo"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/undo/GameMemento$ClassInfo")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/undo/GameMemento$ClassInfo","<init>","(Ljava/lang/Class;)V","invokespecial",25);}
case 25:{f.Locals[1]=f.Pop();f.Pc=26;continue;}
case 26:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","INFOS","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","INFOS","Ljava/util/Map;"));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",36);}
case 36:{f.StackOp("pop");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10908(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Class","isPrimitive","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"java/lang/Integer","TYPE","Ljava/lang/Class;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/Integer","TYPE","Ljava/lang/Class;"));f.Pc=13;continue;}
case 13:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?18:16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"java/lang/Long","TYPE","Ljava/lang/Class;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/Long","TYPE","Ljava/lang/Class;"));f.Pc=22;continue;}
case 22:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?27:25;continue;}
case 25:{f.Push(JValue.I(2));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{if(!rt.StaticReady(f,"java/lang/Boolean","TYPE","Ljava/lang/Class;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/Boolean","TYPE","Ljava/lang/Class;"));f.Pc=31;continue;}
case 31:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?36:34;continue;}
case 34:{f.Push(JValue.I(3));f.Pc=35;continue;}
case 35:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"java/lang/Double","TYPE","Ljava/lang/Class;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/Double","TYPE","Ljava/lang/Class;"));f.Pc=40;continue;}
case 40:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?45:43;continue;}
case 43:{f.Push(JValue.I(4));f.Pc=44;continue;}
case 44:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{if(!rt.StaticReady(f,"java/lang/Float","TYPE","Ljava/lang/Class;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/Float","TYPE","Ljava/lang/Class;"));f.Pc=49;continue;}
case 49:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?54:52;continue;}
case 52:{f.Push(JValue.I(5));f.Pc=53;continue;}
case 53:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{if(!rt.StaticReady(f,"java/lang/Byte","TYPE","Ljava/lang/Class;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/Byte","TYPE","Ljava/lang/Class;"));f.Pc=58;continue;}
case 58:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?64:61;continue;}
case 61:{f.Push(JValue.I(6));f.Pc=63;continue;}
case 63:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"java/lang/Short","TYPE","Ljava/lang/Class;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/Short","TYPE","Ljava/lang/Class;"));f.Pc=68;continue;}
case 68:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?74:71;continue;}
case 71:{f.Push(JValue.I(7));f.Pc=73;continue;}
case 73:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 74:{f.Push(JValue.I(8));f.Pc=76;continue;}
case 76:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10909(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{switch(f.Pop().Int){case 1:f.Pc=44;break;case 2:f.Pc=51;break;case 3:f.Pc=57;break;case 4:f.Pc=71;break;case 5:f.Pc=80;break;case 6:f.Pc=90;break;case 7:f.Pc=97;break;default:f.Pc=104;break;}continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/reflect/Field","getInt","(Ljava/lang/Object;)I","invokevirtual",49);}
case 49:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=50;continue;}
case 50:{return JStep.Return(f.Pop());}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/reflect/Field","getLong","(Ljava/lang/Object;)J","invokevirtual",56);}
case 56:{return JStep.Return(f.Pop());}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/reflect/Field","getBoolean","(Ljava/lang/Object;)Z","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int==0?69:65;continue;}
case 65:{f.Push(JValue.L(1));f.Pc=66;continue;}
case 66:{f.Pc=70;continue;}
case 69:{f.Push(JValue.L(0));f.Pc=70;continue;}
case 70:{return JStep.Return(f.Pop());}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[2]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/lang/reflect/Field","getDouble","(Ljava/lang/Object;)D","invokevirtual",76);}
case 76:{return rt.Call(f,"java/lang/Double","doubleToRawLongBits","(D)J","invokestatic",79);}
case 79:{return JStep.Return(f.Pop());}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/reflect/Field","getFloat","(Ljava/lang/Object;)F","invokevirtual",85);}
case 85:{return rt.Call(f,"java/lang/Float","floatToRawIntBits","(F)I","invokestatic",88);}
case 88:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=89;continue;}
case 89:{return JStep.Return(f.Pop());}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/reflect/Field","getByte","(Ljava/lang/Object;)B","invokevirtual",95);}
case 95:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=96;continue;}
case 96:{return JStep.Return(f.Pop());}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/lang/reflect/Field","getShort","(Ljava/lang/Object;)S","invokevirtual",102);}
case 102:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=103;continue;}
case 103:{return JStep.Return(f.Pop());}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[2]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/reflect/Field","getChar","(Ljava/lang/Object;)C","invokevirtual",109);}
case 109:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=110;continue;}
case 110:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10910(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{switch(f.Pop().Int){case 1:f.Pc=44;break;case 2:f.Pc=54;break;case 3:f.Pc=63;break;case 4:f.Pc=82;break;case 5:f.Pc=94;break;case 6:f.Pc=107;break;case 7:f.Pc=118;break;default:f.Pc=129;break;}continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/reflect/Field","setInt","(Ljava/lang/Object;I)V","invokevirtual",51);}
case 51:{f.Pc=137;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/reflect/Field","setLong","(Ljava/lang/Object;J)V","invokevirtual",60);}
case 60:{f.Pc=137;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{f.Push(JValue.L(0));f.Pc=67;continue;}
case 67:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=68;continue;}
case 68:{f.Pc=f.Pop().Int==0?75:71;continue;}
case 71:{f.Push(JValue.I(1));f.Pc=72;continue;}
case 72:{f.Pc=76;continue;}
case 75:{f.Push(JValue.I(0));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/reflect/Field","setBoolean","(Ljava/lang/Object;Z)V","invokevirtual",79);}
case 79:{f.Pc=137;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[3]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/Double","longBitsToDouble","(J)D","invokestatic",88);}
case 88:{return rt.Call(f,"java/lang/reflect/Field","setDouble","(Ljava/lang/Object;D)V","invokevirtual",91);}
case 91:{f.Pc=137;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[2]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[3]);f.Pc=97;continue;}
case 97:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/lang/Float","intBitsToFloat","(I)F","invokestatic",101);}
case 101:{return rt.Call(f,"java/lang/reflect/Field","setFloat","(Ljava/lang/Object;F)V","invokevirtual",104);}
case 104:{f.Pc=137;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[2]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[3]);f.Pc=110;continue;}
case 110:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=111;continue;}
case 111:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/lang/reflect/Field","setByte","(Ljava/lang/Object;B)V","invokevirtual",115);}
case 115:{f.Pc=137;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[2]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[3]);f.Pc=121;continue;}
case 121:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=122;continue;}
case 122:{f.Push(JNumbers.Unary("i2s",f.Pop()));f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/lang/reflect/Field","setShort","(Ljava/lang/Object;S)V","invokevirtual",126);}
case 126:{f.Pc=137;continue;}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[2]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[3]);f.Pc=132;continue;}
case 132:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=133;continue;}
case 133:{f.Push(JNumbers.Unary("i2c",f.Pop()));f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/lang/reflect/Field","setChar","(Ljava/lang/Object;C)V","invokevirtual",137);}
case 137:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10911(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",12);}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",18);}
case 18:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",24);}
case 24:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10912(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(3));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("forge.game.")));f.Pc=9;continue;}
case 9:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("forge.trackable.")));f.Pc=15;continue;}
case 15:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.I(2));f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("forge.card.CardType")));f.Pc=21;continue;}
case 21:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=22;continue;}
case 22:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","WALK","[Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/game/undo/GameMemento","WALK","[Ljava/lang/String;",f.Pop());f.Pc=25;continue;}
case 25:{f.Push(JValue.I(7));f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("forge.game.undo.")));f.Pc=35;continue;}
case 35:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("forge.game.event.")));f.Pc=41;continue;}
case 41:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.I(2));f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("forge.game.Match")));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(3));f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("forge.game.GameRules")));f.Pc=53;continue;}
case 53:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=54;continue;}
case 54:{f.StackOp("dup");f.Pc=55;continue;}
case 55:{f.Push(JValue.I(4));f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("forge.game.GameLog")));f.Pc=59;continue;}
case 59:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=60;continue;}
case 60:{f.StackOp("dup");f.Pc=61;continue;}
case 61:{f.Push(JValue.I(5));f.Pc=62;continue;}
case 62:{f.Push(JValue.R(rt.String("forge.game.player.PlayerController")));f.Pc=65;continue;}
case 65:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=66;continue;}
case 66:{f.StackOp("dup");f.Pc=67;continue;}
case 67:{f.Push(JValue.I(6));f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("forge.game.player.RegisteredPlayer")));f.Pc=72;continue;}
case 72:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=73;continue;}
case 73:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","SKIP","[Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/game/undo/GameMemento","SKIP","[Ljava/lang/String;",f.Pop());f.Pc=76;continue;}
case 76:{f.Push(JValue.I(0));f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=80;continue;}
case 80:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_OBJECTS","[Ljava/lang/Object;"))return JStep.Continue;rt.PutStatic("forge/game/undo/GameMemento","NO_OBJECTS","[Ljava/lang/Object;",f.Pop());f.Pc=83;continue;}
case 83:{f.Push(JValue.I(0));f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.NewArray("J",f.Pop().Int)));f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_LONGS","[J"))return JStep.Continue;rt.PutStatic("forge/game/undo/GameMemento","NO_LONGS","[J",f.Pop());f.Pc=89;continue;}
case 89:{f.Push(JValue.I(0));f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=92;continue;}
case 92:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_INTS","[I"))return JStep.Continue;rt.PutStatic("forge/game/undo/GameMemento","NO_INTS","[I",f.Pop());f.Pc=95;continue;}
case 95:{f.Push(JValue.I(0));f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.NewArray("Lforge/game/undo/GameMemento$Snap;",f.Pop().Int)));f.Pc=99;continue;}
case 99:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_SNAPS","[Lforge/game/undo/GameMemento$Snap;"))return JStep.Continue;rt.PutStatic("forge/game/undo/GameMemento","NO_SNAPS","[Lforge/game/undo/GameMemento$Snap;",f.Pop());f.Pc=102;continue;}
case 102:{f.Push(JValue.I(0));f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.NewArray("Lforge/game/undo/GameMemento$HistoryData;",f.Pop().Int)));f.Pc=106;continue;}
case 106:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_DELTAS","[Lforge/game/undo/GameMemento$HistoryData;"))return JStep.Continue;rt.PutStatic("forge/game/undo/GameMemento","NO_DELTAS","[Lforge/game/undo/GameMemento$HistoryData;",f.Pop());f.Pc=109;continue;}
case 109:{f.Push(JValue.I(0));f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.NewArray("Lforge/game/undo/GameMemento$Node;",f.Pop().Int)));f.Pc=113;continue;}
case 113:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_NODES","[Lforge/game/undo/GameMemento$Node;"))return JStep.Continue;rt.PutStatic("forge/game/undo/GameMemento","NO_NODES","[Lforge/game/undo/GameMemento$Node;",f.Pop());f.Pc=116;continue;}
case 116:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentHashMap")));f.Pc=119;continue;}
case 119:{f.StackOp("dup");f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","<init>","()V","invokespecial",123);}
case 123:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","KINDS","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/game/undo/GameMemento","KINDS","Ljava/util/Map;",f.Pop());f.Pc=126;continue;}
case 126:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentHashMap")));f.Pc=129;continue;}
case 129:{f.StackOp("dup");f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","<init>","()V","invokespecial",133);}
case 133:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","INFOS","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/game/undo/GameMemento","INFOS","Ljava/util/Map;",f.Pop());f.Pc=136;continue;}
case 136:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

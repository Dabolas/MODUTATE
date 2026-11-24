// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1034{
internal static JClass Build(){var c=new JClass("forge/game/undo/GameMemento$Recorder","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("registry","Ljava/util/IdentityHashMap;",false,JValue.Default("Ljava/util/IdentityHashMap;"),null));
c.Add(new JField("objs","[Lforge/game/undo/GameMemento$Node;",false,JValue.Default("[Lforge/game/undo/GameMemento$Node;"),null));
c.Add(new JField("conts","[Lforge/game/undo/GameMemento$Node;",false,JValue.Default("[Lforge/game/undo/GameMemento$Node;"),null));
c.Add(new JField("no","I",false,JValue.Default("I"),null));
c.Add(new JField("nc","I",false,JValue.Default("I"),null));
c.Add(new JField("work","[Lforge/game/undo/GameMemento$Node;",false,JValue.Default("[Lforge/game/undo/GameMemento$Node;"),null));
c.Add(new JField("wn","I",false,JValue.Default("I"),null));
c.Add(new JField("dn","[Lforge/game/undo/GameMemento$Node;",false,JValue.Default("[Lforge/game/undo/GameMemento$Node;"),null));
c.Add(new JField("ds","[Lforge/game/undo/GameMemento$HistoryData;",false,JValue.Default("[Lforge/game/undo/GameMemento$HistoryData;"),null));
c.Add(new JField("dc","I",false,JValue.Default("I"),null));
c.Add(new JField("deltaBytes","J",false,JValue.Default("J"),null));
c.Add(new JField("sRefs","[Ljava/lang/Object;",false,JValue.Default("[Ljava/lang/Object;"),null));
c.Add(new JField("sPrims","[J",false,JValue.Default("[J"),null));
c.Add(new JField("sn","I",false,JValue.Default("I"),null));
c.Add(new JField("highWater","I",false,JValue.Default("I"),null));
c.Add(new JField("gen","I",false,JValue.Default("I"),null));
c.Add(new JField("current","Lforge/game/undo/GameMemento;",false,JValue.Default("Lforge/game/undo/GameMemento;"),null));
c.Add(new JField("last","Lforge/game/undo/GameMemento;",false,JValue.Default("Lforge/game/undo/GameMemento;"),null));
c.Add(new JField("recording","Z",false,JValue.Default("Z"),null));
c.Add(new JField("liveBytes","J",false,JValue.Default("J"),null));
c.Add(new JField("lastCaptureBytes","J",false,JValue.Default("J"),null));
c.Add(new JField("lastRebaseCaptureBytes","J",false,JValue.Default("J"),null));
c.Add(new JField("lastFullCaptureBytes","J",false,JValue.Default("J"),null));
c.Add(new JField("debugBlindSpots","Z",false,JValue.Default("Z"),null));
c.Add(new JField("blindSpots","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("blindSeen","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("lastAllocated","I",false,JValue.Default("I"),null));
c.Add(new JField("lastReused","I",false,JValue.Default("I"),null));
c.Add(new JField("lastDeltaEntries","I",false,JValue.Default("I"),null));
c.Add(new JField("lastDeltaBytes","J",false,JValue.Default("J"),null));
c.Add(new JMethod(10933,"forge/game/undo/GameMemento$Recorder","<init>","()V",1,1,3,new JHandler[]{},M10933));
c.Add(new JMethod(10934,"forge/game/undo/GameMemento$Recorder","registrySize","()I",0,1,1,new JHandler[]{},M10934));
c.Add(new JMethod(10935,"forge/game/undo/GameMemento$Recorder","liveBytes","()J",1,1,2,new JHandler[]{},M10935));
c.Add(new JMethod(10936,"forge/game/undo/GameMemento$Recorder","lastCaptureBytes","()J",1,1,2,new JHandler[]{},M10936));
c.Add(new JMethod(10937,"forge/game/undo/GameMemento$Recorder","lastFullCaptureBytes","()J",1,1,2,new JHandler[]{},M10937));
c.Add(new JMethod(10938,"forge/game/undo/GameMemento$Recorder","lastRebaseCaptureBytes","()J",1,1,2,new JHandler[]{},M10938));
c.Add(new JMethod(10939,"forge/game/undo/GameMemento$Recorder","needsBaseline","()Z",1,1,1,new JHandler[]{},M10939));
c.Add(new JMethod(10940,"forge/game/undo/GameMemento$Recorder","lastDeltaEntries","()I",1,1,1,new JHandler[]{},M10940));
c.Add(new JMethod(10941,"forge/game/undo/GameMemento$Recorder","lastDeltaBytes","()J",1,1,2,new JHandler[]{},M10941));
c.Add(new JMethod(10942,"forge/game/undo/GameMemento$Recorder","isLatest","(Lforge/game/undo/GameMemento;)Z",1,2,2,new JHandler[]{},M10942));
c.Add(new JMethod(10943,"forge/game/undo/GameMemento$Recorder","checkDense","()Z",0,3,2,new JHandler[]{},M10943));
c.Add(new JMethod(10944,"forge/game/undo/GameMemento$Recorder","link","(Lforge/game/undo/GameMemento$Node;)V",2,2,5,new JHandler[]{},M10944));
c.Add(new JMethod(10945,"forge/game/undo/GameMemento$Recorder","unlink","(Lforge/game/undo/GameMemento$Node;)V",2,5,3,new JHandler[]{},M10945));
c.Add(new JMethod(10946,"forge/game/undo/GameMemento$Recorder","recomputeLiveBytes","()J",0,5,6,new JHandler[]{},M10946));
c.Add(new JMethod(10947,"forge/game/undo/GameMemento$Recorder","detach","()V",1,1,2,new JHandler[]{},M10947));
c.Add(new JMethod(10948,"forge/game/undo/GameMemento$Recorder","reset","()V",1,1,3,new JHandler[]{},M10948));
c.Add(new JMethod(10949,"forge/game/undo/GameMemento$Recorder","capture","(Ljava/lang/Object;)Lforge/game/undo/GameMemento;",1,2,3,new JHandler[]{},M10949));
c.Add(new JMethod(10950,"forge/game/undo/GameMemento$Recorder","captureStandalone","(Ljava/lang/Object;)Lforge/game/undo/GameMemento;",1,2,3,new JHandler[]{},M10950));
c.Add(new JMethod(10951,"forge/game/undo/GameMemento$Recorder","run","(Ljava/lang/Object;Z)Lforge/game/undo/GameMemento;",2,22,9,new JHandler[]{new JHandler(119,769,776,"java/lang/RuntimeException"),new JHandler(119,769,776,"java/lang/Error"),new JHandler(119,769,785,""),new JHandler(776,787,785,"")},M10951));
c.Add(new JMethod(10952,"forge/game/undo/GameMemento$Recorder","forget","(Lforge/game/undo/GameMemento$Node;)V",2,2,7,new JHandler[]{},M10952));
c.Add(new JMethod(10953,"forge/game/undo/GameMemento$Recorder","scratchBytes","()J",2,1,4,new JHandler[]{},M10953));
c.Add(new JMethod(10954,"forge/game/undo/GameMemento$Recorder","releaseScratch","()V",2,1,4,new JHandler[]{},M10954));
c.Add(new JMethod(10955,"forge/game/undo/GameMemento$Recorder","note","(Lforge/game/undo/GameMemento$Node;Lforge/game/undo/GameMemento$Snap;Lforge/game/undo/GameMemento$Snap;)J",2,5,7,new JHandler[]{},M10955));
c.Add(new JMethod(10956,"forge/game/undo/GameMemento$Recorder","restoreTo","(Lforge/game/undo/GameMemento;)Z",1,9,3,new JHandler[]{new JHandler(90,114,117,"java/lang/RuntimeException"),new JHandler(90,114,117,"java/lang/OutOfMemoryError")},M10956));
c.Add(new JMethod(10957,"forge/game/undo/GameMemento$Recorder","rewind","(Lforge/game/undo/GameMemento;)V",2,10,7,new JHandler[]{},M10957));
c.Add(new JMethod(10958,"forge/game/undo/GameMemento$Recorder","enqueue","(Ljava/lang/Object;)V",2,3,5,new JHandler[]{},M10958));
c.Add(new JMethod(10959,"forge/game/undo/GameMemento$Recorder","snapshot","(Lforge/game/undo/GameMemento$Node;)Lforge/game/undo/GameMemento$Snap;",2,4,3,new JHandler[]{},M10959));
c.Add(new JMethod(10960,"forge/game/undo/GameMemento$Recorder","putSeq","(Ljava/lang/Object;)V",2,2,5,new JHandler[]{},M10960));
c.Add(new JMethod(10961,"forge/game/undo/GameMemento$Recorder","snapSequence","(Lforge/game/undo/GameMemento$Node;Lforge/game/undo/GameMemento$Kind;)Lforge/game/undo/GameMemento$Snap;",2,8,4,new JHandler[]{},M10961));
c.Add(new JMethod(10962,"forge/game/undo/GameMemento$Recorder","snapPrimArray","(Lforge/game/undo/GameMemento$Node;)Lforge/game/undo/GameMemento$Snap;",2,5,5,new JHandler[]{},M10962));
c.Add(new JMethod(10963,"forge/game/undo/GameMemento$Recorder","snapObject","(Lforge/game/undo/GameMemento$Node;)Lforge/game/undo/GameMemento$Snap;",2,12,6,new JHandler[]{new JHandler(123,134,137,"java/lang/IllegalAccessException"),new JHandler(236,254,257,"java/lang/IllegalAccessException")},M10963));
c.Add(new JMethod(10964,"forge/game/undo/GameMemento$Recorder","samePrims","([J[JI)Z",10,4,4,new JHandler[]{},M10964));
c.Add(new JMethod(10965,"forge/game/undo/GameMemento$Recorder","noteBlind","(Ljava/lang/reflect/Field;Ljava/lang/Object;)V",2,3,4,new JHandler[]{},M10965));
}

internal static JStep M10933(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/IdentityHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/IdentityHashMap")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/IdentityHashMap","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","registry","Ljava/util/IdentityHashMap;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(1024));f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.NewArray("Lforge/game/undo/GameMemento$Node;",f.Pop().Int)));f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","objs","[Lforge/game/undo/GameMemento$Node;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(JValue.I(1024));f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.NewArray("Lforge/game/undo/GameMemento$Node;",f.Pop().Int)));f.Pc=32;continue;}
case 32:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","conts","[Lforge/game/undo/GameMemento$Node;",value);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(JValue.I(1024));f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.NewArray("Lforge/game/undo/GameMemento$Node;",f.Pop().Int)));f.Pc=42;continue;}
case 42:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","work","[Lforge/game/undo/GameMemento$Node;",value);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(JValue.I(1024));f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.NewArray("Lforge/game/undo/GameMemento$Node;",f.Pop().Int)));f.Pc=52;continue;}
case 52:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dn","[Lforge/game/undo/GameMemento$Node;",value);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(JValue.I(1024));f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.NewArray("Lforge/game/undo/GameMemento$HistoryData;",f.Pop().Int)));f.Pc=62;continue;}
case 62:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","ds","[Lforge/game/undo/GameMemento$HistoryData;",value);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(JValue.I(256));f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=72;continue;}
case 72:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sRefs","[Ljava/lang/Object;",value);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.Push(JValue.I(64));f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.NewArray("J",f.Pop().Int)));f.Pc=80;continue;}
case 80:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sPrims","[J",value);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{if(!rt.EnsureInitialized(f,"java/util/TreeSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeSet")));f.Pc=87;continue;}
case 87:{f.StackOp("dup");f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/TreeSet","<init>","()V","invokespecial",91);}
case 91:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","blindSpots","Ljava/util/Set;",value);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{if(!rt.EnsureInitialized(f,"java/util/IdentityHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/IdentityHashMap")));f.Pc=98;continue;}
case 98:{f.StackOp("dup");f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/IdentityHashMap","<init>","()V","invokespecial",102);}
case 102:{return rt.Call(f,"java/util/Collections","newSetFromMap","(Ljava/util/Map;)Ljava/util/Set;","invokestatic",105);}
case 105:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","blindSeen","Ljava/util/Set;",value);f.Pc=108;continue;}
case 108:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10934(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","registry","Ljava/util/IdentityHashMap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/IdentityHashMap","size","()I","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10935(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","liveBytes","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10936(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastCaptureBytes","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10937(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastFullCaptureBytes","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10938(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastRebaseCaptureBytes","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10939(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","last","Lforge/game/undo/GameMemento;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10940(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastDeltaEntries","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10941(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastDeltaBytes","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10942(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?24:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","last","Lforge/game/undo/GameMemento;"));f.Pc=9;continue;}
case 9:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?24:12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","owner","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10943(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","no","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","nc","I"));f.Pc=8;continue;}
case 8:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","registry","Ljava/util/IdentityHashMap;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/IdentityHashMap","size","()I","invokevirtual",16);}
case 16:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?21:19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{f.Locals[1]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","no","I"));f.Pc=28;continue;}
case 28:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?80:31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","objs","[Lforge/game/undo/GameMemento$Node;"));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=37;continue;}
case 37:{f.Locals[2]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Pc=f.Pop().Reference==null?72:42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","isObj","Z"));f.Pc=46;continue;}
case 46:{f.Pc=f.Pop().Int==0?72:49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","idx","I"));f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?72:57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","registry","Ljava/util/IdentityHashMap;"));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","obj","Ljava/lang/Object;"));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/IdentityHashMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",68);}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?74:72;continue;}
case 72:{f.Push(JValue.I(0));f.Pc=73;continue;}
case 73:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 74:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(1)));f.Pc=77;continue;}
case 77:{f.Pc=23;continue;}
case 80:{f.Push(JValue.I(0));f.Pc=81;continue;}
case 81:{f.Locals[1]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","nc","I"));f.Pc=87;continue;}
case 87:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?139:90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","conts","[Lforge/game/undo/GameMemento$Node;"));f.Pc=94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=96;continue;}
case 96:{f.Locals[2]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[2]);f.Pc=98;continue;}
case 98:{f.Pc=f.Pop().Reference==null?131:101;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","isObj","Z"));f.Pc=105;continue;}
case 105:{f.Pc=f.Pop().Int!=0?131:108;continue;}
case 108:{f.Push(f.Locals[2]);f.Pc=109;continue;}
case 109:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","idx","I"));f.Pc=112;continue;}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?131:116;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","registry","Ljava/util/IdentityHashMap;"));f.Pc=120;continue;}
case 120:{f.Push(f.Locals[2]);f.Pc=121;continue;}
case 121:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","obj","Ljava/lang/Object;"));f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/IdentityHashMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",127);}
case 127:{f.Push(f.Locals[2]);f.Pc=128;continue;}
case 128:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?133:131;continue;}
case 131:{f.Push(JValue.I(0));f.Pc=132;continue;}
case 132:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 133:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(1)));f.Pc=136;continue;}
case 136:{f.Pc=82;continue;}
case 139:{f.Push(f.Locals[0]);f.Pc=140;continue;}
case 140:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","no","I"));f.Pc=143;continue;}
case 143:{f.Locals[1]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[1]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[0]);f.Pc=146;continue;}
case 146:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","objs","[Lforge/game/undo/GameMemento$Node;"));f.Pc=149;continue;}
case 149:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=150;continue;}
case 150:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?170:153;continue;}
case 153:{f.Push(f.Locals[0]);f.Pc=154;continue;}
case 154:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","objs","[Lforge/game/undo/GameMemento$Node;"));f.Pc=157;continue;}
case 157:{f.Push(f.Locals[1]);f.Pc=158;continue;}
case 158:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=159;continue;}
case 159:{f.Pc=f.Pop().Reference==null?164:162;continue;}
case 162:{f.Push(JValue.I(0));f.Pc=163;continue;}
case 163:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 164:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(1)));f.Pc=167;continue;}
case 167:{f.Pc=144;continue;}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","nc","I"));f.Pc=174;continue;}
case 174:{f.Locals[1]=f.Pop();f.Pc=175;continue;}
case 175:{f.Push(f.Locals[1]);f.Pc=176;continue;}
case 176:{f.Push(f.Locals[0]);f.Pc=177;continue;}
case 177:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","conts","[Lforge/game/undo/GameMemento$Node;"));f.Pc=180;continue;}
case 180:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=181;continue;}
case 181:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?201:184;continue;}
case 184:{f.Push(f.Locals[0]);f.Pc=185;continue;}
case 185:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","conts","[Lforge/game/undo/GameMemento$Node;"));f.Pc=188;continue;}
case 188:{f.Push(f.Locals[1]);f.Pc=189;continue;}
case 189:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=190;continue;}
case 190:{f.Pc=f.Pop().Reference==null?195:193;continue;}
case 193:{f.Push(JValue.I(0));f.Pc=194;continue;}
case 194:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 195:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(1)));f.Pc=198;continue;}
case 198:{f.Pc=175;continue;}
case 201:{f.Push(JValue.I(1));f.Pc=202;continue;}
case 202:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10944(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","isObj","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?67:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","no","I"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","objs","[Lforge/game/undo/GameMemento$Node;"));f.Pc=15;continue;}
case 15:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=16;continue;}
case 16:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?39:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","objs","[Lforge/game/undo/GameMemento$Node;"));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","no","I"));f.Pc=28;continue;}
case 28:{f.Push(JValue.I(2));f.Pc=29;continue;}
case 29:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Arrays","copyOf","([Ljava/lang/Object;I)[Ljava/lang/Object;","invokestatic",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/undo/GameMemento$Node;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","objs","[Lforge/game/undo/GameMemento$Node;",value);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","no","I"));f.Pc=44;continue;}
case 44:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Node","idx","I",value);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","objs","[Lforge/game/undo/GameMemento$Node;"));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.StackOp("dup");f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","no","I"));f.Pc=56;continue;}
case 56:{f.StackOp("dup_x1");f.Pc=57;continue;}
case 57:{f.Push(JValue.I(1));f.Pc=58;continue;}
case 58:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=59;continue;}
case 59:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","no","I",value);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=64;continue;}
case 64:{f.Pc=124;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","nc","I"));f.Pc=71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","conts","[Lforge/game/undo/GameMemento$Node;"));f.Pc=75;continue;}
case 75:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=76;continue;}
case 76:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?99:79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","conts","[Lforge/game/undo/GameMemento$Node;"));f.Pc=84;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","nc","I"));f.Pc=88;continue;}
case 88:{f.Push(JValue.I(2));f.Pc=89;continue;}
case 89:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/util/Arrays","copyOf","([Ljava/lang/Object;I)[Ljava/lang/Object;","invokestatic",93);}
case 93:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/undo/GameMemento$Node;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=96;continue;}
case 96:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","conts","[Lforge/game/undo/GameMemento$Node;",value);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","nc","I"));f.Pc=104;continue;}
case 104:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Node","idx","I",value);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","conts","[Lforge/game/undo/GameMemento$Node;"));f.Pc=111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.StackOp("dup");f.Pc=113;continue;}
case 113:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","nc","I"));f.Pc=116;continue;}
case 116:{f.StackOp("dup_x1");f.Pc=117;continue;}
case 117:{f.Push(JValue.I(1));f.Pc=118;continue;}
case 118:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=119;continue;}
case 119:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","nc","I",value);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=124;continue;}
case 124:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10945(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","isObj","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?14:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","objs","[Lforge/game/undo/GameMemento$Node;"));f.Pc=11;continue;}
case 11:{f.Pc=18;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","conts","[Lforge/game/undo/GameMemento$Node;"));f.Pc=18;continue;}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","isObj","Z"));f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Int==0?40:26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.StackOp("dup");f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","no","I"));f.Pc=31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=33;continue;}
case 33:{f.StackOp("dup_x1");f.Pc=34;continue;}
case 34:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","no","I",value);f.Pc=37;continue;}
case 37:{f.Pc=51;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","nc","I"));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=47;continue;}
case 47:{f.StackOp("dup_x1");f.Pc=48;continue;}
case 48:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","nc","I",value);f.Pc=51;continue;}
case 51:{f.Locals[3]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=55;continue;}
case 55:{f.Locals[4]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(null));f.Pc=60;continue;}
case 60:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[4]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?84:67;continue;}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","idx","I"));f.Pc=72;continue;}
case 72:{f.Push(f.Locals[4]);f.Pc=74;continue;}
case 74:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","idx","I"));f.Pc=81;continue;}
case 81:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Node","idx","I",value);f.Pc=84;continue;}
case 84:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10946(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.L(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","registry","Ljava/util/IdentityHashMap;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/IdentityHashMap","values","()Ljava/util/Collection;","invokevirtual",9);}
case 9:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?53:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$Node"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(JValue.L(64L));f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","snap","Lforge/game/undo/GameMemento$Snap;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/undo/GameMemento$Snap","bytes","()J","invokevirtual",47);}
case 47:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=48;continue;}
case 48:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=49;continue;}
case 49:{f.Locals[1]=f.Pop();f.Pc=50;continue;}
case 50:{f.Pc=15;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10947(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","last","Lforge/game/undo/GameMemento;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10948(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.EnsureInitialized(f,"java/util/IdentityHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/IdentityHashMap")));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/IdentityHashMap","<init>","()V","invokespecial",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","registry","Ljava/util/IdentityHashMap;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1024));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.NewArray("Lforge/game/undo/GameMemento$Node;",f.Pop().Int)));f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","objs","[Lforge/game/undo/GameMemento$Node;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(JValue.I(1024));f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.NewArray("Lforge/game/undo/GameMemento$Node;",f.Pop().Int)));f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","conts","[Lforge/game/undo/GameMemento$Node;",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","no","I",value);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","nc","I",value);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(1024));f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.NewArray("Lforge/game/undo/GameMemento$Node;",f.Pop().Int)));f.Pc=48;continue;}
case 48:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","work","[Lforge/game/undo/GameMemento$Node;",value);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(JValue.I(0));f.Pc=53;continue;}
case 53:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","wn","I",value);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(JValue.I(1024));f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.NewArray("Lforge/game/undo/GameMemento$Node;",f.Pop().Int)));f.Pc=63;continue;}
case 63:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dn","[Lforge/game/undo/GameMemento$Node;",value);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(JValue.I(1024));f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.NewArray("Lforge/game/undo/GameMemento$HistoryData;",f.Pop().Int)));f.Pc=73;continue;}
case 73:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","ds","[Lforge/game/undo/GameMemento$HistoryData;",value);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dc","I",value);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(JValue.L(0));f.Pc=83;continue;}
case 83:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","deltaBytes","J",value);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{f.Push(JValue.I(256));f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=93;continue;}
case 93:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sRefs","[Ljava/lang/Object;",value);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(JValue.I(64));f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.NewArray("J",f.Pop().Int)));f.Pc=101;continue;}
case 101:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sPrims","[J",value);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(JValue.I(0));f.Pc=106;continue;}
case 106:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sn","I",value);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{f.Push(JValue.I(0));f.Pc=111;continue;}
case 111:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","highWater","I",value);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(JValue.L(0));f.Pc=116;continue;}
case 116:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","liveBytes","J",value);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{f.Push(JValue.I(0));f.Pc=121;continue;}
case 121:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastDeltaEntries","I",value);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(JValue.L(0));f.Pc=126;continue;}
case 126:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastDeltaBytes","J",value);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(JValue.R(null));f.Pc=131;continue;}
case 131:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","last","Lforge/game/undo/GameMemento;",value);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[0]);f.Pc=135;continue;}
case 135:{f.Push(JValue.R(null));f.Pc=136;continue;}
case 136:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","current","Lforge/game/undo/GameMemento;",value);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[0]);f.Pc=140;continue;}
case 140:{f.Push(JValue.I(0));f.Pc=141;continue;}
case 141:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","recording","Z",value);f.Pc=144;continue;}
case 144:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10949(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(1));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","run","(Ljava/lang/Object;Z)Lforge/game/undo/GameMemento;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10950(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","run","(Ljava/lang/Object;Z)Lforge/game/undo/GameMemento;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10951(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","registry","Ljava/util/IdentityHashMap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/IdentityHashMap","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?14:10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Pc=15;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","scratchBytes","()J","invokevirtual",20);}
case 20:{f.Locals[4]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","gen","I"));f.Pc=27;continue;}
case 27:{f.Push(JValue.I(1));f.Pc=28;continue;}
case 28:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=29;continue;}
case 29:{f.StackOp("dup_x1");f.Pc=30;continue;}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","gen","I",value);f.Pc=33;continue;}
case 33:{f.Locals[6]=f.Pop();f.Pc=35;continue;}
case 35:{if(!rt.EnsureInitialized(f,"forge/game/undo/GameMemento"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/undo/GameMemento")));f.Pc=38;continue;}
case 38:{f.StackOp("dup");f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/undo/GameMemento","<init>","()V","invokespecial",42);}
case 42:{f.Locals[7]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[7]);f.Pc=47;continue;}
case 47:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","current","Lforge/game/undo/GameMemento;",value);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastAllocated","I",value);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastReused","I",value);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastDeltaEntries","I",value);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(JValue.L(0));f.Pc=67;continue;}
case 67:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastDeltaBytes","J",value);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{f.Pc=f.Pop().Int==0?81:74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","last","Lforge/game/undo/GameMemento;"));f.Pc=78;continue;}
case 78:{f.Pc=82;continue;}
case 81:{f.Push(JValue.R(null));f.Pc=82;continue;}
case 82:{f.Locals[8]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[8]);f.Pc=87;continue;}
case 87:{f.Pc=f.Pop().Reference==null?94:90;continue;}
case 90:{f.Push(JValue.I(1));f.Pc=91;continue;}
case 91:{f.Pc=95;continue;}
case 94:{f.Push(JValue.I(0));f.Pc=95;continue;}
case 95:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","recording","Z",value);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{f.Push(JValue.I(0));f.Pc=100;continue;}
case 100:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dc","I",value);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(JValue.L(0));f.Pc=105;continue;}
case 105:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","deltaBytes","J",value);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{f.Push(JValue.I(0));f.Pc=110;continue;}
case 110:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","wn","I",value);f.Pc=113;continue;}
case 113:{f.Push(JValue.L(0));f.Pc=114;continue;}
case 114:{f.Locals[9]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(JValue.L(0));f.Pc=117;continue;}
case 117:{f.Locals[11]=f.Pop();f.Pc=119;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[1]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","enqueue","(Ljava/lang/Object;)V","invokevirtual",124);}
case 124:{f.Push(JValue.I(0));f.Pc=125;continue;}
case 125:{f.Locals[13]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[13]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","wn","I"));f.Pc=133;continue;}
case 133:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?262:136;continue;}
case 136:{f.Push(f.Locals[0]);f.Pc=137;continue;}
case 137:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","work","[Lforge/game/undo/GameMemento$Node;"));f.Pc=140;continue;}
case 140:{f.Push(f.Locals[13]);f.Pc=142;continue;}
case 142:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=143;continue;}
case 143:{f.Locals[14]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(f.Locals[14]);f.Pc=147;continue;}
case 147:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","snap","Lforge/game/undo/GameMemento$Snap;"));f.Pc=150;continue;}
case 150:{f.Locals[15]=f.Pop();f.Pc=152;continue;}
case 152:{f.Push(f.Locals[0]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[14]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","snapshot","(Lforge/game/undo/GameMemento$Node;)Lforge/game/undo/GameMemento$Snap;","invokevirtual",158);}
case 158:{f.Locals[16]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(f.Locals[16]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[15]);f.Pc=164;continue;}
case 164:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?256:167;continue;}
case 167:{f.Push(f.Locals[14]);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[16]);f.Pc=171;continue;}
case 171:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Node","snap","Lforge/game/undo/GameMemento$Snap;",value);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[0]);f.Pc=175;continue;}
case 175:{f.StackOp("dup");f.Pc=176;continue;}
case 176:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","liveBytes","J"));f.Pc=179;continue;}
case 179:{f.Push(f.Locals[15]);f.Pc=181;continue;}
case 181:{f.Pc=f.Pop().Reference!=null?196:184;continue;}
case 184:{f.Push(JValue.L(64L));f.Pc=187;continue;}
case 187:{f.Push(f.Locals[16]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/undo/GameMemento$Snap","bytes","()J","invokevirtual",192);}
case 192:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=193;continue;}
case 193:{f.Pc=207;continue;}
case 196:{f.Push(f.Locals[16]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/undo/GameMemento$Snap","bytes","()J","invokevirtual",201);}
case 201:{f.Push(f.Locals[15]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/undo/GameMemento$Snap","bytes","()J","invokevirtual",206);}
case 206:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=207;continue;}
case 207:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=208;continue;}
case 208:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","liveBytes","J",value);f.Pc=211;continue;}
case 211:{f.Push(f.Locals[9]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[16]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/undo/GameMemento$Snap","bytes","()J","invokevirtual",218);}
case 218:{f.Push(f.Locals[15]);f.Pc=220;continue;}
case 220:{f.Pc=f.Pop().Reference!=null?229:223;continue;}
case 223:{f.Push(JValue.L(64L));f.Pc=226;continue;}
case 226:{f.Pc=230;continue;}
case 229:{f.Push(JValue.L(0));f.Pc=230;continue;}
case 230:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=231;continue;}
case 231:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=232;continue;}
case 232:{f.Locals[9]=f.Pop();f.Pc=234;continue;}
case 234:{f.Push(f.Locals[0]);f.Pc=235;continue;}
case 235:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","recording","Z"));f.Pc=238;continue;}
case 238:{f.Pc=f.Pop().Int==0?256:241;continue;}
case 241:{f.Push(f.Locals[11]);f.Pc=243;continue;}
case 243:{f.Push(f.Locals[0]);f.Pc=244;continue;}
case 244:{f.Push(f.Locals[14]);f.Pc=246;continue;}
case 246:{f.Push(f.Locals[15]);f.Pc=248;continue;}
case 248:{f.Push(f.Locals[16]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","note","(Lforge/game/undo/GameMemento$Node;Lforge/game/undo/GameMemento$Snap;Lforge/game/undo/GameMemento$Snap;)J","invokevirtual",253);}
case 253:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=254;continue;}
case 254:{f.Locals[11]=f.Pop();f.Pc=256;continue;}
case 256:{f.Locals[13]=JValue.I(unchecked(f.Locals[13].Int+(1)));f.Pc=259;continue;}
case 259:{f.Pc=127;continue;}
case 262:{f.Push(f.Locals[0]);f.Pc=263;continue;}
case 263:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","no","I"));f.Pc=266;continue;}
case 266:{f.Push(JValue.I(1));f.Pc=267;continue;}
case 267:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=268;continue;}
case 268:{f.Locals[13]=f.Pop();f.Pc=270;continue;}
case 270:{f.Push(f.Locals[13]);f.Pc=272;continue;}
case 272:{f.Pc=f.Pop().Int<0?307:275;continue;}
case 275:{f.Push(f.Locals[0]);f.Pc=276;continue;}
case 276:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","objs","[Lforge/game/undo/GameMemento$Node;"));f.Pc=279;continue;}
case 279:{f.Push(f.Locals[13]);f.Pc=281;continue;}
case 281:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=282;continue;}
case 282:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","gen","I"));f.Pc=285;continue;}
case 285:{f.Push(f.Locals[6]);f.Pc=287;continue;}
case 287:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?301:290;continue;}
case 290:{f.Push(f.Locals[0]);f.Pc=291;continue;}
case 291:{f.Push(f.Locals[0]);f.Pc=292;continue;}
case 292:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","objs","[Lforge/game/undo/GameMemento$Node;"));f.Pc=295;continue;}
case 295:{f.Push(f.Locals[13]);f.Pc=297;continue;}
case 297:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","forget","(Lforge/game/undo/GameMemento$Node;)V","invokevirtual",301);}
case 301:{f.Locals[13]=JValue.I(unchecked(f.Locals[13].Int+(-1)));f.Pc=304;continue;}
case 304:{f.Pc=270;continue;}
case 307:{f.Push(f.Locals[0]);f.Pc=308;continue;}
case 308:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","nc","I"));f.Pc=311;continue;}
case 311:{f.Push(JValue.I(1));f.Pc=312;continue;}
case 312:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=313;continue;}
case 313:{f.Locals[13]=f.Pop();f.Pc=315;continue;}
case 315:{f.Push(f.Locals[13]);f.Pc=317;continue;}
case 317:{f.Pc=f.Pop().Int<0?352:320;continue;}
case 320:{f.Push(f.Locals[0]);f.Pc=321;continue;}
case 321:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","conts","[Lforge/game/undo/GameMemento$Node;"));f.Pc=324;continue;}
case 324:{f.Push(f.Locals[13]);f.Pc=326;continue;}
case 326:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=327;continue;}
case 327:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","gen","I"));f.Pc=330;continue;}
case 330:{f.Push(f.Locals[6]);f.Pc=332;continue;}
case 332:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?346:335;continue;}
case 335:{f.Push(f.Locals[0]);f.Pc=336;continue;}
case 336:{f.Push(f.Locals[0]);f.Pc=337;continue;}
case 337:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","conts","[Lforge/game/undo/GameMemento$Node;"));f.Pc=340;continue;}
case 340:{f.Push(f.Locals[13]);f.Pc=342;continue;}
case 342:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=343;continue;}
case 343:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","forget","(Lforge/game/undo/GameMemento$Node;)V","invokevirtual",346);}
case 346:{f.Locals[13]=JValue.I(unchecked(f.Locals[13].Int+(-1)));f.Pc=349;continue;}
case 349:{f.Pc=315;continue;}
case 352:{f.Push(f.Locals[2]);f.Pc=353;continue;}
case 353:{f.Pc=f.Pop().Int==0?654:356;continue;}
case 356:{f.Push(f.Locals[0]);f.Pc=357;continue;}
case 357:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dc","I"));f.Pc=360;continue;}
case 360:{f.Pc=f.Pop().Int!=0?369:363;continue;}
case 363:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_NODES","[Lforge/game/undo/GameMemento$Node;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","NO_NODES","[Lforge/game/undo/GameMemento$Node;"));f.Pc=366;continue;}
case 366:{f.Pc=383;continue;}
case 369:{f.Push(f.Locals[0]);f.Pc=370;continue;}
case 370:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dn","[Lforge/game/undo/GameMemento$Node;"));f.Pc=373;continue;}
case 373:{f.Push(f.Locals[0]);f.Pc=374;continue;}
case 374:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dc","I"));f.Pc=377;continue;}
case 377:{return rt.Call(f,"java/util/Arrays","copyOf","([Ljava/lang/Object;I)[Ljava/lang/Object;","invokestatic",380);}
case 380:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/undo/GameMemento$Node;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=383;continue;}
case 383:{f.Locals[13]=f.Pop();f.Pc=385;continue;}
case 385:{f.Push(f.Locals[0]);f.Pc=386;continue;}
case 386:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dc","I"));f.Pc=389;continue;}
case 389:{f.Pc=f.Pop().Int!=0?398:392;continue;}
case 392:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_DELTAS","[Lforge/game/undo/GameMemento$HistoryData;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","NO_DELTAS","[Lforge/game/undo/GameMemento$HistoryData;"));f.Pc=395;continue;}
case 395:{f.Pc=412;continue;}
case 398:{f.Push(f.Locals[0]);f.Pc=399;continue;}
case 399:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","ds","[Lforge/game/undo/GameMemento$HistoryData;"));f.Pc=402;continue;}
case 402:{f.Push(f.Locals[0]);f.Pc=403;continue;}
case 403:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dc","I"));f.Pc=406;continue;}
case 406:{return rt.Call(f,"java/util/Arrays","copyOf","([Ljava/lang/Object;I)[Ljava/lang/Object;","invokestatic",409);}
case 409:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/undo/GameMemento$HistoryData;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=412;continue;}
case 412:{f.Locals[14]=f.Pop();f.Pc=414;continue;}
case 414:{f.Push(f.Locals[7]);f.Pc=416;continue;}
case 416:{f.Push(f.Locals[0]);f.Pc=417;continue;}
case 417:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento","owner","Lforge/game/undo/GameMemento$Recorder;",value);f.Pc=420;continue;}
case 420:{f.Push(f.Locals[7]);f.Pc=422;continue;}
case 422:{f.Push(f.Locals[0]);f.Pc=423;continue;}
case 423:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","wn","I"));f.Pc=426;continue;}
case 426:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento","size","I",value);f.Pc=429;continue;}
case 429:{f.Push(f.Locals[8]);f.Pc=431;continue;}
case 431:{f.Pc=f.Pop().Reference==null?464:434;continue;}
case 434:{f.Push(f.Locals[8]);f.Pc=436;continue;}
case 436:{f.Push(f.Locals[13]);f.Pc=438;continue;}
case 438:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento","undoNodes","[Lforge/game/undo/GameMemento$Node;",value);f.Pc=441;continue;}
case 441:{f.Push(f.Locals[8]);f.Pc=443;continue;}
case 443:{f.Push(f.Locals[14]);f.Pc=445;continue;}
case 445:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento","undoDeltas","[Lforge/game/undo/GameMemento$HistoryData;",value);f.Pc=448;continue;}
case 448:{f.Push(f.Locals[8]);f.Pc=450;continue;}
case 450:{f.Push(f.Locals[0]);f.Pc=451;continue;}
case 451:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","deltaBytes","J"));f.Pc=454;continue;}
case 454:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento","undoBytes","J",value);f.Pc=457;continue;}
case 457:{f.Push(f.Locals[8]);f.Pc=459;continue;}
case 459:{f.Push(f.Locals[7]);f.Pc=461;continue;}
case 461:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento","next","Lforge/game/undo/GameMemento;",value);f.Pc=464;continue;}
case 464:{f.Push(f.Locals[0]);f.Pc=465;continue;}
case 465:{f.Push(f.Locals[7]);f.Pc=467;continue;}
case 467:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","last","Lforge/game/undo/GameMemento;",value);f.Pc=470;continue;}
case 470:{f.Push(f.Locals[0]);f.Pc=471;continue;}
case 471:{f.Push(f.Locals[0]);f.Pc=472;continue;}
case 472:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dc","I"));f.Pc=475;continue;}
case 475:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastDeltaEntries","I",value);f.Pc=478;continue;}
case 478:{f.Push(f.Locals[0]);f.Pc=479;continue;}
case 479:{f.Push(f.Locals[0]);f.Pc=480;continue;}
case 480:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","deltaBytes","J"));f.Pc=483;continue;}
case 483:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastDeltaBytes","J",value);f.Pc=486;continue;}
case 486:{f.Push(f.Locals[0]);f.Pc=487;continue;}
case 487:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dc","I"));f.Pc=490;continue;}
case 490:{f.Pc=f.Pop().Int!=0?497:493;continue;}
case 493:{f.Push(JValue.L(0));f.Pc=494;continue;}
case 494:{f.Pc=510;continue;}
case 497:{f.Push(JValue.L(32L));f.Pc=500;continue;}
case 500:{f.Push(JValue.L(16L));f.Pc=503;continue;}
case 503:{f.Push(f.Locals[0]);f.Pc=504;continue;}
case 504:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dc","I"));f.Pc=507;continue;}
case 507:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=508;continue;}
case 508:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lmul",a,b));f.Pc=509;continue;}
case 509:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=510;continue;}
case 510:{f.Locals[15]=f.Pop();f.Pc=512;continue;}
case 512:{f.Push(f.Locals[9]);f.Pc=514;continue;}
case 514:{f.Push(f.Locals[11]);f.Pc=516;continue;}
case 516:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=517;continue;}
case 517:{f.Push(JValue.L(0));f.Pc=518;continue;}
case 518:{f.Push(f.Locals[0]);f.Pc=519;continue;}
case 519:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","scratchBytes","()J","invokevirtual",522);}
case 522:{f.Push(f.Locals[4]);f.Pc=524;continue;}
case 524:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=525;continue;}
case 525:{return rt.Call(f,"java/lang/Math","max","(JJ)J","invokestatic",528);}
case 528:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=529;continue;}
case 529:{f.Push(JValue.L(96L));f.Pc=532;continue;}
case 532:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=533;continue;}
case 533:{f.Push(f.Locals[15]);f.Pc=535;continue;}
case 535:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=536;continue;}
case 536:{f.Locals[17]=f.Pop();f.Pc=538;continue;}
case 538:{f.Push(f.Locals[7]);f.Pc=540;continue;}
case 540:{f.Push(f.Locals[17]);f.Pc=542;continue;}
case 542:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento","captureBytes","J",value);f.Pc=545;continue;}
case 545:{f.Push(f.Locals[3]);f.Pc=546;continue;}
case 546:{f.Pc=f.Pop().Int==0?635:549;continue;}
case 549:{f.Push(f.Locals[0]);f.Pc=550;continue;}
case 550:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","recording","Z"));f.Pc=553;continue;}
case 553:{f.Pc=f.Pop().Int==0?585:556;continue;}
case 556:{f.Push(f.Locals[0]);f.Pc=557;continue;}
case 557:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastCaptureBytes","J"));f.Pc=560;continue;}
case 560:{f.Push(f.Locals[0]);f.Pc=561;continue;}
case 561:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastCaptureBytes","J"));f.Pc=564;continue;}
case 564:{f.Push(JValue.L(8L));f.Pc=567;continue;}
case 567:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ldiv",a,b));f.Pc=568;continue;}
case 568:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=569;continue;}
case 569:{f.Locals[19]=f.Pop();f.Pc=571;continue;}
case 571:{f.Push(f.Locals[0]);f.Pc=572;continue;}
case 572:{f.Push(f.Locals[17]);f.Pc=574;continue;}
case 574:{f.Push(f.Locals[19]);f.Pc=576;continue;}
case 576:{return rt.Call(f,"java/lang/Math","max","(JJ)J","invokestatic",579);}
case 579:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastCaptureBytes","J",value);f.Pc=582;continue;}
case 582:{f.Pc=651;continue;}
case 585:{f.Push(f.Locals[0]);f.Pc=586;continue;}
case 586:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastRebaseCaptureBytes","J"));f.Pc=589;continue;}
case 589:{f.Push(f.Locals[0]);f.Pc=590;continue;}
case 590:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastRebaseCaptureBytes","J"));f.Pc=593;continue;}
case 593:{f.Push(JValue.L(8L));f.Pc=596;continue;}
case 596:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ldiv",a,b));f.Pc=597;continue;}
case 597:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=598;continue;}
case 598:{f.Locals[19]=f.Pop();f.Pc=600;continue;}
case 600:{f.Push(f.Locals[0]);f.Pc=601;continue;}
case 601:{f.Push(f.Locals[17]);f.Pc=603;continue;}
case 603:{f.Push(f.Locals[19]);f.Pc=605;continue;}
case 605:{return rt.Call(f,"java/lang/Math","max","(JJ)J","invokestatic",608);}
case 608:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastRebaseCaptureBytes","J",value);f.Pc=611;continue;}
case 611:{f.Push(f.Locals[0]);f.Pc=612;continue;}
case 612:{f.Push(f.Locals[17]);f.Pc=614;continue;}
case 614:{f.Push(JValue.L(2L));f.Pc=617;continue;}
case 617:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lmul",a,b));f.Pc=618;continue;}
case 618:{f.Push(f.Locals[0]);f.Pc=619;continue;}
case 619:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastCaptureBytes","J"));f.Pc=622;continue;}
case 622:{f.Push(JValue.L(2L));f.Pc=625;continue;}
case 625:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ldiv",a,b));f.Pc=626;continue;}
case 626:{return rt.Call(f,"java/lang/Math","max","(JJ)J","invokestatic",629);}
case 629:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastCaptureBytes","J",value);f.Pc=632;continue;}
case 632:{f.Pc=651;continue;}
case 635:{f.Push(f.Locals[0]);f.Pc=636;continue;}
case 636:{f.Push(f.Locals[17]);f.Pc=638;continue;}
case 638:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastFullCaptureBytes","J",value);f.Pc=641;continue;}
case 641:{f.Push(f.Locals[0]);f.Pc=642;continue;}
case 642:{f.Push(JValue.L(0));f.Pc=643;continue;}
case 643:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastCaptureBytes","J",value);f.Pc=646;continue;}
case 646:{f.Push(f.Locals[0]);f.Pc=647;continue;}
case 647:{f.Push(JValue.L(0));f.Pc=648;continue;}
case 648:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastRebaseCaptureBytes","J",value);f.Pc=651;continue;}
case 651:{f.Pc=769;continue;}
case 654:{f.Push(f.Locals[7]);f.Pc=656;continue;}
case 656:{f.Push(f.Locals[0]);f.Pc=657;continue;}
case 657:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","wn","I"));f.Pc=660;continue;}
case 660:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=663;continue;}
case 663:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento","targets","[Ljava/lang/Object;",value);f.Pc=666;continue;}
case 666:{f.Push(f.Locals[7]);f.Pc=668;continue;}
case 668:{f.Push(f.Locals[0]);f.Pc=669;continue;}
case 669:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","wn","I"));f.Pc=672;continue;}
case 672:{f.Push(JValue.R(rt.NewArray("Lforge/game/undo/GameMemento$Snap;",f.Pop().Int)));f.Pc=675;continue;}
case 675:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento","snaps","[Lforge/game/undo/GameMemento$Snap;",value);f.Pc=678;continue;}
case 678:{f.Push(JValue.I(0));f.Pc=679;continue;}
case 679:{f.Locals[13]=f.Pop();f.Pc=681;continue;}
case 681:{f.Push(f.Locals[13]);f.Pc=683;continue;}
case 683:{f.Push(f.Locals[0]);f.Pc=684;continue;}
case 684:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","wn","I"));f.Pc=687;continue;}
case 687:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?732:690;continue;}
case 690:{f.Push(f.Locals[7]);f.Pc=692;continue;}
case 692:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","targets","[Ljava/lang/Object;"));f.Pc=695;continue;}
case 695:{f.Push(f.Locals[13]);f.Pc=697;continue;}
case 697:{f.Push(f.Locals[0]);f.Pc=698;continue;}
case 698:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","work","[Lforge/game/undo/GameMemento$Node;"));f.Pc=701;continue;}
case 701:{f.Push(f.Locals[13]);f.Pc=703;continue;}
case 703:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=704;continue;}
case 704:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","obj","Ljava/lang/Object;"));f.Pc=707;continue;}
case 707:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=708;continue;}
case 708:{f.Push(f.Locals[7]);f.Pc=710;continue;}
case 710:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","snaps","[Lforge/game/undo/GameMemento$Snap;"));f.Pc=713;continue;}
case 713:{f.Push(f.Locals[13]);f.Pc=715;continue;}
case 715:{f.Push(f.Locals[0]);f.Pc=716;continue;}
case 716:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","work","[Lforge/game/undo/GameMemento$Node;"));f.Pc=719;continue;}
case 719:{f.Push(f.Locals[13]);f.Pc=721;continue;}
case 721:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=722;continue;}
case 722:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","snap","Lforge/game/undo/GameMemento$Snap;"));f.Pc=725;continue;}
case 725:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=726;continue;}
case 726:{f.Locals[13]=JValue.I(unchecked(f.Locals[13].Int+(1)));f.Pc=729;continue;}
case 729:{f.Pc=681;continue;}
case 732:{f.Push(f.Locals[7]);f.Pc=734;continue;}
case 734:{f.Push(f.Locals[9]);f.Pc=736;continue;}
case 736:{f.Push(JValue.L(0));f.Pc=737;continue;}
case 737:{f.Push(f.Locals[0]);f.Pc=738;continue;}
case 738:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","scratchBytes","()J","invokevirtual",741);}
case 741:{f.Push(f.Locals[4]);f.Pc=743;continue;}
case 743:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=744;continue;}
case 744:{return rt.Call(f,"java/lang/Math","max","(JJ)J","invokestatic",747);}
case 747:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=748;continue;}
case 748:{f.Push(JValue.L(96L));f.Pc=751;continue;}
case 751:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=752;continue;}
case 752:{f.Push(JValue.L(32L));f.Pc=755;continue;}
case 755:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=756;continue;}
case 756:{f.Push(JValue.L(16L));f.Pc=759;continue;}
case 759:{f.Push(f.Locals[0]);f.Pc=760;continue;}
case 760:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","wn","I"));f.Pc=763;continue;}
case 763:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=764;continue;}
case 764:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lmul",a,b));f.Pc=765;continue;}
case 765:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=766;continue;}
case 766:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento","captureBytes","J",value);f.Pc=769;continue;}
case 769:{f.Push(f.Locals[0]);f.Pc=770;continue;}
case 770:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","releaseScratch","()V","invokevirtual",773);}
case 773:{f.Pc=794;continue;}
case 776:{f.Locals[13]=f.Pop();f.Pc=778;continue;}
case 778:{f.Push(f.Locals[0]);f.Pc=779;continue;}
case 779:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","reset","()V","invokevirtual",782);}
case 782:{f.Push(f.Locals[13]);f.Pc=784;continue;}
case 784:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 785:{f.Locals[21]=f.Pop();f.Pc=787;continue;}
case 787:{f.Push(f.Locals[0]);f.Pc=788;continue;}
case 788:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","releaseScratch","()V","invokevirtual",791);}
case 791:{f.Push(f.Locals[21]);f.Pc=793;continue;}
case 793:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 794:{f.Push(f.Locals[7]);f.Pc=796;continue;}
case 796:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10952(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.StackOp("dup");f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","liveBytes","J"));f.Pc=5;continue;}
case 5:{f.Push(JValue.L(64L));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","snap","Lforge/game/undo/GameMemento$Snap;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/undo/GameMemento$Snap","bytes","()J","invokevirtual",15);}
case 15:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=16;continue;}
case 16:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","liveBytes","J",value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","recording","Z"));f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Int==0?38:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","snap","Lforge/game/undo/GameMemento$Snap;"));f.Pc=33;continue;}
case 33:{f.Push(JValue.R(null));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","note","(Lforge/game/undo/GameMemento$Node;Lforge/game/undo/GameMemento$Snap;Lforge/game/undo/GameMemento$Snap;)J","invokevirtual",37);}
case 37:{f.StackOp("pop2");f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","registry","Ljava/util/IdentityHashMap;"));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","obj","Ljava/lang/Object;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/IdentityHashMap","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",49);}
case 49:{f.StackOp("pop");f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","unlink","(Lforge/game/undo/GameMemento$Node;)V","invokevirtual",55);}
case 55:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10953(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","work","[Lforge/game/undo/GameMemento$Node;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/undo/GameMemento","arr","(I)J","invokestatic",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","objs","[Lforge/game/undo/GameMemento$Node;"));f.Pc=12;continue;}
case 12:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/undo/GameMemento","arr","(I)J","invokestatic",16);}
case 16:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","conts","[Lforge/game/undo/GameMemento$Node;"));f.Pc=21;continue;}
case 21:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/undo/GameMemento","arr","(I)J","invokestatic",25);}
case 25:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dn","[Lforge/game/undo/GameMemento$Node;"));f.Pc=30;continue;}
case 30:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/undo/GameMemento","arr","(I)J","invokestatic",34);}
case 34:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","ds","[Lforge/game/undo/GameMemento$HistoryData;"));f.Pc=39;continue;}
case 39:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/undo/GameMemento","arr","(I)J","invokestatic",43);}
case 43:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sRefs","[Ljava/lang/Object;"));f.Pc=48;continue;}
case 48:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/undo/GameMemento","arr","(I)J","invokestatic",52);}
case 52:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sPrims","[J"));f.Pc=57;continue;}
case 57:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/undo/GameMemento","arr","(I)J","invokestatic",61);}
case 61:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=62;continue;}
case 62:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10954(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","work","[Lforge/game/undo/GameMemento$Node;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(65536));f.Pc=8;continue;}
case 8:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?24:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1024));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.NewArray("Lforge/game/undo/GameMemento$Node;",f.Pop().Int)));f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","work","[Lforge/game/undo/GameMemento$Node;",value);f.Pc=21;continue;}
case 21:{f.Pc=45;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","work","[Lforge/game/undo/GameMemento$Node;"));f.Pc=28;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","wn","I"));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","work","[Lforge/game/undo/GameMemento$Node;"));f.Pc=37;continue;}
case 37:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",41);}
case 41:{f.Push(JValue.R(null));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Arrays","fill","([Ljava/lang/Object;IILjava/lang/Object;)V","invokestatic",45);}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","wn","I",value);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dn","[Lforge/game/undo/GameMemento$Node;"));f.Pc=54;continue;}
case 54:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=55;continue;}
case 55:{f.Push(JValue.I(65536));f.Pc=58;continue;}
case 58:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?84:61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(JValue.I(1024));f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.NewArray("Lforge/game/undo/GameMemento$Node;",f.Pop().Int)));f.Pc=68;continue;}
case 68:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dn","[Lforge/game/undo/GameMemento$Node;",value);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(JValue.I(1024));f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.NewArray("Lforge/game/undo/GameMemento$HistoryData;",f.Pop().Int)));f.Pc=78;continue;}
case 78:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","ds","[Lforge/game/undo/GameMemento$HistoryData;",value);f.Pc=81;continue;}
case 81:{f.Pc=126;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dn","[Lforge/game/undo/GameMemento$Node;"));f.Pc=88;continue;}
case 88:{f.Push(JValue.I(0));f.Pc=89;continue;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dc","I"));f.Pc=93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dn","[Lforge/game/undo/GameMemento$Node;"));f.Pc=97;continue;}
case 97:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",101);}
case 101:{f.Push(JValue.R(null));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/Arrays","fill","([Ljava/lang/Object;IILjava/lang/Object;)V","invokestatic",105);}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","ds","[Lforge/game/undo/GameMemento$HistoryData;"));f.Pc=109;continue;}
case 109:{f.Push(JValue.I(0));f.Pc=110;continue;}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dc","I"));f.Pc=114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","ds","[Lforge/game/undo/GameMemento$HistoryData;"));f.Pc=118;continue;}
case 118:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",122);}
case 122:{f.Push(JValue.R(null));f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/util/Arrays","fill","([Ljava/lang/Object;IILjava/lang/Object;)V","invokestatic",126);}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(JValue.I(0));f.Pc=128;continue;}
case 128:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dc","I",value);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sRefs","[Ljava/lang/Object;"));f.Pc=135;continue;}
case 135:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=136;continue;}
case 136:{f.Push(JValue.I(65536));f.Pc=139;continue;}
case 139:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?155:142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{f.Push(JValue.I(256));f.Pc=146;continue;}
case 146:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=149;continue;}
case 149:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sRefs","[Ljava/lang/Object;",value);f.Pc=152;continue;}
case 152:{f.Pc=176;continue;}
case 155:{f.Push(f.Locals[0]);f.Pc=156;continue;}
case 156:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sRefs","[Ljava/lang/Object;"));f.Pc=159;continue;}
case 159:{f.Push(JValue.I(0));f.Pc=160;continue;}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","highWater","I"));f.Pc=164;continue;}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sRefs","[Ljava/lang/Object;"));f.Pc=168;continue;}
case 168:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",172);}
case 172:{f.Push(JValue.R(null));f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/util/Arrays","fill","([Ljava/lang/Object;IILjava/lang/Object;)V","invokestatic",176);}
case 176:{f.Push(f.Locals[0]);f.Pc=177;continue;}
case 177:{f.Push(JValue.I(0));f.Pc=178;continue;}
case 178:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","highWater","I",value);f.Pc=181;continue;}
case 181:{f.Push(f.Locals[0]);f.Pc=182;continue;}
case 182:{f.Push(JValue.R(null));f.Pc=183;continue;}
case 183:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","current","Lforge/game/undo/GameMemento;",value);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[0]);f.Pc=187;continue;}
case 187:{f.Push(JValue.I(0));f.Pc=188;continue;}
case 188:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","recording","Z",value);f.Pc=191;continue;}
case 191:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10955(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dc","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dn","[Lforge/game/undo/GameMemento$Node;"));f.Pc=8;continue;}
case 8:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=9;continue;}
case 9:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?52:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dn","[Lforge/game/undo/GameMemento$Node;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dc","I"));f.Pc=21;continue;}
case 21:{f.Push(JValue.I(2));f.Pc=22;continue;}
case 22:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Arrays","copyOf","([Ljava/lang/Object;I)[Ljava/lang/Object;","invokestatic",26);}
case 26:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/undo/GameMemento$Node;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=29;continue;}
case 29:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dn","[Lforge/game/undo/GameMemento$Node;",value);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","ds","[Lforge/game/undo/GameMemento$HistoryData;"));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dc","I"));f.Pc=41;continue;}
case 41:{f.Push(JValue.I(2));f.Pc=42;continue;}
case 42:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Arrays","copyOf","([Ljava/lang/Object;I)[Ljava/lang/Object;","invokestatic",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/undo/GameMemento$HistoryData;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","ds","[Lforge/game/undo/GameMemento$HistoryData;",value);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{f.Pc=f.Pop().Reference!=null?60:56;continue;}
case 56:{f.Push(JValue.R(null));f.Pc=57;continue;}
case 57:{f.Pc=73;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{f.Pc=f.Pop().Reference!=null?68:64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{f.Pc=73;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/undo/GameMemento$UndoDelta","between","(Lforge/game/undo/GameMemento$Snap;Lforge/game/undo/GameMemento$Snap;)Lforge/game/undo/GameMemento$HistoryData;","invokestatic",73);}
case 73:{f.Locals[4]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dn","[Lforge/game/undo/GameMemento$Node;"));f.Pc=79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dc","I"));f.Pc=83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","ds","[Lforge/game/undo/GameMemento$HistoryData;"));f.Pc=89;continue;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dc","I"));f.Pc=93;continue;}
case 93:{f.Push(f.Locals[4]);f.Pc=95;continue;}
case 95:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dc","I"));f.Pc=101;continue;}
case 101:{f.Push(JValue.I(1));f.Pc=102;continue;}
case 102:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=103;continue;}
case 103:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","dc","I",value);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[0]);f.Pc=107;continue;}
case 107:{f.StackOp("dup");f.Pc=108;continue;}
case 108:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","deltaBytes","J"));f.Pc=111;continue;}
case 111:{f.Push(JValue.L(16L));f.Pc=114;continue;}
case 114:{f.Push(f.Locals[4]);f.Pc=116;continue;}
case 116:{f.Pc=f.Pop().Reference!=null?123:119;continue;}
case 119:{f.Push(JValue.L(0));f.Pc=120;continue;}
case 120:{f.Pc=128;continue;}
case 123:{f.Push(f.Locals[4]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/undo/GameMemento$HistoryData","bytes","()J","invokevirtual",128);}
case 128:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=129;continue;}
case 129:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=130;continue;}
case 130:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","deltaBytes","J",value);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[4]);f.Pc=135;continue;}
case 135:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$UndoDelta")?1:0));f.Pc=138;continue;}
case 138:{f.Pc=f.Pop().Int==0?149:141;continue;}
case 141:{f.Push(f.Locals[4]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/undo/GameMemento$HistoryData","bytes","()J","invokevirtual",146);}
case 146:{f.Pc=150;continue;}
case 149:{f.Push(JValue.L(0));f.Pc=150;continue;}
case 150:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10956(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?19:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","owner","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?19:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","last","Lforge/game/undo/GameMemento;"));f.Pc=16;continue;}
case 16:{f.Pc=f.Pop().Reference!=null?21:19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","last","Lforge/game/undo/GameMemento;"));f.Pc=30;continue;}
case 30:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?50:33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{f.Pc=f.Pop().Reference!=null?39:37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 39:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","next","Lforge/game/undo/GameMemento;"));f.Pc=46;continue;}
case 46:{f.Locals[3]=f.Pop();f.Pc=47;continue;}
case 47:{f.Pc=25;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Pc=f.Pop().Int<=0?204:54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.NewArray("Lforge/game/undo/GameMemento;",f.Pop().Int)));f.Pc=58;continue;}
case 58:{f.Locals[3]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{f.Locals[4]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(JValue.I(0));f.Pc=63;continue;}
case 63:{f.Locals[5]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[5]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?90:71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[5]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[4]);f.Pc=76;continue;}
case 76:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","next","Lforge/game/undo/GameMemento;"));f.Pc=82;continue;}
case 82:{f.Locals[4]=f.Pop();f.Pc=84;continue;}
case 84:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=87;continue;}
case 87:{f.Pc=65;continue;}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{f.Push(JValue.I(1));f.Pc=92;continue;}
case 92:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=93;continue;}
case 93:{f.Locals[5]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[5]);f.Pc=97;continue;}
case 97:{f.Pc=f.Pop().Int<0?114:100;continue;}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[3]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[5]);f.Pc=104;continue;}
case 104:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","rewind","(Lforge/game/undo/GameMemento;)V","invokevirtual",108);}
case 108:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(-1)));f.Pc=111;continue;}
case 111:{f.Pc=95;continue;}
case 114:{f.Pc=145;continue;}
case 117:{f.Locals[5]=f.Pop();f.Pc=119;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","reset","()V","invokevirtual",123);}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","problems","Ljava/util/List;"));f.Pc=127;continue;}
case 127:{f.Push(f.Locals[5]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",132);}
case 132:{return rt.DynamicCall(f,"forge/game/undo/GameMemento$Recorder:10956:132:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",137);}
case 137:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",142);}
case 142:{f.StackOp("pop");f.Pc=143;continue;}
case 143:{f.Push(JValue.I(0));f.Pc=144;continue;}
case 144:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 145:{f.Push(f.Locals[3]);f.Pc=146;continue;}
case 146:{f.Locals[5]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[5]);f.Pc=150;continue;}
case 150:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=151;continue;}
case 151:{f.Locals[6]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(JValue.I(0));f.Pc=154;continue;}
case 154:{f.Locals[7]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[7]);f.Pc=158;continue;}
case 158:{f.Push(f.Locals[6]);f.Pc=160;continue;}
case 160:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?204:163;continue;}
case 163:{f.Push(f.Locals[5]);f.Pc=165;continue;}
case 165:{f.Push(f.Locals[7]);f.Pc=167;continue;}
case 167:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=168;continue;}
case 168:{f.Locals[8]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(f.Locals[8]);f.Pc=172;continue;}
case 172:{f.Push(JValue.R(null));f.Pc=173;continue;}
case 173:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento","next","Lforge/game/undo/GameMemento;",value);f.Pc=176;continue;}
case 176:{f.Push(f.Locals[8]);f.Pc=178;continue;}
case 178:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_NODES","[Lforge/game/undo/GameMemento$Node;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","NO_NODES","[Lforge/game/undo/GameMemento$Node;"));f.Pc=181;continue;}
case 181:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento","undoNodes","[Lforge/game/undo/GameMemento$Node;",value);f.Pc=184;continue;}
case 184:{f.Push(f.Locals[8]);f.Pc=186;continue;}
case 186:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_DELTAS","[Lforge/game/undo/GameMemento$HistoryData;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","NO_DELTAS","[Lforge/game/undo/GameMemento$HistoryData;"));f.Pc=189;continue;}
case 189:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento","undoDeltas","[Lforge/game/undo/GameMemento$HistoryData;",value);f.Pc=192;continue;}
case 192:{f.Push(f.Locals[8]);f.Pc=194;continue;}
case 194:{f.Push(JValue.L(0));f.Pc=195;continue;}
case 195:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento","undoBytes","J",value);f.Pc=198;continue;}
case 198:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=201;continue;}
case 201:{f.Pc=156;continue;}
case 204:{f.Push(f.Locals[0]);f.Pc=205;continue;}
case 205:{f.Push(f.Locals[1]);f.Pc=206;continue;}
case 206:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","last","Lforge/game/undo/GameMemento;",value);f.Pc=209;continue;}
case 209:{f.Push(JValue.I(0));f.Pc=210;continue;}
case 210:{f.Locals[3]=f.Pop();f.Pc=211;continue;}
case 211:{f.Push(f.Locals[3]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[0]);f.Pc=213;continue;}
case 213:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","no","I"));f.Pc=216;continue;}
case 216:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?266:219;continue;}
case 219:{f.Push(f.Locals[0]);f.Pc=220;continue;}
case 220:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","objs","[Lforge/game/undo/GameMemento$Node;"));f.Pc=223;continue;}
case 223:{f.Push(f.Locals[3]);f.Pc=224;continue;}
case 224:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=225;continue;}
case 225:{f.Locals[4]=f.Pop();f.Pc=227;continue;}
case 227:{f.Push(f.Locals[4]);f.Pc=229;continue;}
case 229:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","snap","Lforge/game/undo/GameMemento$Snap;"));f.Pc=232;continue;}
case 232:{f.Locals[6]=f.Pop();f.Pc=234;continue;}
case 234:{f.Push(f.Locals[6]);f.Pc=236;continue;}
case 236:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$ObjSnap")?1:0));f.Pc=239;continue;}
case 239:{f.Pc=f.Pop().Int==0?260:242;continue;}
case 242:{f.Push(f.Locals[6]);f.Pc=244;continue;}
case 244:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$ObjSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=247;continue;}
case 247:{f.Locals[5]=f.Pop();f.Pc=249;continue;}
case 249:{f.Push(f.Locals[1]);f.Pc=250;continue;}
case 250:{f.Push(f.Locals[4]);f.Pc=252;continue;}
case 252:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","obj","Ljava/lang/Object;"));f.Pc=255;continue;}
case 255:{f.Push(f.Locals[5]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/undo/GameMemento","writeFields","(Ljava/lang/Object;Lforge/game/undo/GameMemento$ObjSnap;)V","invokevirtual",260);}
case 260:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=263;continue;}
case 263:{f.Pc=211;continue;}
case 266:{f.Push(JValue.I(0));f.Pc=267;continue;}
case 267:{f.Locals[3]=f.Pop();f.Pc=268;continue;}
case 268:{f.Push(f.Locals[3]);f.Pc=269;continue;}
case 269:{f.Push(f.Locals[0]);f.Pc=270;continue;}
case 270:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","nc","I"));f.Pc=273;continue;}
case 273:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?304:276;continue;}
case 276:{f.Push(f.Locals[0]);f.Pc=277;continue;}
case 277:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","conts","[Lforge/game/undo/GameMemento$Node;"));f.Pc=280;continue;}
case 280:{f.Push(f.Locals[3]);f.Pc=281;continue;}
case 281:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=282;continue;}
case 282:{f.Locals[4]=f.Pop();f.Pc=284;continue;}
case 284:{f.Push(f.Locals[1]);f.Pc=285;continue;}
case 285:{f.Push(f.Locals[4]);f.Pc=287;continue;}
case 287:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","obj","Ljava/lang/Object;"));f.Pc=290;continue;}
case 290:{f.Push(f.Locals[4]);f.Pc=292;continue;}
case 292:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","snap","Lforge/game/undo/GameMemento$Snap;"));f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/game/undo/GameMemento","restoreContainer","(Ljava/lang/Object;Lforge/game/undo/GameMemento$Snap;)V","invokevirtual",298);}
case 298:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=301;continue;}
case 301:{f.Pc=268;continue;}
case 304:{f.Push(JValue.I(1));f.Pc=305;continue;}
case 305:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10957(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","undoNodes","[Lforge/game/undo/GameMemento$Node;"));f.Pc=4;continue;}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","undoDeltas","[Lforge/game/undo/GameMemento$HistoryData;"));f.Pc=9;continue;}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=17;continue;}
case 17:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?263:20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=24;continue;}
case 24:{f.Locals[5]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=30;continue;}
case 30:{f.Locals[6]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","registry","Ljava/util/IdentityHashMap;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[5]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","obj","Ljava/lang/Object;"));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/IdentityHashMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",44);}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?53:49;continue;}
case 49:{f.Push(JValue.I(1));f.Pc=50;continue;}
case 50:{f.Pc=54;continue;}
case 53:{f.Push(JValue.I(0));f.Pc=54;continue;}
case 54:{f.Locals[7]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[6]);f.Pc=58;continue;}
case 58:{f.Pc=f.Pop().Reference!=null?109:61;continue;}
case 61:{f.Push(f.Locals[7]);f.Pc=63;continue;}
case 63:{f.Pc=f.Pop().Int==0?257:66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","registry","Ljava/util/IdentityHashMap;"));f.Pc=70;continue;}
case 70:{f.Push(f.Locals[5]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","obj","Ljava/lang/Object;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/IdentityHashMap","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[5]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","unlink","(Lforge/game/undo/GameMemento$Node;)V","invokevirtual",85);}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.StackOp("dup");f.Pc=87;continue;}
case 87:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","liveBytes","J"));f.Pc=90;continue;}
case 90:{f.Push(JValue.L(64L));f.Pc=93;continue;}
case 93:{f.Push(f.Locals[5]);f.Pc=95;continue;}
case 95:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","snap","Lforge/game/undo/GameMemento$Snap;"));f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/undo/GameMemento$Snap","bytes","()J","invokevirtual",101);}
case 101:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=102;continue;}
case 102:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=103;continue;}
case 103:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","liveBytes","J",value);f.Pc=106;continue;}
case 106:{f.Pc=257;continue;}
case 109:{f.Push(f.Locals[7]);f.Pc=111;continue;}
case 111:{f.Pc=f.Pop().Int==0?182:114;continue;}
case 114:{f.Push(f.Locals[6]);f.Pc=116;continue;}
case 116:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$UndoDelta")?1:0));f.Pc=119;continue;}
case 119:{f.Pc=f.Pop().Int==0?142:122;continue;}
case 122:{f.Push(f.Locals[6]);f.Pc=124;continue;}
case 124:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$UndoDelta"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=127;continue;}
case 127:{f.Locals[9]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[9]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[5]);f.Pc=133;continue;}
case 133:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","snap","Lforge/game/undo/GameMemento$Snap;"));f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/undo/GameMemento$UndoDelta","restore","(Lforge/game/undo/GameMemento$Snap;)Lforge/game/undo/GameMemento$Snap;","invokevirtual",139);}
case 139:{f.Pc=147;continue;}
case 142:{f.Push(f.Locals[6]);f.Pc=144;continue;}
case 144:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$Snap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=147;continue;}
case 147:{f.Locals[8]=f.Pop();f.Pc=149;continue;}
case 149:{f.Push(f.Locals[0]);f.Pc=150;continue;}
case 150:{f.StackOp("dup");f.Pc=151;continue;}
case 151:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","liveBytes","J"));f.Pc=154;continue;}
case 154:{f.Push(f.Locals[8]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/undo/GameMemento$Snap","bytes","()J","invokevirtual",159);}
case 159:{f.Push(f.Locals[5]);f.Pc=161;continue;}
case 161:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","snap","Lforge/game/undo/GameMemento$Snap;"));f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/undo/GameMemento$Snap","bytes","()J","invokevirtual",167);}
case 167:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=168;continue;}
case 168:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=169;continue;}
case 169:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","liveBytes","J",value);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[5]);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[8]);f.Pc=176;continue;}
case 176:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Node","snap","Lforge/game/undo/GameMemento$Snap;",value);f.Pc=179;continue;}
case 179:{f.Pc=257;continue;}
case 182:{f.Push(f.Locals[6]);f.Pc=184;continue;}
case 184:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$Snap")?1:0));f.Pc=187;continue;}
case 187:{f.Pc=f.Pop().Int==0?200:190;continue;}
case 190:{f.Push(f.Locals[6]);f.Pc=192;continue;}
case 192:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$Snap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=195;continue;}
case 195:{f.Locals[8]=f.Pop();f.Pc=197;continue;}
case 197:{f.Pc=211;continue;}
case 200:{if(!rt.EnsureInitialized(f,"java/lang/IllegalStateException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalStateException")));f.Pc=203;continue;}
case 203:{f.StackOp("dup");f.Pc=204;continue;}
case 204:{f.Push(JValue.R(rt.String("missing object has no full reverse snapshot")));f.Pc=207;continue;}
case 207:{return rt.Call(f,"java/lang/IllegalStateException","<init>","(Ljava/lang/String;)V","invokespecial",210);}
case 210:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 211:{f.Push(f.Locals[5]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[8]);f.Pc=215;continue;}
case 215:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Node","snap","Lforge/game/undo/GameMemento$Snap;",value);f.Pc=218;continue;}
case 218:{f.Push(f.Locals[0]);f.Pc=219;continue;}
case 219:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","registry","Ljava/util/IdentityHashMap;"));f.Pc=222;continue;}
case 222:{f.Push(f.Locals[5]);f.Pc=224;continue;}
case 224:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","obj","Ljava/lang/Object;"));f.Pc=227;continue;}
case 227:{f.Push(f.Locals[5]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/util/IdentityHashMap","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",232);}
case 232:{f.StackOp("pop");f.Pc=233;continue;}
case 233:{f.Push(f.Locals[0]);f.Pc=234;continue;}
case 234:{f.Push(f.Locals[5]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","link","(Lforge/game/undo/GameMemento$Node;)V","invokevirtual",239);}
case 239:{f.Push(f.Locals[0]);f.Pc=240;continue;}
case 240:{f.StackOp("dup");f.Pc=241;continue;}
case 241:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","liveBytes","J"));f.Pc=244;continue;}
case 244:{f.Push(JValue.L(64L));f.Pc=247;continue;}
case 247:{f.Push(f.Locals[8]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/game/undo/GameMemento$Snap","bytes","()J","invokevirtual",252);}
case 252:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=253;continue;}
case 253:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=254;continue;}
case 254:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","liveBytes","J",value);f.Pc=257;continue;}
case 257:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=260;continue;}
case 260:{f.Pc=13;continue;}
case 263:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10958(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?17:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/undo/GameMemento","kindOf","(Ljava/lang/Class;)Lforge/game/undo/GameMemento$Kind;","invokestatic",11);}
case 11:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento$Kind","LEAF","Lforge/game/undo/GameMemento$Kind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento$Kind","LEAF","Lforge/game/undo/GameMemento$Kind;"));f.Pc=14;continue;}
case 14:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?18:17;continue;}
case 17:{return JStep.ReturnVoid;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","registry","Ljava/util/IdentityHashMap;"));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/IdentityHashMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",26);}
case 26:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$Node"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=29;continue;}
case 29:{f.Locals[2]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Pc=f.Pop().Reference!=null?79:34;continue;}
case 34:{if(!rt.EnsureInitialized(f,"forge/game/undo/GameMemento$Node"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/undo/GameMemento$Node")));f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",43);}
case 43:{return rt.Call(f,"forge/game/undo/GameMemento","kindOf","(Ljava/lang/Class;)Lforge/game/undo/GameMemento$Kind;","invokestatic",46);}
case 46:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento$Kind","OBJECT","Lforge/game/undo/GameMemento$Kind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento$Kind","OBJECT","Lforge/game/undo/GameMemento$Kind;"));f.Pc=49;continue;}
case 49:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?56:52;continue;}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{f.Pc=57;continue;}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/undo/GameMemento$Node","<init>","(Ljava/lang/Object;Z)V","invokespecial",60);}
case 60:{f.Locals[2]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","registry","Ljava/util/IdentityHashMap;"));f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/IdentityHashMap","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",70);}
case 70:{f.StackOp("pop");f.Pc=71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[2]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","link","(Lforge/game/undo/GameMemento$Node;)V","invokevirtual",76);}
case 76:{f.Pc=91;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","gen","I"));f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","gen","I"));f.Pc=87;continue;}
case 87:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?91:90;continue;}
case 90:{return JStep.ReturnVoid;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","gen","I"));f.Pc=96;continue;}
case 96:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Node","gen","I",value);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","wn","I"));f.Pc=103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","work","[Lforge/game/undo/GameMemento$Node;"));f.Pc=107;continue;}
case 107:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=108;continue;}
case 108:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?131:111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","work","[Lforge/game/undo/GameMemento$Node;"));f.Pc=116;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","wn","I"));f.Pc=120;continue;}
case 120:{f.Push(JValue.I(2));f.Pc=121;continue;}
case 121:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/util/Arrays","copyOf","([Ljava/lang/Object;I)[Ljava/lang/Object;","invokestatic",125);}
case 125:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/undo/GameMemento$Node;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=128;continue;}
case 128:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","work","[Lforge/game/undo/GameMemento$Node;",value);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","work","[Lforge/game/undo/GameMemento$Node;"));f.Pc=135;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{f.StackOp("dup");f.Pc=137;continue;}
case 137:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","wn","I"));f.Pc=140;continue;}
case 140:{f.StackOp("dup_x1");f.Pc=141;continue;}
case 141:{f.Push(JValue.I(1));f.Pc=142;continue;}
case 142:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=143;continue;}
case 143:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","wn","I",value);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[2]);f.Pc=147;continue;}
case 147:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=148;continue;}
case 148:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10959(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","obj","Ljava/lang/Object;"));f.Pc=4;continue;}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/game/undo/GameMemento","kindOf","(Ljava/lang/Class;)Lforge/game/undo/GameMemento$Kind;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento$Kind","OBJECT","Lforge/game/undo/GameMemento$Kind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento$Kind","OBJECT","Lforge/game/undo/GameMemento$Kind;"));f.Pc=17;continue;}
case 17:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?26:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","snapObject","(Lforge/game/undo/GameMemento$Node;)Lforge/game/undo/GameMemento$Snap;","invokevirtual",25);}
case 25:{return JStep.Return(f.Pop());}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento$Kind","ARRAY","Lforge/game/undo/GameMemento$Kind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento$Kind","ARRAY","Lforge/game/undo/GameMemento$Kind;"));f.Pc=30;continue;}
case 30:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?52:33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",37);}
case 37:{return rt.Call(f,"java/lang/Class","getComponentType","()Ljava/lang/Class;","invokevirtual",40);}
case 40:{return rt.Call(f,"java/lang/Class","isPrimitive","()Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int==0?52:46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","snapPrimArray","(Lforge/game/undo/GameMemento$Node;)Lforge/game/undo/GameMemento$Snap;","invokevirtual",51);}
case 51:{return JStep.Return(f.Pop());}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","snapSequence","(Lforge/game/undo/GameMemento$Node;Lforge/game/undo/GameMemento$Kind;)Lforge/game/undo/GameMemento$Snap;","invokevirtual",58);}
case 58:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10960(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sn","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sRefs","[Ljava/lang/Object;"));f.Pc=8;continue;}
case 8:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=9;continue;}
case 9:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?29:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sRefs","[Ljava/lang/Object;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sn","I"));f.Pc=21;continue;}
case 21:{f.Push(JValue.I(2));f.Pc=22;continue;}
case 22:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Arrays","copyOf","([Ljava/lang/Object;I)[Ljava/lang/Object;","invokestatic",26);}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sRefs","[Ljava/lang/Object;",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sRefs","[Ljava/lang/Object;"));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.StackOp("dup");f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sn","I"));f.Pc=38;continue;}
case 38:{f.StackOp("dup_x1");f.Pc=39;continue;}
case 39:{f.Push(JValue.I(1));f.Pc=40;continue;}
case 40:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=41;continue;}
case 41:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sn","I",value);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","enqueue","(Ljava/lang/Object;)V","invokevirtual",51);}
case 51:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10961(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","obj","Ljava/lang/Object;"));f.Pc=4;continue;}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sn","I",value);f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento$1","$SwitchMap$forge$game$undo$GameMemento$Kind","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento$1","$SwitchMap$forge$game$undo$GameMemento$Kind","[I"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/undo/GameMemento$Kind","ordinal","()I","invokevirtual",17);}
case 17:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=18;continue;}
case 18:{switch(f.Pop().Int){case 1:f.Pc=48;break;case 2:f.Pc=91;break;case 3:f.Pc=157;break;case 4:f.Pc=223;break;default:f.Pc=300;break;}continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Ljava/lang/Object;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{f.Locals[4]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=57;continue;}
case 57:{f.Locals[5]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(JValue.I(0));f.Pc=60;continue;}
case 60:{f.Locals[6]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[6]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[5]);f.Pc=66;continue;}
case 66:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?88:69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[6]);f.Pc=73;continue;}
case 73:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=74;continue;}
case 74:{f.Locals[7]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[7]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","putSeq","(Ljava/lang/Object;)V","invokevirtual",82);}
case 82:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=85;continue;}
case 85:{f.Pc=62;continue;}
case 88:{f.Pc=339;continue;}
case 91:{f.Push(f.Locals[3]);f.Pc=92;continue;}
case 92:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",100);}
case 100:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",105);}
case 105:{f.Locals[4]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[4]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",114);}
case 114:{f.Pc=f.Pop().Int==0?154:117;continue;}
case 117:{f.Push(f.Locals[4]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",124);}
case 124:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=127;continue;}
case 127:{f.Locals[5]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[5]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",137);}
case 137:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","putSeq","(Ljava/lang/Object;)V","invokevirtual",140);}
case 140:{f.Push(f.Locals[0]);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[5]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",148);}
case 148:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","putSeq","(Ljava/lang/Object;)V","invokevirtual",151);}
case 151:{f.Pc=107;continue;}
case 154:{f.Pc=339;continue;}
case 157:{f.Push(f.Locals[3]);f.Pc=158;continue;}
case 158:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=161;continue;}
case 161:{return rt.Call(f,"com/google/common/collect/Multimap","entries","()Ljava/util/Collection;","invokeinterface",166);}
case 166:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",171);}
case 171:{f.Locals[4]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[4]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",180);}
case 180:{f.Pc=f.Pop().Int==0?220:183;continue;}
case 183:{f.Push(f.Locals[4]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",190);}
case 190:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=193;continue;}
case 193:{f.Locals[5]=f.Pop();f.Pc=195;continue;}
case 195:{f.Push(f.Locals[0]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[5]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",203);}
case 203:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","putSeq","(Ljava/lang/Object;)V","invokevirtual",206);}
case 206:{f.Push(f.Locals[0]);f.Pc=207;continue;}
case 207:{f.Push(f.Locals[5]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",214);}
case 214:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","putSeq","(Ljava/lang/Object;)V","invokevirtual",217);}
case 217:{f.Pc=173;continue;}
case 220:{f.Pc=339;continue;}
case 223:{f.Push(f.Locals[3]);f.Pc=224;continue;}
case 224:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Table"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=227;continue;}
case 227:{return rt.Call(f,"com/google/common/collect/Table","cellSet","()Ljava/util/Set;","invokeinterface",232);}
case 232:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",237);}
case 237:{f.Locals[4]=f.Pop();f.Pc=239;continue;}
case 239:{f.Push(f.Locals[4]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",246);}
case 246:{f.Pc=f.Pop().Int==0?297:249;continue;}
case 249:{f.Push(f.Locals[4]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",256);}
case 256:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Table$Cell"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=259;continue;}
case 259:{f.Locals[5]=f.Pop();f.Pc=261;continue;}
case 261:{f.Push(f.Locals[0]);f.Pc=262;continue;}
case 262:{f.Push(f.Locals[5]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"com/google/common/collect/Table$Cell","getRowKey","()Ljava/lang/Object;","invokeinterface",269);}
case 269:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","putSeq","(Ljava/lang/Object;)V","invokevirtual",272);}
case 272:{f.Push(f.Locals[0]);f.Pc=273;continue;}
case 273:{f.Push(f.Locals[5]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"com/google/common/collect/Table$Cell","getColumnKey","()Ljava/lang/Object;","invokeinterface",280);}
case 280:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","putSeq","(Ljava/lang/Object;)V","invokevirtual",283);}
case 283:{f.Push(f.Locals[0]);f.Pc=284;continue;}
case 284:{f.Push(f.Locals[5]);f.Pc=286;continue;}
case 286:{return rt.Call(f,"com/google/common/collect/Table$Cell","getValue","()Ljava/lang/Object;","invokeinterface",291);}
case 291:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","putSeq","(Ljava/lang/Object;)V","invokevirtual",294);}
case 294:{f.Pc=239;continue;}
case 297:{f.Pc=339;continue;}
case 300:{f.Push(f.Locals[3]);f.Pc=301;continue;}
case 301:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=304;continue;}
case 304:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",309);}
case 309:{f.Locals[4]=f.Pop();f.Pc=311;continue;}
case 311:{f.Push(f.Locals[4]);f.Pc=313;continue;}
case 313:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",318);}
case 318:{f.Pc=f.Pop().Int==0?339:321;continue;}
case 321:{f.Push(f.Locals[4]);f.Pc=323;continue;}
case 323:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",328);}
case 328:{f.Locals[5]=f.Pop();f.Pc=330;continue;}
case 330:{f.Push(f.Locals[0]);f.Pc=331;continue;}
case 331:{f.Push(f.Locals[5]);f.Pc=333;continue;}
case 333:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","putSeq","(Ljava/lang/Object;)V","invokevirtual",336);}
case 336:{f.Pc=311;continue;}
case 339:{f.Push(f.Locals[0]);f.Pc=340;continue;}
case 340:{f.Push(f.Locals[0]);f.Pc=341;continue;}
case 341:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","highWater","I"));f.Pc=344;continue;}
case 344:{f.Push(f.Locals[0]);f.Pc=345;continue;}
case 345:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sn","I"));f.Pc=348;continue;}
case 348:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",351);}
case 351:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","highWater","I",value);f.Pc=354;continue;}
case 354:{f.Push(f.Locals[1]);f.Pc=355;continue;}
case 355:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","snap","Lforge/game/undo/GameMemento$Snap;"));f.Pc=358;continue;}
case 358:{f.Locals[5]=f.Pop();f.Pc=360;continue;}
case 360:{f.Push(f.Locals[5]);f.Pc=362;continue;}
case 362:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$SeqSnap")?1:0));f.Pc=365;continue;}
case 365:{f.Pc=f.Pop().Int==0?407:368;continue;}
case 368:{f.Push(f.Locals[5]);f.Pc=370;continue;}
case 370:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$SeqSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=373;continue;}
case 373:{f.Locals[4]=f.Pop();f.Pc=375;continue;}
case 375:{f.Push(f.Locals[4]);f.Pc=377;continue;}
case 377:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=380;continue;}
case 380:{f.Push(f.Locals[0]);f.Pc=381;continue;}
case 381:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sRefs","[Ljava/lang/Object;"));f.Pc=384;continue;}
case 384:{f.Push(f.Locals[0]);f.Pc=385;continue;}
case 385:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sn","I"));f.Pc=388;continue;}
case 388:{return rt.Call(f,"forge/game/undo/GameMemento","sameItems","([Ljava/lang/Object;[Ljava/lang/Object;I)Z","invokestatic",391);}
case 391:{f.Pc=f.Pop().Int==0?407:394;continue;}
case 394:{f.Push(f.Locals[0]);f.Pc=395;continue;}
case 395:{f.StackOp("dup");f.Pc=396;continue;}
case 396:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastReused","I"));f.Pc=399;continue;}
case 399:{f.Push(JValue.I(1));f.Pc=400;continue;}
case 400:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=401;continue;}
case 401:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastReused","I",value);f.Pc=404;continue;}
case 404:{f.Push(f.Locals[4]);f.Pc=406;continue;}
case 406:{return JStep.Return(f.Pop());}
case 407:{f.Push(f.Locals[0]);f.Pc=408;continue;}
case 408:{f.StackOp("dup");f.Pc=409;continue;}
case 409:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastAllocated","I"));f.Pc=412;continue;}
case 412:{f.Push(JValue.I(1));f.Pc=413;continue;}
case 413:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=414;continue;}
case 414:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastAllocated","I",value);f.Pc=417;continue;}
case 417:{if(!rt.EnsureInitialized(f,"forge/game/undo/GameMemento$SeqSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/undo/GameMemento$SeqSnap")));f.Pc=420;continue;}
case 420:{f.StackOp("dup");f.Pc=421;continue;}
case 421:{f.Push(f.Locals[0]);f.Pc=422;continue;}
case 422:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sn","I"));f.Pc=425;continue;}
case 425:{f.Pc=f.Pop().Int!=0?434:428;continue;}
case 428:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_OBJECTS","[Ljava/lang/Object;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","NO_OBJECTS","[Ljava/lang/Object;"));f.Pc=431;continue;}
case 431:{f.Pc=445;continue;}
case 434:{f.Push(f.Locals[0]);f.Pc=435;continue;}
case 435:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sRefs","[Ljava/lang/Object;"));f.Pc=438;continue;}
case 438:{f.Push(f.Locals[0]);f.Pc=439;continue;}
case 439:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sn","I"));f.Pc=442;continue;}
case 442:{return rt.Call(f,"java/util/Arrays","copyOf","([Ljava/lang/Object;I)[Ljava/lang/Object;","invokestatic",445);}
case 445:{return rt.Call(f,"forge/game/undo/GameMemento$SeqSnap","<init>","([Ljava/lang/Object;)V","invokespecial",448);}
case 448:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10962(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","obj","Ljava/lang/Object;"));f.Pc=4;continue;}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","snap","Lforge/game/undo/GameMemento$Snap;"));f.Pc=9;continue;}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[4]);f.Pc=13;continue;}
case 13:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$PrimArrSnap")?1:0));f.Pc=16;continue;}
case 16:{f.Pc=f.Pop().Int==0?48:19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$PrimArrSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=24;continue;}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$PrimArrSnap","copy","Ljava/lang/Object;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/undo/GameMemento","samePrimArray","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokestatic",33);}
case 33:{f.Pc=f.Pop().Int==0?48:36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastReused","I"));f.Pc=41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=43;continue;}
case 43:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastReused","I",value);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{return JStep.Return(f.Pop());}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/reflect/Array","getLength","(Ljava/lang/Object;)I","invokestatic",52);}
case 52:{f.Locals[3]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",57);}
case 57:{return rt.Call(f,"java/lang/Class","getComponentType","()Ljava/lang/Class;","invokevirtual",60);}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/reflect/Array","newInstance","(Ljava/lang/Class;I)Ljava/lang/Object;","invokestatic",64);}
case 64:{f.Locals[4]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{f.Push(JValue.I(0));f.Pc=68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{f.Push(JValue.I(0));f.Pc=71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/System","arraycopy","(Ljava/lang/Object;ILjava/lang/Object;II)V","invokestatic",75);}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastAllocated","I"));f.Pc=80;continue;}
case 80:{f.Push(JValue.I(1));f.Pc=81;continue;}
case 81:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=82;continue;}
case 82:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastAllocated","I",value);f.Pc=85;continue;}
case 85:{if(!rt.EnsureInitialized(f,"forge/game/undo/GameMemento$PrimArrSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/undo/GameMemento$PrimArrSnap")));f.Pc=88;continue;}
case 88:{f.StackOp("dup");f.Pc=89;continue;}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/undo/GameMemento$PrimArrSnap","<init>","(Ljava/lang/Object;)V","invokespecial",94);}
case 94:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10963(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","obj","Ljava/lang/Object;"));f.Pc=4;continue;}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/game/undo/GameMemento","infoOf","(Ljava/lang/Class;)Lforge/game/undo/GameMemento$ClassInfo;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sRefs","[Ljava/lang/Object;"));f.Pc=17;continue;}
case 17:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","nRefs","I"));f.Pc=22;continue;}
case 22:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?46:25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","nRefs","I"));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sRefs","[Ljava/lang/Object;"));f.Pc=34;continue;}
case 34:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=35;continue;}
case 35:{f.Push(JValue.I(2));f.Pc=36;continue;}
case 36:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",40);}
case 40:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=43;continue;}
case 43:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sRefs","[Ljava/lang/Object;",value);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sPrims","[J"));f.Pc=50;continue;}
case 50:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","nPrims","I"));f.Pc=55;continue;}
case 55:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?78:58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","nPrims","I"));f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sPrims","[J"));f.Pc=67;continue;}
case 67:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=68;continue;}
case 68:{f.Push(JValue.I(2));f.Pc=69;continue;}
case 69:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",73);}
case 73:{f.Push(JValue.R(rt.NewArray("J",f.Pop().Int)));f.Pc=75;continue;}
case 75:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sPrims","[J",value);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[3]);f.Pc=79;continue;}
case 79:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","fields","[Ljava/lang/reflect/Field;"));f.Pc=82;continue;}
case 82:{f.Locals[4]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(JValue.I(0));f.Pc=85;continue;}
case 85:{f.Locals[5]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(JValue.I(0));f.Pc=88;continue;}
case 88:{f.Locals[6]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(JValue.I(0));f.Pc=91;continue;}
case 91:{f.Locals[7]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[7]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[4]);f.Pc=97;continue;}
case 97:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=98;continue;}
case 98:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?303:101;continue;}
case 101:{f.Push(f.Locals[3]);f.Pc=102;continue;}
case 102:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","stored","[Z"));f.Pc=105;continue;}
case 105:{f.Push(f.Locals[7]);f.Pc=107;continue;}
case 107:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=108;continue;}
case 108:{f.Locals[8]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[3]);f.Pc=111;continue;}
case 111:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","pk","[I"));f.Pc=114;continue;}
case 114:{f.Push(f.Locals[7]);f.Pc=116;continue;}
case 116:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=117;continue;}
case 117:{f.Pc=f.Pop().Int!=0?228:120;continue;}
case 120:{f.Push(JValue.R(null));f.Pc=121;continue;}
case 121:{f.Locals[9]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[4]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[7]);f.Pc=127;continue;}
case 127:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=128;continue;}
case 128:{f.Push(f.Locals[2]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/lang/reflect/Field","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",132);}
case 132:{f.Locals[9]=f.Pop();f.Pc=134;continue;}
case 134:{f.Pc=165;continue;}
case 137:{f.Locals[10]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[0]);f.Pc=140;continue;}
case 140:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","current","Lforge/game/undo/GameMemento;"));f.Pc=143;continue;}
case 143:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","problems","Ljava/util/List;"));f.Pc=146;continue;}
case 146:{f.Push(f.Locals[4]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[7]);f.Pc=150;continue;}
case 150:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",154);}
case 154:{return rt.DynamicCall(f,"forge/game/undo/GameMemento$Recorder:10963:154:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",159);}
case 159:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",164);}
case 164:{f.StackOp("pop");f.Pc=165;continue;}
case 165:{f.Push(f.Locals[8]);f.Pc=167;continue;}
case 167:{f.Pc=f.Pop().Int==0?182:170;continue;}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sRefs","[Ljava/lang/Object;"));f.Pc=174;continue;}
case 174:{f.Push(f.Locals[5]);f.Pc=176;continue;}
case 176:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=179;continue;}
case 179:{f.Push(f.Locals[9]);f.Pc=181;continue;}
case 181:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[9]);f.Pc=184;continue;}
case 184:{f.Pc=f.Pop().Reference==null?225:187;continue;}
case 187:{f.Push(f.Locals[0]);f.Pc=188;continue;}
case 188:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","debugBlindSpots","Z"));f.Pc=191;continue;}
case 191:{f.Pc=f.Pop().Int==0?219:194;continue;}
case 194:{f.Push(f.Locals[9]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",199);}
case 199:{return rt.Call(f,"forge/game/undo/GameMemento","kindOf","(Ljava/lang/Class;)Lforge/game/undo/GameMemento$Kind;","invokestatic",202);}
case 202:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento$Kind","LEAF","Lforge/game/undo/GameMemento$Kind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento$Kind","LEAF","Lforge/game/undo/GameMemento$Kind;"));f.Pc=205;continue;}
case 205:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?219:208;continue;}
case 208:{f.Push(f.Locals[0]);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[4]);f.Pc=211;continue;}
case 211:{f.Push(f.Locals[7]);f.Pc=213;continue;}
case 213:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=214;continue;}
case 214:{f.Push(f.Locals[9]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","noteBlind","(Ljava/lang/reflect/Field;Ljava/lang/Object;)V","invokevirtual",219);}
case 219:{f.Push(f.Locals[0]);f.Pc=220;continue;}
case 220:{f.Push(f.Locals[9]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","enqueue","(Ljava/lang/Object;)V","invokevirtual",225);}
case 225:{f.Pc=297;continue;}
case 228:{f.Push(f.Locals[8]);f.Pc=230;continue;}
case 230:{f.Pc=f.Pop().Int==0?297:233;continue;}
case 233:{f.Push(JValue.L(0));f.Pc=234;continue;}
case 234:{f.Locals[9]=f.Pop();f.Pc=236;continue;}
case 236:{f.Push(f.Locals[4]);f.Pc=238;continue;}
case 238:{f.Push(f.Locals[7]);f.Pc=240;continue;}
case 240:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=241;continue;}
case 241:{f.Push(f.Locals[3]);f.Pc=242;continue;}
case 242:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ClassInfo","pk","[I"));f.Pc=245;continue;}
case 245:{f.Push(f.Locals[7]);f.Pc=247;continue;}
case 247:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=248;continue;}
case 248:{f.Push(f.Locals[2]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/game/undo/GameMemento","readPrim","(Ljava/lang/reflect/Field;ILjava/lang/Object;)J","invokestatic",252);}
case 252:{f.Locals[9]=f.Pop();f.Pc=254;continue;}
case 254:{f.Pc=285;continue;}
case 257:{f.Locals[11]=f.Pop();f.Pc=259;continue;}
case 259:{f.Push(f.Locals[0]);f.Pc=260;continue;}
case 260:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","current","Lforge/game/undo/GameMemento;"));f.Pc=263;continue;}
case 263:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","problems","Ljava/util/List;"));f.Pc=266;continue;}
case 266:{f.Push(f.Locals[4]);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[7]);f.Pc=270;continue;}
case 270:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=271;continue;}
case 271:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",274);}
case 274:{return rt.DynamicCall(f,"forge/game/undo/GameMemento$Recorder:10963:274:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",279);}
case 279:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",284);}
case 284:{f.StackOp("pop");f.Pc=285;continue;}
case 285:{f.Push(f.Locals[0]);f.Pc=286;continue;}
case 286:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sPrims","[J"));f.Pc=289;continue;}
case 289:{f.Push(f.Locals[6]);f.Pc=291;continue;}
case 291:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=294;continue;}
case 294:{f.Push(f.Locals[9]);f.Pc=296;continue;}
case 296:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=297;continue;}
case 297:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=300;continue;}
case 300:{f.Pc=93;continue;}
case 303:{f.Push(f.Locals[0]);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[0]);f.Pc=305;continue;}
case 305:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","highWater","I"));f.Pc=308;continue;}
case 308:{f.Push(f.Locals[5]);f.Pc=310;continue;}
case 310:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",313);}
case 313:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","highWater","I",value);f.Pc=316;continue;}
case 316:{f.Push(f.Locals[1]);f.Pc=317;continue;}
case 317:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Node","snap","Lforge/game/undo/GameMemento$Snap;"));f.Pc=320;continue;}
case 320:{f.Locals[8]=f.Pop();f.Pc=322;continue;}
case 322:{f.Push(f.Locals[8]);f.Pc=324;continue;}
case 324:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$ObjSnap")?1:0));f.Pc=327;continue;}
case 327:{f.Pc=f.Pop().Int==0?393:330;continue;}
case 330:{f.Push(f.Locals[8]);f.Pc=332;continue;}
case 332:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$ObjSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=335;continue;}
case 335:{f.Locals[7]=f.Pop();f.Pc=337;continue;}
case 337:{f.Push(f.Locals[7]);f.Pc=339;continue;}
case 339:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","ci","Lforge/game/undo/GameMemento$ClassInfo;"));f.Pc=342;continue;}
case 342:{f.Push(f.Locals[3]);f.Pc=343;continue;}
case 343:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?393:346;continue;}
case 346:{f.Push(f.Locals[7]);f.Pc=348;continue;}
case 348:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","refs","[Ljava/lang/Object;"));f.Pc=351;continue;}
case 351:{f.Push(f.Locals[0]);f.Pc=352;continue;}
case 352:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sRefs","[Ljava/lang/Object;"));f.Pc=355;continue;}
case 355:{f.Push(f.Locals[5]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"forge/game/undo/GameMemento","sameItems","([Ljava/lang/Object;[Ljava/lang/Object;I)Z","invokestatic",360);}
case 360:{f.Pc=f.Pop().Int==0?393:363;continue;}
case 363:{f.Push(f.Locals[7]);f.Pc=365;continue;}
case 365:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","prims","[J"));f.Pc=368;continue;}
case 368:{f.Push(f.Locals[0]);f.Pc=369;continue;}
case 369:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sPrims","[J"));f.Pc=372;continue;}
case 372:{f.Push(f.Locals[6]);f.Pc=374;continue;}
case 374:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","samePrims","([J[JI)Z","invokestatic",377);}
case 377:{f.Pc=f.Pop().Int==0?393:380;continue;}
case 380:{f.Push(f.Locals[0]);f.Pc=381;continue;}
case 381:{f.StackOp("dup");f.Pc=382;continue;}
case 382:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastReused","I"));f.Pc=385;continue;}
case 385:{f.Push(JValue.I(1));f.Pc=386;continue;}
case 386:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=387;continue;}
case 387:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastReused","I",value);f.Pc=390;continue;}
case 390:{f.Push(f.Locals[7]);f.Pc=392;continue;}
case 392:{return JStep.Return(f.Pop());}
case 393:{f.Push(f.Locals[0]);f.Pc=394;continue;}
case 394:{f.StackOp("dup");f.Pc=395;continue;}
case 395:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastAllocated","I"));f.Pc=398;continue;}
case 398:{f.Push(JValue.I(1));f.Pc=399;continue;}
case 399:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=400;continue;}
case 400:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Recorder","lastAllocated","I",value);f.Pc=403;continue;}
case 403:{if(!rt.EnsureInitialized(f,"forge/game/undo/GameMemento$ObjSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/undo/GameMemento$ObjSnap")));f.Pc=406;continue;}
case 406:{f.StackOp("dup");f.Pc=407;continue;}
case 407:{f.Push(f.Locals[3]);f.Pc=408;continue;}
case 408:{f.Push(f.Locals[5]);f.Pc=410;continue;}
case 410:{f.Pc=f.Pop().Int!=0?419:413;continue;}
case 413:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_OBJECTS","[Ljava/lang/Object;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","NO_OBJECTS","[Ljava/lang/Object;"));f.Pc=416;continue;}
case 416:{f.Pc=428;continue;}
case 419:{f.Push(f.Locals[0]);f.Pc=420;continue;}
case 420:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sRefs","[Ljava/lang/Object;"));f.Pc=423;continue;}
case 423:{f.Push(f.Locals[5]);f.Pc=425;continue;}
case 425:{return rt.Call(f,"java/util/Arrays","copyOf","([Ljava/lang/Object;I)[Ljava/lang/Object;","invokestatic",428);}
case 428:{f.Push(f.Locals[6]);f.Pc=430;continue;}
case 430:{f.Pc=f.Pop().Int!=0?439:433;continue;}
case 433:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_LONGS","[J"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","NO_LONGS","[J"));f.Pc=436;continue;}
case 436:{f.Pc=448;continue;}
case 439:{f.Push(f.Locals[0]);f.Pc=440;continue;}
case 440:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","sPrims","[J"));f.Pc=443;continue;}
case 443:{f.Push(f.Locals[6]);f.Pc=445;continue;}
case 445:{return rt.Call(f,"java/util/Arrays","copyOf","([JI)[J","invokestatic",448);}
case 448:{return rt.Call(f,"forge/game/undo/GameMemento$ObjSnap","<init>","(Lforge/game/undo/GameMemento$ClassInfo;[Ljava/lang/Object;[J)V","invokespecial",451);}
case 451:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10964(JRuntime rt,JFrame f)
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
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?33:15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=21;continue;}
case 21:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Int==0?27:25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 27:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=30;continue;}
case 30:{f.Pc=10;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10965(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/lang/Enum")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?42:7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/lang/Number")?1:0));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int!=0?42:14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/lang/CharSequence")?1:0));f.Pc=18;continue;}
case 18:{f.Pc=f.Pop().Int!=0?42:21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/lang/Boolean")?1:0));f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Int!=0?42:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/lang/Character")?1:0));f.Pc=32;continue;}
case 32:{f.Pc=f.Pop().Int!=0?42:35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/lang/Class")?1:0));f.Pc=39;continue;}
case 39:{f.Pc=f.Pop().Int==0?43:42;continue;}
case 42:{return JStep.ReturnVoid;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","blindSeen","Ljava/util/Set;"));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",53);}
case 53:{f.Pc=f.Pop().Int==0?89:56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$Recorder","blindSpots","Ljava/util/Set;"));f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/reflect/Field","getDeclaringClass","()Ljava/lang/Class;","invokevirtual",64);}
case 64:{return rt.Call(f,"java/lang/Class","getSimpleName","()Ljava/lang/String;","invokevirtual",67);}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/reflect/Field","getName","()Ljava/lang/String;","invokevirtual",71);}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",75);}
case 75:{return rt.Call(f,"java/lang/Class","getName","()Ljava/lang/String;","invokevirtual",78);}
case 78:{return rt.DynamicCall(f,"forge/game/undo/GameMemento$Recorder:10965:78:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",83);}
case 83:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",88);}
case 88:{f.StackOp("pop");f.Pc=89;continue;}
case 89:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

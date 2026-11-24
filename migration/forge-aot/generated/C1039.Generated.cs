// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1039{
internal static JClass Build(){var c=new JClass("forge/game/undo/UndoManager","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("recorder","Lforge/game/undo/GameMemento$Recorder;",false,JValue.Default("Lforge/game/undo/GameMemento$Recorder;"),null));
c.Add(new JField("MAX","I",true,JValue.I(100),null));
c.Add(new JField("LIMITED","Z",true,JValue.I(0),null));
c.Add(new JField("UNDOS_PER_PHASE","I",true,JValue.I(2),null));
c.Add(new JField("OWN_TURN_ONLY","Z",true,JValue.I(0),null));
c.Add(new JField("stack","Ljava/util/Deque;",false,JValue.Default("Ljava/util/Deque;"),null));
c.Add(new JField("randomMark","J",false,JValue.Default("J"),null));
c.Add(new JField("justRestored","Z",false,JValue.Default("Z"),null));
c.Add(new JField("requested","Z",false,JValue.Default("Z"),null));
c.Add(new JField("barrierReason","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("mode","Lforge/game/undo/UndoManager$Mode;",false,JValue.Default("Lforge/game/undo/UndoManager$Mode;"),null));
c.Add(new JField("owner","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("undosLeft","I",false,JValue.Default("I"),null));
c.Add(new JField("budgetPhase","J",false,JValue.Default("J"),null));
c.Add(new JField("resetRecorder","Z",false,JValue.Default("Z"),null));
c.Add(new JField("lastObjects","J",false,JValue.Default("J"),null));
c.Add(new JField("lastStandaloneCaptureBytes","J",false,JValue.Default("J"),null));
c.Add(new JField("lowMemorySkips","I",false,JValue.Default("I"),null));
c.Add(new JField("MAX_RETAINED_BYTES","J",true,JValue.Default("J"),null));
c.Add(new JField("MIN_INCREMENTAL_ESTIMATE","J",true,JValue.L(262144L),null));
c.Add(new JField("MIN_HEAP_RESERVE","J",true,JValue.L(524288L),null));
c.Add(new JField("MAX_HEAP_RESERVE","J",true,JValue.L(2097152L),null));
c.Add(new JField("HEAP_RESERVE_SCALE_DIVISOR","J",true,JValue.L(4096L),null));
c.Add(new JField("MAX_BASELINE_REUSE_SKIPS","I",true,JValue.I(3),null));
c.Add(new JField("DEBUG","Z",true,JValue.Default("Z"),null));
c.Add(new JMethod(10975,"forge/game/undo/UndoManager","<init>","()V",1,1,3,new JHandler[]{},M10975));
c.Add(new JMethod(10976,"forge/game/undo/UndoManager","heapReserve","(J)J",8,2,8,new JHandler[]{},M10976));
c.Add(new JMethod(10977,"forge/game/undo/UndoManager","heapAllows","(Z)Z",2,13,8,new JHandler[]{},M10977));
c.Add(new JMethod(10978,"forge/game/undo/UndoManager","debug","(Ljava/lang/String;)V",2,2,2,new JHandler[]{},M10978));
c.Add(new JMethod(10979,"forge/game/undo/UndoManager","dropHistory","(Ljava/lang/String;)V",34,2,3,new JHandler[]{},M10979));
c.Add(new JMethod(10980,"forge/game/undo/UndoManager","discardHistoryKeepingBaseline","(Ljava/lang/String;)V",34,2,4,new JHandler[]{},M10980));
c.Add(new JMethod(10981,"forge/game/undo/UndoManager","retainedBytes","()J",34,5,4,new JHandler[]{},M10981));
c.Add(new JMethod(10982,"forge/game/undo/UndoManager","mode","()Lforge/game/undo/UndoManager$Mode;",33,1,1,new JHandler[]{},M10982));
c.Add(new JMethod(10983,"forge/game/undo/UndoManager","setMode","(Lforge/game/undo/UndoManager$Mode;)V",33,2,3,new JHandler[]{},M10983));
c.Add(new JMethod(10984,"forge/game/undo/UndoManager","depth","()I",33,1,3,new JHandler[]{},M10984));
c.Add(new JMethod(10985,"forge/game/undo/UndoManager","isOwner","(Lforge/game/player/Player;)Z",33,2,2,new JHandler[]{},M10985));
c.Add(new JMethod(10986,"forge/game/undo/UndoManager","checkpoint","(Lforge/game/Game;Lforge/game/player/Player;)V",1,12,8,new JHandler[]{new JHandler(4,40,382,""),new JHandler(41,95,382,""),new JHandler(96,379,382,""),new JHandler(382,386,382,""),new JHandler(413,455,458,"java/lang/OutOfMemoryError"),new JHandler(413,455,468,"java/lang/RuntimeException"),new JHandler(517,589,592,""),new JHandler(592,597,592,"")},M10986));
c.Add(new JMethod(10987,"forge/game/undo/UndoManager","markForRollback","(Lforge/game/Game;)Lforge/game/undo/UndoManager$Mark;",1,5,6,new JHandler[]{new JHandler(29,84,85,"java/lang/RuntimeException"),new JHandler(29,84,85,"java/lang/OutOfMemoryError")},M10987));
c.Add(new JMethod(10988,"forge/game/undo/UndoManager","rollbackTo","(Lforge/game/Game;Lforge/game/undo/UndoManager$Mark;)Z",1,6,4,new JHandler[]{new JHandler(6,105,108,"java/lang/RuntimeException"),new JHandler(133,159,162,""),new JHandler(162,167,162,"")},M10988));
c.Add(new JMethod(10989,"forge/game/undo/UndoManager","barrier","(Ljava/lang/String;)V",33,2,3,new JHandler[]{},M10989));
c.Add(new JMethod(10990,"forge/game/undo/UndoManager","canUndo","(Lforge/game/player/Player;)Z",33,2,2,new JHandler[]{},M10990));
c.Add(new JMethod(10991,"forge/game/undo/UndoManager","canUndo","()Z",33,1,2,new JHandler[]{},M10991));
c.Add(new JMethod(10992,"forge/game/undo/UndoManager","undosLeft","()I",33,1,1,new JHandler[]{},M10992));
c.Add(new JMethod(10993,"forge/game/undo/UndoManager","whyNot","()Ljava/lang/String;",33,1,2,new JHandler[]{},M10993));
c.Add(new JMethod(10994,"forge/game/undo/UndoManager","requestUndo","()V",1,1,2,new JHandler[]{},M10994));
c.Add(new JMethod(10995,"forge/game/undo/UndoManager","consumeRequest","()Z",1,2,2,new JHandler[]{},M10995));
c.Add(new JMethod(10996,"forge/game/undo/UndoManager","undo","(Lforge/game/Game;)Z",1,6,4,new JHandler[]{new JHandler(4,14,72,""),new JHandler(15,69,72,""),new JHandler(72,76,72,""),new JHandler(105,128,131,""),new JHandler(131,135,131,"")},M10996));
c.Add(new JMethod(10997,"forge/game/undo/UndoManager","refreshViews","(Lforge/game/Game;)V",10,3,4,new JHandler[]{},M10997));
c.Add(new JMethod(10998,"forge/game/undo/UndoManager","<clinit>","()V",8,0,6,new JHandler[]{},M10998));
}

internal static JStep M10975(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"forge/game/undo/GameMemento$Recorder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/undo/GameMemento$Recorder")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","recorder","Lforge/game/undo/GameMemento$Recorder;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{if(!rt.EnsureInitialized(f,"java/util/ArrayDeque"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayDeque")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/ArrayDeque","<init>","()V","invokespecial",23);}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/util/MyRandom","callCount","()J","invokestatic",30);}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","randomMark","J",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{if(!rt.StaticReady(f,"forge/game/undo/UndoManager$Mode","FREE","Lforge/game/undo/UndoManager$Mode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/UndoManager$Mode","FREE","Lforge/game/undo/UndoManager$Mode;"));f.Pc=37;continue;}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","mode","Lforge/game/undo/UndoManager$Mode;",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(JValue.I(2));f.Pc=42;continue;}
case 42:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","undosLeft","I",value);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(JValue.L(-1L));f.Pc=49;continue;}
case 49:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","budgetPhase","J",value);f.Pc=52;continue;}
case 52:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10976(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.L(524288L));f.Pc=3;continue;}
case 3:{f.Push(JValue.L(2097152L));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.L(4096L));f.Pc=10;continue;}
case 10:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ldiv",a,b));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/Math","min","(JJ)J","invokestatic",14);}
case 14:{return rt.Call(f,"java/lang/Math","max","(JJ)J","invokestatic",17);}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10977(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"java/lang/Runtime","getRuntime","()Ljava/lang/Runtime;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Runtime","maxMemory","()J","invokevirtual",8);}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/Runtime","totalMemory","()J","invokevirtual",12);}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/Runtime","freeMemory","()J","invokevirtual",16);}
case 16:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=17;continue;}
case 17:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=18;continue;}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","recorder","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","lastFullCaptureBytes","()J","invokevirtual",26);}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","lastStandaloneCaptureBytes","J"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/Math","max","(JJ)J","invokestatic",33);}
case 33:{f.Locals[5]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Pc=f.Pop().Int==0?70:39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{f.Push(JValue.L(0));f.Pc=42;continue;}
case 42:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=43;continue;}
case 43:{f.Pc=f.Pop().Int<=0?51:46;continue;}
case 46:{f.Push(f.Locals[5]);f.Pc=48;continue;}
case 48:{f.Pc=65;continue;}
case 51:{f.Push(JValue.L(1048576L));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","lastObjects","J"));f.Pc=58;continue;}
case 58:{f.Push(JValue.L(220L));f.Pc=61;continue;}
case 61:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lmul",a,b));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/Math","max","(JJ)J","invokestatic",65);}
case 65:{f.Locals[7]=f.Pop();f.Pc=67;continue;}
case 67:{f.Pc=231;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","recorder","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","liveBytes","()J","invokevirtual",77);}
case 77:{f.Push(JValue.L(0));f.Pc=78;continue;}
case 78:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=79;continue;}
case 79:{f.Pc=f.Pop().Int<=0?203:82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","recorder","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","needsBaseline","()Z","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int==0?153:92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","recorder","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","lastRebaseCaptureBytes","()J","invokevirtual",99);}
case 99:{f.Locals[9]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[5]);f.Pc=103;continue;}
case 103:{f.Push(JValue.L(0));f.Pc=104;continue;}
case 104:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=105;continue;}
case 105:{f.Pc=f.Pop().Int<=0?123:108;continue;}
case 108:{f.Push(JValue.L(1048576L));f.Pc=111;continue;}
case 111:{f.Push(f.Locals[5]);f.Pc=113;continue;}
case 113:{f.Push(JValue.L(64L));f.Pc=116;continue;}
case 116:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ldiv",a,b));f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/lang/Math","min","(JJ)J","invokestatic",120);}
case 120:{f.Pc=126;continue;}
case 123:{f.Push(JValue.L(262144L));f.Pc=126;continue;}
case 126:{f.Locals[11]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(JValue.L(262144L));f.Pc=131;continue;}
case 131:{f.Push(f.Locals[9]);f.Pc=133;continue;}
case 133:{f.Push(JValue.L(0));f.Pc=134;continue;}
case 134:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=135;continue;}
case 135:{f.Pc=f.Pop().Int<=0?143:138;continue;}
case 138:{f.Push(f.Locals[9]);f.Pc=140;continue;}
case 140:{f.Pc=145;continue;}
case 143:{f.Push(f.Locals[11]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/lang/Math","max","(JJ)J","invokestatic",148);}
case 148:{f.Locals[7]=f.Pop();f.Pc=150;continue;}
case 150:{f.Pc=231;continue;}
case 153:{f.Push(f.Locals[5]);f.Pc=155;continue;}
case 155:{f.Push(JValue.L(0));f.Pc=156;continue;}
case 156:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=157;continue;}
case 157:{f.Pc=f.Pop().Int<=0?175:160;continue;}
case 160:{f.Push(JValue.L(1048576L));f.Pc=163;continue;}
case 163:{f.Push(f.Locals[5]);f.Pc=165;continue;}
case 165:{f.Push(JValue.L(64L));f.Pc=168;continue;}
case 168:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ldiv",a,b));f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/lang/Math","min","(JJ)J","invokestatic",172);}
case 172:{f.Pc=178;continue;}
case 175:{f.Push(JValue.L(262144L));f.Pc=178;continue;}
case 178:{f.Locals[9]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(JValue.L(262144L));f.Pc=183;continue;}
case 183:{f.Push(f.Locals[9]);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[0]);f.Pc=186;continue;}
case 186:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","recorder","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","lastCaptureBytes","()J","invokevirtual",192);}
case 192:{return rt.Call(f,"java/lang/Math","max","(JJ)J","invokestatic",195);}
case 195:{return rt.Call(f,"java/lang/Math","max","(JJ)J","invokestatic",198);}
case 198:{f.Locals[7]=f.Pop();f.Pc=200;continue;}
case 200:{f.Pc=231;continue;}
case 203:{f.Push(f.Locals[5]);f.Pc=205;continue;}
case 205:{f.Push(JValue.L(0));f.Pc=206;continue;}
case 206:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=207;continue;}
case 207:{f.Pc=f.Pop().Int<=0?215:210;continue;}
case 210:{f.Push(f.Locals[5]);f.Pc=212;continue;}
case 212:{f.Pc=229;continue;}
case 215:{f.Push(JValue.L(1048576L));f.Pc=218;continue;}
case 218:{f.Push(f.Locals[0]);f.Pc=219;continue;}
case 219:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","lastObjects","J"));f.Pc=222;continue;}
case 222:{f.Push(JValue.L(220L));f.Pc=225;continue;}
case 225:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lmul",a,b));f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/lang/Math","max","(JJ)J","invokestatic",229);}
case 229:{f.Locals[7]=f.Pop();f.Pc=231;continue;}
case 231:{f.Push(f.Locals[7]);f.Pc=233;continue;}
case 233:{f.Push(JValue.L(131072L));f.Pc=236;continue;}
case 236:{f.Push(f.Locals[7]);f.Pc=238;continue;}
case 238:{f.Push(JValue.L(2L));f.Pc=241;continue;}
case 241:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ldiv",a,b));f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/lang/Math","max","(JJ)J","invokestatic",245);}
case 245:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=246;continue;}
case 246:{f.Locals[9]=f.Pop();f.Pc=248;continue;}
case 248:{f.Push(f.Locals[2]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"java/lang/Runtime","maxMemory","()J","invokevirtual",252);}
case 252:{return rt.Call(f,"forge/game/undo/UndoManager","heapReserve","(J)J","invokestatic",255);}
case 255:{f.Locals[11]=f.Pop();f.Pc=257;continue;}
case 257:{f.Push(f.Locals[3]);f.Pc=258;continue;}
case 258:{f.Push(f.Locals[9]);f.Pc=260;continue;}
case 260:{f.Push(f.Locals[11]);f.Pc=262;continue;}
case 262:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=263;continue;}
case 263:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=264;continue;}
case 264:{f.Pc=f.Pop().Int<=0?271:267;continue;}
case 267:{f.Push(JValue.I(1));f.Pc=268;continue;}
case 268:{f.Pc=272;continue;}
case 271:{f.Push(JValue.I(0));f.Pc=272;continue;}
case 272:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10978(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/undo/UndoManager","DEBUG","Z"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/UndoManager","DEBUG","Z"));f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Int==0?18:6;continue;}
case 6:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.DynamicCall(f,"forge/game/undo/UndoManager:10978:10:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",15);}
case 15:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",18);}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10979(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Deque","size","()I","invokeinterface",10);}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.DynamicCall(f,"forge/game/undo/UndoManager:10979:11:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(ILjava/lang/String;)Ljava/lang/String;",16);}
case 16:{return rt.Call(f,"forge/game/undo/UndoManager","debug","(Ljava/lang/String;)V","invokevirtual",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Deque","clear","()V","invokeinterface",28);}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","barrierReason","Ljava/lang/String;",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(JValue.I(0));f.Pc=35;continue;}
case 35:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","justRestored","Z",value);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","recorder","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","reset","()V","invokevirtual",45);}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","lowMemorySkips","I",value);f.Pc=50;continue;}
case 50:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10980(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Deque","clear","()V","invokeinterface",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","barrierReason","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","justRestored","Z",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","recorder","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","detach","()V","invokevirtual",26);}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","recorder","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","liveBytes","()J","invokevirtual",33);}
case 33:{f.Push(JValue.L(0));f.Pc=34;continue;}
case 34:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Int<=0?68:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.StackOp("dup");f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","lowMemorySkips","I"));f.Pc=43;continue;}
case 43:{f.Push(JValue.I(1));f.Pc=44;continue;}
case 44:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=45;continue;}
case 45:{f.StackOp("dup_x1");f.Pc=46;continue;}
case 46:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","lowMemorySkips","I",value);f.Pc=49;continue;}
case 49:{f.Push(JValue.I(3));f.Pc=50;continue;}
case 50:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?73:53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","recorder","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","reset","()V","invokevirtual",60);}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","lowMemorySkips","I",value);f.Pc=65;continue;}
case 65:{f.Pc=73;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(JValue.I(0));f.Pc=70;continue;}
case 70:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","lowMemorySkips","I",value);f.Pc=73;continue;}
case 73:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10981(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","recorder","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","liveBytes","()J","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Deque","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?52:27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/UndoManager$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/undo/UndoManager$Entry","memento","()Lforge/game/undo/GameMemento;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/game/undo/GameMemento","retainedBytes","()J","invokevirtual",47);}
case 47:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=48;continue;}
case 48:{f.Locals[1]=f.Pop();f.Pc=49;continue;}
case 49:{f.Pc=18;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10982(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","mode","Lforge/game/undo/UndoManager$Mode;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10983(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","mode","Lforge/game/undo/UndoManager$Mode;"));f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?9:8;continue;}
case 8:{return JStep.ReturnVoid;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","mode","Lforge/game/undo/UndoManager$Mode;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Deque","clear","()V","invokeinterface",23);}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","justRestored","Z",value);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/undo/UndoManager$Mode","OFF","Lforge/game/undo/UndoManager$Mode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/UndoManager$Mode","OFF","Lforge/game/undo/UndoManager$Mode;"));f.Pc=33;continue;}
case 33:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?41:36;continue;}
case 36:{f.Push(JValue.R(rt.String("Undo is off")));f.Pc=38;continue;}
case 38:{f.Pc=42;continue;}
case 41:{f.Push(JValue.R(null));f.Pc=42;continue;}
case 42:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","barrierReason","Ljava/lang/String;",value);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{if(!rt.StaticReady(f,"forge/game/undo/UndoManager$Mode","OFF","Lforge/game/undo/UndoManager$Mode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/UndoManager$Mode","OFF","Lforge/game/undo/UndoManager$Mode;"));f.Pc=49;continue;}
case 49:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?57:52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(JValue.I(1));f.Pc=54;continue;}
case 54:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","resetRecorder","Z",value);f.Pc=57;continue;}
case 57:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10984(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Deque","size","()I","invokeinterface",10);}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",15);}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10985(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","owner","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?15:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","owner","Lforge/game/player/Player;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?19:15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{f.Pc=20;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10986(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.StackOp("dup");f.Pc=2;continue;}
case 2:{f.Locals[3]=f.Pop();f.Pc=3;continue;}
case 3:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","requested","Z",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","resetRecorder","Z"));f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Int==0?28:16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","resetRecorder","Z",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","recorder","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","reset","()V","invokevirtual",28);}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","mode","Lforge/game/undo/UndoManager$Mode;"));f.Pc=32;continue;}
case 32:{if(!rt.StaticReady(f,"forge/game/undo/UndoManager$Mode","OFF","Lforge/game/undo/UndoManager$Mode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/UndoManager$Mode","OFF","Lforge/game/undo/UndoManager$Mode;"));f.Pc=35;continue;}
case 35:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?41:38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=40;continue;}
case 40:{return JStep.ReturnVoid;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","owner","Lforge/game/player/Player;"));f.Pc=45;continue;}
case 45:{f.Pc=f.Pop().Reference==null?76:48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","owner","Lforge/game/player/Player;"));f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?76:56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Deque","clear","()V","invokeinterface",65);}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("Another player had priority")));f.Pc=68;continue;}
case 68:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","barrierReason","Ljava/lang/String;",value);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(JValue.I(0));f.Pc=73;continue;}
case 73:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","justRestored","Z",value);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","owner","Lforge/game/player/Player;",value);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","justRestored","Z"));f.Pc=85;continue;}
case 85:{f.Pc=f.Pop().Int==0?96:88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(JValue.I(0));f.Pc=90;continue;}
case 90:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","justRestored","Z",value);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[3]);f.Pc=94;continue;}
case 94:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=95;continue;}
case 95:{return JStep.ReturnVoid;}
case 96:{return rt.Call(f,"forge/util/MyRandom","callCount","()J","invokestatic",99);}
case 99:{f.Locals[4]=f.Pop();f.Pc=101;continue;}
case 101:{if(!rt.StaticReady(f,"forge/game/undo/UndoManager","DEBUG","Z"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/UndoManager","DEBUG","Z"));f.Pc=104;continue;}
case 104:{f.Pc=f.Pop().Int==0?135:107;continue;}
case 107:{f.Push(JValue.I(6));f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/util/MyRandom","drainTrace","(I)Ljava/lang/String;","invokestatic",112);}
case 112:{f.Locals[6]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[4]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","randomMark","J"));f.Pc=120;continue;}
case 120:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=121;continue;}
case 121:{f.Pc=f.Pop().Int==0?135:124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[6]);f.Pc=127;continue;}
case 127:{return rt.DynamicCall(f,"forge/game/undo/UndoManager:10986:127:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",132);}
case 132:{return rt.Call(f,"forge/game/undo/UndoManager","debug","(Ljava/lang/String;)V","invokevirtual",135);}
case 135:{f.Push(f.Locals[4]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[0]);f.Pc=138;continue;}
case 138:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","randomMark","J"));f.Pc=141;continue;}
case 141:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=142;continue;}
case 142:{f.Pc=f.Pop().Int==0?167:145;continue;}
case 145:{f.Push(f.Locals[0]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[4]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[0]);f.Pc=149;continue;}
case 149:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","randomMark","J"));f.Pc=152;continue;}
case 152:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=153;continue;}
case 153:{return rt.DynamicCall(f,"forge/game/undo/UndoManager:10986:153:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(J)Ljava/lang/String;",158);}
case 158:{return rt.Call(f,"forge/game/undo/UndoManager","barrier","(Ljava/lang/String;)V","invokevirtual",161);}
case 161:{f.Push(f.Locals[0]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[4]);f.Pc=164;continue;}
case 164:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","randomMark","J",value);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[1]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",171);}
case 171:{f.Locals[6]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[6]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/phase/PhaseHandler","getTurn","()I","invokevirtual",178);}
case 178:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=179;continue;}
case 179:{f.Push(JValue.L(100L));f.Pc=182;continue;}
case 182:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lmul",a,b));f.Pc=183;continue;}
case 183:{f.Push(f.Locals[6]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPhase","()Lforge/game/phase/PhaseType;","invokevirtual",188);}
case 188:{f.Pc=f.Pop().Reference!=null?195:191;continue;}
case 191:{f.Push(JValue.I(0));f.Pc=192;continue;}
case 192:{f.Pc=203;continue;}
case 195:{f.Push(f.Locals[6]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPhase","()Lforge/game/phase/PhaseType;","invokevirtual",200);}
case 200:{return rt.Call(f,"forge/game/phase/PhaseType","ordinal","()I","invokevirtual",203);}
case 203:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=204;continue;}
case 204:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=205;continue;}
case 205:{f.Locals[7]=f.Pop();f.Pc=207;continue;}
case 207:{f.Push(f.Locals[7]);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[0]);f.Pc=210;continue;}
case 210:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","budgetPhase","J"));f.Pc=213;continue;}
case 213:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=214;continue;}
case 214:{f.Pc=f.Pop().Int<=0?228:217;continue;}
case 217:{f.Push(f.Locals[0]);f.Pc=218;continue;}
case 218:{f.Push(f.Locals[7]);f.Pc=220;continue;}
case 220:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","budgetPhase","J",value);f.Pc=223;continue;}
case 223:{f.Push(f.Locals[0]);f.Pc=224;continue;}
case 224:{f.Push(JValue.I(2));f.Pc=225;continue;}
case 225:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","undosLeft","I",value);f.Pc=228;continue;}
case 228:{f.Push(f.Locals[0]);f.Pc=229;continue;}
case 229:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","mode","Lforge/game/undo/UndoManager$Mode;"));f.Pc=232;continue;}
case 232:{if(!rt.StaticReady(f,"forge/game/undo/UndoManager$Mode","SINGLE_STEP","Lforge/game/undo/UndoManager$Mode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/UndoManager$Mode","SINGLE_STEP","Lforge/game/undo/UndoManager$Mode;"));f.Pc=235;continue;}
case 235:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?242:238;continue;}
case 238:{f.Push(JValue.I(2));f.Pc=239;continue;}
case 239:{f.Pc=244;continue;}
case 242:{f.Push(JValue.I(100));f.Pc=244;continue;}
case 244:{f.Locals[9]=f.Pop();f.Pc=246;continue;}
case 246:{f.Push(f.Locals[0]);f.Pc=247;continue;}
case 247:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=250;continue;}
case 250:{return rt.Call(f,"java/util/Deque","size","()I","invokeinterface",255);}
case 255:{f.Push(f.Locals[9]);f.Pc=257;continue;}
case 257:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?292:260;continue;}
case 260:{f.Push(f.Locals[0]);f.Pc=261;continue;}
case 261:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/util/Deque","size","()I","invokeinterface",269);}
case 269:{f.Push(JValue.I(1));f.Pc=270;continue;}
case 270:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?305:273;continue;}
case 273:{f.Push(f.Locals[0]);f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/game/undo/UndoManager","retainedBytes","()J","invokevirtual",277);}
case 277:{f.Push(f.Locals[0]);f.Pc=278;continue;}
case 278:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","recorder","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","lastDeltaBytes","()J","invokevirtual",284);}
case 284:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=285;continue;}
case 285:{if(!rt.StaticReady(f,"forge/game/undo/UndoManager","MAX_RETAINED_BYTES","J"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/UndoManager","MAX_RETAINED_BYTES","J"));f.Pc=288;continue;}
case 288:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=289;continue;}
case 289:{f.Pc=f.Pop().Int<=0?305:292;continue;}
case 292:{f.Push(f.Locals[0]);f.Pc=293;continue;}
case 293:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=296;continue;}
case 296:{return rt.Call(f,"java/util/Deque","removeLast","()Ljava/lang/Object;","invokeinterface",301);}
case 301:{f.StackOp("pop");f.Pc=302;continue;}
case 302:{f.Pc=246;continue;}
case 305:{f.Push(f.Locals[0]);f.Pc=306;continue;}
case 306:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=309;continue;}
case 309:{return rt.Call(f,"java/util/Deque","isEmpty","()Z","invokeinterface",314);}
case 314:{f.Pc=f.Pop().Int!=0?358:317;continue;}
case 317:{f.Push(f.Locals[0]);f.Pc=318;continue;}
case 318:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","recorder","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=321;continue;}
case 321:{f.Push(f.Locals[0]);f.Pc=322;continue;}
case 322:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=325;continue;}
case 325:{return rt.Call(f,"java/util/Deque","peek","()Ljava/lang/Object;","invokeinterface",330);}
case 330:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/UndoManager$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=333;continue;}
case 333:{return rt.Call(f,"forge/game/undo/UndoManager$Entry","memento","()Lforge/game/undo/GameMemento;","invokevirtual",336);}
case 336:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","isLatest","(Lforge/game/undo/GameMemento;)Z","invokevirtual",339);}
case 339:{f.Pc=f.Pop().Int!=0?358:342;continue;}
case 342:{f.Push(f.Locals[0]);f.Pc=343;continue;}
case 343:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=346;continue;}
case 346:{return rt.Call(f,"java/util/Deque","clear","()V","invokeinterface",351);}
case 351:{f.Push(f.Locals[0]);f.Pc=352;continue;}
case 352:{f.Push(JValue.R(rt.String("Undo history was reset")));f.Pc=355;continue;}
case 355:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","barrierReason","Ljava/lang/String;",value);f.Pc=358;continue;}
case 358:{f.Push(f.Locals[0]);f.Pc=359;continue;}
case 359:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=362;continue;}
case 362:{return rt.Call(f,"java/util/Deque","isEmpty","()Z","invokeinterface",367);}
case 367:{f.Pc=f.Pop().Int==0?377:370;continue;}
case 370:{f.Push(f.Locals[0]);f.Pc=371;continue;}
case 371:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","recorder","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=374;continue;}
case 374:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","detach","()V","invokevirtual",377);}
case 377:{f.Push(f.Locals[3]);f.Pc=378;continue;}
case 378:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=379;continue;}
case 379:{f.Pc=389;continue;}
case 382:{f.Locals[10]=f.Pop();f.Pc=384;continue;}
case 384:{f.Push(f.Locals[3]);f.Pc=385;continue;}
case 385:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=386;continue;}
case 386:{f.Push(f.Locals[10]);f.Pc=388;continue;}
case 388:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 389:{f.Push(f.Locals[0]);f.Pc=390;continue;}
case 390:{f.Push(JValue.I(0));f.Pc=391;continue;}
case 391:{return rt.Call(f,"forge/game/undo/UndoManager","heapAllows","(Z)Z","invokevirtual",394);}
case 394:{f.Pc=f.Pop().Int!=0?413:397;continue;}
case 397:{f.Push(f.Locals[0]);f.Pc=398;continue;}
case 398:{f.Push(JValue.R(rt.String("Low memory")));f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/undo/UndoManager","discardHistoryKeepingBaseline","(Ljava/lang/String;)V","invokevirtual",404);}
case 404:{f.Push(f.Locals[0]);f.Pc=405;continue;}
case 405:{f.Push(JValue.I(0));f.Pc=406;continue;}
case 406:{return rt.Call(f,"forge/game/undo/UndoManager","heapAllows","(Z)Z","invokevirtual",409);}
case 409:{f.Pc=f.Pop().Int!=0?413:412;continue;}
case 412:{return JStep.ReturnVoid;}
case 413:{f.Push(f.Locals[0]);f.Pc=414;continue;}
case 414:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","recorder","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=417;continue;}
case 417:{f.Push(f.Locals[1]);f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","capture","(Ljava/lang/Object;)Lforge/game/undo/GameMemento;","invokevirtual",421);}
case 421:{f.Locals[4]=f.Pop();f.Pc=423;continue;}
case 423:{f.Push(f.Locals[0]);f.Pc=424;continue;}
case 424:{f.Push(f.Locals[4]);f.Pc=426;continue;}
case 426:{return rt.Call(f,"forge/game/undo/GameMemento","objectCount","()I","invokevirtual",429);}
case 429:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=430;continue;}
case 430:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","lastObjects","J",value);f.Pc=433;continue;}
case 433:{if(!rt.EnsureInitialized(f,"forge/game/undo/UndoManager$Entry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/undo/UndoManager$Entry")));f.Pc=436;continue;}
case 436:{f.StackOp("dup");f.Pc=437;continue;}
case 437:{f.Push(f.Locals[4]);f.Pc=439;continue;}
case 439:{f.Push(f.Locals[1]);f.Pc=440;continue;}
case 440:{return rt.Call(f,"forge/game/Game","getGameLog","()Lforge/game/GameLog;","invokevirtual",443);}
case 443:{return rt.Call(f,"forge/game/GameLog","size","()I","invokevirtual",446);}
case 446:{return rt.Call(f,"forge/game/undo/UndoManager$Entry","<init>","(Lforge/game/undo/GameMemento;I)V","invokespecial",449);}
case 449:{f.Locals[3]=f.Pop();f.Pc=450;continue;}
case 450:{f.Push(f.Locals[0]);f.Pc=451;continue;}
case 451:{f.Push(JValue.I(0));f.Pc=452;continue;}
case 452:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","lowMemorySkips","I",value);f.Pc=455;continue;}
case 455:{f.Pc=512;continue;}
case 458:{f.Locals[4]=f.Pop();f.Pc=460;continue;}
case 460:{f.Push(f.Locals[0]);f.Pc=461;continue;}
case 461:{f.Push(JValue.R(rt.String("Low memory")));f.Pc=464;continue;}
case 464:{return rt.Call(f,"forge/game/undo/UndoManager","dropHistory","(Ljava/lang/String;)V","invokevirtual",467);}
case 467:{return JStep.ReturnVoid;}
case 468:{f.Locals[4]=f.Pop();f.Pc=470;continue;}
case 470:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=473;continue;}
case 473:{f.Push(f.Locals[4]);f.Pc=475;continue;}
case 475:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",478);}
case 478:{return rt.DynamicCall(f,"forge/game/undo/UndoManager:10986:478:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",483);}
case 483:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",486);}
case 486:{if(!rt.StaticReady(f,"forge/game/undo/UndoManager","DEBUG","Z"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/UndoManager","DEBUG","Z"));f.Pc=489;continue;}
case 489:{f.Pc=f.Pop().Int==0?497:492;continue;}
case 492:{f.Push(f.Locals[4]);f.Pc=494;continue;}
case 494:{return rt.Call(f,"java/lang/RuntimeException","printStackTrace","()V","invokevirtual",497);}
case 497:{f.Push(f.Locals[0]);f.Pc=498;continue;}
case 498:{f.Push(f.Locals[4]);f.Pc=500;continue;}
case 500:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",503);}
case 503:{return rt.DynamicCall(f,"forge/game/undo/UndoManager:10986:503:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",508);}
case 508:{return rt.Call(f,"forge/game/undo/UndoManager","dropHistory","(Ljava/lang/String;)V","invokevirtual",511);}
case 511:{return JStep.ReturnVoid;}
case 512:{f.Push(f.Locals[0]);f.Pc=513;continue;}
case 513:{f.StackOp("dup");f.Pc=514;continue;}
case 514:{f.Locals[4]=f.Pop();f.Pc=516;continue;}
case 516:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=517;continue;}
case 517:{f.Push(f.Locals[0]);f.Pc=518;continue;}
case 518:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=521;continue;}
case 521:{f.Push(f.Locals[3]);f.Pc=522;continue;}
case 522:{return rt.Call(f,"java/util/Deque","push","(Ljava/lang/Object;)V","invokeinterface",527);}
case 527:{if(!rt.StaticReady(f,"forge/game/undo/UndoManager","DEBUG","Z"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/UndoManager","DEBUG","Z"));f.Pc=530;continue;}
case 530:{f.Pc=f.Pop().Int==0?568:533;continue;}
case 533:{f.Push(f.Locals[0]);f.Pc=534;continue;}
case 534:{f.Push(f.Locals[0]);f.Pc=535;continue;}
case 535:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=538;continue;}
case 538:{return rt.Call(f,"java/util/Deque","size","()I","invokeinterface",543);}
case 543:{f.Push(f.Locals[0]);f.Pc=544;continue;}
case 544:{return rt.Call(f,"forge/game/undo/UndoManager","retainedBytes","()J","invokevirtual",547);}
case 547:{f.Push(JValue.I(20));f.Pc=549;continue;}
case 549:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lshr",a,b));f.Pc=550;continue;}
case 550:{if(!rt.StaticReady(f,"forge/game/undo/UndoManager","MAX_RETAINED_BYTES","J"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/UndoManager","MAX_RETAINED_BYTES","J"));f.Pc=553;continue;}
case 553:{f.Push(JValue.I(20));f.Pc=555;continue;}
case 555:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lshr",a,b));f.Pc=556;continue;}
case 556:{f.Push(f.Locals[0]);f.Pc=557;continue;}
case 557:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","lastObjects","J"));f.Pc=560;continue;}
case 560:{return rt.DynamicCall(f,"forge/game/undo/UndoManager:10986:560:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(IJJJ)Ljava/lang/String;",565);}
case 565:{return rt.Call(f,"forge/game/undo/UndoManager","debug","(Ljava/lang/String;)V","invokevirtual",568);}
case 568:{f.Push(f.Locals[0]);f.Pc=569;continue;}
case 569:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=572;continue;}
case 572:{return rt.Call(f,"java/util/Deque","size","()I","invokeinterface",577);}
case 577:{f.Push(JValue.I(2));f.Pc=578;continue;}
case 578:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?586:581;continue;}
case 581:{f.Push(f.Locals[0]);f.Pc=582;continue;}
case 582:{f.Push(JValue.R(null));f.Pc=583;continue;}
case 583:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","barrierReason","Ljava/lang/String;",value);f.Pc=586;continue;}
case 586:{f.Push(f.Locals[4]);f.Pc=588;continue;}
case 588:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=589;continue;}
case 589:{f.Pc=600;continue;}
case 592:{f.Locals[11]=f.Pop();f.Pc=594;continue;}
case 594:{f.Push(f.Locals[4]);f.Pc=596;continue;}
case 596:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=597;continue;}
case 597:{f.Push(f.Locals[11]);f.Pc=599;continue;}
case 599:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 600:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10987(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/undo/UndoManager","mode","()Lforge/game/undo/UndoManager$Mode;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/game/undo/UndoManager$Mode","OFF","Lforge/game/undo/UndoManager$Mode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/UndoManager$Mode","OFF","Lforge/game/undo/UndoManager$Mode;"));f.Pc=7;continue;}
case 7:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?12:10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/undo/UndoManager","heapAllows","(Z)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int!=0?29:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("Low memory")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/undo/UndoManager","dropHistory","(Ljava/lang/String;)V","invokevirtual",27);}
case 27:{f.Push(JValue.R(null));f.Pc=28;continue;}
case 28:{return JStep.Return(f.Pop());}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/undo/GameMemento","capture","(Ljava/lang/Object;)Lforge/game/undo/GameMemento;","invokestatic",33);}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/undo/GameMemento","objectCount","()I","invokevirtual",39);}
case 39:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=40;continue;}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","lastObjects","J",value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","lastStandaloneCaptureBytes","J"));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","lastStandaloneCaptureBytes","J"));f.Pc=51;continue;}
case 51:{f.Push(JValue.L(8L));f.Pc=54;continue;}
case 54:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ldiv",a,b));f.Pc=55;continue;}
case 55:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=56;continue;}
case 56:{f.Locals[3]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/undo/GameMemento","captureBytes","()J","invokevirtual",62);}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/Math","max","(JJ)J","invokestatic",66);}
case 66:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","lastStandaloneCaptureBytes","J",value);f.Pc=69;continue;}
case 69:{if(!rt.EnsureInitialized(f,"forge/game/undo/UndoManager$Mark"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/undo/UndoManager$Mark")));f.Pc=72;continue;}
case 72:{f.StackOp("dup");f.Pc=73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/Game","getGameLog","()Lforge/game/GameLog;","invokevirtual",78);}
case 78:{return rt.Call(f,"forge/game/GameLog","size","()I","invokevirtual",81);}
case 81:{return rt.Call(f,"forge/game/undo/UndoManager$Mark","<init>","(Lforge/game/undo/GameMemento;I)V","invokespecial",84);}
case 84:{return JStep.Return(f.Pop());}
case 85:{f.Locals[2]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String("Low memory")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/undo/UndoManager","dropHistory","(Ljava/lang/String;)V","invokevirtual",93);}
case 93:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=96;continue;}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",100);}
case 100:{return rt.DynamicCall(f,"forge/game/undo/UndoManager:10987:100:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",105);}
case 105:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",108);}
case 108:{f.Push(JValue.R(null));f.Pc=109;continue;}
case 109:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10988(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventSnapshotRestored"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventSnapshotRestored")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/event/GameEventSnapshotRestored","<init>","(Z)V","invokespecial",15);}
case 15:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",18);}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/undo/UndoManager$Mark","memento","()Lforge/game/undo/GameMemento;","invokevirtual",22);}
case 22:{return rt.Call(f,"forge/game/undo/GameMemento","restore","()Z","invokevirtual",25);}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/Game","getGameLog","()Lforge/game/GameLog;","invokevirtual",31);}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/undo/UndoManager$Mark","logSize","()I","invokevirtual",35);}
case 35:{return rt.Call(f,"forge/game/GameLog","truncateTo","(I)V","invokevirtual",38);}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{f.Pc=f.Pop().Int==0?62:43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/undo/UndoManager$Mark","memento","()Lforge/game/undo/GameMemento;","invokevirtual",47);}
case 47:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","problems","Ljava/util/List;"));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",55);}
case 55:{f.Pc=f.Pop().Int==0?62:58;continue;}
case 58:{f.Push(JValue.I(1));f.Pc=59;continue;}
case 59:{f.Pc=63;continue;}
case 62:{f.Push(JValue.I(0));f.Pc=63;continue;}
case 63:{f.Locals[3]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{f.Pc=f.Pop().Int!=0?89:68;continue;}
case 68:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=71;continue;}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/undo/UndoManager$Mark","memento","()Lforge/game/undo/GameMemento;","invokevirtual",75);}
case 75:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","problems","Ljava/util/List;"));f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",81);}
case 81:{return rt.DynamicCall(f,"forge/game/undo/UndoManager:10988:81:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",86);}
case 86:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",89);}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/undo/UndoManager","refreshViews","(Lforge/game/Game;)V","invokestatic",93);}
case 93:{f.Push(f.Locals[1]);f.Pc=94;continue;}
case 94:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventSnapshotRestored"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventSnapshotRestored")));f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{f.Push(JValue.I(0));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/event/GameEventSnapshotRestored","<init>","(Z)V","invokespecial",102);}
case 102:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",105);}
case 105:{f.Pc=128;continue;}
case 108:{f.Locals[4]=f.Pop();f.Pc=110;continue;}
case 110:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=113;continue;}
case 113:{f.Push(f.Locals[4]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",118);}
case 118:{return rt.DynamicCall(f,"forge/game/undo/UndoManager:10988:118:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",123);}
case 123:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",126);}
case 126:{f.Push(JValue.I(0));f.Pc=127;continue;}
case 127:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 128:{f.Push(f.Locals[0]);f.Pc=129;continue;}
case 129:{f.StackOp("dup");f.Pc=130;continue;}
case 130:{f.Locals[4]=f.Pop();f.Pc=132;continue;}
case 132:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=133;continue;}
case 133:{f.Push(f.Locals[0]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/util/MyRandom","callCount","()J","invokestatic",137);}
case 137:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","randomMark","J",value);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[0]);f.Pc=141;continue;}
case 141:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/util/Deque","clear","()V","invokeinterface",149);}
case 149:{f.Push(f.Locals[0]);f.Pc=150;continue;}
case 150:{f.Push(JValue.R(rt.String("An action was taken back")));f.Pc=153;continue;}
case 153:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","barrierReason","Ljava/lang/String;",value);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[4]);f.Pc=158;continue;}
case 158:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=159;continue;}
case 159:{f.Pc=170;continue;}
case 162:{f.Locals[5]=f.Pop();f.Pc=164;continue;}
case 164:{f.Push(f.Locals[4]);f.Pc=166;continue;}
case 166:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=167;continue;}
case 167:{f.Push(f.Locals[5]);f.Pc=169;continue;}
case 169:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 170:{f.Push(f.Locals[3]);f.Pc=171;continue;}
case 171:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10989(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Deque","isEmpty","()Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int!=0?31:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Deque","size","()I","invokeinterface",23);}
case 23:{return rt.DynamicCall(f,"forge/game/undo/UndoManager:10989:23:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;I)Ljava/lang/String;",28);}
case 28:{return rt.Call(f,"forge/game/undo/UndoManager","debug","(Ljava/lang/String;)V","invokevirtual",31);}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Deque","clear","()V","invokeinterface",40);}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","barrierReason","Ljava/lang/String;",value);f.Pc=45;continue;}
case 45:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10990(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/undo/UndoManager","isOwner","(Lforge/game/player/Player;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int==0?19:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/undo/UndoManager","canUndo","()Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int==0?19:15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{f.Pc=20;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10991(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","mode","Lforge/game/undo/UndoManager$Mode;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/undo/UndoManager$Mode","OFF","Lforge/game/undo/UndoManager$Mode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/UndoManager$Mode","OFF","Lforge/game/undo/UndoManager$Mode;"));f.Pc=7;continue;}
case 7:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?27:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Deque","size","()I","invokeinterface",19);}
case 19:{f.Push(JValue.I(2));f.Pc=20;continue;}
case 20:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?27:23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Pc=28;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10992(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10993(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/undo/UndoManager","canUndo","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?9:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","mode","Lforge/game/undo/UndoManager$Mode;"));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/undo/UndoManager$Mode","OFF","Lforge/game/undo/UndoManager$Mode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/UndoManager$Mode","OFF","Lforge/game/undo/UndoManager$Mode;"));f.Pc=16;continue;}
case 16:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?22:19;continue;}
case 19:{f.Push(JValue.R(rt.String("Undo is off")));f.Pc=21;continue;}
case 21:{return JStep.Return(f.Pop());}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Deque","size","()I","invokeinterface",31);}
case 31:{f.Push(JValue.I(2));f.Pc=32;continue;}
case 32:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?41:35;continue;}
case 35:{f.Push(JValue.R(rt.String("No undos left this phase")));f.Pc=38;continue;}
case 38:{f.Pc=45;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","barrierReason","Ljava/lang/String;"));f.Pc=45;continue;}
case 45:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10994(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","requested","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10995(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","requested","Z"));f.Pc=4;continue;}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","requested","Z",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10996(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.StackOp("dup");f.Pc=2;continue;}
case 2:{f.Locals[3]=f.Pop();f.Pc=3;continue;}
case 3:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/undo/UndoManager","canUndo","()Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int!=0?15:11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Deque","pop","()Ljava/lang/Object;","invokeinterface",24);}
case 24:{f.StackOp("pop");f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Deque","peek","()Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/UndoManager$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{f.Locals[2]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","mode","Lforge/game/undo/UndoManager$Mode;"));f.Pc=42;continue;}
case 42:{if(!rt.StaticReady(f,"forge/game/undo/UndoManager$Mode","SINGLE_STEP","Lforge/game/undo/UndoManager$Mode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/UndoManager$Mode","SINGLE_STEP","Lforge/game/undo/UndoManager$Mode;"));f.Pc=45;continue;}
case 45:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?67:48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Deque","clear","()V","invokeinterface",57);}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Deque","push","(Ljava/lang/Object;)V","invokeinterface",67);}
case 67:{f.Push(f.Locals[3]);f.Pc=68;continue;}
case 68:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=69;continue;}
case 69:{f.Pc=79;continue;}
case 72:{f.Locals[4]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventSnapshotRestored"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventSnapshotRestored")));f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.I(1));f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/event/GameEventSnapshotRestored","<init>","(Z)V","invokespecial",88);}
case 88:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",91);}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/undo/UndoManager$Entry","memento","()Lforge/game/undo/GameMemento;","invokevirtual",95);}
case 95:{return rt.Call(f,"forge/game/undo/GameMemento","restore","()Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int!=0?159:101;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{f.StackOp("dup");f.Pc=103;continue;}
case 103:{f.Locals[3]=f.Pop();f.Pc=104;continue;}
case 104:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=105;continue;}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","stack","Ljava/util/Deque;"));f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/util/Deque","clear","()V","invokeinterface",114);}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.String("Undo history was lost")));f.Pc=118;continue;}
case 118:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","barrierReason","Ljava/lang/String;",value);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{f.Push(JValue.I(0));f.Pc=123;continue;}
case 123:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","justRestored","Z",value);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[3]);f.Pc=127;continue;}
case 127:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=128;continue;}
case 128:{f.Pc=138;continue;}
case 131:{f.Locals[5]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(f.Locals[3]);f.Pc=134;continue;}
case 134:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=135;continue;}
case 135:{f.Push(f.Locals[5]);f.Pc=137;continue;}
case 137:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager","recorder","Lforge/game/undo/GameMemento$Recorder;"));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/undo/GameMemento$Recorder","reset","()V","invokevirtual",145);}
case 145:{f.Push(f.Locals[1]);f.Pc=146;continue;}
case 146:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventSnapshotRestored"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventSnapshotRestored")));f.Pc=149;continue;}
case 149:{f.StackOp("dup");f.Pc=150;continue;}
case 150:{f.Push(JValue.I(0));f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/event/GameEventSnapshotRestored","<init>","(Z)V","invokespecial",154);}
case 154:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",157);}
case 157:{f.Push(JValue.I(0));f.Pc=158;continue;}
case 158:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 159:{f.Push(f.Locals[1]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/Game","getGameLog","()Lforge/game/GameLog;","invokevirtual",163);}
case 163:{f.Push(f.Locals[2]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/undo/UndoManager$Entry","logSize","()I","invokevirtual",167);}
case 167:{return rt.Call(f,"forge/game/GameLog","truncateTo","(I)V","invokevirtual",170);}
case 170:{f.Push(f.Locals[2]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/undo/UndoManager$Entry","memento","()Lforge/game/undo/GameMemento;","invokevirtual",174);}
case 174:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","problems","Ljava/util/List;"));f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",182);}
case 182:{f.Pc=f.Pop().Int!=0?206:185;continue;}
case 185:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=188;continue;}
case 188:{f.Push(f.Locals[2]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/undo/UndoManager$Entry","memento","()Lforge/game/undo/GameMemento;","invokevirtual",192);}
case 192:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento","problems","Ljava/util/List;"));f.Pc=195;continue;}
case 195:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",198);}
case 198:{return rt.DynamicCall(f,"forge/game/undo/UndoManager:10996:198:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",203);}
case 203:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",206);}
case 206:{f.Push(f.Locals[1]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/game/undo/UndoManager","refreshViews","(Lforge/game/Game;)V","invokestatic",210);}
case 210:{f.Push(f.Locals[1]);f.Pc=211;continue;}
case 211:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventSnapshotRestored"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventSnapshotRestored")));f.Pc=214;continue;}
case 214:{f.StackOp("dup");f.Pc=215;continue;}
case 215:{f.Push(JValue.I(0));f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/event/GameEventSnapshotRestored","<init>","(Z)V","invokespecial",219);}
case 219:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",222);}
case 222:{f.Push(f.Locals[0]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/util/MyRandom","callCount","()J","invokestatic",226);}
case 226:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","randomMark","J",value);f.Pc=229;continue;}
case 229:{f.Push(f.Locals[0]);f.Pc=230;continue;}
case 230:{f.Push(JValue.I(1));f.Pc=231;continue;}
case 231:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager","justRestored","Z",value);f.Pc=234;continue;}
case 234:{f.Push(JValue.I(1));f.Pc=235;continue;}
case 235:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10997(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/trigger/TriggerHandler","resetActiveTriggers","()V","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",14);}
case 14:{f.Locals[1]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?45:24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/player/Player","updateAllZonesForView","()V","invokevirtual",38);}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/player/Player","updateManaForView","()V","invokevirtual",42);}
case 42:{f.Pc=15;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/Game","updateStackForView","()V","invokevirtual",49);}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/Game","updatePhaseForView","()V","invokevirtual",53);}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/Game","updatePlayerTurnForView","()V","invokevirtual",57);}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/Game","updateTurnForView","()V","invokevirtual",61);}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",65);}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/Game","getCardsInGame","()Lforge/game/card/CardCollectionView;","invokevirtual",74);}
case 74:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Ljava/util/Collection;)V","invokespecial",77);}
case 77:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",80);}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventPlayerStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventPlayerStatsChanged")));f.Pc=84;continue;}
case 84:{f.StackOp("dup");f.Pc=85;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",89);}
case 89:{return rt.Call(f,"forge/game/event/GameEventPlayerStatsChanged","<init>","(Ljava/util/Collection;)V","invokespecial",92);}
case 92:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",95);}
case 95:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10998(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.L(1073741824L));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Runtime","getRuntime","()Ljava/lang/Runtime;","invokestatic",6);}
case 6:{return rt.Call(f,"java/lang/Runtime","maxMemory","()J","invokevirtual",9);}
case 9:{f.Push(JValue.L(7L));f.Pc=12;continue;}
case 12:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ldiv",a,b));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/Math","min","(JJ)J","invokestatic",16);}
case 16:{if(!rt.StaticReady(f,"forge/game/undo/UndoManager","MAX_RETAINED_BYTES","J"))return JStep.Continue;rt.PutStatic("forge/game/undo/UndoManager","MAX_RETAINED_BYTES","J",f.Pop());f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("forge.undo.debug")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/Boolean","getBoolean","(Ljava/lang/String;)Z","invokestatic",25);}
case 25:{if(!rt.StaticReady(f,"forge/game/undo/UndoManager","DEBUG","Z"))return JStep.Continue;rt.PutStatic("forge/game/undo/UndoManager","DEBUG","Z",f.Pop());f.Pc=28;continue;}
case 28:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

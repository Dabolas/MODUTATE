// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1035{
internal static JClass Build(){var c=new JClass("forge/game/undo/GameMemento$SeqDelta","forge/game/undo/GameMemento$UndoDelta",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("prefix","I",false,JValue.Default("I"),null));
c.Add(new JField("suffix","I",false,JValue.Default("I"),null));
c.Add(new JField("oldLength","I",false,JValue.Default("I"),null));
c.Add(new JField("oldMiddle","[Ljava/lang/Object;",false,JValue.Default("[Ljava/lang/Object;"),null));
c.Add(new JMethod(10966,"forge/game/undo/GameMemento$SeqDelta","<init>","(III[Ljava/lang/Object;)V",0,5,2,new JHandler[]{},M10966));
c.Add(new JMethod(10967,"forge/game/undo/GameMemento$SeqDelta","restore","(Lforge/game/undo/GameMemento$Snap;)Lforge/game/undo/GameMemento$Snap;",0,4,5,new JHandler[]{},M10967));
c.Add(new JMethod(10968,"forge/game/undo/GameMemento$SeqDelta","bytes","()J",0,1,4,new JHandler[]{},M10968));
}

internal static JStep M10966(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/undo/GameMemento$UndoDelta","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","prefix","I",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","suffix","I",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","oldLength","I",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","oldMiddle","[Ljava/lang/Object;",value);f.Pc=25;continue;}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10967(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$SeqSnap")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?15:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$SeqSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Pc=25;continue;}
case 15:{if(!rt.EnsureInitialized(f,"java/lang/IllegalStateException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalStateException")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("sequence snapshot kind changed")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/IllegalStateException","<init>","(Ljava/lang/String;)V","invokespecial",24);}
case 24:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=29;continue;}
case 29:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","oldLength","I"));f.Pc=34;continue;}
case 34:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?68:37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","oldMiddle","[Ljava/lang/Object;"));f.Pc=41;continue;}
case 41:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=42;continue;}
case 42:{f.Pc=f.Pop().Int<=0?66:45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","oldMiddle","[Ljava/lang/Object;"));f.Pc=49;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","prefix","I"));f.Pc=58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","oldMiddle","[Ljava/lang/Object;"));f.Pc=62;continue;}
case 62:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/System","arraycopy","(Ljava/lang/Object;ILjava/lang/Object;II)V","invokestatic",66);}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{return JStep.Return(f.Pop());}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","oldLength","I"));f.Pc=72;continue;}
case 72:{f.Pc=f.Pop().Int!=0?81:75;continue;}
case 75:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_OBJECTS","[Ljava/lang/Object;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","NO_OBJECTS","[Ljava/lang/Object;"));f.Pc=78;continue;}
case 78:{f.Pc=88;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","oldLength","I"));f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=88;continue;}
case 88:{f.Locals[3]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","prefix","I"));f.Pc=93;continue;}
case 93:{f.Pc=f.Pop().Int<=0?110:96;continue;}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=100;continue;}
case 100:{f.Push(JValue.I(0));f.Pc=101;continue;}
case 101:{f.Push(f.Locals[3]);f.Pc=102;continue;}
case 102:{f.Push(JValue.I(0));f.Pc=103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","prefix","I"));f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/lang/System","arraycopy","(Ljava/lang/Object;ILjava/lang/Object;II)V","invokestatic",110);}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","oldMiddle","[Ljava/lang/Object;"));f.Pc=114;continue;}
case 114:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=115;continue;}
case 115:{f.Pc=f.Pop().Int<=0?136:118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","oldMiddle","[Ljava/lang/Object;"));f.Pc=122;continue;}
case 122:{f.Push(JValue.I(0));f.Pc=123;continue;}
case 123:{f.Push(f.Locals[3]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","prefix","I"));f.Pc=128;continue;}
case 128:{f.Push(f.Locals[0]);f.Pc=129;continue;}
case 129:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","oldMiddle","[Ljava/lang/Object;"));f.Pc=132;continue;}
case 132:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/lang/System","arraycopy","(Ljava/lang/Object;ILjava/lang/Object;II)V","invokestatic",136);}
case 136:{f.Push(f.Locals[0]);f.Pc=137;continue;}
case 137:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","suffix","I"));f.Pc=140;continue;}
case 140:{f.Pc=f.Pop().Int<=0?174:143;continue;}
case 143:{f.Push(f.Locals[2]);f.Pc=144;continue;}
case 144:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=147;continue;}
case 147:{f.Push(f.Locals[2]);f.Pc=148;continue;}
case 148:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=151;continue;}
case 151:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=152;continue;}
case 152:{f.Push(f.Locals[0]);f.Pc=153;continue;}
case 153:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","suffix","I"));f.Pc=156;continue;}
case 156:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=157;continue;}
case 157:{f.Push(f.Locals[3]);f.Pc=158;continue;}
case 158:{f.Push(f.Locals[0]);f.Pc=159;continue;}
case 159:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","oldLength","I"));f.Pc=162;continue;}
case 162:{f.Push(f.Locals[0]);f.Pc=163;continue;}
case 163:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","suffix","I"));f.Pc=166;continue;}
case 166:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=167;continue;}
case 167:{f.Push(f.Locals[0]);f.Pc=168;continue;}
case 168:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","suffix","I"));f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/lang/System","arraycopy","(Ljava/lang/Object;ILjava/lang/Object;II)V","invokestatic",174);}
case 174:{if(!rt.EnsureInitialized(f,"forge/game/undo/GameMemento$SeqSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/undo/GameMemento$SeqSnap")));f.Pc=177;continue;}
case 177:{f.StackOp("dup");f.Pc=178;continue;}
case 178:{f.Push(f.Locals[3]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/undo/GameMemento$SeqSnap","<init>","([Ljava/lang/Object;)V","invokespecial",182);}
case 182:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10968(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.L(32L));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqDelta","oldMiddle","[Ljava/lang/Object;"));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/undo/GameMemento","arr","(I)J","invokestatic",11);}
case 11:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

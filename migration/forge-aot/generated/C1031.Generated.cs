// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1031{
internal static JClass Build(){var c=new JClass("forge/game/undo/GameMemento$ObjDelta","forge/game/undo/GameMemento$UndoDelta",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("ci","Lforge/game/undo/GameMemento$ClassInfo;",false,JValue.Default("Lforge/game/undo/GameMemento$ClassInfo;"),null));
c.Add(new JField("refIndexes","[I",false,JValue.Default("[I"),null));
c.Add(new JField("oldRefs","[Ljava/lang/Object;",false,JValue.Default("[Ljava/lang/Object;"),null));
c.Add(new JField("primIndexes","[I",false,JValue.Default("[I"),null));
c.Add(new JField("oldPrims","[J",false,JValue.Default("[J"),null));
c.Add(new JMethod(10923,"forge/game/undo/GameMemento$ObjDelta","<init>","(Lforge/game/undo/GameMemento$ClassInfo;[I[Ljava/lang/Object;[I[J)V",0,6,2,new JHandler[]{},M10923));
c.Add(new JMethod(10924,"forge/game/undo/GameMemento$ObjDelta","restore","(Lforge/game/undo/GameMemento$Snap;)Lforge/game/undo/GameMemento$Snap;",0,4,4,new JHandler[]{},M10924));
c.Add(new JMethod(10925,"forge/game/undo/GameMemento$ObjDelta","intArrayBytes","(I)J",10,1,6,new JHandler[]{},M10925));
c.Add(new JMethod(10926,"forge/game/undo/GameMemento$ObjDelta","longArrayBytes","(I)J",10,1,6,new JHandler[]{},M10926));
c.Add(new JMethod(10927,"forge/game/undo/GameMemento$ObjDelta","estimatedBytes","(II)J",8,2,4,new JHandler[]{},M10927));
c.Add(new JMethod(10928,"forge/game/undo/GameMemento$ObjDelta","bytes","()J",0,1,2,new JHandler[]{},M10928));
}

internal static JStep M10923(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/undo/GameMemento$UndoDelta","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$ObjDelta","ci","Lforge/game/undo/GameMemento$ClassInfo;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$ObjDelta","refIndexes","[I",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$ObjDelta","oldRefs","[Ljava/lang/Object;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$ObjDelta","primIndexes","[I",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$ObjDelta","oldPrims","[J",value);f.Pc=31;continue;}
case 31:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10924(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$ObjSnap")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?23:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$ObjSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","ci","Lforge/game/undo/GameMemento$ClassInfo;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjDelta","ci","Lforge/game/undo/GameMemento$ClassInfo;"));f.Pc=20;continue;}
case 20:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?33:23;continue;}
case 23:{if(!rt.EnsureInitialized(f,"java/lang/IllegalStateException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalStateException")));f.Pc=26;continue;}
case 26:{f.StackOp("dup");f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("object snapshot kind changed")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/IllegalStateException","<init>","(Ljava/lang/String;)V","invokespecial",32);}
case 32:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjDelta","refIndexes","[I"));f.Pc=40;continue;}
case 40:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=41;continue;}
case 41:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?67:44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","refs","[Ljava/lang/Object;"));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjDelta","refIndexes","[I"));f.Pc=52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjDelta","oldRefs","[Ljava/lang/Object;"));f.Pc=58;continue;}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=60;continue;}
case 60:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=61;continue;}
case 61:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=64;continue;}
case 64:{f.Pc=35;continue;}
case 67:{f.Push(JValue.I(0));f.Pc=68;continue;}
case 68:{f.Locals[3]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjDelta","primIndexes","[I"));f.Pc=74;continue;}
case 74:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=75;continue;}
case 75:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?101:78;continue;}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","prims","[J"));f.Pc=82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjDelta","primIndexes","[I"));f.Pc=86;continue;}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjDelta","oldPrims","[J"));f.Pc=92;continue;}
case 92:{f.Push(f.Locals[3]);f.Pc=93;continue;}
case 93:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=94;continue;}
case 94:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=95;continue;}
case 95:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=98;continue;}
case 98:{f.Pc=69;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10925(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int!=0?8:4;continue;}
case 4:{f.Push(JValue.L(0));f.Pc=5;continue;}
case 5:{f.Pc=18;continue;}
case 8:{f.Push(JValue.L(16L));f.Pc=11;continue;}
case 11:{f.Push(JValue.L(4L));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=16;continue;}
case 16:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lmul",a,b));f.Pc=17;continue;}
case 17:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=18;continue;}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10926(JRuntime rt,JFrame f)
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

internal static JStep M10927(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.L(32L));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/undo/GameMemento$ObjDelta","intArrayBytes","(I)J","invokestatic",7);}
case 7:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/undo/GameMemento","arr","(I)J","invokestatic",12);}
case 12:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/undo/GameMemento$ObjDelta","intArrayBytes","(I)J","invokestatic",17);}
case 17:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/undo/GameMemento$ObjDelta","longArrayBytes","(I)J","invokestatic",22);}
case 22:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=23;continue;}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10928(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjDelta","oldRefs","[Ljava/lang/Object;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjDelta","oldPrims","[J"));f.Pc=9;continue;}
case 9:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/undo/GameMemento$ObjDelta","estimatedBytes","(II)J","invokestatic",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

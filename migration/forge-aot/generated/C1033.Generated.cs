// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1033{
internal static JClass Build(){var c=new JClass("forge/game/undo/GameMemento$PrimArrSnap","forge/game/undo/GameMemento$Snap",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("copy","Ljava/lang/Object;",false,JValue.Default("Ljava/lang/Object;"),null));
c.Add(new JMethod(10931,"forge/game/undo/GameMemento$PrimArrSnap","<init>","(Ljava/lang/Object;)V",0,2,2,new JHandler[]{},M10931));
c.Add(new JMethod(10932,"forge/game/undo/GameMemento$PrimArrSnap","bytes","()J",0,2,6,new JHandler[]{},M10932));
}

internal static JStep M10931(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/undo/GameMemento$Snap","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$PrimArrSnap","copy","Ljava/lang/Object;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10932(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$PrimArrSnap","copy","Ljava/lang/Object;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[J")?1:0));f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Int!=0?20:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$PrimArrSnap","copy","Ljava/lang/Object;"));f.Pc=14;continue;}
case 14:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[D")?1:0));f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Int==0?25:20;continue;}
case 20:{f.Push(JValue.I(8));f.Pc=22;continue;}
case 22:{f.Pc=74;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$PrimArrSnap","copy","Ljava/lang/Object;"));f.Pc=29;continue;}
case 29:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[I")?1:0));f.Pc=32;continue;}
case 32:{f.Pc=f.Pop().Int!=0?45:35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$PrimArrSnap","copy","Ljava/lang/Object;"));f.Pc=39;continue;}
case 39:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[F")?1:0));f.Pc=42;continue;}
case 42:{f.Pc=f.Pop().Int==0?49:45;continue;}
case 45:{f.Push(JValue.I(4));f.Pc=46;continue;}
case 46:{f.Pc=74;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$PrimArrSnap","copy","Ljava/lang/Object;"));f.Pc=53;continue;}
case 53:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[S")?1:0));f.Pc=56;continue;}
case 56:{f.Pc=f.Pop().Int!=0?69:59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$PrimArrSnap","copy","Ljava/lang/Object;"));f.Pc=63;continue;}
case 63:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"[C")?1:0));f.Pc=66;continue;}
case 66:{f.Pc=f.Pop().Int==0?73:69;continue;}
case 69:{f.Push(JValue.I(2));f.Pc=70;continue;}
case 70:{f.Pc=74;continue;}
case 73:{f.Push(JValue.I(1));f.Pc=74;continue;}
case 74:{f.Locals[1]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(JValue.L(32L));f.Pc=78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$PrimArrSnap","copy","Ljava/lang/Object;"));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/reflect/Array","getLength","(Ljava/lang/Object;)I","invokestatic",85);}
case 85:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=88;continue;}
case 88:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lmul",a,b));f.Pc=89;continue;}
case 89:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=90;continue;}
case 90:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

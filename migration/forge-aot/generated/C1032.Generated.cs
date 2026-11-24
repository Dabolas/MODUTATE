// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1032{
internal static JClass Build(){var c=new JClass("forge/game/undo/GameMemento$ObjSnap","forge/game/undo/GameMemento$Snap",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("ci","Lforge/game/undo/GameMemento$ClassInfo;",false,JValue.Default("Lforge/game/undo/GameMemento$ClassInfo;"),null));
c.Add(new JField("refs","[Ljava/lang/Object;",false,JValue.Default("[Ljava/lang/Object;"),null));
c.Add(new JField("prims","[J",false,JValue.Default("[J"),null));
c.Add(new JMethod(10929,"forge/game/undo/GameMemento$ObjSnap","<init>","(Lforge/game/undo/GameMemento$ClassInfo;[Ljava/lang/Object;[J)V",0,4,2,new JHandler[]{},M10929));
c.Add(new JMethod(10930,"forge/game/undo/GameMemento$ObjSnap","bytes","()J",0,1,4,new JHandler[]{},M10930));
}

internal static JStep M10929(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/undo/GameMemento$Snap","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","ci","Lforge/game/undo/GameMemento$ClassInfo;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","refs","[Ljava/lang/Object;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","prims","[J",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10930(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.L(24L));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","refs","[Ljava/lang/Object;"));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/undo/GameMemento","arr","(I)J","invokestatic",11);}
case 11:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","prims","[J"));f.Pc=16;continue;}
case 16:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/undo/GameMemento","arr","(I)J","invokestatic",20);}
case 20:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=21;continue;}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1036{
internal static JClass Build(){var c=new JClass("forge/game/undo/GameMemento$SeqSnap","forge/game/undo/GameMemento$Snap",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("items","[Ljava/lang/Object;",false,JValue.Default("[Ljava/lang/Object;"),null));
c.Add(new JMethod(10969,"forge/game/undo/GameMemento$SeqSnap","<init>","([Ljava/lang/Object;)V",0,2,2,new JHandler[]{},M10969));
c.Add(new JMethod(10970,"forge/game/undo/GameMemento$SeqSnap","bytes","()J",0,1,4,new JHandler[]{},M10970));
}

internal static JStep M10969(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/undo/GameMemento$Snap","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10970(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.L(16L));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/undo/GameMemento","arr","(I)J","invokestatic",11);}
case 11:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

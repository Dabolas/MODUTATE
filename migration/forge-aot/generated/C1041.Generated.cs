// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1041{
internal static JClass Build(){var c=new JClass("forge/game/undo/UndoManager$Mark","java/lang/Record",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("memento","Lforge/game/undo/GameMemento;",false,JValue.Default("Lforge/game/undo/GameMemento;"),null));
c.Add(new JField("logSize","I",false,JValue.Default("I"),null));
c.Add(new JMethod(11005,"forge/game/undo/UndoManager$Mark","<init>","(Lforge/game/undo/GameMemento;I)V",1,3,2,new JHandler[]{},M11005));
c.Add(new JMethod(11006,"forge/game/undo/UndoManager$Mark","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M11006));
c.Add(new JMethod(11007,"forge/game/undo/UndoManager$Mark","hashCode","()I",17,1,1,new JHandler[]{},M11007));
c.Add(new JMethod(11008,"forge/game/undo/UndoManager$Mark","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M11008));
c.Add(new JMethod(11009,"forge/game/undo/UndoManager$Mark","memento","()Lforge/game/undo/GameMemento;",1,1,1,new JHandler[]{},M11009));
c.Add(new JMethod(11010,"forge/game/undo/UndoManager$Mark","logSize","()I",1,1,1,new JHandler[]{},M11010));
}

internal static JStep M11005(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager$Mark","memento","Lforge/game/undo/GameMemento;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager$Mark","logSize","I",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11006(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/undo/UndoManager$Mark:11006:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/undo/UndoManager$Mark;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11007(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/undo/UndoManager$Mark:11007:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/undo/UndoManager$Mark;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11008(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/undo/UndoManager$Mark:11008:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/undo/UndoManager$Mark;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11009(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager$Mark","memento","Lforge/game/undo/GameMemento;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11010(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager$Mark","logSize","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1040{
internal static JClass Build(){var c=new JClass("forge/game/undo/UndoManager$Entry","java/lang/Record",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("memento","Lforge/game/undo/GameMemento;",false,JValue.Default("Lforge/game/undo/GameMemento;"),null));
c.Add(new JField("logSize","I",false,JValue.Default("I"),null));
c.Add(new JMethod(10999,"forge/game/undo/UndoManager$Entry","<init>","(Lforge/game/undo/GameMemento;I)V",2,3,2,new JHandler[]{},M10999));
c.Add(new JMethod(11000,"forge/game/undo/UndoManager$Entry","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M11000));
c.Add(new JMethod(11001,"forge/game/undo/UndoManager$Entry","hashCode","()I",17,1,1,new JHandler[]{},M11001));
c.Add(new JMethod(11002,"forge/game/undo/UndoManager$Entry","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M11002));
c.Add(new JMethod(11003,"forge/game/undo/UndoManager$Entry","memento","()Lforge/game/undo/GameMemento;",1,1,1,new JHandler[]{},M11003));
c.Add(new JMethod(11004,"forge/game/undo/UndoManager$Entry","logSize","()I",1,1,1,new JHandler[]{},M11004));
}

internal static JStep M10999(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager$Entry","memento","Lforge/game/undo/GameMemento;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/UndoManager$Entry","logSize","I",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11000(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/undo/UndoManager$Entry:11000:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/undo/UndoManager$Entry;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11001(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/undo/UndoManager$Entry:11001:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/undo/UndoManager$Entry;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11002(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/undo/UndoManager$Entry:11002:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/undo/UndoManager$Entry;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11003(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager$Entry","memento","Lforge/game/undo/GameMemento;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11004(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/UndoManager$Entry","logSize","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

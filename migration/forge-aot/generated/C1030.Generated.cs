// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1030{
internal static JClass Build(){var c=new JClass("forge/game/undo/GameMemento$Node","java/lang/Object",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("obj","Ljava/lang/Object;",false,JValue.Default("Ljava/lang/Object;"),null));
c.Add(new JField("isObj","Z",false,JValue.Default("Z"),null));
c.Add(new JField("snap","Lforge/game/undo/GameMemento$Snap;",false,JValue.Default("Lforge/game/undo/GameMemento$Snap;"),null));
c.Add(new JField("gen","I",false,JValue.Default("I"),null));
c.Add(new JField("idx","I",false,JValue.Default("I"),null));
c.Add(new JMethod(10922,"forge/game/undo/GameMemento$Node","<init>","(Ljava/lang/Object;Z)V",0,3,2,new JHandler[]{},M10922));
}

internal static JStep M10922(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Node","obj","Ljava/lang/Object;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/undo/GameMemento$Node","isObj","Z",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

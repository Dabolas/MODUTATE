// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1028{
internal static JClass Build(){var c=new JClass("forge/game/undo/GameMemento$HistoryData","java/lang/Object",new string[]{},1056);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10915,"forge/game/undo/GameMemento$HistoryData","<init>","()V",2,1,1,new JHandler[]{},M10915));
c.Add(new JMethod(10916,"forge/game/undo/GameMemento$HistoryData","bytes","()J",1024,0,0,new JHandler[]{},null));
}

internal static JStep M10915(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

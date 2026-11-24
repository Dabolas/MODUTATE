// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C93{
internal static JClass Build(){var c=new JClass("forge/deck/DeckFormat$4","forge/deck/DeckFormat",new string[]{},16432);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(1484,"forge/deck/DeckFormat$4","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;I)V",2,6,6,new JHandler[]{},M1484));
c.Add(new JMethod(1485,"forge/deck/DeckFormat$4","allowCustomCards","()Z",1,1,1,new JHandler[]{},M1485));
}

internal static JStep M1484(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[5]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/deck/DeckFormat","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;I)V","invokespecial",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1485(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

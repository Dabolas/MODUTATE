// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C2{
internal static JClass Build(){var c=new JClass("forge/CardStorageReader$ProgressObserver$1","java/lang/Object",new string[]{"forge/CardStorageReader$ProgressObserver"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(24,"forge/CardStorageReader$ProgressObserver$1","<init>","()V",0,1,1,new JHandler[]{},M24));
c.Add(new JMethod(25,"forge/CardStorageReader$ProgressObserver$1","setOperationName","(Ljava/lang/String;Z)V",1,3,0,new JHandler[]{},M25));
c.Add(new JMethod(26,"forge/CardStorageReader$ProgressObserver$1","report","(II)V",1,3,0,new JHandler[]{},M26));
}

internal static JStep M24(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M25(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M26(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

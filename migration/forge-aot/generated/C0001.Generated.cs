// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1{
internal static JClass Build(){var c=new JClass("forge/CardStorageReader$ProgressObserver","java/lang/Object",new string[]{},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("emptyObserver","Lforge/CardStorageReader$ProgressObserver;",true,JValue.Default("Lforge/CardStorageReader$ProgressObserver;"),null));
c.Add(new JMethod(21,"forge/CardStorageReader$ProgressObserver","setOperationName","(Ljava/lang/String;Z)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(22,"forge/CardStorageReader$ProgressObserver","report","(II)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(23,"forge/CardStorageReader$ProgressObserver","<clinit>","()V",8,0,2,new JHandler[]{},M23));
}

internal static JStep M23(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/CardStorageReader$ProgressObserver$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/CardStorageReader$ProgressObserver$1")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/CardStorageReader$ProgressObserver$1","<init>","()V","invokespecial",7);}
case 7:{if(!rt.StaticReady(f,"forge/CardStorageReader$ProgressObserver","emptyObserver","Lforge/CardStorageReader$ProgressObserver;"))return JStep.Continue;rt.PutStatic("forge/CardStorageReader$ProgressObserver","emptyObserver","Lforge/CardStorageReader$ProgressObserver;",f.Pop());f.Pc=10;continue;}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

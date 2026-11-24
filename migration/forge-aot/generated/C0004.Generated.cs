// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C4{
internal static JClass Build(){var c=new JClass("forge/GameCommand","java/lang/Object",new string[]{"java/io/Serializable","java/lang/Runnable"},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("BLANK","Lforge/GameCommand;",true,JValue.Default("Lforge/GameCommand;"),null));
c.Add(new JMethod(35,"forge/GameCommand","<clinit>","()V",8,0,2,new JHandler[]{},M35));
}

internal static JStep M35(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/GameCommand$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/GameCommand$1")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/GameCommand$1","<init>","()V","invokespecial",7);}
case 7:{if(!rt.StaticReady(f,"forge/GameCommand","BLANK","Lforge/GameCommand;"))return JStep.Continue;rt.PutStatic("forge/GameCommand","BLANK","Lforge/GameCommand;",f.Pop());f.Pc=10;continue;}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

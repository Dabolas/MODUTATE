// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1104{
internal static JClass Build(){var c=new JClass("forge/util/AITimeoutTracker$Limit","java/lang/Object",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("armed","Z",false,JValue.Default("Z"),null));
c.Add(new JField("honourInterrupt","Z",false,JValue.Default("Z"),null));
c.Add(new JField("deadlineNanos","J",false,JValue.Default("J"),null));
c.Add(new JMethod(11623,"forge/util/AITimeoutTracker$Limit","<init>","()V",2,1,1,new JHandler[]{},M11623));
}

internal static JStep M11623(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

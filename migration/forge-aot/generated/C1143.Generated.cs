// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1143{
internal static JClass Build(){var c=new JClass("forge/util/MyRandom$1","java/lang/InheritableThreadLocal",new string[]{},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(11964,"forge/util/MyRandom$1","<init>","()V",0,1,1,new JHandler[]{},M11964));
c.Add(new JMethod(11965,"forge/util/MyRandom$1","initialValue","()Lforge/util/MyRandom$CountingRandom;",4,1,4,new JHandler[]{},M11965));
c.Add(new JMethod(11966,"forge/util/MyRandom$1","initialValue","()Ljava/lang/Object;",4164,1,1,new JHandler[]{},M11966));
}

internal static JStep M11964(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/InheritableThreadLocal","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11965(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/MyRandom$CountingRandom"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/MyRandom$CountingRandom")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"java/security/SecureRandom"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/security/SecureRandom")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/security/SecureRandom","<init>","()V","invokespecial",11);}
case 11:{return rt.Call(f,"forge/util/MyRandom$CountingRandom","<init>","(Ljava/util/Random;)V","invokespecial",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11966(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/MyRandom$1","initialValue","()Lforge/util/MyRandom$CountingRandom;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

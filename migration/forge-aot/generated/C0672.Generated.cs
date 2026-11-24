// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C672{
internal static JClass Build(){var c=new JClass("forge/game/keyword/SimpleKeyword","forge/game/keyword/KeywordInstance",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(7659,"forge/game/keyword/SimpleKeyword","<init>","()V",1,1,1,new JHandler[]{},M7659));
c.Add(new JMethod(7660,"forge/game/keyword/SimpleKeyword","getTitle","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7660));
c.Add(new JMethod(7661,"forge/game/keyword/SimpleKeyword","parse","(Ljava/lang/String;)V",4,2,0,new JHandler[]{},M7661));
c.Add(new JMethod(7662,"forge/game/keyword/SimpleKeyword","formatReminderText","(Ljava/lang/String;)Ljava/lang/String;",4,2,1,new JHandler[]{},M7662));
}

internal static JStep M7659(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInstance","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7660(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/SimpleKeyword","getKeyword","()Lforge/game/keyword/Keyword;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/keyword/Keyword","toString","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7661(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7662(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

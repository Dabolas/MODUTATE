// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C666{
internal static JClass Build(){var c=new JClass("forge/game/keyword/Landwalk","forge/game/keyword/KeywordWithType",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(7638,"forge/game/keyword/Landwalk","<init>","()V",1,1,1,new JHandler[]{},M7638));
c.Add(new JMethod(7639,"forge/game/keyword/Landwalk","getTitle","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7639));
}

internal static JStep M7638(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordWithType","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7639(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/Landwalk","getTypeDescription","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return rt.DynamicCall(f,"forge/game/keyword/Landwalk:7639:4:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

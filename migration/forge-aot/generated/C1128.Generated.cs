// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1128{
internal static JClass Build(){var c=new JClass("forge/util/ITranslatable","java/lang/Object",new string[]{"forge/util/IHasName"},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(11782,"forge/util/ITranslatable","getTranslationKey","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11782));
c.Add(new JMethod(11783,"forge/util/ITranslatable","getUntranslatedName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11783));
c.Add(new JMethod(11784,"forge/util/ITranslatable","getTranslatedName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11784));
c.Add(new JMethod(11785,"forge/util/ITranslatable","getUntranslatedType","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11785));
}

internal static JStep M11782(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/ITranslatable","getName","()Ljava/lang/String;","invokeinterface",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11783(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/ITranslatable","getName","()Ljava/lang/String;","invokeinterface",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11784(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/ITranslatable","getName","()Ljava/lang/String;","invokeinterface",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11785(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

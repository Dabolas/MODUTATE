// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1187{
internal static JClass Build(){var c=new JClass("forge/util/lang/LangChinese","forge/util/Lang",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(12381,"forge/util/lang/LangChinese","<init>","()V",1,1,1,new JHandler[]{},M12381));
c.Add(new JMethod(12382,"forge/util/lang/LangChinese","getOrdinal","(I)Ljava/lang/String;",1,2,1,new JHandler[]{},M12382));
c.Add(new JMethod(12383,"forge/util/lang/LangChinese","getPossesive","(Ljava/lang/String;)Ljava/lang/String;",1,2,1,new JHandler[]{},M12383));
c.Add(new JMethod(12384,"forge/util/lang/LangChinese","getPossessedObject","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1,3,2,new JHandler[]{},M12384));
c.Add(new JMethod(12385,"forge/util/lang/LangChinese","getNickName","(Ljava/lang/String;)Ljava/lang/String;",1,2,1,new JHandler[]{},M12385));
c.Add(new JMethod(12386,"forge/util/lang/LangChinese","getFontFile","()Ljava/lang/String;",1,1,1,new JHandler[]{},M12386));
c.Add(new JMethod(12387,"forge/util/lang/LangChinese","canDisplayCheck","()C",1,1,1,new JHandler[]{},M12387));
}

internal static JStep M12381(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/Lang","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12382(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/util/lang/LangChinese:12382:1:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12383(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/util/lang/LangChinese:12383:1:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12384(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/lang/LangChinese","getPossesive","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.DynamicCall(f,"forge/util/lang/LangChinese:12384:6:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12385(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12386(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("SourceHanSansCN")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12387(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(40555));f.Pc=2;continue;}
case 2:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1194{
internal static JClass Build(){var c=new JClass("forge/util/lang/LangRussian","forge/util/Lang",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(12418,"forge/util/lang/LangRussian","<init>","()V",1,1,1,new JHandler[]{},M12418));
c.Add(new JMethod(12419,"forge/util/lang/LangRussian","getOrdinal","(I)Ljava/lang/String;",1,2,1,new JHandler[]{},M12419));
c.Add(new JMethod(12420,"forge/util/lang/LangRussian","getPossesive","(Ljava/lang/String;)Ljava/lang/String;",1,2,2,new JHandler[]{},M12420));
c.Add(new JMethod(12421,"forge/util/lang/LangRussian","getPossessedObject","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1,3,2,new JHandler[]{},M12421));
c.Add(new JMethod(12422,"forge/util/lang/LangRussian","getFontFile","()Ljava/lang/String;",1,1,1,new JHandler[]{},M12422));
}

internal static JStep M12418(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/Lang","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12419(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/util/lang/LangRussian:12419:1:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12420(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("You")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?12:9;continue;}
case 9:{f.Push(JValue.R(rt.String("\u0412\u0430\u0448")));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12421(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("You")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?21:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/util/lang/LangRussian","getPossesive","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.DynamicCall(f,"forge/util/lang/LangRussian:12421:15:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",20);}
case 20:{return JStep.Return(f.Pop());}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.DynamicCall(f,"forge/util/lang/LangRussian:12421:23:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",28);}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12422(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Roboto-Bold")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1190{
internal static JClass Build(){var c=new JClass("forge/util/lang/LangGerman","forge/util/Lang",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(12396,"forge/util/lang/LangGerman","<init>","()V",1,1,1,new JHandler[]{},M12396));
c.Add(new JMethod(12397,"forge/util/lang/LangGerman","getOrdinal","(I)Ljava/lang/String;",1,2,2,new JHandler[]{},M12397));
c.Add(new JMethod(12398,"forge/util/lang/LangGerman","getPossesive","(Ljava/lang/String;)Ljava/lang/String;",1,2,2,new JHandler[]{},M12398));
c.Add(new JMethod(12399,"forge/util/lang/LangGerman","getPossessedObject","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1,3,2,new JHandler[]{},M12399));
}

internal static JStep M12396(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/Lang","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12397(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(20));f.Pc=3;continue;}
case 3:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?13:6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.DynamicCall(f,"forge/util/lang/LangGerman:12397:7:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",12);}
case 12:{return JStep.Return(f.Pop());}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.DynamicCall(f,"forge/util/lang/LangGerman:12397:14:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",19);}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12398(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("You")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?16:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.DynamicCall(f,"forge/util/lang/LangGerman:12398:10:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",15);}
case 15:{return JStep.Return(f.Pop());}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("s")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?34:25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.DynamicCall(f,"forge/util/lang/LangGerman:12398:26:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",31);}
case 31:{f.Pc=40;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.DynamicCall(f,"forge/util/lang/LangGerman:12398:35:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",40);}
case 40:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12399(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/lang/LangGerman","getPossesive","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.DynamicCall(f,"forge/util/lang/LangGerman:12399:6:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

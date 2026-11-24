// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1193{
internal static JClass Build(){var c=new JClass("forge/util/lang/LangKorean","forge/util/Lang",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(12411,"forge/util/lang/LangKorean","<init>","()V",1,1,1,new JHandler[]{},M12411));
c.Add(new JMethod(12412,"forge/util/lang/LangKorean","getOrdinal","(I)Ljava/lang/String;",1,2,1,new JHandler[]{},M12412));
c.Add(new JMethod(12413,"forge/util/lang/LangKorean","getPossesive","(Ljava/lang/String;)Ljava/lang/String;",1,2,2,new JHandler[]{},M12413));
c.Add(new JMethod(12414,"forge/util/lang/LangKorean","getPossessedObject","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1,3,2,new JHandler[]{},M12414));
c.Add(new JMethod(12415,"forge/util/lang/LangKorean","getNickName","(Ljava/lang/String;)Ljava/lang/String;",1,3,2,new JHandler[]{},M12415));
c.Add(new JMethod(12416,"forge/util/lang/LangKorean","getFontFile","()Ljava/lang/String;",1,1,1,new JHandler[]{},M12416));
c.Add(new JMethod(12417,"forge/util/lang/LangKorean","canDisplayCheck","()C",1,1,1,new JHandler[]{},M12417));
}

internal static JStep M12411(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/Lang","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12412(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/util/lang/LangKorean:12412:1:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12413(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("\ub2f9\uc2e0")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int!=0?18:9;continue;}
case 9:{f.Push(JValue.R(rt.String("You")));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?21:18;continue;}
case 18:{f.Push(JValue.R(rt.String("\ub2f9\uc2e0\uc758")));f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.DynamicCall(f,"forge/util/lang/LangKorean:12413:22:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",27);}
case 27:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12414(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/lang/LangKorean","getPossesive","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.DynamicCall(f,"forge/util/lang/LangKorean:12414:6:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12415(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String(",")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?20:13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",19);}
case 19:{return JStep.Return(f.Pop());}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12416(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("SourceHanSansKR")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12417(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(51704));f.Pc=2;continue;}
case 2:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

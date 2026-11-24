// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C644{
internal static JClass Build(){var c=new JClass("forge/game/keyword/DefaultKeywordView","java/lang/Record",new string[]{"forge/game/keyword/KeywordView"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("original","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("keyword","Lforge/game/keyword/Keyword;",false,JValue.Default("Lforge/game/keyword/Keyword;"),null));
c.Add(new JField("title","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("reminderText","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(7405,"forge/game/keyword/DefaultKeywordView","<init>","(Ljava/lang/String;Lforge/game/keyword/Keyword;Ljava/lang/String;Ljava/lang/String;)V",1,5,2,new JHandler[]{},M7405));
c.Add(new JMethod(7406,"forge/game/keyword/DefaultKeywordView","toString","()Ljava/lang/String;",1,1,2,new JHandler[]{},M7406));
c.Add(new JMethod(7407,"forge/game/keyword/DefaultKeywordView","hashCode","()I",17,1,1,new JHandler[]{},M7407));
c.Add(new JMethod(7408,"forge/game/keyword/DefaultKeywordView","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M7408));
c.Add(new JMethod(7409,"forge/game/keyword/DefaultKeywordView","original","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7409));
c.Add(new JMethod(7410,"forge/game/keyword/DefaultKeywordView","keyword","()Lforge/game/keyword/Keyword;",1,1,1,new JHandler[]{},M7410));
c.Add(new JMethod(7411,"forge/game/keyword/DefaultKeywordView","title","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7411));
c.Add(new JMethod(7412,"forge/game/keyword/DefaultKeywordView","reminderText","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7412));
}

internal static JStep M7405(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/DefaultKeywordView","original","Ljava/lang/String;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/DefaultKeywordView","keyword","Lforge/game/keyword/Keyword;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/DefaultKeywordView","title","Ljava/lang/String;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/DefaultKeywordView","reminderText","Ljava/lang/String;",value);f.Pc=25;continue;}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7406(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/DefaultKeywordView","title","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/DefaultKeywordView","reminderText","Ljava/lang/String;"));f.Pc=8;continue;}
case 8:{return rt.DynamicCall(f,"forge/game/keyword/DefaultKeywordView:7406:8:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7407(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/keyword/DefaultKeywordView:7407:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/keyword/DefaultKeywordView;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7408(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/keyword/DefaultKeywordView:7408:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/keyword/DefaultKeywordView;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7409(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/DefaultKeywordView","original","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7410(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/DefaultKeywordView","keyword","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7411(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/DefaultKeywordView","title","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7412(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/DefaultKeywordView","reminderText","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

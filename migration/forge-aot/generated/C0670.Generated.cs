// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C670{
internal static JClass Build(){var c=new JClass("forge/game/keyword/Partner","forge/game/keyword/SimpleKeyword",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("with","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(7652,"forge/game/keyword/Partner","<init>","()V",1,1,2,new JHandler[]{},M7652));
c.Add(new JMethod(7653,"forge/game/keyword/Partner","getTitle","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7653));
c.Add(new JMethod(7654,"forge/game/keyword/Partner","parse","(Ljava/lang/String;)V",4,2,2,new JHandler[]{},M7654));
c.Add(new JMethod(7655,"forge/game/keyword/Partner","formatReminderText","(Ljava/lang/String;)Ljava/lang/String;",4,2,1,new JHandler[]{},M7655));
}

internal static JStep M7652(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/SimpleKeyword","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Partner","with","Ljava/lang/String;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7653(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Partner","with","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?17:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Partner","with","Ljava/lang/String;"));f.Pc=11;continue;}
case 11:{return rt.DynamicCall(f,"forge/game/keyword/Partner:7653:11:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",16);}
case 16:{return JStep.Return(f.Pop());}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/keyword/SimpleKeyword","getTitle","()Ljava/lang/String;","invokespecial",21);}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7654(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int==0?12:8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Partner","with","Ljava/lang/String;",value);f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7655(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Partner","with","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?9:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{f.Push(JValue.R(rt.String("You can have two commanders if both have this ability.")));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

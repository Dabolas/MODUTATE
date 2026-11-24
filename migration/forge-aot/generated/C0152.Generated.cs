// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C152{
internal static JClass Build(){var c=new JClass("forge/game/GameLogEntry","java/lang/Record",new string[]{"java/io/Serializable"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("type","Lforge/game/GameLogEntryType;",false,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("message","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("sourceCard","Lforge/game/card/CardView;",false,JValue.Default("Lforge/game/card/CardView;"),null));
c.Add(new JMethod(2397,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V",0,3,4,new JHandler[]{},M2397));
c.Add(new JMethod(2398,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;Lforge/game/card/CardView;)V",1,4,2,new JHandler[]{},M2398));
c.Add(new JMethod(2399,"forge/game/GameLogEntry","toString","()Ljava/lang/String;",1,1,2,new JHandler[]{},M2399));
c.Add(new JMethod(2400,"forge/game/GameLogEntry","hashCode","()I",17,1,1,new JHandler[]{},M2400));
c.Add(new JMethod(2401,"forge/game/GameLogEntry","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M2401));
c.Add(new JMethod(2402,"forge/game/GameLogEntry","type","()Lforge/game/GameLogEntryType;",1,1,1,new JHandler[]{},M2402));
c.Add(new JMethod(2403,"forge/game/GameLogEntry","message","()Ljava/lang/String;",1,1,1,new JHandler[]{},M2403));
c.Add(new JMethod(2404,"forge/game/GameLogEntry","sourceCard","()Lforge/game/card/CardView;",1,1,1,new JHandler[]{},M2404));
}

internal static JStep M2397(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;Lforge/game/card/CardView;)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2398(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameLogEntry","type","Lforge/game/GameLogEntryType;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameLogEntry","message","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameLogEntry","sourceCard","Lforge/game/card/CardView;",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2399(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogEntry","type","Lforge/game/GameLogEntryType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameLogEntryType","getCaption","()Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogEntry","message","Ljava/lang/String;"));f.Pc=11;continue;}
case 11:{return rt.DynamicCall(f,"forge/game/GameLogEntry:2399:11:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2400(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/GameLogEntry:2400:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/GameLogEntry;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2401(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/GameLogEntry:2401:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/GameLogEntry;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2402(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogEntry","type","Lforge/game/GameLogEntryType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2403(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogEntry","message","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2404(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogEntry","sourceCard","Lforge/game/card/CardView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

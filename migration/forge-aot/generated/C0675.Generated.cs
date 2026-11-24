// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C675{
internal static JClass Build(){var c=new JClass("forge/game/keyword/Trample","forge/game/keyword/KeywordWithType",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(7670,"forge/game/keyword/Trample","<init>","()V",1,1,1,new JHandler[]{},M7670));
c.Add(new JMethod(7671,"forge/game/keyword/Trample","getTitle","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7671));
c.Add(new JMethod(7672,"forge/game/keyword/Trample","formatReminderText","(Ljava/lang/String;)Ljava/lang/String;",4,2,1,new JHandler[]{},M7672));
}

internal static JStep M7670(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordWithType","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7671(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Trample","type","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?13:10;continue;}
case 10:{f.Push(JValue.R(rt.String("Trample Over Planeswalkers")));f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
case 13:{f.Push(JValue.R(rt.String("Trample")));f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7672(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Trample","type","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?13:10;continue;}
case 10:{f.Push(JValue.R(rt.String("This creature can deal excess combat damage to the controller of the planeswalker it's attacking.")));f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

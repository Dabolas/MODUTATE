// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C676{
internal static JClass Build(){var c=new JClass("forge/game/keyword/Vanishing","forge/game/keyword/KeywordWithAmount",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("withoutAmount","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(7673,"forge/game/keyword/Vanishing","<init>","()V",1,1,2,new JHandler[]{},M7673));
c.Add(new JMethod(7674,"forge/game/keyword/Vanishing","getTitle","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7674));
c.Add(new JMethod(7675,"forge/game/keyword/Vanishing","parse","(Ljava/lang/String;)V",4,2,2,new JHandler[]{},M7675));
c.Add(new JMethod(7676,"forge/game/keyword/Vanishing","formatReminderText","(Ljava/lang/String;)Ljava/lang/String;",4,2,2,new JHandler[]{},M7676));
}

internal static JStep M7673(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordWithAmount","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Vanishing","withoutAmount","Z",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7674(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Vanishing","withoutAmount","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?15:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/keyword/Vanishing","getKeyword","()Lforge/game/keyword/Keyword;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/keyword/Keyword","toString","()Ljava/lang/String;","invokevirtual",14);}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/keyword/KeywordWithAmount","getTitle","()Ljava/lang/String;","invokespecial",19);}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7675(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?17:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Vanishing","withoutAmount","Z",value);f.Pc=14;continue;}
case 14:{f.Pc=22;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/keyword/KeywordWithAmount","parse","(Ljava/lang/String;)V","invokespecial",22);}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7676(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Vanishing","withoutAmount","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?10:7;continue;}
case 7:{f.Push(JValue.R(rt.String("At the beginning of your upkeep, remove a time counter from this enchantment. When the last is removed, sacrifice it.")));f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/keyword/KeywordWithAmount","formatReminderText","(Ljava/lang/String;)Ljava/lang/String;","invokespecial",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

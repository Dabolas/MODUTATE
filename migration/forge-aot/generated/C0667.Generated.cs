// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C667{
internal static JClass Build(){var c=new JClass("forge/game/keyword/Mayhem","forge/game/keyword/KeywordWithCost",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(7640,"forge/game/keyword/Mayhem","<init>","()V",1,1,1,new JHandler[]{},M7640));
c.Add(new JMethod(7641,"forge/game/keyword/Mayhem","getTitle","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7641));
c.Add(new JMethod(7642,"forge/game/keyword/Mayhem","parse","(Ljava/lang/String;)V",4,2,2,new JHandler[]{},M7642));
c.Add(new JMethod(7643,"forge/game/keyword/Mayhem","formatReminderText","(Ljava/lang/String;)Ljava/lang/String;",4,2,2,new JHandler[]{},M7643));
}

internal static JStep M7640(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7641(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Mayhem","cost","Lforge/game/cost/Cost;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?12:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/keyword/Mayhem","getTitleWithoutCost","()Ljava/lang/String;","invokevirtual",11);}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","getTitle","()Ljava/lang/String;","invokespecial",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7642(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?15:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","parse","(Ljava/lang/String;)V","invokespecial",12);}
case 12:{f.Pc=20;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(null));f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Mayhem","cost","Lforge/game/cost/Cost;",value);f.Pc=20;continue;}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7643(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Mayhem","cost","Lforge/game/cost/Cost;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?10:7;continue;}
case 7:{f.Push(JValue.R(rt.String("You may play this card from your graveyard if you discarded it this turn. Timing rules still apply.")));f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","formatReminderText","(Ljava/lang/String;)Ljava/lang/String;","invokespecial",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

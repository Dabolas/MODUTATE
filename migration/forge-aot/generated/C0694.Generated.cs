// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C694{
internal static JClass Build(){var c=new JClass("forge/game/phase/ExtraPhase","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("phase","Lforge/game/phase/PhaseType;",false,JValue.Default("Lforge/game/phase/PhaseType;"),null));
c.Add(new JField("delTrig","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(7837,"forge/game/phase/ExtraPhase","<init>","(Lforge/game/phase/PhaseType;)V",1,2,3,new JHandler[]{},M7837));
c.Add(new JMethod(7838,"forge/game/phase/ExtraPhase","getPhase","()Lforge/game/phase/PhaseType;",1,1,1,new JHandler[]{},M7838));
c.Add(new JMethod(7839,"forge/game/phase/ExtraPhase","addTrigger","(Lforge/game/trigger/Trigger;)V",1,2,2,new JHandler[]{},M7839));
c.Add(new JMethod(7840,"forge/game/phase/ExtraPhase","getDelayedTriggers","()Ljava/util/List;",1,1,1,new JHandler[]{},M7840));
}

internal static JStep M7837(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",12);}
case 12:{return rt.Call(f,"java/util/Collections","synchronizedList","(Ljava/util/List;)Ljava/util/List;","invokestatic",15);}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/ExtraPhase","delTrig","Ljava/util/List;",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/ExtraPhase","phase","Lforge/game/phase/PhaseType;",value);f.Pc=23;continue;}
case 23:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7838(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/ExtraPhase","phase","Lforge/game/phase/PhaseType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7839(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/ExtraPhase","delTrig","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7840(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/ExtraPhase","delTrig","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

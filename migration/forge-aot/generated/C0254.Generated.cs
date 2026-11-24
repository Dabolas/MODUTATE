// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C254{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ControlGainEffect$1","java/lang/Object",new string[]{"forge/GameCommand"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-42244224L),null));
c.Add(new JField("val$tgtC","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("val$tStamp","J",false,JValue.Default("J"),null));
c.Add(new JField("this$0","Lforge/game/ability/effects/ControlGainEffect;",false,JValue.Default("Lforge/game/ability/effects/ControlGainEffect;"),null));
c.Add(new JMethod(3207,"forge/game/ability/effects/ControlGainEffect$1","<init>","(Lforge/game/ability/effects/ControlGainEffect;Lforge/game/card/Card;J)V",0,5,3,new JHandler[]{},M3207));
c.Add(new JMethod(3208,"forge/game/ability/effects/ControlGainEffect$1","run","()V",1,1,5,new JHandler[]{},M3208));
}

internal static JStep M3207(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/ControlGainEffect$1","this$0","Lforge/game/ability/effects/ControlGainEffect;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/ControlGainEffect$1","val$tgtC","Lforge/game/card/Card;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/ControlGainEffect$1","val$tStamp","J",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",19);}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3208(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ControlGainEffect$1","val$tgtC","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ControlGainEffect$1","val$tStamp","J"));f.Pc=8;continue;}
case 8:{f.Push(JValue.L(0));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","removeChangedCardKeywords","(JJ)Z","invokevirtual",12);}
case 12:{f.StackOp("pop");f.Pc=13;continue;}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

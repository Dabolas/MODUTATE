// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C388{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/RingTemptsYouEffect$1","java/lang/Object",new string[]{"forge/GameCommand"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JField("val$ringBearer","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("val$p","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("this$0","Lforge/game/ability/effects/RingTemptsYouEffect;",false,JValue.Default("Lforge/game/ability/effects/RingTemptsYouEffect;"),null));
c.Add(new JMethod(3671,"forge/game/ability/effects/RingTemptsYouEffect$1","<init>","(Lforge/game/ability/effects/RingTemptsYouEffect;Lforge/game/card/Card;Lforge/game/player/Player;)V",0,4,2,new JHandler[]{},M3671));
c.Add(new JMethod(3672,"forge/game/ability/effects/RingTemptsYouEffect$1","run","()V",1,1,1,new JHandler[]{},M3672));
}

internal static JStep M3671(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/RingTemptsYouEffect$1","this$0","Lforge/game/ability/effects/RingTemptsYouEffect;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/RingTemptsYouEffect$1","val$ringBearer","Lforge/game/card/Card;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/RingTemptsYouEffect$1","val$p","Lforge/game/player/Player;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",19);}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3672(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/RingTemptsYouEffect$1","val$ringBearer","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","isRingBearer","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?17:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/RingTemptsYouEffect$1","val$p","Lforge/game/player/Player;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/player/Player","clearRingBearer","()V","invokevirtual",17);}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

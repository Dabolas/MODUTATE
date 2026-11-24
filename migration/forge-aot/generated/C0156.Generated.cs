// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C156{
internal static JClass Build(){var c=new JClass("forge/game/GameObject","java/lang/Object",new string[]{},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(2470,"forge/game/GameObject","canBeTargetedBy","(Lforge/game/spellability/SpellAbility;)Z",1,2,1,new JHandler[]{},M2470));
c.Add(new JMethod(2471,"forge/game/GameObject","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z",1,9,5,new JHandler[]{},M2471));
c.Add(new JMethod(2472,"forge/game/GameObject","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z",1,5,1,new JHandler[]{},M2472));
c.Add(new JMethod(2473,"forge/game/GameObject","hasProperty","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z",1,5,1,new JHandler[]{},M2473));
}

internal static JStep M2470(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2471(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Locals[5]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[5]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=6;continue;}
case 6:{f.Locals[6]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Locals[7]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[7]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[6]);f.Pc=15;continue;}
case 15:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?48:18;continue;}
case 18:{f.Push(f.Locals[5]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[7]);f.Pc=22;continue;}
case 22:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=23;continue;}
case 23:{f.Locals[8]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[8]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/GameObject","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?42:40;continue;}
case 40:{f.Push(JValue.I(1));f.Pc=41;continue;}
case 41:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 42:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=45;continue;}
case 45:{f.Pc=11;continue;}
case 48:{f.Push(JValue.I(0));f.Pc=49;continue;}
case 49:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2472(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2473(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

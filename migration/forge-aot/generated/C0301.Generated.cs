// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C301{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/EndOfTurnEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3385,"forge/game/ability/effects/EndOfTurnEffect","<init>","()V",1,1,1,new JHandler[]{},M3385));
c.Add(new JMethod(3386,"forge/game/ability/effects/EndOfTurnEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,2,3,new JHandler[]{},M3386));
c.Add(new JMethod(3387,"forge/game/ability/effects/EndOfTurnEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,3,3,new JHandler[]{},M3387));
}

internal static JStep M3385(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3386(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("StackDescription")));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("")));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3387(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/EndOfTurnEffect","getCardsfromTargets","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",11);}
case 11:{f.Pc=f.Pop().Int!=0?25:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",21);}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/ability/effects/EndOfTurnEffect","registerDelayedTrigger","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/Iterable;)V","invokestatic",25);}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C487{
internal static JClass Build(){var c=new JClass("forge/game/card/ICardTraitChanges","java/lang/Object",new string[]{},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(5815,"forge/game/card/ICardTraitChanges","applySpellAbility","(Ljava/util/List;)Ljava/util/List;",1,2,1,new JHandler[]{},M5815));
c.Add(new JMethod(5816,"forge/game/card/ICardTraitChanges","applyTrigger","(Ljava/util/List;)Ljava/util/List;",1,2,1,new JHandler[]{},M5816));
c.Add(new JMethod(5817,"forge/game/card/ICardTraitChanges","applyReplacementEffect","(Ljava/util/List;)Ljava/util/List;",1,2,1,new JHandler[]{},M5817));
c.Add(new JMethod(5818,"forge/game/card/ICardTraitChanges","applyStaticAbility","(Ljava/util/List;)Ljava/util/List;",1,2,1,new JHandler[]{},M5818));
c.Add(new JMethod(5819,"forge/game/card/ICardTraitChanges","changeText","()V",1,1,0,new JHandler[]{},M5819));
c.Add(new JMethod(5820,"forge/game/card/ICardTraitChanges","copy","(Lforge/game/card/Card;Z)Lforge/game/card/ICardTraitChanges;",1025,0,0,new JHandler[]{},null));
}

internal static JStep M5815(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5816(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5817(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5818(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5819(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

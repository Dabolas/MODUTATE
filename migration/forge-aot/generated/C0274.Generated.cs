// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C274{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/DamageBaseEffect","forge/game/ability/SpellAbilityEffect",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3288,"forge/game/ability/effects/DamageBaseEffect","<init>","()V",1,1,1,new JHandler[]{},M3288));
}

internal static JStep M3288(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

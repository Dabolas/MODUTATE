// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C279{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/DamageResolveEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3302,"forge/game/ability/effects/DamageResolveEffect","<init>","()V",1,1,1,new JHandler[]{},M3302));
c.Add(new JMethod(3303,"forge/game/ability/effects/DamageResolveEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,5,6,new JHandler[]{},M3303));
c.Add(new JMethod(3304,"forge/game/ability/effects/DamageResolveEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,2,1,new JHandler[]{},M3304));
}

internal static JStep M3302(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3303(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDamageMap","()Lforge/game/card/CardDamageTable;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?10:9;continue;}
case 9:{return JStep.ReturnVoid;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPreventMap","()Lforge/game/card/CardDamageTable;","invokevirtual",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCounterTable","()Lforge/game/GameEntityCounterTable;","invokevirtual",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",25);}
case 25:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",28);}
case 28:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",31);}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/GameAction","dealDamage","(ZLforge/game/card/CardDamageTable;Lforge/game/card/CardDamageTable;Lforge/game/GameEntityCounterTable;Lforge/game/spellability/SpellAbility;)V","invokevirtual",40);}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/ability/effects/DamageResolveEffect","replaceDying","(Lforge/game/spellability/SpellAbility;)V","invokestatic",44);}
case 44:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3304(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

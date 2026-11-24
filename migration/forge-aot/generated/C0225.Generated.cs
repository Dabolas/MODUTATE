// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C225{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ChangeXEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3095,"forge/game/ability/effects/ChangeXEffect","<init>","()V",1,1,1,new JHandler[]{},M3095));
c.Add(new JMethod(3096,"forge/game/ability/effects/ChangeXEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,7,3,new JHandler[]{},M3096));
}

internal static JStep M3095(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3096(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/ChangeXEffect","getTargetSpells","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?107:21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[4]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",36);}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("Value")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",42);}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",46);}
case 46:{f.Locals[5]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",53);}
case 53:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",56);}
case 56:{f.Locals[6]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[6]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/spellability/SpellAbility","equals","(Ljava/lang/Object;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?86:68;continue;}
case 68:{f.Push(f.Locals[6]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","getXManaCostPaid","()Ljava/lang/Integer;","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Reference==null?86:76;continue;}
case 76:{f.Push(f.Locals[6]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[5]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",83);}
case 83:{return rt.Call(f,"forge/game/spellability/SpellAbility","setXManaCostPaid","(Ljava/lang/Integer;)V","invokevirtual",86);}
case 86:{f.Push(f.Locals[4]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/spellability/SpellAbility","getXManaCostPaid","()Ljava/lang/Integer;","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Reference==null?104:94;continue;}
case 94:{f.Push(f.Locals[4]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[5]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",101);}
case 101:{return rt.Call(f,"forge/game/spellability/SpellAbility","setXManaCostPaid","(Ljava/lang/Integer;)V","invokevirtual",104);}
case 104:{f.Pc=12;continue;}
case 107:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

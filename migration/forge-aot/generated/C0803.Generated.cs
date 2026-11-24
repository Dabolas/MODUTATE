// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C803{
internal static JClass Build(){var c=new JClass("forge/game/spellability/SpellAbilityPredicates","forge/game/CardTraitPredicates",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(9519,"forge/game/spellability/SpellAbilityPredicates","<init>","()V",1,1,1,new JHandler[]{},M9519));
c.Add(new JMethod(9520,"forge/game/spellability/SpellAbilityPredicates","isApi","(Lforge/game/ability/ApiType;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M9520));
c.Add(new JMethod(9521,"forge/game/spellability/SpellAbilityPredicates","hasSubAbilityApi","(Lforge/game/ability/ApiType;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M9521));
c.Add(new JMethod(9522,"forge/game/spellability/SpellAbilityPredicates","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;",9,4,4,new JHandler[]{},M9522));
c.Add(new JMethod(9523,"forge/game/spellability/SpellAbilityPredicates","lambda$isValid$2","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;Lforge/game/spellability/SpellAbility;)Z",4106,5,5,new JHandler[]{},M9523));
c.Add(new JMethod(9524,"forge/game/spellability/SpellAbilityPredicates","lambda$hasSubAbilityApi$1","(Lforge/game/ability/ApiType;Lforge/game/spellability/SpellAbility;)Z",4106,2,2,new JHandler[]{},M9524));
c.Add(new JMethod(9525,"forge/game/spellability/SpellAbilityPredicates","lambda$isApi$0","(Lforge/game/ability/ApiType;Lforge/game/spellability/SpellAbility;)Z",4106,2,2,new JHandler[]{},M9525));
}

internal static JStep M9519(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/CardTraitPredicates","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9520(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbilityPredicates:9520:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/ability/ApiType;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9521(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbilityPredicates:9521:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/ability/ApiType;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9522(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbilityPredicates:9522:4:java/lang/invoke/LambdaMetafactory.metafactory","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9523(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[4]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9524(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","findSubAbilityByType","(Lforge/game/ability/ApiType;)Lforge/game/spellability/SpellAbility;","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Reference==null?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9525(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/ability/ApiType","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

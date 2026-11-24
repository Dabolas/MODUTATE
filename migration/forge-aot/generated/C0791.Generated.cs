// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C791{
internal static JClass Build(){var c=new JClass("forge/game/spellability/AbilityStatic","forge/game/spellability/Ability",new string[]{"java/lang/Cloneable"},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(9132,"forge/game/spellability/AbilityStatic","<init>","(Lforge/game/card/Card;Lforge/card/mana/ManaCost;)V",1,3,3,new JHandler[]{},M9132));
c.Add(new JMethod(9133,"forge/game/spellability/AbilityStatic","<init>","(Lforge/game/card/Card;Lforge/card/mana/ManaCost;Lforge/game/card/CardState;)V",1,4,4,new JHandler[]{},M9133));
c.Add(new JMethod(9134,"forge/game/spellability/AbilityStatic","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;)V",1,4,3,new JHandler[]{},M9134));
c.Add(new JMethod(9135,"forge/game/spellability/AbilityStatic","canPlay","()Z",1,2,3,new JHandler[]{},M9135));
c.Add(new JMethod(9136,"forge/game/spellability/AbilityStatic","clone","()Ljava/lang/Object;",17,2,3,new JHandler[]{new JHandler(0,4,5,"java/lang/Exception")},M9136));
}

internal static JStep M9132(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/Ability","<init>","(Lforge/game/card/Card;Lforge/card/mana/ManaCost;)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9133(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/Ability","<init>","(Lforge/game/card/Card;Lforge/card/mana/ManaCost;Lforge/game/card/CardState;)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9134(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/Ability","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/AbilityStatic","setTargetRestrictions","(Lforge/game/spellability/TargetRestrictions;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9135(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/AbilityStatic","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/AbilityStatic","isTurnFaceUp","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?21:12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/Card","canBeTurnedFaceUp","()Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int!=0?21:19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/AbilityStatic","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",25);}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","canPlay","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",30);}
case 30:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9136(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","clone","()Ljava/lang/Object;","invokespecial",4);}
case 4:{return JStep.Return(f.Pop());}
case 5:{f.Locals[1]=f.Pop();f.Pc=6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",14);}
case 14:{return rt.DynamicCall(f,"forge/game/spellability/AbilityStatic:9136:14:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",19);}
case 19:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",22);}
case 22:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

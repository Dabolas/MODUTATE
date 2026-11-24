// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C787{
internal static JClass Build(){var c=new JClass("forge/game/spellability/Ability","forge/game/spellability/SpellAbility",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(9068,"forge/game/spellability/Ability","<init>","(Lforge/game/card/Card;Lforge/card/mana/ManaCost;)V",4,3,6,new JHandler[]{},M9068));
c.Add(new JMethod(9069,"forge/game/spellability/Ability","<init>","(Lforge/game/card/Card;Lforge/card/mana/ManaCost;Lforge/game/card/CardState;)V",4,4,6,new JHandler[]{},M9069));
c.Add(new JMethod(9070,"forge/game/spellability/Ability","<init>","(Lforge/game/card/Card;Lforge/card/mana/ManaCost;Lforge/game/spellability/SpellAbilityView;)V",4,4,6,new JHandler[]{},M9070));
c.Add(new JMethod(9071,"forge/game/spellability/Ability","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;)V",4,3,4,new JHandler[]{},M9071));
c.Add(new JMethod(9072,"forge/game/spellability/Ability","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbilityView;)V",4,4,4,new JHandler[]{},M9072));
c.Add(new JMethod(9073,"forge/game/spellability/Ability","canPlay","()Z",1,2,1,new JHandler[]{},M9073));
}

internal static JStep M9068(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Lforge/card/mana/ManaCost;Z)V","invokespecial",11);}
case 11:{f.Push(JValue.R(null));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/Ability","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbilityView;)V","invokespecial",15);}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9069(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Lforge/card/mana/ManaCost;Z)V","invokespecial",11);}
case 11:{f.Push(JValue.R(null));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbilityView;Lforge/game/card/CardState;)V","invokespecial",16);}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9070(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Lforge/card/mana/ManaCost;Z)V","invokespecial",11);}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/Ability","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbilityView;)V","invokespecial",15);}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9071(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/Ability","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbilityView;)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9072(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbilityView;)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9073(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/Ability","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/zone/MagicStack","isSplitSecondOnStack","()Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?27:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/Ability","isManaAbility","()Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int!=0?27:25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/Ability","getHostCard","()Lforge/game/card/Card;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?51:37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/Ability","getHostCard","()Lforge/game/card/Card;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int!=0?51:47;continue;}
case 47:{f.Push(JValue.I(1));f.Pc=48;continue;}
case 48:{f.Pc=52;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

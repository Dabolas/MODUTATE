// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C809{
internal static JClass Build(){var c=new JClass("forge/game/spellability/SpellPermanent","forge/game/ability/SpellApiBased",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(2413495058630644447L),null));
c.Add(new JMethod(9678,"forge/game/spellability/SpellPermanent","<init>","(Lforge/game/card/Card;)V",1,2,7,new JHandler[]{},M9678));
c.Add(new JMethod(9679,"forge/game/spellability/SpellPermanent","<init>","(Lforge/game/card/Card;Lforge/game/card/CardState;)V",1,3,7,new JHandler[]{},M9679));
c.Add(new JMethod(9680,"forge/game/spellability/SpellPermanent","<init>","(Lforge/game/card/Card;Lforge/game/card/CardState;Lforge/game/cost/Cost;)V",1,4,6,new JHandler[]{},M9680));
}

internal static JStep M9678(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",6);}
case 6:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",14);}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Lforge/card/mana/ManaCost;Z)V","invokespecial",18);}
case 18:{return rt.Call(f,"forge/game/spellability/SpellPermanent","<init>","(Lforge/game/card/Card;Lforge/game/card/CardState;Lforge/game/cost/Cost;)V","invokespecial",21);}
case 21:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9679(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=6;continue;}
case 6:{f.StackOp("dup");f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardState","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",11);}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Lforge/card/mana/ManaCost;Z)V","invokespecial",15);}
case 15:{return rt.Call(f,"forge/game/spellability/SpellPermanent","<init>","(Lforge/game/card/Card;Lforge/game/card/CardState;Lforge/game/cost/Cost;)V","invokespecial",18);}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9680(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardState","getType","()Lforge/card/CardTypeView;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/card/CardTypeView","isCreature","()Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?19:13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","PermanentCreature","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","PermanentCreature","Lforge/game/ability/ApiType;"));f.Pc=16;continue;}
case 16:{f.Pc=22;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","PermanentNoncreature","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","PermanentNoncreature","Lforge/game/ability/ApiType;"));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(null));f.Pc=25;continue;}
case 25:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",28);}
case 28:{return rt.Call(f,"forge/game/ability/SpellApiBased","<init>","(Lforge/game/ability/ApiType;Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;Ljava/util/Map;)V","invokespecial",31);}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellPermanent","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",36);}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellPermanent","setStackDescription","(Ljava/lang/String;)V","invokevirtual",42);}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/spellability/SpellPermanent","getStackDescription","()Ljava/lang/String;","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/game/spellability/SpellPermanent","setDescription","(Ljava/lang/String;)V","invokevirtual",50);}
case 50:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

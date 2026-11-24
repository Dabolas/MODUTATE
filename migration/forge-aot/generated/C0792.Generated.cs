// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C792{
internal static JClass Build(){var c=new JClass("forge/game/spellability/AbilitySub","forge/game/spellability/SpellAbility",new string[]{"java/io/Serializable","java/lang/Cloneable"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(4650634415821733134L),null));
c.Add(new JField("parent","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JField("effect","Lforge/game/ability/SpellAbilityEffect;",false,JValue.Default("Lforge/game/ability/SpellAbilityEffect;"),null));
c.Add(new JMethod(9137,"forge/game/spellability/AbilitySub","setParent","(Lforge/game/spellability/SpellAbility;)V",1,2,2,new JHandler[]{},M9137));
c.Add(new JMethod(9138,"forge/game/spellability/AbilitySub","getParent","()Lforge/game/spellability/SpellAbility;",1,1,1,new JHandler[]{},M9138));
c.Add(new JMethod(9139,"forge/game/spellability/AbilitySub","canPlay","()Z",1,1,1,new JHandler[]{},M9139));
c.Add(new JMethod(9140,"forge/game/spellability/AbilitySub","<init>","(Lforge/game/ability/ApiType;Lforge/game/card/Card;Lforge/game/spellability/TargetRestrictions;Ljava/util/Map;)V",1,5,3,new JHandler[]{},M9140));
c.Add(new JMethod(9141,"forge/game/spellability/AbilitySub","getStackDescription","()Ljava/lang/String;",1,1,3,new JHandler[]{},M9141));
c.Add(new JMethod(9142,"forge/game/spellability/AbilitySub","resolve","()V",1,1,2,new JHandler[]{},M9142));
c.Add(new JMethod(9143,"forge/game/spellability/AbilitySub","getSVarFallback","(Ljava/lang/String;)Ljava/util/List;",4,2,4,new JHandler[]{},M9143));
c.Add(new JMethod(9144,"forge/game/spellability/AbilitySub","clone","()Ljava/lang/Object;",1,2,3,new JHandler[]{new JHandler(0,4,5,"java/lang/Exception")},M9144));
}

internal static JStep M9137(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilitySub","parent","Lforge/game/spellability/SpellAbility;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9138(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilitySub","parent","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9139(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9140(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{if(!rt.StaticReady(f,"forge/game/cost/Cost","Zero","Lforge/game/cost/Cost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/cost/Cost","Zero","Lforge/game/cost/Cost;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;)V","invokespecial",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/AbilitySub","setTargetRestrictions","(Lforge/game/spellability/TargetRestrictions;)V","invokevirtual",13);}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilitySub","api","Lforge/game/ability/ApiType;",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Reference==null?34:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilitySub","mapParams","Ljava/util/Map;"));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",34);}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilitySub","api","Lforge/game/ability/ApiType;"));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/ability/ApiType","getSpellEffect","()Lforge/game/ability/SpellAbilityEffect;","invokevirtual",42);}
case 42:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilitySub","effect","Lforge/game/ability/SpellAbilityEffect;",value);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilitySub","effect","Lforge/game/ability/SpellAbilityEffect;"));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",53);}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilitySub","originalMapParams","Ljava/util/Map;"));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilitySub","mapParams","Ljava/util/Map;"));f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",66);}
case 66:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9141(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilitySub","effect","Lforge/game/ability/SpellAbilityEffect;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilitySub","mapParams","Ljava/util/Map;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getStackDescriptionWithSubs","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9142(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilitySub","effect","Lforge/game/ability/SpellAbilityEffect;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","resolve","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9143(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/AbilitySub","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCardState","()Lforge/game/card/CardState;","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/AbilitySub","getCardState","()Lforge/game/card/CardState;","invokevirtual",11);}
case 11:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?29:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.NewArray("Lforge/game/IHasSVars;",f.Pop().Int)));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/AbilitySub","getCardState","()Lforge/game/card/CardState;","invokevirtual",24);}
case 24:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=25;continue;}
case 25:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",28);}
case 28:{return JStep.Return(f.Pop());}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVarFallback","(Ljava/lang/String;)Ljava/util/List;","invokespecial",34);}
case 34:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9144(JRuntime rt,JFrame f)
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
case 14:{return rt.DynamicCall(f,"forge/game/spellability/AbilitySub:9144:14:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",19);}
case 19:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",22);}
case 22:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

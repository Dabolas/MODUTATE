// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C564{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostUntap","forge/game/cost/CostPart",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JMethod(6623,"forge/game/cost/CostUntap","<init>","()V",1,1,1,new JHandler[]{},M6623));
c.Add(new JMethod(6624,"forge/game/cost/CostUntap","paymentOrder","()I",1,1,1,new JHandler[]{},M6624));
c.Add(new JMethod(6625,"forge/game/cost/CostUntap","isReusable","()Z",1,1,1,new JHandler[]{},M6625));
c.Add(new JMethod(6626,"forge/game/cost/CostUntap","isUndoable","()Z",1,1,1,new JHandler[]{},M6626));
c.Add(new JMethod(6627,"forge/game/cost/CostUntap","isRenewable","()Z",1,1,1,new JHandler[]{},M6627));
c.Add(new JMethod(6628,"forge/game/cost/CostUntap","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M6628));
c.Add(new JMethod(6629,"forge/game/cost/CostUntap","refund","(Lforge/game/card/Card;)V",17,2,2,new JHandler[]{},M6629));
c.Add(new JMethod(6630,"forge/game/cost/CostUntap","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",17,5,3,new JHandler[]{},M6630));
c.Add(new JMethod(6631,"forge/game/cost/CostUntap","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z",1,8,5,new JHandler[]{},M6631));
c.Add(new JMethod(6632,"forge/game/cost/CostUntap","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6632));
}

internal static JStep M6623(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostPart","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6624(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(20));f.Pc=2;continue;}
case 2:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6625(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6626(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6627(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6628(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("{Q}")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6629(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6630(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[4]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/Card","canUntap","(Lforge/game/player/Player;Z)Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?50:16;continue;}
case 16:{f.Push(f.Locals[4]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/Card","isAbilitySick","()Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int!=0?50:24;continue;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","STUN","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","STUN","Lforge/game/card/CounterEnumType;"));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int==0?46:35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","STUN","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","STUN","Lforge/game/card/CounterEnumType;"));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/Card","canRemoveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int==0?50:46;continue;}
case 46:{f.Push(JValue.I(1));f.Pc=47;continue;}
case 47:{f.Pc=51;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6631(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[5]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[5]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","untap","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?71:14;continue;}
case 14:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",17);}
case 17:{f.Locals[6]=f.Pop();f.Pc=19;continue;}
case 19:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",22);}
case 22:{f.Locals[7]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[7]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{f.Push(f.Locals[5]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",36);}
case 36:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{f.Push(f.Locals[6]);f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[7]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",54);}
case 54:{f.StackOp("pop");f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",59);}
case 59:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",62);}
case 62:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","UntapAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","UntapAll","Lforge/game/trigger/TriggerType;"));f.Pc=65;continue;}
case 65:{f.Push(f.Locals[6]);f.Pc=67;continue;}
case 67:{f.Push(JValue.I(0));f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",71);}
case 71:{f.Push(JValue.I(1));f.Pc=72;continue;}
case 72:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6632(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostUntap;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

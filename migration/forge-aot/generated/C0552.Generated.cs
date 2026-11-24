// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C552{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostPutCounterYou","forge/game/cost/CostPart",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JField("type","Lforge/game/card/CounterType;",false,JValue.Default("Lforge/game/card/CounterType;"),null));
c.Add(new JMethod(6516,"forge/game/cost/CostPutCounterYou","<init>","(Ljava/lang/String;Lforge/game/card/CounterType;)V",1,3,2,new JHandler[]{},M6516));
c.Add(new JMethod(6517,"forge/game/cost/CostPutCounterYou","paymentOrder","()I",1,1,1,new JHandler[]{},M6517));
c.Add(new JMethod(6518,"forge/game/cost/CostPutCounterYou","getCounter","()Lforge/game/card/CounterType;",1,1,1,new JHandler[]{},M6518));
c.Add(new JMethod(6519,"forge/game/cost/CostPutCounterYou","toString","()Ljava/lang/String;",17,2,4,new JHandler[]{},M6519));
c.Add(new JMethod(6520,"forge/game/cost/CostPutCounterYou","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",17,4,2,new JHandler[]{},M6520));
c.Add(new JMethod(6521,"forge/game/cost/CostPutCounterYou","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z",1,6,5,new JHandler[]{},M6521));
c.Add(new JMethod(6522,"forge/game/cost/CostPutCounterYou","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6522));
}

internal static JStep M6516(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostPart","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/cost/CostPutCounterYou","setAmount","(Ljava/lang/String;)V","invokevirtual",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPutCounterYou","type","Lforge/game/card/CounterType;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6517(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(8));f.Pc=2;continue;}
case 2:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6518(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCounterYou","type","Lforge/game/card/CounterType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6519(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Get ")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/cost/CostPutCounterYou","convertAmount","()Ljava/lang/Integer;","invokevirtual",18);}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/cost/CostPutCounterYou","getAmount","()Ljava/lang/String;","invokevirtual",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCounterYou","type","Lforge/game/card/CounterType;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",31);}
case 31:{return rt.DynamicCall(f,"forge/game/cost/CostPutCounterYou:6519:31:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",36);}
case 36:{return rt.Call(f,"forge/game/cost/Cost","convertAmountTypeToWords","(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",39);}
case 39:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",42);}
case 42:{f.StackOp("pop");f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",47);}
case 47:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6520(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCounterYou","type","Lforge/game/card/CounterType;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/player/Player","canReceiveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6521(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",7);}
case 7:{f.Locals[5]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[5]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCounterYou","type","Lforge/game/card/CounterType;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/PaymentDecision","c","I"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/GameEntityCounterTable","put","(Lforge/game/player/Player;Lforge/game/GameEntity;Lforge/game/card/CounterType;I)I","invokevirtual",24);}
case 24:{f.StackOp("pop");f.Pc=25;continue;}
case 25:{f.Push(f.Locals[5]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",31);}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",35);}
case 35:{f.Push(JValue.I(1));f.Pc=36;continue;}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6522(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostPutCounterYou;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

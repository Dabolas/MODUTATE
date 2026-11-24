// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C527{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostDamage","forge/game/cost/CostPart",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JMethod(6271,"forge/game/cost/CostDamage","<init>","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M6271));
c.Add(new JMethod(6272,"forge/game/cost/CostDamage","paymentOrder","()I",1,1,1,new JHandler[]{},M6272));
c.Add(new JMethod(6273,"forge/game/cost/CostDamage","toString","()Ljava/lang/String;",17,2,2,new JHandler[]{},M6273));
c.Add(new JMethod(6274,"forge/game/cost/CostDamage","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",17,4,1,new JHandler[]{},M6274));
c.Add(new JMethod(6275,"forge/game/cost/CostDamage","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z",1,9,6,new JHandler[]{},M6275));
c.Add(new JMethod(6276,"forge/game/cost/CostDamage","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6276));
}

internal static JStep M6271(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostPart","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/cost/CostDamage","setAmount","(Ljava/lang/String;)V","invokevirtual",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6272(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(8));f.Pc=2;continue;}
case 2:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6273(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Deal ")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/cost/CostDamage","getAmount","()Ljava/lang/String;","invokevirtual",18);}
case 18:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",21);}
case 21:{f.Push(JValue.R(rt.String(" damage to you")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",31);}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6274(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6275(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[5]=f.Pop();f.Pc=6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"forge/game/card/CardDamageTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardDamageTable")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/CardDamageTable","<init>","()V","invokespecial",13);}
case 13:{f.Locals[6]=f.Pop();f.Pc=15;continue;}
case 15:{if(!rt.EnsureInitialized(f,"forge/game/card/CardDamageTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardDamageTable")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/CardDamageTable","<init>","()V","invokespecial",22);}
case 22:{f.Locals[7]=f.Pop();f.Pc=24;continue;}
case 24:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=27;continue;}
case 27:{f.StackOp("dup");f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",31);}
case 31:{f.Locals[8]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[6]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[5]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/PaymentDecision","c","I"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",45);}
case 45:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",48);}
case 48:{f.StackOp("pop");f.Pc=49;continue;}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",54);}
case 54:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",57);}
case 57:{f.Push(JValue.I(0));f.Pc=58;continue;}
case 58:{f.Push(f.Locals[6]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[7]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[8]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/GameAction","dealDamage","(ZLforge/game/card/CardDamageTable;Lforge/game/card/CardDamageTable;Lforge/game/GameEntityCounterTable;Lforge/game/spellability/SpellAbility;)V","invokevirtual",68);}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/PaymentDecision","c","I"));f.Pc=72;continue;}
case 72:{f.Pc=f.Pop().Int<=0?79:75;continue;}
case 75:{f.Push(JValue.I(1));f.Pc=76;continue;}
case 76:{f.Pc=80;continue;}
case 79:{f.Push(JValue.I(0));f.Pc=80;continue;}
case 80:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6276(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostDamage;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

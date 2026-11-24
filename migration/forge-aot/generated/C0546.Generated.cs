// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C546{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostPayLife","forge/game/cost/CostPart",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JMethod(6455,"forge/game/cost/CostPayLife","<init>","(Ljava/lang/String;Ljava/lang/String;)V",1,3,4,new JHandler[]{},M6455));
c.Add(new JMethod(6456,"forge/game/cost/CostPayLife","paymentOrder","()I",1,1,1,new JHandler[]{},M6456));
c.Add(new JMethod(6457,"forge/game/cost/CostPayLife","toString","()Ljava/lang/String;",17,3,2,new JHandler[]{},M6457));
c.Add(new JMethod(6458,"forge/game/cost/CostPayLife","getMaxAmountX","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Ljava/lang/Integer;",1,4,4,new JHandler[]{},M6458));
c.Add(new JMethod(6459,"forge/game/cost/CostPayLife","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",17,4,4,new JHandler[]{},M6459));
c.Add(new JMethod(6460,"forge/game/cost/CostPayLife","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z",1,5,4,new JHandler[]{},M6460));
c.Add(new JMethod(6461,"forge/game/cost/CostPayLife","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6461));
}

internal static JStep M6455(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.String("card")));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/cost/CostPart","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6456(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(7));f.Pc=2;continue;}
case 2:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6457(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Pay ")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/cost/CostPayLife","getTypeDescription","()Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Pc=f.Pop().Reference==null?33:24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{f.Pc=47;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/cost/CostPayLife","getAmount","()Ljava/lang/String;","invokevirtual",38);}
case 38:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",41);}
case 41:{f.Push(JValue.R(rt.String(" life")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",46);}
case 46:{f.StackOp("pop");f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",51);}
case 51:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6458(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[3]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/Player","canPayLife","(IZLforge/game/spellability/SpellAbility;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?15:10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",14);}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",19);}
case 19:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",22);}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6459(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/cost/CostPayLife","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",6);}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/player/Player","canPayLife","(IZLforge/game/spellability/SpellAbility;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?16:14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6460(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/PaymentDecision","c","I"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[4]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/player/Player","payLife","(ILforge/game/spellability/SpellAbility;Z)Z","invokevirtual",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6461(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostPayLife;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

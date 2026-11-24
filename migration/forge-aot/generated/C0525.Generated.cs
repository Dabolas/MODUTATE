// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C525{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostChooseCreatureType","forge/game/cost/CostPart",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JMethod(6256,"forge/game/cost/CostChooseCreatureType","<init>","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M6256));
c.Add(new JMethod(6257,"forge/game/cost/CostChooseCreatureType","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",17,4,1,new JHandler[]{},M6257));
c.Add(new JMethod(6258,"forge/game/cost/CostChooseCreatureType","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z",1,5,2,new JHandler[]{},M6258));
c.Add(new JMethod(6259,"forge/game/cost/CostChooseCreatureType","toString","()Ljava/lang/String;",17,3,4,new JHandler[]{},M6259));
c.Add(new JMethod(6260,"forge/game/cost/CostChooseCreatureType","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6260));
}

internal static JStep M6256(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostPart","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/cost/CostChooseCreatureType","setAmount","(Ljava/lang/String;)V","invokevirtual",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6257(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6258(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/PaymentDecision","type","Ljava/lang/String;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","setChosenType","(Ljava/lang/String;)V","invokevirtual",11);}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6259(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/cost/CostChooseCreatureType","convertAmount","()Ljava/lang/Integer;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Choose ")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/cost/CostChooseCreatureType","getAmount","()Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Push(JValue.R(rt.String("creature type")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/cost/Cost","convertAmountTypeToWords","(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",31);}
case 31:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",34);}
case 34:{f.StackOp("pop");f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",39);}
case 39:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6260(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostChooseCreatureType;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C519{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostAddMana","forge/game/cost/CostPart",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JMethod(6218,"forge/game/cost/CostAddMana","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V",1,4,4,new JHandler[]{},M6218));
c.Add(new JMethod(6219,"forge/game/cost/CostAddMana","paymentOrder","()I",1,1,1,new JHandler[]{},M6219));
c.Add(new JMethod(6220,"forge/game/cost/CostAddMana","toString","()Ljava/lang/String;",17,3,3,new JHandler[]{},M6220));
c.Add(new JMethod(6221,"forge/game/cost/CostAddMana","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",17,4,1,new JHandler[]{},M6221));
c.Add(new JMethod(6222,"forge/game/cost/CostAddMana","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z",1,10,7,new JHandler[]{},M6222));
c.Add(new JMethod(6223,"forge/game/cost/CostAddMana","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6223));
}

internal static JStep M6218(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/cost/CostPart","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6219(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(5));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6220(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/cost/CostAddMana","convertAmount","()Ljava/lang/Integer;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Add ")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/cost/CostAddMana","getType","()Ljava/lang/String;","invokevirtual",23);}
case 23:{return rt.DynamicCall(f,"forge/game/cost/CostAddMana:6220:23:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",28);}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",32);}
case 32:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","repeat","(Ljava/lang/String;I)Ljava/lang/String;","invokestatic",35);}
case 35:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",38);}
case 38:{f.StackOp("pop");f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",43);}
case 43:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6221(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6222(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[5]=f.Pop();f.Pc=6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",13);}
case 13:{f.Locals[6]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/cost/CostAddMana","getType","()Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Locals[7]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{f.Locals[8]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[8]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/PaymentDecision","c","I"));f.Pc=30;continue;}
case 30:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?117:33;continue;}
case 33:{f.Push(f.Locals[7]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",38);}
case 38:{f.Pc=f.Pop().Int==0?83:41;continue;}
case 41:{f.Push(f.Locals[7]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",46);}
case 46:{f.Locals[9]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[9]);f.Pc=50;continue;}
case 50:{f.Pc=f.Pop().Int<=0?80:53;continue;}
case 53:{f.Push(f.Locals[6]);f.Pc=55;continue;}
case 55:{if(!rt.EnsureInitialized(f,"forge/game/mana/Mana"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/Mana")));f.Pc=58;continue;}
case 58:{f.StackOp("dup");f.Pc=59;continue;}
case 59:{f.Push(JValue.I(32));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(null));f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/mana/Mana","<init>","(BLforge/game/card/Card;Lforge/game/spellability/AbilityManaPart;Lforge/game/player/Player;)V","invokespecial",68);}
case 68:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",73);}
case 73:{f.StackOp("pop");f.Pc=74;continue;}
case 74:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(-1)));f.Pc=77;continue;}
case 77:{f.Pc=48;continue;}
case 80:{f.Pc=111;continue;}
case 83:{f.Push(f.Locals[7]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/card/mana/ManaAtom","fromName","(Ljava/lang/String;)B","invokestatic",88);}
case 88:{f.Locals[9]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[6]);f.Pc=92;continue;}
case 92:{if(!rt.EnsureInitialized(f,"forge/game/mana/Mana"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/Mana")));f.Pc=95;continue;}
case 95:{f.StackOp("dup");f.Pc=96;continue;}
case 96:{f.Push(f.Locals[9]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[5]);f.Pc=100;continue;}
case 100:{f.Push(JValue.R(null));f.Pc=101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/mana/Mana","<init>","(BLforge/game/card/Card;Lforge/game/spellability/AbilityManaPart;Lforge/game/player/Player;)V","invokespecial",105);}
case 105:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",110);}
case 110:{f.StackOp("pop");f.Pc=111;continue;}
case 111:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=114;continue;}
case 114:{f.Pc=24;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/player/Player","getManaPool","()Lforge/game/mana/ManaPool;","invokevirtual",121);}
case 121:{f.Push(f.Locals[6]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/mana/ManaPool","addMana","(Ljava/lang/Iterable;)V","invokevirtual",126);}
case 126:{f.Push(JValue.I(1));f.Pc=127;continue;}
case 127:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6223(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostAddMana;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

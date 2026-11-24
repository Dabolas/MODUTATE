// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C539{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostGainLife","forge/game/cost/CostPart",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JField("cntPlayers","I",false,JValue.Default("I"),null));
c.Add(new JMethod(6371,"forge/game/cost/CostGainLife","<init>","(Ljava/lang/String;Ljava/lang/String;I)V",1,4,4,new JHandler[]{},M6371));
c.Add(new JMethod(6372,"forge/game/cost/CostGainLife","getCntPlayers","()I",1,1,1,new JHandler[]{},M6372));
c.Add(new JMethod(6373,"forge/game/cost/CostGainLife","toString","()Ljava/lang/String;",17,2,2,new JHandler[]{},M6373));
c.Add(new JMethod(6374,"forge/game/cost/CostGainLife","getPotentialTargets","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Ljava/util/List;",1,6,5,new JHandler[]{},M6374));
c.Add(new JMethod(6375,"forge/game/cost/CostGainLife","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",17,8,3,new JHandler[]{},M6375));
c.Add(new JMethod(6376,"forge/game/cost/CostGainLife","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z",17,9,4,new JHandler[]{},M6376));
c.Add(new JMethod(6377,"forge/game/cost/CostGainLife","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6377));
}

internal static JStep M6371(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/cost/CostPart","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostGainLife","cntPlayers","I",value);f.Pc=12;continue;}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6372(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostGainLife","cntPlayers","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6373(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Have an opponent gain ")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/cost/CostGainLife","getAmount","()Ljava/lang/String;","invokevirtual",18);}
case 18:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",21);}
case 21:{f.Push(JValue.R(rt.String(" life")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",31);}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6374(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[4]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",23);}
case 23:{f.Pc=f.Pop().Int==0?68:26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[5]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/cost/CostGainLife","getType","()Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",49);}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/player/Player","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int==0?65:56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",64);}
case 64:{f.StackOp("pop");f.Pc=65;continue;}
case 65:{f.Pc=16;continue;}
case 68:{f.Push(f.Locals[3]);f.Pc=69;continue;}
case 69:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6375(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[4]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/cost/CostGainLife","getPotentialTargets","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokevirtual",9);}
case 9:{f.Locals[5]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[5]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",18);}
case 18:{f.Locals[6]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[6]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int==0?56:30;continue;}
case 30:{f.Push(f.Locals[6]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Locals[7]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[7]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/player/Player","canGainLife","()Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?53:50;continue;}
case 50:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=53;continue;}
case 53:{f.Pc=20;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostGainLife","cntPlayers","I"));f.Pc=62;continue;}
case 62:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?86:65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostGainLife","cntPlayers","I"));f.Pc=69;continue;}
case 69:{f.Push(JValue.I(2147483647));f.Pc=71;continue;}
case 71:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?90:74;continue;}
case 74:{f.Push(f.Locals[4]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[5]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",83);}
case 83:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?90:86;continue;}
case 86:{f.Push(JValue.I(1));f.Pc=87;continue;}
case 87:{f.Pc=91;continue;}
case 90:{f.Push(JValue.I(0));f.Pc=91;continue;}
case 91:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6376(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[3]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/CostGainLife","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",5);}
case 5:{f.Locals[5]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostGainLife","cntPlayers","I"));f.Pc=11;continue;}
case 11:{f.Locals[6]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/PaymentDecision","players","Ljava/util/List;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[7]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[7]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",31);}
case 31:{f.Pc=f.Pop().Int==0?83:34;continue;}
case 34:{f.Push(f.Locals[7]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Locals[8]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[6]);f.Pc=48;continue;}
case 48:{f.Pc=f.Pop().Int!=0?54:51;continue;}
case 51:{f.Pc=83;continue;}
case 54:{f.Push(f.Locals[8]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/player/Player","canGainLife","()Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int!=0?64:62;continue;}
case 62:{f.Push(JValue.I(0));f.Pc=63;continue;}
case 63:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 64:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(-1)));f.Pc=67;continue;}
case 67:{f.Push(f.Locals[8]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",75);}
case 75:{f.Push(f.Locals[3]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/player/Player","gainLife","(ILforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",79);}
case 79:{f.StackOp("pop");f.Pc=80;continue;}
case 80:{f.Pc=24;continue;}
case 83:{f.Push(JValue.I(1));f.Pc=84;continue;}
case 84:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6377(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostGainLife;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

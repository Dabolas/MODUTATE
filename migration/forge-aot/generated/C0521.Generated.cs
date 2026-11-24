// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C521{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostBehold","forge/game/cost/CostReveal",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JMethod(6237,"forge/game/cost/CostBehold","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V",1,4,5,new JHandler[]{},M6237));
c.Add(new JMethod(6238,"forge/game/cost/CostBehold","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",1,8,4,new JHandler[]{},M6238));
c.Add(new JMethod(6239,"forge/game/cost/CostBehold","toString","()Ljava/lang/String;",1,4,4,new JHandler[]{},M6239));
c.Add(new JMethod(6240,"forge/game/cost/CostBehold","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6240));
}

internal static JStep M6237(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Hand,Battlefield")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/cost/CostReveal","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6238(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostBehold","revealFrom","Ljava/util/List;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",8);}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/cost/CostBehold","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",15);}
case 15:{f.Locals[5]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/cost/CostBehold","getType","()Ljava/lang/String;","invokevirtual",21);}
case 21:{f.Push(JValue.R(rt.String("ChosenType")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Int==0?82:29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",36);}
case 36:{f.Locals[6]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[6]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",45);}
case 45:{f.Pc=f.Pop().Int==0?80:48;continue;}
case 48:{f.Push(f.Locals[6]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",55);}
case 55:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=58;continue;}
case 58:{f.Locals[7]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[7]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/card/CardPredicates","sharesCreatureTypeWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",67);}
case 67:{return rt.Call(f,"forge/game/card/CardLists","count","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)I","invokestatic",70);}
case 70:{f.Push(f.Locals[5]);f.Pc=72;continue;}
case 72:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?77:75;continue;}
case 75:{f.Push(JValue.I(1));f.Pc=76;continue;}
case 76:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 77:{f.Pc=38;continue;}
case 80:{f.Push(JValue.I(0));f.Pc=81;continue;}
case 81:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/cost/CostReveal","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z","invokespecial",89);}
case 89:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6239(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Behold ")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/cost/CostBehold","convertAmount","()Ljava/lang/Integer;","invokevirtual",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/cost/CostBehold","getTypeDescription","()Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Reference!=null?34:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/cost/CostBehold","getType","()Ljava/lang/String;","invokevirtual",31);}
case 31:{f.Pc=38;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/cost/CostBehold","getTypeDescription","()Ljava/lang/String;","invokevirtual",38);}
case 38:{f.Locals[3]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/cost/CostBehold","getAmount","()Ljava/lang/String;","invokevirtual",45);}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/cost/Cost","convertAmountTypeToWords","(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",49);}
case 49:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",57);}
case 57:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6240(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostBehold;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

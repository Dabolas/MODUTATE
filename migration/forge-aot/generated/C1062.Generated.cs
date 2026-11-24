// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1062{
internal static JClass Build(){var c=new JClass("forge/item/ItemPredicate","java/lang/Object",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("IsBoosterPack","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IsPrebuiltDeck","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IsFatPack","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IsTournamentPack","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IsStarterDeck","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_PACK_OR_DECK","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JMethod(11242,"forge/item/ItemPredicate","<init>","()V",1,1,1,new JHandler[]{},M11242));
c.Add(new JMethod(11243,"forge/item/ItemPredicate","lambda$static$1","(Ljava/lang/Object;)Z",4106,1,1,new JHandler[]{},M11243));
c.Add(new JMethod(11244,"forge/item/ItemPredicate","lambda$static$0","(Ljava/lang/Object;)Z",4106,1,1,new JHandler[]{},M11244));
c.Add(new JMethod(11245,"forge/item/ItemPredicate","<clinit>","()V",8,0,2,new JHandler[]{},M11245));
}

internal static JStep M11242(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11243(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/item/TournamentPack")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?21:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/TournamentPack"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/item/TournamentPack","isStarterDeck","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11244(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/item/TournamentPack")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?21:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/TournamentPack"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/item/TournamentPack","isStarterDeck","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int!=0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11245(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/item/BoosterPack")));f.Pc=2;continue;}
case 2:{f.StackOp("dup");f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",6);}
case 6:{f.StackOp("pop");f.Pc=7;continue;}
case 7:{return rt.DynamicCall(f,"forge/item/ItemPredicate:11245:7:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/Class;)Ljava/util/function/Predicate;",12);}
case 12:{if(!rt.StaticReady(f,"forge/item/ItemPredicate","IsBoosterPack","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/ItemPredicate","IsBoosterPack","Ljava/util/function/Predicate;",f.Pop());f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.ClassObject("forge/item/PreconDeck")));f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{return rt.DynamicCall(f,"forge/item/ItemPredicate:11245:22:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/Class;)Ljava/util/function/Predicate;",27);}
case 27:{if(!rt.StaticReady(f,"forge/item/ItemPredicate","IsPrebuiltDeck","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/ItemPredicate","IsPrebuiltDeck","Ljava/util/function/Predicate;",f.Pop());f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.ClassObject("forge/item/FatPack")));f.Pc=32;continue;}
case 32:{f.StackOp("dup");f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",36);}
case 36:{f.StackOp("pop");f.Pc=37;continue;}
case 37:{return rt.DynamicCall(f,"forge/item/ItemPredicate:11245:37:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/Class;)Ljava/util/function/Predicate;",42);}
case 42:{if(!rt.StaticReady(f,"forge/item/ItemPredicate","IsFatPack","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/ItemPredicate","IsFatPack","Ljava/util/function/Predicate;",f.Pop());f.Pc=45;continue;}
case 45:{return rt.DynamicCall(f,"forge/item/ItemPredicate:11245:45:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",50);}
case 50:{if(!rt.StaticReady(f,"forge/item/ItemPredicate","IsTournamentPack","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/ItemPredicate","IsTournamentPack","Ljava/util/function/Predicate;",f.Pop());f.Pc=53;continue;}
case 53:{return rt.DynamicCall(f,"forge/item/ItemPredicate:11245:53:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",58);}
case 58:{if(!rt.StaticReady(f,"forge/item/ItemPredicate","IsStarterDeck","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/ItemPredicate","IsStarterDeck","Ljava/util/function/Predicate;",f.Pop());f.Pc=61;continue;}
case 61:{if(!rt.StaticReady(f,"forge/item/ItemPredicate","IsBoosterPack","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/ItemPredicate","IsBoosterPack","Ljava/util/function/Predicate;"));f.Pc=64;continue;}
case 64:{if(!rt.StaticReady(f,"forge/item/ItemPredicate","IsFatPack","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/ItemPredicate","IsFatPack","Ljava/util/function/Predicate;"));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",72);}
case 72:{if(!rt.StaticReady(f,"forge/item/ItemPredicate","IsTournamentPack","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/ItemPredicate","IsTournamentPack","Ljava/util/function/Predicate;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",80);}
case 80:{if(!rt.StaticReady(f,"forge/item/ItemPredicate","IsStarterDeck","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/ItemPredicate","IsStarterDeck","Ljava/util/function/Predicate;"));f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",88);}
case 88:{if(!rt.StaticReady(f,"forge/item/ItemPredicate","IsPrebuiltDeck","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/ItemPredicate","IsPrebuiltDeck","Ljava/util/function/Predicate;"));f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",96);}
case 96:{if(!rt.StaticReady(f,"forge/item/ItemPredicate","IS_PACK_OR_DECK","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/ItemPredicate","IS_PACK_OR_DECK","Ljava/util/function/Predicate;",f.Pop());f.Pc=99;continue;}
case 99:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

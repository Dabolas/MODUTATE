// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C30{
internal static JClass Build(){var c=new JClass("forge/card/CardFacePredicates","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("IS_BASIC_LAND","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_NONBASIC_LAND","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_CREATURE","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_LEGENDARY","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_NON_LAND","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JMethod(566,"forge/card/CardFacePredicates","<init>","()V",1,1,1,new JHandler[]{},M566));
c.Add(new JMethod(567,"forge/card/CardFacePredicates","coreType","(ZLforge/card/CardType$CoreType;)Ljava/util/function/Predicate;",9,2,4,new JHandler[]{},M567));
c.Add(new JMethod(568,"forge/card/CardFacePredicates","superType","(ZLforge/card/CardType$Supertype;)Ljava/util/function/Predicate;",9,2,4,new JHandler[]{},M568));
c.Add(new JMethod(569,"forge/card/CardFacePredicates","cmc","(I)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M569));
c.Add(new JMethod(570,"forge/card/CardFacePredicates","valid","(Ljava/lang/String;)Ljava/util/function/Predicate;",9,1,3,new JHandler[]{},M570));
c.Add(new JMethod(571,"forge/card/CardFacePredicates","lambda$static$2","(Lforge/card/ICardFace;)Z",4106,1,1,new JHandler[]{},M571));
c.Add(new JMethod(572,"forge/card/CardFacePredicates","lambda$static$1","(Lforge/card/ICardFace;)Z",4106,1,1,new JHandler[]{},M572));
c.Add(new JMethod(573,"forge/card/CardFacePredicates","lambda$cmc$0","(ILforge/card/ICardFace;)Z",4106,3,2,new JHandler[]{},M573));
c.Add(new JMethod(574,"forge/card/CardFacePredicates","<clinit>","()V",8,0,2,new JHandler[]{},M574));
}

internal static JStep M566(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M567(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardFacePredicates$PredicateCoreType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardFacePredicates$PredicateCoreType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/CardFacePredicates$PredicateCoreType","<init>","(Lforge/card/CardType$CoreType;Z)V","invokespecial",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M568(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardFacePredicates$PredicateSuperType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardFacePredicates$PredicateSuperType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/CardFacePredicates$PredicateSuperType","<init>","(Lforge/card/CardType$Supertype;Z)V","invokespecial",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M569(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/card/CardFacePredicates:569:1:java/lang/invoke/LambdaMetafactory.metafactory","(I)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M570(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardFacePredicates$ValidPredicate"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardFacePredicates$ValidPredicate")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardFacePredicates$ValidPredicate","<init>","(Ljava/lang/String;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M571(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",6);}
case 6:{return rt.Call(f,"forge/card/CardType","isLand","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?28:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",18);}
case 18:{return rt.Call(f,"forge/card/CardType","isBasicLand","()Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int!=0?28:24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Pc=29;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M572(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",6);}
case 6:{return rt.Call(f,"forge/card/CardType","isBasicLand","()Z","invokevirtual",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M573(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ICardFace","getManaCost","()Lforge/card/mana/ManaCost;","invokeinterface",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference==null?23:11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/card/mana/ManaCost","getCMC","()I","invokevirtual",15);}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?23:19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M574(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/card/CardFacePredicates:574:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",5);}
case 5:{if(!rt.StaticReady(f,"forge/card/CardFacePredicates","IS_BASIC_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardFacePredicates","IS_BASIC_LAND","Ljava/util/function/Predicate;",f.Pop());f.Pc=8;continue;}
case 8:{return rt.DynamicCall(f,"forge/card/CardFacePredicates:574:8:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",13);}
case 13:{if(!rt.StaticReady(f,"forge/card/CardFacePredicates","IS_NONBASIC_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardFacePredicates","IS_NONBASIC_LAND","Ljava/util/function/Predicate;",f.Pop());f.Pc=16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Creature","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Creature","Lforge/card/CardType$CoreType;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardFacePredicates","coreType","(ZLforge/card/CardType$CoreType;)Ljava/util/function/Predicate;","invokestatic",23);}
case 23:{if(!rt.StaticReady(f,"forge/card/CardFacePredicates","IS_CREATURE","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardFacePredicates","IS_CREATURE","Ljava/util/function/Predicate;",f.Pop());f.Pc=26;continue;}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","Legendary","Lforge/card/CardType$Supertype;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Supertype","Legendary","Lforge/card/CardType$Supertype;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/CardFacePredicates","superType","(ZLforge/card/CardType$Supertype;)Ljava/util/function/Predicate;","invokestatic",33);}
case 33:{if(!rt.StaticReady(f,"forge/card/CardFacePredicates","IS_LEGENDARY","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardFacePredicates","IS_LEGENDARY","Ljava/util/function/Predicate;",f.Pop());f.Pc=36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Land","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Land","Lforge/card/CardType$CoreType;"));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/card/CardFacePredicates","coreType","(ZLforge/card/CardType$CoreType;)Ljava/util/function/Predicate;","invokestatic",43);}
case 43:{if(!rt.StaticReady(f,"forge/card/CardFacePredicates","IS_NON_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardFacePredicates","IS_NON_LAND","Ljava/util/function/Predicate;",f.Pop());f.Pc=46;continue;}
case 46:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

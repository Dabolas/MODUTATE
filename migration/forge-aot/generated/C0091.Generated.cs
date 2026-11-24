// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C91{
internal static JClass Build(){var c=new JClass("forge/deck/DeckFormat$2","forge/deck/DeckFormat",new string[]{},16432);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("bannedCommanders","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JMethod(1478,"forge/deck/DeckFormat$2","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;ILjava/util/function/Predicate;)V",2,7,7,new JHandler[]{},M1478));
c.Add(new JMethod(1479,"forge/deck/DeckFormat$2","isLegalCommander","(Lforge/card/CardRules;)Z",1,2,2,new JHandler[]{},M1479));
c.Add(new JMethod(1480,"forge/deck/DeckFormat$2","adjustCMCLevels","(Ljava/util/List;)V",1,2,5,new JHandler[]{},M1480));
}

internal static JStep M1478(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[5]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[6]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/deck/DeckFormat","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;ILjava/util/function/Predicate;)V","invokespecial",13);}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Derevi, Empyrial Tactician")));f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("Erayo, Soratami Ascendant")));f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("Rofellos, Llanowar Emissary")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"com/google/common/collect/ImmutableSet","of","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableSet;","invokestatic",23);}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckFormat$2","bannedCommanders","Ljava/util/Set;",value);f.Pc=26;continue;}
case 26:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1479(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/DeckFormat","isLegalCommander","(Lforge/card/CardRules;)Z","invokespecial",5);}
case 5:{f.Pc=f.Pop().Int==0?28:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat$2","bannedCommanders","Ljava/util/Set;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",16);}
case 16:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int!=0?28:24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Pc=29;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1480(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",6);}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGeneratorBase$FilterCMC")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC","<init>","(II)V","invokespecial",16);}
case 16:{f.Push(JValue.I(3));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",20);}
case 20:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",23);}
case 23:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",28);}
case 28:{f.StackOp("pop");f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGeneratorBase$FilterCMC")));f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{f.Push(JValue.I(2));f.Pc=35;continue;}
case 35:{f.Push(JValue.I(2));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC","<init>","(II)V","invokespecial",39);}
case 39:{f.Push(JValue.I(3));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",43);}
case 43:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",46);}
case 46:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",51);}
case 51:{f.StackOp("pop");f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGeneratorBase$FilterCMC")));f.Pc=56;continue;}
case 56:{f.StackOp("dup");f.Pc=57;continue;}
case 57:{f.Push(JValue.I(3));f.Pc=58;continue;}
case 58:{f.Push(JValue.I(3));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC","<init>","(II)V","invokespecial",62);}
case 62:{f.Push(JValue.I(3));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",66);}
case 66:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",69);}
case 69:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",74);}
case 74:{f.StackOp("pop");f.Pc=75;continue;}
case 75:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

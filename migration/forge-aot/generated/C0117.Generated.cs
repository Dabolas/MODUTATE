// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C117{
internal static JClass Build(){var c=new JClass("forge/deck/generation/DeckGeneratorMonoColor","forge/deck/generation/DeckGeneratorBase",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("cmcLevels","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(1718,"forge/deck/generation/DeckGeneratorMonoColor","getLandPercentage","()F",20,1,1,new JHandler[]{},M1718));
c.Add(new JMethod(1719,"forge/deck/generation/DeckGeneratorMonoColor","getCreaturePercentage","()F",20,1,1,new JHandler[]{},M1719));
c.Add(new JMethod(1720,"forge/deck/generation/DeckGeneratorMonoColor","getSpellPercentage","()F",20,1,1,new JHandler[]{},M1720));
c.Add(new JMethod(1721,"forge/deck/generation/DeckGeneratorMonoColor","<init>","(Lforge/deck/generation/IDeckGenPool;Lforge/deck/DeckFormat;Ljava/util/function/Predicate;Ljava/lang/String;)V",1,5,8,new JHandler[]{},M1721));
c.Add(new JMethod(1722,"forge/deck/generation/DeckGeneratorMonoColor","<init>","(Lforge/deck/generation/IDeckGenPool;Lforge/deck/DeckFormat;Ljava/lang/String;)V",1,4,8,new JHandler[]{},M1722));
c.Add(new JMethod(1723,"forge/deck/generation/DeckGeneratorMonoColor","initialize","(Ljava/lang/String;)V",1,3,5,new JHandler[]{},M1723));
c.Add(new JMethod(1724,"forge/deck/generation/DeckGeneratorMonoColor","getDeck","(IZ)Lforge/deck/CardPool;",17,4,4,new JHandler[]{},M1724));
}

internal static JStep M1718(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.F(0.4000000059604645f));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1719(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.F(0.3499999940395355f));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1720(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.F(0.25f));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1721(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","<init>","(Lforge/deck/generation/IDeckGenPool;Lforge/deck/DeckFormat;Ljava/util/function/Predicate;)V","invokespecial",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(4));f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.NewArray("Lorg/apache/commons/lang3/tuple/ImmutablePair;",f.Pop().Int)));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGeneratorBase$FilterCMC")));f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(2));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC","<init>","(II)V","invokespecial",23);}
case 23:{f.Push(JValue.I(10));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",28);}
case 28:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",31);}
case 31:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=32;continue;}
case 32:{f.StackOp("dup");f.Pc=33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGeneratorBase$FilterCMC")));f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{f.Push(JValue.I(3));f.Pc=39;continue;}
case 39:{f.Push(JValue.I(4));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC","<init>","(II)V","invokespecial",43);}
case 43:{f.Push(JValue.I(8));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",48);}
case 48:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",51);}
case 51:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=52;continue;}
case 52:{f.StackOp("dup");f.Pc=53;continue;}
case 53:{f.Push(JValue.I(2));f.Pc=54;continue;}
case 54:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGeneratorBase$FilterCMC")));f.Pc=57;continue;}
case 57:{f.StackOp("dup");f.Pc=58;continue;}
case 58:{f.Push(JValue.I(5));f.Pc=59;continue;}
case 59:{f.Push(JValue.I(6));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC","<init>","(II)V","invokespecial",64);}
case 64:{f.Push(JValue.I(5));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",68);}
case 68:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",71);}
case 71:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=72;continue;}
case 72:{f.StackOp("dup");f.Pc=73;continue;}
case 73:{f.Push(JValue.I(3));f.Pc=74;continue;}
case 74:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGeneratorBase$FilterCMC")));f.Pc=77;continue;}
case 77:{f.StackOp("dup");f.Pc=78;continue;}
case 78:{f.Push(JValue.I(7));f.Pc=80;continue;}
case 80:{f.Push(JValue.I(20));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC","<init>","(II)V","invokespecial",85);}
case 85:{f.Push(JValue.I(3));f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",89);}
case 89:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",92);}
case 92:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=93;continue;}
case 93:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",96);}
case 96:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorMonoColor","cmcLevels","Ljava/util/List;",value);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[4]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/deck/generation/DeckGeneratorMonoColor","initialize","(Ljava/lang/String;)V","invokevirtual",105);}
case 105:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1722(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","<init>","(Lforge/deck/generation/IDeckGenPool;Lforge/deck/DeckFormat;)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(4));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.NewArray("Lorg/apache/commons/lang3/tuple/ImmutablePair;",f.Pop().Int)));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGeneratorBase$FilterCMC")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC","<init>","(II)V","invokespecial",22);}
case 22:{f.Push(JValue.I(10));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",27);}
case 27:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",30);}
case 30:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGeneratorBase$FilterCMC")));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(JValue.I(3));f.Pc=38;continue;}
case 38:{f.Push(JValue.I(4));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC","<init>","(II)V","invokespecial",42);}
case 42:{f.Push(JValue.I(8));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",47);}
case 47:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",50);}
case 50:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=51;continue;}
case 51:{f.StackOp("dup");f.Pc=52;continue;}
case 52:{f.Push(JValue.I(2));f.Pc=53;continue;}
case 53:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGeneratorBase$FilterCMC")));f.Pc=56;continue;}
case 56:{f.StackOp("dup");f.Pc=57;continue;}
case 57:{f.Push(JValue.I(5));f.Pc=58;continue;}
case 58:{f.Push(JValue.I(6));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC","<init>","(II)V","invokespecial",63);}
case 63:{f.Push(JValue.I(5));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",67);}
case 67:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",70);}
case 70:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=71;continue;}
case 71:{f.StackOp("dup");f.Pc=72;continue;}
case 72:{f.Push(JValue.I(3));f.Pc=73;continue;}
case 73:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGeneratorBase$FilterCMC")));f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(7));f.Pc=79;continue;}
case 79:{f.Push(JValue.I(20));f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC","<init>","(II)V","invokespecial",84);}
case 84:{f.Push(JValue.I(3));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",88);}
case 88:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",91);}
case 91:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=92;continue;}
case 92:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",95);}
case 95:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorMonoColor","cmcLevels","Ljava/util/List;",value);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[3]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/deck/generation/DeckGeneratorMonoColor","initialize","(Ljava/lang/String;)V","invokevirtual",103);}
case 103:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1723(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int!=0?28:7;continue;}
case 7:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",10);}
case 10:{f.Push(JValue.I(5));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",22);}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorMonoColor","colors","Lforge/card/ColorSet;",value);f.Pc=25;continue;}
case 25:{f.Pc=43;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{f.Push(JValue.I(0));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/card/ColorSet","fromNames","([Ljava/lang/String;)Lforge/card/ColorSet;","invokestatic",40);}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorMonoColor","colors","Lforge/card/ColorSet;",value);f.Pc=43;continue;}
case 43:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1724(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorMonoColor","cmcLevels","Ljava/util/List;"));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/deck/generation/DeckGeneratorMonoColor","addCreaturesAndSpells","(ILjava/util/List;Z)V","invokevirtual",10);}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/deck/generation/DeckGeneratorMonoColor","getLandPercentage","()F","invokevirtual",16);}
case 16:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fmul",a,b));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/Math","round","(F)I","invokestatic",20);}
case 20:{f.Locals[3]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorMonoColor","trace","Lforge/util/DebugTrace;"));f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("numLands:")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",30);}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",34);}
case 34:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",37);}
case 37:{f.Push(JValue.R(rt.String("\n")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",42);}
case 42:{f.StackOp("pop");f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/deck/generation/DeckGeneratorMonoColor","addBasicLand","(I)V","invokevirtual",48);}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorMonoColor","trace","Lforge/util/DebugTrace;"));f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("DeckSize:")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",57);}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorMonoColor","tDeck","Lforge/deck/CardPool;"));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/deck/CardPool","countAll","()I","invokevirtual",64);}
case 64:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",67);}
case 67:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",70);}
case 70:{f.Push(JValue.R(rt.String("\n")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/deck/generation/DeckGeneratorMonoColor","adjustDeckSize","(I)V","invokevirtual",81);}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorMonoColor","trace","Lforge/util/DebugTrace;"));f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("DeckSize:")));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",90);}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorMonoColor","tDeck","Lforge/deck/CardPool;"));f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/deck/CardPool","countAll","()I","invokevirtual",97);}
case 97:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",100);}
case 100:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",103);}
case 103:{f.Push(JValue.R(rt.String("\n")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",108);}
case 108:{f.StackOp("pop");f.Pc=109;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorMonoColor","tDeck","Lforge/deck/CardPool;"));f.Pc=113;continue;}
case 113:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C110{
internal static JClass Build(){var c=new JClass("forge/deck/generation/DeckGenerator2Color","forge/deck/generation/DeckGeneratorBase",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("cmcLevels","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(1658,"forge/deck/generation/DeckGenerator2Color","getLandPercentage","()F",20,1,1,new JHandler[]{},M1658));
c.Add(new JMethod(1659,"forge/deck/generation/DeckGenerator2Color","getCreaturePercentage","()F",20,1,1,new JHandler[]{},M1659));
c.Add(new JMethod(1660,"forge/deck/generation/DeckGenerator2Color","getSpellPercentage","()F",20,1,1,new JHandler[]{},M1660));
c.Add(new JMethod(1661,"forge/deck/generation/DeckGenerator2Color","<init>","(Lforge/deck/generation/IDeckGenPool;Lforge/deck/DeckFormat;Ljava/util/function/Predicate;Ljava/lang/String;Ljava/lang/String;)V",1,6,8,new JHandler[]{},M1661));
c.Add(new JMethod(1662,"forge/deck/generation/DeckGenerator2Color","<init>","(Lforge/deck/generation/IDeckGenPool;Lforge/deck/DeckFormat;Ljava/lang/String;Ljava/lang/String;)V",1,5,8,new JHandler[]{},M1662));
c.Add(new JMethod(1663,"forge/deck/generation/DeckGenerator2Color","initialize","(Lforge/deck/DeckFormat;Ljava/lang/String;Ljava/lang/String;)V",2,9,4,new JHandler[]{},M1663));
c.Add(new JMethod(1664,"forge/deck/generation/DeckGenerator2Color","getDeck","(IZ)Lforge/deck/CardPool;",17,7,7,new JHandler[]{},M1664));
}

internal static JStep M1658(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.F(0.41999998688697815f));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1659(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.F(0.3400000035762787f));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1660(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.F(0.23999999463558197f));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1661(JRuntime rt,JFrame f)
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
case 23:{f.Push(JValue.I(6));f.Pc=25;continue;}
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
case 43:{f.Push(JValue.I(4));f.Pc=44;continue;}
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
case 63:{f.Push(JValue.I(2));f.Pc=64;continue;}
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
case 84:{f.Push(JValue.I(1));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",88);}
case 88:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",91);}
case 91:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=92;continue;}
case 92:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",95);}
case 95:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGenerator2Color","cmcLevels","Ljava/util/List;",value);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[2]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[4]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[5]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/deck/generation/DeckGenerator2Color","initialize","(Lforge/deck/DeckFormat;Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",107);}
case 107:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1662(JRuntime rt,JFrame f)
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
case 22:{f.Push(JValue.I(6));f.Pc=24;continue;}
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
case 42:{f.Push(JValue.I(4));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",46);}
case 46:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",49);}
case 49:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=50;continue;}
case 50:{f.StackOp("dup");f.Pc=51;continue;}
case 51:{f.Push(JValue.I(2));f.Pc=52;continue;}
case 52:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGeneratorBase$FilterCMC")));f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(5));f.Pc=57;continue;}
case 57:{f.Push(JValue.I(6));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC","<init>","(II)V","invokespecial",62);}
case 62:{f.Push(JValue.I(2));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",66);}
case 66:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",69);}
case 69:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=70;continue;}
case 70:{f.StackOp("dup");f.Pc=71;continue;}
case 71:{f.Push(JValue.I(3));f.Pc=72;continue;}
case 72:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGeneratorBase$FilterCMC")));f.Pc=75;continue;}
case 75:{f.StackOp("dup");f.Pc=76;continue;}
case 76:{f.Push(JValue.I(7));f.Pc=78;continue;}
case 78:{f.Push(JValue.I(20));f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC","<init>","(II)V","invokespecial",83);}
case 83:{f.Push(JValue.I(1));f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",87);}
case 87:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",90);}
case 90:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=91;continue;}
case 91:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",94);}
case 94:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGenerator2Color","cmcLevels","Ljava/util/List;",value);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[3]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[4]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/deck/generation/DeckGenerator2Color","initialize","(Lforge/deck/DeckFormat;Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",105);}
case 105:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1663(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B","invokestatic",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B","invokestatic",10);}
case 10:{f.Locals[5]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGenerator2Color","cmcLevels","Ljava/util/List;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/deck/DeckFormat","adjustCMCLevels","(Ljava/util/List;)V","invokevirtual",20);}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Int!=0?74:25;continue;}
case 25:{f.Push(f.Locals[5]);f.Pc=27;continue;}
case 27:{f.Pc=f.Pop().Int!=0?74:30;continue;}
case 30:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",33);}
case 33:{f.Push(JValue.I(5));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",37);}
case 37:{f.Locals[6]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[6]);f.Pc=41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",46);}
case 46:{f.Push(JValue.I(4));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",50);}
case 50:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=51;continue;}
case 51:{f.Push(JValue.I(5));f.Pc=52;continue;}
case 52:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=53;continue;}
case 53:{f.Locals[7]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(JValue.I(1));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=60;continue;}
case 60:{f.Push(JValue.I(1));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[7]);f.Pc=63;continue;}
case 63:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=64;continue;}
case 64:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",68);}
case 68:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGenerator2Color","colors","Lforge/card/ColorSet;",value);f.Pc=71;continue;}
case 71:{f.Pc=149;continue;}
case 74:{f.Push(f.Locals[4]);f.Pc=76;continue;}
case 76:{f.Pc=f.Pop().Int==0?84:79;continue;}
case 79:{f.Push(f.Locals[5]);f.Pc=81;continue;}
case 81:{f.Pc=f.Pop().Int!=0?137:84;continue;}
case 84:{f.Push(f.Locals[4]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[5]);f.Pc=88;continue;}
case 88:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=89;continue;}
case 89:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=90;continue;}
case 90:{f.Locals[6]=f.Pop();f.Pc=92;continue;}
case 92:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=95;continue;}
case 95:{f.Push(f.Locals[6]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/util/Arrays","binarySearch","([BB)I","invokestatic",100);}
case 100:{f.Locals[7]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[7]);f.Pc=104;continue;}
case 104:{f.Push(JValue.I(1));f.Pc=105;continue;}
case 105:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",109);}
case 109:{f.Push(JValue.I(4));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",113);}
case 113:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=114;continue;}
case 114:{f.Push(JValue.I(5));f.Pc=115;continue;}
case 115:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=116;continue;}
case 116:{f.Locals[8]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(JValue.I(1));f.Pc=120;continue;}
case 120:{f.Push(f.Locals[7]);f.Pc=122;continue;}
case 122:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=123;continue;}
case 123:{f.Push(JValue.I(1));f.Pc=124;continue;}
case 124:{f.Push(f.Locals[8]);f.Pc=126;continue;}
case 126:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=127;continue;}
case 127:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",131);}
case 131:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGenerator2Color","colors","Lforge/card/ColorSet;",value);f.Pc=134;continue;}
case 134:{f.Pc=149;continue;}
case 137:{f.Push(f.Locals[0]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[4]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[5]);f.Pc=142;continue;}
case 142:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",146);}
case 146:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGenerator2Color","colors","Lforge/card/ColorSet;",value);f.Pc=149;continue;}
case 149:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1664(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGenerator2Color","cmcLevels","Ljava/util/List;"));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/deck/generation/DeckGenerator2Color","addCreaturesAndSpells","(ILjava/util/List;Z)V","invokevirtual",10);}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/deck/generation/DeckGenerator2Color","getLandPercentage","()F","invokevirtual",16);}
case 16:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fmul",a,b));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/Math","round","(F)I","invokestatic",20);}
case 20:{f.Locals[3]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/deck/generation/DeckGenerator2Color","adjustDeckSize","(I)V","invokevirtual",28);}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGenerator2Color","trace","Lforge/util/DebugTrace;"));f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("Adjusted deck size to: %d, should add %d land(s)%n")));f.Pc=34;continue;}
case 34:{f.Push(JValue.I(2));f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=38;continue;}
case 38:{f.StackOp("dup");f.Pc=39;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",46);}
case 46:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=47;continue;}
case 47:{f.StackOp("dup");f.Pc=48;continue;}
case 48:{f.Push(JValue.I(1));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",53);}
case 53:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",57);}
case 57:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",60);}
case 60:{f.StackOp("pop");f.Pc=61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/deck/generation/DeckGenerator2Color","getDualLandList","(Z)Ljava/util/List;","invokevirtual",66);}
case 66:{f.Locals[4]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",75);}
case 75:{f.Locals[5]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[5]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",84);}
case 84:{f.Pc=f.Pop().Int==0?118:87;continue;}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",94);}
case 94:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=97;continue;}
case 97:{f.Locals[6]=f.Pop();f.Pc=99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGenerator2Color","cardCounts","Ljava/util/Map;"));f.Pc=103;continue;}
case 103:{f.Push(f.Locals[6]);f.Pc=105;continue;}
case 105:{f.Push(JValue.I(0));f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",109);}
case 109:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",114);}
case 114:{f.StackOp("pop");f.Pc=115;continue;}
case 115:{f.Pc=77;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[3]);f.Pc=120;continue;}
case 120:{f.Push(JValue.I(6));f.Pc=122;continue;}
case 122:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"idiv",a,b));f.Pc=123;continue;}
case 123:{f.Push(f.Locals[4]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/deck/generation/DeckGenerator2Color","addSomeStr","(ILjava/util/List;)I","invokevirtual",128);}
case 128:{f.Locals[5]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[3]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[5]);f.Pc=133;continue;}
case 133:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=134;continue;}
case 134:{f.Locals[3]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[3]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/deck/generation/DeckGenerator2Color","addBasicLand","(I)V","invokevirtual",140);}
case 140:{f.Push(f.Locals[0]);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[1]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/deck/generation/DeckGenerator2Color","adjustDeckSize","(I)V","invokevirtual",145);}
case 145:{f.Push(f.Locals[0]);f.Pc=146;continue;}
case 146:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGenerator2Color","trace","Lforge/util/DebugTrace;"));f.Pc=149;continue;}
case 149:{f.Push(JValue.R(rt.String("DeckSize:")));f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",154);}
case 154:{f.Push(f.Locals[0]);f.Pc=155;continue;}
case 155:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGenerator2Color","tDeck","Lforge/deck/CardPool;"));f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/deck/CardPool","countAll","()I","invokevirtual",161);}
case 161:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",164);}
case 164:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",167);}
case 167:{f.Push(JValue.R(rt.String("\n")));f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",172);}
case 172:{f.StackOp("pop");f.Pc=173;continue;}
case 173:{f.Push(f.Locals[0]);f.Pc=174;continue;}
case 174:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGenerator2Color","tDeck","Lforge/deck/CardPool;"));f.Pc=177;continue;}
case 177:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

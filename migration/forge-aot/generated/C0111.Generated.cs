// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C111{
internal static JClass Build(){var c=new JClass("forge/deck/generation/DeckGenerator3Color","forge/deck/generation/DeckGeneratorBase",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("cmcLevels","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(1665,"forge/deck/generation/DeckGenerator3Color","getLandPercentage","()F",20,1,1,new JHandler[]{},M1665));
c.Add(new JMethod(1666,"forge/deck/generation/DeckGenerator3Color","getCreaturePercentage","()F",20,1,1,new JHandler[]{},M1666));
c.Add(new JMethod(1667,"forge/deck/generation/DeckGenerator3Color","getSpellPercentage","()F",20,1,1,new JHandler[]{},M1667));
c.Add(new JMethod(1668,"forge/deck/generation/DeckGenerator3Color","<init>","(Lforge/deck/generation/IDeckGenPool;Lforge/deck/DeckFormat;Ljava/util/function/Predicate;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V",1,7,8,new JHandler[]{},M1668));
c.Add(new JMethod(1669,"forge/deck/generation/DeckGenerator3Color","<init>","(Lforge/deck/generation/IDeckGenPool;Lforge/deck/DeckFormat;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V",1,6,8,new JHandler[]{},M1669));
c.Add(new JMethod(1670,"forge/deck/generation/DeckGenerator3Color","initialize","(Lforge/deck/DeckFormat;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V",2,13,4,new JHandler[]{},M1670));
c.Add(new JMethod(1671,"forge/deck/generation/DeckGenerator3Color","getDeck","(IZ)Lforge/deck/CardPool;",17,7,4,new JHandler[]{},M1671));
}

internal static JStep M1665(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.F(0.4399999976158142f));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1666(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.F(0.33000001311302185f));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1667(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.F(0.23000000417232513f));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1668(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","<init>","(Lforge/deck/generation/IDeckGenPool;Lforge/deck/DeckFormat;Ljava/util/function/Predicate;)V","invokespecial",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(3));f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.NewArray("Lorg/apache/commons/lang3/tuple/ImmutablePair;",f.Pop().Int)));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGeneratorBase$FilterCMC")));f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(2));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC","<init>","(II)V","invokespecial",23);}
case 23:{f.Push(JValue.I(12));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",28);}
case 28:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",31);}
case 31:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=32;continue;}
case 32:{f.StackOp("dup");f.Pc=33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGeneratorBase$FilterCMC")));f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{f.Push(JValue.I(3));f.Pc=39;continue;}
case 39:{f.Push(JValue.I(5));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC","<init>","(II)V","invokespecial",43);}
case 43:{f.Push(JValue.I(9));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",48);}
case 48:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",51);}
case 51:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=52;continue;}
case 52:{f.StackOp("dup");f.Pc=53;continue;}
case 53:{f.Push(JValue.I(2));f.Pc=54;continue;}
case 54:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGeneratorBase$FilterCMC")));f.Pc=57;continue;}
case 57:{f.StackOp("dup");f.Pc=58;continue;}
case 58:{f.Push(JValue.I(6));f.Pc=60;continue;}
case 60:{f.Push(JValue.I(20));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC","<init>","(II)V","invokespecial",65);}
case 65:{f.Push(JValue.I(3));f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",69);}
case 69:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",72);}
case 72:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=73;continue;}
case 73:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",76);}
case 76:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGenerator3Color","cmcLevels","Ljava/util/List;",value);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[2]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[4]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[5]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[6]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/deck/generation/DeckGenerator3Color","initialize","(Lforge/deck/DeckFormat;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",90);}
case 90:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1669(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","<init>","(Lforge/deck/generation/IDeckGenPool;Lforge/deck/DeckFormat;)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(3));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.NewArray("Lorg/apache/commons/lang3/tuple/ImmutablePair;",f.Pop().Int)));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGeneratorBase$FilterCMC")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC","<init>","(II)V","invokespecial",22);}
case 22:{f.Push(JValue.I(12));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",27);}
case 27:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",30);}
case 30:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGeneratorBase$FilterCMC")));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(JValue.I(3));f.Pc=38;continue;}
case 38:{f.Push(JValue.I(5));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC","<init>","(II)V","invokespecial",42);}
case 42:{f.Push(JValue.I(9));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",47);}
case 47:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",50);}
case 50:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=51;continue;}
case 51:{f.StackOp("dup");f.Pc=52;continue;}
case 52:{f.Push(JValue.I(2));f.Pc=53;continue;}
case 53:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGeneratorBase$FilterCMC")));f.Pc=56;continue;}
case 56:{f.StackOp("dup");f.Pc=57;continue;}
case 57:{f.Push(JValue.I(6));f.Pc=59;continue;}
case 59:{f.Push(JValue.I(20));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase$FilterCMC","<init>","(II)V","invokespecial",64);}
case 64:{f.Push(JValue.I(3));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",68);}
case 68:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",71);}
case 71:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=72;continue;}
case 72:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",75);}
case 75:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGenerator3Color","cmcLevels","Ljava/util/List;",value);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[3]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[4]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[5]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/deck/generation/DeckGenerator3Color","initialize","(Lforge/deck/DeckFormat;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",88);}
case 88:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1670(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGenerator3Color","cmcLevels","Ljava/util/List;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/deck/DeckFormat","adjustCMCLevels","(Ljava/util/List;)V","invokevirtual",8);}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B","invokestatic",12);}
case 12:{f.Locals[5]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B","invokestatic",18);}
case 18:{f.Locals[6]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B","invokestatic",25);}
case 25:{f.Locals[7]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{f.Locals[8]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[5]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[6]);f.Pc=34;continue;}
case 34:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[7]);f.Pc=37;continue;}
case 37:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=38;continue;}
case 38:{f.Locals[9]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[9]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",45);}
case 45:{f.Locals[10]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[10]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/card/ColorSet","countColors","()I","invokevirtual",52);}
case 52:{switch(f.Pop().Int){case 0:f.Pc=91;break;case 1:f.Pc=136;break;case 2:f.Pc=161;break;case 3:f.Pc=84;break;default:f.Pc=187;break;}continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[10]);f.Pc=87;continue;}
case 87:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGenerator3Color","colors","Lforge/card/ColorSet;",value);f.Pc=90;continue;}
case 90:{return JStep.ReturnVoid;}
case 91:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",94);}
case 94:{f.Push(JValue.I(5));f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",98);}
case 98:{f.Locals[11]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[11]);f.Pc=102;continue;}
case 102:{f.Push(JValue.I(1));f.Pc=103;continue;}
case 103:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",107);}
case 107:{f.Push(JValue.I(4));f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",111);}
case 111:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=112;continue;}
case 112:{f.Push(JValue.I(5));f.Pc=113;continue;}
case 113:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=114;continue;}
case 114:{f.Locals[12]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{f.Push(JValue.I(1));f.Pc=118;continue;}
case 118:{f.Push(f.Locals[11]);f.Pc=120;continue;}
case 120:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=121;continue;}
case 121:{f.Push(JValue.I(1));f.Pc=122;continue;}
case 122:{f.Push(f.Locals[12]);f.Pc=124;continue;}
case 124:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=125;continue;}
case 125:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",129);}
case 129:{return rt.Call(f,"forge/card/ColorSet","inverse","()Lforge/card/ColorSet;","invokevirtual",132);}
case 132:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGenerator3Color","colors","Lforge/card/ColorSet;",value);f.Pc=135;continue;}
case 135:{return JStep.ReturnVoid;}
case 136:{f.Push(JValue.I(1));f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",140);}
case 140:{f.Push(JValue.I(5));f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",144);}
case 144:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=145;continue;}
case 145:{f.Locals[8]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(f.Locals[8]);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[9]);f.Pc=151;continue;}
case 151:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?136:154;continue;}
case 154:{f.Push(f.Locals[9]);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[8]);f.Pc=158;continue;}
case 158:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=159;continue;}
case 159:{f.Locals[9]=f.Pop();f.Pc=161;continue;}
case 161:{f.Push(JValue.I(1));f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",165);}
case 165:{f.Push(JValue.I(5));f.Pc=166;continue;}
case 166:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",169);}
case 169:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=170;continue;}
case 170:{f.Locals[8]=f.Pop();f.Pc=172;continue;}
case 172:{f.Push(f.Locals[8]);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[9]);f.Pc=176;continue;}
case 176:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=177;continue;}
case 177:{f.Pc=f.Pop().Int!=0?161:180;continue;}
case 180:{f.Push(f.Locals[9]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[8]);f.Pc=184;continue;}
case 184:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=185;continue;}
case 185:{f.Locals[9]=f.Pop();f.Pc=187;continue;}
case 187:{f.Push(f.Locals[0]);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[9]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",193);}
case 193:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGenerator3Color","colors","Lforge/card/ColorSet;",value);f.Pc=196;continue;}
case 196:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1671(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGenerator3Color","cmcLevels","Ljava/util/List;"));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/deck/generation/DeckGenerator3Color","addCreaturesAndSpells","(ILjava/util/List;Z)V","invokevirtual",10);}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/deck/generation/DeckGenerator3Color","getLandPercentage","()F","invokevirtual",16);}
case 16:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fmul",a,b));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/Math","round","(F)I","invokestatic",20);}
case 20:{f.Locals[3]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/deck/generation/DeckGenerator3Color","adjustDeckSize","(I)V","invokevirtual",28);}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGenerator3Color","trace","Lforge/util/DebugTrace;"));f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("numLands:")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",37);}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",41);}
case 41:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",44);}
case 44:{f.Push(JValue.R(rt.String("\n")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",49);}
case 49:{f.StackOp("pop");f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/deck/generation/DeckGenerator3Color","getDualLandList","(Z)Ljava/util/List;","invokevirtual",55);}
case 55:{f.Locals[4]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",64);}
case 64:{f.Locals[5]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",73);}
case 73:{f.Pc=f.Pop().Int==0?107:76;continue;}
case 76:{f.Push(f.Locals[5]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",83);}
case 83:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=86;continue;}
case 86:{f.Locals[6]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGenerator3Color","cardCounts","Ljava/util/Map;"));f.Pc=92;continue;}
case 92:{f.Push(f.Locals[6]);f.Pc=94;continue;}
case 94:{f.Push(JValue.I(0));f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",98);}
case 98:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",103);}
case 103:{f.StackOp("pop");f.Pc=104;continue;}
case 104:{f.Pc=66;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{f.Push(JValue.I(4));f.Pc=110;continue;}
case 110:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"idiv",a,b));f.Pc=111;continue;}
case 111:{f.Push(f.Locals[4]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/deck/generation/DeckGenerator3Color","addSomeStr","(ILjava/util/List;)I","invokevirtual",116);}
case 116:{f.Locals[5]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[3]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[5]);f.Pc=121;continue;}
case 121:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=122;continue;}
case 122:{f.Locals[3]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[0]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[3]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/deck/generation/DeckGenerator3Color","addBasicLand","(I)V","invokevirtual",128);}
case 128:{f.Push(f.Locals[0]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/deck/generation/DeckGenerator3Color","adjustDeckSize","(I)V","invokevirtual",133);}
case 133:{f.Push(f.Locals[0]);f.Pc=134;continue;}
case 134:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGenerator3Color","trace","Lforge/util/DebugTrace;"));f.Pc=137;continue;}
case 137:{f.Push(JValue.R(rt.String("DeckSize:")));f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",142);}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGenerator3Color","tDeck","Lforge/deck/CardPool;"));f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/deck/CardPool","countAll","()I","invokevirtual",149);}
case 149:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",152);}
case 152:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",155);}
case 155:{f.Push(JValue.R(rt.String("\n")));f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",160);}
case 160:{f.StackOp("pop");f.Pc=161;continue;}
case 161:{f.Push(f.Locals[0]);f.Pc=162;continue;}
case 162:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGenerator3Color","tDeck","Lforge/deck/CardPool;"));f.Pc=165;continue;}
case 165:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

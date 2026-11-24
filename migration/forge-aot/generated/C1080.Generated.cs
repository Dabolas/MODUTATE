// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1080{
internal static JClass Build(){var c=new JClass("forge/item/SealedTemplate$Reader","forge/util/storage/StorageReaderFile",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(11436,"forge/item/SealedTemplate$Reader","<init>","(Ljava/io/File;)V",1,2,3,new JHandler[]{},M11436));
c.Add(new JMethod(11437,"forge/item/SealedTemplate$Reader","parseSlots","(Ljava/lang/String;)Ljava/util/List;",9,8,4,new JHandler[]{},M11437));
c.Add(new JMethod(11438,"forge/item/SealedTemplate$Reader","read","(Ljava/lang/String;I)Lforge/item/SealedTemplate;",4,4,5,new JHandler[]{},M11438));
c.Add(new JMethod(11439,"forge/item/SealedTemplate$Reader","read","(Ljava/lang/String;I)Ljava/lang/Object;",4164,3,3,new JHandler[]{},M11439));
}

internal static JStep M11436(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/item/SealedTemplate$Reader:11436:2:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",7);}
case 7:{return rt.Call(f,"forge/util/storage/StorageReaderFile","<init>","(Ljava/io/File;Ljava/util/function/Function;)V","invokespecial",10);}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11437(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(44));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/util/TextUtil","splitWithParenthesis","(Ljava/lang/CharSequence;C)[Ljava/lang/String;","invokestatic",6);}
case 6:{f.Locals[1]=f.Pop();f.Pc=7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=19;continue;}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{f.Locals[5]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[5]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?84:31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=35;continue;}
case 35:{f.Locals[6]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[6]);f.Pc=39;continue;}
case 39:{f.Push(JValue.I(32));f.Pc=41;continue;}
case 41:{f.Push(JValue.I(2));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/util/TextUtil","splitWithParenthesis","(Ljava/lang/CharSequence;CI)[Ljava/lang/String;","invokestatic",45);}
case 45:{f.Locals[7]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[7]);f.Pc=50;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String(";")));f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String(",")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",59);}
case 59:{f.Push(f.Locals[7]);f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",66);}
case 66:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",69);}
case 69:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",72);}
case 72:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",77);}
case 77:{f.StackOp("pop");f.Pc=78;continue;}
case 78:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=81;continue;}
case 81:{f.Pc=24;continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11438(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(58));f.Pc=3;continue;}
case 3:{f.Push(JValue.I(2));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/TextUtil","split","(Ljava/lang/CharSequence;CI)[Ljava/lang/String;","invokestatic",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"forge/item/SealedTemplate"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/SealedTemplate")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/item/SealedTemplate$Reader","parseSlots","(Ljava/lang/String;)Ljava/util/List;","invokestatic",21);}
case 21:{return rt.Call(f,"forge/item/SealedTemplate","<init>","(Ljava/lang/String;Ljava/lang/Iterable;)V","invokespecial",24);}
case 24:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11439(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/item/SealedTemplate$Reader","read","(Ljava/lang/String;I)Lforge/item/SealedTemplate;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

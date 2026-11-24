// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C72{
internal static JClass Build(){var c=new JClass("forge/card/PrintSheet$Reader","forge/util/storage/StorageReaderFileSections",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(1172,"forge/card/PrintSheet$Reader","<init>","(Ljava/io/File;)V",1,2,3,new JHandler[]{},M1172));
c.Add(new JMethod(1173,"forge/card/PrintSheet$Reader","read","(Ljava/lang/String;Ljava/lang/Iterable;I)Lforge/card/PrintSheet;",4,4,4,new JHandler[]{},M1173));
c.Add(new JMethod(1174,"forge/card/PrintSheet$Reader","read","(Ljava/lang/String;Ljava/lang/Iterable;I)Ljava/lang/Object;",4164,4,4,new JHandler[]{},M1174));
}

internal static JStep M1172(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/card/PrintSheet$Reader:1172:2:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",7);}
case 7:{return rt.Call(f,"forge/util/storage/StorageReaderFileSections","<init>","(Ljava/io/File;Ljava/util/function/Function;)V","invokespecial",10);}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1173(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/PrintSheet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/PrintSheet")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/deck/CardPool","fromCardList","(Ljava/lang/Iterable;)Lforge/deck/CardPool;","invokestatic",9);}
case 9:{return rt.Call(f,"forge/card/PrintSheet","<init>","(Ljava/lang/String;Lforge/util/ItemPool;)V","invokespecial",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1174(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/PrintSheet$Reader","read","(Ljava/lang/String;Ljava/lang/Iterable;I)Lforge/card/PrintSheet;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

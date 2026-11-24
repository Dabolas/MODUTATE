// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C445{
internal static JClass Build(){var c=new JClass("forge/game/card/CardCollection","forge/util/collect/FCollection",new string[]{"forge/game/card/CardCollectionView"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-8133537013727100275L),null));
c.Add(new JField("EMPTY","Lforge/game/card/CardCollectionView;",true,JValue.Default("Lforge/game/card/CardCollectionView;"),null));
c.Add(new JMethod(4907,"forge/game/card/CardCollection","<init>","(I)V",1,2,2,new JHandler[]{},M4907));
c.Add(new JMethod(4908,"forge/game/card/CardCollection","ensureCapacity","(I)V",1,2,2,new JHandler[]{},M4908));
c.Add(new JMethod(4909,"forge/game/card/CardCollection","getView","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;",9,1,2,new JHandler[]{},M4909));
c.Add(new JMethod(4910,"forge/game/card/CardCollection","getView","(Ljava/lang/Iterable;Z)Lforge/game/card/CardCollectionView;",9,2,3,new JHandler[]{},M4910));
c.Add(new JMethod(4911,"forge/game/card/CardCollection","combine","([Lforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;",137,7,3,new JHandler[]{},M4911));
c.Add(new JMethod(4912,"forge/game/card/CardCollection","<init>","()V",1,1,1,new JHandler[]{},M4912));
c.Add(new JMethod(4913,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V",1,2,2,new JHandler[]{},M4913));
c.Add(new JMethod(4914,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V",1,2,2,new JHandler[]{},M4914));
c.Add(new JMethod(4915,"forge/game/card/CardCollection","<init>","(Ljava/util/stream/Stream;)V",1,2,3,new JHandler[]{},M4915));
c.Add(new JMethod(4916,"forge/game/card/CardCollection","subList","(II)Lforge/game/card/CardCollection;",1,3,5,new JHandler[]{},M4916));
c.Add(new JMethod(4917,"forge/game/card/CardCollection","filter","(Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;",1,3,3,new JHandler[]{},M4917));
c.Add(new JMethod(4918,"forge/game/card/CardCollection","subList","(II)Ljava/util/List;",4161,3,3,new JHandler[]{},M4918));
c.Add(new JMethod(4919,"forge/game/card/CardCollection","<clinit>","()V",8,0,2,new JHandler[]{},M4919));
}

internal static JStep M4907(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(I)V","invokespecial",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4908(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/collect/FCollection","ensureCapacity","(I)V","invokespecial",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4909(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardCollection","getView","(Ljava/lang/Iterable;Z)Lforge/game/card/CardCollectionView;","invokestatic",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4910(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?8:4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=7;continue;}
case 7:{return JStep.Return(f.Pop());}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Int==0?21:12;continue;}
case 12:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",20);}
case 20:{return JStep.Return(f.Pop());}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/CardCollectionView")?1:0));f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Int==0?33:28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{return JStep.Return(f.Pop());}
case 33:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",41);}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4911(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?14:4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"java/lang/NullPointerException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/NullPointerException")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("The 'views' parameter was null when CardCollection.combine was called")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/NullPointerException","<init>","(Ljava/lang/String;)V","invokespecial",13);}
case 13:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 14:{f.Push(JValue.R(null));f.Pc=15;continue;}
case 15:{f.Locals[1]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(JValue.R(null));f.Pc=17;continue;}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=22;continue;}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{f.Locals[5]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[5]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?98:34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[5]);f.Pc=37;continue;}
case 37:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=38;continue;}
case 38:{f.Locals[6]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[6]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",47);}
case 47:{f.Pc=f.Pop().Int!=0?92:50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Pc=f.Pop().Reference!=null?60:54;continue;}
case 54:{f.Push(f.Locals[6]);f.Pc=56;continue;}
case 56:{f.Locals[2]=f.Pop();f.Pc=57;continue;}
case 57:{f.Pc=92;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Pc=f.Pop().Reference!=null?85:64;continue;}
case 64:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=67;continue;}
case 67:{f.StackOp("dup");f.Pc=68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",72);}
case 72:{f.Locals[1]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[6]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",79);}
case 79:{f.StackOp("pop");f.Pc=80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{f.Locals[2]=f.Pop();f.Pc=82;continue;}
case 82:{f.Pc=92;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[6]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",91);}
case 91:{f.StackOp("pop");f.Pc=92;continue;}
case 92:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=95;continue;}
case 95:{f.Pc=27;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{f.Pc=f.Pop().Reference!=null?106:102;continue;}
case 102:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=105;continue;}
case 105:{f.Locals[2]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4912(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4913(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(Ljava/lang/Object;)V","invokespecial",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4914(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4915(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.StackOp("dup");f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",6);}
case 6:{f.StackOp("pop");f.Pc=7;continue;}
case 7:{return rt.DynamicCall(f,"forge/game/card/CardCollection:4915:7:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/stream/Stream;)Ljava/lang/Iterable;",12);}
case 12:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",15);}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4916(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/util/collect/FCollection","subList","(II)Ljava/util/List;","invokespecial",10);}
case 10:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4917(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/CardCollection","stream","()Ljava/util/stream/Stream;","invokevirtual",12);}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",18);}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{return rt.DynamicCall(f,"forge/game/card/CardCollection:4917:24:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/CardCollection;)Ljava/util/function/Consumer;",29);}
case 29:{return rt.Call(f,"java/util/stream/Stream","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",34);}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4918(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/CardCollection","subList","(II)Lforge/game/card/CardCollection;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4919(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection$EmptyCardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection$EmptyCardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection$EmptyCardCollection","<init>","()V","invokespecial",7);}
case 7:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;",f.Pop());f.Pc=10;continue;}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

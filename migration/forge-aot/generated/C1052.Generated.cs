// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1052{
internal static JClass Build(){var c=new JClass("forge/item/BoosterBox","forge/item/BoxedProduct",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("fpData","Lforge/item/BoosterBox$Template;",false,JValue.Default("Lforge/item/BoosterBox$Template;"),null));
c.Add(new JMethod(11171,"forge/item/BoosterBox","fromSet","(Lforge/card/CardEdition;)Lforge/item/BoosterBox;",9,2,5,new JHandler[]{},M11171));
c.Add(new JMethod(11172,"forge/item/BoosterBox","<init>","(Ljava/lang/String;Lforge/item/BoosterBox$Template;I)V",1,4,4,new JHandler[]{},M11172));
c.Add(new JMethod(11173,"forge/item/BoosterBox","getDescription","()Ljava/lang/String;",1,1,2,new JHandler[]{},M11173));
c.Add(new JMethod(11174,"forge/item/BoosterBox","getItemType","()Ljava/lang/String;",17,1,1,new JHandler[]{},M11174));
c.Add(new JMethod(11175,"forge/item/BoosterBox","clone","()Ljava/lang/Object;",17,1,5,new JHandler[]{},M11175));
c.Add(new JMethod(11176,"forge/item/BoosterBox","getTotalCards","()I",1,1,2,new JHandler[]{},M11176));
c.Add(new JMethod(11177,"forge/item/BoosterBox","getImageKey","(Z)Ljava/lang/String;",1,2,1,new JHandler[]{},M11177));
}

internal static JStep M11171(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardEdition","getBoosterBoxCount","()I","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int>0?9:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{if(!rt.EnsureInitialized(f,"forge/item/BoosterBox$Template"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/BoosterBox$Template")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/item/BoosterBox$Template","<init>","(Lforge/card/CardEdition;)V","invokespecial",17);}
case 17:{f.Locals[1]=f.Pop();f.Pc=18;continue;}
case 18:{if(!rt.EnsureInitialized(f,"forge/item/BoosterBox"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/BoosterBox")));f.Pc=21;continue;}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/card/CardEdition","getName","()Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterBox$Template","cntBoosters","I"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/item/BoosterBox","<init>","(Ljava/lang/String;Lforge/item/BoosterBox$Template;I)V","invokespecial",34);}
case 34:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11172(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/StaticData","getBoosters","()Lforge/util/storage/IStorage;","invokevirtual",8);}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/item/BoosterBox$Template","getEdition","()Ljava/lang/String;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/util/storage/IStorage","get","(Ljava/lang/String;)Ljava/lang/Object;","invokeinterface",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/SealedTemplate"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/item/BoxedProduct","<init>","(Ljava/lang/String;Lforge/item/SealedTemplate;I)V","invokespecial",24);}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/BoosterBox","fpData","Lforge/item/BoosterBox$Template;",value);f.Pc=29;continue;}
case 29:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11173(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterBox","fpData","Lforge/item/BoosterBox$Template;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/item/BoosterBox$Template","toString","()Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterBox","contents","Lforge/item/SealedTemplate;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/item/SealedTemplate","toString","()Ljava/lang/String;","invokevirtual",14);}
case 14:{return rt.DynamicCall(f,"forge/item/BoosterBox:11173:14:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",19);}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11174(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Booster Box")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11175(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/item/BoosterBox"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/BoosterBox")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterBox","name","Ljava/lang/String;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterBox","fpData","Lforge/item/BoosterBox$Template;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterBox","fpData","Lforge/item/BoosterBox$Template;"));f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterBox$Template","cntBoosters","I"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/item/BoosterBox","<init>","(Ljava/lang/String;Lforge/item/BoosterBox$Template;I)V","invokespecial",22);}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11176(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/BoxedProduct","getTotalCards","()I","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterBox","fpData","Lforge/item/BoosterBox$Template;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/item/BoosterBox$Template","getCntBoosters","()I","invokevirtual",11);}
case 11:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/item/BoosterBox","fpData","Lforge/item/BoosterBox$Template;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/item/BoosterBox$Template","getNumberOfCardsExpected","()I","invokevirtual",19);}
case 19:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11177(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/BoosterBox","getEdition","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return rt.DynamicCall(f,"forge/item/BoosterBox:11177:4:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

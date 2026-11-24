// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C8{
internal static JClass Build(){var c=new JClass("forge/MulliganDefs","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("defaultRule","Lforge/MulliganDefs$MulliganRule;",true,JValue.Default("Lforge/MulliganDefs$MulliganRule;"),null));
c.Add(new JMethod(71,"forge/MulliganDefs","<init>","()V",1,1,1,new JHandler[]{},M71));
c.Add(new JMethod(72,"forge/MulliganDefs","getDefaultRule","()Lforge/MulliganDefs$MulliganRule;",9,0,1,new JHandler[]{},M72));
c.Add(new JMethod(73,"forge/MulliganDefs","getMulliganRuleNames","()[Ljava/lang/String;",9,5,2,new JHandler[]{},M73));
c.Add(new JMethod(74,"forge/MulliganDefs","GetRuleByName","(Ljava/lang/String;)Lforge/MulliganDefs$MulliganRule;",9,3,3,new JHandler[]{new JHandler(0,5,8,"java/lang/IllegalArgumentException")},M74));
c.Add(new JMethod(75,"forge/MulliganDefs","<clinit>","()V",8,0,1,new JHandler[]{},M75));
}

internal static JStep M71(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M72(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/MulliganDefs","defaultRule","Lforge/MulliganDefs$MulliganRule;"))return JStep.Continue;f.Push(rt.GetStatic("forge/MulliganDefs","defaultRule","Lforge/MulliganDefs$MulliganRule;"));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M73(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[0]=f.Pop();f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/MulliganDefs$MulliganRule","values","()[Lforge/MulliganDefs$MulliganRule;","invokestatic",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=10;continue;}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?41:18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=21;continue;}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/MulliganDefs$MulliganRule","name","()Ljava/lang/String;","invokevirtual",29);}
case 29:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",34);}
case 34:{f.StackOp("pop");f.Pc=35;continue;}
case 35:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=38;continue;}
case 38:{f.Pc=13;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/List","toArray","([Ljava/lang/Object;)[Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Ljava/lang/String;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M74(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/MulliganDefs$MulliganRule","valueOf","(Ljava/lang/String;)Lforge/MulliganDefs$MulliganRule;","invokestatic",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Pc=31;continue;}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/MulliganDefs","getDefaultRule","()Lforge/MulliganDefs$MulliganRule;","invokestatic",16);}
case 16:{return rt.Call(f,"forge/MulliganDefs$MulliganRule","name","()Ljava/lang/String;","invokevirtual",19);}
case 19:{return rt.DynamicCall(f,"forge/MulliganDefs:74:19:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",24);}
case 24:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",27);}
case 27:{return rt.Call(f,"forge/MulliganDefs","getDefaultRule","()Lforge/MulliganDefs$MulliganRule;","invokestatic",30);}
case 30:{f.Locals[1]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M75(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/MulliganDefs$MulliganRule","London","Lforge/MulliganDefs$MulliganRule;"))return JStep.Continue;f.Push(rt.GetStatic("forge/MulliganDefs$MulliganRule","London","Lforge/MulliganDefs$MulliganRule;"));f.Pc=3;continue;}
case 3:{if(!rt.StaticReady(f,"forge/MulliganDefs","defaultRule","Lforge/MulliganDefs$MulliganRule;"))return JStep.Continue;rt.PutStatic("forge/MulliganDefs","defaultRule","Lforge/MulliganDefs$MulliganRule;",f.Pop());f.Pc=6;continue;}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

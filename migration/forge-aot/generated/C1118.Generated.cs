// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1118{
internal static JClass Build(){var c=new JClass("forge/util/EnumUtil","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(11726,"forge/util/EnumUtil","<init>","()V",2,1,1,new JHandler[]{},M11726));
c.Add(new JMethod(11727,"forge/util/EnumUtil","getNames","(Ljava/lang/Class;)Lcom/google/common/collect/ImmutableList;",9,6,2,new JHandler[]{},M11727));
c.Add(new JMethod(11728,"forge/util/EnumUtil","getEnumDisplayName","(Ljava/lang/Enum;)Ljava/lang/String;",9,6,2,new JHandler[]{},M11728));
}

internal static JStep M11726(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11727(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/ImmutableList","builder","()Lcom/google/common/collect/ImmutableList$Builder;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Class","getEnumConstants","()[Ljava/lang/Object;","invokevirtual",8);}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Ljava/lang/Enum;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=14;continue;}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{f.Locals[4]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?46:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=28;continue;}
case 28:{f.Locals[5]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[5]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/Enum","name","()Ljava/lang/String;","invokevirtual",36);}
case 36:{return rt.Call(f,"com/google/common/collect/ImmutableList$Builder","add","(Ljava/lang/Object;)Lcom/google/common/collect/ImmutableList$Builder;","invokevirtual",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=43;continue;}
case 43:{f.Pc=18;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"com/google/common/collect/ImmutableList$Builder","build","()Lcom/google/common/collect/ImmutableList;","invokevirtual",50);}
case 50:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11728(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","name","()Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{f.Locals[4]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",24);}
case 24:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?86:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",33);}
case 33:{f.Locals[5]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[5]);f.Pc=37;continue;}
case 37:{f.Push(JValue.I(95));f.Pc=39;continue;}
case 39:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?54:42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{f.Push(JValue.I(32));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",48);}
case 48:{f.StackOp("pop");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(1));f.Pc=50;continue;}
case 50:{f.Locals[1]=f.Pop();f.Pc=51;continue;}
case 51:{f.Pc=80;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Pc=f.Pop().Int==0?70:58;continue;}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[5]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",64);}
case 64:{f.StackOp("pop");f.Pc=65;continue;}
case 65:{f.Push(JValue.I(0));f.Pc=66;continue;}
case 66:{f.Locals[1]=f.Pop();f.Pc=67;continue;}
case 67:{f.Pc=80;continue;}
case 70:{f.Push(f.Locals[3]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[5]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/lang/Character","toLowerCase","(C)C","invokestatic",76);}
case 76:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",79);}
case 79:{f.StackOp("pop");f.Pc=80;continue;}
case 80:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=83;continue;}
case 83:{f.Pc=18;continue;}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",90);}
case 90:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1160{
internal static JClass Build(){var c=new JClass("forge/util/StreamUtil$RandomReservoir","java/lang/Object",new string[]{},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("maxSize","I",false,JValue.Default("I"),null));
c.Add(new JField("samples","Ljava/util/ArrayList;",false,JValue.Default("Ljava/util/ArrayList;"),null));
c.Add(new JField("sampleCount","I",false,JValue.Default("I"),null));
c.Add(new JMethod(12037,"forge/util/StreamUtil$RandomReservoir","<init>","(I)V",1,2,4,new JHandler[]{},M12037));
c.Add(new JMethod(12038,"forge/util/StreamUtil$RandomReservoir","accumulate","(Ljava/lang/Object;)V",1,3,3,new JHandler[]{},M12038));
}

internal static JStep M12037(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/StreamUtil$RandomReservoir","sampleCount","I",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/StreamUtil$RandomReservoir","maxSize","I",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/ArrayList","<init>","(I)V","invokespecial",23);}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/StreamUtil$RandomReservoir","samples","Ljava/util/ArrayList;",value);f.Pc=26;continue;}
case 26:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12038(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.StackOp("dup");f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/util/StreamUtil$RandomReservoir","sampleCount","I"));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/StreamUtil$RandomReservoir","sampleCount","I",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/util/StreamUtil$RandomReservoir","sampleCount","I"));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/util/StreamUtil$RandomReservoir","maxSize","I"));f.Pc=18;continue;}
case 18:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?31:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/util/StreamUtil$RandomReservoir","samples","Ljava/util/ArrayList;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{return JStep.ReturnVoid;}
case 31:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",34);}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/util/StreamUtil$RandomReservoir","sampleCount","I"));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",41);}
case 41:{f.Locals[2]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/util/StreamUtil$RandomReservoir","maxSize","I"));f.Pc=47;continue;}
case 47:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?60:50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/util/StreamUtil$RandomReservoir","samples","Ljava/util/ArrayList;"));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/ArrayList","set","(ILjava/lang/Object;)Ljava/lang/Object;","invokevirtual",59);}
case 59:{f.StackOp("pop");f.Pc=60;continue;}
case 60:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

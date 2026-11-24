// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1110{
internal static JClass Build(){var c=new JClass("forge/util/BinaryUtil","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(11671,"forge/util/BinaryUtil","<init>","()V",1,1,1,new JHandler[]{},M11671));
c.Add(new JMethod(11672,"forge/util/BinaryUtil","bitCount","(I)I",9,3,3,new JHandler[]{},M11672));
c.Add(new JMethod(11673,"forge/util/BinaryUtil","bitCount","(B)I",9,3,3,new JHandler[]{},M11673));
c.Add(new JMethod(11674,"forge/util/BinaryUtil","bitCount","(S)I",9,3,3,new JHandler[]{},M11674));
c.Add(new JMethod(11675,"forge/util/BinaryUtil","getLeastImportantBitIndex","(B)I",9,3,2,new JHandler[]{},M11675));
}

internal static JStep M11671(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11672(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Int==0?20:8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=12;continue;}
case 12:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=13;continue;}
case 13:{f.Locals[1]=f.Pop();f.Pc=14;continue;}
case 14:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=17;continue;}
case 17:{f.Pc=4;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11673(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Int==0?21:8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=12;continue;}
case 12:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=13;continue;}
case 13:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=14;continue;}
case 14:{f.Locals[1]=f.Pop();f.Pc=15;continue;}
case 15:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=18;continue;}
case 18:{f.Pc=4;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11674(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Int==0?21:8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=12;continue;}
case 12:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=13;continue;}
case 13:{f.Push(JNumbers.Unary("i2s",f.Pop()));f.Pc=14;continue;}
case 14:{f.Locals[1]=f.Pop();f.Pc=15;continue;}
case 15:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=18;continue;}
case 18:{f.Pc=4;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11675(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int!=0?6:4;continue;}
case 4:{f.Push(JValue.I(-1));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(JValue.I(1));f.Pc=7;continue;}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int==0?33:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Int==0?22:20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=25;continue;}
case 25:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=26;continue;}
case 26:{f.Locals[1]=f.Pop();f.Pc=27;continue;}
case 27:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=30;continue;}
case 30:{f.Pc=10;continue;}
case 33:{f.Push(JValue.I(-1));f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

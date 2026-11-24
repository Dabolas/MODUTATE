// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1116{
internal static JClass Build(){var c=new JClass("forge/util/DateUtil","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(11722,"forge/util/DateUtil","<init>","()V",1,1,1,new JHandler[]{},M11722));
c.Add(new JMethod(11723,"forge/util/DateUtil","getElapsedHours","(Ljava/util/Date;Ljava/util/Date;)J",9,16,4,new JHandler[]{},M11723));
}

internal static JStep M11722(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11723(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Date","getTime","()J","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Date","getTime","()J","invokevirtual",8);}
case 8:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(JValue.L(1000L));f.Pc=13;continue;}
case 13:{f.Locals[4]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{f.Push(JValue.L(60L));f.Pc=20;continue;}
case 20:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lmul",a,b));f.Pc=21;continue;}
case 21:{f.Locals[6]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[6]);f.Pc=25;continue;}
case 25:{f.Push(JValue.L(60L));f.Pc=28;continue;}
case 28:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lmul",a,b));f.Pc=29;continue;}
case 29:{f.Locals[8]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[8]);f.Pc=34;continue;}
case 34:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ldiv",a,b));f.Pc=35;continue;}
case 35:{f.Locals[10]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[8]);f.Pc=40;continue;}
case 40:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lrem",a,b));f.Pc=41;continue;}
case 41:{f.Locals[2]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[6]);f.Pc=45;continue;}
case 45:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ldiv",a,b));f.Pc=46;continue;}
case 46:{f.Locals[12]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[6]);f.Pc=51;continue;}
case 51:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lrem",a,b));f.Pc=52;continue;}
case 52:{f.Locals[2]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ldiv",a,b));f.Pc=57;continue;}
case 57:{f.Locals[14]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[10]);f.Pc=61;continue;}
case 61:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C669{
internal static JClass Build(){var c=new JClass("forge/game/keyword/Ninjutsu","forge/game/keyword/KeywordWithCost",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("commander","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(7649,"forge/game/keyword/Ninjutsu","<init>","()V",1,1,2,new JHandler[]{},M7649));
c.Add(new JMethod(7650,"forge/game/keyword/Ninjutsu","parse","(Ljava/lang/String;)V",4,3,2,new JHandler[]{},M7650));
c.Add(new JMethod(7651,"forge/game/keyword/Ninjutsu","formatReminderText","(Ljava/lang/String;)Ljava/lang/String;",4,3,5,new JHandler[]{},M7651));
}

internal static JStep M7649(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Ninjutsu","commander","Z",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7650(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String(":")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?36:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String(":")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=19;continue;}
case 19:{f.Locals[1]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("Commander")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?36:31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Ninjutsu","commander","Z",value);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","parse","(Ljava/lang/String;)V","invokespecial",41);}
case 41:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7651(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Ninjutsu","commander","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?12:7;continue;}
case 7:{f.Push(JValue.R(rt.String("hand or the command zone")));f.Pc=9;continue;}
case 9:{f.Pc=14;continue;}
case 12:{f.Push(JValue.R(rt.String("hand")));f.Pc=14;continue;}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(2));f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Ninjutsu","cost","Lforge/game/cost/Cost;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",29);}
case 29:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",37);}
case 37:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

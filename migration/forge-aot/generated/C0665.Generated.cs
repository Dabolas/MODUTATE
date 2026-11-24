// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C665{
internal static JClass Build(){var c=new JClass("forge/game/keyword/Kicker","forge/game/keyword/KeywordWithCost",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("cost2","Lforge/game/cost/Cost;",false,JValue.Default("Lforge/game/cost/Cost;"),null));
c.Add(new JMethod(7635,"forge/game/keyword/Kicker","<init>","()V",1,1,2,new JHandler[]{},M7635));
c.Add(new JMethod(7636,"forge/game/keyword/Kicker","parse","(Ljava/lang/String;)V",4,3,5,new JHandler[]{},M7636));
c.Add(new JMethod(7637,"forge/game/keyword/Kicker","formatReminderText","(Ljava/lang/String;)Ljava/lang/String;",4,2,4,new JHandler[]{},M7637));
}

internal static JStep M7635(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Kicker","cost2","Lforge/game/cost/Cost;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7636(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(58));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/util/TextUtil","split","(Ljava/lang/CharSequence;C)[Ljava/lang/String;","invokestatic",6);}
case 6:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",18);}
case 18:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","parse","(Ljava/lang/String;)V","invokespecial",24);}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",30);}
case 30:{f.Push(JValue.I(1));f.Pc=31;continue;}
case 31:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?56:34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=38;continue;}
case 38:{f.StackOp("dup");f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{f.Push(JValue.I(1));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",53);}
case 53:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Kicker","cost2","Lforge/game/cost/Cost;",value);f.Pc=56;continue;}
case 56:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7637(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Kicker","cost2","Lforge/game/cost/Cost;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?13:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","formatReminderText","(Ljava/lang/String;)Ljava/lang/String;","invokespecial",12);}
case 12:{return JStep.Return(f.Pop());}
case 13:{f.Push(JValue.I(5));f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("You may pay an additional")));f.Pc=21;continue;}
case 21:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Kicker","cost","Lforge/game/cost/Cost;"));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",31);}
case 31:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=32;continue;}
case 32:{f.StackOp("dup");f.Pc=33;continue;}
case 33:{f.Push(JValue.I(2));f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("and/or")));f.Pc=36;continue;}
case 36:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{f.Push(JValue.I(3));f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Kicker","cost2","Lforge/game/cost/Cost;"));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",46);}
case 46:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=47;continue;}
case 47:{f.StackOp("dup");f.Pc=48;continue;}
case 48:{f.Push(JValue.I(4));f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("as you cast this spell.")));f.Pc=51;continue;}
case 51:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",55);}
case 55:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C658{
internal static JClass Build(){var c=new JClass("forge/game/keyword/KeywordWithCost","forge/game/keyword/KeywordInstance",new string[]{"forge/game/keyword/KeywordWithCostInterface"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("cost","Lforge/game/cost/Cost;",false,JValue.Default("Lforge/game/cost/Cost;"),null));
c.Add(new JField("costString","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(7578,"forge/game/keyword/KeywordWithCost","<init>","()V",1,1,1,new JHandler[]{},M7578));
c.Add(new JMethod(7579,"forge/game/keyword/KeywordWithCost","getCost","()Lforge/game/cost/Cost;",1,1,4,new JHandler[]{},M7579));
c.Add(new JMethod(7580,"forge/game/keyword/KeywordWithCost","getCostString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7580));
c.Add(new JMethod(7581,"forge/game/keyword/KeywordWithCost","parse","(Ljava/lang/String;)V",4,3,5,new JHandler[]{},M7581));
c.Add(new JMethod(7582,"forge/game/keyword/KeywordWithCost","costReminderText","()Ljava/lang/String;",1,1,4,new JHandler[]{},M7582));
c.Add(new JMethod(7583,"forge/game/keyword/KeywordWithCost","formatReminderText","(Ljava/lang/String;)Ljava/lang/String;",4,2,5,new JHandler[]{},M7583));
}

internal static JStep M7578(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInstance","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7579(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("ManaCost")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCost","costString","Ljava/lang/String;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?28:12;continue;}
case 12:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","getHostCard","()Lforge/game/card/Card;","invokevirtual",20);}
case 20:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",23);}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Lforge/card/mana/ManaCost;Z)V","invokespecial",27);}
case 27:{return JStep.Return(f.Pop());}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCost","cost","Lforge/game/cost/Cost;"));f.Pc=32;continue;}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7580(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCost","costString","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7581(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String(":")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("\\|")));f.Pc=13;continue;}
case 13:{f.Push(JValue.I(2));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",17);}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",22);}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithCost","costString","Ljava/lang/String;",value);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("ManaCost")));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCost","costString","Ljava/lang/String;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int!=0?53:37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCost","costString","Ljava/lang/String;"));f.Pc=46;continue;}
case 46:{f.Push(JValue.I(1));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",50);}
case 50:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithCost","cost","Lforge/game/cost/Cost;",value);f.Pc=53;continue;}
case 53:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7582(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCost","costString","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?29:10;continue;}
case 10:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","getHostCard","()Lforge/game/card/Card;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",21);}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Lforge/card/mana/ManaCost;Z)V","invokespecial",25);}
case 25:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",28);}
case 28:{return JStep.Return(f.Pop());}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/keyword/KeywordWithCostInterface","costReminderText","()Ljava/lang/String;","invokespecial",33);}
case 33:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7583(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("%")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?25:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","costReminderText","()Ljava/lang/String;","invokevirtual",20);}
case 20:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",24);}
case 24:{return JStep.Return(f.Pop());}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

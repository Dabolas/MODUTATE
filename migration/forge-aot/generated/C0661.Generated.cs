// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C661{
internal static JClass Build(){var c=new JClass("forge/game/keyword/KeywordWithCostInterface","java/lang/Object",new string[]{"forge/game/keyword/KeywordInterface"},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(7602,"forge/game/keyword/KeywordWithCostInterface","getCost","()Lforge/game/cost/Cost;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7603,"forge/game/keyword/KeywordWithCostInterface","getCostString","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7604,"forge/game/keyword/KeywordWithCostInterface","getTitle","()Ljava/lang/String;",1,2,2,new JHandler[]{},M7604));
c.Add(new JMethod(7605,"forge/game/keyword/KeywordWithCostInterface","getTitleWithoutCost","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7605));
c.Add(new JMethod(7606,"forge/game/keyword/KeywordWithCostInterface","isComplexCost","()Z",1,2,1,new JHandler[]{},M7606));
c.Add(new JMethod(7607,"forge/game/keyword/KeywordWithCostInterface","getTitleCost","()Ljava/lang/String;",1,2,1,new JHandler[]{},M7607));
c.Add(new JMethod(7608,"forge/game/keyword/KeywordWithCostInterface","costReminderText","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7608));
}

internal static JStep M7604(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/keyword/KeywordWithCostInterface","getTitleWithoutCost","()Ljava/lang/String;","invokeinterface",15);}
case 15:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",18);}
case 18:{f.StackOp("pop");f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/keyword/KeywordWithCostInterface","isComplexCost","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?38:28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("\u2014")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",34);}
case 34:{f.StackOp("pop");f.Pc=35;continue;}
case 35:{f.Pc=45;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String(" ")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",44);}
case 44:{f.StackOp("pop");f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/keyword/KeywordWithCostInterface","getTitleCost","()Ljava/lang/String;","invokeinterface",52);}
case 52:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",60);}
case 60:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7605(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordWithCostInterface","getKeyword","()Lforge/game/keyword/Keyword;","invokeinterface",6);}
case 6:{return rt.Call(f,"forge/game/keyword/Keyword","toString","()Ljava/lang/String;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7606(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordWithCostInterface","getCost","()Lforge/game/cost/Cost;","invokeinterface",6);}
case 6:{f.Locals[1]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7607(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordWithCostInterface","getCost","()Lforge/game/cost/Cost;","invokeinterface",6);}
case 6:{f.Locals[1]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7608(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordWithCostInterface","getCost","()Lforge/game/cost/Cost;","invokeinterface",6);}
case 6:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

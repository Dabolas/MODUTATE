// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C659{
internal static JClass Build(){var c=new JClass("forge/game/keyword/KeywordWithCostAndAmount","forge/game/keyword/KeywordInstance",new string[]{"forge/game/keyword/KeywordWithCostInterface"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("cost","Lforge/game/cost/Cost;",false,JValue.Default("Lforge/game/cost/Cost;"),null));
c.Add(new JField("costString","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("withX","Z",false,JValue.Default("Z"),null));
c.Add(new JField("amount","I",false,JValue.Default("I"),null));
c.Add(new JMethod(7584,"forge/game/keyword/KeywordWithCostAndAmount","<init>","()V",1,1,1,new JHandler[]{},M7584));
c.Add(new JMethod(7585,"forge/game/keyword/KeywordWithCostAndAmount","getCost","()Lforge/game/cost/Cost;",1,1,1,new JHandler[]{},M7585));
c.Add(new JMethod(7586,"forge/game/keyword/KeywordWithCostAndAmount","getCostString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7586));
c.Add(new JMethod(7587,"forge/game/keyword/KeywordWithCostAndAmount","getTitle","()Ljava/lang/String;",1,2,2,new JHandler[]{},M7587));
c.Add(new JMethod(7588,"forge/game/keyword/KeywordWithCostAndAmount","getTitleWithoutCost","()Ljava/lang/String;",1,2,2,new JHandler[]{},M7588));
c.Add(new JMethod(7589,"forge/game/keyword/KeywordWithCostAndAmount","getAmount","()I",1,1,1,new JHandler[]{},M7589));
c.Add(new JMethod(7590,"forge/game/keyword/KeywordWithCostAndAmount","getAmountString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7590));
c.Add(new JMethod(7591,"forge/game/keyword/KeywordWithCostAndAmount","parse","(Ljava/lang/String;)V",4,3,5,new JHandler[]{},M7591));
c.Add(new JMethod(7592,"forge/game/keyword/KeywordWithCostAndAmount","formatReminderText","(Ljava/lang/String;)Ljava/lang/String;",4,3,5,new JHandler[]{},M7592));
}

internal static JStep M7584(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInstance","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7585(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndAmount","cost","Lforge/game/cost/Cost;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7586(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndAmount","costString","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7587(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/keyword/KeywordWithCostAndAmount","getTitleWithoutCost","()Ljava/lang/String;","invokevirtual",13);}
case 13:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",16);}
case 16:{f.StackOp("pop");f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndAmount","cost","Lforge/game/cost/Cost;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",25);}
case 25:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",28);}
case 28:{f.StackOp("pop");f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",33);}
case 33:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7588(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/keyword/KeywordWithCostAndAmount","getKeyword","()Lforge/game/keyword/Keyword;","invokevirtual",13);}
case 13:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",16);}
case 16:{f.Push(JValue.R(rt.String(" ")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",21);}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/keyword/KeywordWithCostAndAmount","getAmountString","()Ljava/lang/String;","invokevirtual",25);}
case 25:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",28);}
case 28:{f.Push(JValue.R(rt.String("\u2014")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",33);}
case 33:{f.StackOp("pop");f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",38);}
case 38:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7589(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndAmount","amount","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7590(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndAmount","withX","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?12:7;continue;}
case 7:{f.Push(JValue.R(rt.String("X")));f.Pc=9;continue;}
case 9:{f.Pc=19;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndAmount","amount","I"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",19);}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7591(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String(":")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("X")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?26:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithCostAndAmount","withX","Z",value);f.Pc=23;continue;}
case 23:{f.Pc=36;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",33);}
case 33:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithCostAndAmount","amount","I",value);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("\\|")));f.Pc=42;continue;}
case 42:{f.Push(JValue.I(2));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",46);}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",51);}
case 51:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithCostAndAmount","costString","Ljava/lang/String;",value);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=58;continue;}
case 58:{f.StackOp("dup");f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndAmount","costString","Ljava/lang/String;"));f.Pc=63;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",67);}
case 67:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithCostAndAmount","cost","Lforge/game/cost/Cost;",value);f.Pc=70;continue;}
case 70:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7592(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndAmount","withX","Z"));f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Int==0?18:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("\\%(\\d+\\$)?d")));f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("%$1s")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Push(JValue.I(2));f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndAmount","cost","Lforge/game/cost/Cost;"));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",32);}
case 32:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndAmount","withX","Z"));f.Pc=39;continue;}
case 39:{f.Pc=f.Pop().Int==0?47:42;continue;}
case 42:{f.Push(JValue.R(rt.String("X")));f.Pc=44;continue;}
case 44:{f.Pc=54;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndAmount","amount","I"));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",54);}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",58);}
case 58:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

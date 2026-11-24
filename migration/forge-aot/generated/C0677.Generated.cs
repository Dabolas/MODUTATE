// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C677{
internal static JClass Build(){var c=new JClass("forge/game/keyword/Ward","forge/game/keyword/KeywordWithCost",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("costs","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JMethod(7677,"forge/game/keyword/Ward","<init>","()V",1,1,1,new JHandler[]{},M7677));
c.Add(new JMethod(7678,"forge/game/keyword/Ward","parse","(Ljava/lang/String;)V",4,7,6,new JHandler[]{},M7678));
c.Add(new JMethod(7679,"forge/game/keyword/Ward","getCosts","()Ljava/util/Map;",1,1,1,new JHandler[]{},M7679));
c.Add(new JMethod(7680,"forge/game/keyword/Ward","isComplexCost","()Z",1,1,1,new JHandler[]{},M7680));
c.Add(new JMethod(7681,"forge/game/keyword/Ward","getTitleCost","()Ljava/lang/String;",1,1,3,new JHandler[]{},M7681));
c.Add(new JMethod(7682,"forge/game/keyword/Ward","costReminderText","()Ljava/lang/String;",1,1,3,new JHandler[]{},M7682));
c.Add(new JMethod(7683,"forge/game/keyword/Ward","costToReminderDesc","(Lforge/game/cost/Cost;)Ljava/lang/String;",4,4,4,new JHandler[]{},M7683));
c.Add(new JMethod(7684,"forge/game/keyword/Ward","lambda$getTitleCost$0","(Lforge/game/cost/Cost;)Ljava/lang/String;",4106,1,2,new JHandler[]{},M7684));
}

internal static JStep M7677(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7678(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String(":")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?75:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=16;continue;}
case 16:{return rt.Call(f,"com/google/common/collect/Maps","newLinkedHashMapWithExpectedSize","(I)Ljava/util/LinkedHashMap;","invokestatic",19);}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Ward","costs","Ljava/util/Map;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=26;continue;}
case 26:{f.Locals[4]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{f.Locals[5]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[5]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[4]);f.Pc=35;continue;}
case 35:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?72:38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=42;continue;}
case 42:{f.Locals[6]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Ward","costs","Ljava/util/Map;"));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[6]);f.Pc=50;continue;}
case 50:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=53;continue;}
case 53:{f.StackOp("dup");f.Pc=54;continue;}
case 54:{f.Push(f.Locals[6]);f.Pc=56;continue;}
case 56:{f.Push(JValue.I(1));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",60);}
case 60:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=69;continue;}
case 69:{f.Pc=31;continue;}
case 72:{f.Pc=80;continue;}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","parse","(Ljava/lang/String;)V","invokespecial",80);}
case 80:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7679(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Ward","costs","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7680(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Ward","costs","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?14:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","isComplexCost","()Z","invokespecial",11);}
case 11:{f.Pc=f.Pop().Int==0?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7681(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Ward","costs","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?34:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","getTitleCost","()Ljava/lang/String;","invokespecial",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Ward","cost","Lforge/game/cost/Cost;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int!=0?26:21;continue;}
case 21:{f.Push(JValue.R(rt.String(".")));f.Pc=23;continue;}
case 23:{f.Pc=28;continue;}
case 26:{f.Push(JValue.R(rt.String("")));f.Pc=28;continue;}
case 28:{return rt.DynamicCall(f,"forge/game/keyword/Ward:7681:28:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",33);}
case 33:{return JStep.Return(f.Pop());}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Ward","costs","Ljava/util/Map;"));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",43);}
case 43:{return rt.DynamicCall(f,"forge/game/keyword/Ward:7681:43:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",48);}
case 48:{f.Push(JValue.R(rt.String("or")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;Ljava/lang/String;)Ljava/lang/String;","invokestatic",53);}
case 53:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7682(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Ward","costs","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?16:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/keyword/Ward","getCost","()Lforge/game/cost/Cost;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/keyword/Ward","costToReminderDesc","(Lforge/game/cost/Cost;)Ljava/lang/String;","invokevirtual",15);}
case 15:{return JStep.Return(f.Pop());}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Ward","costs","Ljava/util/Map;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",25);}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.DynamicCall(f,"forge/game/keyword/Ward:7682:26:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/keyword/Ward;)Ljava/util/function/Function;",31);}
case 31:{f.Push(JValue.R(rt.String("or")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;Ljava/lang/String;)Ljava/lang/String;","invokestatic",36);}
case 36:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7683(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Pay ")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?26:14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("Pay ")));f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("pays ")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Pc=103;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("Discard ")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int==0?47:35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("Discard")));f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("discards")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",43);}
case 43:{f.Locals[2]=f.Pop();f.Pc=44;continue;}
case 44:{f.Pc=103;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int==0?64:54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{return rt.DynamicCall(f,"forge/game/keyword/Ward:7683:55:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",60);}
case 60:{f.Locals[2]=f.Pop();f.Pc=61;continue;}
case 61:{f.Pc=103;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("(?:Sacrifice|Exile|Tap|Remove|Return|Reveal|Mill|Put|Untap|Unattach|Collect) .*")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/String","matches","(Ljava/lang/String;)Z","invokevirtual",70);}
case 70:{f.Pc=f.Pop().Int==0?103:73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{f.Push(JValue.I(0));f.Pc=75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{f.Push(JValue.I(32));f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",81);}
case 81:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",84);}
case 84:{f.Locals[3]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",89);}
case 89:{f.Push(f.Locals[2]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[3]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",94);}
case 94:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",97);}
case 97:{return rt.DynamicCall(f,"forge/game/keyword/Ward:7683:97:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",102);}
case 102:{f.Locals[2]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[2]);f.Pc=104;continue;}
case 104:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7684(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?12:7;continue;}
case 7:{f.Push(JValue.R(rt.String("pay ")));f.Pc=9;continue;}
case 9:{f.Pc=14;continue;}
case 12:{f.Push(JValue.R(rt.String("")));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",18);}
case 18:{return rt.DynamicCall(f,"forge/game/keyword/Ward:7684:18:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",23);}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

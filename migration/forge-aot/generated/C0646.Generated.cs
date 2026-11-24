// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C646{
internal static JClass Build(){var c=new JClass("forge/game/keyword/Emerge","forge/game/keyword/KeywordWithCost",new string[]{"forge/game/keyword/KeywordWithTypeInterface"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("type","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("descType","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(7419,"forge/game/keyword/Emerge","<init>","()V",1,1,2,new JHandler[]{},M7419));
c.Add(new JMethod(7420,"forge/game/keyword/Emerge","getValidType","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7420));
c.Add(new JMethod(7421,"forge/game/keyword/Emerge","getTypeDescription","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7421));
c.Add(new JMethod(7422,"forge/game/keyword/Emerge","getTitleWithoutCost","()Ljava/lang/String;",1,2,2,new JHandler[]{},M7422));
c.Add(new JMethod(7423,"forge/game/keyword/Emerge","parse","(Ljava/lang/String;)V",4,3,5,new JHandler[]{},M7423));
c.Add(new JMethod(7424,"forge/game/keyword/Emerge","formatReminderText","(Ljava/lang/String;)Ljava/lang/String;",4,2,5,new JHandler[]{},M7424));
}

internal static JStep M7419(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Emerge","type","Ljava/lang/String;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Emerge","descType","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7420(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Emerge","type","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?12:7;continue;}
case 7:{f.Push(JValue.R(rt.String("Creature")));f.Pc=9;continue;}
case 9:{f.Pc=16;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Emerge","type","Ljava/lang/String;"));f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7421(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Emerge","descType","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7422(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/keyword/Emerge","getKeyword","()Lforge/game/keyword/Keyword;","invokevirtual",13);}
case 13:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",16);}
case 16:{f.StackOp("pop");f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Emerge","type","Ljava/lang/String;"));f.Pc=21;continue;}
case 21:{f.Pc=f.Pop().Reference==null?38:24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String(" from ")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",30);}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/keyword/Emerge","getTypeDescription","()Ljava/lang/String;","invokevirtual",34);}
case 34:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",37);}
case 37:{f.StackOp("pop");f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",42);}
case 42:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7423(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String(":")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",19);}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Emerge","cost","Lforge/game/cost/Cost;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("creature")));f.Pc=25;continue;}
case 25:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Emerge","descType","Ljava/lang/String;",value);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=30;continue;}
case 30:{f.Push(JValue.I(2));f.Pc=31;continue;}
case 31:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?70:34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=39;continue;}
case 39:{f.StackOp("dup_x1");f.Pc=40;continue;}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Emerge","type","Ljava/lang/String;",value);f.Pc=43;continue;}
case 43:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Emerge","descType","Ljava/lang/String;",value);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Emerge","descType","Ljava/lang/String;"));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/card/CardType","isACardType","(Ljava/lang/String;)Z","invokestatic",53);}
case 53:{f.Pc=f.Pop().Int==0?70:56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Emerge","descType","Ljava/lang/String;"));f.Pc=61;continue;}
case 61:{if(!rt.StaticReady(f,"java/util/Locale","ENGLISH","Ljava/util/Locale;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/Locale","ENGLISH","Ljava/util/Locale;"));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/String","toLowerCase","(Ljava/util/Locale;)Ljava/lang/String;","invokevirtual",67);}
case 67:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Emerge","descType","Ljava/lang/String;",value);f.Pc=70;continue;}
case 70:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7424(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(2));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Emerge","cost","Lforge/game/cost/Cost;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",14);}
case 14:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Emerge","descType","Ljava/lang/String;"));f.Pc=21;continue;}
case 21:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",25);}
case 25:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

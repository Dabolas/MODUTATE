// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C649{
internal static JClass Build(){var c=new JClass("forge/game/keyword/Hexproof","forge/game/keyword/KeywordWithType",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(7431,"forge/game/keyword/Hexproof","<init>","()V",1,1,1,new JHandler[]{},M7431));
c.Add(new JMethod(7432,"forge/game/keyword/Hexproof","getTitle","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7432));
c.Add(new JMethod(7433,"forge/game/keyword/Hexproof","getTypeDescription","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7433));
c.Add(new JMethod(7434,"forge/game/keyword/Hexproof","formatReminderText","(Ljava/lang/String;)Ljava/lang/String;",4,2,5,new JHandler[]{},M7434));
}

internal static JStep M7431(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordWithType","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7432(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Hexproof","type","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?13:10;continue;}
case 10:{f.Push(JValue.R(rt.String("Hexproof")));f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/keyword/Hexproof","getTypeDescription","()Ljava/lang/String;","invokevirtual",17);}
case 17:{return rt.DynamicCall(f,"forge/game/keyword/Hexproof:7432:17:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",22);}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7433(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Hexproof","type","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardType","isACardType","(Ljava/lang/String;)Z","invokestatic",7);}
case 7:{f.Pc=f.Pop().Int==0?18:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Hexproof","type","Ljava/lang/String;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/card/CardType","getPluralType","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",17);}
case 17:{return JStep.Return(f.Pop());}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/keyword/KeywordWithType","getTypeDescription","()Ljava/lang/String;","invokespecial",22);}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7434(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Hexproof","type","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?13:10;continue;}
case 10:{f.Push(JValue.R(rt.String("This can't be the target of spells or abilities your opponents control.")));f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Hexproof","descType","Ljava/lang/String;"));f.Pc=24;continue;}
case 24:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",28);}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

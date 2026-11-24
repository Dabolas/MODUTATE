// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C127{
internal static JClass Build(){var c=new JClass("forge/game/DrawOffer","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("offerer","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("votes","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JMethod(1858,"forge/game/DrawOffer","<init>","(Lforge/game/player/Player;Ljava/lang/Iterable;)V",1,5,3,new JHandler[]{},M1858));
c.Add(new JMethod(1859,"forge/game/DrawOffer","getOfferer","()Lforge/game/player/Player;",1,1,1,new JHandler[]{},M1859));
c.Add(new JMethod(1860,"forge/game/DrawOffer","getVotes","()Ljava/util/Map;",1,1,1,new JHandler[]{},M1860));
c.Add(new JMethod(1861,"forge/game/DrawOffer","record","(Lforge/game/player/Player;Z)V",1,3,3,new JHandler[]{},M1861));
c.Add(new JMethod(1862,"forge/game/DrawOffer","isDeclined","()Z",1,1,2,new JHandler[]{},M1862));
c.Add(new JMethod(1863,"forge/game/DrawOffer","isUnanimousAccept","()Z",1,3,2,new JHandler[]{},M1863));
c.Add(new JMethod(1864,"forge/game/DrawOffer","isSettled","()Z",1,1,1,new JHandler[]{},M1864));
}

internal static JStep M1858(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/LinkedHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/LinkedHashMap")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/LinkedHashMap","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/DrawOffer","votes","Ljava/util/Map;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/DrawOffer","offerer","Lforge/game/player/Player;",value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",26);}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",33);}
case 33:{f.Pc=f.Pop().Int==0?65:36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[4]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/game/DrawOffer","votes","Ljava/util/Map;"));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{if(!rt.StaticReady(f,"forge/game/DrawOffer$Vote","PENDING","Lforge/game/DrawOffer$Vote;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/DrawOffer$Vote","PENDING","Lforge/game/DrawOffer$Vote;"));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{f.Pc=27;continue;}
case 65:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1859(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/DrawOffer","offerer","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1860(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/DrawOffer","votes","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1861(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/DrawOffer","votes","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?37:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/DrawOffer","votes","Ljava/util/Map;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Pc=f.Pop().Int==0?28:22;continue;}
case 22:{if(!rt.StaticReady(f,"forge/game/DrawOffer$Vote","ACCEPTED","Lforge/game/DrawOffer$Vote;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/DrawOffer$Vote","ACCEPTED","Lforge/game/DrawOffer$Vote;"));f.Pc=25;continue;}
case 25:{f.Pc=31;continue;}
case 28:{if(!rt.StaticReady(f,"forge/game/DrawOffer$Vote","DECLINED","Lforge/game/DrawOffer$Vote;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/DrawOffer$Vote","DECLINED","Lforge/game/DrawOffer$Vote;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",36);}
case 36:{f.StackOp("pop");f.Pc=37;continue;}
case 37:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1862(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/DrawOffer","votes","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/DrawOffer$Vote","DECLINED","Lforge/game/DrawOffer$Vote;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/DrawOffer$Vote","DECLINED","Lforge/game/DrawOffer$Vote;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","containsValue","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1863(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/DrawOffer","votes","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int==0?14:12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/DrawOffer","votes","Ljava/util/Map;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",23);}
case 23:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",28);}
case 28:{f.Locals[1]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",35);}
case 35:{f.Pc=f.Pop().Int==0?60:38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",44);}
case 44:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/DrawOffer$Vote"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=47;continue;}
case 47:{f.Locals[2]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{if(!rt.StaticReady(f,"forge/game/DrawOffer$Vote","ACCEPTED","Lforge/game/DrawOffer$Vote;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/DrawOffer$Vote","ACCEPTED","Lforge/game/DrawOffer$Vote;"));f.Pc=52;continue;}
case 52:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?57:55;continue;}
case 55:{f.Push(JValue.I(0));f.Pc=56;continue;}
case 56:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 57:{f.Pc=29;continue;}
case 60:{f.Push(JValue.I(1));f.Pc=61;continue;}
case 61:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1864(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/DrawOffer","isDeclined","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?14:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/DrawOffer","isUnanimousAccept","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

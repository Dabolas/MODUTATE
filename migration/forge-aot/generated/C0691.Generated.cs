// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C691{
internal static JClass Build(){var c=new JClass("forge/game/mulligan/OriginalMulligan","forge/game/mulligan/AbstractMulligan",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(7827,"forge/game/mulligan/OriginalMulligan","<init>","(Lforge/game/player/Player;Z)V",1,3,3,new JHandler[]{},M7827));
c.Add(new JMethod(7828,"forge/game/mulligan/OriginalMulligan","canMulligan","()Z",1,5,2,new JHandler[]{},M7828));
c.Add(new JMethod(7829,"forge/game/mulligan/OriginalMulligan","revealPreMulligan","(Lforge/game/card/CardCollection;)V",1,2,0,new JHandler[]{},M7829));
c.Add(new JMethod(7830,"forge/game/mulligan/OriginalMulligan","mulliganDraw","()V",1,1,2,new JHandler[]{},M7830));
c.Add(new JMethod(7831,"forge/game/mulligan/OriginalMulligan","handSizeAfterNextMulligan","()I",1,1,1,new JHandler[]{},M7831));
}

internal static JStep M7827(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/mulligan/AbstractMulligan","<init>","(Lforge/game/player/Player;Z)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7828(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/OriginalMulligan","timesMulliganed","I"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int<=0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{f.Locals[1]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/OriginalMulligan","player","Lforge/game/player/Player;"));f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",28);}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",35);}
case 35:{f.Pc=f.Pop().Int==0?66:38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",44);}
case 44:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=47;continue;}
case 47:{f.Locals[4]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/card/Card","isLand","()Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int==0?60:57;continue;}
case 57:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=60;continue;}
case 60:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(1)));f.Pc=63;continue;}
case 63:{f.Pc=29;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{f.Pc=f.Pop().Int==0?75:70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?79:75;continue;}
case 75:{f.Push(JValue.I(1));f.Pc=76;continue;}
case 76:{f.Pc=80;continue;}
case 79:{f.Push(JValue.I(0));f.Pc=80;continue;}
case 80:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7829(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7830(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/OriginalMulligan","player","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/mulligan/OriginalMulligan","handSizeAfterNextMulligan","()I","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/player/Player","drawCards","(I)Lforge/game/card/CardCollectionView;","invokevirtual",11);}
case 11:{f.StackOp("pop");f.Pc=12;continue;}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7831(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/OriginalMulligan","player","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/Player","getMaxHandSize","()I","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

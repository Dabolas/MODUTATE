// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1048{
internal static JClass Build(){var c=new JClass("forge/game/zone/PlayerZoneBattlefield","forge/game/zone/PlayerZone",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(5750837078903423978L),null));
c.Add(new JField("trigger","Z",false,JValue.Default("Z"),null));
c.Add(new JField("meldedCards","Lforge/game/card/CardCollection;",false,JValue.Default("Lforge/game/card/CardCollection;"),null));
c.Add(new JMethod(11103,"forge/game/zone/PlayerZoneBattlefield","<init>","(Lforge/game/zone/ZoneType;Lforge/game/player/Player;)V",1,3,3,new JHandler[]{},M11103));
c.Add(new JMethod(11104,"forge/game/zone/PlayerZoneBattlefield","addToMelded","(Lforge/game/card/Card;)V",17,2,2,new JHandler[]{},M11104));
c.Add(new JMethod(11105,"forge/game/zone/PlayerZoneBattlefield","removeFromMelded","(Lforge/game/card/Card;)V",17,2,2,new JHandler[]{},M11105));
c.Add(new JMethod(11106,"forge/game/zone/PlayerZoneBattlefield","add","(Lforge/game/card/Card;Ljava/lang/Integer;Lforge/game/card/Card;)V",17,4,4,new JHandler[]{},M11106));
c.Add(new JMethod(11107,"forge/game/zone/PlayerZoneBattlefield","setTriggers","(Z)V",17,2,2,new JHandler[]{},M11107));
c.Add(new JMethod(11108,"forge/game/zone/PlayerZoneBattlefield","getCards","(Z)Lforge/game/card/CardCollectionView;",17,7,2,new JHandler[]{},M11108));
c.Add(new JMethod(11109,"forge/game/zone/PlayerZoneBattlefield","getMeldedCards","()Lforge/game/card/CardCollection;",17,1,1,new JHandler[]{},M11109));
}

internal static JStep M11103(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/zone/PlayerZone","<init>","(Lforge/game/zone/ZoneType;Lforge/game/player/Player;)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/PlayerZoneBattlefield","trigger","Z",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",19);}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/PlayerZoneBattlefield","meldedCards","Lforge/game/card/CardCollection;",value);f.Pc=22;continue;}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11104(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/zone/Zone","remove","(Lforge/game/card/Card;)V","invokevirtual",8);}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/Card","setZone","(Lforge/game/zone/Zone;)V","invokevirtual",13);}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/PlayerZoneBattlefield","meldedCards","Lforge/game/card/CardCollection;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11105(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/PlayerZoneBattlefield","meldedCards","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{f.StackOp("pop");f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11106(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?14:4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("PlayerZoneComesInto Play : add() object is null")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",13);}
case 13:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/zone/PlayerZone","add","(Lforge/game/card/Card;Ljava/lang/Integer;Lforge/game/card/Card;)V","invokespecial",21);}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/PlayerZoneBattlefield","trigger","Z"));f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Int==0?33:28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/Card","setSickness","(Z)V","invokevirtual",33);}
case 33:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11107(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/PlayerZoneBattlefield","trigger","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11108(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","(Z)Lforge/game/card/CardCollectionView;","invokespecial",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Int!=0?12:10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",20);}
case 20:{f.Locals[4]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?60:32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",49);}
case 49:{f.Pc=f.Pop().Int==0?57:52;continue;}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{f.Locals[3]=f.Pop();f.Pc=54;continue;}
case 54:{f.Pc=60;continue;}
case 57:{f.Pc=22;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{f.Pc=f.Pop().Int==0?125:64;continue;}
case 64:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=67;continue;}
case 67:{f.StackOp("dup");f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",71);}
case 71:{f.Locals[4]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",79);}
case 79:{f.Locals[5]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[5]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",88);}
case 88:{f.Pc=f.Pop().Int==0?122:91;continue;}
case 91:{f.Push(f.Locals[5]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",98);}
case 98:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=101;continue;}
case 101:{f.Locals[6]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[6]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",108);}
case 108:{f.Pc=f.Pop().Int!=0?119:111;continue;}
case 111:{f.Push(f.Locals[4]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[6]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",118);}
case 118:{f.StackOp("pop");f.Pc=119;continue;}
case 119:{f.Pc=81;continue;}
case 122:{f.Push(f.Locals[4]);f.Pc=124;continue;}
case 124:{f.Locals[2]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[2]);f.Pc=126;continue;}
case 126:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11109(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/PlayerZoneBattlefield","meldedCards","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

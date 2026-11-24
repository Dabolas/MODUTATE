// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C734{
internal static JClass Build(){var c=new JClass("forge/game/player/actions/ScryAction","forge/game/player/actions/PlayerAction",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("topCardNames","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("bottomCardNames","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(8860,"forge/game/player/actions/ScryAction","<init>","(Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;)V",1,3,3,new JHandler[]{},M8860));
c.Add(new JMethod(8861,"forge/game/player/actions/ScryAction","namesOf","(Lforge/game/card/CardCollectionView;)Ljava/util/List;",10,4,2,new JHandler[]{},M8861));
c.Add(new JMethod(8862,"forge/game/player/actions/ScryAction","getTopCardNames","()Ljava/util/List;",1,1,1,new JHandler[]{},M8862));
c.Add(new JMethod(8863,"forge/game/player/actions/ScryAction","getBottomCardNames","()Ljava/util/List;",1,1,1,new JHandler[]{},M8863));
c.Add(new JMethod(8864,"forge/game/player/actions/ScryAction","appendDetails","(Ljava/lang/StringBuilder;)V",4,2,2,new JHandler[]{},M8864));
}

internal static JStep M8860(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.String("Scry")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/actions/PlayerAction","<init>","(Lforge/game/GameEntityView;Ljava/lang/String;)V","invokespecial",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/player/actions/ScryAction","namesOf","(Lforge/game/card/CardCollectionView;)Ljava/util/List;","invokestatic",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/actions/ScryAction","topCardNames","Ljava/util/List;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/player/actions/ScryAction","namesOf","(Lforge/game/card/CardCollectionView;)Ljava/util/List;","invokestatic",20);}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/actions/ScryAction","bottomCardNames","Ljava/util/List;",value);f.Pc=23;continue;}
case 23:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8861(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?13:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?17:13;continue;}
case 13:{return rt.Call(f,"java/util/Collections","emptyList","()Ljava/util/List;","invokestatic",16);}
case 16:{return JStep.Return(f.Pop());}
case 17:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",24);}
case 24:{f.Locals[1]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",31);}
case 31:{f.Locals[2]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",38);}
case 38:{f.Pc=f.Pop().Int==0?65:41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{f.Locals[3]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",56);}
case 56:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{f.Pc=32;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8862(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/actions/ScryAction","topCardNames","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8863(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/actions/ScryAction","bottomCardNames","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8864(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String(" top=")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/player/actions/ScryAction","topCardNames","Ljava/util/List;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",13);}
case 13:{f.StackOp("pop");f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String(" bottom=")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",20);}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/player/actions/ScryAction","bottomCardNames","Ljava/util/List;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",27);}
case 27:{f.StackOp("pop");f.Pc=28;continue;}
case 28:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

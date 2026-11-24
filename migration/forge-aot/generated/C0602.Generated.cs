// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C602{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventGameStarted","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("gameType","Lforge/game/GameType;",false,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("firstTurn","Lforge/game/player/PlayerView;",false,JValue.Default("Lforge/game/player/PlayerView;"),null));
c.Add(new JField("players","Ljava/lang/Iterable;",false,JValue.Default("Ljava/lang/Iterable;"),null));
c.Add(new JMethod(6991,"forge/game/event/GameEventGameStarted","<init>","(Lforge/game/GameType;Lforge/game/player/Player;Ljava/lang/Iterable;)V",1,4,4,new JHandler[]{},M6991));
c.Add(new JMethod(6992,"forge/game/event/GameEventGameStarted","<init>","(Lforge/game/GameType;Lforge/game/player/PlayerView;Ljava/lang/Iterable;)V",1,4,2,new JHandler[]{},M6992));
c.Add(new JMethod(6993,"forge/game/event/GameEventGameStarted","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6993));
c.Add(new JMethod(6994,"forge/game/event/GameEventGameStarted","toString","()Ljava/lang/String;",1,1,4,new JHandler[]{},M6994));
c.Add(new JMethod(6995,"forge/game/event/GameEventGameStarted","hashCode","()I",17,1,1,new JHandler[]{},M6995));
c.Add(new JMethod(6996,"forge/game/event/GameEventGameStarted","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M6996));
c.Add(new JMethod(6997,"forge/game/event/GameEventGameStarted","gameType","()Lforge/game/GameType;",1,1,1,new JHandler[]{},M6997));
c.Add(new JMethod(6998,"forge/game/event/GameEventGameStarted","firstTurn","()Lforge/game/player/PlayerView;",1,1,1,new JHandler[]{},M6998));
c.Add(new JMethod(6999,"forge/game/event/GameEventGameStarted","players","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M6999));
}

internal static JStep M6991(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",6);}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/player/PlayerView","getCollection","(Ljava/lang/Iterable;)Lforge/trackable/TrackableCollection;","invokestatic",10);}
case 10:{return rt.Call(f,"forge/game/event/GameEventGameStarted","<init>","(Lforge/game/GameType;Lforge/game/player/PlayerView;Ljava/lang/Iterable;)V","invokespecial",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6992(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventGameStarted","gameType","Lforge/game/GameType;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventGameStarted","firstTurn","Lforge/game/player/PlayerView;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventGameStarted","players","Ljava/lang/Iterable;",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6993(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventGameStarted;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6994(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(6));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventGameStarted","gameType","Lforge/game/GameType;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/GameType","toString","()Ljava/lang/String;","invokevirtual",14);}
case 14:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("game between")));f.Pc=19;continue;}
case 19:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{f.Push(JValue.I(2));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventGameStarted","players","Ljava/lang/Iterable;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/lang/Iterable;)Ljava/lang/String;","invokestatic",29);}
case 29:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{f.Push(JValue.I(3));f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("started.")));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(4));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventGameStarted","firstTurn","Lforge/game/player/PlayerView;"));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/player/PlayerView","toString","()Ljava/lang/String;","invokevirtual",44);}
case 44:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=45;continue;}
case 45:{f.StackOp("dup");f.Pc=46;continue;}
case 46:{f.Push(JValue.I(5));f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("goes first ")));f.Pc=49;continue;}
case 49:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",53);}
case 53:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6995(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventGameStarted:6995:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventGameStarted;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6996(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventGameStarted:6996:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventGameStarted;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6997(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventGameStarted","gameType","Lforge/game/GameType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6998(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventGameStarted","firstTurn","Lforge/game/player/PlayerView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6999(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventGameStarted","players","Ljava/lang/Iterable;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

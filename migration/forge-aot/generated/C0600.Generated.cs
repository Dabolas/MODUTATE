// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C600{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventGameOutcome","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("lastTurnNumber","I",false,JValue.Default("I"),null));
c.Add(new JField("outcomeStrings","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("winningPlayerName","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("matchSummary","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(6972,"forge/game/event/GameEventGameOutcome","<init>","(Lforge/game/GameOutcome;Ljava/util/Collection;)V",1,3,5,new JHandler[]{},M6972));
c.Add(new JMethod(6973,"forge/game/event/GameEventGameOutcome","<init>","(ILjava/util/List;Ljava/lang/String;Ljava/lang/String;)V",1,5,2,new JHandler[]{},M6973));
c.Add(new JMethod(6974,"forge/game/event/GameEventGameOutcome","computeWinningPlayerName","(Lforge/game/GameOutcome;)Ljava/lang/String;",10,2,1,new JHandler[]{},M6974));
c.Add(new JMethod(6975,"forge/game/event/GameEventGameOutcome","computeMatchSummary","(Ljava/util/Collection;)Ljava/lang/String;",10,7,5,new JHandler[]{},M6975));
c.Add(new JMethod(6976,"forge/game/event/GameEventGameOutcome","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6976));
c.Add(new JMethod(6977,"forge/game/event/GameEventGameOutcome","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6977));
c.Add(new JMethod(6978,"forge/game/event/GameEventGameOutcome","hashCode","()I",17,1,1,new JHandler[]{},M6978));
c.Add(new JMethod(6979,"forge/game/event/GameEventGameOutcome","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M6979));
c.Add(new JMethod(6980,"forge/game/event/GameEventGameOutcome","lastTurnNumber","()I",1,1,1,new JHandler[]{},M6980));
c.Add(new JMethod(6981,"forge/game/event/GameEventGameOutcome","outcomeStrings","()Ljava/util/List;",1,1,1,new JHandler[]{},M6981));
c.Add(new JMethod(6982,"forge/game/event/GameEventGameOutcome","winningPlayerName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6982));
c.Add(new JMethod(6983,"forge/game/event/GameEventGameOutcome","matchSummary","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6983));
c.Add(new JMethod(6984,"forge/game/event/GameEventGameOutcome","lambda$computeMatchSummary$0","(Lforge/game/GameOutcome;)Z",4106,1,1,new JHandler[]{},M6984));
}

internal static JStep M6972(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameOutcome","getLastTurnNumber","()I","invokevirtual",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/GameOutcome","getOutcomeStrings","()Ljava/util/List;","invokevirtual",9);}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/event/GameEventGameOutcome","computeWinningPlayerName","(Lforge/game/GameOutcome;)Ljava/lang/String;","invokestatic",13);}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/event/GameEventGameOutcome","computeMatchSummary","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",17);}
case 17:{return rt.Call(f,"forge/game/event/GameEventGameOutcome","<init>","(ILjava/util/List;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",20);}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6973(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventGameOutcome","lastTurnNumber","I",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventGameOutcome","outcomeStrings","Ljava/util/List;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventGameOutcome","winningPlayerName","Ljava/lang/String;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventGameOutcome","matchSummary","Ljava/lang/String;",value);f.Pc=25;continue;}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6974(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameOutcome","getWinningLobbyPlayer","()Lforge/LobbyPlayer;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference==null?16:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/LobbyPlayer","getName","()Ljava/lang/String;","invokevirtual",13);}
case 13:{f.Pc=17;continue;}
case 16:{f.Push(JValue.R(null));f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6975(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",5);}
case 5:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameOutcome"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=8;continue;}
case 8:{f.Locals[1]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Reference!=null?16:13;continue;}
case 13:{f.Push(JValue.R(rt.String("")));f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/GameOutcome","getPlayerNames","()Ljava/util/HashMap;","invokevirtual",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",27);}
case 27:{return rt.DynamicCall(f,"forge/game/event/GameEventGameOutcome:6975:27:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",32);}
case 32:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",37);}
case 37:{return rt.DynamicCall(f,"forge/game/event/GameEventGameOutcome:6975:37:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",42);}
case 42:{return rt.Call(f,"java/util/stream/Collectors","counting","()Ljava/util/stream/Collector;","invokestatic",45);}
case 45:{return rt.Call(f,"java/util/stream/Collectors","groupingBy","(Ljava/util/function/Function;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;","invokestatic",48);}
case 48:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",53);}
case 53:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=56;continue;}
case 56:{f.Locals[3]=f.Pop();f.Pc=57;continue;}
case 57:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=60;continue;}
case 60:{f.StackOp("dup");f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",64);}
case 64:{f.Locals[4]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/HashMap","entrySet","()Ljava/util/Set;","invokevirtual",70);}
case 70:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",75);}
case 75:{f.Locals[5]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[5]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",84);}
case 84:{f.Pc=f.Pop().Int==0?148:87;continue;}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",94);}
case 94:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=97;continue;}
case 97:{f.Locals[6]=f.Pop();f.Pc=99;continue;}
case 99:{f.Push(f.Locals[4]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[6]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",108);}
case 108:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",114);}
case 114:{f.Push(JValue.R(rt.String(": ")));f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",119);}
case 119:{f.Push(f.Locals[3]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[6]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",127);}
case 127:{f.Push(JValue.L(0));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",131);}
case 131:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",136);}
case 136:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",139);}
case 139:{f.Push(JValue.R(rt.String(" ")));f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",144);}
case 144:{f.StackOp("pop");f.Pc=145;continue;}
case 145:{f.Pc=77;continue;}
case 148:{f.Push(f.Locals[4]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",153);}
case 153:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6976(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventGameOutcome;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6977(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventGameOutcome","outcomeStrings","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",7);}
case 7:{return rt.DynamicCall(f,"forge/game/event/GameEventGameOutcome:6977:7:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6978(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventGameOutcome:6978:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventGameOutcome;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6979(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventGameOutcome:6979:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventGameOutcome;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6980(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventGameOutcome","lastTurnNumber","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6981(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventGameOutcome","outcomeStrings","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6982(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventGameOutcome","winningPlayerName","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6983(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventGameOutcome","matchSummary","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6984(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameOutcome","getWinningPlayer","()Lforge/game/player/RegisteredPlayer;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

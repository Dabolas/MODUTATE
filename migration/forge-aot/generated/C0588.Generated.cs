// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C588{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventCardRegenerated","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("cards","Ljava/util/Collection;",false,JValue.Default("Ljava/util/Collection;"),null));
c.Add(new JMethod(6880,"forge/game/event/GameEventCardRegenerated","<init>","(Lforge/game/card/Card;)V",1,2,2,new JHandler[]{},M6880));
c.Add(new JMethod(6881,"forge/game/event/GameEventCardRegenerated","<init>","(Ljava/util/Collection;)V",1,2,2,new JHandler[]{},M6881));
c.Add(new JMethod(6882,"forge/game/event/GameEventCardRegenerated","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6882));
c.Add(new JMethod(6883,"forge/game/event/GameEventCardRegenerated","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M6883));
c.Add(new JMethod(6884,"forge/game/event/GameEventCardRegenerated","hashCode","()I",17,1,1,new JHandler[]{},M6884));
c.Add(new JMethod(6885,"forge/game/event/GameEventCardRegenerated","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M6885));
c.Add(new JMethod(6886,"forge/game/event/GameEventCardRegenerated","cards","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M6886));
}

internal static JStep M6880(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/game/card/Card;)Lforge/game/card/CardView;","invokestatic",5);}
case 5:{return rt.Call(f,"java/util/Collections","singletonList","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",8);}
case 8:{return rt.Call(f,"forge/game/event/GameEventCardRegenerated","<init>","(Ljava/util/Collection;)V","invokespecial",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6881(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventCardRegenerated","cards","Ljava/util/Collection;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6882(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCardRegenerated;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6883(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventCardRegenerated:6883:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventCardRegenerated;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6884(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventCardRegenerated:6884:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventCardRegenerated;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6885(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventCardRegenerated:6885:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventCardRegenerated;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6886(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardRegenerated","cards","Ljava/util/Collection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

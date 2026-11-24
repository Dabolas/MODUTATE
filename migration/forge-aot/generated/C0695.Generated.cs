// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C695{
internal static JClass Build(){var c=new JClass("forge/game/phase/ExtraTurn","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("player","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("delTrig","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("skipUntapSA","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JField("cantSetSchemesInMotionSA","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JMethod(7841,"forge/game/phase/ExtraTurn","<init>","(Lforge/game/player/Player;)V",1,2,3,new JHandler[]{},M7841));
c.Add(new JMethod(7842,"forge/game/phase/ExtraTurn","getPlayer","()Lforge/game/player/Player;",1,1,1,new JHandler[]{},M7842));
c.Add(new JMethod(7843,"forge/game/phase/ExtraTurn","setPlayer","(Lforge/game/player/Player;)V",1,2,2,new JHandler[]{},M7843));
c.Add(new JMethod(7844,"forge/game/phase/ExtraTurn","addTrigger","(Lforge/game/trigger/Trigger;)V",1,2,2,new JHandler[]{},M7844));
c.Add(new JMethod(7845,"forge/game/phase/ExtraTurn","getDelayedTriggers","()Ljava/util/List;",1,1,1,new JHandler[]{},M7845));
c.Add(new JMethod(7846,"forge/game/phase/ExtraTurn","isSkipUntap","()Z",1,1,1,new JHandler[]{},M7846));
c.Add(new JMethod(7847,"forge/game/phase/ExtraTurn","getSkipUntapSA","()Lforge/game/spellability/SpellAbility;",1,1,1,new JHandler[]{},M7847));
c.Add(new JMethod(7848,"forge/game/phase/ExtraTurn","setSkipUntapSA","(Lforge/game/spellability/SpellAbility;)V",1,2,2,new JHandler[]{},M7848));
c.Add(new JMethod(7849,"forge/game/phase/ExtraTurn","isCantSetSchemesInMotion","()Z",1,1,1,new JHandler[]{},M7849));
c.Add(new JMethod(7850,"forge/game/phase/ExtraTurn","getCantSetSchemesInMotionSA","()Lforge/game/spellability/SpellAbility;",1,1,1,new JHandler[]{},M7850));
c.Add(new JMethod(7851,"forge/game/phase/ExtraTurn","setCantSetSchemesInMotionSA","(Lforge/game/spellability/SpellAbility;)V",1,2,2,new JHandler[]{},M7851));
}

internal static JStep M7841(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/ExtraTurn","player","Lforge/game/player/Player;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",17);}
case 17:{return rt.Call(f,"java/util/Collections","synchronizedList","(Ljava/util/List;)Ljava/util/List;","invokestatic",20);}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/ExtraTurn","delTrig","Ljava/util/List;",value);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/ExtraTurn","player","Lforge/game/player/Player;",value);f.Pc=28;continue;}
case 28:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7842(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/ExtraTurn","player","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7843(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/ExtraTurn","player","Lforge/game/player/Player;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7844(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/ExtraTurn","delTrig","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7845(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/ExtraTurn","delTrig","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7846(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/ExtraTurn","skipUntapSA","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7847(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/ExtraTurn","skipUntapSA","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7848(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/ExtraTurn","skipUntapSA","Lforge/game/spellability/SpellAbility;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7849(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/ExtraTurn","cantSetSchemesInMotionSA","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7850(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/ExtraTurn","cantSetSchemesInMotionSA","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7851(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/ExtraTurn","cantSetSchemesInMotionSA","Lforge/game/spellability/SpellAbility;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

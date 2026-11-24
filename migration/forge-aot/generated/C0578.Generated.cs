// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C578{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventCardAttachment","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("equipment","Lforge/game/card/CardView;",false,JValue.Default("Lforge/game/card/CardView;"),null));
c.Add(new JField("oldEntity","Lforge/game/GameEntityView;",false,JValue.Default("Lforge/game/GameEntityView;"),null));
c.Add(new JField("newTarget","Lforge/game/GameEntityView;",false,JValue.Default("Lforge/game/GameEntityView;"),null));
c.Add(new JMethod(6801,"forge/game/event/GameEventCardAttachment","<init>","(Lforge/game/card/Card;Lforge/game/GameEntity;Lforge/game/GameEntity;)V",1,4,4,new JHandler[]{},M6801));
c.Add(new JMethod(6802,"forge/game/event/GameEventCardAttachment","<init>","(Lforge/game/card/CardView;Lforge/game/GameEntityView;Lforge/game/GameEntityView;)V",1,4,2,new JHandler[]{},M6802));
c.Add(new JMethod(6803,"forge/game/event/GameEventCardAttachment","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6803));
c.Add(new JMethod(6804,"forge/game/event/GameEventCardAttachment","toString","()Ljava/lang/String;",1,1,3,new JHandler[]{},M6804));
c.Add(new JMethod(6805,"forge/game/event/GameEventCardAttachment","hashCode","()I",17,1,1,new JHandler[]{},M6805));
c.Add(new JMethod(6806,"forge/game/event/GameEventCardAttachment","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M6806));
c.Add(new JMethod(6807,"forge/game/event/GameEventCardAttachment","equipment","()Lforge/game/card/CardView;",1,1,1,new JHandler[]{},M6807));
c.Add(new JMethod(6808,"forge/game/event/GameEventCardAttachment","oldEntity","()Lforge/game/GameEntityView;",1,1,1,new JHandler[]{},M6808));
c.Add(new JMethod(6809,"forge/game/event/GameEventCardAttachment","newTarget","()Lforge/game/GameEntityView;",1,1,1,new JHandler[]{},M6809));
}

internal static JStep M6801(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/game/card/Card;)Lforge/game/card/CardView;","invokestatic",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/GameEntityView","get","(Lforge/game/GameEntity;)Lforge/game/GameEntityView;","invokestatic",9);}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/GameEntityView","get","(Lforge/game/GameEntity;)Lforge/game/GameEntityView;","invokestatic",13);}
case 13:{return rt.Call(f,"forge/game/event/GameEventCardAttachment","<init>","(Lforge/game/card/CardView;Lforge/game/GameEntityView;Lforge/game/GameEntityView;)V","invokespecial",16);}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6802(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventCardAttachment","equipment","Lforge/game/card/CardView;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventCardAttachment","oldEntity","Lforge/game/GameEntityView;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventCardAttachment","newTarget","Lforge/game/GameEntityView;",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6803(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCardAttachment;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6804(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardAttachment","newTarget","Lforge/game/GameEntityView;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?29:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardAttachment","equipment","Lforge/game/card/CardView;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardAttachment","oldEntity","Lforge/game/GameEntityView;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",21);}
case 21:{return rt.DynamicCall(f,"forge/game/event/GameEventCardAttachment:6804:21:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",26);}
case 26:{f.Pc=72;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardAttachment","equipment","Lforge/game/card/CardView;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",36);}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardAttachment","oldEntity","Lforge/game/GameEntityView;"));f.Pc=40;continue;}
case 40:{f.Pc=f.Pop().Reference!=null?48:43;continue;}
case 43:{f.Push(JValue.R(rt.String("")));f.Pc=45;continue;}
case 45:{f.Pc=60;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardAttachment","oldEntity","Lforge/game/GameEntityView;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",55);}
case 55:{return rt.DynamicCall(f,"forge/game/event/GameEventCardAttachment:6804:55:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",60);}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardAttachment","newTarget","Lforge/game/GameEntityView;"));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",67);}
case 67:{return rt.DynamicCall(f,"forge/game/event/GameEventCardAttachment:6804:67:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",72);}
case 72:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6805(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventCardAttachment:6805:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventCardAttachment;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6806(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventCardAttachment:6806:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventCardAttachment;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6807(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardAttachment","equipment","Lforge/game/card/CardView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6808(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardAttachment","oldEntity","Lforge/game/GameEntityView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6809(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardAttachment","newTarget","Lforge/game/GameEntityView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

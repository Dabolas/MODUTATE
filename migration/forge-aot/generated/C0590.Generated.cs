// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C590{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventCardStatsChanged","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("cards","Ljava/util/Collection;",false,JValue.Default("Ljava/util/Collection;"),null));
c.Add(new JField("transform","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(6893,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V",1,2,3,new JHandler[]{},M6893));
c.Add(new JMethod(6894,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;Z)V",1,3,5,new JHandler[]{},M6894));
c.Add(new JMethod(6895,"forge/game/event/GameEventCardStatsChanged","<init>","(Ljava/util/Collection;)V",1,2,3,new JHandler[]{},M6895));
c.Add(new JMethod(6896,"forge/game/event/GameEventCardStatsChanged","<init>","(Ljava/util/Collection;Z)V",1,3,2,new JHandler[]{},M6896));
c.Add(new JMethod(6897,"forge/game/event/GameEventCardStatsChanged","isRedrawHint","()Z",1,1,1,new JHandler[]{},M6897));
c.Add(new JMethod(6898,"forge/game/event/GameEventCardStatsChanged","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6898));
c.Add(new JMethod(6899,"forge/game/event/GameEventCardStatsChanged","toString","()Ljava/lang/String;",1,2,6,new JHandler[]{},M6899));
c.Add(new JMethod(6900,"forge/game/event/GameEventCardStatsChanged","hashCode","()I",17,1,1,new JHandler[]{},M6900));
c.Add(new JMethod(6901,"forge/game/event/GameEventCardStatsChanged","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M6901));
c.Add(new JMethod(6902,"forge/game/event/GameEventCardStatsChanged","cards","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M6902));
c.Add(new JMethod(6903,"forge/game/event/GameEventCardStatsChanged","transform","()Z",1,1,1,new JHandler[]{},M6903));
}

internal static JStep M6893(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;Z)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6894(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/Card;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",12);}
case 12:{return rt.Call(f,"forge/game/card/CardView","getCollection","(Ljava/lang/Iterable;)Lforge/trackable/TrackableCollection;","invokestatic",15);}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Ljava/util/Collection;Z)V","invokespecial",19);}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6895(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardView","getCollection","(Ljava/lang/Iterable;)Lforge/trackable/TrackableCollection;","invokestatic",5);}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Ljava/util/Collection;Z)V","invokespecial",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6896(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventCardStatsChanged","cards","Ljava/util/Collection;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventCardStatsChanged","transform","Z",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6897(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6898(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCardStatsChanged;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6899(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardStatsChanged","cards","Ljava/util/Collection;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",8);}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(JValue.R(null));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?20:17;continue;}
case 17:{f.Push(JValue.R(rt.String("Card state changes: (empty list)")));f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardStatsChanged","cards","Ljava/util/Collection;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",29);}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?82:33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/card/CardView","getName","()Ljava/lang/String;","invokevirtual",37);}
case 37:{f.Push(JValue.I(2));f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.NewArray("Ljava/io/Serializable;",f.Pop().Int)));f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getType","()Lforge/card/CardTypeView;","invokevirtual",50);}
case 50:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=51;continue;}
case 51:{f.StackOp("dup");f.Pc=52;continue;}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{f.Push(JValue.I(32));f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/Character","valueOf","(C)Ljava/lang/Character;","invokestatic",58);}
case 58:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=59;continue;}
case 59:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","([Ljava/lang/Object;)Ljava/lang/String;","invokestatic",62);}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",66);}
case 66:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getPower","()I","invokevirtual",69);}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",73);}
case 73:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getToughness","()I","invokevirtual",76);}
case 76:{return rt.DynamicCall(f,"forge/game/event/GameEventCardStatsChanged:6899:76:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;II)Ljava/lang/String;",81);}
case 81:{return JStep.Return(f.Pop());}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/card/CardView","getName","()Ljava/lang/String;","invokevirtual",86);}
case 86:{f.Push(JValue.I(2));f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.NewArray("Ljava/io/Serializable;",f.Pop().Int)));f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(JValue.I(0));f.Pc=92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",96);}
case 96:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getType","()Lforge/card/CardTypeView;","invokevirtual",99);}
case 99:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=100;continue;}
case 100:{f.StackOp("dup");f.Pc=101;continue;}
case 101:{f.Push(JValue.I(1));f.Pc=102;continue;}
case 102:{f.Push(JValue.I(32));f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/lang/Character","valueOf","(C)Ljava/lang/Character;","invokestatic",107);}
case 107:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=108;continue;}
case 108:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","([Ljava/lang/Object;)Ljava/lang/String;","invokestatic",111);}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",115);}
case 115:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getPower","()I","invokevirtual",118);}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",122);}
case 122:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getToughness","()I","invokevirtual",125);}
case 125:{f.Push(f.Locals[0]);f.Pc=126;continue;}
case 126:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardStatsChanged","cards","Ljava/util/Collection;"));f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",134);}
case 134:{f.Push(JValue.I(1));f.Pc=135;continue;}
case 135:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=136;continue;}
case 136:{return rt.DynamicCall(f,"forge/game/event/GameEventCardStatsChanged:6899:136:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;III)Ljava/lang/String;",141);}
case 141:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6900(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventCardStatsChanged:6900:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventCardStatsChanged;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6901(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventCardStatsChanged:6901:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventCardStatsChanged;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6902(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardStatsChanged","cards","Ljava/util/Collection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6903(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardStatsChanged","transform","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

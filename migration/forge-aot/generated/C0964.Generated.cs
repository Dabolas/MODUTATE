// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C964{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerHandler","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("suppressedModes","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("allSuppressed","Z",false,JValue.Default("Z"),null));
c.Add(new JField("activeTriggers","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("delayedTriggers","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("thisTurnDelayedTriggers","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("playerDefinedDelayedTriggers","Lcom/google/common/collect/ListMultimap;",false,JValue.Default("Lcom/google/common/collect/ListMultimap;"),null));
c.Add(new JField("waitingTriggers","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("game","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JMethod(10505,"forge/game/trigger/TriggerHandler","<init>","(Lforge/game/Game;)V",1,2,3,new JHandler[]{},M10505));
c.Add(new JMethod(10506,"forge/game/trigger/TriggerHandler","registerDelayedTrigger","(Lforge/game/trigger/Trigger;)V",17,2,2,new JHandler[]{},M10506));
c.Add(new JMethod(10507,"forge/game/trigger/TriggerHandler","clearDelayedTrigger","()V",17,1,1,new JHandler[]{},M10507));
c.Add(new JMethod(10508,"forge/game/trigger/TriggerHandler","registerThisTurnDelayedTrigger","(Lforge/game/trigger/Trigger;)V",17,2,2,new JHandler[]{},M10508));
c.Add(new JMethod(10509,"forge/game/trigger/TriggerHandler","clearThisTurnDelayedTrigger","()V",17,1,2,new JHandler[]{},M10509));
c.Add(new JMethod(10510,"forge/game/trigger/TriggerHandler","clearDelayedTrigger","(Lforge/game/card/Card;)V",17,5,3,new JHandler[]{},M10510));
c.Add(new JMethod(10511,"forge/game/trigger/TriggerHandler","registerPlayerDefinedDelayedTrigger","(Lforge/game/player/Player;Lforge/game/trigger/Trigger;)V",17,3,3,new JHandler[]{},M10511));
c.Add(new JMethod(10512,"forge/game/trigger/TriggerHandler","clearPlayerDefinedDelayedTrigger","()V",17,1,1,new JHandler[]{},M10512));
c.Add(new JMethod(10513,"forge/game/trigger/TriggerHandler","handlePlayerDefinedDelTriggers","(Lforge/game/player/Player;)V",17,3,3,new JHandler[]{},M10513));
c.Add(new JMethod(10514,"forge/game/trigger/TriggerHandler","suppressMode","(Lforge/game/trigger/TriggerType;)V",17,2,2,new JHandler[]{},M10514));
c.Add(new JMethod(10515,"forge/game/trigger/TriggerHandler","setSuppressAllTriggers","(Z)V",17,2,2,new JHandler[]{},M10515));
c.Add(new JMethod(10516,"forge/game/trigger/TriggerHandler","clearSuppression","(Lforge/game/trigger/TriggerType;)V",17,2,2,new JHandler[]{},M10516));
c.Add(new JMethod(10517,"forge/game/trigger/TriggerHandler","isTriggerSuppressed","(Lforge/game/trigger/TriggerType;)Z",1,2,2,new JHandler[]{},M10517));
c.Add(new JMethod(10518,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;",9,3,4,new JHandler[]{},M10518));
c.Add(new JMethod(10519,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/trigger/Trigger;",9,7,4,new JHandler[]{new JHandler(0,14,15,"java/lang/Exception")},M10519));
c.Add(new JMethod(10520,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/util/Map;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/trigger/Trigger;",9,8,4,new JHandler[]{new JHandler(0,75,78,"java/lang/Exception")},M10520));
c.Add(new JMethod(10521,"forge/game/trigger/TriggerHandler","parseParams","(Ljava/lang/String;)Ljava/util/Map;",10,1,3,new JHandler[]{},M10521));
c.Add(new JMethod(10522,"forge/game/trigger/TriggerHandler","collectTriggerForWaiting","()V",1,1,2,new JHandler[]{},M10522));
c.Add(new JMethod(10523,"forge/game/trigger/TriggerHandler","collectTriggerForWaiting","(Z)V",1,6,5,new JHandler[]{},M10523));
c.Add(new JMethod(10524,"forge/game/trigger/TriggerHandler","resetActiveTriggers","()V",17,1,3,new JHandler[]{},M10524));
c.Add(new JMethod(10525,"forge/game/trigger/TriggerHandler","resetActiveTriggers","(ZLforge/game/card/CardCollectionView;)V",17,3,3,new JHandler[]{},M10525));
c.Add(new JMethod(10526,"forge/game/trigger/TriggerHandler","clearActiveTriggers","(Lforge/game/card/Card;Lforge/game/zone/Zone;)V",17,6,2,new JHandler[]{},M10526));
c.Add(new JMethod(10527,"forge/game/trigger/TriggerHandler","registerActiveTrigger","(Lforge/game/card/Card;Z)V",17,5,2,new JHandler[]{},M10527));
c.Add(new JMethod(10528,"forge/game/trigger/TriggerHandler","registerActiveLTBTrigger","(Lforge/game/card/Card;)V",17,4,2,new JHandler[]{},M10528));
c.Add(new JMethod(10529,"forge/game/trigger/TriggerHandler","registerOneTrigger","(Lforge/game/trigger/Trigger;)Z",17,2,2,new JHandler[]{},M10529));
c.Add(new JMethod(10530,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V",17,5,5,new JHandler[]{},M10530));
c.Add(new JMethod(10531,"forge/game/trigger/TriggerHandler","runStateTrigger","(Ljava/util/Map;)V",2,5,4,new JHandler[]{},M10531));
c.Add(new JMethod(10532,"forge/game/trigger/TriggerHandler","runWaitingTriggers","()Z",17,5,3,new JHandler[]{},M10532));
c.Add(new JMethod(10533,"forge/game/trigger/TriggerHandler","runWaitingTrigger","(Lforge/game/trigger/TriggerWaiting;)Z",2,13,5,new JHandler[]{},M10533));
c.Add(new JMethod(10534,"forge/game/trigger/TriggerHandler","getWaitingTriggerCount","()I",1,1,1,new JHandler[]{},M10534));
c.Add(new JMethod(10535,"forge/game/trigger/TriggerHandler","clearWaitingTriggersFrom","(I)V",1,2,3,new JHandler[]{},M10535));
c.Add(new JMethod(10536,"forge/game/trigger/TriggerHandler","clearWaitingTriggers","()V",1,1,1,new JHandler[]{},M10536));
c.Add(new JMethod(10537,"forge/game/trigger/TriggerHandler","isTriggerActive","(Lforge/game/trigger/Trigger;)Z",2,4,3,new JHandler[]{},M10537));
c.Add(new JMethod(10538,"forge/game/trigger/TriggerHandler","canRunTrigger","(Lforge/game/trigger/Trigger;Lforge/game/trigger/TriggerWaiting;)Z",2,4,5,new JHandler[]{},M10538));
c.Add(new JMethod(10539,"forge/game/trigger/TriggerHandler","runSingleTrigger","(Lforge/game/trigger/Trigger;Lforge/game/trigger/TriggerWaiting;Lforge/game/player/Player;)V",2,10,5,new JHandler[]{},M10539));
c.Add(new JMethod(10540,"forge/game/trigger/TriggerHandler","runSingleTriggerInternal","(Lforge/game/trigger/Trigger;Ljava/util/Map;Ljava/util/Map;Lforge/game/player/Player;)V",2,13,5,new JHandler[]{},M10540));
c.Add(new JMethod(10541,"forge/game/trigger/TriggerHandler","adjustUndoStack","(Lforge/game/trigger/Trigger;Ljava/util/Map;)V",2,8,2,new JHandler[]{},M10541));
c.Add(new JMethod(10542,"forge/game/trigger/TriggerHandler","getActiveTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;)Ljava/util/List;",1,3,5,new JHandler[]{},M10542));
c.Add(new JMethod(10543,"forge/game/trigger/TriggerHandler","getActiveTrigger","(Lforge/game/trigger/TriggerWaiting;)Ljava/util/List;",2,5,3,new JHandler[]{},M10543));
c.Add(new JMethod(10544,"forge/game/trigger/TriggerHandler","onPlayerLost","(Lforge/game/player/Player;)V",1,2,2,new JHandler[]{},M10544));
c.Add(new JMethod(10545,"forge/game/trigger/TriggerHandler","lambda$onPlayerLost$2","(Lforge/game/player/Player;Lforge/game/trigger/Trigger;)Z",4106,2,2,new JHandler[]{},M10545));
c.Add(new JMethod(10546,"forge/game/trigger/TriggerHandler","lambda$canRunTrigger$1","(Lforge/game/trigger/Trigger;Ljava/util/Map;)Z",4098,3,3,new JHandler[]{},M10546));
c.Add(new JMethod(10547,"forge/game/trigger/TriggerHandler","lambda$resetActiveTriggers$0","(Lforge/game/card/CardCollectionView;Lforge/game/card/Card;)Z",4098,5,2,new JHandler[]{},M10547));
}

internal static JStep M10505(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.ClassObject("forge/game/trigger/TriggerType")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",10);}
case 10:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/TriggerHandler","suppressedModes","Ljava/util/Set;",value);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/TriggerHandler","allSuppressed","Z",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",26);}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/TriggerHandler","activeTriggers","Ljava/util/List;",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",37);}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/TriggerHandler","delayedTriggers","Ljava/util/List;",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=44;continue;}
case 44:{f.StackOp("dup");f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",48);}
case 48:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/TriggerHandler","thisTurnDelayedTriggers","Ljava/util/List;",value);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","create","()Lcom/google/common/collect/ArrayListMultimap;","invokestatic",55);}
case 55:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/TriggerHandler","playerDefinedDelayedTriggers","Lcom/google/common/collect/ListMultimap;",value);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",66);}
case 66:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/TriggerHandler","waitingTriggers","Ljava/util/List;",value);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/TriggerHandler","game","Lforge/game/Game;",value);f.Pc=74;continue;}
case 74:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10506(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","delayedTriggers","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10507(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","delayedTriggers","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10508(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","thisTurnDelayedTriggers","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","delayedTriggers","Ljava/util/List;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10509(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","delayedTriggers","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","thisTurnDelayedTriggers","Ljava/util/List;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/List","removeAll","(Ljava/util/Collection;)Z","invokeinterface",13);}
case 13:{f.StackOp("pop");f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","thisTurnDelayedTriggers","Ljava/util/List;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",23);}
case 23:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10510(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","delayedTriggers","Ljava/util/List;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",18);}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?66:28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{f.Locals[4]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",44);}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?63:51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","delayedTriggers","Ljava/util/List;"));f.Pc=55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",62);}
case 62:{f.StackOp("pop");f.Pc=63;continue;}
case 63:{f.Pc=19;continue;}
case 66:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10511(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","playerDefinedDelayedTriggers","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"com/google/common/collect/ListMultimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",11);}
case 11:{f.StackOp("pop");f.Pc=12;continue;}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10512(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","playerDefinedDelayedTriggers","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/ListMultimap","clear","()V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10513(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","playerDefinedDelayedTriggers","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/ListMultimap","removeAll","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",17);}
case 17:{f.Push(JValue.R(rt.String("ThisTurn")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/CardTraitPredicates","hasParam","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",22);}
case 22:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",27);}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","thisTurnDelayedTriggers","Ljava/util/List;"));f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{return rt.DynamicCall(f,"forge/game/trigger/TriggerHandler:10513:36:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/List;)Ljava/util/function/Consumer;",41);}
case 41:{return rt.Call(f,"java/util/stream/Stream","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",46);}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","delayedTriggers","Ljava/util/List;"));f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",56);}
case 56:{f.StackOp("pop");f.Pc=57;continue;}
case 57:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10514(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","suppressedModes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10515(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/TriggerHandler","allSuppressed","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10516(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","suppressedModes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Set","remove","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10517(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","allSuppressed","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?20:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","suppressedModes","Ljava/util/Set;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int==0?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10518(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/trigger/Trigger;","invokestatic",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10519(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseParams","(Ljava/lang/String;)Ljava/util/Map;","invokestatic",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[4]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/util/Map;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/trigger/Trigger;","invokestatic",14);}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Locals[4]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("TriggerHandler:parseTrigger failed to parse")));f.Pc=19;continue;}
case 19:{f.Locals[5]=f.Pop();f.Pc=21;continue;}
case 21:{if(!rt.EnsureInitialized(f,"io/sentry/Breadcrumb"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("io/sentry/Breadcrumb")));f.Pc=24;continue;}
case 24:{f.StackOp("dup");f.Pc=25;continue;}
case 25:{f.Push(f.Locals[5]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"io/sentry/Breadcrumb","<init>","(Ljava/lang/String;)V","invokespecial",30);}
case 30:{f.Locals[6]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[6]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("Card")));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",40);}
case 40:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",43);}
case 43:{f.Push(f.Locals[6]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("Trigger")));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",51);}
case 51:{f.Push(f.Locals[6]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"io/sentry/Sentry","addBreadcrumb","(Lio/sentry/Breadcrumb;)V","invokestatic",56);}
case 56:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=59;continue;}
case 59:{f.StackOp("dup");f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",64);}
case 64:{return rt.DynamicCall(f,"forge/game/trigger/TriggerHandler:10519:64:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",69);}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;Ljava/lang/Throwable;)V","invokespecial",74);}
case 74:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10520(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Mode")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",8);}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/trigger/TriggerType","smartValueOf","(Ljava/lang/String;)Lforge/game/trigger/TriggerType;","invokestatic",14);}
case 14:{f.Locals[5]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[5]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/trigger/TriggerType","createTrigger","(Ljava/util/Map;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokevirtual",24);}
case 24:{f.Locals[4]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Pc=f.Pop().Reference==null?75:30;continue;}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/trigger/Trigger","ensureAbility","(Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;","invokevirtual",36);}
case 36:{f.StackOp("pop");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/CardState")?1:0));f.Pc=41;continue;}
case 41:{f.Pc=f.Pop().Int==0?56:44;continue;}
case 44:{f.Push(f.Locals[4]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardState"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/trigger/Trigger","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",53);}
case 53:{f.Pc=75;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/CardTraitBase")?1:0));f.Pc=60;continue;}
case 60:{f.Pc=f.Pop().Int==0?75:63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/CardTraitBase"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/CardTraitBase","getCardState","()Lforge/game/card/CardState;","invokevirtual",72);}
case 72:{return rt.Call(f,"forge/game/trigger/Trigger","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",75);}
case 75:{f.Pc=141;continue;}
case 78:{f.Locals[5]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("TriggerHandler:parseTrigger failed to parse")));f.Pc=82;continue;}
case 82:{f.Locals[6]=f.Pop();f.Pc=84;continue;}
case 84:{if(!rt.EnsureInitialized(f,"io/sentry/Breadcrumb"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("io/sentry/Breadcrumb")));f.Pc=87;continue;}
case 87:{f.StackOp("dup");f.Pc=88;continue;}
case 88:{f.Push(f.Locals[6]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"io/sentry/Breadcrumb","<init>","(Ljava/lang/String;)V","invokespecial",93);}
case 93:{f.Locals[7]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[7]);f.Pc=97;continue;}
case 97:{f.Push(JValue.R(rt.String("Card")));f.Pc=99;continue;}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",103);}
case 103:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",106);}
case 106:{f.Push(f.Locals[7]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("Params")));f.Pc=110;continue;}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",114);}
case 114:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",117);}
case 117:{f.Push(f.Locals[7]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"io/sentry/Sentry","addBreadcrumb","(Lio/sentry/Breadcrumb;)V","invokestatic",122);}
case 122:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=125;continue;}
case 125:{f.StackOp("dup");f.Pc=126;continue;}
case 126:{f.Push(f.Locals[1]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",130);}
case 130:{return rt.DynamicCall(f,"forge/game/trigger/TriggerHandler:10520:130:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",135);}
case 135:{f.Push(f.Locals[5]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;Ljava/lang/Throwable;)V","invokespecial",140);}
case 140:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 141:{f.Push(f.Locals[4]);f.Pc=143;continue;}
case 143:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10521(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?17:7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("TriggerFactory : registerTrigger -- trigParse too short")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",16);}
case 16:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/util/FileSection","DOLLAR_SIGN_KV_SEPARATOR","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/FileSection","DOLLAR_SIGN_KV_SEPARATOR","Ljava/util/regex/Pattern;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/util/FileSection","parseToMap","(Ljava/lang/String;Ljava/util/regex/Pattern;)Ljava/util/Map;","invokestatic",24);}
case 24:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10522(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/trigger/TriggerHandler","collectTriggerForWaiting","(Z)V","invokevirtual",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10523(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","waitingTriggers","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?162:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/TriggerWaiting"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","getTriggers","()Ljava/lang/Iterable;","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Reference==null?39:36;continue;}
case 36:{f.Pc=10;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Pc=f.Pop().Int==0?80:43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",47);}
case 47:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"));f.Pc=50;continue;}
case 50:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?80:53;continue;}
case 53:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/zone/ZoneType","name","()Ljava/lang/String;","invokevirtual",59);}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","getParams","()Ljava/util/Map;","invokevirtual",63);}
case 63:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"));f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",71);}
case 71:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int==0?80:77;continue;}
case 77:{f.Pc=10;continue;}
case 80:{f.Push(f.Locals[3]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[3]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/trigger/TriggerHandler","getActiveTrigger","(Lforge/game/trigger/TriggerWaiting;)Ljava/util/List;","invokevirtual",86);}
case 86:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","setTriggers","(Ljava/util/List;)V","invokevirtual",89);}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","getTriggers","()Ljava/lang/Iterable;","invokevirtual",93);}
case 93:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",98);}
case 98:{f.Locals[4]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[4]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",107);}
case 107:{f.Pc=f.Pop().Int==0?159:110;continue;}
case 110:{f.Push(f.Locals[4]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",117);}
case 117:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=120;continue;}
case 120:{f.Locals[5]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[3]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[5]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","getTriggeringObjects","(Lforge/game/trigger/Trigger;)Ljava/util/Map;","invokevirtual",128);}
case 128:{f.StackOp("pop");f.Pc=129;continue;}
case 129:{f.Push(f.Locals[5]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/trigger/Trigger","isStatic","()Z","invokevirtual",134);}
case 134:{f.Pc=f.Pop().Int!=0?156:137;continue;}
case 137:{f.Push(f.Locals[3]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[5]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[0]);f.Pc=141;continue;}
case 141:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","game","Lforge/game/Game;"));f.Pc=144;continue;}
case 144:{f.Push(f.Locals[5]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[3]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","getParams","()Ljava/util/Map;","invokevirtual",150);}
case 150:{return rt.Call(f,"forge/game/staticability/StaticAbilityPanharmonicon","countPanharmonicon","(Lforge/game/Game;Lforge/game/trigger/Trigger;Ljava/util/Map;)I","invokestatic",153);}
case 153:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","setAdditionalTriggers","(Lforge/game/trigger/Trigger;I)V","invokevirtual",156);}
case 156:{f.Pc=100;continue;}
case 159:{f.Pc=10;continue;}
case 162:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10524(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/trigger/TriggerHandler","resetActiveTriggers","(ZLforge/game/card/CardCollectionView;)V","invokevirtual",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10525(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int==0?8:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/trigger/TriggerHandler","collectTriggerForWaiting","()V","invokevirtual",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","activeTriggers","Ljava/util/List;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",17);}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","game","Lforge/game/Game;"));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.DynamicCall(f,"forge/game/trigger/TriggerHandler:10525:23:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/trigger/TriggerHandler;Lforge/game/card/CardCollectionView;)Lforge/util/Visitor;",28);}
case 28:{return rt.Call(f,"forge/game/Game","forEachCardInGame","(Lforge/util/Visitor;)V","invokevirtual",31);}
case 31:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10526(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","activeTriggers","Ljava/util/List;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",13);}
case 13:{f.Locals[4]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?87:25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",32);}
case 32:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=35;continue;}
case 35:{f.Locals[5]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",41);}
case 41:{f.Push(f.Locals[5]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",46);}
case 46:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",49);}
case 49:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?84:52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/card/Card","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",56);}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/util/collect/FCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",63);}
case 63:{f.Pc=f.Pop().Int==0?75:66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/trigger/Trigger","zonesCheck","(Lforge/game/zone/Zone;)Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int!=0?84:75;continue;}
case 75:{f.Push(f.Locals[3]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[5]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",83);}
case 83:{f.StackOp("pop");f.Pc=84;continue;}
case 84:{f.Pc=15;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","activeTriggers","Ljava/util/List;"));f.Pc=91;continue;}
case 91:{f.Push(f.Locals[3]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/List","removeAll","(Ljava/util/Collection;)Z","invokeinterface",97);}
case 97:{f.StackOp("pop");f.Pc=98;continue;}
case 98:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10527(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?73:19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Pc=f.Pop().Int==0?63:34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/card/Card","isCloned","()Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int!=0?63:41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/trigger/Trigger","isIntrinsic","()Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?63:49;continue;}
case 49:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Always","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Always","Lforge/game/trigger/TriggerType;"));f.Pc=52;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",57);}
case 57:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int==0?70:63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerOneTrigger","(Lforge/game/trigger/Trigger;)Z","invokevirtual",69);}
case 69:{f.StackOp("pop");f.Pc=70;continue;}
case 70:{f.Pc=10;continue;}
case 73:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10528(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?45:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/trigger/Trigger","looksBackInTime","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?42:36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerOneTrigger","(Lforge/game/trigger/Trigger;)Z","invokevirtual",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{f.Pc=10;continue;}
case 45:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10529(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/trigger/TriggerHandler","isTriggerActive","(Lforge/game/trigger/Trigger;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int==0?21:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","activeTriggers","Ljava/util/List;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",18);}
case 18:{f.StackOp("pop");f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10530(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/trigger/TriggerHandler","isTriggerSuppressed","(Lforge/game/trigger/TriggerType;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int==0?9:8;continue;}
case 8:{return JStep.ReturnVoid;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","waitingTriggers","Ljava/util/List;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",18);}
case 18:{f.Push(JValue.I(9999));f.Pc=21;continue;}
case 21:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?28:24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Pc=29;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{f.Locals[4]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Always","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Always","Lforge/game/trigger/TriggerType;"));f.Pc=35;continue;}
case 35:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?46:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runStateTrigger","(Ljava/util/Map;)V","invokevirtual",43);}
case 43:{f.Pc=118;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{f.Pc=f.Pop().Int==0?104:51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","game","Lforge/game/Game;"));f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",58);}
case 58:{return rt.Call(f,"forge/game/zone/MagicStack","isFrozen","()Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int!=0?68:64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{f.Pc=f.Pop().Int==0?104:68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","TapsForMana","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","TapsForMana","Lforge/game/trigger/TriggerType;"));f.Pc=72;continue;}
case 72:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?104:75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ManaAdded","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ManaAdded","Lforge/game/trigger/TriggerType;"));f.Pc=79;continue;}
case 79:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?104:82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","waitingTriggers","Ljava/util/List;"));f.Pc=86;continue;}
case 86:{if(!rt.EnsureInitialized(f,"forge/game/trigger/TriggerWaiting"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/trigger/TriggerWaiting")));f.Pc=89;continue;}
case 89:{f.StackOp("dup");f.Pc=90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","<init>","(Lforge/game/trigger/TriggerType;Ljava/util/Map;)V","invokespecial",95);}
case 95:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",100);}
case 100:{f.StackOp("pop");f.Pc=101;continue;}
case 101:{f.Pc=118;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{if(!rt.EnsureInitialized(f,"forge/game/trigger/TriggerWaiting"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/trigger/TriggerWaiting")));f.Pc=108;continue;}
case 108:{f.StackOp("dup");f.Pc=109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[2]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","<init>","(Lforge/game/trigger/TriggerType;Ljava/util/Map;)V","invokespecial",114);}
case 114:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runWaitingTrigger","(Lforge/game/trigger/TriggerWaiting;)Z","invokevirtual",117);}
case 117:{f.StackOp("pop");f.Pc=118;continue;}
case 118:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10531(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/trigger/TriggerWaiting"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/trigger/TriggerWaiting")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Always","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Always","Lforge/game/trigger/TriggerType;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","<init>","(Lforge/game/trigger/TriggerType;Ljava/util/Map;)V","invokespecial",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","activeTriggers","Ljava/util/List;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",19);}
case 19:{return rt.Call(f,"java/util/ArrayList","iterator","()Ljava/util/Iterator;","invokevirtual",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?64:32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[4]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[4]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/trigger/TriggerHandler","canRunTrigger","(Lforge/game/trigger/Trigger;Lforge/game/trigger/TriggerWaiting;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?61:53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{f.Push(JValue.R(null));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runSingleTrigger","(Lforge/game/trigger/Trigger;Lforge/game/trigger/TriggerWaiting;Lforge/game/player/Player;)V","invokevirtual",61);}
case 61:{f.Pc=23;continue;}
case 64:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10532(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","waitingTriggers","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int==0?14:12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 14:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","waitingTriggers","Ljava/util/List;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",25);}
case 25:{f.Locals[1]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","waitingTriggers","Ljava/util/List;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",35);}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{f.Locals[2]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",43);}
case 43:{f.Locals[3]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",50);}
case 50:{f.Pc=f.Pop().Int==0?76:53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",59);}
case 59:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/TriggerWaiting"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=62;continue;}
case 62:{f.Locals[4]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runWaitingTrigger","(Lforge/game/trigger/TriggerWaiting;)Z","invokevirtual",71);}
case 71:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=72;continue;}
case 72:{f.Locals[2]=f.Pop();f.Pc=73;continue;}
case 73:{f.Pc=44;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10533(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference!=null?17:15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","getParams","()Ljava/util/Map;","invokevirtual",21);}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","delayedTriggers","Ljava/util/List;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",33);}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{f.Locals[5]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","activeTriggers","Ljava/util/List;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",45);}
case 45:{return rt.Call(f,"java/util/ArrayList","iterator","()Ljava/util/Iterator;","invokevirtual",48);}
case 48:{f.Locals[6]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[6]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",57);}
case 57:{f.Pc=f.Pop().Int==0?134:60;continue;}
case 60:{f.Push(f.Locals[6]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",67);}
case 67:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=70;continue;}
case 70:{f.Locals[7]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[7]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/trigger/Trigger","isStatic","()Z","invokevirtual",77);}
case 77:{f.Pc=f.Pop().Int==0?131:80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[7]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/trigger/TriggerHandler","canRunTrigger","(Lforge/game/trigger/Trigger;Lforge/game/trigger/TriggerWaiting;)Z","invokevirtual",87);}
case 87:{f.Pc=f.Pop().Int==0?131:90;continue;}
case 90:{f.Push(JValue.I(1));f.Pc=91;continue;}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","game","Lforge/game/Game;"));f.Pc=95;continue;}
case 95:{f.Push(f.Locals[7]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/staticability/StaticAbilityPanharmonicon","handlePanharmonicon","(Lforge/game/Game;Lforge/game/trigger/Trigger;Ljava/util/Map;)I","invokestatic",101);}
case 101:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=102;continue;}
case 102:{f.Locals[8]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(JValue.I(0));f.Pc=105;continue;}
case 105:{f.Locals[9]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[9]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[8]);f.Pc=111;continue;}
case 111:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?128:114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[7]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{f.Push(JValue.R(null));f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runSingleTrigger","(Lforge/game/trigger/Trigger;Lforge/game/trigger/TriggerWaiting;Lforge/game/player/Player;)V","invokevirtual",122);}
case 122:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(1)));f.Pc=125;continue;}
case 125:{f.Pc=107;continue;}
case 128:{f.Push(JValue.I(1));f.Pc=129;continue;}
case 129:{f.Locals[5]=f.Pop();f.Pc=131;continue;}
case 131:{f.Pc=50;continue;}
case 134:{f.Push(f.Locals[3]);f.Pc=135;continue;}
case 135:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"));f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",143);}
case 143:{f.Pc=f.Pop().Int==0?223:146;continue;}
case 146:{f.Push(f.Locals[3]);f.Pc=147;continue;}
case 147:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"));f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",155);}
case 155:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/lang/String")?1:0));f.Pc=158;continue;}
case 158:{f.Pc=f.Pop().Int==0?191:161;continue;}
case 161:{f.Push(f.Locals[3]);f.Pc=162;continue;}
case 162:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"));f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",170);}
case 170:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=173;continue;}
case 173:{f.Locals[6]=f.Pop();f.Pc=175;continue;}
case 175:{f.Push(f.Locals[5]);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[6]);f.Pc=179;continue;}
case 179:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",185);}
case 185:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=186;continue;}
case 186:{f.Locals[5]=f.Pop();f.Pc=188;continue;}
case 188:{f.Pc=223;continue;}
case 191:{f.Push(f.Locals[3]);f.Pc=192;continue;}
case 192:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"));f.Pc=195;continue;}
case 195:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",200);}
case 200:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=203;continue;}
case 203:{f.Locals[6]=f.Pop();f.Pc=205;continue;}
case 205:{f.Push(f.Locals[6]);f.Pc=207;continue;}
case 207:{f.Pc=f.Pop().Reference==null?223:210;continue;}
case 210:{f.Push(f.Locals[5]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[6]);f.Pc=214;continue;}
case 214:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",220);}
case 220:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=221;continue;}
case 221:{f.Locals[5]=f.Pop();f.Pc=223;continue;}
case 223:{f.Push(f.Locals[1]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","getTriggers","()Ljava/lang/Iterable;","invokevirtual",227);}
case 227:{f.Pc=f.Pop().Reference==null?234:230;continue;}
case 230:{f.Push(JValue.I(1));f.Pc=231;continue;}
case 231:{f.Pc=235;continue;}
case 234:{f.Push(JValue.I(0));f.Pc=235;continue;}
case 235:{f.Locals[6]=f.Pop();f.Pc=237;continue;}
case 237:{f.Push(f.Locals[6]);f.Pc=239;continue;}
case 239:{f.Pc=f.Pop().Int==0?249:242;continue;}
case 242:{f.Push(f.Locals[1]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","getTriggers","()Ljava/lang/Iterable;","invokevirtual",246);}
case 246:{f.Pc=253;continue;}
case 249:{f.Push(f.Locals[0]);f.Pc=250;continue;}
case 250:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","activeTriggers","Ljava/util/List;"));f.Pc=253;continue;}
case 253:{f.Locals[7]=f.Pop();f.Pc=255;continue;}
case 255:{f.Push(f.Locals[7]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",262);}
case 262:{f.Locals[8]=f.Pop();f.Pc=264;continue;}
case 264:{f.Push(f.Locals[8]);f.Pc=266;continue;}
case 266:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",271);}
case 271:{f.Pc=f.Pop().Int==0?381:274;continue;}
case 274:{f.Push(f.Locals[8]);f.Pc=276;continue;}
case 276:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",281);}
case 281:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=284;continue;}
case 284:{f.Locals[9]=f.Pop();f.Pc=286;continue;}
case 286:{f.Push(f.Locals[9]);f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/game/trigger/Trigger","isStatic","()Z","invokevirtual",291);}
case 291:{f.Pc=f.Pop().Int!=0?378:294;continue;}
case 294:{f.Push(f.Locals[6]);f.Pc=296;continue;}
case 296:{f.Pc=f.Pop().Int!=0?309:299;continue;}
case 299:{f.Push(f.Locals[0]);f.Pc=300;continue;}
case 300:{f.Push(f.Locals[9]);f.Pc=302;continue;}
case 302:{f.Push(f.Locals[1]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/game/trigger/TriggerHandler","canRunTrigger","(Lforge/game/trigger/Trigger;Lforge/game/trigger/TriggerWaiting;)Z","invokevirtual",306);}
case 306:{f.Pc=f.Pop().Int==0?378:309;continue;}
case 309:{f.Push(f.Locals[6]);f.Pc=311;continue;}
case 311:{f.Pc=f.Pop().Int==0?323:314;continue;}
case 314:{f.Push(f.Locals[1]);f.Pc=315;continue;}
case 315:{f.Push(f.Locals[9]);f.Pc=317;continue;}
case 317:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","getAdditionalTriggers","(Lforge/game/trigger/Trigger;)I","invokevirtual",320);}
case 320:{f.Pc=333;continue;}
case 323:{f.Push(f.Locals[0]);f.Pc=324;continue;}
case 324:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","game","Lforge/game/Game;"));f.Pc=327;continue;}
case 327:{f.Push(f.Locals[9]);f.Pc=329;continue;}
case 329:{f.Push(f.Locals[3]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/staticability/StaticAbilityPanharmonicon","countPanharmonicon","(Lforge/game/Game;Lforge/game/trigger/Trigger;Ljava/util/Map;)I","invokestatic",333);}
case 333:{f.Locals[10]=f.Pop();f.Pc=335;continue;}
case 335:{f.Push(f.Locals[9]);f.Pc=337;continue;}
case 337:{f.Push(JValue.I(1));f.Pc=338;continue;}
case 338:{f.Push(f.Locals[10]);f.Pc=340;continue;}
case 340:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=341;continue;}
case 341:{return rt.Call(f,"forge/game/trigger/Trigger","limitByActivations","(I)I","invokevirtual",344);}
case 344:{f.Locals[11]=f.Pop();f.Pc=346;continue;}
case 346:{f.Push(JValue.I(0));f.Pc=347;continue;}
case 347:{f.Locals[12]=f.Pop();f.Pc=349;continue;}
case 349:{f.Push(f.Locals[12]);f.Pc=351;continue;}
case 351:{f.Push(f.Locals[11]);f.Pc=353;continue;}
case 353:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?375:356;continue;}
case 356:{f.Push(f.Locals[0]);f.Pc=357;continue;}
case 357:{f.Push(f.Locals[9]);f.Pc=359;continue;}
case 359:{f.Push(f.Locals[1]);f.Pc=360;continue;}
case 360:{f.Push(f.Locals[1]);f.Pc=361;continue;}
case 361:{f.Push(f.Locals[9]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","getController","(Lforge/game/trigger/Trigger;)Lforge/game/player/Player;","invokevirtual",366);}
case 366:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runSingleTrigger","(Lforge/game/trigger/Trigger;Lforge/game/trigger/TriggerWaiting;Lforge/game/player/Player;)V","invokevirtual",369);}
case 369:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=372;continue;}
case 372:{f.Pc=349;continue;}
case 375:{f.Push(JValue.I(1));f.Pc=376;continue;}
case 376:{f.Locals[5]=f.Pop();f.Pc=378;continue;}
case 378:{f.Pc=264;continue;}
case 381:{f.Push(f.Locals[4]);f.Pc=383;continue;}
case 383:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",388);}
case 388:{f.Locals[8]=f.Pop();f.Pc=390;continue;}
case 390:{f.Push(f.Locals[8]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",397);}
case 397:{f.Pc=f.Pop().Int==0?454:400;continue;}
case 400:{f.Push(f.Locals[8]);f.Pc=402;continue;}
case 402:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",407);}
case 407:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=410;continue;}
case 410:{f.Locals[9]=f.Pop();f.Pc=412;continue;}
case 412:{f.Push(f.Locals[0]);f.Pc=413;continue;}
case 413:{f.Push(f.Locals[9]);f.Pc=415;continue;}
case 415:{return rt.Call(f,"forge/game/trigger/TriggerHandler","isTriggerActive","(Lforge/game/trigger/Trigger;)Z","invokevirtual",418);}
case 418:{f.Pc=f.Pop().Int==0?451:421;continue;}
case 421:{f.Push(f.Locals[0]);f.Pc=422;continue;}
case 422:{f.Push(f.Locals[9]);f.Pc=424;continue;}
case 424:{f.Push(f.Locals[1]);f.Pc=425;continue;}
case 425:{return rt.Call(f,"forge/game/trigger/TriggerHandler","canRunTrigger","(Lforge/game/trigger/Trigger;Lforge/game/trigger/TriggerWaiting;)Z","invokevirtual",428);}
case 428:{f.Pc=f.Pop().Int==0?451:431;continue;}
case 431:{f.Push(f.Locals[0]);f.Pc=432;continue;}
case 432:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","delayedTriggers","Ljava/util/List;"));f.Pc=435;continue;}
case 435:{f.Push(f.Locals[9]);f.Pc=437;continue;}
case 437:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",442);}
case 442:{f.StackOp("pop");f.Pc=443;continue;}
case 443:{f.Push(f.Locals[0]);f.Pc=444;continue;}
case 444:{f.Push(f.Locals[9]);f.Pc=446;continue;}
case 446:{f.Push(f.Locals[1]);f.Pc=447;continue;}
case 447:{f.Push(JValue.R(null));f.Pc=448;continue;}
case 448:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runSingleTrigger","(Lforge/game/trigger/Trigger;Lforge/game/trigger/TriggerWaiting;Lforge/game/player/Player;)V","invokevirtual",451);}
case 451:{f.Pc=390;continue;}
case 454:{f.Push(f.Locals[5]);f.Pc=456;continue;}
case 456:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10534(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","waitingTriggers","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10535(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int<0?41:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","waitingTriggers","Ljava/util/List;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",14);}
case 14:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?41:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","waitingTriggers","Ljava/util/List;"));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","waitingTriggers","Ljava/util/List;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",31);}
case 31:{return rt.Call(f,"java/util/List","subList","(II)Ljava/util/List;","invokeinterface",36);}
case 36:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",41);}
case 41:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10536(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","waitingTriggers","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10537(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","game","Lforge/game/Game;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/trigger/Trigger","phasesCheck","(Lforge/game/Game;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int!=0?13:11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/trigger/Trigger","isSuppressed","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?22:20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 22:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Always","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Always","Lforge/game/trigger/TriggerType;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int==0?54:35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","game","Lforge/game/Game;"));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",42);}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/trigger/Trigger","getId","()I","invokevirtual",46);}
case 46:{return rt.Call(f,"forge/game/zone/MagicStack","hasStateTrigger","(I)Z","invokevirtual",49);}
case 49:{f.Pc=f.Pop().Int==0?54:52;continue;}
case 52:{f.Push(JValue.I(0));f.Pc=53;continue;}
case 53:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/trigger/Trigger","getSpawningAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Reference!=null?81:61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","game","Lforge/game/Game;"));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",70);}
case 70:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",73);}
case 73:{return rt.Call(f,"forge/game/trigger/Trigger","zonesCheck","(Lforge/game/zone/Zone;)Z","invokevirtual",76);}
case 76:{f.Pc=f.Pop().Int!=0?81:79;continue;}
case 79:{f.Push(JValue.I(0));f.Pc=80;continue;}
case 80:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","activeTriggers","Ljava/util/List;"));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",90);}
case 90:{f.Locals[2]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",97);}
case 97:{f.Pc=f.Pop().Int==0?126:100;continue;}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",106);}
case 106:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=109;continue;}
case 109:{f.Locals[3]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[1]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/trigger/Trigger","getId","()I","invokevirtual",114);}
case 114:{f.Push(f.Locals[3]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/trigger/Trigger","getId","()I","invokevirtual",118);}
case 118:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?123:121;continue;}
case 121:{f.Push(JValue.I(0));f.Pc=122;continue;}
case 122:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 123:{f.Pc=91;continue;}
case 126:{f.Push(JValue.I(1));f.Pc=127;continue;}
case 127:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10538(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",4);}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",8);}
case 8:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?13:11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","getParams","()Ljava/util/Map;","invokevirtual",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/trigger/Trigger","isSuppressed","()Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?27:25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/trigger/Trigger","limitByActivations","(I)I","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int!=0?37:35;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{return rt.DynamicCall(f,"forge/game/trigger/TriggerHandler:10538:42:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/trigger/TriggerHandler;Lforge/game/trigger/Trigger;Ljava/util/Map;)Ljava/util/function/BooleanSupplier;",47);}
case 47:{return rt.Call(f,"forge/game/trigger/Trigger","checkWith","(Lforge/game/trigger/TriggerWaiting;Ljava/util/function/BooleanSupplier;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int!=0?55:53;continue;}
case 53:{f.Push(JValue.I(0));f.Pc=54;continue;}
case 54:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 55:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Always","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Always","Lforge/game/trigger/TriggerType;"));f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",62);}
case 62:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?87:68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","game","Lforge/game/Game;"));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",75);}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/trigger/Trigger","getId","()I","invokevirtual",79);}
case 79:{return rt.Call(f,"forge/game/zone/MagicStack","hasStateTrigger","(I)Z","invokevirtual",82);}
case 82:{f.Pc=f.Pop().Int==0?87:85;continue;}
case 85:{f.Push(JValue.I(0));f.Pc=86;continue;}
case 86:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/trigger/Trigger","isStatic","()Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int!=0?108:94;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","game","Lforge/game/Game;"));f.Pc=98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[3]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/staticability/StaticAbilityDisableTriggers","disabled","(Lforge/game/Game;Lforge/game/trigger/Trigger;Ljava/util/Map;)Z","invokestatic",103);}
case 103:{f.Pc=f.Pop().Int==0?108:106;continue;}
case 106:{f.Push(JValue.I(0));f.Pc=107;continue;}
case 107:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 108:{f.Push(JValue.I(1));f.Pc=109;continue;}
case 109:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10539(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?12:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","getParams","()Ljava/util/Map;","invokevirtual",16);}
case 16:{f.Locals[4]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","MergedCards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","MergedCards","Lforge/game/ability/AbilityKey;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Reference==null?191:31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Locals[5]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","MergedCards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","MergedCards","Lforge/game/ability/AbilityKey;"));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",56);}
case 56:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=59;continue;}
case 59:{f.Locals[6]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[6]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[6]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[5]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/card/CardCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",70);}
case 70:{f.Push(f.Locals[5]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/card/CardCollection","set","(ILjava/lang/Object;)Ljava/lang/Object;","invokevirtual",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","(Ljava/util/Map;)Ljava/util/EnumMap;","invokestatic",81);}
case 81:{f.Locals[7]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String("Origin")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",93);}
case 93:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Int==0?129:99;continue;}
case 99:{f.Push(f.Locals[7]);f.Pc=101;continue;}
case 101:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=104;continue;}
case 104:{f.Push(f.Locals[6]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",111);}
case 111:{f.StackOp("pop");f.Pc=112;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[7]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[7]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/trigger/Trigger","buildTriggeringObjects","(Ljava/util/Map;)Ljava/util/Map;","invokevirtual",122);}
case 122:{f.Push(f.Locals[3]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runSingleTriggerInternal","(Lforge/game/trigger/Trigger;Ljava/util/Map;Ljava/util/Map;Lforge/game/player/Player;)V","invokevirtual",126);}
case 126:{f.Pc=188;continue;}
case 129:{f.Push(f.Locals[6]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",134);}
case 134:{f.Locals[8]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[8]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",143);}
case 143:{f.Pc=f.Pop().Int==0?188:146;continue;}
case 146:{f.Push(f.Locals[8]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",153);}
case 153:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=156;continue;}
case 156:{f.Locals[9]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[7]);f.Pc=160;continue;}
case 160:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=163;continue;}
case 163:{f.Push(f.Locals[9]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",170);}
case 170:{f.StackOp("pop");f.Pc=171;continue;}
case 171:{f.Push(f.Locals[0]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[1]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[7]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[1]);f.Pc=176;continue;}
case 176:{f.Push(f.Locals[7]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/trigger/Trigger","buildTriggeringObjects","(Ljava/util/Map;)Ljava/util/Map;","invokevirtual",181);}
case 181:{f.Push(f.Locals[3]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runSingleTriggerInternal","(Lforge/game/trigger/Trigger;Ljava/util/Map;Ljava/util/Map;Lforge/game/player/Player;)V","invokevirtual",185);}
case 185:{f.Pc=136;continue;}
case 188:{f.Pc=204;continue;}
case 191:{f.Push(f.Locals[0]);f.Pc=192;continue;}
case 192:{f.Push(f.Locals[1]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[4]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[2]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[1]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","getTriggeringObjects","(Lforge/game/trigger/Trigger;)Ljava/util/Map;","invokevirtual",200);}
case 200:{f.Push(f.Locals[3]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runSingleTriggerInternal","(Lforge/game/trigger/Trigger;Ljava/util/Map;Ljava/util/Map;Lforge/game/player/Player;)V","invokevirtual",204);}
case 204:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10540(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/trigger/TriggerHandler","adjustUndoStack","(Lforge/game/trigger/Trigger;Ljava/util/Map;)V","invokevirtual",6);}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",10);}
case 10:{f.Locals[5]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/trigger/Trigger","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",16);}
case 16:{f.Locals[6]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[6]);f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Reference!=null?139:23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("Execute")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int!=0?47:33;continue;}
case 33:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbility$EmptySa"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbility$EmptySa")));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[5]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility$EmptySa","<init>","(Lforge/game/card/Card;)V","invokespecial",42);}
case 42:{f.Locals[6]=f.Pop();f.Pc=44;continue;}
case 44:{f.Pc=111;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("Execute")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",54);}
case 54:{f.Locals[7]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",61);}
case 61:{f.Push(f.Locals[7]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/card/CardState","hasSVar","(Ljava/lang/String;)Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int!=0?96:69;continue;}
case 69:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=72;continue;}
case 72:{f.Push(f.Locals[5]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",77);}
case 77:{f.Push(f.Locals[7]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[5]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",84);}
case 84:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",87);}
case 87:{return rt.DynamicCall(f,"forge/game/trigger/TriggerHandler:10540:87:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",92);}
case 92:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",95);}
case 95:{return JStep.ReturnVoid;}
case 96:{f.Push(f.Locals[5]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[7]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/card/Card;Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokestatic",103);}
case 103:{f.Locals[6]=f.Pop();f.Pc=105;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[6]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",111);}
case 111:{f.Push(f.Locals[6]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[4]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",118);}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/trigger/Trigger","isIntrinsic","()Z","invokevirtual",122);}
case 122:{f.Pc=f.Pop().Int==0?168:125;continue;}
case 125:{f.Push(f.Locals[6]);f.Pc=127;continue;}
case 127:{f.Push(JValue.I(1));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",131);}
case 131:{f.Push(f.Locals[6]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/spellability/SpellAbility","changeText","()V","invokevirtual",136);}
case 136:{f.Pc=168;continue;}
case 139:{f.Push(f.Locals[1]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/trigger/Trigger","getSpawningAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",143);}
case 143:{f.Pc=f.Pop().Reference==null?155:146;continue;}
case 146:{f.Push(f.Locals[1]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/trigger/Trigger","getSpawningAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",150);}
case 150:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",153);}
case 153:{f.Locals[4]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[6]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[5]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[4]);f.Pc=161;continue;}
case 161:{f.Push(JValue.I(0));f.Pc=162;continue;}
case 162:{f.Push(JValue.I(1));f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Lforge/game/player/Player;ZZ)Lforge/game/spellability/SpellAbility;","invokevirtual",166);}
case 166:{f.Locals[6]=f.Pop();f.Pc=168;continue;}
case 168:{f.Push(f.Locals[6]);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[1]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/spellability/SpellAbility","setTrigger","(Lforge/game/trigger/Trigger;)V","invokevirtual",174);}
case 174:{f.Push(f.Locals[6]);f.Pc=176;continue;}
case 176:{f.Push(f.Locals[3]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/spellability/SpellAbility","setTriggeringObjects","(Ljava/util/Map;)V","invokevirtual",180);}
case 180:{f.Push(f.Locals[1]);f.Pc=181;continue;}
case 181:{f.Push(JValue.R(rt.String("TriggerController")));f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",187);}
case 187:{f.Pc=f.Pop().Int==0?220:190;continue;}
case 190:{f.Push(f.Locals[5]);f.Pc=192;continue;}
case 192:{f.Push(f.Locals[1]);f.Pc=193;continue;}
case 193:{f.Push(JValue.R(rt.String("TriggerController")));f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",199);}
case 199:{f.Push(f.Locals[6]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",204);}
case 204:{f.Push(JValue.I(0));f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",208);}
case 208:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=211;continue;}
case 211:{f.Locals[7]=f.Pop();f.Pc=213;continue;}
case 213:{f.Push(f.Locals[6]);f.Pc=215;continue;}
case 215:{f.Push(f.Locals[7]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",220);}
case 220:{f.Push(f.Locals[6]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",225);}
case 225:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",228);}
case 228:{f.Pc=f.Pop().Int!=0?232:231;continue;}
case 231:{return JStep.ReturnVoid;}
case 232:{f.Push(f.Locals[6]);f.Pc=234;continue;}
case 234:{f.Push(f.Locals[6]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/game/spellability/SpellAbility","toString","()Ljava/lang/String;","invokevirtual",239);}
case 239:{return rt.Call(f,"forge/game/spellability/SpellAbility","setStackDescription","(Ljava/lang/String;)V","invokevirtual",242);}
case 242:{f.Push(JValue.R(null));f.Pc=243;continue;}
case 243:{f.Locals[7]=f.Pop();f.Pc=245;continue;}
case 245:{f.Push(JValue.I(0));f.Pc=246;continue;}
case 246:{f.Locals[8]=f.Pop();f.Pc=248;continue;}
case 248:{f.Push(f.Locals[1]);f.Pc=249;continue;}
case 249:{f.Push(JValue.R(rt.String("OptionalDecider")));f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",255);}
case 255:{f.Pc=f.Pop().Int==0?290:258;continue;}
case 258:{f.Push(f.Locals[6]);f.Pc=260;continue;}
case 260:{f.Push(JValue.I(1));f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/game/spellability/SpellAbility","setOptionalTrigger","(Z)V","invokevirtual",264);}
case 264:{f.Push(f.Locals[5]);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[1]);f.Pc=267;continue;}
case 267:{f.Push(JValue.R(rt.String("OptionalDecider")));f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",273);}
case 273:{f.Push(f.Locals[6]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",278);}
case 278:{f.Push(JValue.I(0));f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",282);}
case 282:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=285;continue;}
case 285:{f.Locals[7]=f.Pop();f.Pc=287;continue;}
case 287:{f.Pc=364;continue;}
case 290:{f.Push(f.Locals[6]);f.Pc=292;continue;}
case 292:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilitySub")?1:0));f.Pc=295;continue;}
case 295:{f.Pc=f.Pop().Int!=0?345:298;continue;}
case 298:{f.Push(f.Locals[6]);f.Pc=300;continue;}
case 300:{f.Push(JValue.R(rt.String("Cost")));f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",306);}
case 306:{f.Pc=f.Pop().Int==0?345:309;continue;}
case 309:{f.Push(f.Locals[6]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",314);}
case 314:{f.Pc=f.Pop().Reference==null?328:317;continue;}
case 317:{f.Push(f.Locals[6]);f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",322);}
case 322:{return rt.Call(f,"forge/game/cost/Cost","isMandatory","()Z","invokevirtual",325);}
case 325:{f.Pc=f.Pop().Int!=0?345:328;continue;}
case 328:{f.Push(f.Locals[6]);f.Pc=330;continue;}
case 330:{f.Push(JValue.R(rt.String("Cost")));f.Pc=333;continue;}
case 333:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",336);}
case 336:{f.Push(JValue.R(rt.String("0")));f.Pc=339;continue;}
case 339:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",342);}
case 342:{f.Pc=f.Pop().Int==0?351:345;continue;}
case 345:{f.Push(JValue.I(1));f.Pc=346;continue;}
case 346:{f.Locals[8]=f.Pop();f.Pc=348;continue;}
case 348:{f.Pc=364;continue;}
case 351:{f.Push(f.Locals[6]);f.Pc=353;continue;}
case 353:{f.Push(JValue.I(1));f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/game/spellability/SpellAbility","setOptionalTrigger","(Z)V","invokevirtual",357);}
case 357:{f.Push(f.Locals[6]);f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",362);}
case 362:{f.Locals[7]=f.Pop();f.Pc=364;continue;}
case 364:{if(!rt.EnsureInitialized(f,"forge/game/trigger/WrappedAbility"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/trigger/WrappedAbility")));f.Pc=367;continue;}
case 367:{f.StackOp("dup");f.Pc=368;continue;}
case 368:{f.Push(f.Locals[1]);f.Pc=369;continue;}
case 369:{f.Push(f.Locals[6]);f.Pc=371;continue;}
case 371:{f.Push(f.Locals[7]);f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/game/trigger/WrappedAbility","<init>","(Lforge/game/trigger/Trigger;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)V","invokespecial",376);}
case 376:{f.Locals[9]=f.Pop();f.Pc=378;continue;}
case 378:{f.Push(f.Locals[1]);f.Pc=379;continue;}
case 379:{return rt.Call(f,"forge/game/trigger/Trigger","isStatic","()Z","invokevirtual",382);}
case 382:{f.Pc=f.Pop().Int==0?444:385;continue;}
case 385:{f.Push(f.Locals[9]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",390);}
case 390:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",393);}
case 393:{f.Push(f.Locals[5]);f.Pc=395;continue;}
case 395:{f.Push(f.Locals[9]);f.Pc=397;continue;}
case 397:{f.Push(f.Locals[8]);f.Pc=399;continue;}
case 399:{return rt.Call(f,"forge/game/player/PlayerController","playTrigger","(Lforge/game/card/Card;Lforge/game/trigger/WrappedAbility;Z)Z","invokevirtual",402);}
case 402:{f.Pc=f.Pop().Int==0?477:405;continue;}
case 405:{f.Push(f.Locals[5]);f.Pc=407;continue;}
case 407:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",410);}
case 410:{f.Locals[10]=f.Pop();f.Pc=412;continue;}
case 412:{f.Push(f.Locals[10]);f.Pc=414;continue;}
case 414:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"));f.Pc=417;continue;}
case 417:{f.Push(f.Locals[6]);f.Pc=419;continue;}
case 419:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",424);}
case 424:{f.StackOp("pop");f.Pc=425;continue;}
case 425:{f.Push(f.Locals[0]);f.Pc=426;continue;}
case 426:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","game","Lforge/game/Game;"));f.Pc=429;continue;}
case 429:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",432);}
case 432:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AbilityResolves","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AbilityResolves","Lforge/game/trigger/TriggerType;"));f.Pc=435;continue;}
case 435:{f.Push(f.Locals[10]);f.Pc=437;continue;}
case 437:{f.Push(JValue.I(0));f.Pc=438;continue;}
case 438:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",441);}
case 441:{f.Pc=477;continue;}
case 444:{f.Push(f.Locals[0]);f.Pc=445;continue;}
case 445:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","game","Lforge/game/Game;"));f.Pc=448;continue;}
case 448:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",451);}
case 451:{f.Push(f.Locals[9]);f.Pc=453;continue;}
case 453:{return rt.Call(f,"forge/game/zone/MagicStack","addSimultaneousStackEntry","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",456);}
case 456:{f.Push(f.Locals[0]);f.Pc=457;continue;}
case 457:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","game","Lforge/game/Game;"));f.Pc=460;continue;}
case 460:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",463);}
case 463:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AbilityTriggered","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AbilityTriggered","Lforge/game/trigger/TriggerType;"));f.Pc=466;continue;}
case 466:{f.Push(f.Locals[1]);f.Pc=467;continue;}
case 467:{f.Push(f.Locals[9]);f.Pc=469;continue;}
case 469:{f.Push(f.Locals[2]);f.Pc=470;continue;}
case 470:{return rt.Call(f,"forge/game/trigger/TriggerAbilityTriggered","getRunParams","(Lforge/game/trigger/Trigger;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Ljava/util/Map;","invokestatic",473);}
case 473:{f.Push(JValue.I(0));f.Pc=474;continue;}
case 474:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",477);}
case 477:{f.Push(f.Locals[1]);f.Pc=478;continue;}
case 478:{return rt.Call(f,"forge/game/trigger/Trigger","triggerRun","()V","invokevirtual",481);}
case 481:{f.Push(f.Locals[5]);f.Pc=483;continue;}
case 483:{return rt.Call(f,"forge/game/card/Card","isBoon","()Z","invokevirtual",486);}
case 486:{f.Locals[10]=f.Pop();f.Pc=488;continue;}
case 488:{f.Push(f.Locals[1]);f.Pc=489;continue;}
case 489:{f.Push(JValue.R(rt.String("BoonAmount")));f.Pc=492;continue;}
case 492:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",495);}
case 495:{f.Pc=f.Pop().Int==0?535:498;continue;}
case 498:{f.Push(f.Locals[5]);f.Pc=500;continue;}
case 500:{f.Push(f.Locals[1]);f.Pc=501;continue;}
case 501:{f.Push(JValue.R(rt.String("BoonAmount")));f.Pc=504;continue;}
case 504:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",507);}
case 507:{f.Push(f.Locals[9]);f.Pc=509;continue;}
case 509:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",512);}
case 512:{f.Locals[11]=f.Pop();f.Pc=514;continue;}
case 514:{f.Push(f.Locals[5]);f.Pc=516;continue;}
case 516:{f.Push(f.Locals[1]);f.Pc=517;continue;}
case 517:{return rt.Call(f,"forge/game/trigger/Trigger","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",520);}
case 520:{return rt.Call(f,"forge/game/card/Card","getAbilityActivatedThisGame","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",523);}
case 523:{f.Locals[12]=f.Pop();f.Pc=525;continue;}
case 525:{f.Push(f.Locals[12]);f.Pc=527;continue;}
case 527:{f.Push(f.Locals[11]);f.Pc=529;continue;}
case 529:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?535:532;continue;}
case 532:{f.Push(JValue.I(0));f.Pc=533;continue;}
case 533:{f.Locals[10]=f.Pop();f.Pc=535;continue;}
case 535:{f.Push(f.Locals[1]);f.Pc=536;continue;}
case 536:{f.Push(JValue.R(rt.String("OneOff")));f.Pc=539;continue;}
case 539:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",542);}
case 542:{f.Pc=f.Pop().Int==0?553:545;continue;}
case 545:{f.Push(f.Locals[5]);f.Pc=547;continue;}
case 547:{return rt.Call(f,"forge/game/card/Card","isImmutable","()Z","invokevirtual",550);}
case 550:{f.Pc=f.Pop().Int!=0?558:553;continue;}
case 553:{f.Push(f.Locals[10]);f.Pc=555;continue;}
case 555:{f.Pc=f.Pop().Int==0?574:558;continue;}
case 558:{f.Push(f.Locals[5]);f.Pc=560;continue;}
case 560:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",563);}
case 563:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=566;continue;}
case 566:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",569);}
case 569:{f.Push(f.Locals[5]);f.Pc=571;continue;}
case 571:{return rt.Call(f,"forge/game/zone/PlayerZone","remove","(Lforge/game/card/Card;)V","invokevirtual",574);}
case 574:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10541(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","TapsForMana","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","TapsForMana","Lforge/game/trigger/TriggerType;"));f.Pc=7;continue;}
case 7:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?20:10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",14);}
case 14:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ManaAdded","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ManaAdded","Lforge/game/trigger/TriggerType;"));f.Pc=17;continue;}
case 17:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?54:20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","AbilityMana","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","AbilityMana","Lforge/game/ability/AbilityKey;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{f.Locals[3]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(JValue.R(null));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?51:38;continue;}
case 38:{f.Push(JValue.R(null));f.Pc=39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/spellability/SpellAbility","getManaPart","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",43);}
case 43:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?51:46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{f.Push(JValue.I(0));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/spellability/SpellAbility","setUndoable","(Z)V","invokevirtual",51);}
case 51:{f.Pc=413;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",58);}
case 58:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AbilityCast","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AbilityCast","Lforge/game/trigger/TriggerType;"));f.Pc=61;continue;}
case 61:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?71:64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/trigger/TriggerAbilityResolves")?1:0));f.Pc=68;continue;}
case 68:{f.Pc=f.Pop().Int==0?105:71;continue;}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",80);}
case 80:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=83;continue;}
case 83:{f.Locals[3]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(JValue.R(null));f.Pc=85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?102:89;continue;}
case 89:{f.Push(JValue.R(null));f.Pc=90;continue;}
case 90:{f.Push(f.Locals[3]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/spellability/SpellAbility","getManaPart","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",94);}
case 94:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?102:97;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{f.Push(JValue.I(0));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/spellability/SpellAbility","setUndoable","(Z)V","invokevirtual",102);}
case 102:{f.Pc=413;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",109);}
case 109:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Taps","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Taps","Lforge/game/trigger/TriggerType;"));f.Pc=112;continue;}
case 112:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?125:115;continue;}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",119);}
case 119:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Untaps","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Untaps","Lforge/game/trigger/TriggerType;"));f.Pc=122;continue;}
case 122:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?190:125;continue;}
case 125:{f.Push(f.Locals[2]);f.Pc=126;continue;}
case 126:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",134);}
case 134:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=137;continue;}
case 137:{f.Locals[3]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","game","Lforge/game/Game;"));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",145);}
case 145:{f.Push(f.Locals[3]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/zone/MagicStack","filterUndoStackByHost","(Lforge/game/card/Card;)Ljava/lang/Iterable;","invokevirtual",149);}
case 149:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",154);}
case 154:{f.Locals[4]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[4]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",163);}
case 163:{f.Pc=f.Pop().Int==0?187:166;continue;}
case 166:{f.Push(f.Locals[4]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",173);}
case 173:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=176;continue;}
case 176:{f.Locals[5]=f.Pop();f.Pc=178;continue;}
case 178:{f.Push(f.Locals[5]);f.Pc=180;continue;}
case 180:{f.Push(JValue.I(0));f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/spellability/SpellAbility","setUndoable","(Z)V","invokevirtual",184);}
case 184:{f.Pc=156;continue;}
case 187:{f.Pc=413;continue;}
case 190:{f.Push(f.Locals[1]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",194);}
case 194:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","TapAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","TapAll","Lforge/game/trigger/TriggerType;"));f.Pc=197;continue;}
case 197:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?299:200;continue;}
case 200:{f.Push(f.Locals[2]);f.Pc=201;continue;}
case 201:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=204;continue;}
case 204:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",209);}
case 209:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=212;continue;}
case 212:{f.Locals[3]=f.Pop();f.Pc=213;continue;}
case 213:{f.Push(f.Locals[3]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",219);}
case 219:{f.Locals[4]=f.Pop();f.Pc=221;continue;}
case 221:{f.Push(f.Locals[4]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",228);}
case 228:{f.Pc=f.Pop().Int==0?296:231;continue;}
case 231:{f.Push(f.Locals[4]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",238);}
case 238:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=241;continue;}
case 241:{f.Locals[5]=f.Pop();f.Pc=243;continue;}
case 243:{f.Push(f.Locals[0]);f.Pc=244;continue;}
case 244:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","game","Lforge/game/Game;"));f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",250);}
case 250:{f.Push(f.Locals[5]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/game/zone/MagicStack","filterUndoStackByHost","(Lforge/game/card/Card;)Ljava/lang/Iterable;","invokevirtual",255);}
case 255:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",260);}
case 260:{f.Locals[6]=f.Pop();f.Pc=262;continue;}
case 262:{f.Push(f.Locals[6]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",269);}
case 269:{f.Pc=f.Pop().Int==0?293:272;continue;}
case 272:{f.Push(f.Locals[6]);f.Pc=274;continue;}
case 274:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",279);}
case 279:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=282;continue;}
case 282:{f.Locals[7]=f.Pop();f.Pc=284;continue;}
case 284:{f.Push(f.Locals[7]);f.Pc=286;continue;}
case 286:{f.Push(JValue.I(0));f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/spellability/SpellAbility","setUndoable","(Z)V","invokevirtual",290);}
case 290:{f.Pc=262;continue;}
case 293:{f.Pc=221;continue;}
case 296:{f.Pc=413;continue;}
case 299:{f.Push(f.Locals[1]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",303);}
case 303:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","UntapAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","UntapAll","Lforge/game/trigger/TriggerType;"));f.Pc=306;continue;}
case 306:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?413:309;continue;}
case 309:{f.Push(f.Locals[2]);f.Pc=310;continue;}
case 310:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"));f.Pc=313;continue;}
case 313:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",318);}
case 318:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=321;continue;}
case 321:{f.Locals[3]=f.Pop();f.Pc=322;continue;}
case 322:{f.Push(f.Locals[3]);f.Pc=323;continue;}
case 323:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",328);}
case 328:{return rt.Call(f,"com/google/common/collect/Iterables","concat","(Ljava/lang/Iterable;)Ljava/lang/Iterable;","invokestatic",331);}
case 331:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",336);}
case 336:{f.Locals[4]=f.Pop();f.Pc=338;continue;}
case 338:{f.Push(f.Locals[4]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",345);}
case 345:{f.Pc=f.Pop().Int==0?413:348;continue;}
case 348:{f.Push(f.Locals[4]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",355);}
case 355:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=358;continue;}
case 358:{f.Locals[5]=f.Pop();f.Pc=360;continue;}
case 360:{f.Push(f.Locals[0]);f.Pc=361;continue;}
case 361:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","game","Lforge/game/Game;"));f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",367);}
case 367:{f.Push(f.Locals[5]);f.Pc=369;continue;}
case 369:{return rt.Call(f,"forge/game/zone/MagicStack","filterUndoStackByHost","(Lforge/game/card/Card;)Ljava/lang/Iterable;","invokevirtual",372);}
case 372:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",377);}
case 377:{f.Locals[6]=f.Pop();f.Pc=379;continue;}
case 379:{f.Push(f.Locals[6]);f.Pc=381;continue;}
case 381:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",386);}
case 386:{f.Pc=f.Pop().Int==0?410:389;continue;}
case 389:{f.Push(f.Locals[6]);f.Pc=391;continue;}
case 391:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",396);}
case 396:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=399;continue;}
case 399:{f.Locals[7]=f.Pop();f.Pc=401;continue;}
case 401:{f.Push(f.Locals[7]);f.Pc=403;continue;}
case 403:{f.Push(JValue.I(0));f.Pc=404;continue;}
case 404:{return rt.Call(f,"forge/game/spellability/SpellAbility","setUndoable","(Z)V","invokevirtual",407);}
case 407:{f.Pc=379;continue;}
case 410:{f.Pc=338;continue;}
case 413:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10542(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.EnsureInitialized(f,"forge/game/trigger/TriggerWaiting"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/trigger/TriggerWaiting")));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","<init>","(Lforge/game/trigger/TriggerType;Ljava/util/Map;)V","invokespecial",10);}
case 10:{return rt.Call(f,"forge/game/trigger/TriggerHandler","getActiveTrigger","(Lforge/game/trigger/TriggerWaiting;)Ljava/util/List;","invokevirtual",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10543(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","activeTriggers","Ljava/util/List;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?56:23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{f.Locals[4]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/trigger/TriggerHandler","canRunTrigger","(Lforge/game/trigger/Trigger;Lforge/game/trigger/TriggerWaiting;)Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int==0?53:44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{f.Pc=14;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10544(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","delayedTriggers","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.DynamicCall(f,"forge/game/trigger/TriggerHandler:10544:5:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/player/Player;)Ljava/util/function/Predicate;",10);}
case 10:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",15);}
case 15:{f.StackOp("pop");f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runWaitingTriggers","()Z","invokevirtual",20);}
case 20:{f.StackOp("pop");f.Pc=21;continue;}
case 21:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10545(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/trigger/Trigger","getSpawningAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10546(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","game","Lforge/game/Game;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/trigger/Trigger","requirementsCheck","(Lforge/game/Game;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?35:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","game","Lforge/game/Game;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/trigger/Trigger","meetsRequirementsOnTriggeredObjects","(Lforge/game/Game;Ljava/util/Map;)Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?35:23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/trigger/Trigger","performTest","(Ljava/util/Map;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?35:31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{f.Pc=36;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10547(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?86:19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?62:37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Pc=f.Pop().Reference==null?62:41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",48);}
case 48:{f.Pc=f.Pop().Int!=0?62:51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/trigger/Trigger","looksBackInTime","()Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?62:59;continue;}
case 59:{f.Pc=10;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/trigger/TriggerHandler","isTriggerActive","(Lforge/game/trigger/Trigger;)Z","invokevirtual",68);}
case 68:{f.Pc=f.Pop().Int==0?83:71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerHandler","activeTriggers","Ljava/util/List;"));f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",82);}
case 82:{f.StackOp("pop");f.Pc=83;continue;}
case 83:{f.Pc=10;continue;}
case 86:{f.Push(JValue.I(1));f.Pc=87;continue;}
case 87:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

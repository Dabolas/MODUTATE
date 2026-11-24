// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C696{
internal static JClass Build(){var c=new JClass("forge/game/phase/Phase","java/lang/Object",new string[]{"java/io/Serializable"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(4665309652476851977L),null));
c.Add(new JField("type","Lforge/game/phase/PhaseType;",false,JValue.Default("Lforge/game/phase/PhaseType;"),null));
c.Add(new JField("at","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("until","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("untilMap","Lcom/google/common/collect/Multimap;",false,JValue.Default("Lcom/google/common/collect/Multimap;"),null));
c.Add(new JField("untilEndMap","Lcom/google/common/collect/Multimap;",false,JValue.Default("Lcom/google/common/collect/Multimap;"),null));
c.Add(new JField("registerMap","Lcom/google/common/collect/Multimap;",false,JValue.Default("Lcom/google/common/collect/Multimap;"),null));
c.Add(new JMethod(7852,"forge/game/phase/Phase","<init>","(Lforge/game/phase/PhaseType;)V",1,2,2,new JHandler[]{},M7852));
c.Add(new JMethod(7853,"forge/game/phase/Phase","clearCommands","()V",1,1,1,new JHandler[]{},M7853));
c.Add(new JMethod(7854,"forge/game/phase/Phase","addAt","(Lforge/GameCommand;)V",17,2,2,new JHandler[]{},M7854));
c.Add(new JMethod(7855,"forge/game/phase/Phase","executeAt","()V",1,1,2,new JHandler[]{},M7855));
c.Add(new JMethod(7856,"forge/game/phase/Phase","addUntil","(Lforge/GameCommand;)V",17,2,2,new JHandler[]{},M7856));
c.Add(new JMethod(7857,"forge/game/phase/Phase","executeUntil","()V",17,1,2,new JHandler[]{},M7857));
c.Add(new JMethod(7858,"forge/game/phase/Phase","addUntil","(Lforge/game/player/Player;Lforge/GameCommand;)V",17,3,3,new JHandler[]{},M7858));
c.Add(new JMethod(7859,"forge/game/phase/Phase","executeUntil","(Lforge/game/player/Player;)V",17,2,3,new JHandler[]{},M7859));
c.Add(new JMethod(7860,"forge/game/phase/Phase","registerUntilEnd","(Lforge/game/player/Player;Lforge/GameCommand;)V",17,3,3,new JHandler[]{},M7860));
c.Add(new JMethod(7861,"forge/game/phase/Phase","addUntilEnd","(Lforge/game/player/Player;Lforge/GameCommand;)V",17,3,3,new JHandler[]{},M7861));
c.Add(new JMethod(7862,"forge/game/phase/Phase","registerUntilEndCommand","(Lforge/game/player/Player;)V",17,2,4,new JHandler[]{},M7862));
c.Add(new JMethod(7863,"forge/game/phase/Phase","executeUntilEndOfPhase","(Lforge/game/player/Player;)V",17,2,3,new JHandler[]{},M7863));
c.Add(new JMethod(7864,"forge/game/phase/Phase","excute","(Ljava/util/Collection;)V",4,3,2,new JHandler[]{},M7864));
}

internal static JStep M7852(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/Phase","at","Ljava/util/List;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",15);}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/Phase","until","Ljava/util/List;",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"com/google/common/collect/MultimapBuilder","hashKeys","()Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys;","invokestatic",22);}
case 22:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys","arrayListValues","()Lcom/google/common/collect/MultimapBuilder$ListMultimapBuilder;","invokevirtual",25);}
case 25:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$ListMultimapBuilder","build","()Lcom/google/common/collect/ListMultimap;","invokevirtual",28);}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/Phase","untilMap","Lcom/google/common/collect/Multimap;",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"com/google/common/collect/MultimapBuilder","hashKeys","()Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys;","invokestatic",35);}
case 35:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys","arrayListValues","()Lcom/google/common/collect/MultimapBuilder$ListMultimapBuilder;","invokevirtual",38);}
case 38:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$ListMultimapBuilder","build","()Lcom/google/common/collect/ListMultimap;","invokevirtual",41);}
case 41:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/Phase","untilEndMap","Lcom/google/common/collect/Multimap;",value);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"com/google/common/collect/MultimapBuilder","hashKeys","()Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys;","invokestatic",48);}
case 48:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys","arrayListValues","()Lcom/google/common/collect/MultimapBuilder$ListMultimapBuilder;","invokevirtual",51);}
case 51:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$ListMultimapBuilder","build","()Lcom/google/common/collect/ListMultimap;","invokevirtual",54);}
case 54:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/Phase","registerMap","Lcom/google/common/collect/Multimap;",value);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/Phase","type","Lforge/game/phase/PhaseType;",value);f.Pc=62;continue;}
case 62:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7853(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Phase","at","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Phase","until","Ljava/util/List;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",18);}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Phase","untilMap","Lcom/google/common/collect/Multimap;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"com/google/common/collect/Multimap","clear","()V","invokeinterface",27);}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Phase","untilEndMap","Lcom/google/common/collect/Multimap;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"com/google/common/collect/Multimap","clear","()V","invokeinterface",36);}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Phase","registerMap","Lcom/google/common/collect/Multimap;"));f.Pc=40;continue;}
case 40:{return rt.Call(f,"com/google/common/collect/Multimap","clear","()V","invokeinterface",45);}
case 45:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7854(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Phase","at","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7855(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Phase","at","Ljava/util/List;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/phase/Phase","excute","(Ljava/util/Collection;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7856(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Phase","until","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7857(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Phase","until","Ljava/util/List;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/phase/Phase","excute","(Ljava/util/Collection;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7858(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Phase","untilMap","Lcom/google/common/collect/Multimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",11);}
case 11:{f.StackOp("pop");f.Pc=12;continue;}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7859(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Phase","untilMap","Lcom/google/common/collect/Multimap;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",11);}
case 11:{return rt.Call(f,"forge/game/phase/Phase","excute","(Ljava/util/Collection;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7860(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Phase","registerMap","Lcom/google/common/collect/Multimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",11);}
case 11:{f.StackOp("pop");f.Pc=12;continue;}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7861(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Phase","untilEndMap","Lcom/google/common/collect/Multimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",11);}
case 11:{f.StackOp("pop");f.Pc=12;continue;}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7862(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Phase","untilEndMap","Lcom/google/common/collect/Multimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Phase","registerMap","Lcom/google/common/collect/Multimap;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",15);}
case 15:{return rt.Call(f,"com/google/common/collect/Multimap","putAll","(Ljava/lang/Object;Ljava/lang/Iterable;)Z","invokeinterface",20);}
case 20:{f.StackOp("pop");f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Phase","registerMap","Lcom/google/common/collect/Multimap;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"com/google/common/collect/Multimap","removeAll","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",31);}
case 31:{f.StackOp("pop");f.Pc=32;continue;}
case 32:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7863(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Phase","untilEndMap","Lcom/google/common/collect/Multimap;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",11);}
case 11:{return rt.Call(f,"forge/game/phase/Phase","excute","(Ljava/util/Collection;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7864(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.DynamicCall(f,"forge/game/phase/Phase:7864:6:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Consumer;",11);}
case 11:{return rt.Call(f,"java/util/List","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",16);}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Collection","removeAll","(Ljava/util/Collection;)Z","invokeinterface",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

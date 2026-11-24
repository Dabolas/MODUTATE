// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C494{
internal static JClass Build(){var c=new JClass("forge/game/card/perpetual/PerpetualKeywords","java/lang/Record",new string[]{"forge/game/card/perpetual/PerpetualInterface"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("timestamp","J",false,JValue.Default("J"),null));
c.Add(new JField("addKeywords","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("removeKeywords","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("removeAll","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(5854,"forge/game/card/perpetual/PerpetualKeywords","<init>","(JLjava/util/List;Ljava/util/List;Z)V",1,6,3,new JHandler[]{},M5854));
c.Add(new JMethod(5855,"forge/game/card/perpetual/PerpetualKeywords","getTimestamp","()J",1,1,2,new JHandler[]{},M5855));
c.Add(new JMethod(5856,"forge/game/card/perpetual/PerpetualKeywords","applyEffect","(Lforge/game/card/Card;)V",1,2,7,new JHandler[]{},M5856));
c.Add(new JMethod(5857,"forge/game/card/perpetual/PerpetualKeywords","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M5857));
c.Add(new JMethod(5858,"forge/game/card/perpetual/PerpetualKeywords","hashCode","()I",17,1,1,new JHandler[]{},M5858));
c.Add(new JMethod(5859,"forge/game/card/perpetual/PerpetualKeywords","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M5859));
c.Add(new JMethod(5860,"forge/game/card/perpetual/PerpetualKeywords","timestamp","()J",1,1,2,new JHandler[]{},M5860));
c.Add(new JMethod(5861,"forge/game/card/perpetual/PerpetualKeywords","addKeywords","()Ljava/util/List;",1,1,1,new JHandler[]{},M5861));
c.Add(new JMethod(5862,"forge/game/card/perpetual/PerpetualKeywords","removeKeywords","()Ljava/util/List;",1,1,1,new JHandler[]{},M5862));
c.Add(new JMethod(5863,"forge/game/card/perpetual/PerpetualKeywords","removeAll","()Z",1,1,1,new JHandler[]{},M5863));
}

internal static JStep M5854(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/perpetual/PerpetualKeywords","timestamp","J",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/perpetual/PerpetualKeywords","addKeywords","Ljava/util/List;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/perpetual/PerpetualKeywords","removeKeywords","Ljava/util/List;",value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[5]);f.Pc=23;continue;}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/perpetual/PerpetualKeywords","removeAll","Z",value);f.Pc=26;continue;}
case 26:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5855(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualKeywords","timestamp","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5856(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualKeywords","addKeywords","Ljava/util/List;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualKeywords","removeKeywords","Ljava/util/List;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualKeywords","removeAll","Z"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualKeywords","timestamp","J"));f.Pc=17;continue;}
case 17:{f.Push(JValue.R(null));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/Card","addChangedCardKeywords","(Ljava/util/List;Ljava/util/List;ZJLforge/game/staticability/StaticAbility;)V","invokevirtual",21);}
case 21:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5857(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/perpetual/PerpetualKeywords:5857:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/perpetual/PerpetualKeywords;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5858(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/perpetual/PerpetualKeywords:5858:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/perpetual/PerpetualKeywords;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5859(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/perpetual/PerpetualKeywords:5859:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/perpetual/PerpetualKeywords;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5860(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualKeywords","timestamp","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5861(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualKeywords","addKeywords","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5862(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualKeywords","removeKeywords","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5863(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualKeywords","removeAll","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

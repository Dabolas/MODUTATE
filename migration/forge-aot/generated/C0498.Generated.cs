// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C498{
internal static JClass Build(){var c=new JClass("forge/game/card/perpetual/PerpetualTypes","java/lang/Record",new string[]{"forge/game/card/perpetual/PerpetualInterface"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("timestamp","J",false,JValue.Default("J"),null));
c.Add(new JField("addTypes","Lforge/card/CardType;",false,JValue.Default("Lforge/card/CardType;"),null));
c.Add(new JField("removeTypes","Lforge/card/CardType;",false,JValue.Default("Lforge/card/CardType;"),null));
c.Add(new JField("removeXTypes","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JMethod(5890,"forge/game/card/perpetual/PerpetualTypes","<init>","(JLforge/card/CardType;Lforge/card/CardType;Ljava/util/Set;)V",1,6,3,new JHandler[]{},M5890));
c.Add(new JMethod(5891,"forge/game/card/perpetual/PerpetualTypes","getTimestamp","()J",1,1,2,new JHandler[]{},M5891));
c.Add(new JMethod(5892,"forge/game/card/perpetual/PerpetualTypes","applyEffect","(Lforge/game/card/Card;)V",1,2,11,new JHandler[]{},M5892));
c.Add(new JMethod(5893,"forge/game/card/perpetual/PerpetualTypes","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M5893));
c.Add(new JMethod(5894,"forge/game/card/perpetual/PerpetualTypes","hashCode","()I",17,1,1,new JHandler[]{},M5894));
c.Add(new JMethod(5895,"forge/game/card/perpetual/PerpetualTypes","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M5895));
c.Add(new JMethod(5896,"forge/game/card/perpetual/PerpetualTypes","timestamp","()J",1,1,2,new JHandler[]{},M5896));
c.Add(new JMethod(5897,"forge/game/card/perpetual/PerpetualTypes","addTypes","()Lforge/card/CardType;",1,1,1,new JHandler[]{},M5897));
c.Add(new JMethod(5898,"forge/game/card/perpetual/PerpetualTypes","removeTypes","()Lforge/card/CardType;",1,1,1,new JHandler[]{},M5898));
c.Add(new JMethod(5899,"forge/game/card/perpetual/PerpetualTypes","removeXTypes","()Ljava/util/Set;",1,1,1,new JHandler[]{},M5899));
}

internal static JStep M5890(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/perpetual/PerpetualTypes","timestamp","J",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/perpetual/PerpetualTypes","addTypes","Lforge/card/CardType;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/perpetual/PerpetualTypes","removeTypes","Lforge/card/CardType;",value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[5]);f.Pc=23;continue;}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/perpetual/PerpetualTypes","removeXTypes","Ljava/util/Set;",value);f.Pc=26;continue;}
case 26:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5891(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualTypes","timestamp","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5892(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualTypes","addTypes","Lforge/card/CardType;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualTypes","removeTypes","Lforge/card/CardType;"));f.Pc=9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualTypes","removeXTypes","Ljava/util/Set;"));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualTypes","timestamp","J"));f.Pc=18;continue;}
case 18:{f.Push(JValue.L(0));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/Card","addChangedCardTypes","(Lforge/card/CardType;Lforge/card/CardType;ZLjava/util/Set;JJZZ)V","invokevirtual",24);}
case 24:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5893(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/perpetual/PerpetualTypes:5893:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/perpetual/PerpetualTypes;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5894(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/perpetual/PerpetualTypes:5894:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/perpetual/PerpetualTypes;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5895(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/perpetual/PerpetualTypes:5895:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/perpetual/PerpetualTypes;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5896(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualTypes","timestamp","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5897(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualTypes","addTypes","Lforge/card/CardType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5898(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualTypes","removeTypes","Lforge/card/CardType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5899(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualTypes","removeXTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

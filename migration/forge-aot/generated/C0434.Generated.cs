// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C434{
internal static JClass Build(){var c=new JClass("forge/game/card/Card$CardColor","java/lang/Record",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("color","Lforge/card/ColorSet;",false,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("additional","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(4851,"forge/game/card/Card$CardColor","<init>","(Lforge/card/ColorSet;Z)V",2,3,2,new JHandler[]{},M4851));
c.Add(new JMethod(4852,"forge/game/card/Card$CardColor","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M4852));
c.Add(new JMethod(4853,"forge/game/card/Card$CardColor","hashCode","()I",17,1,1,new JHandler[]{},M4853));
c.Add(new JMethod(4854,"forge/game/card/Card$CardColor","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M4854));
c.Add(new JMethod(4855,"forge/game/card/Card$CardColor","color","()Lforge/card/ColorSet;",1,1,1,new JHandler[]{},M4855));
c.Add(new JMethod(4856,"forge/game/card/Card$CardColor","additional","()Z",1,1,1,new JHandler[]{},M4856));
}

internal static JStep M4851(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/Card$CardColor","color","Lforge/card/ColorSet;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/Card$CardColor","additional","Z",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4852(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/Card$CardColor:4852:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/Card$CardColor;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4853(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/Card$CardColor:4853:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/Card$CardColor;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4854(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/Card$CardColor:4854:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/Card$CardColor;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4855(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/Card$CardColor","color","Lforge/card/ColorSet;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4856(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/Card$CardColor","additional","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

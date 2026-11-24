// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C435{
internal static JClass Build(){var c=new JClass("forge/game/card/Card$CardManaCost","java/lang/Record",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("mana","Lforge/card/mana/ManaCost;",false,JValue.Default("Lforge/card/mana/ManaCost;"),null));
c.Add(new JField("additional","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(4857,"forge/game/card/Card$CardManaCost","<init>","(Lforge/card/mana/ManaCost;Z)V",2,3,2,new JHandler[]{},M4857));
c.Add(new JMethod(4858,"forge/game/card/Card$CardManaCost","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M4858));
c.Add(new JMethod(4859,"forge/game/card/Card$CardManaCost","hashCode","()I",17,1,1,new JHandler[]{},M4859));
c.Add(new JMethod(4860,"forge/game/card/Card$CardManaCost","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M4860));
c.Add(new JMethod(4861,"forge/game/card/Card$CardManaCost","mana","()Lforge/card/mana/ManaCost;",1,1,1,new JHandler[]{},M4861));
c.Add(new JMethod(4862,"forge/game/card/Card$CardManaCost","additional","()Z",1,1,1,new JHandler[]{},M4862));
}

internal static JStep M4857(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/Card$CardManaCost","mana","Lforge/card/mana/ManaCost;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/Card$CardManaCost","additional","Z",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4858(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/Card$CardManaCost:4858:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/Card$CardManaCost;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4859(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/Card$CardManaCost:4859:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/Card$CardManaCost;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4860(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/Card$CardManaCost:4860:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/Card$CardManaCost;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4861(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/Card$CardManaCost","mana","Lforge/card/mana/ManaCost;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4862(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/Card$CardManaCost","additional","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

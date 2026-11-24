// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C492{
internal static JClass Build(){var c=new JClass("forge/game/card/perpetual/PerpetualIncorporate","java/lang/Record",new string[]{"forge/game/card/perpetual/PerpetualInterface"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("timestamp","J",false,JValue.Default("J"),null));
c.Add(new JField("incorporate","Lforge/card/mana/ManaCost;",false,JValue.Default("Lforge/card/mana/ManaCost;"),null));
c.Add(new JMethod(5844,"forge/game/card/perpetual/PerpetualIncorporate","<init>","(JLforge/card/mana/ManaCost;)V",1,4,3,new JHandler[]{},M5844));
c.Add(new JMethod(5845,"forge/game/card/perpetual/PerpetualIncorporate","getTimestamp","()J",1,1,2,new JHandler[]{},M5845));
c.Add(new JMethod(5846,"forge/game/card/perpetual/PerpetualIncorporate","applyEffect","(Lforge/game/card/Card;)V",1,3,7,new JHandler[]{},M5846));
c.Add(new JMethod(5847,"forge/game/card/perpetual/PerpetualIncorporate","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M5847));
c.Add(new JMethod(5848,"forge/game/card/perpetual/PerpetualIncorporate","hashCode","()I",17,1,1,new JHandler[]{},M5848));
c.Add(new JMethod(5849,"forge/game/card/perpetual/PerpetualIncorporate","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M5849));
c.Add(new JMethod(5850,"forge/game/card/perpetual/PerpetualIncorporate","timestamp","()J",1,1,2,new JHandler[]{},M5850));
c.Add(new JMethod(5851,"forge/game/card/perpetual/PerpetualIncorporate","incorporate","()Lforge/card/mana/ManaCost;",1,1,1,new JHandler[]{},M5851));
}

internal static JStep M5844(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/perpetual/PerpetualIncorporate","timestamp","J",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/perpetual/PerpetualIncorporate","incorporate","Lforge/card/mana/ManaCost;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5845(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualIncorporate","timestamp","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5846(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualIncorporate","incorporate","Lforge/card/mana/ManaCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/mana/ManaCost","getColorProfile","()B","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualIncorporate","incorporate","Lforge/card/mana/ManaCost;"));f.Pc=16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualIncorporate","timestamp","J"));f.Pc=21;continue;}
case 21:{f.Push(JValue.L(0));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/card/Card","addChangedManaCost","(Lforge/card/mana/ManaCost;ZJJ)V","invokevirtual",25);}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(JValue.I(1));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualIncorporate","timestamp","J"));f.Pc=32;continue;}
case 32:{f.Push(JValue.R(null));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/Card","addColorByText","(Lforge/card/ColorSet;ZJLforge/game/staticability/StaticAbility;)V","invokevirtual",36);}
case 36:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5847(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/perpetual/PerpetualIncorporate:5847:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/perpetual/PerpetualIncorporate;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5848(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/perpetual/PerpetualIncorporate:5848:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/perpetual/PerpetualIncorporate;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5849(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/perpetual/PerpetualIncorporate:5849:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/perpetual/PerpetualIncorporate;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5850(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualIncorporate","timestamp","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5851(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualIncorporate","incorporate","Lforge/card/mana/ManaCost;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

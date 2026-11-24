// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C801{
internal static JClass Build(){var c=new JClass("forge/game/spellability/SpellAbility$EmptySa","forge/game/spellability/SpellAbility",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(9509,"forge/game/spellability/SpellAbility$EmptySa","<init>","(Lforge/game/card/Card;)V",1,2,3,new JHandler[]{},M9509));
c.Add(new JMethod(9510,"forge/game/spellability/SpellAbility$EmptySa","<init>","(Lforge/game/ability/ApiType;Lforge/game/card/Card;)V",1,3,3,new JHandler[]{},M9510));
c.Add(new JMethod(9511,"forge/game/spellability/SpellAbility$EmptySa","<init>","(Lforge/game/card/Card;Lforge/game/player/Player;)V",1,3,3,new JHandler[]{},M9511));
c.Add(new JMethod(9512,"forge/game/spellability/SpellAbility$EmptySa","<init>","(Lforge/game/ability/ApiType;Lforge/game/card/Card;Lforge/game/player/Player;)V",1,4,3,new JHandler[]{},M9512));
c.Add(new JMethod(9513,"forge/game/spellability/SpellAbility$EmptySa","resolve","()V",1,1,0,new JHandler[]{},M9513));
c.Add(new JMethod(9514,"forge/game/spellability/SpellAbility$EmptySa","canPlay","()Z",1,1,1,new JHandler[]{},M9514));
c.Add(new JMethod(9515,"forge/game/spellability/SpellAbility$EmptySa","compareTo","(Ljava/lang/Object;)I",4161,2,2,new JHandler[]{},M9515));
}

internal static JStep M9509(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{if(!rt.StaticReady(f,"forge/game/cost/Cost","Zero","Lforge/game/cost/Cost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/cost/Cost","Zero","Lforge/game/cost/Cost;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;)V","invokespecial",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility$EmptySa","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",16);}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9510(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{if(!rt.StaticReady(f,"forge/game/cost/Cost","Zero","Lforge/game/cost/Cost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/cost/Cost","Zero","Lforge/game/cost/Cost;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;)V","invokespecial",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility$EmptySa","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",16);}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility$EmptySa","api","Lforge/game/ability/ApiType;",value);f.Pc=21;continue;}
case 21:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9511(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{if(!rt.StaticReady(f,"forge/game/cost/Cost","Zero","Lforge/game/cost/Cost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/cost/Cost","Zero","Lforge/game/cost/Cost;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;)V","invokespecial",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility$EmptySa","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9512(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{if(!rt.StaticReady(f,"forge/game/cost/Cost","Zero","Lforge/game/cost/Cost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/cost/Cost","Zero","Lforge/game/cost/Cost;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;)V","invokespecial",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility$EmptySa","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",13);}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility$EmptySa","api","Lforge/game/ability/ApiType;",value);f.Pc=18;continue;}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9513(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9514(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9515(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","compareTo","(Lforge/game/spellability/SpellAbility;)I","invokespecial",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C455{
internal static JClass Build(){var c=new JClass("forge/game/card/CardFactoryUtil$2","forge/game/spellability/AbilityStatic",new string[]{},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(5039,"forge/game/card/CardFactoryUtil$2","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;)V",0,4,4,new JHandler[]{},M5039));
c.Add(new JMethod(5040,"forge/game/card/CardFactoryUtil$2","resolve","()V",1,2,3,new JHandler[]{},M5040));
}

internal static JStep M5039(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/AbilityStatic","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5040(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardFactoryUtil$2","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference==null?28:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?28:16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/CardFactoryUtil$2","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",22);}
case 22:{return rt.Call(f,"forge/game/card/Card","getSetCode","()Ljava/lang/String;","invokevirtual",25);}
case 25:{return rt.Call(f,"forge/game/player/Player","setBlessing","(ZLjava/lang/String;)V","invokevirtual",28);}
case 28:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

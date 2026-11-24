// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C204{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/AnimateEffectBase$2","forge/game/spellability/AbilityStatic",new string[]{},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("val$unanimate","Lforge/GameCommand;",false,JValue.Default("Lforge/GameCommand;"),null));
c.Add(new JField("val$cost","Lforge/card/mana/ManaCost;",false,JValue.Default("Lforge/card/mana/ManaCost;"),null));
c.Add(new JField("val$desc","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(3032,"forge/game/ability/effects/AnimateEffectBase$2","<init>","(Lforge/game/card/Card;Lforge/card/mana/ManaCost;Lforge/GameCommand;Lforge/card/mana/ManaCost;Ljava/lang/String;)V",0,6,3,new JHandler[]{},M3032));
c.Add(new JMethod(3033,"forge/game/ability/effects/AnimateEffectBase$2","resolve","()V",1,1,1,new JHandler[]{},M3033));
c.Add(new JMethod(3034,"forge/game/ability/effects/AnimateEffectBase$2","getDescription","()Ljava/lang/String;",1,1,2,new JHandler[]{},M3034));
}

internal static JStep M3032(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[3]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/AnimateEffectBase$2","val$unanimate","Lforge/GameCommand;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[4]);f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/AnimateEffectBase$2","val$cost","Lforge/card/mana/ManaCost;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[5]);f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/AnimateEffectBase$2","val$desc","Ljava/lang/String;",value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/AbilityStatic","<init>","(Lforge/game/card/Card;Lforge/card/mana/ManaCost;)V","invokespecial",23);}
case 23:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3033(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/AnimateEffectBase$2","val$unanimate","Lforge/GameCommand;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/GameCommand","run","()V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3034(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/AnimateEffectBase$2","val$cost","Lforge/card/mana/ManaCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/AnimateEffectBase$2","val$desc","Ljava/lang/String;"));f.Pc=11;continue;}
case 11:{return rt.DynamicCall(f,"forge/game/ability/effects/AnimateEffectBase$2:3034:11:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C850{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityContinuous$2","java/lang/Object",new string[]{"forge/GameCommand"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-5415775215053216360L),null));
c.Add(new JField("val$stAb","Lforge/game/staticability/StaticAbility;",false,JValue.Default("Lforge/game/staticability/StaticAbility;"),null));
c.Add(new JMethod(10003,"forge/game/staticability/StaticAbilityContinuous$2","<init>","(Lforge/game/staticability/StaticAbility;)V",0,2,2,new JHandler[]{},M10003));
c.Add(new JMethod(10004,"forge/game/staticability/StaticAbilityContinuous$2","run","()V",1,1,1,new JHandler[]{},M10004));
}

internal static JStep M10003(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbilityContinuous$2","val$stAb","Lforge/game/staticability/StaticAbility;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10004(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbilityContinuous$2","val$stAb","Lforge/game/staticability/StaticAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbility","clearIgnoreEffects","()V","invokevirtual",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

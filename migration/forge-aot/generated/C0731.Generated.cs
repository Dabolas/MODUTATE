// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C731{
internal static JClass Build(){var c=new JClass("forge/game/player/actions/PayCostAction","forge/game/player/actions/PlayerAction",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(8849,"forge/game/player/actions/PayCostAction","<init>","(Lforge/game/GameEntityView;)V",1,2,3,new JHandler[]{},M8849));
}

internal static JStep M8849(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.String("Pay cost")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/actions/PlayerAction","<init>","(Lforge/game/GameEntityView;Ljava/lang/String;)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

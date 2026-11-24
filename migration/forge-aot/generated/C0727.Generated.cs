// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C727{
internal static JClass Build(){var c=new JClass("forge/game/player/actions/FinishTargetingAction","forge/game/player/actions/PlayerAction",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(8837,"forge/game/player/actions/FinishTargetingAction","<init>","()V",1,1,3,new JHandler[]{},M8837));
}

internal static JStep M8837(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.String("Finish game entity")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/actions/PlayerAction","<init>","(Lforge/game/GameEntityView;Ljava/lang/String;)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

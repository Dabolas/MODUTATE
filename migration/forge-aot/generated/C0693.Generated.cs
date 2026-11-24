// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C693{
internal static JClass Build(){var c=new JClass("forge/game/mulligan/VancouverMulligan","forge/game/mulligan/ParisMulligan",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(7835,"forge/game/mulligan/VancouverMulligan","<init>","(Lforge/game/player/Player;Z)V",1,3,3,new JHandler[]{},M7835));
c.Add(new JMethod(7836,"forge/game/mulligan/VancouverMulligan","afterMulligan","()V",1,1,4,new JHandler[]{},M7836));
}

internal static JStep M7835(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/mulligan/ParisMulligan","<init>","(Lforge/game/player/Player;Z)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7836(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/mulligan/ParisMulligan","afterMulligan","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/VancouverMulligan","player","Lforge/game/player/Player;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/player/Player","getStartingHandSize","()I","invokevirtual",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/VancouverMulligan","player","Lforge/game/player/Player;"));f.Pc=15;continue;}
case 15:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/game/zone/PlayerZone","size","()I","invokevirtual",24);}
case 24:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?49:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/VancouverMulligan","player","Lforge/game/player/Player;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",34);}
case 34:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",37);}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/VancouverMulligan","player","Lforge/game/player/Player;"));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",44);}
case 44:{f.Push(JValue.I(1));f.Pc=45;continue;}
case 45:{f.Push(JValue.R(null));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/GameAction","scry","(Ljava/util/List;ILforge/game/spellability/SpellAbility;)V","invokevirtual",49);}
case 49:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

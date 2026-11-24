// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C343{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/OwnershipGainEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3527,"forge/game/ability/effects/OwnershipGainEffect","<init>","()V",1,1,1,new JHandler[]{},M3527));
c.Add(new JMethod(3528,"forge/game/ability/effects/OwnershipGainEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,7,2,new JHandler[]{},M3528));
}

internal static JStep M3527(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3528(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/OwnershipGainEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("DefinedPlayer")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/ability/effects/OwnershipGainEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/player/PlayerCollection;","invokestatic",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?28:21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",25);}
case 25:{f.Pc=38;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",46);}
case 46:{f.Locals[5]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[5]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",55);}
case 55:{f.Pc=f.Pop().Int==0?80:58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{f.Locals[6]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[6]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/player/Player","changeOwnership","(Lforge/game/card/Card;)V","invokevirtual",77);}
case 77:{f.Pc=48;continue;}
case 80:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

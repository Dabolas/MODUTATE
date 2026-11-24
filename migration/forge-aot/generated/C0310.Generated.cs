// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C310{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/GameLossEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3424,"forge/game/ability/effects/GameLossEffect","<init>","()V",1,1,1,new JHandler[]{},M3424));
c.Add(new JMethod(3425,"forge/game/ability/effects/GameLossEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,4,new JHandler[]{},M3425));
c.Add(new JMethod(3426,"forge/game/ability/effects/GameLossEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,4,3,new JHandler[]{},M3426));
}

internal static JStep M3424(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3425(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/GameLossEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("Defined")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/ability/effects/GameLossEffect","playersOrDescribed","(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;","invokestatic",21);}
case 21:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",24);}
case 24:{f.StackOp("pop");f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",32);}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?41:36;continue;}
case 36:{f.Push(JValue.R(rt.String(" lose the game.")));f.Pc=38;continue;}
case 38:{f.Pc=43;continue;}
case 41:{f.Push(JValue.R(rt.String(" loses the game.")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",46);}
case 46:{f.StackOp("pop");f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",51);}
case 51:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3426(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/GameLossEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",4);}
case 4:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",14);}
case 14:{f.Pc=f.Pop().Int==0?45:17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{if(!rt.StaticReady(f,"forge/game/player/GameLossReason","SpellEffect","Lforge/game/player/GameLossReason;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/GameLossReason","SpellEffect","Lforge/game/player/GameLossReason;"));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",35);}
case 35:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",38);}
case 38:{return rt.Call(f,"forge/game/player/Player","loseConditionMet","(Lforge/game/player/GameLossReason;Ljava/lang/String;)Z","invokevirtual",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{f.Pc=8;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",49);}
case 49:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",52);}
case 52:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",55);}
case 55:{return rt.Call(f,"forge/game/GameAction","checkGameOverCondition","()V","invokevirtual",58);}
case 58:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

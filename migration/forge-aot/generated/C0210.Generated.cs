// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C210{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/BecomeMonarchEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3051,"forge/game/ability/effects/BecomeMonarchEffect","<init>","()V",1,1,1,new JHandler[]{},M3051));
c.Add(new JMethod(3052,"forge/game/ability/effects/BecomeMonarchEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,3,new JHandler[]{},M3052));
c.Add(new JMethod(3053,"forge/game/ability/effects/BecomeMonarchEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,5,3,new JHandler[]{},M3053));
}

internal static JStep M3051(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3052(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/BecomeMonarchEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",18);}
case 18:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",21);}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",27);}
case 27:{f.Push(JValue.I(1));f.Pc=28;continue;}
case 28:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?36:31;continue;}
case 31:{f.Push(JValue.R(rt.String(" becomes")));f.Pc=33;continue;}
case 33:{f.Pc=38;continue;}
case 36:{f.Push(JValue.R(rt.String(" become")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String(" the monarch.")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",48);}
case 48:{f.StackOp("pop");f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",53);}
case 53:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3053(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getSetCode","()Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/BecomeMonarchEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",12);}
case 12:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?72:25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[4]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int!=0?47:44;continue;}
case 44:{f.Pc=16;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/player/Player","canBecomeMonarch","()Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int==0?69:55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",60);}
case 60:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",63);}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/GameAction","becomeMonarch","(Lforge/game/player/Player;Ljava/lang/String;)V","invokevirtual",69);}
case 69:{f.Pc=16;continue;}
case 72:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

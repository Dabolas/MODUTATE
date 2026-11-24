// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C366{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/RadiationEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3605,"forge/game/ability/effects/RadiationEffect","<init>","()V",1,1,1,new JHandler[]{},M3605));
c.Add(new JMethod(3606,"forge/game/ability/effects/RadiationEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,9,4,new JHandler[]{},M3606));
}

internal static JStep M3605(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3606(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("Num")));f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("0")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",25);}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",29);}
case 29:{f.Locals[5]=f.Pop();f.Pc=31;continue;}
case 31:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=34;continue;}
case 34:{f.StackOp("dup");f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",38);}
case 38:{f.Locals[6]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/ability/effects/RadiationEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",44);}
case 44:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",47);}
case 47:{f.Locals[7]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[7]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",56);}
case 56:{f.Pc=f.Pop().Int==0?112:59;continue;}
case 59:{f.Push(f.Locals[7]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",66);}
case 66:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=69;continue;}
case 69:{f.Locals[8]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[8]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",76);}
case 76:{f.Pc=f.Pop().Int!=0?82:79;continue;}
case 79:{f.Pc=49;continue;}
case 82:{f.Push(f.Locals[5]);f.Pc=84;continue;}
case 84:{f.Push(JValue.I(1));f.Pc=85;continue;}
case 85:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?101:88;continue;}
case 88:{f.Push(f.Locals[8]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[5]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[3]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[6]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/player/Player","addRadCounters","(ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",98);}
case 98:{f.Pc=109;continue;}
case 101:{f.Push(f.Locals[8]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[5]);f.Pc=105;continue;}
case 105:{f.Push(JNumbers.Unary("ineg",f.Pop()));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/player/Player","removeRadCounters","(I)V","invokevirtual",109);}
case 109:{f.Pc=49;continue;}
case 112:{f.Push(f.Locals[6]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[4]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",120);}
case 120:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C849{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityContinuous$1","forge/game/spellability/AbilityStatic",new string[]{},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("val$stAb","Lforge/game/staticability/StaticAbility;",false,JValue.Default("Lforge/game/staticability/StaticAbility;"),null));
c.Add(new JField("val$cards","Lforge/game/card/CardCollectionView;",false,JValue.Default("Lforge/game/card/CardCollectionView;"),null));
c.Add(new JField("val$validActivator","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("val$sourceCard","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JMethod(10000,"forge/game/staticability/StaticAbilityContinuous$1","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;Lforge/game/staticability/StaticAbility;Lforge/game/card/CardCollectionView;Ljava/util/List;Lforge/game/card/Card;)V",0,8,4,new JHandler[]{},M10000));
c.Add(new JMethod(10001,"forge/game/staticability/StaticAbilityContinuous$1","resolve","()V",1,1,2,new JHandler[]{},M10001));
c.Add(new JMethod(10002,"forge/game/staticability/StaticAbilityContinuous$1","canPlay","()Z",1,1,2,new JHandler[]{},M10002));
}

internal static JStep M10000(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[4]);f.Pc=3;continue;}
case 3:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbilityContinuous$1","val$stAb","Lforge/game/staticability/StaticAbility;",value);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[5]);f.Pc=9;continue;}
case 9:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbilityContinuous$1","val$cards","Lforge/game/card/CardCollectionView;",value);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[6]);f.Pc=15;continue;}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbilityContinuous$1","val$validActivator","Ljava/util/List;",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[7]);f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbilityContinuous$1","val$sourceCard","Lforge/game/card/Card;",value);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/AbilityStatic","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;)V","invokespecial",31);}
case 31:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10001(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbilityContinuous$1","val$stAb","Lforge/game/staticability/StaticAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/staticability/StaticAbilityContinuous$1","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/staticability/StaticAbility","addIgnoreEffectPlayers","(Lforge/game/player/Player;)V","invokevirtual",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbilityContinuous$1","val$stAb","Lforge/game/staticability/StaticAbility;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbilityContinuous$1","val$cards","Lforge/game/card/CardCollectionView;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/staticability/StaticAbility","setIgnoreEffectCards","(Lforge/game/card/CardCollectionView;)V","invokevirtual",22);}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10002(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbilityContinuous$1","val$validActivator","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/staticability/StaticAbilityContinuous$1","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?30:16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbilityContinuous$1","val$sourceCard","Lforge/game/card/Card;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int==0?30:26;continue;}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{f.Pc=31;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

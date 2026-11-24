// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C328{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/LosePerpetualEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3478,"forge/game/ability/effects/LosePerpetualEffect","<init>","()V",1,1,1,new JHandler[]{},M3478));
c.Add(new JMethod(3479,"forge/game/ability/effects/LosePerpetualEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,8,4,new JHandler[]{},M3479));
}

internal static JStep M3478(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3479(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.L(0));f.Pc=6;continue;}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Reference==null?135:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",18);}
case 18:{f.Locals[5]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/Card","getChangedCardTraits","()Lcom/google/common/collect/Table;","invokevirtual",24);}
case 24:{return rt.Call(f,"com/google/common/collect/Table","cellSet","()Ljava/util/Set;","invokeinterface",29);}
case 29:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",34);}
case 34:{f.Locals[6]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[6]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",43);}
case 43:{f.Pc=f.Pop().Int==0?106:46;continue;}
case 46:{f.Push(f.Locals[6]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",53);}
case 53:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Table$Cell"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=56;continue;}
case 56:{f.Locals[7]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[7]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"com/google/common/collect/Table$Cell","getValue","()Ljava/lang/Object;","invokeinterface",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/ICardTraitChanges"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",71);}
case 71:{return rt.Call(f,"forge/game/card/ICardTraitChanges","applyTrigger","(Ljava/util/List;)Ljava/util/List;","invokeinterface",76);}
case 76:{f.Push(f.Locals[5]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",83);}
case 83:{f.Pc=f.Pop().Int==0?103:86;continue;}
case 86:{f.Push(f.Locals[7]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"com/google/common/collect/Table$Cell","getRowKey","()Ljava/lang/Object;","invokeinterface",93);}
case 93:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Long"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/Long","longValue","()J","invokevirtual",99);}
case 99:{f.Locals[3]=f.Pop();f.Pc=100;continue;}
case 100:{f.Pc=106;continue;}
case 103:{f.Pc=36;continue;}
case 106:{f.Push(f.Locals[3]);f.Pc=107;continue;}
case 107:{f.Push(JValue.L(0));f.Pc=108;continue;}
case 108:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=109;continue;}
case 109:{f.Pc=f.Pop().Int==0?135:112;continue;}
case 112:{f.Push(f.Locals[2]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/card/Card","getChangedCardTraits","()Lcom/google/common/collect/Table;","invokevirtual",116);}
case 116:{f.Push(f.Locals[3]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",120);}
case 120:{f.Push(JValue.L(0));f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",124);}
case 124:{return rt.Call(f,"com/google/common/collect/Table","remove","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",129);}
case 129:{f.StackOp("pop");f.Pc=130;continue;}
case 130:{f.Push(f.Locals[2]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[3]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/card/Card","removePerpetual","(J)V","invokevirtual",135);}
case 135:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

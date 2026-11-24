// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C393{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/RunChaosEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3699,"forge/game/ability/effects/RunChaosEffect","<init>","()V",1,1,1,new JHandler[]{},M3699));
c.Add(new JMethod(3700,"forge/game/ability/effects/RunChaosEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,10,5,new JHandler[]{},M3700));
}

internal static JStep M3699(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3700(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/ability/effects/RunChaosEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",8);}
case 8:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?182:21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[4]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/card/Card","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",37);}
case 37:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",42);}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",51);}
case 51:{f.Pc=f.Pop().Int==0?179:54;continue;}
case 54:{f.Push(f.Locals[5]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",61);}
case 61:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=64;continue;}
case 64:{f.Locals[6]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[6]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",71);}
case 71:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChaosEnsues","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChaosEnsues","Lforge/game/trigger/TriggerType;"));f.Pc=74;continue;}
case 74:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?176:77;continue;}
case 77:{f.Push(f.Locals[6]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/trigger/Trigger","ensureAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",82);}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",86);}
case 86:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;","invokevirtual",89);}
case 89:{f.Locals[7]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[1]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",95);}
case 95:{f.Locals[8]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[6]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String("OptionalDecider")));f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",104);}
case 104:{f.Pc=f.Pop().Int==0?137:107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{f.Push(JValue.I(1));f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/spellability/SpellAbility","setOptionalTrigger","(Z)V","invokevirtual",112);}
case 112:{f.Push(f.Locals[4]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[6]);f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String("OptionalDecider")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",121);}
case 121:{f.Push(f.Locals[1]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",125);}
case 125:{f.Push(JValue.I(0));f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",129);}
case 129:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=132;continue;}
case 132:{f.Locals[8]=f.Pop();f.Pc=134;continue;}
case 134:{f.Pc=152;continue;}
case 137:{f.Push(f.Locals[6]);f.Pc=139;continue;}
case 139:{f.Push(JValue.R(rt.String("Cost")));f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",144);}
case 144:{f.Pc=f.Pop().Int==0?152:147;continue;}
case 147:{f.Push(f.Locals[1]);f.Pc=148;continue;}
case 148:{f.Push(JValue.I(1));f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/spellability/SpellAbility","setOptionalTrigger","(Z)V","invokevirtual",152);}
case 152:{if(!rt.EnsureInitialized(f,"forge/game/trigger/WrappedAbility"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/trigger/WrappedAbility")));f.Pc=155;continue;}
case 155:{f.StackOp("dup");f.Pc=156;continue;}
case 156:{f.Push(f.Locals[6]);f.Pc=158;continue;}
case 158:{f.Push(f.Locals[7]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[8]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/trigger/WrappedAbility","<init>","(Lforge/game/trigger/Trigger;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)V","invokespecial",165);}
case 165:{f.Locals[9]=f.Pop();f.Pc=167;continue;}
case 167:{f.Push(f.Locals[2]);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[9]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",175);}
case 175:{f.StackOp("pop");f.Pc=176;continue;}
case 176:{f.Pc=44;continue;}
case 179:{f.Pc=12;continue;}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",186);}
case 186:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",189);}
case 189:{f.Push(f.Locals[2]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/player/PlayerController","orderAndPlaySimultaneousSa","(Ljava/util/List;)V","invokevirtual",193);}
case 193:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

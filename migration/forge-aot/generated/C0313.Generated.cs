// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C313{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/HauntEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3434,"forge/game/ability/effects/HauntEffect","<init>","()V",1,1,1,new JHandler[]{},M3434));
c.Add(new JMethod(3435,"forge/game/ability/effects/HauntEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,8,4,new JHandler[]{},M3435));
}

internal static JStep M3434(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3435(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","isPermanent","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?33:12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","NewCard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","NewCard","Lforge/game/ability/AbilityKey;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasTriggeringObject","(Lforge/game/ability/AbilityKey;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int==0?33:22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","NewCard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","NewCard","Lforge/game/ability/AbilityKey;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{f.Locals[2]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",37);}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{f.Push(JValue.R(null));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",44);}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{f.Pc=f.Pop().Reference!=null?52:51;continue;}
case 51:{return JStep.ReturnVoid;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?122:59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/card/Card","isToken","()Z","invokevirtual",64);}
case 64:{f.Pc=f.Pop().Int!=0?122:67;continue;}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int==0?122:76;continue;}
case 76:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",79);}
case 79:{f.Locals[5]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[5]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",87);}
case 87:{f.Locals[6]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",93);}
case 93:{f.Push(f.Locals[4]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[5]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/GameAction","exile","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",101);}
case 101:{f.Locals[7]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetCard","()Lforge/game/card/Card;","invokevirtual",107);}
case 107:{f.Push(f.Locals[7]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/card/Card","addHauntedBy","(Lforge/game/card/Card;)V","invokevirtual",112);}
case 112:{f.Push(f.Locals[6]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[3]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",119);}
case 119:{f.Pc=153;continue;}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Int!=0?153:129;continue;}
case 129:{f.Push(f.Locals[4]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/card/Card","getHaunting","()Lforge/game/card/Card;","invokevirtual",134);}
case 134:{f.Pc=f.Pop().Reference==null?153:137;continue;}
case 137:{f.Push(f.Locals[4]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/card/Card","getHaunting","()Lforge/game/card/Card;","invokevirtual",142);}
case 142:{f.Push(f.Locals[4]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/card/Card","removeHauntedBy","(Lforge/game/card/Card;)V","invokevirtual",147);}
case 147:{f.Push(f.Locals[4]);f.Pc=149;continue;}
case 149:{f.Push(JValue.R(null));f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/card/Card","setHaunting","(Lforge/game/card/Card;)V","invokevirtual",153);}
case 153:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

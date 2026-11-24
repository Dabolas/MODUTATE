// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C895{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerAttackersDeclared","forge/game/trigger/Trigger",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10220,"forge/game/trigger/TriggerAttackersDeclared","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M10220));
c.Add(new JMethod(10221,"forge/game/trigger/TriggerAttackersDeclared","performTest","(Ljava/util/Map;)Z",17,5,5,new JHandler[]{},M10221));
c.Add(new JMethod(10222,"forge/game/trigger/TriggerAttackersDeclared","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",17,8,6,new JHandler[]{},M10222));
c.Add(new JMethod(10223,"forge/game/trigger/TriggerAttackersDeclared","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,3,4,new JHandler[]{},M10223));
}

internal static JStep M10220(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/trigger/Trigger","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10221(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","OneOfAttackingTeam","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","OneOfAttackingTeam","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int==0?58:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("AttackingPlayer")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/trigger/TriggerAttackersDeclared","hasParam","(Ljava/lang/String;)Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int!=0?31:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","AttackingPlayer","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","AttackingPlayer","Lforge/game/ability/AbilityKey;"));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/trigger/TriggerAttackersDeclared","refersToTriggering","(Lforge/game/ability/AbilityKey;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?35:31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{f.Pc=36;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{f.Locals[2]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","OneOfAttackingTeam","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","OneOfAttackingTeam","Lforge/game/ability/AbilityKey;"));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",52);}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?58:56;continue;}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("AttackingPlayer")));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","AttackingPlayer","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","AttackingPlayer","Lforge/game/ability/AbilityKey;"));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",70);}
case 70:{return rt.Call(f,"forge/game/trigger/TriggerAttackersDeclared","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int!=0?78:76;continue;}
case 76:{f.Push(JValue.I(0));f.Pc=77;continue;}
case 77:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("AttackedTarget")));f.Pc=81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","AttackedTarget","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","AttackedTarget","Lforge/game/ability/AbilityKey;"));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",90);}
case 90:{return rt.Call(f,"forge/game/trigger/TriggerAttackersDeclared","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Int!=0?98:96;continue;}
case 96:{f.Push(JValue.I(0));f.Pc=97;continue;}
case 97:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String("ValidAttackers")));f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/trigger/TriggerAttackersDeclared","hasParam","(Ljava/lang/String;)Z","invokevirtual",104);}
case 104:{f.Pc=f.Pop().Int==0?177:107;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("ValidAttackersAmount")));f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("GE1")));f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/trigger/TriggerAttackersDeclared","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",115);}
case 115:{f.Locals[2]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"));f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",125);}
case 125:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[0]);f.Pc=129;continue;}
case 129:{f.Push(JValue.R(rt.String("ValidAttackers")));f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/trigger/TriggerAttackersDeclared","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",134);}
case 134:{f.Push(f.Locals[0]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/trigger/TriggerAttackersDeclared","getHostCard","()Lforge/game/card/Card;","invokevirtual",138);}
case 138:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",141);}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/trigger/TriggerAttackersDeclared","getHostCard","()Lforge/game/card/Card;","invokevirtual",145);}
case 145:{f.Push(f.Locals[0]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/card/CardLists","getValidCardCount","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)I","invokestatic",149);}
case 149:{f.Locals[3]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/trigger/TriggerAttackersDeclared","getHostCard","()Lforge/game/card/Card;","invokevirtual",154);}
case 154:{f.Push(f.Locals[2]);f.Pc=155;continue;}
case 155:{f.Push(JValue.I(2));f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",159);}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",163);}
case 163:{f.Locals[4]=f.Pop();f.Pc=165;continue;}
case 165:{f.Push(f.Locals[3]);f.Pc=166;continue;}
case 166:{f.Push(f.Locals[2]);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[4]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",172);}
case 172:{f.Pc=f.Pop().Int!=0?177:175;continue;}
case 175:{f.Push(JValue.I(0));f.Pc=176;continue;}
case 176:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 177:{f.Push(JValue.I(1));f.Pc=178;continue;}
case 178:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10222(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","AttackedTarget","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","AttackedTarget","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("ValidAttackers")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/trigger/TriggerAttackersDeclared","hasParam","(Ljava/lang/String;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?124:36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("ValidAttackers")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/trigger/TriggerAttackersDeclared","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/trigger/TriggerAttackersDeclared","getHostCard","()Lforge/game/card/Card;","invokevirtual",48);}
case 48:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",51);}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/trigger/TriggerAttackersDeclared","getHostCard","()Lforge/game/card/Card;","invokevirtual",55);}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",59);}
case 59:{f.Locals[4]=f.Pop();f.Pc=61;continue;}
case 61:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=64;continue;}
case 64:{f.StackOp("dup");f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",68);}
case 68:{f.Locals[5]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",75);}
case 75:{f.Locals[6]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[6]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",84);}
case 84:{f.Pc=f.Pop().Int==0?121:87;continue;}
case 87:{f.Push(f.Locals[6]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",94);}
case 94:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=97;continue;}
case 97:{f.Locals[7]=f.Pop();f.Pc=99;continue;}
case 99:{f.Push(f.Locals[5]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[7]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",106);}
case 106:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",109);}
case 109:{f.Push(f.Locals[7]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;","invokevirtual",114);}
case 114:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",117);}
case 117:{f.StackOp("pop");f.Pc=118;continue;}
case 118:{f.Pc=77;continue;}
case 121:{f.Push(f.Locals[5]);f.Pc=123;continue;}
case 123:{f.Locals[3]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"));f.Pc=128;continue;}
case 128:{f.Push(f.Locals[4]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",135);}
case 135:{f.StackOp("pop");f.Pc=136;continue;}
case 136:{f.Push(f.Locals[0]);f.Pc=137;continue;}
case 137:{f.Push(JValue.R(rt.String("AttackedTarget")));f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/trigger/TriggerAttackersDeclared","hasParam","(Ljava/lang/String;)Z","invokevirtual",142);}
case 142:{f.Pc=f.Pop().Int==0?176:145;continue;}
case 145:{f.Push(f.Locals[3]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[0]);f.Pc=147;continue;}
case 147:{f.Push(JValue.R(rt.String("AttackedTarget")));f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/trigger/TriggerAttackersDeclared","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",152);}
case 152:{f.Push(JValue.R(rt.String(",")));f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",157);}
case 157:{f.Push(f.Locals[0]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/trigger/TriggerAttackersDeclared","getHostCard","()Lforge/game/card/Card;","invokevirtual",161);}
case 161:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",164);}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/trigger/TriggerAttackersDeclared","getHostCard","()Lforge/game/card/Card;","invokevirtual",168);}
case 168:{f.Push(f.Locals[0]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/GameObjectPredicates","restriction","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",172);}
case 172:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",175);}
case 175:{f.Locals[3]=f.Pop();f.Pc=176;continue;}
case 176:{f.Push(f.Locals[1]);f.Pc=177;continue;}
case 177:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","AttackedTarget","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","AttackedTarget","Lforge/game/ability/AbilityKey;"));f.Pc=180;continue;}
case 180:{f.Push(f.Locals[3]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",186);}
case 186:{f.StackOp("pop");f.Pc=187;continue;}
case 187:{f.Push(f.Locals[2]);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[1]);f.Pc=189;continue;}
case 189:{f.Push(JValue.I(1));f.Pc=190;continue;}
case 190:{f.Push(JValue.R(rt.NewArray("Lforge/game/ability/AbilityKey;",f.Pop().Int)));f.Pc=193;continue;}
case 193:{f.StackOp("dup");f.Pc=194;continue;}
case 194:{f.Push(JValue.I(0));f.Pc=195;continue;}
case 195:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","AttackingPlayer","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","AttackingPlayer","Lforge/game/ability/AbilityKey;"));f.Pc=198;continue;}
case 198:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/ability/AbilityKey","copyKeys","(Ljava/util/Map;Ljava/util/Map;[Lforge/game/ability/AbilityKey;)V","invokestatic",202);}
case 202:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10223(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",12);}
case 12:{f.Push(JValue.R(rt.String("lblNumberAttackers")));f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",24);}
case 24:{f.Push(JValue.R(rt.String(": ")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",29);}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",36);}
case 36:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",44);}
case 44:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

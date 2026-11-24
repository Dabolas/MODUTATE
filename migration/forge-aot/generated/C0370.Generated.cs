// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C370{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/RegenerationEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3621,"forge/game/ability/effects/RegenerationEffect","<init>","()V",1,1,1,new JHandler[]{},M3621));
c.Add(new JMethod(3622,"forge/game/ability/effects/RegenerationEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,9,4,new JHandler[]{},M3622));
}

internal static JStep M3621(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3622(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/ability/effects/RegenerationEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",23);}
case 23:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",26);}
case 26:{f.Locals[5]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[5]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",35);}
case 35:{f.Pc=f.Pop().Int==0?182:38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",45);}
case 45:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=48;continue;}
case 48:{f.Locals[6]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[6]);f.Pc=53;continue;}
case 53:{f.Push(JValue.R(null));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",57);}
case 57:{f.Locals[7]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[7]);f.Pc=61;continue;}
case 61:{f.Pc=f.Pop().Reference==null?28:64;continue;}
case 64:{f.Push(f.Locals[6]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[7]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",71);}
case 71:{f.Pc=f.Pop().Int!=0?77:74;continue;}
case 74:{f.Pc=28;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",84);}
case 84:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=87;continue;}
case 87:{f.Locals[8]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[7]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/card/Card","healDamage","()V","invokevirtual",94);}
case 94:{f.Push(f.Locals[7]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[8]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[7]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",103);}
case 103:{return rt.Call(f,"forge/game/card/Card","tap","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?117:109;continue;}
case 109:{f.Push(f.Locals[4]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[7]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",116);}
case 116:{f.StackOp("pop");f.Pc=117;continue;}
case 117:{f.Push(f.Locals[7]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/card/Card","addRegeneratedThisTurn","()V","invokevirtual",122);}
case 122:{f.Push(f.Locals[3]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Reference==null?148:129;continue;}
case 129:{f.Push(f.Locals[3]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",133);}
case 133:{f.Push(f.Locals[7]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/combat/Combat","saveLKI","(Lforge/game/card/Card;)Lforge/game/combat/CombatLki;","invokevirtual",138);}
case 138:{f.StackOp("pop");f.Pc=139;continue;}
case 139:{f.Push(f.Locals[3]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",143);}
case 143:{f.Push(f.Locals[7]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/combat/Combat","removeFromCombat","(Lforge/game/card/Card;)V","invokevirtual",148);}
case 148:{f.Push(f.Locals[3]);f.Pc=149;continue;}
case 149:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardRegenerated"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardRegenerated")));f.Pc=152;continue;}
case 152:{f.StackOp("dup");f.Pc=153;continue;}
case 153:{f.Push(f.Locals[7]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/event/GameEventCardRegenerated","<init>","(Lforge/game/card/Card;)V","invokespecial",158);}
case 158:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",161);}
case 161:{f.Push(f.Locals[2]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/card/Card","isImmutable","()Z","invokevirtual",165);}
case 165:{f.Pc=f.Pop().Int==0?179:168;continue;}
case 168:{f.Push(f.Locals[7]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/card/Card","decShieldCount","()V","invokevirtual",173);}
case 173:{f.Push(f.Locals[2]);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[7]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Object;)V","invokevirtual",179);}
case 179:{f.Pc=28;continue;}
case 182:{f.Push(f.Locals[4]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",187);}
case 187:{f.Pc=f.Pop().Int!=0?221:190;continue;}
case 190:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",193);}
case 193:{f.Locals[5]=f.Pop();f.Pc=195;continue;}
case 195:{f.Push(f.Locals[5]);f.Pc=197;continue;}
case 197:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=200;continue;}
case 200:{f.Push(f.Locals[4]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",207);}
case 207:{f.StackOp("pop");f.Pc=208;continue;}
case 208:{f.Push(f.Locals[3]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",212);}
case 212:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","TapAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","TapAll","Lforge/game/trigger/TriggerType;"));f.Pc=215;continue;}
case 215:{f.Push(f.Locals[5]);f.Pc=217;continue;}
case 217:{f.Push(JValue.I(0));f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",221);}
case 221:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

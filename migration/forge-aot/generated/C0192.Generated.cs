// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C192{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/AbandonEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(2991,"forge/game/ability/effects/AbandonEffect","<init>","()V",1,1,1,new JHandler[]{},M2991));
c.Add(new JMethod(2992,"forge/game/ability/effects/AbandonEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,6,9,new JHandler[]{},M2992));
}

internal static JStep M2991(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2992(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("Optional")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",16);}
case 16:{f.Locals[4]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Int==0?56:23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",27);}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(null));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",32);}
case 32:{f.Push(JValue.R(rt.String("lblWouldYouLikeAbandonSource")));f.Pc=34;continue;}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=38;continue;}
case 38:{f.StackOp("dup");f.Pc=39;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",44);}
case 44:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",48);}
case 48:{f.Push(JValue.R(null));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int!=0?56:55;continue;}
case 55:{return JStep.ReturnVoid;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String("RememberAbandoned")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int==0?70:65;continue;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",70);}
case 70:{f.Push(f.Locals[3]);f.Pc=71;continue;}
case 71:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",77);}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/zone/PlayerZone","remove","(Lforge/game/card/Card;)V","invokevirtual",81);}
case 81:{f.Push(f.Locals[3]);f.Pc=82;continue;}
case 82:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"));f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",88);}
case 88:{f.Push(f.Locals[2]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/zone/PlayerZone","add","(Lforge/game/card/Card;)V","invokevirtual",92);}
case 92:{f.Push(f.Locals[3]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",96);}
case 96:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",99);}
case 99:{f.Push(f.Locals[2]);f.Pc=100;continue;}
case 100:{f.Push(JValue.R(null));f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/trigger/TriggerHandler","clearActiveTriggers","(Lforge/game/card/Card;Lforge/game/zone/Zone;)V","invokevirtual",104);}
case 104:{f.Push(f.Locals[3]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",108);}
case 108:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",111);}
case 111:{f.Push(f.Locals[2]);f.Pc=112;continue;}
case 112:{f.Push(JValue.I(0));f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerActiveTrigger","(Lforge/game/card/Card;Z)V","invokevirtual",116);}
case 116:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",119);}
case 119:{f.Locals[5]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[5]);f.Pc=123;continue;}
case 123:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Scheme","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Scheme","Lforge/game/ability/AbilityKey;"));f.Pc=126;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",132);}
case 132:{f.StackOp("pop");f.Pc=133;continue;}
case 133:{f.Push(f.Locals[3]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",137);}
case 137:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",140);}
case 140:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Abandoned","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Abandoned","Lforge/game/trigger/TriggerType;"));f.Pc=143;continue;}
case 143:{f.Push(f.Locals[5]);f.Pc=145;continue;}
case 145:{f.Push(JValue.I(0));f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",149);}
case 149:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

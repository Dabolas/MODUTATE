// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C459{
internal static JClass Build(){var c=new JClass("forge/game/card/CardFactoryUtil$6","forge/game/spellability/AbilityStatic",new string[]{},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("val$k","[Ljava/lang/String;",false,JValue.Default("[Ljava/lang/String;"),null));
c.Add(new JMethod(5051,"forge/game/card/CardFactoryUtil$6","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;[Ljava/lang/String;)V",0,5,4,new JHandler[]{},M5051));
c.Add(new JMethod(5052,"forge/game/card/CardFactoryUtil$6","canPlay","()Z",1,1,3,new JHandler[]{},M5052));
c.Add(new JMethod(5053,"forge/game/card/CardFactoryUtil$6","resolve","()V",1,8,6,new JHandler[]{},M5053));
}

internal static JStep M5051(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[4]);f.Pc=3;continue;}
case 3:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardFactoryUtil$6","val$k","[Ljava/lang/String;",value);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/AbilityStatic","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;)V","invokespecial",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5052(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardFactoryUtil$6","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardFactoryUtil$6","getHostCard","()Lforge/game/card/Card;","invokevirtual",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","canPlay","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int!=0?17:15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/CardFactoryUtil$6","getHostCard","()Lforge/game/card/Card;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",27);}
case 27:{return rt.Call(f,"forge/game/zone/MagicStack","isSplitSecondOnStack","()Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?35:33;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/CardFactoryUtil$6","getHostCard","()Lforge/game/card/Card;","invokevirtual",40);}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/card/CardFactoryUtil$6","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantBeCast","cantBeCastAbility","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Z","invokestatic",47);}
case 47:{f.Pc=f.Pop().Int==0?52:50;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/card/CardFactoryUtil$6","getHostCard","()Lforge/game/card/Card;","invokevirtual",56);}
case 56:{return rt.Call(f,"forge/game/card/Card","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",59);}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/card/CardFactoryUtil$6","getHostCard","()Lforge/game/card/Card;","invokevirtual",63);}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/card/CardFactoryUtil$6","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",67);}
case 67:{return rt.Call(f,"forge/game/spellability/SpellAbility","canCastTiming","(Lforge/game/card/Card;Lforge/game/player/Player;)Z","invokevirtual",70);}
case 70:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5053(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardFactoryUtil$6","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/CardFactoryUtil$6","getHostCard","()Lforge/game/card/Card;","invokevirtual",26);}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/GameAction","exile","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",31);}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",39);}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardFactoryUtil$6","val$k","[Ljava/lang/String;"));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",51);}
case 51:{f.Locals[5]=f.Pop();f.Pc=53;continue;}
case 53:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=56;continue;}
case 56:{f.StackOp("dup");f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",60);}
case 60:{f.Locals[6]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","TIME","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","TIME","Lforge/game/card/CounterEnumType;"));f.Pc=67;continue;}
case 67:{f.Push(f.Locals[5]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/card/CardFactoryUtil$6","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",73);}
case 73:{f.Push(f.Locals[6]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",78);}
case 78:{f.Push(f.Locals[6]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",85);}
case 85:{f.Push(JValue.I(6));f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(JValue.I(0));f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/card/CardFactoryUtil$6","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",96);}
case 96:{return rt.Call(f,"forge/game/player/Player","toString","()Ljava/lang/String;","invokevirtual",99);}
case 99:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=100;continue;}
case 100:{f.StackOp("dup");f.Pc=101;continue;}
case 101:{f.Push(JValue.I(1));f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String("has suspended")));f.Pc=104;continue;}
case 104:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=105;continue;}
case 105:{f.StackOp("dup");f.Pc=106;continue;}
case 106:{f.Push(JValue.I(2));f.Pc=107;continue;}
case 107:{f.Push(f.Locals[4]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",112);}
case 112:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=113;continue;}
case 113:{f.StackOp("dup");f.Pc=114;continue;}
case 114:{f.Push(JValue.I(3));f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.String("with")));f.Pc=117;continue;}
case 117:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=118;continue;}
case 118:{f.StackOp("dup");f.Pc=119;continue;}
case 119:{f.Push(JValue.I(4));f.Pc=120;continue;}
case 120:{f.Push(f.Locals[5]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",125);}
case 125:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=126;continue;}
case 126:{f.StackOp("dup");f.Pc=127;continue;}
case 127:{f.Push(JValue.I(5));f.Pc=128;continue;}
case 128:{f.Push(JValue.R(rt.String("time counters on it.")));f.Pc=130;continue;}
case 130:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",134);}
case 134:{f.Locals[7]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=140;continue;}
case 140:{f.StackOp("dup");f.Pc=141;continue;}
case 141:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=144;continue;}
case 144:{f.Push(f.Locals[7]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",149);}
case 149:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",152);}
case 152:{f.Push(f.Locals[1]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",156);}
case 156:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=159;continue;}
case 159:{f.StackOp("dup");f.Pc=160;continue;}
case 160:{f.Push(f.Locals[4]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",165);}
case 165:{f.Push(f.Locals[4]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",170);}
case 170:{f.Push(JValue.I(1));f.Pc=171;continue;}
case 171:{f.Push(f.Locals[4]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",176);}
case 176:{f.Push(f.Locals[5]);f.Pc=178;continue;}
case 178:{return rt.DynamicCall(f,"forge/game/card/CardFactoryUtil$6:5053:178:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;I)Ljava/lang/String;",183);}
case 183:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;ZLjava/lang/String;)V","invokevirtual",186);}
case 186:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C320{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/InvestigateEffect","forge/game/ability/effects/TokenEffectBase",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3452,"forge/game/ability/effects/InvestigateEffect","<init>","()V",1,1,1,new JHandler[]{},M3452));
c.Add(new JMethod(3453,"forge/game/ability/effects/InvestigateEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,5,4,new JHandler[]{},M3453));
c.Add(new JMethod(3454,"forge/game/ability/effects/InvestigateEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,10,6,new JHandler[]{},M3454));
}

internal static JStep M3452(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/TokenEffectBase","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3453(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("Num")));f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("1")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",18);}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("Investigate")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",28);}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?55:35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String(" ")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",42);}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",46);}
case 46:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",49);}
case 49:{f.Push(JValue.R(rt.String(" times")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",54);}
case 54:{f.StackOp("pop");f.Pc=55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String(". (Create a colorless Clue artifact token with \"{2}, Sacrifice this artifact: Draw a card.\")")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",62);}
case 62:{f.StackOp("pop");f.Pc=63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",68);}
case 68:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3454(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("Num")));f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("1")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",23);}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{f.Locals[5]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[5]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?225:35;continue;}
case 35:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=38;continue;}
case 38:{f.StackOp("dup");f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",42);}
case 42:{f.Locals[6]=f.Pop();f.Pc=44;continue;}
case 44:{if(!rt.EnsureInitialized(f,"org/apache/commons/lang3/mutable/MutableBoolean"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("org/apache/commons/lang3/mutable/MutableBoolean")));f.Pc=47;continue;}
case 47:{f.StackOp("dup");f.Pc=48;continue;}
case 48:{f.Push(JValue.I(0));f.Pc=49;continue;}
case 49:{return rt.Call(f,"org/apache/commons/lang3/mutable/MutableBoolean","<init>","(Z)V","invokespecial",52);}
case 52:{f.Locals[7]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/ability/effects/InvestigateEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",58);}
case 58:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",61);}
case 61:{f.Locals[8]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[8]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",70);}
case 70:{f.Pc=f.Pop().Int==0?189:73;continue;}
case 73:{f.Push(f.Locals[8]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",80);}
case 80:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=83;continue;}
case 83:{f.Locals[9]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[9]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int!=0?96:93;continue;}
case 93:{f.Pc=63;continue;}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{f.Push(JValue.R(rt.String("Optional")));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",102);}
case 102:{f.Pc=f.Pop().Int==0?134:105;continue;}
case 105:{f.Push(f.Locals[9]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",110);}
case 110:{f.Push(f.Locals[1]);f.Pc=111;continue;}
case 111:{f.Push(JValue.R(null));f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",115);}
case 115:{f.Push(JValue.R(rt.String("lblWouldYouLikeInvestigate")));f.Pc=117;continue;}
case 117:{f.Push(JValue.I(0));f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",124);}
case 124:{f.Push(JValue.R(null));f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",128);}
case 128:{f.Pc=f.Pop().Int!=0?134:131;continue;}
case 131:{f.Pc=63;continue;}
case 134:{f.Push(f.Locals[0]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[9]);f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("c_a_clue_draw")));f.Pc=140;continue;}
case 140:{f.Push(JValue.I(1));f.Pc=141;continue;}
case 141:{f.Push(f.Locals[1]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/ability/effects/InvestigateEffect","makeTokenTableInternal","(Lforge/game/player/Player;Ljava/lang/String;ILforge/game/spellability/SpellAbility;)Lforge/game/card/TokenCreateTable;","invokevirtual",145);}
case 145:{f.Push(JValue.I(0));f.Pc=146;continue;}
case 146:{f.Push(f.Locals[6]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[7]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[1]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/ability/effects/InvestigateEffect","makeTokenTable","(Lforge/game/card/TokenCreateTable;ZLforge/game/card/CardZoneTable;Lorg/apache/commons/lang3/mutable/MutableBoolean;Lforge/game/spellability/SpellAbility;)Lforge/game/card/TokenCreateTable;","invokevirtual",154);}
case 154:{f.StackOp("pop");f.Pc=155;continue;}
case 155:{f.Push(f.Locals[9]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/player/Player","addInvestigatedThisTurn","()V","invokevirtual",160);}
case 160:{f.Push(f.Locals[1]);f.Pc=161;continue;}
case 161:{f.Push(JValue.R(rt.String("RememberInvestigatingPlayers")));f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",166);}
case 166:{f.Pc=f.Pop().Int==0?175:169;continue;}
case 169:{f.Push(f.Locals[2]);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[9]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",175);}
case 175:{f.Push(f.Locals[3]);f.Pc=176;continue;}
case 176:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventTokenCreated"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventTokenCreated")));f.Pc=179;continue;}
case 179:{f.StackOp("dup");f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/event/GameEventTokenCreated","<init>","()V","invokespecial",183);}
case 183:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",186);}
case 186:{f.Pc=63;continue;}
case 189:{f.Push(f.Locals[6]);f.Pc=191;continue;}
case 191:{f.Push(f.Locals[3]);f.Pc=192;continue;}
case 192:{f.Push(f.Locals[1]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",196);}
case 196:{f.Push(f.Locals[7]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"org/apache/commons/lang3/mutable/MutableBoolean","isTrue","()Z","invokevirtual",201);}
case 201:{f.Pc=f.Pop().Int==0?219:204;continue;}
case 204:{f.Push(f.Locals[3]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",208);}
case 208:{f.Push(f.Locals[3]);f.Pc=209;continue;}
case 209:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCombatChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCombatChanged")));f.Pc=212;continue;}
case 212:{f.StackOp("dup");f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/event/GameEventCombatChanged","<init>","()V","invokespecial",216);}
case 216:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",219);}
case 219:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=222;continue;}
case 222:{f.Pc=28;continue;}
case 225:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

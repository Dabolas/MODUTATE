// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C220{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ChangeCombatantsEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3081,"forge/game/ability/effects/ChangeCombatantsEffect","<init>","()V",1,1,1,new JHandler[]{},M3081));
c.Add(new JMethod(3082,"forge/game/ability/effects/ChangeCombatantsEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,2,new JHandler[]{},M3082));
c.Add(new JMethod(3083,"forge/game/ability/effects/ChangeCombatantsEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,13,9,new JHandler[]{},M3083));
}

internal static JStep M3081(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3082(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Reselect the defender of ")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/ability/effects/ChangeCombatantsEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",19);}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int==0?35:30;continue;}
case 30:{f.Push(JValue.R(rt.String("target creature")));f.Pc=32;continue;}
case 32:{f.Pc=39;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",39);}
case 39:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",42);}
case 42:{f.Push(JValue.R(rt.String(".")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",47);}
case 47:{f.StackOp("pop");f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",52);}
case 52:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3083(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("Optional")));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",8);}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",13);}
case 13:{f.Locals[4]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",20);}
case 20:{f.Locals[5]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/ability/effects/ChangeCombatantsEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",26);}
case 26:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",29);}
case 29:{f.Locals[6]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[6]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",38);}
case 38:{f.Pc=f.Pop().Int==0?277:41;continue;}
case 41:{f.Push(f.Locals[6]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{f.Locals[7]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[7]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",58);}
case 58:{f.Push(f.Locals[7]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",63);}
case 63:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeCombatantsEffect:3083:63:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;I)Ljava/lang/String;",68);}
case 68:{f.Locals[8]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[3]);f.Pc=71;continue;}
case 71:{f.Pc=f.Pop().Int==0?110:74;continue;}
case 74:{f.Push(f.Locals[4]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",79);}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(null));f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",84);}
case 84:{f.Push(JValue.R(rt.String("lblChangeCombatantOption")));f.Pc=86;continue;}
case 86:{f.Push(JValue.I(1));f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(JValue.I(0));f.Pc=92;continue;}
case 92:{f.Push(f.Locals[8]);f.Pc=94;continue;}
case 94:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",98);}
case 98:{f.Push(f.Locals[7]);f.Pc=100;continue;}
case 100:{f.Push(JValue.R(null));f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",104);}
case 104:{f.Pc=f.Pop().Int!=0?110:107;continue;}
case 107:{f.Pc=31;continue;}
case 110:{f.Push(f.Locals[5]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",115);}
case 115:{f.Push(f.Locals[7]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;","invokevirtual",120);}
case 120:{f.Locals[9]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[7]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{f.Push(JValue.R(rt.String("Attacking")));f.Pc=127;continue;}
case 127:{f.Push(JValue.R(rt.String("Blocking")));f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/ability/effects/ChangeCombatantsEffect","addToCombat","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/String;)Z","invokestatic",132);}
case 132:{f.Pc=f.Pop().Int==0?274:135;continue;}
case 135:{f.Push(JValue.I(1));f.Pc=136;continue;}
case 136:{f.Locals[2]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[5]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",142);}
case 142:{f.Push(f.Locals[7]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;","invokevirtual",147);}
case 147:{f.Locals[10]=f.Pop();f.Pc=149;continue;}
case 149:{f.Push(f.Locals[5]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",154);}
case 154:{return rt.Call(f,"forge/game/zone/MagicStack","iterator","()Ljava/util/Iterator;","invokevirtual",157);}
case 157:{f.Locals[11]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[11]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",166);}
case 166:{f.Pc=f.Pop().Int==0?274:169;continue;}
case 169:{f.Push(f.Locals[11]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",176);}
case 176:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=179;continue;}
case 179:{f.Locals[12]=f.Pop();f.Pc=181;continue;}
case 181:{f.Push(f.Locals[12]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","isTrigger","()Z","invokevirtual",186);}
case 186:{f.Pc=f.Pop().Int==0?271:189;continue;}
case 189:{f.Push(f.Locals[7]);f.Pc=191;continue;}
case 191:{f.Push(f.Locals[12]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSourceCard","()Lforge/game/card/Card;","invokevirtual",196);}
case 196:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",199);}
case 199:{f.Pc=f.Pop().Int==0?271:202;continue;}
case 202:{f.Push(f.Locals[12]);f.Pc=204;continue;}
case 204:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"));f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",210);}
case 210:{f.Pc=f.Pop().Reference==null?271:213;continue;}
case 213:{f.Push(f.Locals[12]);f.Pc=215;continue;}
case 215:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","OriginalDefender","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","OriginalDefender","Lforge/game/ability/AbilityKey;"));f.Pc=218;continue;}
case 218:{f.Push(f.Locals[9]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","addTriggeringObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)Z","invokevirtual",223);}
case 223:{f.StackOp("pop");f.Pc=224;continue;}
case 224:{f.Push(f.Locals[10]);f.Pc=226;continue;}
case 226:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=229;continue;}
case 229:{f.Pc=f.Pop().Int==0?246:232;continue;}
case 232:{f.Push(f.Locals[12]);f.Pc=234;continue;}
case 234:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"));f.Pc=237;continue;}
case 237:{f.Push(f.Locals[10]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","updateTriggeringObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)Z","invokevirtual",242);}
case 242:{f.StackOp("pop");f.Pc=243;continue;}
case 243:{f.Pc=271;continue;}
case 246:{f.Push(f.Locals[10]);f.Pc=248;continue;}
case 248:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=251;continue;}
case 251:{f.Pc=f.Pop().Int==0?271:254;continue;}
case 254:{f.Push(f.Locals[12]);f.Pc=256;continue;}
case 256:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"));f.Pc=259;continue;}
case 259:{f.Push(f.Locals[10]);f.Pc=261;continue;}
case 261:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",267);}
case 267:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","updateTriggeringObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)Z","invokevirtual",270);}
case 270:{f.StackOp("pop");f.Pc=271;continue;}
case 271:{f.Pc=159;continue;}
case 274:{f.Pc=31;continue;}
case 277:{f.Push(f.Locals[2]);f.Pc=278;continue;}
case 278:{f.Pc=f.Pop().Int==0?298:281;continue;}
case 281:{f.Push(f.Locals[5]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",286);}
case 286:{f.Push(f.Locals[5]);f.Pc=288;continue;}
case 288:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCombatChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCombatChanged")));f.Pc=291;continue;}
case 291:{f.StackOp("dup");f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/event/GameEventCombatChanged","<init>","()V","invokespecial",295);}
case 295:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",298);}
case 298:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

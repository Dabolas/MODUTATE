// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C340{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/MutateEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3519,"forge/game/ability/effects/MutateEffect","<init>","()V",1,1,1,new JHandler[]{},M3519));
c.Add(new JMethod(3520,"forge/game/ability/effects/MutateEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,12,7,new JHandler[]{},M3520));
}

internal static JStep M3519(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3520(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/Card","isCopiedSpell","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?30:23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/Card","setGamePieceType","(Lforge/card/GamePieceType;)V","invokevirtual",30);}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("Defined")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/ability/effects/MutateEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",36);}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[5]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(JValue.I(2));f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/Card;",f.Pop().Int)));f.Pc=49;continue;}
case 49:{f.StackOp("dup");f.Pc=50;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=53;continue;}
case 53:{f.StackOp("dup");f.Pc=54;continue;}
case 54:{f.Push(JValue.I(1));f.Pc=55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=58;continue;}
case 58:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",61);}
case 61:{return rt.Call(f,"forge/game/card/CardCollection","getView","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokestatic",64);}
case 64:{f.Locals[6]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",70);}
case 70:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",73);}
case 73:{f.Push(f.Locals[6]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",79);}
case 79:{f.Push(JValue.R(rt.String("lblChooseCreatureToBeTop")));f.Pc=81;continue;}
case 81:{f.Push(JValue.I(0));f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",88);}
case 88:{f.Push(JValue.I(0));f.Pc=89;continue;}
case 89:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=92;continue;}
case 92:{f.StackOp("dup");f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",96);}
case 96:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",99);}
case 99:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=102;continue;}
case 102:{f.Locals[7]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[7]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?114:110;continue;}
case 110:{f.Push(JValue.I(1));f.Pc=111;continue;}
case 111:{f.Pc=115;continue;}
case 114:{f.Push(JValue.I(0));f.Pc=115;continue;}
case 115:{f.Locals[8]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",121);}
case 121:{f.Pc=f.Pop().Int==0?130:124;continue;}
case 124:{f.Push(f.Locals[2]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[3]);f.Pc=126;continue;}
case 126:{f.Push(JValue.L(0));f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",130);}
case 130:{f.Push(f.Locals[5]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",135);}
case 135:{f.Locals[9]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[2]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[5]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/card/Card","setMergedToCard","(Lforge/game/card/Card;)V","invokevirtual",143);}
case 143:{f.Push(f.Locals[5]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/card/Card","hasMergedCard","()Z","invokevirtual",148);}
case 148:{f.Pc=f.Pop().Int!=0?158:151;continue;}
case 151:{f.Push(f.Locals[5]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[5]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/card/Card","addMergedCard","(Lforge/game/card/Card;)V","invokevirtual",158);}
case 158:{f.Push(f.Locals[8]);f.Pc=160;continue;}
case 160:{f.Pc=f.Pop().Int==0?172:163;continue;}
case 163:{f.Push(f.Locals[5]);f.Pc=165;continue;}
case 165:{f.Push(f.Locals[2]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"forge/game/card/Card","addMergedCardToTop","(Lforge/game/card/Card;)V","invokevirtual",169);}
case 169:{f.Pc=178;continue;}
case 172:{f.Push(f.Locals[5]);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[2]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/card/Card","addMergedCard","(Lforge/game/card/Card;)V","invokevirtual",178);}
case 178:{f.Push(f.Locals[5]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/card/Card","removeMutatedStates","()V","invokevirtual",183);}
case 183:{f.Push(f.Locals[4]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",188);}
case 188:{f.Locals[10]=f.Pop();f.Pc=190;continue;}
case 190:{f.Push(f.Locals[5]);f.Pc=192;continue;}
case 192:{f.Push(f.Locals[10]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"forge/game/card/Card","setMutatedTimestamp","(J)V","invokevirtual",197);}
case 197:{f.Push(f.Locals[5]);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[5]);f.Pc=201;continue;}
case 201:{f.Push(f.Locals[1]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/game/card/CardFactory","getMutatedCloneStates","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCloneStates;","invokestatic",205);}
case 205:{f.Push(f.Locals[10]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/game/card/Card","addCloneState","(Lforge/game/card/CardCloneStates;J)V","invokevirtual",210);}
case 210:{f.Push(f.Locals[2]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/card/Card","isStickered","()Z","invokevirtual",214);}
case 214:{f.Pc=f.Pop().Int==0?223:217;continue;}
case 217:{f.Push(f.Locals[5]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[2]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/card/Card","takeStickersFrom","(Lforge/game/card/Card;)V","invokevirtual",223);}
case 223:{f.Push(f.Locals[9]);f.Pc=225;continue;}
case 225:{f.Pc=f.Pop().Int==0?241:228;continue;}
case 228:{f.Push(f.Locals[5]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",233);}
case 233:{f.Pc=f.Pop().Int!=0?241:236;continue;}
case 236:{f.Push(f.Locals[5]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/card/Card","runFaceupCommands","()V","invokevirtual",241);}
case 241:{f.Push(f.Locals[4]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",246);}
case 246:{f.Push(f.Locals[5]);f.Pc=248;continue;}
case 248:{f.Push(JValue.R(null));f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/game/trigger/TriggerHandler","clearActiveTriggers","(Lforge/game/card/Card;Lforge/game/zone/Zone;)V","invokevirtual",252);}
case 252:{f.Push(f.Locals[4]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",257);}
case 257:{f.Push(f.Locals[5]);f.Pc=259;continue;}
case 259:{f.Push(JValue.I(0));f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerActiveTrigger","(Lforge/game/card/Card;Z)V","invokevirtual",263);}
case 263:{f.Push(f.Locals[4]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",268);}
case 268:{f.Push(f.Locals[3]);f.Pc=269;continue;}
case 269:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Merged","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Merged","Lforge/game/zone/ZoneType;"));f.Pc=272;continue;}
case 272:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",275);}
case 275:{f.Push(f.Locals[2]);f.Pc=276;continue;}
case 276:{f.Push(f.Locals[1]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",280);}
case 280:{f.StackOp("pop");f.Pc=281;continue;}
case 281:{f.Push(f.Locals[2]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[5]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"forge/game/card/Card","isTapped","()Z","invokevirtual",287);}
case 287:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",290);}
case 290:{f.Push(f.Locals[2]);f.Pc=291;continue;}
case 291:{f.Push(f.Locals[5]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/game/card/Card","isFlipped","()Z","invokevirtual",296);}
case 296:{return rt.Call(f,"forge/game/card/Card","setFlipped","(Z)V","invokevirtual",299);}
case 299:{f.Push(f.Locals[5]);f.Pc=301;continue;}
case 301:{f.Push(f.Locals[5]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/game/card/Card","getTimesMutated","()I","invokevirtual",306);}
case 306:{f.Push(JValue.I(1));f.Pc=307;continue;}
case 307:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/game/card/Card","setTimesMutated","(I)V","invokevirtual",311);}
case 311:{f.Push(f.Locals[5]);f.Pc=313;continue;}
case 313:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",316);}
case 316:{f.Push(f.Locals[5]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/game/card/Card","updateTokenView","()V","invokevirtual",321);}
case 321:{f.Push(f.Locals[2]);f.Pc=322;continue;}
case 322:{return rt.Call(f,"forge/game/card/Card","isCommander","()Z","invokevirtual",325);}
case 325:{f.Pc=f.Pop().Int==0?343:328;continue;}
case 328:{f.Push(f.Locals[2]);f.Pc=329;continue;}
case 329:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",332);}
case 332:{f.Push(f.Locals[5]);f.Pc=334;continue;}
case 334:{f.Push(f.Locals[2]);f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/game/player/Player","updateMergedCommanderInfo","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",338);}
case 338:{f.Push(f.Locals[5]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"forge/game/card/Card","updateCommanderView","()V","invokevirtual",343);}
case 343:{f.Push(f.Locals[4]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",348);}
case 348:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Mutates","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Mutates","Lforge/game/trigger/TriggerType;"));f.Pc=351;continue;}
case 351:{f.Push(f.Locals[5]);f.Pc=353;continue;}
case 353:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",356);}
case 356:{f.Push(JValue.I(0));f.Pc=357;continue;}
case 357:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",360);}
case 360:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

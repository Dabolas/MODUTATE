// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C215{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/BlockEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3065,"forge/game/ability/effects/BlockEffect","<init>","()V",1,1,1,new JHandler[]{},M3065));
c.Add(new JMethod(3066,"forge/game/ability/effects/BlockEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,14,5,new JHandler[]{},M3066));
c.Add(new JMethod(3067,"forge/game/ability/effects/BlockEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,7,3,new JHandler[]{},M3067));
}

internal static JStep M3065(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3066(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/phase/PhaseHandler","getCombat","()Lforge/game/combat/Combat;","invokevirtual",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",26);}
case 26:{f.Locals[5]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("DefinedAttacker")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?98:37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("DefinedAttacker")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",48);}
case 48:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",51);}
case 51:{f.Locals[6]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[6]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",60);}
case 60:{f.Pc=f.Pop().Int==0?98:63;continue;}
case 63:{f.Push(f.Locals[6]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",70);}
case 70:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=73;continue;}
case 73:{f.Locals[7]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[7]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/combat/Combat","isAttacking","(Lforge/game/card/Card;)Z","invokevirtual",82);}
case 82:{f.Pc=f.Pop().Int==0?95:85;continue;}
case 85:{f.Push(f.Locals[5]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[7]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",94);}
case 94:{f.StackOp("pop");f.Pc=95;continue;}
case 95:{f.Pc=53;continue;}
case 98:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=101;continue;}
case 101:{f.StackOp("dup");f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",105);}
case 105:{f.Locals[6]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("DefinedBlocker")));f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",113);}
case 113:{f.Pc=f.Pop().Int==0?183:116;continue;}
case 116:{f.Push(f.Locals[2]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("DefinedBlocker")));f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",123);}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",127);}
case 127:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",130);}
case 130:{f.Locals[7]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(f.Locals[7]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",139);}
case 139:{f.Pc=f.Pop().Int==0?183:142;continue;}
case 142:{f.Push(f.Locals[7]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",149);}
case 149:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=152;continue;}
case 152:{f.Locals[8]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(f.Locals[8]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",159);}
case 159:{f.Pc=f.Pop().Int==0?180:162;continue;}
case 162:{f.Push(f.Locals[8]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",167);}
case 167:{f.Pc=f.Pop().Int==0?180:170;continue;}
case 170:{f.Push(f.Locals[6]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[8]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",179);}
case 179:{f.StackOp("pop");f.Pc=180;continue;}
case 180:{f.Pc=132;continue;}
case 183:{f.Push(f.Locals[5]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",190);}
case 190:{f.Pc=f.Pop().Int==0?203:193;continue;}
case 193:{f.Push(f.Locals[6]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",200);}
case 200:{f.Pc=f.Pop().Int!=0?204:203;continue;}
case 203:{return JStep.ReturnVoid;}
case 204:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",207);}
case 207:{f.Locals[7]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(f.Locals[5]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",216);}
case 216:{f.Locals[8]=f.Pop();f.Pc=218;continue;}
case 218:{f.Push(f.Locals[8]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",225);}
case 225:{f.Pc=f.Pop().Int==0?545:228;continue;}
case 228:{f.Push(f.Locals[8]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",235);}
case 235:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=238;continue;}
case 238:{f.Locals[9]=f.Pop();f.Pc=240;continue;}
case 240:{f.Push(f.Locals[4]);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[9]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/game/combat/Combat","isBlocked","(Lforge/game/card/Card;)Z","invokevirtual",247);}
case 247:{f.Locals[10]=f.Pop();f.Pc=249;continue;}
case 249:{f.Push(f.Locals[6]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",256);}
case 256:{f.Locals[11]=f.Pop();f.Pc=258;continue;}
case 258:{f.Push(f.Locals[11]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",265);}
case 265:{f.Pc=f.Pop().Int==0?422:268;continue;}
case 268:{f.Push(f.Locals[11]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",275);}
case 275:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=278;continue;}
case 278:{f.Locals[12]=f.Pop();f.Pc=280;continue;}
case 280:{f.Push(f.Locals[4]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[12]);f.Pc=284;continue;}
case 284:{f.Push(f.Locals[9]);f.Pc=286;continue;}
case 286:{return rt.Call(f,"forge/game/combat/Combat","isBlocking","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokevirtual",289);}
case 289:{f.Pc=f.Pop().Int==0?295:292;continue;}
case 292:{f.Pc=258;continue;}
case 295:{f.Push(f.Locals[4]);f.Pc=297;continue;}
case 297:{f.Push(f.Locals[9]);f.Pc=299;continue;}
case 299:{f.Push(f.Locals[12]);f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/game/combat/Combat","addBlocker","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",304);}
case 304:{f.Push(f.Locals[4]);f.Pc=306;continue;}
case 306:{f.Push(f.Locals[12]);f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/game/combat/Combat","orderAttackersForDamageAssignment","(Lforge/game/card/Card;)V","invokevirtual",311);}
case 311:{f.Push(f.Locals[12]);f.Pc=313;continue;}
case 313:{f.Push(f.Locals[9]);f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",318);}
case 318:{return rt.Call(f,"forge/game/card/Card","addBlockedThisTurn","(Lforge/game/card/Card;)V","invokevirtual",321);}
case 321:{f.Push(f.Locals[9]);f.Pc=323;continue;}
case 323:{f.Push(f.Locals[12]);f.Pc=325;continue;}
case 325:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",328);}
case 328:{return rt.Call(f,"forge/game/card/Card","addBlockedByThisTurn","(Lforge/game/card/Card;)V","invokevirtual",331);}
case 331:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",334);}
case 334:{f.Locals[13]=f.Pop();f.Pc=336;continue;}
case 336:{f.Push(f.Locals[13]);f.Pc=338;continue;}
case 338:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"));f.Pc=341;continue;}
case 341:{f.Push(f.Locals[9]);f.Pc=343;continue;}
case 343:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",348);}
case 348:{f.StackOp("pop");f.Pc=349;continue;}
case 349:{f.Push(f.Locals[13]);f.Pc=351;continue;}
case 351:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Blocker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Blocker","Lforge/game/ability/AbilityKey;"));f.Pc=354;continue;}
case 354:{f.Push(f.Locals[12]);f.Pc=356;continue;}
case 356:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",361);}
case 361:{f.StackOp("pop");f.Pc=362;continue;}
case 362:{f.Push(f.Locals[3]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",366);}
case 366:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AttackerBlockedByCreature","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AttackerBlockedByCreature","Lforge/game/trigger/TriggerType;"));f.Pc=369;continue;}
case 369:{f.Push(f.Locals[13]);f.Pc=371;continue;}
case 371:{f.Push(JValue.I(0));f.Pc=372;continue;}
case 372:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",375);}
case 375:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",378);}
case 378:{f.Locals[13]=f.Pop();f.Pc=380;continue;}
case 380:{f.Push(f.Locals[13]);f.Pc=382;continue;}
case 382:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Blocker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Blocker","Lforge/game/ability/AbilityKey;"));f.Pc=385;continue;}
case 385:{f.Push(f.Locals[12]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",392);}
case 392:{f.StackOp("pop");f.Pc=393;continue;}
case 393:{f.Push(f.Locals[13]);f.Pc=395;continue;}
case 395:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"));f.Pc=398;continue;}
case 398:{f.Push(f.Locals[9]);f.Pc=400;continue;}
case 400:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",405);}
case 405:{f.StackOp("pop");f.Pc=406;continue;}
case 406:{f.Push(f.Locals[3]);f.Pc=407;continue;}
case 407:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",410);}
case 410:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Blocks","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Blocks","Lforge/game/trigger/TriggerType;"));f.Pc=413;continue;}
case 413:{f.Push(f.Locals[13]);f.Pc=415;continue;}
case 415:{f.Push(JValue.I(0));f.Pc=416;continue;}
case 416:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",419);}
case 419:{f.Pc=258;continue;}
case 422:{f.Push(f.Locals[9]);f.Pc=424;continue;}
case 424:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",427);}
case 427:{f.Push(JValue.I(1));f.Pc=428;continue;}
case 428:{return rt.Call(f,"forge/game/card/CardDamageHistory","setCreatureGotBlockedThisCombat","(Z)V","invokevirtual",431);}
case 431:{f.Push(f.Locals[10]);f.Pc=433;continue;}
case 433:{f.Pc=f.Pop().Int!=0?542:436;continue;}
case 436:{f.Push(f.Locals[7]);f.Pc=438;continue;}
case 438:{f.Push(f.Locals[9]);f.Pc=440;continue;}
case 440:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",445);}
case 445:{f.StackOp("pop");f.Pc=446;continue;}
case 446:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",449);}
case 449:{f.Locals[11]=f.Pop();f.Pc=451;continue;}
case 451:{f.Push(f.Locals[11]);f.Pc=453;continue;}
case 453:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"));f.Pc=456;continue;}
case 456:{f.Push(f.Locals[9]);f.Pc=458;continue;}
case 458:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",463);}
case 463:{f.StackOp("pop");f.Pc=464;continue;}
case 464:{f.Push(f.Locals[11]);f.Pc=466;continue;}
case 466:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Blockers","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Blockers","Lforge/game/ability/AbilityKey;"));f.Pc=469;continue;}
case 469:{f.Push(f.Locals[6]);f.Pc=471;continue;}
case 471:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",476);}
case 476:{f.StackOp("pop");f.Pc=477;continue;}
case 477:{f.Push(f.Locals[11]);f.Pc=479;continue;}
case 479:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Defender","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Defender","Lforge/game/ability/AbilityKey;"));f.Pc=482;continue;}
case 482:{f.Push(f.Locals[4]);f.Pc=484;continue;}
case 484:{f.Push(f.Locals[9]);f.Pc=486;continue;}
case 486:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;","invokevirtual",489);}
case 489:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",494);}
case 494:{f.StackOp("pop");f.Pc=495;continue;}
case 495:{f.Push(f.Locals[11]);f.Pc=497;continue;}
case 497:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"));f.Pc=500;continue;}
case 500:{f.Push(f.Locals[4]);f.Pc=502;continue;}
case 502:{f.Push(f.Locals[9]);f.Pc=504;continue;}
case 504:{return rt.Call(f,"forge/game/combat/Combat","getDefenderPlayerByAttacker","(Lforge/game/card/Card;)Lforge/game/player/Player;","invokevirtual",507);}
case 507:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",512);}
case 512:{f.StackOp("pop");f.Pc=513;continue;}
case 513:{f.Push(f.Locals[3]);f.Pc=514;continue;}
case 514:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",517);}
case 517:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AttackerBlocked","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AttackerBlocked","Lforge/game/trigger/TriggerType;"));f.Pc=520;continue;}
case 520:{f.Push(f.Locals[11]);f.Pc=522;continue;}
case 522:{f.Push(JValue.I(0));f.Pc=523;continue;}
case 523:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",526);}
case 526:{f.Push(f.Locals[4]);f.Pc=528;continue;}
case 528:{f.Push(f.Locals[9]);f.Pc=530;continue;}
case 530:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=533;continue;}
case 533:{f.StackOp("dup");f.Pc=534;continue;}
case 534:{f.Push(f.Locals[6]);f.Pc=536;continue;}
case 536:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",539);}
case 539:{return rt.Call(f,"forge/game/combat/Combat","orderBlockersForDamageAssignment","(Lforge/game/card/Card;Lforge/game/card/CardCollection;)V","invokevirtual",542);}
case 542:{f.Pc=218;continue;}
case 545:{f.Push(f.Locals[7]);f.Pc=547;continue;}
case 547:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",552);}
case 552:{f.Pc=f.Pop().Int!=0?586:555;continue;}
case 555:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",558);}
case 558:{f.Locals[8]=f.Pop();f.Pc=560;continue;}
case 560:{f.Push(f.Locals[8]);f.Pc=562;continue;}
case 562:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"));f.Pc=565;continue;}
case 565:{f.Push(f.Locals[7]);f.Pc=567;continue;}
case 567:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",572);}
case 572:{f.StackOp("pop");f.Pc=573;continue;}
case 573:{f.Push(f.Locals[3]);f.Pc=574;continue;}
case 574:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",577);}
case 577:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AttackerBlockedOnce","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AttackerBlockedOnce","Lforge/game/trigger/TriggerType;"));f.Pc=580;continue;}
case 580:{f.Push(f.Locals[8]);f.Pc=582;continue;}
case 582:{f.Push(JValue.I(0));f.Pc=583;continue;}
case 583:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",586);}
case 586:{f.Push(f.Locals[3]);f.Pc=587;continue;}
case 587:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",590);}
case 590:{f.Push(f.Locals[3]);f.Pc=591;continue;}
case 591:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCombatChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCombatChanged")));f.Pc=594;continue;}
case 594:{f.StackOp("dup");f.Pc=595;continue;}
case 595:{return rt.Call(f,"forge/game/event/GameEventCombatChanged","<init>","()V","invokespecial",598);}
case 598:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",601);}
case 601:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3067(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("DefinedAttacker")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?81:25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",29);}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("DefinedAttacker")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",35);}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",39);}
case 39:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",42);}
case 42:{f.Locals[4]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[4]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",51);}
case 51:{f.Pc=f.Pop().Int==0?81:54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",61);}
case 61:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=64;continue;}
case 64:{f.Locals[5]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[5]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",72);}
case 72:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",77);}
case 77:{f.StackOp("pop");f.Pc=78;continue;}
case 78:{f.Pc=44;continue;}
case 81:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=84;continue;}
case 84:{f.StackOp("dup");f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",88);}
case 88:{f.Locals[4]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.String("DefinedBlocker")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Int==0?156:99;continue;}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",103);}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String("DefinedBlocker")));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",109);}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",113);}
case 113:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",116);}
case 116:{f.Locals[5]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[5]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",125);}
case 125:{f.Pc=f.Pop().Int==0?156:128;continue;}
case 128:{f.Push(f.Locals[5]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",135);}
case 135:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=138;continue;}
case 138:{f.Locals[6]=f.Pop();f.Pc=140;continue;}
case 140:{f.Push(f.Locals[4]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[6]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",147);}
case 147:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",152);}
case 152:{f.StackOp("pop");f.Pc=153;continue;}
case 153:{f.Pc=118;continue;}
case 156:{f.Push(f.Locals[2]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[4]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",162);}
case 162:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",165);}
case 165:{f.Push(JValue.R(rt.String(" block ")));f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",170);}
case 170:{f.Push(f.Locals[3]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",174);}
case 174:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",177);}
case 177:{f.StackOp("pop");f.Pc=178;continue;}
case 178:{f.Push(f.Locals[2]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",182);}
case 182:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

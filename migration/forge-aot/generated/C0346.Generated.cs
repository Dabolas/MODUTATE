// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C346{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/PermanentEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3534,"forge/game/ability/effects/PermanentEffect","<init>","()V",1,1,1,new JHandler[]{},M3534));
c.Add(new JMethod(3535,"forge/game/ability/effects/PermanentEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,9,6,new JHandler[]{},M3535));
}

internal static JStep M3534(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3535(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",13);}
case 13:{f.Locals[4]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",21);}
case 21:{f.Locals[5]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int!=0?37:30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/Card","wasCast","()Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?49:37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSneak","()Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int==0?49:44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",49);}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",53);}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/GameAction","moveToPlay","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",60);}
case 60:{f.Locals[6]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[6]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/spellability/SpellAbility","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",68);}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int!=0?83:75;continue;}
case 75:{f.Push(f.Locals[6]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/card/Card","wasCast","()Z","invokevirtual",80);}
case 80:{f.Pc=f.Pop().Int==0?309:83;continue;}
case 83:{f.Push(f.Locals[6]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",88);}
case 88:{f.Pc=f.Pop().Int==0?309:91;continue;}
case 91:{f.Push(f.Locals[1]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDash","()Z","invokevirtual",95);}
case 95:{f.Pc=f.Pop().Int==0?137:98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String("Hand")));f.Pc=101;continue;}
case 101:{f.Push(JValue.I(1));f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/Card;",f.Pop().Int)));f.Pc=105;continue;}
case 105:{f.StackOp("dup");f.Pc=106;continue;}
case 106:{f.Push(JValue.I(0));f.Pc=107;continue;}
case 107:{f.Push(f.Locals[6]);f.Pc=109;continue;}
case 109:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=110;continue;}
case 110:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",113);}
case 113:{return rt.Call(f,"forge/game/ability/effects/PermanentEffect","registerDelayedTrigger","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/Iterable;)V","invokestatic",116);}
case 116:{f.Push(f.Locals[6]);f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("EndOfTurnLeavePlay")));f.Pc=120;continue;}
case 120:{f.Push(JValue.R(rt.String("Dash")));f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/util/Collections","singletonMap","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;","invokestatic",125);}
case 125:{f.Push(f.Locals[6]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",130);}
case 130:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",133);}
case 133:{f.Push(JValue.L(0));f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/card/Card","addChangedSVars","(Ljava/util/Map;JJ)V","invokevirtual",137);}
case 137:{f.Push(f.Locals[1]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/spellability/SpellAbility","isBlitz","()Z","invokevirtual",141);}
case 141:{f.Pc=f.Pop().Int==0?183:144;continue;}
case 144:{f.Push(f.Locals[1]);f.Pc=145;continue;}
case 145:{f.Push(JValue.R(rt.String("Sacrifice")));f.Pc=147;continue;}
case 147:{f.Push(JValue.I(1));f.Pc=148;continue;}
case 148:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/Card;",f.Pop().Int)));f.Pc=151;continue;}
case 151:{f.StackOp("dup");f.Pc=152;continue;}
case 152:{f.Push(JValue.I(0));f.Pc=153;continue;}
case 153:{f.Push(f.Locals[6]);f.Pc=155;continue;}
case 155:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=156;continue;}
case 156:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",159);}
case 159:{return rt.Call(f,"forge/game/ability/effects/PermanentEffect","registerDelayedTrigger","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/Iterable;)V","invokestatic",162);}
case 162:{f.Push(f.Locals[6]);f.Pc=164;continue;}
case 164:{f.Push(JValue.R(rt.String("EndOfTurnLeavePlay")));f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.String("Blitz")));f.Pc=168;continue;}
case 168:{return rt.Call(f,"java/util/Collections","singletonMap","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;","invokestatic",171);}
case 171:{f.Push(f.Locals[6]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",176);}
case 176:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",179);}
case 179:{f.Push(JValue.L(0));f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/card/Card","addChangedSVars","(Ljava/util/Map;JJ)V","invokevirtual",183);}
case 183:{f.Push(f.Locals[1]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/spellability/SpellAbility","isWarp","()Z","invokevirtual",187);}
case 187:{f.Pc=f.Pop().Int==0?229:190;continue;}
case 190:{f.Push(f.Locals[1]);f.Pc=191;continue;}
case 191:{f.Push(JValue.R(rt.String("Exile")));f.Pc=193;continue;}
case 193:{f.Push(JValue.I(1));f.Pc=194;continue;}
case 194:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/Card;",f.Pop().Int)));f.Pc=197;continue;}
case 197:{f.StackOp("dup");f.Pc=198;continue;}
case 198:{f.Push(JValue.I(0));f.Pc=199;continue;}
case 199:{f.Push(f.Locals[6]);f.Pc=201;continue;}
case 201:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=202;continue;}
case 202:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",205);}
case 205:{return rt.Call(f,"forge/game/ability/effects/PermanentEffect","registerDelayedTrigger","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/Iterable;)V","invokestatic",208);}
case 208:{f.Push(f.Locals[6]);f.Pc=210;continue;}
case 210:{f.Push(JValue.R(rt.String("EndOfTurnLeavePlay")));f.Pc=212;continue;}
case 212:{f.Push(JValue.R(rt.String("Warp")));f.Pc=214;continue;}
case 214:{return rt.Call(f,"java/util/Collections","singletonMap","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;","invokestatic",217);}
case 217:{f.Push(f.Locals[6]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",222);}
case 222:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",225);}
case 225:{f.Push(JValue.L(0));f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/card/Card","addChangedSVars","(Ljava/util/Map;JJ)V","invokevirtual",229);}
case 229:{f.Push(f.Locals[1]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSneak","()Z","invokevirtual",233);}
case 233:{f.Pc=f.Pop().Int==0?309:236;continue;}
case 236:{f.Push(f.Locals[6]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",241);}
case 241:{f.Pc=f.Pop().Int==0?309:244;continue;}
case 244:{f.Push(f.Locals[1]);f.Pc=245;continue;}
case 245:{f.Push(JValue.R(rt.String("Returned")));f.Pc=247;continue;}
case 247:{f.Push(JValue.I(1));f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPaidList","(Ljava/lang/String;Z)Lforge/game/card/CardCollection;","invokevirtual",251);}
case 251:{return rt.Call(f,"forge/game/card/CardCollection","getFirst","()Ljava/lang/Object;","invokevirtual",254);}
case 254:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=257;continue;}
case 257:{f.Locals[7]=f.Pop();f.Pc=259;continue;}
case 259:{f.Push(f.Locals[3]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",263);}
case 263:{f.Push(f.Locals[7]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;","invokevirtual",268);}
case 268:{f.Locals[8]=f.Pop();f.Pc=270;continue;}
case 270:{f.Push(f.Locals[3]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",274);}
case 274:{f.Push(f.Locals[6]);f.Pc=276;continue;}
case 276:{f.Push(f.Locals[8]);f.Pc=278;continue;}
case 278:{return rt.Call(f,"forge/game/combat/Combat","addAttacker","(Lforge/game/card/Card;Lforge/game/GameEntity;)V","invokevirtual",281);}
case 281:{f.Push(f.Locals[3]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",285);}
case 285:{f.Push(f.Locals[6]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttacker","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",290);}
case 290:{f.Push(JValue.I(0));f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/game/combat/AttackingBand","setBlocked","(Z)V","invokevirtual",294);}
case 294:{f.Push(f.Locals[3]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",298);}
case 298:{f.Push(f.Locals[3]);f.Pc=299;continue;}
case 299:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCombatChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCombatChanged")));f.Pc=302;continue;}
case 302:{f.StackOp("dup");f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/game/event/GameEventCombatChanged","<init>","()V","invokespecial",306);}
case 306:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",309);}
case 309:{f.Push(f.Locals[5]);f.Pc=311;continue;}
case 311:{f.Push(f.Locals[3]);f.Pc=312;continue;}
case 312:{f.Push(f.Locals[1]);f.Pc=313;continue;}
case 313:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",316);}
case 316:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

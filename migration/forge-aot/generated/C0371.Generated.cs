// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C371{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/RemoveFromCombatEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3623,"forge/game/ability/effects/RemoveFromCombatEffect","<init>","()V",1,1,1,new JHandler[]{},M3623));
c.Add(new JMethod(3624,"forge/game/ability/effects/RemoveFromCombatEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,3,2,new JHandler[]{},M3624));
c.Add(new JMethod(3625,"forge/game/ability/effects/RemoveFromCombatEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,16,3,new JHandler[]{},M3625));
}

internal static JStep M3623(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3624(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Remove ")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/ability/effects/RemoveFromCombatEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",20);}
case 20:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",23);}
case 23:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String(" from combat.")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",33);}
case 33:{f.StackOp("pop");f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",38);}
case 38:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3625(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("RememberRemovedFromCombat")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",16);}
case 16:{f.Locals[4]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",22);}
case 22:{return rt.Call(f,"forge/game/phase/PhaseHandler","getCombat","()Lforge/game/combat/Combat;","invokevirtual",25);}
case 25:{f.Locals[5]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/ability/effects/RemoveFromCombatEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",31);}
case 31:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",34);}
case 34:{f.Locals[6]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[6]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",43);}
case 43:{f.Pc=f.Pop().Int==0?287:46;continue;}
case 46:{f.Push(f.Locals[6]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",53);}
case 53:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=56;continue;}
case 56:{f.Locals[7]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{f.Pc=f.Pop().Reference==null?36:63;continue;}
case 63:{f.Push(f.Locals[7]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",68);}
case 68:{f.Pc=f.Pop().Int!=0?74:71;continue;}
case 71:{f.Pc=36;continue;}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[7]);f.Pc=77;continue;}
case 77:{f.Push(JValue.R(null));f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",81);}
case 81:{f.Locals[8]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[8]);f.Pc=85;continue;}
case 85:{f.Pc=f.Pop().Reference==null?36:88;continue;}
case 88:{f.Push(f.Locals[7]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[8]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",95);}
case 95:{f.Pc=f.Pop().Int!=0?101:98;continue;}
case 98:{f.Pc=36;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String("UnblockCreaturesBlockedOnlyBy")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Int==0?253:110;continue;}
case 110:{f.Push(f.Locals[1]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",114);}
case 114:{f.Push(f.Locals[1]);f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.String("UnblockCreaturesBlockedOnlyBy")));f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",120);}
case 120:{f.Push(f.Locals[1]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",124);}
case 124:{f.Locals[9]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[9]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int!=0?253:134;continue;}
case 134:{f.Push(f.Locals[5]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[9]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/card/CardCollection","getFirst","()Ljava/lang/Object;","invokevirtual",141);}
case 141:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/combat/Combat","getAttackersBlockedBy","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",147);}
case 147:{f.Locals[10]=f.Pop();f.Pc=149;continue;}
case 149:{f.Push(f.Locals[10]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",154);}
case 154:{f.Locals[11]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[11]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",163);}
case 163:{f.Pc=f.Pop().Int==0?253:166;continue;}
case 166:{f.Push(f.Locals[11]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",173);}
case 173:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=176;continue;}
case 176:{f.Locals[12]=f.Pop();f.Pc=178;continue;}
case 178:{f.Push(JValue.I(1));f.Pc=179;continue;}
case 179:{f.Locals[13]=f.Pop();f.Pc=181;continue;}
case 181:{f.Push(f.Locals[5]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[12]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",188);}
case 188:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",191);}
case 191:{f.Locals[14]=f.Pop();f.Pc=193;continue;}
case 193:{f.Push(f.Locals[14]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",200);}
case 200:{f.Pc=f.Pop().Int==0?237:203;continue;}
case 203:{f.Push(f.Locals[14]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",210);}
case 210:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=213;continue;}
case 213:{f.Locals[15]=f.Pop();f.Pc=215;continue;}
case 215:{f.Push(f.Locals[15]);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[9]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/card/CardCollection","getFirst","()Ljava/lang/Object;","invokevirtual",222);}
case 222:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",225);}
case 225:{f.Pc=f.Pop().Int!=0?234:228;continue;}
case 228:{f.Push(JValue.I(0));f.Pc=229;continue;}
case 229:{f.Locals[13]=f.Pop();f.Pc=231;continue;}
case 231:{f.Pc=237;continue;}
case 234:{f.Pc=193;continue;}
case 237:{f.Push(f.Locals[13]);f.Pc=239;continue;}
case 239:{f.Pc=f.Pop().Int==0?250:242;continue;}
case 242:{f.Push(f.Locals[5]);f.Pc=244;continue;}
case 244:{f.Push(f.Locals[12]);f.Pc=246;continue;}
case 246:{f.Push(JValue.I(0));f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/combat/Combat","setBlocked","(Lforge/game/card/Card;Z)V","invokevirtual",250);}
case 250:{f.Pc=156;continue;}
case 253:{f.Push(f.Locals[3]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",257);}
case 257:{f.Push(f.Locals[8]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"forge/game/combat/Combat","saveLKI","(Lforge/game/card/Card;)Lforge/game/combat/CombatLki;","invokevirtual",262);}
case 262:{f.StackOp("pop");f.Pc=263;continue;}
case 263:{f.Push(f.Locals[5]);f.Pc=265;continue;}
case 265:{f.Push(f.Locals[8]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"forge/game/combat/Combat","removeFromCombat","(Lforge/game/card/Card;)V","invokevirtual",270);}
case 270:{f.Push(f.Locals[4]);f.Pc=272;continue;}
case 272:{f.Pc=f.Pop().Int==0?284:275;continue;}
case 275:{f.Push(f.Locals[1]);f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",279);}
case 279:{f.Push(f.Locals[8]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",284);}
case 284:{f.Pc=36;continue;}
case 287:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

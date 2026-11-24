// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C194{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/AddPhaseEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(2996,"forge/game/ability/effects/AddPhaseEffect","<init>","()V",1,1,1,new JHandler[]{},M2996));
c.Add(new JMethod(2997,"forge/game/ability/effects/AddPhaseEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,17,4,new JHandler[]{},M2997));
}

internal static JStep M2996(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2997(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/Player","isPhasesReversed","()Z","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",20);}
case 20:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",23);}
case 23:{f.Locals[5]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[5]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPhase","()Lforge/game/phase/PhaseType;","invokevirtual",30);}
case 30:{f.Locals[6]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String("BeforeFirstPostCombatMainEnd")));f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int==0?50:41;continue;}
case 41:{f.Push(f.Locals[5]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/phase/PhaseHandler","beforeFirstPostCombatMainEnd","()Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int!=0?50:49;continue;}
case 49:{return JStep.ReturnVoid;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("AfterPhase")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?73:59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("AfterPhase")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",65);}
case 65:{return rt.Call(f,"forge/game/phase/PhaseType","smartValueOf","(Ljava/lang/String;)Lforge/game/phase/PhaseType;","invokestatic",68);}
case 68:{f.Locals[7]=f.Pop();f.Pc=70;continue;}
case 70:{f.Pc=77;continue;}
case 73:{f.Push(f.Locals[6]);f.Pc=75;continue;}
case 75:{f.Locals[7]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[7]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[4]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/phase/PhaseType","getNext","(Lforge/game/phase/PhaseType;Z)Lforge/game/phase/PhaseType;","invokestatic",84);}
case 84:{f.Locals[8]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String("FollowedBy")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",92);}
case 92:{return rt.Call(f,"forge/game/phase/PhaseType","smartValueOf","(Ljava/lang/String;)Lforge/game/phase/PhaseType;","invokestatic",95);}
case 95:{f.Locals[9]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("ExtraPhase")));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",103);}
case 103:{f.Locals[10]=f.Pop();f.Pc=105;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("NumPhases")));f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",111);}
case 111:{f.Pc=f.Pop().Int==0?128:114;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String("NumPhases")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",121);}
case 121:{f.Push(f.Locals[1]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",125);}
case 125:{f.Pc=129;continue;}
case 128:{f.Push(JValue.I(1));f.Pc=129;continue;}
case 129:{f.Locals[11]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[11]);f.Pc=133;continue;}
case 133:{f.Locals[12]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[12]);f.Pc=137;continue;}
case 137:{f.Pc=f.Pop().Int<=0?335:140;continue;}
case 140:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=143;continue;}
case 143:{f.StackOp("dup");f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",147);}
case 147:{f.Locals[13]=f.Pop();f.Pc=149;continue;}
case 149:{f.Push(f.Locals[10]);f.Pc=151;continue;}
case 151:{f.Push(JValue.R(rt.String("Beginning")));f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",156);}
case 156:{f.Pc=f.Pop().Int==0?182:159;continue;}
case 159:{f.Push(f.Locals[13]);f.Pc=161;continue;}
case 161:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","PHASE_GROUPS","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","PHASE_GROUPS","Ljava/util/List;"));f.Pc=164;continue;}
case 164:{f.Push(JValue.I(0));f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",170);}
case 170:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",178);}
case 178:{f.StackOp("pop");f.Pc=179;continue;}
case 179:{f.Pc=228;continue;}
case 182:{f.Push(f.Locals[10]);f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String("Combat")));f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",189);}
case 189:{f.Pc=f.Pop().Int==0?215:192;continue;}
case 192:{f.Push(f.Locals[13]);f.Pc=194;continue;}
case 194:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","PHASE_GROUPS","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","PHASE_GROUPS","Ljava/util/List;"));f.Pc=197;continue;}
case 197:{f.Push(JValue.I(2));f.Pc=198;continue;}
case 198:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",203);}
case 203:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",211);}
case 211:{f.StackOp("pop");f.Pc=212;continue;}
case 212:{f.Pc=228;continue;}
case 215:{f.Push(f.Locals[13]);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[10]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/phase/PhaseType","smartValueOf","(Ljava/lang/String;)Lforge/game/phase/PhaseType;","invokestatic",222);}
case 222:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",227);}
case 227:{f.StackOp("pop");f.Pc=228;continue;}
case 228:{f.Push(f.Locals[9]);f.Pc=230;continue;}
case 230:{f.Pc=f.Pop().Reference==null?243:233;continue;}
case 233:{f.Push(f.Locals[13]);f.Pc=235;continue;}
case 235:{f.Push(f.Locals[9]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",242);}
case 242:{f.StackOp("pop");f.Pc=243;continue;}
case 243:{f.Push(f.Locals[5]);f.Pc=245;continue;}
case 245:{f.Push(f.Locals[7]);f.Pc=247;continue;}
case 247:{f.Push(f.Locals[13]);f.Pc=249;continue;}
case 249:{f.Push(f.Locals[8]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/phase/PhaseHandler","addExtraPhase","(Lforge/game/phase/PhaseType;Ljava/util/List;Lforge/game/phase/PhaseType;)Lforge/game/phase/ExtraPhase;","invokevirtual",254);}
case 254:{f.Locals[14]=f.Pop();f.Pc=256;continue;}
case 256:{f.Push(f.Locals[1]);f.Pc=257;continue;}
case 257:{f.Push(JValue.R(rt.String("ExtraPhaseDelayedTrigger")));f.Pc=259;continue;}
case 259:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",262);}
case 262:{f.Pc=f.Pop().Int==0?329:265;continue;}
case 265:{f.Push(f.Locals[1]);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[1]);f.Pc=267;continue;}
case 267:{f.Push(JValue.R(rt.String("ExtraPhaseDelayedTrigger")));f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",272);}
case 272:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",275);}
case 275:{f.Push(f.Locals[2]);f.Pc=276;continue;}
case 276:{f.Push(JValue.I(1));f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",280);}
case 280:{f.Locals[15]=f.Pop();f.Pc=282;continue;}
case 282:{f.Push(f.Locals[1]);f.Pc=283;continue;}
case 283:{f.Push(f.Locals[1]);f.Pc=284;continue;}
case 284:{f.Push(JValue.R(rt.String("ExtraPhaseDelayedTriggerExcute")));f.Pc=286;continue;}
case 286:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",289);}
case 289:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",292);}
case 292:{f.Push(f.Locals[2]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",296);}
case 296:{f.Locals[16]=f.Pop();f.Pc=298;continue;}
case 298:{f.Push(f.Locals[16]);f.Pc=300;continue;}
case 300:{f.Push(f.Locals[3]);f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",304);}
case 304:{f.Push(f.Locals[15]);f.Pc=306;continue;}
case 306:{f.Push(f.Locals[16]);f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",311);}
case 311:{f.Push(f.Locals[15]);f.Pc=313;continue;}
case 313:{f.Push(f.Locals[1]);f.Pc=314;continue;}
case 314:{f.Push(f.Locals[2]);f.Pc=315;continue;}
case 315:{f.Push(JValue.I(1));f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",319);}
case 319:{return rt.Call(f,"forge/game/trigger/Trigger","setSpawningAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",322);}
case 322:{f.Push(f.Locals[14]);f.Pc=324;continue;}
case 324:{f.Push(f.Locals[15]);f.Pc=326;continue;}
case 326:{return rt.Call(f,"forge/game/phase/ExtraPhase","addTrigger","(Lforge/game/trigger/Trigger;)V","invokevirtual",329);}
case 329:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(-1)));f.Pc=332;continue;}
case 332:{f.Pc=135;continue;}
case 335:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C406{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/SwitchBlockEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3748,"forge/game/ability/effects/SwitchBlockEffect","<init>","()V",1,1,1,new JHandler[]{},M3748));
c.Add(new JMethod(3749,"forge/game/ability/effects/SwitchBlockEffect","runTriggers","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/card/Card;)V",2,5,4,new JHandler[]{},M3749));
c.Add(new JMethod(3750,"forge/game/ability/effects/SwitchBlockEffect","recordBlock","(Lforge/game/card/Card;Lforge/game/card/Card;)V",2,3,2,new JHandler[]{},M3750));
c.Add(new JMethod(3751,"forge/game/ability/effects/SwitchBlockEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,16,4,new JHandler[]{},M3751));
}

internal static JStep M3748(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3749(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",3);}
case 3:{f.Locals[4]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[4]);f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",16);}
case 16:{f.StackOp("pop");f.Pc=17;continue;}
case 17:{f.Push(f.Locals[4]);f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",28);}
case 28:{f.StackOp("pop");f.Pc=29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Blocker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Blocker","Lforge/game/ability/AbilityKey;"));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",40);}
case 40:{f.StackOp("pop");f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",45);}
case 45:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AttackerBlockedByCreature","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AttackerBlockedByCreature","Lforge/game/trigger/TriggerType;"));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",54);}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",58);}
case 58:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Blocks","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Blocks","Lforge/game/trigger/TriggerType;"));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[4]);f.Pc=63;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",67);}
case 67:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3750(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/game/card/Card","addBlockedThisTurn","(Lforge/game/card/Card;)V","invokevirtual",8);}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",13);}
case 13:{return rt.Call(f,"forge/game/card/Card","addBlockedByThisTurn","(Lforge/game/card/Card;)V","invokevirtual",16);}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3751(JRuntime rt,JFrame f)
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
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{f.Locals[5]=f.Pop();f.Pc=22;continue;}
case 22:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",29);}
case 29:{f.Locals[6]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("DefinedAttacker")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?118:40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("DefinedAttacker")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",46);}
case 46:{f.Locals[7]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[7]);f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("Targeted")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int==0?61:58;continue;}
case 58:{f.Push(JValue.I(1));f.Pc=59;continue;}
case 59:{f.Locals[5]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[7]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",68);}
case 68:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",71);}
case 71:{f.Locals[8]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[8]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",80);}
case 80:{f.Pc=f.Pop().Int==0?118:83;continue;}
case 83:{f.Push(f.Locals[8]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",90);}
case 90:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=93;continue;}
case 93:{f.Locals[9]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[4]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[9]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/combat/Combat","isAttacking","(Lforge/game/card/Card;)Z","invokevirtual",102);}
case 102:{f.Pc=f.Pop().Int==0?115:105;continue;}
case 105:{f.Push(f.Locals[6]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[9]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",114);}
case 114:{f.StackOp("pop");f.Pc=115;continue;}
case 115:{f.Pc=73;continue;}
case 118:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=121;continue;}
case 121:{f.StackOp("dup");f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",125);}
case 125:{f.Locals[7]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{f.Push(JValue.R(rt.String("DefinedBlocker")));f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",133);}
case 133:{f.Pc=f.Pop().Int==0?214:136;continue;}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{f.Push(JValue.R(rt.String("DefinedBlocker")));f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",142);}
case 142:{f.Locals[8]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[8]);f.Pc=146;continue;}
case 146:{f.Push(JValue.R(rt.String("Targeted")));f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",151);}
case 151:{f.Pc=f.Pop().Int==0?157:154;continue;}
case 154:{f.Push(JValue.I(0));f.Pc=155;continue;}
case 155:{f.Locals[5]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(f.Locals[2]);f.Pc=158;continue;}
case 158:{f.Push(f.Locals[8]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[1]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",164);}
case 164:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",167);}
case 167:{f.Locals[9]=f.Pop();f.Pc=169;continue;}
case 169:{f.Push(f.Locals[9]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",176);}
case 176:{f.Pc=f.Pop().Int==0?214:179;continue;}
case 179:{f.Push(f.Locals[9]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",186);}
case 186:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=189;continue;}
case 189:{f.Locals[10]=f.Pop();f.Pc=191;continue;}
case 191:{f.Push(f.Locals[4]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[10]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/combat/Combat","isBlocking","(Lforge/game/card/Card;)Z","invokevirtual",198);}
case 198:{f.Pc=f.Pop().Int==0?211:201;continue;}
case 201:{f.Push(f.Locals[7]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[10]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",210);}
case 210:{f.StackOp("pop");f.Pc=211;continue;}
case 211:{f.Pc=169;continue;}
case 214:{f.Push(f.Locals[6]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",221);}
case 221:{f.Pc=f.Pop().Int!=0?234:224;continue;}
case 224:{f.Push(f.Locals[7]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",231);}
case 231:{f.Pc=f.Pop().Int==0?235:234;continue;}
case 234:{return JStep.ReturnVoid;}
case 235:{f.Push(f.Locals[1]);f.Pc=236;continue;}
case 236:{f.Push(JValue.R(rt.String("RemoveFromCombat")));f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",241);}
case 241:{f.Locals[8]=f.Pop();f.Pc=243;continue;}
case 243:{f.Push(f.Locals[5]);f.Pc=245;continue;}
case 245:{f.Pc=f.Pop().Int==0?713:248;continue;}
case 248:{f.Push(f.Locals[6]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",255);}
case 255:{f.Push(JValue.I(1));f.Pc=256;continue;}
case 256:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?260:259;continue;}
case 259:{return JStep.ReturnVoid;}
case 260:{f.Push(f.Locals[6]);f.Pc=262;continue;}
case 262:{f.Push(JValue.I(0));f.Pc=263;continue;}
case 263:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",268);}
case 268:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=271;continue;}
case 271:{f.Locals[9]=f.Pop();f.Pc=273;continue;}
case 273:{f.Push(f.Locals[6]);f.Pc=275;continue;}
case 275:{f.Push(JValue.I(1));f.Pc=276;continue;}
case 276:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",281);}
case 281:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=284;continue;}
case 284:{f.Locals[10]=f.Pop();f.Pc=286;continue;}
case 286:{f.Push(f.Locals[4]);f.Pc=288;continue;}
case 288:{f.Push(f.Locals[9]);f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttacker","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",293);}
case 293:{f.Push(f.Locals[4]);f.Pc=295;continue;}
case 295:{f.Push(f.Locals[10]);f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttacker","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",300);}
case 300:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?304:303;continue;}
case 303:{return JStep.ReturnVoid;}
case 304:{f.Push(f.Locals[7]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",311);}
case 311:{f.Locals[11]=f.Pop();f.Pc=313;continue;}
case 313:{f.Push(f.Locals[11]);f.Pc=315;continue;}
case 315:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",320);}
case 320:{f.Pc=f.Pop().Int==0?383:323;continue;}
case 323:{f.Push(f.Locals[11]);f.Pc=325;continue;}
case 325:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",330);}
case 330:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=333;continue;}
case 333:{f.Locals[12]=f.Pop();f.Pc=335;continue;}
case 335:{f.Push(f.Locals[4]);f.Pc=337;continue;}
case 337:{f.Push(f.Locals[12]);f.Pc=339;continue;}
case 339:{f.Push(f.Locals[9]);f.Pc=341;continue;}
case 341:{return rt.Call(f,"forge/game/combat/Combat","isBlocking","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokevirtual",344);}
case 344:{f.Pc=f.Pop().Int==0?357:347;continue;}
case 347:{f.Push(f.Locals[10]);f.Pc=349;continue;}
case 349:{f.Push(f.Locals[12]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokestatic",354);}
case 354:{f.Pc=f.Pop().Int==0?379:357;continue;}
case 357:{f.Push(f.Locals[4]);f.Pc=359;continue;}
case 359:{f.Push(f.Locals[12]);f.Pc=361;continue;}
case 361:{f.Push(f.Locals[10]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"forge/game/combat/Combat","isBlocking","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokevirtual",366);}
case 366:{f.Pc=f.Pop().Int==0?380:369;continue;}
case 369:{f.Push(f.Locals[9]);f.Pc=371;continue;}
case 371:{f.Push(f.Locals[12]);f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokestatic",376);}
case 376:{f.Pc=f.Pop().Int!=0?380:379;continue;}
case 379:{return JStep.ReturnVoid;}
case 380:{f.Pc=313;continue;}
case 383:{f.Push(f.Locals[7]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",390);}
case 390:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=392;continue;}
case 392:{f.Locals[11]=f.Pop();f.Pc=394;continue;}
case 394:{f.Push(JValue.I(0));f.Pc=395;continue;}
case 395:{f.Locals[12]=f.Pop();f.Pc=397;continue;}
case 397:{f.Push(f.Locals[12]);f.Pc=399;continue;}
case 399:{f.Push(f.Locals[7]);f.Pc=401;continue;}
case 401:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",406);}
case 406:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?505:409;continue;}
case 409:{f.Push(f.Locals[7]);f.Pc=411;continue;}
case 411:{f.Push(f.Locals[12]);f.Pc=413;continue;}
case 413:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",418);}
case 418:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=421;continue;}
case 421:{f.Locals[13]=f.Pop();f.Pc=423;continue;}
case 423:{f.Push(f.Locals[4]);f.Pc=425;continue;}
case 425:{f.Push(f.Locals[13]);f.Pc=427;continue;}
case 427:{f.Push(f.Locals[9]);f.Pc=429;continue;}
case 429:{return rt.Call(f,"forge/game/combat/Combat","isBlocking","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokevirtual",432);}
case 432:{f.Locals[14]=f.Pop();f.Pc=434;continue;}
case 434:{f.Push(f.Locals[4]);f.Pc=436;continue;}
case 436:{f.Push(f.Locals[13]);f.Pc=438;continue;}
case 438:{f.Push(f.Locals[10]);f.Pc=440;continue;}
case 440:{return rt.Call(f,"forge/game/combat/Combat","isBlocking","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokevirtual",443);}
case 443:{f.Locals[15]=f.Pop();f.Pc=445;continue;}
case 445:{f.Push(f.Locals[11]);f.Pc=447;continue;}
case 447:{f.Push(f.Locals[12]);f.Pc=449;continue;}
case 449:{f.Push(f.Locals[14]);f.Pc=451;continue;}
case 451:{f.Pc=f.Pop().Int==0?458:454;continue;}
case 454:{f.Push(JValue.I(1));f.Pc=455;continue;}
case 455:{f.Pc=459;continue;}
case 458:{f.Push(JValue.I(0));f.Pc=459;continue;}
case 459:{f.Push(f.Locals[15]);f.Pc=461;continue;}
case 461:{f.Pc=f.Pop().Int==0?468:464;continue;}
case 464:{f.Push(JValue.I(2));f.Pc=465;continue;}
case 465:{f.Pc=469;continue;}
case 468:{f.Push(JValue.I(0));f.Pc=469;continue;}
case 469:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=470;continue;}
case 470:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=471;continue;}
case 471:{f.Push(f.Locals[14]);f.Pc=473;continue;}
case 473:{f.Pc=f.Pop().Int==0?485:476;continue;}
case 476:{f.Push(f.Locals[4]);f.Pc=478;continue;}
case 478:{f.Push(f.Locals[9]);f.Pc=480;continue;}
case 480:{f.Push(f.Locals[13]);f.Pc=482;continue;}
case 482:{return rt.Call(f,"forge/game/combat/Combat","removeBlockAssignment","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",485);}
case 485:{f.Push(f.Locals[15]);f.Pc=487;continue;}
case 487:{f.Pc=f.Pop().Int==0?499:490;continue;}
case 490:{f.Push(f.Locals[4]);f.Pc=492;continue;}
case 492:{f.Push(f.Locals[10]);f.Pc=494;continue;}
case 494:{f.Push(f.Locals[13]);f.Pc=496;continue;}
case 496:{return rt.Call(f,"forge/game/combat/Combat","removeBlockAssignment","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",499);}
case 499:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=502;continue;}
case 502:{f.Pc=397;continue;}
case 505:{f.Push(f.Locals[4]);f.Pc=507;continue;}
case 507:{f.Push(f.Locals[9]);f.Pc=509;continue;}
case 509:{f.Push(f.Locals[4]);f.Pc=511;continue;}
case 511:{f.Push(f.Locals[9]);f.Pc=513;continue;}
case 513:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttacker","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",516);}
case 516:{return rt.Call(f,"forge/game/combat/Combat","unregisterAttacker","(Lforge/game/card/Card;Lforge/game/combat/AttackingBand;)V","invokevirtual",519);}
case 519:{f.Push(f.Locals[4]);f.Pc=521;continue;}
case 521:{f.Push(f.Locals[10]);f.Pc=523;continue;}
case 523:{f.Push(f.Locals[4]);f.Pc=525;continue;}
case 525:{f.Push(f.Locals[10]);f.Pc=527;continue;}
case 527:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttacker","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",530);}
case 530:{return rt.Call(f,"forge/game/combat/Combat","unregisterAttacker","(Lforge/game/card/Card;Lforge/game/combat/AttackingBand;)V","invokevirtual",533);}
case 533:{f.Push(JValue.I(0));f.Pc=534;continue;}
case 534:{f.Locals[12]=f.Pop();f.Pc=536;continue;}
case 536:{f.Push(f.Locals[12]);f.Pc=538;continue;}
case 538:{f.Push(f.Locals[7]);f.Pc=540;continue;}
case 540:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",545);}
case 545:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?641:548;continue;}
case 548:{f.Push(f.Locals[7]);f.Pc=550;continue;}
case 550:{f.Push(f.Locals[12]);f.Pc=552;continue;}
case 552:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",557);}
case 557:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=560;continue;}
case 560:{f.Locals[13]=f.Pop();f.Pc=562;continue;}
case 562:{f.Push(f.Locals[11]);f.Pc=564;continue;}
case 564:{f.Push(f.Locals[12]);f.Pc=566;continue;}
case 566:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=567;continue;}
case 567:{f.Push(JValue.I(1));f.Pc=568;continue;}
case 568:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=569;continue;}
case 569:{f.Push(JValue.I(1));f.Pc=570;continue;}
case 570:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?596:573;continue;}
case 573:{f.Push(f.Locals[4]);f.Pc=575;continue;}
case 575:{f.Push(f.Locals[10]);f.Pc=577;continue;}
case 577:{f.Push(f.Locals[13]);f.Pc=579;continue;}
case 579:{return rt.Call(f,"forge/game/combat/Combat","addBlocker","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",582);}
case 582:{f.Push(f.Locals[8]);f.Pc=584;continue;}
case 584:{f.Pc=f.Pop().Int==0?596:587;continue;}
case 587:{f.Push(f.Locals[0]);f.Pc=588;continue;}
case 588:{f.Push(f.Locals[3]);f.Pc=589;continue;}
case 589:{f.Push(f.Locals[10]);f.Pc=591;continue;}
case 591:{f.Push(f.Locals[13]);f.Pc=593;continue;}
case 593:{return rt.Call(f,"forge/game/ability/effects/SwitchBlockEffect","runTriggers","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",596);}
case 596:{f.Push(f.Locals[11]);f.Pc=598;continue;}
case 598:{f.Push(f.Locals[12]);f.Pc=600;continue;}
case 600:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=601;continue;}
case 601:{f.Push(JValue.I(2));f.Pc=602;continue;}
case 602:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=603;continue;}
case 603:{f.Push(JValue.I(2));f.Pc=604;continue;}
case 604:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?630:607;continue;}
case 607:{f.Push(f.Locals[4]);f.Pc=609;continue;}
case 609:{f.Push(f.Locals[9]);f.Pc=611;continue;}
case 611:{f.Push(f.Locals[13]);f.Pc=613;continue;}
case 613:{return rt.Call(f,"forge/game/combat/Combat","addBlocker","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",616);}
case 616:{f.Push(f.Locals[8]);f.Pc=618;continue;}
case 618:{f.Pc=f.Pop().Int==0?630:621;continue;}
case 621:{f.Push(f.Locals[0]);f.Pc=622;continue;}
case 622:{f.Push(f.Locals[3]);f.Pc=623;continue;}
case 623:{f.Push(f.Locals[9]);f.Pc=625;continue;}
case 625:{f.Push(f.Locals[13]);f.Pc=627;continue;}
case 627:{return rt.Call(f,"forge/game/ability/effects/SwitchBlockEffect","runTriggers","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",630);}
case 630:{f.Push(f.Locals[13]);f.Pc=632;continue;}
case 632:{return rt.Call(f,"forge/game/card/Card","updateBlockingForView","()V","invokevirtual",635);}
case 635:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=638;continue;}
case 638:{f.Pc=536;continue;}
case 641:{f.Push(f.Locals[4]);f.Pc=643;continue;}
case 643:{f.Push(f.Locals[9]);f.Pc=645;continue;}
case 645:{f.Push(f.Locals[4]);f.Pc=647;continue;}
case 647:{f.Push(f.Locals[9]);f.Pc=649;continue;}
case 649:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",652);}
case 652:{return rt.Call(f,"forge/game/combat/Combat","orderBlockersForDamageAssignment","(Lforge/game/card/Card;Lforge/game/card/CardCollection;)V","invokevirtual",655);}
case 655:{f.Push(f.Locals[4]);f.Pc=657;continue;}
case 657:{f.Push(f.Locals[10]);f.Pc=659;continue;}
case 659:{f.Push(f.Locals[4]);f.Pc=661;continue;}
case 661:{f.Push(f.Locals[10]);f.Pc=663;continue;}
case 663:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",666);}
case 666:{return rt.Call(f,"forge/game/combat/Combat","orderBlockersForDamageAssignment","(Lforge/game/card/Card;Lforge/game/card/CardCollection;)V","invokevirtual",669);}
case 669:{f.Push(f.Locals[7]);f.Pc=671;continue;}
case 671:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",676);}
case 676:{f.Locals[12]=f.Pop();f.Pc=678;continue;}
case 678:{f.Push(f.Locals[12]);f.Pc=680;continue;}
case 680:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",685);}
case 685:{f.Pc=f.Pop().Int==0?710:688;continue;}
case 688:{f.Push(f.Locals[12]);f.Pc=690;continue;}
case 690:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",695);}
case 695:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=698;continue;}
case 698:{f.Locals[13]=f.Pop();f.Pc=700;continue;}
case 700:{f.Push(f.Locals[4]);f.Pc=702;continue;}
case 702:{f.Push(f.Locals[13]);f.Pc=704;continue;}
case 704:{return rt.Call(f,"forge/game/combat/Combat","orderAttackersForDamageAssignment","(Lforge/game/card/Card;)V","invokevirtual",707);}
case 707:{f.Pc=678;continue;}
case 710:{f.Pc=1112;continue;}
case 713:{f.Push(f.Locals[7]);f.Pc=715;continue;}
case 715:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",720);}
case 720:{f.Push(JValue.I(1));f.Pc=721;continue;}
case 721:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?725:724;continue;}
case 724:{return JStep.ReturnVoid;}
case 725:{f.Push(f.Locals[7]);f.Pc=727;continue;}
case 727:{f.Push(JValue.I(0));f.Pc=728;continue;}
case 728:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",733);}
case 733:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=736;continue;}
case 736:{f.Locals[9]=f.Pop();f.Pc=738;continue;}
case 738:{f.Push(f.Locals[7]);f.Pc=740;continue;}
case 740:{f.Push(JValue.I(1));f.Pc=741;continue;}
case 741:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",746);}
case 746:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=749;continue;}
case 749:{f.Locals[10]=f.Pop();f.Pc=751;continue;}
case 751:{f.Push(f.Locals[4]);f.Pc=753;continue;}
case 753:{f.Push(f.Locals[9]);f.Pc=755;continue;}
case 755:{return rt.Call(f,"forge/game/combat/Combat","getAttackersBlockedBy","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",758);}
case 758:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",761);}
case 761:{f.Push(f.Locals[10]);f.Pc=763;continue;}
case 763:{return rt.Call(f,"forge/game/card/Card","canBlockAdditional","()I","invokevirtual",766);}
case 766:{f.Push(JValue.I(1));f.Pc=767;continue;}
case 767:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=768;continue;}
case 768:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?791:771;continue;}
case 771:{f.Push(f.Locals[4]);f.Pc=773;continue;}
case 773:{f.Push(f.Locals[10]);f.Pc=775;continue;}
case 775:{return rt.Call(f,"forge/game/combat/Combat","getAttackersBlockedBy","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",778);}
case 778:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",781);}
case 781:{f.Push(f.Locals[9]);f.Pc=783;continue;}
case 783:{return rt.Call(f,"forge/game/card/Card","canBlockAdditional","()I","invokevirtual",786);}
case 786:{f.Push(JValue.I(1));f.Pc=787;continue;}
case 787:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=788;continue;}
case 788:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?792:791;continue;}
case 791:{return JStep.ReturnVoid;}
case 792:{f.Push(f.Locals[6]);f.Pc=794;continue;}
case 794:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",799);}
case 799:{f.Locals[11]=f.Pop();f.Pc=801;continue;}
case 801:{f.Push(f.Locals[11]);f.Pc=803;continue;}
case 803:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",808);}
case 808:{f.Pc=f.Pop().Int==0?871:811;continue;}
case 811:{f.Push(f.Locals[11]);f.Pc=813;continue;}
case 813:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",818);}
case 818:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=821;continue;}
case 821:{f.Locals[12]=f.Pop();f.Pc=823;continue;}
case 823:{f.Push(f.Locals[4]);f.Pc=825;continue;}
case 825:{f.Push(f.Locals[9]);f.Pc=827;continue;}
case 827:{f.Push(f.Locals[12]);f.Pc=829;continue;}
case 829:{return rt.Call(f,"forge/game/combat/Combat","isBlocking","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokevirtual",832);}
case 832:{f.Pc=f.Pop().Int==0?845:835;continue;}
case 835:{f.Push(f.Locals[12]);f.Pc=837;continue;}
case 837:{f.Push(f.Locals[10]);f.Pc=839;continue;}
case 839:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokestatic",842);}
case 842:{f.Pc=f.Pop().Int==0?867:845;continue;}
case 845:{f.Push(f.Locals[4]);f.Pc=847;continue;}
case 847:{f.Push(f.Locals[10]);f.Pc=849;continue;}
case 849:{f.Push(f.Locals[12]);f.Pc=851;continue;}
case 851:{return rt.Call(f,"forge/game/combat/Combat","isBlocking","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokevirtual",854);}
case 854:{f.Pc=f.Pop().Int==0?868:857;continue;}
case 857:{f.Push(f.Locals[12]);f.Pc=859;continue;}
case 859:{f.Push(f.Locals[9]);f.Pc=861;continue;}
case 861:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokestatic",864);}
case 864:{f.Pc=f.Pop().Int!=0?868:867;continue;}
case 867:{return JStep.ReturnVoid;}
case 868:{f.Pc=801;continue;}
case 871:{f.Push(f.Locals[6]);f.Pc=873;continue;}
case 873:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",878);}
case 878:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=880;continue;}
case 880:{f.Locals[11]=f.Pop();f.Pc=882;continue;}
case 882:{f.Push(JValue.I(0));f.Pc=883;continue;}
case 883:{f.Locals[12]=f.Pop();f.Pc=885;continue;}
case 885:{f.Push(f.Locals[12]);f.Pc=887;continue;}
case 887:{f.Push(f.Locals[6]);f.Pc=889;continue;}
case 889:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",894);}
case 894:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?965:897;continue;}
case 897:{f.Push(f.Locals[6]);f.Pc=899;continue;}
case 899:{f.Push(f.Locals[12]);f.Pc=901;continue;}
case 901:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",906);}
case 906:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=909;continue;}
case 909:{f.Locals[13]=f.Pop();f.Pc=911;continue;}
case 911:{f.Push(f.Locals[4]);f.Pc=913;continue;}
case 913:{f.Push(f.Locals[9]);f.Pc=915;continue;}
case 915:{f.Push(f.Locals[13]);f.Pc=917;continue;}
case 917:{return rt.Call(f,"forge/game/combat/Combat","isBlocking","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokevirtual",920);}
case 920:{f.Locals[14]=f.Pop();f.Pc=922;continue;}
case 922:{f.Push(f.Locals[4]);f.Pc=924;continue;}
case 924:{f.Push(f.Locals[10]);f.Pc=926;continue;}
case 926:{f.Push(f.Locals[13]);f.Pc=928;continue;}
case 928:{return rt.Call(f,"forge/game/combat/Combat","isBlocking","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokevirtual",931);}
case 931:{f.Locals[15]=f.Pop();f.Pc=933;continue;}
case 933:{f.Push(f.Locals[11]);f.Pc=935;continue;}
case 935:{f.Push(f.Locals[12]);f.Pc=937;continue;}
case 937:{f.Push(f.Locals[14]);f.Pc=939;continue;}
case 939:{f.Pc=f.Pop().Int==0?946:942;continue;}
case 942:{f.Push(JValue.I(1));f.Pc=943;continue;}
case 943:{f.Pc=947;continue;}
case 946:{f.Push(JValue.I(0));f.Pc=947;continue;}
case 947:{f.Push(f.Locals[15]);f.Pc=949;continue;}
case 949:{f.Pc=f.Pop().Int==0?956:952;continue;}
case 952:{f.Push(JValue.I(2));f.Pc=953;continue;}
case 953:{f.Pc=957;continue;}
case 956:{f.Push(JValue.I(0));f.Pc=957;continue;}
case 957:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=958;continue;}
case 958:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=959;continue;}
case 959:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=962;continue;}
case 962:{f.Pc=885;continue;}
case 965:{f.Push(f.Locals[4]);f.Pc=967;continue;}
case 967:{f.Push(f.Locals[9]);f.Pc=969;continue;}
case 969:{return rt.Call(f,"forge/game/combat/Combat","removeFromCombat","(Lforge/game/card/Card;)V","invokevirtual",972);}
case 972:{f.Push(f.Locals[4]);f.Pc=974;continue;}
case 974:{f.Push(f.Locals[10]);f.Pc=976;continue;}
case 976:{return rt.Call(f,"forge/game/combat/Combat","removeFromCombat","(Lforge/game/card/Card;)V","invokevirtual",979);}
case 979:{f.Push(JValue.I(0));f.Pc=980;continue;}
case 980:{f.Locals[12]=f.Pop();f.Pc=982;continue;}
case 982:{f.Push(f.Locals[12]);f.Pc=984;continue;}
case 984:{f.Push(f.Locals[6]);f.Pc=986;continue;}
case 986:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",991);}
case 991:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1098:994;continue;}
case 994:{f.Push(f.Locals[6]);f.Pc=996;continue;}
case 996:{f.Push(f.Locals[12]);f.Pc=998;continue;}
case 998:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",1003);}
case 1003:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1006;continue;}
case 1006:{f.Locals[13]=f.Pop();f.Pc=1008;continue;}
case 1008:{f.Push(f.Locals[11]);f.Pc=1010;continue;}
case 1010:{f.Push(f.Locals[12]);f.Pc=1012;continue;}
case 1012:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1013;continue;}
case 1013:{f.Push(JValue.I(1));f.Pc=1014;continue;}
case 1014:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=1015;continue;}
case 1015:{f.Push(JValue.I(1));f.Pc=1016;continue;}
case 1016:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?1050:1019;continue;}
case 1019:{f.Push(f.Locals[4]);f.Pc=1021;continue;}
case 1021:{f.Push(f.Locals[13]);f.Pc=1023;continue;}
case 1023:{f.Push(f.Locals[10]);f.Pc=1025;continue;}
case 1025:{return rt.Call(f,"forge/game/combat/Combat","addBlocker","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",1028);}
case 1028:{f.Push(f.Locals[0]);f.Pc=1029;continue;}
case 1029:{f.Push(f.Locals[13]);f.Pc=1031;continue;}
case 1031:{f.Push(f.Locals[10]);f.Pc=1033;continue;}
case 1033:{return rt.Call(f,"forge/game/ability/effects/SwitchBlockEffect","recordBlock","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",1036);}
case 1036:{f.Push(f.Locals[8]);f.Pc=1038;continue;}
case 1038:{f.Pc=f.Pop().Int==0?1050:1041;continue;}
case 1041:{f.Push(f.Locals[0]);f.Pc=1042;continue;}
case 1042:{f.Push(f.Locals[3]);f.Pc=1043;continue;}
case 1043:{f.Push(f.Locals[13]);f.Pc=1045;continue;}
case 1045:{f.Push(f.Locals[10]);f.Pc=1047;continue;}
case 1047:{return rt.Call(f,"forge/game/ability/effects/SwitchBlockEffect","runTriggers","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",1050);}
case 1050:{f.Push(f.Locals[11]);f.Pc=1052;continue;}
case 1052:{f.Push(f.Locals[12]);f.Pc=1054;continue;}
case 1054:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1055;continue;}
case 1055:{f.Push(JValue.I(2));f.Pc=1056;continue;}
case 1056:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=1057;continue;}
case 1057:{f.Push(JValue.I(2));f.Pc=1058;continue;}
case 1058:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?1092:1061;continue;}
case 1061:{f.Push(f.Locals[4]);f.Pc=1063;continue;}
case 1063:{f.Push(f.Locals[13]);f.Pc=1065;continue;}
case 1065:{f.Push(f.Locals[9]);f.Pc=1067;continue;}
case 1067:{return rt.Call(f,"forge/game/combat/Combat","addBlocker","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",1070);}
case 1070:{f.Push(f.Locals[0]);f.Pc=1071;continue;}
case 1071:{f.Push(f.Locals[13]);f.Pc=1073;continue;}
case 1073:{f.Push(f.Locals[9]);f.Pc=1075;continue;}
case 1075:{return rt.Call(f,"forge/game/ability/effects/SwitchBlockEffect","recordBlock","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",1078);}
case 1078:{f.Push(f.Locals[8]);f.Pc=1080;continue;}
case 1080:{f.Pc=f.Pop().Int==0?1092:1083;continue;}
case 1083:{f.Push(f.Locals[0]);f.Pc=1084;continue;}
case 1084:{f.Push(f.Locals[3]);f.Pc=1085;continue;}
case 1085:{f.Push(f.Locals[13]);f.Pc=1087;continue;}
case 1087:{f.Push(f.Locals[9]);f.Pc=1089;continue;}
case 1089:{return rt.Call(f,"forge/game/ability/effects/SwitchBlockEffect","runTriggers","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",1092);}
case 1092:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=1095;continue;}
case 1095:{f.Pc=982;continue;}
case 1098:{f.Push(f.Locals[4]);f.Pc=1100;continue;}
case 1100:{f.Push(f.Locals[9]);f.Pc=1102;continue;}
case 1102:{return rt.Call(f,"forge/game/combat/Combat","orderAttackersForDamageAssignment","(Lforge/game/card/Card;)V","invokevirtual",1105);}
case 1105:{f.Push(f.Locals[4]);f.Pc=1107;continue;}
case 1107:{f.Push(f.Locals[10]);f.Pc=1109;continue;}
case 1109:{return rt.Call(f,"forge/game/combat/Combat","orderAttackersForDamageAssignment","(Lforge/game/card/Card;)V","invokevirtual",1112);}
case 1112:{f.Push(f.Locals[3]);f.Pc=1113;continue;}
case 1113:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",1116);}
case 1116:{f.Push(f.Locals[3]);f.Pc=1117;continue;}
case 1117:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCombatChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCombatChanged")));f.Pc=1120;continue;}
case 1120:{f.StackOp("dup");f.Pc=1121;continue;}
case 1121:{return rt.Call(f,"forge/game/event/GameEventCombatChanged","<init>","()V","invokespecial",1124);}
case 1124:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",1127);}
case 1127:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

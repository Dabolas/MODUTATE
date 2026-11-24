// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C362{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/PumpEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3587,"forge/game/ability/effects/PumpEffect","<init>","()V",1,1,1,new JHandler[]{},M3587));
c.Add(new JMethod(3588,"forge/game/ability/effects/PumpEffect","applyPump","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;IILjava/util/List;J)V",10,17,8,new JHandler[]{},M3588));
c.Add(new JMethod(3589,"forge/game/ability/effects/PumpEffect","applyPump","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/util/List;J)V",10,7,6,new JHandler[]{},M3589));
c.Add(new JMethod(3590,"forge/game/ability/effects/PumpEffect","keywordText","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",8,5,3,new JHandler[]{},M3590));
c.Add(new JMethod(3591,"forge/game/ability/effects/PumpEffect","hiddenClause","(Ljava/lang/String;)Ljava/lang/String;",8,2,3,new JHandler[]{},M3591));
c.Add(new JMethod(3592,"forge/game/ability/effects/PumpEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,13,5,new JHandler[]{},M3592));
c.Add(new JMethod(3593,"forge/game/ability/effects/PumpEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,19,7,new JHandler[]{},M3593));
c.Add(new JMethod(3594,"forge/game/ability/effects/PumpEffect","lambda$resolve$1","(Lforge/game/card/Card;Ljava/lang/String;)Ljava/lang/String;",4106,3,3,new JHandler[]{},M3594));
c.Add(new JMethod(3595,"forge/game/ability/effects/PumpEffect","lambda$resolve$0","(Lforge/game/player/PlayerCollection;Ljava/util/List;Ljava/lang/String;)Z",4106,8,3,new JHandler[]{},M3595));
}

internal static JStep M3587(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3588(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[7]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[7]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",11);}
case 11:{f.Locals[8]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Duration")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Locals[9]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("Perpetual")));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[9]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",28);}
case 28:{f.Locals[10]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[8]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(JValue.R(null));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",37);}
case 37:{f.Locals[11]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[11]);f.Pc=41;continue;}
case 41:{f.Pc=f.Pop().Reference==null?53:44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[11]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int!=0?54:53;continue;}
case 53:{return JStep.ReturnVoid;}
case 54:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",57);}
case 57:{f.Locals[12]=f.Pop();f.Pc=59;continue;}
case 59:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",62);}
case 62:{f.Locals[13]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(JValue.I(0));f.Pc=65;continue;}
case 65:{f.Locals[14]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[4]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",74);}
case 74:{f.Locals[15]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[15]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",83);}
case 83:{f.Pc=f.Pop().Int==0?151:86;continue;}
case 86:{f.Push(f.Locals[15]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",93);}
case 93:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=96;continue;}
case 96:{f.Locals[16]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[16]);f.Pc=100;continue;}
case 100:{f.Push(JValue.R(rt.String("HIDDEN")));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Int==0?138:108;continue;}
case 108:{f.Push(f.Locals[13]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[16]);f.Pc=112;continue;}
case 112:{f.Push(JValue.I(7));f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",117);}
case 117:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",122);}
case 122:{f.StackOp("pop");f.Pc=123;continue;}
case 123:{f.Push(f.Locals[14]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[16]);f.Pc=127;continue;}
case 127:{f.Push(JValue.R(rt.String("CARDNAME's power and toughness are switched")));f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",132);}
case 132:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=133;continue;}
case 133:{f.Locals[14]=f.Pop();f.Pc=135;continue;}
case 135:{f.Pc=148;continue;}
case 138:{f.Push(f.Locals[12]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[16]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",147);}
case 147:{f.StackOp("pop");f.Pc=148;continue;}
case 148:{f.Pc=76;continue;}
case 151:{f.Push(f.Locals[2]);f.Pc=152;continue;}
case 152:{f.Pc=f.Pop().Int!=0?159:155;continue;}
case 155:{f.Push(f.Locals[3]);f.Pc=156;continue;}
case 156:{f.Pc=f.Pop().Int==0?199:159;continue;}
case 159:{f.Push(f.Locals[10]);f.Pc=161;continue;}
case 161:{f.Pc=f.Pop().Int==0?186:164;continue;}
case 164:{f.Push(f.Locals[11]);f.Pc=166;continue;}
case 166:{if(!rt.EnsureInitialized(f,"forge/game/card/perpetual/PerpetualPTBoost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/perpetual/PerpetualPTBoost")));f.Pc=169;continue;}
case 169:{f.StackOp("dup");f.Pc=170;continue;}
case 170:{f.Push(f.Locals[5]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[2]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",176);}
case 176:{f.Push(f.Locals[3]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",180);}
case 180:{return rt.Call(f,"forge/game/card/perpetual/PerpetualPTBoost","<init>","(JLjava/lang/Integer;Ljava/lang/Integer;)V","invokespecial",183);}
case 183:{return rt.Call(f,"forge/game/card/Card","addPerpetual","(Lforge/game/card/perpetual/PerpetualInterface;)V","invokevirtual",186);}
case 186:{f.Push(f.Locals[11]);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[2]);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[3]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[5]);f.Pc=192;continue;}
case 192:{f.Push(JValue.L(0));f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/card/Card","addPTBoost","(IIJJ)V","invokevirtual",196);}
case 196:{f.Push(JValue.I(1));f.Pc=197;continue;}
case 197:{f.Locals[14]=f.Pop();f.Pc=199;continue;}
case 199:{f.Push(f.Locals[12]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",206);}
case 206:{f.Pc=f.Pop().Int!=0?248:209;continue;}
case 209:{f.Push(f.Locals[10]);f.Pc=211;continue;}
case 211:{f.Pc=f.Pop().Int==0?234:214;continue;}
case 214:{f.Push(f.Locals[11]);f.Pc=216;continue;}
case 216:{if(!rt.EnsureInitialized(f,"forge/game/card/perpetual/PerpetualKeywords"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/perpetual/PerpetualKeywords")));f.Pc=219;continue;}
case 219:{f.StackOp("dup");f.Pc=220;continue;}
case 220:{f.Push(f.Locals[5]);f.Pc=222;continue;}
case 222:{f.Push(f.Locals[12]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",227);}
case 227:{f.Push(JValue.I(0));f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/card/perpetual/PerpetualKeywords","<init>","(JLjava/util/List;Ljava/util/List;Z)V","invokespecial",231);}
case 231:{return rt.Call(f,"forge/game/card/Card","addPerpetual","(Lforge/game/card/perpetual/PerpetualInterface;)V","invokevirtual",234);}
case 234:{f.Push(f.Locals[11]);f.Pc=236;continue;}
case 236:{f.Push(f.Locals[12]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",241);}
case 241:{f.Push(JValue.I(0));f.Pc=242;continue;}
case 242:{f.Push(f.Locals[5]);f.Pc=244;continue;}
case 244:{f.Push(JValue.R(null));f.Pc=245;continue;}
case 245:{return rt.Call(f,"forge/game/card/Card","addChangedCardKeywords","(Ljava/util/List;Ljava/util/List;ZJLforge/game/staticability/StaticAbility;)V","invokevirtual",248);}
case 248:{f.Push(f.Locals[13]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",255);}
case 255:{f.Pc=f.Pop().Int!=0?268:258;continue;}
case 258:{f.Push(f.Locals[11]);f.Pc=260;continue;}
case 260:{f.Push(f.Locals[5]);f.Pc=262;continue;}
case 262:{f.Push(JValue.L(0));f.Pc=263;continue;}
case 263:{f.Push(f.Locals[13]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/card/Card","addHiddenExtrinsicKeywords","(JJLjava/lang/Iterable;)V","invokevirtual",268);}
case 268:{f.Push(f.Locals[14]);f.Pc=270;continue;}
case 270:{f.Pc=f.Pop().Int==0?278:273;continue;}
case 273:{f.Push(f.Locals[11]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/game/card/Card","updatePTforView","()V","invokevirtual",278);}
case 278:{f.Push(f.Locals[0]);f.Pc=279;continue;}
case 279:{f.Push(JValue.R(rt.String("CanBlockAny")));f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",284);}
case 284:{f.Pc=f.Pop().Int==0?294:287;continue;}
case 287:{f.Push(f.Locals[11]);f.Pc=289;continue;}
case 289:{f.Push(f.Locals[5]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/game/card/Card","addCanBlockAny","(J)V","invokevirtual",294);}
case 294:{f.Push(f.Locals[0]);f.Pc=295;continue;}
case 295:{f.Push(JValue.R(rt.String("CanBlockAmount")));f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",300);}
case 300:{f.Pc=f.Pop().Int==0?327:303;continue;}
case 303:{f.Push(f.Locals[7]);f.Pc=305;continue;}
case 305:{f.Push(f.Locals[0]);f.Pc=306;continue;}
case 306:{f.Push(JValue.R(rt.String("CanBlockAmount")));f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",311);}
case 311:{f.Push(f.Locals[0]);f.Pc=312;continue;}
case 312:{f.Push(JValue.I(1));f.Pc=313;continue;}
case 313:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;Z)I","invokestatic",316);}
case 316:{f.Locals[15]=f.Pop();f.Pc=318;continue;}
case 318:{f.Push(f.Locals[11]);f.Pc=320;continue;}
case 320:{f.Push(f.Locals[15]);f.Pc=322;continue;}
case 322:{f.Push(f.Locals[5]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/card/Card","addCanBlockAdditional","(IJ)V","invokevirtual",327);}
case 327:{f.Push(f.Locals[0]);f.Pc=328;continue;}
case 328:{f.Push(JValue.R(rt.String("LeaveBattlefield")));f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",333);}
case 333:{f.Pc=f.Pop().Int==0?348:336;continue;}
case 336:{f.Push(f.Locals[11]);f.Pc=338;continue;}
case 338:{f.Push(f.Locals[0]);f.Pc=339;continue;}
case 339:{f.Push(f.Locals[0]);f.Pc=340;continue;}
case 340:{f.Push(JValue.R(rt.String("LeaveBattlefield")));f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",345);}
case 345:{return rt.Call(f,"forge/game/ability/effects/PumpEffect","addLeaveBattlefieldReplacement","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/lang/String;)V","invokestatic",348);}
case 348:{f.Push(f.Locals[0]);f.Pc=349;continue;}
case 349:{f.Push(JValue.R(rt.String("RememberPumped")));f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",354);}
case 354:{f.Pc=f.Pop().Int==0?364:357;continue;}
case 357:{f.Push(f.Locals[7]);f.Pc=359;continue;}
case 359:{f.Push(f.Locals[11]);f.Pc=361;continue;}
case 361:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",364);}
case 364:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=366;continue;}
case 366:{f.Push(f.Locals[9]);f.Pc=368;continue;}
case 368:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",371);}
case 371:{f.Pc=f.Pop().Int!=0?421:374;continue;}
case 374:{f.Push(f.Locals[10]);f.Pc=376;continue;}
case 376:{f.Pc=f.Pop().Int!=0?421:379;continue;}
case 379:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/PumpEffect$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/PumpEffect$1")));f.Pc=382;continue;}
case 382:{f.StackOp("dup");f.Pc=383;continue;}
case 383:{f.Push(f.Locals[7]);f.Pc=385;continue;}
case 385:{f.Push(f.Locals[11]);f.Pc=387;continue;}
case 387:{f.Push(f.Locals[5]);f.Pc=389;continue;}
case 389:{f.Push(f.Locals[4]);f.Pc=391;continue;}
case 391:{f.Push(f.Locals[8]);f.Pc=393;continue;}
case 393:{return rt.Call(f,"forge/game/ability/effects/PumpEffect$1","<init>","(Lforge/game/card/Card;Lforge/game/card/Card;JLjava/util/List;Lforge/game/Game;)V","invokespecial",396);}
case 396:{f.Locals[15]=f.Pop();f.Pc=398;continue;}
case 398:{f.Push(JValue.R(rt.String("UntilUntaps")));f.Pc=400;continue;}
case 400:{f.Push(f.Locals[9]);f.Pc=402;continue;}
case 402:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",405);}
case 405:{f.Pc=f.Pop().Int==0?415:408;continue;}
case 408:{f.Push(f.Locals[7]);f.Pc=410;continue;}
case 410:{f.Push(f.Locals[11]);f.Pc=412;continue;}
case 412:{return rt.Call(f,"forge/game/card/Card","addGainControlTarget","(Lforge/game/card/Card;)V","invokevirtual",415);}
case 415:{f.Push(f.Locals[0]);f.Pc=416;continue;}
case 416:{f.Push(f.Locals[15]);f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/game/ability/effects/PumpEffect","addUntilCommand","(Lforge/game/spellability/SpellAbility;Lforge/GameCommand;)V","invokestatic",421);}
case 421:{f.Push(f.Locals[8]);f.Pc=423;continue;}
case 423:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=426;continue;}
case 426:{f.StackOp("dup");f.Pc=427;continue;}
case 427:{f.Push(f.Locals[11]);f.Pc=429;continue;}
case 429:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",432);}
case 432:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",435);}
case 435:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3589(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Duration")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Locals[5]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",14);}
case 14:{f.Pc=f.Pop().Int!=0?30:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",22);}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",26);}
case 26:{f.Push(JValue.L(0));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/player/Player","addChangedKeywords","(Ljava/util/List;Ljava/util/List;Ljava/lang/Long;J)V","invokevirtual",30);}
case 30:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int!=0?57:40;continue;}
case 40:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/PumpEffect$2"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/PumpEffect$2")));f.Pc=43;continue;}
case 43:{f.StackOp("dup");f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/ability/effects/PumpEffect$2","<init>","(Lforge/game/player/Player;J)V","invokespecial",49);}
case 49:{f.Locals[6]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[6]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/ability/effects/PumpEffect","addUntilCommand","(Lforge/game/spellability/SpellAbility;Lforge/GameCommand;)V","invokestatic",57);}
case 57:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3590(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String(":")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=11;continue;}
case 11:{f.Push(JValue.I(3));f.Pc=12;continue;}
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?81:15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=20;continue;}
case 20:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int!=0?81:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=30;continue;}
case 30:{f.Push(JValue.I(1));f.Pc=31;continue;}
case 31:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=32;continue;}
case 32:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",41);}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("Protection")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",49);}
case 49:{f.Pc=f.Pop().Int!=0?63:52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{f.Push(JValue.I(0));f.Pc=54;continue;}
case 54:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("Hexproof")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int==0?68:63;continue;}
case 63:{f.Push(JValue.R(rt.String(" from ")));f.Pc=65;continue;}
case 65:{f.Pc=70;continue;}
case 68:{f.Push(JValue.R(rt.String(" ")));f.Pc=70;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{return rt.DynamicCall(f,"forge/game/ability/effects/PumpEffect:3590:72:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",77);}
case 77:{f.Locals[3]=f.Pop();f.Pc=78;continue;}
case 78:{f.Pc=99;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=83;continue;}
case 83:{f.Push(JValue.I(2));f.Pc=84;continue;}
case 84:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?99:87;continue;}
case 87:{f.Push(f.Locals[2]);f.Pc=88;continue;}
case 88:{f.Push(JValue.I(0));f.Pc=89;continue;}
case 89:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=90;continue;}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{f.Push(JValue.I(1));f.Pc=92;continue;}
case 92:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=93;continue;}
case 93:{return rt.DynamicCall(f,"forge/game/ability/effects/PumpEffect:3590:93:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",98);}
case 98:{f.Locals[3]=f.Pop();f.Pc=99;continue;}
case 99:{f.Push(f.Locals[3]);f.Pc=100;continue;}
case 100:{f.Push(JValue.R(rt.String("\\.$")));f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String("")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",107);}
case 107:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",110);}
case 110:{f.Push(JValue.R(rt.String("cardname")));f.Pc=112;continue;}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",116);}
case 116:{f.Locals[3]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[0]);f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("Prevent ")));f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",123);}
case 123:{f.Pc=f.Pop().Int!=0?135:126;continue;}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(JValue.R(rt.String("If ")));f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",132);}
case 132:{f.Pc=f.Pop().Int==0?144:135;continue;}
case 135:{f.Push(f.Locals[3]);f.Pc=136;continue;}
case 136:{return rt.DynamicCall(f,"forge/game/ability/effects/PumpEffect:3590:136:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",141);}
case 141:{f.Pc=145;continue;}
case 144:{f.Push(f.Locals[3]);f.Pc=145;continue;}
case 145:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3591(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.String("\\.$")));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("^(?:CARDNAME|This card|This creature|This permanent|It) ")));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/String","replaceFirst","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",20);}
case 20:{f.Locals[1]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?32:28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Pc=50;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",37);}
case 37:{return rt.Call(f,"java/lang/Character","toLowerCase","(C)C","invokestatic",40);}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",45);}
case 45:{return rt.DynamicCall(f,"forge/game/ability/effects/PumpEffect:3591:45:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(CLjava/lang/String;)Ljava/lang/String;",50);}
case 50:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3592(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/ability/effects/PumpEffect","getCardsfromTargets","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",17);}
case 17:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",22);}
case 22:{f.StackOp("pop");f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?40:30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",34);}
case 34:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","canTgtPlayer","()Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int!=0?50:40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("Defined")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?61:50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/ability/effects/PumpEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",55);}
case 55:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",60);}
case 60:{f.StackOp("pop");f.Pc=61;continue;}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",67);}
case 67:{f.Pc=f.Pop().Int<=0?1463:70;continue;}
case 70:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",73);}
case 73:{f.Locals[4]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("KW")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",82);}
case 82:{f.Pc=f.Pop().Int==0?297:85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{f.Push(JValue.R(rt.String("KW")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",92);}
case 92:{f.Push(JValue.R(rt.String("HIDDEN This card doesn't untap during your next untap step.")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?273:101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilitySub")?1:0));f.Pc=105;continue;}
case 105:{f.Pc=f.Pop().Int==0?135:108;continue;}
case 108:{f.Push(f.Locals[2]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[3]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",115);}
case 115:{f.Push(JValue.I(1));f.Pc=116;continue;}
case 116:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?125:119;continue;}
case 119:{f.Push(JValue.R(rt.String("It doesn't ")));f.Pc=122;continue;}
case 122:{f.Pc=128;continue;}
case 125:{f.Push(JValue.R(rt.String("They don't ")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",131);}
case 131:{f.StackOp("pop");f.Pc=132;continue;}
case 132:{f.Pc=166;continue;}
case 135:{f.Push(f.Locals[2]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[3]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",140);}
case 140:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",143);}
case 143:{f.Push(f.Locals[3]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",149);}
case 149:{f.Push(JValue.I(1));f.Pc=150;continue;}
case 150:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?159:153;continue;}
case 153:{f.Push(JValue.R(rt.String(" doesn't ")));f.Pc=156;continue;}
case 156:{f.Pc=162;continue;}
case 159:{f.Push(JValue.R(rt.String(" don't ")));f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",165);}
case 165:{f.StackOp("pop");f.Pc=166;continue;}
case 166:{f.Push(f.Locals[2]);f.Pc=167;continue;}
case 167:{f.Push(JValue.R(rt.String("untap during ")));f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",173);}
case 173:{f.StackOp("pop");f.Pc=174;continue;}
case 174:{f.Push(JValue.R(rt.String("your")));f.Pc=177;continue;}
case 177:{f.Locals[5]=f.Pop();f.Pc=179;continue;}
case 179:{f.Push(f.Locals[3]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",185);}
case 185:{f.Locals[6]=f.Pop();f.Pc=187;continue;}
case 187:{f.Push(f.Locals[6]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",194);}
case 194:{f.Pc=f.Pop().Int==0?255:197;continue;}
case 197:{f.Push(f.Locals[6]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",204);}
case 204:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=207;continue;}
case 207:{f.Locals[7]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(f.Locals[7]);f.Pc=211;continue;}
case 211:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=214;continue;}
case 214:{f.Locals[8]=f.Pop();f.Pc=216;continue;}
case 216:{f.Push(f.Locals[8]);f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",221);}
case 221:{f.Push(f.Locals[1]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",225);}
case 225:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?252:228;continue;}
case 228:{f.Push(f.Locals[3]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",234);}
case 234:{f.Push(JValue.I(1));f.Pc=235;continue;}
case 235:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?244:238;continue;}
case 238:{f.Push(JValue.R(rt.String("its controller's")));f.Pc=241;continue;}
case 241:{f.Pc=247;continue;}
case 244:{f.Push(JValue.R(rt.String("their controller's")));f.Pc=247;continue;}
case 247:{f.Locals[5]=f.Pop();f.Pc=249;continue;}
case 249:{f.Pc=255;continue;}
case 252:{f.Pc=187;continue;}
case 255:{f.Push(f.Locals[2]);f.Pc=256;continue;}
case 256:{f.Push(f.Locals[5]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",261);}
case 261:{f.Push(JValue.R(rt.String(" next untap step.")));f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",267);}
case 267:{f.StackOp("pop");f.Pc=268;continue;}
case 268:{f.Push(f.Locals[2]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",272);}
case 272:{return JStep.Return(f.Pop());}
case 273:{f.Push(f.Locals[4]);f.Pc=275;continue;}
case 275:{f.Push(f.Locals[1]);f.Pc=276;continue;}
case 276:{f.Push(JValue.R(rt.String("KW")));f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",282);}
case 282:{f.Push(JValue.R(rt.String(" & ")));f.Pc=285;continue;}
case 285:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",288);}
case 288:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",291);}
case 291:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",296);}
case 296:{f.StackOp("pop");f.Pc=297;continue;}
case 297:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",300);}
case 300:{f.Locals[5]=f.Pop();f.Pc=302;continue;}
case 302:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",305);}
case 305:{f.Locals[6]=f.Pop();f.Pc=307;continue;}
case 307:{f.Push(f.Locals[4]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",314);}
case 314:{f.Locals[7]=f.Pop();f.Pc=316;continue;}
case 316:{f.Push(f.Locals[7]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",323);}
case 323:{f.Pc=f.Pop().Int==0?468:326;continue;}
case 326:{f.Push(f.Locals[7]);f.Pc=328;continue;}
case 328:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",333);}
case 333:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=336;continue;}
case 336:{f.Locals[8]=f.Pop();f.Pc=338;continue;}
case 338:{f.Push(f.Locals[8]);f.Pc=340;continue;}
case 340:{f.Push(JValue.R(rt.String("HIDDEN ")));f.Pc=343;continue;}
case 343:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",346);}
case 346:{f.Locals[9]=f.Pop();f.Pc=348;continue;}
case 348:{f.Push(f.Locals[9]);f.Pc=350;continue;}
case 350:{f.Pc=f.Pop().Int!=0?367:353;continue;}
case 353:{f.Push(f.Locals[8]);f.Pc=355;continue;}
case 355:{f.Push(JValue.R(rt.String("CARDNAME ")));f.Pc=358;continue;}
case 358:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",361);}
case 361:{f.Pc=f.Pop().Int!=0?367:364;continue;}
case 364:{f.Pc=316;continue;}
case 367:{f.Push(f.Locals[7]);f.Pc=369;continue;}
case 369:{return rt.Call(f,"java/util/Iterator","remove","()V","invokeinterface",374);}
case 374:{f.Push(f.Locals[9]);f.Pc=376;continue;}
case 376:{f.Pc=f.Pop().Int==0?393:379;continue;}
case 379:{f.Push(f.Locals[8]);f.Pc=381;continue;}
case 381:{f.Push(JValue.R(rt.String("HIDDEN ")));f.Pc=384;continue;}
case 384:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",387);}
case 387:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",390);}
case 390:{f.Pc=395;continue;}
case 393:{f.Push(f.Locals[8]);f.Pc=395;continue;}
case 395:{return rt.Call(f,"forge/game/ability/effects/PumpEffect","hiddenClause","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",398);}
case 398:{f.Locals[10]=f.Pop();f.Pc=400;continue;}
case 400:{f.Push(f.Locals[10]);f.Pc=402;continue;}
case 402:{f.Push(JValue.R(rt.String("(?i)(?:can't|can|must|doesn't|don't|attacks?|blocks?|is|are|has|have|loses?|gets?)\\b.*")));f.Pc=405;continue;}
case 405:{return rt.Call(f,"java/lang/String","matches","(Ljava/lang/String;)Z","invokevirtual",408);}
case 408:{f.Pc=f.Pop().Int==0?424:411;continue;}
case 411:{f.Push(f.Locals[5]);f.Pc=413;continue;}
case 413:{f.Push(f.Locals[10]);f.Pc=415;continue;}
case 415:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",420);}
case 420:{f.StackOp("pop");f.Pc=421;continue;}
case 421:{f.Pc=465;continue;}
case 424:{f.Push(f.Locals[6]);f.Pc=426;continue;}
case 426:{f.Push(f.Locals[9]);f.Pc=428;continue;}
case 428:{f.Pc=f.Pop().Int==0?445:431;continue;}
case 431:{f.Push(f.Locals[8]);f.Pc=433;continue;}
case 433:{f.Push(JValue.R(rt.String("HIDDEN ")));f.Pc=436;continue;}
case 436:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",439);}
case 439:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",442);}
case 442:{f.Pc=447;continue;}
case 445:{f.Push(f.Locals[8]);f.Pc=447;continue;}
case 447:{f.Push(JValue.R(rt.String("\\.$")));f.Pc=449;continue;}
case 449:{f.Push(JValue.R(rt.String("")));f.Pc=451;continue;}
case 451:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",454);}
case 454:{return rt.DynamicCall(f,"forge/game/ability/effects/PumpEffect:3592:454:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",459);}
case 459:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",464);}
case 464:{f.StackOp("pop");f.Pc=465;continue;}
case 465:{f.Pc=316;continue;}
case 468:{f.Push(f.Locals[6]);f.Pc=470;continue;}
case 470:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",475);}
case 475:{f.Pc=f.Pop().Int!=0?526:478;continue;}
case 478:{f.Push(f.Locals[4]);f.Pc=480;continue;}
case 480:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",485);}
case 485:{f.Pc=f.Pop().Int==0?526:488;continue;}
case 488:{f.Push(f.Locals[5]);f.Pc=490;continue;}
case 490:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",495);}
case 495:{f.Pc=f.Pop().Int==0?526:498;continue;}
case 498:{f.Push(f.Locals[1]);f.Pc=499;continue;}
case 499:{f.Push(JValue.R(rt.String("NumAtt")));f.Pc=502;continue;}
case 502:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",505);}
case 505:{f.Pc=f.Pop().Int!=0?526:508;continue;}
case 508:{f.Push(f.Locals[1]);f.Pc=509;continue;}
case 509:{f.Push(JValue.R(rt.String("NumDef")));f.Pc=512;continue;}
case 512:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",515);}
case 515:{f.Pc=f.Pop().Int!=0?526:518;continue;}
case 518:{f.Push(JValue.R(rt.String(" ")));f.Pc=520;continue;}
case 520:{f.Push(f.Locals[6]);f.Pc=522;continue;}
case 522:{return rt.Call(f,"java/lang/String","join","(Ljava/lang/CharSequence;Ljava/lang/Iterable;)Ljava/lang/String;","invokestatic",525);}
case 525:{return JStep.Return(f.Pop());}
case 526:{f.Push(f.Locals[1]);f.Pc=527;continue;}
case 527:{f.Push(JValue.R(rt.String("IfDesc")));f.Pc=530;continue;}
case 530:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",533);}
case 533:{f.Pc=f.Pop().Int==0?611:536;continue;}
case 536:{f.Push(f.Locals[1]);f.Pc=537;continue;}
case 537:{f.Push(JValue.R(rt.String("IfDesc")));f.Pc=540;continue;}
case 540:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",543);}
case 543:{f.Push(JValue.R(rt.String("True")));f.Pc=546;continue;}
case 546:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",549);}
case 549:{f.Pc=f.Pop().Int==0?592:552;continue;}
case 552:{f.Push(f.Locals[1]);f.Pc=553;continue;}
case 553:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=556;continue;}
case 556:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",559);}
case 559:{f.Pc=f.Pop().Int==0?592:562;continue;}
case 562:{f.Push(f.Locals[1]);f.Pc=563;continue;}
case 563:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=566;continue;}
case 566:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",569);}
case 569:{f.Locals[7]=f.Pop();f.Pc=571;continue;}
case 571:{f.Push(f.Locals[2]);f.Pc=572;continue;}
case 572:{f.Push(f.Locals[7]);f.Pc=574;continue;}
case 574:{f.Push(JValue.I(0));f.Pc=575;continue;}
case 575:{f.Push(f.Locals[7]);f.Pc=577;continue;}
case 577:{f.Push(JValue.R(rt.String(",")));f.Pc=580;continue;}
case 580:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",583);}
case 583:{f.Push(JValue.I(1));f.Pc=584;continue;}
case 584:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=585;continue;}
case 585:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;","invokevirtual",588);}
case 588:{f.StackOp("pop");f.Pc=589;continue;}
case 589:{f.Pc=604;continue;}
case 592:{f.Push(f.Locals[2]);f.Pc=593;continue;}
case 593:{f.Push(f.Locals[1]);f.Pc=594;continue;}
case 594:{f.Push(JValue.R(rt.String("IfDesc")));f.Pc=597;continue;}
case 597:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",600);}
case 600:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",603);}
case 603:{f.StackOp("pop");f.Pc=604;continue;}
case 604:{f.Push(f.Locals[2]);f.Pc=605;continue;}
case 605:{f.Push(JValue.R(rt.String(" ")));f.Pc=607;continue;}
case 607:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",610);}
case 610:{f.StackOp("pop");f.Pc=611;continue;}
case 611:{f.Push(f.Locals[1]);f.Pc=612;continue;}
case 612:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilitySub")?1:0));f.Pc=615;continue;}
case 615:{f.Pc=f.Pop().Int==0?672:618;continue;}
case 618:{f.Push(f.Locals[1]);f.Pc=619;continue;}
case 619:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",622);}
case 622:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",625);}
case 625:{f.Push(f.Locals[3]);f.Pc=626;continue;}
case 626:{return rt.Call(f,"forge/game/spellability/TargetChoices","containsAll","(Ljava/util/Collection;)Z","invokevirtual",629);}
case 629:{f.Pc=f.Pop().Int==0?672:632;continue;}
case 632:{f.Push(f.Locals[2]);f.Pc=633;continue;}
case 633:{f.Push(f.Locals[3]);f.Pc=634;continue;}
case 634:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",639);}
case 639:{f.Push(JValue.I(1));f.Pc=640;continue;}
case 640:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?662:643;continue;}
case 643:{f.Push(f.Locals[3]);f.Pc=644;continue;}
case 644:{f.Push(JValue.I(0));f.Pc=645;continue;}
case 645:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",650);}
case 650:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=653;continue;}
case 653:{f.Pc=f.Pop().Int==0?662:656;continue;}
case 656:{f.Push(JValue.R(rt.String("It ")));f.Pc=659;continue;}
case 659:{f.Pc=665;continue;}
case 662:{f.Push(JValue.R(rt.String("They ")));f.Pc=665;continue;}
case 665:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",668);}
case 668:{f.StackOp("pop");f.Pc=669;continue;}
case 669:{f.Pc=686;continue;}
case 672:{f.Push(f.Locals[2]);f.Pc=673;continue;}
case 673:{f.Push(f.Locals[3]);f.Pc=674;continue;}
case 674:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",677);}
case 677:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",680);}
case 680:{f.Push(JValue.R(rt.String(" ")));f.Pc=682;continue;}
case 682:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",685);}
case 685:{f.StackOp("pop");f.Pc=686;continue;}
case 686:{f.Push(f.Locals[1]);f.Pc=687;continue;}
case 687:{f.Push(JValue.R(rt.String("Radiance")));f.Pc=690;continue;}
case 690:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",693);}
case 693:{f.Pc=f.Pop().Int==0?750:696;continue;}
case 696:{f.Push(f.Locals[2]);f.Pc=697;continue;}
case 697:{f.Push(JValue.R(rt.String("and each other ")));f.Pc=700;continue;}
case 700:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",703);}
case 703:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",706);}
case 706:{f.Push(f.Locals[1]);f.Pc=707;continue;}
case 707:{f.Push(JValue.R(rt.String("ValidTgts")));f.Pc=710;continue;}
case 710:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",713);}
case 713:{return rt.Call(f,"forge/util/Lang","describeValidList","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",716);}
case 716:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",719);}
case 719:{f.Push(JValue.R(rt.String(" that shares a color with ")));f.Pc=722;continue;}
case 722:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",725);}
case 725:{f.StackOp("pop");f.Pc=726;continue;}
case 726:{f.Push(f.Locals[2]);f.Pc=727;continue;}
case 727:{f.Push(f.Locals[3]);f.Pc=728;continue;}
case 728:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",733);}
case 733:{f.Push(JValue.I(1));f.Pc=734;continue;}
case 734:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?743:737;continue;}
case 737:{f.Push(JValue.R(rt.String("them ")));f.Pc=740;continue;}
case 740:{f.Pc=746;continue;}
case 743:{f.Push(JValue.R(rt.String("it ")));f.Pc=746;continue;}
case 746:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",749);}
case 749:{f.StackOp("pop");f.Pc=750;continue;}
case 750:{f.Push(f.Locals[1]);f.Pc=751;continue;}
case 751:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",754);}
case 754:{f.Push(f.Locals[1]);f.Pc=755;continue;}
case 755:{f.Push(JValue.R(rt.String("NumAtt")));f.Pc=758;continue;}
case 758:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",761);}
case 761:{f.Push(f.Locals[1]);f.Pc=762;continue;}
case 762:{f.Push(JValue.I(1));f.Pc=763;continue;}
case 763:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;Z)I","invokestatic",766);}
case 766:{f.Locals[7]=f.Pop();f.Pc=768;continue;}
case 768:{f.Push(f.Locals[1]);f.Pc=769;continue;}
case 769:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",772);}
case 772:{f.Push(f.Locals[1]);f.Pc=773;continue;}
case 773:{f.Push(JValue.R(rt.String("NumDef")));f.Pc=776;continue;}
case 776:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",779);}
case 779:{f.Push(f.Locals[1]);f.Pc=780;continue;}
case 780:{f.Push(JValue.I(1));f.Pc=781;continue;}
case 781:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;Z)I","invokestatic",784);}
case 784:{f.Locals[8]=f.Pop();f.Pc=786;continue;}
case 786:{f.Push(f.Locals[1]);f.Pc=787;continue;}
case 787:{f.Push(JValue.R(rt.String("NumAtt")));f.Pc=790;continue;}
case 790:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",793);}
case 793:{f.Pc=f.Pop().Int!=0?806:796;continue;}
case 796:{f.Push(f.Locals[1]);f.Pc=797;continue;}
case 797:{f.Push(JValue.R(rt.String("NumDef")));f.Pc=800;continue;}
case 800:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",803);}
case 803:{f.Pc=f.Pop().Int==0?810:806;continue;}
case 806:{f.Push(JValue.I(1));f.Pc=807;continue;}
case 807:{f.Pc=811;continue;}
case 810:{f.Push(JValue.I(0));f.Pc=811;continue;}
case 811:{f.Locals[9]=f.Pop();f.Pc=813;continue;}
case 813:{f.Push(f.Locals[4]);f.Pc=815;continue;}
case 815:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",820);}
case 820:{f.Pc=f.Pop().Int!=0?827:823;continue;}
case 823:{f.Push(JValue.I(1));f.Pc=824;continue;}
case 824:{f.Pc=828;continue;}
case 827:{f.Push(JValue.I(0));f.Pc=828;continue;}
case 828:{f.Locals[10]=f.Pop();f.Pc=830;continue;}
case 830:{f.Push(f.Locals[3]);f.Pc=831;continue;}
case 831:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",836);}
case 836:{f.Push(JValue.I(1));f.Pc=837;continue;}
case 837:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?844:840;continue;}
case 840:{f.Push(JValue.I(1));f.Pc=841;continue;}
case 841:{f.Pc=845;continue;}
case 844:{f.Push(JValue.I(0));f.Pc=845;continue;}
case 845:{f.Locals[11]=f.Pop();f.Pc=847;continue;}
case 847:{f.Push(f.Locals[9]);f.Pc=849;continue;}
case 849:{f.Pc=f.Pop().Int==0?1035:852;continue;}
case 852:{f.Push(f.Locals[2]);f.Pc=853;continue;}
case 853:{f.Push(f.Locals[11]);f.Pc=855;continue;}
case 855:{f.Pc=f.Pop().Int==0?864:858;continue;}
case 858:{f.Push(JValue.R(rt.String("get ")));f.Pc=861;continue;}
case 861:{f.Pc=867;continue;}
case 864:{f.Push(JValue.R(rt.String("gets ")));f.Pc=867;continue;}
case 867:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",870);}
case 870:{f.StackOp("pop");f.Pc=871;continue;}
case 871:{f.Push(f.Locals[7]);f.Pc=873;continue;}
case 873:{f.Pc=f.Pop().Int==0?908:876;continue;}
case 876:{f.Push(f.Locals[2]);f.Pc=877;continue;}
case 877:{f.Push(f.Locals[7]);f.Pc=879;continue;}
case 879:{f.Pc=f.Pop().Int<=0?888:882;continue;}
case 882:{f.Push(JValue.R(rt.String("+")));f.Pc=885;continue;}
case 885:{f.Pc=890;continue;}
case 888:{f.Push(JValue.R(rt.String("")));f.Pc=890;continue;}
case 890:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",893);}
case 893:{f.Push(f.Locals[7]);f.Pc=895;continue;}
case 895:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",898);}
case 898:{f.Push(JValue.R(rt.String("/")));f.Pc=901;continue;}
case 901:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",904);}
case 904:{f.StackOp("pop");f.Pc=905;continue;}
case 905:{f.Pc=938;continue;}
case 908:{f.Push(f.Locals[2]);f.Pc=909;continue;}
case 909:{f.Push(f.Locals[8]);f.Pc=911;continue;}
case 911:{f.Pc=f.Pop().Int>=0?920:914;continue;}
case 914:{f.Push(JValue.R(rt.String("-")));f.Pc=917;continue;}
case 917:{f.Pc=923;continue;}
case 920:{f.Push(JValue.R(rt.String("+")));f.Pc=923;continue;}
case 923:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",926);}
case 926:{f.Push(f.Locals[7]);f.Pc=928;continue;}
case 928:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",931);}
case 931:{f.Push(JValue.R(rt.String("/")));f.Pc=934;continue;}
case 934:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",937);}
case 937:{f.StackOp("pop");f.Pc=938;continue;}
case 938:{f.Push(f.Locals[8]);f.Pc=940;continue;}
case 940:{f.Pc=f.Pop().Int==0?974:943;continue;}
case 943:{f.Push(f.Locals[2]);f.Pc=944;continue;}
case 944:{f.Push(f.Locals[8]);f.Pc=946;continue;}
case 946:{f.Pc=f.Pop().Int<=0?955:949;continue;}
case 949:{f.Push(JValue.R(rt.String("+")));f.Pc=952;continue;}
case 952:{f.Pc=957;continue;}
case 955:{f.Push(JValue.R(rt.String("")));f.Pc=957;continue;}
case 957:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",960);}
case 960:{f.Push(f.Locals[8]);f.Pc=962;continue;}
case 962:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",965);}
case 965:{f.Push(JValue.R(rt.String(" ")));f.Pc=967;continue;}
case 967:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",970);}
case 970:{f.StackOp("pop");f.Pc=971;continue;}
case 971:{f.Pc=1003;continue;}
case 974:{f.Push(f.Locals[2]);f.Pc=975;continue;}
case 975:{f.Push(f.Locals[7]);f.Pc=977;continue;}
case 977:{f.Pc=f.Pop().Int>=0?986:980;continue;}
case 980:{f.Push(JValue.R(rt.String("-")));f.Pc=983;continue;}
case 983:{f.Pc=989;continue;}
case 986:{f.Push(JValue.R(rt.String("+")));f.Pc=989;continue;}
case 989:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",992);}
case 992:{f.Push(f.Locals[8]);f.Pc=994;continue;}
case 994:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",997);}
case 997:{f.Push(JValue.R(rt.String(" ")));f.Pc=999;continue;}
case 999:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1002);}
case 1002:{f.StackOp("pop");f.Pc=1003;continue;}
case 1003:{f.Push(f.Locals[2]);f.Pc=1004;continue;}
case 1004:{f.Push(f.Locals[10]);f.Pc=1006;continue;}
case 1006:{f.Pc=f.Pop().Int==0?1026:1009;continue;}
case 1009:{f.Push(f.Locals[11]);f.Pc=1011;continue;}
case 1011:{f.Pc=f.Pop().Int==0?1020:1014;continue;}
case 1014:{f.Push(JValue.R(rt.String("and gain ")));f.Pc=1017;continue;}
case 1017:{f.Pc=1028;continue;}
case 1020:{f.Push(JValue.R(rt.String("and gains ")));f.Pc=1023;continue;}
case 1023:{f.Pc=1028;continue;}
case 1026:{f.Push(JValue.R(rt.String("")));f.Pc=1028;continue;}
case 1028:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1031);}
case 1031:{f.StackOp("pop");f.Pc=1032;continue;}
case 1032:{f.Pc=1059;continue;}
case 1035:{f.Push(f.Locals[10]);f.Pc=1037;continue;}
case 1037:{f.Pc=f.Pop().Int==0?1059:1040;continue;}
case 1040:{f.Push(f.Locals[2]);f.Pc=1041;continue;}
case 1041:{f.Push(f.Locals[11]);f.Pc=1043;continue;}
case 1043:{f.Pc=f.Pop().Int==0?1052:1046;continue;}
case 1046:{f.Push(JValue.R(rt.String("gain ")));f.Pc=1049;continue;}
case 1049:{f.Pc=1055;continue;}
case 1052:{f.Push(JValue.R(rt.String("gains ")));f.Pc=1055;continue;}
case 1055:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1058);}
case 1058:{f.StackOp("pop");f.Pc=1059;continue;}
case 1059:{f.Push(JValue.I(0));f.Pc=1060;continue;}
case 1060:{f.Locals[12]=f.Pop();f.Pc=1062;continue;}
case 1062:{f.Push(f.Locals[12]);f.Pc=1064;continue;}
case 1064:{f.Push(f.Locals[4]);f.Pc=1066;continue;}
case 1066:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",1071);}
case 1071:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1200:1074;continue;}
case 1074:{f.Push(f.Locals[2]);f.Pc=1075;continue;}
case 1075:{f.Push(f.Locals[4]);f.Pc=1077;continue;}
case 1077:{f.Push(f.Locals[12]);f.Pc=1079;continue;}
case 1079:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",1084);}
case 1084:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1087;continue;}
case 1087:{f.Push(f.Locals[1]);f.Pc=1088;continue;}
case 1088:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1091);}
case 1091:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",1094);}
case 1094:{return rt.Call(f,"forge/game/ability/effects/PumpEffect","keywordText","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1097);}
case 1097:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1100);}
case 1100:{f.StackOp("pop");f.Pc=1101;continue;}
case 1101:{f.Push(f.Locals[2]);f.Pc=1102;continue;}
case 1102:{f.Push(f.Locals[4]);f.Pc=1104;continue;}
case 1104:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",1109);}
case 1109:{f.Push(JValue.I(2));f.Pc=1110;continue;}
case 1110:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1133:1113;continue;}
case 1113:{f.Push(f.Locals[12]);f.Pc=1115;continue;}
case 1115:{f.Push(JValue.I(1));f.Pc=1116;continue;}
case 1116:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1117;continue;}
case 1117:{f.Push(f.Locals[4]);f.Pc=1119;continue;}
case 1119:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",1124);}
case 1124:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?1133:1127;continue;}
case 1127:{f.Push(JValue.R(rt.String(", ")));f.Pc=1130;continue;}
case 1130:{f.Pc=1135;continue;}
case 1133:{f.Push(JValue.R(rt.String("")));f.Pc=1135;continue;}
case 1135:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1138);}
case 1138:{f.StackOp("pop");f.Pc=1139;continue;}
case 1139:{f.Push(f.Locals[2]);f.Pc=1140;continue;}
case 1140:{f.Push(f.Locals[4]);f.Pc=1142;continue;}
case 1142:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",1147);}
case 1147:{f.Push(JValue.I(2));f.Pc=1148;continue;}
case 1148:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?1161:1151;continue;}
case 1151:{f.Push(f.Locals[12]);f.Pc=1153;continue;}
case 1153:{f.Pc=f.Pop().Int!=0?1161:1156;continue;}
case 1156:{f.Push(JValue.R(rt.String(" ")));f.Pc=1158;continue;}
case 1158:{f.Pc=1163;continue;}
case 1161:{f.Push(JValue.R(rt.String("")));f.Pc=1163;continue;}
case 1163:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1166);}
case 1166:{f.StackOp("pop");f.Pc=1167;continue;}
case 1167:{f.Push(f.Locals[2]);f.Pc=1168;continue;}
case 1168:{f.Push(f.Locals[12]);f.Pc=1170;continue;}
case 1170:{f.Push(JValue.I(2));f.Pc=1171;continue;}
case 1171:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1172;continue;}
case 1172:{f.Push(f.Locals[4]);f.Pc=1174;continue;}
case 1174:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",1179);}
case 1179:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?1188:1182;continue;}
case 1182:{f.Push(JValue.R(rt.String("and ")));f.Pc=1185;continue;}
case 1185:{f.Pc=1190;continue;}
case 1188:{f.Push(JValue.R(rt.String("")));f.Pc=1190;continue;}
case 1190:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1193);}
case 1193:{f.StackOp("pop");f.Pc=1194;continue;}
case 1194:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=1197;continue;}
case 1197:{f.Pc=1062;continue;}
case 1200:{f.Push(JValue.I(0));f.Pc=1201;continue;}
case 1201:{f.Locals[12]=f.Pop();f.Pc=1203;continue;}
case 1203:{f.Push(f.Locals[12]);f.Pc=1205;continue;}
case 1205:{f.Push(f.Locals[5]);f.Pc=1207;continue;}
case 1207:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",1212);}
case 1212:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1264:1215;continue;}
case 1215:{f.Push(f.Locals[2]);f.Pc=1216;continue;}
case 1216:{f.Push(f.Locals[9]);f.Pc=1218;continue;}
case 1218:{f.Pc=f.Pop().Int!=0?1231:1221;continue;}
case 1221:{f.Push(f.Locals[10]);f.Pc=1223;continue;}
case 1223:{f.Pc=f.Pop().Int!=0?1231:1226;continue;}
case 1226:{f.Push(f.Locals[12]);f.Pc=1228;continue;}
case 1228:{f.Pc=f.Pop().Int<=0?1237:1231;continue;}
case 1231:{f.Push(JValue.R(rt.String(" and ")));f.Pc=1234;continue;}
case 1234:{f.Pc=1239;continue;}
case 1237:{f.Push(JValue.R(rt.String("")));f.Pc=1239;continue;}
case 1239:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1242);}
case 1242:{f.Push(f.Locals[5]);f.Pc=1244;continue;}
case 1244:{f.Push(f.Locals[12]);f.Pc=1246;continue;}
case 1246:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",1251);}
case 1251:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1254;continue;}
case 1254:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1257);}
case 1257:{f.StackOp("pop");f.Pc=1258;continue;}
case 1258:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=1261;continue;}
case 1261:{f.Pc=1203;continue;}
case 1264:{f.Push(f.Locals[10]);f.Pc=1266;continue;}
case 1266:{f.Pc=f.Pop().Int!=0?1279:1269;continue;}
case 1269:{f.Push(f.Locals[5]);f.Pc=1271;continue;}
case 1271:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1276);}
case 1276:{f.Pc=f.Pop().Int!=0?1283:1279;continue;}
case 1279:{f.Push(JValue.I(1));f.Pc=1280;continue;}
case 1280:{f.Pc=1284;continue;}
case 1283:{f.Push(JValue.I(0));f.Pc=1284;continue;}
case 1284:{f.Locals[10]=f.Pop();f.Pc=1286;continue;}
case 1286:{f.Push(f.Locals[1]);f.Pc=1287;continue;}
case 1287:{f.Push(JValue.R(rt.String("CanBlockAny")));f.Pc=1289;continue;}
case 1289:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1292);}
case 1292:{f.Pc=f.Pop().Int==0?1324:1295;continue;}
case 1295:{f.Push(f.Locals[9]);f.Pc=1297;continue;}
case 1297:{f.Pc=f.Pop().Int!=0?1305:1300;continue;}
case 1300:{f.Push(f.Locals[10]);f.Pc=1302;continue;}
case 1302:{f.Pc=f.Pop().Int==0?1313:1305;continue;}
case 1305:{f.Push(f.Locals[2]);f.Pc=1306;continue;}
case 1306:{f.Push(JValue.R(rt.String(" and ")));f.Pc=1309;continue;}
case 1309:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1312);}
case 1312:{f.StackOp("pop");f.Pc=1313;continue;}
case 1313:{f.Push(f.Locals[2]);f.Pc=1314;continue;}
case 1314:{f.Push(JValue.R(rt.String("can block any number of creatures")));f.Pc=1317;continue;}
case 1317:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1320);}
case 1320:{f.StackOp("pop");f.Pc=1321;continue;}
case 1321:{f.Pc=1405;continue;}
case 1324:{f.Push(f.Locals[1]);f.Pc=1325;continue;}
case 1325:{f.Push(JValue.R(rt.String("CanBlockAmount")));f.Pc=1327;continue;}
case 1327:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1330);}
case 1330:{f.Pc=f.Pop().Int==0?1405:1333;continue;}
case 1333:{f.Push(f.Locals[9]);f.Pc=1335;continue;}
case 1335:{f.Pc=f.Pop().Int!=0?1343:1338;continue;}
case 1338:{f.Push(f.Locals[10]);f.Pc=1340;continue;}
case 1340:{f.Pc=f.Pop().Int==0?1351:1343;continue;}
case 1343:{f.Push(f.Locals[2]);f.Pc=1344;continue;}
case 1344:{f.Push(JValue.R(rt.String(" and ")));f.Pc=1347;continue;}
case 1347:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1350);}
case 1350:{f.StackOp("pop");f.Pc=1351;continue;}
case 1351:{f.Push(f.Locals[1]);f.Pc=1352;continue;}
case 1352:{f.Push(JValue.R(rt.String("CanBlockAmount")));f.Pc=1354;continue;}
case 1354:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1357);}
case 1357:{f.Locals[12]=f.Pop();f.Pc=1359;continue;}
case 1359:{f.Push(f.Locals[2]);f.Pc=1360;continue;}
case 1360:{f.Push(JValue.R(rt.String("can block an additional ")));f.Pc=1363;continue;}
case 1363:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1366);}
case 1366:{f.StackOp("pop");f.Pc=1367;continue;}
case 1367:{f.Push(f.Locals[2]);f.Pc=1368;continue;}
case 1368:{f.Push(JValue.R(rt.String("1")));f.Pc=1371;continue;}
case 1371:{f.Push(f.Locals[12]);f.Pc=1373;continue;}
case 1373:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1376);}
case 1376:{f.Pc=f.Pop().Int==0?1385:1379;continue;}
case 1379:{f.Push(JValue.R(rt.String("creature")));f.Pc=1382;continue;}
case 1382:{f.Pc=1393;continue;}
case 1385:{f.Push(f.Locals[12]);f.Pc=1387;continue;}
case 1387:{f.Push(JValue.R(rt.String("creature")));f.Pc=1390;continue;}
case 1390:{return rt.Call(f,"forge/util/Lang","nounWithNumeral","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1393);}
case 1393:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1396);}
case 1396:{f.StackOp("pop");f.Pc=1397;continue;}
case 1397:{f.Push(f.Locals[2]);f.Pc=1398;continue;}
case 1398:{f.Push(JValue.R(rt.String(" each combat")));f.Pc=1401;continue;}
case 1401:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1404);}
case 1404:{f.StackOp("pop");f.Pc=1405;continue;}
case 1405:{f.Push(f.Locals[1]);f.Pc=1406;continue;}
case 1406:{f.Push(JValue.R(rt.String("Duration")));f.Pc=1408;continue;}
case 1408:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1411);}
case 1411:{f.Locals[12]=f.Pop();f.Pc=1413;continue;}
case 1413:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=1415;continue;}
case 1415:{f.Push(f.Locals[12]);f.Pc=1417;continue;}
case 1417:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1420);}
case 1420:{f.Pc=f.Pop().Int!=0?1455:1423;continue;}
case 1423:{f.Push(JValue.R(rt.String("UntilUntaps")));f.Pc=1425;continue;}
case 1425:{f.Push(f.Locals[12]);f.Pc=1427;continue;}
case 1427:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1430);}
case 1430:{f.Pc=f.Pop().Int==0?1444:1433;continue;}
case 1433:{f.Push(f.Locals[2]);f.Pc=1434;continue;}
case 1434:{f.Push(JValue.R(rt.String(" for as long as CARDNAME remains tapped.")));f.Pc=1437;continue;}
case 1437:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1440);}
case 1440:{f.StackOp("pop");f.Pc=1441;continue;}
case 1441:{f.Pc=1463;continue;}
case 1444:{f.Push(f.Locals[2]);f.Pc=1445;continue;}
case 1445:{f.Push(JValue.R(rt.String(" until end of turn.")));f.Pc=1448;continue;}
case 1448:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1451);}
case 1451:{f.StackOp("pop");f.Pc=1452;continue;}
case 1452:{f.Pc=1463;continue;}
case 1455:{f.Push(f.Locals[2]);f.Pc=1456;continue;}
case 1456:{f.Push(JValue.R(rt.String(".")));f.Pc=1459;continue;}
case 1459:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1462);}
case 1462:{f.StackOp("pop");f.Pc=1463;continue;}
case 1463:{f.Push(f.Locals[2]);f.Pc=1464;continue;}
case 1464:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1467);}
case 1467:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3593(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Duration")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/ability/effects/PumpEffect","checkValidDuration","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokestatic",10);}
case 10:{f.Pc=f.Pop().Int!=0?14:13;continue;}
case 13:{return JStep.ReturnVoid;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",23);}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",28);}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",34);}
case 34:{f.Locals[5]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/ability/effects/PumpEffect","getCardsfromTargets","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",40);}
case 40:{f.Locals[7]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/ability/effects/PumpEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",46);}
case 46:{f.Locals[8]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("Optional")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int==0?159:58;continue;}
case 58:{f.Push(f.Locals[7]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",63);}
case 63:{f.Locals[9]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("OptionQuestion")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?93:75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("OptionQuestion")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",82);}
case 82:{f.Push(JValue.R(rt.String("TARGETS")));f.Pc=85;continue;}
case 85:{f.Push(f.Locals[9]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",90);}
case 90:{f.Pc=111;continue;}
case 93:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",96);}
case 96:{f.Push(JValue.R(rt.String("lblApplyPumpToTarget")));f.Pc=99;continue;}
case 99:{f.Push(JValue.I(1));f.Pc=100;continue;}
case 100:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=103;continue;}
case 103:{f.StackOp("dup");f.Pc=104;continue;}
case 104:{f.Push(JValue.I(0));f.Pc=105;continue;}
case 105:{f.Push(f.Locals[9]);f.Pc=107;continue;}
case 107:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",111);}
case 111:{f.Locals[10]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(f.Locals[7]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",120);}
case 120:{f.Push(JValue.I(1));f.Pc=121;continue;}
case 121:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?138:124;continue;}
case 124:{f.Push(f.Locals[7]);f.Pc=126;continue;}
case 126:{f.Push(JValue.I(0));f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",132);}
case 132:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=135;continue;}
case 135:{f.Pc=139;continue;}
case 138:{f.Push(JValue.R(null));f.Pc=139;continue;}
case 139:{f.Locals[11]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[2]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",145);}
case 145:{f.Push(f.Locals[1]);f.Pc=146;continue;}
case 146:{f.Push(JValue.R(null));f.Pc=147;continue;}
case 147:{f.Push(f.Locals[10]);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[11]);f.Pc=151;continue;}
case 151:{f.Push(JValue.R(null));f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",155);}
case 155:{f.Pc=f.Pop().Int!=0?159:158;continue;}
case 158:{return JStep.ReturnVoid;}
case 159:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",162);}
case 162:{f.Locals[9]=f.Pop();f.Pc=164;continue;}
case 164:{f.Push(f.Locals[1]);f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String("KW")));f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",171);}
case 171:{f.Pc=f.Pop().Int==0?201:174;continue;}
case 174:{f.Push(f.Locals[9]);f.Pc=176;continue;}
case 176:{f.Push(f.Locals[1]);f.Pc=177;continue;}
case 177:{f.Push(JValue.R(rt.String("KW")));f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",183);}
case 183:{f.Push(JValue.R(rt.String(" & ")));f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",189);}
case 189:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",192);}
case 192:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",197);}
case 197:{f.StackOp("pop");f.Pc=198;continue;}
case 198:{f.Pc=275;continue;}
case 201:{f.Push(f.Locals[1]);f.Pc=202;continue;}
case 202:{f.Push(JValue.R(rt.String("KWChoice")));f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",208);}
case 208:{f.Pc=f.Pop().Int==0?275:211;continue;}
case 211:{f.Push(f.Locals[1]);f.Pc=212;continue;}
case 212:{f.Push(JValue.R(rt.String("KWChoice")));f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",218);}
case 218:{f.Push(JValue.R(rt.String(",")));f.Pc=221;continue;}
case 221:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",224);}
case 224:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",227);}
case 227:{f.Locals[10]=f.Pop();f.Pc=229;continue;}
case 229:{f.Push(f.Locals[2]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",233);}
case 233:{f.Push(f.Locals[10]);f.Pc=235;continue;}
case 235:{f.Push(f.Locals[1]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",239);}
case 239:{f.Push(JValue.R(rt.String("lblChooseKeyword")));f.Pc=242;continue;}
case 242:{f.Push(JValue.I(0));f.Pc=243;continue;}
case 243:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",249);}
case 249:{f.Push(f.Locals[7]);f.Pc=251;continue;}
case 251:{f.Push(JValue.I(0));f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",257);}
case 257:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/player/PlayerController","chooseKeywordForPump","(Ljava/util/List;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/card/Card;)Ljava/lang/String;","invokevirtual",263);}
case 263:{f.Locals[11]=f.Pop();f.Pc=265;continue;}
case 265:{f.Push(f.Locals[9]);f.Pc=267;continue;}
case 267:{f.Push(f.Locals[11]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",274);}
case 274:{f.StackOp("pop");f.Pc=275;continue;}
case 275:{f.Push(JValue.I(0));f.Pc=276;continue;}
case 276:{f.Locals[10]=f.Pop();f.Pc=278;continue;}
case 278:{f.Push(JValue.I(0));f.Pc=279;continue;}
case 279:{f.Locals[11]=f.Pop();f.Pc=281;continue;}
case 281:{f.Push(f.Locals[1]);f.Pc=282;continue;}
case 282:{f.Push(JValue.R(rt.String("NumAtt")));f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",288);}
case 288:{f.Pc=f.Pop().Int==0?339:291;continue;}
case 291:{f.Push(f.Locals[1]);f.Pc=292;continue;}
case 292:{f.Push(JValue.R(rt.String("NumAtt")));f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",298);}
case 298:{f.Push(JValue.R(rt.String("Double")));f.Pc=301;continue;}
case 301:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",304);}
case 304:{f.Pc=f.Pop().Int!=0?339:307;continue;}
case 307:{f.Push(f.Locals[1]);f.Pc=308;continue;}
case 308:{f.Push(JValue.R(rt.String("NumAtt")));f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",314);}
case 314:{f.Push(JValue.R(rt.String("Triple")));f.Pc=317;continue;}
case 317:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",320);}
case 320:{f.Pc=f.Pop().Int!=0?339:323;continue;}
case 323:{f.Push(f.Locals[4]);f.Pc=325;continue;}
case 325:{f.Push(f.Locals[1]);f.Pc=326;continue;}
case 326:{f.Push(JValue.R(rt.String("NumAtt")));f.Pc=329;continue;}
case 329:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",332);}
case 332:{f.Push(f.Locals[1]);f.Pc=333;continue;}
case 333:{f.Push(JValue.I(1));f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;Z)I","invokestatic",337);}
case 337:{f.Locals[10]=f.Pop();f.Pc=339;continue;}
case 339:{f.Push(f.Locals[1]);f.Pc=340;continue;}
case 340:{f.Push(JValue.R(rt.String("NumDef")));f.Pc=343;continue;}
case 343:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",346);}
case 346:{f.Pc=f.Pop().Int==0?397:349;continue;}
case 349:{f.Push(f.Locals[1]);f.Pc=350;continue;}
case 350:{f.Push(JValue.R(rt.String("NumDef")));f.Pc=353;continue;}
case 353:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",356);}
case 356:{f.Push(JValue.R(rt.String("Double")));f.Pc=359;continue;}
case 359:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",362);}
case 362:{f.Pc=f.Pop().Int!=0?397:365;continue;}
case 365:{f.Push(f.Locals[1]);f.Pc=366;continue;}
case 366:{f.Push(JValue.R(rt.String("NumDef")));f.Pc=369;continue;}
case 369:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",372);}
case 372:{f.Push(JValue.R(rt.String("Triple")));f.Pc=375;continue;}
case 375:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",378);}
case 378:{f.Pc=f.Pop().Int!=0?397:381;continue;}
case 381:{f.Push(f.Locals[4]);f.Pc=383;continue;}
case 383:{f.Push(f.Locals[1]);f.Pc=384;continue;}
case 384:{f.Push(JValue.R(rt.String("NumDef")));f.Pc=387;continue;}
case 387:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",390);}
case 390:{f.Push(f.Locals[1]);f.Pc=391;continue;}
case 391:{f.Push(JValue.I(1));f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;Z)I","invokestatic",395);}
case 395:{f.Locals[11]=f.Pop();f.Pc=397;continue;}
case 397:{f.Push(f.Locals[1]);f.Pc=398;continue;}
case 398:{f.Push(JValue.R(rt.String("SharedKeywordsZone")));f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",404);}
case 404:{f.Pc=f.Pop().Int==0?471:407;continue;}
case 407:{f.Push(f.Locals[1]);f.Pc=408;continue;}
case 408:{f.Push(JValue.R(rt.String("SharedKeywordsZone")));f.Pc=411;continue;}
case 411:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",414);}
case 414:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",417);}
case 417:{f.Locals[12]=f.Pop();f.Pc=419;continue;}
case 419:{f.Push(f.Locals[1]);f.Pc=420;continue;}
case 420:{f.Push(JValue.R(rt.String("SharedRestrictions")));f.Pc=423;continue;}
case 423:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",426);}
case 426:{f.Pc=f.Pop().Int==0?445:429;continue;}
case 429:{f.Push(f.Locals[1]);f.Pc=430;continue;}
case 430:{f.Push(JValue.R(rt.String("SharedRestrictions")));f.Pc=433;continue;}
case 433:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",436);}
case 436:{f.Push(JValue.R(rt.String(",")));f.Pc=439;continue;}
case 439:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",442);}
case 442:{f.Pc=455;continue;}
case 445:{f.Push(JValue.I(1));f.Pc=446;continue;}
case 446:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=449;continue;}
case 449:{f.StackOp("dup");f.Pc=450;continue;}
case 450:{f.Push(JValue.I(0));f.Pc=451;continue;}
case 451:{f.Push(JValue.R(rt.String("Card")));f.Pc=454;continue;}
case 454:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=455;continue;}
case 455:{f.Locals[13]=f.Pop();f.Pc=457;continue;}
case 457:{f.Push(f.Locals[9]);f.Pc=459;continue;}
case 459:{f.Push(f.Locals[13]);f.Pc=461;continue;}
case 461:{f.Push(f.Locals[12]);f.Pc=463;continue;}
case 463:{f.Push(f.Locals[4]);f.Pc=465;continue;}
case 465:{f.Push(f.Locals[1]);f.Pc=466;continue;}
case 466:{return rt.Call(f,"forge/game/card/CardFactoryUtil","sharedKeywords","(Ljava/lang/Iterable;[Ljava/lang/String;Ljava/lang/Iterable;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/List;","invokestatic",469);}
case 469:{f.Locals[9]=f.Pop();f.Pc=471;continue;}
case 471:{f.Push(f.Locals[1]);f.Pc=472;continue;}
case 472:{f.Push(JValue.R(rt.String("DefinedKW")));f.Pc=475;continue;}
case 475:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",478);}
case 478:{f.Pc=f.Pop().Int==0?845:481;continue;}
case 481:{f.Push(f.Locals[1]);f.Pc=482;continue;}
case 482:{f.Push(JValue.R(rt.String("DefinedKW")));f.Pc=485;continue;}
case 485:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",488);}
case 488:{f.Locals[12]=f.Pop();f.Pc=490;continue;}
case 490:{f.Push(f.Locals[12]);f.Pc=492;continue;}
case 492:{f.Push(JValue.R(rt.String("ChosenType")));f.Pc=495;continue;}
case 495:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",498);}
case 498:{f.Pc=f.Pop().Int==0?578:501;continue;}
case 501:{f.Push(f.Locals[4]);f.Pc=503;continue;}
case 503:{return rt.Call(f,"forge/game/card/Card","hasChosenType","()Z","invokevirtual",506);}
case 506:{f.Pc=f.Pop().Int!=0?510:509;continue;}
case 509:{return JStep.ReturnVoid;}
case 510:{f.Push(f.Locals[4]);f.Pc=512;continue;}
case 512:{return rt.Call(f,"forge/game/card/Card","getChosenType","()Ljava/lang/String;","invokevirtual",515);}
case 515:{f.Locals[13]=f.Pop();f.Pc=517;continue;}
case 517:{f.Push(JValue.I(0));f.Pc=518;continue;}
case 518:{f.Locals[14]=f.Pop();f.Pc=520;continue;}
case 520:{f.Push(f.Locals[14]);f.Pc=522;continue;}
case 522:{f.Push(f.Locals[9]);f.Pc=524;continue;}
case 524:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",529);}
case 529:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?575:532;continue;}
case 532:{f.Push(f.Locals[9]);f.Pc=534;continue;}
case 534:{f.Push(f.Locals[14]);f.Pc=536;continue;}
case 536:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",541);}
case 541:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=544;continue;}
case 544:{f.Locals[15]=f.Pop();f.Pc=546;continue;}
case 546:{f.Push(f.Locals[15]);f.Pc=548;continue;}
case 548:{f.Push(f.Locals[12]);f.Pc=550;continue;}
case 550:{f.Push(f.Locals[13]);f.Pc=552;continue;}
case 552:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",555);}
case 555:{f.Locals[15]=f.Pop();f.Pc=557;continue;}
case 557:{f.Push(f.Locals[9]);f.Pc=559;continue;}
case 559:{f.Push(f.Locals[14]);f.Pc=561;continue;}
case 561:{f.Push(f.Locals[15]);f.Pc=563;continue;}
case 563:{return rt.Call(f,"java/util/List","set","(ILjava/lang/Object;)Ljava/lang/Object;","invokeinterface",568);}
case 568:{f.StackOp("pop");f.Pc=569;continue;}
case 569:{f.Locals[14]=JValue.I(unchecked(f.Locals[14].Int+(1)));f.Pc=572;continue;}
case 572:{f.Pc=520;continue;}
case 575:{f.Pc=845;continue;}
case 578:{f.Push(f.Locals[12]);f.Pc=580;continue;}
case 580:{f.Push(JValue.R(rt.String("ChosenPlayer")));f.Pc=583;continue;}
case 583:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",586);}
case 586:{f.Pc=f.Pop().Int==0?688:589;continue;}
case 589:{f.Push(f.Locals[4]);f.Pc=591;continue;}
case 591:{return rt.Call(f,"forge/game/card/Card","hasChosenPlayer","()Z","invokevirtual",594);}
case 594:{f.Pc=f.Pop().Int!=0?598:597;continue;}
case 597:{return JStep.ReturnVoid;}
case 598:{f.Push(f.Locals[4]);f.Pc=600;continue;}
case 600:{return rt.Call(f,"forge/game/card/Card","getChosenPlayer","()Lforge/game/player/Player;","invokevirtual",603);}
case 603:{f.Locals[13]=f.Pop();f.Pc=605;continue;}
case 605:{f.Push(JValue.I(0));f.Pc=606;continue;}
case 606:{f.Locals[14]=f.Pop();f.Pc=608;continue;}
case 608:{f.Push(f.Locals[14]);f.Pc=610;continue;}
case 610:{f.Push(f.Locals[9]);f.Pc=612;continue;}
case 612:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",617);}
case 617:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?685:620;continue;}
case 620:{f.Push(f.Locals[9]);f.Pc=622;continue;}
case 622:{f.Push(f.Locals[14]);f.Pc=624;continue;}
case 624:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",629);}
case 629:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=632;continue;}
case 632:{f.Locals[15]=f.Pop();f.Pc=634;continue;}
case 634:{f.Push(f.Locals[15]);f.Pc=636;continue;}
case 636:{f.Push(JValue.R(rt.String("ChosenPlayerUID")));f.Pc=639;continue;}
case 639:{f.Push(f.Locals[13]);f.Pc=641;continue;}
case 641:{return rt.Call(f,"forge/game/player/Player","getId","()I","invokevirtual",644);}
case 644:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",647);}
case 647:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",650);}
case 650:{f.Locals[15]=f.Pop();f.Pc=652;continue;}
case 652:{f.Push(f.Locals[15]);f.Pc=654;continue;}
case 654:{f.Push(JValue.R(rt.String("ChosenPlayerName")));f.Pc=657;continue;}
case 657:{f.Push(f.Locals[13]);f.Pc=659;continue;}
case 659:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",662);}
case 662:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",665);}
case 665:{f.Locals[15]=f.Pop();f.Pc=667;continue;}
case 667:{f.Push(f.Locals[9]);f.Pc=669;continue;}
case 669:{f.Push(f.Locals[14]);f.Pc=671;continue;}
case 671:{f.Push(f.Locals[15]);f.Pc=673;continue;}
case 673:{return rt.Call(f,"java/util/List","set","(ILjava/lang/Object;)Ljava/lang/Object;","invokeinterface",678);}
case 678:{f.StackOp("pop");f.Pc=679;continue;}
case 679:{f.Locals[14]=JValue.I(unchecked(f.Locals[14].Int+(1)));f.Pc=682;continue;}
case 682:{f.Pc=608;continue;}
case 685:{f.Pc=845;continue;}
case 688:{f.Push(f.Locals[12]);f.Pc=690;continue;}
case 690:{f.Push(JValue.R(rt.String("ChosenColor")));f.Pc=693;continue;}
case 693:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",696);}
case 696:{f.Pc=f.Pop().Int==0?794:699;continue;}
case 699:{f.Push(f.Locals[4]);f.Pc=701;continue;}
case 701:{return rt.Call(f,"forge/game/card/Card","hasChosenColor","()Z","invokevirtual",704);}
case 704:{f.Pc=f.Pop().Int!=0?708:707;continue;}
case 707:{return JStep.ReturnVoid;}
case 708:{f.Push(JValue.I(0));f.Pc=709;continue;}
case 709:{f.Locals[13]=f.Pop();f.Pc=711;continue;}
case 711:{f.Push(f.Locals[13]);f.Pc=713;continue;}
case 713:{f.Push(f.Locals[9]);f.Pc=715;continue;}
case 715:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",720);}
case 720:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?791:723;continue;}
case 723:{f.Push(f.Locals[9]);f.Pc=725;continue;}
case 725:{f.Push(f.Locals[13]);f.Pc=727;continue;}
case 727:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",732);}
case 732:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=735;continue;}
case 735:{f.Locals[14]=f.Pop();f.Pc=737;continue;}
case 737:{f.Push(f.Locals[14]);f.Pc=739;continue;}
case 739:{f.Push(JValue.R(rt.String("ChosenColor")));f.Pc=742;continue;}
case 742:{f.Push(f.Locals[4]);f.Pc=744;continue;}
case 744:{return rt.Call(f,"forge/game/card/Card","getChosenColor","()Ljava/lang/String;","invokevirtual",747);}
case 747:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",750);}
case 750:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",753);}
case 753:{f.Locals[14]=f.Pop();f.Pc=755;continue;}
case 755:{f.Push(f.Locals[14]);f.Pc=757;continue;}
case 757:{f.Push(JValue.R(rt.String("chosenColor")));f.Pc=760;continue;}
case 760:{f.Push(f.Locals[4]);f.Pc=762;continue;}
case 762:{return rt.Call(f,"forge/game/card/Card","getChosenColor","()Ljava/lang/String;","invokevirtual",765);}
case 765:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",768);}
case 768:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",771);}
case 771:{f.Locals[14]=f.Pop();f.Pc=773;continue;}
case 773:{f.Push(f.Locals[9]);f.Pc=775;continue;}
case 775:{f.Push(f.Locals[13]);f.Pc=777;continue;}
case 777:{f.Push(f.Locals[14]);f.Pc=779;continue;}
case 779:{return rt.Call(f,"java/util/List","set","(ILjava/lang/Object;)Ljava/lang/Object;","invokeinterface",784);}
case 784:{f.StackOp("pop");f.Pc=785;continue;}
case 785:{f.Locals[13]=JValue.I(unchecked(f.Locals[13].Int+(1)));f.Pc=788;continue;}
case 788:{f.Pc=711;continue;}
case 791:{f.Pc=845;continue;}
case 794:{f.Push(f.Locals[4]);f.Pc=796;continue;}
case 796:{f.Push(f.Locals[12]);f.Pc=798;continue;}
case 798:{f.Push(f.Locals[1]);f.Pc=799;continue;}
case 799:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",802);}
case 802:{f.Locals[13]=f.Pop();f.Pc=804;continue;}
case 804:{f.Push(f.Locals[13]);f.Pc=806;continue;}
case 806:{return rt.Call(f,"forge/game/player/PlayerCollection","isEmpty","()Z","invokevirtual",809);}
case 809:{f.Pc=f.Pop().Int==0?813:812;continue;}
case 812:{return JStep.ReturnVoid;}
case 813:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",816);}
case 816:{f.Locals[14]=f.Pop();f.Pc=818;continue;}
case 818:{f.Push(f.Locals[9]);f.Pc=820;continue;}
case 820:{f.Push(f.Locals[13]);f.Pc=822;continue;}
case 822:{f.Push(f.Locals[14]);f.Pc=824;continue;}
case 824:{return rt.DynamicCall(f,"forge/game/ability/effects/PumpEffect:3593:824:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/player/PlayerCollection;Ljava/util/List;)Ljava/util/function/Predicate;",829);}
case 829:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",834);}
case 834:{f.StackOp("pop");f.Pc=835;continue;}
case 835:{f.Push(f.Locals[9]);f.Pc=837;continue;}
case 837:{f.Push(f.Locals[14]);f.Pc=839;continue;}
case 839:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",844);}
case 844:{f.StackOp("pop");f.Pc=845;continue;}
case 845:{f.Push(f.Locals[1]);f.Pc=846;continue;}
case 846:{f.Push(JValue.R(rt.String("DefinedLandwalk")));f.Pc=849;continue;}
case 849:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",852);}
case 852:{f.Pc=f.Pop().Int==0?959:855;continue;}
case 855:{f.Push(f.Locals[1]);f.Pc=856;continue;}
case 856:{f.Push(JValue.R(rt.String("DefinedLandwalk")));f.Pc=859;continue;}
case 859:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",862);}
case 862:{f.Locals[12]=f.Pop();f.Pc=864;continue;}
case 864:{f.Push(f.Locals[4]);f.Pc=866;continue;}
case 866:{f.Push(f.Locals[12]);f.Pc=868;continue;}
case 868:{f.Push(f.Locals[1]);f.Pc=869;continue;}
case 869:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",872);}
case 872:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",875);}
case 875:{f.Locals[13]=f.Pop();f.Pc=877;continue;}
case 877:{f.Push(f.Locals[13]);f.Pc=879;continue;}
case 879:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",884);}
case 884:{f.Pc=f.Pop().Int==0?959:887;continue;}
case 887:{f.Push(f.Locals[13]);f.Pc=889;continue;}
case 889:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",894);}
case 894:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=897;continue;}
case 897:{f.Locals[14]=f.Pop();f.Pc=899;continue;}
case 899:{f.Push(f.Locals[14]);f.Pc=901;continue;}
case 901:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",904);}
case 904:{return rt.Call(f,"forge/card/CardTypeView","getLandTypes","()Ljava/util/Set;","invokeinterface",909);}
case 909:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",914);}
case 914:{f.Locals[15]=f.Pop();f.Pc=916;continue;}
case 916:{f.Push(f.Locals[15]);f.Pc=918;continue;}
case 918:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",923);}
case 923:{f.Pc=f.Pop().Int==0?956:926;continue;}
case 926:{f.Push(f.Locals[15]);f.Pc=928;continue;}
case 928:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",933);}
case 933:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=936;continue;}
case 936:{f.Locals[16]=f.Pop();f.Pc=938;continue;}
case 938:{f.Push(f.Locals[9]);f.Pc=940;continue;}
case 940:{f.Push(f.Locals[16]);f.Pc=942;continue;}
case 942:{return rt.DynamicCall(f,"forge/game/ability/effects/PumpEffect:3593:942:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",947);}
case 947:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",952);}
case 952:{f.StackOp("pop");f.Pc=953;continue;}
case 953:{f.Pc=916;continue;}
case 956:{f.Pc=877;continue;}
case 959:{f.Push(f.Locals[1]);f.Pc=960;continue;}
case 960:{f.Push(JValue.R(rt.String("RandomKeyword")));f.Pc=963;continue;}
case 963:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",966);}
case 966:{f.Pc=f.Pop().Int==0?1150:969;continue;}
case 969:{f.Push(f.Locals[1]);f.Pc=970;continue;}
case 970:{f.Push(JValue.R(rt.String("RandomKWNum")));f.Pc=973;continue;}
case 973:{f.Push(JValue.R(rt.String("1")));f.Pc=976;continue;}
case 976:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",979);}
case 979:{f.Locals[12]=f.Pop();f.Pc=981;continue;}
case 981:{f.Push(f.Locals[4]);f.Pc=983;continue;}
case 983:{f.Push(f.Locals[12]);f.Pc=985;continue;}
case 985:{f.Push(f.Locals[1]);f.Pc=986;continue;}
case 986:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",989);}
case 989:{f.Locals[13]=f.Pop();f.Pc=991;continue;}
case 991:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",994);}
case 994:{f.Locals[14]=f.Pop();f.Pc=996;continue;}
case 996:{f.Push(f.Locals[9]);f.Pc=998;continue;}
case 998:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",1001);}
case 1001:{f.Locals[15]=f.Pop();f.Pc=1003;continue;}
case 1003:{f.Push(f.Locals[1]);f.Pc=1004;continue;}
case 1004:{f.Push(JValue.R(rt.String("NoRepetition")));f.Pc=1007;continue;}
case 1007:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1010);}
case 1010:{f.Pc=f.Pop().Int==0?1086:1013;continue;}
case 1013:{f.Push(f.Locals[7]);f.Pc=1015;continue;}
case 1015:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1020);}
case 1020:{f.Pc=f.Pop().Int!=0?1086:1023;continue;}
case 1023:{f.Push(f.Locals[9]);f.Pc=1025;continue;}
case 1025:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1030);}
case 1030:{f.Locals[16]=f.Pop();f.Pc=1032;continue;}
case 1032:{f.Push(f.Locals[16]);f.Pc=1034;continue;}
case 1034:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1039);}
case 1039:{f.Pc=f.Pop().Int==0?1086:1042;continue;}
case 1042:{f.Push(f.Locals[16]);f.Pc=1044;continue;}
case 1044:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1049);}
case 1049:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1052;continue;}
case 1052:{f.Locals[17]=f.Pop();f.Pc=1054;continue;}
case 1054:{f.Push(f.Locals[7]);f.Pc=1056;continue;}
case 1056:{f.Push(JValue.I(0));f.Pc=1057;continue;}
case 1057:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",1062);}
case 1062:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1065;continue;}
case 1065:{f.Push(f.Locals[17]);f.Pc=1067;continue;}
case 1067:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",1070);}
case 1070:{f.Pc=f.Pop().Int==0?1083:1073;continue;}
case 1073:{f.Push(f.Locals[15]);f.Pc=1075;continue;}
case 1075:{f.Push(f.Locals[17]);f.Pc=1077;continue;}
case 1077:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",1082);}
case 1082:{f.StackOp("pop");f.Pc=1083;continue;}
case 1083:{f.Pc=1032;continue;}
case 1086:{f.Push(f.Locals[15]);f.Pc=1088;continue;}
case 1088:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",1093);}
case 1093:{f.Push(f.Locals[13]);f.Pc=1095;continue;}
case 1095:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",1098);}
case 1098:{f.Locals[16]=f.Pop();f.Pc=1100;continue;}
case 1100:{f.Push(JValue.I(0));f.Pc=1101;continue;}
case 1101:{f.Locals[17]=f.Pop();f.Pc=1103;continue;}
case 1103:{f.Push(f.Locals[17]);f.Pc=1105;continue;}
case 1105:{f.Push(f.Locals[16]);f.Pc=1107;continue;}
case 1107:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1146:1110;continue;}
case 1110:{f.Push(f.Locals[15]);f.Pc=1112;continue;}
case 1112:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",1115);}
case 1115:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1118;continue;}
case 1118:{f.Locals[18]=f.Pop();f.Pc=1120;continue;}
case 1120:{f.Push(f.Locals[14]);f.Pc=1122;continue;}
case 1122:{f.Push(f.Locals[18]);f.Pc=1124;continue;}
case 1124:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1129);}
case 1129:{f.StackOp("pop");f.Pc=1130;continue;}
case 1130:{f.Push(f.Locals[15]);f.Pc=1132;continue;}
case 1132:{f.Push(f.Locals[18]);f.Pc=1134;continue;}
case 1134:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",1139);}
case 1139:{f.StackOp("pop");f.Pc=1140;continue;}
case 1140:{f.Locals[17]=JValue.I(unchecked(f.Locals[17].Int+(1)));f.Pc=1143;continue;}
case 1143:{f.Pc=1103;continue;}
case 1146:{f.Push(f.Locals[14]);f.Pc=1148;continue;}
case 1148:{f.Locals[9]=f.Pop();f.Pc=1150;continue;}
case 1150:{f.Push(f.Locals[1]);f.Pc=1151;continue;}
case 1151:{f.Push(JValue.R(rt.String("RememberObjects")));f.Pc=1154;continue;}
case 1154:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1157);}
case 1157:{f.Pc=f.Pop().Int==0?1178:1160;continue;}
case 1160:{f.Push(f.Locals[4]);f.Pc=1162;continue;}
case 1162:{f.Push(f.Locals[4]);f.Pc=1164;continue;}
case 1164:{f.Push(f.Locals[1]);f.Pc=1165;continue;}
case 1165:{f.Push(JValue.R(rt.String("RememberObjects")));f.Pc=1168;continue;}
case 1168:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1171);}
case 1171:{f.Push(f.Locals[1]);f.Pc=1172;continue;}
case 1172:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedObjects","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",1175);}
case 1175:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1178);}
case 1178:{f.Push(f.Locals[1]);f.Pc=1179;continue;}
case 1179:{f.Push(JValue.R(rt.String("NoteCardsFor")));f.Pc=1182;continue;}
case 1182:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1185);}
case 1185:{f.Pc=f.Pop().Int==0?1287:1188;continue;}
case 1188:{f.Push(f.Locals[4]);f.Pc=1190;continue;}
case 1190:{f.Push(f.Locals[1]);f.Pc=1191;continue;}
case 1191:{f.Push(JValue.R(rt.String("NoteCards")));f.Pc=1194;continue;}
case 1194:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1197);}
case 1197:{f.Push(f.Locals[1]);f.Pc=1198;continue;}
case 1198:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1201);}
case 1201:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1204);}
case 1204:{f.Locals[12]=f.Pop();f.Pc=1206;continue;}
case 1206:{f.Push(f.Locals[12]);f.Pc=1208;continue;}
case 1208:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1213);}
case 1213:{f.Pc=f.Pop().Int==0?1287:1216;continue;}
case 1216:{f.Push(f.Locals[12]);f.Pc=1218;continue;}
case 1218:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1223);}
case 1223:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1226;continue;}
case 1226:{f.Locals[13]=f.Pop();f.Pc=1228;continue;}
case 1228:{f.Push(f.Locals[8]);f.Pc=1230;continue;}
case 1230:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1235);}
case 1235:{f.Locals[14]=f.Pop();f.Pc=1237;continue;}
case 1237:{f.Push(f.Locals[14]);f.Pc=1239;continue;}
case 1239:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1244);}
case 1244:{f.Pc=f.Pop().Int==0?1284:1247;continue;}
case 1247:{f.Push(f.Locals[14]);f.Pc=1249;continue;}
case 1249:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1254);}
case 1254:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1257;continue;}
case 1257:{f.Locals[15]=f.Pop();f.Pc=1259;continue;}
case 1259:{f.Push(f.Locals[15]);f.Pc=1261;continue;}
case 1261:{f.Push(f.Locals[1]);f.Pc=1262;continue;}
case 1262:{f.Push(JValue.R(rt.String("NoteCardsFor")));f.Pc=1265;continue;}
case 1265:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1268);}
case 1268:{f.Push(f.Locals[13]);f.Pc=1270;continue;}
case 1270:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",1273);}
case 1273:{return rt.DynamicCall(f,"forge/game/ability/effects/PumpEffect:3593:1273:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",1278);}
case 1278:{return rt.Call(f,"forge/game/player/Player","addNoteForName","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",1281);}
case 1281:{f.Pc=1237;continue;}
case 1284:{f.Pc=1206;continue;}
case 1287:{f.Push(f.Locals[1]);f.Pc=1288;continue;}
case 1288:{f.Push(JValue.R(rt.String("ClearNotedCardsFor")));f.Pc=1291;continue;}
case 1291:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1294);}
case 1294:{f.Pc=f.Pop().Int==0?1381:1297;continue;}
case 1297:{f.Push(f.Locals[8]);f.Pc=1299;continue;}
case 1299:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1304);}
case 1304:{f.Locals[12]=f.Pop();f.Pc=1306;continue;}
case 1306:{f.Push(f.Locals[12]);f.Pc=1308;continue;}
case 1308:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1313);}
case 1313:{f.Pc=f.Pop().Int==0?1381:1316;continue;}
case 1316:{f.Push(f.Locals[12]);f.Pc=1318;continue;}
case 1318:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1323);}
case 1323:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1326;continue;}
case 1326:{f.Locals[13]=f.Pop();f.Pc=1328;continue;}
case 1328:{f.Push(f.Locals[1]);f.Pc=1329;continue;}
case 1329:{f.Push(JValue.R(rt.String("ClearNotedCardsFor")));f.Pc=1332;continue;}
case 1332:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1335);}
case 1335:{f.Push(JValue.R(rt.String(",")));f.Pc=1338;continue;}
case 1338:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1341);}
case 1341:{f.Locals[14]=f.Pop();f.Pc=1343;continue;}
case 1343:{f.Push(f.Locals[14]);f.Pc=1345;continue;}
case 1345:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1346;continue;}
case 1346:{f.Locals[15]=f.Pop();f.Pc=1348;continue;}
case 1348:{f.Push(JValue.I(0));f.Pc=1349;continue;}
case 1349:{f.Locals[16]=f.Pop();f.Pc=1351;continue;}
case 1351:{f.Push(f.Locals[16]);f.Pc=1353;continue;}
case 1353:{f.Push(f.Locals[15]);f.Pc=1355;continue;}
case 1355:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1378:1358;continue;}
case 1358:{f.Push(f.Locals[14]);f.Pc=1360;continue;}
case 1360:{f.Push(f.Locals[16]);f.Pc=1362;continue;}
case 1362:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1363;continue;}
case 1363:{f.Locals[17]=f.Pop();f.Pc=1365;continue;}
case 1365:{f.Push(f.Locals[13]);f.Pc=1367;continue;}
case 1367:{f.Push(f.Locals[17]);f.Pc=1369;continue;}
case 1369:{return rt.Call(f,"forge/game/player/Player","clearNotesForName","(Ljava/lang/String;)V","invokevirtual",1372);}
case 1372:{f.Locals[16]=JValue.I(unchecked(f.Locals[16].Int+(1)));f.Pc=1375;continue;}
case 1375:{f.Pc=1351;continue;}
case 1378:{f.Pc=1306;continue;}
case 1381:{f.Push(f.Locals[1]);f.Pc=1382;continue;}
case 1382:{f.Push(JValue.R(rt.String("NoteNumber")));f.Pc=1385;continue;}
case 1385:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1388);}
case 1388:{f.Pc=f.Pop().Int==0?1452:1391;continue;}
case 1391:{f.Push(f.Locals[4]);f.Pc=1393;continue;}
case 1393:{f.Push(f.Locals[1]);f.Pc=1394;continue;}
case 1394:{f.Push(JValue.R(rt.String("NoteNumber")));f.Pc=1397;continue;}
case 1397:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1400);}
case 1400:{f.Push(f.Locals[1]);f.Pc=1401;continue;}
case 1401:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1404);}
case 1404:{f.Locals[12]=f.Pop();f.Pc=1406;continue;}
case 1406:{f.Push(f.Locals[8]);f.Pc=1408;continue;}
case 1408:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1413);}
case 1413:{f.Locals[13]=f.Pop();f.Pc=1415;continue;}
case 1415:{f.Push(f.Locals[13]);f.Pc=1417;continue;}
case 1417:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1422);}
case 1422:{f.Pc=f.Pop().Int==0?1452:1425;continue;}
case 1425:{f.Push(f.Locals[13]);f.Pc=1427;continue;}
case 1427:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1432);}
case 1432:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1435;continue;}
case 1435:{f.Locals[14]=f.Pop();f.Pc=1437;continue;}
case 1437:{f.Push(f.Locals[14]);f.Pc=1439;continue;}
case 1439:{f.Push(f.Locals[4]);f.Pc=1441;continue;}
case 1441:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",1444);}
case 1444:{f.Push(f.Locals[12]);f.Pc=1446;continue;}
case 1446:{return rt.Call(f,"forge/game/player/Player","noteNumberForName","(Ljava/lang/String;I)V","invokevirtual",1449);}
case 1449:{f.Pc=1415;continue;}
case 1452:{f.Push(f.Locals[1]);f.Pc=1453;continue;}
case 1453:{f.Push(JValue.R(rt.String("ForgetObjects")));f.Pc=1456;continue;}
case 1456:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1459);}
case 1459:{f.Pc=f.Pop().Int==0?1480:1462;continue;}
case 1462:{f.Push(f.Locals[4]);f.Pc=1464;continue;}
case 1464:{f.Push(f.Locals[4]);f.Pc=1466;continue;}
case 1466:{f.Push(f.Locals[1]);f.Pc=1467;continue;}
case 1467:{f.Push(JValue.R(rt.String("ForgetObjects")));f.Pc=1470;continue;}
case 1470:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1473);}
case 1473:{f.Push(f.Locals[1]);f.Pc=1474;continue;}
case 1474:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedObjects","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",1477);}
case 1477:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1480);}
case 1480:{f.Push(f.Locals[1]);f.Pc=1481;continue;}
case 1481:{f.Push(JValue.R(rt.String("ImprintCards")));f.Pc=1484;continue;}
case 1484:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1487);}
case 1487:{f.Pc=f.Pop().Int==0?1508:1490;continue;}
case 1490:{f.Push(f.Locals[4]);f.Pc=1492;continue;}
case 1492:{f.Push(f.Locals[4]);f.Pc=1494;continue;}
case 1494:{f.Push(f.Locals[1]);f.Pc=1495;continue;}
case 1495:{f.Push(JValue.R(rt.String("ImprintCards")));f.Pc=1498;continue;}
case 1498:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1501);}
case 1501:{f.Push(f.Locals[1]);f.Pc=1502;continue;}
case 1502:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1505);}
case 1505:{return rt.Call(f,"forge/game/card/Card","addImprintedCards","(Ljava/lang/Iterable;)V","invokevirtual",1508);}
case 1508:{f.Push(f.Locals[1]);f.Pc=1509;continue;}
case 1509:{f.Push(JValue.R(rt.String("ForgetImprinted")));f.Pc=1512;continue;}
case 1512:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1515);}
case 1515:{f.Pc=f.Pop().Int==0?1536:1518;continue;}
case 1518:{f.Push(f.Locals[4]);f.Pc=1520;continue;}
case 1520:{f.Push(f.Locals[4]);f.Pc=1522;continue;}
case 1522:{f.Push(f.Locals[1]);f.Pc=1523;continue;}
case 1523:{f.Push(JValue.R(rt.String("ForgetImprinted")));f.Pc=1526;continue;}
case 1526:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1529);}
case 1529:{f.Push(f.Locals[1]);f.Pc=1530;continue;}
case 1530:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1533);}
case 1533:{return rt.Call(f,"forge/game/card/Card","removeImprintedCards","(Ljava/lang/Iterable;)V","invokevirtual",1536);}
case 1536:{f.Push(f.Locals[1]);f.Pc=1537;continue;}
case 1537:{f.Push(JValue.R(rt.String("PumpZone")));f.Pc=1540;continue;}
case 1540:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1543);}
case 1543:{f.Pc=f.Pop().Int==0?1559:1546;continue;}
case 1546:{f.Push(f.Locals[1]);f.Pc=1547;continue;}
case 1547:{f.Push(JValue.R(rt.String("PumpZone")));f.Pc=1550;continue;}
case 1550:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1553);}
case 1553:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",1556);}
case 1556:{f.Pc=1565;continue;}
case 1559:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=1562;continue;}
case 1562:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",1565);}
case 1565:{f.Locals[12]=f.Pop();f.Pc=1567;continue;}
case 1567:{f.Push(f.Locals[7]);f.Pc=1569;continue;}
case 1569:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1574);}
case 1574:{f.Locals[13]=f.Pop();f.Pc=1576;continue;}
case 1576:{f.Push(f.Locals[13]);f.Pc=1578;continue;}
case 1578:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1583);}
case 1583:{f.Pc=f.Pop().Int==0?1824:1586;continue;}
case 1586:{f.Push(f.Locals[13]);f.Pc=1588;continue;}
case 1588:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1593);}
case 1593:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1596;continue;}
case 1596:{f.Locals[14]=f.Pop();f.Pc=1598;continue;}
case 1598:{f.Push(f.Locals[14]);f.Pc=1600;continue;}
case 1600:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",1603);}
case 1603:{f.Pc=f.Pop().Int==0?1609:1606;continue;}
case 1606:{f.Pc=1576;continue;}
case 1609:{f.Push(f.Locals[14]);f.Pc=1611;continue;}
case 1611:{f.Push(f.Locals[12]);f.Pc=1613;continue;}
case 1613:{return rt.Call(f,"forge/game/card/Card","isInZones","(Ljava/util/List;)Z","invokevirtual",1616);}
case 1616:{f.Pc=f.Pop().Int!=0?1622:1619;continue;}
case 1619:{f.Pc=1576;continue;}
case 1622:{f.Push(f.Locals[9]);f.Pc=1624;continue;}
case 1624:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",1627);}
case 1627:{f.Locals[15]=f.Pop();f.Pc=1629;continue;}
case 1629:{f.Push(f.Locals[15]);f.Pc=1631;continue;}
case 1631:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1636);}
case 1636:{f.Pc=f.Pop().Int!=0?1671:1639;continue;}
case 1639:{f.Push(f.Locals[15]);f.Pc=1641;continue;}
case 1641:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",1646);}
case 1646:{f.Push(f.Locals[14]);f.Pc=1648;continue;}
case 1648:{return rt.DynamicCall(f,"forge/game/ability/effects/PumpEffect:3593:1648:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Function;",1653);}
case 1653:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",1658);}
case 1658:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",1661);}
case 1661:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",1666);}
case 1666:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1669;continue;}
case 1669:{f.Locals[15]=f.Pop();f.Pc=1671;continue;}
case 1671:{f.Push(f.Locals[1]);f.Pc=1672;continue;}
case 1672:{f.Push(JValue.R(rt.String("NumAtt")));f.Pc=1675;continue;}
case 1675:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1678);}
case 1678:{f.Pc=f.Pop().Int==0?1704:1681;continue;}
case 1681:{f.Push(f.Locals[1]);f.Pc=1682;continue;}
case 1682:{f.Push(JValue.R(rt.String("NumAtt")));f.Pc=1685;continue;}
case 1685:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1688);}
case 1688:{f.Push(JValue.R(rt.String("Double")));f.Pc=1691;continue;}
case 1691:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1694);}
case 1694:{f.Pc=f.Pop().Int==0?1704:1697;continue;}
case 1697:{f.Push(f.Locals[14]);f.Pc=1699;continue;}
case 1699:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",1702);}
case 1702:{f.Locals[10]=f.Pop();f.Pc=1704;continue;}
case 1704:{f.Push(f.Locals[1]);f.Pc=1705;continue;}
case 1705:{f.Push(JValue.R(rt.String("NumDef")));f.Pc=1708;continue;}
case 1708:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1711);}
case 1711:{f.Pc=f.Pop().Int==0?1737:1714;continue;}
case 1714:{f.Push(f.Locals[1]);f.Pc=1715;continue;}
case 1715:{f.Push(JValue.R(rt.String("NumDef")));f.Pc=1718;continue;}
case 1718:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1721);}
case 1721:{f.Push(JValue.R(rt.String("Double")));f.Pc=1724;continue;}
case 1724:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1727);}
case 1727:{f.Pc=f.Pop().Int==0?1737:1730;continue;}
case 1730:{f.Push(f.Locals[14]);f.Pc=1732;continue;}
case 1732:{return rt.Call(f,"forge/game/card/Card","getNetToughness","()I","invokevirtual",1735);}
case 1735:{f.Locals[11]=f.Pop();f.Pc=1737;continue;}
case 1737:{f.Push(f.Locals[1]);f.Pc=1738;continue;}
case 1738:{f.Push(JValue.R(rt.String("NumAtt")));f.Pc=1741;continue;}
case 1741:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1744);}
case 1744:{f.Pc=f.Pop().Int==0?1772:1747;continue;}
case 1747:{f.Push(f.Locals[1]);f.Pc=1748;continue;}
case 1748:{f.Push(JValue.R(rt.String("NumAtt")));f.Pc=1751;continue;}
case 1751:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1754);}
case 1754:{f.Push(JValue.R(rt.String("Triple")));f.Pc=1757;continue;}
case 1757:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1760);}
case 1760:{f.Pc=f.Pop().Int==0?1772:1763;continue;}
case 1763:{f.Push(f.Locals[14]);f.Pc=1765;continue;}
case 1765:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",1768);}
case 1768:{f.Push(JValue.I(2));f.Pc=1769;continue;}
case 1769:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=1770;continue;}
case 1770:{f.Locals[10]=f.Pop();f.Pc=1772;continue;}
case 1772:{f.Push(f.Locals[1]);f.Pc=1773;continue;}
case 1773:{f.Push(JValue.R(rt.String("NumDef")));f.Pc=1776;continue;}
case 1776:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1779);}
case 1779:{f.Pc=f.Pop().Int==0?1807:1782;continue;}
case 1782:{f.Push(f.Locals[1]);f.Pc=1783;continue;}
case 1783:{f.Push(JValue.R(rt.String("NumDef")));f.Pc=1786;continue;}
case 1786:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1789);}
case 1789:{f.Push(JValue.R(rt.String("Triple")));f.Pc=1792;continue;}
case 1792:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1795);}
case 1795:{f.Pc=f.Pop().Int==0?1807:1798;continue;}
case 1798:{f.Push(f.Locals[14]);f.Pc=1800;continue;}
case 1800:{return rt.Call(f,"forge/game/card/Card","getNetToughness","()I","invokevirtual",1803);}
case 1803:{f.Push(JValue.I(2));f.Pc=1804;continue;}
case 1804:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=1805;continue;}
case 1805:{f.Locals[11]=f.Pop();f.Pc=1807;continue;}
case 1807:{f.Push(f.Locals[1]);f.Pc=1808;continue;}
case 1808:{f.Push(f.Locals[14]);f.Pc=1810;continue;}
case 1810:{f.Push(f.Locals[10]);f.Pc=1812;continue;}
case 1812:{f.Push(f.Locals[11]);f.Pc=1814;continue;}
case 1814:{f.Push(f.Locals[15]);f.Pc=1816;continue;}
case 1816:{f.Push(f.Locals[5]);f.Pc=1818;continue;}
case 1818:{return rt.Call(f,"forge/game/ability/effects/PumpEffect","applyPump","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;IILjava/util/List;J)V","invokestatic",1821);}
case 1821:{f.Pc=1576;continue;}
case 1824:{f.Push(f.Locals[1]);f.Pc=1825;continue;}
case 1825:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=1828;continue;}
case 1828:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1831);}
case 1831:{f.Pc=f.Pop().Int==0?1857:1834;continue;}
case 1834:{f.Push(f.Locals[7]);f.Pc=1836;continue;}
case 1836:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1841);}
case 1841:{f.Pc=f.Pop().Int!=0?1857:1844;continue;}
case 1844:{f.Push(f.Locals[1]);f.Pc=1845;continue;}
case 1845:{f.Push(f.Locals[1]);f.Pc=1846;continue;}
case 1846:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=1849;continue;}
case 1849:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1852);}
case 1852:{f.Push(f.Locals[7]);f.Pc=1854;continue;}
case 1854:{return rt.Call(f,"forge/game/ability/effects/PumpEffect","registerDelayedTrigger","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/Iterable;)V","invokestatic",1857);}
case 1857:{f.Push(f.Locals[1]);f.Pc=1858;continue;}
case 1858:{return rt.Call(f,"forge/game/card/CardUtil","getRadiance","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",1861);}
case 1861:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1864);}
case 1864:{f.Locals[13]=f.Pop();f.Pc=1866;continue;}
case 1866:{f.Push(f.Locals[13]);f.Pc=1868;continue;}
case 1868:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1873);}
case 1873:{f.Pc=f.Pop().Int==0?1918:1876;continue;}
case 1876:{f.Push(f.Locals[13]);f.Pc=1878;continue;}
case 1878:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1883);}
case 1883:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1886;continue;}
case 1886:{f.Locals[14]=f.Pop();f.Pc=1888;continue;}
case 1888:{f.Push(f.Locals[14]);f.Pc=1890;continue;}
case 1890:{f.Push(f.Locals[12]);f.Pc=1892;continue;}
case 1892:{return rt.Call(f,"forge/game/card/Card","isInZones","(Ljava/util/List;)Z","invokevirtual",1895);}
case 1895:{f.Pc=f.Pop().Int!=0?1901:1898;continue;}
case 1898:{f.Pc=1866;continue;}
case 1901:{f.Push(f.Locals[1]);f.Pc=1902;continue;}
case 1902:{f.Push(f.Locals[14]);f.Pc=1904;continue;}
case 1904:{f.Push(f.Locals[10]);f.Pc=1906;continue;}
case 1906:{f.Push(f.Locals[11]);f.Pc=1908;continue;}
case 1908:{f.Push(f.Locals[9]);f.Pc=1910;continue;}
case 1910:{f.Push(f.Locals[5]);f.Pc=1912;continue;}
case 1912:{return rt.Call(f,"forge/game/ability/effects/PumpEffect","applyPump","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;IILjava/util/List;J)V","invokestatic",1915);}
case 1915:{f.Pc=1866;continue;}
case 1918:{f.Push(f.Locals[8]);f.Pc=1920;continue;}
case 1920:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1925);}
case 1925:{f.Locals[13]=f.Pop();f.Pc=1927;continue;}
case 1927:{f.Push(f.Locals[13]);f.Pc=1929;continue;}
case 1929:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1934);}
case 1934:{f.Pc=f.Pop().Int==0?1973:1937;continue;}
case 1937:{f.Push(f.Locals[13]);f.Pc=1939;continue;}
case 1939:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1944);}
case 1944:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1947;continue;}
case 1947:{f.Locals[14]=f.Pop();f.Pc=1949;continue;}
case 1949:{f.Push(f.Locals[14]);f.Pc=1951;continue;}
case 1951:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",1954);}
case 1954:{f.Pc=f.Pop().Int!=0?1960:1957;continue;}
case 1957:{f.Pc=1927;continue;}
case 1960:{f.Push(f.Locals[1]);f.Pc=1961;continue;}
case 1961:{f.Push(f.Locals[14]);f.Pc=1963;continue;}
case 1963:{f.Push(f.Locals[9]);f.Pc=1965;continue;}
case 1965:{f.Push(f.Locals[5]);f.Pc=1967;continue;}
case 1967:{return rt.Call(f,"forge/game/ability/effects/PumpEffect","applyPump","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/util/List;J)V","invokestatic",1970);}
case 1970:{f.Pc=1927;continue;}
case 1973:{f.Push(f.Locals[1]);f.Pc=1974;continue;}
case 1974:{return rt.Call(f,"forge/game/ability/effects/PumpEffect","replaceDying","(Lforge/game/spellability/SpellAbility;)V","invokestatic",1977);}
case 1977:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3594(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("CardManaCost")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?28:10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("CardManaCost")));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/card/mana/ManaCost","getShortString","()Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Locals[1]=f.Pop();f.Pc=25;continue;}
case 25:{f.Pc=55;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("ConvertedManaCost")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?55:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",42);}
case 42:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",45);}
case 45:{f.Locals[2]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("ConvertedManaCost")));f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",54);}
case 54:{f.Locals[1]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3595(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ChosenPlayerUID")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?22:10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("ChosenPlayerName")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int!=0?22:20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",26);}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",33);}
case 33:{f.Pc=f.Pop().Int==0?99:36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[4]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/player/Player","getId","()I","invokevirtual",52);}
case 52:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",55);}
case 55:{f.Locals[5]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",62);}
case 62:{f.Locals[6]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("ChosenPlayerUID")));f.Pc=68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",73);}
case 73:{f.Locals[7]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[7]);f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String("ChosenPlayerName")));f.Pc=80;continue;}
case 80:{f.Push(f.Locals[6]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",85);}
case 85:{f.Locals[7]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[7]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",95);}
case 95:{f.StackOp("pop");f.Pc=96;continue;}
case 96:{f.Pc=27;continue;}
case 99:{f.Push(JValue.I(1));f.Pc=100;continue;}
case 100:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

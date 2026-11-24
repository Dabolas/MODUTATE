// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C306{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/FlipCoinEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3403,"forge/game/ability/effects/FlipCoinEffect","<init>","()V",1,1,1,new JHandler[]{},M3403));
c.Add(new JMethod(3404,"forge/game/ability/effects/FlipCoinEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,6,2,new JHandler[]{},M3404));
c.Add(new JMethod(3405,"forge/game/ability/effects/FlipCoinEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,18,4,new JHandler[]{},M3405));
c.Add(new JMethod(3406,"forge/game/ability/effects/FlipCoinEffect","flipCoins","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;I)I",9,3,4,new JHandler[]{},M3406));
c.Add(new JMethod(3407,"forge/game/ability/effects/FlipCoinEffect","flipCoins","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;ILjava/lang/String;)I",9,10,6,new JHandler[]{},M3407));
c.Add(new JMethod(3408,"forge/game/ability/effects/FlipCoinEffect","flipCoin","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;ILjava/lang/Boolean;Ljava/lang/String;)Z",10,12,6,new JHandler[]{},M3408));
}

internal static JStep M3403(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3404(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/ability/effects/FlipCoinEffect","getTargets","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",23);}
case 23:{f.Locals[5]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[5]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",31);}
case 31:{f.Push(JValue.R(rt.String(" flips a coin.")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",36);}
case 36:{f.StackOp("pop");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{f.Pc=f.Pop().Reference==null?70:42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",49);}
case 49:{f.Pc=f.Pop().Int!=0?70:52;continue;}
case 52:{f.Push(f.Locals[5]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String(" Targeting: ")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",59);}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",64);}
case 64:{f.Push(JValue.R(rt.String(".")));f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",69);}
case 69:{f.StackOp("pop");f.Pc=70;continue;}
case 70:{f.Push(f.Locals[5]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",75);}
case 75:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3405(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("Flipper")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("NoCall")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",23);}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("ForEachPlayer")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",31);}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("SaveNumFlipsToSVar")));f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("X")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",41);}
case 41:{f.Locals[6]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(JValue.I(1));f.Pc=44;continue;}
case 44:{f.Locals[7]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("Amount")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int==0?68:55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String("Amount")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",62);}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",66);}
case 66:{f.Locals[7]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[3]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",74);}
case 74:{f.Locals[8]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[8]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",83);}
case 83:{f.Pc=f.Pop().Int==0?732:86;continue;}
case 86:{f.Push(f.Locals[8]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",93);}
case 93:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=96;continue;}
case 96:{f.Locals[9]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[4]);f.Pc=100;continue;}
case 100:{f.Pc=f.Pop().Int==0?252:103;continue;}
case 103:{f.Push(f.Locals[9]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[7]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/ability/effects/FlipCoinEffect","flipCoins","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;I)I","invokestatic",111);}
case 111:{f.Locals[10]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(f.Locals[10]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[7]);f.Pc=117;continue;}
case 117:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/lang/Math","abs","(I)I","invokestatic",121);}
case 121:{f.Locals[11]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[10]);f.Pc=125;continue;}
case 125:{f.Pc=f.Pop().Int<=0?186:128;continue;}
case 128:{f.Push(f.Locals[1]);f.Pc=129;continue;}
case 129:{f.Push(JValue.R(rt.String("RememberResult")));f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",134);}
case 134:{f.Pc=f.Pop().Int==0?145:137;continue;}
case 137:{f.Push(f.Locals[2]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[9]);f.Pc=140;continue;}
case 140:{f.Push(JValue.R(rt.String("Heads")));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/card/Card","addFlipResult","(Lforge/game/player/Player;Ljava/lang/String;)V","invokevirtual",145);}
case 145:{f.Push(f.Locals[1]);f.Pc=146;continue;}
case 146:{f.Push(JValue.R(rt.String("HeadsSubAbility")));f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",151);}
case 151:{f.Locals[12]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(f.Locals[12]);f.Pc=155;continue;}
case 155:{f.Pc=f.Pop().Reference==null?186:158;continue;}
case 158:{f.Push(f.Locals[1]);f.Pc=159;continue;}
case 159:{f.Push(JValue.R(rt.String("Amount")));f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",164);}
case 164:{f.Pc=f.Pop().Int==0?181:167;continue;}
case 167:{f.Push(f.Locals[12]);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[6]);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[10]);f.Pc=173;continue;}
case 173:{return rt.DynamicCall(f,"forge/game/ability/effects/FlipCoinEffect:3405:173:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",178);}
case 178:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",181);}
case 181:{f.Push(f.Locals[12]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",186);}
case 186:{f.Push(f.Locals[11]);f.Pc=188;continue;}
case 188:{f.Pc=f.Pop().Int<=0?249:191;continue;}
case 191:{f.Push(f.Locals[1]);f.Pc=192;continue;}
case 192:{f.Push(JValue.R(rt.String("RememberResult")));f.Pc=194;continue;}
case 194:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",197);}
case 197:{f.Pc=f.Pop().Int==0?208:200;continue;}
case 200:{f.Push(f.Locals[2]);f.Pc=201;continue;}
case 201:{f.Push(f.Locals[9]);f.Pc=203;continue;}
case 203:{f.Push(JValue.R(rt.String("Tails")));f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/card/Card","addFlipResult","(Lforge/game/player/Player;Ljava/lang/String;)V","invokevirtual",208);}
case 208:{f.Push(f.Locals[1]);f.Pc=209;continue;}
case 209:{f.Push(JValue.R(rt.String("TailsSubAbility")));f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",214);}
case 214:{f.Locals[12]=f.Pop();f.Pc=216;continue;}
case 216:{f.Push(f.Locals[12]);f.Pc=218;continue;}
case 218:{f.Pc=f.Pop().Reference==null?249:221;continue;}
case 221:{f.Push(f.Locals[1]);f.Pc=222;continue;}
case 222:{f.Push(JValue.R(rt.String("Amount")));f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",227);}
case 227:{f.Pc=f.Pop().Int==0?244:230;continue;}
case 230:{f.Push(f.Locals[12]);f.Pc=232;continue;}
case 232:{f.Push(f.Locals[6]);f.Pc=234;continue;}
case 234:{f.Push(f.Locals[11]);f.Pc=236;continue;}
case 236:{return rt.DynamicCall(f,"forge/game/ability/effects/FlipCoinEffect:3405:236:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",241);}
case 241:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",244);}
case 244:{f.Push(f.Locals[12]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",249);}
case 249:{f.Pc=700;continue;}
case 252:{f.Push(f.Locals[5]);f.Pc=254;continue;}
case 254:{f.Pc=f.Pop().Int==0?518:257;continue;}
case 257:{f.Push(JValue.I(0));f.Pc=258;continue;}
case 258:{f.Locals[10]=f.Pop();f.Pc=260;continue;}
case 260:{f.Push(JValue.I(0));f.Pc=261;continue;}
case 261:{f.Locals[11]=f.Pop();f.Pc=263;continue;}
case 263:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=266;continue;}
case 266:{f.StackOp("dup");f.Pc=267;continue;}
case 267:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","()V","invokespecial",270);}
case 270:{f.Locals[12]=f.Pop();f.Pc=272;continue;}
case 272:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=275;continue;}
case 275:{f.StackOp("dup");f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","()V","invokespecial",279);}
case 279:{f.Locals[13]=f.Pop();f.Pc=281;continue;}
case 281:{f.Push(f.Locals[2]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[1]);f.Pc=283;continue;}
case 283:{f.Push(JValue.R(rt.String("ForEachPlayer")));f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",288);}
case 288:{f.Push(f.Locals[1]);f.Pc=289;continue;}
case 289:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",292);}
case 292:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",295);}
case 295:{f.Locals[14]=f.Pop();f.Pc=297;continue;}
case 297:{f.Push(f.Locals[14]);f.Pc=299;continue;}
case 299:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",304);}
case 304:{f.Pc=f.Pop().Int==0?375:307;continue;}
case 307:{f.Push(f.Locals[14]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",314);}
case 314:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=317;continue;}
case 317:{f.Locals[15]=f.Pop();f.Pc=319;continue;}
case 319:{f.Push(f.Locals[15]);f.Pc=321;continue;}
case 321:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",324);}
case 324:{return rt.DynamicCall(f,"forge/game/ability/effects/FlipCoinEffect:3405:324:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",329);}
case 329:{f.Locals[16]=f.Pop();f.Pc=331;continue;}
case 331:{f.Push(f.Locals[9]);f.Pc=333;continue;}
case 333:{f.Push(f.Locals[1]);f.Pc=334;continue;}
case 334:{f.Push(JValue.I(1));f.Pc=335;continue;}
case 335:{f.Push(f.Locals[16]);f.Pc=337;continue;}
case 337:{return rt.Call(f,"forge/game/ability/effects/FlipCoinEffect","flipCoins","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;ILjava/lang/String;)I","invokestatic",340);}
case 340:{f.Locals[17]=f.Pop();f.Pc=342;continue;}
case 342:{f.Push(f.Locals[17]);f.Pc=344;continue;}
case 344:{f.Pc=f.Pop().Int<=0?361:347;continue;}
case 347:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=350;continue;}
case 350:{f.Push(f.Locals[12]);f.Pc=352;continue;}
case 352:{f.Push(f.Locals[15]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/game/player/PlayerCollection","add","(Ljava/lang/Object;)Z","invokevirtual",357);}
case 357:{f.StackOp("pop");f.Pc=358;continue;}
case 358:{f.Pc=372;continue;}
case 361:{f.Locals[11]=JValue.I(unchecked(f.Locals[11].Int+(1)));f.Pc=364;continue;}
case 364:{f.Push(f.Locals[13]);f.Pc=366;continue;}
case 366:{f.Push(f.Locals[15]);f.Pc=368;continue;}
case 368:{return rt.Call(f,"forge/game/player/PlayerCollection","add","(Ljava/lang/Object;)Z","invokevirtual",371);}
case 371:{f.StackOp("pop");f.Pc=372;continue;}
case 372:{f.Pc=297;continue;}
case 375:{f.Push(f.Locals[10]);f.Pc=377;continue;}
case 377:{f.Pc=f.Pop().Int<=0?445:380;continue;}
case 380:{f.Push(f.Locals[1]);f.Pc=381;continue;}
case 381:{f.Push(JValue.R(rt.String("WinSubAbility")));f.Pc=383;continue;}
case 383:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",386);}
case 386:{f.Locals[14]=f.Pop();f.Pc=388;continue;}
case 388:{f.Push(f.Locals[14]);f.Pc=390;continue;}
case 390:{f.Pc=f.Pop().Reference==null?445:393;continue;}
case 393:{f.Push(f.Locals[2]);f.Pc=394;continue;}
case 394:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",397);}
case 397:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",400);}
case 400:{f.Locals[15]=f.Pop();f.Pc=402;continue;}
case 402:{f.Push(f.Locals[2]);f.Pc=403;continue;}
case 403:{f.Push(f.Locals[15]);f.Pc=405;continue;}
case 405:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Iterable;)V","invokevirtual",408);}
case 408:{f.Push(f.Locals[2]);f.Pc=409;continue;}
case 409:{f.Push(f.Locals[12]);f.Pc=411;continue;}
case 411:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",414);}
case 414:{f.Push(f.Locals[14]);f.Pc=416;continue;}
case 416:{f.Push(JValue.R(rt.String("Wins")));f.Pc=418;continue;}
case 418:{f.Push(f.Locals[10]);f.Pc=420;continue;}
case 420:{return rt.DynamicCall(f,"forge/game/ability/effects/FlipCoinEffect:3405:420:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",425);}
case 425:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",428);}
case 428:{f.Push(f.Locals[14]);f.Pc=430;continue;}
case 430:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",433);}
case 433:{f.Push(f.Locals[2]);f.Pc=434;continue;}
case 434:{f.Push(f.Locals[12]);f.Pc=436;continue;}
case 436:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Iterable;)V","invokevirtual",439);}
case 439:{f.Push(f.Locals[2]);f.Pc=440;continue;}
case 440:{f.Push(f.Locals[15]);f.Pc=442;continue;}
case 442:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",445);}
case 445:{f.Push(f.Locals[11]);f.Pc=447;continue;}
case 447:{f.Pc=f.Pop().Int<=0?515:450;continue;}
case 450:{f.Push(f.Locals[1]);f.Pc=451;continue;}
case 451:{f.Push(JValue.R(rt.String("LoseSubAbility")));f.Pc=453;continue;}
case 453:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",456);}
case 456:{f.Locals[14]=f.Pop();f.Pc=458;continue;}
case 458:{f.Push(f.Locals[14]);f.Pc=460;continue;}
case 460:{f.Pc=f.Pop().Reference==null?515:463;continue;}
case 463:{f.Push(f.Locals[2]);f.Pc=464;continue;}
case 464:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",467);}
case 467:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",470);}
case 470:{f.Locals[15]=f.Pop();f.Pc=472;continue;}
case 472:{f.Push(f.Locals[2]);f.Pc=473;continue;}
case 473:{f.Push(f.Locals[15]);f.Pc=475;continue;}
case 475:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Iterable;)V","invokevirtual",478);}
case 478:{f.Push(f.Locals[2]);f.Pc=479;continue;}
case 479:{f.Push(f.Locals[13]);f.Pc=481;continue;}
case 481:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",484);}
case 484:{f.Push(f.Locals[14]);f.Pc=486;continue;}
case 486:{f.Push(JValue.R(rt.String("Losses")));f.Pc=488;continue;}
case 488:{f.Push(f.Locals[11]);f.Pc=490;continue;}
case 490:{return rt.DynamicCall(f,"forge/game/ability/effects/FlipCoinEffect:3405:490:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",495);}
case 495:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",498);}
case 498:{f.Push(f.Locals[14]);f.Pc=500;continue;}
case 500:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",503);}
case 503:{f.Push(f.Locals[2]);f.Pc=504;continue;}
case 504:{f.Push(f.Locals[13]);f.Pc=506;continue;}
case 506:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Iterable;)V","invokevirtual",509);}
case 509:{f.Push(f.Locals[2]);f.Pc=510;continue;}
case 510:{f.Push(f.Locals[15]);f.Pc=512;continue;}
case 512:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",515);}
case 515:{f.Pc=700;continue;}
case 518:{f.Push(f.Locals[9]);f.Pc=520;continue;}
case 520:{f.Push(f.Locals[1]);f.Pc=521;continue;}
case 521:{f.Push(f.Locals[7]);f.Pc=523;continue;}
case 523:{return rt.Call(f,"forge/game/ability/effects/FlipCoinEffect","flipCoins","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;I)I","invokestatic",526);}
case 526:{f.Locals[10]=f.Pop();f.Pc=528;continue;}
case 528:{f.Push(f.Locals[10]);f.Pc=530;continue;}
case 530:{f.Push(f.Locals[7]);f.Pc=532;continue;}
case 532:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=533;continue;}
case 533:{return rt.Call(f,"java/lang/Math","abs","(I)I","invokestatic",536);}
case 536:{f.Locals[11]=f.Pop();f.Pc=538;continue;}
case 538:{f.Push(f.Locals[10]);f.Pc=540;continue;}
case 540:{f.Pc=f.Pop().Int<=0?590:543;continue;}
case 543:{f.Push(f.Locals[1]);f.Pc=544;continue;}
case 544:{f.Push(JValue.R(rt.String("RememberWinner")));f.Pc=546;continue;}
case 546:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",549);}
case 549:{f.Pc=f.Pop().Int==0?558:552;continue;}
case 552:{f.Push(f.Locals[2]);f.Pc=553;continue;}
case 553:{f.Push(f.Locals[9]);f.Pc=555;continue;}
case 555:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",558);}
case 558:{f.Push(f.Locals[1]);f.Pc=559;continue;}
case 559:{f.Push(JValue.R(rt.String("WinSubAbility")));f.Pc=561;continue;}
case 561:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",564);}
case 564:{f.Locals[12]=f.Pop();f.Pc=566;continue;}
case 566:{f.Push(f.Locals[12]);f.Pc=568;continue;}
case 568:{f.Pc=f.Pop().Reference==null?590:571;continue;}
case 571:{f.Push(f.Locals[12]);f.Pc=573;continue;}
case 573:{f.Push(JValue.R(rt.String("Wins")));f.Pc=575;continue;}
case 575:{f.Push(f.Locals[10]);f.Pc=577;continue;}
case 577:{return rt.DynamicCall(f,"forge/game/ability/effects/FlipCoinEffect:3405:577:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",582);}
case 582:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",585);}
case 585:{f.Push(f.Locals[12]);f.Pc=587;continue;}
case 587:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",590);}
case 590:{f.Push(f.Locals[11]);f.Pc=592;continue;}
case 592:{f.Pc=f.Pop().Int<=0?642:595;continue;}
case 595:{f.Push(f.Locals[1]);f.Pc=596;continue;}
case 596:{f.Push(JValue.R(rt.String("RememberLoser")));f.Pc=598;continue;}
case 598:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",601);}
case 601:{f.Pc=f.Pop().Int==0?610:604;continue;}
case 604:{f.Push(f.Locals[2]);f.Pc=605;continue;}
case 605:{f.Push(f.Locals[9]);f.Pc=607;continue;}
case 607:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",610);}
case 610:{f.Push(f.Locals[1]);f.Pc=611;continue;}
case 611:{f.Push(JValue.R(rt.String("LoseSubAbility")));f.Pc=613;continue;}
case 613:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",616);}
case 616:{f.Locals[12]=f.Pop();f.Pc=618;continue;}
case 618:{f.Push(f.Locals[12]);f.Pc=620;continue;}
case 620:{f.Pc=f.Pop().Reference==null?642:623;continue;}
case 623:{f.Push(f.Locals[12]);f.Pc=625;continue;}
case 625:{f.Push(JValue.R(rt.String("Losses")));f.Pc=627;continue;}
case 627:{f.Push(f.Locals[11]);f.Pc=629;continue;}
case 629:{return rt.DynamicCall(f,"forge/game/ability/effects/FlipCoinEffect:3405:629:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",634);}
case 634:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",637);}
case 637:{f.Push(f.Locals[12]);f.Pc=639;continue;}
case 639:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",642);}
case 642:{f.Push(f.Locals[1]);f.Pc=643;continue;}
case 643:{f.Push(JValue.R(rt.String("RememberNumber")));f.Pc=645;continue;}
case 645:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",648);}
case 648:{f.Pc=f.Pop().Int==0?700:651;continue;}
case 651:{f.Push(f.Locals[1]);f.Pc=652;continue;}
case 652:{f.Push(JValue.R(rt.String("RememberNumber")));f.Pc=654;continue;}
case 654:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",657);}
case 657:{f.Locals[12]=f.Pop();f.Pc=659;continue;}
case 659:{f.Push(f.Locals[12]);f.Pc=661;continue;}
case 661:{f.Push(JValue.R(rt.String("Win")));f.Pc=663;continue;}
case 663:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",666);}
case 666:{f.Pc=f.Pop().Int==0?681:669;continue;}
case 669:{f.Push(f.Locals[2]);f.Pc=670;continue;}
case 670:{f.Push(f.Locals[10]);f.Pc=672;continue;}
case 672:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",675);}
case 675:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",678);}
case 678:{f.Pc=700;continue;}
case 681:{f.Push(f.Locals[12]);f.Pc=683;continue;}
case 683:{f.Push(JValue.R(rt.String("Loss")));f.Pc=685;continue;}
case 685:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",688);}
case 688:{f.Pc=f.Pop().Int==0?700:691;continue;}
case 691:{f.Push(f.Locals[2]);f.Pc=692;continue;}
case 692:{f.Push(f.Locals[11]);f.Pc=694;continue;}
case 694:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",697);}
case 697:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",700);}
case 700:{f.Push(f.Locals[7]);f.Pc=702;continue;}
case 702:{f.Pc=f.Pop().Int<=0?729:705;continue;}
case 705:{f.Push(f.Locals[9]);f.Pc=707;continue;}
case 707:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",710);}
case 710:{f.Locals[10]=f.Pop();f.Pc=712;continue;}
case 712:{f.Push(f.Locals[9]);f.Pc=714;continue;}
case 714:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",717);}
case 717:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",720);}
case 720:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","FlippedCoinOnce","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","FlippedCoinOnce","Lforge/game/trigger/TriggerType;"));f.Pc=723;continue;}
case 723:{f.Push(f.Locals[10]);f.Pc=725;continue;}
case 725:{f.Push(JValue.I(0));f.Pc=726;continue;}
case 726:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",729);}
case 729:{f.Pc=76;continue;}
case 732:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3406(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("")));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/ability/effects/FlipCoinEffect","flipCoins","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;ILjava/lang/String;)I","invokestatic",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3407(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/staticability/StaticAbilityFlipCoinMod","getFlipMultiplier","(Lforge/game/player/Player;)I","invokestatic",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Locals[5]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{f.Locals[6]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/staticability/StaticAbilityFlipCoinMod","fixedResult","(Lforge/game/player/Player;)Ljava/lang/Boolean;","invokestatic",16);}
case 16:{f.Locals[7]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{f.Locals[8]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[8]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?82:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?45:32;continue;}
case 32:{f.Push(f.Locals[8]);f.Pc=34;continue;}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.DynamicCall(f,"forge/game/ability/effects/FlipCoinEffect:3407:37:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(II)Ljava/lang/String;",42);}
case 42:{f.Pc=47;continue;}
case 45:{f.Push(JValue.R(rt.String("")));f.Pc=47;continue;}
case 47:{f.Locals[9]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[7]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[9]);f.Pc=58;continue;}
case 58:{return rt.DynamicCall(f,"forge/game/ability/effects/FlipCoinEffect:3407:58:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",63);}
case 63:{return rt.Call(f,"forge/game/ability/effects/FlipCoinEffect","flipCoin","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;ILjava/lang/Boolean;Ljava/lang/String;)Z","invokestatic",66);}
case 66:{f.Locals[6]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[6]);f.Pc=70;continue;}
case 70:{f.Pc=f.Pop().Int==0?76:73;continue;}
case 73:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=76;continue;}
case 76:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=79;continue;}
case 79:{f.Pc=21;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{f.Push(JValue.R(rt.String("FlipUntilYouLose")));f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",88);}
case 88:{f.Pc=f.Pop().Int==0?96:91;continue;}
case 91:{f.Push(f.Locals[6]);f.Pc=93;continue;}
case 93:{f.Pc=f.Pop().Int!=0?12:96;continue;}
case 96:{f.Push(f.Locals[5]);f.Pc=98;continue;}
case 98:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3408(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",7);}
case 7:{f.Locals[5]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("NoCall")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",15);}
case 15:{f.Locals[6]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Locals[7]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{f.Pc=f.Pop().Reference==null?36:24;continue;}
case 24:{f.Push(f.Locals[5]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",32);}
case 32:{f.StackOp("pop");f.Pc=33;continue;}
case 33:{f.Pc=113;continue;}
case 36:{f.Push(f.Locals[6]);f.Pc=38;continue;}
case 38:{f.Pc=f.Pop().Int!=0?81:41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",45);}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",50);}
case 50:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",53);}
case 53:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",56);}
case 56:{f.Push(JValue.R(rt.String("lblCallCoinFlip")));f.Pc=59;continue;}
case 59:{f.Push(JValue.I(0));f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",66);}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{return rt.DynamicCall(f,"forge/game/ability/effects/FlipCoinEffect:3408:68:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",73);}
case 73:{if(!rt.StaticReady(f,"forge/game/player/PlayerController$BinaryChoiceType","HeadsOrTails","Lforge/game/player/PlayerController$BinaryChoiceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerController$BinaryChoiceType","HeadsOrTails","Lforge/game/player/PlayerController$BinaryChoiceType;"));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/player/PlayerController","chooseBinary","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/PlayerController$BinaryChoiceType;)Z","invokevirtual",79);}
case 79:{f.Locals[7]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(JValue.I(0));f.Pc=82;continue;}
case 82:{f.Locals[8]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[8]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?113:90;continue;}
case 90:{f.Push(f.Locals[5]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",95);}
case 95:{return rt.Call(f,"java/util/Random","nextBoolean","()Z","invokevirtual",98);}
case 98:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",101);}
case 101:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",106);}
case 106:{f.StackOp("pop");f.Pc=107;continue;}
case 107:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=110;continue;}
case 110:{f.Pc=84;continue;}
case 113:{f.Push(f.Locals[5]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",120);}
case 120:{f.Push(JValue.I(1));f.Pc=121;continue;}
case 121:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?145:124;continue;}
case 124:{f.Push(f.Locals[5]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",131);}
case 131:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",136);}
case 136:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",142);}
case 142:{f.Pc=164;continue;}
case 145:{f.Push(f.Locals[0]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",149);}
case 149:{f.Push(f.Locals[1]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{f.Push(f.Locals[6]);f.Pc=153;continue;}
case 153:{f.Pc=f.Pop().Int!=0?160:156;continue;}
case 156:{f.Push(JValue.I(1));f.Pc=157;continue;}
case 157:{f.Pc=161;continue;}
case 160:{f.Push(JValue.I(0));f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/player/PlayerController","chooseFlipResult","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z","invokevirtual",164);}
case 164:{f.Locals[8]=f.Pop();f.Pc=166;continue;}
case 166:{f.Push(f.Locals[8]);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[7]);f.Pc=170;continue;}
case 170:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?177:173;continue;}
case 173:{f.Push(JValue.I(1));f.Pc=174;continue;}
case 174:{f.Pc=178;continue;}
case 177:{f.Push(JValue.I(0));f.Pc=178;continue;}
case 178:{f.Locals[9]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[6]);f.Pc=182;continue;}
case 182:{f.Pc=f.Pop().Int==0?224:185;continue;}
case 185:{f.Push(f.Locals[9]);f.Pc=187;continue;}
case 187:{f.Pc=f.Pop().Int==0?206:190;continue;}
case 190:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",193);}
case 193:{f.Push(JValue.R(rt.String("lblHeads")));f.Pc=196;continue;}
case 196:{f.Push(JValue.I(0));f.Pc=197;continue;}
case 197:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",203);}
case 203:{f.Pc=219;continue;}
case 206:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",209);}
case 209:{f.Push(JValue.R(rt.String("lblTails")));f.Pc=212;continue;}
case 212:{f.Push(JValue.I(0));f.Pc=213;continue;}
case 213:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",219);}
case 219:{f.Locals[10]=f.Pop();f.Pc=221;continue;}
case 221:{f.Pc=260;continue;}
case 224:{f.Push(f.Locals[9]);f.Pc=226;continue;}
case 226:{f.Pc=f.Pop().Int==0?245:229;continue;}
case 229:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",232);}
case 232:{f.Push(JValue.R(rt.String("lblWin")));f.Pc=235;continue;}
case 235:{f.Push(JValue.I(0));f.Pc=236;continue;}
case 236:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=239;continue;}
case 239:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",242);}
case 242:{f.Pc=258;continue;}
case 245:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",248);}
case 248:{f.Push(JValue.R(rt.String("lblLose")));f.Pc=251;continue;}
case 251:{f.Push(JValue.I(0));f.Pc=252;continue;}
case 252:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",258);}
case 258:{f.Locals[10]=f.Pop();f.Pc=260;continue;}
case 260:{f.Push(f.Locals[0]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",264);}
case 264:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventFlipCoin"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventFlipCoin")));f.Pc=267;continue;}
case 267:{f.StackOp("dup");f.Pc=268;continue;}
case 268:{f.Push(f.Locals[0]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/player/Player","getView","()Lforge/game/player/PlayerView;","invokevirtual",272);}
case 272:{f.Push(f.Locals[8]);f.Pc=274;continue;}
case 274:{f.Push(JValue.I(0));f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/game/event/GameEventFlipCoin","<init>","(Lforge/game/player/PlayerView;ZZ)V","invokespecial",278);}
case 278:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",281);}
case 281:{f.Push(f.Locals[0]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",285);}
case 285:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",288);}
case 288:{f.Push(f.Locals[1]);f.Pc=289;continue;}
case 289:{f.Push(f.Locals[0]);f.Pc=290;continue;}
case 290:{f.Push(f.Locals[10]);f.Pc=292;continue;}
case 292:{f.Push(JValue.R(null));f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",296);}
case 296:{f.Push(f.Locals[0]);f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/game/player/Player","flip","()V","invokevirtual",300);}
case 300:{f.Push(f.Locals[6]);f.Pc=302;continue;}
case 302:{f.Pc=f.Pop().Int==0?309:305;continue;}
case 305:{f.Push(f.Locals[3]);f.Pc=306;continue;}
case 306:{f.Pc=f.Pop().Reference==null?347:309;continue;}
case 309:{f.Push(f.Locals[0]);f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",313);}
case 313:{f.Locals[11]=f.Pop();f.Pc=315;continue;}
case 315:{f.Push(f.Locals[11]);f.Pc=317;continue;}
case 317:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Result","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Result","Lforge/game/ability/AbilityKey;"));f.Pc=320;continue;}
case 320:{f.Push(f.Locals[9]);f.Pc=322;continue;}
case 322:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",325);}
case 325:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",330);}
case 330:{f.StackOp("pop");f.Pc=331;continue;}
case 331:{f.Push(f.Locals[0]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",335);}
case 335:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",338);}
case 338:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","FlippedCoin","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","FlippedCoin","Lforge/game/trigger/TriggerType;"));f.Pc=341;continue;}
case 341:{f.Push(f.Locals[11]);f.Pc=343;continue;}
case 343:{f.Push(JValue.I(0));f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",347);}
case 347:{f.Push(f.Locals[9]);f.Pc=349;continue;}
case 349:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

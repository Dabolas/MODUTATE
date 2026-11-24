// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C326{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/LifeSetEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3471,"forge/game/ability/effects/LifeSetEffect","<init>","()V",1,1,1,new JHandler[]{},M3471));
c.Add(new JMethod(3472,"forge/game/ability/effects/LifeSetEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,14,9,new JHandler[]{},M3472));
c.Add(new JMethod(3473,"forge/game/ability/effects/LifeSetEffect","getDistribution","(Ljava/util/List;ZLjava/util/List;)Ljava/util/List;",10,10,3,new JHandler[]{},M3473));
c.Add(new JMethod(3474,"forge/game/ability/effects/LifeSetEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,6,3,new JHandler[]{},M3474));
}

internal static JStep M3471(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3472(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Redistribute")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Int==0?20:16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{f.Pc=31;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("LifeAmount")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",27);}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",31);}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",40);}
case 40:{f.Locals[5]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",46);}
case 46:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",49);}
case 49:{f.Locals[6]=f.Pop();f.Pc=51;continue;}
case 51:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=54;continue;}
case 54:{f.StackOp("dup");f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","()V","invokespecial",58);}
case 58:{f.Locals[7]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("PlayerChoices")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?203:69;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.String("PlayerChoices")));f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",76);}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",80);}
case 80:{f.Locals[8]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(JValue.I(1));f.Pc=83;continue;}
case 83:{f.Locals[9]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(JValue.I(1));f.Pc=86;continue;}
case 86:{f.Locals[10]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{f.Push(JValue.R(rt.String("ChoiceAmount")));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int==0?141:97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("ChoiceAmount")));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",103);}
case 103:{f.Push(JValue.R(rt.String("Any")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",108);}
case 108:{f.Pc=f.Pop().Int==0?124:111;continue;}
case 111:{f.Push(f.Locals[8]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",116);}
case 116:{f.Locals[9]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(JValue.I(0));f.Pc=119;continue;}
case 119:{f.Locals[10]=f.Pop();f.Pc=121;continue;}
case 121:{f.Pc=141;continue;}
case 124:{f.Push(f.Locals[2]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[1]);f.Pc=126;continue;}
case 126:{f.Push(JValue.R(rt.String("ChoiceAmount")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",131);}
case 131:{f.Push(f.Locals[1]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",135);}
case 135:{f.Locals[9]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[9]);f.Pc=139;continue;}
case 139:{f.Locals[10]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[1]);f.Pc=142;continue;}
case 142:{f.Push(JValue.R(rt.String("ChoicePrompt")));f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",147);}
case 147:{f.Pc=f.Pop().Int==0?159:150;continue;}
case 150:{f.Push(f.Locals[1]);f.Pc=151;continue;}
case 151:{f.Push(JValue.R(rt.String("ChoicePrompt")));f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",156);}
case 156:{f.Pc=171;continue;}
case 159:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",162);}
case 162:{f.Push(JValue.R(rt.String("lblChoosePlayer")));f.Pc=164;continue;}
case 164:{f.Push(JValue.I(0));f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",171);}
case 171:{f.Locals[11]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[6]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[8]);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[10]);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[9]);f.Pc=181;continue;}
case 181:{f.Push(JValue.R(null));f.Pc=182;continue;}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[11]);f.Pc=185;continue;}
case 185:{f.Push(JValue.R(null));f.Pc=186;continue;}
case 186:{f.Push(JValue.R(null));f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/player/PlayerController","chooseEntitiesForEffect","(Lforge/util/collect/FCollectionView;IILforge/game/player/DelayedReveal;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/Player;Ljava/util/Map;)Ljava/util/List;","invokevirtual",190);}
case 190:{f.Locals[12]=f.Pop();f.Pc=192;continue;}
case 192:{f.Push(f.Locals[7]);f.Pc=194;continue;}
case 194:{f.Push(f.Locals[12]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/player/PlayerCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",199);}
case 199:{f.StackOp("pop");f.Pc=200;continue;}
case 200:{f.Pc=209;continue;}
case 203:{f.Push(f.Locals[1]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/ability/effects/LifeSetEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",207);}
case 207:{f.Locals[7]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(f.Locals[7]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/player/PlayerCollection","isEmpty","()Z","invokevirtual",214);}
case 214:{f.Pc=f.Pop().Int==0?218:217;continue;}
case 217:{return JStep.ReturnVoid;}
case 218:{f.Push(f.Locals[3]);f.Pc=219;continue;}
case 219:{f.Pc=f.Pop().Int==0?281:222;continue;}
case 222:{f.Push(f.Locals[7]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",227);}
case 227:{f.Locals[8]=f.Pop();f.Pc=229;continue;}
case 229:{f.Push(f.Locals[8]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",236);}
case 236:{f.Pc=f.Pop().Int==0?281:239;continue;}
case 239:{f.Push(f.Locals[8]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",246);}
case 246:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=249;continue;}
case 249:{f.Locals[9]=f.Pop();f.Pc=251;continue;}
case 251:{f.Push(f.Locals[9]);f.Pc=253;continue;}
case 253:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",256);}
case 256:{f.Pc=f.Pop().Int!=0?262:259;continue;}
case 259:{f.Pc=229;continue;}
case 262:{f.Push(f.Locals[5]);f.Pc=264;continue;}
case 264:{f.Push(f.Locals[9]);f.Pc=266;continue;}
case 266:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",269);}
case 269:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",272);}
case 272:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",277);}
case 277:{f.StackOp("pop");f.Pc=278;continue;}
case 278:{f.Pc=229;continue;}
case 281:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",284);}
case 284:{f.Locals[8]=f.Pop();f.Pc=286;continue;}
case 286:{f.Push(f.Locals[7]);f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/game/player/PlayerCollection","threadSafeIterable","()Ljava/lang/Iterable;","invokevirtual",291);}
case 291:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",296);}
case 296:{f.Locals[9]=f.Pop();f.Pc=298;continue;}
case 298:{f.Push(f.Locals[9]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",305);}
case 305:{f.Pc=f.Pop().Int==0?461:308;continue;}
case 308:{f.Push(f.Locals[9]);f.Pc=310;continue;}
case 310:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",315);}
case 315:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=318;continue;}
case 318:{f.Locals[10]=f.Pop();f.Pc=320;continue;}
case 320:{f.Push(f.Locals[10]);f.Pc=322;continue;}
case 322:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",325);}
case 325:{f.Pc=f.Pop().Int!=0?331:328;continue;}
case 328:{f.Pc=298;continue;}
case 331:{f.Push(f.Locals[10]);f.Pc=333;continue;}
case 333:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",336);}
case 336:{f.Locals[11]=f.Pop();f.Pc=338;continue;}
case 338:{f.Push(f.Locals[3]);f.Pc=339;continue;}
case 339:{f.Pc=f.Pop().Int!=0?354:342;continue;}
case 342:{f.Push(f.Locals[10]);f.Pc=344;continue;}
case 344:{f.Push(f.Locals[4]);f.Pc=346;continue;}
case 346:{f.Push(f.Locals[1]);f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/game/player/Player","setLife","(ILforge/game/spellability/SpellAbility;)Z","invokevirtual",350);}
case 350:{f.StackOp("pop");f.Pc=351;continue;}
case 351:{f.Pc=428;continue;}
case 354:{f.Push(f.Locals[7]);f.Pc=356;continue;}
case 356:{f.Push(JValue.I(1));f.Pc=357;continue;}
case 357:{f.Push(f.Locals[5]);f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/ability/effects/LifeSetEffect","getDistribution","(Ljava/util/List;ZLjava/util/List;)Ljava/util/List;","invokestatic",362);}
case 362:{f.Locals[12]=f.Pop();f.Pc=364;continue;}
case 364:{f.Push(f.Locals[6]);f.Pc=366;continue;}
case 366:{f.Push(f.Locals[1]);f.Pc=367;continue;}
case 367:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",370);}
case 370:{f.Push(JValue.R(rt.String("lblLifeTotal")));f.Pc=372;continue;}
case 372:{f.Push(JValue.I(0));f.Pc=373;continue;}
case 373:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=376;continue;}
case 376:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",379);}
case 379:{f.Push(f.Locals[10]);f.Pc=381;continue;}
case 381:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",384);}
case 384:{return rt.DynamicCall(f,"forge/game/ability/effects/LifeSetEffect:3472:384:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",389);}
case 389:{f.Push(f.Locals[12]);f.Pc=391;continue;}
case 391:{f.Push(f.Locals[10]);f.Pc=393;continue;}
case 393:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/List;Lforge/game/player/Player;)I","invokevirtual",396);}
case 396:{f.Locals[13]=f.Pop();f.Pc=398;continue;}
case 398:{f.Push(f.Locals[10]);f.Pc=400;continue;}
case 400:{f.Push(f.Locals[13]);f.Pc=402;continue;}
case 402:{f.Push(f.Locals[1]);f.Pc=403;continue;}
case 403:{return rt.Call(f,"forge/game/player/Player","setLife","(ILforge/game/spellability/SpellAbility;)Z","invokevirtual",406);}
case 406:{f.StackOp("pop");f.Pc=407;continue;}
case 407:{f.Push(f.Locals[5]);f.Pc=409;continue;}
case 409:{f.Push(f.Locals[13]);f.Pc=411;continue;}
case 411:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",414);}
case 414:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",419);}
case 419:{f.StackOp("pop");f.Pc=420;continue;}
case 420:{f.Push(f.Locals[7]);f.Pc=422;continue;}
case 422:{f.Push(f.Locals[10]);f.Pc=424;continue;}
case 424:{return rt.Call(f,"forge/game/player/PlayerCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",427);}
case 427:{f.StackOp("pop");f.Pc=428;continue;}
case 428:{f.Push(f.Locals[11]);f.Pc=430;continue;}
case 430:{f.Push(f.Locals[10]);f.Pc=432;continue;}
case 432:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",435);}
case 435:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=436;continue;}
case 436:{f.Locals[12]=f.Pop();f.Pc=438;continue;}
case 438:{f.Push(f.Locals[12]);f.Pc=440;continue;}
case 440:{f.Pc=f.Pop().Int<=0?458:443;continue;}
case 443:{f.Push(f.Locals[8]);f.Pc=445;continue;}
case 445:{f.Push(f.Locals[10]);f.Pc=447;continue;}
case 447:{f.Push(f.Locals[12]);f.Pc=449;continue;}
case 449:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",452);}
case 452:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",457);}
case 457:{f.StackOp("pop");f.Pc=458;continue;}
case 458:{f.Pc=298;continue;}
case 461:{f.Push(f.Locals[8]);f.Pc=463;continue;}
case 463:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",468);}
case 468:{f.Pc=f.Pop().Int!=0?494:471;continue;}
case 471:{f.Push(f.Locals[8]);f.Pc=473;continue;}
case 473:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPIMap","(Ljava/util/Map;)Ljava/util/Map;","invokestatic",476);}
case 476:{f.Locals[9]=f.Pop();f.Pc=478;continue;}
case 478:{f.Push(f.Locals[2]);f.Pc=479;continue;}
case 479:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",482);}
case 482:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",485);}
case 485:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","LifeLostAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","LifeLostAll","Lforge/game/trigger/TriggerType;"));f.Pc=488;continue;}
case 488:{f.Push(f.Locals[9]);f.Pc=490;continue;}
case 490:{f.Push(JValue.I(0));f.Pc=491;continue;}
case 491:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",494);}
case 494:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3473(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",6);}
case 6:{f.Pc=f.Pop().Int==0?22:9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",14);}
case 14:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return JStep.Return(f.Pop());}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",26);}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",33);}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int==0?234:45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{f.Locals[5]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",63);}
case 63:{f.Locals[6]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[6]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",72);}
case 72:{f.Pc=f.Pop().Int==0?225:75;continue;}
case 75:{f.Push(f.Locals[6]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",82);}
case 82:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=85;continue;}
case 85:{f.Locals[7]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",92);}
case 92:{f.Push(f.Locals[7]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",97);}
case 97:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?108:100;continue;}
case 100:{f.Push(f.Locals[5]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/player/Player","canGainLife","()Z","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Int==0?129:108;continue;}
case 108:{f.Push(f.Locals[5]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",113);}
case 113:{f.Push(f.Locals[7]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",118);}
case 118:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?145:121;continue;}
case 121:{f.Push(f.Locals[5]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/player/Player","canLoseLife","()Z","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Int!=0?145:129;continue;}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{f.Pc=f.Pop().Int==0?65:133;continue;}
case 133:{f.Push(f.Locals[3]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[7]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",141);}
case 141:{f.StackOp("pop");f.Pc=142;continue;}
case 142:{f.Pc=65;continue;}
case 145:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=148;continue;}
case 148:{f.StackOp("dup");f.Pc=149;continue;}
case 149:{f.Push(f.Locals[0]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",153);}
case 153:{f.Locals[8]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[8]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[5]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/player/PlayerCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",162);}
case 162:{f.StackOp("pop");f.Pc=163;continue;}
case 163:{f.Push(f.Locals[2]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",167);}
case 167:{f.Locals[9]=f.Pop();f.Pc=169;continue;}
case 169:{f.Push(f.Locals[9]);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[7]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",178);}
case 178:{f.StackOp("pop");f.Pc=179;continue;}
case 179:{f.Push(f.Locals[8]);f.Pc=181;continue;}
case 181:{f.Push(JValue.I(0));f.Pc=182;continue;}
case 182:{f.Push(f.Locals[9]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/ability/effects/LifeSetEffect","getDistribution","(Ljava/util/List;ZLjava/util/List;)Ljava/util/List;","invokestatic",187);}
case 187:{f.Locals[9]=f.Pop();f.Pc=189;continue;}
case 189:{f.Push(f.Locals[9]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",196);}
case 196:{f.Pc=f.Pop().Int==0?215:199;continue;}
case 199:{f.Push(f.Locals[1]);f.Pc=200;continue;}
case 200:{f.Pc=f.Pop().Int==0?222:203;continue;}
case 203:{f.Push(f.Locals[3]);f.Pc=204;continue;}
case 204:{f.Push(f.Locals[7]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",211);}
case 211:{f.StackOp("pop");f.Pc=212;continue;}
case 212:{f.Pc=222;continue;}
case 215:{f.Push(f.Locals[1]);f.Pc=216;continue;}
case 216:{f.Pc=f.Pop().Int!=0?222:219;continue;}
case 219:{f.Push(f.Locals[9]);f.Pc=221;continue;}
case 221:{return JStep.Return(f.Pop());}
case 222:{f.Pc=65;continue;}
case 225:{f.Push(f.Locals[1]);f.Pc=226;continue;}
case 226:{f.Pc=f.Pop().Int==0?231:229;continue;}
case 229:{f.Push(f.Locals[3]);f.Pc=230;continue;}
case 230:{return JStep.Return(f.Pop());}
case 231:{f.Pc=35;continue;}
case 234:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",237);}
case 237:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3474(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Redistribute")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?28:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?25:18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",24);}
case 24:{return JStep.Return(f.Pop());}
case 25:{f.Push(JValue.R(rt.String("Please add StackDescription or SpellDescription for Redistribute in LifeSetEffect.")));f.Pc=27;continue;}
case 27:{return JStep.Return(f.Pop());}
case 28:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",35);}
case 35:{f.Locals[2]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",40);}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("LifeAmount")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",46);}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",50);}
case 50:{f.Locals[3]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/ability/effects/LifeSetEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",55);}
case 55:{f.Locals[4]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("Defined")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/ability/effects/LifeSetEffect","playersOrDescribed","(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;","invokestatic",65);}
case 65:{f.Locals[5]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",75);}
case 75:{f.Push(JValue.I(1));f.Pc=76;continue;}
case 76:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?89:79;continue;}
case 79:{f.Push(f.Locals[5]);f.Pc=81;continue;}
case 81:{return rt.DynamicCall(f,"forge/game/ability/effects/LifeSetEffect:3474:81:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",86);}
case 86:{f.Pc=102;continue;}
case 89:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",92);}
case 92:{f.Push(f.Locals[5]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/util/Lang","getPossesive","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",97);}
case 97:{return rt.DynamicCall(f,"forge/game/ability/effects/LifeSetEffect:3474:97:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",102);}
case 102:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",105);}
case 105:{f.Push(f.Locals[3]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",109);}
case 109:{f.Push(JValue.R(rt.String(".")));f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",115);}
case 115:{f.StackOp("pop");f.Pc=116;continue;}
case 116:{f.Push(f.Locals[2]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",120);}
case 120:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

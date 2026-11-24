// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C520{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostAdjustment","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(6224,"forge/game/cost/CostAdjustment","<init>","()V",1,1,1,new JHandler[]{},M6224));
c.Add(new JMethod(6225,"forge/game/cost/CostAdjustment","adjust","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Z)Lforge/game/cost/Cost;",9,14,5,new JHandler[]{},M6225));
c.Add(new JMethod(6226,"forge/game/cost/CostAdjustment","applyRaiseCostAbility","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Lforge/game/staticability/StaticAbility;)V",10,10,6,new JHandler[]{},M6226));
c.Add(new JMethod(6227,"forge/game/cost/CostAdjustment","adjust","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Lforge/game/card/CardCollection;ZZ)Z",9,20,6,new JHandler[]{},M6227));
c.Add(new JMethod(6228,"forge/game/cost/CostAdjustment","adjustCostByAssist","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;Z)Z",10,8,5,new JHandler[]{},M6228));
c.Add(new JMethod(6229,"forge/game/cost/CostAdjustment","adjustCostByWaterbend","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)V",10,5,6,new JHandler[]{},M6229));
c.Add(new JMethod(6230,"forge/game/cost/CostAdjustment","adjustCostByConvokeOrImprovise","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;ZZZ)V",10,13,7,new JHandler[]{},M6230));
c.Add(new JMethod(6231,"forge/game/cost/CostAdjustment","adjustCostByOffering","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;)V",10,6,6,new JHandler[]{},M6231));
c.Add(new JMethod(6232,"forge/game/cost/CostAdjustment","adjustCostByEmerge","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;Lforge/game/keyword/Emerge;)V",10,8,6,new JHandler[]{},M6232));
c.Add(new JMethod(6233,"forge/game/cost/CostAdjustment","applySetCostAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/spellability/SpellAbility;Lforge/game/mana/ManaCostBeingPaid;)V",10,5,2,new JHandler[]{},M6233));
c.Add(new JMethod(6234,"forge/game/cost/CostAdjustment","applyReduceCostAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/spellability/SpellAbility;Lforge/game/mana/ManaCostBeingPaid;I)I",10,14,5,new JHandler[]{},M6234));
c.Add(new JMethod(6235,"forge/game/cost/CostAdjustment","checkRequirement","(Lforge/game/spellability/SpellAbility;Lforge/game/staticability/StaticAbility;)Z",10,11,5,new JHandler[]{},M6235));
c.Add(new JMethod(6236,"forge/game/cost/CostAdjustment","lambda$adjustCostByConvokeOrImprovise$0","(Lforge/game/card/Card;)Z",4106,1,1,new JHandler[]{},M6236));
}

internal static JStep M6224(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6225(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?15:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference==null?15:11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Int==0?22:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","setMaxWaterbend","(Lforge/game/cost/Cost;)V","invokevirtual",20);}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return JStep.Return(f.Pop());}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",26);}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",31);}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",37);}
case 37:{f.Locals[5]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/cost/Cost","copy","()Lforge/game/cost/Cost;","invokevirtual",43);}
case 43:{f.Locals[6]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{f.Locals[7]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int==0?146:55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCastFaceDown","()Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int==0?79:62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",67);}
case 67:{f.Pc=f.Pop().Int!=0?79:70;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/card/Card","turnFaceDownNoUpdate","()Z","invokevirtual",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{f.Push(JValue.I(1));f.Pc=77;continue;}
case 77:{f.Locals[7]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[4]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/Card","isCommander","()Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int==0?146:87;continue;}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/card/Card","getCastFrom","()Lforge/game/zone/Zone;","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Reference==null?146:95;continue;}
case 95:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=98;continue;}
case 98:{f.Push(f.Locals[4]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/card/Card","getCastFrom","()Lforge/game/zone/Zone;","invokevirtual",103);}
case 103:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",106);}
case 106:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",109);}
case 109:{f.Pc=f.Pop().Int==0?146:112;continue;}
case 112:{f.Push(f.Locals[3]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[4]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/player/Player","getCommanderCast","(Lforge/game/card/Card;)I","invokevirtual",118);}
case 118:{f.Push(JValue.I(2));f.Pc=119;continue;}
case 119:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=120;continue;}
case 120:{f.Locals[8]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[8]);f.Pc=124;continue;}
case 124:{f.Pc=f.Pop().Int<=0?146:127;continue;}
case 127:{f.Push(f.Locals[6]);f.Pc=129;continue;}
case 129:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=132;continue;}
case 132:{f.StackOp("dup");f.Pc=133;continue;}
case 133:{f.Push(f.Locals[8]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/card/mana/ManaCost","get","(I)Lforge/card/mana/ManaCost;","invokestatic",138);}
case 138:{f.Push(JValue.I(0));f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Lforge/card/mana/ManaCost;Z)V","invokespecial",142);}
case 142:{return rt.Call(f,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;)Lforge/game/cost/Cost;","invokevirtual",145);}
case 145:{f.StackOp("pop");f.Pc=146;continue;}
case 146:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=149;continue;}
case 149:{f.StackOp("dup");f.Pc=150;continue;}
case 150:{f.Push(f.Locals[5]);f.Pc=152;continue;}
case 152:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",158);}
case 158:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",161);}
case 161:{f.Locals[8]=f.Pop();f.Pc=163;continue;}
case 163:{f.Push(f.Locals[8]);f.Pc=165;continue;}
case 165:{f.Push(f.Locals[5]);f.Pc=167;continue;}
case 167:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",173);}
case 173:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",176);}
case 176:{f.StackOp("pop");f.Pc=177;continue;}
case 177:{f.Push(f.Locals[8]);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[5]);f.Pc=181;continue;}
case 181:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",187);}
case 187:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",190);}
case 190:{f.StackOp("pop");f.Pc=191;continue;}
case 191:{f.Push(f.Locals[8]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[4]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",198);}
case 198:{f.Pc=f.Pop().Int!=0?209:201;continue;}
case 201:{f.Push(f.Locals[8]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[4]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",208);}
case 208:{f.StackOp("pop");f.Pc=209;continue;}
case 209:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",212);}
case 212:{f.Locals[9]=f.Pop();f.Pc=214;continue;}
case 214:{f.Push(f.Locals[8]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",219);}
case 219:{f.Locals[10]=f.Pop();f.Pc=221;continue;}
case 221:{f.Push(f.Locals[10]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",228);}
case 228:{f.Pc=f.Pop().Int==0?304:231;continue;}
case 231:{f.Push(f.Locals[10]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",238);}
case 238:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=241;continue;}
case 241:{f.Locals[11]=f.Pop();f.Pc=243;continue;}
case 243:{f.Push(f.Locals[11]);f.Pc=245;continue;}
case 245:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",248);}
case 248:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",253);}
case 253:{f.Locals[12]=f.Pop();f.Pc=255;continue;}
case 255:{f.Push(f.Locals[12]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",262);}
case 262:{f.Pc=f.Pop().Int==0?301:265;continue;}
case 265:{f.Push(f.Locals[12]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",272);}
case 272:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=275;continue;}
case 275:{f.Locals[13]=f.Pop();f.Pc=277;continue;}
case 277:{f.Push(f.Locals[13]);f.Pc=279;continue;}
case 279:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","RaiseCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","RaiseCost","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkMode","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",285);}
case 285:{f.Pc=f.Pop().Int==0?298:288;continue;}
case 288:{f.Push(f.Locals[9]);f.Pc=290;continue;}
case 290:{f.Push(f.Locals[13]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",297);}
case 297:{f.StackOp("pop");f.Pc=298;continue;}
case 298:{f.Pc=255;continue;}
case 301:{f.Pc=221;continue;}
case 304:{f.Push(f.Locals[1]);f.Pc=305;continue;}
case 305:{f.Push(JValue.R(rt.String("RaiseCost")));f.Pc=307;continue;}
case 307:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",310);}
case 310:{f.Pc=f.Pop().Int==0?374:313;continue;}
case 313:{f.Push(f.Locals[1]);f.Pc=314;continue;}
case 314:{f.Push(JValue.R(rt.String("RaiseCost")));f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",319);}
case 319:{f.Locals[10]=f.Pop();f.Pc=321;continue;}
case 321:{f.Push(f.Locals[1]);f.Pc=322;continue;}
case 322:{f.Push(f.Locals[10]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasSVar","(Ljava/lang/String;)Z","invokevirtual",327);}
case 327:{f.Pc=f.Pop().Int==0?354:330;continue;}
case 330:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=333;continue;}
case 333:{f.StackOp("dup");f.Pc=334;continue;}
case 334:{f.Push(f.Locals[4]);f.Pc=336;continue;}
case 336:{f.Push(f.Locals[10]);f.Pc=338;continue;}
case 338:{f.Push(f.Locals[1]);f.Pc=339;continue;}
case 339:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",342);}
case 342:{return rt.Call(f,"forge/card/mana/ManaCost","get","(I)Lforge/card/mana/ManaCost;","invokestatic",345);}
case 345:{f.Push(JValue.I(0));f.Pc=346;continue;}
case 346:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Lforge/card/mana/ManaCost;Z)V","invokespecial",349);}
case 349:{f.Locals[11]=f.Pop();f.Pc=351;continue;}
case 351:{f.Pc=366;continue;}
case 354:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=357;continue;}
case 357:{f.StackOp("dup");f.Pc=358;continue;}
case 358:{f.Push(f.Locals[10]);f.Pc=360;continue;}
case 360:{f.Push(JValue.I(0));f.Pc=361;continue;}
case 361:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",364);}
case 364:{f.Locals[11]=f.Pop();f.Pc=366;continue;}
case 366:{f.Push(f.Locals[6]);f.Pc=368;continue;}
case 368:{f.Push(f.Locals[11]);f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;)Lforge/game/cost/Cost;","invokevirtual",373);}
case 373:{f.StackOp("pop");f.Pc=374;continue;}
case 374:{f.Push(f.Locals[9]);f.Pc=376;continue;}
case 376:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",381);}
case 381:{f.Locals[10]=f.Pop();f.Pc=383;continue;}
case 383:{f.Push(f.Locals[10]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",390);}
case 390:{f.Pc=f.Pop().Int==0?416:393;continue;}
case 393:{f.Push(f.Locals[10]);f.Pc=395;continue;}
case 395:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",400);}
case 400:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=403;continue;}
case 403:{f.Locals[11]=f.Pop();f.Pc=405;continue;}
case 405:{f.Push(f.Locals[6]);f.Pc=407;continue;}
case 407:{f.Push(f.Locals[1]);f.Pc=408;continue;}
case 408:{f.Push(f.Locals[11]);f.Pc=410;continue;}
case 410:{return rt.Call(f,"forge/game/cost/CostAdjustment","applyRaiseCostAbility","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Lforge/game/staticability/StaticAbility;)V","invokestatic",413);}
case 413:{f.Pc=383;continue;}
case 416:{f.Push(f.Locals[7]);f.Pc=418;continue;}
case 418:{f.Pc=f.Pop().Int==0?437:421;continue;}
case 421:{f.Push(f.Locals[4]);f.Pc=423;continue;}
case 423:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=426;continue;}
case 426:{f.Push(JValue.I(0));f.Pc=427;continue;}
case 427:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",430);}
case 430:{f.StackOp("pop");f.Pc=431;continue;}
case 431:{f.Push(f.Locals[4]);f.Pc=433;continue;}
case 433:{f.Push(JValue.I(0));f.Pc=434;continue;}
case 434:{return rt.Call(f,"forge/game/card/Card","setFaceDown","(Z)V","invokevirtual",437);}
case 437:{f.Push(f.Locals[1]);f.Pc=438;continue;}
case 438:{f.Push(f.Locals[6]);f.Pc=440;continue;}
case 440:{return rt.Call(f,"forge/game/spellability/SpellAbility","setMaxWaterbend","(Lforge/game/cost/Cost;)V","invokevirtual",443);}
case 443:{f.Push(f.Locals[6]);f.Pc=445;continue;}
case 445:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6226(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/cost/CostAdjustment","checkRequirement","(Lforge/game/spellability/SpellAbility;Lforge/game/staticability/StaticAbility;)Z","invokestatic",10);}
case 10:{f.Pc=f.Pop().Int!=0?14:13;continue;}
case 13:{return JStep.ReturnVoid;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("Cost")));f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("1")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",22);}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{f.Locals[5]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("ForEachShard")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?152:36;continue;}
case 36:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","ZERO","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","ZERO","Lforge/card/mana/ManaCost;"));f.Pc=39;continue;}
case 39:{f.Locals[6]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int==0?60:48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",52);}
case 52:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",55);}
case 55:{f.Locals[6]=f.Pop();f.Pc=57;continue;}
case 57:{f.Pc=89;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",64);}
case 64:{f.Pc=f.Pop().Int==0?89:67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",71);}
case 71:{return rt.Call(f,"forge/game/cost/Cost","hasManaCost","()Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int==0?89:77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",81);}
case 81:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",84);}
case 84:{return rt.Call(f,"forge/game/cost/CostPartMana","getMana","()Lforge/card/mana/ManaCost;","invokevirtual",87);}
case 87:{f.Locals[6]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[2]);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("ForEachShard")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",95);}
case 95:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",98);}
case 98:{return rt.Call(f,"forge/card/mana/ManaAtom","fromName","(Ljava/lang/String;)B","invokestatic",101);}
case 101:{f.Locals[7]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[6]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/card/mana/ManaCost","iterator","()Ljava/util/Iterator;","invokevirtual",108);}
case 108:{f.Locals[8]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[8]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",117);}
case 117:{f.Pc=f.Pop().Int==0?149:120;continue;}
case 120:{f.Push(f.Locals[8]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",127);}
case 127:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=130;continue;}
case 130:{f.Locals[9]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(f.Locals[9]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/card/mana/ManaCostShard","getColorMask","()B","invokevirtual",137);}
case 137:{f.Push(f.Locals[7]);f.Pc=139;continue;}
case 139:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=140;continue;}
case 140:{f.Pc=f.Pop().Int==0?146:143;continue;}
case 143:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=146;continue;}
case 146:{f.Pc=110;continue;}
case 149:{f.Pc=445;continue;}
case 152:{f.Push(f.Locals[2]);f.Pc=153;continue;}
case 153:{f.Push(JValue.R(rt.String("Amount")));f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",159);}
case 159:{f.Pc=f.Pop().Int==0?442:162;continue;}
case 162:{f.Push(f.Locals[2]);f.Pc=163;continue;}
case 163:{f.Push(JValue.R(rt.String("Amount")));f.Pc=166;continue;}
case 166:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",169);}
case 169:{f.Locals[6]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(JValue.R(rt.String("Escalate")));f.Pc=174;continue;}
case 174:{f.Push(f.Locals[6]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",179);}
case 179:{f.Pc=f.Pop().Int==0?217:182;continue;}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTailAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",186);}
case 186:{f.Locals[7]=f.Pop();f.Pc=188;continue;}
case 188:{f.Push(f.Locals[7]);f.Pc=190;continue;}
case 190:{f.Push(JValue.R(rt.String("CharmOrder")));f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasSVar","(Ljava/lang/String;)Z","invokevirtual",196);}
case 196:{f.Pc=f.Pop().Int==0?214:199;continue;}
case 199:{f.Push(f.Locals[7]);f.Pc=201;continue;}
case 201:{f.Push(JValue.R(rt.String("CharmOrder")));f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVarInt","(Ljava/lang/String;)Ljava/lang/Integer;","invokevirtual",207);}
case 207:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",210);}
case 210:{f.Push(JValue.I(1));f.Pc=211;continue;}
case 211:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=212;continue;}
case 212:{f.Locals[5]=f.Pop();f.Pc=214;continue;}
case 214:{f.Pc=439;continue;}
case 217:{f.Push(JValue.R(rt.String("Strive")));f.Pc=220;continue;}
case 220:{f.Push(f.Locals[6]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",225);}
case 225:{f.Pc=f.Pop().Int==0?280:228;continue;}
case 228:{f.Push(f.Locals[1]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAllTargetChoices","()Ljava/util/List;","invokevirtual",232);}
case 232:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",237);}
case 237:{f.Locals[7]=f.Pop();f.Pc=239;continue;}
case 239:{f.Push(f.Locals[7]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",246);}
case 246:{f.Pc=f.Pop().Int==0?274:249;continue;}
case 249:{f.Push(f.Locals[7]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",256);}
case 256:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/TargetChoices"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=259;continue;}
case 259:{f.Locals[8]=f.Pop();f.Pc=261;continue;}
case 261:{f.Push(f.Locals[5]);f.Pc=263;continue;}
case 263:{f.Push(f.Locals[8]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/spellability/TargetChoices","size","()I","invokevirtual",268);}
case 268:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=269;continue;}
case 269:{f.Locals[5]=f.Pop();f.Pc=271;continue;}
case 271:{f.Pc=239;continue;}
case 274:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(-1)));f.Pc=277;continue;}
case 277:{f.Pc=439;continue;}
case 280:{f.Push(JValue.R(rt.String("Spree")));f.Pc=283;continue;}
case 283:{f.Push(f.Locals[6]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",288);}
case 288:{f.Pc=f.Pop().Int!=0?302:291;continue;}
case 291:{f.Push(JValue.R(rt.String("Tiered")));f.Pc=294;continue;}
case 294:{f.Push(f.Locals[6]);f.Pc=296;continue;}
case 296:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",299);}
case 299:{f.Pc=f.Pop().Int==0?372:302;continue;}
case 302:{f.Push(f.Locals[1]);f.Pc=303;continue;}
case 303:{f.Locals[7]=f.Pop();f.Pc=305;continue;}
case 305:{f.Push(f.Locals[7]);f.Pc=307;continue;}
case 307:{f.Pc=f.Pop().Reference==null?369:310;continue;}
case 310:{f.Push(f.Locals[7]);f.Pc=312;continue;}
case 312:{f.Push(JValue.R(rt.String("ModeCost")));f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",318);}
case 318:{f.Pc=f.Pop().Int==0?359:321;continue;}
case 321:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=324;continue;}
case 324:{f.StackOp("dup");f.Pc=325;continue;}
case 325:{f.Push(f.Locals[7]);f.Pc=327;continue;}
case 327:{f.Push(JValue.R(rt.String("ModeCost")));f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",333);}
case 333:{f.Push(f.Locals[1]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",337);}
case 337:{f.Push(f.Locals[1]);f.Pc=338;continue;}
case 338:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",341);}
case 341:{f.Push(f.Locals[3]);f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",345);}
case 345:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;ZZ)V","invokespecial",348);}
case 348:{f.Locals[8]=f.Pop();f.Pc=350;continue;}
case 350:{f.Push(f.Locals[0]);f.Pc=351;continue;}
case 351:{f.Push(f.Locals[8]);f.Pc=353;continue;}
case 353:{f.Push(f.Locals[5]);f.Pc=355;continue;}
case 355:{f.Push(f.Locals[1]);f.Pc=356;continue;}
case 356:{return rt.Call(f,"forge/game/cost/Cost","mergeTo","(Lforge/game/cost/Cost;ILforge/game/spellability/SpellAbility;)V","invokevirtual",359);}
case 359:{f.Push(f.Locals[7]);f.Pc=361;continue;}
case 361:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",364);}
case 364:{f.Locals[7]=f.Pop();f.Pc=366;continue;}
case 366:{f.Pc=305;continue;}
case 369:{f.Pc=439;continue;}
case 372:{f.Push(f.Locals[6]);f.Pc=374;continue;}
case 374:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",377);}
case 377:{f.Pc=f.Pop().Int==0?390:380;continue;}
case 380:{f.Push(f.Locals[6]);f.Pc=382;continue;}
case 382:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",385);}
case 385:{f.Locals[5]=f.Pop();f.Pc=387;continue;}
case 387:{f.Pc=439;continue;}
case 390:{f.Push(f.Locals[2]);f.Pc=391;continue;}
case 391:{f.Push(JValue.R(rt.String("Relative")));f.Pc=394;continue;}
case 394:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",397);}
case 397:{f.Pc=f.Pop().Int==0?430:400;continue;}
case 400:{f.Push(f.Locals[3]);f.Pc=401;continue;}
case 401:{f.Push(f.Locals[2]);f.Pc=402;continue;}
case 402:{f.Push(f.Locals[6]);f.Pc=404;continue;}
case 404:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasSVar","(Ljava/lang/String;)Z","invokevirtual",407);}
case 407:{f.Pc=f.Pop().Int==0?419:410;continue;}
case 410:{f.Push(f.Locals[2]);f.Pc=411;continue;}
case 411:{f.Push(f.Locals[6]);f.Pc=413;continue;}
case 413:{return rt.Call(f,"forge/game/staticability/StaticAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",416);}
case 416:{f.Pc=421;continue;}
case 419:{f.Push(f.Locals[6]);f.Pc=421;continue;}
case 421:{f.Push(f.Locals[1]);f.Pc=422;continue;}
case 422:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",425);}
case 425:{f.Locals[5]=f.Pop();f.Pc=427;continue;}
case 427:{f.Pc=439;continue;}
case 430:{f.Push(f.Locals[3]);f.Pc=431;continue;}
case 431:{f.Push(f.Locals[6]);f.Pc=433;continue;}
case 433:{f.Push(f.Locals[2]);f.Pc=434;continue;}
case 434:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",437);}
case 437:{f.Locals[5]=f.Pop();f.Pc=439;continue;}
case 439:{f.Pc=445;continue;}
case 442:{f.Push(JValue.I(1));f.Pc=443;continue;}
case 443:{f.Locals[5]=f.Pop();f.Pc=445;continue;}
case 445:{f.Push(f.Locals[5]);f.Pc=447;continue;}
case 447:{f.Pc=f.Pop().Int<=0?482:450;continue;}
case 450:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=453;continue;}
case 453:{f.StackOp("dup");f.Pc=454;continue;}
case 454:{f.Push(f.Locals[4]);f.Pc=456;continue;}
case 456:{f.Push(f.Locals[1]);f.Pc=457;continue;}
case 457:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",460);}
case 460:{f.Push(f.Locals[1]);f.Pc=461;continue;}
case 461:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",464);}
case 464:{f.Push(f.Locals[3]);f.Pc=465;continue;}
case 465:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",468);}
case 468:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;ZZ)V","invokespecial",471);}
case 471:{f.Locals[6]=f.Pop();f.Pc=473;continue;}
case 473:{f.Push(f.Locals[0]);f.Pc=474;continue;}
case 474:{f.Push(f.Locals[6]);f.Pc=476;continue;}
case 476:{f.Push(f.Locals[5]);f.Pc=478;continue;}
case 478:{f.Push(f.Locals[1]);f.Pc=479;continue;}
case 479:{return rt.Call(f,"forge/game/cost/Cost","mergeTo","(Lforge/game/cost/Cost;ILforge/game/spellability/SpellAbility;)V","invokevirtual",482);}
case 482:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6227(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[5]);f.Pc=2;continue;}
case 2:{f.Pc=f.Pop().Int==0?13:5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[4]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/cost/CostAdjustment","adjustCostByWaterbend","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)V","invokestatic",13);}
case 13:{f.Push(f.Locals[5]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Int!=0?32:18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int!=0?32:25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","isReplacementAbility","()Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int==0?34:32;continue;}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",38);}
case 38:{f.Locals[6]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[6]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",45);}
case 45:{f.Locals[7]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",51);}
case 51:{f.Locals[8]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(JValue.I(0));f.Pc=54;continue;}
case 54:{f.Locals[9]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int==0?87:63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCastFaceDown","()Z","invokevirtual",67);}
case 67:{f.Pc=f.Pop().Int==0?87:70;continue;}
case 70:{f.Push(f.Locals[8]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",75);}
case 75:{f.Pc=f.Pop().Int!=0?87:78;continue;}
case 78:{f.Push(f.Locals[8]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/card/Card","turnFaceDownNoUpdate","()Z","invokevirtual",83);}
case 83:{f.StackOp("pop");f.Pc=84;continue;}
case 84:{f.Push(JValue.I(1));f.Pc=85;continue;}
case 85:{f.Locals[9]=f.Pop();f.Pc=87;continue;}
case 87:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(f.Locals[7]);f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",99);}
case 99:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",102);}
case 102:{f.Locals[10]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[10]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[7]);f.Pc=108;continue;}
case 108:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",114);}
case 114:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",117);}
case 117:{f.StackOp("pop");f.Pc=118;continue;}
case 118:{f.Push(f.Locals[10]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[7]);f.Pc=122;continue;}
case 122:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",128);}
case 128:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",131);}
case 131:{f.StackOp("pop");f.Pc=132;continue;}
case 132:{f.Push(f.Locals[10]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[8]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",139);}
case 139:{f.Pc=f.Pop().Int!=0?150:142;continue;}
case 142:{f.Push(f.Locals[10]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[8]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",149);}
case 149:{f.StackOp("pop");f.Pc=150;continue;}
case 150:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",153);}
case 153:{f.Locals[11]=f.Pop();f.Pc=155;continue;}
case 155:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",158);}
case 158:{f.Locals[12]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(f.Locals[10]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",165);}
case 165:{f.Locals[13]=f.Pop();f.Pc=167;continue;}
case 167:{f.Push(f.Locals[13]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",174);}
case 174:{f.Pc=f.Pop().Int==0?283:177;continue;}
case 177:{f.Push(f.Locals[13]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",184);}
case 184:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=187;continue;}
case 187:{f.Locals[14]=f.Pop();f.Pc=189;continue;}
case 189:{f.Push(f.Locals[14]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",194);}
case 194:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",199);}
case 199:{f.Locals[15]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(f.Locals[15]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",208);}
case 208:{f.Pc=f.Pop().Int==0?280:211;continue;}
case 211:{f.Push(f.Locals[15]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",218);}
case 218:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=221;continue;}
case 221:{f.Locals[16]=f.Pop();f.Pc=223;continue;}
case 223:{f.Push(f.Locals[16]);f.Pc=225;continue;}
case 225:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","ReduceCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","ReduceCost","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkMode","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",231);}
case 231:{f.Pc=f.Pop().Int==0?256:234;continue;}
case 234:{f.Push(f.Locals[1]);f.Pc=235;continue;}
case 235:{f.Push(f.Locals[16]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/game/cost/CostAdjustment","checkRequirement","(Lforge/game/spellability/SpellAbility;Lforge/game/staticability/StaticAbility;)Z","invokestatic",240);}
case 240:{f.Pc=f.Pop().Int==0?256:243;continue;}
case 243:{f.Push(f.Locals[11]);f.Pc=245;continue;}
case 245:{f.Push(f.Locals[16]);f.Pc=247;continue;}
case 247:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",252);}
case 252:{f.StackOp("pop");f.Pc=253;continue;}
case 253:{f.Pc=277;continue;}
case 256:{f.Push(f.Locals[16]);f.Pc=258;continue;}
case 258:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","SetCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","SetCost","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkMode","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",264);}
case 264:{f.Pc=f.Pop().Int==0?277:267;continue;}
case 267:{f.Push(f.Locals[12]);f.Pc=269;continue;}
case 269:{f.Push(f.Locals[16]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",276);}
case 276:{f.StackOp("pop");f.Pc=277;continue;}
case 277:{f.Pc=201;continue;}
case 280:{f.Pc=167;continue;}
case 283:{f.Push(JValue.I(0));f.Pc=284;continue;}
case 284:{f.Locals[13]=f.Pop();f.Pc=286;continue;}
case 286:{f.Push(f.Locals[1]);f.Pc=287;continue;}
case 287:{f.Push(JValue.R(rt.String("ReduceCost")));f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",293);}
case 293:{f.Pc=f.Pop().Int==0?374:296;continue;}
case 296:{f.Push(f.Locals[1]);f.Pc=297;continue;}
case 297:{f.Push(JValue.R(rt.String("ReduceCost")));f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",303);}
case 303:{f.Locals[14]=f.Pop();f.Pc=305;continue;}
case 305:{f.Push(f.Locals[1]);f.Pc=306;continue;}
case 306:{f.Push(JValue.R(rt.String("ReduceAmount")));f.Pc=309;continue;}
case 309:{f.Push(f.Locals[14]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",314);}
case 314:{f.Locals[15]=f.Pop();f.Pc=316;continue;}
case 316:{f.Push(f.Locals[8]);f.Pc=318;continue;}
case 318:{f.Push(f.Locals[15]);f.Pc=320;continue;}
case 320:{f.Push(f.Locals[1]);f.Pc=321;continue;}
case 321:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",324);}
case 324:{f.Locals[16]=f.Pop();f.Pc=326;continue;}
case 326:{f.Push(f.Locals[1]);f.Pc=327;continue;}
case 327:{f.Push(JValue.R(rt.String("ReduceAmount")));f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",333);}
case 333:{f.Pc=f.Pop().Int==0?367:336;continue;}
case 336:{f.Push(f.Locals[16]);f.Pc=338;continue;}
case 338:{f.Pc=f.Pop().Int<=0?367:341;continue;}
case 341:{f.Push(f.Locals[0]);f.Pc=342;continue;}
case 342:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=345;continue;}
case 345:{f.StackOp("dup");f.Pc=346;continue;}
case 346:{f.Push(f.Locals[14]);f.Pc=348;continue;}
case 348:{return rt.DynamicCall(f,"forge/game/cost/CostAdjustment:6227:348:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",353);}
case 353:{f.Push(f.Locals[16]);f.Pc=355;continue;}
case 355:{return rt.Call(f,"com/google/common/base/Strings","repeat","(Ljava/lang/String;I)Ljava/lang/String;","invokestatic",358);}
case 358:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(Ljava/lang/String;)V","invokespecial",361);}
case 361:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","subtractManaCost","(Lforge/card/mana/ManaCost;)V","invokevirtual",364);}
case 364:{f.Pc=374;continue;}
case 367:{f.Push(f.Locals[13]);f.Pc=369;continue;}
case 369:{f.Push(f.Locals[16]);f.Pc=371;continue;}
case 371:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=372;continue;}
case 372:{f.Locals[13]=f.Pop();f.Pc=374;continue;}
case 374:{f.Push(f.Locals[1]);f.Pc=375;continue;}
case 375:{return rt.Call(f,"forge/game/spellability/SpellAbility","isPowerUp","()Z","invokevirtual",378);}
case 378:{f.Pc=f.Pop().Int==0?398:381;continue;}
case 381:{f.Push(f.Locals[8]);f.Pc=383;continue;}
case 383:{return rt.Call(f,"forge/game/card/Card","enteredThisTurn","()Z","invokevirtual",386);}
case 386:{f.Pc=f.Pop().Int==0?398:389;continue;}
case 389:{f.Push(f.Locals[0]);f.Pc=390;continue;}
case 390:{f.Push(f.Locals[8]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",395);}
case 395:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","subtractManaCost","(Lforge/card/mana/ManaCost;)V","invokevirtual",398);}
case 398:{f.Push(f.Locals[11]);f.Pc=400;continue;}
case 400:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",405);}
case 405:{f.Pc=f.Pop().Int!=0?447:408;continue;}
case 408:{f.Push(f.Locals[6]);f.Pc=410;continue;}
case 410:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",413);}
case 413:{f.Push(f.Locals[11]);f.Pc=415;continue;}
case 415:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleStaticAbility","(Ljava/util/List;)Lforge/game/staticability/StaticAbility;","invokevirtual",418);}
case 418:{f.Locals[14]=f.Pop();f.Pc=420;continue;}
case 420:{f.Push(f.Locals[11]);f.Pc=422;continue;}
case 422:{f.Push(f.Locals[14]);f.Pc=424;continue;}
case 424:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",429);}
case 429:{f.StackOp("pop");f.Pc=430;continue;}
case 430:{f.Push(f.Locals[13]);f.Pc=432;continue;}
case 432:{f.Push(f.Locals[14]);f.Pc=434;continue;}
case 434:{f.Push(f.Locals[1]);f.Pc=435;continue;}
case 435:{f.Push(f.Locals[0]);f.Pc=436;continue;}
case 436:{f.Push(f.Locals[13]);f.Pc=438;continue;}
case 438:{return rt.Call(f,"forge/game/cost/CostAdjustment","applyReduceCostAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/spellability/SpellAbility;Lforge/game/mana/ManaCostBeingPaid;I)I","invokestatic",441);}
case 441:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=442;continue;}
case 442:{f.Locals[13]=f.Pop();f.Pc=444;continue;}
case 444:{f.Pc=398;continue;}
case 447:{f.Push(f.Locals[0]);f.Pc=448;continue;}
case 448:{f.Push(f.Locals[13]);f.Pc=450;continue;}
case 450:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","decreaseGenericMana","(I)V","invokevirtual",453);}
case 453:{f.Push(f.Locals[1]);f.Pc=454;continue;}
case 454:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",457);}
case 457:{f.Pc=f.Pop().Int==0?506:460;continue;}
case 460:{f.Push(f.Locals[1]);f.Pc=461;continue;}
case 461:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPipsToReduce","()Ljava/util/List;","invokevirtual",464);}
case 464:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",469);}
case 469:{f.Locals[14]=f.Pop();f.Pc=471;continue;}
case 471:{f.Push(f.Locals[14]);f.Pc=473;continue;}
case 473:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",478);}
case 478:{f.Pc=f.Pop().Int==0?506:481;continue;}
case 481:{f.Push(f.Locals[14]);f.Pc=483;continue;}
case 483:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",488);}
case 488:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=491;continue;}
case 491:{f.Locals[15]=f.Pop();f.Pc=493;continue;}
case 493:{f.Push(f.Locals[0]);f.Pc=494;continue;}
case 494:{f.Push(f.Locals[15]);f.Pc=496;continue;}
case 496:{return rt.Call(f,"forge/card/mana/ManaCostShard","parseNonGeneric","(Ljava/lang/String;)Lforge/card/mana/ManaCostShard;","invokestatic",499);}
case 499:{f.Push(JValue.I(1));f.Pc=500;continue;}
case 500:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","decreaseShard","(Lforge/card/mana/ManaCostShard;I)V","invokevirtual",503);}
case 503:{f.Pc=471;continue;}
case 506:{f.Push(f.Locals[1]);f.Pc=507;continue;}
case 507:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",510);}
case 510:{f.Pc=f.Pop().Int==0?525:513;continue;}
case 513:{f.Push(f.Locals[1]);f.Pc=514;continue;}
case 514:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOffering","()Z","invokevirtual",517);}
case 517:{f.Pc=f.Pop().Int==0?525:520;continue;}
case 520:{f.Push(f.Locals[0]);f.Pc=521;continue;}
case 521:{f.Push(f.Locals[1]);f.Pc=522;continue;}
case 522:{return rt.Call(f,"forge/game/cost/CostAdjustment","adjustCostByOffering","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;)V","invokestatic",525);}
case 525:{f.Push(f.Locals[1]);f.Pc=526;continue;}
case 526:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",529);}
case 529:{f.Pc=f.Pop().Int==0?567:532;continue;}
case 532:{f.Push(f.Locals[1]);f.Pc=533;continue;}
case 533:{return rt.Call(f,"forge/game/spellability/SpellAbility","isEmerge","()Z","invokevirtual",536);}
case 536:{f.Pc=f.Pop().Int==0?567:539;continue;}
case 539:{f.Push(f.Locals[1]);f.Pc=540;continue;}
case 540:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",543);}
case 543:{f.Locals[15]=f.Pop();f.Pc=545;continue;}
case 545:{f.Push(f.Locals[15]);f.Pc=547;continue;}
case 547:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/Emerge")?1:0));f.Pc=550;continue;}
case 550:{f.Pc=f.Pop().Int==0?567:553;continue;}
case 553:{f.Push(f.Locals[15]);f.Pc=555;continue;}
case 555:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/Emerge"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=558;continue;}
case 558:{f.Locals[14]=f.Pop();f.Pc=560;continue;}
case 560:{f.Push(f.Locals[0]);f.Pc=561;continue;}
case 561:{f.Push(f.Locals[1]);f.Pc=562;continue;}
case 562:{f.Push(f.Locals[14]);f.Pc=564;continue;}
case 564:{return rt.Call(f,"forge/game/cost/CostAdjustment","adjustCostByEmerge","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;Lforge/game/keyword/Emerge;)V","invokestatic",567);}
case 567:{f.Push(f.Locals[12]);f.Pc=569;continue;}
case 569:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",574);}
case 574:{f.Locals[14]=f.Pop();f.Pc=576;continue;}
case 576:{f.Push(f.Locals[14]);f.Pc=578;continue;}
case 578:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",583);}
case 583:{f.Pc=f.Pop().Int==0?608:586;continue;}
case 586:{f.Push(f.Locals[14]);f.Pc=588;continue;}
case 588:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",593);}
case 593:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=596;continue;}
case 596:{f.Locals[15]=f.Pop();f.Pc=598;continue;}
case 598:{f.Push(f.Locals[15]);f.Pc=600;continue;}
case 600:{f.Push(f.Locals[1]);f.Pc=601;continue;}
case 601:{f.Push(f.Locals[0]);f.Pc=602;continue;}
case 602:{return rt.Call(f,"forge/game/cost/CostAdjustment","applySetCostAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/spellability/SpellAbility;Lforge/game/mana/ManaCostBeingPaid;)V","invokestatic",605);}
case 605:{f.Pc=576;continue;}
case 608:{f.Push(f.Locals[1]);f.Pc=609;continue;}
case 609:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",612);}
case 612:{f.Pc=f.Pop().Int==0?879:615;continue;}
case 615:{f.Push(f.Locals[8]);f.Pc=617;continue;}
case 617:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","ASSIST","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","ASSIST","Lforge/game/keyword/Keyword;"));f.Pc=620;continue;}
case 620:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",623);}
case 623:{f.Pc=f.Pop().Int==0?638:626;continue;}
case 626:{f.Push(f.Locals[0]);f.Pc=627;continue;}
case 627:{f.Push(f.Locals[1]);f.Pc=628;continue;}
case 628:{f.Push(f.Locals[4]);f.Pc=630;continue;}
case 630:{return rt.Call(f,"forge/game/cost/CostAdjustment","adjustCostByAssist","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;Z)Z","invokestatic",633);}
case 633:{f.Pc=f.Pop().Int!=0?638:636;continue;}
case 636:{f.Push(JValue.I(0));f.Pc=637;continue;}
case 637:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 638:{f.Push(f.Locals[8]);f.Pc=640;continue;}
case 640:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","DELVE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","DELVE","Lforge/game/keyword/Keyword;"));f.Pc=643;continue;}
case 643:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",646);}
case 646:{f.Pc=f.Pop().Int==0?835:649;continue;}
case 649:{f.Push(f.Locals[8]);f.Pc=651;continue;}
case 651:{return rt.Call(f,"forge/game/card/Card","clearDelved","()V","invokevirtual",654);}
case 654:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=657;continue;}
case 657:{f.StackOp("dup");f.Pc=658;continue;}
case 658:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",661);}
case 661:{f.Locals[14]=f.Pop();f.Pc=663;continue;}
case 663:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=666;continue;}
case 666:{f.StackOp("dup");f.Pc=667;continue;}
case 667:{f.Push(f.Locals[6]);f.Pc=669;continue;}
case 669:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=672;continue;}
case 672:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",675);}
case 675:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",678);}
case 678:{f.Locals[15]=f.Pop();f.Pc=680;continue;}
case 680:{f.Push(f.Locals[6]);f.Pc=682;continue;}
case 682:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",685);}
case 685:{f.Push(f.Locals[0]);f.Pc=686;continue;}
case 686:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"));f.Pc=689;continue;}
case 689:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","getUnpaidShards","(Lforge/card/mana/ManaCostShard;)I","invokevirtual",692);}
case 692:{f.Push(f.Locals[15]);f.Pc=694;continue;}
case 694:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsToDelve","(ILforge/game/card/CardCollection;)Lforge/game/card/CardCollectionView;","invokevirtual",697);}
case 697:{f.Locals[16]=f.Pop();f.Pc=699;continue;}
case 699:{f.Push(f.Locals[16]);f.Pc=701;continue;}
case 701:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",706);}
case 706:{f.Locals[17]=f.Pop();f.Pc=708;continue;}
case 708:{f.Push(f.Locals[17]);f.Pc=710;continue;}
case 710:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",715);}
case 715:{f.Pc=f.Pop().Int==0?827:718;continue;}
case 718:{f.Push(f.Locals[17]);f.Pc=720;continue;}
case 720:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",725);}
case 725:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=728;continue;}
case 728:{f.Locals[18]=f.Pop();f.Pc=730;continue;}
case 730:{f.Push(f.Locals[0]);f.Pc=731;continue;}
case 731:{f.Push(JValue.I(1));f.Pc=732;continue;}
case 732:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","decreaseGenericMana","(I)V","invokevirtual",735);}
case 735:{f.Push(f.Locals[3]);f.Pc=736;continue;}
case 736:{f.Pc=f.Pop().Reference==null?749:739;continue;}
case 739:{f.Push(f.Locals[3]);f.Pc=740;continue;}
case 740:{f.Push(f.Locals[18]);f.Pc=742;continue;}
case 742:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",745);}
case 745:{f.StackOp("pop");f.Pc=746;continue;}
case 746:{f.Pc=824;continue;}
case 749:{f.Push(f.Locals[4]);f.Pc=751;continue;}
case 751:{f.Pc=f.Pop().Int!=0?824:754;continue;}
case 754:{f.Push(f.Locals[8]);f.Pc=756;continue;}
case 756:{f.Push(f.Locals[18]);f.Pc=758;continue;}
case 758:{return rt.Call(f,"forge/game/card/Card","addDelved","(Lforge/game/card/Card;)V","invokevirtual",761);}
case 761:{f.Push(f.Locals[7]);f.Pc=763;continue;}
case 763:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",766);}
case 766:{f.Push(f.Locals[18]);f.Pc=768;continue;}
case 768:{f.Push(JValue.R(null));f.Pc=769;continue;}
case 769:{f.Push(JValue.R(null));f.Pc=770;continue;}
case 770:{return rt.Call(f,"forge/game/GameAction","exile","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",773);}
case 773:{f.Locals[19]=f.Pop();f.Pc=775;continue;}
case 775:{f.Push(f.Locals[8]);f.Pc=777;continue;}
case 777:{f.Push(f.Locals[19]);f.Pc=779;continue;}
case 779:{return rt.Call(f,"forge/game/card/Card","addExiledCard","(Lforge/game/card/Card;)V","invokevirtual",782);}
case 782:{f.Push(f.Locals[19]);f.Pc=784;continue;}
case 784:{f.Push(f.Locals[8]);f.Pc=786;continue;}
case 786:{return rt.Call(f,"forge/game/card/Card","setExiledWith","(Lforge/game/card/Card;)V","invokevirtual",789);}
case 789:{f.Push(f.Locals[19]);f.Pc=791;continue;}
case 791:{f.Push(f.Locals[8]);f.Pc=793;continue;}
case 793:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",796);}
case 796:{return rt.Call(f,"forge/game/card/Card","setExiledBy","(Lforge/game/player/Player;)V","invokevirtual",799);}
case 799:{f.Push(f.Locals[19]);f.Pc=801;continue;}
case 801:{f.Push(f.Locals[1]);f.Pc=802;continue;}
case 802:{return rt.Call(f,"forge/game/card/Card","setExiledSA","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",805);}
case 805:{f.Push(f.Locals[14]);f.Pc=807;continue;}
case 807:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=810;continue;}
case 810:{f.Push(f.Locals[19]);f.Pc=812;continue;}
case 812:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",815);}
case 815:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",818);}
case 818:{f.Push(f.Locals[19]);f.Pc=820;continue;}
case 820:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",823);}
case 823:{f.StackOp("pop");f.Pc=824;continue;}
case 824:{f.Pc=708;continue;}
case 827:{f.Push(f.Locals[14]);f.Pc=829;continue;}
case 829:{f.Push(f.Locals[7]);f.Pc=831;continue;}
case 831:{f.Push(f.Locals[1]);f.Pc=832;continue;}
case 832:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",835);}
case 835:{f.Push(f.Locals[8]);f.Pc=837;continue;}
case 837:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","CONVOKE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","CONVOKE","Lforge/game/keyword/Keyword;"));f.Pc=840;continue;}
case 840:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",843);}
case 843:{f.Pc=f.Pop().Int==0?857:846;continue;}
case 846:{f.Push(f.Locals[0]);f.Pc=847;continue;}
case 847:{f.Push(f.Locals[1]);f.Pc=848;continue;}
case 848:{f.Push(f.Locals[6]);f.Pc=850;continue;}
case 850:{f.Push(JValue.I(0));f.Pc=851;continue;}
case 851:{f.Push(JValue.I(1));f.Pc=852;continue;}
case 852:{f.Push(f.Locals[4]);f.Pc=854;continue;}
case 854:{return rt.Call(f,"forge/game/cost/CostAdjustment","adjustCostByConvokeOrImprovise","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;ZZZ)V","invokestatic",857);}
case 857:{f.Push(f.Locals[8]);f.Pc=859;continue;}
case 859:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","IMPROVISE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","IMPROVISE","Lforge/game/keyword/Keyword;"));f.Pc=862;continue;}
case 862:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",865);}
case 865:{f.Pc=f.Pop().Int==0?879:868;continue;}
case 868:{f.Push(f.Locals[0]);f.Pc=869;continue;}
case 869:{f.Push(f.Locals[1]);f.Pc=870;continue;}
case 870:{f.Push(f.Locals[6]);f.Pc=872;continue;}
case 872:{f.Push(JValue.I(1));f.Pc=873;continue;}
case 873:{f.Push(JValue.I(0));f.Pc=874;continue;}
case 874:{f.Push(f.Locals[4]);f.Pc=876;continue;}
case 876:{return rt.Call(f,"forge/game/cost/CostAdjustment","adjustCostByConvokeOrImprovise","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;ZZZ)V","invokestatic",879);}
case 879:{f.Push(f.Locals[1]);f.Pc=880;continue;}
case 880:{f.Push(JValue.R(rt.String("TapCreaturesForMana")));f.Pc=883;continue;}
case 883:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",886);}
case 886:{f.Pc=f.Pop().Int==0?900:889;continue;}
case 889:{f.Push(f.Locals[0]);f.Pc=890;continue;}
case 890:{f.Push(f.Locals[1]);f.Pc=891;continue;}
case 891:{f.Push(f.Locals[6]);f.Pc=893;continue;}
case 893:{f.Push(JValue.I(0));f.Pc=894;continue;}
case 894:{f.Push(JValue.I(1));f.Pc=895;continue;}
case 895:{f.Push(f.Locals[4]);f.Pc=897;continue;}
case 897:{return rt.Call(f,"forge/game/cost/CostAdjustment","adjustCostByConvokeOrImprovise","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;ZZZ)V","invokestatic",900);}
case 900:{f.Push(f.Locals[0]);f.Pc=901;continue;}
case 901:{f.Push(f.Locals[1]);f.Pc=902;continue;}
case 902:{f.Push(f.Locals[2]);f.Pc=903;continue;}
case 903:{f.Push(f.Locals[4]);f.Pc=905;continue;}
case 905:{return rt.Call(f,"forge/game/cost/CostAdjustment","adjustCostByWaterbend","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)V","invokestatic",908);}
case 908:{f.Push(f.Locals[9]);f.Pc=910;continue;}
case 910:{f.Pc=f.Pop().Int==0?929:913;continue;}
case 913:{f.Push(f.Locals[8]);f.Pc=915;continue;}
case 915:{f.Push(JValue.I(0));f.Pc=916;continue;}
case 916:{return rt.Call(f,"forge/game/card/Card","setFaceDown","(Z)V","invokevirtual",919);}
case 919:{f.Push(f.Locals[8]);f.Pc=921;continue;}
case 921:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=924;continue;}
case 924:{f.Push(JValue.I(0));f.Pc=925;continue;}
case 925:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",928);}
case 928:{f.StackOp("pop");f.Pc=929;continue;}
case 929:{f.Push(JValue.I(1));f.Pc=930;continue;}
case 930:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6228(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","getUnpaidShards","(Lforge/card/mana/ManaCostShard;)I","invokevirtual",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Int!=0?14:12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",18);}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/player/Player","getAllOtherPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",25);}
case 25:{f.Locals[5]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",32);}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("Choose a player to assist paying this spell")));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/player/PlayerController","choosePlayerToAssistPayment","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;I)Lforge/game/player/Player;","invokevirtual",42);}
case 42:{f.Locals[6]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[6]);f.Pc=46;continue;}
case 46:{f.Pc=f.Pop().Reference!=null?51:49;continue;}
case 49:{f.Push(JValue.I(1));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{f.Locals[7]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[6]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",59);}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[7]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/player/PlayerController","helpPayForAssistSpell","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;II)Z","invokevirtual",67);}
case 67:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6229(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMaxWaterbend","()Ljava/lang/Integer;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[4]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference==null?28:11;continue;}
case 11:{f.Push(f.Locals[4]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int<=0?28:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(JValue.I(1));f.Pc=23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/cost/CostAdjustment","adjustCostByConvokeOrImprovise","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;ZZZ)V","invokestatic",28);}
case 28:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6230(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[4]);f.Pc=2;continue;}
case 2:{f.Pc=f.Pop().Int==0?13:5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Int!=0?13:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","clearTappedForConvoke","()V","invokevirtual",13);}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",20);}
case 20:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","CAN_TAP","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","CAN_TAP","Ljava/util/function/Predicate;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",26);}
case 26:{f.Locals[6]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(JValue.R(null));f.Pc=29;continue;}
case 29:{f.Locals[7]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{f.Pc=f.Pop().Int==0?65:35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{f.Pc=f.Pop().Int==0?65:40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMaxWaterbend","()Ljava/lang/Integer;","invokevirtual",44);}
case 44:{f.Locals[7]=f.Pop();f.Pc=46;continue;}
case 46:{return rt.DynamicCall(f,"forge/game/cost/CostAdjustment:6230:46:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",51);}
case 51:{f.Locals[8]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[6]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[8]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",60);}
case 60:{f.Locals[6]=f.Pop();f.Pc=62;continue;}
case 62:{f.Pc=92;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{f.Pc=f.Pop().Int==0?82:69;continue;}
case 69:{f.Push(f.Locals[6]);f.Pc=71;continue;}
case 71:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","ARTIFACTS","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","ARTIFACTS","Ljava/util/function/Predicate;"));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",77);}
case 77:{f.Locals[6]=f.Pop();f.Pc=79;continue;}
case 79:{f.Pc=92;continue;}
case 82:{f.Push(f.Locals[6]);f.Pc=84;continue;}
case 84:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","CREATURES","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","CREATURES","Ljava/util/function/Predicate;"));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",90);}
case 90:{f.Locals[6]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[6]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",99);}
case 99:{f.Pc=f.Pop().Int==0?103:102;continue;}
case 102:{return JStep.ReturnVoid;}
case 103:{f.Push(f.Locals[2]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",107);}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","toManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",112);}
case 112:{f.Push(f.Locals[6]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[3]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[4]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[7]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForConvokeOrImprovise","(Lforge/game/spellability/SpellAbility;Lforge/card/mana/ManaCost;Lforge/game/card/CardCollectionView;ZZLjava/lang/Integer;)Ljava/util/Map;","invokevirtual",122);}
case 122:{f.Locals[8]=f.Pop();f.Pc=124;continue;}
case 124:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=127;continue;}
case 127:{f.StackOp("dup");f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",131);}
case 131:{f.Locals[9]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(f.Locals[8]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",140);}
case 140:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",145);}
case 145:{f.Locals[10]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(f.Locals[10]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",154);}
case 154:{f.Pc=f.Pop().Int==0?237:157;continue;}
case 157:{f.Push(f.Locals[10]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",164);}
case 164:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=167;continue;}
case 167:{f.Locals[11]=f.Pop();f.Pc=169;continue;}
case 169:{f.Push(f.Locals[11]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",176);}
case 176:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=179;continue;}
case 179:{f.Locals[12]=f.Pop();f.Pc=181;continue;}
case 181:{f.Push(f.Locals[4]);f.Pc=183;continue;}
case 183:{f.Pc=f.Pop().Int==0?196:186;continue;}
case 186:{f.Push(f.Locals[3]);f.Pc=187;continue;}
case 187:{f.Pc=f.Pop().Int!=0?196:190;continue;}
case 190:{f.Push(f.Locals[1]);f.Pc=191;continue;}
case 191:{f.Push(f.Locals[12]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/spellability/SpellAbility","addTappedForConvoke","(Lforge/game/card/Card;)V","invokevirtual",196);}
case 196:{f.Push(f.Locals[0]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[11]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",204);}
case 204:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=207;continue;}
case 207:{f.Push(JValue.I(1));f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","decreaseShard","(Lforge/card/mana/ManaCostShard;I)V","invokevirtual",211);}
case 211:{f.Push(f.Locals[5]);f.Pc=213;continue;}
case 213:{f.Pc=f.Pop().Int!=0?234:216;continue;}
case 216:{f.Push(f.Locals[12]);f.Pc=218;continue;}
case 218:{f.Push(f.Locals[1]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[2]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/card/Card","tap","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Z","invokevirtual",223);}
case 223:{f.Pc=f.Pop().Int==0?234:226;continue;}
case 226:{f.Push(f.Locals[9]);f.Pc=228;continue;}
case 228:{f.Push(f.Locals[12]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",233);}
case 233:{f.StackOp("pop");f.Pc=234;continue;}
case 234:{f.Pc=147;continue;}
case 237:{f.Push(f.Locals[9]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",242);}
case 242:{f.Pc=f.Pop().Int!=0?279:245;continue;}
case 245:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",248);}
case 248:{f.Locals[10]=f.Pop();f.Pc=250;continue;}
case 250:{f.Push(f.Locals[10]);f.Pc=252;continue;}
case 252:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=255;continue;}
case 255:{f.Push(f.Locals[9]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",262);}
case 262:{f.StackOp("pop");f.Pc=263;continue;}
case 263:{f.Push(f.Locals[2]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",267);}
case 267:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",270);}
case 270:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","TapAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","TapAll","Lforge/game/trigger/TriggerType;"));f.Pc=273;continue;}
case 273:{f.Push(f.Locals[10]);f.Pc=275;continue;}
case 275:{f.Push(JValue.I(0));f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",279);}
case 279:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6231(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("")));f.Pc=3;continue;}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",8);}
case 8:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","OFFERING","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","OFFERING","Lforge/game/keyword/Keyword;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getKeywords","(Lforge/game/keyword/Keyword;)Ljava/util/Collection;","invokevirtual",14);}
case 14:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",19);}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?63:29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",47);}
case 47:{f.Locals[5]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String(":")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",57);}
case 57:{f.Push(JValue.I(1));f.Pc=58;continue;}
case 58:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=59;continue;}
case 59:{f.Locals[2]=f.Pop();f.Pc=60;continue;}
case 60:{f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",67);}
case 67:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",73);}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/card/CardPredicates","isType","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",77);}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{f.Push(JValue.I(0));f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/card/CardPredicates","canBeSacrificedBy","(Lforge/game/spellability/SpellAbility;Z)Ljava/util/function/Predicate;","invokestatic",82);}
case 82:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",85);}
case 85:{f.Locals[3]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",90);}
case 90:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",93);}
case 93:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",96);}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{f.Push(JValue.I(0));f.Pc=98;continue;}
case 98:{f.Push(JValue.I(1));f.Pc=99;continue;}
case 99:{f.Push(f.Locals[3]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/player/PlayerController","choosePermanentsToSacrifice","(Lforge/game/spellability/SpellAbility;IILforge/game/card/CardCollectionView;Ljava/lang/String;)Lforge/game/card/CardCollectionView;","invokevirtual",104);}
case 104:{f.Locals[4]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(f.Locals[4]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",113);}
case 113:{f.Pc=f.Pop().Int==0?117:116;continue;}
case 116:{return JStep.ReturnVoid;}
case 117:{f.Push(f.Locals[4]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/card/CardCollectionView","getFirst","()Ljava/lang/Object;","invokeinterface",124);}
case 124:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=127;continue;}
case 127:{f.Locals[5]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[5]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",135);}
case 135:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","subtractManaCost","(Lforge/card/mana/ManaCost;)V","invokevirtual",138);}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[5]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSacrificedAsOffering","(Lforge/game/card/Card;)V","invokevirtual",144);}
case 144:{f.Push(f.Locals[5]);f.Pc=146;continue;}
case 146:{f.Push(JValue.I(1));f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/card/Card","setUsedToPay","(Z)V","invokevirtual",150);}
case 150:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6232(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/Emerge","getValidType","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[4]);f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",19);}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",26);}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/CardPredicates","restriction","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",30);}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/CardPredicates","canBeSacrificedBy","(Lforge/game/spellability/SpellAbility;Z)Ljava/util/function/Predicate;","invokestatic",35);}
case 35:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",38);}
case 38:{f.Locals[5]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",45);}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{f.Push(JValue.I(1));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[5]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/player/PlayerController","choosePermanentsToSacrifice","(Lforge/game/spellability/SpellAbility;IILforge/game/card/CardCollectionView;Ljava/lang/String;)Lforge/game/card/CardCollectionView;","invokevirtual",54);}
case 54:{f.Locals[6]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[6]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",63);}
case 63:{f.Pc=f.Pop().Int==0?67:66;continue;}
case 66:{return JStep.ReturnVoid;}
case 67:{f.Push(f.Locals[6]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/card/CardCollectionView","getFirst","()Ljava/lang/Object;","invokeinterface",74);}
case 74:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=77;continue;}
case 77:{f.Locals[7]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[7]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",85);}
case 85:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","decreaseGenericMana","(I)V","invokevirtual",88);}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[7]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSacrificedAsEmerge","(Lforge/game/card/Card;)V","invokevirtual",94);}
case 94:{f.Push(f.Locals[7]);f.Pc=96;continue;}
case 96:{f.Push(JValue.I(1));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/card/Card","setUsedToPay","(Z)V","invokevirtual",100);}
case 100:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6233(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Amount")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/cost/CostAdjustment","checkRequirement","(Lforge/game/spellability/SpellAbility;Lforge/game/staticability/StaticAbility;)Z","invokestatic",13);}
case 13:{f.Pc=f.Pop().Int!=0?17:16;continue;}
case 16:{return JStep.ReturnVoid;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",21);}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("RaiseTo")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?46:33;continue;}
case 33:{f.Push(f.Locals[4]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","getConvertedManaCost","()I","invokevirtual",39);}
case 39:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=40;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",44);}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","increaseGenericMana","(I)V","invokevirtual",52);}
case 52:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6234(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","toString","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.String("{0}")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?15:13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",25);}
case 25:{f.Locals[5]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("Amount")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Locals[6]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("AffectedX")));f.Pc=39;continue;}
case 39:{f.Push(f.Locals[6]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int==0?60:47;continue;}
case 47:{f.Push(f.Locals[5]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[6]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",55);}
case 55:{f.Locals[7]=f.Pop();f.Pc=57;continue;}
case 57:{f.Pc=138;continue;}
case 60:{f.Push(JValue.R(rt.String("Undaunted")));f.Pc=63;continue;}
case 63:{f.Push(f.Locals[6]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",68);}
case 68:{f.Pc=f.Pop().Int==0?87:71;continue;}
case 71:{f.Push(f.Locals[5]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",76);}
case 76:{return rt.Call(f,"forge/game/player/Player","getOpponents","()Lforge/game/player/PlayerCollection;","invokevirtual",79);}
case 79:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",82);}
case 82:{f.Locals[7]=f.Pop();f.Pc=84;continue;}
case 84:{f.Pc=138;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String("Relative")));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int==0?128:97;continue;}
case 97:{f.Push(f.Locals[4]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[6]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasSVar","(Ljava/lang/String;)Z","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Int==0?117:108;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[6]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/staticability/StaticAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",114);}
case 114:{f.Pc=119;continue;}
case 117:{f.Push(f.Locals[6]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",123);}
case 123:{f.Locals[7]=f.Pop();f.Pc=125;continue;}
case 125:{f.Pc=138;continue;}
case 128:{f.Push(f.Locals[4]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[6]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",136);}
case 136:{f.Locals[7]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{f.Push(JValue.R(rt.String("UpTo")));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",145);}
case 145:{f.Pc=f.Pop().Int==0?164:148;continue;}
case 148:{f.Push(f.Locals[1]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",152);}
case 152:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",155);}
case 155:{f.Push(f.Locals[1]);f.Pc=156;continue;}
case 156:{f.Push(JValue.I(0));f.Pc=157;continue;}
case 157:{f.Push(f.Locals[7]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumberForCostReduction","(Lforge/game/spellability/SpellAbility;II)I","invokevirtual",162);}
case 162:{f.Locals[7]=f.Pop();f.Pc=164;continue;}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String("Color")));f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",171);}
case 171:{f.Pc=f.Pop().Int==0?298:174;continue;}
case 174:{f.Push(f.Locals[0]);f.Pc=175;continue;}
case 175:{f.Push(JValue.R(rt.String("Color")));f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",181);}
case 181:{f.Locals[8]=f.Pop();f.Pc=183;continue;}
case 183:{f.Push(JValue.I(0));f.Pc=184;continue;}
case 184:{f.Locals[9]=f.Pop();f.Pc=186;continue;}
case 186:{f.Push(f.Locals[8]);f.Pc=188;continue;}
case 188:{f.Push(JValue.R(rt.String(" ")));f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",194);}
case 194:{f.Locals[10]=f.Pop();f.Pc=196;continue;}
case 196:{f.Push(f.Locals[10]);f.Pc=198;continue;}
case 198:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=199;continue;}
case 199:{f.Locals[11]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(JValue.I(0));f.Pc=202;continue;}
case 202:{f.Locals[12]=f.Pop();f.Pc=204;continue;}
case 204:{f.Push(f.Locals[12]);f.Pc=206;continue;}
case 206:{f.Push(f.Locals[11]);f.Pc=208;continue;}
case 208:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?295:211;continue;}
case 211:{f.Push(f.Locals[10]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[12]);f.Pc=215;continue;}
case 215:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=216;continue;}
case 216:{f.Locals[13]=f.Pop();f.Pc=218;continue;}
case 218:{f.Push(f.Locals[13]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",223);}
case 223:{f.Pc=f.Pop().Int==0?242:226;continue;}
case 226:{f.Push(f.Locals[9]);f.Pc=228;continue;}
case 228:{f.Push(f.Locals[13]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",233);}
case 233:{f.Push(f.Locals[7]);f.Pc=235;continue;}
case 235:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=236;continue;}
case 236:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=237;continue;}
case 237:{f.Locals[9]=f.Pop();f.Pc=239;continue;}
case 239:{f.Pc=289;continue;}
case 242:{f.Push(f.Locals[0]);f.Pc=243;continue;}
case 243:{f.Push(JValue.R(rt.String("IgnoreGeneric")));f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",249);}
case 249:{f.Pc=f.Pop().Int==0?266:252;continue;}
case 252:{f.Push(f.Locals[2]);f.Pc=253;continue;}
case 253:{f.Push(f.Locals[13]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/card/mana/ManaCostShard","parseNonGeneric","(Ljava/lang/String;)Lforge/card/mana/ManaCostShard;","invokestatic",258);}
case 258:{f.Push(f.Locals[7]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","decreaseShard","(Lforge/card/mana/ManaCostShard;I)V","invokevirtual",263);}
case 263:{f.Pc=289;continue;}
case 266:{f.Push(f.Locals[2]);f.Pc=267;continue;}
case 267:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=270;continue;}
case 270:{f.StackOp("dup");f.Pc=271;continue;}
case 271:{f.Push(f.Locals[13]);f.Pc=273;continue;}
case 273:{return rt.DynamicCall(f,"forge/game/cost/CostAdjustment:6234:273:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",278);}
case 278:{f.Push(f.Locals[7]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"com/google/common/base/Strings","repeat","(Ljava/lang/String;I)Ljava/lang/String;","invokestatic",283);}
case 283:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(Ljava/lang/String;)V","invokespecial",286);}
case 286:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","subtractManaCost","(Lforge/card/mana/ManaCost;)V","invokevirtual",289);}
case 289:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=292;continue;}
case 292:{f.Pc=204;continue;}
case 295:{f.Push(f.Locals[9]);f.Pc=297;continue;}
case 297:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 298:{f.Push(JValue.I(0));f.Pc=299;continue;}
case 299:{f.Locals[8]=f.Pop();f.Pc=301;continue;}
case 301:{f.Push(f.Locals[0]);f.Pc=302;continue;}
case 302:{f.Push(JValue.R(rt.String("MinMana")));f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",308);}
case 308:{f.Pc=f.Pop().Int==0?323:311;continue;}
case 311:{f.Push(f.Locals[0]);f.Pc=312;continue;}
case 312:{f.Push(JValue.R(rt.String("MinMana")));f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",318);}
case 318:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",321);}
case 321:{f.Locals[8]=f.Pop();f.Pc=323;continue;}
case 323:{f.Push(f.Locals[2]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","getConvertedManaCost","()I","invokevirtual",327);}
case 327:{f.Push(f.Locals[8]);f.Pc=329;continue;}
case 329:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=330;continue;}
case 330:{f.Push(f.Locals[3]);f.Pc=331;continue;}
case 331:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=332;continue;}
case 332:{f.Locals[9]=f.Pop();f.Pc=334;continue;}
case 334:{f.Push(f.Locals[9]);f.Pc=336;continue;}
case 336:{f.Pc=f.Pop().Int<=0?347:339;continue;}
case 339:{f.Push(f.Locals[7]);f.Pc=341;continue;}
case 341:{f.Push(f.Locals[9]);f.Pc=343;continue;}
case 343:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",346);}
case 346:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 347:{f.Push(JValue.I(0));f.Pc=348;continue;}
case 348:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6235(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",13);}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",18);}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",23);}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",29);}
case 29:{f.Locals[5]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",35);}
case 35:{f.Locals[6]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[5]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int!=0?51:49;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("ValidSpell")));f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int!=0?64:62;continue;}
case 62:{f.Push(JValue.I(0));f.Pc=63;continue;}
case 63:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("Activator")));f.Pc=68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int!=0?78:76;continue;}
case 76:{f.Push(JValue.I(0));f.Pc=77;continue;}
case 77:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("Type")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",85);}
case 85:{f.Pc=f.Pop().Int==0?382:88;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{f.Push(JValue.R(rt.String("Type")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",95);}
case 95:{f.Locals[7]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(JValue.I(-1));f.Pc=98;continue;}
case 98:{f.Locals[8]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[7]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",105);}
case 105:{switch(f.Pop().Int){case 80089352:f.Pc=140;break;case 464145674:f.Pc=157;break;case 531887757:f.Pc=174;break;default:f.Pc=188;break;}continue;}
case 140:{f.Push(f.Locals[7]);f.Pc=142;continue;}
case 142:{f.Push(JValue.R(rt.String("Spell")));f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",148);}
case 148:{f.Pc=f.Pop().Int==0?188:151;continue;}
case 151:{f.Push(JValue.I(0));f.Pc=152;continue;}
case 152:{f.Locals[8]=f.Pop();f.Pc=154;continue;}
case 154:{f.Pc=188;continue;}
case 157:{f.Push(f.Locals[7]);f.Pc=159;continue;}
case 159:{f.Push(JValue.R(rt.String("Ability")));f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",165);}
case 165:{f.Pc=f.Pop().Int==0?188:168;continue;}
case 168:{f.Push(JValue.I(1));f.Pc=169;continue;}
case 169:{f.Locals[8]=f.Pop();f.Pc=171;continue;}
case 171:{f.Pc=188;continue;}
case 174:{f.Push(f.Locals[7]);f.Pc=176;continue;}
case 176:{f.Push(JValue.R(rt.String("Foretell")));f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",182);}
case 182:{f.Pc=f.Pop().Int==0?188:185;continue;}
case 185:{f.Push(JValue.I(2));f.Pc=186;continue;}
case 186:{f.Locals[8]=f.Pop();f.Pc=188;continue;}
case 188:{f.Push(f.Locals[8]);f.Pc=190;continue;}
case 190:{switch(f.Pop().Int){case 0:f.Pc=216;break;case 1:f.Pc=337;break;case 2:f.Pc=353;break;default:f.Pc=382;break;}continue;}
case 216:{f.Push(f.Locals[0]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",220);}
case 220:{f.Pc=f.Pop().Int!=0?225:223;continue;}
case 223:{f.Push(JValue.I(0));f.Pc=224;continue;}
case 224:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 225:{f.Push(f.Locals[1]);f.Pc=226;continue;}
case 226:{f.Push(JValue.R(rt.String("OnlyFirstSpell")));f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",232);}
case 232:{f.Pc=f.Pop().Int==0?382:235;continue;}
case 235:{f.Push(f.Locals[4]);f.Pc=237;continue;}
case 237:{f.Pc=f.Pop().Reference!=null?242:240;continue;}
case 240:{f.Push(JValue.I(0));f.Pc=241;continue;}
case 241:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 242:{f.Push(f.Locals[1]);f.Pc=243;continue;}
case 243:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",249);}
case 249:{f.Pc=f.Pop().Int==0?270:252;continue;}
case 252:{f.Push(f.Locals[1]);f.Pc=253;continue;}
case 253:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=256;continue;}
case 256:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",259);}
case 259:{f.Push(f.Locals[2]);f.Pc=260;continue;}
case 260:{f.Push(f.Locals[1]);f.Pc=261;continue;}
case 261:{f.Push(f.Locals[3]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/card/CardUtil","getThisTurnCast","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;Lforge/game/player/Player;)Ljava/util/List;","invokestatic",265);}
case 265:{f.Locals[9]=f.Pop();f.Pc=267;continue;}
case 267:{f.Pc=280;continue;}
case 270:{f.Push(f.Locals[6]);f.Pc=272;continue;}
case 272:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",275);}
case 275:{return rt.Call(f,"forge/game/zone/MagicStack","getSpellCardsCastThisTurn","()Ljava/util/List;","invokevirtual",278);}
case 278:{f.Locals[9]=f.Pop();f.Pc=280;continue;}
case 280:{f.Push(f.Locals[1]);f.Pc=281;continue;}
case 281:{f.Push(JValue.R(rt.String("ValidSpell")));f.Pc=284;continue;}
case 284:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",287);}
case 287:{f.Pc=f.Pop().Int==0?319:290;continue;}
case 290:{f.Push(f.Locals[9]);f.Pc=292;continue;}
case 292:{f.Push(f.Locals[1]);f.Pc=293;continue;}
case 293:{f.Push(JValue.R(rt.String("ValidSpell")));f.Pc=296;continue;}
case 296:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",299);}
case 299:{f.Push(JValue.R(rt.String(",")));f.Pc=302;continue;}
case 302:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",305);}
case 305:{f.Push(f.Locals[3]);f.Pc=306;continue;}
case 306:{f.Push(f.Locals[2]);f.Pc=307;continue;}
case 307:{f.Push(f.Locals[1]);f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/game/spellability/SpellAbilityPredicates","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",311);}
case 311:{return rt.Call(f,"forge/game/card/CardPredicates","castSA","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",314);}
case 314:{return rt.Call(f,"forge/game/card/CardLists","filterAsList","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/util/List;","invokestatic",317);}
case 317:{f.Locals[9]=f.Pop();f.Pc=319;continue;}
case 319:{f.Push(f.Locals[9]);f.Pc=321;continue;}
case 321:{f.Push(f.Locals[4]);f.Pc=323;continue;}
case 323:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollection;","invokestatic",326);}
case 326:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",329);}
case 329:{f.Pc=f.Pop().Int!=0?334:332;continue;}
case 332:{f.Push(JValue.I(0));f.Pc=333;continue;}
case 333:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 334:{f.Pc=382;continue;}
case 337:{f.Push(f.Locals[0]);f.Pc=338;continue;}
case 338:{return rt.Call(f,"forge/game/spellability/SpellAbility","isActivatedAbility","()Z","invokevirtual",341);}
case 341:{f.Pc=f.Pop().Int==0?351:344;continue;}
case 344:{f.Push(f.Locals[0]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"forge/game/spellability/SpellAbility","isReplacementAbility","()Z","invokevirtual",348);}
case 348:{f.Pc=f.Pop().Int==0?382:351;continue;}
case 351:{f.Push(JValue.I(0));f.Pc=352;continue;}
case 352:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 353:{f.Push(f.Locals[0]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/game/spellability/SpellAbility","isForetelling","()Z","invokevirtual",357);}
case 357:{f.Pc=f.Pop().Int!=0?362:360;continue;}
case 360:{f.Push(JValue.I(0));f.Pc=361;continue;}
case 361:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 362:{f.Push(f.Locals[1]);f.Pc=363;continue;}
case 363:{f.Push(JValue.R(rt.String("FirstForetell")));f.Pc=366;continue;}
case 366:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",369);}
case 369:{f.Pc=f.Pop().Int==0?382:372;continue;}
case 372:{f.Push(f.Locals[4]);f.Pc=374;continue;}
case 374:{return rt.Call(f,"forge/game/player/Player","getNumForetoldThisTurn","()I","invokevirtual",377);}
case 377:{f.Pc=f.Pop().Int<=0?382:380;continue;}
case 380:{f.Push(JValue.I(0));f.Pc=381;continue;}
case 381:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 382:{f.Push(f.Locals[1]);f.Pc=383;continue;}
case 383:{f.Push(JValue.R(rt.String("AffectedZone")));f.Pc=386;continue;}
case 386:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",389);}
case 389:{f.Pc=f.Pop().Int==0?468:392;continue;}
case 392:{f.Push(f.Locals[1]);f.Pc=393;continue;}
case 393:{f.Push(JValue.R(rt.String("AffectedZone")));f.Pc=396;continue;}
case 396:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",399);}
case 399:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",402);}
case 402:{f.Locals[7]=f.Pop();f.Pc=404;continue;}
case 404:{f.Push(f.Locals[0]);f.Pc=405;continue;}
case 405:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",408);}
case 408:{f.Pc=f.Pop().Int==0?439:411;continue;}
case 411:{f.Push(f.Locals[5]);f.Pc=413;continue;}
case 413:{return rt.Call(f,"forge/game/card/Card","wasCast","()Z","invokevirtual",416);}
case 416:{f.Pc=f.Pop().Int==0?439:419;continue;}
case 419:{f.Push(f.Locals[7]);f.Pc=421;continue;}
case 421:{f.Push(f.Locals[5]);f.Pc=423;continue;}
case 423:{return rt.Call(f,"forge/game/card/Card","getCastFrom","()Lforge/game/zone/Zone;","invokevirtual",426);}
case 426:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",429);}
case 429:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",434);}
case 434:{f.Pc=f.Pop().Int!=0?468:437;continue;}
case 437:{f.Push(JValue.I(0));f.Pc=438;continue;}
case 438:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 439:{f.Push(f.Locals[5]);f.Pc=441;continue;}
case 441:{return rt.Call(f,"forge/game/card/Card","getLastKnownZone","()Lforge/game/zone/Zone;","invokevirtual",444);}
case 444:{f.Locals[8]=f.Pop();f.Pc=446;continue;}
case 446:{f.Push(f.Locals[8]);f.Pc=448;continue;}
case 448:{f.Pc=f.Pop().Reference==null?466:451;continue;}
case 451:{f.Push(f.Locals[7]);f.Pc=453;continue;}
case 453:{f.Push(f.Locals[8]);f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",458);}
case 458:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",463);}
case 463:{f.Pc=f.Pop().Int!=0?468:466;continue;}
case 466:{f.Push(JValue.I(0));f.Pc=467;continue;}
case 467:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 468:{f.Push(f.Locals[1]);f.Pc=469;continue;}
case 469:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=472;continue;}
case 472:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",475);}
case 475:{f.Pc=f.Pop().Int==0?609:478;continue;}
case 478:{f.Push(f.Locals[0]);f.Pc=479;continue;}
case 479:{f.Locals[7]=f.Pop();f.Pc=481;continue;}
case 481:{f.Push(JValue.I(0));f.Pc=482;continue;}
case 482:{f.Locals[8]=f.Pop();f.Pc=484;continue;}
case 484:{f.Push(f.Locals[7]);f.Pc=486;continue;}
case 486:{f.Pc=f.Pop().Reference==null?585:489;continue;}
case 489:{f.Push(f.Locals[7]);f.Pc=491;continue;}
case 491:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",494);}
case 494:{f.Pc=f.Pop().Int!=0?507:497;continue;}
case 497:{f.Push(f.Locals[7]);f.Pc=499;continue;}
case 499:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",502);}
case 502:{f.Locals[7]=f.Pop();f.Pc=504;continue;}
case 504:{f.Pc=484;continue;}
case 507:{f.Push(f.Locals[7]);f.Pc=509;continue;}
case 509:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",512);}
case 512:{return rt.Call(f,"forge/game/spellability/TargetChoices","iterator","()Ljava/util/Iterator;","invokevirtual",515);}
case 515:{f.Locals[9]=f.Pop();f.Pc=517;continue;}
case 517:{f.Push(f.Locals[9]);f.Pc=519;continue;}
case 519:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",524);}
case 524:{f.Pc=f.Pop().Int==0?575:527;continue;}
case 527:{f.Push(f.Locals[9]);f.Pc=529;continue;}
case 529:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",534);}
case 534:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=537;continue;}
case 537:{f.Locals[10]=f.Pop();f.Pc=539;continue;}
case 539:{f.Push(f.Locals[10]);f.Pc=541;continue;}
case 541:{f.Push(f.Locals[1]);f.Pc=542;continue;}
case 542:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=545;continue;}
case 545:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",548);}
case 548:{f.Push(JValue.R(rt.String(",")));f.Pc=551;continue;}
case 551:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",554);}
case 554:{f.Push(f.Locals[3]);f.Pc=555;continue;}
case 555:{f.Push(f.Locals[2]);f.Pc=556;continue;}
case 556:{f.Push(f.Locals[7]);f.Pc=558;continue;}
case 558:{return rt.Call(f,"forge/game/GameObject","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokeinterface",563);}
case 563:{f.Pc=f.Pop().Int==0?572:566;continue;}
case 566:{f.Push(JValue.I(1));f.Pc=567;continue;}
case 567:{f.Locals[8]=f.Pop();f.Pc=569;continue;}
case 569:{f.Pc=585;continue;}
case 572:{f.Pc=517;continue;}
case 575:{f.Push(f.Locals[7]);f.Pc=577;continue;}
case 577:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",580);}
case 580:{f.Locals[7]=f.Pop();f.Pc=582;continue;}
case 582:{f.Pc=484;continue;}
case 585:{f.Push(f.Locals[1]);f.Pc=586;continue;}
case 586:{f.Push(JValue.R(rt.String("UnlessValidTarget")));f.Pc=589;continue;}
case 589:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",592);}
case 592:{f.Pc=f.Pop().Int==0?602:595;continue;}
case 595:{f.Push(f.Locals[8]);f.Pc=597;continue;}
case 597:{f.Pc=f.Pop().Int==0?609:600;continue;}
case 600:{f.Push(JValue.I(0));f.Pc=601;continue;}
case 601:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 602:{f.Push(f.Locals[8]);f.Pc=604;continue;}
case 604:{f.Pc=f.Pop().Int!=0?609:607;continue;}
case 607:{f.Push(JValue.I(0));f.Pc=608;continue;}
case 608:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 609:{f.Push(JValue.I(1));f.Pc=610;continue;}
case 610:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6236(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isArtifact","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?14:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

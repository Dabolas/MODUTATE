// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C448{
internal static JClass Build(){var c=new JClass("forge/game/card/CardCopyService","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("copyFrom","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("toGame","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JMethod(4921,"forge/game/card/CardCopyService","<init>","(Lforge/game/card/Card;)V",1,2,3,new JHandler[]{},M4921));
c.Add(new JMethod(4922,"forge/game/card/CardCopyService","<init>","(Lforge/game/card/Card;Lforge/game/Game;)V",1,3,2,new JHandler[]{},M4922));
c.Add(new JMethod(4923,"forge/game/card/CardCopyService","copyCard","(Z)Lforge/game/card/Card;",17,2,3,new JHandler[]{},M4923));
c.Add(new JMethod(4924,"forge/game/card/CardCopyService","copyCard","(ZLforge/game/player/Player;)Lforge/game/card/Card;",17,5,4,new JHandler[]{},M4924));
c.Add(new JMethod(4925,"forge/game/card/CardCopyService","copyState","(Lforge/game/card/Card;Lforge/card/CardStateName;Lforge/game/card/Card;Lforge/card/CardStateName;)V",10,4,5,new JHandler[]{},M4925));
c.Add(new JMethod(4926,"forge/game/card/CardCopyService","copyState","(Lforge/game/card/Card;Lforge/card/CardStateName;Lforge/game/card/Card;Lforge/card/CardStateName;Z)V",10,7,3,new JHandler[]{},M4926));
c.Add(new JMethod(4927,"forge/game/card/CardCopyService","copyStats","(Lforge/game/card/Card;Lforge/game/player/Player;Z)Lforge/game/card/Card;",9,7,5,new JHandler[]{},M4927));
c.Add(new JMethod(4928,"forge/game/card/CardCopyService","copyCopiableCharacteristics","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;)V",1,7,4,new JHandler[]{},M4928));
c.Add(new JMethod(4929,"forge/game/card/CardCopyService","getLKICopyList","(Ljava/lang/Iterable;Ljava/util/Map;)Ljava/util/List;",9,5,4,new JHandler[]{},M4929));
c.Add(new JMethod(4930,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;",9,1,3,new JHandler[]{},M4930));
c.Add(new JMethod(4931,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;Ljava/util/Map;)Lforge/game/card/Card;",9,2,3,new JHandler[]{},M4931));
c.Add(new JMethod(4932,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/GameEntity;Ljava/util/Map;)Lforge/game/GameEntity;",9,2,3,new JHandler[]{},M4932));
c.Add(new JMethod(4933,"forge/game/card/CardCopyService","getLKICopy","()Lforge/game/card/Card;",1,1,2,new JHandler[]{},M4933));
c.Add(new JMethod(4934,"forge/game/card/CardCopyService","copyAbilityText","(Lforge/game/card/CardView;Lforge/game/card/CardView;)V",10,2,3,new JHandler[]{},M4934));
c.Add(new JMethod(4935,"forge/game/card/CardCopyService","getLKICopy","(Ljava/util/Map;)Lforge/game/card/Card;",1,8,7,new JHandler[]{},M4935));
}

internal static JStep M4921(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Reference!=null?10:6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{f.Pc=14;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/card/CardCopyService","<init>","(Lforge/game/card/Card;Lforge/game/Game;)V","invokespecial",17);}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4922(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardCopyService","toGame","Lforge/game/Game;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4923(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/game/card/CardCopyService","copyCard","(ZLforge/game/player/Player;)Lforge/game/card/Card;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4924(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","isRealToken","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?30:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/Card","getCopiedPermanent","()Lforge/game/card/Card;","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Reference!=null?30:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Reference!=null?95:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/CardCopyService","copyStats","(Lforge/game/card/Card;Lforge/game/player/Player;Z)Lforge/game/card/Card;","invokestatic",39);}
case 39:{f.Locals[3]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/Card","getEffectSource","()Lforge/game/card/Card;","invokevirtual",48);}
case 48:{return rt.Call(f,"forge/game/card/Card","setEffectSource","(Lforge/game/card/Card;)V","invokevirtual",51);}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/card/Card","isBoon","()Z","invokevirtual",59);}
case 59:{return rt.Call(f,"forge/game/card/Card","setBoon","(Z)V","invokevirtual",62);}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","toGame","Lforge/game/Game;"));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/card/Card","dangerouslySetGame","(Lforge/game/Game;)V","invokevirtual",70);}
case 70:{f.Push(f.Locals[3]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/card/Card","getTokenSpawningAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",78);}
case 78:{return rt.Call(f,"forge/game/card/Card","setTokenSpawningAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",81);}
case 81:{f.Push(f.Locals[3]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/card/Card","getCopiedPermanent","()Lforge/game/card/Card;","invokevirtual",89);}
case 89:{return rt.Call(f,"forge/game/card/Card","setCopiedPermanent","(Lforge/game/card/Card;)V","invokevirtual",92);}
case 92:{f.Pc=140;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{f.Pc=f.Pop().Int==0?117:99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",106);}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","toGame","Lforge/game/Game;"));f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/card/CardFactory","getCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;Lforge/game/Game;)Lforge/game/card/Card;","invokestatic",114);}
case 114:{f.Pc=139;continue;}
case 117:{f.Push(f.Locals[0]);f.Pc=118;continue;}
case 118:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",124);}
case 124:{f.Push(f.Locals[2]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[0]);f.Pc=126;continue;}
case 126:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",132);}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","toGame","Lforge/game/Game;"));f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/card/CardFactory","getCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;ILforge/game/Game;)Lforge/game/card/Card;","invokestatic",139);}
case 139:{f.Locals[3]=f.Pop();f.Pc=140;continue;}
case 140:{f.Push(f.Locals[3]);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",148);}
case 148:{return rt.Call(f,"forge/game/card/Card","setZone","(Lforge/game/zone/Zone;)V","invokevirtual",151);}
case 151:{f.Push(f.Locals[3]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[0]);f.Pc=153;continue;}
case 153:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/card/Card","getFaceupCardStateName","()Lforge/card/CardStateName;","invokevirtual",159);}
case 159:{f.Push(JValue.I(1));f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",163);}
case 163:{f.StackOp("pop");f.Pc=164;continue;}
case 164:{f.Push(f.Locals[3]);f.Pc=165;continue;}
case 165:{f.Push(f.Locals[0]);f.Pc=166;continue;}
case 166:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/card/Card","isBackSide","()Z","invokevirtual",172);}
case 172:{return rt.Call(f,"forge/game/card/Card","setBackSide","(Z)V","invokevirtual",175);}
case 175:{f.Push(f.Locals[3]);f.Pc=176;continue;}
case 176:{f.Push(f.Locals[0]);f.Pc=177;continue;}
case 177:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/card/Card","getGamePieceType","()Lforge/card/GamePieceType;","invokevirtual",183);}
case 183:{return rt.Call(f,"forge/game/card/Card","setGamePieceType","(Lforge/card/GamePieceType;)V","invokevirtual",186);}
case 186:{f.Push(f.Locals[3]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[0]);f.Pc=188;continue;}
case 188:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/card/Card","isTokenCard","()Z","invokevirtual",194);}
case 194:{return rt.Call(f,"forge/game/card/Card","setTokenCard","(Z)V","invokevirtual",197);}
case 197:{f.Push(f.Locals[0]);f.Pc=198;continue;}
case 198:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","toGame","Lforge/game/Game;"));f.Pc=201;continue;}
case 201:{f.Push(f.Locals[0]);f.Pc=202;continue;}
case 202:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",208);}
case 208:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?340:211;continue;}
case 211:{f.Push(f.Locals[3]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[0]);f.Pc=213;continue;}
case 213:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/card/Card","isCollectible","()Z","invokevirtual",219);}
case 219:{return rt.Call(f,"forge/game/card/Card","setCollectible","(Z)V","invokevirtual",222);}
case 222:{f.Push(f.Locals[0]);f.Pc=223;continue;}
case 223:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/card/Card","hasCardAttachments","()Z","invokevirtual",229);}
case 229:{f.Pc=f.Pop().Int==0?243:232;continue;}
case 232:{f.Push(f.Locals[3]);f.Pc=233;continue;}
case 233:{f.Push(f.Locals[0]);f.Pc=234;continue;}
case 234:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/game/card/Card","getAttachedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",240);}
case 240:{return rt.Call(f,"forge/game/card/Card","setAttachedCards","(Ljava/lang/Iterable;)V","invokevirtual",243);}
case 243:{f.Push(f.Locals[0]);f.Pc=244;continue;}
case 244:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/card/Card","isAttachedToEntity","()Z","invokevirtual",250);}
case 250:{f.Pc=f.Pop().Int==0?264:253;continue;}
case 253:{f.Push(f.Locals[3]);f.Pc=254;continue;}
case 254:{f.Push(f.Locals[0]);f.Pc=255;continue;}
case 255:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/card/Card","getEntityAttachedTo","()Lforge/game/GameEntity;","invokevirtual",261);}
case 261:{return rt.Call(f,"forge/game/card/Card","setEntityAttachedTo","(Lforge/game/GameEntity;)V","invokevirtual",264);}
case 264:{f.Push(f.Locals[0]);f.Pc=265;continue;}
case 265:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/card/Card","hasMergedCard","()Z","invokevirtual",271);}
case 271:{f.Pc=f.Pop().Int==0?285:274;continue;}
case 274:{f.Push(f.Locals[3]);f.Pc=275;continue;}
case 275:{f.Push(f.Locals[0]);f.Pc=276;continue;}
case 276:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/game/card/Card","getMergedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",282);}
case 282:{return rt.Call(f,"forge/game/card/Card","setMergedCards","(Ljava/lang/Iterable;)V","invokevirtual",285);}
case 285:{f.Push(f.Locals[3]);f.Pc=286;continue;}
case 286:{f.Push(f.Locals[0]);f.Pc=287;continue;}
case 287:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/card/Card","getLeavesPlayCommands","()Ljava/util/List;","invokevirtual",293);}
case 293:{return rt.Call(f,"forge/game/card/Card","setLeavesPlayCommands","(Ljava/util/List;)V","invokevirtual",296);}
case 296:{f.Push(f.Locals[3]);f.Pc=297;continue;}
case 297:{f.Push(f.Locals[0]);f.Pc=298;continue;}
case 298:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/game/card/Card","isSpecialized","()Z","invokevirtual",304);}
case 304:{return rt.Call(f,"forge/game/card/Card","setSpecialized","(Z)V","invokevirtual",307);}
case 307:{f.Push(f.Locals[3]);f.Pc=308;continue;}
case 308:{f.Push(f.Locals[0]);f.Pc=309;continue;}
case 309:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",315);}
case 315:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",318);}
case 318:{f.Push(f.Locals[3]);f.Pc=319;continue;}
case 319:{f.Push(f.Locals[0]);f.Pc=320;continue;}
case 320:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=323;continue;}
case 323:{return rt.Call(f,"forge/game/card/Card","getImprintedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",326);}
case 326:{return rt.Call(f,"forge/game/card/Card","addImprintedCards","(Ljava/lang/Iterable;)V","invokevirtual",329);}
case 329:{f.Push(f.Locals[3]);f.Pc=330;continue;}
case 330:{f.Push(f.Locals[0]);f.Pc=331;continue;}
case 331:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/game/card/Card","isRealCommander","()Z","invokevirtual",337);}
case 337:{return rt.Call(f,"forge/game/card/Card","setCommander","(Z)V","invokevirtual",340);}
case 340:{f.Push(f.Locals[0]);f.Pc=341;continue;}
case 341:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",347);}
case 347:{return rt.Call(f,"forge/game/card/CardState","getFoil","()I","invokevirtual",350);}
case 350:{f.Locals[4]=f.Pop();f.Pc=352;continue;}
case 352:{f.Push(f.Locals[4]);f.Pc=354;continue;}
case 354:{f.Pc=f.Pop().Int<=0?363:357;continue;}
case 357:{f.Push(f.Locals[3]);f.Pc=358;continue;}
case 358:{f.Push(f.Locals[4]);f.Pc=360;continue;}
case 360:{return rt.Call(f,"forge/game/card/Card","setFoil","(I)V","invokevirtual",363);}
case 363:{f.Push(f.Locals[3]);f.Pc=364;continue;}
case 364:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4925(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardCopyService","copyState","(Lforge/game/card/Card;Lforge/card/CardStateName;Lforge/game/card/Card;Lforge/card/CardStateName;Z)V","invokestatic",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4926(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","getSpellText","()Ljava/lang/String;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/card/Card","setText","(Ljava/lang/String;)V","invokevirtual",8);}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","getStates","()Ljava/util/Set;","invokevirtual",12);}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int!=0?28:21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/Card","addAlternateState","(Lforge/card/CardStateName;Z)V","invokevirtual",28);}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",33);}
case 33:{f.Locals[5]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",40);}
case 40:{f.Locals[6]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[5]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[6]);f.Pc=46;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/CardState","copyFrom","(Lforge/game/card/CardState;Z)V","invokevirtual",50);}
case 50:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4927(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Int==0?25:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Reference!=null?17:13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{f.Pc=24;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/game/Game","nextCardId","()I","invokevirtual",24);}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/ability/effects/DetachedCardEffect")?1:0));f.Pc=29;continue;}
case 29:{f.Pc=f.Pop().Int==0?49:32;continue;}
case 32:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/DetachedCardEffect"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/DetachedCardEffect")));f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/ability/effects/DetachedCardEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/ability/effects/DetachedCardEffect","<init>","(Lforge/game/ability/effects/DetachedCardEffect;Z)V","invokespecial",44);}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Pc=67;continue;}
case 49:{if(!rt.EnsureInitialized(f,"forge/game/card/Card"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/Card")));f.Pc=52;continue;}
case 52:{f.StackOp("dup");f.Pc=53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",58);}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",62);}
case 62:{return rt.Call(f,"forge/game/card/Card","<init>","(ILforge/item/IPaperCard;Lforge/game/Game;)V","invokespecial",65);}
case 65:{f.Locals[4]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[4]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/card/Card","setOwner","(Lforge/game/player/Player;)V","invokevirtual",73);}
case 73:{f.Push(f.Locals[4]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/card/Card","getSetCode","()Ljava/lang/String;","invokevirtual",79);}
case 79:{return rt.Call(f,"forge/game/card/Card","setSetCode","(Ljava/lang/String;)V","invokevirtual",82);}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/card/Card","getStates","()Ljava/util/Set;","invokevirtual",86);}
case 86:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",91);}
case 91:{f.Locals[5]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[5]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",100);}
case 100:{f.Pc=f.Pop().Int==0?129:103;continue;}
case 103:{f.Push(f.Locals[5]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",110);}
case 110:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardStateName"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=113;continue;}
case 113:{f.Locals[6]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[6]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[4]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[6]);f.Pc=122;continue;}
case 122:{f.Push(JValue.I(0));f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/card/CardCopyService","copyState","(Lforge/game/card/Card;Lforge/card/CardStateName;Lforge/game/card/Card;Lforge/card/CardStateName;Z)V","invokestatic",126);}
case 126:{f.Pc=93;continue;}
case 129:{f.Push(f.Locals[4]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",135);}
case 135:{f.Push(JValue.I(0));f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",139);}
case 139:{f.StackOp("pop");f.Pc=140;continue;}
case 140:{f.Push(f.Locals[4]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/card/Card","isBackSide","()Z","invokevirtual",146);}
case 146:{return rt.Call(f,"forge/game/card/Card","setBackSide","(Z)V","invokevirtual",149);}
case 149:{f.Push(f.Locals[4]);f.Pc=151;continue;}
case 151:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4928(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[4]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int==0?37:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/CardCopyService","copyCopiableCharacteristics","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;)V","invokevirtual",27);}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{if(!rt.StaticReady(f,"forge/card/CardStateName","FaceDown","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","FaceDown","Lforge/card/CardStateName;"));f.Pc=31;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{return JStep.ReturnVoid;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/card/Card","isFlipCard","()Z","invokevirtual",44);}
case 44:{f.Locals[5]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",53);}
case 53:{if(!rt.StaticReady(f,"forge/card/CardStateName","Backside","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Backside","Lforge/card/CardStateName;"));f.Pc=56;continue;}
case 56:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?72:59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",66);}
case 66:{if(!rt.StaticReady(f,"forge/card/CardStateName","Meld","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Meld","Lforge/card/CardStateName;"));f.Pc=69;continue;}
case 69:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?76:72;continue;}
case 72:{f.Push(JValue.I(1));f.Pc=73;continue;}
case 73:{f.Pc=77;continue;}
case 76:{f.Push(JValue.I(0));f.Pc=77;continue;}
case 77:{f.Locals[6]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[5]);f.Pc=81;continue;}
case 81:{f.Pc=f.Pop().Int==0?146:84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",88);}
case 88:{if(!rt.StaticReady(f,"forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/card/CardStateName","equals","(Ljava/lang/Object;)Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int==0?114:97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=101;continue;}
case 101:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=104;continue;}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/card/CardCopyService","copyState","(Lforge/game/card/Card;Lforge/card/CardStateName;Lforge/game/card/Card;Lforge/card/CardStateName;)V","invokestatic",111);}
case 111:{f.Pc=129;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=118;continue;}
case 118:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=121;continue;}
case 121:{f.Push(f.Locals[1]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",126);}
case 126:{return rt.Call(f,"forge/game/card/CardCopyService","copyState","(Lforge/game/card/Card;Lforge/card/CardStateName;Lforge/game/card/Card;Lforge/card/CardStateName;)V","invokestatic",129);}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=133;continue;}
case 133:{if(!rt.StaticReady(f,"forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"));f.Pc=136;continue;}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{if(!rt.StaticReady(f,"forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"));f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/card/CardCopyService","copyState","(Lforge/game/card/Card;Lforge/card/CardStateName;Lforge/game/card/Card;Lforge/card/CardStateName;)V","invokestatic",143);}
case 143:{f.Pc=281;continue;}
case 146:{f.Push(f.Locals[0]);f.Pc=147;continue;}
case 147:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/card/Card","isTransformable","()Z","invokevirtual",153);}
case 153:{f.Pc=f.Pop().Int==0?236:156;continue;}
case 156:{f.Push(f.Locals[2]);f.Pc=157;continue;}
case 157:{f.Pc=f.Pop().Reference==null?236:160;continue;}
case 160:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","CopySpellAbility","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","CopySpellAbility","Lforge/game/ability/ApiType;"));f.Pc=163;continue;}
case 163:{f.Push(f.Locals[2]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",167);}
case 167:{return rt.Call(f,"forge/game/ability/ApiType","equals","(Ljava/lang/Object;)Z","invokevirtual",170);}
case 170:{f.Pc=f.Pop().Int==0?236:173;continue;}
case 173:{f.Push(f.Locals[3]);f.Pc=174;continue;}
case 174:{f.Pc=f.Pop().Reference==null?236:177;continue;}
case 177:{f.Push(f.Locals[3]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",181);}
case 181:{f.Pc=f.Pop().Int==0?236:184;continue;}
case 184:{f.Push(f.Locals[3]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",188);}
case 188:{return rt.Call(f,"forge/game/card/Card","isPermanent","()Z","invokevirtual",191);}
case 191:{f.Pc=f.Pop().Int==0?236:194;continue;}
case 194:{f.Push(f.Locals[0]);f.Pc=195;continue;}
case 195:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=198;continue;}
case 198:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=201;continue;}
case 201:{f.Push(f.Locals[1]);f.Pc=202;continue;}
case 202:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/card/CardCopyService","copyState","(Lforge/game/card/Card;Lforge/card/CardStateName;Lforge/game/card/Card;Lforge/card/CardStateName;)V","invokestatic",208);}
case 208:{f.Push(f.Locals[0]);f.Pc=209;continue;}
case 209:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=212;continue;}
case 212:{if(!rt.StaticReady(f,"forge/card/CardStateName","Backside","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Backside","Lforge/card/CardStateName;"));f.Pc=215;continue;}
case 215:{f.Push(f.Locals[1]);f.Pc=216;continue;}
case 216:{if(!rt.StaticReady(f,"forge/card/CardStateName","Backside","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Backside","Lforge/card/CardStateName;"));f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/card/CardCopyService","copyState","(Lforge/game/card/Card;Lforge/card/CardStateName;Lforge/game/card/Card;Lforge/card/CardStateName;)V","invokestatic",222);}
case 222:{f.Push(f.Locals[1]);f.Pc=223;continue;}
case 223:{f.Push(f.Locals[0]);f.Pc=224;continue;}
case 224:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/card/Card","isBackSide","()Z","invokevirtual",230);}
case 230:{return rt.Call(f,"forge/game/card/Card","setBackSide","(Z)V","invokevirtual",233);}
case 233:{f.Pc=281;continue;}
case 236:{f.Push(f.Locals[6]);f.Pc=238;continue;}
case 238:{f.Pc=f.Pop().Int==0?262:241;continue;}
case 241:{f.Push(f.Locals[0]);f.Pc=242;continue;}
case 242:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=245;continue;}
case 245:{f.Push(f.Locals[0]);f.Pc=246;continue;}
case 246:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",252);}
case 252:{f.Push(f.Locals[1]);f.Pc=253;continue;}
case 253:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=256;continue;}
case 256:{return rt.Call(f,"forge/game/card/CardCopyService","copyState","(Lforge/game/card/Card;Lforge/card/CardStateName;Lforge/game/card/Card;Lforge/card/CardStateName;)V","invokestatic",259);}
case 259:{f.Pc=281;continue;}
case 262:{f.Push(f.Locals[0]);f.Pc=263;continue;}
case 263:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=266;continue;}
case 266:{f.Push(f.Locals[0]);f.Pc=267;continue;}
case 267:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",273);}
case 273:{f.Push(f.Locals[1]);f.Pc=274;continue;}
case 274:{f.Push(f.Locals[1]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",278);}
case 278:{return rt.Call(f,"forge/game/card/CardCopyService","copyState","(Lforge/game/card/Card;Lforge/card/CardStateName;Lforge/game/card/Card;Lforge/card/CardStateName;)V","invokestatic",281);}
case 281:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4929(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",23);}
case 23:{f.Pc=f.Pop().Int==0?60:26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",32);}
case 32:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=35;continue;}
case 35:{f.Locals[4]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCopyService"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCopyService")));f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/card/CardCopyService","<init>","(Lforge/game/card/Card;)V","invokespecial",47);}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",51);}
case 51:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",56);}
case 56:{f.StackOp("pop");f.Pc=57;continue;}
case 57:{f.Pc=17;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4930(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCopyService"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCopyService")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardCopyService","<init>","(Lforge/game/card/Card;)V","invokespecial",8);}
case 8:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","()Lforge/game/card/Card;","invokevirtual",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4931(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCopyService"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCopyService")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardCopyService","<init>","(Lforge/game/card/Card;)V","invokespecial",8);}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4932(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?23:7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCopyService"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCopyService")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/CardCopyService","<init>","(Lforge/game/card/Card;)V","invokespecial",18);}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",22);}
case 22:{return JStep.Return(f.Pop());}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4933(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",4);}
case 4:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4934(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AbilityText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AbilityText","Lforge/trackable/TrackableProperty;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getAbilityText","()Ljava/lang/String;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",17);}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/CardView","hasAlternateState","()Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?48:24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/CardView","hasAlternateState","()Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?48:31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/CardView","getAlternateState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",35);}
case 35:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AbilityText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AbilityText","Lforge/trackable/TrackableProperty;"));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/CardView","getAlternateState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",42);}
case 42:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getAbilityText","()Ljava/lang/String;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",48);}
case 48:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4935(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?9:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",17);}
case 17:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",20);}
case 20:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Reference==null?35:33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return JStep.Return(f.Pop());}
case 35:{f.Push(JValue.R(rt.String("CardUtil:getLKICopy copy object")));f.Pc=38;continue;}
case 38:{f.Locals[3]=f.Pop();f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"io/sentry/Breadcrumb"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("io/sentry/Breadcrumb")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"io/sentry/Breadcrumb","<init>","(Ljava/lang/String;)V","invokespecial",47);}
case 47:{f.Locals[4]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("Card")));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",61);}
case 61:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",64);}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("CardState")));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",76);}
case 76:{return rt.Call(f,"forge/card/CardStateName","toString","()Ljava/lang/String;","invokevirtual",79);}
case 79:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",82);}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String("Player")));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",94);}
case 94:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",97);}
case 97:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",100);}
case 100:{f.Push(f.Locals[4]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"io/sentry/Sentry","addBreadcrumb","(Lio/sentry/Breadcrumb;)V","invokestatic",105);}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=109;continue;}
case 109:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/ability/effects/DetachedCardEffect")?1:0));f.Pc=112;continue;}
case 112:{f.Pc=f.Pop().Int==0?135:115;continue;}
case 115:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/DetachedCardEffect"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/DetachedCardEffect")));f.Pc=118;continue;}
case 118:{f.StackOp("dup");f.Pc=119;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=123;continue;}
case 123:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/ability/effects/DetachedCardEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=126;continue;}
case 126:{f.Push(JValue.I(0));f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/ability/effects/DetachedCardEffect","<init>","(Lforge/game/ability/effects/DetachedCardEffect;Z)V","invokespecial",130);}
case 130:{f.Locals[5]=f.Pop();f.Pc=132;continue;}
case 132:{f.Pc=167;continue;}
case 135:{if(!rt.EnsureInitialized(f,"forge/game/card/Card"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/Card")));f.Pc=138;continue;}
case 138:{f.StackOp("dup");f.Pc=139;continue;}
case 139:{f.Push(f.Locals[0]);f.Pc=140;continue;}
case 140:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",146);}
case 146:{f.Push(f.Locals[0]);f.Pc=147;continue;}
case 147:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",153);}
case 153:{f.Push(f.Locals[0]);f.Pc=154;continue;}
case 154:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",160);}
case 160:{f.Push(JValue.R(null));f.Pc=161;continue;}
case 161:{f.Push(JValue.I(1));f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/card/Card","<init>","(ILforge/item/IPaperCard;Lforge/game/Game;Lforge/trackable/Tracker;Z)V","invokespecial",165);}
case 165:{f.Locals[5]=f.Pop();f.Pc=167;continue;}
case 167:{f.Push(f.Locals[1]);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[0]);f.Pc=169;continue;}
case 169:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",175);}
case 175:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",178);}
case 178:{f.Push(f.Locals[5]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",185);}
case 185:{f.StackOp("pop");f.Pc=186;continue;}
case 186:{f.Push(f.Locals[5]);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[0]);f.Pc=189;continue;}
case 189:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/game/card/Card","getSetCode","()Ljava/lang/String;","invokevirtual",195);}
case 195:{return rt.Call(f,"forge/game/card/Card","setSetCode","(Ljava/lang/String;)V","invokevirtual",198);}
case 198:{f.Push(f.Locals[5]);f.Pc=200;continue;}
case 200:{f.Push(f.Locals[0]);f.Pc=201;continue;}
case 201:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",207);}
case 207:{return rt.Call(f,"forge/game/card/Card","setOwner","(Lforge/game/player/Player;)V","invokevirtual",210);}
case 210:{f.Push(f.Locals[5]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[0]);f.Pc=213;continue;}
case 213:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",219);}
case 219:{f.Push(JValue.L(0));f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",223);}
case 223:{f.Push(f.Locals[5]);f.Pc=225;continue;}
case 225:{f.Push(f.Locals[0]);f.Pc=226;continue;}
case 226:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/card/Card","isCommander","()Z","invokevirtual",232);}
case 232:{return rt.Call(f,"forge/game/card/Card","setCommander","(Z)V","invokevirtual",235);}
case 235:{f.Push(f.Locals[5]);f.Pc=237;continue;}
case 237:{f.Push(f.Locals[0]);f.Pc=238;continue;}
case 238:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/card/Card","isCollectible","()Z","invokevirtual",244);}
case 244:{return rt.Call(f,"forge/game/card/Card","setCollectible","(Z)V","invokevirtual",247);}
case 247:{f.Push(f.Locals[5]);f.Pc=249;continue;}
case 249:{f.Push(f.Locals[0]);f.Pc=250;continue;}
case 250:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=253;continue;}
case 253:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",256);}
case 256:{return rt.Call(f,"forge/game/card/Card","setLKICMC","(I)V","invokevirtual",259);}
case 259:{f.Push(f.Locals[5]);f.Pc=261;continue;}
case 261:{f.Push(f.Locals[0]);f.Pc=262;continue;}
case 262:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/card/Card","getLastKnownZone","()Lforge/game/zone/Zone;","invokevirtual",268);}
case 268:{return rt.Call(f,"forge/game/card/Card","setLastKnownZone","(Lforge/game/zone/Zone;)V","invokevirtual",271);}
case 271:{f.Push(f.Locals[5]);f.Pc=273;continue;}
case 273:{f.Push(f.Locals[0]);f.Pc=274;continue;}
case 274:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/card/Card","getEffectSource","()Lforge/game/card/Card;","invokevirtual",280);}
case 280:{f.Push(f.Locals[1]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;Ljava/util/Map;)Lforge/game/card/Card;","invokestatic",284);}
case 284:{return rt.Call(f,"forge/game/card/Card","setEffectSource","(Lforge/game/card/Card;)V","invokevirtual",287);}
case 287:{f.Push(f.Locals[0]);f.Pc=288;continue;}
case 288:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/game/card/Card","isFlipCard","()Z","invokevirtual",294);}
case 294:{f.Pc=f.Pop().Int==0?353:297;continue;}
case 297:{f.Push(f.Locals[5]);f.Pc=299;continue;}
case 299:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=302;continue;}
case 302:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",305);}
case 305:{f.Push(f.Locals[0]);f.Pc=306;continue;}
case 306:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=309;continue;}
case 309:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",315);}
case 315:{f.Push(JValue.I(1));f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/card/CardState","copyFrom","(Lforge/game/card/CardState;Z)V","invokevirtual",319);}
case 319:{f.Push(f.Locals[5]);f.Pc=321;continue;}
case 321:{if(!rt.StaticReady(f,"forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"));f.Pc=324;continue;}
case 324:{f.Push(JValue.I(0));f.Pc=325;continue;}
case 325:{return rt.Call(f,"forge/game/card/Card","addAlternateState","(Lforge/card/CardStateName;Z)V","invokevirtual",328);}
case 328:{f.Push(f.Locals[5]);f.Pc=330;continue;}
case 330:{if(!rt.StaticReady(f,"forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"));f.Pc=333;continue;}
case 333:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",336);}
case 336:{f.Push(f.Locals[0]);f.Pc=337;continue;}
case 337:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=340;continue;}
case 340:{if(!rt.StaticReady(f,"forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"));f.Pc=343;continue;}
case 343:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",346);}
case 346:{f.Push(JValue.I(1));f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/game/card/CardState","copyFrom","(Lforge/game/card/CardState;Z)V","invokevirtual",350);}
case 350:{f.Pc=677;continue;}
case 353:{f.Push(f.Locals[0]);f.Pc=354;continue;}
case 354:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=357;continue;}
case 357:{return rt.Call(f,"forge/game/card/Card","isTransformable","()Z","invokevirtual",360);}
case 360:{f.Pc=f.Pop().Int==0?419:363;continue;}
case 363:{f.Push(f.Locals[5]);f.Pc=365;continue;}
case 365:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=368;continue;}
case 368:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",371);}
case 371:{f.Push(f.Locals[0]);f.Pc=372;continue;}
case 372:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=375;continue;}
case 375:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=378;continue;}
case 378:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",381);}
case 381:{f.Push(JValue.I(1));f.Pc=382;continue;}
case 382:{return rt.Call(f,"forge/game/card/CardState","copyFrom","(Lforge/game/card/CardState;Z)V","invokevirtual",385);}
case 385:{f.Push(f.Locals[5]);f.Pc=387;continue;}
case 387:{if(!rt.StaticReady(f,"forge/card/CardStateName","Backside","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Backside","Lforge/card/CardStateName;"));f.Pc=390;continue;}
case 390:{f.Push(JValue.I(0));f.Pc=391;continue;}
case 391:{return rt.Call(f,"forge/game/card/Card","addAlternateState","(Lforge/card/CardStateName;Z)V","invokevirtual",394);}
case 394:{f.Push(f.Locals[5]);f.Pc=396;continue;}
case 396:{if(!rt.StaticReady(f,"forge/card/CardStateName","Backside","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Backside","Lforge/card/CardStateName;"));f.Pc=399;continue;}
case 399:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",402);}
case 402:{f.Push(f.Locals[0]);f.Pc=403;continue;}
case 403:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=406;continue;}
case 406:{if(!rt.StaticReady(f,"forge/card/CardStateName","Backside","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Backside","Lforge/card/CardStateName;"));f.Pc=409;continue;}
case 409:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",412);}
case 412:{f.Push(JValue.I(1));f.Pc=413;continue;}
case 413:{return rt.Call(f,"forge/game/card/CardState","copyFrom","(Lforge/game/card/CardState;Z)V","invokevirtual",416);}
case 416:{f.Pc=677;continue;}
case 419:{f.Push(f.Locals[0]);f.Pc=420;continue;}
case 420:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=423;continue;}
case 423:{if(!rt.StaticReady(f,"forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"));f.Pc=426;continue;}
case 426:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",429);}
case 429:{f.Pc=f.Pop().Int==0?488:432;continue;}
case 432:{f.Push(f.Locals[5]);f.Pc=434;continue;}
case 434:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=437;continue;}
case 437:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",440);}
case 440:{f.Push(f.Locals[0]);f.Pc=441;continue;}
case 441:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=444;continue;}
case 444:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=447;continue;}
case 447:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",450);}
case 450:{f.Push(JValue.I(1));f.Pc=451;continue;}
case 451:{return rt.Call(f,"forge/game/card/CardState","copyFrom","(Lforge/game/card/CardState;Z)V","invokevirtual",454);}
case 454:{f.Push(f.Locals[5]);f.Pc=456;continue;}
case 456:{if(!rt.StaticReady(f,"forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"));f.Pc=459;continue;}
case 459:{f.Push(JValue.I(0));f.Pc=460;continue;}
case 460:{return rt.Call(f,"forge/game/card/Card","addAlternateState","(Lforge/card/CardStateName;Z)V","invokevirtual",463);}
case 463:{f.Push(f.Locals[5]);f.Pc=465;continue;}
case 465:{if(!rt.StaticReady(f,"forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"));f.Pc=468;continue;}
case 468:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",471);}
case 471:{f.Push(f.Locals[0]);f.Pc=472;continue;}
case 472:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=475;continue;}
case 475:{if(!rt.StaticReady(f,"forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"));f.Pc=478;continue;}
case 478:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",481);}
case 481:{f.Push(JValue.I(1));f.Pc=482;continue;}
case 482:{return rt.Call(f,"forge/game/card/CardState","copyFrom","(Lforge/game/card/CardState;Z)V","invokevirtual",485);}
case 485:{f.Pc=677;continue;}
case 488:{f.Push(f.Locals[0]);f.Pc=489;continue;}
case 489:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=492;continue;}
case 492:{if(!rt.StaticReady(f,"forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"));f.Pc=495;continue;}
case 495:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",498);}
case 498:{f.Pc=f.Pop().Int==0?557:501;continue;}
case 501:{f.Push(f.Locals[5]);f.Pc=503;continue;}
case 503:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=506;continue;}
case 506:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",509);}
case 509:{f.Push(f.Locals[0]);f.Pc=510;continue;}
case 510:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=513;continue;}
case 513:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=516;continue;}
case 516:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",519);}
case 519:{f.Push(JValue.I(1));f.Pc=520;continue;}
case 520:{return rt.Call(f,"forge/game/card/CardState","copyFrom","(Lforge/game/card/CardState;Z)V","invokevirtual",523);}
case 523:{f.Push(f.Locals[5]);f.Pc=525;continue;}
case 525:{if(!rt.StaticReady(f,"forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"));f.Pc=528;continue;}
case 528:{f.Push(JValue.I(0));f.Pc=529;continue;}
case 529:{return rt.Call(f,"forge/game/card/Card","addAlternateState","(Lforge/card/CardStateName;Z)V","invokevirtual",532);}
case 532:{f.Push(f.Locals[5]);f.Pc=534;continue;}
case 534:{if(!rt.StaticReady(f,"forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"));f.Pc=537;continue;}
case 537:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",540);}
case 540:{f.Push(f.Locals[0]);f.Pc=541;continue;}
case 541:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=544;continue;}
case 544:{if(!rt.StaticReady(f,"forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"));f.Pc=547;continue;}
case 547:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",550);}
case 550:{f.Push(JValue.I(1));f.Pc=551;continue;}
case 551:{return rt.Call(f,"forge/game/card/CardState","copyFrom","(Lforge/game/card/CardState;Z)V","invokevirtual",554);}
case 554:{f.Pc=677;continue;}
case 557:{f.Push(f.Locals[0]);f.Pc=558;continue;}
case 558:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=561;continue;}
case 561:{return rt.Call(f,"forge/game/card/Card","isSplitCard","()Z","invokevirtual",564);}
case 564:{f.Pc=f.Pop().Int==0?654:567;continue;}
case 567:{f.Push(f.Locals[5]);f.Pc=569;continue;}
case 569:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=572;continue;}
case 572:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",575);}
case 575:{f.Push(f.Locals[0]);f.Pc=576;continue;}
case 576:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=579;continue;}
case 579:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=582;continue;}
case 582:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",585);}
case 585:{f.Push(JValue.I(1));f.Pc=586;continue;}
case 586:{return rt.Call(f,"forge/game/card/CardState","copyFrom","(Lforge/game/card/CardState;Z)V","invokevirtual",589);}
case 589:{f.Push(f.Locals[5]);f.Pc=591;continue;}
case 591:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=594;continue;}
case 594:{f.Push(JValue.I(0));f.Pc=595;continue;}
case 595:{return rt.Call(f,"forge/game/card/Card","addAlternateState","(Lforge/card/CardStateName;Z)V","invokevirtual",598);}
case 598:{f.Push(f.Locals[5]);f.Pc=600;continue;}
case 600:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=603;continue;}
case 603:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",606);}
case 606:{f.Push(f.Locals[0]);f.Pc=607;continue;}
case 607:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=610;continue;}
case 610:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=613;continue;}
case 613:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",616);}
case 616:{f.Push(JValue.I(1));f.Pc=617;continue;}
case 617:{return rt.Call(f,"forge/game/card/CardState","copyFrom","(Lforge/game/card/CardState;Z)V","invokevirtual",620);}
case 620:{f.Push(f.Locals[5]);f.Pc=622;continue;}
case 622:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=625;continue;}
case 625:{f.Push(JValue.I(0));f.Pc=626;continue;}
case 626:{return rt.Call(f,"forge/game/card/Card","addAlternateState","(Lforge/card/CardStateName;Z)V","invokevirtual",629);}
case 629:{f.Push(f.Locals[5]);f.Pc=631;continue;}
case 631:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=634;continue;}
case 634:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",637);}
case 637:{f.Push(f.Locals[0]);f.Pc=638;continue;}
case 638:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=641;continue;}
case 641:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=644;continue;}
case 644:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",647);}
case 647:{f.Push(JValue.I(1));f.Pc=648;continue;}
case 648:{return rt.Call(f,"forge/game/card/CardState","copyFrom","(Lforge/game/card/CardState;Z)V","invokevirtual",651);}
case 651:{f.Pc=677;continue;}
case 654:{f.Push(f.Locals[5]);f.Pc=656;continue;}
case 656:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",659);}
case 659:{f.Push(f.Locals[0]);f.Pc=660;continue;}
case 660:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=663;continue;}
case 663:{f.Push(f.Locals[0]);f.Pc=664;continue;}
case 664:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=667;continue;}
case 667:{return rt.Call(f,"forge/game/card/Card","getFaceupCardStateName","()Lforge/card/CardStateName;","invokevirtual",670);}
case 670:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",673);}
case 673:{f.Push(JValue.I(1));f.Pc=674;continue;}
case 674:{return rt.Call(f,"forge/game/card/CardState","copyFrom","(Lforge/game/card/CardState;Z)V","invokevirtual",677);}
case 677:{f.Push(f.Locals[5]);f.Pc=679;continue;}
case 679:{f.Push(f.Locals[0]);f.Pc=680;continue;}
case 680:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=683;continue;}
case 683:{return rt.Call(f,"forge/game/card/Card","isFlipped","()Z","invokevirtual",686);}
case 686:{return rt.Call(f,"forge/game/card/Card","setFlipped","(Z)V","invokevirtual",689);}
case 689:{f.Push(f.Locals[5]);f.Pc=691;continue;}
case 691:{f.Push(f.Locals[0]);f.Pc=692;continue;}
case 692:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=695;continue;}
case 695:{return rt.Call(f,"forge/game/card/Card","isBackSide","()Z","invokevirtual",698);}
case 698:{return rt.Call(f,"forge/game/card/Card","setBackSide","(Z)V","invokevirtual",701);}
case 701:{f.Push(f.Locals[5]);f.Pc=703;continue;}
case 703:{return rt.Call(f,"forge/game/card/Card","hasAlternateState","()Z","invokevirtual",706);}
case 706:{f.Pc=f.Pop().Int==0?724:709;continue;}
case 709:{f.Push(f.Locals[5]);f.Pc=711;continue;}
case 711:{f.Push(f.Locals[0]);f.Pc=712;continue;}
case 712:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=715;continue;}
case 715:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",718);}
case 718:{f.Push(JValue.I(0));f.Pc=719;continue;}
case 719:{f.Push(JValue.I(1));f.Pc=720;continue;}
case 720:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;ZZ)Z","invokevirtual",723);}
case 723:{f.StackOp("pop");f.Pc=724;continue;}
case 724:{f.Push(f.Locals[0]);f.Pc=725;continue;}
case 725:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=728;continue;}
case 728:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",731);}
case 731:{f.Pc=f.Pop().Int==0?762:734;continue;}
case 734:{f.Push(f.Locals[5]);f.Pc=736;continue;}
case 736:{return rt.Call(f,"forge/game/card/Card","turnFaceDownNoUpdate","()Z","invokevirtual",739);}
case 739:{f.StackOp("pop");f.Pc=740;continue;}
case 740:{f.Push(f.Locals[5]);f.Pc=742;continue;}
case 742:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=745;continue;}
case 745:{f.StackOp("dup");f.Pc=746;continue;}
case 746:{f.Push(f.Locals[0]);f.Pc=747;continue;}
case 747:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=750;continue;}
case 750:{return rt.Call(f,"forge/game/card/Card","getFaceDownState","()Lforge/game/card/CardState;","invokevirtual",753);}
case 753:{return rt.Call(f,"forge/game/card/CardState","getType","()Lforge/card/CardTypeView;","invokevirtual",756);}
case 756:{return rt.Call(f,"forge/card/CardType","<init>","(Lforge/card/CardTypeView;)V","invokespecial",759);}
case 759:{return rt.Call(f,"forge/game/card/Card","setType","(Lforge/card/CardType;)V","invokevirtual",762);}
case 762:{f.Push(f.Locals[5]);f.Pc=764;continue;}
case 764:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",767);}
case 767:{f.Push(f.Locals[0]);f.Pc=768;continue;}
case 768:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=771;continue;}
case 771:{return rt.Call(f,"forge/game/card/Card","getView","()Lforge/game/card/CardView;","invokevirtual",774);}
case 774:{f.Push(f.Locals[5]);f.Pc=776;continue;}
case 776:{return rt.Call(f,"forge/game/card/Card","getView","()Lforge/game/card/CardView;","invokevirtual",779);}
case 779:{return rt.Call(f,"forge/game/card/CardCopyService","copyAbilityText","(Lforge/game/card/CardView;Lforge/game/card/CardView;)V","invokestatic",782);}
case 782:{f.Push(f.Locals[5]);f.Pc=784;continue;}
case 784:{f.Push(f.Locals[0]);f.Pc=785;continue;}
case 785:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=788;continue;}
case 788:{return rt.Call(f,"forge/game/card/Card","getGamePieceType","()Lforge/card/GamePieceType;","invokevirtual",791);}
case 791:{return rt.Call(f,"forge/game/card/Card","setGamePieceType","(Lforge/card/GamePieceType;)V","invokevirtual",794);}
case 794:{f.Push(f.Locals[5]);f.Pc=796;continue;}
case 796:{f.Push(f.Locals[0]);f.Pc=797;continue;}
case 797:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=800;continue;}
case 800:{return rt.Call(f,"forge/game/card/Card","isTokenCard","()Z","invokevirtual",803);}
case 803:{return rt.Call(f,"forge/game/card/Card","setTokenCard","(Z)V","invokevirtual",806);}
case 806:{f.Push(f.Locals[5]);f.Pc=808;continue;}
case 808:{f.Push(f.Locals[0]);f.Pc=809;continue;}
case 809:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=812;continue;}
case 812:{return rt.Call(f,"forge/game/card/Card","isEmblem","()Z","invokevirtual",815);}
case 815:{return rt.Call(f,"forge/game/card/Card","setEmblem","(Z)V","invokevirtual",818);}
case 818:{f.Push(f.Locals[5]);f.Pc=820;continue;}
case 820:{f.Push(f.Locals[0]);f.Pc=821;continue;}
case 821:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=824;continue;}
case 824:{return rt.Call(f,"forge/game/card/Card","getCurrentPower","()I","invokevirtual",827);}
case 827:{return rt.Call(f,"forge/game/card/Card","setBasePower","(I)V","invokevirtual",830);}
case 830:{f.Push(f.Locals[5]);f.Pc=832;continue;}
case 832:{f.Push(f.Locals[0]);f.Pc=833;continue;}
case 833:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=836;continue;}
case 836:{return rt.Call(f,"forge/game/card/Card","getCurrentToughness","()I","invokevirtual",839);}
case 839:{return rt.Call(f,"forge/game/card/Card","setBaseToughness","(I)V","invokevirtual",842);}
case 842:{f.Push(f.Locals[5]);f.Pc=844;continue;}
case 844:{f.Push(f.Locals[0]);f.Pc=845;continue;}
case 845:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=848;continue;}
case 848:{return rt.Call(f,"forge/game/card/Card","getPTBoostTable","()Lcom/google/common/collect/Table;","invokevirtual",851);}
case 851:{return rt.Call(f,"forge/game/card/Card","setPTBoost","(Lcom/google/common/collect/Table;)V","invokevirtual",854);}
case 854:{f.Push(f.Locals[5]);f.Pc=856;continue;}
case 856:{f.Push(f.Locals[0]);f.Pc=857;continue;}
case 857:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=860;continue;}
case 860:{return rt.Call(f,"forge/game/card/Card","copyFrom","(Lforge/game/card/Card;)V","invokevirtual",863);}
case 863:{f.Push(f.Locals[5]);f.Pc=865;continue;}
case 865:{f.Push(f.Locals[0]);f.Pc=866;continue;}
case 866:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=869;continue;}
case 869:{return rt.Call(f,"forge/game/card/Card","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",872);}
case 872:{return rt.Call(f,"com/google/common/collect/HashMultiset","create","(Ljava/lang/Iterable;)Lcom/google/common/collect/HashMultiset;","invokestatic",875);}
case 875:{return rt.Call(f,"forge/game/card/Card","setCounters","(Lcom/google/common/collect/Multiset;)V","invokevirtual",878);}
case 878:{f.Push(f.Locals[5]);f.Pc=880;continue;}
case 880:{f.Push(f.Locals[0]);f.Pc=881;continue;}
case 881:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=884;continue;}
case 884:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",887);}
case 887:{return rt.Call(f,"forge/game/card/Card","setColor","(Lforge/card/ColorSet;)V","invokevirtual",890);}
case 890:{f.Push(f.Locals[5]);f.Pc=892;continue;}
case 892:{f.Push(f.Locals[0]);f.Pc=893;continue;}
case 893:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=896;continue;}
case 896:{return rt.Call(f,"forge/game/card/Card","getPhasedOut","()Lforge/game/player/Player;","invokevirtual",899);}
case 899:{return rt.Call(f,"forge/game/card/Card","setPhasedOut","(Lforge/game/player/Player;)V","invokevirtual",902);}
case 902:{f.Push(f.Locals[5]);f.Pc=904;continue;}
case 904:{f.Push(f.Locals[0]);f.Pc=905;continue;}
case 905:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=908;continue;}
case 908:{return rt.Call(f,"forge/game/card/Card","isTapped","()Z","invokevirtual",911);}
case 911:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",914);}
case 914:{f.Push(f.Locals[5]);f.Pc=916;continue;}
case 916:{f.Push(f.Locals[0]);f.Pc=917;continue;}
case 917:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=920;continue;}
case 920:{return rt.Call(f,"forge/game/card/Card","isTributed","()Z","invokevirtual",923);}
case 923:{return rt.Call(f,"forge/game/card/Card","setTributed","(Z)V","invokevirtual",926);}
case 926:{f.Push(f.Locals[5]);f.Pc=928;continue;}
case 928:{f.Push(f.Locals[0]);f.Pc=929;continue;}
case 929:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=932;continue;}
case 932:{return rt.Call(f,"forge/game/card/Card","isUnearthed","()Z","invokevirtual",935);}
case 935:{return rt.Call(f,"forge/game/card/Card","setUnearthed","(Z)V","invokevirtual",938);}
case 938:{f.Push(f.Locals[5]);f.Pc=940;continue;}
case 940:{f.Push(f.Locals[0]);f.Pc=941;continue;}
case 941:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=944;continue;}
case 944:{return rt.Call(f,"forge/game/card/Card","isMonstrous","()Z","invokevirtual",947);}
case 947:{return rt.Call(f,"forge/game/card/Card","setMonstrous","(Z)V","invokevirtual",950);}
case 950:{f.Push(f.Locals[5]);f.Pc=952;continue;}
case 952:{f.Push(f.Locals[0]);f.Pc=953;continue;}
case 953:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=956;continue;}
case 956:{return rt.Call(f,"forge/game/card/Card","isRenowned","()Z","invokevirtual",959);}
case 959:{return rt.Call(f,"forge/game/card/Card","setRenowned","(Z)V","invokevirtual",962);}
case 962:{f.Push(f.Locals[5]);f.Pc=964;continue;}
case 964:{f.Push(f.Locals[0]);f.Pc=965;continue;}
case 965:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=968;continue;}
case 968:{return rt.Call(f,"forge/game/card/Card","isSolved","()Z","invokevirtual",971);}
case 971:{return rt.Call(f,"forge/game/card/Card","setSolved","(Z)Z","invokevirtual",974);}
case 974:{f.StackOp("pop");f.Pc=975;continue;}
case 975:{f.Push(f.Locals[5]);f.Pc=977;continue;}
case 977:{f.Push(f.Locals[0]);f.Pc=978;continue;}
case 978:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=981;continue;}
case 981:{return rt.Call(f,"forge/game/card/Card","getPromisedGift","()Lforge/game/player/Player;","invokevirtual",984);}
case 984:{return rt.Call(f,"forge/game/card/Card","setPromisedGift","(Lforge/game/player/Player;)V","invokevirtual",987);}
case 987:{f.Push(f.Locals[5]);f.Pc=989;continue;}
case 989:{f.Push(f.Locals[0]);f.Pc=990;continue;}
case 990:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=993;continue;}
case 993:{return rt.Call(f,"forge/game/card/Card","isSaddled","()Z","invokevirtual",996);}
case 996:{return rt.Call(f,"forge/game/card/Card","setSaddled","(Z)Z","invokevirtual",999);}
case 999:{f.StackOp("pop");f.Pc=1000;continue;}
case 1000:{f.Push(f.Locals[5]);f.Pc=1002;continue;}
case 1002:{return rt.Call(f,"forge/game/card/Card","isSaddled","()Z","invokevirtual",1005);}
case 1005:{f.Pc=f.Pop().Int==0?1020:1008;continue;}
case 1008:{f.Push(f.Locals[5]);f.Pc=1010;continue;}
case 1010:{f.Push(f.Locals[0]);f.Pc=1011;continue;}
case 1011:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1014;continue;}
case 1014:{return rt.Call(f,"forge/game/card/Card","getSaddledByThisTurn","()Lforge/game/card/CardCollection;","invokevirtual",1017);}
case 1017:{return rt.Call(f,"forge/game/card/Card","setSaddledByThisTurn","(Lforge/game/card/CardCollection;)V","invokevirtual",1020);}
case 1020:{f.Push(f.Locals[0]);f.Pc=1021;continue;}
case 1021:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1024;continue;}
case 1024:{return rt.Call(f,"forge/game/card/Card","isSuspected","()Z","invokevirtual",1027);}
case 1027:{f.Pc=f.Pop().Int==0?1048:1030;continue;}
case 1030:{f.Push(f.Locals[5]);f.Pc=1032;continue;}
case 1032:{f.Push(f.Locals[0]);f.Pc=1033;continue;}
case 1033:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1036;continue;}
case 1036:{return rt.Call(f,"forge/game/card/Card","getSuspectedStatic","()Lforge/game/staticability/StaticAbility;","invokevirtual",1039);}
case 1039:{f.Push(f.Locals[5]);f.Pc=1041;continue;}
case 1041:{f.Push(JValue.I(1));f.Pc=1042;continue;}
case 1042:{return rt.Call(f,"forge/game/staticability/StaticAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/staticability/StaticAbility;","invokevirtual",1045);}
case 1045:{return rt.Call(f,"forge/game/card/Card","setSuspectedStatic","(Lforge/game/staticability/StaticAbility;)V","invokevirtual",1048);}
case 1048:{f.Push(f.Locals[5]);f.Pc=1050;continue;}
case 1050:{f.Push(f.Locals[0]);f.Pc=1051;continue;}
case 1051:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1054;continue;}
case 1054:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",1057);}
case 1057:{return rt.Call(f,"forge/game/card/Card","setDamageHistory","(Lforge/game/card/CardDamageHistory;)V","invokevirtual",1060);}
case 1060:{f.Push(f.Locals[5]);f.Pc=1062;continue;}
case 1062:{f.Push(f.Locals[0]);f.Pc=1063;continue;}
case 1063:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1066;continue;}
case 1066:{return rt.Call(f,"forge/game/card/Card","getDamageReceivedThisTurn","()Ljava/util/List;","invokevirtual",1069);}
case 1069:{return rt.Call(f,"forge/game/card/Card","setDamageReceivedThisTurn","(Ljava/util/List;)V","invokevirtual",1072);}
case 1072:{f.Push(f.Locals[5]);f.Pc=1074;continue;}
case 1074:{f.Push(f.Locals[0]);f.Pc=1075;continue;}
case 1075:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1078;continue;}
case 1078:{return rt.Call(f,"forge/game/card/Card","getExcessDamageThisTurn","()I","invokevirtual",1081);}
case 1081:{return rt.Call(f,"forge/game/card/Card","setExcessDamageReceivedThisTurn","(I)V","invokevirtual",1084);}
case 1084:{f.Push(f.Locals[5]);f.Pc=1086;continue;}
case 1086:{return rt.Call(f,"forge/game/card/Card","getBlockedThisTurn","()Ljava/util/List;","invokevirtual",1089);}
case 1089:{f.Push(f.Locals[0]);f.Pc=1090;continue;}
case 1090:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1093;continue;}
case 1093:{return rt.Call(f,"forge/game/card/Card","getBlockedThisTurn","()Ljava/util/List;","invokevirtual",1096);}
case 1096:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",1101);}
case 1101:{f.StackOp("pop");f.Pc=1102;continue;}
case 1102:{f.Push(f.Locals[5]);f.Pc=1104;continue;}
case 1104:{return rt.Call(f,"forge/game/card/Card","getBlockedByThisTurn","()Ljava/util/List;","invokevirtual",1107);}
case 1107:{f.Push(f.Locals[0]);f.Pc=1108;continue;}
case 1108:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1111;continue;}
case 1111:{return rt.Call(f,"forge/game/card/Card","getBlockedByThisTurn","()Ljava/util/List;","invokevirtual",1114);}
case 1114:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",1119);}
case 1119:{f.StackOp("pop");f.Pc=1120;continue;}
case 1120:{f.Push(f.Locals[5]);f.Pc=1122;continue;}
case 1122:{f.Push(f.Locals[0]);f.Pc=1123;continue;}
case 1123:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1126;continue;}
case 1126:{return rt.Call(f,"forge/game/card/Card","getAttachedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",1129);}
case 1129:{f.Push(f.Locals[1]);f.Pc=1130;continue;}
case 1130:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopyList","(Ljava/lang/Iterable;Ljava/util/Map;)Ljava/util/List;","invokestatic",1133);}
case 1133:{return rt.Call(f,"forge/game/card/Card","setAttachedCards","(Ljava/lang/Iterable;)V","invokevirtual",1136);}
case 1136:{f.Push(f.Locals[5]);f.Pc=1138;continue;}
case 1138:{f.Push(f.Locals[0]);f.Pc=1139;continue;}
case 1139:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1142;continue;}
case 1142:{return rt.Call(f,"forge/game/card/Card","getEntityAttachedTo","()Lforge/game/GameEntity;","invokevirtual",1145);}
case 1145:{f.Push(f.Locals[1]);f.Pc=1146;continue;}
case 1146:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/GameEntity;Ljava/util/Map;)Lforge/game/GameEntity;","invokestatic",1149);}
case 1149:{return rt.Call(f,"forge/game/card/Card","setEntityAttachedTo","(Lforge/game/GameEntity;)V","invokevirtual",1152);}
case 1152:{f.Push(f.Locals[5]);f.Pc=1154;continue;}
case 1154:{f.Push(f.Locals[0]);f.Pc=1155;continue;}
case 1155:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1158;continue;}
case 1158:{return rt.Call(f,"forge/game/card/Card","getCopiedPermanent","()Lforge/game/card/Card;","invokevirtual",1161);}
case 1161:{return rt.Call(f,"forge/game/card/Card","setCopiedPermanent","(Lforge/game/card/Card;)V","invokevirtual",1164);}
case 1164:{f.Push(f.Locals[5]);f.Pc=1166;continue;}
case 1166:{f.Push(f.Locals[0]);f.Pc=1167;continue;}
case 1167:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1170;continue;}
case 1170:{return rt.Call(f,"forge/game/card/Card","getHaunting","()Lforge/game/card/Card;","invokevirtual",1173);}
case 1173:{return rt.Call(f,"forge/game/card/Card","setHaunting","(Lforge/game/card/Card;)V","invokevirtual",1176);}
case 1176:{f.Push(f.Locals[0]);f.Pc=1177;continue;}
case 1177:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1180;continue;}
case 1180:{return rt.Call(f,"forge/game/card/Card","getHauntedBy","()Lforge/game/card/CardCollectionView;","invokevirtual",1183);}
case 1183:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",1188);}
case 1188:{f.Locals[6]=f.Pop();f.Pc=1190;continue;}
case 1190:{f.Push(f.Locals[6]);f.Pc=1192;continue;}
case 1192:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1197);}
case 1197:{f.Pc=f.Pop().Int==0?1223:1200;continue;}
case 1200:{f.Push(f.Locals[6]);f.Pc=1202;continue;}
case 1202:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1207);}
case 1207:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1210;continue;}
case 1210:{f.Locals[7]=f.Pop();f.Pc=1212;continue;}
case 1212:{f.Push(f.Locals[5]);f.Pc=1214;continue;}
case 1214:{f.Push(f.Locals[7]);f.Pc=1216;continue;}
case 1216:{f.Push(JValue.I(0));f.Pc=1217;continue;}
case 1217:{return rt.Call(f,"forge/game/card/Card","addHauntedBy","(Lforge/game/card/Card;Z)V","invokevirtual",1220);}
case 1220:{f.Pc=1190;continue;}
case 1223:{f.Push(f.Locals[5]);f.Pc=1225;continue;}
case 1225:{f.Push(f.Locals[0]);f.Pc=1226;continue;}
case 1226:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1229;continue;}
case 1229:{f.Push(JValue.I(0));f.Pc=1230;continue;}
case 1230:{return rt.Call(f,"forge/game/card/Card","getIntensity","(Z)I","invokevirtual",1233);}
case 1233:{return rt.Call(f,"forge/game/card/Card","setIntensity","(I)V","invokevirtual",1236);}
case 1236:{f.Push(f.Locals[5]);f.Pc=1238;continue;}
case 1238:{f.Push(f.Locals[0]);f.Pc=1239;continue;}
case 1239:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1242;continue;}
case 1242:{f.Push(JValue.I(0));f.Pc=1243;continue;}
case 1243:{return rt.Call(f,"forge/game/card/Card","setPerpetual","(Lforge/game/card/Card;Z)V","invokevirtual",1246);}
case 1246:{f.Push(f.Locals[5]);f.Pc=1248;continue;}
case 1248:{f.Push(f.Locals[0]);f.Pc=1249;continue;}
case 1249:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1252;continue;}
case 1252:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",1255);}
case 1255:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1258);}
case 1258:{f.Push(f.Locals[5]);f.Pc=1260;continue;}
case 1260:{f.Push(f.Locals[0]);f.Pc=1261;continue;}
case 1261:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1264;continue;}
case 1264:{return rt.Call(f,"forge/game/card/Card","getImprintedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",1267);}
case 1267:{return rt.Call(f,"forge/game/card/Card","addImprintedCards","(Ljava/lang/Iterable;)V","invokevirtual",1270);}
case 1270:{f.Push(f.Locals[5]);f.Pc=1272;continue;}
case 1272:{f.Push(f.Locals[0]);f.Pc=1273;continue;}
case 1273:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1276;continue;}
case 1276:{return rt.Call(f,"forge/game/card/Card","getChosenCards","()Lforge/game/card/CardCollectionView;","invokevirtual",1279);}
case 1279:{return rt.Call(f,"forge/game/card/Card","setChosenCards","(Ljava/lang/Iterable;)V","invokevirtual",1282);}
case 1282:{f.Push(f.Locals[5]);f.Pc=1284;continue;}
case 1284:{f.Push(f.Locals[0]);f.Pc=1285;continue;}
case 1285:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1288;continue;}
case 1288:{return rt.Call(f,"forge/game/card/Card","getChosenType","()Ljava/lang/String;","invokevirtual",1291);}
case 1291:{return rt.Call(f,"forge/game/card/Card","setChosenType","(Ljava/lang/String;)V","invokevirtual",1294);}
case 1294:{f.Push(f.Locals[5]);f.Pc=1296;continue;}
case 1296:{f.Push(f.Locals[0]);f.Pc=1297;continue;}
case 1297:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1300;continue;}
case 1300:{return rt.Call(f,"forge/game/card/Card","getChosenType2","()Ljava/lang/String;","invokevirtual",1303);}
case 1303:{return rt.Call(f,"forge/game/card/Card","setChosenType2","(Ljava/lang/String;)V","invokevirtual",1306);}
case 1306:{f.Push(f.Locals[5]);f.Pc=1308;continue;}
case 1308:{f.Push(f.Locals[0]);f.Pc=1309;continue;}
case 1309:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1312;continue;}
case 1312:{return rt.Call(f,"forge/game/card/Card","getNamedCards","()Ljava/util/List;","invokevirtual",1315);}
case 1315:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",1318);}
case 1318:{return rt.Call(f,"forge/game/card/Card","setNamedCards","(Ljava/util/List;)V","invokevirtual",1321);}
case 1321:{f.Push(f.Locals[5]);f.Pc=1323;continue;}
case 1323:{f.Push(f.Locals[0]);f.Pc=1324;continue;}
case 1324:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1327;continue;}
case 1327:{return rt.Call(f,"forge/game/card/Card","getChosenColors","()Ljava/lang/Iterable;","invokevirtual",1330);}
case 1330:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",1333);}
case 1333:{return rt.Call(f,"forge/game/card/Card","setChosenColors","(Ljava/util/List;)V","invokevirtual",1336);}
case 1336:{f.Push(f.Locals[0]);f.Pc=1337;continue;}
case 1337:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1340;continue;}
case 1340:{return rt.Call(f,"forge/game/card/Card","hasChosenNumber","()Z","invokevirtual",1343);}
case 1343:{f.Pc=f.Pop().Int==0?1361:1346;continue;}
case 1346:{f.Push(f.Locals[5]);f.Pc=1348;continue;}
case 1348:{f.Push(f.Locals[0]);f.Pc=1349;continue;}
case 1349:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1352;continue;}
case 1352:{return rt.Call(f,"forge/game/card/Card","getChosenNumber","()Ljava/lang/Integer;","invokevirtual",1355);}
case 1355:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",1358);}
case 1358:{return rt.Call(f,"forge/game/card/Card","setChosenNumber","(I)V","invokevirtual",1361);}
case 1361:{f.Push(f.Locals[5]);f.Pc=1363;continue;}
case 1363:{f.Push(f.Locals[0]);f.Pc=1364;continue;}
case 1364:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1367;continue;}
case 1367:{return rt.Call(f,"forge/game/card/Card","getChosenEvenOdd","()Lforge/game/EvenOdd;","invokevirtual",1370);}
case 1370:{return rt.Call(f,"forge/game/card/Card","setChosenEvenOdd","(Lforge/game/EvenOdd;)V","invokevirtual",1373);}
case 1373:{f.Push(f.Locals[5]);f.Pc=1375;continue;}
case 1375:{f.Push(f.Locals[0]);f.Pc=1376;continue;}
case 1376:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1379;continue;}
case 1379:{return rt.Call(f,"forge/game/card/Card","getStoredKeywords","()Ljava/util/Map;","invokevirtual",1382);}
case 1382:{f.Push(JValue.I(1));f.Pc=1383;continue;}
case 1383:{return rt.Call(f,"forge/game/card/Card","setStoredKeywords","(Ljava/util/Map;Z)V","invokevirtual",1386);}
case 1386:{f.Push(f.Locals[5]);f.Pc=1388;continue;}
case 1388:{f.Push(f.Locals[0]);f.Pc=1389;continue;}
case 1389:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1392;continue;}
case 1392:{return rt.Call(f,"forge/game/card/Card","getStoredReplacements","()Lcom/google/common/collect/Table;","invokevirtual",1395);}
case 1395:{return rt.Call(f,"forge/game/card/Card","setStoredReplacements","(Lcom/google/common/collect/Table;)V","invokevirtual",1398);}
case 1398:{f.Push(f.Locals[5]);f.Pc=1400;continue;}
case 1400:{f.Push(f.Locals[0]);f.Pc=1401;continue;}
case 1401:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1404;continue;}
case 1404:{return rt.Call(f,"forge/game/card/Card","copyChangedTextFrom","(Lforge/game/card/Card;)V","invokevirtual",1407);}
case 1407:{f.Push(f.Locals[5]);f.Pc=1409;continue;}
case 1409:{f.Push(f.Locals[0]);f.Pc=1410;continue;}
case 1410:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1413;continue;}
case 1413:{f.Push(rt.GetField(f.Pop(),"forge/game/card/Card","changedCardKeywordsByWord","Lforge/game/keyword/KeywordsChange;"));f.Pc=1416;continue;}
case 1416:{f.Push(f.Locals[5]);f.Pc=1418;continue;}
case 1418:{f.Push(JValue.I(1));f.Pc=1419;continue;}
case 1419:{return rt.Call(f,"forge/game/keyword/KeywordsChange","copy","(Lforge/game/card/Card;Z)Lforge/game/keyword/KeywordsChange;","invokevirtual",1422);}
case 1422:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/Card","changedCardKeywordsByWord","Lforge/game/keyword/KeywordsChange;",value);f.Pc=1425;continue;}
case 1425:{f.Push(f.Locals[5]);f.Pc=1427;continue;}
case 1427:{f.Push(f.Locals[0]);f.Pc=1428;continue;}
case 1428:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1431;continue;}
case 1431:{return rt.Call(f,"forge/game/card/Card","getGameTimestamp","()J","invokevirtual",1434);}
case 1434:{return rt.Call(f,"forge/game/card/Card","setGameTimestamp","(J)V","invokevirtual",1437);}
case 1437:{f.Push(f.Locals[5]);f.Pc=1439;continue;}
case 1439:{f.Push(f.Locals[0]);f.Pc=1440;continue;}
case 1440:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1443;continue;}
case 1443:{return rt.Call(f,"forge/game/card/Card","getLayerTimestamp","()J","invokevirtual",1446);}
case 1446:{return rt.Call(f,"forge/game/card/Card","setLayerTimestamp","(J)V","invokevirtual",1449);}
case 1449:{f.Push(f.Locals[5]);f.Pc=1451;continue;}
case 1451:{f.Push(f.Locals[0]);f.Pc=1452;continue;}
case 1452:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1455;continue;}
case 1455:{return rt.Call(f,"forge/game/card/Card","getBestowTimestamp","()J","invokevirtual",1458);}
case 1458:{return rt.Call(f,"forge/game/card/Card","setBestowTimestamp","(J)V","invokevirtual",1461);}
case 1461:{f.Push(f.Locals[5]);f.Pc=1463;continue;}
case 1463:{f.Push(f.Locals[0]);f.Pc=1464;continue;}
case 1464:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1467;continue;}
case 1467:{return rt.Call(f,"forge/game/card/Card","getTurnInZone","()I","invokevirtual",1470);}
case 1470:{return rt.Call(f,"forge/game/card/Card","setTurnInZone","(I)V","invokevirtual",1473);}
case 1473:{f.Push(f.Locals[5]);f.Pc=1475;continue;}
case 1475:{f.Push(f.Locals[0]);f.Pc=1476;continue;}
case 1476:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1479;continue;}
case 1479:{return rt.Call(f,"forge/game/card/Card","isForetold","()Z","invokevirtual",1482);}
case 1482:{return rt.Call(f,"forge/game/card/Card","setForetold","(Z)V","invokevirtual",1485);}
case 1485:{f.Push(f.Locals[5]);f.Pc=1487;continue;}
case 1487:{f.Push(f.Locals[0]);f.Pc=1488;continue;}
case 1488:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1491;continue;}
case 1491:{return rt.Call(f,"forge/game/card/Card","isForetoldCostByEffect","()Z","invokevirtual",1494);}
case 1494:{return rt.Call(f,"forge/game/card/Card","setForetoldCostByEffect","(Z)V","invokevirtual",1497);}
case 1497:{f.Push(f.Locals[5]);f.Pc=1499;continue;}
case 1499:{f.Push(f.Locals[0]);f.Pc=1500;continue;}
case 1500:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1503;continue;}
case 1503:{return rt.Call(f,"forge/game/card/Card","isPlotted","()Z","invokevirtual",1506);}
case 1506:{return rt.Call(f,"forge/game/card/Card","setPlotted","(Z)Z","invokevirtual",1509);}
case 1509:{f.StackOp("pop");f.Pc=1510;continue;}
case 1510:{f.Push(f.Locals[5]);f.Pc=1512;continue;}
case 1512:{f.Push(f.Locals[0]);f.Pc=1513;continue;}
case 1513:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1516;continue;}
case 1516:{return rt.Call(f,"forge/game/card/Card","getPrepared","()Lforge/game/card/Card;","invokevirtual",1519);}
case 1519:{return rt.Call(f,"forge/game/card/Card","setPrepared","(Lforge/game/card/Card;)V","invokevirtual",1522);}
case 1522:{f.Push(f.Locals[5]);f.Pc=1524;continue;}
case 1524:{f.Push(f.Locals[0]);f.Pc=1525;continue;}
case 1525:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1528;continue;}
case 1528:{return rt.Call(f,"forge/game/card/Card","getMeldedWith","()Lforge/game/card/Card;","invokevirtual",1531);}
case 1531:{f.Push(f.Locals[1]);f.Pc=1532;continue;}
case 1532:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;Ljava/util/Map;)Lforge/game/card/Card;","invokestatic",1535);}
case 1535:{return rt.Call(f,"forge/game/card/Card","setMeldedWith","(Lforge/game/card/Card;)V","invokevirtual",1538);}
case 1538:{f.Push(f.Locals[5]);f.Pc=1540;continue;}
case 1540:{return rt.Call(f,"forge/game/card/Card","getStates","()Ljava/util/Set;","invokevirtual",1543);}
case 1543:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",1548);}
case 1548:{f.Locals[6]=f.Pop();f.Pc=1550;continue;}
case 1550:{f.Push(f.Locals[6]);f.Pc=1552;continue;}
case 1552:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1557);}
case 1557:{f.Pc=f.Pop().Int==0?1587:1560;continue;}
case 1560:{f.Push(f.Locals[6]);f.Pc=1562;continue;}
case 1562:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1567);}
case 1567:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardStateName"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1570;continue;}
case 1570:{f.Locals[7]=f.Pop();f.Pc=1572;continue;}
case 1572:{f.Push(f.Locals[5]);f.Pc=1574;continue;}
case 1574:{f.Push(f.Locals[5]);f.Pc=1576;continue;}
case 1576:{f.Push(f.Locals[7]);f.Pc=1578;continue;}
case 1578:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",1581);}
case 1581:{return rt.Call(f,"forge/game/card/Card","updateKeywordsCache","(Lforge/game/card/CardState;)V","invokevirtual",1584);}
case 1584:{f.Pc=1550;continue;}
case 1587:{f.Push(f.Locals[0]);f.Pc=1588;continue;}
case 1588:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1591;continue;}
case 1591:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",1594);}
case 1594:{f.Pc=f.Pop().Reference==null?1635:1597;continue;}
case 1597:{f.Push(f.Locals[0]);f.Pc=1598;continue;}
case 1598:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1601;continue;}
case 1601:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",1604);}
case 1604:{f.Push(f.Locals[5]);f.Pc=1606;continue;}
case 1606:{f.Push(JValue.I(1));f.Pc=1607;continue;}
case 1607:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",1610);}
case 1610:{f.Locals[6]=f.Pop();f.Pc=1612;continue;}
case 1612:{f.Push(f.Locals[6]);f.Pc=1614;continue;}
case 1614:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=1617;continue;}
case 1617:{return rt.Call(f,"forge/game/spellability/SpellAbility","setLastStateBattlefield","(Lforge/game/card/CardCollectionView;)V","invokevirtual",1620);}
case 1620:{f.Push(f.Locals[6]);f.Pc=1622;continue;}
case 1622:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=1625;continue;}
case 1625:{return rt.Call(f,"forge/game/spellability/SpellAbility","setLastStateGraveyard","(Lforge/game/card/CardCollectionView;)V","invokevirtual",1628);}
case 1628:{f.Push(f.Locals[5]);f.Pc=1630;continue;}
case 1630:{f.Push(f.Locals[6]);f.Pc=1632;continue;}
case 1632:{return rt.Call(f,"forge/game/card/Card","setCastSA","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1635);}
case 1635:{f.Push(f.Locals[5]);f.Pc=1637;continue;}
case 1637:{f.Push(f.Locals[0]);f.Pc=1638;continue;}
case 1638:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1641;continue;}
case 1641:{return rt.Call(f,"forge/game/card/Card","getCastFrom","()Lforge/game/zone/Zone;","invokevirtual",1644);}
case 1644:{return rt.Call(f,"forge/game/card/Card","setCastFrom","(Lforge/game/zone/Zone;)V","invokevirtual",1647);}
case 1647:{f.Push(f.Locals[5]);f.Pc=1649;continue;}
case 1649:{f.Push(f.Locals[0]);f.Pc=1650;continue;}
case 1650:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1653;continue;}
case 1653:{return rt.Call(f,"forge/game/card/Card","getExiledBy","()Lforge/game/player/Player;","invokevirtual",1656);}
case 1656:{return rt.Call(f,"forge/game/card/Card","setExiledBy","(Lforge/game/player/Player;)V","invokevirtual",1659);}
case 1659:{f.Push(f.Locals[5]);f.Pc=1661;continue;}
case 1661:{f.Push(f.Locals[0]);f.Pc=1662;continue;}
case 1662:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1665;continue;}
case 1665:{return rt.Call(f,"forge/game/card/Card","getExiledWith","()Lforge/game/card/Card;","invokevirtual",1668);}
case 1668:{f.Push(f.Locals[1]);f.Pc=1669;continue;}
case 1669:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;Ljava/util/Map;)Lforge/game/card/Card;","invokestatic",1672);}
case 1672:{return rt.Call(f,"forge/game/card/Card","setExiledWith","(Lforge/game/card/Card;)V","invokevirtual",1675);}
case 1675:{f.Push(f.Locals[5]);f.Pc=1677;continue;}
case 1677:{f.Push(f.Locals[0]);f.Pc=1678;continue;}
case 1678:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1681;continue;}
case 1681:{return rt.Call(f,"forge/game/card/Card","getExiledSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",1684);}
case 1684:{return rt.Call(f,"forge/game/card/Card","setExiledSA","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1687);}
case 1687:{f.Push(f.Locals[5]);f.Pc=1689;continue;}
case 1689:{f.Push(f.Locals[0]);f.Pc=1690;continue;}
case 1690:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1693;continue;}
case 1693:{return rt.Call(f,"forge/game/card/Card","getExiledCards","()Lforge/game/card/CardCollectionView;","invokevirtual",1696);}
case 1696:{return rt.Call(f,"forge/game/card/Card","addExiledCards","(Ljava/lang/Iterable;)V","invokevirtual",1699);}
case 1699:{f.Push(f.Locals[5]);f.Pc=1701;continue;}
case 1701:{f.Push(f.Locals[0]);f.Pc=1702;continue;}
case 1702:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1705;continue;}
case 1705:{return rt.Call(f,"forge/game/card/Card","wasDiscarded","()Z","invokevirtual",1708);}
case 1708:{return rt.Call(f,"forge/game/card/Card","setDiscarded","(Z)V","invokevirtual",1711);}
case 1711:{f.Push(f.Locals[5]);f.Pc=1713;continue;}
case 1713:{f.Push(f.Locals[0]);f.Pc=1714;continue;}
case 1714:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1717;continue;}
case 1717:{return rt.Call(f,"forge/game/card/Card","wasMilled","()Z","invokevirtual",1720);}
case 1720:{return rt.Call(f,"forge/game/card/Card","setMilled","(Z)V","invokevirtual",1723);}
case 1723:{f.Push(f.Locals[5]);f.Pc=1725;continue;}
case 1725:{f.Push(f.Locals[0]);f.Pc=1726;continue;}
case 1726:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1729;continue;}
case 1729:{return rt.Call(f,"forge/game/card/Card","wasSurveilled","()Z","invokevirtual",1732);}
case 1732:{return rt.Call(f,"forge/game/card/Card","setSurveilled","(Z)V","invokevirtual",1735);}
case 1735:{f.Push(f.Locals[5]);f.Pc=1737;continue;}
case 1737:{return rt.Call(f,"forge/game/card/Card","getAbilityActivatedThisTurn","()Lforge/game/card/ActivationTable;","invokevirtual",1740);}
case 1740:{f.Push(f.Locals[0]);f.Pc=1741;continue;}
case 1741:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1744;continue;}
case 1744:{return rt.Call(f,"forge/game/card/Card","getAbilityActivatedThisTurn","()Lforge/game/card/ActivationTable;","invokevirtual",1747);}
case 1747:{return rt.Call(f,"forge/game/card/ActivationTable","putAll","(Lcom/google/common/collect/Table;)V","invokevirtual",1750);}
case 1750:{f.Push(f.Locals[5]);f.Pc=1752;continue;}
case 1752:{return rt.Call(f,"forge/game/card/Card","getAbilityActivatedThisGame","()Lforge/game/card/ActivationTable;","invokevirtual",1755);}
case 1755:{f.Push(f.Locals[0]);f.Pc=1756;continue;}
case 1756:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1759;continue;}
case 1759:{return rt.Call(f,"forge/game/card/Card","getAbilityActivatedThisGame","()Lforge/game/card/ActivationTable;","invokevirtual",1762);}
case 1762:{return rt.Call(f,"forge/game/card/ActivationTable","putAll","(Lcom/google/common/collect/Table;)V","invokevirtual",1765);}
case 1765:{f.Push(f.Locals[5]);f.Pc=1767;continue;}
case 1767:{return rt.Call(f,"forge/game/card/Card","getAbilityResolvedThisTurn","()Lforge/game/card/ActivationTable;","invokevirtual",1770);}
case 1770:{f.Push(f.Locals[0]);f.Pc=1771;continue;}
case 1771:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1774;continue;}
case 1774:{return rt.Call(f,"forge/game/card/Card","getAbilityResolvedThisTurn","()Lforge/game/card/ActivationTable;","invokevirtual",1777);}
case 1777:{return rt.Call(f,"forge/game/card/ActivationTable","putAll","(Lcom/google/common/collect/Table;)V","invokevirtual",1780);}
case 1780:{f.Push(f.Locals[0]);f.Pc=1781;continue;}
case 1781:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1784;continue;}
case 1784:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",1787);}
case 1787:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",1790);}
case 1790:{f.Pc=f.Pop().Reference==null?1823:1793;continue;}
case 1793:{f.Push(f.Locals[0]);f.Pc=1794;continue;}
case 1794:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1797;continue;}
case 1797:{return rt.Call(f,"forge/game/card/Card","isPermanent","()Z","invokevirtual",1800);}
case 1800:{f.Pc=f.Pop().Int==0?1823:1803;continue;}
case 1803:{f.Push(f.Locals[5]);f.Pc=1805;continue;}
case 1805:{f.Push(f.Locals[0]);f.Pc=1806;continue;}
case 1806:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1809;continue;}
case 1809:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",1812);}
case 1812:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",1815);}
case 1815:{f.Push(f.Locals[5]);f.Pc=1817;continue;}
case 1817:{return rt.Call(f,"forge/game/combat/Combat","saveLKI","(Lforge/game/card/Card;)Lforge/game/combat/CombatLki;","invokevirtual",1820);}
case 1820:{return rt.Call(f,"forge/game/card/Card","setCombatLKI","(Lforge/game/combat/CombatLki;)V","invokevirtual",1823);}
case 1823:{f.Push(f.Locals[5]);f.Pc=1825;continue;}
case 1825:{return rt.Call(f,"forge/game/card/Card","getGoadMap","()Ljava/util/Map;","invokevirtual",1828);}
case 1828:{f.Push(f.Locals[0]);f.Pc=1829;continue;}
case 1829:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCopyService","copyFrom","Lforge/game/card/Card;"));f.Pc=1832;continue;}
case 1832:{return rt.Call(f,"forge/game/card/Card","getGoadMap","()Ljava/util/Map;","invokevirtual",1835);}
case 1835:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",1840);}
case 1840:{f.Push(f.Locals[5]);f.Pc=1842;continue;}
case 1842:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

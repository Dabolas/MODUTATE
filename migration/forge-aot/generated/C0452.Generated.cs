// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C452{
internal static JClass Build(){var c=new JClass("forge/game/card/CardFactory","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(4990,"forge/game/card/CardFactory","<init>","()V",1,1,1,new JHandler[]{},M4990));
c.Add(new JMethod(4991,"forge/game/card/CardFactory","copySpellHost","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/card/Card;",10,8,4,new JHandler[]{},M4991));
c.Add(new JMethod(4992,"forge/game/card/CardFactory","copySpellAbilityAndPossiblyHost","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;",25,6,5,new JHandler[]{},M4992));
c.Add(new JMethod(4993,"forge/game/card/CardFactory","getCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;Lforge/game/Game;)Lforge/game/card/Card;",9,3,4,new JHandler[]{},M4993));
c.Add(new JMethod(4994,"forge/game/card/CardFactory","getCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;ILforge/game/Game;)Lforge/game/card/Card;",9,6,3,new JHandler[]{},M4994));
c.Add(new JMethod(4995,"forge/game/card/CardFactory","buildAbilities","(Lforge/game/card/Card;)V",10,3,3,new JHandler[]{},M4995));
c.Add(new JMethod(4996,"forge/game/card/CardFactory","buildBattleAbilities","(Lforge/game/card/Card;)V",10,4,3,new JHandler[]{},M4996));
c.Add(new JMethod(4997,"forge/game/card/CardFactory","readCard","(Lforge/item/IPaperCard;ILforge/game/Game;)Lforge/game/card/Card;",10,8,5,new JHandler[]{},M4997));
c.Add(new JMethod(4998,"forge/game/card/CardFactory","readCardFace","(Lforge/game/card/Card;Lforge/card/ICardFace;)V",10,5,6,new JHandler[]{},M4998));
c.Add(new JMethod(4999,"forge/game/card/CardFactory","copySpellAbility","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;ZZ)V",9,8,7,new JHandler[]{},M4999));
c.Add(new JMethod(5000,"forge/game/card/CardFactory","getCopiedTriggeredAbility","(Lforge/game/trigger/WrappedAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;",9,3,7,new JHandler[]{},M5000));
c.Add(new JMethod(5001,"forge/game/card/CardFactory","getCloneStates","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCloneStates;",9,26,5,new JHandler[]{},M5001));
c.Add(new JMethod(5002,"forge/game/card/CardFactory","getMutatedCloneStates","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCloneStates;",9,8,4,new JHandler[]{},M5002));
c.Add(new JMethod(5003,"forge/game/card/CardFactory","lambda$getCloneStates$2","(Lforge/game/card/CardState;Ljava/lang/String;)Z",4106,2,2,new JHandler[]{},M5003));
c.Add(new JMethod(5004,"forge/game/card/CardFactory","lambda$copySpellAbility$1","(Lforge/game/card/Card;Lforge/game/player/Player;ZZLforge/game/spellability/AbilitySub;)Lforge/game/spellability/AbilitySub;",4106,5,5,new JHandler[]{},M5004));
c.Add(new JMethod(5005,"forge/game/card/CardFactory","lambda$buildBattleAbilities$0","(Lforge/game/replacement/ReplacementEffect;)Z",4106,1,2,new JHandler[]{},M5005));
}

internal static JStep M4990(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4991(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",9);}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",15);}
case 15:{f.Locals[5]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[5]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/Game","nextCardId","()I","invokevirtual",22);}
case 22:{f.Locals[6]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",29);}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[6]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/card/CardFactory","getCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;ILforge/game/Game;)Lforge/game/card/Card;","invokestatic",37);}
case 37:{f.Locals[7]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[7]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[7]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/card/CardFactory","getCloneStates","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCloneStates;","invokestatic",49);}
case 49:{return rt.Call(f,"forge/game/card/Card","setStates","(Ljava/util/Map;)V","invokevirtual",52);}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/card/Card","isTransformable","()Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?98:60;continue;}
case 60:{f.Push(f.Locals[7]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/card/Card","isTransformed","()Z","invokevirtual",67);}
case 67:{f.Pc=f.Pop().Int==0?76:70;continue;}
case 70:{if(!rt.StaticReady(f,"forge/card/CardStateName","Backside","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Backside","Lforge/card/CardStateName;"));f.Pc=73;continue;}
case 73:{f.Pc=79;continue;}
case 76:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=79;continue;}
case 79:{f.Push(JValue.I(1));f.Pc=80;continue;}
case 80:{f.Push(JValue.I(1));f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;ZZ)Z","invokevirtual",84);}
case 84:{f.StackOp("pop");f.Pc=85;continue;}
case 85:{f.Push(f.Locals[7]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/card/Card","isBackSide","()Z","invokevirtual",92);}
case 92:{return rt.Call(f,"forge/game/card/Card","setBackSide","(Z)V","invokevirtual",95);}
case 95:{f.Pc=111;continue;}
case 98:{f.Push(f.Locals[7]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[7]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",105);}
case 105:{f.Push(JValue.I(1));f.Pc=106;continue;}
case 106:{f.Push(JValue.I(1));f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;ZZ)Z","invokevirtual",110);}
case 110:{f.StackOp("pop");f.Pc=111;continue;}
case 111:{f.Push(f.Locals[7]);f.Pc=113;continue;}
case 113:{if(!rt.StaticReady(f,"forge/card/GamePieceType","COPIED_SPELL","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","COPIED_SPELL","Lforge/card/GamePieceType;"));f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/card/Card","setGamePieceType","(Lforge/card/GamePieceType;)V","invokevirtual",119);}
case 119:{f.Push(f.Locals[7]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[4]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/card/Card","setCopiedPermanent","(Lforge/game/card/Card;)V","invokevirtual",126);}
case 126:{f.Push(f.Locals[7]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[4]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/card/Card","getXManaCostPaidByColor","()Ljava/util/Map;","invokevirtual",133);}
case 133:{return rt.Call(f,"forge/game/card/Card","setXManaCostPaidByColor","(Ljava/util/Map;)V","invokevirtual",136);}
case 136:{f.Push(f.Locals[7]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[4]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/card/Card","getPromisedGift","()Lforge/game/player/Player;","invokevirtual",143);}
case 143:{return rt.Call(f,"forge/game/card/Card","setPromisedGift","(Lforge/game/player/Player;)V","invokevirtual",146);}
case 146:{f.Push(f.Locals[1]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/spellability/SpellAbility","isBestow","()Z","invokevirtual",150);}
case 150:{f.Pc=f.Pop().Int==0?158:153;continue;}
case 153:{f.Push(f.Locals[7]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/card/Card","animateBestow","()V","invokevirtual",158);}
case 158:{f.Push(f.Locals[0]);f.Pc=159;continue;}
case 159:{f.Push(JValue.R(rt.String("RememberNewCard")));f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",164);}
case 164:{f.Pc=f.Pop().Int==0?173:167;continue;}
case 167:{f.Push(f.Locals[3]);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[7]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",173);}
case 173:{f.Push(f.Locals[7]);f.Pc=175;continue;}
case 175:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4992(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?25:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("UseOriginalHost")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int!=0?25:16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/CardFactory","copySpellHost","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",22);}
case 22:{f.Pc=29;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",29);}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?58:37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","isWrapper","()Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int==0?58:44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/WrappedAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/card/CardFactory","getCopiedTriggeredAbility","(Lforge/game/trigger/WrappedAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;","invokestatic",53);}
case 53:{f.Locals[4]=f.Pop();f.Pc=55;continue;}
case 55:{f.Pc=106;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Lforge/game/player/Player;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",65);}
case 65:{f.Locals[4]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[4]);f.Pc=69;continue;}
case 69:{f.Push(JValue.I(0));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCastFromPlayEffect","(Z)V","invokevirtual",73);}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",77);}
case 77:{f.Pc=f.Pop().Reference==null?106:80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",84);}
case 84:{f.Push(f.Locals[3]);f.Pc=85;continue;}
case 85:{f.Push(JValue.I(0));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/keyword/KeywordInterface","copy","(Lforge/game/card/Card;Z)Lforge/game/keyword/KeywordInterface;","invokeinterface",91);}
case 91:{f.Locals[5]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[4]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[5]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/spellability/SpellAbility","setKeyword","(Lforge/game/keyword/KeywordInterface;)V","invokevirtual",100);}
case 100:{f.Push(f.Locals[3]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[5]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/card/Card","addKeywordForStaticAbility","(Lforge/game/keyword/KeywordInterface;)V","invokevirtual",106);}
case 106:{f.Push(f.Locals[4]);f.Pc=108;continue;}
case 108:{f.Push(JValue.I(1));f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCopied","(Z)V","invokevirtual",112);}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",116);}
case 116:{f.Pc=f.Pop().Int==0?125:119;continue;}
case 119:{f.Push(f.Locals[4]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[1]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/spellability/SpellAbility","setOriginalAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",125);}
case 125:{f.Push(f.Locals[4]);f.Pc=127;continue;}
case 127:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/Spell")?1:0));f.Pc=130;continue;}
case 130:{f.Pc=f.Pop().Int==0?152:133;continue;}
case 133:{f.Push(f.Locals[4]);f.Pc=135;continue;}
case 135:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/Spell"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=138;continue;}
case 138:{f.Locals[5]=f.Pop();f.Pc=140;continue;}
case 140:{f.Push(f.Locals[5]);f.Pc=142;continue;}
case 142:{f.Push(JValue.I(0));f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/spellability/Spell","setCastFaceDown","(Z)V","invokevirtual",146);}
case 146:{f.Push(f.Locals[3]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[4]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/card/Card","setCastSA","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",152);}
case 152:{f.Push(f.Locals[4]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/spellability/SpellAbility","clearManaPaid","()V","invokevirtual",157);}
case 157:{f.Push(f.Locals[4]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",162);}
case 162:{f.Pc=f.Pop().Int!=0?183:165;continue;}
case 165:{f.Push(f.Locals[4]);f.Pc=167;continue;}
case 167:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=170;continue;}
case 170:{f.StackOp("dup");f.Pc=171;continue;}
case 171:{f.Push(JValue.R(rt.String("")));f.Pc=173;continue;}
case 173:{f.Push(f.Locals[1]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",177);}
case 177:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",180);}
case 180:{return rt.Call(f,"forge/game/spellability/SpellAbility","setPayCosts","(Lforge/game/cost/Cost;)V","invokevirtual",183);}
case 183:{f.Push(f.Locals[4]);f.Pc=185;continue;}
case 185:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4993(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Reference!=null?10:6;continue;}
case 6:{f.Push(JValue.I(-1));f.Pc=7;continue;}
case 7:{f.Pc=17;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/Game","nextCardId","()I","invokevirtual",17);}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/CardFactory","getCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;ILforge/game/Game;)Lforge/game/card/Card;","invokestatic",21);}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4994(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[3]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/CardFactory","readCard","(Lforge/item/IPaperCard;ILforge/game/Game;)Lforge/game/card/Card;","invokestatic",6);}
case 6:{f.Locals[4]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[4]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","setOwner","(Lforge/game/player/Player;)V","invokevirtual",14);}
case 14:{f.Push(f.Locals[4]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardFactory","buildAbilities","(Lforge/game/card/Card;)V","invokestatic",19);}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/item/IPaperCard","getEdition","()Ljava/lang/String;","invokeinterface",27);}
case 27:{return rt.Call(f,"forge/game/card/Card","setSetCode","(Ljava/lang/String;)V","invokevirtual",30);}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/item/IPaperCard","getRarity","()Lforge/card/CardRarity;","invokeinterface",38);}
case 38:{return rt.Call(f,"forge/game/card/Card","setRarity","(Lforge/card/CardRarity;)V","invokevirtual",41);}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/item/IPaperCard","getImageKey","(Z)Ljava/lang/String;","invokeinterface",48);}
case 48:{f.Locals[5]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[5]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/card/Card","setImageKey","(Ljava/lang/String;)V","invokevirtual",57);}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/item/IPaperCard","isToken","()Z","invokeinterface",63);}
case 63:{f.Pc=f.Pop().Int==0?77:66;continue;}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{if(!rt.StaticReady(f,"forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/card/Card","setGamePieceType","(Lforge/card/GamePieceType;)V","invokevirtual",74);}
case 74:{f.Pc=93;continue;}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[4]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/Card","getRules","()Lforge/card/CardRules;","invokevirtual",84);}
case 84:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",87);}
case 87:{return rt.Call(f,"forge/card/CardType","getGamePieceType","()Lforge/card/GamePieceType;","invokevirtual",90);}
case 90:{return rt.Call(f,"forge/game/card/Card","setGamePieceType","(Lforge/card/GamePieceType;)V","invokevirtual",93);}
case 93:{f.Push(f.Locals[4]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/card/Card","hasAlternateState","()Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?590:101;continue;}
case 101:{f.Push(f.Locals[4]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/card/Card","isFlipCard","()Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?134:109;continue;}
case 109:{f.Push(f.Locals[4]);f.Pc=111;continue;}
case 111:{if(!rt.StaticReady(f,"forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"));f.Pc=114;continue;}
case 114:{f.Push(JValue.I(0));f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",118);}
case 118:{f.StackOp("pop");f.Pc=119;continue;}
case 119:{f.Push(f.Locals[4]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{f.Push(JValue.I(0));f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/item/IPaperCard","getImageKey","(Z)Ljava/lang/String;","invokeinterface",128);}
case 128:{return rt.Call(f,"forge/game/card/Card","setImageKey","(Ljava/lang/String;)V","invokevirtual",131);}
case 131:{f.Pc=558;continue;}
case 134:{f.Push(f.Locals[4]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/card/Card","isDoubleFaced","()Z","invokevirtual",139);}
case 139:{f.Pc=f.Pop().Int==0?176:142;continue;}
case 142:{f.Push(f.Locals[4]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[0]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/item/IPaperCard","getRules","()Lforge/card/CardRules;","invokeinterface",150);}
case 150:{return rt.Call(f,"forge/card/CardRules","getSplitType","()Lforge/card/CardSplitType;","invokevirtual",153);}
case 153:{return rt.Call(f,"forge/card/CardSplitType","getChangedStateName","()Lforge/card/CardStateName;","invokevirtual",156);}
case 156:{f.Push(JValue.I(0));f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",160);}
case 160:{f.StackOp("pop");f.Pc=161;continue;}
case 161:{f.Push(f.Locals[4]);f.Pc=163;continue;}
case 163:{f.Push(f.Locals[0]);f.Pc=164;continue;}
case 164:{f.Push(JValue.I(1));f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/item/IPaperCard","getImageKey","(Z)Ljava/lang/String;","invokeinterface",170);}
case 170:{return rt.Call(f,"forge/game/card/Card","setImageKey","(Ljava/lang/String;)V","invokevirtual",173);}
case 173:{f.Pc=558;continue;}
case 176:{f.Push(f.Locals[4]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/card/Card","isSplitCard","()Z","invokevirtual",181);}
case 181:{f.Pc=f.Pop().Int==0?243:184;continue;}
case 184:{f.Push(f.Locals[4]);f.Pc=186;continue;}
case 186:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=189;continue;}
case 189:{f.Push(JValue.I(0));f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",193);}
case 193:{f.StackOp("pop");f.Pc=194;continue;}
case 194:{f.Push(f.Locals[4]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[5]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/card/Card","setImageKey","(Ljava/lang/String;)V","invokevirtual",201);}
case 201:{f.Push(f.Locals[4]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[0]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/item/IPaperCard","getEdition","()Ljava/lang/String;","invokeinterface",209);}
case 209:{return rt.Call(f,"forge/game/card/Card","setSetCode","(Ljava/lang/String;)V","invokevirtual",212);}
case 212:{f.Push(f.Locals[4]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[0]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/item/IPaperCard","getRarity","()Lforge/card/CardRarity;","invokeinterface",220);}
case 220:{return rt.Call(f,"forge/game/card/Card","setRarity","(Lforge/card/CardRarity;)V","invokevirtual",223);}
case 223:{f.Push(f.Locals[4]);f.Pc=225;continue;}
case 225:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=228;continue;}
case 228:{f.Push(JValue.I(0));f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",232);}
case 232:{f.StackOp("pop");f.Pc=233;continue;}
case 233:{f.Push(f.Locals[4]);f.Pc=235;continue;}
case 235:{f.Push(f.Locals[5]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/game/card/Card","setImageKey","(Ljava/lang/String;)V","invokevirtual",240);}
case 240:{f.Pc=558;continue;}
case 243:{f.Push(f.Locals[4]);f.Pc=245;continue;}
case 245:{if(!rt.StaticReady(f,"forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"));f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",251);}
case 251:{f.Pc=f.Pop().Int==0?274:254;continue;}
case 254:{f.Push(f.Locals[4]);f.Pc=256;continue;}
case 256:{if(!rt.StaticReady(f,"forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"));f.Pc=259;continue;}
case 259:{f.Push(JValue.I(0));f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",263);}
case 263:{f.StackOp("pop");f.Pc=264;continue;}
case 264:{f.Push(f.Locals[4]);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[5]);f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/card/Card","setImageKey","(Ljava/lang/String;)V","invokevirtual",271);}
case 271:{f.Pc=558;continue;}
case 274:{f.Push(f.Locals[4]);f.Pc=276;continue;}
case 276:{if(!rt.StaticReady(f,"forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"));f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",282);}
case 282:{f.Pc=f.Pop().Int==0?305:285;continue;}
case 285:{f.Push(f.Locals[4]);f.Pc=287;continue;}
case 287:{if(!rt.StaticReady(f,"forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"));f.Pc=290;continue;}
case 290:{f.Push(JValue.I(0));f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",294);}
case 294:{f.StackOp("pop");f.Pc=295;continue;}
case 295:{f.Push(f.Locals[4]);f.Pc=297;continue;}
case 297:{f.Push(f.Locals[5]);f.Pc=299;continue;}
case 299:{return rt.Call(f,"forge/game/card/Card","setImageKey","(Ljava/lang/String;)V","invokevirtual",302);}
case 302:{f.Pc=558;continue;}
case 305:{f.Push(f.Locals[4]);f.Pc=307;continue;}
case 307:{return rt.Call(f,"forge/game/card/Card","canSpecialize","()Z","invokevirtual",310);}
case 310:{f.Pc=f.Pop().Int==0?558:313;continue;}
case 313:{f.Push(f.Locals[4]);f.Pc=315;continue;}
case 315:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeW","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","SpecializeW","Lforge/card/CardStateName;"));f.Pc=318;continue;}
case 318:{f.Push(JValue.I(0));f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",322);}
case 322:{f.StackOp("pop");f.Pc=323;continue;}
case 323:{f.Push(f.Locals[4]);f.Pc=325;continue;}
case 325:{f.Push(f.Locals[0]);f.Pc=326;continue;}
case 326:{f.Push(JValue.I(0));f.Pc=327;continue;}
case 327:{return rt.Call(f,"forge/item/IPaperCard","getImageKey","(Z)Ljava/lang/String;","invokeinterface",332);}
case 332:{return rt.DynamicCall(f,"forge/game/card/CardFactory:4994:332:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",337);}
case 337:{return rt.Call(f,"forge/game/card/Card","setImageKey","(Ljava/lang/String;)V","invokevirtual",340);}
case 340:{f.Push(f.Locals[4]);f.Pc=342;continue;}
case 342:{f.Push(f.Locals[0]);f.Pc=343;continue;}
case 343:{return rt.Call(f,"forge/item/IPaperCard","getEdition","()Ljava/lang/String;","invokeinterface",348);}
case 348:{return rt.Call(f,"forge/game/card/Card","setSetCode","(Ljava/lang/String;)V","invokevirtual",351);}
case 351:{f.Push(f.Locals[4]);f.Pc=353;continue;}
case 353:{f.Push(f.Locals[0]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/item/IPaperCard","getRarity","()Lforge/card/CardRarity;","invokeinterface",359);}
case 359:{return rt.Call(f,"forge/game/card/Card","setRarity","(Lforge/card/CardRarity;)V","invokevirtual",362);}
case 362:{f.Push(f.Locals[4]);f.Pc=364;continue;}
case 364:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeU","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","SpecializeU","Lforge/card/CardStateName;"));f.Pc=367;continue;}
case 367:{f.Push(JValue.I(0));f.Pc=368;continue;}
case 368:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",371);}
case 371:{f.StackOp("pop");f.Pc=372;continue;}
case 372:{f.Push(f.Locals[4]);f.Pc=374;continue;}
case 374:{f.Push(f.Locals[0]);f.Pc=375;continue;}
case 375:{f.Push(JValue.I(0));f.Pc=376;continue;}
case 376:{return rt.Call(f,"forge/item/IPaperCard","getImageKey","(Z)Ljava/lang/String;","invokeinterface",381);}
case 381:{return rt.DynamicCall(f,"forge/game/card/CardFactory:4994:381:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",386);}
case 386:{return rt.Call(f,"forge/game/card/Card","setImageKey","(Ljava/lang/String;)V","invokevirtual",389);}
case 389:{f.Push(f.Locals[4]);f.Pc=391;continue;}
case 391:{f.Push(f.Locals[0]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/item/IPaperCard","getEdition","()Ljava/lang/String;","invokeinterface",397);}
case 397:{return rt.Call(f,"forge/game/card/Card","setSetCode","(Ljava/lang/String;)V","invokevirtual",400);}
case 400:{f.Push(f.Locals[4]);f.Pc=402;continue;}
case 402:{f.Push(f.Locals[0]);f.Pc=403;continue;}
case 403:{return rt.Call(f,"forge/item/IPaperCard","getRarity","()Lforge/card/CardRarity;","invokeinterface",408);}
case 408:{return rt.Call(f,"forge/game/card/Card","setRarity","(Lforge/card/CardRarity;)V","invokevirtual",411);}
case 411:{f.Push(f.Locals[4]);f.Pc=413;continue;}
case 413:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeB","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","SpecializeB","Lforge/card/CardStateName;"));f.Pc=416;continue;}
case 416:{f.Push(JValue.I(0));f.Pc=417;continue;}
case 417:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",420);}
case 420:{f.StackOp("pop");f.Pc=421;continue;}
case 421:{f.Push(f.Locals[4]);f.Pc=423;continue;}
case 423:{f.Push(f.Locals[0]);f.Pc=424;continue;}
case 424:{f.Push(JValue.I(0));f.Pc=425;continue;}
case 425:{return rt.Call(f,"forge/item/IPaperCard","getImageKey","(Z)Ljava/lang/String;","invokeinterface",430);}
case 430:{return rt.DynamicCall(f,"forge/game/card/CardFactory:4994:430:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",435);}
case 435:{return rt.Call(f,"forge/game/card/Card","setImageKey","(Ljava/lang/String;)V","invokevirtual",438);}
case 438:{f.Push(f.Locals[4]);f.Pc=440;continue;}
case 440:{f.Push(f.Locals[0]);f.Pc=441;continue;}
case 441:{return rt.Call(f,"forge/item/IPaperCard","getEdition","()Ljava/lang/String;","invokeinterface",446);}
case 446:{return rt.Call(f,"forge/game/card/Card","setSetCode","(Ljava/lang/String;)V","invokevirtual",449);}
case 449:{f.Push(f.Locals[4]);f.Pc=451;continue;}
case 451:{f.Push(f.Locals[0]);f.Pc=452;continue;}
case 452:{return rt.Call(f,"forge/item/IPaperCard","getRarity","()Lforge/card/CardRarity;","invokeinterface",457);}
case 457:{return rt.Call(f,"forge/game/card/Card","setRarity","(Lforge/card/CardRarity;)V","invokevirtual",460);}
case 460:{f.Push(f.Locals[4]);f.Pc=462;continue;}
case 462:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeR","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","SpecializeR","Lforge/card/CardStateName;"));f.Pc=465;continue;}
case 465:{f.Push(JValue.I(0));f.Pc=466;continue;}
case 466:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",469);}
case 469:{f.StackOp("pop");f.Pc=470;continue;}
case 470:{f.Push(f.Locals[4]);f.Pc=472;continue;}
case 472:{f.Push(f.Locals[0]);f.Pc=473;continue;}
case 473:{f.Push(JValue.I(0));f.Pc=474;continue;}
case 474:{return rt.Call(f,"forge/item/IPaperCard","getImageKey","(Z)Ljava/lang/String;","invokeinterface",479);}
case 479:{return rt.DynamicCall(f,"forge/game/card/CardFactory:4994:479:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",484);}
case 484:{return rt.Call(f,"forge/game/card/Card","setImageKey","(Ljava/lang/String;)V","invokevirtual",487);}
case 487:{f.Push(f.Locals[4]);f.Pc=489;continue;}
case 489:{f.Push(f.Locals[0]);f.Pc=490;continue;}
case 490:{return rt.Call(f,"forge/item/IPaperCard","getEdition","()Ljava/lang/String;","invokeinterface",495);}
case 495:{return rt.Call(f,"forge/game/card/Card","setSetCode","(Ljava/lang/String;)V","invokevirtual",498);}
case 498:{f.Push(f.Locals[4]);f.Pc=500;continue;}
case 500:{f.Push(f.Locals[0]);f.Pc=501;continue;}
case 501:{return rt.Call(f,"forge/item/IPaperCard","getRarity","()Lforge/card/CardRarity;","invokeinterface",506);}
case 506:{return rt.Call(f,"forge/game/card/Card","setRarity","(Lforge/card/CardRarity;)V","invokevirtual",509);}
case 509:{f.Push(f.Locals[4]);f.Pc=511;continue;}
case 511:{if(!rt.StaticReady(f,"forge/card/CardStateName","SpecializeG","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","SpecializeG","Lforge/card/CardStateName;"));f.Pc=514;continue;}
case 514:{f.Push(JValue.I(0));f.Pc=515;continue;}
case 515:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",518);}
case 518:{f.StackOp("pop");f.Pc=519;continue;}
case 519:{f.Push(f.Locals[4]);f.Pc=521;continue;}
case 521:{f.Push(f.Locals[0]);f.Pc=522;continue;}
case 522:{f.Push(JValue.I(0));f.Pc=523;continue;}
case 523:{return rt.Call(f,"forge/item/IPaperCard","getImageKey","(Z)Ljava/lang/String;","invokeinterface",528);}
case 528:{return rt.DynamicCall(f,"forge/game/card/CardFactory:4994:528:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",533);}
case 533:{return rt.Call(f,"forge/game/card/Card","setImageKey","(Ljava/lang/String;)V","invokevirtual",536);}
case 536:{f.Push(f.Locals[4]);f.Pc=538;continue;}
case 538:{f.Push(f.Locals[0]);f.Pc=539;continue;}
case 539:{return rt.Call(f,"forge/item/IPaperCard","getEdition","()Ljava/lang/String;","invokeinterface",544);}
case 544:{return rt.Call(f,"forge/game/card/Card","setSetCode","(Ljava/lang/String;)V","invokevirtual",547);}
case 547:{f.Push(f.Locals[4]);f.Pc=549;continue;}
case 549:{f.Push(f.Locals[0]);f.Pc=550;continue;}
case 550:{return rt.Call(f,"forge/item/IPaperCard","getRarity","()Lforge/card/CardRarity;","invokeinterface",555);}
case 555:{return rt.Call(f,"forge/game/card/Card","setRarity","(Lforge/card/CardRarity;)V","invokevirtual",558);}
case 558:{f.Push(f.Locals[4]);f.Pc=560;continue;}
case 560:{f.Push(f.Locals[0]);f.Pc=561;continue;}
case 561:{return rt.Call(f,"forge/item/IPaperCard","getEdition","()Ljava/lang/String;","invokeinterface",566);}
case 566:{return rt.Call(f,"forge/game/card/Card","setSetCode","(Ljava/lang/String;)V","invokevirtual",569);}
case 569:{f.Push(f.Locals[4]);f.Pc=571;continue;}
case 571:{f.Push(f.Locals[0]);f.Pc=572;continue;}
case 572:{return rt.Call(f,"forge/item/IPaperCard","getRarity","()Lforge/card/CardRarity;","invokeinterface",577);}
case 577:{return rt.Call(f,"forge/game/card/Card","setRarity","(Lforge/card/CardRarity;)V","invokevirtual",580);}
case 580:{f.Push(f.Locals[4]);f.Pc=582;continue;}
case 582:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=585;continue;}
case 585:{f.Push(JValue.I(0));f.Pc=586;continue;}
case 586:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",589);}
case 589:{f.StackOp("pop");f.Pc=590;continue;}
case 590:{f.Push(f.Locals[4]);f.Pc=592;continue;}
case 592:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4995(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getStates","()Ljava/util/Set;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?67:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardStateName"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/Card","isDoubleFaced","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?46:36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/card/CardStateName","FaceDown","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","FaceDown","Lforge/card/CardStateName;"));f.Pc=40;continue;}
case 40:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?46:43;continue;}
case 43:{f.Pc=10;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{f.Push(JValue.I(0));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=57;continue;}
case 57:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?64:60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/card/CardFactoryUtil","setupKeywordedAbilities","(Lforge/game/card/Card;)V","invokestatic",64);}
case 64:{f.Pc=10;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=71;continue;}
case 71:{f.Push(JValue.I(0));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/card/Card","isSplitCard","()Z","invokevirtual",80);}
case 80:{f.Pc=f.Pop().Int==0?87:83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/card/Card","updateKeywordsCache","()V","invokevirtual",87);}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/card/CardFactory","buildBattleAbilities","(Lforge/game/card/Card;)V","invokestatic",91);}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/card/CardFactoryUtil","setupKeywordedAbilities","(Lforge/game/card/Card;)V","invokestatic",95);}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",99);}
case 99:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4996(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isBattle","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?8:7;continue;}
case 7:{return JStep.ReturnVoid;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",12);}
case 12:{f.Push(JValue.R(rt.String("Siege")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/card/CardTypeView","hasSubtype","(Ljava/lang/String;)Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?30:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/CardFactoryUtil","setupSiegeAbilities","(Lforge/game/card/Card;)V","invokestatic",27);}
case 27:{f.Pc=100;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",34);}
case 34:{return rt.Call(f,"forge/card/CardTypeView","getBattleTypes","()Ljava/util/Set;","invokeinterface",39);}
case 39:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",44);}
case 44:{f.Pc=f.Pop().Int==0?100:47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/Card","getReplacementEffects","()Lforge/util/collect/FCollectionView;","invokevirtual",51);}
case 51:{return rt.Call(f,"forge/util/collect/FCollectionView","stream","()Ljava/util/stream/Stream;","invokeinterface",56);}
case 56:{return rt.DynamicCall(f,"forge/game/card/CardFactory:4996:56:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",61);}
case 61:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",66);}
case 66:{f.Pc=f.Pop().Int==0?70:69;continue;}
case 69:{return JStep.ReturnVoid;}
case 70:{f.Push(JValue.R(rt.String("DB$ ChoosePlayer | Choices$ You | Protect$ True | DontNotify$ True")));f.Pc=73;continue;}
case 73:{f.Locals[1]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("Event$ Moved | ValidCard$ Card.Self | Destination$ Battlefield | ReplacementResult$ Updated | BattleProtector$ True | Description$ (As this Battle enters, its controller becomes its protector.)")));f.Pc=77;continue;}
case 77:{f.Locals[2]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(JValue.I(1));f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",84);}
case 84:{f.Locals[3]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",91);}
case 91:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",94);}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[3]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/card/Card","addReplacementEffect","(Lforge/game/replacement/ReplacementEffect;)Lforge/game/replacement/ReplacementEffect;","invokevirtual",99);}
case 99:{f.StackOp("pop");f.Pc=100;continue;}
case 100:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4997(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/Card"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/Card")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/Card","<init>","(ILforge/item/IPaperCard;Lforge/game/Game;)V","invokespecial",10);}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/item/IPaperCard","getRules","()Lforge/card/CardRules;","invokeinterface",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/Card","updateRulesView","()V","invokevirtual",23);}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/card/CardRules","getSplitType","()Lforge/card/CardSplitType;","invokevirtual",28);}
case 28:{f.Locals[5]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[5]);f.Pc=32;continue;}
case 32:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Split","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Split","Lforge/card/CardSplitType;"));f.Pc=35;continue;}
case 35:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?55:38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=42;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/Card","addAlternateState","(Lforge/card/CardStateName;Z)V","invokevirtual",46);}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=50;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",54);}
case 54:{f.StackOp("pop");f.Pc=55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/card/CardRules","getMainPart","()Lforge/card/ICardFace;","invokevirtual",61);}
case 61:{return rt.Call(f,"forge/game/card/CardFactory","readCardFace","(Lforge/game/card/Card;Lforge/card/ICardFace;)V","invokestatic",64);}
case 64:{f.Push(f.Locals[5]);f.Pc=66;continue;}
case 66:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Specialize","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Specialize","Lforge/card/CardSplitType;"));f.Pc=69;continue;}
case 69:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?172:72;continue;}
case 72:{f.Push(f.Locals[4]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/card/CardRules","getSpecializeParts","()Ljava/util/Map;","invokevirtual",77);}
case 77:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",82);}
case 82:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",87);}
case 87:{f.Locals[6]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[6]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",96);}
case 96:{f.Pc=f.Pop().Int==0?169:99;continue;}
case 99:{f.Push(f.Locals[6]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",106);}
case 106:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=109;continue;}
case 109:{f.Locals[7]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(f.Locals[3]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[7]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",119);}
case 119:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardStateName"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=122;continue;}
case 122:{f.Push(JValue.I(0));f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/card/Card","addAlternateState","(Lforge/card/CardStateName;Z)V","invokevirtual",126);}
case 126:{f.Push(f.Locals[3]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[7]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",134);}
case 134:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardStateName"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=137;continue;}
case 137:{f.Push(JValue.I(0));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",141);}
case 141:{f.StackOp("pop");f.Pc=142;continue;}
case 142:{f.Push(f.Locals[7]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",149);}
case 149:{f.Pc=f.Pop().Reference==null?166:152;continue;}
case 152:{f.Push(f.Locals[3]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[7]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",160);}
case 160:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/card/CardFactory","readCardFace","(Lforge/game/card/Card;Lforge/card/ICardFace;)V","invokestatic",166);}
case 166:{f.Pc=89;continue;}
case 169:{f.Pc=253;continue;}
case 172:{f.Push(f.Locals[5]);f.Pc=174;continue;}
case 174:{if(!rt.StaticReady(f,"forge/card/CardSplitType","None","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","None","Lforge/card/CardSplitType;"));f.Pc=177;continue;}
case 177:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?253:180;continue;}
case 180:{f.Push(f.Locals[3]);f.Pc=181;continue;}
case 181:{f.Push(f.Locals[5]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/card/CardSplitType","getChangedStateName","()Lforge/card/CardStateName;","invokevirtual",186);}
case 186:{f.Push(JValue.I(0));f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/card/Card","addAlternateState","(Lforge/card/CardStateName;Z)V","invokevirtual",190);}
case 190:{f.Push(f.Locals[3]);f.Pc=191;continue;}
case 191:{f.Push(f.Locals[5]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/card/CardSplitType","getChangedStateName","()Lforge/card/CardStateName;","invokevirtual",196);}
case 196:{f.Push(JValue.I(0));f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",200);}
case 200:{f.StackOp("pop");f.Pc=201;continue;}
case 201:{f.Push(f.Locals[4]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/card/CardRules","getOtherPart","()Lforge/card/ICardFace;","invokevirtual",206);}
case 206:{f.Pc=f.Pop().Reference==null?221:209;continue;}
case 209:{f.Push(f.Locals[3]);f.Pc=210;continue;}
case 210:{f.Push(f.Locals[4]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/card/CardRules","getOtherPart","()Lforge/card/ICardFace;","invokevirtual",215);}
case 215:{return rt.Call(f,"forge/game/card/CardFactory","readCardFace","(Lforge/game/card/Card;Lforge/card/ICardFace;)V","invokestatic",218);}
case 218:{f.Pc=253;continue;}
case 221:{f.Push(f.Locals[4]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/card/CardRules","getMeldWith","()Ljava/lang/String;","invokevirtual",226);}
case 226:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",229);}
case 229:{f.Pc=f.Pop().Int!=0?253:232;continue;}
case 232:{f.Push(f.Locals[3]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",236);}
case 236:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",239);}
case 239:{f.Push(f.Locals[4]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/card/CardRules","getMeldWith","()Ljava/lang/String;","invokevirtual",244);}
case 244:{return rt.Call(f,"forge/card/CardDb","getRulesOrElseUnsupported","(Ljava/lang/String;)Lforge/card/CardRules;","invokevirtual",247);}
case 247:{return rt.Call(f,"forge/card/CardRules","getOtherPart","()Lforge/card/ICardFace;","invokevirtual",250);}
case 250:{return rt.Call(f,"forge/game/card/CardFactory","readCardFace","(Lforge/game/card/Card;Lforge/card/ICardFace;)V","invokestatic",253);}
case 253:{f.Push(f.Locals[3]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/card/Card","isInAlternateState","()Z","invokevirtual",257);}
case 257:{f.Pc=f.Pop().Int==0?269:260;continue;}
case 260:{f.Push(f.Locals[3]);f.Pc=261;continue;}
case 261:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=264;continue;}
case 264:{f.Push(JValue.I(0));f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",268);}
case 268:{f.StackOp("pop");f.Pc=269;continue;}
case 269:{f.Push(f.Locals[5]);f.Pc=271;continue;}
case 271:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Split","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Split","Lforge/card/CardSplitType;"));f.Pc=274;continue;}
case 274:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?396:277;continue;}
case 277:{f.Push(f.Locals[3]);f.Pc=278;continue;}
case 278:{f.Push(f.Locals[4]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",283);}
case 283:{return rt.Call(f,"forge/game/card/Card","setName","(Ljava/lang/String;)V","invokevirtual",286);}
case 286:{f.Push(f.Locals[3]);f.Pc=287;continue;}
case 287:{f.Push(f.Locals[4]);f.Pc=289;continue;}
case 289:{return rt.Call(f,"forge/card/CardRules","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",292);}
case 292:{return rt.Call(f,"forge/game/card/Card","setManaCost","(Lforge/card/mana/ManaCost;)V","invokevirtual",295);}
case 295:{f.Push(f.Locals[3]);f.Pc=296;continue;}
case 296:{f.Push(f.Locals[4]);f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/card/CardRules","getColor","()Lforge/card/ColorSet;","invokevirtual",301);}
case 301:{return rt.Call(f,"forge/game/card/Card","setColor","(Lforge/card/ColorSet;)V","invokevirtual",304);}
case 304:{f.Push(f.Locals[3]);f.Pc=305;continue;}
case 305:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=308;continue;}
case 308:{f.StackOp("dup");f.Pc=309;continue;}
case 309:{f.Push(f.Locals[4]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",314);}
case 314:{return rt.Call(f,"forge/card/CardType","<init>","(Lforge/card/CardType;)V","invokespecial",317);}
case 317:{return rt.Call(f,"forge/game/card/Card","setType","(Lforge/card/CardType;)V","invokevirtual",320);}
case 320:{f.Push(JValue.R(rt.String("(%s) %s\r\n\r\n(%s) %s")));f.Pc=323;continue;}
case 323:{f.Push(JValue.I(4));f.Pc=324;continue;}
case 324:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=327;continue;}
case 327:{f.StackOp("dup");f.Pc=328;continue;}
case 328:{f.Push(JValue.I(0));f.Pc=329;continue;}
case 329:{f.Push(f.Locals[4]);f.Pc=331;continue;}
case 331:{return rt.Call(f,"forge/card/CardRules","getMainPart","()Lforge/card/ICardFace;","invokevirtual",334);}
case 334:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",339);}
case 339:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=340;continue;}
case 340:{f.StackOp("dup");f.Pc=341;continue;}
case 341:{f.Push(JValue.I(1));f.Pc=342;continue;}
case 342:{f.Push(f.Locals[4]);f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/card/CardRules","getMainPart","()Lforge/card/ICardFace;","invokevirtual",347);}
case 347:{return rt.Call(f,"forge/card/ICardFace","getOracleText","()Ljava/lang/String;","invokeinterface",352);}
case 352:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=353;continue;}
case 353:{f.StackOp("dup");f.Pc=354;continue;}
case 354:{f.Push(JValue.I(2));f.Pc=355;continue;}
case 355:{f.Push(f.Locals[4]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"forge/card/CardRules","getOtherPart","()Lforge/card/ICardFace;","invokevirtual",360);}
case 360:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",365);}
case 365:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=366;continue;}
case 366:{f.StackOp("dup");f.Pc=367;continue;}
case 367:{f.Push(JValue.I(3));f.Pc=368;continue;}
case 368:{f.Push(f.Locals[4]);f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/card/CardRules","getOtherPart","()Lforge/card/ICardFace;","invokevirtual",373);}
case 373:{return rt.Call(f,"forge/card/ICardFace","getOracleText","()Ljava/lang/String;","invokeinterface",378);}
case 378:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=379;continue;}
case 379:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",382);}
case 382:{f.Locals[6]=f.Pop();f.Pc=384;continue;}
case 384:{f.Push(f.Locals[3]);f.Pc=385;continue;}
case 385:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=388;continue;}
case 388:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",391);}
case 391:{f.Push(f.Locals[6]);f.Pc=393;continue;}
case 393:{return rt.Call(f,"forge/game/card/CardState","setOracleText","(Ljava/lang/String;)V","invokevirtual",396);}
case 396:{f.Push(f.Locals[3]);f.Pc=397;continue;}
case 397:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4998(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/ICardFace","hasFunctionalVariants","()Z","invokeinterface",8);}
case 8:{f.Pc=f.Pop().Int==0?82:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",15);}
case 15:{return rt.Call(f,"forge/item/IPaperCard","getFunctionalVariant","()Ljava/lang/String;","invokeinterface",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("")));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int!=0?82:30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/card/ICardFace","getFunctionalVariant","(Ljava/lang/String;)Lforge/card/ICardFace;","invokeinterface",37);}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{f.Pc=f.Pop().Reference==null?55:42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{f.Locals[1]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",48);}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/card/CardState","setFunctionalVariantName","(Ljava/lang/String;)V","invokevirtual",52);}
case 52:{f.Pc=82;continue;}
case 55:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("Tried to apply unknown or unsupported variant - Card: \"%s\"; Variant: %s\n")));f.Pc=61;continue;}
case 61:{f.Push(JValue.I(2));f.Pc=62;continue;}
case 62:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=65;continue;}
case 65:{f.StackOp("dup");f.Pc=66;continue;}
case 66:{f.Push(JValue.I(0));f.Pc=67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",73);}
case 73:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=74;continue;}
case 74:{f.StackOp("dup");f.Pc=75;continue;}
case 75:{f.Push(JValue.I(1));f.Pc=76;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/io/PrintStream","printf","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;","invokevirtual",81);}
case 81:{f.StackOp("pop");f.Pc=82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",89);}
case 89:{return rt.Call(f,"forge/game/card/Card","setName","(Ljava/lang/String;)V","invokevirtual",92);}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",96);}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/card/ICardFace","getFlavorName","()Ljava/lang/String;","invokeinterface",102);}
case 102:{return rt.Call(f,"forge/game/card/CardState","setFlavorName","(Ljava/lang/String;)V","invokevirtual",105);}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/card/ICardFace","getDraftActions","()Ljava/lang/Iterable;","invokeinterface",111);}
case 111:{f.Pc=f.Pop().Reference==null?136:114;continue;}
case 114:{f.Push(f.Locals[1]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/card/ICardFace","getDraftActions","()Ljava/lang/Iterable;","invokeinterface",120);}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.StackOp("dup");f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",125);}
case 125:{f.StackOp("pop");f.Pc=126;continue;}
case 126:{return rt.DynamicCall(f,"forge/game/card/CardFactory:4998:126:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Consumer;",131);}
case 131:{return rt.Call(f,"java/lang/Iterable","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",136);}
case 136:{f.Push(f.Locals[0]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[1]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/card/ICardFace","getManaCost","()Lforge/card/mana/ManaCost;","invokeinterface",143);}
case 143:{return rt.Call(f,"forge/game/card/Card","setManaCost","(Lforge/card/mana/ManaCost;)V","invokevirtual",146);}
case 146:{f.Push(f.Locals[0]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[1]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/card/ICardFace","getNonAbilityText","()Ljava/lang/String;","invokeinterface",153);}
case 153:{return rt.Call(f,"forge/game/card/Card","setText","(Ljava/lang/String;)V","invokevirtual",156);}
case 156:{f.Push(f.Locals[0]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",160);}
case 160:{f.Push(f.Locals[1]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/card/ICardFace","getOracleText","()Ljava/lang/String;","invokeinterface",166);}
case 166:{return rt.Call(f,"forge/game/card/CardState","setOracleText","(Ljava/lang/String;)V","invokevirtual",169);}
case 169:{f.Push(f.Locals[0]);f.Pc=170;continue;}
case 170:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=173;continue;}
case 173:{f.StackOp("dup");f.Pc=174;continue;}
case 174:{f.Push(f.Locals[1]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",180);}
case 180:{return rt.Call(f,"forge/card/CardType","<init>","(Lforge/card/CardType;)V","invokespecial",183);}
case 183:{return rt.Call(f,"forge/game/card/Card","setType","(Lforge/card/CardType;)V","invokevirtual",186);}
case 186:{f.Push(f.Locals[0]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[1]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/card/ICardFace","getColor","()Lforge/card/ColorSet;","invokeinterface",193);}
case 193:{return rt.Call(f,"forge/game/card/Card","setColor","(Lforge/card/ColorSet;)V","invokevirtual",196);}
case 196:{f.Push(f.Locals[1]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/card/ICardFace","getIntPower","()I","invokeinterface",202);}
case 202:{f.Push(JValue.I(2147483647));f.Pc=205;continue;}
case 205:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?228:208;continue;}
case 208:{f.Push(f.Locals[0]);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[1]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/card/ICardFace","getIntPower","()I","invokeinterface",215);}
case 215:{return rt.Call(f,"forge/game/card/Card","setBasePower","(I)V","invokevirtual",218);}
case 218:{f.Push(f.Locals[0]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[1]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/card/ICardFace","getPower","()Ljava/lang/String;","invokeinterface",225);}
case 225:{return rt.Call(f,"forge/game/card/Card","setBasePowerString","(Ljava/lang/String;)V","invokevirtual",228);}
case 228:{f.Push(f.Locals[1]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/card/ICardFace","getIntToughness","()I","invokeinterface",234);}
case 234:{f.Push(JValue.I(2147483647));f.Pc=237;continue;}
case 237:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?260:240;continue;}
case 240:{f.Push(f.Locals[0]);f.Pc=241;continue;}
case 241:{f.Push(f.Locals[1]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"forge/card/ICardFace","getIntToughness","()I","invokeinterface",247);}
case 247:{return rt.Call(f,"forge/game/card/Card","setBaseToughness","(I)V","invokevirtual",250);}
case 250:{f.Push(f.Locals[0]);f.Pc=251;continue;}
case 251:{f.Push(f.Locals[1]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/card/ICardFace","getToughness","()Ljava/lang/String;","invokeinterface",257);}
case 257:{return rt.Call(f,"forge/game/card/Card","setBaseToughnessString","(Ljava/lang/String;)V","invokevirtual",260);}
case 260:{f.Push(f.Locals[0]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",264);}
case 264:{f.Push(f.Locals[1]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/card/ICardFace","getInitialLoyalty","()Ljava/lang/String;","invokeinterface",270);}
case 270:{return rt.Call(f,"forge/game/card/CardState","setBaseLoyalty","(Ljava/lang/String;)V","invokevirtual",273);}
case 273:{f.Push(f.Locals[0]);f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",277);}
case 277:{f.Push(f.Locals[1]);f.Pc=278;continue;}
case 278:{return rt.Call(f,"forge/card/ICardFace","getDefense","()Ljava/lang/String;","invokeinterface",283);}
case 283:{return rt.Call(f,"forge/game/card/CardState","setBaseDefense","(Ljava/lang/String;)V","invokevirtual",286);}
case 286:{f.Push(f.Locals[0]);f.Pc=287;continue;}
case 287:{f.Push(f.Locals[1]);f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/card/ICardFace","getAttractionLights","()Ljava/util/Set;","invokeinterface",293);}
case 293:{return rt.Call(f,"forge/game/card/Card","setAttractionLights","(Ljava/util/Set;)V","invokevirtual",296);}
case 296:{f.Push(f.Locals[0]);f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",300);}
case 300:{f.Pc=f.Pop().Int<0?581:303;continue;}
case 303:{f.Push(f.Locals[1]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",309);}
case 309:{f.Push(f.Locals[1]);f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/card/ICardFace","getOracleText","()Ljava/lang/String;","invokeinterface",315);}
case 315:{f.Push(f.Locals[2]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/util/CardTranslation","buildOracleMapping","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokestatic",319);}
case 319:{f.Push(f.Locals[1]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/card/ICardFace","getVariables","()Ljava/lang/Iterable;","invokeinterface",325);}
case 325:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",330);}
case 330:{f.Locals[3]=f.Pop();f.Pc=331;continue;}
case 331:{f.Push(f.Locals[3]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",337);}
case 337:{f.Pc=f.Pop().Int==0?378:340;continue;}
case 340:{f.Push(f.Locals[3]);f.Pc=341;continue;}
case 341:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",346);}
case 346:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=349;continue;}
case 349:{f.Locals[4]=f.Pop();f.Pc=351;continue;}
case 351:{f.Push(f.Locals[0]);f.Pc=352;continue;}
case 352:{f.Push(f.Locals[4]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",359);}
case 359:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=362;continue;}
case 362:{f.Push(f.Locals[4]);f.Pc=364;continue;}
case 364:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",369);}
case 369:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=372;continue;}
case 372:{return rt.Call(f,"forge/game/card/Card","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",375);}
case 375:{f.Pc=331;continue;}
case 378:{f.Push(f.Locals[1]);f.Pc=379;continue;}
case 379:{return rt.Call(f,"forge/card/ICardFace","getReplacements","()Ljava/lang/Iterable;","invokeinterface",384);}
case 384:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",389);}
case 389:{f.Locals[3]=f.Pop();f.Pc=390;continue;}
case 390:{f.Push(f.Locals[3]);f.Pc=391;continue;}
case 391:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",396);}
case 396:{f.Pc=f.Pop().Int==0?429:399;continue;}
case 399:{f.Push(f.Locals[3]);f.Pc=400;continue;}
case 400:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",405);}
case 405:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=408;continue;}
case 408:{f.Locals[4]=f.Pop();f.Pc=410;continue;}
case 410:{f.Push(f.Locals[0]);f.Pc=411;continue;}
case 411:{f.Push(f.Locals[4]);f.Pc=413;continue;}
case 413:{f.Push(f.Locals[0]);f.Pc=414;continue;}
case 414:{f.Push(JValue.I(1));f.Pc=415;continue;}
case 415:{f.Push(f.Locals[0]);f.Pc=416;continue;}
case 416:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",419);}
case 419:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",422);}
case 422:{return rt.Call(f,"forge/game/card/Card","addReplacementEffect","(Lforge/game/replacement/ReplacementEffect;)Lforge/game/replacement/ReplacementEffect;","invokevirtual",425);}
case 425:{f.StackOp("pop");f.Pc=426;continue;}
case 426:{f.Pc=390;continue;}
case 429:{f.Push(f.Locals[1]);f.Pc=430;continue;}
case 430:{return rt.Call(f,"forge/card/ICardFace","getStaticAbilities","()Ljava/lang/Iterable;","invokeinterface",435);}
case 435:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",440);}
case 440:{f.Locals[3]=f.Pop();f.Pc=441;continue;}
case 441:{f.Push(f.Locals[3]);f.Pc=442;continue;}
case 442:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",447);}
case 447:{f.Pc=f.Pop().Int==0?471:450;continue;}
case 450:{f.Push(f.Locals[3]);f.Pc=451;continue;}
case 451:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",456);}
case 456:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=459;continue;}
case 459:{f.Locals[4]=f.Pop();f.Pc=461;continue;}
case 461:{f.Push(f.Locals[0]);f.Pc=462;continue;}
case 462:{f.Push(f.Locals[4]);f.Pc=464;continue;}
case 464:{return rt.Call(f,"forge/game/card/Card","addStaticAbility","(Ljava/lang/String;)Lforge/game/staticability/StaticAbility;","invokevirtual",467);}
case 467:{f.StackOp("pop");f.Pc=468;continue;}
case 468:{f.Pc=441;continue;}
case 471:{f.Push(f.Locals[1]);f.Pc=472;continue;}
case 472:{return rt.Call(f,"forge/card/ICardFace","getTriggers","()Ljava/lang/Iterable;","invokeinterface",477);}
case 477:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",482);}
case 482:{f.Locals[3]=f.Pop();f.Pc=483;continue;}
case 483:{f.Push(f.Locals[3]);f.Pc=484;continue;}
case 484:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",489);}
case 489:{f.Pc=f.Pop().Int==0?522:492;continue;}
case 492:{f.Push(f.Locals[3]);f.Pc=493;continue;}
case 493:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",498);}
case 498:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=501;continue;}
case 501:{f.Locals[4]=f.Pop();f.Pc=503;continue;}
case 503:{f.Push(f.Locals[0]);f.Pc=504;continue;}
case 504:{f.Push(f.Locals[4]);f.Pc=506;continue;}
case 506:{f.Push(f.Locals[0]);f.Pc=507;continue;}
case 507:{f.Push(JValue.I(1));f.Pc=508;continue;}
case 508:{f.Push(f.Locals[0]);f.Pc=509;continue;}
case 509:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",512);}
case 512:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/trigger/Trigger;","invokestatic",515);}
case 515:{return rt.Call(f,"forge/game/card/Card","addTrigger","(Lforge/game/trigger/Trigger;)Lforge/game/trigger/Trigger;","invokevirtual",518);}
case 518:{f.StackOp("pop");f.Pc=519;continue;}
case 519:{f.Pc=483;continue;}
case 522:{f.Push(f.Locals[0]);f.Pc=523;continue;}
case 523:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",526);}
case 526:{f.Push(f.Locals[1]);f.Pc=527;continue;}
case 527:{return rt.Call(f,"forge/card/ICardFace","getKeywords","()Ljava/lang/Iterable;","invokeinterface",532);}
case 532:{f.Push(JValue.I(0));f.Pc=533;continue;}
case 533:{return rt.Call(f,"forge/game/card/CardState","addIntrinsicKeywords","(Ljava/lang/Iterable;Z)Z","invokevirtual",536);}
case 536:{f.Pc=f.Pop().Int==0?543:539;continue;}
case 539:{f.Push(f.Locals[0]);f.Pc=540;continue;}
case 540:{return rt.Call(f,"forge/game/card/Card","updateKeywordsCache","()V","invokevirtual",543);}
case 543:{f.Push(f.Locals[0]);f.Pc=544;continue;}
case 544:{f.Push(f.Locals[1]);f.Pc=545;continue;}
case 545:{return rt.Call(f,"forge/card/ICardFace","getAbilities","()Ljava/lang/Iterable;","invokeinterface",550);}
case 550:{return rt.Call(f,"forge/game/card/CardFactoryUtil","addAbilityFactoryAbilities","(Lforge/game/card/Card;Ljava/lang/Iterable;)V","invokestatic",553);}
case 553:{f.Push(f.Locals[0]);f.Pc=554;continue;}
case 554:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",557);}
case 557:{f.Push(JValue.R(rt.String("Vengeance")));f.Pc=560;continue;}
case 560:{return rt.Call(f,"forge/card/CardTypeView","hasSubtype","(Ljava/lang/String;)Z","invokeinterface",565);}
case 565:{f.Pc=f.Pop().Int==0?581:568;continue;}
case 568:{f.Push(f.Locals[0]);f.Pc=569;continue;}
case 569:{return rt.Call(f,"forge/game/card/Card","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",572);}
case 572:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",575);}
case 575:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=578;continue;}
case 578:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setZone","(Lforge/game/zone/ZoneType;)V","invokevirtual",581);}
case 581:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4999(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?15:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","setTargetRestrictions","(Lforge/game/spellability/TargetRestrictions;)V","invokevirtual",15);}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalDescription","()Ljava/lang/String;","invokevirtual",20);}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",23);}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalStackDescription","()Ljava/lang/String;","invokevirtual",28);}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","setStackDescription","(Ljava/lang/String;)V","invokevirtual",31);}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Reference==null?58:38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",43);}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[5]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/AbilitySub","copy","(Lforge/game/card/Card;Lforge/game/player/Player;ZZ)Lforge/game/spellability/SpellAbility;","invokevirtual",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",58);}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbilities","()Ljava/util/Map;","invokevirtual",62);}
case 62:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",67);}
case 67:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",72);}
case 72:{f.Locals[6]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[6]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",81);}
case 81:{f.Pc=f.Pop().Int==0?132:84;continue;}
case 84:{f.Push(f.Locals[6]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",91);}
case 91:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=94;continue;}
case 94:{f.Locals[7]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[7]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",104);}
case 104:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[7]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",114);}
case 114:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[2]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[3]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[4]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[5]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Lforge/game/player/Player;ZZ)Lforge/game/spellability/SpellAbility;","invokevirtual",126);}
case 126:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAdditionalAbility","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)V","invokevirtual",129);}
case 129:{f.Pc=74;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbilityLists","()Ljava/util/Map;","invokevirtual",136);}
case 136:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",141);}
case 141:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",146);}
case 146:{f.Locals[6]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[6]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",155);}
case 155:{f.Pc=f.Pop().Int==0?229:158;continue;}
case 158:{f.Push(f.Locals[6]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",165);}
case 165:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=168;continue;}
case 168:{f.Locals[7]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(f.Locals[1]);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[7]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",178);}
case 178:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=181;continue;}
case 181:{f.Push(f.Locals[7]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",188);}
case 188:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",196);}
case 196:{f.Push(f.Locals[2]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[3]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[4]);f.Pc=200;continue;}
case 200:{f.Push(f.Locals[5]);f.Pc=202;continue;}
case 202:{return rt.DynamicCall(f,"forge/game/card/CardFactory:4999:202:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;Lforge/game/player/Player;ZZ)Ljava/util/function/Function;",207);}
case 207:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",212);}
case 212:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",215);}
case 215:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",220);}
case 220:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAdditionalAbilityList","(Ljava/lang/String;Ljava/util/List;)V","invokevirtual",226);}
case 226:{f.Pc=148;continue;}
case 229:{f.Push(f.Locals[0]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",233);}
case 233:{f.Pc=f.Pop().Reference==null?250:236;continue;}
case 236:{f.Push(f.Locals[1]);f.Pc=237;continue;}
case 237:{f.Push(f.Locals[0]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",241);}
case 241:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","copy","()Lforge/game/spellability/SpellAbilityVariables;","invokevirtual",244);}
case 244:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityRestriction"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/spellability/SpellAbility","setRestrictions","(Lforge/game/spellability/SpellAbilityRestriction;)V","invokevirtual",250);}
case 250:{f.Push(f.Locals[0]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/spellability/SpellAbility","getConditions","()Lforge/game/spellability/SpellAbilityCondition;","invokevirtual",254);}
case 254:{f.Pc=f.Pop().Reference==null?271:257;continue;}
case 257:{f.Push(f.Locals[1]);f.Pc=258;continue;}
case 258:{f.Push(f.Locals[0]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"forge/game/spellability/SpellAbility","getConditions","()Lforge/game/spellability/SpellAbilityCondition;","invokevirtual",262);}
case 262:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","copy","()Lforge/game/spellability/SpellAbilityVariables;","invokevirtual",265);}
case 265:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityCondition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/spellability/SpellAbility","setConditions","(Lforge/game/spellability/SpellAbilityCondition;)V","invokevirtual",271);}
case 271:{f.Push(f.Locals[3]);f.Pc=272;continue;}
case 272:{f.Pc=f.Pop().Reference==null?280:275;continue;}
case 275:{f.Push(f.Locals[1]);f.Pc=276;continue;}
case 276:{f.Push(f.Locals[3]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",280);}
case 280:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5000(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/trigger/WrappedAbility","isTrigger","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{if(!rt.EnsureInitialized(f,"forge/game/trigger/WrappedAbility"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/trigger/WrappedAbility")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",17);}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getWrappedAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",21);}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Lforge/game/player/Player;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",27);}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getDecider","()Lforge/game/player/Player;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/game/trigger/WrappedAbility","<init>","(Lforge/game/trigger/Trigger;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)V","invokespecial",34);}
case 34:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5001(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getSVars","()Ljava/util/Map;","invokevirtual",9);}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",14);}
case 14:{f.Locals[5]=f.Pop();f.Pc=16;continue;}
case 16:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",19);}
case 19:{f.Locals[6]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{f.Locals[7]=f.Pop();f.Pc=24;continue;}
case 24:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",27);}
case 27:{f.Locals[8]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(JValue.R(null));f.Pc=30;continue;}
case 30:{f.Locals[9]=f.Pop();f.Pc=32;continue;}
case 32:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCloneStates"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCloneStates")));f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/CardCloneStates","<init>","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)V","invokespecial",41);}
case 41:{f.Locals[10]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("NewName")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/CardTraitBase","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",50);}
case 50:{f.Locals[11]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(JValue.R(null));f.Pc=53;continue;}
case 53:{f.Locals[12]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(JValue.R(null));f.Pc=56;continue;}
case 56:{f.Locals[13]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("AddTypes")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?92:68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.String("AddTypes")));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/CardTraitBase","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",77);}
case 77:{f.Push(JValue.R(rt.String(" & ")));f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",83);}
case 83:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",86);}
case 86:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",91);}
case 91:{f.StackOp("pop");f.Pc=92;continue;}
case 92:{f.Push(f.Locals[2]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("SetCreatureTypes")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",99);}
case 99:{f.Pc=f.Pop().Int==0?120:102;continue;}
case 102:{f.Push(f.Locals[2]);f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("SetCreatureTypes")));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/CardTraitBase","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",109);}
case 109:{f.Push(JValue.R(rt.String(" ")));f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",115);}
case 115:{return rt.Call(f,"java/util/List","of","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",118);}
case 118:{f.Locals[9]=f.Pop();f.Pc=120;continue;}
case 120:{f.Push(f.Locals[2]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("AddKeywords")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",127);}
case 127:{f.Pc=f.Pop().Int==0?181:130;continue;}
case 130:{f.Push(f.Locals[2]);f.Pc=131;continue;}
case 131:{f.Push(JValue.R(rt.String("AddKeywords")));f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/CardTraitBase","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",137);}
case 137:{f.Locals[14]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[14]);f.Pc=141;continue;}
case 141:{f.Push(JValue.R(rt.String("IfNew ")));f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",147);}
case 147:{f.Pc=f.Pop().Int==0?162:150;continue;}
case 150:{f.Push(JValue.I(1));f.Pc=151;continue;}
case 151:{f.Locals[7]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(f.Locals[14]);f.Pc=155;continue;}
case 155:{f.Push(JValue.I(6));f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",160);}
case 160:{f.Locals[14]=f.Pop();f.Pc=162;continue;}
case 162:{f.Push(f.Locals[6]);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[14]);f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.String(" & ")));f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",172);}
case 172:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",175);}
case 175:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",180);}
case 180:{f.StackOp("pop");f.Pc=181;continue;}
case 181:{f.Push(f.Locals[2]);f.Pc=182;continue;}
case 182:{f.Push(JValue.R(rt.String("RemoveKeywords")));f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",188);}
case 188:{f.Pc=f.Pop().Int==0?215:191;continue;}
case 191:{f.Push(f.Locals[8]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[2]);f.Pc=194;continue;}
case 194:{f.Push(JValue.R(rt.String("RemoveKeywords")));f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/CardTraitBase","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",200);}
case 200:{f.Push(JValue.R(rt.String(" & ")));f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",206);}
case 206:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",209);}
case 209:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",214);}
case 214:{f.StackOp("pop");f.Pc=215;continue;}
case 215:{f.Push(f.Locals[2]);f.Pc=216;continue;}
case 216:{f.Push(JValue.R(rt.String("AddColors")));f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",222);}
case 222:{f.Pc=f.Pop().Int==0?243:225;continue;}
case 225:{f.Push(f.Locals[2]);f.Pc=226;continue;}
case 226:{f.Push(JValue.R(rt.String("AddColors")));f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/CardTraitBase","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",232);}
case 232:{f.Push(JValue.R(rt.String(",")));f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",238);}
case 238:{return rt.Call(f,"forge/card/ColorSet","fromNames","([Ljava/lang/String;)Lforge/card/ColorSet;","invokestatic",241);}
case 241:{f.Locals[13]=f.Pop();f.Pc=243;continue;}
case 243:{f.Push(f.Locals[2]);f.Pc=244;continue;}
case 244:{f.Push(JValue.R(rt.String("SetColor")));f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",250);}
case 250:{f.Pc=f.Pop().Int==0?271:253;continue;}
case 253:{f.Push(f.Locals[2]);f.Pc=254;continue;}
case 254:{f.Push(JValue.R(rt.String("SetColor")));f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/CardTraitBase","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",260);}
case 260:{f.Push(JValue.R(rt.String(",")));f.Pc=263;continue;}
case 263:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",266);}
case 266:{return rt.Call(f,"forge/card/ColorSet","fromNames","([Ljava/lang/String;)Lforge/card/ColorSet;","invokestatic",269);}
case 269:{f.Locals[13]=f.Pop();f.Pc=271;continue;}
case 271:{f.Push(f.Locals[2]);f.Pc=272;continue;}
case 272:{f.Push(JValue.R(rt.String("SetManaCost")));f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",278);}
case 278:{f.Pc=f.Pop().Int==0?314:281;continue;}
case 281:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=284;continue;}
case 284:{f.StackOp("dup");f.Pc=285;continue;}
case 285:{f.Push(f.Locals[2]);f.Pc=286;continue;}
case 286:{f.Push(JValue.R(rt.String("SetManaCost")));f.Pc=289;continue;}
case 289:{return rt.Call(f,"forge/game/CardTraitBase","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",292);}
case 292:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(Ljava/lang/String;)V","invokespecial",295);}
case 295:{f.Locals[12]=f.Pop();f.Pc=297;continue;}
case 297:{f.Push(f.Locals[2]);f.Pc=298;continue;}
case 298:{f.Push(JValue.R(rt.String("SetColorByManaCost")));f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",304);}
case 304:{f.Pc=f.Pop().Int==0?314:307;continue;}
case 307:{f.Push(f.Locals[12]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"forge/card/ColorSet","fromManaCost","(Lforge/card/mana/ManaCost;)Lforge/card/ColorSet;","invokestatic",312);}
case 312:{f.Locals[13]=f.Pop();f.Pc=314;continue;}
case 314:{f.Push(f.Locals[0]);f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",318);}
case 318:{f.Pc=f.Pop().Int==0?341:321;continue;}
case 321:{f.Push(f.Locals[10]);f.Pc=323;continue;}
case 323:{f.Push(f.Locals[0]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/card/Card","getFaceDownState","()Lforge/game/card/CardState;","invokevirtual",327);}
case 327:{f.Push(f.Locals[1]);f.Pc=328;continue;}
case 328:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=331;continue;}
case 331:{f.Push(f.Locals[2]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/card/CardStateName;Lforge/game/CardTraitBase;)Lforge/game/card/CardState;","invokevirtual",335);}
case 335:{return rt.Call(f,"forge/game/card/CardCloneStates","add","(Lforge/game/card/CardState;)V","invokevirtual",338);}
case 338:{f.Pc=684;continue;}
case 341:{f.Push(f.Locals[0]);f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/game/card/Card","isFlipCard","()Z","invokevirtual",345);}
case 345:{f.Pc=f.Pop().Int==0?385:348;continue;}
case 348:{f.Push(f.Locals[10]);f.Pc=350;continue;}
case 350:{f.Push(f.Locals[0]);f.Pc=351;continue;}
case 351:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",357);}
case 357:{f.Push(f.Locals[1]);f.Pc=358;continue;}
case 358:{f.Push(f.Locals[2]);f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardState;","invokevirtual",362);}
case 362:{return rt.Call(f,"forge/game/card/CardCloneStates","add","(Lforge/game/card/CardState;)V","invokevirtual",365);}
case 365:{f.Push(f.Locals[10]);f.Pc=367;continue;}
case 367:{f.Push(f.Locals[0]);f.Pc=368;continue;}
case 368:{if(!rt.StaticReady(f,"forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"));f.Pc=371;continue;}
case 371:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",374);}
case 374:{f.Push(f.Locals[1]);f.Pc=375;continue;}
case 375:{f.Push(f.Locals[2]);f.Pc=376;continue;}
case 376:{return rt.Call(f,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardState;","invokevirtual",379);}
case 379:{return rt.Call(f,"forge/game/card/CardCloneStates","add","(Lforge/game/card/CardState;)V","invokevirtual",382);}
case 382:{f.Pc=684;continue;}
case 385:{f.Push(f.Locals[0]);f.Pc=386;continue;}
case 386:{if(!rt.StaticReady(f,"forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"));f.Pc=389;continue;}
case 389:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",392);}
case 392:{f.Pc=f.Pop().Int==0?432:395;continue;}
case 395:{f.Push(f.Locals[10]);f.Pc=397;continue;}
case 397:{f.Push(f.Locals[0]);f.Pc=398;continue;}
case 398:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",404);}
case 404:{f.Push(f.Locals[1]);f.Pc=405;continue;}
case 405:{f.Push(f.Locals[2]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardState;","invokevirtual",409);}
case 409:{return rt.Call(f,"forge/game/card/CardCloneStates","add","(Lforge/game/card/CardState;)V","invokevirtual",412);}
case 412:{f.Push(f.Locals[10]);f.Pc=414;continue;}
case 414:{f.Push(f.Locals[0]);f.Pc=415;continue;}
case 415:{if(!rt.StaticReady(f,"forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"));f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",421);}
case 421:{f.Push(f.Locals[1]);f.Pc=422;continue;}
case 422:{f.Push(f.Locals[2]);f.Pc=423;continue;}
case 423:{return rt.Call(f,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardState;","invokevirtual",426);}
case 426:{return rt.Call(f,"forge/game/card/CardCloneStates","add","(Lforge/game/card/CardState;)V","invokevirtual",429);}
case 429:{f.Pc=684;continue;}
case 432:{f.Push(f.Locals[0]);f.Pc=433;continue;}
case 433:{if(!rt.StaticReady(f,"forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"));f.Pc=436;continue;}
case 436:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",439);}
case 439:{f.Pc=f.Pop().Int==0?479:442;continue;}
case 442:{f.Push(f.Locals[10]);f.Pc=444;continue;}
case 444:{f.Push(f.Locals[0]);f.Pc=445;continue;}
case 445:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=448;continue;}
case 448:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",451);}
case 451:{f.Push(f.Locals[1]);f.Pc=452;continue;}
case 452:{f.Push(f.Locals[2]);f.Pc=453;continue;}
case 453:{return rt.Call(f,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardState;","invokevirtual",456);}
case 456:{return rt.Call(f,"forge/game/card/CardCloneStates","add","(Lforge/game/card/CardState;)V","invokevirtual",459);}
case 459:{f.Push(f.Locals[10]);f.Pc=461;continue;}
case 461:{f.Push(f.Locals[0]);f.Pc=462;continue;}
case 462:{if(!rt.StaticReady(f,"forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"));f.Pc=465;continue;}
case 465:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",468);}
case 468:{f.Push(f.Locals[1]);f.Pc=469;continue;}
case 469:{f.Push(f.Locals[2]);f.Pc=470;continue;}
case 470:{return rt.Call(f,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardState;","invokevirtual",473);}
case 473:{return rt.Call(f,"forge/game/card/CardCloneStates","add","(Lforge/game/card/CardState;)V","invokevirtual",476);}
case 476:{f.Pc=684;continue;}
case 479:{f.Push(f.Locals[0]);f.Pc=480;continue;}
case 480:{return rt.Call(f,"forge/game/card/Card","isTransformable","()Z","invokevirtual",483);}
case 483:{f.Pc=f.Pop().Int==0?578:486;continue;}
case 486:{f.Push(f.Locals[2]);f.Pc=487;continue;}
case 487:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/SpellAbility")?1:0));f.Pc=490;continue;}
case 490:{f.Pc=f.Pop().Int==0?578:493;continue;}
case 493:{f.Push(f.Locals[2]);f.Pc=494;continue;}
case 494:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=497;continue;}
case 497:{f.Locals[14]=f.Pop();f.Pc=499;continue;}
case 499:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","CopyPermanent","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","CopyPermanent","Lforge/game/ability/ApiType;"));f.Pc=502;continue;}
case 502:{f.Push(f.Locals[14]);f.Pc=504;continue;}
case 504:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",507);}
case 507:{return rt.Call(f,"forge/game/ability/ApiType","equals","(Ljava/lang/Object;)Z","invokevirtual",510);}
case 510:{f.Pc=f.Pop().Int!=0?541:513;continue;}
case 513:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","CopySpellAbility","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","CopySpellAbility","Lforge/game/ability/ApiType;"));f.Pc=516;continue;}
case 516:{f.Push(f.Locals[14]);f.Pc=518;continue;}
case 518:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",521);}
case 521:{return rt.Call(f,"forge/game/ability/ApiType","equals","(Ljava/lang/Object;)Z","invokevirtual",524);}
case 524:{f.Pc=f.Pop().Int!=0?541:527;continue;}
case 527:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceToken","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceToken","Lforge/game/ability/ApiType;"));f.Pc=530;continue;}
case 530:{f.Push(f.Locals[14]);f.Pc=532;continue;}
case 532:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",535);}
case 535:{return rt.Call(f,"forge/game/ability/ApiType","equals","(Ljava/lang/Object;)Z","invokevirtual",538);}
case 538:{f.Pc=f.Pop().Int==0?578:541;continue;}
case 541:{f.Push(f.Locals[10]);f.Pc=543;continue;}
case 543:{f.Push(f.Locals[0]);f.Pc=544;continue;}
case 544:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=547;continue;}
case 547:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",550);}
case 550:{f.Push(f.Locals[1]);f.Pc=551;continue;}
case 551:{f.Push(f.Locals[2]);f.Pc=552;continue;}
case 552:{return rt.Call(f,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardState;","invokevirtual",555);}
case 555:{return rt.Call(f,"forge/game/card/CardCloneStates","add","(Lforge/game/card/CardState;)V","invokevirtual",558);}
case 558:{f.Push(f.Locals[10]);f.Pc=560;continue;}
case 560:{f.Push(f.Locals[0]);f.Pc=561;continue;}
case 561:{if(!rt.StaticReady(f,"forge/card/CardStateName","Backside","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Backside","Lforge/card/CardStateName;"));f.Pc=564;continue;}
case 564:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",567);}
case 567:{f.Push(f.Locals[1]);f.Pc=568;continue;}
case 568:{f.Push(f.Locals[2]);f.Pc=569;continue;}
case 569:{return rt.Call(f,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardState;","invokevirtual",572);}
case 572:{return rt.Call(f,"forge/game/card/CardCloneStates","add","(Lforge/game/card/CardState;)V","invokevirtual",575);}
case 575:{f.Pc=684;continue;}
case 578:{f.Push(f.Locals[0]);f.Pc=579;continue;}
case 579:{return rt.Call(f,"forge/game/card/Card","isSplitCard","()Z","invokevirtual",582);}
case 582:{f.Pc=f.Pop().Int==0?663:585;continue;}
case 585:{f.Push(f.Locals[10]);f.Pc=587;continue;}
case 587:{f.Push(f.Locals[0]);f.Pc=588;continue;}
case 588:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=591;continue;}
case 591:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",594);}
case 594:{f.Push(f.Locals[1]);f.Pc=595;continue;}
case 595:{f.Push(f.Locals[2]);f.Pc=596;continue;}
case 596:{return rt.Call(f,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardState;","invokevirtual",599);}
case 599:{return rt.Call(f,"forge/game/card/CardCloneStates","add","(Lforge/game/card/CardState;)V","invokevirtual",602);}
case 602:{f.Push(f.Locals[10]);f.Pc=604;continue;}
case 604:{f.Push(f.Locals[0]);f.Pc=605;continue;}
case 605:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=608;continue;}
case 608:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",611);}
case 611:{f.Push(f.Locals[1]);f.Pc=612;continue;}
case 612:{f.Push(f.Locals[2]);f.Pc=613;continue;}
case 613:{return rt.Call(f,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardState;","invokevirtual",616);}
case 616:{return rt.Call(f,"forge/game/card/CardCloneStates","add","(Lforge/game/card/CardState;)V","invokevirtual",619);}
case 619:{f.Push(f.Locals[10]);f.Pc=621;continue;}
case 621:{f.Push(f.Locals[0]);f.Pc=622;continue;}
case 622:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=625;continue;}
case 625:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",628);}
case 628:{f.Push(f.Locals[1]);f.Pc=629;continue;}
case 629:{f.Push(f.Locals[2]);f.Pc=630;continue;}
case 630:{return rt.Call(f,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardState;","invokevirtual",633);}
case 633:{return rt.Call(f,"forge/game/card/CardCloneStates","add","(Lforge/game/card/CardState;)V","invokevirtual",636);}
case 636:{f.Push(f.Locals[0]);f.Pc=637;continue;}
case 637:{return rt.Call(f,"forge/game/card/Card","isPermanent","()Z","invokevirtual",640);}
case 640:{f.Pc=f.Pop().Int==0?684:643;continue;}
case 643:{f.Push(f.Locals[10]);f.Pc=645;continue;}
case 645:{f.Push(f.Locals[0]);f.Pc=646;continue;}
case 646:{if(!rt.StaticReady(f,"forge/card/CardStateName","EmptyRoom","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","EmptyRoom","Lforge/card/CardStateName;"));f.Pc=649;continue;}
case 649:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",652);}
case 652:{f.Push(f.Locals[1]);f.Pc=653;continue;}
case 653:{f.Push(f.Locals[2]);f.Pc=654;continue;}
case 654:{return rt.Call(f,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardState;","invokevirtual",657);}
case 657:{return rt.Call(f,"forge/game/card/CardCloneStates","add","(Lforge/game/card/CardState;)V","invokevirtual",660);}
case 660:{f.Pc=684;continue;}
case 663:{f.Push(f.Locals[10]);f.Pc=665;continue;}
case 665:{f.Push(f.Locals[0]);f.Pc=666;continue;}
case 666:{f.Push(f.Locals[0]);f.Pc=667;continue;}
case 667:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",670);}
case 670:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",673);}
case 673:{f.Push(f.Locals[1]);f.Pc=674;continue;}
case 674:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=677;continue;}
case 677:{f.Push(f.Locals[2]);f.Pc=678;continue;}
case 678:{return rt.Call(f,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/card/CardStateName;Lforge/game/CardTraitBase;)Lforge/game/card/CardState;","invokevirtual",681);}
case 681:{return rt.Call(f,"forge/game/card/CardCloneStates","add","(Lforge/game/card/CardState;)V","invokevirtual",684);}
case 684:{f.Push(f.Locals[10]);f.Pc=686;continue;}
case 686:{return rt.Call(f,"forge/game/card/CardCloneStates","entrySet","()Ljava/util/Set;","invokevirtual",689);}
case 689:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",694);}
case 694:{f.Locals[14]=f.Pop();f.Pc=696;continue;}
case 696:{f.Push(f.Locals[14]);f.Pc=698;continue;}
case 698:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",703);}
case 703:{f.Pc=f.Pop().Int==0?2242:706;continue;}
case 706:{f.Push(f.Locals[14]);f.Pc=708;continue;}
case 708:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",713);}
case 713:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=716;continue;}
case 716:{f.Locals[15]=f.Pop();f.Pc=718;continue;}
case 718:{f.Push(f.Locals[1]);f.Pc=719;continue;}
case 719:{f.Push(f.Locals[15]);f.Pc=721;continue;}
case 721:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",726);}
case 726:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardStateName"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=729;continue;}
case 729:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",732);}
case 732:{f.Locals[16]=f.Pop();f.Pc=734;continue;}
case 734:{f.Push(f.Locals[15]);f.Pc=736;continue;}
case 736:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",741);}
case 741:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardState"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=744;continue;}
case 744:{f.Locals[17]=f.Pop();f.Pc=746;continue;}
case 746:{f.Push(f.Locals[2]);f.Pc=747;continue;}
case 747:{f.Push(JValue.R(rt.String("Embalm")));f.Pc=750;continue;}
case 750:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",753);}
case 753:{f.Pc=f.Pop().Int==0?766:756;continue;}
case 756:{f.Push(f.Locals[1]);f.Pc=757;continue;}
case 757:{return rt.Call(f,"forge/game/card/Card","isEmbalmed","()Z","invokevirtual",760);}
case 760:{f.Pc=f.Pop().Int!=0?766:763;continue;}
case 763:{f.Pc=696;continue;}
case 766:{f.Push(f.Locals[2]);f.Pc=767;continue;}
case 767:{f.Push(JValue.R(rt.String("KeepName")));f.Pc=770;continue;}
case 770:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",773);}
case 773:{f.Pc=f.Pop().Int==0?789:776;continue;}
case 776:{f.Push(f.Locals[17]);f.Pc=778;continue;}
case 778:{f.Push(f.Locals[16]);f.Pc=780;continue;}
case 780:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",783);}
case 783:{return rt.Call(f,"forge/game/card/CardState","setName","(Ljava/lang/String;)V","invokevirtual",786);}
case 786:{f.Pc=801;continue;}
case 789:{f.Push(f.Locals[11]);f.Pc=791;continue;}
case 791:{f.Pc=f.Pop().Reference==null?801:794;continue;}
case 794:{f.Push(f.Locals[17]);f.Pc=796;continue;}
case 796:{f.Push(f.Locals[11]);f.Pc=798;continue;}
case 798:{return rt.Call(f,"forge/game/card/CardState","setName","(Ljava/lang/String;)V","invokevirtual",801);}
case 801:{f.Push(f.Locals[2]);f.Pc=802;continue;}
case 802:{f.Push(JValue.R(rt.String("AddColors")));f.Pc=805;continue;}
case 805:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",808);}
case 808:{f.Pc=f.Pop().Int==0?818:811;continue;}
case 811:{f.Push(f.Locals[17]);f.Pc=813;continue;}
case 813:{f.Push(f.Locals[13]);f.Pc=815;continue;}
case 815:{return rt.Call(f,"forge/game/card/CardState","addColor","(Lforge/card/ColorSet;)V","invokevirtual",818);}
case 818:{f.Push(f.Locals[2]);f.Pc=819;continue;}
case 819:{f.Push(JValue.R(rt.String("SetColor")));f.Pc=822;continue;}
case 822:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",825);}
case 825:{f.Pc=f.Pop().Int!=0?838:828;continue;}
case 828:{f.Push(f.Locals[2]);f.Pc=829;continue;}
case 829:{f.Push(JValue.R(rt.String("SetColorByManaCost")));f.Pc=832;continue;}
case 832:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",835);}
case 835:{f.Pc=f.Pop().Int==0?845:838;continue;}
case 838:{f.Push(f.Locals[17]);f.Pc=840;continue;}
case 840:{f.Push(f.Locals[13]);f.Pc=842;continue;}
case 842:{return rt.Call(f,"forge/game/card/CardState","setColor","(Lforge/card/ColorSet;)V","invokevirtual",845);}
case 845:{f.Push(f.Locals[2]);f.Pc=846;continue;}
case 846:{f.Push(JValue.R(rt.String("NonLegendary")));f.Pc=849;continue;}
case 849:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",852);}
case 852:{f.Pc=f.Pop().Int==0?863:855;continue;}
case 855:{f.Push(f.Locals[17]);f.Pc=857;continue;}
case 857:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","Legendary","Lforge/card/CardType$Supertype;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Supertype","Legendary","Lforge/card/CardType$Supertype;"));f.Pc=860;continue;}
case 860:{return rt.Call(f,"forge/game/card/CardState","removeType","(Lforge/card/CardType$Supertype;)V","invokevirtual",863);}
case 863:{f.Push(f.Locals[2]);f.Pc=864;continue;}
case 864:{f.Push(JValue.R(rt.String("RemoveCardTypes")));f.Pc=867;continue;}
case 867:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",870);}
case 870:{f.Pc=f.Pop().Int==0?885:873;continue;}
case 873:{f.Push(f.Locals[17]);f.Pc=875;continue;}
case 875:{f.Push(f.Locals[2]);f.Pc=876;continue;}
case 876:{f.Push(JValue.R(rt.String("RemoveSubTypes")));f.Pc=879;continue;}
case 879:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",882);}
case 882:{return rt.Call(f,"forge/game/card/CardState","removeCardTypes","(Z)V","invokevirtual",885);}
case 885:{f.Push(f.Locals[17]);f.Pc=887;continue;}
case 887:{f.Push(f.Locals[5]);f.Pc=889;continue;}
case 889:{return rt.Call(f,"forge/game/card/CardState","addType","(Ljava/lang/Iterable;)V","invokevirtual",892);}
case 892:{f.Push(f.Locals[9]);f.Pc=894;continue;}
case 894:{f.Pc=f.Pop().Reference==null?904:897;continue;}
case 897:{f.Push(f.Locals[17]);f.Pc=899;continue;}
case 899:{f.Push(f.Locals[9]);f.Pc=901;continue;}
case 901:{return rt.Call(f,"forge/game/card/CardState","setCreatureTypes","(Ljava/util/Collection;)V","invokevirtual",904);}
case 904:{f.Push(f.Locals[6]);f.Pc=906;continue;}
case 906:{f.Locals[18]=f.Pop();f.Pc=908;continue;}
case 908:{f.Push(f.Locals[7]);f.Pc=910;continue;}
case 910:{f.Pc=f.Pop().Int==0?945:913;continue;}
case 913:{f.Push(f.Locals[6]);f.Pc=915;continue;}
case 915:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",920);}
case 920:{f.Push(f.Locals[17]);f.Pc=922;continue;}
case 922:{return rt.DynamicCall(f,"forge/game/card/CardFactory:5001:922:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/CardState;)Ljava/util/function/Predicate;",927);}
case 927:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",932);}
case 932:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",935);}
case 935:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",940);}
case 940:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=943;continue;}
case 943:{f.Locals[18]=f.Pop();f.Pc=945;continue;}
case 945:{f.Push(f.Locals[17]);f.Pc=947;continue;}
case 947:{f.Push(f.Locals[18]);f.Pc=949;continue;}
case 949:{return rt.Call(f,"forge/game/card/CardState","addIntrinsicKeywords","(Ljava/lang/Iterable;)Z","invokevirtual",952);}
case 952:{f.StackOp("pop");f.Pc=953;continue;}
case 953:{f.Push(f.Locals[8]);f.Pc=955;continue;}
case 955:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",960);}
case 960:{f.Locals[19]=f.Pop();f.Pc=962;continue;}
case 962:{f.Push(f.Locals[19]);f.Pc=964;continue;}
case 964:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",969);}
case 969:{f.Pc=f.Pop().Int==0?995:972;continue;}
case 972:{f.Push(f.Locals[19]);f.Pc=974;continue;}
case 974:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",979);}
case 979:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=982;continue;}
case 982:{f.Locals[20]=f.Pop();f.Pc=984;continue;}
case 984:{f.Push(f.Locals[17]);f.Pc=986;continue;}
case 986:{f.Push(f.Locals[20]);f.Pc=988;continue;}
case 988:{return rt.Call(f,"forge/game/card/CardState","removeIntrinsicKeyword","(Ljava/lang/String;)Z","invokevirtual",991);}
case 991:{f.StackOp("pop");f.Pc=992;continue;}
case 992:{f.Pc=962;continue;}
case 995:{f.Push(f.Locals[2]);f.Pc=996;continue;}
case 996:{f.Push(JValue.R(rt.String("SetPower")));f.Pc=999;continue;}
case 999:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",1002);}
case 1002:{f.Pc=f.Pop().Int!=0?1015:1005;continue;}
case 1005:{f.Push(f.Locals[2]);f.Pc=1006;continue;}
case 1006:{f.Push(JValue.R(rt.String("SetToughness")));f.Pc=1009;continue;}
case 1009:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",1012);}
case 1012:{f.Pc=f.Pop().Int==0?1102:1015;continue;}
case 1015:{f.Push(f.Locals[17]);f.Pc=1017;continue;}
case 1017:{return rt.Call(f,"forge/game/card/CardState","getType","()Lforge/card/CardTypeView;","invokevirtual",1020);}
case 1020:{return rt.Call(f,"forge/card/CardTypeView","isCreature","()Z","invokeinterface",1025);}
case 1025:{f.Pc=f.Pop().Int!=0?1048:1028;continue;}
case 1028:{f.Push(f.Locals[16]);f.Pc=1030;continue;}
case 1030:{f.Pc=f.Pop().Reference==null?1102:1033;continue;}
case 1033:{f.Push(f.Locals[0]);f.Pc=1034;continue;}
case 1034:{f.Push(f.Locals[16]);f.Pc=1036;continue;}
case 1036:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",1039);}
case 1039:{return rt.Call(f,"forge/game/card/Card","getOriginalState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",1042);}
case 1042:{return rt.Call(f,"forge/game/card/CardState","hasPrintedPT","()Z","invokevirtual",1045);}
case 1045:{f.Pc=f.Pop().Int==0?1102:1048;continue;}
case 1048:{f.Push(f.Locals[2]);f.Pc=1049;continue;}
case 1049:{f.Push(JValue.R(rt.String("SetPower")));f.Pc=1052;continue;}
case 1052:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",1055);}
case 1055:{f.Pc=f.Pop().Int==0?1075:1058;continue;}
case 1058:{f.Push(f.Locals[17]);f.Pc=1060;continue;}
case 1060:{f.Push(f.Locals[3]);f.Pc=1061;continue;}
case 1061:{f.Push(f.Locals[2]);f.Pc=1062;continue;}
case 1062:{f.Push(JValue.R(rt.String("SetPower")));f.Pc=1065;continue;}
case 1065:{return rt.Call(f,"forge/game/CardTraitBase","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1068);}
case 1068:{f.Push(f.Locals[2]);f.Pc=1069;continue;}
case 1069:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1072);}
case 1072:{return rt.Call(f,"forge/game/card/CardState","setBasePower","(I)V","invokevirtual",1075);}
case 1075:{f.Push(f.Locals[2]);f.Pc=1076;continue;}
case 1076:{f.Push(JValue.R(rt.String("SetToughness")));f.Pc=1079;continue;}
case 1079:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",1082);}
case 1082:{f.Pc=f.Pop().Int==0?1102:1085;continue;}
case 1085:{f.Push(f.Locals[17]);f.Pc=1087;continue;}
case 1087:{f.Push(f.Locals[3]);f.Pc=1088;continue;}
case 1088:{f.Push(f.Locals[2]);f.Pc=1089;continue;}
case 1089:{f.Push(JValue.R(rt.String("SetToughness")));f.Pc=1092;continue;}
case 1092:{return rt.Call(f,"forge/game/CardTraitBase","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1095);}
case 1095:{f.Push(f.Locals[2]);f.Pc=1096;continue;}
case 1096:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1099);}
case 1099:{return rt.Call(f,"forge/game/card/CardState","setBaseToughness","(I)V","invokevirtual",1102);}
case 1102:{f.Push(f.Locals[17]);f.Pc=1104;continue;}
case 1104:{return rt.Call(f,"forge/game/card/CardState","getType","()Lforge/card/CardTypeView;","invokevirtual",1107);}
case 1107:{return rt.Call(f,"forge/card/CardTypeView","isPlaneswalker","()Z","invokeinterface",1112);}
case 1112:{f.Pc=f.Pop().Int==0?1145:1115;continue;}
case 1115:{f.Push(f.Locals[2]);f.Pc=1116;continue;}
case 1116:{f.Push(JValue.R(rt.String("SetLoyalty")));f.Pc=1119;continue;}
case 1119:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",1122);}
case 1122:{f.Pc=f.Pop().Int==0?1145:1125;continue;}
case 1125:{f.Push(f.Locals[17]);f.Pc=1127;continue;}
case 1127:{f.Push(f.Locals[3]);f.Pc=1128;continue;}
case 1128:{f.Push(f.Locals[2]);f.Pc=1129;continue;}
case 1129:{f.Push(JValue.R(rt.String("SetLoyalty")));f.Pc=1132;continue;}
case 1132:{return rt.Call(f,"forge/game/CardTraitBase","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1135);}
case 1135:{f.Push(f.Locals[2]);f.Pc=1136;continue;}
case 1136:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1139);}
case 1139:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",1142);}
case 1142:{return rt.Call(f,"forge/game/card/CardState","setBaseLoyalty","(Ljava/lang/String;)V","invokevirtual",1145);}
case 1145:{f.Push(f.Locals[2]);f.Pc=1146;continue;}
case 1146:{f.Push(JValue.R(rt.String("RemoveCost")));f.Pc=1149;continue;}
case 1149:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",1152);}
case 1152:{f.Pc=f.Pop().Int==0?1163:1155;continue;}
case 1155:{f.Push(f.Locals[17]);f.Pc=1157;continue;}
case 1157:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","NO_COST","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","NO_COST","Lforge/card/mana/ManaCost;"));f.Pc=1160;continue;}
case 1160:{return rt.Call(f,"forge/game/card/CardState","setManaCost","(Lforge/card/mana/ManaCost;)V","invokevirtual",1163);}
case 1163:{f.Push(f.Locals[2]);f.Pc=1164;continue;}
case 1164:{f.Push(JValue.R(rt.String("SetManaCost")));f.Pc=1167;continue;}
case 1167:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",1170);}
case 1170:{f.Pc=f.Pop().Int==0?1180:1173;continue;}
case 1173:{f.Push(f.Locals[17]);f.Pc=1175;continue;}
case 1175:{f.Push(f.Locals[12]);f.Pc=1177;continue;}
case 1177:{return rt.Call(f,"forge/game/card/CardState","setManaCost","(Lforge/card/mana/ManaCost;)V","invokevirtual",1180);}
case 1180:{f.Push(f.Locals[2]);f.Pc=1181;continue;}
case 1181:{f.Push(JValue.R(rt.String("AddSVars")));f.Pc=1184;continue;}
case 1184:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",1187);}
case 1187:{f.Pc=f.Pop().Int==0?1272:1190;continue;}
case 1190:{f.Push(f.Locals[2]);f.Pc=1191;continue;}
case 1191:{f.Push(JValue.R(rt.String("AddSVars")));f.Pc=1194;continue;}
case 1194:{return rt.Call(f,"forge/game/CardTraitBase","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1197);}
case 1197:{f.Locals[19]=f.Pop();f.Pc=1199;continue;}
case 1199:{f.Push(f.Locals[19]);f.Pc=1201;continue;}
case 1201:{f.Push(JValue.R(rt.String(",")));f.Pc=1204;continue;}
case 1204:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1207);}
case 1207:{f.Locals[20]=f.Pop();f.Pc=1209;continue;}
case 1209:{f.Push(f.Locals[20]);f.Pc=1211;continue;}
case 1211:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1212;continue;}
case 1212:{f.Locals[21]=f.Pop();f.Pc=1214;continue;}
case 1214:{f.Push(JValue.I(0));f.Pc=1215;continue;}
case 1215:{f.Locals[22]=f.Pop();f.Pc=1217;continue;}
case 1217:{f.Push(f.Locals[22]);f.Pc=1219;continue;}
case 1219:{f.Push(f.Locals[21]);f.Pc=1221;continue;}
case 1221:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1272:1224;continue;}
case 1224:{f.Push(f.Locals[20]);f.Pc=1226;continue;}
case 1226:{f.Push(f.Locals[22]);f.Pc=1228;continue;}
case 1228:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1229;continue;}
case 1229:{f.Locals[23]=f.Pop();f.Pc=1231;continue;}
case 1231:{f.Push(f.Locals[4]);f.Pc=1233;continue;}
case 1233:{f.Push(f.Locals[23]);f.Pc=1235;continue;}
case 1235:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1240);}
case 1240:{f.Pc=f.Pop().Int==0?1266:1243;continue;}
case 1243:{f.Push(f.Locals[4]);f.Pc=1245;continue;}
case 1245:{f.Push(f.Locals[23]);f.Pc=1247;continue;}
case 1247:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1252);}
case 1252:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1255;continue;}
case 1255:{f.Locals[24]=f.Pop();f.Pc=1257;continue;}
case 1257:{f.Push(f.Locals[17]);f.Pc=1259;continue;}
case 1259:{f.Push(f.Locals[23]);f.Pc=1261;continue;}
case 1261:{f.Push(f.Locals[24]);f.Pc=1263;continue;}
case 1263:{return rt.Call(f,"forge/game/card/CardState","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",1266);}
case 1266:{f.Locals[22]=JValue.I(unchecked(f.Locals[22].Int+(1)));f.Pc=1269;continue;}
case 1269:{f.Pc=1217;continue;}
case 1272:{f.Push(f.Locals[2]);f.Pc=1273;continue;}
case 1273:{f.Push(JValue.R(rt.String("AddTriggers")));f.Pc=1276;continue;}
case 1276:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",1279);}
case 1279:{f.Pc=f.Pop().Int==0?1370:1282;continue;}
case 1282:{f.Push(f.Locals[2]);f.Pc=1283;continue;}
case 1283:{f.Push(JValue.R(rt.String("AddTriggers")));f.Pc=1286;continue;}
case 1286:{return rt.Call(f,"forge/game/CardTraitBase","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1289);}
case 1289:{f.Push(JValue.R(rt.String(",")));f.Pc=1292;continue;}
case 1292:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1295);}
case 1295:{f.Locals[19]=f.Pop();f.Pc=1297;continue;}
case 1297:{f.Push(f.Locals[19]);f.Pc=1299;continue;}
case 1299:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1300;continue;}
case 1300:{f.Locals[20]=f.Pop();f.Pc=1302;continue;}
case 1302:{f.Push(JValue.I(0));f.Pc=1303;continue;}
case 1303:{f.Locals[21]=f.Pop();f.Pc=1305;continue;}
case 1305:{f.Push(f.Locals[21]);f.Pc=1307;continue;}
case 1307:{f.Push(f.Locals[20]);f.Pc=1309;continue;}
case 1309:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1370:1312;continue;}
case 1312:{f.Push(f.Locals[19]);f.Pc=1314;continue;}
case 1314:{f.Push(f.Locals[21]);f.Pc=1316;continue;}
case 1316:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1317;continue;}
case 1317:{f.Locals[22]=f.Pop();f.Pc=1319;continue;}
case 1319:{f.Push(f.Locals[4]);f.Pc=1321;continue;}
case 1321:{f.Push(f.Locals[22]);f.Pc=1323;continue;}
case 1323:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1328);}
case 1328:{f.Pc=f.Pop().Int==0?1364:1331;continue;}
case 1331:{f.Push(f.Locals[4]);f.Pc=1333;continue;}
case 1333:{f.Push(f.Locals[22]);f.Pc=1335;continue;}
case 1335:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1340);}
case 1340:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1343;continue;}
case 1343:{f.Locals[23]=f.Pop();f.Pc=1345;continue;}
case 1345:{f.Push(f.Locals[23]);f.Pc=1347;continue;}
case 1347:{f.Push(f.Locals[1]);f.Pc=1348;continue;}
case 1348:{f.Push(JValue.I(1));f.Pc=1349;continue;}
case 1349:{f.Push(f.Locals[17]);f.Pc=1351;continue;}
case 1351:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/trigger/Trigger;","invokestatic",1354);}
case 1354:{f.Locals[24]=f.Pop();f.Pc=1356;continue;}
case 1356:{f.Push(f.Locals[17]);f.Pc=1358;continue;}
case 1358:{f.Push(f.Locals[24]);f.Pc=1360;continue;}
case 1360:{return rt.Call(f,"forge/game/card/CardState","addTrigger","(Lforge/game/trigger/Trigger;)Z","invokevirtual",1363);}
case 1363:{f.StackOp("pop");f.Pc=1364;continue;}
case 1364:{f.Locals[21]=JValue.I(unchecked(f.Locals[21].Int+(1)));f.Pc=1367;continue;}
case 1367:{f.Pc=1305;continue;}
case 1370:{f.Push(f.Locals[2]);f.Pc=1371;continue;}
case 1371:{f.Push(JValue.R(rt.String("AddAbilities")));f.Pc=1374;continue;}
case 1374:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",1377);}
case 1377:{f.Pc=f.Pop().Int!=0?1390:1380;continue;}
case 1380:{f.Push(f.Locals[2]);f.Pc=1381;continue;}
case 1381:{f.Push(JValue.R(rt.String("GainTextAbilities")));f.Pc=1384;continue;}
case 1384:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",1387);}
case 1387:{f.Pc=f.Pop().Int==0?1492:1390;continue;}
case 1390:{f.Push(f.Locals[2]);f.Pc=1391;continue;}
case 1391:{f.Push(JValue.R(rt.String("GainTextAbilities")));f.Pc=1394;continue;}
case 1394:{f.Push(f.Locals[2]);f.Pc=1395;continue;}
case 1395:{f.Push(JValue.R(rt.String("AddAbilities")));f.Pc=1398;continue;}
case 1398:{return rt.Call(f,"forge/game/CardTraitBase","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1401);}
case 1401:{return rt.Call(f,"forge/game/CardTraitBase","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1404);}
case 1404:{f.Locals[19]=f.Pop();f.Pc=1406;continue;}
case 1406:{f.Push(f.Locals[19]);f.Pc=1408;continue;}
case 1408:{f.Push(JValue.R(rt.String(",")));f.Pc=1411;continue;}
case 1411:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1414);}
case 1414:{f.Locals[20]=f.Pop();f.Pc=1416;continue;}
case 1416:{f.Push(f.Locals[20]);f.Pc=1418;continue;}
case 1418:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1419;continue;}
case 1419:{f.Locals[21]=f.Pop();f.Pc=1421;continue;}
case 1421:{f.Push(JValue.I(0));f.Pc=1422;continue;}
case 1422:{f.Locals[22]=f.Pop();f.Pc=1424;continue;}
case 1424:{f.Push(f.Locals[22]);f.Pc=1426;continue;}
case 1426:{f.Push(f.Locals[21]);f.Pc=1428;continue;}
case 1428:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1492:1431;continue;}
case 1431:{f.Push(f.Locals[20]);f.Pc=1433;continue;}
case 1433:{f.Push(f.Locals[22]);f.Pc=1435;continue;}
case 1435:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1436;continue;}
case 1436:{f.Locals[23]=f.Pop();f.Pc=1438;continue;}
case 1438:{f.Push(f.Locals[4]);f.Pc=1440;continue;}
case 1440:{f.Push(f.Locals[23]);f.Pc=1442;continue;}
case 1442:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1447);}
case 1447:{f.Pc=f.Pop().Int==0?1486:1450;continue;}
case 1450:{f.Push(f.Locals[4]);f.Pc=1452;continue;}
case 1452:{f.Push(f.Locals[23]);f.Pc=1454;continue;}
case 1454:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1459);}
case 1459:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1462;continue;}
case 1462:{f.Locals[24]=f.Pop();f.Pc=1464;continue;}
case 1464:{f.Push(f.Locals[24]);f.Pc=1466;continue;}
case 1466:{f.Push(f.Locals[1]);f.Pc=1467;continue;}
case 1467:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",1470);}
case 1470:{f.Locals[25]=f.Pop();f.Pc=1472;continue;}
case 1472:{f.Push(f.Locals[25]);f.Pc=1474;continue;}
case 1474:{f.Push(JValue.I(1));f.Pc=1475;continue;}
case 1475:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",1478);}
case 1478:{f.Push(f.Locals[17]);f.Pc=1480;continue;}
case 1480:{f.Push(f.Locals[25]);f.Pc=1482;continue;}
case 1482:{return rt.Call(f,"forge/game/card/CardState","addSpellAbility","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",1485);}
case 1485:{f.StackOp("pop");f.Pc=1486;continue;}
case 1486:{f.Locals[22]=JValue.I(unchecked(f.Locals[22].Int+(1)));f.Pc=1489;continue;}
case 1489:{f.Pc=1424;continue;}
case 1492:{f.Push(f.Locals[2]);f.Pc=1493;continue;}
case 1493:{f.Push(JValue.R(rt.String("AddStaticAbilities")));f.Pc=1496;continue;}
case 1496:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",1499);}
case 1499:{f.Pc=f.Pop().Int==0?1592:1502;continue;}
case 1502:{f.Push(f.Locals[2]);f.Pc=1503;continue;}
case 1503:{f.Push(JValue.R(rt.String("AddStaticAbilities")));f.Pc=1506;continue;}
case 1506:{return rt.Call(f,"forge/game/CardTraitBase","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1509);}
case 1509:{f.Locals[19]=f.Pop();f.Pc=1511;continue;}
case 1511:{f.Push(f.Locals[19]);f.Pc=1513;continue;}
case 1513:{f.Push(JValue.R(rt.String(",")));f.Pc=1516;continue;}
case 1516:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1519);}
case 1519:{f.Locals[20]=f.Pop();f.Pc=1521;continue;}
case 1521:{f.Push(f.Locals[20]);f.Pc=1523;continue;}
case 1523:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1524;continue;}
case 1524:{f.Locals[21]=f.Pop();f.Pc=1526;continue;}
case 1526:{f.Push(JValue.I(0));f.Pc=1527;continue;}
case 1527:{f.Locals[22]=f.Pop();f.Pc=1529;continue;}
case 1529:{f.Push(f.Locals[22]);f.Pc=1531;continue;}
case 1531:{f.Push(f.Locals[21]);f.Pc=1533;continue;}
case 1533:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1592:1536;continue;}
case 1536:{f.Push(f.Locals[20]);f.Pc=1538;continue;}
case 1538:{f.Push(f.Locals[22]);f.Pc=1540;continue;}
case 1540:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1541;continue;}
case 1541:{f.Locals[23]=f.Pop();f.Pc=1543;continue;}
case 1543:{f.Push(f.Locals[4]);f.Pc=1545;continue;}
case 1545:{f.Push(f.Locals[23]);f.Pc=1547;continue;}
case 1547:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1552);}
case 1552:{f.Pc=f.Pop().Int==0?1586:1555;continue;}
case 1555:{f.Push(f.Locals[4]);f.Pc=1557;continue;}
case 1557:{f.Push(f.Locals[23]);f.Pc=1559;continue;}
case 1559:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1564);}
case 1564:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1567;continue;}
case 1567:{f.Locals[24]=f.Pop();f.Pc=1569;continue;}
case 1569:{f.Push(f.Locals[17]);f.Pc=1571;continue;}
case 1571:{f.Push(f.Locals[24]);f.Pc=1573;continue;}
case 1573:{f.Push(f.Locals[1]);f.Pc=1574;continue;}
case 1574:{f.Push(f.Locals[2]);f.Pc=1575;continue;}
case 1575:{return rt.Call(f,"forge/game/CardTraitBase","getCardState","()Lforge/game/card/CardState;","invokevirtual",1578);}
case 1578:{f.Push(JValue.I(1));f.Pc=1579;continue;}
case 1579:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",1582);}
case 1582:{return rt.Call(f,"forge/game/card/CardState","addStaticAbility","(Lforge/game/staticability/StaticAbility;)Z","invokevirtual",1585);}
case 1585:{f.StackOp("pop");f.Pc=1586;continue;}
case 1586:{f.Locals[22]=JValue.I(unchecked(f.Locals[22].Int+(1)));f.Pc=1589;continue;}
case 1589:{f.Pc=1529;continue;}
case 1592:{f.Push(f.Locals[2]);f.Pc=1593;continue;}
case 1593:{f.Push(JValue.R(rt.String("GainThisAbility")));f.Pc=1596;continue;}
case 1596:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",1599);}
case 1599:{f.Pc=f.Pop().Int==0?1718:1602;continue;}
case 1602:{f.Push(f.Locals[2]);f.Pc=1603;continue;}
case 1603:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/SpellAbility")?1:0));f.Pc=1606;continue;}
case 1606:{f.Pc=f.Pop().Int==0?1718:1609;continue;}
case 1609:{f.Push(f.Locals[2]);f.Pc=1610;continue;}
case 1610:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1613;continue;}
case 1613:{f.Locals[19]=f.Pop();f.Pc=1615;continue;}
case 1615:{f.Push(f.Locals[19]);f.Pc=1617;continue;}
case 1617:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",1620);}
case 1620:{f.Locals[20]=f.Pop();f.Pc=1622;continue;}
case 1622:{f.Push(f.Locals[20]);f.Pc=1624;continue;}
case 1624:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",1627);}
case 1627:{f.Pc=f.Pop().Int==0?1651:1630;continue;}
case 1630:{f.Push(f.Locals[20]);f.Pc=1632;continue;}
case 1632:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",1635);}
case 1635:{return rt.Call(f,"forge/game/trigger/Trigger","getSpawningAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",1638);}
case 1638:{f.Pc=f.Pop().Reference==null?1651:1641;continue;}
case 1641:{f.Push(f.Locals[20]);f.Pc=1643;continue;}
case 1643:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",1646);}
case 1646:{return rt.Call(f,"forge/game/trigger/Trigger","getSpawningAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",1649);}
case 1649:{f.Locals[20]=f.Pop();f.Pc=1651;continue;}
case 1651:{f.Push(f.Locals[20]);f.Pc=1653;continue;}
case 1653:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",1656);}
case 1656:{f.Pc=f.Pop().Int==0?1678:1659;continue;}
case 1659:{f.Push(f.Locals[17]);f.Pc=1661;continue;}
case 1661:{f.Push(f.Locals[20]);f.Pc=1663;continue;}
case 1663:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",1666);}
case 1666:{f.Push(f.Locals[1]);f.Pc=1667;continue;}
case 1667:{f.Push(JValue.I(0));f.Pc=1668;continue;}
case 1668:{return rt.Call(f,"forge/game/trigger/Trigger","copy","(Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokevirtual",1671);}
case 1671:{return rt.Call(f,"forge/game/card/CardState","addTrigger","(Lforge/game/trigger/Trigger;)Z","invokevirtual",1674);}
case 1674:{f.StackOp("pop");f.Pc=1675;continue;}
case 1675:{f.Pc=1718;continue;}
case 1678:{f.Push(f.Locals[20]);f.Pc=1680;continue;}
case 1680:{return rt.Call(f,"forge/game/spellability/SpellAbility","isReplacementAbility","()Z","invokevirtual",1683);}
case 1683:{f.Pc=f.Pop().Int==0?1705:1686;continue;}
case 1686:{f.Push(f.Locals[17]);f.Pc=1688;continue;}
case 1688:{f.Push(f.Locals[20]);f.Pc=1690;continue;}
case 1690:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacementEffect","()Lforge/game/replacement/ReplacementEffect;","invokevirtual",1693);}
case 1693:{f.Push(f.Locals[1]);f.Pc=1694;continue;}
case 1694:{f.Push(JValue.I(0));f.Pc=1695;continue;}
case 1695:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","copy","(Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokevirtual",1698);}
case 1698:{return rt.Call(f,"forge/game/card/CardState","addReplacementEffect","(Lforge/game/replacement/ReplacementEffect;)Z","invokevirtual",1701);}
case 1701:{f.StackOp("pop");f.Pc=1702;continue;}
case 1702:{f.Pc=1718;continue;}
case 1705:{f.Push(f.Locals[17]);f.Pc=1707;continue;}
case 1707:{f.Push(f.Locals[20]);f.Pc=1709;continue;}
case 1709:{f.Push(f.Locals[1]);f.Pc=1710;continue;}
case 1710:{f.Push(JValue.I(0));f.Pc=1711;continue;}
case 1711:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",1714);}
case 1714:{return rt.Call(f,"forge/game/card/CardState","addSpellAbility","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",1717);}
case 1717:{f.StackOp("pop");f.Pc=1718;continue;}
case 1718:{f.Push(f.Locals[2]);f.Pc=1719;continue;}
case 1719:{return rt.Call(f,"forge/game/CardTraitBase","isEmbalm","()Z","invokevirtual",1722);}
case 1722:{f.Pc=f.Pop().Int==0?1780:1725;continue;}
case 1725:{f.Push(f.Locals[2]);f.Pc=1726;continue;}
case 1726:{return rt.Call(f,"forge/game/CardTraitBase","isIntrinsic","()Z","invokevirtual",1729);}
case 1729:{f.Pc=f.Pop().Int==0?1780:1732;continue;}
case 1732:{f.Push(f.Locals[3]);f.Pc=1733;continue;}
case 1733:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",1736);}
case 1736:{f.Push(JValue.R(rt.String(",")));f.Pc=1739;continue;}
case 1739:{f.Push(JValue.R(rt.String("")));f.Pc=1741;continue;}
case 1741:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1744);}
case 1744:{f.Push(JValue.R(rt.String(" ")));f.Pc=1747;continue;}
case 1747:{f.Push(JValue.R(rt.String("_")));f.Pc=1750;continue;}
case 1750:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1753);}
case 1753:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",1756);}
case 1756:{return rt.DynamicCall(f,"forge/game/card/CardFactory:5001:1756:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1761);}
case 1761:{f.Locals[19]=f.Pop();f.Pc=1763;continue;}
case 1763:{f.Push(f.Locals[17]);f.Pc=1765;continue;}
case 1765:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",1768);}
case 1768:{f.Push(f.Locals[19]);f.Pc=1770;continue;}
case 1770:{f.Push(f.Locals[3]);f.Pc=1771;continue;}
case 1771:{return rt.Call(f,"forge/game/card/Card","getSetCode","()Ljava/lang/String;","invokevirtual",1774);}
case 1774:{return rt.Call(f,"forge/StaticData","getOtherImageKey","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1777);}
case 1777:{return rt.Call(f,"forge/game/card/CardState","setImageKey","(Ljava/lang/String;)V","invokevirtual",1780);}
case 1780:{f.Push(f.Locals[2]);f.Pc=1781;continue;}
case 1781:{return rt.Call(f,"forge/game/CardTraitBase","isEternalize","()Z","invokevirtual",1784);}
case 1784:{f.Pc=f.Pop().Int==0?1842:1787;continue;}
case 1787:{f.Push(f.Locals[2]);f.Pc=1788;continue;}
case 1788:{return rt.Call(f,"forge/game/CardTraitBase","isIntrinsic","()Z","invokevirtual",1791);}
case 1791:{f.Pc=f.Pop().Int==0?1842:1794;continue;}
case 1794:{f.Push(f.Locals[3]);f.Pc=1795;continue;}
case 1795:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",1798);}
case 1798:{f.Push(JValue.R(rt.String(",")));f.Pc=1801;continue;}
case 1801:{f.Push(JValue.R(rt.String("")));f.Pc=1803;continue;}
case 1803:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1806);}
case 1806:{f.Push(JValue.R(rt.String(" ")));f.Pc=1809;continue;}
case 1809:{f.Push(JValue.R(rt.String("_")));f.Pc=1812;continue;}
case 1812:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1815);}
case 1815:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",1818);}
case 1818:{return rt.DynamicCall(f,"forge/game/card/CardFactory:5001:1818:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1823);}
case 1823:{f.Locals[19]=f.Pop();f.Pc=1825;continue;}
case 1825:{f.Push(f.Locals[17]);f.Pc=1827;continue;}
case 1827:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",1830);}
case 1830:{f.Push(f.Locals[19]);f.Pc=1832;continue;}
case 1832:{f.Push(f.Locals[3]);f.Pc=1833;continue;}
case 1833:{return rt.Call(f,"forge/game/card/Card","getSetCode","()Ljava/lang/String;","invokevirtual",1836);}
case 1836:{return rt.Call(f,"forge/StaticData","getOtherImageKey","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1839);}
case 1839:{return rt.Call(f,"forge/game/card/CardState","setImageKey","(Ljava/lang/String;)V","invokevirtual",1842);}
case 1842:{f.Push(f.Locals[2]);f.Pc=1843;continue;}
case 1843:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","OFFSPRING","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","OFFSPRING","Lforge/game/keyword/Keyword;"));f.Pc=1846;continue;}
case 1846:{return rt.Call(f,"forge/game/CardTraitBase","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",1849);}
case 1849:{f.Pc=f.Pop().Int==0?1907:1852;continue;}
case 1852:{f.Push(f.Locals[2]);f.Pc=1853;continue;}
case 1853:{return rt.Call(f,"forge/game/CardTraitBase","isIntrinsic","()Z","invokevirtual",1856);}
case 1856:{f.Pc=f.Pop().Int==0?1907:1859;continue;}
case 1859:{f.Push(f.Locals[3]);f.Pc=1860;continue;}
case 1860:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",1863);}
case 1863:{f.Push(JValue.R(rt.String(",")));f.Pc=1866;continue;}
case 1866:{f.Push(JValue.R(rt.String("")));f.Pc=1868;continue;}
case 1868:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1871);}
case 1871:{f.Push(JValue.R(rt.String(" ")));f.Pc=1874;continue;}
case 1874:{f.Push(JValue.R(rt.String("_")));f.Pc=1877;continue;}
case 1877:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1880);}
case 1880:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",1883);}
case 1883:{return rt.DynamicCall(f,"forge/game/card/CardFactory:5001:1883:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1888);}
case 1888:{f.Locals[19]=f.Pop();f.Pc=1890;continue;}
case 1890:{f.Push(f.Locals[17]);f.Pc=1892;continue;}
case 1892:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",1895);}
case 1895:{f.Push(f.Locals[19]);f.Pc=1897;continue;}
case 1897:{f.Push(f.Locals[3]);f.Pc=1898;continue;}
case 1898:{return rt.Call(f,"forge/game/card/Card","getSetCode","()Ljava/lang/String;","invokevirtual",1901);}
case 1901:{return rt.Call(f,"forge/StaticData","getOtherImageKey","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1904);}
case 1904:{return rt.Call(f,"forge/game/card/CardState","setImageKey","(Ljava/lang/String;)V","invokevirtual",1907);}
case 1907:{f.Push(f.Locals[2]);f.Pc=1908;continue;}
case 1908:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","SQUAD","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","SQUAD","Lforge/game/keyword/Keyword;"));f.Pc=1911;continue;}
case 1911:{return rt.Call(f,"forge/game/CardTraitBase","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",1914);}
case 1914:{f.Pc=f.Pop().Int==0?1972:1917;continue;}
case 1917:{f.Push(f.Locals[2]);f.Pc=1918;continue;}
case 1918:{return rt.Call(f,"forge/game/CardTraitBase","isIntrinsic","()Z","invokevirtual",1921);}
case 1921:{f.Pc=f.Pop().Int==0?1972:1924;continue;}
case 1924:{f.Push(f.Locals[3]);f.Pc=1925;continue;}
case 1925:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",1928);}
case 1928:{f.Push(JValue.R(rt.String(",")));f.Pc=1931;continue;}
case 1931:{f.Push(JValue.R(rt.String("")));f.Pc=1933;continue;}
case 1933:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1936);}
case 1936:{f.Push(JValue.R(rt.String(" ")));f.Pc=1939;continue;}
case 1939:{f.Push(JValue.R(rt.String("_")));f.Pc=1942;continue;}
case 1942:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1945);}
case 1945:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",1948);}
case 1948:{return rt.DynamicCall(f,"forge/game/card/CardFactory:5001:1948:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1953);}
case 1953:{f.Locals[19]=f.Pop();f.Pc=1955;continue;}
case 1955:{f.Push(f.Locals[17]);f.Pc=1957;continue;}
case 1957:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",1960);}
case 1960:{f.Push(f.Locals[19]);f.Pc=1962;continue;}
case 1962:{f.Push(f.Locals[3]);f.Pc=1963;continue;}
case 1963:{return rt.Call(f,"forge/game/card/Card","getSetCode","()Ljava/lang/String;","invokevirtual",1966);}
case 1966:{return rt.Call(f,"forge/StaticData","getOtherImageKey","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1969);}
case 1969:{return rt.Call(f,"forge/game/card/CardState","setImageKey","(Ljava/lang/String;)V","invokevirtual",1972);}
case 1972:{f.Push(f.Locals[2]);f.Pc=1973;continue;}
case 1973:{f.Push(JValue.R(rt.String("GainTextOf")));f.Pc=1976;continue;}
case 1976:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",1979);}
case 1979:{f.Pc=f.Pop().Int==0?2017:1982;continue;}
case 1982:{f.Push(f.Locals[16]);f.Pc=1984;continue;}
case 1984:{f.Pc=f.Pop().Reference==null?2017:1987;continue;}
case 1987:{f.Push(f.Locals[17]);f.Pc=1989;continue;}
case 1989:{f.Push(f.Locals[16]);f.Pc=1991;continue;}
case 1991:{return rt.Call(f,"forge/game/card/CardState","getSetCode","()Ljava/lang/String;","invokevirtual",1994);}
case 1994:{return rt.Call(f,"forge/game/card/CardState","setSetCode","(Ljava/lang/String;)V","invokevirtual",1997);}
case 1997:{f.Push(f.Locals[17]);f.Pc=1999;continue;}
case 1999:{f.Push(f.Locals[16]);f.Pc=2001;continue;}
case 2001:{return rt.Call(f,"forge/game/card/CardState","getRarity","()Lforge/card/CardRarity;","invokevirtual",2004);}
case 2004:{return rt.Call(f,"forge/game/card/CardState","setRarity","(Lforge/card/CardRarity;)V","invokevirtual",2007);}
case 2007:{f.Push(f.Locals[17]);f.Pc=2009;continue;}
case 2009:{f.Push(f.Locals[16]);f.Pc=2011;continue;}
case 2011:{return rt.Call(f,"forge/game/card/CardState","getImageKey","()Ljava/lang/String;","invokevirtual",2014);}
case 2014:{return rt.Call(f,"forge/game/card/CardState","setImageKey","(Ljava/lang/String;)V","invokevirtual",2017);}
case 2017:{f.Push(f.Locals[17]);f.Pc=2019;continue;}
case 2019:{return rt.Call(f,"forge/game/card/CardState","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",2022);}
case 2022:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",2027);}
case 2027:{f.Locals[19]=f.Pop();f.Pc=2029;continue;}
case 2029:{f.Push(f.Locals[19]);f.Pc=2031;continue;}
case 2031:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2036);}
case 2036:{f.Pc=f.Pop().Int==0?2191:2039;continue;}
case 2039:{f.Push(f.Locals[19]);f.Pc=2041;continue;}
case 2041:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2046);}
case 2046:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2049;continue;}
case 2049:{f.Locals[20]=f.Pop();f.Pc=2051;continue;}
case 2051:{f.Push(f.Locals[20]);f.Pc=2053;continue;}
case 2053:{return rt.Call(f,"forge/game/staticability/StaticAbility","isCharacteristicDefining","()Z","invokevirtual",2056);}
case 2056:{f.Pc=f.Pop().Int!=0?2062:2059;continue;}
case 2059:{f.Pc=2029;continue;}
case 2062:{f.Push(f.Locals[2]);f.Pc=2063;continue;}
case 2063:{f.Push(JValue.R(rt.String("SetPower")));f.Pc=2066;continue;}
case 2066:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",2069);}
case 2069:{f.Pc=f.Pop().Int==0?2091:2072;continue;}
case 2072:{f.Push(f.Locals[20]);f.Pc=2074;continue;}
case 2074:{f.Push(JValue.R(rt.String("SetPower")));f.Pc=2077;continue;}
case 2077:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2080);}
case 2080:{f.Pc=f.Pop().Int==0?2091:2083;continue;}
case 2083:{f.Push(f.Locals[17]);f.Pc=2085;continue;}
case 2085:{f.Push(f.Locals[20]);f.Pc=2087;continue;}
case 2087:{return rt.Call(f,"forge/game/card/CardState","removeStaticAbility","(Lforge/game/staticability/StaticAbility;)Z","invokevirtual",2090);}
case 2090:{f.StackOp("pop");f.Pc=2091;continue;}
case 2091:{f.Push(f.Locals[2]);f.Pc=2092;continue;}
case 2092:{f.Push(JValue.R(rt.String("SetToughness")));f.Pc=2095;continue;}
case 2095:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",2098);}
case 2098:{f.Pc=f.Pop().Int==0?2120:2101;continue;}
case 2101:{f.Push(f.Locals[20]);f.Pc=2103;continue;}
case 2103:{f.Push(JValue.R(rt.String("SetToughness")));f.Pc=2106;continue;}
case 2106:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2109);}
case 2109:{f.Pc=f.Pop().Int==0?2120:2112;continue;}
case 2112:{f.Push(f.Locals[17]);f.Pc=2114;continue;}
case 2114:{f.Push(f.Locals[20]);f.Pc=2116;continue;}
case 2116:{return rt.Call(f,"forge/game/card/CardState","removeStaticAbility","(Lforge/game/staticability/StaticAbility;)Z","invokevirtual",2119);}
case 2119:{f.StackOp("pop");f.Pc=2120;continue;}
case 2120:{f.Push(f.Locals[2]);f.Pc=2121;continue;}
case 2121:{f.Push(JValue.R(rt.String("SetCreatureTypes")));f.Pc=2124;continue;}
case 2124:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",2127);}
case 2127:{f.Pc=f.Pop().Int==0?2149:2130;continue;}
case 2130:{f.Push(f.Locals[20]);f.Pc=2132;continue;}
case 2132:{f.Push(JValue.R(rt.String("AddAllCreatureTypes")));f.Pc=2135;continue;}
case 2135:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2138);}
case 2138:{f.Pc=f.Pop().Int==0?2149:2141;continue;}
case 2141:{f.Push(f.Locals[17]);f.Pc=2143;continue;}
case 2143:{f.Push(f.Locals[20]);f.Pc=2145;continue;}
case 2145:{return rt.Call(f,"forge/game/card/CardState","removeStaticAbility","(Lforge/game/staticability/StaticAbility;)Z","invokevirtual",2148);}
case 2148:{f.StackOp("pop");f.Pc=2149;continue;}
case 2149:{f.Push(f.Locals[2]);f.Pc=2150;continue;}
case 2150:{f.Push(JValue.R(rt.String("SetColor")));f.Pc=2153;continue;}
case 2153:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",2156);}
case 2156:{f.Pc=f.Pop().Int!=0?2169:2159;continue;}
case 2159:{f.Push(f.Locals[2]);f.Pc=2160;continue;}
case 2160:{f.Push(JValue.R(rt.String("SetColorByManaCost")));f.Pc=2163;continue;}
case 2163:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",2166);}
case 2166:{f.Pc=f.Pop().Int==0?2188:2169;continue;}
case 2169:{f.Push(f.Locals[20]);f.Pc=2171;continue;}
case 2171:{f.Push(JValue.R(rt.String("SetColor")));f.Pc=2174;continue;}
case 2174:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2177);}
case 2177:{f.Pc=f.Pop().Int==0?2188:2180;continue;}
case 2180:{f.Push(f.Locals[17]);f.Pc=2182;continue;}
case 2182:{f.Push(f.Locals[20]);f.Pc=2184;continue;}
case 2184:{return rt.Call(f,"forge/game/card/CardState","removeStaticAbility","(Lforge/game/staticability/StaticAbility;)Z","invokevirtual",2187);}
case 2187:{f.StackOp("pop");f.Pc=2188;continue;}
case 2188:{f.Pc=2029;continue;}
case 2191:{f.Push(f.Locals[2]);f.Pc=2192;continue;}
case 2192:{f.Push(JValue.R(rt.String("SetCreatureTypes")));f.Pc=2195;continue;}
case 2195:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",2198);}
case 2198:{f.Pc=f.Pop().Int==0?2210:2201;continue;}
case 2201:{f.Push(f.Locals[17]);f.Pc=2203;continue;}
case 2203:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","CHANGELING","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","CHANGELING","Lforge/game/keyword/Keyword;"));f.Pc=2206;continue;}
case 2206:{return rt.Call(f,"forge/game/card/CardState","removeIntrinsicKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",2209);}
case 2209:{f.StackOp("pop");f.Pc=2210;continue;}
case 2210:{f.Push(f.Locals[2]);f.Pc=2211;continue;}
case 2211:{f.Push(JValue.R(rt.String("SetColor")));f.Pc=2214;continue;}
case 2214:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",2217);}
case 2217:{f.Pc=f.Pop().Int!=0?2230:2220;continue;}
case 2220:{f.Push(f.Locals[2]);f.Pc=2221;continue;}
case 2221:{f.Push(JValue.R(rt.String("SetColorByManaCost")));f.Pc=2224;continue;}
case 2224:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",2227);}
case 2227:{f.Pc=f.Pop().Int==0?2239:2230;continue;}
case 2230:{f.Push(f.Locals[17]);f.Pc=2232;continue;}
case 2232:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","DEVOID","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","DEVOID","Lforge/game/keyword/Keyword;"));f.Pc=2235;continue;}
case 2235:{return rt.Call(f,"forge/game/card/CardState","removeIntrinsicKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",2238);}
case 2238:{f.StackOp("pop");f.Pc=2239;continue;}
case 2239:{f.Pc=696;continue;}
case 2242:{f.Push(f.Locals[10]);f.Pc=2244;continue;}
case 2244:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5002(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getTopMergedCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","isCloned","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?32:17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardState;","invokevirtual",27);}
case 27:{f.Locals[4]=f.Pop();f.Pc=29;continue;}
case 29:{f.Pc=44;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/card/Card","getOriginalState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",37);}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardState;","invokevirtual",42);}
case 42:{f.Locals[4]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(JValue.I(1));f.Pc=45;continue;}
case 45:{f.Locals[5]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/Card","getMergedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",51);}
case 51:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",56);}
case 56:{f.Locals[6]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[6]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",65);}
case 65:{f.Pc=f.Pop().Int==0?105:68;continue;}
case 68:{f.Push(f.Locals[6]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",75);}
case 75:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=78;continue;}
case 78:{f.Locals[7]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[5]);f.Pc=82;continue;}
case 82:{f.Pc=f.Pop().Int==0?91:85;continue;}
case 85:{f.Push(JValue.I(0));f.Pc=86;continue;}
case 86:{f.Locals[5]=f.Pop();f.Pc=88;continue;}
case 88:{f.Pc=58;continue;}
case 91:{f.Push(f.Locals[4]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[7]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",98);}
case 98:{f.Push(JValue.I(0));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/card/CardState","addAbilitiesFrom","(Lforge/game/card/CardState;Z)V","invokevirtual",102);}
case 102:{f.Pc=58;continue;}
case 105:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCloneStates"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCloneStates")));f.Pc=108;continue;}
case 108:{f.StackOp("dup");f.Pc=109;continue;}
case 109:{f.Push(f.Locals[2]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[1]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/card/CardCloneStates","<init>","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)V","invokespecial",114);}
case 114:{f.Locals[6]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[6]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[3]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[4]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/card/CardCloneStates","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",124);}
case 124:{f.StackOp("pop");f.Pc=125;continue;}
case 125:{f.Push(f.Locals[3]);f.Pc=126;continue;}
case 126:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=129;continue;}
case 129:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?149:132;continue;}
case 132:{f.Push(f.Locals[6]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[2]);f.Pc=135;continue;}
case 135:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",141);}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[1]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardState;","invokevirtual",146);}
case 146:{return rt.Call(f,"forge/game/card/CardCloneStates","add","(Lforge/game/card/CardState;)V","invokevirtual",149);}
case 149:{f.Push(f.Locals[6]);f.Pc=151;continue;}
case 151:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5003(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/keyword/Keyword","getInstance","(Ljava/lang/String;)Lforge/game/keyword/KeywordInterface;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getKeyword","()Lforge/game/keyword/Keyword;","invokeinterface",10);}
case 10:{return rt.Call(f,"forge/game/card/CardState","hasIntrinsicKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int!=0?20:16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{f.Pc=21;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5004(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[4]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/AbilitySub","copy","(Lforge/game/card/Card;Lforge/game/player/Player;ZZ)Lforge/game/spellability/SpellAbility;","invokevirtual",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5005(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("BattleProtector")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

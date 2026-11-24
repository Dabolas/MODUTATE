// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C706{
internal static JClass Build(){var c=new JClass("forge/game/player/PlaySpellAbility","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("controller","Lforge/game/player/PlayerController;",false,JValue.Default("Lforge/game/player/PlayerController;"),null));
c.Add(new JField("ability","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JField("needX","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(7982,"forge/game/player/PlaySpellAbility","<init>","(Lforge/game/player/PlayerController;Lforge/game/spellability/SpellAbility;)V",1,3,2,new JHandler[]{},M7982));
c.Add(new JMethod(7983,"forge/game/player/PlaySpellAbility","playSpellAbility","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Z",9,9,4,new JHandler[]{},M7983));
c.Add(new JMethod(7984,"forge/game/player/PlaySpellAbility","chooseOptionalAdditionalCosts","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbility;",8,6,3,new JHandler[]{},M7984));
c.Add(new JMethod(7985,"forge/game/player/PlaySpellAbility","payCostDuringAbilityResolve","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Z",9,32,10,new JHandler[]{},M7985));
c.Add(new JMethod(7986,"forge/game/player/PlaySpellAbility","getOrStringFromCost","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/lang/String;",9,3,6,new JHandler[]{},M7986));
c.Add(new JMethod(7987,"forge/game/player/PlaySpellAbility","payCostPart","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;ZLforge/game/cost/CostPartWithList;ILforge/game/card/CardCollectionView;Ljava/lang/String;)Z",10,10,12,new JHandler[]{},M7987));
c.Add(new JMethod(7988,"forge/game/player/PlaySpellAbility","payManaCost","(Lforge/game/player/PlayerController;Lforge/card/mana/ManaCost;Lforge/game/cost/CostPartMana;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/lang/String;Lforge/game/mana/ManaConversionMatrix;Z)Z",9,15,6,new JHandler[]{},M7988));
c.Add(new JMethod(7989,"forge/game/player/PlaySpellAbility","handleOfferingConvokeAndDelve","(Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;Z)Z",10,10,5,new JHandler[]{},M7989));
c.Add(new JMethod(7990,"forge/game/player/PlaySpellAbility","playSaWithoutPayingManaCost","(Lforge/game/player/PlayerController;Lforge/game/spellability/SpellAbility;Z)V",9,5,4,new JHandler[]{},M7990));
c.Add(new JMethod(7991,"forge/game/player/PlaySpellAbility","playSpellAbilityNoStack","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Z)Z",9,5,4,new JHandler[]{},M7991));
c.Add(new JMethod(7992,"forge/game/player/PlaySpellAbility","playAbility","(ZZZ)Z",17,18,6,new JHandler[]{},M7992));
c.Add(new JMethod(7993,"forge/game/player/PlaySpellAbility","announceValuesLikeX","()Z",2,11,5,new JHandler[]{},M7993));
c.Add(new JMethod(7994,"forge/game/player/PlaySpellAbility","announceType","()Z",2,11,6,new JHandler[]{},M7994));
c.Add(new JMethod(7995,"forge/game/player/PlaySpellAbility","ensureAbilityHasDescription","(Lforge/game/spellability/SpellAbility;)V",10,5,2,new JHandler[]{},M7995));
}

internal static JStep M7982(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/PlaySpellAbility","needX","Z",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/PlaySpellAbility","controller","Lforge/game/player/PlayerController;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7983(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",10);}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","isLandAbility","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?30:17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","canPlay","()Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?28:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","resolve","()V","invokevirtual",28);}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCastFaceDown","()Z","invokevirtual",34);}
case 34:{f.Locals[4]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int==0?54:43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?54:50;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{f.Pc=55;continue;}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{f.Locals[5]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/player/PlaySpellAbility","chooseOptionalAdditionalCosts","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbility;","invokestatic",62);}
case 62:{f.Locals[2]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{f.Pc=f.Pop().Reference!=null?69:67;continue;}
case 67:{f.Push(JValue.I(0));f.Pc=68;continue;}
case 68:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",73);}
case 73:{f.Locals[6]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[3]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/card/Card","setSplitStateToPlayAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",80);}
case 80:{f.Push(f.Locals[2]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int==0?113:87;continue;}
case 87:{f.Push(f.Locals[2]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/spellability/SpellAbility","canPlay","()Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int!=0?113:94;continue;}
case 94:{f.Push(f.Locals[3]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",98);}
case 98:{f.Push(f.Locals[6]);f.Pc=100;continue;}
case 100:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?111:103;continue;}
case 103:{f.Push(f.Locals[3]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[6]);f.Pc=106;continue;}
case 106:{f.Push(JValue.I(1));f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",110);}
case 110:{f.StackOp("pop");f.Pc=111;continue;}
case 111:{f.Push(JValue.I(0));f.Pc=112;continue;}
case 112:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 113:{f.Push(f.Locals[5]);f.Pc=115;continue;}
case 115:{f.Pc=f.Pop().Int==0?127:118;continue;}
case 118:{f.Push(f.Locals[4]);f.Pc=120;continue;}
case 120:{f.Pc=f.Pop().Int!=0?127:123;continue;}
case 123:{f.Push(f.Locals[3]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/card/Card","forceTurnFaceUp","()V","invokevirtual",127);}
case 127:{if(!rt.EnsureInitialized(f,"forge/game/player/PlaySpellAbility"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlaySpellAbility")));f.Pc=130;continue;}
case 130:{f.StackOp("dup");f.Pc=131;continue;}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[2]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/player/PlaySpellAbility","<init>","(Lforge/game/player/PlayerController;Lforge/game/spellability/SpellAbility;)V","invokespecial",136);}
case 136:{f.Locals[7]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[7]);f.Pc=140;continue;}
case 140:{f.Push(JValue.I(1));f.Pc=141;continue;}
case 141:{f.Push(JValue.I(0));f.Pc=142;continue;}
case 142:{f.Push(JValue.I(0));f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/player/PlaySpellAbility","playAbility","(ZZZ)Z","invokevirtual",146);}
case 146:{f.Pc=f.Pop().Int!=0?219:149;continue;}
case 149:{f.Push(f.Locals[0]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/player/PlayerController","getGame","()Lforge/game/Game;","invokevirtual",153);}
case 153:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","EXPERIMENTAL_RESTORE_SNAPSHOT","Z"));f.Pc=156;continue;}
case 156:{f.Pc=f.Pop().Int!=0?217:159;continue;}
case 159:{f.Push(f.Locals[1]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",163);}
case 163:{f.Push(f.Locals[3]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",167);}
case 167:{f.Locals[8]=f.Pop();f.Pc=169;continue;}
case 169:{f.Push(f.Locals[4]);f.Pc=171;continue;}
case 171:{f.Pc=f.Pop().Int==0?188:174;continue;}
case 174:{f.Push(f.Locals[8]);f.Pc=176;continue;}
case 176:{f.Push(JValue.I(0));f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/card/Card","setFaceDown","(Z)V","invokevirtual",180);}
case 180:{f.Push(f.Locals[8]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",185);}
case 185:{f.Pc=217;continue;}
case 188:{f.Push(f.Locals[5]);f.Pc=190;continue;}
case 190:{f.Pc=f.Pop().Int==0?217:193;continue;}
case 193:{f.Push(f.Locals[8]);f.Pc=195;continue;}
case 195:{f.Push(JValue.I(1));f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/card/Card","turnFaceDown","(Z)Z","invokevirtual",199);}
case 199:{f.StackOp("pop");f.Pc=200;continue;}
case 200:{f.Push(f.Locals[8]);f.Pc=202;continue;}
case 202:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",208);}
case 208:{f.Pc=f.Pop().Int==0?217:211;continue;}
case 211:{f.Push(f.Locals[8]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[1]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/card/Card","addMayLookFaceDownExile","(Lforge/game/player/Player;)V","invokevirtual",217);}
case 217:{f.Push(JValue.I(0));f.Pc=218;continue;}
case 218:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 219:{f.Push(JValue.I(1));f.Pc=220;continue;}
case 220:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7984(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/GameActionUtil","getAdditionalCostSpell","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",15);}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/player/PlayerController","getAbilityToPlay","(Lforge/game/card/Card;Ljava/util/List;)Lforge/game/spellability/SpellAbility;","invokevirtual",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/GameActionUtil","getOptionalCostValues","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",26);}
case 26:{f.Locals[5]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[5]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",35);}
case 35:{f.Pc=f.Pop().Int!=0?48:38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[5]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/player/PlayerController","chooseOptionalCosts","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)Ljava/util/List;","invokevirtual",46);}
case 46:{f.Locals[5]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/GameActionUtil","addOptionalCosts","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)Lforge/game/spellability/SpellAbility;","invokestatic",55);}
case 55:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7985(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[5]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{f.Locals[6]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("ShowCurrentCard")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?43:18;continue;}
case 18:{f.Push(f.Locals[5]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("ShowCurrentCard")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",30);}
case 30:{f.Locals[7]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[7]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(null));f.Pc=35;continue;}
case 35:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[6]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/cost/Cost","getCostParts","()Ljava/util/List;","invokevirtual",47);}
case 47:{f.Locals[7]=f.Pop();f.Pc=49;continue;}
case 49:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=52;continue;}
case 52:{f.StackOp("dup");f.Pc=53;continue;}
case 53:{f.Push(f.Locals[7]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",58);}
case 58:{f.Locals[8]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(JValue.R(null));f.Pc=61;continue;}
case 61:{f.Locals[9]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[7]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",70);}
case 70:{f.Pc=f.Pop().Int!=0?86:73;continue;}
case 73:{f.Push(f.Locals[7]);f.Pc=75;continue;}
case 75:{f.Push(JValue.I(0));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",81);}
case 81:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=84;continue;}
case 84:{f.Locals[9]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/player/PlaySpellAbility","getOrStringFromCost","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/lang/String;","invokestatic",92);}
case 92:{f.Locals[10]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[9]);f.Pc=96;continue;}
case 96:{f.Pc=f.Pop().Reference==null?123:99;continue;}
case 99:{f.Push(f.Locals[9]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/cost/CostPart","getAmount","()Ljava/lang/String;","invokevirtual",104);}
case 104:{f.Push(JValue.R(rt.String("0")));f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",109);}
case 109:{f.Pc=f.Pop().Int==0?153:112;continue;}
case 112:{f.Push(f.Locals[7]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",119);}
case 119:{f.Push(JValue.I(2));f.Pc=120;continue;}
case 120:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?153:123;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",127);}
case 127:{f.Push(f.Locals[9]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",132);}
case 132:{f.Push(JValue.R(rt.String("lblDoYouWantPay")));f.Pc=134;continue;}
case 134:{f.Push(JValue.I(0));f.Pc=135;continue;}
case 135:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",141);}
case 141:{f.Push(f.Locals[10]);f.Pc=143;continue;}
case 143:{return rt.DynamicCall(f,"forge/game/player/PlaySpellAbility:7985:143:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",148);}
case 148:{f.Push(f.Locals[3]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/player/PlayerController","confirmPayment","(Lforge/game/cost/CostPart;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",152);}
case 152:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 153:{f.Push(f.Locals[9]);f.Pc=155;continue;}
case 155:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPartMana")?1:0));f.Pc=158;continue;}
case 158:{f.Pc=f.Pop().Int==0?216:161;continue;}
case 161:{f.Push(f.Locals[7]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",168);}
case 168:{f.Push(JValue.I(2));f.Pc=169;continue;}
case 169:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?216:172;continue;}
case 172:{f.Push(f.Locals[9]);f.Pc=174;continue;}
case 174:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPartMana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/cost/CostPartMana","getMana","()Lforge/card/mana/ManaCost;","invokevirtual",180);}
case 180:{return rt.Call(f,"forge/card/mana/ManaCost","isZero","()Z","invokevirtual",183);}
case 183:{f.Pc=f.Pop().Int==0?216:186;continue;}
case 186:{f.Push(f.Locals[1]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",190);}
case 190:{f.Push(f.Locals[9]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",195);}
case 195:{f.Push(JValue.R(rt.String("lblDoYouWantPay")));f.Pc=197;continue;}
case 197:{f.Push(JValue.I(0));f.Pc=198;continue;}
case 198:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",204);}
case 204:{f.Push(f.Locals[10]);f.Pc=206;continue;}
case 206:{return rt.DynamicCall(f,"forge/game/player/PlaySpellAbility:7985:206:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",211);}
case 211:{f.Push(f.Locals[3]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/player/PlayerController","confirmPayment","(Lforge/game/cost/CostPart;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",215);}
case 215:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 216:{f.Push(f.Locals[0]);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[1]);f.Pc=218;continue;}
case 218:{f.Push(f.Locals[3]);f.Pc=219;continue;}
case 219:{f.Push(JValue.I(1));f.Pc=220;continue;}
case 220:{f.Push(f.Locals[4]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/player/PlayerController","getCostDecisionMaker","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;ZLjava/lang/String;)Lforge/game/cost/CostDecisionMakerBase;","invokevirtual",225);}
case 225:{f.Locals[11]=f.Pop();f.Pc=227;continue;}
case 227:{f.Push(f.Locals[2]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/cost/Cost","isMandatory","()Z","invokevirtual",231);}
case 231:{f.Locals[12]=f.Pop();f.Pc=233;continue;}
case 233:{f.Push(f.Locals[7]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",240);}
case 240:{f.Locals[13]=f.Pop();f.Pc=242;continue;}
case 242:{f.Push(f.Locals[13]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",249);}
case 249:{f.Pc=f.Pop().Int==0?2306:252;continue;}
case 252:{f.Push(f.Locals[13]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",259);}
case 259:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=262;continue;}
case 262:{f.Locals[14]=f.Pop();f.Pc=264;continue;}
case 264:{f.Push(f.Locals[14]);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[3]);f.Pc=267;continue;}
case 267:{f.Push(f.Locals[1]);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[11]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","isEffect","()Z","invokevirtual",273);}
case 273:{return rt.Call(f,"forge/game/cost/CostPart","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z","invokevirtual",276);}
case 276:{f.Pc=f.Pop().Int!=0?281:279;continue;}
case 279:{f.Push(JValue.I(0));f.Pc=280;continue;}
case 280:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 281:{f.Push(JValue.I(1));f.Pc=282;continue;}
case 282:{f.Locals[15]=f.Pop();f.Pc=284;continue;}
case 284:{f.Push(f.Locals[14]);f.Pc=286;continue;}
case 286:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPayLife")?1:0));f.Pc=289;continue;}
case 289:{f.Pc=f.Pop().Int!=0?404:292;continue;}
case 292:{f.Push(f.Locals[14]);f.Pc=294;continue;}
case 294:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostDraw")?1:0));f.Pc=297;continue;}
case 297:{f.Pc=f.Pop().Int!=0?404:300;continue;}
case 300:{f.Push(f.Locals[14]);f.Pc=302;continue;}
case 302:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostGainLife")?1:0));f.Pc=305;continue;}
case 305:{f.Pc=f.Pop().Int!=0?404:308;continue;}
case 308:{f.Push(f.Locals[14]);f.Pc=310;continue;}
case 310:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostFlipCoin")?1:0));f.Pc=313;continue;}
case 313:{f.Pc=f.Pop().Int!=0?404:316;continue;}
case 316:{f.Push(f.Locals[14]);f.Pc=318;continue;}
case 318:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostRollDice")?1:0));f.Pc=321;continue;}
case 321:{f.Pc=f.Pop().Int!=0?404:324;continue;}
case 324:{f.Push(f.Locals[14]);f.Pc=326;continue;}
case 326:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostDamage")?1:0));f.Pc=329;continue;}
case 329:{f.Pc=f.Pop().Int!=0?404:332;continue;}
case 332:{f.Push(f.Locals[14]);f.Pc=334;continue;}
case 334:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostEnlist")?1:0));f.Pc=337;continue;}
case 337:{f.Pc=f.Pop().Int!=0?404:340;continue;}
case 340:{f.Push(f.Locals[14]);f.Pc=342;continue;}
case 342:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostExileFromStack")?1:0));f.Pc=345;continue;}
case 345:{f.Pc=f.Pop().Int!=0?404:348;continue;}
case 348:{f.Push(f.Locals[14]);f.Pc=350;continue;}
case 350:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPutCounter")?1:0));f.Pc=353;continue;}
case 353:{f.Pc=f.Pop().Int!=0?404:356;continue;}
case 356:{f.Push(f.Locals[14]);f.Pc=358;continue;}
case 358:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPutCounterYou")?1:0));f.Pc=361;continue;}
case 361:{f.Pc=f.Pop().Int!=0?404:364;continue;}
case 364:{f.Push(f.Locals[14]);f.Pc=366;continue;}
case 366:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostRemoveCounter")?1:0));f.Pc=369;continue;}
case 369:{f.Pc=f.Pop().Int!=0?404:372;continue;}
case 372:{f.Push(f.Locals[14]);f.Pc=374;continue;}
case 374:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostRemoveAnyCounter")?1:0));f.Pc=377;continue;}
case 377:{f.Pc=f.Pop().Int!=0?404:380;continue;}
case 380:{f.Push(f.Locals[14]);f.Pc=382;continue;}
case 382:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostMill")?1:0));f.Pc=385;continue;}
case 385:{f.Pc=f.Pop().Int!=0?404:388;continue;}
case 388:{f.Push(f.Locals[14]);f.Pc=390;continue;}
case 390:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostSacrifice")?1:0));f.Pc=393;continue;}
case 393:{f.Pc=f.Pop().Int!=0?404:396;continue;}
case 396:{f.Push(f.Locals[14]);f.Pc=398;continue;}
case 398:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostCollectEvidence")?1:0));f.Pc=401;continue;}
case 401:{f.Pc=f.Pop().Int==0?441:404;continue;}
case 404:{f.Push(f.Locals[14]);f.Pc=406;continue;}
case 406:{f.Push(f.Locals[11]);f.Pc=408;continue;}
case 408:{return rt.Call(f,"forge/game/cost/CostPart","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;","invokevirtual",411);}
case 411:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/PaymentDecision"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=414;continue;}
case 414:{f.Locals[18]=f.Pop();f.Pc=416;continue;}
case 416:{f.Push(f.Locals[18]);f.Pc=418;continue;}
case 418:{f.Pc=f.Pop().Reference!=null?423:421;continue;}
case 421:{f.Push(JValue.I(0));f.Pc=422;continue;}
case 422:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 423:{f.Push(f.Locals[14]);f.Pc=425;continue;}
case 425:{f.Push(f.Locals[1]);f.Pc=426;continue;}
case 426:{f.Push(f.Locals[18]);f.Pc=428;continue;}
case 428:{f.Push(f.Locals[3]);f.Pc=429;continue;}
case 429:{f.Push(f.Locals[11]);f.Pc=431;continue;}
case 431:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","isEffect","()Z","invokevirtual",434);}
case 434:{return rt.Call(f,"forge/game/cost/CostPart","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",437);}
case 437:{f.StackOp("pop");f.Pc=438;continue;}
case 438:{f.Pc=2288;continue;}
case 441:{f.Push(f.Locals[14]);f.Pc=443;continue;}
case 443:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostAddMana")?1:0));f.Pc=446;continue;}
case 446:{f.Pc=f.Pop().Int==0?553:449;continue;}
case 449:{f.Push(f.Locals[14]);f.Pc=451;continue;}
case 451:{return rt.Call(f,"forge/game/cost/CostPart","toString","()Ljava/lang/String;","invokevirtual",454);}
case 454:{f.Locals[18]=f.Pop();f.Pc=456;continue;}
case 456:{f.Push(f.Locals[18]);f.Pc=458;continue;}
case 458:{f.Push(JValue.I(0));f.Pc=459;continue;}
case 459:{f.Push(JValue.I(1));f.Pc=460;continue;}
case 460:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",463);}
case 463:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",466);}
case 466:{f.Push(f.Locals[18]);f.Pc=468;continue;}
case 468:{f.Push(JValue.I(1));f.Pc=469;continue;}
case 469:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",472);}
case 472:{return rt.DynamicCall(f,"forge/game/player/PlaySpellAbility:7985:472:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",477);}
case 477:{f.Locals[18]=f.Pop();f.Pc=479;continue;}
case 479:{f.Push(f.Locals[1]);f.Pc=480;continue;}
case 480:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",483);}
case 483:{f.Push(f.Locals[14]);f.Pc=485;continue;}
case 485:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",488);}
case 488:{f.Push(JValue.R(rt.String("lblDoyouWantTo")));f.Pc=491;continue;}
case 491:{f.Push(JValue.I(0));f.Pc=492;continue;}
case 492:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=495;continue;}
case 495:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",498);}
case 498:{f.Push(f.Locals[18]);f.Pc=500;continue;}
case 500:{f.Push(f.Locals[10]);f.Pc=502;continue;}
case 502:{return rt.DynamicCall(f,"forge/game/player/PlaySpellAbility:7985:502:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",507);}
case 507:{f.Push(f.Locals[3]);f.Pc=508;continue;}
case 508:{return rt.Call(f,"forge/game/player/PlayerController","confirmPayment","(Lforge/game/cost/CostPart;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",511);}
case 511:{f.Pc=f.Pop().Int!=0?516:514;continue;}
case 514:{f.Push(JValue.I(0));f.Pc=515;continue;}
case 515:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 516:{f.Push(f.Locals[14]);f.Pc=518;continue;}
case 518:{f.Push(f.Locals[11]);f.Pc=520;continue;}
case 520:{return rt.Call(f,"forge/game/cost/CostPart","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;","invokevirtual",523);}
case 523:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/PaymentDecision"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=526;continue;}
case 526:{f.Locals[19]=f.Pop();f.Pc=528;continue;}
case 528:{f.Push(f.Locals[19]);f.Pc=530;continue;}
case 530:{f.Pc=f.Pop().Reference!=null?535:533;continue;}
case 533:{f.Push(JValue.I(0));f.Pc=534;continue;}
case 534:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 535:{f.Push(f.Locals[14]);f.Pc=537;continue;}
case 537:{f.Push(f.Locals[1]);f.Pc=538;continue;}
case 538:{f.Push(f.Locals[19]);f.Pc=540;continue;}
case 540:{f.Push(f.Locals[3]);f.Pc=541;continue;}
case 541:{f.Push(f.Locals[11]);f.Pc=543;continue;}
case 543:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","isEffect","()Z","invokevirtual",546);}
case 546:{return rt.Call(f,"forge/game/cost/CostPart","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",549);}
case 549:{f.StackOp("pop");f.Pc=550;continue;}
case 550:{f.Pc=2288;continue;}
case 553:{f.Push(f.Locals[14]);f.Pc=555;continue;}
case 555:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostExile")?1:0));f.Pc=558;continue;}
case 558:{f.Pc=f.Pop().Int==0?1025:561;continue;}
case 561:{f.Push(f.Locals[14]);f.Pc=563;continue;}
case 563:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostExile"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=566;continue;}
case 566:{f.Locals[16]=f.Pop();f.Pc=568;continue;}
case 568:{f.Push(JValue.R(rt.String("All")));f.Pc=571;continue;}
case 571:{f.Push(f.Locals[14]);f.Pc=573;continue;}
case 573:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",576);}
case 576:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",579);}
case 579:{f.Pc=f.Pop().Int==0?672:582;continue;}
case 582:{f.Push(f.Locals[16]);f.Pc=584;continue;}
case 584:{return rt.Call(f,"forge/game/cost/CostExile","getFrom","()Ljava/util/List;","invokevirtual",587);}
case 587:{f.Push(JValue.I(0));f.Pc=588;continue;}
case 588:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",593);}
case 593:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=596;continue;}
case 596:{f.Locals[18]=f.Pop();f.Pc=598;continue;}
case 598:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=601;continue;}
case 601:{f.Push(f.Locals[18]);f.Pc=603;continue;}
case 603:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",606);}
case 606:{f.Pc=f.Pop().Int==0?615:609;continue;}
case 609:{f.Push(JValue.R(rt.String("lblDoYouWantExileAllCardYouGraveyard")));f.Pc=612;continue;}
case 612:{f.Pc=618;continue;}
case 615:{f.Push(JValue.R(rt.String("lblDoYouWantExileAllCardHand")));f.Pc=618;continue;}
case 618:{f.Locals[4]=f.Pop();f.Pc=620;continue;}
case 620:{f.Push(f.Locals[1]);f.Pc=621;continue;}
case 621:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",624);}
case 624:{f.Push(f.Locals[14]);f.Pc=626;continue;}
case 626:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",629);}
case 629:{f.Push(f.Locals[4]);f.Pc=631;continue;}
case 631:{f.Push(JValue.I(0));f.Pc=632;continue;}
case 632:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=635;continue;}
case 635:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",638);}
case 638:{f.Push(f.Locals[3]);f.Pc=639;continue;}
case 639:{return rt.Call(f,"forge/game/player/PlayerController","confirmPayment","(Lforge/game/cost/CostPart;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",642);}
case 642:{f.Pc=f.Pop().Int!=0?647:645;continue;}
case 645:{f.Push(JValue.I(0));f.Pc=646;continue;}
case 646:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 647:{f.Push(f.Locals[16]);f.Pc=649;continue;}
case 649:{f.Push(f.Locals[1]);f.Pc=650;continue;}
case 650:{f.Push(f.Locals[1]);f.Pc=651;continue;}
case 651:{f.Push(f.Locals[18]);f.Pc=653;continue;}
case 653:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",656);}
case 656:{return rt.Call(f,"forge/game/cost/PaymentDecision","card","(Ljava/lang/Iterable;)Lforge/game/cost/PaymentDecision;","invokestatic",659);}
case 659:{f.Push(f.Locals[3]);f.Pc=660;continue;}
case 660:{f.Push(f.Locals[11]);f.Pc=662;continue;}
case 662:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","isEffect","()Z","invokevirtual",665);}
case 665:{return rt.Call(f,"forge/game/cost/CostExile","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",668);}
case 668:{f.StackOp("pop");f.Pc=669;continue;}
case 669:{f.Pc=2288;continue;}
case 672:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=675;continue;}
case 675:{f.StackOp("dup");f.Pc=676;continue;}
case 676:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",679);}
case 679:{f.Locals[18]=f.Pop();f.Pc=681;continue;}
case 681:{f.Push(f.Locals[16]);f.Pc=683;continue;}
case 683:{return rt.Call(f,"forge/game/cost/CostExile","getFrom","()Ljava/util/List;","invokevirtual",686);}
case 686:{f.Locals[19]=f.Pop();f.Pc=688;continue;}
case 688:{f.Push(f.Locals[19]);f.Pc=690;continue;}
case 690:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",695);}
case 695:{f.Push(JValue.I(1));f.Pc=696;continue;}
case 696:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?703:699;continue;}
case 699:{f.Push(JValue.I(1));f.Pc=700;continue;}
case 700:{f.Pc=704;continue;}
case 703:{f.Push(JValue.I(0));f.Pc=704;continue;}
case 704:{f.Locals[20]=f.Pop();f.Pc=706;continue;}
case 706:{f.Push(f.Locals[19]);f.Pc=708;continue;}
case 708:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",713);}
case 713:{f.Locals[21]=f.Pop();f.Pc=715;continue;}
case 715:{f.Push(f.Locals[21]);f.Pc=717;continue;}
case 717:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",722);}
case 722:{f.Pc=f.Pop().Int==0?773:725;continue;}
case 725:{f.Push(f.Locals[21]);f.Pc=727;continue;}
case 727:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",732);}
case 732:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=735;continue;}
case 735:{f.Locals[22]=f.Pop();f.Pc=737;continue;}
case 737:{f.Push(f.Locals[18]);f.Pc=739;continue;}
case 739:{f.Push(f.Locals[16]);f.Pc=741;continue;}
case 741:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostExile","zoneRestriction","I"));f.Pc=744;continue;}
case 744:{f.Push(JValue.I(1));f.Pc=745;continue;}
case 745:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?760:748;continue;}
case 748:{f.Push(f.Locals[1]);f.Pc=749;continue;}
case 749:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",752);}
case 752:{f.Push(f.Locals[22]);f.Pc=754;continue;}
case 754:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",757);}
case 757:{f.Pc=766;continue;}
case 760:{f.Push(f.Locals[1]);f.Pc=761;continue;}
case 761:{f.Push(f.Locals[22]);f.Pc=763;continue;}
case 763:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",766);}
case 766:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",769);}
case 769:{f.StackOp("pop");f.Pc=770;continue;}
case 770:{f.Pc=715;continue;}
case 773:{f.Push(f.Locals[18]);f.Pc=775;continue;}
case 775:{f.Push(f.Locals[14]);f.Pc=777;continue;}
case 777:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",780);}
case 780:{f.Push(JValue.R(rt.String(";")));f.Pc=783;continue;}
case 783:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",786);}
case 786:{f.Push(f.Locals[1]);f.Pc=787;continue;}
case 787:{f.Push(f.Locals[5]);f.Pc=789;continue;}
case 789:{f.Push(f.Locals[3]);f.Pc=790;continue;}
case 790:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",793);}
case 793:{f.Locals[18]=f.Pop();f.Pc=795;continue;}
case 795:{f.Push(f.Locals[14]);f.Pc=797;continue;}
case 797:{f.Push(f.Locals[3]);f.Pc=798;continue;}
case 798:{return rt.Call(f,"forge/game/cost/CostPart","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",801);}
case 801:{f.Locals[21]=f.Pop();f.Pc=803;continue;}
case 803:{f.Push(f.Locals[18]);f.Pc=805;continue;}
case 805:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",808);}
case 808:{f.Push(f.Locals[21]);f.Pc=810;continue;}
case 810:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?815:813;continue;}
case 813:{f.Push(JValue.I(0));f.Pc=814;continue;}
case 814:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 815:{f.Push(f.Locals[20]);f.Pc=817;continue;}
case 817:{f.Pc=f.Pop().Int!=0?907:820;continue;}
case 820:{f.Push(f.Locals[19]);f.Pc=822;continue;}
case 822:{f.Push(JValue.I(0));f.Pc=823;continue;}
case 823:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",828);}
case 828:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=831;continue;}
case 831:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=834;continue;}
case 834:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",837);}
case 837:{f.Pc=f.Pop().Int==0?907:840;continue;}
case 840:{f.Push(f.Locals[1]);f.Pc=841;continue;}
case 841:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",844);}
case 844:{f.Push(f.Locals[14]);f.Pc=846;continue;}
case 846:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",849);}
case 849:{f.Push(JValue.R(rt.String("lblDoYouWantExileNCardsFromYourLibrary")));f.Pc=852;continue;}
case 852:{f.Push(JValue.I(1));f.Pc=853;continue;}
case 853:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=856;continue;}
case 856:{f.StackOp("dup");f.Pc=857;continue;}
case 857:{f.Push(JValue.I(0));f.Pc=858;continue;}
case 858:{f.Push(f.Locals[21]);f.Pc=860;continue;}
case 860:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",863);}
case 863:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=864;continue;}
case 864:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",867);}
case 867:{f.Push(f.Locals[3]);f.Pc=868;continue;}
case 868:{return rt.Call(f,"forge/game/player/PlayerController","confirmPayment","(Lforge/game/cost/CostPart;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",871);}
case 871:{f.Pc=f.Pop().Int!=0?876:874;continue;}
case 874:{f.Push(JValue.I(0));f.Pc=875;continue;}
case 875:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 876:{f.Push(f.Locals[18]);f.Pc=878;continue;}
case 878:{f.Push(JValue.I(0));f.Pc=879;continue;}
case 879:{f.Push(f.Locals[21]);f.Pc=881;continue;}
case 881:{return rt.Call(f,"forge/game/card/CardCollection","subList","(II)Lforge/game/card/CardCollection;","invokevirtual",884);}
case 884:{f.Locals[18]=f.Pop();f.Pc=886;continue;}
case 886:{f.Push(f.Locals[16]);f.Pc=888;continue;}
case 888:{f.Push(f.Locals[1]);f.Pc=889;continue;}
case 889:{f.Push(f.Locals[18]);f.Pc=891;continue;}
case 891:{return rt.Call(f,"forge/game/cost/PaymentDecision","card","(Ljava/lang/Iterable;)Lforge/game/cost/PaymentDecision;","invokestatic",894);}
case 894:{f.Push(f.Locals[3]);f.Pc=895;continue;}
case 895:{f.Push(f.Locals[11]);f.Pc=897;continue;}
case 897:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","isEffect","()Z","invokevirtual",900);}
case 900:{return rt.Call(f,"forge/game/cost/CostExile","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",903);}
case 903:{f.StackOp("pop");f.Pc=904;continue;}
case 904:{f.Pc=1022;continue;}
case 907:{f.Push(f.Locals[19]);f.Pc=909;continue;}
case 909:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",914);}
case 914:{return rt.DynamicCall(f,"forge/game/player/PlaySpellAbility:7985:914:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",919);}
case 919:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",924);}
case 924:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",927);}
case 927:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",932);}
case 932:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=935;continue;}
case 935:{f.Locals[22]=f.Pop();f.Pc=937;continue;}
case 937:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",940);}
case 940:{f.Push(JValue.R(rt.String("lblExileFromZone")));f.Pc=943;continue;}
case 943:{f.Push(JValue.I(1));f.Pc=944;continue;}
case 944:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=947;continue;}
case 947:{f.StackOp("dup");f.Pc=948;continue;}
case 948:{f.Push(JValue.I(0));f.Pc=949;continue;}
case 949:{f.Push(f.Locals[22]);f.Pc=951;continue;}
case 951:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",954);}
case 954:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=955;continue;}
case 955:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",958);}
case 958:{f.Locals[23]=f.Pop();f.Pc=960;continue;}
case 960:{f.Push(f.Locals[0]);f.Pc=961;continue;}
case 961:{f.Push(f.Locals[18]);f.Pc=963;continue;}
case 963:{f.Push(f.Locals[3]);f.Pc=964;continue;}
case 964:{f.Push(f.Locals[16]);f.Pc=966;continue;}
case 966:{f.Push(f.Locals[21]);f.Pc=968;continue;}
case 968:{f.Push(f.Locals[12]);f.Pc=970;continue;}
case 970:{f.Pc=f.Pop().Int!=0?977:973;continue;}
case 973:{f.Push(JValue.I(1));f.Pc=974;continue;}
case 974:{f.Pc=978;continue;}
case 977:{f.Push(JValue.I(0));f.Pc=978;continue;}
case 978:{f.Push(f.Locals[23]);f.Pc=980;continue;}
case 980:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForCost","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Lforge/game/cost/CostPartWithList;IZLjava/lang/String;)Lforge/game/card/CardCollectionView;","invokevirtual",983);}
case 983:{f.Locals[24]=f.Pop();f.Pc=985;continue;}
case 985:{f.Push(f.Locals[24]);f.Pc=987;continue;}
case 987:{f.Pc=f.Pop().Reference==null?1002:990;continue;}
case 990:{f.Push(f.Locals[24]);f.Pc=992;continue;}
case 992:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",997);}
case 997:{f.Push(f.Locals[21]);f.Pc=999;continue;}
case 999:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1004:1002;continue;}
case 1002:{f.Push(JValue.I(0));f.Pc=1003;continue;}
case 1003:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1004:{f.Push(f.Locals[16]);f.Pc=1006;continue;}
case 1006:{f.Push(f.Locals[1]);f.Pc=1007;continue;}
case 1007:{f.Push(f.Locals[24]);f.Pc=1009;continue;}
case 1009:{return rt.Call(f,"forge/game/cost/PaymentDecision","card","(Ljava/lang/Iterable;)Lforge/game/cost/PaymentDecision;","invokestatic",1012);}
case 1012:{f.Push(f.Locals[3]);f.Pc=1013;continue;}
case 1013:{f.Push(f.Locals[11]);f.Pc=1015;continue;}
case 1015:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","isEffect","()Z","invokevirtual",1018);}
case 1018:{return rt.Call(f,"forge/game/cost/CostExile","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",1021);}
case 1021:{f.StackOp("pop");f.Pc=1022;continue;}
case 1022:{f.Pc=2288;continue;}
case 1025:{f.Push(f.Locals[14]);f.Pc=1027;continue;}
case 1027:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPutCardToLib")?1:0));f.Pc=1030;continue;}
case 1030:{f.Pc=f.Pop().Int==0?1431:1033;continue;}
case 1033:{f.Push(f.Locals[14]);f.Pc=1035;continue;}
case 1035:{return rt.Call(f,"forge/game/cost/CostPart","getAmount","()Ljava/lang/String;","invokevirtual",1038);}
case 1038:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",1041);}
case 1041:{f.Locals[18]=f.Pop();f.Pc=1043;continue;}
case 1043:{f.Push(f.Locals[14]);f.Pc=1045;continue;}
case 1045:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPutCardToLib"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1048;continue;}
case 1048:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","getFrom","()Lforge/game/zone/ZoneType;","invokevirtual",1051);}
case 1051:{f.Locals[19]=f.Pop();f.Pc=1053;continue;}
case 1053:{f.Push(f.Locals[14]);f.Pc=1055;continue;}
case 1055:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPutCardToLib"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1058;continue;}
case 1058:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","isSameZone","()Z","invokevirtual",1061);}
case 1061:{f.Locals[20]=f.Pop();f.Pc=1063;continue;}
case 1063:{f.Push(f.Locals[20]);f.Pc=1065;continue;}
case 1065:{f.Pc=f.Pop().Int==0?1082:1068;continue;}
case 1068:{f.Push(f.Locals[1]);f.Pc=1069;continue;}
case 1069:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",1072);}
case 1072:{f.Push(f.Locals[19]);f.Pc=1074;continue;}
case 1074:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1077);}
case 1077:{f.Locals[21]=f.Pop();f.Pc=1079;continue;}
case 1079:{f.Pc=1090;continue;}
case 1082:{f.Push(f.Locals[1]);f.Pc=1083;continue;}
case 1083:{f.Push(f.Locals[19]);f.Pc=1085;continue;}
case 1085:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1088);}
case 1088:{f.Locals[21]=f.Pop();f.Pc=1090;continue;}
case 1090:{f.Push(f.Locals[21]);f.Pc=1092;continue;}
case 1092:{f.Push(f.Locals[14]);f.Pc=1094;continue;}
case 1094:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",1097);}
case 1097:{f.Push(JValue.R(rt.String(";")));f.Pc=1100;continue;}
case 1100:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1103);}
case 1103:{f.Push(f.Locals[1]);f.Pc=1104;continue;}
case 1104:{f.Push(f.Locals[5]);f.Pc=1106;continue;}
case 1106:{f.Push(f.Locals[3]);f.Pc=1107;continue;}
case 1107:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1110);}
case 1110:{f.Locals[22]=f.Pop();f.Pc=1112;continue;}
case 1112:{f.Push(f.Locals[20]);f.Pc=1114;continue;}
case 1114:{f.Pc=f.Pop().Int==0?1379:1117;continue;}
case 1117:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=1120;continue;}
case 1120:{f.StackOp("dup");f.Pc=1121;continue;}
case 1121:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","()V","invokespecial",1124);}
case 1124:{f.Locals[23]=f.Pop();f.Pc=1126;continue;}
case 1126:{f.Push(f.Locals[1]);f.Pc=1127;continue;}
case 1127:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",1130);}
case 1130:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",1133);}
case 1133:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1136);}
case 1136:{f.Locals[24]=f.Pop();f.Pc=1138;continue;}
case 1138:{f.Push(f.Locals[24]);f.Pc=1140;continue;}
case 1140:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1145);}
case 1145:{f.Pc=f.Pop().Int==0?1206:1148;continue;}
case 1148:{f.Push(f.Locals[24]);f.Pc=1150;continue;}
case 1150:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1155);}
case 1155:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1158;continue;}
case 1158:{f.Locals[25]=f.Pop();f.Pc=1160;continue;}
case 1160:{f.Push(f.Locals[22]);f.Pc=1162;continue;}
case 1162:{f.Push(f.Locals[25]);f.Pc=1164;continue;}
case 1164:{return rt.Call(f,"forge/game/card/CardPredicates","isOwner","(Lforge/game/player/Player;)Ljava/util/function/Predicate;","invokestatic",1167);}
case 1167:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",1170);}
case 1170:{f.Locals[26]=f.Pop();f.Pc=1172;continue;}
case 1172:{f.Push(f.Locals[26]);f.Pc=1174;continue;}
case 1174:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",1179);}
case 1179:{f.Push(f.Locals[18]);f.Pc=1181;continue;}
case 1181:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1195:1184;continue;}
case 1184:{f.Push(f.Locals[22]);f.Pc=1186;continue;}
case 1186:{f.Push(f.Locals[26]);f.Pc=1188;continue;}
case 1188:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",1191);}
case 1191:{f.StackOp("pop");f.Pc=1192;continue;}
case 1192:{f.Pc=1203;continue;}
case 1195:{f.Push(f.Locals[23]);f.Pc=1197;continue;}
case 1197:{f.Push(f.Locals[25]);f.Pc=1199;continue;}
case 1199:{return rt.Call(f,"forge/game/player/PlayerCollection","add","(Ljava/lang/Object;)Z","invokevirtual",1202);}
case 1202:{f.StackOp("pop");f.Pc=1203;continue;}
case 1203:{f.Pc=1138;continue;}
case 1206:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1209);}
case 1209:{f.Push(JValue.R(rt.String("lblPutCardFromWhoseZone")));f.Pc=1212;continue;}
case 1212:{f.Push(JValue.I(1));f.Pc=1213;continue;}
case 1213:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1216;continue;}
case 1216:{f.StackOp("dup");f.Pc=1217;continue;}
case 1217:{f.Push(JValue.I(0));f.Pc=1218;continue;}
case 1218:{f.Push(f.Locals[19]);f.Pc=1220;continue;}
case 1220:{return rt.Call(f,"forge/game/zone/ZoneType","getTranslatedName","()Ljava/lang/String;","invokevirtual",1223);}
case 1223:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1224;continue;}
case 1224:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1227);}
case 1227:{f.Locals[24]=f.Pop();f.Pc=1229;continue;}
case 1229:{f.Push(f.Locals[0]);f.Pc=1230;continue;}
case 1230:{f.Push(f.Locals[23]);f.Pc=1232;continue;}
case 1232:{f.Push(f.Locals[3]);f.Pc=1233;continue;}
case 1233:{f.Push(f.Locals[24]);f.Pc=1235;continue;}
case 1235:{f.Push(JValue.I(1));f.Pc=1236;continue;}
case 1236:{f.Push(JValue.R(null));f.Pc=1237;continue;}
case 1237:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",1240);}
case 1240:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1243;continue;}
case 1243:{f.Locals[25]=f.Pop();f.Pc=1245;continue;}
case 1245:{f.Push(f.Locals[25]);f.Pc=1247;continue;}
case 1247:{f.Pc=f.Pop().Reference!=null?1252:1250;continue;}
case 1250:{f.Push(JValue.I(0));f.Pc=1251;continue;}
case 1251:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1252:{f.Push(f.Locals[22]);f.Pc=1254;continue;}
case 1254:{f.Push(f.Locals[25]);f.Pc=1256;continue;}
case 1256:{return rt.Call(f,"forge/game/card/CardPredicates","isOwner","(Lforge/game/player/Player;)Ljava/util/function/Predicate;","invokestatic",1259);}
case 1259:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",1262);}
case 1262:{f.Locals[26]=f.Pop();f.Pc=1264;continue;}
case 1264:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1267);}
case 1267:{f.Push(JValue.R(rt.String("lblPutCardToLibrary")));f.Pc=1270;continue;}
case 1270:{f.Push(JValue.I(0));f.Pc=1271;continue;}
case 1271:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1274;continue;}
case 1274:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1277);}
case 1277:{f.Locals[27]=f.Pop();f.Pc=1279;continue;}
case 1279:{f.Push(f.Locals[0]);f.Pc=1280;continue;}
case 1280:{f.Push(f.Locals[26]);f.Pc=1282;continue;}
case 1282:{f.Push(f.Locals[3]);f.Pc=1283;continue;}
case 1283:{f.Push(f.Locals[14]);f.Pc=1285;continue;}
case 1285:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPutCardToLib"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1288;continue;}
case 1288:{f.Push(f.Locals[18]);f.Pc=1290;continue;}
case 1290:{f.Push(JValue.I(1));f.Pc=1291;continue;}
case 1291:{f.Push(f.Locals[27]);f.Pc=1293;continue;}
case 1293:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForCost","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Lforge/game/cost/CostPartWithList;IZLjava/lang/String;)Lforge/game/card/CardCollectionView;","invokevirtual",1296);}
case 1296:{f.Locals[28]=f.Pop();f.Pc=1298;continue;}
case 1298:{f.Push(f.Locals[1]);f.Pc=1299;continue;}
case 1299:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",1302);}
case 1302:{f.Push(f.Locals[28]);f.Pc=1304;continue;}
case 1304:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=1307;continue;}
case 1307:{f.Push(f.Locals[3]);f.Pc=1308;continue;}
case 1308:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",1311);}
case 1311:{f.Locals[28]=f.Pop();f.Pc=1313;continue;}
case 1313:{f.Push(f.Locals[14]);f.Pc=1315;continue;}
case 1315:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPutCardToLib"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1318;continue;}
case 1318:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","getLibPos","()Ljava/lang/String;","invokevirtual",1321);}
case 1321:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",1324);}
case 1324:{f.Locals[29]=f.Pop();f.Pc=1326;continue;}
case 1326:{f.Push(f.Locals[28]);f.Pc=1328;continue;}
case 1328:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",1333);}
case 1333:{f.Locals[30]=f.Pop();f.Pc=1335;continue;}
case 1335:{f.Push(f.Locals[30]);f.Pc=1337;continue;}
case 1337:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1342);}
case 1342:{f.Pc=f.Pop().Int==0?1376:1345;continue;}
case 1345:{f.Push(f.Locals[30]);f.Pc=1347;continue;}
case 1347:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1352);}
case 1352:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1355;continue;}
case 1355:{f.Locals[31]=f.Pop();f.Pc=1357;continue;}
case 1357:{f.Push(f.Locals[1]);f.Pc=1358;continue;}
case 1358:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",1361);}
case 1361:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1364);}
case 1364:{f.Push(f.Locals[31]);f.Pc=1366;continue;}
case 1366:{f.Push(f.Locals[29]);f.Pc=1368;continue;}
case 1368:{f.Push(f.Locals[3]);f.Pc=1369;continue;}
case 1369:{return rt.Call(f,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",1372);}
case 1372:{f.StackOp("pop");f.Pc=1373;continue;}
case 1373:{f.Pc=1335;continue;}
case 1376:{f.Pc=1428;continue;}
case 1379:{f.Push(f.Locals[0]);f.Pc=1380;continue;}
case 1380:{f.Push(f.Locals[1]);f.Pc=1381;continue;}
case 1381:{f.Push(f.Locals[3]);f.Pc=1382;continue;}
case 1382:{f.Push(f.Locals[11]);f.Pc=1384;continue;}
case 1384:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","isEffect","()Z","invokevirtual",1387);}
case 1387:{f.Push(f.Locals[14]);f.Pc=1389;continue;}
case 1389:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPartWithList"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1392;continue;}
case 1392:{f.Push(f.Locals[18]);f.Pc=1394;continue;}
case 1394:{f.Push(f.Locals[22]);f.Pc=1396;continue;}
case 1396:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1399);}
case 1399:{f.Push(JValue.R(rt.String("lblPutIntoLibrary")));f.Pc=1402;continue;}
case 1402:{f.Push(JValue.I(0));f.Pc=1403;continue;}
case 1403:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1406;continue;}
case 1406:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1409);}
case 1409:{f.Push(f.Locals[10]);f.Pc=1411;continue;}
case 1411:{return rt.DynamicCall(f,"forge/game/player/PlaySpellAbility:7985:1411:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1416);}
case 1416:{return rt.Call(f,"forge/game/player/PlaySpellAbility","payCostPart","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;ZLforge/game/cost/CostPartWithList;ILforge/game/card/CardCollectionView;Ljava/lang/String;)Z","invokestatic",1419);}
case 1419:{f.Locals[23]=f.Pop();f.Pc=1421;continue;}
case 1421:{f.Push(f.Locals[23]);f.Pc=1423;continue;}
case 1423:{f.Pc=f.Pop().Int!=0?1428:1426;continue;}
case 1426:{f.Push(JValue.I(0));f.Pc=1427;continue;}
case 1427:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1428:{f.Pc=2288;continue;}
case 1431:{f.Push(f.Locals[14]);f.Pc=1433;continue;}
case 1433:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostGainControl")?1:0));f.Pc=1436;continue;}
case 1436:{f.Pc=f.Pop().Int==0?1525:1439;continue;}
case 1439:{f.Push(f.Locals[14]);f.Pc=1441;continue;}
case 1441:{return rt.Call(f,"forge/game/cost/CostPart","getAmount","()Ljava/lang/String;","invokevirtual",1444);}
case 1444:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",1447);}
case 1447:{f.Locals[18]=f.Pop();f.Pc=1449;continue;}
case 1449:{f.Push(f.Locals[1]);f.Pc=1450;continue;}
case 1450:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",1453);}
case 1453:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1456;continue;}
case 1456:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1459);}
case 1459:{f.Push(f.Locals[14]);f.Pc=1461;continue;}
case 1461:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",1464);}
case 1464:{f.Push(f.Locals[1]);f.Pc=1465;continue;}
case 1465:{f.Push(f.Locals[5]);f.Pc=1467;continue;}
case 1467:{f.Push(f.Locals[3]);f.Pc=1468;continue;}
case 1468:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1471);}
case 1471:{f.Locals[19]=f.Pop();f.Pc=1473;continue;}
case 1473:{f.Push(f.Locals[0]);f.Pc=1474;continue;}
case 1474:{f.Push(f.Locals[1]);f.Pc=1475;continue;}
case 1475:{f.Push(f.Locals[3]);f.Pc=1476;continue;}
case 1476:{f.Push(f.Locals[11]);f.Pc=1478;continue;}
case 1478:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","isEffect","()Z","invokevirtual",1481);}
case 1481:{f.Push(f.Locals[14]);f.Pc=1483;continue;}
case 1483:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPartWithList"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1486;continue;}
case 1486:{f.Push(f.Locals[18]);f.Pc=1488;continue;}
case 1488:{f.Push(f.Locals[19]);f.Pc=1490;continue;}
case 1490:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1493);}
case 1493:{f.Push(JValue.R(rt.String("lblGainControl")));f.Pc=1496;continue;}
case 1496:{f.Push(JValue.I(0));f.Pc=1497;continue;}
case 1497:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1500;continue;}
case 1500:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1503);}
case 1503:{f.Push(f.Locals[10]);f.Pc=1505;continue;}
case 1505:{return rt.DynamicCall(f,"forge/game/player/PlaySpellAbility:7985:1505:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1510);}
case 1510:{return rt.Call(f,"forge/game/player/PlaySpellAbility","payCostPart","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;ZLforge/game/cost/CostPartWithList;ILforge/game/card/CardCollectionView;Ljava/lang/String;)Z","invokestatic",1513);}
case 1513:{f.Locals[20]=f.Pop();f.Pc=1515;continue;}
case 1515:{f.Push(f.Locals[20]);f.Pc=1517;continue;}
case 1517:{f.Pc=f.Pop().Int!=0?1522:1520;continue;}
case 1520:{f.Push(JValue.I(0));f.Pc=1521;continue;}
case 1521:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1522:{f.Pc=2288;continue;}
case 1525:{f.Push(f.Locals[14]);f.Pc=1527;continue;}
case 1527:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostReturn")?1:0));f.Pc=1530;continue;}
case 1530:{f.Pc=f.Pop().Int==0?1614:1533;continue;}
case 1533:{f.Push(f.Locals[1]);f.Pc=1534;continue;}
case 1534:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1537;continue;}
case 1537:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1540);}
case 1540:{f.Push(f.Locals[14]);f.Pc=1542;continue;}
case 1542:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",1545);}
case 1545:{f.Push(f.Locals[1]);f.Pc=1546;continue;}
case 1546:{f.Push(f.Locals[5]);f.Pc=1548;continue;}
case 1548:{f.Push(f.Locals[3]);f.Pc=1549;continue;}
case 1549:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1552);}
case 1552:{f.Locals[18]=f.Pop();f.Pc=1554;continue;}
case 1554:{f.Push(f.Locals[14]);f.Pc=1556;continue;}
case 1556:{f.Push(f.Locals[3]);f.Pc=1557;continue;}
case 1557:{return rt.Call(f,"forge/game/cost/CostPart","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",1560);}
case 1560:{f.Locals[19]=f.Pop();f.Pc=1562;continue;}
case 1562:{f.Push(f.Locals[0]);f.Pc=1563;continue;}
case 1563:{f.Push(f.Locals[1]);f.Pc=1564;continue;}
case 1564:{f.Push(f.Locals[3]);f.Pc=1565;continue;}
case 1565:{f.Push(f.Locals[11]);f.Pc=1567;continue;}
case 1567:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","isEffect","()Z","invokevirtual",1570);}
case 1570:{f.Push(f.Locals[14]);f.Pc=1572;continue;}
case 1572:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPartWithList"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1575;continue;}
case 1575:{f.Push(f.Locals[19]);f.Pc=1577;continue;}
case 1577:{f.Push(f.Locals[18]);f.Pc=1579;continue;}
case 1579:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1582);}
case 1582:{f.Push(JValue.R(rt.String("lblReturnToHand")));f.Pc=1585;continue;}
case 1585:{f.Push(JValue.I(0));f.Pc=1586;continue;}
case 1586:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1589;continue;}
case 1589:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1592);}
case 1592:{f.Push(f.Locals[10]);f.Pc=1594;continue;}
case 1594:{return rt.DynamicCall(f,"forge/game/player/PlaySpellAbility:7985:1594:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1599);}
case 1599:{return rt.Call(f,"forge/game/player/PlaySpellAbility","payCostPart","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;ZLforge/game/cost/CostPartWithList;ILforge/game/card/CardCollectionView;Ljava/lang/String;)Z","invokestatic",1602);}
case 1602:{f.Locals[20]=f.Pop();f.Pc=1604;continue;}
case 1604:{f.Push(f.Locals[20]);f.Pc=1606;continue;}
case 1606:{f.Pc=f.Pop().Int!=0?1611:1609;continue;}
case 1609:{f.Push(JValue.I(0));f.Pc=1610;continue;}
case 1610:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1611:{f.Pc=2288;continue;}
case 1614:{f.Push(f.Locals[14]);f.Pc=1616;continue;}
case 1616:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostDiscard")?1:0));f.Pc=1619;continue;}
case 1619:{f.Pc=f.Pop().Int==0?1850:1622;continue;}
case 1622:{f.Push(f.Locals[14]);f.Pc=1624;continue;}
case 1624:{f.Push(f.Locals[3]);f.Pc=1625;continue;}
case 1625:{return rt.Call(f,"forge/game/cost/CostPart","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",1628);}
case 1628:{f.Locals[18]=f.Pop();f.Pc=1630;continue;}
case 1630:{f.Push(JValue.R(rt.String("Hand")));f.Pc=1633;continue;}
case 1633:{f.Push(f.Locals[14]);f.Pc=1635;continue;}
case 1635:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",1638);}
case 1638:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1641);}
case 1641:{f.Pc=f.Pop().Int==0?1694:1644;continue;}
case 1644:{f.Push(f.Locals[1]);f.Pc=1645;continue;}
case 1645:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1648);}
case 1648:{f.Push(f.Locals[14]);f.Pc=1650;continue;}
case 1650:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1653);}
case 1653:{f.Push(JValue.R(rt.String("lblDoYouWantDiscardYourHand")));f.Pc=1656;continue;}
case 1656:{f.Push(JValue.I(0));f.Pc=1657;continue;}
case 1657:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1660;continue;}
case 1660:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1663);}
case 1663:{f.Push(f.Locals[3]);f.Pc=1664;continue;}
case 1664:{return rt.Call(f,"forge/game/player/PlayerController","confirmPayment","(Lforge/game/cost/CostPart;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",1667);}
case 1667:{f.Pc=f.Pop().Int!=0?1672:1670;continue;}
case 1670:{f.Push(JValue.I(0));f.Pc=1671;continue;}
case 1671:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1672:{f.Push(f.Locals[14]);f.Pc=1674;continue;}
case 1674:{f.Push(f.Locals[1]);f.Pc=1675;continue;}
case 1675:{f.Push(f.Locals[1]);f.Pc=1676;continue;}
case 1676:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=1679;continue;}
case 1679:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1682);}
case 1682:{return rt.Call(f,"forge/game/cost/PaymentDecision","card","(Ljava/lang/Iterable;)Lforge/game/cost/PaymentDecision;","invokestatic",1685);}
case 1685:{f.Push(f.Locals[3]);f.Pc=1686;continue;}
case 1686:{f.Push(JValue.I(1));f.Pc=1687;continue;}
case 1687:{return rt.Call(f,"forge/game/cost/CostPart","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",1690);}
case 1690:{f.StackOp("pop");f.Pc=1691;continue;}
case 1691:{f.Pc=1847;continue;}
case 1694:{f.Push(JValue.R(rt.String("Random")));f.Pc=1697;continue;}
case 1697:{f.Push(f.Locals[14]);f.Pc=1699;continue;}
case 1699:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",1702);}
case 1702:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1705);}
case 1705:{f.Pc=f.Pop().Int==0?1771:1708;continue;}
case 1708:{f.Push(f.Locals[1]);f.Pc=1709;continue;}
case 1709:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1712);}
case 1712:{f.Push(f.Locals[14]);f.Pc=1714;continue;}
case 1714:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1717);}
case 1717:{f.Push(JValue.R(rt.String("lblWouldYouLikeRandomDiscardTargetCard")));f.Pc=1720;continue;}
case 1720:{f.Push(JValue.I(1));f.Pc=1721;continue;}
case 1721:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1724;continue;}
case 1724:{f.StackOp("dup");f.Pc=1725;continue;}
case 1725:{f.Push(JValue.I(0));f.Pc=1726;continue;}
case 1726:{f.Push(f.Locals[18]);f.Pc=1728;continue;}
case 1728:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1731);}
case 1731:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1732;continue;}
case 1732:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1735);}
case 1735:{f.Push(f.Locals[3]);f.Pc=1736;continue;}
case 1736:{return rt.Call(f,"forge/game/player/PlayerController","confirmPayment","(Lforge/game/cost/CostPart;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",1739);}
case 1739:{f.Pc=f.Pop().Int!=0?1744:1742;continue;}
case 1742:{f.Push(JValue.I(0));f.Pc=1743;continue;}
case 1743:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1744:{f.Push(f.Locals[14]);f.Pc=1746;continue;}
case 1746:{f.Push(f.Locals[1]);f.Pc=1747;continue;}
case 1747:{f.Push(f.Locals[1]);f.Pc=1748;continue;}
case 1748:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=1751;continue;}
case 1751:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1754);}
case 1754:{f.Push(f.Locals[18]);f.Pc=1756;continue;}
case 1756:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;","invokestatic",1759);}
case 1759:{return rt.Call(f,"forge/game/cost/PaymentDecision","card","(Ljava/lang/Iterable;)Lforge/game/cost/PaymentDecision;","invokestatic",1762);}
case 1762:{f.Push(f.Locals[3]);f.Pc=1763;continue;}
case 1763:{f.Push(JValue.I(1));f.Pc=1764;continue;}
case 1764:{return rt.Call(f,"forge/game/cost/CostPart","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",1767);}
case 1767:{f.StackOp("pop");f.Pc=1768;continue;}
case 1768:{f.Pc=1847;continue;}
case 1771:{f.Push(f.Locals[1]);f.Pc=1772;continue;}
case 1772:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=1775;continue;}
case 1775:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1778);}
case 1778:{f.Push(f.Locals[14]);f.Pc=1780;continue;}
case 1780:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",1783);}
case 1783:{f.Push(JValue.R(rt.String(";")));f.Pc=1786;continue;}
case 1786:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1789);}
case 1789:{f.Push(f.Locals[1]);f.Pc=1790;continue;}
case 1790:{f.Push(f.Locals[5]);f.Pc=1792;continue;}
case 1792:{f.Push(f.Locals[3]);f.Pc=1793;continue;}
case 1793:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1796);}
case 1796:{f.Locals[19]=f.Pop();f.Pc=1798;continue;}
case 1798:{f.Push(f.Locals[0]);f.Pc=1799;continue;}
case 1799:{f.Push(f.Locals[1]);f.Pc=1800;continue;}
case 1800:{f.Push(f.Locals[3]);f.Pc=1801;continue;}
case 1801:{f.Push(f.Locals[11]);f.Pc=1803;continue;}
case 1803:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","isEffect","()Z","invokevirtual",1806);}
case 1806:{f.Push(f.Locals[14]);f.Pc=1808;continue;}
case 1808:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPartWithList"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1811;continue;}
case 1811:{f.Push(f.Locals[18]);f.Pc=1813;continue;}
case 1813:{f.Push(f.Locals[19]);f.Pc=1815;continue;}
case 1815:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1818);}
case 1818:{f.Push(JValue.R(rt.String("lbldiscard")));f.Pc=1821;continue;}
case 1821:{f.Push(JValue.I(0));f.Pc=1822;continue;}
case 1822:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1825;continue;}
case 1825:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1828);}
case 1828:{f.Push(f.Locals[10]);f.Pc=1830;continue;}
case 1830:{return rt.DynamicCall(f,"forge/game/player/PlaySpellAbility:7985:1830:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1835);}
case 1835:{return rt.Call(f,"forge/game/player/PlaySpellAbility","payCostPart","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;ZLforge/game/cost/CostPartWithList;ILforge/game/card/CardCollectionView;Ljava/lang/String;)Z","invokestatic",1838);}
case 1838:{f.Locals[20]=f.Pop();f.Pc=1840;continue;}
case 1840:{f.Push(f.Locals[20]);f.Pc=1842;continue;}
case 1842:{f.Pc=f.Pop().Int!=0?1847:1845;continue;}
case 1845:{f.Push(JValue.I(0));f.Pc=1846;continue;}
case 1846:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1847:{f.Pc=2288;continue;}
case 1850:{f.Push(f.Locals[14]);f.Pc=1852;continue;}
case 1852:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostReveal")?1:0));f.Pc=1855;continue;}
case 1855:{f.Pc=f.Pop().Int==0?1954:1858;continue;}
case 1858:{f.Push(f.Locals[14]);f.Pc=1860;continue;}
case 1860:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostReveal"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1863;continue;}
case 1863:{f.Locals[17]=f.Pop();f.Pc=1865;continue;}
case 1865:{f.Push(f.Locals[1]);f.Pc=1866;continue;}
case 1866:{f.Push(f.Locals[17]);f.Pc=1868;continue;}
case 1868:{return rt.Call(f,"forge/game/cost/CostReveal","getRevealFrom","()Ljava/util/List;","invokevirtual",1871);}
case 1871:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",1874);}
case 1874:{f.Push(f.Locals[14]);f.Pc=1876;continue;}
case 1876:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",1879);}
case 1879:{f.Push(JValue.R(rt.String(";")));f.Pc=1882;continue;}
case 1882:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1885);}
case 1885:{f.Push(f.Locals[1]);f.Pc=1886;continue;}
case 1886:{f.Push(f.Locals[5]);f.Pc=1888;continue;}
case 1888:{f.Push(f.Locals[3]);f.Pc=1889;continue;}
case 1889:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1892);}
case 1892:{f.Locals[18]=f.Pop();f.Pc=1894;continue;}
case 1894:{f.Push(f.Locals[14]);f.Pc=1896;continue;}
case 1896:{f.Push(f.Locals[3]);f.Pc=1897;continue;}
case 1897:{return rt.Call(f,"forge/game/cost/CostPart","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",1900);}
case 1900:{f.Locals[19]=f.Pop();f.Pc=1902;continue;}
case 1902:{f.Push(f.Locals[0]);f.Pc=1903;continue;}
case 1903:{f.Push(f.Locals[1]);f.Pc=1904;continue;}
case 1904:{f.Push(f.Locals[3]);f.Pc=1905;continue;}
case 1905:{f.Push(f.Locals[11]);f.Pc=1907;continue;}
case 1907:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","isEffect","()Z","invokevirtual",1910);}
case 1910:{f.Push(f.Locals[14]);f.Pc=1912;continue;}
case 1912:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPartWithList"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1915;continue;}
case 1915:{f.Push(f.Locals[19]);f.Pc=1917;continue;}
case 1917:{f.Push(f.Locals[18]);f.Pc=1919;continue;}
case 1919:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1922);}
case 1922:{f.Push(JValue.R(rt.String("lblReveal")));f.Pc=1925;continue;}
case 1925:{f.Push(JValue.I(0));f.Pc=1926;continue;}
case 1926:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1929;continue;}
case 1929:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1932);}
case 1932:{f.Push(f.Locals[10]);f.Pc=1934;continue;}
case 1934:{return rt.DynamicCall(f,"forge/game/player/PlaySpellAbility:7985:1934:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1939);}
case 1939:{return rt.Call(f,"forge/game/player/PlaySpellAbility","payCostPart","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;ZLforge/game/cost/CostPartWithList;ILforge/game/card/CardCollectionView;Ljava/lang/String;)Z","invokestatic",1942);}
case 1942:{f.Locals[20]=f.Pop();f.Pc=1944;continue;}
case 1944:{f.Push(f.Locals[20]);f.Pc=1946;continue;}
case 1946:{f.Pc=f.Pop().Int!=0?1951:1949;continue;}
case 1949:{f.Push(JValue.I(0));f.Pc=1950;continue;}
case 1950:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1951:{f.Pc=2288;continue;}
case 1954:{f.Push(f.Locals[14]);f.Pc=1956;continue;}
case 1956:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostTapType")?1:0));f.Pc=1959;continue;}
case 1959:{f.Pc=f.Pop().Int==0?2059:1962;continue;}
case 1962:{f.Push(f.Locals[1]);f.Pc=1963;continue;}
case 1963:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1966;continue;}
case 1966:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1969);}
case 1969:{f.Push(f.Locals[14]);f.Pc=1971;continue;}
case 1971:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",1974);}
case 1974:{f.Push(JValue.R(rt.String(";")));f.Pc=1977;continue;}
case 1977:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1980);}
case 1980:{f.Push(f.Locals[1]);f.Pc=1981;continue;}
case 1981:{f.Push(f.Locals[5]);f.Pc=1983;continue;}
case 1983:{f.Push(f.Locals[3]);f.Pc=1984;continue;}
case 1984:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1987);}
case 1987:{f.Locals[18]=f.Pop();f.Pc=1989;continue;}
case 1989:{f.Push(f.Locals[18]);f.Pc=1991;continue;}
case 1991:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","CAN_TAP","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","CAN_TAP","Ljava/util/function/Predicate;"));f.Pc=1994;continue;}
case 1994:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",1997);}
case 1997:{f.Locals[18]=f.Pop();f.Pc=1999;continue;}
case 1999:{f.Push(f.Locals[14]);f.Pc=2001;continue;}
case 2001:{f.Push(f.Locals[3]);f.Pc=2002;continue;}
case 2002:{return rt.Call(f,"forge/game/cost/CostPart","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",2005);}
case 2005:{f.Locals[19]=f.Pop();f.Pc=2007;continue;}
case 2007:{f.Push(f.Locals[0]);f.Pc=2008;continue;}
case 2008:{f.Push(f.Locals[1]);f.Pc=2009;continue;}
case 2009:{f.Push(f.Locals[3]);f.Pc=2010;continue;}
case 2010:{f.Push(f.Locals[11]);f.Pc=2012;continue;}
case 2012:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","isEffect","()Z","invokevirtual",2015);}
case 2015:{f.Push(f.Locals[14]);f.Pc=2017;continue;}
case 2017:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPartWithList"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2020;continue;}
case 2020:{f.Push(f.Locals[19]);f.Pc=2022;continue;}
case 2022:{f.Push(f.Locals[18]);f.Pc=2024;continue;}
case 2024:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",2027);}
case 2027:{f.Push(JValue.R(rt.String("lblTap")));f.Pc=2030;continue;}
case 2030:{f.Push(JValue.I(0));f.Pc=2031;continue;}
case 2031:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=2034;continue;}
case 2034:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",2037);}
case 2037:{f.Push(f.Locals[10]);f.Pc=2039;continue;}
case 2039:{return rt.DynamicCall(f,"forge/game/player/PlaySpellAbility:7985:2039:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",2044);}
case 2044:{return rt.Call(f,"forge/game/player/PlaySpellAbility","payCostPart","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;ZLforge/game/cost/CostPartWithList;ILforge/game/card/CardCollectionView;Ljava/lang/String;)Z","invokestatic",2047);}
case 2047:{f.Locals[20]=f.Pop();f.Pc=2049;continue;}
case 2049:{f.Push(f.Locals[20]);f.Pc=2051;continue;}
case 2051:{f.Pc=f.Pop().Int!=0?2056:2054;continue;}
case 2054:{f.Push(JValue.I(0));f.Pc=2055;continue;}
case 2055:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2056:{f.Pc=2288;continue;}
case 2059:{f.Push(f.Locals[14]);f.Pc=2061;continue;}
case 2061:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPartMana")?1:0));f.Pc=2064;continue;}
case 2064:{f.Pc=f.Pop().Int==0?2087:2067;continue;}
case 2067:{f.Push(f.Locals[14]);f.Pc=2069;continue;}
case 2069:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPartMana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2072;continue;}
case 2072:{return rt.Call(f,"forge/game/cost/CostPartMana","getMana","()Lforge/card/mana/ManaCost;","invokevirtual",2075);}
case 2075:{return rt.Call(f,"forge/card/mana/ManaCost","isZero","()Z","invokevirtual",2078);}
case 2078:{f.Pc=f.Pop().Int!=0?2288:2081;continue;}
case 2081:{f.Push(JValue.I(0));f.Pc=2082;continue;}
case 2082:{f.Locals[15]=f.Pop();f.Pc=2084;continue;}
case 2084:{f.Pc=2288;continue;}
case 2087:{f.Push(f.Locals[14]);f.Pc=2089;continue;}
case 2089:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPayEnergy")?1:0));f.Pc=2092;continue;}
case 2092:{f.Pc=f.Pop().Int==0?2171:2095;continue;}
case 2095:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","ENERGY","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","ENERGY","Lforge/game/card/CounterEnumType;"));f.Pc=2098;continue;}
case 2098:{f.Locals[18]=f.Pop();f.Pc=2100;continue;}
case 2100:{f.Push(f.Locals[14]);f.Pc=2102;continue;}
case 2102:{f.Push(f.Locals[3]);f.Pc=2103;continue;}
case 2103:{return rt.Call(f,"forge/game/cost/CostPart","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",2106);}
case 2106:{f.Locals[19]=f.Pop();f.Pc=2108;continue;}
case 2108:{f.Push(f.Locals[12]);f.Pc=2110;continue;}
case 2110:{f.Pc=f.Pop().Int!=0?2159:2113;continue;}
case 2113:{f.Push(f.Locals[1]);f.Pc=2114;continue;}
case 2114:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",2117);}
case 2117:{f.Push(f.Locals[14]);f.Pc=2119;continue;}
case 2119:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",2122);}
case 2122:{f.Push(JValue.R(rt.String("lblDoYouWantSpendNTargetTypeCounter")));f.Pc=2125;continue;}
case 2125:{f.Push(JValue.I(2));f.Pc=2126;continue;}
case 2126:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=2129;continue;}
case 2129:{f.StackOp("dup");f.Pc=2130;continue;}
case 2130:{f.Push(JValue.I(0));f.Pc=2131;continue;}
case 2131:{f.Push(f.Locals[19]);f.Pc=2133;continue;}
case 2133:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",2136);}
case 2136:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=2137;continue;}
case 2137:{f.StackOp("dup");f.Pc=2138;continue;}
case 2138:{f.Push(JValue.I(1));f.Pc=2139;continue;}
case 2139:{f.Push(f.Locals[18]);f.Pc=2141;continue;}
case 2141:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",2146);}
case 2146:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=2147;continue;}
case 2147:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",2150);}
case 2150:{f.Push(f.Locals[3]);f.Pc=2151;continue;}
case 2151:{return rt.Call(f,"forge/game/player/PlayerController","confirmPayment","(Lforge/game/cost/CostPart;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",2154);}
case 2154:{f.Pc=f.Pop().Int!=0?2159:2157;continue;}
case 2157:{f.Push(JValue.I(0));f.Pc=2158;continue;}
case 2158:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2159:{f.Push(f.Locals[1]);f.Pc=2160;continue;}
case 2160:{f.Push(f.Locals[19]);f.Pc=2162;continue;}
case 2162:{f.Push(f.Locals[5]);f.Pc=2164;continue;}
case 2164:{return rt.Call(f,"forge/game/player/Player","payEnergy","(ILforge/game/card/Card;)Z","invokevirtual",2167);}
case 2167:{f.StackOp("pop");f.Pc=2168;continue;}
case 2168:{f.Pc=2288;continue;}
case 2171:{f.Push(f.Locals[14]);f.Pc=2173;continue;}
case 2173:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostExert")?1:0));f.Pc=2176;continue;}
case 2176:{f.Pc=f.Pop().Int==0?2200:2179;continue;}
case 2179:{f.Push(f.Locals[14]);f.Pc=2181;continue;}
case 2181:{f.Push(f.Locals[1]);f.Pc=2182;continue;}
case 2182:{f.Push(f.Locals[5]);f.Pc=2184;continue;}
case 2184:{return rt.Call(f,"forge/game/cost/PaymentDecision","card","(Lforge/game/card/Card;)Lforge/game/cost/PaymentDecision;","invokestatic",2187);}
case 2187:{f.Push(f.Locals[3]);f.Pc=2188;continue;}
case 2188:{f.Push(f.Locals[11]);f.Pc=2190;continue;}
case 2190:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","isEffect","()Z","invokevirtual",2193);}
case 2193:{return rt.Call(f,"forge/game/cost/CostPart","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",2196);}
case 2196:{f.StackOp("pop");f.Pc=2197;continue;}
case 2197:{f.Pc=2288;continue;}
case 2200:{f.Push(f.Locals[14]);f.Pc=2202;continue;}
case 2202:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPayShards")?1:0));f.Pc=2205;continue;}
case 2205:{f.Pc=f.Pop().Int==0?2267:2208;continue;}
case 2208:{f.Push(f.Locals[14]);f.Pc=2210;continue;}
case 2210:{f.Push(f.Locals[3]);f.Pc=2211;continue;}
case 2211:{return rt.Call(f,"forge/game/cost/CostPart","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",2214);}
case 2214:{f.Locals[18]=f.Pop();f.Pc=2216;continue;}
case 2216:{f.Push(f.Locals[12]);f.Pc=2218;continue;}
case 2218:{f.Pc=f.Pop().Int!=0?2255:2221;continue;}
case 2221:{f.Push(f.Locals[1]);f.Pc=2222;continue;}
case 2222:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",2225);}
case 2225:{f.Push(f.Locals[14]);f.Pc=2227;continue;}
case 2227:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",2230);}
case 2230:{f.Push(JValue.R(rt.String("lblDoYouWantPay")));f.Pc=2232;continue;}
case 2232:{f.Push(JValue.I(0));f.Pc=2233;continue;}
case 2233:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=2236;continue;}
case 2236:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",2239);}
case 2239:{f.Push(f.Locals[18]);f.Pc=2241;continue;}
case 2241:{return rt.DynamicCall(f,"forge/game/player/PlaySpellAbility:7985:2241:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;I)Ljava/lang/String;",2246);}
case 2246:{f.Push(f.Locals[3]);f.Pc=2247;continue;}
case 2247:{return rt.Call(f,"forge/game/player/PlayerController","confirmPayment","(Lforge/game/cost/CostPart;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",2250);}
case 2250:{f.Pc=f.Pop().Int!=0?2255:2253;continue;}
case 2253:{f.Push(JValue.I(0));f.Pc=2254;continue;}
case 2254:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2255:{f.Push(f.Locals[1]);f.Pc=2256;continue;}
case 2256:{f.Push(f.Locals[18]);f.Pc=2258;continue;}
case 2258:{f.Push(f.Locals[5]);f.Pc=2260;continue;}
case 2260:{return rt.Call(f,"forge/game/player/Player","payShards","(ILforge/game/card/Card;)Z","invokevirtual",2263);}
case 2263:{f.StackOp("pop");f.Pc=2264;continue;}
case 2264:{f.Pc=2288;continue;}
case 2267:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=2270;continue;}
case 2270:{f.StackOp("dup");f.Pc=2271;continue;}
case 2271:{f.Push(f.Locals[14]);f.Pc=2273;continue;}
case 2273:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",2276);}
case 2276:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",2279);}
case 2279:{return rt.DynamicCall(f,"forge/game/player/PlaySpellAbility:7985:2279:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2284);}
case 2284:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",2287);}
case 2287:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 2288:{f.Push(f.Locals[15]);f.Pc=2290;continue;}
case 2290:{f.Pc=f.Pop().Int==0?2303:2293;continue;}
case 2293:{f.Push(f.Locals[8]);f.Pc=2295;continue;}
case 2295:{f.Push(f.Locals[14]);f.Pc=2297;continue;}
case 2297:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",2302);}
case 2302:{f.StackOp("pop");f.Pc=2303;continue;}
case 2303:{f.Pc=242;continue;}
case 2306:{f.Push(f.Locals[8]);f.Pc=2308;continue;}
case 2308:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",2313);}
case 2313:{f.Pc=f.Pop().Int==0?2318:2316;continue;}
case 2316:{f.Push(JValue.I(1));f.Pc=2317;continue;}
case 2317:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2318:{f.Push(f.Locals[8]);f.Pc=2320;continue;}
case 2320:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",2325);}
case 2325:{f.Push(JValue.I(1));f.Pc=2326;continue;}
case 2326:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2347:2329;continue;}
case 2329:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=2332;continue;}
case 2332:{f.StackOp("dup");f.Pc=2333;continue;}
case 2333:{f.Push(f.Locals[5]);f.Pc=2335;continue;}
case 2335:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",2338);}
case 2338:{return rt.DynamicCall(f,"forge/game/player/PlaySpellAbility:7985:2338:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2343);}
case 2343:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",2346);}
case 2346:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 2347:{f.Push(f.Locals[8]);f.Pc=2349;continue;}
case 2349:{f.Push(JValue.I(0));f.Pc=2350;continue;}
case 2350:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",2355);}
case 2355:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2358;continue;}
case 2358:{f.Locals[9]=f.Pop();f.Pc=2360;continue;}
case 2360:{f.Push(f.Locals[9]);f.Pc=2362;continue;}
case 2362:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPartMana")?1:0));f.Pc=2365;continue;}
case 2365:{f.Pc=f.Pop().Int!=0?2379:2368;continue;}
case 2368:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=2371;continue;}
case 2371:{f.StackOp("dup");f.Pc=2372;continue;}
case 2372:{f.Push(JValue.R(rt.String("GameActionUtil.payCostDuringAbilityResolve - The remaining payment type is not Mana.")));f.Pc=2375;continue;}
case 2375:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",2378);}
case 2378:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 2379:{f.Push(f.Locals[4]);f.Pc=2381;continue;}
case 2381:{f.Pc=f.Pop().Reference!=null?2434:2384;continue;}
case 2384:{f.Push(f.Locals[6]);f.Pc=2386;continue;}
case 2386:{f.Pc=f.Pop().Reference!=null?2395:2389;continue;}
case 2389:{f.Push(JValue.R(rt.String("")));f.Pc=2392;continue;}
case 2392:{f.Pc=2418;continue;}
case 2395:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",2398);}
case 2398:{f.Push(JValue.R(rt.String("lblCurrentCard")));f.Pc=2401;continue;}
case 2401:{f.Push(JValue.I(0));f.Pc=2402;continue;}
case 2402:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=2405;continue;}
case 2405:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",2408);}
case 2408:{f.Push(f.Locals[6]);f.Pc=2410;continue;}
case 2410:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",2413);}
case 2413:{return rt.DynamicCall(f,"forge/game/player/PlaySpellAbility:7985:2413:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",2418);}
case 2418:{f.Locals[13]=f.Pop();f.Pc=2420;continue;}
case 2420:{f.Push(f.Locals[5]);f.Pc=2422;continue;}
case 2422:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",2425);}
case 2425:{f.Push(f.Locals[13]);f.Pc=2427;continue;}
case 2427:{return rt.DynamicCall(f,"forge/game/player/PlaySpellAbility:7985:2427:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",2432);}
case 2432:{f.Locals[4]=f.Pop();f.Pc=2434;continue;}
case 2434:{f.Push(f.Locals[3]);f.Pc=2435;continue;}
case 2435:{return rt.Call(f,"forge/game/spellability/SpellAbility","clearManaPaid","()V","invokevirtual",2438);}
case 2438:{f.Push(f.Locals[1]);f.Pc=2439;continue;}
case 2439:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",2442);}
case 2442:{f.Push(f.Locals[2]);f.Pc=2443;continue;}
case 2443:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",2446);}
case 2446:{f.Push(f.Locals[3]);f.Pc=2447;continue;}
case 2447:{f.Push(f.Locals[4]);f.Pc=2449;continue;}
case 2449:{f.Push(JValue.R(null));f.Pc=2450;continue;}
case 2450:{f.Push(f.Locals[11]);f.Pc=2452;continue;}
case 2452:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","isEffect","()Z","invokevirtual",2455);}
case 2455:{return rt.Call(f,"forge/game/player/PlayerController","payManaCost","(Lforge/game/cost/CostPartMana;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/mana/ManaConversionMatrix;Z)Z","invokevirtual",2458);}
case 2458:{f.Locals[13]=f.Pop();f.Pc=2460;continue;}
case 2460:{f.Push(f.Locals[13]);f.Pc=2462;continue;}
case 2462:{f.Pc=f.Pop().Int!=0?2476:2465;continue;}
case 2465:{if(!rt.EnsureInitialized(f,"forge/game/mana/ManaRefundService"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/ManaRefundService")));f.Pc=2468;continue;}
case 2468:{f.StackOp("dup");f.Pc=2469;continue;}
case 2469:{f.Push(f.Locals[3]);f.Pc=2470;continue;}
case 2470:{return rt.Call(f,"forge/game/mana/ManaRefundService","<init>","(Lforge/game/spellability/SpellAbility;)V","invokespecial",2473);}
case 2473:{return rt.Call(f,"forge/game/mana/ManaRefundService","refundManaPaid","()V","invokevirtual",2476);}
case 2476:{f.Push(f.Locals[13]);f.Pc=2478;continue;}
case 2478:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7986(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("OrString")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?21:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("OrString")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Pc=39;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Reference!=null?35:25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getStackDescription","()Ljava/lang/String;","invokevirtual",29);}
case 29:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Pc=38;continue;}
case 35:{f.Push(JValue.R(rt.String("")));f.Pc=38;continue;}
case 38:{f.Locals[2]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int!=0?133:46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("UnlessSwitched")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int==0?94:56;continue;}
case 56:{f.Push(JValue.I(2));f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=60;continue;}
case 60:{f.StackOp("dup");f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",65);}
case 65:{f.Push(JValue.R(rt.String("lblIfYouDo")));f.Pc=68;continue;}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",75);}
case 75:{return rt.DynamicCall(f,"forge/game/player/PlaySpellAbility:7986:75:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",80);}
case 80:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=81;continue;}
case 81:{f.StackOp("dup");f.Pc=82;continue;}
case 82:{f.Push(JValue.I(1));f.Pc=83;continue;}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{return rt.DynamicCall(f,"forge/game/player/PlaySpellAbility:7986:84:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",89);}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",93);}
case 93:{return JStep.Return(f.Pop());}
case 94:{f.Push(JValue.I(3));f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=98;continue;}
case 98:{f.StackOp("dup");f.Pc=99;continue;}
case 99:{f.Push(JValue.I(0));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",103);}
case 103:{f.Push(JValue.R(rt.String("lblOr")));f.Pc=106;continue;}
case 106:{f.Push(JValue.I(0));f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",113);}
case 113:{return rt.DynamicCall(f,"forge/game/player/PlaySpellAbility:7986:113:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",118);}
case 118:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=119;continue;}
case 119:{f.StackOp("dup");f.Pc=120;continue;}
case 120:{f.Push(JValue.I(1));f.Pc=121;continue;}
case 121:{f.Push(f.Locals[2]);f.Pc=122;continue;}
case 122:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=123;continue;}
case 123:{f.StackOp("dup");f.Pc=124;continue;}
case 124:{f.Push(JValue.I(2));f.Pc=125;continue;}
case 125:{f.Push(JValue.R(rt.String(")")));f.Pc=128;continue;}
case 128:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",132);}
case 132:{return JStep.Return(f.Pop());}
case 133:{f.Push(f.Locals[2]);f.Pc=134;continue;}
case 134:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7987(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[6]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",7);}
case 7:{f.Push(f.Locals[5]);f.Pc=9;continue;}
case 9:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?14:12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 14:{f.Push(f.Locals[4]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/cost/CostPartWithList","getDescriptiveType","()Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Push(JValue.R(rt.String("Card")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?34:28;continue;}
case 28:{f.Push(JValue.R(rt.String("")));f.Pc=31;continue;}
case 31:{f.Pc=39;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/cost/CostPartWithList","getDescriptiveType","()Ljava/lang/String;","invokevirtual",39);}
case 39:{f.Locals[8]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[6]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[5]);f.Pc=49;continue;}
case 49:{f.Push(JValue.I(1));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",53);}
case 53:{f.Push(JValue.R(rt.String("lblSelectNSpecifyTypeCardsToAction")));f.Pc=56;continue;}
case 56:{f.Push(JValue.I(2));f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=60;continue;}
case 60:{f.StackOp("dup");f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{f.Push(f.Locals[8]);f.Pc=64;continue;}
case 64:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=65;continue;}
case 65:{f.StackOp("dup");f.Pc=66;continue;}
case 66:{f.Push(JValue.I(1));f.Pc=67;continue;}
case 67:{f.Push(f.Locals[7]);f.Pc=69;continue;}
case 69:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",73);}
case 73:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForCost","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Lforge/game/cost/CostPartWithList;IZLjava/lang/String;)Lforge/game/card/CardCollectionView;","invokevirtual",76);}
case 76:{f.Locals[9]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[9]);f.Pc=80;continue;}
case 80:{f.Pc=f.Pop().Reference!=null?85:83;continue;}
case 83:{f.Push(JValue.I(0));f.Pc=84;continue;}
case 84:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 85:{f.Push(f.Locals[4]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[9]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/cost/PaymentDecision","card","(Ljava/lang/Iterable;)Lforge/game/cost/PaymentDecision;","invokestatic",93);}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[3]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/cost/CostPartWithList","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",98);}
case 98:{f.StackOp("pop");f.Pc=99;continue;}
case 99:{f.Push(JValue.I(1));f.Pc=100;continue;}
case 100:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7988(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[8]=f.Pop();f.Pc=6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"forge/game/mana/ManaCostBeingPaid"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/ManaCostBeingPaid")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","<init>","(Lforge/card/mana/ManaCost;)V","invokespecial",14);}
case 14:{f.Locals[9]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("XAlternative")));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("X")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",27);}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",30);}
case 30:{f.Locals[10]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getXColor","()Ljava/lang/String;","invokevirtual",36);}
case 36:{f.Locals[11]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[8]);f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("Spend only colored mana on X. No more than one mana of each color may be spent this way.")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?54:49;continue;}
case 49:{f.Push(JValue.R(rt.String("WUBRGX")));f.Pc=52;continue;}
case 52:{f.Locals[11]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/cost/CostPartMana","getAmountOfX","()I","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int<=0?103:61;continue;}
case 61:{f.Push(JValue.R(rt.String("Count$xPaid")));f.Pc=64;continue;}
case 64:{f.Push(f.Locals[10]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int!=0?103:72;continue;}
case 72:{f.Push(f.Locals[8]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[10]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[3]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",80);}
case 80:{f.Locals[12]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[9]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[12]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[11]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","setXManaCostPaid","(ILjava/lang/String;)V","invokevirtual",91);}
case 91:{f.Push(f.Locals[3]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[12]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",97);}
case 97:{return rt.Call(f,"forge/game/spellability/SpellAbility","setXManaCostPaid","(Ljava/lang/Integer;)V","invokevirtual",100);}
case 100:{f.Pc=124;continue;}
case 103:{f.Push(f.Locals[3]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/spellability/SpellAbility","getXManaCostPaid","()Ljava/lang/Integer;","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Reference==null?124:110;continue;}
case 110:{f.Push(f.Locals[9]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[3]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/spellability/SpellAbility","getXManaCostPaid","()Ljava/lang/Integer;","invokevirtual",116);}
case 116:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",119);}
case 119:{f.Push(f.Locals[11]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","setXManaCostPaid","(ILjava/lang/String;)V","invokevirtual",124);}
case 124:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=127;continue;}
case 127:{f.StackOp("dup");f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",131);}
case 131:{f.Locals[12]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(f.Locals[9]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[3]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[4]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[12]);f.Pc=140;continue;}
case 140:{f.Push(JValue.I(0));f.Pc=141;continue;}
case 141:{f.Push(f.Locals[7]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/cost/CostAdjustment","adjust","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Lforge/game/card/CardCollection;ZZ)Z","invokestatic",146);}
case 146:{f.StackOp("pop");f.Pc=147;continue;}
case 147:{f.Push(JValue.R(null));f.Pc=148;continue;}
case 148:{f.Locals[13]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(JValue.R(null));f.Pc=151;continue;}
case 151:{f.Locals[14]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(f.Locals[3]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOffering","()Z","invokevirtual",157);}
case 157:{f.Pc=f.Pop().Int==0?184:160;continue;}
case 160:{f.Push(f.Locals[3]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSacrificedAsOffering","()Lforge/game/card/Card;","invokevirtual",164);}
case 164:{f.Pc=f.Pop().Reference!=null?178:167;continue;}
case 167:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=170;continue;}
case 170:{f.Push(JValue.R(rt.String("Sacrifice input for Offering cancelled")));f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",176);}
case 176:{f.Push(JValue.I(0));f.Pc=177;continue;}
case 177:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 178:{f.Push(f.Locals[3]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSacrificedAsOffering","()Lforge/game/card/Card;","invokevirtual",182);}
case 182:{f.Locals[13]=f.Pop();f.Pc=184;continue;}
case 184:{f.Push(f.Locals[3]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/game/spellability/SpellAbility","isEmerge","()Z","invokevirtual",188);}
case 188:{f.Pc=f.Pop().Int==0?215:191;continue;}
case 191:{f.Push(f.Locals[3]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSacrificedAsEmerge","()Lforge/game/card/Card;","invokevirtual",195);}
case 195:{f.Pc=f.Pop().Reference!=null?209:198;continue;}
case 198:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=201;continue;}
case 201:{f.Push(JValue.R(rt.String("Sacrifice input for Emerge cancelled")));f.Pc=204;continue;}
case 204:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",207);}
case 207:{f.Push(JValue.I(0));f.Pc=208;continue;}
case 208:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 209:{f.Push(f.Locals[3]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSacrificedAsEmerge","()Lforge/game/card/Card;","invokevirtual",213);}
case 213:{f.Locals[14]=f.Pop();f.Pc=215;continue;}
case 215:{f.Push(f.Locals[9]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","isPaid","()Z","invokevirtual",220);}
case 220:{f.Pc=f.Pop().Int!=0?289:223;continue;}
case 223:{f.Push(f.Locals[6]);f.Pc=225;continue;}
case 225:{f.Pc=f.Pop().Reference!=null?255:228;continue;}
case 228:{if(!rt.EnsureInitialized(f,"forge/game/mana/ManaConversionMatrix"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/ManaConversionMatrix")));f.Pc=231;continue;}
case 231:{f.StackOp("dup");f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/mana/ManaConversionMatrix","<init>","()V","invokespecial",235);}
case 235:{f.Locals[6]=f.Pop();f.Pc=237;continue;}
case 237:{f.Push(f.Locals[6]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"forge/game/mana/ManaConversionMatrix","restoreColorReplacements","()V","invokevirtual",242);}
case 242:{f.Push(f.Locals[6]);f.Pc=244;continue;}
case 244:{f.Push(f.Locals[4]);f.Pc=246;continue;}
case 246:{f.Push(f.Locals[3]);f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",250);}
case 250:{f.Push(JValue.R(null));f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/staticability/StaticAbilityManaConvert","manaConvert","(Lforge/game/mana/ManaConversionMatrix;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokestatic",254);}
case 254:{f.StackOp("pop");f.Pc=255;continue;}
case 255:{f.Push(f.Locals[0]);f.Pc=256;continue;}
case 256:{f.Push(f.Locals[9]);f.Pc=258;continue;}
case 258:{f.Push(f.Locals[3]);f.Pc=259;continue;}
case 259:{f.Push(f.Locals[5]);f.Pc=261;continue;}
case 261:{f.Push(f.Locals[6]);f.Pc=263;continue;}
case 263:{f.Push(f.Locals[7]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/player/PlayerController","applyManaToCost","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/mana/ManaConversionMatrix;Z)Z","invokevirtual",268);}
case 268:{f.Pc=f.Pop().Int!=0?279:271;continue;}
case 271:{f.Push(f.Locals[3]);f.Pc=272;continue;}
case 272:{f.Push(f.Locals[12]);f.Pc=274;continue;}
case 274:{f.Push(JValue.I(1));f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/game/player/PlaySpellAbility","handleOfferingConvokeAndDelve","(Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;Z)Z","invokestatic",278);}
case 278:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 279:{f.Push(f.Locals[8]);f.Pc=281;continue;}
case 281:{f.Push(f.Locals[9]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","getXManaCostPaidByColor","()Ljava/util/Map;","invokevirtual",286);}
case 286:{return rt.Call(f,"forge/game/card/Card","setXManaCostPaidByColor","(Ljava/util/Map;)V","invokevirtual",289);}
case 289:{f.Push(f.Locals[3]);f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOffering","()Z","invokevirtual",293);}
case 293:{f.Pc=f.Pop().Int==0?314:296;continue;}
case 296:{f.Push(f.Locals[3]);f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSacrificedAsOffering","()Lforge/game/card/Card;","invokevirtual",300);}
case 300:{f.Pc=f.Pop().Reference!=null?314:303;continue;}
case 303:{f.Push(f.Locals[13]);f.Pc=305;continue;}
case 305:{f.Pc=f.Pop().Reference==null?314:308;continue;}
case 308:{f.Push(f.Locals[3]);f.Pc=309;continue;}
case 309:{f.Push(f.Locals[13]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSacrificedAsOffering","(Lforge/game/card/Card;)V","invokevirtual",314);}
case 314:{f.Push(f.Locals[3]);f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/spellability/SpellAbility","isEmerge","()Z","invokevirtual",318);}
case 318:{f.Pc=f.Pop().Int==0?339:321;continue;}
case 321:{f.Push(f.Locals[3]);f.Pc=322;continue;}
case 322:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSacrificedAsEmerge","()Lforge/game/card/Card;","invokevirtual",325);}
case 325:{f.Pc=f.Pop().Reference!=null?339:328;continue;}
case 328:{f.Push(f.Locals[14]);f.Pc=330;continue;}
case 330:{f.Pc=f.Pop().Reference==null?339:333;continue;}
case 333:{f.Push(f.Locals[3]);f.Pc=334;continue;}
case 334:{f.Push(f.Locals[14]);f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSacrificedAsEmerge","(Lforge/game/card/Card;)V","invokevirtual",339);}
case 339:{f.Push(f.Locals[3]);f.Pc=340;continue;}
case 340:{f.Push(f.Locals[12]);f.Pc=342;continue;}
case 342:{f.Push(JValue.I(0));f.Pc=343;continue;}
case 343:{return rt.Call(f,"forge/game/player/PlaySpellAbility","handleOfferingConvokeAndDelve","(Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;Z)Z","invokestatic",346);}
case 346:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7989(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/Game","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",20);}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/Game","getLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",25);}
case 25:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","(Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;)V","invokespecial",28);}
case 28:{f.Locals[5]=f.Pop();f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",33);}
case 33:{f.Locals[6]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[6]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[5]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/card/CardZoneTable;)V","invokestatic",42);}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{f.Pc=f.Pop().Int!=0?132:46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int!=0?132:53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",57);}
case 57:{f.Locals[7]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[7]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",66);}
case 66:{f.Pc=f.Pop().Int==0?132:69;continue;}
case 69:{f.Push(f.Locals[7]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",76);}
case 76:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=79;continue;}
case 79:{f.Locals[8]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[3]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[8]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/card/Card","addDelved","(Lforge/game/card/Card;)V","invokevirtual",87);}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",92);}
case 92:{f.Push(f.Locals[8]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(null));f.Pc=95;continue;}
case 95:{f.Push(f.Locals[6]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/GameAction","exile","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",100);}
case 100:{f.Locals[9]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[3]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[9]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/card/Card","addExiledCard","(Lforge/game/card/Card;)V","invokevirtual",108);}
case 108:{f.Push(f.Locals[9]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[3]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/card/Card","setExiledWith","(Lforge/game/card/Card;)V","invokevirtual",114);}
case 114:{f.Push(f.Locals[9]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[3]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",120);}
case 120:{return rt.Call(f,"forge/game/card/Card","setExiledBy","(Lforge/game/player/Player;)V","invokevirtual",123);}
case 123:{f.Push(f.Locals[9]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[0]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/card/Card","setExiledSA","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",129);}
case 129:{f.Pc=59;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOffering","()Z","invokevirtual",136);}
case 136:{f.Pc=f.Pop().Int==0?188:139;continue;}
case 139:{f.Push(f.Locals[0]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSacrificedAsOffering","()Lforge/game/card/Card;","invokevirtual",143);}
case 143:{f.Pc=f.Pop().Reference==null?188:146;continue;}
case 146:{f.Push(f.Locals[0]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSacrificedAsOffering","()Lforge/game/card/Card;","invokevirtual",150);}
case 150:{f.Locals[7]=f.Pop();f.Pc=152;continue;}
case 152:{f.Push(f.Locals[7]);f.Pc=154;continue;}
case 154:{f.Push(JValue.I(0));f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/card/Card","setUsedToPay","(Z)V","invokevirtual",158);}
case 158:{f.Push(f.Locals[2]);f.Pc=159;continue;}
case 159:{f.Pc=f.Pop().Int!=0?184:162;continue;}
case 162:{f.Push(f.Locals[4]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",167);}
case 167:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=170;continue;}
case 170:{f.StackOp("dup");f.Pc=171;continue;}
case 171:{f.Push(f.Locals[7]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",176);}
case 176:{f.Push(f.Locals[0]);f.Pc=177;continue;}
case 177:{f.Push(JValue.I(0));f.Pc=178;continue;}
case 178:{f.Push(f.Locals[6]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/GameAction","sacrifice","(Ljava/lang/Iterable;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Lforge/game/card/CardCollection;","invokevirtual",183);}
case 183:{f.StackOp("pop");f.Pc=184;continue;}
case 184:{f.Push(f.Locals[0]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/game/spellability/SpellAbility","resetSacrificedAsOffering","()V","invokevirtual",188);}
case 188:{f.Push(f.Locals[0]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/spellability/SpellAbility","isEmerge","()Z","invokevirtual",192);}
case 192:{f.Pc=f.Pop().Int==0?258:195;continue;}
case 195:{f.Push(f.Locals[0]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSacrificedAsEmerge","()Lforge/game/card/Card;","invokevirtual",199);}
case 199:{f.Pc=f.Pop().Reference==null?258:202;continue;}
case 202:{f.Push(f.Locals[0]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSacrificedAsEmerge","()Lforge/game/card/Card;","invokevirtual",206);}
case 206:{f.Locals[7]=f.Pop();f.Pc=208;continue;}
case 208:{f.Push(f.Locals[7]);f.Pc=210;continue;}
case 210:{f.Push(JValue.I(0));f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/card/Card","setUsedToPay","(Z)V","invokevirtual",214);}
case 214:{f.Push(f.Locals[2]);f.Pc=215;continue;}
case 215:{f.Pc=f.Pop().Int!=0?254:218;continue;}
case 218:{f.Push(f.Locals[4]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",223);}
case 223:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=226;continue;}
case 226:{f.StackOp("dup");f.Pc=227;continue;}
case 227:{f.Push(f.Locals[7]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",232);}
case 232:{f.Push(f.Locals[0]);f.Pc=233;continue;}
case 233:{f.Push(JValue.I(0));f.Pc=234;continue;}
case 234:{f.Push(f.Locals[6]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/game/GameAction","sacrifice","(Ljava/lang/Iterable;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Lforge/game/card/CardCollection;","invokevirtual",239);}
case 239:{f.StackOp("pop");f.Pc=240;continue;}
case 240:{f.Push(f.Locals[0]);f.Pc=241;continue;}
case 241:{f.Push(f.Locals[4]);f.Pc=243;continue;}
case 243:{f.Push(f.Locals[7]);f.Pc=245;continue;}
case 245:{return rt.Call(f,"forge/game/Game","getChangeZoneLKIInfo","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",248);}
case 248:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSacrificedAsEmerge","(Lforge/game/card/Card;)V","invokevirtual",251);}
case 251:{f.Pc=258;continue;}
case 254:{f.Push(f.Locals[0]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/spellability/SpellAbility","resetSacrificedAsEmerge","()V","invokevirtual",258);}
case 258:{f.Push(f.Locals[5]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/card/CardZoneTable","isEmpty","()Z","invokevirtual",263);}
case 263:{f.Pc=f.Pop().Int!=0?278:266;continue;}
case 266:{f.Push(f.Locals[2]);f.Pc=267;continue;}
case 267:{f.Pc=f.Pop().Int!=0?278:270;continue;}
case 270:{f.Push(f.Locals[5]);f.Pc=272;continue;}
case 272:{f.Push(f.Locals[4]);f.Pc=274;continue;}
case 274:{f.Push(f.Locals[0]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",278);}
case 278:{f.Push(f.Locals[2]);f.Pc=279;continue;}
case 279:{f.Pc=f.Pop().Int!=0?286:282;continue;}
case 282:{f.Push(JValue.I(1));f.Pc=283;continue;}
case 283:{f.Pc=287;continue;}
case 286:{f.Push(JValue.I(0));f.Pc=287;continue;}
case 287:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7990(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/Card","setSplitStateToPlayAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",10);}
case 10:{if(!rt.EnsureInitialized(f,"forge/game/player/PlaySpellAbility"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlaySpellAbility")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/player/PlaySpellAbility","<init>","(Lforge/game/player/PlayerController;Lforge/game/spellability/SpellAbility;)V","invokespecial",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/player/PlaySpellAbility","playAbility","(ZZZ)Z","invokevirtual",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7991(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",5);}
case 5:{if(!rt.EnsureInitialized(f,"forge/game/player/PlaySpellAbility"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlaySpellAbility")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/PlaySpellAbility","<init>","(Lforge/game/player/PlayerController;Lforge/game/spellability/SpellAbility;)V","invokespecial",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[4]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{f.Pc=f.Pop().Int!=0?26:22;continue;}
case 22:{f.Push(JValue.I(1));f.Pc=23;continue;}
case 23:{f.Pc=27;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/player/PlaySpellAbility","playAbility","(ZZZ)Z","invokevirtual",32);}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7992(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",7);}
case 7:{f.Locals[4]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[4]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Locals[5]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[5]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/game/zone/MagicStack","isFrozen","()Z","invokevirtual",24);}
case 24:{f.Locals[6]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/game/trigger/TriggerHandler","getWaitingTriggerCount","()I","invokevirtual",34);}
case 34:{f.Locals[7]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{f.Pc=f.Pop().Int!=0?140:40;continue;}
case 40:{f.Push(f.Locals[6]);f.Pc=42;continue;}
case 42:{f.Pc=f.Pop().Int!=0?50:45;continue;}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/Game","setTopLibsCast","()V","invokevirtual",50);}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",57);}
case 57:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"));f.Pc=60;continue;}
case 60:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?129:63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("X")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAnnouncing","(Ljava/lang/String;)Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int==0?108:76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",84);}
case 84:{return rt.Call(f,"forge/game/cost/Cost","hasXInAnyCostPart","()Z","invokevirtual",87);}
case 87:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/PlaySpellAbility","needX","Z",value);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/player/PlaySpellAbility","announceValuesLikeX","()Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int!=0?108:97;continue;}
case 97:{f.Push(f.Locals[5]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/Game","clearTopLibsCast","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",106);}
case 106:{f.Push(JValue.I(0));f.Pc=107;continue;}
case 107:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/ability/effects/CharmEffect","makeChoices","(Lforge/game/spellability/SpellAbility;)Z","invokestatic",115);}
case 115:{f.Pc=f.Pop().Int!=0?129:118;continue;}
case 118:{f.Push(f.Locals[5]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/Game","clearTopLibsCast","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",127);}
case 127:{f.Push(JValue.I(0));f.Pc=128;continue;}
case 128:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[0]);f.Pc=131;continue;}
case 131:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/ability/AbilityUtils","addSpliceEffects","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbility;","invokestatic",137);}
case 137:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;",value);f.Pc=140;continue;}
case 140:{f.Push(JValue.R(null));f.Pc=141;continue;}
case 141:{f.Locals[8]=f.Pop();f.Pc=143;continue;}
case 143:{f.Push(JValue.I(0));f.Pc=144;continue;}
case 144:{f.Locals[9]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[4]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/player/Player","getManaPool","()Lforge/game/mana/ManaPool;","invokevirtual",151);}
case 151:{f.Locals[10]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(f.Locals[0]);f.Pc=154;continue;}
case 154:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",160);}
case 160:{f.Locals[11]=f.Pop();f.Pc=162;continue;}
case 162:{f.Push(f.Locals[11]);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMayPlay","()Lforge/game/staticability/StaticAbility;","invokevirtual",171);}
case 171:{return rt.Call(f,"forge/game/card/Card","mayPlay","(Lforge/game/staticability/StaticAbility;)Lforge/game/card/CardPlayOption;","invokevirtual",174);}
case 174:{f.Locals[12]=f.Pop();f.Pc=176;continue;}
case 176:{f.Push(f.Locals[0]);f.Pc=177;continue;}
case 177:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",183);}
case 183:{f.Pc=f.Pop().Int==0?250:186;continue;}
case 186:{f.Push(f.Locals[11]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/card/Card","isCopiedSpell","()Z","invokevirtual",191);}
case 191:{f.Pc=f.Pop().Int!=0?250:194;continue;}
case 194:{f.Push(f.Locals[5]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[11]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",201);}
case 201:{f.Locals[8]=f.Pop();f.Pc=203;continue;}
case 203:{f.Push(f.Locals[8]);f.Pc=205;continue;}
case 205:{f.Pc=f.Pop().Reference==null?222:208;continue;}
case 208:{f.Push(f.Locals[8]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/zone/Zone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",213);}
case 213:{f.Push(f.Locals[11]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/card/CardCollectionView","indexOf","(Ljava/lang/Object;)I","invokeinterface",220);}
case 220:{f.Locals[9]=f.Pop();f.Pc=222;continue;}
case 222:{f.Push(f.Locals[0]);f.Pc=223;continue;}
case 223:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=226;continue;}
case 226:{f.Push(f.Locals[5]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",231);}
case 231:{f.Push(f.Locals[11]);f.Pc=233;continue;}
case 233:{f.Push(f.Locals[0]);f.Pc=234;continue;}
case 234:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/game/GameAction","moveToStack","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",240);}
case 240:{return rt.Call(f,"forge/game/spellability/SpellAbility","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",243);}
case 243:{f.Push(f.Locals[0]);f.Pc=244;continue;}
case 244:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/spellability/SpellAbility","changeText","()V","invokevirtual",250);}
case 250:{f.Push(f.Locals[0]);f.Pc=251;continue;}
case 251:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCopied","()Z","invokevirtual",257);}
case 257:{f.Pc=f.Pop().Int!=0?275:260;continue;}
case 260:{f.Push(f.Locals[0]);f.Pc=261;continue;}
case 261:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/game/spellability/SpellAbility","resetPaidHash","()V","invokevirtual",267);}
case 267:{f.Push(f.Locals[0]);f.Pc=268;continue;}
case 268:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=271;continue;}
case 271:{f.Push(JValue.I(0));f.Pc=272;continue;}
case 272:{return rt.Call(f,"forge/game/spellability/SpellAbility","setPaidLife","(I)V","invokevirtual",275);}
case 275:{f.Push(f.Locals[0]);f.Pc=276;continue;}
case 276:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",282);}
case 282:{f.Pc=f.Pop().Int==0?304:285;continue;}
case 285:{f.Push(f.Locals[11]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/card/Card","isCopiedSpell","()Z","invokevirtual",290);}
case 290:{f.Pc=f.Pop().Int!=0?304:293;continue;}
case 293:{f.Push(f.Locals[0]);f.Pc=294;continue;}
case 294:{f.Push(f.Locals[0]);f.Pc=295;continue;}
case 295:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/game/GameActionUtil","addExtraKeywordCost","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbility;","invokestatic",301);}
case 301:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;",value);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[0]);f.Pc=305;continue;}
case 305:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",311);}
case 311:{f.Locals[13]=f.Pop();f.Pc=313;continue;}
case 313:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPayment"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPayment")));f.Pc=316;continue;}
case 316:{f.StackOp("dup");f.Pc=317;continue;}
case 317:{f.Push(f.Locals[13]);f.Pc=319;continue;}
case 319:{f.Push(f.Locals[0]);f.Pc=320;continue;}
case 320:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=323;continue;}
case 323:{return rt.Call(f,"forge/game/cost/CostPayment","<init>","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;)V","invokespecial",326);}
case 326:{f.Locals[14]=f.Pop();f.Pc=328;continue;}
case 328:{f.Push(JValue.I(0));f.Pc=329;continue;}
case 329:{f.Locals[15]=f.Pop();f.Pc=331;continue;}
case 331:{f.Push(f.Locals[0]);f.Pc=332;continue;}
case 332:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCopied","()Z","invokevirtual",338);}
case 338:{f.Pc=f.Pop().Int!=0?500:341;continue;}
case 341:{f.Push(f.Locals[0]);f.Pc=342;continue;}
case 342:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=345;continue;}
case 345:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",348);}
case 348:{f.Pc=f.Pop().Int==0?388:351;continue;}
case 351:{f.Push(f.Locals[12]);f.Pc=353;continue;}
case 353:{f.Pc=f.Pop().Reference==null?369:356;continue;}
case 356:{f.Push(f.Locals[12]);f.Pc=358;continue;}
case 358:{f.Push(f.Locals[14]);f.Pc=360;continue;}
case 360:{return rt.Call(f,"forge/game/card/CardPlayOption","applyManaConvert","(Lforge/game/mana/ManaConversionMatrix;)Z","invokevirtual",363);}
case 363:{f.Pc=f.Pop().Int==0?369:366;continue;}
case 366:{f.Push(JValue.I(1));f.Pc=367;continue;}
case 367:{f.Locals[15]=f.Pop();f.Pc=369;continue;}
case 369:{f.Push(f.Locals[12]);f.Pc=371;continue;}
case 371:{f.Pc=f.Pop().Reference==null?388:374;continue;}
case 374:{f.Push(f.Locals[12]);f.Pc=376;continue;}
case 376:{return rt.Call(f,"forge/game/card/CardPlayOption","isIgnoreSnowSourceManaCostColor","()Z","invokevirtual",379);}
case 379:{f.Pc=f.Pop().Int==0?388:382;continue;}
case 382:{f.Push(f.Locals[14]);f.Pc=384;continue;}
case 384:{f.Push(JValue.I(1));f.Pc=385;continue;}
case 385:{return rt.Call(f,"forge/game/cost/CostPayment","setSnowForColor","(Z)V","invokevirtual",388);}
case 388:{f.Push(f.Locals[0]);f.Pc=389;continue;}
case 389:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/game/spellability/SpellAbility","isActivatedAbility","()Z","invokevirtual",395);}
case 395:{f.Pc=f.Pop().Int==0?445:398;continue;}
case 398:{f.Push(f.Locals[0]);f.Pc=399;continue;}
case 399:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=402;continue;}
case 402:{return rt.Call(f,"forge/game/spellability/SpellAbility","getGrantorStatic","()Lforge/game/staticability/StaticAbility;","invokevirtual",405);}
case 405:{f.Pc=f.Pop().Reference==null?445:408;continue;}
case 408:{f.Push(f.Locals[0]);f.Pc=409;continue;}
case 409:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=412;continue;}
case 412:{return rt.Call(f,"forge/game/spellability/SpellAbility","getGrantorStatic","()Lforge/game/staticability/StaticAbility;","invokevirtual",415);}
case 415:{f.Push(JValue.R(rt.String("ManaConversion")));f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",421);}
case 421:{f.Pc=f.Pop().Int==0?445:424;continue;}
case 424:{f.Push(f.Locals[14]);f.Pc=426;continue;}
case 426:{f.Push(f.Locals[0]);f.Pc=427;continue;}
case 427:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=430;continue;}
case 430:{return rt.Call(f,"forge/game/spellability/SpellAbility","getGrantorStatic","()Lforge/game/staticability/StaticAbility;","invokevirtual",433);}
case 433:{f.Push(JValue.R(rt.String("ManaConversion")));f.Pc=436;continue;}
case 436:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",439);}
case 439:{return rt.Call(f,"forge/game/ability/AbilityUtils","applyManaColorConversion","(Lforge/game/mana/ManaConversionMatrix;Ljava/lang/String;)V","invokestatic",442);}
case 442:{f.Push(JValue.I(1));f.Pc=443;continue;}
case 443:{f.Locals[15]=f.Pop();f.Pc=445;continue;}
case 445:{f.Push(f.Locals[14]);f.Pc=447;continue;}
case 447:{f.Push(f.Locals[4]);f.Pc=449;continue;}
case 449:{f.Push(f.Locals[0]);f.Pc=450;continue;}
case 450:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=453;continue;}
case 453:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",456);}
case 456:{f.Push(f.Locals[0]);f.Pc=457;continue;}
case 457:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=460;continue;}
case 460:{return rt.Call(f,"forge/game/staticability/StaticAbilityManaConvert","manaConvert","(Lforge/game/mana/ManaConversionMatrix;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokestatic",463);}
case 463:{f.Pc=f.Pop().Int==0?469:466;continue;}
case 466:{f.Push(JValue.I(1));f.Pc=467;continue;}
case 467:{f.Locals[15]=f.Pop();f.Pc=469;continue;}
case 469:{f.Push(f.Locals[0]);f.Pc=470;continue;}
case 470:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=473;continue;}
case 473:{f.Push(JValue.R(rt.String("ManaConversion")));f.Pc=476;continue;}
case 476:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",479);}
case 479:{f.Pc=f.Pop().Int==0?500:482;continue;}
case 482:{f.Push(f.Locals[14]);f.Pc=484;continue;}
case 484:{f.Push(f.Locals[0]);f.Pc=485;continue;}
case 485:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=488;continue;}
case 488:{f.Push(JValue.R(rt.String("ManaConversion")));f.Pc=491;continue;}
case 491:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",494);}
case 494:{return rt.Call(f,"forge/game/ability/AbilityUtils","applyManaColorConversion","(Lforge/game/mana/ManaConversionMatrix;Ljava/lang/String;)V","invokestatic",497);}
case 497:{f.Push(JValue.I(1));f.Pc=498;continue;}
case 498:{f.Locals[15]=f.Pop();f.Pc=500;continue;}
case 500:{f.Push(f.Locals[0]);f.Pc=501;continue;}
case 501:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=504;continue;}
case 504:{return rt.Call(f,"forge/game/spellability/SpellAbility","clearManaPaid","()V","invokevirtual",507);}
case 507:{f.Push(f.Locals[0]);f.Pc=508;continue;}
case 508:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=511;continue;}
case 511:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingManaAbilities","()Ljava/util/List;","invokevirtual",514);}
case 514:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",519);}
case 519:{f.Push(f.Locals[0]);f.Pc=520;continue;}
case 520:{return rt.Call(f,"forge/game/player/PlaySpellAbility","announceType","()Z","invokevirtual",523);}
case 523:{f.Pc=f.Pop().Int==0?585:526;continue;}
case 526:{f.Push(f.Locals[0]);f.Pc=527;continue;}
case 527:{return rt.Call(f,"forge/game/player/PlaySpellAbility","announceValuesLikeX","()Z","invokevirtual",530);}
case 530:{f.Pc=f.Pop().Int==0?585:533;continue;}
case 533:{f.Push(f.Locals[0]);f.Pc=534;continue;}
case 534:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=537;continue;}
case 537:{f.Push(f.Locals[4]);f.Pc=539;continue;}
case 539:{return rt.Call(f,"forge/game/spellability/SpellAbility","checkRestrictions","(Lforge/game/player/Player;)Z","invokevirtual",542);}
case 542:{f.Pc=f.Pop().Int==0?585:545;continue;}
case 545:{f.Push(f.Locals[1]);f.Pc=546;continue;}
case 546:{f.Pc=f.Pop().Int==0?559:549;continue;}
case 549:{f.Push(f.Locals[0]);f.Pc=550;continue;}
case 550:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=553;continue;}
case 553:{return rt.Call(f,"forge/game/spellability/SpellAbility","setupTargets","()Z","invokevirtual",556);}
case 556:{f.Pc=f.Pop().Int==0?585:559;continue;}
case 559:{f.Push(f.Locals[0]);f.Pc=560;continue;}
case 560:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=563;continue;}
case 563:{f.Push(f.Locals[4]);f.Pc=565;continue;}
case 565:{return rt.Call(f,"forge/game/spellability/SpellAbility","canCastTiming","(Lforge/game/player/Player;)Z","invokevirtual",568);}
case 568:{f.Pc=f.Pop().Int==0?585:571;continue;}
case 571:{f.Push(f.Locals[0]);f.Pc=572;continue;}
case 572:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=575;continue;}
case 575:{return rt.Call(f,"forge/game/spellability/SpellAbility","isLegalAfterStack","()Z","invokevirtual",578);}
case 578:{f.Pc=f.Pop().Int==0?585:581;continue;}
case 581:{f.Push(JValue.I(1));f.Pc=582;continue;}
case 582:{f.Pc=586;continue;}
case 585:{f.Push(JValue.I(0));f.Pc=586;continue;}
case 586:{f.Locals[16]=f.Pop();f.Pc=588;continue;}
case 588:{f.Push(f.Locals[5]);f.Pc=590;continue;}
case 590:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",593);}
case 593:{f.Push(f.Locals[3]);f.Pc=594;continue;}
case 594:{f.Pc=f.Pop().Int==0?601:597;continue;}
case 597:{f.Push(JValue.R(null));f.Pc=598;continue;}
case 598:{f.Pc=605;continue;}
case 601:{f.Push(f.Locals[0]);f.Pc=602;continue;}
case 602:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=605;continue;}
case 605:{return rt.Call(f,"forge/game/zone/MagicStack","freezeStack","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",608);}
case 608:{f.Push(f.Locals[16]);f.Pc=610;continue;}
case 610:{f.Pc=f.Pop().Int==0?649:613;continue;}
case 613:{f.Push(f.Locals[2]);f.Pc=614;continue;}
case 614:{f.Pc=f.Pop().Int!=0?645:617;continue;}
case 617:{f.Push(f.Locals[14]);f.Pc=619;continue;}
case 619:{f.Push(f.Locals[0]);f.Pc=620;continue;}
case 620:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","controller","Lforge/game/player/PlayerController;"));f.Pc=623;continue;}
case 623:{f.Push(f.Locals[4]);f.Pc=625;continue;}
case 625:{f.Push(f.Locals[0]);f.Pc=626;continue;}
case 626:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=629;continue;}
case 629:{f.Push(f.Locals[0]);f.Pc=630;continue;}
case 630:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=633;continue;}
case 633:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",636);}
case 636:{return rt.Call(f,"forge/game/player/PlayerController","getCostDecisionMaker","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Z)Lforge/game/cost/CostDecisionMakerBase;","invokevirtual",639);}
case 639:{return rt.Call(f,"forge/game/cost/CostPayment","payCost","(Lforge/game/cost/CostDecisionMakerBase;)Z","invokevirtual",642);}
case 642:{f.Pc=f.Pop().Int==0?649:645;continue;}
case 645:{f.Push(JValue.I(1));f.Pc=646;continue;}
case 646:{f.Pc=650;continue;}
case 649:{f.Push(JValue.I(0));f.Pc=650;continue;}
case 650:{f.Locals[17]=f.Pop();f.Pc=652;continue;}
case 652:{f.Push(f.Locals[5]);f.Pc=654;continue;}
case 654:{f.Push(f.Locals[0]);f.Pc=655;continue;}
case 655:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=658;continue;}
case 658:{return rt.Call(f,"forge/game/Game","clearTopLibsCast","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",661);}
case 661:{f.Push(f.Locals[17]);f.Pc=663;continue;}
case 663:{f.Pc=f.Pop().Int!=0?759:666;continue;}
case 666:{f.Push(f.Locals[0]);f.Pc=667;continue;}
case 667:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=670;continue;}
case 670:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",673);}
case 673:{f.Pc=f.Pop().Int==0?717:676;continue;}
case 676:{f.Push(f.Locals[5]);f.Pc=678;continue;}
case 678:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","EXPERIMENTAL_RESTORE_SNAPSHOT","Z"));f.Pc=681;continue;}
case 681:{f.Pc=f.Pop().Int==0?709:684;continue;}
case 684:{f.Push(f.Locals[16]);f.Pc=686;continue;}
case 686:{f.Pc=f.Pop().Int==0?709:689;continue;}
case 689:{f.Push(f.Locals[0]);f.Pc=690;continue;}
case 690:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=693;continue;}
case 693:{f.Push(f.Locals[8]);f.Pc=695;continue;}
case 695:{f.Push(f.Locals[9]);f.Pc=697;continue;}
case 697:{f.Push(f.Locals[14]);f.Pc=699;continue;}
case 699:{f.Push(f.Locals[11]);f.Pc=701;continue;}
case 701:{f.Push(f.Locals[7]);f.Pc=703;continue;}
case 703:{return rt.Call(f,"forge/game/GameActionUtil","rollbackAbility","(Lforge/game/spellability/SpellAbility;Lforge/game/zone/Zone;ILforge/game/cost/CostPayment;Lforge/game/card/Card;I)V","invokestatic",706);}
case 706:{f.Pc=734;continue;}
case 709:{f.Push(f.Locals[14]);f.Pc=711;continue;}
case 711:{return rt.Call(f,"forge/game/cost/CostPayment","refundPayment","()V","invokevirtual",714);}
case 714:{f.Pc=734;continue;}
case 717:{f.Push(f.Locals[0]);f.Pc=718;continue;}
case 718:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=721;continue;}
case 721:{f.Push(f.Locals[8]);f.Pc=723;continue;}
case 723:{f.Push(f.Locals[9]);f.Pc=725;continue;}
case 725:{f.Push(f.Locals[14]);f.Pc=727;continue;}
case 727:{f.Push(f.Locals[11]);f.Pc=729;continue;}
case 729:{f.Push(f.Locals[7]);f.Pc=731;continue;}
case 731:{return rt.Call(f,"forge/game/GameActionUtil","rollbackAbility","(Lforge/game/spellability/SpellAbility;Lforge/game/zone/Zone;ILforge/game/cost/CostPayment;Lforge/game/card/Card;I)V","invokestatic",734);}
case 734:{f.Push(f.Locals[6]);f.Pc=736;continue;}
case 736:{f.Pc=f.Pop().Int!=0?747:739;continue;}
case 739:{f.Push(f.Locals[5]);f.Pc=741;continue;}
case 741:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",744);}
case 744:{return rt.Call(f,"forge/game/zone/MagicStack","unfreezeStack","()V","invokevirtual",747);}
case 747:{f.Push(f.Locals[15]);f.Pc=749;continue;}
case 749:{f.Pc=f.Pop().Int==0?757:752;continue;}
case 752:{f.Push(f.Locals[10]);f.Pc=754;continue;}
case 754:{return rt.Call(f,"forge/game/mana/ManaPool","restoreColorReplacements","()V","invokevirtual",757);}
case 757:{f.Push(JValue.I(0));f.Pc=758;continue;}
case 758:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 759:{f.Push(f.Locals[2]);f.Pc=760;continue;}
case 760:{f.Pc=f.Pop().Int!=0?771:763;continue;}
case 763:{f.Push(f.Locals[14]);f.Pc=765;continue;}
case 765:{return rt.Call(f,"forge/game/cost/CostPayment","isFullyPaid","()Z","invokevirtual",768);}
case 768:{f.Pc=f.Pop().Int==0?844:771;continue;}
case 771:{f.Push(f.Locals[4]);f.Pc=773;continue;}
case 773:{return rt.Call(f,"forge/game/player/Player","getAchievementTracker","()Lforge/game/player/AchievementTracker;","invokevirtual",776);}
case 776:{f.Push(f.Locals[0]);f.Pc=777;continue;}
case 777:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=780;continue;}
case 780:{return rt.Call(f,"forge/game/player/AchievementTracker","onSpellAbilityPlayed","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",783);}
case 783:{f.Push(f.Locals[3]);f.Pc=784;continue;}
case 784:{f.Pc=f.Pop().Int==0?815:787;continue;}
case 787:{f.Push(f.Locals[0]);f.Pc=788;continue;}
case 788:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=791;continue;}
case 791:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",794);}
case 794:{f.Push(f.Locals[0]);f.Pc=795;continue;}
case 795:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=798;continue;}
case 798:{return rt.Call(f,"forge/game/spellability/SpellAbility","isReplacementAbility","()Z","invokevirtual",801);}
case 801:{f.Pc=f.Pop().Int!=0?834:804;continue;}
case 804:{f.Push(f.Locals[5]);f.Pc=806;continue;}
case 806:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",809);}
case 809:{return rt.Call(f,"forge/game/zone/MagicStack","unfreezeStack","()V","invokevirtual",812);}
case 812:{f.Pc=834;continue;}
case 815:{f.Push(f.Locals[0]);f.Pc=816;continue;}
case 816:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=819;continue;}
case 819:{return rt.Call(f,"forge/game/player/PlaySpellAbility","ensureAbilityHasDescription","(Lforge/game/spellability/SpellAbility;)V","invokestatic",822);}
case 822:{f.Push(f.Locals[5]);f.Pc=824;continue;}
case 824:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",827);}
case 827:{f.Push(f.Locals[0]);f.Pc=828;continue;}
case 828:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=831;continue;}
case 831:{return rt.Call(f,"forge/game/zone/MagicStack","addAndUnfreeze","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",834);}
case 834:{f.Push(f.Locals[15]);f.Pc=836;continue;}
case 836:{f.Pc=f.Pop().Int==0?844:839;continue;}
case 839:{f.Push(f.Locals[10]);f.Pc=841;continue;}
case 841:{return rt.Call(f,"forge/game/mana/ManaPool","restoreColorReplacements","()V","invokevirtual",844);}
case 844:{f.Push(JValue.I(1));f.Pc=845;continue;}
case 845:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7993(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCopied","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?20:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","isWrapper","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?22:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",29);}
case 29:{f.Locals[1]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",37);}
case 37:{f.Locals[2]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("Announce")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",48);}
case 48:{f.Locals[3]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{f.Pc=f.Pop().Reference==null?212:53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","needX","Z"));f.Pc=57;continue;}
case 57:{f.Pc=f.Pop().Int==0?212:60;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String(",")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",67);}
case 67:{f.Locals[4]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=72;continue;}
case 72:{f.Locals[5]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(JValue.I(0));f.Pc=75;continue;}
case 75:{f.Locals[6]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[6]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[5]);f.Pc=81;continue;}
case 81:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?212:84;continue;}
case 84:{f.Push(f.Locals[4]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[6]);f.Pc=88;continue;}
case 88:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=89;continue;}
case 89:{f.Locals[7]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[7]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",96);}
case 96:{f.Locals[8]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=102;continue;}
case 102:{f.Push(f.Locals[8]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/ability/AbilityUtils","getAnnouncementBounds","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lorg/apache/commons/lang3/Range;","invokestatic",107);}
case 107:{f.Locals[9]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","controller","Lforge/game/player/PlayerController;"));f.Pc=113;continue;}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=117;continue;}
case 117:{f.Push(f.Locals[9]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"org/apache/commons/lang3/Range","getMinimum","()Ljava/lang/Object;","invokevirtual",122);}
case 122:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",128);}
case 128:{f.Push(f.Locals[9]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"org/apache/commons/lang3/Range","getMaximum","()Ljava/lang/Object;","invokevirtual",133);}
case 133:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",139);}
case 139:{f.Push(f.Locals[8]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/player/PlayerController","announceRequirements","(Lforge/game/spellability/SpellAbility;IILjava/lang/String;)Ljava/lang/Integer;","invokevirtual",144);}
case 144:{f.Locals[10]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[10]);f.Pc=148;continue;}
case 148:{f.Pc=f.Pop().Reference!=null?153:151;continue;}
case 151:{f.Push(JValue.I(0));f.Pc=152;continue;}
case 152:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 153:{f.Push(JValue.R(rt.String("X")));f.Pc=156;continue;}
case 156:{f.Push(f.Locals[8]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",161);}
case 161:{f.Pc=f.Pop().Int==0?181:164;continue;}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{f.Push(JValue.I(0));f.Pc=166;continue;}
case 166:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/PlaySpellAbility","needX","Z",value);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[0]);f.Pc=170;continue;}
case 170:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=173;continue;}
case 173:{f.Push(f.Locals[10]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/spellability/SpellAbility","setXManaCostPaid","(Ljava/lang/Integer;)V","invokevirtual",178);}
case 178:{f.Pc=206;continue;}
case 181:{f.Push(f.Locals[0]);f.Pc=182;continue;}
case 182:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=185;continue;}
case 185:{f.Push(f.Locals[8]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[10]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"java/lang/Integer","toString","()Ljava/lang/String;","invokevirtual",192);}
case 192:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",195);}
case 195:{f.Push(f.Locals[2]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[8]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[10]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"java/lang/Integer","toString","()Ljava/lang/String;","invokevirtual",203);}
case 203:{return rt.Call(f,"forge/game/card/Card","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",206);}
case 206:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=209;continue;}
case 209:{f.Pc=77;continue;}
case 212:{f.Push(f.Locals[0]);f.Pc=213;continue;}
case 213:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","needX","Z"));f.Pc=216;continue;}
case 216:{f.Pc=f.Pop().Int==0?389:219;continue;}
case 219:{f.Push(f.Locals[1]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/cost/Cost","hasXInAnyCostPart","()Z","invokevirtual",223);}
case 223:{f.Pc=f.Pop().Int==0?381:226;continue;}
case 226:{f.Push(f.Locals[0]);f.Pc=227;continue;}
case 227:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=230;continue;}
case 230:{f.Push(JValue.R(rt.String("XAlternative")));f.Pc=233;continue;}
case 233:{f.Push(f.Locals[0]);f.Pc=234;continue;}
case 234:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=237;continue;}
case 237:{f.Push(JValue.R(rt.String("X")));f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",243);}
case 243:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",246);}
case 246:{f.Locals[4]=f.Pop();f.Pc=248;continue;}
case 248:{f.Push(f.Locals[0]);f.Pc=249;continue;}
case 249:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",255);}
case 255:{f.Pc=f.Pop().Int==0?285:258;continue;}
case 258:{f.Push(f.Locals[0]);f.Pc=259;continue;}
case 259:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",265);}
case 265:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",268);}
case 268:{return rt.Call(f,"forge/card/mana/ManaCost","countX","()I","invokevirtual",271);}
case 271:{f.Pc=f.Pop().Int<=0?285:274;continue;}
case 274:{f.Push(f.Locals[1]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/game/cost/Cost","hasXInAnyCostPart","()Z","invokevirtual",278);}
case 278:{f.Pc=f.Pop().Int!=0?285:281;continue;}
case 281:{f.Push(JValue.I(1));f.Pc=282;continue;}
case 282:{f.Pc=286;continue;}
case 285:{f.Push(JValue.I(0));f.Pc=286;continue;}
case 286:{f.Locals[5]=f.Pop();f.Pc=288;continue;}
case 288:{f.Push(JValue.R(rt.String("Count$xPaid")));f.Pc=291;continue;}
case 291:{f.Push(f.Locals[4]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",296);}
case 296:{f.Pc=f.Pop().Int==0?304:299;continue;}
case 299:{f.Push(f.Locals[5]);f.Pc=301;continue;}
case 301:{f.Pc=f.Pop().Int==0?312:304;continue;}
case 304:{f.Push(f.Locals[4]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",309);}
case 309:{f.Pc=f.Pop().Int==0?378:312;continue;}
case 312:{f.Push(f.Locals[0]);f.Pc=313;continue;}
case 313:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=316;continue;}
case 316:{f.Push(JValue.R(rt.String("X")));f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/game/ability/AbilityUtils","getAnnouncementBounds","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lorg/apache/commons/lang3/Range;","invokestatic",322);}
case 322:{f.Locals[6]=f.Pop();f.Pc=324;continue;}
case 324:{f.Push(f.Locals[0]);f.Pc=325;continue;}
case 325:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","controller","Lforge/game/player/PlayerController;"));f.Pc=328;continue;}
case 328:{f.Push(f.Locals[0]);f.Pc=329;continue;}
case 329:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=332;continue;}
case 332:{f.Push(f.Locals[6]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"org/apache/commons/lang3/Range","getMinimum","()Ljava/lang/Object;","invokevirtual",337);}
case 337:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=340;continue;}
case 340:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",343);}
case 343:{f.Push(f.Locals[6]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"org/apache/commons/lang3/Range","getMaximum","()Ljava/lang/Object;","invokevirtual",348);}
case 348:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=351;continue;}
case 351:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",354);}
case 354:{f.Push(JValue.R(rt.String("X")));f.Pc=357;continue;}
case 357:{return rt.Call(f,"forge/game/player/PlayerController","announceRequirements","(Lforge/game/spellability/SpellAbility;IILjava/lang/String;)Ljava/lang/Integer;","invokevirtual",360);}
case 360:{f.Locals[7]=f.Pop();f.Pc=362;continue;}
case 362:{f.Push(f.Locals[7]);f.Pc=364;continue;}
case 364:{f.Pc=f.Pop().Reference!=null?369:367;continue;}
case 367:{f.Push(JValue.I(0));f.Pc=368;continue;}
case 368:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 369:{f.Push(f.Locals[0]);f.Pc=370;continue;}
case 370:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=373;continue;}
case 373:{f.Push(f.Locals[7]);f.Pc=375;continue;}
case 375:{return rt.Call(f,"forge/game/spellability/SpellAbility","setXManaCostPaid","(Ljava/lang/Integer;)V","invokevirtual",378);}
case 378:{f.Pc=389;continue;}
case 381:{f.Push(f.Locals[0]);f.Pc=382;continue;}
case 382:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=385;continue;}
case 385:{f.Push(JValue.R(null));f.Pc=386;continue;}
case 386:{return rt.Call(f,"forge/game/spellability/SpellAbility","setXManaCostPaid","(Ljava/lang/Integer;)V","invokevirtual",389);}
case 389:{f.Push(JValue.I(1));f.Pc=390;continue;}
case 390:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7994(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCopied","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?12:10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("AnnounceType")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",22);}
case 22:{f.Locals[1]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",30);}
case 30:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",33);}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Reference==null?290:38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String(",")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",45);}
case 45:{f.Locals[3]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=48;continue;}
case 48:{f.Locals[4]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{f.Locals[5]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[5]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?290:60;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=64;continue;}
case 64:{f.Locals[6]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[6]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",71);}
case 71:{f.Locals[7]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("CreatureType")));f.Pc=76;continue;}
case 76:{f.Push(f.Locals[7]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",81);}
case 81:{f.Pc=f.Pop().Int==0?119:84;continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("Creature")));f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/card/CardType","getAllCreatureTypes","()Ljava/util/Collection;","invokestatic",95);}
case 95:{return rt.Call(f,"forge/game/player/PlayerController","chooseSomeType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Ljava/util/Collection;)Ljava/lang/String;","invokevirtual",98);}
case 98:{f.Locals[8]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[8]);f.Pc=102;continue;}
case 102:{f.Pc=f.Pop().Reference!=null?107:105;continue;}
case 105:{f.Push(JValue.I(0));f.Pc=106;continue;}
case 106:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",114);}
case 114:{f.Push(f.Locals[8]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/card/Card","setChosenType","(Ljava/lang/String;)V","invokevirtual",119);}
case 119:{f.Push(JValue.R(rt.String("ChooseNumber")));f.Pc=122;continue;}
case 122:{f.Push(f.Locals[7]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",127);}
case 127:{f.Pc=f.Pop().Int==0?208:130;continue;}
case 130:{f.Push(f.Locals[0]);f.Pc=131;continue;}
case 131:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=134;continue;}
case 134:{f.Push(JValue.R(rt.String("Min")));f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",140);}
case 140:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",143);}
case 143:{f.Locals[8]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(f.Locals[0]);f.Pc=146;continue;}
case 146:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=149;continue;}
case 149:{f.Push(JValue.R(rt.String("Max")));f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",155);}
case 155:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",158);}
case 158:{f.Locals[9]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",167);}
case 167:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",170);}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",177);}
case 177:{f.Push(JValue.R(rt.String("lblChooseNumber")));f.Pc=180;continue;}
case 180:{f.Push(JValue.I(0));f.Pc=181;continue;}
case 181:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",187);}
case 187:{f.Push(f.Locals[8]);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[9]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;II)I","invokevirtual",194);}
case 194:{f.Locals[10]=f.Pop();f.Pc=196;continue;}
case 196:{f.Push(f.Locals[0]);f.Pc=197;continue;}
case 197:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",203);}
case 203:{f.Push(f.Locals[10]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/card/Card","setChosenNumber","(I)V","invokevirtual",208);}
case 208:{f.Push(JValue.R(rt.String("Opponent")));f.Pc=211;continue;}
case 211:{f.Push(f.Locals[7]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",216);}
case 216:{f.Pc=f.Pop().Int==0?284:219;continue;}
case 219:{f.Push(f.Locals[0]);f.Pc=220;continue;}
case 220:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",226);}
case 226:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",229);}
case 229:{f.Push(f.Locals[0]);f.Pc=230;continue;}
case 230:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",236);}
case 236:{return rt.Call(f,"forge/game/player/Player","getOpponents","()Lforge/game/player/PlayerCollection;","invokevirtual",239);}
case 239:{f.Push(f.Locals[0]);f.Pc=240;continue;}
case 240:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",246);}
case 246:{f.Push(JValue.R(rt.String("lblChooseAnOpponent")));f.Pc=249;continue;}
case 249:{f.Push(JValue.I(0));f.Pc=250;continue;}
case 250:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=253;continue;}
case 253:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",256);}
case 256:{f.Push(JValue.R(null));f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",260);}
case 260:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=263;continue;}
case 263:{f.Locals[8]=f.Pop();f.Pc=265;continue;}
case 265:{f.Push(f.Locals[8]);f.Pc=267;continue;}
case 267:{f.Pc=f.Pop().Reference!=null?272:270;continue;}
case 270:{f.Push(JValue.I(0));f.Pc=271;continue;}
case 271:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 272:{f.Push(f.Locals[0]);f.Pc=273;continue;}
case 273:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlaySpellAbility","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",279);}
case 279:{f.Push(f.Locals[8]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/card/Card","setChosenPlayer","(Lforge/game/player/Player;)V","invokevirtual",284);}
case 284:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=287;continue;}
case 287:{f.Pc=53;continue;}
case 290:{f.Push(JValue.I(1));f.Pc=291;continue;}
case 291:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7995(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getStackDescription","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isBlank","(Ljava/lang/CharSequence;)Z","invokestatic",7);}
case 7:{f.Pc=f.Pop().Int!=0?11:10;continue;}
case 10:{return JStep.ReturnVoid;}
case 11:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",18);}
case 18:{f.Locals[1]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",27);}
case 27:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",30);}
case 30:{f.StackOp("pop");f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?104:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",42);}
case 42:{f.Locals[2]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"com/google/common/collect/Iterables","isEmpty","(Ljava/lang/Iterable;)Z","invokestatic",47);}
case 47:{f.Pc=f.Pop().Int!=0?104:50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String(" - Targeting ")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",57);}
case 57:{f.StackOp("pop");f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",64);}
case 64:{f.Locals[3]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",71);}
case 71:{f.Pc=f.Pop().Int==0?104:74;continue;}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",80);}
case 80:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=83;continue;}
case 83:{f.Locals[4]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[4]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",91);}
case 91:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",94);}
case 94:{f.Push(JValue.R(rt.String(" ")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",100);}
case 100:{f.StackOp("pop");f.Pc=101;continue;}
case 101:{f.Pc=65;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",109);}
case 109:{return rt.Call(f,"forge/game/spellability/SpellAbility","setStackDescription","(Ljava/lang/String;)V","invokevirtual",112);}
case 112:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C232{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ChooseCardEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3135,"forge/game/ability/effects/ChooseCardEffect","<init>","()V",1,1,1,new JHandler[]{},M3135));
c.Add(new JMethod(3136,"forge/game/ability/effects/ChooseCardEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,6,3,new JHandler[]{},M3136));
c.Add(new JMethod(3137,"forge/game/ability/effects/ChooseCardEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,26,12,new JHandler[]{},M3137));
c.Add(new JMethod(3138,"forge/game/ability/effects/ChooseCardEffect","lambda$resolve$0","(ILforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M3138));
}

internal static JStep M3135(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3136(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Amount")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?34:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",21);}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("Amount")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",27);}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",31);}
case 31:{f.Pc=35;continue;}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{f.Locals[3]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/ability/effects/ChooseCardEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",40);}
case 40:{return rt.Call(f,"forge/game/player/PlayerCollection","isEmpty","()Z","invokevirtual",43);}
case 43:{f.Locals[4]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{f.Pc=f.Pop().Int==0?56:51;continue;}
case 51:{f.Push(JValue.R(rt.String("You")));f.Pc=53;continue;}
case 53:{f.Pc=63;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/ability/effects/ChooseCardEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",60);}
case 60:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",63);}
case 63:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",66);}
case 66:{f.Push(JValue.R(rt.String(" ")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",71);}
case 71:{f.StackOp("pop");f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("Mandatory")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int==0?112:81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{f.Pc=f.Pop().Int!=0?103:87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/ability/effects/ChooseCardEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",91);}
case 91:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",94);}
case 94:{f.Push(JValue.I(1));f.Pc=95;continue;}
case 95:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?103:98;continue;}
case 98:{f.Push(JValue.R(rt.String("chooses ")));f.Pc=100;continue;}
case 100:{f.Pc=105;continue;}
case 103:{f.Push(JValue.R(rt.String("choose ")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",108);}
case 108:{f.StackOp("pop");f.Pc=109;continue;}
case 109:{f.Pc=119;continue;}
case 112:{f.Push(f.Locals[2]);f.Pc=113;continue;}
case 113:{f.Push(JValue.R(rt.String("may choose ")));f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",118);}
case 118:{f.StackOp("pop");f.Pc=119;continue;}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{f.Push(JValue.R(rt.String("ChoiceDesc")));f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("card")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",127);}
case 127:{f.Locals[5]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[5]);f.Pc=131;continue;}
case 131:{f.Push(JValue.R(rt.String("card")));f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",136);}
case 136:{f.Pc=f.Pop().Int!=0?158:139;continue;}
case 139:{f.Push(f.Locals[5]);f.Pc=141;continue;}
case 141:{f.Push(JValue.R(rt.String("control")));f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",146);}
case 146:{f.Pc=f.Pop().Int!=0?158:149;continue;}
case 149:{f.Push(f.Locals[5]);f.Pc=151;continue;}
case 151:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardEffect:3136:151:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",156);}
case 156:{f.Locals[5]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[2]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[3]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[5]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",165);}
case 165:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",168);}
case 168:{f.StackOp("pop");f.Pc=169;continue;}
case 169:{f.Push(f.Locals[1]);f.Pc=170;continue;}
case 170:{f.Push(JValue.R(rt.String("FromDesc")));f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",175);}
case 175:{f.Pc=f.Pop().Int==0?197:178;continue;}
case 178:{f.Push(f.Locals[2]);f.Pc=179;continue;}
case 179:{f.Push(JValue.R(rt.String(" from ")));f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",184);}
case 184:{f.Push(f.Locals[1]);f.Pc=185;continue;}
case 185:{f.Push(JValue.R(rt.String("FromDesc")));f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",190);}
case 190:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",193);}
case 193:{f.StackOp("pop");f.Pc=194;continue;}
case 194:{f.Pc=227;continue;}
case 197:{f.Push(f.Locals[1]);f.Pc=198;continue;}
case 198:{f.Push(JValue.R(rt.String("ChoiceZone")));f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",203);}
case 203:{f.Pc=f.Pop().Int==0?227:206;continue;}
case 206:{f.Push(f.Locals[1]);f.Pc=207;continue;}
case 207:{f.Push(JValue.R(rt.String("ChoiceZone")));f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",212);}
case 212:{f.Push(JValue.R(rt.String("Hand")));f.Pc=214;continue;}
case 214:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",217);}
case 217:{f.Pc=f.Pop().Int==0?227:220;continue;}
case 220:{f.Push(f.Locals[2]);f.Pc=221;continue;}
case 221:{f.Push(JValue.R(rt.String(" in their hand")));f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",226);}
case 226:{f.StackOp("pop");f.Pc=227;continue;}
case 227:{f.Push(f.Locals[2]);f.Pc=228;continue;}
case 228:{f.Push(JValue.R(rt.String(".")));f.Pc=230;continue;}
case 230:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",233);}
case 233:{f.StackOp("pop");f.Pc=234;continue;}
case 234:{f.Push(f.Locals[2]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",238);}
case 238:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3137(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",23);}
case 23:{f.Locals[5]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/ability/effects/ChooseCardEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",29);}
case 29:{f.Locals[6]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.NewArray("Lforge/game/zone/ZoneType;",f.Pop().Int)));f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",44);}
case 44:{f.Locals[7]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("ChoiceZone")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int==0?66:55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("ChoiceZone")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",61);}
case 61:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",64);}
case 64:{f.Locals[7]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("AllCards")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?83:75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/Game","getCardsInGame","()Lforge/game/card/CardCollectionView;","invokevirtual",80);}
case 80:{f.Pc=90;continue;}
case 83:{f.Push(f.Locals[4]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[7]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",90);}
case 90:{f.Locals[8]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("Choices")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?117:101;continue;}
case 101:{f.Push(f.Locals[8]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String("Choices")));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",109);}
case 109:{f.Push(f.Locals[3]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[2]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",115);}
case 115:{f.Locals[8]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("DefinedCards")));f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",123);}
case 123:{f.Pc=f.Pop().Int==0?139:126;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{f.Push(JValue.R(rt.String("DefinedCards")));f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",133);}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",137);}
case 137:{f.Locals[8]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[1]);f.Pc=140;continue;}
case 140:{f.Push(JValue.R(rt.String("IncludeSpellsOnStack")));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",145);}
case 145:{f.Pc=f.Pop().Int==0?187:148;continue;}
case 148:{f.Push(f.Locals[4]);f.Pc=150;continue;}
case 150:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",156);}
case 156:{f.Locals[9]=f.Pop();f.Pc=158;continue;}
case 158:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=161;continue;}
case 161:{f.StackOp("dup");f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",165);}
case 165:{f.Locals[10]=f.Pop();f.Pc=167;continue;}
case 167:{f.Push(f.Locals[10]);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[9]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",174);}
case 174:{f.StackOp("pop");f.Pc=175;continue;}
case 175:{f.Push(f.Locals[10]);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[8]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",182);}
case 182:{f.StackOp("pop");f.Pc=183;continue;}
case 183:{f.Push(f.Locals[10]);f.Pc=185;continue;}
case 185:{f.Locals[8]=f.Pop();f.Pc=187;continue;}
case 187:{f.Push(f.Locals[1]);f.Pc=188;continue;}
case 188:{f.Push(JValue.R(rt.String("Amount")));f.Pc=190;continue;}
case 190:{f.Push(JValue.R(rt.String("1")));f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",195);}
case 195:{f.Locals[9]=f.Pop();f.Pc=197;continue;}
case 197:{f.Push(f.Locals[9]);f.Pc=199;continue;}
case 199:{f.Push(JValue.R(rt.String("Random")));f.Pc=201;continue;}
case 201:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",204);}
case 204:{f.Pc=f.Pop().Int==0?223:207;continue;}
case 207:{f.Push(JValue.I(0));f.Pc=208;continue;}
case 208:{f.Push(f.Locals[8]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",215);}
case 215:{return rt.Call(f,"forge/util/Aggregates","randomInt","(II)I","invokestatic",218);}
case 218:{f.Locals[10]=f.Pop();f.Pc=220;continue;}
case 220:{f.Pc=232;continue;}
case 223:{f.Push(f.Locals[2]);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[9]);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[1]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",230);}
case 230:{f.Locals[10]=f.Pop();f.Pc=232;continue;}
case 232:{f.Push(f.Locals[1]);f.Pc=233;continue;}
case 233:{f.Push(JValue.R(rt.String("MinAmount")));f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",238);}
case 238:{f.Pc=f.Pop().Int==0?253:241;continue;}
case 241:{f.Push(f.Locals[1]);f.Pc=242;continue;}
case 242:{f.Push(JValue.R(rt.String("MinAmount")));f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",247);}
case 247:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",250);}
case 250:{f.Pc=255;continue;}
case 253:{f.Push(f.Locals[10]);f.Pc=255;continue;}
case 255:{f.Locals[11]=f.Pop();f.Pc=257;continue;}
case 257:{f.Push(f.Locals[10]);f.Pc=259;continue;}
case 259:{f.Pc=f.Pop().Int>0?269:262;continue;}
case 262:{f.Push(f.Locals[2]);f.Pc=263;continue;}
case 263:{f.Push(f.Locals[5]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/card/Card","setChosenCards","(Ljava/lang/Iterable;)V","invokevirtual",268);}
case 268:{return JStep.ReturnVoid;}
case 269:{f.Push(f.Locals[1]);f.Pc=270;continue;}
case 270:{f.Push(JValue.R(rt.String("RevealTitle")));f.Pc=272;continue;}
case 272:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",275);}
case 275:{f.Locals[12]=f.Pop();f.Pc=277;continue;}
case 277:{f.Push(f.Locals[6]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",282);}
case 282:{f.Locals[13]=f.Pop();f.Pc=284;continue;}
case 284:{f.Push(f.Locals[13]);f.Pc=286;continue;}
case 286:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",291);}
case 291:{f.Pc=f.Pop().Int==0?2188:294;continue;}
case 294:{f.Push(f.Locals[13]);f.Pc=296;continue;}
case 296:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",301);}
case 301:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=304;continue;}
case 304:{f.Locals[14]=f.Pop();f.Pc=306;continue;}
case 306:{f.Push(f.Locals[8]);f.Pc=308;continue;}
case 308:{f.Locals[15]=f.Pop();f.Pc=310;continue;}
case 310:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=313;continue;}
case 313:{f.StackOp("dup");f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",317);}
case 317:{f.Locals[16]=f.Pop();f.Pc=319;continue;}
case 319:{f.Push(f.Locals[14]);f.Pc=321;continue;}
case 321:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",324);}
case 324:{f.Pc=f.Pop().Int!=0?335:327;continue;}
case 327:{f.Push(f.Locals[1]);f.Pc=328;continue;}
case 328:{f.Push(f.Locals[14]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/ability/effects/ChooseCardEffect","getNewChooser","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/player/Player;","invokestatic",333);}
case 333:{f.Locals[14]=f.Pop();f.Pc=335;continue;}
case 335:{f.Push(f.Locals[1]);f.Pc=336;continue;}
case 336:{f.Push(JValue.R(rt.String("ControlledByPlayer")));f.Pc=338;continue;}
case 338:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",341);}
case 341:{f.Pc=f.Pop().Int==0?430:344;continue;}
case 344:{f.Push(f.Locals[1]);f.Pc=345;continue;}
case 345:{f.Push(JValue.R(rt.String("ControlledByPlayer")));f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",350);}
case 350:{f.Locals[17]=f.Pop();f.Pc=352;continue;}
case 352:{f.Push(f.Locals[17]);f.Pc=354;continue;}
case 354:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=356;continue;}
case 356:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",359);}
case 359:{f.Pc=f.Pop().Int==0?374:362;continue;}
case 362:{f.Push(f.Locals[15]);f.Pc=364;continue;}
case 364:{f.Push(f.Locals[14]);f.Pc=366;continue;}
case 366:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollection;","invokestatic",369);}
case 369:{f.Locals[15]=f.Pop();f.Pc=371;continue;}
case 371:{f.Pc=430;continue;}
case 374:{f.Push(f.Locals[17]);f.Pc=376;continue;}
case 376:{f.Push(JValue.R(rt.String("Left")));f.Pc=378;continue;}
case 378:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",381);}
case 381:{f.Pc=f.Pop().Int!=0?394:384;continue;}
case 384:{f.Push(f.Locals[17]);f.Pc=386;continue;}
case 386:{f.Push(JValue.R(rt.String("Right")));f.Pc=388;continue;}
case 388:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",391);}
case 391:{f.Pc=f.Pop().Int==0?416:394;continue;}
case 394:{f.Push(f.Locals[15]);f.Pc=396;continue;}
case 396:{f.Push(f.Locals[4]);f.Pc=398;continue;}
case 398:{f.Push(f.Locals[14]);f.Pc=400;continue;}
case 400:{f.Push(f.Locals[17]);f.Pc=402;continue;}
case 402:{return rt.Call(f,"forge/game/Direction","valueOf","(Ljava/lang/String;)Lforge/game/Direction;","invokestatic",405);}
case 405:{return rt.Call(f,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;Lforge/game/Direction;)Lforge/game/player/Player;","invokevirtual",408);}
case 408:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollection;","invokestatic",411);}
case 411:{f.Locals[15]=f.Pop();f.Pc=413;continue;}
case 413:{f.Pc=430;continue;}
case 416:{f.Push(f.Locals[15]);f.Pc=418;continue;}
case 418:{f.Push(f.Locals[2]);f.Pc=419;continue;}
case 419:{f.Push(f.Locals[17]);f.Pc=421;continue;}
case 421:{f.Push(f.Locals[1]);f.Pc=422;continue;}
case 422:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",425);}
case 425:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/util/collect/FCollectionView;)Lforge/game/card/CardCollection;","invokestatic",428);}
case 428:{f.Locals[15]=f.Pop();f.Pc=430;continue;}
case 430:{f.Push(JValue.I(1));f.Pc=431;continue;}
case 431:{f.Locals[17]=f.Pop();f.Pc=433;continue;}
case 433:{f.Push(f.Locals[1]);f.Pc=434;continue;}
case 434:{f.Push(JValue.R(rt.String("EachBasicType")));f.Pc=437;continue;}
case 437:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",440);}
case 440:{f.Pc=f.Pop().Int==0?559:443;continue;}
case 443:{return rt.Call(f,"forge/card/CardType","getBasicTypes","()Ljava/util/Collection;","invokestatic",446);}
case 446:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",451);}
case 451:{f.Locals[18]=f.Pop();f.Pc=453;continue;}
case 453:{f.Push(f.Locals[18]);f.Pc=455;continue;}
case 455:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",460);}
case 460:{f.Pc=f.Pop().Int==0?556:463;continue;}
case 463:{f.Push(f.Locals[18]);f.Pc=465;continue;}
case 465:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",470);}
case 470:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=473;continue;}
case 473:{f.Locals[19]=f.Pop();f.Pc=475;continue;}
case 475:{f.Push(f.Locals[15]);f.Pc=477;continue;}
case 477:{f.Push(f.Locals[19]);f.Pc=479;continue;}
case 479:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",482);}
case 482:{f.Locals[20]=f.Pop();f.Pc=484;continue;}
case 484:{f.Push(f.Locals[20]);f.Pc=486;continue;}
case 486:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",491);}
case 491:{f.Pc=f.Pop().Int!=0?553:494;continue;}
case 494:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",497);}
case 497:{f.Push(JValue.R(rt.String("lblChoose")));f.Pc=500;continue;}
case 500:{f.Push(JValue.I(0));f.Pc=501;continue;}
case 501:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=504;continue;}
case 504:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",507);}
case 507:{f.Push(JValue.I(1));f.Pc=508;continue;}
case 508:{f.Push(f.Locals[19]);f.Pc=510;continue;}
case 510:{return rt.Call(f,"forge/util/Lang","nounWithAmount","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",513);}
case 513:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardEffect:3137:513:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",518);}
case 518:{f.Locals[21]=f.Pop();f.Pc=520;continue;}
case 520:{f.Push(f.Locals[14]);f.Pc=522;continue;}
case 522:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",525);}
case 525:{f.Push(f.Locals[20]);f.Pc=527;continue;}
case 527:{f.Push(f.Locals[1]);f.Pc=528;continue;}
case 528:{f.Push(f.Locals[21]);f.Pc=530;continue;}
case 530:{f.Push(JValue.I(0));f.Pc=531;continue;}
case 531:{f.Push(JValue.R(null));f.Pc=532;continue;}
case 532:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",535);}
case 535:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=538;continue;}
case 538:{f.Locals[22]=f.Pop();f.Pc=540;continue;}
case 540:{f.Push(f.Locals[22]);f.Pc=542;continue;}
case 542:{f.Pc=f.Pop().Reference==null?553:545;continue;}
case 545:{f.Push(f.Locals[16]);f.Pc=547;continue;}
case 547:{f.Push(f.Locals[22]);f.Pc=549;continue;}
case 549:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",552);}
case 552:{f.StackOp("pop");f.Pc=553;continue;}
case 553:{f.Pc=453;continue;}
case 556:{f.Pc=2083;continue;}
case 559:{f.Push(f.Locals[1]);f.Pc=560;continue;}
case 560:{f.Push(JValue.R(rt.String("ChooseEach")));f.Pc=563;continue;}
case 563:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",566);}
case 566:{f.Pc=f.Pop().Int==0?737:569;continue;}
case 569:{f.Push(f.Locals[1]);f.Pc=570;continue;}
case 570:{f.Push(JValue.R(rt.String("ChooseEach")));f.Pc=573;continue;}
case 573:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",576);}
case 576:{f.Locals[18]=f.Pop();f.Pc=578;continue;}
case 578:{f.Push(f.Locals[18]);f.Pc=580;continue;}
case 580:{f.Push(JValue.R(rt.String("Party")));f.Pc=583;continue;}
case 583:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",586);}
case 586:{f.Pc=f.Pop().Int==0?595:589;continue;}
case 589:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","PARTY_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","PARTY_TYPES","Ljava/util/Set;"));f.Pc=592;continue;}
case 592:{f.Pc=606;continue;}
case 595:{f.Push(f.Locals[18]);f.Pc=597;continue;}
case 597:{f.Push(JValue.R(rt.String(" & ")));f.Pc=600;continue;}
case 600:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",603);}
case 603:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",606);}
case 606:{f.Locals[19]=f.Pop();f.Pc=608;continue;}
case 608:{f.Push(f.Locals[19]);f.Pc=610;continue;}
case 610:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",615);}
case 615:{f.Locals[20]=f.Pop();f.Pc=617;continue;}
case 617:{f.Push(f.Locals[20]);f.Pc=619;continue;}
case 619:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",624);}
case 624:{f.Pc=f.Pop().Int==0?734:627;continue;}
case 627:{f.Push(f.Locals[20]);f.Pc=629;continue;}
case 629:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",634);}
case 634:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=637;continue;}
case 637:{f.Locals[21]=f.Pop();f.Pc=639;continue;}
case 639:{f.Push(f.Locals[15]);f.Pc=641;continue;}
case 641:{f.Push(f.Locals[21]);f.Pc=643;continue;}
case 643:{return rt.Call(f,"forge/game/card/CardPredicates","isType","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",646);}
case 646:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",649);}
case 649:{f.Locals[22]=f.Pop();f.Pc=651;continue;}
case 651:{f.Push(f.Locals[22]);f.Pc=653;continue;}
case 653:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",656);}
case 656:{f.Pc=f.Pop().Int!=0?731:659;continue;}
case 659:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",662);}
case 662:{f.Push(JValue.R(rt.String("lblChoose")));f.Pc=665;continue;}
case 665:{f.Push(JValue.I(0));f.Pc=666;continue;}
case 666:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=669;continue;}
case 669:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",672);}
case 672:{f.Push(JValue.I(1));f.Pc=673;continue;}
case 673:{f.Push(f.Locals[21]);f.Pc=675;continue;}
case 675:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",678);}
case 678:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardEffect:3137:678:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",683);}
case 683:{f.Locals[23]=f.Pop();f.Pc=685;continue;}
case 685:{f.Push(f.Locals[14]);f.Pc=687;continue;}
case 687:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",690);}
case 690:{f.Push(f.Locals[22]);f.Pc=692;continue;}
case 692:{f.Push(f.Locals[1]);f.Pc=693;continue;}
case 693:{f.Push(f.Locals[23]);f.Pc=695;continue;}
case 695:{f.Push(f.Locals[1]);f.Pc=696;continue;}
case 696:{f.Push(JValue.R(rt.String("Mandatory")));f.Pc=698;continue;}
case 698:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",701);}
case 701:{f.Pc=f.Pop().Int!=0?708:704;continue;}
case 704:{f.Push(JValue.I(1));f.Pc=705;continue;}
case 705:{f.Pc=709;continue;}
case 708:{f.Push(JValue.I(0));f.Pc=709;continue;}
case 709:{f.Push(JValue.R(null));f.Pc=710;continue;}
case 710:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",713);}
case 713:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=716;continue;}
case 716:{f.Locals[24]=f.Pop();f.Pc=718;continue;}
case 718:{f.Push(f.Locals[24]);f.Pc=720;continue;}
case 720:{f.Pc=f.Pop().Reference==null?731:723;continue;}
case 723:{f.Push(f.Locals[16]);f.Pc=725;continue;}
case 725:{f.Push(f.Locals[24]);f.Pc=727;continue;}
case 727:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",730);}
case 730:{f.StackOp("pop");f.Pc=731;continue;}
case 731:{f.Pc=617;continue;}
case 734:{f.Pc=2083;continue;}
case 737:{f.Push(f.Locals[1]);f.Pc=738;continue;}
case 738:{f.Push(JValue.R(rt.String("WithTotalPower")));f.Pc=741;continue;}
case 741:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",744);}
case 744:{f.Pc=f.Pop().Int==0?1034:747;continue;}
case 747:{f.Push(f.Locals[2]);f.Pc=748;continue;}
case 748:{f.Push(f.Locals[1]);f.Pc=749;continue;}
case 749:{f.Push(JValue.R(rt.String("WithTotalPower")));f.Pc=752;continue;}
case 752:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",755);}
case 755:{f.Push(f.Locals[1]);f.Pc=756;continue;}
case 756:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",759);}
case 759:{f.Locals[18]=f.Pop();f.Pc=761;continue;}
case 761:{f.Push(f.Locals[14]);f.Pc=763;continue;}
case 763:{return rt.Call(f,"forge/game/player/Player","getCreaturesInPlay","()Lforge/game/card/CardCollection;","invokevirtual",766);}
case 766:{f.Push(JValue.I(-1));f.Pc=767;continue;}
case 767:{return rt.Call(f,"forge/game/card/CardLists","filterLEPower","(Ljava/lang/Iterable;I)Lforge/game/card/CardCollection;","invokestatic",770);}
case 770:{f.Locals[19]=f.Pop();f.Pc=772;continue;}
case 772:{f.Push(f.Locals[19]);f.Pc=774;continue;}
case 774:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardEffect:3137:774:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",779);}
case 779:{return rt.Call(f,"forge/util/Aggregates","sum","(Ljava/lang/Iterable;Ljava/util/function/Function;)I","invokestatic",782);}
case 782:{f.Locals[20]=f.Pop();f.Pc=784;continue;}
case 784:{f.Push(f.Locals[14]);f.Pc=786;continue;}
case 786:{return rt.Call(f,"forge/game/player/Player","getCreaturesInPlay","()Lforge/game/card/CardCollection;","invokevirtual",789);}
case 789:{f.Push(f.Locals[18]);f.Pc=791;continue;}
case 791:{f.Push(f.Locals[20]);f.Pc=793;continue;}
case 793:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=794;continue;}
case 794:{return rt.Call(f,"forge/game/card/CardLists","filterLEPower","(Ljava/lang/Iterable;I)Lforge/game/card/CardCollection;","invokestatic",797);}
case 797:{f.Locals[21]=f.Pop();f.Pc=799;continue;}
case 799:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=802;continue;}
case 802:{f.StackOp("dup");f.Pc=803;continue;}
case 803:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",806);}
case 806:{f.Locals[22]=f.Pop();f.Pc=808;continue;}
case 808:{f.Push(JValue.I(0));f.Pc=809;continue;}
case 809:{f.Locals[23]=f.Pop();f.Pc=811;continue;}
case 811:{f.Push(f.Locals[21]);f.Pc=813;continue;}
case 813:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",816);}
case 816:{f.Pc=f.Pop().Int!=0?1023:819;continue;}
case 819:{f.Push(f.Locals[14]);f.Pc=821;continue;}
case 821:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",824);}
case 824:{f.Push(f.Locals[21]);f.Pc=826;continue;}
case 826:{f.Push(f.Locals[1]);f.Pc=827;continue;}
case 827:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",830);}
case 830:{f.Push(JValue.R(rt.String("lblSelectCreatureWithTotalPowerLessOrEqualTo")));f.Pc=833;continue;}
case 833:{f.Push(JValue.I(1));f.Pc=834;continue;}
case 834:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=837;continue;}
case 837:{f.StackOp("dup");f.Pc=838;continue;}
case 838:{f.Push(JValue.I(0));f.Pc=839;continue;}
case 839:{f.Push(f.Locals[18]);f.Pc=841;continue;}
case 841:{f.Push(f.Locals[23]);f.Pc=843;continue;}
case 843:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=844;continue;}
case 844:{f.Push(f.Locals[20]);f.Pc=846;continue;}
case 846:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=847;continue;}
case 847:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",850);}
case 850:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=851;continue;}
case 851:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",854);}
case 854:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",857);}
case 857:{f.Push(JValue.R(rt.String("lblSelected")));f.Pc=860;continue;}
case 860:{f.Push(JValue.I(0));f.Pc=861;continue;}
case 861:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=864;continue;}
case 864:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",867);}
case 867:{f.Push(f.Locals[22]);f.Pc=869;continue;}
case 869:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",872);}
case 872:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",875);}
case 875:{f.Push(JValue.R(rt.String("lblTotalPowerNum")));f.Pc=878;continue;}
case 878:{f.Push(JValue.I(1));f.Pc=879;continue;}
case 879:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=882;continue;}
case 882:{f.StackOp("dup");f.Pc=883;continue;}
case 883:{f.Push(JValue.I(0));f.Pc=884;continue;}
case 884:{f.Push(f.Locals[23]);f.Pc=886;continue;}
case 886:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",889);}
case 889:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=890;continue;}
case 890:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",893);}
case 893:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardEffect:3137:893:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",898);}
case 898:{f.Push(f.Locals[23]);f.Pc=900;continue;}
case 900:{f.Push(f.Locals[18]);f.Pc=902;continue;}
case 902:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?909:905;continue;}
case 905:{f.Push(JValue.I(1));f.Pc=906;continue;}
case 906:{f.Pc=910;continue;}
case 909:{f.Push(JValue.I(0));f.Pc=910;continue;}
case 910:{f.Push(JValue.R(null));f.Pc=911;continue;}
case 911:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",914);}
case 914:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=917;continue;}
case 917:{f.Locals[24]=f.Pop();f.Pc=919;continue;}
case 919:{f.Push(f.Locals[24]);f.Pc=921;continue;}
case 921:{f.Pc=f.Pop().Reference!=null?956:924;continue;}
case 924:{f.Push(f.Locals[14]);f.Pc=926;continue;}
case 926:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",929);}
case 929:{f.Push(f.Locals[1]);f.Pc=930;continue;}
case 930:{if(!rt.StaticReady(f,"forge/game/player/PlayerActionConfirmMode","OptionalChoose","Lforge/game/player/PlayerActionConfirmMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerActionConfirmMode","OptionalChoose","Lforge/game/player/PlayerActionConfirmMode;"));f.Pc=933;continue;}
case 933:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",936);}
case 936:{f.Push(JValue.R(rt.String("lblCancelChooseConfirm")));f.Pc=939;continue;}
case 939:{f.Push(JValue.I(0));f.Pc=940;continue;}
case 940:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=943;continue;}
case 943:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",946);}
case 946:{f.Push(JValue.R(null));f.Pc=947;continue;}
case 947:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",950);}
case 950:{f.Pc=f.Pop().Int==0?1020:953;continue;}
case 953:{f.Pc=1023;continue;}
case 956:{f.Push(f.Locals[23]);f.Pc=958;continue;}
case 958:{f.Push(f.Locals[24]);f.Pc=960;continue;}
case 960:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",963);}
case 963:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=964;continue;}
case 964:{f.Locals[23]=f.Pop();f.Pc=966;continue;}
case 966:{f.Push(f.Locals[22]);f.Pc=968;continue;}
case 968:{f.Push(f.Locals[24]);f.Pc=970;continue;}
case 970:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",973);}
case 973:{f.StackOp("pop");f.Pc=974;continue;}
case 974:{f.Push(f.Locals[19]);f.Pc=976;continue;}
case 976:{f.Push(f.Locals[24]);f.Pc=978;continue;}
case 978:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",981);}
case 981:{f.StackOp("pop");f.Pc=982;continue;}
case 982:{f.Push(f.Locals[19]);f.Pc=984;continue;}
case 984:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardEffect:3137:984:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",989);}
case 989:{return rt.Call(f,"forge/util/Aggregates","sum","(Ljava/lang/Iterable;Ljava/util/function/Function;)I","invokestatic",992);}
case 992:{f.Locals[20]=f.Pop();f.Pc=994;continue;}
case 994:{f.Push(f.Locals[14]);f.Pc=996;continue;}
case 996:{return rt.Call(f,"forge/game/player/Player","getCreaturesInPlay","()Lforge/game/card/CardCollection;","invokevirtual",999);}
case 999:{f.Push(f.Locals[18]);f.Pc=1001;continue;}
case 1001:{f.Push(f.Locals[23]);f.Pc=1003;continue;}
case 1003:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=1004;continue;}
case 1004:{f.Push(f.Locals[20]);f.Pc=1006;continue;}
case 1006:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=1007;continue;}
case 1007:{return rt.Call(f,"forge/game/card/CardLists","filterLEPower","(Ljava/lang/Iterable;I)Lforge/game/card/CardCollection;","invokestatic",1010);}
case 1010:{f.Locals[21]=f.Pop();f.Pc=1012;continue;}
case 1012:{f.Push(f.Locals[21]);f.Pc=1014;continue;}
case 1014:{f.Push(f.Locals[22]);f.Pc=1016;continue;}
case 1016:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",1019);}
case 1019:{f.StackOp("pop");f.Pc=1020;continue;}
case 1020:{f.Pc=811;continue;}
case 1023:{f.Push(f.Locals[16]);f.Pc=1025;continue;}
case 1025:{f.Push(f.Locals[22]);f.Pc=1027;continue;}
case 1027:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1030);}
case 1030:{f.StackOp("pop");f.Pc=1031;continue;}
case 1031:{f.Pc=2083;continue;}
case 1034:{f.Push(f.Locals[1]);f.Pc=1035;continue;}
case 1035:{f.Push(JValue.R(rt.String("WithDifferentPowers")));f.Pc=1038;continue;}
case 1038:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1041);}
case 1041:{f.Pc=f.Pop().Int==0?1255:1044;continue;}
case 1044:{f.Push(f.Locals[1]);f.Pc=1045;continue;}
case 1045:{f.Push(JValue.R(rt.String("Choices")));f.Pc=1047;continue;}
case 1047:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1050);}
case 1050:{f.Locals[18]=f.Pop();f.Pc=1052;continue;}
case 1052:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1055;continue;}
case 1055:{f.StackOp("dup");f.Pc=1056;continue;}
case 1056:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",1059);}
case 1059:{f.Locals[19]=f.Pop();f.Pc=1061;continue;}
case 1061:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1064);}
case 1064:{f.Push(JValue.R(rt.String("lblChooseCreature")));f.Pc=1067;continue;}
case 1067:{f.Push(JValue.I(0));f.Pc=1068;continue;}
case 1068:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1071;continue;}
case 1071:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1074);}
case 1074:{f.Locals[20]=f.Pop();f.Pc=1076;continue;}
case 1076:{f.Push(JValue.R(null));f.Pc=1077;continue;}
case 1077:{f.Locals[21]=f.Pop();f.Pc=1079;continue;}
case 1079:{f.Push(f.Locals[15]);f.Pc=1081;continue;}
case 1081:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",1086);}
case 1086:{f.Pc=f.Pop().Int!=0?1231:1089;continue;}
case 1089:{f.Push(f.Locals[19]);f.Pc=1091;continue;}
case 1091:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",1094);}
case 1094:{f.Push(f.Locals[10]);f.Pc=1096;continue;}
case 1096:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1231:1099;continue;}
case 1099:{f.Push(f.Locals[19]);f.Pc=1101;continue;}
case 1101:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",1104);}
case 1104:{f.Push(f.Locals[11]);f.Pc=1106;continue;}
case 1106:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?1113:1109;continue;}
case 1109:{f.Push(JValue.I(1));f.Pc=1110;continue;}
case 1110:{f.Pc=1114;continue;}
case 1113:{f.Push(JValue.I(0));f.Pc=1114;continue;}
case 1114:{f.Locals[22]=f.Pop();f.Pc=1116;continue;}
case 1116:{f.Push(f.Locals[15]);f.Pc=1118;continue;}
case 1118:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1121;continue;}
case 1121:{f.Locals[23]=f.Pop();f.Pc=1123;continue;}
case 1123:{f.Push(f.Locals[19]);f.Pc=1125;continue;}
case 1125:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1128);}
case 1128:{f.Pc=f.Pop().Int!=0?1146:1131;continue;}
case 1131:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1134);}
case 1134:{f.Push(JValue.R(rt.String("lblChooseCreatureWithDiffPower")));f.Pc=1137;continue;}
case 1137:{f.Push(JValue.I(0));f.Pc=1138;continue;}
case 1138:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1141;continue;}
case 1141:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1144);}
case 1144:{f.Locals[20]=f.Pop();f.Pc=1146;continue;}
case 1146:{f.Push(f.Locals[14]);f.Pc=1148;continue;}
case 1148:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1151);}
case 1151:{f.Push(f.Locals[23]);f.Pc=1153;continue;}
case 1153:{f.Push(f.Locals[1]);f.Pc=1154;continue;}
case 1154:{f.Push(f.Locals[20]);f.Pc=1156;continue;}
case 1156:{f.Push(f.Locals[22]);f.Pc=1158;continue;}
case 1158:{f.Push(JValue.R(null));f.Pc=1159;continue;}
case 1159:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",1162);}
case 1162:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1165;continue;}
case 1165:{f.Locals[21]=f.Pop();f.Pc=1167;continue;}
case 1167:{f.Push(f.Locals[21]);f.Pc=1169;continue;}
case 1169:{f.Pc=f.Pop().Reference!=null?1175:1172;continue;}
case 1172:{f.Pc=1231;continue;}
case 1175:{f.Push(f.Locals[19]);f.Pc=1177;continue;}
case 1177:{f.Push(f.Locals[21]);f.Pc=1179;continue;}
case 1179:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",1182);}
case 1182:{f.StackOp("pop");f.Pc=1183;continue;}
case 1183:{f.Push(f.Locals[18]);f.Pc=1185;continue;}
case 1185:{f.Push(f.Locals[18]);f.Pc=1187;continue;}
case 1187:{f.Push(JValue.R(rt.String(".")));f.Pc=1189;continue;}
case 1189:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",1192);}
case 1192:{f.Pc=f.Pop().Int==0?1201:1195;continue;}
case 1195:{f.Push(JValue.R(rt.String("+powerNE")));f.Pc=1198;continue;}
case 1198:{f.Pc=1204;continue;}
case 1201:{f.Push(JValue.R(rt.String(".powerNE")));f.Pc=1204;continue;}
case 1204:{f.Push(f.Locals[21]);f.Pc=1206;continue;}
case 1206:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",1209);}
case 1209:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardEffect:3137:1209:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;",1214);}
case 1214:{f.Locals[18]=f.Pop();f.Pc=1216;continue;}
case 1216:{f.Push(f.Locals[15]);f.Pc=1218;continue;}
case 1218:{f.Push(f.Locals[18]);f.Pc=1220;continue;}
case 1220:{f.Push(f.Locals[3]);f.Pc=1221;continue;}
case 1221:{f.Push(f.Locals[2]);f.Pc=1222;continue;}
case 1222:{f.Push(f.Locals[1]);f.Pc=1223;continue;}
case 1223:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1226);}
case 1226:{f.Locals[15]=f.Pop();f.Pc=1228;continue;}
case 1228:{f.Pc=1079;continue;}
case 1231:{f.Push(f.Locals[21]);f.Pc=1233;continue;}
case 1233:{f.Pc=f.Pop().Reference==null?1244:1236;continue;}
case 1236:{f.Push(f.Locals[19]);f.Pc=1238;continue;}
case 1238:{f.Push(f.Locals[21]);f.Pc=1240;continue;}
case 1240:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",1243);}
case 1243:{f.StackOp("pop");f.Pc=1244;continue;}
case 1244:{f.Push(f.Locals[16]);f.Pc=1246;continue;}
case 1246:{f.Push(f.Locals[19]);f.Pc=1248;continue;}
case 1248:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1251);}
case 1251:{f.StackOp("pop");f.Pc=1252;continue;}
case 1252:{f.Pc=2083;continue;}
case 1255:{f.Push(f.Locals[1]);f.Pc=1256;continue;}
case 1256:{f.Push(JValue.R(rt.String("WithDifferentManaValues")));f.Pc=1259;continue;}
case 1259:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1262);}
case 1262:{f.Pc=f.Pop().Int!=0?1275:1265;continue;}
case 1265:{f.Push(f.Locals[1]);f.Pc=1266;continue;}
case 1266:{f.Push(JValue.R(rt.String("WithDifferentCMC")));f.Pc=1269;continue;}
case 1269:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1272);}
case 1272:{f.Pc=f.Pop().Int==0?1451:1275;continue;}
case 1275:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1278;continue;}
case 1278:{f.StackOp("dup");f.Pc=1279;continue;}
case 1279:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",1282);}
case 1282:{f.Locals[18]=f.Pop();f.Pc=1284;continue;}
case 1284:{f.Push(f.Locals[1]);f.Pc=1285;continue;}
case 1285:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=1288;continue;}
case 1288:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1291);}
case 1291:{f.Pc=f.Pop().Int==0?1304:1294;continue;}
case 1294:{f.Push(f.Locals[1]);f.Pc=1295;continue;}
case 1295:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=1298;continue;}
case 1298:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1301);}
case 1301:{f.Pc=1317;continue;}
case 1304:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1307);}
case 1307:{f.Push(JValue.R(rt.String("lblChooseCreature")));f.Pc=1310;continue;}
case 1310:{f.Push(JValue.I(0));f.Pc=1311;continue;}
case 1311:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1314;continue;}
case 1314:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1317);}
case 1317:{f.Locals[19]=f.Pop();f.Pc=1319;continue;}
case 1319:{f.Push(f.Locals[15]);f.Pc=1321;continue;}
case 1321:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",1326);}
case 1326:{f.Pc=f.Pop().Int!=0?1440:1329;continue;}
case 1329:{f.Push(f.Locals[18]);f.Pc=1331;continue;}
case 1331:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",1334);}
case 1334:{f.Push(f.Locals[10]);f.Pc=1336;continue;}
case 1336:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1440:1339;continue;}
case 1339:{f.Push(f.Locals[18]);f.Pc=1341;continue;}
case 1341:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",1344);}
case 1344:{f.Push(f.Locals[11]);f.Pc=1346;continue;}
case 1346:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?1353:1349;continue;}
case 1349:{f.Push(JValue.I(1));f.Pc=1350;continue;}
case 1350:{f.Pc=1354;continue;}
case 1353:{f.Push(JValue.I(0));f.Pc=1354;continue;}
case 1354:{f.Locals[20]=f.Pop();f.Pc=1356;continue;}
case 1356:{f.Push(f.Locals[18]);f.Pc=1358;continue;}
case 1358:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1361);}
case 1361:{f.Pc=f.Pop().Int!=0?1379:1364;continue;}
case 1364:{f.Push(f.Locals[1]);f.Pc=1365;continue;}
case 1365:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=1368;continue;}
case 1368:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1371);}
case 1371:{f.Pc=f.Pop().Int!=0?1379:1374;continue;}
case 1374:{f.Push(JValue.R(rt.String("Choose a creature with a different mana value")));f.Pc=1377;continue;}
case 1377:{f.Locals[19]=f.Pop();f.Pc=1379;continue;}
case 1379:{f.Push(f.Locals[14]);f.Pc=1381;continue;}
case 1381:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1384);}
case 1384:{f.Push(f.Locals[15]);f.Pc=1386;continue;}
case 1386:{f.Push(f.Locals[1]);f.Pc=1387;continue;}
case 1387:{f.Push(f.Locals[19]);f.Pc=1389;continue;}
case 1389:{f.Push(f.Locals[20]);f.Pc=1391;continue;}
case 1391:{f.Push(JValue.R(null));f.Pc=1392;continue;}
case 1392:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",1395);}
case 1395:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1398;continue;}
case 1398:{f.Locals[21]=f.Pop();f.Pc=1400;continue;}
case 1400:{f.Push(f.Locals[21]);f.Pc=1402;continue;}
case 1402:{f.Pc=f.Pop().Reference!=null?1408:1405;continue;}
case 1405:{f.Pc=1440;continue;}
case 1408:{f.Push(f.Locals[18]);f.Pc=1410;continue;}
case 1410:{f.Push(f.Locals[21]);f.Pc=1412;continue;}
case 1412:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",1415);}
case 1415:{f.StackOp("pop");f.Pc=1416;continue;}
case 1416:{f.Push(f.Locals[21]);f.Pc=1418;continue;}
case 1418:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",1421);}
case 1421:{f.Locals[22]=f.Pop();f.Pc=1423;continue;}
case 1423:{f.Push(f.Locals[15]);f.Pc=1425;continue;}
case 1425:{f.Push(f.Locals[22]);f.Pc=1427;continue;}
case 1427:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardEffect:3137:1427:java/lang/invoke/LambdaMetafactory.metafactory","(I)Ljava/util/function/Predicate;",1432);}
case 1432:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",1435);}
case 1435:{f.Locals[15]=f.Pop();f.Pc=1437;continue;}
case 1437:{f.Pc=1319;continue;}
case 1440:{f.Push(f.Locals[16]);f.Pc=1442;continue;}
case 1442:{f.Push(f.Locals[18]);f.Pc=1444;continue;}
case 1444:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1447);}
case 1447:{f.StackOp("pop");f.Pc=1448;continue;}
case 1448:{f.Pc=2083;continue;}
case 1451:{f.Push(f.Locals[1]);f.Pc=1452;continue;}
case 1452:{f.Push(JValue.R(rt.String("EachDifferentPower")));f.Pc=1455;continue;}
case 1455:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1458);}
case 1458:{f.Pc=f.Pop().Int==0?1710:1461;continue;}
case 1461:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=1464;continue;}
case 1464:{f.StackOp("dup");f.Pc=1465;continue;}
case 1465:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",1468);}
case 1468:{f.Locals[18]=f.Pop();f.Pc=1470;continue;}
case 1470:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1473;continue;}
case 1473:{f.StackOp("dup");f.Pc=1474;continue;}
case 1474:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",1477);}
case 1477:{f.Locals[19]=f.Pop();f.Pc=1479;continue;}
case 1479:{f.Push(f.Locals[15]);f.Pc=1481;continue;}
case 1481:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",1486);}
case 1486:{f.Locals[20]=f.Pop();f.Pc=1488;continue;}
case 1488:{f.Push(f.Locals[20]);f.Pc=1490;continue;}
case 1490:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1495);}
case 1495:{f.Pc=f.Pop().Int==0?1551:1498;continue;}
case 1498:{f.Push(f.Locals[20]);f.Pc=1500;continue;}
case 1500:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1505);}
case 1505:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1508;continue;}
case 1508:{f.Locals[21]=f.Pop();f.Pc=1510;continue;}
case 1510:{f.Push(f.Locals[21]);f.Pc=1512;continue;}
case 1512:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",1515);}
case 1515:{f.Locals[22]=f.Pop();f.Pc=1517;continue;}
case 1517:{f.Push(f.Locals[18]);f.Pc=1519;continue;}
case 1519:{f.Push(f.Locals[22]);f.Pc=1521;continue;}
case 1521:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1524);}
case 1524:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",1529);}
case 1529:{f.Pc=f.Pop().Int!=0?1548:1532;continue;}
case 1532:{f.Push(f.Locals[18]);f.Pc=1534;continue;}
case 1534:{f.Push(f.Locals[21]);f.Pc=1536;continue;}
case 1536:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",1539);}
case 1539:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1542);}
case 1542:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1547);}
case 1547:{f.StackOp("pop");f.Pc=1548;continue;}
case 1548:{f.Pc=1488;continue;}
case 1551:{f.Push(f.Locals[18]);f.Pc=1553;continue;}
case 1553:{return rt.Call(f,"java/util/Collections","sort","(Ljava/util/List;)V","invokestatic",1556);}
case 1556:{f.Push(f.Locals[1]);f.Pc=1557;continue;}
case 1557:{f.Push(JValue.R(rt.String("Choices")));f.Pc=1559;continue;}
case 1559:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1562);}
case 1562:{f.Locals[20]=f.Pop();f.Pc=1564;continue;}
case 1564:{f.Push(f.Locals[20]);f.Pc=1566;continue;}
case 1566:{f.Push(f.Locals[20]);f.Pc=1568;continue;}
case 1568:{f.Push(JValue.R(rt.String(".")));f.Pc=1570;continue;}
case 1570:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",1573);}
case 1573:{f.Pc=f.Pop().Int==0?1582:1576;continue;}
case 1576:{f.Push(JValue.R(rt.String("+powerEQ")));f.Pc=1579;continue;}
case 1579:{f.Pc=1585;continue;}
case 1582:{f.Push(JValue.R(rt.String(".powerEQ")));f.Pc=1585;continue;}
case 1585:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardEffect:3137:1585:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1590);}
case 1590:{f.Locals[20]=f.Pop();f.Pc=1592;continue;}
case 1592:{f.Push(f.Locals[18]);f.Pc=1594;continue;}
case 1594:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1599);}
case 1599:{f.Locals[21]=f.Pop();f.Pc=1601;continue;}
case 1601:{f.Push(f.Locals[21]);f.Pc=1603;continue;}
case 1603:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1608);}
case 1608:{f.Pc=f.Pop().Int==0?1699:1611;continue;}
case 1611:{f.Push(f.Locals[21]);f.Pc=1613;continue;}
case 1613:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1618);}
case 1618:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1621;continue;}
case 1621:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",1624);}
case 1624:{f.Locals[22]=f.Pop();f.Pc=1626;continue;}
case 1626:{f.Push(f.Locals[20]);f.Pc=1628;continue;}
case 1628:{f.Push(f.Locals[22]);f.Pc=1630;continue;}
case 1630:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardEffect:3137:1630:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;I)Ljava/lang/String;",1635);}
case 1635:{f.Locals[23]=f.Pop();f.Pc=1637;continue;}
case 1637:{f.Push(f.Locals[15]);f.Pc=1639;continue;}
case 1639:{f.Push(f.Locals[23]);f.Pc=1641;continue;}
case 1641:{f.Push(f.Locals[3]);f.Pc=1642;continue;}
case 1642:{f.Push(f.Locals[2]);f.Pc=1643;continue;}
case 1643:{f.Push(f.Locals[1]);f.Pc=1644;continue;}
case 1644:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1647);}
case 1647:{f.Locals[24]=f.Pop();f.Pc=1649;continue;}
case 1649:{f.Push(f.Locals[14]);f.Pc=1651;continue;}
case 1651:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1654);}
case 1654:{f.Push(f.Locals[24]);f.Pc=1656;continue;}
case 1656:{f.Push(f.Locals[1]);f.Pc=1657;continue;}
case 1657:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1660);}
case 1660:{f.Push(JValue.R(rt.String("lblChooseCreatureWithXPower")));f.Pc=1663;continue;}
case 1663:{f.Push(JValue.I(1));f.Pc=1664;continue;}
case 1664:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1667;continue;}
case 1667:{f.StackOp("dup");f.Pc=1668;continue;}
case 1668:{f.Push(JValue.I(0));f.Pc=1669;continue;}
case 1669:{f.Push(f.Locals[22]);f.Pc=1671;continue;}
case 1671:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1674);}
case 1674:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1675;continue;}
case 1675:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1678);}
case 1678:{f.Push(JValue.I(0));f.Pc=1679;continue;}
case 1679:{f.Push(JValue.R(null));f.Pc=1680;continue;}
case 1680:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",1683);}
case 1683:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1686;continue;}
case 1686:{f.Locals[25]=f.Pop();f.Pc=1688;continue;}
case 1688:{f.Push(f.Locals[19]);f.Pc=1690;continue;}
case 1690:{f.Push(f.Locals[25]);f.Pc=1692;continue;}
case 1692:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",1695);}
case 1695:{f.StackOp("pop");f.Pc=1696;continue;}
case 1696:{f.Pc=1601;continue;}
case 1699:{f.Push(f.Locals[16]);f.Pc=1701;continue;}
case 1701:{f.Push(f.Locals[19]);f.Pc=1703;continue;}
case 1703:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1706);}
case 1706:{f.StackOp("pop");f.Pc=1707;continue;}
case 1707:{f.Pc=2083;continue;}
case 1710:{f.Push(f.Locals[1]);f.Pc=1711;continue;}
case 1711:{f.Push(JValue.R(rt.String("ControlAndNot")));f.Pc=1714;continue;}
case 1714:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1717);}
case 1717:{f.Pc=f.Pop().Int==0?1872:1720;continue;}
case 1720:{f.Push(f.Locals[1]);f.Pc=1721;continue;}
case 1721:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=1724;continue;}
case 1724:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1727);}
case 1727:{f.Pc=f.Pop().Int==0?1740:1730;continue;}
case 1730:{f.Push(f.Locals[1]);f.Pc=1731;continue;}
case 1731:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=1734;continue;}
case 1734:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1737);}
case 1737:{f.Pc=1753;continue;}
case 1740:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1743);}
case 1743:{f.Push(JValue.R(rt.String("lblChooseCreature")));f.Pc=1746;continue;}
case 1746:{f.Push(JValue.I(0));f.Pc=1747;continue;}
case 1747:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1750;continue;}
case 1750:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1753);}
case 1753:{f.Locals[18]=f.Pop();f.Pc=1755;continue;}
case 1755:{f.Push(f.Locals[15]);f.Pc=1757;continue;}
case 1757:{f.Push(f.Locals[14]);f.Pc=1759;continue;}
case 1759:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollection;","invokestatic",1762);}
case 1762:{f.Locals[19]=f.Pop();f.Pc=1764;continue;}
case 1764:{f.Push(f.Locals[16]);f.Pc=1766;continue;}
case 1766:{f.Push(f.Locals[14]);f.Pc=1768;continue;}
case 1768:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1771);}
case 1771:{f.Push(f.Locals[19]);f.Pc=1773;continue;}
case 1773:{f.Push(f.Locals[1]);f.Pc=1774;continue;}
case 1774:{f.Push(f.Locals[18]);f.Pc=1776;continue;}
case 1776:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardEffect:3137:1776:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1781);}
case 1781:{f.Push(f.Locals[11]);f.Pc=1783;continue;}
case 1783:{f.Push(f.Locals[10]);f.Pc=1785;continue;}
case 1785:{f.Push(f.Locals[1]);f.Pc=1786;continue;}
case 1786:{f.Push(JValue.R(rt.String("Mandatory")));f.Pc=1788;continue;}
case 1788:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1791);}
case 1791:{f.Pc=f.Pop().Int!=0?1798:1794;continue;}
case 1794:{f.Push(JValue.I(1));f.Pc=1795;continue;}
case 1795:{f.Pc=1799;continue;}
case 1798:{f.Push(JValue.I(0));f.Pc=1799;continue;}
case 1799:{f.Push(JValue.R(null));f.Pc=1800;continue;}
case 1800:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",1803);}
case 1803:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1806);}
case 1806:{f.StackOp("pop");f.Pc=1807;continue;}
case 1807:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1810;continue;}
case 1810:{f.StackOp("dup");f.Pc=1811;continue;}
case 1811:{f.Push(f.Locals[15]);f.Pc=1813;continue;}
case 1813:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",1816);}
case 1816:{f.Locals[20]=f.Pop();f.Pc=1818;continue;}
case 1818:{f.Push(f.Locals[20]);f.Pc=1820;continue;}
case 1820:{f.Push(f.Locals[19]);f.Pc=1822;continue;}
case 1822:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",1825);}
case 1825:{f.StackOp("pop");f.Pc=1826;continue;}
case 1826:{f.Push(f.Locals[16]);f.Pc=1828;continue;}
case 1828:{f.Push(f.Locals[14]);f.Pc=1830;continue;}
case 1830:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1833);}
case 1833:{f.Push(f.Locals[20]);f.Pc=1835;continue;}
case 1835:{f.Push(f.Locals[1]);f.Pc=1836;continue;}
case 1836:{f.Push(f.Locals[18]);f.Pc=1838;continue;}
case 1838:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardEffect:3137:1838:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1843);}
case 1843:{f.Push(f.Locals[11]);f.Pc=1845;continue;}
case 1845:{f.Push(f.Locals[10]);f.Pc=1847;continue;}
case 1847:{f.Push(f.Locals[1]);f.Pc=1848;continue;}
case 1848:{f.Push(JValue.R(rt.String("Mandatory")));f.Pc=1850;continue;}
case 1850:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1853);}
case 1853:{f.Pc=f.Pop().Int!=0?1860:1856;continue;}
case 1856:{f.Push(JValue.I(1));f.Pc=1857;continue;}
case 1857:{f.Pc=1861;continue;}
case 1860:{f.Push(JValue.I(0));f.Pc=1861;continue;}
case 1861:{f.Push(JValue.R(null));f.Pc=1862;continue;}
case 1862:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",1865);}
case 1865:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1868);}
case 1868:{f.StackOp("pop");f.Pc=1869;continue;}
case 1869:{f.Pc=2083;continue;}
case 1872:{f.Push(f.Locals[1]);f.Pc=1873;continue;}
case 1873:{f.Push(JValue.R(rt.String("AtRandom")));f.Pc=1876;continue;}
case 1876:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1879);}
case 1879:{f.Pc=f.Pop().Int==0?1914:1882;continue;}
case 1882:{f.Push(f.Locals[15]);f.Pc=1884;continue;}
case 1884:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",1889);}
case 1889:{f.Pc=f.Pop().Int!=0?1914:1892;continue;}
case 1892:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1895;continue;}
case 1895:{f.StackOp("dup");f.Pc=1896;continue;}
case 1896:{f.Push(f.Locals[15]);f.Pc=1898;continue;}
case 1898:{f.Push(f.Locals[10]);f.Pc=1900;continue;}
case 1900:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;","invokestatic",1903);}
case 1903:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",1906);}
case 1906:{f.Locals[16]=f.Pop();f.Pc=1908;continue;}
case 1908:{f.Push(JValue.I(0));f.Pc=1909;continue;}
case 1909:{f.Locals[17]=f.Pop();f.Pc=1911;continue;}
case 1911:{f.Pc=2083;continue;}
case 1914:{f.Push(f.Locals[1]);f.Pc=1915;continue;}
case 1915:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=1918;continue;}
case 1918:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1921);}
case 1921:{f.Pc=f.Pop().Int==0?1934:1924;continue;}
case 1924:{f.Push(f.Locals[1]);f.Pc=1925;continue;}
case 1925:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=1928;continue;}
case 1928:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1931);}
case 1931:{f.Pc=1952;continue;}
case 1934:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1937);}
case 1937:{f.Push(JValue.R(rt.String("lblChooseaCard")));f.Pc=1940;continue;}
case 1940:{f.Push(JValue.I(0));f.Pc=1941;continue;}
case 1941:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1944;continue;}
case 1944:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1947);}
case 1947:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardEffect:3137:1947:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1952);}
case 1952:{f.Locals[18]=f.Pop();f.Pc=1954;continue;}
case 1954:{f.Push(f.Locals[1]);f.Pc=1955;continue;}
case 1955:{f.Push(JValue.R(rt.String("ChoiceTitleAppend")));f.Pc=1958;continue;}
case 1958:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1961);}
case 1961:{f.Pc=f.Pop().Int==0?2045:1964;continue;}
case 1964:{f.Push(JValue.R(rt.String("")));f.Pc=1967;continue;}
case 1967:{f.Locals[19]=f.Pop();f.Pc=1969;continue;}
case 1969:{f.Push(f.Locals[1]);f.Pc=1970;continue;}
case 1970:{f.Push(JValue.R(rt.String("ChoiceTitleAppend")));f.Pc=1973;continue;}
case 1973:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1976);}
case 1976:{f.Locals[20]=f.Pop();f.Pc=1978;continue;}
case 1978:{f.Push(f.Locals[20]);f.Pc=1980;continue;}
case 1980:{f.Push(JValue.R(rt.String("Defined ")));f.Pc=1983;continue;}
case 1983:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1986);}
case 1986:{f.Pc=f.Pop().Int==0?2009:1989;continue;}
case 1989:{f.Push(f.Locals[2]);f.Pc=1990;continue;}
case 1990:{f.Push(f.Locals[20]);f.Pc=1992;continue;}
case 1992:{f.Push(JValue.I(8));f.Pc=1994;continue;}
case 1994:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1997);}
case 1997:{f.Push(f.Locals[1]);f.Pc=1998;continue;}
case 1998:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",2001);}
case 2001:{return rt.Call(f,"forge/game/player/PlayerCollection","toString","()Ljava/lang/String;","invokevirtual",2004);}
case 2004:{f.Locals[19]=f.Pop();f.Pc=2006;continue;}
case 2006:{f.Pc=2026;continue;}
case 2009:{f.Push(f.Locals[20]);f.Pc=2011;continue;}
case 2011:{f.Push(JValue.R(rt.String("ChosenType")));f.Pc=2014;continue;}
case 2014:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2017);}
case 2017:{f.Pc=f.Pop().Int==0?2026:2020;continue;}
case 2020:{f.Push(f.Locals[2]);f.Pc=2021;continue;}
case 2021:{return rt.Call(f,"forge/game/card/Card","getChosenType","()Ljava/lang/String;","invokevirtual",2024);}
case 2024:{f.Locals[19]=f.Pop();f.Pc=2026;continue;}
case 2026:{f.Push(f.Locals[19]);f.Pc=2028;continue;}
case 2028:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",2031);}
case 2031:{f.Pc=f.Pop().Int!=0?2045:2034;continue;}
case 2034:{f.Push(f.Locals[18]);f.Pc=2036;continue;}
case 2036:{f.Push(f.Locals[19]);f.Pc=2038;continue;}
case 2038:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardEffect:3137:2038:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",2043);}
case 2043:{f.Locals[18]=f.Pop();f.Pc=2045;continue;}
case 2045:{f.Push(f.Locals[16]);f.Pc=2047;continue;}
case 2047:{f.Push(f.Locals[14]);f.Pc=2049;continue;}
case 2049:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",2052);}
case 2052:{f.Push(f.Locals[15]);f.Pc=2054;continue;}
case 2054:{f.Push(f.Locals[1]);f.Pc=2055;continue;}
case 2055:{f.Push(f.Locals[18]);f.Pc=2057;continue;}
case 2057:{f.Push(f.Locals[11]);f.Pc=2059;continue;}
case 2059:{f.Push(f.Locals[10]);f.Pc=2061;continue;}
case 2061:{f.Push(f.Locals[1]);f.Pc=2062;continue;}
case 2062:{f.Push(JValue.R(rt.String("Mandatory")));f.Pc=2064;continue;}
case 2064:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2067);}
case 2067:{f.Pc=f.Pop().Int!=0?2074:2070;continue;}
case 2070:{f.Push(JValue.I(1));f.Pc=2071;continue;}
case 2071:{f.Pc=2075;continue;}
case 2074:{f.Push(JValue.I(0));f.Pc=2075;continue;}
case 2075:{f.Push(JValue.R(null));f.Pc=2076;continue;}
case 2076:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",2079);}
case 2079:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",2082);}
case 2082:{f.StackOp("pop");f.Pc=2083;continue;}
case 2083:{f.Push(f.Locals[1]);f.Pc=2084;continue;}
case 2084:{f.Push(JValue.R(rt.String("Reveal")));f.Pc=2087;continue;}
case 2087:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2090);}
case 2090:{f.Pc=f.Pop().Int==0?2159:2093;continue;}
case 2093:{f.Push(f.Locals[1]);f.Pc=2094;continue;}
case 2094:{f.Push(JValue.R(rt.String("Secretly")));f.Pc=2097;continue;}
case 2097:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2100);}
case 2100:{f.Pc=f.Pop().Int!=0?2159:2103;continue;}
case 2103:{f.Push(f.Locals[4]);f.Pc=2105;continue;}
case 2105:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",2108);}
case 2108:{f.Push(f.Locals[16]);f.Pc=2110;continue;}
case 2110:{f.Push(f.Locals[14]);f.Pc=2112;continue;}
case 2112:{f.Push(f.Locals[17]);f.Pc=2114;continue;}
case 2114:{f.Push(f.Locals[12]);f.Pc=2116;continue;}
case 2116:{f.Pc=f.Pop().Int==0?2128:2119;continue;}
case 2119:{f.Push(f.Locals[1]);f.Pc=2120;continue;}
case 2120:{f.Push(JValue.R(rt.String("RevealTitle")));f.Pc=2122;continue;}
case 2122:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2125);}
case 2125:{f.Pc=2146;continue;}
case 2128:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",2131);}
case 2131:{f.Push(JValue.R(rt.String("lblChosenCards")));f.Pc=2134;continue;}
case 2134:{f.Push(JValue.I(0));f.Pc=2135;continue;}
case 2135:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=2138;continue;}
case 2138:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",2141);}
case 2141:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardEffect:3137:2141:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2146);}
case 2146:{f.Push(f.Locals[12]);f.Pc=2148;continue;}
case 2148:{f.Pc=f.Pop().Int!=0?2155:2151;continue;}
case 2151:{f.Push(JValue.I(1));f.Pc=2152;continue;}
case 2152:{f.Pc=2156;continue;}
case 2155:{f.Push(JValue.I(0));f.Pc=2156;continue;}
case 2156:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;ZLjava/lang/String;Z)V","invokevirtual",2159);}
case 2159:{f.Push(f.Locals[1]);f.Pc=2160;continue;}
case 2160:{f.Push(JValue.R(rt.String("ChosenMap")));f.Pc=2163;continue;}
case 2163:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2166);}
case 2166:{f.Pc=f.Pop().Int==0?2177:2169;continue;}
case 2169:{f.Push(f.Locals[2]);f.Pc=2170;continue;}
case 2170:{f.Push(f.Locals[14]);f.Pc=2172;continue;}
case 2172:{f.Push(f.Locals[16]);f.Pc=2174;continue;}
case 2174:{return rt.Call(f,"forge/game/card/Card","addToChosenMap","(Lforge/game/player/Player;Lforge/game/card/CardCollection;)V","invokevirtual",2177);}
case 2177:{f.Push(f.Locals[5]);f.Pc=2179;continue;}
case 2179:{f.Push(f.Locals[16]);f.Pc=2181;continue;}
case 2181:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",2184);}
case 2184:{f.StackOp("pop");f.Pc=2185;continue;}
case 2185:{f.Pc=284;continue;}
case 2188:{f.Push(f.Locals[1]);f.Pc=2189;continue;}
case 2189:{f.Push(JValue.R(rt.String("Reveal")));f.Pc=2192;continue;}
case 2192:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2195);}
case 2195:{f.Pc=f.Pop().Int==0?2265:2198;continue;}
case 2198:{f.Push(f.Locals[1]);f.Pc=2199;continue;}
case 2199:{f.Push(JValue.R(rt.String("Secretly")));f.Pc=2202;continue;}
case 2202:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2205);}
case 2205:{f.Pc=f.Pop().Int==0?2265:2208;continue;}
case 2208:{f.Push(f.Locals[4]);f.Pc=2210;continue;}
case 2210:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",2213);}
case 2213:{f.Push(f.Locals[5]);f.Pc=2215;continue;}
case 2215:{f.Push(f.Locals[4]);f.Pc=2217;continue;}
case 2217:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",2220);}
case 2220:{f.Push(f.Locals[12]);f.Pc=2222;continue;}
case 2222:{f.Pc=f.Pop().Int==0?2234:2225;continue;}
case 2225:{f.Push(f.Locals[1]);f.Pc=2226;continue;}
case 2226:{f.Push(JValue.R(rt.String("RevealTitle")));f.Pc=2228;continue;}
case 2228:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2231);}
case 2231:{f.Pc=2252;continue;}
case 2234:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",2237);}
case 2237:{f.Push(JValue.R(rt.String("lblChosenCards")));f.Pc=2240;continue;}
case 2240:{f.Push(JValue.I(0));f.Pc=2241;continue;}
case 2241:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=2244;continue;}
case 2244:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",2247);}
case 2247:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardEffect:3137:2247:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2252);}
case 2252:{f.Push(f.Locals[12]);f.Pc=2254;continue;}
case 2254:{f.Pc=f.Pop().Int!=0?2261:2257;continue;}
case 2257:{f.Push(JValue.I(1));f.Pc=2258;continue;}
case 2258:{f.Pc=2262;continue;}
case 2261:{f.Push(JValue.I(0));f.Pc=2262;continue;}
case 2262:{return rt.Call(f,"forge/game/GameAction","revealTo","(Lforge/game/card/CardCollectionView;Ljava/lang/Iterable;Ljava/lang/String;Z)V","invokevirtual",2265);}
case 2265:{f.Push(f.Locals[2]);f.Pc=2266;continue;}
case 2266:{f.Push(f.Locals[5]);f.Pc=2268;continue;}
case 2268:{return rt.Call(f,"forge/game/card/Card","setChosenCards","(Ljava/lang/Iterable;)V","invokevirtual",2271);}
case 2271:{f.Push(f.Locals[1]);f.Pc=2272;continue;}
case 2272:{f.Push(JValue.R(rt.String("ForgetOtherRemembered")));f.Pc=2275;continue;}
case 2275:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2278);}
case 2278:{f.Pc=f.Pop().Int==0?2285:2281;continue;}
case 2281:{f.Push(f.Locals[2]);f.Pc=2282;continue;}
case 2282:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",2285);}
case 2285:{f.Push(f.Locals[1]);f.Pc=2286;continue;}
case 2286:{f.Push(JValue.R(rt.String("RememberChosen")));f.Pc=2289;continue;}
case 2289:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2292);}
case 2292:{f.Pc=f.Pop().Int==0?2301:2295;continue;}
case 2295:{f.Push(f.Locals[2]);f.Pc=2296;continue;}
case 2296:{f.Push(f.Locals[5]);f.Pc=2298;continue;}
case 2298:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",2301);}
case 2301:{f.Push(f.Locals[1]);f.Pc=2302;continue;}
case 2302:{f.Push(JValue.R(rt.String("ForgetChosen")));f.Pc=2305;continue;}
case 2305:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2308);}
case 2308:{f.Pc=f.Pop().Int==0?2317:2311;continue;}
case 2311:{f.Push(f.Locals[2]);f.Pc=2312;continue;}
case 2312:{f.Push(f.Locals[5]);f.Pc=2314;continue;}
case 2314:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Iterable;)V","invokevirtual",2317);}
case 2317:{f.Push(f.Locals[1]);f.Pc=2318;continue;}
case 2318:{f.Push(JValue.R(rt.String("ImprintChosen")));f.Pc=2321;continue;}
case 2321:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2324);}
case 2324:{f.Pc=f.Pop().Int==0?2333:2327;continue;}
case 2327:{f.Push(f.Locals[2]);f.Pc=2328;continue;}
case 2328:{f.Push(f.Locals[5]);f.Pc=2330;continue;}
case 2330:{return rt.Call(f,"forge/game/card/Card","addImprintedCards","(Ljava/lang/Iterable;)V","invokevirtual",2333);}
case 2333:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3138(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

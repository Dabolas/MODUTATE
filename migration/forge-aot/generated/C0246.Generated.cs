// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C246{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/CleanUpEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3181,"forge/game/ability/effects/CleanUpEffect","<init>","()V",1,1,1,new JHandler[]{},M3181));
c.Add(new JMethod(3182,"forge/game/ability/effects/CleanUpEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,7,4,new JHandler[]{},M3182));
c.Add(new JMethod(3183,"forge/game/ability/effects/CleanUpEffect","logOutput","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;)Ljava/lang/String;",4,9,7,new JHandler[]{},M3183));
}

internal static JStep M3181(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3182(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Defined")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?24:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/ability/effects/CleanUpEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",13);}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Pc=29;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",28);}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",33);}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("")));f.Pc=36;continue;}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("Log")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int==0?55:47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/ability/effects/CleanUpEffect","logOutput","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;)Ljava/lang/String;","invokevirtual",53);}
case 53:{f.Locals[4]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("ClearRemembered")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int==0?76:64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",68);}
case 68:{f.Push(f.Locals[3]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",73);}
case 73:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",76);}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String("ForgetDefined")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",82);}
case 82:{f.Pc=f.Pop().Int==0?132:85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String("ForgetDefined")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",92);}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedEntities","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",96);}
case 96:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",99);}
case 99:{f.Locals[5]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[5]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",108);}
case 108:{f.Pc=f.Pop().Int==0?132:111;continue;}
case 111:{f.Push(f.Locals[5]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",118);}
case 118:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=121;continue;}
case 121:{f.Locals[6]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[2]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[6]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Object;)V","invokevirtual",129);}
case 129:{f.Pc=101;continue;}
case 132:{f.Push(f.Locals[1]);f.Pc=133;continue;}
case 133:{f.Push(JValue.R(rt.String("ClearImprinted")));f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",138);}
case 138:{f.Pc=f.Pop().Int==0?153:141;continue;}
case 141:{f.Push(f.Locals[2]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/card/Card","clearImprintedCards","()V","invokevirtual",145);}
case 145:{f.Push(f.Locals[3]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[2]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",150);}
case 150:{return rt.Call(f,"forge/game/card/Card","clearImprintedCards","()V","invokevirtual",153);}
case 153:{f.Push(f.Locals[1]);f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String("ClearTriggered")));f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",159);}
case 159:{f.Pc=f.Pop().Int==0?170:162;continue;}
case 162:{f.Push(f.Locals[3]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",166);}
case 166:{f.Push(f.Locals[2]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/trigger/TriggerHandler","clearDelayedTrigger","(Lforge/game/card/Card;)V","invokevirtual",170);}
case 170:{f.Push(f.Locals[1]);f.Pc=171;continue;}
case 171:{f.Push(JValue.R(rt.String("ClearCoinFlips")));f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",176);}
case 176:{f.Pc=f.Pop().Int==0?183:179;continue;}
case 179:{f.Push(f.Locals[2]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/card/Card","clearFlipResult","()V","invokevirtual",183);}
case 183:{f.Push(f.Locals[1]);f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String("ClearChosenCard")));f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",189);}
case 189:{f.Pc=f.Pop().Int==0?197:192;continue;}
case 192:{f.Push(f.Locals[2]);f.Pc=193;continue;}
case 193:{f.Push(JValue.R(null));f.Pc=194;continue;}
case 194:{return rt.Call(f,"forge/game/card/Card","setChosenCards","(Ljava/lang/Iterable;)V","invokevirtual",197);}
case 197:{f.Push(f.Locals[1]);f.Pc=198;continue;}
case 198:{f.Push(JValue.R(rt.String("ClearChosenPlayer")));f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",203);}
case 203:{f.Pc=f.Pop().Int==0?211:206;continue;}
case 206:{f.Push(f.Locals[2]);f.Pc=207;continue;}
case 207:{f.Push(JValue.R(null));f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/card/Card","setChosenPlayer","(Lforge/game/player/Player;)V","invokevirtual",211);}
case 211:{f.Push(f.Locals[1]);f.Pc=212;continue;}
case 212:{f.Push(JValue.R(rt.String("ClearChosenType")));f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",217);}
case 217:{f.Pc=f.Pop().Int==0?232:220;continue;}
case 220:{f.Push(f.Locals[2]);f.Pc=221;continue;}
case 221:{f.Push(JValue.R(rt.String("")));f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/card/Card","setChosenType","(Ljava/lang/String;)V","invokevirtual",226);}
case 226:{f.Push(f.Locals[2]);f.Pc=227;continue;}
case 227:{f.Push(JValue.R(rt.String("")));f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/card/Card","setChosenType2","(Ljava/lang/String;)V","invokevirtual",232);}
case 232:{f.Push(f.Locals[1]);f.Pc=233;continue;}
case 233:{f.Push(JValue.R(rt.String("ClearChosenColor")));f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",238);}
case 238:{f.Pc=f.Pop().Int==0?246:241;continue;}
case 241:{f.Push(f.Locals[2]);f.Pc=242;continue;}
case 242:{f.Push(JValue.R(null));f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/card/Card","setChosenColors","(Ljava/util/List;)V","invokevirtual",246);}
case 246:{f.Push(f.Locals[1]);f.Pc=247;continue;}
case 247:{f.Push(JValue.R(rt.String("ClearNamedCard")));f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",252);}
case 252:{f.Pc=f.Pop().Int==0?262:255;continue;}
case 255:{f.Push(f.Locals[2]);f.Pc=256;continue;}
case 256:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",259);}
case 259:{return rt.Call(f,"forge/game/card/Card","setNamedCards","(Ljava/util/List;)V","invokevirtual",262);}
case 262:{f.Push(f.Locals[1]);f.Pc=263;continue;}
case 263:{f.Push(JValue.R(rt.String("Log")));f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",268);}
case 268:{f.Pc=f.Pop().Int==0?290:271;continue;}
case 271:{f.Push(f.Locals[2]);f.Pc=272;continue;}
case 272:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",275);}
case 275:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",278);}
case 278:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventRandomLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventRandomLog")));f.Pc=281;continue;}
case 281:{f.StackOp("dup");f.Pc=282;continue;}
case 282:{f.Push(f.Locals[4]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"forge/game/event/GameEventRandomLog","<init>","(Ljava/lang/String;)V","invokespecial",287);}
case 287:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",290);}
case 290:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3183(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Locals[4]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=16;continue;}
case 16:{f.Locals[5]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("ClearRemembered")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?185:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/Card","getRememberedCount","()I","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int==0?185:34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",38);}
case 38:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",43);}
case 43:{f.Locals[6]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[6]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",52);}
case 52:{f.Pc=f.Pop().Int==0?185:55;continue;}
case 55:{f.Push(f.Locals[6]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",62);}
case 62:{f.Locals[7]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[7]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",69);}
case 69:{f.Locals[8]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[7]);f.Pc=73;continue;}
case 73:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=76;continue;}
case 76:{f.Pc=f.Pop().Int==0?128:79;continue;}
case 79:{f.Push(f.Locals[3]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[3]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int<=0?92:87;continue;}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{f.Pc=94;continue;}
case 92:{f.Push(JValue.R(rt.String("")));f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",97);}
case 97:{f.StackOp("pop");f.Pc=98;continue;}
case 98:{f.Push(f.Locals[3]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",102);}
case 102:{f.Push(JValue.R(rt.String("lblChosenCard")));f.Pc=104;continue;}
case 104:{f.Push(JValue.I(2));f.Pc=105;continue;}
case 105:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=108;continue;}
case 108:{f.StackOp("dup");f.Pc=109;continue;}
case 109:{f.Push(JValue.I(0));f.Pc=110;continue;}
case 110:{f.Push(f.Locals[4]);f.Pc=112;continue;}
case 112:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=113;continue;}
case 113:{f.StackOp("dup");f.Pc=114;continue;}
case 114:{f.Push(JValue.I(1));f.Pc=115;continue;}
case 115:{f.Push(f.Locals[8]);f.Pc=117;continue;}
case 117:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",121);}
case 121:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",124);}
case 124:{f.StackOp("pop");f.Pc=125;continue;}
case 125:{f.Pc=182;continue;}
case 128:{f.Push(f.Locals[7]);f.Pc=130;continue;}
case 130:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=133;continue;}
case 133:{f.Pc=f.Pop().Int==0?182:136;continue;}
case 136:{f.Push(f.Locals[3]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[3]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",141);}
case 141:{f.Pc=f.Pop().Int<=0?149:144;continue;}
case 144:{f.Push(f.Locals[5]);f.Pc=146;continue;}
case 146:{f.Pc=151;continue;}
case 149:{f.Push(JValue.R(rt.String("")));f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",154);}
case 154:{f.StackOp("pop");f.Pc=155;continue;}
case 155:{f.Push(f.Locals[3]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",159);}
case 159:{f.Push(JValue.R(rt.String("lblChosenPlayer")));f.Pc=161;continue;}
case 161:{f.Push(JValue.I(2));f.Pc=162;continue;}
case 162:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=165;continue;}
case 165:{f.StackOp("dup");f.Pc=166;continue;}
case 166:{f.Push(JValue.I(0));f.Pc=167;continue;}
case 167:{f.Push(f.Locals[4]);f.Pc=169;continue;}
case 169:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=170;continue;}
case 170:{f.StackOp("dup");f.Pc=171;continue;}
case 171:{f.Push(JValue.I(1));f.Pc=172;continue;}
case 172:{f.Push(f.Locals[8]);f.Pc=174;continue;}
case 174:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",178);}
case 178:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",181);}
case 181:{f.StackOp("pop");f.Pc=182;continue;}
case 182:{f.Pc=45;continue;}
case 185:{f.Push(f.Locals[1]);f.Pc=186;continue;}
case 186:{f.Push(JValue.R(rt.String("ClearChosenCard")));f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",191);}
case 191:{f.Pc=f.Pop().Int==0?225:194;continue;}
case 194:{f.Push(f.Locals[2]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/card/Card","hasChosenCard","()Z","invokevirtual",198);}
case 198:{f.Pc=f.Pop().Int==0?225:201;continue;}
case 201:{f.Push(f.Locals[2]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/game/card/Card","getChosenCards","()Lforge/game/card/CardCollectionView;","invokevirtual",205);}
case 205:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",208);}
case 208:{f.Push(JValue.R(rt.String("[")));f.Pc=210;continue;}
case 210:{f.Push(JValue.R(rt.String("")));f.Pc=212;continue;}
case 212:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",215);}
case 215:{f.Push(JValue.R(rt.String("]")));f.Pc=217;continue;}
case 217:{f.Push(JValue.R(rt.String("")));f.Pc=219;continue;}
case 219:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",222);}
case 222:{f.Pc=227;continue;}
case 225:{f.Push(JValue.R(rt.String("")));f.Pc=227;continue;}
case 227:{f.Locals[6]=f.Pop();f.Pc=229;continue;}
case 229:{f.Push(f.Locals[6]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",234);}
case 234:{f.Pc=f.Pop().Int<=0?317:237;continue;}
case 237:{f.Push(f.Locals[3]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",241);}
case 241:{f.Push(f.Locals[6]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",246);}
case 246:{f.Pc=f.Pop().Int!=0?317:249;continue;}
case 249:{f.Push(f.Locals[3]);f.Pc=250;continue;}
case 250:{f.Push(f.Locals[3]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",254);}
case 254:{f.Pc=f.Pop().Int<=0?262:257;continue;}
case 257:{f.Push(f.Locals[5]);f.Pc=259;continue;}
case 259:{f.Pc=264;continue;}
case 262:{f.Push(JValue.R(rt.String("")));f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",267);}
case 267:{f.StackOp("pop");f.Pc=268;continue;}
case 268:{f.Push(f.Locals[2]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/card/Card","getChosenCards","()Lforge/game/card/CardCollectionView;","invokevirtual",272);}
case 272:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",277);}
case 277:{f.Push(JValue.I(1));f.Pc=278;continue;}
case 278:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?286:281;continue;}
case 281:{f.Push(JValue.R(rt.String("lblChosenMultiCard")));f.Pc=283;continue;}
case 283:{f.Pc=288;continue;}
case 286:{f.Push(JValue.R(rt.String("lblChosenCard")));f.Pc=288;continue;}
case 288:{f.Locals[7]=f.Pop();f.Pc=290;continue;}
case 290:{f.Push(f.Locals[3]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",294);}
case 294:{f.Push(f.Locals[7]);f.Pc=296;continue;}
case 296:{f.Push(JValue.I(2));f.Pc=297;continue;}
case 297:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=300;continue;}
case 300:{f.StackOp("dup");f.Pc=301;continue;}
case 301:{f.Push(JValue.I(0));f.Pc=302;continue;}
case 302:{f.Push(f.Locals[4]);f.Pc=304;continue;}
case 304:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=305;continue;}
case 305:{f.StackOp("dup");f.Pc=306;continue;}
case 306:{f.Push(JValue.I(1));f.Pc=307;continue;}
case 307:{f.Push(f.Locals[6]);f.Pc=309;continue;}
case 309:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",313);}
case 313:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",316);}
case 316:{f.StackOp("pop");f.Pc=317;continue;}
case 317:{f.Push(f.Locals[1]);f.Pc=318;continue;}
case 318:{f.Push(JValue.R(rt.String("ClearChosenPlayer")));f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",323);}
case 323:{f.Pc=f.Pop().Int==0?343:326;continue;}
case 326:{f.Push(f.Locals[2]);f.Pc=327;continue;}
case 327:{return rt.Call(f,"forge/game/card/Card","hasChosenPlayer","()Z","invokevirtual",330);}
case 330:{f.Pc=f.Pop().Int==0?343:333;continue;}
case 333:{f.Push(f.Locals[2]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/game/card/Card","getChosenPlayer","()Lforge/game/player/Player;","invokevirtual",337);}
case 337:{return rt.Call(f,"forge/game/player/Player","toString","()Ljava/lang/String;","invokevirtual",340);}
case 340:{f.Pc=345;continue;}
case 343:{f.Push(JValue.R(rt.String("")));f.Pc=345;continue;}
case 345:{f.Locals[7]=f.Pop();f.Pc=347;continue;}
case 347:{f.Push(f.Locals[7]);f.Pc=349;continue;}
case 349:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",352);}
case 352:{f.Pc=f.Pop().Int<=0?413:355;continue;}
case 355:{f.Push(f.Locals[3]);f.Pc=356;continue;}
case 356:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",359);}
case 359:{f.Push(f.Locals[7]);f.Pc=361;continue;}
case 361:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",364);}
case 364:{f.Pc=f.Pop().Int!=0?413:367;continue;}
case 367:{f.Push(f.Locals[3]);f.Pc=368;continue;}
case 368:{f.Push(f.Locals[3]);f.Pc=369;continue;}
case 369:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",372);}
case 372:{f.Pc=f.Pop().Int<=0?380:375;continue;}
case 375:{f.Push(f.Locals[5]);f.Pc=377;continue;}
case 377:{f.Pc=382;continue;}
case 380:{f.Push(JValue.R(rt.String("")));f.Pc=382;continue;}
case 382:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",385);}
case 385:{f.StackOp("pop");f.Pc=386;continue;}
case 386:{f.Push(f.Locals[3]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",390);}
case 390:{f.Push(JValue.R(rt.String("lblChosenPlayer")));f.Pc=392;continue;}
case 392:{f.Push(JValue.I(2));f.Pc=393;continue;}
case 393:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=396;continue;}
case 396:{f.StackOp("dup");f.Pc=397;continue;}
case 397:{f.Push(JValue.I(0));f.Pc=398;continue;}
case 398:{f.Push(f.Locals[4]);f.Pc=400;continue;}
case 400:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=401;continue;}
case 401:{f.StackOp("dup");f.Pc=402;continue;}
case 402:{f.Push(JValue.I(1));f.Pc=403;continue;}
case 403:{f.Push(f.Locals[7]);f.Pc=405;continue;}
case 405:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=406;continue;}
case 406:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",409);}
case 409:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",412);}
case 412:{f.StackOp("pop");f.Pc=413;continue;}
case 413:{f.Push(f.Locals[3]);f.Pc=414;continue;}
case 414:{f.Push(f.Locals[3]);f.Pc=415;continue;}
case 415:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",418);}
case 418:{f.Pc=f.Pop().Int<=0?426:421;continue;}
case 421:{f.Push(JValue.R(rt.String("")));f.Pc=423;continue;}
case 423:{f.Pc=443;continue;}
case 426:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",429);}
case 429:{f.Push(JValue.R(rt.String("lblNoValidChoice")));f.Pc=431;continue;}
case 431:{f.Push(JValue.I(1));f.Pc=432;continue;}
case 432:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=435;continue;}
case 435:{f.StackOp("dup");f.Pc=436;continue;}
case 436:{f.Push(JValue.I(0));f.Pc=437;continue;}
case 437:{f.Push(f.Locals[4]);f.Pc=439;continue;}
case 439:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=440;continue;}
case 440:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",443);}
case 443:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",446);}
case 446:{f.StackOp("pop");f.Pc=447;continue;}
case 447:{f.Push(f.Locals[3]);f.Pc=448;continue;}
case 448:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",451);}
case 451:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

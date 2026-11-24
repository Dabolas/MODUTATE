// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C360{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/PumpAllEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3581,"forge/game/ability/effects/PumpAllEffect","<init>","()V",1,1,1,new JHandler[]{},M3581));
c.Add(new JMethod(3582,"forge/game/ability/effects/PumpAllEffect","applyPumpAll","(Lforge/game/spellability/SpellAbility;Ljava/lang/Iterable;IILjava/util/List;Ljava/util/List;)V",10,16,8,new JHandler[]{},M3582));
c.Add(new JMethod(3583,"forge/game/ability/effects/PumpAllEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,2,new JHandler[]{},M3583));
c.Add(new JMethod(3584,"forge/game/ability/effects/PumpAllEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,11,6,new JHandler[]{},M3584));
}

internal static JStep M3581(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3582(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[6]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[6]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",14);}
case 14:{f.Locals[7]=f.Pop();f.Pc=16;continue;}
case 16:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",19);}
case 19:{f.Locals[9]=f.Pop();f.Pc=21;continue;}
case 21:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",24);}
case 24:{f.Locals[10]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("Perpetual")));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("Duration")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",34);}
case 34:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",37);}
case 37:{f.Locals[11]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",46);}
case 46:{f.Locals[12]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[12]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",55);}
case 55:{f.Pc=f.Pop().Int==0?111:58;continue;}
case 58:{f.Push(f.Locals[12]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{f.Locals[13]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[13]);f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("HIDDEN")));f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",77);}
case 77:{f.Pc=f.Pop().Int==0?98:80;continue;}
case 80:{f.Push(f.Locals[10]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[13]);f.Pc=84;continue;}
case 84:{f.Push(JValue.I(7));f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",89);}
case 89:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",94);}
case 94:{f.StackOp("pop");f.Pc=95;continue;}
case 95:{f.Pc=108;continue;}
case 98:{f.Push(f.Locals[9]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[13]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",107);}
case 107:{f.StackOp("pop");f.Pc=108;continue;}
case 108:{f.Pc=48;continue;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",117);}
case 117:{f.Locals[12]=f.Pop();f.Pc=119;continue;}
case 119:{f.Push(f.Locals[12]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",126);}
case 126:{f.Pc=f.Pop().Int==0?355:129;continue;}
case 129:{f.Push(f.Locals[12]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",136);}
case 136:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=139;continue;}
case 139:{f.Locals[13]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[13]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[5]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/card/Card","isInZones","(Ljava/util/List;)Z","invokevirtual",148);}
case 148:{f.Pc=f.Pop().Int!=0?154:151;continue;}
case 151:{f.Pc=119;continue;}
case 154:{f.Push(JValue.I(0));f.Pc=155;continue;}
case 155:{f.Locals[14]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(f.Locals[2]);f.Pc=158;continue;}
case 158:{f.Pc=f.Pop().Int!=0?165:161;continue;}
case 161:{f.Push(f.Locals[3]);f.Pc=162;continue;}
case 162:{f.Pc=f.Pop().Int==0?205:165;continue;}
case 165:{f.Push(f.Locals[11]);f.Pc=167;continue;}
case 167:{f.Pc=f.Pop().Int==0?192:170;continue;}
case 170:{f.Push(f.Locals[13]);f.Pc=172;continue;}
case 172:{if(!rt.EnsureInitialized(f,"forge/game/card/perpetual/PerpetualPTBoost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/perpetual/PerpetualPTBoost")));f.Pc=175;continue;}
case 175:{f.StackOp("dup");f.Pc=176;continue;}
case 176:{f.Push(f.Locals[7]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[2]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",182);}
case 182:{f.Push(f.Locals[3]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",186);}
case 186:{return rt.Call(f,"forge/game/card/perpetual/PerpetualPTBoost","<init>","(JLjava/lang/Integer;Ljava/lang/Integer;)V","invokespecial",189);}
case 189:{return rt.Call(f,"forge/game/card/Card","addPerpetual","(Lforge/game/card/perpetual/PerpetualInterface;)V","invokevirtual",192);}
case 192:{f.Push(f.Locals[13]);f.Pc=194;continue;}
case 194:{f.Push(f.Locals[2]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[3]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[7]);f.Pc=198;continue;}
case 198:{f.Push(JValue.L(0));f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/card/Card","addPTBoost","(IIJJ)V","invokevirtual",202);}
case 202:{f.Push(JValue.I(1));f.Pc=203;continue;}
case 203:{f.Locals[14]=f.Pop();f.Pc=205;continue;}
case 205:{f.Push(f.Locals[9]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",212);}
case 212:{f.Pc=f.Pop().Int!=0?250:215;continue;}
case 215:{f.Push(f.Locals[11]);f.Pc=217;continue;}
case 217:{f.Pc=f.Pop().Int==0?238:220;continue;}
case 220:{f.Push(f.Locals[13]);f.Pc=222;continue;}
case 222:{if(!rt.EnsureInitialized(f,"forge/game/card/perpetual/PerpetualKeywords"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/perpetual/PerpetualKeywords")));f.Pc=225;continue;}
case 225:{f.StackOp("dup");f.Pc=226;continue;}
case 226:{f.Push(f.Locals[7]);f.Pc=228;continue;}
case 228:{f.Push(f.Locals[9]);f.Pc=230;continue;}
case 230:{f.Push(JValue.R(null));f.Pc=231;continue;}
case 231:{f.Push(JValue.I(0));f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/card/perpetual/PerpetualKeywords","<init>","(JLjava/util/List;Ljava/util/List;Z)V","invokespecial",235);}
case 235:{return rt.Call(f,"forge/game/card/Card","addPerpetual","(Lforge/game/card/perpetual/PerpetualInterface;)V","invokevirtual",238);}
case 238:{f.Push(f.Locals[13]);f.Pc=240;continue;}
case 240:{f.Push(f.Locals[9]);f.Pc=242;continue;}
case 242:{f.Push(JValue.R(null));f.Pc=243;continue;}
case 243:{f.Push(JValue.I(0));f.Pc=244;continue;}
case 244:{f.Push(f.Locals[7]);f.Pc=246;continue;}
case 246:{f.Push(JValue.R(null));f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/card/Card","addChangedCardKeywords","(Ljava/util/List;Ljava/util/List;ZJLforge/game/staticability/StaticAbility;)V","invokevirtual",250);}
case 250:{f.Push(f.Locals[14]);f.Pc=252;continue;}
case 252:{f.Pc=f.Pop().Int==0?260:255;continue;}
case 255:{f.Push(f.Locals[13]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/card/Card","updatePTforView","()V","invokevirtual",260);}
case 260:{f.Push(f.Locals[10]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",267);}
case 267:{f.Pc=f.Pop().Int!=0?280:270;continue;}
case 270:{f.Push(f.Locals[13]);f.Pc=272;continue;}
case 272:{f.Push(f.Locals[7]);f.Pc=274;continue;}
case 274:{f.Push(JValue.L(0));f.Pc=275;continue;}
case 275:{f.Push(f.Locals[10]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/card/Card","addHiddenExtrinsicKeywords","(JJLjava/lang/Iterable;)V","invokevirtual",280);}
case 280:{f.Push(f.Locals[0]);f.Pc=281;continue;}
case 281:{f.Push(JValue.R(rt.String("RememberPumped")));f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",286);}
case 286:{f.Pc=f.Pop().Int==0?298:289;continue;}
case 289:{f.Push(f.Locals[0]);f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",293);}
case 293:{f.Push(f.Locals[13]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",298);}
case 298:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=300;continue;}
case 300:{f.Push(f.Locals[0]);f.Pc=301;continue;}
case 301:{f.Push(JValue.R(rt.String("Duration")));f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",306);}
case 306:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",309);}
case 309:{f.Pc=f.Pop().Int!=0?338:312;continue;}
case 312:{f.Push(f.Locals[11]);f.Pc=314;continue;}
case 314:{f.Pc=f.Pop().Int!=0?338:317;continue;}
case 317:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/PumpAllEffect$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/PumpAllEffect$1")));f.Pc=320;continue;}
case 320:{f.StackOp("dup");f.Pc=321;continue;}
case 321:{f.Push(f.Locals[13]);f.Pc=323;continue;}
case 323:{f.Push(f.Locals[7]);f.Pc=325;continue;}
case 325:{f.Push(f.Locals[6]);f.Pc=327;continue;}
case 327:{return rt.Call(f,"forge/game/ability/effects/PumpAllEffect$1","<init>","(Lforge/game/card/Card;JLforge/game/Game;)V","invokespecial",330);}
case 330:{f.Locals[15]=f.Pop();f.Pc=332;continue;}
case 332:{f.Push(f.Locals[0]);f.Pc=333;continue;}
case 333:{f.Push(f.Locals[15]);f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/game/ability/effects/PumpAllEffect","addUntilCommand","(Lforge/game/spellability/SpellAbility;Lforge/GameCommand;)V","invokestatic",338);}
case 338:{f.Push(f.Locals[6]);f.Pc=340;continue;}
case 340:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=343;continue;}
case 343:{f.StackOp("dup");f.Pc=344;continue;}
case 344:{f.Push(f.Locals[13]);f.Pc=346;continue;}
case 346:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",349);}
case 349:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",352);}
case 352:{f.Pc=119;continue;}
case 355:{f.Push(f.Locals[0]);f.Pc=356;continue;}
case 356:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=358;continue;}
case 358:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",361);}
case 361:{f.Pc=f.Pop().Int==0?382:364;continue;}
case 364:{f.Push(f.Locals[1]);f.Pc=365;continue;}
case 365:{return rt.Call(f,"com/google/common/collect/Iterables","isEmpty","(Ljava/lang/Iterable;)Z","invokestatic",368);}
case 368:{f.Pc=f.Pop().Int!=0?382:371;continue;}
case 371:{f.Push(f.Locals[0]);f.Pc=372;continue;}
case 372:{f.Push(f.Locals[0]);f.Pc=373;continue;}
case 373:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=375;continue;}
case 375:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",378);}
case 378:{f.Push(f.Locals[1]);f.Pc=379;continue;}
case 379:{return rt.Call(f,"forge/game/ability/effects/PumpAllEffect","registerDelayedTrigger","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/Iterable;)V","invokestatic",382);}
case 382:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3583(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("")));f.Pc=10;continue;}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?27:20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",32);}
case 32:{f.StackOp("pop");f.Pc=33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",37);}
case 37:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3584(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("Duration")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",18);}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/ability/effects/PumpAllEffect","checkValidDuration","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokestatic",22);}
case 22:{f.Pc=f.Pop().Int!=0?26:25;continue;}
case 25:{return JStep.ReturnVoid;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("PumpZone")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int==0?54:35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("PumpZone")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",42);}
case 42:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",45);}
case 45:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",50);}
case 50:{f.StackOp("pop");f.Pc=51;continue;}
case 51:{f.Pc=64;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",63);}
case 63:{f.StackOp("pop");f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",68);}
case 68:{f.Pc=f.Pop().Int!=0?90:71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("Defined")));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",77);}
case 77:{f.Pc=f.Pop().Int!=0?90:80;continue;}
case 80:{f.Push(f.Locals[3]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",85);}
case 85:{f.Locals[4]=f.Pop();f.Pc=87;continue;}
case 87:{f.Pc=104;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/ability/effects/PumpAllEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",94);}
case 94:{f.Locals[5]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[5]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/player/PlayerCollection","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollection;","invokevirtual",102);}
case 102:{f.Locals[4]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.String("")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",112);}
case 112:{f.Locals[5]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[4]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[5]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/ability/AbilityUtils","filterListByType","(Lforge/game/card/CardCollectionView;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",122);}
case 122:{f.Locals[4]=f.Pop();f.Pc=124;continue;}
case 124:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",127);}
case 127:{f.Locals[6]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("KW")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",135);}
case 135:{f.Pc=f.Pop().Int==0?160:138;continue;}
case 138:{f.Push(f.Locals[6]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[1]);f.Pc=141;continue;}
case 141:{f.Push(JValue.R(rt.String("KW")));f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",146);}
case 146:{f.Push(JValue.R(rt.String(" & ")));f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",151);}
case 151:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",154);}
case 154:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",159);}
case 159:{f.StackOp("pop");f.Pc=160;continue;}
case 160:{f.Push(f.Locals[1]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",164);}
case 164:{f.Push(f.Locals[1]);f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String("NumAtt")));f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",170);}
case 170:{f.Push(f.Locals[1]);f.Pc=171;continue;}
case 171:{f.Push(JValue.I(1));f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;Z)I","invokestatic",175);}
case 175:{f.Locals[7]=f.Pop();f.Pc=177;continue;}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",181);}
case 181:{f.Push(f.Locals[1]);f.Pc=182;continue;}
case 182:{f.Push(JValue.R(rt.String("NumDef")));f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",187);}
case 187:{f.Push(f.Locals[1]);f.Pc=188;continue;}
case 188:{f.Push(JValue.I(1));f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;Z)I","invokestatic",192);}
case 192:{f.Locals[8]=f.Pop();f.Pc=194;continue;}
case 194:{f.Push(f.Locals[1]);f.Pc=195;continue;}
case 195:{f.Push(JValue.R(rt.String("SharedKeywordsZone")));f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",200);}
case 200:{f.Pc=f.Pop().Int==0?267:203;continue;}
case 203:{f.Push(f.Locals[1]);f.Pc=204;continue;}
case 204:{f.Push(JValue.R(rt.String("SharedKeywordsZone")));f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",209);}
case 209:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",212);}
case 212:{f.Locals[9]=f.Pop();f.Pc=214;continue;}
case 214:{f.Push(JValue.I(1));f.Pc=215;continue;}
case 215:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=218;continue;}
case 218:{f.StackOp("dup");f.Pc=219;continue;}
case 219:{f.Push(JValue.I(0));f.Pc=220;continue;}
case 220:{f.Push(JValue.R(rt.String("Card")));f.Pc=223;continue;}
case 223:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=224;continue;}
case 224:{f.Locals[10]=f.Pop();f.Pc=226;continue;}
case 226:{f.Push(f.Locals[1]);f.Pc=227;continue;}
case 227:{f.Push(JValue.R(rt.String("SharedRestrictions")));f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",233);}
case 233:{f.Pc=f.Pop().Int==0?251:236;continue;}
case 236:{f.Push(f.Locals[1]);f.Pc=237;continue;}
case 237:{f.Push(JValue.R(rt.String("SharedRestrictions")));f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",243);}
case 243:{f.Push(JValue.R(rt.String(",")));f.Pc=246;continue;}
case 246:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",249);}
case 249:{f.Locals[10]=f.Pop();f.Pc=251;continue;}
case 251:{f.Push(f.Locals[6]);f.Pc=253;continue;}
case 253:{f.Push(f.Locals[10]);f.Pc=255;continue;}
case 255:{f.Push(f.Locals[9]);f.Pc=257;continue;}
case 257:{f.Push(f.Locals[1]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",261);}
case 261:{f.Push(f.Locals[1]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/card/CardFactoryUtil","sharedKeywords","(Ljava/lang/Iterable;[Ljava/lang/String;Ljava/lang/Iterable;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/List;","invokestatic",265);}
case 265:{f.Locals[6]=f.Pop();f.Pc=267;continue;}
case 267:{f.Push(f.Locals[1]);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[4]);f.Pc=270;continue;}
case 270:{f.Push(f.Locals[7]);f.Pc=272;continue;}
case 272:{f.Push(f.Locals[8]);f.Pc=274;continue;}
case 274:{f.Push(f.Locals[6]);f.Pc=276;continue;}
case 276:{f.Push(f.Locals[2]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/ability/effects/PumpAllEffect","applyPumpAll","(Lforge/game/spellability/SpellAbility;Ljava/lang/Iterable;IILjava/util/List;Ljava/util/List;)V","invokestatic",280);}
case 280:{f.Push(f.Locals[1]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/ability/effects/PumpAllEffect","replaceDying","(Lforge/game/spellability/SpellAbility;)V","invokestatic",284);}
case 284:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

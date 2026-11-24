// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C638{
internal static JClass Build(){var c=new JClass("forge/game/extrahands/BackupPlanService","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("player","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("multipleHands","Z",false,JValue.Default("Z"),null));
c.Add(new JField("hands","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("hand","Lforge/game/zone/PlayerZone;",false,JValue.Default("Lforge/game/zone/PlayerZone;"),null));
c.Add(new JMethod(7384,"forge/game/extrahands/BackupPlanService","<init>","(Lforge/game/player/Player;)V",1,2,2,new JHandler[]{},M7384));
c.Add(new JMethod(7385,"forge/game/extrahands/BackupPlanService","initializeExtraHands","()Z",1,3,3,new JHandler[]{},M7385));
c.Add(new JMethod(7386,"forge/game/extrahands/BackupPlanService","chooseHand","()V",1,8,4,new JHandler[]{},M7386));
}

internal static JStep M7384(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/extrahands/BackupPlanService","multipleHands","Z",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",13);}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/extrahands/BackupPlanService","hands","Ljava/util/List;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/extrahands/BackupPlanService","player","Lforge/game/player/Player;",value);f.Pc=21;continue;}
case 21:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7385(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","player","Lforge/game/player/Player;"));f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",11);}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/extrahands/BackupPlanService","hand","Lforge/game/zone/PlayerZone;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","hands","Ljava/util/List;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","hand","Lforge/game/zone/PlayerZone;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",27);}
case 27:{f.StackOp("pop");f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","player","Lforge/game/player/Player;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/player/Player","getExtraZones","()Ljava/util/List;","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Reference!=null?43:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","multipleHands","Z"));f.Pc=42;continue;}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","player","Lforge/game/player/Player;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/player/Player","getExtraZones","()Ljava/util/List;","invokevirtual",50);}
case 50:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",55);}
case 55:{f.Locals[1]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",62);}
case 62:{f.Pc=f.Pop().Int==0?115:65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",71);}
case 71:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/PlayerZone"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=74;continue;}
case 74:{f.Locals[2]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/zone/PlayerZone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",79);}
case 79:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","ExtraHand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","ExtraHand","Lforge/game/zone/ZoneType;"));f.Pc=82;continue;}
case 82:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?112:85;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","player","Lforge/game/player/Player;"));f.Pc=89;continue;}
case 89:{f.Push(JValue.I(7));f.Pc=91;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/player/Player","drawCards","(ILforge/game/zone/PlayerZone;)Lforge/game/card/CardCollectionView;","invokevirtual",95);}
case 95:{f.StackOp("pop");f.Pc=96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(JValue.I(1));f.Pc=98;continue;}
case 98:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/extrahands/BackupPlanService","multipleHands","Z",value);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","hands","Ljava/util/List;"));f.Pc=105;continue;}
case 105:{f.Push(f.Locals[2]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",111);}
case 111:{f.StackOp("pop");f.Pc=112;continue;}
case 112:{f.Pc=56;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","player","Lforge/game/player/Player;"));f.Pc=119;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","hand","Lforge/game/zone/PlayerZone;"));f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/player/Player","updateZoneForView","(Lforge/game/zone/PlayerZone;)V","invokevirtual",126);}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","multipleHands","Z"));f.Pc=130;continue;}
case 130:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7386(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","multipleHands","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?8:7;continue;}
case 7:{return JStep.ReturnVoid;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","player","Lforge/game/player/Player;"));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",18);}
case 18:{f.Locals[1]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","player","Lforge/game/player/Player;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",26);}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","hands","Ljava/util/List;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/player/PlayerController","chooseStartingHand","(Ljava/util/List;)Lforge/game/zone/PlayerZone;","invokevirtual",33);}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","hand","Lforge/game/zone/PlayerZone;"));f.Pc=39;continue;}
case 39:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?153:42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","player","Lforge/game/player/Player;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/player/Player","getExtraZones","()Ljava/util/List;","invokevirtual",49);}
case 49:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",54);}
case 54:{f.Locals[3]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",61);}
case 61:{f.Pc=f.Pop().Int==0?150:64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",70);}
case 70:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/PlayerZone"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=73;continue;}
case 73:{f.Locals[4]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/zone/PlayerZone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",80);}
case 80:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","ExtraHand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","ExtraHand","Lforge/game/zone/ZoneType;"));f.Pc=83;continue;}
case 83:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?147:86;continue;}
case 86:{f.Push(f.Locals[4]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",91);}
case 91:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",96);}
case 96:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/util/Iterator;)Ljava/util/ArrayList;","invokestatic",99);}
case 99:{return rt.Call(f,"java/util/ArrayList","iterator","()Ljava/util/Iterator;","invokevirtual",102);}
case 102:{f.Locals[5]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[5]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",111);}
case 111:{f.Pc=f.Pop().Int==0?147:114;continue;}
case 114:{f.Push(f.Locals[5]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",121);}
case 121:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=124;continue;}
case 124:{f.Locals[6]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","player","Lforge/game/player/Player;"));f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",133);}
case 133:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",136);}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[6]);f.Pc=139;continue;}
case 139:{f.Push(JValue.R(null));f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",143);}
case 143:{f.StackOp("pop");f.Pc=144;continue;}
case 144:{f.Pc=104;continue;}
case 147:{f.Pc=55;continue;}
case 150:{f.Pc=347;continue;}
case 153:{f.Push(f.Locals[0]);f.Pc=154;continue;}
case 154:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","hand","Lforge/game/zone/PlayerZone;"));f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",160);}
case 160:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",165);}
case 165:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/util/Iterator;)Ljava/util/ArrayList;","invokestatic",168);}
case 168:{return rt.Call(f,"java/util/ArrayList","iterator","()Ljava/util/Iterator;","invokevirtual",171);}
case 171:{f.Locals[3]=f.Pop();f.Pc=172;continue;}
case 172:{f.Push(f.Locals[3]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",178);}
case 178:{f.Pc=f.Pop().Int==0?213:181;continue;}
case 181:{f.Push(f.Locals[3]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",187);}
case 187:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=190;continue;}
case 190:{f.Locals[4]=f.Pop();f.Pc=192;continue;}
case 192:{f.Push(f.Locals[0]);f.Pc=193;continue;}
case 193:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","player","Lforge/game/player/Player;"));f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",199);}
case 199:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",202);}
case 202:{f.Push(f.Locals[1]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[4]);f.Pc=205;continue;}
case 205:{f.Push(JValue.R(null));f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",209);}
case 209:{f.StackOp("pop");f.Pc=210;continue;}
case 210:{f.Pc=172;continue;}
case 213:{f.Push(f.Locals[0]);f.Pc=214;continue;}
case 214:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","player","Lforge/game/player/Player;"));f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/game/player/Player","getExtraZones","()Ljava/util/List;","invokevirtual",220);}
case 220:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",225);}
case 225:{f.Locals[3]=f.Pop();f.Pc=226;continue;}
case 226:{f.Push(f.Locals[3]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",232);}
case 232:{f.Pc=f.Pop().Int==0?347:235;continue;}
case 235:{f.Push(f.Locals[3]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",241);}
case 241:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/PlayerZone"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=244;continue;}
case 244:{f.Locals[4]=f.Pop();f.Pc=246;continue;}
case 246:{f.Push(f.Locals[2]);f.Pc=247;continue;}
case 247:{f.Push(f.Locals[4]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",252);}
case 252:{f.Locals[5]=f.Pop();f.Pc=254;continue;}
case 254:{f.Push(f.Locals[4]);f.Pc=256;continue;}
case 256:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",259);}
case 259:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",264);}
case 264:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/util/Iterator;)Ljava/util/ArrayList;","invokestatic",267);}
case 267:{return rt.Call(f,"java/util/ArrayList","iterator","()Ljava/util/Iterator;","invokevirtual",270);}
case 270:{f.Locals[6]=f.Pop();f.Pc=272;continue;}
case 272:{f.Push(f.Locals[6]);f.Pc=274;continue;}
case 274:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",279);}
case 279:{f.Pc=f.Pop().Int==0?344:282;continue;}
case 282:{f.Push(f.Locals[6]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",289);}
case 289:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=292;continue;}
case 292:{f.Locals[7]=f.Pop();f.Pc=294;continue;}
case 294:{f.Push(f.Locals[5]);f.Pc=296;continue;}
case 296:{f.Pc=f.Pop().Int==0?323:299;continue;}
case 299:{f.Push(f.Locals[0]);f.Pc=300;continue;}
case 300:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","player","Lforge/game/player/Player;"));f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",306);}
case 306:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",309);}
case 309:{f.Push(f.Locals[0]);f.Pc=310;continue;}
case 310:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","hand","Lforge/game/zone/PlayerZone;"));f.Pc=313;continue;}
case 313:{f.Push(f.Locals[7]);f.Pc=315;continue;}
case 315:{f.Push(JValue.R(null));f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",319);}
case 319:{f.StackOp("pop");f.Pc=320;continue;}
case 320:{f.Pc=341;continue;}
case 323:{f.Push(f.Locals[0]);f.Pc=324;continue;}
case 324:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","player","Lforge/game/player/Player;"));f.Pc=327;continue;}
case 327:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",330);}
case 330:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",333);}
case 333:{f.Push(f.Locals[1]);f.Pc=334;continue;}
case 334:{f.Push(f.Locals[7]);f.Pc=336;continue;}
case 336:{f.Push(JValue.R(null));f.Pc=337;continue;}
case 337:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",340);}
case 340:{f.StackOp("pop");f.Pc=341;continue;}
case 341:{f.Pc=272;continue;}
case 344:{f.Pc=226;continue;}
case 347:{f.Push(f.Locals[0]);f.Pc=348;continue;}
case 348:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","player","Lforge/game/player/Player;"));f.Pc=351;continue;}
case 351:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","ExtraHand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","ExtraHand","Lforge/game/zone/ZoneType;"));f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/game/player/Player","resetExtraZones","(Lforge/game/zone/ZoneType;)V","invokevirtual",357);}
case 357:{f.Push(f.Locals[0]);f.Pc=358;continue;}
case 358:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","player","Lforge/game/player/Player;"));f.Pc=361;continue;}
case 361:{f.Push(f.Locals[0]);f.Pc=362;continue;}
case 362:{f.Push(rt.GetField(f.Pop(),"forge/game/extrahands/BackupPlanService","player","Lforge/game/player/Player;"));f.Pc=365;continue;}
case 365:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=368;continue;}
case 368:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",371);}
case 371:{return rt.Call(f,"forge/game/player/Player","updateZoneForView","(Lforge/game/zone/PlayerZone;)V","invokevirtual",374);}
case 374:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

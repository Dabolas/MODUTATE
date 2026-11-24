// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C689{
internal static JClass Build(){var c=new JClass("forge/game/mulligan/MulliganService","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("firstPlayer","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("game","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JField("mulligans","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(7821,"forge/game/mulligan/MulliganService","<init>","(Lforge/game/player/Player;)V",1,2,2,new JHandler[]{},M7821));
c.Add(new JMethod(7822,"forge/game/mulligan/MulliganService","perform","()V",1,1,1,new JHandler[]{},M7822));
c.Add(new JMethod(7823,"forge/game/mulligan/MulliganService","initializeMulligans","()V",2,8,4,new JHandler[]{},M7823));
c.Add(new JMethod(7824,"forge/game/mulligan/MulliganService","runPlayerMulligans","()V",2,6,3,new JHandler[]{},M7824));
c.Add(new JMethod(7825,"forge/game/mulligan/MulliganService","runPostMulligans","()V",2,3,1,new JHandler[]{},M7825));
}

internal static JStep M7821(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mulligan/MulliganService","mulligans","Ljava/util/List;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mulligan/MulliganService","firstPlayer","Lforge/game/player/Player;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/MulliganService","firstPlayer","Lforge/game/player/Player;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",24);}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mulligan/MulliganService","game","Lforge/game/Game;",value);f.Pc=27;continue;}
case 27:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7822(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/mulligan/MulliganService","initializeMulligans","()V","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/mulligan/MulliganService","runPlayerMulligans","()V","invokevirtual",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/mulligan/MulliganService","runPostMulligans","()V","invokevirtual",12);}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7823(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/MulliganService","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",7);}
case 7:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",10);}
case 10:{f.Locals[1]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/MulliganService","firstPlayer","Lforge/game/player/Player;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/List","indexOf","(Ljava/lang/Object;)I","invokeinterface",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?52:29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/List","remove","(I)Ljava/lang/Object;","invokeinterface",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",45);}
case 45:{f.StackOp("pop");f.Pc=46;continue;}
case 46:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=49;continue;}
case 49:{f.Pc=24;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/MulliganService","game","Lforge/game/Game;"));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",59);}
case 59:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",62);}
case 62:{f.Push(JValue.I(2));f.Pc=63;continue;}
case 63:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?82:66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/MulliganService","game","Lforge/game/Game;"));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",73);}
case 73:{if(!rt.StaticReady(f,"forge/game/GameType","Brawl","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Brawl","Lforge/game/GameType;"));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/GameRules","hasAppliedVariant","(Lforge/game/GameType;)Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int==0?86:82;continue;}
case 82:{f.Push(JValue.I(1));f.Pc=83;continue;}
case 83:{f.Pc=87;continue;}
case 86:{f.Push(JValue.I(0));f.Pc=87;continue;}
case 87:{f.Locals[3]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",94);}
case 94:{f.Locals[4]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[4]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",103);}
case 103:{f.Pc=f.Pop().Int==0?275:106;continue;}
case 106:{f.Push(f.Locals[4]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",113);}
case 113:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=116;continue;}
case 116:{f.Locals[5]=f.Pop();f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",121);}
case 121:{return rt.Call(f,"forge/StaticData","getMulliganRule","()Lforge/MulliganDefs$MulliganRule;","invokevirtual",124);}
case 124:{f.Locals[6]=f.Pop();f.Pc=126;continue;}
case 126:{if(!rt.StaticReady(f,"forge/game/mulligan/MulliganService$1","$SwitchMap$forge$MulliganDefs$MulliganRule","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/mulligan/MulliganService$1","$SwitchMap$forge$MulliganDefs$MulliganRule","[I"));f.Pc=129;continue;}
case 129:{f.Push(f.Locals[6]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/MulliganDefs$MulliganRule","ordinal","()I","invokevirtual",134);}
case 134:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=135;continue;}
case 135:{switch(f.Pop().Int){case 1:f.Pc=168;break;case 2:f.Pc=183;break;case 3:f.Pc=198;break;case 4:f.Pc=213;break;case 5:f.Pc=228;break;default:f.Pc=243;break;}continue;}
case 168:{if(!rt.EnsureInitialized(f,"forge/game/mulligan/OriginalMulligan"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mulligan/OriginalMulligan")));f.Pc=171;continue;}
case 171:{f.StackOp("dup");f.Pc=172;continue;}
case 172:{f.Push(f.Locals[5]);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[3]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/mulligan/OriginalMulligan","<init>","(Lforge/game/player/Player;Z)V","invokespecial",178);}
case 178:{f.Locals[7]=f.Pop();f.Pc=180;continue;}
case 180:{f.Pc=255;continue;}
case 183:{if(!rt.EnsureInitialized(f,"forge/game/mulligan/ParisMulligan"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mulligan/ParisMulligan")));f.Pc=186;continue;}
case 186:{f.StackOp("dup");f.Pc=187;continue;}
case 187:{f.Push(f.Locals[5]);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[3]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/mulligan/ParisMulligan","<init>","(Lforge/game/player/Player;Z)V","invokespecial",193);}
case 193:{f.Locals[7]=f.Pop();f.Pc=195;continue;}
case 195:{f.Pc=255;continue;}
case 198:{if(!rt.EnsureInitialized(f,"forge/game/mulligan/VancouverMulligan"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mulligan/VancouverMulligan")));f.Pc=201;continue;}
case 201:{f.StackOp("dup");f.Pc=202;continue;}
case 202:{f.Push(f.Locals[5]);f.Pc=204;continue;}
case 204:{f.Push(f.Locals[3]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/mulligan/VancouverMulligan","<init>","(Lforge/game/player/Player;Z)V","invokespecial",208);}
case 208:{f.Locals[7]=f.Pop();f.Pc=210;continue;}
case 210:{f.Pc=255;continue;}
case 213:{if(!rt.EnsureInitialized(f,"forge/game/mulligan/LondonMulligan"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mulligan/LondonMulligan")));f.Pc=216;continue;}
case 216:{f.StackOp("dup");f.Pc=217;continue;}
case 217:{f.Push(f.Locals[5]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[3]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/mulligan/LondonMulligan","<init>","(Lforge/game/player/Player;Z)V","invokespecial",223);}
case 223:{f.Locals[7]=f.Pop();f.Pc=225;continue;}
case 225:{f.Pc=255;continue;}
case 228:{if(!rt.EnsureInitialized(f,"forge/game/mulligan/HoustonMulligan"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mulligan/HoustonMulligan")));f.Pc=231;continue;}
case 231:{f.StackOp("dup");f.Pc=232;continue;}
case 232:{f.Push(f.Locals[5]);f.Pc=234;continue;}
case 234:{f.Push(f.Locals[3]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/mulligan/HoustonMulligan","<init>","(Lforge/game/player/Player;Z)V","invokespecial",238);}
case 238:{f.Locals[7]=f.Pop();f.Pc=240;continue;}
case 240:{f.Pc=255;continue;}
case 243:{if(!rt.EnsureInitialized(f,"forge/game/mulligan/VancouverMulligan"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mulligan/VancouverMulligan")));f.Pc=246;continue;}
case 246:{f.StackOp("dup");f.Pc=247;continue;}
case 247:{f.Push(f.Locals[5]);f.Pc=249;continue;}
case 249:{f.Push(f.Locals[3]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"forge/game/mulligan/VancouverMulligan","<init>","(Lforge/game/player/Player;Z)V","invokespecial",253);}
case 253:{f.Locals[7]=f.Pop();f.Pc=255;continue;}
case 255:{f.Push(f.Locals[0]);f.Pc=256;continue;}
case 256:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/MulliganService","mulligans","Ljava/util/List;"));f.Pc=259;continue;}
case 259:{f.Push(f.Locals[7]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",266);}
case 266:{f.StackOp("pop");f.Pc=267;continue;}
case 267:{f.Push(f.Locals[7]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/mulligan/AbstractMulligan","beforeFirstMulligan","()V","invokevirtual",272);}
case 272:{f.Pc=96;continue;}
case 275:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7824(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/MulliganService","mulligans","Ljava/util/List;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?112:21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mulligan/AbstractMulligan"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/mulligan/AbstractMulligan","hasKept","()Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?41:38;continue;}
case 38:{f.Pc=12;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/mulligan/AbstractMulligan","getPlayer","()Lforge/game/player/Player;","invokevirtual",45);}
case 45:{f.Locals[4]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/mulligan/AbstractMulligan","canMulligan","()Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int==0?73:54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",59);}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/MulliganService","firstPlayer","Lforge/game/player/Player;"));f.Pc=63;continue;}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/mulligan/AbstractMulligan","tuckCardsDuringMulligan","()I","invokevirtual",67);}
case 67:{return rt.Call(f,"forge/game/player/PlayerController","mulliganKeepHand","(Lforge/game/player/Player;I)Z","invokevirtual",70);}
case 70:{f.Pc=f.Pop().Int==0?77:73;continue;}
case 73:{f.Push(JValue.I(1));f.Pc=74;continue;}
case 74:{f.Pc=78;continue;}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{f.Locals[5]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/MulliganService","game","Lforge/game/Game;"));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/Game","isGameOver","()Z","invokevirtual",87);}
case 87:{f.Pc=f.Pop().Int==0?91:90;continue;}
case 90:{return JStep.ReturnVoid;}
case 91:{f.Push(f.Locals[5]);f.Pc=93;continue;}
case 93:{f.Pc=f.Pop().Int==0?103:96;continue;}
case 96:{f.Push(f.Locals[3]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/mulligan/AbstractMulligan","keep","()V","invokevirtual",100);}
case 100:{f.Pc=12;continue;}
case 103:{f.Push(JValue.I(0));f.Pc=104;continue;}
case 104:{f.Locals[1]=f.Pop();f.Pc=105;continue;}
case 105:{f.Push(f.Locals[3]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/mulligan/AbstractMulligan","mulligan","()V","invokevirtual",109);}
case 109:{f.Pc=12;continue;}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{f.Pc=f.Pop().Int==0?0:116;continue;}
case 116:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7825(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/MulliganService","mulligans","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?36:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mulligan/AbstractMulligan"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/mulligan/AbstractMulligan","afterMulligan","()V","invokevirtual",33);}
case 33:{f.Pc=10;continue;}
case 36:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C715{
internal static JClass Build(){var c=new JClass("forge/game/player/PlayerOutcome","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("altWinSourceName","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("lossState","Lforge/game/player/GameLossReason;",false,JValue.Default("Lforge/game/player/GameLossReason;"),null));
c.Add(new JField("loseConditionSpell","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(8626,"forge/game/player/PlayerOutcome","<init>","(Ljava/lang/String;Lforge/game/player/GameLossReason;Ljava/lang/String;)V",2,4,2,new JHandler[]{},M8626));
c.Add(new JMethod(8627,"forge/game/player/PlayerOutcome","win","()Lforge/game/player/PlayerOutcome;",9,0,5,new JHandler[]{},M8627));
c.Add(new JMethod(8628,"forge/game/player/PlayerOutcome","draw","()Lforge/game/player/PlayerOutcome;",9,0,5,new JHandler[]{},M8628));
c.Add(new JMethod(8629,"forge/game/player/PlayerOutcome","altWin","(Ljava/lang/String;)Lforge/game/player/PlayerOutcome;",9,1,5,new JHandler[]{},M8629));
c.Add(new JMethod(8630,"forge/game/player/PlayerOutcome","loss","(Lforge/game/player/GameLossReason;Ljava/lang/String;)Lforge/game/player/PlayerOutcome;",9,2,5,new JHandler[]{},M8630));
c.Add(new JMethod(8631,"forge/game/player/PlayerOutcome","concede","()Lforge/game/player/PlayerOutcome;",9,0,5,new JHandler[]{},M8631));
c.Add(new JMethod(8632,"forge/game/player/PlayerOutcome","hasWon","()Z",1,1,1,new JHandler[]{},M8632));
c.Add(new JMethod(8633,"forge/game/player/PlayerOutcome","toString","()Ljava/lang/String;",1,2,3,new JHandler[]{},M8633));
}

internal static JStep M8626(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/PlayerOutcome","altWinSourceName","Ljava/lang/String;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/PlayerOutcome","loseConditionSpell","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/PlayerOutcome","lossState","Lforge/game/player/GameLossReason;",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8627(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerOutcome"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerOutcome")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/player/PlayerOutcome","<init>","(Ljava/lang/String;Lforge/game/player/GameLossReason;Ljava/lang/String;)V","invokespecial",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8628(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerOutcome"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerOutcome")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/player/GameLossReason","IntentionalDraw","Lforge/game/player/GameLossReason;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/GameLossReason","IntentionalDraw","Lforge/game/player/GameLossReason;"));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/player/PlayerOutcome","<init>","(Ljava/lang/String;Lforge/game/player/GameLossReason;Ljava/lang/String;)V","invokespecial",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8629(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerOutcome"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerOutcome")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/player/PlayerOutcome","<init>","(Ljava/lang/String;Lforge/game/player/GameLossReason;Ljava/lang/String;)V","invokespecial",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8630(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerOutcome"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerOutcome")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/player/PlayerOutcome","<init>","(Ljava/lang/String;Lforge/game/player/GameLossReason;Ljava/lang/String;)V","invokespecial",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8631(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerOutcome"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerOutcome")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/player/GameLossReason","Conceded","Lforge/game/player/GameLossReason;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/GameLossReason","Conceded","Lforge/game/player/GameLossReason;"));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/player/PlayerOutcome","<init>","(Ljava/lang/String;Lforge/game/player/GameLossReason;Ljava/lang/String;)V","invokespecial",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8632(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlayerOutcome","lossState","Lforge/game/player/GameLossReason;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8633(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlayerOutcome","lossState","Lforge/game/player/GameLossReason;"));f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference!=null?49:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlayerOutcome","altWinSourceName","Ljava/lang/String;"));f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Reference!=null?29:18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("lblWonBecauseAllOpponentsHaveLost")));f.Pc=21;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",28);}
case 28:{return JStep.Return(f.Pop());}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("lblWonDueToEffectOf")));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",39);}
case 39:{f.Push(JValue.R(rt.String("%s")));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlayerOutcome","altWinSourceName","Ljava/lang/String;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",48);}
case 48:{return JStep.Return(f.Pop());}
case 49:{if(!rt.StaticReady(f,"forge/game/player/PlayerOutcome$1","$SwitchMap$forge$game$player$GameLossReason","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerOutcome$1","$SwitchMap$forge$game$player$GameLossReason","[I"));f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlayerOutcome","lossState","Lforge/game/player/GameLossReason;"));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/player/GameLossReason","ordinal","()I","invokevirtual",59);}
case 59:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=60;continue;}
case 60:{switch(f.Pop().Int){case 1:f.Pc=108;break;case 2:f.Pc=119;break;case 3:f.Pc=130;break;case 4:f.Pc=141;break;case 5:f.Pc=152;break;case 6:f.Pc=172;break;case 7:f.Pc=192;break;case 8:f.Pc=203;break;default:f.Pc=214;break;}continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("lblConceded")));f.Pc=111;continue;}
case 111:{f.Push(JValue.I(0));f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",118);}
case 118:{return JStep.Return(f.Pop());}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{f.Push(JValue.R(rt.String("lblLostTryingToDrawCardsFromEmptyLibrary")));f.Pc=122;continue;}
case 122:{f.Push(JValue.I(0));f.Pc=123;continue;}
case 123:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",129);}
case 129:{return JStep.Return(f.Pop());}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{f.Push(JValue.R(rt.String("lblLostBecauseLifeTotalReachedZero")));f.Pc=133;continue;}
case 133:{f.Push(JValue.I(0));f.Pc=134;continue;}
case 134:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",140);}
case 140:{return JStep.Return(f.Pop());}
case 141:{f.Push(f.Locals[1]);f.Pc=142;continue;}
case 142:{f.Push(JValue.R(rt.String("lblLostBecauseOfObtainingTenPoisonCounters")));f.Pc=144;continue;}
case 144:{f.Push(JValue.I(0));f.Pc=145;continue;}
case 145:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",151);}
case 151:{return JStep.Return(f.Pop());}
case 152:{f.Push(f.Locals[1]);f.Pc=153;continue;}
case 153:{f.Push(JValue.R(rt.String("lblLostBecauseAnOpponentHasWonBySpell")));f.Pc=155;continue;}
case 155:{f.Push(JValue.I(0));f.Pc=156;continue;}
case 156:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",162);}
case 162:{f.Push(JValue.R(rt.String("%s")));f.Pc=164;continue;}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlayerOutcome","loseConditionSpell","Ljava/lang/String;"));f.Pc=168;continue;}
case 168:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",171);}
case 171:{return JStep.Return(f.Pop());}
case 172:{f.Push(f.Locals[1]);f.Pc=173;continue;}
case 173:{f.Push(JValue.R(rt.String("lblLostDueToEffectOfSpell")));f.Pc=175;continue;}
case 175:{f.Push(JValue.I(0));f.Pc=176;continue;}
case 176:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",182);}
case 182:{f.Push(JValue.R(rt.String("%s")));f.Pc=184;continue;}
case 184:{f.Push(f.Locals[0]);f.Pc=185;continue;}
case 185:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlayerOutcome","loseConditionSpell","Ljava/lang/String;"));f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",191);}
case 191:{return JStep.Return(f.Pop());}
case 192:{f.Push(f.Locals[1]);f.Pc=193;continue;}
case 193:{f.Push(JValue.R(rt.String("lblLostDueToAccumulationOf21DamageFromGenerals")));f.Pc=195;continue;}
case 195:{f.Push(JValue.I(0));f.Pc=196;continue;}
case 196:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",202);}
case 202:{return JStep.Return(f.Pop());}
case 203:{f.Push(f.Locals[1]);f.Pc=204;continue;}
case 204:{f.Push(JValue.R(rt.String("lblAcceptedThatTheGameIsADraw")));f.Pc=206;continue;}
case 206:{f.Push(JValue.I(0));f.Pc=207;continue;}
case 207:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",213);}
case 213:{return JStep.Return(f.Pop());}
case 214:{f.Push(f.Locals[1]);f.Pc=215;continue;}
case 215:{f.Push(JValue.R(rt.String("lblLostForUnknownReasonBug")));f.Pc=217;continue;}
case 217:{f.Push(JValue.I(0));f.Pc=218;continue;}
case 218:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=221;continue;}
case 221:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",224);}
case 224:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

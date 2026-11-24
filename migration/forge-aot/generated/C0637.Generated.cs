// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C637{
internal static JClass Build(){var c=new JClass("forge/game/event/IGameEventVisitor$Base","java/lang/Object",new string[]{"forge/game/event/IGameEventVisitor"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(7323,"forge/game/event/IGameEventVisitor$Base","<init>","()V",1,1,1,new JHandler[]{},M7323));
c.Add(new JMethod(7324,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventAnteCardsSelected;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7324));
c.Add(new JMethod(7325,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventAttackersDeclared;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7325));
c.Add(new JMethod(7326,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventBlockersDeclared;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7326));
c.Add(new JMethod(7327,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventCardDamaged;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7327));
c.Add(new JMethod(7328,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventCardDestroyed;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7328));
c.Add(new JMethod(7329,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventCardAttachment;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7329));
c.Add(new JMethod(7330,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventCardChangeZone;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7330));
c.Add(new JMethod(7331,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventCardModeChosen;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7331));
c.Add(new JMethod(7332,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventCardRegenerated;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7332));
c.Add(new JMethod(7333,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventCardSacrificed;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7333));
c.Add(new JMethod(7334,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventCardTapped;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7334));
c.Add(new JMethod(7335,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventCardStatsChanged;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7335));
c.Add(new JMethod(7336,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventCardCounters;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7336));
c.Add(new JMethod(7337,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventCardPhased;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7337));
c.Add(new JMethod(7338,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventCombatChanged;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7338));
c.Add(new JMethod(7339,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventCombatEnded;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7339));
c.Add(new JMethod(7340,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventCombatUpdate;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7340));
c.Add(new JMethod(7341,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventGameFinished;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7341));
c.Add(new JMethod(7342,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventGameOutcome;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7342));
c.Add(new JMethod(7343,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventFlipCoin;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7343));
c.Add(new JMethod(7344,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventFlipOntoBattlefield;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7344));
c.Add(new JMethod(7345,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventGameStarted;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7345));
c.Add(new JMethod(7346,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventGameRestarted;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7346));
c.Add(new JMethod(7347,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventLandPlayed;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7347));
c.Add(new JMethod(7348,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventPlayerLivesChanged;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7348));
c.Add(new JMethod(7349,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventManaPool;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7349));
c.Add(new JMethod(7350,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventManaBurn;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7350));
c.Add(new JMethod(7351,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventMulligan;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7351));
c.Add(new JMethod(7352,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventPlayerControl;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7352));
c.Add(new JMethod(7353,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventPlayerCounters;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7353));
c.Add(new JMethod(7354,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventPlayerPoisoned;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7354));
c.Add(new JMethod(7355,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventPlayerRadiation;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7355));
c.Add(new JMethod(7356,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventPlayerPriority;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7356));
c.Add(new JMethod(7357,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventPlayerShardsChanged;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7357));
c.Add(new JMethod(7358,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventPlayerStatsChanged;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7358));
c.Add(new JMethod(7359,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventRandomLog;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7359));
c.Add(new JMethod(7360,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventRollDie;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7360));
c.Add(new JMethod(7361,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventRollDice;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7361));
c.Add(new JMethod(7362,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventScry;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7362));
c.Add(new JMethod(7363,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventShuffle;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7363));
c.Add(new JMethod(7364,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventSpeedChanged;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7364));
c.Add(new JMethod(7365,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventSpellResolved;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7365));
c.Add(new JMethod(7366,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventSpellAbilityCast;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7366));
c.Add(new JMethod(7367,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventSpellRemovedFromStack;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7367));
c.Add(new JMethod(7368,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventSprocketUpdate;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7368));
c.Add(new JMethod(7369,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventSubgameStart;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7369));
c.Add(new JMethod(7370,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventSubgameEnd;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7370));
c.Add(new JMethod(7371,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventSurveil;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7371));
c.Add(new JMethod(7372,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventTokenCreated;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7372));
c.Add(new JMethod(7373,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventTurnBegan;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7373));
c.Add(new JMethod(7374,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventTurnEnded;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7374));
c.Add(new JMethod(7375,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventTurnPhase;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7375));
c.Add(new JMethod(7376,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventPlayerDamaged;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7376));
c.Add(new JMethod(7377,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventZone;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7377));
c.Add(new JMethod(7378,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventCardForetold;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7378));
c.Add(new JMethod(7379,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventCardPlotted;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7379));
c.Add(new JMethod(7380,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventDayTimeChanged;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7380));
c.Add(new JMethod(7381,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventDoorChanged;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7381));
c.Add(new JMethod(7382,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventSnapshotRestored;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7382));
c.Add(new JMethod(7383,"forge/game/event/IGameEventVisitor$Base","visit","(Lforge/game/event/GameEventAddLog;)Ljava/lang/Object;",1,2,1,new JHandler[]{},M7383));
}

internal static JStep M7323(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7324(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7325(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7326(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7327(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7328(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7329(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7330(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7331(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7332(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7333(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7334(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7335(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7336(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7337(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7338(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7339(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7340(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7341(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7342(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7343(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7344(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7345(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7346(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7347(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7348(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7349(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7350(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7351(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7352(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7353(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7354(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7355(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7356(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7357(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7358(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7359(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7360(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7361(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7362(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7363(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7364(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7365(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7366(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7367(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7368(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7369(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7370(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7371(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7372(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7373(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7374(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7375(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7376(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7377(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7378(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7379(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7380(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7381(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7382(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7383(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

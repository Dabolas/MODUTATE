// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C636{
internal static JClass Build(){var c=new JClass("forge/game/event/IGameEventVisitor","java/lang/Object",new string[]{},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(7263,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventAnteCardsSelected;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7264,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventAttackersDeclared;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7265,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventBlockersDeclared;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7266,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCardDamaged;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7267,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCardDestroyed;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7268,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCardAttachment;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7269,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCardChangeZone;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7270,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCardModeChosen;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7271,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCardRegenerated;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7272,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCardSacrificed;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7273,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCardPhased;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7274,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCardTapped;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7275,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCardStatsChanged;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7276,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCardCounters;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7277,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCombatChanged;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7278,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCombatEnded;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7279,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCombatUpdate;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7280,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventGameFinished;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7281,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventGameOutcome;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7282,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventFlipCoin;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7283,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventFlipOntoBattlefield;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7284,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventGameStarted;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7285,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventGameRestarted;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7286,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventLandPlayed;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7287,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventPlayerLivesChanged;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7288,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventManaPool;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7289,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventManaBurn;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7290,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventMulligan;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7291,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventPlayerControl;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7292,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventPlayerDamaged;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7293,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventPlayerCounters;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7294,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventPlayerPoisoned;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7295,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventPlayerRadiation;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7296,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventPlayerPriority;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7297,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventPlayerShardsChanged;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7298,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventPlayerStatsChanged;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7299,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventRandomLog;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7300,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventRollDie;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7301,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventRollDice;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7302,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventScry;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7303,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventShuffle;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7304,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventSpeedChanged;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7305,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventSpellAbilityCast;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7306,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventSpellResolved;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7307,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventSpellRemovedFromStack;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7308,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventSprocketUpdate;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7309,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventSubgameStart;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7310,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventSubgameEnd;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7311,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventSurveil;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7312,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventTokenCreated;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7313,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventTurnBegan;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7314,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventTurnEnded;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7315,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventTurnPhase;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7316,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventZone;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7317,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCardForetold;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7318,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCardPlotted;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7319,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventDayTimeChanged;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7320,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventDoorChanged;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7321,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventSnapshotRestored;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7322,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventAddLog;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
}
}}

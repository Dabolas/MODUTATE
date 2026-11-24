// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C130{
internal static JClass Build(){var c=new JClass("forge/game/Game","java/lang/Object",new string[]{},33);Add0(c);Add1(c);Add2(c);Add3(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("netLog","Lorg/tinylog/TaggedLogger;",true,JValue.Default("Lorg/tinylog/TaggedLogger;"),null));
c.Add(new JField("maxId","I",true,JValue.Default("I"),null));
c.Add(new JField("noGUIUser","Z",false,JValue.Default("Z"),null));
c.Add(new JField("id","I",false,JValue.Default("I"),null));
c.Add(new JField("rules","Lforge/game/GameRules;",false,JValue.Default("Lforge/game/GameRules;"),null));
c.Add(new JField("allPlayers","Lforge/game/player/PlayerCollection;",false,JValue.Default("Lforge/game/player/PlayerCollection;"),null));
c.Add(new JField("ingamePlayers","Lforge/game/player/PlayerCollection;",false,JValue.Default("Lforge/game/player/PlayerCollection;"),null));
c.Add(new JField("lostPlayers","Lforge/game/player/PlayerCollection;",false,JValue.Default("Lforge/game/player/PlayerCollection;"),null));
c.Add(new JField("playerCache","Lforge/game/GameEntityViewMap;",false,JValue.Default("Lforge/game/GameEntityViewMap;"),null));
c.Add(new JField("activePlanes","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("untap","Lforge/game/phase/Untap;",false,JValue.Default("Lforge/game/phase/Untap;"),null));
c.Add(new JField("upkeep","Lforge/game/phase/Phase;",false,JValue.Default("Lforge/game/phase/Phase;"),null));
c.Add(new JField("beginOfCombat","Lforge/game/phase/Phase;",false,JValue.Default("Lforge/game/phase/Phase;"),null));
c.Add(new JField("endOfCombat","Lforge/game/phase/Phase;",false,JValue.Default("Lforge/game/phase/Phase;"),null));
c.Add(new JField("endOfTurn","Lforge/game/phase/Phase;",false,JValue.Default("Lforge/game/phase/Phase;"),null));
c.Add(new JField("cleanup","Lforge/game/phase/Phase;",false,JValue.Default("Lforge/game/phase/Phase;"),null));
c.Add(new JField("sbaCheckedCommandList","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("stack","Lforge/game/zone/MagicStack;",false,JValue.Default("Lforge/game/zone/MagicStack;"),null));
c.Add(new JField("costPaymentStack","Lforge/game/zone/CostPaymentStack;",false,JValue.Default("Lforge/game/zone/CostPaymentStack;"),null));
c.Add(new JField("phaseHandler","Lforge/game/phase/PhaseHandler;",false,JValue.Default("Lforge/game/phase/PhaseHandler;"),null));
c.Add(new JField("staticEffects","Lforge/game/StaticEffects;",false,JValue.Default("Lforge/game/StaticEffects;"),null));
c.Add(new JField("triggerHandler","Lforge/game/trigger/TriggerHandler;",false,JValue.Default("Lforge/game/trigger/TriggerHandler;"),null));
c.Add(new JField("replacementHandler","Lforge/game/replacement/ReplacementHandler;",false,JValue.Default("Lforge/game/replacement/ReplacementHandler;"),null));
c.Add(new JField("events","Lcom/google/common/eventbus/EventBus;",false,JValue.Default("Lcom/google/common/eventbus/EventBus;"),null));
c.Add(new JField("gameLog","Lforge/game/GameLog;",false,JValue.Default("Lforge/game/GameLog;"),null));
c.Add(new JField("stackZone","Lforge/game/zone/Zone;",false,JValue.Default("Lforge/game/zone/Zone;"),null));
c.Add(new JField("AI_TIMEOUT","I",false,JValue.Default("I"),null));
c.Add(new JField("AI_FLAT_MONTE_CARLO","Z",false,JValue.Default("Z"),null));
c.Add(new JField("AI_FLAT_MONTE_CARLO_MAX","Z",false,JValue.Default("Z"),null));
c.Add(new JField("AI_FLAT_MONTE_CARLO_LITE","Z",false,JValue.Default("Z"),null));
c.Add(new JField("EXPERIMENTAL_RESTORE_SNAPSHOT","Z",false,JValue.Default("Z"),null));
c.Add(new JField("simulationCopy","Z",false,JValue.Default("Z"),null));
c.Add(new JField("previousGameState","Lforge/game/GameSnapshot;",false,JValue.Default("Lforge/game/GameSnapshot;"),null));
c.Add(new JField("lastStateBattlefield","Lforge/game/card/CardCollection;",false,JValue.Default("Lforge/game/card/CardCollection;"),null));
c.Add(new JField("lastStateGraveyard","Lforge/game/card/CardCollection;",false,JValue.Default("Lforge/game/card/CardCollection;"),null));
c.Add(new JField("untilHostLeavesPlayTriggerList","Lforge/game/card/CardZoneTable;",false,JValue.Default("Lforge/game/card/CardZoneTable;"),null));
c.Add(new JField("countersAddedThisTurn","Lcom/google/common/collect/Table;",false,JValue.Default("Lcom/google/common/collect/Table;"),null));
c.Add(new JField("countersRemovedThisTurn","Lcom/google/common/collect/Multimap;",false,JValue.Default("Lcom/google/common/collect/Multimap;"),null));
c.Add(new JField("leftBattlefieldThisTurn","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("leftGraveyardThisTurn","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("globalDamageHistory","Lforge/util/collect/FCollection;",false,JValue.Default("Lforge/util/collect/FCollection;"),null));
c.Add(new JField("damageThisTurnLKI","Ljava/util/IdentityHashMap;",false,JValue.Default("Ljava/util/IdentityHashMap;"),null));
c.Add(new JField("topLibsCast","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("facedownWhileCasting","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("initiative","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("monarch","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("monarchBeginTurn","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("startingPlayer","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("turnOrder","Lforge/game/Direction;",false,JValue.Default("Lforge/game/Direction;"),null));
c.Add(new JField("daytime","Ljava/lang/Boolean;",false,JValue.Default("Ljava/lang/Boolean;"),null));
c.Add(new JField("numPiledGuessedSA","I",false,JValue.Default("I"),null));
c.Add(new JField("timestamp","J",false,JValue.Default("J"),null));
c.Add(new JField("action","Lforge/game/GameAction;",false,JValue.Default("Lforge/game/GameAction;"),null));
c.Add(new JField("match","Lforge/game/Match;",false,JValue.Default("Lforge/game/Match;"),null));
c.Add(new JField("age","Lforge/game/GameStage;",false,JValue.Default("Lforge/game/GameStage;"),null));
c.Add(new JField("outcome","Lforge/game/GameOutcome;",false,JValue.Default("Lforge/game/GameOutcome;"),null));
c.Add(new JField("drawOffer","Lforge/game/DrawOffer;",false,JValue.Default("Lforge/game/DrawOffer;"),null));
c.Add(new JField("maingame","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JField("view","Lforge/game/GameView;",false,JValue.Default("Lforge/game/GameView;"),null));
c.Add(new JField("tracker","Lforge/trackable/Tracker;",false,JValue.Default("Lforge/trackable/Tracker;"),null));
c.Add(new JField("undoManager","Lforge/game/undo/UndoManager;",false,JValue.Default("Lforge/game/undo/UndoManager;"),null));
c.Add(new JField("changeZoneLKIInfo","Lcom/google/common/collect/Table;",false,JValue.Default("Lcom/google/common/collect/Table;"),null));
c.Add(new JField("ALL_ZONE_TYPES","[Lforge/game/zone/ZoneType;",true,JValue.Default("[Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("cardIdCounter","I",false,JValue.Default("I"),null));
}

private static void Add1(JClass c){
c.Add(new JField("hiddenCardIdCounter","I",false,JValue.Default("I"),null));
c.Add(new JMethod(1875,"forge/game/Game","nextId","()I",10,0,2,new JHandler[]{},M1875));
c.Add(new JMethod(1876,"forge/game/Game","isSimulationCopy","()Z",1,1,1,new JHandler[]{},M1876));
c.Add(new JMethod(1877,"forge/game/Game","markAsSimulationCopy","()V",1,1,2,new JHandler[]{},M1877));
c.Add(new JMethod(1878,"forge/game/Game","getId","()I",1,1,1,new JHandler[]{},M1878));
c.Add(new JMethod(1879,"forge/game/Game","getStartingPlayer","()Lforge/game/player/Player;",1,1,1,new JHandler[]{},M1879));
c.Add(new JMethod(1880,"forge/game/Game","setStartingPlayer","(Lforge/game/player/Player;)V",1,2,2,new JHandler[]{},M1880));
c.Add(new JMethod(1881,"forge/game/Game","getDrawOffer","()Lforge/game/DrawOffer;",1,1,1,new JHandler[]{},M1881));
c.Add(new JMethod(1882,"forge/game/Game","setDrawOffer","(Lforge/game/DrawOffer;)V",1,2,2,new JHandler[]{},M1882));
c.Add(new JMethod(1883,"forge/game/Game","getMonarch","()Lforge/game/player/Player;",1,1,1,new JHandler[]{},M1883));
c.Add(new JMethod(1884,"forge/game/Game","setMonarch","(Lforge/game/player/Player;)V",1,2,2,new JHandler[]{},M1884));
c.Add(new JMethod(1885,"forge/game/Game","getMonarchBeginTurn","()Lforge/game/player/Player;",1,1,1,new JHandler[]{},M1885));
c.Add(new JMethod(1886,"forge/game/Game","setMonarchBeginTurn","(Lforge/game/player/Player;)V",1,2,2,new JHandler[]{},M1886));
c.Add(new JMethod(1887,"forge/game/Game","getHasInitiative","()Lforge/game/player/Player;",1,1,1,new JHandler[]{},M1887));
c.Add(new JMethod(1888,"forge/game/Game","setHasInitiative","(Lforge/game/player/Player;)V",1,2,2,new JHandler[]{},M1888));
c.Add(new JMethod(1889,"forge/game/Game","getUntilHostLeavesPlayTriggerList","()Lforge/game/card/CardZoneTable;",1,1,1,new JHandler[]{},M1889));
c.Add(new JMethod(1890,"forge/game/Game","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;",1,1,1,new JHandler[]{},M1890));
c.Add(new JMethod(1891,"forge/game/Game","getLastStateGraveyard","()Lforge/game/card/CardCollectionView;",1,1,1,new JHandler[]{},M1891));
c.Add(new JMethod(1892,"forge/game/Game","getUndoManager","()Lforge/game/undo/UndoManager;",1,1,1,new JHandler[]{},M1892));
c.Add(new JMethod(1893,"forge/game/Game","stashGameState","()V",1,1,4,new JHandler[]{},M1893));
c.Add(new JMethod(1894,"forge/game/Game","restoreGameState","()Z",1,1,2,new JHandler[]{},M1894));
c.Add(new JMethod(1895,"forge/game/Game","copyLastState","()V",1,4,3,new JHandler[]{},M1895));
c.Add(new JMethod(1896,"forge/game/Game","copyLastState","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;",1,6,3,new JHandler[]{},M1896));
c.Add(new JMethod(1897,"forge/game/Game","copyLastStateBattlefield","()Lforge/game/card/CardCollectionView;",1,1,2,new JHandler[]{},M1897));
c.Add(new JMethod(1898,"forge/game/Game","copyLastStateGraveyard","()Lforge/game/card/CardCollectionView;",1,1,2,new JHandler[]{},M1898));
c.Add(new JMethod(1899,"forge/game/Game","updateLastStateForCard","(Lforge/game/card/Card;)V",1,4,2,new JHandler[]{},M1899));
c.Add(new JMethod(1900,"forge/game/Game","getPlayer","(Lforge/game/player/PlayerView;)Lforge/game/player/Player;",1,2,2,new JHandler[]{},M1900));
c.Add(new JMethod(1901,"forge/game/Game","getPlayer","(I)Lforge/game/player/Player;",1,4,2,new JHandler[]{},M1901));
c.Add(new JMethod(1902,"forge/game/Game","addChangeZoneLKIInfo","(Lforge/game/card/Card;)V",17,2,4,new JHandler[]{},M1902));
c.Add(new JMethod(1903,"forge/game/Game","getChangeZoneLKIInfo","(Lforge/game/card/Card;)Lforge/game/card/Card;",17,2,4,new JHandler[]{},M1903));
c.Add(new JMethod(1904,"forge/game/Game","clearChangeZoneLKIInfo","()V",17,1,1,new JHandler[]{},M1904));
c.Add(new JMethod(1905,"forge/game/Game","addLeftBattlefieldThisTurn","(Lforge/game/card/Card;)V",1,2,2,new JHandler[]{},M1905));
c.Add(new JMethod(1906,"forge/game/Game","addLeftGraveyardThisTurn","(Lforge/game/card/Card;)V",1,2,2,new JHandler[]{},M1906));
c.Add(new JMethod(1907,"forge/game/Game","getLeftBattlefieldThisTurn","()Ljava/util/List;",1,1,1,new JHandler[]{},M1907));
c.Add(new JMethod(1908,"forge/game/Game","getLeftGraveyardThisTurn","()Ljava/util/List;",1,1,1,new JHandler[]{},M1908));
c.Add(new JMethod(1909,"forge/game/Game","clearLeftBattlefieldThisTurn","()V",1,1,1,new JHandler[]{},M1909));
c.Add(new JMethod(1910,"forge/game/Game","clearLeftGraveyardThisTurn","()V",1,1,1,new JHandler[]{},M1910));
c.Add(new JMethod(1911,"forge/game/Game","<init>","(Ljava/lang/Iterable;Lforge/game/GameRules;Lforge/game/Match;)V",1,4,6,new JHandler[]{},M1911));
c.Add(new JMethod(1912,"forge/game/Game","<init>","(Ljava/lang/Iterable;Lforge/game/GameRules;Lforge/game/Match;Lforge/game/Game;I)V",1,14,5,new JHandler[]{},M1912));
c.Add(new JMethod(1913,"forge/game/Game","getView","()Lforge/game/GameView;",1,1,1,new JHandler[]{},M1913));
c.Add(new JMethod(1914,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;",1,1,1,new JHandler[]{},M1914));
c.Add(new JMethod(1915,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;",17,1,1,new JHandler[]{},M1915));
c.Add(new JMethod(1916,"forge/game/Game","getLostPlayers","()Lforge/game/player/PlayerCollection;",17,1,1,new JHandler[]{},M1916));
c.Add(new JMethod(1917,"forge/game/Game","getPlayersInTurnOrder","()Lforge/game/player/PlayerCollection;",17,2,3,new JHandler[]{},M1917));
c.Add(new JMethod(1918,"forge/game/Game","getPlayersInTurnOrder","(Lforge/game/player/Player;)Lforge/game/player/PlayerCollection;",17,5,3,new JHandler[]{},M1918));
c.Add(new JMethod(1919,"forge/game/Game","getRegisteredPlayers","()Lforge/game/player/PlayerCollection;",17,1,1,new JHandler[]{},M1919));
c.Add(new JMethod(1920,"forge/game/Game","getUntap","()Lforge/game/phase/Untap;",17,1,1,new JHandler[]{},M1920));
c.Add(new JMethod(1921,"forge/game/Game","getUpkeep","()Lforge/game/phase/Phase;",17,1,1,new JHandler[]{},M1921));
c.Add(new JMethod(1922,"forge/game/Game","getBeginOfCombat","()Lforge/game/phase/Phase;",17,1,1,new JHandler[]{},M1922));
c.Add(new JMethod(1923,"forge/game/Game","getEndOfCombat","()Lforge/game/phase/Phase;",17,1,1,new JHandler[]{},M1923));
c.Add(new JMethod(1924,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;",17,1,1,new JHandler[]{},M1924));
c.Add(new JMethod(1925,"forge/game/Game","getCleanup","()Lforge/game/phase/Phase;",17,1,1,new JHandler[]{},M1925));
c.Add(new JMethod(1926,"forge/game/Game","addSBACheckedCommand","(Lforge/GameCommand;)V",1,2,2,new JHandler[]{},M1926));
c.Add(new JMethod(1927,"forge/game/Game","runSBACheckedCommands","()V",17,3,1,new JHandler[]{},M1927));
c.Add(new JMethod(1928,"forge/game/Game","getStaticEffects","()Lforge/game/StaticEffects;",17,1,1,new JHandler[]{},M1928));
c.Add(new JMethod(1929,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;",17,1,1,new JHandler[]{},M1929));
c.Add(new JMethod(1930,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;",17,1,1,new JHandler[]{},M1930));
c.Add(new JMethod(1931,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;",17,1,1,new JHandler[]{},M1931));
c.Add(new JMethod(1932,"forge/game/Game","updateTurnForView","()V",17,1,2,new JHandler[]{},M1932));
c.Add(new JMethod(1933,"forge/game/Game","updatePhaseForView","()V",17,1,2,new JHandler[]{},M1933));
c.Add(new JMethod(1934,"forge/game/Game","updatePlayerTurnForView","()V",17,1,2,new JHandler[]{},M1934));
c.Add(new JMethod(1935,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;",17,1,1,new JHandler[]{},M1935));
c.Add(new JMethod(1936,"forge/game/Game","updateStackForView","()V",17,1,2,new JHandler[]{},M1936));
c.Add(new JMethod(1937,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;",17,1,1,new JHandler[]{},M1937));
}

private static void Add2(JClass c){
c.Add(new JMethod(1938,"forge/game/Game","updateCombatForView","()V",17,1,2,new JHandler[]{},M1938));
c.Add(new JMethod(1939,"forge/game/Game","getGameLog","()Lforge/game/GameLog;",17,1,1,new JHandler[]{},M1939));
c.Add(new JMethod(1940,"forge/game/Game","getStackZone","()Lforge/game/zone/Zone;",17,1,1,new JHandler[]{},M1940));
c.Add(new JMethod(1941,"forge/game/Game","getCardsPlayerCanActivateInStack","()Lforge/game/card/CardCollectionView;",1,1,2,new JHandler[]{},M1941));
c.Add(new JMethod(1942,"forge/game/Game","getTurnOrder","()Lforge/game/Direction;",17,1,1,new JHandler[]{},M1942));
c.Add(new JMethod(1943,"forge/game/Game","reverseTurnOrder","()V",17,1,2,new JHandler[]{},M1943));
c.Add(new JMethod(1944,"forge/game/Game","resetTurnOrder","()V",17,1,2,new JHandler[]{},M1944));
c.Add(new JMethod(1945,"forge/game/Game","getNextTimestamp","()J",17,1,5,new JHandler[]{},M1945));
c.Add(new JMethod(1946,"forge/game/Game","getTimestamp","()J",17,1,2,new JHandler[]{},M1946));
c.Add(new JMethod(1947,"forge/game/Game","dangerouslySetTimestamp","(J)V",1,3,3,new JHandler[]{},M1947));
c.Add(new JMethod(1948,"forge/game/Game","dangerouslySyncCardIdCounters","(Lforge/game/Game;)V",1,2,2,new JHandler[]{},M1948));
c.Add(new JMethod(1949,"forge/game/Game","getOutcome","()Lforge/game/GameOutcome;",17,1,1,new JHandler[]{},M1949));
c.Add(new JMethod(1950,"forge/game/Game","getMaingame","()Lforge/game/Game;",17,1,1,new JHandler[]{},M1950));
c.Add(new JMethod(1951,"forge/game/Game","isGameOver","()Z",33,1,2,new JHandler[]{},M1951));
c.Add(new JMethod(1952,"forge/game/Game","setGameOver","(Lforge/game/GameEndReason;)V",33,4,5,new JHandler[]{},M1952));
c.Add(new JMethod(1953,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;",1,2,1,new JHandler[]{},M1953));
c.Add(new JMethod(1954,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;",1,2,2,new JHandler[]{},M1954));
c.Add(new JMethod(1955,"forge/game/Game","getCardsIncludePhasingIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;",1,6,4,new JHandler[]{},M1955));
c.Add(new JMethod(1956,"forge/game/Game","addCardsIn","(Lforge/game/card/CardCollection;Lforge/game/zone/ZoneType;Lforge/game/player/PlayerCollection;I)V",2,6,3,new JHandler[]{},M1956));
c.Add(new JMethod(1957,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;",1,10,5,new JHandler[]{},M1957));
c.Add(new JMethod(1958,"forge/game/Game","getCardsInOwnedBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollectionView;",1,11,3,new JHandler[]{},M1958));
c.Add(new JMethod(1959,"forge/game/Game","isCardExiled","(Lforge/game/card/Card;)Z",1,2,2,new JHandler[]{},M1959));
c.Add(new JMethod(1960,"forge/game/Game","isCardInPlay","(Ljava/lang/String;)Z",1,2,2,new JHandler[]{},M1960));
c.Add(new JMethod(1961,"forge/game/Game","isCardInCommand","(Ljava/lang/String;)Z",1,2,2,new JHandler[]{},M1961));
c.Add(new JMethod(1962,"forge/game/Game","getColoredCardsInPlay","(B)Lforge/game/card/CardCollectionView;",1,6,3,new JHandler[]{},M1962));
c.Add(new JMethod(1963,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;",1,2,3,new JHandler[]{},M1963));
c.Add(new JMethod(1964,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;",1,4,3,new JHandler[]{},M1964));
c.Add(new JMethod(1965,"forge/game/Game","findByView","(Lforge/game/card/CardView;)Lforge/game/card/Card;",1,4,6,new JHandler[]{},M1965));
c.Add(new JMethod(1966,"forge/game/Game","findById","(I)Lforge/game/card/Card;",1,3,3,new JHandler[]{},M1966));
c.Add(new JMethod(1967,"forge/game/Game","forEachCardInGame","(Lforge/util/Visitor;)V",1,2,3,new JHandler[]{},M1967));
c.Add(new JMethod(1968,"forge/game/Game","forEachCardInGame","(Lforge/util/Visitor;Z)V",1,5,3,new JHandler[]{},M1968));
c.Add(new JMethod(1969,"forge/game/Game","getCardsInGame","()Lforge/game/card/CardCollectionView;",1,6,3,new JHandler[]{},M1969));
c.Add(new JMethod(1970,"forge/game/Game","getAction","()Lforge/game/GameAction;",17,1,1,new JHandler[]{},M1970));
c.Add(new JMethod(1971,"forge/game/Game","getMatch","()Lforge/game/Match;",17,1,1,new JHandler[]{},M1971));
c.Add(new JMethod(1972,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;)Lforge/game/player/Player;",1,2,3,new JHandler[]{},M1972));
c.Add(new JMethod(1973,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;Lforge/game/Direction;)Lforge/game/player/Player;",1,7,3,new JHandler[]{},M1973));
c.Add(new JMethod(1974,"forge/game/Game","getPosition","(Lforge/game/player/Player;Lforge/game/player/Player;)I",1,5,2,new JHandler[]{},M1974));
c.Add(new JMethod(1975,"forge/game/Game","onPlayerLost","(Lforge/game/player/Player;)V",1,11,4,new JHandler[]{},M1975));
c.Add(new JMethod(1976,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V",1,2,2,new JHandler[]{},M1976));
c.Add(new JMethod(1977,"forge/game/Game","subscribeToEvents","(Ljava/lang/Object;)V",1,2,2,new JHandler[]{},M1977));
c.Add(new JMethod(1978,"forge/game/Game","getRules","()Lforge/game/GameRules;",1,1,1,new JHandler[]{},M1978));
c.Add(new JMethod(1979,"forge/game/Game","getActivePlanes","()Ljava/util/List;",1,1,1,new JHandler[]{},M1979));
c.Add(new JMethod(1980,"forge/game/Game","setActivePlanes","(Ljava/util/List;)V",1,2,2,new JHandler[]{},M1980));
c.Add(new JMethod(1981,"forge/game/Game","getAge","()Lforge/game/GameStage;",1,1,1,new JHandler[]{},M1981));
c.Add(new JMethod(1982,"forge/game/Game","setAge","(Lforge/game/GameStage;)V",1,2,2,new JHandler[]{},M1982));
c.Add(new JMethod(1983,"forge/game/Game","nextCardId","()I",1,1,3,new JHandler[]{},M1983));
c.Add(new JMethod(1984,"forge/game/Game","nextHiddenCardId","()I",1,1,3,new JHandler[]{},M1984));
c.Add(new JMethod(1985,"forge/game/Game","chooseCardsForAnte","(ZZ)Lcom/google/common/collect/Multimap;",1,13,4,new JHandler[]{},M1985));
c.Add(new JMethod(1986,"forge/game/Game","chooseRandomCardsForAnte","(Lforge/game/player/Player;Lcom/google/common/collect/Multimap;Z)V",2,7,5,new JHandler[]{},M1986));
c.Add(new JMethod(1987,"forge/game/Game","getValidRarities","(Ljava/lang/Iterable;)Ljava/util/Set;",10,4,2,new JHandler[]{},M1987));
c.Add(new JMethod(1988,"forge/game/Game","clearCaches","()V",1,1,1,new JHandler[]{},M1988));
c.Add(new JMethod(1989,"forge/game/Game","isGraveyardOrdered","(Lforge/game/player/Player;)Z",1,4,3,new JHandler[]{},M1989));
c.Add(new JMethod(1990,"forge/game/Game","getControlVote","()Lforge/game/player/Player;",1,7,4,new JHandler[]{},M1990));
c.Add(new JMethod(1991,"forge/game/Game","incPiledGuessedSA","()V",1,1,3,new JHandler[]{},M1991));
c.Add(new JMethod(1992,"forge/game/Game","getNumPiledGuessedSA","()I",1,1,1,new JHandler[]{},M1992));
c.Add(new JMethod(1993,"forge/game/Game","resetNumPiledGuessedSA","()V",1,1,2,new JHandler[]{},M1993));
c.Add(new JMethod(1994,"forge/game/Game","onCleanupPhase","()V",1,3,3,new JHandler[]{},M1994));
c.Add(new JMethod(1995,"forge/game/Game","addCounterAddedThisTurn","(Lforge/game/player/Player;Lforge/game/card/CounterType;Lforge/game/card/Card;Ljava/lang/Integer;)V",1,6,4,new JHandler[]{},M1995));
c.Add(new JMethod(1996,"forge/game/Game","getCounterAddedThisTurn","(Lforge/game/card/CounterType;Ljava/lang/String;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/CardTraitBase;)I",1,15,5,new JHandler[]{},M1996));
c.Add(new JMethod(1997,"forge/game/Game","getCounterAddedThisTurn","(Lforge/game/card/CounterType;Lforge/game/card/Card;)I",1,11,4,new JHandler[]{},M1997));
c.Add(new JMethod(1998,"forge/game/Game","clearCountersThisTurn","()V",1,1,1,new JHandler[]{},M1998));
c.Add(new JMethod(1999,"forge/game/Game","addCounterRemovedThisTurn","(Lforge/game/card/CounterType;Lforge/game/card/Card;Ljava/lang/Integer;)V",1,4,4,new JHandler[]{},M1999));
c.Add(new JMethod(2000,"forge/game/Game","addCounterRemovedThisTurn","(Lforge/game/card/CounterType;Lforge/game/player/Player;Ljava/lang/Integer;)V",1,4,4,new JHandler[]{},M2000));
c.Add(new JMethod(2001,"forge/game/Game","getCounterRemovedThisTurn","(Lforge/game/card/CounterType;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/CardTraitBase;)I",1,9,5,new JHandler[]{},M2001));
}

private static void Add3(JClass c){
c.Add(new JMethod(2002,"forge/game/Game","getDamageDoneThisTurn","(Ljava/lang/Boolean;ZLjava/lang/String;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/CardTraitBase;)Ljava/util/List;",1,12,8,new JHandler[]{},M2002));
c.Add(new JMethod(2003,"forge/game/Game","getSingleMaxDamageDoneThisTurn","()I",1,1,2,new JHandler[]{},M2003));
c.Add(new JMethod(2004,"forge/game/Game","addGlobalDamageHistory","(Lforge/game/card/CardDamageHistory;Lorg/apache/commons/lang3/tuple/Pair;Lforge/game/card/Card;Lforge/game/GameEntity;)V",1,5,4,new JHandler[]{},M2004));
c.Add(new JMethod(2005,"forge/game/Game","clearGlobalDamageHistory","()V",1,1,1,new JHandler[]{},M2005));
c.Add(new JMethod(2006,"forge/game/Game","getDamageLKI","(Lorg/apache/commons/lang3/tuple/Pair;)Lorg/apache/commons/lang3/tuple/Pair;",1,2,2,new JHandler[]{},M2006));
c.Add(new JMethod(2007,"forge/game/Game","getTopLibForPlayer","(Lforge/game/player/Player;)Lforge/game/card/Card;",1,2,2,new JHandler[]{},M2007));
c.Add(new JMethod(2008,"forge/game/Game","setTopLibsCast","()V",1,3,4,new JHandler[]{},M2008));
c.Add(new JMethod(2009,"forge/game/Game","clearTopLibsCast","(Lforge/game/spellability/SpellAbility;)V",1,5,4,new JHandler[]{},M2009));
c.Add(new JMethod(2010,"forge/game/Game","addFacedownWhileCasting","(Lforge/game/card/Card;I)V",1,3,3,new JHandler[]{},M2010));
c.Add(new JMethod(2011,"forge/game/Game","isDay","()Z",1,1,1,new JHandler[]{},M2011));
c.Add(new JMethod(2012,"forge/game/Game","isNight","()Z",1,1,2,new JHandler[]{},M2012));
c.Add(new JMethod(2013,"forge/game/Game","isNeitherDayNorNight","()Z",1,1,1,new JHandler[]{},M2013));
c.Add(new JMethod(2014,"forge/game/Game","getDayTime","()Ljava/lang/Boolean;",1,1,1,new JHandler[]{},M2014));
c.Add(new JMethod(2015,"forge/game/Game","setDayTime","(Ljava/lang/Boolean;)V",1,4,4,new JHandler[]{},M2015));
c.Add(new JMethod(2016,"forge/game/Game","isVoid","()Z",1,1,2,new JHandler[]{},M2016));
c.Add(new JMethod(2017,"forge/game/Game","getAITimeout","()I",1,1,1,new JHandler[]{},M2017));
c.Add(new JMethod(2018,"forge/game/Game","getAIFlatMonteCarlo","()Z",1,1,1,new JHandler[]{},M2018));
c.Add(new JMethod(2019,"forge/game/Game","getAIFlatMonteCarloMax","()Z",1,1,1,new JHandler[]{},M2019));
c.Add(new JMethod(2020,"forge/game/Game","getAIFlatMonteCarloLite","()Z",1,1,1,new JHandler[]{},M2020));
c.Add(new JMethod(2021,"forge/game/Game","isNoGUIUser","()Z",1,1,1,new JHandler[]{},M2021));
c.Add(new JMethod(2022,"forge/game/Game","setNoGUIUser","()V",1,1,2,new JHandler[]{},M2022));
c.Add(new JMethod(2023,"forge/game/Game","lambda$isVoid$3","(Lforge/game/card/Card;)Z",4106,1,1,new JHandler[]{},M2023));
c.Add(new JMethod(2024,"forge/game/Game","lambda$getSingleMaxDamageDoneThisTurn$2","(Lorg/apache/commons/lang3/tuple/Pair;)I",4106,1,1,new JHandler[]{},M2024));
c.Add(new JMethod(2025,"forge/game/Game","lambda$getSingleMaxDamageDoneThisTurn$1","(Lforge/game/card/CardDamageHistory;)Ljava/util/stream/Stream;",4106,1,1,new JHandler[]{},M2025));
c.Add(new JMethod(2026,"forge/game/Game","lambda$getCardsPlayerCanActivateInStack$0","(Lforge/game/card/Card;)Z",4106,4,2,new JHandler[]{},M2026));
c.Add(new JMethod(2027,"forge/game/Game","<clinit>","()V",8,0,1,new JHandler[]{},M2027));
}

internal static JStep M1875(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/Game","maxId","I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/Game","maxId","I"));f.Pc=3;continue;}
case 3:{f.Push(JValue.I(1));f.Pc=4;continue;}
case 4:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/Game","maxId","I"))return JStep.Continue;rt.PutStatic("forge/game/Game","maxId","I",f.Pop());f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1876(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","simulationCopy","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1877(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","simulationCopy","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1878(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","id","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1879(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","startingPlayer","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1880(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","startingPlayer","Lforge/game/player/Player;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1881(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","drawOffer","Lforge/game/DrawOffer;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1882(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","drawOffer","Lforge/game/DrawOffer;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1883(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","monarch","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1884(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","monarch","Lforge/game/player/Player;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1885(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","monarchBeginTurn","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1886(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","monarchBeginTurn","Lforge/game/player/Player;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1887(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","initiative","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1888(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","initiative","Lforge/game/player/Player;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1889(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","untilHostLeavesPlayTriggerList","Lforge/game/card/CardZoneTable;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1890(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","lastStateBattlefield","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1891(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","lastStateGraveyard","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1892(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","undoManager","Lforge/game/undo/UndoManager;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1893(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","EXPERIMENTAL_RESTORE_SNAPSHOT","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?27:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"forge/game/GameSnapshot"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameSnapshot")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/GameSnapshot","<init>","(Lforge/game/Game;)V","invokespecial",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","previousGameState","Lforge/game/GameSnapshot;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","previousGameState","Lforge/game/GameSnapshot;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/GameSnapshot","makeCopy","()Lforge/game/Game;","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1894(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","previousGameState","Lforge/game/GameSnapshot;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?14:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","EXPERIMENTAL_RESTORE_SNAPSHOT","Z"));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int!=0?16:14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","previousGameState","Lforge/game/GameSnapshot;"));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/GameSnapshot","restoreGameState","(Lforge/game/Game;)V","invokevirtual",24);}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1895(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","lastStateBattlefield","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","clear","()V","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","lastStateGraveyard","Lforge/game/card/CardCollection;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardCollection","clear","()V","invokevirtual",14);}
case 14:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",17);}
case 17:{f.Locals[1]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",22);}
case 22:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",25);}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?86:35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Locals[3]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","lastStateBattlefield","Lforge/game/card/CardCollection;"));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",56);}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/zone/PlayerZone","getLKICopy","(Ljava/util/Map;)Lforge/game/zone/Zone;","invokevirtual",60);}
case 60:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/lang/Iterable;)Z","invokevirtual",63);}
case 63:{f.StackOp("pop");f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","lastStateGraveyard","Lforge/game/card/CardCollection;"));f.Pc=68;continue;}
case 68:{f.Push(f.Locals[3]);f.Pc=69;continue;}
case 69:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",75);}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/zone/PlayerZone","getLKICopy","(Ljava/util/Map;)Lforge/game/zone/Zone;","invokevirtual",79);}
case 79:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/lang/Iterable;)Z","invokevirtual",82);}
case 82:{f.StackOp("pop");f.Pc=83;continue;}
case 83:{f.Pc=26;continue;}
case 86:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1896(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(I)V","invokespecial",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",17);}
case 17:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",20);}
case 20:{f.Locals[4]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?65:32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",51);}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/zone/PlayerZone","getLKICopy","(Ljava/util/Map;)Lforge/game/zone/Zone;","invokevirtual",55);}
case 55:{return rt.Call(f,"forge/game/zone/Zone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",58);}
case 58:{return rt.Call(f,"forge/game/card/CardCollection","addAllUnique","(Ljava/util/Collection;)Z","invokevirtual",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{f.Pc=22;continue;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1897(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","copyLastState","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1898(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","copyLastState","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1899(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?11:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Reference!=null?12:11;continue;}
case 11:{return JStep.ReturnVoid;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?37:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","lastStateBattlefield","Lforge/game/card/CardCollection;"));f.Pc=34;continue;}
case 34:{f.Pc=55;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int==0?54:47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","lastStateGraveyard","Lforge/game/card/CardCollection;"));f.Pc=51;continue;}
case 51:{f.Pc=55;continue;}
case 54:{f.Push(JValue.R(null));f.Pc=55;continue;}
case 55:{f.Locals[3]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{f.Pc=f.Pop().Reference==null?87:60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","lastStateBattlefield","Lforge/game/card/CardCollection;"));f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",68);}
case 68:{f.StackOp("pop");f.Pc=69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","lastStateGraveyard","Lforge/game/card/CardCollection;"));f.Pc=73;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",77);}
case 77:{f.StackOp("pop");f.Pc=78;continue;}
case 78:{f.Push(f.Locals[3]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",83);}
case 83:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",86);}
case 86:{f.StackOp("pop");f.Pc=87;continue;}
case 87:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1900(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","playerCache","Lforge/game/GameEntityViewMap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameEntityViewMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",8);}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1901(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","allPlayers","Lforge/game/player/PlayerCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",14);}
case 14:{f.Pc=f.Pop().Int==0?40:17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/player/Player","getId","()I","invokevirtual",31);}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?37:35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return JStep.Return(f.Pop());}
case 37:{f.Pc=8;continue;}
case 40:{f.Push(JValue.R(null));f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1902(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?5:4;continue;}
case 4:{return JStep.ReturnVoid;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","changeZoneLKIInfo","Lcom/google/common/collect/Table;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",13);}
case 13:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",16);}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/Card","getGameTimestamp","()J","invokevirtual",20);}
case 20:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",23);}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"com/google/common/collect/Table","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1903(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","changeZoneLKIInfo","Lcom/google/common/collect/Table;"));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",14);}
case 14:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",17);}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/Card","getGameTimestamp","()J","invokevirtual",21);}
case 21:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",24);}
case 24:{return rt.Call(f,"com/google/common/collect/Table","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1904(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","changeZoneLKIInfo","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/Table","clear","()V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1905(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","leftBattlefieldThisTurn","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1906(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","leftGraveyardThisTurn","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1907(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","leftBattlefieldThisTurn","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1908(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","leftGraveyardThisTurn","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1909(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","leftBattlefieldThisTurn","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1910(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","leftGraveyardThisTurn","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1911(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(-1));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/Game","<init>","(Ljava/lang/Iterable;Lforge/game/GameRules;Lforge/game/Match;Lforge/game/Game;I)V","invokespecial",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1912(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","allPlayers","Lforge/game/player/PlayerCollection;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","()V","invokespecial",23);}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","ingamePlayers","Lforge/game/player/PlayerCollection;",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","()V","invokespecial",34);}
case 34:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","lostPlayers","Lforge/game/player/PlayerCollection;",value);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityViewMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityViewMap")));f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/GameEntityViewMap","<init>","()V","invokespecial",45);}
case 45:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","playerCache","Lforge/game/GameEntityViewMap;",value);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(null));f.Pc=50;continue;}
case 50:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","activePlanes","Ljava/util/List;",value);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{if(!rt.EnsureInitialized(f,"forge/game/zone/CostPaymentStack"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/CostPaymentStack")));f.Pc=57;continue;}
case 57:{f.StackOp("dup");f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/zone/CostPaymentStack","<init>","()V","invokespecial",61);}
case 61:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","costPaymentStack","Lforge/game/zone/CostPaymentStack;",value);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{if(!rt.EnsureInitialized(f,"forge/game/StaticEffects"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/StaticEffects")));f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/StaticEffects","<init>","()V","invokespecial",72);}
case 72:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","staticEffects","Lforge/game/StaticEffects;",value);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{if(!rt.EnsureInitialized(f,"forge/game/trigger/TriggerHandler"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/trigger/TriggerHandler")));f.Pc=79;continue;}
case 79:{f.StackOp("dup");f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/trigger/TriggerHandler","<init>","(Lforge/game/Game;)V","invokespecial",84);}
case 84:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","triggerHandler","Lforge/game/trigger/TriggerHandler;",value);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{if(!rt.EnsureInitialized(f,"forge/game/replacement/ReplacementHandler"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/replacement/ReplacementHandler")));f.Pc=91;continue;}
case 91:{f.StackOp("dup");f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","<init>","(Lforge/game/Game;)V","invokespecial",96);}
case 96:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","replacementHandler","Lforge/game/replacement/ReplacementHandler;",value);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{if(!rt.EnsureInitialized(f,"com/google/common/eventbus/EventBus"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("com/google/common/eventbus/EventBus")));f.Pc=103;continue;}
case 103:{f.StackOp("dup");f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String("game events")));f.Pc=107;continue;}
case 107:{return rt.Call(f,"com/google/common/eventbus/EventBus","<init>","(Ljava/lang/String;)V","invokespecial",110);}
case 110:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","events","Lcom/google/common/eventbus/EventBus;",value);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{if(!rt.EnsureInitialized(f,"forge/game/GameLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLog")));f.Pc=117;continue;}
case 117:{f.StackOp("dup");f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/GameLog","<init>","()V","invokespecial",121);}
case 121:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","gameLog","Lforge/game/GameLog;",value);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{if(!rt.EnsureInitialized(f,"forge/game/zone/Zone"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/Zone")));f.Pc=128;continue;}
case 128:{f.StackOp("dup");f.Pc=129;continue;}
case 129:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=132;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/zone/Zone","<init>","(Lforge/game/zone/ZoneType;Lforge/game/Game;)V","invokespecial",136);}
case 136:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","stackZone","Lforge/game/zone/Zone;",value);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[0]);f.Pc=140;continue;}
case 140:{f.Push(JValue.I(5));f.Pc=141;continue;}
case 141:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","AI_TIMEOUT","I",value);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[0]);f.Pc=145;continue;}
case 145:{f.Push(JValue.I(0));f.Pc=146;continue;}
case 146:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","AI_FLAT_MONTE_CARLO","Z",value);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[0]);f.Pc=150;continue;}
case 150:{f.Push(JValue.I(0));f.Pc=151;continue;}
case 151:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","AI_FLAT_MONTE_CARLO_MAX","Z",value);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[0]);f.Pc=155;continue;}
case 155:{f.Push(JValue.I(0));f.Pc=156;continue;}
case 156:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","AI_FLAT_MONTE_CARLO_LITE","Z",value);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{f.Push(JValue.I(0));f.Pc=161;continue;}
case 161:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","EXPERIMENTAL_RESTORE_SNAPSHOT","Z",value);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{f.Push(JValue.I(0));f.Pc=166;continue;}
case 166:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","simulationCopy","Z",value);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[0]);f.Pc=170;continue;}
case 170:{f.Push(JValue.R(null));f.Pc=171;continue;}
case 171:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","previousGameState","Lforge/game/GameSnapshot;",value);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[0]);f.Pc=175;continue;}
case 175:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=178;continue;}
case 178:{f.StackOp("dup");f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",182);}
case 182:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","lastStateBattlefield","Lforge/game/card/CardCollection;",value);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[0]);f.Pc=186;continue;}
case 186:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=189;continue;}
case 189:{f.StackOp("dup");f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",193);}
case 193:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","lastStateGraveyard","Lforge/game/card/CardCollection;",value);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[0]);f.Pc=197;continue;}
case 197:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=200;continue;}
case 200:{f.StackOp("dup");f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",204);}
case 204:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","untilHostLeavesPlayTriggerList","Lforge/game/card/CardZoneTable;",value);f.Pc=207;continue;}
case 207:{f.Push(f.Locals[0]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"com/google/common/collect/HashBasedTable","create","()Lcom/google/common/collect/HashBasedTable;","invokestatic",211);}
case 211:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","countersAddedThisTurn","Lcom/google/common/collect/Table;",value);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[0]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","create","()Lcom/google/common/collect/ArrayListMultimap;","invokestatic",218);}
case 218:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","countersRemovedThisTurn","Lcom/google/common/collect/Multimap;",value);f.Pc=221;continue;}
case 221:{f.Push(f.Locals[0]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",225);}
case 225:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","leftBattlefieldThisTurn","Ljava/util/List;",value);f.Pc=228;continue;}
case 228:{f.Push(f.Locals[0]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",232);}
case 232:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","leftGraveyardThisTurn","Ljava/util/List;",value);f.Pc=235;continue;}
case 235:{f.Push(f.Locals[0]);f.Pc=236;continue;}
case 236:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=239;continue;}
case 239:{f.StackOp("dup");f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",243);}
case 243:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","globalDamageHistory","Lforge/util/collect/FCollection;",value);f.Pc=246;continue;}
case 246:{f.Push(f.Locals[0]);f.Pc=247;continue;}
case 247:{if(!rt.EnsureInitialized(f,"java/util/IdentityHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/IdentityHashMap")));f.Pc=250;continue;}
case 250:{f.StackOp("dup");f.Pc=251;continue;}
case 251:{return rt.Call(f,"java/util/IdentityHashMap","<init>","()V","invokespecial",254);}
case 254:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","damageThisTurnLKI","Ljava/util/IdentityHashMap;",value);f.Pc=257;continue;}
case 257:{f.Push(f.Locals[0]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",261);}
case 261:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","topLibsCast","Ljava/util/Map;",value);f.Pc=264;continue;}
case 264:{f.Push(f.Locals[0]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",268);}
case 268:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","facedownWhileCasting","Ljava/util/Map;",value);f.Pc=271;continue;}
case 271:{f.Push(f.Locals[0]);f.Pc=272;continue;}
case 272:{return rt.Call(f,"forge/game/Direction","getDefaultDirection","()Lforge/game/Direction;","invokestatic",275);}
case 275:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","turnOrder","Lforge/game/Direction;",value);f.Pc=278;continue;}
case 278:{f.Push(f.Locals[0]);f.Pc=279;continue;}
case 279:{f.Push(JValue.R(null));f.Pc=280;continue;}
case 280:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","daytime","Ljava/lang/Boolean;",value);f.Pc=283;continue;}
case 283:{f.Push(f.Locals[0]);f.Pc=284;continue;}
case 284:{f.Push(JValue.L(0));f.Pc=285;continue;}
case 285:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","timestamp","J",value);f.Pc=288;continue;}
case 288:{f.Push(f.Locals[0]);f.Pc=289;continue;}
case 289:{if(!rt.StaticReady(f,"forge/game/GameStage","BeforeMulligan","Lforge/game/GameStage;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameStage","BeforeMulligan","Lforge/game/GameStage;"));f.Pc=292;continue;}
case 292:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","age","Lforge/game/GameStage;",value);f.Pc=295;continue;}
case 295:{f.Push(f.Locals[0]);f.Pc=296;continue;}
case 296:{if(!rt.EnsureInitialized(f,"forge/trackable/Tracker"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/Tracker")));f.Pc=299;continue;}
case 299:{f.StackOp("dup");f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/trackable/Tracker","<init>","()V","invokespecial",303);}
case 303:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","tracker","Lforge/trackable/Tracker;",value);f.Pc=306;continue;}
case 306:{f.Push(f.Locals[0]);f.Pc=307;continue;}
case 307:{if(!rt.EnsureInitialized(f,"forge/game/undo/UndoManager"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/undo/UndoManager")));f.Pc=310;continue;}
case 310:{f.StackOp("dup");f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/game/undo/UndoManager","<init>","()V","invokespecial",314);}
case 314:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","undoManager","Lforge/game/undo/UndoManager;",value);f.Pc=317;continue;}
case 317:{f.Push(f.Locals[0]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"com/google/common/collect/HashBasedTable","create","()Lcom/google/common/collect/HashBasedTable;","invokestatic",321);}
case 321:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","changeZoneLKIInfo","Lcom/google/common/collect/Table;",value);f.Pc=324;continue;}
case 324:{f.Push(f.Locals[0]);f.Pc=325;continue;}
case 325:{f.Push(JValue.I(0));f.Pc=326;continue;}
case 326:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","cardIdCounter","I",value);f.Pc=329;continue;}
case 329:{f.Push(f.Locals[0]);f.Pc=330;continue;}
case 330:{f.Push(JValue.I(0));f.Pc=331;continue;}
case 331:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","hiddenCardIdCounter","I",value);f.Pc=334;continue;}
case 334:{f.Push(f.Locals[0]);f.Pc=335;continue;}
case 335:{f.Push(f.Locals[2]);f.Pc=336;continue;}
case 336:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","rules","Lforge/game/GameRules;",value);f.Pc=339;continue;}
case 339:{f.Push(f.Locals[0]);f.Pc=340;continue;}
case 340:{f.Push(f.Locals[3]);f.Pc=341;continue;}
case 341:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","match","Lforge/game/Match;",value);f.Pc=344;continue;}
case 344:{f.Push(f.Locals[0]);f.Pc=345;continue;}
case 345:{f.Push(f.Locals[4]);f.Pc=347;continue;}
case 347:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","maingame","Lforge/game/Game;",value);f.Pc=350;continue;}
case 350:{f.Push(f.Locals[0]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/game/Game","nextId","()I","invokestatic",354);}
case 354:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","id","I",value);f.Pc=357;continue;}
case 357:{f.Push(JValue.I(-1));f.Pc=358;continue;}
case 358:{f.Locals[6]=f.Pop();f.Pc=360;continue;}
case 360:{f.Push(f.Locals[1]);f.Pc=361;continue;}
case 361:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",366);}
case 366:{f.Locals[7]=f.Pop();f.Pc=368;continue;}
case 368:{f.Push(f.Locals[7]);f.Pc=370;continue;}
case 370:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",375);}
case 375:{f.Pc=f.Pop().Int==0?411:378;continue;}
case 378:{f.Push(f.Locals[7]);f.Pc=380;continue;}
case 380:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",385);}
case 385:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/RegisteredPlayer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=388;continue;}
case 388:{f.Locals[8]=f.Pop();f.Pc=390;continue;}
case 390:{f.Push(f.Locals[8]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getTeamNumber","()I","invokevirtual",395);}
case 395:{f.Locals[9]=f.Pop();f.Pc=397;continue;}
case 397:{f.Push(f.Locals[9]);f.Pc=399;continue;}
case 399:{f.Push(f.Locals[6]);f.Pc=401;continue;}
case 401:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?408:404;continue;}
case 404:{f.Push(f.Locals[9]);f.Pc=406;continue;}
case 406:{f.Locals[6]=f.Pop();f.Pc=408;continue;}
case 408:{f.Pc=368;continue;}
case 411:{f.Push(f.Locals[0]);f.Pc=412;continue;}
case 412:{if(!rt.EnsureInitialized(f,"forge/game/GameView"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameView")));f.Pc=415;continue;}
case 415:{f.StackOp("dup");f.Pc=416;continue;}
case 416:{f.Push(f.Locals[0]);f.Pc=417;continue;}
case 417:{return rt.Call(f,"forge/game/GameView","<init>","(Lforge/game/Game;)V","invokespecial",420);}
case 420:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","view","Lforge/game/GameView;",value);f.Pc=423;continue;}
case 423:{f.Push(JValue.I(0));f.Pc=424;continue;}
case 424:{f.Locals[7]=f.Pop();f.Pc=426;continue;}
case 426:{f.Push(f.Locals[1]);f.Pc=427;continue;}
case 427:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",432);}
case 432:{f.Locals[8]=f.Pop();f.Pc=434;continue;}
case 434:{f.Push(f.Locals[8]);f.Pc=436;continue;}
case 436:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",441);}
case 441:{f.Pc=f.Pop().Int==0?631:444;continue;}
case 444:{f.Push(f.Locals[8]);f.Pc=446;continue;}
case 446:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",451);}
case 451:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/RegisteredPlayer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=454;continue;}
case 454:{f.Locals[9]=f.Pop();f.Pc=456;continue;}
case 456:{f.Push(f.Locals[9]);f.Pc=458;continue;}
case 458:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getPlayer","()Lforge/LobbyPlayer;","invokevirtual",461);}
case 461:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/IGameEntitiesFactory"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=464;continue;}
case 464:{f.Locals[10]=f.Pop();f.Pc=466;continue;}
case 466:{f.Push(f.Locals[9]);f.Pc=468;continue;}
case 468:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getId","()Ljava/lang/Integer;","invokevirtual",471);}
case 471:{f.Locals[11]=f.Pop();f.Pc=473;continue;}
case 473:{f.Push(f.Locals[10]);f.Pc=475;continue;}
case 475:{f.Push(f.Locals[0]);f.Pc=476;continue;}
case 476:{f.Push(f.Locals[11]);f.Pc=478;continue;}
case 478:{f.Pc=f.Pop().Reference!=null?489:481;continue;}
case 481:{f.Push(f.Locals[7]);f.Pc=483;continue;}
case 483:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=486;continue;}
case 486:{f.Pc=494;continue;}
case 489:{f.Push(f.Locals[11]);f.Pc=491;continue;}
case 491:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",494);}
case 494:{return rt.Call(f,"forge/game/player/IGameEntitiesFactory","createIngamePlayer","(Lforge/game/Game;I)Lforge/game/player/Player;","invokeinterface",499);}
case 499:{f.Locals[12]=f.Pop();f.Pc=501;continue;}
case 501:{f.Push(f.Locals[0]);f.Pc=502;continue;}
case 502:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","allPlayers","Lforge/game/player/PlayerCollection;"));f.Pc=505;continue;}
case 505:{f.Push(f.Locals[12]);f.Pc=507;continue;}
case 507:{return rt.Call(f,"forge/game/player/PlayerCollection","add","(Ljava/lang/Object;)Z","invokevirtual",510);}
case 510:{f.StackOp("pop");f.Pc=511;continue;}
case 511:{f.Push(f.Locals[0]);f.Pc=512;continue;}
case 512:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","ingamePlayers","Lforge/game/player/PlayerCollection;"));f.Pc=515;continue;}
case 515:{f.Push(f.Locals[12]);f.Pc=517;continue;}
case 517:{return rt.Call(f,"forge/game/player/PlayerCollection","add","(Ljava/lang/Object;)Z","invokevirtual",520);}
case 520:{f.StackOp("pop");f.Pc=521;continue;}
case 521:{f.Push(f.Locals[0]);f.Pc=522;continue;}
case 522:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","playerCache","Lforge/game/GameEntityViewMap;"));f.Pc=525;continue;}
case 525:{f.Push(f.Locals[12]);f.Pc=527;continue;}
case 527:{return rt.Call(f,"forge/game/GameEntityViewMap","put","(Lforge/game/GameEntity;)V","invokevirtual",530);}
case 530:{f.Push(f.Locals[5]);f.Pc=532;continue;}
case 532:{f.Push(JValue.I(-1));f.Pc=533;continue;}
case 533:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?546:536;continue;}
case 536:{f.Push(f.Locals[12]);f.Pc=538;continue;}
case 538:{f.Push(f.Locals[5]);f.Pc=540;continue;}
case 540:{return rt.Call(f,"forge/game/player/Player","setStartingLife","(I)V","invokevirtual",543);}
case 543:{f.Pc=556;continue;}
case 546:{f.Push(f.Locals[12]);f.Pc=548;continue;}
case 548:{f.Push(f.Locals[9]);f.Pc=550;continue;}
case 550:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getStartingLife","()I","invokevirtual",553);}
case 553:{return rt.Call(f,"forge/game/player/Player","setStartingLife","(I)V","invokevirtual",556);}
case 556:{f.Push(f.Locals[12]);f.Pc=558;continue;}
case 558:{f.Push(f.Locals[9]);f.Pc=560;continue;}
case 560:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getStartingHand","()I","invokevirtual",563);}
case 563:{return rt.Call(f,"forge/game/player/Player","setMaxHandSize","(I)V","invokevirtual",566);}
case 566:{f.Push(f.Locals[12]);f.Pc=568;continue;}
case 568:{f.Push(f.Locals[9]);f.Pc=570;continue;}
case 570:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getStartingHand","()I","invokevirtual",573);}
case 573:{return rt.Call(f,"forge/game/player/Player","setStartingHandSize","(I)V","invokevirtual",576);}
case 576:{f.Push(f.Locals[9]);f.Pc=578;continue;}
case 578:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getManaShards","()I","invokevirtual",581);}
case 581:{f.Pc=f.Pop().Int<=0?594:584;continue;}
case 584:{f.Push(f.Locals[12]);f.Pc=586;continue;}
case 586:{f.Push(f.Locals[9]);f.Pc=588;continue;}
case 588:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getManaShards","()I","invokevirtual",591);}
case 591:{return rt.Call(f,"forge/game/player/Player","setNumManaShards","(I)V","invokevirtual",594);}
case 594:{f.Push(f.Locals[9]);f.Pc=596;continue;}
case 596:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getTeamNumber","()I","invokevirtual",599);}
case 599:{f.Locals[13]=f.Pop();f.Pc=601;continue;}
case 601:{f.Push(f.Locals[13]);f.Pc=603;continue;}
case 603:{f.Push(JValue.I(-1));f.Pc=604;continue;}
case 604:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?621:607;continue;}
case 607:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=610;continue;}
case 610:{f.Push(f.Locals[6]);f.Pc=612;continue;}
case 612:{f.Locals[13]=f.Pop();f.Pc=614;continue;}
case 614:{f.Push(f.Locals[9]);f.Pc=616;continue;}
case 616:{f.Push(f.Locals[13]);f.Pc=618;continue;}
case 618:{return rt.Call(f,"forge/game/player/RegisteredPlayer","setTeamNumber","(I)V","invokevirtual",621);}
case 621:{f.Push(f.Locals[12]);f.Pc=623;continue;}
case 623:{f.Push(f.Locals[13]);f.Pc=625;continue;}
case 625:{return rt.Call(f,"forge/game/player/Player","setTeam","(I)V","invokevirtual",628);}
case 628:{f.Pc=434;continue;}
case 631:{f.Push(f.Locals[0]);f.Pc=632;continue;}
case 632:{if(!rt.EnsureInitialized(f,"forge/game/GameAction"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameAction")));f.Pc=635;continue;}
case 635:{f.StackOp("dup");f.Pc=636;continue;}
case 636:{f.Push(f.Locals[0]);f.Pc=637;continue;}
case 637:{return rt.Call(f,"forge/game/GameAction","<init>","(Lforge/game/Game;)V","invokespecial",640);}
case 640:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","action","Lforge/game/GameAction;",value);f.Pc=643;continue;}
case 643:{f.Push(f.Locals[0]);f.Pc=644;continue;}
case 644:{if(!rt.EnsureInitialized(f,"forge/game/zone/MagicStack"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/MagicStack")));f.Pc=647;continue;}
case 647:{f.StackOp("dup");f.Pc=648;continue;}
case 648:{f.Push(f.Locals[0]);f.Pc=649;continue;}
case 649:{return rt.Call(f,"forge/game/zone/MagicStack","<init>","(Lforge/game/Game;)V","invokespecial",652);}
case 652:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","stack","Lforge/game/zone/MagicStack;",value);f.Pc=655;continue;}
case 655:{f.Push(f.Locals[0]);f.Pc=656;continue;}
case 656:{if(!rt.EnsureInitialized(f,"forge/game/phase/PhaseHandler"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/PhaseHandler")));f.Pc=659;continue;}
case 659:{f.StackOp("dup");f.Pc=660;continue;}
case 660:{f.Push(f.Locals[0]);f.Pc=661;continue;}
case 661:{return rt.Call(f,"forge/game/phase/PhaseHandler","<init>","(Lforge/game/Game;)V","invokespecial",664);}
case 664:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","phaseHandler","Lforge/game/phase/PhaseHandler;",value);f.Pc=667;continue;}
case 667:{f.Push(f.Locals[0]);f.Pc=668;continue;}
case 668:{if(!rt.EnsureInitialized(f,"forge/game/phase/Untap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/Untap")));f.Pc=671;continue;}
case 671:{f.StackOp("dup");f.Pc=672;continue;}
case 672:{f.Push(f.Locals[0]);f.Pc=673;continue;}
case 673:{return rt.Call(f,"forge/game/phase/Untap","<init>","(Lforge/game/Game;)V","invokespecial",676);}
case 676:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","untap","Lforge/game/phase/Untap;",value);f.Pc=679;continue;}
case 679:{f.Push(f.Locals[0]);f.Pc=680;continue;}
case 680:{if(!rt.EnsureInitialized(f,"forge/game/phase/Phase"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/Phase")));f.Pc=683;continue;}
case 683:{f.StackOp("dup");f.Pc=684;continue;}
case 684:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","UPKEEP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","UPKEEP","Lforge/game/phase/PhaseType;"));f.Pc=687;continue;}
case 687:{return rt.Call(f,"forge/game/phase/Phase","<init>","(Lforge/game/phase/PhaseType;)V","invokespecial",690);}
case 690:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","upkeep","Lforge/game/phase/Phase;",value);f.Pc=693;continue;}
case 693:{f.Push(f.Locals[0]);f.Pc=694;continue;}
case 694:{if(!rt.EnsureInitialized(f,"forge/game/phase/Phase"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/Phase")));f.Pc=697;continue;}
case 697:{f.StackOp("dup");f.Pc=698;continue;}
case 698:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_BEGIN","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_BEGIN","Lforge/game/phase/PhaseType;"));f.Pc=701;continue;}
case 701:{return rt.Call(f,"forge/game/phase/Phase","<init>","(Lforge/game/phase/PhaseType;)V","invokespecial",704);}
case 704:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","beginOfCombat","Lforge/game/phase/Phase;",value);f.Pc=707;continue;}
case 707:{f.Push(f.Locals[0]);f.Pc=708;continue;}
case 708:{if(!rt.EnsureInitialized(f,"forge/game/phase/Phase"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/Phase")));f.Pc=711;continue;}
case 711:{f.StackOp("dup");f.Pc=712;continue;}
case 712:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_END","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_END","Lforge/game/phase/PhaseType;"));f.Pc=715;continue;}
case 715:{return rt.Call(f,"forge/game/phase/Phase","<init>","(Lforge/game/phase/PhaseType;)V","invokespecial",718);}
case 718:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","endOfCombat","Lforge/game/phase/Phase;",value);f.Pc=721;continue;}
case 721:{f.Push(f.Locals[0]);f.Pc=722;continue;}
case 722:{if(!rt.EnsureInitialized(f,"forge/game/phase/Phase"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/Phase")));f.Pc=725;continue;}
case 725:{f.StackOp("dup");f.Pc=726;continue;}
case 726:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","END_OF_TURN","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","END_OF_TURN","Lforge/game/phase/PhaseType;"));f.Pc=729;continue;}
case 729:{return rt.Call(f,"forge/game/phase/Phase","<init>","(Lforge/game/phase/PhaseType;)V","invokespecial",732);}
case 732:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","endOfTurn","Lforge/game/phase/Phase;",value);f.Pc=735;continue;}
case 735:{f.Push(f.Locals[0]);f.Pc=736;continue;}
case 736:{if(!rt.EnsureInitialized(f,"forge/game/phase/Phase"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/Phase")));f.Pc=739;continue;}
case 739:{f.StackOp("dup");f.Pc=740;continue;}
case 740:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;"));f.Pc=743;continue;}
case 743:{return rt.Call(f,"forge/game/phase/Phase","<init>","(Lforge/game/phase/PhaseType;)V","invokespecial",746);}
case 746:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","cleanup","Lforge/game/phase/Phase;",value);f.Pc=749;continue;}
case 749:{f.Push(f.Locals[0]);f.Pc=750;continue;}
case 750:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=753;continue;}
case 753:{f.StackOp("dup");f.Pc=754;continue;}
case 754:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",757);}
case 757:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","sbaCheckedCommandList","Ljava/util/List;",value);f.Pc=760;continue;}
case 760:{f.Push(f.Locals[0]);f.Pc=761;continue;}
case 761:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","view","Lforge/game/GameView;"));f.Pc=764;continue;}
case 764:{f.Push(f.Locals[0]);f.Pc=765;continue;}
case 765:{return rt.Call(f,"forge/game/GameView","updatePlayers","(Lforge/game/Game;)V","invokevirtual",768);}
case 768:{f.Push(f.Locals[0]);f.Pc=769;continue;}
case 769:{f.Push(f.Locals[0]);f.Pc=770;continue;}
case 770:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","gameLog","Lforge/game/GameLog;"));f.Pc=773;continue;}
case 773:{return rt.Call(f,"forge/game/GameLog","getEventVisitor","()Lforge/game/GameLogFormatter;","invokevirtual",776);}
case 776:{return rt.Call(f,"forge/game/Game","subscribeToEvents","(Ljava/lang/Object;)V","invokevirtual",779);}
case 779:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1913(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","view","Lforge/game/GameView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1914(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","tracker","Lforge/trackable/Tracker;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1915(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","ingamePlayers","Lforge/game/player/PlayerCollection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1916(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","lostPlayers","Lforge/game/player/PlayerCollection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1917(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getTurnOrder","()Lforge/game/Direction;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/Direction","isDefaultDirection","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?15:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","ingamePlayers","Lforge/game/player/PlayerCollection;"));f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
case 15:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","ingamePlayers","Lforge/game/player/PlayerCollection;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",26);}
case 26:{f.Locals[1]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Collections","reverse","(Ljava/util/List;)V","invokestatic",31);}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1918(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","ingamePlayers","Lforge/game/player/PlayerCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",7);}
case 7:{f.Push(JValue.I(2));f.Pc=8;continue;}
case 8:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?26:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","ingamePlayers","Lforge/game/player/PlayerCollection;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/player/PlayerCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int==0?26:22;continue;}
case 22:{f.Push(JValue.I(1));f.Pc=23;continue;}
case 23:{f.Pc=27;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{f.Locals[2]=f.Pop();f.Pc=28;continue;}
case 28:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{f.Pc=f.Pop().Int==0?43:36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","ingamePlayers","Lforge/game/player/PlayerCollection;"));f.Pc=40;continue;}
case 40:{f.Pc=47;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/Game","getPlayersInTurnOrder","()Lforge/game/player/PlayerCollection;","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",50);}
case 50:{f.Locals[3]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/player/PlayerCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int!=0?65:59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",64);}
case 64:{f.Locals[1]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/player/PlayerCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",70);}
case 70:{f.Locals[4]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[4]);f.Pc=75;continue;}
case 75:{f.Push(JNumbers.Unary("ineg",f.Pop()));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Collections","rotate","(Ljava/util/List;I)V","invokestatic",79);}
case 79:{f.Push(f.Locals[3]);f.Pc=80;continue;}
case 80:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1919(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","allPlayers","Lforge/game/player/PlayerCollection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1920(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","untap","Lforge/game/phase/Untap;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1921(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","upkeep","Lforge/game/phase/Phase;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1922(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","beginOfCombat","Lforge/game/phase/Phase;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1923(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","endOfCombat","Lforge/game/phase/Phase;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1924(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","endOfTurn","Lforge/game/phase/Phase;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1925(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","cleanup","Lforge/game/phase/Phase;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1926(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","sbaCheckedCommandList","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1927(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","sbaCheckedCommandList","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?38:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/GameCommand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/GameCommand","run","()V","invokeinterface",35);}
case 35:{f.Pc=10;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","sbaCheckedCommandList","Ljava/util/List;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",47);}
case 47:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1928(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","staticEffects","Lforge/game/StaticEffects;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1929(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","replacementHandler","Lforge/game/replacement/ReplacementHandler;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1930(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","triggerHandler","Lforge/game/trigger/TriggerHandler;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1931(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","phaseHandler","Lforge/game/phase/PhaseHandler;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1932(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","view","Lforge/game/GameView;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","phaseHandler","Lforge/game/phase/PhaseHandler;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/GameView","updateTurn","(Lforge/game/phase/PhaseHandler;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1933(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","view","Lforge/game/GameView;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","phaseHandler","Lforge/game/phase/PhaseHandler;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/GameView","updatePhase","(Lforge/game/phase/PhaseHandler;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1934(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","view","Lforge/game/GameView;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","phaseHandler","Lforge/game/phase/PhaseHandler;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/GameView","updatePlayerTurn","(Lforge/game/phase/PhaseHandler;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1935(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","stack","Lforge/game/zone/MagicStack;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1936(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","view","Lforge/game/GameView;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","stack","Lforge/game/zone/MagicStack;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/GameView","updateStack","(Lforge/game/zone/MagicStack;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1937(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/phase/PhaseHandler","getCombat","()Lforge/game/combat/Combat;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1938(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","view","Lforge/game/GameView;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/GameView","updateCombat","(Lforge/game/combat/Combat;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1939(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","gameLog","Lforge/game/GameLog;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1940(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","stackZone","Lforge/game/zone/Zone;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1941(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","stackZone","Lforge/game/zone/Zone;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/zone/Zone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",7);}
case 7:{return rt.DynamicCall(f,"forge/game/Game:1941:7:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",12);}
case 12:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1942(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","phaseHandler","Lforge/game/phase/PhaseHandler;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Reference==null?31:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","phaseHandler","Lforge/game/phase/PhaseHandler;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",17);}
case 17:{return rt.Call(f,"forge/game/player/Player","isTurnOrderReversed","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?31:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","turnOrder","Lforge/game/Direction;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/Direction","getOtherDirection","()Lforge/game/Direction;","invokevirtual",30);}
case 30:{return JStep.Return(f.Pop());}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","turnOrder","Lforge/game/Direction;"));f.Pc=35;continue;}
case 35:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1943(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","turnOrder","Lforge/game/Direction;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/Direction","getOtherDirection","()Lforge/game/Direction;","invokevirtual",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","turnOrder","Lforge/game/Direction;",value);f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1944(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Direction","getDefaultDirection","()Lforge/game/Direction;","invokestatic",4);}
case 4:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","turnOrder","Lforge/game/Direction;",value);f.Pc=7;continue;}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1945(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/Game","getTimestamp","()J","invokevirtual",5);}
case 5:{f.Push(JValue.L(1));f.Pc=6;continue;}
case 6:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","timestamp","J",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/Game","getTimestamp","()J","invokevirtual",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1946(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","timestamp","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1947(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","timestamp","J",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1948(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","cardIdCounter","I"));f.Pc=5;continue;}
case 5:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","cardIdCounter","I",value);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","hiddenCardIdCounter","I"));f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","hiddenCardIdCounter","I",value);f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1949(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","outcome","Lforge/game/GameOutcome;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1950(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","maingame","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1951(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","age","Lforge/game/GameStage;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/GameStage","GameOver","Lforge/game/GameStage;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameStage","GameOver","Lforge/game/GameStage;"));f.Pc=7;continue;}
case 7:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?14:10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Pc=15;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1952(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","isGameOver","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?8:7;continue;}
case 7:{return JStep.ReturnVoid;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","allPlayers","Lforge/game/player/PlayerCollection;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?42:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/player/Player","clearController","()V","invokevirtual",39);}
case 39:{f.Pc=16;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{if(!rt.StaticReady(f,"forge/game/GameStage","GameOver","Lforge/game/GameStage;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameStage","GameOver","Lforge/game/GameStage;"));f.Pc=46;continue;}
case 46:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","age","Lforge/game/GameStage;",value);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",53);}
case 53:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",56);}
case 56:{f.Locals[2]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",63);}
case 63:{f.Pc=f.Pop().Int==0?83:66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",72);}
case 72:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=75;continue;}
case 75:{f.Locals[3]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[3]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/player/Player","onGameOver","()V","invokevirtual",80);}
case 80:{f.Pc=57;continue;}
case 83:{if(!rt.EnsureInitialized(f,"forge/game/GameOutcome"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameOutcome")));f.Pc=86;continue;}
case 86:{f.StackOp("dup");f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/Game","getRegisteredPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",92);}
case 92:{return rt.Call(f,"forge/game/GameOutcome","<init>","(Lforge/game/GameEndReason;Ljava/lang/Iterable;)V","invokespecial",95);}
case 95:{f.Locals[2]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",101);}
case 101:{return rt.Call(f,"forge/game/phase/PhaseHandler","getTurn","()I","invokevirtual",104);}
case 104:{return rt.Call(f,"forge/game/GameOutcome","setTurnsPlayed","(I)V","invokevirtual",107);}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[2]);f.Pc=109;continue;}
case 109:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","outcome","Lforge/game/GameOutcome;",value);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","maingame","Lforge/game/Game;"));f.Pc=116;continue;}
case 116:{f.Pc=f.Pop().Reference!=null?127:119;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","match","Lforge/game/Match;"));f.Pc=123;continue;}
case 123:{f.Push(f.Locals[0]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/Match","addGamePlayed","(Lforge/game/Game;)V","invokevirtual",127);}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","view","Lforge/game/GameView;"));f.Pc=131;continue;}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/GameView","updateGameOver","(Lforge/game/Game;)V","invokevirtual",135);}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","maingame","Lforge/game/Game;"));f.Pc=139;continue;}
case 139:{f.Pc=f.Pop().Reference!=null?161:142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventGameOutcome"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventGameOutcome")));f.Pc=146;continue;}
case 146:{f.StackOp("dup");f.Pc=147;continue;}
case 147:{f.Push(f.Locals[2]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[0]);f.Pc=149;continue;}
case 149:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","match","Lforge/game/Match;"));f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/Match","getOutcomes","()Ljava/util/Collection;","invokevirtual",155);}
case 155:{return rt.Call(f,"forge/game/event/GameEventGameOutcome","<init>","(Lforge/game/GameOutcome;Ljava/util/Collection;)V","invokespecial",158);}
case 158:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",161);}
case 161:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1953(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?8:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Pc=12;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","getLastKnownZone","()Lforge/game/zone/Zone;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1954(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?15:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/Game","getStackZone","()Lforge/game/zone/Zone;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/zone/Zone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",14);}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",19);}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/player/PlayerCollection","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollection;","invokevirtual",23);}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1955(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?15:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/Game","getStackZone","()Lforge/game/zone/Zone;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/zone/Zone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",14);}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",24);}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(I)V","invokespecial",33);}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{f.Locals[5]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?70:44;continue;}
case 44:{f.Push(f.Locals[4]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[5]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;Z)Lforge/game/card/CardCollectionView;","invokevirtual",60);}
case 60:{return rt.Call(f,"forge/game/card/CardCollection","addAllUnique","(Ljava/util/Collection;)Z","invokevirtual",63);}
case 63:{f.StackOp("pop");f.Pc=64;continue;}
case 64:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=67;continue;}
case 67:{f.Pc=38;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1956(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?20:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/Game","getStackZone","()Lforge/game/zone/Zone;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/zone/Zone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",15);}
case 15:{return rt.Call(f,"forge/game/card/CardCollection","addAllUnique","(Ljava/util/Collection;)Z","invokevirtual",18);}
case 18:{f.StackOp("pop");f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{f.Locals[5]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[5]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?54:30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/game/card/CardCollection","addAllUnique","(Ljava/util/Collection;)Z","invokevirtual",47);}
case 47:{f.StackOp("pop");f.Pc=48;continue;}
case 48:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=51;continue;}
case 51:{f.Pc=23;continue;}
case 54:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1957(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?8:4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=7;continue;}
case 7:{return JStep.Return(f.Pop());}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/util/EnumSet")?1:0));f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Int==0?99:25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=29;continue;}
case 29:{f.Locals[4]=f.Pop();f.Pc=31;continue;}
case 31:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=34;continue;}
case 34:{f.StackOp("dup");f.Pc=35;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(I)V","invokespecial",39);}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{if(!rt.StaticReady(f,"forge/game/Game","ALL_ZONE_TYPES","[Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/Game","ALL_ZONE_TYPES","[Lforge/game/zone/ZoneType;"));f.Pc=44;continue;}
case 44:{f.Locals[6]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[6]);f.Pc=48;continue;}
case 48:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=49;continue;}
case 49:{f.Locals[7]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{f.Locals[8]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[8]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[7]);f.Pc=58;continue;}
case 58:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?96:61;continue;}
case 61:{f.Push(f.Locals[6]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[8]);f.Pc=65;continue;}
case 65:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=66;continue;}
case 66:{f.Locals[9]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[9]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",77);}
case 77:{f.Pc=f.Pop().Int==0?90:80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[5]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[9]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/Game","addCardsIn","(Lforge/game/card/CardCollection;Lforge/game/zone/ZoneType;Lforge/game/player/PlayerCollection;I)V","invokevirtual",90);}
case 90:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=93;continue;}
case 93:{f.Pc=54;continue;}
case 96:{f.Push(f.Locals[5]);f.Pc=98;continue;}
case 98:{return JStep.Return(f.Pop());}
case 99:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=102;continue;}
case 102:{f.StackOp("dup");f.Pc=103;continue;}
case 103:{f.Push(JValue.I(0));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(I)V","invokespecial",107);}
case 107:{f.Locals[4]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",115);}
case 115:{f.Locals[5]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[5]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",124);}
case 124:{f.Pc=f.Pop().Int==0?264:127;continue;}
case 127:{f.Push(f.Locals[5]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",134);}
case 134:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=137;continue;}
case 137:{f.Locals[6]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[6]);f.Pc=141;continue;}
case 141:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=144;continue;}
case 144:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?195:147;continue;}
case 147:{f.Push(f.Locals[0]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/Game","getStackZone","()Lforge/game/zone/Zone;","invokevirtual",151);}
case 151:{return rt.Call(f,"forge/game/zone/Zone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",154);}
case 154:{f.Locals[7]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[7]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",163);}
case 163:{f.Pc=f.Pop().Int!=0?117:166;continue;}
case 166:{f.Push(f.Locals[4]);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[4]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",173);}
case 173:{f.Push(f.Locals[7]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",180);}
case 180:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/card/CardCollection","ensureCapacity","(I)V","invokevirtual",184);}
case 184:{f.Push(f.Locals[4]);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[7]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",191);}
case 191:{f.StackOp("pop");f.Pc=192;continue;}
case 192:{f.Pc=117;continue;}
case 195:{f.Push(JValue.I(0));f.Pc=196;continue;}
case 196:{f.Locals[7]=f.Pop();f.Pc=198;continue;}
case 198:{f.Push(f.Locals[7]);f.Pc=200;continue;}
case 200:{f.Push(f.Locals[3]);f.Pc=201;continue;}
case 201:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?261:204;continue;}
case 204:{f.Push(f.Locals[2]);f.Pc=205;continue;}
case 205:{f.Push(f.Locals[7]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",210);}
case 210:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[6]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",218);}
case 218:{f.Locals[8]=f.Pop();f.Pc=220;continue;}
case 220:{f.Push(f.Locals[8]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",227);}
case 227:{f.Locals[9]=f.Pop();f.Pc=229;continue;}
case 229:{f.Push(f.Locals[9]);f.Pc=231;continue;}
case 231:{f.Pc=f.Pop().Int<=0?255:234;continue;}
case 234:{f.Push(f.Locals[4]);f.Pc=236;continue;}
case 236:{f.Push(f.Locals[4]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",241);}
case 241:{f.Push(f.Locals[9]);f.Pc=243;continue;}
case 243:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/game/card/CardCollection","ensureCapacity","(I)V","invokevirtual",247);}
case 247:{f.Push(f.Locals[4]);f.Pc=249;continue;}
case 249:{f.Push(f.Locals[8]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",254);}
case 254:{f.StackOp("pop");f.Pc=255;continue;}
case 255:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=258;continue;}
case 258:{f.Pc=198;continue;}
case 261:{f.Pc=117;continue;}
case 264:{f.Push(f.Locals[4]);f.Pc=266;continue;}
case 266:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1958(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?8:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference!=null?12:8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",21);}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=26;continue;}
case 26:{f.StackOp("dup");f.Pc=27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(I)V","invokespecial",31);}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",39);}
case 39:{f.Locals[6]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[6]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",48);}
case 48:{f.Pc=f.Pop().Int==0?190:51;continue;}
case 51:{f.Push(f.Locals[6]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{f.Locals[7]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[7]);f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=68;continue;}
case 68:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?119:71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/Game","getStackZone","()Lforge/game/zone/Zone;","invokevirtual",75);}
case 75:{return rt.Call(f,"forge/game/zone/Zone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",78);}
case 78:{f.Locals[8]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[8]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",87);}
case 87:{f.Pc=f.Pop().Int!=0?41:90;continue;}
case 90:{f.Push(f.Locals[5]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[5]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",97);}
case 97:{f.Push(f.Locals[8]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",104);}
case 104:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/card/CardCollection","ensureCapacity","(I)V","invokevirtual",108);}
case 108:{f.Push(f.Locals[5]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[8]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",115);}
case 115:{f.StackOp("pop");f.Pc=116;continue;}
case 116:{f.Pc=41;continue;}
case 119:{f.Push(JValue.I(0));f.Pc=120;continue;}
case 120:{f.Locals[8]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[8]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[4]);f.Pc=126;continue;}
case 126:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?187:129;continue;}
case 129:{f.Push(f.Locals[3]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[8]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",135);}
case 135:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[7]);f.Pc=140;continue;}
case 140:{f.Push(JValue.I(0));f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;Z)Lforge/game/card/CardCollectionView;","invokevirtual",144);}
case 144:{f.Locals[9]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[9]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",153);}
case 153:{f.Locals[10]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[10]);f.Pc=157;continue;}
case 157:{f.Pc=f.Pop().Int<=0?181:160;continue;}
case 160:{f.Push(f.Locals[5]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[5]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",167);}
case 167:{f.Push(f.Locals[10]);f.Pc=169;continue;}
case 169:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/card/CardCollection","ensureCapacity","(I)V","invokevirtual",173);}
case 173:{f.Push(f.Locals[5]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[9]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",180);}
case 180:{f.StackOp("pop");f.Pc=181;continue;}
case 181:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=184;continue;}
case 184:{f.Pc=122;continue;}
case 187:{f.Pc=41;continue;}
case 190:{f.Push(f.Locals[5]);f.Pc=192;continue;}
case 192:{f.Push(f.Locals[2]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/card/CardPredicates","isOwner","(Lforge/game/player/Player;)Ljava/util/function/Predicate;","invokestatic",196);}
case 196:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",199);}
case 199:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1959(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",7);}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1960(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",7);}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardPredicates","nameEquals","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",16);}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1961(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",7);}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardPredicates","nameEquals","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",16);}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1962(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(I)V","invokespecial",18);}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{f.Locals[5]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[5]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?54:29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/player/Player","getColoredCardsInPlay","(B)Lforge/game/card/CardCollectionView;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/game/card/CardCollection","addAllUnique","(Ljava/util/Collection;)Z","invokevirtual",47);}
case 47:{f.StackOp("pop");f.Pc=48;continue;}
case 48:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=51;continue;}
case 51:{f.Pc=23;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1963(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1964(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/Game$CardStateVisitor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/Game$CardStateVisitor")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/Game$CardStateVisitor","<init>","(Lforge/game/card/Card;)V","invokespecial",8);}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/Game","forEachCardInGame","(Lforge/util/Visitor;Z)V","invokevirtual",15);}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/Game$CardStateVisitor","getFound","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",20);}
case 20:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1965(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{if(!rt.EnsureInitialized(f,"forge/game/Game$CardIdVisitor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/Game$CardIdVisitor")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardView","getId","()I","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/Game$CardIdVisitor","<init>","(I)V","invokespecial",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/card/CardView","getZone","()Lforge/game/zone/ZoneType;","invokevirtual",25);}
case 25:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?43:31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/Game","getStackZone","()Lforge/game/zone/Zone;","invokevirtual",36);}
case 36:{return rt.Call(f,"forge/game/Game$CardIdVisitor","visitAll","(Ljava/lang/Iterable;)Z","invokevirtual",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{f.Pc=83;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/card/CardView","getController","()Lforge/game/player/PlayerView;","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Reference==null?83:50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/card/CardView","getZone","()Lforge/game/zone/ZoneType;","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Reference==null?83:57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/card/CardView","getController","()Lforge/game/player/PlayerView;","invokevirtual",62);}
case 62:{return rt.Call(f,"forge/game/Game","getPlayer","(Lforge/game/player/PlayerView;)Lforge/game/player/Player;","invokevirtual",65);}
case 65:{f.Locals[3]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{f.Pc=f.Pop().Reference==null?83:70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/card/CardView","getZone","()Lforge/game/zone/ZoneType;","invokevirtual",76);}
case 76:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",79);}
case 79:{return rt.Call(f,"forge/game/Game$CardIdVisitor","visitAll","(Ljava/lang/Iterable;)Z","invokevirtual",82);}
case 82:{f.StackOp("pop");f.Pc=83;continue;}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/Game$CardIdVisitor","getFound","()Lforge/game/card/Card;","invokevirtual",87);}
case 87:{f.Pc=f.Pop().Reference!=null?95:90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/Game","forEachCardInGame","(Lforge/util/Visitor;)V","invokevirtual",95);}
case 95:{f.Push(f.Locals[2]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/Game$CardIdVisitor","getFound","()Lforge/game/card/Card;","invokevirtual",99);}
case 99:{f.Locals[3]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[3]);f.Pc=101;continue;}
case 101:{f.Pc=f.Pop().Reference!=null?141:104;continue;}
case 104:{if(!rt.StaticReady(f,"forge/game/Game","netLog","Lorg/tinylog/TaggedLogger;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/Game","netLog","Lorg/tinylog/TaggedLogger;"));f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.String("findByView: id={} (zone={}, controller={}) not found in any zone \u2014 returning null")));f.Pc=110;continue;}
case 110:{f.Push(JValue.I(3));f.Pc=111;continue;}
case 111:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=114;continue;}
case 114:{f.StackOp("dup");f.Pc=115;continue;}
case 115:{f.Push(JValue.I(0));f.Pc=116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/card/CardView","getId","()I","invokevirtual",120);}
case 120:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",123);}
case 123:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=124;continue;}
case 124:{f.StackOp("dup");f.Pc=125;continue;}
case 125:{f.Push(JValue.I(1));f.Pc=126;continue;}
case 126:{f.Push(f.Locals[1]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/card/CardView","getZone","()Lforge/game/zone/ZoneType;","invokevirtual",130);}
case 130:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=131;continue;}
case 131:{f.StackOp("dup");f.Pc=132;continue;}
case 132:{f.Push(JValue.I(2));f.Pc=133;continue;}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/card/CardView","getController","()Lforge/game/player/PlayerView;","invokevirtual",137);}
case 137:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=138;continue;}
case 138:{return rt.Call(f,"org/tinylog/TaggedLogger","error","(Ljava/lang/String;[Ljava/lang/Object;)V","invokevirtual",141);}
case 141:{f.Push(f.Locals[3]);f.Pc=142;continue;}
case 142:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1966(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/Game$CardIdVisitor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/Game$CardIdVisitor")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/Game$CardIdVisitor","<init>","(I)V","invokespecial",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/Game","forEachCardInGame","(Lforge/util/Visitor;)V","invokevirtual",14);}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/Game$CardIdVisitor","getFound","()Lforge/game/card/Card;","invokevirtual",18);}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1967(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/Game","forEachCardInGame","(Lforge/util/Visitor;Z)V","invokevirtual",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1968(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",14);}
case 14:{f.Pc=f.Pop().Int==0?195:17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{f.Locals[4]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",37);}
case 37:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",40);}
case 40:{return rt.Call(f,"forge/util/Visitor","visitAll","(Ljava/lang/Iterable;)Z","invokeinterface",45);}
case 45:{f.Pc=f.Pop().Int!=0?49:48;continue;}
case 48:{return JStep.ReturnVoid;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",58);}
case 58:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",61);}
case 61:{return rt.Call(f,"forge/util/Visitor","visitAll","(Ljava/lang/Iterable;)Z","invokeinterface",66);}
case 66:{f.Pc=f.Pop().Int!=0?70:69;continue;}
case 69:{return JStep.ReturnVoid;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[4]);f.Pc=73;continue;}
case 73:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",79);}
case 79:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",82);}
case 82:{return rt.Call(f,"forge/util/Visitor","visitAll","(Ljava/lang/Iterable;)Z","invokeinterface",87);}
case 87:{f.Pc=f.Pop().Int!=0?91:90;continue;}
case 90:{return JStep.ReturnVoid;}
case 91:{f.Push(f.Locals[1]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[4]);f.Pc=94;continue;}
case 94:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",100);}
case 100:{f.Push(JValue.I(0));f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","(Z)Lforge/game/card/CardCollectionView;","invokevirtual",104);}
case 104:{return rt.Call(f,"forge/util/Visitor","visitAll","(Ljava/lang/Iterable;)Z","invokeinterface",109);}
case 109:{f.Pc=f.Pop().Int!=0?113:112;continue;}
case 112:{return JStep.ReturnVoid;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[4]);f.Pc=116;continue;}
case 116:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",122);}
case 122:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",125);}
case 125:{return rt.Call(f,"forge/util/Visitor","visitAll","(Ljava/lang/Iterable;)Z","invokeinterface",130);}
case 130:{f.Pc=f.Pop().Int!=0?134:133;continue;}
case 133:{return JStep.ReturnVoid;}
case 134:{f.Push(f.Locals[1]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[4]);f.Pc=137;continue;}
case 137:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","PART_OF_COMMAND_ZONE","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","PART_OF_COMMAND_ZONE","Ljava/util/EnumSet;"));f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",143);}
case 143:{return rt.Call(f,"forge/util/Visitor","visitAll","(Ljava/lang/Iterable;)Z","invokeinterface",148);}
case 148:{f.Pc=f.Pop().Int!=0?152:151;continue;}
case 151:{return JStep.ReturnVoid;}
case 152:{f.Push(f.Locals[2]);f.Pc=153;continue;}
case 153:{f.Pc=f.Pop().Int==0?177:156;continue;}
case 156:{f.Push(f.Locals[1]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[4]);f.Pc=159;continue;}
case 159:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"));f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",165);}
case 165:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",168);}
case 168:{return rt.Call(f,"forge/util/Visitor","visitAll","(Ljava/lang/Iterable;)Z","invokeinterface",173);}
case 173:{f.Pc=f.Pop().Int!=0?177:176;continue;}
case 176:{return JStep.ReturnVoid;}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[4]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/player/Player","getInboundTokens","()Lforge/game/card/CardCollectionView;","invokevirtual",183);}
case 183:{return rt.Call(f,"forge/util/Visitor","visitAll","(Ljava/lang/Iterable;)Z","invokeinterface",188);}
case 188:{f.Pc=f.Pop().Int!=0?192:191;continue;}
case 191:{return JStep.ReturnVoid;}
case 192:{f.Pc=8;continue;}
case 195:{f.Push(f.Locals[1]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[0]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/Game","getStackZone","()Lforge/game/zone/Zone;","invokevirtual",200);}
case 200:{return rt.Call(f,"forge/game/zone/Zone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",203);}
case 203:{return rt.Call(f,"forge/util/Visitor","visitAll","(Ljava/lang/Iterable;)Z","invokeinterface",208);}
case 208:{f.StackOp("pop");f.Pc=209;continue;}
case 209:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1969(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(I)V","invokespecial",18);}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{f.Locals[4]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?149:28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{f.Locals[5]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[5]);f.Pc=42;continue;}
case 42:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",48);}
case 48:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",51);}
case 51:{return rt.Call(f,"forge/game/card/CardCollection","addAllUnique","(Ljava/util/Collection;)Z","invokevirtual",54);}
case 54:{f.StackOp("pop");f.Pc=55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",64);}
case 64:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",67);}
case 67:{return rt.Call(f,"forge/game/card/CardCollection","addAllUnique","(Ljava/util/Collection;)Z","invokevirtual",70);}
case 70:{f.StackOp("pop");f.Pc=71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[5]);f.Pc=74;continue;}
case 74:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",80);}
case 80:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",83);}
case 83:{return rt.Call(f,"forge/game/card/CardCollection","addAllUnique","(Ljava/util/Collection;)Z","invokevirtual",86);}
case 86:{f.StackOp("pop");f.Pc=87;continue;}
case 87:{f.Push(f.Locals[3]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[5]);f.Pc=90;continue;}
case 90:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",96);}
case 96:{f.Push(JValue.I(0));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","(Z)Lforge/game/card/CardCollectionView;","invokevirtual",100);}
case 100:{return rt.Call(f,"forge/game/card/CardCollection","addAllUnique","(Ljava/util/Collection;)Z","invokevirtual",103);}
case 103:{f.StackOp("pop");f.Pc=104;continue;}
case 104:{f.Push(f.Locals[3]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[5]);f.Pc=107;continue;}
case 107:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",113);}
case 113:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",116);}
case 116:{return rt.Call(f,"forge/game/card/CardCollection","addAllUnique","(Ljava/util/Collection;)Z","invokevirtual",119);}
case 119:{f.StackOp("pop");f.Pc=120;continue;}
case 120:{f.Push(f.Locals[3]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[5]);f.Pc=123;continue;}
case 123:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","PART_OF_COMMAND_ZONE","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","PART_OF_COMMAND_ZONE","Ljava/util/EnumSet;"));f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",129);}
case 129:{return rt.Call(f,"forge/game/card/CardCollection","addAllUnique","(Ljava/util/Collection;)Z","invokevirtual",132);}
case 132:{f.StackOp("pop");f.Pc=133;continue;}
case 133:{f.Push(f.Locals[3]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[5]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/player/Player","getInboundTokens","()Lforge/game/card/CardCollectionView;","invokevirtual",139);}
case 139:{return rt.Call(f,"forge/game/card/CardCollection","addAllUnique","(Ljava/util/Collection;)Z","invokevirtual",142);}
case 142:{f.StackOp("pop");f.Pc=143;continue;}
case 143:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=146;continue;}
case 146:{f.Pc=22;continue;}
case 149:{f.Push(f.Locals[3]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/Game","getStackZone","()Lforge/game/zone/Zone;","invokevirtual",154);}
case 154:{return rt.Call(f,"forge/game/zone/Zone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",157);}
case 157:{return rt.Call(f,"forge/game/card/CardCollection","addAllUnique","(Ljava/util/Collection;)Z","invokevirtual",160);}
case 160:{f.StackOp("pop");f.Pc=161;continue;}
case 161:{f.Push(f.Locals[3]);f.Pc=162;continue;}
case 162:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1970(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","action","Lforge/game/GameAction;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1971(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","match","Lforge/game/Match;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1972(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/Game","getTurnOrder","()Lforge/game/Direction;","invokevirtual",6);}
case 6:{return rt.Call(f,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;Lforge/game/Direction;)Lforge/game/player/Player;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1973(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","ingamePlayers","Lforge/game/player/PlayerCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/player/PlayerCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",8);}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","ingamePlayers","Lforge/game/player/PlayerCollection;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/player/PlayerCollection","isEmpty","()Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?21:19;continue;}
case 19:{f.Push(JValue.R(null));f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/Direction","getShift","()I","invokevirtual",25);}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(JValue.I(-1));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?95:32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","allPlayers","Lforge/game/player/PlayerCollection;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",39);}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","allPlayers","Lforge/game/player/PlayerCollection;"));f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/player/PlayerCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",49);}
case 49:{f.Locals[3]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[5]);f.Pc=56;continue;}
case 56:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=57;continue;}
case 57:{f.Locals[3]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{f.Pc=f.Pop().Int>=0?67:62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[5]);f.Pc=65;continue;}
case 65:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=66;continue;}
case 66:{f.Locals[3]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","ingamePlayers","Lforge/game/player/PlayerCollection;"));f.Pc=71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","allPlayers","Lforge/game/player/PlayerCollection;"));f.Pc=75;continue;}
case 75:{f.Push(f.Locals[3]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",79);}
case 79:{return rt.Call(f,"forge/game/player/PlayerCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",82);}
case 82:{f.Locals[6]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[6]);f.Pc=86;continue;}
case 86:{f.Pc=f.Pop().Int<0?50:89;continue;}
case 89:{f.Push(f.Locals[6]);f.Pc=91;continue;}
case 91:{f.Locals[3]=f.Pop();f.Pc=92;continue;}
case 92:{f.Pc=121;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","ingamePlayers","Lforge/game/player/PlayerCollection;"));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",102);}
case 102:{f.Locals[5]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[3]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[4]);f.Pc=107;continue;}
case 107:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=108;continue;}
case 108:{f.Push(f.Locals[5]);f.Pc=110;continue;}
case 110:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=111;continue;}
case 111:{f.Locals[3]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[3]);f.Pc=113;continue;}
case 113:{f.Pc=f.Pop().Int>=0?121:116;continue;}
case 116:{f.Push(f.Locals[3]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[5]);f.Pc=119;continue;}
case 119:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=120;continue;}
case 120:{f.Locals[3]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","ingamePlayers","Lforge/game/player/PlayerCollection;"));f.Pc=125;continue;}
case 125:{f.Push(f.Locals[3]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",129);}
case 129:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=132;continue;}
case 132:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1974(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","ingamePlayers","Lforge/game/player/PlayerCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/player/PlayerCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",8);}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","ingamePlayers","Lforge/game/player/PlayerCollection;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/player/PlayerCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?37:25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","ingamePlayers","Lforge/game/player/PlayerCollection;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",34);}
case 34:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=35;continue;}
case 35:{f.Locals[4]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1975(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/player/Player","setHasLost","(Z)V","invokevirtual",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/Game","getCardsInGame","()Lforge/game/card/CardCollectionView;","invokevirtual",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{f.Locals[4]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",19);}
case 19:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",22);}
case 22:{f.Push(JValue.I(2));f.Pc=23;continue;}
case 23:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?30:26;continue;}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{f.Pc=31;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/Game","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",41);}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/Game","getLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","(Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;)V","invokespecial",48);}
case 48:{f.Locals[6]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{f.Pc=f.Pop().Int==0?62:55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/player/Player","revealFaceDownCards","()V","invokevirtual",59);}
case 59:{f.Pc=101;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",66);}
case 66:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",69);}
case 69:{f.Locals[7]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[7]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",78);}
case 78:{f.Pc=f.Pop().Int==0?101:81;continue;}
case 81:{f.Push(f.Locals[7]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",88);}
case 88:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=91;continue;}
case 91:{f.Locals[8]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[8]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/player/Player","revealFaceDownCards","()V","invokevirtual",98);}
case 98:{f.Pc=71;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",107);}
case 107:{f.Locals[7]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[7]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",116);}
case 116:{f.Pc=f.Pop().Int==0?168:119;continue;}
case 119:{f.Push(f.Locals[7]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",126);}
case 126:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=129;continue;}
case 129:{f.Locals[8]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[8]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",136);}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",140);}
case 140:{f.Pc=f.Pop().Int==0?165:143;continue;}
case 143:{f.Push(f.Locals[8]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",148);}
case 148:{f.Push(f.Locals[1]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",152);}
case 152:{f.Pc=f.Pop().Int==0?165:155;continue;}
case 155:{f.Push(f.Locals[0]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",159);}
case 159:{f.Push(f.Locals[8]);f.Pc=161;continue;}
case 161:{f.Push(JValue.R(null));f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/trigger/TriggerHandler","clearActiveTriggers","(Lforge/game/card/Card;Lforge/game/zone/Zone;)V","invokevirtual",165);}
case 165:{f.Pc=109;continue;}
case 168:{f.Push(f.Locals[0]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/Game","getActivePlanes","()Ljava/util/List;","invokevirtual",172);}
case 172:{f.Pc=f.Pop().Reference==null?240:175;continue;}
case 175:{f.Push(f.Locals[0]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/Game","getActivePlanes","()Ljava/util/List;","invokevirtual",179);}
case 179:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",184);}
case 184:{f.Locals[7]=f.Pop();f.Pc=186;continue;}
case 186:{f.Push(f.Locals[7]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",193);}
case 193:{f.Pc=f.Pop().Int==0?240:196;continue;}
case 196:{f.Push(f.Locals[7]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",203);}
case 203:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=206;continue;}
case 206:{f.Locals[8]=f.Pop();f.Pc=208;continue;}
case 208:{f.Push(f.Locals[8]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",213);}
case 213:{f.Push(f.Locals[1]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",217);}
case 217:{f.Pc=f.Pop().Int==0?222:220;continue;}
case 220:{f.Push(JValue.I(1));f.Pc=221;continue;}
case 221:{f.Locals[3]=f.Pop();f.Pc=222;continue;}
case 222:{f.Push(f.Locals[8]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",227);}
case 227:{f.Push(f.Locals[1]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",231);}
case 231:{f.Pc=f.Pop().Int==0?237:234;continue;}
case 234:{f.Push(JValue.I(1));f.Pc=235;continue;}
case 235:{f.Locals[4]=f.Pop();f.Pc=237;continue;}
case 237:{f.Pc=186;continue;}
case 240:{f.Push(f.Locals[2]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",246);}
case 246:{f.Locals[7]=f.Pop();f.Pc=248;continue;}
case 248:{f.Push(f.Locals[7]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",255);}
case 255:{f.Pc=f.Pop().Int==0?617:258;continue;}
case 258:{f.Push(f.Locals[7]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",265);}
case 265:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=268;continue;}
case 268:{f.Locals[8]=f.Pop();f.Pc=270;continue;}
case 270:{f.Push(f.Locals[5]);f.Pc=272;continue;}
case 272:{f.Pc=f.Pop().Int==0?609:275;continue;}
case 275:{f.Push(f.Locals[8]);f.Pc=277;continue;}
case 277:{f.Push(f.Locals[1]);f.Pc=278;continue;}
case 278:{return rt.Call(f,"forge/game/card/Card","removeAttachedTo","(Lforge/game/GameEntity;)V","invokevirtual",281);}
case 281:{f.Push(f.Locals[8]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",286);}
case 286:{f.Push(f.Locals[1]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",290);}
case 290:{f.Pc=f.Pop().Int==0?451:293;continue;}
case 293:{f.Push(f.Locals[8]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/game/card/Card","getEffectSource","()Lforge/game/card/Card;","invokevirtual",298);}
case 298:{f.Pc=f.Pop().Reference==null?353:301;continue;}
case 301:{f.Push(f.Locals[8]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/game/card/Card","isEmblem","()Z","invokevirtual",306);}
case 306:{f.Pc=f.Pop().Int!=0?353:309;continue;}
case 309:{f.Push(f.Locals[1]);f.Pc=310;continue;}
case 310:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=313;continue;}
case 313:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",316);}
case 316:{f.Push(f.Locals[8]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/game/zone/PlayerZone","contains","(Lforge/game/card/Card;)Z","invokevirtual",321);}
case 321:{f.Pc=f.Pop().Int==0?353:324;continue;}
case 324:{f.Push(f.Locals[8]);f.Pc=326;continue;}
case 326:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",329);}
case 329:{f.Push(f.Locals[8]);f.Pc=331;continue;}
case 331:{return rt.Call(f,"forge/game/zone/Zone","remove","(Lforge/game/card/Card;)V","invokevirtual",334);}
case 334:{f.Push(f.Locals[0]);f.Pc=335;continue;}
case 335:{f.Push(f.Locals[1]);f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",339);}
case 339:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",345);}
case 345:{f.Push(f.Locals[8]);f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/game/zone/PlayerZone","add","(Lforge/game/card/Card;)V","invokevirtual",350);}
case 350:{f.Pc=614;continue;}
case 353:{f.Push(f.Locals[2]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",359);}
case 359:{f.Locals[9]=f.Pop();f.Pc=361;continue;}
case 361:{f.Push(f.Locals[9]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",368);}
case 368:{f.Pc=f.Pop().Int==0?421:371;continue;}
case 371:{f.Push(f.Locals[9]);f.Pc=373;continue;}
case 373:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",378);}
case 378:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=381;continue;}
case 381:{f.Locals[10]=f.Pop();f.Pc=383;continue;}
case 383:{f.Push(f.Locals[10]);f.Pc=385;continue;}
case 385:{f.Push(f.Locals[8]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"forge/game/card/Card","removeImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",390);}
case 390:{f.Push(f.Locals[10]);f.Pc=392;continue;}
case 392:{f.Push(f.Locals[8]);f.Pc=394;continue;}
case 394:{return rt.Call(f,"forge/game/card/Card","removeEncodedCard","(Lforge/game/card/Card;)V","invokevirtual",397);}
case 397:{f.Push(f.Locals[10]);f.Pc=399;continue;}
case 399:{f.Push(f.Locals[8]);f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Object;)V","invokevirtual",404);}
case 404:{f.Push(f.Locals[10]);f.Pc=406;continue;}
case 406:{f.Push(f.Locals[8]);f.Pc=408;continue;}
case 408:{return rt.Call(f,"forge/game/card/Card","removeAttachedTo","(Lforge/game/GameEntity;)V","invokevirtual",411);}
case 411:{f.Push(f.Locals[10]);f.Pc=413;continue;}
case 413:{f.Push(f.Locals[8]);f.Pc=415;continue;}
case 415:{return rt.Call(f,"forge/game/card/Card","removeAttachedCard","(Lforge/game/card/Card;)V","invokevirtual",418);}
case 418:{f.Pc=361;continue;}
case 421:{f.Push(f.Locals[6]);f.Pc=423;continue;}
case 423:{f.Push(f.Locals[8]);f.Pc=425;continue;}
case 425:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",428);}
case 428:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",431);}
case 431:{f.Push(JValue.R(null));f.Pc=432;continue;}
case 432:{f.Push(f.Locals[8]);f.Pc=434;continue;}
case 434:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",437);}
case 437:{f.StackOp("pop");f.Pc=438;continue;}
case 438:{f.Push(f.Locals[0]);f.Pc=439;continue;}
case 439:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",442);}
case 442:{f.Push(f.Locals[8]);f.Pc=444;continue;}
case 444:{f.Push(JValue.I(0));f.Pc=445;continue;}
case 445:{return rt.Call(f,"forge/game/GameAction","ceaseToExist","(Lforge/game/card/Card;Z)V","invokevirtual",448);}
case 448:{f.Pc=614;continue;}
case 451:{f.Push(f.Locals[8]);f.Pc=453;continue;}
case 453:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",456);}
case 456:{f.Pc=f.Pop().Int==0?501:459;continue;}
case 459:{f.Push(f.Locals[8]);f.Pc=461;continue;}
case 461:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",464);}
case 464:{f.Push(f.Locals[1]);f.Pc=465;continue;}
case 465:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",468);}
case 468:{f.Pc=f.Pop().Int!=0?486:471;continue;}
case 471:{f.Push(f.Locals[8]);f.Pc=473;continue;}
case 473:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",476);}
case 476:{return rt.Call(f,"forge/game/zone/Zone","getPlayer","()Lforge/game/player/Player;","invokevirtual",479);}
case 479:{f.Push(f.Locals[1]);f.Pc=480;continue;}
case 480:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",483);}
case 483:{f.Pc=f.Pop().Int==0?501:486;continue;}
case 486:{f.Push(f.Locals[8]);f.Pc=488;continue;}
case 488:{f.Push(f.Locals[1]);f.Pc=489;continue;}
case 489:{return rt.Call(f,"forge/game/card/Card","removeTempController","(Lforge/game/player/Player;)V","invokevirtual",492);}
case 492:{f.Push(f.Locals[0]);f.Pc=493;continue;}
case 493:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",496);}
case 496:{f.Push(f.Locals[8]);f.Pc=498;continue;}
case 498:{return rt.Call(f,"forge/game/GameAction","controllerChangeZoneCorrection","(Lforge/game/card/Card;)V","invokevirtual",501);}
case 501:{f.Push(f.Locals[8]);f.Pc=503;continue;}
case 503:{f.Push(f.Locals[1]);f.Pc=504;continue;}
case 504:{return rt.Call(f,"forge/game/card/Card","removeTempController","(Lforge/game/player/Player;)V","invokevirtual",507);}
case 507:{f.Push(f.Locals[8]);f.Pc=509;continue;}
case 509:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=512;continue;}
case 512:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",515);}
case 515:{f.Pc=f.Pop().Int==0?547:518;continue;}
case 518:{f.Push(f.Locals[0]);f.Pc=519;continue;}
case 519:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",522);}
case 522:{f.Push(f.Locals[8]);f.Pc=524;continue;}
case 524:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",527);}
case 527:{return rt.Call(f,"forge/game/zone/MagicStack","getInstanceMatchingSpellAbilityID","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbilityStackInstance;","invokevirtual",530);}
case 530:{f.Locals[9]=f.Pop();f.Pc=532;continue;}
case 532:{f.Push(f.Locals[9]);f.Pc=534;continue;}
case 534:{f.Pc=f.Pop().Reference==null?547:537;continue;}
case 537:{f.Push(f.Locals[9]);f.Pc=539;continue;}
case 539:{f.Push(f.Locals[8]);f.Pc=541;continue;}
case 541:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",544);}
case 544:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",547);}
case 547:{f.Push(f.Locals[8]);f.Pc=549;continue;}
case 549:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",552);}
case 552:{f.Push(f.Locals[1]);f.Pc=553;continue;}
case 553:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",556);}
case 556:{f.Pc=f.Pop().Int==0?614:559;continue;}
case 559:{f.Push(f.Locals[8]);f.Pc=561;continue;}
case 561:{return rt.Call(f,"forge/game/card/Card","isPlane","()Z","invokevirtual",564);}
case 564:{f.Pc=f.Pop().Int!=0?614:567;continue;}
case 567:{f.Push(f.Locals[8]);f.Pc=569;continue;}
case 569:{return rt.Call(f,"forge/game/card/Card","isPhenomenon","()Z","invokevirtual",572);}
case 572:{f.Pc=f.Pop().Int!=0?614:575;continue;}
case 575:{f.Push(f.Locals[0]);f.Pc=576;continue;}
case 576:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",579);}
case 579:{f.Push(f.Locals[8]);f.Pc=581;continue;}
case 581:{f.Push(JValue.R(null));f.Pc=582;continue;}
case 582:{f.Push(JValue.R(null));f.Pc=583;continue;}
case 583:{return rt.Call(f,"forge/game/GameAction","exile","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",586);}
case 586:{f.StackOp("pop");f.Pc=587;continue;}
case 587:{f.Push(f.Locals[6]);f.Pc=589;continue;}
case 589:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=592;continue;}
case 592:{f.Push(f.Locals[8]);f.Pc=594;continue;}
case 594:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",597);}
case 597:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",600);}
case 600:{f.Push(f.Locals[8]);f.Pc=602;continue;}
case 602:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",605);}
case 605:{f.StackOp("pop");f.Pc=606;continue;}
case 606:{f.Pc=614;continue;}
case 609:{f.Push(f.Locals[8]);f.Pc=611;continue;}
case 611:{return rt.Call(f,"forge/game/card/Card","forceTurnFaceUp","()V","invokevirtual",614);}
case 614:{f.Pc=248;continue;}
case 617:{f.Push(f.Locals[6]);f.Pc=619;continue;}
case 619:{f.Push(f.Locals[0]);f.Pc=620;continue;}
case 620:{f.Push(JValue.R(null));f.Pc=621;continue;}
case 621:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",624);}
case 624:{f.Push(f.Locals[3]);f.Pc=625;continue;}
case 625:{f.Pc=f.Pop().Int==0?696:628;continue;}
case 628:{f.Push(f.Locals[0]);f.Pc=629;continue;}
case 629:{return rt.Call(f,"forge/game/Game","getActivePlanes","()Ljava/util/List;","invokevirtual",632);}
case 632:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",637);}
case 637:{f.Locals[7]=f.Pop();f.Pc=639;continue;}
case 639:{f.Push(f.Locals[7]);f.Pc=641;continue;}
case 641:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",646);}
case 646:{f.Pc=f.Pop().Int==0?696:649;continue;}
case 649:{f.Push(f.Locals[7]);f.Pc=651;continue;}
case 651:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",656);}
case 656:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=659;continue;}
case 659:{f.Locals[8]=f.Pop();f.Pc=661;continue;}
case 661:{f.Push(f.Locals[8]);f.Pc=663;continue;}
case 663:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",666);}
case 666:{f.Push(f.Locals[1]);f.Pc=667;continue;}
case 667:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",670);}
case 670:{f.Pc=f.Pop().Int!=0?693:673;continue;}
case 673:{f.Push(f.Locals[8]);f.Pc=675;continue;}
case 675:{f.Push(f.Locals[0]);f.Pc=676;continue;}
case 676:{f.Push(f.Locals[1]);f.Pc=677;continue;}
case 677:{return rt.Call(f,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",680);}
case 680:{f.Push(JValue.L(0));f.Pc=681;continue;}
case 681:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",684);}
case 684:{f.Push(f.Locals[0]);f.Pc=685;continue;}
case 685:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",688);}
case 688:{f.Push(f.Locals[8]);f.Pc=690;continue;}
case 690:{return rt.Call(f,"forge/game/GameAction","controllerChangeZoneCorrection","(Lforge/game/card/Card;)V","invokevirtual",693);}
case 693:{f.Pc=639;continue;}
case 696:{f.Push(f.Locals[4]);f.Pc=698;continue;}
case 698:{f.Pc=f.Pop().Int==0?835:701;continue;}
case 701:{f.Push(f.Locals[0]);f.Pc=702;continue;}
case 702:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",705);}
case 705:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",708);}
case 708:{f.Locals[7]=f.Pop();f.Pc=710;continue;}
case 710:{f.Push(f.Locals[7]);f.Pc=712;continue;}
case 712:{f.Push(f.Locals[1]);f.Pc=713;continue;}
case 713:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",716);}
case 716:{f.Pc=f.Pop().Int==0?726:719;continue;}
case 719:{f.Push(f.Locals[0]);f.Pc=720;continue;}
case 720:{f.Push(f.Locals[1]);f.Pc=721;continue;}
case 721:{return rt.Call(f,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",724);}
case 724:{f.Locals[7]=f.Pop();f.Pc=726;continue;}
case 726:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=729;continue;}
case 729:{f.StackOp("dup");f.Pc=730;continue;}
case 730:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",733);}
case 733:{f.Locals[8]=f.Pop();f.Pc=735;continue;}
case 735:{f.Push(f.Locals[0]);f.Pc=736;continue;}
case 736:{return rt.Call(f,"forge/game/Game","getActivePlanes","()Ljava/util/List;","invokevirtual",739);}
case 739:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",744);}
case 744:{f.Locals[9]=f.Pop();f.Pc=746;continue;}
case 746:{f.Push(f.Locals[9]);f.Pc=748;continue;}
case 748:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",753);}
case 753:{f.Pc=f.Pop().Int==0?798:756;continue;}
case 756:{f.Push(f.Locals[9]);f.Pc=758;continue;}
case 758:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",763);}
case 763:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=766;continue;}
case 766:{f.Locals[10]=f.Pop();f.Pc=768;continue;}
case 768:{f.Push(f.Locals[10]);f.Pc=770;continue;}
case 770:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",773);}
case 773:{f.Push(f.Locals[1]);f.Pc=774;continue;}
case 774:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",777);}
case 777:{f.Pc=f.Pop().Int==0?795:780;continue;}
case 780:{f.Push(f.Locals[8]);f.Pc=782;continue;}
case 782:{f.Push(f.Locals[10]);f.Pc=784;continue;}
case 784:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",787);}
case 787:{f.StackOp("pop");f.Pc=788;continue;}
case 788:{f.Push(f.Locals[7]);f.Pc=790;continue;}
case 790:{f.Push(f.Locals[10]);f.Pc=792;continue;}
case 792:{return rt.Call(f,"forge/game/player/Player","removeCurrentPlane","(Lforge/game/card/Card;)V","invokevirtual",795);}
case 795:{f.Pc=746;continue;}
case 798:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",801);}
case 801:{f.Locals[9]=f.Pop();f.Pc=803;continue;}
case 803:{f.Push(f.Locals[9]);f.Pc=805;continue;}
case 805:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=808;continue;}
case 808:{f.Push(f.Locals[8]);f.Pc=810;continue;}
case 810:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",815);}
case 815:{f.StackOp("pop");f.Pc=816;continue;}
case 816:{f.Push(f.Locals[0]);f.Pc=817;continue;}
case 817:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",820);}
case 820:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","PlaneswalkedFrom","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","PlaneswalkedFrom","Lforge/game/trigger/TriggerType;"));f.Pc=823;continue;}
case 823:{f.Push(f.Locals[9]);f.Pc=825;continue;}
case 825:{f.Push(JValue.I(0));f.Pc=826;continue;}
case 826:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",829);}
case 829:{f.Push(f.Locals[7]);f.Pc=831;continue;}
case 831:{f.Push(JValue.R(null));f.Pc=832;continue;}
case 832:{return rt.Call(f,"forge/game/player/Player","planeswalk","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",835);}
case 835:{f.Push(f.Locals[1]);f.Pc=836;continue;}
case 836:{return rt.Call(f,"forge/game/player/Player","isMonarch","()Z","invokevirtual",839);}
case 839:{f.Pc=f.Pop().Int==0?893:842;continue;}
case 842:{f.Push(f.Locals[1]);f.Pc=843;continue;}
case 843:{f.Push(f.Locals[0]);f.Pc=844;continue;}
case 844:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",847);}
case 847:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",850);}
case 850:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",853);}
case 853:{f.Pc=f.Pop().Int==0?875:856;continue;}
case 856:{f.Push(f.Locals[0]);f.Pc=857;continue;}
case 857:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",860);}
case 860:{f.Push(f.Locals[0]);f.Pc=861;continue;}
case 861:{f.Push(f.Locals[1]);f.Pc=862;continue;}
case 862:{return rt.Call(f,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",865);}
case 865:{f.Push(f.Locals[1]);f.Pc=866;continue;}
case 866:{return rt.Call(f,"forge/game/player/Player","getMonarchSet","()Ljava/lang/String;","invokevirtual",869);}
case 869:{return rt.Call(f,"forge/game/GameAction","becomeMonarch","(Lforge/game/player/Player;Ljava/lang/String;)V","invokevirtual",872);}
case 872:{f.Pc=893;continue;}
case 875:{f.Push(f.Locals[0]);f.Pc=876;continue;}
case 876:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",879);}
case 879:{f.Push(f.Locals[0]);f.Pc=880;continue;}
case 880:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",883);}
case 883:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",886);}
case 886:{f.Push(f.Locals[1]);f.Pc=887;continue;}
case 887:{return rt.Call(f,"forge/game/player/Player","getMonarchSet","()Ljava/lang/String;","invokevirtual",890);}
case 890:{return rt.Call(f,"forge/game/GameAction","becomeMonarch","(Lforge/game/player/Player;Ljava/lang/String;)V","invokevirtual",893);}
case 893:{f.Push(f.Locals[1]);f.Pc=894;continue;}
case 894:{return rt.Call(f,"forge/game/player/Player","hasInitiative","()Z","invokevirtual",897);}
case 897:{f.Pc=f.Pop().Int==0?951:900;continue;}
case 900:{f.Push(f.Locals[1]);f.Pc=901;continue;}
case 901:{f.Push(f.Locals[0]);f.Pc=902;continue;}
case 902:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",905);}
case 905:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",908);}
case 908:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",911);}
case 911:{f.Pc=f.Pop().Int==0?933:914;continue;}
case 914:{f.Push(f.Locals[0]);f.Pc=915;continue;}
case 915:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",918);}
case 918:{f.Push(f.Locals[0]);f.Pc=919;continue;}
case 919:{f.Push(f.Locals[1]);f.Pc=920;continue;}
case 920:{return rt.Call(f,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",923);}
case 923:{f.Push(f.Locals[1]);f.Pc=924;continue;}
case 924:{return rt.Call(f,"forge/game/player/Player","getInitiativeSet","()Ljava/lang/String;","invokevirtual",927);}
case 927:{return rt.Call(f,"forge/game/GameAction","takeInitiative","(Lforge/game/player/Player;Ljava/lang/String;)V","invokevirtual",930);}
case 930:{f.Pc=951;continue;}
case 933:{f.Push(f.Locals[0]);f.Pc=934;continue;}
case 934:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",937);}
case 937:{f.Push(f.Locals[0]);f.Pc=938;continue;}
case 938:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",941);}
case 941:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",944);}
case 944:{f.Push(f.Locals[1]);f.Pc=945;continue;}
case 945:{return rt.Call(f,"forge/game/player/Player","getInitiativeSet","()Ljava/lang/String;","invokevirtual",948);}
case 948:{return rt.Call(f,"forge/game/GameAction","takeInitiative","(Lforge/game/player/Player;Ljava/lang/String;)V","invokevirtual",951);}
case 951:{f.Push(f.Locals[0]);f.Pc=952;continue;}
case 952:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",955);}
case 955:{f.Push(f.Locals[1]);f.Pc=956;continue;}
case 956:{return rt.Call(f,"forge/game/zone/MagicStack","removeInstancesControlledBy","(Lforge/game/player/Player;)V","invokevirtual",959);}
case 959:{f.Push(f.Locals[0]);f.Pc=960;continue;}
case 960:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","ingamePlayers","Lforge/game/player/PlayerCollection;"));f.Pc=963;continue;}
case 963:{f.Push(f.Locals[1]);f.Pc=964;continue;}
case 964:{return rt.Call(f,"forge/game/player/PlayerCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",967);}
case 967:{f.StackOp("pop");f.Pc=968;continue;}
case 968:{f.Push(f.Locals[0]);f.Pc=969;continue;}
case 969:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","lostPlayers","Lforge/game/player/PlayerCollection;"));f.Pc=972;continue;}
case 972:{f.Push(f.Locals[1]);f.Pc=973;continue;}
case 973:{return rt.Call(f,"forge/game/player/PlayerCollection","add","(Ljava/lang/Object;)Z","invokevirtual",976);}
case 976:{f.StackOp("pop");f.Pc=977;continue;}
case 977:{f.Push(f.Locals[0]);f.Pc=978;continue;}
case 978:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",981);}
case 981:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",984);}
case 984:{f.Locals[7]=f.Pop();f.Pc=986;continue;}
case 986:{f.Push(f.Locals[7]);f.Pc=988;continue;}
case 988:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",993);}
case 993:{f.Pc=f.Pop().Int==0?1017:996;continue;}
case 996:{f.Push(f.Locals[7]);f.Pc=998;continue;}
case 998:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1003);}
case 1003:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1006;continue;}
case 1006:{f.Locals[8]=f.Pop();f.Pc=1008;continue;}
case 1008:{f.Push(f.Locals[8]);f.Pc=1010;continue;}
case 1010:{f.Push(f.Locals[1]);f.Pc=1011;continue;}
case 1011:{return rt.Call(f,"forge/game/player/Player","removeController","(Lforge/game/player/Player;)V","invokevirtual",1014);}
case 1014:{f.Pc=986;continue;}
case 1017:{f.Push(f.Locals[1]);f.Pc=1018;continue;}
case 1018:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",1021);}
case 1021:{f.Locals[7]=f.Pop();f.Pc=1023;continue;}
case 1023:{f.Push(f.Locals[7]);f.Pc=1025;continue;}
case 1025:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=1028;continue;}
case 1028:{f.Push(f.Locals[6]);f.Pc=1030;continue;}
case 1030:{return rt.Call(f,"forge/game/card/CardZoneTable","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",1033);}
case 1033:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1038);}
case 1038:{f.StackOp("pop");f.Pc=1039;continue;}
case 1039:{f.Push(f.Locals[0]);f.Pc=1040;continue;}
case 1040:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1043);}
case 1043:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","LosesGame","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","LosesGame","Lforge/game/trigger/TriggerType;"));f.Pc=1046;continue;}
case 1046:{f.Push(f.Locals[7]);f.Pc=1048;continue;}
case 1048:{f.Push(JValue.I(0));f.Pc=1049;continue;}
case 1049:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1052);}
case 1052:{f.Push(f.Locals[0]);f.Pc=1053;continue;}
case 1053:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1056);}
case 1056:{f.Push(f.Locals[1]);f.Pc=1057;continue;}
case 1057:{return rt.Call(f,"forge/game/trigger/TriggerHandler","onPlayerLost","(Lforge/game/player/Player;)V","invokevirtual",1060);}
case 1060:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1976(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","events","Lcom/google/common/eventbus/EventBus;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/eventbus/EventBus","post","(Ljava/lang/Object;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1977(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","events","Lcom/google/common/eventbus/EventBus;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/eventbus/EventBus","register","(Ljava/lang/Object;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1978(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","rules","Lforge/game/GameRules;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1979(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","activePlanes","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1980(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","activePlanes","Ljava/util/List;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1981(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","age","Lforge/game/GameStage;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1982(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","age","Lforge/game/GameStage;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1983(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.StackOp("dup");f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","cardIdCounter","I"));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=7;continue;}
case 7:{f.StackOp("dup_x1");f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","cardIdCounter","I",value);f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1984(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.StackOp("dup");f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","hiddenCardIdCounter","I"));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=7;continue;}
case 7:{f.StackOp("dup_x1");f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","hiddenCardIdCounter","I",value);f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1985(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","create","()Lcom/google/common/collect/ArrayListMultimap;","invokestatic",3);}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Int==0?549:8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/card/CardRarity","values","()[Lforge/card/CardRarity;","invokestatic",18);}
case 18:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",21);}
case 21:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",24);}
case 24:{f.Locals[5]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",30);}
case 30:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",33);}
case 33:{f.Locals[6]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[6]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int==0?100:45;continue;}
case 45:{f.Push(f.Locals[6]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{f.Locals[7]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[7]);f.Pc=59;continue;}
case 59:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",65);}
case 65:{return rt.Call(f,"forge/game/Game","getValidRarities","(Ljava/lang/Iterable;)Ljava/util/Set;","invokestatic",68);}
case 68:{f.Locals[8]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{f.Pc=f.Pop().Int!=0?87:75;continue;}
case 75:{f.Push(f.Locals[8]);f.Pc=77;continue;}
case 77:{if(!rt.StaticReady(f,"forge/card/CardRarity","Special","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Special","Lforge/card/CardRarity;"));f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",85);}
case 85:{f.Locals[4]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[8]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/List","retainAll","(Ljava/util/Collection;)Z","invokeinterface",96);}
case 96:{f.StackOp("pop");f.Pc=97;continue;}
case 97:{f.Pc=35;continue;}
case 100:{f.Push(f.Locals[5]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",107);}
case 107:{f.Pc=f.Pop().Int!=0?154:110;continue;}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",114);}
case 114:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",117);}
case 117:{f.Locals[6]=f.Pop();f.Pc=119;continue;}
case 119:{f.Push(f.Locals[6]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",126);}
case 126:{f.Pc=f.Pop().Int==0?152:129;continue;}
case 129:{f.Push(f.Locals[6]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",136);}
case 136:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=139;continue;}
case 139:{f.Locals[7]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[7]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[3]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[2]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/Game","chooseRandomCardsForAnte","(Lforge/game/player/Player;Lcom/google/common/collect/Multimap;Z)V","invokevirtual",149);}
case 149:{f.Pc=119;continue;}
case 152:{f.Push(f.Locals[3]);f.Pc=153;continue;}
case 153:{return JStep.Return(f.Pop());}
case 154:{f.Push(f.Locals[2]);f.Pc=155;continue;}
case 155:{f.Pc=f.Pop().Int!=0?252:158;continue;}
case 158:{f.Push(f.Locals[5]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",165);}
case 165:{f.Push(JValue.I(1));f.Pc=166;continue;}
case 166:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?183:169;continue;}
case 169:{f.Push(f.Locals[5]);f.Pc=171;continue;}
case 171:{if(!rt.StaticReady(f,"forge/card/CardRarity","BasicLand","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","BasicLand","Lforge/card/CardRarity;"));f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",179);}
case 179:{f.StackOp("pop");f.Pc=180;continue;}
case 180:{f.Pc=252;continue;}
case 183:{f.Push(f.Locals[5]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",190);}
case 190:{f.Push(JValue.I(1));f.Pc=191;continue;}
case 191:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?252:194;continue;}
case 194:{f.Push(f.Locals[5]);f.Pc=196;continue;}
case 196:{f.Push(JValue.I(0));f.Pc=197;continue;}
case 197:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",202);}
case 202:{if(!rt.StaticReady(f,"forge/card/CardRarity","BasicLand","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","BasicLand","Lforge/card/CardRarity;"));f.Pc=205;continue;}
case 205:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?252:208;continue;}
case 208:{f.Push(f.Locals[0]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",212);}
case 212:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",215);}
case 215:{f.Locals[6]=f.Pop();f.Pc=217;continue;}
case 217:{f.Push(f.Locals[6]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",224);}
case 224:{f.Pc=f.Pop().Int==0?250:227;continue;}
case 227:{f.Push(f.Locals[6]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",234);}
case 234:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=237;continue;}
case 237:{f.Locals[7]=f.Pop();f.Pc=239;continue;}
case 239:{f.Push(f.Locals[0]);f.Pc=240;continue;}
case 240:{f.Push(f.Locals[7]);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[3]);f.Pc=243;continue;}
case 243:{f.Push(f.Locals[2]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/game/Game","chooseRandomCardsForAnte","(Lforge/game/player/Player;Lcom/google/common/collect/Multimap;Z)V","invokevirtual",247);}
case 247:{f.Pc=217;continue;}
case 250:{f.Push(f.Locals[3]);f.Pc=251;continue;}
case 251:{return JStep.Return(f.Pop());}
case 252:{f.Push(f.Locals[5]);f.Pc=254;continue;}
case 254:{if(!rt.StaticReady(f,"forge/card/CardRarity","Special","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Special","Lforge/card/CardRarity;"));f.Pc=257;continue;}
case 257:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",262);}
case 262:{f.Pc=f.Pop().Int==0?268:265;continue;}
case 265:{f.Push(JValue.I(0));f.Pc=266;continue;}
case 266:{f.Locals[4]=f.Pop();f.Pc=268;continue;}
case 268:{f.Push(f.Locals[5]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",273);}
case 273:{f.Push(f.Locals[5]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",280);}
case 280:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",283);}
case 283:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",288);}
case 288:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRarity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=291;continue;}
case 291:{f.Locals[6]=f.Pop();f.Pc=293;continue;}
case 293:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=296;continue;}
case 296:{f.Push(f.Locals[6]);f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/card/CardRarity","name","()Ljava/lang/String;","invokevirtual",301);}
case 301:{return rt.DynamicCall(f,"forge/game/Game:1985:301:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",306);}
case 306:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",309);}
case 309:{f.Push(f.Locals[0]);f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",313);}
case 313:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",316);}
case 316:{f.Locals[7]=f.Pop();f.Pc=318;continue;}
case 318:{f.Push(f.Locals[7]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",325);}
case 325:{f.Pc=f.Pop().Int==0?546:328;continue;}
case 328:{f.Push(f.Locals[7]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",335);}
case 335:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=338;continue;}
case 338:{f.Locals[8]=f.Pop();f.Pc=340;continue;}
case 340:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=343;continue;}
case 343:{f.StackOp("dup");f.Pc=344;continue;}
case 344:{f.Push(f.Locals[8]);f.Pc=346;continue;}
case 346:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=349;continue;}
case 349:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",352);}
case 352:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",355);}
case 355:{f.Locals[9]=f.Pop();f.Pc=357;continue;}
case 357:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=360;continue;}
case 360:{f.StackOp("dup");f.Pc=361;continue;}
case 361:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",364);}
case 364:{f.Locals[10]=f.Pop();f.Pc=366;continue;}
case 366:{f.Push(f.Locals[9]);f.Pc=368;continue;}
case 368:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",371);}
case 371:{f.Locals[11]=f.Pop();f.Pc=373;continue;}
case 373:{f.Push(f.Locals[11]);f.Pc=375;continue;}
case 375:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",380);}
case 380:{f.Pc=f.Pop().Int==0?484:383;continue;}
case 383:{f.Push(f.Locals[11]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",390);}
case 390:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=393;continue;}
case 393:{f.Locals[12]=f.Pop();f.Pc=395;continue;}
case 395:{f.Push(f.Locals[4]);f.Pc=397;continue;}
case 397:{f.Pc=f.Pop().Int==0?414:400;continue;}
case 400:{f.Push(f.Locals[12]);f.Pc=402;continue;}
case 402:{return rt.Call(f,"forge/game/card/Card","getRarity","()Lforge/card/CardRarity;","invokevirtual",405);}
case 405:{if(!rt.StaticReady(f,"forge/card/CardRarity","Special","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Special","Lforge/card/CardRarity;"));f.Pc=408;continue;}
case 408:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?414:411;continue;}
case 411:{f.Pc=373;continue;}
case 414:{f.Push(f.Locals[6]);f.Pc=416;continue;}
case 416:{if(!rt.StaticReady(f,"forge/card/CardRarity","MythicRare","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","MythicRare","Lforge/card/CardRarity;"));f.Pc=419;continue;}
case 419:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?430:422;continue;}
case 422:{f.Push(f.Locals[6]);f.Pc=424;continue;}
case 424:{if(!rt.StaticReady(f,"forge/card/CardRarity","Rare","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Rare","Lforge/card/CardRarity;"));f.Pc=427;continue;}
case 427:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?463:430;continue;}
case 430:{f.Push(f.Locals[12]);f.Pc=432;continue;}
case 432:{return rt.Call(f,"forge/game/card/Card","getRarity","()Lforge/card/CardRarity;","invokevirtual",435);}
case 435:{if(!rt.StaticReady(f,"forge/card/CardRarity","MythicRare","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","MythicRare","Lforge/card/CardRarity;"));f.Pc=438;continue;}
case 438:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?481:441;continue;}
case 441:{f.Push(f.Locals[12]);f.Pc=443;continue;}
case 443:{return rt.Call(f,"forge/game/card/Card","getRarity","()Lforge/card/CardRarity;","invokevirtual",446);}
case 446:{if(!rt.StaticReady(f,"forge/card/CardRarity","Rare","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Rare","Lforge/card/CardRarity;"));f.Pc=449;continue;}
case 449:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?481:452;continue;}
case 452:{f.Push(f.Locals[10]);f.Pc=454;continue;}
case 454:{f.Push(f.Locals[12]);f.Pc=456;continue;}
case 456:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",459);}
case 459:{f.StackOp("pop");f.Pc=460;continue;}
case 460:{f.Pc=481;continue;}
case 463:{f.Push(f.Locals[12]);f.Pc=465;continue;}
case 465:{return rt.Call(f,"forge/game/card/Card","getRarity","()Lforge/card/CardRarity;","invokevirtual",468);}
case 468:{f.Push(f.Locals[6]);f.Pc=470;continue;}
case 470:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?481:473;continue;}
case 473:{f.Push(f.Locals[10]);f.Pc=475;continue;}
case 475:{f.Push(f.Locals[12]);f.Pc=477;continue;}
case 477:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",480);}
case 480:{f.StackOp("pop");f.Pc=481;continue;}
case 481:{f.Pc=373;continue;}
case 484:{f.Push(f.Locals[9]);f.Pc=486;continue;}
case 486:{f.Push(f.Locals[10]);f.Pc=488;continue;}
case 488:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",491);}
case 491:{f.StackOp("pop");f.Pc=492;continue;}
case 492:{f.Push(f.Locals[9]);f.Pc=494;continue;}
case 494:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",497);}
case 497:{f.Pc=f.Pop().Int<=0?535:500;continue;}
case 500:{f.Push(f.Locals[9]);f.Pc=502;continue;}
case 502:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",505);}
case 505:{f.Push(f.Locals[9]);f.Pc=507;continue;}
case 507:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",510);}
case 510:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",513);}
case 513:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",516);}
case 516:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=519;continue;}
case 519:{f.Locals[11]=f.Pop();f.Pc=521;continue;}
case 521:{f.Push(f.Locals[3]);f.Pc=522;continue;}
case 522:{f.Push(f.Locals[8]);f.Pc=524;continue;}
case 524:{f.Push(f.Locals[11]);f.Pc=526;continue;}
case 526:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",531);}
case 531:{f.StackOp("pop");f.Pc=532;continue;}
case 532:{f.Pc=543;continue;}
case 535:{f.Push(f.Locals[0]);f.Pc=536;continue;}
case 536:{f.Push(f.Locals[8]);f.Pc=538;continue;}
case 538:{f.Push(f.Locals[3]);f.Pc=539;continue;}
case 539:{f.Push(f.Locals[2]);f.Pc=540;continue;}
case 540:{return rt.Call(f,"forge/game/Game","chooseRandomCardsForAnte","(Lforge/game/player/Player;Lcom/google/common/collect/Multimap;Z)V","invokevirtual",543);}
case 543:{f.Pc=318;continue;}
case 546:{f.Pc=591;continue;}
case 549:{f.Push(f.Locals[0]);f.Pc=550;continue;}
case 550:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",553);}
case 553:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",556);}
case 556:{f.Locals[4]=f.Pop();f.Pc=558;continue;}
case 558:{f.Push(f.Locals[4]);f.Pc=560;continue;}
case 560:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",565);}
case 565:{f.Pc=f.Pop().Int==0?591:568;continue;}
case 568:{f.Push(f.Locals[4]);f.Pc=570;continue;}
case 570:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",575);}
case 575:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=578;continue;}
case 578:{f.Locals[5]=f.Pop();f.Pc=580;continue;}
case 580:{f.Push(f.Locals[0]);f.Pc=581;continue;}
case 581:{f.Push(f.Locals[5]);f.Pc=583;continue;}
case 583:{f.Push(f.Locals[3]);f.Pc=584;continue;}
case 584:{f.Push(f.Locals[2]);f.Pc=585;continue;}
case 585:{return rt.Call(f,"forge/game/Game","chooseRandomCardsForAnte","(Lforge/game/player/Player;Lcom/google/common/collect/Multimap;Z)V","invokevirtual",588);}
case 588:{f.Pc=558;continue;}
case 591:{f.Push(f.Locals[3]);f.Pc=592;continue;}
case 592:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1986(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",7);}
case 7:{f.Locals[4]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Int==0?39:13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",18);}
case 18:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=21;continue;}
case 21:{f.Locals[5]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[5]);f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Reference==null?38:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[5]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",37);}
case 37:{f.StackOp("pop");f.Pc=38;continue;}
case 38:{return JStep.ReturnVoid;}
case 39:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","BASIC_LANDS","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","BASIC_LANDS","Ljava/util/function/Predicate;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/function/Predicate","negate","()Ljava/util/function/Predicate;","invokeinterface",47);}
case 47:{f.Locals[5]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[5]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/util/Collection;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",56);}
case 56:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",59);}
case 59:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=62;continue;}
case 62:{f.Locals[6]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[6]);f.Pc=66;continue;}
case 66:{f.Pc=f.Pop().Reference!=null?96:69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=73;continue;}
case 73:{f.StackOp("dup");f.Pc=74;continue;}
case 74:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","ANTE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","ANTE","Lforge/game/GameLogEntryType;"));f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String("Only basic lands found. Will ante one of them")));f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",83);}
case 83:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",86);}
case 86:{f.Push(f.Locals[4]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",91);}
case 91:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=94;continue;}
case 94:{f.Locals[6]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[6]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",105);}
case 105:{f.StackOp("pop");f.Pc=106;continue;}
case 106:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1987(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?81:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/card/Card","getRarity","()Lforge/card/CardRarity;","invokevirtual",38);}
case 38:{if(!rt.StaticReady(f,"forge/card/CardRarity","Rare","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Rare","Lforge/card/CardRarity;"));f.Pc=41;continue;}
case 41:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?54:44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/Card","getRarity","()Lforge/card/CardRarity;","invokevirtual",48);}
case 48:{if(!rt.StaticReady(f,"forge/card/CardRarity","MythicRare","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","MythicRare","Lforge/card/CardRarity;"));f.Pc=51;continue;}
case 51:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?67:54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{if(!rt.StaticReady(f,"forge/card/CardRarity","Rare","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Rare","Lforge/card/CardRarity;"));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",63);}
case 63:{f.StackOp("pop");f.Pc=64;continue;}
case 64:{f.Pc=78;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[3]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/card/Card","getRarity","()Lforge/card/CardRarity;","invokevirtual",72);}
case 72:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",77);}
case 77:{f.StackOp("pop");f.Pc=78;continue;}
case 78:{f.Pc=15;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1988(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","lastStateBattlefield","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","clear","()V","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","lastStateGraveyard","Lforge/game/card/CardCollection;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardCollection","clear","()V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1989(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getAllCards","()Lforge/game/card/CardCollectionView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?62:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("NeedsOrderedGraveyard")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/Card","hasSVar","(Ljava/lang/String;)Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int==0?41:39;continue;}
case 39:{f.Push(JValue.I(1));f.Pc=40;continue;}
case 40:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/Card","getOriginalState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",48);}
case 48:{f.Push(JValue.R(rt.String("NeedsOrderedGraveyard")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/card/CardState","hasSVar","(Ljava/lang/String;)Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int==0?59:57;continue;}
case 57:{f.Push(JValue.I(1));f.Pc=58;continue;}
case 58:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 59:{f.Pc=10;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/player/Player","getOpponents","()Lforge/game/player/PlayerCollection;","invokevirtual",66);}
case 66:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/player/PlayerCollection","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollection;","invokevirtual",72);}
case 72:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",75);}
case 75:{f.Locals[2]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",82);}
case 82:{f.Pc=f.Pop().Int==0?116:85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",91);}
case 91:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=94;continue;}
case 94:{f.Locals[3]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String("opponent")));f.Pc=98;continue;}
case 98:{f.Push(f.Locals[3]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String("NeedsOrderedGraveyard")));f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",105);}
case 105:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",108);}
case 108:{f.Pc=f.Pop().Int==0?113:111;continue;}
case 111:{f.Push(JValue.I(1));f.Pc=112;continue;}
case 112:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 113:{f.Pc=76;continue;}
case 116:{f.Push(JValue.I(0));f.Pc=117;continue;}
case 117:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1990(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(JValue.L(0));f.Pc=3;continue;}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",11);}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?69:23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[5]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[5]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/player/Player","getHighestControlVote","()Ljava/lang/Long;","invokevirtual",40);}
case 40:{f.Locals[6]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[6]);f.Pc=44;continue;}
case 44:{f.Pc=f.Pop().Reference==null?66:47;continue;}
case 47:{f.Push(f.Locals[6]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/Long","longValue","()J","invokevirtual",52);}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=54;continue;}
case 54:{f.Pc=f.Pop().Int<=0?66:57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/Long","longValue","()J","invokevirtual",62);}
case 62:{f.Locals[2]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[5]);f.Pc=65;continue;}
case 65:{f.Locals[1]=f.Pop();f.Pc=66;continue;}
case 66:{f.Pc=13;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1991(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.StackOp("dup");f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","numPiledGuessedSA","I"));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","numPiledGuessedSA","I",value);f.Pc=10;continue;}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1992(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","numPiledGuessedSA","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1993(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","numPiledGuessedSA","I",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1994(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","resetNumPiledGuessedSA","()V","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/Game","clearLeftBattlefieldThisTurn","()V","invokevirtual",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/Game","clearLeftGraveyardThisTurn","()V","invokevirtual",12);}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/Game","clearCountersThisTurn","()V","invokevirtual",16);}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/Game","clearGlobalDamageHistory","()V","invokevirtual",20);}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/Game","getRegisteredPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",27);}
case 27:{f.Locals[1]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",34);}
case 34:{f.Pc=f.Pop().Int==0?54:37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{f.Locals[2]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/player/Player","onCleanupPhase","()V","invokevirtual",51);}
case 51:{f.Pc=28;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/Game","getCardsIncludePhasingIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",61);}
case 61:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",66);}
case 66:{f.Locals[1]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",73);}
case 73:{f.Pc=f.Pop().Int==0?121:76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",82);}
case 82:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=85;continue;}
case 85:{f.Locals[2]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",91);}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",95);}
case 95:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?108:101;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",105);}
case 105:{f.Pc=115;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",112);}
case 112:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",115);}
case 115:{return rt.Call(f,"forge/game/card/Card","onCleanupPhase","(Lforge/game/player/Player;)V","invokevirtual",118);}
case 118:{f.Pc=67;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/Game","getCardsInGame","()Lforge/game/card/CardCollectionView;","invokevirtual",125);}
case 125:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",130);}
case 130:{f.Locals[1]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[1]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",137);}
case 137:{f.Pc=f.Pop().Int==0?157:140;continue;}
case 140:{f.Push(f.Locals[1]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",146);}
case 146:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=149;continue;}
case 149:{f.Locals[2]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[2]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/card/Card","resetActivationsPerTurn","()V","invokevirtual",154);}
case 154:{f.Pc=131;continue;}
case 157:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1995(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?16:4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference==null?16:8;continue;}
case 8:{f.Push(f.Locals[4]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int>0?17:16;continue;}
case 16:{return JStep.ReturnVoid;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","countersAddedThisTurn","Lcom/google/common/collect/Table;"));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"com/google/common/collect/Table","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Reference!=null?57:38;continue;}
case 38:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",41);}
case 41:{f.Locals[5]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","countersAddedThisTurn","Lcom/google/common/collect/Table;"));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"com/google/common/collect/Table","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",56);}
case 56:{f.StackOp("pop");f.Pc=57;continue;}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",63);}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",68);}
case 68:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",73);}
case 73:{f.StackOp("pop");f.Pc=74;continue;}
case 74:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1996(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[7]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?21:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","countersAddedThisTurn","Lcom/google/common/collect/Table;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"com/google/common/collect/Table","rowKeySet","()Ljava/util/Set;","invokeinterface",16);}
case 16:{f.Locals[8]=f.Pop();f.Pc=18;continue;}
case 18:{f.Pc=50;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","countersAddedThisTurn","Lcom/google/common/collect/Table;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"com/google/common/collect/Table","containsRow","(Ljava/lang/Object;)Z","invokeinterface",31);}
case 31:{f.Pc=f.Pop().Int!=0?37:34;continue;}
case 34:{f.Push(f.Locals[7]);f.Pc=36;continue;}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/CounterType;",f.Pop().Int)));f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=45;continue;}
case 45:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","([Ljava/lang/Object;)Ljava/util/HashSet;","invokestatic",48);}
case 48:{f.Locals[8]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[8]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",57);}
case 57:{f.Locals[9]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[9]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",66);}
case 66:{f.Pc=f.Pop().Int==0?246:69;continue;}
case 69:{f.Push(f.Locals[9]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",76);}
case 76:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=79;continue;}
case 79:{f.Locals[10]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","countersAddedThisTurn","Lcom/google/common/collect/Table;"));f.Pc=85;continue;}
case 85:{f.Push(f.Locals[10]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"com/google/common/collect/Table","row","(Ljava/lang/Object;)Ljava/util/Map;","invokeinterface",92);}
case 92:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",97);}
case 97:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",102);}
case 102:{f.Locals[11]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[11]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",111);}
case 111:{f.Pc=f.Pop().Int==0?243:114;continue;}
case 114:{f.Push(f.Locals[11]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",121);}
case 121:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=124;continue;}
case 124:{f.Locals[12]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[12]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",133);}
case 133:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[2]);f.Pc=137;continue;}
case 137:{f.Push(JValue.R(rt.String(",")));f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",143);}
case 143:{f.Push(f.Locals[5]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[4]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[6]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/player/Player","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",152);}
case 152:{f.Pc=f.Pop().Int==0?240:155;continue;}
case 155:{f.Push(f.Locals[12]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",162);}
case 162:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",170);}
case 170:{f.Locals[13]=f.Pop();f.Pc=172;continue;}
case 172:{f.Push(f.Locals[13]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",179);}
case 179:{f.Pc=f.Pop().Int==0?240:182;continue;}
case 182:{f.Push(f.Locals[13]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",189);}
case 189:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=192;continue;}
case 192:{f.Locals[14]=f.Pop();f.Pc=194;continue;}
case 194:{f.Push(f.Locals[14]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getKey","()Ljava/lang/Object;","invokevirtual",199);}
case 199:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=202;continue;}
case 202:{f.Push(f.Locals[3]);f.Pc=203;continue;}
case 203:{f.Push(JValue.R(rt.String(",")));f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",209);}
case 209:{f.Push(f.Locals[5]);f.Pc=211;continue;}
case 211:{f.Push(f.Locals[4]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[6]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/card/Card","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",218);}
case 218:{f.Pc=f.Pop().Int==0?237:221;continue;}
case 221:{f.Push(f.Locals[7]);f.Pc=223;continue;}
case 223:{f.Push(f.Locals[14]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getValue","()Ljava/lang/Object;","invokevirtual",228);}
case 228:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",234);}
case 234:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=235;continue;}
case 235:{f.Locals[7]=f.Pop();f.Pc=237;continue;}
case 237:{f.Pc=172;continue;}
case 240:{f.Pc=104;continue;}
case 243:{f.Pc=59;continue;}
case 246:{f.Push(f.Locals[7]);f.Pc=248;continue;}
case 248:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1997(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[3]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Reference!=null?20:6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","countersAddedThisTurn","Lcom/google/common/collect/Table;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/collect/Table","rowKeySet","()Ljava/util/Set;","invokeinterface",15);}
case 15:{f.Locals[4]=f.Pop();f.Pc=17;continue;}
case 17:{f.Pc=48;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","countersAddedThisTurn","Lcom/google/common/collect/Table;"));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"com/google/common/collect/Table","containsRow","(Ljava/lang/Object;)Z","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int!=0?35:33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 35:{f.Push(JValue.I(1));f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/CounterType;",f.Pop().Int)));f.Pc=39;continue;}
case 39:{f.StackOp("dup");f.Pc=40;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=43;continue;}
case 43:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","([Ljava/lang/Object;)Ljava/util/HashSet;","invokestatic",46);}
case 46:{f.Locals[4]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",55);}
case 55:{f.Locals[5]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",64);}
case 64:{f.Pc=f.Pop().Int==0?193:67;continue;}
case 67:{f.Push(f.Locals[5]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",74);}
case 74:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=77;continue;}
case 77:{f.Locals[6]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","countersAddedThisTurn","Lcom/google/common/collect/Table;"));f.Pc=83;continue;}
case 83:{f.Push(f.Locals[6]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"com/google/common/collect/Table","row","(Ljava/lang/Object;)Ljava/util/Map;","invokeinterface",90);}
case 90:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",95);}
case 95:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",100);}
case 100:{f.Locals[7]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[7]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",109);}
case 109:{f.Pc=f.Pop().Int==0?190:112;continue;}
case 112:{f.Push(f.Locals[7]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",119);}
case 119:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=122;continue;}
case 122:{f.Locals[8]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[8]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",131);}
case 131:{f.Locals[9]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(f.Locals[9]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",140);}
case 140:{f.Pc=f.Pop().Int==0?187:143;continue;}
case 143:{f.Push(f.Locals[9]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",150);}
case 150:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=153;continue;}
case 153:{f.Locals[10]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[10]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getKey","()Ljava/lang/Object;","invokevirtual",160);}
case 160:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=163;continue;}
case 163:{f.Push(f.Locals[2]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",167);}
case 167:{f.Pc=f.Pop().Int==0?184:170;continue;}
case 170:{f.Push(f.Locals[3]);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[10]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getValue","()Ljava/lang/Object;","invokevirtual",176);}
case 176:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",182);}
case 182:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=183;continue;}
case 183:{f.Locals[3]=f.Pop();f.Pc=184;continue;}
case 184:{f.Pc=133;continue;}
case 187:{f.Pc=102;continue;}
case 190:{f.Pc=57;continue;}
case 193:{f.Push(f.Locals[3]);f.Pc=194;continue;}
case 194:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1998(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","countersAddedThisTurn","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/Table","clear","()V","invokeinterface",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","countersRemovedThisTurn","Lcom/google/common/collect/Multimap;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"com/google/common/collect/Multimap","clear","()V","invokeinterface",18);}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1999(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","countersRemovedThisTurn","Lcom/google/common/collect/Multimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",9);}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",13);}
case 13:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",18);}
case 18:{f.StackOp("pop");f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2000(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","countersRemovedThisTurn","Lcom/google/common/collect/Multimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",10);}
case 10:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",15);}
case 15:{f.StackOp("pop");f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2001(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[6]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","countersRemovedThisTurn","Lcom/google/common/collect/Multimap;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",13);}
case 13:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",18);}
case 18:{f.Locals[7]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[7]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int==0?87:30;continue;}
case 30:{f.Push(f.Locals[7]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Locals[8]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[8]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getKey","()Ljava/lang/Object;","invokevirtual",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String(",")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",57);}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[5]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/GameEntity","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?84:68;continue;}
case 68:{f.Push(f.Locals[6]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[8]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getValue","()Ljava/lang/Object;","invokevirtual",75);}
case 75:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",81);}
case 81:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=82;continue;}
case 82:{f.Locals[6]=f.Pop();f.Pc=84;continue;}
case 84:{f.Pc=20;continue;}
case 87:{f.Push(f.Locals[6]);f.Pc=89;continue;}
case 89:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2002(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[8]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","globalDamageHistory","Lforge/util/collect/FCollection;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",12);}
case 12:{f.Locals[9]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[9]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?85:24;continue;}
case 24:{f.Push(f.Locals[9]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardDamageHistory"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[10]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[10]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[5]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[6]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[7]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/card/CardDamageHistory","getDamageDoneThisTurn","(Ljava/lang/Boolean;ZLjava/lang/String;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/CardTraitBase;)I","invokevirtual",52);}
case 52:{f.Locals[11]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[11]);f.Pc=56;continue;}
case 56:{f.Pc=f.Pop().Int!=0?62:59;continue;}
case 59:{f.Pc=14;continue;}
case 62:{f.Push(f.Locals[8]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[11]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",69);}
case 69:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",74);}
case 74:{f.StackOp("pop");f.Pc=75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{f.Pc=f.Pop().Int==0?82:79;continue;}
case 79:{f.Pc=85;continue;}
case 82:{f.Pc=14;continue;}
case 85:{f.Push(f.Locals[8]);f.Pc=87;continue;}
case 87:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2003(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","globalDamageHistory","Lforge/util/collect/FCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FCollection","stream","()Ljava/util/stream/Stream;","invokevirtual",7);}
case 7:{return rt.DynamicCall(f,"forge/game/Game:2003:7:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",12);}
case 12:{return rt.Call(f,"java/util/stream/Stream","flatMap","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",17);}
case 17:{return rt.DynamicCall(f,"forge/game/Game:2003:17:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToIntFunction;",22);}
case 22:{return rt.Call(f,"java/util/stream/Stream","mapToInt","(Ljava/util/function/ToIntFunction;)Ljava/util/stream/IntStream;","invokeinterface",27);}
case 27:{return rt.Call(f,"java/util/stream/IntStream","max","()Ljava/util/OptionalInt;","invokeinterface",32);}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/OptionalInt","orElse","(I)I","invokevirtual",36);}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2004(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","globalDamageHistory","Lforge/util/collect/FCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{f.StackOp("pop");f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","damageThisTurnLKI","Ljava/util/IdentityHashMap;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",20);}
case 20:{return rt.Call(f,"java/util/IdentityHashMap","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2005(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","globalDamageHistory","Lforge/util/collect/FCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FCollection","clear","()V","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","damageThisTurnLKI","Ljava/util/IdentityHashMap;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/IdentityHashMap","clear","()V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2006(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","damageThisTurnLKI","Ljava/util/IdentityHashMap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/IdentityHashMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",8);}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2007(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","topLibsCast","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2008(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",14);}
case 14:{f.Pc=f.Pop().Int==0?68:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","topLibsCast","Ljava/util/Map;"));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/player/Player","getTopXCardsFromLibrary","(I)Lforge/game/card/CardCollection;","invokevirtual",37);}
case 37:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int==0?47:43;continue;}
case 43:{f.Push(JValue.R(null));f.Pc=44;continue;}
case 44:{f.Pc=59;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{f.Push(JValue.I(1));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/player/Player","getTopXCardsFromLibrary","(I)Lforge/game/card/CardCollection;","invokevirtual",52);}
case 52:{f.Push(JValue.I(0));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",56);}
case 56:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",64);}
case 64:{f.StackOp("pop");f.Pc=65;continue;}
case 65:{f.Pc=8;continue;}
case 68:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2009(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/player/Player","getPaidForSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Reference!=null?149:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","topLibsCast","Ljava/util/Map;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","facedownWhileCasting","Ljava/util/Map;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",28);}
case 28:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",33);}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",40);}
case 40:{f.Pc=f.Pop().Int==0?140:43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{f.Locals[3]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int==0?137:63;continue;}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/card/Card","forceTurnFaceUp","()V","invokevirtual",67);}
case 67:{f.Push(f.Locals[3]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",71);}
case 71:{f.Locals[4]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[4]);f.Pc=75;continue;}
case 75:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"));f.Pc=78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","facedownWhileCasting","Ljava/util/Map;"));f.Pc=82;continue;}
case 82:{f.Push(f.Locals[3]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",88);}
case 88:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",93);}
case 93:{f.StackOp("pop");f.Pc=94;continue;}
case 94:{f.Push(f.Locals[4]);f.Pc=96;continue;}
case 96:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=99;continue;}
case 99:{f.Push(f.Locals[3]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",103);}
case 103:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",108);}
case 108:{f.StackOp("pop");f.Pc=109;continue;}
case 109:{f.Push(f.Locals[4]);f.Pc=111;continue;}
case 111:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CanReveal","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CanReveal","Lforge/game/ability/AbilityKey;"));f.Pc=114;continue;}
case 114:{f.Push(JValue.I(1));f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",118);}
case 118:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",123);}
case 123:{f.StackOp("pop");f.Pc=124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",128);}
case 128:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Drawn","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Drawn","Lforge/game/trigger/TriggerType;"));f.Pc=131;continue;}
case 131:{f.Push(f.Locals[4]);f.Pc=133;continue;}
case 133:{f.Push(JValue.I(1));f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",137);}
case 137:{f.Pc=34;continue;}
case 140:{f.Push(f.Locals[0]);f.Pc=141;continue;}
case 141:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","facedownWhileCasting","Ljava/util/Map;"));f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",149);}
case 149:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2010(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","facedownWhileCasting","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",9);}
case 9:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2011(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","daytime","Ljava/lang/Boolean;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?21:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","daytime","Ljava/lang/Boolean;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int!=0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2012(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","daytime","Ljava/lang/Boolean;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?22:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","daytime","Ljava/lang/Boolean;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",14);}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?22:18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{f.Pc=23;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2013(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","daytime","Ljava/lang/Boolean;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2014(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","daytime","Ljava/lang/Boolean;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2015(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantChangeDayTime","cantChangeDay","(Lforge/game/Game;Ljava/lang/Boolean;)Z","invokestatic",5);}
case 5:{f.Pc=f.Pop().Int==0?9:8;continue;}
case 8:{return JStep.ReturnVoid;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","daytime","Ljava/lang/Boolean;"));f.Pc=13;continue;}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","daytime","Ljava/lang/Boolean;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Reference==null?48:23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Reference==null?48:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?48:32;continue;}
case 32:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",35);}
case 35:{f.Locals[3]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",40);}
case 40:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","DayTimeChanges","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","DayTimeChanges","Lforge/game/trigger/TriggerType;"));f.Pc=43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{f.Push(JValue.I(0));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",48);}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/Game","isNeitherDayNorNight","()Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int!=0?70:55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventDayTimeChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventDayTimeChanged")));f.Pc=59;continue;}
case 59:{f.StackOp("dup");f.Pc=60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/Game","isDay","()Z","invokevirtual",64);}
case 64:{return rt.Call(f,"forge/game/event/GameEventDayTimeChanged","<init>","(Z)V","invokespecial",67);}
case 67:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",70);}
case 70:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2016(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getLeftBattlefieldThisTurn","()Ljava/util/List;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",9);}
case 9:{return rt.DynamicCall(f,"forge/game/Game:2016:9:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",14);}
case 14:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int!=0?47:22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",26);}
case 26:{return rt.Call(f,"forge/game/zone/MagicStack","getSpellsCastThisTurn","()Ljava/util/List;","invokevirtual",29);}
case 29:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",34);}
case 34:{return rt.DynamicCall(f,"forge/game/Game:2016:34:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",39);}
case 39:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",44);}
case 44:{f.Pc=f.Pop().Int==0?51:47;continue;}
case 47:{f.Push(JValue.I(1));f.Pc=48;continue;}
case 48:{f.Pc=52;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2017(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","AI_TIMEOUT","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2018(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","AI_FLAT_MONTE_CARLO","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2019(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","AI_FLAT_MONTE_CARLO_MAX","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2020(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","AI_FLAT_MONTE_CARLO_LITE","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2021(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","noGUIUser","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2022(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Game","noGUIUser","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2023(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isLand","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2024(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",4);}
case 4:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2025(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardDamageHistory","getAllDmgInstances","()Ljava/util/List;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2026(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getSpellAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?49:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",33);}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getZone","()Lforge/game/zone/ZoneType;","invokevirtual",36);}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?46:44;continue;}
case 44:{f.Push(JValue.I(1));f.Pc=45;continue;}
case 45:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 46:{f.Pc=10;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2027(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("NETWORK")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"org/tinylog/Logger","tag","(Ljava/lang/String;)Lorg/tinylog/TaggedLogger;","invokestatic",6);}
case 6:{if(!rt.StaticReady(f,"forge/game/Game","netLog","Lorg/tinylog/TaggedLogger;"))return JStep.Continue;rt.PutStatic("forge/game/Game","netLog","Lorg/tinylog/TaggedLogger;",f.Pop());f.Pc=9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/game/Game","maxId","I"))return JStep.Continue;rt.PutStatic("forge/game/Game","maxId","I",f.Pop());f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/zone/ZoneType","values","()[Lforge/game/zone/ZoneType;","invokestatic",16);}
case 16:{if(!rt.StaticReady(f,"forge/game/Game","ALL_ZONE_TYPES","[Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/Game","ALL_ZONE_TYPES","[Lforge/game/zone/ZoneType;",f.Pop());f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

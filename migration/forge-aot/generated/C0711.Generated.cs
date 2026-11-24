// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C711{
internal static JClass Build(){var c=new JClass("forge/game/player/PlayerController","java/lang/Object",new string[]{},1057);Add0(c);Add1(c);Add2(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("fullControls","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("gameView","Lforge/game/GameView;",false,JValue.Default("Lforge/game/GameView;"),null));
c.Add(new JField("player","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("lobbyPlayer","Lforge/LobbyPlayer;",false,JValue.Default("Lforge/LobbyPlayer;"),null));
c.Add(new JMethod(8458,"forge/game/player/PlayerController","<init>","(Lforge/game/Game;Lforge/game/player/Player;Lforge/LobbyPlayer;)V",1,4,2,new JHandler[]{},M8458));
c.Add(new JMethod(8459,"forge/game/player/PlayerController","isAI","()Z",1,1,1,new JHandler[]{},M8459));
c.Add(new JMethod(8460,"forge/game/player/PlayerController","getGame","()Lforge/game/Game;",1,1,1,new JHandler[]{},M8460));
c.Add(new JMethod(8461,"forge/game/player/PlayerController","getMatch","()Lforge/game/Match;",1,1,1,new JHandler[]{},M8461));
c.Add(new JMethod(8462,"forge/game/player/PlayerController","getPlayer","()Lforge/game/player/Player;",1,1,1,new JHandler[]{},M8462));
c.Add(new JMethod(8463,"forge/game/player/PlayerController","getLobbyPlayer","()Lforge/LobbyPlayer;",1,1,1,new JHandler[]{},M8463));
c.Add(new JMethod(8464,"forge/game/player/PlayerController","tempShowCards","(Ljava/lang/Iterable;)V",1,2,0,new JHandler[]{},M8464));
c.Add(new JMethod(8465,"forge/game/player/PlayerController","endTempShowCards","()V",1,1,0,new JHandler[]{},M8465));
c.Add(new JMethod(8466,"forge/game/player/PlayerController","getAbilityToPlay","(Lforge/game/card/Card;Ljava/util/List;)Lforge/game/spellability/SpellAbility;",17,3,4,new JHandler[]{},M8466));
c.Add(new JMethod(8467,"forge/game/player/PlayerController","getAbilityToPlay","(Lforge/game/card/Card;Ljava/util/List;Lforge/util/ITriggerEvent;)Lforge/game/spellability/SpellAbility;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8468,"forge/game/player/PlayerController","playSpellAbilityNoStack","(Lforge/game/spellability/SpellAbility;Z)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8469,"forge/game/player/PlayerController","orderSimultaneousSa","(Ljava/util/List;)Ljava/util/List;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8470,"forge/game/player/PlayerController","orderAndPlaySimultaneousSa","(Ljava/util/List;)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8471,"forge/game/player/PlayerController","playedByTeammate","(Lforge/game/spellability/SpellAbility;)Z",20,3,5,new JHandler[]{},M8471));
c.Add(new JMethod(8472,"forge/game/player/PlayerController","playTrigger","(Lforge/game/card/Card;Lforge/game/trigger/WrappedAbility;Z)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8473,"forge/game/player/PlayerController","playSaFromPlayEffect","(Lforge/game/spellability/SpellAbility;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8474,"forge/game/player/PlayerController","sideboard","(Lforge/deck/Deck;Lforge/game/GameType;Ljava/lang/String;)Ljava/util/List;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8475,"forge/game/player/PlayerController","sideboardsByItself","()Z",1,1,1,new JHandler[]{},M8475));
c.Add(new JMethod(8476,"forge/game/player/PlayerController","getSideboardingReport","()Ljava/util/List;",1,1,1,new JHandler[]{},M8476));
c.Add(new JMethod(8477,"forge/game/player/PlayerController","chooseCardsYouWonToAddToDeck","(Ljava/util/List;)Ljava/util/List;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8478,"forge/game/player/PlayerController","assignCombatDamage","(Lforge/game/card/Card;Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;ILforge/game/GameEntity;Z)Ljava/util/Map;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8479,"forge/game/player/PlayerController","divideShield","(Lforge/game/card/Card;Ljava/util/Map;I)Ljava/util/Map;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8480,"forge/game/player/PlayerController","specifyManaCombo","(Lforge/game/spellability/SpellAbility;Lforge/card/ColorSet;IZ)Ljava/util/Map;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8481,"forge/game/player/PlayerController","choosePermanentsToSacrifice","(Lforge/game/spellability/SpellAbility;IILforge/game/card/CardCollectionView;Ljava/lang/String;)Lforge/game/card/CardCollectionView;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8482,"forge/game/player/PlayerController","choosePermanentsToDestroy","(Lforge/game/spellability/SpellAbility;IILforge/game/card/CardCollectionView;Ljava/lang/String;)Lforge/game/card/CardCollectionView;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8483,"forge/game/player/PlayerController","announceRequirements","(Lforge/game/spellability/SpellAbility;IILjava/lang/String;)Ljava/lang/Integer;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8484,"forge/game/player/PlayerController","chooseNewTargetsFor","(Lforge/game/spellability/SpellAbility;Ljava/util/function/Predicate;Z)Lforge/game/spellability/TargetChoices;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8485,"forge/game/player/PlayerController","chooseTargetsFor","(Lforge/game/spellability/SpellAbility;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8486,"forge/game/player/PlayerController","chooseTarget","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)Lorg/apache/commons/lang3/tuple/Pair;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8487,"forge/game/player/PlayerController","helpPayForAssistSpell","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;II)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8488,"forge/game/player/PlayerController","choosePlayerToAssistPayment","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;I)Lforge/game/player/Player;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8489,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8490,"forge/game/player/PlayerController","chooseCardsForEffectMultiple","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Z)Lforge/game/card/CardCollection;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8491,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;",17,5,8,new JHandler[]{},M8491));
c.Add(new JMethod(8492,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;",17,6,8,new JHandler[]{},M8492));
c.Add(new JMethod(8493,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/player/DelayedReveal;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLforge/game/player/Player;Ljava/util/Map;)Lforge/game/GameEntity;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8494,"forge/game/player/PlayerController","chooseEntitiesForEffect","(Lforge/util/collect/FCollectionView;IILforge/game/player/DelayedReveal;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/Player;Ljava/util/Map;)Ljava/util/List;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8495,"forge/game/player/PlayerController","chooseSpellAbilitiesForEffect","(Ljava/util/List;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ILjava/util/Map;)Ljava/util/List;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8496,"forge/game/player/PlayerController","chooseSingleSpellForEffect","(Ljava/util/List;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/spellability/SpellAbility;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8497,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z",17,5,7,new JHandler[]{},M8497));
c.Add(new JMethod(8498,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z",17,6,7,new JHandler[]{},M8498));
c.Add(new JMethod(8499,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/List;Lforge/game/card/Card;Ljava/util/Map;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8500,"forge/game/player/PlayerController","confirmBidAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;ILforge/game/player/Player;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8501,"forge/game/player/PlayerController","confirmReplacementEffect","(Lforge/game/replacement/ReplacementEffect;Lforge/game/spellability/SpellAbility;Lforge/game/GameEntity;Ljava/lang/String;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8502,"forge/game/player/PlayerController","confirmStaticApplication","(Lforge/game/card/Card;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/lang/String;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8503,"forge/game/player/PlayerController","confirmTrigger","(Lforge/game/trigger/WrappedAbility;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8504,"forge/game/player/PlayerController","exertAttackers","(Ljava/util/List;)Ljava/util/List;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8505,"forge/game/player/PlayerController","enlistAttackers","(Ljava/util/List;)Ljava/util/List;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8506,"forge/game/player/PlayerController","declareAttackers","(Lforge/game/player/Player;Lforge/game/combat/Combat;)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8507,"forge/game/player/PlayerController","declareBlockers","(Lforge/game/player/Player;Lforge/game/combat/Combat;)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8508,"forge/game/player/PlayerController","orderBlockers","(Lforge/game/card/Card;Lforge/game/card/CardCollection;)Lforge/game/card/CardCollection;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8509,"forge/game/player/PlayerController","orderBlocker","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/card/CardCollection;)Lforge/game/card/CardCollection;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8510,"forge/game/player/PlayerController","orderAttackers","(Lforge/game/card/Card;Lforge/game/card/CardCollection;)Lforge/game/card/CardCollection;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8511,"forge/game/player/PlayerController","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/player/Player;)V",17,4,5,new JHandler[]{},M8511));
c.Add(new JMethod(8512,"forge/game/player/PlayerController","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/player/Player;Ljava/lang/String;)V",17,5,6,new JHandler[]{},M8512));
c.Add(new JMethod(8513,"forge/game/player/PlayerController","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/player/Player;Ljava/lang/String;Z)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8514,"forge/game/player/PlayerController","reveal","(Ljava/util/List;Lforge/game/zone/ZoneType;Lforge/game/player/PlayerView;Ljava/lang/String;)V",17,5,6,new JHandler[]{},M8514));
c.Add(new JMethod(8515,"forge/game/player/PlayerController","reveal","(Lforge/game/player/DelayedReveal;)V",17,4,5,new JHandler[]{},M8515));
c.Add(new JMethod(8516,"forge/game/player/PlayerController","reveal","(Ljava/util/List;Lforge/game/zone/ZoneType;Lforge/game/player/PlayerView;Ljava/lang/String;Z)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8517,"forge/game/player/PlayerController","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;)V",1025,0,0,new JHandler[]{},null));
}

private static void Add1(JClass c){
c.Add(new JMethod(8518,"forge/game/player/PlayerController","arrangeForScry","(Lforge/game/card/CardCollection;)Lorg/apache/commons/lang3/tuple/ImmutablePair;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8519,"forge/game/player/PlayerController","arrangeForSurveil","(Lforge/game/card/CardCollection;)Lorg/apache/commons/lang3/tuple/ImmutablePair;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8520,"forge/game/player/PlayerController","willPutCardOnTop","(Lforge/game/card/Card;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8521,"forge/game/player/PlayerController","orderMoveToZoneList","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8522,"forge/game/player/PlayerController","orderedMoveToTopOfLibrary","(Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Z",4,4,3,new JHandler[]{},M8522));
c.Add(new JMethod(8523,"forge/game/player/PlayerController","chooseCardsToDiscardFrom","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;II)Lforge/game/card/CardCollectionView;",1,6,7,new JHandler[]{},M8523));
c.Add(new JMethod(8524,"forge/game/player/PlayerController","chooseCardsToDiscardFrom","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;IILforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8525,"forge/game/player/PlayerController","chooseCardsToDiscardUnlessType","(ILforge/game/card/CardCollectionView;[Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8526,"forge/game/player/PlayerController","chooseCardsToDiscardToMaximumHandSize","(I)Lforge/game/card/CardCollectionView;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8527,"forge/game/player/PlayerController","chooseCardsToDelve","(ILforge/game/card/CardCollection;)Lforge/game/card/CardCollectionView;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8528,"forge/game/player/PlayerController","chooseCardsForConvokeOrImprovise","(Lforge/game/spellability/SpellAbility;Lforge/card/mana/ManaCost;Lforge/game/card/CardCollectionView;ZZLjava/lang/Integer;)Ljava/util/Map;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8529,"forge/game/player/PlayerController","chooseCardsForSplice","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)Ljava/util/List;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8530,"forge/game/player/PlayerController","chooseCardsToRevealFromHand","(IILforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8531,"forge/game/player/PlayerController","chooseSaToActivateFromOpeningHand","(Ljava/util/List;)Ljava/util/List;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8532,"forge/game/player/PlayerController","chooseStartingPlayer","(Z)Lforge/game/player/Player;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8533,"forge/game/player/PlayerController","chooseStartingHand","(Ljava/util/List;)Lforge/game/zone/PlayerZone;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8534,"forge/game/player/PlayerController","chooseManaFromPool","(Ljava/util/List;)Lforge/game/mana/Mana;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8535,"forge/game/player/PlayerController","chooseSomeType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Ljava/util/Collection;Z)Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8536,"forge/game/player/PlayerController","chooseSomeType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Ljava/util/Collection;)Ljava/lang/String;",17,4,5,new JHandler[]{},M8536));
c.Add(new JMethod(8537,"forge/game/player/PlayerController","chooseSector","(Lforge/game/card/Card;Ljava/lang/String;Ljava/util/List;)Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8538,"forge/game/player/PlayerController","chooseSticker","(Ljava/util/List;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Z)Lforge/game/card/sticker/Sticker;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8539,"forge/game/player/PlayerController","chooseStickerNamePosition","(Lforge/game/card/sticker/Sticker;Lforge/game/card/Card;)I",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8540,"forge/game/player/PlayerController","chooseCardToKeepStickers","(Lforge/game/card/CardCollectionView;)Lforge/game/card/Card;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8541,"forge/game/player/PlayerController","chooseSector","(Lforge/game/card/Card;Ljava/lang/String;)Ljava/lang/String;",17,4,4,new JHandler[]{},M8541));
c.Add(new JMethod(8542,"forge/game/player/PlayerController","chooseContraptionsToCrank","(Ljava/util/List;)Ljava/util/List;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8543,"forge/game/player/PlayerController","chooseSprocket","(Lforge/game/card/Card;Ljava/util/List;)I",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8544,"forge/game/player/PlayerController","chooseSprocket","(Lforge/game/card/Card;)I",17,2,5,new JHandler[]{},M8544));
c.Add(new JMethod(8545,"forge/game/player/PlayerController","choosePDRollToIgnore","(Ljava/util/List;)Lforge/game/PlanarDice;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8546,"forge/game/player/PlayerController","chooseRollToIgnore","(Ljava/util/List;)Ljava/lang/Integer;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8547,"forge/game/player/PlayerController","chooseDiceToReroll","(Ljava/util/List;)Ljava/util/List;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8548,"forge/game/player/PlayerController","chooseRollToModify","(Ljava/util/List;)Ljava/lang/Integer;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8549,"forge/game/player/PlayerController","chooseRollToSwap","(Ljava/util/List;)Lforge/game/ability/effects/RollDiceEffect$DieRollResult;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8550,"forge/game/player/PlayerController","chooseRollSwapValue","(Ljava/util/List;Ljava/lang/Integer;II)Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8551,"forge/game/player/PlayerController","vote","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/List;Lcom/google/common/collect/ListMultimap;Lforge/game/player/Player;Z)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8552,"forge/game/player/PlayerController","mulliganKeepHand","(Lforge/game/player/Player;I)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8553,"forge/game/player/PlayerController","tuckCardsViaMulligan","(Lforge/game/card/CardCollectionView;I)Lforge/game/card/CardCollectionView;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8554,"forge/game/player/PlayerController","chooseSpellAbilityToPlay","()Ljava/util/List;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8555,"forge/game/player/PlayerController","playChosenSpellAbility","(Lforge/game/spellability/SpellAbility;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8556,"forge/game/player/PlayerController","chooseModeForAbility","(Lforge/game/spellability/SpellAbility;Ljava/util/List;IIZ)Ljava/util/List;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8557,"forge/game/player/PlayerController","chooseNumberForCostReduction","(Lforge/game/spellability/SpellAbility;II)I",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8558,"forge/game/player/PlayerController","chooseNumberForKeywordCost","(Lforge/game/spellability/SpellAbility;Lforge/game/cost/Cost;Lforge/game/keyword/KeywordInterface;Ljava/lang/String;I)I",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8559,"forge/game/player/PlayerController","addKeywordCost","(Lforge/game/spellability/SpellAbility;Lforge/game/cost/Cost;Lforge/game/keyword/KeywordInterface;Ljava/lang/String;)Z",1,5,6,new JHandler[]{},M8559));
c.Add(new JMethod(8560,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;II)I",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8561,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/List;Lforge/game/player/Player;)I",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8562,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;IILjava/util/Map;)I",1,6,5,new JHandler[]{},M8562));
c.Add(new JMethod(8563,"forge/game/player/PlayerController","chooseBinary","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/PlayerController$BinaryChoiceType;)Z",17,4,5,new JHandler[]{},M8563));
c.Add(new JMethod(8564,"forge/game/player/PlayerController","chooseBinary","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/PlayerController$BinaryChoiceType;Ljava/lang/Boolean;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8565,"forge/game/player/PlayerController","chooseBinary","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/PlayerController$BinaryChoiceType;Ljava/util/Map;)Z",1,5,4,new JHandler[]{},M8565));
c.Add(new JMethod(8566,"forge/game/player/PlayerController","chooseFlipResult","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8567,"forge/game/player/PlayerController","chooseColor","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/card/ColorSet;)B",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8568,"forge/game/player/PlayerController","chooseColorAllowColorless","(Ljava/lang/String;Lforge/game/card/Card;Lforge/card/ColorSet;)B",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8569,"forge/game/player/PlayerController","chooseColors","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;IILforge/card/ColorSet;)Lforge/card/ColorSet;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8570,"forge/game/player/PlayerController","chooseSingleCardFace","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/function/Predicate;Ljava/lang/String;)Lforge/card/ICardFace;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8571,"forge/game/player/PlayerController","chooseSingleCardFace","(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;)Lforge/card/ICardFace;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8572,"forge/game/player/PlayerController","chooseSingleCardState","(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)Lforge/game/card/CardState;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8573,"forge/game/player/PlayerController","chooseCardsPile","(Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;Ljava/lang/String;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8574,"forge/game/player/PlayerController","chooseCounterType","(Ljava/util/List;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/card/CounterType;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8575,"forge/game/player/PlayerController","chooseKeywordForPump","(Ljava/util/List;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/card/Card;)Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8576,"forge/game/player/PlayerController","confirmPayment","(Lforge/game/cost/CostPart;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8577,"forge/game/player/PlayerController","chooseSingleReplacementEffect","(Ljava/util/List;)Lforge/game/replacement/ReplacementEffect;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8578,"forge/game/player/PlayerController","chooseSingleStaticAbility","(Ljava/util/List;)Lforge/game/staticability/StaticAbility;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8579,"forge/game/player/PlayerController","chooseProtectionType","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8580,"forge/game/player/PlayerController","revealAnte","(Ljava/lang/String;Lcom/google/common/collect/Multimap;)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8581,"forge/game/player/PlayerController","revealAISkipCards","(Ljava/lang/String;Ljava/util/Map;)V",1025,0,0,new JHandler[]{},null));
}

private static void Add2(JClass c){
c.Add(new JMethod(8582,"forge/game/player/PlayerController","revealUnsupported","(Ljava/util/Map;)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8583,"forge/game/player/PlayerController","cheatShuffle","(Lforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;",1,2,1,new JHandler[]{},M8583));
c.Add(new JMethod(8584,"forge/game/player/PlayerController","complainCardsCantPlayWell","(Lforge/deck/Deck;)Ljava/util/Map;",1,2,1,new JHandler[]{},M8584));
c.Add(new JMethod(8585,"forge/game/player/PlayerController","resetAtEndOfTurn","()V",1,1,0,new JHandler[]{},M8585));
c.Add(new JMethod(8586,"forge/game/player/PlayerController","chooseOptionalCosts","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)Ljava/util/List;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8587,"forge/game/player/PlayerController","orderCosts","(Ljava/util/List;)Ljava/util/List;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8588,"forge/game/player/PlayerController","payCostToPreventEffect","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;ZLforge/util/collect/FCollectionView;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8589,"forge/game/player/PlayerController","payCostDuringRoll","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8590,"forge/game/player/PlayerController","payCombatCost","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8591,"forge/game/player/PlayerController","payManaCost","(Lforge/game/cost/CostPartMana;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/mana/ManaConversionMatrix;Z)Z",17,6,7,new JHandler[]{},M8591));
c.Add(new JMethod(8592,"forge/game/player/PlayerController","payManaCost","(Lforge/card/mana/ManaCost;Lforge/game/cost/CostPartMana;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/mana/ManaConversionMatrix;Z)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8593,"forge/game/player/PlayerController","applyManaToCost","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/mana/ManaConversionMatrix;Z)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8594,"forge/game/player/PlayerController","chooseCardsForCost","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Lforge/game/cost/CostPartWithList;IZLjava/lang/String;)Lforge/game/card/CardCollectionView;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8595,"forge/game/player/PlayerController","getCostDecisionMaker","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Z)Lforge/game/cost/CostDecisionMakerBase;",1,4,5,new JHandler[]{},M8595));
c.Add(new JMethod(8596,"forge/game/player/PlayerController","getCostDecisionMaker","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;ZLjava/lang/String;)Lforge/game/cost/CostDecisionMakerBase;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8597,"forge/game/player/PlayerController","chooseCardName","(Lforge/game/spellability/SpellAbility;Ljava/util/function/Predicate;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8598,"forge/game/player/PlayerController","chooseCardName","(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8599,"forge/game/player/PlayerController","chooseSingleCardForZoneChange","(Lforge/game/zone/ZoneType;Ljava/util/List;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;Lforge/game/player/DelayedReveal;Ljava/lang/String;ZLforge/game/player/Player;)Lforge/game/card/Card;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8600,"forge/game/player/PlayerController","chooseCardsForZoneChange","(Lforge/game/zone/ZoneType;Ljava/util/List;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;IILforge/game/player/DelayedReveal;Ljava/lang/String;Lforge/game/player/Player;)Ljava/util/List;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8601,"forge/game/player/PlayerController","getFullControl","()Ljava/util/Set;",1,1,1,new JHandler[]{},M8601));
c.Add(new JMethod(8602,"forge/game/player/PlayerController","isFullControl","(Lforge/game/player/PlayerController$FullControlFlag;)Z",1,2,2,new JHandler[]{},M8602));
c.Add(new JMethod(8603,"forge/game/player/PlayerController","autoPassCancel","()V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8604,"forge/game/player/PlayerController","awaitNextInput","()V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8605,"forge/game/player/PlayerController","cancelAwaitNextInput","()V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(8606,"forge/game/player/PlayerController","isGuiPlayer","()Z",1,1,1,new JHandler[]{},M8606));
c.Add(new JMethod(8607,"forge/game/player/PlayerController","canPlayUnlimitedLands","()Z",1,1,1,new JHandler[]{},M8607));
c.Add(new JMethod(8608,"forge/game/player/PlayerController","getAnteResult","()Lforge/game/GameOutcome$AnteResult;",1,1,2,new JHandler[]{},M8608));
c.Add(new JMethod(8609,"forge/game/player/PlayerController","isOrderedZone","()Z",1,1,1,new JHandler[]{},M8609));
c.Add(new JMethod(8610,"forge/game/player/PlayerController","lambda$reveal$0","(Lforge/game/zone/ZoneType;Lforge/game/card/CardView;)Z",4106,2,2,new JHandler[]{},M8610));
}

internal static JStep M8458(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.ClassObject("forge/game/player/PlayerController$FullControlFlag")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",10);}
case 10:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/PlayerController","fullControls","Ljava/util/Set;",value);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/Game","getView","()Lforge/game/GameView;","invokevirtual",18);}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/PlayerController","gameView","Lforge/game/GameView;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/PlayerController","player","Lforge/game/player/Player;",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/PlayerController","lobbyPlayer","Lforge/LobbyPlayer;",value);f.Pc=31;continue;}
case 31:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8459(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8460(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlayerController","gameView","Lforge/game/GameView;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8461(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlayerController","gameView","Lforge/game/GameView;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","getMatch","()Lforge/game/Match;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8462(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlayerController","player","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8463(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlayerController","lobbyPlayer","Lforge/LobbyPlayer;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8464(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8465(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8466(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/PlayerController","getAbilityToPlay","(Lforge/game/card/Card;Ljava/util/List;Lforge/util/ITriggerEvent;)Lforge/game/spellability/SpellAbility;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8471(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?14:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",11);}
case 11:{f.Pc=21;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlayerController","player","Lforge/game/player/Player;"));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?35:33;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",39);}
case 39:{f.Push(JValue.I(1));f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.NewArray("Lforge/game/spellability/SpellAbility;",f.Pop().Int)));f.Pc=43;continue;}
case 43:{f.StackOp("dup");f.Pc=44;continue;}
case 44:{f.Push(JValue.I(0));f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=47;continue;}
case 47:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",50);}
case 50:{return rt.Call(f,"forge/game/player/PlayerController","orderAndPlaySimultaneousSa","(Ljava/util/List;)V","invokevirtual",53);}
case 53:{f.Push(JValue.I(1));f.Pc=54;continue;}
case 54:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8475(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8476(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"java/util/Collections","emptyList","()Ljava/util/List;","invokestatic",3);}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8491(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[2]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[4]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/player/DelayedReveal;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLforge/game/player/Player;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8492(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[2]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[4]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[5]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/player/DelayedReveal;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLforge/game/player/Player;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8497(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",7);}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[4]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/List;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8498(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",7);}
case 7:{f.Push(f.Locals[4]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[5]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/List;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",14);}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8511(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/player/PlayerController","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/player/Player;Ljava/lang/String;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8512(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/PlayerController","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/player/Player;Ljava/lang/String;Z)V","invokevirtual",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8514(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/PlayerController","reveal","(Ljava/util/List;Lforge/game/zone/ZoneType;Lforge/game/player/PlayerView;Ljava/lang/String;Z)V","invokevirtual",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8515(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/DelayedReveal","getZone","()Ljava/util/Set;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?74:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/player/DelayedReveal","getCards","()Lforge/trackable/TrackableCollection;","invokevirtual",34);}
case 34:{return rt.Call(f,"forge/trackable/TrackableCollection","stream","()Ljava/util/stream/Stream;","invokevirtual",37);}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.DynamicCall(f,"forge/game/player/PlayerController:8515:38:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/zone/ZoneType;)Ljava/util/function/Predicate;",43);}
case 43:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",48);}
case 48:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",51);}
case 51:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",56);}
case 56:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/player/DelayedReveal","getOwner","()Lforge/game/player/PlayerView;","invokevirtual",64);}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/player/DelayedReveal","getMessagePrefix","()Ljava/lang/String;","invokevirtual",68);}
case 68:{return rt.Call(f,"forge/game/player/PlayerController","reveal","(Ljava/util/List;Lforge/game/zone/ZoneType;Lforge/game/player/PlayerView;Ljava/lang/String;)V","invokevirtual",71);}
case 71:{f.Pc=10;continue;}
case 74:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8522(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/zone/ZoneType","isDeck","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Reference!=null?15:13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("LibraryPosition")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?30:24;continue;}
case 24:{f.Push(JValue.R(rt.String("LibraryPosition")));f.Pc=26;continue;}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Pc=47;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("RevealedLibraryPosition")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int==0?45:39;continue;}
case 39:{f.Push(JValue.R(rt.String("RevealedLibraryPosition")));f.Pc=41;continue;}
case 41:{f.Locals[3]=f.Pop();f.Pc=42;continue;}
case 42:{f.Pc=47;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",51);}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",56);}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",60);}
case 60:{f.Pc=f.Pop().Int<0?67:63;continue;}
case 63:{f.Push(JValue.I(1));f.Pc=64;continue;}
case 64:{f.Pc=68;continue;}
case 67:{f.Push(JValue.I(0));f.Pc=68;continue;}
case 68:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8523(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[5]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsToDiscardFrom","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;IILforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8536(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/player/PlayerController","chooseSomeType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Ljava/util/Collection;Z)Ljava/lang/String;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8541(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(3));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Alpha")));f.Pc=8;continue;}
case 8:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("Beta")));f.Pc=13;continue;}
case 13:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{f.Push(JValue.I(2));f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("Gamma")));f.Pc=18;continue;}
case 18:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/player/PlayerController","chooseSector","(Lforge/game/card/Card;Ljava/lang/String;Ljava/util/List;)Ljava/lang/String;","invokevirtual",30);}
case 30:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8544(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(1));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",6);}
case 6:{f.Push(JValue.I(2));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",10);}
case 10:{f.Push(JValue.I(3));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",14);}
case 14:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/List;","invokestatic",17);}
case 17:{return rt.Call(f,"forge/game/player/PlayerController","chooseSprocket","(Lforge/game/card/Card;Ljava/util/List;)I","invokevirtual",20);}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8559(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(1));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumberForKeywordCost","(Lforge/game/spellability/SpellAbility;Lforge/game/cost/Cost;Lforge/game/keyword/KeywordInterface;Ljava/lang/String;I)I","invokevirtual",10);}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8562(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;II)I","invokevirtual",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8563(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/player/PlayerController","chooseBinary","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/PlayerController$BinaryChoiceType;Ljava/lang/Boolean;)Z","invokevirtual",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8565(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/PlayerController","chooseBinary","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/PlayerController$BinaryChoiceType;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8583(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8584(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8585(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8591(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/cost/CostPartMana","getManaCostFor","(Lforge/game/spellability/SpellAbility;)Lforge/card/mana/ManaCost;","invokevirtual",6);}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[4]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[5]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/player/PlayerController","payManaCost","(Lforge/card/mana/ManaCost;Lforge/game/cost/CostPartMana;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/mana/ManaConversionMatrix;Z)Z","invokevirtual",16);}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8595(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/player/PlayerController","getCostDecisionMaker","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;ZLjava/lang/String;)Lforge/game/cost/CostDecisionMakerBase;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8601(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlayerController","fullControls","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8602(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlayerController","fullControls","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8606(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8607(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8608(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlayerController","gameView","Lforge/game/GameView;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlayerController","player","Lforge/game/player/Player;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/player/Player","getView","()Lforge/game/player/PlayerView;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/GameView","getAnteResult","(Lforge/game/player/PlayerView;)Lforge/game/GameOutcome$AnteResult;","invokevirtual",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8609(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8610(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView","getZone","()Lforge/game/zone/ZoneType;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

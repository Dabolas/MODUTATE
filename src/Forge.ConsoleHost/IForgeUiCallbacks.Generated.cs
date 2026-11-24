// Generated complete host callback inventory. Untyped engine values must be converted to seat-filtered HostDecision options.
namespace Planeswalker.ForgeConsole;
public interface IForgeUiCallbacks
{
    // forge/game/player/PlayerController.isAI()Z
    HostDecision Request_isAI_6822D90A(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.getGame()Lforge/game/Game;
    HostDecision Request_getGame_F00C205D(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.getMatch()Lforge/game/Match;
    HostDecision Request_getMatch_106CFD89(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.getPlayer()Lforge/game/player/Player;
    HostDecision Request_getPlayer_9D49C9E7(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.getLobbyPlayer()Lforge/LobbyPlayer;
    HostDecision Request_getLobbyPlayer_BBCB80B3(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.tempShowCards(Ljava/lang/Iterable;)V
    HostDecision Request_tempShowCards_8209E4C4(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.endTempShowCards()V
    HostDecision Request_endTempShowCards_A68A0BC4(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.getAbilityToPlay(Lforge/game/card/Card;Ljava/util/List;)Lforge/game/spellability/SpellAbility;
    HostDecision Request_getAbilityToPlay_618DCCDC(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.getAbilityToPlay(Lforge/game/card/Card;Ljava/util/List;Lforge/util/ITriggerEvent;)Lforge/game/spellability/SpellAbility;
    HostDecision Request_getAbilityToPlay_EEC5E275(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.playSpellAbilityNoStack(Lforge/game/spellability/SpellAbility;Z)V
    HostDecision Request_playSpellAbilityNoStack_1C0D6623(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.orderSimultaneousSa(Ljava/util/List;)Ljava/util/List;
    HostDecision Request_orderSimultaneousSa_D62A84BD(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.orderAndPlaySimultaneousSa(Ljava/util/List;)V
    HostDecision Request_orderAndPlaySimultaneousSa_EFE650E7(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.playedByTeammate(Lforge/game/spellability/SpellAbility;)Z
    HostDecision Request_playedByTeammate_B0C6B47E(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.playTrigger(Lforge/game/card/Card;Lforge/game/trigger/WrappedAbility;Z)Z
    HostDecision Request_playTrigger_9DDE16E9(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.playSaFromPlayEffect(Lforge/game/spellability/SpellAbility;)Z
    HostDecision Request_playSaFromPlayEffect_D0B46B57(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.sideboard(Lforge/deck/Deck;Lforge/game/GameType;Ljava/lang/String;)Ljava/util/List;
    HostDecision Request_sideboard_3AACEC42(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.sideboardsByItself()Z
    HostDecision Request_sideboardsByItself_2D4CC475(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.getSideboardingReport()Ljava/util/List;
    HostDecision Request_getSideboardingReport_2FFB1A62(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseCardsYouWonToAddToDeck(Ljava/util/List;)Ljava/util/List;
    HostDecision Request_chooseCardsYouWonToAddToDeck_C554F19D(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.assignCombatDamage(Lforge/game/card/Card;Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;ILforge/game/GameEntity;Z)Ljava/util/Map;
    HostDecision Request_assignCombatDamage_859B8E8F(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.divideShield(Lforge/game/card/Card;Ljava/util/Map;I)Ljava/util/Map;
    HostDecision Request_divideShield_BA02628F(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.specifyManaCombo(Lforge/game/spellability/SpellAbility;Lforge/card/ColorSet;IZ)Ljava/util/Map;
    HostDecision Request_specifyManaCombo_F36F4977(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.choosePermanentsToSacrifice(Lforge/game/spellability/SpellAbility;IILforge/game/card/CardCollectionView;Ljava/lang/String;)Lforge/game/card/CardCollectionView;
    HostDecision Request_choosePermanentsToSacrifice_24F5C898(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.choosePermanentsToDestroy(Lforge/game/spellability/SpellAbility;IILforge/game/card/CardCollectionView;Ljava/lang/String;)Lforge/game/card/CardCollectionView;
    HostDecision Request_choosePermanentsToDestroy_D9A04C48(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.announceRequirements(Lforge/game/spellability/SpellAbility;IILjava/lang/String;)Ljava/lang/Integer;
    HostDecision Request_announceRequirements_9AD504D3(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseNewTargetsFor(Lforge/game/spellability/SpellAbility;Ljava/util/function/Predicate;Z)Lforge/game/spellability/TargetChoices;
    HostDecision Request_chooseNewTargetsFor_480E57E4(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseTargetsFor(Lforge/game/spellability/SpellAbility;)Z
    HostDecision Request_chooseTargetsFor_FED3FAF0(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseTarget(Lforge/game/spellability/SpellAbility;Ljava/util/List;)Lorg/apache/commons/lang3/tuple/Pair;
    HostDecision Request_chooseTarget_55E2B9BD(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.helpPayForAssistSpell(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;II)Z
    HostDecision Request_helpPayForAssistSpell_D81FECF6(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.choosePlayerToAssistPayment(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;I)Lforge/game/player/Player;
    HostDecision Request_choosePlayerToAssistPayment_62DCE03D(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseCardsForEffect(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;
    HostDecision Request_chooseCardsForEffect_884C2374(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseCardsForEffectMultiple(Ljava/util/Map;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Z)Lforge/game/card/CardCollection;
    HostDecision Request_chooseCardsForEffectMultiple_134F7F1E(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseSingleEntityForEffect(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;
    HostDecision Request_chooseSingleEntityForEffect_AC695F81(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseSingleEntityForEffect(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;
    HostDecision Request_chooseSingleEntityForEffect_309EB4B1(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseSingleEntityForEffect(Lforge/util/collect/FCollectionView;Lforge/game/player/DelayedReveal;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLforge/game/player/Player;Ljava/util/Map;)Lforge/game/GameEntity;
    HostDecision Request_chooseSingleEntityForEffect_D64F3BEB(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseEntitiesForEffect(Lforge/util/collect/FCollectionView;IILforge/game/player/DelayedReveal;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/Player;Ljava/util/Map;)Ljava/util/List;
    HostDecision Request_chooseEntitiesForEffect_D898F84E(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseSpellAbilitiesForEffect(Ljava/util/List;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ILjava/util/Map;)Ljava/util/List;
    HostDecision Request_chooseSpellAbilitiesForEffect_33B3B680(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseSingleSpellForEffect(Ljava/util/List;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/spellability/SpellAbility;
    HostDecision Request_chooseSingleSpellForEffect_0E511FB1(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.confirmAction(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z
    HostDecision Request_confirmAction_BA7C9ED0(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.confirmAction(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z
    HostDecision Request_confirmAction_910B1C28(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.confirmAction(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/List;Lforge/game/card/Card;Ljava/util/Map;)Z
    HostDecision Request_confirmAction_E812B423(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.confirmBidAction(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;ILforge/game/player/Player;)Z
    HostDecision Request_confirmBidAction_0E832E05(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.confirmReplacementEffect(Lforge/game/replacement/ReplacementEffect;Lforge/game/spellability/SpellAbility;Lforge/game/GameEntity;Ljava/lang/String;)Z
    HostDecision Request_confirmReplacementEffect_1B5F6980(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.confirmStaticApplication(Lforge/game/card/Card;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/lang/String;)Z
    HostDecision Request_confirmStaticApplication_B1D962EF(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.confirmTrigger(Lforge/game/trigger/WrappedAbility;)Z
    HostDecision Request_confirmTrigger_D9C18E34(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.exertAttackers(Ljava/util/List;)Ljava/util/List;
    HostDecision Request_exertAttackers_057A6082(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.enlistAttackers(Ljava/util/List;)Ljava/util/List;
    HostDecision Request_enlistAttackers_8E83DFB0(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.declareAttackers(Lforge/game/player/Player;Lforge/game/combat/Combat;)V
    HostDecision Request_declareAttackers_765767FF(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.declareBlockers(Lforge/game/player/Player;Lforge/game/combat/Combat;)V
    HostDecision Request_declareBlockers_5184ADD1(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.orderBlockers(Lforge/game/card/Card;Lforge/game/card/CardCollection;)Lforge/game/card/CardCollection;
    HostDecision Request_orderBlockers_3E6D7B24(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.orderBlocker(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/card/CardCollection;)Lforge/game/card/CardCollection;
    HostDecision Request_orderBlocker_ED68D8B2(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.orderAttackers(Lforge/game/card/Card;Lforge/game/card/CardCollection;)Lforge/game/card/CardCollection;
    HostDecision Request_orderAttackers_4A2E9099(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.reveal(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/player/Player;)V
    HostDecision Request_reveal_017C34DE(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.reveal(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/player/Player;Ljava/lang/String;)V
    HostDecision Request_reveal_F02F15D1(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.reveal(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/player/Player;Ljava/lang/String;Z)V
    HostDecision Request_reveal_C1C9901D(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.reveal(Ljava/util/List;Lforge/game/zone/ZoneType;Lforge/game/player/PlayerView;Ljava/lang/String;)V
    HostDecision Request_reveal_66B5AC0A(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.reveal(Lforge/game/player/DelayedReveal;)V
    HostDecision Request_reveal_5E4F2248(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.reveal(Ljava/util/List;Lforge/game/zone/ZoneType;Lforge/game/player/PlayerView;Ljava/lang/String;Z)V
    HostDecision Request_reveal_FBC3D470(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.notifyOfValue(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;)V
    HostDecision Request_notifyOfValue_A13B70A0(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.arrangeForScry(Lforge/game/card/CardCollection;)Lorg/apache/commons/lang3/tuple/ImmutablePair;
    HostDecision Request_arrangeForScry_19C73EDD(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.arrangeForSurveil(Lforge/game/card/CardCollection;)Lorg/apache/commons/lang3/tuple/ImmutablePair;
    HostDecision Request_arrangeForSurveil_CAEC0B1D(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.willPutCardOnTop(Lforge/game/card/Card;)Z
    HostDecision Request_willPutCardOnTop_7953A427(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.orderMoveToZoneList(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;
    HostDecision Request_orderMoveToZoneList_0A715690(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.orderedMoveToTopOfLibrary(Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Z
    HostDecision Request_orderedMoveToTopOfLibrary_B4103634(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseCardsToDiscardFrom(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;II)Lforge/game/card/CardCollectionView;
    HostDecision Request_chooseCardsToDiscardFrom_49B0DBED(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseCardsToDiscardFrom(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;IILforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;
    HostDecision Request_chooseCardsToDiscardFrom_042ADA1C(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseCardsToDiscardUnlessType(ILforge/game/card/CardCollectionView;[Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;
    HostDecision Request_chooseCardsToDiscardUnlessType_A3F5DDF2(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseCardsToDiscardToMaximumHandSize(I)Lforge/game/card/CardCollectionView;
    HostDecision Request_chooseCardsToDiscardToMaximumHandSize_FDC68983(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseCardsToDelve(ILforge/game/card/CardCollection;)Lforge/game/card/CardCollectionView;
    HostDecision Request_chooseCardsToDelve_84061647(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseCardsForConvokeOrImprovise(Lforge/game/spellability/SpellAbility;Lforge/card/mana/ManaCost;Lforge/game/card/CardCollectionView;ZZLjava/lang/Integer;)Ljava/util/Map;
    HostDecision Request_chooseCardsForConvokeOrImprovise_485B9FAF(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseCardsForSplice(Lforge/game/spellability/SpellAbility;Ljava/util/List;)Ljava/util/List;
    HostDecision Request_chooseCardsForSplice_D7023D14(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseCardsToRevealFromHand(IILforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;
    HostDecision Request_chooseCardsToRevealFromHand_8E14BF0A(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseSaToActivateFromOpeningHand(Ljava/util/List;)Ljava/util/List;
    HostDecision Request_chooseSaToActivateFromOpeningHand_1278B04F(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseStartingPlayer(Z)Lforge/game/player/Player;
    HostDecision Request_chooseStartingPlayer_934C4696(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseStartingHand(Ljava/util/List;)Lforge/game/zone/PlayerZone;
    HostDecision Request_chooseStartingHand_C86F44D3(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseManaFromPool(Ljava/util/List;)Lforge/game/mana/Mana;
    HostDecision Request_chooseManaFromPool_765C89AF(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseSomeType(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Ljava/util/Collection;Z)Ljava/lang/String;
    HostDecision Request_chooseSomeType_E0AFA106(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseSomeType(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Ljava/util/Collection;)Ljava/lang/String;
    HostDecision Request_chooseSomeType_D0DEA8A5(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseSector(Lforge/game/card/Card;Ljava/lang/String;Ljava/util/List;)Ljava/lang/String;
    HostDecision Request_chooseSector_DCD26B27(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseSticker(Ljava/util/List;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Z)Lforge/game/card/sticker/Sticker;
    HostDecision Request_chooseSticker_E7520084(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseStickerNamePosition(Lforge/game/card/sticker/Sticker;Lforge/game/card/Card;)I
    HostDecision Request_chooseStickerNamePosition_B62DE1C3(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseCardToKeepStickers(Lforge/game/card/CardCollectionView;)Lforge/game/card/Card;
    HostDecision Request_chooseCardToKeepStickers_7FB96970(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseSector(Lforge/game/card/Card;Ljava/lang/String;)Ljava/lang/String;
    HostDecision Request_chooseSector_EBE60D5E(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseContraptionsToCrank(Ljava/util/List;)Ljava/util/List;
    HostDecision Request_chooseContraptionsToCrank_AE11A132(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseSprocket(Lforge/game/card/Card;Ljava/util/List;)I
    HostDecision Request_chooseSprocket_8E3FFC35(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseSprocket(Lforge/game/card/Card;)I
    HostDecision Request_chooseSprocket_C2F8A168(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.choosePDRollToIgnore(Ljava/util/List;)Lforge/game/PlanarDice;
    HostDecision Request_choosePDRollToIgnore_46800DA8(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseRollToIgnore(Ljava/util/List;)Ljava/lang/Integer;
    HostDecision Request_chooseRollToIgnore_0B0223DB(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseDiceToReroll(Ljava/util/List;)Ljava/util/List;
    HostDecision Request_chooseDiceToReroll_2A428BC2(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseRollToModify(Ljava/util/List;)Ljava/lang/Integer;
    HostDecision Request_chooseRollToModify_584FE959(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseRollToSwap(Ljava/util/List;)Lforge/game/ability/effects/RollDiceEffect$DieRollResult;
    HostDecision Request_chooseRollToSwap_FA66D39E(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseRollSwapValue(Ljava/util/List;Ljava/lang/Integer;II)Ljava/lang/String;
    HostDecision Request_chooseRollSwapValue_D217AF2D(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.vote(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/List;Lcom/google/common/collect/ListMultimap;Lforge/game/player/Player;Z)Ljava/lang/Object;
    HostDecision Request_vote_A0A11220(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.mulliganKeepHand(Lforge/game/player/Player;I)Z
    HostDecision Request_mulliganKeepHand_6C30E2B1(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.tuckCardsViaMulligan(Lforge/game/card/CardCollectionView;I)Lforge/game/card/CardCollectionView;
    HostDecision Request_tuckCardsViaMulligan_79ADD084(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseSpellAbilityToPlay()Ljava/util/List;
    HostDecision Request_chooseSpellAbilityToPlay_3478CDF0(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.playChosenSpellAbility(Lforge/game/spellability/SpellAbility;)Z
    HostDecision Request_playChosenSpellAbility_D000F5DA(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseModeForAbility(Lforge/game/spellability/SpellAbility;Ljava/util/List;IIZ)Ljava/util/List;
    HostDecision Request_chooseModeForAbility_0EF29FD9(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseNumberForCostReduction(Lforge/game/spellability/SpellAbility;II)I
    HostDecision Request_chooseNumberForCostReduction_AD68961D(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseNumberForKeywordCost(Lforge/game/spellability/SpellAbility;Lforge/game/cost/Cost;Lforge/game/keyword/KeywordInterface;Ljava/lang/String;I)I
    HostDecision Request_chooseNumberForKeywordCost_0580E5F9(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.addKeywordCost(Lforge/game/spellability/SpellAbility;Lforge/game/cost/Cost;Lforge/game/keyword/KeywordInterface;Ljava/lang/String;)Z
    HostDecision Request_addKeywordCost_76BEFBAE(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseNumber(Lforge/game/spellability/SpellAbility;Ljava/lang/String;II)I
    HostDecision Request_chooseNumber_CFBFFE53(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseNumber(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/List;Lforge/game/player/Player;)I
    HostDecision Request_chooseNumber_4C09DE72(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseNumber(Lforge/game/spellability/SpellAbility;Ljava/lang/String;IILjava/util/Map;)I
    HostDecision Request_chooseNumber_DE751C16(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseBinary(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/PlayerController$BinaryChoiceType;)Z
    HostDecision Request_chooseBinary_D8CDB474(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseBinary(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/PlayerController$BinaryChoiceType;Ljava/lang/Boolean;)Z
    HostDecision Request_chooseBinary_5D6FAE2F(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseBinary(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/PlayerController$BinaryChoiceType;Ljava/util/Map;)Z
    HostDecision Request_chooseBinary_C4CC28C6(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseFlipResult(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z
    HostDecision Request_chooseFlipResult_CD8D1EE5(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseColor(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/card/ColorSet;)B
    HostDecision Request_chooseColor_A75B5581(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseColorAllowColorless(Ljava/lang/String;Lforge/game/card/Card;Lforge/card/ColorSet;)B
    HostDecision Request_chooseColorAllowColorless_E8C03F54(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseColors(Ljava/lang/String;Lforge/game/spellability/SpellAbility;IILforge/card/ColorSet;)Lforge/card/ColorSet;
    HostDecision Request_chooseColors_54461BF0(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseSingleCardFace(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/function/Predicate;Ljava/lang/String;)Lforge/card/ICardFace;
    HostDecision Request_chooseSingleCardFace_328867DC(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseSingleCardFace(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;)Lforge/card/ICardFace;
    HostDecision Request_chooseSingleCardFace_89C66001(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseSingleCardState(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)Lforge/game/card/CardState;
    HostDecision Request_chooseSingleCardState_5DC7C546(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseCardsPile(Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;Ljava/lang/String;)Z
    HostDecision Request_chooseCardsPile_FAD14CDA(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseCounterType(Ljava/util/List;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/card/CounterType;
    HostDecision Request_chooseCounterType_160FDEDA(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseKeywordForPump(Ljava/util/List;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/card/Card;)Ljava/lang/String;
    HostDecision Request_chooseKeywordForPump_CCC680CE(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.confirmPayment(Lforge/game/cost/CostPart;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z
    HostDecision Request_confirmPayment_12DBDBFD(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseSingleReplacementEffect(Ljava/util/List;)Lforge/game/replacement/ReplacementEffect;
    HostDecision Request_chooseSingleReplacementEffect_635E383D(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseSingleStaticAbility(Ljava/util/List;)Lforge/game/staticability/StaticAbility;
    HostDecision Request_chooseSingleStaticAbility_4A1FE8D0(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseProtectionType(Lforge/game/spellability/SpellAbility;Ljava/util/List;)Ljava/lang/String;
    HostDecision Request_chooseProtectionType_1A03E5E0(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.revealAnte(Ljava/lang/String;Lcom/google/common/collect/Multimap;)V
    HostDecision Request_revealAnte_498271E1(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.revealAISkipCards(Ljava/lang/String;Ljava/util/Map;)V
    HostDecision Request_revealAISkipCards_AFE464BB(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.revealUnsupported(Ljava/util/Map;)V
    HostDecision Request_revealUnsupported_ACE94464(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.cheatShuffle(Lforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;
    HostDecision Request_cheatShuffle_34825EF8(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.complainCardsCantPlayWell(Lforge/deck/Deck;)Ljava/util/Map;
    HostDecision Request_complainCardsCantPlayWell_6A340389(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.resetAtEndOfTurn()V
    HostDecision Request_resetAtEndOfTurn_6068C950(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseOptionalCosts(Lforge/game/spellability/SpellAbility;Ljava/util/List;)Ljava/util/List;
    HostDecision Request_chooseOptionalCosts_CD5BB453(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.orderCosts(Ljava/util/List;)Ljava/util/List;
    HostDecision Request_orderCosts_CD1EAAB2(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.payCostToPreventEffect(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;ZLforge/util/collect/FCollectionView;)Z
    HostDecision Request_payCostToPreventEffect_784EF669(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.payCostDuringRoll(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;)Z
    HostDecision Request_payCostDuringRoll_4E878992(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.payCombatCost(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Z
    HostDecision Request_payCombatCost_40E9F63D(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.payManaCost(Lforge/game/cost/CostPartMana;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/mana/ManaConversionMatrix;Z)Z
    HostDecision Request_payManaCost_852DB4B1(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.payManaCost(Lforge/card/mana/ManaCost;Lforge/game/cost/CostPartMana;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/mana/ManaConversionMatrix;Z)Z
    HostDecision Request_payManaCost_9A13BDEB(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.applyManaToCost(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/mana/ManaConversionMatrix;Z)Z
    HostDecision Request_applyManaToCost_F2BFA8FA(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseCardsForCost(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Lforge/game/cost/CostPartWithList;IZLjava/lang/String;)Lforge/game/card/CardCollectionView;
    HostDecision Request_chooseCardsForCost_7E945FDB(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.getCostDecisionMaker(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Z)Lforge/game/cost/CostDecisionMakerBase;
    HostDecision Request_getCostDecisionMaker_8B6501AA(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.getCostDecisionMaker(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;ZLjava/lang/String;)Lforge/game/cost/CostDecisionMakerBase;
    HostDecision Request_getCostDecisionMaker_71017A8C(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseCardName(Lforge/game/spellability/SpellAbility;Ljava/util/function/Predicate;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;
    HostDecision Request_chooseCardName_70C12A2F(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseCardName(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;
    HostDecision Request_chooseCardName_9936AFD3(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseSingleCardForZoneChange(Lforge/game/zone/ZoneType;Ljava/util/List;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;Lforge/game/player/DelayedReveal;Ljava/lang/String;ZLforge/game/player/Player;)Lforge/game/card/Card;
    HostDecision Request_chooseSingleCardForZoneChange_20ECC808(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.chooseCardsForZoneChange(Lforge/game/zone/ZoneType;Ljava/util/List;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;IILforge/game/player/DelayedReveal;Ljava/lang/String;Lforge/game/player/Player;)Ljava/util/List;
    HostDecision Request_chooseCardsForZoneChange_E4CD1FD7(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.getFullControl()Ljava/util/Set;
    HostDecision Request_getFullControl_D59A932E(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.isFullControl(Lforge/game/player/PlayerController$FullControlFlag;)Z
    HostDecision Request_isFullControl_AE499A97(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.autoPassCancel()V
    HostDecision Request_autoPassCancel_22535108(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.awaitNextInput()V
    HostDecision Request_awaitNextInput_E2DBCC6C(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.cancelAwaitNextInput()V
    HostDecision Request_cancelAwaitNextInput_94D1EE74(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.isGuiPlayer()Z
    HostDecision Request_isGuiPlayer_EF5BDFAE(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.canPlayUnlimitedLands()Z
    HostDecision Request_canPlayUnlimitedLands_02F51D51(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.getAnteResult()Lforge/game/GameOutcome$AnteResult;
    HostDecision Request_getAnteResult_84C17DB8(HostDecision seatFilteredRequest);
    // forge/game/player/PlayerController.isOrderedZone()Z
    HostDecision Request_isOrderedZone_5EEE3059(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.isLibgdxPort()Z
    HostDecision Request_isLibgdxPort_C507ED6D(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.setGameView(Lforge/game/GameView;J)V
    HostDecision Request_setGameView_5E32F875(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.setGameView(Lforge/game/GameView;)V
    HostDecision Request_setGameView_CB452B23(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.getGameView()Lforge/game/GameView;
    HostDecision Request_getGameView_28E25FAF(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.setOriginalGameController(Lforge/game/player/PlayerView;Lforge/interfaces/IGameController;)V
    HostDecision Request_setOriginalGameController_8444C049(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.setGameController(Lforge/game/player/PlayerView;Lforge/interfaces/IGameController;)V
    HostDecision Request_setGameController_A96984AE(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.setSpectator(Lforge/interfaces/IGameController;)V
    HostDecision Request_setSpectator_E687E7D1(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.openView(Lforge/trackable/TrackableCollection;)V
    HostDecision Request_openView_3F9BB883(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.afterGameEnd()V
    HostDecision Request_afterGameEnd_8D82FABD(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.showCombat()V
    HostDecision Request_showCombat_4267707C(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.showPromptMessage(Lforge/game/player/PlayerView;Ljava/lang/String;)V
    HostDecision Request_showPromptMessage_574FEE91(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.showPromptMessage(Lforge/game/player/PlayerView;Ljava/lang/String;Lforge/game/card/CardView;)V
    HostDecision Request_showPromptMessage_2D17C3B8(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.updateDrawOffer(Lforge/gamemodes/match/DrawOfferMessage$Status;)V
    HostDecision Request_updateDrawOffer_709C8DB4(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.updateButtons(Lforge/game/player/PlayerView;ZZZ)V
    HostDecision Request_updateButtons_B48F5D93(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.updateButtons(Lforge/game/player/PlayerView;Ljava/lang/String;Ljava/lang/String;ZZZ)V
    HostDecision Request_updateButtons_BDC6A159(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.updateButtons(Lforge/game/player/PlayerView;Ljava/lang/String;Ljava/lang/String;ZZZZ)V
    HostDecision Request_updateButtons_1B14321D(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.showCoinFlip(ZLjava/lang/String;Z)V
    HostDecision Request_showCoinFlip_B3F63A2D(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.showFlipOntoBattlefield(Lforge/game/card/CardView;Lforge/game/card/CardView;Ljava/util/List;Ljava/util/List;I)V
    HostDecision Request_showFlipOntoBattlefield_C7768C82(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.endFlipOntoBattlefield(Lforge/game/card/CardView;)V
    HostDecision Request_endFlipOntoBattlefield_D58ED755(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.flashIncorrectAction()V
    HostDecision Request_flashIncorrectAction_B90A2BEB(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.alertUser()V
    HostDecision Request_alertUser_47615B8B(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.updatePhase(Z)V
    HostDecision Request_updatePhase_F6CAC677(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.updateTurn(Lforge/game/player/PlayerView;)V
    HostDecision Request_updateTurn_A79C16F5(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.updatePlayerControl()V
    HostDecision Request_updatePlayerControl_2CA093F0(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.enableOverlay()V
    HostDecision Request_enableOverlay_9B0E17B9(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.disableOverlay()V
    HostDecision Request_disableOverlay_3167A87B(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.finishGame()V
    HostDecision Request_finishGame_DEDC0219(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.showManaPool(Lforge/game/player/PlayerView;)V
    HostDecision Request_showManaPool_02018724(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.hideManaPool(Lforge/game/player/PlayerView;)V
    HostDecision Request_hideManaPool_2E53AFB7(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.updateStack()V
    HostDecision Request_updateStack_5467A0D9(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.onSnapshotRestored()V
    HostDecision Request_onSnapshotRestored_98990419(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.notifyStackAddition(Lforge/game/event/GameEventSpellAbilityCast;)V
    HostDecision Request_notifyStackAddition_85AF8B8C(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.notifyStackRemoval(Lforge/game/event/GameEventSpellRemovedFromStack;)V
    HostDecision Request_notifyStackRemoval_F8E47D7E(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.handleLandPlayed(Lforge/game/card/CardView;)V
    HostDecision Request_handleLandPlayed_578CAA8D(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.handleGameEvent(Lforge/game/event/GameEvent;)V
    HostDecision Request_handleGameEvent_6EF0B34B(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.handleGameEvents(Ljava/util/List;)V
    HostDecision Request_handleGameEvents_4943D622(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.updateZones(Ljava/lang/Iterable;)V
    HostDecision Request_updateZones_9F469B34(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.updateCard(Lforge/game/card/CardView;)V
    HostDecision Request_updateCard_1B0912F4(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.updateCards(Ljava/lang/Iterable;)V
    HostDecision Request_updateCards_33C5C8F1(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.updateCardsNetSafe(Lforge/util/collect/FCollectionView;)V
    HostDecision Request_updateCardsNetSafe_5238E536(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.refreshCardDetails(Ljava/lang/Iterable;)V
    HostDecision Request_refreshCardDetails_BDB9F00E(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.refreshField()V
    HostDecision Request_refreshField_07F3E234(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.updateManaPool(Ljava/lang/Iterable;)V
    HostDecision Request_updateManaPool_4AA292C0(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.updateLives(Ljava/lang/Iterable;)V
    HostDecision Request_updateLives_DD5571A9(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.updateShards(Ljava/lang/Iterable;)V
    HostDecision Request_updateShards_12290420(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.updateDependencies()V
    HostDecision Request_updateDependencies_7354FD7B(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.setPanelSelection(Lforge/game/card/CardView;)V
    HostDecision Request_setPanelSelection_65A3DCA7(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.getAbilityToPlay(Lforge/game/card/CardView;Ljava/util/List;Lforge/util/ITriggerEvent;)Lforge/game/spellability/SpellAbilityView;
    HostDecision Request_getAbilityToPlay_49A970B6(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.assignCombatDamage(Lforge/game/card/CardView;Ljava/util/List;ILforge/game/GameEntityView;ZZ)Ljava/util/Map;
    HostDecision Request_assignCombatDamage_8773CFCA(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.assignGenericAmount(Lforge/game/card/CardView;Ljava/util/Map;IZLjava/lang/String;)Ljava/util/Map;
    HostDecision Request_assignGenericAmount_F5D91C65(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.message(Ljava/lang/String;)V
    HostDecision Request_message_9718E661(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.message(Ljava/lang/String;Ljava/lang/String;)V
    HostDecision Request_message_26729357(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.showErrorDialog(Ljava/lang/String;)V
    HostDecision Request_showErrorDialog_BBBEEAF0(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.showErrorDialog(Ljava/lang/String;Ljava/lang/String;)V
    HostDecision Request_showErrorDialog_D1C7BB93(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.showConfirmDialog(Ljava/lang/String;Ljava/lang/String;)Z
    HostDecision Request_showConfirmDialog_E896EED7(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.showConfirmDialog(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Z
    HostDecision Request_showConfirmDialog_25275E73(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.showConfirmDialog(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Z
    HostDecision Request_showConfirmDialog_7C81479E(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.showOptionDialog(Ljava/lang/String;Ljava/lang/String;Lforge/localinstance/skin/FSkinProp;Ljava/util/List;I)I
    HostDecision Request_showOptionDialog_9DE70FF8(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.showInputDialog(Ljava/lang/String;Ljava/lang/String;Lforge/localinstance/skin/FSkinProp;Ljava/lang/String;Ljava/util/List;Z)Ljava/lang/String;
    HostDecision Request_showInputDialog_50DAB297(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.confirm(Lforge/game/card/CardView;Ljava/lang/String;)Z
    HostDecision Request_confirm_A28B09C6(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.confirm(Lforge/game/card/CardView;Ljava/lang/String;ZLjava/util/List;)Z
    HostDecision Request_confirm_6F4D046F(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.getChoices(Ljava/lang/String;IILjava/util/List;)Ljava/util/List;
    HostDecision Request_getChoices_8424FC07(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.getChoices(Ljava/lang/String;IILjava/util/List;Ljava/util/List;Lforge/util/FSerializableFunction;)Ljava/util/List;
    HostDecision Request_getChoices_32644DA5(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.getInteger(Ljava/lang/String;IIZ)Ljava/lang/Integer;
    HostDecision Request_getInteger_F666C432(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.getInteger(Ljava/lang/String;III)Ljava/lang/Integer;
    HostDecision Request_getInteger_283B52F0(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.oneOrNone(Ljava/lang/String;Ljava/util/List;)Ljava/lang/Object;
    HostDecision Request_oneOrNone_D4734B3E(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.one(Ljava/lang/String;Ljava/util/List;)Ljava/lang/Object;
    HostDecision Request_one_2DD18FD4(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.one(Ljava/lang/String;Ljava/util/List;Lforge/util/FSerializableFunction;)Ljava/lang/Object;
    HostDecision Request_one_BB21296E(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.reveal(Ljava/lang/String;Ljava/util/List;)V
    HostDecision Request_reveal_A0761181(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.many(Ljava/lang/String;Ljava/lang/String;ILjava/util/List;Lforge/game/card/CardView;)Ljava/util/List;
    HostDecision Request_many_058EE0B7(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.many(Ljava/lang/String;Ljava/lang/String;IILjava/util/List;Lforge/game/card/CardView;)Ljava/util/List;
    HostDecision Request_many_4475C2CF(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.many(Ljava/lang/String;Ljava/lang/String;IILjava/util/List;Ljava/util/List;Lforge/game/card/CardView;)Ljava/util/List;
    HostDecision Request_many_E2BB6B10(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.order(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Lforge/game/card/CardView;)Ljava/util/List;
    HostDecision Request_order_02D96FCB(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.order(Ljava/lang/String;Ljava/lang/String;IILjava/util/List;Ljava/util/List;Lforge/game/card/CardView;Z)Ljava/util/List;
    HostDecision Request_order_2C918A5A(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.order(Ljava/lang/String;Ljava/lang/String;IILjava/util/List;Ljava/util/List;Lforge/game/card/CardView;ZZ)Lforge/gui/interfaces/IGuiGame$OrderResult;
    HostDecision Request_order_623C1AB8(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.insertInList(Ljava/lang/String;Ljava/lang/Object;Ljava/util/List;)Ljava/util/List;
    HostDecision Request_insertInList_BCC7EA6A(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.sideboard(Lforge/deck/CardPool;Lforge/deck/CardPool;Ljava/lang/String;)Ljava/util/List;
    HostDecision Request_sideboard_549FCD6D(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.chooseSingleEntityForEffect(Ljava/lang/String;Ljava/util/List;Lforge/game/player/DelayedReveal;Z)Lforge/game/GameEntityView;
    HostDecision Request_chooseSingleEntityForEffect_5AA395C1(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.chooseEntitiesForEffect(Ljava/lang/String;Ljava/util/List;IILforge/game/player/DelayedReveal;)Ljava/util/List;
    HostDecision Request_chooseEntitiesForEffect_C0240B7B(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.manipulateCardList(Ljava/lang/String;Ljava/lang/Iterable;Ljava/lang/Iterable;ZZZ)Ljava/util/List;
    HostDecision Request_manipulateCardList_4F4DA513(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.setCard(Lforge/game/card/CardView;)V
    HostDecision Request_setCard_75B0029F(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.setPlayerAvatar(Lforge/LobbyPlayer;Lforge/game/player/IHasIcon;)V
    HostDecision Request_setPlayerAvatar_0CDBF3A5(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.openZones(Lforge/game/player/PlayerView;Ljava/util/Collection;Ljava/util/Map;)V
    HostDecision Request_openZones_1744FD89(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.setSelection(Lforge/gamemodes/match/Selection;)V
    HostDecision Request_setSelection_CDEB3D9E(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.canPickStackTargets()Z
    HostDecision Request_canPickStackTargets_6C8B9F9A(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.isSelecting()Z
    HostDecision Request_isSelecting_683D3E0D(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.showRevealedCards(Ljava/lang/Iterable;)V
    HostDecision Request_showRevealedCards_FD5223D2(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.hideRevealedCards()V
    HostDecision Request_hideRevealedCards_460E9A4D(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.isGamePaused()Z
    HostDecision Request_isGamePaused_EC4B64A2(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.setGamePause(Z)V
    HostDecision Request_setGamePause_6EC77F07(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.getGameSpeed()Lforge/gui/control/PlaybackSpeed;
    HostDecision Request_getGameSpeed_630D4545(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.setGameSpeed(Lforge/gui/control/PlaybackSpeed;)V
    HostDecision Request_setGameSpeed_19DA766B(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.getDayTime()Ljava/lang/String;
    HostDecision Request_getDayTime_427FFD5C(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.updateDayTime(Ljava/lang/String;)V
    HostDecision Request_updateDayTime_698C1659(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.awaitNextInput()V
    HostDecision Request_awaitNextInput_E5E46333(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.cancelAwaitNextInput()V
    HostDecision Request_cancelAwaitNextInput_28D31A83(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.updateAutoPassPrompt()V
    HostDecision Request_updateAutoPassPrompt_C5AD24FA(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.setCurrentPlayer(Lforge/game/player/PlayerView;)V
    HostDecision Request_setCurrentPlayer_E478118B(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.isUiSetToSkipPhase(Lforge/game/player/PlayerView;Lforge/game/phase/PhaseType;)Z
    HostDecision Request_isUiSetToSkipPhase_FC72755C(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.refreshYieldUi(Lforge/game/player/PlayerView;)V
    HostDecision Request_refreshYieldUi_B669BDD2(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.applyYieldUpdate(Lforge/gamemodes/match/YieldUpdate;)V
    HostDecision Request_applyYieldUpdate_DDF828C7(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.applyMacroState(Lforge/interfaces/IMacroSystem$State;)V
    HostDecision Request_applyMacroState_FF778561(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.applyDelta(Lforge/gamemodes/net/DeltaPacket;)V
    HostDecision Request_applyDelta_8A690C2F(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.awaitInput(Ljava/util/concurrent/CountDownLatch;)V
    HostDecision Request_awaitInput_11F91827(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.isNetGame()Z
    HostDecision Request_isNetGame_B2514FCE(HostDecision seatFilteredRequest);
    // forge/gui/interfaces/IGuiGame.setNetGame()V
    HostDecision Request_setNetGame_18C1ACAE(HostDecision seatFilteredRequest);
}

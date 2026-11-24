// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C476{
internal static JClass Build(){var c=new JClass("forge/game/card/CardView","forge/game/GameEntityView",new string[]{},33);Add0(c);Add1(c);Add2(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-3624090829028979255L),null));
c.Add(new JField("zoneText","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(5454,"forge/game/card/CardView","get","(Lforge/game/card/Card;)Lforge/game/card/CardView;",9,1,1,new JHandler[]{},M5454));
c.Add(new JMethod(5455,"forge/game/card/CardView","getState","(Lforge/game/card/Card;Lforge/card/CardStateName;)Lforge/game/card/CardView$CardStateView;",9,3,2,new JHandler[]{},M5455));
c.Add(new JMethod(5456,"forge/game/card/CardView","getStateMap","(Ljava/lang/Iterable;)Ljava/util/Map;",9,4,3,new JHandler[]{},M5456));
c.Add(new JMethod(5457,"forge/game/card/CardView","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M5457));
c.Add(new JMethod(5458,"forge/game/card/CardView","getBackup","()Lforge/game/card/CardView;",1,1,2,new JHandler[]{},M5458));
c.Add(new JMethod(5459,"forge/game/card/CardView","getCardForUi","(Lforge/item/IPaperCard;)Lforge/game/card/CardView;",9,1,1,new JHandler[]{},M5459));
c.Add(new JMethod(5460,"forge/game/card/CardView","getObject","()Ljava/lang/Object;",1,1,2,new JHandler[]{},M5460));
c.Add(new JMethod(5461,"forge/game/card/CardView","clearObject","()V",1,1,3,new JHandler[]{},M5461));
c.Add(new JMethod(5462,"forge/game/card/CardView","getCollection","(Ljava/lang/Iterable;)Lforge/trackable/TrackableCollection;",9,4,2,new JHandler[]{},M5462));
c.Add(new JMethod(5463,"forge/game/card/CardView","mayViewAny","(Ljava/lang/Iterable;Ljava/lang/Iterable;)Z",9,4,2,new JHandler[]{},M5463));
c.Add(new JMethod(5464,"forge/game/card/CardView","<init>","(ILforge/trackable/Tracker;)V",1,3,4,new JHandler[]{},M5464));
c.Add(new JMethod(5465,"forge/game/card/CardView","<init>","(ILforge/trackable/Tracker;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V",1,6,4,new JHandler[]{},M5465));
c.Add(new JMethod(5466,"forge/game/card/CardView","<init>","(ILforge/trackable/Tracker;Ljava/lang/String;)V",1,4,4,new JHandler[]{},M5466));
c.Add(new JMethod(5467,"forge/game/card/CardView","<init>","(ILforge/trackable/Tracker;Ljava/lang/String;Ljava/lang/String;)V",1,5,4,new JHandler[]{},M5467));
c.Add(new JMethod(5468,"forge/game/card/CardView","updateName","(Lforge/game/GameEntity;)V",4,3,3,new JHandler[]{},M5468));
c.Add(new JMethod(5469,"forge/game/card/CardView","getOracleName","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5469));
c.Add(new JMethod(5470,"forge/game/card/CardView","getOwner","()Lforge/game/player/PlayerView;",1,1,2,new JHandler[]{},M5470));
c.Add(new JMethod(5471,"forge/game/card/CardView","updateOwner","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5471));
c.Add(new JMethod(5472,"forge/game/card/CardView","getController","()Lforge/game/player/PlayerView;",1,1,2,new JHandler[]{},M5472));
c.Add(new JMethod(5473,"forge/game/card/CardView","updateController","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5473));
c.Add(new JMethod(5474,"forge/game/card/CardView","getZone","()Lforge/game/zone/ZoneType;",1,1,2,new JHandler[]{},M5474));
c.Add(new JMethod(5475,"forge/game/card/CardView","updateZone","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5475));
c.Add(new JMethod(5476,"forge/game/card/CardView","isInZone","(Ljava/lang/Iterable;)Z",1,2,2,new JHandler[]{},M5476));
c.Add(new JMethod(5477,"forge/game/card/CardView","isCloned","()Z",1,1,2,new JHandler[]{},M5477));
c.Add(new JMethod(5478,"forge/game/card/CardView","isFaceDown","()Z",1,1,2,new JHandler[]{},M5478));
c.Add(new JMethod(5479,"forge/game/card/CardView","isForeTold","()Z",1,1,2,new JHandler[]{},M5479));
c.Add(new JMethod(5480,"forge/game/card/CardView","isFlipCard","()Z",1,1,2,new JHandler[]{},M5480));
c.Add(new JMethod(5481,"forge/game/card/CardView","isFlipped","()Z",1,1,2,new JHandler[]{},M5481));
c.Add(new JMethod(5482,"forge/game/card/CardView","isSplitCard","()Z",1,1,2,new JHandler[]{},M5482));
c.Add(new JMethod(5483,"forge/game/card/CardView","isDoubleFacedCard","()Z",1,1,2,new JHandler[]{},M5483));
c.Add(new JMethod(5484,"forge/game/card/CardView","hasSecondaryState","()Z",1,1,2,new JHandler[]{},M5484));
c.Add(new JMethod(5485,"forge/game/card/CardView","hasPreparedSpell","()Z",1,1,2,new JHandler[]{},M5485));
c.Add(new JMethod(5486,"forge/game/card/CardView","isModalCard","()Z",1,1,2,new JHandler[]{},M5486));
c.Add(new JMethod(5487,"forge/game/card/CardView","isRoom","()Z",1,1,2,new JHandler[]{},M5487));
c.Add(new JMethod(5488,"forge/game/card/CardView","getFacedownImageKey","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5488));
c.Add(new JMethod(5489,"forge/game/card/CardView","isAttacking","()Z",1,1,2,new JHandler[]{},M5489));
c.Add(new JMethod(5490,"forge/game/card/CardView","updateAttacking","(Lforge/game/card/Card;)V",0,3,4,new JHandler[]{},M5490));
c.Add(new JMethod(5491,"forge/game/card/CardView","isExertedThisTurn","()Z",1,1,2,new JHandler[]{},M5491));
c.Add(new JMethod(5492,"forge/game/card/CardView","updateExertedThisTurn","(Lforge/game/card/Card;Z)V",0,3,3,new JHandler[]{},M5492));
c.Add(new JMethod(5493,"forge/game/card/CardView","isDetained","()Z",1,1,2,new JHandler[]{},M5493));
c.Add(new JMethod(5494,"forge/game/card/CardView","updateDetained","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5494));
c.Add(new JMethod(5495,"forge/game/card/CardView","isBlocking","()Z",1,1,2,new JHandler[]{},M5495));
c.Add(new JMethod(5496,"forge/game/card/CardView","updateBlocking","(Lforge/game/card/Card;)V",0,3,4,new JHandler[]{},M5496));
c.Add(new JMethod(5497,"forge/game/card/CardView","isPhasedOut","()Z",1,1,2,new JHandler[]{},M5497));
c.Add(new JMethod(5498,"forge/game/card/CardView","updatePhasedOut","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5498));
c.Add(new JMethod(5499,"forge/game/card/CardView","isFirstTurnControlled","()Z",1,1,2,new JHandler[]{},M5499));
c.Add(new JMethod(5500,"forge/game/card/CardView","hasSickness","()Z",1,1,1,new JHandler[]{},M5500));
c.Add(new JMethod(5501,"forge/game/card/CardView","isSick","()Z",1,1,2,new JHandler[]{},M5501));
c.Add(new JMethod(5502,"forge/game/card/CardView","updateSickness","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5502));
c.Add(new JMethod(5503,"forge/game/card/CardView","isTapped","()Z",1,1,2,new JHandler[]{},M5503));
c.Add(new JMethod(5504,"forge/game/card/CardView","updateTapped","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5504));
c.Add(new JMethod(5505,"forge/game/card/CardView","getGamePieceType","()Lforge/card/GamePieceType;",1,1,2,new JHandler[]{},M5505));
c.Add(new JMethod(5506,"forge/game/card/CardView","updateGamePieceType","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5506));
c.Add(new JMethod(5507,"forge/game/card/CardView","isToken","()Z",1,1,2,new JHandler[]{},M5507));
c.Add(new JMethod(5508,"forge/game/card/CardView","updateToken","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5508));
c.Add(new JMethod(5509,"forge/game/card/CardView","isImmutable","()Z",1,1,2,new JHandler[]{},M5509));
c.Add(new JMethod(5510,"forge/game/card/CardView","isEmblem","()Z",1,1,2,new JHandler[]{},M5510));
c.Add(new JMethod(5511,"forge/game/card/CardView","updateEmblem","(Lforge/game/card/Card;)V",1,2,3,new JHandler[]{},M5511));
c.Add(new JMethod(5512,"forge/game/card/CardView","isBoon","()Z",1,1,2,new JHandler[]{},M5512));
c.Add(new JMethod(5513,"forge/game/card/CardView","updateBoon","(Lforge/game/card/Card;)V",1,2,3,new JHandler[]{},M5513));
c.Add(new JMethod(5514,"forge/game/card/CardView","canSpecialize","()Z",1,1,2,new JHandler[]{},M5514));
c.Add(new JMethod(5515,"forge/game/card/CardView","updateSpecialize","(Lforge/game/card/Card;)V",1,2,3,new JHandler[]{},M5515));
}

private static void Add1(JClass c){
c.Add(new JMethod(5516,"forge/game/card/CardView","isTokenCard","()Z",1,1,2,new JHandler[]{},M5516));
c.Add(new JMethod(5517,"forge/game/card/CardView","updateTokenCard","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5517));
c.Add(new JMethod(5518,"forge/game/card/CardView","isCommander","()Z",1,1,2,new JHandler[]{},M5518));
c.Add(new JMethod(5519,"forge/game/card/CardView","updateCommander","(Lforge/game/card/Card;)V",0,3,3,new JHandler[]{},M5519));
c.Add(new JMethod(5520,"forge/game/card/CardView","getCommanderType","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5520));
c.Add(new JMethod(5521,"forge/game/card/CardView","hasSamePT","(Lforge/game/card/CardView;)Z",1,2,2,new JHandler[]{},M5521));
c.Add(new JMethod(5522,"forge/game/card/CardView","updateCounters","(Lforge/game/card/Card;)V",0,3,2,new JHandler[]{},M5522));
c.Add(new JMethod(5523,"forge/game/card/CardView","getDamage","()I",1,1,2,new JHandler[]{},M5523));
c.Add(new JMethod(5524,"forge/game/card/CardView","updateDamage","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5524));
c.Add(new JMethod(5525,"forge/game/card/CardView","getAssignedDamage","()I",1,1,2,new JHandler[]{},M5525));
c.Add(new JMethod(5526,"forge/game/card/CardView","updateAssignedDamage","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5526));
c.Add(new JMethod(5527,"forge/game/card/CardView","getLethalDamage","()I",1,1,2,new JHandler[]{},M5527));
c.Add(new JMethod(5528,"forge/game/card/CardView","updateLethalDamage","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5528));
c.Add(new JMethod(5529,"forge/game/card/CardView","getShieldCount","()I",1,1,2,new JHandler[]{},M5529));
c.Add(new JMethod(5530,"forge/game/card/CardView","updateShieldCount","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5530));
c.Add(new JMethod(5531,"forge/game/card/CardView","getChosenType","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5531));
c.Add(new JMethod(5532,"forge/game/card/CardView","updateChosenType","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5532));
c.Add(new JMethod(5533,"forge/game/card/CardView","getChosenType2","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5533));
c.Add(new JMethod(5534,"forge/game/card/CardView","updateChosenType2","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5534));
c.Add(new JMethod(5535,"forge/game/card/CardView","getNotedTypes","()Ljava/util/List;",1,1,2,new JHandler[]{},M5535));
c.Add(new JMethod(5536,"forge/game/card/CardView","updateNotedTypes","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5536));
c.Add(new JMethod(5537,"forge/game/card/CardView","getChosenNumber","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5537));
c.Add(new JMethod(5538,"forge/game/card/CardView","updateChosenNumber","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5538));
c.Add(new JMethod(5539,"forge/game/card/CardView","clearChosenNumber","()V",0,1,3,new JHandler[]{},M5539));
c.Add(new JMethod(5540,"forge/game/card/CardView","getStoredRolls","()Ljava/util/List;",1,1,2,new JHandler[]{},M5540));
c.Add(new JMethod(5541,"forge/game/card/CardView","updateStoredRolls","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5541));
c.Add(new JMethod(5542,"forge/game/card/CardView","getChosenColors","()Ljava/util/List;",1,1,2,new JHandler[]{},M5542));
c.Add(new JMethod(5543,"forge/game/card/CardView","updateChosenColors","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5543));
c.Add(new JMethod(5544,"forge/game/card/CardView","hasPaperFoil","()Z",1,1,2,new JHandler[]{},M5544));
c.Add(new JMethod(5545,"forge/game/card/CardView","updatePaperFoil","(Z)V",0,2,3,new JHandler[]{},M5545));
c.Add(new JMethod(5546,"forge/game/card/CardView","getMarkedColors","()Lforge/card/ColorSet;",1,1,2,new JHandler[]{},M5546));
c.Add(new JMethod(5547,"forge/game/card/CardView","updateMarkedColors","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5547));
c.Add(new JMethod(5548,"forge/game/card/CardView","getMergedCardsCollection","()Lforge/util/collect/FCollectionView;",1,1,2,new JHandler[]{},M5548));
c.Add(new JMethod(5549,"forge/game/card/CardView","getChosenCards","()Lforge/util/collect/FCollectionView;",1,1,2,new JHandler[]{},M5549));
c.Add(new JMethod(5550,"forge/game/card/CardView","getChosenPlayer","()Lforge/game/player/PlayerView;",1,1,2,new JHandler[]{},M5550));
c.Add(new JMethod(5551,"forge/game/card/CardView","updateChosenPlayer","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5551));
c.Add(new JMethod(5552,"forge/game/card/CardView","getPromisedGift","()Lforge/game/player/PlayerView;",1,1,2,new JHandler[]{},M5552));
c.Add(new JMethod(5553,"forge/game/card/CardView","updatePromisedGift","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5553));
c.Add(new JMethod(5554,"forge/game/card/CardView","getProtectingPlayer","()Lforge/game/player/PlayerView;",1,1,2,new JHandler[]{},M5554));
c.Add(new JMethod(5555,"forge/game/card/CardView","updateProtectingPlayer","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5555));
c.Add(new JMethod(5556,"forge/game/card/CardView","getChosenDirection","()Lforge/game/Direction;",1,1,2,new JHandler[]{},M5556));
c.Add(new JMethod(5557,"forge/game/card/CardView","updateChosenDirection","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5557));
c.Add(new JMethod(5558,"forge/game/card/CardView","getChosenEvenOdd","()Lforge/game/EvenOdd;",1,1,2,new JHandler[]{},M5558));
c.Add(new JMethod(5559,"forge/game/card/CardView","updateChosenEvenOdd","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5559));
c.Add(new JMethod(5560,"forge/game/card/CardView","getChosenMode","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5560));
c.Add(new JMethod(5561,"forge/game/card/CardView","updateChosenMode","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5561));
c.Add(new JMethod(5562,"forge/game/card/CardView","getCurrentRoom","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5562));
c.Add(new JMethod(5563,"forge/game/card/CardView","updateCurrentRoom","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5563));
c.Add(new JMethod(5564,"forge/game/card/CardView","getIntensity","()I",1,1,2,new JHandler[]{},M5564));
c.Add(new JMethod(5565,"forge/game/card/CardView","updateIntensity","(Lforge/game/card/Card;)V",0,2,4,new JHandler[]{},M5565));
c.Add(new JMethod(5566,"forge/game/card/CardView","getClassLevel","()I",1,1,2,new JHandler[]{},M5566));
c.Add(new JMethod(5567,"forge/game/card/CardView","updateClassLevel","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5567));
c.Add(new JMethod(5568,"forge/game/card/CardView","getRingLevel","()I",1,1,2,new JHandler[]{},M5568));
c.Add(new JMethod(5569,"forge/game/card/CardView","updateRingLevel","(Lforge/game/card/Card;)V",0,3,3,new JHandler[]{},M5569));
c.Add(new JMethod(5570,"forge/game/card/CardView","getOverlayText","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5570));
c.Add(new JMethod(5571,"forge/game/card/CardView","getMarkerText","()Ljava/util/List;",1,1,2,new JHandler[]{},M5571));
c.Add(new JMethod(5572,"forge/game/card/CardView","updateMarkerText","(Lforge/game/card/Card;)V",0,3,3,new JHandler[]{},M5572));
c.Add(new JMethod(5573,"forge/game/card/CardView","getRemembered","()Ljava/lang/String;",2,1,2,new JHandler[]{},M5573));
c.Add(new JMethod(5574,"forge/game/card/CardView","updateRemembered","(Lforge/game/card/Card;)V",0,5,3,new JHandler[]{},M5574));
c.Add(new JMethod(5575,"forge/game/card/CardView","getSector","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5575));
c.Add(new JMethod(5576,"forge/game/card/CardView","updateSector","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5576));
c.Add(new JMethod(5577,"forge/game/card/CardView","getSprocket","()I",1,1,2,new JHandler[]{},M5577));
c.Add(new JMethod(5578,"forge/game/card/CardView","updateSprocket","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5578));
c.Add(new JMethod(5579,"forge/game/card/CardView","getDraftAction","()Ljava/util/List;",1,1,2,new JHandler[]{},M5579));
}

private static void Add2(JClass c){
c.Add(new JMethod(5580,"forge/game/card/CardView","updateDraftAction","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5580));
c.Add(new JMethod(5581,"forge/game/card/CardView","getNamedCard","()Ljava/util/List;",1,1,2,new JHandler[]{},M5581));
c.Add(new JMethod(5582,"forge/game/card/CardView","updateNamedCard","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5582));
c.Add(new JMethod(5583,"forge/game/card/CardView","mayPlayerLook","(Lforge/game/player/PlayerView;)Z",1,3,2,new JHandler[]{},M5583));
c.Add(new JMethod(5584,"forge/game/card/CardView","setPlayerMayLook","(Ljava/lang/Iterable;)V",0,2,3,new JHandler[]{},M5584));
c.Add(new JMethod(5585,"forge/game/card/CardView","canBeShownToAny","(Ljava/lang/Iterable;)Z",1,2,2,new JHandler[]{},M5585));
c.Add(new JMethod(5586,"forge/game/card/CardView","canBeShownTo","(Lforge/game/player/PlayerView;)Z",1,5,2,new JHandler[]{},M5586));
c.Add(new JMethod(5587,"forge/game/card/CardView","canFaceDownBeShownToAny","(Ljava/lang/Iterable;)Z",1,2,2,new JHandler[]{},M5587));
c.Add(new JMethod(5588,"forge/game/card/CardView","canFaceDownBeShownTo","(Lforge/game/player/PlayerView;)Z",1,3,4,new JHandler[]{},M5588));
c.Add(new JMethod(5589,"forge/game/card/CardView","getEncodedCards","()Lforge/util/collect/FCollectionView;",1,1,2,new JHandler[]{},M5589));
c.Add(new JMethod(5590,"forge/game/card/CardView","getUntilLeavesBattlefield","()Lforge/util/collect/FCollectionView;",1,1,2,new JHandler[]{},M5590));
c.Add(new JMethod(5591,"forge/game/card/CardView","getEntityAttachedTo","()Lforge/game/GameEntityView;",1,1,2,new JHandler[]{},M5591));
c.Add(new JMethod(5592,"forge/game/card/CardView","updateAttachedTo","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5592));
c.Add(new JMethod(5593,"forge/game/card/CardView","getAttachedTo","()Lforge/game/card/CardView;",1,2,1,new JHandler[]{},M5593));
c.Add(new JMethod(5594,"forge/game/card/CardView","getEnchantedPlayer","()Lforge/game/player/PlayerView;",1,2,1,new JHandler[]{},M5594));
c.Add(new JMethod(5595,"forge/game/card/CardView","getGainControlTargets","()Lforge/util/collect/FCollectionView;",1,1,2,new JHandler[]{},M5595));
c.Add(new JMethod(5596,"forge/game/card/CardView","getCloneOrigin","()Lforge/game/card/CardView;",1,1,2,new JHandler[]{},M5596));
c.Add(new JMethod(5597,"forge/game/card/CardView","getExiledWith","()Lforge/game/card/CardView;",1,1,2,new JHandler[]{},M5597));
c.Add(new JMethod(5598,"forge/game/card/CardView","getPreparedSpell","()Lforge/game/card/CardView;",1,1,2,new JHandler[]{},M5598));
c.Add(new JMethod(5599,"forge/game/card/CardView","updatePreparedSpell","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5599));
c.Add(new JMethod(5600,"forge/game/card/CardView","getImprintedCards","()Lforge/util/collect/FCollectionView;",1,1,2,new JHandler[]{},M5600));
c.Add(new JMethod(5601,"forge/game/card/CardView","getExiledCards","()Lforge/util/collect/FCollectionView;",1,1,2,new JHandler[]{},M5601));
c.Add(new JMethod(5602,"forge/game/card/CardView","getHauntedBy","()Lforge/util/collect/FCollectionView;",1,1,2,new JHandler[]{},M5602));
c.Add(new JMethod(5603,"forge/game/card/CardView","getHaunting","()Lforge/game/card/CardView;",1,1,2,new JHandler[]{},M5603));
c.Add(new JMethod(5604,"forge/game/card/CardView","getMustBlockCards","()Lforge/util/collect/FCollectionView;",1,1,2,new JHandler[]{},M5604));
c.Add(new JMethod(5605,"forge/game/card/CardView","updateMustBlockCards","(Lforge/game/card/Card;)V",0,2,4,new JHandler[]{},M5605));
c.Add(new JMethod(5606,"forge/game/card/CardView","getPairedWith","()Lforge/game/card/CardView;",1,1,2,new JHandler[]{},M5606));
c.Add(new JMethod(5607,"forge/game/card/CardView","getChangedColorWords","()Ljava/util/Map;",1,1,2,new JHandler[]{},M5607));
c.Add(new JMethod(5608,"forge/game/card/CardView","updateChangedColorWords","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5608));
c.Add(new JMethod(5609,"forge/game/card/CardView","getChangedTypes","()Ljava/util/Map;",1,1,2,new JHandler[]{},M5609));
c.Add(new JMethod(5610,"forge/game/card/CardView","updateChangedTypes","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5610));
c.Add(new JMethod(5611,"forge/game/card/CardView","updateNonAbilityText","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5611));
c.Add(new JMethod(5612,"forge/game/card/CardView","updateStickers","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5612));
c.Add(new JMethod(5613,"forge/game/card/CardView","getText","()Ljava/lang/String;",1,1,3,new JHandler[]{},M5613));
c.Add(new JMethod(5614,"forge/game/card/CardView","getText","(Lforge/game/card/CardView$CardStateView;Ljava/util/HashMap;)Ljava/lang/String;",1,18,4,new JHandler[]{},M5614));
c.Add(new JMethod(5615,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;",1,1,2,new JHandler[]{},M5615));
c.Add(new JMethod(5616,"forge/game/card/CardView","hasAlternateState","()Z",1,1,1,new JHandler[]{},M5616));
c.Add(new JMethod(5617,"forge/game/card/CardView","getAlternateState","()Lforge/game/card/CardView$CardStateView;",1,1,2,new JHandler[]{},M5617));
c.Add(new JMethod(5618,"forge/game/card/CardView","hasLeftSplitState","()Z",1,1,1,new JHandler[]{},M5618));
c.Add(new JMethod(5619,"forge/game/card/CardView","getLeftSplitState","()Lforge/game/card/CardView$CardStateView;",1,1,2,new JHandler[]{},M5619));
c.Add(new JMethod(5620,"forge/game/card/CardView","hasRightSplitState","()Z",1,1,1,new JHandler[]{},M5620));
c.Add(new JMethod(5621,"forge/game/card/CardView","getRightSplitState","()Lforge/game/card/CardView$CardStateView;",1,1,2,new JHandler[]{},M5621));
c.Add(new JMethod(5622,"forge/game/card/CardView","createAlternateState","(Lforge/card/CardStateName;)Lforge/game/card/CardView$CardStateView;",1,2,6,new JHandler[]{},M5622));
c.Add(new JMethod(5623,"forge/game/card/CardView","getState","(Z)Lforge/game/card/CardView$CardStateView;",1,2,1,new JHandler[]{},M5623));
c.Add(new JMethod(5624,"forge/game/card/CardView","useCardArt","()Z",1,1,2,new JHandler[]{},M5624));
c.Add(new JMethod(5625,"forge/game/card/CardView","updateState","(Lforge/game/card/Card;)V",0,9,4,new JHandler[]{},M5625));
c.Add(new JMethod(5626,"forge/game/card/CardView","getHiddenId","()I",1,2,2,new JHandler[]{},M5626));
c.Add(new JMethod(5627,"forge/game/card/CardView","updateHiddenId","(I)V",0,2,3,new JHandler[]{},M5627));
c.Add(new JMethod(5628,"forge/game/card/CardView","getBlockAdditional","()I",0,1,2,new JHandler[]{},M5628));
c.Add(new JMethod(5629,"forge/game/card/CardView","getCanBlockAny","()Z",0,1,2,new JHandler[]{},M5629));
c.Add(new JMethod(5630,"forge/game/card/CardView","updateBlockAdditional","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5630));
c.Add(new JMethod(5631,"forge/game/card/CardView","isRingBearer","()Z",1,1,2,new JHandler[]{},M5631));
c.Add(new JMethod(5632,"forge/game/card/CardView","updateRingBearer","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5632));
c.Add(new JMethod(5633,"forge/game/card/CardView","getCantHaveKeyword","()Ljava/util/Set;",0,1,2,new JHandler[]{},M5633));
c.Add(new JMethod(5634,"forge/game/card/CardView","updateCantHaveKeyword","(Lforge/game/card/Card;)V",0,5,3,new JHandler[]{},M5634));
c.Add(new JMethod(5635,"forge/game/card/CardView","getZoneText","()Ljava/lang/String;",2,1,1,new JHandler[]{},M5635));
c.Add(new JMethod(5636,"forge/game/card/CardView","updateZoneText","(Lforge/game/card/Card;)V",0,5,7,new JHandler[]{},M5636));
c.Add(new JMethod(5637,"forge/game/card/CardView","toString","()Ljava/lang/String;",1,4,3,new JHandler[]{},M5637));
c.Add(new JMethod(5638,"forge/game/card/CardView","updateMergeCollections","(Lforge/game/card/CardCollection;)V",0,6,3,new JHandler[]{},M5638));
}

internal static JStep M5454(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?8:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Pc=12;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","getView","()Lforge/game/card/CardView;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5455(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Reference!=null?20:16;continue;}
case 16:{f.Push(JValue.R(null));f.Pc=17;continue;}
case 17:{f.Pc=24;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/CardState","getView","()Lforge/game/card/CardView$CardStateView;","invokevirtual",24);}
case 24:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5456(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Maps","newLinkedHashMap","()Ljava/util/LinkedHashMap;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int==0?45:20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",26);}
case 26:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardState"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=29;continue;}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/CardState","getView","()Lforge/game/card/CardView$CardStateView;","invokevirtual",35);}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{f.Pc=11;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5457(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/Object","hashCode","()I","invokevirtual",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardView","hashCode","()I","invokevirtual",14);}
case 14:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?28:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/CardView")?1:0));f.Pc=21;continue;}
case 21:{f.Pc=f.Pop().Int==0?28:24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Pc=29;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5458(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PaperCardBackup","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PaperCardBackup","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Reference!=null?12:10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PaperCardBackup","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PaperCardBackup","Lforge/trackable/TrackableProperty;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",19);}
case 19:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/IPaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/card/CardView","getCardForUi","(Lforge/item/IPaperCard;)Lforge/game/card/CardView;","invokestatic",25);}
case 25:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5459(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getCardForUi","(Lforge/item/IPaperCard;)Lforge/game/card/Card;","invokestatic",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getView","()Lforge/game/card/CardView;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5460(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Object","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Object","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5461(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Object","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Object","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5462(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/trackable/TrackableCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference==null?61:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?61:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{f.Pc=f.Pop().Reference==null?58:42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/Card","getRenderForUI","()Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?58:49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/card/Card","getView","()Lforge/game/card/CardView;","invokevirtual",54);}
case 54:{return rt.Call(f,"forge/trackable/TrackableCollection","add","(Ljava/lang/Object;)Z","invokevirtual",57);}
case 57:{f.StackOp("pop");f.Pc=58;continue;}
case 58:{f.Pc=19;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5463(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?45:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/card/CardView","canBeShownToAny","(Ljava/lang/Iterable;)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?42:40;continue;}
case 40:{f.Push(JValue.I(1));f.Pc=41;continue;}
case 41:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 42:{f.Pc=13;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5464(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/GameEntityView","<init>","(ILforge/trackable/Tracker;)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("")));f.Pc=9;continue;}
case 9:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardView","zoneText","Ljava/lang/String;",value);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CurrentState","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CurrentState","Lforge/trackable/TrackableProperty;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/CardView","createAlternateState","(Lforge/card/CardStateName;)Lforge/game/card/CardView$CardStateView;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",26);}
case 26:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5465(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/GameEntityView","<init>","(ILforge/trackable/Tracker;)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("")));f.Pc=9;continue;}
case 9:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardView","zoneText","Ljava/lang/String;",value);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CurrentState","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CurrentState","Lforge/trackable/TrackableProperty;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/CardView","createAlternateState","(Lforge/card/CardStateName;)Lforge/game/card/CardView$CardStateView;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",26);}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",30);}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/CardView$CardStateView","setName","(Ljava/lang/String;)V","invokevirtual",34);}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",38);}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/CardView$CardStateView","setOracleText","(Ljava/lang/String;)V","invokevirtual",43);}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Name","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Name","Lforge/trackable/TrackableProperty;"));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",51);}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Object","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Object","Lforge/trackable/TrackableProperty;"));f.Pc=55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",60);}
case 60:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5466(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/CardView","<init>","(ILforge/trackable/Tracker;)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",10);}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardView$CardStateView","setName","(Ljava/lang/String;)V","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Name","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Name","Lforge/trackable/TrackableProperty;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChangedColorWords","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChangedColorWords","Lforge/trackable/TrackableProperty;"));f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",33);}
case 33:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",36);}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChangedTypes","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChangedTypes","Lforge/trackable/TrackableProperty;"));f.Pc=40;continue;}
case 40:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=43;continue;}
case 43:{f.StackOp("dup");f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",47);}
case 47:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",50);}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Sickness","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Sickness","Lforge/trackable/TrackableProperty;"));f.Pc=54;continue;}
case 54:{f.Push(JValue.I(1));f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",58);}
case 58:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",61);}
case 61:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5467(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","<init>","(ILforge/trackable/Tracker;Ljava/lang/String;)V","invokespecial",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ImageKey","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ImageKey","Lforge/trackable/TrackableProperty;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[4]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",16);}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5468(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?37:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Name","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Name","Lforge/trackable/TrackableProperty;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",20);}
case 20:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",23);}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OracleName","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OracleName","Lforge/trackable/TrackableProperty;"));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",34);}
case 34:{f.Pc=53;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/GameEntityView","updateName","(Lforge/game/GameEntity;)V","invokespecial",42);}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OracleName","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OracleName","Lforge/trackable/TrackableProperty;"));f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/GameEntity","getName","()Ljava/lang/String;","invokevirtual",50);}
case 50:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",53);}
case 53:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5469(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OracleName","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OracleName","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5470(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Owner","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Owner","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/PlayerView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5471(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Owner","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Owner","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5472(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Controller","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Controller","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/PlayerView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5473(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Controller","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Controller","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5474(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Zone","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Zone","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5475(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Zone","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Zone","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Reference!=null?15:11;continue;}
case 11:{f.Push(JValue.R(null));f.Pc=12;continue;}
case 12:{f.Pc=22;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",19);}
case 19:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",22);}
case 22:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",25);}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5476(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardView","getZone","()Lforge/game/zone/ZoneType;","invokevirtual",5);}
case 5:{return rt.Call(f,"com/google/common/collect/Iterables","contains","(Ljava/lang/Iterable;Ljava/lang/Object;)Z","invokestatic",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5477(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Cloned","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Cloned","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5478(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Facedown","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Facedown","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5479(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Foretold","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Foretold","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5480(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","FlipCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","FlipCard","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5481(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Flipped","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Flipped","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5482(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SplitCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SplitCard","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5483(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","DoubleFaced","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","DoubleFaced","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5484(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Secondary","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Secondary","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5485(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView","hasAlternateState","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?24:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardView","getAlternateState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getState","()Lforge/card/CardStateName;","invokevirtual",14);}
case 14:{if(!rt.StaticReady(f,"forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"));f.Pc=17;continue;}
case 17:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5486(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Modal","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Modal","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5487(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Room","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Room","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5488(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","FacedownImageKey","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","FacedownImageKey","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5489(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Attacking","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Attacking","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5490(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Attacking","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Attacking","Lforge/trackable/TrackableProperty;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Reference==null?28:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/combat/Combat","isAttacking","(Lforge/game/card/Card;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?28:24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Pc=29;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",32);}
case 32:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",35);}
case 35:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5491(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ExertedThisTurn","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ExertedThisTurn","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5492(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ExertedThisTurn","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ExertedThisTurn","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5493(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Detained","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Detained","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5494(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Detained","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Detained","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","isDetained","()Z","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5495(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Blocking","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Blocking","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5496(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Blocking","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Blocking","Lforge/trackable/TrackableProperty;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Reference==null?28:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/combat/Combat","isBlocking","(Lforge/game/card/Card;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?28:24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Pc=29;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",32);}
case 32:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",35);}
case 35:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5497(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PhasedOut","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PhasedOut","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5498(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PhasedOut","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PhasedOut","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5499(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Sickness","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Sickness","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5500(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView","isFirstTurnControlled","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?21:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView$CardStateView","hasHaste","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int!=0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5501(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView","getZone","()Lforge/game/zone/ZoneType;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=7;continue;}
case 7:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?31:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/card/CardView$CardStateView","isCreature","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?31:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/CardView","hasSickness","()Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?31:27;continue;}
case 27:{f.Push(JValue.I(1));f.Pc=28;continue;}
case 28:{f.Pc=32;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5502(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Sickness","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Sickness","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","isFirstTurnControlled","()Z","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5503(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Tapped","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Tapped","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5504(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Tapped","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Tapped","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","isTapped","()Z","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5505(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","GamePieceType","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","GamePieceType","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/GamePieceType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5506(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","GamePieceType","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","GamePieceType","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getGamePieceType","()Lforge/card/GamePieceType;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5507(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Token","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Token","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5508(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Token","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Token","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","isToken","()Z","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5509(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","GamePieceType","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","GamePieceType","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{if(!rt.StaticReady(f,"forge/card/GamePieceType","EFFECT","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","EFFECT","Lforge/card/GamePieceType;"));f.Pc=10;continue;}
case 10:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?17:13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Pc=18;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5510(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsEmblem","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","IsEmblem","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5511(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsEmblem","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","IsEmblem","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","isEmblem","()Z","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5512(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsBoon","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","IsBoon","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5513(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsBoon","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","IsBoon","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","isBoon","()Z","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5514(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CanSpecialize","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CanSpecialize","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5515(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CanSpecialize","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CanSpecialize","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","canSpecialize","()Z","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5516(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","TokenCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","TokenCard","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5517(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","TokenCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","TokenCard","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","isTokenCard","()Z","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5518(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsCommander","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","IsCommander","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5519(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isCommander","()Z","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsCommander","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","IsCommander","Lforge/trackable/TrackableProperty;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",13);}
case 13:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",16);}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Int==0?87:20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",27);}
case 27:{if(!rt.StaticReady(f,"forge/game/GameType","Oathbreaker","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Oathbreaker","Lforge/game/GameType;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/GameRules","hasAppliedVariant","(Lforge/game/GameType;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?77:36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",40);}
case 40:{return rt.Call(f,"forge/item/IPaperCard","getRules","()Lforge/card/CardRules;","invokeinterface",45);}
case 45:{return rt.Call(f,"forge/card/CardRules","canBeSignatureSpell","()Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?64:51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CommanderAltType","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CommanderAltType","Lforge/trackable/TrackableProperty;"));f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("Signature Spell")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",61);}
case 61:{f.Pc=87;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CommanderAltType","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CommanderAltType","Lforge/trackable/TrackableProperty;"));f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("Oathbreaker")));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",74);}
case 74:{f.Pc=87;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CommanderAltType","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CommanderAltType","Lforge/trackable/TrackableProperty;"));f.Pc=81;continue;}
case 81:{f.Push(JValue.R(rt.String("Commander")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",87);}
case 87:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5520(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CommanderAltType","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CommanderAltType","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5521(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getPower","()I","invokevirtual",7);}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getPower","()I","invokevirtual",14);}
case 14:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?19:17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getToughness","()I","invokevirtual",26);}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",30);}
case 30:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getToughness","()I","invokevirtual",33);}
case 33:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?38:36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5522(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameEntityView","updateCounters","(Lforge/game/GameEntity;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updatePower","(Lforge/game/card/Card;)V","invokevirtual",15);}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateToughness","(Lforge/game/card/Card;)V","invokevirtual",20);}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateLoyalty","(Lforge/game/card/Card;)V","invokevirtual",25);}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateDefense","(Lforge/game/card/Card;)V","invokevirtual",30);}
case 30:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5523(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Damage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Damage","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5524(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Damage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Damage","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getDamage","()I","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardView","updateLethalDamage","(Lforge/game/card/Card;)V","invokevirtual",19);}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5525(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AssignedDamage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AssignedDamage","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5526(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AssignedDamage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AssignedDamage","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getTotalAssignedDamage","()I","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardView","updateLethalDamage","(Lforge/game/card/Card;)V","invokevirtual",19);}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5527(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","LethalDamage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","LethalDamage","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5528(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","LethalDamage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","LethalDamage","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getLethalDamage","()I","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5529(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ShieldCount","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ShieldCount","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5530(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ShieldCount","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ShieldCount","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getShieldCount","()I","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5531(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenType","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenType","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5532(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenType","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenType","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getChosenType","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5533(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenType2","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenType2","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5534(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenType2","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenType2","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getChosenType2","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5535(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NotedTypes","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","NotedTypes","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5536(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NotedTypes","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","NotedTypes","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getNotedTypes","()Ljava/lang/Iterable;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NotedTypes","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","NotedTypes","Lforge/trackable/TrackableProperty;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/CardView","flagAsChanged","(Lforge/trackable/TrackableProperty;)V","invokevirtual",18);}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5537(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenNumber","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenNumber","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5538(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenNumber","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenNumber","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getChosenNumber","()Ljava/lang/Integer;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Integer","toString","()Ljava/lang/String;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5539(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenNumber","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenNumber","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5540(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","StoredRolls","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","StoredRolls","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5541(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","StoredRolls","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","StoredRolls","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getStoredRollsForView","()Ljava/util/List;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5542(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenColors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenColors","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5543(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenColors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenColors","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getChosenColors","()Ljava/lang/Iterable;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenColors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenColors","Lforge/trackable/TrackableProperty;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/CardView","flagAsChanged","(Lforge/trackable/TrackableProperty;)V","invokevirtual",18);}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5544(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PaperFoil","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PaperFoil","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5545(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PaperFoil","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PaperFoil","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5546(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MarkedColors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MarkedColors","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ColorSet"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5547(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MarkedColors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MarkedColors","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getMarkedColors","()Lforge/card/ColorSet;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5548(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MergedCardsCollection","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MergedCardsCollection","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/collect/FCollection","getEmpty","()Lforge/util/collect/FCollection;","invokestatic",13);}
case 13:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5549(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenCards","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/collect/FCollection","getEmpty","()Lforge/util/collect/FCollection;","invokestatic",13);}
case 13:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5550(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenPlayer","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenPlayer","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/PlayerView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5551(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenPlayer","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenPlayer","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getChosenPlayer","()Lforge/game/player/Player;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5552(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PromisedGift","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PromisedGift","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/PlayerView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5553(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PromisedGift","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PromisedGift","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getPromisedGift","()Lforge/game/player/Player;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5554(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ProtectingPlayer","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ProtectingPlayer","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/PlayerView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5555(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ProtectingPlayer","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ProtectingPlayer","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getProtectingPlayer","()Lforge/game/player/Player;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5556(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenDirection","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenDirection","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/Direction"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5557(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenDirection","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenDirection","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getChosenDirection","()Lforge/game/Direction;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5558(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenEvenOdd","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenEvenOdd","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/EvenOdd"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5559(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenEvenOdd","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenEvenOdd","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getChosenEvenOdd","()Lforge/game/EvenOdd;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5560(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenMode","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenMode","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5561(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenMode","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenMode","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getChosenMode","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5562(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CurrentRoom","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CurrentRoom","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5563(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CurrentRoom","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CurrentRoom","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getCurrentRoom","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/CardView","updateMarkerText","(Lforge/game/card/Card;)V","invokevirtual",16);}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5564(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Intensity","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Intensity","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5565(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Intensity","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Intensity","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getIntensity","(Z)I","invokevirtual",9);}
case 9:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",12);}
case 12:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",15);}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5566(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ClassLevel","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ClassLevel","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5567(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ClassLevel","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ClassLevel","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getClassLevel","()I","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardView","updateMarkerText","(Lforge/game/card/Card;)V","invokevirtual",19);}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5568(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","RingLevel","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","RingLevel","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5569(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference==null?31:9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/player/Player","getTheRing","()Lforge/game/card/Card;","invokevirtual",13);}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?31:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","RingLevel","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","RingLevel","Lforge/trackable/TrackableProperty;"));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/player/Player","getNumRingTemptedYou","()I","invokevirtual",25);}
case 25:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",28);}
case 28:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",31);}
case 31:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5570(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OverlayText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OverlayText","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5571(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MarkerText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MarkerText","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5572(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","getCurrentRoom","()Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Reference==null?46:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/Card","getCurrentRoom","()Ljava/lang/String;","invokevirtual",19);}
case 19:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int!=0?46:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("In Room:")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",34);}
case 34:{f.StackOp("pop");f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/Card","getCurrentRoom","()Ljava/lang/String;","invokevirtual",40);}
case 40:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",45);}
case 45:{f.StackOp("pop");f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/Card","isClassCard","()Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?79:53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int==0?79:63;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/card/Card","getClassLevel","()I","invokevirtual",68);}
case 68:{return rt.DynamicCall(f,"forge/game/card/CardView:5572:68:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",73);}
case 73:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/card/CardView","getRingLevel","()I","invokevirtual",83);}
case 83:{f.Pc=f.Pop().Int<=0?102:86;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/card/CardView","getRingLevel","()I","invokevirtual",91);}
case 91:{return rt.DynamicCall(f,"forge/game/card/CardView:5572:91:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",96);}
case 96:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",101);}
case 101:{f.StackOp("pop");f.Pc=102;continue;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/card/Card","getOverlayText","()Ljava/lang/String;","invokevirtual",106);}
case 106:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNotEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",109);}
case 109:{f.Pc=f.Pop().Int==0?137:112;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OverlayText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OverlayText","Lforge/trackable/TrackableProperty;"));f.Pc=116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/card/Card","getOverlayText","()Ljava/lang/String;","invokevirtual",120);}
case 120:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",123);}
case 123:{f.Push(f.Locals[2]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/card/Card","getOverlayText","()Ljava/lang/String;","invokevirtual",128);}
case 128:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",133);}
case 133:{f.StackOp("pop");f.Pc=134;continue;}
case 134:{f.Pc=145;continue;}
case 137:{f.Push(f.Locals[0]);f.Pc=138;continue;}
case 138:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OverlayText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OverlayText","Lforge/trackable/TrackableProperty;"));f.Pc=141;continue;}
case 141:{f.Push(JValue.R(null));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",145);}
case 145:{f.Push(f.Locals[2]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",151);}
case 151:{f.Pc=f.Pop().Int==0?165:154;continue;}
case 154:{f.Push(f.Locals[0]);f.Pc=155;continue;}
case 155:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MarkerText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MarkerText","Lforge/trackable/TrackableProperty;"));f.Pc=158;continue;}
case 158:{f.Push(JValue.R(null));f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",162);}
case 162:{f.Pc=173;continue;}
case 165:{f.Push(f.Locals[0]);f.Pc=166;continue;}
case 166:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MarkerText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MarkerText","Lforge/trackable/TrackableProperty;"));f.Pc=169;continue;}
case 169:{f.Push(f.Locals[2]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",173);}
case 173:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5573(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Remembered","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Remembered","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5574(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?17:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",11);}
case 11:{return rt.Call(f,"com/google/common/collect/Iterables","isEmpty","(Ljava/lang/Iterable;)Z","invokestatic",14);}
case 14:{f.Pc=f.Pop().Int==0?26:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Remembered","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Remembered","Lforge/trackable/TrackableProperty;"));f.Pc=21;continue;}
case 21:{f.Push(JValue.R(null));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",25);}
case 25:{return JStep.ReturnVoid;}
case 26:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",33);}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("\r\nRemembered: \r\n")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",46);}
case 46:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",51);}
case 51:{f.Locals[3]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",58);}
case 58:{f.Pc=f.Pop().Int==0?92:61;continue;}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",67);}
case 67:{f.Locals[4]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{f.Pc=f.Pop().Reference==null?89:74;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",80);}
case 80:{f.StackOp("pop");f.Pc=81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",88);}
case 88:{f.StackOp("pop");f.Pc=89;continue;}
case 89:{f.Pc=52;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Remembered","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Remembered","Lforge/trackable/TrackableProperty;"));f.Pc=96;continue;}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",100);}
case 100:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",103);}
case 103:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5575(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Sector","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Sector","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5576(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Sector","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Sector","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getSector","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5577(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Sprocket","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Sprocket","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5578(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Sprocket","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Sprocket","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getSprocket","()I","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5579(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","DraftAction","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","DraftAction","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5580(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","DraftAction","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","DraftAction","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getDraftActions","()Ljava/util/List;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","DraftAction","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","DraftAction","Lforge/trackable/TrackableProperty;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/CardView","flagAsChanged","(Lforge/trackable/TrackableProperty;)V","invokevirtual",18);}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5581(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NamedCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","NamedCard","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5582(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NamedCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","NamedCard","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getNamedCards","()Ljava/util/List;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NamedCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","NamedCard","Lforge/trackable/TrackableProperty;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/CardView","flagAsChanged","(Lforge/trackable/TrackableProperty;)V","invokevirtual",18);}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5583(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PlayerMayLook","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PlayerMayLook","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/trackable/TrackableCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference==null?28:15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/trackable/TrackableCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",20);}
case 20:{f.Push(JValue.I(-1));f.Pc=21;continue;}
case 21:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?28:24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Pc=29;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5584(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/Iterables","isEmpty","(Ljava/lang/Iterable;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int==0?18:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PlayerMayLook","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PlayerMayLook","Lforge/trackable/TrackableProperty;"));f.Pc=11;continue;}
case 11:{f.Push(JValue.R(null));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",15);}
case 15:{f.Pc=29;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PlayerMayLook","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PlayerMayLook","Lforge/trackable/TrackableProperty;"));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/player/PlayerView","getCollection","(Ljava/lang/Iterable;)Lforge/trackable/TrackableCollection;","invokestatic",26);}
case 26:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",29);}
case 29:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5585(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?11:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Iterables","isEmpty","(Ljava/lang/Iterable;)Z","invokestatic",8);}
case 8:{f.Pc=f.Pop().Int==0?13:11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.DynamicCall(f,"forge/game/card/CardView:5585:15:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/CardView;)Ljava/util/function/Predicate;",20);}
case 20:{return rt.Call(f,"forge/util/IterableUtil","any","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Z","invokestatic",23);}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5586(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/CardView","getZone","()Lforge/game/zone/ZoneType;","invokevirtual",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference!=null?17:15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/CardView","getController","()Lforge/game/player/PlayerView;","invokevirtual",21);}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{if(!rt.StaticReady(f,"forge/game/card/CardView$1","$SwitchMap$forge$game$zone$ZoneType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardView$1","$SwitchMap$forge$game$zone$ZoneType","[I"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/zone/ZoneType","ordinal","()I","invokevirtual",29);}
case 29:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=30;continue;}
case 30:{switch(f.Pop().Int){case 1:f.Pc=112;break;case 2:f.Pc=112;break;case 3:f.Pc=112;break;case 4:f.Pc=112;break;case 5:f.Pc=112;break;case 6:f.Pc=112;break;case 7:f.Pc=112;break;case 8:f.Pc=114;break;case 9:f.Pc=114;break;case 10:f.Pc=123;break;case 11:f.Pc=133;break;case 12:f.Pc=154;break;case 13:f.Pc=154;break;case 14:f.Pc=154;break;case 15:f.Pc=154;break;case 16:f.Pc=157;break;case 17:f.Pc=159;break;default:f.Pc=161;break;}continue;}
case 112:{f.Push(JValue.I(1));f.Pc=113;continue;}
case 113:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/card/CardView","isFaceDown","()Z","invokevirtual",118);}
case 118:{f.Pc=f.Pop().Int!=0?161:121;continue;}
case 121:{f.Push(JValue.I(1));f.Pc=122;continue;}
case 122:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 123:{f.Push(f.Locals[3]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/player/PlayerView","sharesTeamWith","(Lforge/game/player/PlayerView;)Z","invokevirtual",128);}
case 128:{f.Pc=f.Pop().Int==0?161:131;continue;}
case 131:{f.Push(JValue.I(1));f.Pc=132;continue;}
case 132:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 133:{f.Push(f.Locals[3]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[1]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/player/PlayerView","isOpponentOf","(Lforge/game/player/PlayerView;)Z","invokevirtual",138);}
case 138:{f.Pc=f.Pop().Int==0?152:141;continue;}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[1]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/card/CardView","mayPlayerLook","(Lforge/game/player/PlayerView;)Z","invokevirtual",146);}
case 146:{f.Pc=f.Pop().Int!=0?152:149;continue;}
case 149:{f.Pc=161;continue;}
case 152:{f.Push(JValue.I(1));f.Pc=153;continue;}
case 153:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 154:{f.Pc=161;continue;}
case 157:{f.Push(JValue.I(1));f.Pc=158;continue;}
case 158:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 159:{f.Push(JValue.I(1));f.Pc=160;continue;}
case 160:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 161:{f.Push(f.Locals[0]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[1]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/card/CardView","mayPlayerLook","(Lforge/game/player/PlayerView;)Z","invokevirtual",166);}
case 166:{f.Pc=f.Pop().Int==0?171:169;continue;}
case 169:{f.Push(JValue.I(1));f.Pc=170;continue;}
case 170:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 171:{f.Push(f.Locals[3]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/player/PlayerView","getMindSlaveMaster","()Lforge/game/player/PlayerView;","invokevirtual",175);}
case 175:{f.Locals[4]=f.Pop();f.Pc=177;continue;}
case 177:{f.Push(f.Locals[4]);f.Pc=179;continue;}
case 179:{f.Pc=f.Pop().Reference==null?200:182;continue;}
case 182:{f.Push(f.Locals[4]);f.Pc=184;continue;}
case 184:{f.Push(f.Locals[3]);f.Pc=185;continue;}
case 185:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?200:188;continue;}
case 188:{f.Push(f.Locals[4]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[1]);f.Pc=191;continue;}
case 191:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?200:194;continue;}
case 194:{f.Push(f.Locals[0]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[3]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/card/CardView","canBeShownTo","(Lforge/game/player/PlayerView;)Z","invokevirtual",199);}
case 199:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 200:{f.Push(JValue.I(0));f.Pc=201;continue;}
case 201:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5587(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?11:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Iterables","isEmpty","(Ljava/lang/Iterable;)Z","invokestatic",8);}
case 8:{f.Pc=f.Pop().Int==0?13:11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.DynamicCall(f,"forge/game/card/CardView:5587:15:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/CardView;)Ljava/util/function/Predicate;",20);}
case 20:{return rt.Call(f,"forge/util/IterableUtil","any","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Z","invokestatic",23);}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5588(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView","isFaceDown","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardView","mayPlayerLook","(Lforge/game/player/PlayerView;)Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?19:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/CardView","getController","()Lforge/game/player/PlayerView;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/game/player/PlayerView","getMindSlaveMaster","()Lforge/game/player/PlayerView;","invokevirtual",26);}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Pc=f.Pop().Reference==null?53:31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/CardView","getController","()Lforge/game/player/PlayerView;","invokevirtual",36);}
case 36:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?53:39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?53:44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/card/CardView","getController","()Lforge/game/player/PlayerView;","invokevirtual",49);}
case 49:{return rt.Call(f,"forge/game/card/CardView","canFaceDownBeShownTo","(Lforge/game/player/PlayerView;)Z","invokevirtual",52);}
case 52:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=57;continue;}
case 57:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=60;continue;}
case 60:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",66);}
case 66:{return rt.Call(f,"forge/game/card/CardView","isInZone","(Ljava/lang/Iterable;)Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int==0?87:72;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/card/CardView","getController","()Lforge/game/player/PlayerView;","invokevirtual",76);}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/player/PlayerView","equals","(Ljava/lang/Object;)Z","invokevirtual",80);}
case 80:{f.Pc=f.Pop().Int==0?87:83;continue;}
case 83:{f.Push(JValue.I(1));f.Pc=84;continue;}
case 84:{f.Pc=88;continue;}
case 87:{f.Push(JValue.I(0));f.Pc=88;continue;}
case 88:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5589(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","EncodedCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","EncodedCards","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/collect/FCollection","getEmpty","()Lforge/util/collect/FCollection;","invokestatic",13);}
case 13:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5590(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","UntilLeavesBattlefield","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","UntilLeavesBattlefield","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/collect/FCollection","getEmpty","()Lforge/util/collect/FCollection;","invokestatic",13);}
case 13:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5591(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","EntityAttachedTo","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","EntityAttachedTo","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntityView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5592(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","EntityAttachedTo","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","EntityAttachedTo","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getEntityAttachedTo","()Lforge/game/GameEntity;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/GameEntityView","get","(Lforge/game/GameEntity;)Lforge/game/GameEntityView;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5593(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView","getEntityAttachedTo","()Lforge/game/GameEntityView;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/CardView")?1:0));f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Int==0?17:12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
case 17:{f.Push(JValue.R(null));f.Pc=18;continue;}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5594(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView","getEntityAttachedTo","()Lforge/game/GameEntityView;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/PlayerView")?1:0));f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Int==0?17:12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/PlayerView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
case 17:{f.Push(JValue.R(null));f.Pc=18;continue;}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5595(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","GainControlTargets","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","GainControlTargets","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/collect/FCollection","getEmpty","()Lforge/util/collect/FCollection;","invokestatic",13);}
case 13:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5596(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CloneOrigin","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CloneOrigin","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5597(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ExiledWith","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ExiledWith","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5598(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PreparedSpell","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PreparedSpell","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5599(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PreparedSpell","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PreparedSpell","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getPreparedSpell","()Lforge/game/card/Card;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/game/card/Card;)Lforge/game/card/CardView;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5600(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ImprintedCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ImprintedCards","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/collect/FCollection","getEmpty","()Lforge/util/collect/FCollection;","invokestatic",13);}
case 13:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5601(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ExiledCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ExiledCards","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/collect/FCollection","getEmpty","()Lforge/util/collect/FCollection;","invokestatic",13);}
case 13:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5602(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HauntedBy","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HauntedBy","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/collect/FCollection","getEmpty","()Lforge/util/collect/FCollection;","invokestatic",13);}
case 13:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5603(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Haunting","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Haunting","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5604(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MustBlockCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MustBlockCards","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/collect/FCollection","getEmpty","()Lforge/util/collect/FCollection;","invokestatic",13);}
case 13:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5605(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/Card","getMustBlockCards","()Lforge/game/card/CardCollectionView;","invokevirtual",6);}
case 6:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MustBlockCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MustBlockCards","Lforge/trackable/TrackableProperty;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/CardView","setCards","(Lforge/game/card/CardCollection;Ljava/lang/Iterable;Lforge/trackable/TrackableProperty;)Lforge/game/card/CardCollection;","invokevirtual",12);}
case 12:{f.StackOp("pop");f.Pc=13;continue;}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5606(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PairedWith","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PairedWith","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5607(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChangedColorWords","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChangedColorWords","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5608(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChangedColorWords","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChangedColorWords","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getChangedTextColorWords","()Lcom/google/common/collect/ImmutableMap;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5609(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChangedTypes","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChangedTypes","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5610(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChangedTypes","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChangedTypes","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getChangedTextTypeWords","()Lcom/google/common/collect/ImmutableMap;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5611(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NonAbilityText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","NonAbilityText","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getNonAbilityText","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5612(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Stickers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Stickers","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/sticker/StickerSheet","describe","(Lforge/game/card/Card;)Ljava/lang/String;","invokestatic",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5613(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",5);}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardView","getText","(Lforge/game/card/CardView$CardStateView;Ljava/util/HashMap;)Ljava/lang/String;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5614(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("")));f.Pc=10;continue;}
case 10:{f.Locals[4]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("")));f.Pc=14;continue;}
case 14:{f.Locals[5]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("")));f.Pc=18;continue;}
case 18:{f.Locals[6]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("")));f.Pc=22;continue;}
case 22:{f.Locals[7]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Reference==null?76:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("name")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/HashMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("altname")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/HashMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{f.Locals[6]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{f.Push(JValue.R(rt.String("oracle")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/HashMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",59);}
case 59:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=62;continue;}
case 62:{f.Locals[5]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("altoracle")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/HashMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",71);}
case 71:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=74;continue;}
case 74:{f.Locals[7]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/card/CardView","isSplitCard","()Z","invokevirtual",80);}
case 80:{f.Pc=f.Pop().Int==0?181:83;continue;}
case 83:{f.Push(f.Locals[4]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",88);}
case 88:{f.Pc=f.Pop().Int==0?101:91;continue;}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/card/CardView","getLeftSplitState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",95);}
case 95:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getName","()Ljava/lang/String;","invokevirtual",98);}
case 98:{f.Pc=103;continue;}
case 101:{f.Push(f.Locals[4]);f.Pc=103;continue;}
case 103:{f.Locals[4]=f.Pop();f.Pc=105;continue;}
case 105:{f.Push(f.Locals[6]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",110);}
case 110:{f.Pc=f.Pop().Int==0?123:113;continue;}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/card/CardView","getRightSplitState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",117);}
case 117:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getName","()Ljava/lang/String;","invokevirtual",120);}
case 120:{f.Pc=125;continue;}
case 123:{f.Push(f.Locals[6]);f.Pc=125;continue;}
case 125:{f.Locals[6]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/card/CardView","getId","()I","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int>=0?226:134;continue;}
case 134:{f.Push(f.Locals[5]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",139);}
case 139:{f.Pc=f.Pop().Int==0?152:142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/card/CardView","getLeftSplitState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",146);}
case 146:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getOracleText","()Ljava/lang/String;","invokevirtual",149);}
case 149:{f.Pc=154;continue;}
case 152:{f.Push(f.Locals[5]);f.Pc=154;continue;}
case 154:{f.Locals[5]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[7]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",161);}
case 161:{f.Pc=f.Pop().Int==0?174:164;continue;}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/card/CardView","getRightSplitState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",168);}
case 168:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getOracleText","()Ljava/lang/String;","invokevirtual",171);}
case 171:{f.Pc=176;continue;}
case 174:{f.Push(f.Locals[7]);f.Pc=176;continue;}
case 176:{f.Locals[7]=f.Pop();f.Pc=178;continue;}
case 178:{f.Pc=226;continue;}
case 181:{f.Push(f.Locals[4]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",186);}
case 186:{f.Pc=f.Pop().Int==0?196:189;continue;}
case 189:{f.Push(f.Locals[1]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getName","()Ljava/lang/String;","invokevirtual",193);}
case 193:{f.Pc=198;continue;}
case 196:{f.Push(f.Locals[4]);f.Pc=198;continue;}
case 198:{f.Locals[4]=f.Pop();f.Pc=200;continue;}
case 200:{f.Push(f.Locals[0]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/game/card/CardView","getId","()I","invokevirtual",204);}
case 204:{f.Pc=f.Pop().Int>=0?226:207;continue;}
case 207:{f.Push(f.Locals[5]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",212);}
case 212:{f.Pc=f.Pop().Int==0?222:215;continue;}
case 215:{f.Push(f.Locals[1]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getOracleText","()Ljava/lang/String;","invokevirtual",219);}
case 219:{f.Pc=224;continue;}
case 222:{f.Push(f.Locals[5]);f.Pc=224;continue;}
case 224:{f.Locals[5]=f.Pop();f.Pc=226;continue;}
case 226:{f.Push(f.Locals[0]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/card/CardView","getId","()I","invokevirtual",230);}
case 230:{f.Pc=f.Pop().Int>=0?323:233;continue;}
case 233:{f.Push(f.Locals[0]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"forge/game/card/CardView","isSplitCard","()Z","invokevirtual",237);}
case 237:{f.Pc=f.Pop().Int==0?311:240;continue;}
case 240:{f.Push(f.Locals[5]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",245);}
case 245:{f.Pc=f.Pop().Int!=0?311:248;continue;}
case 248:{f.Push(f.Locals[3]);f.Pc=249;continue;}
case 249:{f.Push(JValue.R(rt.String("(")));f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",255);}
case 255:{f.Push(f.Locals[4]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",260);}
case 260:{f.Push(JValue.R(rt.String(") ")));f.Pc=263;continue;}
case 263:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",266);}
case 266:{f.StackOp("pop");f.Pc=267;continue;}
case 267:{f.Push(f.Locals[3]);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[5]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",273);}
case 273:{f.StackOp("pop");f.Pc=274;continue;}
case 274:{f.Push(f.Locals[3]);f.Pc=275;continue;}
case 275:{f.Push(JValue.R(rt.String("\r\n\r\n")));f.Pc=278;continue;}
case 278:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",281);}
case 281:{f.StackOp("pop");f.Pc=282;continue;}
case 282:{f.Push(f.Locals[3]);f.Pc=283;continue;}
case 283:{f.Push(JValue.R(rt.String("(")));f.Pc=286;continue;}
case 286:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",289);}
case 289:{f.Push(f.Locals[6]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",294);}
case 294:{f.Push(JValue.R(rt.String(") ")));f.Pc=297;continue;}
case 297:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",300);}
case 300:{f.StackOp("pop");f.Pc=301;continue;}
case 301:{f.Push(f.Locals[3]);f.Pc=302;continue;}
case 302:{f.Push(f.Locals[7]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",307);}
case 307:{f.StackOp("pop");f.Pc=308;continue;}
case 308:{f.Pc=318;continue;}
case 311:{f.Push(f.Locals[3]);f.Pc=312;continue;}
case 312:{f.Push(f.Locals[5]);f.Pc=314;continue;}
case 314:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",317);}
case 317:{f.StackOp("pop");f.Pc=318;continue;}
case 318:{f.Push(f.Locals[3]);f.Pc=319;continue;}
case 319:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",322);}
case 322:{return JStep.Return(f.Pop());}
case 323:{f.Push(f.Locals[1]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getRulesText","()Ljava/lang/String;","invokevirtual",327);}
case 327:{f.Locals[8]=f.Pop();f.Pc=329;continue;}
case 329:{f.Push(f.Locals[8]);f.Pc=331;continue;}
case 331:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",334);}
case 334:{f.Pc=f.Pop().Int!=0?350:337;continue;}
case 337:{f.Push(f.Locals[3]);f.Pc=338;continue;}
case 338:{f.Push(f.Locals[8]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",343);}
case 343:{f.Push(JValue.R(rt.String("\r\n\r\n")));f.Pc=346;continue;}
case 346:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",349);}
case 349:{f.StackOp("pop");f.Pc=350;continue;}
case 350:{f.Push(f.Locals[0]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/game/card/CardView","isCommander","()Z","invokevirtual",354);}
case 354:{f.Pc=f.Pop().Int==0?404:357;continue;}
case 357:{f.Push(f.Locals[3]);f.Pc=358;continue;}
case 358:{f.Push(f.Locals[0]);f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/card/CardView","getOwner","()Lforge/game/player/PlayerView;","invokevirtual",362);}
case 362:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",365);}
case 365:{f.Push(JValue.R(rt.String("'s ")));f.Pc=368;continue;}
case 368:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",371);}
case 371:{f.Push(f.Locals[0]);f.Pc=372;continue;}
case 372:{return rt.Call(f,"forge/game/card/CardView","getCommanderType","()Ljava/lang/String;","invokevirtual",375);}
case 375:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",378);}
case 378:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=381;continue;}
case 381:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",384);}
case 384:{f.StackOp("pop");f.Pc=385;continue;}
case 385:{f.Push(f.Locals[3]);f.Pc=386;continue;}
case 386:{f.Push(f.Locals[0]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"forge/game/card/CardView","getOwner","()Lforge/game/player/PlayerView;","invokevirtual",390);}
case 390:{f.Push(f.Locals[0]);f.Pc=391;continue;}
case 391:{return rt.Call(f,"forge/game/player/PlayerView","getCommanderInfo","(Lforge/game/card/CardView;)Ljava/lang/String;","invokevirtual",394);}
case 394:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",397);}
case 397:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=400;continue;}
case 400:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",403);}
case 403:{f.StackOp("pop");f.Pc=404;continue;}
case 404:{f.Push(f.Locals[0]);f.Pc=405;continue;}
case 405:{return rt.Call(f,"forge/game/card/CardView","isSplitCard","()Z","invokevirtual",408);}
case 408:{f.Pc=f.Pop().Int==0?519:411;continue;}
case 411:{f.Push(f.Locals[0]);f.Pc=412;continue;}
case 412:{return rt.Call(f,"forge/game/card/CardView","isFaceDown","()Z","invokevirtual",415);}
case 415:{f.Pc=f.Pop().Int!=0?519:418;continue;}
case 418:{f.Push(f.Locals[0]);f.Pc=419;continue;}
case 419:{return rt.Call(f,"forge/game/card/CardView","getZone","()Lforge/game/zone/ZoneType;","invokevirtual",422);}
case 422:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=425;continue;}
case 425:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?519:428;continue;}
case 428:{f.Push(f.Locals[0]);f.Pc=429;continue;}
case 429:{return rt.Call(f,"forge/game/card/CardView","getZone","()Lforge/game/zone/ZoneType;","invokevirtual",432);}
case 432:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=435;continue;}
case 435:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?519:438;continue;}
case 438:{f.Push(f.Locals[3]);f.Pc=439;continue;}
case 439:{f.Push(JValue.R(rt.String("(")));f.Pc=442;continue;}
case 442:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",445);}
case 445:{f.Push(f.Locals[0]);f.Pc=446;continue;}
case 446:{return rt.Call(f,"forge/game/card/CardView","getLeftSplitState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",449);}
case 449:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getName","()Ljava/lang/String;","invokevirtual",452);}
case 452:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",455);}
case 455:{f.Push(JValue.R(rt.String(") ")));f.Pc=458;continue;}
case 458:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",461);}
case 461:{f.StackOp("pop");f.Pc=462;continue;}
case 462:{f.Push(f.Locals[3]);f.Pc=463;continue;}
case 463:{f.Push(f.Locals[0]);f.Pc=464;continue;}
case 464:{return rt.Call(f,"forge/game/card/CardView","getLeftSplitState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",467);}
case 467:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getAbilityText","()Ljava/lang/String;","invokevirtual",470);}
case 470:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",473);}
case 473:{f.StackOp("pop");f.Pc=474;continue;}
case 474:{f.Push(f.Locals[3]);f.Pc=475;continue;}
case 475:{f.Push(JValue.R(rt.String("\r\n\r\n")));f.Pc=478;continue;}
case 478:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",481);}
case 481:{f.Push(JValue.R(rt.String("(")));f.Pc=484;continue;}
case 484:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",487);}
case 487:{f.Push(f.Locals[0]);f.Pc=488;continue;}
case 488:{return rt.Call(f,"forge/game/card/CardView","getRightSplitState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",491);}
case 491:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getName","()Ljava/lang/String;","invokevirtual",494);}
case 494:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",497);}
case 497:{f.Push(JValue.R(rt.String(") ")));f.Pc=500;continue;}
case 500:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",503);}
case 503:{f.StackOp("pop");f.Pc=504;continue;}
case 504:{f.Push(f.Locals[3]);f.Pc=505;continue;}
case 505:{f.Push(f.Locals[0]);f.Pc=506;continue;}
case 506:{return rt.Call(f,"forge/game/card/CardView","getRightSplitState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",509);}
case 509:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getAbilityText","()Ljava/lang/String;","invokevirtual",512);}
case 512:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",515);}
case 515:{f.StackOp("pop");f.Pc=516;continue;}
case 516:{f.Pc=528;continue;}
case 519:{f.Push(f.Locals[3]);f.Pc=520;continue;}
case 520:{f.Push(f.Locals[1]);f.Pc=521;continue;}
case 521:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getAbilityText","()Ljava/lang/String;","invokevirtual",524);}
case 524:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",527);}
case 527:{f.StackOp("pop");f.Pc=528;continue;}
case 528:{f.Push(f.Locals[0]);f.Pc=529;continue;}
case 529:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NonAbilityText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","NonAbilityText","Lforge/trackable/TrackableProperty;"));f.Pc=532;continue;}
case 532:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",535);}
case 535:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=538;continue;}
case 538:{f.Locals[9]=f.Pop();f.Pc=540;continue;}
case 540:{f.Push(f.Locals[9]);f.Pc=542;continue;}
case 542:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",545);}
case 545:{f.Pc=f.Pop().Int!=0?573:548;continue;}
case 548:{f.Push(f.Locals[3]);f.Pc=549;continue;}
case 549:{f.Push(JValue.R(rt.String("\r\n \r\nNon ability features: \r\n")));f.Pc=552;continue;}
case 552:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",555);}
case 555:{f.StackOp("pop");f.Pc=556;continue;}
case 556:{f.Push(f.Locals[3]);f.Pc=557;continue;}
case 557:{f.Push(f.Locals[9]);f.Pc=559;continue;}
case 559:{f.Push(JValue.R(rt.String("CARDNAME")));f.Pc=562;continue;}
case 562:{f.Push(f.Locals[0]);f.Pc=563;continue;}
case 563:{return rt.Call(f,"forge/game/card/CardView","getName","()Ljava/lang/String;","invokevirtual",566);}
case 566:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",569);}
case 569:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",572);}
case 572:{f.StackOp("pop");f.Pc=573;continue;}
case 573:{f.Push(f.Locals[0]);f.Pc=574;continue;}
case 574:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Stickers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Stickers","Lforge/trackable/TrackableProperty;"));f.Pc=577;continue;}
case 577:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",580);}
case 580:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=583;continue;}
case 583:{f.Locals[10]=f.Pop();f.Pc=585;continue;}
case 585:{f.Push(f.Locals[10]);f.Pc=587;continue;}
case 587:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNotEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",590);}
case 590:{f.Pc=f.Pop().Int==0?606:593;continue;}
case 593:{f.Push(f.Locals[3]);f.Pc=594;continue;}
case 594:{f.Push(JValue.R(rt.String("\r\n\r\n")));f.Pc=597;continue;}
case 597:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",600);}
case 600:{f.Push(f.Locals[10]);f.Pc=602;continue;}
case 602:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",605);}
case 605:{f.StackOp("pop");f.Pc=606;continue;}
case 606:{f.Push(f.Locals[0]);f.Pc=607;continue;}
case 607:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttractionLights","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttractionLights","Lforge/trackable/TrackableProperty;"));f.Pc=610;continue;}
case 610:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",613);}
case 613:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=616;continue;}
case 616:{f.Locals[11]=f.Pop();f.Pc=618;continue;}
case 618:{f.Push(f.Locals[11]);f.Pc=620;continue;}
case 620:{f.Pc=f.Pop().Reference==null?654:623;continue;}
case 623:{f.Push(f.Locals[11]);f.Pc=625;continue;}
case 625:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",630);}
case 630:{f.Pc=f.Pop().Int!=0?654:633;continue;}
case 633:{f.Push(f.Locals[3]);f.Pc=634;continue;}
case 634:{f.Push(JValue.R(rt.String("\r\n\r\nLights: ")));f.Pc=637;continue;}
case 637:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",640);}
case 640:{f.StackOp("pop");f.Pc=641;continue;}
case 641:{f.Push(f.Locals[3]);f.Pc=642;continue;}
case 642:{f.Push(f.Locals[11]);f.Pc=644;continue;}
case 644:{f.Push(JValue.R(rt.String(", ")));f.Pc=647;continue;}
case 647:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",650);}
case 650:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",653);}
case 653:{f.StackOp("pop");f.Pc=654;continue;}
case 654:{f.Push(f.Locals[3]);f.Pc=655;continue;}
case 655:{f.Push(f.Locals[0]);f.Pc=656;continue;}
case 656:{return rt.Call(f,"forge/game/card/CardView","getRemembered","()Ljava/lang/String;","invokevirtual",659);}
case 659:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",662);}
case 662:{f.StackOp("pop");f.Pc=663;continue;}
case 663:{f.Push(f.Locals[0]);f.Pc=664;continue;}
case 664:{return rt.Call(f,"forge/game/card/CardView","getChosenDirection","()Lforge/game/Direction;","invokevirtual",667);}
case 667:{f.Locals[12]=f.Pop();f.Pc=669;continue;}
case 669:{f.Push(f.Locals[12]);f.Pc=671;continue;}
case 671:{f.Pc=f.Pop().Reference==null?697:674;continue;}
case 674:{f.Push(f.Locals[3]);f.Pc=675;continue;}
case 675:{f.Push(JValue.R(rt.String("\r\n[Chosen direction: ")));f.Pc=678;continue;}
case 678:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",681);}
case 681:{f.StackOp("pop");f.Pc=682;continue;}
case 682:{f.Push(f.Locals[3]);f.Pc=683;continue;}
case 683:{f.Push(f.Locals[12]);f.Pc=685;continue;}
case 685:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",688);}
case 688:{f.StackOp("pop");f.Pc=689;continue;}
case 689:{f.Push(f.Locals[3]);f.Pc=690;continue;}
case 690:{f.Push(JValue.R(rt.String("]\r\n")));f.Pc=693;continue;}
case 693:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",696);}
case 696:{f.StackOp("pop");f.Pc=697;continue;}
case 697:{f.Push(f.Locals[0]);f.Pc=698;continue;}
case 698:{return rt.Call(f,"forge/game/card/CardView","getChosenEvenOdd","()Lforge/game/EvenOdd;","invokevirtual",701);}
case 701:{f.Locals[13]=f.Pop();f.Pc=703;continue;}
case 703:{f.Push(f.Locals[13]);f.Pc=705;continue;}
case 705:{f.Pc=f.Pop().Reference==null?731:708;continue;}
case 708:{f.Push(f.Locals[3]);f.Pc=709;continue;}
case 709:{f.Push(JValue.R(rt.String("\r\n[Chosen value: ")));f.Pc=712;continue;}
case 712:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",715);}
case 715:{f.StackOp("pop");f.Pc=716;continue;}
case 716:{f.Push(f.Locals[3]);f.Pc=717;continue;}
case 717:{f.Push(f.Locals[13]);f.Pc=719;continue;}
case 719:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",722);}
case 722:{f.StackOp("pop");f.Pc=723;continue;}
case 723:{f.Push(f.Locals[3]);f.Pc=724;continue;}
case 724:{f.Push(JValue.R(rt.String("]\r\n")));f.Pc=727;continue;}
case 727:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",730);}
case 730:{f.StackOp("pop");f.Pc=731;continue;}
case 731:{f.Push(f.Locals[0]);f.Pc=732;continue;}
case 732:{return rt.Call(f,"forge/game/card/CardView","getPairedWith","()Lforge/game/card/CardView;","invokevirtual",735);}
case 735:{f.Locals[14]=f.Pop();f.Pc=737;continue;}
case 737:{f.Push(f.Locals[14]);f.Pc=739;continue;}
case 739:{f.Pc=f.Pop().Reference==null?763:742;continue;}
case 742:{f.Push(f.Locals[3]);f.Pc=743;continue;}
case 743:{f.Push(JValue.R(rt.String("\r\n \r\nPaired With: ")));f.Pc=746;continue;}
case 746:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",749);}
case 749:{f.Push(f.Locals[14]);f.Pc=751;continue;}
case 751:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",754);}
case 754:{f.StackOp("pop");f.Pc=755;continue;}
case 755:{f.Push(f.Locals[3]);f.Pc=756;continue;}
case 756:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=759;continue;}
case 759:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",762);}
case 762:{f.StackOp("pop");f.Pc=763;continue;}
case 763:{f.Push(f.Locals[0]);f.Pc=764;continue;}
case 764:{return rt.Call(f,"forge/game/card/CardView","getCanBlockAny","()Z","invokevirtual",767);}
case 767:{f.Pc=f.Pop().Int==0?807:770;continue;}
case 770:{f.Push(f.Locals[3]);f.Pc=771;continue;}
case 771:{f.Push(JValue.R(rt.String("\r\n\r\n")));f.Pc=774;continue;}
case 774:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",777);}
case 777:{f.StackOp("pop");f.Pc=778;continue;}
case 778:{f.Push(f.Locals[3]);f.Pc=779;continue;}
case 779:{f.Push(JValue.R(rt.String("CARDNAME can block any number of creatures.")));f.Pc=782;continue;}
case 782:{f.Push(JValue.R(rt.String("CARDNAME")));f.Pc=785;continue;}
case 785:{f.Push(f.Locals[0]);f.Pc=786;continue;}
case 786:{return rt.Call(f,"forge/game/card/CardView","getName","()Ljava/lang/String;","invokevirtual",789);}
case 789:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",792);}
case 792:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",795);}
case 795:{f.StackOp("pop");f.Pc=796;continue;}
case 796:{f.Push(f.Locals[3]);f.Pc=797;continue;}
case 797:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=800;continue;}
case 800:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",803);}
case 803:{f.StackOp("pop");f.Pc=804;continue;}
case 804:{f.Pc=885;continue;}
case 807:{f.Push(f.Locals[0]);f.Pc=808;continue;}
case 808:{return rt.Call(f,"forge/game/card/CardView","getBlockAdditional","()I","invokevirtual",811);}
case 811:{f.Locals[15]=f.Pop();f.Pc=813;continue;}
case 813:{f.Push(f.Locals[15]);f.Pc=815;continue;}
case 815:{f.Pc=f.Pop().Int<=0?885:818;continue;}
case 818:{f.Push(f.Locals[3]);f.Pc=819;continue;}
case 819:{f.Push(JValue.R(rt.String("\r\n\r\n")));f.Pc=822;continue;}
case 822:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",825);}
case 825:{f.StackOp("pop");f.Pc=826;continue;}
case 826:{f.Push(f.Locals[3]);f.Pc=827;continue;}
case 827:{f.Push(JValue.R(rt.String("CARDNAME can block an additional ")));f.Pc=830;continue;}
case 830:{f.Push(JValue.R(rt.String("CARDNAME")));f.Pc=833;continue;}
case 833:{f.Push(f.Locals[0]);f.Pc=834;continue;}
case 834:{return rt.Call(f,"forge/game/card/CardView","getName","()Ljava/lang/String;","invokevirtual",837);}
case 837:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",840);}
case 840:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",843);}
case 843:{f.StackOp("pop");f.Pc=844;continue;}
case 844:{f.Push(f.Locals[3]);f.Pc=845;continue;}
case 845:{f.Push(f.Locals[15]);f.Pc=847;continue;}
case 847:{f.Push(JValue.I(1));f.Pc=848;continue;}
case 848:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?857:851;continue;}
case 851:{f.Push(JValue.R(rt.String("creature")));f.Pc=854;continue;}
case 854:{f.Pc=865;continue;}
case 857:{f.Push(f.Locals[15]);f.Pc=859;continue;}
case 859:{f.Push(JValue.R(rt.String("creature")));f.Pc=862;continue;}
case 862:{return rt.Call(f,"forge/util/Lang","nounWithNumeral","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",865);}
case 865:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",868);}
case 868:{f.StackOp("pop");f.Pc=869;continue;}
case 869:{f.Push(f.Locals[3]);f.Pc=870;continue;}
case 870:{f.Push(JValue.R(rt.String(" each combat.")));f.Pc=873;continue;}
case 873:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",876);}
case 876:{f.StackOp("pop");f.Pc=877;continue;}
case 877:{f.Push(f.Locals[3]);f.Pc=878;continue;}
case 878:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=881;continue;}
case 881:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",884);}
case 884:{f.StackOp("pop");f.Pc=885;continue;}
case 885:{f.Push(f.Locals[0]);f.Pc=886;continue;}
case 886:{return rt.Call(f,"forge/game/card/CardView","getCantHaveKeyword","()Ljava/util/Set;","invokevirtual",889);}
case 889:{f.Locals[15]=f.Pop();f.Pc=891;continue;}
case 891:{f.Push(f.Locals[15]);f.Pc=893;continue;}
case 893:{f.Pc=f.Pop().Reference==null?989:896;continue;}
case 896:{f.Push(f.Locals[15]);f.Pc=898;continue;}
case 898:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",903);}
case 903:{f.Pc=f.Pop().Int!=0?989:906;continue;}
case 906:{f.Push(f.Locals[3]);f.Pc=907;continue;}
case 907:{f.Push(JValue.R(rt.String("\r\n\r\n")));f.Pc=910;continue;}
case 910:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",913);}
case 913:{f.StackOp("pop");f.Pc=914;continue;}
case 914:{f.Push(f.Locals[15]);f.Pc=916;continue;}
case 916:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",921);}
case 921:{f.Locals[16]=f.Pop();f.Pc=923;continue;}
case 923:{f.Push(f.Locals[16]);f.Pc=925;continue;}
case 925:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",930);}
case 930:{f.Pc=f.Pop().Int==0?989:933;continue;}
case 933:{f.Push(f.Locals[16]);f.Pc=935;continue;}
case 935:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",940);}
case 940:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=943;continue;}
case 943:{f.Locals[17]=f.Pop();f.Pc=945;continue;}
case 945:{f.Push(f.Locals[3]);f.Pc=946;continue;}
case 946:{f.Push(JValue.R(rt.String("CARDNAME can't have or gain ")));f.Pc=949;continue;}
case 949:{f.Push(JValue.R(rt.String("CARDNAME")));f.Pc=952;continue;}
case 952:{f.Push(f.Locals[0]);f.Pc=953;continue;}
case 953:{return rt.Call(f,"forge/game/card/CardView","getName","()Ljava/lang/String;","invokevirtual",956);}
case 956:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",959);}
case 959:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",962);}
case 962:{f.StackOp("pop");f.Pc=963;continue;}
case 963:{f.Push(f.Locals[3]);f.Pc=964;continue;}
case 964:{f.Push(f.Locals[17]);f.Pc=966;continue;}
case 966:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",969);}
case 969:{f.StackOp("pop");f.Pc=970;continue;}
case 970:{f.Push(f.Locals[3]);f.Pc=971;continue;}
case 971:{f.Push(JValue.R(rt.String(".")));f.Pc=974;continue;}
case 974:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",977);}
case 977:{f.StackOp("pop");f.Pc=978;continue;}
case 978:{f.Push(f.Locals[3]);f.Pc=979;continue;}
case 979:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=982;continue;}
case 982:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",985);}
case 985:{f.StackOp("pop");f.Pc=986;continue;}
case 986:{f.Pc=923;continue;}
case 989:{f.Push(f.Locals[0]);f.Pc=990;continue;}
case 990:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Cloner","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Cloner","Lforge/trackable/TrackableProperty;"));f.Pc=993;continue;}
case 993:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",996);}
case 996:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=999;continue;}
case 999:{f.Locals[16]=f.Pop();f.Pc=1001;continue;}
case 1001:{f.Push(f.Locals[16]);f.Pc=1003;continue;}
case 1003:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",1006);}
case 1006:{f.Pc=f.Pop().Int!=0?1022:1009;continue;}
case 1009:{f.Push(f.Locals[3]);f.Pc=1010;continue;}
case 1010:{f.Push(JValue.R(rt.String("\r\nCloned by: ")));f.Pc=1013;continue;}
case 1013:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1016);}
case 1016:{f.Push(f.Locals[16]);f.Pc=1018;continue;}
case 1018:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1021);}
case 1021:{f.StackOp("pop");f.Pc=1022;continue;}
case 1022:{f.Push(f.Locals[0]);f.Pc=1023;continue;}
case 1023:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MergedCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MergedCards","Lforge/trackable/TrackableProperty;"));f.Pc=1026;continue;}
case 1026:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",1029);}
case 1029:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1032;continue;}
case 1032:{f.Locals[17]=f.Pop();f.Pc=1034;continue;}
case 1034:{f.Push(f.Locals[17]);f.Pc=1036;continue;}
case 1036:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",1039);}
case 1039:{f.Pc=f.Pop().Int!=0?1055:1042;continue;}
case 1042:{f.Push(f.Locals[3]);f.Pc=1043;continue;}
case 1043:{f.Push(JValue.R(rt.String("\r\n\r\nMerged Cards: ")));f.Pc=1046;continue;}
case 1046:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1049);}
case 1049:{f.Push(f.Locals[17]);f.Pc=1051;continue;}
case 1051:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1054);}
case 1054:{f.StackOp("pop");f.Pc=1055;continue;}
case 1055:{f.Push(f.Locals[3]);f.Pc=1056;continue;}
case 1056:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1059);}
case 1059:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",1062);}
case 1062:{f.Push(JValue.R(rt.String("\\r")));f.Pc=1065;continue;}
case 1065:{f.Push(JValue.R(rt.String("\r")));f.Pc=1068;continue;}
case 1068:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",1071);}
case 1071:{f.Push(JValue.R(rt.String("\\n")));f.Pc=1074;continue;}
case 1074:{f.Push(JValue.R(rt.String("\n")));f.Pc=1077;continue;}
case 1077:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",1080);}
case 1080:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5615(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CurrentState","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CurrentState","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardView$CardStateView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5616(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView","getAlternateState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5617(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AlternateState","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AlternateState","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardView$CardStateView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5618(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView","getLeftSplitState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5619(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","LeftSplitState","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","LeftSplitState","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardView$CardStateView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5620(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView","getRightSplitState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5621(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","RightSplitState","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","RightSplitState","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardView$CardStateView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5622(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardView$CardStateView"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardView$CardStateView")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardView","getId","()I","invokevirtual",9);}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardView","tracker","Lforge/trackable/Tracker;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/CardView$CardStateView","<init>","(Lforge/game/card/CardView;ILforge/card/CardStateName;Lforge/trackable/Tracker;)V","invokespecial",17);}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5623(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int==0?11:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardView","getAlternateState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",8);}
case 8:{f.Pc=15;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5624(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference!=null?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{if(!rt.StaticReady(f,"forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",16);}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardView$CardStateView","state","Lforge/card/CardStateName;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/card/CardStateName","equals","(Ljava/lang/Object;)Z","invokevirtual",22);}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5625(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardView","updateName","(Lforge/game/GameEntity;)V","invokevirtual",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/CardView","updateZoneText","(Lforge/game/card/Card;)V","invokevirtual",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardView","updateDamage","(Lforge/game/card/Card;)V","invokevirtual",15);}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/CardView","updateSpecialize","(Lforge/game/card/Card;)V","invokevirtual",20);}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/card/CardView","updateRingLevel","(Lforge/game/card/Card;)V","invokevirtual",25);}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/CardView","updateMarkerText","(Lforge/game/card/Card;)V","invokevirtual",30);}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/Card","getIntensity","(Z)I","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int<=0?43:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/CardView","updateIntensity","(Lforge/game/card/Card;)V","invokevirtual",43);}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/card/CardView","getBackup","()Lforge/game/card/CardView;","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Reference!=null?96:50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int!=0?96:57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/Card","isDoubleFaced","()Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int!=0?85:64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/card/Card","isFlipCard","()Z","invokevirtual",68);}
case 68:{f.Pc=f.Pop().Int!=0?85:71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/card/Card","isAdventureCard","()Z","invokevirtual",75);}
case 75:{f.Pc=f.Pop().Int!=0?85:78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/card/Card","isCloned","()Z","invokevirtual",82);}
case 82:{f.Pc=f.Pop().Int==0?96:85;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PaperCardBackup","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PaperCardBackup","Lforge/trackable/TrackableProperty;"));f.Pc=89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",93);}
case 93:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",96);}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/card/Card","isSplitCard","()Z","invokevirtual",100);}
case 100:{f.Locals[2]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Cloned","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Cloned","Lforge/trackable/TrackableProperty;"));f.Pc=105;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/card/Card","isCloned","()Z","invokevirtual",109);}
case 109:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",112);}
case 112:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",115);}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SplitCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SplitCard","Lforge/trackable/TrackableProperty;"));f.Pc=119;continue;}
case 119:{f.Push(f.Locals[2]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",123);}
case 123:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",126);}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","FlipCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","FlipCard","Lforge/trackable/TrackableProperty;"));f.Pc=130;continue;}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/card/Card","isFlipCard","()Z","invokevirtual",134);}
case 134:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",137);}
case 137:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",140);}
case 140:{f.Push(f.Locals[0]);f.Pc=141;continue;}
case 141:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Flipped","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Flipped","Lforge/trackable/TrackableProperty;"));f.Pc=144;continue;}
case 144:{f.Push(f.Locals[1]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",148);}
case 148:{if(!rt.StaticReady(f,"forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"));f.Pc=151;continue;}
case 151:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?158:154;continue;}
case 154:{f.Push(JValue.I(1));f.Pc=155;continue;}
case 155:{f.Pc=159;continue;}
case 158:{f.Push(JValue.I(0));f.Pc=159;continue;}
case 159:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",162);}
case 162:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",165);}
case 165:{f.Push(f.Locals[0]);f.Pc=166;continue;}
case 166:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Facedown","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Facedown","Lforge/trackable/TrackableProperty;"));f.Pc=169;continue;}
case 169:{f.Push(f.Locals[1]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",173);}
case 173:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",176);}
case 176:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",179);}
case 179:{f.Push(f.Locals[0]);f.Pc=180;continue;}
case 180:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Foretold","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Foretold","Lforge/trackable/TrackableProperty;"));f.Pc=183;continue;}
case 183:{f.Push(f.Locals[1]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/card/Card","isForetold","()Z","invokevirtual",187);}
case 187:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",190);}
case 190:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",193);}
case 193:{f.Push(f.Locals[0]);f.Pc=194;continue;}
case 194:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Secondary","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Secondary","Lforge/trackable/TrackableProperty;"));f.Pc=197;continue;}
case 197:{f.Push(f.Locals[1]);f.Pc=198;continue;}
case 198:{if(!rt.StaticReady(f,"forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"));f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",204);}
case 204:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",207);}
case 207:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",210);}
case 210:{f.Push(f.Locals[0]);f.Pc=211;continue;}
case 211:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","DoubleFaced","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","DoubleFaced","Lforge/trackable/TrackableProperty;"));f.Pc=214;continue;}
case 214:{f.Push(f.Locals[1]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/card/Card","isDoubleFaced","()Z","invokevirtual",218);}
case 218:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",221);}
case 221:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",224);}
case 224:{f.Push(f.Locals[0]);f.Pc=225;continue;}
case 225:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Modal","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Modal","Lforge/trackable/TrackableProperty;"));f.Pc=228;continue;}
case 228:{f.Push(f.Locals[1]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/card/Card","isModal","()Z","invokevirtual",232);}
case 232:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",235);}
case 235:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",238);}
case 238:{f.Push(f.Locals[0]);f.Pc=239;continue;}
case 239:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Room","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Room","Lforge/trackable/TrackableProperty;"));f.Pc=242;continue;}
case 242:{f.Push(f.Locals[1]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/card/Card","isRoom","()Z","invokevirtual",246);}
case 246:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",249);}
case 249:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",252);}
case 252:{f.Push(f.Locals[0]);f.Pc=253;continue;}
case 253:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","FacedownImageKey","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","FacedownImageKey","Lforge/trackable/TrackableProperty;"));f.Pc=256;continue;}
case 256:{f.Push(f.Locals[1]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/card/Card","getFacedownImageKey","()Ljava/lang/String;","invokevirtual",260);}
case 260:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",263);}
case 263:{f.Push(f.Locals[1]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/game/card/Card","getCloner","()Lforge/game/card/Card;","invokevirtual",267);}
case 267:{f.Locals[3]=f.Pop();f.Pc=268;continue;}
case 268:{f.Push(f.Locals[0]);f.Pc=269;continue;}
case 269:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Cloner","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Cloner","Lforge/trackable/TrackableProperty;"));f.Pc=272;continue;}
case 272:{f.Push(f.Locals[3]);f.Pc=273;continue;}
case 273:{f.Pc=f.Pop().Reference!=null?280:276;continue;}
case 276:{f.Push(JValue.R(null));f.Pc=277;continue;}
case 277:{f.Pc=299;continue;}
case 280:{f.Push(f.Locals[3]);f.Pc=281;continue;}
case 281:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=284;continue;}
case 284:{return rt.Call(f,"forge/game/card/Card","getOriginalState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",287);}
case 287:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",290);}
case 290:{f.Push(f.Locals[3]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",294);}
case 294:{return rt.DynamicCall(f,"forge/game/card/CardView:5625:294:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;I)Ljava/lang/String;",299);}
case 299:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",302);}
case 302:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=305;continue;}
case 305:{f.StackOp("dup");f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",309);}
case 309:{f.Locals[4]=f.Pop();f.Pc=311;continue;}
case 311:{f.Push(f.Locals[1]);f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/game/card/Card","hasMergedCard","()Z","invokevirtual",315);}
case 315:{f.Pc=f.Pop().Int==0?523:318;continue;}
case 318:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=321;continue;}
case 321:{f.StackOp("dup");f.Pc=322;continue;}
case 322:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",325);}
case 325:{f.Locals[5]=f.Pop();f.Pc=327;continue;}
case 327:{f.Push(f.Locals[1]);f.Pc=328;continue;}
case 328:{return rt.Call(f,"forge/game/card/Card","getMergedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",331);}
case 331:{f.Locals[6]=f.Pop();f.Pc=333;continue;}
case 333:{f.Push(JValue.I(1));f.Pc=334;continue;}
case 334:{f.Locals[7]=f.Pop();f.Pc=336;continue;}
case 336:{f.Push(f.Locals[7]);f.Pc=338;continue;}
case 338:{f.Push(f.Locals[6]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",345);}
case 345:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?425:348;continue;}
case 348:{f.Push(f.Locals[6]);f.Pc=350;continue;}
case 350:{f.Push(f.Locals[7]);f.Pc=352;continue;}
case 352:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",357);}
case 357:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=360;continue;}
case 360:{f.Locals[8]=f.Pop();f.Pc=362;continue;}
case 362:{f.Push(f.Locals[7]);f.Pc=364;continue;}
case 364:{f.Push(JValue.I(1));f.Pc=365;continue;}
case 365:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?377:368;continue;}
case 368:{f.Push(f.Locals[5]);f.Pc=370;continue;}
case 370:{f.Push(JValue.R(rt.String(", ")));f.Pc=373;continue;}
case 373:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",376);}
case 376:{f.StackOp("pop");f.Pc=377;continue;}
case 377:{f.Push(f.Locals[5]);f.Pc=379;continue;}
case 379:{f.Push(f.Locals[8]);f.Pc=381;continue;}
case 381:{f.Push(f.Locals[8]);f.Pc=383;continue;}
case 383:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",386);}
case 386:{return rt.Call(f,"forge/game/card/Card","getOriginalState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",389);}
case 389:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",392);}
case 392:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",395);}
case 395:{f.StackOp("pop");f.Pc=396;continue;}
case 396:{f.Push(f.Locals[5]);f.Pc=398;continue;}
case 398:{f.Push(JValue.R(rt.String(" (")));f.Pc=401;continue;}
case 401:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",404);}
case 404:{f.Push(f.Locals[8]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",409);}
case 409:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",412);}
case 412:{f.Push(JValue.R(rt.String(")")));f.Pc=415;continue;}
case 415:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",418);}
case 418:{f.StackOp("pop");f.Pc=419;continue;}
case 419:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=422;continue;}
case 422:{f.Pc=336;continue;}
case 425:{f.Push(f.Locals[0]);f.Pc=426;continue;}
case 426:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MergedCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MergedCards","Lforge/trackable/TrackableProperty;"));f.Pc=429;continue;}
case 429:{f.Push(f.Locals[5]);f.Pc=431;continue;}
case 431:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",434);}
case 434:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",437);}
case 437:{f.Push(JValue.I(0));f.Pc=438;continue;}
case 438:{f.Locals[7]=f.Pop();f.Pc=440;continue;}
case 440:{f.Push(f.Locals[7]);f.Pc=442;continue;}
case 442:{f.Push(f.Locals[6]);f.Pc=444;continue;}
case 444:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",449);}
case 449:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?520:452;continue;}
case 452:{f.Push(f.Locals[6]);f.Pc=454;continue;}
case 454:{f.Push(f.Locals[7]);f.Pc=456;continue;}
case 456:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",461);}
case 461:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=464;continue;}
case 464:{f.Locals[8]=f.Pop();f.Pc=466;continue;}
case 466:{f.Push(f.Locals[7]);f.Pc=468;continue;}
case 468:{f.Pc=f.Pop().Int!=0?506:471;continue;}
case 471:{f.Push(f.Locals[8]);f.Pc=473;continue;}
case 473:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",476);}
case 476:{f.Pc=f.Pop().Int!=0?495:479;continue;}
case 479:{f.Push(f.Locals[4]);f.Pc=481;continue;}
case 481:{f.Push(f.Locals[1]);f.Pc=482;continue;}
case 482:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",485);}
case 485:{return rt.Call(f,"forge/game/card/Card","getCardForUi","(Lforge/item/IPaperCard;)Lforge/game/card/Card;","invokestatic",488);}
case 488:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",491);}
case 491:{f.StackOp("pop");f.Pc=492;continue;}
case 492:{f.Pc=514;continue;}
case 495:{f.Push(f.Locals[4]);f.Pc=497;continue;}
case 497:{f.Push(f.Locals[8]);f.Pc=499;continue;}
case 499:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",502);}
case 502:{f.StackOp("pop");f.Pc=503;continue;}
case 503:{f.Pc=514;continue;}
case 506:{f.Push(f.Locals[4]);f.Pc=508;continue;}
case 508:{f.Push(f.Locals[8]);f.Pc=510;continue;}
case 510:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",513);}
case 513:{f.StackOp("pop");f.Pc=514;continue;}
case 514:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=517;continue;}
case 517:{f.Pc=440;continue;}
case 520:{f.Pc=531;continue;}
case 523:{f.Push(f.Locals[0]);f.Pc=524;continue;}
case 524:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MergedCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MergedCards","Lforge/trackable/TrackableProperty;"));f.Pc=527;continue;}
case 527:{f.Push(JValue.R(null));f.Pc=528;continue;}
case 528:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",531);}
case 531:{f.Push(f.Locals[0]);f.Pc=532;continue;}
case 532:{f.Push(f.Locals[4]);f.Pc=534;continue;}
case 534:{return rt.Call(f,"forge/game/card/CardView","updateMergeCollections","(Lforge/game/card/CardCollection;)V","invokevirtual",537);}
case 537:{f.Push(f.Locals[2]);f.Pc=538;continue;}
case 538:{f.Pc=f.Pop().Int==0?605:541;continue;}
case 541:{f.Push(f.Locals[0]);f.Pc=542;continue;}
case 542:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","LeftSplitState","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","LeftSplitState","Lforge/trackable/TrackableProperty;"));f.Pc=545;continue;}
case 545:{f.Push(f.Locals[1]);f.Pc=546;continue;}
case 546:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=549;continue;}
case 549:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",552);}
case 552:{return rt.Call(f,"forge/game/card/CardState","getView","()Lforge/game/card/CardView$CardStateView;","invokevirtual",555);}
case 555:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",558);}
case 558:{f.Push(f.Locals[0]);f.Pc=559;continue;}
case 559:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","RightSplitState","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","RightSplitState","Lforge/trackable/TrackableProperty;"));f.Pc=562;continue;}
case 562:{f.Push(f.Locals[1]);f.Pc=563;continue;}
case 563:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=566;continue;}
case 566:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",569);}
case 569:{return rt.Call(f,"forge/game/card/CardState","getView","()Lforge/game/card/CardView$CardStateView;","invokevirtual",572);}
case 572:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",575);}
case 575:{f.Push(f.Locals[0]);f.Pc=576;continue;}
case 576:{return rt.Call(f,"forge/game/card/CardView","getLeftSplitState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",579);}
case 579:{f.Push(f.Locals[1]);f.Pc=580;continue;}
case 580:{f.Push(f.Locals[1]);f.Pc=581;continue;}
case 581:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=584;continue;}
case 584:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",587);}
case 587:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateAbilityText","(Lforge/game/card/Card;Lforge/game/card/CardState;)V","invokevirtual",590);}
case 590:{f.Push(f.Locals[0]);f.Pc=591;continue;}
case 591:{return rt.Call(f,"forge/game/card/CardView","getRightSplitState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",594);}
case 594:{f.Push(f.Locals[1]);f.Pc=595;continue;}
case 595:{f.Push(f.Locals[1]);f.Pc=596;continue;}
case 596:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=599;continue;}
case 599:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",602);}
case 602:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateAbilityText","(Lforge/game/card/Card;Lforge/game/card/CardState;)V","invokevirtual",605);}
case 605:{f.Push(f.Locals[1]);f.Pc=606;continue;}
case 606:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",609);}
case 609:{f.Locals[5]=f.Pop();f.Pc=611;continue;}
case 611:{f.Push(f.Locals[5]);f.Pc=613;continue;}
case 613:{return rt.Call(f,"forge/game/card/CardState","getView","()Lforge/game/card/CardView$CardStateView;","invokevirtual",616);}
case 616:{f.Locals[6]=f.Pop();f.Pc=618;continue;}
case 618:{f.Push(f.Locals[0]);f.Pc=619;continue;}
case 619:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",622);}
case 622:{f.Push(f.Locals[6]);f.Pc=624;continue;}
case 624:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?634:627;continue;}
case 627:{f.Push(f.Locals[1]);f.Pc=628;continue;}
case 628:{return rt.Call(f,"forge/game/card/Card","hasPerpetual","()Z","invokevirtual",631);}
case 631:{f.Pc=f.Pop().Int==0?716:634;continue;}
case 634:{f.Push(f.Locals[0]);f.Pc=635;continue;}
case 635:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CurrentState","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CurrentState","Lforge/trackable/TrackableProperty;"));f.Pc=638;continue;}
case 638:{f.Push(f.Locals[6]);f.Pc=640;continue;}
case 640:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",643);}
case 643:{f.Push(f.Locals[6]);f.Pc=645;continue;}
case 645:{f.Push(f.Locals[5]);f.Pc=647;continue;}
case 647:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateName","(Lforge/game/card/CardState;)V","invokevirtual",650);}
case 650:{f.Push(f.Locals[6]);f.Pc=652;continue;}
case 652:{f.Push(f.Locals[1]);f.Pc=653;continue;}
case 653:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updatePower","(Lforge/game/card/Card;)V","invokevirtual",656);}
case 656:{f.Push(f.Locals[6]);f.Pc=658;continue;}
case 658:{f.Push(f.Locals[1]);f.Pc=659;continue;}
case 659:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateToughness","(Lforge/game/card/Card;)V","invokevirtual",662);}
case 662:{f.Push(f.Locals[6]);f.Pc=664;continue;}
case 664:{f.Push(f.Locals[1]);f.Pc=665;continue;}
case 665:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateLoyalty","(Lforge/game/card/Card;)V","invokevirtual",668);}
case 668:{f.Push(f.Locals[6]);f.Pc=670;continue;}
case 670:{f.Push(f.Locals[1]);f.Pc=671;continue;}
case 671:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateDefense","(Lforge/game/card/Card;)V","invokevirtual",674);}
case 674:{f.Push(f.Locals[1]);f.Pc=675;continue;}
case 675:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",678);}
case 678:{f.Pc=f.Pop().Reference==null?730:681;continue;}
case 681:{f.Push(f.Locals[1]);f.Pc=682;continue;}
case 682:{return rt.Call(f,"forge/game/card/Card","hasPerpetual","()Z","invokevirtual",685);}
case 685:{f.Pc=f.Pop().Int==0?697:688;continue;}
case 688:{f.Push(f.Locals[6]);f.Pc=690;continue;}
case 690:{f.Push(f.Locals[1]);f.Pc=691;continue;}
case 691:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateColors","(Lforge/game/card/Card;)V","invokevirtual",694);}
case 694:{f.Pc=704;continue;}
case 697:{f.Push(f.Locals[6]);f.Pc=699;continue;}
case 699:{f.Push(f.Locals[5]);f.Pc=701;continue;}
case 701:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateColors","(Lforge/game/card/CardState;)V","invokevirtual",704);}
case 704:{f.Push(f.Locals[6]);f.Pc=706;continue;}
case 706:{f.Push(f.Locals[1]);f.Pc=707;continue;}
case 707:{return rt.Call(f,"forge/game/card/Card","hasChangedCardColors","()Z","invokevirtual",710);}
case 710:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateHasChangeColors","(Z)V","invokevirtual",713);}
case 713:{f.Pc=730;continue;}
case 716:{f.Push(f.Locals[6]);f.Pc=718;continue;}
case 718:{f.Push(f.Locals[5]);f.Pc=720;continue;}
case 720:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateLoyalty","(Lforge/game/card/CardState;)V","invokevirtual",723);}
case 723:{f.Push(f.Locals[6]);f.Pc=725;continue;}
case 725:{f.Push(f.Locals[5]);f.Pc=727;continue;}
case 727:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateDefense","(Lforge/game/card/CardState;)V","invokevirtual",730);}
case 730:{f.Push(f.Locals[5]);f.Pc=732;continue;}
case 732:{return rt.Call(f,"forge/game/card/CardState","getView","()Lforge/game/card/CardView$CardStateView;","invokevirtual",735);}
case 735:{f.Push(f.Locals[1]);f.Pc=736;continue;}
case 736:{f.Push(f.Locals[5]);f.Pc=738;continue;}
case 738:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateKeywords","(Lforge/game/card/Card;Lforge/game/card/CardState;)V","invokevirtual",741);}
case 741:{f.Push(f.Locals[5]);f.Pc=743;continue;}
case 743:{return rt.Call(f,"forge/game/card/CardState","getView","()Lforge/game/card/CardView$CardStateView;","invokevirtual",746);}
case 746:{f.Push(f.Locals[1]);f.Pc=747;continue;}
case 747:{return rt.Call(f,"forge/game/card/CardView$CardStateView","setOriginalColors","(Lforge/game/card/Card;)V","invokevirtual",750);}
case 750:{f.Push(f.Locals[6]);f.Pc=752;continue;}
case 752:{f.Push(f.Locals[5]);f.Pc=754;continue;}
case 754:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateAttractionLights","(Lforge/game/card/CardState;)V","invokevirtual",757);}
case 757:{f.Push(f.Locals[6]);f.Pc=759;continue;}
case 759:{f.Push(f.Locals[6]);f.Pc=761;continue;}
case 761:{return rt.Call(f,"forge/game/card/CardView$CardStateView","isVehicle","()Z","invokevirtual",764);}
case 764:{f.Pc=f.Pop().Int!=0?775:767;continue;}
case 767:{f.Push(f.Locals[6]);f.Pc=769;continue;}
case 769:{return rt.Call(f,"forge/game/card/CardView$CardStateView","isSpaceCraft","()Z","invokevirtual",772);}
case 772:{f.Pc=f.Pop().Int==0?787:775;continue;}
case 775:{f.Push(f.Locals[5]);f.Pc=777;continue;}
case 777:{return rt.Call(f,"forge/game/card/CardState","hasPrintedPT","()Z","invokevirtual",780);}
case 780:{f.Pc=f.Pop().Int==0?787:783;continue;}
case 783:{f.Push(JValue.I(1));f.Pc=784;continue;}
case 784:{f.Pc=788;continue;}
case 787:{f.Push(JValue.I(0));f.Pc=788;continue;}
case 788:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateHasPrintedPT","(Z)V","invokevirtual",791);}
case 791:{f.Push(f.Locals[2]);f.Pc=792;continue;}
case 792:{f.Pc=f.Pop().Int==0?812:795;continue;}
case 795:{f.Push(f.Locals[0]);f.Pc=796;continue;}
case 796:{return rt.Call(f,"forge/game/card/CardView","isFaceDown","()Z","invokevirtual",799);}
case 799:{f.Pc=f.Pop().Int==0?812:802;continue;}
case 802:{f.Push(f.Locals[1]);f.Pc=803;continue;}
case 803:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=806;continue;}
case 806:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",809);}
case 809:{f.Pc=816;continue;}
case 812:{f.Push(f.Locals[1]);f.Pc=813;continue;}
case 813:{return rt.Call(f,"forge/game/card/Card","getAlternateState","()Lforge/game/card/CardState;","invokevirtual",816);}
case 816:{f.Locals[7]=f.Pop();f.Pc=818;continue;}
case 818:{f.Push(f.Locals[2]);f.Pc=819;continue;}
case 819:{f.Pc=f.Pop().Int!=0?829:822;continue;}
case 822:{f.Push(f.Locals[1]);f.Pc=823;continue;}
case 823:{return rt.Call(f,"forge/game/card/Card","isDoubleFaced","()Z","invokevirtual",826);}
case 826:{f.Pc=f.Pop().Int==0?845:829;continue;}
case 829:{f.Push(f.Locals[0]);f.Pc=830;continue;}
case 830:{return rt.Call(f,"forge/game/card/CardView","isFaceDown","()Z","invokevirtual",833);}
case 833:{f.Pc=f.Pop().Int==0?845:836;continue;}
case 836:{f.Push(f.Locals[1]);f.Pc=837;continue;}
case 837:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=840;continue;}
case 840:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",843);}
case 843:{f.Locals[7]=f.Pop();f.Pc=845;continue;}
case 845:{f.Push(f.Locals[7]);f.Pc=847;continue;}
case 847:{f.Pc=f.Pop().Reference!=null?869:850;continue;}
case 850:{f.Push(f.Locals[1]);f.Pc=851;continue;}
case 851:{if(!rt.StaticReady(f,"forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"));f.Pc=854;continue;}
case 854:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",857);}
case 857:{f.Pc=f.Pop().Int==0?869:860;continue;}
case 860:{f.Push(f.Locals[1]);f.Pc=861;continue;}
case 861:{if(!rt.StaticReady(f,"forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"));f.Pc=864;continue;}
case 864:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",867);}
case 867:{f.Locals[7]=f.Pop();f.Pc=869;continue;}
case 869:{f.Push(f.Locals[7]);f.Pc=871;continue;}
case 871:{f.Pc=f.Pop().Reference!=null?885:874;continue;}
case 874:{f.Push(f.Locals[0]);f.Pc=875;continue;}
case 875:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AlternateState","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AlternateState","Lforge/trackable/TrackableProperty;"));f.Pc=878;continue;}
case 878:{f.Push(JValue.R(null));f.Pc=879;continue;}
case 879:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",882);}
case 882:{f.Pc=983;continue;}
case 885:{f.Push(f.Locals[7]);f.Pc=887;continue;}
case 887:{return rt.Call(f,"forge/game/card/CardState","getView","()Lforge/game/card/CardView$CardStateView;","invokevirtual",890);}
case 890:{f.Locals[8]=f.Pop();f.Pc=892;continue;}
case 892:{f.Push(f.Locals[0]);f.Pc=893;continue;}
case 893:{return rt.Call(f,"forge/game/card/CardView","getAlternateState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",896);}
case 896:{f.Push(f.Locals[8]);f.Pc=898;continue;}
case 898:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?958:901;continue;}
case 901:{f.Push(f.Locals[0]);f.Pc=902;continue;}
case 902:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AlternateState","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AlternateState","Lforge/trackable/TrackableProperty;"));f.Pc=905;continue;}
case 905:{f.Push(f.Locals[8]);f.Pc=907;continue;}
case 907:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",910);}
case 910:{f.Push(f.Locals[8]);f.Pc=912;continue;}
case 912:{f.Push(f.Locals[7]);f.Pc=914;continue;}
case 914:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateName","(Lforge/game/card/CardState;)V","invokevirtual",917);}
case 917:{f.Push(f.Locals[8]);f.Pc=919;continue;}
case 919:{f.Push(f.Locals[1]);f.Pc=920;continue;}
case 920:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updatePower","(Lforge/game/card/Card;)V","invokevirtual",923);}
case 923:{f.Push(f.Locals[8]);f.Pc=925;continue;}
case 925:{f.Push(f.Locals[1]);f.Pc=926;continue;}
case 926:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateToughness","(Lforge/game/card/Card;)V","invokevirtual",929);}
case 929:{f.Push(f.Locals[8]);f.Pc=931;continue;}
case 931:{f.Push(f.Locals[1]);f.Pc=932;continue;}
case 932:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateLoyalty","(Lforge/game/card/Card;)V","invokevirtual",935);}
case 935:{f.Push(f.Locals[8]);f.Pc=937;continue;}
case 937:{f.Push(f.Locals[1]);f.Pc=938;continue;}
case 938:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateDefense","(Lforge/game/card/Card;)V","invokevirtual",941);}
case 941:{f.Push(f.Locals[1]);f.Pc=942;continue;}
case 942:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",945);}
case 945:{f.Pc=f.Pop().Reference==null?972:948;continue;}
case 948:{f.Push(f.Locals[8]);f.Pc=950;continue;}
case 950:{f.Push(f.Locals[7]);f.Pc=952;continue;}
case 952:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateColors","(Lforge/game/card/CardState;)V","invokevirtual",955);}
case 955:{f.Pc=972;continue;}
case 958:{f.Push(f.Locals[8]);f.Pc=960;continue;}
case 960:{f.Push(f.Locals[7]);f.Pc=962;continue;}
case 962:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateLoyalty","(Lforge/game/card/CardState;)V","invokevirtual",965);}
case 965:{f.Push(f.Locals[8]);f.Pc=967;continue;}
case 967:{f.Push(f.Locals[7]);f.Pc=969;continue;}
case 969:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateDefense","(Lforge/game/card/CardState;)V","invokevirtual",972);}
case 972:{f.Push(f.Locals[7]);f.Pc=974;continue;}
case 974:{return rt.Call(f,"forge/game/card/CardState","getView","()Lforge/game/card/CardView$CardStateView;","invokevirtual",977);}
case 977:{f.Push(f.Locals[1]);f.Pc=978;continue;}
case 978:{f.Push(f.Locals[7]);f.Pc=980;continue;}
case 980:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateKeywords","(Lforge/game/card/Card;Lforge/game/card/CardState;)V","invokevirtual",983);}
case 983:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5626(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HiddenId","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HiddenId","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{f.Locals[1]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference!=null?20:15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardView","getId","()I","invokevirtual",19);}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",24);}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5627(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HiddenId","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HiddenId","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5628(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","BlockAdditional","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","BlockAdditional","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5629(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","BlockAny","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","BlockAny","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5630(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","BlockAdditional","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","BlockAdditional","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","canBlockAdditional","()I","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","BlockAny","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","BlockAny","Lforge/trackable/TrackableProperty;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/Card","canBlockAny","()Z","invokevirtual",22);}
case 22:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",25);}
case 25:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",28);}
case 28:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5631(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsRingBearer","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","IsRingBearer","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5632(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsRingBearer","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","IsRingBearer","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","isRingBearer","()Z","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5633(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CantHaveKeyword","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CantHaveKeyword","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5634(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Sets","newTreeSet","()Ljava/util/TreeSet;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getCantHaveKeyword","()Ljava/util/Collection;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?49:23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/Keyword"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{f.Locals[4]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/keyword/Keyword","toString","()Ljava/lang/String;","invokevirtual",40);}
case 40:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",45);}
case 45:{f.StackOp("pop");f.Pc=46;continue;}
case 46:{f.Pc=14;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CantHaveKeyword","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CantHaveKeyword","Lforge/trackable/TrackableProperty;"));f.Pc=53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",57);}
case 57:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5635(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardView","zoneText","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5636(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?190:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",11);}
case 11:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?190:20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/game/Game","getMaingame","()Lforge/game/Game;","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Reference==null?190:30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",34);}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/player/Player","getMappingMaingameCard","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",38);}
case 38:{f.Locals[2]=f.Pop();f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",46);}
case 46:{f.Locals[3]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(JValue.I(0));f.Pc=48;continue;}
case 48:{f.Locals[4]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Pc=f.Pop().Reference==null?182:54;continue;}
case 54:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",61);}
case 61:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",67);}
case 67:{f.Pc=f.Pop().Int!=0?170:70;continue;}
case 70:{f.Push(f.Locals[3]);f.Pc=71;continue;}
case 71:{f.Push(JValue.I(91));f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",76);}
case 76:{f.StackOp("pop");f.Pc=77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",81);}
case 81:{return rt.Call(f,"forge/game/Game","getMaingame","()Lforge/game/Game;","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Reference!=null?108:87;continue;}
case 87:{f.Push(f.Locals[3]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",91);}
case 91:{f.Push(JValue.R(rt.String("lblMainGame")));f.Pc=94;continue;}
case 94:{f.Push(JValue.I(0));f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",101);}
case 101:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",104);}
case 104:{f.StackOp("pop");f.Pc=105;continue;}
case 105:{f.Pc=134;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",112);}
case 112:{f.Push(JValue.R(rt.String("lblSubgame")));f.Pc=115;continue;}
case 115:{f.Push(JValue.I(1));f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=119;continue;}
case 119:{f.StackOp("dup");f.Pc=120;continue;}
case 120:{f.Push(JValue.I(0));f.Pc=121;continue;}
case 121:{f.Push(f.Locals[4]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",126);}
case 126:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",130);}
case 130:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",133);}
case 133:{f.StackOp("pop");f.Pc=134;continue;}
case 134:{f.Push(f.Locals[3]);f.Pc=135;continue;}
case 135:{f.Push(JValue.R(rt.String(": ")));f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",141);}
case 141:{f.StackOp("pop");f.Pc=142;continue;}
case 142:{f.Push(f.Locals[3]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[2]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",147);}
case 147:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",150);}
case 150:{return rt.Call(f,"forge/game/zone/ZoneType","getTranslatedName","()Ljava/lang/String;","invokevirtual",153);}
case 153:{return rt.Call(f,"forge/util/TextUtil","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",156);}
case 156:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",159);}
case 159:{f.StackOp("pop");f.Pc=160;continue;}
case 160:{f.Push(f.Locals[3]);f.Pc=161;continue;}
case 161:{f.Push(JValue.I(93));f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",166);}
case 166:{f.StackOp("pop");f.Pc=167;continue;}
case 167:{f.Pc=182;continue;}
case 170:{f.Push(f.Locals[2]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",174);}
case 174:{f.Push(f.Locals[2]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/player/Player","getMappingMaingameCard","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",178);}
case 178:{f.Locals[2]=f.Pop();f.Pc=179;continue;}
case 179:{f.Pc=50;continue;}
case 182:{f.Push(f.Locals[0]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[3]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",187);}
case 187:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardView","zoneText","Ljava/lang/String;",value);f.Pc=190;continue;}
case 190:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5637(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardView","getZoneText","()Ljava/lang/String;","invokevirtual",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardView","getId","()I","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int>0?19:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return JStep.Return(f.Pop());}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int==0?69:26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/CardView","getAlternateState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",30);}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{f.Pc=f.Pop().Reference==null?69:35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/CardView","isFaceDown","()Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int==0?52:42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/CardView","getHiddenId","()I","invokevirtual",46);}
case 46:{return rt.DynamicCall(f,"forge/game/card/CardView:5637:46:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",51);}
case 51:{return JStep.Return(f.Pop());}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/card/CardView","getAlternateState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",56);}
case 56:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getName","()Ljava/lang/String;","invokevirtual",59);}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/card/CardView","getId","()I","invokevirtual",63);}
case 63:{return rt.DynamicCall(f,"forge/game/card/CardView:5637:63:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;I)Ljava/lang/String;",68);}
case 68:{return JStep.Return(f.Pop());}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedName","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",74);}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/card/CardView","getId","()I","invokevirtual",78);}
case 78:{return rt.DynamicCall(f,"forge/game/card/CardView:5637:78:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;",83);}
case 83:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",86);}
case 86:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5638(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MergedCardsCollection","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MergedCardsCollection","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/trackable/TrackableCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Reference!=null?36:17;continue;}
case 17:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableCollection")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/trackable/TrackableCollection","<init>","()V","invokespecial",24);}
case 24:{f.Locals[2]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MergedCardsCollection","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MergedCardsCollection","Lforge/trackable/TrackableProperty;"));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/CardView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",33);}
case 33:{f.Pc=49;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/trackable/TrackableCollection","isEmpty","()Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int!=0?45:43;continue;}
case 43:{f.Push(JValue.I(1));f.Pc=44;continue;}
case 44:{f.Locals[3]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/trackable/TrackableCollection","clear","()V","invokevirtual",49);}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Pc=f.Pop().Reference==null?98:53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",57);}
case 57:{f.Locals[4]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",66);}
case 66:{f.Pc=f.Pop().Int==0?98:69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",76);}
case 76:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=79;continue;}
case 79:{f.Locals[5]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[5]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/card/Card","getView","()Lforge/game/card/CardView;","invokevirtual",87);}
case 87:{return rt.Call(f,"forge/trackable/TrackableCollection","add","(Ljava/lang/Object;)Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?95:93;continue;}
case 93:{f.Push(JValue.I(1));f.Pc=94;continue;}
case 94:{f.Locals[3]=f.Pop();f.Pc=95;continue;}
case 95:{f.Pc=59;continue;}
case 98:{f.Push(f.Locals[3]);f.Pc=99;continue;}
case 99:{f.Pc=f.Pop().Int==0?109:102;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MergedCardsCollection","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MergedCardsCollection","Lforge/trackable/TrackableProperty;"));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/card/CardView","flagAsChanged","(Lforge/trackable/TrackableProperty;)V","invokevirtual",109);}
case 109:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

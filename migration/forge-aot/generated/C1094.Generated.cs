// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1094{
internal static JClass Build(){var c=new JClass("forge/trackable/TrackableProperty","java/lang/Enum",new string[]{},16433);Add0(c);Add1(c);Add2(c);Add3(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("PreventNextDamage","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("AttachedCards","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Counters","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("CurrentPlane","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("PlanarPlayer","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Owner","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Controller","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Zone","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("GamePieceType","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("IsEmblem","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("IsBoon","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("CanSpecialize","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Flipped","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Facedown","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Foretold","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Modal","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Secondary","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("DoubleFaced","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("FacedownImageKey","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("PaperFoil","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Cloner","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Cloned","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("FlipCard","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("SplitCard","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("MergedCards","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("MergedCardsCollection","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("PaperCardBackup","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Attacking","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Blocking","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("PhasedOut","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Sickness","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Tapped","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Token","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("TokenCard","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("IsCommander","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("IsRingBearer","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("CommanderAltType","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Damage","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("AssignedDamage","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("LethalDamage","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ShieldCount","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ChosenType","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ChosenType2","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("NotedTypes","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ChosenColors","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ChosenCards","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ChosenNumber","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("StoredRolls","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ChosenPlayer","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("PromisedGift","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ProtectingPlayer","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ChosenDirection","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ChosenEvenOdd","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ChosenMode","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Sector","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Sprocket","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("DraftAction","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ClassLevel","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("RingLevel","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("CurrentRoom","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Intensity","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("OverlayText","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("MarkerText","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Remembered","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
}

private static void Add1(JClass c){
c.Add(new JField("NamedCard","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("PlayerMayLook","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("EntityAttachedTo","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("EncodedCards","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("UntilLeavesBattlefield","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("GainControlTargets","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("CloneOrigin","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ExiledWith","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("PreparedSpell","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("MarkedColors","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ImprintedCards","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ExiledCards","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("HauntedBy","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Haunting","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("MustBlockCards","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("PairedWith","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("CurrentState","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("AlternateState","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("LeftSplitState","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("RightSplitState","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Room","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("HiddenId","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ExertedThisTurn","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Detained","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Name","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("OracleName","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ImageKey","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Colors","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("OriginalColors","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Type","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ManaCost","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("OriginalManaCost","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("SetCode","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Rarity","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("OracleText","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("RulesText","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("HasPrintedPT","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Power","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Toughness","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Loyalty","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Defense","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("FunctionalVariant","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("AttractionLights","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ChangedColorWords","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("HasChangedColors","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ChangedTypes","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("OrigProduceMana","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("OrigProduceAnyMana","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Keywords","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("HasAnnihilator","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("HasWard","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("BlockAdditional","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("BlockAny","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("AbilityText","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("NonAbilityText","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("HasDivideDamage","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("FoilIndex","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("CantHaveKeyword","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("IsAI","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("LobbyPlayerName","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("AvatarIndex","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("AvatarCardImageKey","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("SleeveIndex","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("SleeveArtKey","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
}

private static void Add2(JClass c){
c.Add(new JField("SleeveArtOffset","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Opponents","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("SharedTeam","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Life","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("MaxHandSize","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("HasUnlimitedHandSize","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("MaxLandPlay","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("HasUnlimitedLandPlay","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("NumLandThisTurn","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("DraftNotes","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("NumDrawnThisTurn","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("AdditionalVote","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("OptionalAdditionalVote","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ControlVotes","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("AdditionalVillainousChoices","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Commander","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("CommanderCast","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("CommanderDamage","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("MindSlaveMaster","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Ante","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Battlefield","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Command","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Exile","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Flashback","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Graveyard","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Hand","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Library","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Sideboard","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("PlanarDeck","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("SchemeDeck","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("AttractionDeck","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ContraptionDeck","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Junkyard","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("StickerSheets","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Stickers","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Mana","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("IsExtraTurn","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ExtraTurnCount","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("HasPriority","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("HasLost","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("HasAvailableActions","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("NumManaShards","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("HostCard","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Description","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("CanPlay","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("PromptIfOnlyPossibleAbility","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("SA_IsSpell","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Key","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("SourceTrigger","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("SourceCard","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("ActivatingPlayer","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("TargetCards","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("TargetPlayers","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("TargetStackItems","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("SubInstance","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Ability","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("OptionalTrigger","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("OptionalCosts","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("CombatView","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("AttackersWithDefenders","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("AttackersWithBlockers","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("AttackersWithPlannedBlockers","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("BandsWithDefenders","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("BandsWithBlockers","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
}

private static void Add3(JClass c){
c.Add(new JField("BandsWithPlannedBlockers","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Players","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("GameType","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Title","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Turn","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("PlayerTurn","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Phase","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("WinningPlayerName","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("WinningTeam","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Mulligan","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("GameOver","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("MatchOver","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("NumGamesInMatch","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("NumPlayedGamesInMatch","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Stack","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("StormCount","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("PoisonCountersToLose","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Object","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("Dependencies","Lforge/trackable/TrackableProperty;",true,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("type","Lforge/trackable/TrackableTypes$TrackableType;",false,JValue.Default("Lforge/trackable/TrackableTypes$TrackableType;"),null));
c.Add(new JField("freezeMode","Lforge/trackable/TrackableProperty$FreezeMode;",false,JValue.Default("Lforge/trackable/TrackableProperty$FreezeMode;"),null));
c.Add(new JField("$VALUES","[Lforge/trackable/TrackableProperty;",true,JValue.Default("[Lforge/trackable/TrackableProperty;"),null));
c.Add(new JMethod(11563,"forge/trackable/TrackableProperty","values","()[Lforge/trackable/TrackableProperty;",9,0,1,new JHandler[]{},M11563));
c.Add(new JMethod(11564,"forge/trackable/TrackableProperty","valueOf","(Ljava/lang/String;)Lforge/trackable/TrackableProperty;",9,1,2,new JHandler[]{},M11564));
c.Add(new JMethod(11565,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V",2,4,5,new JHandler[]{},M11565));
c.Add(new JMethod(11566,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V",2,5,3,new JHandler[]{},M11566));
c.Add(new JMethod(11567,"forge/trackable/TrackableProperty","getFreezeMode","()Lforge/trackable/TrackableProperty$FreezeMode;",1,1,1,new JHandler[]{},M11567));
c.Add(new JMethod(11568,"forge/trackable/TrackableProperty","getType","()Lforge/trackable/TrackableTypes$TrackableType;",1,1,1,new JHandler[]{},M11568));
c.Add(new JMethod(11569,"forge/trackable/TrackableProperty","updateObjLookup","(Lforge/trackable/Tracker;Ljava/lang/Object;)V",1,3,3,new JHandler[]{},M11569));
c.Add(new JMethod(11570,"forge/trackable/TrackableProperty","getDefaultValue","()Ljava/lang/Object;",1,1,1,new JHandler[]{},M11570));
c.Add(new JMethod(11571,"forge/trackable/TrackableProperty","$values","()[Lforge/trackable/TrackableProperty;",4106,0,4,new JHandler[]{},M11571));
c.Add(new JMethod(11572,"forge/trackable/TrackableProperty","<clinit>","()V",8,0,6,new JHandler[]{},M11572));
}

internal static JStep M11563(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","$VALUES","[Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","$VALUES","[Lforge/trackable/TrackableProperty;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/trackable/TrackableProperty;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/trackable/TrackableProperty;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11564(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/trackable/TrackableProperty")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/trackable/TrackableProperty"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11565(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","RespectsFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","RespectsFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",10);}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11566(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/trackable/TrackableProperty","type","Lforge/trackable/TrackableTypes$TrackableType;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/trackable/TrackableProperty","freezeMode","Lforge/trackable/TrackableProperty$FreezeMode;",value);f.Pc=17;continue;}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11567(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableProperty","freezeMode","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11568(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableProperty","type","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11569(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableProperty","type","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","updateObjLookup","(Lforge/trackable/Tracker;Ljava/lang/Object;)V","invokevirtual",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11570(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableProperty","type","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","getDefaultValue","()Ljava/lang/Object;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11571(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(211));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.NewArray("Lforge/trackable/TrackableProperty;",f.Pop().Int)));f.Pc=6;continue;}
case 6:{f.StackOp("dup");f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PreventNextDamage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PreventNextDamage","Lforge/trackable/TrackableProperty;"));f.Pc=11;continue;}
case 11:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttachedCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttachedCards","Lforge/trackable/TrackableProperty;"));f.Pc=17;continue;}
case 17:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(JValue.I(2));f.Pc=20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Counters","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Counters","Lforge/trackable/TrackableProperty;"));f.Pc=23;continue;}
case 23:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=24;continue;}
case 24:{f.StackOp("dup");f.Pc=25;continue;}
case 25:{f.Push(JValue.I(3));f.Pc=26;continue;}
case 26:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CurrentPlane","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CurrentPlane","Lforge/trackable/TrackableProperty;"));f.Pc=29;continue;}
case 29:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{f.Push(JValue.I(4));f.Pc=32;continue;}
case 32:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PlanarPlayer","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PlanarPlayer","Lforge/trackable/TrackableProperty;"));f.Pc=35;continue;}
case 35:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(JValue.I(5));f.Pc=38;continue;}
case 38:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Owner","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Owner","Lforge/trackable/TrackableProperty;"));f.Pc=41;continue;}
case 41:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.I(6));f.Pc=45;continue;}
case 45:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Controller","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Controller","Lforge/trackable/TrackableProperty;"));f.Pc=48;continue;}
case 48:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=49;continue;}
case 49:{f.StackOp("dup");f.Pc=50;continue;}
case 50:{f.Push(JValue.I(7));f.Pc=52;continue;}
case 52:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Zone","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Zone","Lforge/trackable/TrackableProperty;"));f.Pc=55;continue;}
case 55:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=56;continue;}
case 56:{f.StackOp("dup");f.Pc=57;continue;}
case 57:{f.Push(JValue.I(8));f.Pc=59;continue;}
case 59:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","GamePieceType","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","GamePieceType","Lforge/trackable/TrackableProperty;"));f.Pc=62;continue;}
case 62:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=63;continue;}
case 63:{f.StackOp("dup");f.Pc=64;continue;}
case 64:{f.Push(JValue.I(9));f.Pc=66;continue;}
case 66:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsEmblem","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","IsEmblem","Lforge/trackable/TrackableProperty;"));f.Pc=69;continue;}
case 69:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=70;continue;}
case 70:{f.StackOp("dup");f.Pc=71;continue;}
case 71:{f.Push(JValue.I(10));f.Pc=73;continue;}
case 73:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsBoon","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","IsBoon","Lforge/trackable/TrackableProperty;"));f.Pc=76;continue;}
case 76:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=77;continue;}
case 77:{f.StackOp("dup");f.Pc=78;continue;}
case 78:{f.Push(JValue.I(11));f.Pc=80;continue;}
case 80:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CanSpecialize","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CanSpecialize","Lforge/trackable/TrackableProperty;"));f.Pc=83;continue;}
case 83:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=84;continue;}
case 84:{f.StackOp("dup");f.Pc=85;continue;}
case 85:{f.Push(JValue.I(12));f.Pc=87;continue;}
case 87:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Flipped","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Flipped","Lforge/trackable/TrackableProperty;"));f.Pc=90;continue;}
case 90:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=91;continue;}
case 91:{f.StackOp("dup");f.Pc=92;continue;}
case 92:{f.Push(JValue.I(13));f.Pc=94;continue;}
case 94:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Facedown","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Facedown","Lforge/trackable/TrackableProperty;"));f.Pc=97;continue;}
case 97:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=98;continue;}
case 98:{f.StackOp("dup");f.Pc=99;continue;}
case 99:{f.Push(JValue.I(14));f.Pc=101;continue;}
case 101:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Foretold","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Foretold","Lforge/trackable/TrackableProperty;"));f.Pc=104;continue;}
case 104:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=105;continue;}
case 105:{f.StackOp("dup");f.Pc=106;continue;}
case 106:{f.Push(JValue.I(15));f.Pc=108;continue;}
case 108:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Modal","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Modal","Lforge/trackable/TrackableProperty;"));f.Pc=111;continue;}
case 111:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=112;continue;}
case 112:{f.StackOp("dup");f.Pc=113;continue;}
case 113:{f.Push(JValue.I(16));f.Pc=115;continue;}
case 115:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Secondary","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Secondary","Lforge/trackable/TrackableProperty;"));f.Pc=118;continue;}
case 118:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=119;continue;}
case 119:{f.StackOp("dup");f.Pc=120;continue;}
case 120:{f.Push(JValue.I(17));f.Pc=122;continue;}
case 122:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","DoubleFaced","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","DoubleFaced","Lforge/trackable/TrackableProperty;"));f.Pc=125;continue;}
case 125:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=126;continue;}
case 126:{f.StackOp("dup");f.Pc=127;continue;}
case 127:{f.Push(JValue.I(18));f.Pc=129;continue;}
case 129:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","FacedownImageKey","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","FacedownImageKey","Lforge/trackable/TrackableProperty;"));f.Pc=132;continue;}
case 132:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=133;continue;}
case 133:{f.StackOp("dup");f.Pc=134;continue;}
case 134:{f.Push(JValue.I(19));f.Pc=136;continue;}
case 136:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PaperFoil","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PaperFoil","Lforge/trackable/TrackableProperty;"));f.Pc=139;continue;}
case 139:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=140;continue;}
case 140:{f.StackOp("dup");f.Pc=141;continue;}
case 141:{f.Push(JValue.I(20));f.Pc=143;continue;}
case 143:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Cloner","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Cloner","Lforge/trackable/TrackableProperty;"));f.Pc=146;continue;}
case 146:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=147;continue;}
case 147:{f.StackOp("dup");f.Pc=148;continue;}
case 148:{f.Push(JValue.I(21));f.Pc=150;continue;}
case 150:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Cloned","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Cloned","Lforge/trackable/TrackableProperty;"));f.Pc=153;continue;}
case 153:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=154;continue;}
case 154:{f.StackOp("dup");f.Pc=155;continue;}
case 155:{f.Push(JValue.I(22));f.Pc=157;continue;}
case 157:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","FlipCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","FlipCard","Lforge/trackable/TrackableProperty;"));f.Pc=160;continue;}
case 160:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=161;continue;}
case 161:{f.StackOp("dup");f.Pc=162;continue;}
case 162:{f.Push(JValue.I(23));f.Pc=164;continue;}
case 164:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SplitCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SplitCard","Lforge/trackable/TrackableProperty;"));f.Pc=167;continue;}
case 167:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=168;continue;}
case 168:{f.StackOp("dup");f.Pc=169;continue;}
case 169:{f.Push(JValue.I(24));f.Pc=171;continue;}
case 171:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MergedCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MergedCards","Lforge/trackable/TrackableProperty;"));f.Pc=174;continue;}
case 174:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=175;continue;}
case 175:{f.StackOp("dup");f.Pc=176;continue;}
case 176:{f.Push(JValue.I(25));f.Pc=178;continue;}
case 178:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MergedCardsCollection","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MergedCardsCollection","Lforge/trackable/TrackableProperty;"));f.Pc=181;continue;}
case 181:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=182;continue;}
case 182:{f.StackOp("dup");f.Pc=183;continue;}
case 183:{f.Push(JValue.I(26));f.Pc=185;continue;}
case 185:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PaperCardBackup","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PaperCardBackup","Lforge/trackable/TrackableProperty;"));f.Pc=188;continue;}
case 188:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=189;continue;}
case 189:{f.StackOp("dup");f.Pc=190;continue;}
case 190:{f.Push(JValue.I(27));f.Pc=192;continue;}
case 192:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Attacking","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Attacking","Lforge/trackable/TrackableProperty;"));f.Pc=195;continue;}
case 195:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=196;continue;}
case 196:{f.StackOp("dup");f.Pc=197;continue;}
case 197:{f.Push(JValue.I(28));f.Pc=199;continue;}
case 199:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Blocking","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Blocking","Lforge/trackable/TrackableProperty;"));f.Pc=202;continue;}
case 202:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=203;continue;}
case 203:{f.StackOp("dup");f.Pc=204;continue;}
case 204:{f.Push(JValue.I(29));f.Pc=206;continue;}
case 206:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PhasedOut","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PhasedOut","Lforge/trackable/TrackableProperty;"));f.Pc=209;continue;}
case 209:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=210;continue;}
case 210:{f.StackOp("dup");f.Pc=211;continue;}
case 211:{f.Push(JValue.I(30));f.Pc=213;continue;}
case 213:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Sickness","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Sickness","Lforge/trackable/TrackableProperty;"));f.Pc=216;continue;}
case 216:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=217;continue;}
case 217:{f.StackOp("dup");f.Pc=218;continue;}
case 218:{f.Push(JValue.I(31));f.Pc=220;continue;}
case 220:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Tapped","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Tapped","Lforge/trackable/TrackableProperty;"));f.Pc=223;continue;}
case 223:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=224;continue;}
case 224:{f.StackOp("dup");f.Pc=225;continue;}
case 225:{f.Push(JValue.I(32));f.Pc=227;continue;}
case 227:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Token","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Token","Lforge/trackable/TrackableProperty;"));f.Pc=230;continue;}
case 230:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=231;continue;}
case 231:{f.StackOp("dup");f.Pc=232;continue;}
case 232:{f.Push(JValue.I(33));f.Pc=234;continue;}
case 234:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","TokenCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","TokenCard","Lforge/trackable/TrackableProperty;"));f.Pc=237;continue;}
case 237:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=238;continue;}
case 238:{f.StackOp("dup");f.Pc=239;continue;}
case 239:{f.Push(JValue.I(34));f.Pc=241;continue;}
case 241:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsCommander","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","IsCommander","Lforge/trackable/TrackableProperty;"));f.Pc=244;continue;}
case 244:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=245;continue;}
case 245:{f.StackOp("dup");f.Pc=246;continue;}
case 246:{f.Push(JValue.I(35));f.Pc=248;continue;}
case 248:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsRingBearer","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","IsRingBearer","Lforge/trackable/TrackableProperty;"));f.Pc=251;continue;}
case 251:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=252;continue;}
case 252:{f.StackOp("dup");f.Pc=253;continue;}
case 253:{f.Push(JValue.I(36));f.Pc=255;continue;}
case 255:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CommanderAltType","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CommanderAltType","Lforge/trackable/TrackableProperty;"));f.Pc=258;continue;}
case 258:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=259;continue;}
case 259:{f.StackOp("dup");f.Pc=260;continue;}
case 260:{f.Push(JValue.I(37));f.Pc=262;continue;}
case 262:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Damage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Damage","Lforge/trackable/TrackableProperty;"));f.Pc=265;continue;}
case 265:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=266;continue;}
case 266:{f.StackOp("dup");f.Pc=267;continue;}
case 267:{f.Push(JValue.I(38));f.Pc=269;continue;}
case 269:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AssignedDamage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AssignedDamage","Lforge/trackable/TrackableProperty;"));f.Pc=272;continue;}
case 272:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=273;continue;}
case 273:{f.StackOp("dup");f.Pc=274;continue;}
case 274:{f.Push(JValue.I(39));f.Pc=276;continue;}
case 276:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","LethalDamage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","LethalDamage","Lforge/trackable/TrackableProperty;"));f.Pc=279;continue;}
case 279:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=280;continue;}
case 280:{f.StackOp("dup");f.Pc=281;continue;}
case 281:{f.Push(JValue.I(40));f.Pc=283;continue;}
case 283:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ShieldCount","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ShieldCount","Lforge/trackable/TrackableProperty;"));f.Pc=286;continue;}
case 286:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=287;continue;}
case 287:{f.StackOp("dup");f.Pc=288;continue;}
case 288:{f.Push(JValue.I(41));f.Pc=290;continue;}
case 290:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenType","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenType","Lforge/trackable/TrackableProperty;"));f.Pc=293;continue;}
case 293:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=294;continue;}
case 294:{f.StackOp("dup");f.Pc=295;continue;}
case 295:{f.Push(JValue.I(42));f.Pc=297;continue;}
case 297:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenType2","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenType2","Lforge/trackable/TrackableProperty;"));f.Pc=300;continue;}
case 300:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=301;continue;}
case 301:{f.StackOp("dup");f.Pc=302;continue;}
case 302:{f.Push(JValue.I(43));f.Pc=304;continue;}
case 304:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NotedTypes","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","NotedTypes","Lforge/trackable/TrackableProperty;"));f.Pc=307;continue;}
case 307:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=308;continue;}
case 308:{f.StackOp("dup");f.Pc=309;continue;}
case 309:{f.Push(JValue.I(44));f.Pc=311;continue;}
case 311:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenColors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenColors","Lforge/trackable/TrackableProperty;"));f.Pc=314;continue;}
case 314:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=315;continue;}
case 315:{f.StackOp("dup");f.Pc=316;continue;}
case 316:{f.Push(JValue.I(45));f.Pc=318;continue;}
case 318:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenCards","Lforge/trackable/TrackableProperty;"));f.Pc=321;continue;}
case 321:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=322;continue;}
case 322:{f.StackOp("dup");f.Pc=323;continue;}
case 323:{f.Push(JValue.I(46));f.Pc=325;continue;}
case 325:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenNumber","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenNumber","Lforge/trackable/TrackableProperty;"));f.Pc=328;continue;}
case 328:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=329;continue;}
case 329:{f.StackOp("dup");f.Pc=330;continue;}
case 330:{f.Push(JValue.I(47));f.Pc=332;continue;}
case 332:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","StoredRolls","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","StoredRolls","Lforge/trackable/TrackableProperty;"));f.Pc=335;continue;}
case 335:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=336;continue;}
case 336:{f.StackOp("dup");f.Pc=337;continue;}
case 337:{f.Push(JValue.I(48));f.Pc=339;continue;}
case 339:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenPlayer","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenPlayer","Lforge/trackable/TrackableProperty;"));f.Pc=342;continue;}
case 342:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=343;continue;}
case 343:{f.StackOp("dup");f.Pc=344;continue;}
case 344:{f.Push(JValue.I(49));f.Pc=346;continue;}
case 346:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PromisedGift","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PromisedGift","Lforge/trackable/TrackableProperty;"));f.Pc=349;continue;}
case 349:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=350;continue;}
case 350:{f.StackOp("dup");f.Pc=351;continue;}
case 351:{f.Push(JValue.I(50));f.Pc=353;continue;}
case 353:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ProtectingPlayer","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ProtectingPlayer","Lforge/trackable/TrackableProperty;"));f.Pc=356;continue;}
case 356:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=357;continue;}
case 357:{f.StackOp("dup");f.Pc=358;continue;}
case 358:{f.Push(JValue.I(51));f.Pc=360;continue;}
case 360:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenDirection","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenDirection","Lforge/trackable/TrackableProperty;"));f.Pc=363;continue;}
case 363:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=364;continue;}
case 364:{f.StackOp("dup");f.Pc=365;continue;}
case 365:{f.Push(JValue.I(52));f.Pc=367;continue;}
case 367:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenEvenOdd","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenEvenOdd","Lforge/trackable/TrackableProperty;"));f.Pc=370;continue;}
case 370:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=371;continue;}
case 371:{f.StackOp("dup");f.Pc=372;continue;}
case 372:{f.Push(JValue.I(53));f.Pc=374;continue;}
case 374:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenMode","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChosenMode","Lforge/trackable/TrackableProperty;"));f.Pc=377;continue;}
case 377:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=378;continue;}
case 378:{f.StackOp("dup");f.Pc=379;continue;}
case 379:{f.Push(JValue.I(54));f.Pc=381;continue;}
case 381:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Sector","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Sector","Lforge/trackable/TrackableProperty;"));f.Pc=384;continue;}
case 384:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=385;continue;}
case 385:{f.StackOp("dup");f.Pc=386;continue;}
case 386:{f.Push(JValue.I(55));f.Pc=388;continue;}
case 388:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Sprocket","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Sprocket","Lforge/trackable/TrackableProperty;"));f.Pc=391;continue;}
case 391:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=392;continue;}
case 392:{f.StackOp("dup");f.Pc=393;continue;}
case 393:{f.Push(JValue.I(56));f.Pc=395;continue;}
case 395:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","DraftAction","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","DraftAction","Lforge/trackable/TrackableProperty;"));f.Pc=398;continue;}
case 398:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=399;continue;}
case 399:{f.StackOp("dup");f.Pc=400;continue;}
case 400:{f.Push(JValue.I(57));f.Pc=402;continue;}
case 402:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ClassLevel","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ClassLevel","Lforge/trackable/TrackableProperty;"));f.Pc=405;continue;}
case 405:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=406;continue;}
case 406:{f.StackOp("dup");f.Pc=407;continue;}
case 407:{f.Push(JValue.I(58));f.Pc=409;continue;}
case 409:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","RingLevel","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","RingLevel","Lforge/trackable/TrackableProperty;"));f.Pc=412;continue;}
case 412:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=413;continue;}
case 413:{f.StackOp("dup");f.Pc=414;continue;}
case 414:{f.Push(JValue.I(59));f.Pc=416;continue;}
case 416:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CurrentRoom","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CurrentRoom","Lforge/trackable/TrackableProperty;"));f.Pc=419;continue;}
case 419:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=420;continue;}
case 420:{f.StackOp("dup");f.Pc=421;continue;}
case 421:{f.Push(JValue.I(60));f.Pc=423;continue;}
case 423:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Intensity","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Intensity","Lforge/trackable/TrackableProperty;"));f.Pc=426;continue;}
case 426:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=427;continue;}
case 427:{f.StackOp("dup");f.Pc=428;continue;}
case 428:{f.Push(JValue.I(61));f.Pc=430;continue;}
case 430:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OverlayText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OverlayText","Lforge/trackable/TrackableProperty;"));f.Pc=433;continue;}
case 433:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=434;continue;}
case 434:{f.StackOp("dup");f.Pc=435;continue;}
case 435:{f.Push(JValue.I(62));f.Pc=437;continue;}
case 437:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MarkerText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MarkerText","Lforge/trackable/TrackableProperty;"));f.Pc=440;continue;}
case 440:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=441;continue;}
case 441:{f.StackOp("dup");f.Pc=442;continue;}
case 442:{f.Push(JValue.I(63));f.Pc=444;continue;}
case 444:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Remembered","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Remembered","Lforge/trackable/TrackableProperty;"));f.Pc=447;continue;}
case 447:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=448;continue;}
case 448:{f.StackOp("dup");f.Pc=449;continue;}
case 449:{f.Push(JValue.I(64));f.Pc=451;continue;}
case 451:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NamedCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","NamedCard","Lforge/trackable/TrackableProperty;"));f.Pc=454;continue;}
case 454:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=455;continue;}
case 455:{f.StackOp("dup");f.Pc=456;continue;}
case 456:{f.Push(JValue.I(65));f.Pc=458;continue;}
case 458:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PlayerMayLook","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PlayerMayLook","Lforge/trackable/TrackableProperty;"));f.Pc=461;continue;}
case 461:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=462;continue;}
case 462:{f.StackOp("dup");f.Pc=463;continue;}
case 463:{f.Push(JValue.I(66));f.Pc=465;continue;}
case 465:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","EntityAttachedTo","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","EntityAttachedTo","Lforge/trackable/TrackableProperty;"));f.Pc=468;continue;}
case 468:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=469;continue;}
case 469:{f.StackOp("dup");f.Pc=470;continue;}
case 470:{f.Push(JValue.I(67));f.Pc=472;continue;}
case 472:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","EncodedCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","EncodedCards","Lforge/trackable/TrackableProperty;"));f.Pc=475;continue;}
case 475:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=476;continue;}
case 476:{f.StackOp("dup");f.Pc=477;continue;}
case 477:{f.Push(JValue.I(68));f.Pc=479;continue;}
case 479:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","UntilLeavesBattlefield","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","UntilLeavesBattlefield","Lforge/trackable/TrackableProperty;"));f.Pc=482;continue;}
case 482:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=483;continue;}
case 483:{f.StackOp("dup");f.Pc=484;continue;}
case 484:{f.Push(JValue.I(69));f.Pc=486;continue;}
case 486:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","GainControlTargets","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","GainControlTargets","Lforge/trackable/TrackableProperty;"));f.Pc=489;continue;}
case 489:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=490;continue;}
case 490:{f.StackOp("dup");f.Pc=491;continue;}
case 491:{f.Push(JValue.I(70));f.Pc=493;continue;}
case 493:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CloneOrigin","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CloneOrigin","Lforge/trackable/TrackableProperty;"));f.Pc=496;continue;}
case 496:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=497;continue;}
case 497:{f.StackOp("dup");f.Pc=498;continue;}
case 498:{f.Push(JValue.I(71));f.Pc=500;continue;}
case 500:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ExiledWith","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ExiledWith","Lforge/trackable/TrackableProperty;"));f.Pc=503;continue;}
case 503:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=504;continue;}
case 504:{f.StackOp("dup");f.Pc=505;continue;}
case 505:{f.Push(JValue.I(72));f.Pc=507;continue;}
case 507:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PreparedSpell","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PreparedSpell","Lforge/trackable/TrackableProperty;"));f.Pc=510;continue;}
case 510:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=511;continue;}
case 511:{f.StackOp("dup");f.Pc=512;continue;}
case 512:{f.Push(JValue.I(73));f.Pc=514;continue;}
case 514:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MarkedColors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MarkedColors","Lforge/trackable/TrackableProperty;"));f.Pc=517;continue;}
case 517:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=518;continue;}
case 518:{f.StackOp("dup");f.Pc=519;continue;}
case 519:{f.Push(JValue.I(74));f.Pc=521;continue;}
case 521:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ImprintedCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ImprintedCards","Lforge/trackable/TrackableProperty;"));f.Pc=524;continue;}
case 524:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=525;continue;}
case 525:{f.StackOp("dup");f.Pc=526;continue;}
case 526:{f.Push(JValue.I(75));f.Pc=528;continue;}
case 528:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ExiledCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ExiledCards","Lforge/trackable/TrackableProperty;"));f.Pc=531;continue;}
case 531:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=532;continue;}
case 532:{f.StackOp("dup");f.Pc=533;continue;}
case 533:{f.Push(JValue.I(76));f.Pc=535;continue;}
case 535:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HauntedBy","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HauntedBy","Lforge/trackable/TrackableProperty;"));f.Pc=538;continue;}
case 538:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=539;continue;}
case 539:{f.StackOp("dup");f.Pc=540;continue;}
case 540:{f.Push(JValue.I(77));f.Pc=542;continue;}
case 542:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Haunting","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Haunting","Lforge/trackable/TrackableProperty;"));f.Pc=545;continue;}
case 545:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=546;continue;}
case 546:{f.StackOp("dup");f.Pc=547;continue;}
case 547:{f.Push(JValue.I(78));f.Pc=549;continue;}
case 549:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MustBlockCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MustBlockCards","Lforge/trackable/TrackableProperty;"));f.Pc=552;continue;}
case 552:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=553;continue;}
case 553:{f.StackOp("dup");f.Pc=554;continue;}
case 554:{f.Push(JValue.I(79));f.Pc=556;continue;}
case 556:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PairedWith","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PairedWith","Lforge/trackable/TrackableProperty;"));f.Pc=559;continue;}
case 559:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=560;continue;}
case 560:{f.StackOp("dup");f.Pc=561;continue;}
case 561:{f.Push(JValue.I(80));f.Pc=563;continue;}
case 563:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CurrentState","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CurrentState","Lforge/trackable/TrackableProperty;"));f.Pc=566;continue;}
case 566:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=567;continue;}
case 567:{f.StackOp("dup");f.Pc=568;continue;}
case 568:{f.Push(JValue.I(81));f.Pc=570;continue;}
case 570:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AlternateState","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AlternateState","Lforge/trackable/TrackableProperty;"));f.Pc=573;continue;}
case 573:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=574;continue;}
case 574:{f.StackOp("dup");f.Pc=575;continue;}
case 575:{f.Push(JValue.I(82));f.Pc=577;continue;}
case 577:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","LeftSplitState","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","LeftSplitState","Lforge/trackable/TrackableProperty;"));f.Pc=580;continue;}
case 580:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=581;continue;}
case 581:{f.StackOp("dup");f.Pc=582;continue;}
case 582:{f.Push(JValue.I(83));f.Pc=584;continue;}
case 584:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","RightSplitState","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","RightSplitState","Lforge/trackable/TrackableProperty;"));f.Pc=587;continue;}
case 587:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=588;continue;}
case 588:{f.StackOp("dup");f.Pc=589;continue;}
case 589:{f.Push(JValue.I(84));f.Pc=591;continue;}
case 591:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Room","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Room","Lforge/trackable/TrackableProperty;"));f.Pc=594;continue;}
case 594:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=595;continue;}
case 595:{f.StackOp("dup");f.Pc=596;continue;}
case 596:{f.Push(JValue.I(85));f.Pc=598;continue;}
case 598:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HiddenId","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HiddenId","Lforge/trackable/TrackableProperty;"));f.Pc=601;continue;}
case 601:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=602;continue;}
case 602:{f.StackOp("dup");f.Pc=603;continue;}
case 603:{f.Push(JValue.I(86));f.Pc=605;continue;}
case 605:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ExertedThisTurn","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ExertedThisTurn","Lforge/trackable/TrackableProperty;"));f.Pc=608;continue;}
case 608:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=609;continue;}
case 609:{f.StackOp("dup");f.Pc=610;continue;}
case 610:{f.Push(JValue.I(87));f.Pc=612;continue;}
case 612:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Detained","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Detained","Lforge/trackable/TrackableProperty;"));f.Pc=615;continue;}
case 615:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=616;continue;}
case 616:{f.StackOp("dup");f.Pc=617;continue;}
case 617:{f.Push(JValue.I(88));f.Pc=619;continue;}
case 619:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Name","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Name","Lforge/trackable/TrackableProperty;"));f.Pc=622;continue;}
case 622:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=623;continue;}
case 623:{f.StackOp("dup");f.Pc=624;continue;}
case 624:{f.Push(JValue.I(89));f.Pc=626;continue;}
case 626:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OracleName","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OracleName","Lforge/trackable/TrackableProperty;"));f.Pc=629;continue;}
case 629:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=630;continue;}
case 630:{f.StackOp("dup");f.Pc=631;continue;}
case 631:{f.Push(JValue.I(90));f.Pc=633;continue;}
case 633:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ImageKey","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ImageKey","Lforge/trackable/TrackableProperty;"));f.Pc=636;continue;}
case 636:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=637;continue;}
case 637:{f.StackOp("dup");f.Pc=638;continue;}
case 638:{f.Push(JValue.I(91));f.Pc=640;continue;}
case 640:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Colors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Colors","Lforge/trackable/TrackableProperty;"));f.Pc=643;continue;}
case 643:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=644;continue;}
case 644:{f.StackOp("dup");f.Pc=645;continue;}
case 645:{f.Push(JValue.I(92));f.Pc=647;continue;}
case 647:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OriginalColors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OriginalColors","Lforge/trackable/TrackableProperty;"));f.Pc=650;continue;}
case 650:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=651;continue;}
case 651:{f.StackOp("dup");f.Pc=652;continue;}
case 652:{f.Push(JValue.I(93));f.Pc=654;continue;}
case 654:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Type","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Type","Lforge/trackable/TrackableProperty;"));f.Pc=657;continue;}
case 657:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=658;continue;}
case 658:{f.StackOp("dup");f.Pc=659;continue;}
case 659:{f.Push(JValue.I(94));f.Pc=661;continue;}
case 661:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ManaCost","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ManaCost","Lforge/trackable/TrackableProperty;"));f.Pc=664;continue;}
case 664:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=665;continue;}
case 665:{f.StackOp("dup");f.Pc=666;continue;}
case 666:{f.Push(JValue.I(95));f.Pc=668;continue;}
case 668:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OriginalManaCost","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OriginalManaCost","Lforge/trackable/TrackableProperty;"));f.Pc=671;continue;}
case 671:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=672;continue;}
case 672:{f.StackOp("dup");f.Pc=673;continue;}
case 673:{f.Push(JValue.I(96));f.Pc=675;continue;}
case 675:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SetCode","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SetCode","Lforge/trackable/TrackableProperty;"));f.Pc=678;continue;}
case 678:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=679;continue;}
case 679:{f.StackOp("dup");f.Pc=680;continue;}
case 680:{f.Push(JValue.I(97));f.Pc=682;continue;}
case 682:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Rarity","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Rarity","Lforge/trackable/TrackableProperty;"));f.Pc=685;continue;}
case 685:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=686;continue;}
case 686:{f.StackOp("dup");f.Pc=687;continue;}
case 687:{f.Push(JValue.I(98));f.Pc=689;continue;}
case 689:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OracleText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OracleText","Lforge/trackable/TrackableProperty;"));f.Pc=692;continue;}
case 692:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=693;continue;}
case 693:{f.StackOp("dup");f.Pc=694;continue;}
case 694:{f.Push(JValue.I(99));f.Pc=696;continue;}
case 696:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","RulesText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","RulesText","Lforge/trackable/TrackableProperty;"));f.Pc=699;continue;}
case 699:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=700;continue;}
case 700:{f.StackOp("dup");f.Pc=701;continue;}
case 701:{f.Push(JValue.I(100));f.Pc=703;continue;}
case 703:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasPrintedPT","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HasPrintedPT","Lforge/trackable/TrackableProperty;"));f.Pc=706;continue;}
case 706:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=707;continue;}
case 707:{f.StackOp("dup");f.Pc=708;continue;}
case 708:{f.Push(JValue.I(101));f.Pc=710;continue;}
case 710:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Power","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Power","Lforge/trackable/TrackableProperty;"));f.Pc=713;continue;}
case 713:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=714;continue;}
case 714:{f.StackOp("dup");f.Pc=715;continue;}
case 715:{f.Push(JValue.I(102));f.Pc=717;continue;}
case 717:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Toughness","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Toughness","Lforge/trackable/TrackableProperty;"));f.Pc=720;continue;}
case 720:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=721;continue;}
case 721:{f.StackOp("dup");f.Pc=722;continue;}
case 722:{f.Push(JValue.I(103));f.Pc=724;continue;}
case 724:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Loyalty","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Loyalty","Lforge/trackable/TrackableProperty;"));f.Pc=727;continue;}
case 727:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=728;continue;}
case 728:{f.StackOp("dup");f.Pc=729;continue;}
case 729:{f.Push(JValue.I(104));f.Pc=731;continue;}
case 731:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Defense","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Defense","Lforge/trackable/TrackableProperty;"));f.Pc=734;continue;}
case 734:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=735;continue;}
case 735:{f.StackOp("dup");f.Pc=736;continue;}
case 736:{f.Push(JValue.I(105));f.Pc=738;continue;}
case 738:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","FunctionalVariant","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","FunctionalVariant","Lforge/trackable/TrackableProperty;"));f.Pc=741;continue;}
case 741:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=742;continue;}
case 742:{f.StackOp("dup");f.Pc=743;continue;}
case 743:{f.Push(JValue.I(106));f.Pc=745;continue;}
case 745:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttractionLights","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttractionLights","Lforge/trackable/TrackableProperty;"));f.Pc=748;continue;}
case 748:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=749;continue;}
case 749:{f.StackOp("dup");f.Pc=750;continue;}
case 750:{f.Push(JValue.I(107));f.Pc=752;continue;}
case 752:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChangedColorWords","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChangedColorWords","Lforge/trackable/TrackableProperty;"));f.Pc=755;continue;}
case 755:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=756;continue;}
case 756:{f.StackOp("dup");f.Pc=757;continue;}
case 757:{f.Push(JValue.I(108));f.Pc=759;continue;}
case 759:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasChangedColors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HasChangedColors","Lforge/trackable/TrackableProperty;"));f.Pc=762;continue;}
case 762:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=763;continue;}
case 763:{f.StackOp("dup");f.Pc=764;continue;}
case 764:{f.Push(JValue.I(109));f.Pc=766;continue;}
case 766:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChangedTypes","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ChangedTypes","Lforge/trackable/TrackableProperty;"));f.Pc=769;continue;}
case 769:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=770;continue;}
case 770:{f.StackOp("dup");f.Pc=771;continue;}
case 771:{f.Push(JValue.I(110));f.Pc=773;continue;}
case 773:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OrigProduceMana","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OrigProduceMana","Lforge/trackable/TrackableProperty;"));f.Pc=776;continue;}
case 776:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=777;continue;}
case 777:{f.StackOp("dup");f.Pc=778;continue;}
case 778:{f.Push(JValue.I(111));f.Pc=780;continue;}
case 780:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OrigProduceAnyMana","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OrigProduceAnyMana","Lforge/trackable/TrackableProperty;"));f.Pc=783;continue;}
case 783:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=784;continue;}
case 784:{f.StackOp("dup");f.Pc=785;continue;}
case 785:{f.Push(JValue.I(112));f.Pc=787;continue;}
case 787:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Keywords","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Keywords","Lforge/trackable/TrackableProperty;"));f.Pc=790;continue;}
case 790:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=791;continue;}
case 791:{f.StackOp("dup");f.Pc=792;continue;}
case 792:{f.Push(JValue.I(113));f.Pc=794;continue;}
case 794:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasAnnihilator","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HasAnnihilator","Lforge/trackable/TrackableProperty;"));f.Pc=797;continue;}
case 797:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=798;continue;}
case 798:{f.StackOp("dup");f.Pc=799;continue;}
case 799:{f.Push(JValue.I(114));f.Pc=801;continue;}
case 801:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasWard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HasWard","Lforge/trackable/TrackableProperty;"));f.Pc=804;continue;}
case 804:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=805;continue;}
case 805:{f.StackOp("dup");f.Pc=806;continue;}
case 806:{f.Push(JValue.I(115));f.Pc=808;continue;}
case 808:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","BlockAdditional","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","BlockAdditional","Lforge/trackable/TrackableProperty;"));f.Pc=811;continue;}
case 811:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=812;continue;}
case 812:{f.StackOp("dup");f.Pc=813;continue;}
case 813:{f.Push(JValue.I(116));f.Pc=815;continue;}
case 815:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","BlockAny","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","BlockAny","Lforge/trackable/TrackableProperty;"));f.Pc=818;continue;}
case 818:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=819;continue;}
case 819:{f.StackOp("dup");f.Pc=820;continue;}
case 820:{f.Push(JValue.I(117));f.Pc=822;continue;}
case 822:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AbilityText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AbilityText","Lforge/trackable/TrackableProperty;"));f.Pc=825;continue;}
case 825:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=826;continue;}
case 826:{f.StackOp("dup");f.Pc=827;continue;}
case 827:{f.Push(JValue.I(118));f.Pc=829;continue;}
case 829:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NonAbilityText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","NonAbilityText","Lforge/trackable/TrackableProperty;"));f.Pc=832;continue;}
case 832:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=833;continue;}
case 833:{f.StackOp("dup");f.Pc=834;continue;}
case 834:{f.Push(JValue.I(119));f.Pc=836;continue;}
case 836:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasDivideDamage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HasDivideDamage","Lforge/trackable/TrackableProperty;"));f.Pc=839;continue;}
case 839:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=840;continue;}
case 840:{f.StackOp("dup");f.Pc=841;continue;}
case 841:{f.Push(JValue.I(120));f.Pc=843;continue;}
case 843:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","FoilIndex","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","FoilIndex","Lforge/trackable/TrackableProperty;"));f.Pc=846;continue;}
case 846:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=847;continue;}
case 847:{f.StackOp("dup");f.Pc=848;continue;}
case 848:{f.Push(JValue.I(121));f.Pc=850;continue;}
case 850:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CantHaveKeyword","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CantHaveKeyword","Lforge/trackable/TrackableProperty;"));f.Pc=853;continue;}
case 853:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=854;continue;}
case 854:{f.StackOp("dup");f.Pc=855;continue;}
case 855:{f.Push(JValue.I(122));f.Pc=857;continue;}
case 857:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsAI","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","IsAI","Lforge/trackable/TrackableProperty;"));f.Pc=860;continue;}
case 860:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=861;continue;}
case 861:{f.StackOp("dup");f.Pc=862;continue;}
case 862:{f.Push(JValue.I(123));f.Pc=864;continue;}
case 864:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","LobbyPlayerName","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","LobbyPlayerName","Lforge/trackable/TrackableProperty;"));f.Pc=867;continue;}
case 867:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=868;continue;}
case 868:{f.StackOp("dup");f.Pc=869;continue;}
case 869:{f.Push(JValue.I(124));f.Pc=871;continue;}
case 871:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AvatarIndex","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AvatarIndex","Lforge/trackable/TrackableProperty;"));f.Pc=874;continue;}
case 874:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=875;continue;}
case 875:{f.StackOp("dup");f.Pc=876;continue;}
case 876:{f.Push(JValue.I(125));f.Pc=878;continue;}
case 878:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AvatarCardImageKey","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AvatarCardImageKey","Lforge/trackable/TrackableProperty;"));f.Pc=881;continue;}
case 881:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=882;continue;}
case 882:{f.StackOp("dup");f.Pc=883;continue;}
case 883:{f.Push(JValue.I(126));f.Pc=885;continue;}
case 885:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SleeveIndex","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SleeveIndex","Lforge/trackable/TrackableProperty;"));f.Pc=888;continue;}
case 888:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=889;continue;}
case 889:{f.StackOp("dup");f.Pc=890;continue;}
case 890:{f.Push(JValue.I(127));f.Pc=892;continue;}
case 892:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SleeveArtKey","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SleeveArtKey","Lforge/trackable/TrackableProperty;"));f.Pc=895;continue;}
case 895:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=896;continue;}
case 896:{f.StackOp("dup");f.Pc=897;continue;}
case 897:{f.Push(JValue.I(128));f.Pc=900;continue;}
case 900:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SleeveArtOffset","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SleeveArtOffset","Lforge/trackable/TrackableProperty;"));f.Pc=903;continue;}
case 903:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=904;continue;}
case 904:{f.StackOp("dup");f.Pc=905;continue;}
case 905:{f.Push(JValue.I(129));f.Pc=908;continue;}
case 908:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Opponents","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Opponents","Lforge/trackable/TrackableProperty;"));f.Pc=911;continue;}
case 911:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=912;continue;}
case 912:{f.StackOp("dup");f.Pc=913;continue;}
case 913:{f.Push(JValue.I(130));f.Pc=916;continue;}
case 916:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SharedTeam","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SharedTeam","Lforge/trackable/TrackableProperty;"));f.Pc=919;continue;}
case 919:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=920;continue;}
case 920:{f.StackOp("dup");f.Pc=921;continue;}
case 921:{f.Push(JValue.I(131));f.Pc=924;continue;}
case 924:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Life","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Life","Lforge/trackable/TrackableProperty;"));f.Pc=927;continue;}
case 927:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=928;continue;}
case 928:{f.StackOp("dup");f.Pc=929;continue;}
case 929:{f.Push(JValue.I(132));f.Pc=932;continue;}
case 932:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MaxHandSize","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MaxHandSize","Lforge/trackable/TrackableProperty;"));f.Pc=935;continue;}
case 935:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=936;continue;}
case 936:{f.StackOp("dup");f.Pc=937;continue;}
case 937:{f.Push(JValue.I(133));f.Pc=940;continue;}
case 940:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasUnlimitedHandSize","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HasUnlimitedHandSize","Lforge/trackable/TrackableProperty;"));f.Pc=943;continue;}
case 943:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=944;continue;}
case 944:{f.StackOp("dup");f.Pc=945;continue;}
case 945:{f.Push(JValue.I(134));f.Pc=948;continue;}
case 948:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MaxLandPlay","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MaxLandPlay","Lforge/trackable/TrackableProperty;"));f.Pc=951;continue;}
case 951:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=952;continue;}
case 952:{f.StackOp("dup");f.Pc=953;continue;}
case 953:{f.Push(JValue.I(135));f.Pc=956;continue;}
case 956:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasUnlimitedLandPlay","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HasUnlimitedLandPlay","Lforge/trackable/TrackableProperty;"));f.Pc=959;continue;}
case 959:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=960;continue;}
case 960:{f.StackOp("dup");f.Pc=961;continue;}
case 961:{f.Push(JValue.I(136));f.Pc=964;continue;}
case 964:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NumLandThisTurn","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","NumLandThisTurn","Lforge/trackable/TrackableProperty;"));f.Pc=967;continue;}
case 967:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=968;continue;}
case 968:{f.StackOp("dup");f.Pc=969;continue;}
case 969:{f.Push(JValue.I(137));f.Pc=972;continue;}
case 972:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","DraftNotes","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","DraftNotes","Lforge/trackable/TrackableProperty;"));f.Pc=975;continue;}
case 975:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=976;continue;}
case 976:{f.StackOp("dup");f.Pc=977;continue;}
case 977:{f.Push(JValue.I(138));f.Pc=980;continue;}
case 980:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NumDrawnThisTurn","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","NumDrawnThisTurn","Lforge/trackable/TrackableProperty;"));f.Pc=983;continue;}
case 983:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=984;continue;}
case 984:{f.StackOp("dup");f.Pc=985;continue;}
case 985:{f.Push(JValue.I(139));f.Pc=988;continue;}
case 988:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AdditionalVote","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AdditionalVote","Lforge/trackable/TrackableProperty;"));f.Pc=991;continue;}
case 991:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=992;continue;}
case 992:{f.StackOp("dup");f.Pc=993;continue;}
case 993:{f.Push(JValue.I(140));f.Pc=996;continue;}
case 996:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OptionalAdditionalVote","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OptionalAdditionalVote","Lforge/trackable/TrackableProperty;"));f.Pc=999;continue;}
case 999:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1000;continue;}
case 1000:{f.StackOp("dup");f.Pc=1001;continue;}
case 1001:{f.Push(JValue.I(141));f.Pc=1004;continue;}
case 1004:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ControlVotes","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ControlVotes","Lforge/trackable/TrackableProperty;"));f.Pc=1007;continue;}
case 1007:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1008;continue;}
case 1008:{f.StackOp("dup");f.Pc=1009;continue;}
case 1009:{f.Push(JValue.I(142));f.Pc=1012;continue;}
case 1012:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AdditionalVillainousChoices","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AdditionalVillainousChoices","Lforge/trackable/TrackableProperty;"));f.Pc=1015;continue;}
case 1015:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1016;continue;}
case 1016:{f.StackOp("dup");f.Pc=1017;continue;}
case 1017:{f.Push(JValue.I(143));f.Pc=1020;continue;}
case 1020:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Commander","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Commander","Lforge/trackable/TrackableProperty;"));f.Pc=1023;continue;}
case 1023:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1024;continue;}
case 1024:{f.StackOp("dup");f.Pc=1025;continue;}
case 1025:{f.Push(JValue.I(144));f.Pc=1028;continue;}
case 1028:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CommanderCast","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CommanderCast","Lforge/trackable/TrackableProperty;"));f.Pc=1031;continue;}
case 1031:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1032;continue;}
case 1032:{f.StackOp("dup");f.Pc=1033;continue;}
case 1033:{f.Push(JValue.I(145));f.Pc=1036;continue;}
case 1036:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CommanderDamage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CommanderDamage","Lforge/trackable/TrackableProperty;"));f.Pc=1039;continue;}
case 1039:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1040;continue;}
case 1040:{f.StackOp("dup");f.Pc=1041;continue;}
case 1041:{f.Push(JValue.I(146));f.Pc=1044;continue;}
case 1044:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MindSlaveMaster","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MindSlaveMaster","Lforge/trackable/TrackableProperty;"));f.Pc=1047;continue;}
case 1047:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1048;continue;}
case 1048:{f.StackOp("dup");f.Pc=1049;continue;}
case 1049:{f.Push(JValue.I(147));f.Pc=1052;continue;}
case 1052:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Ante","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Ante","Lforge/trackable/TrackableProperty;"));f.Pc=1055;continue;}
case 1055:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1056;continue;}
case 1056:{f.StackOp("dup");f.Pc=1057;continue;}
case 1057:{f.Push(JValue.I(148));f.Pc=1060;continue;}
case 1060:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Battlefield","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Battlefield","Lforge/trackable/TrackableProperty;"));f.Pc=1063;continue;}
case 1063:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1064;continue;}
case 1064:{f.StackOp("dup");f.Pc=1065;continue;}
case 1065:{f.Push(JValue.I(149));f.Pc=1068;continue;}
case 1068:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Command","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Command","Lforge/trackable/TrackableProperty;"));f.Pc=1071;continue;}
case 1071:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1072;continue;}
case 1072:{f.StackOp("dup");f.Pc=1073;continue;}
case 1073:{f.Push(JValue.I(150));f.Pc=1076;continue;}
case 1076:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Exile","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Exile","Lforge/trackable/TrackableProperty;"));f.Pc=1079;continue;}
case 1079:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1080;continue;}
case 1080:{f.StackOp("dup");f.Pc=1081;continue;}
case 1081:{f.Push(JValue.I(151));f.Pc=1084;continue;}
case 1084:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Flashback","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Flashback","Lforge/trackable/TrackableProperty;"));f.Pc=1087;continue;}
case 1087:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1088;continue;}
case 1088:{f.StackOp("dup");f.Pc=1089;continue;}
case 1089:{f.Push(JValue.I(152));f.Pc=1092;continue;}
case 1092:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Graveyard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Graveyard","Lforge/trackable/TrackableProperty;"));f.Pc=1095;continue;}
case 1095:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1096;continue;}
case 1096:{f.StackOp("dup");f.Pc=1097;continue;}
case 1097:{f.Push(JValue.I(153));f.Pc=1100;continue;}
case 1100:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Hand","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Hand","Lforge/trackable/TrackableProperty;"));f.Pc=1103;continue;}
case 1103:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1104;continue;}
case 1104:{f.StackOp("dup");f.Pc=1105;continue;}
case 1105:{f.Push(JValue.I(154));f.Pc=1108;continue;}
case 1108:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Library","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Library","Lforge/trackable/TrackableProperty;"));f.Pc=1111;continue;}
case 1111:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1112;continue;}
case 1112:{f.StackOp("dup");f.Pc=1113;continue;}
case 1113:{f.Push(JValue.I(155));f.Pc=1116;continue;}
case 1116:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Sideboard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Sideboard","Lforge/trackable/TrackableProperty;"));f.Pc=1119;continue;}
case 1119:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1120;continue;}
case 1120:{f.StackOp("dup");f.Pc=1121;continue;}
case 1121:{f.Push(JValue.I(156));f.Pc=1124;continue;}
case 1124:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PlanarDeck","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PlanarDeck","Lforge/trackable/TrackableProperty;"));f.Pc=1127;continue;}
case 1127:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1128;continue;}
case 1128:{f.StackOp("dup");f.Pc=1129;continue;}
case 1129:{f.Push(JValue.I(157));f.Pc=1132;continue;}
case 1132:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SchemeDeck","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SchemeDeck","Lforge/trackable/TrackableProperty;"));f.Pc=1135;continue;}
case 1135:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1136;continue;}
case 1136:{f.StackOp("dup");f.Pc=1137;continue;}
case 1137:{f.Push(JValue.I(158));f.Pc=1140;continue;}
case 1140:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttractionDeck","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttractionDeck","Lforge/trackable/TrackableProperty;"));f.Pc=1143;continue;}
case 1143:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1144;continue;}
case 1144:{f.StackOp("dup");f.Pc=1145;continue;}
case 1145:{f.Push(JValue.I(159));f.Pc=1148;continue;}
case 1148:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ContraptionDeck","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ContraptionDeck","Lforge/trackable/TrackableProperty;"));f.Pc=1151;continue;}
case 1151:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1152;continue;}
case 1152:{f.StackOp("dup");f.Pc=1153;continue;}
case 1153:{f.Push(JValue.I(160));f.Pc=1156;continue;}
case 1156:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Junkyard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Junkyard","Lforge/trackable/TrackableProperty;"));f.Pc=1159;continue;}
case 1159:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1160;continue;}
case 1160:{f.StackOp("dup");f.Pc=1161;continue;}
case 1161:{f.Push(JValue.I(161));f.Pc=1164;continue;}
case 1164:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","StickerSheets","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","StickerSheets","Lforge/trackable/TrackableProperty;"));f.Pc=1167;continue;}
case 1167:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1168;continue;}
case 1168:{f.StackOp("dup");f.Pc=1169;continue;}
case 1169:{f.Push(JValue.I(162));f.Pc=1172;continue;}
case 1172:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Stickers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Stickers","Lforge/trackable/TrackableProperty;"));f.Pc=1175;continue;}
case 1175:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1176;continue;}
case 1176:{f.StackOp("dup");f.Pc=1177;continue;}
case 1177:{f.Push(JValue.I(163));f.Pc=1180;continue;}
case 1180:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Mana","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Mana","Lforge/trackable/TrackableProperty;"));f.Pc=1183;continue;}
case 1183:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1184;continue;}
case 1184:{f.StackOp("dup");f.Pc=1185;continue;}
case 1185:{f.Push(JValue.I(164));f.Pc=1188;continue;}
case 1188:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsExtraTurn","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","IsExtraTurn","Lforge/trackable/TrackableProperty;"));f.Pc=1191;continue;}
case 1191:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1192;continue;}
case 1192:{f.StackOp("dup");f.Pc=1193;continue;}
case 1193:{f.Push(JValue.I(165));f.Pc=1196;continue;}
case 1196:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ExtraTurnCount","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ExtraTurnCount","Lforge/trackable/TrackableProperty;"));f.Pc=1199;continue;}
case 1199:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1200;continue;}
case 1200:{f.StackOp("dup");f.Pc=1201;continue;}
case 1201:{f.Push(JValue.I(166));f.Pc=1204;continue;}
case 1204:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasPriority","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HasPriority","Lforge/trackable/TrackableProperty;"));f.Pc=1207;continue;}
case 1207:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1208;continue;}
case 1208:{f.StackOp("dup");f.Pc=1209;continue;}
case 1209:{f.Push(JValue.I(167));f.Pc=1212;continue;}
case 1212:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasLost","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HasLost","Lforge/trackable/TrackableProperty;"));f.Pc=1215;continue;}
case 1215:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1216;continue;}
case 1216:{f.StackOp("dup");f.Pc=1217;continue;}
case 1217:{f.Push(JValue.I(168));f.Pc=1220;continue;}
case 1220:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasAvailableActions","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HasAvailableActions","Lforge/trackable/TrackableProperty;"));f.Pc=1223;continue;}
case 1223:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1224;continue;}
case 1224:{f.StackOp("dup");f.Pc=1225;continue;}
case 1225:{f.Push(JValue.I(169));f.Pc=1228;continue;}
case 1228:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NumManaShards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","NumManaShards","Lforge/trackable/TrackableProperty;"));f.Pc=1231;continue;}
case 1231:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1232;continue;}
case 1232:{f.StackOp("dup");f.Pc=1233;continue;}
case 1233:{f.Push(JValue.I(170));f.Pc=1236;continue;}
case 1236:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HostCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HostCard","Lforge/trackable/TrackableProperty;"));f.Pc=1239;continue;}
case 1239:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1240;continue;}
case 1240:{f.StackOp("dup");f.Pc=1241;continue;}
case 1241:{f.Push(JValue.I(171));f.Pc=1244;continue;}
case 1244:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Description","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Description","Lforge/trackable/TrackableProperty;"));f.Pc=1247;continue;}
case 1247:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1248;continue;}
case 1248:{f.StackOp("dup");f.Pc=1249;continue;}
case 1249:{f.Push(JValue.I(172));f.Pc=1252;continue;}
case 1252:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CanPlay","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CanPlay","Lforge/trackable/TrackableProperty;"));f.Pc=1255;continue;}
case 1255:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1256;continue;}
case 1256:{f.StackOp("dup");f.Pc=1257;continue;}
case 1257:{f.Push(JValue.I(173));f.Pc=1260;continue;}
case 1260:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PromptIfOnlyPossibleAbility","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PromptIfOnlyPossibleAbility","Lforge/trackable/TrackableProperty;"));f.Pc=1263;continue;}
case 1263:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1264;continue;}
case 1264:{f.StackOp("dup");f.Pc=1265;continue;}
case 1265:{f.Push(JValue.I(174));f.Pc=1268;continue;}
case 1268:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SA_IsSpell","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SA_IsSpell","Lforge/trackable/TrackableProperty;"));f.Pc=1271;continue;}
case 1271:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1272;continue;}
case 1272:{f.StackOp("dup");f.Pc=1273;continue;}
case 1273:{f.Push(JValue.I(175));f.Pc=1276;continue;}
case 1276:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Key","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Key","Lforge/trackable/TrackableProperty;"));f.Pc=1279;continue;}
case 1279:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1280;continue;}
case 1280:{f.StackOp("dup");f.Pc=1281;continue;}
case 1281:{f.Push(JValue.I(176));f.Pc=1284;continue;}
case 1284:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SourceTrigger","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SourceTrigger","Lforge/trackable/TrackableProperty;"));f.Pc=1287;continue;}
case 1287:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1288;continue;}
case 1288:{f.StackOp("dup");f.Pc=1289;continue;}
case 1289:{f.Push(JValue.I(177));f.Pc=1292;continue;}
case 1292:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SourceCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SourceCard","Lforge/trackable/TrackableProperty;"));f.Pc=1295;continue;}
case 1295:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1296;continue;}
case 1296:{f.StackOp("dup");f.Pc=1297;continue;}
case 1297:{f.Push(JValue.I(178));f.Pc=1300;continue;}
case 1300:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ActivatingPlayer","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ActivatingPlayer","Lforge/trackable/TrackableProperty;"));f.Pc=1303;continue;}
case 1303:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1304;continue;}
case 1304:{f.StackOp("dup");f.Pc=1305;continue;}
case 1305:{f.Push(JValue.I(179));f.Pc=1308;continue;}
case 1308:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","TargetCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","TargetCards","Lforge/trackable/TrackableProperty;"));f.Pc=1311;continue;}
case 1311:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1312;continue;}
case 1312:{f.StackOp("dup");f.Pc=1313;continue;}
case 1313:{f.Push(JValue.I(180));f.Pc=1316;continue;}
case 1316:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","TargetPlayers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","TargetPlayers","Lforge/trackable/TrackableProperty;"));f.Pc=1319;continue;}
case 1319:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1320;continue;}
case 1320:{f.StackOp("dup");f.Pc=1321;continue;}
case 1321:{f.Push(JValue.I(181));f.Pc=1324;continue;}
case 1324:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","TargetStackItems","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","TargetStackItems","Lforge/trackable/TrackableProperty;"));f.Pc=1327;continue;}
case 1327:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1328;continue;}
case 1328:{f.StackOp("dup");f.Pc=1329;continue;}
case 1329:{f.Push(JValue.I(182));f.Pc=1332;continue;}
case 1332:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SubInstance","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SubInstance","Lforge/trackable/TrackableProperty;"));f.Pc=1335;continue;}
case 1335:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1336;continue;}
case 1336:{f.StackOp("dup");f.Pc=1337;continue;}
case 1337:{f.Push(JValue.I(183));f.Pc=1340;continue;}
case 1340:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Ability","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Ability","Lforge/trackable/TrackableProperty;"));f.Pc=1343;continue;}
case 1343:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1344;continue;}
case 1344:{f.StackOp("dup");f.Pc=1345;continue;}
case 1345:{f.Push(JValue.I(184));f.Pc=1348;continue;}
case 1348:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OptionalTrigger","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OptionalTrigger","Lforge/trackable/TrackableProperty;"));f.Pc=1351;continue;}
case 1351:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1352;continue;}
case 1352:{f.StackOp("dup");f.Pc=1353;continue;}
case 1353:{f.Push(JValue.I(185));f.Pc=1356;continue;}
case 1356:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OptionalCosts","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OptionalCosts","Lforge/trackable/TrackableProperty;"));f.Pc=1359;continue;}
case 1359:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1360;continue;}
case 1360:{f.StackOp("dup");f.Pc=1361;continue;}
case 1361:{f.Push(JValue.I(186));f.Pc=1364;continue;}
case 1364:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CombatView","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CombatView","Lforge/trackable/TrackableProperty;"));f.Pc=1367;continue;}
case 1367:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1368;continue;}
case 1368:{f.StackOp("dup");f.Pc=1369;continue;}
case 1369:{f.Push(JValue.I(187));f.Pc=1372;continue;}
case 1372:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttackersWithDefenders","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttackersWithDefenders","Lforge/trackable/TrackableProperty;"));f.Pc=1375;continue;}
case 1375:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1376;continue;}
case 1376:{f.StackOp("dup");f.Pc=1377;continue;}
case 1377:{f.Push(JValue.I(188));f.Pc=1380;continue;}
case 1380:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttackersWithBlockers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttackersWithBlockers","Lforge/trackable/TrackableProperty;"));f.Pc=1383;continue;}
case 1383:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1384;continue;}
case 1384:{f.StackOp("dup");f.Pc=1385;continue;}
case 1385:{f.Push(JValue.I(189));f.Pc=1388;continue;}
case 1388:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttackersWithPlannedBlockers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttackersWithPlannedBlockers","Lforge/trackable/TrackableProperty;"));f.Pc=1391;continue;}
case 1391:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1392;continue;}
case 1392:{f.StackOp("dup");f.Pc=1393;continue;}
case 1393:{f.Push(JValue.I(190));f.Pc=1396;continue;}
case 1396:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","BandsWithDefenders","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","BandsWithDefenders","Lforge/trackable/TrackableProperty;"));f.Pc=1399;continue;}
case 1399:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1400;continue;}
case 1400:{f.StackOp("dup");f.Pc=1401;continue;}
case 1401:{f.Push(JValue.I(191));f.Pc=1404;continue;}
case 1404:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","BandsWithBlockers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","BandsWithBlockers","Lforge/trackable/TrackableProperty;"));f.Pc=1407;continue;}
case 1407:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1408;continue;}
case 1408:{f.StackOp("dup");f.Pc=1409;continue;}
case 1409:{f.Push(JValue.I(192));f.Pc=1412;continue;}
case 1412:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","BandsWithPlannedBlockers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","BandsWithPlannedBlockers","Lforge/trackable/TrackableProperty;"));f.Pc=1415;continue;}
case 1415:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1416;continue;}
case 1416:{f.StackOp("dup");f.Pc=1417;continue;}
case 1417:{f.Push(JValue.I(193));f.Pc=1420;continue;}
case 1420:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Players","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Players","Lforge/trackable/TrackableProperty;"));f.Pc=1423;continue;}
case 1423:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1424;continue;}
case 1424:{f.StackOp("dup");f.Pc=1425;continue;}
case 1425:{f.Push(JValue.I(194));f.Pc=1428;continue;}
case 1428:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","GameType","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","GameType","Lforge/trackable/TrackableProperty;"));f.Pc=1431;continue;}
case 1431:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1432;continue;}
case 1432:{f.StackOp("dup");f.Pc=1433;continue;}
case 1433:{f.Push(JValue.I(195));f.Pc=1436;continue;}
case 1436:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Title","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Title","Lforge/trackable/TrackableProperty;"));f.Pc=1439;continue;}
case 1439:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1440;continue;}
case 1440:{f.StackOp("dup");f.Pc=1441;continue;}
case 1441:{f.Push(JValue.I(196));f.Pc=1444;continue;}
case 1444:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Turn","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Turn","Lforge/trackable/TrackableProperty;"));f.Pc=1447;continue;}
case 1447:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1448;continue;}
case 1448:{f.StackOp("dup");f.Pc=1449;continue;}
case 1449:{f.Push(JValue.I(197));f.Pc=1452;continue;}
case 1452:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PlayerTurn","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PlayerTurn","Lforge/trackable/TrackableProperty;"));f.Pc=1455;continue;}
case 1455:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1456;continue;}
case 1456:{f.StackOp("dup");f.Pc=1457;continue;}
case 1457:{f.Push(JValue.I(198));f.Pc=1460;continue;}
case 1460:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Phase","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Phase","Lforge/trackable/TrackableProperty;"));f.Pc=1463;continue;}
case 1463:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1464;continue;}
case 1464:{f.StackOp("dup");f.Pc=1465;continue;}
case 1465:{f.Push(JValue.I(199));f.Pc=1468;continue;}
case 1468:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","WinningPlayerName","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","WinningPlayerName","Lforge/trackable/TrackableProperty;"));f.Pc=1471;continue;}
case 1471:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1472;continue;}
case 1472:{f.StackOp("dup");f.Pc=1473;continue;}
case 1473:{f.Push(JValue.I(200));f.Pc=1476;continue;}
case 1476:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","WinningTeam","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","WinningTeam","Lforge/trackable/TrackableProperty;"));f.Pc=1479;continue;}
case 1479:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1480;continue;}
case 1480:{f.StackOp("dup");f.Pc=1481;continue;}
case 1481:{f.Push(JValue.I(201));f.Pc=1484;continue;}
case 1484:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Mulligan","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Mulligan","Lforge/trackable/TrackableProperty;"));f.Pc=1487;continue;}
case 1487:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1488;continue;}
case 1488:{f.StackOp("dup");f.Pc=1489;continue;}
case 1489:{f.Push(JValue.I(202));f.Pc=1492;continue;}
case 1492:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","GameOver","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","GameOver","Lforge/trackable/TrackableProperty;"));f.Pc=1495;continue;}
case 1495:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1496;continue;}
case 1496:{f.StackOp("dup");f.Pc=1497;continue;}
case 1497:{f.Push(JValue.I(203));f.Pc=1500;continue;}
case 1500:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MatchOver","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MatchOver","Lforge/trackable/TrackableProperty;"));f.Pc=1503;continue;}
case 1503:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1504;continue;}
case 1504:{f.StackOp("dup");f.Pc=1505;continue;}
case 1505:{f.Push(JValue.I(204));f.Pc=1508;continue;}
case 1508:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NumGamesInMatch","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","NumGamesInMatch","Lforge/trackable/TrackableProperty;"));f.Pc=1511;continue;}
case 1511:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1512;continue;}
case 1512:{f.StackOp("dup");f.Pc=1513;continue;}
case 1513:{f.Push(JValue.I(205));f.Pc=1516;continue;}
case 1516:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NumPlayedGamesInMatch","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","NumPlayedGamesInMatch","Lforge/trackable/TrackableProperty;"));f.Pc=1519;continue;}
case 1519:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1520;continue;}
case 1520:{f.StackOp("dup");f.Pc=1521;continue;}
case 1521:{f.Push(JValue.I(206));f.Pc=1524;continue;}
case 1524:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Stack","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Stack","Lforge/trackable/TrackableProperty;"));f.Pc=1527;continue;}
case 1527:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1528;continue;}
case 1528:{f.StackOp("dup");f.Pc=1529;continue;}
case 1529:{f.Push(JValue.I(207));f.Pc=1532;continue;}
case 1532:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","StormCount","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","StormCount","Lforge/trackable/TrackableProperty;"));f.Pc=1535;continue;}
case 1535:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1536;continue;}
case 1536:{f.StackOp("dup");f.Pc=1537;continue;}
case 1537:{f.Push(JValue.I(208));f.Pc=1540;continue;}
case 1540:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PoisonCountersToLose","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PoisonCountersToLose","Lforge/trackable/TrackableProperty;"));f.Pc=1543;continue;}
case 1543:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1544;continue;}
case 1544:{f.StackOp("dup");f.Pc=1545;continue;}
case 1545:{f.Push(JValue.I(209));f.Pc=1548;continue;}
case 1548:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Object","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Object","Lforge/trackable/TrackableProperty;"));f.Pc=1551;continue;}
case 1551:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1552;continue;}
case 1552:{f.StackOp("dup");f.Pc=1553;continue;}
case 1553:{f.Push(JValue.I(210));f.Pc=1556;continue;}
case 1556:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Dependencies","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Dependencies","Lforge/trackable/TrackableProperty;"));f.Pc=1559;continue;}
case 1559:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1560;continue;}
case 1560:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11572(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("PreventNextDamage")));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",14);}
case 14:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PreventNextDamage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","PreventNextDamage","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=17;continue;}
case 17:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("AttachedCards")));f.Pc=24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",31);}
case 31:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttachedCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","AttachedCards","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=34;continue;}
case 34:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("Counters")));f.Pc=41;continue;}
case 41:{f.Push(JValue.I(2));f.Pc=42;continue;}
case 42:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CounterMapType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CounterMapType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",48);}
case 48:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Counters","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Counters","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=51;continue;}
case 51:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=54;continue;}
case 54:{f.StackOp("dup");f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("CurrentPlane")));f.Pc=58;continue;}
case 58:{f.Push(JValue.I(3));f.Pc=59;continue;}
case 59:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",65);}
case 65:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CurrentPlane","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","CurrentPlane","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=68;continue;}
case 68:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=71;continue;}
case 71:{f.StackOp("dup");f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("PlanarPlayer")));f.Pc=75;continue;}
case 75:{f.Push(JValue.I(4));f.Pc=76;continue;}
case 76:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",82);}
case 82:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PlanarPlayer","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","PlanarPlayer","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=85;continue;}
case 85:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=88;continue;}
case 88:{f.StackOp("dup");f.Pc=89;continue;}
case 89:{f.Push(JValue.R(rt.String("Owner")));f.Pc=92;continue;}
case 92:{f.Push(JValue.I(5));f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",99);}
case 99:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Owner","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Owner","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=102;continue;}
case 102:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=105;continue;}
case 105:{f.StackOp("dup");f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("Controller")));f.Pc=109;continue;}
case 109:{f.Push(JValue.I(6));f.Pc=111;continue;}
case 111:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",117);}
case 117:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Controller","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Controller","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=120;continue;}
case 120:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=123;continue;}
case 123:{f.StackOp("dup");f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.String("Zone")));f.Pc=127;continue;}
case 127:{f.Push(JValue.I(7));f.Pc=129;continue;}
case 129:{f.Push(JValue.R(rt.ClassObject("forge/game/zone/ZoneType")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/trackable/TrackableTypes","EnumType","(Ljava/lang/Class;)Lforge/trackable/TrackableTypes$TrackableType;","invokestatic",135);}
case 135:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",138);}
case 138:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Zone","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Zone","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=141;continue;}
case 141:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=144;continue;}
case 144:{f.StackOp("dup");f.Pc=145;continue;}
case 145:{f.Push(JValue.R(rt.String("GamePieceType")));f.Pc=148;continue;}
case 148:{f.Push(JValue.I(8));f.Pc=150;continue;}
case 150:{f.Push(JValue.R(rt.ClassObject("forge/card/GamePieceType")));f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/trackable/TrackableTypes","EnumType","(Ljava/lang/Class;)Lforge/trackable/TrackableTypes$TrackableType;","invokestatic",156);}
case 156:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",159);}
case 159:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","GamePieceType","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","GamePieceType","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=162;continue;}
case 162:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=165;continue;}
case 165:{f.StackOp("dup");f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.String("IsEmblem")));f.Pc=169;continue;}
case 169:{f.Push(JValue.I(9));f.Pc=171;continue;}
case 171:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",177);}
case 177:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsEmblem","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","IsEmblem","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=180;continue;}
case 180:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=183;continue;}
case 183:{f.StackOp("dup");f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String("IsBoon")));f.Pc=187;continue;}
case 187:{f.Push(JValue.I(10));f.Pc=189;continue;}
case 189:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",195);}
case 195:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsBoon","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","IsBoon","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=198;continue;}
case 198:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=201;continue;}
case 201:{f.StackOp("dup");f.Pc=202;continue;}
case 202:{f.Push(JValue.R(rt.String("CanSpecialize")));f.Pc=205;continue;}
case 205:{f.Push(JValue.I(11));f.Pc=207;continue;}
case 207:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",213);}
case 213:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CanSpecialize","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","CanSpecialize","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=216;continue;}
case 216:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=219;continue;}
case 219:{f.StackOp("dup");f.Pc=220;continue;}
case 220:{f.Push(JValue.R(rt.String("Flipped")));f.Pc=223;continue;}
case 223:{f.Push(JValue.I(12));f.Pc=225;continue;}
case 225:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",231);}
case 231:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Flipped","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Flipped","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=234;continue;}
case 234:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=237;continue;}
case 237:{f.StackOp("dup");f.Pc=238;continue;}
case 238:{f.Push(JValue.R(rt.String("Facedown")));f.Pc=241;continue;}
case 241:{f.Push(JValue.I(13));f.Pc=243;continue;}
case 243:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",249);}
case 249:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Facedown","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Facedown","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=252;continue;}
case 252:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=255;continue;}
case 255:{f.StackOp("dup");f.Pc=256;continue;}
case 256:{f.Push(JValue.R(rt.String("Foretold")));f.Pc=259;continue;}
case 259:{f.Push(JValue.I(14));f.Pc=261;continue;}
case 261:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",267);}
case 267:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Foretold","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Foretold","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=270;continue;}
case 270:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=273;continue;}
case 273:{f.StackOp("dup");f.Pc=274;continue;}
case 274:{f.Push(JValue.R(rt.String("Modal")));f.Pc=277;continue;}
case 277:{f.Push(JValue.I(15));f.Pc=279;continue;}
case 279:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",285);}
case 285:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Modal","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Modal","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=288;continue;}
case 288:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=291;continue;}
case 291:{f.StackOp("dup");f.Pc=292;continue;}
case 292:{f.Push(JValue.R(rt.String("Secondary")));f.Pc=295;continue;}
case 295:{f.Push(JValue.I(16));f.Pc=297;continue;}
case 297:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",303);}
case 303:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Secondary","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Secondary","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=306;continue;}
case 306:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=309;continue;}
case 309:{f.StackOp("dup");f.Pc=310;continue;}
case 310:{f.Push(JValue.R(rt.String("DoubleFaced")));f.Pc=313;continue;}
case 313:{f.Push(JValue.I(17));f.Pc=315;continue;}
case 315:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",321);}
case 321:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","DoubleFaced","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","DoubleFaced","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=324;continue;}
case 324:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=327;continue;}
case 327:{f.StackOp("dup");f.Pc=328;continue;}
case 328:{f.Push(JValue.R(rt.String("FacedownImageKey")));f.Pc=331;continue;}
case 331:{f.Push(JValue.I(18));f.Pc=333;continue;}
case 333:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",339);}
case 339:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","FacedownImageKey","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","FacedownImageKey","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=342;continue;}
case 342:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=345;continue;}
case 345:{f.StackOp("dup");f.Pc=346;continue;}
case 346:{f.Push(JValue.R(rt.String("PaperFoil")));f.Pc=349;continue;}
case 349:{f.Push(JValue.I(19));f.Pc=351;continue;}
case 351:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",357);}
case 357:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PaperFoil","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","PaperFoil","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=360;continue;}
case 360:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=363;continue;}
case 363:{f.StackOp("dup");f.Pc=364;continue;}
case 364:{f.Push(JValue.R(rt.String("Cloner")));f.Pc=367;continue;}
case 367:{f.Push(JValue.I(20));f.Pc=369;continue;}
case 369:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=372;continue;}
case 372:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",375);}
case 375:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Cloner","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Cloner","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=378;continue;}
case 378:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=381;continue;}
case 381:{f.StackOp("dup");f.Pc=382;continue;}
case 382:{f.Push(JValue.R(rt.String("Cloned")));f.Pc=385;continue;}
case 385:{f.Push(JValue.I(21));f.Pc=387;continue;}
case 387:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=390;continue;}
case 390:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",393);}
case 393:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Cloned","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Cloned","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=396;continue;}
case 396:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=399;continue;}
case 399:{f.StackOp("dup");f.Pc=400;continue;}
case 400:{f.Push(JValue.R(rt.String("FlipCard")));f.Pc=403;continue;}
case 403:{f.Push(JValue.I(22));f.Pc=405;continue;}
case 405:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=408;continue;}
case 408:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",411);}
case 411:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","FlipCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","FlipCard","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=414;continue;}
case 414:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=417;continue;}
case 417:{f.StackOp("dup");f.Pc=418;continue;}
case 418:{f.Push(JValue.R(rt.String("SplitCard")));f.Pc=421;continue;}
case 421:{f.Push(JValue.I(23));f.Pc=423;continue;}
case 423:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=426;continue;}
case 426:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",429);}
case 429:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SplitCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","SplitCard","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=432;continue;}
case 432:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=435;continue;}
case 435:{f.StackOp("dup");f.Pc=436;continue;}
case 436:{f.Push(JValue.R(rt.String("MergedCards")));f.Pc=439;continue;}
case 439:{f.Push(JValue.I(24));f.Pc=441;continue;}
case 441:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=444;continue;}
case 444:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",447);}
case 447:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MergedCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","MergedCards","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=450;continue;}
case 450:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=453;continue;}
case 453:{f.StackOp("dup");f.Pc=454;continue;}
case 454:{f.Push(JValue.R(rt.String("MergedCardsCollection")));f.Pc=457;continue;}
case 457:{f.Push(JValue.I(25));f.Pc=459;continue;}
case 459:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=462;continue;}
case 462:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=465;continue;}
case 465:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",468);}
case 468:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MergedCardsCollection","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","MergedCardsCollection","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=471;continue;}
case 471:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=474;continue;}
case 474:{f.StackOp("dup");f.Pc=475;continue;}
case 475:{f.Push(JValue.R(rt.String("PaperCardBackup")));f.Pc=478;continue;}
case 478:{f.Push(JValue.I(26));f.Pc=480;continue;}
case 480:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IPaperCardType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IPaperCardType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=483;continue;}
case 483:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",486);}
case 486:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PaperCardBackup","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","PaperCardBackup","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=489;continue;}
case 489:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=492;continue;}
case 492:{f.StackOp("dup");f.Pc=493;continue;}
case 493:{f.Push(JValue.R(rt.String("Attacking")));f.Pc=496;continue;}
case 496:{f.Push(JValue.I(27));f.Pc=498;continue;}
case 498:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=501;continue;}
case 501:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",504);}
case 504:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Attacking","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Attacking","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=507;continue;}
case 507:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=510;continue;}
case 510:{f.StackOp("dup");f.Pc=511;continue;}
case 511:{f.Push(JValue.R(rt.String("Blocking")));f.Pc=514;continue;}
case 514:{f.Push(JValue.I(28));f.Pc=516;continue;}
case 516:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=519;continue;}
case 519:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",522);}
case 522:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Blocking","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Blocking","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=525;continue;}
case 525:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=528;continue;}
case 528:{f.StackOp("dup");f.Pc=529;continue;}
case 529:{f.Push(JValue.R(rt.String("PhasedOut")));f.Pc=532;continue;}
case 532:{f.Push(JValue.I(29));f.Pc=534;continue;}
case 534:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=537;continue;}
case 537:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",540);}
case 540:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PhasedOut","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","PhasedOut","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=543;continue;}
case 543:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=546;continue;}
case 546:{f.StackOp("dup");f.Pc=547;continue;}
case 547:{f.Push(JValue.R(rt.String("Sickness")));f.Pc=550;continue;}
case 550:{f.Push(JValue.I(30));f.Pc=552;continue;}
case 552:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=555;continue;}
case 555:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",558);}
case 558:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Sickness","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Sickness","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=561;continue;}
case 561:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=564;continue;}
case 564:{f.StackOp("dup");f.Pc=565;continue;}
case 565:{f.Push(JValue.R(rt.String("Tapped")));f.Pc=568;continue;}
case 568:{f.Push(JValue.I(31));f.Pc=570;continue;}
case 570:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=573;continue;}
case 573:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",576);}
case 576:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Tapped","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Tapped","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=579;continue;}
case 579:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=582;continue;}
case 582:{f.StackOp("dup");f.Pc=583;continue;}
case 583:{f.Push(JValue.R(rt.String("Token")));f.Pc=586;continue;}
case 586:{f.Push(JValue.I(32));f.Pc=588;continue;}
case 588:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=591;continue;}
case 591:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",594);}
case 594:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Token","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Token","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=597;continue;}
case 597:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=600;continue;}
case 600:{f.StackOp("dup");f.Pc=601;continue;}
case 601:{f.Push(JValue.R(rt.String("TokenCard")));f.Pc=604;continue;}
case 604:{f.Push(JValue.I(33));f.Pc=606;continue;}
case 606:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=609;continue;}
case 609:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",612);}
case 612:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","TokenCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","TokenCard","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=615;continue;}
case 615:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=618;continue;}
case 618:{f.StackOp("dup");f.Pc=619;continue;}
case 619:{f.Push(JValue.R(rt.String("IsCommander")));f.Pc=622;continue;}
case 622:{f.Push(JValue.I(34));f.Pc=624;continue;}
case 624:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=627;continue;}
case 627:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",630);}
case 630:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsCommander","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","IsCommander","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=633;continue;}
case 633:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=636;continue;}
case 636:{f.StackOp("dup");f.Pc=637;continue;}
case 637:{f.Push(JValue.R(rt.String("IsRingBearer")));f.Pc=640;continue;}
case 640:{f.Push(JValue.I(35));f.Pc=642;continue;}
case 642:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=645;continue;}
case 645:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",648);}
case 648:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsRingBearer","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","IsRingBearer","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=651;continue;}
case 651:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=654;continue;}
case 654:{f.StackOp("dup");f.Pc=655;continue;}
case 655:{f.Push(JValue.R(rt.String("CommanderAltType")));f.Pc=658;continue;}
case 658:{f.Push(JValue.I(36));f.Pc=660;continue;}
case 660:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=663;continue;}
case 663:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",666);}
case 666:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CommanderAltType","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","CommanderAltType","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=669;continue;}
case 669:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=672;continue;}
case 672:{f.StackOp("dup");f.Pc=673;continue;}
case 673:{f.Push(JValue.R(rt.String("Damage")));f.Pc=676;continue;}
case 676:{f.Push(JValue.I(37));f.Pc=678;continue;}
case 678:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=681;continue;}
case 681:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",684);}
case 684:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Damage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Damage","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=687;continue;}
case 687:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=690;continue;}
case 690:{f.StackOp("dup");f.Pc=691;continue;}
case 691:{f.Push(JValue.R(rt.String("AssignedDamage")));f.Pc=694;continue;}
case 694:{f.Push(JValue.I(38));f.Pc=696;continue;}
case 696:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=699;continue;}
case 699:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",702);}
case 702:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AssignedDamage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","AssignedDamage","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=705;continue;}
case 705:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=708;continue;}
case 708:{f.StackOp("dup");f.Pc=709;continue;}
case 709:{f.Push(JValue.R(rt.String("LethalDamage")));f.Pc=712;continue;}
case 712:{f.Push(JValue.I(39));f.Pc=714;continue;}
case 714:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=717;continue;}
case 717:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",720);}
case 720:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","LethalDamage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","LethalDamage","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=723;continue;}
case 723:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=726;continue;}
case 726:{f.StackOp("dup");f.Pc=727;continue;}
case 727:{f.Push(JValue.R(rt.String("ShieldCount")));f.Pc=730;continue;}
case 730:{f.Push(JValue.I(40));f.Pc=732;continue;}
case 732:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=735;continue;}
case 735:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",738);}
case 738:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ShieldCount","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ShieldCount","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=741;continue;}
case 741:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=744;continue;}
case 744:{f.StackOp("dup");f.Pc=745;continue;}
case 745:{f.Push(JValue.R(rt.String("ChosenType")));f.Pc=748;continue;}
case 748:{f.Push(JValue.I(41));f.Pc=750;continue;}
case 750:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=753;continue;}
case 753:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",756);}
case 756:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenType","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ChosenType","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=759;continue;}
case 759:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=762;continue;}
case 762:{f.StackOp("dup");f.Pc=763;continue;}
case 763:{f.Push(JValue.R(rt.String("ChosenType2")));f.Pc=766;continue;}
case 766:{f.Push(JValue.I(42));f.Pc=768;continue;}
case 768:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=771;continue;}
case 771:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",774);}
case 774:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenType2","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ChosenType2","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=777;continue;}
case 777:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=780;continue;}
case 780:{f.StackOp("dup");f.Pc=781;continue;}
case 781:{f.Push(JValue.R(rt.String("NotedTypes")));f.Pc=784;continue;}
case 784:{f.Push(JValue.I(43));f.Pc=786;continue;}
case 786:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringListType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringListType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=789;continue;}
case 789:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",792);}
case 792:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NotedTypes","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","NotedTypes","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=795;continue;}
case 795:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=798;continue;}
case 798:{f.StackOp("dup");f.Pc=799;continue;}
case 799:{f.Push(JValue.R(rt.String("ChosenColors")));f.Pc=802;continue;}
case 802:{f.Push(JValue.I(44));f.Pc=804;continue;}
case 804:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringListType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringListType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=807;continue;}
case 807:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",810);}
case 810:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenColors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ChosenColors","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=813;continue;}
case 813:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=816;continue;}
case 816:{f.StackOp("dup");f.Pc=817;continue;}
case 817:{f.Push(JValue.R(rt.String("ChosenCards")));f.Pc=820;continue;}
case 820:{f.Push(JValue.I(45));f.Pc=822;continue;}
case 822:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=825;continue;}
case 825:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",828);}
case 828:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ChosenCards","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=831;continue;}
case 831:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=834;continue;}
case 834:{f.StackOp("dup");f.Pc=835;continue;}
case 835:{f.Push(JValue.R(rt.String("ChosenNumber")));f.Pc=838;continue;}
case 838:{f.Push(JValue.I(46));f.Pc=840;continue;}
case 840:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=843;continue;}
case 843:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",846);}
case 846:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenNumber","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ChosenNumber","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=849;continue;}
case 849:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=852;continue;}
case 852:{f.StackOp("dup");f.Pc=853;continue;}
case 853:{f.Push(JValue.R(rt.String("StoredRolls")));f.Pc=856;continue;}
case 856:{f.Push(JValue.I(47));f.Pc=858;continue;}
case 858:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringListType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringListType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=861;continue;}
case 861:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",864);}
case 864:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","StoredRolls","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","StoredRolls","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=867;continue;}
case 867:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=870;continue;}
case 870:{f.StackOp("dup");f.Pc=871;continue;}
case 871:{f.Push(JValue.R(rt.String("ChosenPlayer")));f.Pc=874;continue;}
case 874:{f.Push(JValue.I(48));f.Pc=876;continue;}
case 876:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=879;continue;}
case 879:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",882);}
case 882:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenPlayer","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ChosenPlayer","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=885;continue;}
case 885:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=888;continue;}
case 888:{f.StackOp("dup");f.Pc=889;continue;}
case 889:{f.Push(JValue.R(rt.String("PromisedGift")));f.Pc=892;continue;}
case 892:{f.Push(JValue.I(49));f.Pc=894;continue;}
case 894:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=897;continue;}
case 897:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",900);}
case 900:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PromisedGift","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","PromisedGift","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=903;continue;}
case 903:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=906;continue;}
case 906:{f.StackOp("dup");f.Pc=907;continue;}
case 907:{f.Push(JValue.R(rt.String("ProtectingPlayer")));f.Pc=910;continue;}
case 910:{f.Push(JValue.I(50));f.Pc=912;continue;}
case 912:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=915;continue;}
case 915:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",918);}
case 918:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ProtectingPlayer","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ProtectingPlayer","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=921;continue;}
case 921:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=924;continue;}
case 924:{f.StackOp("dup");f.Pc=925;continue;}
case 925:{f.Push(JValue.R(rt.String("ChosenDirection")));f.Pc=928;continue;}
case 928:{f.Push(JValue.I(51));f.Pc=930;continue;}
case 930:{f.Push(JValue.R(rt.ClassObject("forge/game/Direction")));f.Pc=933;continue;}
case 933:{return rt.Call(f,"forge/trackable/TrackableTypes","EnumType","(Ljava/lang/Class;)Lforge/trackable/TrackableTypes$TrackableType;","invokestatic",936);}
case 936:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",939);}
case 939:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenDirection","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ChosenDirection","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=942;continue;}
case 942:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=945;continue;}
case 945:{f.StackOp("dup");f.Pc=946;continue;}
case 946:{f.Push(JValue.R(rt.String("ChosenEvenOdd")));f.Pc=949;continue;}
case 949:{f.Push(JValue.I(52));f.Pc=951;continue;}
case 951:{f.Push(JValue.R(rt.ClassObject("forge/game/EvenOdd")));f.Pc=954;continue;}
case 954:{return rt.Call(f,"forge/trackable/TrackableTypes","EnumType","(Ljava/lang/Class;)Lforge/trackable/TrackableTypes$TrackableType;","invokestatic",957);}
case 957:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",960);}
case 960:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenEvenOdd","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ChosenEvenOdd","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=963;continue;}
case 963:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=966;continue;}
case 966:{f.StackOp("dup");f.Pc=967;continue;}
case 967:{f.Push(JValue.R(rt.String("ChosenMode")));f.Pc=970;continue;}
case 970:{f.Push(JValue.I(53));f.Pc=972;continue;}
case 972:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=975;continue;}
case 975:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",978);}
case 978:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChosenMode","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ChosenMode","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=981;continue;}
case 981:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=984;continue;}
case 984:{f.StackOp("dup");f.Pc=985;continue;}
case 985:{f.Push(JValue.R(rt.String("Sector")));f.Pc=988;continue;}
case 988:{f.Push(JValue.I(54));f.Pc=990;continue;}
case 990:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=993;continue;}
case 993:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",996);}
case 996:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Sector","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Sector","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=999;continue;}
case 999:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1002;continue;}
case 1002:{f.StackOp("dup");f.Pc=1003;continue;}
case 1003:{f.Push(JValue.R(rt.String("Sprocket")));f.Pc=1006;continue;}
case 1006:{f.Push(JValue.I(55));f.Pc=1008;continue;}
case 1008:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1011;continue;}
case 1011:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1014);}
case 1014:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Sprocket","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Sprocket","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1017;continue;}
case 1017:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1020;continue;}
case 1020:{f.StackOp("dup");f.Pc=1021;continue;}
case 1021:{f.Push(JValue.R(rt.String("DraftAction")));f.Pc=1024;continue;}
case 1024:{f.Push(JValue.I(56));f.Pc=1026;continue;}
case 1026:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringListType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringListType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1029;continue;}
case 1029:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1032);}
case 1032:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","DraftAction","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","DraftAction","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1035;continue;}
case 1035:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1038;continue;}
case 1038:{f.StackOp("dup");f.Pc=1039;continue;}
case 1039:{f.Push(JValue.R(rt.String("ClassLevel")));f.Pc=1042;continue;}
case 1042:{f.Push(JValue.I(57));f.Pc=1044;continue;}
case 1044:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1047;continue;}
case 1047:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1050);}
case 1050:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ClassLevel","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ClassLevel","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1053;continue;}
case 1053:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1056;continue;}
case 1056:{f.StackOp("dup");f.Pc=1057;continue;}
case 1057:{f.Push(JValue.R(rt.String("RingLevel")));f.Pc=1060;continue;}
case 1060:{f.Push(JValue.I(58));f.Pc=1062;continue;}
case 1062:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1065;continue;}
case 1065:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1068);}
case 1068:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","RingLevel","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","RingLevel","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1071;continue;}
case 1071:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1074;continue;}
case 1074:{f.StackOp("dup");f.Pc=1075;continue;}
case 1075:{f.Push(JValue.R(rt.String("CurrentRoom")));f.Pc=1078;continue;}
case 1078:{f.Push(JValue.I(59));f.Pc=1080;continue;}
case 1080:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1083;continue;}
case 1083:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1086);}
case 1086:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CurrentRoom","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","CurrentRoom","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1089;continue;}
case 1089:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1092;continue;}
case 1092:{f.StackOp("dup");f.Pc=1093;continue;}
case 1093:{f.Push(JValue.R(rt.String("Intensity")));f.Pc=1096;continue;}
case 1096:{f.Push(JValue.I(60));f.Pc=1098;continue;}
case 1098:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1101;continue;}
case 1101:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1104);}
case 1104:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Intensity","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Intensity","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1107;continue;}
case 1107:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1110;continue;}
case 1110:{f.StackOp("dup");f.Pc=1111;continue;}
case 1111:{f.Push(JValue.R(rt.String("OverlayText")));f.Pc=1114;continue;}
case 1114:{f.Push(JValue.I(61));f.Pc=1116;continue;}
case 1116:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1119;continue;}
case 1119:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1122);}
case 1122:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OverlayText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","OverlayText","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1125;continue;}
case 1125:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1128;continue;}
case 1128:{f.StackOp("dup");f.Pc=1129;continue;}
case 1129:{f.Push(JValue.R(rt.String("MarkerText")));f.Pc=1132;continue;}
case 1132:{f.Push(JValue.I(62));f.Pc=1134;continue;}
case 1134:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringListType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringListType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1137;continue;}
case 1137:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1140);}
case 1140:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MarkerText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","MarkerText","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1143;continue;}
case 1143:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1146;continue;}
case 1146:{f.StackOp("dup");f.Pc=1147;continue;}
case 1147:{f.Push(JValue.R(rt.String("Remembered")));f.Pc=1150;continue;}
case 1150:{f.Push(JValue.I(63));f.Pc=1152;continue;}
case 1152:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1155;continue;}
case 1155:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1158);}
case 1158:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Remembered","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Remembered","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1161;continue;}
case 1161:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1164;continue;}
case 1164:{f.StackOp("dup");f.Pc=1165;continue;}
case 1165:{f.Push(JValue.R(rt.String("NamedCard")));f.Pc=1168;continue;}
case 1168:{f.Push(JValue.I(64));f.Pc=1170;continue;}
case 1170:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringListType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringListType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1173;continue;}
case 1173:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1176);}
case 1176:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NamedCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","NamedCard","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1179;continue;}
case 1179:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1182;continue;}
case 1182:{f.StackOp("dup");f.Pc=1183;continue;}
case 1183:{f.Push(JValue.R(rt.String("PlayerMayLook")));f.Pc=1186;continue;}
case 1186:{f.Push(JValue.I(65));f.Pc=1188;continue;}
case 1188:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","PlayerViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","PlayerViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=1191;continue;}
case 1191:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=1194;continue;}
case 1194:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",1197);}
case 1197:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PlayerMayLook","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","PlayerMayLook","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1200;continue;}
case 1200:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1203;continue;}
case 1203:{f.StackOp("dup");f.Pc=1204;continue;}
case 1204:{f.Push(JValue.R(rt.String("EntityAttachedTo")));f.Pc=1207;continue;}
case 1207:{f.Push(JValue.I(66));f.Pc=1209;continue;}
case 1209:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","GameEntityViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","GameEntityViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=1212;continue;}
case 1212:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1215);}
case 1215:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","EntityAttachedTo","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","EntityAttachedTo","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1218;continue;}
case 1218:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1221;continue;}
case 1221:{f.StackOp("dup");f.Pc=1222;continue;}
case 1222:{f.Push(JValue.R(rt.String("EncodedCards")));f.Pc=1225;continue;}
case 1225:{f.Push(JValue.I(67));f.Pc=1227;continue;}
case 1227:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=1230;continue;}
case 1230:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1233);}
case 1233:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","EncodedCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","EncodedCards","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1236;continue;}
case 1236:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1239;continue;}
case 1239:{f.StackOp("dup");f.Pc=1240;continue;}
case 1240:{f.Push(JValue.R(rt.String("UntilLeavesBattlefield")));f.Pc=1243;continue;}
case 1243:{f.Push(JValue.I(68));f.Pc=1245;continue;}
case 1245:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=1248;continue;}
case 1248:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1251);}
case 1251:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","UntilLeavesBattlefield","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","UntilLeavesBattlefield","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1254;continue;}
case 1254:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1257;continue;}
case 1257:{f.StackOp("dup");f.Pc=1258;continue;}
case 1258:{f.Push(JValue.R(rt.String("GainControlTargets")));f.Pc=1261;continue;}
case 1261:{f.Push(JValue.I(69));f.Pc=1263;continue;}
case 1263:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=1266;continue;}
case 1266:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1269);}
case 1269:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","GainControlTargets","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","GainControlTargets","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1272;continue;}
case 1272:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1275;continue;}
case 1275:{f.StackOp("dup");f.Pc=1276;continue;}
case 1276:{f.Push(JValue.R(rt.String("CloneOrigin")));f.Pc=1279;continue;}
case 1279:{f.Push(JValue.I(70));f.Pc=1281;continue;}
case 1281:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=1284;continue;}
case 1284:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1287);}
case 1287:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CloneOrigin","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","CloneOrigin","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1290;continue;}
case 1290:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1293;continue;}
case 1293:{f.StackOp("dup");f.Pc=1294;continue;}
case 1294:{f.Push(JValue.R(rt.String("ExiledWith")));f.Pc=1297;continue;}
case 1297:{f.Push(JValue.I(71));f.Pc=1299;continue;}
case 1299:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=1302;continue;}
case 1302:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1305);}
case 1305:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ExiledWith","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ExiledWith","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1308;continue;}
case 1308:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1311;continue;}
case 1311:{f.StackOp("dup");f.Pc=1312;continue;}
case 1312:{f.Push(JValue.R(rt.String("PreparedSpell")));f.Pc=1315;continue;}
case 1315:{f.Push(JValue.I(72));f.Pc=1317;continue;}
case 1317:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=1320;continue;}
case 1320:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1323);}
case 1323:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PreparedSpell","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","PreparedSpell","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1326;continue;}
case 1326:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1329;continue;}
case 1329:{f.StackOp("dup");f.Pc=1330;continue;}
case 1330:{f.Push(JValue.R(rt.String("MarkedColors")));f.Pc=1333;continue;}
case 1333:{f.Push(JValue.I(73));f.Pc=1335;continue;}
case 1335:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","ColorSetType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","ColorSetType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1338;continue;}
case 1338:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1341);}
case 1341:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MarkedColors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","MarkedColors","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1344;continue;}
case 1344:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1347;continue;}
case 1347:{f.StackOp("dup");f.Pc=1348;continue;}
case 1348:{f.Push(JValue.R(rt.String("ImprintedCards")));f.Pc=1351;continue;}
case 1351:{f.Push(JValue.I(74));f.Pc=1353;continue;}
case 1353:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=1356;continue;}
case 1356:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1359);}
case 1359:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ImprintedCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ImprintedCards","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1362;continue;}
case 1362:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1365;continue;}
case 1365:{f.StackOp("dup");f.Pc=1366;continue;}
case 1366:{f.Push(JValue.R(rt.String("ExiledCards")));f.Pc=1369;continue;}
case 1369:{f.Push(JValue.I(75));f.Pc=1371;continue;}
case 1371:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=1374;continue;}
case 1374:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1377);}
case 1377:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ExiledCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ExiledCards","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1380;continue;}
case 1380:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1383;continue;}
case 1383:{f.StackOp("dup");f.Pc=1384;continue;}
case 1384:{f.Push(JValue.R(rt.String("HauntedBy")));f.Pc=1387;continue;}
case 1387:{f.Push(JValue.I(76));f.Pc=1389;continue;}
case 1389:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=1392;continue;}
case 1392:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1395);}
case 1395:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HauntedBy","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","HauntedBy","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1398;continue;}
case 1398:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1401;continue;}
case 1401:{f.StackOp("dup");f.Pc=1402;continue;}
case 1402:{f.Push(JValue.R(rt.String("Haunting")));f.Pc=1405;continue;}
case 1405:{f.Push(JValue.I(77));f.Pc=1407;continue;}
case 1407:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=1410;continue;}
case 1410:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1413);}
case 1413:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Haunting","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Haunting","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1416;continue;}
case 1416:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1419;continue;}
case 1419:{f.StackOp("dup");f.Pc=1420;continue;}
case 1420:{f.Push(JValue.R(rt.String("MustBlockCards")));f.Pc=1423;continue;}
case 1423:{f.Push(JValue.I(78));f.Pc=1425;continue;}
case 1425:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=1428;continue;}
case 1428:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1431);}
case 1431:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MustBlockCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","MustBlockCards","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1434;continue;}
case 1434:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1437;continue;}
case 1437:{f.StackOp("dup");f.Pc=1438;continue;}
case 1438:{f.Push(JValue.R(rt.String("PairedWith")));f.Pc=1441;continue;}
case 1441:{f.Push(JValue.I(79));f.Pc=1443;continue;}
case 1443:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=1446;continue;}
case 1446:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1449);}
case 1449:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PairedWith","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","PairedWith","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1452;continue;}
case 1452:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1455;continue;}
case 1455:{f.StackOp("dup");f.Pc=1456;continue;}
case 1456:{f.Push(JValue.R(rt.String("CurrentState")));f.Pc=1459;continue;}
case 1459:{f.Push(JValue.I(80));f.Pc=1461;continue;}
case 1461:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardStateViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardStateViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=1464;continue;}
case 1464:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=1467;continue;}
case 1467:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",1470);}
case 1470:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CurrentState","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","CurrentState","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1473;continue;}
case 1473:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1476;continue;}
case 1476:{f.StackOp("dup");f.Pc=1477;continue;}
case 1477:{f.Push(JValue.R(rt.String("AlternateState")));f.Pc=1480;continue;}
case 1480:{f.Push(JValue.I(81));f.Pc=1482;continue;}
case 1482:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardStateViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardStateViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=1485;continue;}
case 1485:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=1488;continue;}
case 1488:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",1491);}
case 1491:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AlternateState","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","AlternateState","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1494;continue;}
case 1494:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1497;continue;}
case 1497:{f.StackOp("dup");f.Pc=1498;continue;}
case 1498:{f.Push(JValue.R(rt.String("LeftSplitState")));f.Pc=1501;continue;}
case 1501:{f.Push(JValue.I(82));f.Pc=1503;continue;}
case 1503:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardStateViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardStateViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=1506;continue;}
case 1506:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=1509;continue;}
case 1509:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",1512);}
case 1512:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","LeftSplitState","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","LeftSplitState","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1515;continue;}
case 1515:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1518;continue;}
case 1518:{f.StackOp("dup");f.Pc=1519;continue;}
case 1519:{f.Push(JValue.R(rt.String("RightSplitState")));f.Pc=1522;continue;}
case 1522:{f.Push(JValue.I(83));f.Pc=1524;continue;}
case 1524:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardStateViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardStateViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=1527;continue;}
case 1527:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=1530;continue;}
case 1530:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",1533);}
case 1533:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","RightSplitState","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","RightSplitState","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1536;continue;}
case 1536:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1539;continue;}
case 1539:{f.StackOp("dup");f.Pc=1540;continue;}
case 1540:{f.Push(JValue.R(rt.String("Room")));f.Pc=1543;continue;}
case 1543:{f.Push(JValue.I(84));f.Pc=1545;continue;}
case 1545:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1548;continue;}
case 1548:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=1551;continue;}
case 1551:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",1554);}
case 1554:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Room","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Room","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1557;continue;}
case 1557:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1560;continue;}
case 1560:{f.StackOp("dup");f.Pc=1561;continue;}
case 1561:{f.Push(JValue.R(rt.String("HiddenId")));f.Pc=1564;continue;}
case 1564:{f.Push(JValue.I(85));f.Pc=1566;continue;}
case 1566:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1569;continue;}
case 1569:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1572);}
case 1572:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HiddenId","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","HiddenId","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1575;continue;}
case 1575:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1578;continue;}
case 1578:{f.StackOp("dup");f.Pc=1579;continue;}
case 1579:{f.Push(JValue.R(rt.String("ExertedThisTurn")));f.Pc=1582;continue;}
case 1582:{f.Push(JValue.I(86));f.Pc=1584;continue;}
case 1584:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1587;continue;}
case 1587:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1590);}
case 1590:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ExertedThisTurn","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ExertedThisTurn","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1593;continue;}
case 1593:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1596;continue;}
case 1596:{f.StackOp("dup");f.Pc=1597;continue;}
case 1597:{f.Push(JValue.R(rt.String("Detained")));f.Pc=1600;continue;}
case 1600:{f.Push(JValue.I(87));f.Pc=1602;continue;}
case 1602:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1605;continue;}
case 1605:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1608);}
case 1608:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Detained","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Detained","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1611;continue;}
case 1611:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1614;continue;}
case 1614:{f.StackOp("dup");f.Pc=1615;continue;}
case 1615:{f.Push(JValue.R(rt.String("Name")));f.Pc=1618;continue;}
case 1618:{f.Push(JValue.I(88));f.Pc=1620;continue;}
case 1620:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1623;continue;}
case 1623:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1626);}
case 1626:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Name","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Name","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1629;continue;}
case 1629:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1632;continue;}
case 1632:{f.StackOp("dup");f.Pc=1633;continue;}
case 1633:{f.Push(JValue.R(rt.String("OracleName")));f.Pc=1636;continue;}
case 1636:{f.Push(JValue.I(89));f.Pc=1638;continue;}
case 1638:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1641;continue;}
case 1641:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1644);}
case 1644:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OracleName","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","OracleName","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1647;continue;}
case 1647:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1650;continue;}
case 1650:{f.StackOp("dup");f.Pc=1651;continue;}
case 1651:{f.Push(JValue.R(rt.String("ImageKey")));f.Pc=1654;continue;}
case 1654:{f.Push(JValue.I(90));f.Pc=1656;continue;}
case 1656:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1659;continue;}
case 1659:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1662);}
case 1662:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ImageKey","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ImageKey","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1665;continue;}
case 1665:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1668;continue;}
case 1668:{f.StackOp("dup");f.Pc=1669;continue;}
case 1669:{f.Push(JValue.R(rt.String("Colors")));f.Pc=1672;continue;}
case 1672:{f.Push(JValue.I(91));f.Pc=1674;continue;}
case 1674:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","ColorSetType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","ColorSetType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1677;continue;}
case 1677:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1680);}
case 1680:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Colors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Colors","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1683;continue;}
case 1683:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1686;continue;}
case 1686:{f.StackOp("dup");f.Pc=1687;continue;}
case 1687:{f.Push(JValue.R(rt.String("OriginalColors")));f.Pc=1690;continue;}
case 1690:{f.Push(JValue.I(92));f.Pc=1692;continue;}
case 1692:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","ColorSetType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","ColorSetType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1695;continue;}
case 1695:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1698);}
case 1698:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OriginalColors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","OriginalColors","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1701;continue;}
case 1701:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1704;continue;}
case 1704:{f.StackOp("dup");f.Pc=1705;continue;}
case 1705:{f.Push(JValue.R(rt.String("Type")));f.Pc=1708;continue;}
case 1708:{f.Push(JValue.I(93));f.Pc=1710;continue;}
case 1710:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardTypeViewType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardTypeViewType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1713;continue;}
case 1713:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1716);}
case 1716:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Type","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Type","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1719;continue;}
case 1719:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1722;continue;}
case 1722:{f.StackOp("dup");f.Pc=1723;continue;}
case 1723:{f.Push(JValue.R(rt.String("ManaCost")));f.Pc=1726;continue;}
case 1726:{f.Push(JValue.I(94));f.Pc=1728;continue;}
case 1728:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","ManaCostType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","ManaCostType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1731;continue;}
case 1731:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1734);}
case 1734:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ManaCost","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ManaCost","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1737;continue;}
case 1737:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1740;continue;}
case 1740:{f.StackOp("dup");f.Pc=1741;continue;}
case 1741:{f.Push(JValue.R(rt.String("OriginalManaCost")));f.Pc=1744;continue;}
case 1744:{f.Push(JValue.I(95));f.Pc=1746;continue;}
case 1746:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","ManaCostType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","ManaCostType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1749;continue;}
case 1749:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1752);}
case 1752:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OriginalManaCost","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","OriginalManaCost","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1755;continue;}
case 1755:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1758;continue;}
case 1758:{f.StackOp("dup");f.Pc=1759;continue;}
case 1759:{f.Push(JValue.R(rt.String("SetCode")));f.Pc=1762;continue;}
case 1762:{f.Push(JValue.I(96));f.Pc=1764;continue;}
case 1764:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1767;continue;}
case 1767:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1770);}
case 1770:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SetCode","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","SetCode","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1773;continue;}
case 1773:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1776;continue;}
case 1776:{f.StackOp("dup");f.Pc=1777;continue;}
case 1777:{f.Push(JValue.R(rt.String("Rarity")));f.Pc=1780;continue;}
case 1780:{f.Push(JValue.I(97));f.Pc=1782;continue;}
case 1782:{f.Push(JValue.R(rt.ClassObject("forge/card/CardRarity")));f.Pc=1785;continue;}
case 1785:{return rt.Call(f,"forge/trackable/TrackableTypes","EnumType","(Ljava/lang/Class;)Lforge/trackable/TrackableTypes$TrackableType;","invokestatic",1788);}
case 1788:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1791);}
case 1791:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Rarity","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Rarity","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1794;continue;}
case 1794:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1797;continue;}
case 1797:{f.StackOp("dup");f.Pc=1798;continue;}
case 1798:{f.Push(JValue.R(rt.String("OracleText")));f.Pc=1801;continue;}
case 1801:{f.Push(JValue.I(98));f.Pc=1803;continue;}
case 1803:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1806;continue;}
case 1806:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1809);}
case 1809:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OracleText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","OracleText","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1812;continue;}
case 1812:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1815;continue;}
case 1815:{f.StackOp("dup");f.Pc=1816;continue;}
case 1816:{f.Push(JValue.R(rt.String("RulesText")));f.Pc=1819;continue;}
case 1819:{f.Push(JValue.I(99));f.Pc=1821;continue;}
case 1821:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1824;continue;}
case 1824:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1827);}
case 1827:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","RulesText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","RulesText","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1830;continue;}
case 1830:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1833;continue;}
case 1833:{f.StackOp("dup");f.Pc=1834;continue;}
case 1834:{f.Push(JValue.R(rt.String("HasPrintedPT")));f.Pc=1837;continue;}
case 1837:{f.Push(JValue.I(100));f.Pc=1839;continue;}
case 1839:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1842;continue;}
case 1842:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1845);}
case 1845:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasPrintedPT","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","HasPrintedPT","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1848;continue;}
case 1848:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1851;continue;}
case 1851:{f.StackOp("dup");f.Pc=1852;continue;}
case 1852:{f.Push(JValue.R(rt.String("Power")));f.Pc=1855;continue;}
case 1855:{f.Push(JValue.I(101));f.Pc=1857;continue;}
case 1857:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1860;continue;}
case 1860:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1863);}
case 1863:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Power","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Power","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1866;continue;}
case 1866:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1869;continue;}
case 1869:{f.StackOp("dup");f.Pc=1870;continue;}
case 1870:{f.Push(JValue.R(rt.String("Toughness")));f.Pc=1873;continue;}
case 1873:{f.Push(JValue.I(102));f.Pc=1875;continue;}
case 1875:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1878;continue;}
case 1878:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1881);}
case 1881:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Toughness","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Toughness","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1884;continue;}
case 1884:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1887;continue;}
case 1887:{f.StackOp("dup");f.Pc=1888;continue;}
case 1888:{f.Push(JValue.R(rt.String("Loyalty")));f.Pc=1891;continue;}
case 1891:{f.Push(JValue.I(103));f.Pc=1893;continue;}
case 1893:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1896;continue;}
case 1896:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1899);}
case 1899:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Loyalty","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Loyalty","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1902;continue;}
case 1902:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1905;continue;}
case 1905:{f.StackOp("dup");f.Pc=1906;continue;}
case 1906:{f.Push(JValue.R(rt.String("Defense")));f.Pc=1909;continue;}
case 1909:{f.Push(JValue.I(104));f.Pc=1911;continue;}
case 1911:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1914;continue;}
case 1914:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1917);}
case 1917:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Defense","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Defense","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1920;continue;}
case 1920:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1923;continue;}
case 1923:{f.StackOp("dup");f.Pc=1924;continue;}
case 1924:{f.Push(JValue.R(rt.String("FunctionalVariant")));f.Pc=1927;continue;}
case 1927:{f.Push(JValue.I(105));f.Pc=1929;continue;}
case 1929:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1932;continue;}
case 1932:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1935);}
case 1935:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","FunctionalVariant","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","FunctionalVariant","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1938;continue;}
case 1938:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1941;continue;}
case 1941:{f.StackOp("dup");f.Pc=1942;continue;}
case 1942:{f.Push(JValue.R(rt.String("AttractionLights")));f.Pc=1945;continue;}
case 1945:{f.Push(JValue.I(106));f.Pc=1947;continue;}
case 1947:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerSetType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerSetType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1950;continue;}
case 1950:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1953);}
case 1953:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttractionLights","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","AttractionLights","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1956;continue;}
case 1956:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1959;continue;}
case 1959:{f.StackOp("dup");f.Pc=1960;continue;}
case 1960:{f.Push(JValue.R(rt.String("ChangedColorWords")));f.Pc=1963;continue;}
case 1963:{f.Push(JValue.I(107));f.Pc=1965;continue;}
case 1965:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringMapType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringMapType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1968;continue;}
case 1968:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1971);}
case 1971:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChangedColorWords","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ChangedColorWords","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1974;continue;}
case 1974:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1977;continue;}
case 1977:{f.StackOp("dup");f.Pc=1978;continue;}
case 1978:{f.Push(JValue.R(rt.String("HasChangedColors")));f.Pc=1981;continue;}
case 1981:{f.Push(JValue.I(108));f.Pc=1983;continue;}
case 1983:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=1986;continue;}
case 1986:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",1989);}
case 1989:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasChangedColors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","HasChangedColors","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=1992;continue;}
case 1992:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=1995;continue;}
case 1995:{f.StackOp("dup");f.Pc=1996;continue;}
case 1996:{f.Push(JValue.R(rt.String("ChangedTypes")));f.Pc=1999;continue;}
case 1999:{f.Push(JValue.I(109));f.Pc=2001;continue;}
case 2001:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringMapType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringMapType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2004;continue;}
case 2004:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2007);}
case 2007:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ChangedTypes","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ChangedTypes","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2010;continue;}
case 2010:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2013;continue;}
case 2013:{f.StackOp("dup");f.Pc=2014;continue;}
case 2014:{f.Push(JValue.R(rt.String("OrigProduceMana")));f.Pc=2017;continue;}
case 2017:{f.Push(JValue.I(110));f.Pc=2019;continue;}
case 2019:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","ColorSetType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","ColorSetType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2022;continue;}
case 2022:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2025);}
case 2025:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OrigProduceMana","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","OrigProduceMana","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2028;continue;}
case 2028:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2031;continue;}
case 2031:{f.StackOp("dup");f.Pc=2032;continue;}
case 2032:{f.Push(JValue.R(rt.String("OrigProduceAnyMana")));f.Pc=2035;continue;}
case 2035:{f.Push(JValue.I(111));f.Pc=2037;continue;}
case 2037:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2040;continue;}
case 2040:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2043);}
case 2043:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OrigProduceAnyMana","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","OrigProduceAnyMana","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2046;continue;}
case 2046:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2049;continue;}
case 2049:{f.StackOp("dup");f.Pc=2050;continue;}
case 2050:{f.Push(JValue.R(rt.String("Keywords")));f.Pc=2053;continue;}
case 2053:{f.Push(JValue.I(112));f.Pc=2055;continue;}
case 2055:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","KeywordCollectionViewType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","KeywordCollectionViewType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2058;continue;}
case 2058:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2061);}
case 2061:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Keywords","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Keywords","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2064;continue;}
case 2064:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2067;continue;}
case 2067:{f.StackOp("dup");f.Pc=2068;continue;}
case 2068:{f.Push(JValue.R(rt.String("HasAnnihilator")));f.Pc=2071;continue;}
case 2071:{f.Push(JValue.I(113));f.Pc=2073;continue;}
case 2073:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2076;continue;}
case 2076:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2079);}
case 2079:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasAnnihilator","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","HasAnnihilator","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2082;continue;}
case 2082:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2085;continue;}
case 2085:{f.StackOp("dup");f.Pc=2086;continue;}
case 2086:{f.Push(JValue.R(rt.String("HasWard")));f.Pc=2089;continue;}
case 2089:{f.Push(JValue.I(114));f.Pc=2091;continue;}
case 2091:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2094;continue;}
case 2094:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2097);}
case 2097:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasWard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","HasWard","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2100;continue;}
case 2100:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2103;continue;}
case 2103:{f.StackOp("dup");f.Pc=2104;continue;}
case 2104:{f.Push(JValue.R(rt.String("BlockAdditional")));f.Pc=2107;continue;}
case 2107:{f.Push(JValue.I(115));f.Pc=2109;continue;}
case 2109:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2112;continue;}
case 2112:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2115);}
case 2115:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","BlockAdditional","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","BlockAdditional","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2118;continue;}
case 2118:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2121;continue;}
case 2121:{f.StackOp("dup");f.Pc=2122;continue;}
case 2122:{f.Push(JValue.R(rt.String("BlockAny")));f.Pc=2125;continue;}
case 2125:{f.Push(JValue.I(116));f.Pc=2127;continue;}
case 2127:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2130;continue;}
case 2130:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2133);}
case 2133:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","BlockAny","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","BlockAny","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2136;continue;}
case 2136:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2139;continue;}
case 2139:{f.StackOp("dup");f.Pc=2140;continue;}
case 2140:{f.Push(JValue.R(rt.String("AbilityText")));f.Pc=2143;continue;}
case 2143:{f.Push(JValue.I(117));f.Pc=2145;continue;}
case 2145:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2148;continue;}
case 2148:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2151);}
case 2151:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AbilityText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","AbilityText","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2154;continue;}
case 2154:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2157;continue;}
case 2157:{f.StackOp("dup");f.Pc=2158;continue;}
case 2158:{f.Push(JValue.R(rt.String("NonAbilityText")));f.Pc=2161;continue;}
case 2161:{f.Push(JValue.I(118));f.Pc=2163;continue;}
case 2163:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2166;continue;}
case 2166:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2169);}
case 2169:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NonAbilityText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","NonAbilityText","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2172;continue;}
case 2172:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2175;continue;}
case 2175:{f.StackOp("dup");f.Pc=2176;continue;}
case 2176:{f.Push(JValue.R(rt.String("HasDivideDamage")));f.Pc=2179;continue;}
case 2179:{f.Push(JValue.I(119));f.Pc=2181;continue;}
case 2181:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2184;continue;}
case 2184:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2187);}
case 2187:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasDivideDamage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","HasDivideDamage","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2190;continue;}
case 2190:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2193;continue;}
case 2193:{f.StackOp("dup");f.Pc=2194;continue;}
case 2194:{f.Push(JValue.R(rt.String("FoilIndex")));f.Pc=2197;continue;}
case 2197:{f.Push(JValue.I(120));f.Pc=2199;continue;}
case 2199:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2202;continue;}
case 2202:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2205);}
case 2205:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","FoilIndex","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","FoilIndex","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2208;continue;}
case 2208:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2211;continue;}
case 2211:{f.StackOp("dup");f.Pc=2212;continue;}
case 2212:{f.Push(JValue.R(rt.String("CantHaveKeyword")));f.Pc=2215;continue;}
case 2215:{f.Push(JValue.I(121));f.Pc=2217;continue;}
case 2217:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringSetType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringSetType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2220;continue;}
case 2220:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2223);}
case 2223:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CantHaveKeyword","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","CantHaveKeyword","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2226;continue;}
case 2226:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2229;continue;}
case 2229:{f.StackOp("dup");f.Pc=2230;continue;}
case 2230:{f.Push(JValue.R(rt.String("IsAI")));f.Pc=2233;continue;}
case 2233:{f.Push(JValue.I(122));f.Pc=2235;continue;}
case 2235:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2238;continue;}
case 2238:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2241);}
case 2241:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsAI","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","IsAI","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2244;continue;}
case 2244:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2247;continue;}
case 2247:{f.StackOp("dup");f.Pc=2248;continue;}
case 2248:{f.Push(JValue.R(rt.String("LobbyPlayerName")));f.Pc=2251;continue;}
case 2251:{f.Push(JValue.I(123));f.Pc=2253;continue;}
case 2253:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2256;continue;}
case 2256:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2259);}
case 2259:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","LobbyPlayerName","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","LobbyPlayerName","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2262;continue;}
case 2262:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2265;continue;}
case 2265:{f.StackOp("dup");f.Pc=2266;continue;}
case 2266:{f.Push(JValue.R(rt.String("AvatarIndex")));f.Pc=2269;continue;}
case 2269:{f.Push(JValue.I(124));f.Pc=2271;continue;}
case 2271:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2274;continue;}
case 2274:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2277);}
case 2277:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AvatarIndex","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","AvatarIndex","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2280;continue;}
case 2280:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2283;continue;}
case 2283:{f.StackOp("dup");f.Pc=2284;continue;}
case 2284:{f.Push(JValue.R(rt.String("AvatarCardImageKey")));f.Pc=2287;continue;}
case 2287:{f.Push(JValue.I(125));f.Pc=2289;continue;}
case 2289:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2292;continue;}
case 2292:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2295);}
case 2295:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AvatarCardImageKey","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","AvatarCardImageKey","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2298;continue;}
case 2298:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2301;continue;}
case 2301:{f.StackOp("dup");f.Pc=2302;continue;}
case 2302:{f.Push(JValue.R(rt.String("SleeveIndex")));f.Pc=2305;continue;}
case 2305:{f.Push(JValue.I(126));f.Pc=2307;continue;}
case 2307:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2310;continue;}
case 2310:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2313);}
case 2313:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SleeveIndex","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","SleeveIndex","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2316;continue;}
case 2316:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2319;continue;}
case 2319:{f.StackOp("dup");f.Pc=2320;continue;}
case 2320:{f.Push(JValue.R(rt.String("SleeveArtKey")));f.Pc=2323;continue;}
case 2323:{f.Push(JValue.I(127));f.Pc=2325;continue;}
case 2325:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2328;continue;}
case 2328:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2331);}
case 2331:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SleeveArtKey","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","SleeveArtKey","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2334;continue;}
case 2334:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2337;continue;}
case 2337:{f.StackOp("dup");f.Pc=2338;continue;}
case 2338:{f.Push(JValue.R(rt.String("SleeveArtOffset")));f.Pc=2341;continue;}
case 2341:{f.Push(JValue.I(128));f.Pc=2344;continue;}
case 2344:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2347;continue;}
case 2347:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2350);}
case 2350:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SleeveArtOffset","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","SleeveArtOffset","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2353;continue;}
case 2353:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2356;continue;}
case 2356:{f.StackOp("dup");f.Pc=2357;continue;}
case 2357:{f.Push(JValue.R(rt.String("Opponents")));f.Pc=2360;continue;}
case 2360:{f.Push(JValue.I(129));f.Pc=2363;continue;}
case 2363:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","PlayerViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","PlayerViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=2366;continue;}
case 2366:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2369);}
case 2369:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Opponents","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Opponents","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2372;continue;}
case 2372:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2375;continue;}
case 2375:{f.StackOp("dup");f.Pc=2376;continue;}
case 2376:{f.Push(JValue.R(rt.String("SharedTeam")));f.Pc=2379;continue;}
case 2379:{f.Push(JValue.I(130));f.Pc=2382;continue;}
case 2382:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","PlayerViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","PlayerViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=2385;continue;}
case 2385:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2388);}
case 2388:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SharedTeam","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","SharedTeam","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2391;continue;}
case 2391:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2394;continue;}
case 2394:{f.StackOp("dup");f.Pc=2395;continue;}
case 2395:{f.Push(JValue.R(rt.String("Life")));f.Pc=2398;continue;}
case 2398:{f.Push(JValue.I(131));f.Pc=2401;continue;}
case 2401:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2404;continue;}
case 2404:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2407);}
case 2407:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Life","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Life","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2410;continue;}
case 2410:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2413;continue;}
case 2413:{f.StackOp("dup");f.Pc=2414;continue;}
case 2414:{f.Push(JValue.R(rt.String("MaxHandSize")));f.Pc=2417;continue;}
case 2417:{f.Push(JValue.I(132));f.Pc=2420;continue;}
case 2420:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2423;continue;}
case 2423:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2426);}
case 2426:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MaxHandSize","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","MaxHandSize","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2429;continue;}
case 2429:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2432;continue;}
case 2432:{f.StackOp("dup");f.Pc=2433;continue;}
case 2433:{f.Push(JValue.R(rt.String("HasUnlimitedHandSize")));f.Pc=2436;continue;}
case 2436:{f.Push(JValue.I(133));f.Pc=2439;continue;}
case 2439:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2442;continue;}
case 2442:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2445);}
case 2445:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasUnlimitedHandSize","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","HasUnlimitedHandSize","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2448;continue;}
case 2448:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2451;continue;}
case 2451:{f.StackOp("dup");f.Pc=2452;continue;}
case 2452:{f.Push(JValue.R(rt.String("MaxLandPlay")));f.Pc=2455;continue;}
case 2455:{f.Push(JValue.I(134));f.Pc=2458;continue;}
case 2458:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2461;continue;}
case 2461:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2464);}
case 2464:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MaxLandPlay","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","MaxLandPlay","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2467;continue;}
case 2467:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2470;continue;}
case 2470:{f.StackOp("dup");f.Pc=2471;continue;}
case 2471:{f.Push(JValue.R(rt.String("HasUnlimitedLandPlay")));f.Pc=2474;continue;}
case 2474:{f.Push(JValue.I(135));f.Pc=2477;continue;}
case 2477:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2480;continue;}
case 2480:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2483);}
case 2483:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasUnlimitedLandPlay","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","HasUnlimitedLandPlay","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2486;continue;}
case 2486:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2489;continue;}
case 2489:{f.StackOp("dup");f.Pc=2490;continue;}
case 2490:{f.Push(JValue.R(rt.String("NumLandThisTurn")));f.Pc=2493;continue;}
case 2493:{f.Push(JValue.I(136));f.Pc=2496;continue;}
case 2496:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2499;continue;}
case 2499:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2502);}
case 2502:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NumLandThisTurn","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","NumLandThisTurn","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2505;continue;}
case 2505:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2508;continue;}
case 2508:{f.StackOp("dup");f.Pc=2509;continue;}
case 2509:{f.Push(JValue.R(rt.String("DraftNotes")));f.Pc=2512;continue;}
case 2512:{f.Push(JValue.I(137));f.Pc=2515;continue;}
case 2515:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringMapType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringMapType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2518;continue;}
case 2518:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2521);}
case 2521:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","DraftNotes","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","DraftNotes","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2524;continue;}
case 2524:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2527;continue;}
case 2527:{f.StackOp("dup");f.Pc=2528;continue;}
case 2528:{f.Push(JValue.R(rt.String("NumDrawnThisTurn")));f.Pc=2531;continue;}
case 2531:{f.Push(JValue.I(138));f.Pc=2534;continue;}
case 2534:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2537;continue;}
case 2537:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2540);}
case 2540:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NumDrawnThisTurn","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","NumDrawnThisTurn","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2543;continue;}
case 2543:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2546;continue;}
case 2546:{f.StackOp("dup");f.Pc=2547;continue;}
case 2547:{f.Push(JValue.R(rt.String("AdditionalVote")));f.Pc=2550;continue;}
case 2550:{f.Push(JValue.I(139));f.Pc=2553;continue;}
case 2553:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2556;continue;}
case 2556:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2559);}
case 2559:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AdditionalVote","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","AdditionalVote","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2562;continue;}
case 2562:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2565;continue;}
case 2565:{f.StackOp("dup");f.Pc=2566;continue;}
case 2566:{f.Push(JValue.R(rt.String("OptionalAdditionalVote")));f.Pc=2569;continue;}
case 2569:{f.Push(JValue.I(140));f.Pc=2572;continue;}
case 2572:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2575;continue;}
case 2575:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2578);}
case 2578:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OptionalAdditionalVote","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","OptionalAdditionalVote","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2581;continue;}
case 2581:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2584;continue;}
case 2584:{f.StackOp("dup");f.Pc=2585;continue;}
case 2585:{f.Push(JValue.R(rt.String("ControlVotes")));f.Pc=2588;continue;}
case 2588:{f.Push(JValue.I(141));f.Pc=2591;continue;}
case 2591:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2594;continue;}
case 2594:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2597);}
case 2597:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ControlVotes","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ControlVotes","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2600;continue;}
case 2600:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2603;continue;}
case 2603:{f.StackOp("dup");f.Pc=2604;continue;}
case 2604:{f.Push(JValue.R(rt.String("AdditionalVillainousChoices")));f.Pc=2607;continue;}
case 2607:{f.Push(JValue.I(142));f.Pc=2610;continue;}
case 2610:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2613;continue;}
case 2613:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2616);}
case 2616:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AdditionalVillainousChoices","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","AdditionalVillainousChoices","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2619;continue;}
case 2619:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2622;continue;}
case 2622:{f.StackOp("dup");f.Pc=2623;continue;}
case 2623:{f.Push(JValue.R(rt.String("Commander")));f.Pc=2626;continue;}
case 2626:{f.Push(JValue.I(143));f.Pc=2629;continue;}
case 2629:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=2632;continue;}
case 2632:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=2635;continue;}
case 2635:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",2638);}
case 2638:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Commander","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Commander","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2641;continue;}
case 2641:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2644;continue;}
case 2644:{f.StackOp("dup");f.Pc=2645;continue;}
case 2645:{f.Push(JValue.R(rt.String("CommanderCast")));f.Pc=2648;continue;}
case 2648:{f.Push(JValue.I(144));f.Pc=2651;continue;}
case 2651:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerMapType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerMapType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2654;continue;}
case 2654:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2657);}
case 2657:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CommanderCast","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","CommanderCast","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2660;continue;}
case 2660:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2663;continue;}
case 2663:{f.StackOp("dup");f.Pc=2664;continue;}
case 2664:{f.Push(JValue.R(rt.String("CommanderDamage")));f.Pc=2667;continue;}
case 2667:{f.Push(JValue.I(145));f.Pc=2670;continue;}
case 2670:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerMapType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerMapType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=2673;continue;}
case 2673:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2676);}
case 2676:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CommanderDamage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","CommanderDamage","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2679;continue;}
case 2679:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2682;continue;}
case 2682:{f.StackOp("dup");f.Pc=2683;continue;}
case 2683:{f.Push(JValue.R(rt.String("MindSlaveMaster")));f.Pc=2686;continue;}
case 2686:{f.Push(JValue.I(146));f.Pc=2689;continue;}
case 2689:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=2692;continue;}
case 2692:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",2695);}
case 2695:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MindSlaveMaster","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","MindSlaveMaster","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2698;continue;}
case 2698:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2701;continue;}
case 2701:{f.StackOp("dup");f.Pc=2702;continue;}
case 2702:{f.Push(JValue.R(rt.String("Ante")));f.Pc=2705;continue;}
case 2705:{f.Push(JValue.I(147));f.Pc=2708;continue;}
case 2708:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=2711;continue;}
case 2711:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=2714;continue;}
case 2714:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",2717);}
case 2717:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Ante","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Ante","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2720;continue;}
case 2720:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2723;continue;}
case 2723:{f.StackOp("dup");f.Pc=2724;continue;}
case 2724:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=2727;continue;}
case 2727:{f.Push(JValue.I(148));f.Pc=2730;continue;}
case 2730:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=2733;continue;}
case 2733:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=2736;continue;}
case 2736:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",2739);}
case 2739:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Battlefield","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Battlefield","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2742;continue;}
case 2742:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2745;continue;}
case 2745:{f.StackOp("dup");f.Pc=2746;continue;}
case 2746:{f.Push(JValue.R(rt.String("Command")));f.Pc=2749;continue;}
case 2749:{f.Push(JValue.I(149));f.Pc=2752;continue;}
case 2752:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=2755;continue;}
case 2755:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=2758;continue;}
case 2758:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",2761);}
case 2761:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Command","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Command","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2764;continue;}
case 2764:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2767;continue;}
case 2767:{f.StackOp("dup");f.Pc=2768;continue;}
case 2768:{f.Push(JValue.R(rt.String("Exile")));f.Pc=2771;continue;}
case 2771:{f.Push(JValue.I(150));f.Pc=2774;continue;}
case 2774:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=2777;continue;}
case 2777:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=2780;continue;}
case 2780:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",2783);}
case 2783:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Exile","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Exile","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2786;continue;}
case 2786:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2789;continue;}
case 2789:{f.StackOp("dup");f.Pc=2790;continue;}
case 2790:{f.Push(JValue.R(rt.String("Flashback")));f.Pc=2793;continue;}
case 2793:{f.Push(JValue.I(151));f.Pc=2796;continue;}
case 2796:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=2799;continue;}
case 2799:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=2802;continue;}
case 2802:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",2805);}
case 2805:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Flashback","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Flashback","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2808;continue;}
case 2808:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2811;continue;}
case 2811:{f.StackOp("dup");f.Pc=2812;continue;}
case 2812:{f.Push(JValue.R(rt.String("Graveyard")));f.Pc=2815;continue;}
case 2815:{f.Push(JValue.I(152));f.Pc=2818;continue;}
case 2818:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=2821;continue;}
case 2821:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=2824;continue;}
case 2824:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",2827);}
case 2827:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Graveyard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Graveyard","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2830;continue;}
case 2830:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2833;continue;}
case 2833:{f.StackOp("dup");f.Pc=2834;continue;}
case 2834:{f.Push(JValue.R(rt.String("Hand")));f.Pc=2837;continue;}
case 2837:{f.Push(JValue.I(153));f.Pc=2840;continue;}
case 2840:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=2843;continue;}
case 2843:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=2846;continue;}
case 2846:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",2849);}
case 2849:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Hand","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Hand","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2852;continue;}
case 2852:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2855;continue;}
case 2855:{f.StackOp("dup");f.Pc=2856;continue;}
case 2856:{f.Push(JValue.R(rt.String("Library")));f.Pc=2859;continue;}
case 2859:{f.Push(JValue.I(154));f.Pc=2862;continue;}
case 2862:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=2865;continue;}
case 2865:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=2868;continue;}
case 2868:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",2871);}
case 2871:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Library","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Library","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2874;continue;}
case 2874:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2877;continue;}
case 2877:{f.StackOp("dup");f.Pc=2878;continue;}
case 2878:{f.Push(JValue.R(rt.String("Sideboard")));f.Pc=2881;continue;}
case 2881:{f.Push(JValue.I(155));f.Pc=2884;continue;}
case 2884:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=2887;continue;}
case 2887:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=2890;continue;}
case 2890:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",2893);}
case 2893:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Sideboard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Sideboard","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2896;continue;}
case 2896:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2899;continue;}
case 2899:{f.StackOp("dup");f.Pc=2900;continue;}
case 2900:{f.Push(JValue.R(rt.String("PlanarDeck")));f.Pc=2903;continue;}
case 2903:{f.Push(JValue.I(156));f.Pc=2906;continue;}
case 2906:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=2909;continue;}
case 2909:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=2912;continue;}
case 2912:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",2915);}
case 2915:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PlanarDeck","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","PlanarDeck","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2918;continue;}
case 2918:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2921;continue;}
case 2921:{f.StackOp("dup");f.Pc=2922;continue;}
case 2922:{f.Push(JValue.R(rt.String("SchemeDeck")));f.Pc=2925;continue;}
case 2925:{f.Push(JValue.I(157));f.Pc=2928;continue;}
case 2928:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=2931;continue;}
case 2931:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=2934;continue;}
case 2934:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",2937);}
case 2937:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SchemeDeck","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","SchemeDeck","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2940;continue;}
case 2940:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2943;continue;}
case 2943:{f.StackOp("dup");f.Pc=2944;continue;}
case 2944:{f.Push(JValue.R(rt.String("AttractionDeck")));f.Pc=2947;continue;}
case 2947:{f.Push(JValue.I(158));f.Pc=2950;continue;}
case 2950:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=2953;continue;}
case 2953:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=2956;continue;}
case 2956:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",2959);}
case 2959:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttractionDeck","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","AttractionDeck","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2962;continue;}
case 2962:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2965;continue;}
case 2965:{f.StackOp("dup");f.Pc=2966;continue;}
case 2966:{f.Push(JValue.R(rt.String("ContraptionDeck")));f.Pc=2969;continue;}
case 2969:{f.Push(JValue.I(159));f.Pc=2972;continue;}
case 2972:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=2975;continue;}
case 2975:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=2978;continue;}
case 2978:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",2981);}
case 2981:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ContraptionDeck","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ContraptionDeck","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=2984;continue;}
case 2984:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=2987;continue;}
case 2987:{f.StackOp("dup");f.Pc=2988;continue;}
case 2988:{f.Push(JValue.R(rt.String("Junkyard")));f.Pc=2991;continue;}
case 2991:{f.Push(JValue.I(160));f.Pc=2994;continue;}
case 2994:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=2997;continue;}
case 2997:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=3000;continue;}
case 3000:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",3003);}
case 3003:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Junkyard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Junkyard","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3006;continue;}
case 3006:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3009;continue;}
case 3009:{f.StackOp("dup");f.Pc=3010;continue;}
case 3010:{f.Push(JValue.R(rt.String("StickerSheets")));f.Pc=3013;continue;}
case 3013:{f.Push(JValue.I(161));f.Pc=3016;continue;}
case 3016:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=3019;continue;}
case 3019:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=3022;continue;}
case 3022:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",3025);}
case 3025:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","StickerSheets","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","StickerSheets","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3028;continue;}
case 3028:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3031;continue;}
case 3031:{f.StackOp("dup");f.Pc=3032;continue;}
case 3032:{f.Push(JValue.R(rt.String("Stickers")));f.Pc=3035;continue;}
case 3035:{f.Push(JValue.I(162));f.Pc=3038;continue;}
case 3038:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3041;continue;}
case 3041:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3044);}
case 3044:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Stickers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Stickers","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3047;continue;}
case 3047:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3050;continue;}
case 3050:{f.StackOp("dup");f.Pc=3051;continue;}
case 3051:{f.Push(JValue.R(rt.String("Mana")));f.Pc=3054;continue;}
case 3054:{f.Push(JValue.I(163));f.Pc=3057;continue;}
case 3057:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","ManaMapType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","ManaMapType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3060;continue;}
case 3060:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=3063;continue;}
case 3063:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",3066);}
case 3066:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Mana","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Mana","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3069;continue;}
case 3069:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3072;continue;}
case 3072:{f.StackOp("dup");f.Pc=3073;continue;}
case 3073:{f.Push(JValue.R(rt.String("IsExtraTurn")));f.Pc=3076;continue;}
case 3076:{f.Push(JValue.I(164));f.Pc=3079;continue;}
case 3079:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3082;continue;}
case 3082:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3085);}
case 3085:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsExtraTurn","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","IsExtraTurn","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3088;continue;}
case 3088:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3091;continue;}
case 3091:{f.StackOp("dup");f.Pc=3092;continue;}
case 3092:{f.Push(JValue.R(rt.String("ExtraTurnCount")));f.Pc=3095;continue;}
case 3095:{f.Push(JValue.I(165));f.Pc=3098;continue;}
case 3098:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3101;continue;}
case 3101:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3104);}
case 3104:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ExtraTurnCount","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ExtraTurnCount","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3107;continue;}
case 3107:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3110;continue;}
case 3110:{f.StackOp("dup");f.Pc=3111;continue;}
case 3111:{f.Push(JValue.R(rt.String("HasPriority")));f.Pc=3114;continue;}
case 3114:{f.Push(JValue.I(166));f.Pc=3117;continue;}
case 3117:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3120;continue;}
case 3120:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=3123;continue;}
case 3123:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",3126);}
case 3126:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasPriority","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","HasPriority","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3129;continue;}
case 3129:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3132;continue;}
case 3132:{f.StackOp("dup");f.Pc=3133;continue;}
case 3133:{f.Push(JValue.R(rt.String("HasLost")));f.Pc=3136;continue;}
case 3136:{f.Push(JValue.I(167));f.Pc=3139;continue;}
case 3139:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3142;continue;}
case 3142:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3145);}
case 3145:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasLost","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","HasLost","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3148;continue;}
case 3148:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3151;continue;}
case 3151:{f.StackOp("dup");f.Pc=3152;continue;}
case 3152:{f.Push(JValue.R(rt.String("HasAvailableActions")));f.Pc=3155;continue;}
case 3155:{f.Push(JValue.I(168));f.Pc=3158;continue;}
case 3158:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3161;continue;}
case 3161:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3164);}
case 3164:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasAvailableActions","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","HasAvailableActions","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3167;continue;}
case 3167:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3170;continue;}
case 3170:{f.StackOp("dup");f.Pc=3171;continue;}
case 3171:{f.Push(JValue.R(rt.String("NumManaShards")));f.Pc=3174;continue;}
case 3174:{f.Push(JValue.I(169));f.Pc=3177;continue;}
case 3177:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3180;continue;}
case 3180:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3183);}
case 3183:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NumManaShards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","NumManaShards","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3186;continue;}
case 3186:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3189;continue;}
case 3189:{f.StackOp("dup");f.Pc=3190;continue;}
case 3190:{f.Push(JValue.R(rt.String("HostCard")));f.Pc=3193;continue;}
case 3193:{f.Push(JValue.I(170));f.Pc=3196;continue;}
case 3196:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=3199;continue;}
case 3199:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3202);}
case 3202:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HostCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","HostCard","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3205;continue;}
case 3205:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3208;continue;}
case 3208:{f.StackOp("dup");f.Pc=3209;continue;}
case 3209:{f.Push(JValue.R(rt.String("Description")));f.Pc=3212;continue;}
case 3212:{f.Push(JValue.I(171));f.Pc=3215;continue;}
case 3215:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3218;continue;}
case 3218:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3221);}
case 3221:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Description","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Description","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3224;continue;}
case 3224:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3227;continue;}
case 3227:{f.StackOp("dup");f.Pc=3228;continue;}
case 3228:{f.Push(JValue.R(rt.String("CanPlay")));f.Pc=3231;continue;}
case 3231:{f.Push(JValue.I(172));f.Pc=3234;continue;}
case 3234:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3237;continue;}
case 3237:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3240);}
case 3240:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CanPlay","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","CanPlay","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3243;continue;}
case 3243:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3246;continue;}
case 3246:{f.StackOp("dup");f.Pc=3247;continue;}
case 3247:{f.Push(JValue.R(rt.String("PromptIfOnlyPossibleAbility")));f.Pc=3250;continue;}
case 3250:{f.Push(JValue.I(173));f.Pc=3253;continue;}
case 3253:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3256;continue;}
case 3256:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3259);}
case 3259:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PromptIfOnlyPossibleAbility","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","PromptIfOnlyPossibleAbility","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3262;continue;}
case 3262:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3265;continue;}
case 3265:{f.StackOp("dup");f.Pc=3266;continue;}
case 3266:{f.Push(JValue.R(rt.String("SA_IsSpell")));f.Pc=3269;continue;}
case 3269:{f.Push(JValue.I(174));f.Pc=3272;continue;}
case 3272:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3275;continue;}
case 3275:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3278);}
case 3278:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SA_IsSpell","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","SA_IsSpell","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3281;continue;}
case 3281:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3284;continue;}
case 3284:{f.StackOp("dup");f.Pc=3285;continue;}
case 3285:{f.Push(JValue.R(rt.String("Key")));f.Pc=3288;continue;}
case 3288:{f.Push(JValue.I(175));f.Pc=3291;continue;}
case 3291:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3294;continue;}
case 3294:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3297);}
case 3297:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Key","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Key","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3300;continue;}
case 3300:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3303;continue;}
case 3303:{f.StackOp("dup");f.Pc=3304;continue;}
case 3304:{f.Push(JValue.R(rt.String("SourceTrigger")));f.Pc=3307;continue;}
case 3307:{f.Push(JValue.I(176));f.Pc=3310;continue;}
case 3310:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3313;continue;}
case 3313:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3316);}
case 3316:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SourceTrigger","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","SourceTrigger","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3319;continue;}
case 3319:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3322;continue;}
case 3322:{f.StackOp("dup");f.Pc=3323;continue;}
case 3323:{f.Push(JValue.R(rt.String("SourceCard")));f.Pc=3326;continue;}
case 3326:{f.Push(JValue.I(177));f.Pc=3329;continue;}
case 3329:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=3332;continue;}
case 3332:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3335);}
case 3335:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SourceCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","SourceCard","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3338;continue;}
case 3338:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3341;continue;}
case 3341:{f.StackOp("dup");f.Pc=3342;continue;}
case 3342:{f.Push(JValue.R(rt.String("ActivatingPlayer")));f.Pc=3345;continue;}
case 3345:{f.Push(JValue.I(178));f.Pc=3348;continue;}
case 3348:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=3351;continue;}
case 3351:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3354);}
case 3354:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ActivatingPlayer","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","ActivatingPlayer","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3357;continue;}
case 3357:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3360;continue;}
case 3360:{f.StackOp("dup");f.Pc=3361;continue;}
case 3361:{f.Push(JValue.R(rt.String("TargetCards")));f.Pc=3364;continue;}
case 3364:{f.Push(JValue.I(179));f.Pc=3367;continue;}
case 3367:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=3370;continue;}
case 3370:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3373);}
case 3373:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","TargetCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","TargetCards","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3376;continue;}
case 3376:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3379;continue;}
case 3379:{f.StackOp("dup");f.Pc=3380;continue;}
case 3380:{f.Push(JValue.R(rt.String("TargetPlayers")));f.Pc=3383;continue;}
case 3383:{f.Push(JValue.I(180));f.Pc=3386;continue;}
case 3386:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","PlayerViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","PlayerViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=3389;continue;}
case 3389:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3392);}
case 3392:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","TargetPlayers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","TargetPlayers","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3395;continue;}
case 3395:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3398;continue;}
case 3398:{f.StackOp("dup");f.Pc=3399;continue;}
case 3399:{f.Push(JValue.R(rt.String("TargetStackItems")));f.Pc=3402;continue;}
case 3402:{f.Push(JValue.I(181));f.Pc=3405;continue;}
case 3405:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StackItemViewListType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StackItemViewListType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=3408;continue;}
case 3408:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3411);}
case 3411:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","TargetStackItems","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","TargetStackItems","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3414;continue;}
case 3414:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3417;continue;}
case 3417:{f.StackOp("dup");f.Pc=3418;continue;}
case 3418:{f.Push(JValue.R(rt.String("SubInstance")));f.Pc=3421;continue;}
case 3421:{f.Push(JValue.I(182));f.Pc=3424;continue;}
case 3424:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StackItemViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StackItemViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=3427;continue;}
case 3427:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3430);}
case 3430:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SubInstance","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","SubInstance","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3433;continue;}
case 3433:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3436;continue;}
case 3436:{f.StackOp("dup");f.Pc=3437;continue;}
case 3437:{f.Push(JValue.R(rt.String("Ability")));f.Pc=3440;continue;}
case 3440:{f.Push(JValue.I(183));f.Pc=3443;continue;}
case 3443:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3446;continue;}
case 3446:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3449);}
case 3449:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Ability","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Ability","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3452;continue;}
case 3452:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3455;continue;}
case 3455:{f.StackOp("dup");f.Pc=3456;continue;}
case 3456:{f.Push(JValue.R(rt.String("OptionalTrigger")));f.Pc=3459;continue;}
case 3459:{f.Push(JValue.I(184));f.Pc=3462;continue;}
case 3462:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3465;continue;}
case 3465:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3468);}
case 3468:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OptionalTrigger","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","OptionalTrigger","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3471;continue;}
case 3471:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3474;continue;}
case 3474:{f.StackOp("dup");f.Pc=3475;continue;}
case 3475:{f.Push(JValue.R(rt.String("OptionalCosts")));f.Pc=3478;continue;}
case 3478:{f.Push(JValue.I(185));f.Pc=3481;continue;}
case 3481:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3484;continue;}
case 3484:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3487);}
case 3487:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OptionalCosts","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","OptionalCosts","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3490;continue;}
case 3490:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3493;continue;}
case 3493:{f.StackOp("dup");f.Pc=3494;continue;}
case 3494:{f.Push(JValue.R(rt.String("CombatView")));f.Pc=3497;continue;}
case 3497:{f.Push(JValue.I(186));f.Pc=3500;continue;}
case 3500:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CombatViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CombatViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=3503;continue;}
case 3503:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=3506;continue;}
case 3506:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",3509);}
case 3509:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CombatView","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","CombatView","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3512;continue;}
case 3512:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3515;continue;}
case 3515:{f.StackOp("dup");f.Pc=3516;continue;}
case 3516:{f.Push(JValue.R(rt.String("AttackersWithDefenders")));f.Pc=3519;continue;}
case 3519:{f.Push(JValue.I(187));f.Pc=3522;continue;}
case 3522:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","GenericMapType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","GenericMapType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3525;continue;}
case 3525:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=3528;continue;}
case 3528:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",3531);}
case 3531:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttackersWithDefenders","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","AttackersWithDefenders","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3534;continue;}
case 3534:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3537;continue;}
case 3537:{f.StackOp("dup");f.Pc=3538;continue;}
case 3538:{f.Push(JValue.R(rt.String("AttackersWithBlockers")));f.Pc=3541;continue;}
case 3541:{f.Push(JValue.I(188));f.Pc=3544;continue;}
case 3544:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","GenericMapType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","GenericMapType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3547;continue;}
case 3547:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=3550;continue;}
case 3550:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",3553);}
case 3553:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttackersWithBlockers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","AttackersWithBlockers","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3556;continue;}
case 3556:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3559;continue;}
case 3559:{f.StackOp("dup");f.Pc=3560;continue;}
case 3560:{f.Push(JValue.R(rt.String("AttackersWithPlannedBlockers")));f.Pc=3563;continue;}
case 3563:{f.Push(JValue.I(189));f.Pc=3566;continue;}
case 3566:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","GenericMapType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","GenericMapType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3569;continue;}
case 3569:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=3572;continue;}
case 3572:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",3575);}
case 3575:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttackersWithPlannedBlockers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","AttackersWithPlannedBlockers","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3578;continue;}
case 3578:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3581;continue;}
case 3581:{f.StackOp("dup");f.Pc=3582;continue;}
case 3582:{f.Push(JValue.R(rt.String("BandsWithDefenders")));f.Pc=3585;continue;}
case 3585:{f.Push(JValue.I(190));f.Pc=3588;continue;}
case 3588:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","GenericMapType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","GenericMapType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3591;continue;}
case 3591:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=3594;continue;}
case 3594:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",3597);}
case 3597:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","BandsWithDefenders","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","BandsWithDefenders","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3600;continue;}
case 3600:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3603;continue;}
case 3603:{f.StackOp("dup");f.Pc=3604;continue;}
case 3604:{f.Push(JValue.R(rt.String("BandsWithBlockers")));f.Pc=3607;continue;}
case 3607:{f.Push(JValue.I(191));f.Pc=3610;continue;}
case 3610:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","GenericMapType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","GenericMapType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3613;continue;}
case 3613:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=3616;continue;}
case 3616:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",3619);}
case 3619:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","BandsWithBlockers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","BandsWithBlockers","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3622;continue;}
case 3622:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3625;continue;}
case 3625:{f.StackOp("dup");f.Pc=3626;continue;}
case 3626:{f.Push(JValue.R(rt.String("BandsWithPlannedBlockers")));f.Pc=3629;continue;}
case 3629:{f.Push(JValue.I(192));f.Pc=3632;continue;}
case 3632:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","GenericMapType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","GenericMapType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3635;continue;}
case 3635:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=3638;continue;}
case 3638:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",3641);}
case 3641:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","BandsWithPlannedBlockers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","BandsWithPlannedBlockers","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3644;continue;}
case 3644:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3647;continue;}
case 3647:{f.StackOp("dup");f.Pc=3648;continue;}
case 3648:{f.Push(JValue.R(rt.String("Players")));f.Pc=3651;continue;}
case 3651:{f.Push(JValue.I(193));f.Pc=3654;continue;}
case 3654:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","PlayerViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","PlayerViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=3657;continue;}
case 3657:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3660);}
case 3660:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Players","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Players","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3663;continue;}
case 3663:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3666;continue;}
case 3666:{f.StackOp("dup");f.Pc=3667;continue;}
case 3667:{f.Push(JValue.R(rt.String("GameType")));f.Pc=3670;continue;}
case 3670:{f.Push(JValue.I(194));f.Pc=3673;continue;}
case 3673:{f.Push(JValue.R(rt.ClassObject("forge/game/GameType")));f.Pc=3676;continue;}
case 3676:{return rt.Call(f,"forge/trackable/TrackableTypes","EnumType","(Ljava/lang/Class;)Lforge/trackable/TrackableTypes$TrackableType;","invokestatic",3679);}
case 3679:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3682);}
case 3682:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","GameType","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","GameType","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3685;continue;}
case 3685:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3688;continue;}
case 3688:{f.StackOp("dup");f.Pc=3689;continue;}
case 3689:{f.Push(JValue.R(rt.String("Title")));f.Pc=3692;continue;}
case 3692:{f.Push(JValue.I(195));f.Pc=3695;continue;}
case 3695:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3698;continue;}
case 3698:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3701);}
case 3701:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Title","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Title","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3704;continue;}
case 3704:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3707;continue;}
case 3707:{f.StackOp("dup");f.Pc=3708;continue;}
case 3708:{f.Push(JValue.R(rt.String("Turn")));f.Pc=3711;continue;}
case 3711:{f.Push(JValue.I(196));f.Pc=3714;continue;}
case 3714:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3717;continue;}
case 3717:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3720);}
case 3720:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Turn","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Turn","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3723;continue;}
case 3723:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3726;continue;}
case 3726:{f.StackOp("dup");f.Pc=3727;continue;}
case 3727:{f.Push(JValue.R(rt.String("PlayerTurn")));f.Pc=3730;continue;}
case 3730:{f.Push(JValue.I(197));f.Pc=3733;continue;}
case 3733:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=3736;continue;}
case 3736:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=3739;continue;}
case 3739:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",3742);}
case 3742:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PlayerTurn","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","PlayerTurn","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3745;continue;}
case 3745:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3748;continue;}
case 3748:{f.StackOp("dup");f.Pc=3749;continue;}
case 3749:{f.Push(JValue.R(rt.String("Phase")));f.Pc=3752;continue;}
case 3752:{f.Push(JValue.I(198));f.Pc=3755;continue;}
case 3755:{f.Push(JValue.R(rt.ClassObject("forge/game/phase/PhaseType")));f.Pc=3758;continue;}
case 3758:{return rt.Call(f,"forge/trackable/TrackableTypes","EnumType","(Ljava/lang/Class;)Lforge/trackable/TrackableTypes$TrackableType;","invokestatic",3761);}
case 3761:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=3764;continue;}
case 3764:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",3767);}
case 3767:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Phase","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Phase","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3770;continue;}
case 3770:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3773;continue;}
case 3773:{f.StackOp("dup");f.Pc=3774;continue;}
case 3774:{f.Push(JValue.R(rt.String("WinningPlayerName")));f.Pc=3777;continue;}
case 3777:{f.Push(JValue.I(199));f.Pc=3780;continue;}
case 3780:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3783;continue;}
case 3783:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3786);}
case 3786:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","WinningPlayerName","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","WinningPlayerName","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3789;continue;}
case 3789:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3792;continue;}
case 3792:{f.StackOp("dup");f.Pc=3793;continue;}
case 3793:{f.Push(JValue.R(rt.String("WinningTeam")));f.Pc=3796;continue;}
case 3796:{f.Push(JValue.I(200));f.Pc=3799;continue;}
case 3799:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3802;continue;}
case 3802:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3805);}
case 3805:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","WinningTeam","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","WinningTeam","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3808;continue;}
case 3808:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3811;continue;}
case 3811:{f.StackOp("dup");f.Pc=3812;continue;}
case 3812:{f.Push(JValue.R(rt.String("Mulligan")));f.Pc=3815;continue;}
case 3815:{f.Push(JValue.I(201));f.Pc=3818;continue;}
case 3818:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3821;continue;}
case 3821:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3824);}
case 3824:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Mulligan","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Mulligan","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3827;continue;}
case 3827:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3830;continue;}
case 3830:{f.StackOp("dup");f.Pc=3831;continue;}
case 3831:{f.Push(JValue.R(rt.String("GameOver")));f.Pc=3834;continue;}
case 3834:{f.Push(JValue.I(202));f.Pc=3837;continue;}
case 3837:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3840;continue;}
case 3840:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3843);}
case 3843:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","GameOver","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","GameOver","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3846;continue;}
case 3846:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3849;continue;}
case 3849:{f.StackOp("dup");f.Pc=3850;continue;}
case 3850:{f.Push(JValue.R(rt.String("MatchOver")));f.Pc=3853;continue;}
case 3853:{f.Push(JValue.I(203));f.Pc=3856;continue;}
case 3856:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3859;continue;}
case 3859:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3862);}
case 3862:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MatchOver","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","MatchOver","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3865;continue;}
case 3865:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3868;continue;}
case 3868:{f.StackOp("dup");f.Pc=3869;continue;}
case 3869:{f.Push(JValue.R(rt.String("NumGamesInMatch")));f.Pc=3872;continue;}
case 3872:{f.Push(JValue.I(204));f.Pc=3875;continue;}
case 3875:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3878;continue;}
case 3878:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3881);}
case 3881:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NumGamesInMatch","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","NumGamesInMatch","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3884;continue;}
case 3884:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3887;continue;}
case 3887:{f.StackOp("dup");f.Pc=3888;continue;}
case 3888:{f.Push(JValue.R(rt.String("NumPlayedGamesInMatch")));f.Pc=3891;continue;}
case 3891:{f.Push(JValue.I(205));f.Pc=3894;continue;}
case 3894:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3897;continue;}
case 3897:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3900);}
case 3900:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NumPlayedGamesInMatch","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","NumPlayedGamesInMatch","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3903;continue;}
case 3903:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3906;continue;}
case 3906:{f.StackOp("dup");f.Pc=3907;continue;}
case 3907:{f.Push(JValue.R(rt.String("Stack")));f.Pc=3910;continue;}
case 3910:{f.Push(JValue.I(206));f.Pc=3913;continue;}
case 3913:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StackItemViewListType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StackItemViewListType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"));f.Pc=3916;continue;}
case 3916:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3919);}
case 3919:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Stack","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Stack","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3922;continue;}
case 3922:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3925;continue;}
case 3925:{f.StackOp("dup");f.Pc=3926;continue;}
case 3926:{f.Push(JValue.R(rt.String("StormCount")));f.Pc=3929;continue;}
case 3929:{f.Push(JValue.I(207));f.Pc=3932;continue;}
case 3932:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3935;continue;}
case 3935:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3938);}
case 3938:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","StormCount","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","StormCount","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3941;continue;}
case 3941:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3944;continue;}
case 3944:{f.StackOp("dup");f.Pc=3945;continue;}
case 3945:{f.Push(JValue.R(rt.String("PoisonCountersToLose")));f.Pc=3948;continue;}
case 3948:{f.Push(JValue.I(208));f.Pc=3951;continue;}
case 3951:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3954;continue;}
case 3954:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3957);}
case 3957:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PoisonCountersToLose","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","PoisonCountersToLose","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3960;continue;}
case 3960:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3963;continue;}
case 3963:{f.StackOp("dup");f.Pc=3964;continue;}
case 3964:{f.Push(JValue.R(rt.String("Object")));f.Pc=3967;continue;}
case 3967:{f.Push(JValue.I(209));f.Pc=3970;continue;}
case 3970:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","ObjectType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","ObjectType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3973;continue;}
case 3973:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=3976;continue;}
case 3976:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;Lforge/trackable/TrackableProperty$FreezeMode;)V","invokespecial",3979);}
case 3979:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Object","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Object","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=3982;continue;}
case 3982:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableProperty"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableProperty")));f.Pc=3985;continue;}
case 3985:{f.StackOp("dup");f.Pc=3986;continue;}
case 3986:{f.Push(JValue.R(rt.String("Dependencies")));f.Pc=3989;continue;}
case 3989:{f.Push(JValue.I(210));f.Pc=3992;continue;}
case 3992:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"));f.Pc=3995;continue;}
case 3995:{return rt.Call(f,"forge/trackable/TrackableProperty","<init>","(Ljava/lang/String;ILforge/trackable/TrackableTypes$TrackableType;)V","invokespecial",3998);}
case 3998:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Dependencies","Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","Dependencies","Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=4001;continue;}
case 4001:{return rt.Call(f,"forge/trackable/TrackableProperty","$values","()[Lforge/trackable/TrackableProperty;","invokestatic",4004);}
case 4004:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","$VALUES","[Lforge/trackable/TrackableProperty;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableProperty","$VALUES","[Lforge/trackable/TrackableProperty;",f.Pop());f.Pc=4007;continue;}
case 4007:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

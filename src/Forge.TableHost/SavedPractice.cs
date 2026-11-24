using System.Globalization;
using Planeswalker.ForgeAot;
using Planeswalker.ForgeConsole;
using Planeswalker.TableHost;

public sealed partial class HeadlessMatch
{
    private const int SavedPracticeZoneLimit = 250;
    private const int SavedPracticeLoyaltyLimit = 1000;
    private SavedPracticeFixture? savedPractice;

    public static HeadlessMatch CreateSavedPractice(CardDatabase db, byte[] types, byte[] messages, SavedPracticeFixture fixture)
    {
        if (fixture == null) throw new ArgumentNullException(nameof(fixture));
        var setup = new SavedPracticeFixture {
            Seed = fixture.Seed,
            PlayerHand = CopyCards(fixture.PlayerHand, "你的手牌"),
            OpponentHand = CopyCards(fixture.OpponentHand, "对手的手牌"),
            PlayerLibrary = CopyCards(fixture.PlayerLibrary, "你的牌库"),
            OpponentLibrary = CopyCards(fixture.OpponentLibrary, "对手的牌库"),
            PlayerGraveyard = CopyCards(fixture.PlayerGraveyard, "你的坟场"),
            PlayerBattlefield = CopyBattlefield(fixture.PlayerBattlefield, "你的战场"),
            OpponentBattlefield = CopyBattlefield(fixture.OpponentBattlefield, "对手的战场")
        };
        return new HeadlessMatch(db, types, messages, Array.Empty<string>(), Array.Empty<string>(), setup.Seed) {
            savedPractice = setup
        };

        void CheckName(string? name, string zone)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException($"{zone}含有空白牌名。", nameof(fixture));
            if (!db.ContainsCard(name)) throw new ArgumentException($"{zone}含有未收录的牌「{name}」。", nameof(fixture));
        }

        string[] CopyCards(string[]? cards, string zone)
        {
            if (cards == null || cards.Length > SavedPracticeZoneLimit)
                throw new ArgumentException($"{zone}的牌表需要为 0 至 {SavedPracticeZoneLimit} 张。", nameof(fixture));
            foreach (var name in cards) CheckName(name, zone);
            return cards.ToArray();
        }

        SavedPracticePermanent[] CopyBattlefield(SavedPracticePermanent[]? cards, string zone)
        {
            if (cards == null || cards.Length > SavedPracticeZoneLimit)
                throw new ArgumentException($"{zone}的牌表需要为 0 至 {SavedPracticeZoneLimit} 张。", nameof(fixture));
            var snapshot = new SavedPracticePermanent[cards.Length];
            for (int i = 0; i < cards.Length; i++) {
                var entry = cards[i];
                if (entry == null) throw new ArgumentException($"{zone}含有空白永久物。", nameof(fixture));
                CheckName(entry.Name, zone);
                if (entry.Loyalty is < 0 or > SavedPracticeLoyaltyLimit)
                    throw new ArgumentException($"「{entry.Name}」的起始忠诚需为 0 至 {SavedPracticeLoyaltyLimit}。", nameof(fixture));
                snapshot[i] = new SavedPracticePermanent { Name = entry.Name, Loyalty = entry.Loyalty };
            }
            return snapshot;
        }
    }

    private void StartSavedPractice(SavedPracticeFixture fixture)
    {
        opening = false;
        var player = g.Players[0];
        C(g.Game, "setAge", "(Lforge/game/GameStage;)V", g.Enum("forge/game/GameStage", "Play"));
        C(g.Game, "setStartingPlayer", "(Lforge/game/player/Player;)V", player);
        C(g.Phase, "setupFirstTurn", "(Lforge/game/player/Player;Ljava/lang/Runnable;)V", player, default);

        // The engine draws from library index zero. Direct setup preserves the supplied order.
        foreach (var name in fixture.PlayerLibrary) g.Card(name, 0, "Library");
        foreach (var name in fixture.OpponentLibrary) g.Card(name, 1, "Library");
        foreach (var name in fixture.PlayerHand) g.Card(name, 0, "Hand");
        foreach (var name in fixture.OpponentHand) g.Card(name, 1, "Hand");
        foreach (var name in fixture.PlayerGraveyard) g.Card(name, 0, "Graveyard");
        foreach (var entry in fixture.PlayerBattlefield) PlaceSavedPermanent(entry, 0);
        foreach (var entry in fixture.OpponentBattlefield) PlaceSavedPermanent(entry, 1);

        C(g.Phase, "devModeSet", "(Lforge/game/phase/PhaseType;Lforge/game/player/Player;I)V",
            g.Enum("forge/game/phase/PhaseType", "MAIN1"), player, JValue.I(1));
        C(g.Phase, "setPriority", "(Lforge/game/player/Player;)V", player);
        g.Rt.PutField(g.Phase, PhaseHandler, "givePriorityToPlayer", "Z", JValue.I(1));
        C(g.Action, "checkStateEffects", "(Z)Z", JValue.I(1));
        C(g.Game, "copyLastState", "()V");
    }

    private void PlaceSavedPermanent(SavedPracticePermanent entry, int seat)
    {
        var card = g.Card(entry.Name, seat);
        if (!B(card, "isPermanent")) throw new ArgumentException($"「{entry.Name}」无法作为永久物设置在战场。");
        bool planeswalker = B(card, "isPlaneswalker");
        if (entry.Loyalty.HasValue && !planeswalker)
            throw new ArgumentException($"只能给鹏洛客设置忠诚。「{entry.Name}」不是鹏洛客。");

        C(g.Zone(seat, "Battlefield"), "add", "(Lforge/game/card/Card;)V", card);
        if (!planeswalker) return;
        int? loyalty = entry.Loyalty;
        if (!loyalty.HasValue) {
            string printed = OptionalText(C(card, "getBaseLoyalty", "()Ljava/lang/String;"));
            if (!int.TryParse(printed, NumberStyles.None, CultureInfo.InvariantCulture, out int baseLoyalty))
                throw new ArgumentException($"「{entry.Name}」的起始忠诚需要在场景中指定。");
            loyalty = baseLoyalty;
        }

        int additional = loyalty.Value - C(card, "getCurrentLoyalty", "()I").Int;
        if (additional < 0)
            throw new ArgumentException($"「{entry.Name}」已有更多忠诚指示物，无法按场景放置。");
        if (additional == 0) return;
        var counter = S("forge/game/card/CounterType", "getType", "(Ljava/lang/String;)Lforge/game/card/CounterType;",
            g.S("LOYALTY"));
        var table = g.New("forge/game/GameEntityCounterTable", "()V");
        var parameters = S("forge/game/ability/AbilityKey", "newMap", "()Ljava/util/EnumMap;");
        C(card, "addCounterInternal",
            "(Lforge/game/card/CounterType;ILforge/game/player/Player;ZLforge/game/GameEntityCounterTable;Ljava/util/Map;)V",
            counter, JValue.I(additional), g.Players[seat], JValue.I(0), table, parameters);
        if (C(card, "getCurrentLoyalty", "()I").Int != loyalty.Value)
            throw new ArgumentException($"「{entry.Name}」无法放置场景指定的忠诚指示物。");
    }
}

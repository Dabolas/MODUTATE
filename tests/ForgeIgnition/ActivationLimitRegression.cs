using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    public static void ActivationLimitRegression(string root, Action<bool,string> check)
    {
        HostCases(root, "activation-limit", check, (match, verify, granted, seed) =>
        {
            var game = match.g;
            string name = granted == 1 ? "Cursed Wombat" : "Dusk Legion Duelist";
            game.Card("Forest", 0, "Library");
            game.Card("Swamp", 0, "Library");
            var spell = game.Card(name, 0, "Hand");
            game.Fund(0, granted == 1 ? "B G" : "C W");
            verify(match.Play(game.Ability(spell, 0), 0), name + " cast");
            game.ResolveOne();
            game.Sba();
            game.Drain();
            var card = game.Current(spell);
            var type = match.S("forge/game/card/CounterType", "getType", "(Ljava/lang/String;)Lforge/game/card/CounterType;", game.S("P1P1"));
            int hand = game.Count(0, "Hand");

            void AddAndCheck(int expectedCounters, int draws)
            {
                var table = game.New("forge/game/GameEntityCounterTable", "()V");
                match.C(card, "addCounter", "(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V",
                    type, JValue.I(1), game.Players[0], table);
                match.C(table, "replaceCounterEffect", "(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V", game.Game, default);
                game.Sba();
                game.Drain();
                verify(match.C(card, "getCounters", "(Lforge/game/card/CounterType;)I", type).Int == expectedCounters, name + " counter total");
                verify(game.Count(0, "Hand") == hand + draws, name + " cards drawn");
            }

            AddAndCheck(granted == 1 ? 2 : 1, granted == 1 ? 0 : 1);
            AddAndCheck(granted == 1 ? 3 : 2, granted == 1 ? 0 : 1);
            match.C(card, "resetActivationsPerTurn", "()V");
            AddAndCheck(granted == 1 ? 5 : 3, granted == 1 ? 0 : 2);
        });
    }
}

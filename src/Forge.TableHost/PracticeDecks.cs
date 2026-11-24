namespace Planeswalker.TableHost;

public static class PracticeDecks
{
    public static string[] Build(bool human)
    {
        string land=human?"Forest":"Plains";
        string[] creatures=human
            ? new[]{"Llanowar Elves","Grizzly Bears","Runeclaw Bear","Kalonian Tusker","Nessian Courser","Centaur Courser","Garruk's Companion","Rumbling Baloth","Spined Wurm"}
            : new[]{"Savannah Lions","Elite Vanguard","Glory Seeker","Silvercoat Lion","Youthful Knight","Blade of the Sixth Pride","Pillarfield Ox","Siege Mastodon","Serra Angel"};
        return Enumerable.Repeat(land,24).Concat(creatures.SelectMany(name=>Enumerable.Repeat(name,4))).ToArray();
    }
}

namespace Planeswalker.TableHost;

public sealed class SavedPracticeFixture
{
    public long Seed { get; set; }
    public string[] PlayerHand { get; set; } = Array.Empty<string>();
    public string[] OpponentHand { get; set; } = Array.Empty<string>();
    public string[] PlayerLibrary { get; set; } = Array.Empty<string>();
    public string[] OpponentLibrary { get; set; } = Array.Empty<string>();
    public string[] PlayerGraveyard { get; set; } = Array.Empty<string>();
    public SavedPracticePermanent[] PlayerBattlefield { get; set; } = Array.Empty<SavedPracticePermanent>();
    public SavedPracticePermanent[] OpponentBattlefield { get; set; } = Array.Empty<SavedPracticePermanent>();
}

public sealed class SavedPracticePermanent
{
    public string Name { get; set; } = "";
    public int? Loyalty { get; set; }
}

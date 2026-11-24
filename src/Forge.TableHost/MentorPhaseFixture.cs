using Planeswalker.Core;

namespace Planeswalker.TableHost;

public sealed class MentorPhaseFixture
{
    public long Seed { get; set; }
    public string[] PlayerHand { get; set; } = Array.Empty<string>();
    public string[] PlayerBattlefield { get; set; } = Array.Empty<string>();
    public string[] OpponentBattlefield { get; set; } = Array.Empty<string>();
    public string[] PlayerLibrary { get; set; } = Array.Empty<string>();
    public string[] OpponentLibrary { get; set; } = Array.Empty<string>();
}

public sealed record MentorPhaseEvidence(string Event, long Seed, string Line, MatchView State);

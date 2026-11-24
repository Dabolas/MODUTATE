namespace Planeswalker.TableHost;

// The declared companion counts as a sideboard card in Constructed play.
public sealed class DuelDeck
{
    public DuelDeck(string[] main,string[]? sideboard=null,string? companion=null)
        : this(main,sideboard,companion,false)
    {
    }

    private DuelDeck(string[] main,string[]? sideboard,string? companion,bool isDraft)
    {
        Main=main.ToArray();
        Sideboard=sideboard?.ToArray()??Array.Empty<string>();
        Companion=string.IsNullOrWhiteSpace(companion)?null:companion;
        IsDraft=isDraft;
    }

    // Forge offers the eligible cards in this sideboard before either opening hand is drawn.
    public static DuelDeck FromDraft(string[] main,string[] companionCandidates)=>new(main,companionCandidates,null,true);

    public string[] Main {get;}
    public string[] Sideboard {get;}
    public string? Companion {get;}
    internal bool IsDraft {get;}
    internal string[] OutsideCards()=>Companion is { } name?Sideboard.Append(name).ToArray():Sideboard;
}

using System.Text.Json;
using Planeswalker.ForgeConsole;

public sealed record ReplayDecision(int Step,string Kind,string[] Options,int Choice);
public sealed record MatchInput(int Version,long Seed,int TurnLimit,string[][] Decks,string Mode)
{
    [System.Text.Json.Serialization.JsonIgnore(Condition=System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]
    public string? OpeningFocus {get;init;}
}
public sealed class DecisionTape(long seed,StreamWriter writer,ReplayDecision[]? replay=null)
{
    // Fully specified PRNG: replay does not depend on System.Random implementation changes.
    private ulong state=unchecked((ulong)seed);
    public ulong RandomState=>state;
    public Action? BeforeDecision;
    public readonly List<ReplayDecision> Records=[];
    public void VerifyReplayConsumed(){if(replay!=null&&Records.Count<replay.Length)throw new InvalidDataException("Replay ended before consuming all recorded decisions");}
    public int ChooseInteger(string kind,int minimum,int maximum)
    {
        BeforeDecision?.Invoke();
        if(maximum<minimum)throw new HostDecisionGap(kind+": empty legal integer range");
        string[] options=["integer range",minimum.ToString(System.Globalization.CultureInfo.InvariantCulture),maximum.ToString(System.Globalization.CultureInfo.InvariantCulture)];
        int value=checked((int)((long)minimum+(long)(Next()%((ulong)((long)maximum-minimum)+1))));
        if(replay!=null&&Records.Count<replay.Length){var old=replay[Records.Count];if(old.Kind!=kind||!old.Options.SequenceEqual(options))throw new InvalidOperationException("Replay diverged at integer decision "+Records.Count);value=old.Choice;}
        if(value<minimum||value>maximum)throw new InvalidDataException("Replay integer outside legal range");
        var record=new ReplayDecision(Records.Count,kind,options,value);Records.Add(record);writer.WriteLine(JsonSerializer.Serialize(record));writer.Flush();return value;
    }
    private ulong Next(){state+=0x9E3779B97F4A7C15UL;ulong z=state;z=(z^(z>>30))*0xBF58476D1CE4E5B9UL;z=(z^(z>>27))*0x94D049BB133111EBUL;return z^(z>>31);}
    public int Choose(string kind,IEnumerable<string> offered,int? preferred=null)
    {
        BeforeDecision?.Invoke();
        var options=offered.ToArray();if(options.Length==0)throw new HostDecisionGap(kind+": empty legal choices");
        int choice=(int)(Next()%(uint)options.Length);
        if(preferred.HasValue)choice=preferred.Value;
        if(replay!=null&&Records.Count<replay.Length){var old=replay[Records.Count];if(old.Kind!=kind||!old.Options.SequenceEqual(options))throw new InvalidOperationException("Replay diverged at decision "+Records.Count+" "+kind);choice=old.Choice;}
        if(choice<0||choice>=options.Length)throw new InvalidDataException("Decision outside legal options");
        var item=new ReplayDecision(Records.Count,kind,options,choice);Records.Add(item);writer.WriteLine(JsonSerializer.Serialize(item));writer.Flush();return choice;
    }
    public T Pick<T>(string kind,T[] values,Func<T,string> label)=>values[Choose(kind,values.Select(label))];
    public T[] Shuffle<T>(string kind,IEnumerable<T> values,Func<T,string> label)
    {var list=values.ToList();var result=new List<T>();while(list.Count>0){int at=Choose(kind,list.Select(label));result.Add(list[at]);list.RemoveAt(at);}return result.ToArray();}
}

public static class CurveDecks
{
    public static string[][] Generate(CardDatabase database,DecisionTape tape)
    {
        // Start with the complete pinned database. Constraints are deck construction only;
        // unsupported abilities and keywords are NEVER used to filter out cards.
        var all=database.Cards.OrderBy(c=>c.Name,StringComparer.Ordinal).ToArray();
        string[] colors=["W","U","B","R","G"];string[] lands=["Plains","Island","Swamp","Mountain","Forest"];
        var decks=new List<string[]>();
        for(int seat=0;seat<2;seat++)
        {
            int[] colorCounts=[1,1,1,2,2,2,3,4,5];int colorCount=colorCounts[tape.Choose("deck color count "+seat,colorCounts.Select(n=>n.ToString()))];
            var selected=tape.Shuffle("deck colors "+seat,Enumerable.Range(0,5),i=>colors[i]).Take(colorCount).ToArray();
            var deck=new List<string>();
            var candidates=all.Where(c=>!c.Value("Types").Split(' ').Any(t=>new[]{"Land","Plane","Scheme","Conspiracy","Dungeon","Vanguard"}.Contains(t)))
                .Where(c=>c.Value("ManaCost")!=""&&c.Value("ManaCost")!="no cost")
                .Where(c=>!Enumerable.Range(0,5).Except(selected).Any(i=>c.Value("ManaCost").Contains(colors[i],StringComparison.Ordinal))).ToArray();
            int ManaValue(CardDefinition c)=>c.Value("ManaCost").Split(' ',StringSplitOptions.RemoveEmptyEntries).Sum(t=>int.TryParse(t.Split('/')[0],out int n)?n:t is "X" or "Y" or "Z"?0:1);
            for(int slot=0;slot<36;slot++)
            {
                int min=slot<12?0:slot<24?3:slot<32?4:6,max=slot<12?2:slot<24?3:slot<32?5:int.MaxValue;
                var pool=candidates.Where(c=>ManaValue(c)>=min&&ManaValue(c)<=max&&deck.Count(n=>n==c.Name)<4).ToArray();
                if(slot%2==0)pool=pool.Where(c=>c.Value("Types").Split(' ').Contains("Creature")).ToArray();
                deck.Add(tape.Pick("deck card "+seat+":"+slot,pool,c=>c.Name).Name);
            }
            // Allocate basic sources proportionally to the selected spells' colored pips.
            var weights=selected.Select(i=>1+deck.Sum(name=>all.First(c=>c.Name==name).Value("ManaCost").Count(ch=>ch==colors[i][0]))).ToArray();
            var counts=new int[selected.Length];for(int land=0;land<24;land++){int at=Enumerable.Range(0,selected.Length).OrderByDescending(i=>(double)weights[i]/(counts[i]+1)).First();counts[at]++;deck.Add(lands[selected[at]]);}
            decks.Add(deck.ToArray());
        }
        return decks.ToArray();
    }
}

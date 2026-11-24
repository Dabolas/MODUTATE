namespace Planeswalker.ForgeConsole;

public sealed record CardField(string Key,string Value);
public sealed record CardDefinition(string Id,string Name,string Kind,string TokenId,string Script,string Sha256,CardField[] Fields)
{
    public string Value(string key)=>Fields.FirstOrDefault(f=>f.Key==key)?.Value??"";
}
public sealed class CardInstance : Planeswalker.ForgeAot.JRuntime.IJavaIdentity
{
    public long InstanceId { get; }
    public CardDefinition Definition { get; }
    public int Owner { get; }
    public bool Tapped { get; internal set; }
    public string Zone { get; internal set; }="Library";
    public string JavaIdentity=>"card:"+InstanceId;
    internal CardInstance(long id,CardDefinition definition,int owner){InstanceId=id;Definition=definition;Owner=owner;}
}
public sealed partial class CardDatabase
{
    private readonly Dictionary<string,CardDefinition> cards=new(StringComparer.Ordinal);
    private readonly Dictionary<string,CardDefinition> tokens=new(StringComparer.Ordinal);
    private long nextId;
    private ILookup<string,string>? byFace,byCardName,byPrimary,byRuleAlias;
    internal sealed class CardNamesEntry(string name)
    {
        public string Name=name, Primary=name;
        public string[]? Faces, ExtraAliases;
        public IEnumerable<string> FaceNames=>Faces??[Name];
    }

    internal static CardNamesEntry NamesFrom(CardDefinition def)
    {
        var faces=def.Fields.Where(f=>f.Key=="Name").Select(f=>f.Value).ToArray();
        var names=def.Fields.Where(f=>f.Key is "Name" or "CopyFaceFrom").Select(f=>f.Value).ToArray();
        var extras=def.Fields.Where(f=>f.Key=="CopyFaceFrom"||f.Key=="FlavorName").Select(f=>f.Value).ToList();
        foreach(var field in def.Fields.Where(f=>f.Key=="Variant"))
            if(field.Value.Split(':',3) is [_, "FlavorName", var alias])extras.Add(alias);
        return new(def.Name){Primary=def.Value("AlternateMode")=="Split"?string.Join(" // ",names.Take(2)):def.Name,Faces=faces,ExtraAliases=extras.ToArray()};
    }
    public bool ContainsCard(string name)=>HasCardKey(name);
    public IEnumerable<string> FindCardNames(string query)=>
        (byCardName??=MakeLookup(e=>e.FaceNames.Append(e.Name),StringComparer.OrdinalIgnoreCase))[query];
    public IEnumerable<string> FindFaceNames(string query,bool exact=false)
    {
        byFace??=MakeLookup(e=>e.FaceNames,StringComparer.OrdinalIgnoreCase);
        var matches=byFace[query];
        return exact?matches.Where(name=>GetCard(name).Fields.Any(field=>field.Key=="Name"&&field.Value==query)):matches;
    }
    public IEnumerable<string> FindRuleNames(string query,bool alternate)
    {
        var comparer=StringComparer.Create(System.Globalization.CultureInfo.InvariantCulture,
            System.Globalization.CompareOptions.IgnoreCase|System.Globalization.CompareOptions.IgnoreNonSpace);
        if(alternate)return (byRuleAlias??=MakeLookup(e=>e.FaceNames.Concat(e.ExtraAliases??Array.Empty<string>()),comparer))[query];
        return (byPrimary??=MakeLookup(e=>new[]{e.Primary},comparer))[query];
    }
    private ILookup<string,string> MakeLookup(Func<CardNamesEntry,IEnumerable<string>> keys,StringComparer comparer)=>
        NameEntries.SelectMany(e=>keys(e).Distinct(comparer).Select(key=>(key,e.Name))).ToLookup(pair=>pair.key,pair=>pair.Name,comparer);

    public CardInstance Create(string name,int owner=0)
    {
        if(owner<0)throw new ArgumentOutOfRangeException(nameof(owner));
        return new(Interlocked.Increment(ref nextId),GetCard(name),owner);
    }
    public CardInstance CreateToken(string tokenId,int owner=0)
    {
        if(owner<0)throw new ArgumentOutOfRangeException(nameof(owner));
        return new(Interlocked.Increment(ref nextId),GetToken(tokenId)??throw new KeyNotFoundException("Unknown token: "+tokenId),owner);
    }
}

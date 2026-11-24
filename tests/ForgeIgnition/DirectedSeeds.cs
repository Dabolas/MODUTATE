using System.Security.Cryptography;
using System.Text.Json;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;

public static class DirectedSeeds
{
    private sealed record Deck(string Title,Dictionary<string,int> Cards);
    private sealed record Match(string Id,long Seed,string[] Decks,string? Focus=null);
    private sealed record Pack(string Edition,long MasterSeed,bool AcceptanceEligible,string CatalogueManifestSha256,
        Dictionary<string,Deck> Decks,Match[] Cases,Dictionary<string,string> CardHashes,string? Kind=null);

    public static int Run(string root,string[] args)
    {
        string? Option(string name)=>args.SingleOrDefault(s=>s.StartsWith(name+"=",StringComparison.Ordinal))?[(name.Length+1)..];
        string path=Option("--directed-pack")??throw new ArgumentException("Expected a directed pack path");
        var pack=JsonSerializer.Deserialize<Pack>(File.ReadAllBytes(path),new JsonSerializerOptions{PropertyNameCaseInsensitive=true})!;
        string dbPath=Path.Combine(root,"data/forge");
        string manifestHash=Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(Path.Combine(dbPath,"manifest.json"))));
        if(pack.AcceptanceEligible||!manifestHash.Equals(pack.CatalogueManifestSha256,StringComparison.OrdinalIgnoreCase))
            throw new InvalidDataException("Directed pack eligibility or catalogue hash mismatch");
        var db=CardDatabase.Load(dbPath);
        var names=pack.Decks.Values.SelectMany(d=>d.Cards.Keys).ToHashSet(StringComparer.Ordinal);
        if(!names.SetEquals(pack.CardHashes.Keys))throw new InvalidDataException("Card list and definition hashes disagree");
        foreach(var name in names)
            if(db.Create(name,0).Definition.Sha256!=pack.CardHashes[name])throw new InvalidDataException("Changed card definition: "+name);
        foreach(var (id,deck) in pack.Decks)
            if(deck.Cards.Values.Sum()!=(pack.Kind=="outcome-matrix"&&deck.Title=="Battle of Wits"?220:60)||deck.Cards.Any(k=>k.Value<=0||k.Value>4&&!db.Create(k.Key,0).Definition.Value("Types").Split(' ').Contains("Basic")))
                throw new InvalidDataException("Illegal test deck size or card count: "+id);
        if(pack.Cases.Length==0||pack.Cases.Select(c=>c.Id).Distinct().Count()!=pack.Cases.Length||
           !pack.Cases.Select(c=>c.Seed).SequenceEqual(Enumerable.Range(0,pack.Cases.Length).Select(i=>checked(pack.MasterSeed+i)))||
           !pack.Decks.Keys.ToHashSet().SetEquals(pack.Cases.SelectMany(c=>c.Decks))||
           pack.Cases.Any(c=>c.Decks.Length!=2||c.Decks[0]==c.Decks[1]||c.Id!=string.Join("-vs-",c.Decks)||
               c.Id.Any(ch=>!char.IsAsciiLetterOrDigit(ch)&&ch!='-')))
            throw new InvalidDataException("Invalid directed match list");
        MatchInput Input(Match match)=>new(4,match.Seed,60,match.Decks.Select(id=>
            pack.Decks[id].Cards.SelectMany(p=>Enumerable.Repeat(p.Key,p.Value)).ToArray()).ToArray(),"directed"){OpeningFocus=match.Focus};
        string? selected=Option("--case");
        if(selected==null){
            var reader=new AotCardReader(ForgeProgram.BuildForDevelopment(),Path.Combine(root,"src/Forge.ConsoleHost/Data/TypeLists.txt"),db);
            int failed=0;
            foreach(var name in names.Order(StringComparer.Ordinal)){
                var attempt=reader.Attempt(db.Create(name,0).Definition);
                if(!attempt.Passed){Console.Error.WriteLine(name+" — "+attempt.Error);failed++;}
            }
            Console.WriteLine($"CR {pack.Edition}, seed {pack.MasterSeed}: {pack.Cases.Length} match inputs, {pack.Decks.Count} decks, {names.Count-failed}/{names.Count} card scripts read.");
            if(failed==0&&Option("--emit-inputs") is string dest){
                var folder=Directory.CreateDirectory(Path.Combine(Path.GetFullPath(dest),"inputs-"+Guid.NewGuid().ToString("N")));
                foreach(var c in pack.Cases)File.WriteAllText(Path.Combine(folder.FullName,c.Id+".json"),JsonSerializer.Serialize(Input(c)));
                Console.WriteLine("Prepared inputs: "+folder.FullName);
            }
            return failed==0?0:2;
        }
        var game=pack.Cases.Single(c=>c.Id==selected);
        string gate=Option("--gate")??throw new ArgumentException("A matching complete-turn gate is required");
        string outputRoot=Option("--output")??throw new ArgumentException("Specify an output directory");
        BatchPaths.Gate=Path.GetFullPath(gate);
        EngineBuild.RequireStageZero(root);
        string dir=Path.Combine(Path.GetFullPath(outputRoot),game.Id+"-"+Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(dir);
        BatchPaths.WorkerRoot=dir;
        Console.WriteLine("Directed match evidence: "+dir);
        File.WriteAllText(Path.Combine(dir,"directed-source.json"),JsonSerializer.Serialize(new{
            pack.Edition,pack.MasterSeed,game.Id,game.Seed,game.Decks,packSha256=Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(path))),
            acceptanceEligible=false,mechanismAssertionsEvaluated=false}));
        return HeadlessMatch.Run(root,Input(game),dir);
    }
}

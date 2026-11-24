using System.Security.Cryptography;
using System.Text.Json;
namespace Planeswalker.ForgeConsole;
public sealed partial class CardDatabase
{
    public IReadOnlyCollection<CardDefinition> Cards=>cards.Values;
    public IReadOnlyCollection<CardDefinition> Tokens=>tokens.Values;
    public IReadOnlyCollection<string> CardNames=>cards.Keys;
    private IEnumerable<CardNamesEntry> NameEntries=>cards.Values.Select(NamesFrom);
    private bool HasCardKey(string name)=>cards.ContainsKey(name);
    public bool IsBasicLand(string name)=>cards.TryGetValue(name,out var c)&&c.Value("Types").Split(' ').Contains("Basic");
    public CardDefinition GetCard(string name)=>cards.TryGetValue(name,out var c)?c:throw new KeyNotFoundException("Unknown card: "+name);
    public CardDefinition? GetToken(string id)=>tokens.TryGetValue(id,out var c)?c:null;
    public static CardDatabase Load(string directory)
    {
        var db=new CardDatabase();using var manifest=JsonDocument.Parse(File.ReadAllBytes(Path.Combine(directory,"manifest.json")));
        foreach(var shard in manifest.RootElement.GetProperty("shards").EnumerateArray())
        {
            string relative=shard.GetProperty("path").GetString()!;
            string root=Path.GetFullPath(directory)+Path.DirectorySeparatorChar;
            string path=Path.GetFullPath(Path.Combine(directory,relative));
            if(!path.StartsWith(root,StringComparison.OrdinalIgnoreCase))throw new InvalidDataException("Shard escaped database directory.");
            byte[] bytes=File.ReadAllBytes(path);
            if(Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant()!=shard.GetProperty("sha256").GetString())throw new InvalidDataException("Shard hash mismatch: "+relative);
            using var json=JsonDocument.Parse(bytes);
            foreach(var record in json.RootElement.GetProperty("records").EnumerateArray())
            {
                var fields=record.GetProperty("fields").EnumerateArray().Select(f=>new CardField(f.GetProperty("key").GetString()!,f.GetProperty("value").GetString()!)).ToArray();
                var definition=new CardDefinition(record.GetProperty("id").GetString()!,record.GetProperty("name").GetString()!,record.GetProperty("kind").GetString()!,record.GetProperty("tokenId").GetString()!,record.GetProperty("script").GetString()!,record.GetProperty("sha256").GetString()!,fields);
                if(definition.Kind=="cardsfolder")db.cards.Add(definition.Name,definition);else db.tokens.Add(definition.TokenId,definition);
            }
        }
        if(db.cards.Count!=34468||db.tokens.Count!=864)throw new InvalidDataException("Incomplete pinned Forge catalogue.");
        return db;
    }
}

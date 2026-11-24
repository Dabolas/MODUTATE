using System.Collections;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Planeswalker.ForgeConsole;

public sealed partial class CardDatabase
{
    private sealed class Shard(string path,string hash)
    {
        public readonly string Path=path, Hash=hash;
    }
    private readonly record struct Address(Shard Shard,int Offset,int Length);
    private sealed class TableIndex(Func<string,byte[]> read)
    {
        internal readonly Dictionary<string,Address> Cards=new(StringComparer.Ordinal), Tokens=new(StringComparer.Ordinal);
        internal readonly Dictionary<string,CardNamesEntry> SpecialNames=new(StringComparer.Ordinal);
        internal readonly HashSet<string> Basics=new(StringComparer.Ordinal);
        // Nearby names often share a file. Keep raw bytes for only the last few files,
        // while the immutable objects actually used in play stay cached on the database.
        readonly LinkedList<(Shard Shard,byte[] Bytes)> recent=new();
        internal CardDefinition Load(Address address,string key,bool token)
        {
            var node=recent.First;
            while(node!=null && node.Value.Shard!=address.Shard)node=node.Next;
            if(node==null){
                var data=read(address.Shard.Path);
                if(!Matches(data,0,address.Shard.Hash))throw new InvalidDataException("Invalid card shard: "+address.Shard.Path);
                node=recent.AddFirst((address.Shard,data));
                if(recent.Count>4)recent.RemoveLast();
            }else{
                recent.Remove(node);
                recent.AddFirst(node);
            }
            var bytes=node.Value.Bytes;
            if(address.Offset<0||address.Length<=0||address.Offset>bytes.Length-address.Length)throw new InvalidDataException("Invalid card address: "+key);
            var record=JObject.Parse(Encoding.UTF8.GetString(bytes,address.Offset,address.Length));
            string Field(string name)=>(string)record[name]!;
            var fields=((JArray)record["fields"]!).Select(f=>new CardField((string)f["key"]!,(string)f["value"]!)).ToArray();
            var definition=new CardDefinition(Field("id"),Field("name"),Field("kind"),Field("tokenId"),Field("script"),Field("sha256"),fields);
            if((token?definition.TokenId:definition.Name)!=key||definition.Kind!=(token?"tokenscripts":"cardsfolder"))
                throw new InvalidDataException("Card directory disagrees with shard: "+key);
            return definition;
        }
    }
    private TableIndex? index;
    private TableIndex Index=>index??throw new InvalidOperationException("Table index is not mounted");
    public IReadOnlyCollection<string> CardNames=>Index.Cards.Keys;
    private bool HasCardKey(string name)=>Index.Cards.ContainsKey(name);
    public bool IsBasicLand(string name)=>Index.Basics.Contains(name);
    private IEnumerable<CardNamesEntry> NameEntries=>CardNames.Select(name=>Index.SpecialNames.TryGetValue(name,out var e)?e:new(name));
    public CardDefinition GetCard(string name)
    {
        if(cards.TryGetValue(name,out var definition))return definition;
        if(!Index.Cards.TryGetValue(name,out var address))throw new KeyNotFoundException("Unknown card: "+name);
        return cards[name]=Index.Load(address,name,false);
    }
    public CardDefinition? GetToken(string id)
    {
        if(tokens.TryGetValue(id,out var definition))return definition;
        return Index.Tokens.TryGetValue(id,out var address)?tokens[id]=Index.Load(address,id,true):null;
    }
    private sealed class Definitions(IReadOnlyCollection<string> keys,Func<string,CardDefinition> get):IReadOnlyCollection<CardDefinition>
    {
        public int Count=>keys.Count;
        public IEnumerator<CardDefinition> GetEnumerator()=>keys.Select(get).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
    }
    public IReadOnlyCollection<CardDefinition> Cards=>new Definitions(CardNames,GetCard);
    public IReadOnlyCollection<CardDefinition> Tokens=>new Definitions(Index.Tokens.Keys,id=>GetToken(id)!);
    private static bool Matches(byte[] bytes,int offset,string expected)
    {
        using var hash=SHA256.Create();
        return string.Equals(BitConverter.ToString(hash.ComputeHash(bytes,offset,bytes.Length-offset)).Replace("-",""),expected,StringComparison.OrdinalIgnoreCase);
    }

    public static IEnumerable<int> Mount(Func<string,byte[]> read,CardDatabase db)
    {
        if(db.index!=null){yield return db.CardNames.Count+db.Index.Tokens.Count;yield break;}
        byte[] manifestBytes=read("manifest.json"),bytes=read("table-index.txt");
        int headerEnd=Array.IndexOf(bytes,(byte)'\n');
        if(headerEnd<0)throw new InvalidDataException("Missing table directory header");
        var header=Encoding.UTF8.GetString(bytes,0,headerEnd).Split('\t');
        if(header.Length!=3||header[0]!="1"||!Matches(manifestBytes,0,header[1])||!Matches(bytes,headerEnd+1,header[2]))
            throw new InvalidDataException("Table directory and rules manifest do not match");
        var manifest=JObject.Parse(Encoding.UTF8.GetString(manifestBytes));
        var shards=((JArray)manifest["shards"]!).ToDictionary(e=>(string)e["path"]!,e=>new Shard((string)e["path"]!,(string)e["sha256"]!),StringComparer.Ordinal);
        var mounted=new TableIndex(read);
        using var lines=new StringReader(Encoding.UTF8.GetString(bytes,headerEnd+1,bytes.Length-headerEnd-1));
        Shard? shard=null;
        string? lastCard=null;
        string? line;
        while((line=lines.ReadLine())!=null){
            var fields=line.Split('\t');
            switch(fields[0]){
                case "#":
                    if(!shards.TryGetValue(fields[1],out shard)||!System.Text.RegularExpressions.Regex.IsMatch(shard.Path,@"^records/[0-9]{4}\.json$"))
                        throw new InvalidDataException("Invalid table shard");
                    lastCard=null;
                    break;
                case "B":case "C":case "T":
                    var address=new Address(shard??throw new InvalidDataException("Missing table shard"),int.Parse(fields[2],CultureInfo.InvariantCulture),int.Parse(fields[3],CultureInfo.InvariantCulture));
                    bool token=fields[0]=="T";
                    (token?mounted.Tokens:mounted.Cards).Add(fields[1],address);
                    if(fields[0]=="B")mounted.Basics.Add(fields[1]);
                    lastCard=token?null:fields[1];
                    break;
                case "F":case "P":case "A":
                    if(lastCard==null)throw new InvalidDataException("Missing face owner");
                    if(!mounted.SpecialNames.TryGetValue(lastCard,out var e))mounted.SpecialNames.Add(lastCard,e=new(lastCard));
                    if(fields[0]=="F")e.Faces=fields.Skip(1).ToArray();
                    else if(fields[0]=="P")e.Primary=fields[1];
                    else e.ExtraAliases=fields.Skip(1).ToArray();
                    break;
                default:throw new InvalidDataException("Unknown table directory record");
            }
        }
        if(mounted.Cards.Count!=(int)manifest["counts"]!["cards"]!||mounted.Tokens.Count!=(int)manifest["counts"]!["tokens"]!)
            throw new InvalidDataException("Incomplete table directory");
        db.index=mounted;
        yield return mounted.Cards.Count+mounted.Tokens.Count;
    }
}

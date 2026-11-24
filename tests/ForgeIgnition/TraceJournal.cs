using System.IO.Compression;
using System.Text.Json;

// Lossless: every trace event is retained in order. Repeated method names are
// dictionary encoded before compression so full-match traces do not expand to GBs.
public sealed class TraceJournal:IDisposable
{
    private readonly Dictionary<string,int> ids=new(StringComparer.Ordinal);
    private readonly BinaryWriter events;
    private readonly StreamWriter dictionary;
    private readonly string directory;
    private long count;
    public TraceJournal(string directory)
    {
        this.directory=directory;
        // Batch the four-byte IDs before compression. Keep every event and the same
        // on-disk format, without paying a compression-stream call for each method.
        events=new(new BufferedStream(new GZipStream(File.Create(Path.Combine(directory,"trace.events.gz")),CompressionLevel.Fastest),65536));
        dictionary=new(Path.Combine(directory,"trace.dictionary.jsonl"));
    }
    public void WriteLine(string line)
    {
        if(!ids.TryGetValue(line,out int id)){id=ids.Count;ids.Add(line,id);dictionary.WriteLine(JsonSerializer.Serialize(new{id,text=line}));}
        events.Write(id);count++;
    }
    public void Dispose()
    {
        events.Dispose();dictionary.Dispose();File.WriteAllText(Path.Combine(directory,"trace-format.json"),JsonSerializer.Serialize(new{version=1,format="gzip stream of little-endian Int32 dictionary IDs",events=count,dictionaryEntries=ids.Count,lossless=true}));
    }
    public static void Decode(string directory,string output)
    {
        var lines=File.ReadLines(Path.Combine(directory,"trace.dictionary.jsonl")).Select(l=>{using var j=JsonDocument.Parse(l);return j.RootElement.GetProperty("text").GetString()!;}).ToArray();
        using var stream=new GZipStream(File.OpenRead(Path.Combine(directory,"trace.events.gz")),CompressionMode.Decompress);using var writer=new StreamWriter(output);byte[] data=new byte[4];long count=0;
        while(true){int first=stream.ReadByte();if(first<0)break;data[0]=(byte)first;stream.ReadExactly(data.AsSpan(1));int id=System.Buffers.Binary.BinaryPrimitives.ReadInt32LittleEndian(data);if(id<0||id>=lines.Length)throw new InvalidDataException("Trace dictionary reference is invalid");writer.WriteLine(lines[id]);count++;}
        using var manifest=JsonDocument.Parse(File.ReadAllText(Path.Combine(directory,"trace-format.json")));if(count!=manifest.RootElement.GetProperty("events").GetInt64())throw new InvalidDataException("Incomplete event trace");
    }
}

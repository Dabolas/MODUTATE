using Planeswalker.ForgeAot;
using System.Security.Cryptography;

namespace Planeswalker.ForgeConsole;

public sealed record ReaderAttempt(bool Passed,string ErrorType,string Error,IReadOnlyList<string> Methods,IReadOnlyList<string> Bindings);
public sealed class AotCardReader
{
    private readonly JProgram program;
    private readonly string[] typeLines;
    private JRuntime? runtime;
    private bool attachedToGame;
    private JValue reader;
    private readonly CardDatabase? database;
    public JValue LastRules {get;private set;}
    public void Attach(JRuntime target)
    {
        if(runtime!=null)throw new InvalidOperationException("Reader already has an execution session.");
        if(!ReferenceEquals(target.Program,program))throw new ArgumentException("Reader and game must share program metadata.");
        target.InstallFaceLinkingAdapter();MountTypes(target);reader=AotDamageBridge.Construct(target,"forge/card/CardRules$Reader");runtime=target;attachedToGame=true;
    }
#if !NETSTANDARD2_1
    public AotCardReader(JProgram program,string typeListFile,CardDatabase database):this(program,typeListFile){this.database=database;}
    public AotCardReader(JProgram program,string typeListFile):this(program,File.ReadAllBytes(typeListFile)){}
#endif
    public AotCardReader(JProgram program,byte[] bytes,CardDatabase db):this(program,bytes){database=db;}
    private AotCardReader(JProgram program,byte[] bytes)
    {
        this.program=program;
        using var hash=SHA256.Create();
        if(BitConverter.ToString(hash.ComputeHash(bytes)).Replace("-","")!="5F2A278464311CD84D1317F7E552AAC3E3D6C8B8952746C2B199D59609AE2838")throw new InvalidDataException("Pinned Forge TypeLists hash mismatch.");
        typeLines=System.Text.Encoding.UTF8.GetString(bytes).Split('\n').Select(line=>line.TrimEnd('\r')).ToArray();
    }
    private void MountTypes(JRuntime rt)
    {
        var lines=rt.ListOf(typeLines.Select(line=>JValue.R(rt.String(line))));
        var parse=program.Classes["forge/util/FileSection"].Methods["parseSections(Ljava/util/List;)Ljava/util/Map;"];
        var sections=AotDamageBridge.Run(rt,parse,default,[lines]);
        var parseTypes=program.Classes["forge/card/CardType$Helper"].Methods["parseTypes(Ljava/lang/String;Ljava/util/List;)V"];
        foreach(var section in rt.MapItems(sections))AotDamageBridge.Run(rt,parseTypes,default,[section.Key,section.Value]);
        var loaded=rt.GetStatic("forge/card/CardType$Constant","LOADED","Lforge/util/Settable;");
        AotDamageBridge.Run(rt,program.Classes["forge/util/Settable"].Methods["set()Z"],loaded,[]);
        AotDamageBridge.Run(rt,program.Classes["forge/util/Lang"].Methods["createInstance(Ljava/lang/String;)V"],default,[JValue.R(rt.String("en-US"))]);
    }
    // Calls the original generated constructor and Reader.readCard, without fixture rule bindings.
    // This is a rules-definition parse, not CardFactory/Game initialization or gameplay.
    public ReaderAttempt Attempt(CardDefinition definition,bool includeCoverage=true)
    {
        var rt=runtime??new JRuntime(program);
        // Loading a token or previously unseen card inside a live match must
        // not erase the match's method/binding coverage collected before it.
        if(!attachedToGame){rt.ExecutedMethods.Clear();rt.ExecutedBindings.Clear();}
        try
        {
            JValue Run(JRuntime target,JMethod method,JValue receiver,JValue[] arguments)=>target.InvokeSynchronous(method.Owner,method.Name,method.Descriptor,receiver,arguments,method.Static?"invokestatic":"invokevirtual");
            if(runtime==null){rt.InstallFaceLinkingAdapter();MountTypes(rt);reader=AotDamageBridge.Construct(rt,"forge/card/CardRules$Reader");runtime=rt;}
            var lines=rt.ListOf(definition.Script.Split('\n').Select(line=>JValue.R(rt.String(line.TrimEnd('\r')))));
            var method=program.Classes["forge/card/CardRules$Reader"].Methods["readCard(Ljava/lang/Iterable;)Lforge/card/CardRules;"];
            var rules=Run(rt,method,reader,[lines]);
            if(rules.Reference?.ClassName!="forge/card/CardRules")throw new InvalidOperationException("Reader returned no CardRules.");
            var copies=definition.Fields.Where(f=>f.Key=="CopyFaceFrom").Select(f=>f.Value).ToArray();
            if(copies.Length>0)
            {
                if(database==null)throw new PortGap("CopyFaceFrom requires the mounted database");
                var faces=new Dictionary<string,JValue>(StringComparer.Ordinal);
                foreach(string copy in copies.Distinct())
                {
                    var sourceDefinition=database.FindFaceNames(copy,true).Select(database.GetCard).FirstOrDefault()??throw new PortGap("Missing copied face "+copy);
                    if(sourceDefinition.Fields.Any(f=>f.Key=="CopyFaceFrom"))throw new PortGap("Recursive copied face needs cycle-aware linking: "+copy);
                    var sourceLines=rt.ListOf(sourceDefinition.Script.Split('\n').Select(line=>JValue.R(rt.String(line.TrimEnd('\r')))));
                    var sourceRules=Run(rt,method,reader,[sourceLines]);
                    var all=Run(rt,program.Classes["forge/card/CardRules"].Methods["getAllFaces()Ljava/util/List;"],sourceRules,[]);
                    foreach(var face in rt.ListItems(all))
                    {string faceName=rt.StringValue(Run(rt,program.Classes["forge/card/CardFace"].Methods["getName()Ljava/lang/String;"],face,[]));faces[faceName]=face;}
                }
                var faceMap=rt.MapOf(faces.Select(p=>new KeyValuePair<JValue,JValue>(JValue.R(rt.String(p.Key)),p.Value)));
                Run(rt,program.Classes["forge/card/CardRules"].Methods["supplyPlaceholderFaces(Ljava/util/Map;)V"],rules,[faceMap]);
            }
            var name=program.Classes["forge/card/CardRules"].Methods["getName()Ljava/lang/String;"];
            string actual=rt.StringValue(Run(rt,name,rules,[]));
            string expected=definition.Value("AlternateMode")=="Split"?string.Join(" // ",definition.Fields.Where(f=>f.Key=="Name"||f.Key=="CopyFaceFrom").Take(2).Select(f=>f.Value)):definition.Name;
            if(actual!=expected)throw new InvalidOperationException("CardRules name mismatch: expected "+expected+", got "+actual);
            LastRules=rules;
            return new(true,"","",includeCoverage?rt.ExecutedMethods.OrderBy(x=>x).ToArray():Array.Empty<string>(),includeCoverage?rt.ExecutedBindings.OrderBy(x=>x).ToArray():Array.Empty<string>());
        }
        catch(Exception ex)
        {runtime=null;LastRules=default;return new(false,ex is JavaFault fault?fault.Value.ClassName:ex.GetType().Name,ex.Message,includeCoverage?rt.ExecutedMethods.OrderBy(x=>x).ToArray():Array.Empty<string>(),includeCoverage?rt.ExecutedBindings.OrderBy(x=>x).ToArray():Array.Empty<string>());}
    }
}

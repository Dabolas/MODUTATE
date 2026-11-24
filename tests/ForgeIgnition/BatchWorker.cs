using System.Text.Json;
using Planeswalker.ForgeConsole;

// Legacy single-test invocations keep their normal report locations. Only a
// child process receives its private output root and the immutable stage gate.
public static class BatchPaths
{
    internal static string? WorkerRoot, Gate;
    public static string Output(string root,string path,params string[] parts)=>
        Path.Combine([WorkerRoot??root,path,..parts]);
    public static string StageZero(string root)=>Gate??Path.Combine(root,"release/forge-l3/minimum-playable-state.json");
}

public static partial class ParallelBatch
{
    private sealed record Job(string Name,string Kind,long? Seed=null,string? Source=null);
    private sealed record Request(Job Job,SortedDictionary<string,string> Build,string? Gate,string? Driver);
    private sealed record Receipt(Job Job,bool Passed,string? Failure,object? Evidence,SortedDictionary<string,string> Build);
    private static readonly JsonSerializerOptions Json=new(){WriteIndented=true};
    private static JsonElement Read(string path)=>JsonSerializer.Deserialize<JsonElement>(File.ReadAllText(path));
    private static void Save(string path,object data)
    {
        File.WriteAllText(path+".tmp",JsonSerializer.Serialize(data,Json));
        File.Move(path+".tmp",path,true);
    }
    private static void Require(bool condition,string reason)
    {
        if(!condition)throw new InvalidDataException(reason);
    }
    private static bool SameBuild(JsonElement files,SortedDictionary<string,string> expected)=>
        files.ValueKind==JsonValueKind.Object&&files.EnumerateObject().Count()==expected.Count&&
        expected.All(pair=>files.TryGetProperty(pair.Key,out var hash)&&hash.GetString()==pair.Value);

    public static int RunWorker(string root,string requestFile)
    {
        string dir=Path.GetDirectoryName(Path.GetFullPath(requestFile))!;
        var request=JsonSerializer.Deserialize<Request>(File.ReadAllText(requestFile))!;
        BatchPaths.WorkerRoot=dir;
        BatchPaths.Gate=request.Gate;
        Directory.CreateDirectory(Path.Combine(dir,"release/forge-l3"));
        object? evidence=null;
        string? failure=null;
        var build=EngineBuild.Fingerprint(root);
        try {
            Require(build.Count==request.Build.Count&&build.All(p=>request.Build.TryGetValue(p.Key,out var hash)&&hash==p.Value),"Worker build disagrees with batch");
            if(request.Job.Seed.HasValue)
                evidence=RunMatch(root,dir,request,out failure);
            else
                evidence=RunCheck(root,dir,request.Job.Kind);
            Require(EngineBuild.Fingerprint(root).SequenceEqual(build),"Worker build changed during execution");
        } catch(Exception ex) { failure=ex.ToString(); }
        Save(Path.Combine(dir,"receipt.json"),new Receipt(request.Job,failure==null,failure,evidence,build));
        return failure==null?0:2;
    }

    private static object RunCheck(string root,string dir,string kind)
    {
        string report;
        switch(kind) {
            case "minimum-turn":
                Require(MinimumTurn.Run(root)==0,"Complete turn failed");
                report="release/forge-l3/minimum-playable-state.json";break;
            case "native-checks":
                NativeChecks.Run(root);report="release/forge-l3/native-checks.json";break;
            case "l3-matrix":
                Require(L3Suite.RunMatrix(root)==0,"Basic matrix failed");report="release/forge-l3-matrix/matrix.json";break;
            case "advanced-matrix":
                Require(AdvancedSuite.Run(root)==0,"Advanced matrix failed");report="release/forge-advanced/matrix.json";break;
            case "reference-audit":
                L3Suite.Audit(root);report="release/forge-l3/references.json";break;
            default: throw new ArgumentException("Unknown batch check: "+kind);
        }
        var r=Read(Path.Combine(dir,report));
        bool passed=kind switch {
            "minimum-turn"=>r.GetProperty("passed").GetBoolean()&&r.GetProperty("executed").GetBoolean()&&SameBuild(r.GetProperty("build"),EngineBuild.Fingerprint(root)),
            "native-checks"=>r.GetProperty("passed").GetBoolean()&&r.GetProperty("count").GetInt32()>=1192,
            "reference-audit"=>r.GetProperty("regressions").GetInt32()==0&&r.GetProperty("baseline").GetInt32()==686&&r.GetProperty("unbound").GetInt32()<=289,
            _=>r.GetProperty("allPassed").GetBoolean()&&r.GetProperty("passed").GetInt32()==r.GetProperty("total").GetInt32()&&r.GetProperty("total").GetInt32()>=(kind=="l3-matrix"?13:29)
        };
        Require(passed,"Invalid or incomplete report: "+report);
        return new{report};
    }

    private static object RunMatch(string root,string dir,Request request,out string? failure)
    {
        var job=request.Job;
        long seed=job.Seed!.Value;
        MatchInput input;
        if(job.Kind=="strict") {
            var driver=Read(request.Driver!);
            Require(driver.GetProperty("executed").GetBoolean()&&driver.GetProperty("passed").GetBoolean()&&driver.GetProperty("policyVersion").GetInt32()==4&&SameBuild(driver.GetProperty("build"),request.Build),"Invalid driver gate");
            var db=CardDatabase.Load(Path.Combine(root,"data/forge"));
            using var generation=new StreamWriter(Path.Combine(dir,"deck-generation.jsonl"));
            input=new(4,seed,60,CurveDecks.Generate(db,new(seed,generation)),"full-pool-random");
        } else {
            Require(job.Kind is "replay" or "replay-prefix" &&job.Source!=null,"Missing original replay corpus");
            input=JsonSerializer.Deserialize<MatchInput>(File.ReadAllText(Path.Combine(job.Source!,"input.json")))!;
            Require(input.Seed==seed,"Original seed mismatch");
        }
        ReplayDecision[]? recorded=null;
        if(job.Kind=="replay-prefix")
        {
            recorded=File.ReadLines(Path.Combine(job.Source!,"decisions.jsonl"))
                .Select(line=>JsonSerializer.Deserialize<ReplayDecision>(line)!).ToArray();
            Require(recorded.Length>0,"Original decision prefix is empty");
        }
        int exit=HeadlessMatch.Run(root,input,dir,recorded);
        var result=Read(Path.Combine(dir,"result.json"));
        string? termination=result.GetProperty("termination").GetString();
        bool passed=exit==0&&result.GetProperty("seed").GetInt64()==seed&&result.GetProperty("executionCompleted").GetBoolean()&&termination=="engine-game-over"
            &&SameBuild(Read(Path.Combine(dir,"build.json")).GetProperty("files"),request.Build);
        if(job.Kind=="strict")passed&=result.GetProperty("passed").GetBoolean()&&result.GetProperty("acceptanceEligible").GetBoolean()&&result.GetProperty("mode").GetString()=="full-pool-random";
        failure=passed?null:result.GetProperty("error").GetString()?.Split('\n')[0]??termination??"Match failed";
        object? prefix=job.Source==null?null:ComparePrefix(job.Source,dir);
        return new{seed,termination,exit,signature=result.GetProperty("javaSignature").GetString(),prefix};
    }

    private static object ComparePrefix(string source,string dir)
    {
        using var old=File.OpenText(Path.Combine(source,"decisions.jsonl"));
        using var current=File.OpenText(Path.Combine(dir,"decisions.jsonl"));
        int index=0;
        while(old.ReadLine() is string line) {
            string? next=current.ReadLine();
            if(line!=next) {
                var a=JsonSerializer.Deserialize<ReplayDecision>(line)!;
                var b=next==null?null:JsonSerializer.Deserialize<ReplayDecision>(next);
                return new{index,oldKind=a.Kind,newKind=b?.Kind,oldOptions=a.Options.Length,newOptions=b?.Options.Length,oldChoice=a.Choice,newChoice=b?.Choice};
            }
            index++;
        }
        return new{matchedPrefix=index};
    }
}

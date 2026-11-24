using System.Diagnostics;
using System.Text.Json;
using System.Text.RegularExpressions;
using Planeswalker.ForgeConsole;

// Discovery is a separate experiment. Neither its workers nor its aggregate
// report can contribute to strict acceptance or open the playable gate.
public static class DiscoverySuite
{
    private static readonly JsonSerializerOptions Json=new(){WriteIndented=true};
    private static void Save(string path,object value){string temporary=path+".tmp";File.WriteAllText(temporary,JsonSerializer.Serialize(value,Json));File.Move(temporary,path,true);}
    private static string Option(string[] args,string name,string fallback)=>args.FirstOrDefault(a=>a.StartsWith(name+"=",StringComparison.Ordinal))?[(name.Length+1)..]??fallback;
    public static int Run(string root,string[] args)
    {
        EngineBuild.RequireStageZero(root);
        if(args.Contains("--fuzz-discover-worker"))
        {
            long seed=long.Parse(Option(args,"--seed","44"));string directory=Path.GetFullPath(Option(args,"--artifact",Path.Combine(root,"release/forge-discovery",seed.ToString())));
            Directory.CreateDirectory(directory);
            var db=CardDatabase.Load(Path.Combine(root,"data/forge"));string[][] decks;
            using(var writer=new StreamWriter(Path.Combine(directory,"deck-generation.jsonl")))decks=CurveDecks.Generate(db,new(seed,writer));
            // Until a lossless engine transaction is certified, stop this worker
            // at an unsafe boundary. Sibling seeds continue in isolated processes.
            return HeadlessMatch.Run(root,new(4,seed,60,decks,"discovery"),directory);
        }
        long first=long.Parse(Option(args,"--seed","44"));int seeds=int.Parse(Option(args,"--seeds","21")),workers=int.Parse(Option(args,"--workers","3"));
        if(seeds<1||workers<1||workers>16)throw new ArgumentOutOfRangeException(nameof(args),"Positive seed count and 1..16 isolated workers required");
        string batch=Path.Combine(root,"release/forge-discovery","batch-"+DateTime.UtcNow.ToString("yyyyMMdd-HHmmss"));Directory.CreateDirectory(batch);
        Save(Path.Combine(batch,"batch.json"),new{mode="discovery",acceptanceEligible=false,playable=false,first,seeds,workers,build=EngineBuild.Fingerprint(root),snapshot=HeadlessSuite.Snapshot});
        DiscoveryReachability.Write(root,batch);
        Parallel.ForEachAsync(Enumerable.Range(0,seeds),new ParallelOptions{MaxDegreeOfParallelism=workers},async(index,cancellation)=>
        {
            long seed=checked(first+index);string directory=Path.Combine(batch,seed.ToString());Directory.CreateDirectory(directory);
            var start=new ProcessStartInfo(Environment.ProcessPath??throw new InvalidOperationException("Missing console process path")){UseShellExecute=false,CreateNoWindow=true,RedirectStandardOutput=true,RedirectStandardError=true,WorkingDirectory=root};
            if(string.Equals(Path.GetFileNameWithoutExtension(start.FileName),"dotnet",StringComparison.OrdinalIgnoreCase))start.ArgumentList.Add(typeof(DiscoverySuite).Assembly.Location);
            foreach(string argument in new[]{root,"--fuzz-discover-worker","--seed="+seed,"--artifact="+directory})start.ArgumentList.Add(argument);
            using var process=Process.Start(start)??throw new InvalidOperationException("Worker failed to start");
            using var stdout=File.Create(Path.Combine(directory,"console.log"));using var stderr=File.Create(Path.Combine(directory,"stderr.log"));
            await Task.WhenAll(process.StandardOutput.BaseStream.CopyToAsync(stdout,cancellation),process.StandardError.BaseStream.CopyToAsync(stderr,cancellation),process.WaitForExitAsync(cancellation));
            Save(Path.Combine(directory,"worker.json"),new{seed,exitCode=process.ExitCode,acceptanceEligible=false});
            Console.WriteLine($"DISCOVERY seed={seed} exit={process.ExitCode} artifact={directory}");
        }).GetAwaiter().GetResult();
        Aggregate(root,batch);Console.WriteLine("DISCOVERY report: "+Path.Combine(batch,"discovery.json"));return 0;
    }
    public static string Family(string signature)
    {
        string owner=signature.Split('(')[0];int dot=owner.LastIndexOf('.');if(dot>=0)owner=owner[..dot];
        if(owner.StartsWith("java/util/stream/"))return "java/util/stream/*";
        if(owner.StartsWith("com/google/common/collect/")&&(owner.Contains("Multimap")||owner.EndsWith("Multimaps")))return "com/google/common/collect/*Multimap*";
        foreach(string prefix in new[]{"com/google/common/collect/","java/util/","java/io/","java/net/","javax/crypto/","java/security/","java/time/"})if(owner.StartsWith(prefix))return prefix+"*";
        int slash=owner.LastIndexOf('/');return slash<0?"host-or-runtime":owner[..(slash+1)]+"*";
    }
    public static void Aggregate(string root,string batch,bool publishLatest=true)
    {
        var rows=new List<object>();var failures=new List<DiscoveryFailure>();
        foreach(string directory in Directory.EnumerateDirectories(batch).Order(StringComparer.Ordinal))
        {
            string path=Path.Combine(directory,"result.json");if(!File.Exists(path)){rows.Add(new{directory,status="worker-incomplete"});continue;}
            using var doc=JsonDocument.Parse(File.ReadAllText(path));var r=doc.RootElement;
            string error=r.GetProperty("error").GetString()??"",stack=r.GetProperty("javaStack").GetString()??"";
            bool completed=r.TryGetProperty("executionCompleted",out var done)&&done.GetBoolean();
            rows.Add(new{directory,status=completed?"completed-not-accepted":"recovery-blocked",acceptanceEligible=false});
            if(error.Length==0)continue;
            var missing=Regex.Match(error,@"Unlinked (?:runtime )?(?:call|method): ([^\r\n]+)");string signature=missing.Success?missing.Groups[1].Value:r.GetProperty("javaSignature").GetString()??"unknown";
            string[] cards=r.TryGetProperty("failureCards",out var cardList)?cardList.EnumerateArray().Select(c=>c.GetString()??"").ToArray():[];
            // Older captures lack entity ids. Preserve that distinction: the last
            // selected ability is useful context but is not proof of the thrower.
            string? lastAbility=null;string decisions=Path.Combine(directory,"decisions.jsonl");
            if(File.Exists(decisions))foreach(string line in File.ReadLines(decisions))
            {var decision=JsonSerializer.Deserialize<ReplayDecision>(line)!;if(decision.Choice>=0&&decision.Choice<decision.Options.Length&&decision.Options[decision.Choice].StartsWith("ability:"))lastAbility=decision.Options[decision.Choice];}
            failures.Add(new(signature,Family(signature),r.GetProperty("category").GetString()??"unclassified",r.GetProperty("seed").GetInt64(),cards,lastAbility,error,stack,path));
        }
        var gaps=failures.GroupBy(f=>f.Signature).Select(group=>new{signature=group.Key,family=group.First().Family,occurrences=group.Count(),cards=group.SelectMany(f=>f.Cards).Distinct().Order().ToArray(),evidence=group.ToArray()}).ToArray();
        var report=new{mode="discovery",acceptanceEligible=false,passed=false,playable=false,snapshot=HeadlessSuite.Snapshot,batch,workers=rows.Count,completed=rows,distinctGaps=gaps.Length,gaps,
            families=gaps.GroupBy(g=>g.family).Select(group=>new{family=group.Key,distinctSignatures=group.Count(),occurrences=group.Sum(g=>g.occurrences)}),
            recovery=new{arbitraryExceptionRollbackCertified=false,durableResumeSupported=false,reason="Original GameSnapshot omits state (thisTurnCast, creatureAttackedThisTurn, countersAddedThisTurn); no serializable VM/host continuation. Unsafe workers stop; siblings continue."}};
        Save(Path.Combine(batch,"discovery.json"),report);if(publishLatest)Save(Path.Combine(root,"release/forge-discovery/discovery.json"),report);
    }
    private sealed record DiscoveryFailure(string Signature,string Family,string Category,long Seed,string[] Cards,string? LastSelectedAbilityContext,string DotNetStack,string JavaStack,string Artifact);
}

using System.Text.Json;
using Planeswalker.ForgeConsole;

public static class HeadlessSuite
{
    public const string Snapshot="f818e4b2751a8237c5e1ba35248f6373745217aa";
    private static readonly JsonSerializerOptions Json=new(){WriteIndented=true};
    private static void Save(string path,object value)=>File.WriteAllText(path,JsonSerializer.Serialize(value,Json));
    private static void Status(string directory,string status,string? artifact=null)=>Save(Path.Combine(directory,"readiness.json"),new{playable=false,snapshot=Snapshot,randomMatchesRequired=200,representativesPassed=false,status,artifact});
    private static string ReplayAnchor(string root,string replay,MatchInput input,ReplayDecision[] decisions)
    {
        string corpus=Path.GetFullPath(Path.Combine(root,"tests/ForgeIgnition/Corpus"))+Path.DirectorySeparatorChar;
        string full=Path.GetFullPath(replay);if(!full.StartsWith(corpus,StringComparison.OrdinalIgnoreCase))return replay;
        string first=full[corpus.Length..].Split(Path.DirectorySeparatorChar,Path.AltDirectorySeparatorChar)[0];string anchor=Path.Combine(corpus,first);
        if(!File.Exists(Path.Combine(anchor,"input.json"))||!File.Exists(Path.Combine(anchor,"decisions.jsonl")))return replay;
        var original=JsonSerializer.Deserialize<MatchInput>(File.ReadAllText(Path.Combine(anchor,"input.json")))!;
        if(JsonSerializer.Serialize(original)!=JsonSerializer.Serialize(input))return replay;
        var prefix=File.ReadLines(Path.Combine(anchor,"decisions.jsonl")).Select(line=>JsonSerializer.Deserialize<ReplayDecision>(line)!).ToArray();
        if(prefix.Length>decisions.Length||!prefix.Zip(decisions).All(pair=>pair.First.Step==pair.Second.Step&&pair.First.Kind==pair.Second.Kind&&pair.First.Choice==pair.Second.Choice&&pair.First.Options.SequenceEqual(pair.Second.Options)))return replay;
        return anchor;
    }
    public static int Run(string root,string[] args)
    {
        string dir=Path.Combine(root,"release/forge-headless");Directory.CreateDirectory(dir);
        Status(dir,"running");
        using(var gate=JsonDocument.Parse(File.ReadAllText(Path.Combine(root,"release/forge-l3/minimum-playable-state.json"))))
            if(!gate.RootElement.GetProperty("passed").GetBoolean()||!gate.RootElement.GetProperty("executed").GetBoolean())throw new InvalidOperationException("Stage 0 must pass before headless execution");
        long seed=long.Parse(args.FirstOrDefault(a=>a.StartsWith("--seed="))?.Split('=')[1]??"42");
        string? replay=args.FirstOrDefault(a=>a.StartsWith("--replay="))?[9..];
        if(replay!=null)
        {
            var input=JsonSerializer.Deserialize<MatchInput>(File.ReadAllText(Path.Combine(replay,"input.json")))!;
            var decisions=File.ReadLines(Path.Combine(replay,"decisions.jsonl")).Select(l=>JsonSerializer.Deserialize<ReplayDecision>(l)!).ToArray();
            bool currentPolicy=args.Contains("--replay-current-policy");
            string attempt=Path.Combine(dir,"replay-"+DateTime.UtcNow.ToString("yyyyMMdd-HHmmss"));
            Directory.CreateDirectory(attempt);
            Save(Path.Combine(attempt,"replay-source.json"),new{source=Path.GetFullPath(replay),currentPolicy,seed=input.Seed,semantics=currentPolicy?"original seed and decks; new decision policy from opening; not checkpoint recovery":"strict recorded decision prefix"});
            int exit=HeadlessMatch.Run(root,input,attempt,currentPolicy?null:decisions);
            string anchor=ReplayAnchor(root,replay,input,decisions);
            string history=Path.Combine(anchor,"attempts",Path.GetFileName(attempt));Directory.CreateDirectory(history);
            foreach(string file in new[]{"input.json","result.json","decisions.jsonl","method-coverage.json"})if(File.Exists(Path.Combine(attempt,file)))File.Copy(Path.Combine(attempt,file),Path.Combine(history,file));
            Save(Path.Combine(history,"artifact.json"),new{snapshot=Snapshot,originalDirectory=attempt,parentCorpus=replay,currentPolicy,regressionRequired=true,status=exit==0?"passed":"unfixed"});
            Save(Path.Combine(anchor,"regression-status.json"),new{passed=exit==0,lastReplay=attempt,replayedPrefix=replay,snapshot=Snapshot,permanentRegression=true});Status(dir,exit==0?"replay-passed-only":"replay-failed",attempt);return exit;
        }
        if(args.Contains("--corpus-regressions"))
        {
            var rows=new List<object>();int failed=0;
            foreach(string corpus in Directory.EnumerateDirectories(Path.Combine(root,"tests/ForgeIgnition/Corpus")).Order(StringComparer.Ordinal))
            {
                if(!File.Exists(Path.Combine(corpus,"input.json"))||!File.Exists(Path.Combine(corpus,"decisions.jsonl")))continue;
                int exit=Run(root,["--replay="+corpus]);rows.Add(new{corpus,passed=exit==0});
                if(exit!=0){failed++;break;}
            }
            Save(Path.Combine(dir,"corpus-regressions.json"),new{passed=failed==0&&rows.Count>0,failFast=true,executed=rows.Count,failed,rows});return failed==0&&rows.Count>0?0:2;
        }
        if(args.Contains("--headless-smoke"))
        {
            string previous=Path.Combine(dir,"smoke");if(File.Exists(Path.Combine(previous,"result.json"))){string archive=Path.Combine(root,"tests/ForgeIgnition/Corpus","driver-"+DateTime.UtcNow.ToString("yyyyMMdd-HHmmss"));Directory.CreateDirectory(archive);foreach(string file in Directory.EnumerateFiles(previous))File.Copy(file,Path.Combine(archive,Path.GetFileName(file)));}
            string[] names=["Raging Goblin","Goblin Piker","Hill Giant","Lightning Bolt","Shock","Volcanic Hammer","Lightning Strike","Lava Axe","Prodigal Pyromancer"];
            var deck=Enumerable.Repeat("Mountain",24).Concat(names.SelectMany(n=>Enumerable.Repeat(n,4))).ToArray();
            int exit=HeadlessMatch.Run(root,new(4,seed,12,[deck,deck],"driver-smoke"),Path.Combine(dir,"smoke"));
            Save(Path.Combine(dir,"driver-gate.json"),new{executed=true,passed=exit==0,seed,policyVersion=4,build=EngineBuild.Fingerprint(root),snapshot=Snapshot});Status(dir,exit==0?"driver-passed-only":"driver-failed",Path.Combine(dir,"smoke"));return exit;
        }
        using(var driverGate=JsonDocument.Parse(File.ReadAllText(Path.Combine(dir,"driver-gate.json"))))
        {
            var gate=driverGate.RootElement;
            if(!gate.GetProperty("passed").GetBoolean()||!gate.TryGetProperty("policyVersion",out var policy)||policy.GetInt32()!=4)throw new InvalidOperationException("Full casting driver gate is closed; run --headless-smoke");
            foreach(var file in EngineBuild.Fingerprint(root))if(!gate.GetProperty("build").TryGetProperty(file.Key,out var hash)||hash.GetString()!=file.Value)throw new InvalidOperationException("Driver gate is stale; run --headless-smoke with this build");
        }
        int games=int.Parse(args.FirstOrDefault(a=>a.StartsWith("--games="))?.Split('=')[1]??"200");if(games<200)throw new ArgumentOutOfRangeException(nameof(games),"Acceptance batch must contain at least 200 consecutive games");
        return ParallelBatch.RunStrict(root,dir,seed,games,args);
    }
}

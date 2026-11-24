using System.Diagnostics;
using System.Text.Json;
using System.Collections.Concurrent;

public static partial class ParallelBatch
{
    private sealed record Outcome(Job Job,bool Passed,string? Failure,int ProcessId,DateTimeOffset Start,DateTimeOffset End,string Directory);
    private sealed record Wave(int Requested,int WorkerLimit,int PeakWorkers,int Passed,bool AllPassed,double Seconds,double? GamesPerMinute,Outcome[] Jobs);
    private static string? Option(string[] args,string key)=>args.FirstOrDefault(x=>x.StartsWith(key+"=",StringComparison.Ordinal))?[(key.Length+1)..];
    private static int Workers(string[] args)
    {
        int count=int.Parse(Option(args,"--workers")??"4");
        if(count is <2 or >16)throw new ArgumentOutOfRangeException(nameof(count),"Parallel batches use 2 to 16 workers");
        return count;
    }
    private static string NewBatch(string root,string[] args,string prefix)
    {
        string dir=Option(args,"--batch-directory")??Path.Combine(root,"release/forge-headless",prefix+"-"+Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(dir);
        Require(!Directory.EnumerateFileSystemEntries(dir).Any(),"Batch destination must be empty: "+dir);
        using var claim=new FileStream(Path.Combine(dir,"batch.claim"),FileMode.CreateNew,FileAccess.Write,FileShare.None);
        return Path.GetFullPath(dir);
    }
    private static async Task<Outcome> Dispatch(string root,string dir,Request request)
    {
        Directory.CreateDirectory(dir);
        string file=Path.Combine(dir,"request.json");
        Save(file,request);
        var start=new ProcessStartInfo("dotnet"){UseShellExecute=false,CreateNoWindow=true,RedirectStandardOutput=true,RedirectStandardError=true,WorkingDirectory=root};
        foreach(string arg in new[]{typeof(ParallelBatch).Assembly.Location,root,"--batch-job="+file}) start.ArgumentList.Add(arg);
        var begin=DateTimeOffset.UtcNow;
        int pid=0;
        string? failure=null;
        try {
            using var stdout=File.Create(Path.Combine(dir,"stdout.log"));
            using var stderr=File.Create(Path.Combine(dir,"stderr.log"));
            using var process=Process.Start(start)??throw new InvalidOperationException("Worker did not start");
            pid=process.Id;
            await Task.WhenAll(process.StandardOutput.BaseStream.CopyToAsync(stdout),process.StandardError.BaseStream.CopyToAsync(stderr),process.WaitForExitAsync());
            var r=Read(Path.Combine(dir,"receipt.json"));
            Require(r.GetProperty("Job").Deserialize<Job>()==request.Job&&SameBuild(r.GetProperty("Build"),request.Build),"Worker identity mismatch");
            if(process.ExitCode!=0||!r.GetProperty("Passed").GetBoolean())
                failure=r.GetProperty("Failure").GetString()??"Worker exit "+process.ExitCode;
        } catch(Exception ex) {failure=ex.Message;}
        return new(request.Job,failure==null,failure,pid,begin,DateTimeOffset.UtcNow,dir);
    }
    private static Wave RunWave(string root,string dir,IReadOnlyList<Job> jobs,int limit,SortedDictionary<string,string> build,string? gate=null,string? driver=null,bool failFast=false)
    {
        var results=new ConcurrentBag<Outcome>();
        var timer=Stopwatch.StartNew();
        int failed=0;
        Parallel.ForEachAsync(jobs,new ParallelOptions{MaxDegreeOfParallelism=limit},async(job,_)=>{
            if(failFast&&Volatile.Read(ref failed)!=0)return;
            var outcome=await Dispatch(root,Path.Combine(dir,job.Name),new(job,build,gate,driver));
            if(!outcome.Passed)Interlocked.Exchange(ref failed,1);
            results.Add(outcome);
        }).GetAwaiter().GetResult();
        var rows=results.OrderBy(r=>r.Job.Name,StringComparer.Ordinal).ToArray();
        int passed=rows.Count(r=>r.Passed);
        int peak=rows.Where(r=>r.ProcessId!=0).Select(r=>rows.Count(other=>other.ProcessId!=0&&other.Start<=r.Start&&other.End>r.Start)).DefaultIfEmpty().Max();
        double seconds=timer.Elapsed.TotalSeconds;
        return new(jobs.Count,limit,peak,passed,passed==jobs.Count&&rows.Length==jobs.Count,seconds,
            jobs.All(j=>j.Seed.HasValue)?60*passed/seconds:null,rows);
    }
    public static int Verify(string root,string[] args)
    {
        int workers=Workers(args);
        var seeds=(Option(args,"--replay-seeds")??"53,60").Split(',').Select(long.Parse).ToArray();
        Require(seeds.Length>=2&&seeds.Distinct().Count()==seeds.Length,"Original seed list must contain distinct seeds");
        string corpus=Option(args,"--corpus-root")??Path.Combine(root,"tests/ForgeIgnition/Corpus/host-gaps-20261118-followup");
        var build=EngineBuild.Fingerprint(root);
        string batch=NewBatch(root,args,"parallel-verify");
        Console.WriteLine("Batch evidence: "+batch);
        string summary=Path.Combine(batch,"result.json");
        var timer=Stopwatch.StartNew();
        var phases=new Dictionary<string,Wave>();
        object? scaling=null;
        bool passed=false;
        string? failure=null;
        try {
            Save(summary,new{status="running",build,workers,seeds});
            string[] available=["minimum-turn","native-checks","l3-matrix","advanced-matrix","reference-audit"];
            var selected=Option(args,"--checks")?.Split(',')??available;
            Require(selected.Length>=2&&selected.Distinct().Count()==selected.Length&&selected.All(available.Contains),"Invalid parallel check list");
            Require(args.Contains("--parallel-checks")||selected.Contains("minimum-turn"),"Replay batches require their own complete turn gate");
            var checks=selected.Select(k=>new Job(k,k)).ToArray();
            var tests=RunWave(root,Path.Combine(batch,"checks"),checks,workers,build);
            phases.Add("checks",tests);
            Require(tests.AllPassed,"Verification suite failed");
            if(!args.Contains("--parallel-checks")) {
                string gate=Path.Combine(batch,"checks/minimum-turn/release/forge-l3/minimum-playable-state.json");
                var originals=seeds.Select(s=>new Job(s.ToString(),"replay",s,Path.Combine(corpus,s.ToString()))).ToArray();
                var matches=RunWave(root,Path.Combine(batch,"replays"),originals,workers,build,gate);
                phases.Add("replays",matches);
                Require(matches.AllPassed,"Original replay failed");
                if(args.Contains("--measure-scaling")) {
                    int n=originals.Length;
                    Require(workers>=2*n,"Scaling comparison requires twice as many worker slots as original seeds");
                    // Weak scaling: double the number of copies of exactly the same
                    // workloads and worker slots. Calibration never counts as acceptance.
                    var workload=originals.Concat(originals.Select(j=>j with{Name=j.Name+"-copy"})).ToArray();
                    var calibration=RunWave(root,Path.Combine(batch,"scaling"),workload,2*n,build,gate);
                    phases.Add("calibration",calibration);
                    Require(calibration.AllPassed,"Scaling workload failed");
                    foreach(var sample in calibration.Jobs) {
                        var original=matches.Jobs.Single(r=>r.Job.Seed==sample.Job.Seed);
                        Require(DecisionHash(original.Directory)==DecisionHash(sample.Directory),"Replayed decisions changed with worker count");
                    }
                    double ratio=calibration.GamesPerMinute!.Value/matches.GamesPerMinute!.Value;
                    scaling=new{fromWorkers=matches.PeakWorkers,toWorkers=calibration.PeakWorkers,throughputRatio=ratio,idealRatio=2,efficiency=ratio/2,
                        interpretation="paired seed mix; weak scaling; one wall-time sample per width"};
                }
            }
            Require(EngineBuild.Fingerprint(root).SequenceEqual(build),"Build changed during verification");
            passed=true;
        } catch(Exception ex) {failure=ex.Message;}
        Save(summary,new{status=passed?"passed":"failed",passed,build,workers,seeds,phases,scaling,failure,seconds=timer.Elapsed.TotalSeconds,acceptanceEligible=false});
        return passed?0:2;
    }
    private static string DecisionHash(string dir)
    {
        using var stream=File.OpenRead(Path.Combine(dir,"decisions.jsonl"));
        return Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(stream));
    }
    public static int RunStrict(string root,string headless,long seed,int games,string[] args)
    {
        int workers=Workers(args);
        var build=EngineBuild.Fingerprint(root);
        string batch=NewBatch(root,args,"batch");
        string summary=Path.Combine(batch,"result.json");
        var jobs=Enumerable.Range(0,games).Select(i=>checked(seed+i)).Select(s=>new Job(s.ToString(),"strict",s)).ToArray();
        var timer=Stopwatch.StartNew();
        Wave? matches=null;
        bool passed=false;
        string? failure=null;
        void Publish(string status) {
            var data=new{status,passed,requested=games,completed=matches?.Passed??0,seed,batch,build,workers,matches,failure,seconds=timer.Elapsed.TotalSeconds};
            Save(summary,data);
            Save(Path.Combine(headless,"random-batch.json"),data);
        }
        try {
            Publish("running");
            string gate=Path.Combine(batch,"minimum-turn.json"),driver=Path.Combine(batch,"driver-gate.json");
            File.Copy(BatchPaths.StageZero(root),gate);
            File.Copy(Path.Combine(headless,"driver-gate.json"),driver);
            matches=RunWave(root,batch,jobs,workers,build,gate,driver,true);
            foreach(var row in matches.Jobs.Where(r=>!r.Passed)) {
                string corpus=Path.Combine(root,"tests/ForgeIgnition/Corpus",Path.GetFileName(batch)+"-"+row.Job.Name);
                Directory.CreateDirectory(corpus);
                foreach(string file in new[]{"input.json","decisions.jsonl","result.json","deck-generation.jsonl"})
                    if(File.Exists(Path.Combine(row.Directory,file)))File.Copy(Path.Combine(row.Directory,file),Path.Combine(corpus,file));
                Save(Path.Combine(corpus,"artifact.json"),new{snapshot=HeadlessSuite.Snapshot,originalDirectory=row.Directory,status="unfixed",regressionRequired=true});
            }
            Require(matches.AllPassed&&EngineBuild.Fingerprint(root).SequenceEqual(build),"Strict acceptance failed");
            passed=true;
        } catch(Exception ex) {failure=ex.Message;}
        Publish(passed?"completed":"failed");
        Save(Path.Combine(headless,"readiness.json"),new{playable=false,snapshot=HeadlessSuite.Snapshot,randomMatchesPassed=matches?.Passed??0,representativesPassed=false,status=passed?"representative-matrix-required":"random-batch-failed",batch});
        return passed?0:2;
    }
}

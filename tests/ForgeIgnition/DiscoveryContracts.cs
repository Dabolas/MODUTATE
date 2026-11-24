using System.Text.Json;

public static class DiscoveryContracts
{
    public static void Run(string root,Action<bool,string> check)
    {
        string directory=BatchPaths.Output(root,"release/forge-discovery/contracts");Directory.CreateDirectory(directory);
        string missing="java/util/stream/Collector.of()Ljava/util/stream/Collector;";
        foreach(int seed in new[]{1,2})
        {
            string path=Path.Combine(directory,seed.ToString());Directory.CreateDirectory(path);
            File.WriteAllText(Path.Combine(path,"result.json"),JsonSerializer.Serialize(new{passed=false,executionCompleted=false,error="PortGap: Unlinked call: "+missing+"\nsynthetic .NET stack",javaStack="synthetic Java stack",javaSignature="fixture.call()V",category="a-missing-binding",seed,failureCards=new[]{"1:Fixture card"}}));
        }
        DiscoverySuite.Aggregate(root,directory,false);using var json=JsonDocument.Parse(File.ReadAllText(Path.Combine(directory,"discovery.json")));var r=json.RootElement;
        check(!r.GetProperty("passed").GetBoolean()&&!r.GetProperty("playable").GetBoolean()&&!r.GetProperty("acceptanceEligible").GetBoolean(),"Discovery aggregation cannot mark acceptance or playability even when orchestration completes");
        check(r.GetProperty("distinctGaps").GetInt32()==1&&r.GetProperty("gaps")[0].GetProperty("occurrences").GetInt32()==2,"Discovery deduplicates a signature across seeds while retaining both occurrences");
        check(r.GetProperty("gaps")[0].GetProperty("cards")[0].GetString()=="1:Fixture card"&&r.GetProperty("gaps")[0].GetProperty("evidence").GetArrayLength()==2,"Discovery preserves card context and complete per-seed error evidence");
        check(DiscoverySuite.Family(missing)=="java/util/stream/*"&&DiscoverySuite.Family("com/google/common/collect/Multimaps.index()V")=="com/google/common/collect/*Multimap*","Discovery families distinguish stream and multimap semantic groups");
    }
}

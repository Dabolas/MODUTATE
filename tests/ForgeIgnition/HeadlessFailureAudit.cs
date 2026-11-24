using System.Text;
using System.Text.Json;

// Read-only audit of recorded failures. It never marks a crash fixed merely
// because another run got farther, and never authorizes playability.
public static class HeadlessFailureAudit
{
    private sealed record Failure(string Artifact,string Category,string Signature,string Error,long Seed,int Steps);
    public static void Run(string root)
    {
        string output=Path.Combine(root,"release/forge-headless");Directory.CreateDirectory(output);
        var failures=new List<Failure>();
        foreach(string path in Directory.EnumerateFiles(output,"result.json",SearchOption.AllDirectories).Order(StringComparer.Ordinal))
        {
            using var json=JsonDocument.Parse(File.ReadAllText(path));var r=json.RootElement;
            if(!r.TryGetProperty("passed",out var pass)||pass.GetBoolean()||!r.TryGetProperty("error",out var error)||error.ValueKind!=JsonValueKind.String)continue;
            string category=r.TryGetProperty("category",out var c)?c.GetString()??"unclassified":"unclassified";
            string signature=r.TryGetProperty("javaSignature",out var s)?s.GetString()??"not-captured":"not-captured";
            // Older captures overwrote the innermost signature while unwinding.
            // Recover from their preserved ordered trace; leave original artifacts intact.
            if(string.IsNullOrWhiteSpace(signature)&&r.TryGetProperty("traceTail",out var tail))
                signature=tail.EnumerateArray().Select(e=>e.GetString()??"").Where(line=>line.Contains("JAVA STACK\n",StringComparison.Ordinal)).Select(line=>line.Split("JAVA STACK\n")[1].Split('\n')[0]).FirstOrDefault(line=>!string.IsNullOrWhiteSpace(line))??"not-captured";
            string first=(error.GetString()??"").Split('\n')[0].TrimEnd();
            // Reviewed against the preserved stack: this NPE came from the
            // printing-free console catalogue, not a rules-method translation.
            // Original artifacts remain intact; only the reviewed audit changes.
            if(signature.StartsWith("forge/StaticData.getOtherImageKey",StringComparison.Ordinal))category="c-host-policy";
            failures.Add(new(Path.GetRelativePath(root,path),category,signature,first,r.TryGetProperty("seed",out var seed)?seed.GetInt64():0,r.TryGetProperty("steps",out var steps)&&steps.ValueKind==JsonValueKind.Number?steps.GetInt32():0));
        }
        var groups=failures.GroupBy(f=>(f.Category,f.Signature,f.Error)).Select(group=>new{category=group.Key.Category,signature=group.Key.Signature,error=group.Key.Error,occurrences=group.Count(),artifacts=group.Select(f=>new{f.Artifact,f.Seed,f.Steps}).ToArray(),repairStatus="requires regression evidence; not inferred from later failures"}).ToArray();
        var categories=new[]{"a-missing-binding","b-runtime-or-rule","c-host-policy","unclassified"}.Select(category=>new{category,failedRuns=failures.Count(f=>f.Category==category),distinctFailureSites=groups.Count(g=>g.category==category)}).ToArray();
        var corpus=new List<object>();string corpusRoot=Path.Combine(root,"tests/ForgeIgnition/Corpus");
        if(Directory.Exists(corpusRoot))foreach(string dir in Directory.EnumerateDirectories(corpusRoot).Order(StringComparer.Ordinal))
        {
            if(!File.Exists(Path.Combine(dir,"input.json")))continue;
            string statusFile=Path.Combine(dir,"regression-status.json");bool passed=false;string? replay=null;
            if(File.Exists(statusFile)){using var status=JsonDocument.Parse(File.ReadAllText(statusFile));passed=status.RootElement.GetProperty("passed").GetBoolean();replay=status.RootElement.GetProperty("lastReplay").GetString();}
            corpus.Add(new{path=Path.GetRelativePath(root,dir),fullReplayPassed=passed,lastReplay=replay});
        }
        File.WriteAllText(Path.Combine(output,"failure-audit.json"),JsonSerializer.Serialize(new{snapshot=HeadlessSuite.Snapshot,playable=false,countsAreFailureRunsNotCardRates=true,automaticCategoriesRequireRootCauseReview=true,categories,failures=groups,corpus},new JsonSerializerOptions{WriteIndented=true}));
        var text=new StringBuilder("# 无头测试失败归因\n\n本报告统计已保存的失败执行，不表示失败卡牌数量或可玩率。同一缺口可在多次重放中出现。自动分类需结合完整方法栈核对；修复状态只由专门回归和完整重放提供。\n\n| 类别 | 失败执行次数 | 不同失败位置 |\n|---|---:|---:|\n");
        foreach(var category in categories)text.AppendLine($"| {category.category} | {category.failedRuns} | {category.distinctFailureSites} |");
        foreach(var group in groups){text.AppendLine($"\n## {group.category} — {group.occurrences} 次\n\n{group.error}\n\n生成方法：`{group.signature}`\n");foreach(var artifact in group.artifacts)text.AppendLine($"- seed={artifact.Seed}，step={artifact.Steps}：`{artifact.Artifact}`");}
        File.WriteAllText(Path.Combine(output,"Failure_Audit.md"),text.ToString());
        Console.WriteLine($"Failure audit: {failures.Count} failed executions, {groups.Length} distinct failure sites; playability unchanged false.");
    }
}

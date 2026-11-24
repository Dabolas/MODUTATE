using System.Text.Json;
using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;

public static class Followup
{
    private sealed class Platform : IJavaPlatformHost
    {public long CurrentTimeMillis()=>0;public long NanoTime()=>0;public string LineSeparator=>"\n";public void Write(string text){} }
    public static void Run(string root)
    {
        string dir=Path.Combine(root,"release/forge-followup");Directory.CreateDirectory(dir);
        var options=new JsonSerializerOptions{WriteIndented=true};void Save(string name,object data)=>File.WriteAllText(Path.Combine(dir,name),JsonSerializer.Serialize(data,options));
        var baseline=File.ReadLines(Path.Combine(dir,"baseline-reader-failures.jsonl")).Select(line=>JsonDocument.Parse(line).RootElement.Clone()).ToArray();
        string Cluster(string error)=>error.Contains("case-insensitive")?"regex-case":error.Contains("StringBuilder.append")?"text-slice":error.Contains("CopyFaceFrom")?"face-link":error.Contains("Map.forEach")?"map-callback":"other";
        Save("clusters.json",baseline.GroupBy(row=>Cluster(row.GetProperty("Error").GetString()!)).Select(g=>new{category=g.Key,count=g.Count(),cards=g.Select(r=>r.GetProperty("name").GetString()).ToArray()}));
        var program=ForgeProgram.BuildForDevelopment();var db=CardDatabase.Load(Path.Combine(root,"data/forge"));var reader=new AotCardReader(program,Path.Combine(root,"src/Forge.ConsoleHost/Data/TypeLists.txt"),db);
        var retried=baseline.Select(row=>{string name=row.GetProperty("name").GetString()!;return new{name,category=Cluster(row.GetProperty("Error").GetString()!),result=reader.Attempt(db.Create(name).Definition)};}).ToArray();
        Save("reader-retest.json",new{attempted=retried.Length,passed=retried.Count(r=>r.result.Passed),failed=retried.Count(r=>!r.result.Passed),rows=retried});
        Console.WriteLine($"301 retest: {retried.Count(r=>r.result.Passed)} passed");
        using var linkage=JsonDocument.Parse(File.ReadAllText(Path.Combine(dir,"baseline-linkage.json")));
        Save("contract-checks.json",new{passed=true,checks=ContractChecks.Run(program)});
        var runtime=new JRuntime(program);runtime.InstallPlatformHost(new Platform());var keys=runtime.BindingNames.ToHashSet();
        var rows=linkage.RootElement.GetProperty("remainingJava").EnumerateArray().Select(row=>
        {
            string owner=row.GetProperty("owner").GetString()!,key=row.GetProperty("key").GetString()!;
            bool host=owner.StartsWith("java/io/")||owner.StartsWith("java/nio/file/")||owner.StartsWith("java/net/")||owner=="java/lang/Thread"||owner=="java/lang/System"&&!key.Contains("arraycopy")||owner.StartsWith("java/util/concurrent/Executors");
            return new{key,category=host?"host-policy-adapter":"native-semantic-rewrite",classification="proposed implementation route; not a reachability proof",bound=keys.Contains(key),deadCodeProven=false};
        }).ToArray();
        Save("references.json",new{total=rows.Length,host=rows.Count(r=>r.category=="host-policy-adapter"),rewrite=rows.Count(r=>r.category=="native-semantic-rewrite"),provenDead=0,bound=rows.Count(r=>r.bound),unbound=rows.Count(r=>!r.bound),rows});
        // These are honest readiness probes, not substitutes for the requested L3 games.
        var cases=new[]{("Llanowar Visionary","ETB draw trigger","DrawEffect"),("Rest in Peace","graveyard replacement","ChangeZoneEffect"),("Arc Lightning","multiple targets","DamageDealEffect"),("Fireball","X payment","DamageDealEffect"),("Divination","draw","DrawEffect"),("Healing Salve","life gain","LifeGainEffect"),("Giant Growth","temporary pump","PumpEffect"),("Unsummon","zone movement","ChangeZoneEffect"),("Raise the Alarm","tokens","TokenEffect"),("Counterspell","stack target","CounterEffect")};
        var logs=new List<object>();
        foreach(var (name,mechanism,effect) in cases)
        {
            var definition=db.Create(name).Definition;var parsed=reader.Attempt(definition);var rt=new JRuntime(program);string error="";
            try
            {
                AotDamageBridge.Construct(rt,"forge/game/ability/effects/"+effect);
                AotDamageBridge.Run(rt,program.Classes["forge/game/GameType"].Methods["values()[Lforge/game/GameType;"],default,[]);
                var type=rt.GetStatic("forge/game/GameType","Constructed","Lforge/game/GameType;");
                AotDamageBridge.Construct(rt,"forge/game/GameRules","(Lforge/game/GameType;)V",[type]);
                throw new PortGap("GameRules initialized, but complete RegisteredPlayer/Game/CardFactory/SpellAbilityStack activation is not implemented; no resolution was attempted.");
            }
            catch(Exception ex){error=ex.Message;}
            logs.Add(new{name,mechanism,reader=parsed.Passed,stackMounted=false,resolved=false,passed=false,blocker=error,actualMethods=rt.ExecutedMethods.Order().ToArray(),readerMethods=parsed.Methods});
        }
        Save("mechanism-cases.json",new{required=10,passed=0,blocked=10,scope="readiness probes only; requested L3 execution remains unfinished",cases=logs});
        File.WriteAllText(Path.Combine(dir,"report.md"),$"# 后续验证\n\n原失败301张：本次读取成功 {retried.Count(r=>r.result.Passed)} 张，仍失败 {retried.Count(r=>!r.result.Passed)} 张。\n\n686引用：宿主路线 {rows.Count(r=>r.category=="host-policy-adapter")}，C#语义重写路线 {rows.Count(r=>r.category=="native-semantic-rewrite")}，确认死代码0。已绑定 {rows.Count(r=>r.bound)}，未绑定 {rows.Count(r=>!r.bound)}。分类为保守处理路线，未把暂未调用当成死代码。\n\n10个机制用例仍为阻塞探针：0个完成原引擎入栈及结算；未提升L3覆盖率。方法日志仅记录实际读取与构造路径。\n\n全卡可用尚未实现。详见 clusters.json、reader-retest.json、references.json、mechanism-cases.json。\n");
    }
}

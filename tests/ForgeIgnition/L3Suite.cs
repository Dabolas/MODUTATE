using System.Text.Json;
using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;

public static class L3Suite
{
    public static int RunMatrix(string root)
    {
        var startedUtc=DateTimeOffset.UtcNow;
        string dir=BatchPaths.Output(root,"release/forge-l3-matrix");Directory.CreateDirectory(dir);
        var program=ForgeProgram.BuildForDevelopment();var db=CardDatabase.Load(Path.Combine(root,"data/forge"));
        var tests=new List<(string Group,string Name,Action<L3Game> Body)>
        {
            ("A","basic-actions",g=>
            {
                var land=g.Card("Plains",0,"Hand");var landSa=g.Ability(land,0);
                g.Check(g.Call(landSa,"canPlay","()Z").Int!=0,"land play permitted in main phase");g.Call(g.Players[0],"playLand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;",land,landSa);g.Check(g.In(land,"Battlefield"),"played land on battlefield");
                g.Call(land,"tap","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Z",default,g.Players[0]);g.Check(g.Call(land,"isTapped","()Z").Int!=0,"land tapped");g.Call(land,"untap","()Z");g.Check(g.Call(land,"isTapped","()Z").Int==0,"original untap reset land");
                int hand=g.Count(0,"Hand"),library=g.Count(0,"Library");g.Call(g.Players[0],"drawCards","(I)Lforge/game/card/CardCollectionView;",JValue.I(1));g.Check(g.Count(0,"Hand")==hand+1&&g.Count(0,"Library")==library-1,"draw moved one library card to hand");
                g.Fund(0,"W");int before=g.ManaCount(0);var creature=g.Card("Eager Cadet",0,"Hand");g.Check(g.Pay(g.Ability(creature,0),0)&&g.ManaCount(0)==before-1,"one white mana produced and consumed");g.Sba();g.Trace.Add("STACK/RESOLUTION NOT APPLICABLE: basic actions");
            }),
            ("B","divination",g=>
            {g.Fund(0,"U U U");var card=g.Card("Divination",0,"Hand");int hand=g.Count(0,"Hand"),library=g.Count(0,"Library");g.Check(g.Cast(card,g.Ability(card,0),0),"Divination cast accepted");g.ResolveOne();g.Sba();g.Check(g.Count(0,"Hand")==hand+1&&g.Count(0,"Library")==library-2&&g.In(card,"Graveyard"),"Divination drew two and went to graveyard");}),
            ("C","bolt-player",g=>
            {g.Fund(0,"R");var card=g.Card("Lightning Bolt",0,"Hand");var sa=g.Ability(card,0);g.Target(sa,g.Players[1]);int life=g.Life(1);g.Check(g.Cast(card,sa,0),"Bolt accepted");g.ResolveOne();g.Sba();g.Check(g.Life(1)==life-3,"original damage effect dealt three to opponent");}),
            ("C","bolt-creature",g=>BoltCreature(g)),
            ("C","arc-lightning",g=>
            {g.Fund(0,"R R R");var victim=g.Card("Hill Giant",1,"Battlefield");var card=g.Card("Arc Lightning",0,"Hand");var sa=g.Ability(card,0);g.Target(sa,g.Players[1],victim);g.Call(sa,"addDividedAllocation","(Lforge/game/GameObject;Ljava/lang/Integer;)V",g.Players[1],g.Rt.BoxInt(1));g.Call(sa,"addDividedAllocation","(Lforge/game/GameObject;Ljava/lang/Integer;)V",victim,g.Rt.BoxInt(2));int life=g.Life(1);g.Check(g.Cast(card,sa,0),"divided spell accepted");g.ResolveOne();g.Sba();g.Check(g.Life(1)==life-1&&g.Call(victim,"getDamage","()I").Int==2,"divided damage applied to both targets");}),
            ("D","one-mana-creature",g=>
            {g.Fund(0,"W");var card=g.Card("Eager Cadet",0,"Hand");g.Check(g.Cast(card,g.Ability(card,0),0),"one-mana creature accepted");g.ResolveOne();g.Sba();g.Check(g.In(card,"Battlefield")&&g.Call(card,"getNetToughness","()I").Int==1,"creature entered as a living 1/1");g.Check(g.Trace.Any(s=>s.Contains("trigger/TriggerHandler.runTrigger",StringComparison.Ordinal)),"original trigger handler executed for zone events");}),
            ("D","etb-draw-trigger",g=>
            {g.Fund(0,"G G G");var card=g.Card("Llanowar Visionary",0,"Hand");int hand=g.Count(0,"Hand"),library=g.Count(0,"Library");g.Check(g.Cast(card,g.Ability(card,0),0),"ETB creature accepted");g.ResolveOne();g.Sba();g.Drain();g.Check(g.In(card,"Battlefield")&&g.Count(0,"Library")==library-1&&g.Count(0,"Hand")==hand,"ETB trigger drew exactly one card");}),
            ("E","insufficient-mana",g=>
            {var card=g.Card("Divination",0,"Hand");g.Check(!g.Cast(card,g.Ability(card,0),0),"unpayable spell rejected");g.Check(g.Call(g.Stack,"size","()I").Int==0&&g.In(card,"Hand")&&g.ManaCount(0)==0,"rejected payment preserves hand and empty stack");g.Sba();}),
            ("E","illegal-target",g=>
            {g.Fund(0,"G");var card=g.Card("Giant Growth",0,"Hand");var sa=g.Ability(card,0);g.Check(g.Call(sa,"canTarget","(Lforge/game/GameObject;)Z",g.Players[1]).Int==0,"player is not a legal creature target");int mana=g.ManaCount(0);g.Check(!g.Cast(card,sa,0),"spell without required target rejected");g.Check(g.In(card,"Hand")&&g.ManaCount(0)==mana&&g.Call(g.Stack,"size","()I").Int==0,"target rejection preserves state");g.Sba();}),
            ("E","lethal-damage-sba",g=>BoltCreature(g)),
            ("C","giant-growth-legal",g=>
            {g.Fund(0,"G");var target=g.Card("Grizzly Bears",0,"Battlefield");var card=g.Card("Giant Growth",0,"Hand");var sa=g.Ability(card,0);g.Target(sa,target);g.Check(g.Cast(card,sa,0),"Growth accepted with legal creature");g.ResolveOne();g.Sba();g.Check(g.Call(target,"getNetPower","()I").Int==5&&g.Call(target,"getNetToughness","()I").Int==5,"Growth grants +3/+3");}),
            ("C","unsummon-legal",g=>
            {g.Fund(0,"U");var target=g.Card("Grizzly Bears",1,"Battlefield");var card=g.Card("Unsummon",0,"Hand");var sa=g.Ability(card,0);g.Target(sa,target);g.Check(g.Cast(card,sa,0),"Unsummon accepted with legal creature");g.ResolveOne();g.Sba();g.Check(g.In(target,"Hand"),"target returned to its owner's hand");}),
            ("C","counterspell-legal",g=>
            {g.SetMain(1);g.Fund(1,"U U U");var pending=g.Card("Divination",1,"Hand");var original=g.Ability(pending,1);g.Check(g.Cast(pending,original,1),"opponent spell on stack");g.SetMain(0);g.Fund(0,"U U");var card=g.Card("Counterspell",0,"Hand");var sa=g.Ability(card,0);g.Target(sa,original);int library=g.Count(1,"Library");g.Check(g.Cast(card,sa,0),"Counterspell accepted with pending spell target");g.ResolveOne();g.Sba();g.Check(g.Call(g.Stack,"size","()I").Int==0&&g.Count(1,"Library")==library&&g.In(pending,"Graveyard"),"countered spell removed without drawing");})
        };
        var rows=new List<MatrixResult>();
        foreach(var test in tests)
        {
            Console.WriteLine("MATRIX "+test.Group+" / "+test.Name);L3Game? game=null;Exception? failure=null;
            try{game=new(root,program,db);game.Initialize();game.Stage=test.Name;test.Body(game);}catch(Exception ex){failure=ex;}
            string file=test.Group+"-"+test.Name+".trace.log";
            string error=failure is JavaFault jf?jf.Value.ClassName+": "+failure:failure?.ToString()??"";
            var trace=game?.Trace??[];if(failure!=null)trace.Add("FAILURE "+error);File.WriteAllLines(Path.Combine(dir,file),trace.Select((line,index)=>$"{index:D7} {line}"));
            rows.Add(new(test.Group,test.Name,failure==null,game?.Stage??"host initialization",game?.Enqueued??0,game?.Resolved??0,game?.SbaChecks??0,game?.SbaChanges??0,game?.Assertions.ToArray()??[],error,file));
            Console.WriteLine(failure==null?"PASS":"FAIL "+(failure is JavaFault fault?fault.Value.ClassName+": ":"")+failure.Message);
        }
        File.WriteAllText(Path.Combine(dir,"matrix.json"),JsonSerializer.Serialize(new{schema=2,startedUtc,finishedUtc=DateTimeOffset.UtcNow,gameOrUiStarted=false,scope="Controlled original-engine scenarios; not full-turn or all-card certification",passed=rows.Count(r=>r.Passed),total=rows.Count,allPassed=rows.All(r=>r.Passed),groups=rows.GroupBy(r=>r.Group).Select(g=>new{group=g.Key,passed=g.Count(r=>r.Passed),total=g.Count(),enqueued=g.Sum(r=>r.Enqueued),resolved=g.Sum(r=>r.Resolved),sbaChecks=g.Sum(r=>r.SbaChecks),sbaChanges=g.Sum(r=>r.SbaChanges)}),cases=rows},new JsonSerializerOptions{WriteIndented=true}));Audit(root,program);return rows.All(r=>r.Passed)?0:2;
    }
    private sealed record MatrixResult(string Group,string Name,bool Passed,string Stage,int Enqueued,int Resolved,int SbaChecks,int SbaChanges,string[] Assertions,string Error,string Trace);
    private static void BoltCreature(L3Game g)
    {g.Fund(0,"R");var target=g.Card("Grizzly Bears",1,"Battlefield");var card=g.Card("Lightning Bolt",0,"Hand");var sa=g.Ability(card,0);g.Target(sa,target);g.Check(g.Cast(card,sa,0),"creature-targeting Bolt accepted");g.ResolveOne();g.Check(g.Call(target,"getDamage","()I").Int==3,"lethal damage marked before explicit SBA");g.Sba();g.Check(g.In(target,"Graveyard"),"SBA moved lethally damaged creature to graveyard");}
    public static void Run(string root,bool one=false)
    {
        string dir=BatchPaths.Output(root,"release/forge-l3");Directory.CreateDirectory(dir);var options=new JsonSerializerOptions{WriteIndented=true};
        void Save(string name,object value)=>File.WriteAllText(Path.Combine(dir,name),JsonSerializer.Serialize(value,options));
        var program=ForgeProgram.BuildForDevelopment();var db=CardDatabase.Load(Path.Combine(root,"data/forge"));
        var names=new[]{"Llanowar Visionary","Rest in Peace","Arc Lightning","Fireball","Divination","Healing Salve","Giant Growth","Unsummon","Raise the Alarm","Counterspell"};
        var results=new List<object>();
        foreach(string name in one?names.Take(1):names)
        {
            Console.WriteLine("L3 probe: "+name);var result=L3Probe.Execute(root,program,db,name);string file="trace-"+name.Replace(' ','-')+".json";Save(file,result);
            results.Add(new{name,game=result.GameConstructed,players=result.PlayersConstructed,reader=result.RulesRead,cardFactory=result.FactoryCreated,stackMounted=result.StackMounted,resolved=result.Resolved,sbaChecked=result.SbaChecked,mechanismAssertionsPassed=false,passed=false,phase=result.Phase,blocker=result.Error,trace=file});
            Console.WriteLine("Stopped at "+result.Phase+": "+result.Error.Split('\n')[0]);
        }
        Save(one?"single-probe.json":"mechanism-cases.json",new{required=10,attempted=results.Count,passed=0,l3PassRate=0,scope="Original engine readiness/stack attempt probes; complete mechanism scenarios remain unfinished",cases=results});
        if(!one)Audit(root,program);
    }
    public static void Audit(string root,JProgram? program=null)
    {
        string dir=BatchPaths.Output(root,"release/forge-l3");var rt=new JRuntime(program??ForgeProgram.BuildForDevelopment());var environment=new ConsoleEnvironment(_=>{});rt.InstallPlatformHost(environment);rt.InstallEnvironment(environment);
        using var before=JsonDocument.Parse(File.ReadAllText(Path.Combine(root,"release/forge-l3/baseline-references.json")));var keys=rt.BindingNames.ToHashSet();
        var rows=before.RootElement.GetProperty("rows").EnumerateArray().Select(row=>new{key=row.GetProperty("key").GetString()!,category=row.GetProperty("category").GetString()!,previouslyBound=row.GetProperty("bound").GetBoolean(),bound=keys.Contains(row.GetProperty("key").GetString()!),deadCodeProven=false}).ToArray();
        var report=new{baseline=rows.Length,baselineUnbound=rows.Count(r=>!r.previouslyBound),newlyBound=rows.Count(r=>!r.previouslyBound&&r.bound),newNative=rows.Count(r=>!r.previouslyBound&&r.bound&&r.category=="native-semantic-rewrite"),nativeBoundTotal=rows.Count(r=>r.bound&&r.category=="native-semantic-rewrite"),hostBoundTotal=rows.Count(r=>r.bound&&r.category=="host-policy-adapter"),unbound=rows.Count(r=>!r.bound),nativeRemaining=rows.Count(r=>!r.bound&&r.category=="native-semantic-rewrite"),hostRemaining=rows.Count(r=>!r.bound&&r.category=="host-policy-adapter"),regressions=rows.Count(r=>r.previouslyBound&&!r.bound),note="Direct signature binding is not semantic or gameplay coverage. Host routes require explicit environment installation; no dead code is proven.",modules=rows.GroupBy(r=>r.key[..r.key.IndexOf('.')]).Select(g=>new{module=g.Key,total=g.Count(),bound=g.Count(r=>r.bound),remaining=g.Count(r=>!r.bound)}).OrderByDescending(g=>g.remaining).ToArray(),rows};
        File.WriteAllText(Path.Combine(dir,"references.json"),JsonSerializer.Serialize(report,new JsonSerializerOptions{WriteIndented=true}));Console.WriteLine($"References: {report.newlyBound} newly bound ({report.newNative} native), {report.unbound} remain.");
        // The historic 686-entry baseline is Java-only. Do not silently imply
        // that it accounts for Guava/Apache or every other external dependency.
        using var linkage=JsonDocument.Parse(File.ReadAllText(Path.Combine(root,"migration/forge-aot/linkage-gaps.json")));
        var inventory=linkage.RootElement.GetProperty("methods").EnumerateArray().Select(row=>{
            string owner=row.GetProperty("owner").GetString()!,name=row.GetProperty("name").GetString()!,descriptor=row.GetProperty("descriptor").GetString()!;
            string key=owner+"."+name+descriptor;
            string family=owner.StartsWith("java/",StringComparison.Ordinal)?"java":owner.StartsWith("com/google/",StringComparison.Ordinal)?"guava":owner.StartsWith("org/apache/",StringComparison.Ordinal)?"apache":owner.StartsWith("[",StringComparison.Ordinal)?"arrays":"other";
            bool native=keys.Contains(key),generated=rt.Program.Classes.TryGetValue(owner,out var cls)&&cls.Methods.TryGetValue(name+descriptor,out var method)&&method.Body!=null;
            return new{key,family,directNativeBinding=native,directGeneratedBody=generated,requiresDispatchReview=!native&&!generated,callSites=row.GetProperty("callSites").GetArrayLength()};
        }).ToArray();
        File.WriteAllText(Path.Combine(dir,"all-external-reference-inventory.json"),JsonSerializer.Serialize(new{snapshot=HeadlessSuite.Snapshot,total=inventory.Length,note="Complete saved external-call inventory, not runtime failure count. Inherited methods, arrays and dynamic host dispatch require separate resolution; absence of a direct binding is not proof of failure or dead code.",families=inventory.GroupBy(row=>row.family).Select(group=>new{family=group.Key,total=group.Count(),directNative=group.Count(row=>row.directNativeBinding),directGenerated=group.Count(row=>row.directGeneratedBody),requiresDispatchReview=group.Count(row=>row.requiresDispatchReview)}).ToArray(),rows=inventory},new JsonSerializerOptions{WriteIndented=true}));
    }
}

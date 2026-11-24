using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;
using System.Text.Json;

public sealed partial class HeadlessMatch
{
    public static void OptionalCostRegression(string root,Action<bool,string> check)
    {
        var rows=new List<object>();
        foreach(var scenario in new[]{(Mana:2,Kick:false),(Mana:4,Kick:true),(Mana:4,Kick:false)})
        {
            string directory=BatchPaths.Output(root,"release/forge-headless/optional-cost-regression",scenario.Mana+"-"+scenario.Kick);Directory.CreateDirectory(directory);
            using var trace=new TraceJournal(directory);using var state=new StreamWriter(Path.Combine(directory,"snapshots.jsonl"));using var choices=new StreamWriter(Path.Combine(directory,"decisions.jsonl"));
            var driver=new HeadlessMatch(root,ForgeProgram.BuildForDevelopment(),CardDatabase.Load(Path.Combine(root,"data/forge")),new(4,43,4,[[],[]],"optional-cost-regression"),trace,state,new(43,choices));
            var g=driver.g;g.Initialize();g.Fund(0,new string('U',scenario.Mana));var victim=g.Card("Grizzly Bears",1,"Battlefield");var spell=g.Card("Blink of an Eye",0,"Hand");var sa=g.Ability(spell,0);
            var offered=driver.Items(driver.S("forge/game/GameActionUtil","getOptionalCostValues","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",sa));
            var legal=driver.OptionalCostOptions(sa,offered,0);check(legal.Length==(scenario.Mana==2?1:2)&&legal.Any(s=>s.Length==0),"Optional kicker queries include base casting and exclude unaffordable total costs");
            check(g.ManaCount(0)==scenario.Mana&&g.In(spell,"Hand"),"Optional-cost affordability queries consume no mana and move no card");
            var chosen=legal.Single(set=>(set.Length>0)==scenario.Kick);
            g.SetDecision("chooseOptionalCosts",(ctrl,a)=>JHostResult.Complete(g.Rt.ListOf(driver.OptionalCostOptions(a[0],driver.Items(a[1]),0).Single(set=>(set.Length>0)==scenario.Kick))));
            int library=g.Count(0,"Library"),hand=g.Count(0,"Hand");check(driver.Play(sa,0),"Blink of an Eye full casting transaction accepts affordable optional costs");
            check(g.ManaCount(0)==scenario.Mana-(scenario.Kick?4:2),"Engine consumes base 1U plus chosen kicker 1U exactly");g.ResolveOne();g.Sba();g.Drain();
            check(g.In(victim,"Hand")&&g.In(spell,"Graveyard"),"Blink of an Eye actually returns its nonland target to the owner's hand");
            check(g.Count(0,"Library")==library-(scenario.Kick?1:0)&&g.Count(0,"Hand")==hand-1+(scenario.Kick?1:0),"Kicked Blink draws exactly one; unkicked Blink draws none");driver.Snapshot("after affordable optional spell resolution");
            rows.Add(new{scenario.Mana,scenario.Kick,passed=true,driver.enqueued,driver.resolved,driver.sba,directory});
        }
        File.WriteAllText(BatchPaths.Output(root,"release/forge-headless/optional-cost-regression/result.json"),JsonSerializer.Serialize(new{passed=true,cases=rows},new JsonSerializerOptions{WriteIndented=true}));
    }
}

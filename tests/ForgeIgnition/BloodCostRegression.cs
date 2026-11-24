using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;
using System.Text.Json;

public sealed partial class HeadlessMatch
{
    public static void BloodCostRegression(string root,Action<bool,string> check)
    {
        string directory=BatchPaths.Output(root,"release/forge-headless/blood-cost-regression");Directory.CreateDirectory(directory);
        using var trace=new TraceJournal(directory);using var state=new StreamWriter(Path.Combine(directory,"snapshots.jsonl"));using var choices=new StreamWriter(Path.Combine(directory,"decisions.jsonl"));
        string report=Path.Combine(directory,"result.json");File.WriteAllText(report,"{\"passed\":false,\"status\":\"running-or-interrupted\"}");
        var driver=new HeadlessMatch(root,ForgeProgram.BuildForDevelopment(),CardDatabase.Load(Path.Combine(root,"data/forge")),new(4,99,4,[[],[]],"blood-cost-regression"),trace,state,new(99,choices));
        var g=driver.g;g.Initialize();g.Fund(0,"RRR");var servitor=g.Card("Blood Servitor",0,"Hand");var discarded=g.Card("Plains",0,"Hand");
        check(driver.Play(g.Ability(servitor,0),0),"Blood Servitor casts through full engine transaction");g.ResolveOne();g.Sba();g.Drain();
        var blood=driver.Zone(0,"Battlefield").Single(c=>driver.B(c,"isToken"));
        check(driver.C(driver.C(blood,"getType","()Lforge/card/CardTypeView;"),"hasSubtype","(Ljava/lang/String;)Z",g.S("Blood")).Int!=0,"Blood Servitor ETB actually creates Blood token");
        g.Fund(0,"R");var ability=driver.Items(driver.C(blood,"getSpellAbilities","()Lforge/util/collect/FCollectionView;")).Single(a=>driver.B(a,"isActivatedAbility"));
        driver.C(ability,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);int library=g.Count(0,"Library");
        driver.Snapshot("before Blood activation");check(driver.Play(ability,0),"Blood activation accepted through full transaction");
        check(g.ManaCount(0)==0&&g.In(discarded,"Graveyard")&&!driver.Zone(0,"Battlefield").Any(c=>driver.C(c,"getId","()I").Int==driver.C(blood,"getId","()I").Int),"Blood activation consumes mana, discards chosen card and sacrifices token before resolving");
        g.ResolveOne();g.Sba();driver.Snapshot("after Blood resolution and SBA");
        check(g.Count(0,"Library")==library-1&&g.Count(0,"Hand")==1,"Blood ability actually draws exactly one replacement card");
        check(g.Rt.ExecutedMethods.Any(m=>m.Contains("CostDiscard.doPayment"))&&g.Rt.ExecutedMethods.Any(m=>m.Contains("CostSacrifice.doListPayment"))&&g.Rt.ExecutedMethods.Any(m=>m.Contains("PlaySpellAbility.playAbility")),"Blood regression executes full casting, discard and sacrifice engine bodies");
        File.WriteAllText(report,JsonSerializer.Serialize(new{passed=true,card="Blood Servitor / Blood token",driver.enqueued,driver.resolved,driver.sba,methods=g.Rt.ExecutedMethods.Order().ToArray()},new JsonSerializerOptions{WriteIndented=true}));
    }
}

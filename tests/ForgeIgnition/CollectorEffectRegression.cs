using System.Text.Json;
using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;

public sealed partial class HeadlessMatch
{
    public static void CollectorEffectRegression(string root,Action<bool,string> check)
    {
        string dir=BatchPaths.Output(root,"release/forge-headless/collector-effect-regression");Directory.CreateDirectory(dir);
        using var trace=new TraceJournal(dir);using var state=new StreamWriter(Path.Combine(dir,"snapshots.jsonl"));using var choices=new StreamWriter(Path.Combine(dir,"decisions.jsonl"));
        var driver=new HeadlessMatch(root,ForgeProgram.BuildForDevelopment(),CardDatabase.Load(Path.Combine(root,"data/forge")),new(4,44,4,[[],[]],"collector-effect-regression"),trace,state,new(44,choices));var g=driver.g;g.Initialize();
        g.Card("Plains",0,"Battlefield");g.Card("Plains",0,"Battlefield");g.Card("Forest",0,"Battlefield");g.Fund(0,"W W W W W W");
        var card=g.Card("Excalbian Gamemaster",0,"Hand");var ability=g.Ability(card,0);
        check(driver.Play(ability,0)&&g.ManaCount(0)==0,"Excalbian Gamemaster pays 5W through the complete casting transaction");g.ResolveOne();g.Sba();g.Drain();
        var tokens=driver.Zone(0,"Battlefield").Where(c=>driver.B(c,"isToken")).ToArray();
        check(tokens.Length==2,"Distinct-land-name Collector.of effect creates exactly two tokens for Plains, Plains, Forest");
        check(tokens.All(c=>driver.C(c,"getNetPower","()I").Int==1&&driver.C(c,"getNetToughness","()I").Int==1&&driver.C(driver.C(c,"getColor","()Lforge/card/ColorSet;"),"getColor","()B").Int==8&&driver.C(driver.C(c,"getType","()Lforge/card/CardTypeView;"),"hasSubtype","(Ljava/lang/String;)Z",g.S("Officer")).Int!=0),"Actual ETB tokens are red 1/1 Officers");
        File.WriteAllText(Path.Combine(dir,"counters.json"),JsonSerializer.Serialize(new{driver.enqueued,driver.resolved,driver.sba,fixtureEnqueued=g.Enqueued,fixtureResolved=g.Resolved}));
        check(driver.enqueued==2&&driver.resolved==2&&g.Rt.ExecutedMethods.Any(m=>m.Contains("CardLists.getDifferentNamesCount")),"Creature and its real ETB trigger both entered and resolved through the generated distinct-name method");
        var diagnostic=new Exception("Synthetic diagnostic capture; no engine error injected");diagnostic.Data["Forge.FailureLocals"]=new[]{ability};int methods=g.Rt.ExecutedMethods.Count;
        check(driver.FailureCards(diagnostic).Any(c=>c.EndsWith(":Excalbian Gamemaster",StringComparison.Ordinal))&&g.Rt.ExecutedMethods.Count==methods,"Failure diagnostics identify a source card through CardTraitBase without executing more rules code");
        driver.Snapshot("ETB resolved after Collector family adaptation");File.WriteAllText(Path.Combine(dir,"result.json"),JsonSerializer.Serialize(new{passed=true,driver.enqueued,driver.resolved,driver.sba,scope="ETB distinct-land token effect, not whole-card certification"},new JsonSerializerOptions{WriteIndented=true}));
    }
}

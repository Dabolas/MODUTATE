using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;
using System.Text.Json;

public sealed partial class HeadlessMatch
{
    public static void ScryRegression(string root,Action<bool,string> check)
    {
        string directory=BatchPaths.Output(root,"release/forge-headless/scry-regression");Directory.CreateDirectory(directory);
        string report=Path.Combine(directory,"result.json");File.WriteAllText(report,"{\"passed\":false,\"status\":\"running-or-interrupted\"}");
        using var trace=new TraceJournal(directory);using var state=new StreamWriter(Path.Combine(directory,"snapshots.jsonl"));using var choices=new StreamWriter(Path.Combine(directory,"decisions.jsonl"));
        var driver=new HeadlessMatch(root,ForgeProgram.BuildForDevelopment(),CardDatabase.Load(Path.Combine(root,"data/forge")),new(4,31,4,[[],[]],"scry-regression"),trace,state,new(31,choices));
        var g=driver.g;g.Initialize();g.Fund(0,"UU");var construct=g.Card("Eager Construct",0,"Hand");
        int Id(JValue card)=>driver.C(card,"getId","()I").Int;
        var before=Enumerable.Range(0,2).Select(seat=>driver.Zone(seat,"Library")).ToArray();
        // This controlled case accepts the optional effect so both players actually
        // scry. Ordering and top/bottom decisions still use the production policy.
        g.SetDecision("confirmAction",(ctrl,a)=>JHostResult.Complete(JValue.I(1)));
        driver.Snapshot("before Eager Construct");check(driver.Play(g.Ability(construct,0),0),"Eager Construct casts with real two-mana payment");g.ResolveOne();g.Sba();g.Drain();driver.Snapshot("after ETB scry and SBA");
        check(g.ManaCount(0)==0&&g.In(construct,"Battlefield"),"Eager Construct remains on battlefield after consuming two mana");
        for(int seat=0;seat<2;seat++)
        {
            var decision=driver.tape.Records.Single(d=>d.Kind=="scry destination "+driver.Label(before[seat][0]));
            var expected=decision.Choice==0?before[seat]:before[seat].Skip(1).Append(before[seat][0]).ToArray();
            check(driver.Zone(seat,"Library").Select(Id).SequenceEqual(expected.Select(Id)),"Scry changes seat "+seat+" library to exactly the chosen top/bottom order");
            check(g.Count(seat,"Hand")==0&&g.Count(seat,"Graveyard")==0,"Scry reveals/reorders but does not draw or discard for seat "+seat);
        }
        check(driver.tape.Records.Count(d=>d.Kind.StartsWith("scry destination ",StringComparison.Ordinal))==2,"Both optional scry effects actually reach the decision callback");
        check(g.Rt.ExecutedMethods.Any(m=>m.Contains("aot/lambda/S435.iterator"))&&g.Rt.ExecutedMethods.Any(m=>m.Contains("GameAction.scry"))&&g.Rt.ExecutedMethods.Any(m=>m.Contains("ScryEffect.resolve")),"Scry regression executes BaseStream method reference, actual scry effect and zone ordering");
        File.WriteAllText(report,JsonSerializer.Serialize(new{passed=true,card="Eager Construct",scope="Both players accept ETB scry 1; exact library order and no unintended draws",driver.enqueued,driver.resolved,driver.sba,methods=g.Rt.ExecutedMethods.Order().ToArray()},new JsonSerializerOptions{WriteIndented=true}));
    }
}

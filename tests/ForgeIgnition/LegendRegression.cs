using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;
using System.Text.Json;

public sealed partial class HeadlessMatch
{
    public static void LegendRegression(string root,Action<bool,string> check)
    {
        string directory=BatchPaths.Output(root,"release/forge-headless/legend-regression");Directory.CreateDirectory(directory);
        string report=Path.Combine(directory,"result.json");File.WriteAllText(report,"{\"passed\":false,\"status\":\"running-or-interrupted\"}");
        using var trace=new TraceJournal(directory);using var state=new StreamWriter(Path.Combine(directory,"snapshots.jsonl"));using var choices=new StreamWriter(Path.Combine(directory,"decisions.jsonl"));
        var driver=new HeadlessMatch(root,ForgeProgram.BuildForDevelopment(),CardDatabase.Load(Path.Combine(root,"data/forge")),new(4,43,4,[[],[]],"legend-regression"),trace,state,new(43,choices));
        var g=driver.g;g.Initialize();var existing=g.Card("Rograkh, Son of Rohgahh",0,"Battlefield");var other=g.Card("Rograkh, Son of Rohgahh",1,"Battlefield");var copy=g.Card("Rograkh, Son of Rohgahh",0,"Hand");
        var data=driver.S("forge/StaticData","instance","()Lforge/StaticData;");var catalogue=driver.C(data,"getCommonCards","()Lforge/card/CardDb;");
        foreach(var item in new[]{("Grizzly Bears",true),("Ironfang",true),("Rograkh, Son of Rohgahh",false),("Plains",false),("Nonexistent Regression Face",false)})check(driver.C(catalogue,"isNonLegendaryCreatureName","(Ljava/lang/String;)Z",g.S(item.Item1)).Int==(item.Item2?1:0),"Original name classification uses actual main/alternate face types: "+item.Item1);
        check(driver.Play(g.Ability(copy,0),0),"Second Rograkh casts through the full zero-mana transaction");g.ResolveOne();g.Sba();g.Drain();
        check(driver.Zone(0,"Battlefield").Count(c=>g.Rt.StringValue(driver.C(c,"getName","()Ljava/lang/String;"))=="Rograkh, Son of Rohgahh")==1,"Legend SBA retains exactly one same-name legendary under the same controller");
        check(new[]{existing,copy}.Count(c=>g.In(c,"Graveyard"))==1&&g.In(other,"Battlefield"),"Legend SBA moves the unchosen legend to graveyard and leaves the opponent's copy alone");
        check(driver.tape.Records.Any(d=>d.Kind=="chooseSingleEntityForEffect"&&d.Options.Length==2),"Legend choice uses the two engine-offered legal permanents");driver.Snapshot("legend rule completed");
        File.WriteAllText(report,JsonSerializer.Serialize(new{passed=true,card="Rograkh, Son of Rohgahh",driver.enqueued,driver.resolved,driver.sba,methods=g.Rt.ExecutedMethods.Order().ToArray()},new JsonSerializerOptions{WriteIndented=true}));
    }
}

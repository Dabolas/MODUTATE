using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;
using System.Text.Json;

public sealed partial class HeadlessMatch
{
    public static void ExileCostRegression(string root,Action<bool,string> check)
    {
        string directory=BatchPaths.Output(root,"release/forge-headless/exile-cost-regression");Directory.CreateDirectory(directory);
        string report=Path.Combine(directory,"result.json");File.WriteAllText(report,"{\"passed\":false,\"status\":\"running-or-interrupted\"}");
        using var trace=new TraceJournal(directory);using var state=new StreamWriter(Path.Combine(directory,"snapshots.jsonl"));using var choices=new StreamWriter(Path.Combine(directory,"decisions.jsonl"));
        var driver=new HeadlessMatch(root,ForgeProgram.BuildForDevelopment(),CardDatabase.Load(Path.Combine(root,"data/forge")),new(4,43,4,[[],[]],"exile-cost-regression"),trace,state,new(43,choices));
        var g=driver.g;g.Initialize();g.Fund(0,"UUUU");var source=g.Card("Tah-Crop Skirmisher",0,"Graveyard");
        var sa=driver.Items(driver.C(source,"getAllPossibleAbilities","(Lforge/game/player/Player;Z)Ljava/util/List;",g.Players[0],JValue.I(1))).Single(a=>driver.B(a,"isEmbalm"));
        check(driver.B(sa,"canPlay")&&driver.Play(sa,0),"Embalm is a legal sorcery-speed graveyard activation with real 3U payment");
        check(g.In(source,"Exile")&&g.ManaCount(0)==0&&driver.Zone(0,"Battlefield").All(c=>!driver.B(c,"isToken")),"Engine exiles embalm source as a cost before creating any token");driver.Snapshot("embalm paid before resolution");g.ResolveOne();g.Sba();g.Drain();
        var tokens=driver.Zone(0,"Battlefield").Where(c=>driver.B(c,"isToken")).ToArray();check(tokens.Length==1,"Embalm resolution creates exactly one copy token");var token=tokens.Single();
        check(g.Rt.StringValue(driver.C(token,"getName","()Ljava/lang/String;"))=="Tah-Crop Skirmisher"&&driver.C(token,"getNetPower","()I").Int==2&&driver.C(token,"getNetToughness","()I").Int==1,"Embalmed token retains the original name and 2/1 statistics");
        check(driver.C(driver.C(token,"getColor","()Lforge/card/ColorSet;"),"getColor","()B").Int==1&&driver.B(driver.C(token,"getManaCost","()Lforge/card/mana/ManaCost;"),"isNoCost"),"Embalmed token is white and has no mana cost");
        var types=driver.C(token,"getType","()Lforge/card/CardTypeView;");check(new[]{"Zombie","Snake","Warrior"}.All(t=>driver.C(types,"hasSubtype","(Ljava/lang/String;)Z",g.S(t)).Int!=0),"Embalmed copy adds Zombie while retaining Snake and Warrior");
        check(g.In(source,"Exile")&&driver.enqueued==1&&driver.resolved==1,"Original card remains exiled after one actual activation resolution");driver.Snapshot("embalm token resolved");
        File.WriteAllText(report,JsonSerializer.Serialize(new{passed=true,card="Tah-Crop Skirmisher",driver.enqueued,driver.resolved,driver.sba,methods=g.Rt.ExecutedMethods.Order().ToArray()},new JsonSerializerOptions{WriteIndented=true}));
    }
}

using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;
using System.Text.Json;

public sealed partial class HeadlessMatch
{
    public static void ManaCounterRegression(string root,Action<bool,string> check)
    {
        string directory=BatchPaths.Output(root,"release/forge-headless/mana-counter-regression");Directory.CreateDirectory(directory);
        using var trace=new TraceJournal(directory);using var state=new StreamWriter(Path.Combine(directory,"snapshots.jsonl"));using var choices=new StreamWriter(Path.Combine(directory,"decisions.jsonl"));
        string report=Path.Combine(directory,"result.json");File.WriteAllText(report,"{\"passed\":false,\"status\":\"running-or-interrupted\"}");
        var driver=new HeadlessMatch(root,ForgeProgram.BuildForDevelopment(),CardDatabase.Load(Path.Combine(root,"data/forge")),new(4,113,4,[[],[]],"mana-counter-regression"),trace,state,new(113,choices));
        var g=driver.g;g.Initialize();var card=g.Card("Petalmane Baku",0,"Battlefield");
        var ki=driver.S("forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;",g.S("KI"));var counters=g.New("forge/game/GameEntityCounterTable","()V");
        driver.C(card,"addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V",ki,JValue.I(2),g.Players[0],counters);
        driver.C(counters,"replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V",g.Game,JValue.R(null));
        g.Fund(0,"G");var ability=driver.Items(driver.C(card,"getManaAbilities","()Lforge/util/collect/FCollectionView;")).Single();driver.C(ability,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);driver.C(ability,"setXManaCostPaid","(Ljava/lang/Integer;)V",g.Rt.BoxInt(2));
        check(driver.Play(ability,0),"Petalmane Baku activation uses full engine transaction");
        check(driver.C(card,"getCounters","(Lforge/game/card/CounterType;)I",ki).Int==0&&g.ManaCount(0)==2,"Petalmane Baku spends one mana and two ki counters, produces two mana");
        var amounts=new[]{1,2,4,8,16}.Select(c=>driver.C(g.ManaPool(0),"getAmountOfColor","(B)I",JValue.I(c)).Int).ToArray();check(amounts.Count(n=>n==2)==1&&amounts.Sum()==2,"Produced mana is all the chosen legal color");
        check(driver.B(g.Stack,"isEmpty")&&g.Rt.ExecutedMethods.Any(m=>m.Contains("ManaEffect.resolve")),"Mana ability resolves immediately without using spell stack");g.Sba();driver.Snapshot("after Petalmane Baku activation");
        File.WriteAllText(report,JsonSerializer.Serialize(new{passed=true,card="Petalmane Baku",produced=amounts,driver.sba,methods=g.Rt.ExecutedMethods.Order().ToArray()},new JsonSerializerOptions{WriteIndented=true}));
    }
}

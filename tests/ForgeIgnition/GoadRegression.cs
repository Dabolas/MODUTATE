using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;
using System.Text.Json;

public sealed partial class HeadlessMatch
{
    public static void GoadRegression(string root,Action<bool,string> check)
    {
        string directory=BatchPaths.Output(root,"release/forge-headless/goad-regression");Directory.CreateDirectory(directory);
        string report=Path.Combine(directory,"result.json");File.WriteAllText(report,"{\"passed\":false,\"status\":\"running-or-interrupted\"}");
        using var trace=new TraceJournal(directory);using var state=new StreamWriter(Path.Combine(directory,"snapshots.jsonl"));using var choices=new StreamWriter(Path.Combine(directory,"decisions.jsonl"));
        var driver=new HeadlessMatch(root,ForgeProgram.BuildForDevelopment(),CardDatabase.Load(Path.Combine(root,"data/forge")),new(4,23,4,[[],[]],"goad-regression"),trace,state,new(23,choices));
        var g=driver.g;g.Initialize();var source=g.Card("Sly Instigator",0,"Battlefield");var target=g.Card("Grizzly Bears",1,"Battlefield");var blocker=g.Card("Hill Giant",0,"Battlefield");
        // Initial fixture: Instigator has been controlled since before this turn.
        driver.C(source,"setSickness","(Z)V",JValue.I(0));g.Fund(0,"U");
        var ability=driver.Items(driver.C(source,"getSpellAbilities","()Lforge/util/collect/FCollectionView;")).Single(a=>driver.B(a,"isActivatedAbility"));
        driver.C(ability,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);
        check(driver.S("forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;)Z",target,blocker).Int!=0,"Ordinary opposing Bear can be blocked before Instigator effect");
        driver.Snapshot("before activation");check(driver.Play(ability,0),"Sly Instigator activates through full casting transaction");
        check(g.ManaCount(0)==0&&driver.B(source,"isTapped"),"Instigator actually consumes U and taps as its cost");
        var stacked=driver.C(g.Stack,"peek","()Lforge/game/spellability/SpellAbilityStackInstance;");
        string description=g.Rt.StringValue(driver.C(stacked,"getStackDescription","()Ljava/lang/String;"));
        check(description.Contains("Grizzly Bears",StringComparison.Ordinal)&&!description.Contains("{c:Targeted}",StringComparison.Ordinal),"Stack text tokenizer substitutes the actual target name");
        g.ResolveOne();g.Sba();driver.Snapshot("after effect and SBA");
        check(driver.C(g.Current(target),"isGoadedBy","(Lforge/game/player/Player;)Z",g.Players[0]).Int!=0,"Actual GoadEffect records the activating player as goader");
        check(driver.S("forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;)Z",g.Current(target),blocker).Int==0,"Resolved static effect makes the target unblockable");
        check(g.Rt.ExecutedMethods.Any(m=>m.Contains("SpellAbilityEffect.tokenizeString"))&&g.Rt.ExecutedMethods.Any(m=>m.Contains("GoadEffect.resolve")),"Real tokenizer and goad resolution paths complete");
        File.WriteAllText(report,JsonSerializer.Serialize(new{passed=true,card="Sly Instigator",scope="activation costs, target description, goad registration, block prohibition; next-turn expiration is not asserted here",driver.enqueued,driver.resolved,driver.sba,methods=g.Rt.ExecutedMethods.Order().ToArray()},new JsonSerializerOptions{WriteIndented=true}));
    }
}

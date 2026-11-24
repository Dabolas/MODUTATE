using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;
using System.Text.Json;

public sealed partial class HeadlessMatch
{
    public static void CounterCostRegression(string root,Action<bool,string> check)
    {
        string dir=BatchPaths.Output(root,"release/forge-headless/counter-cost-regression");Directory.CreateDirectory(dir);
        using var trace=new TraceJournal(dir);using var snapshots=new StreamWriter(Path.Combine(dir,"snapshots.jsonl"));using var decisions=new StreamWriter(Path.Combine(dir,"decisions.jsonl"));
        var driver=new HeadlessMatch(root,ForgeProgram.BuildForDevelopment(),CardDatabase.Load(Path.Combine(root,"data/forge")),new(4,17,4,[[],[]],"counter-cost-regression"),trace,snapshots,new(17,decisions));
        var g=driver.g;g.Initialize();
        var card=g.Card("Blademane Baku",0,"Battlefield");
        var ki=driver.S("forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;",g.S("KI"));
        var additions=g.New("forge/game/GameEntityCounterTable","()V");
        driver.C(card,"addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V",ki,JValue.I(3),g.Players[0],additions);
        driver.C(additions,"replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V",g.Game,default);
        var sa=driver.Items(driver.C(card,"getSpellAbilities","()Lforge/util/collect/FCollectionView;")).Single(a=>driver.Items(driver.C(driver.C(a,"getPayCosts","()Lforge/game/cost/Cost;"),"getCostParts","()Ljava/util/List;")).Any(p=>g.Rt.IsInstance(p.Reference!,"forge/game/cost/CostRemoveCounter")));
        driver.C(sa,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);
        int removed=0;
        foreach(int x in new[]{2,0,1})
        {
            g.Fund(0,"R");driver.C(sa,"setXManaCostPaid","(Ljava/lang/Integer;)V",g.Rt.BoxInt(x));
            check(driver.Play(sa,0),"Counter cost X="+x+" activated through CostPayment and MagicStack");removed+=x;
            int actual=driver.C(card,"getCounters","(Lforge/game/card/CounterType;)I",ki).Int,mana=g.ManaCount(0);driver.Snapshot("after counter cost, before resolution");
            check(actual==3-removed&&mana==0,$"Engine deducted exactly X counters and one mana before resolution: counters={actual}, expected={3-removed}, mana={mana}");
            g.ResolveOne();g.Sba();
            check(driver.C(g.Current(card),"getNetPower","()I").Int==1+2*removed,"Blademane Baku resolves +2 power for each counter actually paid");
            driver.Snapshot("counter payment X="+x);
        }
        driver.C(sa,"setXManaCostPaid","(Ljava/lang/Integer;)V",g.Rt.BoxInt(1));
        var cost=driver.C(sa,"getPayCosts","()Lforge/game/cost/Cost;");
        check(driver.C(cost,"canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",sa,g.Players[0],JValue.I(0)).Int==0,"Cannot pay another counter after all counters were removed");
        check(g.Rt.ExecutedMethods.Any(m=>m.Contains("CostRemoveCounter.payAsDecided"))&&g.Rt.ExecutedMethods.Any(m=>m.Contains("PumpEffect.resolve")),"Counter regression executes actual payment and effect bodies");
        File.WriteAllText(Path.Combine(dir,"result.json"),JsonSerializer.Serialize(new{passed=true,caseName="Blademane Baku counter cost",driver.enqueued,driver.resolved,driver.sba,methods=g.Rt.ExecutedMethods.Order().ToArray()}));
    }

}
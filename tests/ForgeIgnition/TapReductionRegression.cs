using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;
using System.Text.Json;

public sealed partial class HeadlessMatch
{
    public static void TapReductionRegression(string root,Action<bool,string> check)
    {
        var rows=new List<object>();
        foreach(string scenario in new[]{"convoke","improvise","waterbend"})
        {
            string directory=BatchPaths.Output(root,"release/forge-headless/tap-reduction-regression",scenario);Directory.CreateDirectory(directory);
            using var trace=new TraceJournal(directory);using var state=new StreamWriter(Path.Combine(directory,"snapshots.jsonl"));using var choices=new StreamWriter(Path.Combine(directory,"decisions.jsonl"));
            var driver=new HeadlessMatch(root,ForgeProgram.BuildForDevelopment(),CardDatabase.Load(Path.Combine(root,"data/forge")),new(4,44,4,[[],[]],"tap-reduction-"+scenario),trace,state,new(44,choices));
            var g=driver.g;g.Initialize();var payers=new List<JValue>();string name=scenario=="convoke"?"Triplicate Spirits":scenario=="improvise"?"Bastion Inventor":"Water Tribe Rallier";
            var card=g.Card(name,0,scenario=="waterbend"?"Battlefield":"Hand");
            int count=scenario=="convoke"?6:scenario=="improvise"?5:4;
            for(int i=0;i<count;i++)payers.Add(g.Card(scenario=="convoke"?"Eager Cadet":"Ornithopter",0,"Battlefield"));
            if(scenario=="waterbend")payers.Add(card);if(scenario=="improvise")g.Fund(0,"U");
            var sa=scenario=="waterbend"?driver.Items(driver.C(card,"getSpellAbilities","()Lforge/util/collect/FCollectionView;")).Single(a=>driver.B(a,"isActivatedAbility")):g.Ability(card,0);
            driver.C(sa,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);
            var adjusted=driver.S("forge/game/cost/CostAdjustment","adjust","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Z)Lforge/game/cost/Cost;",driver.C(sa,"getPayCosts","()Lforge/game/cost/Cost;"),sa,JValue.I(0));
            var mana=driver.C(driver.C(adjusted,"getCostMana","()Lforge/game/cost/CostPartMana;"),"getManaCostFor","(Lforge/game/spellability/SpellAbility;)Lforge/card/mana/ManaCost;",sa);
            int before=g.ManaCount(0);check(driver.PayMana(mana,sa,0,default,false,true),scenario+": engine and host find an affordable tap-payment plan");
            check(payers.All(c=>!driver.B(c,"isTapped"))&&g.ManaCount(0)==before,scenario+": payment simulation leaves permanents untapped and mana refunded");
            int[] top=driver.Zone(0,"Library").Take(4).Select(c=>driver.C(c,"getId","()I").Int).ToArray();int library=g.Count(0,"Library"),hand=g.Count(0,"Hand");
            check(driver.Play(sa,0),scenario+": real casting or activation transaction accepts the selected plan");
            check(payers.All(c=>driver.B(c,"isTapped"))&&g.ManaCount(0)==0,scenario+": engine taps every required source and consumes only the remaining mana");g.ResolveOne();g.Sba();g.Drain();
            if(scenario=="convoke")
            {
                var tokens=driver.Zone(0,"Battlefield").Where(c=>driver.B(c,"isToken")).ToArray();check(tokens.Length==3&&tokens.All(c=>driver.C(c,"getNetPower","()I").Int==1&&driver.C(c,"getNetToughness","()I").Int==1&&driver.C(c,"hasKeyword","(Ljava/lang/String;)Z",g.S("Flying")).Int!=0),"Convoke paid 4WW and Triplicate Spirits actually created three flying 1/1 Spirits");
            }
            else if(scenario=="improvise")check(g.In(card,"Battlefield")&&driver.C(g.Current(card),"getNetPower","()I").Int==4&&driver.C(g.Current(card),"getNetToughness","()I").Int==4,"Improvise pays five generic with artifacts and U with mana; Bastion Inventor enters 4/4");
            else
            {
                var bottom=driver.Zone(0,"Library").TakeLast(4).Select(c=>driver.C(c,"getId","()I").Int).Order().ToArray();
                check(g.Count(0,"Library")==library&&g.Count(0,"Hand")==hand&&bottom.SequenceEqual(top.Order()),"Waterbend pays five; no eligible creature in top four lands, so actual Dig puts all four on bottom");
            }
            driver.Snapshot("paid "+scenario+" and resolved");rows.Add(new{scenario,passed=true,driver.enqueued,driver.resolved,driver.sba,directory});
        }
        File.WriteAllText(BatchPaths.Output(root,"release/forge-headless/tap-reduction-regression/result.json"),JsonSerializer.Serialize(new{passed=true,cases=rows},new JsonSerializerOptions{WriteIndented=true}));
    }
}

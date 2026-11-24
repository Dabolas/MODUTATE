using System.Text.Json;
using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;

public sealed partial class HeadlessMatch
{
    public static void PreventEffectRegression(string root,Action<bool,string> check)
    {
        string directory=BatchPaths.Output(root,"release/forge-headless/prevent-effect-regression");Directory.CreateDirectory(directory);
        var outcomes=new List<object>();bool quickPaid=false,quickDeclined=false,lifePaid=false,lifeDeclined=false,wardPaid=false,wardDeclined=false;
        var program=ForgeProgram.BuildForDevelopment();var db=CardDatabase.Load(Path.Combine(root,"data/forge"));
        foreach(string scenario in new[]{"quickling","quickling-unpayable","sangrophage","sangrophage-unpayable","ward","ward-unpayable"})
        foreach(int seed in Enumerable.Range(1,4))
        {
            string dir=Path.Combine(directory,scenario+"-"+seed);Directory.CreateDirectory(dir);
            using var trace=new TraceJournal(dir);using var states=new StreamWriter(Path.Combine(dir,"snapshots.jsonl"));using var choices=new StreamWriter(Path.Combine(dir,"decisions.jsonl"));
            var input=new MatchInput(4,seed,4,[[],[]],scenario);
            File.WriteAllText(Path.Combine(dir,"input.json"),JsonSerializer.Serialize(input));
            var driver=new HeadlessMatch(root,program,db,input,trace,states,new(seed,choices));var g=driver.g;g.Initialize();
            bool unpayable=scenario.EndsWith("unpayable");bool paid;
            if(scenario.StartsWith("quickling"))
            {
                var other=unpayable?default:g.Card("Raging Goblin",0,"Battlefield");
                var opponent=g.Card("Raging Goblin",1,"Battlefield");var land=g.Card("Island",0,"Battlefield");
                var card=g.Card("Quickling",0,"Hand");g.Fund(0,"U U");
                check(driver.Play(g.Ability(card,0),0)&&g.ManaCount(0)==0,"Quickling pays actual 1U casting cost");
                g.ResolveOne();g.Sba();g.Drain();paid=g.In(card,"Battlefield");
                check(g.In(opponent,"Battlefield")&&g.In(land,"Battlefield"),"Return cost excludes opponents and noncreatures");
                check(unpayable?!paid&&g.In(card,"Graveyard"):paid?g.In(other,"Hand"):g.In(other,"Battlefield")&&g.In(card,"Graveyard"),"Quickling returns another creature or is actually sacrificed");
                if(!unpayable){quickPaid|=paid;quickDeclined|=!paid;}
            }
            else if(scenario.StartsWith("ward"))
            {
                var card=g.Card("Imoen, Mystic Trickster",1,"Battlefield");var bolt=g.Card("Lightning Bolt",0,"Hand");
                var ability=g.Ability(bolt,0);g.Target(ability,card);g.Fund(0,unpayable?"R":"R C C");
                check(g.Cast(bolt,ability,0),"Real Lightning Bolt targets Imoen and triggers ward");g.Sba();g.Drain();
                paid=g.In(card,"Graveyard");
                check(g.In(bolt,"Graveyard")&&(paid?g.ManaCount(0)==0:g.In(card,"Battlefield")&&driver.C(g.Current(card),"getDamage","()I").Int==0&&g.ManaCount(0)==(unpayable?0:2)),"Ward consumes two mana then permits lethal Bolt, or counters Bolt without damage or spending ward mana");
                check(!unpayable||!paid,"Unfunded ward cannot be paid");
                if(!unpayable){wardPaid|=paid;wardDeclined|=!paid;}
            }
            else
            {
                var card=g.Card("Sangrophage",0,"Battlefield");
                if(unpayable)driver.C(g.Players[0],"setLife","(ILforge/game/spellability/SpellAbility;)Z",JValue.I(1),default);
                int before=g.Life(0);
                var script=driver.C(card,"getSVar","(Ljava/lang/String;)Ljava/lang/String;",g.S("TrigTap"));
                var ability=driver.S("forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;",script,card);
                driver.C(ability,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);
                driver.Enqueue(ability);g.ResolveOne();paid=g.Life(0)==before-2;
                check(paid?!driver.B(card,"isTapped"):g.Life(0)==before&&driver.B(card,"isTapped"),"Sangrophage deducts exactly two life or taps without life payment");
                check(!unpayable||!paid,"Insufficient life cannot pay the cost");
                if(!unpayable){lifePaid|=paid;lifeDeclined|=!paid;}
            }
            check(g.Rt.ExecutedMethods.Any(m=>m.Contains("AbilityUtils.handleUnlessCost")),"Real engine unless-cost branch executes");
            driver.Snapshot("unless cost resolved");outcomes.Add(new{scenario,seed,paid});
        }
        check(quickPaid&&quickDeclined&&lifePaid&&lifeDeclined,"Deterministic seeds exercise payment and refusal for both real cards");
        check(wardPaid&&wardDeclined,"Ward exercises payment and refusal");
        File.WriteAllText(Path.Combine(directory,"result.json"),JsonSerializer.Serialize(new{passed=true,outcomes,scope="Quickling real ETB; Sangrophage printed upkeep effect resolved on stack; Imoen real ward trigger. Controlled fixtures, not strict match acceptance."},new JsonSerializerOptions{WriteIndented=true}));
    }
}


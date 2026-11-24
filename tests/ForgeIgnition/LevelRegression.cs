using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;
using System.Text.Json;

public sealed partial class HeadlessMatch
{
    public static void LevelRegression(string root,Action<bool,string> check)
    {
        string directory=BatchPaths.Output(root,"release/forge-headless/level-regression");Directory.CreateDirectory(directory);
        string report=Path.Combine(directory,"result.json");File.WriteAllText(report,"{\"passed\":false,\"status\":\"running-or-interrupted\"}");
        using var trace=new TraceJournal(directory);using var state=new StreamWriter(Path.Combine(directory,"snapshots.jsonl"));using var choices=new StreamWriter(Path.Combine(directory,"decisions.jsonl"));
        var driver=new HeadlessMatch(root,ForgeProgram.BuildForDevelopment(),CardDatabase.Load(Path.Combine(root,"data/forge")),new(4,13,4,[[],[]],"level-regression"),trace,state,new(13,choices));
        var g=driver.g;g.Initialize();var card=g.Card("Enclave Cryptologist",0,"Battlefield");driver.C(card,"setSickness","(Z)V",JValue.I(0));
        string? Api(JValue a)=>g.Rt.InspectEnumName(driver.C(a,"getApi","()Lforge/game/ability/ApiType;"));
        JValue[] Abilities()=>driver.Items(driver.C(g.Current(card),"getSpellAbilities","()Lforge/util/collect/FCollectionView;")).Where(a=>driver.B(a,"isActivatedAbility")).ToArray();
        var level=driver.S("forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;",g.S("LEVEL"));
        for(int n=1;n<=3;n++)
        {
            g.Fund(0,"UU");var ability=Abilities().Single(a=>Api(a)=="PutCounter");driver.C(ability,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);
            check(driver.Play(ability,0),"Enclave Cryptologist level "+n+" pays and enters stack");g.ResolveOne();g.Sba();
            var draw=Abilities().Where(a=>Api(a)=="Draw").ToArray();
            check(driver.C(g.Current(card),"getCounters","(Lforge/game/card/CounterType;)I",level).Int==n&&g.ManaCount(0)==0,"Level "+n+" adds exactly one counter and consumes 1U");
            check(draw.Length==1&&(driver.C(draw[0],"getSubAbility","()Lforge/game/spellability/AbilitySub;").Reference!=null)==(n<3),"Level "+n+" grants exactly the applicable looting/draw ability without stale lower-level ability");
            driver.Snapshot("level "+n+" after SBA");
        }
        var finalDraw=Abilities().Single(a=>Api(a)=="Draw");driver.C(finalDraw,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);int library=g.Count(0,"Library");
        check(driver.Play(finalDraw,0),"Level-three tap ability enters stack");g.ResolveOne();g.Sba();
        check(driver.B(g.Current(card),"isTapped")&&g.Count(0,"Hand")==1&&g.Count(0,"Library")==library-1&&g.Count(0,"Graveyard")==0,"Level-three ability actually taps and draws without the former discard");
        check(g.Rt.ExecutedMethods.Any(m=>m.Contains("StaticAbility.compareTo"))&&g.Rt.ExecutedBindings.Any(m=>m.Contains("ComparisonChain.compare")),"Level transitions exercise native comparison chain through actual static-layer recalculation");
        driver.Snapshot("level-three ability resolved");
        File.WriteAllText(report,JsonSerializer.Serialize(new{passed=true,card="Enclave Cryptologist",driver.enqueued,driver.resolved,driver.sba,methods=g.Rt.ExecutedMethods.Order().ToArray()},new JsonSerializerOptions{WriteIndented=true}));
    }
}

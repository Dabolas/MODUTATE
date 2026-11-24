using System.Text.Json;
using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;
public static class ApacheKeywordRegression
{
    public static void Run(string root,Action<bool,string> check)
    {
        string directory=BatchPaths.Output(root,"release/forge-headless/afterlife-regression");Directory.CreateDirectory(directory);using var trace=new TraceJournal(directory);
        var g=new L3Game(root,ForgeProgram.BuildForDevelopment(),CardDatabase.Load(Path.Combine(root,"data/forge")),false,trace.WriteLine);g.Rt.SynchronousInstructionLimit=100000000;g.Initialize();
        var victim=g.Card("Ministrant of Obligation",1,"Battlefield");var spell=g.Card("Lightning Bolt",0,"Hand");var sa=g.Ability(spell,0);g.Target(sa,victim);g.Fund(0,"R");
        check(g.Cast(spell,sa,0)&&g.ManaCount(0)==0,"Afterlife fixture casts a real paid damage spell at Ministrant of Obligation");g.ResolveOne();g.Sba();g.Drain();
        var tokens=g.Rt.ListItems(g.Call(g.Zone(1,"Battlefield"),"getCards","()Lforge/game/card/CardCollectionView;")).Where(c=>g.Call(c,"isToken","()Z").Int!=0).ToArray();
        check(g.In(victim,"Graveyard")&&tokens.Length==2,"Lethal damage SBA kills Ministrant and Afterlife 2 actually creates two Spirits");
        check(tokens.All(c=>g.Call(c,"getNetPower","()I").Int==1&&g.Call(c,"getNetToughness","()I").Int==1&&g.Call(g.Call(c,"getColor","()Lforge/card/ColorSet;"),"getColor","()B").Int==5&&g.Call(c,"hasKeyword","(Ljava/lang/String;)Z",g.S("Flying")).Int!=0),"Afterlife Spirits are white and black, flying, 1/1");
        check(g.Resolved==2&&g.Rt.ExecutedMethods.Any(m=>m.Contains("CardFactoryUtil.addTriggerAbility"))&&g.Rt.ExecutedMethods.Any(m=>m.Contains("TokenEffect.resolve")),"Afterlife initialization, death trigger and token resolution retain their original executed methods");
        File.WriteAllText(Path.Combine(directory,"result.json"),JsonSerializer.Serialize(new{passed=true,g.Enqueued,g.Resolved,g.SbaChecks,scope="Ministrant of Obligation Afterlife 2 death-trigger effect"},new JsonSerializerOptions{WriteIndented=true}));
    }
}

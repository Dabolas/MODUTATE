using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;
using System.Text.Json;

public sealed partial class HeadlessMatch
{
    public static void ManifestRegression(string root,Action<bool,string> check)
    {
        string directory=BatchPaths.Output(root,"release/forge-headless/manifest-regression");Directory.CreateDirectory(directory);
        string report=Path.Combine(directory,"result.json");File.WriteAllText(report,"{\"passed\":false,\"status\":\"running-or-interrupted\"}");
        using var trace=new TraceJournal(directory);using var state=new StreamWriter(Path.Combine(directory,"snapshots.jsonl"));using var choices=new StreamWriter(Path.Combine(directory,"decisions.jsonl"));
        var driver=new HeadlessMatch(root,ForgeProgram.BuildForDevelopment(),CardDatabase.Load(Path.Combine(root,"data/forge")),new(4,43,4,[[],[]],"manifest-regression"),trace,state,new(43,choices));
        var g=driver.g;g.Initialize();var scroll=g.Card("Scroll of Fate",0,"Battlefield");var victim=g.Card("Hill Giant",0,"Hand");int hand=g.Count(0,"Hand");
        var activation=driver.Items(driver.C(scroll,"getSpellAbilities","()Lforge/util/collect/FCollectionView;")).Single(a=>driver.B(a,"isActivatedAbility"));driver.C(activation,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);
        check(driver.Play(activation,0),"Scroll of Fate's real tap cost and manifest activation enter stack");g.ResolveOne();g.Sba();g.Drain();victim=g.Current(victim);
        check(driver.B(scroll,"isTapped")&&g.Count(0,"Hand")==hand-1&&g.In(victim,"Battlefield"),"Manifest removes the chosen hand card and moves it to battlefield");
        check(driver.B(victim,"isManifested")&&driver.B(victim,"isFaceDown")&&driver.B(victim,"isCreature")&&driver.C(victim,"getNetPower","()I").Int==2&&driver.C(victim,"getNetToughness","()I").Int==2,"Manifested Hill Giant is a face-down 2/2 creature");
        string key=g.Rt.StringValue(driver.C(victim,"getFacedownImageKey","()Ljava/lang/String;"));check(key.Length>2&&g.Rt.ExecutedMethods.Any(m=>m.Contains("forge/ImageKeys.getTokenKey",StringComparison.Ordinal)),"Headless view obtains a real fallback token key without opening images or bypassing manifest");driver.Snapshot("manifested 2/2");
        g.Fund(0,"RRRR");var up=driver.Items(driver.C(victim,"getAllPossibleAbilities","(Lforge/game/player/Player;Z)Ljava/util/List;",g.Players[0],JValue.I(1))).Single(a=>driver.B(a,"isManifestUp"));
        check(driver.B(up,"canPlay")&&driver.Play(up,0),"Engine permits and performs the manifested creature's paid turn-face-up action");g.Sba();g.Drain();
        check(!driver.B(victim,"isFaceDown")&&!driver.B(victim,"isManifested")&&g.ManaCount(0)==0&&driver.C(victim,"getNetPower","()I").Int==3&&driver.C(victim,"getNetToughness","()I").Int==3,"Paying Hill Giant's 3R restores its real 3/3 characteristics");driver.Snapshot("paid face-up special action");
        check(driver.enqueued==1&&driver.resolved==1,"Face-up special action and mana production are excluded from actual stack admission counts");
        File.WriteAllText(report,JsonSerializer.Serialize(new{passed=true,card="Scroll of Fate",manifested="Hill Giant",key,driver.enqueued,driver.resolved,driver.sba,methods=g.Rt.ExecutedMethods.Order().ToArray()},new JsonSerializerOptions{WriteIndented=true}));
    }
}

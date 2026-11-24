using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;
using System.Text.Json;

public static class TokenRegression
{
    public static void Run(string root,Action<bool,string> check)
    {
        string directory=BatchPaths.Output(root,"release/forge-headless/token-regression");Directory.CreateDirectory(directory);
        string report=Path.Combine(directory,"result.json");File.WriteAllText(report,"{\"passed\":false,\"status\":\"running-or-interrupted\"}");
        using var trace=new TraceJournal(directory);
        var db=CardDatabase.Load(Path.Combine(root,"data/forge"));var g=new L3Game(root,ForgeProgram.BuildForDevelopment(),db,false,trace.WriteLine);g.Rt.SynchronousInstructionLimit=10000000;g.Initialize();g.Fund(0,"WW");
        var spell=g.Card("Raise the Alarm",0,"Hand");var sa=g.Ability(spell,0);
        check(g.Cast(spell,sa,0)&&g.ManaCount(0)==0,"Raise the Alarm pays its real 1W cost and enters stack");g.ResolveOne();g.Sba();
        var tokens=g.Rt.ListItems(g.Call(g.Zone(0,"Battlefield"),"getCards","()Lforge/game/card/CardCollectionView;")).Where(c=>g.Call(c,"isToken","()Z").Int!=0).ToArray();
        check(tokens.Length==2,"Raise the Alarm actually creates exactly two battlefield tokens");
        foreach(var token in tokens)
        {
            check(g.Call(token,"getNetPower","()I").Int==1&&g.Call(token,"getNetToughness","()I").Int==1,"Soldier token computed P/T is 1/1");
            check(g.Call(g.Call(token,"getColor","()Lforge/card/ColorSet;"),"getColor","()B").Int==1&&g.Call(g.Call(token,"getType","()Lforge/card/CardTypeView;"),"hasSubtype","(Ljava/lang/String;)Z",g.S("Soldier")).Int!=0,"Token is white and has Soldier subtype");
            check(ReferenceEquals(g.Call(token,"getController","()Lforge/game/player/Player;").Reference,g.Players[0].Reference),"Token belongs to the resolving spell's controller");
        }
        check(g.In(spell,"Graveyard")&&g.Call(g.Stack,"isEmpty","()Z").Int!=0,"Raise the Alarm finishes in graveyard with an empty stack");
        check(g.Rt.ExecutedMethods.Any(m=>m.Contains("TokenInfo.getProtoType"))&&g.Rt.ExecutedMethods.Any(m=>m.Contains("TokenEffect.resolve")),"Token regression passes through prototype creation and actual TokenEffect");
        var definition=db.Create("Raise the Alarm").Definition;
        File.WriteAllText(report,JsonSerializer.Serialize(new{passed=true,card=definition.Name,ruleText=definition.Value("Oracle"),sourceHash=definition.Sha256,g.Enqueued,g.Resolved,g.SbaChecks,tokens=tokens.Select(t=>new{id=g.Call(t,"getId","()I").Int,name=g.Rt.StringValue(g.Call(t,"getName","()Ljava/lang/String;")),power=g.Call(t,"getNetPower","()I").Int,toughness=g.Call(t,"getNetToughness","()I").Int}).ToArray(),methods=g.Rt.ExecutedMethods.Order().ToArray()},new JsonSerializerOptions{WriteIndented=true}));
    }
}

using System.Text.Json;
using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;

public sealed partial class HeadlessMatch
{
    public static void CraftPaidListRegression(string root,Action<bool,string> check)
    {
        var directory=BatchPaths.Output(root,"release/forge-headless/craft-paid-list");
        Directory.CreateDirectory(directory);
        var db=CardDatabase.Load(Path.Combine(root,"data/forge"));
        var program=ForgeProgram.BuildForDevelopment();
        foreach(string zone in new[]{"Battlefield","Graveyard"}){
            var dir=Directory.CreateDirectory(Path.Combine(directory,zone)).FullName;
            var input=new MatchInput(4,225,4,[[],[]],"craft-paid-list");
            File.WriteAllText(Path.Combine(dir,"input.json"),JsonSerializer.Serialize(new{input,source="Oteclan Landmark",material="Memnite",zone,mana="CCW"}));
            using var trace=new TraceJournal(dir);
            using var states=new StreamWriter(Path.Combine(dir,"snapshots.jsonl"));
            using var choices=new StreamWriter(Path.Combine(dir,"decisions.jsonl"));
            var assertions=new List<string>();
            string? error=null;
            void Verify(bool ok,string label){check(ok,label);assertions.Add(label);}
            try{
                var d=new HeadlessMatch(root,program,db,input,trace,states,new(input.Seed,choices));
                var g=d.g;
                g.Initialize();
                var landmark=g.Card("Oteclan Landmark",0,"Battlefield");
                var material=g.Card("Memnite",0,zone);
                g.Fund(0,"CCW");
                var ability=d.Items(d.C(landmark,"getAllPossibleAbilities","(Lforge/game/player/Player;Z)Ljava/util/List;",g.Players[0],JValue.I(1))).Single(a=>d.B(a,"isCraft"));
                d.Snapshot("before craft with artifact from "+zone);
                Verify(d.Play(ability,0)&&d.Items(g.Stack).Length==1,"Craft entered the stack");
                Verify(g.ManaCount(0)==0&&g.In(landmark,"Exile")&&g.In(material,"Exile"),"Paid 2W and exiled source plus the other artifact");
                g.Drain();
                var result=d.Zone(0,"Battlefield").Single(c=>g.Rt.StringValue(d.C(c,"getName","()Ljava/lang/String;"))=="Oteclan Levitator");
                Verify(g.In(material,"Exile")&&d.C(result,"getNetPower","()I").Int==1&&d.C(result,"getNetToughness","()I").Int==4,"Returned transformed as the 1/4 Levitator; material remains in exile");
                var retained=d.Items(d.C(result,"getExiledCards","()Lforge/game/card/CardCollectionView;"));
                Verify(retained.Length==1&&d.C(retained[0],"getId","()I").Int==d.C(material,"getId","()I").Int,"Retained exactly the paid material, excluding the source");
                Verify(d.C(retained[0],"getExiledWith","()Lforge/game/card/Card;").Reference==result.Reference&&
                    d.C(retained[0],"getExiledBy","()Lforge/game/player/Player;").Reference==g.Players[0].Reference,"Material points back to the transformed permanent and paying player");
                Verify(g.Rt.ExecutedMethods.Contains("forge/game/spellability/SpellAbility.getPaidList(Ljava/lang/String;)Ljava/lang/Iterable;"),"Resolution read the combined paid-card list");
                d.Snapshot("after craft resolution");
            }catch(Exception ex){error=ex.Message;trace.WriteLine(ex.ToString());throw;}
            finally{File.WriteAllText(Path.Combine(dir,"result.json"),JsonSerializer.Serialize(new{zone,passed=error==null,assertions,error}));}
        }
    }
}

using System.Text.Json;
using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;

public static class L3Probe
{
    public sealed record ProbeResult(string? Name,bool Ready,string Phase,string Error,bool GameConstructed,int PlayersConstructed,bool RulesRead,bool FactoryCreated,bool StackMounted,bool Resolved,bool SbaChecked,string[] Trace);
    public static ProbeResult Execute(string root,JProgram program,CardDatabase? database=null,string? cardName=null)
    {
        var rt=new JRuntime(program);var trace=new List<string>();rt.Trace=trace.Add;
        ConsoleLocalization.Install(rt,new ConsoleLocalization(Path.Combine(root,"data/runtime/en-US.properties")));
        rt.InstallEventBus(new Dictionary<string,(string,string)>{["forge/game/GameLogFormatter"]=("recieve","forge/game/event/GameEvent")});
        rt.InstallDiagnosticLog(line=>trace.Add("diagnostic "+line));
        rt.InstallBreadcrumbSink((message,data)=>trace.Add("breadcrumb "+message+" "+string.Join(", ",data.Select(pair=>pair.Key+"="+(pair.Value.Reference?.ClassName=="java/lang/String"?rt.StringValue(pair.Value):pair.Value.Reference?.ClassName??"null")))));
        var environment=new ConsoleEnvironment(line=>trace.Add("output "+line));rt.InstallEnvironment(environment);rt.InstallPlatformHost(environment);
        string phase="GameType",error="";bool ready=false,gameConstructed=false,rulesRead=false,factoryCreated=false,stackMounted=false,resolved=false,sbaChecked=false;int playersConstructed=0;
        try
        {
            AotDamageBridge.Run(rt,rt.Program.Classes["forge/game/GameType"].Methods["values()[Lforge/game/GameType;"],default,[]);
            phase="GameRules";
            var type=rt.GetStatic("forge/game/GameType","Constructed","Lforge/game/GameType;");
            var rules=AotDamageBridge.Construct(rt,"forge/game/GameRules","(Lforge/game/GameType;)V",[type]);
            phase="Match";
            var players=rt.ListOf([]);
            var match=AotDamageBridge.Construct(rt,"forge/game/Match","(Lforge/game/GameRules;Ljava/util/List;Ljava/lang/String;)V",[rules,players,JValue.R(rt.String("Console initialization probe"))]);
            phase="Game (empty roster constructor probe, not a match)";
            var random=JValue.R(rt.Allocate("java/util/Random"));AotDamageBridge.Run(rt,ContractChecks.CallEntry("java/util/Random","<init>","(J)V",random,[JValue.L(42)],"invokespecial"),default,[]);
            AotDamageBridge.Run(rt,rt.Program.Classes["forge/util/MyRandom"].Methods["setRandom(Ljava/util/Random;)V"],default,[random]);
            var game=AotDamageBridge.Construct(rt,"forge/game/Game","(Ljava/lang/Iterable;Lforge/game/GameRules;Lforge/game/Match;)V",[players,rules,match]);
            gameConstructed=true;var seats=new List<JValue>();
            phase="Player";
            for(int seat=0;seat<2;seat++)
            {
                var player=AotDamageBridge.Construct(rt,"forge/game/player/Player","(Ljava/lang/String;Lforge/game/Game;I)V",[JValue.R(rt.String("Console Player "+seat)),game,JValue.I(seat)]);
                seats.Add(player);playersConstructed++;
                foreach(string getter in new[]{"getPlayers","getRegisteredPlayers"})
                {var collection=AotDamageBridge.Run(rt,rt.Program.Classes["forge/game/Game"].Methods[getter+"()Lforge/game/player/PlayerCollection;"],game,[]);AotDamageBridge.Run(rt,ContractChecks.CallEntry("forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z",collection,[player]),default,[]);}
            }
            phase="Card constructor";
            AotDamageBridge.Construct(rt,"forge/game/card/Card","(ILforge/game/Game;)V",[JValue.I(1),game]);
            if(cardName!=null)
            {
                phase="CardRules in game runtime";
                var reader=new AotCardReader(program,Path.Combine(root,"src/Forge.ConsoleHost/Data/TypeLists.txt"),database!);reader.Attach(rt);var read=reader.Attempt(database!.Create(cardName).Definition);rulesRead=read.Passed;
                if(!read.Passed)throw new PortGap(read.Error);
                phase="PaperCard";
                var rarity=rt.GetStatic("forge/card/CardRarity","Common","Lforge/card/CardRarity;");
                var paper=AotDamageBridge.Construct(rt,"forge/item/PaperCard","(Lforge/card/CardRules;Ljava/lang/String;Lforge/card/CardRarity;)V",[reader.LastRules,JValue.R(rt.String("CONSOLE")),rarity]);
                phase="CardFactory";
                var card=AotDamageBridge.Run(rt,program.Classes["forge/game/card/CardFactory"].Methods["getCard(Lforge/item/IPaperCard;Lforge/game/player/Player;Lforge/game/Game;)Lforge/game/card/Card;"],default,[paper,seats[0],game]);factoryCreated=true;
                phase="SpellAbility / fixture preconditions";
                var sa=AotDamageBridge.Run(rt,ContractChecks.CallEntry("forge/game/card/Card","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;",card,[]),default,[]);
                if(sa.Reference==null)throw new PortGap("Card has no first spell ability.");
                AotDamageBridge.Run(rt,ContractChecks.CallEntry("forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V",sa,[seats[0]]),default,[]);
                phase="MagicStack.add";
                var stack=AotDamageBridge.Run(rt,program.Classes["forge/game/Game"].Methods["getStack()Lforge/game/zone/MagicStack;"],game,[]);
                AotDamageBridge.Run(rt,ContractChecks.CallEntry("forge/game/zone/MagicStack","add","(Lforge/game/spellability/SpellAbility;)V",stack,[sa]),default,[]);
                stackMounted=AotDamageBridge.Run(rt,ContractChecks.CallEntry("forge/game/zone/MagicStack","size","()I",stack,[]),default,[]).Int>0;
                if(!stackMounted)throw new InvalidOperationException("MagicStack.add returned without a stack item.");
                phase="MagicStack.resolveStack";AotDamageBridge.Run(rt,ContractChecks.CallEntry("forge/game/zone/MagicStack","resolveStack","()V",stack,[]),default,[]);resolved=true;
                phase="GameAction.checkStateEffects";
                var action=AotDamageBridge.Run(rt,program.Classes["forge/game/Game"].Methods["getAction()Lforge/game/GameAction;"],game,[]);
                AotDamageBridge.Run(rt,ContractChecks.CallEntry("forge/game/GameAction","checkStateEffects","(Z)Z",action,[JValue.I(1)]),default,[]);sbaChecked=true;
                // Do not count call completion as mechanism correctness: these probes do not
                // yet implement legal costs/targets, event assertions or a complete match host.
                phase="mechanism assertions unavailable";
                throw new PortGap("Stack/SBA calls alone do not prove this mechanism: full payment/targets/postcondition fixtures still required.");
            }
            ready=true;
        }
        catch(Exception ex){error=ex.ToString();}
        return new(cardName,ready,phase,error,gameConstructed,playersConstructed,rulesRead,factoryCreated,stackMounted,resolved,sbaChecked,trace.ToArray());
    }
    public static void Run(string root)
    {
        string dir=Path.Combine(root,"release/forge-l3");Directory.CreateDirectory(dir);var result=Execute(root,ForgeProgram.BuildForDevelopment());
        File.WriteAllText(Path.Combine(dir,"bootstrap.json"),JsonSerializer.Serialize(result,new JsonSerializerOptions{WriteIndented=true}));
        Console.WriteLine($"Bootstrap ready={result.Ready}, phase={result.Phase}: {result.Error}");foreach(string line in result.Trace.TakeLast(15))Console.WriteLine(line);
    }
}

using System.IO.Compression;
using System.Text.Json;
using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;

public sealed partial class HeadlessMatch
{
    private readonly L3Game g;
    private readonly CardDatabase catalogue;
    private readonly DecisionTape tape;
    private readonly StreamWriter snapshots;
    private int step,enqueued,resolved,sba,priorityDecisions;
    private string stage="bootstrap";
    private string? lastSignature;
    private readonly List<string> castingCheckpoints=[];
    private bool recordingCast;
    private readonly Queue<string> tail=[];
    private readonly MatchInput input;
    private readonly Dictionary<int,string> initialCards=[];
    private static string? FailureCategory(Exception? error)
    {
        if(error==null)return null;
        string top=error.StackTrace?.Split('\n').FirstOrDefault()??"";
        if(error is HostDecisionGap||error.Message.Contains("PlayerController")||error.Message.Contains("headless/CostDecisions")||top.Contains("HeadlessDecisions.cs")||error.Message.Contains("instruction limit"))return "c-host-policy";
        return error is PortGap&&error.Message.StartsWith("Unlinked")?"a-missing-binding":"b-runtime-or-rule";
    }
    private HeadlessMatch(string root,JProgram program,CardDatabase db,MatchInput config,TraceJournal trace,StreamWriter state,DecisionTape decisions)
    {
        input=config;tape=decisions;snapshots=state;catalogue=db;
        g=new(root,program,db,true,line=>{trace.WriteLine(line);tail.Enqueue(line);if(tail.Count>120)tail.Dequeue();if(line.Contains("JAVA STACK\n"))lastSignature=line.Split("JAVA STACK\n")[1].Split('\n')[0];});
        g.Rt.SynchronousInstructionLimit=100000000;
        g.Rt.MethodReturned=(frame,value)=>{
            if(recordingCast && frame.Method.Descriptor.EndsWith(")Z") &&
                (frame.Method.Owner is "forge/game/player/PlaySpellAbility" or "forge/game/cost/CostPayment" or "forge/game/cost/CostAdjustment" or "forge/game/ability/effects/CharmEffect" ||
                 frame.Method.Name is "checkRestrictions" or "setupTargets" or "canCastTiming" or "isLegalAfterStack" or "payAsDecided"))
                castingCheckpoints.Add(frame.Method.Owner+"."+frame.Method.Name+"="+(value.Int!=0));
            // Count the engine's actual stack-admission event, including copies and
            // triggers. A successful special action or mana ability is not an enqueue.
            if(frame.Method.Owner=="forge/game/event/GameEventSpellAbilityCast"&&frame.Method.Name=="<init>"&&frame.Method.Descriptor=="(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbilityStackInstance;I)V")enqueued++;
            if(frame.Method.Owner=="forge/game/zone/MagicStack"&&frame.Method.Name=="resolveStack")resolved++;
            if(frame.Method.Owner=="forge/game/GameAction"&&frame.Method.Name=="checkStateEffects"&&frame.Method.Descriptor=="(ZLjava/util/Set;)Z")sba++;
        };
        InstallDecisions();
        if(input.Mode=="discovery")tape.BeforeDecision=()=>{if(g.Game.Reference!=null&&g.Phase.Reference!=null&&g.Players.Count==2)Snapshot("decision checkpoint "+tape.Records.Count+"; inspection only, not resumable");};
    }
    private void Snapshot(string reason)
    {
        object[] Counters(JValue entity)=>Items(C(C(entity,"getCounters","()Lcom/google/common/collect/Multiset;"),"entrySet","()Ljava/util/Set;")).Select(e=>(object)new{type=Label(C(e,"getElement","()Ljava/lang/Object;")),count=C(e,"getCount","()I").Int}).ToArray();
        var phase=C(g.Phase,"getPhase","()Lforge/game/phase/PhaseType;");var seen=new HashSet<int>();
        var players=Enumerable.Range(0,g.Players.Count).Select(seat=>new{seat,life=g.Life(seat),mana=g.ManaCount(seat),counters=Counters(g.Players[seat]),manaByColor=new[]{1,2,4,8,16,0}.Select(color=>new{color,amount=C(g.ManaPool(seat),"getAmountOfColor","(B)I",JValue.I(color)).Int}).ToArray(),zones=new[]{"Battlefield","Hand","Library","Graveyard","Exile","Command"}.ToDictionary(zone=>zone,zone=>Zone(seat,zone).Select(card=>{
            int id=C(card,"getId","()I").Int;if(!seen.Add(id))throw new InvalidOperationException("Card appears in two zones: "+id);
            if(C(card,"isInZone","(Lforge/game/zone/ZoneType;)Z",g.Enum("forge/game/zone/ZoneType",zone)).Int==0)throw new InvalidOperationException("Card zone disagrees with containing zone: "+id+" "+zone);
            return new{id,name=g.Rt.StringValue(C(card,"getName","()Ljava/lang/String;")),tapped=B(card,"isTapped"),damage=C(card,"getDamage","()I").Int,counters=Counters(card),power=zone=="Battlefield"&&B(card,"isCreature")?(int?)C(card,"getNetPower","()I").Int:null,toughness=zone=="Battlefield"&&B(card,"isCreature")?(int?)C(card,"getNetToughness","()I").Int:null};}).ToArray())}).ToArray();
        snapshots.WriteLine(JsonSerializer.Serialize(new{step,reason,decisionIndex=tape.Records.Count,decisionRandomState=tape.RandomState,resumable=false,turn=C(g.Phase,"getTurn","()I").Int,phase=phase.Reference==null?null:g.Rt.InspectEnumName(phase),priority=Seat(C(g.Phase,"getPriorityPlayer","()Lforge/game/player/Player;")),stack=C(g.Stack,"size","()I").Int,enqueued,resolved,sba,players}));snapshots.Flush();
    }
    private void Start()
    {
        stage="registered decks / prepareAllZones";g.Initialize(0,input.Seed,input.Decks,false);
        for(int seat=0;seat<2;seat++)foreach(var card in Zone(seat,"Library"))initialCards.Add(C(card,"getId","()I").Int,g.Rt.StringValue(C(card,"getName","()Ljava/lang/String;")));
        Snapshot("shuffled initial decks");stage="opening hands and London mulligans";
        var first=Pick("starting player",Items(C(g.Game,"getPlayers","()Lforge/game/player/PlayerCollection;")));
        C(g.Action,"runPreOpeningHandActions","(Lforge/game/player/Player;)V",first);
        if(input.OpeningFocus!=null)ArrangeOutcomeOpening(input.OpeningFocus);
        C(g.Game,"setAge","(Lforge/game/GameStage;)V",g.Enum("forge/game/GameStage","Mulligan"));
        foreach(var p in g.Players)C(p,"drawCards","(I)Lforge/game/card/CardCollectionView;",C(p,"getStartingHandSize","()I"));
        // A complete London sequence can rebuild both 60-card zones several times.
        // Keep it bounded, but do not confuse the per-step instruction budget with a rule failure.
        g.Rt.SynchronousInstructionLimit=200000000;
        C(g.New("forge/game/mulligan/MulliganService","(Lforge/game/player/Player;)V",first),"perform","()V");
        g.Rt.SynchronousInstructionLimit=100000000;
        foreach(var p in g.Players)C(p,"runStartGameScripts","()V");
        C(g.Game,"setAge","(Lforge/game/GameStage;)V",g.Enum("forge/game/GameStage","Play"));
        first=C(g.Action,"runOpeningHandActions","(Lforge/game/player/Player;)Lforge/game/player/Player;",first);
        C(g.Action,"checkStateEffects","(Z)Z",JValue.I(1));
        C(C(g.Game,"getTriggerHandler","()Lforge/game/trigger/TriggerHandler;"),"runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V",g.Enum("forge/game/trigger/TriggerType","NewGame"),S("forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;"),JValue.I(1));
        C(g.Game,"setStartingPlayer","(Lforge/game/player/Player;)V",first);C(g.Phase,"setupFirstTurn","(Lforge/game/player/Player;Ljava/lang/Runnable;)V",first,default);
        Snapshot("first turn prepared");
    }
    public static int Run(string root,MatchInput input,string directory,ReplayDecision[]? replay=null)
    {
        if(input.Version is not (1 or 2 or 3 or 4))throw new InvalidDataException("Unsupported decision policy version: "+input.Version);
        EngineBuild.RequireStageZero(root);
        Directory.CreateDirectory(directory);File.WriteAllText(Path.Combine(directory,"input.json"),JsonSerializer.Serialize(input,new JsonSerializerOptions{WriteIndented=true}));
        File.WriteAllText(Path.Combine(directory,"build.json"),JsonSerializer.Serialize(new{snapshot=HeadlessSuite.Snapshot,files=EngineBuild.Fingerprint(root)},new JsonSerializerOptions{WriteIndented=true}));
        using var trace=new TraceJournal(directory);
        using var state=new StreamWriter(Path.Combine(directory,"snapshots.jsonl"));using var choices=new StreamWriter(Path.Combine(directory,"decisions.jsonl"));
        HeadlessMatch? driver=null;Exception? failure=null;string termination="failed";
        try
        {
            driver=new(root,ForgeProgram.BuildForDevelopment(),CardDatabase.Load(Path.Combine(root,"data/forge")),input,trace,state,new(input.Seed,choices,replay));driver.Start();
            while(!driver.B(driver.g.Game,"isGameOver"))
            {
                if(driver.C(driver.g.Phase,"getTurn","()I").Int>input.TurnLimit){termination="turn-limit";break;}
                if(driver.step++>=input.TurnLimit*1000)throw new InvalidOperationException("Action watchdog: no legal progress within bounded steps");
                driver.stage="PhaseHandler.mainLoopStep";driver.priorityDecisions=0;
                if(input.Version>=4)driver.g.Rt.InvokeSynchronousWithBudget("forge/game/phase/PhaseHandler","mainLoopStep","()V",driver.g.Phase,[],500000000);
                else driver.C(driver.g.Phase,"mainLoopStep","()V");
                driver.Snapshot("after engine step");
            }
            if(driver.B(driver.g.Game,"isGameOver"))termination="engine-game-over";
            if((input.Mode=="full-pool-random"||input.Mode=="directed")&&termination!="engine-game-over")
                throw new InvalidOperationException("Strict match ended without engine game over: "+termination);
            if(driver.enqueued==0||driver.resolved==0||driver.sba==0)throw new InvalidOperationException("No actual spell lifecycle observed; match cannot count as validated");
            driver.tape.VerifyReplayConsumed();
            if(input.OpeningFocus!=null)driver.SaveOutcomeEvidence(directory,input.OpeningFocus);
        }
        catch(Exception ex){failure=ex;if(driver!=null&&ex.Data["Forge.JavaStack"] is string origin&&!string.IsNullOrWhiteSpace(origin))driver.lastSignature=origin.Split('\n')[0];trace.WriteLine(ex.ToString());}
        var result=new{passed=failure==null&&input.Mode!="discovery",executionCompleted=failure==null,acceptanceEligible=input.Mode is not ("discovery" or "directed"),playable=false,termination,seed=input.Seed,mode=input.Mode,stage=driver?.stage,steps=driver?.step,enqueued=driver?.enqueued??0,resolved=driver?.resolved??0,sba=driver?.sba??0,checkedInvariants=new[]{"unique card instance across zones","card zone agrees with container","chosen actions satisfy engine legality","actual spell lifecycle observed","recorded replay prefix completely consumed"},fullRulesOracle=false,category=FailureCategory(failure),javaSignature=driver?.lastSignature,javaStack=failure?.Data["Forge.JavaStack"] as string,failureCards=driver?.FailureCards(failure)??[],error=failure?.ToString(),traceTail=driver?.tail.ToArray()};
        if(driver!=null)File.WriteAllText(Path.Combine(directory,"method-coverage.json"),JsonSerializer.Serialize(new{methods=driver.g.Rt.ExecutedMethods.Order().ToArray(),bindings=driver.g.Rt.ExecutedBindings.Order().ToArray(),initialCards=driver.initialCards},new JsonSerializerOptions{WriteIndented=true}));
        File.WriteAllText(Path.Combine(directory,"result.json"),JsonSerializer.Serialize(result,new JsonSerializerOptions{WriteIndented=true}));
        if(failure!=null){Console.WriteLine(failure);Console.WriteLine("Failure artifact: "+directory);return 2;}Console.WriteLine((input.Mode=="discovery"?"DISCOVERY COMPLETED (NOT ACCEPTED) ":"HEADLESS PASS ")+input.Seed+" "+termination);return 0;
    }
    private string[] FailureCards(Exception? failure)
    {
        if(failure?.Data["Forge.FailureLocals"] is not JValue[] locals)return [];
        var names=new HashSet<string>(StringComparer.Ordinal);var seen=new HashSet<JObject>();
        void Visit(JObject? obj,int depth)
        {
            if(obj==null||depth>3||!seen.Add(obj))return;
            var fields=g.Rt.InspectFields(obj);
            if(obj.ClassName=="forge/game/card/Card"&&fields.TryGetValue("forge/game/GameEntity.id:I",out var id))
            {
                if(initialCards.TryGetValue(id.Int,out string? name))names.Add(id.Int+":"+name);
                else if(fields.TryGetValue("forge/game/card/Card.currentState:Lforge/game/card/CardState;",out var cardState)&&cardState.Reference!=null&&g.Rt.InspectFields(cardState.Reference).TryGetValue("forge/game/card/CardState.name:Ljava/lang/String;",out var cardName)&&cardName.Reference!=null)names.Add(id.Int+":"+g.Rt.StringValue(cardName));
                else names.Add("card-id:"+id.Int);
            }
            foreach(var field in fields)if(field.Key.Contains("hostCard:")||field.Key.Contains(".card:")||field.Key.Contains(".currentState:"))Visit(field.Value.Reference,depth+1);
        }
        foreach(var local in locals)Visit(local.Reference,0);return names.Order(StringComparer.Ordinal).ToArray();
    }
}

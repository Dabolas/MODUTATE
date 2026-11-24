using System.Text.Json;
using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;

public sealed partial class HeadlessMatch
{
    private void ArrangeOutcomeOpening(string focus)
    {
        if(input.Mode!="directed")throw new InvalidDataException("A fixed opening requires a directed fixture");
        var library=g.Zone(0,"Library");
        var cards=Zone(0,"Library");
        var card=cards.First(c=>g.Rt.StringValue(C(c,"getName","()Ljava/lang/String;"))==focus);
        var opening=cards.Where(c=>c.Reference!=card.Reference&&B(c,"isLand")).Take(3).Prepend(card).ToArray();
        foreach(var c in opening.Reverse()){
            C(library,"remove","(Lforge/game/card/Card;)V",c);
            C(library,"add","(Lforge/game/card/Card;Ljava/lang/Integer;)V",c,g.Rt.BoxInt(0));
        }
        Snapshot("fixed opening before draw: "+focus+" and three lands");
    }
    private void SaveOutcomeEvidence(string directory,string focus)
    {
        var seats=g.Players.Select((p,seat)=>{
            var o=C(p,"getOutcome","()Lforge/game/player/PlayerOutcome;");
            string? Source(string key){
                var value=g.Rt.GetField(o,"forge/game/player/PlayerOutcome",key,"Ljava/lang/String;");
                return value.Reference==null?null:g.Rt.StringValue(value);
            }
            var loss=g.Rt.GetField(o,"forge/game/player/PlayerOutcome","lossState","Lforge/game/player/GameLossReason;");
            return new{seat,winSource=Source("altWinSourceName"),lossSource=Source("loseConditionSpell"),
                lossReason=loss.Reference==null?null:g.Rt.InspectEnumName(loss)};
        }).ToArray();
        bool observed=seats.Any(s=>s.winSource==focus||s.lossSource==focus);
        File.WriteAllText(Path.Combine(directory,"outcome.json"),JsonSerializer.Serialize(new{focus,observed,seats}));
    }
    public static void OutcomeRegression(string root, Action<bool,string> check,long? selectedSeed=null)
    {
        var folder = BatchPaths.Output(root,"release/forge-headless/outcome-boundaries");
        Directory.CreateDirectory(folder);
        var program = ForgeProgram.BuildForDevelopment();
        var db = CardDatabase.Load(Path.Combine(root,"data/forge"));
        var cases = new List<(string card,string branch)> {
            ("Approach of the Second Sun","first"), ("Approach of the Second Sun","second"),
            ("Thassa's Oracle","equal"), ("Thassa's Oracle","below"), ("Thassa's Oracle","angel"),
            ("Phyrexian Unlife","cross-zero"), ("Phyrexian Unlife","ten-poison"), ("Phyrexian Unlife","empty-draw"),
            ("Platinum Angel","protected"), ("Platinum Angel","removed"),
            ("Phage the Untouchable","from-hand"), ("Phage the Untouchable","reanimated"),
            ("Phage the Untouchable","combat"), ("Phage the Untouchable","noncombat"),
            ("Laboratory Maniac","empty-draw"), ("Laboratory Maniac","last-card"),
            ("Herald of Eternal Dawn","protected"), ("Herald of Eternal Dawn","removed")
        };
        foreach(var card in new[]{"Battle of Wits","Felidar Sovereign","Test of Endurance","Near-Death Experience",
            "Triskaidekaphile","Barren Glory","The Cheese Stands Alone","Biovisionary","Epic Struggle",
            "Mortal Combat","Hellkite Tyrant","Knuckles the Echidna","Abyssal Persecutor","Darksteel Angel"}){
            cases.Add((card,"condition-met"));
            cases.Add((card,"condition-missed"));
        }
        var special=new[]{"Celestine Reef","Platinum Angel Avatar","Assassin Token","Amulet of Quoz","Bronze Tablet",
            "Sengir, the Dark Baron","Blood Tyrant","Curse of Vengeance","Miss Highwater","Hot Pursuit","Rampant Frogantua",
            "Share the Spoils","Elbrus, the Binding Blade","Ramses, Assassin Lord"};
        foreach(var card in special){
            cases.Add((card,"special-positive"));
            cases.Add((card,"special-control"));
        }
        // Append controls so every previous seed continues to identify the same fixture.
        cases.Add(("Platinum Angel Avatar","special-without-land"));
        var results = new List<object>();
        var failures = new List<string>();
        for (int i = 0; i < cases.Count; i++)
        {
            var (card,branch) = cases[i];
            long seed = 20261201+i;
            if(selectedSeed.HasValue&&seed!=selectedSeed)continue;
            string dir = Path.Combine(folder,seed+"-"+branch);
            Directory.CreateDirectory(dir);
            string mainCard=card switch{
                "Assassin Token"=>"Vraska the Unseen","Celestine Reef" or "Platinum Angel Avatar"=>"Phyrexian Unlife",_=>card
            };
            string[] deck = Enumerable.Repeat(mainCard,4).Concat(Enumerable.Repeat("Plains",20))
                .Concat(Enumerable.Repeat("Swamp",18)).Concat(Enumerable.Repeat("Island",card=="Battle of Wits"?170:10))
                .Concat(Enumerable.Repeat("Memnite",4)).Concat(Enumerable.Repeat("Zombify",4)).ToArray();
            if(card is "Hellkite Tyrant" or "Knuckles the Echidna" or "Mortal Combat" or "Epic Struggle"){
                string[] creatures=["Memnite","Ornithopter","Phyrexian Walker","Shield Sphere","Iron Myr","Gold Myr","Silver Myr","Copper Myr"];
                deck=Enumerable.Repeat(card,4).Concat(creatures.SelectMany(c=>Enumerable.Repeat(c,4))).Concat(Enumerable.Repeat("Forest",24)).ToArray();
            }
            string[] opponent = Enumerable.Repeat("Platinum Angel",4).Concat(Enumerable.Repeat("Grizzly Bears",4))
                .Concat(Enumerable.Repeat("Forest",52)).ToArray();
            bool multiplayer=Array.IndexOf(special,card)>=5;
            var input = new MatchInput(4,seed,60,multiplayer?[deck,opponent,opponent,opponent]:[deck,opponent],"directed");
            File.WriteAllText(Path.Combine(dir,"input.json"),JsonSerializer.Serialize(input));
            File.WriteAllText(Path.Combine(dir,"fixture.json"),JsonSerializer.Serialize(new{card,branch,seed,sha256=card=="Assassin Token"?db.Tokens.Single(token=>token.TokenId=="b_1_1_assassin_lose_con").Sha256:db.Create(card).Definition.Sha256}));
            using var trace = new TraceJournal(dir);
            using var states = new StreamWriter(Path.Combine(dir,"snapshots.jsonl"));
            using var choices = new StreamWriter(Path.Combine(dir,"decisions.jsonl"));
            var assertions = new List<string>();
            string? error = null;
            try {
                var d = new HeadlessMatch(root,program,db,input,trace,states,new(seed,choices));
                d.g.Initialize(0,seed,input.Decks,fixtureVariant:card=="Platinum Angel Avatar"?"Vanguard":card=="Celestine Reef"?"Planechase":null,ante:card is "Amulet of Quoz" or "Bronze Tablet");
                d.OutcomeBoundary(card,branch,(ok,label)=>{
                    if(!ok)throw new InvalidOperationException(label);
                    assertions.Add(label);
                    check(true,label);
                });
            } catch(Exception ex) {
                error=ex.Message;
                trace.WriteLine(ex.ToString());
                failures.Add(card+" / "+branch+": "+error);
            }
            var receipt=new{card,branch,seed,passed=error==null,error,assertions};
            results.Add(receipt);
            File.WriteAllText(Path.Combine(dir,"result.json"),JsonSerializer.Serialize(receipt));
            var report=Path.Combine(folder,"matrix.json");
            File.WriteAllText(report+".tmp",JsonSerializer.Serialize(results));
            File.Move(report+".tmp",report,true);
        }
        check(results.Count>0,"No matching outcome scenario");
        check(failures.Count==0,string.Join(Environment.NewLine,failures));
    }

    private void OutcomeBoundary(string name,string branch,Action<bool,string> verify)
    {
        JValue FromLibrary(string card,int seat,string zone){
            var c=Zone(seat,"Library").First(x=>g.Rt.StringValue(C(x,"getName","()Ljava/lang/String;"))==card);
            Place(c,seat,zone);
            return c;
        }
        void Place(JValue c,int seat,string zone){
            C(g.Zone(seat,"Library"),"remove","(Lforge/game/card/Card;)V",c);
            C(g.Zone(seat,zone),"add","(Lforge/game/card/Card;)V",c);
        }
        void LibrarySize(int n){
            foreach(var c in Zone(0,"Library").Skip(n))Place(c,0,"Exile");
        }
        bool Over()=>B(g.Game,"isGameOver");
        void Settle(){
            for(int i=0;i<24;i++){
                if(Over())return;
                C(g.Action,"checkStateEffects","(Z)Z",JValue.I(1));
                if(Over())return;
                C(g.Stack,"addAllTriggeredAbilitiesToStack","()Z");
                if(C(g.Stack,"size","()I").Int==0)return;
                C(g.Stack,"resolveStack","()V");
            }
            throw new InvalidOperationException("Trigger stack did not settle");
        }
        void Expect(int winner,string? reason=null){
            Snapshot("after "+branch);
            verify(Over()==(winner>=0),"Game-over status for "+branch);
            if(winner<0){
                verify(g.Players.All(p=>C(p,"getOutcome","()Lforge/game/player/PlayerOutcome;").Reference==null),"Both seats still playing");
                return;
            }
            var loser=g.Players[1-winner];
            verify(B(g.Players[winner],"hasWon")&&B(loser,"hasLost"),"Expected winning and losing seats");
            var outcome=C(loser,"getOutcome","()Lforge/game/player/PlayerOutcome;");
            var why=g.Rt.GetField(outcome,"forge/game/player/PlayerOutcome","lossState","Lforge/game/player/GameLossReason;");
            verify(g.Rt.InspectEnumName(why)==reason,"Expected loss reason "+reason);
        }
        var manaSources=new Dictionary<char,Queue<JValue>>();
        string reserve=name switch{
            "Thassa's Oracle"=>"UU",
            "Approach of the Second Sun"=>branch=="second"?"WCCCCCCWCCCCCC":"WCCCCCC",
            "Phage the Untouchable" when branch=="from-hand"=>"BBBBCCC",
            "Phage the Untouchable" when branch=="reanimated"=>"BCCC",
            _=>""
        };
        foreach(char symbol in reserve){
            string land=symbol switch{'U'=>"Island",'B'=>"Swamp",_=>"Plains"};
            if(!manaSources.TryGetValue(symbol,out var sources))manaSources[symbol]=sources=new();
            sources.Enqueue(FromLibrary(land,0,"Battlefield"));
        }
        void Cast(JValue c,string mana){
            foreach(char symbol in mana){
                var land=manaSources[symbol].Dequeue();
                var ability=Items(C(land,"getManaAbilities","()Lforge/util/collect/FCollectionView;"))[0];
                C(ability,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);
                verify(C(land,"tap","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Z",ability,g.Players[0]).Int!=0,"Tapped original basic land");
                C(C(ability,"getManaPart","()Lforge/game/spellability/AbilityManaPart;"),"produceMana","(Lforge/game/spellability/SpellAbility;)V",ability);
            }
            verify(Play(g.Ability(c,0),0)&&g.In(c,"Stack")&&g.ManaCount(0)==0,"Paid cast from hand reaches stack");
            Settle();
        }
        void Damage(JValue c,int seat,int amount,bool combat){
            var table=g.New("forge/game/card/CardDamageTable","()V");
            C(table,"put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;",c,g.Players[seat],g.Rt.BoxInt(amount));
            C(g.Action,"dealDamage","(ZLforge/game/card/CardDamageTable;Lforge/game/card/CardDamageTable;Lforge/game/GameEntityCounterTable;Lforge/game/spellability/SpellAbility;)V",
                JValue.I(combat?1:0),table,g.New("forge/game/card/CardDamageTable","()V"),g.New("forge/game/GameEntityCounterTable","()V"),default(JValue));
            Settle();
        }
        if(branch.StartsWith("special-")){
            bool hit=branch=="special-positive";
            JValue Map()=>S("forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;");
            void Counters(JValue c,string type,int n){
                var kind=S("forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;",g.S(type));
                C(c,"addCounterInternal","(Lforge/game/card/CounterType;ILforge/game/player/Player;ZLforge/game/GameEntityCounterTable;Ljava/util/Map;)V",
                    kind,JValue.I(n),g.Players[0],JValue.I(0),g.New("forge/game/GameEntityCounterTable","()V"),Map());
            }
            void Zero(int seat){C(g.Players[seat],"setLife","(ILforge/game/spellability/SpellAbility;)Z",JValue.I(0),default(JValue));Settle();}
            void PhaseStart(string phase){
                C(g.Phase,"devModeSet","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;I)V",g.Enum("forge/game/phase/PhaseType",phase),g.Players[0],JValue.I(3));
                C(g.Phase,"onPhaseBegin","()V");Settle();
            }
            if(name is "Celestine Reef" or "Platinum Angel Avatar"){
                var source=g.Card(name,0,"Command");
                if(name=="Platinum Angel Avatar"){
                    FromLibrary("Memnite",0,"Battlefield");
                    if(branch!="special-without-land")FromLibrary("Island",0,"Battlefield");
                    if(hit||branch=="special-without-land")g.Card("Glorious Anthem",0,"Battlefield");
                }
                C(g.Action,"checkStaticAbilities","()V");
                C(C(g.Game,"getTriggerHandler","()Lforge/game/trigger/TriggerHandler;"),"resetActiveTriggers","()V");
                Snapshot("command zone and applicable protection");
                if(hit&&name=="Celestine Reef"){
                    var parameters=S("forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;",g.Players[0]);
                    C(C(g.Game,"getTriggerHandler","()Lforge/game/trigger/TriggerHandler;"),"runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V",g.Enum("forge/game/trigger/TriggerType","ChaosEnsues"),parameters,JValue.I(0));Settle();
                }
                Zero(0);Expect(hit?-1:1,"LifeReachedZero");return;
            }
            if(name=="Assassin Token"){
                var vraska=FromLibrary("Vraska the Unseen",0,"Battlefield");
                Counters(vraska,"LOYALTY",7);
                var ultimate=Items(C(vraska,"getSpellAbilities","()Lforge/util/collect/FCollectionView;")).Single(a=>g.Rt.InspectEnumName(C(a,"getApi","()Lforge/game/ability/ApiType;"))=="Token");
                C(ultimate,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);
                Snapshot("before Vraska ultimate");verify(Play(ultimate,0),"Activate real token-producing ultimate");Settle();
                var tokens=Zone(0,"Battlefield").Where(c=>B(c,"isToken")).ToArray();
                verify(tokens.Length==3,"Ultimate created three Assassins");
                Damage(tokens[0],1,1,hit);Expect(hit?0:-1,"SpellEffect");return;
            }
            var card=FromLibrary(name,0,"Battlefield");
            var bear=FromLibrary("Grizzly Bears",1,"Battlefield");
            if(name is "Bronze Tablet" or "Amulet of Quoz"){
                if(name=="Amulet of Quoz")PhaseStart("UPKEEP");else g.Fund(0,"CCCC");
                var a=Items(C(card,"getSpellAbilities","()Lforge/util/collect/FCollectionView;")).Single(x=>B(x,"isActivatedAbility"));
                C(a,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);
                g.SetDecision("confirmAction",(_,args)=>JHostResult.Complete(JValue.I(hit?0:1)));
                g.SetDecision("chooseSpellAbilitiesForEffect",(_,args)=>{
                    var legal=Items(args[0]);var choice=legal.Single(x=>g.Rt.InspectEnumName(C(x,"getApi","()Lforge/game/ability/ApiType;"))==(hit?"LosesGame":"LoseLife"));
                    return JHostResult.Complete(g.Rt.ListOf([choice]));
                });
                Snapshot("before ante activation");verify(Play(a,0),"Pay activation costs in ante game");Settle();
                if(hit){
                    verify(Over()&&g.Players.Count(p=>B(p,"hasLost"))==1,"Ante refusal branch yields exactly one loser");
                    if(name=="Bronze Tablet")Expect(0,"SpellEffect");
                }else{
                    Expect(-1);verify(name=="Bronze Tablet"?g.Life(1)==10:g.Count(1,"Ante")>0,"Alternative to a terminal outcome occurred");
                }
                return;
            }
            if(name=="Curse of Vengeance"){
                C(card,"attachToEntity","(Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;)V",g.Players[1],default(JValue));
                Counters(card,"SPITE",2);
            }
            if(name=="Elbrus, the Binding Blade"){
                verify(C(card,"setState","(Lforge/card/CardStateName;Z)Z",g.Enum("forge/card/CardStateName","Backside"),JValue.I(1)).Int!=0,"Selected the defined back face");
                verify(g.Rt.StringValue(C(card,"getName","()Ljava/lang/String;"))=="Withengar Unbound"&&C(card,"getNetPower","()I").Int==13,"Withengar starts on its 13/13 face");
            }
            if(name=="Sengir, the Dark Baron")C(g.Players[1],"setLifeStartedThisTurnWith","(I)V",JValue.I(17));
            if(name=="Hot Pursuit")C(bear,"setSuspected","(Z)Z",JValue.I(1));
            if(name=="Ramses, Assassin Lord"&&hit)C(g.Players[0],"addCreaturesAttackedThisTurn","(Lforge/game/card/Card;Lforge/game/GameEntity;)V",card,g.Players[1]);
            C(g.Action,"checkStaticAbilities","()V");
            C(C(g.Game,"getTriggerHandler","()Lforge/game/trigger/TriggerHandler;"),"resetActiveTriggers","()V");
            if(name=="Miss Highwater"){
                FromLibrary("Forest",1,"Hand");
                g.SetDecision("confirmPayment",(ctrl,args)=>{
                    verify(ControllerSeat(ctrl)==1&&g.Rt.IsInstance(args[0].Reference!,"forge/game/cost/CostDiscard"),"Damaged player chooses the printed discard cost");
                    return JHostResult.Complete(JValue.I(hit?1:0));
                });
                Damage(card,1,5,true);
                var contract=S("forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;",g.S("Contract"));
                verify(g.Count(1,"Hand")==(hit?7:1)&&C(g.Players[1],"getCounters","(Lforge/game/card/CounterType;)I",contract).Int==(hit?1:0),"Hand and contract counter reflect the payment decision");
                C(g.Game,"copyLastState","()V");
            }
            int power=C(card,"getNetPower","()I").Int;
            int hand=g.Count(0,"Hand"),exiled=g.Count(0,"Exile");
            Snapshot("before elimination in four-player game");
            if(name=="Hot Pursuit"){Zero(2);if(hit)Zero(3);PhaseStart("COMBAT_BEGIN");}
            else if(hit||name is "Ramses, Assassin Lord" or "Miss Highwater")Zero(1);
            if(name=="Ramses, Assassin Lord"){
                verify(Over()==hit&&(!hit||B(g.Players[0],"hasWon")),"Only eliminating the attacked opponent awards the Assassin player the whole game");
            }else{
                verify(!Over(),"Other seats remain in the game");
                bool matches=name switch{
                    "Sengir, the Dark Baron"=>g.Life(0)==20+(hit?17:0),
                    "Blood Tyrant"=>C(card,"getNetPower","()I").Int==power+(hit?5:0),
                    "Elbrus, the Binding Blade"=>C(card,"getNetPower","()I").Int==power+(hit?13:0),
                    "Rampant Frogantua"=>C(card,"getNetPower","()I").Int==power+(hit?10:0),
                    "Curse of Vengeance"=>g.Life(0)==20+(hit?2:0)&&g.Count(0,"Hand")==hand+(hit?2:0),
                    "Share the Spoils"=>g.Count(0,"Exile")==exiled+(hit?1:0),
                    "Hot Pursuit"=>B(bear,"isTapped")==false&&Seat(C(bear,"getController","()Lforge/game/player/Player;"))==(hit?0:1),
                    "Miss Highwater"=>Zone(0,"Battlefield").Count(c=>B(c,"isToken")&&g.Rt.StringValue(C(c,"getName","()Ljava/lang/String;"))=="Grizzly Bears")==(hit?1:0),
                    _=>throw new ArgumentException(name)
                };
                verify(matches,"Printed elimination effect matches the fixed control");
            }
            Snapshot("after elimination check");return;
        }
        if(branch.StartsWith("condition-")){
            bool hit=branch=="condition-met";
            var permanent=FromLibrary(name,0,"Battlefield");
            if(name is "Abyssal Persecutor" or "Darksteel Angel"){
                int seat=(name=="Darksteel Angel")==hit?0:1;
                C(g.Players[seat],"setLife","(ILforge/game/spellability/SpellAbility;)Z",JValue.I(0),default(JValue));
                Snapshot("zero life with prevention source");
                Settle();Expect(hit?-1:1-seat,"LifeReachedZero");return;
            }
            int threshold=name switch{
                "Battle of Wits"=>200,"Felidar Sovereign"=>40,"Test of Endurance"=>50,
                "Near-Death Experience"=>1,"Triskaidekaphile"=>13,"Biovisionary"=>4,
                "Epic Struggle" or "Mortal Combat" or "Hellkite Tyrant"=>20,"Knuckles the Echidna"=>30,_=>0
            };
            int amount=threshold-(hit?0:1);
            switch(name){
                case "Battle of Wits":LibrarySize(amount);break;
                case "Felidar Sovereign":case "Test of Endurance":case "Near-Death Experience":
                    C(g.Players[0],"setLife","(ILforge/game/spellability/SpellAbility;)Z",JValue.I(name=="Near-Death Experience"&&!hit?2:amount),default(JValue));break;
                case "Triskaidekaphile":
                    foreach(var c in Zone(0,"Library").Take(amount))Place(c,0,"Hand");
                    break;
                case "Biovisionary":
                    for(int i=1;i<amount;i++)FromLibrary(name,0,"Battlefield");
                    break;
                case "Barren Glory":case "The Cheese Stands Alone":
                    if(!hit)FromLibrary("Island",0,"Hand");
                    break;
                default:
                    var creatures=Zone(0,"Library").Where(c=>B(c,"isArtifact")&&B(c,"isCreature")).Take(amount).ToArray();
                    verify(creatures.Length==amount,"Original deck supplies the threshold fixture");
                    foreach(var c in creatures)Place(c,0,name=="Mortal Combat"?"Graveyard":"Battlefield");
                    break;
            }
            C(g.Action,"checkStaticAbilities","()V");
            Snapshot("fixed threshold before phase");
            g.Call(g.Phase,"devModeSet","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;I)V",
                g.Enum("forge/game/phase/PhaseType",name=="Biovisionary"?"END_OF_TURN":"UPKEEP"),g.Players[0],JValue.I(3));
            C(g.Phase,"onPhaseBegin","()V");Settle();Expect(hit?0:-1,"OpponentWon");return;
        }
        if(name=="Approach of the Second Sun"){
            var first=FromLibrary(name,0,"Hand");
            var second=FromLibrary(name,0,"Hand");
            Snapshot("before first cast");
            Cast(first,"WCCCCCC");
            verify(!Over()&&g.Life(0)==27&&g.In(first,"Library")&&C(Zone(0,"Library")[6],"getId","()I").Int==C(first,"getId","()I").Int,"First Approach gains seven and is seventh from the top");
            if(branch=="second")Cast(second,"WCCCCCC");
            Expect(branch=="second"?0:-1,"OpponentWon");
        }else if(name=="Thassa's Oracle"){
            var oracle=FromLibrary(name,0,"Hand");
            LibrarySize(branch=="below"?3:2);
            if(branch=="angel")FromLibrary("Platinum Angel",1,"Battlefield");
            Snapshot("before Oracle");
            Cast(oracle,"UU");
            verify(g.In(oracle,"Battlefield")&&g.Count(0,"Library")== (branch=="below"?3:2),"Oracle enters with devotion two and preserves library size");
            Expect(branch=="equal"?0:-1,"OpponentWon");
        }else if(name=="Phage the Untouchable"){
            bool fromHand=branch=="from-hand"||branch=="reanimated";
            var phage=FromLibrary(name,0,branch=="reanimated"?"Graveyard":fromHand?"Hand":"Battlefield");
            Snapshot("before Phage event");
            if(branch=="from-hand")Cast(phage,"BBBBCCC");
            else if(branch=="reanimated"){
                Cast(FromLibrary("Zombify",0,"Hand"),"BCCC");
            }else{
                C(g.Action,"checkStaticAbilities","()V");
                C(C(g.Game,"getTriggerHandler","()Lforge/game/trigger/TriggerHandler;"),"resetActiveTriggers","()V");
                Damage(phage,1,4,branch=="combat");
                verify(g.Life(1)==16,"Opponent took four damage");
            }
            Expect(branch=="combat"?0:branch=="reanimated"?1:-1,"SpellEffect");
        }else{
            var permanent=FromLibrary(name,0,"Battlefield");
            var bear=FromLibrary("Grizzly Bears",1,"Battlefield");
            C(g.Action,"checkStaticAbilities","()V");
            if(branch=="empty-draw"||branch=="last-card"){
                LibrarySize(branch=="last-card"?1:0);
                Snapshot("before draw");
                C(g.Players[0],"drawCards","(I)Lforge/game/card/CardCollectionView;",JValue.I(1));
                Settle();
                if(branch=="last-card")verify(g.Count(0,"Hand")==1,"Last available card actually drawn");
                Expect(branch=="last-card"?-1:name=="Laboratory Maniac"?0:1,name=="Laboratory Maniac"?"OpponentWon":"Milled");
                return;
            }
            C(g.Players[0],"setLife","(ILforge/game/spellability/SpellAbility;)Z",JValue.I(1),default(JValue));
            Snapshot("before damage at one life");
            Damage(bear,0,2,false);
            verify(!Over()&&g.Life(0)==-1&&C(g.Players[0],"getPoisonCounters","()I").Int==0,"First hit crosses zero without poison or defeat");
            if(branch=="removed"){
                C(g.Action,"moveToGraveyard","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;",permanent,default(JValue));
                Settle();Expect(1,"LifeReachedZero");
            }else if(branch=="ten-poison"){
                Damage(bear,0,9,false);
                verify(!Over()&&g.Life(0)==-1&&C(g.Players[0],"getPoisonCounters","()I").Int==9,"Next nine damage becomes nine poison counters");
                Damage(bear,0,1,false);Expect(1,"Poisoned");
            }else Expect(-1);
        }
    }
}

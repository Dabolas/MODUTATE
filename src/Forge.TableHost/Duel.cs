using Planeswalker.Core;
using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;
using System.Text;
using System.Diagnostics;
using Planeswalker.TableHost;

// The live host shares the legal-action, payment and BOT controller with full-match replays.
// The outer phase/mulligan frame is owned by the player loop and survives UI redraws.
public sealed partial class HeadlessMatch
{
    readonly L3Game g;
    readonly CardDatabase catalogue;
    readonly BotDecisions tape;
    readonly LivePolicy input=new();
    sealed class LivePolicy { public int Version=>4; }
    int priorityDecisions, revision;
    readonly List<string> castingCheckpoints=new();
    bool recordingCast, running, opening=true;
    Action<string>? log;
    void Snapshot(string reason) => log?.Invoke(reason);
    public MatchView View {get;private set;}=new();
    public bool Waiting=>reply!=null;
    public bool Finished=>View.gameOver;
    public bool PromptSnapshotsOnly {get;set;}
    public long Seed {get;}
    Func<string,int[],bool>? reply;
    JValue answer;
    List<JValue> actions=new();
    int[] actionCardIds=Array.Empty<int>();
    int[] preparedActionSourceIds=Array.Empty<int>();
    int landActionCardId=-1;
    int automaticStackPasses;
    IEnumerator<int>? preparing;
    readonly int openingDeckSize;
    readonly string?[] companions;
    readonly string[][] draftCompanionOrder;
    int openingCardsLoaded;
    public Action<int>? OnOpeningProgress {get;set;}
    long lastProjection;
    static readonly string[] zones={"Battlefield","Graveyard","Exile","Command"};
    static readonly string[] humanZones={"Battlefield","Graveyard","Exile","Command","Hand"};
    readonly Dictionary<int,int> projectedStackIds=new();

    public HeadlessMatch(CardDatabase db,byte[] types,byte[] messages,string[] human,string[] bot,long seed,Action<string>? log=null)
        : this(db,types,messages,new DuelDeck(human),new DuelDeck(bot),seed,log){}

    public HeadlessMatch(CardDatabase db,byte[] types,byte[] messages,DuelDeck human,DuelDeck bot,long seed,Action<string>? log=null,
        TableBotStyle botStyle=TableBotStyle.Replay)
    {
        catalogue=db;this.log=log;this.botStyle=botStyle;Seed=seed;tape=new BotDecisions(seed);
        g=new L3Game("",TableProgram.Open(),db,true,null,new ConsoleLocalization(Encoding.UTF8.GetString(messages).Split('\n').Select(s=>s.TrimEnd('\r'))),types,live:true);
        g.Rt.SynchronousInstructionLimit=100000000;
        // Visual presentation owns pacing. The translated delay has no rule-side effect.
        g.Rt.Delay=_=>JHostResult.Complete();
        InstallDecisions();
        InstallPlayer();
        InstallTableChoices();
        InstallBotPolicy();
        companions=new[]{human.Companion,bot.Companion};
        draftCompanionOrder=new[]{
            human.IsDraft?human.Sideboard:Array.Empty<string>(),
            bot.IsDraft?bot.Sideboard:Array.Empty<string>()
        };
        InstallCompanionChoice();
        InstallCasting();
        InstallExileAnnouncement();
        var outside=new[]{human.OutsideCards(),bot.OutsideCards()};
        openingDeckSize=human.Main.Length+bot.Main.Length+outside.Sum(cards=>cards.Length);
        preparing=g.InitializeSteps(0,seed,new[]{human.Main,bot.Main},false,
            sideboards:outside,draft:human.IsDraft||bot.IsDraft).GetEnumerator();
        View.status="starting";
    }
    void StartOpeningHand()
    {
        for(int seat=0;seat<companions.Length;seat++)
            if(companions[seat] is { } companion&&!Zone(seat,"Command").Any(card=>Name(card)==companion))
                throw new ArgumentException((seat==0?"你的":"对手的")+"起始牌组不满足行侣「"+companion+"」的登记条件。");
        var first=g.Players[0];
        C(g.Action,"runPreOpeningHandActions","(Lforge/game/player/Player;)V",first);
        C(g.Game,"setAge","(Lforge/game/GameStage;)V",g.Enum("forge/game/GameStage","Mulligan"));
        foreach(var player in g.Players) C(player,"drawCards","(I)Lforge/game/card/CardCollectionView;",C(player,"getStartingHandSize","()I"));
        var service=g.New("forge/game/mulligan/MulliganService","(Lforge/game/player/Player;)V",first);
        Begin(service,"forge/game/mulligan/MulliganService","perform()V");
        Refresh();
    }
    void InstallCompanionChoice()
    {
        var otherChoices=g.Decision("chooseSingleEntityForEffect")!;
        g.SetDecision("chooseSingleEntityForEffect",(controller,args)=>{
            var ability=args[2];
            if(ability.Reference==null||g.Rt.InspectEnumName(C(ability,"getApi","()Lforge/game/ability/ApiType;"))!="CompanionChoose")
                return otherChoices(controller,args);
            int seat=ControllerSeat(controller);
            if(companions[seat] is { } declared)
                return JHostResult.Complete(Items(args[0]).FirstOrDefault(card=>Name(card)==declared));

            var eligible=Items(args[0]);
            foreach(string candidate in draftCompanionOrder[seat]){
                var chosen=eligible.FirstOrDefault(card=>Name(card)==candidate);
                if(chosen.Reference==null)continue;
                companions[seat]=candidate;
                return JHostResult.Complete(chosen);
            }
            return JHostResult.Complete();
        });
    }
    void Begin(JValue receiver,string owner,string key)
    {
        g.Rt.Start(g.Rt.Program.Classes[owner].Methods[key],receiver);
        running=true;
    }
    public void Tick()
    {
        if(Waiting||Finished)return;
        if(preparing!=null){
            long deadline=Stopwatch.GetTimestamp()+Stopwatch.Frequency/250;
            do{
                if(!preparing.MoveNext()){
                    preparing.Dispose();preparing=null;
                    OnOpeningProgress?.Invoke(97);
                    if(phaseLesson!=null)StartPhaseLesson();
                    else if(savedPractice is { } fixture){
                        savedPractice=null;
                        StartSavedPractice(fixture);
                    }else StartOpeningHand();
                    break;
                }
                if(preparing.Current==1){
                    openingCardsLoaded++;
                    OnOpeningProgress?.Invoke(35+55*openingCardsLoaded/Math.Max(1,openingDeckSize));
                }
            }while(Stopwatch.GetTimestamp()<deadline);
            return;
        }
        if(!running){
            priorityDecisions=0;
            Begin(g.Phase,"forge/game/phase/PhaseHandler","mainLoopStep()V");
        }
        if(g.Rt.RunSlice(75000,4)!=JRunState.Completed){PublishProgressIfDue();return;}
        running=false;
        if(opening){
            opening=false;
            foreach(var p in g.Players) C(p,"runStartGameScripts","()V");
            C(g.Game,"setAge","(Lforge/game/GameStage;)V",g.Enum("forge/game/GameStage","Play"));
            var first=C(g.Action,"runOpeningHandActions","(Lforge/game/player/Player;)Lforge/game/player/Player;",g.Players[0]);
            C(g.Action,"checkStateEffects","(Z)Z",JValue.I(1));
            C(C(g.Game,"getTriggerHandler","()Lforge/game/trigger/TriggerHandler;"),"runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V",g.Enum("forge/game/trigger/TriggerType","NewGame"),S("forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;"),JValue.I(1));
            C(g.Game,"setStartingPlayer","(Lforge/game/player/Player;)V",first);
            C(g.Phase,"setupFirstTurn","(Lforge/game/player/Player;Ljava/lang/Runnable;)V",first,default);
        }
        // Human prompts and terminal results always publish immediately. Avoid
        // walking every visible zone for intermediate BOT steps between paints.
        if(B(g.Game,"isGameOver")||!PromptSnapshotsOnly&&Stopwatch.GetTimestamp()-lastProjection>=Stopwatch.Frequency/8)Refresh();
        FinishAutomaticLessonStep();
        PublishProgressIfDue();
    }
    JHostResult Ask(string descriptor,string prompt,Func<string,int[],bool> handler,bool ok=true,string okLabel="OK",bool cancel=false)
    {
        PublishPrompt(prompt,handler,ok,okLabel,cancel);
        var method=new JMethod(-230,"java/lang/Object","tableInput","()"+descriptor,8,0,1,Array.Empty<JHandler>(),(rt,f)=>
            Waiting?JStep.Yield:descriptor=="V"?JStep.ReturnVoid:JStep.Return(answer));
        return JHostResult.Schedule(new JFrame(method,default,Array.Empty<JValue>()));
    }
    void PublishPrompt(string prompt,Func<string,int[],bool> handler,bool ok=true,string okLabel="OK",bool cancel=false)
    {
        automaticStackPasses=0;
        Refresh();View.prompt=prompt;View.ok=ok;View.okLabel=okLabel;View.cancel=cancel;View.cancelLabel=opening?"Mulligan":"取消";
        pendingProgress=turnChanged=false;
        View.inputReady=true;reply=handler;answer=default;
    }
    public bool Submit(long id,string command,params int[] ids)
    {
        if(reply==null||id!=View.inputId)return false;
        if(command=="concede"){
            C(g.Players[0],"concede","()V");
            C(g.Action,"checkStateEffects","(Z)Z",JValue.I(1));
            reply=null;Refresh();return true;
        }
        if(!reply(command,ids))return false;
        log?.Invoke($"{id} {command} {string.Join(",",ids)}");
        reply=null;View.inputReady=false;View.choice=null;View.prompt="正在结算";View.inputId=++revision;
        return true;
    }
    void InstallPlayer()
    {
        g.SetDecision("mulliganKeepHand",(ctrl,a)=>{
            if(ControllerSeat(ctrl)==0)
                return Ask("Z","查看手牌，决定保留或调度。",(cmd,ids)=>{answer=JValue.I(cmd=="ok"?1:0);return cmd=="ok"||cmd=="cancel";},true,"Keep",true);
            var hand=Zone(1,"Hand");
            bool keep=TacticalBot?!BotShouldMulligan(hand,a[1].Int):hand.Count(c=>B(c,"isLand")) is >=2 and <=5||a[1].Int>=2;
            return JHostResult.Complete(JValue.I(keep?1:0));
        });
        g.SetDecision("tuckCardsViaMulligan",(ctrl,a)=>{
            var hand=Items(a[0]);int n=a[1].Int;
            if(ControllerSeat(ctrl)!=0)return JHostResult.Complete(Cards((TacticalBot?BotKeepOrder(hand).Reverse():hand).Take(n)));
            if(n==0)return JHostResult.Complete(Cards(hand.Take(0)));
            return BottomFromHand(hand,n);
        });
        g.SetDecision("chooseSpellAbilityToPlay",(ctrl,a)=>PreparePriority(ControllerSeat(ctrl)));
        g.SetDecision("declareAttackers",(ctrl,a)=>CombatChoice(ControllerSeat(ctrl),a[1],true));
        g.SetDecision("declareBlockers",(ctrl,a)=>CombatChoice(ControllerSeat(ctrl),a[1],false));
        foreach(bool multi in new[]{false,true}){
            string key=multi?"chooseCardsForZoneChange":"chooseSingleCardForZoneChange";
            g.SetDecision(key,(ctrl,a)=>{
                var legal=Items(a[3]);int min=multi?a[4].Int:(a[6].Int!=0?0:1),max=multi?a[5].Int:1;
                JValue ToAnswer(IEnumerable<JValue> cards)=>multi?g.Rt.ListOf(cards.ToArray()):cards.FirstOrDefault();
                var origins=Items(a[1]);
                bool library=origins.Any(z=>g.Rt.InspectEnumName(z)=="Library");
                if(TacticalBot&&ControllerSeat(ctrl)==1){
                    var destination=g.Rt.InspectEnumName(a[0]);
                    bool giveUpCard=destination is "Graveyard" or "Exile" or "Library"&&origins.Any(z=>g.Rt.InspectEnumName(z)=="Hand");
                    return JHostResult.Complete(ToAnswer(BotChooseZoneCards(legal,min,max,library,giveUpCard,a[2])));
                }
                if(checkingActions||ControllerSeat(ctrl)==1)return JHostResult.Complete(ToAnswer(EffectSelection(key,legal,min,max,false)));
                if(library)return SearchLibrary(a,legal,min,max,multi,ToAnswer);
                if(legal.Length==0)return JHostResult.Complete(ToAnswer(Array.Empty<JValue>()));
                var source=C(a[2],"getHostCard","()Lforge/game/card/Card;");
                bool imprint=C(a[2],"hasParam","(Ljava/lang/String;)Z",g.S("Imprint")).Int!=0;
                return CardSelection(Name(source)+(imprint?" · 从手牌选择要压印的牌":" · 选择要移动的牌"),legal,min,max,ToAnswer,multi?"Ljava/util/List;":"Lforge/game/card/Card;");
            });
        }
    }
    internal Action<L3Game>? FirstMainFixture;
    JHostResult PreparePriority(int seat)
    {
        if(phaseLesson!=null&&!TeachPriority(seat))return JHostResult.Complete();
        Array.Clear(priorityManaSources,0,priorityManaSources.Length);
        priorityHasManaModifiers=null;
        if(seat==0){
            stagedExiles.Clear();
            int turn=C(g.Phase,"getTurn","()I").Int;
            if(skippingTurn==turn){
                string phase=g.Rt.InspectEnumName(C(g.Phase,"getPhase","()Lforge/game/phase/PhaseType;"))??"";
                if(phase!="END_OF_TURN"&&phase!="CLEANUP")return JHostResult.Complete();
            }
            if(automaticStackPasses>0){
                string phase=g.Rt.InspectEnumName(C(g.Phase,"getPhase","()Lforge/game/phase/PhaseType;"))??"";
                if(B(g.Stack,"isEmpty")||phaseStops.Contains(phase)&&lastPriorityWindow!=(turn,phase))automaticStackPasses=0;
                else{
                    automaticStackPasses--;
                    return JHostResult.Complete();
                }
            }
        }
        if(FirstMainFixture!=null&&seat==0&&g.Rt.InspectEnumName(C(g.Phase,"getPhase","()Lforge/game/phase/PhaseType;"))=="MAIN1"){
            var setup=FirstMainFixture;FirstMainFixture=null;setup(g);
        }
        delvePlans.Clear();
        var botWindow=seat==1&&TacticalBot?CurrentBotWindow():null;
        if(botWindow is { StackEmpty:true, MayActOnEmptyStack:false })return JHostResult.Complete();
        if(seat==1 && ++priorityDecisions>256)throw new HostDecisionGap("Priority window exceeds 256 legal decisions without yielding priority");
        var legal=new List<JValue>();
        var mayHaveAlternativeCosts=botWindow==null?null:new Lazy<bool>(HasAlternativeActionCosts);
        var scan=CollectActions(seat,seat==1,legal,botWindow==null?null:ability=>BotConsiderAction(ability,botWindow),
            mayHaveAlternativeCosts==null?null:card=>BotConsiderBattlefieldCard(card,mayHaveAlternativeCosts)).GetEnumerator();
        var method=new JMethod(-231,"java/lang/Object","tablePriority","()Ljava/util/List;",8,0,1,Array.Empty<JHandler>(),(rt,frame)=>{
            if(frame.Pc==1)return Waiting?JStep.Yield:JStep.Return(answer);
            if(!rt.Tick()||rt.SliceExpired)return JStep.Yield;
            checkingActions=true;
            try{if((botWindow==null||legal.Count<20)&&scan.MoveNext())return JStep.Continue;}finally{checkingActions=false;}
            scan.Dispose();
            if(phaseLesson!=null&&LessonSpell is string lessonSpell){
                if(lessonStep==1)RequireLesson(!legal.Any(sa=>B(sa,"isSpell")&&Name(C(sa,"getHostCard","()Lforge/game/card/Card;"))=="Chain Lightning"),
                    "规则引擎不应在对手结束步骤提供法术施放动作");
                bool allowLand=lessonStep is 5 or 7;
                legal.RemoveAll(sa=>!B(sa,"isManaAbility")&&!(allowLand&&B(sa,"isLandAbility"))&&Name(C(sa,"getHostCard","()Lforge/game/card/Card;"))!=lessonSpell);
            }
            if(seat==1)return JStep.Return(botWindow==null?PickPriority(seat,legal):BotPriority(legal,botWindow));
            string phase=g.Rt.InspectEnumName(C(g.Phase,"getPhase","()Lforge/game/phase/PhaseType;"))??"";
            var window=(C(g.Phase,"getTurn","()I").Int,phase);
            bool stop=phaseLesson!=null||phaseStops.Contains(phase)&&lastPriorityWindow!=window;
            if(skippingTurn==window.Item1){
                if(phase!="END_OF_TURN"&&phase!="CLEANUP")return JStep.Return(JValue.R(null));
                stop=true;
            }
            skippingTurn=-1;
            lastPriorityWindow=window;
            if(!stop && legal.Count==0 && B(g.Stack,"isEmpty"))return JStep.Return(JValue.R(null));
            actions=legal;
            PublishPrompt(stop?"已在指定步骤停留，可行动或继续。":"双击亮框卡牌，施放或选择可用异能。",Priority,true,stop?"继续此步骤":"OK");
            View.priorityWindow=true;
            var visible=View.players.SelectMany(p=>p.cards).Select(c=>c.id).ToHashSet();
            // The same legal cast can be selected on the exile object or on its battlefield source.
            var preparedSources=View.players.SelectMany(p=>p.cards).Where(c=>c.preparedSpellId>=0)
                .ToDictionary(c=>c.preparedSpellId,c=>c.id);
            actionCardIds=new int[actions.Count];
            preparedActionSourceIds=new int[actions.Count];
            Array.Fill(preparedActionSourceIds,-1);
            var castablePrepared=new HashSet<int>();
            var castable=new HashSet<int>();
            var landPlays=new HashSet<int>();
            var manaAbilities=new HashSet<int>();
            var otherAbilities=new HashSet<int>();
            var channelAbilities=new HashSet<int>();
            for(int i=0;i<actions.Count;i++){
                int actual=AbilityCardId(actions[i]);
                actionCardIds[i]=actual;
                if(B(actions[i],"isSpell")){
                    castable.Add(actual);
                    if(preparedSources.TryGetValue(actual,out int source)){
                        preparedActionSourceIds[i]=source;
                        castablePrepared.Add(source);
                    }
                }
                else if(B(actions[i],"isLandAbility"))landPlays.Add(actionCardIds[i]);
                else if(B(actions[i],"isManaAbility"))manaAbilities.Add(actionCardIds[i]);
                else{
                    otherAbilities.Add(actionCardIds[i]);
                    if(IsChannelAbility(actions[i]))channelAbilities.Add(actionCardIds[i]);
                }
                if(visible.Contains(actionCardIds[i]))continue;
                var card=C(actions[i],"getHostCard","()Lforge/game/card/Card;");
                if(!B(card,"isFaceDown")&&C(card,"mayPlayerLook","(Lforge/game/player/Player;)Z",g.Players[0]).Int!=0){
                    var row=Card(card,"External");View.players[0].cards=View.players[0].cards.Append(row).ToArray();visible.Add(row.id);
                }
            }
            var actionable=actionCardIds.Concat(castablePrepared).ToHashSet();
            foreach(var row in View.players.SelectMany(p=>p.cards)){
                row.actionable=actionable.Contains(row.id);
                row.canCast=castable.Contains(row.id);
                row.canPlayLand=landPlays.Contains(row.id);
                row.canProduceMana=manaAbilities.Contains(row.id);
                row.canActivateAbility=otherAbilities.Contains(row.id);
                row.canChannel=channelAbilities.Contains(row.id);
                row.canCastPrepared=castablePrepared.Contains(row.id);
            }
            if(phaseLesson!=null)RecordLessonPriorityInput();
            frame.Pc=1;
            return JStep.Yield;
        });
        return JHostResult.Schedule(new JFrame(method,default,Array.Empty<JValue>()));
    }
    bool Priority(string cmd,int[] ids)
    {
        if(cmd=="skipEnd"&&View.choice==null&&View.phase!="END_OF_TURN"&&View.phase!="CLEANUP"){skippingTurn=View.turn;answer=default;return true;}
        if(cmd=="yieldStack"&&View.choice==null&&View.okLabel=="OK"&&phaseLesson==null&&!B(g.Stack,"isEmpty")){
            // Keep automatic waits short so the table can resume responding between batches.
            automaticStackPasses=3;
            answer=default;
            return true;
        }
        if(cmd=="ok"&&View.choice==null){
            if(phaseLesson!=null){
                if(lessonStep!=7)return false;
                lessonSecondMainPassed=true;
            }
            answer=JValue.R(null);return true;
        }
        if(cmd=="choice"&&View.choice!=null){
            if(ids.Length==0){landActionCardId=-1;View.choice=null;View.inputId=++revision;return false;}
            if(ids.Length!=1||!View.choice.options.Any(o=>o.id==ids[0]&&!o.disabled))return false;
            if(View.choice.kind=="land-action"){
                int id=landActionCardId;
                landActionCardId=-1;
                View.choice=null;
                return ChoosePriorityCard(ids[0]==0?"cardMana":"cardAbility",id);
            }
            answer=g.Rt.ListOf(new[]{actions[ids[0]]});return true;
        }
        if(View.choice!=null||ids.Length!=1||cmd is not ("card" or "cardUseLand" or "cardMana" or "cardAbility" or "cardLand" or "cardChannel" or "cardPrepared"))return false;
        return ChoosePriorityCard(cmd,ids[0]);
    }

    bool NonManaAction(JValue ability)=>!B(ability,"isManaAbility")&&!B(ability,"isSpell")&&!B(ability,"isLandAbility");

    bool ChoosePriorityCard(string command,int id)
    {
        var matching=actions.Select((sa,i)=>(sa,i)).Where(v=>actionCardIds[v.i]==id||preparedActionSourceIds[v.i]==id&&id>=0).ToArray();
        if(matching.Length==0)return false;
        if(command=="cardUseLand"){
            var fromLand=matching.Where(v=>actionCardIds[v.i]==id).Select(v=>v.sa).ToArray();
            bool mana=fromLand.Any(sa=>B(sa,"isManaAbility")),utility=fromLand.Any(NonManaAction);
            if(mana||utility){
                var source=C(fromLand[0],"getHostCard","()Lforge/game/card/Card;");
                if(!B(source,"isLand")||!B(source,"isInPlay"))return false;
                const string abilities="()Lforge/util/collect/FCollectionView;";
                bool hasMana=mana||!B(C(source,"getManaAbilities",abilities),"isEmpty");
                bool hasUtility=utility||Items(C(source,"getNonManaAbilities",abilities)).Any(sa=>B(sa,"isActivatedAbility"));
                if(hasMana&&hasUtility){
                    landActionCardId=id;
                    View.choice=new ChoiceView{id=++revision,kind="land-action",title=Name(source),min=1,max=1,optional=true,
                        options=new[]{new OptionView{id=0,label="产费",disabled=!mana},new OptionView{id=1,label="启动异能",disabled=!utility}}};
                    View.inputId=revision;
                    return false;
                }
            }
            command=mana?"cardMana":matching.Any(v=>preparedActionSourceIds[v.i]>=0)?"card":"cardAbility";
        }
        var choices=matching.Where(v=>command switch{
            "cardMana"=>B(v.sa,"isManaAbility"),
            "cardAbility"=>NonManaAction(v.sa),
            "cardLand"=>B(v.sa,"isLandAbility"),
            "cardChannel"=>IsChannelAbility(v.sa),
            "cardPrepared"=>preparedActionSourceIds[v.i]>=0,
            _=>true
        }).ToArray();
        if(choices.Length==0)return false;
        if(choices.Length==1){answer=g.Rt.ListOf(new[]{choices[0].sa});return true;}
        View.choice=new ChoiceView{id=++revision,kind="ability",title=command=="cardMana"?"选择产费异能":
            command=="cardAbility"?"选择要启动的异能":"选择要进行的动作",min=1,max=1,optional=true,
            options=choices.Select(v=>new OptionView{id=v.i,label=(preparedActionSourceIds[v.i]>=0?"施放备法咒语 · ":"")+
                g.Rt.StringValue(C(v.sa,"toString","()Ljava/lang/String;"))}).ToArray()};View.inputId=revision;
        return false;
    }
    bool IsChannelAbility(JValue sa)=>OptionalText(C(sa,"getParam","(Ljava/lang/String;)Ljava/lang/String;",g.S("PrecostDesc")))
        .StartsWith("Channel",StringComparison.Ordinal);
    JHostResult PickCards(string prompt,JValue[] legal,int min,int max,Func<IEnumerable<JValue>,JValue> build,string type)
    {
        var wait=Ask(type,prompt,(cmd,ids)=>{
            if(cmd!="choice"||ids.Length<min||ids.Length>max||ids.Distinct().Count()!=ids.Length||ids.Any(i=>i<0||i>=legal.Length))return false;
            answer=build(ids.Select(i=>legal[i]));return true;
        },false);
        View.choice=new ChoiceView{id=revision,kind="options",title=prompt,min=min,max=max,options=legal.Select((c,i)=>new OptionView{id=i,label=Name(c)}).ToArray()};
        return wait;
    }
    string Name(JValue card)=>g.Rt.StringValue(C(card,"getName","()Ljava/lang/String;"));
    CardView Card(JValue card,string zone){
        bool hidden=B(card,"isFaceDown")&&C(card,"mayPlayerLook","(Lforge/game/player/Player;)Z",g.Players[0]).Int==0;
        bool creature=B(card,"isCreature");
        var row=new CardView{id=C(card,"getId","()I").Int,name=hidden?"面朝下的牌":Name(card),zone=zone,
            text=hidden?"":g.Rt.StringValue(C(card,"getOracleText","()Ljava/lang/String;")),mana=hidden?"":g.Rt.StringValue(C(C(card,"getManaCost","()Lforge/card/mana/ManaCost;"),"toString","()Ljava/lang/String;")),
            type=hidden?"":g.Rt.StringValue(C(C(card,"getType","()Lforge/card/CardTypeView;"),"toString","()Ljava/lang/String;")),creature=creature,land=B(card,"isLand"),tapped=B(card,"isTapped"),token=B(card,"isToken"),
            counters=Counters(card),
            damage=zone=="Battlefield"?C(card,"getDamage","()I").Int:0,summoningSick=zone=="Battlefield"&&creature&&B(card,"isSick"),
            power=creature?C(card,"getNetPower","()I").Int:0,toughness=creature?C(card,"getNetToughness","()I").Int:0};
        row.preparedCopy=!hidden&&row.token&&(zone is "Exile" or "Stack")&&
            g.Rt.InspectEnumName(C(card,"getCurrentStateName","()Lforge/card/CardStateName;"))=="PreparedSpell";
        if(!hidden&&!row.preparedCopy&&(row.token||B(card,"isEmblem")))ProjectTokenArt(card,row);
        if(zone=="Battlefield")ProjectPermanentDetails(card,row,hidden);
        return row;
    }
    void ProjectTokenArt(JValue card,CardView row)
    {
        // Copies can inherit a regular card face. Only a real token image or a
        // matching PaperToken supplies the script ID (many tokens share a name).
        var face=C(card,"getCurrentState","()Lforge/game/card/CardState;");
        var image=OptionalText(C(face,"getImageKey","()Ljava/lang/String;"));
        if(image.StartsWith("t:",StringComparison.Ordinal)){
            var id=image.Substring(2).Split('|')[0];
            row.tokenKey=id.EndsWith("$alt",StringComparison.Ordinal)?id.Substring(0,id.Length-4):id;
            row.artKey="Tokens/"+row.tokenKey+(image.EndsWith("$alt",StringComparison.Ordinal)?"$alt":"");
            return;
        }
        // The face's printed name survives an effect that only changes the
        // permanent's displayed name and identifies the correct transformed face.
        string printed=Name(face);
        if(printed.Length!=0&&printed!=row.name)row.artKey=printed;
        if(image.Length!=0||!g.Rt.InspectFields(card.Reference!).TryGetValue("forge/game/card/Card.paperCard:Lforge/item/IPaperCard;",out var paper)
            ||paper.Reference?.ClassName!="forge/item/PaperToken")return;
        bool back=B(card,"isBackSide");
        if(!back&&Name(paper)!=printed)return;
        row.tokenKey=OptionalText(C(paper,"getImageFilename","(I)Ljava/lang/String;",JValue.I(1)));
        if(row.tokenKey.Length!=0)row.artKey="Tokens/"+row.tokenKey+(back?"$alt":"");
    }
    TargetView? Target(JValue value,IReadOnlyDictionary<int,int>? stackIds=null)
    {
        if(value.Reference==null)return null;
        int seat=Seat(value);
        if(seat>=0)return new TargetView{kind="player",id=seat,name=seat==0?"你":"BOT"};
        if(g.Rt.IsInstance(value.Reference,"forge/game/card/Card"))return new TargetView{kind="card",id=C(value,"getId","()I").Int,name=B(value,"isFaceDown")?"面朝下的牌":Name(value)};
        if(g.Rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility")){
            if(stackIds!=null)
                return stackIds.TryGetValue(C(value,"getId","()I").Int,out int id)
                    ?new TargetView{kind="stack",id=id,name=Describe(value)}:null;
            var stackEntry=C(g.Stack,"getInstanceMatchingSpellAbilityID","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbilityStackInstance;",value);
            if(stackEntry.Reference!=null)
                return new TargetView{kind="stack",id=C(stackEntry,"getId","()I").Int,name=Describe(value)};
        }
        return null;
    }
    void Refresh(){
        View=ProjectTable();
        View.inputId=++revision;
        lastProjection=Stopwatch.GetTimestamp();
    }
    MatchView ProjectTable(){
        var phase=C(g.Phase,"getPhase","()Lforge/game/phase/PhaseType;");
        bool over=B(g.Game,"isGameOver");
        var view=new MatchView{turn=C(g.Phase,"getTurn","()I").Int,phase=opening?"MULLIGAN":g.Rt.InspectEnumName(phase)??"",
            activePlayerId=Seat(C(g.Phase,"getPlayerTurn","()Lforge/game/player/Player;")),
            priorityPlayerId=Seat(C(g.Phase,"getPriorityPlayer","()Lforge/game/player/Player;")),status=over?"finished":"playing",gameOver=over,notice=lastNotice,prompt="正在推进对局"};
        view.players=g.Players.Select((p,seat)=>new PlayerView{id=seat,local=seat==0,name=seat==0?"你":"BOT",lost=B(p,"hasLost"),life=g.Life(seat),
            command=CommandState(p,seat),counters=Counters(p),handCount=g.Count(seat,"Hand"),libraryCount=g.Count(seat,"Library"),cards=(seat==0?humanZones:zones).SelectMany(z=>Zone(seat,z)
                .Where(c=>z!="Command"||B(c,"getRenderForUI")&&(companions[seat]==null||!Name(c).EndsWith(" Companion Effect",StringComparison.Ordinal)))
                .Select(c=>{var row=Card(c,z);row.companion=z=="Command"&&row.name==companions[seat];return row;})).ToArray(),
            manaPool=ManaPoolView(seat)
        }).ToArray();
        foreach(var player in view.players){
            if(opening||player.libraryCount==0)continue;
            var top=C(g.Zone(player.id,"Library"),"get","(I)Lforge/game/card/Card;",JValue.I(0));
            if(C(top,"mayPlayerLook","(Lforge/game/player/Player;)Z",g.Players[0]).Int!=0)
                player.cards=player.cards.Append(Card(top,"LibraryTop")).ToArray();
        }
        var combat=C(g.Game,"getCombat","()Lforge/game/combat/Combat;");
        if(combat.Reference!=null)ProjectCombat(view,combat);
        var spells=Items(g.Stack).Select(entry=>(Id:C(entry,"getId","()I").Int,
            Ability:C(entry,"getSpellAbility","()Lforge/game/spellability/SpellAbility;"))).ToArray();
        projectedStackIds.Clear();
        foreach(var spell in spells)projectedStackIds.TryAdd(C(spell.Ability,"getId","()I").Int,spell.Id);
        var stackFaces=new Dictionary<JObject,CardView>();
        view.stackItems=spells.Select(spell=>{
            var sa=spell.Ability;
            var source=C(sa,"getHostCard","()Lforge/game/card/Card;");
            if(!stackFaces.TryGetValue(source.Reference!,out var face)){
                face=Card(source,"Stack");
                stackFaces.Add(source.Reference!,face);
            }
            return new StackView{id=spell.Id,source=face,
                targets=Items(C(sa,"getTargets","()Lforge/game/spellability/TargetChoices;"))
                    .Select(t=>Target(t,projectedStackIds)).Where(t=>t!=null).Cast<TargetView>().ToArray(),
                ability=!B(sa,"isSpell"),playerId=Seat(C(sa,"getActivatingPlayer","()Lforge/game/player/Player;")),text=g.Rt.StringValue(C(sa,"toString","()Ljava/lang/String;"))};
        }).ToArray();
        view.stack=view.stackItems.Select(s=>s.text).ToArray();
        projectedTableSize=view.players.Sum(player=>player.cards.Length)+view.stackItems.Length;
        if(phaseLesson!=null)ProjectPhaseLesson(view);
        return view;
    }
}

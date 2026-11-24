using Planeswalker.ForgeAot;
using Planeswalker.ForgeConsole;

// Controlled console host: only host decisions and initial fixtures are supplied here.
// All cost, zone, stack, trigger, damage and SBA methods are the original Forge bodies.
public sealed partial class L3Game
{
    public readonly JRuntime Rt;
    public readonly List<string> Trace=[];
    public readonly List<string> Assertions=[];
    public readonly List<JValue> Players=[];
    private readonly CardDatabase database;
    private readonly AotCardReader reader;
    private readonly Dictionary<string,JValue> papers=[];
    private readonly Dictionary<string,JValue> paperTokens=[];
    private readonly Dictionary<string,JValue> tokenRules=[];
    private readonly Dictionary<string,Func<JValue,JValue[],JHostResult>> decisions=[];
    private readonly HashSet<string> boundDecisions=[];
    public void SetDecision(string name,Func<JValue,JValue[],JHostResult> handler)
    {
        decisions[name]=handler;
        foreach(var method in Rt.Program.Classes["forge/game/player/PlayerController"].Methods.Values.Where(m=>m.Name==name&&(m.Access&0x400)!=0))
            if(boundDecisions.Add(method.Key))Rt.Bind("l3/ConsoleController",method.Name,method.Descriptor,(r,s,a)=>decisions[name](s,a));
    }
    internal Func<JValue,JValue[],JHostResult>? Decision(string name)=>decisions.TryGetValue(name,out var previous)?previous:null;
    public JValue Game,Stack,Action,Phase;
    public int Enqueued,Resolved,SbaChecks,SbaChanges;
    public string Stage="initialization";
    public L3Game(string root,JProgram program,CardDatabase db,bool strictHost=false,Action<string>? traceSink=null,ConsoleLocalization? localization=null,byte[]? typeList=null,bool live=false)
    {
        database=db;Rt=new(program){CacheLinkedMembers=live,CollectCoverage=!live};Rt.Trace=live?traceSink:traceSink??Trace.Add;this.strictHost=strictHost;
#if NETSTANDARD2_1
        ConsoleLocalization.Install(Rt,localization??throw new ArgumentNullException(nameof(localization)));
#else
        Rt.Delay=ConsoleEnvironment.Wait;
        ConsoleLocalization.Install(Rt,localization??new ConsoleLocalization(Path.Combine(root,"data/runtime/en-US.properties")));
#endif
        Rt.InstallEventBus(new Dictionary<string,(string,string)>{["forge/game/GameLogFormatter"]=("recieve","forge/game/event/GameEvent")});
        Rt.InstallDiagnosticLog(line=>Trace.Add("diagnostic "+line));Rt.InstallBreadcrumbSink((message,data)=>Trace.Add("breadcrumb "+message));
        var environment=new ConsoleEnvironment(line=>Trace.Add("output "+line));Rt.InstallEnvironment(environment);Rt.InstallPlatformHost(environment);
#if NETSTANDARD2_1
        reader=new(program,typeList??throw new ArgumentNullException(nameof(typeList)),db);
#else
        reader=typeList!=null?new(program,typeList,db):new(program,Path.Combine(root,"src/Forge.ConsoleHost/Data/TypeLists.txt"),db);
#endif
        reader.Attach(Rt);
        InstallHost();
    }
    public JValue S(string text)=>JValue.R(Rt.String(text));
    private readonly bool strictHost;
    public JValue Call(JValue receiver,string name,string descriptor,params JValue[] args)=>Rt.InvokeSynchronous(receiver.Reference!.ClassName,name,descriptor,receiver,args);
    public JValue Static(string type,string name,string descriptor,params JValue[] args)=>Rt.InvokeSynchronous(type,name,descriptor,default,args,"invokestatic");
    public JValue New(string type,string descriptor,params JValue[] args){var value=JValue.R(Rt.Allocate(type));Rt.InvokeSynchronous(type,"<init>",descriptor,value,args,"invokespecial");return value;}
    public JValue Enum(string type,string name){Static(type,"values","()[L"+type+";");return Rt.GetStatic(type,name,"L"+type+";");}
    public void Check(bool condition,string label){if(!condition)throw new InvalidOperationException("ASSERT: "+label);Assertions.Add(label);Trace.Add("ASSERT PASS "+label);}
    private void InstallHost()
    {
        Rt.InstallExtendedTraitRequirements();
        var data=JValue.R(Rt.Allocate("forge/StaticData"));
        var catalogue=JValue.R(Rt.Allocate("forge/card/CardDb"));
        var variantCatalogue=JValue.R(Rt.Allocate("forge/card/CardDb"));
        InstallFaceStream(data,catalogue,variantCatalogue);
        // The logical catalogue supplies faces; keep the original rules-name
        // classification and its cache in generated CardDb code.
        Rt.PutField(catalogue,"forge/card/CardDb","nonLegendaryCreatureNames","Ljava/util/Map;",Rt.MapOf([]));
        Rt.PutField(variantCatalogue,"forge/card/CardDb","nonLegendaryCreatureNames","Ljava/util/Map;",Rt.MapOf([]));
        Rt.Bind("forge/StaticData","instance","()Lforge/StaticData;",(r,s,a)=>JHostResult.Complete(data));
        // Console cards use a logical, printing-free catalogue. CardView still
        // requests facedown artwork keys; mirror StaticData's documented final
        // fallback via the original ImageKeys method, without loading an image.
        Rt.Bind("forge/StaticData","getOtherImageKey","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",(r,s,a)=>{
            string? edition=a[1].Reference==null?null:r.StringValue(a[1]);
            if(edition is not (null or "" or "CONSOLE" or "???" or "TEST"))throw new HostDecisionGap("Printing-specific facedown artwork query: "+edition);
            return JHostResult.Complete(Static("forge/ImageKeys","getTokenKey","(Ljava/lang/String;)Ljava/lang/String;",a[0]));});
        Rt.Bind("forge/StaticData","getCardArtPreference","()Lforge/card/CardDb$CardArtPreference;",(r,s,a)=>JHostResult.Complete(Enum("forge/card/CardDb$CardArtPreference","LATEST_ART_ALL_EDITIONS")));
        Rt.Bind("forge/StaticData","getCommonCards","()Lforge/card/CardDb;",(r,s,a)=>JHostResult.Complete(catalogue));
        Rt.Bind("forge/StaticData","getVariantCards","()Lforge/card/CardDb;",(r,s,a)=>JHostResult.Complete(variantCatalogue));
        Rt.Bind("forge/card/CardDb","getFaceByName","(Ljava/lang/String;)Lforge/card/ICardFace;",(r,s,a)=>{
            string name=r.StringValue(a[0]);var owner=database.FindFaceNames(name).FirstOrDefault();
            if(owner==null)return JHostResult.Complete(JValue.R(null));
            var rules=Call(Paper(owner),"getRules","()Lforge/card/CardRules;");
            return JHostResult.Complete(r.ListItems(Call(rules,"getAllFaces","()Ljava/util/List;")).FirstOrDefault(face=>string.Equals(r.StringValue(Call(face,"getName","()Ljava/lang/String;")),name,StringComparison.OrdinalIgnoreCase)));});
        var tokenCatalogue=JValue.R(Rt.HostObject("forge/token/TokenDb",database));
        JValue allTokenRules=default;
        Rt.Bind("forge/token/TokenDb","getRules","()Ljava/util/Map;",(r,s,a)=>{
            if(allTokenRules.Reference==null)
                allTokenRules=r.MapOf(database.Tokens.Select(definition=>
                    new KeyValuePair<JValue,JValue>(S(definition.TokenId),TokenRules(definition))));
            return JHostResult.Complete(allTokenRules);
        });
        Rt.Bind("forge/StaticData","getAllTokens","()Lforge/token/TokenDb;",(r,s,a)=>JHostResult.Complete(tokenCatalogue));
        Rt.Bind("forge/StaticData","getCardEdition","(Ljava/lang/String;)Lforge/card/CardEdition;",(r,s,a)=>{string code=r.StringValue(a[0]);if(code is "CONSOLE" or "???" or "")return JHostResult.Complete(JValue.R(null));throw new HostDecisionGap("Edition-specific query is not in the logical console catalogue: "+code);});
        foreach(string descriptor in new[]{"(Ljava/lang/String;)Lforge/item/PaperToken;","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperToken;","(Ljava/lang/String;Ljava/lang/String;I)Lforge/item/PaperToken;"})
            Rt.Bind("forge/token/TokenDb","getToken",descriptor,(r,s,a)=>JHostResult.Complete(PaperToken(r.StringValue(a[0]))));
        // This rules catalogue contains one logical PaperCard per definition, not a
        // print/edition catalogue. Include alternate faces for rules-name queries.
        Rt.Bind("forge/card/CardDb","getAllCards","(Ljava/lang/String;)Ljava/util/List;",(r,s,a)=>{string name=r.StringValue(a[0]);var matches=database.FindCardNames(name).Select(Paper).ToArray();return JHostResult.Complete(r.ListOf(matches));});
        foreach(var method in Rt.Program.Classes["forge/card/CardDb"].Methods.Values.Where(m=>m.ReturnType=="Lforge/item/PaperCard;"&&m.Parameters.FirstOrDefault()=="Ljava/lang/String;"&&(m.Name=="getCard"||m.Name=="getCardFromEditions"||m.Name=="getUniqueByName")))
            Rt.Bind(method.Owner,method.Name,method.Descriptor,(r,s,a)=>{string name=r.StringValue(a[0]);if(papers.TryGetValue(name,out var known))return JHostResult.Complete(known);
                string? owner=database.ContainsCard(name)?name:database.FindFaceNames(name,true).FirstOrDefault();
                return JHostResult.Complete(owner==null?default:Paper(owner));});
        const string lobby="l3/ConsoleLobby",controller="l3/ConsoleController";
        if(!Rt.Program.Classes.ContainsKey(lobby))Rt.Program.Add(new(lobby,"forge/LobbyPlayer",["forge/game/player/IGameEntitiesFactory"],1));
        if(!Rt.Program.Classes.ContainsKey(controller))Rt.Program.Add(new(controller,"forge/game/player/PlayerController",[],1));
        Rt.Bind(lobby,"createIngamePlayer","(Lforge/game/Game;I)Lforge/game/player/Player;",(r,s,a)=>
        {
            var player=New("forge/game/player/Player","(Ljava/lang/String;Lforge/game/Game;I)V",Call(s,"getName","()Ljava/lang/String;"),a[0],a[1]);
            var ctrl=JValue.R(r.Allocate(controller));r.InvokeSynchronous("forge/game/player/PlayerController","<init>","(Lforge/game/Game;Lforge/game/player/Player;Lforge/LobbyPlayer;)V",ctrl,[a[0],player,s],"invokespecial");
            Call(player,"setFirstController","(Lforge/game/player/PlayerController;)V",ctrl);Players.Add(player);return JHostResult.Complete(player);
        });
        void Bind(string name,Func<JRuntime,JValue,JValue[],JHostResult> handler)
        {foreach(var method in Rt.Program.Classes["forge/game/player/PlayerController"].Methods.Values.Where(m=>m.Name==name&&(m.Access&0x400)!=0)){boundDecisions.Add(method.Key);Rt.Bind(controller,name,method.Descriptor,(r,s,a)=>decisions.TryGetValue(name,out var chosen)?chosen(s,a):strictHost?throw new HostDecisionGap(method.Key):handler(r,s,a));}}
        Bind("orderMoveToZoneList",(r,s,a)=>{Trace.Add("HOST preserve zone ordering");return JHostResult.Complete(a[0]);});
        Bind("orderSimultaneousSa",(r,s,a)=>JHostResult.Complete(a[0]));
        Bind("orderAndPlaySimultaneousSa",(r,s,a)=>{foreach(var ability in r.ListItems(a[0]))Enqueue(ability,"trigger");return JHostResult.Complete();});
        Bind("confirmTrigger",(r,s,a)=>{Trace.Add("HOST accept trigger");return JHostResult.Complete(JValue.I(1));});
        Bind("confirmReplacementEffect",(r,s,a)=>{Trace.Add("HOST accept replacement");return JHostResult.Complete(JValue.I(1));});
        Bind("playTrigger",(r,s,a)=>{Trace.Add("HOST resolve static trigger without stack");Call(a[1],"resolve","()V");return JHostResult.Complete(JValue.I(1));});
        Bind("playSpellAbilityNoStack",(r,s,a)=>{Check(Call(Stack,"hasLegalTargeting","(Lforge/game/spellability/SpellAbility;)Z",a[0]).Int!=0,"inner trigger targets legal before resolution");Trace.Add("HOST resolve chosen trigger through AbilityUtils.resolve");Static("forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V",a[0]);return JHostResult.Complete();});
        Bind("reveal",(r,s,a)=>{Trace.Add("HOST reveal recorded");return JHostResult.Complete();});
        Bind("notifyOfValue",(r,s,a)=>{Trace.Add("HOST value notification recorded");return JHostResult.Complete();});
        Bind("chooseManaFromPool",(r,s,a)=>{var choices=r.ListItems(a[0]);if(choices.Length==0)throw new InvalidOperationException("No offered mana");return JHostResult.Complete(choices[0]);});
        Bind("getAbilityToPlay",(r,s,a)=>{var offered=r.ListItems(a[1]);Check(offered.Length>0,"play effect offered abilities");return JHostResult.Complete(offered[0]);});
        foreach(string choice in new[]{"chooseSingleReplacementEffect","chooseSingleSpellForEffect"})Bind(choice,(r,s,a)=>{var offered=r.ListItems(a[0]);Check(offered.Length>0,"nonempty offered choices for "+choice);Trace.Add("HOST choose first offered: "+choice);return JHostResult.Complete(offered[0]);});
        Bind("chooseSingleEntityForEffect",(r,s,a)=>{
            var offered=r.ListItems(a[0]);
            Trace.Add(offered.Length==0?"HOST no eligible entity for effect":"HOST choose first offered: chooseSingleEntityForEffect");
            return JHostResult.Complete(offered.FirstOrDefault());
        });
        Bind("confirmAction",(r,s,a)=>{Trace.Add("HOST confirm offered action");return JHostResult.Complete(JValue.I(1));});
        Bind("playSaFromPlayEffect",(r,s,a)=>{var card=Call(a[0],"getHostCard","()Lforge/game/card/Card;");int seat=Players.FindIndex(p=>ReferenceEquals(p.Reference,Call(a[0],"getActivatingPlayer","()Lforge/game/player/Player;").Reference));Check(seat>=0,"effect caster belongs to match");return JHostResult.Complete(JValue.I(Cast(card,a[0],seat)?1:0));});
    }
    public void Initialize(int library=8,long seed=42,string[][]? decks=null,bool setupTurn=true,bool twoHeadedGiant=false,string? fixtureVariant=null,bool ante=false)
    {
        foreach(var _ in InitializeSteps(library,seed,decks,setupTurn,twoHeadedGiant,fixtureVariant,ante,false)){}
    }
    public IEnumerable<int> InitializeSteps(int library,long seed,string[][]? decks,bool setupTurn,bool twoHeadedGiant=false,string? fixtureVariant=null,bool ante=false,bool cooperative=true,string[][]? sideboards=null,bool draft=false)
    {
        Rt.SetDeterministicAmbientSeed(seed);
        Stage="registered match initialization";
        var random=New("java/util/Random","(J)V",JValue.L(seed));Static("forge/util/MyRandom","setRandom","(Ljava/util/Random;)V",random);
        var rules=New("forge/game/GameRules","(Lforge/game/GameType;)V",Enum("forge/game/GameType",draft?"Draft":"Constructed"));
        int seats=twoHeadedGiant?4:decks?.Length??2;
        if(fixtureVariant!=null){
            var variants=Static("java/util/Collections","singleton","(Ljava/lang/Object;)Ljava/util/Set;",Enum("forge/game/GameType",fixtureVariant));
            Call(rules,"setAppliedVariants","(Ljava/util/Set;)V",variants);
        }
        if(ante)Call(rules,"setPlayForAnte","(Z)V",JValue.I(1));
        if(twoHeadedGiant){
            var variants=Static("java/util/Collections","singleton","(Ljava/lang/Object;)Ljava/util/Set;",Enum("forge/game/GameType","TwoHeadedGiant"));
            Call(rules,"setAppliedVariants","(Ljava/util/Set;)V",variants);
        }
        var roster=Rt.ListOf([]);
        for(int seat=0;seat<seats;seat++)
        {
            var lobby=JValue.R(Rt.Allocate("l3/ConsoleLobby"));Rt.InvokeSynchronous("forge/LobbyPlayer","<init>","(Ljava/lang/String;)V",lobby,[S("Console "+seat)],"invokespecial");
            var deck=New("forge/deck/Deck","(Ljava/lang/String;)V",S("Fixture "+seat));
            if(decks!=null){
                var main=Call(deck,"getMain","()Lforge/deck/CardPool;");
                foreach(string name in decks[seat]){
                    Call(main,"add","(Lforge/item/InventoryItem;I)V",Paper(name),JValue.I(1));
                    if(cooperative)yield return 1;
                }
            }
            if(sideboards?[seat] is {Length:>0} sideboard){
                var section=Enum("forge/deck/DeckSection","Sideboard");
                var pool=Call(deck,"getOrCreate","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;",section);
                foreach(string name in sideboard){
                    Call(pool,"add","(Lforge/item/InventoryItem;I)V",Paper(name),JValue.I(1));
                    if(cooperative)yield return 1;
                }
            }
            var registered=New("forge/game/player/RegisteredPlayer","(Lforge/deck/Deck;)V",deck);Call(registered,"setPlayer","(Lforge/LobbyPlayer;)Lforge/game/player/RegisteredPlayer;",lobby);
            if(twoHeadedGiant){
                Call(registered,"setTeamNumber","(I)V",JValue.I(seat/2));
                Call(registered,"setStartingLife","(I)V",JValue.I(30));
            }
            Call(roster,"add","(Ljava/lang/Object;)Z",registered);
        }
        var match=New("forge/game/Match","(Lforge/game/GameRules;Ljava/util/List;Ljava/lang/String;)V",rules,roster,S("L3 controlled matrix"));
        Game=New("forge/game/Game","(Ljava/lang/Iterable;Lforge/game/GameRules;Lforge/game/Match;)V",roster,rules,match);
        Stack=Call(Game,"getStack","()Lforge/game/zone/MagicStack;");Action=Call(Game,"getAction","()Lforge/game/GameAction;");Phase=Call(Game,"getPhaseHandler","()Lforge/game/phase/PhaseHandler;");
        if(setupTurn){Call(Game,"setAge","(Lforge/game/GameStage;)V",Enum("forge/game/GameStage","Play"));SetMain(0);}
        Check(Players.Count==seats&&Enumerable.Range(0,seats).All(s=>Life(s)==(twoHeadedGiant?30:20)),"Registered players and starting life");
        if(decks!=null&&cooperative){
            Rt.Start(Rt.Program.Classes["forge/game/Match"].Methods["prepareAllZones(Lforge/game/Game;)V"],match,Game);
            while(Rt.RunSlice(75000,4)!=JRunState.Completed)yield return 0;
        }
        else if(decks!=null)Call(match,"prepareAllZones","(Lforge/game/Game;)V",Game);
        else for(int seat=0;seat<seats;seat++)for(int i=0;i<library;i++)Card(i%2==0?"Plains":"Island",seat,"Library");
        Trace.Add("FIXTURE READY");
    }
    public void SetMain(int seat)=>Call(Phase,"devModeSet","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;)V",Enum("forge/game/phase/PhaseType","MAIN1"),Players[seat]);
    public JValue Paper(string name)
    {
        if(papers.TryGetValue(name,out var paper))return paper;
        var attempt=reader.Attempt(database.GetCard(name),false);if(!attempt.Passed)throw new PortGap(attempt.Error);
        paper=New("forge/item/PaperCard","(Lforge/card/CardRules;Ljava/lang/String;Lforge/card/CardRarity;)V",reader.LastRules,S("CONSOLE"),Enum("forge/card/CardRarity","Common"));papers[name]=paper;return paper;
    }
    public JValue PaperToken(string script)
    {
        if(paperTokens.TryGetValue(script,out var token))return token;
        var definition=database.GetToken(script)??throw new HostDecisionGap("Unknown token script: "+script);
        // Art/printing selection is absent in this console catalogue. The original
        // PaperToken constructor receives actual token rules and an unknown edition.
        token=New("forge/item/PaperToken","(Lforge/card/CardRules;Lforge/card/CardEdition;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V",TokenRules(definition),JValue.R(null),S(script),S(""),S(""));paperTokens.Add(script,token);return token;
    }
    private JValue TokenRules(CardDefinition definition)
    {
        if(tokenRules.TryGetValue(definition.TokenId,out var rules))return rules;
        var attempt=reader.Attempt(definition,false);
        if(!attempt.Passed)throw new PortGap(definition.TokenId+": "+attempt.Error);
        return tokenRules[definition.TokenId]=reader.LastRules;
    }
    public JValue Card(string name,int seat,string? zone=null)
    {
        var card=Static("forge/game/card/CardFactory","getCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;Lforge/game/Game;)Lforge/game/card/Card;",Paper(name),Players[seat],Game);
        if(zone!=null)Call(Zone(seat,zone),"add","(Lforge/game/card/Card;)V",card);return card;
    }
    public JValue Fixture(string name,string types,string rules,int seat=0,string zone="Hand",string extra="")
    {
        string script=$"Name:{name}\nManaCost:0\nTypes:{types}\n"+(types.Contains("Creature")?"PT:2/3\n":"")+rules+"\n"+extra+"\nOracle:Controlled mechanism fixture.\n";
        var fields=script.Split('\n').Where(l=>l.Contains(':')).Select(l=>new CardField(l[..l.IndexOf(':')],l[(l.IndexOf(':')+1)..])).ToArray();
        var definition=new CardDefinition(name,name,"cardsfolder","",script,"",fields);var attempt=reader.Attempt(definition,false);Check(attempt.Passed,"synthetic mechanism definition read: "+name+" "+attempt.Error);
        var paper=New("forge/item/PaperCard","(Lforge/card/CardRules;Ljava/lang/String;Lforge/card/CardRarity;)V",reader.LastRules,S("TEST"),Enum("forge/card/CardRarity","Common"));
        papers[name]=paper;var card=Static("forge/game/card/CardFactory","getCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;Lforge/game/Game;)Lforge/game/card/Card;",paper,Players[seat],Game);Call(Zone(seat,zone),"add","(Lforge/game/card/Card;)V",card);return card;
    }
    public JValue Zone(int seat,string name)=>Call(Players[seat],"getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;",Enum("forge/game/zone/ZoneType",name));
    public int Count(int seat,string zone)=>Call(Zone(seat,zone),"size","()I").Int;
    public int Life(int seat)=>Call(Players[seat],"getLife","()I").Int;
    public JValue Current(JValue card)=>Call(Game,"getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;",card);
    public bool In(JValue card,string zone)=>Call(Current(card),"isInZone","(Lforge/game/zone/ZoneType;)Z",Enum("forge/game/zone/ZoneType",zone)).Int!=0;
    public JValue Ability(JValue card,int seat){var sa=Call(card,"getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;");Call(sa,"setActivatingPlayer","(Lforge/game/player/Player;)V",Players[seat]);return sa;}
    public void Target(JValue sa,params JValue[] targets)
    {
        var choices=Call(sa,"getTargets","()Lforge/game/spellability/TargetChoices;");
        foreach(var target in targets){Check(Call(sa,"canTarget","(Lforge/game/GameObject;)Z",target).Int!=0,"engine accepts selected target");Check(Call(choices,"add","(Lforge/game/GameObject;)Z",target).Int!=0,"selected target stored");}
        Check(Call(Stack,"hasLegalTargeting","(Lforge/game/spellability/SpellAbility;)Z",sa).Int!=0,"target cardinality is legal");
    }
    public JValue ManaPool(int seat)=>Call(Players[seat],"getManaPool","()Lforge/game/mana/ManaPool;");
    public int ManaCount(int seat)=>Call(ManaPool(seat),"totalMana","()I").Int;
    public void Fund(int seat,string colors)
    {
        // Initial mana fixture uses the original mana-production implementation.
        foreach(char color in colors.Where(c=>!char.IsWhiteSpace(c)))
        {
            string name=color switch{'W'=>"Plains",'U'=>"Island",'B'=>"Swamp",'R'=>"Mountain",'G'=>"Forest",'C'=>"Wastes",_=>throw new ArgumentException("Unknown fixture color")};
            var land=Card(name,seat,"Battlefield");var abilities=Rt.ListItems(Call(land,"getManaAbilities","()Lforge/util/collect/FCollectionView;"));
            Check(abilities.Length>0,"basic land has mana ability");var manaSa=abilities[0];Call(manaSa,"setActivatingPlayer","(Lforge/game/player/Player;)V",Players[seat]);
            Check(Call(land,"tap","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Z",manaSa,Players[seat]).Int!=0,"mana source taps");
            var part=Call(manaSa,"getManaPart","()Lforge/game/spellability/AbilityManaPart;");Call(part,"produceMana","(Lforge/game/spellability/SpellAbility;)V",manaSa);
        }
    }
    public bool Pay(JValue sa,int seat)
    {
        var cost=Call(sa,"getPayCosts","()Lforge/game/cost/Cost;");var mana=Call(cost,"getCostMana","()Lforge/game/cost/CostPartMana;");
        var manaCost=Call(mana,"getManaCostFor","(Lforge/game/spellability/SpellAbility;)Lforge/card/mana/ManaCost;",sa);
        JValue Due()=>New("forge/game/mana/ManaCostBeingPaid","(Lforge/card/mana/ManaCost;)V",manaCost);
        var spent=Rt.ListOf([]);var pool=ManaPool(seat);
        bool can=Call(pool,"payManaCostFromPool","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;ZLjava/util/List;)Z",Due(),sa,JValue.I(1),spent).Int!=0;
        if(!can){Call(pool,"refundMana","(Ljava/util/List;)V",spent);Trace.Add("COST REJECTED");return false;}
        spent=Rt.ListOf([]);Check(Call(pool,"payManaCostFromPool","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;ZLjava/util/List;)Z",Due(),sa,JValue.I(0),spent).Int!=0,"engine consumed full mana cost");
        Call(Call(sa,"getPayingMana","()Ljava/util/List;"),"addAll","(Ljava/util/Collection;)Z",spent);return true;
    }
    public bool Cast(JValue card,JValue sa,int seat,bool pay=true)
    {
        Stage="cast legality and payment";
        if(Call(sa,"canPlay","()Z").Int==0){Trace.Add("CAST RESTRICTIONS REJECTED");return false;}
        if(Call(Stack,"hasLegalTargeting","(Lforge/game/spellability/SpellAbility;)Z",sa).Int==0){Trace.Add("TARGET REJECTED");return false;}
        if(pay&&!Pay(sa,seat))return false;
        Call(card,"setCastSA","(Lforge/game/spellability/SpellAbility;)V",sa);
        Stage="move spell to stack zone";var moved=Call(Action,"moveToStack","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;",card,sa);
        Check(moved.Reference!=null,"original moveToStack returned a card");
        Call(sa,"setHostCard","(Lforge/game/card/Card;)V",moved);
        Enqueue(sa,"spell");return true;
    }
    private void Enqueue(JValue sa,string kind){int before=Call(Stack,"size","()I").Int;Stage="MagicStack.add";Call(Stack,"add","(Lforge/game/spellability/SpellAbility;)V",sa);Check(Call(Stack,"size","()I").Int==before+1,"stack increased by one");Enqueued++;Trace.Add("入栈成功 / STACK ENQUEUED: "+kind);}
    public void ResolveOne()
    {
        Stage="MagicStack.resolveStack";int before=Call(Stack,"size","()I").Int;Check(before>0,"nonempty stack before resolution");
        var instance=Call(Stack,"peek","()Lforge/game/spellability/SpellAbilityStackInstance;");Call(Stack,"resolveStack","()V");Check(!Rt.ListItems(Stack).Any(x=>ReferenceEquals(x.Reference,instance.Reference)),"resolved stack instance removed (new copies may remain)");Resolved++;Trace.Add("结算完成 / RESOLUTION COMPLETE");
    }
    public void Sba(){Stage="GameAction.checkStateEffects";bool changed=Call(Action,"checkStateEffects","(Z)Z",JValue.I(1)).Int!=0;SbaChecks++;if(changed)SbaChanges++;Trace.Add("SBA 检查完成 / SBA CHECK COMPLETE; changed="+changed);Check(Call(Game,"isGameOver","()Z").Int==0,"SBA did not terminate the fixture game");Call(Stack,"addAllTriggeredAbilitiesToStack","()Z");}
    public void Drain(){for(int i=0;Call(Stack,"size","()I").Int>0;i++){if(i>=20)throw new InvalidOperationException("Unexpected trigger loop");ResolveOne();Sba();}}
}

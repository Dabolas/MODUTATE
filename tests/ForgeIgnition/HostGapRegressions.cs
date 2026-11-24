using System.Text.Json;
using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;

public sealed partial class HeadlessMatch
{
    private static void HostCases(string root,string name,Action<bool,string> check,Action<HeadlessMatch,Action<bool,string>,int,int> scenario,bool twoHeadedGiant=false)
    {
        string dir=BatchPaths.Output(root,"release/forge-headless/host-gaps",name);Directory.CreateDirectory(dir);
        int assertions=0;void Verify(bool ok,string message){check(ok,message);assertions++;}
        var program=ForgeProgram.BuildForDevelopment();var db=CardDatabase.Load(Path.Combine(root,"data/forge"));
        File.WriteAllText(Path.Combine(dir,"result.json"),"{\"passed\":false,\"status\":\"running\"}");
        for(int resources=0;resources<=1;resources++)for(int seed=1;seed<=4;seed++)
        {
            string output=Path.Combine(dir,$"resources-{resources}-seed-{seed}");Directory.CreateDirectory(output);
            using var trace=new TraceJournal(output);using var states=new StreamWriter(Path.Combine(output,"snapshots.jsonl"));using var choices=new StreamWriter(Path.Combine(output,"decisions.jsonl"));
            var input=new MatchInput(4,seed,4,twoHeadedGiant?[[],[],[],[]]:[[],[]],name);
            File.WriteAllText(Path.Combine(output,"input.json"),JsonSerializer.Serialize(input));
            var d=new HeadlessMatch(root,program,db,input,trace,states,new(seed,choices));d.g.Initialize(0,twoHeadedGiant:twoHeadedGiant);
            scenario(d,Verify,resources,seed);d.Snapshot("regression completed");
        }
        File.WriteAllText(Path.Combine(dir,"result.json"),JsonSerializer.Serialize(new{passed=true,assertions,scenarios=8,scope="controlled real-card effect assertions; not match acceptance"}));
    }
    public static void HiddenZoneRegression(string root,Action<bool,string> check)
    {
        bool chosen=false,declined=false;
        HostCases(root,"hidden-zone",check,(d,v,resources,seed)=>{
            var g=d.g;var legal=resources==1?g.Card("Llanowar Elves",0,"Library"):default;
            var illegal=g.Card("Raging Goblin",0,"Library");var spell=g.Card("Green Sun's Zenith",0,"Hand");var sa=g.Ability(spell,0);
            d.C(sa,"setXManaCostPaid","(Ljava/lang/Integer;)V",g.Rt.BoxInt(1));g.Fund(0,"G G");
            v(d.Play(sa,0)&&g.ManaCount(0)==0,"Zenith actually pays X=1 plus G");g.ResolveOne();g.Sba();g.Drain();
            v(g.In(illegal,"Library")&&g.In(spell,"Library"),"Illegal red creature stays in library and Zenith shuffles itself back");
            if(resources==1){bool moved=g.In(legal,"Battlefield");chosen|=moved;declined|=!moved;v(moved||g.In(legal,"Library"),"Legal green creature enters or search declines");}
            else v(!d.Zone(0,"Battlefield").Any(c=>d.B(c,"isCreature")),"Empty legal search resolves without inventing a choice");
        });
        check(chosen&&declined,"Search exercises both legal selection and refusal");
    }
    public static void ZoneCardsRegression(string root,Action<bool,string> check)
    {
        bool selected=false,refused=false;
        HostCases(root,"zone-cards",check,(d,v,resources,seed)=>{
            var g=d.g;var lands=Enumerable.Range(0,resources==1?4:1).Select(_=>g.Card("Forest",0,"Library")).ToArray();
            var spell=g.Card("Flare of Cultivation",0,"Hand");g.Fund(0,"G G G");v(d.Play(g.Ability(spell,0),0),"Flare cast through real payment");g.ResolveOne();g.Sba();g.Drain();
            int field=lands.Count(c=>g.In(c,"Battlefield")),hand=lands.Count(c=>g.In(c,"Hand"));
            v(field<=1&&hand<=1&&field+hand<=2&&lands.Where(c=>g.In(c,"Battlefield")).All(c=>d.B(g.Current(c),"isTapped")),"Flare puts at most one basic tapped on battlefield and one in hand");
            selected|=field+hand>0;refused|=field+hand==0;
            var foresight=g.Card("Foresight",0,"Hand");int available=d.Zone(0,"Library").Length;g.Fund(0,"U U");v(d.Play(g.Ability(foresight,0),0),"Foresight paid cast");g.ResolveOne();
            v(d.Zone(0,"Exile").Length==Math.Min(3,available),"Mandatory Foresight exiles exactly three or all remaining cards; no illegal refusal");
        });check(selected&&refused,"Optional multi-card search selects and refuses across seeds");
    }
    public static void EffectCardsRegression(string root,Action<bool,string> check)
    {
        bool selected=false,refused=false;
        HostCases(root,"effect-cards",check,(d,v,resources,seed)=>{
            var g=d.g;var akiri=g.Card("Akiri, Fearless Voyager",0,"Battlefield");var creature=g.Card("Raging Goblin",0,"Battlefield");
            var equip=g.Card("Bonesplitter",0,"Battlefield");if(resources==1)d.C(equip,"attachToEntity","(Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;)V",creature,default);
            var sa=d.Items(d.C(akiri,"getSpellAbilities","()Lforge/util/collect/FCollectionView;")).First(a=>d.B(a,"isActivatedAbility"));
            d.C(sa,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);g.Fund(0,"W");v(d.Play(sa,0)&&g.ManaCount(0)==0,"Akiri spends W even if no equipment is chosen");g.ResolveOne();
            bool tapped=d.B(creature,"isTapped"),attached=d.C(equip,"getAttachedTo","()Lforge/game/card/Card;").Reference!=null;
            v(tapped? !attached&&d.C(creature,"hasKeyword","(Ljava/lang/String;)Z",g.S("Indestructible")).Int!=0:attached==(resources==1),"Akiri unattachment taps and grants indestructible only when paid by an actual choice");
            if(resources==1){selected|=tapped;refused|=!tapped;}else v(!tapped,"No equipped creature produces no effect and no invalid bounds");
        });check(selected&&refused,"Akiri exercises acceptance and refusal");
    }
    public static void PutCounterRegression(string root,Action<bool,string> check)
    {
        bool counters=false,tokens=false;
        HostCases(root,"put-counter-cost",check,(d,v,resources,seed)=>{
            var g=d.g;var yisan=g.Card("Yisan, the Wanderer Bard",0,resources==1?"Battlefield":"Hand");
            var sa=d.Items(d.C(yisan,"getSpellAbilities","()Lforge/util/collect/FCollectionView;")).First(a=>d.B(a,"isActivatedAbility"));d.C(sa,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);
            var cost=d.C(sa,"getPayCosts","()Lforge/game/cost/Cost;");var part=d.Items(d.C(cost,"getCostParts","()Ljava/util/List;")).Single(p=>g.Rt.IsInstance(p.Reference!,"forge/game/cost/CostPutCounter"));
            if(resources==1){g.Fund(0,"G G G");v(d.Play(sa,0)&&g.ManaCount(0)==0&&d.B(yisan,"isTapped"),"Yisan pays mana and taps");v(d.C(yisan,"getCounters","(Lforge/game/card/CounterType;)I",d.C(part,"getCounter","()Lforge/game/card/CounterType;")).Int==1,"Yisan gains exactly one verse counter as actual cost");g.ResolveOne();}
            else v(d.PutCounterDecision(part,sa,g.Players[0],false).Reference==null,"Absent battlefield source rejects counter cost");
            var fabricate=g.Card("Weaponcraft Enthusiast",0,"Hand");g.Fund(0,"B B B");v(d.Play(g.Ability(fabricate,0),0),"Real Fabricate creature cast");g.ResolveOne();g.Sba();g.Drain();
            int power=d.C(g.Current(fabricate),"getNetPower","()I").Int,servos=d.Zone(0,"Battlefield").Count(c=>d.B(c,"isToken"));
            v(power==2&&servos==0||power==0&&servos==2,"Fabricate actually places two counters or creates two Servos on refusal");counters|=power==2;tokens|=servos==2;
        });check(counters&&tokens,"Counter payment and refusal both exercised");
    }
    public static void TapTypeRegression(string root,Action<bool,string> check){HostCases(root,"tap-type-cost",check,(d,v,resources,seed)=>{
        var g=d.g;var mount=g.Card("Brightfield Mustang",0,"Battlefield");var other=resources==1?g.Card("Raging Goblin",0,"Battlefield"):default;var enemy=g.Card("Raging Goblin",1,"Battlefield");
        var sa=d.Items(d.C(mount,"getSpellAbilities","()Lforge/util/collect/FCollectionView;")).First(a=>d.B(a,"isActivatedAbility"));d.C(sa,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);
        var part=d.Items(d.C(d.C(sa,"getPayCosts","()Lforge/game/cost/Cost;"),"getCostParts","()Ljava/util/List;")).Single(p=>g.Rt.IsInstance(p.Reference!,"forge/game/cost/CostTapType"));
        v(!d.B(mount,"isSaddled")&&!d.B(enemy,"isTapped"),"Declining to activate leaves mount unsaddled and enemy untouched");
        if(resources==0)v(d.TapTypeDecision(part,sa,g.Players[0],false).Reference==null&&!d.B(mount,"isTapped"),"Insufficient legal power rejects payment without tapping source");
        else{v(d.Play(sa,0)&&d.B(other,"isTapped")&&!d.B(mount,"isTapped")&&!d.B(enemy,"isTapped"),"Saddle taps only legal other creature as cost");g.ResolveOne();v(d.B(mount,"isSaddled"),"Actual Saddle effect marks Mustang saddled");}
    });
        bool paid=false,declined=false;
        HostCases(root,"tap-type-refusal",check,(d,v,resources,seed)=>{
            var g=d.g;var falls=g.Card("Koskun Falls",0,"Battlefield");var creature=resources==1?g.Card("Raging Goblin",0,"Battlefield"):default;
            var ability=d.S("forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;",d.C(falls,"getSVar","(Ljava/lang/String;)Ljava/lang/String;",g.S("TrigUpkeep")),falls);d.C(ability,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);d.Enqueue(ability);g.ResolveOne();
            bool survived=g.In(falls,"Battlefield");v(survived||g.In(falls,"Graveyard"),"Koskun upkeep actually keeps or sacrifices enchantment");
            v(resources==0?!survived:survived==d.B(creature,"isTapped"),"Koskun refusal or insufficient creatures sacrifices it; payment taps actual creature");
            if(resources==1){paid|=survived;declined|=!survived;}
        });check(paid&&declined,"Real tap-cost upkeep exercises payment and refusal");
    }
    public static void SurveilRegression(string root,Action<bool,string> check)
    {
        bool kept=false,moved=false;
        HostCases(root,"surveil",check,(d,v,resources,seed)=>{
            var g=d.g;var cards=resources==1?new[]{g.Card("Island",0,"Library"),g.Card("Forest",0,"Library")}:Array.Empty<JValue>();
            var spell=g.Card("Mission Briefing",0,"Hand");g.Fund(0,"U U");v(d.Play(g.Ability(spell,0),0)&&g.ManaCount(0)==0,"Mission Briefing pays UU");g.ResolveOne();
            v(cards.All(c=>g.In(c,"Library")||g.In(c,"Graveyard"))&&g.In(spell,"Graveyard"),"Surveil partitions offered cards into library and graveyard without losing cards");
            foreach(var card in cards){bool grave=g.In(card,"Graveyard");var record=d.tape.Records.Single(r=>r.Kind=="surveil destination "+d.Label(card));v(grave==(record.Choice==1),"Actual card zone follows recorded surveil decision");kept|=!grave;moved|=grave;}
            if(resources==0)v(d.Zone(0,"Library").Length==0,"Empty library resolves surveil without invalid choices");
        });check(kept&&moved,"Surveil exercises keeping cards and moving cards");
    }
    public static void CardNameRegression(string root,Action<bool,string> check)
    {
        bool named=false,cancelled=false;
        HostCases(root,"card-name",check,(d,v,resources,seed)=>{
            var g=d.g;g.Card("Lightning Bolt",1,"Hand");var curse=g.Card("Curse of Silence",0,"Hand");var sa=g.Ability(curse,0);g.Target(sa,g.Players[1]);g.Fund(0,"W");v(g.Cast(curse,sa,0),"Curse of Silence cast targeting opponent");g.ResolveOne();g.Sba();
            var chosen=d.Items(d.C(g.Current(curse),"getNamedCards","()Ljava/util/List;"));named|=chosen.Length>0;cancelled|=chosen.Length==0;
            v(chosen.Length<=1,"Name effect records at most one valid name");
            if(chosen.Length>0){var card=g.Card(g.Rt.StringValue(chosen[0]),1,"Hand");var ability=g.Ability(card,1);var cost=d.C(ability,"getPayCosts","()Lforge/game/cost/Cost;");
                var adjusted=d.S("forge/game/cost/CostAdjustment","adjust","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Z)Lforge/game/cost/Cost;",cost,ability,JValue.I(0));
                int Cmc(JValue c)=>d.C(d.C(d.C(c,"getCostMana","()Lforge/game/cost/CostPartMana;"),"getManaCostFor","(Lforge/game/spellability/SpellAbility;)Lforge/card/mana/ManaCost;",ability),"getCMC","()I").Int;
                v(Cmc(adjusted)==Cmc(cost)+(d.B(ability,"isLandAbility")?0:2),"Curse raises a named spell by two; named lands remain land plays");}
            else v(g.Rt.StringValue(d.C(g.Players[0],"getNamedCard","()Ljava/lang/String;"))=="","Cancelled naming leaves no chosen name");
            v(g.Rt.StringValue(d.ChooseLegalCardName([sa,g.Rt.ListOf([]),g.S("empty")],0))=="","No offered card faces returns empty name");
        });check(named&&cancelled,"Naming and cancellation exercised");
    }
    public static void DelveRegression(string root,Action<bool,string> check)
    {
        bool delved=false,declined=false;
        HostCases(root,"delve",check,(d,v,resources,seed)=>{
            var g=d.g;var grave=Enumerable.Range(0,resources==1?5:0).Select(_=>g.Card("Forest",0,"Graveyard")).ToArray();
            var victim=g.Card("Hill Giant",1,"Battlefield");var spell=g.Card("Magmatic Sinkhole",0,"Hand");var sa=g.Ability(spell,0);g.Fund(0,resources==1?"R R R R R R":"R");
            var ctrl=d.C(g.Players[0],"getController","()Lforge/game/player/PlayerController;");
            bool played=d.S("forge/game/player/PlaySpellAbility","playSpellAbility","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Z",ctrl,g.Players[0],sa).Int!=0;
            if(resources==0){v(!played&&g.In(spell,"Hand")&&g.ManaCount(0)==1&&g.In(victim,"Battlefield"),"Insufficient mana and no delve cards rejects spell without spending or damage");return;}
            int exiled=grave.Count(c=>g.In(c,"Exile"));v(played&&g.ManaCount(0)==exiled&&grave.All(c=>g.In(c,"Graveyard")||g.In(c,"Exile")),"Each actual delve exile replaces exactly one generic mana");
            g.ResolveOne();g.Sba();v(g.In(victim,"Graveyard")&&g.In(spell,"Graveyard"),"Paid Sinkhole deals lethal five damage");delved|=exiled>0;declined|=exiled==0;
        });check(delved&&declined,"Delve exercises exiling and choosing zero cards");
    }
    public static void KeywordCostRegression(string root,Action<bool,string> check)
    {
        bool paid=false,declined=false;
        HostCases(root,"keyword-cost",check,(d,v,resources,seed)=>{
            var g=d.g;var card=g.Card("Fountainport Charmer",0,"Hand");g.Fund(0,resources==1?"G G G G":"G G");v(d.Play(g.Ability(card,0),0),"Fountainport Charmer casts with affordable optional cost");
            int mana=g.ManaCount(0);g.ResolveOne();g.Sba();g.Drain();var copies=d.Zone(0,"Battlefield").Where(c=>d.B(c,"isToken")).ToArray();
            v(copies.Length<=1&&copies.All(c=>d.C(c,"getNetPower","()I").Int==1&&d.C(c,"getNetToughness","()I").Int==1),"Offspring creates at most one actual 1/1 copy");
            v(resources==0?copies.Length==0&&mana==0:copies.Length==1?mana==0:mana==2,"Offspring costs exactly two extra mana and is unavailable without resources");
            if(resources==1){paid|=copies.Length==1;declined|=copies.Length==0;}
        });check(paid&&declined,"Offspring payment and refusal exercised");
    }
    public static void ManaComboRegression(string root,Action<bool,string> check)=>HostCases(root,"mana-combo",check,(d,v,resources,seed)=>{
        var g=d.g;var relic=g.Card("Coalition Relic",0,"Battlefield");var charge=d.S("forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;",g.S("CHARGE"));
        if(resources==1){var table=g.New("forge/game/GameEntityCounterTable","()V");d.C(relic,"addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V",charge,JValue.I(2),g.Players[0],table);d.C(table,"replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V",g.Game,default);}
        var ability=d.S("forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;",d.C(relic,"getSVar","(Ljava/lang/String;)Ljava/lang/String;",g.S("TrigRemove")),relic);d.C(ability,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);
        d.S("forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V",ability);
        v(d.C(relic,"getCounters","(Lforge/game/card/CounterType;)I",charge).Int==0&&g.ManaCount(0)==resources*2,"Coalition Relic removes actual charge counters and produces exactly that much mana");
        var colors=d.S("forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;",JValue.I(3));var map=d.ChooseManaCombo(colors,2,true);var entries=d.Items(d.C(map,"entrySet","()Ljava/util/Set;"));
        v(entries.Length==2&&entries.All(e=>g.Rt.UnboxInt(d.C(e,"getValue","()Ljava/lang/Object;"))==1),"Different colors allocation uses each offered color once");
        bool rejected=false;try{d.ChooseManaCombo(colors,3,true);}catch(HostDecisionGap){rejected=true;}v(rejected,"Impossible distinct-color allocation is rejected rather than invented");
        v(d.C(d.ChooseManaCombo(colors,0,false),"size","()I").Int==0,"Zero mana requested allocates nothing");
    });
    public static void ColorsRegression(string root,Action<bool,string> check)
    {
        bool optionalNone=false,optionalChosen=false;
        HostCases(root,"colors",check,(d,v,resources,seed)=>{
            var g=d.g;var card=g.Card("Sol Grail",0,"Hand");if(resources==1)g.Fund(0,"C C C");var sa=g.Ability(card,0);
            bool played=d.S("forge/game/player/PlaySpellAbility","playSpellAbility","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Z",d.C(g.Players[0],"getController","()Lforge/game/player/PlayerController;"),g.Players[0],sa).Int!=0;
            if(resources==0)v(!played&&g.In(card,"Hand"),"Unfunded Sol Grail remains in hand");
            else{v(played&&g.ManaCount(0)==0,"Sol Grail pays three mana");g.ResolveOne();var current=g.Current(card);var colors=d.Items(d.C(current,"getChosenColors","()Ljava/lang/Iterable;"));v(colors.Length==1,"Sol Grail actually records one mandatory color");
                var manaSa=d.Items(d.C(current,"getSpellAbilities","()Lforge/util/collect/FCollectionView;")).First(a=>d.B(a,"isManaAbility"));d.C(manaSa,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);v(d.Play(manaSa,0),"Sol Grail mana ability activates");
                var color=d.S("forge/card/MagicColor","fromName","(Ljava/lang/String;)B",colors[0]);v(g.ManaCount(0)==1&&d.C(g.ManaPool(0),"getAmountOfColor","(B)I",color).Int==1&&d.B(current,"isTapped"),"Sol Grail taps and produces its chosen color");}
            var offered=d.S("forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;",JValue.I(3));int optional=d.C(d.ChooseColorSet(offered,0,1),"getColor","()B").Int;
            v(optional is 0 or 1 or 2,"Optional color selection chooses only offered colors or none");optionalNone|=optional==0;optionalChosen|=optional!=0;
            v(d.B(d.ChooseColorSet(d.S("forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;",JValue.I(0)),0,1),"isColorless"),"Empty offered color set does not invent a color");
        });check(optionalNone&&optionalChosen,"Optional color selection and refusal exercised");
    }
}









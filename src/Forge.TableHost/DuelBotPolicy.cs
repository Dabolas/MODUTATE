using Planeswalker.ForgeAot;

namespace Planeswalker.TableHost
{
    public enum TableBotStyle { Replay, Balanced, Aggro, Midrange, Control }
}

public sealed partial class HeadlessMatch
{
    const string BotCard="Lforge/game/card/Card;";
    const string BotPlayer="Lforge/game/player/Player;";
    readonly Planeswalker.TableHost.TableBotStyle botStyle;
    bool TacticalBot=>botStyle!=Planeswalker.TableHost.TableBotStyle.Replay;
    bool AggressiveBot=>botStyle==Planeswalker.TableHost.TableBotStyle.Aggro;
    bool ControlBot=>botStyle==Planeswalker.TableHost.TableBotStyle.Control;
    string BotApi(JValue ability)=>g.Rt.InspectEnumName(C(ability,"getApi","()Lforge/game/ability/ApiType;"))??"";
    string BotParameter(JValue ability,string key)=>OptionalText(C(ability,"getParam","(Ljava/lang/String;)Ljava/lang/String;",g.S(key)));
    int BotCost(JValue card)=>Math.Max(0,C(card,"getCMC","()I").Int);
    bool BotOwns(JValue card)=>ReferenceEquals(C(card,"getController","()"+BotPlayer).Reference,g.Players[1].Reference);
    bool BotIsCard(JValue target)=>target.Reference!=null&&g.Rt.IsInstance(target.Reference,"forge/game/card/Card");
    bool BotKeyword(JValue card,string name)=>C(card,"hasKeyword","(Ljava/lang/String;)Z",g.S(name)).Int!=0;
    int BotPower(JValue card)=>Math.Max(0,C(card,"getNetPower","()I").Int);
    int BotHealth(JValue card)=>Math.Max(1,C(card,"getNetToughness","()I").Int-C(card,"getDamage","()I").Int);

    void InstallBotPolicy()
    {
        if(!TacticalBot)return;
        chooseBotTarget=BotSelectTarget;
        chooseBotTargetCount=(ability,min,max)=>BotApi(ability) switch{
            "Destroy" or "ChangeZone" or "Pump" or "DealDamage" => max,
            _ => min
        };
        payBotMana=(due,sa,matrix,quote,effect)=>PayFromTable(due,sa,matrix,quote,effect,1);
        availableBotMana=ability=>TableManaCapacity(ability,1);

        void BotDecision(string name,Func<JValue[],JValue> decide)
        {
            var previous=g.Decision(name)!;
            g.SetDecision(name,(controller,args)=>ControllerSeat(controller)==1?
                JHostResult.Complete(decide(args)):previous(controller,args));
        }
        BotDecision("chooseCardsToDiscardToMaximumHandSize",a=>Cards(BotKeepOrder(Zone(1,"Hand")).Reverse().Take(a[0].Int)));
        BotDecision("chooseCardsToDiscardFrom",a=>{
            var offered=Items(a[2]);
            return Cards((Seat(a[0])==1?BotKeepOrder(offered).Reverse():offered.OrderByDescending(BotCost)).Take(a[3].Int));
        });
        BotDecision("arrangeForScry",a=>BotArrangeTop(Items(a[0])));
        BotDecision("arrangeForSurveil",a=>BotArrangeTop(Items(a[0])));
        BotDecision("willPutCardOnTop",a=>JValue.I(BotValueInHand(a[0],BotHand())>=0?1:0));
        BotDecision("chooseModeForAbility",BotChooseModes);
        var chooseType=g.Decision("chooseSomeType")!;
        g.SetDecision("chooseSomeType",(controller,args)=>{
            if(ControllerSeat(controller)!=1||OptionalText(args[0])!="Creature"||
               BotParameter(args[1],"AILogic")!="MostProminentInComputerDeckNonToken")return chooseType(controller,args);
            var types=Items(args[2]);
            var candidates=Zone(1,"Hand").Where(card=>B(card,"isCreature")).ToArray();
            if(candidates.Length==0||types.Length==0)return chooseType(controller,args);
            var counts=candidates.SelectMany(card=>Items(C(C(card,"getType","()Lforge/card/CardTypeView;"),"getCreatureTypes","()Ljava/util/Set;")))
                .GroupBy(OptionalText,StringComparer.Ordinal).ToDictionary(group=>group.Key,group=>group.Count(),StringComparer.Ordinal);
            var best=types.OrderByDescending(type=>counts.TryGetValue(OptionalText(type),out int count)?count:0).First();
            return JHostResult.Complete(best);
        });
        var confirmTrigger=g.Decision("confirmTrigger")!;
        g.SetDecision("confirmTrigger",(controller,args)=>{
            if(ControllerSeat(controller)!=1)return confirmTrigger(controller,args);
            var wrapped=C(args[0],"getWrappedAbility","()Lforge/game/spellability/SpellAbility;");
            if(IsChromeMoxImprint(wrapped))return JHostResult.Complete(JValue.I(BotWantsMoxImprint()?1:0));
            return confirmTrigger(controller,args);
        });
        BotDecision("chooseStartingPlayer",_=>g.Players[1]);
    }

    sealed record BotHandState(int Lands,int LandCards,int SpellCards,int[] Colors);
    BotHandState BotHand()
    {
        var hand=Zone(1,"Hand");
        int lands=Zone(1,"Battlefield").Count(card=>B(card,"isLand"));
        int landCards=0;
        var colors=new int[5];
        foreach(var card in hand){
            if(B(card,"isLand")){landCards++;continue;}
            int mask=C(C(card,"getColor","()Lforge/card/ColorSet;"),"getColor","()B").Int;
            for(int i=0;i<colors.Length;i++)if((mask&(1<<i))!=0)colors[i]++;
        }
        return new BotHandState(lands,landCards,hand.Length-landCards,colors);
    }

    int BotLandValue(JValue card,BotHandState hand)
    {
        var type=C(card,"getType","()Lforge/card/CardTypeView;");
        int score=0;
        string[] basicTypes={"Plains","Island","Swamp","Mountain","Forest"};
        for(int i=0;i<basicTypes.Length;i++)
            if(C(type,"hasSubtype","(Ljava/lang/String;)Z",g.S(basicTypes[i])).Int!=0)score+=2*hand.Colors[i];
        return score;
    }

    int BotValueInHand(JValue card,BotHandState hand)
    {
        int aim=AggressiveBot?3:ControlBot?6:4;
        if(B(card,"isLand")){
            int planned=hand.Lands+hand.LandCards;
            return (planned<=2?18:planned<=aim?5:-8-2*(planned-aim))+Math.Min(5,BotLandValue(card,hand));
        }
        int cost=BotCost(card);
        int value=6+Math.Min(5,cost)-4*Math.Max(0,cost-Math.Max(2,hand.Lands+hand.LandCards));
        if(AggressiveBot&&B(card,"isCreature"))value+=2;
        return value;
    }

    JValue[] BotKeepOrder(JValue[] offered)
    {
        var hand=BotHand();
        return offered.OrderByDescending(card=>BotValueInHand(card,hand)).ToArray();
    }

    JValue BotArrangeTop(JValue[] cards)
    {
        var hand=BotHand();
        var ranked=cards.Select(card=>(Card:card,Value:BotValueInHand(card,hand))).OrderByDescending(row=>row.Value).ToArray();
        return S("org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;",
            Cards(ranked.Where(row=>row.Value>=0).Select(row=>row.Card)),Cards(ranked.Where(row=>row.Value<0).Select(row=>row.Card)));
    }

    bool IsChromeMoxImprint(JValue ability)=>ability.Reference!=null&&BotParameter(ability,"Imprint")=="True"&&
        Name(C(ability,"getHostCard","()"+BotCard))=="Chrome Mox";
    bool BotWantsMoxImprint(bool beforeCasting=false)
    {
        var hand=BotHand();
        return hand.Lands<4&&hand.SpellCards>=(beforeCasting?3:2)&&Zone(1,"Hand").Any(c=>!B(c,"isArtifact")&&!B(c,"isLand")&&!B(c,"isColorless"));
    }

    IEnumerable<JValue> BotChooseZoneCards(JValue[] offered,int minimum,int maximum,bool searchLibrary,bool giveUpCard,JValue ability)
    {
        if(offered.Length==0)return offered;
        bool own=BotOwns(offered[0]);
        if(own&&giveUpCard&&minimum==0&&maximum>0&&IsChromeMoxImprint(ability)&&BotWantsMoxImprint())
            return BotKeepOrder(offered.Where(c=>!B(c,"isColorless")).ToArray()).Reverse().Take(1);
        var hand=BotHand();
        var scores=new Dictionary<string,int>(StringComparer.Ordinal);
        int Rank(JValue card){
            string name=Name(card);
            if(scores.TryGetValue(name,out int value))return value;
            value=BotValueInHand(card,hand);
            if(searchLibrary&&B(card,"isLand"))value=8+BotLandValue(card,hand);
            if(giveUpCard&&!own)value=BotCost(card)+(B(card,"isCreature")?4:0);
            scores.Add(name,value);
            return value;
        }
        return giveUpCard&&own?offered.OrderBy(Rank).Take(minimum):offered.OrderByDescending(Rank).Take(maximum);
    }

    bool BotShouldMulligan(JValue[] cards,int mulligans)
    {
        if(mulligans>=2)return false;
        int lands=cards.Count(card=>B(card,"isLand"));
        if(lands<2||lands>5)return true;
        return mulligans==0&&AggressiveBot&&lands==2&&!cards.Any(card=>!B(card,"isLand")&&BotCost(card)<=2);
    }

    int BotPermanentValue(JValue card)
    {
        if(B(card,"isCreature"))return 4+BotPower(card)*2+BotHealth(card)+Math.Min(4,BotCost(card));
        if(B(card,"isPlaneswalker"))return 13+Math.Min(5,BotCost(card));
        if(B(card,"isLand"))return 3;
        return 5+Math.Min(7,BotCost(card));
    }

    JValue BotSelectTarget(JValue ability,JValue[] legal)
    {
        if(legal.Length<=1)return legal.FirstOrDefault();
        string api=BotApi(ability);
        return legal.OrderByDescending(target=>BotTargetValue(ability,api,target)).First();
    }

    JValue BotChooseModes(JValue[] args)
    {
        var modes=LegalModes(Items(args[1]));
        int minimum=args[2].Int,maximum=args[3].Int;
        if(args[4].Int!=0||modes.Length<minimum)return ChooseModes(args);
        int ScoreMode(JValue ability){
            string api=BotApi(ability);
            var targets=Items(C(ability,"getTargets","()Lforge/game/spellability/TargetChoices;"));
            if(targets.Length>0)return targets.Sum(target=>BotTargetValue(ability,api,target));
            return api switch{
                "Draw"=>19,"Token" or "Amass"=>15,"Scry" or "Surveil" or "Investigate"=>11,
                "GainLife"=>g.Life(1)<=7?16:6,_=>3
            };
        }
        var scores=modes.ToDictionary(mode=>mode,ScoreMode);
        if(HasModeCosts(args[0],modes)){
            var choice=AffordableModes(args[0],modes,minimum,maximum).OrderByDescending(set=>set.Sum(mode=>scores[mode])-4*set.Length).FirstOrDefault();
            if(choice==null)throw new HostDecisionGap("No payable mode set for "+Label(args[0]));
            return g.Rt.ListOf(choice);
        }
        var chosen=modes.OrderByDescending(mode=>scores[mode]).Take(maximum).Where((mode,index)=>index<minimum||scores[mode]>0);
        return g.Rt.ListOf(chosen.ToArray());
    }

    int BotTargetValue(JValue ability,string api,JValue target)
    {
        if(target.Reference==null)return 0;
        bool damage=api is "DealDamage" or "LoseLife";
        int damageAmount=damage&&(int.TryParse(BotParameter(ability,api=="LoseLife"?"LifeAmount":"NumDmg"),out int amount))?amount:2;
        bool hostile=damage||api is "Destroy" or "Counter" or "Debuff" or "Discard" or "Sacrifice" or "Tap" or "GainControl" or "Goad" ||
            api=="ChangeZone"&&BotParameter(ability,"Origin").Contains("Battlefield",StringComparison.Ordinal);
        if(api=="Attach"){
            var card=C(ability,"getHostCard","()"+BotCard);
            hostile=OptionalText(C(card,"getSVar","(Ljava/lang/String;)Ljava/lang/String;",g.S("AttachAILogic")))=="Curse";
        }
        bool helpful=api is "Pump" or "Attach" or "Draw" or "GainLife" or "Regenerate" or "Untap" or "Protection" or "PutCounter" or
            "InternalLegendaryRule" or "ChangeZone";
        if(g.Rt.IsInstance(target.Reference,"forge/game/spellability/SpellAbility")){
            bool own=ReferenceEquals(C(target,"getActivatingPlayer","()"+BotPlayer).Reference,g.Players[1].Reference);
            return (hostile==own?-40:24)+BotCost(C(target,"getHostCard","()"+BotCard));
        }
        if(g.Rt.IsInstance(target.Reference,"forge/game/player/Player")){
            bool own=ReferenceEquals(target.Reference,g.Players[1].Reference);
            if(damage&&!own)return damageAmount>=C(target,"getLife","()I").Int?100:AggressiveBot?17:9;
            return hostile?(own?-40:22):helpful?(own?20:-20):0;
        }
        if(!BotIsCard(target))return 0;
        bool friendly=BotOwns(target);
        int value=BotPermanentValue(target);
        if(hostile&&!friendly&&B(target,"isLand")&&!B(target,"isBasicLand")&&api is "Destroy" or "ChangeZone")value+=14;
        if(api=="Untap"&&!B(target,"isTapped"))return -10;
        if(api=="Tap"&&B(target,"isTapped"))return -10;
        if(api is "Pump" or "Protection"){
            var combat=C(g.Game,"getCombat","()Lforge/game/combat/Combat;");
            if(combat.Reference!=null&&(C(combat,"isAttacking","("+BotCard+")Z",target).Int!=0||
                                       C(combat,"isBlocking","("+BotCard+")Z",target).Int!=0))value+=10;
        }
        if(damage&&B(target,"isCreature"))value=damageAmount>=BotHealth(target)?value+12:value/3;
        if(hostile)return friendly?-35:value;
        if(helpful)return friendly?value:-35;
        return friendly?value:0;
    }

    sealed record BotWindow(bool OwnTurn,string Phase,bool StackEmpty)
    {
        public bool OwnMain=>OwnTurn&&Phase is "MAIN1" or "MAIN2";
        public bool CombatTrick=>Phase is "COMBAT_DECLARE_BLOCKERS" or "COMBAT_FIRST_STRIKE_DAMAGE";
        public bool MayActOnEmptyStack=>OwnMain||CombatTrick||Phase is "UPKEEP" or "COMBAT_DECLARE_ATTACKERS" or "END_OF_TURN";
    }

    BotWindow CurrentBotWindow()=>new(Seat(C(g.Phase,"getPlayerTurn","()"+BotPlayer))==1,
        g.Rt.InspectEnumName(C(g.Phase,"getPhase","()Lforge/game/phase/PhaseType;"))??"",B(g.Stack,"isEmpty"));

    bool HasAlternativeActionCosts()
    {
        const string mode="forge/game/staticability/StaticAbilityMode";
        var zones=g.Rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;");
        var sources=Items(C(g.Game,"getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;",zones));
        var alternate=g.Enum(mode,"AlternativeCost");
        return sources.Any(source=>Items(C(source,"getStaticAbilities","()Lforge/util/collect/FCollectionView;"))
            .Any(ability=>C(ability,"checkMode","(L"+mode+";)Z",alternate).Int!=0));
    }

    bool BotConsiderBattlefieldCard(JValue card,Lazy<bool> mayHaveAlternativeCosts)
    {
        if(!B(card,"isBasicLand")||B(card,"isFaceDown")||B(card,"isModal")||
            g.Rt.InspectEnumName(C(card,"getCurrentStateName","()Lforge/card/CardStateName;"))!="Original")return true;
        // A land already in play cannot offer its ordinary land play, and the
        // bot pays for actions via its mana planner. Preserve other abilities
        // granted by continuous effects, even on a basic land.
        // An alternative activation cost that moves a card to/from the library
        // can turn a printed mana ability into an action that uses the stack.
        return Items(C(card,"getNonManaAbilities","()Lforge/util/collect/FCollectionView;"))
            .Any(ability=>!B(ability,"isLandAbility"))||mayHaveAlternativeCosts.Value;
    }

    bool BotConsiderAction(JValue ability,BotWindow window)
    {
        if(B(ability,"isManaAbility"))return false;
        if(B(ability,"isLandAbility"))return window.OwnMain&&window.StackEmpty;
        string api=BotApi(ability);
        if(api=="Counter")return !window.StackEmpty;
        if(api=="Pump"&&window.StackEmpty&&B(ability,"usesTargeting")&&!window.CombatTrick&&
            string.IsNullOrEmpty(BotParameter(ability,"Duration")))return false;
        return true;
    }

    JValue BotPriority(List<JValue> legal,BotWindow window)
    {
        if(legal.Count==0)return default;
        var hand=BotHand();
        var creaturesOurs=new Lazy<JValue[]>(()=>Zone(1,"Battlefield").Where(c=>B(c,"isCreature")).ToArray());
        var creaturesTheirs=new Lazy<JValue[]>(()=>Zone(0,"Battlefield").Where(c=>B(c,"isCreature")).ToArray());
        int Score(JValue ability){
            var card=C(ability,"getHostCard","()"+BotCard);
            if(B(ability,"isLandAbility"))return 90+BotLandValue(card,hand);
            if(Name(card)=="Chrome Mox"&&!BotWantsMoxImprint(beforeCasting:true))return 0;
            string api=BotApi(ability);
            if(api is "DestroyAll" or "DamageAll" or "SacrificeAll" ||
                api=="ChangeZoneAll"&&BotParameter(ability,"Origin").Contains("Battlefield",StringComparison.Ordinal)){
                int ours=creaturesOurs.Value.Length,theirs=creaturesTheirs.Value.Length;
                bool threat=theirs>0&&creaturesTheirs.Value.Sum(BotPower)>=g.Life(1);
                return theirs>ours&&(theirs>=2||threat)?34+3*(theirs-ours):0;
            }
            if(api=="ChangeZone"&&BotParameter(ability,"Origin").Contains("Library",StringComparison.Ordinal)&&B(card,"isLand"))
                return hand.SpellCards>0&&(window.OwnMain||!window.OwnTurn&&window.Phase=="END_OF_TURN")?32:0;
            if(api=="Draw"&&BotParameter(ability,"Defined")=="Opponent")return 0;
            int adjustedCost=BotCost(card);
            var targets=Items(C(ability,"getTargets","()Lforge/game/spellability/TargetChoices;"));
            int targetScore=targets.Length==0?0:targets.Sum(target=>BotTargetValue(ability,api,target));
            if(targetScore<0&&B(ability,"usesTargeting"))return 0;
            if(targetScore>=100||api=="Counter")return targetScore+28;
            if(api is "Destroy" or "Debuff" or "DealDamage" or "Tap" or "GainControl" || api=="ChangeZone"&&targetScore>0){
                if(window.OwnMain&&window.Phase=="MAIN2"&&api=="DealDamage"&&targetScore<20&&!AggressiveBot)return 0;
                return targetScore>=12?12+targetScore-adjustedCost:0;
            }
            if(api is "Pump" or "Protection")return window.CombatTrick||!window.StackEmpty?12+targetScore:0;
            if(api=="Scry"||api=="Surveil"||api=="Draw"||api=="Investigate")
                return window.OwnMain&&window.Phase=="MAIN1"&&AggressiveBot?9:21+Math.Max(0,3-hand.SpellCards)*3;
            if(api is "Discard" or "Mill" && !window.OwnMain)return 0;
            if(B(ability,"isSpell")&&B(card,"isCreature")){
                if(window.OwnMain&&window.Phase=="MAIN1"&&!BotKeyword(card,"Haste")&&!AggressiveBot)
                    return ControlBot?0:12+adjustedCost;
                return 20+Math.Min(9,adjustedCost*2);
            }
            if(!window.StackEmpty&&targets.Length==0&&!window.CombatTrick)return 0;
            if(window.OwnMain||!window.OwnTurn&&window.Phase=="END_OF_TURN")return 13+Math.Min(6,adjustedCost);
            return 0;
        }
        var best=legal.Select(ability=>(Ability:ability,Score:Score(ability))).OrderByDescending(row=>row.Score).First();
        return best.Score>0?g.Rt.ListOf([best.Ability]):default;
    }
}

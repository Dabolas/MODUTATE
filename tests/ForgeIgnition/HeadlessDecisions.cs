using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    private Func<JValue,JValue[],JHostResult>? chooseOfferedFace;
    private Func<JValue,JValue[],JValue[]>? orderedTriggers {get;set;}
    private Func<string,int,int,int>? announcedNumber {get;set;}
    private Func<int[],int>? announcedPayableX {get;set;}
    private Func<JValue,bool>? targetsAfterAnnouncement {get;set;}
    private Func<JValue,JValue,JValue,bool>? acceptLifePayment {get;set;}
    private Func<JValue,JValue[],JValue>? chooseBotTarget;
    private Func<JValue,int,int,int>? chooseBotTargetCount;
    private Func<JValue,JValue,JValue,bool,bool,bool>? payBotMana;
    private Func<JValue,int>? availableBotMana;
    private readonly Dictionary<int,JValue[]> delvePlans=[];
    private JValue delveAbility;
    private bool probingDelve;
    private JValue[]? proposedDelve;
    private void InstallDecisions()
    {
        JHostResult Done(JValue v=default)=>JHostResult.Complete(v);
        void Bind(string name,Func<JValue,JValue[],JValue> body)=>g.SetDecision(name,(ctrl,a)=>Done(body(ctrl,a)));
        foreach(string notification in new[]{"reveal","notifyOfValue","revealAnte","revealAISkipCards","revealUnsupported","autoPassCancel","awaitNextInput","cancelAwaitNextInput"})
            Bind(notification,(ctrl,a)=>{g.Trace.Add("HOST notification "+notification);return default;});
        foreach(string confirmation in new[]{"confirmTrigger","confirmReplacementEffect","confirmAction","confirmPayment","confirmStaticApplication","chooseBinary","mulliganKeepHand","willPutCardOnTop"})
            Bind(confirmation,(ctrl,a)=>JValue.I(tape.Choose(confirmation+":"+ControllerSeat(ctrl),["no","yes"])));
        foreach(string select in new[]{"chooseManaFromPool","chooseSingleReplacementEffect","chooseSingleStaticAbility","chooseSingleSpellForEffect","chooseStartingHand","chooseCounterType","chooseKeywordForPump","chooseRollToIgnore","chooseRollToModify"})
            Bind(select,(ctrl,a)=>Pick(select,Items(a[0])));
        Bind("chooseSingleEntityForEffect",(ctrl,a)=>{
            var offered=Items(a[0]);
            // Effects such as the untap-step restriction can consume their last eligible option before asking.
            if(offered.Length==0){
                g.Trace.Add("HOST no eligible entity for effect");
                return default;
            }
            return Pick("chooseSingleEntityForEffect",offered);
        });
        Bind("chooseSomeType",(ctrl,a)=>Pick("type",Items(a[2])));
        Bind("chooseSector",(ctrl,a)=>Pick("sector",Items(a[2])));
        Bind("chooseProtectionType",(ctrl,a)=>Pick("protection type",Items(a[1])));
        Bind("chooseCardName",(ctrl,a)=>ChooseLegalCardName(a,ControllerSeat(ctrl)));
        g.Rt.Bind("l3/ConsoleController","chooseSingleCardFace","(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;)Lforge/card/ICardFace;",(r,ctrl,a)=>{
            if(chooseOfferedFace!=null)return chooseOfferedFace(ctrl,a);
            var offered=Items(a[1]);
            return Done(offered.Length==0?default:Pick("choose offered card face",offered));
        });
        Bind("chooseNumberForKeywordCost",(ctrl,a)=>JValue.I(ChooseKeywordCount(a[0],a[1],a[4].Int,ControllerSeat(ctrl))));
        Bind("specifyManaCombo",(ctrl,a)=>ChooseManaCombo(a[1],a[2].Int,a[3].Int!=0));
        Bind("chooseColors",(ctrl,a)=>ChooseColorSet(a[4],a[2].Int,a[3].Int));
        Bind("getAbilityToPlay",(ctrl,a)=>{
            var offered=Items(a[1]);
            if(offered.Length>1)offered=offered.Where(sa=>CanFundVariant(sa,ControllerSeat(ctrl))).ToArray();
            return Pick("ability",offered);
        });
        Bind("chooseStartingPlayer",(ctrl,a)=>Pick("starting player",g.Players.ToArray()));
        foreach(string choice in new[]{"chooseColor","chooseColorAllowColorless"})Bind(choice,(ctrl,a)=>{var colors=Items(C(a[2],"getOrderedColors","()Ljava/util/Collection;")).ToList();if(choice=="chooseColorAllowColorless"&&!B(a[2],"isColorless"))colors.Add(g.Enum("forge/card/MagicColor$Color","COLORLESS"));return C(Pick(choice,colors.ToArray()),"getColorMask","()B");});
        Bind("announceRequirements",(ctrl,a)=>{
            string name=g.Rt.StringValue(a[3]);int min=a[1].Int,max=a[2].Int;
            if(name=="Exiled"&&min==0&&(announcedNumber==null||ControllerSeat(ctrl)!=0))return g.Rt.BoxInt(0);
            if(name=="X"){
                var previous=C(a[0],"getXManaCostPaid","()Ljava/lang/Integer;");
                if(previous.Reference!=null){int x=g.Rt.UnboxInt(previous);if(x<min||x>max)throw new HostDecisionGap("Previously chosen X no longer within announcement bounds");return previous;}
                var cost=C(a[0],"getPayCosts","()Lforge/game/cost/Cost;");
                var mana=cost.Reference==null?default:C(cost,"getCostMana","()Lforge/game/cost/CostPartMana;");
                int copies=mana.Reference==null?0:C(mana,"getAmountOfX","()I").Int;
                if(copies>0){
                    int seat=ControllerSeat(ctrl);
                    var estimate=seat==0?availableTableMana:availableBotMana;
                    int available=estimate?.Invoke(a[0])??g.ManaCount(seat);
                    max=Math.Min(max,Math.Max(min,available/copies));
                    var payable=new List<int>();
                    try {
                        for(int x=min;x<=max;x++){
                            C(a[0],"setXManaCostPaid","(Ljava/lang/Integer;)V",g.Rt.BoxInt(x));
                            if(PayMana(C(mana,"getManaCostFor","(Lforge/game/spellability/SpellAbility;)Lforge/card/mana/ManaCost;",a[0]),a[0],seat,default,false,true))payable.Add(x);
                        }
                    }finally{C(a[0],"setXManaCostPaid","(Ljava/lang/Integer;)V",previous);}
                    return payable.Count==0?default:g.Rt.BoxInt(announcedPayableX!=null&&seat==0?announcedPayableX(payable.ToArray()):
                        seat==1&&availableBotMana!=null?payable[payable.Count-1]:tape.Pick("payable announced X",payable.ToArray(),x=>x.ToString()));
                }
            }
            return max<min?default:g.Rt.BoxInt(announcedNumber!=null&&ControllerSeat(ctrl)==0?announcedNumber(name,min,max):tape.ChooseInteger("announce "+name,min,max));
        });
        Bind("chooseSingleCardForZoneChange",(ctrl,a)=>EffectSelection("zone change card",Items(a[3]),1,1,a[6].Int!=0).FirstOrDefault());
        Bind("chooseCardsForZoneChange",(ctrl,a)=>g.Rt.ListOf(EffectSelection("zone change cards",Items(a[3]),a[4].Int,a[5].Int,false)));
        Bind("chooseNumber",(ctrl,a)=>a.Length==4&&a[2].Reference!=null?JValue.I(g.Rt.UnboxInt(Pick("number",Items(a[2])))):JValue.I(a[2].Int+tape.Choose("number",Enumerable.Range(a[2].Int,checked(a[3].Int-a[2].Int+1)).Select(n=>n.ToString()))));
        Bind("tuckCardsViaMulligan",(ctrl,a)=>Cards(Subset("mulligan bottom",Items(a[0]),a[1].Int,a[1].Int)));
        Bind("chooseCardsToDiscardToMaximumHandSize",(ctrl,a)=>Cards(Subset("cleanup discard",Zone(ControllerSeat(ctrl),"Hand"),a[0].Int,a[0].Int)));
        Bind("chooseCardsToDiscardFrom",(ctrl,a)=>Cards(Subset("discard",Items(a[2]),a[3].Int,a[4].Int)));
        Bind("chooseCardsForEffect",(ctrl,a)=>Cards(EffectSelection("effect cards",Items(a[0]),a[3].Int,a[4].Int,a[5].Int!=0)));
        Bind("chooseCardsPile",(ctrl,a)=>JValue.I(tape.Choose("choose pile",["second","first"])));
        Bind("chooseCardsToDiscardUnlessType",(ctrl,a)=>{
            var hand=Items(a[1]);var sa=a[3];
            var matching=Items(S("forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;",
                Cards(hand),a[2],C(sa,"getActivatingPlayer","()Lforge/game/player/Player;"),C(sa,"getHostCard","()Lforge/game/card/Card;"),sa));
            if(matching.Length>0&&a[0].Int>0&&tape.Choose("discard alternative",["ordinary","matching type"])==1)
                return Cards([Pick("matching discard",matching)]);
            int count=Math.Min(hand.Length,a[0].Int);
            return Cards(Subset("discard ordinary",hand,count,count));
        });
        Bind("chooseCardsForEffectMultiple",(ctrl,a)=>{
            var groups=Items(C(a[0],"entrySet","()Ljava/util/Set;"));
            var chosen=new List<JValue>();
            for(int i=0;i<groups.Length;i++){
                var available=Items(C(groups[i],"getValue","()Ljava/lang/Object;")).Where(card=>chosen.All(c=>c.Reference!=card.Reference)).ToArray();
                if(available.Length==0)continue;
                bool required=a[3].Int==0&&chosen.Count==0&&i==groups.Length-1;
                if(required||tape.Choose("take from category",["skip","take"])==1)chosen.Add(Pick("category card",available));
            }
            return Cards(chosen);
        });
        Bind("chooseCardsToRevealFromHand",(ctrl,a)=>Cards(EffectSelection("reveal from hand",Items(a[2]),a[0].Int,a[1].Int,false)));
        Bind("chooseSpellAbilitiesForEffect",(ctrl,a)=>g.Rt.ListOf(EffectSelection("effect spell abilities",Items(a[0]),a[3].Int,a[3].Int,false)));
        Bind("chooseEntitiesForEffect",(ctrl,a)=>g.Rt.ListOf(Subset("effect entities",Items(a[0]),a[1].Int,a[2].Int)));
        Bind("choosePermanentsToSacrifice",(ctrl,a)=>Cards(EffectSelection("sacrifice",Items(a[3]),a[1].Int,a[2].Int,false)));
        Bind("choosePermanentsToDestroy",(ctrl,a)=>Cards(EffectSelection("destroy",Items(a[3]),a[1].Int,a[2].Int,false)));
        Bind("chooseModeForAbility",(ctrl,a)=>ChooseModes(a));
        Bind("choosePlayerToAssistPayment",(ctrl,a)=>Items(a[0]).Where(p=>g.ManaCount(Seat(p))>0)
            .OrderByDescending(p=>g.ManaCount(Seat(p))).FirstOrDefault());
        Bind("helpPayForAssistSpell",(ctrl,a)=>AssistPayment(ControllerSeat(ctrl),a[0],a[1],a[2].Int));
        Bind("chooseOptionalCosts",(ctrl,a)=>g.Rt.ListOf(tape.Pick("affordable optional cost set",OptionalCostOptions(a[0],Items(a[1]),ControllerSeat(ctrl)),set=>set.Length==0?"none":string.Join(" + ",set.Select(Label)))));
        Bind("orderSimultaneousSa",(ctrl,a)=>g.Rt.ListOf(tape.Shuffle("orderSimultaneousSa",Items(a[0]),Label)));
        Bind("orderCosts",(ctrl,a)=>g.Rt.ListOf(input.Version<3?tape.Shuffle("orderCosts",Items(a[0]),Label):Items(a[0]).GroupBy(c=>C(c,"paymentOrder","()I").Int).OrderBy(group=>group.Key).SelectMany(group=>tape.Shuffle("cost order "+group.Key,group,Label))));
        Bind("orderMoveToZoneList",(ctrl,a)=>Cards(tape.Shuffle("zone order",Items(a[0]),Label)));
        Bind("arrangeForScry",(ctrl,a)=>{var top=new List<JValue>();var bottom=new List<JValue>();foreach(var card in tape.Shuffle("scry order",Items(a[0]),Label)){if(tape.Choose("scry destination "+Label(card),["top","bottom"])==0)top.Add(card);else bottom.Add(card);}return S("org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;",Cards(top),Cards(bottom));});
        Bind("orderBlockers",(ctrl,a)=>Cards(tape.Shuffle("blocker order",Items(a[1]),Label)));
        Bind("arrangeForSurveil",(ctrl,a)=>{
            var top=new List<JValue>();var grave=new List<JValue>();
            foreach(var card in tape.Shuffle("surveil order",Items(a[0]),Label))
                (tape.Choose("surveil destination "+Label(card),["top","graveyard"])==0?top:grave).Add(card);
            return S("org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;",Cards(top),Cards(grave));});
        Bind("orderAttackers",(ctrl,a)=>Cards(tape.Shuffle("attacker order",Items(a[1]),Label)));
        Bind("chooseSaToActivateFromOpeningHand",(ctrl,a)=>g.Rt.ListOf(Subset("opening abilities",Items(a[0]),0,Items(a[0]).Length)));
        Bind("orderAndPlaySimultaneousSa",(ctrl,a)=>{foreach(var sa in orderedTriggers!=null?orderedTriggers(ctrl,Items(a[0])):tape.Shuffle("trigger order",Items(a[0]),Label)){
            if(input.Version>=3){if(B(sa,"isTrigger")&&!B(sa,"isCopied")){S("forge/game/player/PlaySpellAbility","playSpellAbility","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Z",ctrl,g.Players[ControllerSeat(ctrl)],sa);continue;}
                if(B(sa,"isCopied")){if(B(sa,"isSpell")){var card=C(sa,"getHostCard","()Lforge/game/card/Card;");if(!g.In(card,"Stack"))C(sa,"setHostCard","(Lforge/game/card/Card;)V",C(g.Action,"moveToStack","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;",card,sa));else C(C(g.Game,"getStackZone","()Lforge/game/zone/Zone;"),"add","(Lforge/game/card/Card;)V",card);}if(B(sa,"isMayChooseNewTargets"))C(sa,"setupNewTargets","(Lforge/game/player/Player;)Z",g.Players[ControllerSeat(ctrl)]);}Enqueue(sa);continue;}
            if(!SelectTargets(sa))throw new HostDecisionGap("Mandatory trigger has no selected legal targets: "+Label(sa));Enqueue(sa);}return default;});
        Bind("playSpellAbilityNoStack",(ctrl,a)=>{if(input.Version>=3){S("forge/game/player/PlaySpellAbility","playSpellAbilityNoStack","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Z)Z",ctrl,g.Players[ControllerSeat(ctrl)],a[0],JValue.I(a[1].Int==0?1:0));return default;}if(a[1].Int!=0&&!SelectTargets(a[0]))throw new HostDecisionGap("No-stack effect targets");S("forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V",a[0]);return default;});
        Bind("playTrigger",(ctrl,a)=>{if(input.Version>=3)return S("forge/game/player/PlaySpellAbility","playSpellAbilityNoStack","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Z)Z",ctrl,g.Players[ControllerSeat(ctrl)],a[1],JValue.I(0));if(!SelectTargets(a[1]))throw new HostDecisionGap("Static trigger targets");C(a[1],"resolve","()V");return JValue.I(1);});
        Bind("playSaFromPlayEffect",(ctrl,a)=>S("forge/game/player/PlaySpellAbility","playSpellAbility","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Z",ctrl,g.Players[ControllerSeat(ctrl)],a[0]));
        Bind("chooseTargetsFor",(ctrl,a)=>JValue.I(SelectTargetsForCast(a[0],ControllerSeat(ctrl))?1:0));
        Bind("chooseNewTargetsFor",(ctrl,a)=>{
            var sa=a[0];var old=C(sa,"getTargets","()Lforge/game/spellability/TargetChoices;");
            if(a[2].Int!=0&&tape.Choose("change targets",["keep","choose"])==0)return default;
            int count=C(old,"size","()I").Int;
            var amounts=Items(C(old,"getDividedValues","()Ljava/util/Collection;")).Select(g.Rt.UnboxInt).ToArray();
            if(SelectTargets(sa,count,a[1],amounts))return C(sa,"getTargets","()Lforge/game/spellability/TargetChoices;");
            C(sa,"setTargets","(Lforge/game/spellability/TargetChoices;)V",old);return default;
        });
        Bind("chooseSpellAbilityToPlay",(ctrl,a)=>ChooseAction(ControllerSeat(ctrl)));
        Bind("playChosenSpellAbility",(ctrl,a)=>JValue.I(Play(a[0],ControllerSeat(ctrl))?1:0));
        Bind("declareAttackers",(ctrl,a)=>{Attack(ControllerSeat(ctrl),a[1]);return default;});
        Bind("declareBlockers",(ctrl,a)=>{Block(ControllerSeat(ctrl),a[1]);return default;});
        Bind("assignCombatDamage",(ctrl,a)=>{
            var recipients=Items(a[1]);if(recipients.Length==0)throw new HostDecisionGap("Combat damage: empty offered recipients");
            // With unordered modern assignment, putting all damage on any offered blocker is legal.
            // Legacy ordered multi-blocker allocation needs its separate legality policy.
            if(a[5].Int==0&&recipients.Length>1)throw new HostDecisionGap("Legacy ordered multiple-blocker damage assignment");
            var target=Pick("combat damage recipient",recipients);return g.Rt.MapOf([new(target,g.Rt.BoxInt(a[3].Int))]);});
        Bind("exertAttackers",(ctrl,a)=>g.Rt.ListOf(Subset("exert",Items(a[0]),0,Items(a[0]).Length)));
        Bind("enlistAttackers",(ctrl,a)=>g.Rt.ListOf(Subset("enlist",Items(a[0]),0,Items(a[0]).Length)));
        Bind("payManaCost",(ctrl,a)=>{
            var source=C(a[2],"getHostCard","()Lforge/game/card/Card;");
            if(C(source,"hasKeyword","(Lforge/game/keyword/Keyword;)Z",g.Enum("forge/game/keyword/Keyword","DELVE")).Int!=0)
            {
                var previous=(delveAbility,assistContribution);delveAbility=a[2];assistContribution=null;
                try {
                    var result=S("forge/game/player/PlaySpellAbility","payManaCost","(Lforge/game/player/PlayerController;Lforge/card/mana/ManaCost;Lforge/game/cost/CostPartMana;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/lang/String;Lforge/game/mana/ManaConversionMatrix;Z)Z",ctrl,a[0],a[1],a[2],g.Players[ControllerSeat(ctrl)],a[3],a[4],a[5]);
                    if(result.Int!=0)CommitAssist(a[2]);
                    return result;
                }
                finally { delvePlans.Remove(AbilityCardId(a[2]));(delveAbility,assistContribution)=previous; }
            }
            return JValue.I(PayMana(a[0],a[2],ControllerSeat(ctrl),a[4],a[5].Int!=0,false)?1:0);});
        Bind("applyManaToCost",(ctrl,a)=>JValue.I(ApplyManaPool(a[0],a[1],ControllerSeat(ctrl),a[3],false,a[4].Int!=0)?1:0));
        Bind("chooseCardsToDelve",(ctrl,a)=>ChooseDelve(a[0].Int,Items(a[1])));
        Bind("getCostDecisionMaker",(ctrl,a)=>CostVisitor(a[0],a[1],a[2].Int!=0));
        Bind("payCostToPreventEffect",(ctrl,a)=>{
            var mana=C(a[0],"getCostMana","()Lforge/game/cost/CostPartMana;");
            if(mana.Reference!=null&&tape.Choose("optional prevention mana cost",["decline","attempt payment"])==0)return JValue.I(0);
            return PayResolvingCost(ctrl,a[0],a[1],default);});
        Bind("payCombatCost",(ctrl,a)=>!CanPayPart(a[1],a[2],g.Players[ControllerSeat(ctrl)],true)||!AcceptOptionalCost("combat cost")?JValue.I(0):PayResolvingCost(ctrl,a[1],a[2],a[3]));
        Bind("chooseCardsForCost",(ctrl,a)=>{
            var legal=Items(a[0]);int count=a[3].Int;
            if(count<0)throw new HostDecisionGap("Negative card cost amount");
            if(legal.Length<count)return default;
            if(a[4].Int!=0&&tape.Choose("optional card cost",["decline","pay"])==0)return default;
            return Cards(Subset("cards for cost",legal,count,count));});
        Bind("chooseCardsForConvokeOrImprovise",(ctrl,a)=>ChooseTapReduction(a,ControllerSeat(ctrl)));
        g.Rt.Bind("forge/StaticData","getMulliganRule","()Lforge/MulliganDefs$MulliganRule;",(r,s,a)=>Done(g.Enum("forge/MulliganDefs$MulliganRule","London")));
    }
    // Effect instructions do as much as possible; unlike costs their minimum is
    // capped by the engine's available legal set. Cancellation is separate.
    private JValue[] EffectSelection(string kind,JValue[] legal,int min,int max,bool optional)
    {
        if(min<0||max<0||min>max)throw new HostDecisionGap(kind+": invalid declared bounds");
        if(legal.Length==0)return [];
        if(optional&&tape.Choose(kind+" optional",["decline","choose"])==0)return [];
        return Subset(kind,legal,Math.Min(min,legal.Length),Math.Min(max,legal.Length));
    }
    private bool SelectTargets(JValue ability)=>SelectTargets(ability,null,default,[]);
    private bool SelectTargets(JValue ability,int? fixedCount,JValue filter,int[] allocations,int? maximumCount=null,
        Func<string,int,int,int>? chooseNumber=null,Func<string,JValue[],JValue>? chooseTarget=null)
    {
        for(var sa=ability;sa.Reference!=null;sa=C(sa,"getSubAbility","()Lforge/game/spellability/AbilitySub;"))
        {
            if(!B(sa,"usesTargeting"))continue;
            C(sa,"clearTargets","()V");
            var restrictions=C(sa,"getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;");
            var candidates=Items(C(restrictions,"getAllCandidates","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",sa)).ToList();
            // Stack targets have a dedicated legality query. GameObject.canTarget
            // alone does not enforce the target-zone restriction for abilities.
            bool stackAllowed=Items(C(restrictions,"getZone","()Ljava/util/List;")).Any(z=>g.Rt.InspectEnumName(z)=="Stack");
            candidates.RemoveAll(c=>g.Rt.IsInstance(c.Reference!,"forge/game/card/Card")&&g.In(c,"Stack"));
            if(stackAllowed)foreach(var instance in Items(g.Stack)){var stacked=C(instance,"getSpellAbility","()Lforge/game/spellability/SpellAbility;");if(C(sa,"canTargetSpellAbility","(Lforge/game/spellability/SpellAbility;)Z",stacked).Int!=0)candidates.Add(stacked);}
            if(filter.Reference!=null)candidates.RemoveAll(c=>C(filter,"test","(Ljava/lang/Object;)Z",c).Int==0);
            int min=C(sa,"getMinTargets","()I").Int,max=Math.Min(C(sa,"getMaxTargets","()I").Int,candidates.Count);
            if(maximumCount.HasValue&&ReferenceEquals(sa.Reference,ability.Reference))max=Math.Min(max,maximumCount.Value);
            bool divide=B(sa,"isDividedAsYouChoose");
            int remaining=divide?C(sa,"getStillToDivide","()I").Int:0;
            if(divide)max=Math.Min(max,TargetCapAfterSacrifices(sa,ability));
            if(divide)max=Math.Min(max,remaining);
            if(max<min)return false;
            var activator=chooseBotTarget==null?default:C(sa,"getActivatingPlayer","()Lforge/game/player/Player;");
            bool botTarget=activator.Reference!=null&&ReferenceEquals(activator.Reference,g.Players[1].Reference);
            int count=fixedCount??(chooseNumber!=null?chooseNumber("选择目标数量",min,max):
                botTarget&&chooseBotTargetCount!=null?chooseBotTargetCount(sa,min,max):
                min+tape.Choose("target count "+Label(sa),Enumerable.Range(min,max-min+1).Select(n=>n.ToString())));
            if(count<min||count>max)return false;
            for(int i=0;i<count;i++)
            {
                var legal=candidates.Where(c=>g.Rt.IsInstance(c.Reference!,"forge/game/spellability/SpellAbility")?stackAllowed&&C(sa,"canTargetSpellAbility","(Lforge/game/spellability/SpellAbility;)Z",c).Int!=0:C(sa,"canTarget","(Lforge/game/GameObject;)Z",c).Int!=0).ToArray();if(legal.Length==0)return false;
                var target=chooseTarget!=null?chooseTarget("选择目标 · "+Label(sa),legal):
                    botTarget?chooseBotTarget!(sa,legal):Pick("target "+Label(sa),legal);
                if(target.Reference==null){
                    for(var started=ability;started.Reference!=null;started=C(started,"getSubAbility","()Lforge/game/spellability/AbilitySub;")){
                        C(started,"clearTargets","()V");
                        if(ReferenceEquals(started.Reference,sa.Reference))break;
                    }
                    return false;
                }
                C(C(sa,"getTargets","()Lforge/game/spellability/TargetChoices;"),"add","(Lforge/game/GameObject;)Z",target);candidates.Remove(target);
                if(divide)
                {
                    int amount=fixedCount.HasValue?allocations[i]:i==count-1?remaining:
                        chooseNumber!=null?chooseNumber("分配给 "+Label(target)+" 的数量",1,remaining-(count-1-i)):tape.ChooseInteger("divided amount",1,remaining-(count-1-i));
                    C(sa,"addDividedAllocation","(Lforge/game/GameObject;Ljava/lang/Integer;)V",target,g.Rt.BoxInt(amount));
                    remaining-=amount;
                }
            }
            if(!B(sa,"isTargetNumberValid"))return false;
            if(fixedCount.HasValue)return true;
        }
        return C(g.Stack,"hasLegalTargeting","(Lforge/game/spellability/SpellAbility;)Z",ability).Int!=0;
    }
    private bool SelectTargetsForCast(JValue ability,int seat)
    {
        if(!SelectTargets(ability))return false;
        if(!B(ability,"isSpell")||!B(ability,"usesTargeting")||B(ability,"isCopied"))return true;
        var card=C(ability,"getHostCard","()Lforge/game/card/Card;");
        bool relativeCost=Items(C(card,"getStaticAbilities","()Lforge/util/collect/FCollectionView;")).Any(effect=>
            C(effect,"checkMode","(Lforge/game/staticability/StaticAbilityMode;)Z",g.Enum("forge/game/staticability/StaticAbilityMode","RaiseCost")).Int!=0&&
            C(effect,"hasParam","(Ljava/lang/String;)Z",g.S("Relative")).Int!=0);
        if(!relativeCost)return true;
        var targets=C(ability,"getTargets","()Lforge/game/spellability/TargetChoices;");
        int maximum=C(targets,"size","()I").Int;
        while(!CanFundVariant(ability,seat)){
            if(--maximum<0||!SelectTargets(ability,null,default,[],maximum))return false;
            maximum=C(C(ability,"getTargets","()Lforge/game/spellability/TargetChoices;"),"size","()I").Int;
        }
        return true;
    }
    // The stack validates a dynamic target maximum again after payment. Reserve
    // room for permanents that can leave as part of the proposed sacrifice.
    private int TargetCapAfterSacrifices(JValue sa,JValue root)
    {
        int cap=C(sa,"getMaxTargets","()I").Int;
        var variable=C(sa,"getParam","(Ljava/lang/String;)Ljava/lang/String;",g.S("TargetMax"));
        if(variable.Reference==null)return cap;
        var formula=C(sa,"getSVar","(Ljava/lang/String;)Ljava/lang/String;",variable);
        if(formula.Reference==null || !g.Rt.StringValue(formula).StartsWith("Count$Valid ",StringComparison.Ordinal))return cap;
        var cost=C(root,"getPayCosts","()Lforge/game/cost/Cost;");
        if(cost.Reference==null)return cap;
        var payer=C(root,"getActivatingPlayer","()Lforge/game/player/Player;");
        var field=C(payer,"getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;",g.Enum("forge/game/zone/ZoneType","Battlefield"));
        foreach(var part in Items(C(cost,"getCostParts","()Ljava/util/List;")))
        {
            if(!g.Rt.IsInstance(part.Reference!,"forge/game/cost/CostSacrifice"))continue;
            var legal=ValidCostCards(part,root,payer,field);
            var counted=ValidCostCards(part,sa,payer,Cards(legal),g.Rt.StringValue(formula)["Count$Valid ".Length..]);
            cap-=Math.Min(counted.Length,C(part,"getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I",root).Int);
        }
        return cap;
    }
    private JValue ChooseAction(int seat)
    {
        delvePlans.Clear();
        if(input.Version>=4&&++priorityDecisions>256)throw new HostDecisionGap("Priority window exceeds 256 legal decisions without yielding priority");
        var legal=new List<JValue>();
        foreach(var _ in CollectActions(seat,true,legal)){}
        return PickPriority(seat,legal);
    }
    private JValue PickPriority(int seat,List<JValue> legal)
    {
        if(input.Version==1){int selected=tape.Choose("priority "+seat,new[]{"pass"}.Concat(legal.Select(Label)));return selected==0?default:g.Rt.ListOf([legal[selected-1]]);}
        bool ownMain=Seat(C(g.Phase,"getPlayerTurn","()Lforge/game/player/Player;"))==seat&&B(C(g.Phase,"getPhase","()Lforge/game/phase/PhaseType;"),"isMain");
        // All offered actions remain eligible. Weighting avoids emptying mana in upkeep
        // on almost every turn while preserving exploration of unusual timing.
        var weighted=Enumerable.Repeat(default(JValue),ownMain?1:24).ToList();
        var labels=Enumerable.Repeat("null",weighted.Count).ToList();
        foreach(var sa in legal){int weight=B(sa,"isManaAbility")?(ownMain?3:1):12;string label=Label(sa);weighted.AddRange(Enumerable.Repeat(sa,weight));labels.AddRange(Enumerable.Repeat(label,weight));}
        var selectedSa=weighted[tape.Choose("weighted priority "+seat,labels)];return selectedSa.Reference==null?default:g.Rt.ListOf([selectedSa]);
    }
    // The game can yield between cards while the same priority window is open.
    // Batch replays drain this iterator synchronously in the same offer order.
    private IEnumerable<int> CollectActions(int seat,bool botPolicy,List<JValue> legal,Func<JValue,bool>? consider=null,
        Func<JValue,bool>? considerBattlefield=null) {
        var hand=Zone(seat,"Hand");
        var battlefield=consider!=null?Zone(seat,"Battlefield"):Items(C(g.Game,"getCardsIn",
            "(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;",g.Enum("forge/game/zone/ZoneType","Battlefield")));
        IEnumerable<JValue> handOrder=consider==null?hand:hand.OrderByDescending(c=>B(c,"isLand"));
        var outside=Items(C(g.Players[seat],"getCardsActivatableInExternalZones","(Z)Lforge/game/card/CardCollectionView;",JValue.I(1)));
        var actionableCards=handOrder.Select(card=>(Card:card,OnBattlefield:false))
            .Concat(battlefield.Select(card=>(Card:card,OnBattlefield:true)))
            .Concat(outside.Select(card=>(Card:card,OnBattlefield:false)));
        var seen=new HashSet<int>();
        foreach(var (card,onBattlefield) in actionableCards){
            if(!seen.Add(C(card,"getId","()I").Int))continue;
            if(onBattlefield&&considerBattlefield!=null&&!considerBattlefield(card)){
                yield return 0;
                continue;
            }
            var abilities=(onBattlefield?quoteOrdinaryLandAbilities?.Invoke(card,seat):null)??
                Items(C(card,"getAllPossibleAbilities","(Lforge/game/player/Player;Z)Ljava/util/List;",g.Players[seat],JValue.I(1)));
            foreach(var sa in abilities){
                if((consider==null||consider(sa))&&(!botPolicy||input.Version<4||ShouldUseUntap(card,sa))&&CanOfferAction(card,sa,seat)&&(!botPolicy||ShouldUseTurnSkipPump(card,sa)))legal.Add(sa);
                yield return 0;
            }
            yield return 0;
        }
    }
    private bool ShouldUseUntap(JValue card,JValue ability)
    {
        if(!IsManaOnlySelfUntap(ability))return true;
        if(!B(card,"isTapped"))return false;
        foreach(var entry in Items(g.Stack)){
            var pending=C(entry,"getSpellAbility","()Lforge/game/spellability/SpellAbility;");
            if(!IsManaOnlySelfUntap(pending))continue;
            var source=C(pending,"getHostCard","()Lforge/game/card/Card;");
            if(C(source,"equalsWithGameTimestamp","(Lforge/game/card/Card;)Z",card).Int!=0)return false;
        }
        return true;
    }
    private bool IsManaOnlySelfUntap(JValue ability)
    {
        if(!B(ability,"isActivatedAbility")||
            g.Rt.InspectEnumName(C(ability,"getApi","()Lforge/game/ability/ApiType;"))!="Untap"||
            B(ability,"usesTargeting")||
            C(ability,"getSubAbility","()Lforge/game/spellability/AbilitySub;").Reference!=null)return false;
        var defined=C(ability,"getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",g.S("Defined"),g.S("Self"));
        if(g.Rt.StringValue(defined)!="Self")return false;
        if(new[]{"UntapUpTo","UntapExactly","Radiance","ETB"}.Any(flag=>
            C(ability,"hasParam","(Ljava/lang/String;)Z",g.S(flag)).Int!=0))return false;
        var cost=C(ability,"getPayCosts","()Lforge/game/cost/Cost;");
        return cost.Reference!=null&&Items(C(cost,"getCostParts","()Ljava/util/List;")).All(part=>
            g.Rt.IsInstance(part.Reference!,"forge/game/cost/CostPartMana"));
    }
    private bool ShouldUseTurnSkipPump(JValue card,JValue sa)
    {
        if(!B(sa,"isActivatedAbility") || g.Rt.InspectEnumName(C(sa,"getApi","()Lforge/game/ability/ApiType;"))!="Pump")return true;
        for(var sub=C(sa,"getSubAbility","()Lforge/game/spellability/AbilitySub;");sub.Reference!=null;sub=C(sub,"getSubAbility","()Lforge/game/spellability/AbilitySub;"))
        {
            if(g.Rt.InspectEnumName(C(sub,"getApi","()Lforge/game/ability/ApiType;"))!="SkipTurn" ||
                g.Rt.StringValue(C(sub,"getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",g.S("Defined"),g.S("")))!="You")continue;
            var combat=C(g.Game,"getCombat","()Lforge/game/combat/Combat;");
            if(combat.Reference==null || g.Rt.InspectEnumName(C(g.Phase,"getPhase","()Lforge/game/phase/PhaseType;"))!="COMBAT_DECLARE_BLOCKERS")return false;
            if(C(combat,"isBlocking","(Lforge/game/card/Card;)Z",card).Int!=0)return true;
            if(C(combat,"isAttacking","(Lforge/game/card/Card;)Z",card).Int==0)return false;
            var defender=C(combat,"getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;",card);
            if(!g.Rt.IsInstance(defender.Reference!,"forge/game/player/Player") || C(combat,"isBlocked","(Lforge/game/card/Card;)Z",card).Int!=0)return false;
            int power=C(card,"getNetPower","()I").Int, life=C(defender,"getLife","()I").Int;
            var bonus=C(sa,"getParam","(Ljava/lang/String;)Ljava/lang/String;",g.S("NumAtt"));
            return bonus.Reference!=null && power<life && power+S("forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I",card,bonus,sa).Int>=life;
        }
        return true;
    }

    private Func<JValue,int,JValue[]?>? quoteOrdinaryLandAbilities;
    private Func<JValue,JValue,int,bool?>? quoteOrdinaryManaOffer;
    private bool CanOfferAction(JValue card,JValue sa,int seat)
    {
        if(!B(sa,"canPlay"))return false;
        if(B(sa,"isLandAbility"))return true;
        if(quoteOrdinaryManaOffer?.Invoke(card,sa,seat) is bool quickOffer)return quickOffer;
        const string state="Lforge/card/CardStateName;";
        var original=C(card,"getCurrentStateName","()"+state);
        var face=C(sa,"getCardStateName","()"+state);
        bool spell=B(sa,"isSpell");
        var castFrom=spell?C(card,"getCastFrom","()Lforge/game/zone/Zone;"):default;
        bool preview=B(sa,"isSpell") && !B(card,"isInPlay") && face.Reference!=null &&
            !ReferenceEquals(face.Reference,original.Reference) && C(card,"hasState","("+state+")Z",face).Int!=0;
        try
        {
            if(preview)C(card,"setState","("+state+"Z)Z",face,JValue.I(0));
            if(spell)C(card,"setCastFrom","(Lforge/game/zone/Zone;)V",C(card,"getZone","()Lforge/game/zone/Zone;"));
            if(!CanChooseModes(sa))return false;
            var cost=C(sa,"getPayCosts","()Lforge/game/cost/Cost;");if(cost.Reference==null)throw new HostDecisionGap("Non-land action with no declared cost: "+Label(sa));
            var adjusted=S("forge/game/cost/CostAdjustment","adjust","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Z)Lforge/game/cost/Cost;",cost,sa,JValue.I(0));
            if(!AnnounceNonManaX(sa,adjusted,seat,out bool announcedX))return false;
            if(C(adjusted,"canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",sa,g.Players[seat],JValue.I(0)).Int==0)return false;
            foreach(var part in Items(C(adjusted,"getCostParts","()Ljava/util/List;")))
                if(g.Rt.IsInstance(part.Reference!,"forge/game/cost/CostChooseColor")&&PayableColorSets(part,sa,g.Players[seat],false).Length==0)return false;
            var mana=C(adjusted,"getCostMana","()Lforge/game/cost/CostPartMana;");
            if(mana.Reference!=null&&(seat==0?payTableMana!=null:payBotMana!=null)&&!announcedX){
                if(!CanFundMana(mana,sa,seat))return false;
            }else if(mana.Reference!=null){if(!announcedX&&C(mana,"getAmountOfX","()I").Int>0){int min=C(mana,"getXMin","()I").Int,max=Math.Max(min,g.ManaCount(seat));int x=min+tape.Choose("X value "+Label(sa),Enumerable.Range(min,max-min+1).Select(n=>n.ToString()));C(sa,"setXManaCostPaid","(Ljava/lang/Integer;)V",g.Rt.BoxInt(x));}
                if(!PayMana(C(mana,"getManaCostFor","(Lforge/game/spellability/SpellAbility;)Lforge/card/mana/ManaCost;",sa),sa,seat,default,false,true))return false;}
            bool deferTargets=seat==0&&targetsAfterAnnouncement?.Invoke(sa)==true;
            if((!deferTargets&&!SelectTargetsForCast(sa,seat))||!B(sa,"isLegalAfterStack")||
                C(sa,"checkRestrictions","(Lforge/game/player/Player;)Z",g.Players[seat]).Int==0)return false;
            if(B(sa,"isActivatedAbility")&&C(sa,"hasParam","(Ljava/lang/String;)Z",g.S("AlternateCost")).Int!=0||
                spell&&Items(C(card,"getKeywords","()Ljava/util/List;")).Any(k=>g.Rt.StringValue(C(k,"getOriginal","()Ljava/lang/String;")).StartsWith("AlternateAdditionalCost:",StringComparison.Ordinal)))
                return Items(S("forge/game/GameActionUtil","getAdditionalCostSpell","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",sa)).Any(v=>CanFundVariant(v,seat));
            return true;
        }
        finally
        {
            if(spell)C(card,"setCastFrom","(Lforge/game/zone/Zone;)V",castFrom);
            if(preview)C(card,"setState","("+state+"Z)Z",original,JValue.I(0));
        }
    }
    private bool CanFundVariant(JValue sa,int seat)
    {
        var cost=C(sa,"getPayCosts","()Lforge/game/cost/Cost;");
        if(cost.Reference==null)return true;
        var adjusted=S("forge/game/cost/CostAdjustment","adjust","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Z)Lforge/game/cost/Cost;",cost,sa,JValue.I(0));
        if(!CanPayPart(adjusted,sa,g.Players[seat],false))return false;
        var mana=C(adjusted,"getCostMana","()Lforge/game/cost/CostPartMana;");
        return CanFundMana(mana,sa,seat);
    }
    private void Enqueue(JValue sa)=>C(g.Stack,"add","(Lforge/game/spellability/SpellAbility;)V",sa);
    // Forge's initial modal filter checks the first target only. Verify each
    // offered mode's entire subability chain using the engine target queries.
    private JValue[] LegalModes(JValue[] offered)=>offered.Where(SelectTargets).ToArray();
    private bool CanChooseModes(JValue sa)
    {
        if(g.Rt.InspectEnumName(C(sa,"getApi","()Lforge/game/ability/ApiType;"))!="Charm")return true;
        var offered=Items(S("forge/game/ability/effects/CharmEffect","makePossibleOptions","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",sa));
        var amount=C(sa,"getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",g.S("MinCharmNum"),C(sa,"getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",g.S("CharmNum"),g.S("1")));
        int min=S("forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I",C(sa,"getHostCard","()Lforge/game/card/Card;"),amount,sa).Int;
        var legal=LegalModes(offered);
        if(legal.Length<min)return false;
        // A payable minimum-sized set suffices for ordinary additive mode costs.
        // Examine larger sets too, since a continuous effect may change their cost.
        if(!HasModeCosts(sa,legal))return true;
        var maximum=C(sa,"getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",g.S("CharmNum"),g.S("1"));
        int max=S("forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I",C(sa,"getHostCard","()Lforge/game/card/Card;"),maximum,sa).Int;
        return AffordableModes(sa,legal,min,max).Any();
    }
    private bool Play(JValue sa,int seat)
    {
        if(input.Version>=3)
        {
            // Use the ported engine's complete casting transaction: optional costs,
            // modes, stack-zone movement, announcements, targeting, payment and rollback.
            var controller=C(g.Players[seat],"getController","()Lforge/game/player/PlayerController;");
            castingCheckpoints.Clear();recordingCast=true;
            bool accepted;
            try { accepted=S("forge/game/player/PlaySpellAbility","playSpellAbility","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Z",controller,g.Players[seat],sa).Int!=0; }
            finally { recordingCast=false; }
            if(!accepted)throw new HostDecisionGap("Chosen action was rejected by full casting transaction: "+Label(sa)+"; checkpoints: "+string.Join("; ",castingCheckpoints));
            if(input.Version>=4)Snapshot("after engine accepted action");
            return true;
        }
        if(!B(sa,"canPlay")||C(g.Stack,"hasLegalTargeting","(Lforge/game/spellability/SpellAbility;)Z",sa).Int==0)throw new InvalidOperationException("Selected action is no longer legal");
        if(B(sa,"isLandAbility")){C(sa,"resolve","()V");return true;}
        var cost=C(sa,"getPayCosts","()Lforge/game/cost/Cost;");var payment=g.New("forge/game/cost/CostPayment","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;)V",cost,sa);
        if(C(payment,"payCost","(Lforge/game/cost/CostDecisionMakerBase;)Z",CostVisitor(g.Players[seat],sa,false)).Int==0)throw new InvalidOperationException("Legal action payment unexpectedly failed");
        if(!B(payment,"isFullyPaid"))throw new InvalidOperationException("Payment returned success but not all cost parts were recorded as paid");
        if(B(sa,"isManaAbility")){C(g.Stack,"add","(Lforge/game/spellability/SpellAbility;)V",sa);return true;}
        if(B(sa,"isSpell")){var card=C(sa,"getHostCard","()Lforge/game/card/Card;");C(card,"setCastSA","(Lforge/game/spellability/SpellAbility;)V",sa);var moved=C(g.Action,"moveToStack","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;",card,sa);C(sa,"setHostCard","(Lforge/game/card/Card;)V",moved);}
        Enqueue(sa);return true;
    }
    private bool costVisitorInstalled;
    private JValue CostVisitor(JValue player,JValue ability,bool effect)
    {
        const string type="headless/CostDecisions";
        if(!g.Rt.Program.Classes.ContainsKey(type))g.Rt.Program.Add(new(type,"forge/game/cost/CostDecisionMakerBase",["forge/game/cost/ICostVisitor"],1));
        if(!costVisitorInstalled)
        {
            g.Rt.Bind(type,"paysRightAfterDecision","()Z",(r,s,a)=>JHostResult.Complete(JValue.I(1)));
            foreach(var method in g.Rt.Program.Classes["forge/game/cost/ICostVisitor"].Methods.Values.Where(m=>m.Name=="visit"))
            {
                if(new[]{"CostDraw","CostDamage","CostEnlist","CostMill","CostTapType","CostPutCounter","CostPayEnergy","CostPayLife","CostRemoveCounter","CostDiscard","CostSacrifice","CostReturn","CostExile","CostUnattach","CostChooseColor","CostExert","CostRemoveAnyCounter","CostReveal"}.Any(part=>method.Descriptor=="(Lforge/game/cost/"+part+";)Ljava/lang/Object;"))continue;
                if(new[]{"CostBehold","CostBeholdExile","CostPutCardToLib"}.Any(part=>method.Descriptor=="(Lforge/game/cost/"+part+";)Ljava/lang/Object;"))continue;
                if(method.Descriptor=="(Lforge/game/cost/CostRevealChosen;)Ljava/lang/Object;"){
                    g.Rt.Bind(type,"visit",method.Descriptor,(r,s,a)=>JHostResult.Complete(S("forge/game/cost/PaymentDecision","number","(I)Lforge/game/cost/PaymentDecision;",JValue.I(1))));
                    continue;
                }
                bool implemented=new[]{"CostTap","CostUntap","CostPartMana"}.Any(part=>method.Descriptor=="(Lforge/game/cost/"+part+";)Ljava/lang/Object;");
                g.Rt.Bind(type,"visit",method.Descriptor,(r,s,a)=>implemented?JHostResult.Complete(S("forge/game/cost/PaymentDecision","number","(I)Lforge/game/cost/PaymentDecision;",JValue.I(0))):throw new HostDecisionGap(method.Key));
            }
            g.Rt.Bind(type,"visit","(Lforge/game/cost/CostRemoveCounter;)Ljava/lang/Object;",(r,s,a)=>JHostResult.Complete(RemoveCounterDecision(a[0],r.GetField(s,"forge/game/cost/CostDecisionMakerBase","ability","Lforge/game/spellability/SpellAbility;"),r.GetField(s,"forge/game/cost/CostDecisionMakerBase","player","Lforge/game/player/Player;"))));
            foreach(string part in new[]{"CostChooseColor","CostExert","CostRemoveAnyCounter","CostReveal","CostBehold","CostBeholdExile","CostPutCardToLib"})
                g.Rt.Bind(type,"visit","(Lforge/game/cost/"+part+";)Ljava/lang/Object;",(r,s,a)=>JHostResult.Complete(
                    AdditionalCostDecision(part,a[0],r.GetField(s,"forge/game/cost/CostDecisionMakerBase","ability","Lforge/game/spellability/SpellAbility;"),r.GetField(s,"forge/game/cost/CostDecisionMakerBase","player","Lforge/game/player/Player;"),B(s,"isEffect"))));
            g.Rt.Bind(type,"visit","(Lforge/game/cost/CostMill;)Ljava/lang/Object;",(r,s,a)=>JHostResult.Complete(MillDecision(a[0],r.GetField(s,"forge/game/cost/CostDecisionMakerBase","ability","Lforge/game/spellability/SpellAbility;"),r.GetField(s,"forge/game/cost/CostDecisionMakerBase","player","Lforge/game/player/Player;"),B(s,"isEffect"))));
            g.Rt.Bind(type,"visit","(Lforge/game/cost/CostDraw;)Ljava/lang/Object;",(r,s,a)=>JHostResult.Complete(DrawCostDecision(a[0],r.GetField(s,"forge/game/cost/CostDecisionMakerBase","ability","Lforge/game/spellability/SpellAbility;"),r.GetField(s,"forge/game/cost/CostDecisionMakerBase","player","Lforge/game/player/Player;"),B(s,"isEffect"))));
            g.Rt.Bind(type,"visit","(Lforge/game/cost/CostEnlist;)Ljava/lang/Object;",(r,s,a)=>JHostResult.Complete(EnlistDecision(r.GetField(s,"forge/game/cost/CostDecisionMakerBase","player","Lforge/game/player/Player;"))));
            g.Rt.Bind(type,"visit","(Lforge/game/cost/CostPutCounter;)Ljava/lang/Object;",(r,s,a)=>JHostResult.Complete(PutCounterDecision(a[0],r.GetField(s,"forge/game/cost/CostDecisionMakerBase","ability","Lforge/game/spellability/SpellAbility;"),r.GetField(s,"forge/game/cost/CostDecisionMakerBase","player","Lforge/game/player/Player;"),B(s,"isEffect"))));
            g.Rt.Bind(type,"visit","(Lforge/game/cost/CostTapType;)Ljava/lang/Object;",(r,s,a)=>JHostResult.Complete(TapTypeDecision(a[0],r.GetField(s,"forge/game/cost/CostDecisionMakerBase","ability","Lforge/game/spellability/SpellAbility;"),r.GetField(s,"forge/game/cost/CostDecisionMakerBase","player","Lforge/game/player/Player;"),B(s,"isEffect"))));
            g.Rt.Bind(type,"visit","(Lforge/game/cost/CostPayEnergy;)Ljava/lang/Object;",(r,s,a)=>{
                var ability=r.GetField(s,"forge/game/cost/CostDecisionMakerBase","ability","Lforge/game/spellability/SpellAbility;");
                var payer=r.GetField(s,"forge/game/cost/CostDecisionMakerBase","player","Lforge/game/player/Player;");
                if(!CanPayPart(a[0],ability,payer,B(s,"isEffect")))return JHostResult.Complete();
                var amount=C(a[0],"getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I",ability);
                return JHostResult.Complete(S("forge/game/cost/PaymentDecision","number","(I)Lforge/game/cost/PaymentDecision;",amount));});
            g.Rt.Bind(type,"visit","(Lforge/game/cost/CostDamage;)Ljava/lang/Object;",(r,s,a)=>{
                var ability=r.GetField(s,"forge/game/cost/CostDecisionMakerBase","ability","Lforge/game/spellability/SpellAbility;");
                var payer=r.GetField(s,"forge/game/cost/CostDecisionMakerBase","player","Lforge/game/player/Player;");
                var amount=C(a[0],"getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I",ability);
                if(B(s,"isEffect")){
                    var controller=C(payer,"getController","()Lforge/game/player/PlayerController;");
                    if(C(controller,"confirmPayment","(Lforge/game/cost/CostPart;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z",
                        a[0],g.S($"Take {amount.Int} damage"),ability).Int==0)return JHostResult.Complete();
                }
                return JHostResult.Complete(S("forge/game/cost/PaymentDecision","number","(I)Lforge/game/cost/PaymentDecision;",amount));
            });
            g.Rt.Bind(type,"visit","(Lforge/game/cost/CostPayLife;)Ljava/lang/Object;",(r,s,a)=>{
                var ability=r.GetField(s,"forge/game/cost/CostDecisionMakerBase","ability","Lforge/game/spellability/SpellAbility;");
                var player=r.GetField(s,"forge/game/cost/CostDecisionMakerBase","player","Lforge/game/player/Player;");
                if(C(a[0],"canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",ability,player,JValue.I(B(s,"isEffect")?1:0)).Int==0)return JHostResult.Complete();
                if(B(s,"isEffect")&&!(acceptLifePayment?.Invoke(a[0],ability,player)??(tape.Choose("optional life cost",["decline","pay"])!=0)))return JHostResult.Complete();
                return JHostResult.Complete(S("forge/game/cost/PaymentDecision","number","(I)Lforge/game/cost/PaymentDecision;",C(a[0],"getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I",ability)));});
            g.Rt.Bind(type,"visit","(Lforge/game/cost/CostExile;)Ljava/lang/Object;",(r,s,a)=>JHostResult.Complete(ExileCostDecision(a[0],r.GetField(s,"forge/game/cost/CostDecisionMakerBase","ability","Lforge/game/spellability/SpellAbility;"),r.GetField(s,"forge/game/cost/CostDecisionMakerBase","player","Lforge/game/player/Player;"),B(s,"isEffect"))));
            g.Rt.Bind(type,"visit","(Lforge/game/cost/CostUnattach;)Ljava/lang/Object;",(r,s,a)=>{
                var sa=r.GetField(s,"forge/game/cost/CostDecisionMakerBase","ability","Lforge/game/spellability/SpellAbility;");
                var player=r.GetField(s,"forge/game/cost/CostDecisionMakerBase","player","Lforge/game/player/Player;");
                var legal=Items(C(a[0],"findCardToUnattach","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;",C(sa,"getHostCard","()Lforge/game/card/Card;"),player,sa));
                return JHostResult.Complete(legal.Length==0?default:S("forge/game/cost/PaymentDecision","card","(Ljava/lang/Iterable;)Lforge/game/cost/PaymentDecision;",Cards([Pick("unattach cost",legal)])));
            });
            foreach(string part in new[]{"CostDiscard","CostSacrifice"})g.Rt.Bind(type,"visit","(Lforge/game/cost/"+part+";)Ljava/lang/Object;",(r,s,a)=>JHostResult.Complete(ZoneCostDecision(a[0],r.GetField(s,"forge/game/cost/CostDecisionMakerBase","ability","Lforge/game/spellability/SpellAbility;"),r.GetField(s,"forge/game/cost/CostDecisionMakerBase","player","Lforge/game/player/Player;"),B(s,"isEffect"),part=="CostSacrifice")));
            g.Rt.Bind(type,"visit","(Lforge/game/cost/CostReturn;)Ljava/lang/Object;",(r,s,a)=>JHostResult.Complete(ReturnCostDecision(a[0],r.GetField(s,"forge/game/cost/CostDecisionMakerBase","ability","Lforge/game/spellability/SpellAbility;"),r.GetField(s,"forge/game/cost/CostDecisionMakerBase","player","Lforge/game/player/Player;"),B(s,"isEffect"))));
            costVisitorInstalled=true;
        }
        var obj=JValue.R(g.Rt.Allocate(type));g.Rt.InvokeSynchronous("forge/game/cost/CostDecisionMakerBase","<init>","(Lforge/game/player/Player;ZLforge/game/spellability/SpellAbility;Lforge/game/card/Card;)V",obj,[player,JValue.I(effect?1:0),ability,C(ability,"getHostCard","()Lforge/game/card/Card;")],"invokespecial");return obj;
    }
    private JValue[] ValidCostCards(JValue cost,JValue sa,JValue player,JValue cards,string? restriction=null)
    {
        var type=restriction==null?C(cost,"getType","()Ljava/lang/String;"):g.S(restriction);
        return Items(S("forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;",cards,C(type,"split","(Ljava/lang/String;)[Ljava/lang/String;",g.S(";")),player,C(sa,"getHostCard","()Lforge/game/card/Card;"),sa));
    }
    private bool CanPayPart(JValue cost,JValue sa,JValue player,bool effect)=>C(cost,"canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",sa,player,JValue.I(effect?1:0)).Int!=0;
    private bool AcceptOptionalCost(string kind)=>tape.Choose(kind,["decline","pay"])!=0;
    private JValue PayResolvingCost(JValue ctrl,JValue cost,JValue sa,JValue prompt)=>S("forge/game/player/PlaySpellAbility","payCostDuringAbilityResolve","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Z",ctrl,g.Players[ControllerSeat(ctrl)],cost,sa,prompt);
    private JValue EnlistDecision(JValue player)
    {
        var legal=Items(S("forge/game/cost/CostEnlist","getCardsForEnlisting","(Lforge/game/player/Player;)Lforge/game/card/CardCollection;",player));
        if(legal.Length==0||!AcceptOptionalCost("enlist cost"))return default;
        return S("forge/game/cost/PaymentDecision","card","(Ljava/lang/Iterable;)Lforge/game/cost/PaymentDecision;",Cards([Pick("enlist creature",legal)]));
    }
    private JValue MillDecision(JValue cost,JValue sa,JValue player,bool effect)
    {
        if(!CanPayPart(cost,sa,player,effect)||(effect&&!AcceptOptionalCost("optional mill cost")))return default;
        return S("forge/game/cost/PaymentDecision","number","(I)Lforge/game/cost/PaymentDecision;",C(cost,"getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I",sa));
    }
    private JValue ChooseLegalCardName(JValue[] a,int seat)
    {
        if(a.Length==3){var faces=Items(a[1]);return faces.Length==0?g.S(""):C(Pick("card face name",faces),"getName","()Ljava/lang/String;");}
        if(tape.Choose("name card",["cancel","choose"])==0)return g.S("");
        var source=C(a[0],"getHostCard","()Lforge/game/card/Card;");var controller=C(source,"getController","()Lforge/game/player/Player;");
        var validity=C(a[2],"split","(Ljava/lang/String;)[Ljava/lang/String;",g.S(","));
        var definitions=catalogue.CardNames.OrderBy(name=>name,StringComparer.Ordinal).ToArray();
        JValue[] Legal(string name)
        {
            var paper=g.Paper(name);var rules=C(paper,"getRules","()Lforge/card/CardRules;");var results=new List<JValue>();
            foreach(var face in Items(C(rules,"getAllFaces","()Ljava/util/List;")))
            {
                if(C(a[1],"test","(Ljava/lang/Object;)Z",face).Int==0)continue;
                var faceName=C(face,"getName","()Ljava/lang/String;");
                var card=S("forge/game/card/Card","fromPaperCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;)Lforge/game/card/Card;",paper,g.Players[seat]);
                S("forge/game/card/CardUtil","turnToRightFace","(Ljava/lang/String;Lforge/game/card/Card;)V",faceName,card);
                if(C(card,"isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z",validity,controller,source,a[0]).Int!=0)results.Add(faceName);
            }
            return results.ToArray();
        }
        // Prefer names visible in the current game, but validate them with both
        // engine predicates. If none qualify, search the complete pinned catalogue.
        var visible=Items(C(g.Game,"getCardsInGame","()Lforge/game/card/CardCollectionView;")).Select(c=>g.Rt.StringValue(C(c,"getName","()Ljava/lang/String;"))).Distinct().Where(catalogue.ContainsCard);
        var legal=visible.SelectMany(Legal).ToArray();
        if(legal.Length>0)return tape.Pick("legal card name",legal,g.Rt.StringValue);
        int start=tape.ChooseInteger("name catalogue start",0,definitions.Length-1);
        for(int n=0;n<definitions.Length;n++){legal=Legal(definitions[(start+n)%definitions.Length]);if(legal.Length>0)return tape.Pick("legal card name",legal,g.Rt.StringValue);}
        return g.S("");
    }
    private int ChooseKeywordCount(JValue sa,JValue extra,int max,int seat)
    {
        var legal=new List<int>{0};
        // Exploration budget, not a rules limit: every proposed count must pass
        // the engine's combined-cost checks, including the original spell cost.
        for(int count=1;count<=Math.Min(max,16);count++)
        {
            var copy=C(sa,"copy","()Lforge/game/spellability/SpellAbility;");var cost=C(C(sa,"getPayCosts","()Lforge/game/cost/Cost;"),"copy","()Lforge/game/cost/Cost;");
            for(int i=0;i<count;i++)C(cost,"add","(Lforge/game/cost/Cost;)Lforge/game/cost/Cost;",extra);
            C(copy,"setPayCosts","(Lforge/game/cost/Cost;)V",cost);
            var adjusted=S("forge/game/cost/CostAdjustment","adjust","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Z)Lforge/game/cost/Cost;",cost,copy,JValue.I(0));
            if(C(adjusted,"canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",copy,g.Players[seat],JValue.I(0)).Int==0)continue;
            var mana=C(adjusted,"getCostMana","()Lforge/game/cost/CostPartMana;");
            if(mana.Reference==null||PayMana(C(mana,"getManaCostFor","(Lforge/game/spellability/SpellAbility;)Lforge/card/mana/ManaCost;",copy),copy,seat,default,false,true))legal.Add(count);
        }
        return tape.Pick("affordable keyword count",legal.ToArray(),n=>n.ToString());
    }
    private JValue[] OfferedColors(JValue options)=>Items(C(options,"getOrderedColors","()Ljava/util/Collection;")).Where(c=>g.Rt.InspectEnumName(c)!="COLORLESS").ToArray();
    private JValue ChooseColorSet(JValue options,int min,int max)
    {
        var selected=EffectSelection("colors",OfferedColors(options),min,max,false);int mask=0;
        foreach(var color in selected)mask|=C(color,"getColorMask","()B").Int;
        return S("forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;",JValue.I(mask));
    }
    private JValue ChooseManaCombo(JValue options,int amount,bool different)
    {
        var legal=OfferedColors(options).ToList();var counts=new Dictionary<int,int>();
        if(amount<0||amount>0&&legal.Count==0||different&&amount>legal.Count)throw new HostDecisionGap("Mana combination has no legal allocation");
        for(int n=0;n<amount;n++){var color=Pick("mana combination color",legal.ToArray());int mask=C(color,"getColorMask","()B").Int;counts[mask]=counts.GetValueOrDefault(mask)+1;if(different)legal.Remove(color);}
        return g.Rt.MapOf(counts.Select(p=>new KeyValuePair<JValue,JValue>(S("java/lang/Byte","valueOf","(B)Ljava/lang/Byte;",JValue.I(p.Key)),g.Rt.BoxInt(p.Value))));
    }
    private JValue PutCounterDecision(JValue cost,JValue sa,JValue player,bool effect)
    {
        if(C(cost,"canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",sa,player,JValue.I(effect?1:0)).Int==0)return default;
        var source=C(sa,"getHostCard","()Lforge/game/card/Card;");
        if(B(cost,"payCostFromSource"))
        {
            if(effect&&C(sa,"hasParam","(Ljava/lang/String;)Z",g.S("UnlessCost")).Int!=0&&tape.Choose("optional counter cost",["decline","pay"])==0)return default;
            return S("forge/game/cost/PaymentDecision","card","(Lforge/game/card/Card;)Lforge/game/cost/PaymentDecision;",source);
        }
        var counter=C(cost,"getCounter","()Lforge/game/card/CounterType;");
        var legal=ValidCostCards(cost,sa,player,C(g.Game,"getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;",g.Enum("forge/game/zone/ZoneType","Battlefield"))).Where(c=>C(c,"canReceiveCounters","(Lforge/game/card/CounterType;)Z",counter).Int!=0).ToArray();
        if(legal.Length==0)return default;
        return S("forge/game/cost/PaymentDecision","card","(Lforge/game/card/Card;)Lforge/game/cost/PaymentDecision;",Pick("counter cost source",legal));
    }
    private Func<JValue,JValue>? plannedManaTapPartner {get;set;}
    private JValue[] TapCostCandidates(JValue cost,JValue sa,JValue player,JValue source,string type)
    {
        var field=C(player,"getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;",g.Enum("forge/game/zone/ZoneType","Battlefield"));
        bool allowSource=g.Rt.GetField(cost,"forge/game/cost/CostTapType","canTapSource","Z").Int!=0;
        string permission=B(sa,"isCrew")?"canCrew":"canTap";
        return ValidCostCards(cost,sa,player,field,type).Where(c=>(allowSource||!ReferenceEquals(c.Reference,source.Reference))&&B(c,permission)).ToArray();
    }
    private JValue TapTypeDecision(JValue cost,JValue sa,JValue player,bool effect)
    {
        if(C(cost,"canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",sa,player,JValue.I(effect?1:0)).Int==0)return default;
        string type=g.Rt.StringValue(C(cost,"getType","()Ljava/lang/String;"));var source=C(sa,"getHostCard","()Lforge/game/card/Card;");
        if(type=="OriginalHost")return S("forge/game/cost/PaymentDecision","card","(Lforge/game/card/Card;)Lforge/game/cost/PaymentDecision;",C(sa,"getOriginalHost","()Lforge/game/card/Card;"));
        bool shared=type.Contains(".sharesCreatureTypeWith");type=type.Replace(".sharesCreatureTypeWith","");
        int power=-1,at=type.IndexOf("+withTotalPowerGE",StringComparison.Ordinal);
        if(at>=0){power=int.Parse(type[(at+"+withTotalPowerGE".Length)..]);type=type[..at];}
        var legal=TapCostCandidates(cost,sa,player,source,type);
        int amount=g.Rt.StringValue(C(cost,"getAmount","()Ljava/lang/String;"))=="Any"?0:C(cost,"getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I",sa).Int;
        if(!shared&&power<0&&amount>0&&HasCostInput(player)){
            var planned=plannedManaTapPartner?.Invoke(sa)??default;
            JValue[] paid;
            if(planned.Reference!=null){
                if(amount!=1||!legal.Any(c=>ReferenceEquals(c.Reference,planned.Reference)))return default;
                paid=[planned];
            }else{
                if(legal.Length<amount)return default;
                paid=SelectForCost("tap cost","选择要横置的永久物",player,legal,amount);
            }
            return S("forge/game/cost/PaymentDecision","card","(Ljava/lang/Iterable;)Lforge/game/cost/PaymentDecision;",Cards(paid));
        }
        var order=tape.Shuffle("tap cost candidates",legal,Label);var candidates=new List<JValue[]>();
        if(power>=0){for(int n=0;n<=order.Length;n++){var set=order.Take(n).ToArray();if(S("forge/game/card/CardLists","getTotalPower","(Ljava/lang/Iterable;Lforge/game/CardTraitBase;)I",Cards(set),sa).Int>=power)candidates.Add(set);}}
        else if(shared){foreach(var anchor in order){var group=order.Where(c=>ReferenceEquals(c.Reference,anchor.Reference)||C(c,"sharesCreatureTypeWith","(Lforge/game/card/Card;)Z",anchor).Int!=0).ToArray();if(group.Length>=amount){var set=group.Take(amount).ToArray();if(set.All(c=>set.All(other=>ReferenceEquals(c.Reference,other.Reference)||C(c,"sharesCreatureTypeWith","(Lforge/game/card/Card;)Z",other).Int!=0)))candidates.Add(set);}}}
        else if(order.Length>=amount)candidates.Add(order.Take(amount).ToArray());
        if(candidates.Count==0)return default;
        var chosen=tape.Pick("tap cost set",candidates.ToArray(),set=>string.Join(";",set.Select(Label)));
        return S("forge/game/cost/PaymentDecision","card","(Ljava/lang/Iterable;)Lforge/game/cost/PaymentDecision;",Cards(chosen));
    }
    private bool PayMana(JValue mana,JValue sa,int seat,JValue matrix,bool effect,bool test)
    {
        var previous=(delveAbility,probingDelve,proposedDelve,assistContribution);delveAbility=sa;probingDelve=test;proposedDelve=null;assistContribution=null;
        try {
        var due=g.New("forge/game/mana/ManaCostBeingPaid","(Lforge/card/mana/ManaCost;)V",mana);int xCount=C(mana,"countX","()I").Int;
        if(xCount>0){
            var x=C(sa,"getXManaCostPaid","()Ljava/lang/Integer;");
            if(x.Reference==null)throw new HostDecisionGap("Unannounced X mana cost");
            var source=C(sa,"getHostCard","()Lforge/game/card/Card;");
            var color=C(sa,"getXColor","()Ljava/lang/String;");
            if(C(source,"hasKeyword","(Ljava/lang/String;)Z",g.S("Spend only colored mana on X. No more than one mana of each color may be spent this way.")).Int!=0)
                color=g.S("WUBRGX");
            C(due,"setXManaCostPaid","(ILjava/lang/String;)V",JValue.I(g.Rt.UnboxInt(x)),color);
        }
        var delved=Cards([]);if(S("forge/game/cost/CostAdjustment","adjust","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Lforge/game/card/CardCollection;ZZ)Z",due,sa,g.Players[seat],delved,JValue.I(test?1:0),JValue.I(effect?1:0)).Int==0)return false;
        if(Items(delved).Length!=0&&!test)throw new HostDecisionGap("Delve payment must use engine casting transaction");
        bool paid=ApplyManaPool(due,sa,seat,matrix,test,effect);
        if(paid&&!test){
            if(xCount>0)C(C(sa,"getHostCard","()Lforge/game/card/Card;"),"setXManaCostPaidByColor","(Ljava/util/Map;)V",
                C(due,"getXManaCostPaidByColor","()Ljava/util/Map;"));
            CommitAssist(sa);
        }
        if(test&&proposedDelve!=null){if(paid)delvePlans[AbilityCardId(sa)]=proposedDelve;else delvePlans.Remove(AbilityCardId(sa));}
        return paid;
        } finally { (delveAbility,probingDelve,proposedDelve,assistContribution)=previous; }
    }
    private int AbilityCardId(JValue sa)=>C(C(sa,"getHostCard","()Lforge/game/card/Card;"),"getId","()I").Int;
    private JValue ChooseDelve(int maximum,JValue[] legal)
    {
        if(!probingDelve&&delveAbility.Reference!=null&&delvePlans.TryGetValue(AbilityCardId(delveAbility),out var plan))
        {
            if(plan.Length>maximum||plan.Any(c=>!legal.Any(v=>ReferenceEquals(v.Reference,c.Reference))))throw new HostDecisionGap("Previously payable delve plan is no longer legal");
            return Cards(plan);
        }
        var selected=Subset("delve",legal,0,Math.Max(0,Math.Min(maximum,legal.Length)));
        if(probingDelve)proposedDelve=selected;
        return Cards(selected);
    }
    private Func<JValue,JValue,JValue,bool,bool,bool>? payTableMana {get;set;}
    private Func<JValue,int>? availableTableMana {get;set;}
    private bool ApplyManaPool(JValue due,JValue sa,int seat,JValue matrix,bool test,bool effect)
    {
        var pay=seat==0?payTableMana:payBotMana;
        if(pay!=null)return pay(due,sa,matrix,test,effect);
        var pool=g.ManaPool(seat);if(matrix.Reference!=null)C(pool,"applyCardMatrix","(Lforge/game/mana/ManaConversionMatrix;)V",matrix);
        var spent=g.Rt.ListOf([]);bool paid=C(pool,"payManaCostFromPool","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;ZLjava/util/List;)Z",due,sa,JValue.I(test?1:0),spent).Int!=0;
        if(recordingCast)castingCheckpoints.Add("mana pool affordability="+paid+", test="+test);
        if(!paid)C(pool,"refundMana","(Ljava/util/List;)V",spent);
        if(paid&&!test){C(C(sa,"getPayingMana","()Ljava/util/List;"),"addAll","(Ljava/util/Collection;)Z",spent);C(sa,"setManaCostBeingPaid","(Lforge/game/mana/ManaCostBeingPaid;)V",due);}
        return paid;
    }
    private void Attack(int seat,JValue combat)
    {
        var creatures=Zone(seat,"Battlefield").Where(c=>B(c,"isCreature")).ToArray();var defenders=Items(C(combat,"getDefenders","()Lforge/util/collect/FCollectionView;"));
        var opposingCreatures=Zone(1-seat,"Battlefield").Where(c=>B(c,"isCreature")).ToArray();
        for(int retry=0;retry<64;retry++)
        {
            C(combat,"clearAttackers","()V");foreach(var card in tape.Shuffle("attack order",creatures,Label))
            {
                var choices=defenders.Where(d=>S("forge/game/combat/CombatUtil","canAttack","(Lforge/game/card/Card;Lforge/game/GameEntity;)Z",card,d).Int!=0).ToArray();
                int opponent=Array.FindIndex(choices,d=>ReferenceEquals(d.Reference,g.Players[1-seat].Reference));
                int? preferred=null;
                if(input.Version>=4 && retry==0 && opponent>=0 && C(card,"getNetPower","()I").Int>0 &&
                    !opposingCreatures.Any(blocker=>S("forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;)Z",card,blocker).Int!=0) &&
                    S("forge/game/combat/CombatUtil","getAttackCost","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/GameEntity;)Lforge/game/cost/Cost;",g.Game,card,choices[opponent]).Reference==null)
                    preferred=opponent+1;
                int n=tape.Choose("attack "+Label(card),new[]{"do not attack"}.Concat(choices.Select(Label)),preferred);
                if(n>0)C(combat,"addAttacker","(Lforge/game/card/Card;Lforge/game/GameEntity;)V",card,choices[n-1]);
            }
            if(S("forge/game/combat/CombatUtil","validateAttackers","(Lforge/game/combat/Combat;)Z",combat).Int!=0)return;
        }
        throw new HostDecisionGap("No globally legal attack proposal after 64 attempts");
    }
    private void Block(int seat,JValue combat)
    {
        var creatures=Zone(seat,"Battlefield").Where(c=>B(c,"isCreature")).ToArray();var attackers=Items(C(combat,"getAttackers","()Lforge/game/card/CardCollection;"));
        for(int retry=0;retry<64;retry++)
        {
            foreach(var card in creatures)C(combat,"removeFromCombat","(Lforge/game/card/Card;)V",card);
            foreach(var card in tape.Shuffle("block order",creatures,Label))
            {var choices=attackers.Where(a=>S("forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/combat/Combat;)Z",a,card,combat).Int!=0).ToArray();int n=tape.Choose("block "+Label(card),new[]{"do not block"}.Concat(choices.Select(Label)));if(n>0)C(combat,"addBlocker","(Lforge/game/card/Card;Lforge/game/card/Card;)V",choices[n-1],card);}
            if(S("forge/game/combat/CombatUtil","validateBlocks","(Lforge/game/combat/Combat;Lforge/game/player/Player;)Ljava/lang/String;",combat,g.Players[seat]).Reference==null)return;
        }
        throw new HostDecisionGap("No globally legal block proposal after 64 attempts");
    }
}





using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;


public sealed partial class HeadlessMatch
{
    private JValue DrawCostDecision(JValue cost,JValue ability,JValue payer,bool effect)
    {
        var players=C(cost,"getPotentialPlayers","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;",payer,ability);
        if(Items(players).Length==0 || (effect&&!AcceptOptionalCost("optional draw cost")))return default;
        var decision=S("forge/game/cost/PaymentDecision","players","(Ljava/util/List;)Lforge/game/cost/PaymentDecision;",players);
        g.Rt.PutField(decision,"forge/game/cost/PaymentDecision","c","I",C(cost,"getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I",ability));
        return decision;
    }

    private JValue ReturnCostDecision(JValue cost,JValue ability,JValue payer,bool effect)
    {
        if(!CanPayPart(cost,ability,payer,effect))return default;
        var battlefield=C(payer,"getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;",g.Enum("forge/game/zone/ZoneType","Battlefield"));
        JValue[] selected;
        if(B(cost,"payCostFromSource"))
        {
            var source=C(ability,"getHostCard","()Lforge/game/card/Card;");
            if(!Items(battlefield).Any(card=>ReferenceEquals(card.Reference,source.Reference)))return default;
            selected=[source];
        }
        else
        {
            var legal=ValidCostCards(cost,ability,payer,battlefield);
            int count=C(cost,"getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I",ability).Int;
            selected=SelectForCost("return cost","选择要移回手牌的永久物",payer,legal,count);
        }
        return S("forge/game/cost/PaymentDecision","card","(Ljava/lang/Iterable;)Lforge/game/cost/PaymentDecision;",Cards(selected));
    }

    private JValue ZoneCostDecision(JValue cost,JValue sa,JValue player,bool effect,bool sacrifice)
    {
        var source=C(sa,"getHostCard","()Lforge/game/card/Card;");string type=g.Rt.StringValue(C(cost,"getType","()Ljava/lang/String;"));
        bool differentNames=type.Contains("+WithDifferentNames"),sameName=type.Contains("+WithSameName");
        if(differentNames||sameName)type=type.Replace("+WithDifferentNames","").Replace("+WithSameName","");
        if(!CanPayPart(cost,sa,player,effect))return default;
        string zone=sacrifice?"Battlefield":"Hand",legality=sacrifice?"canBeSacrificedBy":"canBeDiscardedBy";
        var available=Items(C(player,"getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;",g.Enum("forge/game/zone/ZoneType",zone)))
            .Where(card=>C(card,legality,"(Lforge/game/spellability/SpellAbility;Z)Z",sa,JValue.I(effect?1:0)).Int!=0).ToArray();
        JValue[] selected;
        if(B(cost,"payCostFromSource")||type=="OriginalHost"||!sacrifice&&type=="LastDrawn")
        {
            var card=type=="OriginalHost"?C(sa,"getOriginalHost","()Lforge/game/card/Card;"):type=="LastDrawn"?C(player,"getLastDrawnCard","()Lforge/game/card/Card;"):source;
            var legal=available.Where(c=>ReferenceEquals(c.Reference,card.Reference)).ToArray();selected=[Pick("zone cost source",legal)];
        }
        else
        {
            if(B(sa,"isSpell"))available=available.Where(c=>!ReferenceEquals(c.Reference,source.Reference)).ToArray();
            if(type!="Hand"&&type!="Random")available=Items(S("forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;",Cards(available),C(g.S(type),"split","(Ljava/lang/String;)[Ljava/lang/String;",g.S(";")),player,source,sa));
            int count=type=="Hand"||g.Rt.StringValue(C(cost,"getAmount","()Ljava/lang/String;"))=="All"?available.Length:C(cost,"getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I",sa).Int;
            if(type=="Random")selected=Items(S("forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;",Cards(available),JValue.I(count)));
            else if(differentNames||sameName){
                string NameOf(JValue card)=>g.Rt.StringValue(C(card,"getName","()Ljava/lang/String;"));
                if(sameName)available=available.GroupBy(NameOf).Where(group=>group.Count()>=count).SelectMany(group=>group).ToArray();
                var paid=new List<JValue>();
                while(paid.Count<count){
                    if(available.Length==0)return default;
                    var card=SelectForCost("name-constrained discard",sameName?"选择同名牌弃掉":"选择不同名的牌弃掉",player,available,1)[0];
                    paid.Add(card);string name=NameOf(card);
                    available=available.Where(c=>!ReferenceEquals(c.Reference,card.Reference)&&(NameOf(c)==name)==sameName).ToArray();
                }
                selected=paid.ToArray();
            }else if((type=="Hand"||count==0)&&HasCostInput(player))selected=available.Take(count).ToArray();
            else selected=SelectForCost(sacrifice?"sacrifice cost":"discard cost",sacrifice?"选择要牺牲的永久物":"选择要弃掉的牌",player,available,count);
        }
        return S("forge/game/cost/PaymentDecision","card","(Ljava/lang/Iterable;)Lforge/game/cost/PaymentDecision;",Cards(selected));
    }

    private bool AnnounceNonManaX(JValue sa,JValue cost,int seat,out bool announced)
    {
        announced=false;
        var parts=Items(C(cost,"getCostParts","()Ljava/util/List;"));
        var xParts=parts.Where(p=>!g.Rt.IsInstance(p.Reference!,"forge/game/cost/CostPartMana")&&g.Rt.StringValue(C(p,"getAmount","()Ljava/lang/String;"))=="X").ToArray();
        var manaValueCost=parts.FirstOrDefault(p=>g.Rt.IsInstance(p.Reference!,"forge/game/cost/CostSacrifice")&&
            g.Rt.StringValue(C(p,"getType","()Ljava/lang/String;")).Contains("cmcEQX",StringComparison.Ordinal));
        if(xParts.Length==0 && manaValueCost.Reference==null)return true;
        var bounds=S("forge/game/ability/AbilityUtils","getAnnouncementBounds","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lorg/apache/commons/lang3/Range;",sa,g.S("X"));
        int min=g.Rt.UnboxInt(C(bounds,"getMinimum","()Ljava/lang/Object;")),max=g.Rt.UnboxInt(C(bounds,"getMaximum","()Ljava/lang/Object;"));
        foreach(var part in xParts)
        {
            var cap=C(part,"getMaxAmountX","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Ljava/lang/Integer;",sa,g.Players[seat],JValue.I(0));
            if(cap.Reference!=null)max=Math.Min(max,g.Rt.UnboxInt(cap));
            if(part.Reference!.ClassName is "forge/game/cost/CostRemoveCounter" or "forge/game/cost/CostRemoveAnyCounter" &&
                B(g.Rt.GetField(part,part.Reference.ClassName,"oneOrMore","Ljava/lang/Boolean;"),"booleanValue"))min=Math.Max(min,1);
        }
        if(max<min)return false;
        if(manaValueCost.Reference!=null)
        {
            var previous=C(sa,"getXManaCostPaid","()Ljava/lang/Integer;");
            var payable=new List<int>();
            var battlefield=Cards(Zone(seat,"Battlefield").Where(card=>C(card,"canBeSacrificedBy","(Lforge/game/spellability/SpellAbility;Z)Z",sa,JValue.I(0)).Int!=0));
            try
            {
                foreach(int value in Items(battlefield).Select(card=>C(card,"getCMC","()I").Int).Distinct().OrderBy(value=>value))
                {
                    if(value<min||value>max)continue;
                    C(sa,"setXManaCostPaid","(Ljava/lang/Integer;)V",g.Rt.BoxInt(value));
                    if(ValidCostCards(manaValueCost,sa,g.Players[seat],battlefield).Length<C(manaValueCost,"getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I",sa).Int)continue;
                    if(C(cost,"canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",sa,g.Players[seat],JValue.I(0)).Int!=0)payable.Add(value);
                }
            }
            finally { C(sa,"setXManaCostPaid","(Ljava/lang/Integer;)V",previous); }
            if(payable.Count==0)return false;
            int chosen=payable[tape.Choose("sacrifice mana value",payable.Select(n=>n.ToString()))];
            C(sa,"setXManaCostPaid","(Ljava/lang/Integer;)V",g.Rt.BoxInt(chosen));
            announced=true;return true;
        }
        if(max==int.MaxValue)throw new HostDecisionGap("Non-mana X has no finite resource bound: "+Label(sa));
        C(sa,"setXManaCostPaid","(Ljava/lang/Integer;)V",g.Rt.BoxInt(min+tape.Choose("non-mana X "+Label(sa),Enumerable.Range(min,checked(max-min+1)).Select(n=>n.ToString()))));
        announced=true;
        return true;
    }

    private JValue AdditionalCostDecision(string part,JValue cost,JValue sa,JValue payer,bool effect)
    {
        if(!CanPayPart(cost,sa,payer,effect))return default;
        int count=C(cost,"getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I",sa).Int;
        if(part=="CostPutCardToLib"){
            var from=C(cost,"getFrom","()Lforge/game/zone/ZoneType;");
            bool singleOwner=B(cost,"isSameZone");
            var pool=C(singleOwner?g.Game:payer,"getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;",from);
            JValue[] chosen;
            if(B(cost,"payCostFromSource")){
                var sourceCard=C(sa,"getHostCard","()Lforge/game/card/Card;");
                if(!Items(pool).Contains(sourceCard))return default;
                chosen=[sourceCard];
            }else{
                var candidates=ValidCostCards(cost,sa,payer,pool);
                if(singleOwner&&count>0){
                    var groups=candidates.GroupBy(c=>Seat(C(c,"getOwner","()Lforge/game/player/Player;"))).Where(group=>group.Count()>=count).ToArray();
                    if(groups.Length==0)return default;
                    int groupIndex=HasCostInput(payer)&&groups.Length>1?pickCostGroup!("选择区域所属玩家",groups.Select(group=>group.Key==0?"你":"对手").ToArray()):0;
                    candidates=groups[groupIndex].ToArray();
                }
                if(candidates.Length<count)return default;
                chosen=SelectForCost("put into library cost","选择要放回牌库的牌",payer,candidates,count);
            }
            return S("forge/game/cost/PaymentDecision","card","(Ljava/lang/Iterable;)Lforge/game/cost/PaymentDecision;",Cards(chosen));
        }
        if(part=="CostChooseColor"){
            var sets=PayableColorSets(cost,sa,payer,effect);
            if(sets.Length==0)return default;
            return S("forge/game/cost/PaymentDecision","colors","(Lforge/card/ColorSet;)Lforge/game/cost/PaymentDecision;",Pick("payable color choice",sets));
        }
        var source=C(sa,"getHostCard","()Lforge/game/card/Card;");
        bool reveal=part is "CostReveal" or "CostBehold" or "CostBeholdExile";
        var zone=reveal?C(payer,"getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;",C(cost,"getRevealFrom","()Ljava/util/List;")):
            C(payer,"getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;",g.Enum("forge/game/zone/ZoneType","Battlefield"));
        string restriction=g.Rt.StringValue(C(cost,"getType","()Ljava/lang/String;"));
        JValue[] offered;
        if(B(cost,"payCostFromSource"))offered=[source];
        else if(reveal&&restriction=="Hand"){offered=Items(zone);count=offered.Length;}
        else if(reveal&&restriction=="SameColor"){
            var hand=Items(zone).Where(c=>!B(sa,"isSpell")||!ReferenceEquals(c.Reference,source.Reference)).ToArray();
            var groups=Enumerable.Range(0,5).Select(i=>hand.Where(c=>(C(C(c,"getColor","()Lforge/card/ColorSet;"),"getColor","()B").Int&(1<<i))!=0).ToArray()).Where(group=>group.Length>=count).ToArray();
            if(groups.Length==0)return default;
            int groupIndex=HasCostInput(payer)?groups.Length==1?0:pickCostGroup!("选择一组同色牌",groups.Select(group=>string.Join("、",group.Select(c=>g.Rt.StringValue(C(c,"getName","()Ljava/lang/String;"))))).ToArray()):
                tape.Choose("common reveal color",groups.Select(group=>string.Join(", ",group.Select(Label))));
            offered=groups[groupIndex];
        }else offered=ValidCostCards(cost,sa,payer,zone).Where(c=>!reveal||!B(sa,"isSpell")||!ReferenceEquals(c.Reference,source.Reference)).ToArray();
        if(part=="CostRemoveAnyCounter"){
            var table=g.New("forge/game/GameEntityCounterTable","()V");
            var fixedType=g.Rt.GetField(cost,"forge/game/cost/CostRemoveAnyCounter","counter","Lforge/game/card/CounterType;");
            for(int i=0;i<count;i++){
                var choices=new List<(JValue Card,JValue Type)>();
                foreach(var card in offered){
                    var left=C(table,"filterToRemove","(Lforge/game/GameEntity;)Lcom/google/common/collect/Multiset;",card);
                    foreach(var type in Items(C(left,"elementSet","()Ljava/util/Set;")))
                        if((fixedType.Reference==null||C(type,"equals","(Ljava/lang/Object;)Z",fixedType).Int!=0)&&C(card,"canRemoveCounters","(Lforge/game/card/CounterType;)Z",type).Int!=0)choices.Add((card,type));
                }
                if(choices.Count==0)return default;
                var chosen=tape.Pick("remove counter from among permanents",choices.ToArray(),v=>Label(v.Card)+" "+Label(v.Type));
                C(table,"put","(Lforge/game/player/Player;Lforge/game/GameEntity;Lforge/game/card/CounterType;I)I",JValue.R(null),chosen.Card,chosen.Type,JValue.I(1));
            }
            return S("forge/game/cost/PaymentDecision","counters","(Lforge/game/GameEntityCounterTable;)Lforge/game/cost/PaymentDecision;",table);
        }
        if(count>offered.Length)return default;
        var selected=HasCostInput(payer)&&(B(cost,"payCostFromSource")||reveal&&restriction=="Hand")?offered.Take(count).ToArray():
            SelectForCost(part,reveal?"选择要展示的牌":"选择要耗竭的永久物",payer,offered,count);
        return S("forge/game/cost/PaymentDecision","card","(Ljava/lang/Iterable;)Lforge/game/cost/PaymentDecision;",Cards(selected));
    }

    private JValue[] PayableColorSets(JValue cost,JValue sa,JValue payer,bool effect)
    {
        int count=C(cost,"getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I",sa).Int;
        var source=C(sa,"getHostCard","()Lforge/game/card/Card;");
        var parts=C(C(sa,"getPayCosts","()Lforge/game/cost/Cost;"),"getCostParts","()Ljava/util/List;");
        var dependent=Items(parts).Where(p=>g.Rt.IsInstance(p.Reference!,"forge/game/cost/CostDiscard")&&
            g.Rt.StringValue(C(p,"getType","()Ljava/lang/String;")).Contains("ChosenColor",StringComparison.Ordinal)).ToArray();
        var previous=g.Rt.GetField(source,"forge/game/card/Card","chosenColors","Ljava/util/List;");
        var result=new List<JValue>();
        try {
            for(int mask=0;mask<32;mask++){
                if(Enumerable.Range(0,5).Count(bit=>(mask&(1<<bit))!=0)!=count)continue;
                var colors=S("forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;",JValue.I(mask));
                if(dependent.Length>0){
                    var names=OfferedColors(colors).Select(c=>C(c,"getName","()Ljava/lang/String;"));
                    C(source,"setChosenColors","(Ljava/util/List;)V",g.Rt.ListOf(names));
                    if(!dependent.All(p=>CanPayPart(p,sa,payer,effect)))continue;
                }
                result.Add(colors);
            }
        }finally{
            if(dependent.Length>0)C(source,"setChosenColors","(Ljava/util/List;)V",previous);
        }
        return result.ToArray();
    }

    // Only a decision is constructed here. CostRemoveCounter.payAsDecided performs
    // all mutation, triggers and CostCountersRemoved bookkeeping in the engine.
    private JValue RemoveCounterDecision(JValue cost,JValue sa,JValue player)
    {
        var counter=g.Rt.GetField(cost,"forge/game/cost/CostRemoveCounter","counter","Lforge/game/card/CounterType;");
        var source=C(sa,"getHostCard","()Lforge/game/card/Card;");
        string type=g.Rt.StringValue(C(cost,"getType","()Ljava/lang/String;"));
        string amount=g.Rt.StringValue(C(cost,"getAmount","()Ljava/lang/String;"));
        JValue[] offered;
        if(B(cost,"payCostFromSource"))offered=[source];
        else if(type=="OriginalHost")offered=[C(sa,"getOriginalHost","()Lforge/game/card/Card;")];
        else
        {
            var zones=g.Rt.GetField(cost,"forge/game/cost/CostRemoveCounter","zone","Ljava/util/List;");
            var cards=C(player,"getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;",zones);
            var restrictions=C(g.S(type),"split","(Ljava/lang/String;)[Ljava/lang/String;",g.S(";"));
            offered=Items(S("forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;",cards,restrictions,player,source,sa));
        }
        var table=g.New("forge/game/GameEntityCounterTable","()V");
        int requested=amount=="All"?-1:C(cost,"getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I",sa).Int;
        if(requested<0&&amount!="All")throw new HostDecisionGap("Negative announced counter payment");
        JValue[] Types(JValue card)=>counter.Reference!=null?[counter]:Items(C(C(card,"getCounters","()Lcom/google/common/collect/Multiset;"),"elementSet","()Ljava/util/Set;"));
        int Available(JValue card,JValue ct)=>C(card,"canRemoveCounters","(Lforge/game/card/CounterType;)Z",ct).Int!=0?C(card,"getCounters","(Lforge/game/card/CounterType;)I",ct).Int:0;
        var legal=offered.Where(card=>!B(card,"isPhasedOut")&&(requested<=0||Types(card).Sum(ct=>Available(card,ct))>=requested)).ToArray();
        if(legal.Length==0)throw new HostDecisionGap("Counter payment has no legal source");
        var selected=Pick("remove counter source",legal);
        int remaining=requested<0?Types(selected).Sum(ct=>C(selected,"getCounters","(Lforge/game/card/CounterType;)I",ct).Int):requested;
        while(remaining>0)
        {
            var pool=C(table,"filterToRemove","(Lforge/game/GameEntity;)Lcom/google/common/collect/Multiset;",selected);
            var choices=Types(selected).Where(ct=>Available(selected,ct)>0&&C(pool,"count","(Ljava/lang/Object;)I",ct).Int>0).ToArray();
            if(choices.Length==0)throw new HostDecisionGap("Counter payment cannot remove required total");
            var chosen=Pick("remove counter type",choices);
            int max=Math.Min(remaining,C(pool,"count","(Ljava/lang/Object;)I",chosen).Int);
            int count=1+tape.Choose("remove counter quantity",Enumerable.Range(1,max).Select(n=>n.ToString()));
            C(table,"put","(Lforge/game/player/Player;Lforge/game/GameEntity;Lforge/game/card/CounterType;I)I",JValue.R(null),selected,chosen,JValue.I(count));remaining-=count;
        }
        return S("forge/game/cost/PaymentDecision","counters","(Lforge/game/GameEntityCounterTable;)Lforge/game/cost/PaymentDecision;",table);
    }
}

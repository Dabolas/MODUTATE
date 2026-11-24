using Planeswalker.ForgeAot;
public sealed partial class HeadlessMatch {
    private JValue C(JValue v,string name,string signature,params JValue[] args)=>g.Call(v,name,signature,args);
    private JValue S(string owner,string name,string signature,params JValue[] args)=>g.Static(owner,name,signature,args);
    private JValue[] Items(JValue value)=>g.Rt.ListItems(value);
    private JValue Cards(IEnumerable<JValue> values)=>g.New("forge/game/card/CardCollection","(Ljava/lang/Iterable;)V",g.Rt.ListOf(values.ToArray()));
    private bool B(JValue v,string name)=>C(v,name,"()Z").Int!=0;
    private int Seat(JValue player)=>g.Players.FindIndex(p=>ReferenceEquals(p.Reference,player.Reference));
    private int ControllerSeat(JValue ctrl)=>Seat(C(ctrl,"getPlayer","()Lforge/game/player/Player;"));
    private JValue[] Zone(int seat,string zone)=>Items(C(g.Zone(seat,zone),"getCards","()Lforge/game/card/CardCollectionView;"));
    private string Label(JValue v)
    {
        if(v.Reference==null)return "null";
        if(g.Rt.IsInstance(v.Reference,"forge/game/card/Card"))return "card:"+C(v,"getId","()I").Int+":"+g.Rt.StringValue(C(v,"getName","()Ljava/lang/String;"));
        if(g.Rt.IsInstance(v.Reference,"forge/game/player/Player"))return "seat:"+Seat(v);
        if(g.Rt.IsInstance(v.Reference,"forge/game/spellability/SpellAbility"))return "ability:"+Label(C(v,"getHostCard","()Lforge/game/card/Card;"))+":"+g.Rt.StringValue(C(v,"toString","()Ljava/lang/String;"));
        return v.Reference.ClassName+":"+g.Rt.StringValue(C(v,"toString","()Ljava/lang/String;"));
    }
    private JValue Pick(string kind,JValue[] offered)=>tape.Pick(kind,offered,Label);
    private Func<JValue,bool>? takesCostInput {get;set;}
    private Func<string,JValue[],int,JValue[]>? pickCostCards {get;set;}
    private Func<string,string[],int>? pickCostGroup {get;set;}
    private Func<JValue,JValue,JValue[]?>? stagedExilePayment {get;set;}
    private bool HasCostInput(JValue payer)=>takesCostInput?.Invoke(payer)==true;
    private JValue[] SelectForCost(string kind,string title,JValue payer,JValue[] offered,int count)
    {
        if(count<0||count>offered.Length)throw new HostDecisionGap(kind+": invalid cost candidate count");
        if(count>0&&HasCostInput(payer))return pickCostCards!(title,offered,count);
        return Subset(kind,offered,count,count);
    }
    private JValue[] Subset(string kind,JValue[] offered,int min,int max)
    {
        max=Math.Min(max,offered.Length);if(min<0||max<min)throw new HostDecisionGap(kind+": inconsistent bounds");
        int count=min+tape.Choose(kind+" count",Enumerable.Range(min,max-min+1).Select(n=>n.ToString()));return tape.Shuffle(kind,offered,Label).Take(count).ToArray();
    }
    private bool CanFundMana(JValue costPart,JValue ability,int seat)
    {
        if(costPart.Reference==null)return true;
        const string xType="Ljava/lang/Integer;";
        var previous=C(ability,"getXManaCostPaid","()"+xType);
        bool needsX=previous.Reference==null&&C(costPart,"getAmountOfX","()I").Int>0;
        // Before the engine announces X, check whether its minimum is payable.
        // The actual announcement independently evaluates the affordable values.
        if(needsX)C(ability,"setXManaCostPaid","("+xType+")V",g.Rt.BoxInt(C(costPart,"getXMin","()I").Int));
        try{
            var mana=C(costPart,"getManaCostFor","(Lforge/game/spellability/SpellAbility;)Lforge/card/mana/ManaCost;",ability);
            return PayMana(mana,ability,seat,default,false,true);
        }finally{if(needsX)C(ability,"setXManaCostPaid","("+xType+")V",previous);}
    }
    private JValue[][] OptionalCostOptions(JValue ability,JValue[] offered,int seat)
    {
        if(offered.Length>16)throw new HostDecisionGap("Optional cost powerset exceeds bounded policy search");
        var legal=new List<JValue[]>();
        for(int bits=0;bits<(1<<offered.Length);bits++)
        {
            var selected=offered.Where((_,i)=>(bits&(1<<i))!=0).ToArray();
            var variant=S("forge/game/GameActionUtil","addOptionalCosts","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)Lforge/game/spellability/SpellAbility;",ability,g.Rt.ListOf(selected));
            var cost=C(variant,"getPayCosts","()Lforge/game/cost/Cost;");
            var adjusted=S("forge/game/cost/CostAdjustment","adjust","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Z)Lforge/game/cost/Cost;",cost,variant,JValue.I(0));
            if(C(adjusted,"canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",variant,g.Players[seat],JValue.I(0)).Int==0)continue;
            var mana=C(adjusted,"getCostMana","()Lforge/game/cost/CostPartMana;");
            if(!CanFundMana(mana,variant,seat))continue;
            legal.Add(selected);
        }
        if(legal.Count==0)throw new HostDecisionGap("No affordable optional cost combination for selected action: "+Label(ability));
        return legal.ToArray();
    }
    private JValue ExileCostDecision(JValue cost,JValue sa,JValue player,bool effect)
    {
        if(C(cost,"canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",sa,player,JValue.I(effect?1:0)).Int==0)return default;
        var source=C(sa,"getHostCard","()Lforge/game/card/Card;");string type=g.Rt.StringValue(C(cost,"getType","()Ljava/lang/String;"));
        int restriction=g.Rt.GetField(cost,"forge/game/cost/CostExile","zoneRestriction","I").Int;
        var zones=C(cost,"getFrom","()Ljava/util/List;");
        var available=Items(C(restriction==1?player:g.Game,"getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;",zones)).Where(card=>C(card,"canExiledBy","(Lforge/game/spellability/SpellAbility;Z)Z",sa,JValue.I(effect?1:0)).Int!=0).ToArray();
        JValue[] chosen;
        if(B(cost,"payCostFromSource")||type=="OriginalHost")
        {var target=type=="OriginalHost"?C(sa,"getOriginalHost","()Lforge/game/card/Card;"):source;chosen=[Pick("exile cost source",available.Where(c=>ReferenceEquals(c.Reference,target.Reference)).ToArray())];}
        else
        {
            if(type.Contains("withTotalCMC")||type.Contains("withSharedCardType")||type.Contains("withTypesGE")||type.Contains("FromTopGrave"))throw new HostDecisionGap("Constrained exile-cost subset: "+type);
            if(B(sa,"isSpell"))available=available.Where(c=>!ReferenceEquals(c.Reference,source.Reference)).ToArray();
            if(B(sa,"isCraft")){
                var first=C(C(sa,"getPayCosts","()Lforge/game/cost/Cost;"),"getCostPartByType","(Ljava/lang/Class;)Lforge/game/cost/CostPart;",JValue.R(g.Rt.ClassObject("forge/game/cost/CostExile")));
                if(first.Reference!=null&&B(first,"payCostFromSource"))available=available.Where(c=>!ReferenceEquals(c.Reference,source.Reference)).ToArray();
            }
            if(type!="All")available=Items(S("forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;",Cards(available),C(g.S(type),"split","(Ljava/lang/String;)[Ljava/lang/String;",g.S(";")),player,source,sa));
            int count=type=="All"?available.Length:C(cost,"getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I",sa).Int;
            if(Items(zones).Any(z=>g.Rt.InspectEnumName(z)=="Library"))throw new HostDecisionGap("Ordered library exile cost");
            if(restriction==0&&count>0){
                var groups=available.GroupBy(c=>Seat(C(c,"getController","()Lforge/game/player/Player;"))).Where(group=>group.Count()>=count).ToArray();
                if(groups.Length==0)return default;
                available=HasCostInput(player)?groups[groups.Length==1?0:pickCostGroup!("选择从哪位玩家的区域放逐",groups.Select(group=>group.Key==0?"你":"对手").ToArray())].ToArray():
                    tape.Pick("exile from one player",groups,group=>"seat "+group.Key).ToArray();
            }
            if(HasCostInput(player)&&stagedExilePayment?.Invoke(sa,cost) is { } staged){
                if(staged.Length!=count||staged.Any(c=>!available.Any(card=>ReferenceEquals(card.Reference,c.Reference))))return default;
                chosen=staged;
            }else chosen=type=="All"&&HasCostInput(player)?available:SelectForCost("exile cost","选择要放逐的牌",player,available,count);
        }
        return S("forge/game/cost/PaymentDecision","card","(Ljava/lang/Iterable;)Lforge/game/cost/PaymentDecision;",Cards(chosen));
    }
    private Func<int,KeyValuePair<JValue,JValue>[][],KeyValuePair<JValue,JValue>[]>? chooseReductionPlan {get;set;}
    private JValue ChooseTapReduction(JValue[] args,int seat)
    {
        var sa=args[0];var mana=args[1];bool colored=args[4].Int!=0&&args[3].Int==0;
        int maximum=args[5].Reference==null?int.MaxValue:g.Rt.UnboxInt(args[5]);
        var offered=tape.Shuffle("tap payment candidate order",Items(args[2]),Label);
        var plans=new List<KeyValuePair<JValue,JValue>[]>();int nodes=0;
        JValue Copy(JValue due)=>g.New("forge/game/mana/ManaCostBeingPaid","(Lforge/game/mana/ManaCostBeingPaid;)V",due);
        bool CanFund(JValue due)
        {
            var spent=g.Rt.ListOf([]);bool paid=C(g.ManaPool(seat),"payManaCostFromPool","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;ZLjava/util/List;)Z",Copy(due),sa,JValue.I(1),spent).Int!=0;
            if(!paid)C(g.ManaPool(seat),"refundMana","(Ljava/util/List;)V",spent);return paid;
        }
        void Search(int index,JValue due,List<KeyValuePair<JValue,JValue>> selected)
        {
            if(plans.Count>=64)return;
            if(++nodes>8192)throw new HostDecisionGap("Convoke/improvise payment search exceeds 8192 states");
            if(index==offered.Length||selected.Count==maximum||B(due,"isPaid"))
            {if(CanFund(due))plans.Add(selected.ToArray());return;}
            var card=offered[index];int mask=C(C(card,"getColor","()Lforge/card/ColorSet;"),"getColor","()B").Int;
            var shards=Items(C(due,"getUnpaidShards","()Ljava/util/List;")).GroupBy(s=>g.Rt.InspectEnumName(s)).Select(group=>group.First()).ToArray();
            if(colored&&shards.Any(shard=>B(shard,"isOr2Generic")))throw new HostDecisionGap("Two-generic hybrid convoke allocation requires its separate payment policy");
            var eligible=shards.Where(shard=>g.Rt.InspectEnumName(shard)=="GENERIC"||colored&&!B(shard,"isSnow")&&!B(shard,"isColorless")&&(C(shard,"getColorMask","()B").Int&mask)!=0).ToArray();
            foreach(var shard in tape.Shuffle("tap payment shard search",eligible.Append(default(JValue)),s=>s.Reference==null?"do not tap":Label(s)))
            {
                if(shard.Reference==null){Search(index+1,due,selected);continue;}
                var next=Copy(due);C(next,"decreaseShard","(Lforge/card/mana/ManaCostShard;I)V",shard,JValue.I(1));selected.Add(new(card,shard));Search(index+1,next,selected);selected.RemoveAt(selected.Count-1);
            }
        }
        Search(0,g.New("forge/game/mana/ManaCostBeingPaid","(Lforge/card/mana/ManaCost;)V",mana),[]);
        // An empty optional selection is legal even if the underlying action is
        // unaffordable. The caller's real mana check then rejects that action.
        if(plans.Count==0){tape.Choose("no affordable tap payment plan",["decline optional reduction; let engine reject unpaid cost"]);return g.Rt.MapOf([]);}
        var chosen=chooseReductionPlan!=null?chooseReductionPlan(seat,plans.ToArray()):tape.Pick("affordable tap payment plan",plans.ToArray(),plan=>plan.Length==0?"pay only mana":string.Join(";",plan.Select(p=>Label(p.Key)+" -> "+Label(p.Value))));
        return g.Rt.MapOf(chosen);
    }
}

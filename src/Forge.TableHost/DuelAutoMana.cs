using Planeswalker.ForgeAot;
using Planeswalker.Core;

public sealed partial class HeadlessMatch
{
    sealed record ManaOption(JValue Card,JValue Ability,JValue Part,string Express,JValue[] Mana,
        JValue TapPartner=default,int Id=-1,int PartnerId=-1,int Life=0,int Damage=0,bool Sacrifice=false)
    {
        public bool AdditionalCost=>Life!=0||Damage!=0||Sacrifice||PartnerId>=0;
    }
    const string ManaCostDue="Lforge/game/mana/ManaCostBeingPaid;";
    const string ManaObject="Lforge/game/mana/Mana;";
    const string ManaPoolObject="Lforge/game/mana/ManaPool;";
    const string ManaShard="Lforge/card/mana/ManaCostShard;";
    const string SpellObject="Lforge/game/spellability/SpellAbility;";
    const string ManaCostObject="Lforge/game/cost/Cost;";
    readonly List<ManaOption[]>?[] priorityManaSources=new List<ManaOption[]>?[2];
    bool? priorityHasManaModifiers;

    bool HasManaActionModifiers()
    {
        const string modeType="forge/game/staticability/StaticAbilityMode";
        var raise=g.Enum(modeType,"RaiseCost");
        var prohibit=g.Enum(modeType,"CantBeActivated");
        var alternate=g.Enum(modeType,"AlternativeCost");
        var zones=g.Rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;");
        var cards=Items(C(g.Game,"getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;",zones));
        foreach(var card in cards)
            foreach(var trait in Items(C(card,"getStaticAbilities","()Lforge/util/collect/FCollectionView;")))
                if(C(trait,"checkMode","(L"+modeType+";)Z",raise).Int!=0||
                   C(trait,"checkMode","(L"+modeType+";)Z",prohibit).Int!=0||
                   C(trait,"checkMode","(L"+modeType+";)Z",alternate).Int!=0)return true;
        return false;
    }

    JValue OrdinaryTapManaCost(JValue card,JValue ability)
    {
        if(ability.Reference?.ClassName!="forge/game/ability/AbilityApiBased"||!B(ability,"isManaAbility")||
           !B(card,"isBasicLand")||!B(card,"isInPlay")||!B(ability,"isIntrinsic")||B(ability,"usesTargeting")||
           !ReferenceEquals(card.Reference,C(ability,"getHostCard","()Lforge/game/card/Card;").Reference)||
           g.Rt.InspectEnumName(C(ability,"getApi","()Lforge/game/ability/ApiType;"))!="Mana"||
           C(ability,"getSubAbility","()Lforge/game/spellability/AbilitySub;").Reference!=null||
           C(ability,"hasParam","(Ljava/lang/String;)Z",g.S("RaiseCost")).Int!=0||
           C(ability,"hasParam","(Ljava/lang/String;)Z",g.S("AlternateCost")).Int!=0)return default;
        var cost=C(ability,"getPayCosts","()"+ManaCostObject);
        if(cost.Reference==null)return default;
        var parts=Items(C(cost,"getCostParts","()Ljava/util/List;"));
        return parts.Length==1&&parts[0].Reference?.ClassName=="forge/game/cost/CostTap"?cost:default;
    }

    JValue[]? QuoteOrdinaryLandAbilities(JValue card,int seat)
    {
        var player=g.Players[seat];
        if(!checkingActions||!B(card,"isBasicLand")||!B(card,"isInPlay")||B(card,"isFaceDown")||B(card,"isModal")||
           g.Rt.InspectEnumName(C(card,"getCurrentStateName","()Lforge/card/CardStateName;"))!="Original"||
           !ReferenceEquals(C(card,"getController","()Lforge/game/player/Player;").Reference,player.Reference))return null;
        var abilities=Items(C(card,"getSpellAbilities","()Lforge/util/collect/FCollectionView;"));
        // CardState supplies the intrinsic land-play ability as well as mana.
        // The land-play ability is unavailable for a card already in play.
        if(abilities.Length!=2||abilities[0].Reference?.ClassName!="forge/game/spellability/LandAbility"||
           OrdinaryTapManaCost(card,abilities[1]).Reference==null||
           (priorityHasManaModifiers??=HasManaActionModifiers()))return null;
        foreach(var ability in abilities)
            C(ability,"setActivatingPlayer","(Lforge/game/player/Player;)V",player);
        return C(abilities[1],"canPlay","(Z)Z",JValue.I(1)).Int!=0?new[]{abilities[1]}:Array.Empty<JValue>();
    }

    bool? QuoteOrdinaryManaOffer(JValue card,JValue ability,int seat)
    {
        if(!checkingActions)return null;
        var cost=OrdinaryTapManaCost(card,ability);
        if(cost.Reference==null||(priorityHasManaModifiers??=HasManaActionModifiers()))return null;
        // CostTap is the entire cost. There is no X, alternate cost, or target
        // to quote, and the window's static abilities do not change this cost or permission.
        C(ability,"setMaxWaterbend","("+ManaCostObject+")V",cost);
        return C(cost,"canPay","("+SpellObject+"Lforge/game/player/Player;Z)Z",ability,g.Players[seat],JValue.I(0)).Int!=0&&
            B(ability,"isLegalAfterStack");
    }

    ManaView[] ManaPoolView(int seat)
    {
        var floating=Items(g.ManaPool(seat)).Select(m=>(Color:C(m,"getColor","()B").Int,Snow:B(m,"isSnow"))).ToArray();
        return new[]{"W","U","B","R","G","C"}.Select(symbol=>{
            int color=ManaMask(symbol);
            return new ManaView{id=color,color=symbol,amount=floating.Count(m=>m.Color==color),snowAmount=floating.Count(m=>m.Color==color&&m.Snow)};
        }).ToArray();
    }

    // One group per permanent: a dual land cannot be tapped once for each color.
    // Floating mana is represented separately, including the ability which created it.
    List<ManaOption[]> BattlefieldMana(int seat=0)
    {
        if(checkingActions&&priorityManaSources[seat] is { } cached)return cached;
        var player=g.Players[seat];
        var groups=new List<ManaOption[]>();
        var hasModifiers=new Lazy<bool>(HasManaActionModifiers);
        // Most boards have no effect that replaces mana production. Check for the
        // event type once, then ask about individual outputs only when necessary.
        var hasReplacement=new Lazy<bool>(()=>Items(C(g.Game,"getCardsInGame","()Lforge/game/card/CardCollectionView;"))
            .Any(c=>Items(C(c,"getReplacementEffects","()Lforge/util/collect/FCollectionView;"))
                .Any(r=>g.Rt.InspectEnumName(C(r,"getMode","()Lforge/game/replacement/ReplacementType;"))=="ProduceMana")));
        foreach(var card in Zone(seat,"Battlefield")){
            if(B(card,"isTapped")||B(card,"isPhasedOut"))continue;
            var options=new List<ManaOption>();
            foreach(var ability in Items(C(card,"getManaAbilities","()Lforge/util/collect/FCollectionView;"))){
                var previous=C(ability,"getActivatingPlayer","()Lforge/game/player/Player;");
                try{
                    C(ability,"setActivatingPlayer","(Lforge/game/player/Player;)V",player);
                    options.AddRange(ManaOutputs(card,ability,hasModifiers,hasReplacement,seat));
                }finally{C(ability,"setActivatingPlayer","(Lforge/game/player/Player;)V",previous);}
            }
            if(options.Count>0)groups.Add(options.ToArray());
        }
        // Prefer less flexible sources, keeping rainbow lands available.
        groups=groups.OrderBy(group=>group.Length).ToList();
        if(checkingActions)priorityManaSources[seat]=groups;
        return groups;
    }

    IEnumerable<ManaOption> ManaOutputs(JValue card,JValue ability,Lazy<bool> hasModifiers,Lazy<bool> hasReplacement,int seat)
    {
        var player=g.Players[seat];
        string api=g.Rt.InspectEnumName(C(ability,"getApi","()Lforge/game/ability/ApiType;"))??"";
        if(api!="Mana"&&api!="ManaReflected")yield break;
        bool Has(string key)=>C(ability,"hasParam","(Ljava/lang/String;)Z",g.S(key)).Int!=0;
        if(B(ability,"usesTargeting")||
           Has("Optional")||Has("Chooser")||Has("Each")||!B(ability,"canPlay")||!B(ability,"metConditions")||
           B(C(ability,"getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;"),"isInstantSpeed"))yield break;
        var tapCost=OrdinaryTapManaCost(card,ability);
        bool ordinary=tapCost.Reference!=null&&!hasModifiers.Value;
        if(!ordinary&&C(ability,"checkRestrictions","(Lforge/game/player/Player;)Z",player).Int==0)yield break;
        var sub=C(ability,"getSubAbility","()Lforge/game/spellability/AbilitySub;");
        int damage=0;
        if(sub.Reference!=null){
            if(g.Rt.InspectEnumName(C(sub,"getApi","()Lforge/game/ability/ApiType;"))!="DealDamage"||
               OptionalText(C(sub,"getParam","(Ljava/lang/String;)Ljava/lang/String;",g.S("Defined")))!="You"||
               !int.TryParse(OptionalText(C(sub,"getParam","(Ljava/lang/String;)Ljava/lang/String;",g.S("NumDmg"))),out damage)||damage<1||
               C(sub,"getSubAbility","()Lforge/game/spellability/AbilitySub;").Reference!=null)yield break;
        }
        var adjusted=tapCost;
        if(ordinary)C(ability,"setMaxWaterbend","("+ManaCostObject+")V",adjusted);
        else{
            var cost=C(ability,"getPayCosts","()"+ManaCostObject);
            adjusted=S("forge/game/cost/CostAdjustment","adjust","("+ManaCostObject+SpellObject+"Z)"+ManaCostObject,cost,ability,JValue.I(0));
        }
        var parts=Items(C(adjusted,"getCostParts","()Ljava/util/List;"));
        bool Is(JValue p,string name)=>g.Rt.IsInstance(p.Reference!,"forge/game/cost/"+name);
        int life=0;bool sacrifice=false,taps=false;
        JValue[] partners=new[]{default(JValue)};
        foreach(var p in parts){
            if(Is(p,"CostTap"))taps=true;
            else if(Is(p,"CostPayLife"))life+=C(p,"getAbilityAmount","("+SpellObject+")I",ability).Int;
            else if(Is(p,"CostSacrifice")&&B(p,"payCostFromSource"))sacrifice=true;
            else if(Is(p,"CostTapType")&&partners.Length==1&&partners[0].Reference==null)partners=DrumPartners(p,ability,card,player);
            else if(!Is(p,"CostPartMana")||!B(C(p,"getManaCostFor","("+SpellObject+")Lforge/card/mana/ManaCost;",ability),"isZero"))yield break;
        }
        if(!taps&&!sacrifice||partners.Length==0)yield break;
        var recipients=Items(S("forge/game/ability/SpellAbilityEffect",api=="Mana"?"getDefinedPlayersOrTargeted":"getTargetPlayers",
            "("+SpellObject+")Lforge/game/player/PlayerCollection;",ability));
        if(recipients.Length!=1||Seat(recipients[0])!=seat)yield break;
        var part=C(ability,"getManaPart","()Lforge/game/spellability/AbilityManaPart;");
        int amount=C(ability,"amountOfManaGenerated","(Z)I",JValue.I(0)).Int;
        if(part.Reference==null||amount<=0||B(part,"isSpecialMana"))yield break;
        var outputs=new List<(string Express,string[] Colors)>();
        bool combo=B(part,"isComboMana");
        if(api=="ManaReflected"||combo||B(part,"isAnyMana")){
            string[] colors=api=="ManaReflected"
                ?Items(S("forge/game/card/CardUtil","getReflectableManaColors","("+SpellObject+")Ljava/util/Set;",ability))
                    .Select(c=>OptionalText(S("forge/card/MagicColor","toShortString","(Ljava/lang/String;)Ljava/lang/String;",c))).ToArray()
                :combo?OptionalText(C(part,"getComboColors","("+SpellObject+")Ljava/lang/String;",ability)).Split(' ')
                :new[]{"W","U","B","R","G"};
            // Multi-mana combos accept one independent choice per unit. A player can
            // always use those explicitly, including effects requiring distinct colors.
            if(combo&&amount>1)yield break;
            foreach(string color in colors.Distinct())
                if(ManaMask(color)!=0&&!(combo&&api=="Mana"&&color=="C"&&colors[0]!="C"))
                    outputs.Add((color,Enumerable.Repeat(color,amount).ToArray()));
        }else{
            string printed=OptionalText(C(part,"mana","("+SpellObject+")Ljava/lang/String;",ability));
            var colors=new List<string>();
            foreach(string token in printed.Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries)){
                if(int.TryParse(token,out int count)&&count>=0)colors.AddRange(Enumerable.Repeat("C",count));
                else if(ManaMask(token)!=0)colors.Add(token);
                else yield break;
            }
            if(colors.Count>0)outputs.Add(("",Enumerable.Range(0,amount).SelectMany(_=>colors).ToArray()));
        }
        var previews=new Dictionary<string,JValue>();
        foreach(var output in outputs){
            if(hasReplacement.Value&&HasManaReplacement(card,ability,string.Join(" ",output.Colors),player))continue;
            JValue Preview(string color){
                if(!previews.TryGetValue(color,out var mana)){
                    mana=g.New("forge/game/mana/Mana","(BLforge/game/card/Card;Lforge/game/spellability/AbilityManaPart;Lforge/game/player/Player;)V",
                        JValue.I(ManaMask(color)),card,part,player);
                    previews.Add(color,mana);
                }
                return mana;
            }
            var produced=output.Colors.Select(Preview).ToArray();
            int id=C(card,"getId","()I").Int;
            foreach(var partner in partners)
                yield return new ManaOption(card,ability,part,output.Express,produced,partner,id,
                    partner.Reference==null?-1:C(partner,"getId","()I").Int,life,damage,sacrifice);
        }
    }

    static int ManaMask(string color)=>color switch{"W"=>1,"U"=>2,"B"=>4,"R"=>8,"G"=>16,"C"=>32,_=>0};

    bool HasManaReplacement(JValue card,JValue ability,string produced,JValue player)
    {
        var parameters=S("forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;",card);
        void Set(string key,JValue value)=>C(parameters,"put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",g.Enum("forge/game/ability/AbilityKey",key),value);
        Set("Mana",g.S(produced));Set("Player",player);Set("Activator",player);Set("AbilityMana",ability);
        var handler=C(g.Game,"getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;");
        var replacement=g.Enum("forge/game/replacement/ReplacementType","ProduceMana");
        // A null layer asks the rules for matches in any layer, in one pass.
        var applicable=C(handler,"getReplacementList","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;Lforge/game/replacement/ReplacementLayer;)Ljava/util/List;",
            replacement,parameters,default(JValue));
        return !B(applicable,"isEmpty");
    }

    IEnumerable<ManaOption[]> PayableManaSources(JValue spell,JValue host,int seat)
    {
        var cost=C(spell,"getPayCosts","()Lforge/game/cost/Cost;");
        bool tapsSource=cost.Reference!=null&&B(cost,"hasTapCost");
        bool? requiresSource=null;
        foreach(var group in BattlefieldMana(seat)){
            var options=new List<ManaOption>();
            foreach(var option in group){
                bool own=ReferenceEquals(option.Card.Reference,host.Reference);
                if(tapsSource&&(own||ReferenceEquals(option.TapPartner.Reference,host.Reference)))continue;
                if(own&&option.Sacrifice&&cost.Reference!=null&&
                   (requiresSource??=Items(C(cost,"getCostParts","()Ljava/util/List;")).Any(part=>B(part,"payCostFromSource"))))continue;
                var units=option.Mana.Where(mana=>Spendable(mana,spell)).ToArray();
                if(units.Length>0)options.Add(option with{Mana=units});
            }
            if(options.Count>0)yield return options.ToArray();
        }
    }

    int TableManaCapacity(JValue spell,int seat)=>g.ManaCount(seat)+
        PayableManaSources(spell,C(spell,"getHostCard","()Lforge/game/card/Card;"),seat).Sum(group=>group.Max(option=>option.Mana.Length));

    JValue ManaSource(JValue mana)=>C(mana,"getSourceCard","()Lforge/game/card/Card;");

    bool Spendable(JValue mana,JValue spell)=>Spendable(mana,spell,ManaSource(mana));

    bool Spendable(JValue mana,JValue spell,JValue source)=>C(mana,"meetsManaRestrictions","("+SpellObject+")Z",spell).Int!=0&&
        C(spell,"allowsPayingWithShard","(Lforge/game/card/Card;B)Z",source,C(mana,"getColor","()B")).Int!=0;

    JValue QuotePool(JValue spell,JValue realPool,JValue matrix,JValue player)
    {
        const string matrixType="Lforge/game/mana/ManaConversionMatrix;";
        var pool=g.New("forge/game/mana/ManaPool","(Lforge/game/player/Player;)V",player);
        C(pool,"applyCardMatrix","("+matrixType+")V",realPool);
        if(matrix.Reference!=null){
            C(pool,"applyCardMatrix","("+matrixType+")V",matrix);
            return pool;
        }
        if(B(spell,"isCopied"))return pool;
        var host=C(spell,"getHostCard","()Lforge/game/card/Card;");
        if(B(spell,"isSpell")){
            var option=C(host,"mayPlay","(Lforge/game/staticability/StaticAbility;)Lforge/game/card/CardPlayOption;",C(spell,"getMayPlay","()Lforge/game/staticability/StaticAbility;"));
            if(option.Reference!=null){
                C(option,"applyManaConvert","("+matrixType+")Z",pool);
                if(B(option,"isIgnoreSnowSourceManaCostColor"))C(pool,"setSnowForColor","(Z)V",JValue.I(1));
            }
        }
        void ApplyConversion(JValue trait){
            var conversion=C(trait,"getParam","(Ljava/lang/String;)Ljava/lang/String;",g.S("ManaConversion"));
            if(conversion.Reference!=null)S("forge/game/ability/AbilityUtils","applyManaColorConversion","("+matrixType+"Ljava/lang/String;)V",pool,conversion);
        }
        if(B(spell,"isActivatedAbility")){
            var grantor=C(spell,"getGrantorStatic","()Lforge/game/staticability/StaticAbility;");
            if(grantor.Reference!=null)ApplyConversion(grantor);
        }
        S("forge/game/staticability/StaticAbilityManaConvert","manaConvert","("+matrixType+"Lforge/game/player/Player;Lforge/game/card/Card;"+SpellObject+")Z",pool,player,host,spell);
        ApplyConversion(spell);
        return pool;
    }

    bool PayFromTable(JValue due,JValue spell,JValue matrix,bool quote,bool effect,int seat=0)
    {
        if(B(due,"isPaid")){
            if(!quote)C(spell,"setManaCostBeingPaid","("+ManaCostDue+")V",due);
            return true;
        }
        var payer=g.Players[seat];
        var pool=g.ManaPool(seat);
        int availableLife=Math.Max(0,g.Life(seat)-(seat==1?1:0));
        var host=C(spell,"getHostCard","()Lforge/game/card/Card;");
        bool preferOtherSources=B(spell,"isActivatedAbility")&&!B(spell,"isManaAbility")&&B(host,"isLand");
        int hostId=preferOtherSources?C(host,"getId","()I").Int:-1;
        var rulesPool=quote?default:pool;
        JValue RulesPool()=>rulesPool.Reference==null?(rulesPool=QuotePool(spell,pool,matrix,payer)):rulesPool;
        if(!quote&&matrix.Reference!=null)C(pool,"applyCardMatrix","(Lforge/game/mana/ManaConversionMatrix;)V",matrix);
        var primary=new List<ManaOption[]>();
        var sourceOnly=new List<ManaOption[]>();
        foreach(var mana in Items(pool)){
            var source=ManaSource(mana);
            if(!Spendable(mana,spell,source))continue;
            bool fromHost=preferOtherSources&&source.Reference!=null&&C(source,"getId","()I").Int==hostId;
            (fromHost?sourceOnly:primary).Add(new[]{new ManaOption(default,default,default,"",new[]{mana})});
        }
        var plan=new List<ManaOption>();
        var effectFlag=JValue.I(effect?1:0);
        JValue[] Unpaid(JValue debt)=>Items(C(debt,"getUnpaidShards","()Ljava/util/List;"));
        bool Needed(JValue copy,JValue mana)=>C(copy,"isNeeded","("+ManaObject+ManaPoolObject+")Z",mana,RulesPool()).Int!=0;
        bool FindPlan(IReadOnlyList<ManaOption[]> groups,JValue balance,int reservedLife,bool additional){
            plan.Clear();
            if(B(balance,"isPaid"))return true;
            if(groups.Count==0||availableLife<reservedLife)return false;
            int generic=C(balance,"getGenericManaAmount","()I").Int;
            if(!additional&&generic>0&&Unpaid(balance).Length==generic){
                // Independent, cost-free sources with only generic debt need no search.
                // Check every preview against Forge's shard rules before counting it.
                int unpaid=generic;
                foreach(var group in groups){
                    ManaOption? best=null;
                    int usable=0;
                    foreach(var option in group){
                        if(option.AdditionalCost)continue;
                        int count=option.Mana.Count(mana=>Needed(balance,mana));
                        if(count<=usable)continue;
                        usable=count;best=option;
                        if(usable>=unpaid)break;
                    }
                    if(best==null)continue;
                    plan.Add(best);
                    unpaid-=usable;
                    if(unpaid<=0)return true;
                }
                return false;
            }
            int budget=seat==1?Math.Max(128,groups.Count*3):int.MaxValue;
            var failed=new HashSet<(int,string,int)>();
            var sharedIds=groups.SelectMany(group=>group).Where(o=>o.PartnerId>=0).Select(o=>o.PartnerId).ToHashSet();
            var used=new SortedSet<int>();
            var remaining=new long[groups.Count+1];
            for(int i=groups.Count-1;i>=0;i--)remaining[i]=remaining[i+1]+groups[i].Max(o=>o.Mana.Length);
            bool Search(int index,JValue debt,int lifeRemaining){
                if(--budget<0)return false;
                if((reservedLife>0||seat==1)&&lifeRemaining<0)return false;
                if(B(debt,"isPaid"))return true;
                if(index==groups.Count||C(debt,"getGenericManaAmount","()I").Int>remaining[index]||
                    Unpaid(debt).Length>remaining[index])return false;
                string key=OptionalText(C(debt,"toString","()Ljava/lang/String;"));
                var x=C(debt,"getXManaCostPaidByColor","()Ljava/util/Map;");
                if(x.Reference!=null)key+=OptionalText(C(x,"toString","()Ljava/lang/String;"));
                if(used.Count>0)key+="|"+string.Join(",",used);
                if(!failed.Add((index,key,lifeRemaining)))return false;
                foreach(var option in groups[index].OrderBy(o=>o.Sacrifice?3:o.Life+o.Damage>0?2:o.PartnerId>=0?1:0)){
                    if(option.AdditionalCost&&!additional||used.Contains(option.Id)||used.Contains(option.PartnerId)||
                       option.Life>0&&option.Life>lifeRemaining)continue;
                    JValue next=default;
                    foreach(var mana in option.Mana){
                        if(!Needed(next.Reference==null?debt:next,mana))continue;
                        if(next.Reference==null)next=g.New("forge/game/mana/ManaCostBeingPaid","("+ManaCostDue+")V",debt);
                        C(next,"payMana","("+ManaObject+ManaPoolObject+")Z",mana,RulesPool());
                    }
                    if(next.Reference==null)continue;
                    plan.Add(option);
                    if(sharedIds.Contains(option.Id))used.Add(option.Id);
                    if(option.PartnerId>=0)used.Add(option.PartnerId);
                    if(Search(index+1,next,lifeRemaining-option.Life-option.Damage))return true;
                    used.Remove(option.Id);used.Remove(option.PartnerId);
                    plan.RemoveAt(plan.Count-1);
                }
                return Search(index+1,debt,lifeRemaining);
            }
            return Search(0,balance,availableLife-reservedLife);
        }

        bool addedSources=false;
        List<ManaOption[]>? withSource=null;
        bool FindWithAdditionalCosts(IReadOnlyList<ManaOption[]> groups,JValue balance,int reservedLife)=>
            groups.Any(group=>group.Any(option=>option.AdditionalCost))&&FindPlan(groups,balance,reservedLife,true);
        bool PlanMana(JValue balance,int reservedLife){
            if(FindPlan(primary,balance,reservedLife,false))return true;
            if(!addedSources){
                addedSources=true;
                foreach(var group in PayableManaSources(spell,host,seat))
                    (preferOtherSources&&group[0].Id==hostId?sourceOnly:primary).Add(group);
                if(FindPlan(primary,balance,reservedLife,false))return true;
            }
            if(FindWithAdditionalCosts(primary,balance,reservedLife))return true;
            if(sourceOnly.Count==0)return false;
            withSource??=primary.Concat(sourceOnly).ToList();
            return FindPlan(withSource,balance,reservedLife,false)||FindWithAdditionalCosts(withSource,balance,reservedLife);
        }

        void ReserveLifeShards(JValue balance,(JValue Shard,int Count)[] reserved)
        {
            foreach(var part in reserved)
                if(part.Count>0)C(balance,"decreaseShard","("+ManaShard+"I)V",part.Shard,JValue.I(part.Count));
        }

        int phyrexianCount=0;
        var lifeShards=Array.Empty<(JValue Shard,int Count)>();
        IReadOnlyList<ManaOption> payment=plan;
        if(B(due,"containsPhyrexianMana")){
            var symbols=Unpaid(due).Where(shard=>B(shard,"isPhyrexian"))
                .GroupBy(shard=>shard.Reference).Select(group=>(Shard:group.First(),Count:group.Count())).ToArray();
            var remaining=new int[symbols.Length+1];
            for(int i=symbols.Length-1;i>=0;i--)remaining[i]=remaining[i+1]+symbols[i].Count;
            int limit=Math.Min(remaining[0],availableLife/2);
            var reserved=symbols.Select(part=>(part.Shard,Count:0)).ToArray();
            // Reserve exact symbols on a copy before planning mana, including costs with more than one color of Phyrexian symbol.
            bool TryAllocation(int index,int count,int lifeCost)
            {
                if(index==symbols.Length){
                    if(lifeCost==0)return PlanMana(due,0);
                    var balance=g.New("forge/game/mana/ManaCostBeingPaid","("+ManaCostDue+")V",due);
                    ReserveLifeShards(balance,reserved);
                    return PlanMana(balance,lifeCost);
                }
                int min=Math.Max(0,count-remaining[index+1]),max=Math.Min(count,symbols[index].Count);
                for(int n=min;n<=max;n++){
                    reserved[index].Count=n;
                    if(TryAllocation(index+1,count-n,lifeCost))return true;
                }
                return false;
            }
            var payable=new SortedDictionary<int,((JValue Shard,int Count)[] Shards,ManaOption[] Mana)>();
            for(int count=0;count<=limit;count++){
                int lifeCost=2*count;
                if(count>0&&C(payer,"canPayLife","(IZ"+SpellObject+")Z",JValue.I(lifeCost),effectFlag,spell).Int==0)continue;
                if(!TryAllocation(0,count,lifeCost))continue;
                if(quote)return true;
                payable.Add(count,(reserved.ToArray(),plan.ToArray()));
                if(seat==1)break;
            }
            if(payable.Count==0)return false;
            phyrexianCount=seat==1?payable.Keys.First():ChoosePhyrexianPayment(payable.Keys.ToArray());
            if(!payable.TryGetValue(phyrexianCount,out var chosen))return false;
            lifeShards=chosen.Shards;
            payment=chosen.Mana;
        }
        else if(!PlanMana(due,0))return false;
        if(quote)return true;
        var consequences=new List<string>();
        foreach(var option in payment.Where(o=>seat==0&&o.AdditionalCost)){
            var effects=new List<string>();
            if(option.Life>0)effects.Add("支付 "+option.Life+" 点生命");
            if(option.Damage>0)effects.Add("对你造成 "+option.Damage+" 点伤害");
            if(option.Sacrifice)effects.Add("牺牲此牌");
            if(option.PartnerId>=0)effects.Add("横置 "+Name(option.TapPartner));
            consequences.Add(Name(option.Card)+" · "+string.Join("，",effects));
        }
        if(consequences.Count>0&&TableAnswer(YesNo(string.Join("；",consequences),"确认产费","取消施放")).Int==0)return false;
        ReserveLifeShards(due,lifeShards);
        var spent=C(spell,"getPayingMana","()Ljava/util/List;");
        foreach(var option in payment){
            var mana=option.Mana;
            if(option.Ability.Reference!=null){
                if(!ActivateMana(option,pool,payer))return false;
                C(C(spell,"getPayingManaAbilities","()Ljava/util/List;"),"add","(Ljava/lang/Object;)Z",option.Ability);
                mana=Items(C(option.Part,"getLastManaProduced","()Ljava/util/Collection;"));
            }
            foreach(var unit in mana){
                if(Spendable(unit,spell)&&Needed(due,unit)&&C(pool,"tryPayCostWithMana","("+SpellObject+ManaCostDue+ManaObject+"Z)Z",spell,due,unit,JValue.I(0)).Int!=0)
                    C(spent,"add","(Ljava/lang/Object;)Z",unit);
            }
        }
        if(!B(due,"isPaid"))return false;
        if(phyrexianCount>0){
            if(C(payer,"payLife","(I"+SpellObject+"Z)Z",JValue.I(2*phyrexianCount),spell,effectFlag).Int==0)return false;
            for(int i=0;i<phyrexianCount;i++)
                C(spell,"setSpendPhyrexianMana","(Z)V",JValue.I(1));
        }
        C(spell,"setManaCostBeingPaid","("+ManaCostDue+")V",due);
        return true;
    }

    bool ActivateMana(ManaOption option,JValue pool,JValue player)
    {
        var ability=option.Ability;
        var previous=C(ability,"getActivatingPlayer","()Lforge/game/player/Player;");
        C(ability,"setActivatingPlayer","(Lforge/game/player/Player;)V",player);
        if(!B(ability,"canPlay")||C(ability,"checkRestrictions","(Lforge/game/player/Player;)Z",player).Int==0){
            C(ability,"setActivatingPlayer","(Lforge/game/player/Player;)V",previous);
            return false;
        }
        var express=C(option.Part,"getExpressChoice","()Ljava/lang/String;");
        // The nested activation may install and clear its own spending conversions.
        // Keep the outer spell's matrix when it returns, just as CostPartMana does.
        const string matrixType="Lforge/game/mana/ManaConversionMatrix;";
        var outer=g.New("forge/game/mana/ManaConversionMatrix","()V");
        C(outer,"restoreColorReplacements","()V");
        C(outer,"applyCardMatrix","("+matrixType+")V",pool);
        try{
            C(option.Part,"setExpressChoice","(Ljava/lang/String;)V",g.S(option.Express));
            return WithDrumPartner(ability,option.TapPartner,()=>S("forge/game/player/PlaySpellAbility","playSpellAbility",
                "(Lforge/game/player/PlayerController;Lforge/game/player/Player;"+SpellObject+")Z",
                C(player,"getController","()Lforge/game/player/PlayerController;"),player,ability).Int!=0);
        }finally{
            C(option.Part,"setExpressChoice","(Ljava/lang/String;)V",express);
            C(pool,"restoreColorReplacements","()V");
            C(pool,"applyCardMatrix","("+matrixType+")V",outer);
        }
    }
}

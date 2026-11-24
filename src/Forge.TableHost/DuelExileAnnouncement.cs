using Planeswalker.Core;
using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    sealed record ExilePlan(string Type,JValue[] Cards);
    readonly Dictionary<int,ExilePlan> stagedExiles=new();

    void InstallExileAnnouncement()
    {
        targetsAfterAnnouncement=sa=>OptionalText(C(sa,"getParam","(Ljava/lang/String;)Ljava/lang/String;",g.S("Announce")))=="Exiled";
        var ordinary=g.Decision("announceRequirements")!;
        g.SetDecision("announceRequirements",(controller,args)=>{
            if(checkingActions||ControllerSeat(controller)!=0)return ordinary(controller,args);
            var sa=args[0];
            string value=OptionalText(args[3]);
            if(value=="Exiled"&&AnnouncedHandExileCost(sa) is {Reference:not null} part)
                return JHostResult.Complete(ChooseExilePlan(sa,part,args[2].Int));
            if(value=="X"&&stagedExiles.TryGetValue(AbilityCardId(sa),out var plan))
                return JHostResult.Complete(ChooseExileSpellX(sa,plan,args[1].Int,args[2].Int));
            return ordinary(controller,args);
        });
        stagedExilePayment=(sa,cost)=>{
            int id=AbilityCardId(sa);
            if(!stagedExiles.TryGetValue(id,out var plan)||
                plan.Type!=OptionalText(C(cost,"getType","()Ljava/lang/String;"))||!IsExileFromHand(cost))return null;
            stagedExiles.Remove(id);
            return plan.Cards;
        };
    }

    bool IsExileFromHand(JValue cost)
    {
        if(cost.Reference?.ClassName!="forge/game/cost/CostExile")return false;
        var zones=Items(C(cost,"getFrom","()Ljava/util/List;"));
        return zones.Length==1&&g.Rt.InspectEnumName(zones[0])=="Hand";
    }

    JValue AnnouncedHandExileCost(JValue sa)
    {
        var host=C(sa,"getHostCard","()Lforge/game/card/Card;");
        var mode=g.Enum("forge/game/staticability/StaticAbilityMode","RaiseCost");
        foreach(var rule in Items(C(host,"getStaticAbilities","()Lforge/util/collect/FCollectionView;"))){
            if(C(rule,"checkMode","(Lforge/game/staticability/StaticAbilityMode;)Z",mode).Int==0)continue;
            string cost=OptionalText(C(rule,"getParam","(Ljava/lang/String;)Ljava/lang/String;",g.S("Cost")));
            if(!cost.StartsWith("ExileFromHand<",StringComparison.Ordinal))continue;
            var definition=g.New("forge/game/cost/Cost","(Ljava/lang/String;ZZ)V",g.S(cost),JValue.I(0),JValue.I(1));
            return Items(C(definition,"getCostParts","()Ljava/util/List;")).FirstOrDefault(IsExileFromHand);
        }
        return default;
    }

    JValue ChooseExilePlan(JValue sa,JValue part,int max)
    {
        lastNotice="";
        var source=C(sa,"getHostCard","()Lforge/game/card/Card;");
        int id=AbilityCardId(sa);
        var candidates=Zone(0,"Hand").Where(card=>C(card,"getId","()I").Int!=id&&
            C(card,"canExiledBy","(Lforge/game/spellability/SpellAbility;Z)Z",sa,JValue.I(0)).Int!=0);
        var legal=ValidCostCards(part,sa,g.Players[0],Cards(candidates));
        int limit=Math.Min(max,legal.Length);
        bool cancelled=false;
        JValue[] selected=Array.Empty<JValue>();
        if(limit>0){
            const string title="步骤一 · 选择要从手牌放逐的牌";
            var wait=Ask("Ljava/lang/Integer;",title,(cmd,ids)=>{
                if(cmd=="cancel"){cancelled=true;return true;}
                if(cmd!="choice"||ids.Length>limit||ids.Distinct().Count()!=ids.Length||ids.Any(i=>(uint)i>=legal.Length))return false;
                selected=ids.Select(i=>legal[i]).ToArray();
                answer=g.Rt.BoxInt(selected.Length);
                return true;
            },false);
            var choice=new ChoiceView{id=revision,kind="cast-exile",title=title,min=0,max=limit,cancelCast=true,
                instructions="可选零张。每张牌减少{2}通用法术力，费用会在确认施放时支付。"};
            SetChoiceOptions(choice,legal,Name);
            View.choice=choice;
            View.promptCardId=C(source,"getId","()I").Int;
            TableAnswer(wait);
        }
        if(cancelled)return default;
        stagedExiles[id]=new ExilePlan(OptionalText(C(part,"getType","()Ljava/lang/String;")),selected);
        return g.Rt.BoxInt(selected.Length);
    }

    JValue ChooseExileSpellX(JValue sa,ExilePlan plan,int min,int max)
    {
        const string title="步骤二 · 声明 X";
        var wait=Ask("Ljava/lang/Integer;",title,(cmd,ids)=>{
            if(cmd=="cancel")return true;
            if(cmd!="choice"||ids.Length!=1||ids[0]<min||ids[0]>max)return false;
            int x=ids[0];
            var previous=C(sa,"getXManaCostPaid","()Ljava/lang/Integer;");
            C(sa,"setXManaCostPaid","(Ljava/lang/Integer;)V",g.Rt.BoxInt(x));
            try{
                if(!ExileSpellHasTarget(sa))lastNotice="这个 X 没有合法目标，咒语已退回手牌。";
                else if(!CanPayExileSpell(sa,x))lastNotice="这个 X 的费用无法支付，咒语已退回手牌。";
                else answer=g.Rt.BoxInt(x);
            }finally{C(sa,"setXManaCostPaid","(Ljava/lang/Integer;)V",previous);}
            return true;
        },false);
        View.choice=new ChoiceView{id=revision,kind="number",title=title,min=min,max=max,cancelCast=true,
            instructions=$"已选 {plan.Cards.Length} 张，减少 {{{2*plan.Cards.Length}}} 通用法术力。若费用不足或无合法目标，咒语会退回手牌。"};
        var chosen=TableAnswer(wait);
        if(chosen.Reference==null)stagedExiles.Remove(AbilityCardId(sa));
        return chosen;
    }

    bool ExileSpellHasTarget(JValue sa)
    {
        if(!B(sa,"usesTargeting"))return true;
        int min=C(sa,"getMinTargets","()I").Int;
        if(min==0)return true;
        var restrictions=C(sa,"getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;");
        return Items(C(restrictions,"getAllCandidates","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",sa))
            .Count(target=>C(sa,"canTarget","(Lforge/game/GameObject;)Z",target).Int!=0)>=min;
    }

    bool CanPayExileSpell(JValue sa,int x)
    {
        var cost=C(sa,"getPayCosts","()Lforge/game/cost/Cost;");
        var adjusted=S("forge/game/cost/CostAdjustment","adjust","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Z)Lforge/game/cost/Cost;",cost,sa,JValue.I(0));
        var mana=C(adjusted,"getCostMana","()Lforge/game/cost/CostPartMana;");
        if(mana.Reference!=null&&(long)x*(1+C(mana,"getAmountOfX","()I").Int)>=int.MaxValue)return false;
        return CanPayPart(adjusted,sa,g.Players[0],false)&&CanFundMana(mana,sa,0);
    }
}

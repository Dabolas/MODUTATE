using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    private bool HasModeCosts(JValue ability,JValue[] modes)=>
        C(C(ability,"getHostCard","()Lforge/game/card/Card;"),"hasKeyword","(Lforge/game/keyword/Keyword;)Z",g.Enum("forge/game/keyword/Keyword","ESCALATE")).Int!=0||
        modes.Any(mode=>C(mode,"hasParam","(Ljava/lang/String;)Z",g.S("ModeCost")).Int!=0);

    private JValue ChooseModes(JValue[] args)
    {
        if(args[4].Int!=0)throw new HostDecisionGap("Repeated modal selections");
        var modes=LegalModes(Items(args[1]));
        int min=args[2].Int,max=args[3].Int;
        if(!HasModeCosts(args[0],modes))return g.Rt.ListOf(Subset("modes",modes,min,max));
        var choices=AffordableModes(args[0],modes,min,max).ToArray();
        if(choices.Length==0)throw new HostDecisionGap("No payable mode set for "+Label(args[0]));
        return g.Rt.ListOf(tape.Pick("affordable modes",choices,set=>string.Join(" + ",set.Select(Label))));
    }

    private IEnumerable<JValue[]> AffordableModes(JValue ability,JValue[] modes,int min,int max)
    {
        if(modes.Length>16)throw new HostDecisionGap("Mode cost powerset exceeds bounded policy search");
        var player=C(ability,"getActivatingPlayer","()Lforge/game/player/Player;");
        for(int mask=0;mask<(1<<modes.Length);mask++)
        {
            var selected=modes.Where((_,i)=>(mask&(1<<i))!=0).ToArray();
            if(selected.Length<min||selected.Length>max)continue;
            // Use exactly the chain that the real transaction passes to CostAdjustment.
            var copy=C(ability,"copy","()Lforge/game/spellability/SpellAbility;");
            C(copy,"setSubAbility","(Lforge/game/spellability/AbilitySub;)V",default(JValue));
            S("forge/game/ability/effects/CharmEffect","chainAbilities","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)V",copy,g.Rt.ListOf(selected));
            var cost=C(copy,"getPayCosts","()Lforge/game/cost/Cost;");
            var adjusted=S("forge/game/cost/CostAdjustment","adjust","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Z)Lforge/game/cost/Cost;",cost,copy,JValue.I(0));
            if(!CanPayPart(adjusted,copy,player,false))continue;
            var mana=C(adjusted,"getCostMana","()Lforge/game/cost/CostPartMana;");
            if(CanFundMana(mana,copy,Seat(player)))
                yield return selected;
        }
    }

    // The callback also runs during affordability probes. Quote a contribution
    // against the helper's real pool and commit only after the caster can pay.
    private (int Seat,JValue Mana)? assistContribution;

    private void CommitAssist(JValue ability)
    {
        if(assistContribution is { } contribution&&!PayAssistPool(contribution.Seat,contribution.Mana,ability,false))
            throw new HostDecisionGap("Assist contribution became unpayable during payment");
    }

    private JValue AssistPayment(int helper,JValue due,JValue ability,int generic)
    {
        for(int count=Math.Min(generic,g.ManaCount(helper));count>0;count--)
        {
            var mana=S("forge/card/mana/ManaCost","get","(I)Lforge/card/mana/ManaCost;",JValue.I(count));
            if(!PayAssistPool(helper,mana,ability,true))continue;
            C(due,"decreaseGenericMana","(I)V",JValue.I(count));
            assistContribution=(helper,mana);
            break;
        }
        // A player can decline even after being asked.
        return JValue.I(1);
    }

    private bool PayAssistPool(int helper,JValue mana,JValue ability,bool test)
    {
        var due=g.New("forge/game/mana/ManaCostBeingPaid","(Lforge/card/mana/ManaCost;)V",mana);
        var spent=g.Rt.ListOf([]);
        var pool=g.ManaPool(helper);
        bool paid=C(pool,"payManaCostFromPool","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;ZLjava/util/List;)Z",due,ability,JValue.I(test?1:0),spent).Int!=0;
        if(!paid)C(pool,"refundMana","(Ljava/util/List;)V",spent);
        if(paid&&!test)C(C(ability,"getPayingMana","()Ljava/util/List;"),"addAll","(Ljava/util/Collection;)Z",spent);
        return paid;
    }
}

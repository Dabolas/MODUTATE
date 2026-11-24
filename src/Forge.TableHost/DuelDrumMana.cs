using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    // A creature paying another permanent's tap cost may have summoning sickness.
    // Use the same filtered battlefield list as the rules' eventual cost decision.
    JValue[] DrumPartners(JValue part,JValue ability,JValue card,JValue player)
    {
        if(!g.Rt.IsInstance(part.Reference!,"forge/game/cost/CostTapType")||
           OptionalText(C(part,"getType","()Ljava/lang/String;"))!="Creature"||
           OptionalText(C(part,"getAmount","()Ljava/lang/String;"))!="1")return Array.Empty<JValue>();
        return TapCostCandidates(part,ability,player,card,"Creature")
            .Where(partner=>!ReferenceEquals(partner.Reference,card.Reference)).ToArray();
    }

    bool WithDrumPartner(JValue ability,JValue partner,Func<bool> activate)
    {
        var previous=plannedManaTapPartner;
        plannedManaTapPartner=sa=>ReferenceEquals(sa.Reference,ability.Reference)?partner:previous?.Invoke(sa)??default;
        try{return activate();}
        finally{plannedManaTapPartner=previous;}
    }
}

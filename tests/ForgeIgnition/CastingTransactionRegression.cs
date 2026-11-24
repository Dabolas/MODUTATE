using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    public static void CastingDelveRegression(string root,Action<bool,string> check)=>HostCases(root,"casting-delve",check,(d,v,resources,seed)=>{
        var g=d.g;var grave=resources==1?g.Card("Forest",0,"Graveyard"):default;
        var victim=g.Card("Hill Giant",1,"Battlefield");var card=g.Card("Magmatic Sinkhole",0,"Hand");var sa=g.Ability(card,0);
        g.Fund(0,"R R R R R");var cost=d.C(sa,"getPayCosts","()Lforge/game/cost/Cost;");var mana=d.C(d.C(cost,"getCostMana","()Lforge/game/cost/CostPartMana;"),"getManaCostFor","(Lforge/game/spellability/SpellAbility;)Lforge/card/mana/ManaCost;",sa);
        bool payable=false;for(int i=0;i<16&&!payable;i++)payable=d.PayMana(mana,sa,0,default,false,true);
        v(payable==(resources==1),"Engine mana preflight requires the one available delve card");
        v(g.ManaCount(0)==5&&(resources==0||g.In(grave,"Graveyard")),"Preflight spends neither mana nor graveyard cards");
        if(!payable){v(g.In(card,"Hand")&&g.In(victim,"Battlefield"),"Unpayable Sinkhole is not offered for casting");return;}
        v(d.Play(sa,0)&&g.ManaCount(0)==0&&g.In(grave,"Exile"),"Actual cast retains the payable delve plan rather than randomly refusing it");
        g.ResolveOne();g.Sba();v(g.In(card,"Graveyard")&&g.In(victim,"Graveyard"),"Scarce-resource Sinkhole resolves for five damage");
    });

    public static void CastingModesRegression(string root,Action<bool,string> check)=>HostCases(root,"casting-modes",check,(d,v,resources,seed)=>{
        var g=d.g;var creature=resources==1?g.Card("Hill Giant",0,"Battlefield"):default;
        var card=g.Card("Dromoka's Command",0,"Hand");var sa=g.Ability(card,0);g.Fund(0,"G W");
        var ctrl=d.C(g.Players[0],"getController","()Lforge/game/player/PlayerController;");
        if(resources==0){
            v(!d.CanChooseModes(sa),"Command with only one legal mode is excluded before selecting an action");
            bool accepted=d.S("forge/game/player/PlaySpellAbility","playSpellAbility","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Z",ctrl,g.Players[0],sa).Int!=0;
            v(!accepted&&g.In(card,"Hand")&&g.ManaCount(0)==2,"Original transaction rejects insufficient modes without spending mana");return;
        }
        v(d.CanChooseModes(sa),"Command has two complete legal modes with only a friendly creature");
        v(d.Play(sa,0)&&g.ManaCount(0)==0,"Command pays GW despite an unavailable second fight target");
        g.ResolveOne();g.Sba();
        v(d.C(g.Current(creature),"getNetPower","()I").Int==4&&d.C(g.Current(creature),"getNetToughness","()I").Int==4,"Legal counter mode resolves; impossible fight mode is not selected");
        v(g.In(card,"Graveyard"),"Command completes the actual stack transaction");
    });
}

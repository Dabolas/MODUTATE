using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    private JValue ActivatedAbility(JValue card,int seat=0)
    {
        var sa=Items(C(card,"getSpellAbilities","()Lforge/util/collect/FCollectionView;")).First(a=>B(a,"isActivatedAbility"));
        C(sa,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[seat]);return sa;
    }
    public static void EffectAbilitiesRegression(string root,Action<bool,string> check)
    {
        bool selected=false,refused=false;
        HostCases(root,"effect-abilities",check,(d,v,resources,seed)=>{
            var g=d.g;var master=g.Card("A-Master of Winds",0,"Battlefield");var spell=g.Card("Shock",0,"Hand");var sa=g.Ability(spell,0);
            if(resources==1)g.Fund(0,"R");
            var ctrl=d.C(g.Players[0],"getController","()Lforge/game/player/PlayerController;");
            bool cast=d.S("forge/game/player/PlaySpellAbility","playSpellAbility","(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Z",ctrl,g.Players[0],sa).Int!=0;
            v(cast==(resources==1),"Only an actually paid Shock can trigger Master of Winds");
            if(cast){g.Sba();g.Drain();v(g.In(spell,"Graveyard")&&g.ManaCount(0)==0,"Trigger and real paid spell finish resolving");}
            else v(g.In(spell,"Hand"),"Insufficient mana leaves Shock in hand");
            int power=d.C(g.Current(master),"getNetPower","()I").Int,tough=d.C(g.Current(master),"getNetToughness","()I").Int;
            // Subset shuffles the whole offered list; only the first element is
            // selected for this one-choice effect, not the final shuffle entry.
            var choice=d.tape.Records.FirstOrDefault(r=>r.Kind=="effect spell abilities");
            if(choice!=null){selected=true;bool five=choice.Options[choice.Choice].Contains("5/1");v(power==(five?5:1)&&tough==(five?1:5),"Chosen printed mode actually sets Master's base power and toughness");}
            else {if(cast)refused=true;v(power==1&&tough==5,"Declined or untriggered optional ability leaves Master's 1/5 unchanged");}
            var empty=d.C(ctrl,"chooseSpellAbilitiesForEffect","(Ljava/util/List;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ILjava/util/Map;)Ljava/util/List;",g.Rt.ListOf([]),sa,g.S("empty legal set"),JValue.I(1),default);
            v(d.Items(empty).Length==0,"Empty engine-offered effect list does not invent an ability");
        });check(selected&&refused,"Real optional Master trigger exercises selection and refusal");
    }
    public static void CombatCostRegression(string root,Action<bool,string> check)
    {
        bool enlisted=false,declined=false,taxPaid=false,taxRefused=false;
        HostCases(root,"combat-cost",check,(d,v,resources,seed)=>{
            var g=d.g;var attacker=g.Card("Aradesh, the Founder",0,"Battlefield");var helper=g.Card("Hill Giant",0,"Battlefield");
            d.C(attacker,"setSickness","(Z)V",JValue.I(0));d.C(helper,"setSickness","(Z)V",JValue.I(resources==1?0:1));
            var combat=g.New("forge/game/combat/Combat","(Lforge/game/player/Player;)V",g.Players[0]);d.C(g.Phase,"setCombat","(Lforge/game/combat/Combat;)V",combat);d.C(combat,"addAttacker","(Lforge/game/card/Card;Lforge/game/GameEntity;)V",attacker,g.Players[1]);
            var legal=d.Items(d.S("forge/game/cost/CostEnlist","getCardsForEnlisting","(Lforge/game/player/Player;)Lforge/game/card/CardCollection;",g.Players[0]));
            v(legal.Length==resources&&legal.All(c=>ReferenceEquals(c.Reference,helper.Reference)),"Engine enlist candidates exclude attacker and summoning-sick helper");
            bool paid=d.S("forge/game/combat/CombatUtil","checkPropagandaEffects","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/combat/Combat;Ljava/util/List;)Z",g.Game,attacker,combat,g.Rt.ListOf([attacker])).Int!=0;
            v(resources==1||!paid,"Unpayable enlist is refused by original combat-cost path");
            g.Sba();g.Drain();
            if(paid){enlisted=true;v(d.B(helper,"isTapped")&&d.B(attacker,"getEnlistedThisCombat"),"Original enlist payment taps only the legal helper and marks attacker");v(d.C(attacker,"getNetPower","()I").Int==4,"Original enlist reflexive trigger adds helper's three power");}
            else {if(resources==1)declined=true;v(!d.B(helper,"isTapped")&&!d.B(attacker,"getEnlistedThisCombat")&&d.C(attacker,"getNetPower","()I").Int==1,"Declined or impossible enlist leaves both payment and power unchanged");}
        });
        HostCases(root,"combat-tax",check,(d,v,resources,seed)=>{
            var g=d.g;var attacker=g.Card("Raging Goblin",0,"Battlefield");g.Card("Propaganda",1,"Battlefield");if(resources==1)g.Fund(0,"R R");
            var combat=g.New("forge/game/combat/Combat","(Lforge/game/player/Player;)V",g.Players[0]);d.C(g.Phase,"setCombat","(Lforge/game/combat/Combat;)V",combat);d.C(combat,"addAttacker","(Lforge/game/card/Card;Lforge/game/GameEntity;)V",attacker,g.Players[1]);
            bool paid=d.S("forge/game/combat/CombatUtil","checkPropagandaEffects","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/combat/Combat;Ljava/util/List;)Z",g.Game,attacker,combat,g.Rt.ListOf([])).Int!=0;
            v(resources==1||!paid,"Propaganda cannot permit attacking without its two mana");
            v(g.ManaCount(0)==(paid?0:resources*2),"Propaganda spends exactly two mana on payment, none on refusal or failure");
            if(resources==1){taxPaid|=paid;taxRefused|=!paid;}
        });check(enlisted&&declined,"Aradesh exercises actual enlist payment and refusal");check(taxPaid&&taxRefused,"Propaganda exercises paid and refused attack taxes");
    }
    public static void MillCostRegression(string root,Action<bool,string> check)
    {
        HostCases(root,"mill-cost",check,(d,v,resources,seed)=>{
            var g=d.g;var top=resources==1?g.Card("Forest",0,"Library"):default;
            var card=g.Card("The Warring Triad",0,"Battlefield");var sa=d.ActivatedAbility(card);
            var cost=d.C(sa,"getPayCosts","()Lforge/game/cost/Cost;");
            bool canPay=d.CanPayPart(cost,sa,g.Players[0],false);
            v(canPay==(resources==1),"Triad's original cost requires a library card");
            if(!canPay){v(!d.B(card,"isTapped")&&g.ManaCount(0)+g.ManaCount(1)==0,"Insufficient library does not tap Triad or produce mana");return;}
            v(d.Play(sa,0),"Triad pays its original tap and mill cost");g.Drain();
            v(g.In(top,"Graveyard")&&d.Zone(0,"Library").Length==0&&d.B(card,"isTapped"),"Triad mills the actual top card and taps");
            v(g.ManaCount(0)+g.ManaCount(1)==1,"Triad produces exactly one actual mana for its chosen player");
        });
        bool accepted=false,refused=false;
        HostCases(root,"mill-cost-refusal",check,(d,v,resources,seed)=>{
            var g=d.g;var top=resources==1?g.Card("Forest",0,"Library"):default;
            var card=g.Card("The Warring Triad",0,"Battlefield");var sa=d.ActivatedAbility(card);
            var mill=d.Items(d.C(d.C(sa,"getPayCosts","()Lforge/game/cost/Cost;"),"getCostParts","()Ljava/util/List;")).Single(c=>g.Rt.IsInstance(c.Reference!,"forge/game/cost/CostMill"));
            var decision=d.C(mill,"accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",d.CostVisitor(g.Players[0],sa,true));
            v(resources==1||decision.Reference==null,"Optional mill cannot be paid from an empty library");
            if(decision.Reference==null){if(resources==1)refused=true;v(resources==0||g.In(top,"Library"),"Refusing mill leaves the top card untouched");}
            else {accepted=true;v(d.C(mill,"payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z",g.Players[0],decision,sa,JValue.I(1)).Int!=0&&g.In(top,"Graveyard"),"Accepted optional mill is performed by original CostMill.payAsDecided");}
        });check(accepted&&refused,"Optional mill covers payment and refusal");
    }
}

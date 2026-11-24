using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    public static void ReturnCostRegression(string root,Action<bool,string> check)=>
        HostCases(root,"return-cost",check,(d,verify,resources,seed)=>{
            var g=d.g;
            var opponent=g.Card("Forest",1,"Battlefield");
            var nonbasic=g.Card("City of Brass",0,"Battlefield");
            var spell=g.Card("Firewild Borderpost",0,"Hand");
            if(resources==1)g.Fund(0,"C");
            var alternatives=d.Items(d.S("forge/game/GameActionUtil","getAlternativeCosts","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Ljava/util/List;",g.Ability(spell,0),g.Players[0],JValue.I(0)));
            var paidReturn=(from sa in alternatives
                            let cost=d.C(sa,"getPayCosts","()Lforge/game/cost/Cost;")
                            from part in d.Items(d.C(cost,"getCostParts","()Ljava/util/List;"))
                            where g.Rt.IsInstance(part.Reference!,"forge/game/cost/CostReturn")
                            select (sa,part)).Single();
            verify(d.CanPayPart(paidReturn.part,paidReturn.sa,g.Players[0],false)==(resources==1),"Return requires a basic land on the payer's battlefield");
            if(resources==0)
            {
                verify(d.ReturnCostDecision(paidReturn.part,paidReturn.sa,g.Players[0],false).Reference==null&&g.In(spell,"Hand"),"No return decision when only an opponent's basic and a friendly nonbasic exist");
                return;
            }
            var basic=d.Zone(0,"Battlefield").Single(card=>d.B(card,"isBasicLand"));
            verify(d.Play(paidReturn.sa,0)&&g.ManaCount(0)==0,"Borderpost casts by paying its single generic alternative mana cost");
            verify(g.In(basic,"Hand")&&g.In(spell,"Stack")&&g.In(opponent,"Battlefield")&&g.In(nonbasic,"Battlefield"),"Only the eligible tapped basic returns, as a cost before resolution");
            g.Drain();
            verify(g.In(spell,"Battlefield")&&d.B(g.Current(spell),"isTapped"),"Paid Borderpost resolves and enters tapped");
        });

    public static void AssistPaymentRegression(string root,Action<bool,string> check)=>
        HostCases(root,"assist-payment",check,(d,verify,resources,seed)=>{
            var g=d.g;
            bool assisted=resources==1;
            string caster=assisted?(seed==1?"RC":"RR"):"RRCCCCCCC";
            g.Fund(0,caster);
            if(assisted)g.Fund(1,"GGGGGGGG");
            var victim=g.Card("Colossal Dreadmaw",1,"Battlefield");
            var spell=g.Card("Lava-Field Overlord",0,"Hand");
            var sa=g.Ability(spell,0);
            var mana=d.C(spell,"getManaCost","()Lforge/card/mana/ManaCost;");
            bool payable=d.PayMana(mana,sa,0,default,false,true);
            verify(payable==(!assisted||seed!=1),"Assist covers only generic mana and the caster needs both red pips");
            verify(g.ManaCount(0)==caster.Length&&g.ManaCount(1)==(assisted?8:0)&&g.In(spell,"Hand"),"Assist probe preserves both pools and the card in hand");
            if(!payable)
            {
                verify(!d.PayMana(mana,sa,0,default,false,false)&&g.ManaCount(0)==caster.Length&&g.ManaCount(1)==8,"Unpayable red pips leave the helper and caster fully refunded");
                return;
            }
            verify(d.Play(sa,0)&&g.ManaCount(0)==0,"Overlord's casting transaction spends the caster's share");
            verify(g.ManaCount(1)==(assisted?1:0),"The other player pays exactly seven generic when assisting");
            g.Drain();
            verify(g.In(spell,"Battlefield")&&d.C(g.Current(victim),"getDamage","()I").Int==4,"Overlord enters and its triggered ability deals exactly four damage");
        });

    public static void SpreePaymentRegression(string root,Action<bool,string> check)=>
        HostCases(root,"spree-payment",check,(d,verify,resources,seed)=>{
            var g=d.g;
            int funds=2+seed;
            g.Fund(0,"W"+new string('C',funds-1));
            var creature=g.Card("Hill Giant",0,"Graveyard");
            var vehicle=resources==1?g.Card("Sky Skiff",0,"Graveyard"):default;
            var spell=g.Card("One Last Job",0,"Hand");
            var sa=g.Ability(spell,0);
            bool payable=d.CanChooseModes(sa);
            verify(payable==(funds>=5||(resources==1&&funds>=4)),"An offered Spree action has a targetable mode payable above the base 2W");
            var modes=d.LegalModes(d.Items(d.S("forge/game/ability/effects/CharmEffect","makePossibleOptions","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",sa)));
            var sets=d.AffordableModes(sa,modes,1,3).ToArray();
            int expected=(funds>=5?1:0)+(resources==1&&funds>=4?1:0)+(resources==1&&funds>=6?1:0);
            verify(sets.Length==expected&&sets.Any(s=>s.Length==2)==(resources==1&&funds==6),"Creature, Vehicle and their combined surcharge use distinct affordability boundaries");
            verify(g.In(spell,"Hand")&&g.ManaCount(0)==funds&&g.In(creature,"Graveyard"),"Mode probes consume no mana and leave cards in their original zones");
            if(!payable)return;
            if(resources==1&&funds==6)
                g.SetDecision("chooseModeForAbility",(ctrl,a)=>JHostResult.Complete(g.Rt.ListOf(d.AffordableModes(a[0],d.LegalModes(d.Items(a[1])),a[2].Int,a[3].Int).Single(set=>set.Length==2))));
            verify(d.Play(sa,0),"One Last Job casts through the full payment and targeting transaction");
            g.Drain();
            bool returnedCreature=g.In(creature,"Battlefield");
            bool returnedVehicle=resources==1&&g.In(vehicle,"Battlefield");
            verify(g.In(spell,"Graveyard")&&(returnedCreature||returnedVehicle),"Selected legal targets return to the battlefield");
            verify(funds-g.ManaCount(0)==3+(returnedCreature?2:0)+(returnedVehicle?1:0),"Actual payment includes each resolved mode's surcharge exactly once");
            if(resources==1&&funds==6)verify(returnedCreature&&returnedVehicle,"Both modes resolve on the combined-cost boundary");
        });
}

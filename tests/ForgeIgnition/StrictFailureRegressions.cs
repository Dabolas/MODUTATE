using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    private JValue ScriptAbility(JValue card,string variable)
    {
        var script=C(card,"getSVar","(Ljava/lang/String;)Ljava/lang/String;",g.S(variable));
        var sa=S("forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;",script,card);
        C(sa,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);
        return sa;
    }
    public static void EnergyPaymentRegression(string root,Action<bool,string> check)=>
        HostCases(root,"energy-payment",check,(d,v,funded,seed)=>{
            var g=d.g;
            bool guide=seed%2==0;
            var card=g.Card(guide?"Guide of Souls":"Bristling Hydra",0,"Battlefield");
            var sa=guide?d.ScriptAbility(card,"TrigImmediateTrig"):d.Items(d.C(card,"getSpellAbilities","()Lforge/util/collect/FCollectionView;")).First(a=>d.B(a,"isActivatedAbility"));
            d.C(sa,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);
            var energy=d.S("forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;",g.S("ENERGY"));
            int balance=funded==1?4:2;
            var table=g.New("forge/game/GameEntityCounterTable","()V");
            d.C(g.Players[0],"addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V",energy,JValue.I(balance),g.Players[0],table);
            d.C(table,"replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V",g.Game,default);
            var cost=d.C(sa,"getPayCosts","()Lforge/game/cost/Cost;");
            var payment=g.New("forge/game/cost/CostPayment","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;)V",cost,sa);
            bool paid=d.C(payment,"payCost","(Lforge/game/cost/CostDecisionMakerBase;)Z",d.CostVisitor(g.Players[0],sa,false)).Int!=0;
            v(paid==(funded==1),"PayEnergy<3> checks available energy");
            v(d.C(g.Players[0],"getCounters","(Lforge/game/card/CounterType;)I",energy).Int==balance-(paid?3:0),"Engine pays exactly the announced energy");
        });

    public static void AdventureCostRegression(string root,Action<bool,string> check)=>
        HostCases(root,"adventure-cost",check,(d,v,funded,seed)=>{
            var g=d.g;
            bool red=seed%2==0;
            g.Card("Radagast of Rhosgobel",0,"Battlefield");
            g.Card("Grizzly Bears",1,"Battlefield");
            var card=g.Card(red?"Bonecrusher Giant":"Queen of Ice",0,"Hand");
            g.Sba();
            g.Fund(0,(funded==1?"C ":"")+(red?"R":"U"));
            var abilities=d.Items(d.C(card,"getAllPossibleAbilities","(Lforge/game/player/Player;Z)Ljava/util/List;",g.Players[0],JValue.I(0)));
            var sa=abilities.First(a=>g.Rt.InspectEnumName(d.C(a,"getCardStateName","()Lforge/card/CardStateName;"))=="Secondary");
            bool offered=d.CanOfferAction(card,sa,0);
            v(offered==(funded==1),"Adventure ignores reduction for creature spells");
            v(g.ManaCount(0)==1+funded&&g.Rt.InspectEnumName(d.C(card,"getCurrentStateName","()Lforge/card/CardStateName;"))=="Original","Probe restores hand face and mana");
            if(offered){v(d.Play(sa,0)&&g.ManaCount(0)==0,"Adventure actually pays two");g.ResolveOne();v(g.In(card,"Exile"),"Resolved adventure goes to exile");}
        });

    public static void DividedDamageRegression(string root,Action<bool,string> check)=>
        HostCases(root,"divided-damage",check,(d,v,funded,seed)=>{
            var g=d.g;
            bool sacrifice=seed%2==0;
            var card=g.Card(sacrifice?"Nahiri's Sacrifice":"Forked Bolt",0,"Hand");
            g.Card("Grizzly Bears",1,"Battlefield");
            JValue fodder=funded==1?g.Card("Grizzly Bears",0,"Battlefield"):default;
            g.Fund(0,sacrifice?"C R":"R");
            var sa=g.Ability(card,0);
            bool offered=d.CanOfferAction(card,sa,0);
            v(offered==(!sacrifice||funded==1),"Only a payable sacrifice is offered");
            if(!offered)return;
            if(sacrifice)v(g.Rt.UnboxInt(d.C(sa,"getXManaCostPaid","()Ljava/lang/Integer;"))==2,"X equals actual sacrifice mana value");
            v(d.Play(sa,0),"Divided spell pays and enters stack");
            v(d.C(g.Stack,"size","()I").Int==1,"Paid spell was admitted to the stack");
            var stackEntry=d.C(g.Stack,"peek","()Lforge/game/spellability/SpellAbilityStackInstance;");
            var cast=d.C(stackEntry,"getSpellAbility","()Lforge/game/spellability/SpellAbility;");
            var targets=d.Items(d.C(cast,"getTargets","()Lforge/game/spellability/TargetChoices;"));
            int total=0;
            var damage=new List<(JValue Target,int Amount,bool Player,int Before)>();
            foreach(var target in targets)
            {
                int portion=g.Rt.UnboxInt(d.C(cast,"getDividedValue","(Lforge/game/GameObject;)Ljava/lang/Integer;",target));
                v(portion>=1,"Each chosen target receives positive damage");
                total+=portion;
                bool player=g.Rt.IsInstance(target.Reference!,"forge/game/player/Player");
                if(player||g.In(target,"Battlefield"))damage.Add((target,portion,player,d.C(target,player?"getLife":"getDamage","()I").Int));
            }
            v(total==(targets.Length==0?0:2),"Chosen targets account for all assigned damage");
            g.ResolveOne();
            foreach(var hit in damage)
                v(hit.Player?d.C(hit.Target,"getLife","()I").Int==hit.Before-hit.Amount:
                    d.C(hit.Target,"getDamage","()I").Int==hit.Before+hit.Amount,"Actual damage matches allocation");
            g.Sba();
            if(sacrifice)v(g.In(fodder,"Graveyard"),"Matching permanent was sacrificed");
        });

    public static void CatalogueNameRegression(string root,Action<bool,string> check)=>
        HostCases(root,"catalogue-name",check,(d,v,index,seed)=>{
            var g=d.g;
            var card=g.Card(index==0?"Change the Narrative":"The Disciple of Vess",0,"Battlefield");
            var sa=d.ScriptAbility(card,index==0?"TrigName":"DBName");
            d.C(sa,"resolve","()V");
            var name=d.C(card,"getNamedCard","()Ljava/lang/String;");
            v(name.Reference!=null&&g.Rt.StringValue(name).Length>0,"Random name exists");
            var db=d.C(d.S("forge/StaticData","instance","()Lforge/StaticData;"),"getCommonCards","()Lforge/card/CardDb;");
            var face=d.C(db,"getFaceByName","(Ljava/lang/String;)Lforge/card/ICardFace;",name);
            var type=d.C(face,"getType","()Lforge/card/CardType;");
            v(d.B(type,"isPlaneswalker"),"Selected a real planeswalker face");
            if(index==1)v(d.C(type,"hasStringType","(Ljava/lang/String;)Z",g.S("Liliana")).Int!=0,"Liliana subtype filter applied");
            else
            {
                var make=d.C(sa,"getSubAbility","()Lforge/game/spellability/AbilitySub;");
                d.S("forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V",make);
                var conjured=d.Zone(0,"Hand").Single();
                v(d.B(conjured,"isPlaneswalker")&&d.C(conjured,"hasKeyword","(Ljava/lang/String;)Z",g.S("Prismatic")).Int!=0,"Conjured planeswalker has perpetual prismatic");
            }
        });

    public static void SkipPumpRegression(string root,Action<bool,string> check)=>
        HostCases(root,"skip-turn-pump",check,(d,v,index,seed)=>{
            var g=d.g;
            var card=g.Card(index==0?"Chronatog":"Chronatog Totem",0,"Battlefield");
            var sa=d.Items(d.C(card,"getSpellAbilities","()Lforge/util/collect/FCollectionView;")).Single(a=>g.Rt.InspectEnumName(d.C(a,"getApi","()Lforge/game/ability/ApiType;"))=="Pump");
            d.C(g.Players[1],"setLife","(ILforge/game/spellability/SpellAbility;)Z",JValue.I(1),default);
            g.Card("Grizzly Bears",0,"Battlefield");
            v(!d.ShouldUseTurnSkipPump(card,sa),"Bot retains its next turn when an opponent at one life can be attacked");
            if(index==0)
            {
                d.C(g.Phase,"devModeSet","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;)V",g.Enum("forge/game/phase/PhaseType","COMBAT_DECLARE_BLOCKERS"),g.Players[0]);
                var combat=g.New("forge/game/combat/Combat","(Lforge/game/player/Player;)V",g.Players[0]);
                d.C(g.Phase,"setCombat","(Lforge/game/combat/Combat;)V",combat);
                d.C(combat,"addAttacker","(Lforge/game/card/Card;Lforge/game/GameEntity;)V",card,g.Players[1]);
                v(!d.ShouldUseTurnSkipPump(card,sa),"Unblocked attacker already deals lethal without skipping");
                d.C(g.Players[1],"setLife","(ILforge/game/spellability/SpellAbility;)Z",JValue.I(4),default);
                v(d.ShouldUseTurnSkipPump(card,sa),"Unblocked +3 power can win this combat");
            }
        });
}

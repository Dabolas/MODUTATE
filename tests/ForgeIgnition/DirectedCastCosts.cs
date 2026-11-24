using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    public static void DirectedCastCosts(string root,Action<bool,string> check)
    {
        HostCases(root,"directed-target-tax",check,(d,verify,extra,seed)=>{
            var g=d.g;
            bool fireball=seed%2==0;
            var creature=g.Card("Grizzly Bears",1,"Battlefield");
            var card=g.Card(fireball?"Fireball":"Officious Interrogation",0,"Hand");
            var sa=g.Ability(card,0);
            if(fireball)d.C(sa,"setXManaCostPaid","(Ljava/lang/Integer;)V",g.Rt.BoxInt(2));
            string mana=fireball?(extra==1?"RCCC":"RCC"):(extra==1?"WUWU":"WU");
            g.Fund(0,mana);
            d.C(sa,"clearTargets","()V");g.Target(sa,g.Players[1],fireball?creature:g.Players[0]);
            verify(d.CanFundVariant(sa,0)==(extra==1)&&g.ManaCount(0)==mana.Length,"Second target has the printed cost and the quote preserves all mana");
            verify(d.Play(sa,0),"Cast transaction can choose an affordable number of targets");
            var stacked=d.Items(g.Stack).Single();
            var instance=d.C(stacked,"getSpellAbility","()Lforge/game/spellability/SpellAbility;");
            var targets=d.C(instance,"getTargets","()Lforge/game/spellability/TargetChoices;");
            int count=d.C(targets,"size","()I").Int;
            verify(count<=1+extra,"Engine only accepted targets whose surcharge could be paid");
            verify(g.ManaCount(0)==mana.Length-(fireball?3:2)-(count>1?(fireball?1:2):0),"Committed mana matches the chosen number of targets");
        });
        HostCases(root,"directed-escalate",check,(d,verify,extra,seed)=>{
            var g=d.g;bool grace=seed%2==0;
            var creature=g.Card("Grizzly Bears",0,"Battlefield");
            var opponent=grace?g.Card("Hill Giant",1,"Battlefield"):default;
            var spell=g.Card(grace?"Borrowed Grace":"Borrowed Hostility",0,"Hand");
            var sa=g.Ability(spell,0);
            string mana=grace?(extra==1?"WWCCC":"WCC"):(extra==1?"RCCC":"R");
            g.Fund(0,mana);
            var modes=d.LegalModes(d.Items(d.S("forge/game/ability/effects/CharmEffect","makePossibleOptions","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",sa)));
            var legal=d.AffordableModes(sa,modes,1,2).ToArray();
            verify(legal.Length==2+extra&&legal.Any(set=>set.Length==2)==(extra==1),"Only the extra payment permits both modes");
            bool first=extra==1||seed<=2;
            bool second=extra==1||seed>2;
            g.SetDecision("chooseModeForAbility",(ctrl,args)=>{
                var offered=d.LegalModes(d.Items(args[1]));
                var selected=d.AffordableModes(args[0],offered,args[2].Int,args[3].Int)
                    .Single(set=>extra==1?set.Length==2:set.Length==1&&set[0].Reference==offered[first?0:1].Reference);
                return JHostResult.Complete(g.Rt.ListOf(selected));
            });
            d.Snapshot("before Escalate cast");
            verify(g.ManaCount(0)==mana.Length&&d.Play(sa,0)&&g.In(spell,"Stack"),"Escalate quote preserves mana and selected spell enters the stack");
            verify(g.ManaCount(0)==0,"Paid exactly the base cost plus the printed surcharge for the second mode");
            g.Drain();
            verify(g.In(spell,"Graveyard")&&d.C(g.Current(creature),"getNetPower","()I").Int==2+(first?(grace?2:3):0),"Resolved spell reaches graveyard and power matches the selected modes");
            verify(d.C(g.Current(creature),"getNetToughness","()I").Int==2+(grace&&second?2:0),"Resolved toughness matches Borrowed Grace mode selection");
            verify((d.C(g.Current(creature),"hasKeyword","(Ljava/lang/String;)Z",g.S("First Strike")).Int!=0)==(!grace&&second),"First strike matches Borrowed Hostility mode selection");
            if(grace)verify(d.C(g.Current(opponent),"getNetPower","()I").Int==3&&d.C(g.Current(opponent),"getNetToughness","()I").Int==3,"Borrowed Grace leaves the opposing Hill Giant at 3/3");
        });
        HostCases(root,"directed-x-kicker",check,(d,verify,extra,seed)=>{
            var g=d.g;bool golem=seed%2==0;
            var card=g.Card(golem?"Emblazoned Golem":"Thieving Skydiver",0,"Hand");
            if(!golem)g.Card("Ornithopter",1,"Battlefield");
            var sa=g.Ability(card,0);
            var options=d.Items(d.S("forge/game/GameActionUtil","getOptionalCostValues","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",sa));
            string mana=golem?(extra==1?"CCRG":"CCRR"):(extra==1?"UCC":"UC");
            g.Fund(0,mana);
            var legal=d.OptionalCostOptions(sa,options,0);
            verify(legal.Any(set=>set.Length>0)==(golem||extra==1)&&g.ManaCount(0)==mana.Length,"Before X is announced, probe the actual minimum for the optional cost");
            if(golem){
                var kicked=d.S("forge/game/GameActionUtil","addOptionalCosts","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)Lforge/game/spellability/SpellAbility;",sa,g.Rt.ListOf(options));
                d.C(kicked,"setXManaCostPaid","(Ljava/lang/Integer;)V",g.Rt.BoxInt(2));
                verify(d.CanFundVariant(kicked,0)==(extra==1),"Two X shards may use two different colors and reject repeated red");
            }
            g.SetDecision("chooseOptionalCosts",(ctrl,a)=>JHostResult.Complete(g.Rt.ListOf(d.OptionalCostOptions(a[0],d.Items(a[1]),0).OrderByDescending(set=>set.Length).First())));
            verify(d.Play(sa,0),"Selected X kicker option completes the actual cast");
            g.ResolveOne();g.Sba();g.Drain();
            verify(g.In(card,"Battlefield"),"Creature enters after the full X kicker transaction");
        });
    }
}

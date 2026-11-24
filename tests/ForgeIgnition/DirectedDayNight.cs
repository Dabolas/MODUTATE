using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    public static void DirectedTeamDayNight(string root,Action<bool,string> check)=>
        HostCases(root,"directed-team-day-night",check,(d,verify,night,scenario)=>{
            var g=d.g;
            bool Allies(int seat)=>d.C(g.Players[0],"sharesTeamWith","(Lforge/game/player/Player;)Z",g.Players[seat]).Int!=0;
            verify(Allies(1)&&!Allies(2)&&!Allies(3),"Four registered players form two teams");
            d.C(g.Game,"setDayTime","(Ljava/lang/Boolean;)V",d.S("java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;",JValue.I(night)));
            int[] casters=scenario switch {1=>[0,1],2=>[1,1],3=>[2,3],_=>[0]};
            for(int i=0;i<casters.Length;i++){
                int seat=casters[i];
                var spell=g.Card(i==0?"Shock":"Lightning Bolt",seat,"Hand");
                var ability=g.Ability(spell,seat);g.Target(ability,g.Players[seat<2?2:0]);g.Fund(seat,"R");
                verify(g.Cast(spell,ability,seat),"Real spell cast by seat "+seat);g.ResolveOne();
            }
            d.C(g.Stack,"onNextTurn","()V");
            var logged=d.Items(d.C(g.Stack,"getSpellsCastLastTurn","()Ljava/util/List;"));
            verify(logged.Select(card=>d.Seat(d.C(card,"getController","()Lforge/game/player/Player;"))).SequenceEqual(casters),"Cast ledger preserves each caster");
            g.SetMain(2);g.Rt.PutField(g.Phase,"forge/game/phase/PhaseHandler","playerPreviousTurn","Lforge/game/player/Player;",g.Players[0]);
            d.C(d.C(g.Game,"getUntap","()Lforge/game/phase/Untap;"),"executeAt","()V");
            bool expectedNight=night==1?scenario!=2:scenario==3;
            verify(d.B(g.Game,"isNight")==expectedNight,"CR 502.2a: starting night="+night+", casters="+string.Join(",",casters)+", expected night="+expectedNight);
        },twoHeadedGiant:true);

    public static void DirectedDayNight(string root,Action<bool,string> check)
    {
        HostCases(root,"directed-day-night",check,(d,verify,variant,scenario)=>{
            var g=d.g;
            bool IsDay()=>d.B(g.Game,"isDay");
            bool IsNight()=>d.B(g.Game,"isNight");
            void SetNight(bool night)=>d.C(g.Game,"setDayTime","(Ljava/lang/Boolean;)V",
                d.S("java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;",JValue.I(night?1:0)));
            int StackSize()=>d.C(g.Stack,"size","()I").Int;
            JValue Cast(string name,string mana){
                var card=g.Card(name,0,"Hand");
                g.Fund(0,mana);
                verify(d.Play(g.Ability(card,0),0),"Cast "+name);
                g.ResolveOne();g.Sba();g.Drain();
                return g.Current(card);
            }
            if(scenario==1){
                if(variant==1)SetNight(true);
                int life=g.Life(0);
                Cast("The Celestus","CCC");
                verify(variant==0?IsDay():IsNight(),"Celestus establishes day only if no designation existed");
                verify(g.Life(0)==life&&g.Count(0,"Hand")==0&&StackSize()==0,"Entering does not trigger the day-to-night reward");
                string name=variant==0?"Kessig Naturalist":"Suspicious Stowaway";
                var creature=Cast(name,variant==0?"RG":"CU");
                verify(d.B(creature,"isBackSide")==(variant==1),"Daybound creature enters on the face matching the global designation");
                return;
            }
            if(scenario==2){
                var celestus=Cast("The Celestus","CCC");
                var sa=d.Items(d.C(celestus,"getSpellAbilities","()Lforge/util/collect/FCollectionView;"))
                    .Single(a=>g.Rt.InspectEnumName(d.C(a,"getApi","()Lforge/game/ability/ApiType;"))=="DayTime");
                d.C(sa,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);
                g.Fund(0,"CC");
                verify(!d.CanOfferAction(celestus,sa,0),"Two mana cannot pay for the switch");
                g.Fund(0,"C");g.SetMain(1);
                verify(!d.CanOfferAction(celestus,sa,0),"Switch is unavailable during the opponent's main phase");
                g.SetMain(0);
                var top=g.Card("Forest",0,"Library");
                if(variant==1)g.Card("Maralen of the Mornsong",1,"Battlefield");
                int life=g.Life(0);
                verify(d.CanOfferAction(celestus,sa,0)&&d.Play(sa,0),"Three mana and an untapped Celestus pay for its sorcery-speed switch");
                verify(IsDay()&&d.B(celestus,"isTapped")&&g.ManaCount(0)==0,"Tapping and payment precede the change of designation");
                g.ResolveOne();g.Sba();
                verify(IsNight()&&StackSize()==1&&g.Life(0)==life,"One life-gain trigger awaits resolution");
                g.Drain();
                verify(g.Life(0)==life+1&&(variant==0||g.In(top,"Library")),"Gain life even when drawing is prohibited");
                g.Fund(0,"CCC");
                verify(!d.CanOfferAction(celestus,sa,0),"A tapped Celestus cannot switch again");
                return;
            }
            bool night=scenario==4;
            SetNight(night);
            string werewolf=variant==0?"Kessig Naturalist":"Suspicious Stowaway";
            var transforming=Cast(werewolf,variant==0?"RG":"CU");
            // Move setup casts out of the turn being measured. Exercise the actual
            // stack cast ledger, its rollover, and the engine's entire untap step.
            d.C(g.Stack,"onNextTurn","()V");
            int activeCasts=night?variant+1:variant;
            for(int seat=0;seat<=1;seat++){
                int count=seat==0?activeCasts:2;
                for(int n=0;n<count;n++){
                    var spell=g.Card("Lightning Bolt",seat,"Hand");
                    var ability=g.Ability(spell,seat);g.Target(ability,g.Players[1-seat]);g.Fund(seat,"R");
                    verify(g.Cast(spell,ability,seat),"Real instant counted for its caster");
                    g.ResolveOne();
                }
            }
            d.C(g.Stack,"onNextTurn","()V");
            verify(d.Items(d.C(g.Stack,"getSpellsCastLastTurn","()Ljava/util/List;")).Length==activeCasts+2,"Last-turn ledger contains precisely the casts in the measured turn");
            g.SetMain(1);
            g.Rt.PutField(g.Phase,"forge/game/phase/PhaseHandler","playerPreviousTurn","Lforge/game/player/Player;",g.Players[0]);
            var untap=d.C(g.Game,"getUntap","()Lforge/game/phase/Untap;");
            d.C(untap,"executeAt","()V");g.Sba();g.Drain();
            bool expectedNight=night?activeCasts<2:activeCasts==0;
            verify(IsNight()==expectedNight&&IsDay()!=expectedNight,"Only the prior active player's cast count determines day or night");
            verify(d.B(g.Current(transforming),"isBackSide")==expectedNight,"Bound permanent tracks the result of the real untap check");
        });
    }

    public static void DirectedCastHistory(string root,Action<bool,string> check)=>
        HostCases(root,"directed-cast-history",check,(d,verify,countered,seed)=>{
            var g=d.g;
            d.C(g.Game,"setDayTime","(Ljava/lang/Boolean;)V",d.S("java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;",JValue.I(1)));
            int caster=countered==1?0:1;
            var bolt=g.Card(seed%2==0?"Lightning Bolt":"Shock",caster,"Hand");
            var target=g.Ability(bolt,caster);g.Fund(caster,"R");g.Target(target,g.Players[1-caster]);
            verify(g.Cast(bolt,target,caster),"Damage spell cast");
            int responder=1-caster;
            var answer=g.Card(countered==1?"Counterspell":"Twincast",responder,"Hand");
            var sa=g.Ability(answer,responder);g.Fund(responder,"UU");g.Target(sa,target);
            verify(g.Cast(answer,sa,responder),"Cast response targeting original spell");
            g.ResolveOne();g.Sba();
            int pending=d.C(g.Stack,"size","()I").Int;
            verify(pending==(countered==1?0:2),"Counterspell removed its target or Twincast left the copy and original pending");
            g.Drain();
            if(countered==1){
                verify(g.In(bolt,"Graveyard")&&g.Life(1)==20,"Countered damage spell did not resolve");
                var extra=g.Card("Shock",0,"Hand");var spell=g.Ability(extra,0);
                g.Fund(0,"R");g.Target(spell,g.Players[1]);verify(g.Cast(extra,spell,0),"Second spell of the active player cast");g.ResolveOne();
            }
            d.C(g.Stack,"onNextTurn","()V");
            var cards=d.Items(d.C(g.Stack,"getSpellsCastLastTurn","()Ljava/util/List;"));
            verify(cards.Length==(countered==1?3:2),"Only real casts entered the cast ledger");
            g.SetMain(1);g.Rt.PutField(g.Phase,"forge/game/phase/PhaseHandler","playerPreviousTurn","Lforge/game/player/Player;",g.Players[0]);
            d.C(d.C(g.Game,"getUntap","()Lforge/game/phase/Untap;"),"executeAt","()V");
            verify(d.B(g.Game,"isDay")==(countered==1),"A countered cast counts toward daybreak; a stack copy does not");
        });

    public static void DirectedCelestusLoot(string root,Action<bool,string> check)
    {
        bool accepted=false,declined=false;
        HostCases(root,"directed-celestus-loot",check,(d,verify,blocked,seed)=>{
            var g=d.g;
            var card=g.Card("The Celestus",0,"Hand");g.Fund(0,"CCC");
            verify(d.Play(g.Ability(card,0),0),"Celestus cast");g.ResolveOne();g.Sba();g.Drain();
            var top=g.Card("Island",0,"Library");
            if(blocked==1)g.Card("Maralen of the Mornsong",1,"Battlefield");
            d.C(g.Game,"setDayTime","(Ljava/lang/Boolean;)V",d.S("java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;",JValue.I(1)));
            g.Sba();g.Drain();
            int draws=d.C(g.Players[0],"getNumDrawnThisTurn","()I").Int;
            var discarded=d.Items(d.C(g.Players[0],"getDiscardedThisTurn","()Ljava/util/List;"));
            verify(g.Life(0)==21&&draws is 0 or 1,"One life gained whether or not the draw was paid");
            verify(discarded.Length==draws&&g.Count(0,"Hand")==0,"One discard for each successful optional draw");
            if(draws==1){
                verify(blocked==0&&g.In(top,"Graveyard")&&d.C(discarded[0],"getId","()I").Int==d.C(top,"getId","()I").Int,"The known top card was drawn and then discarded");
                accepted=true;
            }else{
                verify(g.In(top,"Library"),"With no draw, the known top card stays in the library");
                if(blocked==0)declined=true;
            }
        });
        check(accepted&&declined,"Both legal optional choices were exercised without a draw prohibition");
    }
}

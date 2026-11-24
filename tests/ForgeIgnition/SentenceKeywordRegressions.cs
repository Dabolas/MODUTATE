using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    public static void SentenceKeywordRegression(string root,Action<bool,string> check)
    {
        HostCases(root,"sentence-keyword-damage",check,(d,v,control,scenario)=>{
            var g=d.g;
            bool ogre=control==0;
            var target=g.Card(ogre?"Ogre Enforcer":"Rumbling Baloth",1,"Battlefield");
            v(d.C(target,"getNetToughness","()I").Int==4,"Both damage fixtures start at four toughness");
            void ResolveSpell(string name,string mana)
            {
                var spell=g.Card(name,0,"Hand");
                var sa=g.Ability(spell,0);
                g.Fund(0,mana);g.Target(sa,target);
                v(g.Cast(spell,sa,0),"Cast "+name+" targeting the test creature");
                g.ResolveOne();
            }
            if(scenario==1){
                ResolveSpell("Shock","R");g.Sba();
                v(g.In(target,"Battlefield")&&d.C(target,"getDamage","()I").Int==2,"First Shock is sublethal");
                ResolveSpell("Shock","R");
                v(d.C(target,"getDamage","()I").Int==4&&d.C(target,"getMaxDamageFromSource","()I").Int==2,"Two distinct cards with identical names retain separate damage totals");
                g.Sba();
                v(g.In(target,ogre?"Battlefield":"Graveyard"),"Only Ogre survives lethal total from two distinct sources");
            }else if(scenario==2){
                var pyro=g.Card("Pyrohemia",0,"Battlefield");
                for(int n=1;n<=4;n++){
                    g.Fund(0,"R");var sa=d.ActivatedAbility(pyro);
                    v(d.Play(sa,0),"Pay R and activate the same Pyrohemia permanent");
                    g.ResolveOne();
                    v(d.C(target,"getMaxDamageFromSource","()I").Int==n,"Repeated damage from the same permanent accumulates");
                    g.Sba();
                    v(g.In(target,n<4?"Battlefield":"Graveyard"),"Single source becomes lethal on its fourth activation");
                }
            }else{
                if(scenario==3)ResolveSpell("Flame Slash","R");
                else ResolveSpell("Murder","B B C");
                g.Sba();
                v(g.In(target,"Graveyard"),"Single lethal hit and unconditional destroy both remove the creature");
            }
        });
        HostCases(root,"sentence-keyword-attacks",check,(d,v,withPartner,seed)=>{
            var g=d.g;
            var restricted=g.Card(seed%2==0?"Bonded Construct":"Militia Rallier",0,"Battlefield");
            var partner=g.Card("Grizzly Bears",0,"Battlefield");
            foreach(var card in new[]{restricted,partner})d.C(card,"setSickness","(Z)V",JValue.I(0));
            d.C(g.Phase,"devModeSet","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;)V",g.Enum("forge/game/phase/PhaseType","COMBAT_DECLARE_ATTACKERS"),g.Players[0]);
            var combat=g.New("forge/game/combat/Combat","(Lforge/game/player/Player;)V",g.Players[0]);
            d.C(g.Phase,"setCombat","(Lforge/game/combat/Combat;)V",combat);
            d.C(combat,"addAttacker","(Lforge/game/card/Card;Lforge/game/GameEntity;)V",restricted,g.Players[1]);
            if(withPartner==1)d.C(combat,"addAttacker","(Lforge/game/card/Card;Lforge/game/GameEntity;)V",partner,g.Players[1]);
            bool legal=d.S("forge/game/combat/CombatUtil","validateAttackers","(Lforge/game/combat/Combat;)Z",combat).Int!=0;
            v(legal==(withPartner==1),"Original combat constraints reject solo attack and allow attacking with another creature");
        });
        HostCases(root,"sentence-keyword-blocks",check,(d,v,selectSecond,seed)=>{
            var g=d.g;
            var first=g.Card("Grizzly Bears",1,"Battlefield");
            var second=g.Card("Rumbling Baloth",1,"Battlefield");
            bool CanBlock(JValue card)=>d.S("forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;)Z",card).Int!=0;
            v(CanBlock(first)&&CanBlock(second),"Both untapped creatures can initially block");
            bool panic=seed%2==0;
            var spell=g.Card(panic?"Panic Attack":"Abandon the Post",0,"Hand");
            var sa=g.Ability(spell,0);
            g.Fund(0,panic?"R C C":"R C");
            g.Target(sa,first);
            if(selectSecond==1)g.Target(sa,second);
            v(g.Cast(spell,sa,0),"Cast real spell with selected creatures");
            g.ResolveOne();
            v(!CanBlock(first)&&CanBlock(second)==(selectSecond==0),"Only selected creatures lose permission to block");
            var end=g.Call(g.Game,"getEndOfTurn","()Lforge/game/phase/Phase;");
            d.C(end,"executeUntil","()V");
            v(CanBlock(first)&&CanBlock(second),"Both creatures regain permission after the engine removes end-of-turn effects");
        });
    }
}

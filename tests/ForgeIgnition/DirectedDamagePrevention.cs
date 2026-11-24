using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    public static void DirectedDamagePrevention(string root,Action<bool,string> check)
    {
        foreach(string direction in new[]{"incoming","outgoing","both"}){
            HostCases(root,"prevention-"+direction,check,(d,verify,combatOnly,scenario)=>{
                var g=d.g;
                bool combat=scenario<=2,second=scenario%2==0;
                var other=g.Card("Rumbling Baloth",0,"Battlefield");
                JValue affected;
                if(direction=="incoming"){
                    string name=combatOnly==1?(second?"Everdawn Champion":"Guard Gomazoa"):(second?"Dawn Elemental":"Cho-Manno, Revolutionary");
                    affected=g.Card(name,1,"Battlefield");
                }else if(direction=="both"&&combatOnly==1&&!second){
                    affected=g.Card("Fog Bank",1,"Battlefield");
                }else{
                    affected=g.Card("Hill Giant",1,"Battlefield");
                    if(direction=="both"&&combatOnly==0){
                        string name=second?"Kiora, the Crashing Wave":"Dovin, Hand of Control";
                        var walker=g.Card(name,0,"Hand");g.Fund(0,second?"CCGU":"CCW");
                        verify(d.Play(g.Ability(walker,0),0),"Cast "+name);g.ResolveOne();g.Sba();g.Drain();
                        var ability=d.Items(d.C(g.Current(walker),"getSpellAbilities","()Lforge/util/collect/FCollectionView;"))
                            .Single(sa=>g.Rt.InspectEnumName(d.C(sa,"getApi","()Lforge/game/ability/ApiType;"))=="Pump");
                        d.C(ability,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);
                        verify(d.Play(ability,0),"Pay the loyalty cost and target the opponent's creature");g.ResolveOne();
                    }else{
                        (string name,string mana)=direction=="both"?("Ghostly Possession","CCW"):
                            combatOnly==1?(second?("Hunter's Ambush","CCG"):("Subdue","G")):
                            (second?("Chain of Silence","CW"):("Soul Parry","CW"));
                        var spell=g.Card(name,0,"Hand");g.Fund(0,mana);
                        var ability=g.Ability(spell,0);if(d.B(ability,"usesTargeting"))g.Target(ability,affected);
                        verify(g.Cast(spell,ability,0),"Cast "+name);g.ResolveOne();g.Sba();g.Drain();
                    }
                }
                d.C(g.Action,"checkStaticAbilities","()V");
                var damage=g.New("forge/game/card/CardDamageTable","()V");
                void Assign(JValue source,JValue target)=>d.C(damage,"put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;",source,target,g.Rt.BoxInt(1));
                Assign(affected,other);Assign(other,affected);
                d.C(g.Action,"dealDamage","(ZLforge/game/card/CardDamageTable;Lforge/game/card/CardDamageTable;Lforge/game/GameEntityCounterTable;Lforge/game/spellability/SpellAbility;)V",
                    JValue.I(combat?1:0),damage,g.New("forge/game/card/CardDamageTable","()V"),g.New("forge/game/GameEntityCounterTable","()V"),JValue.R(null));
                bool applies=combat||combatOnly==0;
                verify(d.C(affected,"getDamage","()I").Int==(applies&&direction!="outgoing"?0:1),"Incoming damage matches the duration and direction of the printed prevention");
                verify(d.C(other,"getDamage","()I").Int==(applies&&direction!="incoming"?0:1),"Outgoing damage matches the duration and direction of the printed prevention");
            });
        }
    }
}

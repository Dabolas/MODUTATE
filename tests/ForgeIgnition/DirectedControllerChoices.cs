using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    public static void DirectedControllerChoices(string root,Action<bool,string> check)=>
        HostCases(root,"directed-controller-options",check,(d,verify,sector,scenario)=>{
            var g=d.g;
            var target=g.Card("Grizzly Bears",0,"Battlefield");
            var other=g.Card("Hill Giant",1,"Battlefield");
            if(sector==1){
                var card=g.Card("Space Beleren",0,"Hand");
                g.Fund(0,"CCWU");verify(d.Play(g.Ability(card,0),0),"Cast Space Beleren");
                g.ResolveOne();g.Sba();g.Drain();var walker=g.Current(card);
                bool Offered(string choice)=>choice is "Alpha" or "Beta" or "Gamma";
                string Sector(JValue creature)=>g.Rt.StringValue(d.C(creature,"getSector","()Ljava/lang/String;"));
                verify(Offered(Sector(target))&&Offered(Sector(other)),"The original state-based action assigns both teams' creatures to offered sectors");
                var ability=d.Items(d.C(walker,"getSpellAbilities","()Lforge/util/collect/FCollectionView;"))
                    .First(sa=>g.Rt.InspectEnumName(d.C(sa,"getApi","()Lforge/game/ability/ApiType;"))=="ChooseSector");
                d.C(ability,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);
                verify(d.Play(ability,0),"Activate sector selection");g.ResolveOne();g.Sba();
                var picked=g.Rt.StringValue(d.C(walker,"getChosenSector","()Ljava/lang/String;"));
                verify(Offered(picked),"The selected sector came from the offered sectors");
                var counter=d.S("forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;",g.S("P1P1"));
                foreach(var creature in new[]{target,other})
                    verify(d.C(creature,"getCounters","(Lforge/game/card/CounterType;)I",counter).Int==(Sector(creature)==picked?1:0),"Only creatures in the chosen sector received a counter");
            }else{
                var ally=g.Card("Llanowar Elves",0,"Battlefield");
                bool radiance=scenario%2==0;
                var card=g.Card(radiance?"Bathe in Light":"Blessed Breath",0,"Hand");
                g.Fund(0,radiance?"CW":"W");var sa=g.Ability(card,0);g.Target(sa,target);
                verify(g.Cast(card,sa,0),"Cast a real protection spell");g.ResolveOne();g.Sba();g.Drain();
                string[] Protections(JValue creature)=>d.Items(d.C(creature,"getKeywords","()Ljava/util/List;"))
                    .Select(kw=>g.Rt.StringValue(d.C(kw,"getOriginal","()Ljava/lang/String;")))
                    .Where(kw=>kw.StartsWith("Protection from ",StringComparison.Ordinal)).ToArray();
                var protection=Protections(target);
                verify(protection.Length==1&&new[]{"white","blue","black","red","green"}.Contains(protection[0]["Protection from ".Length..].ToLowerInvariant()),"The selected protection is an offered color");
                verify(Protections(other).Length==0&&Protections(ally).SequenceEqual(radiance?protection:[]),"Radiance grants the same choice only to the creature sharing the target's color");
            }
        });
}

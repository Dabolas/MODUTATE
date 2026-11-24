using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    public static void MeldCatalogueRegression(string root,Action<bool,string> check)=>
        HostCases(root,"meld-catalogue",check,(d,verify,pair,seed)=>{
            var game=d.g;
            var (front,partner,back,power,toughness)=pair==0
                ? ("Midnight Scavengers","Graf Rats","Chittering Host",5,6)
                : ("Hanweir Garrison","Hanweir Battlements","Hanweir, the Writhing Township",7,4);
            var card=game.Card(front,0,"Library");
            var state=d.C(card,"getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;",game.Enum("forge/card/CardStateName","Meld"));
            verify(game.In(card,"Library")&&game.Rt.StringValue(d.C(card,"getName","()Ljava/lang/String;"))==front,"Deck construction preserves the original face");
            verify(game.Rt.StringValue(d.C(state,"getName","()Ljava/lang/String;"))==back,"CardFactory reads the partner's real meld face");
            verify(d.C(state,"getBasePower","()I").Int==power&&d.C(state,"getBaseToughness","()I").Int==toughness,"Meld face has its printed power and toughness");
            var catalogue=d.C(d.S("forge/StaticData","instance","()Lforge/StaticData;"),"getCommonCards","()Lforge/card/CardDb;");
            JValue Lookup(string name,bool allowAlternate)=>d.C(catalogue,"getRules","(Ljava/lang/String;Z)Lforge/card/CardRules;",game.S(name),JValue.I(allowAlternate?1:0));
            var primary=Lookup(partner.ToLowerInvariant(),false);
            verify(primary.Reference!=null&&ReferenceEquals(primary.Reference,Lookup(back,true).Reference),"Permitted alternate name and case-insensitive primary name resolve to the same rules");
            verify(Lookup(back,false).Reference==null&&Lookup("missing fixture card name",true).Reference==null,"Primary-only and absent-name lookup preserve absence");
        });
}

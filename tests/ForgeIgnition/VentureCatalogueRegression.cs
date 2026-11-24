using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    public static void VentureCatalogueRegression(string root,Action<bool,string> check)=>
        HostCases(root,"venture-catalogue",check,(d,verify,order,seed)=>{
            var g=d.g;
            foreach(var name in new[]{"Island","Forest","Plains"})g.Card(name,0,"Library");
            string[] cards=order==0?["Cloister Gargoyle","Displacer Beast"]:["Displacer Beast","Cloister Gargoyle"];
            JValue previous=default;
            string previousRoom="";
            for(int i=0;i<cards.Length;i++)
            {
                int life=g.Life(0),opponentLife=g.Life(1);
                var card=g.Card(cards[i],0,"Hand");
                g.Fund(0,cards[i]=="Cloister Gargoyle"?"C C W":"C C U");
                verify(d.Play(g.Ability(card,0),0),"Cast "+cards[i]);
                g.ResolveOne();g.Sba();g.Drain();
                var dungeon=d.Zone(0,"Command").Single(c=>d.B(d.C(c,"getType","()Lforge/card/CardTypeView;"),"isDungeon"));
                string room=g.Rt.StringValue(d.C(dungeon,"getCurrentRoom","()Ljava/lang/String;"));
                var rooms=d.Items(d.C(dungeon,"getTriggers","()Lforge/util/collect/FCollectionView;"))
                    .Select(t=>d.C(t,"getOverridingAbility","()Lforge/game/spellability/SpellAbility;")).ToArray();
                string Param(JValue sa,string key)=>g.Rt.StringValue(d.C(sa,"getParam","(Ljava/lang/String;)Ljava/lang/String;",g.S(key)));
                verify(d.C(g.Players[0],"getVenturedThisTurn","()I").Int==i+1,"Each real ETB ventures once");
                if(i==0)
                {
                    verify(room==Param(rooms[0],"RoomName"),"Enters printed first room");
                    var rules=d.C(d.C(dungeon,"getPaperCard","()Lforge/item/IPaperCard;"),"getRules","()Lforge/card/CardRules;");
                    verify(d.B(rules,"isEnterableDungeon"),"Ordinary venture selects an enterable dungeon");
                    if(room=="Trapped Entry")verify(g.Life(0)==life-1&&g.Life(1)==opponentLife-1,"Trapped Entry resolves its loss of one life for each player");
                    if(room=="Yawning Portal")verify(g.Life(0)==life+1&&g.Life(1)==opponentLife,"Yawning Portal resolves its life gain for the venturing player");
                }
                else
                {
                    verify(ReferenceEquals(previous.Reference,dungeon.Reference),"Second venture keeps the dungeon in command");
                    var from=rooms.Single(sa=>Param(sa,"RoomName")==previousRoom);
                    verify(Param(from,"NextRoomName").Split(',').Contains(room),"Advances along a printed room connection");
                }
                previous=dungeon;previousRoom=room;
            }
        });
}

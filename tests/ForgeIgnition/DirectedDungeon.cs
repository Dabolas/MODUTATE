using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    public static void DirectedDungeon(string root,Action<bool,string> check)
    {
        HostCases(root,"directed-dungeon",check,(d,verify,route,scenario)=>{
            var g=d.g;var player=g.Players[0];
            var library=new[]{"Forest","Plains","Island","Mountain","Swamp","Grizzly Bears"};
            foreach(var name in library)g.Card(name,0,"Library");
            JValue[] Dungeons()=>d.Zone(0,"Command").Where(c=>d.B(d.C(c,"getType","()Lforge/card/CardTypeView;"),"isDungeon")).ToArray();
            JValue[] Completed()=>d.Items(d.C(player,"getCompletedDungeons","()Ljava/util/List;"));
            string Name(JValue c)=>g.Rt.StringValue(d.C(c,"getName","()Ljava/lang/String;"));
            string Room(JValue dungeon)=>g.Rt.StringValue(d.C(dungeon,"getCurrentRoom","()Ljava/lang/String;"));
            int Visits()=>d.C(player,"getVenturedThisTurn","()I").Int;
            void Enter(string name,string mana){
                var source=g.Card(name,0,"Hand");
                g.Fund(0,mana);
                verify(d.Play(g.Ability(source,0),0),"Cast "+name);
                g.ResolveOne();g.Sba();g.Drain();
            }
            string initiator=route==0?"White Plume Adventurer":"Passageway Seer";
            string initiateMana=route==0?"CCW":"CCCB";
            string explorer=scenario%2==0?"Displacer Beast":"Cloister Gargoyle";
            string exploreMana=scenario%2==0?"CCU":"CCW";
            if(scenario==1){
                Enter(explorer,exploreMana);
                var ordinary=Dungeons().Single();string before=Room(ordinary);
                verify(Name(ordinary)!="Undercity"&&Visits()==1,"Ordinary venture enters an ordinary dungeon");
                Enter(initiator,initiateMana);
                verify(Dungeons().Length==1&&ReferenceEquals(ordinary.Reference,Dungeons()[0].Reference)&&before!=Room(ordinary)&&Visits()==2,
                    "Taking the initiative inside an existing dungeon advances that dungeon");
                return;
            }
            string wanted=route==0?"Forge":"Lost Well";
            // The controller selects only an option the engine actually offered.
            // Exercise each printed branch directly instead of hoping for both.
            g.SetDecision("chooseSingleSpellForEffect",(ctrl,args)=>{
                var offered=d.Items(args[0]);
                if(offered.Length==0)throw new InvalidOperationException("Empty ability choice");
                var room=offered.FirstOrDefault(a=>{
                    var param=d.C(a,"getParam","(Ljava/lang/String;)Ljava/lang/String;",g.S("RoomName"));
                    return param.Reference!=null&&g.Rt.StringValue(param)==wanted;
                });
                return JHostResult.Complete(room.Reference!=null?room:offered[0]);
            });
            Enter(initiator,initiateMana);
            var dungeon=Dungeons().Single();
            verify(Name(dungeon)=="Undercity"&&Room(dungeon)=="Secret Entrance"&&Visits()==1,"Initiative from outside enters the first room of Undercity");
            Enter(explorer,exploreMana);
            verify(ReferenceEquals(dungeon.Reference,Dungeons().Single().Reference)&&Room(dungeon)==wanted&&Visits()==2,"Ordinary venture follows the selected printed branch inside Undercity");
            if(scenario==2)return;
            string previous=Room(dungeon);
            for(int step=3;step<=5;step++){
                var triggers=d.Items(d.C(dungeon,"getTriggers","()Lforge/util/collect/FCollectionView;"));
                var roomAbilities=triggers.Select(t=>d.C(t,"getOverridingAbility","()Lforge/game/spellability/SpellAbility;"));
                string Param(JValue a,string key)=>g.Rt.StringValue(d.C(a,"getParam","(Ljava/lang/String;)Ljava/lang/String;",g.S(key)));
                var from=roomAbilities.Single(a=>Param(a,"RoomName")==previous);
                var successors=Param(from,"NextRoomName").Split(',');
                wanted=scenario==3?successors.First():successors.Last();
                Enter(explorer,exploreMana);
                verify(Visits()==step&&Room(dungeon)==wanted,"Exactly one printed edge followed per venture");
                if(step<5)verify(Completed().Length==0&&Dungeons().Length==1,"Dungeon stays in command until its final room");
                previous=wanted;
            }
            verify(previous=="Throne of the Dead Three"&&Completed().Length==1&&Name(Completed()[0])=="Undercity"&&Dungeons().Length==0,
                "Final room completes Undercity exactly once and removes it from command");
            Enter(explorer,exploreMana);
            verify(Visits()==6&&Name(Dungeons().Single())!="Undercity"&&Completed().Length==1,"A new ordinary venture begins a new dungeon after completion");
        });
    }
}

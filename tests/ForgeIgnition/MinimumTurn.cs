using System.Text.Json;
using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;

public static class MinimumTurn
{
    public static int Run(string root)
    {
        string dir=BatchPaths.Output(root,"release/forge-turn");
        Directory.CreateDirectory(dir);
        string gate=BatchPaths.Output(root,"release/forge-l3/minimum-playable-state.json");
        Directory.CreateDirectory(Path.GetDirectoryName(gate)!);
        File.WriteAllText(gate,"{\"executed\":true,\"passed\":false,\"status\":\"running\",\"playable\":false}");
        L3Game? g=null;var snapshots=new List<object>();var decisions=new List<object>();var completed=new HashSet<string>();Exception? failure=null;int castCount=0,resolutions=0,sbas=0;bool damageSeen=false,deathSeen=false;
        try
        {
            var program=ForgeProgram.BuildForDevelopment();g=new(root,program,CardDatabase.Load(Path.Combine(root,"data/forge")));g.Rt.SynchronousInstructionLimit=20000000;
            g.Initialize(40);var divination=g.Card("Divination",0,"Hand");var goblin=g.Card("Raging Goblin",0,"Hand");var growth=g.Card("Giant Growth",0,"Hand");var blocker=g.Card("Eager Cadet",1,"Battlefield");var survivor=g.Card("Hill Giant",0,"Battlefield");
            var lands=new List<JValue>();foreach(string name in new[]{"Island","Island","Island","Mountain","Forest"})lands.Add(g.Card(name,0,"Battlefield"));var otherLand=g.Card("Plains",1,"Battlefield");
            foreach(var land in lands.Append(otherLand))g.Call(land,"setTapped","(Z)V",JValue.I(1));
            string Phase()=>g.Rt.InspectEnumName(g.Call(g.Phase,"getPhase","()Lforge/game/phase/PhaseType;"))!;
            int Seat(JValue player)=>g.Players.FindIndex(p=>ReferenceEquals(p.Reference,player.Reference));
            int Active()=>Seat(g.Call(g.Phase,"getPlayerTurn","()Lforge/game/player/Player;"));
            int ControllerSeat(JValue ctrl)=>Seat(g.Call(ctrl,"getPlayer","()Lforge/game/player/Player;"));
            void Snapshot(string label){snapshots.Add(new{label,phase=Phase(),active=Active(),priority=Seat(g.Call(g.Phase,"getPriorityPlayer","()Lforge/game/player/Player;")),stack=g.Call(g.Stack,"size","()I").Int,players=Enumerable.Range(0,2).Select(seat=>new{seat,life=g.Life(seat),mana=g.ManaCount(seat),zones=new[]{"Battlefield","Hand","Library","Graveyard","Exile"}.ToDictionary(zone=>zone,zone=>g.Rt.ListItems(g.Call(g.Zone(seat,zone),"getCards","()Lforge/game/card/CardCollectionView;")).Select(c=>new{id=g.Call(c,"getId","()I").Int,name=g.Rt.StringValue(g.Call(c,"getName","()Ljava/lang/String;")),damage=g.Call(c,"getDamage","()I").Int,tapped=g.Call(c,"isTapped","()Z").Int!=0}).ToArray())}).ToArray()});}
            g.Rt.MethodReturned=(f,v)=>{if(f.Method.Owner=="forge/game/zone/MagicStack"&&f.Method.Name=="resolveStack")resolutions++;if(f.Method.Owner=="forge/game/GameAction"&&f.Method.Name=="checkStateEffects"&&f.Method.Descriptor=="(ZLjava/util/Set;)Z")sbas++;};
            g.SetDecision("chooseSpellAbilityToPlay",(ctrl,a)=>{
                int seat=ControllerSeat(ctrl);if(seat==0&&Active()==0&&Phase()=="MAIN1"&&g.Call(g.Stack,"isEmpty","()Z").Int!=0&&castCount<3){var card=castCount==0?divination:castCount==1?goblin:growth;var sa=g.Ability(card,0);if(castCount==2)g.Target(sa,survivor);g.Check(g.Call(sa,"canPlay","()Z").Int!=0,"priority offers legal spell");decisions.Add(new{kind="cast",seat,card=castCount==0?"Divination":castCount==1?"Raging Goblin":"Giant Growth"});return JHostResult.Complete(g.Rt.ListOf([sa]));}decisions.Add(new{kind="pass",seat,phase=Phase()});return JHostResult.Complete();});
            g.SetDecision("playChosenSpellAbility",(ctrl,a)=>{
                int amount=castCount==0?3:1;foreach(var land in lands.Skip(castCount==0?0:castCount==1?3:4).Take(amount)){var mana=g.Rt.ListItems(g.Call(land,"getManaAbilities","()Lforge/util/collect/FCollectionView;"))[0];g.Call(mana,"setActivatingPlayer","(Lforge/game/player/Player;)V",g.Players[0]);g.Check(g.Call(mana,"canPlay","()Z").Int!=0,"land mana activation legal");g.Check(g.Call(land,"tap","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Z",mana,g.Players[0]).Int!=0,"existing land tapped to pay");g.Call(g.Call(mana,"getManaPart","()Lforge/game/spellability/AbilityManaPart;"),"produceMana","(Lforge/game/spellability/SpellAbility;)V",mana);}
                g.Check(g.ManaCount(0)==amount,"generated exact mana for spell");Snapshot("before paid cast");bool accepted=g.Cast(castCount==0?divination:castCount==1?goblin:growth,a[0],0);g.Check(accepted&&g.ManaCount(0)==0,"spell accepted and cost consumed");castCount++;Snapshot("after paid cast");return JHostResult.Complete(JValue.I(1));});
            g.SetDecision("declareAttackers",(ctrl,a)=>{var attacker=g.Current(goblin);g.Check(g.Static("forge/game/combat/CombatUtil","canAttack","(Lforge/game/card/Card;Lforge/game/GameEntity;)Z",attacker,g.Players[1]).Int!=0,"haste creature can attack this turn");g.Call(a[1],"addAttacker","(Lforge/game/card/Card;Lforge/game/GameEntity;)V",attacker,g.Players[1]);g.Check(g.Call(a[1],"isAttacking","(Lforge/game/card/Card;)Z",attacker).Int!=0,"attack relation stored");decisions.Add(new{kind="attack",attacker="Raging Goblin",defender=1});return JHostResult.Complete();});
            g.SetDecision("declareBlockers",(ctrl,a)=>{var attacker=g.Current(goblin);g.Check(g.Static("forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/combat/Combat;)Z",attacker,blocker,a[1]).Int!=0,"block declared from legal choices");g.Call(a[1],"addBlocker","(Lforge/game/card/Card;Lforge/game/card/Card;)V",attacker,blocker);decisions.Add(new{kind="block",attacker="Raging Goblin",blocker="Eager Cadet"});return JHostResult.Complete();});
            g.SetDecision("assignCombatDamage",(ctrl,a)=>{var offered=g.Rt.ListItems(a[1]);g.Check(offered.Length==1&&a[3].Int==1,"controlled combat has one legal recipient and one damage");decisions.Add(new{kind="damageAssignment",amount=1});return JHostResult.Complete(g.Rt.MapOf([new(offered[0],g.Rt.BoxInt(a[3].Int))]));});
            g.SetDecision("autoPassCancel",(ctrl,a)=>{decisions.Add(new{kind="clearAutopass"});return JHostResult.Complete();});
            g.Call(g.Phase,"devModeSet","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;I)V",g.Enum("forge/game/phase/PhaseType","UNTAP"),g.Players[0],JValue.I(2));
            Snapshot("initial controlled turn");g.Call(g.Phase,"onPhaseBegin","()V");
            for(int step=0;step<100;step++)
            {
                string phase=Phase();int active=Active();completed.Add(active+":"+phase);Snapshot("step "+step);
                if(active==0&&phase=="UPKEEP")g.Check(lands.All(l=>g.Call(l,"isTapped","()Z").Int==0),"player zero untap completed");
                if(active==0&&phase=="MAIN1"&&castCount==0)g.Check(g.Count(0,"Library")==39&&g.Count(0,"Hand")==4,"first draw step moved exactly one card");
                if(castCount>=1&&g.In(divination,"Graveyard")){g.Check(g.Count(0,"Library")==37,"Divination resolved and drew exactly two");if(castCount==1)g.Check(g.Count(0,"Hand")==5,"Divination resolution increased hand by exactly two");}
                if(active==0&&phase=="COMBAT_BEGIN")g.Check(g.Call(survivor,"getNetPower","()I").Int==6&&g.Call(survivor,"getNetToughness","()I").Int==6,"temporary pump applied before combat");if(active==0&&phase=="CLEANUP")g.Check(g.Call(survivor,"getNetPower","()I").Int==3&&g.Call(survivor,"getNetToughness","()I").Int==3,"until end of turn pump removed by cleanup");if(phase=="COMBAT_DAMAGE"&&!damageSeen){g.Check(g.Call(g.Current(goblin),"getDamage","()I").Int==1&&g.Call(g.Current(blocker),"getDamage","()I").Int==1,"Combat assigned and dealt reciprocal lethal damage before SBA");damageSeen=true;Snapshot("combat damage before SBA");}
                if(damageSeen&&g.In(goblin,"Graveyard")&&g.In(blocker,"Graveyard")){deathSeen=true;Snapshot("lethal creatures after SBA");}
                if(active==1&&phase=="MAIN1")
                {g.Check(g.Count(1,"Library")==39&&g.Count(1,"Hand")==1,"opponent draw step moved one card");g.Check(g.Call(otherLand,"isTapped","()Z").Int==0,"opponent untap completed");g.Check(castCount==3&&resolutions==3&&damageSeen&&deathSeen,"draw, creature and temporary pump spells plus combat completed through priority loop");g.Check(g.Call(g.Stack,"isEmpty","()Z").Int!=0&&g.ManaCount(0)==0&&g.ManaCount(1)==0,"stack and mana clear after turn end");g.Check(Seat(g.Call(g.Phase,"getPriorityPlayer","()Lforge/game/player/Player;"))==1,"opponent has main phase priority");break;}
                g.Call(g.Phase,"mainLoopStep","()V");
                if(step==99)throw new InvalidOperationException("Turn action bound exhausted");
            }
            foreach(string required in new[]{"0:UNTAP","0:UPKEEP","0:DRAW","0:MAIN1","0:COMBAT_DECLARE_ATTACKERS","0:COMBAT_DECLARE_BLOCKERS","0:COMBAT_DAMAGE","0:CLEANUP","1:UNTAP","1:UPKEEP","1:DRAW","1:MAIN1"})g.Check(completed.Contains(required),"completed phase "+required);
        }
        catch(Exception ex){failure=ex;}
        if(g!=null){if(failure!=null)g.Trace.Add("FAILURE "+failure);File.WriteAllLines(Path.Combine(dir,"minimum-turn.trace.log"),g.Trace);}
        File.WriteAllText(Path.Combine(dir,"snapshots.json"),JsonSerializer.Serialize(snapshots,new JsonSerializerOptions{WriteIndented=true}));File.WriteAllText(Path.Combine(dir,"decisions.json"),JsonSerializer.Serialize(decisions,new JsonSerializerOptions{WriteIndented=true}));
        string? failingSignature=g?.Trace.LastOrDefault(t=>t.Contains("JAVA STACK\nforge/"))?.Split("JAVA STACK\n")[1].Split('\n')[0];
        var report=new{initialSnapshot=snapshots.FirstOrDefault(),decisions,failingSignature,category=failure==null?null:failure.Message.Contains("PlayerController")?"c-host-policy":failure is PortGap&&failure.Message.StartsWith("Unlinked")?"a-missing-binding":"b-runtime-or-rule",executed=true,passed=failure==null,playable=false,seed=42,phase="stage0",fuzzStarted=false,errorType=failure is JavaFault jf?jf.Value.ClassName:failure?.GetType().Name,error=failure?.ToString(),completedPhases=completed,assertions=g?.Assertions,enqueued=g?.Enqueued??0,resolutions,sbas,trace="../forge-turn/minimum-turn.trace.log",snapshots="../forge-turn/snapshots.json"};
        var delivery=JsonSerializer.SerializeToNode(report)!;delivery["build"]=JsonSerializer.SerializeToNode(EngineBuild.Fingerprint(root));
        File.WriteAllText(gate,delivery.ToJsonString(new JsonSerializerOptions{WriteIndented=true}));Console.WriteLine(failure==null?"MINIMUM TURN PASS":failure.ToString());return failure==null?0:2;
    }
}

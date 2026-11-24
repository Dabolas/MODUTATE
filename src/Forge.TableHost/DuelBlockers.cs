using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    JHostResult ChooseBlockers(JValue combat,JValue[] candidates)
    {
        var blockers=candidates.ToDictionary(c=>C(c,"getId","()I").Int);
        var attackers=Items(C(combat,"getAttackers","()Lforge/game/card/CardCollection;"))
            .ToDictionary(c=>C(c,"getId","()I").Int);
        var assigned=new HashSet<(int Blocker,int Attacker)>();
        var available=new HashSet<int>();
        var destinations=new HashSet<int>();
        int selected=0;
        bool CanAssign(JValue blocker,JValue attacker)=>
            S("forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/combat/Combat;)Z",attacker,blocker,combat).Int!=0;

        void FindAvailable()
        {
            available.Clear();
            foreach(var id in assigned)available.Add(id.Blocker);
            foreach(var blocker in blockers)
                if(!available.Contains(blocker.Key)&&attackers.Values.Any(a=>CanAssign(blocker.Value,a)))available.Add(blocker.Key);
        }
        FindAvailable();
        if(available.Count==0)return JHostResult.Complete();
        void Paint(string? error=null)
        {
            View.inputId=++revision;
            View.declaringBlockers=true;
            View.selectedBlockerId=selected;
            View.prompt=error??(selected!=0?"点选亮框攻击者分配阻挡，再点同一对可撤回。":"先点自己的阻挡者，再点要挡的攻击者。");
            View.ok=selected==0;
            View.okLabel=assigned.Count>0?"确认阻挡（"+assigned.Count+"）":
                View.players[0].cards.Any(c=>c.blockingAttackerId>0)?"确认阻挡":"不阻挡";
            View.cancel=selected!=0;
            View.cancelLabel="取消选取";
            destinations.Clear();
            if(selected!=0)
                foreach(var attacker in attackers)
                    if(assigned.Contains((selected,attacker.Key))||CanAssign(blockers[selected],attacker.Value))destinations.Add(attacker.Key);
            foreach(var row in View.players.SelectMany(p=>p.cards)){
                row.selectable=available.Contains(row.id)||destinations.Contains(row.id);
                row.chosen=row.id==selected;
            }
        }
        var wait=Ask("V","选择阻挡者",(cmd,ids)=>{
            if(cmd=="ok"&&selected==0){
                var error=S("forge/game/combat/CombatUtil","validateBlocks","(Lforge/game/combat/Combat;Lforge/game/player/Player;)Ljava/lang/String;",combat,g.Players[0]);
                if(error.Reference==null)return true;
                Paint("阻挡未通过，请调整。"+OptionalText(error));
            }else if(cmd=="cancel"&&selected!=0){
                selected=0;Paint();
            }else if(cmd=="card"&&ids.Length==1){
                int id=ids[0];
                if(selected!=0&&destinations.Contains(id)){
                    var pair=(selected,id);
                    if(assigned.Remove(pair))
                        C(combat,"removeBlockAssignment","(Lforge/game/card/Card;Lforge/game/card/Card;)V",attackers[id],blockers[selected]);
                    else{
                        C(combat,"addBlocker","(Lforge/game/card/Card;Lforge/game/card/Card;)V",attackers[id],blockers[selected]);
                        assigned.Add(pair);
                    }
                    selected=0;
                    ProjectCombat(View,combat);
                    FindAvailable();Paint();
                }else if(available.Contains(id)){
                    selected=selected==id?0:id;
                    Paint();
                }
            }
            return false;
        },false);
        Paint();
        return FinishPrompt(wait);
    }
}

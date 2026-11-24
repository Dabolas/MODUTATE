using Planeswalker.Core;
using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    JHostResult ChooseAttackers(JValue combat,List<(JValue Card,JValue Target)> pairs,bool requireAll=false)
    {
        var legal=pairs.GroupBy(p=>C(p.Card,"getId","()I").Int).ToDictionary(group=>group.Key,group=>group.ToArray());
        var selected=new Dictionary<int,JValue>();
        var defenders=pairs.Select(p=>p.Target).Distinct().ToDictionary(t=>t,t=>Target(t)!);
        var destinations=new Dictionary<(string Kind,int Id),JValue>();
        int choosing=-1;
        bool ReadyToConfirm()=>choosing<0&&(requireAll?selected.Count==legal.Count:selected.Count>0);
        void Paint(string? error=null)
        {
            View.choice=null;View.declaringAttackers=true;
            View.inputId=++revision;
            View.pendingAttackerId=choosing<0?0:choosing;
            View.prompt=error??(choosing<0?"点生物加入或撤回攻击，最后确认。":"点亮框的防御牌手或永久物，指定攻击方向。");
            View.ok=ReadyToConfirm();View.okLabel="确认攻击（"+selected.Count+"）";
            View.cancel=choosing>=0||!requireAll&&selected.Count==0;View.cancelLabel=choosing>=0?"取消选取":"不攻击";
            destinations.Clear();
            if(choosing>=0)foreach(var pair in legal[choosing]){
                var target=defenders[pair.Target];
                destinations[(target.kind,target.id)]=pair.Target;
            }
            foreach(var player in View.players){
                player.selectableDefender=destinations.ContainsKey(("player",player.id));
                foreach(var row in player.cards){
                    row.selectable=choosing<0?legal.ContainsKey(row.id):destinations.ContainsKey(("card",row.id))||row.id==choosing;
                    row.chosen=selected.ContainsKey(row.id)||row.id==choosing;
                    if(!legal.ContainsKey(row.id))continue;
                    row.attacking=selected.TryGetValue(row.id,out var target);
                    row.attackTarget=row.attacking?defenders[target]:null;
                }
            }
        }
        var wait=Ask("V","点选战场上的生物，再确认攻击。",(cmd,ids)=>{
            if(choosing>=0){
                if(ids.Length==1&&destinations.TryGetValue((cmd,ids[0]),out var target))selected[choosing]=target;
                else if(cmd!="cancel"&&!(cmd=="card"&&ids.Length==1&&ids[0]==choosing))return false;
                choosing=-1;Paint();return false;
            }
            if(cmd=="card"&&ids.Length==1&&legal.TryGetValue(ids[0],out var options)){
                if(!selected.Remove(ids[0])){
                    if(options.Length>1){
                        choosing=ids[0];Paint();return false;
                    }
                    selected[ids[0]]=options[0].Target;
                }
                Paint();return false;
            }
            if(cmd=="attackAll"){
                foreach(var pair in legal)if(!selected.ContainsKey(pair.Key)){
                    var target=pair.Value.FirstOrDefault(p=>Seat(p.Target)==1).Target;
                    selected[pair.Key]=target.Reference==null?pair.Value[0].Target:target;
                }
                Paint();return false;
            }
            if(!(cmd=="attack"&&ReadyToConfirm()||cmd=="noAttack"&&!requireAll&&selected.Count==0))return false;
            C(combat,"clearAttackers","()V");
            foreach(var pair in selected)C(combat,"addAttacker","(Lforge/game/card/Card;Lforge/game/GameEntity;)V",legal[pair.Key][0].Card,pair.Value);
            if(S("forge/game/combat/CombatUtil","validateAttackers","(Lforge/game/combat/Combat;)Z",combat).Int!=0)return true;
            C(combat,"clearAttackers","()V");Paint("当前宣告不符合攻击要求，请调整。");return false;
        },false);
        Paint();
        if(requireAll&&phaseLesson!=null)ReportLesson("input",View);
        return FinishPrompt(wait);
    }
}

using Planeswalker.Core;
using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    JHostResult BoardTarget(string title,JValue[] legal,string type,JValue source=default,bool canCancel=false)
    {
        if(phaseLesson!=null)legal=legal.Where(PhaseLessonTarget).ToArray();
        if(legal.Length==0)return JHostResult.Complete();
        var wait=Ask(type,title,(cmd,ids)=>{
            if(cmd=="cancel"&&canCancel)return true;
            if(cmd!="choice"||ids.Length!=1||(uint)ids[0]>=legal.Length)return false;
            answer=legal[ids[0]];
            return true;
        },false,cancel:canCancel);
        var choice=new ChoiceView{id=revision,kind="target",title=title,min=1,max=1,cancelCast=canCancel};
        SetChoiceOptions(choice,legal,Describe);
        View.choice=choice;
        MarkTargetPrompt(source);
        return FinishPrompt(wait);
    }

    void MarkTargetPrompt(JValue ability)
    {
        View.targeting=true;
        if(ability.Reference!=null){
            int source=AbilityCardId(ability);
            View.promptCardId=View.players.SelectMany(player=>player.cards)
                .FirstOrDefault(card=>card.preparedSpellId==source)?.id??source;
        }
    }

    void InstallCasting()
    {
        g.SetDecision("playChosenSpellAbility",(ctrl,a)=>{
            int seat=ControllerSeat(ctrl);
            if(seat!=0)return JHostResult.Complete(JValue.I(Play(a[0],seat)?1:0));
            var play=g.Rt.Program.Classes["forge/game/player/PlaySpellAbility"].Methods[
                "playSpellAbility(Lforge/game/player/PlayerController;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Z"];
            return JHostResult.Schedule(new JFrame(play,default,new[]{ctrl,g.Players[0],a[0]}));
        });
        g.SetDecision("chooseTargetsFor",(ctrl,a)=>{
            var sa=a[0];int seat=ControllerSeat(ctrl);
            if(seat!=0||checkingActions)return JHostResult.Complete(JValue.I(SelectTargetsForCast(sa,seat)?1:0));
            bool canCancel=!B(C(sa,"getRootAbility","()Lforge/game/spellability/SpellAbility;"),"isMandatory");
            if(!B(sa,"usesTargeting")||B(sa,"isDividedAsYouChoose")||C(sa,"getSubAbility","()Lforge/game/spellability/AbilitySub;").Reference!=null)
                return JHostResult.Complete(JValue.I(SelectTargets(sa,null,default,Array.Empty<int>(),chooseNumber:TableNumber,
                    chooseTarget:(title,legal)=>TableAnswer(BoardTarget(title,legal,"Ljava/lang/Object;",sa,canCancel)))?1:0));
            var restrictions=C(sa,"getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;");
            C(sa,"clearTargets","()V");
            var legal=Items(C(restrictions,"getAllCandidates","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",sa))
                .Where(entity=>!(g.Rt.IsInstance(entity.Reference!,"forge/game/card/Card")&&g.In(entity,"Stack"))&&C(sa,"canTarget","(Lforge/game/GameObject;)Z",entity).Int!=0).ToList();
            if(Items(C(restrictions,"getZone","()Ljava/util/List;")).Any(z=>g.Rt.InspectEnumName(z)=="Stack")){
                foreach(var entry in Items(g.Stack)){
                    var spell=C(entry,"getSpellAbility","()Lforge/game/spellability/SpellAbility;");
                    if(C(sa,"canTargetSpellAbility","(Lforge/game/spellability/SpellAbility;)Z",spell).Int!=0)legal.Add(spell);
                }
            }
            if(phaseLesson!=null)legal.RemoveAll(entity=>!PhaseLessonTarget(entity));
            int min=C(sa,"getMinTargets","()I").Int,max=Math.Min(legal.Count,C(sa,"getMaxTargets","()I").Int);
            if(min>max)return JHostResult.Complete(JValue.I(0));
            if(max==0)return JHostResult.Complete(JValue.I(1));
            var wait=Ask("Z","选择目标",(cmd,ids)=>{
                if(cmd=="cancel"&&canCancel){C(sa,"clearTargets","()V");answer=JValue.I(0);return true;}
                if(cmd!="choice"||ids.Length<min||ids.Length>max||ids.Distinct().Count()!=ids.Length||ids.Any(i=>i<0||i>=legal.Count))return false;
                C(sa,"clearTargets","()V");
                foreach(int index in ids){
                    var entity=legal[index];
                    bool spell=g.Rt.IsInstance(entity.Reference!,"forge/game/spellability/SpellAbility");
                    if((spell?C(sa,"canTargetSpellAbility","(Lforge/game/spellability/SpellAbility;)Z",entity):C(sa,"canTarget","(Lforge/game/GameObject;)Z",entity)).Int==0){
                        C(sa,"clearTargets","()V");
                        View.prompt="这组目标不能同时选择，请重新点选。";
                        return false;
                    }
                    C(C(sa,"getTargets","()Lforge/game/spellability/TargetChoices;"),"add","(Lforge/game/GameObject;)Z",entity);
                }
                if(!B(sa,"isTargetNumberValid")){C(sa,"clearTargets","()V");return false;}
                answer=JValue.I(1);return true;
            },false,cancel:canCancel);
            var choice=new ChoiceView{id=revision,kind="target",title="请选择目标",min=min,max=max,cancelCast=canCancel};
            SetChoiceOptions(choice,legal,e=>Seat(e)==0?"你":Seat(e)==1?"BOT":Label(e));
            View.choice=choice;
            MarkTargetPrompt(sa);
            return FinishPrompt(wait);
        });
    }
}

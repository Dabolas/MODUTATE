using Planeswalker.ForgeAot;
using Planeswalker.Core;

public sealed partial class HeadlessMatch
{
    int ChoosePhyrexianPayment(int[] payable)
    {
        const string title="用生命支付几个非瑞克西亚符号？";
        var wait=Ask("I",title,(command,ids)=>{
            if(command=="cancel"){answer=JValue.I(-1);return true;}
            if(command!="choice"||ids.Length!=1||!payable.Contains(ids[0]))return false;
            answer=JValue.I(ids[0]);return true;
        },false,cancel:true);
        View.choice=new ChoiceView{id=revision,kind="phyrexian-payment",title=title,min=1,max=1,cancelCast=true,
            instructions="每个符号支付 2 点生命。确认数量后，再支付剩余的法术力。",
            options=payable.Select(count=>new OptionView{id=count,label=count==0?"0 个 · 只用法术力":$"{count} 个 · 支付 {2*count} 点生命"}).ToArray()};
        return TableAnswer(wait).Int;
    }

    void InstallPaymentDecisions()
    {
        payTableMana=(due,spell,matrix,quote,effect)=>PayFromTable(due,spell,matrix,quote,effect);
        availableTableMana=ability=>TableManaCapacity(ability,0);
        quoteOrdinaryLandAbilities=QuoteOrdinaryLandAbilities;
        quoteOrdinaryManaOffer=QuoteOrdinaryManaOffer;
        takesCostInput=payer=>Seat(payer)==0&&!checkingActions;
        pickCostCards=(title,legal,count)=>Items(TableAnswer(CardSelection(title,legal,count,count,Cards,CardList)));
        pickCostGroup=(title,labels)=>{
            var options=labels.Select(g.S).ToArray();
            return Array.IndexOf(options,TableTarget(title,options));
        };
        announcedNumber=(label,min,max)=>checkingActions?min:TableNumber("宣告 "+label,min,max);
        announcedPayableX=values=>checkingActions||values.Length==1?values[0]:g.Rt.UnboxInt(TableTarget("选择可支付的 X",values.Select(g.Rt.BoxInt).ToArray()));
        chooseReductionPlan=(seat,plans)=>{
            if(checkingActions||seat!=0||plans.Length==1)return plans[0];
            string DescribePlan(KeyValuePair<JValue,JValue>[] plan)=>plan.Length==0?"只支付法术力":string.Join("、",plan.Select(p=>Name(p.Key)+" → "+Describe(p.Value)));
            var labels=plans.Select(p=>g.S(DescribePlan(p))).ToArray();
            int index=TableAnswer(Offers("召集或拼造 · 选择支付方式",labels,1,1,"I",v=>JValue.I(Array.IndexOf(labels,v[0])),label:OptionalText)).Int;
            return plans[index];
        };
        Human("chooseNumberForKeywordCost",a=>Number(OptionalText(a[3]),0,a[4].Int,"I",JValue.I));
        Human("chooseCardsToDelve",a=>probingDelve?JHostResult.Complete(ChooseDelve(a[0].Int,Items(a[1]))):
            CardSelection("掘穴 · 选择从坟场放逐的牌",Items(a[1]),0,a[0].Int,Cards,CardList));
        Human("choosePlayerToAssistPayment",a=>Offers(OptionalText(a[2]),Items(a[0]),1,1,"Lforge/game/player/Player;",v=>v.FirstOrDefault(),optional:true));
        Human("helpPayForAssistSpell",a=>{
            int max=Math.Min(Math.Min(a[2].Int,a[3].Int),g.ManaCount(0));
            return JHostResult.Complete(AssistPayment(0,a[0],a[1],TableNumber("协力支付的通用法术力",0,Math.Max(0,max))));
        });
        Human("orderCosts",a=>{
            var result=new List<JValue>();
            foreach(var group in Items(a[0]).GroupBy(c=>C(c,"paymentOrder","()I").Int).OrderBy(g=>g.Key)){
                var items=group.ToArray();
                result.AddRange(items.Length<2?items:Items(TableAnswer(Offers("选择这些费用的支付顺序",items,items.Length,items.Length,JavaList,AsList,"order"))));
            }
            return JHostResult.Complete(AsList(result));
        });
        object? confirmedCostAbility=null;
        acceptLifePayment=(part,sa,payer)=>{
            int seat=Seat(payer);
            if(seat==1&&TacticalBot){
                int lifeCost=C(part,"getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I",sa).Int;
                return g.Life(seat)>Math.Max(7,lifeCost+3);
            }
            if(checkingActions||seat!=0)return tape.Choose("optional life cost",["decline","pay"])!=0;
            if(ReferenceEquals(sa.Reference,confirmedCostAbility))return true;
            int amount=C(part,"getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I",sa).Int;
            var source=C(sa,"getHostCard","()Lforge/game/card/Card;");
            bool tapOnEntry=g.Rt.InspectEnumName(C(sa,"getApi","()Lforge/game/ability/ApiType;"))=="Tap"
                &&OptionalText(C(sa,"getParam","(Ljava/lang/String;)Ljava/lang/String;",g.S("ETB")))=="True"
                &&OptionalText(C(sa,"getParam","(Ljava/lang/String;)Ljava/lang/String;",g.S("Defined")))=="Self";
            string price="支付 "+amount+" 点生命";
            return TableAnswer(tapOnEntry?YesNo(Name(source)+" · 进场方式",price+"（尝试竖进）","不支付（横进）"):
                YesNo(Name(source)+" · "+price+"？",price,"不支付")).Int!=0;
        };
        JHostResult Pay(JValue cost,JValue sa,string title){
            if(!CanPayPart(cost,sa,g.Players[0],true))return JHostResult.Complete(JValue.I(0));
            var parts=Items(C(cost,"getCostParts","()Ljava/util/List;"));
            bool lifeOnly=parts.Length==1&&g.Rt.IsInstance(parts[0].Reference!,"forge/game/cost/CostPayLife");
            if(!lifeOnly&&TableAnswer(YesNo(title,"支付","放弃")).Int==0)return JHostResult.Complete(JValue.I(0));
            var previous=confirmedCostAbility;
            try{
                confirmedCostAbility=lifeOnly?null:sa.Reference;
                return JHostResult.Complete(PayResolvingCost(C(g.Players[0],"getController","()Lforge/game/player/PlayerController;"),cost,sa,g.S(title)));
            }finally{confirmedCostAbility=previous;}
        }
        Human("payCombatCost",a=>Pay(a[1],a[2],OptionalText(a[3])));
        Human("payCostToPreventEffect",a=>Pay(a[0],a[1],"支付费用以防止效应？"));
        g.SetDecision("payCostDuringRoll",(ctrl,a)=>ControllerSeat(ctrl)==0&&!checkingActions?Pay(a[0],a[1],"支付掷骰费用？"):JHostResult.Complete(JValue.I(0)));
        g.SetDecision("orderBlocker",(ctrl,a)=>{
            var old=Items(a[2]).ToList();int at=ControllerSeat(ctrl)==0&&!checkingActions?TableNumber("插入阻挡者的位置（0 为最前）",0,old.Count):old.Count;
            old.Insert(at,a[1]);return JHostResult.Complete(Cards(old));
        });
    }
}

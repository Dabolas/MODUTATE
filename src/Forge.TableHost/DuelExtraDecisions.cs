using Planeswalker.Core;
using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    JValue TableAnswer(JHostResult result)
    {
        if(result.Frame==null)return result.Value;
        while(Waiting)(WaitForInlineInput??throw new InvalidOperationException("Missing table input"))();
        return answer;
    }
    int TableNumber(string label,int min,int max)=>TableAnswer(Number(label,min,max,"I",JValue.I)).Int;
    JValue TableTarget(string title,JValue[] legal)=>TableAnswer(Single(title,legal,"Ljava/lang/Object;"));
    string lastNotice="";
    void InstallExtraDecisions()
    {
        InstallPaymentDecisions();
        InstallDamageDecisions();
        Human("notifyOfValue",a=>{lastNotice=OptionalText(a[2]);return JHostResult.Complete();});
        orderedTriggers=(controller,items)=>checkingActions||ControllerSeat(controller)!=0?tape.Shuffle("trigger order",items,Label).ToArray():
            items.Length<2?items:Items(TableAnswer(Offers("排列同时触发的异能",items,items.Length,items.Length,JavaList,AsList,"order")));
        void Register(string name,Func<JValue[],JHostResult> human,Func<JValue[],JValue> fallback)
        {
            var previous=g.Decision(name);
            g.SetDecision(name,(controller,args)=>!checkingActions&&ControllerSeat(controller)==0?human(args):
                previous!=null?previous(controller,args):JHostResult.Complete(fallback(args)));
        }
        string Result(string method){
            var signature=g.Rt.Program.Classes["forge/game/player/PlayerController"].Methods.Values.First(m=>m.Name==method).Descriptor;
            return signature.Substring(signature.IndexOf(')')+1);
        }
        foreach(var item in new[]{
            ("choosePDRollToIgnore",0,"选择要忽略的时空骰"),("chooseRollToSwap",0,"选择要替换的骰子"),("chooseRollSwapValue",0,"选择替换值"),
            ("chooseSingleCardState",1,"选择牌面"),("chooseCardToKeepStickers",0,"选择保留贴纸的牌")})
            Register(item.Item1,a=>Single(item.Item3,Items(a[item.Item2]),Result(item.Item1)),a=>Items(a[item.Item2]).FirstOrDefault());
        Register("chooseTarget",a=>BoardTarget("请选择要更改的目标",Items(a[1]),Result("chooseTarget")),a=>Items(a[1]).FirstOrDefault());
        foreach(var item in new[]{("chooseCardsForSplice",1,"选择要通联的牌"),("chooseDiceToReroll",0,"选择要重掷的骰子"),("chooseContraptionsToCrank",0,"选择要启动的机巧")})
            Register(item.Item1,a=>{var opts=Items(a[item.Item2]);return Offers(item.Item3,opts,0,opts.Length,JavaList,AsList);},a=>AsList(Array.Empty<JValue>()));
        Register("chooseSticker",a=>Offers("选择贴纸",Items(a[0]),1,1,Result("chooseSticker"),v=>v.FirstOrDefault(),optional:a[3].Int!=0),a=>Items(a[0]).FirstOrDefault());
        Register("chooseStickerNamePosition",a=>Number("贴纸在牌名中的位置",0,B(a[1],"stickerWouldFillBlank")?0:Name(a[1]).Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries).Length,"I",JValue.I),a=>JValue.I(0));
        Register("chooseSprocket",a=>Offers("分配机巧到齿轮",Items(a[1]),1,1,"I",v=>JValue.I(g.Rt.UnboxInt(v[0]))),a=>JValue.I(g.Rt.UnboxInt(Items(a[1]).First())));
        Register("vote",a=>Offers(OptionalText(a[1]),Items(a[2]),1,1,"Ljava/lang/Object;",v=>v.FirstOrDefault(),optional:a[5].Int!=0),a=>Items(a[2]).FirstOrDefault());
        Register("confirmBidAction",a=>YesNo(OptionalText(a[2])+" · "+a[3].Int,"出价","放弃"),a=>JValue.I(0));
        Register("chooseFlipResult",a=>YesNo("选择掷币结果",a[2].Int!=0?"正面":"赢",a[2].Int!=0?"反面":"输"),a=>JValue.I(1));
        Register("chooseNumberForCostReduction",a=>Number("选择费用减免量",a[1].Int,a[2].Int,"I",JValue.I),a=>a[2]);
        Human("chooseNewTargetsFor",a=>{
            var sa=a[0];var old=C(sa,"getTargets","()Lforge/game/spellability/TargetChoices;");
            if(a[2].Int!=0&&TableAnswer(YesNo("重新选择目标？","更改","保留")).Int==0)return JHostResult.Complete();
            int count=C(old,"size","()I").Int;
            var amounts=Items(C(old,"getDividedValues","()Ljava/util/Collection;")).Select(g.Rt.UnboxInt).ToArray();
            if(SelectTargets(sa,count,a[1],amounts,chooseNumber:TableNumber,
                chooseTarget:(title,legal)=>TableAnswer(BoardTarget(title,legal,"Ljava/lang/Object;",sa,true))))
                return JHostResult.Complete(C(sa,"getTargets","()Lforge/game/spellability/TargetChoices;"));
            C(sa,"setTargets","(Lforge/game/spellability/TargetChoices;)V",old);return JHostResult.Complete();
        });
        Human("chooseCardsForEffectMultiple",a=>{
            var chosen=new List<JValue>();
            foreach(var group in Items(C(a[0],"entrySet","()Ljava/util/Set;"))){
                var offered=Items(C(group,"getValue","()Ljava/lang/Object;")).Where(c=>!chosen.Contains(c)).ToArray();
                if(offered.Length==0)continue;
                var result=TableAnswer(Offers(OptionalText(a[2])+" · "+Describe(C(group,"getKey","()Ljava/lang/Object;")),offered,0,1,CardList,v=>Cards(v),"cards"));
                chosen.AddRange(Items(result));
            }
            return JHostResult.Complete(Cards(chosen));
        });
        Human("chooseCardsToDiscardUnlessType",a=>{
            var hand=Items(a[1]);int count=Math.Min(a[0].Int,hand.Length);var sa=a[3];
            var matching=Items(S("forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;",
                Cards(hand),a[2],C(sa,"getActivatingPlayer","()Lforge/game/player/Player;"),C(sa,"getHostCard","()Lforge/game/card/Card;"),sa));
            if(count>1&&matching.Length>0&&TableAnswer(YesNo("选择弃牌方式","弃一张指定类别","弃 "+count+" 张")).Int!=0)
                return CardSelection("选择符合类别的牌",matching,1,1,Cards,CardList);
            return CardSelection("选择要弃的牌",hand,count,count,Cards,CardList);
        });
        Human("chooseCardsPile",a=>{
            string conceal=OptionalText(a[3]);
            string Pile(int index,bool visible){var cards=Items(a[index]);return "第 "+index+" 堆（"+cards.Length+" 张）"+(visible?string.Join("、",cards.Select(Name)):"");}
            return Offers("选择一堆牌",new[]{g.S(Pile(1,conceal=="False")),g.S(Pile(2,conceal!="True"))},1,1,"Z",v=>JValue.I(OptionalText(v[0]).StartsWith("第 1 ")?1:0),label:OptionalText);
        });
        Human("chooseCardName",a=>a.Length==3?
            Offers(OptionalText(a[2]),Items(a[1]),1,1,"Ljava/lang/String;",v=>v.Length==0?g.S(""):C(v[0],"getName","()Ljava/lang/String;"),label:Name):
            NameFilteredFace(a,false));
        const string faceSignature="(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/function/Predicate;Ljava/lang/String;)Lforge/card/ICardFace;";
        g.Rt.Bind("l3/ConsoleController","chooseSingleCardFace",faceSignature,(r,controller,a)=>
            !checkingActions&&ControllerSeat(controller)==0?NameFilteredFace(a,true):JHostResult.Complete(FindFace(a,true,OptionalText(a[3]))));
    }

    JValue FindFace(JValue[] args,bool returnFace,string query)
    {
        foreach(string definition in catalogue.FindFaceNames(query)){
            var paper=g.Paper(definition);
            foreach(var face in Items(C(C(paper,"getRules","()Lforge/card/CardRules;"),"getAllFaces","()Ljava/util/List;"))){
                if(!string.Equals(Name(face),query,StringComparison.OrdinalIgnoreCase)||
                    C(args[returnFace?2:1],"test","(Ljava/lang/Object;)Z",face).Int==0)continue;
                if(returnFace)return face;
                var name=C(face,"getName","()Ljava/lang/String;");
                var source=C(args[0],"getHostCard","()Lforge/game/card/Card;");
                var card=S("forge/game/card/Card","fromPaperCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;)Lforge/game/card/Card;",paper,g.Players[0]);
                S("forge/game/card/CardUtil","turnToRightFace","(Ljava/lang/String;Lforge/game/card/Card;)V",name,card);
                var validity=C(args[2],"split","(Ljava/lang/String;)[Ljava/lang/String;",g.S(","));
                if(C(card,"isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z",
                    validity,C(source,"getController","()Lforge/game/player/Player;"),source,args[0]).Int!=0)return name;
            }
        }
        return default;
    }
    JHostResult NameFilteredFace(JValue[] args,bool returnFace)
    {
        string title=OptionalText(args[returnFace?1:3]);
        var wait=Ask(returnFace?"Lforge/card/ICardFace;":"Ljava/lang/String;",title,(cmd,ids)=>{
            if(cmd!="choice"||ids.Length>200||ids.Any(i=>i<32||i>char.MaxValue))return false;
            if(ids.Length==0){answer=returnFace?default:g.S("");return true;}
            var value=FindFace(args,returnFace,new string(ids.Select(i=>(char)i).ToArray()).Trim());
            if(value.Reference==null){View.prompt="此牌名不符合要求，请重新输入。";View.inputId=++revision;return false;}
            answer=value;return true;
        },false);
        View.choice=new ChoiceView{id=revision,kind="name",title=title,optional=true};return FinishPrompt(wait);
    }
}

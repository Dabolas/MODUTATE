using Planeswalker.Core;
using Planeswalker.ForgeAot;
public sealed partial class HeadlessMatch
{
    bool checkingActions;
    const string CardList="Lforge/game/card/CardCollectionView;",JavaList="Ljava/util/List;";
    JValue AsList(IEnumerable<JValue> values)=>g.Rt.ListOf(values.ToArray());
    string Describe(JValue v){
        if(v.Reference==null)return "";
        if(Seat(v)>=0)return Seat(v)==0?"你":"对手";
        return OptionalText(C(v,"toString","()Ljava/lang/String;"));
    }
    JHostResult BottomFromHand(JValue[] hand,int count)
    {
        var available=hand.ToDictionary(c=>C(c,"getId","()I").Int);
        var bottom=new List<JValue>();
        void UpdateHand(){
            int remaining=count-bottom.Count;
            View.inputId=++revision;
            View.choice=new ChoiceView{id=revision,kind="mulligan-bottom",min=remaining,max=remaining,title="双击放回牌库底"};
            View.players[0].cards=View.players[0].cards.Where(c=>c.zone!="Hand"||available.ContainsKey(c.id)).ToArray();
            View.players[0].handCount=available.Count;
        }
        var wait=Ask(CardList,"双击手牌放回牌库底",(cmd,ids)=>{
            if(cmd!="bottom"||ids.Length!=1||!available.TryGetValue(ids[0],out var chosen))return false;
            bottom.Add(chosen);available.Remove(ids[0]);
            if(bottom.Count<count){UpdateHand();return false;}
            answer=Cards(bottom);return true;
        },false);
        UpdateHand();return FinishPrompt(wait);
    }
    JHostResult Offers(string title,JValue[] offered,int min,int max,string type,Func<JValue[],JValue> build,
        string kind="options",bool optional=false,Func<JValue,string>? label=null,bool repeat=false,JValue[]? visibleCards=null)
    {
        if(!repeat){min=Math.Min(min,offered.Length);max=Math.Min(max,offered.Length);}
        if(max==0)return JHostResult.Complete(build(Array.Empty<JValue>()));
        var wait=Ask(type,title,(cmd,ids)=>{
            if(cmd!="choice"||ids.Length>max||ids.Length<min&&!(optional&&ids.Length==0)||
               !repeat&&ids.Distinct().Count()!=ids.Length||ids.Any(i=>(uint)i>=offered.Length))return false;
            answer=build(ids.Select(i=>offered[i]).ToArray());return true;
        },false);
        var choice=new ChoiceView{id=revision,kind=kind,title=title,min=min,max=max,optional=optional,repeat=repeat};
        SetChoiceOptions(choice,offered,label??Describe);
        if(visibleCards!=null){
            var selectableIds=new HashSet<int>(choice.cards.Select(c=>c.instanceId));
            var extra=new List<CardView>();
            foreach(var card in visibleCards){
                int id=C(card,"getId","()I").Int;
                if(!selectableIds.Add(id))continue;
                var row=Card(card,"Choice");
                row.instanceId=id;row.id=offered.Length+extra.Count;row.selectable=false;
                extra.Add(row);
            }
            if(extra.Count>0)choice.cards=choice.cards.Concat(extra).ToArray();
        }
        View.choice=choice;
        if(phaseLesson!=null&&kind=="hand-discard")ReportLesson("discard-choice",View);
        return FinishPrompt(wait);
    }
    void SetChoiceOptions(ChoiceView choice,IEnumerable<JValue> offered,Func<JValue,string> label)
    {
        var cards=new List<CardView>();
        bool useBoard=choice.kind is "target" or "legend";
        Dictionary<int,CardView>? projected=null;
        if(useBoard){
            projected=new Dictionary<int,CardView>();
            foreach(var player in View.players)
                foreach(var card in player.cards)projected.TryAdd(card.id,card);
        }
        choice.options=offered.Select((value,index)=>{
            var target=useBoard?Target(value,projectedStackIds):null;
            if(value.Reference==null||!g.Rt.IsInstance(value.Reference,"forge/game/card/Card"))
                return new OptionView{id=index,label=label(value),target=target};
            var row=target!=null&&projected!.TryGetValue(target.id,out var visible)?visible.CopyForTable():Card(value,"Choice");
            row.zone="Choice";
            row.instanceId=row.id;row.id=index;row.selectable=true;
            row.ownerId=Seat(C(value,"getOwner","()Lforge/game/player/Player;"));
            row.controllerId=Seat(C(value,"getController","()Lforge/game/player/Player;"));
            cards.Add(row);
            return new OptionView{id=index,label=row.name,target=target};
        }).ToArray();
        choice.cards=cards.ToArray();
    }
    JHostResult CardSelection(string title,JValue[] legal,int min,int max,Func<IEnumerable<JValue>,JValue> build,string type)=>
        Offers(title,legal,min,max,type,v=>build(v),"cards");
    void Human(string name,Func<JValue[],JHostResult> handle){
        var previous=g.Decision(name);
        if(previous==null)throw new InvalidOperationException("Missing controller delegate "+name);
        g.SetDecision(name,(controller,args)=>!checkingActions&&ControllerSeat(controller)==0?handle(args):previous(controller,args));
    }
    JHostResult YesNo(string title,string accept="执行",string decline="放弃"){
        var wait=Ask("Z",title,(cmd,ids)=>{
            if(cmd=="choice"&&ids.Length==1&&ids[0] is 0 or 1){answer=JValue.I(ids[0]);return true;}
            if(cmd!="ok"&&cmd!="cancel")return false;
            answer=JValue.I(cmd=="ok"?1:0);return true;
        },false);
        View.choice=new ChoiceView{kind="confirm",id=revision,title=title,min=1,max=1,options=new[]{new OptionView{id=1,label=accept},new OptionView{id=0,label=decline}}};
        return FinishPrompt(wait);
    }
    JHostResult Number(string title,int min,int max,string type,Func<int,JValue> result){
        if(min==max)return JHostResult.Complete(result(min));
        var wait=Ask(type,title,(cmd,n)=>{
            if(cmd!="choice"||n.Length!=1||n[0]<min||n[0]>max)return false;
            answer=result(n[0]);return true;
        },false);
        View.choice=new ChoiceView{id=revision,title=title,kind="number",min=min,max=max};return FinishPrompt(wait);
    }
    void InstallVisualDecisions()
    {
        InstallLibraryDecisions();
        InstallExtraDecisions();
        Human("confirmTrigger",a=>YesNo("可选触发 · "+Describe(a[0])));
        Human("confirmReplacementEffect",a=>YesNo(OptionalText(a[3])));
        Human("confirmStaticApplication",a=>YesNo(OptionalText(a[2])));
        Human("confirmPayment",a=>YesNo(OptionalText(a[1]),"支付","不支付"));
        Human("chooseBinary",a=>YesNo(OptionalText(a[1]),Describe(a[2])+" · 是","否"));
        Human("willPutCardOnTop",a=>YesNo(Name(a[0])+" · 放回牌库顶？","放在顶上","放在底下"));
        Human("chooseCardsToDiscardFrom",a=>{
            string owner=Seat(a[0])==0?"你的手牌":"对手的手牌";
            return Offers(owner+" · 选择要弃掉的牌",Items(a[2]),a[3].Int,a[4].Int,CardList,v=>Cards(v),
                "discard",visibleCards:Items(a[5]));
        });
        Human("chooseCardsToDiscardToMaximumHandSize",a=>{
            int count=a[0].Int;
            var hand=Zone(0,"Hand");
            return phaseLesson==null?CardSelection("弃到手牌上限",hand,count,count,Cards,CardList):
                Offers($"清理 · 选择弃掉 {count} 张牌，留下 {hand.Length-count} 张",hand,count,count,CardList,v=>Cards(v),"hand-discard");
        });
        Human("chooseCardsToRevealFromHand",a=>CardSelection("选择展示的手牌",Items(a[2]),a[0].Int,a[1].Int,Cards,CardList));
        Human("chooseCardsForEffect",a=>Offers(OptionalText(a[2]),Items(a[0]),a[3].Int,a[4].Int,CardList,v=>Cards(v),"cards",a[5].Int!=0));
        foreach(string key in new[]{"choosePermanentsToSacrifice","choosePermanentsToDestroy"})
            Human(key,a=>CardSelection(key.EndsWith("Sacrifice")?"选择要牺牲的永久物":"选择要消灭的永久物",Items(a[3]),a[1].Int,a[2].Int,Cards,CardList));
        Human("chooseCardsForCost",a=>Offers(OptionalText(a[5]),Items(a[0]),a[3].Int,a[3].Int,CardList,v=>v.Length==0&&a[4].Int!=0?default:Cards(v),"cards",a[4].Int!=0));
        Human("chooseEntitiesForEffect",a=>Offers(OptionalText(a[5]),Items(a[0]),a[1].Int,a[2].Int,JavaList,AsList));
        Human("chooseSingleEntityForEffect",a=>{
            var ability=a[2];
            var api=ability.Reference==null?null:g.Rt.InspectEnumName(C(ability,"getApi","()Lforge/game/ability/ApiType;"));
            bool legend=api=="InternalLegendaryRule";
            string prompt=api switch{
                "InternalLegendaryRule"=>"传奇规则 · 请选择要保留的永久物",
                "Untap"=>"选择要重置的永久物",
                _=>OptionalText(a[3])
            };
            return Offers(prompt,
                Items(a[0]),1,1,"Lforge/game/GameEntity;",v=>v.FirstOrDefault(),legend?"legend":"options",a[4].Int!=0);
        });
        Human("chooseSpellAbilitiesForEffect",a=>Offers(OptionalText(a[2]),Items(a[0]),a[3].Int,a[3].Int,JavaList,AsList));
        Human("getAbilityToPlay",a=>{
            var options=Items(a[1]);
            if(options.Length>1)options=options.Where(sa=>CanFundVariant(sa,0)).ToArray();
            return Single("选择异能",options,"Lforge/game/spellability/SpellAbility;");
        });
        foreach(var e in new[]{("chooseCounterType","选择指示物","Lforge/game/card/CounterType;"),("chooseKeywordForPump","选择关键字","Ljava/lang/String;"),("chooseSingleReplacementEffect","选择替代效应","Lforge/game/replacement/ReplacementEffect;"),("chooseSingleStaticAbility","选择静止式异能","Lforge/game/staticability/StaticAbility;"),("chooseRollToIgnore","忽略哪次掷骰","Ljava/lang/Integer;"),("chooseRollToModify","修改哪次掷骰","Ljava/lang/Integer;"),("chooseManaFromPool","选择法术力","Lforge/game/mana/Mana;"),("chooseStartingHand","选择起始手牌","Lforge/game/zone/PlayerZone;")})
            Human(e.Item1,a=>Single(e.Item2,Items(a[0]),e.Item3));
        Human("chooseSector",a=>Single("选择区域",Items(a[2]),"Ljava/lang/String;"));
        Human("chooseProtectionType",a=>Single("选择保护类别",Items(a[1]),"Ljava/lang/String;"));
        Human("chooseNumber",a=>a[2].Reference==null?Number(OptionalText(a[1]),a[2].Int,a[3].Int,"I",JValue.I):
            Offers(OptionalText(a[1]),Items(a[2]),1,1,"I",v=>JValue.I(g.Rt.UnboxInt(v.Single()))));
        foreach(string key in new[]{"chooseColor","chooseColorAllowColorless"}){
            Human(key,a=>{
                var colors=Items(C(a[2],"getOrderedColors","()Ljava/util/Collection;")).ToList();
                if(key=="chooseColorAllowColorless"&&!colors.Any(color=>g.Rt.InspectEnumName(color)=="COLORLESS"))
                    colors.Add(g.Enum("forge/card/MagicColor$Color","COLORLESS"));
                if(colors.Count==1)return JHostResult.Complete(C(colors[0],"getColorMask","()B"));
                return Offers("选择颜色",colors.ToArray(),1,1,"B",v=>C(v[0],"getColorMask","()B"));
            });
        }
        Human("chooseColors",a=>Offers("选择颜色",Items(C(a[4],"getOrderedColors","()Ljava/util/Collection;")),a[2].Int,a[3].Int,"Lforge/card/ColorSet;",
            v=>S("forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;",JValue.I(v.Aggregate(0,(mask,c)=>mask|C(c,"getColorMask","()B").Int)))));
        foreach(var e in new[]{("orderSimultaneousSa",0,"排列同时触发的异能",JavaList),("orderMoveToZoneList",0,"排列移动的牌",CardList),("orderAttackers",1,"排列攻击者","Lforge/game/card/CardCollection;"),("orderBlockers",1,"排列阻挡者","Lforge/game/card/CardCollection;")})
            Human(e.Item1,a=>{var items=Items(a[e.Item2]);JValue Build(JValue[] v)=>e.Item4==JavaList?AsList(v):Cards(v);
                return items.Length<2?JHostResult.Complete(Build(items)):Offers(e.Item3,items,items.Length,items.Length,e.Item4,Build,"order");});
        foreach(var e in new[]{("exertAttackers","选择要耗竭的生物"),("enlistAttackers","选择要征召的生物"),("chooseSaToActivateFromOpeningHand","选择起手可启动的异能")})
            Human(e.Item1,a=>{var items=Items(a[0]);return Offers(e.Item2,items,0,items.Length,JavaList,AsList);});
        Human("chooseModeForAbility",a=>{
            var modes=LegalModes(Items(a[1]));
            if(!HasModeCosts(a[0],modes))return Offers("选择模式",modes,a[2].Int,a[3].Int,JavaList,AsList,repeat:a[4].Int!=0);
            var combos=AffordableModes(a[0],modes,a[2].Int,a[3].Int).Select(AsList).ToArray();
            return Offers("选择可支付的模式组合",combos,1,1,JavaList,v=>v.Single(),label:v=>string.Join(" + ",Items(v).Select(Describe)));
        });
        Human("chooseOptionalCosts",a=>{
            var combos=OptionalCostOptions(a[0],Items(a[1]),0).Select(AsList).ToArray();
            if(combos.Length==1)return JHostResult.Complete(combos[0]);
            return Offers("选择额外费用",combos,1,1,JavaList,v=>v.Single(),label:v=>Items(v).Length==0?"无额外费用":string.Join(" + ",Items(v).Select(Describe)));
        });
    }
    JHostResult Single(string title,JValue[] options,string type)=>options.Length<2?JHostResult.Complete(options.FirstOrDefault()):
        Offers(title,options,1,1,type,v=>v.Single());
}

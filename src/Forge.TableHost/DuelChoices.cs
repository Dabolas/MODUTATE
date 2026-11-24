using Planeswalker.Core;
using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    public Action? WaitForInlineInput {get;set;}
    readonly HashSet<string> phaseStops=new(StringComparer.Ordinal);
    (int Turn,string Phase) lastPriorityWindow;
    int skippingTurn=-1;
    public void SetStops(IEnumerable<string> phases){phaseStops.Clear();phaseStops.UnionWith(phases);}
    string OptionalText(JValue v)=>v.Reference==null?"":g.Rt.StringValue(v);
    JHostResult FinishPrompt(JHostResult scheduled)
    {
        if(g.Rt.CanPauseForInput)return scheduled;
        if(WaitForInlineInput==null)throw new InvalidOperationException("Inline player decision requires a table input owner: "+View.prompt);
        while(Waiting)WaitForInlineInput();
        return JHostResult.Complete(answer);
    }
    JHostResult PickOne(JValue[] offered,string type,string title,Func<JValue,string> label,string kind="options",bool optional=false)
    {
        var wait=Ask(type,title,(cmd,ids)=>{
            if(cmd!="choice")return false;
            if(optional&&ids.Length==0){answer=default;return true;}
            if(ids.Length!=1||(uint)ids[0]>=offered.Length)return false;
            answer=offered[ids[0]];return true;
        },false);
        View.choice=new ChoiceView{id=revision,title=title,kind=kind,min=optional?0:1,max=1,
            options=offered.Select((v,i)=>new OptionView{id=i,label=label(v)}).ToArray()};
        return FinishPrompt(wait);
    }
    void InstallTableChoices()
    {
        g.SetDecision("chooseSomeType",(ctrl,a)=>{
            var options=Items(a[2]);
            if(checkingActions||ControllerSeat(ctrl)!=0)return JHostResult.Complete(Pick("type",options));
            var source=C(a[1],"getHostCard","()Lforge/game/card/Card;");
            string title=Name(source)+" · "+(OptionalText(a[0])=="Creature"?"选择生物类别":"选择类别");
            return PickOne(options,"Ljava/lang/String;",title,OptionalText,"table-type",a[3].Int!=0);
        });
        chooseOfferedFace=(ctrl,a)=>{
            var faces=Items(a[1]);
            if(faces.Length==0||checkingActions||ControllerSeat(ctrl)!=0)return JHostResult.Complete(faces.Length==0?default:Pick("choose offered card face",faces));
            return PickOne(faces,"Lforge/card/ICardFace;",OptionalText(a[2]),Name);
        };
        g.SetDecision("chooseSingleSpellForEffect",(ctrl,a)=>{
            var options=Items(a[0]);
            if(checkingActions||ControllerSeat(ctrl)!=0||options.Length==0)return JHostResult.Complete(options.Length==0?default:Pick("chooseSingleSpellForEffect",options));
            return PickOne(options,"Lforge/game/spellability/SpellAbility;",OptionalText(a[2]),sa=>{
                string room=OptionalText(C(sa,"getParam","(Ljava/lang/String;)Ljava/lang/String;",g.S("RoomName")));
                return room.Length>0?room:OptionalText(C(sa,"toString","()Ljava/lang/String;"));
            });
        });
        InstallVisualDecisions();
        g.SetDecision("confirmAction",(ctrl,a)=>{
            if(checkingActions||ControllerSeat(ctrl)!=0)
                return JHostResult.Complete(JValue.I(tape.Choose("confirmAction:"+ControllerSeat(ctrl),new[]{"no","yes"})));
            return YesNo(OptionalText(a[2]));
        });
    }
    JHostResult SearchLibrary(JValue[] args,JValue[] legal,int min,int max,bool multi,Func<IEnumerable<JValue>,JValue> build)
    {
        int Id(JValue card)=>C(card,"getId","()I").Int;
        var allowed=legal.ToDictionary(Id);
        var visible=legal.ToDictionary(Id,c=>VisibleLibraryCard(c,Id(c),"Library",true));
        var reveal=args[multi?6:4];
        if(reveal.Reference!=null){
            foreach(var card in Items(C(reveal,"getCards","()Lforge/trackable/TrackableCollection;"))){
                int id=Id(card);
                if(!visible.ContainsKey(id))visible.Add(id,VisibleLibraryCard(card,id,"Library",false));
            }
        }
        min=Math.Min(min,allowed.Count);max=Math.Min(max,allowed.Count);
        var wait=Ask(multi?"Ljava/util/List;":"Lforge/game/card/Card;","搜寻牌库",(cmd,ids)=>{
            if(cmd!="choice"||ids.Length<min||ids.Length>max||ids.Distinct().Count()!=ids.Length||ids.Any(id=>!allowed.ContainsKey(id)))return false;
            answer=build(ids.Select(id=>allowed[id]));return true;
        },false);
        var rows=visible.Values.OrderByDescending(c=>c.selectable).ThenBy(c=>c.name,StringComparer.Ordinal).ThenBy(c=>c.id).ToArray();
        View.choice=new ChoiceView{id=revision,title="搜寻牌库",kind="library",min=min,max=max,
            cards=rows,options=rows.Where(c=>c.selectable).Select(c=>new OptionView{id=c.id,label=c.name}).ToArray()};
        return FinishPrompt(wait);
    }
    CounterView[] Counters(JValue entity)
    {
        if(!B(entity,"hasCounters"))return Array.Empty<CounterView>();
        var counts=C(entity,"getCounters","()Lcom/google/common/collect/Multiset;");
        return Items(C(counts,"elementSet","()Ljava/util/Set;")).Select(type=>{
            string name=OptionalText(C(type,"getName","()Ljava/lang/String;"));
            return new CounterView{name=name,key=g.Rt.InspectEnumName(type)??name,amount=C(counts,"count","(Ljava/lang/Object;)I",type).Int};
        }).OrderBy(c=>c.key,StringComparer.Ordinal).ToArray();
    }
    CommandView CommandState(JValue player,int seat)
    {
        var dungeon=Zone(seat,"Command").FirstOrDefault(c=>B(C(c,"getType","()Lforge/card/CardTypeView;"),"isDungeon"));
        var bearer=C(player,"getRingBearer","()Lforge/game/card/Card;");
        int tempted=C(player,"getNumRingTemptedYou","()I").Int;
        return new CommandView{initiativeImplemented=true,dungeonImplemented=true,initiative=B(player,"hasInitiative"),
            monarch=B(player,"isMonarch"),ringTemptations=tempted,ringLevel=Math.Min(4,tempted),ringBearerId=bearer.Reference==null?-1:C(bearer,"getId","()I").Int,
            dungeon=dungeon.Reference==null?"":Name(dungeon),room=dungeon.Reference==null?"":OptionalText(C(dungeon,"getCurrentRoom","()Ljava/lang/String;"))};
    }
}

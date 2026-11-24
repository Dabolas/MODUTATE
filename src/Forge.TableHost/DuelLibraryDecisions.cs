using Planeswalker.Core;
using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    CardView VisibleLibraryCard(JValue card,int id,string zone,bool selectable)
    {
        string name=Name(card);
        var definition=catalogue.ContainsCard(name)?catalogue.GetCard(name):null;
        return new CardView{id=id,name=name,zone=zone,selectable=selectable,text=definition?.Value("Oracle")??"",type=definition?.Value("Types")??"",mana=definition?.Value("ManaCost")??""};
    }
    void InstallLibraryDecisions()
    {
        Human("arrangeForScry",a=>ArrangeTop(Items(a[0]),false));
        Human("arrangeForSurveil",a=>ArrangeTop(Items(a[0]),true));
        Human("reveal",a=>{
            var seen=Items(a[0]);if(seen.Length==0)return JHostResult.Complete();
            bool mine=Seat(a[2])==0||ReferenceEquals(a[2].Reference,C(g.Players[0],"getView","()Lforge/game/player/PlayerView;").Reference);
            string zone=g.Rt.InspectEnumName(a[1]) switch{"Library"=>"牌库","Hand"=>"手牌","Exile"=>"放逐区",var z=>z??""};
            string title=(mine?"你的":"对手的")+zone+" · 展示的牌";
            var wait=Ask("V",title,(cmd,ids)=>cmd=="choice"&&ids.Length==0,false);
            View.choice=new ChoiceView{id=revision,kind="reveal",title=title,cards=seen.Select((v,i)=>VisibleLibraryCard(v,i,"Revealed",false)).ToArray()};
            return FinishPrompt(wait);
        });
        Human("specifyManaCombo",a=>{
            var colors=OfferedColors(a[1]);
            return Offers("选择要产生的法术力",colors,a[2].Int,a[2].Int,"Ljava/util/Map;",values=>
                g.Rt.MapOf(values.GroupBy(v=>C(v,"getColorMask","()B").Int).Select(group=>new KeyValuePair<JValue,JValue>(
                    S("java/lang/Byte","valueOf","(B)Ljava/lang/Byte;",JValue.I(group.Key)),g.Rt.BoxInt(group.Count())))),repeat:a[3].Int==0);
        });
    }
    JHostResult ArrangeTop(JValue[] cards,bool surveil)
    {
        const string descriptor="Lorg/apache/commons/lang3/tuple/ImmutablePair;";
        JValue Pair(IEnumerable<JValue> top,IEnumerable<JValue> moved)=>S("org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;",Cards(top),Cards(moved));
        if(cards.Length==0)return JHostResult.Complete(Pair(cards,cards));
        string title=surveil?"刺探 · 你的牌库顶":"占卜 · 你的牌库顶";
        var wait=Ask(descriptor,title,(cmd,ids)=>{
            if(cmd!="choice"||ids.Length!=cards.Length+1||ids.Distinct().Count()!=ids.Length||ids.Any(i=>i< -1||i>=cards.Length))return false;
            int split=Array.IndexOf(ids,-1);
            if(split<0)return false;
            answer=Pair(ids.Take(split).Select(i=>cards[i]),ids.Skip(split+1).Select(i=>cards[i]));return true;
        },false);
        View.choice=new ChoiceView{id=revision,kind=surveil?"surveil":"scry",title=title,
            cards=cards.Select((c,i)=>VisibleLibraryCard(c,i,"Library",true)).ToArray(),
            options=cards.Select((c,i)=>new OptionView{id=i,label=Name(c)}).ToArray()};
        return FinishPrompt(wait);
    }
}

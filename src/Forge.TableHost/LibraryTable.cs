using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;
using Planeswalker.ForgeConsole;
using System.Text;

namespace Planeswalker.TableHost;

public sealed record TableCard(int Id,string Name,bool Selectable);

// Two repeatable player-facing acceptance scenes. The same generated stack remains
// suspended while Unity draws the search and resumes with the selected engine object.
public sealed class LibraryTable
{
    readonly L3Game game;
    readonly Dictionary<int,JValue> legal=new();
    readonly bool search;
    bool listAnswer, optional, resolving, answered;
    JValue spell;
    int? expectedHand;
    private readonly System.Diagnostics.Stopwatch elapsed=System.Diagnostics.Stopwatch.StartNew();
    private long? resumeAt;
    public bool Choosing=>game.Rt.Pending!=null&&!resumeAt.HasValue;
    public bool CanDecline=>Choosing&&optional;
    public bool ReadyToPlay {get;private set;}
    public bool Complete {get;private set;}
    public bool Passed {get;private set;}
    public string Status {get;private set;}="";
    public IReadOnlyList<TableCard> Cards {get;private set;}=Array.Empty<TableCard>();
    public LibraryTable(CardDatabase database,byte[] types,byte[] messages,bool search,Action<string>? trace=null)
    {
        this.search=search;
        game=new L3Game("",TableProgram.Open(),database,traceSink:trace,localization:new ConsoleLocalization(Encoding.UTF8.GetString(messages).Split('\n').Select(s=>s.TrimEnd('\r'))),typeList:types,live:true);
        game.Rt.CollectCoverage=true;
        game.Rt.Delay=ms=>{
            resumeAt=elapsed.ElapsedMilliseconds+Math.Min(ms,long.MaxValue-elapsed.ElapsedMilliseconds-1);
            return JHostResult.Suspend;
        };
        game.Initialize(0,44);
        if(search){
            foreach(string name in new[]{"Island","Mountain","Grizzly Bears","Forest","Wood Elves"})game.Card(name,0,"Library");
            spell=game.Card("Lay of the Land",0,"Hand");
            game.Fund(0,"G");
            game.SetDecision("chooseCardsForZoneChange",(_,a)=>Search(a,true));
            game.SetDecision("chooseSingleCardForZoneChange",(_,a)=>Search(a,false));
            ReadyToPlay=true;Status="遍览大地 · 从手牌施放，搜寻一张基本地。";
        }else{
            game.Card("Future Sight",0,"Battlefield");
            spell=game.Card("Divination",0,"Library");
            game.Card("Island",0,"Library");game.Card("Forest",0,"Library");
            game.Fund(0,"UCC");
            game.Call(game.Action,"checkStaticAbilities","()V");
            var top=Library().First();
            bool visible=game.Call(top,"mayPlayerLook","(Lforge/game/player/Player;)Z",game.Players[0]).Int!=0;
            if(!visible)throw new InvalidOperationException("Forge 未授予查看顶牌的权限。");
            ReadyToPlay=Playable(top).Length>0;
            Cards=new[]{Row(top,ReadyToPlay)};
            Status="未来视界 · 牌库顶公开。";
        }
    }
    JValue[] Library()=>game.Rt.ListItems(game.Call(game.Zone(0,"Library"),"getCards","()Lforge/game/card/CardCollectionView;"));
    int Id(JValue c)=>game.Call(c,"getId","()I").Int;
    TableCard Row(JValue c,bool enabled)=>new(Id(c),game.Rt.StringValue(game.Call(c,"getName","()Ljava/lang/String;")),enabled);
    JValue[] Playable(JValue card)=>game.Rt.ListItems(game.Call(card,"getAllPossibleAbilities","(Lforge/game/player/Player;Z)Ljava/util/List;",game.Players[0],JValue.I(1)))
        .Where(a=>game.Call(a,"isSpell","()Z").Int!=0&&game.Call(a,"canPlay","()Z").Int!=0).ToArray();
    JHostResult Search(JValue[] a,bool multi)
    {
        if(!search||!(ReferenceEquals(a[multi?8:7].Reference,game.Players[0].Reference)))throw new InvalidOperationException("Unexpected search viewer");
        listAnswer=multi;optional=multi?a[4].Int==0:a[6].Int!=0;
        if(multi&&a[5].Int!=1)throw new InvalidOperationException("Unexpected search size");
        legal.Clear();
        foreach(var card in game.Rt.ListItems(a[3]))legal.Add(Id(card),card);
        // The scenario's unrestricted search permits looking through the whole library;
        // Within each group, names and object IDs keep the physical library order private.
        Cards=Library().Select(c=>Row(c,legal.ContainsKey(Id(c)))).OrderByDescending(c=>c.Selectable)
            .ThenBy(c=>c.Name,StringComparer.Ordinal).ThenBy(c=>c.Id).ToArray();
        Status="搜寻你的牌库 · 选择一张基本地";return JHostResult.Suspend;
    }
    public void Cast()
    {
        if(!ReadyToPlay||Complete||Choosing)return;
        var ability=search?game.Ability(spell,0):Playable(Library().First()).First();
        if(!game.Cast(spell,ability,0)||!game.In(spell,"Stack"))throw new InvalidOperationException("Forge 拒绝施放。");
        resolving=true;ReadyToPlay=false;Cards=Array.Empty<TableCard>();Status="正在结算";
        game.Rt.Start(game.Rt.Program.Classes["forge/game/zone/MagicStack"].Methods["resolveStack()V"],game.Stack);
    }
    public void Select(int? card)
    {
        if(!Choosing||(!card.HasValue&&!optional)||(card.HasValue&&!legal.ContainsKey(card.Value)))throw new InvalidOperationException("无效或已过期的选择。");
        var selected=card.HasValue?legal[card.Value]:JValue.R(null);
        var answer=listAnswer?game.Rt.ListOf(card.HasValue?[selected]:[]):selected;
        expectedHand=card;
        game.Rt.Resume(game.Rt.Pending!.Id,answer);answered=true;Cards=Array.Empty<TableCard>();Status="正在结算";
    }
    public void Tick()
    {
        if(!resolving||Choosing||Complete)return;
        if(resumeAt.HasValue){
            if(elapsed.ElapsedMilliseconds<resumeAt.Value)return;
            game.Rt.Resume(game.Rt.Pending!.Id,default);
            resumeAt=null;
        }
        if(game.Rt.Run(25000)!=JRunState.Completed)return;
        game.Sba();
        bool paid=game.ManaCount(0)==0&&game.In(spell,"Graveyard");
        Passed=search?paid&&answered&&game.Rt.ExecutedMethods.Any(m=>m.Contains("Player.shuffle("))&&game.Count(0,"Hand")== (expectedHand.HasValue?1:0)
            &&(!expectedHand.HasValue||game.In(legal[expectedHand.Value],"Hand"))&&game.Count(0,"Library")== (expectedHand.HasValue?4:5)
            :paid&&game.Count(0,"Hand")==2&&game.Count(0,"Library")==0;
        Complete=true;
        Status=Passed?(search?(expectedHand.HasValue?"已找到基本地，移入手牌；搜寻结算完成。":"已放弃找牌，搜寻结算完成。"):"已从牌库顶施放 Divination，抓两张牌，咒语进入坟场。"):"结算状态与场景断言不符。";
    }
}

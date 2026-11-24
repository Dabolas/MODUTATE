using Planeswalker.Core;
using Planeswalker.ForgeAot;
using Planeswalker.TableHost;

public sealed partial class HeadlessMatch
{
    Action<BotTableMotion>? botMotion;
    Action<MatchView>? progressView;
    Func<bool>? canStreamPresentation;
    bool pendingProgress, turnChanged;
    int projectedTableSize;
    long lastProgress;

    internal void StreamPresentation(Action<BotTableMotion> onMotion,Action<MatchView> onProgress,Func<bool> canStream)
    {
        if(phaseLesson!=null)return;
        botMotion=onMotion;
        progressView=onProgress;
        canStreamPresentation=canStream;
        const string game="forge/game/Game", fire="(Lforge/game/event/Event;)V";
        var original=g.Rt.Program.Classes[game].Methods["fireEvent"+fire];
        g.Rt.Bind(game,"fireEvent",fire,(_,receiver,args)=>{
            if(!opening&&canStream())ObserveMotion(args[0]);
            return JHostResult.Schedule(new JFrame(original,receiver,args));
        });
    }

    void ObserveMotion(JValue message)
    {
        switch(message.Reference?.ClassName){
            case "forge/game/event/GameEventTurnBegan":
                turnChanged=pendingProgress=true;
                if(IsBotView(C(message,"turnOwner","()Lforge/game/player/PlayerView;")))botMotion!(new(BotMotionKind.Turn));
                break;
            case "forge/game/event/GameEventCardChangeZone":
                var to=C(message,"to","()Lforge/game/zone/ZoneView;");
                if(to.Reference==null)break;
                string zone=MotionZone(to);
                if(zone is not ("Battlefield" or "Hand"))break;
                if(!IsBotView(C(to,"player","()Lforge/game/player/PlayerView;")))break;
                string origin=MotionZone(C(message,"from","()Lforge/game/zone/ZoneView;"));
                if(zone=="Hand"){
                    if(origin=="Library")SendMotion(new(BotMotionKind.Draw));
                }else if(origin!="Battlefield"){
                    var card=C(message,"card","()Lforge/game/card/CardView;");
                    SendMotion(new(BotMotionKind.Enter,PublicMotionCard(card,zone),origin));
                }
                break;
            case "forge/game/event/GameEventSpellAbilityCast":
                var stack=C(message,"si","()Lforge/game/spellability/StackItemView;");
                if(!IsBotView(C(stack,"getActivatingPlayer","()Lforge/game/player/PlayerView;")))break;
                var spell=C(message,"sa","()Lforge/game/spellability/SpellAbilityView;");
                var host=C(spell,"getHostCard","()Lforge/game/card/CardView;");
                SendMotion(new(B(spell,"isSpell")?BotMotionKind.Cast:BotMotionKind.Activate,PublicMotionCard(host,"Stack")));
                break;
        }
    }

    void SendMotion(BotTableMotion motion)
    {
        pendingProgress=true;
        botMotion!(motion);
    }

    bool IsBotView(JValue view)=>view.Reference!=null&&C(view,"getId","()I").Int==C(g.Players[1],"getId","()I").Int;
    string MotionZone(JValue zone)=>zone.Reference==null?"":g.Rt.InspectEnumName(C(zone,"zoneType","()Lforge/game/zone/ZoneType;"))??"";

    CardView PublicMotionCard(JValue card,string zone)
    {
        if(card.Reference==null)return new CardView{name="面朝下的牌",zone=zone};
        var face=C(card,"getCurrentState","()Lforge/game/card/CardView$CardStateView;");
        return new CardView{id=C(card,"getId","()I").Int,zone=zone,
            name=B(card,"isFaceDown")?"面朝下的牌":Name(card),land=face.Reference!=null&&B(face,"isLand")};
    }

    void PublishProgressIfDue()
    {
        if(!pendingProgress||Waiting||progressView==null||canStreamPresentation?.Invoke()!=true)return;
        long now=System.Diagnostics.Stopwatch.GetTimestamp();
        int frequency=projectedTableSize>=100?4:12;
        if(!turnChanged&&now-lastProgress<System.Diagnostics.Stopwatch.Frequency/frequency)return;
        pendingProgress=turnChanged=false;
        lastProgress=now;
        progressView(ProjectTable());
    }
}

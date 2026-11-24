namespace Planeswalker.ForgeConsole;

public sealed class ConsolePlayer(int seat)
{
    public int Seat { get; }=seat;
    public int Life { get; internal set; }=20;
    public List<CardInstance> Library { get; }=[];
    public List<CardInstance> Hand { get; }=[];
    public List<CardInstance> Battlefield { get; }=[];
    public List<CardInstance> Graveyard { get; }=[];
    public Dictionary<char,int> Mana { get; }=[];
}
public sealed class ConsoleMatch
{
    public ConsolePlayer[] Players { get; }=[new(0),new(1)];
    public long Revision { get; private set; }
    public int Turn { get; private set; }
    public int Active { get; private set; }
    public DamageExecution? LastExecution { get; private set; }
    private readonly CardDatabase database;
    private readonly IGameHostAdapter host;
    private readonly AotDamageBridge bridge;
    private long requestId;
    private CardInstance? casting;
    private FixtureRule? rule;
    private int target=-1,passes;
    private bool landPlayed;
    private enum Stage { Idle,Target,Payment,Priority }
    private Stage stage;
    public ConsoleMatch(CardDatabase db,IGameHostAdapter adapter,AotDamageBridge effects)
    {database=db;host=adapter;bridge=effects;}
    public void LoadFortyLands()
    {
        for(int seat=0;seat<2;seat++)
        {for(int i=0;i<40;i++)Players[seat].Library.Add(database.Create(seat==0?"Mountain":"Plains",seat));for(int i=0;i<7;i++)Draw(seat);}
        host.Notify("SETUP: two players, 20 life; each library started with 40 basic lands; opening hands draw 7.");
    }
    public CardInstance AddIgnitionSpell(string name,int seat)
    {var card=database.Create(name,seat);card.Zone="Hand";Players[seat].Hand.Add(card);host.Notify("FIXTURE: one extra "+name+" placed in player "+seat+" hand; not part of the forty-land library.");return card;}
    private void Draw(int seat)
    {var player=Players[seat];if(player.Library.Count==0)throw new InvalidOperationException("Draw from empty library.");var card=player.Library[0];player.Library.RemoveAt(0);card.Zone="Hand";player.Hand.Add(card);host.Notify("DRAW player "+seat+": "+card.Definition.Name+"; library="+player.Library.Count);}
    public void BeginTurn(int seat)
    {
        if(stage!=Stage.Idle)throw new InvalidOperationException("Cannot change turns with a pending spell.");
        Active=seat;Turn++;var p=Players[seat];int untapped=p.Battlefield.Count(c=>c.Tapped);
        foreach(var c in p.Battlefield)c.Tapped=false;foreach(var player in Players)player.Mana.Clear();landPlayed=false;Revision++;
        host.Notify("TURN "+Turn+" player "+seat+": UNTAP "+untapped+" permanents; UPKEEP; DRAW (forced ignition setup).");Draw(seat);
    }
    public CardInstance PlayLand(int seat,CardInstance? selected=null)
    {
        if(seat!=Active||stage!=Stage.Idle)throw new InvalidOperationException("No main-phase priority.");
        if(landPlayed)throw new InvalidOperationException("Only one land per turn in this fixture.");
        var card=selected??Players[seat].Hand.First(c=>c.Definition.Value("Types").Split(' ').Contains("Land"));
        if(card.Owner!=seat||!Players[seat].Hand.Contains(card)||!FixtureCompiler.Compile(card.Definition).Land)throw new InvalidOperationException("Not a playable land from this hand.");
        card.Zone="Battlefield";Players[seat].Hand.Remove(card);Players[seat].Battlefield.Add(card);landPlayed=true;Revision++;host.Notify("LAND: "+card.Definition.Name+" entered battlefield.");return card;
    }
    public void TapForMana(CardInstance card)
    {
        if(card.Zone!="Battlefield"||card.Tapped)throw new InvalidOperationException("Land is not available.");var r=FixtureCompiler.Compile(card.Definition);
        if(!r.Land)throw new InvalidOperationException("Not a basic land.");card.Tapped=true;var pool=Players[card.Owner].Mana;pool[r.ManaColor]=pool.GetValueOrDefault(r.ManaColor)+1;Revision++;
        host.Notify("MANA player "+card.Owner+": tap "+card.Definition.Name+" -> {"+r.ManaColor+"}; pool="+string.Join(",",pool.Select(p=>p.Key+":"+p.Value)));
    }
    public void BeginCast(CardInstance card)
    {
        if(stage!=Stage.Idle||card.Zone!="Hand"||card.Owner!=Active)throw new InvalidOperationException("Cannot cast.");
        rule=FixtureCompiler.Compile(card.Definition);if(rule.Land)throw new InvalidOperationException("A land is not cast as a spell.");casting=card;stage=Stage.Target;target=-1;
        Request(card.Owner,HostDecisionKind.ChooseTargets,"Choose a legal target",Players.Select(p=>new HostOption(p.Seat,"Player "+p.Seat+" ("+p.Life+")")).ToArray());
    }
    private void Request(int seat,HostDecisionKind kind,string message,IReadOnlyList<HostOption> options)
    {host.Present(new HostDecision(++requestId,Revision,seat,kind,message,1,1,options));}
    public bool Advance()
    {
        if(stage==Stage.Idle)return false;
        var answer=host.TakeReply();if(answer.Revision!=Revision)throw new InvalidOperationException("A host reply became stale.");
        if(stage==Stage.Target)
        {target=checked((int)answer.Selected.Single());stage=Stage.Payment;Request(casting!.Owner,HostDecisionKind.PayCosts,"Pay "+casting.Definition.Value("ManaCost"),[new(1,"Pay from current mana pool")]);return true;}
        if(stage==Stage.Payment)
        {
            var player=Players[casting!.Owner];var remaining=new Dictionary<char,int>(player.Mana);
            foreach(var color in rule!.Colors)
            {if(remaining.GetValueOrDefault(color.Key)<color.Value){CancelCast();throw new InvalidOperationException("Insufficient mana; spell remains in hand.");}remaining[color.Key]-=color.Value;}
            int generic=rule.Generic;foreach(char color in "WUBRGC"){int spend=Math.Min(generic,remaining.GetValueOrDefault(color));remaining[color]=remaining.GetValueOrDefault(color)-spend;generic-=spend;}
            if(generic>0){CancelCast();throw new InvalidOperationException("Insufficient generic mana; spell remains in hand.");}
            player.Mana.Clear();foreach(var color in remaining)if(color.Value!=0)player.Mana.Add(color.Key,color.Value);
            player.Hand.Remove(casting);casting.Zone="Stack";Revision++;passes=0;stage=Stage.Priority;
            host.Notify("PAYMENT committed; mana consumed. STACK push: "+casting.Definition.Name+" -> player "+target);
            Request(casting.Owner,HostDecisionKind.Priority,"Pass priority",[new(1,"Pass")]);return true;
        }
        host.Notify("PRIORITY: player "+answer.Seat+" passes.");passes++;
        if(passes==1){Request(1-casting!.Owner,HostDecisionKind.Priority,"Opponent response window",[new(1,"Pass")]);return true;}
        LastExecution=bridge.Execute(casting!,rule!,target);
        int before=Players[target].Life;Players[target].Life-=LastExecution.Damage;Revision++;
        host.Notify("AOT executed DamageDealEffect.resolve; damage batch="+LastExecution.Damage+"; player "+target+": "+before+" -> "+Players[target].Life);
        casting!.Zone="Graveyard";Players[casting.Owner].Graveyard.Add(casting);host.Notify("RESOLVED: "+casting.Definition.Name+" -> Graveyard; stack empty.");
        casting=null;rule=null;stage=Stage.Idle;return false;
    }
    private void CancelCast()
    {host.Notify("CAST cancelled: insufficient mana; no costs committed and card remains in hand.");casting=null;rule=null;stage=Stage.Idle;target=-1;}
}

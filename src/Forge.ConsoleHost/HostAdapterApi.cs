namespace Planeswalker.ForgeConsole;

public enum HostDecisionKind
{
    ChooseTargets,Priority,PayCosts,ChooseMode,ChooseCards,ChoosePlayer,ChooseNumber,ChooseName,ChooseType,ChooseColor,
    OrderCards,OrderTriggers,ChooseReplacement,Mulligan,ChooseBottomCards,DeclareAttackers,DeclareBlockers,AssignDamage,
    Discard,Sacrifice,Reveal,Acknowledge,Confirm,Vote,DungeonRoom,Sideboard,Other
}
public sealed record HostOption(long Id,string Label);
public sealed record HostDecision(long Id,long Revision,int Seat,HostDecisionKind Kind,string Message,int Min,int Max,IReadOnlyList<HostOption> Options,bool HiddenInformation=false,int? MinNumber=null,int? MaxNumber=null,bool RequiresText=false,bool AllowRepeated=false);
public sealed record HostAnswer(long RequestId,long Revision,int Seat,IReadOnlyList<long> Selected,int? Number=null,string? Text=null);
public interface IGameHostAdapter
{
    // UI subscribes to this event; the engine remains suspended until a valid Reply.
    event Action<HostDecision>? DecisionRequested;
    HostDecision? Pending { get; }
    void Present(HostDecision decision);
    bool TryReply(HostAnswer answer,out string error);
    bool TryTakeReply(out HostAnswer? answer);
    HostAnswer TakeReply();
    void Notify(string message);
}
public sealed class HostMailbox : IGameHostAdapter
{
    public event Action<HostDecision>? DecisionRequested;
    public event Action<string>? Message;
    public HostDecision? Pending { get; private set; }
    private HostAnswer? answer;
    public void Present(HostDecision decision)
    {
        if(Pending!=null)throw new InvalidOperationException("A decision is already pending.");
        if(decision.Min<0||decision.Max<decision.Min||decision.Options.Select(o=>o.Id).Distinct().Count()!=decision.Options.Count||decision.MinNumber>decision.MaxNumber)throw new ArgumentException("Invalid decision bounds or duplicate option IDs.");
        Pending=decision with{Options=Array.AsReadOnly(decision.Options.ToArray())};answer=null;DecisionRequested?.Invoke(Pending);
    }
    public bool TryReply(HostAnswer value,out string error)
    {
        error="";var request=Pending;
        if(request==null||answer!=null||value.RequestId!=request.Id||value.Revision!=request.Revision||value.Seat!=request.Seat){error="Stale, duplicate or foreign decision.";return false;}
        var selected=value.Selected;
        if(selected.Count<request.Min||selected.Count>request.Max||!request.AllowRepeated&&selected.Distinct().Count()!=selected.Count||selected.Any(id=>!request.Options.Any(o=>o.Id==id))){error="Illegal option or selection count.";return false;}
        if((request.MinNumber.HasValue||request.MaxNumber.HasValue)&&(!value.Number.HasValue||value.Number<request.MinNumber||value.Number>request.MaxNumber)){error="Number is missing or outside the legal range.";return false;}
        if(request.RequiresText&&string.IsNullOrWhiteSpace(value.Text)){error="A name or text value is required.";return false;}
        answer=value with{Selected=Array.AsReadOnly(value.Selected.ToArray())};return true;
    }
    public bool TryTakeReply(out HostAnswer? value)
    {value=null;if(answer==null)return false;value=TakeReply();return true;}
    public HostAnswer TakeReply()
    {if(answer==null)throw new InvalidOperationException("The host has not answered.");var result=answer;answer=null;Pending=null;return result;}
    public void Notify(string message)=>Message?.Invoke(message);
}

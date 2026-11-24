using Planeswalker.ForgeAot;

namespace Planeswalker.ForgeConsole;

// The UI codec owns legality, hidden-information filtering and typed result conversion.
// Unknown callback families must throw PortGap, never return false/null as a default.
public interface IForgeDecisionCodec
{
    HostDecision Describe(JHostRequest call,int seat,long revision);
    JValue Encode(JHostRequest call,HostAnswer answer);
}

public sealed class AotHostAdapter
{
    private readonly JRuntime runtime;
    private readonly IGameHostAdapter mailbox;
    private readonly IForgeDecisionCodec codec;
    private readonly Func<JValue,int> seatForController;
    private readonly Func<long> revision;
    private long publishedCall;
    public int SuspendedCallbacks { get; }

    public AotHostAdapter(JRuntime runtime,IGameHostAdapter mailbox,IForgeDecisionCodec codec,int seat,Func<long> revision)
        :this(runtime,mailbox,codec,_=>seat,revision){}
    public AotHostAdapter(JRuntime runtime,IGameHostAdapter mailbox,IForgeDecisionCodec codec,Func<JValue,int> seatForController,Func<long> revision)
    {
        this.runtime=runtime;this.mailbox=mailbox;this.codec=codec;this.seatForController=seatForController;this.revision=revision;
        var methods=runtime.Program.Classes["forge/game/player/PlayerController"].Methods.Values.Where(m=>(m.Access&0x400)!=0).ToArray();
        foreach(var method in methods)runtime.Bind(method.Owner,method.Name,method.Descriptor,(r,s,a)=>JHostResult.Suspend);
        SuspendedCallbacks=methods.Length;
    }

    // The same generated C# stack is resumed after the answer; effects are not replayed.
    public JRunState Pump(int instructionBudget=10000)
    {
        if(runtime.Pending!=null&&publishedCall!=0)
        {
            if(!mailbox.TryTakeReply(out var answer))return JRunState.Waiting;
            if(answer!.Revision!=revision())throw new InvalidOperationException("Stale engine decision.");
            runtime.Resume(runtime.Pending.Id,codec.Encode(runtime.Pending,answer));publishedCall=0;
        }
        var state=runtime.Run(instructionBudget);
        if(state==JRunState.Waiting&&publishedCall==0)
        {
            int seat=seatForController(runtime.Pending!.Receiver);
            var request=codec.Describe(runtime.Pending!,seat,revision());
            if(request.Id!=runtime.Pending!.Id||request.Seat!=seat||request.Revision!=revision())throw new InvalidOperationException("Codec changed decision identity.");
            publishedCall=runtime.Pending.Id;mailbox.Present(request);
        }
        return state;
    }
}

// A real callback codec for the numeric choice used by X and other bounded choices.
// Other callback signatures remain explicitly unsupported by this console codec.
public sealed class ConsoleNumberCodec : IForgeDecisionCodec
{
    private const string Signature="forge/game/player/PlayerController.chooseNumber(Lforge/game/spellability/SpellAbility;Ljava/lang/String;II)I";
    public HostDecision Describe(JHostRequest call,int seat,long revision)
    {
        if(call.Method!=Signature)throw new PortGap("No console decision codec for "+call.Method);
        return new HostDecision(call.Id,revision,seat,HostDecisionKind.ChooseNumber,"Choose a number",0,0,[],MinNumber:call.Arguments[2].Int,MaxNumber:call.Arguments[3].Int);
    }
    public JValue Encode(JHostRequest call,HostAnswer answer)
    {if(call.Method!=Signature||!answer.Number.HasValue)throw new PortGap("Not a numeric callback response.");return JValue.I(answer.Number.Value);}
}

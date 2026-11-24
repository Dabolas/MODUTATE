using System.Collections.Concurrent;
using System.Threading;
using Newtonsoft.Json;
using Planeswalker.Core;

namespace Planeswalker.TableHost;

// One game-owned background job owns the entire interpreter, including nested decisions.
// The render thread only sees detached public views and sends revision-tagged replies.
public sealed class DuelSession : IDisposable
{
    sealed record Input(long Revision,string Command,int[] Ids,string[]? Stops=null);
    sealed record Decision(ulong State,Input Input,bool Completed);
    readonly BlockingCollection<Input> queue=new();
    readonly CancellationTokenSource cancel=new();
    readonly Func<HeadlessMatch> create;
    readonly string[] initialStops;
    readonly List<Decision> history=new();
    readonly object gate=new();
    readonly Queue<BotTableMotion> motions=new();
    const int MotionLimit=24;
    MatchView view=new(){status="starting"};
    int serial;
    int loadingPercent=4;
    bool submitted,rewind;
    HeadlessMatch match=null!;
    int cursor;
    ulong? destination;
    public Exception? Error {get;private set;}
    public string? FailureContext {get;private set;}
    public MatchView View {get{lock(gate)return view;}}
    public int LoadingPercent=>Volatile.Read(ref loadingPercent);
    public void ReportLoading(int percent)=>Volatile.Write(ref loadingPercent,percent);
    public BotTableMotion[] ReadMotions()
    {
        lock(gate){
            if(motions.Count==0)return Array.Empty<BotTableMotion>();
            var result=motions.ToArray();
            motions.Clear();
            return result;
        }
    }
    public DuelSession(Func<HeadlessMatch> create,string[] stops){this.create=create;initialStops=stops.ToArray();}
    public bool Send(long revision,string command,int[] ids,string[]? stops=null)
    {
        lock(gate){
            if(submitted||revision!=view.inputId||cancel.IsCancellationRequested||!view.inputReady&&!(command=="undo"&&view.canUndo))return false;
            submitted=true;queue.Add(new Input(revision,command,ids.ToArray(),stops?.ToArray()));return true;
        }
    }
    void Publish(MatchView state)
    {
        // Copy the rows the host mutates during input. Published stack rows and nested
        // values are built once and remain read-only on both sides of this boundary.
        var snapshot=state.CopyForTable();
        lock(gate){
            snapshot.inputId=++serial;if(snapshot.choice!=null)snapshot.choice.id=serial;
            snapshot.canUndo=history.Any(h=>h.Input.Command!="stops");
            view=snapshot;submitted=false;
        }
    }
    void PublishMotion(BotTableMotion motion)
    {
        if(rewind||cursor<history.Count)return;
        lock(gate){
            if(motions.Count==MotionLimit)motions.Dequeue();
            motions.Enqueue(motion);
        }
    }
    void PublishProgress(MatchView snapshot)
    {
        if(rewind||cursor<history.Count||snapshot.gameOver)return;
        // ProjectTable produces an independent snapshot used only by the renderer.
        lock(gate){snapshot.inputId=++serial;view=snapshot;submitted=false;}
    }
    static ulong Signature(MatchView v)
    {
        ulong hash=14695981039346656037UL;
        void Add(int value)=>hash=unchecked((hash^(uint)value)*1099511628211UL);
        void Text(string? value){
            Add(value?.Length??-1);
            if(value!=null)foreach(char c in value)Add(c);
        }
        Add(v.turn);Text(v.phase);Add(v.activePlayerId);Text(v.prompt);Text(v.okLabel);
        Add(v.pendingAttackerId);Add(v.selectedBlockerId);Add(v.players.Length);
        foreach(var player in v.players){
            Add(player.life);Add(player.libraryCount);Add(player.cards.Length);
            foreach(var card in player.cards){
                Add(card.id);Text(card.name);Text(card.zone);Add(card.tapped?1:0);Add(card.chosen?1:0);
                Add(card.preparedSpellId);Add(card.canCastPrepared?1:0);
                Text(card.attackTarget?.kind);Add(card.attackTarget?.id??-1);
                Add(card.blockingAttackerIds.Length);
                foreach(int attacker in card.blockingAttackerIds)Add(attacker);
            }
        }
        Add(v.stackItems.Length);
        foreach(var item in v.stackItems){Add(item.id);Text(item.text);}
        if(v.choice is { } choice){
            Text(choice.kind);Text(choice.title);Add(choice.min);Add(choice.max);Add(choice.options.Length);
            foreach(var option in choice.options){Add(option.id);Text(option.label);Add(option.disabled?1:0);}
            Add(choice.cards.Length);
            foreach(var card in choice.cards){Add(card.id);Add(card.instanceId);Text(card.name);Add(card.selectable?1:0);}
        }
        return hash;
    }
    public void Run(CancellationToken loaderToken)
    {
        using var lifetime=CancellationTokenSource.CreateLinkedTokenSource(cancel.Token,loaderToken);
        var token=lifetime.Token;
        try{
            do{
                rewind=false;cursor=0;token.ThrowIfCancellationRequested();
                ReportLoading(34);
                match=create();match.SetStops(initialStops);match.PromptSnapshotsOnly=true;
                match.StreamPresentation(PublishMotion,PublishProgress,()=>!rewind&&cursor>=history.Count);
                match.OnOpeningProgress=ReportLoading;
                match.WaitForInlineInput=()=>Decide(token);
                try{
                    while(!rewind){
                        token.ThrowIfCancellationRequested();
                        if(match.Waiting||match.Finished)Decide(token);else match.Tick();
                    }
                }catch(Exception) when(rewind){}
            }while(rewind);
        }catch(Exception) when(token.IsCancellationRequested){}
        catch(Exception ex){
            Error=ex;
            FailureContext=JsonConvert.SerializeObject(new{
                replayCursor=cursor,
                lastState=match?.View,
                decisions=history.Select(record=>new{record.Input,record.Completed})
            });
            Publish(new MatchView{status="error",error=ex.Message});
        }
    }
    void Decide(CancellationToken token)
    {
        var v=match.View;
        ulong signature=Signature(v);
        bool replay=cursor<history.Count;
        Input input;
        if(replay){
            var record=history[cursor];
            if(record.State!=signature)throw new InvalidOperationException("回滚时对局选择与原记录不同，第 "+(cursor+1)+" 步");
            input=record.Input;
        }else{
            if(destination!=null&&destination!=signature)throw new InvalidOperationException("回滚未到达原决定点");
            destination=null;
            if(LoadingPercent<100)ReportLoading(100);
            Publish(v);
            input=queue.Take(token);
            if(input.Command=="undo"){
                int at=history.FindLastIndex(h=>h.Input.Command!="stops");
                if(at<0)return;
                destination=history[at].State;
                history.RemoveRange(at,history.Count-at);rewind=true;
                lock(gate)motions.Clear();
                Publish(new MatchView{status="starting",prompt="正在回滚"});
                throw new OperationCanceledException("rewind");
            }
        }
        long before=v.inputId;
        bool completed;
        if(input.Command=="stops"){match.SetStops(input.Stops!);completed=true;}
        else completed=match.Submit(before,input.Command,input.Ids);
        if(replay){
            if(history[cursor].Completed!=completed)throw new InvalidOperationException("回滚输入结果不一致");
            cursor++;
        }else if(completed||match.View.inputId!=before){
            history.Add(new Decision(signature,input,completed));cursor++;
        }
    }
    public void Dispose()=>cancel.Cancel();
}

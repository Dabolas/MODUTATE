using System;
using System.Collections.Generic;
using System.Linq;

namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class ObservableState {internal bool Changed;internal readonly List<JValue> Observers=new List<JValue>();}
        private readonly Dictionary<int,ObservableState> observables=new Dictionary<int,ObservableState>();
        private ObservableState Observable(JValue value)=>observables.TryGetValue(NonNull(value).Identity,out var state)?state:throw new PortGap("Observable constructor has not executed");
        private void InstallObservables()
        {
            const string type="java/util/Observable";NativeClass(type);NativeClass("java/util/Observer");
            StandardBind(type,"<init>","()V",(r,s,a)=>{r.observables.Add(r.NonNull(s).Identity,new ObservableState());return Done();});
            StandardBind(type,"addObserver","(Ljava/util/Observer;)V",(r,s,a)=>{r.NonNull(a[0]);var state=r.Observable(s);if(!state.Observers.Any(v=>r.NativeEqual(v,a[0])))state.Observers.Add(a[0]);return Done();});
            StandardBind(type,"deleteObserver","(Ljava/util/Observer;)V",(r,s,a)=>{var state=r.Observable(s);int at=state.Observers.FindIndex(v=>r.NativeEqual(v,a[0]));if(at>=0)state.Observers.RemoveAt(at);return Done();});
            StandardBind(type,"deleteObservers","()V",(r,s,a)=>{r.Observable(s).Observers.Clear();return Done();});
            StandardBind(type,"countObservers","()I",(r,s,a)=>Done(JValue.I(r.Observable(s).Observers.Count)));
            StandardBind(type,"setChanged","()V",(r,s,a)=>{r.Observable(s).Changed=true;return Done();});
            StandardBind(type,"clearChanged","()V",(r,s,a)=>{r.Observable(s).Changed=false;return Done();});
            StandardBind(type,"hasChanged","()Z",(r,s,a)=>Done(JValue.I(r.Observable(s).Changed?1:0)));
            foreach(string descriptor in new[]{"()V","(Ljava/lang/Object;)V"})StandardBind(type,"notifyObservers",descriptor,(r,s,a)=>
            {
                var state=r.Observable(s);if(!state.Changed)return Done();state.Changed=false;var observers=state.Observers.ToArray();int index=observers.Length-1;var argument=a.Length==0?JValue.R(null):a[0];
                var method=new JMethod(-100,"java/lang/Object","<notify-observers>","()V",8,0,4,Array.Empty<JHandler>(),(t,f)=>
                {if(!t.Tick())return JStep.Yield;if(f.Pc==1){index--;f.Pc=0;}if(index<0)return JStep.ReturnVoid;if(f.Pc==0){f.Push(observers[index]);f.Push(s);f.Push(argument);f.Pc=2;}return t.Call(f,"java/util/Observer","update","(Ljava/util/Observable;Ljava/lang/Object;)V","invokeinterface",1);});
                return JHostResult.Schedule(new JFrame(method,default,Array.Empty<JValue>()));
            });
        }
    }
}

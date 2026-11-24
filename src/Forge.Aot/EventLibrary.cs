using System;
using System.Collections.Generic;
using System.Linq;

namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class JavaEventBus {internal readonly List<JValue> Subscribers=new List<JValue>();}
        // Subscriber signatures come from an explicit host catalog of @Subscribe annotations.
        // Unknown subscribers are rejected; events are never silently discarded by a stub.
        public void InstallEventBus(IReadOnlyDictionary<string,(string Method,string Event)> catalog)
        {
            const string bus="com/google/common/eventbus/EventBus";NativeClass(bus);
            StandardBind(bus,"<init>","(Ljava/lang/String;)V",(r,s,a)=>{r.NonNull(a[0]);var value=r.NonNull(s);value.Payload=new JavaEventBus();value.HostStorage=true;return Done();});
            StandardBind(bus,"register","(Ljava/lang/Object;)V",(r,s,a)=>{string type=r.NonNull(a[0]).ClassName;if(!catalog.ContainsKey(type))throw new PortGap("Event subscriber metadata not mounted: "+type);var listeners=r.HostPayload<JavaEventBus>(s).Subscribers;if(!listeners.Any(v=>ReferenceEquals(v.Reference,a[0].Reference)))listeners.Add(a[0]);return Done();});
            StandardBind(bus,"unregister","(Ljava/lang/Object;)V",(r,s,a)=>{var listeners=r.HostPayload<JavaEventBus>(s).Subscribers;int at=listeners.FindIndex(v=>ReferenceEquals(v.Reference,a[0].Reference));if(at<0)throw r.Fault("java/lang/IllegalArgumentException");listeners.RemoveAt(at);return Done();});
            StandardBind(bus,"post","(Ljava/lang/Object;)V",(r,s,a)=>
            {
                r.NonNull(a[0]);var listeners=r.HostPayload<JavaEventBus>(s).Subscribers.Where(v=>r.IsInstance(a[0].Reference,catalog[r.NonNull(v).ClassName].Event)).ToArray();int index=0;
                var method=new JMethod(-97,"java/lang/Object","<event-dispatch>","()V",8,0,3,Array.Empty<JHandler>(),(t,f)=>
                {
                    if(!t.Tick())return JStep.Yield;
                    if(f.Pc==1){index++;f.Pc=0;}
                    if(index==listeners.Length)return JStep.ReturnVoid;
                    var listener=listeners[index];string owner=t.NonNull(listener).ClassName;var entry=catalog[owner];
                    if(f.Pc==0){f.Push(listener);f.Push(a[0]);f.Pc=2;}
                    return t.Call(f,owner,entry.Method,"(L"+entry.Event+";)V","invokevirtual",1);
                });
                return JHostResult.Schedule(new JFrame(method,default,Array.Empty<JValue>()));
            });
        }
        public void InstallDiagnosticLog(Action<string> write)
        {
            NativeClass("org/tinylog/Logger");NativeClass("org/tinylog/TaggedLogger");
            StandardBind("org/tinylog/Logger","tag","(Ljava/lang/String;)Lorg/tinylog/TaggedLogger;",(r,s,a)=>Done(JValue.R(r.HostObject("org/tinylog/TaggedLogger",r.Text(a[0])))));
            foreach(string owner in new[]{"org/tinylog/Logger","org/tinylog/TaggedLogger"})foreach(string level in new[]{"debug","info","warn","error","trace"})
            {
                StandardBind(owner,level,"(Ljava/lang/String;)V",(r,s,a)=>{write(level+": "+r.Text(a[0]));return Done();});
                StandardBind(owner,level,"(Ljava/lang/String;[Ljava/lang/Object;)V",(r,s,a)=>
                {
                    string format=r.Text(a[0]);var result=new System.Text.StringBuilder();int from=0,index=0,at;
                    while(index<r.ArrayLength(a[1])&&(at=format.IndexOf("{}",from,StringComparison.Ordinal))>=0)
                    {
                        result.Append(format,from,at-from);var value=r.ArrayLoad(a[1],index++);
                        result.Append(value.Reference==null?"null":r.Text(r.InlineCall("java/lang/Object","toString","()Ljava/lang/String;",value,Array.Empty<JValue>())));from=at+2;
                    }
                    result.Append(format,from,format.Length-from);write(level+": "+result);return Done();
                });
            }
        }
    }
}

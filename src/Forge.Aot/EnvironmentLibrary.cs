using System;
using System.Collections.Generic;
using System.Threading;

namespace Planeswalker.ForgeAot
{
    public interface IJavaEnvironmentHost
    {long MaximumMemory{get;}long UsedMemory{get;}int ProcessorCount{get;}string? Property(string key);}
    public sealed partial class JRuntime
    {
        public Func<long,JHostResult>? Delay {get;set;}
        private sealed class LocalValues {internal readonly Dictionary<int,JValue> Values=new Dictionary<int,JValue>();}
        private readonly Dictionary<int,LocalValues> localValues=new Dictionary<int,LocalValues>();
        private sealed class AtomicValue {internal long Value;internal AtomicValue(long value){Value=value;}}
        public void InstallEnvironment(IJavaEnvironmentHost host)
        {
            NativeClass("java/lang/Runtime");var runtime=JValue.R(HostObject("java/lang/Runtime",host));
            StandardBind("java/lang/Runtime","getRuntime","()Ljava/lang/Runtime;",(r,s,a)=>Done(runtime));
            StandardBind("java/lang/Runtime","maxMemory","()J",(r,s,a)=>Done(JValue.L(host.MaximumMemory)));
            // A managed heap has no committed-but-unused capacity available through netstandard.
            // Model total as used and free as zero; max-(total-free) remains the host budget headroom.
            StandardBind("java/lang/Runtime","totalMemory","()J",(r,s,a)=>Done(JValue.L(host.UsedMemory)));
            StandardBind("java/lang/Runtime","freeMemory","()J",(r,s,a)=>Done(JValue.L(0)));
            StandardBind("java/lang/Runtime","availableProcessors","()I",(r,s,a)=>Done(JValue.I(host.ProcessorCount)));
            StandardBind("java/lang/Boolean","getBoolean","(Ljava/lang/String;)Z",(r,s,a)=>Done(JValue.I(a[0].Reference!=null&&string.Equals(host.Property(r.Text(a[0])),"true",StringComparison.OrdinalIgnoreCase)?1:0)));
            foreach(string descriptor in new[]{"(Ljava/lang/String;)Ljava/lang/String;","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"})StandardBind("java/lang/System","getProperty",descriptor,(r,s,a)=>{string key=r.Text(a[0]);if(key.Length==0)throw r.Fault("java/lang/IllegalArgumentException");string? value=host.Property(key);return Done(value!=null?JValue.R(r.String(value)):a.Length==2?a[1]:JValue.R(null));});
        }
        private void InstallExecutionUtilities()
        {
            NativeClass("java/lang/Thread");NativeClass("java/lang/InterruptedException","java/lang/Exception");
            StandardBind("java/lang/Thread","sleep","(J)V",(r,s,a)=>{
                if(a[0].Long<0)throw r.Fault("java/lang/IllegalArgumentException");
                try{return r.Delay?.Invoke(a[0].Long)??JHostResult.Suspend;}
                catch(ThreadInterruptedException){throw r.Fault("java/lang/InterruptedException");}
            });
            NativeClass("java/lang/ThreadLocal");NativeClass("java/lang/InheritableThreadLocal","java/lang/ThreadLocal");
            foreach(string owner in new[]{"java/lang/ThreadLocal","java/lang/InheritableThreadLocal"})
            {
                StandardBind(owner,"<init>","()V",(r,s,a)=>{r.localValues[r.NonNull(s).Identity]=new LocalValues();return Done();});
                StandardBind(owner,"initialValue","()Ljava/lang/Object;",(r,s,a)=>Done(JValue.R(null)));
                StandardBind(owner,"set","(Ljava/lang/Object;)V",(r,s,a)=>{r.localValues[r.NonNull(s).Identity].Values[Environment.CurrentManagedThreadId]=a[0];return Done();});
                StandardBind(owner,"remove","()V",(r,s,a)=>{r.localValues[r.NonNull(s).Identity].Values.Remove(Environment.CurrentManagedThreadId);return Done();});
                StandardBind(owner,"get","()Ljava/lang/Object;",(r,s,a)=>{var values=r.localValues[r.NonNull(s).Identity].Values;int thread=Environment.CurrentManagedThreadId;if(values.TryGetValue(thread,out var value))return Done(value);return r.Callback("java/lang/ThreadLocal","initialValue","()Ljava/lang/Object;",s,Array.Empty<JValue>(),(t,v)=>{values[thread]=v;return v;});});
            }
            foreach(string owner in new[]{"java/util/concurrent/atomic/AtomicLong","java/util/concurrent/atomic/LongAdder"})
            {
                NativeClass(owner,"java/lang/Number");StandardBind(owner,"<init>","()V",(r,s,a)=>{var o=r.NonNull(s);o.Payload=new AtomicValue(0);o.HostStorage=true;return Done();});
                StandardBind(owner,"<init>","(J)V",(r,s,a)=>{var o=r.NonNull(s);o.Payload=new AtomicValue(a[0].Long);o.HostStorage=true;return Done();});
                foreach(string name in new[]{"get","sum","longValue"})StandardBind(owner,name,"()J",(r,s,a)=>Done(JValue.L(Interlocked.Read(ref r.HostPayload<AtomicValue>(s).Value))));
                StandardBind(owner,"set","(J)V",(r,s,a)=>{Interlocked.Exchange(ref r.HostPayload<AtomicValue>(s).Value,a[0].Long);return Done();});
                StandardBind(owner,"incrementAndGet","()J",(r,s,a)=>Done(JValue.L(Interlocked.Increment(ref r.HostPayload<AtomicValue>(s).Value))));
                StandardBind(owner,"getAndIncrement","()J",(r,s,a)=>Done(JValue.L(unchecked(Interlocked.Increment(ref r.HostPayload<AtomicValue>(s).Value)-1))));
                StandardBind(owner,"increment","()V",(r,s,a)=>{Interlocked.Increment(ref r.HostPayload<AtomicValue>(s).Value);return Done();});
                StandardBind(owner,"add","(J)V",(r,s,a)=>{Interlocked.Add(ref r.HostPayload<AtomicValue>(s).Value,a[0].Long);return Done();});
                StandardBind(owner,"reset","()V",(r,s,a)=>{Interlocked.Exchange(ref r.HostPayload<AtomicValue>(s).Value,0);return Done();});
            }
        }
    }
}

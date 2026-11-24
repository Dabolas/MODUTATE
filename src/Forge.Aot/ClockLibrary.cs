using System;
using System.Diagnostics;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class StopwatchState {internal readonly Stopwatch Watch=new Stopwatch();internal int State;}
        private void InstallStopwatches()
        {
            const string type="org/apache/commons/lang3/time/StopWatch";NativeClass(type);NativeClass("java/util/concurrent/TimeUnit");
            foreach(var unit in new[]{("NANOSECONDS",1L),("MICROSECONDS",1000L),("MILLISECONDS",1000000L),("SECONDS",1000000000L),("MINUTES",60000000000L),("HOURS",3600000000000L),("DAYS",86400000000000L)})
            {var value=JValue.R(HostObject("java/util/concurrent/TimeUnit",unit.Item2));BindStatic("java/util/concurrent/TimeUnit",unit.Item1,"Ljava/util/concurrent/TimeUnit;",()=>value);}
            StandardBind(type,"<init>","()V",(r,s,a)=>{var obj=r.NonNull(s);obj.Payload=new StopwatchState();obj.HostStorage=true;return Done();});
            StandardBind(type,"start","()V",(r,s,a)=>{var state=r.HostPayload<StopwatchState>(s);if(state.State!=0)throw r.Fault("java/lang/IllegalStateException");state.State=1;state.Watch.Start();return Done();});
            StandardBind(type,"stop","()V",(r,s,a)=>{var state=r.HostPayload<StopwatchState>(s);if(state.State!=1)throw r.Fault("java/lang/IllegalStateException");state.State=2;state.Watch.Stop();return Done();});
            StandardBind(type,"getTime","()J",(r,s,a)=>Done(JValue.L(r.HostPayload<StopwatchState>(s).Watch.ElapsedMilliseconds)));
            StandardBind(type,"getTime","(Ljava/util/concurrent/TimeUnit;)J",(r,s,a)=>Done(JValue.L((long)(r.HostPayload<StopwatchState>(s).Watch.ElapsedTicks*(1000000000.0/Stopwatch.Frequency)/r.HostPayload<long>(a[0])))));
        }
    }
}

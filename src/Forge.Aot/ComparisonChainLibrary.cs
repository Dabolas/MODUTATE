using System;

namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class ComparisonState
        {internal readonly int Result;internal ComparisonState(int result){Result=Math.Sign(result);}}
        private void InstallComparisonChain()
        {
            const string type="com/google/common/collect/ComparisonChain";NativeClass(type);
            StandardBind(type,"start","()L"+type+";",(r,s,a)=>Done(JValue.R(r.HostObject(type,new ComparisonState(0)))));
            StandardBind(type,"result","()I",(r,s,a)=>Done(JValue.I(r.HostPayload<ComparisonState>(s).Result)));
            foreach(string parameters in new[]{"II","Ljava/lang/Comparable;Ljava/lang/Comparable;"})
                StandardBind(type,"compare","("+parameters+")L"+type+";",(r,s,a)=>{
                    // ComparisonChain is immutable: the first nonzero comparison
                    // wins, and subsequent comparables must never be evaluated.
                    if(r.HostPayload<ComparisonState>(s).Result!=0)return Done(s);
                    int result=parameters=="II"?a[0].Int.CompareTo(a[1].Int):r.InlineCall("java/lang/Comparable","compareTo","(Ljava/lang/Object;)I",a[0],new[]{a[1]}).Int;
                    return Done(result==0?s:JValue.R(r.HostObject(type,new ComparisonState(result))));
                });
        }
    }
}

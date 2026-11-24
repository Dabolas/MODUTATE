using System;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class NativeRange
        {internal readonly JValue Minimum,Maximum;internal NativeRange(JValue min,JValue max){Minimum=min;Maximum=max;}}
        private void InstallRanges()
        {
            const string type="org/apache/commons/lang3/Range";NativeClass(type);
            StandardBind(type,"of","(Ljava/lang/Comparable;Ljava/lang/Comparable;)L"+type+";",(r,s,a)=>
            {r.NonNull(a[0]);r.NonNull(a[1]);bool ordered=r.CompareNative(a[0],a[1])<=0;return Done(JValue.R(r.HostObject(type,new NativeRange(a[ordered?0:1],a[ordered?1:0]))));});
            StandardBind(type,"is","(Ljava/lang/Comparable;)L"+type+";",(r,s,a)=>{r.NonNull(a[0]);return Done(JValue.R(r.HostObject(type,new NativeRange(a[0],a[0]))));});
            StandardBind(type,"getMinimum","()Ljava/lang/Object;",(r,s,a)=>Done(r.HostPayload<NativeRange>(s).Minimum));
            StandardBind(type,"getMaximum","()Ljava/lang/Object;",(r,s,a)=>Done(r.HostPayload<NativeRange>(s).Maximum));
            StandardBind(type,"contains","(Ljava/lang/Object;)Z",(r,s,a)=>{var range=r.HostPayload<NativeRange>(s);return Done(JValue.I(a[0].Reference!=null&&r.CompareNative(range.Minimum,a[0])<=0&&r.CompareNative(range.Maximum,a[0])>=0?1:0));});
        }
    }
}

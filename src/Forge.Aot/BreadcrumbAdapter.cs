using System;
using System.Collections.Generic;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class DiagnosticBreadcrumb
        {internal string Message="";internal readonly Dictionary<string,JValue> Data=new Dictionary<string,JValue>(StringComparer.Ordinal);}
        // Explicit local diagnostics host. Never initializes or calls the Sentry SDK/network.
        public void InstallBreadcrumbSink(Action<string,IReadOnlyDictionary<string,JValue>> sink)
        {
            if(sink==null)throw new ArgumentNullException(nameof(sink));
            const string type="io/sentry/Breadcrumb";NativeClass(type);NativeClass("io/sentry/Sentry");
            StandardBind("io/sentry/Sentry","setExtra","(Ljava/lang/String;Ljava/lang/String;)V",(r,s,a)=>{sink("extra: "+r.Text(a[0]),new Dictionary<string,JValue>{{"value",a[1]}});return Done();});
            StandardBind("io/sentry/Sentry","removeExtra","(Ljava/lang/String;)V",(r,s,a)=>{sink("remove extra: "+r.Text(a[0]),new Dictionary<string,JValue>());return Done();});
            foreach(string descriptor in new[]{"()V","(Ljava/lang/String;)V"})StandardBind(type,"<init>",descriptor,(r,s,a)=>{var obj=r.NonNull(s);obj.Payload=new DiagnosticBreadcrumb{Message=a.Length==0||a[0].Reference==null?"":r.Text(a[0])};obj.HostStorage=true;return Done();});
            StandardBind(type,"setMessage","(Ljava/lang/String;)V",(r,s,a)=>{r.HostPayload<DiagnosticBreadcrumb>(s).Message=a[0].Reference==null?"":r.Text(a[0]);return Done();});
            StandardBind(type,"setData","(Ljava/lang/String;Ljava/lang/Object;)V",(r,s,a)=>{r.HostPayload<DiagnosticBreadcrumb>(s).Data[r.Text(a[0])]=a[1];return Done();});
            StandardBind("io/sentry/Sentry","addBreadcrumb","(Lio/sentry/Breadcrumb;)V",(r,s,a)=>{var breadcrumb=r.HostPayload<DiagnosticBreadcrumb>(a[0]);sink(breadcrumb.Message,new Dictionary<string,JValue>(breadcrumb.Data,StringComparer.Ordinal));return Done();});
        }
    }
}

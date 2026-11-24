using System;
namespace Planeswalker.ForgeAot
{
    public interface IJavaPlatformHost
    {long CurrentTimeMillis();long NanoTime();string LineSeparator{get;}void Write(string text);}
    public sealed partial class JRuntime
    {
        public void InstallPlatformHost(IJavaPlatformHost host)
        {
            NativeClass("java/io/PrintStream");var output=JValue.R(HostObject("java/io/PrintStream",host));
            BindStatic("java/lang/System","out","Ljava/io/PrintStream;",()=>output);
            BindStatic("java/lang/System","err","Ljava/io/PrintStream;",()=>output);
            Bind("java/lang/System","currentTimeMillis","()J",(r,s,a)=>Done(JValue.L(host.CurrentTimeMillis())));
            Bind("java/lang/System","nanoTime","()J",(r,s,a)=>Done(JValue.L(host.NanoTime())));
            Bind("java/lang/System","lineSeparator","()Ljava/lang/String;",(r,s,a)=>Done(JValue.R(r.String(host.LineSeparator))));
            Bind("java/io/PrintStream","print","(Ljava/lang/String;)V",(r,s,a)=>{host.Write(a[0].Reference==null?"null":r.Text(a[0]));return Done();});
            Bind("java/io/PrintStream","println","(Ljava/lang/String;)V",(r,s,a)=>{host.Write((a[0].Reference==null?"null":r.Text(a[0]))+host.LineSeparator);return Done();});
            Bind("java/io/PrintStream","println","()V",(r,s,a)=>{host.Write(host.LineSeparator);return Done();});
            Bind("java/io/PrintStream","printf","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;",(r,s,a)=>{
                r.NonNull(a[0]);var destination=r.HostPayload<IJavaPlatformHost>(s);
                destination.Write(r.FormatJava(r.Text(a[0]),r.ArrayObject(a[1]).Items,destination.LineSeparator));return Done(s);
            });
        }
    }
}

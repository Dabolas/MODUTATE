using System;

namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private void InstallIntrinsics()
        {
            Bind("java/lang/Object","<init>","()V",(r,s,a)=>JHostResult.Complete());
            Bind("java/lang/Object","equals","(Ljava/lang/Object;)Z",(r,s,a)=>JHostResult.Complete(JValue.I(ReferenceEquals(s.Reference,a[0].Reference)?1:0)));
            Bind("java/lang/Object","hashCode","()I",(r,s,a)=>JHostResult.Complete(JValue.I(r.NonNull(s).Identity)));
            Bind("java/lang/Object","getClass","()Ljava/lang/Class;",(r,s,a)=>JHostResult.Complete(JValue.R(r.ClassObject(r.NonNull(s).ClassName))));
            Bind("java/lang/Object","toString","()Ljava/lang/String;",(r,s,a)=>r.Callback("java/lang/Object","hashCode","()I",s,Array.Empty<JValue>(),(t,v)=>JValue.R(t.String(t.NonNull(s).ClassName.Replace('/','.')+"@"+unchecked((uint)v.Int).ToString("x",System.Globalization.CultureInfo.InvariantCulture)))));
            Bind("java/lang/System","identityHashCode","(Ljava/lang/Object;)I",(r,s,a)=>JHostResult.Complete(JValue.I(a[0].Reference?.Identity??0)));
            Bind("java/lang/String","length","()I",(r,s,a)=>JHostResult.Complete(JValue.I(r.Text(s).Length)));
            Bind("java/lang/String","isEmpty","()Z",(r,s,a)=>JHostResult.Complete(JValue.I(r.Text(s).Length==0?1:0)));
            Bind("java/lang/String","charAt","(I)C",(r,s,a)=>
            {string text=r.Text(s);int at=a[0].Int;if(at<0||at>=text.Length)throw r.Fault("java/lang/StringIndexOutOfBoundsException");return JHostResult.Complete(JValue.I(text[at]));});
            Bind("java/lang/String","equals","(Ljava/lang/Object;)Z",(r,s,a)=>
            {var other=a[0].Reference;return JHostResult.Complete(JValue.I(other!=null&&other.ClassName=="java/lang/String"&&string.Equals(r.Text(s),r.Text(JValue.R(other)),StringComparison.Ordinal)?1:0));});
            Bind("java/lang/String","hashCode","()I",(r,s,a)=>
            {int value=0;unchecked{foreach(char c in r.Text(s))value=31*value+c;}return JHostResult.Complete(JValue.I(value));});
            Bind("java/lang/String","toString","()Ljava/lang/String;",(r,s,a)=>JHostResult.Complete(s));
        }
        private string Text(JValue value)=>NonNull(value).Text??throw new PortGap("Java string state is not bound");
    }
}

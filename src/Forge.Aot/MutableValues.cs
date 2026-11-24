using System;
using System.Text;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class MutableBoolean {internal bool Value;internal MutableBoolean(bool value){Value=value;}}
        // Commons Lang 3.18.0 (the pinned Forge dependency) uses NFKD, not NFD,
        // removes only U+0300..036F and does not recompose the resulting string.
        // https://github.com/apache/commons-lang/blob/rel/commons-lang-3.18.0/src/main/java/org/apache/commons/lang3/StringUtils.java
        private string StripAccents(string input)
        {
            string normalized;
            try{normalized=input.Normalize(NormalizationForm.FormKD);}catch(ArgumentException){throw new PortGap("Normalization of unpaired UTF-16 surrogates requires a Java-compatible adapter");}
            const string barred="ŁłĐđƗɨᵻᶤᶧɄʉᵾᶶŦŧ",plain="LlDdIiIiIUuUuTt";
            var output=new StringBuilder();foreach(char c in normalized){if(c>=0x0300&&c<=0x036f)continue;int at=barred.IndexOf(c);output.Append(at<0?c:plain[at]);}return output.ToString();
        }
        private void InstallMutableValues()
        {
            const string pair="org/apache/commons/lang3/tuple/MutablePair";NativeClass(pair,"org/apache/commons/lang3/tuple/Pair","java/util/Map$Entry");
            StandardBind(pair,"of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/MutablePair;",(r,s,a)=>Done(JValue.R(r.HostObject(pair,new JavaPair(a[0],a[1])))));
            StandardBind(pair,"setLeft","(Ljava/lang/Object;)V",(r,s,a)=>{r.HostPayload<JavaPair>(s).Left=a[0];return Done();});StandardBind(pair,"setRight","(Ljava/lang/Object;)V",(r,s,a)=>{r.HostPayload<JavaPair>(s).Right=a[0];return Done();});StandardBind(pair,"setValue","(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var p=r.HostPayload<JavaPair>(s);var old=p.Right;p.Right=a[0];return Done(old);});
            StandardBind("org/apache/commons/lang3/StringUtils","stripAccents","(Ljava/lang/String;)Ljava/lang/String;",(r,s,a)=>Done(a[0].Reference==null?a[0]:JValue.R(r.String(r.StripAccents(r.Text(a[0]))))));
            const string type="org/apache/commons/lang3/mutable/MutableBoolean";NativeClass(type,"java/lang/Object","java/lang/Comparable");
            foreach(string desc in new[]{"()V","(Z)V","(Ljava/lang/Boolean;)V"})StandardBind(type,"<init>",desc,(r,s,a)=>{var obj=r.NonNull(s);obj.Payload=new MutableBoolean(a.Length!=0&&(desc=="(Z)V"?a[0].Int!=0:r.NonNull(a[0]).Boxed!.Value.Int!=0));obj.HostStorage=true;return Done();});
            foreach(string operation in new[]{"booleanValue","isTrue","isFalse"})StandardBind(type,operation,"()Z",(r,s,a)=>Done(JValue.I(r.HostPayload<MutableBoolean>(s).Value!=(operation=="isFalse")?1:0)));
            foreach(bool value in new[]{false,true})StandardBind(type,value?"setTrue":"setFalse","()V",(r,s,a)=>{r.HostPayload<MutableBoolean>(s).Value=value;return Done();});
            StandardBind(type,"setValue","(Z)V",(r,s,a)=>{r.HostPayload<MutableBoolean>(s).Value=a[0].Int!=0;return Done();});
            StandardBind(type,"getValue","()Ljava/lang/Boolean;",(r,s,a)=>Done(JValue.R(r.BooleanBox(r.HostPayload<MutableBoolean>(s).Value))));
            StandardBind("org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z",(r,s,a)=>{if(a[0].Reference==null)return Done(JValue.I(0));string text=r.CharSequence(a[0]);if(text.Length==0)return Done(JValue.I(0));foreach(char c in text)if(!char.IsDigit(c))return Done(JValue.I(0));return Done(JValue.I(1));});
        }
    }
}

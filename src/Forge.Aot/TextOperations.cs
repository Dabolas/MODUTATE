using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private string CharSequence(JValue value)=>NonNull(value).Payload is StringBuilder builder?builder.ToString():Text(value);
        private void InstallTextOperations()
        {
            InstallApacheStringFamily();
            const string str="java/lang/String",sb="java/lang/StringBuilder",chr="java/lang/Character";
            const string strings="org/apache/commons/lang3/Strings";NativeClass(strings);
            foreach(bool ignore in new[]{false,true}){var instance=JValue.R(HostObject(strings,ignore));BindStatic(strings,ignore?"CI":"CS","L"+strings+";",()=>instance);}
            StandardBind(strings,"contains","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z",(r,s,a)=>Done(JValue.I(a[0].Reference!=null&&a[1].Reference!=null&&r.CharSequence(a[0]).IndexOf(r.CharSequence(a[1]),r.HostPayload<bool>(s)?StringComparison.OrdinalIgnoreCase:StringComparison.Ordinal)>=0?1:0)));
            StandardBind(strings,"containsAny","(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z",(r,s,a)=>{if(a[0].Reference==null||a[1].Reference==null)return Done(JValue.I(0));string value=r.CharSequence(a[0]);if(value.Length==0)return Done(JValue.I(0));return Done(JValue.I(r.ArrayObject(a[1]).Items.Any(v=>v.Reference!=null&&value.IndexOf(r.CharSequence(v),r.HostPayload<bool>(s)?StringComparison.OrdinalIgnoreCase:StringComparison.Ordinal)>=0)?1:0));});
            StandardBind("org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;",(r,s,a)=>{
                if(a[0].Reference==null)return Done(default);
                string separator=a[1].Reference==null?"":r.Text(a[1]);
                return r.CollectIterable(a[0],(t,values)=>JValue.R(t.String(string.Join(separator,values.Select(v=>v.Reference==null?"":t.Text(t.InlineCall("java/lang/Object","toString","()Ljava/lang/String;",v,Array.Empty<JValue>())))))));
            });
            NativeClass("java/util/Locale");
            foreach(var locale in new[]{("ROOT",CultureInfo.InvariantCulture),("ENGLISH",CultureInfo.GetCultureInfo("en")),("US",CultureInfo.GetCultureInfo("en-US"))}){var value=JValue.R(HostObject("java/util/Locale",locale.Item2));BindStatic("java/util/Locale",locale.Item1,"Ljava/util/Locale;",()=>value);}
            foreach(bool upper in new[]{false,true})StandardBind(str,upper?"toUpperCase":"toLowerCase","(Ljava/util/Locale;)Ljava/lang/String;",(r,s,a)=>{var culture=r.HostPayload<CultureInfo>(a[0]);return Done(JValue.R(r.String(UnicodeCase.Convert(r.Text(s),upper,culture.TwoLetterISOLanguageName))));});
            StandardBind("org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;",(r,s,a)=>{if(a[0].Reference==null)return Done(a[0]);var text=r.Text(a[0]);if(text.Length==0)return Done(a[0]);if(text[0]>127)throw new PortGap("Non-ASCII code-point titlecase requires a Unicode-version adapter");return Done(JValue.R(r.String(char.ToUpperInvariant(text[0])+text.Substring(1))));});
            StandardBind("org/apache/commons/lang3/StringUtils","uncapitalize","(Ljava/lang/String;)Ljava/lang/String;",(r,s,a)=>{if(a[0].Reference==null)return Done(a[0]);var text=r.Text(a[0]);if(text.Length==0)return Done(a[0]);if(text[0]>127)throw new PortGap("Non-ASCII code-point lowercase requires a Unicode-version adapter");return Done(JValue.R(r.String(char.ToLowerInvariant(text[0])+text.Substring(1))));});
            StandardBind("com/google/common/base/Strings","repeat","(Ljava/lang/String;I)Ljava/lang/String;",(r,s,a)=>{string text=r.Text(a[0]);int count=a[1].Int;if(count<0)throw r.Fault("java/lang/IllegalArgumentException");long length=(long)text.Length*count;if(length>int.MaxValue)throw r.Fault("java/lang/OutOfMemoryError");if(length==0)return Done(JValue.R(r.String("")));return Done(JValue.R(r.String(new StringBuilder((int)length).Insert(0,text,count).ToString())));});
            foreach(var predicate in new (string Name,Func<char,bool> Test)[]{("isDigit",char.IsDigit),("isLetter",char.IsLetter),("isLetterOrDigit",char.IsLetterOrDigit),("isLowerCase",char.IsLower),("isUpperCase",char.IsUpper),("isWhitespace",c=>JavaBlank(c.ToString())),("isISOControl",c=>c<=0x1f||c>=0x7f&&c<=0x9f)})
                StandardBind(chr,predicate.Name,"(C)Z",(r,s,a)=>Done(JValue.I(predicate.Test((char)a[0].Int)?1:0)));
            StandardBind(chr,"toLowerCase","(C)C",(r,s,a)=>Done(JValue.I(char.ToLowerInvariant((char)a[0].Int))));
            StandardBind(chr,"toUpperCase","(C)C",(r,s,a)=>Done(JValue.I(char.ToUpperInvariant((char)a[0].Int))));
            StandardBind(chr,"toTitleCase","(I)I",(r,s,a)=>{int cp=a[0].Int;if(cp<0||cp>0x10ffff||cp>=0xd800&&cp<=0xdfff)return Done(a[0]);string text=CultureInfo.InvariantCulture.TextInfo.ToTitleCase(char.ConvertFromUtf32(cp));if(text.Length==1)return Done(JValue.I(text[0]));if(text.Length==2&&char.IsSurrogatePair(text,0))return Done(JValue.I(char.ConvertToUtf32(text,0)));throw new PortGap("Multi-code-point titlecase differs from Java Character semantics");});
            StandardBind(str,"<init>","([C)V",(r,s,a)=>{var chars=r.ArrayObject(a[0]).Items;var obj=r.NonNull(s);obj.Text=new string(chars.Select(v=>(char)v.Int).ToArray());obj.HostStorage=true;return Done();});
            StandardBind(str,"<init>","([CII)V",(r,s,a)=>{var chars=r.ArrayObject(a[0]).Items;int from=a[1].Int,count=a[2].Int;if(from<0||count<0||from>chars.Length-count)throw r.Fault("java/lang/StringIndexOutOfBoundsException");var obj=r.NonNull(s);obj.Text=new string(chars.Skip(from).Take(count).Select(v=>(char)v.Int).ToArray());obj.HostStorage=true;return Done();});
            StandardBind(str,"toCharArray","()[C",(r,s,a)=>{var text=r.Text(s);var arr=r.NewArray("C",text.Length);for(int i=0;i<text.Length;i++)arr.Items[i]=JValue.I(text[i]);return Done(JValue.R(arr));});
            StandardBind(str,"codePointAt","(I)I",(r,s,a)=>{string text=r.Text(s);int at=a[0].Int;if(at<0||at>=text.Length)throw r.Fault("java/lang/StringIndexOutOfBoundsException");return Done(JValue.I(char.IsHighSurrogate(text[at])&&at+1<text.Length&&char.IsLowSurrogate(text[at+1])?char.ConvertToUtf32(text[at],text[at+1]):text[at]));});
            foreach(string owner in new[]{str,sb,"java/lang/CharSequence"})StandardBind(owner,"subSequence","(II)Ljava/lang/CharSequence;",(r,s,a)=>{string text=r.CharSequence(s);int start=a[0].Int,end=a[1].Int;if(start<0||end<start||end>text.Length)throw r.Fault("java/lang/StringIndexOutOfBoundsException");return Done(JValue.R(r.String(text.Substring(start,end-start))));});
            StandardBind(str,"compareTo","(Ljava/lang/String;)I",(r,s,a)=>{var x=r.Text(s);var y=r.Text(a[0]);for(int i=0;i<Math.Min(x.Length,y.Length);i++)if(x[i]!=y[i])return Done(JValue.I(x[i]-y[i]));return Done(JValue.I(x.Length-y.Length));});
            StandardBind(str,"compareTo","(Ljava/lang/Object;)I",(r,s,a)=>{if(a[0].Reference!=null&&!r.IsInstance(a[0].Reference,str))throw r.Fault("java/lang/ClassCastException");return Done(r.InlineCall(str,"compareTo","(Ljava/lang/String;)I",s,a));});
            StandardBind(str,"compareToIgnoreCase","(Ljava/lang/String;)I",(r,s,a)=>Done(JValue.I(UnicodeCase.CompareIgnoreCase(r.Text(s),r.Text(a[0])))));
            StandardBind(str,"isBlank","()Z",(r,s,a)=>Done(JValue.I(JavaBlank(r.Text(s))?1:0)));
            foreach(bool leading in new[]{false,true})StandardBind(str,leading?"stripLeading":"stripTrailing","()Ljava/lang/String;",(r,s,a)=>{var text=r.Text(s);int begin=0,end=text.Length;if(leading){while(begin<end&&JavaBlank(text[begin].ToString()))begin++;}else while(end>begin&&JavaBlank(text[end-1].ToString()))end--;return Done(JValue.R(r.String(text.Substring(begin,end-begin))));});
            StandardBind(str,"repeat","(I)Ljava/lang/String;",(r,s,a)=>{int count=a[0].Int;if(count<0)throw r.Fault("java/lang/IllegalArgumentException");var text=r.Text(s);if(text.Length==0||count==0)return Done(JValue.R(r.String("")));if((long)text.Length*count>int.MaxValue)throw r.Fault("java/lang/OutOfMemoryError");return Done(JValue.R(r.String(string.Concat(Enumerable.Repeat(text,count)))));});
            StandardBind(str,"lastIndexOf","(Ljava/lang/String;)I",(r,s,a)=>{var text=r.Text(s);var part=r.Text(a[0]);return Done(JValue.I(part.Length==0?text.Length:text.LastIndexOf(part,StringComparison.Ordinal)));});
            StandardBind(str,"lastIndexOf","(I)I",(r,s,a)=>{var text=r.Text(s);int cp=a[0].Int;return Done(JValue.I(cp<0||cp>0x10ffff?-1:cp<=0xffff?text.LastIndexOf((char)cp):text.LastIndexOf(char.ConvertFromUtf32(cp),StringComparison.Ordinal)));});
            StandardBind(str,"regionMatches","(ZILjava/lang/String;II)Z",(r,s,a)=>{var text=r.Text(s);var other=r.Text(a[2]);int from=a[1].Int,to=a[3].Int,count=a[4].Int;if(from<0||to<0||from>text.Length-(long)count||to>other.Length-(long)count)return Done(JValue.I(0));for(int i=0;i<count;i++){char x=text[from+i],y=other[to+i];if(x==y)continue;if(a[0].Int==0)return Done(JValue.I(0));x=char.ToUpperInvariant(x);y=char.ToUpperInvariant(y);if(x!=y&&char.ToLowerInvariant(x)!=char.ToLowerInvariant(y))return Done(JValue.I(0));}return Done(JValue.I(1));});
            foreach(string type in new[]{"C","I","J"})StandardBind(str,"valueOf","("+type+")Ljava/lang/String;",(r,s,a)=>Done(JValue.R(r.String(r.DisplayPrimitive(a[0],type)))));
            StandardBind(str,"valueOf","([C)Ljava/lang/String;",(r,s,a)=>Done(JValue.R(r.String(new string(r.ArrayObject(a[0]).Items.Select(v=>(char)v.Int).ToArray())))));
            StandardBind(str,"valueOf","(Ljava/lang/Object;)Ljava/lang/String;",(r,s,a)=>a[0].Reference==null?Done(JValue.R(r.String("null"))):r.Callback("java/lang/Object","toString","()Ljava/lang/String;",a[0],Array.Empty<JValue>(),(t,v)=>v));
            StandardBind(str,"join","(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/String;",(r,s,a)=>Done(JValue.R(r.String(string.Join(r.CharSequence(a[0]),r.ArrayObject(a[1]).Items.Select(v=>v.Reference==null?"null":r.CharSequence(v)))))));
            StandardBind(str,"join","(Ljava/lang/CharSequence;Ljava/lang/Iterable;)Ljava/lang/String;",(r,s,a)=>{string separator=r.CharSequence(a[0]);return r.CollectIterable(a[1],(t,v)=>JValue.R(t.String(string.Join(separator,v.Select(x=>x.Reference==null?"null":t.CharSequence(x))))));});
            StandardBind(sb,"append","(Ljava/lang/CharSequence;)Ljava/lang/StringBuilder;",(r,s,a)=>{r.HostPayload<StringBuilder>(s).Append(a[0].Reference==null?"null":r.CharSequence(a[0]));return Done(s);});
            StandardBind(sb,"append","([C)Ljava/lang/StringBuilder;",(r,s,a)=>{r.HostPayload<StringBuilder>(s).Append(r.ArrayObject(a[0]).Items.Select(v=>(char)v.Int).ToArray());return Done(s);});
            StandardBind(sb,"append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;",(r,s,a)=>{if(a[0].Reference==null){r.HostPayload<StringBuilder>(s).Append("null");return Done(s);}return r.Callback("java/lang/Object","toString","()Ljava/lang/String;",a[0],Array.Empty<JValue>(),(t,v)=>{t.HostPayload<StringBuilder>(s).Append(v.Reference==null?"null":t.Text(v));return s;});});
            StandardBind(sb,"length","()I",(r,s,a)=>Done(JValue.I(r.HostPayload<StringBuilder>(s).Length)));
            StandardBind(sb,"charAt","(I)C",(r,s,a)=>{var b=r.HostPayload<StringBuilder>(s);if(a[0].Int<0||a[0].Int>=b.Length)throw r.Fault("java/lang/StringIndexOutOfBoundsException");return Done(JValue.I(b[a[0].Int]));});
            StandardBind(sb,"deleteCharAt","(I)Ljava/lang/StringBuilder;",(r,s,a)=>{var b=r.HostPayload<StringBuilder>(s);if(a[0].Int<0||a[0].Int>=b.Length)throw r.Fault("java/lang/StringIndexOutOfBoundsException");b.Remove(a[0].Int,1);return Done(s);});
            StandardBind(sb,"insert","(ILjava/lang/String;)Ljava/lang/StringBuilder;",(r,s,a)=>{var b=r.HostPayload<StringBuilder>(s);if(a[0].Int<0||a[0].Int>b.Length)throw r.Fault("java/lang/StringIndexOutOfBoundsException");b.Insert(a[0].Int,a[1].Reference==null?"null":r.Text(a[1]));return Done(s);});
            foreach(bool last in new[]{false,true})StandardBind(sb,last?"lastIndexOf":"indexOf","(Ljava/lang/String;)I",(r,s,a)=>{var text=r.HostPayload<StringBuilder>(s).ToString();var part=r.Text(a[0]);return Done(JValue.I(last?(part.Length==0?text.Length:text.LastIndexOf(part,StringComparison.Ordinal)):text.IndexOf(part,StringComparison.Ordinal)));});
            StandardBind(sb,"substring","(II)Ljava/lang/String;",(r,s,a)=>{var b=r.HostPayload<StringBuilder>(s);int from=a[0].Int,to=a[1].Int;if(from<0||to<from||to>b.Length)throw r.Fault("java/lang/StringIndexOutOfBoundsException");return Done(JValue.R(r.String(b.ToString(from,to-from))));});
            StandardBind(sb,"replace","(IILjava/lang/String;)Ljava/lang/StringBuilder;",(r,s,a)=>{var b=r.HostPayload<StringBuilder>(s);int from=a[0].Int,to=Math.Min(b.Length,a[1].Int);if(from<0||from>b.Length||to<from)throw r.Fault("java/lang/StringIndexOutOfBoundsException");string replacement=r.Text(a[2]);b.Remove(from,to-from).Insert(from,replacement);return Done(s);});
        }
    }
}

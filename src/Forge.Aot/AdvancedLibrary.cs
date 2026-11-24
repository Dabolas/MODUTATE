using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class TripleValue {internal readonly JValue[] Values;internal TripleValue(JValue[] v){Values=v.ToArray();}}
        private void InstallAdvancedLibrary()
        {
            InstallDependencyGraphs();
            NativeClass("com/google/common/base/Function","java/lang/Object","java/util/function/Function");
            InstallFunctionMaps();
            StandardBind("com/google/common/collect/Lists","newLinkedList","()Ljava/util/LinkedList;",(r,s,a)=>Done(r.ListOf(Array.Empty<JValue>(),"java/util/LinkedList")));
            NativeClass("aot/SynchronizedMultimap","java/lang/Object","com/google/common/collect/Multimap");
            foreach(var binding in bindings.Where(b=>b.Key.StartsWith("com/google/common/collect/Multimap.",StringComparison.Ordinal)).ToArray())
            {string sig=binding.Key.Substring("com/google/common/collect/Multimap.".Length);int at=sig.IndexOf('(');var operation=binding.Value;StandardBind("aot/SynchronizedMultimap",sig.Substring(0,at),sig.Substring(at),(r,s,a)=>{lock(r.HostPayload<JavaMultimap>(s))return operation(r,s,a);});}
            StandardBind("com/google/common/collect/Multimaps","synchronizedMultimap","(Lcom/google/common/collect/Multimap;)Lcom/google/common/collect/Multimap;",(r,s,a)=>Done(JValue.R(r.HostObject("aot/SynchronizedMultimap",r.HostPayload<JavaMultimap>(a[0])))));
            foreach(string owner in new[]{"java/util/AbstractList","java/util/List","java/util/ArrayList","java/util/LinkedList","java/util/Stack","com/google/common/collect/ImmutableList"})
            {
                StandardBind(owner,"equals","(Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(r.SequenceEquals(s,a[0],false)?1:0)));
                StandardBind(owner,"hashCode","()I",(r,s,a)=>Done(JValue.I(r.SequenceHash(s,false))));
            }
            foreach(string owner in new[]{"java/util/AbstractSet","java/util/Set","java/util/HashSet","java/util/LinkedHashSet","java/util/EnumSet","java/util/TreeSet","com/google/common/collect/ImmutableSet"})
            {
                StandardBind(owner,"equals","(Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(r.SequenceEquals(s,a[0],true)?1:0)));
                StandardBind(owner,"hashCode","()I",(r,s,a)=>Done(JValue.I(r.SequenceHash(s,true))));
            }
            StandardBind("org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;C)Ljava/lang/String;",(r,s,a)=>{if(a[0].Reference==null)return Done(default);string separator=((char)a[1].Int).ToString();return r.CollectIterable(a[0],(t,v)=>JValue.R(t.String(string.Join(separator,v.Select(x=>x.Reference==null?"":t.Text(t.InlineCall("java/lang/Object","toString","()Ljava/lang/String;",x,Array.Empty<JValue>())))))));});
            StandardBind("com/google/common/collect/Iterators","elementsEqual","(Ljava/util/Iterator;Ljava/util/Iterator;)Z",(r,s,a)=>{while(r.InlineCall("java/util/Iterator","hasNext","()Z",a[0],Array.Empty<JValue>()).Int!=0){if(r.InlineCall("java/util/Iterator","hasNext","()Z",a[1],Array.Empty<JValue>()).Int==0)return Done(JValue.I(0));var left=r.InlineCall("java/util/Iterator","next","()Ljava/lang/Object;",a[0],Array.Empty<JValue>());var right=r.InlineCall("java/util/Iterator","next","()Ljava/lang/Object;",a[1],Array.Empty<JValue>());if(!r.NativeEqual(left,right))return Done(JValue.I(0));}return Done(JValue.I(r.InlineCall("java/util/Iterator","hasNext","()Z",a[1],Array.Empty<JValue>()).Int==0?1:0));});
            StandardBind("java/util/Collections","shuffle","(Ljava/util/List;Ljava/util/Random;)V",(r,s,a)=>{int count=r.InlineCall("java/util/List","size","()I",a[0],Array.Empty<JValue>()).Int;for(int i=count;i>1;i--){int j=r.InlineCall("java/util/Random","nextInt","(I)I",a[1],new[]{JValue.I(i)}).Int;var tail=r.InlineCall("java/util/List","get","(I)Ljava/lang/Object;",a[0],new[]{JValue.I(i-1)});var replaced=r.InlineCall("java/util/List","set","(ILjava/lang/Object;)Ljava/lang/Object;",a[0],new[]{JValue.I(j),tail});r.InlineCall("java/util/List","set","(ILjava/lang/Object;)Ljava/lang/Object;",a[0],new[]{JValue.I(i-1),replaced});}return Done();});
            StandardBind("java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;",(r,s,a)=>Done(JValue.R(r.String(r.FormatJava(r.Text(a[0]),r.ArrayObject(a[1]).Items)))));
            foreach(var type in BuiltinParents.Where(p=>p.Key!="java/lang/String"&&p.Key!="java/lang/Class"))
            {
                NativeClass(type.Key,type.Value);
                foreach(string desc in new[]{"()V","(Ljava/lang/String;)V","(Ljava/lang/Throwable;)V","(Ljava/lang/String;Ljava/lang/Throwable;)V"})
                {string signature=desc;StandardBind(type.Key,"<init>",desc,(r,s,a)=>{var obj=r.NonNull(s);obj.Text=a.Length==0?null:signature=="(Ljava/lang/Throwable;)V"?(a[0].Reference==null?null:a[0].Reference!.ClassName+": "+a[0].Reference!.Text):a[0].Reference?.Text;obj.Fields["java/lang/Throwable.cause:Ljava/lang/Throwable;"]=signature=="(Ljava/lang/Throwable;)V"?a[0]:a.Length==2?a[1]:JValue.R(null);return Done();});}
            }
            StandardBind("java/lang/Throwable","getMessage","()Ljava/lang/String;",(r,s,a)=>Done(r.NonNull(s).Text is string text?JValue.R(r.String(text)):JValue.R(null)));
            StandardBind("java/lang/Throwable","getCause","()Ljava/lang/Throwable;",(r,s,a)=>Done(r.NonNull(s).Fields.TryGetValue("java/lang/Throwable.cause:Ljava/lang/Throwable;",out var cause)?cause:JValue.R(null)));
            StandardBind("java/lang/Throwable","toString","()Ljava/lang/String;",(r,s,a)=>Done(JValue.R(r.String(r.NonNull(s).ClassName.Replace('/','.')+(r.NonNull(s).Text==null?"":": "+r.NonNull(s).Text)))));
            foreach(string desc in new[]{"(Ljava/lang/Boolean;)I","(Ljava/lang/Object;)I"})StandardBind("java/lang/Boolean","compareTo",desc,(r,s,a)=>{if(r.NonNull(a[0]).ClassName!="java/lang/Boolean")throw r.Fault("java/lang/ClassCastException");return Done(JValue.I(r.NonNull(s).Boxed!.Value.Int.CompareTo(r.NonNull(a[0]).Boxed!.Value.Int)));});
            const string triple="org/apache/commons/lang3/tuple/Triple";NativeClass(triple);
            StandardBind(triple,"of","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Triple;",(r,s,a)=>Done(JValue.R(r.HostObject(triple,new TripleValue(a)))));
            foreach(var pair in new[]{("getLeft",0),("getMiddle",1),("getRight",2)})StandardBind(triple,pair.Item1,"()Ljava/lang/Object;",(r,s,a)=>Done(r.HostPayload<TripleValue>(s).Values[pair.Item2]));
            StandardBind(triple,"equals","(Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(a[0].Reference?.Payload is TripleValue right&&r.HostPayload<TripleValue>(s).Values.Zip(right.Values,(x,y)=>r.NativeEqual(x,y)).All(b=>b)?1:0)));
            StandardBind(triple,"hashCode","()I",(r,s,a)=>{int hash=0;foreach(var v in r.HostPayload<TripleValue>(s).Values)if(v.Reference!=null)hash^=r.InlineCall("java/lang/Object","hashCode","()I",v,Array.Empty<JValue>()).Int;return Done(JValue.I(hash));});
            StandardBind("java/lang/String","matches","(Ljava/lang/String;)Z",(r,s,a)=>{var p=r.HostPayload<PatternValue>(r.Pattern(a[0],0));string text=r.Text(s);if(p.AsciiOnly)AssertAscii(text);return Done(JValue.I(new Regex("\\A(?:"+p.Regex+")\\z",p.Regex.Options,TimeSpan.FromMilliseconds(250)).IsMatch(text)?1:0));});
            // StringBuffer has the same text operations with synchronized calls and distinct descriptors.
            NativeClass("java/lang/StringBuffer","java/lang/Object","java/lang/CharSequence");
            foreach(var binding in bindings.Where(b=>b.Key.StartsWith("java/lang/StringBuilder.",StringComparison.Ordinal)).ToArray())
            {string sig=binding.Key.Substring("java/lang/StringBuilder.".Length).Replace("Ljava/lang/StringBuilder;","Ljava/lang/StringBuffer;");int at=sig.IndexOf('(');var invoke=binding.Value;StandardBind("java/lang/StringBuffer",sig.Substring(0,at),sig.Substring(at),(r,s,a)=>{lock(r.NonNull(s))return invoke(r,s,a);});}
            foreach(string owner in new[]{"java/util/List","java/util/ArrayList","java/util/Stack","java/util/LinkedList"})StandardBind(owner,"subList","(II)Ljava/util/List;",(r,s,a)=>{var list=r.HostPayload<JavaList>(s);int from=a[0].Int,to=a[1].Int;if(from<0||to>list.Values.Count)throw r.Fault("java/lang/IndexOutOfBoundsException");if(from>to)throw r.Fault("java/lang/IllegalArgumentException");var view=new SubListValues(r,list,from,to-from);return Done(JValue.R(r.HostObject("java/util/ArrayList",new JavaList{Immutable=list.Immutable,FixedSize=list.FixedSize,Storage=new ListStorage{Values=view,ExternalVersion=()=>list.Version}})));});
        }
        private bool SequenceEquals(JValue left,JValue right,bool set)
        {
            if(ReferenceEquals(left.Reference,right.Reference))return true;
            if(right.Reference==null||!IsInstance(right.Reference,set?"java/util/Set":"java/util/List"))return false;
            var a=ListItems(left);var b=ListItems(right);return a.Length==b.Length&&(set?a.All(x=>b.Any(y=>NativeEqual(x,y))):a.Zip(b,(x,y)=>NativeEqual(x,y)).All(v=>v));
        }
        private int SequenceHash(JValue value,bool set){int hash=set?0:1;foreach(var v in ListItems(value)){int h=v.Reference==null?0:InlineCall("java/lang/Object","hashCode","()I",v,Array.Empty<JValue>()).Int;hash=unchecked(set?hash+h:31*hash+h);}return hash;}
        private string FormatJava(string format,JValue[] args,string? lineSeparator=null)
        {
            int next=0,last=-1;var output=new System.Text.StringBuilder();
            for(int at=0;at<format.Length;)
            {
                if(format[at]!='%'){output.Append(format[at++]);continue;}
                var m=Regex.Match(format.Substring(at),@"^%(?:(\d+)\$)?([-<0]*)(\d+)?(?:\.(\d+))?([sSbdxXf%n])");
                if(!m.Success)throw new PortGap("Unsupported Java Formatter conversion at "+format.Substring(at));at+=m.Length;char conversion=m.Groups[5].Value[0];if(conversion=='%'){output.Append('%');continue;}if(conversion=='n'){output.Append(lineSeparator??Environment.NewLine);continue;}
                string flags=m.Groups[2].Value;int index=flags.Contains("<")?last:m.Groups[1].Success?int.Parse(m.Groups[1].Value,System.Globalization.CultureInfo.InvariantCulture)-1:next++;last=index;if(index<0||index>=args.Length)throw new PortGap("Formatter argument index out of range");var v=args[index];string text;
                if(v.Reference==null)text=conversion=='b'?"false":"null";
                else if(conversion=='s'||conversion=='S'){text=Text(InlineCall("java/lang/Object","toString","()Ljava/lang/String;",v,Array.Empty<JValue>()));if(m.Groups[4].Success)text=text.Substring(0,Math.Min(text.Length,int.Parse(m.Groups[4].Value,System.Globalization.CultureInfo.InvariantCulture)));if(conversion=='S')text=text.ToUpperInvariant();}
                else if(conversion=='b')text=v.Reference.ClassName=="java/lang/Boolean"?(v.Reference.Boxed!.Value.Int==0?"false":"true"):"true";
                else {var n=v.Reference.Boxed??throw new PortGap("Formatter numeric conversion requires a number");if(conversion=='f')text=(n.Kind==JKind.Float?(double)n.Float:n.Double).ToString("F"+(m.Groups[4].Success?m.Groups[4].Value:"6"),System.Globalization.CultureInfo.InvariantCulture);else text=(n.Kind==JKind.Long?n.Long:(long)n.Int).ToString(conversion=='d'?"D":conversion.ToString(),System.Globalization.CultureInfo.InvariantCulture);}
                int width=m.Groups[3].Success?int.Parse(m.Groups[3].Value,System.Globalization.CultureInfo.InvariantCulture):0;if(width>text.Length)text=flags.Contains("-")?text.PadRight(width):text.PadLeft(width,flags.Contains("0")?'0':' ');output.Append(text);
            }
            return output.ToString();
        }
        // Backed, fail-fast view. Mutations through the view update the backing list/version.
        private sealed class SubListValues:IList<JValue>
        {
            private readonly JRuntime rt;private readonly JavaList list;private readonly int start;private int count,version;
            internal SubListValues(JRuntime r,JavaList l,int at,int n){rt=r;list=l;start=at;count=n;version=l.Version;}
            private void Check(int i,bool end=false){if(version!=list.Version)throw rt.Fault("java/util/ConcurrentModificationException");if(i<0||i>count||(!end&&i==count))throw rt.Fault("java/lang/IndexOutOfBoundsException");}
            public int Count{get{Check(0,true);return count;}}public bool IsReadOnly=>list.Immutable;
            public JValue this[int i]{get{Check(i);return list.Values[start+i];}set{Check(i);rt.Mutable(list,false);list.Values[start+i]=value;}}
            public void Insert(int i,JValue v){Check(i,true);rt.Mutable(list);list.Values.Insert(start+i,v);count++;list.Version++;version=list.Version;}
            public void Add(JValue v)=>Insert(count,v);public void RemoveAt(int i){Check(i);rt.Mutable(list);list.Values.RemoveAt(start+i);count--;list.Version++;version=list.Version;}
            public void Clear(){while(Count>0)RemoveAt(Count-1);}public int IndexOf(JValue v){for(int i=0;i<Count;i++)if(rt.NativeEqual(this[i],v))return i;return -1;}public bool Contains(JValue v)=>IndexOf(v)>=0;public bool Remove(JValue v){int i=IndexOf(v);if(i<0)return false;RemoveAt(i);return true;}public void CopyTo(JValue[] a,int at){foreach(var v in this)a[at++]=v;}public IEnumerator<JValue> GetEnumerator(){for(int i=0;i<Count;i++)yield return this[i];}IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        }
    }
}

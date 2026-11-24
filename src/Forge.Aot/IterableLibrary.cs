using System;
using System.Linq;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class ConcatSource {internal JValue[]? Sources;internal JValue Outer;}
        private sealed class ConcatIterator {internal readonly ConcatSource Source;internal int Index;internal JValue Outer,Current,Last;internal bool CanRemove;internal ConcatIterator(ConcatSource source){Source=source;}}
        private bool ConcatHasNext(ConcatIterator it)
        {
            while(true)
            {
                if(it.Current.Reference!=null&&InlineCall("java/util/Iterator","hasNext","()Z",it.Current,Array.Empty<JValue>()).Int!=0)return true;
                JValue next;
                if(it.Source.Sources!=null){if(it.Index==it.Source.Sources.Length)return false;next=it.Source.Sources[it.Index++];}
                else
                {if(it.Outer.Reference==null)it.Outer=InlineCall("java/lang/Iterable","iterator","()Ljava/util/Iterator;",it.Source.Outer,Array.Empty<JValue>());if(InlineCall("java/util/Iterator","hasNext","()Z",it.Outer,Array.Empty<JValue>()).Int==0)return false;next=InlineCall("java/util/Iterator","next","()Ljava/lang/Object;",it.Outer,Array.Empty<JValue>());}
                it.Current=InlineCall("java/lang/Iterable","iterator","()Ljava/util/Iterator;",next,Array.Empty<JValue>());
            }
        }
        private void InstallIterables()
        {
            StandardBind("com/google/common/collect/Iterables","get","(Ljava/lang/Iterable;I)Ljava/lang/Object;",(r,s,a)=>{int index=a[1].Int;if(index<0)throw r.Fault("java/lang/IndexOutOfBoundsException");foreach(var item in r.StreamIterable(a[0]))if(index--==0)return Done(item);throw r.Fault("java/lang/IndexOutOfBoundsException");});
            StandardBind("com/google/common/collect/Iterables","contains","(Ljava/lang/Iterable;Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(r.StreamIterable(a[0]).Any(v=>r.NativeEqual(v,a[1]))?1:0)));
            StandardBind("com/google/common/collect/Iterables","addAll","(Ljava/util/Collection;Ljava/lang/Iterable;)Z",(r,s,a)=>{bool changed=false;foreach(var v in r.StreamIterable(a[1]))changed|=r.InlineCall("java/util/Collection","add","(Ljava/lang/Object;)Z",a[0],new[]{v}).Int!=0;return Done(JValue.I(changed?1:0));});
            foreach(string desc in new[]{"(Ljava/lang/Long;)I","(Ljava/lang/Object;)I"})StandardBind("java/lang/Long","compareTo",desc,(r,s,a)=>{if(r.NonNull(a[0]).ClassName!="java/lang/Long")throw r.Fault("java/lang/ClassCastException");return Done(JValue.I(r.NonNull(s).Boxed!.Value.Long.CompareTo(r.NonNull(a[0]).Boxed!.Value.Long)));});
            StandardBind("java/util/EnumMap","put","(Ljava/lang/Enum;Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>Done(r.PutNativeMap(r.HostPayload<JavaMap>(s),a[0],a[1])));
            NativeClass("java/lang/Runnable");
            NativeClass("aot/SynchronizedList","java/util/ArrayList","java/util/List");
            foreach(var binding in bindings.Where(b=>b.Key.StartsWith("java/util/ArrayList.",StringComparison.Ordinal)).ToArray())
            {string signature=binding.Key.Substring("java/util/ArrayList.".Length);int at=signature.IndexOf('(');var invoke=binding.Value;StandardBind("aot/SynchronizedList",signature.Substring(0,at),signature.Substring(at),(r,s,a)=>{lock(r.NonNull(s)){return invoke(r,s,a);}});}
            StandardBind("java/util/Collections","synchronizedList","(Ljava/util/List;)Ljava/util/List;",(r,s,a)=>Done(JValue.R(r.HostObject("aot/SynchronizedList",r.HostPayload<JavaList>(a[0])))));
            NativeClass("java/util/AbstractSet","java/util/AbstractCollection","java/util/Set");
            StandardBind("java/util/AbstractSet","<init>","()V",(r,s,a)=>Done());
            StandardBind("com/google/common/collect/Tables","immutableCell","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/Table$Cell;",(r,s,a)=>{r.TableCellSet(new JavaTable());return Done(JValue.R(r.HostObject("aot/TableCell",new TableCell(a[0],a[1],a[2]))));});
            StandardBind("java/util/Objects","hash","([Ljava/lang/Object;)I",(r,s,a)=>{if(a[0].Reference==null)return Done(JValue.I(0));int hash=1;foreach(var value in r.ArrayObject(a[0]).Items)hash=unchecked(31*hash+(value.Reference==null?0:r.InlineCall("java/lang/Object","hashCode","()I",value,Array.Empty<JValue>()).Int));return Done(JValue.I(hash));});
            foreach(bool max in new[]{false,true})StandardBind("java/util/Collections",max?"max":"min","(Ljava/util/Collection;)Ljava/lang/Object;",(r,s,a)=>r.CollectIterable(a[0],(t,v)=>{if(v.Length==0)throw t.Fault("java/util/NoSuchElementException");var best=v[0];foreach(var value in v){int cmp=t.CompareNative(value,best);if(max?cmp>0:cmp<0)best=value;}return best;}));
            NativeClass("aot/LimitedIterable","java/lang/Object","java/lang/Iterable");NativeClass("aot/LimitedIterator","java/lang/Object","java/util/Iterator");
            StandardBind("com/google/common/collect/Iterables","limit","(Ljava/lang/Iterable;I)Ljava/lang/Iterable;",(r,s,a)=>{r.NonNull(a[0]);if(a[1].Int<0)throw r.Fault("java/lang/IllegalArgumentException");return Done(JValue.R(r.HostObject("aot/LimitedIterable",new LimitSource(a[0],a[1].Int))));});
            StandardBind("aot/LimitedIterable","iterator","()Ljava/util/Iterator;",(r,s,a)=>{var source=r.HostPayload<LimitSource>(s);var iterator=r.InlineCall("java/lang/Iterable","iterator","()Ljava/util/Iterator;",source.Source,Array.Empty<JValue>());return Done(JValue.R(r.HostObject("aot/LimitedIterator",new LimitIterator(iterator,source.Count))));});
            StandardBind("aot/LimitedIterator","hasNext","()Z",(r,s,a)=>{var it=r.HostPayload<LimitIterator>(s);return Done(JValue.I(it.Remaining>0&&r.InlineCall("java/util/Iterator","hasNext","()Z",it.Iterator,Array.Empty<JValue>()).Int!=0?1:0));});
            StandardBind("aot/LimitedIterator","next","()Ljava/lang/Object;",(r,s,a)=>{var it=r.HostPayload<LimitIterator>(s);if(it.Remaining==0)throw r.Fault("java/util/NoSuchElementException");var v=r.InlineCall("java/util/Iterator","next","()Ljava/lang/Object;",it.Iterator,Array.Empty<JValue>());it.Remaining--;it.CanRemove=true;return Done(v);});
            StandardBind("aot/LimitedIterator","remove","()V",(r,s,a)=>{var it=r.HostPayload<LimitIterator>(s);if(!it.CanRemove)throw r.Fault("java/lang/IllegalStateException");r.InlineVoid("java/util/Iterator","remove","()V",it.Iterator,Array.Empty<JValue>());it.CanRemove=false;return Done();});
            NativeClass("aot/ConcatIterable","java/lang/Object","java/lang/Iterable");NativeClass("aot/ConcatIterator","java/lang/Object","java/util/Iterator");
            for(int n=2;n<=4;n++)StandardBind("com/google/common/collect/Iterables","concat","("+string.Concat(Enumerable.Repeat("Ljava/lang/Iterable;",n))+")Ljava/lang/Iterable;",(r,s,a)=>{foreach(var v in a)r.NonNull(v);return Done(JValue.R(r.HostObject("aot/ConcatIterable",new ConcatSource{Sources=a})));});
            StandardBind("com/google/common/collect/Iterables","concat","(Ljava/lang/Iterable;)Ljava/lang/Iterable;",(r,s,a)=>{r.NonNull(a[0]);return Done(JValue.R(r.HostObject("aot/ConcatIterable",new ConcatSource{Outer=a[0]})));});
            StandardBind("aot/ConcatIterable","iterator","()Ljava/util/Iterator;",(r,s,a)=>Done(JValue.R(r.HostObject("aot/ConcatIterator",new ConcatIterator(r.HostPayload<ConcatSource>(s))))));
            StandardBind("aot/ConcatIterator","hasNext","()Z",(r,s,a)=>Done(JValue.I(r.ConcatHasNext(r.HostPayload<ConcatIterator>(s))?1:0)));
            StandardBind("aot/ConcatIterator","next","()Ljava/lang/Object;",(r,s,a)=>{var it=r.HostPayload<ConcatIterator>(s);if(!r.ConcatHasNext(it))throw r.Fault("java/util/NoSuchElementException");var value=r.InlineCall("java/util/Iterator","next","()Ljava/lang/Object;",it.Current,Array.Empty<JValue>());it.Last=it.Current;it.CanRemove=true;return Done(value);});
            StandardBind("aot/ConcatIterator","remove","()V",(r,s,a)=>{var it=r.HostPayload<ConcatIterator>(s);if(!it.CanRemove)throw r.Fault("java/lang/IllegalStateException");r.InlineVoid("java/util/Iterator","remove","()V",it.Last,Array.Empty<JValue>());it.CanRemove=false;return Done();});
        }
        private sealed class LimitSource {internal readonly JValue Source;internal readonly int Count;internal LimitSource(JValue source,int count){Source=source;Count=count;}}
        private sealed class LimitIterator {internal readonly JValue Iterator;internal int Remaining;internal bool CanRemove;internal LimitIterator(JValue iterator,int count){Iterator=iterator;Remaining=count;}}
    }
}

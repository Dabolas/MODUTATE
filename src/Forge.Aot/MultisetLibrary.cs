using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private void InstallMultisets()
        {
            InstallMultisetDifference();
            const string hash="com/google/common/collect/HashMultiset",multi="com/google/common/collect/Multiset";
            NativeClass(multi,"java/lang/Object","java/util/Collection");NativeClass(hash,"java/lang/Object",multi);
            NativeClass("com/google/common/collect/Multiset$Entry");NativeClass("aot/MultisetEntry","java/lang/Object","com/google/common/collect/Multiset$Entry");
            StandardBind("aot/MultisetEntry","getElement","()Ljava/lang/Object;",(r,s,a)=>Done(r.HostPayload<LiveMapEntry>(s).Key));
            StandardBind("aot/MultisetEntry","getCount","()I",(r,s,a)=>{var e=r.HostPayload<LiveMapEntry>(s);int at=r.MapIndex(e.Map,e.Key);return Done(JValue.I(at<0?0:e.Map.Entries[at].Value.Int));});
            StandardBind("aot/MultisetEntry","equals","(Ljava/lang/Object;)Z",(r,s,a)=>{if(a[0].Reference==null||!r.IsInstance(a[0].Reference,"com/google/common/collect/Multiset$Entry"))return Done(JValue.I(0));var e=r.HostPayload<LiveMapEntry>(s);var key=r.InlineCall("com/google/common/collect/Multiset$Entry","getElement","()Ljava/lang/Object;",a[0],Array.Empty<JValue>());int at=r.MapIndex(e.Map,e.Key),count=at<0?0:e.Map.Entries[at].Value.Int;return Done(JValue.I(r.NativeEqual(e.Key,key)&&count==r.InlineCall("com/google/common/collect/Multiset$Entry","getCount","()I",a[0],Array.Empty<JValue>()).Int?1:0));});
            StandardBind(hash,"create","(Ljava/lang/Iterable;)L"+hash+";",(r,s,a)=>r.CollectIterable(a[0],(t,values)=>{var copy=new JavaMap();foreach(var v in values)t.MultisetAdd(copy,v,1);return JValue.R(t.HostObject(hash,copy));}));
            foreach(string desc in new[]{"()L"+hash+";","(I)L"+hash+";"})StandardBind(hash,"create",desc,(r,s,a)=>{if(a.Length>0&&a[0].Int<0)throw r.Fault("java/lang/IllegalArgumentException");return Done(JValue.R(r.HostObject(hash,new JavaMap())));});
            foreach(string type in new[]{hash,multi})
            {
                StandardBind(type,"clear","()V",(r,s,a)=>{var m=r.HostPayload<JavaMap>(s);while(m.Entries.Count>0)r.RemoveMapAt(m,m.Entries.Count-1);return Done();});
                StandardBind(type,"contains","(Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(r.MapIndex(r.HostPayload<JavaMap>(s),a[0])>=0?1:0)));
                StandardBind(type,"iterator","()Ljava/util/Iterator;",(r,s,a)=>{var m=r.HostPayload<JavaMap>(s);var list=new JavaList{Storage=new ListStorage{Values=new MultisetValues(r,m),ExternalVersion=()=>m.Storage.Version}};return Done(JValue.R(r.HostObject("aot/Iterator",new JavaIterator(list))));});
                StandardBind(type,"count","(Ljava/lang/Object;)I",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);int at=r.MapIndex(map,a[0]);return Done(JValue.I(at<0?0:map.Entries[at].Value.Int));});
                StandardBind(type,"setCount","(Ljava/lang/Object;I)I",(r,s,a)=>{if(a[1].Int<0)throw r.Fault("java/lang/IllegalArgumentException");var map=r.HostPayload<JavaMap>(s);int at=r.MapIndex(map,a[0]),old=at<0?0:map.Entries[at].Value.Int;if(a[1].Int==0){if(at>=0)r.RemoveMapAt(map,at);}else r.PutNativeMap(map,a[0],a[1]);return Done(JValue.I(old));});
                StandardBind(type,"add","(Ljava/lang/Object;I)I",(r,s,a)=>Done(JValue.I(r.MultisetAdd(r.HostPayload<JavaMap>(s),a[0],a[1].Int))));
                StandardBind(type,"add","(Ljava/lang/Object;)Z",(r,s,a)=>{r.MultisetAdd(r.HostPayload<JavaMap>(s),a[0],1);return Done(JValue.I(1));});
                StandardBind(type,"remove","(Ljava/lang/Object;I)I",(r,s,a)=>{if(a[1].Int<0)throw r.Fault("java/lang/IllegalArgumentException");var map=r.HostPayload<JavaMap>(s);int at=r.MapIndex(map,a[0]),old=at<0?0:map.Entries[at].Value.Int;if(at>=0&&a[1].Int>0){if(old<=a[1].Int)r.RemoveMapAt(map,at);else r.PutNativeMap(map,a[0],JValue.I(old-a[1].Int));}return Done(JValue.I(old));});
                StandardBind(type,"isEmpty","()Z",(r,s,a)=>Done(JValue.I(r.HostPayload<JavaMap>(s).Entries.Count==0?1:0)));
                StandardBind(type,"size","()I",(r,s,a)=>Done(JValue.I((int)Math.Min(int.MaxValue,r.HostPayload<JavaMap>(s).Entries.Sum(e=>(long)e.Value.Int)))));
                StandardBind(type,"elementSet","()Ljava/util/Set;",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);return Done(JValue.R(r.HostObject("java/util/HashSet",new JavaList{Storage=new ListStorage{Values=new JavaMapKeys(r,map),ExternalVersion=()=>map.Storage.Version},Unique=true})));});
                StandardBind(type,"entrySet","()Ljava/util/Set;",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);return Done(JValue.R(r.HostObject("java/util/HashSet",new JavaList{Storage=new ListStorage{Values=new MultisetEntries(r,map),ExternalVersion=()=>map.Storage.Version},Unique=true})));});
            }
        }
        private int MultisetAdd(JavaMap map,JValue key,int count)
        {if(count<0)throw Fault("java/lang/IllegalArgumentException");int at=MapIndex(map,key),old=at<0?0:map.Entries[at].Value.Int;if((long)old+count>int.MaxValue)throw Fault("java/lang/IllegalArgumentException");if(count>0)PutNativeMap(map,key,JValue.I(old+count));return old;}
        private sealed class MultisetEntries:IList<JValue>
        {
            private readonly JRuntime rt;private readonly JavaMap map;
            internal MultisetEntries(JRuntime r,JavaMap m){rt=r;map=m;}
            public int Count=>map.Entries.Count;public bool IsReadOnly=>false;
            public JValue this[int i]{get=>JValue.R(rt.HostObject("aot/MultisetEntry",new LiveMapEntry(map,map.Entries[i].Key)));set=>throw rt.Fault("java/lang/UnsupportedOperationException");}
            public void Add(JValue v)=>throw rt.Fault("java/lang/UnsupportedOperationException");public void Insert(int i,JValue v)=>Add(v);
            public void RemoveAt(int i)=>rt.RemoveMapAt(map,i);public void Clear(){while(Count>0)RemoveAt(Count-1);}
            public int IndexOf(JValue v){if(v.Reference==null||!rt.IsInstance(v.Reference,"com/google/common/collect/Multiset$Entry"))return -1;var key=rt.InlineCall("com/google/common/collect/Multiset$Entry","getElement","()Ljava/lang/Object;",v,Array.Empty<JValue>());int at=rt.MapIndex(map,key);return at>=0&&map.Entries[at].Value.Int==rt.InlineCall("com/google/common/collect/Multiset$Entry","getCount","()I",v,Array.Empty<JValue>()).Int?at:-1;}
            public bool Contains(JValue v)=>IndexOf(v)>=0;public bool Remove(JValue v){int i=IndexOf(v);if(i<0)return false;RemoveAt(i);return true;}
            public void CopyTo(JValue[] a,int at){for(int i=0;i<Count;i++)a[at++]=this[i];}public IEnumerator<JValue> GetEnumerator(){for(int i=0;i<Count;i++)yield return this[i];}IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        }
        private sealed class MultisetValues:IList<JValue>
        {
            private readonly JRuntime rt;private readonly JavaMap map;internal MultisetValues(JRuntime r,JavaMap m){rt=r;map=m;}
            public int Count=>(int)Math.Min(int.MaxValue,map.Entries.Sum(e=>(long)e.Value.Int));public bool IsReadOnly=>false;
            private int Entry(int index){if(index<0)throw new ArgumentOutOfRangeException();for(int i=0;i<map.Entries.Count;i++){if(index<map.Entries[i].Value.Int)return i;index-=map.Entries[i].Value.Int;}throw new ArgumentOutOfRangeException();}
            public JValue this[int index]{get=>map.Entries[Entry(index)].Key;set=>throw rt.Fault("java/lang/UnsupportedOperationException");}
            public void RemoveAt(int index){int i=Entry(index);var e=map.Entries[i];if(e.Value.Int==1)rt.RemoveMapAt(map,i);else{rt.PutNativeMap(map,e.Key,JValue.I(e.Value.Int-1));map.Storage.Version++;}}
            public void Clear(){while(map.Entries.Count>0)rt.RemoveMapAt(map,0);}public void Add(JValue v)=>rt.MultisetAdd(map,v,1);public void Insert(int i,JValue v)=>throw rt.Fault("java/lang/UnsupportedOperationException");
            public int IndexOf(JValue v){int i=0;foreach(var e in map.Entries){if(rt.NativeEqual(e.Key,v))return i;i+=e.Value.Int;}return -1;}public bool Contains(JValue v)=>IndexOf(v)>=0;public bool Remove(JValue v){int i=IndexOf(v);if(i<0)return false;RemoveAt(i);return true;}
            public void CopyTo(JValue[] a,int at){foreach(var v in this)a[at++]=v;}public IEnumerator<JValue> GetEnumerator(){foreach(var e in map.Entries)for(int i=0;i<e.Value.Int;i++)yield return e.Key;}IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class LiveMapEntry
        {internal readonly JavaMap Map;internal readonly JValue Key;internal JValue SnapshotValue;internal LiveMapEntry(JavaMap map,JValue key,JValue snapshotValue=default){Map=map;Key=key;SnapshotValue=snapshotValue;}}
        private sealed class MapEntries : IList<JValue>
        {
            private readonly JRuntime rt;private readonly JavaMap map;
            internal MapEntries(JRuntime runtime,JavaMap value){rt=runtime;map=value;}
            public int Count=>map.Entries.Count;public bool IsReadOnly=>map.Immutable;
            public JValue this[int i]{get=>JValue.R(rt.HostObject("aot/LiveMapEntry",new LiveMapEntry(map,map.Entries[i].Key,map.Entries[i].Value)));set=>throw rt.Fault("java/lang/UnsupportedOperationException");}
            public void Add(JValue v)=>throw rt.Fault("java/lang/UnsupportedOperationException");public void Insert(int i,JValue v)=>Add(v);
            public void Clear(){if(map.Immutable)throw rt.Fault("java/lang/UnsupportedOperationException");while(Count>0)rt.RemoveMapAt(map,Count-1);}
            public void RemoveAt(int i){if(map.Immutable)throw rt.Fault("java/lang/UnsupportedOperationException");rt.RemoveMapAt(map,i);}
            public int IndexOf(JValue value){if(value.Reference==null||!rt.IsInstance(value.Reference,"java/util/Map$Entry"))return -1;var key=rt.InlineCall("java/util/Map$Entry","getKey","()Ljava/lang/Object;",value,Array.Empty<JValue>());var val=rt.InlineCall("java/util/Map$Entry","getValue","()Ljava/lang/Object;",value,Array.Empty<JValue>());int at=rt.MapIndex(map,key);return at>=0&&(map.Identity?ReferenceEquals(map.Entries[at].Value.Reference,val.Reference):rt.NativeEqual(map.Entries[at].Value,val))?at:-1;}
            public bool Contains(JValue v)=>IndexOf(v)>=0;public bool Remove(JValue v){int at=IndexOf(v);if(at<0)return false;RemoveAt(at);return true;}
            public void CopyTo(JValue[] target,int at){for(int i=0;i<Count;i++)target[at++]=this[i];}
            public IEnumerator<JValue> GetEnumerator(){for(int i=0;i<Count;i++)yield return this[i];}IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        }
        private void InstallEntrySets()
        {
            NativeClass("aot/ConcurrentEntrySet","java/util/HashSet","java/util/Set");
            StandardBind("aot/ConcurrentEntrySet","iterator","()Ljava/util/Iterator;",(r,s,a)=>{var entries=(MapEntries)r.HostPayload<JavaList>(s).Values;var snapshot=new JavaList{Storage=new ListStorage{Values=new ConcurrentEntrySnapshot(r,r.ListItems(s))}};return Done(JValue.R(r.HostObject("aot/Iterator",new JavaIterator(snapshot))));});
            NativeClass("aot/ImmutableMapEntry","java/lang/Object","java/util/Map$Entry");
            StandardBind("aot/ImmutableMapEntry","getKey","()Ljava/lang/Object;",(r,s,a)=>Done(r.HostPayload<JavaPair>(s).Left));
            StandardBind("aot/ImmutableMapEntry","getValue","()Ljava/lang/Object;",(r,s,a)=>Done(r.HostPayload<JavaPair>(s).Right));
            StandardBind("aot/ImmutableMapEntry","setValue","(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>throw r.Fault("java/lang/UnsupportedOperationException"));
            foreach(string owner in new[]{"java/util/TreeMap","java/util/NavigableMap"})
            foreach(string operation in new[]{"firstEntry","lastEntry","pollFirstEntry","pollLastEntry"})
            StandardBind(owner,operation,"()Ljava/util/Map$Entry;",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);if(!map.Sorted)throw new PortGap("Navigable map requires sorted storage");if(operation.StartsWith("poll",StringComparison.Ordinal)&&map.Immutable)throw r.Fault("java/lang/UnsupportedOperationException");if(map.Entries.Count==0)return Done(JValue.R(null));int at=operation.Contains("ast")?map.Entries.Count-1:0;var pair=map.Entries[at];var result=JValue.R(r.HostObject("aot/ImmutableMapEntry",new JavaPair(pair.Key,pair.Value)));if(operation.StartsWith("poll",StringComparison.Ordinal))r.RemoveMapAt(map,at);return Done(result);});
            foreach(string owner in new[]{"java/util/TreeMap","java/util/SortedMap"})
            foreach(bool last in new[]{false,true})StandardBind(owner,last?"lastKey":"firstKey","()Ljava/lang/Object;",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);if(!map.Sorted)throw new PortGap("Sorted map requires sorted storage");if(map.Entries.Count==0)throw r.Fault("java/util/NoSuchElementException");return Done(map.Entries[last?map.Entries.Count-1:0].Key);});
            NativeClass("aot/LiveMapEntry","java/lang/Object","java/util/Map$Entry");
            StandardBind("aot/LiveMapEntry","getKey","()Ljava/lang/Object;",(r,s,a)=>Done(r.HostPayload<LiveMapEntry>(s).Key));
            StandardBind("aot/LiveMapEntry","getValue","()Ljava/lang/Object;",(r,s,a)=>{var e=r.HostPayload<LiveMapEntry>(s);if(e.Map.Concurrent)return Done(e.SnapshotValue);int at=r.MapIndex(e.Map,e.Key);return Done(at<0?JValue.R(null):e.Map.Entries[at].Value);});
            StandardBind("aot/LiveMapEntry","setValue","(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var e=r.HostPayload<LiveMapEntry>(s);if(e.Map.Concurrent){r.NonNull(a[0]);var old=e.SnapshotValue;r.PutNativeMap(e.Map,e.Key,a[0]);e.SnapshotValue=a[0];return Done(old);}if(r.MapIndex(e.Map,e.Key)<0)throw r.Fault("java/lang/IllegalStateException");return Done(r.PutNativeMap(e.Map,e.Key,a[0]));});
            foreach(string owner in new[]{"java/util/Map","java/util/HashMap","java/util/EnumMap","java/util/LinkedHashMap","java/util/TreeMap","java/util/IdentityHashMap","java/util/concurrent/ConcurrentHashMap"})StandardBind(owner,"entrySet","()Ljava/util/Set;",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);return Done(JValue.R(r.HostObject(map.Concurrent?"aot/ConcurrentEntrySet":"java/util/HashSet",new JavaList{Storage=new ListStorage{Values=new MapEntries(r,map),ExternalVersion=()=>map.Storage.Version},Unique=true,Immutable=map.Immutable})));});
        }
        private sealed class ConcurrentEntrySnapshot : IList<JValue>
        {
            private readonly JRuntime rt;private readonly List<JValue> entries;
            internal ConcurrentEntrySnapshot(JRuntime runtime,JValue[] values){rt=runtime;entries=new List<JValue>(values);}
            public int Count=>entries.Count;public bool IsReadOnly=>false;public JValue this[int i]{get=>entries[i];set=>throw rt.Fault("java/lang/UnsupportedOperationException");}
            public void RemoveAt(int i){var entry=rt.HostPayload<LiveMapEntry>(entries[i]);int at=rt.MapIndex(entry.Map,entry.Key);if(at>=0)rt.RemoveMapAt(entry.Map,at);entries.RemoveAt(i);}
            public void Clear(){while(Count>0)RemoveAt(Count-1);}public int IndexOf(JValue v)=>entries.IndexOf(v);public bool Contains(JValue v)=>entries.Contains(v);public bool Remove(JValue v){int at=IndexOf(v);if(at<0)return false;RemoveAt(at);return true;}
            public void Add(JValue v)=>throw rt.Fault("java/lang/UnsupportedOperationException");public void Insert(int i,JValue v)=>Add(v);public void CopyTo(JValue[] target,int at)=>entries.CopyTo(target,at);public IEnumerator<JValue> GetEnumerator()=>entries.GetEnumerator();IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        }
    }
}

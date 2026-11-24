using System;
using System.Linq;

namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private void InstallImmutableMultimapIndex()
        {
            const string type="com/google/common/collect/ImmutableListMultimap",parent="com/google/common/collect/ImmutableMultimap";
            NativeClass(parent,"java/lang/Object","com/google/common/collect/Multimap");NativeClass(type,parent,"com/google/common/collect/ListMultimap");
            for(int count=0;count<=10;count++)StandardBind("java/util/Set","of","("+string.Concat(Enumerable.Repeat("Ljava/lang/Object;",count))+")Ljava/util/Set;",(r,s,a)=>Done(r.ImmutableSetFactory(a)));
            StandardBind("java/util/Set","of","([Ljava/lang/Object;)Ljava/util/Set;",(r,s,a)=>Done(r.ImmutableSetFactory(r.ArrayObject(a[0]).Items)));
            StandardBind("com/google/common/collect/Multimaps","index","(Ljava/lang/Iterable;Lcom/google/common/base/Function;)L"+type+";",(r,s,a)=>{
                r.NonNull(a[1]);return r.CollectIterable(a[0],(t,values)=>{
                    var map=new JavaMultimap();foreach(var value in values){t.NonNull(value);var key=t.InlineCall("com/google/common/base/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;",a[1],new[]{value});t.NonNull(key);t.MultiPut(map,key,value);}
                    return JValue.R(t.HostObject(type,map));});});
            foreach(string owner in new[]{parent,type})
            {
                StandardBind(owner,"size","()I",(r,s,a)=>Done(JValue.I(r.HostPayload<JavaMultimap>(s).Entries.Count)));
                StandardBind(owner,"isEmpty","()Z",(r,s,a)=>Done(JValue.I(r.HostPayload<JavaMultimap>(s).Entries.Count==0?1:0)));
                StandardBind(owner,"containsKey","(Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(r.HostPayload<JavaMultimap>(s).Entries.Any(e=>r.NativeEqual(e.Key,a[0]))?1:0)));
                StandardBind(owner,"containsValue","(Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(r.HostPayload<JavaMultimap>(s).Entries.Any(e=>r.NativeEqual(e.Value,a[0]))?1:0)));
                StandardBind(owner,"containsEntry","(Ljava/lang/Object;Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(r.HostPayload<JavaMultimap>(s).Entries.Any(e=>r.NativeEqual(e.Key,a[0])&&r.NativeEqual(e.Value,a[1]))?1:0)));
                foreach(var entry in new[]{("put","(Ljava/lang/Object;Ljava/lang/Object;)Z"),("putAll","(Ljava/lang/Object;Ljava/lang/Iterable;)Z"),("putAll","(Lcom/google/common/collect/Multimap;)Z"),("remove","(Ljava/lang/Object;Ljava/lang/Object;)Z"),("clear","()V"),("removeAll","(Ljava/lang/Object;)Ljava/util/Collection;"),("removeAll","(Ljava/lang/Object;)Ljava/util/List;"),("removeAll","(Ljava/lang/Object;)Lcom/google/common/collect/ImmutableList;"),("replaceValues","(Ljava/lang/Object;Ljava/lang/Iterable;)Ljava/util/Collection;"),("replaceValues","(Ljava/lang/Object;Ljava/lang/Iterable;)Ljava/util/List;")})
                    StandardBind(owner,entry.Item1,entry.Item2,(r,s,a)=>throw r.Fault("java/lang/UnsupportedOperationException"));
                foreach(string result in new[]{"Ljava/util/List;","Ljava/util/Collection;","Lcom/google/common/collect/ImmutableList;"})StandardBind(owner,"get","(Ljava/lang/Object;)"+result,(r,s,a)=>Done(r.ListOf(r.HostPayload<JavaMultimap>(s).Entries.Where(e=>r.NativeEqual(e.Key,a[0])).Select(e=>e.Value),"com/google/common/collect/ImmutableList",true)));
                foreach(string result in new[]{"Ljava/util/Set;","Lcom/google/common/collect/ImmutableSet;"})StandardBind(owner,"keySet","()"+result,(r,s,a)=>Done(r.ListOf(r.MultiKeys(r.HostPayload<JavaMultimap>(s)),"com/google/common/collect/ImmutableSet",true)));
                StandardBind(owner,"values","()Ljava/util/Collection;",(r,s,a)=>Done(r.ListOf(r.MultiKeys(r.HostPayload<JavaMultimap>(s)).SelectMany(k=>r.HostPayload<JavaMultimap>(s).Entries.Where(e=>r.NativeEqual(k,e.Key)).Select(e=>e.Value)),"com/google/common/collect/ImmutableList",true)));
                StandardBind(owner,"entries","()Ljava/util/Collection;",(r,s,a)=>Done(r.ListOf(r.MultiKeys(r.HostPayload<JavaMultimap>(s)).SelectMany(k=>r.HostPayload<JavaMultimap>(s).Entries.Where(e=>r.NativeEqual(k,e.Key)).Select(e=>JValue.R(r.HostObject("aot/ImmutableMapEntry",new JavaPair(e.Key,e.Value))))),"com/google/common/collect/ImmutableList",true)));
                foreach(string result in new[]{"Ljava/util/Map;","Lcom/google/common/collect/ImmutableMap;"})StandardBind(owner,"asMap","()"+result,(r,s,a)=>{
                    var source=r.HostPayload<JavaMultimap>(s);var map=new JavaMap();foreach(var key in r.MultiKeys(source))r.PutNativeMap(map,key,r.ListOf(source.Entries.Where(e=>r.NativeEqual(e.Key,key)).Select(e=>e.Value),"com/google/common/collect/ImmutableList",true));map.Immutable=true;return Done(JValue.R(r.HostObject("com/google/common/collect/ImmutableMap",map)));});
            }
        }
        private JValue ImmutableSetFactory(JValue[] values)
        {
            var set=new JavaList{Unique=true};foreach(var value in values){NonNull(value);if(!AddNative(set,value))throw Fault("java/lang/IllegalArgumentException");}
            set.Immutable=true;return JValue.R(HostObject("java/util/HashSet",set));
        }
    }
}

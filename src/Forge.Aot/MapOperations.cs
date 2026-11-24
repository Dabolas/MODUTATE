using System;
using System.Collections.Generic;
using System.Linq;

namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private bool HashMapEquals(JValue self, JValue other)
        {
            if (ReferenceEquals(self.Reference, other.Reference)) return true;
            if (other.Reference == null || !IsInstance(other.Reference, "java/util/Map")) return false;
            const string map = "java/util/Map";
            var entries = MapItems(self);
            if (entries.Length != InlineCall(map, "size", "()I", other, Array.Empty<JValue>()).Int) return false;
            foreach (var entry in entries)
            {
                var key = new[] { entry.Key };
                var value = InlineCall(map, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", other, key);
                if (!NativeEqual(entry.Value, value)) return false;
                if (value.Reference == null && InlineCall(map, "containsKey", "(Ljava/lang/Object;)Z", other, key).Int == 0)
                    return false;
            }
            return true;
        }

        private void InstallMapOperations()
        {
            foreach (string owner in new[] { "java/util/HashMap", "java/util/LinkedHashMap" })
            {
                StandardBind(owner, "equals", "(Ljava/lang/Object;)Z", (r, self, args) =>
                    Done(JValue.I(r.HashMapEquals(self, args[0]) ? 1 : 0)));
                StandardBind(owner, "hashCode", "()I", (r, self, args) =>
                {
                    int hash = 0;
                    int Hash(JValue value) => value.Reference == null ? 0 :
                        r.InlineCall("java/lang/Object", "hashCode", "()I", value, Array.Empty<JValue>()).Int;
                    foreach (var entry in r.MapItems(self))
                        hash = unchecked(hash + (Hash(entry.Key) ^ Hash(entry.Value)));
                    return Done(JValue.I(hash));
                });
            }
            foreach(string type in new[]{"HashMap","LinkedHashMap"})StandardBind("com/google/common/collect/Maps","new"+type,"(Ljava/util/Map;)Ljava/util/"+type+";",(r,s,a)=>{var map=new JavaMap();foreach(var pair in r.MapItems(a[0]))r.PutNativeMap(map,pair.Key,pair.Value);return Done(JValue.R(r.HostObject("java/util/"+type,map)));});
            StandardBind("com/google/common/collect/Maps","newHashMapWithExpectedSize","(I)Ljava/util/HashMap;",(r,s,a)=>{if(a[0].Int<0)throw r.Fault("java/lang/IllegalArgumentException");return Done(r.MapOf(Array.Empty<KeyValuePair<JValue,JValue>>()));});
            StandardBind("java/util/EnumMap","<init>","(Ljava/lang/Class;)V",(r,s,a)=>{string type=r.EnumType(a[0]);var obj=r.NonNull(s);obj.Payload=new JavaMap{Sorted=true,EnumClass=type};obj.HostStorage=true;return Done();});
            foreach(string parameter in new[]{"java/util/Map","java/util/EnumMap"})StandardBind("java/util/EnumMap","<init>","(L"+parameter+";)V",(r,s,a)=>{var pairs=r.MapItems(a[0]);string? type=(r.NonNull(a[0]).Payload as JavaMap)?.EnumClass;if(type==null){if(pairs.Length==0)throw r.Fault("java/lang/IllegalArgumentException");var key=r.NonNull(pairs[0].Key);if(!r.IsInstance(key,"java/lang/Enum"))throw r.Fault("java/lang/ClassCastException");type=key.ClassName;while(r.Program.Classes.TryGetValue(type,out var meta)&&meta.Super!="java/lang/Enum")type=meta.Super;}var map=new JavaMap{Sorted=true,EnumClass=type};foreach(var pair in pairs)r.PutNativeMap(map,pair.Key,pair.Value);var obj=r.NonNull(s);obj.Payload=map;obj.HostStorage=true;return Done();});
            StandardBind("com/google/common/collect/Maps","newEnumMap","(Ljava/lang/Class;)Ljava/util/EnumMap;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/EnumMap",new JavaMap{Sorted=true,EnumClass=r.EnumType(a[0])}))));
            NativeClass("aot/MapSet","java/util/HashSet","java/util/Set");
            StandardBind("java/util/Collections","newSetFromMap","(Ljava/util/Map;)Ljava/util/Set;",(r,s,a)=>{var map=r.HostPayload<JavaMap>(a[0]);if(map.Entries.Count!=0)throw r.Fault("java/lang/IllegalArgumentException");return Done(JValue.R(r.HostObject("aot/MapSet",new JavaList{Storage=new ListStorage{Values=new JavaMapKeys(r,map),ExternalVersion=()=>map.Storage.Version},Unique=true})));});
            foreach(string operation in new[]{"add","contains","remove"})StandardBind("aot/MapSet",operation,"(Ljava/lang/Object;)Z",(r,s,a)=>{var map=((JavaMapKeys)r.HostPayload<JavaList>(s).Values).Map;int index=r.MapIndex(map,a[0]);if(operation=="add"){r.PutNativeMap(map,a[0],JValue.R(r.BooleanBox(true)));return Done(JValue.I(index<0?1:0));}if(operation=="remove"&&index>=0){if(map.Immutable)throw r.Fault("java/lang/UnsupportedOperationException");r.RemoveMapAt(map,index);}return Done(JValue.I(index>=0?1:0));});
            foreach(var factory in new[]{("newLinkedHashMap","java/util/LinkedHashMap"),("newIdentityHashMap","java/util/IdentityHashMap"),("newTreeMap","java/util/TreeMap"),("newConcurrentMap","java/util/concurrent/ConcurrentMap")})StandardBind("com/google/common/collect/Maps",factory.Item1,"()L"+factory.Item2+";",(r,s,a)=>Done(JValue.R(r.HostObject(factory.Item2=="java/util/concurrent/ConcurrentMap"?"java/util/concurrent/ConcurrentHashMap":factory.Item2,new JavaMap{Identity=factory.Item1=="newIdentityHashMap",Sorted=factory.Item1=="newTreeMap",Concurrent=factory.Item1=="newConcurrentMap"}))));
            NativeClass("java/util/IdentityHashMap","java/lang/Object","java/util/Map");
            foreach(string descriptor in new[]{"()V","(I)V"})StandardBind("java/util/IdentityHashMap","<init>",descriptor,(r,s,a)=>{if(a.Length!=0&&a[0].Int<0)throw r.Fault("java/lang/IllegalArgumentException");var obj=r.NonNull(s);obj.Payload=new JavaMap{Identity=true};obj.HostStorage=true;return Done();});
            const string id="java/util/IdentityHashMap";
            StandardBind(id,"get","(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);int at=r.MapIndex(map,a[0]);return Done(at<0?JValue.R(null):map.Entries[at].Value);});
            StandardBind(id,"put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>Done(r.PutNativeMap(r.HostPayload<JavaMap>(s),a[0],a[1])));
            StandardBind(id,"size","()I",(r,s,a)=>Done(JValue.I(r.HostPayload<JavaMap>(s).Entries.Count)));
            StandardBind(id,"isEmpty","()Z",(r,s,a)=>Done(JValue.I(r.HostPayload<JavaMap>(s).Entries.Count==0?1:0)));
            StandardBind(id,"values","()Ljava/util/Collection;",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);return Done(JValue.R(r.HostObject("aot/MapValues",new JavaList{Storage=new ListStorage{Values=new JavaMapKeys(r,map,false),ExternalVersion=()=>map.Storage.Version}})));});
            foreach(string owner in new[]{"java/util/Map","java/util/HashMap","java/util/LinkedHashMap","java/util/TreeMap","java/util/SortedMap","java/util/NavigableMap",id})
            {
                StandardBind(owner,"clear","()V",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);if(map.Immutable)throw r.Fault("java/lang/UnsupportedOperationException");while(map.Entries.Count>0)r.RemoveMapAt(map,map.Entries.Count-1);return Done();});
                StandardBind(owner,"remove","(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);if(map.Immutable)throw r.Fault("java/lang/UnsupportedOperationException");int at=r.MapIndex(map,a[0]);if(at<0)return Done(JValue.R(null));var value=map.Entries[at].Value;r.RemoveMapAt(map,at);return Done(value);});
                StandardBind(owner,"containsValue","(Ljava/lang/Object;)Z",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);return Done(JValue.I(map.Entries.Any(e=>map.Identity?ReferenceEquals(e.Value.Reference,a[0].Reference):r.NativeEqual(e.Value,a[0]))?1:0));});
                StandardBind(owner,"getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);int at=r.MapIndex(map,a[0]);return Done(at<0?a[1]:map.Entries[at].Value);});
                StandardBind(owner,"putIfAbsent","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);int at=r.MapIndex(map,a[0]);return Done(at>=0&&map.Entries[at].Value.Reference!=null?map.Entries[at].Value:r.PutNativeMap(map,a[0],a[1]));});
                StandardBind(owner,"putAll","(Ljava/util/Map;)V",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);if(map.Immutable)throw r.Fault("java/lang/UnsupportedOperationException");foreach(var pair in r.MapItems(a[0]))r.PutNativeMap(map,pair.Key,pair.Value);return Done();});
                StandardBind(owner,"replace","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);if(map.Immutable)throw r.Fault("java/lang/UnsupportedOperationException");int at=r.MapIndex(map,a[0]);if(at<0||!(map.Identity?ReferenceEquals(map.Entries[at].Value.Reference,a[1].Reference):r.NativeEqual(map.Entries[at].Value,a[1])))return Done(JValue.I(0));r.PutNativeMap(map,a[0],a[2]);return Done(JValue.I(1));});
                StandardBind(owner,"merge","(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;",(r,s,a)=>
                {r.NonNull(a[1]);r.NonNull(a[2]);var map=r.HostPayload<JavaMap>(s);if(map.Immutable)throw r.Fault("java/lang/UnsupportedOperationException");int at=r.MapIndex(map,a[0]);if(at<0||map.Entries[at].Value.Reference==null){r.PutNativeMap(map,a[0],a[1]);return Done(a[1]);}int version=map.Storage.Version;return r.Callback("java/util/function/BiFunction","apply","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",a[2],new[]{map.Entries[at].Value,a[1]},(t,v)=>{if(version!=map.Storage.Version)throw t.Fault("java/util/ConcurrentModificationException");if(v.Reference==null)t.RemoveMapAt(map,t.MapIndex(map,a[0]));else t.PutNativeMap(map,a[0],v);return v;});});
            }
            StandardBind("java/util/HashMap","<init>","(Ljava/util/Map;)V",(r,s,a)=>{var map=new JavaMap();foreach(var pair in r.MapItems(a[0]))r.PutNativeMap(map,pair.Key,pair.Value);var obj=r.NonNull(s);obj.Payload=map;obj.HostStorage=true;return Done();});
            for(int count=0;count<=2;count++)StandardBind("java/util/Map","of","("+string.Concat(Enumerable.Repeat("Ljava/lang/Object;",count*2))+")Ljava/util/Map;",(r,s,a)=>{var map=new JavaMap();for(int i=0;i<a.Length;i+=2){r.NonNull(a[i]);r.NonNull(a[i+1]);if(r.MapIndex(map,a[i])>=0)throw r.Fault("java/lang/IllegalArgumentException");r.PutNativeMap(map,a[i],a[i+1]);}map.Immutable=true;return Done(JValue.R(r.HostObject("java/util/HashMap",map)));});
            StandardBind("java/util/Map","copyOf","(Ljava/util/Map;)Ljava/util/Map;",(r,s,a)=>{var map=new JavaMap();foreach(var pair in r.MapItems(a[0])){r.NonNull(pair.Key);r.NonNull(pair.Value);r.PutNativeMap(map,pair.Key,pair.Value);}map.Immutable=true;return Done(JValue.R(r.HostObject("java/util/HashMap",map)));});
        }
    }
}

using System;
using System.Linq;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private void InstallImmutableLists()
        {
            const string type="com/google/common/collect/ImmutableList",builder=type+"$Builder";
            NativeClass(type,"java/util/AbstractList","java/util/List");NativeClass(builder);
            const string iterator="com/google/common/collect/UnmodifiableIterator";NativeClass(iterator,"java/lang/Object","java/util/Iterator");
            StandardBind(iterator,"hasNext","()Z",bindings["aot/Iterator.hasNext()Z"]);
            StandardBind(iterator,"next","()Ljava/lang/Object;",bindings["aot/Iterator.next()Ljava/lang/Object;"]);
            StandardBind(iterator,"remove","()V",(r,s,a)=>throw r.Fault("java/lang/UnsupportedOperationException"));
            foreach(string owner in new[]{type,"com/google/common/collect/ImmutableSet"})StandardBind(owner,"iterator","()L"+iterator+";",(r,s,a)=>Done(JValue.R(r.HostObject(iterator,new JavaIterator(r.HostPayload<JavaList>(s))))));
            const string mapType="com/google/common/collect/ImmutableMap";NativeClass(mapType,"java/util/HashMap","java/util/Map");
            StandardBind(mapType,"copyOf","(Ljava/util/Map;)L"+mapType+";",(r,s,a)=>{var map=new JavaMap();foreach(var pair in r.MapItems(a[0])){r.NonNull(pair.Key);r.NonNull(pair.Value);r.PutNativeMap(map,pair.Key,pair.Value);}map.Immutable=true;return Done(JValue.R(r.HostObject(mapType,map)));});
            for(int n=0;n<=5;n++)StandardBind(mapType,"of","("+string.Concat(Enumerable.Repeat("Ljava/lang/Object;",n*2))+")L"+mapType+";",(r,s,a)=>{var map=new JavaMap();for(int i=0;i<a.Length;i+=2){r.NonNull(a[i]);r.NonNull(a[i+1]);if(r.MapIndex(map,a[i])>=0)throw r.Fault("java/lang/IllegalArgumentException");r.PutNativeMap(map,a[i],a[i+1]);}map.Immutable=true;return Done(JValue.R(r.HostObject(mapType,map)));});
            for(int n=0;n<=12;n++)StandardBind(type,"of","("+string.Concat(Enumerable.Repeat("Ljava/lang/Object;",n))+")L"+type+";",(r,s,a)=>{foreach(var value in a)r.NonNull(value);return Done(r.ListOf(a,type,true));});
            StandardBind(type,"of","("+string.Concat(Enumerable.Repeat("Ljava/lang/Object;",12))+"[Ljava/lang/Object;)L"+type+";",(r,s,a)=>{var values=a.Take(12).Concat(r.ArrayObject(a[12]).Items).ToArray();foreach(var value in values)r.NonNull(value);return Done(r.ListOf(values,type,true));});
            foreach(string source in new[]{"Ljava/lang/Iterable;","Ljava/util/Collection;"})StandardBind(type,"copyOf","("+source+")L"+type+";",(r,s,a)=>r.CollectIterable(a[0],(t,v)=>{foreach(var value in v)t.NonNull(value);return t.ListOf(v,type,true);}));
            StandardBind(type,"copyOf","([Ljava/lang/Object;)L"+type+";",(r,s,a)=>{var values=r.ArrayObject(a[0]).Items;foreach(var value in values)r.NonNull(value);return Done(r.ListOf(values,type,true));});
            StandardBind(type,"builder","()L"+builder+";",(r,s,a)=>Done(r.ListOf(Array.Empty<JValue>(),builder)));
            StandardBind(builder,"add","(Ljava/lang/Object;)L"+builder+";",(r,s,a)=>{r.NonNull(a[0]);r.AddNative(r.HostPayload<JavaList>(s),a[0]);return Done(s);});
            StandardBind(builder,"add","([Ljava/lang/Object;)L"+builder+";",(r,s,a)=>{foreach(var v in r.ArrayObject(a[0]).Items){r.NonNull(v);r.AddNative(r.HostPayload<JavaList>(s),v);}return Done(s);});
            StandardBind(builder,"addAll","(Ljava/lang/Iterable;)L"+builder+";",(r,s,a)=>r.CollectIterable(a[0],(t,values)=>{foreach(var v in values){t.NonNull(v);t.AddNative(t.HostPayload<JavaList>(s),v);}return s;}));
            StandardBind(builder,"build","()L"+type+";",(r,s,a)=>Done(r.ListOf(r.ListItems(s),type,true)));
            foreach(string source in new[]{"Ljava/lang/Iterable;","Ljava/util/Collection;"})StandardBind("com/google/common/collect/ImmutableSet","copyOf","("+source+")Lcom/google/common/collect/ImmutableSet;",(r,s,a)=>r.CollectIterable(a[0],(t,v)=>{var set=new JavaList{Unique=true};foreach(var value in v){t.NonNull(value);t.AddNative(set,value);}set.Immutable=true;return JValue.R(t.HostObject("com/google/common/collect/ImmutableSet",set));}));
        }
    }
}

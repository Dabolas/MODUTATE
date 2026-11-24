using System;
using System.Collections.Generic;

namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class SortedMapBuilder
        {internal readonly List<KeyValuePair<JValue,JValue>> Items=new List<KeyValuePair<JValue,JValue>>();}
        private void InstallSortedMaps()
        {
            const string mapType="com/google/common/collect/ImmutableSortedMap",builderType=mapType+"$Builder";
            NativeClass(mapType,"java/util/TreeMap","java/util/Map");NativeClass(builderType);
            foreach(string type in new[]{mapType,"java/util/TreeMap"})StandardBind(type,"floorKey","(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{r.NonNull(a[0]);var map=r.HostPayload<JavaMap>(s);JValue found=default;foreach(var entry in map.Entries){if(r.CompareMapKeys(map,entry.Key,a[0])>0)break;found=entry.Key;}return Done(found);});
            StandardBind(mapType,"naturalOrder","()L"+builderType+";",(r,s,a)=>Done(JValue.R(r.HostObject(builderType,new SortedMapBuilder()))));
            StandardBind(builderType,"put","(Ljava/lang/Object;Ljava/lang/Object;)L"+builderType+";",(r,s,a)=>
            {r.NonNull(a[0]);r.NonNull(a[1]);r.CompareNative(a[0],a[0]);r.HostPayload<SortedMapBuilder>(s).Items.Add(new KeyValuePair<JValue,JValue>(a[0],a[1]));return Done(s);});
            foreach(string name in new[]{"build","buildOrThrow"})
                StandardBind(builderType,name,"()L"+mapType+";",(r,s,a)=>
                {var map=new JavaMap{Sorted=true};foreach(var entry in r.HostPayload<SortedMapBuilder>(s).Items){if(r.MapIndex(map,entry.Key)>=0)throw r.Fault("java/lang/IllegalArgumentException","Duplicate sorted-map key");r.PutNativeMap(map,entry.Key,entry.Value);}map.Immutable=true;return Done(JValue.R(r.HostObject(mapType,map)));});
        }
    }
}

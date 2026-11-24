using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class JavaMultimap
        {internal readonly List<(JValue Key,JValue Value)> Entries=new List<(JValue,JValue)>();internal bool Unique;internal int Version;internal string? EnumClass;}
        private sealed class MultimapBuilderValue {internal bool Unique;internal string? EnumClass;}
        private sealed class MultimapView : IList<JValue>
        {
            private readonly JRuntime runtime;private readonly JavaMultimap map;private readonly JValue key;private readonly bool all;
            internal MultimapView(JRuntime rt,JavaMultimap data,JValue k,bool every){runtime=rt;map=data;key=k;all=every;}
            private int[] Indices()=>Enumerable.Range(0,map.Entries.Count).Where(i=>all||runtime.NativeEqual(map.Entries[i].Key,key)).ToArray();
            public int Count=>Indices().Length;public bool IsReadOnly=>false;
            public JValue this[int i]{get=>map.Entries[Indices()[i]].Value;set{if(all||map.Unique)throw runtime.Fault("java/lang/UnsupportedOperationException");map.Entries[Indices()[i]]=(key,value);}}
            public void Add(JValue value){if(all)throw runtime.Fault("java/lang/UnsupportedOperationException");runtime.MultiPut(map,key,value);}
            public void Clear(){foreach(int i in Indices().Reverse()){map.Entries.RemoveAt(i);map.Version++;}}
            public int IndexOf(JValue value){int i=0;foreach(var x in this){if(runtime.NativeEqual(x,value))return i;i++;}return -1;}
            public bool Contains(JValue value)=>IndexOf(value)>=0;
            public void CopyTo(JValue[] values,int start){foreach(var v in this)values[start++]=v;}
            public void Insert(int i,JValue value){if(all||map.Unique)throw runtime.Fault("java/lang/UnsupportedOperationException");var ids=Indices();if(i==ids.Length)Add(value);else{map.Entries.Insert(ids[i],(key,value));map.Version++;}}
            public void RemoveAt(int i){map.Entries.RemoveAt(Indices()[i]);map.Version++;}
            public bool Remove(JValue value){int i=IndexOf(value);if(i<0)return false;RemoveAt(i);return true;}
            public IEnumerator<JValue> GetEnumerator(){foreach(int i in Indices())yield return map.Entries[i].Value;}
            IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        }
        private bool MultiPut(JavaMultimap map,JValue key,JValue value)
        {if(map.EnumClass!=null&&NonNull(key).ClassName!=map.EnumClass)throw Fault("java/lang/ClassCastException");if(map.Unique&&map.Entries.Any(e=>NativeEqual(e.Key,key)&&NativeEqual(e.Value,value)))return false;map.Entries.Add((key,value));map.Version++;return true;}
        private JValue MultiView(JavaMultimap map,JValue key,bool all)
        {return JValue.R(HostObject(all?"java/util/ArrayList":map.Unique?"java/util/HashSet":"java/util/ArrayList",new JavaList{Storage=new ListStorage{Values=new MultimapView(this,map,key,all),ExternalVersion=()=>map.Version},Unique=!all&&map.Unique}));}
        private void InstallMultimaps()
        {
            InstallMultimapAsMap();
            InstallImmutableMultimapIndex();
            StandardBind("com/google/common/collect/Multimaps","invertFrom","(Lcom/google/common/collect/Multimap;Lcom/google/common/collect/Multimap;)Lcom/google/common/collect/Multimap;",(r,s,a)=>{var entries=r.InlineCall("com/google/common/collect/Multimap","entries","()Ljava/util/Collection;",a[0],Array.Empty<JValue>());foreach(var entry in r.ListItems(entries)){var key=r.InlineCall("java/util/Map$Entry","getKey","()Ljava/lang/Object;",entry,Array.Empty<JValue>());var value=r.InlineCall("java/util/Map$Entry","getValue","()Ljava/lang/Object;",entry,Array.Empty<JValue>());r.InlineCall("com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z",a[1],new[]{value,key});}return Done(a[1]);});
            const string builder="com/google/common/collect/MultimapBuilder",keys=builder+"$MultimapBuilderWithKeys",list=builder+"$ListMultimapBuilder",set=builder+"$SetMultimapBuilder";
            foreach(string type in new[]{builder,keys,list,set,"com/google/common/collect/Multimap"})NativeClass(type);
            NativeClass("com/google/common/collect/ListMultimap","java/lang/Object","com/google/common/collect/Multimap");NativeClass("com/google/common/collect/SetMultimap","java/lang/Object","com/google/common/collect/Multimap");
            NativeClass("com/google/common/collect/ArrayListMultimap","java/lang/Object","com/google/common/collect/ListMultimap");NativeClass("com/google/common/collect/HashMultimap","java/lang/Object","com/google/common/collect/SetMultimap");
            StandardBind(builder,"hashKeys","()L"+keys+";",(r,s,a)=>Done(JValue.R(r.HostObject(keys,new MultimapBuilderValue()))));
            StandardBind(builder,"hashKeys","(I)L"+keys+";",(r,s,a)=>{if(a[0].Int<0)throw r.Fault("java/lang/IllegalArgumentException");return Done(JValue.R(r.HostObject(keys,new MultimapBuilderValue())));});
            StandardBind(builder,"enumKeys","(Ljava/lang/Class;)L"+keys+";",(r,s,a)=>Done(JValue.R(r.HostObject(keys,new MultimapBuilderValue{EnumClass=r.EnumType(a[0])}))));
            foreach(string mode in new[]{"arrayListValues","linkedHashSetValues","hashSetValues"})StandardBind(keys,mode,"()L"+(mode=="arrayListValues"?list:set)+";",(r,s,a)=>Done(JValue.R(r.HostObject(mode=="arrayListValues"?list:set,new MultimapBuilderValue{EnumClass=r.HostPayload<MultimapBuilderValue>(s).EnumClass,Unique=mode!="arrayListValues"}))));
            foreach(string type in new[]{list,set})StandardBind(type,"build","()Lcom/google/common/collect/"+(type==list?"ListMultimap":"SetMultimap")+";",(r,s,a)=>{var config=r.HostPayload<MultimapBuilderValue>(s);return Done(JValue.R(r.HostObject(config.Unique?"com/google/common/collect/HashMultimap":"com/google/common/collect/ArrayListMultimap",new JavaMultimap{Unique=config.Unique,EnumClass=config.EnumClass})));});
            foreach(string type in new[]{list,set})StandardBind(type,"build","(Lcom/google/common/collect/Multimap;)Lcom/google/common/collect/"+(type==list?"ListMultimap":"SetMultimap")+";",(r,s,a)=>{var config=r.HostPayload<MultimapBuilderValue>(s);var copy=new JavaMultimap{Unique=config.Unique,EnumClass=config.EnumClass};var entries=r.InlineCall("com/google/common/collect/Multimap","entries","()Ljava/util/Collection;",a[0],Array.Empty<JValue>());foreach(var e in r.ListItems(entries)){var key=r.InlineCall("java/util/Map$Entry","getKey","()Ljava/lang/Object;",e,Array.Empty<JValue>());var value=r.InlineCall("java/util/Map$Entry","getValue","()Ljava/lang/Object;",e,Array.Empty<JValue>());r.MultiPut(copy,key,value);}return Done(JValue.R(r.HostObject(config.Unique?"com/google/common/collect/HashMultimap":"com/google/common/collect/ArrayListMultimap",copy)));});
            foreach(string type in new[]{"com/google/common/collect/ArrayListMultimap","com/google/common/collect/HashMultimap"})StandardBind(type,"create","()L"+type+";",(r,s,a)=>Done(JValue.R(r.HostObject(type,new JavaMultimap{Unique=type.EndsWith("HashMultimap",StringComparison.Ordinal)}))));
            foreach(string type in new[]{"com/google/common/collect/Multimap","com/google/common/collect/ListMultimap","com/google/common/collect/SetMultimap","com/google/common/collect/ArrayListMultimap","com/google/common/collect/HashMultimap"})
            {
                StandardBind(type,"asMap","()Ljava/util/Map;",(r,s,a)=>Done(JValue.R(r.HostObject("aot/MultimapAsMap",r.HostPayload<JavaMultimap>(s)))));
                StandardBind(type,"size","()I",(r,s,a)=>Done(JValue.I(r.HostPayload<JavaMultimap>(s).Entries.Count)));
                StandardBind(type,"keySet","()Ljava/util/Set;",(r,s,a)=>{var m=r.HostPayload<JavaMultimap>(s);return Done(JValue.R(r.HostObject("java/util/HashSet",new JavaList{Unique=true,Storage=new ListStorage{Values=new MultimapMapView(r,m,"keySet"),ExternalVersion=()=>m.Version}})));});
                StandardBind(type,"isEmpty","()Z",(r,s,a)=>Done(JValue.I(r.HostPayload<JavaMultimap>(s).Entries.Count==0?1:0)));
                StandardBind(type,"clear","()V",(r,s,a)=>{var m=r.HostPayload<JavaMultimap>(s);m.Entries.Clear();m.Version++;return Done();});
                StandardBind(type,"containsKey","(Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(r.HostPayload<JavaMultimap>(s).Entries.Any(e=>r.NativeEqual(e.Key,a[0]))?1:0)));
                StandardBind(type,"containsValue","(Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(r.HostPayload<JavaMultimap>(s).Entries.Any(e=>r.NativeEqual(e.Value,a[0]))?1:0)));
                StandardBind(type,"put","(Ljava/lang/Object;Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(r.MultiPut(r.HostPayload<JavaMultimap>(s),a[0],a[1])?1:0)));
                foreach(string result in new[]{"Collection","List","Set"})StandardBind(type,"get","(Ljava/lang/Object;)Ljava/util/"+result+";",(r,s,a)=>Done(r.MultiView(r.HostPayload<JavaMultimap>(s),a[0],false)));
                StandardBind(type,"values","()Ljava/util/Collection;",(r,s,a)=>Done(r.MultiView(r.HostPayload<JavaMultimap>(s),default,true)));
                StandardBind(type,"entries","()Ljava/util/Collection;",(r,s,a)=>{var m=r.HostPayload<JavaMultimap>(s);return Done(JValue.R(r.HostObject("java/util/ArrayList",new JavaList{Storage=new ListStorage{Values=new MultimapEntries(r,m),ExternalVersion=()=>m.Version}})));});
                StandardBind(type,"remove","(Ljava/lang/Object;Ljava/lang/Object;)Z",(r,s,a)=>{var m=r.HostPayload<JavaMultimap>(s);int i=m.Entries.FindIndex(e=>r.NativeEqual(e.Key,a[0])&&r.NativeEqual(e.Value,a[1]));if(i<0)return Done(JValue.I(0));m.Entries.RemoveAt(i);m.Version++;return Done(JValue.I(1));});
                StandardBind(type,"putAll","(Ljava/lang/Object;Ljava/lang/Iterable;)Z",(r,s,a)=>r.CollectIterable(a[1],(t,v)=>{bool changed=false;foreach(var value in v)changed|=t.MultiPut(t.HostPayload<JavaMultimap>(s),a[0],value);return JValue.I(changed?1:0);}));
                StandardBind(type,"putAll","(Lcom/google/common/collect/Multimap;)Z",(r,s,a)=>{var entries=r.InlineCall("com/google/common/collect/Multimap","entries","()Ljava/util/Collection;",a[0],Array.Empty<JValue>());bool changed=false;foreach(var entry in r.ListItems(entries)){var key=r.InlineCall("java/util/Map$Entry","getKey","()Ljava/lang/Object;",entry,Array.Empty<JValue>());var value=r.InlineCall("java/util/Map$Entry","getValue","()Ljava/lang/Object;",entry,Array.Empty<JValue>());changed|=r.MultiPut(r.HostPayload<JavaMultimap>(s),key,value);}return Done(JValue.I(changed?1:0));});
                foreach(string result in new[]{"Collection","List","Set"})StandardBind(type,"removeAll","(Ljava/lang/Object;)Ljava/util/"+result+";",(r,s,a)=>{var m=r.HostPayload<JavaMultimap>(s);var view=new MultimapView(r,m,a[0],false);var old=view.ToArray();view.Clear();return Done(r.ListOf(old,m.Unique?"java/util/HashSet":"java/util/ArrayList"));});
            }
        }
        private JValue[] MultiKeys(JavaMultimap map){var keys=new List<JValue>();foreach(var e in map.Entries)if(!keys.Any(k=>NativeEqual(k,e.Key)))keys.Add(e.Key);return keys.ToArray();}
        private sealed class MultimapEntries:IList<JValue>
        {
            private readonly JRuntime rt;private readonly JavaMultimap map;internal MultimapEntries(JRuntime r,JavaMultimap m){rt=r;map=m;}
            public int Count=>map.Entries.Count;public bool IsReadOnly=>false;public JValue this[int i]{get{var e=map.Entries[i];return JValue.R(rt.HostObject("aot/MapEntry",new KeyValuePair<JValue,JValue>(e.Key,e.Value)));}set=>throw rt.Fault("java/lang/UnsupportedOperationException");}
            public void RemoveAt(int i){map.Entries.RemoveAt(i);map.Version++;}public void Clear(){map.Entries.Clear();map.Version++;}public void Add(JValue v)=>throw rt.Fault("java/lang/UnsupportedOperationException");public void Insert(int i,JValue v)=>Add(v);public int IndexOf(JValue v){if(v.Reference==null||!rt.IsInstance(v.Reference,"java/util/Map$Entry"))return -1;var k=rt.InlineCall("java/util/Map$Entry","getKey","()Ljava/lang/Object;",v,Array.Empty<JValue>());var value=rt.InlineCall("java/util/Map$Entry","getValue","()Ljava/lang/Object;",v,Array.Empty<JValue>());return map.Entries.FindIndex(e=>rt.NativeEqual(e.Key,k)&&rt.NativeEqual(e.Value,value));}public bool Contains(JValue v)=>IndexOf(v)>=0;public bool Remove(JValue v){int i=IndexOf(v);if(i<0)return false;RemoveAt(i);return true;}public void CopyTo(JValue[] a,int at){foreach(var v in this)a[at++]=v;}public IEnumerator<JValue> GetEnumerator(){for(int i=0;i<Count;i++)yield return this[i];}IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        }
        private void InstallMultimapAsMap()
        {
            const string type="aot/MultimapAsMap";NativeClass(type,"java/lang/Object","java/util/Map");
            StandardBind(type,"size","()I",(r,s,a)=>Done(JValue.I(r.MultiKeys(r.HostPayload<JavaMultimap>(s)).Length)));
            StandardBind(type,"isEmpty","()Z",(r,s,a)=>Done(JValue.I(r.HostPayload<JavaMultimap>(s).Entries.Count==0?1:0)));
            StandardBind(type,"containsKey","(Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(r.MultiKeys(r.HostPayload<JavaMultimap>(s)).Any(k=>r.NativeEqual(k,a[0]))?1:0)));
            StandardBind(type,"get","(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var m=r.HostPayload<JavaMultimap>(s);return Done(m.Entries.Any(e=>r.NativeEqual(e.Key,a[0]))?r.MultiView(m,a[0],false):default);});
            StandardBind(type,"remove","(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var m=r.HostPayload<JavaMultimap>(s);var view=new MultimapView(r,m,a[0],false);if(view.Count==0)return Done(default);var old=r.ListOf(view.ToArray(),m.Unique?"java/util/HashSet":"java/util/ArrayList");view.Clear();return Done(old);});
            StandardBind(type,"clear","()V",(r,s,a)=>{var m=r.HostPayload<JavaMultimap>(s);m.Entries.Clear();m.Version++;return Done();});
            StandardBind(type,"put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>throw r.Fault("java/lang/UnsupportedOperationException"));
            foreach(string method in new[]{"entrySet","keySet","values"})StandardBind(type,method,"()Ljava/util/"+(method=="values"?"Collection":"Set")+";",(r,s,a)=>{var m=r.HostPayload<JavaMultimap>(s);return Done(JValue.R(r.HostObject(method=="values"?"java/util/ArrayList":"java/util/HashSet",new JavaList{Unique=method!="values",Storage=new ListStorage{Values=new MultimapMapView(r,m,method),ExternalVersion=()=>m.Version}})));});
        }
        private sealed class MultimapMapView:IList<JValue>
        {
            private readonly JRuntime rt;private readonly JavaMultimap map;private readonly string kind;internal MultimapMapView(JRuntime r,JavaMultimap m,string k){rt=r;map=m;kind=k;}
            public int Count=>rt.MultiKeys(map).Length;public bool IsReadOnly=>false;
            public JValue this[int i]{get{var key=rt.MultiKeys(map)[i];if(kind=="keySet")return key;var v=rt.MultiView(map,key,false);return kind=="values"?v:JValue.R(rt.HostObject("aot/ImmutableMapEntry",new JavaPair(key,v)));}set=>throw rt.Fault("java/lang/UnsupportedOperationException");}
            public void RemoveAt(int i)=>new MultimapView(rt,map,rt.MultiKeys(map)[i],false).Clear();public void Clear(){map.Entries.Clear();map.Version++;}public void Add(JValue v)=>throw rt.Fault("java/lang/UnsupportedOperationException");public void Insert(int i,JValue v)=>Add(v);
            public int IndexOf(JValue v){for(int i=0;i<Count;i++)if(rt.NativeEqual(this[i],v))return i;return -1;}public bool Contains(JValue v)=>IndexOf(v)>=0;public bool Remove(JValue v){int i=IndexOf(v);if(i<0)return false;RemoveAt(i);return true;}
            public void CopyTo(JValue[] a,int at){foreach(var v in this)a[at++]=v;}public IEnumerator<JValue> GetEnumerator(){for(int i=0;i<Count;i++)yield return this[i];}IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        }
    }
}

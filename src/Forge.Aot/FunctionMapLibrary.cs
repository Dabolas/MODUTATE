using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class FunctionMap {internal JValue Keys,Function,Source;internal FunctionMap(JValue k,JValue f){Keys=k;Function=f;}}
        private sealed class FunctionMapIterator{internal readonly FunctionMapValues View;internal readonly JValue Iterator;internal FunctionMapIterator(FunctionMapValues v,JValue i){View=v;Iterator=i;}}
        private JValue FunctionValue(FunctionMap map,JValue key)=>InlineCall("com/google/common/base/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;",map.Function,new[]{map.Source.Reference==null?key:InlineCall("java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;",map.Source,new[]{key})});
        private void InstallFunctionMaps()
        {
            const string type="aot/FunctionMap";NativeClass(type,"java/lang/Object","java/util/Map");
            NativeClass("aot/FunctionMapValues","java/util/AbstractCollection","java/util/Collection");NativeClass("aot/FunctionMapSet","aot/FunctionMapValues","java/util/Set");NativeClass("aot/FunctionMapIterator","java/lang/Object","java/util/Iterator");
            foreach(var b in bindings.Where(b=>b.Key.StartsWith("java/util/ArrayList.",StringComparison.Ordinal)).ToArray()){string sig=b.Key.Substring("java/util/ArrayList.".Length);int at=sig.IndexOf('(');string name=sig.Substring(0,at);if(name=="iterator"||name=="equals"||name=="hashCode"||name=="<init>")continue;StandardBind("aot/FunctionMapValues",name,sig.Substring(at),b.Value);}
            StandardBind("aot/FunctionMapSet","equals","(Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(r.SequenceEquals(s,a[0],true)?1:0)));StandardBind("aot/FunctionMapSet","hashCode","()I",(r,s,a)=>Done(JValue.I(r.SequenceHash(s,true))));
            StandardBind("aot/FunctionMapValues","iterator","()Ljava/util/Iterator;",(r,s,a)=>{var v=(FunctionMapValues)r.HostPayload<JavaList>(s).Values;var it=r.InlineCall("java/util/Set","iterator","()Ljava/util/Iterator;",v.Map.Keys,Array.Empty<JValue>());return Done(JValue.R(r.HostObject("aot/FunctionMapIterator",new FunctionMapIterator(v,it))));});
            foreach(string op in new[]{"hasNext","next","remove"})StandardBind("aot/FunctionMapIterator",op,op=="hasNext"?"()Z":op=="next"?"()Ljava/lang/Object;":"()V",(r,s,a)=>{var it=r.HostPayload<FunctionMapIterator>(s);var value=r.InlineCall("java/util/Iterator",op,op=="hasNext"?"()Z":op=="next"?"()Ljava/lang/Object;":"()V",it.Iterator,Array.Empty<JValue>());return Done(op=="next"?it.View.ForKey(value):value);});
            StandardBind("com/google/common/collect/Maps","asMap","(Ljava/util/Set;Lcom/google/common/base/Function;)Ljava/util/Map;",(r,s,a)=>{r.NonNull(a[0]);r.NonNull(a[1]);return Done(JValue.R(r.HostObject(type,new FunctionMap(a[0],a[1]))));});
            StandardBind("com/google/common/collect/Maps","transformValues","(Ljava/util/Map;Lcom/google/common/base/Function;)Ljava/util/Map;",(r,s,a)=>{r.NonNull(a[1]);var keys=r.InlineCall("java/util/Map","keySet","()Ljava/util/Set;",a[0],Array.Empty<JValue>());return Done(JValue.R(r.HostObject(type,new FunctionMap(keys,a[1]){Source=a[0]})));});
            foreach(string op in new[]{"size","isEmpty","clear"})StandardBind(type,op,op=="size"?"()I":op=="isEmpty"?"()Z":"()V",(r,s,a)=>Done(r.InlineCall("java/util/Set",op,op=="size"?"()I":op=="isEmpty"?"()Z":"()V",r.HostPayload<FunctionMap>(s).Keys,Array.Empty<JValue>())));
            StandardBind(type,"containsKey","(Ljava/lang/Object;)Z",(r,s,a)=>Done(r.InlineCall("java/util/Set","contains","(Ljava/lang/Object;)Z",r.HostPayload<FunctionMap>(s).Keys,a)));
            foreach(string op in new[]{"get","remove"})StandardBind(type,op,"(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var m=r.HostPayload<FunctionMap>(s);if(r.InlineCall("java/util/Set","contains","(Ljava/lang/Object;)Z",m.Keys,a).Int==0)return Done(default);var v=r.FunctionValue(m,a[0]);if(op=="remove")r.InlineCall("java/util/Set","remove","(Ljava/lang/Object;)Z",m.Keys,a);return Done(v);});
            StandardBind(type,"put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>throw r.Fault("java/lang/UnsupportedOperationException"));
            foreach(string op in new[]{"keySet","entrySet","values"})StandardBind(type,op,op=="values"?"()Ljava/util/Collection;":"()Ljava/util/Set;",(r,s,a)=>{var m=r.HostPayload<FunctionMap>(s);var keys=r.NonNull(m.Keys).Payload as JavaList;return Done(JValue.R(r.HostObject(op=="values"?"aot/FunctionMapValues":"aot/FunctionMapSet",new JavaList{Storage=new ListStorage{Values=new FunctionMapValues(r,m,op),ExternalVersion=keys==null?null:()=>keys.Version}})));});
        }
        private sealed class FunctionMapValues:IList<JValue>
        {
            private readonly JRuntime rt;private readonly FunctionMap map;private readonly string kind;internal FunctionMapValues(JRuntime r,FunctionMap m,string k){rt=r;map=m;kind=k;}
            internal FunctionMap Map=>map;
            internal JValue ForKey(JValue key){if(kind=="keySet")return key;var value=rt.FunctionValue(map,key);return kind=="values"?value:JValue.R(rt.HostObject("aot/MapEntry",new KeyValuePair<JValue,JValue>(key,value)));}
            public int Count=>rt.ListItems(map.Keys).Length;public bool IsReadOnly=>false;
            public JValue this[int i]{get=>ForKey(rt.ListItems(map.Keys)[i]);set=>throw rt.Fault("java/lang/UnsupportedOperationException");}
            public void Add(JValue v)=>throw rt.Fault("java/lang/UnsupportedOperationException");public void Insert(int i,JValue v)=>Add(v);public void RemoveAt(int i)=>rt.InlineCall("java/util/Set","remove","(Ljava/lang/Object;)Z",map.Keys,new[]{rt.ListItems(map.Keys)[i]});public void Clear()=>rt.InlineCall("java/util/Set","clear","()V",map.Keys,Array.Empty<JValue>());public int IndexOf(JValue v){for(int i=0;i<Count;i++)if(rt.NativeEqual(this[i],v))return i;return -1;}public bool Contains(JValue v)=>IndexOf(v)>=0;public bool Remove(JValue v){int i=IndexOf(v);if(i<0)return false;RemoveAt(i);return true;}public void CopyTo(JValue[] a,int at){foreach(var v in this)a[at++]=v;}public IEnumerator<JValue> GetEnumerator(){for(int i=0;i<Count;i++)yield return this[i];}IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        }
    }
}

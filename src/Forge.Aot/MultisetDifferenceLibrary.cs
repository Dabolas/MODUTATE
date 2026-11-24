using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class MultisetDifference
        {internal readonly JValue Left,Right;internal MultisetDifference(JValue left,JValue right){Left=left;Right=right;}}
        private int DifferenceCount(MultisetDifference difference,JValue key)=>Math.Max(0,InlineCall("com/google/common/collect/Multiset","count","(Ljava/lang/Object;)I",difference.Left,new[]{key}).Int-InlineCall("com/google/common/collect/Multiset","count","(Ljava/lang/Object;)I",difference.Right,new[]{key}).Int);
        private JValue[] DifferenceKeys(MultisetDifference difference)=>ListItems(InlineCall("com/google/common/collect/Multiset","elementSet","()Ljava/util/Set;",difference.Left,Array.Empty<JValue>())).Where(key=>DifferenceCount(difference,key)>0).ToArray();
        private sealed class DifferenceValues:IList<JValue>
        {
            private readonly JRuntime rt;private readonly MultisetDifference difference;private readonly string kind;
            internal DifferenceValues(JRuntime runtime,MultisetDifference value,string mode){rt=runtime;difference=value;kind=mode;}
            public int Count{get{var keys=rt.DifferenceKeys(difference);return kind=="values"?(int)Math.Min(int.MaxValue,keys.Sum(key=>(long)rt.DifferenceCount(difference,key))):keys.Length;}}
            public bool IsReadOnly=>true;
            public JValue this[int index]{get{if(index<0)throw rt.Fault("java/lang/IndexOutOfBoundsException");foreach(var key in rt.DifferenceKeys(difference)){int count=rt.DifferenceCount(difference,key);if(kind=="values"){if(index<count)return key;index-=count;}else if(index--==0)return kind=="keys"?key:JValue.R(rt.HostObject("aot/ImmutableMultisetEntry",new JavaPair(key,JValue.I(count))));}throw rt.Fault("java/lang/IndexOutOfBoundsException");}set=>throw rt.Fault("java/lang/UnsupportedOperationException");}
            public int IndexOf(JValue v){for(int i=0;i<Count;i++)if(rt.NativeEqual(this[i],v))return i;return -1;}public bool Contains(JValue v)=>IndexOf(v)>=0;
            public void Add(JValue v)=>throw rt.Fault("java/lang/UnsupportedOperationException");public void Insert(int i,JValue v)=>Add(v);public void Clear()=>throw rt.Fault("java/lang/UnsupportedOperationException");public void RemoveAt(int i)=>Clear();public bool Remove(JValue v)=>throw rt.Fault("java/lang/UnsupportedOperationException");
            public void CopyTo(JValue[] a,int at){foreach(var value in this)a[at++]=value;}public IEnumerator<JValue> GetEnumerator(){foreach(var key in rt.DifferenceKeys(difference)){int count=rt.DifferenceCount(difference,key);if(kind=="values"){for(int i=0;i<count;i++)yield return key;}else yield return kind=="keys"?key:JValue.R(rt.HostObject("aot/ImmutableMultisetEntry",new JavaPair(key,JValue.I(count))));}}IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        }
        private void InstallMultisetDifference()
        {
            const string type="aot/MultisetDifference",entry="aot/ImmutableMultisetEntry";
            NativeClass(type,"java/lang/Object","com/google/common/collect/Multiset");NativeClass(entry,"java/lang/Object","com/google/common/collect/Multiset$Entry");
            StandardBind(entry,"getElement","()Ljava/lang/Object;",(r,s,a)=>Done(r.HostPayload<JavaPair>(s).Left));
            StandardBind(entry,"getCount","()I",(r,s,a)=>Done(r.HostPayload<JavaPair>(s).Right));
            StandardBind("com/google/common/collect/Multisets","difference","(Lcom/google/common/collect/Multiset;Lcom/google/common/collect/Multiset;)Lcom/google/common/collect/Multiset;",(r,s,a)=>{r.NonNull(a[0]);r.NonNull(a[1]);return Done(JValue.R(r.HostObject(type,new MultisetDifference(a[0],a[1]))));});
            StandardBind(type,"count","(Ljava/lang/Object;)I",(r,s,a)=>Done(JValue.I(r.DifferenceCount(r.HostPayload<MultisetDifference>(s),a[0]))));
            StandardBind(type,"contains","(Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(r.DifferenceCount(r.HostPayload<MultisetDifference>(s),a[0])>0?1:0)));
            StandardBind(type,"isEmpty","()Z",(r,s,a)=>Done(JValue.I(r.DifferenceKeys(r.HostPayload<MultisetDifference>(s)).Length==0?1:0)));
            StandardBind(type,"size","()I",(r,s,a)=>Done(JValue.I(new DifferenceValues(r,r.HostPayload<MultisetDifference>(s),"values").Count)));
            StandardBind(type,"iterator","()Ljava/util/Iterator;",(r,s,a)=>Done(JValue.R(r.HostObject("aot/Iterator",new JavaIterator(new JavaList{Immutable=true,Storage=new ListStorage{Values=new DifferenceValues(r,r.HostPayload<MultisetDifference>(s),"values")}})))));
            foreach(string method in new[]{"elementSet","entrySet"})StandardBind(type,method,"()Ljava/util/Set;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/HashSet",new JavaList{Immutable=true,Unique=true,Storage=new ListStorage{Values=new DifferenceValues(r,r.HostPayload<MultisetDifference>(s),method=="elementSet"?"keys":"entries")}}))));
            foreach(var operation in new[]{("add","(Ljava/lang/Object;)Z"),("add","(Ljava/lang/Object;I)I"),("remove","(Ljava/lang/Object;)Z"),("remove","(Ljava/lang/Object;I)I"),("setCount","(Ljava/lang/Object;I)I"),("clear","()V")})StandardBind(type,operation.Item1,operation.Item2,(r,s,a)=>throw r.Fault("java/lang/UnsupportedOperationException"));
        }
    }
}

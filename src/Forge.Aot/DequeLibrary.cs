using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private void InstallDeques()
        {
            const string blocking="java/util/concurrent/LinkedBlockingDeque";
            NativeClass(blocking,"java/util/AbstractCollection","java/util/Deque","java/util/Queue");
            StandardBind(blocking,"iterator","()Ljava/util/Iterator;",(r,s,a)=>Done(r.WeakDequeIterator(s,false)));
            StandardBind(blocking,"<init>","()V",(r,s,a)=>{var o=r.NonNull(s);o.Payload=new JavaList();o.HostStorage=true;return Done();});
            foreach(string owner in new[]{"java/util/Deque","java/util/Queue","java/util/ArrayDeque","java/util/LinkedList",blocking})
            {
                foreach(string operation in new[]{"push","addFirst","addLast","add","offer","offerLast","offerFirst"})
                {
                    bool returns=operation=="add"||operation.StartsWith("offer",StringComparison.Ordinal),first=operation=="push"||operation.EndsWith("First",StringComparison.Ordinal);
                    StandardBind(owner,operation,"(Ljava/lang/Object;)"+(returns?"Z":"V"),(r,s,a)=>{var list=r.HostPayload<JavaList>(s);lock(list.Storage){r.Mutable(list);if(r.NonNull(s).ClassName!="java/util/LinkedList")r.NonNull(a[0]);if(first)list.Values.Insert(0,a[0]);else list.Values.Add(a[0]);list.Version++;return Done(returns?JValue.I(1):default);}});
                }
                foreach(string operation in new[]{"peek","peekFirst","peekLast","poll","pollFirst","pollLast","pop","removeFirst","removeLast","remove","getFirst","getLast"})
                {
                    bool last=operation.EndsWith("Last",StringComparison.Ordinal),remove=operation.StartsWith("poll",StringComparison.Ordinal)||operation.StartsWith("remove",StringComparison.Ordinal)||operation=="pop",nullable=operation.StartsWith("peek",StringComparison.Ordinal)||operation.StartsWith("poll",StringComparison.Ordinal);
                    StandardBind(owner,operation,"()Ljava/lang/Object;",(r,s,a)=>{var list=r.HostPayload<JavaList>(s);lock(list.Storage){if(list.Values.Count==0){if(nullable)return Done(JValue.R(null));throw r.Fault("java/util/NoSuchElementException");}int at=last?list.Values.Count-1:0;var value=list.Values[at];if(remove){r.Mutable(list);list.Values.RemoveAt(at);list.Version++;}return Done(value);}});
                }
                StandardBind(owner,"descendingIterator","()Ljava/util/Iterator;",(r,s,a)=>{var list=r.HostPayload<JavaList>(s);if(r.NonNull(s).ClassName==blocking)return Done(r.WeakDequeIterator(s,true));return Done(JValue.R(r.HostObject("aot/Iterator",new JavaIterator(list){At=list.Values.Count-1,Reverse=true})));});
            }
            // Iterators use a stable, write-through snapshot; blocking take/put remain explicit gaps.
        }
        private JValue WeakDequeIterator(JValue deque,bool reverse){var list=HostPayload<JavaList>(deque);lock(list.Storage){var snapshot=reverse?list.Values.Reverse().ToArray():list.Values.ToArray();return JValue.R(HostObject("aot/Iterator",new JavaIterator(new JavaList{Storage=new ListStorage{Values=new WeakDequeValues(this,list,snapshot)}})));}}
        private sealed class WeakDequeValues:IList<JValue>
        {
            private readonly JRuntime rt;private readonly JavaList backing;private readonly List<JValue> values;internal WeakDequeValues(JRuntime r,JavaList b,JValue[] v){rt=r;backing=b;values=new List<JValue>(v);}
            public int Count=>values.Count;public bool IsReadOnly=>false;public JValue this[int i]{get=>values[i];set=>throw rt.Fault("java/lang/UnsupportedOperationException");}
            public void RemoveAt(int i){lock(backing.Storage){for(int j=0;j<backing.Values.Count;j++)if(ReferenceEquals(backing.Values[j].Reference,values[i].Reference)){backing.Values.RemoveAt(j);backing.Version++;break;}}values.RemoveAt(i);}public void Clear(){while(Count>0)RemoveAt(0);}public void Add(JValue v)=>throw rt.Fault("java/lang/UnsupportedOperationException");public void Insert(int i,JValue v)=>Add(v);public int IndexOf(JValue v)=>values.IndexOf(v);public bool Contains(JValue v)=>values.Contains(v);public bool Remove(JValue v){int i=IndexOf(v);if(i<0)return false;RemoveAt(i);return true;}public void CopyTo(JValue[] a,int i)=>values.CopyTo(a,i);public IEnumerator<JValue> GetEnumerator()=>values.GetEnumerator();IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        }
    }
}

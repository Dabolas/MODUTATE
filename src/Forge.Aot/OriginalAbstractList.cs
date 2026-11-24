using System;
using System.Collections;
using System.Collections.Generic;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        // AbstractList owns no element array; inherited algorithms must call the subclass.
        private sealed class OriginalAbstractList:IList<JValue>
        {
            private readonly JRuntime rt;private readonly JValue owner;
            internal OriginalAbstractList(JRuntime r,JValue o){rt=r;owner=o;}
            private JValue Call(string name,string descriptor,params JValue[] args){var method=rt.Resolve(rt.NonNull(owner).ClassName,name,descriptor);if(method?.Body==null)throw rt.Fault("java/lang/UnsupportedOperationException");return rt.InlineCall(method.Owner,name,descriptor,owner,args);}
            public int Count=>Call("size","()I").Int;public bool IsReadOnly=>false;
            public JValue this[int i]{get=>Call("get","(I)Ljava/lang/Object;",JValue.I(i));set=>Call("set","(ILjava/lang/Object;)Ljava/lang/Object;",JValue.I(i),value);}
            public void Add(JValue value)=>Insert(Count,value);public void Insert(int i,JValue value)=>Call("add","(ILjava/lang/Object;)V",JValue.I(i),value);public void RemoveAt(int i)=>Call("remove","(I)Ljava/lang/Object;",JValue.I(i));public void Clear(){while(Count>0)RemoveAt(Count-1);}
            public int IndexOf(JValue v){for(int i=0;i<Count;i++)if(rt.NativeEqual(this[i],v))return i;return -1;}public bool Contains(JValue v)=>IndexOf(v)>=0;public bool Remove(JValue v){int i=IndexOf(v);if(i<0)return false;RemoveAt(i);return true;}public void CopyTo(JValue[] a,int at){foreach(var v in this)a[at++]=v;}public IEnumerator<JValue> GetEnumerator(){for(int i=0;i<Count;i++)yield return this[i];}IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        }
    }
}

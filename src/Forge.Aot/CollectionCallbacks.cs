using System;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class MemoizedSupplier {internal JValue Supplier,Value;internal bool Computed;}
        private void InstallCollectionCallbacks()
        {
            StandardBind("com/google/common/collect/Iterables","getLast","(Ljava/lang/Iterable;)Ljava/lang/Object;",(r,self,args)=>{
                var iterator=r.InlineCall("java/lang/Iterable","iterator","()Ljava/util/Iterator;",args[0],Array.Empty<JValue>());
                JValue last;
                do { last=r.InlineCall("java/util/Iterator","next","()Ljava/lang/Object;",iterator,Array.Empty<JValue>()); }
                while(r.InlineCall("java/util/Iterator","hasNext","()Z",iterator,Array.Empty<JValue>()).Int!=0);
                return Done(last);
            });
            NativeClass("com/google/common/base/Supplier","java/lang/Object","java/util/function/Supplier");NativeClass("aot/MemoizedSupplier","java/lang/Object","com/google/common/base/Supplier","java/util/function/Supplier");
            StandardBind("com/google/common/base/Suppliers","memoize","(Lcom/google/common/base/Supplier;)Lcom/google/common/base/Supplier;",(r,s,a)=>{r.NonNull(a[0]);return Done(a[0].Reference!.Payload is MemoizedSupplier?a[0]:JValue.R(r.HostObject("aot/MemoizedSupplier",new MemoizedSupplier{Supplier=a[0]})));});
            StandardBind("aot/MemoizedSupplier","get","()Ljava/lang/Object;",(r,s,a)=>{var memo=r.HostPayload<MemoizedSupplier>(s);lock(memo){if(!memo.Computed){memo.Value=r.InlineCall("com/google/common/base/Supplier","get","()Ljava/lang/Object;",memo.Supplier,Array.Empty<JValue>());memo.Computed=true;}return Done(memo.Value);}});
            StandardBind("com/google/common/collect/Iterables","frequency","(Ljava/lang/Iterable;Ljava/lang/Object;)I",(r,s,a)=>{int count=0;foreach(var v in r.ListItems(a[0]))if(r.NativeEqual(a[1],v))count++;return Done(JValue.I(count));});
            StandardBind("com/google/common/collect/Iterables","isEmpty","(Ljava/lang/Iterable;)Z",(r,s,a)=>{if(r.NonNull(a[0]).Payload is JavaList list)return Done(JValue.I(list.Values.Count==0?1:0));var it=r.InlineCall("java/lang/Iterable","iterator","()Ljava/util/Iterator;",a[0],Array.Empty<JValue>());return Done(JValue.I(r.InlineCall("java/util/Iterator","hasNext","()Z",it,Array.Empty<JValue>()).Int==0?1:0));});
            StandardBind("com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var it=r.InlineCall("java/lang/Iterable","iterator","()Ljava/util/Iterator;",a[0],Array.Empty<JValue>());return Done(r.InlineCall("java/util/Iterator","hasNext","()Z",it,Array.Empty<JValue>()).Int==0?a[1]:r.InlineCall("java/util/Iterator","next","()Ljava/lang/Object;",it,Array.Empty<JValue>()));});
            foreach(string owner in new[]{"java/util/Collection","java/util/List","java/util/ArrayList","java/util/Set","java/util/HashSet","java/util/LinkedHashSet"})StandardBind(owner,"removeIf","(Ljava/util/function/Predicate;)Z",(r,s,a)=>
            {
                r.NonNull(a[0]);var list=r.HostPayload<JavaList>(s);r.Mutable(list);int index=0,version=list.Version;bool changed=false;
                // ArrayList's bulk operation is atomic on predicate failure; other collections
                // use the interface iterator algorithm and retain successful earlier removals.
                bool bulk=r.NonNull(s).ClassName=="java/util/ArrayList";var remove=new System.Collections.Generic.List<int>();
                var method=new JMethod(-108,"java/lang/Object","<collection-removeIf>","()Z",8,0,3,Array.Empty<JHandler>(),(t,f)=>
                {
                    if(!t.Tick())return JStep.Yield;if(list.Version!=version)throw t.Fault("java/util/ConcurrentModificationException");
                    if(f.Pc==2)return t.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",1);
                    if(f.Pc==1){if(f.Pop().Int!=0){changed=true;if(bulk){remove.Add(index);index++;}else{list.Values.RemoveAt(index);list.Version++;version=list.Version;}}else index++;f.Pc=0;}
                    if(index==list.Values.Count){if(bulk&&changed){for(int n=remove.Count-1;n>=0;n--)list.Values.RemoveAt(remove[n]);list.Version++;}return JStep.Return(JValue.I(changed?1:0));}
                    f.Push(a[0]);f.Push(list.Values[index]);f.Pc=2;return JStep.Continue;
                });return JHostResult.Schedule(new JFrame(method,default,Array.Empty<JValue>()));
            });
        }
    }
}

using System;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private void InstallTreeSets()
        {
            NativeClass("java/util/TreeSet","java/util/AbstractCollection","java/util/Set");
            StandardBind("com/google/common/collect/Sets","newTreeSet","()Ljava/util/TreeSet;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/TreeSet",new JavaList{Sorted=true,Unique=true}))));
            foreach(string descriptor in new[]{"()V","(Ljava/util/Comparator;)V"})StandardBind("java/util/TreeSet","<init>",descriptor,(r,s,a)=>{var obj=r.NonNull(s);obj.Payload=new JavaList{Sorted=true,Unique=true,Comparator=a.Length==0?JValue.R(null):a[0]};obj.HostStorage=true;return Done();});
            foreach(string operation in new[]{"add","contains","remove"})StandardBind("java/util/TreeSet",operation,"(Ljava/lang/Object;)Z",(r,s,a)=>r.TreeOperation(s,a[0],operation));
            StandardBind("java/util/TreeSet","addAll","(Ljava/util/Collection;)Z",(r,s,a)=>r.CollectIterable(a[0],(t,values)=>{t.Mutable(t.HostPayload<JavaList>(s),false);bool changed=false;foreach(var value in values)changed|=t.InlineCall("java/util/TreeSet","add","(Ljava/lang/Object;)Z",s,new[]{value}).Int!=0;return JValue.I(changed?1:0);}));
        }
        private JHostResult TreeOperation(JValue receiver,JValue value,string operation)
        {
            var set=HostPayload<JavaList>(receiver);if(operation!="contains")Mutable(set);int index=0,version=set.Version;
            var method=new JMethod(-105,"java/lang/Object","<tree-search>","()Z",8,0,4,Array.Empty<JHandler>(),(r,f)=>
            {
                if(!r.Tick())return JStep.Yield;if(set.Version!=version)throw r.Fault("java/util/ConcurrentModificationException");
                if(f.Pc==2)return r.Call(f,"java/util/Comparator","compare","(Ljava/lang/Object;Ljava/lang/Object;)I","invokeinterface",1);
                if(f.Pc==1)
                {
                    int order=f.Pop().Int;
                    if(set.Values.Count==0||order<0||index>=set.Values.Count){if(operation=="add"){set.Values.Insert(index,value);set.Version++;return JStep.Return(JValue.I(1));}return JStep.Return(JValue.I(0));}
                    if(order==0){if(operation=="remove"){set.Values.RemoveAt(index);set.Version++;}return JStep.Return(JValue.I(operation=="add"?0:1));}
                    index++;if(index==set.Values.Count){if(operation=="add"){set.Values.Add(value);set.Version++;return JStep.Return(JValue.I(1));}return JStep.Return(JValue.I(0));}f.Pc=0;
                }
                var other=set.Values.Count==0?value:set.Values[index];
                if(set.Comparator.Reference==null){r.NonNull(value);f.Push(JValue.I(r.CompareNative(value,other)));f.Pc=1;return JStep.Continue;}
                f.Push(set.Comparator);f.Push(value);f.Push(other);f.Pc=2;return JStep.Continue;
            });return JHostResult.Schedule(new JFrame(method,default,Array.Empty<JValue>()));
        }
    }
}

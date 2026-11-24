using System;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class CombinedPredicate {internal JValue Left,Right;internal string Mode="";}
        private void InstallPredicates()
        {
            const string iface="java/util/function/Predicate",impl="aot/CombinedPredicate";NativeClass(impl,"java/lang/Object",iface);
            foreach(string mode in new[]{"and","or"})StandardBind(iface,mode,"(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;",(r,s,a)=>{r.NonNull(a[0]);return Done(JValue.R(r.HostObject(impl,new CombinedPredicate{Left=s,Right=a[0],Mode=mode})));});
            StandardBind(iface,"negate","()Ljava/util/function/Predicate;",(r,s,a)=>Done(JValue.R(r.HostObject(impl,new CombinedPredicate{Left=s,Mode="not"}))));
            StandardBind(iface,"not","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;",(r,s,a)=>{r.NonNull(a[0]);return Done(JValue.R(r.HostObject(impl,new CombinedPredicate{Left=a[0],Mode="not"})));});
            StandardBind(iface,"isEqual","(Ljava/lang/Object;)Ljava/util/function/Predicate;",(r,s,a)=>Done(JValue.R(r.HostObject(impl,new CombinedPredicate{Left=a[0],Mode="equal"}))));
            StandardBind(impl,"test","(Ljava/lang/Object;)Z",(r,s,a)=>
            {
                var predicate=r.HostPayload<CombinedPredicate>(s);if(predicate.Mode=="equal")return Done(JValue.I(r.NativeEqual(predicate.Left,a[0])?1:0));
                var method=new JMethod(-107,"java/lang/Object","<predicate-short-circuit>","()Z",8,0,3,Array.Empty<JHandler>(),(t,f)=>
                {if(!t.Tick())return JStep.Yield;if(f.Pc==0){f.Push(predicate.Left);f.Push(a[0]);f.Pc=10;}if(f.Pc==10)return t.Call(f,iface,"test","(Ljava/lang/Object;)Z","invokeinterface",1);if(f.Pc==1){int answer=f.Pop().Int;if(predicate.Mode=="not")return JStep.Return(JValue.I(answer==0?1:0));if(predicate.Mode=="and"&&answer==0||predicate.Mode=="or"&&answer!=0)return JStep.Return(JValue.I(answer));f.Push(predicate.Right);f.Push(a[0]);f.Pc=20;}if(f.Pc==20)return t.Call(f,iface,"test","(Ljava/lang/Object;)Z","invokeinterface",2);return JStep.Return(f.Pop());});return JHostResult.Schedule(new JFrame(method,default,Array.Empty<JValue>()));
            });
            StandardBind("java/util/Objects","equals","(Ljava/lang/Object;Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(r.NativeEqual(a[0],a[1])?1:0)));
        }
    }
}

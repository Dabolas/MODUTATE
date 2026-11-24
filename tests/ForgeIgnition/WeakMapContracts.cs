using Planeswalker.ForgeAot;
using System.Runtime.CompilerServices;

public static class WeakMapContracts
{
    private static JValue Call(JRuntime r,JValue value,string name,string desc,params JValue[] args)=>r.InvokeSynchronous(value.Reference!.ClassName,name,desc,value,args);
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static WeakReference<JObject> AddTransient(JRuntime r,JValue map)
    {var key=r.Allocate("java/lang/Object");Call(r,map,"put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",JValue.R(key),JValue.R(r.String("finished game")));return new(key);}
    public static void Run(JRuntime r,Action<bool,string> check)
    {
        var map=JValue.R(r.Allocate("java/util/WeakHashMap"));Call(r,map,"<init>","()V");
        var wrapper=r.InvokeSynchronous("java/util/Collections","synchronizedMap","(Ljava/util/Map;)Ljava/util/Map;",default,[map],"invokestatic");
        var key=JValue.R(r.Allocate("java/lang/Object"));Call(r,wrapper,"put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",key,r.BoxInt(7));
        check(r.UnboxInt(Call(r,map,"get","(Ljava/lang/Object;)Ljava/lang/Object;",key))==7,"Synchronized weak map delegates to the same backing map");
        const string function="contract/WeakMapFactory";r.Program.Add(new(function,"java/lang/Object",["java/util/function/Function"],1));var factory=JValue.R(r.Allocate(function));int calls=0;r.Bind(function,"apply","(Ljava/lang/Object;)Ljava/lang/Object;",(rt,s,a)=>{calls++;return JHostResult.Complete(rt.BoxInt(9));});
        var other=JValue.R(r.Allocate("java/lang/Object"));for(int i=0;i<2;i++)Call(r,wrapper,"computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;",other,factory);
        check(calls==1&&r.UnboxInt(Call(r,wrapper,"get","(Ljava/lang/Object;)Ljava/lang/Object;",other))==9,"Per-game token pin factory runs once for a live game");
        Call(r,wrapper,"clear","()V");var weak=AddTransient(r,wrapper);GC.Collect();GC.WaitForPendingFinalizers();GC.Collect();
        check(!weak.TryGetTarget(out _)&&Call(r,map,"size","()I").Int==0,"Token cache does not retain finished game keys");
        GC.KeepAlive(key);GC.KeepAlive(other);
        int[] Draw(long seed){var runtime=new JRuntime(r.Program);runtime.SetDeterministicAmbientSeed(seed);var local=runtime.InvokeSynchronous("java/util/concurrent/ThreadLocalRandom","current","()Ljava/util/concurrent/ThreadLocalRandom;",default,[],"invokestatic");return Enumerable.Range(0,32).Select(_=>Call(runtime,local,"nextInt","(I)I",JValue.I(17)).Int).ToArray();}
        var draws=Draw(42);check(draws.SequenceEqual(Draw(42))&&draws.Distinct().Count()>1&&draws.All(n=>n>=0&&n<17),"Cosmetic thread RNG is reproducible and stays within offered art bounds");
    }
}

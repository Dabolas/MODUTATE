using Planeswalker.ForgeAot;

public static class MultimapIndexContracts
{
    public static void Run(JRuntime r,Action<bool,string> check)
    {
        JValue S(string s)=>JValue.R(r.String(s));JValue Call(JValue v,string name,string desc,params JValue[] args)=>r.InvokeSynchronous(v.Reference!.ClassName,name,desc,v,args);
        const string function="contracts/IndexFunction";r.Program.Add(new(function,"java/lang/Object",["com/google/common/base/Function"],1));
        var fn=JValue.R(r.HostObject(function,new object()));int calls=0;bool nullKey=false;
        r.Bind(function,"apply","(Ljava/lang/Object;)Ljava/lang/Object;",(rt,s,a)=>{calls++;return JHostResult.Complete(nullKey?JValue.R(null):S(rt.StringValue(a[0])[..1]));});
        var source=r.ListOf([S("b1"),S("a1"),S("b2"),S("a1")]);
        var map=r.InvokeSynchronous("com/google/common/collect/Multimaps","index","(Ljava/lang/Iterable;Lcom/google/common/base/Function;)Lcom/google/common/collect/ImmutableListMultimap;",default,[source,fn],"invokestatic");
        check(calls==4&&r.ListItems(Call(map,"keySet","()Ljava/util/Set;")).Select(r.StringValue).SequenceEqual(["b","a"]),"Multimaps.index evaluates every key function once and preserves first-key encounter order");
        var values=Call(map,"get","(Ljava/lang/Object;)Ljava/util/Collection;",S("a"));check(r.ListItems(values).Select(r.StringValue).SequenceEqual(["a1","a1"]),"Indexed lists preserve order and duplicate values");
        check(r.ListItems(Call(map,"values","()Ljava/util/Collection;")).Select(r.StringValue).SequenceEqual(["b1","b2","a1","a1"]),"Immutable multimap iteration groups values in key order");
        Call(source,"clear","()V");check(Call(map,"size","()I").Int==4,"Index is a snapshot independent of subsequent source mutation");
        foreach(var mutate in new Action[]{()=>Call(map,"put","(Ljava/lang/Object;Ljava/lang/Object;)Z",S("c"),S("c1")),()=>Call(values,"clear","()V"),()=>Call(Call(map,"asMap","()Ljava/util/Map;"),"clear","()V")})
        {try{mutate();check(false,"Immutable index must reject mutation");}catch(JavaFault e){check(e.Value.ClassName=="java/lang/UnsupportedOperationException","Immutable index and nested views reject mutation");}}
        nullKey=true;
        try{r.InvokeSynchronous("com/google/common/collect/Multimaps","index","(Ljava/lang/Iterable;Lcom/google/common/base/Function;)Lcom/google/common/collect/ImmutableListMultimap;",default,[r.ListOf([S("x")]),fn],"invokestatic");check(false,"Null index key must fail");}catch(JavaFault e){check(e.Value.ClassName=="java/lang/NullPointerException","Index rejects null keys from the classifier");}
        JValue Set(params JValue[] values)=>r.InvokeSynchronous("java/util/Set","of","("+string.Concat(Enumerable.Repeat("Ljava/lang/Object;",values.Length))+")Ljava/util/Set;",default,values,"invokestatic");
        var singleton=Set(S("Library"));check(Call(singleton,"size","()I").Int==1&&Call(singleton,"contains","(Ljava/lang/Object;)Z",S("Library")).Int!=0,"DelayedReveal's Set.of creates its actual immutable zone set");
        foreach(var item in new[]{(Body:(Action)(()=>Set(JValue.R(null))),Type:"java/lang/NullPointerException"),(Body:(Action)(()=>Set(S("x"),S("x"))),Type:"java/lang/IllegalArgumentException"),(Body:(Action)(()=>Call(singleton,"clear","()V")),Type:"java/lang/UnsupportedOperationException")})
        {try{item.Body();check(false,"Set.of must enforce its contract");}catch(JavaFault e){check(e.Value.ClassName==item.Type,"Set.of rejects null/duplicate elements and mutation: "+item.Type);}}
    }
}

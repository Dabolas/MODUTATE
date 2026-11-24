using Planeswalker.ForgeAot;

public static class StreamFamilyContracts
{
    public static void Run(JRuntime r,Action<bool,string> check)
    {
        JValue S(string text)=>JValue.R(r.String(text));
        JValue Call(JValue v,string name,string desc,params JValue[] args)=>r.InvokeSynchronous(v.Reference!.ClassName,name,desc,v,args);
        JValue Static(string owner,string name,string desc,params JValue[] args)=>r.InvokeSynchronous(owner,name,desc,default,args,"invokestatic");
        JValue Function(string name,string iface,string method,string signature,Func<JValue[],JValue> callback)
        {string type="contracts/Collector"+name;r.Program.Add(new(type,"java/lang/Object",[iface],1));r.Bind(type,method,signature,(rt,s,a)=>JHostResult.Complete(callback(a)));return JValue.R(r.HostObject(type,new object()));}
        int suppliers=0,accumulations=0,combinations=0,finishes=0;
        var supply=Function("Supplier","java/util/function/Supplier","get","()Ljava/lang/Object;",a=>{suppliers++;return r.ListOf([]);});
        var accumulate=Function("Accumulator","java/util/function/BiConsumer","accept","(Ljava/lang/Object;Ljava/lang/Object;)V",a=>{accumulations++;Call(a[0],"add","(Ljava/lang/Object;)Z",a[1]);return default;});
        var combine=Function("Combine","java/util/function/BinaryOperator","apply","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",a=>{combinations++;Call(a[0],"addAll","(Ljava/util/Collection;)Z",a[1]);return a[0];});
        var finish=Function("Finish","java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;",a=>{finishes++;return r.BoxInt(r.ListItems(a[0]).Length);});
        var flags=JValue.R(r.NewArray("Ljava/util/stream/Collector$Characteristics;",0));
        string prefix="(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;";
        var identity=Static("java/util/stream/Collector","of",prefix+"[Ljava/util/stream/Collector$Characteristics;)Ljava/util/stream/Collector;",supply,accumulate,combine,flags);
        var finished=Static("java/util/stream/Collector","of",prefix+"Ljava/util/function/Function;[Ljava/util/stream/Collector$Characteristics;)Ljava/util/stream/Collector;",supply,accumulate,combine,finish,flags);
        JValue Collect(JValue collector,params JValue[] values)=>Call(Call(r.ListOf(values),"stream","()Ljava/util/stream/Stream;"),"collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;",collector);
        check(r.ListItems(Collect(identity,S("a"),S("b"))).Select(r.StringValue).SequenceEqual(["a","b"]),"Collector.of identity finish retains encounter order");
        check(r.UnboxInt(Collect(finished,S("x"),S("y")))==2&&suppliers==2&&accumulations==4&&combinations==0&&finishes==1,"Sequential collectors invoke supplier/accumulator/finisher exactly, without unnecessary combiner calls");
        check(r.UnboxInt(Collect(finished))==0&&suppliers==3&&finishes==2,"Empty stream still supplies and finishes a fresh result");
        var characteristic=Call(identity,"characteristics","()Ljava/util/Set;");check(r.ListItems(characteristic).Select(r.InspectEnumName).SequenceEqual(["IDENTITY_FINISH"]),"Identity collector exposes immutable IDENTITY_FINISH characteristic");
        check(Call(Call(identity,"finisher","()Ljava/util/function/Function;"),"apply","(Ljava/lang/Object;)Ljava/lang/Object;",supply).Reference==supply.Reference,"Identity finisher returns exactly the same reference");
        var combined=Call(Call(identity,"combiner","()Ljava/util/function/BinaryOperator;"),"apply","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",r.ListOf([S("a")]),r.ListOf([S("b")]));check(r.ListItems(combined).Length==2&&combinations==1,"Collector exposes its real combination callback");
        var listCollector=Static("java/util/stream/Collectors","toCollection","(Ljava/util/function/Supplier;)Ljava/util/stream/Collector;",supply);check(r.ListItems(Collect(listCollector,S("a"),S("a"))).Length==2,"toCollection uses supplied collection and preserves its duplicate policy");
        var key=Function("Key","java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;",a=>S(r.StringValue(a[0])[..1]));
        var value=Function("Value","java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;",a=>a[0]);
        var mapCollector=Static("java/util/stream/Collectors","toMap","(Ljava/util/function/Function;Ljava/util/function/Function;)Ljava/util/stream/Collector;",key,value);
        var map=Collect(mapCollector,S("a1"),S("b1"));check(r.StringValue(Call(map,"get","(Ljava/lang/Object;)Ljava/lang/Object;",S("b")))=="b1","toMap applies key and value functions");
        try{Collect(mapCollector,S("a1"),S("a2"));check(false,"Duplicate key expected");}catch(JavaFault e){check(e.Value.ClassName=="java/lang/IllegalStateException","toMap rejects duplicate keys without a merger");}
        var merge=Function("Merge","java/util/function/BinaryOperator","apply","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",a=>S(r.StringValue(a[0])+"/"+r.StringValue(a[1])));
        var mapFactory=Function("MapFactory","java/util/function/Supplier","get","()Ljava/lang/Object;",a=>r.MapOf([]));
        var merged=Static("java/util/stream/Collectors","toMap","(Ljava/util/function/Function;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;Ljava/util/function/Supplier;)Ljava/util/stream/Collector;",key,value,merge,mapFactory);
        check(r.StringValue(Call(Collect(merged,S("a1"),S("a2")),"get","(Ljava/lang/Object;)Ljava/lang/Object;",S("a")))=="a1/a2","toMap uses merge function and supplied map");
        var predicate=Function("Predicate","java/util/function/Predicate","test","(Ljava/lang/Object;)Z",a=>JValue.I(r.StringValue(a[0]).StartsWith('a')?1:0));
        var count=Static("java/util/stream/Collectors","counting","()Ljava/util/stream/Collector;");var partition=Static("java/util/stream/Collectors","partitioningBy","(Ljava/util/function/Predicate;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;",predicate,count);
        JValue Bool(bool b)=>Static("java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;",JValue.I(b?1:0));
        var empty=Collect(partition);check(Call(empty,"size","()I").Int==2&&Call(Call(empty,"get","(Ljava/lang/Object;)Ljava/lang/Object;",Bool(true)),"longValue","()J").Long==0,"Empty partition has both true and false keys and finished empty downstream values");
        var divided=Collect(partition,S("a"),S("b"),S("a2"));check(Call(Call(divided,"get","(Ljava/lang/Object;)Ljava/lang/Object;",Bool(true)),"longValue","()J").Long==2,"Partition classifier routes each item into its own downstream accumulator");
        var ints=Function("Int","java/util/function/ToIntFunction","applyAsInt","(Ljava/lang/Object;)I",a=>JValue.I(r.UnboxInt(a[0])));
        var intStream=Call(Call(r.ListOf([r.BoxInt(2),r.BoxInt(2),r.BoxInt(-1)]),"stream","()Ljava/util/stream/Stream;"),"mapToInt","(Ljava/util/function/ToIntFunction;)Ljava/util/stream/IntStream;",ints);
        check(Call(Call(intStream,"distinct","()Ljava/util/stream/IntStream;"),"count","()J").Long==2,"IntStream distinct and count preserve primitive equality");
        int mapped=0;var longs=Function("Long","java/util/function/ToLongFunction","applyAsLong","(Ljava/lang/Object;)J",a=>{mapped++;return JValue.L(long.MaxValue-r.UnboxInt(a[0]));});
        var ls=Call(Call(r.ListOf([r.BoxInt(4),r.BoxInt(1)]),"stream","()Ljava/util/stream/Stream;"),"mapToLong","(Ljava/util/function/ToLongFunction;)Ljava/util/stream/LongStream;",longs);check(mapped==0,"mapToLong stays lazy");
        var maximum=Call(ls,"max","()Ljava/util/OptionalLong;");check(Call(maximum,"getAsLong","()J").Long==long.MaxValue-1&&mapped==2,"LongStream max keeps 64-bit precision and invokes mapper once per element");
        var none=Call(Call(Call(r.ListOf([]),"stream","()Ljava/util/stream/Stream;"),"mapToLong","(Ljava/util/function/ToLongFunction;)Ljava/util/stream/LongStream;",longs),"max","()Ljava/util/OptionalLong;");check(Call(none,"isPresent","()Z").Int==0&&Call(none,"orElse","(J)J",JValue.L(19)).Long==19,"Empty LongStream yields empty OptionalLong");
    }
}

using Planeswalker.ForgeAot;
using Planeswalker.ForgeConsole;

public static class ContractChecks
{
    public static JMethod CallEntry(string owner,string name,string descriptor,JValue receiver,JValue[] arguments,string kind="invokevirtual")
    {
        JDescriptor.Parameters(descriptor,out string returns);
        return new JMethod(-70,"java/lang/Object","<console-adapter-check>","()"+returns,8,1,arguments.Length+2,[],(r,f)=>
        {
            if(!r.Tick())return JStep.Yield;
            if(f.Pc==1)return returns=="V"?JStep.ReturnVoid:JStep.Return(f.Pop());
            if(f.Pc==0){if(kind!="invokestatic")f.Push(receiver);foreach(var value in arguments)f.Push(value);f.Pc=2;}
            return r.Call(f,owner,name,descriptor,kind,1);
        });
    }
    private static JValue Invoke(JRuntime rt,string owner,string name,string descriptor,JValue receiver,params JValue[] arguments)
        =>AotDamageBridge.Run(rt,CallEntry(owner,name,descriptor,receiver,arguments),default,[]);
    private static JValue Static(JRuntime rt,string owner,string name,string descriptor,params JValue[] arguments)
        =>AotDamageBridge.Run(rt,CallEntry(owner,name,descriptor,default,arguments,"invokestatic"),default,[]);
    public static string[] Run(JProgram program)
    {
        var checks=new List<string>();
        void Verify(bool condition,string name){if(!condition)throw new InvalidOperationException("Contract check failed: "+name);checks.Add(name);}
        var rt=new JRuntime(program);JValue S(string value)=>JValue.R(rt.String(value));
        var array=rt.NewArray("Ljava/lang/Object;",2);array.Items[0]=S("a");array.Items[1]=S("b");
        var view=Static(rt,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;",JValue.R(array));
        Invoke(rt,"java/util/List","set","(ILjava/lang/Object;)Ljava/lang/Object;",view,JValue.I(1),S("c"));
        Verify(rt.StringValue(array.Items[1])=="c","Arrays.asList set writes through to original array");
        array.Items[0]=S("z");Verify(rt.StringValue(Invoke(rt,"java/util/List","get","(I)Ljava/lang/Object;",view,JValue.I(0)))=="z","Arrays.asList observes array updates");
        try{Invoke(rt,"java/util/List","add","(Ljava/lang/Object;)Z",view,S("x"));throw new InvalidOperationException("Fixed list grew");}
        catch(JavaFault fault){Verify(fault.Value.ClassName=="java/lang/UnsupportedOperationException","Arrays.asList rejects resizing");}
        var list=rt.ListOf([S("x")]);var readOnly=Static(rt,"java/util/Collections","unmodifiableList","(Ljava/util/List;)Ljava/util/List;",list);
        Invoke(rt,"java/util/List","add","(Ljava/lang/Object;)Z",list,S("y"));Verify(rt.ListItems(readOnly).Length==2,"Unmodifiable list is a live view");
        try{Invoke(rt,"java/util/List","set","(ILjava/lang/Object;)Ljava/lang/Object;",readOnly,JValue.I(0),S("q"));throw new InvalidOperationException("Read-only list mutated");}
        catch(JavaFault fault){Verify(fault.Value.ClassName=="java/lang/UnsupportedOperationException","Unmodifiable list rejects set");}
        try{Invoke(rt,"java/util/List","get","(I)Ljava/lang/Object;",list,JValue.I(5));throw new InvalidOperationException("List overrun accepted");}
        catch(JavaFault fault){Verify(fault.Value.ClassName=="java/lang/IndexOutOfBoundsException","List bounds use Java exception");}
        var bytes=rt.NewArray("B",2);bytes.Items[0]=JValue.I(0);bytes.Items[1]=JValue.I(-1);
        var stream=JValue.R(rt.Allocate("java/io/ByteArrayInputStream"));Invoke(rt,"java/io/ByteArrayInputStream","<init>","([B)V",stream,JValue.R(bytes));
        Verify(Invoke(rt,"java/io/InputStream","read","()I",stream).Int==0,"Stream read distinguishes byte zero from EOF");
        Invoke(rt,"java/io/InputStream","close","()V",stream);
        Verify(Invoke(rt,"java/io/InputStream","read","()I",stream).Int==255,"ByteArrayInputStream close permits later reads");
        Verify(Invoke(rt,"java/io/InputStream","read","()I",stream).Int==-1,"Stream EOF is -1");
        Verify(Invoke(rt,"java/lang/String","indexOf","(I)I",S("x😀y"),JValue.I(0x1f600)).Int==1,"String indexOf supports supplementary code points");
        Verify(Invoke(rt,"java/lang/String","indexOf","(I)I",S("a"),JValue.I(-1)).Int==-1,"String indexOf rejects invalid code points");
        var pieces=Invoke(rt,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;",S("a,b,,"),S("(,)"));
        Verify(((JArray)pieces.Reference!).Items.Select(v=>rt.StringValue(v)).SequenceEqual(new[]{"a","b"}),"String split drops trailing empties and excludes captures");
        var copy=Invoke(rt,"java/lang/Object","clone","()Ljava/lang/Object;",JValue.R(bytes));
        ((JArray)copy.Reference!).Items[0]=JValue.I(9);Verify(bytes.Items[0].Int==0,"Array clone uses independent storage");
        var builder=JValue.R(rt.Allocate("java/lang/StringBuilder"));Invoke(rt,"java/lang/StringBuilder","<init>","()V",builder);
        Invoke(rt,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;",builder,JValue.I(42));
        Verify(rt.StringValue(Invoke(rt,"java/lang/StringBuilder","toString","()Ljava/lang/String;",builder))=="42","StringBuilder maps to System.Text");
        var key=Invoke(rt,"java/lang/String","substring","(I)Ljava/lang/String;",S("_same"),JValue.I(1));
        var map=rt.MapOf([new(S("same"),JValue.I(7))]);
        Verify(Invoke(rt,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;",map,key).Int==7,"Map uses Java string value equality");
        var keys=Invoke(rt,"java/util/Map","keySet","()Ljava/util/Set;",map);
        Invoke(rt,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",map,S("other"),JValue.I(8));
        Verify(rt.ListItems(keys).Length==2,"Map keySet remains live after new key");
        var bi=Static(rt,"com/google/common/collect/HashBiMap","create","()Lcom/google/common/collect/HashBiMap;");
        Invoke(rt,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",bi,S("left"),S("right"));
        var inverse=Invoke(rt,"com/google/common/collect/HashBiMap","inverse","()Lcom/google/common/collect/BiMap;",bi);
        Verify(rt.StringValue(Invoke(rt,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;",inverse,S("right")))=="left","BiMap inverse reflects original mapping");
        Verify(ReferenceEquals(Invoke(rt,"com/google/common/collect/HashBiMap","inverse","()Lcom/google/common/collect/BiMap;",inverse).Reference,bi.Reference),"BiMap inverse of inverse preserves identity");
        try{Invoke(rt,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",bi,S("another"),S("right"));throw new InvalidOperationException("Duplicate BiMap value accepted");}
        catch(JavaFault fault){Verify(fault.Value.ClassName=="java/lang/IllegalArgumentException","BiMap rejects duplicate value atomically");}
        var keysBefore=Invoke(rt,"java/util/Map","keySet","()Ljava/util/Set;",bi);Verify(rt.ListItems(keysBefore).Length==1,"Rejected BiMap put leaves original entries unchanged");
        var self=rt.ListOf([S("a"),S("b")]);Invoke(rt,"java/util/List","addAll","(Ljava/util/Collection;)Z",self,self);
        Verify(rt.ListItems(self).Select(rt.StringValue).SequenceEqual(new[]{"a","b","a","b"}),"List addAll handles self-source without invalidating enumeration");
        var concurrent=JValue.R(rt.Allocate("java/util/concurrent/ConcurrentHashMap"));Invoke(rt,"java/util/concurrent/ConcurrentHashMap","<init>","()V",concurrent);
        try{Invoke(rt,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",concurrent,S("x"),JValue.R(null));throw new InvalidOperationException("Concurrent map accepted null");}
        catch(JavaFault fault){Verify(fault.Value.ClassName=="java/lang/NullPointerException","ConcurrentHashMap rejects null values");}
        Verify(Invoke(rt,"java/util/Map","size","()I",concurrent).Int==0,"Rejected concurrent-map put leaves no entry");
        // Execute an actual PlayerController callback through the resumable runtime.
        var host=new HostMailbox();var callbackRt=new JRuntime(program);
        var adapter=new AotHostAdapter(callbackRt,host,new ConsoleNumberCodec(),0,()=>9);
        var controller=JValue.R(callbackRt.HostObject("forge/game/player/PlayerController",new object()));
        var entry=CallEntry("forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;II)I",controller,[JValue.R(null),JValue.R(callbackRt.String("X")),JValue.I(0),JValue.I(5)]);
        callbackRt.Start(entry,default,[]);Verify(adapter.Pump()==JRunState.Waiting,"Generated caller suspends at real PlayerController callback");
        var request=host.Pending!;Verify(!host.TryReply(new(request.Id,request.Revision,request.Seat,[],Number:6),out _),"Host rejects out-of-range X");
        Verify(!host.TryReply(new(request.Id,request.Revision,1,[],Number:3),out _),"Host rejects foreign-seat response");
        Verify(!host.TryReply(new(request.Id,8,request.Seat,[],Number:3),out _),"Host rejects stale revision");
        Verify(host.TryReply(new(request.Id,request.Revision,request.Seat,[],Number:3),out _),"Host accepts legal numeric response");
        Verify(adapter.Pump()==JRunState.Completed&&callbackRt.Result.Int==3,"Generated caller resumes with typed callback result");
        Verify(adapter.SuspendedCallbacks==112,"All abstract PlayerController methods have suspension transport");
        var pattern=Static(rt,"java/util/regex/Pattern","compile","(Ljava/lang/String;I)Ljava/util/regex/Pattern;",S("[a-z]+"),JValue.I(2));
        var matcher=Invoke(rt,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;",pattern,S("ABC"));
        Verify(Invoke(rt,"java/util/regex/Matcher","matches","()Z",matcher).Int==1,"ASCII case-insensitive regex matches uppercase range");
        Invoke(rt,"java/lang/StringBuilder","append","(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;",builder,S("abcd"),JValue.I(1),JValue.I(3));
        Verify(rt.StringValue(Invoke(rt,"java/lang/StringBuilder","toString","()Ljava/lang/String;",builder))=="42bc","StringBuilder appends requested half-open range");
        try{Static(rt,"java/util/List","of","(Ljava/lang/Object;)Ljava/util/List;",JValue.R(null));throw new InvalidOperationException("List.of accepted null");}
        catch(JavaFault fault){Verify(fault.Value.ClassName=="java/lang/NullPointerException","List.of rejects null members");}
        Verify(Invoke(rt,"java/lang/String","indexOf","(Ljava/lang/String;I)I",S("abc"),S(""),JValue.I(99)).Int==3,"String indexOf empty suffix clamps start to length");
        Verify(rt.StringValue(Invoke(rt,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",S("ab12"),S("([a-z]+)([0-9]+)"),S("$2-$1")))=="12-ab","replaceAll uses Java numeric replacement groups");
        try{Invoke(rt,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;",pattern,S("\u212a"));throw new InvalidOperationException("Unicode regex silently accepted");}
        catch(PortGap){checks.Add("ASCII regex rejects unimplemented Unicode folding");}
        return checks.ToArray();
    }
}

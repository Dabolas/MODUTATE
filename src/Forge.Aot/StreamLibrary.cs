using System;
using System.Collections.Generic;

namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class JavaStream
        {
            internal readonly Func<IEnumerable<JValue>> Source;
            internal readonly List<(bool Map,JValue Function)> Steps;
            internal bool Consumed;
            internal JavaStream(JValue[] source,List<(bool Map,JValue Function)>? steps=null):this(()=>source,steps){}
            internal JavaStream(Func<IEnumerable<JValue>> source,List<(bool Map,JValue Function)>? steps=null){Source=source;Steps=steps??new List<(bool,JValue)>();}
        }
        private sealed class JavaCollector
        {
            internal readonly bool Set;internal string Kind="items";internal JValue Classifier,MapFactory;internal JavaCollector? Downstream;
            internal string Delimiter="",Prefix="",Suffix="";
            internal JValue Supplier,Accumulator,Combiner,Finisher,ValueMapper,Characteristics;
            internal JavaCollector(bool set){Set=set;}
        }
        private void InstallStreams()
        {
            NativeClass("java/util/function/Predicate");NativeClass("java/lang/AutoCloseable");
            NativeClass("java/util/stream/BaseStream","java/lang/Object","java/lang/AutoCloseable");
            NativeClass("java/util/stream/Stream","java/lang/Object","java/util/stream/BaseStream");NativeClass("java/util/stream/Collector");
            foreach(string owner in new[]{"java/util/Collection","java/util/List","java/util/ArrayList","java/util/Set","java/util/HashSet","java/util/EnumSet"})StandardBind(owner,"stream","()Ljava/util/stream/Stream;",(r,s,a)=>Done(r.StreamOf(()=>r.StreamIterable(s))));
            StandardBind("java/util/Objects","nonNull","(Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(a[0].Reference!=null?1:0)));
            StandardBind("java/util/Arrays","stream","([Ljava/lang/Object;)Ljava/util/stream/Stream;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/stream/Stream",new JavaStream(r.ArrayObject(a[0]).Items)))));
            StandardBind("java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;",(r,s,a)=>
            {
                var stream=r.HostPayload<JavaStream>(s);if(stream.Consumed)throw r.Fault("java/lang/IllegalStateException");r.NonNull(a[0]);stream.Consumed=true;
                var steps=new List<(bool Map,JValue Function)>(stream.Steps){(false,a[0])};return Done(JValue.R(r.HostObject("java/util/stream/Stream",new JavaStream(stream.Source,steps))));
            });
            StandardBind("java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;",(r,s,a)=>
            {var stream=r.HostPayload<JavaStream>(s);if(stream.Consumed)throw r.Fault("java/lang/IllegalStateException");r.NonNull(a[0]);stream.Consumed=true;var steps=new List<(bool Map,JValue Function)>(stream.Steps){(true,a[0])};return Done(JValue.R(r.HostObject("java/util/stream/Stream",new JavaStream(stream.Source,steps))));});
            StandardBind("java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/stream/Collector",new JavaCollector(false)))));
            StandardBind("java/util/stream/Collectors","toSet","()Ljava/util/stream/Collector;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/stream/Collector",new JavaCollector(true)))));
        }
    }
}

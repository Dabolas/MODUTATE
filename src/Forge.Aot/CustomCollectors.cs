using System;
using System.Linq;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private void InstallCustomCollectors()
        {
            NativeClass("aot/CollectorIdentity","java/lang/Object","java/util/function/Function");
            StandardBind("aot/CollectorIdentity","apply","(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>Done(a[0]));
            const string characteristic="java/util/stream/Collector$Characteristics";
            NativeClass(characteristic,"java/lang/Enum");
            string[] names={"CONCURRENT","UNORDERED","IDENTITY_FINISH"};
            var constants=names.Select((name,index)=>{var value=Allocate(characteristic);value.Fields["java/lang/Enum.name:Ljava/lang/String;"]=JValue.R(String(name));value.Fields["java/lang/Enum.ordinal:I"]=JValue.I(index);BindStatic(characteristic,name,"L"+characteristic+";",()=>JValue.R(value));return JValue.R(value);}).ToArray();
            StandardBind(characteristic,"values","()[L"+characteristic+";",(r,s,a)=>{var result=r.NewArray("L"+characteristic+";",constants.Length);Array.Copy(constants,result.Items,constants.Length);return Done(JValue.R(result));});
            foreach(bool finish in new[]{false,true})
            StandardBind("java/util/stream/Collector","of","(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;"+(finish?"Ljava/util/function/Function;":"")+"[Ljava/util/stream/Collector$Characteristics;)Ljava/util/stream/Collector;",(r,s,a)=>
            {
                for(int i=0;i<(finish?4:3);i++)r.NonNull(a[i]);var flags=r.ArrayObject(a[a.Length-1]).Items.ToList();foreach(var flag in flags)r.NonNull(flag);
                if(!finish&&!flags.Any(v=>r.NativeEqual(v,constants[2])))flags.Add(constants[2]);
                return Done(JValue.R(r.HostObject("java/util/stream/Collector",new JavaCollector(false){Kind="custom",Supplier=a[0],Accumulator=a[1],Combiner=a[2],Finisher=finish?a[3]:default,Characteristics=r.ImmutableSetFactory(flags.ToArray())})));
            });
            foreach(string name in new[]{"supplier","accumulator","combiner","finisher","characteristics"})
            {
                string returns=name=="supplier"?"java/util/function/Supplier":name=="accumulator"?"java/util/function/BiConsumer":name=="combiner"?"java/util/function/BinaryOperator":name=="finisher"?"java/util/function/Function":"java/util/Set";
                StandardBind("java/util/stream/Collector",name,"()L"+returns+";",(r,s,a)=>
                {
                    var spec=r.HostPayload<JavaCollector>(s);if(spec.Kind!="custom")throw new PortGap("Collector accessor for built-in collector: "+spec.Kind);
                    if(name=="supplier")return Done(spec.Supplier);if(name=="accumulator")return Done(spec.Accumulator);if(name=="combiner")return Done(spec.Combiner);if(name=="characteristics")return Done(spec.Characteristics);
                    return Done(spec.Finisher.Reference!=null?spec.Finisher:JValue.R(r.HostObject("aot/CollectorIdentity",new object())));
                });
            }
            StandardBind("java/util/stream/Collectors","toCollection","(Ljava/util/function/Supplier;)Ljava/util/stream/Collector;",(r,s,a)=>{r.NonNull(a[0]);return Done(JValue.R(r.HostObject("java/util/stream/Collector",new JavaCollector(false){Kind="collection",Supplier=a[0]})));});
            foreach(string suffix in new[]{"","Ljava/util/function/BinaryOperator;","Ljava/util/function/BinaryOperator;Ljava/util/function/Supplier;"})
            StandardBind("java/util/stream/Collectors","toMap","(Ljava/util/function/Function;Ljava/util/function/Function;"+suffix+")Ljava/util/stream/Collector;",(r,s,a)=>
            {foreach(var function in a)r.NonNull(function);return Done(JValue.R(r.HostObject("java/util/stream/Collector",new JavaCollector(false){Kind="map",Classifier=a[0],ValueMapper=a[1],Combiner=a.Length>=3?a[2]:default,MapFactory=a.Length==4?a[3]:default})));});
            foreach(bool downstream in new[]{false,true})
            StandardBind("java/util/stream/Collectors","partitioningBy","(Ljava/util/function/Predicate;"+(downstream?"Ljava/util/stream/Collector;":"")+")Ljava/util/stream/Collector;",(r,s,a)=>
            {r.NonNull(a[0]);return Done(JValue.R(r.HostObject("java/util/stream/Collector",new JavaCollector(false){Kind="partition",Classifier=a[0],Downstream=downstream?r.HostPayload<JavaCollector>(a[1]):new JavaCollector(false)})));});
        }
    }
}

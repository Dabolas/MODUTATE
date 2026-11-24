using System;
using System.Collections.Generic;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class CollectorAccumulator
        {
            internal readonly JavaCollector Spec;internal readonly List<JValue> Values=new List<JValue>();internal long Count;internal JValue Groups;
            internal readonly List<string> Texts=new List<string>();
            internal CollectorAccumulator(JavaCollector spec){Spec=spec;}
        }
        private CollectorAccumulator BeginCollector(JavaCollector spec)
        {
            var state=new CollectorAccumulator(spec);
            if(spec.Kind=="custom"||spec.Kind=="collection")state.Groups=InlineCall("java/util/function/Supplier","get","()Ljava/lang/Object;",spec.Supplier,Array.Empty<JValue>());
            if(spec.Kind=="map")state.Groups=spec.MapFactory.Reference==null?MapOf(Array.Empty<KeyValuePair<JValue,JValue>>()):InlineCall("java/util/function/Supplier","get","()Ljava/lang/Object;",spec.MapFactory,Array.Empty<JValue>());
            if(spec.Kind=="partition")
            {
                state.Groups=MapOf(Array.Empty<KeyValuePair<JValue,JValue>>());
                foreach(bool key in new[]{false,true})InlineCall("java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",state.Groups,new[]{JValue.R(BooleanBox(key)),JValue.R(HostObject("aot/CollectorAccumulator",BeginCollector(spec.Downstream!)))});
            }
            if(spec.Kind=="group")state.Groups=spec.MapFactory.Reference==null?MapOf(Array.Empty<KeyValuePair<JValue,JValue>>()):InlineCall("java/util/function/Supplier","get","()Ljava/lang/Object;",spec.MapFactory,Array.Empty<JValue>());
            return state;
        }
        private void AccumulateCollector(CollectorAccumulator state,JValue value)
        {
            if(state.Spec.Kind=="custom"){InlineVoid("java/util/function/BiConsumer","accept","(Ljava/lang/Object;Ljava/lang/Object;)V",state.Spec.Accumulator,new[]{state.Groups,value});return;}
            if(state.Spec.Kind=="collection"){InlineCall("java/util/Collection","add","(Ljava/lang/Object;)Z",state.Groups,new[]{value});return;}
            if(state.Spec.Kind=="map")
            {
                var key=InlineCall("java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;",state.Spec.Classifier,new[]{value});
                var mapped=InlineCall("java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;",state.Spec.ValueMapper,new[]{value});NonNull(mapped);
                var previous=InlineCall("java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;",state.Groups,new[]{key});
                if(previous.Reference!=null)
                {
                    if(state.Spec.Combiner.Reference==null)throw Fault("java/lang/IllegalStateException","Duplicate key in Collectors.toMap");
                    mapped=InlineCall("java/util/function/BinaryOperator","apply","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",state.Spec.Combiner,new[]{previous,mapped});
                    if(mapped.Reference==null){InlineCall("java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;",state.Groups,new[]{key});return;}
                }
                InlineCall("java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",state.Groups,new[]{key,mapped});return;
            }
            if(state.Spec.Kind=="count"){state.Count=unchecked(state.Count+1);return;}
            if(state.Spec.Kind=="sumInt"){state.Count=unchecked((int)state.Count+InlineCall("java/util/function/ToIntFunction","applyAsInt","(Ljava/lang/Object;)I",state.Spec.Classifier,new[]{value}).Int);return;}
            if(state.Spec.Kind=="join"){state.Texts.Add(value.Reference==null?"null":CharSequence(value));return;}
            if(state.Spec.Kind=="items"){state.Values.Add(value);return;}
            var groupKey=state.Spec.Kind=="partition"?JValue.R(BooleanBox(InlineCall("java/util/function/Predicate","test","(Ljava/lang/Object;)Z",state.Spec.Classifier,new[]{value}).Int!=0)):InlineCall("java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;",state.Spec.Classifier,new[]{value});NonNull(groupKey);
            var existing=InlineCall("java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;",state.Groups,new[]{groupKey});CollectorAccumulator child;
            if(existing.Reference==null){child=BeginCollector(state.Spec.Downstream!);InlineCall("java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",state.Groups,new[]{groupKey,JValue.R(HostObject("aot/CollectorAccumulator",child))});}
            else child=HostPayload<CollectorAccumulator>(existing);
            AccumulateCollector(child,value);
        }
        private JValue FinishCollector(CollectorAccumulator state)
        {
            if(state.Spec.Kind=="custom")return state.Spec.Finisher.Reference==null?state.Groups:InlineCall("java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;",state.Spec.Finisher,new[]{state.Groups});
            if(state.Spec.Kind=="map"||state.Spec.Kind=="collection")return state.Groups;
            if(state.Spec.Kind=="count")return BoxLong(state.Count);
            if(state.Spec.Kind=="sumInt")return BoxInt((int)state.Count);
            if(state.Spec.Kind=="join")return JValue.R(String(state.Spec.Prefix+string.Join(state.Spec.Delimiter,state.Texts)+state.Spec.Suffix));
            if(state.Spec.Kind=="items")
            {if(!state.Spec.Set)return ListOf(state.Values);var list=new JavaList{Unique=true};foreach(var value in state.Values)AddNative(list,value);return JValue.R(HostObject("java/util/HashSet",list));}
            foreach(var pair in MapItems(state.Groups))InlineCall("java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",state.Groups,new[]{pair.Key,FinishCollector(HostPayload<CollectorAccumulator>(pair.Value))});
            return state.Groups;
        }
        private void InstallGroupingCollectors()
        {
            InstallCustomCollectors();
            StandardBind("java/util/stream/Collectors","summingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/stream/Collector;",(r,s,a)=>{r.NonNull(a[0]);return Done(JValue.R(r.HostObject("java/util/stream/Collector",new JavaCollector(false){Kind="sumInt",Classifier=a[0]})));});
            foreach(string signature in new[]{"()","(Ljava/lang/CharSequence;)","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)"})StandardBind("java/util/stream/Collectors","joining",signature+"Ljava/util/stream/Collector;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/stream/Collector",new JavaCollector(false){Kind="join",Delimiter=a.Length==0?"":r.CharSequence(a[0]),Prefix=a.Length==3?r.CharSequence(a[1]):"",Suffix=a.Length==3?r.CharSequence(a[2]):""}))));
            StandardBind("java/util/stream/Collectors","counting","()Ljava/util/stream/Collector;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/stream/Collector",new JavaCollector(false){Kind="count"}))));
            foreach(string tail in new[]{"","Ljava/util/stream/Collector;","Ljava/util/function/Supplier;Ljava/util/stream/Collector;"})
            StandardBind("java/util/stream/Collectors","groupingBy","(Ljava/util/function/Function;"+tail+")Ljava/util/stream/Collector;",(r,s,a)=>
            {r.NonNull(a[0]);var downstream=a.Length==1?new JavaCollector(false):r.HostPayload<JavaCollector>(a[a.Length-1]);if(a.Length==3)r.NonNull(a[1]);return Done(JValue.R(r.HostObject("java/util/stream/Collector",new JavaCollector(false){Kind="group",Classifier=a[0],Downstream=downstream,MapFactory=a.Length==3?a[1]:default})));});
        }
    }
}

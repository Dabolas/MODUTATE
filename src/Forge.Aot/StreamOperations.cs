using System;
using System.Collections.Generic;
using System.Linq;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class StreamIterator
        {
            internal readonly IEnumerator<JValue> Values;internal bool Buffered,Ended;internal JValue Current;
            internal StreamIterator(IEnumerator<JValue> values){Values=values;}
            internal bool HasNext(){if(Buffered)return true;if(Ended)return false;if(!Values.MoveNext()){Ended=true;Values.Dispose();return false;}Current=Values.Current;Buffered=true;return true;}
        }
        private JavaStream TakeStream(JValue value){var stream=HostPayload<JavaStream>(value);if(stream.Consumed)throw Fault("java/lang/IllegalStateException","Stream already linked or consumed");stream.Consumed=true;return stream;}
        private JValue StreamOf(Func<IEnumerable<JValue>> source)=>JValue.R(HostObject("java/util/stream/Stream",new JavaStream(source)));
        private IEnumerable<JValue> StreamIterable(JValue value)
        {var iterator=InlineCall("java/lang/Iterable","iterator","()Ljava/util/Iterator;",value,Array.Empty<JValue>());foreach(var item in StreamIteratorValues(iterator))yield return item;}
        private IEnumerable<JValue> StreamIteratorValues(JValue iterator)
        {while(InlineCall("java/util/Iterator","hasNext","()Z",iterator,Array.Empty<JValue>()).Int!=0)yield return InlineCall("java/util/Iterator","next","()Ljava/lang/Object;",iterator,Array.Empty<JValue>());}
        private sealed class JavaSpliterator {internal readonly JValue Iterator;internal JavaSpliterator(JValue iterator){Iterator=iterator;}}
        private IEnumerable<JValue> StreamValues(JavaStream stream)
        {
            long work=0;
            foreach(var input in stream.Source())
            {
                if(++work>1000000)throw new PortGap("Stream exceeds development runtime work bound");
                var value=input;bool include=true;
                foreach(var step in stream.Steps)
                {var result=InlineCall(step.Map?"java/util/function/Function":"java/util/function/Predicate",step.Map?"apply":"test",step.Map?"(Ljava/lang/Object;)Ljava/lang/Object;":"(Ljava/lang/Object;)Z",step.Function,new[]{value});if(step.Map)value=result;else if(result.Int==0){include=false;break;}}
                if(include)yield return value;
            }
        }
        private IEnumerable<JValue> DistinctStream(JavaStream source)
        {var seen=new List<JValue>();foreach(var value in StreamValues(source)){if(seen.Any(previous=>NativeEqual(previous,value)))continue;seen.Add(value);yield return value;}}
        private IEnumerable<JValue> LimitStream(JavaStream source,long limit)
        {if(limit==0)yield break;long count=0;foreach(var value in StreamValues(source)){yield return value;if(++count==limit)yield break;}}
        private IEnumerable<JValue> FlatStream(JavaStream source,JValue mapper)
        {foreach(var value in StreamValues(source)){var mapped=InlineCall("java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;",mapper,new[]{value});if(mapped.Reference==null)continue;foreach(var item in StreamValues(TakeStream(mapped)))yield return item;}}
        private IEnumerable<JValue> GenerateStream(JValue supplier)
        {while(true)yield return InlineCall("java/util/function/Supplier","get","()Ljava/lang/Object;",supplier,Array.Empty<JValue>());}
        private IEnumerable<JValue> OrderedStream(JavaStream source,JValue comparator)
        {var values=StreamValues(source).Select((value,index)=>(value,index)).ToArray();Array.Sort(values,(x,y)=>{int c=InlineCall("java/util/Comparator","compare","(Ljava/lang/Object;Ljava/lang/Object;)I",comparator,new[]{x.value,y.value}).Int;return c!=0?c:x.index.CompareTo(y.index);});return values.Select(pair=>pair.value);}
        private void InstallStreamOperations()
        {
            InstallGroupingCollectors();
            InstallPrimitiveStreamFamily();
            NativeClass("java/util/Spliterator");
            interfaceDefaults.Add(("java/lang/Iterable","spliterator","()Ljava/util/Spliterator;"));
            interfaceDefaults.Add(("java/lang/Iterable","forEach","(Ljava/util/function/Consumer;)V"));
            StandardBind("java/lang/Iterable","forEach","(Ljava/util/function/Consumer;)V",(r,s,a)=>{r.NonNull(a[0]);foreach(var value in r.StreamIterable(s))r.InlineVoid("java/util/function/Consumer","accept","(Ljava/lang/Object;)V",a[0],new[]{value});return Done();});
            StandardBind("com/google/common/collect/Iterables","size","(Ljava/lang/Iterable;)I",(r,s,a)=>{int count=0;foreach(var value in r.StreamIterable(a[0])){if(count==int.MaxValue)return Done(JValue.I(count));count++;}return Done(JValue.I(count));});
            StandardBind("java/lang/Iterable","spliterator","()Ljava/util/Spliterator;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/Spliterator",new JavaSpliterator(r.InlineCall("java/lang/Iterable","iterator","()Ljava/util/Iterator;",s,Array.Empty<JValue>()))))));
            StandardBind("java/util/stream/StreamSupport","stream","(Ljava/util/Spliterator;Z)Ljava/util/stream/Stream;",(r,s,a)=>{if(a[1].Int!=0)throw new PortGap("Parallel stream execution requires an explicit scheduler");var source=r.HostPayload<JavaSpliterator>(a[0]);return Done(r.StreamOf(()=>r.StreamIteratorValues(source.Iterator)));});
            StandardBind("java/util/Spliterator","tryAdvance","(Ljava/util/function/Consumer;)Z",(r,s,a)=>{r.NonNull(a[0]);var source=r.HostPayload<JavaSpliterator>(s);if(r.InlineCall("java/util/Iterator","hasNext","()Z",source.Iterator,Array.Empty<JValue>()).Int==0)return Done(JValue.I(0));var value=r.InlineCall("java/util/Iterator","next","()Ljava/lang/Object;",source.Iterator,Array.Empty<JValue>());r.InlineVoid("java/util/function/Consumer","accept","(Ljava/lang/Object;)V",a[0],new[]{value});return Done(JValue.I(1));});
            NativeClass("aot/StreamIterator","java/lang/Object","java/util/Iterator");
            foreach(string owner in new[]{"java/util/stream/Stream","java/util/stream/BaseStream"})StandardBind(owner,"iterator","()Ljava/util/Iterator;",(r,s,a)=>Done(JValue.R(r.HostObject("aot/StreamIterator",new StreamIterator(r.StreamValues(r.TakeStream(s)).GetEnumerator())))));
            StandardBind("aot/StreamIterator","hasNext","()Z",(r,s,a)=>Done(JValue.I(r.HostPayload<StreamIterator>(s).HasNext()?1:0)));
            StandardBind("aot/StreamIterator","next","()Ljava/lang/Object;",(r,s,a)=>{var iterator=r.HostPayload<StreamIterator>(s);if(!iterator.HasNext())throw r.Fault("java/util/NoSuchElementException");iterator.Buffered=false;return Done(iterator.Current);});
            StandardBind("aot/StreamIterator","remove","()V",(r,s,a)=>throw r.Fault("java/lang/UnsupportedOperationException"));
            const string streamType="java/util/stream/Stream";
            StandardBind(streamType,"empty","()Ljava/util/stream/Stream;",(r,s,a)=>Done(r.StreamOf(()=>Array.Empty<JValue>())));
            StandardBind(streamType,"of","([Ljava/lang/Object;)Ljava/util/stream/Stream;",(r,s,a)=>{var array=r.ArrayObject(a[0]);return Done(r.StreamOf(()=>array.Items));});
            StandardBind(streamType,"generate","(Ljava/util/function/Supplier;)Ljava/util/stream/Stream;",(r,s,a)=>{r.NonNull(a[0]);return Done(r.StreamOf(()=>r.GenerateStream(a[0])));});
            StandardBind(streamType,"distinct","()Ljava/util/stream/Stream;",(r,s,a)=>{var source=r.TakeStream(s);return Done(r.StreamOf(()=>r.DistinctStream(source)));});
            StandardBind(streamType,"limit","(J)Ljava/util/stream/Stream;",(r,s,a)=>{if(a[0].Long<0)throw r.Fault("java/lang/IllegalArgumentException");var source=r.TakeStream(s);return Done(r.StreamOf(()=>r.LimitStream(source,a[0].Long)));});
            StandardBind(streamType,"flatMap","(Ljava/util/function/Function;)Ljava/util/stream/Stream;",(r,s,a)=>{r.NonNull(a[0]);var source=r.TakeStream(s);return Done(r.StreamOf(()=>r.FlatStream(source,a[0])));});
            StandardBind(streamType,"sorted","(Ljava/util/Comparator;)Ljava/util/stream/Stream;",(r,s,a)=>{r.NonNull(a[0]);var source=r.TakeStream(s);return Done(r.StreamOf(()=>r.OrderedStream(source,a[0])));});
            StandardBind(streamType,"count","()J",(r,s,a)=>Done(JValue.L(r.StreamValues(r.TakeStream(s)).LongCount())));
            foreach(string operation in new[]{"anyMatch","allMatch","noneMatch"})StandardBind(streamType,operation,"(Ljava/util/function/Predicate;)Z",(r,s,a)=>{r.NonNull(a[0]);foreach(var value in r.StreamValues(r.TakeStream(s))){bool match=r.InlineCall("java/util/function/Predicate","test","(Ljava/lang/Object;)Z",a[0],new[]{value}).Int!=0;if(operation=="allMatch"?!match:match)return Done(JValue.I(operation=="anyMatch"?1:0));}return Done(JValue.I(operation=="anyMatch"?0:1));});
            foreach(string operation in new[]{"findFirst","findAny"})StandardBind(streamType,operation,"()Ljava/util/Optional;",(r,s,a)=>{foreach(var value in r.StreamValues(r.TakeStream(s))){r.NonNull(value);return Done(r.Optional(value));}return Done(r.Optional(JValue.R(null)));});
            foreach(bool max in new[]{false,true})StandardBind(streamType,max?"max":"min","(Ljava/util/Comparator;)Ljava/util/Optional;",(r,s,a)=>{r.NonNull(a[0]);bool found=false;JValue best=default;foreach(var value in r.StreamValues(r.TakeStream(s))){if(!found){best=value;found=true;}else{int compare=r.InlineCall("java/util/Comparator","compare","(Ljava/lang/Object;Ljava/lang/Object;)I",a[0],new[]{best,value}).Int;if(max?compare<0:compare>0)best=value;}}if(found)r.NonNull(best);return Done(r.Optional(best));});
            StandardBind(streamType,"reduce","(Ljava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;",(r,s,a)=>{r.NonNull(a[1]);var value=a[0];foreach(var item in r.StreamValues(r.TakeStream(s)))value=r.InlineCall("java/util/function/BinaryOperator","apply","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",a[1],new[]{value,item});return Done(value);});
            StandardBind(streamType,"forEach","(Ljava/util/function/Consumer;)V",(r,s,a)=>{r.NonNull(a[0]);foreach(var item in r.StreamValues(r.TakeStream(s)))r.InlineVoid("java/util/function/Consumer","accept","(Ljava/lang/Object;)V",a[0],new[]{item});return Done();});
            // Use the same lazy per-element pipeline for every terminal operation.
            Bind(streamType,"collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;",(r,s,a)=>{
                var collector=r.NonNull(a[0]);
                var source=r.TakeStream(s);
                if(collector.Payload is JavaCollector native)
                {
                    var state=r.BeginCollector(native);
                    foreach(var value in r.StreamValues(source))r.AccumulateCollector(state,value);
                    return Done(r.FinishCollector(state));
                }
                const string contract="java/util/stream/Collector";
                JValue Member(string name,string type)=>r.InlineCall(contract,name,"()L"+type+";",a[0],Array.Empty<JValue>());
                var supplier=Member("supplier","java/util/function/Supplier");
                var accumulator=Member("accumulator","java/util/function/BiConsumer");
                var result=r.InlineCall("java/util/function/Supplier","get","()Ljava/lang/Object;",supplier,Array.Empty<JValue>());
                foreach(var value in r.StreamValues(source))
                    r.InlineCall("java/util/function/BiConsumer","accept","(Ljava/lang/Object;Ljava/lang/Object;)V",accumulator,new[]{result,value});
                var characteristics=Member("characteristics","java/util/Set");
                if(r.ListItems(characteristics).Any(c=>r.InspectEnumName(c)=="IDENTITY_FINISH"))return Done(result);
                var finish=Member("finisher","java/util/function/Function");
                return Done(r.InlineCall("java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;",finish,new[]{result}));
            });
        }
    }
}

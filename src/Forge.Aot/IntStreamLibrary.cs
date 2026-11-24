using System;
using System.Collections.Generic;
using System.Linq;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class IntStreamSource {internal readonly JValue Stream,Mapper;internal bool Consumed;internal IntStreamSource(JValue stream,JValue mapper){Stream=stream;Mapper=mapper;}}
        private IEnumerable<JValue> BoxedRange(int start,int end){for(long i=start;i<=end;i++)yield return BoxInt((int)i);}
        private void InstallIntStreams()
        {
            NativeClass("java/util/stream/IntStream","java/lang/Object","java/util/stream/BaseStream");NativeClass("java/util/OptionalInt");
            StandardBind("java/util/stream/IntStream","rangeClosed","(II)Ljava/util/stream/IntStream;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/stream/IntStream",new IntStreamSource(r.StreamOf(()=>r.BoxedRange(a[0].Int,a[1].Int)),default)))));
            StandardBind("java/util/stream/IntStream","boxed","()Ljava/util/stream/Stream;",(r,s,a)=>{var source=r.HostPayload<IntStreamSource>(s);if(source.Consumed)throw r.Fault("java/lang/IllegalStateException");source.Consumed=true;var input=r.TakeStream(source.Stream);return Done(r.StreamOf(()=>r.StreamValues(input).Select(v=>source.Mapper.Reference==null?v:r.BoxInt(r.InlineCall("java/util/function/ToIntFunction","applyAsInt","(Ljava/lang/Object;)I",source.Mapper,new[]{v}).Int))));});
            StandardBind("java/util/stream/Stream","mapToInt","(Ljava/util/function/ToIntFunction;)Ljava/util/stream/IntStream;",(r,s,a)=>{r.NonNull(a[0]);var stream=r.HostPayload<JavaStream>(s);if(stream.Consumed)throw r.Fault("java/lang/IllegalStateException");stream.Consumed=true;var child=JValue.R(r.HostObject("java/util/stream/Stream",new JavaStream(stream.Source,stream.Steps)));return Done(JValue.R(r.HostObject("java/util/stream/IntStream",new IntStreamSource(child,a[0]))));});
            StandardBind("java/util/OptionalInt","orElse","(I)I",(r,s,a)=>{var value=r.HostPayload<JavaOptional>(s).Value;return Done(value.Reference==null?a[0]:JValue.I(r.UnboxInt(value)));});
            StandardBind("java/util/OptionalInt","getAsInt","()I",(r,s,a)=>{var value=r.HostPayload<JavaOptional>(s).Value;if(value.Reference==null)throw r.Fault("java/util/NoSuchElementException");return Done(JValue.I(r.UnboxInt(value)));});
            StandardBind("java/util/OptionalInt","isPresent","()Z",(r,s,a)=>Done(JValue.I(r.HostPayload<JavaOptional>(s).Value.Reference!=null?1:0)));
            foreach(string operation in new[]{"sum","min","max"})StandardBind("java/util/stream/IntStream",operation,operation=="sum"?"()I":"()Ljava/util/OptionalInt;",(r,s,a)=>
            {
                var source=r.HostPayload<IntStreamSource>(s);if(source.Consumed)throw r.Fault("java/lang/IllegalStateException");source.Consumed=true;JValue[] values=Array.Empty<JValue>();int index=0,total=0;
                var method=new JMethod(-109,"java/lang/Object","<int-stream-aggregate>",operation=="sum"?"()I":"()Ljava/util/OptionalInt;",8,0,3,Array.Empty<JHandler>(),(t,f)=>
                {
                    if(!t.Tick())return JStep.Yield;
                    if(f.Pc==0){f.Push(source.Stream);f.Push(JValue.R(t.HostObject("java/util/stream/Collector",new JavaCollector(false))));f.Pc=10;}
                    if(f.Pc==10)return t.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",1);
                    if(f.Pc==1){values=t.ListItems(f.Pop());f.Pc=2;}
                    if(f.Pc==3){int value=f.Pop().Int;total=operation=="sum"?unchecked(total+value):index==0?value:operation=="min"?Math.Min(total,value):Math.Max(total,value);index++;f.Pc=2;}
                    if(f.Pc==2){if(index==values.Length)return JStep.Return(operation=="sum"?JValue.I(total):JValue.R(t.HostObject("java/util/OptionalInt",new JavaOptional(index==0?JValue.R(null):t.BoxInt(total)))));if(source.Mapper.Reference==null){f.Push(JValue.I(t.UnboxInt(values[index])));f.Pc=3;return JStep.Continue;}f.Push(source.Mapper);f.Push(values[index]);f.Pc=20;}
                    return t.Call(f,"java/util/function/ToIntFunction","applyAsInt","(Ljava/lang/Object;)I","invokeinterface",3);
                });return JHostResult.Schedule(new JFrame(method,default,Array.Empty<JValue>()));
            });
        }
    }
}

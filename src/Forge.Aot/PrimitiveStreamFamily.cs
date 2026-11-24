using System;
using System.Linq;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private JValue BoxedIntStream(JValue source)=>InlineCall("java/util/stream/IntStream","boxed","()Ljava/util/stream/Stream;",source,Array.Empty<JValue>());
        private void InstallPrimitiveStreamFamily()
        {
            StandardBind("java/util/stream/IntStream","count","()J",(r,s,a)=>Done(JValue.L(r.StreamValues(r.TakeStream(r.BoxedIntStream(s))).LongCount())));
            StandardBind("java/util/stream/IntStream","distinct","()Ljava/util/stream/IntStream;",(r,s,a)=>{var source=r.TakeStream(r.BoxedIntStream(s));return Done(JValue.R(r.HostObject("java/util/stream/IntStream",new IntStreamSource(r.StreamOf(()=>r.DistinctStream(source)),default))));});
            NativeClass("java/util/stream/LongStream","java/lang/Object","java/util/stream/BaseStream");NativeClass("java/util/OptionalLong");
            StandardBind("java/util/stream/Stream","mapToLong","(Ljava/util/function/ToLongFunction;)Ljava/util/stream/LongStream;",(r,s,a)=>
            {r.NonNull(a[0]);var source=r.TakeStream(s);return Done(JValue.R(r.HostObject("java/util/stream/LongStream",new JavaStream(()=>r.StreamValues(source).Select(v=>r.BoxLong(r.InlineCall("java/util/function/ToLongFunction","applyAsLong","(Ljava/lang/Object;)J",a[0],new[]{v}).Long))))));});
            foreach(string operation in new[]{"sum","min","max","count"})StandardBind("java/util/stream/LongStream",operation,operation=="sum"||operation=="count"?"()J":"()Ljava/util/OptionalLong;",(r,s,a)=>
            {
                bool found=false;long total=0,count=0;foreach(var value in r.StreamValues(r.TakeStream(s))){long number=r.NonNull(value).Boxed!.Value.Long;total=operation=="sum"?unchecked(total+number):!found?number:operation=="min"?Math.Min(total,number):Math.Max(total,number);found=true;count++;}
                return Done(operation=="sum"?JValue.L(total):operation=="count"?JValue.L(count):JValue.R(r.HostObject("java/util/OptionalLong",new JavaOptional(found?r.BoxLong(total):default))));
            });
            StandardBind("java/util/OptionalLong","isPresent","()Z",(r,s,a)=>Done(JValue.I(r.HostPayload<JavaOptional>(s).Value.Reference!=null?1:0)));
            StandardBind("java/util/OptionalLong","orElse","(J)J",(r,s,a)=>{var value=r.HostPayload<JavaOptional>(s).Value;return Done(value.Reference==null?a[0]:JValue.L(r.NonNull(value).Boxed!.Value.Long));});
            StandardBind("java/util/OptionalLong","getAsLong","()J",(r,s,a)=>{var value=r.HostPayload<JavaOptional>(s).Value;if(value.Reference==null)throw r.Fault("java/util/NoSuchElementException");return Done(JValue.L(r.NonNull(value).Boxed!.Value.Long));});
        }
    }
}

using System;
using System.Collections.Generic;

namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class JavaComparator
        {internal JValue Extractor,Before,After;internal bool Natural,Reverse,ObjectKey,LongKey,EntryValue,EntryKey;}
        private void InstallComparators()
        {
            InstallComparisonChain();
            StandardBind("org/apache/commons/lang3/ObjectUtils","compare","(Ljava/lang/Comparable;Ljava/lang/Comparable;)I",(r,s,a)=>Done(JValue.I(ReferenceEquals(a[0].Reference,a[1].Reference)?0:a[0].Reference==null?-1:a[1].Reference==null?1:r.CompareNative(a[0],a[1]))));
            StandardBind("java/util/Map$Entry","comparingByValue","()Ljava/util/Comparator;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/Comparator",new JavaComparator{EntryValue=true}))));
            StandardBind("java/util/Map$Entry","comparingByKey","()Ljava/util/Comparator;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/Comparator",new JavaComparator{EntryKey=true}))));
            foreach(string type in new[]{"ToIntFunction","IntFunction","IntSupplier","IntPredicate","IntConsumer","IntUnaryOperator","ToLongFunction","ToDoubleFunction","BinaryOperator","UnaryOperator","BiPredicate","BooleanSupplier","LongSupplier","Supplier","Function","BiFunction","Consumer","BiConsumer"})NativeClass("java/util/function/"+type);
            StandardBind("java/util/Comparator","comparingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;",(r,s,a)=>{r.NonNull(a[0]);return Done(JValue.R(r.HostObject("java/util/Comparator",new JavaComparator{Extractor=a[0]})));});
            StandardBind("java/util/Comparator","comparingLong","(Ljava/util/function/ToLongFunction;)Ljava/util/Comparator;",(r,s,a)=>{r.NonNull(a[0]);return Done(JValue.R(r.HostObject("java/util/Comparator",new JavaComparator{Extractor=a[0],LongKey=true})));});
            StandardBind("java/util/Comparator","comparing","(Ljava/util/function/Function;)Ljava/util/Comparator;",(r,s,a)=>{r.NonNull(a[0]);return Done(JValue.R(r.HostObject("java/util/Comparator",new JavaComparator{Extractor=a[0],ObjectKey=true})));});
            StandardBind("java/util/Comparator","thenComparing","(Ljava/util/Comparator;)Ljava/util/Comparator;",(r,s,a)=>{r.NonNull(a[0]);return Done(JValue.R(r.HostObject("java/util/Comparator",new JavaComparator{Before=s,After=a[0]})));});
            StandardBind("java/util/Comparator","thenComparing","(Ljava/util/function/Function;)Ljava/util/Comparator;",(r,s,a)=>{r.NonNull(a[0]);var after=JValue.R(r.HostObject("java/util/Comparator",new JavaComparator{Extractor=a[0],ObjectKey=true}));return Done(JValue.R(r.HostObject("java/util/Comparator",new JavaComparator{Before=s,After=after})));});
            StandardBind("java/util/Comparator","reversed","()Ljava/util/Comparator;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/Comparator",new JavaComparator{Before=s,Reverse=true}))));
            StandardBind("java/util/Comparator","naturalOrder","()Ljava/util/Comparator;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/Comparator",new JavaComparator{Natural=true}))));
            StandardBind("java/util/Comparator","reverseOrder","()Ljava/util/Comparator;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/Comparator",new JavaComparator{Natural=true,Reverse=true}))));
            StandardBind("java/util/Comparator","compare","(Ljava/lang/Object;Ljava/lang/Object;)I",(r,s,a)=>
            {
                if(r.NonNull(s).Payload is AsciiCaseComparator){var x=r.Text(a[0]);var y=r.Text(a[1]);AssertAscii(x);AssertAscii(y);return Done(JValue.I(string.Compare(x,y,StringComparison.OrdinalIgnoreCase)));}
                var cmp=r.HostPayload<JavaComparator>(s);var xval=cmp.Reverse?a[1]:a[0];var yval=cmp.Reverse?a[0]:a[1];
                if(cmp.EntryValue||cmp.EntryKey){var x=r.InlineCall("java/util/Map$Entry",cmp.EntryKey?"getKey":"getValue","()Ljava/lang/Object;",xval,Array.Empty<JValue>());var y=r.InlineCall("java/util/Map$Entry",cmp.EntryKey?"getKey":"getValue","()Ljava/lang/Object;",yval,Array.Empty<JValue>());return Done(JValue.I(r.CompareNative(x,y)));}
                if(cmp.Before.Reference!=null)
                {
                    var chain=new JMethod(-103,"java/lang/Object","<comparator-chain>","()I",8,0,4,Array.Empty<JHandler>(),(t,f)=>
                    {if(!t.Tick())return JStep.Yield;if(f.Pc==0){f.Push(cmp.Before);f.Push(xval);f.Push(yval);f.Pc=10;}if(f.Pc==10)return t.Call(f,"java/util/Comparator","compare","(Ljava/lang/Object;Ljava/lang/Object;)I","invokeinterface",1);if(f.Pc==1){var result=f.Pop();if(result.Int!=0||cmp.After.Reference==null)return JStep.Return(result);f.Push(cmp.After);f.Push(xval);f.Push(yval);f.Pc=20;}if(f.Pc==20)return t.Call(f,"java/util/Comparator","compare","(Ljava/lang/Object;Ljava/lang/Object;)I","invokeinterface",2);return JStep.Return(f.Pop());});return JHostResult.Schedule(new JFrame(chain,default,Array.Empty<JValue>()));
                }
                if(cmp.Natural)return Done(JValue.I(r.CompareNative(xval,yval)));
                JValue first=default;string iface=cmp.ObjectKey?"java/util/function/Function":cmp.LongKey?"java/util/function/ToLongFunction":"java/util/function/ToIntFunction",apply=cmp.ObjectKey?"apply":cmp.LongKey?"applyAsLong":"applyAsInt",desc=cmp.ObjectKey?"(Ljava/lang/Object;)Ljava/lang/Object;":cmp.LongKey?"(Ljava/lang/Object;)J":"(Ljava/lang/Object;)I";
                var method=new JMethod(-101,"java/lang/Object","<compare-int-keys>","()I",8,0,3,Array.Empty<JHandler>(),(t,f)=>
                {if(!t.Tick())return JStep.Yield;if(f.Pc==0){f.Push(cmp.Extractor);f.Push(xval);f.Pc=10;}if(f.Pc==10)return t.Call(f,iface,apply,desc,"invokeinterface",1);if(f.Pc==1){first=f.Pop();f.Push(cmp.Extractor);f.Push(yval);f.Pc=20;}if(f.Pc==20)return t.Call(f,iface,apply,desc,"invokeinterface",2);var second=f.Pop();return JStep.Return(JValue.I(cmp.ObjectKey?t.CompareNative(first,second):cmp.LongKey?first.Long.CompareTo(second.Long):first.Int.CompareTo(second.Int)));});
                return JHostResult.Schedule(new JFrame(method,default,Array.Empty<JValue>()));
            });
            foreach(string type in new[]{"java/util/List","java/util/ArrayList"})StandardBind(type,"sort","(Ljava/util/Comparator;)V",(r,s,a)=>r.SortWithComparator(s,a[0]));
            StandardBind("java/util/Collections","sort","(Ljava/util/List;Ljava/util/Comparator;)V",(r,s,a)=>r.SortWithComparator(a[0],a[1]));
        }
        private JHostResult SortWithComparator(JValue receiver,JValue comparator)
        {
            var list=HostPayload<JavaList>(receiver);Mutable(list,false);var values=ListItems(receiver);int version=list.Version,i=1,j=0;JValue current=default;
            var method=new JMethod(-102,"java/lang/Object","<stable-list-sort>","()V",8,0,4,Array.Empty<JHandler>(),(r,f)=>
            {
                if(!r.Tick())return JStep.Yield;if(version!=list.Version)throw r.Fault("java/util/ConcurrentModificationException");
                if(f.Pc==3)return r.Call(f,"java/util/Comparator","compare","(Ljava/lang/Object;Ljava/lang/Object;)I","invokeinterface",2);
                if(f.Pc==2){if(f.Pop().Int>0){values[j+1]=values[j];j--;}else{values[j+1]=current;i++;f.Pc=0;return JStep.Continue;}f.Pc=1;}
                if(i>=values.Length){for(int n=0;n<values.Length;n++)list.Values[n]=values[n];list.Version++;return JStep.ReturnVoid;}
                if(f.Pc==0){current=values[i];j=i-1;f.Pc=1;}
                if(j<0){values[0]=current;i++;f.Pc=0;return JStep.Continue;}
                if(comparator.Reference==null){f.Push(JValue.I(r.CompareNative(values[j],current)));f.Pc=2;return JStep.Continue;}
                f.Push(comparator);f.Push(values[j]);f.Push(current);f.Pc=3;return JStep.Continue;
            });return JHostResult.Schedule(new JFrame(method,default,Array.Empty<JValue>()));
        }
    }
}

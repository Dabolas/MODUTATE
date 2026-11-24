using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class JavaOptional { internal readonly JValue Value;internal JavaOptional(JValue value){Value=value;} }
        // Schedule Java callbacks on the interpreter stack; never recursively Run() a live runtime.
        private JHostResult Callback(string owner,string name,string descriptor,JValue receiver,JValue[] args,Func<JRuntime,JValue,JValue> finish)
        {
            var method=new JMethod(-96,"java/lang/Object","<native-callback>","()Ljava/lang/Object;",8,0,args.Length+3,Array.Empty<JHandler>(),(r,f)=>
            {
                if(!r.Tick())return JStep.Yield;
                if(f.Pc==1)return JStep.Return(finish(r,f.Pop()));
                if(f.Pc==0){f.Push(receiver);foreach(var a in args)f.Push(a);f.Pc=2;}
                return r.Call(f,owner,name,descriptor,"invokeinterface",1);
            });
            return JHostResult.Schedule(new JFrame(method,default,Array.Empty<JValue>()));
        }
        private static long RoundedLong(double value)
        {if(double.IsNaN(value))return 0;if(value>=long.MaxValue)return long.MaxValue;if(value<=long.MinValue)return long.MinValue;double floor=Math.Floor(value);return (long)(value-floor>=0.5?floor+1:floor);}
        private void InstallCoreLibrary()
        {
            NativeClass("java/lang/Boolean","java/lang/Object","java/lang/Comparable");
            BindStatic("java/lang/Boolean","TRUE","Ljava/lang/Boolean;",()=>JValue.R(BooleanBox(true)));
            BindStatic("java/lang/Boolean","FALSE","Ljava/lang/Boolean;",()=>JValue.R(BooleanBox(false)));
            NativeClass("java/lang/Long","java/lang/Number","java/lang/Comparable");NativeClass("java/util/Optional");
            NativeClass("com/google/common/base/Enums");
            NativeClass("com/google/common/base/Optional");
            StandardBind("com/google/common/base/Enums","getIfPresent","(Ljava/lang/Class;Ljava/lang/String;)Lcom/google/common/base/Optional;",(r,s,a)=>{
                string type=r.EnumType(a[0]),name=r.Text(a[1]);
                return r.AfterClassInit(type,t=>{
                    var value=t.EnumValues(type).FirstOrDefault(item=>t.InspectEnumName(item)==name);
                    return JValue.R(t.HostObject("com/google/common/base/Optional",new JavaOptional(JValue.R(value.Reference))));
                });
            });
            StandardBind("com/google/common/base/Optional","orNull","()Ljava/lang/Object;",(r,s,a)=>Done(r.HostPayload<JavaOptional>(s).Value));
            NativeClass("java/lang/Record");StandardBind("java/lang/Record","<init>","()V",(r,s,a)=>Done());
            foreach(var box in new[]{("java/lang/Float","F","floatValue"),("java/lang/Double","D","doubleValue"),("java/lang/Character","C","charValue"),("java/lang/Byte","B","byteValue"),("java/lang/Short","S","shortValue")})
            {
                NativeClass(box.Item1,box.Item2=="C"?"java/lang/Object":"java/lang/Number","java/lang/Comparable");
                StandardBind(box.Item1,"valueOf","("+box.Item2+")L"+box.Item1+";",(r,s,a)=>Done(r.BoxPrimitive(box.Item1,a[0])));
                StandardBind(box.Item1,box.Item3,"()"+box.Item2,(r,s,a)=>Done(r.NonNull(s).Boxed??throw new PortGap("Primitive box required")));
            }
            foreach(string kind in new[]{"I","J"})
            {
                bool wide=kind=="J";
                StandardBind("java/lang/Math","abs","("+kind+")"+kind,(r,s,a)=>Done(wide?JValue.L(a[0].Long<0?unchecked(-a[0].Long):a[0].Long):JValue.I(a[0].Int<0?unchecked(-a[0].Int):a[0].Int)));
                foreach(bool max in new[]{false,true})StandardBind("java/lang/Math",max?"max":"min","("+kind+kind+")"+kind,(r,s,a)=>Done(wide?JValue.L(max?Math.Max(a[0].Long,a[1].Long):Math.Min(a[0].Long,a[1].Long)):JValue.I(max?Math.Max(a[0].Int,a[1].Int):Math.Min(a[0].Int,a[1].Int))));
            }
            StandardBind("java/lang/Math","abs","(F)F",(r,s,a)=>Done(JValue.F(Math.Abs(a[0].Float))));
            StandardBind("java/lang/Math","min","(FF)F",(r,s,a)=>{float x=a[0].Float,y=a[1].Float;return Done(JValue.F(float.IsNaN(x)?x:float.IsNaN(y)?y:x==0&&y==0?BitConverter.Int32BitsToSingle(a[0].Int|a[1].Int):Math.Min(x,y)));});
            StandardBind("java/lang/Math","ceil","(D)D",(r,s,a)=>Done(JValue.D(Math.Ceiling(a[0].Double))));
            StandardBind("java/lang/Math","floor","(D)D",(r,s,a)=>Done(JValue.D(Math.Floor(a[0].Double))));
            StandardBind("java/lang/Math","log","(D)D",(r,s,a)=>Done(JValue.D(Math.Log(a[0].Double))));
            StandardBind("java/lang/Math","pow","(DD)D",(r,s,a)=>Done(JValue.D(a[1].Double==0?1:Math.Pow(a[0].Double,a[1].Double))));
            StandardBind("java/lang/Math","round","(D)J",(r,s,a)=>Done(JValue.L(RoundedLong(a[0].Double))));
            StandardBind("java/lang/Math","round","(F)I",(r,s,a)=>Done(JValue.I((int)Math.Max(int.MinValue,Math.Min(int.MaxValue,RoundedLong(a[0].Float))))));
            StandardBind("java/lang/Math","toIntExact","(J)I",(r,s,a)=>{long v=a[0].Long;if(v<int.MinValue||v>int.MaxValue)throw r.Fault("java/lang/ArithmeticException","integer overflow");return Done(JValue.I((int)v));});
            StandardBind("java/lang/Integer","compare","(II)I",(r,s,a)=>Done(JValue.I(a[0].Int.CompareTo(a[1].Int))));
            StandardBind("java/lang/Integer","sum","(II)I",(r,s,a)=>Done(JValue.I(unchecked(a[0].Int+a[1].Int))));
            StandardBind("java/lang/Integer","toString","(I)Ljava/lang/String;",(r,s,a)=>Done(JValue.R(r.String(a[0].Int.ToString(CultureInfo.InvariantCulture)))));
            StandardBind("java/lang/Integer","toString","()Ljava/lang/String;",(r,s,a)=>Done(JValue.R(r.String(r.UnboxInt(s).ToString(CultureInfo.InvariantCulture)))));
            StandardBind("java/lang/Integer","valueOf","(Ljava/lang/String;)Ljava/lang/Integer;",(r,s,a)=>{if(!int.TryParse(r.Text(a[0]),NumberStyles.AllowLeadingSign,CultureInfo.InvariantCulture,out int n))throw r.Fault("java/lang/NumberFormatException");return Done(r.BoxInt(n));});
            foreach(string box in new[]{"java/lang/Integer","java/lang/Boolean"})StandardBind(box,"equals","(Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(a[0].Reference?.ClassName==box&&r.NativeEqual(s,a[0])?1:0)));
            StandardBind("java/lang/Boolean","parseBoolean","(Ljava/lang/String;)Z",(r,s,a)=>Done(JValue.I(a[0].Reference!=null&&string.Equals(r.Text(a[0]),"true",StringComparison.OrdinalIgnoreCase)?1:0)));
            StandardBind("java/lang/Boolean","valueOf","(Ljava/lang/String;)Ljava/lang/Boolean;",(r,s,a)=>Done(JValue.R(r.BooleanBox(a[0].Reference!=null&&string.Equals(r.Text(a[0]),"true",StringComparison.OrdinalIgnoreCase)))));
            StandardBind("java/lang/Long","compare","(JJ)I",(r,s,a)=>Done(JValue.I(a[0].Long.CompareTo(a[1].Long))));
            StandardBind("java/lang/Long","longValue","()J",(r,s,a)=>Done(r.NonNull(s).Boxed??throw new PortGap("Long box required")));
            StandardBind("java/lang/Long","valueOf","(J)Ljava/lang/Long;",(r,s,a)=>Done(r.BoxLong(a[0].Long)));
            StandardBind("java/lang/Long","valueOf","(Ljava/lang/String;)Ljava/lang/Long;",(r,s,a)=>Done(r.BoxLong(r.ParseLong(a[0]))));
            StandardBind("java/lang/Long","parseLong","(Ljava/lang/String;)J",(r,s,a)=>Done(JValue.L(r.ParseLong(a[0]))));
            StandardBind("java/lang/Double","doubleToRawLongBits","(D)J",(r,s,a)=>Done(JValue.L(a[0].Bits)));
            StandardBind("java/lang/Double","longBitsToDouble","(J)D",(r,s,a)=>Done(JValue.D(BitConverter.Int64BitsToDouble(a[0].Long))));
            StandardBind("java/util/Objects","isNull","(Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(a[0].Reference==null?1:0)));
            StandardBind("java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{r.NonNull(a[0]);return Done(a[0]);});
            StandardBind("java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var v=a[0].Reference!=null?a[0]:a[1];r.NonNull(v);return Done(v);});
            StandardBind("java/util/Objects","requireNonNullElseGet","(Ljava/lang/Object;Ljava/util/function/Supplier;)Ljava/lang/Object;",(r,s,a)=>a[0].Reference!=null?Done(a[0]):r.Callback("java/util/function/Supplier","get","()Ljava/lang/Object;",a[1],Array.Empty<JValue>(),(t,v)=>{t.NonNull(v);return v;}));
            StandardBind("java/util/Optional","empty","()Ljava/util/Optional;",(r,s,a)=>Done(r.Optional(JValue.R(null))));
            StandardBind("java/util/Optional","equals","(Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(a[0].Reference is {ClassName:"java/util/Optional",Payload:JavaOptional other}&&r.NativeEqual(r.HostPayload<JavaOptional>(s).Value,other.Value)?1:0)));
            StandardBind("java/util/Optional","hashCode","()I",(r,s,a)=>{var v=r.HostPayload<JavaOptional>(s).Value;return Done(JValue.I(v.Reference==null?0:r.InlineCall("java/lang/Object","hashCode","()I",v,Array.Empty<JValue>()).Int));});
            StandardBind("java/util/Optional","ofNullable","(Ljava/lang/Object;)Ljava/util/Optional;",(r,s,a)=>Done(r.Optional(a[0])));
            StandardBind("java/util/Optional","of","(Ljava/lang/Object;)Ljava/util/Optional;",(r,s,a)=>{r.NonNull(a[0]);return Done(r.Optional(a[0]));});
            foreach(bool empty in new[]{false,true})StandardBind("java/util/Optional",empty?"isEmpty":"isPresent","()Z",(r,s,a)=>Done(JValue.I((r.HostPayload<JavaOptional>(s).Value.Reference==null)==empty?1:0)));
            StandardBind("java/util/Optional","get","()Ljava/lang/Object;",(r,s,a)=>{var v=r.HostPayload<JavaOptional>(s).Value;if(v.Reference==null)throw r.Fault("java/util/NoSuchElementException");return Done(v);});
            StandardBind("java/util/Optional","orElse","(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var v=r.HostPayload<JavaOptional>(s).Value;return Done(v.Reference!=null?v:a[0]);});
            StandardBind("java/util/Optional","orElseGet","(Ljava/util/function/Supplier;)Ljava/lang/Object;",(r,s,a)=>{var v=r.HostPayload<JavaOptional>(s).Value;return v.Reference!=null?Done(v):r.Callback("java/util/function/Supplier","get","()Ljava/lang/Object;",a[0],Array.Empty<JValue>(),(t,x)=>x);});
            StandardBind("java/util/Optional","orElseThrow","(Ljava/util/function/Supplier;)Ljava/lang/Object;",(r,s,a)=>{var v=r.HostPayload<JavaOptional>(s).Value;return v.Reference!=null?Done(v):r.Callback("java/util/function/Supplier","get","()Ljava/lang/Object;",a[0],Array.Empty<JValue>(),(t,x)=>throw new JavaFault(t.NonNull(x)));});
            StandardBind("java/util/Optional","map","(Ljava/util/function/Function;)Ljava/util/Optional;",(r,s,a)=>{r.NonNull(a[0]);var v=r.HostPayload<JavaOptional>(s).Value;return v.Reference==null?Done(r.Optional(v)):r.Callback("java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;",a[0],new[]{v},(t,x)=>t.Optional(x));});
            InstallArrayOperations();InstallCollectionOperations();InstallMapOperations();InstallEntrySets();InstallTextOperations();InstallMultimaps();InstallForwardingMaps();InstallObservables();InstallComparators();InstallExecutionUtilities();InstallRandom();InstallTreeSets();InstallMultisets();InstallDeques();InstallStopwatches();InstallImmutableLists();InstallPredicates();InstallCollectionCallbacks();InstallIterables();InstallIntStreams();InstallStreamOperations();InstallMutableValues();InstallWeakMaps();InstallStringTokenizer();
        }
        private readonly Dictionary<long,JObject> longCache=new Dictionary<long,JObject>();
        private readonly Dictionary<string,JObject> primitiveCache=new Dictionary<string,JObject>();
        private JValue BoxPrimitive(string type,JValue value)
        {bool cache=type=="java/lang/Character"?value.Int>=0&&value.Int<=127:(type=="java/lang/Byte"||type=="java/lang/Short")&&value.Int>=-128&&value.Int<=127;string key=type+":"+value.Bits;if(cache&&primitiveCache.TryGetValue(key,out var previous))return JValue.R(previous);var box=new JObject(type,++identity){HostStorage=true,Boxed=value};if(cache)primitiveCache[key]=box;return JValue.R(box);}
        private JValue BoxLong(long value){if(value>=-128&&value<=127&&longCache.TryGetValue(value,out var cached))return JValue.R(cached);var box=new JObject("java/lang/Long",++identity){HostStorage=true,Boxed=JValue.L(value)};if(value>=-128&&value<=127)longCache[value]=box;return JValue.R(box);}
        private long ParseLong(JValue value){if(!long.TryParse(Text(value),NumberStyles.AllowLeadingSign,CultureInfo.InvariantCulture,out long n))throw Fault("java/lang/NumberFormatException");return n;}
        private JValue Optional(JValue value)=>JValue.R(HostObject("java/util/Optional",new JavaOptional(value)));
        private void InstallArrayOperations()
        {
            NativeClass("org/apache/commons/lang3/ArrayUtils");var emptyStrings=JValue.R(NewArray("Ljava/lang/String;",0));BindStatic("org/apache/commons/lang3/ArrayUtils","EMPTY_STRING_ARRAY","[Ljava/lang/String;",()=>emptyStrings);
            StandardBind("org/apache/commons/lang3/ArrayUtils","contains","([Ljava/lang/Object;Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(a[0].Reference!=null&&r.ArrayObject(a[0]).Items.Any(v=>r.NativeEqual(a[1],v))?1:0)));
            StandardBind("java/lang/System","arraycopy","(Ljava/lang/Object;ILjava/lang/Object;II)V",(r,s,a)=>
            {
                var fromObj=r.NonNull(a[0]);var toObj=r.NonNull(a[2]);if(!(fromObj is JArray from)||!(toObj is JArray to))throw r.Fault("java/lang/ArrayStoreException");
                bool fromPrimitive=from.Component[0]!='L'&&from.Component[0]!='[',toPrimitive=to.Component[0]!='L'&&to.Component[0]!='[';
                if((fromPrimitive||toPrimitive)&&from.Component!=to.Component)throw r.Fault("java/lang/ArrayStoreException");
                int start=a[1].Int,dest=a[3].Int,count=a[4].Int;if(count<0||start<0||dest<0||start>from.Items.Length-count||dest>to.Items.Length-count)throw r.Fault("java/lang/ArrayIndexOutOfBoundsException");
                var copy=new JValue[count];Array.Copy(from.Items,start,copy,0,count);for(int i=0;i<count;i++)r.ArrayStore(a[2],dest+i,copy[i]);return Done();
            });
            foreach(string component in new[]{"B","C","D","F","I","J","S","Z"})StandardBind("java/util/Arrays","equals","(["+component+"["+component+")Z",(r,s,a)=>
            {if(ReferenceEquals(a[0].Reference,a[1].Reference))return Done(JValue.I(1));if(a[0].Reference==null||a[1].Reference==null)return Done(JValue.I(0));var x=r.ArrayObject(a[0]).Items;var y=r.ArrayObject(a[1]).Items;if(x.Length!=y.Length)return Done(JValue.I(0));for(int i=0;i<x.Length;i++)if(x[i].Bits!=y[i].Bits&&!(component=="D"&&double.IsNaN(x[i].Double)&&double.IsNaN(y[i].Double))&&!(component=="F"&&float.IsNaN(x[i].Float)&&float.IsNaN(y[i].Float)))return Done(JValue.I(0));return Done(JValue.I(1));});
            foreach(string component in new[]{"J","Ljava/lang/Object;"})StandardBind("java/util/Arrays","copyOf","(["+component+"I)["+component,(r,s,a)=>{var source=r.ArrayObject(a[0]);var copy=r.NewArray(source.Component,a[1].Int);Array.Copy(source.Items,copy.Items,Math.Min(copy.Items.Length,source.Items.Length));return Done(JValue.R(copy));});
            foreach(string component in new[]{"B","Ljava/lang/Object;"})StandardBind("java/util/Arrays","copyOfRange","(["+component+"II)["+component,(r,s,a)=>{var source=r.ArrayObject(a[0]);int from=a[1].Int,to=a[2].Int;if(from>to)throw r.Fault("java/lang/IllegalArgumentException");if(from<0||from>source.Items.Length)throw r.Fault("java/lang/ArrayIndexOutOfBoundsException");var copy=r.NewArray(source.Component,to-from);Array.Copy(source.Items,from,copy.Items,0,Math.Min(copy.Items.Length,source.Items.Length-from));return Done(JValue.R(copy));});
            foreach(string component in new[]{"B","Ljava/lang/Object;"})StandardBind("java/util/Arrays","fill","(["+component+component+")V",(r,s,a)=>{var arr=r.ArrayObject(a[0]);for(int i=0;i<arr.Items.Length;i++)r.ArrayStore(a[0],i,a[1]);return Done();});
            StandardBind("java/util/Arrays","fill","([Ljava/lang/Object;IILjava/lang/Object;)V",(r,s,a)=>{int length=r.ArrayLength(a[0]),from=a[1].Int,to=a[2].Int;if(from>to)throw r.Fault("java/lang/IllegalArgumentException");if(from<0||to>length)throw r.Fault("java/lang/ArrayIndexOutOfBoundsException");for(int i=from;i<to;i++)r.ArrayStore(a[0],i,a[3]);return Done();});
            StandardBind("java/util/Arrays","sort","([I)V",(r,s,a)=>{Array.Sort(r.ArrayObject(a[0]).Items,(x,y)=>x.Int.CompareTo(y.Int));return Done();});
            StandardBind("java/util/Arrays","binarySearch","([BB)I",(r,s,a)=>{var values=r.ArrayObject(a[0]).Items;int low=0,high=values.Length-1;while(low<=high){int mid=(low+high)>>>1;int compare=values[mid].Int.CompareTo(a[1].Int);if(compare<0)low=mid+1;else if(compare>0)high=mid-1;else return Done(JValue.I(mid));}return Done(JValue.I(-low-1));});
        }
        private void InstallCollectionOperations()
        {
            foreach(string type in new[]{"java/util/ArrayList","java/util/LinkedList","java/util/HashSet","java/util/LinkedHashSet","java/util/EnumSet","java/util/TreeSet"})StandardBind(type,"toString","()Ljava/lang/String;",(r,s,a)=>{var parts=new List<string>();foreach(var item in r.ListItems(s)){if(item.Reference==null)parts.Add("null");else if(ReferenceEquals(item.Reference,s.Reference))parts.Add("(this Collection)");else{var text=r.InlineCall("java/lang/Object","toString","()Ljava/lang/String;",item,Array.Empty<JValue>());parts.Add(text.Reference==null?"null":r.Text(text));}}return Done(JValue.R(r.String("["+string.Join(", ",parts)+"]")));});
            StandardBind("java/util/EnumSet","of","(Ljava/lang/Enum;[Ljava/lang/Enum;)Ljava/util/EnumSet;",(r,s,a)=>{var set=new JavaList{Unique=true,EnumClass=r.NonNull(a[0]).ClassName};r.AddNative(set,a[0]);foreach(var v in r.ArrayObject(a[1]).Items)r.AddNative(set,v);return Done(JValue.R(r.HostObject("java/util/EnumSet",set)));});
            StandardBind("java/util/EnumSet","allOf","(Ljava/lang/Class;)Ljava/util/EnumSet;",(r,s,a)=>{string type=r.EnumType(a[0]);return r.AfterClassInit(type,t=>{var set=new JavaList{Unique=true,EnumClass=type};foreach(var v in t.EnumValues(type))t.AddNative(set,v);return JValue.R(t.HostObject("java/util/EnumSet",set));});});
            StandardBind("java/util/EnumSet","range","(Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;",(r,s,a)=>{string type=r.NonNull(a[0]).ClassName;r.NonNull(a[1]);while(r.Program.Classes.TryGetValue(type,out var cls)&&cls.Super!="java/lang/Enum")type=cls.Super;if(!r.IsInstance(a[1].Reference,type))throw r.Fault("java/lang/ClassCastException");int from=r.NonNull(a[0]).Fields["java/lang/Enum.ordinal:I"].Int,to=r.NonNull(a[1]).Fields["java/lang/Enum.ordinal:I"].Int;if(from>to)throw r.Fault("java/lang/IllegalArgumentException");var set=new JavaList{Unique=true,EnumClass=type};foreach(var value in r.EnumValues(type).Skip(from).Take(to-from+1))r.AddNative(set,value);return Done(JValue.R(r.HostObject("java/util/EnumSet",set)));});
            StandardBind("java/util/EnumSet","copyOf","(Ljava/util/EnumSet;)Ljava/util/EnumSet;",(r,s,a)=>{var original=r.HostPayload<JavaList>(a[0]);var set=new JavaList{Unique=true,EnumClass=original.EnumClass};foreach(var v in original.Values)r.AddNative(set,v);return Done(JValue.R(r.HostObject("java/util/EnumSet",set)));});
            StandardBind("java/util/EnumSet","copyOf","(Ljava/util/Collection;)Ljava/util/EnumSet;",(r,s,a)=>{var values=r.ListItems(a[0]);string? type=(r.NonNull(a[0]).Payload as JavaList)?.EnumClass;if(type==null){if(values.Length==0)throw r.Fault("java/lang/IllegalArgumentException");type=r.NonNull(values[0]).ClassName;}var set=new JavaList{Unique=true,EnumClass=type};foreach(var v in values)r.AddNative(set,v);return Done(JValue.R(r.HostObject("java/util/EnumSet",set)));});
            StandardBind("com/google/common/collect/Sets","newEnumSet","(Ljava/lang/Iterable;Ljava/lang/Class;)Ljava/util/EnumSet;",(r,s,a)=>{var set=new JavaList{Unique=true,EnumClass=r.EnumType(a[1])};foreach(var v in r.ListItems(a[0]))r.AddNative(set,v);return Done(JValue.R(r.HostObject("java/util/EnumSet",set)));});
            StandardBind("com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;",(r,s,a)=>r.CollectIterable(a[0],(t,v)=>t.ListOf(v)));
            StandardBind("java/util/ArrayList","<init>","(I)V",(r,s,a)=>{if(a[0].Int<0)throw r.Fault("java/lang/IllegalArgumentException");var o=r.NonNull(s);o.Payload=new JavaList{Storage=new ListStorage{Values=new List<JValue>(a[0].Int)}};o.HostStorage=true;return Done();});
            StandardBind("java/util/ArrayList","ensureCapacity","(I)V",(r,s,a)=>{var list=r.HostPayload<JavaList>(s);r.Mutable(list);if(!(list.Values is List<JValue> values))throw new PortGap("ArrayList capacity requires owned storage");if(a[0].Int>values.Capacity){values.Capacity=a[0].Int;list.Version++;}return Done();});
            NativeClass("java/util/Stack","java/util/AbstractList","java/util/List");
            foreach(string type in new[]{"java/util/ArrayDeque","java/util/Deque","java/util/Queue"})NativeClass(type,"java/util/AbstractCollection");
            foreach(string type in new[]{"java/util/Stack","java/util/ArrayDeque"})StandardBind(type,"<init>","()V",(r,s,a)=>{var o=r.NonNull(s);o.Payload=new JavaList();o.HostStorage=true;return Done();});
            var owners=new[]{"java/util/List","java/util/ArrayList","java/util/LinkedList","java/util/Collection","java/util/Set","java/util/HashSet","java/util/LinkedHashSet","java/util/Stack","java/util/Deque","java/util/Queue","java/util/ArrayDeque"};
            foreach(string owner in owners)
            {
                StandardBind(owner,"size","()I",(r,s,a)=>Done(JValue.I(r.HostPayload<JavaList>(s).Values.Count)));
                StandardBind(owner,"isEmpty","()Z",(r,s,a)=>Done(JValue.I(r.HostPayload<JavaList>(s).Values.Count==0?1:0)));
                StandardBind(owner,"clear","()V",(r,s,a)=>{var list=r.HostPayload<JavaList>(s);r.Mutable(list);list.Values.Clear();list.Version++;return Done();});
                StandardBind(owner,"iterator","()Ljava/util/Iterator;",(r,s,a)=>Done(JValue.R(r.HostObject("aot/Iterator",new JavaIterator(r.HostPayload<JavaList>(s))))));
                StandardBind(owner,"remove","(Ljava/lang/Object;)Z",(r,s,a)=>{var list=r.HostPayload<JavaList>(s);r.Mutable(list);for(int i=0;i<list.Values.Count;i++)if(r.NativeEqual(list.Values[i],a[0])){list.Values.RemoveAt(i);list.Version++;return Done(JValue.I(1));}return Done(JValue.I(0));});
                StandardBind(owner,"containsAll","(Ljava/util/Collection;)Z",(r,s,a)=>Done(JValue.I(r.ListItems(a[0]).All(x=>r.ListItems(s).Any(y=>r.NativeEqual(x,y)))?1:0)));
                StandardBind(owner,"toArray","([Ljava/lang/Object;)[Ljava/lang/Object;",(r,s,a)=>{var values=r.ListItems(s);var dest=r.ArrayObject(a[0]);if(dest.Items.Length<values.Length)dest=r.NewArray(dest.Component,values.Length);for(int i=0;i<values.Length;i++)r.ArrayStore(JValue.R(dest),i,values[i]);if(dest.Items.Length>values.Length)dest.Items[values.Length]=JValue.R(null);return Done(JValue.R(dest));});
                foreach(bool retain in new[]{false,true})StandardBind(owner,retain?"retainAll":"removeAll","(Ljava/util/Collection;)Z",(r,s,a)=>{var list=r.HostPayload<JavaList>(s);r.Mutable(list);var other=r.ListItems(a[0]);bool changed=false;for(int i=list.Values.Count-1;i>=0;i--)if(other.Any(v=>r.NativeEqual(list.Values[i],v))!=retain){list.Values.RemoveAt(i);list.Version++;changed=true;}return Done(JValue.I(changed?1:0));});
            }
            foreach(string owner in new[]{"java/util/List","java/util/ArrayList","java/util/LinkedList","java/util/Stack"})
            {
                StandardBind(owner,"remove","(I)Ljava/lang/Object;",(r,s,a)=>{var list=r.HostPayload<JavaList>(s);r.Mutable(list);r.ListBounds(list,a[0].Int);var value=list.Values[a[0].Int];list.Values.RemoveAt(a[0].Int);list.Version++;return Done(value);});
                foreach(bool last in new[]{false,true})StandardBind(owner,last?"lastIndexOf":"indexOf","(Ljava/lang/Object;)I",(r,s,a)=>{var list=r.HostPayload<JavaList>(s);for(int n=0;n<list.Values.Count;n++){int i=last?list.Values.Count-n-1:n;if(r.NativeEqual(list.Values[i],a[0]))return Done(JValue.I(i));}return Done(JValue.I(-1));});
            }
            StandardBind("java/util/Stack","empty","()Z",(r,s,a)=>Done(JValue.I(r.HostPayload<JavaList>(s).Values.Count==0?1:0)));
            StandardBind("java/util/Stack","push","(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{r.AddNative(r.HostPayload<JavaList>(s),a[0]);return Done(a[0]);});
            foreach(bool pop in new[]{false,true})StandardBind("java/util/Stack",pop?"pop":"peek","()Ljava/lang/Object;",(r,s,a)=>{var list=r.HostPayload<JavaList>(s);int at=list.Values.Count-1;if(at<0)throw r.Fault("java/util/EmptyStackException");var value=list.Values[at];if(pop){r.Mutable(list);list.Values.RemoveAt(at);list.Version++;}return Done(value);});
            foreach(string iteratorOwner in new[]{"java/util/Iterator","aot/Iterator"})StandardBind(iteratorOwner,"remove","()V",(r,s,a)=>{var it=r.HostPayload<JavaIterator>(s);r.CheckIterator(it);if(it.Last<0)throw r.Fault("java/lang/IllegalStateException");r.Mutable(it.List);it.List.Values.RemoveAt(it.Last);it.List.Version++;it.Version=it.List.Version;it.At=it.Last-(it.Reverse?1:0);it.Last=-1;return Done();});
            StandardBind("java/util/Collections","emptySet","()Ljava/util/Set;",(r,s,a)=>Done(r.ListOf(Array.Empty<JValue>(),"java/util/HashSet",true)));
            StandardBind("java/util/Collections","singleton","(Ljava/lang/Object;)Ljava/util/Set;",(r,s,a)=>Done(r.ListOf(a,"java/util/HashSet",true)));
            StandardBind("java/util/Collections","emptyIterator","()Ljava/util/Iterator;",(r,s,a)=>Done(JValue.R(r.HostObject("aot/Iterator",new JavaIterator(new JavaList{Immutable=true})))));
            StandardBind("java/util/Collections","emptyMap","()Ljava/util/Map;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/HashMap",new JavaMap{Immutable=true}))));
            StandardBind("java/util/Collections","singletonMap","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;",(r,s,a)=>{var map=new JavaMap();r.PutNativeMap(map,a[0],a[1]);map.Immutable=true;return Done(JValue.R(r.HostObject("java/util/HashMap",map)));});
            StandardBind("java/util/Collections","nCopies","(ILjava/lang/Object;)Ljava/util/List;",(r,s,a)=>{if(a[0].Int<0)throw r.Fault("java/lang/IllegalArgumentException");return Done(r.ListOf(Enumerable.Repeat(a[1],a[0].Int),immutable:true));});
            StandardBind("java/util/Collections","addAll","(Ljava/util/Collection;[Ljava/lang/Object;)Z",(r,s,a)=>{bool changed=false;var list=r.HostPayload<JavaList>(a[0]);foreach(var value in r.ArrayObject(a[1]).Items)changed|=r.AddNative(list,value);return Done(JValue.I(changed?1:0));});
            StandardBind("java/util/Collections","frequency","(Ljava/util/Collection;Ljava/lang/Object;)I",(r,s,a)=>Done(JValue.I(r.ListItems(a[0]).Count(v=>r.NativeEqual(v,a[1])))));
            StandardBind("java/util/Collections","disjoint","(Ljava/util/Collection;Ljava/util/Collection;)Z",(r,s,a)=>Done(JValue.I(r.ListItems(a[0]).Any(x=>r.ListItems(a[1]).Any(y=>r.NativeEqual(x,y)))?0:1)));
            StandardBind("java/util/Collections","reverse","(Ljava/util/List;)V",(r,s,a)=>{var copy=r.ListItems(a[0]);for(int i=0,j=copy.Length-1;i<j;i++,j--){r.InlineCall("java/util/List","set","(ILjava/lang/Object;)Ljava/lang/Object;",a[0],new[]{JValue.I(i),copy[j]});r.InlineCall("java/util/List","set","(ILjava/lang/Object;)Ljava/lang/Object;",a[0],new[]{JValue.I(j),copy[i]});}return Done();});
            StandardBind("java/util/Collections","rotate","(Ljava/util/List;I)V",(r,s,a)=>{var copy=r.ListItems(a[0]);if(copy.Length>0){int by=a[1].Int%copy.Length;if(by<0)by+=copy.Length;if(by!=0)for(int i=0;i<copy.Length;i++)r.InlineCall("java/util/List","set","(ILjava/lang/Object;)Ljava/lang/Object;",a[0],new[]{JValue.I((i+by)%copy.Length),copy[i]});}return Done();});
            StandardBind("java/util/Collections","unmodifiableCollection","(Ljava/util/Collection;)Ljava/util/Collection;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/ArrayList",new JavaList{Storage=r.HostPayload<JavaList>(a[0]).Storage,Immutable=true}))));
        }
        private JHostResult CollectIterable(JValue iterable,Func<JRuntime,JValue[],JValue> finish)
        {
            if(NonNull(iterable).Payload is JavaList)return Done(finish(this,ListItems(iterable)));
            var values=new List<JValue>();JValue iterator=default;
            var method=new JMethod(-98,"java/lang/Object","<collect-iterable>","()Ljava/lang/Object;",8,0,3,Array.Empty<JHandler>(),(r,f)=>
            {
                if(!r.Tick())return JStep.Yield;
                if(f.Pc==0){f.Push(iterable);f.Pc=10;}
                if(f.Pc==10)return r.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",1);
                if(f.Pc==1){iterator=f.Pop();f.Pc=2;}
                if(f.Pc==2){f.Push(iterator);f.Pc=20;}
                if(f.Pc==20)return r.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",3);
                if(f.Pc==3){if(f.Pop().Int==0)return JStep.Return(finish(r,values.ToArray()));f.Push(iterator);f.Pc=30;}
                if(f.Pc==30)return r.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",4);
                values.Add(f.Pop());f.Pc=2;return JStep.Continue;
            });return JHostResult.Schedule(new JFrame(method,default,Array.Empty<JValue>()));
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Planeswalker.ForgeAot
{
    // Native .NET storage with Java-facing bounds/EOF/null behavior. Unknown APIs remain PortGap.
    public sealed partial class JRuntime
    {
        public interface IJavaIdentity { string JavaIdentity { get; } }
        private sealed class ListStorage
        {internal IList<JValue> Values=new List<JValue>();internal int Version;internal Func<int>? ExternalVersion;}
        private sealed class JavaList
        {
            internal ListStorage Storage=new ListStorage();
            internal IList<JValue> Values=>Storage.Values;
            internal int Version {get=>Storage.ExternalVersion?.Invoke()??Storage.Version;set{if(Storage.ExternalVersion==null)Storage.Version=value;}}
            internal bool Immutable,FixedSize,Unique,Sorted;internal JValue Comparator;internal string? EnumClass;
        }
        private sealed class JavaIterator
        {internal readonly JavaList List;internal int At,Last=-1,Version;internal bool Reverse;internal JavaIterator(JavaList list){List=list;Version=list.Version;}}
        private sealed class MapStorage {internal readonly List<KeyValuePair<JValue,JValue>> Entries=new List<KeyValuePair<JValue,JValue>>();internal int Version;}
        private sealed class JavaMap
        {internal MapStorage Storage=new MapStorage();internal List<KeyValuePair<JValue,JValue>> Entries=>Storage.Entries;internal bool Immutable,Sorted,CaseInsensitive,Concurrent,Identity;internal string? EnumClass;internal JavaMap? Inverse;internal JObject? Handle;}
        private sealed class AsciiCaseComparator { }
        private sealed class JavaPair {internal JValue Left,Right;internal JavaPair(JValue left,JValue right){Left=left;Right=right;}}
        private sealed class JavaMapKeys : IList<JValue>
        {
            private readonly JRuntime runtime;private readonly JavaMap map;private readonly bool keys;
            internal JavaMap Map=>map;
            internal JavaMapKeys(JRuntime runtime,JavaMap map,bool keys=true){this.runtime=runtime;this.map=map;this.keys=keys;}
            public JValue this[int index]{get=>keys?map.Entries[index].Key:map.Entries[index].Value;set=>throw runtime.Fault("java/lang/UnsupportedOperationException");}
            public int Count=>map.Entries.Count;public bool IsReadOnly=>map.Immutable;
            public void Add(JValue value)=>throw runtime.Fault("java/lang/UnsupportedOperationException");
            public void Insert(int index,JValue value)=>Add(value);
            public void Clear(){if(map.Immutable)throw runtime.Fault("java/lang/UnsupportedOperationException");while(map.Entries.Count>0)runtime.RemoveMapAt(map,map.Entries.Count-1);}
            public bool Contains(JValue value)=>IndexOf(value)>=0;
            public int IndexOf(JValue value){if(keys)return runtime.MapIndex(map,value);for(int i=0;i<map.Entries.Count;i++)if(runtime.NativeEqual(map.Entries[i].Value,value))return i;return -1;}
            public bool Remove(JValue value){int at=IndexOf(value);if(at<0)return false;RemoveAt(at);return true;}
            public void RemoveAt(int index){if(map.Immutable)throw runtime.Fault("java/lang/UnsupportedOperationException");runtime.RemoveMapAt(map,index);}
            public void CopyTo(JValue[] array,int index){foreach(var entry in map.Entries)array[index++]=keys?entry.Key:entry.Value;}
            public IEnumerator<JValue> GetEnumerator(){foreach(var entry in map.Entries)yield return keys?entry.Key:entry.Value;}
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()=>GetEnumerator();
        }
        private sealed class JavaTable {internal readonly List<(JValue Row,JValue Column,JValue Value)> Entries=new List<(JValue,JValue,JValue)>();internal bool Sorted;}
        private readonly Dictionary<int,JObject> integerCache=new Dictionary<int,JObject>();
        private void NativeClass(string name,string parent="java/lang/Object",params string[] interfaces)
        {if(!Program.Classes.ContainsKey(name))Program.Add(new JClass(name,parent,interfaces,1));}
        private void StandardBind(string owner,string name,string descriptor,Func<JRuntime,JValue,JValue[],JHostResult> fn)
        {if(!bindings.ContainsKey(owner+"."+name+descriptor))Bind(owner,name,descriptor,fn);}
        public JValue ListOf(IEnumerable<JValue> values,string type="java/util/ArrayList",bool immutable=false)
        {var list=new JavaList{Immutable=immutable};foreach(var value in values)list.Values.Add(value);return JValue.R(HostObject(type,list));}
        public JValue[] ListItems(JValue value)
        {
            if(NonNull(value).Payload is JavaList list){var result=new JValue[list.Values.Count];list.Values.CopyTo(result,0);return result;}
            var iterator=InlineCall("java/lang/Iterable","iterator","()Ljava/util/Iterator;",value,Array.Empty<JValue>());var values=new List<JValue>();
            while(InlineCall("java/util/Iterator","hasNext","()Z",iterator,Array.Empty<JValue>()).Int!=0)
            {if(values.Count>=1000000)throw new PortGap("Collection materialization exceeds development runtime bound");values.Add(InlineCall("java/util/Iterator","next","()Ljava/lang/Object;",iterator,Array.Empty<JValue>()));}
            return values.ToArray();
        }
        public JValue MapOf(IEnumerable<KeyValuePair<JValue,JValue>> entries)
        {var map=new JavaMap();foreach(var entry in entries)PutNativeMap(map,entry.Key,entry.Value);return JValue.R(HostObject("java/util/HashMap",map));}
        public KeyValuePair<JValue,JValue>[] MapItems(JValue value)
        {
            if(NonNull(value).Payload is JavaMap map)return map.Entries.ToArray();
            var entries=InlineCall("java/util/Map","entrySet","()Ljava/util/Set;",value,Array.Empty<JValue>());var pairs=new List<KeyValuePair<JValue,JValue>>();
            foreach(var entry in ListItems(entries))pairs.Add(new KeyValuePair<JValue,JValue>(InlineCall("java/util/Map$Entry","getKey","()Ljava/lang/Object;",entry,Array.Empty<JValue>()),InlineCall("java/util/Map$Entry","getValue","()Ljava/lang/Object;",entry,Array.Empty<JValue>())));
            return pairs.ToArray();
        }
        public (JValue Row,JValue Column,JValue Value)[] TableRows(JValue table)
        {
            if(NonNull(table).Payload is JavaTable native)return native.Entries.ToArray();
            var cells=InlineCall("com/google/common/collect/Table","cellSet","()Ljava/util/Set;",table,Array.Empty<JValue>());
            return ListItems(cells).Select(cell=>(InlineCall("com/google/common/collect/Table$Cell","getRowKey","()Ljava/lang/Object;",cell,Array.Empty<JValue>()),InlineCall("com/google/common/collect/Table$Cell","getColumnKey","()Ljava/lang/Object;",cell,Array.Empty<JValue>()),InlineCall("com/google/common/collect/Table$Cell","getValue","()Ljava/lang/Object;",cell,Array.Empty<JValue>()))).ToArray();
        }
        private bool NativeEqual(JValue a,JValue b)
        {
            if(a.Kind!=JKind.Reference||b.Kind!=JKind.Reference)return a.Kind==b.Kind&&a.Bits==b.Bits;
            if(ReferenceEquals(a.Reference,b.Reference))return true;if(a.Reference==null||b.Reference==null)return false;
            if(a.Reference.ClassName=="java/lang/String"&&b.Reference.ClassName=="java/lang/String")return Text(a)==Text(b);
            if(a.Reference.Payload is IJavaIdentity ai&&b.Reference.Payload is IJavaIdentity bi)return ai.JavaIdentity==bi.JavaIdentity;
            if(a.Reference.Payload is JavaPair ap&&b.Reference.Payload is JavaPair bp)return NativeEqual(ap.Left,bp.Left)&&NativeEqual(ap.Right,bp.Right);
            if(a.Reference.Payload is TripleValue at&&b.Reference.Payload is TripleValue bt)return at.Values.Zip(bt.Values,(x,y)=>NativeEqual(x,y)).All(v=>v);
            if(a.Reference.Payload is JavaList){if(IsInstance(a.Reference,"java/util/List"))return SequenceEquals(a,b,false);if(IsInstance(a.Reference,"java/util/Set"))return SequenceEquals(a,b,true);}
            if(a.Reference.Boxed.HasValue&&b.Reference.Boxed.HasValue)return a.Reference.ClassName==b.Reference.ClassName&&a.Reference.Boxed.Value.Bits==b.Reference.Boxed.Value.Bits;
            // Native classes have bindings but no generated JMethod body. Honor
            // their value equality when they are map/table keys as well.
            if(a.Reference.ClassName!="java/lang/Object"&&bindings.ContainsKey(a.Reference.ClassName+".equals(Ljava/lang/Object;)Z"))return InlineCall("java/lang/Object","equals","(Ljava/lang/Object;)Z",a,new[]{b}).Int!=0;
            var method=Resolve(a.Reference.ClassName,"equals","(Ljava/lang/Object;)Z");
            if(method!=null&&method.Owner!="java/lang/Object")return InlineCall("java/lang/Object","equals","(Ljava/lang/Object;)Z",a,new[]{b}).Int!=0;
            return false;
        }
        private int MapIndex(JavaMap map,JValue key){if(map.Concurrent)NonNull(key);if(map.EnumClass!=null&&(key.Reference==null||!IsInstance(key.Reference,map.EnumClass)))return -1;if(map.Sorted){NonNull(key);for(int i=0;i<map.Entries.Count;i++)if(CompareMapKeys(map,map.Entries[i].Key,key)==0)return i;return -1;}for(int i=0;i<map.Entries.Count;i++)if(map.Identity?ReferenceEquals(map.Entries[i].Key.Reference,key.Reference):NativeEqual(map.Entries[i].Key,key))return i;return -1;}
        private void Mutable(JavaList list,bool structural=true){if(list.Immutable||structural&&list.FixedSize)throw Fault("java/lang/UnsupportedOperationException");}
        private void CheckIterator(JavaIterator it){if(it.Version!=it.List.Version)throw Fault("java/util/ConcurrentModificationException");}
        private static JHostResult Done(JValue value=default)=>JHostResult.Complete(value);
        private void InstallStandardLibrary()
        {
            NativeClass("java/lang/Object","");NativeClass("java/lang/Enum");NativeClass("java/lang/Number","java/lang/Object","java/io/Serializable");NativeClass("java/lang/Integer","java/lang/Number","java/lang/Comparable");
            NativeClass("java/lang/Comparable");NativeClass("java/io/Serializable");NativeClass("java/lang/Cloneable");NativeClass("java/util/Map");
            NativeClass("java/lang/CharSequence");NativeClass("java/lang/String","java/lang/Object","java/lang/CharSequence","java/lang/Comparable","java/io/Serializable");NativeClass("java/lang/StringBuilder","java/lang/Object","java/lang/CharSequence");
            NativeClass("java/lang/Class");
            NativeClass("java/util/Comparator");var caseComparator=JValue.R(HostObject("java/util/Comparator",new AsciiCaseComparator()));
            NativeClass("java/util/Map$Entry");NativeClass("aot/MapEntry","java/lang/Object","java/util/Map$Entry");
            foreach(string method in new[]{"getKey","getValue"}){string captured=method;StandardBind("aot/MapEntry",method,"()Ljava/lang/Object;",(r,s,a)=>{var entry=r.HostPayload<KeyValuePair<JValue,JValue>>(s);return Done(captured=="getKey"?entry.Key:entry.Value);});}
            BindStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;",()=>caseComparator);
            // The development runtime has Java assertions disabled, equivalent to the default JVM mode.
            StandardBind("java/lang/Class","desiredAssertionStatus","()Z",(r,s,a)=>Done(JValue.I(0)));
            NativeClass("java/lang/Iterable");NativeClass("java/util/Collection","java/lang/Object","java/lang/Iterable");
            NativeClass("java/util/List","java/lang/Object","java/util/Collection");NativeClass("java/util/Set","java/lang/Object","java/util/Collection");
            NativeClass("java/util/AbstractCollection","java/lang/Object","java/util/Collection");NativeClass("java/util/AbstractList","java/util/AbstractCollection","java/util/List");
            NativeClass("java/util/RandomAccess");NativeClass("java/util/ArrayList","java/util/AbstractList","java/util/List","java/util/RandomAccess");NativeClass("java/util/LinkedList","java/util/AbstractList","java/util/List");
            const string snapshotList="java/util/concurrent/CopyOnWriteArrayList";
            NativeClass(snapshotList,"java/lang/Object","java/util/List","java/util/RandomAccess");
            StandardBind(snapshotList,"<init>","()V",(r,s,a)=>{
                var obj=r.NonNull(s);obj.Payload=new JavaList();obj.HostStorage=true;return Done();
            });
            StandardBind(snapshotList,"iterator","()Ljava/util/Iterator;",(r,s,a)=>{
                var snapshot=r.ListOf(r.HostPayload<JavaList>(s).Values.ToArray(),immutable:true);
                return Done(JValue.R(r.HostObject("aot/Iterator",new JavaIterator(r.HostPayload<JavaList>(snapshot)))));
            });
            NativeClass("java/util/HashSet","java/util/AbstractCollection","java/util/Set");NativeClass("java/util/EnumSet","java/util/AbstractCollection","java/util/Set");
            NativeClass("java/util/LinkedHashSet","java/util/HashSet","java/util/Set");
            NativeClass("com/google/common/collect/ImmutableSet","java/util/AbstractCollection","java/util/Set");
            NativeClass("java/util/Iterator");NativeClass("aot/Iterator","java/lang/Object","java/util/Iterator");
            NativeClass("java/util/function/Function");NativeClass("java/util/function/BiConsumer");NativeClass("aot/MapValues","java/util/AbstractCollection","java/util/Collection");
            foreach(string type in new[]{"java/util/HashMap","java/util/LinkedHashMap","java/util/EnumMap"})NativeClass(type,"java/lang/Object","java/util/Map");
            NativeClass("java/util/TreeMap","java/lang/Object","java/util/Map");
            NativeClass("java/util/concurrent/ConcurrentMap","java/lang/Object","java/util/Map");NativeClass("java/util/concurrent/ConcurrentHashMap","java/lang/Object","java/util/concurrent/ConcurrentMap");
            NativeClass("aot/SynchronizedMap","java/lang/Object","java/util/Map");
            NativeClass("com/google/common/collect/BiMap","java/lang/Object","java/util/Map");NativeClass("com/google/common/collect/HashBiMap","java/util/HashMap","com/google/common/collect/BiMap");
            StandardBind("com/google/common/collect/HashBiMap","create","()Lcom/google/common/collect/HashBiMap;",(r,s,a)=>{var map=new JavaMap();var inverse=new JavaMap{Inverse=map};map.Inverse=inverse;map.Handle=r.HostObject("com/google/common/collect/HashBiMap",map);inverse.Handle=r.HostObject("com/google/common/collect/HashBiMap",inverse);return Done(JValue.R(map.Handle));});
            StandardBind("com/google/common/collect/HashBiMap","inverse","()Lcom/google/common/collect/BiMap;",(r,s,a)=>Done(JValue.R((r.HostPayload<JavaMap>(s).Inverse??throw new PortGap("Not a bidirectional map")).Handle)));
            foreach(string type in new[]{"com/google/common/collect/ForwardingTable","com/google/common/collect/Table","com/google/common/collect/HashBasedTable"})NativeClass(type);
            StandardBind("com/google/common/collect/ForwardingTable","<init>","()V",(r,s,a)=>Done());
            StandardBind("com/google/common/collect/HashBasedTable","create","()Lcom/google/common/collect/HashBasedTable;",(r,s,a)=>Done(JValue.R(r.HostObject("com/google/common/collect/HashBasedTable",new JavaTable()))));
            StandardBind("com/google/common/collect/HashBasedTable","create","(Lcom/google/common/collect/Table;)Lcom/google/common/collect/HashBasedTable;",(r,s,a)=>{var copy=new JavaTable();copy.Entries.AddRange(r.TableRows(a[0]));return Done(JValue.R(r.HostObject("com/google/common/collect/HashBasedTable",copy)));});
            NativeClass("com/google/common/collect/TreeBasedTable");StandardBind("com/google/common/collect/TreeBasedTable","create","()Lcom/google/common/collect/TreeBasedTable;",(r,s,a)=>Done(JValue.R(r.HostObject("com/google/common/collect/TreeBasedTable",new JavaTable{Sorted=true}))));
            StandardBind("com/google/common/collect/TreeBasedTable","create","(Lcom/google/common/collect/TreeBasedTable;)Lcom/google/common/collect/TreeBasedTable;",(r,s,a)=>{var original=r.HostPayload<JavaTable>(a[0]);if(!original.Sorted)throw new PortGap("TreeBasedTable requires ordered source");var copy=new JavaTable{Sorted=true};copy.Entries.AddRange(original.Entries);return Done(JValue.R(r.HostObject("com/google/common/collect/TreeBasedTable",copy)));});
            StandardBind("com/google/common/collect/TreeBasedTable","row","(Ljava/lang/Object;)Ljava/util/SortedMap;",(r,s,a)=>{
                r.NonNull(a[0]);
                return Done(r.TableAxisMap(r.HostPayload<JavaTable>(s),a[0],true));
            });
            foreach(string owner in new[]{"com/google/common/collect/Table","com/google/common/collect/HashBasedTable","com/google/common/collect/ForwardingTable","com/google/common/collect/TreeBasedTable"})
            {
                string capturedOwner=owner;
                StandardBind(owner,"values","()Ljava/util/Collection;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/ArrayList",new JavaList{Storage=new ListStorage{Values=new TableValues(r,r.TablePayload(s,capturedOwner))}}))));
                foreach(bool rows in new[]{false,true})StandardBind(owner,rows?"rowMap":"columnMap","()Ljava/util/Map;",(r,s,a)=>Done(r.TableOuterMap(r.TablePayload(s,capturedOwner),rows)));
                foreach(bool rows in new[]{false,true})StandardBind(owner,rows?"rowKeySet":"columnKeySet","()Ljava/util/Set;",(r,s,a)=>Done(r.InlineCall("java/util/Map","keySet","()Ljava/util/Set;",r.TableOuterMap(r.TablePayload(s,capturedOwner),rows),Array.Empty<JValue>())));
                foreach(bool row in new[]{false,true})
                {
                    StandardBind(owner,row?"row":"column","(Ljava/lang/Object;)Ljava/util/Map;",(r,s,a)=>{r.NonNull(a[0]);return Done(r.TableAxisMap(r.TablePayload(s,capturedOwner),a[0],row));});
                    StandardBind(owner,row?"containsRow":"containsColumn","(Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(r.TablePayload(s,capturedOwner).Entries.Any(e=>r.NativeEqual(row?e.Row:e.Column,a[0]))?1:0)));
                }
                StandardBind(owner,"cellSet","()Ljava/util/Set;",(r,s,a)=>Done(r.TableCellSet(r.TablePayload(s,capturedOwner))));
                StandardBind(owner,"size","()I",(r,s,a)=>Done(JValue.I(r.TablePayload(s,capturedOwner).Entries.Count)));
                StandardBind(owner,"putAll","(Lcom/google/common/collect/Table;)V",(r,s,a)=>{foreach(var cell in r.TableRows(a[0]))r.InlineCall(capturedOwner,"put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",s,new[]{cell.Row,cell.Column,cell.Value});return Done();});
                StandardBind(owner,"contains","(Ljava/lang/Object;Ljava/lang/Object;)Z",(r,s,a)=>{var table=r.TablePayload(s,capturedOwner);return Done(JValue.I(r.TableIndex(table,a[0],a[1])>=0?1:0));});
                StandardBind(owner,"get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var table=r.TablePayload(s,capturedOwner);int at=r.TableIndex(table,a[0],a[1]);return Done(at<0?JValue.R(null):table.Entries[at].Value);});
                StandardBind(owner,"remove","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var table=r.TablePayload(s,capturedOwner);int at=r.TableIndex(table,a[0],a[1]);if(at<0)return Done(default);var value=table.Entries[at].Value;table.Entries.RemoveAt(at);return Done(value);});
                StandardBind(owner,"put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{foreach(var v in a)r.NonNull(v);var table=r.TablePayload(s,capturedOwner);if(table.Sorted){r.CompareNative(a[0],a[0]);r.CompareNative(a[1],a[1]);}int at=r.TableIndex(table,a[0],a[1]);JValue old=at<0?JValue.R(null):table.Entries[at].Value;var item=(a[0],a[1],a[2]);if(at<0)table.Entries.Add(item);else table.Entries[at]=item;if(table.Sorted)table.Entries.Sort((x,y)=>{int row=r.CompareNative(x.Row,y.Row);return row!=0?row:r.CompareNative(x.Column,y.Column);});return Done(old);});
                StandardBind(owner,"isEmpty","()Z",(r,s,a)=>Done(JValue.I(r.TablePayload(s,capturedOwner).Entries.Count==0?1:0)));
                StandardBind(owner,"clear","()V",(r,s,a)=>{r.TablePayload(s,capturedOwner).Entries.Clear();return Done();});
            }
            StandardBind("java/lang/Enum","<init>","(Ljava/lang/String;I)V",(r,s,a)=>{var o=r.NonNull(s);o.Fields["java/lang/Enum.name:Ljava/lang/String;"]=a[0];o.Fields["java/lang/Enum.ordinal:I"]=a[1];return Done();});
            StandardBind("java/lang/Enum","name","()Ljava/lang/String;",(r,s,a)=>Done(r.NonNull(s).Fields["java/lang/Enum.name:Ljava/lang/String;"]));
            StandardBind("java/lang/Enum","ordinal","()I",(r,s,a)=>Done(r.NonNull(s).Fields["java/lang/Enum.ordinal:I"]));
            StandardBind("java/lang/Enum","toString","()Ljava/lang/String;",(r,s,a)=>Done(r.NonNull(s).Fields["java/lang/Enum.name:Ljava/lang/String;"]));
            StandardBind("java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;",(r,s,a)=>
            {string type=r.EnumType(a[0]),name=r.Text(a[1]);return r.AfterClassInit(type,t=>{foreach(var item in t.EnumValues(type))if(t.StringValue(t.NonNull(item).Fields["java/lang/Enum.name:Ljava/lang/String;"])==name)return item;throw t.Fault("java/lang/IllegalArgumentException","No enum constant "+type+"."+name);});});
            StandardBind("java/lang/Integer","valueOf","(I)Ljava/lang/Integer;",(r,s,a)=>Done(r.BoxInt(a[0].Int)));
            StandardBind("java/lang/Integer","intValue","()I",(r,s,a)=>Done(JValue.I(r.UnboxInt(s))));
            StandardBind("java/lang/Integer","parseInt","(Ljava/lang/String;)I",(r,s,a)=>
            {if(!int.TryParse(r.Text(a[0]),NumberStyles.AllowLeadingSign,CultureInfo.InvariantCulture,out int v))throw r.Fault("java/lang/NumberFormatException");return Done(JValue.I(v));});
            StandardBind("com/google/common/primitives/Ints","tryParse","(Ljava/lang/String;)Ljava/lang/Integer;",(r,s,a)=>
            {string text=r.Text(a[0]);bool valid=text.Length>0&&text!="-";for(int i=text.Length>0&&text[0]=='-'?1:0;i<text.Length;i++)if(text[i]<'0'||text[i]>'9')valid=false;return Done(valid&&int.TryParse(text,NumberStyles.AllowLeadingSign,CultureInfo.InvariantCulture,out int v)?r.BoxInt(v):JValue.R(null));});
            StandardBind("java/lang/Object","clone","()Ljava/lang/Object;",(r,s,a)=>
            {
                var source=r.NonNull(s);
                if(source is JArray array){var copy=r.NewArray(array.Component,array.Items.Length);Array.Copy(array.Items,copy.Items,array.Items.Length);return Done(JValue.R(copy));}
                if(!r.IsInstance(source,"java/lang/Cloneable"))throw r.Fault("java/lang/CloneNotSupportedException");
                if(source.HostStorage||source.Payload!=null)throw new PortGap("Native payload clone requires its storage-specific adapter: "+source.ClassName);
                var cloned=r.Allocate(source.ClassName);foreach(var field in source.Fields)cloned.Fields[field.Key]=field.Value;
                return Done(JValue.R(cloned));
            });
            StandardBind("java/lang/String","indexOf","(I)I",(r,s,a)=>{int cp=a[0].Int;return Done(JValue.I(cp<0||cp>0x10ffff?-1:cp<=0xffff?r.Text(s).IndexOf((char)cp):r.Text(s).IndexOf(char.ConvertFromUtf32(cp),StringComparison.Ordinal)));});
            StandardBind("java/lang/String","indexOf","(Ljava/lang/String;)I",(r,s,a)=>Done(JValue.I(r.Text(s).IndexOf(r.Text(a[0]),StringComparison.Ordinal))));
            StandardBind("java/lang/String","indexOf","(Ljava/lang/String;I)I",(r,s,a)=>{string text=r.Text(s),part=r.Text(a[0]);int start=Math.Max(0,a[1].Int);return Done(JValue.I(start>text.Length?part.Length==0?text.Length:-1:text.IndexOf(part,start,StringComparison.Ordinal)));});
            StandardBind("java/lang/String","indexOf","(II)I",(r,s,a)=>{string text=r.Text(s);int cp=a[0].Int,at=Math.Max(0,a[1].Int);return Done(JValue.I(at>=text.Length||cp<0||cp>0x10ffff?-1:cp<=0xffff?text.IndexOf((char)cp,at):text.IndexOf(char.ConvertFromUtf32(cp),at,StringComparison.Ordinal)));});
            StandardBind("java/lang/Integer","bitCount","(I)I",(r,s,a)=>{uint bits=unchecked((uint)a[0].Int);int count=0;while(bits!=0){bits&=bits-1;count++;}return Done(JValue.I(count));});
            StandardBind("java/lang/String","substring","(I)Ljava/lang/String;",(r,s,a)=>Done(JValue.R(r.NewString(r.Substring(s,a[0].Int,r.Text(s).Length)))));
            StandardBind("java/lang/String","substring","(II)Ljava/lang/String;",(r,s,a)=>Done(JValue.R(r.NewString(r.Substring(s,a[0].Int,a[1].Int)))));
            StandardBind("java/lang/String","trim","()Ljava/lang/String;",(r,s,a)=>
            {string t=r.Text(s);int l=0,h=t.Length;while(l<h&&t[l]<=32)l++;while(h>l&&t[h-1]<=32)h--;return Done(JValue.R(r.NewString(t.Substring(l,h-l))));});
            StandardBind("java/lang/String","startsWith","(Ljava/lang/String;)Z",(r,s,a)=>Done(JValue.I(r.Text(s).StartsWith(r.Text(a[0]),StringComparison.Ordinal)?1:0)));
            StandardBind("java/lang/String","endsWith","(Ljava/lang/String;)Z",(r,s,a)=>Done(JValue.I(r.Text(s).EndsWith(r.Text(a[0]),StringComparison.Ordinal)?1:0)));
            StandardBind("java/lang/String","contains","(Ljava/lang/CharSequence;)Z",(r,s,a)=>Done(JValue.I(r.Text(s).IndexOf(r.Text(a[0]),StringComparison.Ordinal)>=0?1:0)));
            StandardBind("java/lang/String","replace","(CC)Ljava/lang/String;",(r,s,a)=>Done(JValue.R(r.NewString(r.Text(s).Replace((char)a[0].Int,(char)a[1].Int)))));
            StandardBind("java/lang/String","toUpperCase","()Ljava/lang/String;",(r,s,a)=>Done(JValue.R(r.NewString(UnicodeCase.Convert(r.Text(s),true,"en")))));
            StandardBind("java/lang/String","toLowerCase","()Ljava/lang/String;",(r,s,a)=>Done(JValue.R(r.NewString(UnicodeCase.Convert(r.Text(s),false,"en")))));
            StandardBind("java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;",(r,s,a)=>
            {string value=r.Text(s),from=r.Text(a[0]),to=r.Text(a[1]);if(from.Length!=0)return Done(JValue.R(r.NewString(value.Replace(from,to))));var text=new StringBuilder(to);foreach(char c in value)text.Append(c).Append(to);return Done(JValue.R(r.NewString(text.ToString())));});
            StandardBind("java/lang/StringBuilder","<init>","()V",(r,s,a)=>{r.NonNull(s).Payload=new StringBuilder();r.NonNull(s).HostStorage=true;return Done();});
            StandardBind("java/lang/StringBuilder","append","(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;",(r,s,a)=>{string value=a[0].Reference==null?"null":r.Text(a[0]);int start=a[1].Int,end=a[2].Int;if(start<0||end<start||end>value.Length)throw r.Fault("java/lang/IndexOutOfBoundsException");r.HostPayload<StringBuilder>(s).Append(value,start,end-start);return Done(s);});
            StandardBind("java/lang/StringBuilder","<init>","(I)V",(r,s,a)=>{if(a[0].Int<0)throw r.Fault("java/lang/NegativeArraySizeException");r.NonNull(s).Payload=new StringBuilder(a[0].Int);r.NonNull(s).HostStorage=true;return Done();});
            StandardBind("java/lang/StringBuilder","<init>","(Ljava/lang/String;)V",(r,s,a)=>{r.NonNull(s).Payload=new StringBuilder(r.Text(a[0]));r.NonNull(s).HostStorage=true;return Done();});
            foreach(string t in new[]{"Ljava/lang/String;","I","J","Z","C"})
            {string type=t;StandardBind("java/lang/StringBuilder","append","("+type+")Ljava/lang/StringBuilder;",(r,s,a)=>{r.HostPayload<StringBuilder>(s).Append(r.DisplayPrimitive(a[0],type));return Done(s);});}
            StandardBind("java/lang/StringBuilder","toString","()Ljava/lang/String;",(r,s,a)=>Done(JValue.R(r.NewString(r.HostPayload<StringBuilder>(s).ToString()))));
            StandardBind("java/lang/StringBuilder","insert","(ILjava/lang/Object;)Ljava/lang/StringBuilder;",(r,s,a)=>
            {
                var builder=r.HostPayload<StringBuilder>(s);int index=a[0].Int;if(index<0||index>builder.Length)throw r.Fault("java/lang/StringIndexOutOfBoundsException");
                if(a[1].Reference==null){builder.Insert(index,"null");return Done(s);}
                if(a[1].Reference!.ClassName=="java/lang/String"){builder.Insert(index,r.Text(a[1]));return Done(s);}
                var helper=new JMethod(-92,"java/lang/Object","<builder-insert>","()Ljava/lang/StringBuilder;",8,0,2,Array.Empty<JHandler>(),(t,f)=>
                {if(!t.Tick())return JStep.Yield;if(f.Pc==1){var text=f.Pop();builder.Insert(index,text.Reference==null?"null":t.Text(text));return JStep.Return(s);}if(f.Pc==0){f.Push(a[1]);f.Pc=2;}return t.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",1);});
                return JHostResult.Schedule(new JFrame(helper,default,Array.Empty<JValue>()));
            });
            string[] lists={"java/util/ArrayList","java/util/LinkedList","java/util/List","java/util/Collection","java/lang/Iterable","java/util/AbstractCollection","java/util/AbstractList","java/util/HashSet","java/util/LinkedHashSet","java/util/EnumSet","java/util/Set","com/google/common/collect/ImmutableSet"};
            foreach(string owner in lists)
            {
                StandardBind(owner,"<init>","()V",(r,s,a)=>{var obj=r.NonNull(s);if(owner=="java/util/AbstractList"&&obj.ClassName!=owner){obj.Payload=new JavaList{Storage=new ListStorage{Values=new OriginalAbstractList(r,s)}};return Done();}var list=new JavaList{Unique=obj.ClassName=="java/util/HashSet"||obj.ClassName=="java/util/LinkedHashSet"};if(owner=="java/util/ArrayList")list.Storage.Values=new List<JValue>(10);obj.Payload=list;obj.HostStorage=true;return Done();});
                StandardBind(owner,"size","()I",(r,s,a)=>Done(JValue.I(r.HostPayload<JavaList>(s).Values.Count)));
                StandardBind(owner,"isEmpty","()Z",(r,s,a)=>Done(JValue.I(r.HostPayload<JavaList>(s).Values.Count==0?1:0)));
                StandardBind(owner,"get","(I)Ljava/lang/Object;",(r,s,a)=>{var l=r.HostPayload<JavaList>(s);int at=a[0].Int;r.ListBounds(l,at);return Done(l.Values[at]);});
                StandardBind(owner,"<init>","(Ljava/util/Collection;)V",(r,s,a)=>{var list=new JavaList();foreach(var value in r.ListItems(a[0]))list.Values.Add(value);r.NonNull(s).Payload=list;r.NonNull(s).HostStorage=true;return Done();});
                StandardBind(owner,"add","(ILjava/lang/Object;)V",(r,s,a)=>{var list=r.HostPayload<JavaList>(s);r.Mutable(list);int at=a[0].Int;if(at<0||at>list.Values.Count)throw r.Fault("java/lang/IndexOutOfBoundsException");list.Values.Insert(at,a[1]);list.Version++;return Done();});
                StandardBind(owner,"set","(ILjava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var l=r.HostPayload<JavaList>(s);r.Mutable(l,false);int at=a[0].Int;r.ListBounds(l,at);var old=l.Values[at];l.Values[at]=a[1];return Done(old);});
                StandardBind(owner,"add","(Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(r.AddNative(r.HostPayload<JavaList>(s),a[0])?1:0)));
                StandardBind(owner,"addAll","(Ljava/util/Collection;)Z",(r,s,a)=>{var list=r.HostPayload<JavaList>(s);r.Mutable(list,false);bool changed=false;foreach(var value in r.ListItems(a[0]))changed|=r.AddNative(list,value);return Done(JValue.I(changed?1:0));});
                StandardBind(owner,"addAll","(ILjava/util/Collection;)Z",(r,s,a)=>{var list=r.HostPayload<JavaList>(s);r.Mutable(list,false);int at=a[0].Int;if(at<0||at>list.Values.Count)throw r.Fault("java/lang/IndexOutOfBoundsException");if(list.Unique)throw new PortGap("Indexed insertion into a non-list collection is invalid");var values=r.ListItems(a[1]);if(values.Length==0)return Done(JValue.I(0));r.Mutable(list);foreach(var value in values)list.Values.Insert(at++,value);list.Version++;return Done(JValue.I(1));});
                StandardBind(owner,"contains","(Ljava/lang/Object;)Z",(r,s,a)=>{foreach(var v in r.HostPayload<JavaList>(s).Values)if(r.NativeEqual(v,a[0]))return Done(JValue.I(1));return Done(JValue.I(0));});
                StandardBind(owner,"clear","()V",(r,s,a)=>{var l=r.HostPayload<JavaList>(s);r.Mutable(l);l.Values.Clear();l.Version++;return Done();});
                StandardBind(owner,"iterator","()Ljava/util/Iterator;",(r,s,a)=>Done(JValue.R(r.HostObject("aot/Iterator",new JavaIterator(r.HostPayload<JavaList>(s))))));
                StandardBind(owner,"toArray","()[Ljava/lang/Object;",(r,s,a)=>{var l=r.HostPayload<JavaList>(s);var arr=r.NewArray("Ljava/lang/Object;",l.Values.Count);l.Values.CopyTo(arr.Items,0);return Done(JValue.R(arr));});
            }
            foreach(string owner in new[]{"java/util/Iterator","aot/Iterator"})
            {
                StandardBind(owner,"hasNext","()Z",(r,s,a)=>{var it=r.HostPayload<JavaIterator>(s);r.CheckIterator(it);return Done(JValue.I(it.At>=0&&it.At<it.List.Values.Count?1:0));});
                StandardBind(owner,"next","()Ljava/lang/Object;",(r,s,a)=>{var it=r.HostPayload<JavaIterator>(s);r.CheckIterator(it);if(it.At<0||it.At>=it.List.Values.Count)throw r.Fault("java/util/NoSuchElementException");it.Last=it.At;var value=it.List.Values[it.At];it.At+=it.Reverse?-1:1;return Done(value);});
            }
            foreach(string owner in new[]{"com/google/common/collect/Lists"})
            {
                StandardBind(owner,"newArrayList","()Ljava/util/ArrayList;",(r,s,a)=>Done(r.ListOf(Array.Empty<JValue>())));
                StandardBind(owner,"newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;",(r,s,a)=>Done(r.ListOf(r.ArrayObject(a[0]).Items)));
                StandardBind(owner,"newArrayListWithCapacity","(I)Ljava/util/ArrayList;",(r,s,a)=>{if(a[0].Int<0)throw r.Fault("java/lang/IllegalArgumentException");return Done(r.ListOf(Array.Empty<JValue>()));});
            }
            StandardBind("java/util/Collections","emptyList","()Ljava/util/List;",(r,s,a)=>Done(r.ListOf(Array.Empty<JValue>(),immutable:true)));
            StandardBind("java/util/List","copyOf","(Ljava/util/Collection;)Ljava/util/List;",(r,s,a)=>r.CollectIterable(a[0],(t,values)=>{foreach(var v in values)t.NonNull(v);return t.ListOf(values,immutable:true);}));
            for(int count=0;count<=10;count++){string descriptor="("+string.Concat(System.Linq.Enumerable.Repeat("Ljava/lang/Object;",count))+")Ljava/util/List;";StandardBind("java/util/List","of",descriptor,(r,s,a)=>{foreach(var v in a)r.NonNull(v);return Done(r.ListOf(a,immutable:true));});}
            StandardBind("java/util/List","of","([Ljava/lang/Object;)Ljava/util/List;",(r,s,a)=>{var values=r.ArrayObject(a[0]).Items;foreach(var v in values)r.NonNull(v);return Done(r.ListOf(values,immutable:true));});
            StandardBind("java/util/Collections","singletonList","(Ljava/lang/Object;)Ljava/util/List;",(r,s,a)=>Done(r.ListOf(a,immutable:true)));
            StandardBind("java/util/Collections","sort","(Ljava/util/List;)V",(r,s,a)=>{var list=r.HostPayload<JavaList>(a[0]);r.Mutable(list,false);var values=new List<JValue>(list.Values);values.Sort(r.CompareNative);for(int i=0;i<values.Count;i++)list.Values[i]=values[i];list.Version++;return Done();});
            StandardBind("java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/ArrayList",new JavaList{Storage=new ListStorage{Values=r.ArrayObject(a[0]).Items},FixedSize=true}))));
            StandardBind("java/util/Collections","unmodifiableList","(Ljava/util/List;)Ljava/util/List;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/ArrayList",new JavaList{Storage=r.HostPayload<JavaList>(a[0]).Storage,Immutable=true}))));
            StandardBind("java/util/Collections","unmodifiableSet","(Ljava/util/Set;)Ljava/util/Set;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/HashSet",new JavaList{Storage=r.HostPayload<JavaList>(a[0]).Storage,Immutable=true,Unique=true}))));
            StandardBind("com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/HashSet",new JavaList{Unique=true}))));
            StandardBind("com/google/common/collect/Sets","newHashSet","([Ljava/lang/Object;)Ljava/util/HashSet;",(r,s,a)=>{var set=new JavaList{Unique=true};foreach(var value in r.ArrayObject(a[0]).Items)r.AddNative(set,value);return Done(JValue.R(r.HostObject("java/util/HashSet",set)));});
            StandardBind("com/google/common/collect/Sets","newLinkedHashSet","()Ljava/util/LinkedHashSet;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/LinkedHashSet",new JavaList{Unique=true}))));
            foreach(string set in new[]{"HashSet","LinkedHashSet"})StandardBind("com/google/common/collect/Sets","new"+set,"(Ljava/lang/Iterable;)Ljava/util/"+set+";",(r,s,a)=>r.CollectIterable(a[0],(t,v)=>t.ListOf(v,"java/util/"+set)));
            StandardBind("java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;",(r,s,a)=>
            {string type=r.EnumType(a[0]);return r.AfterClassInit(type,t=>JValue.R(t.HostObject("java/util/EnumSet",new JavaList{Unique=true,EnumClass=type})));});
            StandardBind("org/apache/commons/lang3/EnumUtils","getEnumMap","(Ljava/lang/Class;)Ljava/util/Map;",(r,s,a)=>
            {string type=r.EnumType(a[0]);return r.AfterClassInit(type,t=>{var map=new JavaMap();foreach(var value in t.EnumValues(type))map.Entries.Add(new KeyValuePair<JValue,JValue>(t.NonNull(value).Fields["java/lang/Enum.name:Ljava/lang/String;"],value));return JValue.R(t.HostObject("java/util/LinkedHashMap",map));});});
            for(int count=0;count<=5;count++)
            {
                string descriptor="("+string.Concat(System.Linq.Enumerable.Repeat("Ljava/lang/Object;",count))+")Lcom/google/common/collect/ImmutableSet;";
                StandardBind("com/google/common/collect/ImmutableSet","of",descriptor,(r,s,a)=>{var set=new JavaList{Unique=true};foreach(var value in a){r.NonNull(value);r.AddNative(set,value);}set.Immutable=true;return Done(JValue.R(r.HostObject("com/google/common/collect/ImmutableSet",set)));});
            }
            for(int count=1;count<=5;count++)
            {
                string descriptor="("+string.Concat(System.Linq.Enumerable.Repeat("Ljava/lang/Enum;",count))+")Ljava/util/EnumSet;";
                StandardBind("java/util/EnumSet","of",descriptor,(r,s,a)=>{var set=new JavaList{Unique=true,EnumClass=r.NonNull(a[0]).ClassName};foreach(var value in a)r.AddNative(set,value);return Done(JValue.R(r.HostObject("java/util/EnumSet",set)));});
            }
            foreach(string owner in new[]{"java/util/HashMap","java/util/LinkedHashMap","java/util/EnumMap","java/util/TreeMap","java/util/Map","java/util/concurrent/ConcurrentHashMap","java/util/concurrent/ConcurrentMap"})
            {
                StandardBind(owner,"<init>","()V",(r,s,a)=>{r.NonNull(s).Payload=new JavaMap{Sorted=r.NonNull(s).ClassName=="java/util/TreeMap",Concurrent=r.NonNull(s).ClassName=="java/util/concurrent/ConcurrentHashMap"};r.NonNull(s).HostStorage=true;return Done();});
                StandardBind(owner,"size","()I",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);lock(map.Storage)return Done(JValue.I(map.Entries.Count));});
                StandardBind(owner,"isEmpty","()Z",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);lock(map.Storage)return Done(JValue.I(map.Entries.Count==0?1:0));});
                StandardBind(owner,"put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);lock(map.Storage)return Done(r.PutNativeMap(map,a[0],a[1]));});
                StandardBind(owner,"get","(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);lock(map.Storage){int i=r.MapIndex(map,a[0]);return Done(i<0?JValue.R(null):map.Entries[i].Value);}});
                StandardBind(owner,"containsKey","(Ljava/lang/Object;)Z",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);lock(map.Storage)return Done(JValue.I(r.MapIndex(map,a[0])>=0?1:0));});
                StandardBind(owner,"forEach","(Ljava/util/function/BiConsumer;)V",(r,s,a)=>
                {
                    r.NonNull(a[0]);var map=r.HostPayload<JavaMap>(s);if(map.Concurrent)throw new PortGap("Concurrent map forEach is not adapted");int index=0,version=map.Storage.Version;
                    var method=new JMethod(-110,"java/lang/Object","<map-forEach>","()V",8,0,4,Array.Empty<JHandler>(),(t,f)=>
                    {if(!t.Tick())return JStep.Yield;if(f.Pc==2)return t.Call(f,"java/util/function/BiConsumer","accept","(Ljava/lang/Object;Ljava/lang/Object;)V","invokeinterface",1);if(version!=map.Storage.Version)throw t.Fault("java/util/ConcurrentModificationException");if(f.Pc==1){index++;f.Pc=0;}if(index==map.Entries.Count)return JStep.ReturnVoid;var entry=map.Entries[index];f.Push(a[0]);f.Push(entry.Key);f.Push(entry.Value);f.Pc=2;return JStep.Continue;});
                    return JHostResult.Schedule(new JFrame(method,default,Array.Empty<JValue>()));
                });
                StandardBind(owner,"computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;",(r,s,a)=>
                {
                    r.NonNull(a[1]);var map=r.HostPayload<JavaMap>(s);if(map.Concurrent)throw new PortGap("Concurrent computeIfAbsent needs atomic callback scheduling");int at=r.MapIndex(map,a[0]);if(at>=0&&map.Entries[at].Value.Reference!=null)return Done(map.Entries[at].Value);int version=map.Storage.Version;
                    var method=new JMethod(-111,"java/lang/Object","<map-compute>","()Ljava/lang/Object;",8,0,3,Array.Empty<JHandler>(),(t,f)=>
                    {if(!t.Tick())return JStep.Yield;if(f.Pc==1){var value=f.Pop();if(map.Storage.Version!=version)throw t.Fault("java/util/ConcurrentModificationException");if(value.Reference!=null)t.PutNativeMap(map,a[0],value);return JStep.Return(value);}if(f.Pc==0){f.Push(a[1]);f.Push(a[0]);f.Pc=2;}return t.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1);});return JHostResult.Schedule(new JFrame(method,default,Array.Empty<JValue>()));
                });
                StandardBind(owner,"keySet","()Ljava/util/Set;",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);if(map.Concurrent)throw new PortGap("ConcurrentHashMap weakly-consistent key views are not adapted");return Done(JValue.R(r.HostObject("java/util/HashSet",new JavaList{Storage=new ListStorage{Values=new JavaMapKeys(r,map),ExternalVersion=()=>map.Storage.Version},Unique=true,Immutable=map.Immutable})));});
                StandardBind(owner,"values","()Ljava/util/Collection;",(r,s,a)=>{var map=r.HostPayload<JavaMap>(s);if(map.Concurrent)throw new PortGap("ConcurrentHashMap weakly-consistent value views are not adapted");return Done(JValue.R(r.HostObject("aot/MapValues",new JavaList{Storage=new ListStorage{Values=new JavaMapKeys(r,map,false),ExternalVersion=()=>map.Storage.Version},Immutable=map.Immutable})));});
            }
            foreach(string owner in new[]{"java/util/HashMap","java/util/LinkedHashMap"})
                StandardBind(owner,"<init>","(I)V",(r,s,a)=>{if(a[0].Int<0)throw r.Fault("java/lang/IllegalArgumentException");r.NonNull(s).Payload=new JavaMap();r.NonNull(s).HostStorage=true;return Done();});
            StandardBind("com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;",(r,s,a)=>Done(r.MapOf(Array.Empty<KeyValuePair<JValue,JValue>>())));
            StandardBind("com/google/common/collect/Maps","newTreeMap","()Ljava/util/TreeMap;",(r,s,a)=>Done(JValue.R(r.HostObject("java/util/TreeMap",new JavaMap{Sorted=true}))));
            StandardBind("java/util/TreeMap","<init>","(Ljava/util/Comparator;)V",(r,s,a)=>{if(a[0].Reference!=null)r.HostPayload<AsciiCaseComparator>(a[0]);r.NonNull(s).Payload=new JavaMap{Sorted=true,CaseInsensitive=a[0].Reference!=null};r.NonNull(s).HostStorage=true;return Done();});
            StandardBind("com/google/common/collect/Maps","newTreeMap","(Ljava/util/Comparator;)Ljava/util/TreeMap;",(r,s,a)=>{if(a[0].Reference!=null)r.HostPayload<AsciiCaseComparator>(a[0]);return Done(JValue.R(r.HostObject("java/util/TreeMap",new JavaMap{Sorted=true,CaseInsensitive=a[0].Reference!=null})));});
            StandardBind("java/util/Collections","unmodifiableMap","(Ljava/util/Map;)Ljava/util/Map;",(r,s,a)=>{var map=r.HostPayload<JavaMap>(a[0]);return Done(JValue.R(r.HostObject("java/util/HashMap",new JavaMap{Storage=map.Storage,Immutable=true,Sorted=map.Sorted,CaseInsensitive=map.CaseInsensitive,Concurrent=map.Concurrent})));});
            StandardBind("java/util/Collections","synchronizedMap","(Ljava/util/Map;)Ljava/util/Map;",(r,s,a)=>{r.NonNull(a[0]);return Done(JValue.R(r.HostObject("aot/SynchronizedMap",new SynchronizedMapTarget(a[0]))));});
            NativeClass("org/apache/commons/lang3/tuple/Pair");NativeClass("org/apache/commons/lang3/tuple/ImmutablePair","org/apache/commons/lang3/tuple/Pair");
            StandardBind("org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;",(r,s,a)=>Done(JValue.R(r.HostObject("org/apache/commons/lang3/tuple/ImmutablePair",new JavaPair(a[0],a[1])))));
            foreach(string name in new[]{"getLeft","getKey","getRight","getValue"}){string captured=name;StandardBind("org/apache/commons/lang3/tuple/Pair",name,"()Ljava/lang/Object;",(r,s,a)=>Done(captured=="getLeft"||captured=="getKey"?r.HostPayload<JavaPair>(s).Left:r.HostPayload<JavaPair>(s).Right));}
            StandardBind("org/apache/commons/lang3/StringUtils","isBlank","(Ljava/lang/CharSequence;)Z",(r,s,a)=>Done(JValue.I(a[0].Reference==null||JavaBlank(r.Text(a[0]))?1:0)));
            StandardBind("org/apache/commons/lang3/StringUtils","isNotBlank","(Ljava/lang/CharSequence;)Z",(r,s,a)=>Done(JValue.I(a[0].Reference!=null&&!JavaBlank(r.Text(a[0]))?1:0)));
            StandardBind("org/apache/commons/lang3/StringUtils","isEmpty","(Ljava/lang/CharSequence;)Z",(r,s,a)=>Done(JValue.I(a[0].Reference==null||r.Text(a[0]).Length==0?1:0)));
            StandardBind("org/apache/commons/lang3/StringUtils","isNotEmpty","(Ljava/lang/CharSequence;)Z",(r,s,a)=>Done(JValue.I(a[0].Reference!=null&&r.Text(a[0]).Length!=0?1:0)));
            StandardBind("java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z",(r,s,a)=>Done(JValue.I(a[0].Reference!=null&&AsciiEqualsIgnoreCase(r.Text(s),r.Text(a[0]))?1:0)));
            StandardBind("org/apache/commons/lang3/StringUtils","containsIgnoreCase","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z",(r,s,a)=>
            {if(a[0].Reference==null||a[1].Reference==null)return Done(JValue.I(0));string text=r.Text(a[0]),part=r.Text(a[1]);AssertAscii(text);AssertAscii(part);return Done(JValue.I(text.IndexOf(part,StringComparison.OrdinalIgnoreCase)>=0?1:0));});
            NativeClass("java/io/InputStream");NativeClass("java/io/ByteArrayInputStream","java/io/InputStream");
            StandardBind("java/io/ByteArrayInputStream","<init>","([B)V",(r,s,a)=>{var source=r.ArrayObject(a[0]);var bytes=new byte[source.Items.Length];for(int i=0;i<bytes.Length;i++)bytes[i]=unchecked((byte)source.Items[i].Int);r.NonNull(s).Payload=new MemoryStream(bytes,false);r.NonNull(s).HostStorage=true;return Done();});
            foreach(string owner in new[]{"java/io/InputStream","java/io/ByteArrayInputStream"})
            {
                StandardBind(owner,"read","()I",(r,s,a)=>Done(JValue.I(r.HostPayload<Stream>(s).ReadByte())));
                StandardBind(owner,"close","()V",(r,s,a)=>{if(r.NonNull(s).ClassName!="java/io/ByteArrayInputStream")r.HostPayload<Stream>(s).Dispose();return Done();});
            }
            StandardBind("com/google/common/collect/ImmutableSet","of","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)Lcom/google/common/collect/ImmutableSet;",(r,s,a)=>{var set=new JavaList{Unique=true};for(int i=0;i<6;i++){r.NonNull(a[i]);r.AddNative(set,a[i]);}foreach(var value in r.ArrayObject(a[6]).Items){r.NonNull(value);r.AddNative(set,value);}set.Immutable=true;return Done(JValue.R(r.HostObject("com/google/common/collect/ImmutableSet",set)));});
            InstallSortedMaps();
            NativeClass("java/text/Format");NativeClass("java/text/NumberFormat","java/text/Format");NativeClass("java/text/DecimalFormat","java/text/NumberFormat");
            StandardBind("java/text/DecimalFormat","<init>","(Ljava/lang/String;)V",(r,s,a)=>{string pattern=r.Text(a[0]);if(pattern!="#.##")throw new PortGap("DecimalFormat pattern adapter missing: "+pattern);r.NonNull(s).Payload=new DecimalPattern(pattern);r.NonNull(s).HostStorage=true;return Done();});
        }
        // Initialization used by TextUtil; actual number formatting is deliberately not bound
        // until Java rounding/locale/negative-zero behavior has been implemented and verified.
        private sealed class DecimalPattern {internal readonly string Pattern;internal DecimalPattern(string pattern){Pattern=pattern;}}
        // Only the damage ignition fixture uses opaque host-backed Forge collections.
        // Do not install this in the full engine: generated FCollection methods must remain authoritative.
        public void InstallFixtureListAdapters()
        {
            var entries=new List<KeyValuePair<string,Func<JRuntime,JValue,JValue[],JHostResult>>>(bindings);
            const string prefix="java/util/ArrayList";
            foreach(string owner in new[]{"forge/util/collect/FCollection","forge/game/card/CardCollection"})
                foreach(var entry in entries)if(entry.Key.StartsWith(prefix+".",StringComparison.Ordinal))bindings.Add(owner+entry.Key.Substring(prefix.Length),entry.Value);
        }
        public void InstallFaceLinkingAdapter()
        {
            // Compatibility entry point: all readers now use the generic live entrySet adapter.
            if(!bindings.ContainsKey("java/util/HashMap.entrySet()Ljava/util/Set;"))throw new PortGap("Live map entrySet adapter is not installed");
        }
        private string EnumType(JValue value)
        {string type=NonNull(value).RepresentedClass??throw new PortGap("Class object required for enum adapter");if(!Program.Classes.TryGetValue(type,out var cls)||(cls.Access&0x4000)==0)throw Fault("java/lang/ClassCastException");return type;}
        private IEnumerable<JValue> EnumValues(string type)
        {var field=Program.Classes[type].Fields["$VALUES:[L"+type+";"];return ArrayObject(GetStatic(type,field.Name,field.Descriptor)).Items;}
        private JHostResult AfterClassInit(string type,Func<JRuntime,JValue> action)
        {
            var method=new JMethod(-90,"java/lang/Object","<library-init>","()Ljava/lang/Object;",8,0,1,Array.Empty<JHandler>(),(r,f)=>
            {if(!r.Tick())return JStep.Yield;if(!r.EnsureInitialized(f,type))return JStep.Continue;return JStep.Return(action(r));});
            return JHostResult.Schedule(new JFrame(method,default,Array.Empty<JValue>()));
        }
        private bool AddNative(JavaList list,JValue value)
        {
            Mutable(list);if(list.Sorted)throw new PortGap("Sorted set mutation must use its scheduled comparator");if(list.Values is JavaMapKeys)throw Fault("java/lang/UnsupportedOperationException");if(list.EnumClass!=null&&!IsInstance(NonNull(value),list.EnumClass))throw Fault("java/lang/ClassCastException");
            if(list.Unique)foreach(var item in list.Values)if(NativeEqual(item,value))return false;
            if(list.EnumClass==null)list.Values.Add(value);
            else{int ordinal=NonNull(value).Fields["java/lang/Enum.ordinal:I"].Int,at=0;while(at<list.Values.Count&&NonNull(list.Values[at]).Fields["java/lang/Enum.ordinal:I"].Int<ordinal)at++;list.Values.Insert(at,value);}
            list.Version++;return true;
        }
        private void RemoveMapAt(JavaMap map,int index)
        {var entry=map.Entries[index];if(map.Inverse!=null){int inverse=MapIndex(map.Inverse,entry.Value);if(inverse>=0){map.Inverse.Entries.RemoveAt(inverse);map.Inverse.Storage.Version++;}}map.Entries.RemoveAt(index);map.Storage.Version++;}
        private JValue PutNativeMap(JavaMap map,JValue key,JValue value)
        {
            if(map.Immutable)throw Fault("java/lang/UnsupportedOperationException");if(map.Concurrent){NonNull(key);NonNull(value);}int at=MapIndex(map,key);var old=at<0?JValue.R(null):map.Entries[at].Value;
            if(map.EnumClass!=null&&!IsInstance(NonNull(key),map.EnumClass))throw Fault("java/lang/ClassCastException");
            if(map.Sorted){NonNull(key);CompareMapKeys(map,key,key);foreach(var entry in map.Entries)CompareMapKeys(map,entry.Key,key);}
            if(map.Inverse!=null)
            {
                int duplicate=MapIndex(map.Inverse,value);if(duplicate>=0&&!NativeEqual(map.Inverse.Entries[duplicate].Value,key))throw Fault("java/lang/IllegalArgumentException","value already present");
                if(at>=0){int oldInverse=MapIndex(map.Inverse,old);if(oldInverse>=0)map.Inverse.Entries.RemoveAt(oldInverse);}
                map.Inverse.Entries.Add(new KeyValuePair<JValue,JValue>(value,key));map.Inverse.Storage.Version++;
            }
            var item=new KeyValuePair<JValue,JValue>(key,value);if(at<0){map.Entries.Add(item);map.Storage.Version++;}else map.Entries[at]=item;
            if(map.Sorted)map.Entries.Sort((x,y)=>CompareMapKeys(map,x.Key,y.Key));return old;
        }
        private int CompareMapKeys(JavaMap map,JValue a,JValue b)
        {if(!map.CaseInsensitive)return CompareNative(a,b);string left=Text(a),right=Text(b);AssertAscii(left);AssertAscii(right);return string.Compare(left,right,StringComparison.OrdinalIgnoreCase);}
        private int CompareNative(JValue a,JValue b)
        {
            if(a.Reference?.ClassName=="java/lang/String"&&b.Reference?.ClassName=="java/lang/String")return string.CompareOrdinal(Text(a),Text(b));
            if(a.Reference?.ClassName=="java/lang/Integer"&&b.Reference?.ClassName=="java/lang/Integer")return UnboxInt(a).CompareTo(UnboxInt(b));
            if(a.Reference?.ClassName=="java/lang/Long"&&b.Reference?.ClassName=="java/lang/Long")return a.Reference.Boxed!.Value.Long.CompareTo(b.Reference.Boxed!.Value.Long);
            if(a.Reference!=null&&b.Reference!=null&&a.Reference.ClassName==b.Reference.ClassName&&a.Reference.Fields.TryGetValue("java/lang/Enum.ordinal:I",out var ordinal)&&b.Reference.Fields.TryGetValue("java/lang/Enum.ordinal:I",out var other))return ordinal.Int.CompareTo(other.Int);
            NonNull(a);NonNull(b);return InlineCall("java/lang/Comparable","compareTo","(Ljava/lang/Object;)I",a,new[]{b}).Int;
        }
        private static bool JavaBlank(string value)
        {foreach(char c in value)if(!(c>=9&&c<=13||c>=0x1c&&c<=0x20||c==0x1680||c>=0x2000&&c<=0x2006||c>=0x2008&&c<=0x200a||c==0x2028||c==0x2029||c==0x205f||c==0x3000))return false;return true;}
        private static void AssertAscii(string value){foreach(char c in value)if(c>127)throw new PortGap("Non-ASCII Java case folding requires an additional adapter");}
        private static bool AsciiEqualsIgnoreCase(string left,string right)
        {if(left.Length!=right.Length)return false;AssertAscii(left);AssertAscii(right);return string.Equals(left,right,StringComparison.OrdinalIgnoreCase);}
        private void ListBounds(JavaList list,int at){if(at<0||at>=list.Values.Count)throw Fault("java/lang/IndexOutOfBoundsException");}
        private JavaTable TablePayload(JValue receiver,string owner)
        {
            if(NonNull(receiver).Payload is JavaTable direct)return direct;
            if(owner!="com/google/common/collect/ForwardingTable")throw new PortGap("Table storage adapter missing");
            return TablePayload(InlineCall(owner,"delegate","()Lcom/google/common/collect/Table;",receiver,Array.Empty<JValue>()),owner);
        }
        private int TableIndex(JavaTable table,JValue row,JValue column){for(int i=0;i<table.Entries.Count;i++)if(NativeEqual(table.Entries[i].Row,row)&&NativeEqual(table.Entries[i].Column,column))return i;return -1;}
        private string Substring(JValue value,int from,int to){string text=Text(value);if(from<0||to<from||to>text.Length)throw Fault("java/lang/StringIndexOutOfBoundsException");return text.Substring(from,to-from);}
        private string DisplayPrimitive(JValue value,string type)=>type=="Ljava/lang/String;"?value.Reference==null?"null":Text(value):type=="Z"?value.Int==0?"false":"true":type=="C"?((char)value.Int).ToString():type=="J"?value.Long.ToString(CultureInfo.InvariantCulture):value.Int.ToString(CultureInfo.InvariantCulture);
    }
}

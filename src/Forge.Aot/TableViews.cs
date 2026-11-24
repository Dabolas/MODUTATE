using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private JValue[] TableKeys(JavaTable table,bool rows){var keys=new List<JValue>();foreach(var e in table.Entries){var key=rows?e.Row:e.Column;if(!keys.Any(k=>NativeEqual(k,key)))keys.Add(key);}return keys.ToArray();}
        private JValue TableOuterMap(JavaTable table,bool rows)
        {
            const string type="aot/TableOuterMap";NativeClass(type,"java/lang/Object","java/util/Map");
            StandardBind(type,"get","(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var v=r.HostPayload<TableAxis>(s);return Done(r.TableKeys(v.Table,v.Row).Any(k=>r.NativeEqual(k,a[0]))?r.TableAxisMap(v.Table,a[0],v.Row):default);});
            StandardBind(type,"containsKey","(Ljava/lang/Object;)Z",(r,s,a)=>{var v=r.HostPayload<TableAxis>(s);return Done(JValue.I(r.TableKeys(v.Table,v.Row).Any(k=>r.NativeEqual(k,a[0]))?1:0));});
            StandardBind(type,"size","()I",(r,s,a)=>{var v=r.HostPayload<TableAxis>(s);return Done(JValue.I(r.TableKeys(v.Table,v.Row).Length));});
            StandardBind(type,"isEmpty","()Z",(r,s,a)=>Done(JValue.I(r.HostPayload<TableAxis>(s).Table.Entries.Count==0?1:0)));
            StandardBind(type,"clear","()V",(r,s,a)=>{r.HostPayload<TableAxis>(s).Table.Entries.Clear();return Done();});
            StandardBind(type,"put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>throw r.Fault("java/lang/UnsupportedOperationException"));
            StandardBind(type,"remove","(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var v=r.HostPayload<TableAxis>(s);var axis=new TableAxis(v.Table,a[0],v.Row);if(axis.Indices(r).Length==0)return Done(default);var copy=new JavaMap();foreach(int i in axis.Indices(r)){var e=v.Table.Entries[i];r.PutNativeMap(copy,v.Row?e.Column:e.Row,e.Value);}new TableAxisValues(r,axis,"values").Clear();return Done(JValue.R(r.HostObject("java/util/HashMap",copy)));});
            foreach(string method in new[]{"values","keySet","entrySet"})StandardBind(type,method,"()Ljava/util/"+(method=="values"?"Collection":"Set")+";",(r,s,a)=>Done(JValue.R(r.HostObject(method=="values"?"java/util/ArrayList":"java/util/HashSet",new JavaList{Unique=method!="values",Storage=new ListStorage{Values=new TableOuterValues(r,r.HostPayload<TableAxis>(s),method)}}))));
            return JValue.R(HostObject(type,new TableAxis(table,default,rows)));
        }
        private sealed class TableOuterValues:IList<JValue>
        {
            private readonly JRuntime rt;private readonly TableAxis outer;private readonly string kind;internal TableOuterValues(JRuntime r,TableAxis o,string k){rt=r;outer=o;kind=k;}
            public int Count=>rt.TableKeys(outer.Table,outer.Row).Length;public bool IsReadOnly=>false;
            public JValue this[int i]{get{var key=rt.TableKeys(outer.Table,outer.Row)[i];if(kind=="keySet")return key;var value=rt.TableAxisMap(outer.Table,key,outer.Row);return kind=="values"?value:JValue.R(rt.HostObject("aot/ImmutableMapEntry",new JavaPair(key,value)));}set=>throw rt.Fault("java/lang/UnsupportedOperationException");}
            public void RemoveAt(int i)=>new TableAxisValues(rt,new TableAxis(outer.Table,rt.TableKeys(outer.Table,outer.Row)[i],outer.Row),"values").Clear();public void Clear()=>outer.Table.Entries.Clear();public void Add(JValue v)=>throw rt.Fault("java/lang/UnsupportedOperationException");public void Insert(int i,JValue v)=>Add(v);public int IndexOf(JValue v){for(int i=0;i<Count;i++)if(rt.NativeEqual(this[i],v))return i;return -1;}public bool Contains(JValue v)=>IndexOf(v)>=0;public bool Remove(JValue v){int i=IndexOf(v);if(i<0)return false;RemoveAt(i);return true;}public void CopyTo(JValue[] a,int at){foreach(var v in this)a[at++]=v;}public IEnumerator<JValue> GetEnumerator(){for(int i=0;i<Count;i++)yield return this[i];}IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        }
        private sealed class TableValues:IList<JValue>
        {
            private readonly JRuntime rt;private readonly JavaTable table;internal TableValues(JRuntime r,JavaTable t){rt=r;table=t;}
            public int Count=>table.Entries.Count;public bool IsReadOnly=>false;public JValue this[int i]{get=>table.Entries[i].Value;set=>throw rt.Fault("java/lang/UnsupportedOperationException");}
            public void RemoveAt(int i)=>table.Entries.RemoveAt(i);public void Clear()=>table.Entries.Clear();public void Add(JValue v)=>throw rt.Fault("java/lang/UnsupportedOperationException");public void Insert(int i,JValue v)=>Add(v);public int IndexOf(JValue v)=>table.Entries.FindIndex(e=>rt.NativeEqual(e.Value,v));public bool Contains(JValue v)=>IndexOf(v)>=0;public bool Remove(JValue v){int i=IndexOf(v);if(i<0)return false;RemoveAt(i);return true;}public void CopyTo(JValue[] a,int at){foreach(var v in this)a[at++]=v;}public IEnumerator<JValue> GetEnumerator(){foreach(var e in table.Entries)yield return e.Value;}IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        }
        private JValue TableAxisMap(JavaTable table,JValue key,bool row)
        {
            const string type="aot/TableAxisMap";NativeClass(type,"java/lang/Object","java/util/Map");
            NativeClass("aot/TableAxisEntry","java/lang/Object","java/util/Map$Entry");
            StandardBind("aot/TableAxisEntry","getKey","()Ljava/lang/Object;",(r,s,a)=>Done(r.HostPayload<TableAxisEntry>(s).Key));
            StandardBind("aot/TableAxisEntry","getValue","()Ljava/lang/Object;",(r,s,a)=>{var e=r.HostPayload<TableAxisEntry>(s);return Done(r.InlineCall(type,"get","(Ljava/lang/Object;)Ljava/lang/Object;",e.Map,new[]{e.Key}));});
            StandardBind("aot/TableAxisEntry","setValue","(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var e=r.HostPayload<TableAxisEntry>(s);return Done(r.InlineCall(type,"put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",e.Map,new[]{e.Key,a[0]}));});
            StandardBind(type,"get","(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var v=r.HostPayload<TableAxis>(s);int i=r.TableIndex(v.Table,v.Row?v.Key:a[0],v.Row?a[0]:v.Key);return Done(i<0?default:v.Table.Entries[i].Value);});
            StandardBind(type,"containsKey","(Ljava/lang/Object;)Z",(r,s,a)=>{var v=r.HostPayload<TableAxis>(s);return Done(JValue.I(r.TableIndex(v.Table,v.Row?v.Key:a[0],v.Row?a[0]:v.Key)>=0?1:0));});
            StandardBind(type,"put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var v=r.HostPayload<TableAxis>(s);return Done(r.InlineCall("com/google/common/collect/Table","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",JValue.R(r.HostObject(v.Table.Sorted?"com/google/common/collect/TreeBasedTable":"com/google/common/collect/HashBasedTable",v.Table)),new[]{v.Row?v.Key:a[0],v.Row?a[0]:v.Key,a[1]}));});
            StandardBind(type,"remove","(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var v=r.HostPayload<TableAxis>(s);int i=r.TableIndex(v.Table,v.Row?v.Key:a[0],v.Row?a[0]:v.Key);if(i<0)return Done(default);var old=v.Table.Entries[i].Value;v.Table.Entries.RemoveAt(i);return Done(old);});
            StandardBind(type,"size","()I",(r,s,a)=>Done(JValue.I(r.HostPayload<TableAxis>(s).Indices(r).Length)));
            StandardBind(type,"isEmpty","()Z",(r,s,a)=>Done(JValue.I(r.HostPayload<TableAxis>(s).Indices(r).Length==0?1:0)));
            StandardBind(type,"clear","()V",(r,s,a)=>{new TableAxisValues(r,r.HostPayload<TableAxis>(s),"values").Clear();return Done();});
            foreach(string method in new[]{"values","keySet","entrySet"})StandardBind(type,method,"()Ljava/util/"+(method=="values"?"Collection":"Set")+";",(r,s,a)=>Done(JValue.R(r.HostObject(method=="values"?"java/util/ArrayList":"java/util/HashSet",new JavaList{Unique=method!="values",Storage=new ListStorage{Values=new TableAxisValues(r,r.HostPayload<TableAxis>(s),method)}}))));
            if(table.Sorted&&row){
                const string sortedRow="aot/SortedTableRow";
                NativeClass(sortedRow,type,"java/util/SortedMap");
                return JValue.R(HostObject(sortedRow,new TableAxis(table,key,true)));
            }
            return JValue.R(HostObject(type,new TableAxis(table,key,row)));
        }
        private sealed class TableAxis
        {internal readonly JavaTable Table;internal readonly JValue Key;internal readonly bool Row;internal TableAxis(JavaTable table,JValue key,bool row){Table=table;Key=key;Row=row;}internal int[] Indices(JRuntime rt)=>Enumerable.Range(0,Table.Entries.Count).Where(i=>rt.NativeEqual(Row?Table.Entries[i].Row:Table.Entries[i].Column,Key)).ToArray();}
        private sealed class TableAxisEntry {internal readonly JValue Map,Key;internal TableAxisEntry(JValue map,JValue key){Map=map;Key=key;}}
        private sealed class TableAxisValues:IList<JValue>
        {
            private readonly JRuntime rt;private readonly TableAxis axis;private readonly string kind;internal TableAxisValues(JRuntime r,TableAxis a,string k){rt=r;axis=a;kind=k;}
            public int Count=>axis.Indices(rt).Length;public bool IsReadOnly=>false;
            public JValue this[int i]{get{var e=axis.Table.Entries[axis.Indices(rt)[i]];var key=axis.Row?e.Column:e.Row;return kind=="values"?e.Value:kind=="keySet"?key:JValue.R(rt.HostObject("aot/TableAxisEntry",new TableAxisEntry(rt.TableAxisMap(axis.Table,axis.Key,axis.Row),key)));}set=>throw rt.Fault("java/lang/UnsupportedOperationException");}
            public void RemoveAt(int i)=>axis.Table.Entries.RemoveAt(axis.Indices(rt)[i]);public void Clear(){foreach(int i in axis.Indices(rt).Reverse())axis.Table.Entries.RemoveAt(i);}public void Add(JValue v)=>throw rt.Fault("java/lang/UnsupportedOperationException");public void Insert(int i,JValue v)=>Add(v);public int IndexOf(JValue v){for(int i=0;i<Count;i++)if(rt.NativeEqual(this[i],v))return i;return -1;}public bool Contains(JValue v)=>IndexOf(v)>=0;public bool Remove(JValue v){int i=IndexOf(v);if(i<0)return false;RemoveAt(i);return true;}public void CopyTo(JValue[] a,int at){foreach(var v in this)a[at++]=v;}public IEnumerator<JValue> GetEnumerator(){for(int i=0;i<Count;i++)yield return this[i];}IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        }
        private JValue TableCellSet(JavaTable table)
        {
            const string cell="aot/TableCell";
            NativeClass(cell,"java/lang/Object","com/google/common/collect/Table$Cell");
            foreach(var property in new[]{"getRowKey","getColumnKey","getValue"})StandardBind(cell,property,"()Ljava/lang/Object;",(r,s,a)=>{var c=r.HostPayload<TableCell>(s);return Done(property=="getRowKey"?c.Row:property=="getColumnKey"?c.Column:c.Value);});
            return JValue.R(HostObject("java/util/HashSet",new JavaList{Unique=true,Storage=new ListStorage{Values=new TableCells(this,table)}}));
        }
        private sealed class TableCell {internal readonly JValue Row,Column,Value;internal TableCell(JValue row,JValue column,JValue value){Row=row;Column=column;Value=value;}}
        private sealed class TableCells:IList<JValue>
        {
            private readonly JRuntime rt;private readonly JavaTable table;internal TableCells(JRuntime r,JavaTable t){rt=r;table=t;}
            public int Count=>table.Entries.Count;public bool IsReadOnly=>false;
            public JValue this[int i]{get{var c=table.Entries[i];return JValue.R(rt.HostObject("aot/TableCell",new TableCell(c.Row,c.Column,c.Value)));}set=>throw rt.Fault("java/lang/UnsupportedOperationException");}
            public void RemoveAt(int i)=>table.Entries.RemoveAt(i);public void Clear()=>table.Entries.Clear();public void Add(JValue v)=>throw rt.Fault("java/lang/UnsupportedOperationException");public void Insert(int i,JValue v)=>Add(v);
            public int IndexOf(JValue v){if(v.Reference==null||!rt.IsInstance(v.Reference,"com/google/common/collect/Table$Cell"))return -1;var row=rt.InlineCall("com/google/common/collect/Table$Cell","getRowKey","()Ljava/lang/Object;",v,Array.Empty<JValue>());var col=rt.InlineCall("com/google/common/collect/Table$Cell","getColumnKey","()Ljava/lang/Object;",v,Array.Empty<JValue>());var value=rt.InlineCall("com/google/common/collect/Table$Cell","getValue","()Ljava/lang/Object;",v,Array.Empty<JValue>());int i=rt.TableIndex(table,row,col);return i>=0&&rt.NativeEqual(table.Entries[i].Value,value)?i:-1;}
            public bool Contains(JValue v)=>IndexOf(v)>=0;public bool Remove(JValue v){int i=IndexOf(v);if(i<0)return false;RemoveAt(i);return true;}public void CopyTo(JValue[] a,int at){foreach(var v in this)a[at++]=v;}public IEnumerator<JValue> GetEnumerator(){for(int i=0;i<Count;i++)yield return this[i];}IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        }
    }
}

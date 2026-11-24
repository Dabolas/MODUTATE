using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class DependencyGraph {internal readonly List<JValue> Vertices=new List<JValue>();internal readonly List<(JValue From,JValue To,JValue Edge)> Edges=new List<(JValue,JValue,JValue)>();}
        private void InstallDependencyGraphs()
        {
            const string graph="org/jgrapht/graph/DefaultDirectedGraph",cycle="org/jgrapht/alg/cycle/SzwarcfiterLauerSimpleCycles";
            NativeClass("org/jgrapht/Graph");NativeClass(graph,"java/lang/Object","org/jgrapht/Graph");NativeClass("org/jgrapht/graph/DefaultEdge");NativeClass(cycle);
            StandardBind(graph,"<init>","(Ljava/lang/Class;)V",(r,s,a)=>{if(r.ClassName(a[0])!="org/jgrapht/graph/DefaultEdge")throw new PortGap("Graph requires supported DefaultEdge supplier");var o=r.NonNull(s);o.Payload=new DependencyGraph();o.HostStorage=true;return Done();});
            StandardBind(graph,"addVertex","(Ljava/lang/Object;)Z",(r,s,a)=>{r.NonNull(a[0]);var g=r.HostPayload<DependencyGraph>(s);if(g.Vertices.Any(v=>r.NativeEqual(v,a[0])))return Done(JValue.I(0));g.Vertices.Add(a[0]);return Done(JValue.I(1));});
            StandardBind(graph,"addEdge","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var g=r.HostPayload<DependencyGraph>(s);if(a.Any(v=>!g.Vertices.Any(w=>r.NativeEqual(v,w))))throw r.Fault("java/lang/IllegalArgumentException","Missing graph vertex");if(g.Edges.Any(e=>r.NativeEqual(e.From,a[0])&&r.NativeEqual(e.To,a[1])))return Done(default);var edge=JValue.R(r.HostObject("org/jgrapht/graph/DefaultEdge",new object()));g.Edges.Add((a[0],a[1],edge));return Done(edge);});
            StandardBind(graph,"removeEdge","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var g=r.HostPayload<DependencyGraph>(s);int at=g.Edges.FindIndex(e=>r.NativeEqual(e.From,a[0])&&r.NativeEqual(e.To,a[1]));if(at<0)return Done(default);var edge=g.Edges[at].Edge;g.Edges.RemoveAt(at);return Done(edge);});
            StandardBind(graph,"outDegreeOf","(Ljava/lang/Object;)I",(r,s,a)=>{var g=r.HostPayload<DependencyGraph>(s);if(!g.Vertices.Any(v=>r.NativeEqual(v,a[0])))throw r.Fault("java/lang/IllegalArgumentException");return Done(JValue.I(g.Edges.Count(e=>r.NativeEqual(e.From,a[0]))));});
            StandardBind(graph,"removeAllVertices","(Ljava/util/Collection;)Z",(r,s,a)=>{var g=r.HostPayload<DependencyGraph>(s);var remove=r.ListItems(a[0]);int count=g.Vertices.RemoveAll(v=>remove.Any(w=>r.NativeEqual(v,w)));g.Edges.RemoveAll(e=>remove.Any(v=>r.NativeEqual(e.From,v)||r.NativeEqual(e.To,v)));return Done(JValue.I(count>0?1:0));});
            foreach(bool edges in new[]{false,true})StandardBind(graph,edges?"edgeSet":"vertexSet","()Ljava/util/Set;",(r,s,a)=>{var g=r.HostPayload<DependencyGraph>(s);return Done(JValue.R(r.HostObject("java/util/HashSet",new JavaList{Immutable=true,Unique=true,Storage=new ListStorage{Values=new GraphValues(()=>edges?g.Edges.Select(e=>e.Edge).ToArray():g.Vertices.ToArray())}})));});
            StandardBind(cycle,"<init>","(Lorg/jgrapht/Graph;)V",(r,s,a)=>{var o=r.NonNull(s);o.Payload=r.HostPayload<DependencyGraph>(a[0]);o.HostStorage=true;return Done();});
            StandardBind(cycle,"findSimpleCycles","()Ljava/util/List;",(r,s,a)=>Done(r.GraphCycles(r.HostPayload<DependencyGraph>(s))));
        }
        // Enumerates directed elementary cycles, canonically starting at their lowest vertex index.
        private JValue GraphCycles(DependencyGraph graph)
        {
            var vertices=graph.Vertices.ToArray();var links=vertices.Select(v=>graph.Edges.Where(e=>NativeEqual(e.From,v)).Select(e=>Array.FindIndex(vertices,w=>NativeEqual(e.To,w))).ToArray()).ToArray();var cycles=new List<JValue>();int visits=0;
            for(int start=0;start<vertices.Length;start++){var path=new List<int>{start};var seen=new HashSet<int>{start};void Visit(int node){if(++visits>1000000)throw new PortGap("Dependency graph cycle enumeration exceeded safety bound");foreach(int next in links[node]){if(next==start){cycles.Add(ListOf(path.Select(i=>vertices[i])));continue;}if(next<start||!seen.Add(next))continue;path.Add(next);Visit(next);path.RemoveAt(path.Count-1);seen.Remove(next);}}Visit(start);}
            Trace?.Invoke("DEPENDENCY CYCLES "+cycles.Count);
            return ListOf(cycles);
        }
        private sealed class GraphValues:IList<JValue>
        {
            private readonly Func<JValue[]> read;internal GraphValues(Func<JValue[]> source){read=source;}public int Count=>read().Length;public bool IsReadOnly=>true;public JValue this[int i]{get=>read()[i];set=>throw new NotSupportedException();}public void Add(JValue v)=>throw new NotSupportedException();public void Clear()=>throw new NotSupportedException();public void Insert(int i,JValue v)=>throw new NotSupportedException();public bool Remove(JValue v)=>throw new NotSupportedException();public void RemoveAt(int i)=>throw new NotSupportedException();public int IndexOf(JValue v)=>Array.IndexOf(read(),v);public bool Contains(JValue v)=>IndexOf(v)>=0;public void CopyTo(JValue[] a,int at)=>read().CopyTo(a,at);public IEnumerator<JValue> GetEnumerator()=>((IEnumerable<JValue>)read()).GetEnumerator();IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        }
    }
}

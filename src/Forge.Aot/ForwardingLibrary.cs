using System;
using System.Linq;

namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private void InstallForwardingMaps()
        {
            const string obj="com/google/common/collect/ForwardingObject",map="com/google/common/collect/ForwardingMap";
            NativeClass(obj);NativeClass(map,obj,"java/util/Map");
            StandardBind(obj,"<init>","()V",(r,s,a)=>Done());StandardBind(map,"<init>","()V",(r,s,a)=>Done());
            const string collection="com/google/common/collect/ForwardingCollection",list="com/google/common/collect/ForwardingList";
            NativeClass(collection,obj,"java/util/Collection");NativeClass(list,collection,"java/util/List");
            StandardBind(collection,"<init>","()V",(r,s,a)=>Done());StandardBind(list,"<init>","()V",(r,s,a)=>Done());
            foreach(var pair in new[]{(list,"java/util/List"),(collection,"java/util/Collection")})
            foreach(string key in bindings.Keys.Where(k=>k.StartsWith(pair.Item2+".",StringComparison.Ordinal)).ToArray())
            {string signature=key.Substring(pair.Item2.Length+1);int paren=signature.IndexOf('(');string name=signature.Substring(0,paren),descriptor=signature.Substring(paren);if(name=="<init>"||name=="of"||name=="copyOf")continue;StandardBind(pair.Item1,name,descriptor,(r,s,a)=>r.ForwardCall(s,pair.Item1,pair.Item2,name,descriptor,a));}
            foreach(string key in bindings.Keys.Where(k=>k.StartsWith("java/util/Map.",StringComparison.Ordinal)).ToArray())
            {
                string signature=key.Substring("java/util/Map.".Length);int paren=signature.IndexOf('(');string name=signature.Substring(0,paren),descriptor=signature.Substring(paren);
                if(name=="<init>"||name=="of"||name=="copyOf")continue;
                StandardBind(map,name,descriptor,(r,s,a)=>r.ForwardMap(s,name,descriptor,a));
            }
        }
        private JHostResult ForwardMap(JValue receiver,string name,string descriptor,JValue[] arguments)
            =>ForwardCall(receiver,"com/google/common/collect/ForwardingMap","java/util/Map",name,descriptor,arguments);
        private JHostResult ForwardCall(JValue receiver,string owner,string targetType,string name,string descriptor,JValue[] arguments)
        {
            JDescriptor.Parameters(descriptor,out string returns);JValue target=default;
            var method=new JMethod(-99,"java/lang/Object","<forward-map>","()"+returns,8,0,arguments.Length+3,Array.Empty<JHandler>(),(r,f)=>
            {
                if(!r.Tick())return JStep.Yield;
                if(f.Pc==0){f.Push(receiver);f.Pc=10;}
                if(f.Pc==10)return r.Call(f,owner,"delegate","()L"+targetType+";","invokevirtual",1);
                if(f.Pc==1){target=f.Pop();f.Push(target);foreach(var arg in arguments)f.Push(arg);f.Pc=20;}
                if(f.Pc==20)return r.Call(f,targetType,name,descriptor,"invokeinterface",2);
                return returns=="V"?JStep.ReturnVoid:JStep.Return(f.Pop());
            });return JHostResult.Schedule(new JFrame(method,default,Array.Empty<JValue>()));
        }
    }
}

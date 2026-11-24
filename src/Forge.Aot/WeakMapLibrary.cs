using System;
using System.Collections.Generic;
using System.Linq;

namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class WeakMapEntry
        {
            internal readonly WeakReference<JObject>? Key;internal JValue Value;
            internal WeakMapEntry(JValue key,JValue value){Key=key.Reference==null?null:new WeakReference<JObject>(key.Reference);Value=value;}
            internal bool TryKey(out JValue value){if(Key==null){value=JValue.R(null);return true;}if(Key.TryGetTarget(out var target)){value=JValue.R(target);return true;}value=default;return false;}
        }
        private sealed class WeakMapStorage
        {
            internal readonly List<WeakMapEntry> Entries=new List<WeakMapEntry>();internal int Version;
            internal void Prune(){Entries.RemoveAll(e=>!e.TryKey(out _));}
        }
        private sealed class SynchronizedMapTarget
        {internal readonly JValue Target;internal SynchronizedMapTarget(JValue target){Target=target;}}
        private int WeakIndex(WeakMapStorage map,JValue key){map.Prune();for(int i=0;i<map.Entries.Count;i++)if(map.Entries[i].TryKey(out var candidate)&&NativeEqual(candidate,key))return i;return -1;}
        private JValue WeakPut(WeakMapStorage map,JValue key,JValue value){int at=WeakIndex(map,key);if(at<0){map.Entries.Add(new WeakMapEntry(key,value));map.Version++;return JValue.R(null);}var old=map.Entries[at].Value;map.Entries[at].Value=value;return old;}
        private void InstallWeakMaps()
        {
            const string type="java/util/WeakHashMap";NativeClass(type,"java/lang/Object","java/util/Map");
            StandardBind(type,"<init>","()V",(r,s,a)=>{var obj=r.NonNull(s);obj.Payload=new WeakMapStorage();obj.HostStorage=true;return Done();});
            StandardBind(type,"get","(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var map=r.HostPayload<WeakMapStorage>(s);int at=r.WeakIndex(map,a[0]);return Done(at<0?JValue.R(null):map.Entries[at].Value);});
            StandardBind(type,"put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>Done(r.WeakPut(r.HostPayload<WeakMapStorage>(s),a[0],a[1])));
            StandardBind(type,"containsKey","(Ljava/lang/Object;)Z",(r,s,a)=>Done(JValue.I(r.WeakIndex(r.HostPayload<WeakMapStorage>(s),a[0])>=0?1:0)));
            StandardBind(type,"size","()I",(r,s,a)=>{var map=r.HostPayload<WeakMapStorage>(s);map.Prune();return Done(JValue.I(map.Entries.Count));});
            StandardBind(type,"isEmpty","()Z",(r,s,a)=>{var map=r.HostPayload<WeakMapStorage>(s);map.Prune();return Done(JValue.I(map.Entries.Count==0?1:0));});
            StandardBind(type,"clear","()V",(r,s,a)=>{var map=r.HostPayload<WeakMapStorage>(s);map.Entries.Clear();map.Version++;return Done();});
            StandardBind(type,"remove","(Ljava/lang/Object;)Ljava/lang/Object;",(r,s,a)=>{var map=r.HostPayload<WeakMapStorage>(s);int at=r.WeakIndex(map,a[0]);if(at<0)return Done(JValue.R(null));var value=map.Entries[at].Value;map.Entries.RemoveAt(at);map.Version++;return Done(value);});
            StandardBind(type,"computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;",(r,s,a)=>
            {
                r.NonNull(a[1]);var map=r.HostPayload<WeakMapStorage>(s);int at=r.WeakIndex(map,a[0]);if(at>=0&&map.Entries[at].Value.Reference!=null)return Done(map.Entries[at].Value);int version=map.Version;
                return r.Callback("java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;",a[1],new[]{a[0]},(t,value)=>{if(map.Version!=version)throw t.Fault("java/util/ConcurrentModificationException");if(value.Reference!=null)t.WeakPut(map,a[0],value);return value;});
            });
            foreach(var binding in bindings.Where(b=>b.Key.StartsWith("java/util/Map.",StringComparison.Ordinal)).ToArray())
            {
                string signature=binding.Key.Substring("java/util/Map.".Length);int start=signature.IndexOf('(');string name=signature.Substring(0,start),descriptor=signature.Substring(start);
                StandardBind("aot/SynchronizedMap",name,descriptor,(r,s,a)=>{var wrapper=r.HostPayload<SynchronizedMapTarget>(s);lock(wrapper)return Done(r.InlineCall("java/util/Map",name,descriptor,wrapper.Target,a));});
            }
        }
    }
}

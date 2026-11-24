// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1093{
internal static JClass Build(){var c=new JClass("forge/trackable/TrackableObject","java/lang/Object",new string[]{"forge/game/IIdentifiable","java/io/Serializable"},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(7386836745378571056L),null));
c.Add(new JField("id","I",false,JValue.Default("I"),null));
c.Add(new JField("tracker","Lforge/trackable/Tracker;",false,JValue.Default("Lforge/trackable/Tracker;"),null));
c.Add(new JField("props","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("version","I",false,JValue.Default("I"),null));
c.Add(new JField("consumers","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JMethod(11538,"forge/trackable/TrackableObject","<init>","(ILforge/trackable/Tracker;)V",4,3,4,new JHandler[]{},M11538));
c.Add(new JMethod(11539,"forge/trackable/TrackableObject","getId","()I",17,1,1,new JHandler[]{},M11539));
c.Add(new JMethod(11540,"forge/trackable/TrackableObject","setTracker","(Lforge/trackable/Tracker;)V",1,2,2,new JHandler[]{},M11540));
c.Add(new JMethod(11541,"forge/trackable/TrackableObject","getTracker","()Lforge/trackable/Tracker;",17,1,1,new JHandler[]{},M11541));
c.Add(new JMethod(11542,"forge/trackable/TrackableObject","hashCode","()I",1,1,1,new JHandler[]{},M11542));
c.Add(new JMethod(11543,"forge/trackable/TrackableObject","equals","(Ljava/lang/Object;)Z",1,2,2,new JHandler[]{},M11543));
c.Add(new JMethod(11544,"forge/trackable/TrackableObject","getProps","()Ljava/util/Map;",1,1,1,new JHandler[]{},M11544));
c.Add(new JMethod(11545,"forge/trackable/TrackableObject","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;",20,3,2,new JHandler[]{},M11545));
c.Add(new JMethod(11546,"forge/trackable/TrackableObject","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V",17,4,4,new JHandler[]{},M11546));
c.Add(new JMethod(11547,"forge/trackable/TrackableObject","markDirtyForConsumers","(Lforge/trackable/TrackableProperty;)V",2,4,3,new JHandler[]{},M11547));
c.Add(new JMethod(11548,"forge/trackable/TrackableObject","updateObjLookup","()V",17,3,3,new JHandler[]{},M11548));
c.Add(new JMethod(11549,"forge/trackable/TrackableObject","flagAsChanged","(Lforge/trackable/TrackableProperty;)V",20,2,4,new JHandler[]{},M11549));
c.Add(new JMethod(11550,"forge/trackable/TrackableObject","getVersion","()I",1,1,1,new JHandler[]{},M11550));
c.Add(new JMethod(11551,"forge/trackable/TrackableObject","hasConsumer","(I)Z",1,2,2,new JHandler[]{},M11551));
c.Add(new JMethod(11552,"forge/trackable/TrackableObject","registerConsumer","(I)V",1,2,3,new JHandler[]{},M11552));
c.Add(new JMethod(11553,"forge/trackable/TrackableObject","unregisterConsumer","(I)V",1,2,2,new JHandler[]{},M11553));
c.Add(new JMethod(11554,"forge/trackable/TrackableObject","getAndClearDirtyProps","(I)Ljava/util/EnumSet;",1,4,2,new JHandler[]{},M11554));
c.Add(new JMethod(11555,"forge/trackable/TrackableObject","setCard","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/trackable/TrackableProperty;)Lforge/game/card/Card;",1,4,3,new JHandler[]{},M11555));
c.Add(new JMethod(11556,"forge/trackable/TrackableObject","setCards","(Lforge/game/card/CardCollection;Lforge/game/card/CardCollection;Lforge/trackable/TrackableProperty;)Lforge/game/card/CardCollection;",1,4,3,new JHandler[]{},M11556));
c.Add(new JMethod(11557,"forge/trackable/TrackableObject","setCards","(Lforge/game/card/CardCollection;Ljava/lang/Iterable;Lforge/trackable/TrackableProperty;)Lforge/game/card/CardCollection;",1,4,5,new JHandler[]{},M11557));
c.Add(new JMethod(11558,"forge/trackable/TrackableObject","addCard","(Lforge/game/card/CardCollection;Lforge/game/card/Card;Lforge/trackable/TrackableProperty;)Lforge/game/card/CardCollection;",1,5,3,new JHandler[]{},M11558));
c.Add(new JMethod(11559,"forge/trackable/TrackableObject","addCards","(Lforge/game/card/CardCollection;Ljava/lang/Iterable;Lforge/trackable/TrackableProperty;)Lforge/game/card/CardCollection;",1,8,3,new JHandler[]{},M11559));
c.Add(new JMethod(11560,"forge/trackable/TrackableObject","removeCard","(Lforge/game/card/CardCollection;Lforge/game/card/Card;Lforge/trackable/TrackableProperty;)Lforge/game/card/CardCollection;",1,5,3,new JHandler[]{},M11560));
c.Add(new JMethod(11561,"forge/trackable/TrackableObject","removeCards","(Lforge/game/card/CardCollection;Ljava/lang/Iterable;Lforge/trackable/TrackableProperty;)Lforge/game/card/CardCollection;",1,8,3,new JHandler[]{},M11561));
c.Add(new JMethod(11562,"forge/trackable/TrackableObject","clearCards","(Lforge/game/card/CardCollection;Lforge/trackable/TrackableProperty;)Lforge/game/card/CardCollection;",1,3,3,new JHandler[]{},M11562));
}

internal static JStep M11538(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/trackable/TrackableObject","id","I",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/trackable/TrackableObject","tracker","Lforge/trackable/Tracker;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{if(!rt.EnsureInitialized(f,"java/util/EnumMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/EnumMap")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.ClassObject("forge/trackable/TrackableProperty")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/EnumMap","<init>","(Ljava/lang/Class;)V","invokespecial",24);}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/trackable/TrackableObject","props","Ljava/util/Map;",value);f.Pc=27;continue;}
case 27:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11539(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","id","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11540(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/trackable/TrackableObject","tracker","Lforge/trackable/Tracker;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11541(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","tracker","Lforge/trackable/Tracker;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11542(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","id","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11543(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/Object","hashCode","()I","invokevirtual",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/trackable/TrackableObject","hashCode","()I","invokevirtual",14);}
case 14:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?35:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",21);}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",25);}
case 25:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?35:31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{f.Pc=36;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11544(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","props","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11545(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","props","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference!=null?20:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/trackable/TrackableProperty","getDefaultValue","()Ljava/lang/Object;","invokevirtual",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11546(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","tracker","Lforge/trackable/Tracker;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?78:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","tracker","Lforge/trackable/Tracker;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/trackable/Tracker","isFrozen","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?78:17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/trackable/TrackableProperty","getFreezeMode","()Lforge/trackable/TrackableProperty$FreezeMode;","invokevirtual",23);}
case 23:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","RespectsFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","RespectsFreeze","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=26;continue;}
case 26:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?34:29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Pc=63;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/trackable/TrackableProperty","getFreezeMode","()Lforge/trackable/TrackableProperty$FreezeMode;","invokevirtual",38);}
case 38:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty$FreezeMode","IgnoresFreezeIfUnset","Lforge/trackable/TrackableProperty$FreezeMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty$FreezeMode","IgnoresFreezeIfUnset","Lforge/trackable/TrackableProperty$FreezeMode;"));f.Pc=41;continue;}
case 41:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?63:44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","props","Ljava/util/Map;"));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",54);}
case 54:{f.Pc=f.Pop().Reference==null?61:57;continue;}
case 57:{f.Push(JValue.I(1));f.Pc=58;continue;}
case 58:{f.Pc=62;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{f.Locals[3]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{f.Pc=f.Pop().Int==0?78:67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","tracker","Lforge/trackable/Tracker;"));f.Pc=71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/trackable/Tracker","addDelayedPropChange","(Lforge/trackable/TrackableObject;Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",77);}
case 77:{return JStep.ReturnVoid;}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{f.Pc=f.Pop().Reference==null?93:82;continue;}
case 82:{f.Push(f.Locals[2]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/trackable/TrackableProperty","getDefaultValue","()Ljava/lang/Object;","invokevirtual",87);}
case 87:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?123:93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","props","Ljava/util/Map;"));f.Pc=97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",103);}
case 103:{f.Pc=f.Pop().Reference==null?155:106;continue;}
case 106:{f.Push(f.Locals[0]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/trackable/TrackableObject","markDirtyForConsumers","(Lforge/trackable/TrackableProperty;)V","invokevirtual",111);}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","tracker","Lforge/trackable/Tracker;"));f.Pc=116;continue;}
case 116:{f.Push(f.Locals[2]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/trackable/TrackableProperty","updateObjLookup","(Lforge/trackable/Tracker;Ljava/lang/Object;)V","invokevirtual",120);}
case 120:{f.Pc=155;continue;}
case 123:{f.Push(f.Locals[2]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","props","Ljava/util/Map;"));f.Pc=128;continue;}
case 128:{f.Push(f.Locals[1]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[2]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",135);}
case 135:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",138);}
case 138:{f.Pc=f.Pop().Int!=0?155:141;continue;}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[1]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/trackable/TrackableObject","markDirtyForConsumers","(Lforge/trackable/TrackableProperty;)V","invokevirtual",146);}
case 146:{f.Push(f.Locals[1]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[0]);f.Pc=148;continue;}
case 148:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","tracker","Lforge/trackable/Tracker;"));f.Pc=151;continue;}
case 151:{f.Push(f.Locals[2]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/trackable/TrackableProperty","updateObjLookup","(Lforge/trackable/Tracker;Ljava/lang/Object;)V","invokevirtual",155);}
case 155:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11547(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","consumers","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?8:7;continue;}
case 7:{return JStep.ReturnVoid;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","version","I"));f.Pc=13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=15;continue;}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/trackable/TrackableObject","version","I",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","consumers","Ljava/util/Map;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",27);}
case 27:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",32);}
case 32:{f.Locals[2]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",39);}
case 39:{f.Pc=f.Pop().Int==0?61:42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/EnumSet"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{f.Locals[3]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/EnumSet","add","(Ljava/lang/Object;)Z","invokevirtual",57);}
case 57:{f.StackOp("pop");f.Pc=58;continue;}
case 58:{f.Pc=33;continue;}
case 61:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11548(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","props","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[1]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?59:24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/trackable/TrackableProperty"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","tracker","Lforge/trackable/Tracker;"));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",53);}
case 53:{return rt.Call(f,"forge/trackable/TrackableProperty","updateObjLookup","(Lforge/trackable/Tracker;Ljava/lang/Object;)V","invokevirtual",56);}
case 56:{f.Pc=15;continue;}
case 59:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11549(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/trackable/TrackableObject","markDirtyForConsumers","(Lforge/trackable/TrackableProperty;)V","invokevirtual",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","tracker","Lforge/trackable/Tracker;"));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","props","Ljava/util/Map;"));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",20);}
case 20:{return rt.Call(f,"forge/trackable/TrackableProperty","updateObjLookup","(Lforge/trackable/Tracker;Ljava/lang/Object;)V","invokevirtual",23);}
case 23:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11550(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","version","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11551(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","consumers","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?27:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","consumers","Ljava/util/Map;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",15);}
case 15:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?27:23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Pc=28;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11552(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","consumers","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?18:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",15);}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/trackable/TrackableObject","consumers","Ljava/util/Map;",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","consumers","Ljava/util/Map;"));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",26);}
case 26:{f.Push(JValue.R(rt.ClassObject("forge/trackable/TrackableProperty")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",31);}
case 31:{return rt.Call(f,"java/util/Map","putIfAbsent","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",36);}
case 36:{f.StackOp("pop");f.Pc=37;continue;}
case 37:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11553(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","consumers","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?38:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","consumers","Ljava/util/Map;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",15);}
case 15:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",20);}
case 20:{f.StackOp("pop");f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","consumers","Ljava/util/Map;"));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int==0?38:33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(null));f.Pc=35;continue;}
case 35:{var value=f.Pop();rt.PutField(f.Pop(),"forge/trackable/TrackableObject","consumers","Ljava/util/Map;",value);f.Pc=38;continue;}
case 38:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11554(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","consumers","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?13:7;continue;}
case 7:{f.Push(JValue.R(rt.ClassObject("forge/trackable/TrackableProperty")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",12);}
case 12:{return JStep.Return(f.Pop());}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableObject","consumers","Ljava/util/Map;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",21);}
case 21:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",26);}
case 26:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/EnumSet"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=29;continue;}
case 29:{f.Locals[2]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Pc=f.Pop().Reference==null?41:34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/EnumSet","isEmpty","()Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int==0?47:41;continue;}
case 41:{f.Push(JValue.R(rt.ClassObject("forge/trackable/TrackableProperty")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",46);}
case 46:{return JStep.Return(f.Pop());}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/EnumSet","copyOf","(Ljava/util/EnumSet;)Ljava/util/EnumSet;","invokestatic",51);}
case 51:{f.Locals[3]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/EnumSet","clear","()V","invokevirtual",56);}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11555(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?14:5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/game/card/Card;)Lforge/game/card/CardView;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/trackable/TrackableObject","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11556(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?11:4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?19:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(null));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/trackable/TrackableObject","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",17);}
case 17:{f.Push(JValue.R(null));f.Pc=18;continue;}
case 18:{return JStep.Return(f.Pop());}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/card/CardView","getCollection","(Ljava/lang/Iterable;)Lforge/trackable/TrackableCollection;","invokestatic",25);}
case 25:{return rt.Call(f,"forge/trackable/TrackableObject","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",28);}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11557(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?12:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/trackable/TrackableObject","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",10);}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",22);}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/trackable/TrackableObject","setCards","(Lforge/game/card/CardCollection;Lforge/game/card/CardCollection;Lforge/trackable/TrackableProperty;)Lforge/game/card/CardCollection;","invokevirtual",26);}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11558(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Reference!=null?18:10;continue;}
case 10:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",17);}
case 17:{f.Locals[1]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int==0?87:26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/trackable/TrackableObject","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/trackable/TrackableCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[4]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{f.Pc=f.Pop().Reference!=null?70:41;continue;}
case 41:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableCollection")));f.Pc=44;continue;}
case 44:{f.StackOp("dup");f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/trackable/TrackableCollection","<init>","()V","invokespecial",48);}
case 48:{f.Locals[4]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/card/Card","getView","()Lforge/game/card/CardView;","invokevirtual",56);}
case 56:{return rt.Call(f,"forge/trackable/TrackableCollection","add","(Ljava/lang/Object;)Z","invokevirtual",59);}
case 59:{f.StackOp("pop");f.Pc=60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/trackable/TrackableObject","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",67);}
case 67:{f.Pc=87;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[2]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/card/Card","getView","()Lforge/game/card/CardView;","invokevirtual",76);}
case 76:{return rt.Call(f,"forge/trackable/TrackableCollection","add","(Ljava/lang/Object;)Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int==0?87:82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[3]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/trackable/TrackableObject","flagAsChanged","(Lforge/trackable/TrackableProperty;)V","invokevirtual",87);}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11559(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/trackable/TrackableObject","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",11);}
case 11:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/trackable/TrackableCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=14;continue;}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Reference!=null?28:20;continue;}
case 20:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",27);}
case 27:{f.Locals[1]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{f.Locals[5]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",37);}
case 37:{f.Locals[6]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[6]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",46);}
case 46:{f.Pc=f.Pop().Int==0?129:49;continue;}
case 49:{f.Push(f.Locals[6]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",56);}
case 56:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=59;continue;}
case 59:{f.Locals[7]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[7]);f.Pc=63;continue;}
case 63:{f.Pc=f.Pop().Reference==null?126:66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[7]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?126:75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{f.Pc=f.Pop().Reference!=null?110:80;continue;}
case 80:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableCollection")));f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/trackable/TrackableCollection","<init>","()V","invokespecial",87);}
case 87:{f.Locals[4]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[7]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/card/Card","getView","()Lforge/game/card/CardView;","invokevirtual",96);}
case 96:{return rt.Call(f,"forge/trackable/TrackableCollection","add","(Ljava/lang/Object;)Z","invokevirtual",99);}
case 99:{f.StackOp("pop");f.Pc=100;continue;}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[3]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[4]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/trackable/TrackableObject","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",107);}
case 107:{f.Pc=126;continue;}
case 110:{f.Push(f.Locals[4]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[7]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/card/Card","getView","()Lforge/game/card/CardView;","invokevirtual",117);}
case 117:{return rt.Call(f,"forge/trackable/TrackableCollection","add","(Ljava/lang/Object;)Z","invokevirtual",120);}
case 120:{f.Pc=f.Pop().Int==0?126:123;continue;}
case 123:{f.Push(JValue.I(1));f.Pc=124;continue;}
case 124:{f.Locals[5]=f.Pop();f.Pc=126;continue;}
case 126:{f.Pc=39;continue;}
case 129:{f.Push(f.Locals[5]);f.Pc=131;continue;}
case 131:{f.Pc=f.Pop().Int==0?139:134;continue;}
case 134:{f.Push(f.Locals[0]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[3]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/trackable/TrackableObject","flagAsChanged","(Lforge/trackable/TrackableProperty;)V","invokevirtual",139);}
case 139:{f.Push(f.Locals[1]);f.Pc=140;continue;}
case 140:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11560(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?8:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference!=null?10:8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?85:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/trackable/TrackableObject","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/trackable/TrackableCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{f.Locals[4]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Reference!=null?42:33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(null));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/trackable/TrackableObject","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",39);}
case 39:{f.Pc=76;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/Card","getView","()Lforge/game/card/CardView;","invokevirtual",48);}
case 48:{return rt.Call(f,"forge/trackable/TrackableCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int==0?76:54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/trackable/TrackableCollection","isEmpty","()Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int==0?71:62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{f.Push(JValue.R(null));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/trackable/TrackableObject","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",68);}
case 68:{f.Pc=76;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/trackable/TrackableObject","flagAsChanged","(Lforge/trackable/TrackableProperty;)V","invokevirtual",76);}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",80);}
case 80:{f.Pc=f.Pop().Int==0?85:83;continue;}
case 83:{f.Push(JValue.R(null));f.Pc=84;continue;}
case 84:{f.Locals[1]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11561(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?8:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference!=null?10:8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/trackable/TrackableObject","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",15);}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/trackable/TrackableCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{f.Locals[5]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",29);}
case 29:{f.Locals[6]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[6]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",38);}
case 38:{f.Pc=f.Pop().Int==0?130:41;continue;}
case 41:{f.Push(f.Locals[6]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{f.Locals[7]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[7]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int==0?127:62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{f.Pc=f.Pop().Reference!=null?76:67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[3]);f.Pc=69;continue;}
case 69:{f.Push(JValue.R(null));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/trackable/TrackableObject","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",73);}
case 73:{f.Pc=115;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[7]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/card/Card","getView","()Lforge/game/card/CardView;","invokevirtual",83);}
case 83:{return rt.Call(f,"forge/trackable/TrackableCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",86);}
case 86:{f.Pc=f.Pop().Int==0?115:89;continue;}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/trackable/TrackableCollection","isEmpty","()Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int==0?112:97;continue;}
case 97:{f.Push(JValue.R(null));f.Pc=98;continue;}
case 98:{f.Locals[4]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[3]);f.Pc=102;continue;}
case 102:{f.Push(JValue.R(null));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/trackable/TrackableObject","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",106);}
case 106:{f.Push(JValue.I(0));f.Pc=107;continue;}
case 107:{f.Locals[5]=f.Pop();f.Pc=109;continue;}
case 109:{f.Pc=115;continue;}
case 112:{f.Push(JValue.I(1));f.Pc=113;continue;}
case 113:{f.Locals[5]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",119);}
case 119:{f.Pc=f.Pop().Int==0?127:122;continue;}
case 122:{f.Push(JValue.R(null));f.Pc=123;continue;}
case 123:{f.Locals[1]=f.Pop();f.Pc=124;continue;}
case 124:{f.Pc=130;continue;}
case 127:{f.Pc=31;continue;}
case 130:{f.Push(f.Locals[5]);f.Pc=132;continue;}
case 132:{f.Pc=f.Pop().Int==0?140:135;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[3]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/trackable/TrackableObject","flagAsChanged","(Lforge/trackable/TrackableProperty;)V","invokevirtual",140);}
case 140:{f.Push(f.Locals[1]);f.Pc=141;continue;}
case 141:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11562(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?10:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/trackable/TrackableObject","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",10);}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

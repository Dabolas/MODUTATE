// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1097{
internal static JClass Build(){var c=new JClass("forge/trackable/TrackableTypes$TrackableCollectionType","forge/trackable/TrackableTypes$TrackableType",new string[]{},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("itemType","Lforge/trackable/TrackableTypes$TrackableObjectType;",false,JValue.Default("Lforge/trackable/TrackableTypes$TrackableObjectType;"),null));
c.Add(new JMethod(11582,"forge/trackable/TrackableTypes$TrackableCollectionType","<init>","(Lforge/trackable/TrackableTypes$TrackableObjectType;)V",2,2,2,new JHandler[]{},M11582));
c.Add(new JMethod(11583,"forge/trackable/TrackableTypes$TrackableCollectionType","updateObjLookup","(Lforge/trackable/Tracker;Lforge/trackable/TrackableCollection;)V",4,5,3,new JHandler[]{},M11583));
c.Add(new JMethod(11584,"forge/trackable/TrackableTypes$TrackableCollectionType","updateObjLookup","(Lforge/trackable/Tracker;Ljava/lang/Object;)V",4164,3,3,new JHandler[]{},M11584));
}

internal static JStep M11582(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/trackable/TrackableTypes$TrackableCollectionType","itemType","Lforge/trackable/TrackableTypes$TrackableObjectType;",value);f.Pc=10;continue;}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11583(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?47:4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/trackable/TrackableCollection","iterator","()Ljava/util/Iterator;","invokevirtual",8);}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",15);}
case 15:{f.Pc=f.Pop().Int==0?47:18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",24);}
case 24:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/trackable/TrackableObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=27;continue;}
case 27:{f.Locals[4]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{f.Pc=f.Pop().Reference==null?44:34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableTypes$TrackableCollectionType","itemType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableObjectType","updateObjLookup","(Lforge/trackable/Tracker;Lforge/trackable/TrackableObject;)V","invokevirtual",44);}
case 44:{f.Pc=9;continue;}
case 47:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11584(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/trackable/TrackableCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableCollectionType","updateObjLookup","(Lforge/trackable/Tracker;Lforge/trackable/TrackableCollection;)V","invokevirtual",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

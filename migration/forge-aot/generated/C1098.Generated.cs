// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1098{
internal static JClass Build(){var c=new JClass("forge/trackable/TrackableTypes$TrackableObjectType","forge/trackable/TrackableTypes$TrackableType",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(11585,"forge/trackable/TrackableTypes$TrackableObjectType","<init>","()V",2,1,2,new JHandler[]{},M11585));
c.Add(new JMethod(11586,"forge/trackable/TrackableTypes$TrackableObjectType","lookup","(Lforge/trackable/TrackableObject;)Lforge/trackable/TrackableObject;",1,3,4,new JHandler[]{},M11586));
c.Add(new JMethod(11587,"forge/trackable/TrackableTypes$TrackableObjectType","updateObjLookup","(Lforge/trackable/Tracker;Lforge/trackable/TrackableObject;)V",4,3,4,new JHandler[]{},M11587));
c.Add(new JMethod(11588,"forge/trackable/TrackableTypes$TrackableObjectType","updateObjLookup","(Lforge/trackable/Tracker;Ljava/lang/Object;)V",4164,3,3,new JHandler[]{},M11588));
}

internal static JStep M11585(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V","invokespecial",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11586(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/trackable/TrackableObject","getTracker","()Lforge/trackable/Tracker;","invokevirtual",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/trackable/TrackableObject","getId","()I","invokevirtual",15);}
case 15:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",18);}
case 18:{return rt.Call(f,"forge/trackable/Tracker","getObj","(Lforge/trackable/TrackableTypes$TrackableType;Ljava/lang/Integer;)Ljava/lang/Object;","invokevirtual",21);}
case 21:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/trackable/TrackableObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=24;continue;}
case 24:{f.Locals[2]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Pc=f.Pop().Reference!=null?47:29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/trackable/TrackableObject","getTracker","()Lforge/trackable/Tracker;","invokevirtual",33);}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/trackable/TrackableObject","getId","()I","invokevirtual",38);}
case 38:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",41);}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/trackable/Tracker","putObj","(Lforge/trackable/TrackableTypes$TrackableType;Ljava/lang/Integer;Ljava/lang/Object;)V","invokevirtual",45);}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{return JStep.Return(f.Pop());}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11587(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?5:4;continue;}
case 4:{return JStep.ReturnVoid;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference==null?41:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/trackable/TrackableObject","getId","()I","invokevirtual",15);}
case 15:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",18);}
case 18:{return rt.Call(f,"forge/trackable/Tracker","hasObj","(Lforge/trackable/TrackableTypes$TrackableType;Ljava/lang/Integer;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int!=0?41:24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/trackable/TrackableObject","getId","()I","invokevirtual",30);}
case 30:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",33);}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/trackable/Tracker","putObj","(Lforge/trackable/TrackableTypes$TrackableType;Ljava/lang/Integer;Ljava/lang/Object;)V","invokevirtual",37);}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/trackable/TrackableObject","updateObjLookup","()V","invokevirtual",41);}
case 41:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11588(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/trackable/TrackableObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableObjectType","updateObjLookup","(Lforge/trackable/Tracker;Lforge/trackable/TrackableObject;)V","invokevirtual",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

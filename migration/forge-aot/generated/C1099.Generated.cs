// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1099{
internal static JClass Build(){var c=new JClass("forge/trackable/TrackableTypes$TrackableType","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("defaultValue","Ljava/lang/Object;",false,JValue.Default("Ljava/lang/Object;"),null));
c.Add(new JMethod(11589,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V",2,2,2,new JHandler[]{},M11589));
c.Add(new JMethod(11590,"forge/trackable/TrackableTypes$TrackableType","updateObjLookup","(Lforge/trackable/Tracker;Ljava/lang/Object;)V",4,3,0,new JHandler[]{},M11590));
c.Add(new JMethod(11591,"forge/trackable/TrackableTypes$TrackableType","getDefaultValue","()Ljava/lang/Object;",4,1,1,new JHandler[]{},M11591));
}

internal static JStep M11589(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/trackable/TrackableTypes$TrackableType","defaultValue","Ljava/lang/Object;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11590(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11591(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/TrackableTypes$TrackableType","defaultValue","Ljava/lang/Object;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1101{
internal static JClass Build(){var c=new JClass("forge/trackable/Tracker$DelayedPropChange","java/lang/Object",new string[]{},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("object","Lforge/trackable/TrackableObject;",false,JValue.Default("Lforge/trackable/TrackableObject;"),null));
c.Add(new JField("prop","Lforge/trackable/TrackableProperty;",false,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("value","Ljava/lang/Object;",false,JValue.Default("Ljava/lang/Object;"),null));
c.Add(new JField("this$0","Lforge/trackable/Tracker;",false,JValue.Default("Lforge/trackable/Tracker;"),null));
c.Add(new JMethod(11603,"forge/trackable/Tracker$DelayedPropChange","<init>","(Lforge/trackable/Tracker;Lforge/trackable/TrackableObject;Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V",2,5,2,new JHandler[]{},M11603));
c.Add(new JMethod(11604,"forge/trackable/Tracker$DelayedPropChange","toString","()Ljava/lang/String;",1,1,3,new JHandler[]{},M11604));
}

internal static JStep M11603(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/trackable/Tracker$DelayedPropChange","this$0","Lforge/trackable/Tracker;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/trackable/Tracker$DelayedPropChange","object","Lforge/trackable/TrackableObject;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/trackable/Tracker$DelayedPropChange","prop","Lforge/trackable/TrackableProperty;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/trackable/Tracker$DelayedPropChange","value","Ljava/lang/Object;",value);f.Pc=25;continue;}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11604(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker$DelayedPropChange","prop","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker$DelayedPropChange","object","Lforge/trackable/TrackableObject;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker$DelayedPropChange","value","Ljava/lang/Object;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",21);}
case 21:{return rt.DynamicCall(f,"forge/trackable/Tracker$DelayedPropChange:11604:21:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",26);}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

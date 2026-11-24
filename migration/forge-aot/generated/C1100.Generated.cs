// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1100{
internal static JClass Build(){var c=new JClass("forge/trackable/Tracker","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("freezeCounter","I",false,JValue.Default("I"),null));
c.Add(new JField("delayedPropChanges","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("objLookups","Lcom/google/common/collect/Table;",false,JValue.Default("Lcom/google/common/collect/Table;"),null));
c.Add(new JMethod(11592,"forge/trackable/Tracker","<init>","()V",1,1,2,new JHandler[]{},M11592));
c.Add(new JMethod(11593,"forge/trackable/Tracker","isFrozen","()Z",17,1,1,new JHandler[]{},M11593));
c.Add(new JMethod(11594,"forge/trackable/Tracker","freeze","()V",1,1,3,new JHandler[]{},M11594));
c.Add(new JMethod(11595,"forge/trackable/Tracker","getObj","(Lforge/trackable/TrackableTypes$TrackableType;Ljava/lang/Integer;)Ljava/lang/Object;",1,3,3,new JHandler[]{},M11595));
c.Add(new JMethod(11596,"forge/trackable/Tracker","hasObj","(Lforge/trackable/TrackableTypes$TrackableType;Ljava/lang/Integer;)Z",1,3,3,new JHandler[]{},M11596));
c.Add(new JMethod(11597,"forge/trackable/Tracker","putObj","(Lforge/trackable/TrackableTypes$TrackableType;Ljava/lang/Integer;Ljava/lang/Object;)V",1,4,4,new JHandler[]{},M11597));
c.Add(new JMethod(11598,"forge/trackable/Tracker","unfreeze","()V",1,3,3,new JHandler[]{},M11598));
c.Add(new JMethod(11599,"forge/trackable/Tracker","flush","()V",1,1,1,new JHandler[]{},M11599));
c.Add(new JMethod(11600,"forge/trackable/Tracker","addDelayedPropChange","(Lforge/trackable/TrackableObject;Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V",1,4,7,new JHandler[]{},M11600));
c.Add(new JMethod(11601,"forge/trackable/Tracker","clearDelayed","()V",1,1,1,new JHandler[]{},M11601));
c.Add(new JMethod(11602,"forge/trackable/Tracker","getDelayedPropsFor","(Lforge/trackable/TrackableObject;)Ljava/util/Map;",1,5,3,new JHandler[]{},M11602));
}

internal static JStep M11592(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/trackable/Tracker","freezeCounter","I",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",13);}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/trackable/Tracker","delayedPropChanges","Ljava/util/List;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"com/google/common/collect/HashBasedTable","create","()Lcom/google/common/collect/HashBasedTable;","invokestatic",20);}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/trackable/Tracker","objLookups","Lcom/google/common/collect/Table;",value);f.Pc=23;continue;}
case 23:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11593(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker","freezeCounter","I"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int<=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11594(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.StackOp("dup");f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker","freezeCounter","I"));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/trackable/Tracker","freezeCounter","I",value);f.Pc=10;continue;}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11595(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker","objLookups","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"com/google/common/collect/Table","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11596(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker","objLookups","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"com/google/common/collect/Table","contains","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11597(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker","objLookups","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"com/google/common/collect/Table","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{f.StackOp("pop");f.Pc=13;continue;}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11598(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/trackable/Tracker","isFrozen","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?33:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker","freezeCounter","I"));f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=14;continue;}
case 14:{f.StackOp("dup_x1");f.Pc=15;continue;}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/trackable/Tracker","freezeCounter","I",value);f.Pc=18;continue;}
case 18:{f.Pc=f.Pop().Int>0?33:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker","delayedPropChanges","Ljava/util/List;"));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int==0?34:33;continue;}
case 33:{return JStep.ReturnVoid;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker","delayedPropChanges","Ljava/util/List;"));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",43);}
case 43:{f.Locals[1]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",50);}
case 50:{f.Pc=f.Pop().Int==0?81:53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",59);}
case 59:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/trackable/Tracker$DelayedPropChange"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=62;continue;}
case 62:{f.Locals[2]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker$DelayedPropChange","object","Lforge/trackable/TrackableObject;"));f.Pc=67;continue;}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker$DelayedPropChange","prop","Lforge/trackable/TrackableProperty;"));f.Pc=71;continue;}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker$DelayedPropChange","value","Ljava/lang/Object;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/trackable/TrackableObject","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",78);}
case 78:{f.Pc=44;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker","delayedPropChanges","Ljava/util/List;"));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",90);}
case 90:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11599(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/trackable/Tracker","isFrozen","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?8:7;continue;}
case 7:{return JStep.ReturnVoid;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/trackable/Tracker","unfreeze","()V","invokevirtual",12);}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/trackable/Tracker","freeze","()V","invokevirtual",16);}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11600(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker","delayedPropChanges","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"forge/trackable/Tracker$DelayedPropChange"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/Tracker$DelayedPropChange")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/trackable/Tracker$DelayedPropChange","<init>","(Lforge/trackable/Tracker;Lforge/trackable/TrackableObject;Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokespecial",15);}
case 15:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",20);}
case 20:{f.StackOp("pop");f.Pc=21;continue;}
case 21:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11601(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker","delayedPropChanges","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11602(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker","delayedPropChanges","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int==0?16:12;continue;}
case 12:{return rt.Call(f,"java/util/Collections","emptyMap","()Ljava/util/Map;","invokestatic",15);}
case 15:{return JStep.Return(f.Pop());}
case 16:{if(!rt.EnsureInitialized(f,"java/util/EnumMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/EnumMap")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.ClassObject("forge/trackable/TrackableProperty")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/EnumMap","<init>","(Ljava/lang/Class;)V","invokespecial",25);}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker","delayedPropChanges","Ljava/util/List;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",35);}
case 35:{f.Locals[3]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int==0?85:45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/trackable/Tracker$DelayedPropChange"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{f.Locals[4]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker$DelayedPropChange","object","Lforge/trackable/TrackableObject;"));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?82:65;continue;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker$DelayedPropChange","prop","Lforge/trackable/TrackableProperty;"));f.Pc=71;continue;}
case 71:{f.Push(f.Locals[4]);f.Pc=73;continue;}
case 73:{f.Push(rt.GetField(f.Pop(),"forge/trackable/Tracker$DelayedPropChange","value","Ljava/lang/Object;"));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",81);}
case 81:{f.StackOp("pop");f.Pc=82;continue;}
case 82:{f.Pc=36;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

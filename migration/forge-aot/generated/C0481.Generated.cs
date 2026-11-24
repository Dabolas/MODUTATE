// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C481{
internal static JClass Build(){var c=new JClass("forge/game/card/CounterCustomType","java/lang/Record",new string[]{"forge/game/card/CounterType"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("keyword","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("sMap","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JMethod(5762,"forge/game/card/CounterCustomType","<init>","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M5762));
c.Add(new JMethod(5763,"forge/game/card/CounterCustomType","get","(Ljava/lang/String;)Lforge/game/card/CounterCustomType;",9,1,5,new JHandler[]{},M5763));
c.Add(new JMethod(5764,"forge/game/card/CounterCustomType","getValues","()Ljava/util/Set;",9,0,3,new JHandler[]{},M5764));
c.Add(new JMethod(5765,"forge/game/card/CounterCustomType","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5765));
c.Add(new JMethod(5766,"forge/game/card/CounterCustomType","getName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5766));
c.Add(new JMethod(5767,"forge/game/card/CounterCustomType","hashCode","()I",17,1,1,new JHandler[]{},M5767));
c.Add(new JMethod(5768,"forge/game/card/CounterCustomType","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M5768));
c.Add(new JMethod(5769,"forge/game/card/CounterCustomType","keyword","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5769));
c.Add(new JMethod(5770,"forge/game/card/CounterCustomType","<clinit>","()V",8,0,1,new JHandler[]{},M5770));
}

internal static JStep M5762(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CounterCustomType","keyword","Ljava/lang/String;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5763(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/card/CounterCustomType","sMap","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterCustomType","sMap","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int!=0?30:12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/card/CounterCustomType","sMap","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterCustomType","sMap","Ljava/util/Map;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{if(!rt.EnsureInitialized(f,"forge/game/card/CounterCustomType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CounterCustomType")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/CounterCustomType","<init>","(Ljava/lang/String;)V","invokespecial",24);}
case 24:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/card/CounterCustomType","sMap","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterCustomType","sMap","Ljava/util/Map;"));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterCustomType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5764(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/LinkedHashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/LinkedHashSet")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/card/CounterCustomType","sMap","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterCustomType","sMap","Ljava/util/Map;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",12);}
case 12:{return rt.Call(f,"java/util/LinkedHashSet","<init>","(Ljava/util/Collection;)V","invokespecial",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5765(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CounterCustomType","keyword","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5766(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CounterCustomType","keyword","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5767(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CounterCustomType:5767:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/CounterCustomType;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5768(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/CounterCustomType:5768:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/CounterCustomType;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5769(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CounterCustomType","keyword","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5770(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",3);}
case 3:{if(!rt.StaticReady(f,"forge/game/card/CounterCustomType","sMap","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/game/card/CounterCustomType","sMap","Ljava/util/Map;",f.Pop());f.Pc=6;continue;}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

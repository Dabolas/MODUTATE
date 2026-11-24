// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C444{
internal static JClass Build(){var c=new JClass("forge/game/card/CardCloneStates","com/google/common/collect/ForwardingMap",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("dataMap","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("origin","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("ctb","Lforge/game/CardTraitBase;",false,JValue.Default("Lforge/game/CardTraitBase;"),null));
c.Add(new JMethod(4898,"forge/game/card/CardCloneStates","<init>","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)V",1,3,2,new JHandler[]{},M4898));
c.Add(new JMethod(4899,"forge/game/card/CardCloneStates","getOrigin","()Lforge/game/card/Card;",1,1,1,new JHandler[]{},M4899));
c.Add(new JMethod(4900,"forge/game/card/CardCloneStates","getSource","()Lforge/game/CardTraitBase;",1,1,1,new JHandler[]{},M4900));
c.Add(new JMethod(4901,"forge/game/card/CardCloneStates","getHost","()Lforge/game/card/Card;",1,1,1,new JHandler[]{},M4901));
c.Add(new JMethod(4902,"forge/game/card/CardCloneStates","delegate","()Ljava/util/Map;",4,1,1,new JHandler[]{},M4902));
c.Add(new JMethod(4903,"forge/game/card/CardCloneStates","get","(Lforge/card/CardStateName;)Lforge/game/card/CardState;",1,4,4,new JHandler[]{},M4903));
c.Add(new JMethod(4904,"forge/game/card/CardCloneStates","add","(Lforge/game/card/CardState;)V",1,2,3,new JHandler[]{},M4904));
c.Add(new JMethod(4905,"forge/game/card/CardCloneStates","copy","(Lforge/game/card/Card;Z)Lforge/game/card/CardCloneStates;",1,6,6,new JHandler[]{},M4905));
c.Add(new JMethod(4906,"forge/game/card/CardCloneStates","delegate","()Ljava/lang/Object;",4164,1,1,new JHandler[]{},M4906));
}

internal static JStep M4898(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/ForwardingMap","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.ClassObject("forge/card/CardStateName")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"com/google/common/collect/Maps","newEnumMap","(Ljava/lang/Class;)Ljava/util/EnumMap;","invokestatic",10);}
case 10:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardCloneStates","dataMap","Ljava/util/Map;",value);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardCloneStates","origin","Lforge/game/card/Card;",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardCloneStates","ctb","Lforge/game/CardTraitBase;",value);f.Pc=23;continue;}
case 23:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4899(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCloneStates","origin","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4900(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCloneStates","ctb","Lforge/game/CardTraitBase;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4901(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCloneStates","ctb","Lforge/game/CardTraitBase;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4902(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCloneStates","dataMap","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4903(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCloneStates","dataMap","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?22:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"com/google/common/collect/ForwardingMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokespecial",18);}
case 18:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardState"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=21;continue;}
case 21:{return JStep.Return(f.Pop());}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"com/google/common/collect/ForwardingMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokespecial",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardState"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{f.Locals[2]=f.Pop();f.Pc=33;continue;}
case 33:{if(!rt.EnsureInitialized(f,"forge/game/card/CardState"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardState")));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",41);}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/CardState","<init>","(Lforge/game/card/Card;Lforge/card/CardStateName;)V","invokespecial",45);}
case 45:{f.Locals[3]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{f.Push(JValue.I(0));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/card/CardState","copyFrom","(Lforge/game/card/CardState;Z)V","invokevirtual",52);}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCloneStates","dataMap","Ljava/util/Map;"));f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",63);}
case 63:{f.StackOp("pop");f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4904(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardCloneStates","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",9);}
case 9:{f.StackOp("pop");f.Pc=10;continue;}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4905(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCloneStates"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCloneStates")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCloneStates","origin","Lforge/game/card/Card;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCloneStates","ctb","Lforge/game/CardTraitBase;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardCloneStates","<init>","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)V","invokespecial",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardCloneStates","dataMap","Ljava/util/Map;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",25);}
case 25:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",30);}
case 30:{f.Locals[4]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",39);}
case 39:{f.Pc=f.Pop().Int==0?97:42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{f.Locals[5]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",62);}
case 62:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardStateName"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[5]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",72);}
case 72:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardState"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[5]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",83);}
case 83:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardStateName"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/card/CardStateName;Z)Lforge/game/card/CardState;","invokevirtual",90);}
case 90:{return rt.Call(f,"forge/game/card/CardCloneStates","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",93);}
case 93:{f.StackOp("pop");f.Pc=94;continue;}
case 94:{f.Pc=32;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4906(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardCloneStates","delegate","()Ljava/util/Map;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

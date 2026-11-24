// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1178{
internal static JClass Build(){var c=new JClass("forge/util/collect/FSnapshotTable$HashSnap","forge/util/collect/FSnapshotTable$Snap",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("table","Lcom/google/common/collect/Table;",false,JValue.Default("Lcom/google/common/collect/Table;"),null));
c.Add(new JField("values","Ljava/util/Collection;",false,JValue.Default("Ljava/util/Collection;"),null));
c.Add(new JMethod(12296,"forge/util/collect/FSnapshotTable$HashSnap","<init>","(Lcom/google/common/collect/Table;)V",0,2,2,new JHandler[]{},M12296));
c.Add(new JMethod(12297,"forge/util/collect/FSnapshotTable$HashSnap","size","()I",0,1,1,new JHandler[]{},M12297));
c.Add(new JMethod(12298,"forge/util/collect/FSnapshotTable$HashSnap","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",0,3,3,new JHandler[]{},M12298));
c.Add(new JMethod(12299,"forge/util/collect/FSnapshotTable$HashSnap","contains","(Ljava/lang/Object;Ljava/lang/Object;)Z",0,3,3,new JHandler[]{},M12299));
c.Add(new JMethod(12300,"forge/util/collect/FSnapshotTable$HashSnap","containsRow","(Ljava/lang/Object;)Z",0,2,2,new JHandler[]{},M12300));
c.Add(new JMethod(12301,"forge/util/collect/FSnapshotTable$HashSnap","containsColumn","(Ljava/lang/Object;)Z",0,2,2,new JHandler[]{},M12301));
c.Add(new JMethod(12302,"forge/util/collect/FSnapshotTable$HashSnap","containsValue","(Ljava/lang/Object;)Z",0,2,2,new JHandler[]{},M12302));
c.Add(new JMethod(12303,"forge/util/collect/FSnapshotTable$HashSnap","table","()Lcom/google/common/collect/Table;",0,1,1,new JHandler[]{},M12303));
c.Add(new JMethod(12304,"forge/util/collect/FSnapshotTable$HashSnap","computeRowKeys","()Ljava/util/List;",0,1,3,new JHandler[]{},M12304));
c.Add(new JMethod(12305,"forge/util/collect/FSnapshotTable$HashSnap","computeColumnKeys","()Ljava/util/List;",0,1,3,new JHandler[]{},M12305));
c.Add(new JMethod(12306,"forge/util/collect/FSnapshotTable$HashSnap","row","(Ljava/lang/Object;)Ljava/util/Map;",0,2,2,new JHandler[]{},M12306));
c.Add(new JMethod(12307,"forge/util/collect/FSnapshotTable$HashSnap","column","(Ljava/lang/Object;)Ljava/util/Map;",0,2,2,new JHandler[]{},M12307));
c.Add(new JMethod(12308,"forge/util/collect/FSnapshotTable$HashSnap","values","()Ljava/util/Collection;",0,2,3,new JHandler[]{},M12308));
c.Add(new JMethod(12309,"forge/util/collect/FSnapshotTable$HashSnap","cellSet","()Ljava/util/Set;",0,1,1,new JHandler[]{},M12309));
}

internal static JStep M12296(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable$HashSnap","table","Lcom/google/common/collect/Table;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12297(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$HashSnap","table","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/Table","size","()I","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12298(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$HashSnap","table","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"com/google/common/collect/Table","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12299(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$HashSnap","table","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"com/google/common/collect/Table","contains","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12300(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$HashSnap","table","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Table","containsRow","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12301(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$HashSnap","table","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Table","containsColumn","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12302(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$HashSnap","table","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Table","containsValue","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12303(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$HashSnap","table","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12304(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$HashSnap","table","Lcom/google/common/collect/Table;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"com/google/common/collect/Table","rowKeySet","()Ljava/util/Set;","invokeinterface",13);}
case 13:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12305(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$HashSnap","table","Lcom/google/common/collect/Table;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"com/google/common/collect/Table","columnKeySet","()Ljava/util/Set;","invokeinterface",13);}
case 13:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12306(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$HashSnap","table","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Table","row","(Ljava/lang/Object;)Ljava/util/Map;","invokeinterface",10);}
case 10:{return rt.Call(f,"java/util/Collections","unmodifiableMap","(Ljava/util/Map;)Ljava/util/Map;","invokestatic",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12307(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$HashSnap","table","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Table","column","(Ljava/lang/Object;)Ljava/util/Map;","invokeinterface",10);}
case 10:{return rt.Call(f,"java/util/Collections","unmodifiableMap","(Ljava/util/Map;)Ljava/util/Map;","invokestatic",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12308(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$HashSnap","values","Ljava/util/Collection;"));f.Pc=4;continue;}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?52:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$HashSnap","table","Lcom/google/common/collect/Table;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"com/google/common/collect/Table","isEmpty","()Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?27:21;continue;}
case 21:{return rt.Call(f,"java/util/Collections","emptyList","()Ljava/util/List;","invokestatic",24);}
case 24:{f.Pc=46;continue;}
case 27:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$HashSnap","table","Lcom/google/common/collect/Table;"));f.Pc=35;continue;}
case 35:{return rt.Call(f,"com/google/common/collect/Table","values","()Ljava/util/Collection;","invokeinterface",40);}
case 40:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",43);}
case 43:{return rt.Call(f,"java/util/Collections","unmodifiableList","(Ljava/util/List;)Ljava/util/List;","invokestatic",46);}
case 46:{f.Locals[1]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable$HashSnap","values","Ljava/util/Collection;",value);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12309(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$HashSnap","table","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/Table","isEmpty","()Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int==0?18:12;continue;}
case 12:{return rt.Call(f,"java/util/Collections","emptySet","()Ljava/util/Set;","invokestatic",15);}
case 15:{f.Pc=30;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$HashSnap","table","Lcom/google/common/collect/Table;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"com/google/common/collect/Table","cellSet","()Ljava/util/Set;","invokeinterface",27);}
case 27:{return rt.Call(f,"java/util/Collections","unmodifiableSet","(Ljava/util/Set;)Ljava/util/Set;","invokestatic",30);}
case 30:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

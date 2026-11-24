// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1176{
internal static JClass Build(){var c=new JClass("forge/util/collect/FSnapshotTable$CellSet","java/util/AbstractSet",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("s","Lforge/util/collect/FSnapshotTable$SortedSnap;",false,JValue.Default("Lforge/util/collect/FSnapshotTable$SortedSnap;"),null));
c.Add(new JMethod(12288,"forge/util/collect/FSnapshotTable$CellSet","<init>","(Lforge/util/collect/FSnapshotTable$SortedSnap;)V",0,2,2,new JHandler[]{},M12288));
c.Add(new JMethod(12289,"forge/util/collect/FSnapshotTable$CellSet","size","()I",1,1,1,new JHandler[]{},M12289));
c.Add(new JMethod(12290,"forge/util/collect/FSnapshotTable$CellSet","contains","(Ljava/lang/Object;)Z",1,4,3,new JHandler[]{},M12290));
c.Add(new JMethod(12291,"forge/util/collect/FSnapshotTable$CellSet","iterator","()Ljava/util/Iterator;",1,1,3,new JHandler[]{},M12291));
}

internal static JStep M12288(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/AbstractSet","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable$CellSet","s","Lforge/util/collect/FSnapshotTable$SortedSnap;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12289(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$CellSet","s","Lforge/util/collect/FSnapshotTable$SortedSnap;"));f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=7;continue;}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12290(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"com/google/common/collect/Table$Cell")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Table$Cell"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$CellSet","s","Lforge/util/collect/FSnapshotTable$SortedSnap;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"com/google/common/collect/Table$Cell","getRowKey","()Ljava/lang/Object;","invokeinterface",24);}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"com/google/common/collect/Table$Cell","getColumnKey","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","find","(Ljava/lang/Object;Ljava/lang/Object;)I","invokevirtual",33);}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Int<0?67:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$CellSet","s","Lforge/util/collect/FSnapshotTable$SortedSnap;"));f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(3));f.Pc=46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=48;continue;}
case 48:{f.Push(JValue.I(2));f.Pc=49;continue;}
case 49:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=50;continue;}
case 50:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"com/google/common/collect/Table$Cell","getValue","()Ljava/lang/Object;","invokeinterface",57);}
case 57:{return rt.Call(f,"java/util/Objects","equals","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokestatic",60);}
case 60:{f.Pc=f.Pop().Int==0?67:63;continue;}
case 63:{f.Push(JValue.I(1));f.Pc=64;continue;}
case 64:{f.Pc=68;continue;}
case 67:{f.Push(JValue.I(0));f.Pc=68;continue;}
case 68:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12291(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$CellSet$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$CellSet$1")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FSnapshotTable$CellSet$1","<init>","(Lforge/util/collect/FSnapshotTable$CellSet;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

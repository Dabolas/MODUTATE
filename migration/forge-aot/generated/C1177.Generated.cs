// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1177{
internal static JClass Build(){var c=new JClass("forge/util/collect/FSnapshotTable$CellSet$1","java/lang/Object",new string[]{"java/util/Iterator"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("i","I",false,JValue.Default("I"),null));
c.Add(new JField("this$0","Lforge/util/collect/FSnapshotTable$CellSet;",false,JValue.Default("Lforge/util/collect/FSnapshotTable$CellSet;"),null));
c.Add(new JMethod(12292,"forge/util/collect/FSnapshotTable$CellSet$1","<init>","(Lforge/util/collect/FSnapshotTable$CellSet;)V",0,2,2,new JHandler[]{},M12292));
c.Add(new JMethod(12293,"forge/util/collect/FSnapshotTable$CellSet$1","hasNext","()Z",1,1,2,new JHandler[]{},M12293));
c.Add(new JMethod(12294,"forge/util/collect/FSnapshotTable$CellSet$1","next","()Lcom/google/common/collect/Table$Cell;",1,2,5,new JHandler[]{},M12294));
c.Add(new JMethod(12295,"forge/util/collect/FSnapshotTable$CellSet$1","next","()Ljava/lang/Object;",4161,1,1,new JHandler[]{},M12295));
}

internal static JStep M12292(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable$CellSet$1","this$0","Lforge/util/collect/FSnapshotTable$CellSet;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12293(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$CellSet$1","i","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$CellSet$1","this$0","Lforge/util/collect/FSnapshotTable$CellSet;"));f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$CellSet","s","Lforge/util/collect/FSnapshotTable$SortedSnap;"));f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=14;continue;}
case 14:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12294(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$CellSet$1","i","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$CellSet$1","this$0","Lforge/util/collect/FSnapshotTable$CellSet;"));f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$CellSet","s","Lforge/util/collect/FSnapshotTable$SortedSnap;"));f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=14;continue;}
case 14:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?25:17;continue;}
case 17:{if(!rt.EnsureInitialized(f,"java/util/NoSuchElementException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/NoSuchElementException")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/NoSuchElementException","<init>","()V","invokespecial",24);}
case 24:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 25:{f.Push(JValue.I(3));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.StackOp("dup");f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$CellSet$1","i","I"));f.Pc=31;continue;}
case 31:{f.StackOp("dup_x1");f.Pc=32;continue;}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=34;continue;}
case 34:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable$CellSet$1","i","I",value);f.Pc=37;continue;}
case 37:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=38;continue;}
case 38:{f.Locals[1]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$CellSet$1","this$0","Lforge/util/collect/FSnapshotTable$CellSet;"));f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$CellSet","s","Lforge/util/collect/FSnapshotTable$SortedSnap;"));f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$CellSet$1","this$0","Lforge/util/collect/FSnapshotTable$CellSet;"));f.Pc=55;continue;}
case 55:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$CellSet","s","Lforge/util/collect/FSnapshotTable$SortedSnap;"));f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{f.Push(JValue.I(1));f.Pc=63;continue;}
case 63:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=64;continue;}
case 64:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$CellSet$1","this$0","Lforge/util/collect/FSnapshotTable$CellSet;"));f.Pc=69;continue;}
case 69:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$CellSet","s","Lforge/util/collect/FSnapshotTable$SortedSnap;"));f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{f.Push(JValue.I(2));f.Pc=77;continue;}
case 77:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=78;continue;}
case 78:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=79;continue;}
case 79:{return rt.Call(f,"com/google/common/collect/Tables","immutableCell","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/Table$Cell;","invokestatic",82);}
case 82:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12295(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/collect/FSnapshotTable$CellSet$1","next","()Lcom/google/common/collect/Table$Cell;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

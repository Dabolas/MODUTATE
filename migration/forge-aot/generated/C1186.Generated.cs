// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1186{
internal static JClass Build(){var c=new JClass("forge/util/collect/FSnapshotTable$ValueList$1","java/lang/Object",new string[]{"java/util/Iterator"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("i","I",false,JValue.Default("I"),null));
c.Add(new JField("this$0","Lforge/util/collect/FSnapshotTable$ValueList;",false,JValue.Default("Lforge/util/collect/FSnapshotTable$ValueList;"),null));
c.Add(new JMethod(12378,"forge/util/collect/FSnapshotTable$ValueList$1","<init>","(Lforge/util/collect/FSnapshotTable$ValueList;)V",0,2,2,new JHandler[]{},M12378));
c.Add(new JMethod(12379,"forge/util/collect/FSnapshotTable$ValueList$1","hasNext","()Z",1,1,2,new JHandler[]{},M12379));
c.Add(new JMethod(12380,"forge/util/collect/FSnapshotTable$ValueList$1","next","()Ljava/lang/Object;",1,1,6,new JHandler[]{},M12380));
}

internal static JStep M12378(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable$ValueList$1","this$0","Lforge/util/collect/FSnapshotTable$ValueList;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12379(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$ValueList$1","i","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$ValueList$1","this$0","Lforge/util/collect/FSnapshotTable$ValueList;"));f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$ValueList","n","I"));f.Pc=11;continue;}
case 11:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12380(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$ValueList$1","i","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$ValueList$1","this$0","Lforge/util/collect/FSnapshotTable$ValueList;"));f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$ValueList","n","I"));f.Pc=11;continue;}
case 11:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?22:14;continue;}
case 14:{if(!rt.EnsureInitialized(f,"java/util/NoSuchElementException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/NoSuchElementException")));f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/NoSuchElementException","<init>","()V","invokespecial",21);}
case 21:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$ValueList$1","this$0","Lforge/util/collect/FSnapshotTable$ValueList;"));f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$ValueList","d","[Ljava/lang/Object;"));f.Pc=29;continue;}
case 29:{f.Push(JValue.I(3));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$ValueList$1","i","I"));f.Pc=35;continue;}
case 35:{f.StackOp("dup_x1");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=38;continue;}
case 38:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable$ValueList$1","i","I",value);f.Pc=41;continue;}
case 41:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=42;continue;}
case 42:{f.Push(JValue.I(2));f.Pc=43;continue;}
case 43:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=44;continue;}
case 44:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=45;continue;}
case 45:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

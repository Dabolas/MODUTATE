// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1181{
internal static JClass Build(){var c=new JClass("forge/util/collect/FSnapshotTable$RowView$1","java/util/AbstractSet",new string[]{},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("this$0","Lforge/util/collect/FSnapshotTable$RowView;",false,JValue.Default("Lforge/util/collect/FSnapshotTable$RowView;"),null));
c.Add(new JMethod(12328,"forge/util/collect/FSnapshotTable$RowView$1","<init>","(Lforge/util/collect/FSnapshotTable$RowView;)V",0,2,2,new JHandler[]{},M12328));
c.Add(new JMethod(12329,"forge/util/collect/FSnapshotTable$RowView$1","size","()I",1,1,2,new JHandler[]{},M12329));
c.Add(new JMethod(12330,"forge/util/collect/FSnapshotTable$RowView$1","iterator","()Ljava/util/Iterator;",1,1,3,new JHandler[]{},M12330));
}

internal static JStep M12328(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable$RowView$1","this$0","Lforge/util/collect/FSnapshotTable$RowView;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/AbstractSet","<init>","()V","invokespecial",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12329(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$RowView$1","this$0","Lforge/util/collect/FSnapshotTable$RowView;"));f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$RowView","hi","I"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$RowView$1","this$0","Lforge/util/collect/FSnapshotTable$RowView;"));f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$RowView","lo","I"));f.Pc=14;continue;}
case 14:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12330(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$RowView$1$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$RowView$1$1")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FSnapshotTable$RowView$1$1","<init>","(Lforge/util/collect/FSnapshotTable$RowView$1;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

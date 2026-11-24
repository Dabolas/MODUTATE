// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1185{
internal static JClass Build(){var c=new JClass("forge/util/collect/FSnapshotTable$ValueList","java/util/AbstractList",new string[]{"java/util/RandomAccess"},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("d","[Ljava/lang/Object;",false,JValue.Default("[Ljava/lang/Object;"),null));
c.Add(new JField("n","I",false,JValue.Default("I"),null));
c.Add(new JMethod(12374,"forge/util/collect/FSnapshotTable$ValueList","<init>","([Ljava/lang/Object;I)V",0,3,2,new JHandler[]{},M12374));
c.Add(new JMethod(12375,"forge/util/collect/FSnapshotTable$ValueList","get","(I)Ljava/lang/Object;",1,2,4,new JHandler[]{},M12375));
c.Add(new JMethod(12376,"forge/util/collect/FSnapshotTable$ValueList","size","()I",1,1,1,new JHandler[]{},M12376));
c.Add(new JMethod(12377,"forge/util/collect/FSnapshotTable$ValueList","iterator","()Ljava/util/Iterator;",1,1,3,new JHandler[]{},M12377));
}

internal static JStep M12374(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/AbstractList","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable$ValueList","d","[Ljava/lang/Object;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable$ValueList","n","I",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12375(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int<0?12:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$ValueList","n","I"));f.Pc=9;continue;}
case 9:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?30:12;continue;}
case 12:{if(!rt.EnsureInitialized(f,"java/lang/IndexOutOfBoundsException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IndexOutOfBoundsException")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$ValueList","n","I"));f.Pc=21;continue;}
case 21:{return rt.DynamicCall(f,"forge/util/collect/FSnapshotTable$ValueList:12375:21:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(II)Ljava/lang/String;",26);}
case 26:{return rt.Call(f,"java/lang/IndexOutOfBoundsException","<init>","(Ljava/lang/String;)V","invokespecial",29);}
case 29:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$ValueList","d","[Ljava/lang/Object;"));f.Pc=34;continue;}
case 34:{f.Push(JValue.I(3));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=37;continue;}
case 37:{f.Push(JValue.I(2));f.Pc=38;continue;}
case 38:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=39;continue;}
case 39:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=40;continue;}
case 40:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12376(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$ValueList","n","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12377(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$ValueList$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$ValueList$1")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FSnapshotTable$ValueList$1","<init>","(Lforge/util/collect/FSnapshotTable$ValueList;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

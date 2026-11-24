// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1180{
internal static JClass Build(){var c=new JClass("forge/util/collect/FSnapshotTable$RowView","java/util/AbstractMap",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("d","[Ljava/lang/Object;",false,JValue.Default("[Ljava/lang/Object;"),null));
c.Add(new JField("lo","I",false,JValue.Default("I"),null));
c.Add(new JField("hi","I",false,JValue.Default("I"),null));
c.Add(new JMethod(12322,"forge/util/collect/FSnapshotTable$RowView","<init>","([Ljava/lang/Object;II)V",0,4,2,new JHandler[]{},M12322));
c.Add(new JMethod(12323,"forge/util/collect/FSnapshotTable$RowView","indexOfColumn","(Ljava/lang/Object;)I",2,6,3,new JHandler[]{new JHandler(6,75,82,"java/lang/ClassCastException"),new JHandler(76,79,82,"java/lang/ClassCastException")},M12323));
c.Add(new JMethod(12324,"forge/util/collect/FSnapshotTable$RowView","size","()I",1,1,2,new JHandler[]{},M12324));
c.Add(new JMethod(12325,"forge/util/collect/FSnapshotTable$RowView","containsKey","(Ljava/lang/Object;)Z",1,2,2,new JHandler[]{},M12325));
c.Add(new JMethod(12326,"forge/util/collect/FSnapshotTable$RowView","get","(Ljava/lang/Object;)Ljava/lang/Object;",1,3,3,new JHandler[]{},M12326));
c.Add(new JMethod(12327,"forge/util/collect/FSnapshotTable$RowView","entrySet","()Ljava/util/Set;",1,1,3,new JHandler[]{},M12327));
}

internal static JStep M12322(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/AbstractMap","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable$RowView","d","[Ljava/lang/Object;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable$RowView","lo","I",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable$RowView","hi","I",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12323(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(-1));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$RowView","lo","I"));f.Pc=10;continue;}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$RowView","hi","I"));f.Pc=15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=17;continue;}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?79:23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=26;continue;}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iushr",a,b));f.Pc=28;continue;}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$RowView","d","[Ljava/lang/Object;"));f.Pc=34;continue;}
case 34:{f.Push(JValue.I(3));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=38;continue;}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=40;continue;}
case 40:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","cmp","(Ljava/lang/Object;Ljava/lang/Object;)I","invokestatic",45);}
case 45:{f.Locals[5]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[5]);f.Pc=49;continue;}
case 49:{f.Pc=f.Pop().Int>=0?60:52;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{f.Push(JValue.I(1));f.Pc=55;continue;}
case 55:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=56;continue;}
case 56:{f.Locals[2]=f.Pop();f.Pc=57;continue;}
case 57:{f.Pc=76;continue;}
case 60:{f.Push(f.Locals[5]);f.Pc=62;continue;}
case 62:{f.Pc=f.Pop().Int<=0?73:65;continue;}
case 65:{f.Push(f.Locals[4]);f.Pc=67;continue;}
case 67:{f.Push(JValue.I(1));f.Pc=68;continue;}
case 68:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=69;continue;}
case 69:{f.Locals[3]=f.Pop();f.Pc=70;continue;}
case 70:{f.Pc=76;continue;}
case 73:{f.Push(f.Locals[4]);f.Pc=75;continue;}
case 75:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 76:{f.Pc=18;continue;}
case 79:{f.Pc=83;continue;}
case 82:{f.Locals[2]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(JValue.I(-1));f.Pc=84;continue;}
case 84:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12324(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$RowView","hi","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$RowView","lo","I"));f.Pc=8;continue;}
case 8:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12325(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/collect/FSnapshotTable$RowView","indexOfColumn","(Ljava/lang/Object;)I","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int<0?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12326(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/collect/FSnapshotTable$RowView","indexOfColumn","(Ljava/lang/Object;)I","invokevirtual",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Int<0?23:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$RowView","d","[Ljava/lang/Object;"));f.Pc=14;continue;}
case 14:{f.Push(JValue.I(3));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=17;continue;}
case 17:{f.Push(JValue.I(2));f.Pc=18;continue;}
case 18:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=19;continue;}
case 19:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Push(JValue.R(null));f.Pc=24;continue;}
case 24:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12327(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$RowView$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$RowView$1")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FSnapshotTable$RowView$1","<init>","(Lforge/util/collect/FSnapshotTable$RowView;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

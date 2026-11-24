// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1179{
internal static JClass Build(){var c=new JClass("forge/util/collect/FSnapshotTable$KeyView","java/util/AbstractSet",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("rows","Z",false,JValue.Default("Z"),null));
c.Add(new JField("this$0","Lforge/util/collect/FSnapshotTable;",false,JValue.Default("Lforge/util/collect/FSnapshotTable;"),null));
c.Add(new JMethod(12310,"forge/util/collect/FSnapshotTable$KeyView","<init>","(Lforge/util/collect/FSnapshotTable;Z)V",0,3,2,new JHandler[]{},M12310));
c.Add(new JMethod(12311,"forge/util/collect/FSnapshotTable$KeyView","keys","()Ljava/util/List;",2,1,1,new JHandler[]{},M12311));
c.Add(new JMethod(12312,"forge/util/collect/FSnapshotTable$KeyView","iterator","()Ljava/util/Iterator;",1,1,1,new JHandler[]{},M12312));
c.Add(new JMethod(12313,"forge/util/collect/FSnapshotTable$KeyView","size","()I",1,1,1,new JHandler[]{},M12313));
c.Add(new JMethod(12314,"forge/util/collect/FSnapshotTable$KeyView","contains","(Ljava/lang/Object;)Z",1,2,2,new JHandler[]{},M12314));
c.Add(new JMethod(12315,"forge/util/collect/FSnapshotTable$KeyView","remove","(Ljava/lang/Object;)Z",1,2,4,new JHandler[]{},M12315));
c.Add(new JMethod(12316,"forge/util/collect/FSnapshotTable$KeyView","removeAll","(Ljava/util/Collection;)Z",1,2,4,new JHandler[]{},M12316));
c.Add(new JMethod(12317,"forge/util/collect/FSnapshotTable$KeyView","retainAll","(Ljava/util/Collection;)Z",1,2,3,new JHandler[]{},M12317));
c.Add(new JMethod(12318,"forge/util/collect/FSnapshotTable$KeyView","removeIf","(Ljava/util/function/Predicate;)Z",1,2,3,new JHandler[]{},M12318));
c.Add(new JMethod(12319,"forge/util/collect/FSnapshotTable$KeyView","clear","()V",1,1,1,new JHandler[]{},M12319));
c.Add(new JMethod(12320,"forge/util/collect/FSnapshotTable$KeyView","lambda$removeIf$1","(Ljava/util/function/Predicate;Ljava/lang/Object;)Z",4106,2,2,new JHandler[]{},M12320));
c.Add(new JMethod(12321,"forge/util/collect/FSnapshotTable$KeyView","lambda$retainAll$0","(Ljava/util/Collection;Ljava/lang/Object;)Z",4106,2,2,new JHandler[]{},M12321));
}

internal static JStep M12310(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable$KeyView","this$0","Lforge/util/collect/FSnapshotTable;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/AbstractSet","<init>","()V","invokespecial",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable$KeyView","rows","Z",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12311(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$KeyView","rows","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?20:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$KeyView","this$0","Lforge/util/collect/FSnapshotTable;"));f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","rowKeys","()Ljava/util/List;","invokevirtual",17);}
case 17:{f.Pc=30;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$KeyView","this$0","Lforge/util/collect/FSnapshotTable;"));f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","columnKeys","()Ljava/util/List;","invokevirtual",30);}
case 30:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12312(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/collect/FSnapshotTable$KeyView","keys","()Ljava/util/List;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12313(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/collect/FSnapshotTable$KeyView","keys","()Ljava/util/List;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12314(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$KeyView","rows","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?21:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$KeyView","this$0","Lforge/util/collect/FSnapshotTable;"));f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","containsRow","(Ljava/lang/Object;)Z","invokevirtual",18);}
case 18:{f.Pc=32;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$KeyView","this$0","Lforge/util/collect/FSnapshotTable;"));f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","containsColumn","(Ljava/lang/Object;)Z","invokevirtual",32);}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12315(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?33:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$KeyView","this$0","Lforge/util/collect/FSnapshotTable;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$KeyView","rows","Z"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",17);}
case 17:{f.StackOp("pop");f.Pc=18;continue;}
case 18:{return rt.DynamicCall(f,"forge/util/collect/FSnapshotTable$KeyView:12315:18:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/Object;)Ljava/util/function/Predicate;",23);}
case 23:{return rt.Call(f,"forge/util/collect/FSnapshotTable","removeKeys","(ZLjava/util/function/Predicate;)Z","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Int==0?33:29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{f.Pc=34;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12316(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",4);}
case 4:{f.StackOp("pop");f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$KeyView","this$0","Lforge/util/collect/FSnapshotTable;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$KeyView","rows","Z"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",18);}
case 18:{f.StackOp("pop");f.Pc=19;continue;}
case 19:{return rt.DynamicCall(f,"forge/util/collect/FSnapshotTable$KeyView:12316:19:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/Collection;)Ljava/util/function/Predicate;",24);}
case 24:{return rt.Call(f,"forge/util/collect/FSnapshotTable","removeKeys","(ZLjava/util/function/Predicate;)Z","invokevirtual",27);}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12317(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",4);}
case 4:{f.StackOp("pop");f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$KeyView","this$0","Lforge/util/collect/FSnapshotTable;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$KeyView","rows","Z"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.DynamicCall(f,"forge/util/collect/FSnapshotTable$KeyView:12317:14:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/Collection;)Ljava/util/function/Predicate;",19);}
case 19:{return rt.Call(f,"forge/util/collect/FSnapshotTable","removeKeys","(ZLjava/util/function/Predicate;)Z","invokevirtual",22);}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12318(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",4);}
case 4:{f.StackOp("pop");f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$KeyView","this$0","Lforge/util/collect/FSnapshotTable;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$KeyView","rows","Z"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.DynamicCall(f,"forge/util/collect/FSnapshotTable$KeyView:12318:14:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;",19);}
case 19:{return rt.Call(f,"forge/util/collect/FSnapshotTable","removeKeys","(ZLjava/util/function/Predicate;)Z","invokevirtual",22);}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12319(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$KeyView","this$0","Lforge/util/collect/FSnapshotTable;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FSnapshotTable","clear","()V","invokevirtual",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12320(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12321(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/Collection","contains","(Ljava/lang/Object;)Z","invokeinterface",7);}
case 7:{f.Pc=f.Pop().Int!=0?14:10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Pc=15;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

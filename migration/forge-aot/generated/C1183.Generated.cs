// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1183{
internal static JClass Build(){var c=new JClass("forge/util/collect/FSnapshotTable$Snap","java/lang/Object",new string[]{},1056);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("rowKeys","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("columnKeys","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(12335,"forge/util/collect/FSnapshotTable$Snap","<init>","()V",2,1,1,new JHandler[]{},M12335));
c.Add(new JMethod(12336,"forge/util/collect/FSnapshotTable$Snap","size","()I",1024,0,0,new JHandler[]{},null));
c.Add(new JMethod(12337,"forge/util/collect/FSnapshotTable$Snap","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",1024,0,0,new JHandler[]{},null));
c.Add(new JMethod(12338,"forge/util/collect/FSnapshotTable$Snap","contains","(Ljava/lang/Object;Ljava/lang/Object;)Z",1024,0,0,new JHandler[]{},null));
c.Add(new JMethod(12339,"forge/util/collect/FSnapshotTable$Snap","containsRow","(Ljava/lang/Object;)Z",1024,0,0,new JHandler[]{},null));
c.Add(new JMethod(12340,"forge/util/collect/FSnapshotTable$Snap","containsColumn","(Ljava/lang/Object;)Z",1024,0,0,new JHandler[]{},null));
c.Add(new JMethod(12341,"forge/util/collect/FSnapshotTable$Snap","containsValue","(Ljava/lang/Object;)Z",1024,0,0,new JHandler[]{},null));
c.Add(new JMethod(12342,"forge/util/collect/FSnapshotTable$Snap","values","()Ljava/util/Collection;",1024,0,0,new JHandler[]{},null));
c.Add(new JMethod(12343,"forge/util/collect/FSnapshotTable$Snap","cellSet","()Ljava/util/Set;",1024,0,0,new JHandler[]{},null));
c.Add(new JMethod(12344,"forge/util/collect/FSnapshotTable$Snap","row","(Ljava/lang/Object;)Ljava/util/Map;",1024,0,0,new JHandler[]{},null));
c.Add(new JMethod(12345,"forge/util/collect/FSnapshotTable$Snap","column","(Ljava/lang/Object;)Ljava/util/Map;",1024,0,0,new JHandler[]{},null));
c.Add(new JMethod(12346,"forge/util/collect/FSnapshotTable$Snap","table","()Lcom/google/common/collect/Table;",1024,0,0,new JHandler[]{},null));
c.Add(new JMethod(12347,"forge/util/collect/FSnapshotTable$Snap","computeRowKeys","()Ljava/util/List;",1024,0,0,new JHandler[]{},null));
c.Add(new JMethod(12348,"forge/util/collect/FSnapshotTable$Snap","computeColumnKeys","()Ljava/util/List;",1024,0,0,new JHandler[]{},null));
c.Add(new JMethod(12349,"forge/util/collect/FSnapshotTable$Snap","rowKeys","()Ljava/util/List;",16,2,2,new JHandler[]{},M12349));
c.Add(new JMethod(12350,"forge/util/collect/FSnapshotTable$Snap","columnKeys","()Ljava/util/List;",16,2,2,new JHandler[]{},M12350));
}

internal static JStep M12335(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12349(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$Snap","rowKeys","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?22:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","computeRowKeys","()Ljava/util/List;","invokevirtual",13);}
case 13:{return rt.Call(f,"java/util/Collections","unmodifiableList","(Ljava/util/List;)Ljava/util/List;","invokestatic",16);}
case 16:{f.Locals[1]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable$Snap","rowKeys","Ljava/util/List;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12350(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$Snap","columnKeys","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?22:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","computeColumnKeys","()Ljava/util/List;","invokevirtual",13);}
case 13:{return rt.Call(f,"java/util/Collections","unmodifiableList","(Ljava/util/List;)Ljava/util/List;","invokestatic",16);}
case 16:{f.Locals[1]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable$Snap","columnKeys","Ljava/util/List;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

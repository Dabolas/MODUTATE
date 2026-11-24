// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1202{
internal static JClass Build(){var c=new JClass("forge/util/storage/StorageReaderBase","java/lang/Object",new string[]{"forge/util/IItemReader"},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("keySelector","Ljava/util/function/Function;",false,JValue.Default("Ljava/util/function/Function;"),null));
c.Add(new JMethod(12477,"forge/util/storage/StorageReaderBase","<init>","(Ljava/util/function/Function;)V",1,2,2,new JHandler[]{},M12477));
c.Add(new JMethod(12478,"forge/util/storage/StorageReaderBase","createMap","()Ljava/util/Map;",4,1,2,new JHandler[]{},M12478));
c.Add(new JMethod(12479,"forge/util/storage/StorageReaderBase","getSubFolders","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M12479));
c.Add(new JMethod(12480,"forge/util/storage/StorageReaderBase","getReaderForFolder","(Ljava/io/File;)Lforge/util/IItemReader;",1,2,3,new JHandler[]{},M12480));
}

internal static JStep M12477(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/storage/StorageReaderBase","keySelector","Ljava/util/function/Function;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12478(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/TreeMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/TreeMap","<init>","()V","invokespecial",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12479(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/ImmutableList","of","()Lcom/google/common/collect/ImmutableList;","invokestatic",3);}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12480(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/UnsupportedOperationException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/UnsupportedOperationException")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("This reader is not supposed to have nested folders")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/UnsupportedOperationException","<init>","(Ljava/lang/String;)V","invokespecial",9);}
case 9:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

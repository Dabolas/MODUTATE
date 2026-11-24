// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1200{
internal static JClass Build(){var c=new JClass("forge/util/storage/StorageImmediatelySerialized$1","java/lang/Object",new string[]{"java/util/function/Function"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("this$0","Lforge/util/storage/StorageImmediatelySerialized;",false,JValue.Default("Lforge/util/storage/StorageImmediatelySerialized;"),null));
c.Add(new JMethod(12470,"forge/util/storage/StorageImmediatelySerialized$1","<init>","(Lforge/util/storage/StorageImmediatelySerialized;)V",0,2,2,new JHandler[]{},M12470));
c.Add(new JMethod(12471,"forge/util/storage/StorageImmediatelySerialized$1","apply","(Ljava/io/File;)Lforge/util/storage/IStorage;",1,2,5,new JHandler[]{},M12471));
c.Add(new JMethod(12472,"forge/util/storage/StorageImmediatelySerialized$1","apply","(Ljava/lang/Object;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M12472));
}

internal static JStep M12470(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/storage/StorageImmediatelySerialized$1","this$0","Lforge/util/storage/StorageImmediatelySerialized;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12471(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/storage/StorageImmediatelySerialized"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/storage/StorageImmediatelySerialized")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/io/File","getName","()Ljava/lang/String;","invokevirtual",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageImmediatelySerialized$1","this$0","Lforge/util/storage/StorageImmediatelySerialized;"));f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageImmediatelySerialized","serializer","Lforge/util/IItemSerializer;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/util/IItemSerializer","getReaderForFolder","(Ljava/io/File;)Lforge/util/IItemReader;","invokeinterface",21);}
case 21:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/IItemSerializer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/util/storage/StorageImmediatelySerialized","<init>","(Ljava/lang/String;Lforge/util/IItemSerializer;Z)V","invokespecial",28);}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12472(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/io/File"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/storage/StorageImmediatelySerialized$1","apply","(Ljava/io/File;)Lforge/util/storage/IStorage;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

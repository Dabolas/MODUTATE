// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1201{
internal static JClass Build(){var c=new JClass("forge/util/storage/StorageNestedFolders","forge/util/storage/StorageBase",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("thisFolder","Ljava/io/File;",false,JValue.Default("Ljava/io/File;"),null));
c.Add(new JMethod(12473,"forge/util/storage/StorageNestedFolders","<init>","(Ljava/io/File;Ljava/lang/Iterable;Ljava/util/function/Function;)V",1,7,5,new JHandler[]{},M12473));
c.Add(new JMethod(12474,"forge/util/storage/StorageNestedFolders","add","(Lforge/util/storage/IStorage;)V",1,3,4,new JHandler[]{},M12474));
c.Add(new JMethod(12475,"forge/util/storage/StorageNestedFolders","delete","(Ljava/lang/String;)V",1,4,4,new JHandler[]{},M12475));
c.Add(new JMethod(12476,"forge/util/storage/StorageNestedFolders","add","(Ljava/lang/Object;)V",4161,2,2,new JHandler[]{},M12476));
}

internal static JStep M12473(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("<Subfolders>")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/io/File","getPath","()Ljava/lang/String;","invokevirtual",7);}
case 7:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",14);}
case 14:{return rt.Call(f,"forge/util/storage/StorageBase","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V","invokespecial",17);}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/storage/StorageNestedFolders","thisFolder","Ljava/io/File;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",28);}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?85:40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/io/File"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{f.Locals[5]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[5]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",60);}
case 60:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/storage/IStorage"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=63;continue;}
case 63:{f.Locals[6]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageNestedFolders","map","Ljava/util/Map;"));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/io/File","getName","()Ljava/lang/String;","invokevirtual",74);}
case 74:{f.Push(f.Locals[6]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",81);}
case 81:{f.StackOp("pop");f.Pc=82;continue;}
case 82:{f.Pc=30;continue;}
case 85:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12474(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageNestedFolders","thisFolder","Ljava/io/File;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/storage/IStorage","getName","()Ljava/lang/String;","invokeinterface",14);}
case 14:{return rt.Call(f,"java/io/File","<init>","(Ljava/io/File;Ljava/lang/String;)V","invokespecial",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/io/File","mkdir","()Z","invokevirtual",22);}
case 22:{f.StackOp("pop");f.Pc=23;continue;}
case 23:{if(!rt.EnsureInitialized(f,"java/lang/UnsupportedOperationException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/UnsupportedOperationException")));f.Pc=26;continue;}
case 26:{f.StackOp("dup");f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("method is not implemented")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/UnsupportedOperationException","<init>","(Ljava/lang/String;)V","invokespecial",32);}
case 32:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12475(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageNestedFolders","thisFolder","Ljava/io/File;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/io/File","<init>","(Ljava/io/File;Ljava/lang/String;)V","invokespecial",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageNestedFolders","map","Ljava/util/Map;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/storage/IStorage"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{f.Pc=f.Pop().Reference==null?36:31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/io/File","delete","()Z","invokevirtual",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12476(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/storage/IStorage"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/storage/StorageNestedFolders","add","(Lforge/util/storage/IStorage;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1199{
internal static JClass Build(){var c=new JClass("forge/util/storage/StorageImmediatelySerialized","forge/util/storage/StorageBase",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serializer","Lforge/util/IItemSerializer;",false,JValue.Default("Lforge/util/IItemSerializer;"),null));
c.Add(new JField("subfolders","Lforge/util/storage/IStorage;",false,JValue.Default("Lforge/util/storage/IStorage;"),null));
c.Add(new JField("nestedFactory","Ljava/util/function/Function;",false,JValue.Default("Ljava/util/function/Function;"),null));
c.Add(new JMethod(12462,"forge/util/storage/StorageImmediatelySerialized","<init>","(Ljava/lang/String;Lforge/util/IItemSerializer;)V",1,3,4,new JHandler[]{},M12462));
c.Add(new JMethod(12463,"forge/util/storage/StorageImmediatelySerialized","<init>","(Ljava/lang/String;Lforge/util/IItemSerializer;Z)V",1,4,6,new JHandler[]{},M12463));
c.Add(new JMethod(12464,"forge/util/storage/StorageImmediatelySerialized","add","(Ljava/lang/Object;)V",17,3,3,new JHandler[]{},M12464));
c.Add(new JMethod(12465,"forge/util/storage/StorageImmediatelySerialized","delete","(Ljava/lang/String;)V",17,3,3,new JHandler[]{new JHandler(0,19,22,"java/lang/Exception")},M12465));
c.Add(new JMethod(12466,"forge/util/storage/StorageImmediatelySerialized","getFolders","()Lforge/util/storage/IStorage;",1,1,1,new JHandler[]{},M12466));
c.Add(new JMethod(12467,"forge/util/storage/StorageImmediatelySerialized","tryGetFolder","(Ljava/lang/String;)Lforge/util/storage/IStorage;",1,4,3,new JHandler[]{},M12467));
c.Add(new JMethod(12468,"forge/util/storage/StorageImmediatelySerialized","getFolderOrCreate","(Ljava/lang/String;)Lforge/util/storage/IStorage;",1,3,3,new JHandler[]{},M12468));
c.Add(new JMethod(12469,"forge/util/storage/StorageImmediatelySerialized","getOrCreateSubfolder","(Ljava/lang/String;)Lforge/util/storage/IStorage;",2,3,4,new JHandler[]{},M12469));
}

internal static JStep M12462(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/storage/StorageImmediatelySerialized","<init>","(Ljava/lang/String;Lforge/util/IItemSerializer;Z)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12463(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/util/storage/StorageBase","<init>","(Ljava/lang/String;Lforge/util/IItemReader;)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"forge/util/storage/StorageImmediatelySerialized$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/storage/StorageImmediatelySerialized$1")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/util/storage/StorageImmediatelySerialized$1","<init>","(Lforge/util/storage/StorageImmediatelySerialized;)V","invokespecial",15);}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/storage/StorageImmediatelySerialized","nestedFactory","Ljava/util/function/Function;",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/storage/StorageImmediatelySerialized","serializer","Lforge/util/IItemSerializer;",value);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Int==0?54:28;continue;}
case 28:{if(!rt.EnsureInitialized(f,"forge/util/storage/StorageNestedFolders"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/storage/StorageNestedFolders")));f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/util/IItemSerializer","getDirectory","()Ljava/io/File;","invokeinterface",38);}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/util/IItemSerializer","getSubFolders","()Ljava/lang/Iterable;","invokeinterface",44);}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageImmediatelySerialized","nestedFactory","Ljava/util/function/Function;"));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/util/storage/StorageNestedFolders","<init>","(Ljava/io/File;Ljava/lang/Iterable;Ljava/util/function/Function;)V","invokespecial",51);}
case 51:{f.Pc=55;continue;}
case 54:{f.Push(JValue.R(null));f.Pc=55;continue;}
case 55:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/storage/StorageImmediatelySerialized","subfolders","Lforge/util/storage/IStorage;",value);f.Pc=58;continue;}
case 58:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12464(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageImmediatelySerialized","serializer","Lforge/util/IItemSerializer;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/IItemSerializer","getItemKey","(Ljava/lang/Object;)Ljava/lang/String;","invokeinterface",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageImmediatelySerialized","map","Ljava/util/Map;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",22);}
case 22:{f.StackOp("pop");f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageImmediatelySerialized","serializer","Lforge/util/IItemSerializer;"));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/util/IItemSerializer","save","(Ljava/lang/Object;)V","invokeinterface",33);}
case 33:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12465(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageImmediatelySerialized","serializer","Lforge/util/IItemSerializer;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageImmediatelySerialized","map","Ljava/util/Map;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",14);}
case 14:{return rt.Call(f,"forge/util/IItemSerializer","erase","(Ljava/lang/Object;)V","invokeinterface",19);}
case 19:{f.Pc=27;continue;}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/Exception","printStackTrace","()V","invokevirtual",27);}
case 27:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12466(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageImmediatelySerialized","subfolders","Lforge/util/storage/IStorage;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?14:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/util/storage/StorageBase","getFolders","()Lforge/util/storage/IStorage;","invokespecial",11);}
case 11:{f.Pc=18;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageImmediatelySerialized","subfolders","Lforge/util/storage/IStorage;"));f.Pc=18;continue;}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12467(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(47));f.Pc=3;continue;}
case 3:{f.Push(JValue.I(2));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/TextUtil","split","(Ljava/lang/CharSequence;CI)[Ljava/lang/String;","invokestatic",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=10;continue;}
case 10:{switch(f.Pop().Int){case 0:f.Pc=36;break;case 1:f.Pc=38;break;case 2:f.Pc=69;break;default:f.Pc=103;break;}continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return JStep.Return(f.Pop());}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String(".")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?53:49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Pc=68;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/util/storage/StorageImmediatelySerialized","getFolders","()Lforge/util/storage/IStorage;","invokevirtual",57);}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{f.Push(JValue.I(0));f.Pc=59;continue;}
case 59:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/util/storage/IStorage","get","(Ljava/lang/String;)Ljava/lang/Object;","invokeinterface",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/storage/IStorage"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{return JStep.Return(f.Pop());}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/util/storage/StorageImmediatelySerialized","getFolders","()Lforge/util/storage/IStorage;","invokevirtual",73);}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{f.Push(JValue.I(0));f.Pc=75;continue;}
case 75:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/util/storage/IStorage","get","(Ljava/lang/String;)Ljava/lang/Object;","invokeinterface",81);}
case 81:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/storage/IStorage"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=84;continue;}
case 84:{f.Locals[3]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{f.Pc=f.Pop().Reference!=null?93:89;continue;}
case 89:{f.Push(JValue.R(null));f.Pc=90;continue;}
case 90:{f.Pc=102;continue;}
case 93:{f.Push(f.Locals[3]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[2]);f.Pc=95;continue;}
case 95:{f.Push(JValue.I(1));f.Pc=96;continue;}
case 96:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/util/storage/IStorage","tryGetFolder","(Ljava/lang/String;)Lforge/util/storage/IStorage;","invokeinterface",102);}
case 102:{return JStep.Return(f.Pop());}
case 103:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=106;continue;}
case 106:{f.StackOp("dup");f.Pc=107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",111);}
case 111:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12468(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(47));f.Pc=3;continue;}
case 3:{f.Push(JValue.I(2));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/TextUtil","split","(Ljava/lang/CharSequence;CI)[Ljava/lang/String;","invokestatic",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=10;continue;}
case 10:{switch(f.Pop().Int){case 0:f.Pc=36;break;case 1:f.Pc=38;break;case 2:f.Pc=61;break;default:f.Pc=77;break;}continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return JStep.Return(f.Pop());}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String(".")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?53:49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Pc=60;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(JValue.I(0));f.Pc=56;continue;}
case 56:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/util/storage/StorageImmediatelySerialized","getOrCreateSubfolder","(Ljava/lang/String;)Lforge/util/storage/IStorage;","invokevirtual",60);}
case 60:{return JStep.Return(f.Pop());}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/util/storage/StorageImmediatelySerialized","getOrCreateSubfolder","(Ljava/lang/String;)Lforge/util/storage/IStorage;","invokevirtual",68);}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{f.Push(JValue.I(1));f.Pc=70;continue;}
case 70:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/util/storage/IStorage","getFolderOrCreate","(Ljava/lang/String;)Lforge/util/storage/IStorage;","invokeinterface",76);}
case 76:{return JStep.Return(f.Pop());}
case 77:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=80;continue;}
case 80:{f.StackOp("dup");f.Pc=81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",85);}
case 85:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12469(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/storage/StorageImmediatelySerialized","getFolders","()Lforge/util/storage/IStorage;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/storage/IStorage","get","(Ljava/lang/String;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/storage/IStorage"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(JValue.R(null));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?42:19;continue;}
case 19:{if(!rt.EnsureInitialized(f,"forge/util/storage/StorageImmediatelySerialized"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/storage/StorageImmediatelySerialized")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageImmediatelySerialized","serializer","Lforge/util/IItemSerializer;"));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/util/storage/StorageImmediatelySerialized","<init>","(Ljava/lang/String;Lforge/util/IItemSerializer;)V","invokespecial",31);}
case 31:{f.Locals[2]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/util/storage/StorageImmediatelySerialized","subfolders","Lforge/util/storage/IStorage;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/util/storage/IStorage","add","(Ljava/lang/Object;)V","invokeinterface",42);}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1175{
internal static JClass Build(){var c=new JClass("forge/util/collect/FSnapshotTable","java/lang/Object",new string[]{"com/google/common/collect/Table","java/io/Serializable"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(2L),null));
c.Add(new JField("sorted","Z",false,JValue.Default("Z"),null));
c.Add(new JField("snap","Lforge/util/collect/FSnapshotTable$Snap;",false,JValue.Default("Lforge/util/collect/FSnapshotTable$Snap;"),null));
c.Add(new JMethod(12254,"forge/util/collect/FSnapshotTable","<init>","(ZLforge/util/collect/FSnapshotTable$Snap;)V",2,3,2,new JHandler[]{},M12254));
c.Add(new JMethod(12255,"forge/util/collect/FSnapshotTable","createTree","()Lforge/util/collect/FSnapshotTable;",9,0,7,new JHandler[]{},M12255));
c.Add(new JMethod(12256,"forge/util/collect/FSnapshotTable","createTree","(Lcom/google/common/collect/Table;)Lforge/util/collect/FSnapshotTable;",9,2,2,new JHandler[]{},M12256));
c.Add(new JMethod(12257,"forge/util/collect/FSnapshotTable","createHash","()Lforge/util/collect/FSnapshotTable;",9,0,6,new JHandler[]{},M12257));
c.Add(new JMethod(12258,"forge/util/collect/FSnapshotTable","createHash","(Lcom/google/common/collect/Table;)Lforge/util/collect/FSnapshotTable;",9,1,6,new JHandler[]{},M12258));
c.Add(new JMethod(12259,"forge/util/collect/FSnapshotTable","sortedSnap","()Lforge/util/collect/FSnapshotTable$SortedSnap;",2,1,1,new JHandler[]{},M12259));
c.Add(new JMethod(12260,"forge/util/collect/FSnapshotTable","hashCopy","()Lcom/google/common/collect/Table;",2,1,1,new JHandler[]{},M12260));
c.Add(new JMethod(12261,"forge/util/collect/FSnapshotTable","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",33,7,6,new JHandler[]{},M12261));
c.Add(new JMethod(12262,"forge/util/collect/FSnapshotTable","remove","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",33,6,4,new JHandler[]{},M12262));
c.Add(new JMethod(12263,"forge/util/collect/FSnapshotTable","putAll","(Lcom/google/common/collect/Table;)V",33,15,7,new JHandler[]{},M12263));
c.Add(new JMethod(12264,"forge/util/collect/FSnapshotTable","clear","()V",33,1,5,new JHandler[]{},M12264));
c.Add(new JMethod(12265,"forge/util/collect/FSnapshotTable","removeKeys","(ZLjava/util/function/Predicate;)Z",34,11,6,new JHandler[]{},M12265));
c.Add(new JMethod(12266,"forge/util/collect/FSnapshotTable","version","()Ljava/lang/Object;",1,1,1,new JHandler[]{},M12266));
c.Add(new JMethod(12267,"forge/util/collect/FSnapshotTable","versionOf","(Lcom/google/common/collect/Table;)Ljava/lang/Object;",9,1,1,new JHandler[]{},M12267));
c.Add(new JMethod(12268,"forge/util/collect/FSnapshotTable","contains","(Ljava/lang/Object;Ljava/lang/Object;)Z",1,3,3,new JHandler[]{},M12268));
c.Add(new JMethod(12269,"forge/util/collect/FSnapshotTable","containsRow","(Ljava/lang/Object;)Z",1,2,2,new JHandler[]{},M12269));
c.Add(new JMethod(12270,"forge/util/collect/FSnapshotTable","containsColumn","(Ljava/lang/Object;)Z",1,2,2,new JHandler[]{},M12270));
c.Add(new JMethod(12271,"forge/util/collect/FSnapshotTable","containsValue","(Ljava/lang/Object;)Z",1,2,2,new JHandler[]{},M12271));
c.Add(new JMethod(12272,"forge/util/collect/FSnapshotTable","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",1,3,3,new JHandler[]{},M12272));
c.Add(new JMethod(12273,"forge/util/collect/FSnapshotTable","isEmpty","()Z",1,1,1,new JHandler[]{},M12273));
c.Add(new JMethod(12274,"forge/util/collect/FSnapshotTable","size","()I",1,1,1,new JHandler[]{},M12274));
c.Add(new JMethod(12275,"forge/util/collect/FSnapshotTable","row","(Ljava/lang/Object;)Ljava/util/Map;",1,2,2,new JHandler[]{},M12275));
c.Add(new JMethod(12276,"forge/util/collect/FSnapshotTable","column","(Ljava/lang/Object;)Ljava/util/Map;",1,2,2,new JHandler[]{},M12276));
c.Add(new JMethod(12277,"forge/util/collect/FSnapshotTable","rowMap","()Ljava/util/Map;",1,1,1,new JHandler[]{},M12277));
c.Add(new JMethod(12278,"forge/util/collect/FSnapshotTable","columnMap","()Ljava/util/Map;",1,1,1,new JHandler[]{},M12278));
c.Add(new JMethod(12279,"forge/util/collect/FSnapshotTable","rowKeySet","()Ljava/util/Set;",1,1,4,new JHandler[]{},M12279));
c.Add(new JMethod(12280,"forge/util/collect/FSnapshotTable","columnKeySet","()Ljava/util/Set;",1,1,4,new JHandler[]{},M12280));
c.Add(new JMethod(12281,"forge/util/collect/FSnapshotTable","values","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M12281));
c.Add(new JMethod(12282,"forge/util/collect/FSnapshotTable","cellSet","()Ljava/util/Set;",1,1,1,new JHandler[]{},M12282));
c.Add(new JMethod(12283,"forge/util/collect/FSnapshotTable","equals","(Ljava/lang/Object;)Z",1,2,2,new JHandler[]{},M12283));
c.Add(new JMethod(12284,"forge/util/collect/FSnapshotTable","hashCode","()I",1,1,1,new JHandler[]{},M12284));
c.Add(new JMethod(12285,"forge/util/collect/FSnapshotTable","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M12285));
c.Add(new JMethod(12286,"forge/util/collect/FSnapshotTable","writeObject","(Ljava/io/ObjectOutputStream;)V",2,2,2,new JHandler[]{},M12286));
c.Add(new JMethod(12287,"forge/util/collect/FSnapshotTable","readObject","(Ljava/io/ObjectInputStream;)V",2,3,5,new JHandler[]{},M12287));
}

internal static JStep M12254(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable","sorted","Z",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12255(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$SortedSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$SortedSnap")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/util/collect/FSnapshotTable$SortedSnap","NO_DATA","[Ljava/lang/Object;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/collect/FSnapshotTable$SortedSnap","NO_DATA","[Ljava/lang/Object;"));f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","<init>","([Ljava/lang/Object;I)V","invokespecial",16);}
case 16:{return rt.Call(f,"forge/util/collect/FSnapshotTable","<init>","(ZLforge/util/collect/FSnapshotTable$Snap;)V","invokespecial",19);}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12256(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/collect/FSnapshotTable","createTree","()Lforge/util/collect/FSnapshotTable;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/util/collect/FSnapshotTable","putAll","(Lcom/google/common/collect/Table;)V","invokevirtual",9);}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12257(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$HashSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$HashSnap")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"com/google/common/collect/HashBasedTable","create","()Lcom/google/common/collect/HashBasedTable;","invokestatic",12);}
case 12:{return rt.Call(f,"forge/util/collect/FSnapshotTable$HashSnap","<init>","(Lcom/google/common/collect/Table;)V","invokespecial",15);}
case 15:{return rt.Call(f,"forge/util/collect/FSnapshotTable","<init>","(ZLforge/util/collect/FSnapshotTable$Snap;)V","invokespecial",18);}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12258(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$HashSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$HashSnap")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/collect/HashBasedTable","create","(Lcom/google/common/collect/Table;)Lcom/google/common/collect/HashBasedTable;","invokestatic",13);}
case 13:{return rt.Call(f,"forge/util/collect/FSnapshotTable$HashSnap","<init>","(Lcom/google/common/collect/Table;)V","invokespecial",16);}
case 16:{return rt.Call(f,"forge/util/collect/FSnapshotTable","<init>","(ZLforge/util/collect/FSnapshotTable$Snap;)V","invokespecial",19);}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12259(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=4;continue;}
case 4:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FSnapshotTable$SortedSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=7;continue;}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12260(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","table","()Lcom/google/common/collect/Table;","invokevirtual",7);}
case 7:{return rt.Call(f,"com/google/common/collect/HashBasedTable","create","(Lcom/google/common/collect/Table;)Lcom/google/common/collect/HashBasedTable;","invokestatic",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12261(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?12:4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference==null?12:8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference!=null?20:12;continue;}
case 12:{if(!rt.EnsureInitialized(f,"java/lang/NullPointerException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/NullPointerException")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/NullPointerException","<init>","()V","invokespecial",19);}
case 19:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","sorted","Z"));f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Int!=0?85:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","table","()Lcom/google/common/collect/Table;","invokevirtual",34);}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"com/google/common/collect/Table","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",41);}
case 41:{f.Locals[4]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?52:49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{return JStep.Return(f.Pop());}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/util/collect/FSnapshotTable","hashCopy","()Lcom/google/common/collect/Table;","invokevirtual",56);}
case 56:{f.Locals[5]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"com/google/common/collect/Table","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",68);}
case 68:{f.StackOp("pop");f.Pc=69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$HashSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$HashSnap")));f.Pc=73;continue;}
case 73:{f.StackOp("dup");f.Pc=74;continue;}
case 74:{f.Push(f.Locals[5]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/util/collect/FSnapshotTable$HashSnap","<init>","(Lcom/google/common/collect/Table;)V","invokespecial",79);}
case 79:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;",value);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{return JStep.Return(f.Pop());}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/util/collect/FSnapshotTable","sortedSnap","()Lforge/util/collect/FSnapshotTable$SortedSnap;","invokevirtual",89);}
case 89:{f.Locals[4]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[4]);f.Pc=93;continue;}
case 93:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=96;continue;}
case 96:{f.Push(f.Locals[4]);f.Pc=98;continue;}
case 98:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[2]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","search","([Ljava/lang/Object;ILjava/lang/Object;Ljava/lang/Object;)I","invokestatic",106);}
case 106:{f.Locals[5]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[5]);f.Pc=110;continue;}
case 110:{f.Pc=f.Pop().Int<0?151:113;continue;}
case 113:{f.Push(f.Locals[4]);f.Pc=115;continue;}
case 115:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=118;continue;}
case 118:{f.Push(JValue.I(3));f.Pc=119;continue;}
case 119:{f.Push(f.Locals[5]);f.Pc=121;continue;}
case 121:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=122;continue;}
case 122:{f.Push(JValue.I(2));f.Pc=123;continue;}
case 123:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=124;continue;}
case 124:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=125;continue;}
case 125:{f.Locals[6]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[6]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[3]);f.Pc=130;continue;}
case 130:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?136:133;continue;}
case 133:{f.Push(f.Locals[6]);f.Pc=135;continue;}
case 135:{return JStep.Return(f.Pop());}
case 136:{f.Push(f.Locals[0]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[4]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[5]);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[3]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","withValue","(ILjava/lang/Object;)Lforge/util/collect/FSnapshotTable$SortedSnap;","invokevirtual",145);}
case 145:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;",value);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[6]);f.Pc=150;continue;}
case 150:{return JStep.Return(f.Pop());}
case 151:{f.Push(f.Locals[0]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[4]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[5]);f.Pc=156;continue;}
case 156:{f.Push(JNumbers.Unary("ineg",f.Pop()));f.Pc=157;continue;}
case 157:{f.Push(JValue.I(1));f.Pc=158;continue;}
case 158:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=159;continue;}
case 159:{f.Push(f.Locals[1]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[2]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[3]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","inserted","(ILjava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lforge/util/collect/FSnapshotTable$SortedSnap;","invokevirtual",165);}
case 165:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;",value);f.Pc=168;continue;}
case 168:{f.Push(JValue.R(null));f.Pc=169;continue;}
case 169:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12262(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?8:4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference!=null?10:8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","sorted","Z"));f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Int!=0?66:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","table","()Lcom/google/common/collect/Table;","invokevirtual",24);}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"com/google/common/collect/Table","contains","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",31);}
case 31:{f.Pc=f.Pop().Int!=0?36:34;continue;}
case 34:{f.Push(JValue.R(null));f.Pc=35;continue;}
case 35:{return JStep.Return(f.Pop());}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/util/collect/FSnapshotTable","hashCopy","()Lcom/google/common/collect/Table;","invokevirtual",40);}
case 40:{f.Locals[3]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"com/google/common/collect/Table","remove","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",49);}
case 49:{f.Locals[4]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$HashSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$HashSnap")));f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/util/collect/FSnapshotTable$HashSnap","<init>","(Lcom/google/common/collect/Table;)V","invokespecial",60);}
case 60:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;",value);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{return JStep.Return(f.Pop());}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/util/collect/FSnapshotTable","sortedSnap","()Lforge/util/collect/FSnapshotTable$SortedSnap;","invokevirtual",70);}
case 70:{f.Locals[3]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","find","(Ljava/lang/Object;Ljava/lang/Object;)I","invokevirtual",77);}
case 77:{f.Locals[4]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[4]);f.Pc=81;continue;}
case 81:{f.Pc=f.Pop().Int>=0?86:84;continue;}
case 84:{f.Push(JValue.R(null));f.Pc=85;continue;}
case 85:{return JStep.Return(f.Pop());}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=90;continue;}
case 90:{f.Push(JValue.I(3));f.Pc=91;continue;}
case 91:{f.Push(f.Locals[4]);f.Pc=93;continue;}
case 93:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=94;continue;}
case 94:{f.Push(JValue.I(2));f.Pc=95;continue;}
case 95:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=96;continue;}
case 96:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=97;continue;}
case 97:{f.Locals[5]=f.Pop();f.Pc=99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[3]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[4]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","without","(I)Lforge/util/collect/FSnapshotTable$SortedSnap;","invokevirtual",106);}
case 106:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;",value);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[5]);f.Pc=111;continue;}
case 111:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12263(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/Table","isEmpty","()Z","invokeinterface",6);}
case 6:{f.Pc=f.Pop().Int==0?10:9;continue;}
case 9:{return JStep.ReturnVoid;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","sorted","Z"));f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Int!=0?42:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/collect/FSnapshotTable","hashCopy","()Lcom/google/common/collect/Table;","invokevirtual",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"com/google/common/collect/Table","putAll","(Lcom/google/common/collect/Table;)V","invokeinterface",29);}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$HashSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$HashSnap")));f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/util/collect/FSnapshotTable$HashSnap","<init>","(Lcom/google/common/collect/Table;)V","invokespecial",38);}
case 38:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;",value);f.Pc=41;continue;}
case 41:{return JStep.ReturnVoid;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/util/collect/FSnapshotTable","sortedSnap","()Lforge/util/collect/FSnapshotTable$SortedSnap;","invokevirtual",46);}
case 46:{f.Locals[2]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=51;continue;}
case 51:{f.Locals[3]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=56;continue;}
case 56:{f.Locals[4]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(JValue.I(0));f.Pc=59;continue;}
case 59:{f.Locals[5]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{f.Locals[6]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"com/google/common/collect/Table","size","()I","invokeinterface",70);}
case 70:{f.Locals[7]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"com/google/common/collect/Table","cellSet","()Ljava/util/Set;","invokeinterface",78);}
case 78:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",83);}
case 83:{f.Locals[8]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[8]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",92);}
case 92:{f.Pc=f.Pop().Int==0?309:95;continue;}
case 95:{f.Push(f.Locals[8]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",102);}
case 102:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Table$Cell"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=105;continue;}
case 105:{f.Locals[9]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[9]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"com/google/common/collect/Table$Cell","getRowKey","()Ljava/lang/Object;","invokeinterface",114);}
case 114:{f.Locals[10]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[9]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"com/google/common/collect/Table$Cell","getColumnKey","()Ljava/lang/Object;","invokeinterface",123);}
case 123:{f.Locals[11]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[9]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"com/google/common/collect/Table$Cell","getValue","()Ljava/lang/Object;","invokeinterface",132);}
case 132:{f.Locals[12]=f.Pop();f.Pc=134;continue;}
case 134:{f.Push(f.Locals[10]);f.Pc=136;continue;}
case 136:{f.Pc=f.Pop().Reference==null?149:139;continue;}
case 139:{f.Push(f.Locals[11]);f.Pc=141;continue;}
case 141:{f.Pc=f.Pop().Reference==null?149:144;continue;}
case 144:{f.Push(f.Locals[12]);f.Pc=146;continue;}
case 146:{f.Pc=f.Pop().Reference!=null?157:149;continue;}
case 149:{if(!rt.EnsureInitialized(f,"java/lang/NullPointerException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/NullPointerException")));f.Pc=152;continue;}
case 152:{f.StackOp("dup");f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/lang/NullPointerException","<init>","()V","invokespecial",156);}
case 156:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 157:{f.Push(f.Locals[3]);f.Pc=158;continue;}
case 158:{f.Push(f.Locals[4]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[10]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[11]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","search","([Ljava/lang/Object;ILjava/lang/Object;Ljava/lang/Object;)I","invokestatic",167);}
case 167:{f.Locals[13]=f.Pop();f.Pc=169;continue;}
case 169:{f.Push(f.Locals[13]);f.Pc=171;continue;}
case 171:{f.Pc=f.Pop().Int<0?223:174;continue;}
case 174:{f.Push(f.Locals[3]);f.Pc=175;continue;}
case 175:{f.Push(JValue.I(3));f.Pc=176;continue;}
case 176:{f.Push(f.Locals[13]);f.Pc=178;continue;}
case 178:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=179;continue;}
case 179:{f.Push(JValue.I(2));f.Pc=180;continue;}
case 180:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=181;continue;}
case 181:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=182;continue;}
case 182:{f.Push(f.Locals[12]);f.Pc=184;continue;}
case 184:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?190:187;continue;}
case 187:{f.Pc=85;continue;}
case 190:{f.Push(f.Locals[5]);f.Pc=192;continue;}
case 192:{f.Pc=f.Pop().Int!=0?210:195;continue;}
case 195:{f.Push(f.Locals[3]);f.Pc=196;continue;}
case 196:{f.Push(JValue.I(3));f.Pc=197;continue;}
case 197:{f.Push(f.Locals[4]);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[7]);f.Pc=201;continue;}
case 201:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=202;continue;}
case 202:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/util/Arrays","copyOf","([Ljava/lang/Object;I)[Ljava/lang/Object;","invokestatic",206);}
case 206:{f.Locals[3]=f.Pop();f.Pc=207;continue;}
case 207:{f.Push(JValue.I(1));f.Pc=208;continue;}
case 208:{f.Locals[5]=f.Pop();f.Pc=210;continue;}
case 210:{f.Push(f.Locals[3]);f.Pc=211;continue;}
case 211:{f.Push(JValue.I(3));f.Pc=212;continue;}
case 212:{f.Push(f.Locals[13]);f.Pc=214;continue;}
case 214:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=215;continue;}
case 215:{f.Push(JValue.I(2));f.Pc=216;continue;}
case 216:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=217;continue;}
case 217:{f.Push(f.Locals[12]);f.Pc=219;continue;}
case 219:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=220;continue;}
case 220:{f.Pc=303;continue;}
case 223:{f.Push(f.Locals[5]);f.Pc=225;continue;}
case 225:{f.Pc=f.Pop().Int!=0?243:228;continue;}
case 228:{f.Push(f.Locals[3]);f.Pc=229;continue;}
case 229:{f.Push(JValue.I(3));f.Pc=230;continue;}
case 230:{f.Push(f.Locals[4]);f.Pc=232;continue;}
case 232:{f.Push(f.Locals[7]);f.Pc=234;continue;}
case 234:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=235;continue;}
case 235:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/util/Arrays","copyOf","([Ljava/lang/Object;I)[Ljava/lang/Object;","invokestatic",239);}
case 239:{f.Locals[3]=f.Pop();f.Pc=240;continue;}
case 240:{f.Push(JValue.I(1));f.Pc=241;continue;}
case 241:{f.Locals[5]=f.Pop();f.Pc=243;continue;}
case 243:{f.Push(f.Locals[13]);f.Pc=245;continue;}
case 245:{f.Push(JNumbers.Unary("ineg",f.Pop()));f.Pc=246;continue;}
case 246:{f.Push(JValue.I(1));f.Pc=247;continue;}
case 247:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=248;continue;}
case 248:{f.Locals[14]=f.Pop();f.Pc=250;continue;}
case 250:{f.Push(f.Locals[3]);f.Pc=251;continue;}
case 251:{f.Push(JValue.I(3));f.Pc=252;continue;}
case 252:{f.Push(f.Locals[14]);f.Pc=254;continue;}
case 254:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=255;continue;}
case 255:{f.Push(f.Locals[3]);f.Pc=256;continue;}
case 256:{f.Push(JValue.I(3));f.Pc=257;continue;}
case 257:{f.Push(f.Locals[14]);f.Pc=259;continue;}
case 259:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=260;continue;}
case 260:{f.Push(JValue.I(3));f.Pc=261;continue;}
case 261:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=262;continue;}
case 262:{f.Push(JValue.I(3));f.Pc=263;continue;}
case 263:{f.Push(f.Locals[4]);f.Pc=265;continue;}
case 265:{f.Push(f.Locals[14]);f.Pc=267;continue;}
case 267:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=268;continue;}
case 268:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=269;continue;}
case 269:{return rt.Call(f,"java/lang/System","arraycopy","(Ljava/lang/Object;ILjava/lang/Object;II)V","invokestatic",272);}
case 272:{f.Push(f.Locals[3]);f.Pc=273;continue;}
case 273:{f.Push(JValue.I(3));f.Pc=274;continue;}
case 274:{f.Push(f.Locals[14]);f.Pc=276;continue;}
case 276:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=277;continue;}
case 277:{f.Push(f.Locals[10]);f.Pc=279;continue;}
case 279:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=280;continue;}
case 280:{f.Push(f.Locals[3]);f.Pc=281;continue;}
case 281:{f.Push(JValue.I(3));f.Pc=282;continue;}
case 282:{f.Push(f.Locals[14]);f.Pc=284;continue;}
case 284:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=285;continue;}
case 285:{f.Push(JValue.I(1));f.Pc=286;continue;}
case 286:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=287;continue;}
case 287:{f.Push(f.Locals[11]);f.Pc=289;continue;}
case 289:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=290;continue;}
case 290:{f.Push(f.Locals[3]);f.Pc=291;continue;}
case 291:{f.Push(JValue.I(3));f.Pc=292;continue;}
case 292:{f.Push(f.Locals[14]);f.Pc=294;continue;}
case 294:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=295;continue;}
case 295:{f.Push(JValue.I(2));f.Pc=296;continue;}
case 296:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=297;continue;}
case 297:{f.Push(f.Locals[12]);f.Pc=299;continue;}
case 299:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=300;continue;}
case 300:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=303;continue;}
case 303:{f.Push(JValue.I(1));f.Pc=304;continue;}
case 304:{f.Locals[6]=f.Pop();f.Pc=306;continue;}
case 306:{f.Pc=85;continue;}
case 309:{f.Push(f.Locals[6]);f.Pc=311;continue;}
case 311:{f.Pc=f.Pop().Int==0?348:314;continue;}
case 314:{f.Push(f.Locals[0]);f.Pc=315;continue;}
case 315:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$SortedSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$SortedSnap")));f.Pc=318;continue;}
case 318:{f.StackOp("dup");f.Pc=319;continue;}
case 319:{f.Push(f.Locals[3]);f.Pc=320;continue;}
case 320:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=321;continue;}
case 321:{f.Push(JValue.I(3));f.Pc=322;continue;}
case 322:{f.Push(f.Locals[4]);f.Pc=324;continue;}
case 324:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=325;continue;}
case 325:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?332:328;continue;}
case 328:{f.Push(f.Locals[3]);f.Pc=329;continue;}
case 329:{f.Pc=340;continue;}
case 332:{f.Push(f.Locals[3]);f.Pc=333;continue;}
case 333:{f.Push(JValue.I(3));f.Pc=334;continue;}
case 334:{f.Push(f.Locals[4]);f.Pc=336;continue;}
case 336:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=337;continue;}
case 337:{return rt.Call(f,"java/util/Arrays","copyOf","([Ljava/lang/Object;I)[Ljava/lang/Object;","invokestatic",340);}
case 340:{f.Push(f.Locals[4]);f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","<init>","([Ljava/lang/Object;I)V","invokespecial",345);}
case 345:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;",value);f.Pc=348;continue;}
case 348:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12264(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","size","()I","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?11:10;continue;}
case 10:{return JStep.ReturnVoid;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","sorted","Z"));f.Pc=16;continue;}
case 16:{f.Pc=f.Pop().Int==0?33:19;continue;}
case 19:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$SortedSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$SortedSnap")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{if(!rt.StaticReady(f,"forge/util/collect/FSnapshotTable$SortedSnap","NO_DATA","[Ljava/lang/Object;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/collect/FSnapshotTable$SortedSnap","NO_DATA","[Ljava/lang/Object;"));f.Pc=26;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","<init>","([Ljava/lang/Object;I)V","invokespecial",30);}
case 30:{f.Pc=43;continue;}
case 33:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$HashSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$HashSnap")));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{return rt.Call(f,"com/google/common/collect/HashBasedTable","create","()Lcom/google/common/collect/HashBasedTable;","invokestatic",40);}
case 40:{return rt.Call(f,"forge/util/collect/FSnapshotTable$HashSnap","<init>","(Lcom/google/common/collect/Table;)V","invokespecial",43);}
case 43:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;",value);f.Pc=46;continue;}
case 46:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12265(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","sorted","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?117:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/util/collect/FSnapshotTable","hashCopy","()Lcom/google/common/collect/Table;","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Int==0?25:16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"com/google/common/collect/Table","rowKeySet","()Ljava/util/Set;","invokeinterface",22);}
case 22:{f.Pc=31;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"com/google/common/collect/Table","columnKeySet","()Ljava/util/Set;","invokeinterface",31);}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{f.Locals[5]=f.Pop();f.Pc=36;continue;}
case 36:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=39;continue;}
case 39:{f.StackOp("dup");f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",45);}
case 45:{return rt.Call(f,"java/util/ArrayList","iterator","()Ljava/util/Iterator;","invokevirtual",48);}
case 48:{f.Locals[6]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[6]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",57);}
case 57:{f.Pc=f.Pop().Int==0?96:60;continue;}
case 60:{f.Push(f.Locals[6]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",67);}
case 67:{f.Locals[7]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[7]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",77);}
case 77:{f.Pc=f.Pop().Int==0?93:80;continue;}
case 80:{f.Push(f.Locals[4]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[7]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/Set","remove","(Ljava/lang/Object;)Z","invokeinterface",89);}
case 89:{f.StackOp("pop");f.Pc=90;continue;}
case 90:{f.Push(JValue.I(1));f.Pc=91;continue;}
case 91:{f.Locals[5]=f.Pop();f.Pc=93;continue;}
case 93:{f.Pc=50;continue;}
case 96:{f.Push(f.Locals[5]);f.Pc=98;continue;}
case 98:{f.Pc=f.Pop().Int!=0?103:101;continue;}
case 101:{f.Push(JValue.I(0));f.Pc=102;continue;}
case 102:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$HashSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$HashSnap")));f.Pc=107;continue;}
case 107:{f.StackOp("dup");f.Pc=108;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/util/collect/FSnapshotTable$HashSnap","<init>","(Lcom/google/common/collect/Table;)V","invokespecial",112);}
case 112:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;",value);f.Pc=115;continue;}
case 115:{f.Push(JValue.I(1));f.Pc=116;continue;}
case 116:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 117:{f.Push(f.Locals[0]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/util/collect/FSnapshotTable","sortedSnap","()Lforge/util/collect/FSnapshotTable$SortedSnap;","invokevirtual",121);}
case 121:{f.Locals[3]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[3]);f.Pc=123;continue;}
case 123:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=126;continue;}
case 126:{f.Locals[4]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=132;continue;}
case 132:{f.Locals[5]=f.Pop();f.Pc=134;continue;}
case 134:{f.Push(f.Locals[1]);f.Pc=135;continue;}
case 135:{f.Pc=f.Pop().Int==0?142:138;continue;}
case 138:{f.Push(JValue.I(0));f.Pc=139;continue;}
case 139:{f.Pc=143;continue;}
case 142:{f.Push(JValue.I(1));f.Pc=143;continue;}
case 143:{f.Locals[6]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(JValue.I(-1));f.Pc=146;continue;}
case 146:{f.Locals[7]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(JValue.I(0));f.Pc=149;continue;}
case 149:{f.Locals[8]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(f.Locals[8]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[5]);f.Pc=155;continue;}
case 155:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?190:158;continue;}
case 158:{f.Push(f.Locals[2]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[4]);f.Pc=161;continue;}
case 161:{f.Push(JValue.I(3));f.Pc=162;continue;}
case 162:{f.Push(f.Locals[8]);f.Pc=164;continue;}
case 164:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=165;continue;}
case 165:{f.Push(f.Locals[6]);f.Pc=167;continue;}
case 167:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=168;continue;}
case 168:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",174);}
case 174:{f.Pc=f.Pop().Int==0?184:177;continue;}
case 177:{f.Push(f.Locals[8]);f.Pc=179;continue;}
case 179:{f.Locals[7]=f.Pop();f.Pc=181;continue;}
case 181:{f.Pc=190;continue;}
case 184:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=187;continue;}
case 187:{f.Pc=151;continue;}
case 190:{f.Push(f.Locals[7]);f.Pc=192;continue;}
case 192:{f.Pc=f.Pop().Int>=0?197:195;continue;}
case 195:{f.Push(JValue.I(0));f.Pc=196;continue;}
case 196:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 197:{f.Push(JValue.I(3));f.Pc=198;continue;}
case 198:{f.Push(f.Locals[5]);f.Pc=200;continue;}
case 200:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=201;continue;}
case 201:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=204;continue;}
case 204:{f.Locals[8]=f.Pop();f.Pc=206;continue;}
case 206:{f.Push(f.Locals[4]);f.Pc=208;continue;}
case 208:{f.Push(JValue.I(0));f.Pc=209;continue;}
case 209:{f.Push(f.Locals[8]);f.Pc=211;continue;}
case 211:{f.Push(JValue.I(0));f.Pc=212;continue;}
case 212:{f.Push(JValue.I(3));f.Pc=213;continue;}
case 213:{f.Push(f.Locals[7]);f.Pc=215;continue;}
case 215:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=216;continue;}
case 216:{return rt.Call(f,"java/lang/System","arraycopy","(Ljava/lang/Object;ILjava/lang/Object;II)V","invokestatic",219);}
case 219:{f.Push(f.Locals[7]);f.Pc=221;continue;}
case 221:{f.Locals[9]=f.Pop();f.Pc=223;continue;}
case 223:{f.Push(f.Locals[7]);f.Pc=225;continue;}
case 225:{f.Push(JValue.I(1));f.Pc=226;continue;}
case 226:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=227;continue;}
case 227:{f.Locals[10]=f.Pop();f.Pc=229;continue;}
case 229:{f.Push(f.Locals[10]);f.Pc=231;continue;}
case 231:{f.Push(f.Locals[5]);f.Pc=233;continue;}
case 233:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?280:236;continue;}
case 236:{f.Push(f.Locals[2]);f.Pc=237;continue;}
case 237:{f.Push(f.Locals[4]);f.Pc=239;continue;}
case 239:{f.Push(JValue.I(3));f.Pc=240;continue;}
case 240:{f.Push(f.Locals[10]);f.Pc=242;continue;}
case 242:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=243;continue;}
case 243:{f.Push(f.Locals[6]);f.Pc=245;continue;}
case 245:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=246;continue;}
case 246:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=247;continue;}
case 247:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",252);}
case 252:{f.Pc=f.Pop().Int!=0?274:255;continue;}
case 255:{f.Push(f.Locals[4]);f.Pc=257;continue;}
case 257:{f.Push(JValue.I(3));f.Pc=258;continue;}
case 258:{f.Push(f.Locals[10]);f.Pc=260;continue;}
case 260:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=261;continue;}
case 261:{f.Push(f.Locals[8]);f.Pc=263;continue;}
case 263:{f.Push(JValue.I(3));f.Pc=264;continue;}
case 264:{f.Push(f.Locals[9]);f.Pc=266;continue;}
case 266:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=267;continue;}
case 267:{f.Push(JValue.I(3));f.Pc=268;continue;}
case 268:{return rt.Call(f,"java/lang/System","arraycopy","(Ljava/lang/Object;ILjava/lang/Object;II)V","invokestatic",271);}
case 271:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(1)));f.Pc=274;continue;}
case 274:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=277;continue;}
case 277:{f.Pc=229;continue;}
case 280:{f.Push(f.Locals[0]);f.Pc=281;continue;}
case 281:{f.Push(f.Locals[9]);f.Pc=283;continue;}
case 283:{f.Pc=f.Pop().Int!=0?300:286;continue;}
case 286:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$SortedSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$SortedSnap")));f.Pc=289;continue;}
case 289:{f.StackOp("dup");f.Pc=290;continue;}
case 290:{if(!rt.StaticReady(f,"forge/util/collect/FSnapshotTable$SortedSnap","NO_DATA","[Ljava/lang/Object;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/collect/FSnapshotTable$SortedSnap","NO_DATA","[Ljava/lang/Object;"));f.Pc=293;continue;}
case 293:{f.Push(JValue.I(0));f.Pc=294;continue;}
case 294:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","<init>","([Ljava/lang/Object;I)V","invokespecial",297);}
case 297:{f.Pc=318;continue;}
case 300:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$SortedSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$SortedSnap")));f.Pc=303;continue;}
case 303:{f.StackOp("dup");f.Pc=304;continue;}
case 304:{f.Push(f.Locals[8]);f.Pc=306;continue;}
case 306:{f.Push(JValue.I(3));f.Pc=307;continue;}
case 307:{f.Push(f.Locals[9]);f.Pc=309;continue;}
case 309:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=310;continue;}
case 310:{return rt.Call(f,"java/util/Arrays","copyOf","([Ljava/lang/Object;I)[Ljava/lang/Object;","invokestatic",313);}
case 313:{f.Push(f.Locals[9]);f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","<init>","([Ljava/lang/Object;I)V","invokespecial",318);}
case 318:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;",value);f.Pc=321;continue;}
case 321:{f.Push(JValue.I(1));f.Pc=322;continue;}
case 322:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12266(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12267(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/util/collect/FSnapshotTable")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?17:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FSnapshotTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/util/collect/FSnapshotTable","version","()Ljava/lang/Object;","invokevirtual",14);}
case 14:{f.Pc=18;continue;}
case 17:{f.Push(JValue.R(null));f.Pc=18;continue;}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12268(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","contains","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokevirtual",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12269(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","containsRow","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12270(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","containsColumn","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12271(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","containsValue","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12272(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12273(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","size","()I","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?14:10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Pc=15;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12274(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","size","()I","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12275(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","row","(Ljava/lang/Object;)Ljava/util/Map;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12276(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","column","(Ljava/lang/Object;)Ljava/util/Map;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12277(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","table","()Lcom/google/common/collect/Table;","invokevirtual",7);}
case 7:{return rt.Call(f,"com/google/common/collect/Table","rowMap","()Ljava/util/Map;","invokeinterface",12);}
case 12:{return rt.Call(f,"java/util/Collections","unmodifiableMap","(Ljava/util/Map;)Ljava/util/Map;","invokestatic",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12278(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","table","()Lcom/google/common/collect/Table;","invokevirtual",7);}
case 7:{return rt.Call(f,"com/google/common/collect/Table","columnMap","()Ljava/util/Map;","invokeinterface",12);}
case 12:{return rt.Call(f,"java/util/Collections","unmodifiableMap","(Ljava/util/Map;)Ljava/util/Map;","invokestatic",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12279(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$KeyView"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$KeyView")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/util/collect/FSnapshotTable$KeyView","<init>","(Lforge/util/collect/FSnapshotTable;Z)V","invokespecial",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12280(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$KeyView"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$KeyView")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/util/collect/FSnapshotTable$KeyView","<init>","(Lforge/util/collect/FSnapshotTable;Z)V","invokespecial",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12281(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","values","()Ljava/util/Collection;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12282(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","cellSet","()Ljava/util/Set;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12283(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?33:5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"com/google/common/collect/Table")?1:0));f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Int==0?37:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/util/collect/FSnapshotTable","cellSet","()Ljava/util/Set;","invokevirtual",16);}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Table"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{return rt.Call(f,"com/google/common/collect/Table","cellSet","()Ljava/util/Set;","invokeinterface",25);}
case 25:{return rt.Call(f,"java/util/Set","equals","(Ljava/lang/Object;)Z","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int==0?37:33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{f.Pc=38;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12284(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/collect/FSnapshotTable","cellSet","()Ljava/util/Set;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/Set","hashCode","()I","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12285(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","table","()Lcom/google/common/collect/Table;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12286(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/io/ObjectOutputStream","defaultWriteObject","()V","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","table","()Lcom/google/common/collect/Table;","invokevirtual",12);}
case 12:{return rt.Call(f,"java/io/ObjectOutputStream","writeObject","(Ljava/lang/Object;)V","invokevirtual",15);}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12287(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/io/ObjectInputStream","defaultReadObject","()V","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/io/ObjectInputStream","readObject","()Ljava/lang/Object;","invokevirtual",8);}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Table"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable","sorted","Z"));f.Pc=16;continue;}
case 16:{f.Pc=f.Pop().Int==0?42:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$SortedSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$SortedSnap")));f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/util/collect/FSnapshotTable$SortedSnap","NO_DATA","[Ljava/lang/Object;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/collect/FSnapshotTable$SortedSnap","NO_DATA","[Ljava/lang/Object;"));f.Pc=27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","<init>","([Ljava/lang/Object;I)V","invokespecial",31);}
case 31:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;",value);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/util/collect/FSnapshotTable","putAll","(Lcom/google/common/collect/Table;)V","invokevirtual",39);}
case 39:{f.Pc=54;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$HashSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$HashSnap")));f.Pc=46;continue;}
case 46:{f.StackOp("dup");f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/util/collect/FSnapshotTable$HashSnap","<init>","(Lcom/google/common/collect/Table;)V","invokespecial",51);}
case 51:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable","snap","Lforge/util/collect/FSnapshotTable$Snap;",value);f.Pc=54;continue;}
case 54:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

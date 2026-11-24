// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1184{
internal static JClass Build(){var c=new JClass("forge/util/collect/FSnapshotTable$SortedSnap","forge/util/collect/FSnapshotTable$Snap",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("NO_DATA","[Ljava/lang/Object;",true,JValue.Default("[Ljava/lang/Object;"),null));
c.Add(new JField("d","[Ljava/lang/Object;",false,JValue.Default("[Ljava/lang/Object;"),null));
c.Add(new JField("n","I",false,JValue.Default("I"),null));
c.Add(new JField("table","Lcom/google/common/collect/Table;",false,JValue.Default("Lcom/google/common/collect/Table;"),null));
c.Add(new JField("values","Ljava/util/Collection;",false,JValue.Default("Ljava/util/Collection;"),null));
c.Add(new JMethod(12351,"forge/util/collect/FSnapshotTable$SortedSnap","<init>","([Ljava/lang/Object;I)V",0,3,2,new JHandler[]{},M12351));
c.Add(new JMethod(12352,"forge/util/collect/FSnapshotTable$SortedSnap","cmp","(Ljava/lang/Object;Ljava/lang/Object;)I",8,2,2,new JHandler[]{},M12352));
c.Add(new JMethod(12353,"forge/util/collect/FSnapshotTable$SortedSnap","search","([Ljava/lang/Object;ILjava/lang/Object;Ljava/lang/Object;)I",8,9,3,new JHandler[]{},M12353));
c.Add(new JMethod(12354,"forge/util/collect/FSnapshotTable$SortedSnap","find","(Ljava/lang/Object;Ljava/lang/Object;)I",0,4,4,new JHandler[]{new JHandler(17,30,31,"java/lang/ClassCastException")},M12354));
c.Add(new JMethod(12355,"forge/util/collect/FSnapshotTable$SortedSnap","rowLow","(Ljava/lang/Object;)I",2,5,3,new JHandler[]{},M12355));
c.Add(new JMethod(12356,"forge/util/collect/FSnapshotTable$SortedSnap","rowHigh","(Ljava/lang/Object;)I",2,5,3,new JHandler[]{},M12356));
c.Add(new JMethod(12357,"forge/util/collect/FSnapshotTable$SortedSnap","withValue","(ILjava/lang/Object;)Lforge/util/collect/FSnapshotTable$SortedSnap;",0,4,4,new JHandler[]{},M12357));
c.Add(new JMethod(12358,"forge/util/collect/FSnapshotTable$SortedSnap","inserted","(ILjava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lforge/util/collect/FSnapshotTable$SortedSnap;",0,6,7,new JHandler[]{},M12358));
c.Add(new JMethod(12359,"forge/util/collect/FSnapshotTable$SortedSnap","without","(I)Lforge/util/collect/FSnapshotTable$SortedSnap;",0,3,7,new JHandler[]{},M12359));
c.Add(new JMethod(12360,"forge/util/collect/FSnapshotTable$SortedSnap","size","()I",0,1,1,new JHandler[]{},M12360));
c.Add(new JMethod(12361,"forge/util/collect/FSnapshotTable$SortedSnap","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",0,4,3,new JHandler[]{},M12361));
c.Add(new JMethod(12362,"forge/util/collect/FSnapshotTable$SortedSnap","contains","(Ljava/lang/Object;Ljava/lang/Object;)Z",0,3,3,new JHandler[]{},M12362));
c.Add(new JMethod(12363,"forge/util/collect/FSnapshotTable$SortedSnap","containsRow","(Ljava/lang/Object;)Z",0,3,3,new JHandler[]{new JHandler(13,47,48,"java/lang/ClassCastException")},M12363));
c.Add(new JMethod(12364,"forge/util/collect/FSnapshotTable$SortedSnap","containsColumn","(Ljava/lang/Object;)Z",0,3,4,new JHandler[]{},M12364));
c.Add(new JMethod(12365,"forge/util/collect/FSnapshotTable$SortedSnap","containsValue","(Ljava/lang/Object;)Z",0,3,4,new JHandler[]{},M12365));
c.Add(new JMethod(12366,"forge/util/collect/FSnapshotTable$SortedSnap","values","()Ljava/util/Collection;",0,2,4,new JHandler[]{},M12366));
c.Add(new JMethod(12367,"forge/util/collect/FSnapshotTable$SortedSnap","cellSet","()Ljava/util/Set;",0,1,3,new JHandler[]{},M12367));
c.Add(new JMethod(12368,"forge/util/collect/FSnapshotTable$SortedSnap","row","(Ljava/lang/Object;)Ljava/util/Map;",0,3,6,new JHandler[]{new JHandler(15,47,66,"java/lang/ClassCastException"),new JHandler(48,65,66,"java/lang/ClassCastException")},M12368));
c.Add(new JMethod(12369,"forge/util/collect/FSnapshotTable$SortedSnap","column","(Ljava/lang/Object;)Ljava/util/Map;",0,4,5,new JHandler[]{},M12369));
c.Add(new JMethod(12370,"forge/util/collect/FSnapshotTable$SortedSnap","table","()Lcom/google/common/collect/Table;",0,4,6,new JHandler[]{},M12370));
c.Add(new JMethod(12371,"forge/util/collect/FSnapshotTable$SortedSnap","computeRowKeys","()Ljava/util/List;",0,5,3,new JHandler[]{},M12371));
c.Add(new JMethod(12372,"forge/util/collect/FSnapshotTable$SortedSnap","computeColumnKeys","()Ljava/util/List;",0,3,4,new JHandler[]{},M12372));
c.Add(new JMethod(12373,"forge/util/collect/FSnapshotTable$SortedSnap","<clinit>","()V",8,0,1,new JHandler[]{},M12373));
}

internal static JStep M12351(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/collect/FSnapshotTable$Snap","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12352(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Comparable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Comparable","compareTo","(Ljava/lang/Object;)I","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12353(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[4]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=6;continue;}
case 6:{f.Locals[5]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[4]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[5]);f.Pc=12;continue;}
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?91:15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[5]);f.Pc=19;continue;}
case 19:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iushr",a,b));f.Pc=22;continue;}
case 22:{f.Locals[6]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[6]);f.Pc=27;continue;}
case 27:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=28;continue;}
case 28:{f.Locals[7]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[7]);f.Pc=33;continue;}
case 33:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","cmp","(Ljava/lang/Object;Ljava/lang/Object;)I","invokestatic",38);}
case 38:{f.Locals[8]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[8]);f.Pc=42;continue;}
case 42:{f.Pc=f.Pop().Int!=0?57:45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[7]);f.Pc=48;continue;}
case 48:{f.Push(JValue.I(1));f.Pc=49;continue;}
case 49:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=50;continue;}
case 50:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","cmp","(Ljava/lang/Object;Ljava/lang/Object;)I","invokestatic",55);}
case 55:{f.Locals[8]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[8]);f.Pc=59;continue;}
case 59:{f.Pc=f.Pop().Int>=0?71:62;continue;}
case 62:{f.Push(f.Locals[6]);f.Pc=64;continue;}
case 64:{f.Push(JValue.I(1));f.Pc=65;continue;}
case 65:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=66;continue;}
case 66:{f.Locals[4]=f.Pop();f.Pc=68;continue;}
case 68:{f.Pc=88;continue;}
case 71:{f.Push(f.Locals[8]);f.Pc=73;continue;}
case 73:{f.Pc=f.Pop().Int<=0?85:76;continue;}
case 76:{f.Push(f.Locals[6]);f.Pc=78;continue;}
case 78:{f.Push(JValue.I(1));f.Pc=79;continue;}
case 79:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=80;continue;}
case 80:{f.Locals[5]=f.Pop();f.Pc=82;continue;}
case 82:{f.Pc=88;continue;}
case 85:{f.Push(f.Locals[6]);f.Pc=87;continue;}
case 87:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 88:{f.Pc=8;continue;}
case 91:{f.Push(f.Locals[4]);f.Pc=93;continue;}
case 93:{f.Push(JValue.I(1));f.Pc=94;continue;}
case 94:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=95;continue;}
case 95:{f.Push(JNumbers.Unary("ineg",f.Pop()));f.Pc=96;continue;}
case 96:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12354(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?15:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference==null?15:11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference!=null?17:15;continue;}
case 15:{f.Push(JValue.I(-1));f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","search","([Ljava/lang/Object;ILjava/lang/Object;Ljava/lang/Object;)I","invokestatic",30);}
case 30:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(JValue.I(-1));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12355(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=6;continue;}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?49:12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iushr",a,b));f.Pc=17;continue;}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=23;continue;}
case 23:{f.Push(JValue.I(3));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=27;continue;}
case 27:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","cmp","(Ljava/lang/Object;Ljava/lang/Object;)I","invokestatic",32);}
case 32:{f.Pc=f.Pop().Int>=0?43:35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=39;continue;}
case 39:{f.Locals[2]=f.Pop();f.Pc=40;continue;}
case 40:{f.Pc=46;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{f.Locals[3]=f.Pop();f.Pc=46;continue;}
case 46:{f.Pc=7;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12356(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=6;continue;}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?49:12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iushr",a,b));f.Pc=17;continue;}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=23;continue;}
case 23:{f.Push(JValue.I(3));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=27;continue;}
case 27:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","cmp","(Ljava/lang/Object;Ljava/lang/Object;)I","invokestatic",32);}
case 32:{f.Pc=f.Pop().Int>0?43:35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=39;continue;}
case 39:{f.Locals[2]=f.Pop();f.Pc=40;continue;}
case 40:{f.Pc=46;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{f.Locals[3]=f.Pop();f.Pc=46;continue;}
case 46:{f.Pc=7;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12357(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"[Ljava/lang/Object;","clone","()Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Ljava/lang/Object;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{f.Push(JValue.I(3));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=15;continue;}
case 15:{f.Push(JValue.I(2));f.Pc=16;continue;}
case 16:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=19;continue;}
case 19:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$SortedSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$SortedSnap")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","<init>","([Ljava/lang/Object;I)V","invokespecial",31);}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12358(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(3));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=7;continue;}
case 7:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=11;continue;}
case 11:{f.Locals[5]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[5]);f.Pc=20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{f.Push(JValue.I(3));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/System","arraycopy","(Ljava/lang/Object;ILjava/lang/Object;II)V","invokestatic",27);}
case 27:{f.Push(f.Locals[5]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(3));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[5]);f.Pc=36;continue;}
case 36:{f.Push(JValue.I(3));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=39;continue;}
case 39:{f.Push(JValue.I(1));f.Pc=40;continue;}
case 40:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[5]);f.Pc=45;continue;}
case 45:{f.Push(JValue.I(3));f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=48;continue;}
case 48:{f.Push(JValue.I(2));f.Pc=49;continue;}
case 49:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=57;continue;}
case 57:{f.Push(JValue.I(3));f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=60;continue;}
case 60:{f.Push(f.Locals[5]);f.Pc=62;continue;}
case 62:{f.Push(JValue.I(3));f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=65;continue;}
case 65:{f.Push(JValue.I(3));f.Pc=66;continue;}
case 66:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=67;continue;}
case 67:{f.Push(JValue.I(3));f.Pc=68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=74;continue;}
case 74:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/System","arraycopy","(Ljava/lang/Object;ILjava/lang/Object;II)V","invokestatic",78);}
case 78:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$SortedSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$SortedSnap")));f.Pc=81;continue;}
case 81:{f.StackOp("dup");f.Pc=82;continue;}
case 82:{f.Push(f.Locals[5]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=88;continue;}
case 88:{f.Push(JValue.I(1));f.Pc=89;continue;}
case 89:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","<init>","([Ljava/lang/Object;I)V","invokespecial",93);}
case 93:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12359(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?20:8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$SortedSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$SortedSnap")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/util/collect/FSnapshotTable$SortedSnap","NO_DATA","[Ljava/lang/Object;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/collect/FSnapshotTable$SortedSnap","NO_DATA","[Ljava/lang/Object;"));f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","<init>","([Ljava/lang/Object;I)V","invokespecial",19);}
case 19:{return JStep.Return(f.Pop());}
case 20:{f.Push(JValue.I(3));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=25;continue;}
case 25:{f.Push(JValue.I(1));f.Pc=26;continue;}
case 26:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=27;continue;}
case 27:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=31;continue;}
case 31:{f.Locals[2]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{f.Push(JValue.I(3));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/System","arraycopy","(Ljava/lang/Object;ILjava/lang/Object;II)V","invokestatic",45);}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=49;continue;}
case 49:{f.Push(JValue.I(3));f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=52;continue;}
case 52:{f.Push(JValue.I(3));f.Pc=53;continue;}
case 53:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(JValue.I(3));f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=58;continue;}
case 58:{f.Push(JValue.I(3));f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=65;continue;}
case 65:{f.Push(JValue.I(1));f.Pc=66;continue;}
case 66:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=67;continue;}
case 67:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/System","arraycopy","(Ljava/lang/Object;ILjava/lang/Object;II)V","invokestatic",71);}
case 71:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$SortedSnap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$SortedSnap")));f.Pc=74;continue;}
case 74:{f.StackOp("dup");f.Pc=75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=80;continue;}
case 80:{f.Push(JValue.I(1));f.Pc=81;continue;}
case 81:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","<init>","([Ljava/lang/Object;I)V","invokespecial",85);}
case 85:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12360(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12361(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","find","(Ljava/lang/Object;Ljava/lang/Object;)I","invokevirtual",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int<0?24:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=15;continue;}
case 15:{f.Push(JValue.I(3));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=20;continue;}
case 20:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.R(null));f.Pc=25;continue;}
case 25:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12362(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","find","(Ljava/lang/Object;Ljava/lang/Object;)I","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int<0?13:9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{f.Pc=14;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12363(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?11:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference!=null?13:11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","rowLow","(Ljava/lang/Object;)I","invokevirtual",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=24;continue;}
case 24:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?46:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=31;continue;}
case 31:{f.Push(JValue.I(3));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=34;continue;}
case 34:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","cmp","(Ljava/lang/Object;Ljava/lang/Object;)I","invokestatic",39);}
case 39:{f.Pc=f.Pop().Int!=0?46:42;continue;}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{f.Pc=47;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 48:{f.Locals[2]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12364(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=13;continue;}
case 13:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?41:16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=21;continue;}
case 21:{f.Push(JValue.I(3));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=26;continue;}
case 26:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?35:33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 35:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=38;continue;}
case 38:{f.Pc=8;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12365(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=13;continue;}
case 13:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?41:16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=21;continue;}
case 21:{f.Push(JValue.I(3));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=24;continue;}
case 24:{f.Push(JValue.I(2));f.Pc=25;continue;}
case 25:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=26;continue;}
case 26:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?35:33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 35:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=38;continue;}
case 38:{f.Pc=8;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12366(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","values","Ljava/util/Collection;"));f.Pc=4;continue;}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?43:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Int!=0?22:16;continue;}
case 16:{return rt.Call(f,"java/util/Collections","emptyList","()Ljava/util/List;","invokestatic",19);}
case 19:{f.Pc=37;continue;}
case 22:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$ValueList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$ValueList")));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/util/collect/FSnapshotTable$ValueList","<init>","([Ljava/lang/Object;I)V","invokespecial",37);}
case 37:{f.Locals[1]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","values","Ljava/util/Collection;",value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12367(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?13:7;continue;}
case 7:{return rt.Call(f,"java/util/Collections","emptySet","()Ljava/util/Set;","invokestatic",10);}
case 10:{f.Pc=21;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$CellSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$CellSet")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/collect/FSnapshotTable$CellSet","<init>","(Lforge/util/collect/FSnapshotTable$SortedSnap;)V","invokespecial",21);}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12368(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?11:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference!=null?15:11;continue;}
case 11:{return rt.Call(f,"java/util/Collections","emptyMap","()Ljava/util/Map;","invokestatic",14);}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","rowLow","(Ljava/lang/Object;)I","invokevirtual",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=26;continue;}
case 26:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?44:29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=33;continue;}
case 33:{f.Push(JValue.I(3));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=36;continue;}
case 36:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","cmp","(Ljava/lang/Object;Ljava/lang/Object;)I","invokestatic",41);}
case 41:{f.Pc=f.Pop().Int==0?48:44;continue;}
case 44:{return rt.Call(f,"java/util/Collections","emptyMap","()Ljava/util/Map;","invokestatic",47);}
case 47:{return JStep.Return(f.Pop());}
case 48:{if(!rt.EnsureInitialized(f,"forge/util/collect/FSnapshotTable$RowView"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FSnapshotTable$RowView")));f.Pc=51;continue;}
case 51:{f.StackOp("dup");f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/util/collect/FSnapshotTable$SortedSnap","rowHigh","(Ljava/lang/Object;)I","invokevirtual",62);}
case 62:{return rt.Call(f,"forge/util/collect/FSnapshotTable$RowView","<init>","([Ljava/lang/Object;II)V","invokespecial",65);}
case 65:{return JStep.Return(f.Pop());}
case 66:{f.Locals[2]=f.Pop();f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Collections","emptyMap","()Ljava/util/Map;","invokestatic",70);}
case 70:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12369(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?11:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference!=null?15:11;continue;}
case 11:{return rt.Call(f,"java/util/Collections","emptyMap","()Ljava/util/Map;","invokestatic",14);}
case 14:{return JStep.Return(f.Pop());}
case 15:{if(!rt.EnsureInitialized(f,"java/util/LinkedHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/LinkedHashMap")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/LinkedHashMap","<init>","()V","invokespecial",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=30;continue;}
case 30:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?81:33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=38;continue;}
case 38:{f.Push(JValue.I(3));f.Pc=39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=43;continue;}
case 43:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?75:50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=55;continue;}
case 55:{f.Push(JValue.I(3));f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=58;continue;}
case 58:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=63;continue;}
case 63:{f.Push(JValue.I(3));f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=66;continue;}
case 66:{f.Push(JValue.I(2));f.Pc=67;continue;}
case 67:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=68;continue;}
case 68:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",74);}
case 74:{f.StackOp("pop");f.Pc=75;continue;}
case 75:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=78;continue;}
case 78:{f.Pc=25;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",87);}
case 87:{f.Pc=f.Pop().Int==0?96:90;continue;}
case 90:{return rt.Call(f,"java/util/Collections","emptyMap","()Ljava/util/Map;","invokestatic",93);}
case 93:{f.Pc=100;continue;}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/util/Collections","unmodifiableMap","(Ljava/util/Map;)Ljava/util/Map;","invokestatic",100);}
case 100:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12370(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","table","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?69:9;continue;}
case 9:{return rt.Call(f,"com/google/common/collect/TreeBasedTable","create","()Lcom/google/common/collect/TreeBasedTable;","invokestatic",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=20;continue;}
case 20:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?62:23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=28;continue;}
case 28:{f.Push(JValue.I(3));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=31;continue;}
case 31:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=36;continue;}
case 36:{f.Push(JValue.I(3));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=39;continue;}
case 39:{f.Push(JValue.I(1));f.Pc=40;continue;}
case 40:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=41;continue;}
case 41:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=46;continue;}
case 46:{f.Push(JValue.I(3));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=49;continue;}
case 49:{f.Push(JValue.I(2));f.Pc=50;continue;}
case 50:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=51;continue;}
case 51:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=52;continue;}
case 52:{return rt.Call(f,"com/google/common/collect/TreeBasedTable","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=59;continue;}
case 59:{f.Pc=15;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{f.Locals[1]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","table","Lcom/google/common/collect/Table;",value);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12371(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=17;continue;}
case 17:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?61:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=27;continue;}
case 27:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=28;continue;}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{f.Pc=f.Pop().Int==0?43:34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int!=0?55:43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[4]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",51);}
case 51:{f.StackOp("pop");f.Pc=52;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{f.Locals[2]=f.Pop();f.Pc=55;continue;}
case 55:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=58;continue;}
case 58:{f.Pc=12;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12372(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/TreeSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeSet")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/TreeSet","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","n","I"));f.Pc=15;continue;}
case 15:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?39:18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FSnapshotTable$SortedSnap","d","[Ljava/lang/Object;"));f.Pc=23;continue;}
case 23:{f.Push(JValue.I(3));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=26;continue;}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=28;continue;}
case 28:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/TreeSet","add","(Ljava/lang/Object;)Z","invokevirtual",32);}
case 32:{f.StackOp("pop");f.Pc=33;continue;}
case 33:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=36;continue;}
case 36:{f.Pc=10;continue;}
case 39:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",47);}
case 47:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12373(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/util/collect/FSnapshotTable$SortedSnap","NO_DATA","[Ljava/lang/Object;"))return JStep.Continue;rt.PutStatic("forge/util/collect/FSnapshotTable$SortedSnap","NO_DATA","[Ljava/lang/Object;",f.Pop());f.Pc=7;continue;}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

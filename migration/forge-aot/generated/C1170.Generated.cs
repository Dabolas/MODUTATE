// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1170{
internal static JClass Build(){var c=new JClass("forge/util/collect/FCollection$Itr","java/lang/Object",new string[]{"java/util/Iterator"},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("snapshot","Ljava/util/ArrayList;",false,JValue.Default("Ljava/util/ArrayList;"),null));
c.Add(new JField("size","I",false,JValue.Default("I"),null));
c.Add(new JField("cursor","I",false,JValue.Default("I"),null));
c.Add(new JField("lastReturned","Ljava/lang/Object;",false,JValue.Default("Ljava/lang/Object;"),null));
c.Add(new JField("released","Z",false,JValue.Default("Z"),null));
c.Add(new JField("this$0","Lforge/util/collect/FCollection;",false,JValue.Default("Lforge/util/collect/FCollection;"),null));
c.Add(new JMethod(12217,"forge/util/collect/FCollection$Itr","<init>","(Lforge/util/collect/FCollection;)V",0,2,3,new JHandler[]{},M12217));
c.Add(new JMethod(12218,"forge/util/collect/FCollection$Itr","hasNext","()Z",1,1,2,new JHandler[]{},M12218));
c.Add(new JMethod(12219,"forge/util/collect/FCollection$Itr","next","()Ljava/lang/Object;",1,1,6,new JHandler[]{},M12219));
c.Add(new JMethod(12220,"forge/util/collect/FCollection$Itr","remove","()V",1,2,2,new JHandler[]{},M12220));
c.Add(new JMethod(12221,"forge/util/collect/FCollection$Itr","release","()V",2,1,3,new JHandler[]{},M12221));
}

internal static JStep M12217(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection$Itr","this$0","Lforge/util/collect/FCollection;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$Itr","this$0","Lforge/util/collect/FCollection;"));f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection$Itr","snapshot","Ljava/util/ArrayList;",value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$Itr","snapshot","Ljava/util/ArrayList;"));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",28);}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection$Itr","size","I",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.StackOp("dup");f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","liveIterators","I"));f.Pc=36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=38;continue;}
case 38:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","liveIterators","I",value);f.Pc=41;continue;}
case 41:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12218(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$Itr","cursor","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$Itr","size","I"));f.Pc=8;continue;}
case 8:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?13:11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/util/collect/FCollection$Itr","release","()V","invokevirtual",17);}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12219(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$Itr","cursor","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$Itr","size","I"));f.Pc=8;continue;}
case 8:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?23:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/util/collect/FCollection$Itr","release","()V","invokevirtual",15);}
case 15:{if(!rt.EnsureInitialized(f,"java/util/NoSuchElementException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/NoSuchElementException")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/NoSuchElementException","<init>","()V","invokespecial",22);}
case 22:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$Itr","snapshot","Ljava/util/ArrayList;"));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$Itr","cursor","I"));f.Pc=33;continue;}
case 33:{f.StackOp("dup_x1");f.Pc=34;continue;}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=36;continue;}
case 36:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection$Itr","cursor","I",value);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/ArrayList","get","(I)Ljava/lang/Object;","invokevirtual",42);}
case 42:{f.StackOp("dup_x1");f.Pc=43;continue;}
case 43:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection$Itr","lastReturned","Ljava/lang/Object;",value);f.Pc=46;continue;}
case 46:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12220(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$Itr","lastReturned","Ljava/lang/Object;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?15:7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"java/lang/IllegalStateException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalStateException")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/IllegalStateException","<init>","()V","invokespecial",14);}
case 14:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$Itr","lastReturned","Ljava/lang/Object;"));f.Pc=19;continue;}
case 19:{f.Locals[1]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(null));f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection$Itr","lastReturned","Ljava/lang/Object;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$Itr","this$0","Lforge/util/collect/FCollection;"));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/util/collect/FCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",33);}
case 33:{f.StackOp("pop");f.Pc=34;continue;}
case 34:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12221(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$Itr","released","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?49:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection$Itr","released","Z",value);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$Itr","this$0","Lforge/util/collect/FCollection;"));f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$Itr","snapshot","Ljava/util/ArrayList;"));f.Pc=23;continue;}
case 23:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?49:26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$Itr","this$0","Lforge/util/collect/FCollection;"));f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","liveIterators","I"));f.Pc=33;continue;}
case 33:{f.Pc=f.Pop().Int<=0?49:36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$Itr","this$0","Lforge/util/collect/FCollection;"));f.Pc=40;continue;}
case 40:{f.StackOp("dup");f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","liveIterators","I"));f.Pc=44;continue;}
case 44:{f.Push(JValue.I(1));f.Pc=45;continue;}
case 45:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=46;continue;}
case 46:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","liveIterators","I",value);f.Pc=49;continue;}
case 49:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

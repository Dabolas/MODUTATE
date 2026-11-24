// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1171{
internal static JClass Build(){var c=new JClass("forge/util/collect/FCollection$SetIterator","java/lang/Object",new string[]{"java/util/Iterator"},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("cursor","I",false,JValue.Default("I"),null));
c.Add(new JField("lastReturned","I",false,JValue.Default("I"),null));
c.Add(new JField("this$0","Lforge/util/collect/FCollection;",false,JValue.Default("Lforge/util/collect/FCollection;"),null));
c.Add(new JMethod(12222,"forge/util/collect/FCollection$SetIterator","<init>","(Lforge/util/collect/FCollection;)V",2,2,2,new JHandler[]{},M12222));
c.Add(new JMethod(12223,"forge/util/collect/FCollection$SetIterator","hasNext","()Z",1,1,2,new JHandler[]{},M12223));
c.Add(new JMethod(12224,"forge/util/collect/FCollection$SetIterator","next","()Ljava/lang/Object;",1,1,5,new JHandler[]{},M12224));
c.Add(new JMethod(12225,"forge/util/collect/FCollection$SetIterator","remove","()V",1,2,3,new JHandler[]{},M12225));
}

internal static JStep M12222(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection$SetIterator","this$0","Lforge/util/collect/FCollection;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(-1));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection$SetIterator","lastReturned","I",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12223(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetIterator","cursor","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetIterator","this$0","Lforge/util/collect/FCollection;"));f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",14);}
case 14:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12224(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetIterator","cursor","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetIterator","this$0","Lforge/util/collect/FCollection;"));f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",14);}
case 14:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?25:17;continue;}
case 17:{if(!rt.EnsureInitialized(f,"java/util/NoSuchElementException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/NoSuchElementException")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/NoSuchElementException","<init>","()V","invokespecial",24);}
case 24:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetIterator","cursor","I"));f.Pc=30;continue;}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection$SetIterator","lastReturned","I",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetIterator","this$0","Lforge/util/collect/FCollection;"));f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetIterator","cursor","I"));f.Pc=45;continue;}
case 45:{f.StackOp("dup_x1");f.Pc=46;continue;}
case 46:{f.Push(JValue.I(1));f.Pc=47;continue;}
case 47:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=48;continue;}
case 48:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection$SetIterator","cursor","I",value);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/ArrayList","get","(I)Ljava/lang/Object;","invokevirtual",54);}
case 54:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12225(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetIterator","lastReturned","I"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int>=0?15:7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"java/lang/IllegalStateException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalStateException")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/IllegalStateException","<init>","()V","invokespecial",14);}
case 14:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetIterator","this$0","Lforge/util/collect/FCollection;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/util/collect/FCollection","ownList","()V","invokevirtual",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetIterator","this$0","Lforge/util/collect/FCollection;"));f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","list","Ljava/util/ArrayList;"));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetIterator","lastReturned","I"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/ArrayList","remove","(I)Ljava/lang/Object;","invokevirtual",36);}
case 36:{f.Locals[1]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetIterator","this$0","Lforge/util/collect/FCollection;"));f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","modCount","I"));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=47;continue;}
case 47:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection","modCount","I",value);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Pc=f.Pop().Reference==null?73:54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetIterator","this$0","Lforge/util/collect/FCollection;"));f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection","hashTable","[Ljava/lang/Object;"));f.Pc=61;continue;}
case 61:{f.Pc=f.Pop().Reference==null?73:64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetIterator","this$0","Lforge/util/collect/FCollection;"));f.Pc=68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/util/collect/FCollection","removeFromHashTable","(Ljava/lang/Object;)Z","invokevirtual",72);}
case 72:{f.StackOp("pop");f.Pc=73;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetIterator","lastReturned","I"));f.Pc=78;continue;}
case 78:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection$SetIterator","cursor","I",value);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(JValue.I(-1));f.Pc=83;continue;}
case 83:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection$SetIterator","lastReturned","I",value);f.Pc=86;continue;}
case 86:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

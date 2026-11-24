// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1107{
internal static JClass Build(){var c=new JClass("forge/util/BagRandomizer","java/lang/Object",new string[]{"java/lang/Iterable"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("random","Ljava/util/Random;",true,JValue.Default("Ljava/util/Random;"),null));
c.Add(new JField("bag","[Ljava/lang/Object;",false,JValue.Default("[Ljava/lang/Object;"),null));
c.Add(new JField("currentPosition","I",false,JValue.Default("I"),null));
c.Add(new JMethod(11646,"forge/util/BagRandomizer","<init>","([Ljava/lang/Object;)V",1,2,3,new JHandler[]{},M11646));
c.Add(new JMethod(11647,"forge/util/BagRandomizer","<init>","(Ljava/lang/Iterable;)V",1,5,3,new JHandler[]{},M11647));
c.Add(new JMethod(11648,"forge/util/BagRandomizer","getNextItem","()Ljava/lang/Object;",1,1,5,new JHandler[]{},M11648));
c.Add(new JMethod(11649,"forge/util/BagRandomizer","shuffleBag","()V",2,5,4,new JHandler[]{},M11649));
c.Add(new JMethod(11650,"forge/util/BagRandomizer","iterator","()Ljava/util/Iterator;",1,1,3,new JHandler[]{},M11650));
c.Add(new JMethod(11651,"forge/util/BagRandomizer","<clinit>","()V",8,0,2,new JHandler[]{},M11651));
}

internal static JStep M11646(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/BagRandomizer","currentPosition","I",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int!=0?24:14;continue;}
case 14:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("Must include at least one item!")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",23);}
case 23:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/BagRandomizer","bag","[Ljava/lang/Object;",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/util/BagRandomizer","shuffleBag","()V","invokevirtual",33);}
case 33:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11647(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/BagRandomizer","currentPosition","I",value);f.Pc=9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",23);}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int==0?51:33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",39);}
case 39:{f.Locals[4]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",47);}
case 47:{f.StackOp("pop");f.Pc=48;continue;}
case 48:{f.Pc=24;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int!=0?68:58;continue;}
case 58:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=61;continue;}
case 61:{f.StackOp("dup");f.Pc=62;continue;}
case 62:{f.Push(JValue.R(rt.String("Must include at least one item!")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",67);}
case 67:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/ArrayList","toArray","()[Ljava/lang/Object;","invokevirtual",73);}
case 73:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/BagRandomizer","bag","[Ljava/lang/Object;",value);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/util/BagRandomizer","shuffleBag","()V","invokevirtual",80);}
case 80:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11648(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/BagRandomizer","currentPosition","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/BagRandomizer","bag","[Ljava/lang/Object;"));f.Pc=8;continue;}
case 8:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=9;continue;}
case 9:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?21:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/util/BagRandomizer","shuffleBag","()V","invokevirtual",16);}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/BagRandomizer","currentPosition","I",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/util/BagRandomizer","bag","[Ljava/lang/Object;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.StackOp("dup");f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/util/BagRandomizer","currentPosition","I"));f.Pc=30;continue;}
case 30:{f.StackOp("dup_x1");f.Pc=31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=33;continue;}
case 33:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/BagRandomizer","currentPosition","I",value);f.Pc=36;continue;}
case 36:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=37;continue;}
case 37:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11649(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/BagRandomizer","bag","[Ljava/lang/Object;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=5;continue;}
case 5:{f.Locals[1]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?60:13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/util/BagRandomizer","random","Ljava/util/Random;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/BagRandomizer","random","Ljava/util/Random;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Random","nextDouble","()D","invokevirtual",19);}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=22;continue;}
case 22:{f.Push(JNumbers.Unary("i2d",f.Pop()));f.Pc=23;continue;}
case 23:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"dmul",a,b));f.Pc=24;continue;}
case 24:{f.Push(JNumbers.Unary("d2i",f.Pop()));f.Pc=25;continue;}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/util/BagRandomizer","bag","[Ljava/lang/Object;"));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=32;continue;}
case 32:{f.Locals[4]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/util/BagRandomizer","bag","[Ljava/lang/Object;"));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/util/BagRandomizer","bag","[Ljava/lang/Object;"));f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=45;continue;}
case 45:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(rt.GetField(f.Pop(),"forge/util/BagRandomizer","bag","[Ljava/lang/Object;"));f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=54;continue;}
case 54:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=57;continue;}
case 57:{f.Pc=8;continue;}
case 60:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11650(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/BagRandomizer$BagRandomizerIterator"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/BagRandomizer$BagRandomizerIterator")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/BagRandomizer$BagRandomizerIterator","<init>","(Lforge/util/BagRandomizer;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11651(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/security/SecureRandom"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/security/SecureRandom")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/security/SecureRandom","<init>","()V","invokespecial",7);}
case 7:{if(!rt.StaticReady(f,"forge/util/BagRandomizer","random","Ljava/util/Random;"))return JStep.Continue;rt.PutStatic("forge/util/BagRandomizer","random","Ljava/util/Random;",f.Pop());f.Pc=10;continue;}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

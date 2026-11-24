// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C79{
internal static JClass Build(){var c=new JClass("forge/card/mana/ManaCostParser","java/lang/Object",new string[]{"forge/card/mana/IParserManaCost"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("cost","[Ljava/lang/String;",false,JValue.Default("[Ljava/lang/String;"),null));
c.Add(new JField("nextToken","I",false,JValue.Default("I"),null));
c.Add(new JField("genericCost","I",false,JValue.Default("I"),null));
c.Add(new JMethod(1234,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;",9,3,3,new JHandler[]{},M1234));
c.Add(new JMethod(1235,"forge/card/mana/ManaCostParser","<init>","(Ljava/lang/String;)V",1,2,3,new JHandler[]{},M1235));
c.Add(new JMethod(1236,"forge/card/mana/ManaCostParser","getTotalGenericCost","()I",17,1,3,new JHandler[]{},M1236));
c.Add(new JMethod(1237,"forge/card/mana/ManaCostParser","hasNext","()Z",17,1,2,new JHandler[]{},M1237));
c.Add(new JMethod(1238,"forge/card/mana/ManaCostParser","next","()Lforge/card/mana/ManaCostShard;",17,3,5,new JHandler[]{},M1238));
c.Add(new JMethod(1239,"forge/card/mana/ManaCostParser","remove","()V",1,1,0,new JHandler[]{},M1239));
c.Add(new JMethod(1240,"forge/card/mana/ManaCostParser","next","()Ljava/lang/Object;",4161,1,1,new JHandler[]{},M1240));
}

internal static JStep M1234(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCostParser"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCostParser")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/mana/ManaCostParser","<init>","(Ljava/lang/String;)V","invokespecial",8);}
case 8:{f.Locals[1]=f.Pop();f.Pc=9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(Lforge/card/mana/IParserManaCost;)V","invokespecial",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/card/mana/ManaCost","toString","()Ljava/lang/String;","invokevirtual",22);}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1235(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String(" ")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",11);}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/mana/ManaCostParser","cost","[Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/mana/ManaCostParser","nextToken","I",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/mana/ManaCostParser","genericCost","I",value);f.Pc=24;continue;}
case 24:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1236(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/mana/ManaCostParser","hasNext","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?17:7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("Generic cost should be obtained after iteration is complete")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",16);}
case 16:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCostParser","genericCost","I"));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1237(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCostParser","nextToken","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCostParser","cost","[Ljava/lang/String;"));f.Pc=8;continue;}
case 8:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=9;continue;}
case 9:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?16:12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{f.Pc=17;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1238(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCostParser","cost","[Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCostParser","nextToken","I"));f.Pc=9;continue;}
case 9:{f.StackOp("dup_x1");f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/mana/ManaCostParser","nextToken","I",value);f.Pc=15;continue;}
case 15:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=16;continue;}
case 16:{f.Locals[1]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"com/google/common/primitives/Ints","tryParse","(Ljava/lang/String;)Ljava/lang/Integer;","invokestatic",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Reference==null?41:26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.StackOp("dup");f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/card/mana/ManaCostParser","genericCost","I"));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",35);}
case 35:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=36;continue;}
case 36:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/mana/ManaCostParser","genericCost","I",value);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(null));f.Pc=40;continue;}
case 40:{return JStep.Return(f.Pop());}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/card/mana/ManaCostShard","parseNonGeneric","(Ljava/lang/String;)Lforge/card/mana/ManaCostShard;","invokestatic",45);}
case 45:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1239(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1240(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/mana/ManaCostParser","next","()Lforge/card/mana/ManaCostShard;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

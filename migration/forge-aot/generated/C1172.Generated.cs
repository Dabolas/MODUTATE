// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1172{
internal static JClass Build(){var c=new JClass("forge/util/collect/FCollection$SetView","java/util/AbstractSet",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("this$0","Lforge/util/collect/FCollection;",false,JValue.Default("Lforge/util/collect/FCollection;"),null));
c.Add(new JMethod(12226,"forge/util/collect/FCollection$SetView","<init>","(Lforge/util/collect/FCollection;)V",2,2,2,new JHandler[]{},M12226));
c.Add(new JMethod(12227,"forge/util/collect/FCollection$SetView","size","()I",1,1,1,new JHandler[]{},M12227));
c.Add(new JMethod(12228,"forge/util/collect/FCollection$SetView","isEmpty","()Z",1,1,1,new JHandler[]{},M12228));
c.Add(new JMethod(12229,"forge/util/collect/FCollection$SetView","contains","(Ljava/lang/Object;)Z",1,2,2,new JHandler[]{},M12229));
c.Add(new JMethod(12230,"forge/util/collect/FCollection$SetView","iterator","()Ljava/util/Iterator;",1,1,3,new JHandler[]{},M12230));
c.Add(new JMethod(12231,"forge/util/collect/FCollection$SetView","add","(Ljava/lang/Object;)Z",1,2,2,new JHandler[]{},M12231));
c.Add(new JMethod(12232,"forge/util/collect/FCollection$SetView","remove","(Ljava/lang/Object;)Z",1,2,2,new JHandler[]{},M12232));
c.Add(new JMethod(12233,"forge/util/collect/FCollection$SetView","clear","()V",1,1,1,new JHandler[]{},M12233));
c.Add(new JMethod(12234,"forge/util/collect/FCollection$SetView","toArray","()[Ljava/lang/Object;",1,1,1,new JHandler[]{},M12234));
c.Add(new JMethod(12235,"forge/util/collect/FCollection$SetView","toArray","([Ljava/lang/Object;)[Ljava/lang/Object;",1,2,2,new JHandler[]{},M12235));
}

internal static JStep M12226(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/collect/FCollection$SetView","this$0","Lforge/util/collect/FCollection;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/AbstractSet","<init>","()V","invokespecial",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12227(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetView","this$0","Lforge/util/collect/FCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FCollection","size","()I","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12228(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetView","this$0","Lforge/util/collect/FCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FCollection","isEmpty","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12229(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetView","this$0","Lforge/util/collect/FCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12230(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection$SetIterator"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection$SetIterator")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetView","this$0","Lforge/util/collect/FCollection;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/util/collect/FCollection$SetIterator","<init>","(Lforge/util/collect/FCollection;)V","invokespecial",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12231(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetView","this$0","Lforge/util/collect/FCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12232(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetView","this$0","Lforge/util/collect/FCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12233(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetView","this$0","Lforge/util/collect/FCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FCollection","clear","()V","invokevirtual",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12234(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetView","this$0","Lforge/util/collect/FCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FCollection","toArray","()[Ljava/lang/Object;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12235(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/collect/FCollection$SetView","this$0","Lforge/util/collect/FCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FCollection","toArray","([Ljava/lang/Object;)[Ljava/lang/Object;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

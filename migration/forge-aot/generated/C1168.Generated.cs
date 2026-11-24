// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1168{
internal static JClass Build(){var c=new JClass("forge/util/collect/FCollection$1","java/lang/Object",new string[]{"java/util/Comparator"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(12175,"forge/util/collect/FCollection$1","<init>","()V",0,1,1,new JHandler[]{},M12175));
c.Add(new JMethod(12176,"forge/util/collect/FCollection$1","compare","(Ljava/lang/Object;Ljava/lang/Object;)I",1,3,2,new JHandler[]{},M12176));
}

internal static JStep M12175(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12176(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/String","compareTo","(Ljava/lang/String;)I","invokevirtual",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

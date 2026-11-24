// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1087{
internal static JClass Build(){var c=new JClass("forge/item/generation/IUnOpenedProduct","java/lang/Object",new string[]{"java/util/function/Supplier"},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(11478,"forge/item/generation/IUnOpenedProduct","get","()Ljava/util/List;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11479,"forge/item/generation/IUnOpenedProduct","get","()Ljava/lang/Object;",4161,1,1,new JHandler[]{},M11479));
}

internal static JStep M11479(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/generation/IUnOpenedProduct","get","()Ljava/util/List;","invokeinterface",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

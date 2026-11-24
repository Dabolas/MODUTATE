// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C63{
internal static JClass Build(){var c=new JClass("forge/card/ICardChangedType","java/lang/Object",new string[]{},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(1056,"forge/card/ICardChangedType","applyChanges","(Lforge/card/CardType;)Lforge/card/CardType;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1057,"forge/card/ICardChangedType","isRemoveLandTypes","()Z",1,1,1,new JHandler[]{},M1057));
}

internal static JStep M1057(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

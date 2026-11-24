// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C446{
internal static JClass Build(){var c=new JClass("forge/game/card/CardCollection$EmptyCardCollection","forge/util/collect/FCollection$EmptyFCollection",new string[]{"forge/game/card/CardCollectionView"},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-3218771134502034727L),null));
c.Add(new JMethod(4920,"forge/game/card/CardCollection$EmptyCardCollection","<init>","()V",2,1,1,new JHandler[]{},M4920));
}

internal static JStep M4920(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/collect/FCollection$EmptyFCollection","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

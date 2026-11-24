// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1060{
internal static JClass Build(){var c=new JClass("forge/item/InventoryItem","java/lang/Object",new string[]{"forge/util/ITranslatable"},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(11236,"forge/item/InventoryItem","getItemType","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11237,"forge/item/InventoryItem","getImageKey","(Z)Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11238,"forge/item/InventoryItem","getDisplayName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11238));
c.Add(new JMethod(11239,"forge/item/InventoryItem","hasFlavorName","()Z",1,1,1,new JHandler[]{},M11239));
c.Add(new JMethod(11240,"forge/item/InventoryItem","getUntranslatedType","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11240));
}

internal static JStep M11238(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/InventoryItem","getName","()Ljava/lang/String;","invokeinterface",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11239(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11240(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/InventoryItem","getItemType","()Ljava/lang/String;","invokeinterface",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

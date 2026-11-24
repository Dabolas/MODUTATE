// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C66{
internal static JClass Build(){var c=new JClass("forge/card/ICardFace","java/lang/Object",new string[]{"forge/card/ICardCharacteristics","forge/card/ICardRawAbilites","java/lang/Comparable"},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(1117,"forge/card/ICardFace","getFlavorName","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1118,"forge/card/ICardFace","getDisplayName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1118));
c.Add(new JMethod(1119,"forge/card/ICardFace","hasFunctionalVariants","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1120,"forge/card/ICardFace","getFunctionalVariant","(Ljava/lang/String;)Lforge/card/ICardFace;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(1121,"forge/card/ICardFace","getFunctionalVariants","()Ljava/util/Map;",1025,0,0,new JHandler[]{},null));
}

internal static JStep M1118(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ICardFace","getFlavorName","()Ljava/lang/String;","invokeinterface",6);}
case 6:{f.Pc=f.Pop().Reference==null?16:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/card/ICardFace","getFlavorName","()Ljava/lang/String;","invokeinterface",15);}
case 15:{return JStep.Return(f.Pop());}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",22);}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

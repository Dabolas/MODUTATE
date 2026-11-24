// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C415{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/TextBoxExchangeEffect$TextBoxData","java/lang/Object",new string[]{},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("spellabilities","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("triggers","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("replacements","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("statics","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("keywords","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(3778,"forge/game/ability/effects/TextBoxExchangeEffect$TextBoxData","<init>","()V",2,1,1,new JHandler[]{},M3778));
}

internal static JStep M3778(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

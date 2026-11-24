// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1085{
internal static JClass Build(){var c=new JClass("forge/item/generation/BoosterSlots","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("LAND","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"Land"));
c.Add(new JField("ANY","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"Any"));
c.Add(new JField("COMMON","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"Common"));
c.Add(new JField("UNCOMMON","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"Uncommon"));
c.Add(new JField("UNCOMMON_RARE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"UncommonRare"));
c.Add(new JField("UNCOMMON_RARE_MYTHIC","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"UncommonRareMythic"));
c.Add(new JField("RARE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"Rare"));
c.Add(new JField("RARE_MYTHIC","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"RareMythic"));
c.Add(new JField("MYTHIC","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"Mythic"));
c.Add(new JField("SPECIAL","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"Special"));
c.Add(new JField("BASIC_LAND","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"BasicLand"));
c.Add(new JField("TIME_SHIFTED","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"TimeShifted"));
c.Add(new JField("DUAL_FACED_CARD","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"dfc"));
c.Add(new JMethod(11474,"forge/item/generation/BoosterSlots","<init>","()V",1,1,1,new JHandler[]{},M11474));
}

internal static JStep M11474(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

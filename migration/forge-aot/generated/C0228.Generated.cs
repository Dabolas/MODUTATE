// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C228{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices","java/lang/Object",new string[]{},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("shuffleMandatory","Z",false,JValue.Default("Z"),null));
c.Add(new JField("searchedLibrary","Z",false,JValue.Default("Z"),null));
c.Add(new JField("chosenCards","Lforge/game/card/CardCollection;",false,JValue.Default("Lforge/game/card/CardCollection;"),null));
c.Add(new JField("libraryPos","I",false,JValue.Default("I"),null));
c.Add(new JField("origin","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("destination","Lforge/game/zone/ZoneType;",false,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JMethod(3119,"forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices","<init>","()V",2,1,1,new JHandler[]{},M3119));
}

internal static JStep M3119(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1124{
internal static JClass Build(){var c=new JClass("forge/util/IHasForgeLog","java/lang/Object",new string[]{},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("engineLog","Lorg/tinylog/TaggedLogger;",true,JValue.Default("Lorg/tinylog/TaggedLogger;"),null));
c.Add(new JField("guiLog","Lorg/tinylog/TaggedLogger;",true,JValue.Default("Lorg/tinylog/TaggedLogger;"),null));
c.Add(new JField("aiLog","Lorg/tinylog/TaggedLogger;",true,JValue.Default("Lorg/tinylog/TaggedLogger;"),null));
c.Add(new JField("netLog","Lorg/tinylog/TaggedLogger;",true,JValue.Default("Lorg/tinylog/TaggedLogger;"),null));
c.Add(new JMethod(11772,"forge/util/IHasForgeLog","<clinit>","()V",8,0,1,new JHandler[]{},M11772));
}

internal static JStep M11772(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("ENGINE")));f.Pc=2;continue;}
case 2:{return rt.Call(f,"org/tinylog/Logger","tag","(Ljava/lang/String;)Lorg/tinylog/TaggedLogger;","invokestatic",5);}
case 5:{if(!rt.StaticReady(f,"forge/util/IHasForgeLog","engineLog","Lorg/tinylog/TaggedLogger;"))return JStep.Continue;rt.PutStatic("forge/util/IHasForgeLog","engineLog","Lorg/tinylog/TaggedLogger;",f.Pop());f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("GUI")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"org/tinylog/Logger","tag","(Ljava/lang/String;)Lorg/tinylog/TaggedLogger;","invokestatic",13);}
case 13:{if(!rt.StaticReady(f,"forge/util/IHasForgeLog","guiLog","Lorg/tinylog/TaggedLogger;"))return JStep.Continue;rt.PutStatic("forge/util/IHasForgeLog","guiLog","Lorg/tinylog/TaggedLogger;",f.Pop());f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("AI")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"org/tinylog/Logger","tag","(Ljava/lang/String;)Lorg/tinylog/TaggedLogger;","invokestatic",21);}
case 21:{if(!rt.StaticReady(f,"forge/util/IHasForgeLog","aiLog","Lorg/tinylog/TaggedLogger;"))return JStep.Continue;rt.PutStatic("forge/util/IHasForgeLog","aiLog","Lorg/tinylog/TaggedLogger;",f.Pop());f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("NETWORK")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"org/tinylog/Logger","tag","(Ljava/lang/String;)Lorg/tinylog/TaggedLogger;","invokestatic",29);}
case 29:{if(!rt.StaticReady(f,"forge/util/IHasForgeLog","netLog","Lorg/tinylog/TaggedLogger;"))return JStep.Continue;rt.PutStatic("forge/util/IHasForgeLog","netLog","Lorg/tinylog/TaggedLogger;",f.Pop());f.Pc=32;continue;}
case 32:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C18{
internal static JClass Build(){var c=new JClass("forge/card/CardEdition$1","java/lang/Object",new string[]{},4128);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("$SwitchMap$forge$card$CardEdition$Type","[I",true,JValue.Default("[I"),null));
c.Add(new JMethod(428,"forge/card/CardEdition$1","<clinit>","()V",8,1,3,new JHandler[]{new JHandler(9,20,23,"java/lang/NoSuchFieldError"),new JHandler(24,35,38,"java/lang/NoSuchFieldError")},M428));
}

internal static JStep M428(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/card/CardEdition$Type","values","()[Lforge/card/CardEdition$Type;","invokestatic",3);}
case 3:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/card/CardEdition$1","$SwitchMap$forge$card$CardEdition$Type","[I"))return JStep.Continue;rt.PutStatic("forge/card/CardEdition$1","$SwitchMap$forge$card$CardEdition$Type","[I",f.Pop());f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/card/CardEdition$1","$SwitchMap$forge$card$CardEdition$Type","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$1","$SwitchMap$forge$card$CardEdition$Type","[I"));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","CORE","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","CORE","Lforge/card/CardEdition$Type;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/card/CardEdition$Type","ordinal","()I","invokevirtual",18);}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Locals[0]=f.Pop();f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/card/CardEdition$1","$SwitchMap$forge$card$CardEdition$Type","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$1","$SwitchMap$forge$card$CardEdition$Type","[I"));f.Pc=27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/CardEdition$Type","ordinal","()I","invokevirtual",33);}
case 33:{f.Push(JValue.I(2));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.Pc=39;continue;}
case 38:{f.Locals[0]=f.Pop();f.Pc=39;continue;}
case 39:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

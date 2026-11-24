// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1162{
internal static JClass Build(){var c=new JClass("forge/util/TextUtil$1","java/lang/Object",new string[]{},4128);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("$SwitchMap$forge$util$TextUtil$PhraseCase","[I",true,JValue.Default("[I"),null));
c.Add(new JMethod(12074,"forge/util/TextUtil$1","<clinit>","()V",8,1,3,new JHandler[]{new JHandler(9,20,23,"java/lang/NoSuchFieldError"),new JHandler(24,35,38,"java/lang/NoSuchFieldError"),new JHandler(39,50,53,"java/lang/NoSuchFieldError")},M12074));
}

internal static JStep M12074(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/TextUtil$PhraseCase","values","()[Lforge/util/TextUtil$PhraseCase;","invokestatic",3);}
case 3:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/util/TextUtil$1","$SwitchMap$forge$util$TextUtil$PhraseCase","[I"))return JStep.Continue;rt.PutStatic("forge/util/TextUtil$1","$SwitchMap$forge$util$TextUtil$PhraseCase","[I",f.Pop());f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/util/TextUtil$1","$SwitchMap$forge$util$TextUtil$PhraseCase","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil$1","$SwitchMap$forge$util$TextUtil$PhraseCase","[I"));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/util/TextUtil$PhraseCase","Title","Lforge/util/TextUtil$PhraseCase;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil$PhraseCase","Title","Lforge/util/TextUtil$PhraseCase;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/util/TextUtil$PhraseCase","ordinal","()I","invokevirtual",18);}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Locals[0]=f.Pop();f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/util/TextUtil$1","$SwitchMap$forge$util$TextUtil$PhraseCase","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil$1","$SwitchMap$forge$util$TextUtil$PhraseCase","[I"));f.Pc=27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/util/TextUtil$PhraseCase","Sentence","Lforge/util/TextUtil$PhraseCase;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil$PhraseCase","Sentence","Lforge/util/TextUtil$PhraseCase;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/util/TextUtil$PhraseCase","ordinal","()I","invokevirtual",33);}
case 33:{f.Push(JValue.I(2));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.Pc=39;continue;}
case 38:{f.Locals[0]=f.Pop();f.Pc=39;continue;}
case 39:{if(!rt.StaticReady(f,"forge/util/TextUtil$1","$SwitchMap$forge$util$TextUtil$PhraseCase","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil$1","$SwitchMap$forge$util$TextUtil$PhraseCase","[I"));f.Pc=42;continue;}
case 42:{if(!rt.StaticReady(f,"forge/util/TextUtil$PhraseCase","Lower","Lforge/util/TextUtil$PhraseCase;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/TextUtil$PhraseCase","Lower","Lforge/util/TextUtil$PhraseCase;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/util/TextUtil$PhraseCase","ordinal","()I","invokevirtual",48);}
case 48:{f.Push(JValue.I(3));f.Pc=49;continue;}
case 49:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=50;continue;}
case 50:{f.Pc=54;continue;}
case 53:{f.Locals[0]=f.Pop();f.Pc=54;continue;}
case 54:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

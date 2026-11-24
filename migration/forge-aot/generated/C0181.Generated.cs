// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C181{
internal static JClass Build(){var c=new JClass("forge/game/ability/AbilityFactory$1","java/lang/Object",new string[]{},4128);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("$SwitchMap$forge$game$ability$AbilityFactory$AbilityRecordType","[I",true,JValue.Default("[I"),null));
c.Add(new JMethod(2801,"forge/game/ability/AbilityFactory$1","<clinit>","()V",8,1,3,new JHandler[]{new JHandler(9,20,23,"java/lang/NoSuchFieldError"),new JHandler(24,35,38,"java/lang/NoSuchFieldError"),new JHandler(39,50,53,"java/lang/NoSuchFieldError"),new JHandler(54,65,68,"java/lang/NoSuchFieldError")},M2801));
}

internal static JStep M2801(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","values","()[Lforge/game/ability/AbilityFactory$AbilityRecordType;","invokestatic",3);}
case 3:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$1","$SwitchMap$forge$game$ability$AbilityFactory$AbilityRecordType","[I"))return JStep.Continue;rt.PutStatic("forge/game/ability/AbilityFactory$1","$SwitchMap$forge$game$ability$AbilityFactory$AbilityRecordType","[I",f.Pop());f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$1","$SwitchMap$forge$game$ability$AbilityFactory$AbilityRecordType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$1","$SwitchMap$forge$game$ability$AbilityFactory$AbilityRecordType","[I"));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","Ability","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$AbilityRecordType","Ability","Lforge/game/ability/AbilityFactory$AbilityRecordType;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","ordinal","()I","invokevirtual",18);}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Locals[0]=f.Pop();f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$1","$SwitchMap$forge$game$ability$AbilityFactory$AbilityRecordType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$1","$SwitchMap$forge$game$ability$AbilityFactory$AbilityRecordType","[I"));f.Pc=27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","Spell","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$AbilityRecordType","Spell","Lforge/game/ability/AbilityFactory$AbilityRecordType;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","ordinal","()I","invokevirtual",33);}
case 33:{f.Push(JValue.I(2));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.Pc=39;continue;}
case 38:{f.Locals[0]=f.Pop();f.Pc=39;continue;}
case 39:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$1","$SwitchMap$forge$game$ability$AbilityFactory$AbilityRecordType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$1","$SwitchMap$forge$game$ability$AbilityFactory$AbilityRecordType","[I"));f.Pc=42;continue;}
case 42:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","StaticAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$AbilityRecordType","StaticAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","ordinal","()I","invokevirtual",48);}
case 48:{f.Push(JValue.I(3));f.Pc=49;continue;}
case 49:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=50;continue;}
case 50:{f.Pc=54;continue;}
case 53:{f.Locals[0]=f.Pop();f.Pc=54;continue;}
case 54:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$1","$SwitchMap$forge$game$ability$AbilityFactory$AbilityRecordType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$1","$SwitchMap$forge$game$ability$AbilityFactory$AbilityRecordType","[I"));f.Pc=57;continue;}
case 57:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","SubAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$AbilityRecordType","SubAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","ordinal","()I","invokevirtual",63);}
case 63:{f.Push(JValue.I(4));f.Pc=64;continue;}
case 64:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=65;continue;}
case 65:{f.Pc=69;continue;}
case 68:{f.Locals[0]=f.Pop();f.Pc=69;continue;}
case 69:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

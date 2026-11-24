// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C698{
internal static JClass Build(){var c=new JClass("forge/game/phase/PhaseHandler$1","java/lang/Object",new string[]{},4128);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("$SwitchMap$forge$game$phase$PhaseType","[I",true,JValue.Default("[I"),null));
c.Add(new JMethod(7935,"forge/game/phase/PhaseHandler$1","<clinit>","()V",8,1,3,new JHandler[]{new JHandler(9,20,23,"java/lang/NoSuchFieldError"),new JHandler(24,35,38,"java/lang/NoSuchFieldError"),new JHandler(39,50,53,"java/lang/NoSuchFieldError"),new JHandler(54,65,68,"java/lang/NoSuchFieldError"),new JHandler(69,80,83,"java/lang/NoSuchFieldError"),new JHandler(84,96,99,"java/lang/NoSuchFieldError"),new JHandler(100,112,115,"java/lang/NoSuchFieldError"),new JHandler(116,128,131,"java/lang/NoSuchFieldError"),new JHandler(132,144,147,"java/lang/NoSuchFieldError"),new JHandler(148,160,163,"java/lang/NoSuchFieldError"),new JHandler(164,176,179,"java/lang/NoSuchFieldError"),new JHandler(180,192,195,"java/lang/NoSuchFieldError"),new JHandler(196,208,211,"java/lang/NoSuchFieldError")},M7935));
}

internal static JStep M7935(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/game/phase/PhaseType","values","()[Lforge/game/phase/PhaseType;","invokestatic",3);}
case 3:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"))return JStep.Continue;rt.PutStatic("forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I",f.Pop());f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","DRAW","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","DRAW","Lforge/game/phase/PhaseType;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/phase/PhaseType","ordinal","()I","invokevirtual",18);}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Locals[0]=f.Pop();f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"));f.Pc=27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_BEGIN","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_BEGIN","Lforge/game/phase/PhaseType;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/phase/PhaseType","ordinal","()I","invokevirtual",33);}
case 33:{f.Push(JValue.I(2));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.Pc=39;continue;}
case 38:{f.Locals[0]=f.Pop();f.Pc=39;continue;}
case 39:{if(!rt.StaticReady(f,"forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"));f.Pc=42;continue;}
case 42:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DECLARE_ATTACKERS","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_DECLARE_ATTACKERS","Lforge/game/phase/PhaseType;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/phase/PhaseType","ordinal","()I","invokevirtual",48);}
case 48:{f.Push(JValue.I(3));f.Pc=49;continue;}
case 49:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=50;continue;}
case 50:{f.Pc=54;continue;}
case 53:{f.Locals[0]=f.Pop();f.Pc=54;continue;}
case 54:{if(!rt.StaticReady(f,"forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"));f.Pc=57;continue;}
case 57:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DECLARE_BLOCKERS","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_DECLARE_BLOCKERS","Lforge/game/phase/PhaseType;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/phase/PhaseType","ordinal","()I","invokevirtual",63);}
case 63:{f.Push(JValue.I(4));f.Pc=64;continue;}
case 64:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=65;continue;}
case 65:{f.Pc=69;continue;}
case 68:{f.Locals[0]=f.Pop();f.Pc=69;continue;}
case 69:{if(!rt.StaticReady(f,"forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_FIRST_STRIKE_DAMAGE","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_FIRST_STRIKE_DAMAGE","Lforge/game/phase/PhaseType;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/phase/PhaseType","ordinal","()I","invokevirtual",78);}
case 78:{f.Push(JValue.I(5));f.Pc=79;continue;}
case 79:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=80;continue;}
case 80:{f.Pc=84;continue;}
case 83:{f.Locals[0]=f.Pop();f.Pc=84;continue;}
case 84:{if(!rt.StaticReady(f,"forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"));f.Pc=87;continue;}
case 87:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DAMAGE","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_DAMAGE","Lforge/game/phase/PhaseType;"));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/phase/PhaseType","ordinal","()I","invokevirtual",93);}
case 93:{f.Push(JValue.I(6));f.Pc=95;continue;}
case 95:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=96;continue;}
case 96:{f.Pc=100;continue;}
case 99:{f.Locals[0]=f.Pop();f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"));f.Pc=103;continue;}
case 103:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","UNTAP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","UNTAP","Lforge/game/phase/PhaseType;"));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/phase/PhaseType","ordinal","()I","invokevirtual",109);}
case 109:{f.Push(JValue.I(7));f.Pc=111;continue;}
case 111:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=112;continue;}
case 112:{f.Pc=116;continue;}
case 115:{f.Locals[0]=f.Pop();f.Pc=116;continue;}
case 116:{if(!rt.StaticReady(f,"forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"));f.Pc=119;continue;}
case 119:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","UPKEEP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","UPKEEP","Lforge/game/phase/PhaseType;"));f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/phase/PhaseType","ordinal","()I","invokevirtual",125);}
case 125:{f.Push(JValue.I(8));f.Pc=127;continue;}
case 127:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=128;continue;}
case 128:{f.Pc=132;continue;}
case 131:{f.Locals[0]=f.Pop();f.Pc=132;continue;}
case 132:{if(!rt.StaticReady(f,"forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"));f.Pc=135;continue;}
case 135:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","MAIN1","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","MAIN1","Lforge/game/phase/PhaseType;"));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/phase/PhaseType","ordinal","()I","invokevirtual",141);}
case 141:{f.Push(JValue.I(9));f.Pc=143;continue;}
case 143:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=144;continue;}
case 144:{f.Pc=148;continue;}
case 147:{f.Locals[0]=f.Pop();f.Pc=148;continue;}
case 148:{if(!rt.StaticReady(f,"forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"));f.Pc=151;continue;}
case 151:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_END","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_END","Lforge/game/phase/PhaseType;"));f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/phase/PhaseType","ordinal","()I","invokevirtual",157);}
case 157:{f.Push(JValue.I(10));f.Pc=159;continue;}
case 159:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=160;continue;}
case 160:{f.Pc=164;continue;}
case 163:{f.Locals[0]=f.Pop();f.Pc=164;continue;}
case 164:{if(!rt.StaticReady(f,"forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"));f.Pc=167;continue;}
case 167:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","MAIN2","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","MAIN2","Lforge/game/phase/PhaseType;"));f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/phase/PhaseType","ordinal","()I","invokevirtual",173);}
case 173:{f.Push(JValue.I(11));f.Pc=175;continue;}
case 175:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=176;continue;}
case 176:{f.Pc=180;continue;}
case 179:{f.Locals[0]=f.Pop();f.Pc=180;continue;}
case 180:{if(!rt.StaticReady(f,"forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"));f.Pc=183;continue;}
case 183:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","END_OF_TURN","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","END_OF_TURN","Lforge/game/phase/PhaseType;"));f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/phase/PhaseType","ordinal","()I","invokevirtual",189);}
case 189:{f.Push(JValue.I(12));f.Pc=191;continue;}
case 191:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=192;continue;}
case 192:{f.Pc=196;continue;}
case 195:{f.Locals[0]=f.Pop();f.Pc=196;continue;}
case 196:{if(!rt.StaticReady(f,"forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"));f.Pc=199;continue;}
case 199:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;"));f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/game/phase/PhaseType","ordinal","()I","invokevirtual",205);}
case 205:{f.Push(JValue.I(13));f.Pc=207;continue;}
case 207:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=208;continue;}
case 208:{f.Pc=212;continue;}
case 211:{f.Locals[0]=f.Pop();f.Pc=212;continue;}
case 212:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

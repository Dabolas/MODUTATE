// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C716{
internal static JClass Build(){var c=new JClass("forge/game/player/PlayerOutcome$1","java/lang/Object",new string[]{},4128);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("$SwitchMap$forge$game$player$GameLossReason","[I",true,JValue.Default("[I"),null));
c.Add(new JMethod(8634,"forge/game/player/PlayerOutcome$1","<clinit>","()V",8,1,3,new JHandler[]{new JHandler(9,20,23,"java/lang/NoSuchFieldError"),new JHandler(24,35,38,"java/lang/NoSuchFieldError"),new JHandler(39,50,53,"java/lang/NoSuchFieldError"),new JHandler(54,65,68,"java/lang/NoSuchFieldError"),new JHandler(69,80,83,"java/lang/NoSuchFieldError"),new JHandler(84,96,99,"java/lang/NoSuchFieldError"),new JHandler(100,112,115,"java/lang/NoSuchFieldError"),new JHandler(116,128,131,"java/lang/NoSuchFieldError")},M8634));
}

internal static JStep M8634(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/game/player/GameLossReason","values","()[Lforge/game/player/GameLossReason;","invokestatic",3);}
case 3:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/player/PlayerOutcome$1","$SwitchMap$forge$game$player$GameLossReason","[I"))return JStep.Continue;rt.PutStatic("forge/game/player/PlayerOutcome$1","$SwitchMap$forge$game$player$GameLossReason","[I",f.Pop());f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/game/player/PlayerOutcome$1","$SwitchMap$forge$game$player$GameLossReason","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerOutcome$1","$SwitchMap$forge$game$player$GameLossReason","[I"));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/player/GameLossReason","Conceded","Lforge/game/player/GameLossReason;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/GameLossReason","Conceded","Lforge/game/player/GameLossReason;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/player/GameLossReason","ordinal","()I","invokevirtual",18);}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Locals[0]=f.Pop();f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/player/PlayerOutcome$1","$SwitchMap$forge$game$player$GameLossReason","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerOutcome$1","$SwitchMap$forge$game$player$GameLossReason","[I"));f.Pc=27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/game/player/GameLossReason","Milled","Lforge/game/player/GameLossReason;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/GameLossReason","Milled","Lforge/game/player/GameLossReason;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/player/GameLossReason","ordinal","()I","invokevirtual",33);}
case 33:{f.Push(JValue.I(2));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.Pc=39;continue;}
case 38:{f.Locals[0]=f.Pop();f.Pc=39;continue;}
case 39:{if(!rt.StaticReady(f,"forge/game/player/PlayerOutcome$1","$SwitchMap$forge$game$player$GameLossReason","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerOutcome$1","$SwitchMap$forge$game$player$GameLossReason","[I"));f.Pc=42;continue;}
case 42:{if(!rt.StaticReady(f,"forge/game/player/GameLossReason","LifeReachedZero","Lforge/game/player/GameLossReason;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/GameLossReason","LifeReachedZero","Lforge/game/player/GameLossReason;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/player/GameLossReason","ordinal","()I","invokevirtual",48);}
case 48:{f.Push(JValue.I(3));f.Pc=49;continue;}
case 49:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=50;continue;}
case 50:{f.Pc=54;continue;}
case 53:{f.Locals[0]=f.Pop();f.Pc=54;continue;}
case 54:{if(!rt.StaticReady(f,"forge/game/player/PlayerOutcome$1","$SwitchMap$forge$game$player$GameLossReason","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerOutcome$1","$SwitchMap$forge$game$player$GameLossReason","[I"));f.Pc=57;continue;}
case 57:{if(!rt.StaticReady(f,"forge/game/player/GameLossReason","Poisoned","Lforge/game/player/GameLossReason;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/GameLossReason","Poisoned","Lforge/game/player/GameLossReason;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/player/GameLossReason","ordinal","()I","invokevirtual",63);}
case 63:{f.Push(JValue.I(4));f.Pc=64;continue;}
case 64:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=65;continue;}
case 65:{f.Pc=69;continue;}
case 68:{f.Locals[0]=f.Pop();f.Pc=69;continue;}
case 69:{if(!rt.StaticReady(f,"forge/game/player/PlayerOutcome$1","$SwitchMap$forge$game$player$GameLossReason","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerOutcome$1","$SwitchMap$forge$game$player$GameLossReason","[I"));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/game/player/GameLossReason","OpponentWon","Lforge/game/player/GameLossReason;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/GameLossReason","OpponentWon","Lforge/game/player/GameLossReason;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/player/GameLossReason","ordinal","()I","invokevirtual",78);}
case 78:{f.Push(JValue.I(5));f.Pc=79;continue;}
case 79:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=80;continue;}
case 80:{f.Pc=84;continue;}
case 83:{f.Locals[0]=f.Pop();f.Pc=84;continue;}
case 84:{if(!rt.StaticReady(f,"forge/game/player/PlayerOutcome$1","$SwitchMap$forge$game$player$GameLossReason","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerOutcome$1","$SwitchMap$forge$game$player$GameLossReason","[I"));f.Pc=87;continue;}
case 87:{if(!rt.StaticReady(f,"forge/game/player/GameLossReason","SpellEffect","Lforge/game/player/GameLossReason;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/GameLossReason","SpellEffect","Lforge/game/player/GameLossReason;"));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/player/GameLossReason","ordinal","()I","invokevirtual",93);}
case 93:{f.Push(JValue.I(6));f.Pc=95;continue;}
case 95:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=96;continue;}
case 96:{f.Pc=100;continue;}
case 99:{f.Locals[0]=f.Pop();f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/game/player/PlayerOutcome$1","$SwitchMap$forge$game$player$GameLossReason","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerOutcome$1","$SwitchMap$forge$game$player$GameLossReason","[I"));f.Pc=103;continue;}
case 103:{if(!rt.StaticReady(f,"forge/game/player/GameLossReason","CommanderDamage","Lforge/game/player/GameLossReason;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/GameLossReason","CommanderDamage","Lforge/game/player/GameLossReason;"));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/player/GameLossReason","ordinal","()I","invokevirtual",109);}
case 109:{f.Push(JValue.I(7));f.Pc=111;continue;}
case 111:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=112;continue;}
case 112:{f.Pc=116;continue;}
case 115:{f.Locals[0]=f.Pop();f.Pc=116;continue;}
case 116:{if(!rt.StaticReady(f,"forge/game/player/PlayerOutcome$1","$SwitchMap$forge$game$player$GameLossReason","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerOutcome$1","$SwitchMap$forge$game$player$GameLossReason","[I"));f.Pc=119;continue;}
case 119:{if(!rt.StaticReady(f,"forge/game/player/GameLossReason","IntentionalDraw","Lforge/game/player/GameLossReason;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/GameLossReason","IntentionalDraw","Lforge/game/player/GameLossReason;"));f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/player/GameLossReason","ordinal","()I","invokevirtual",125);}
case 125:{f.Push(JValue.I(8));f.Pc=127;continue;}
case 127:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=128;continue;}
case 128:{f.Pc=132;continue;}
case 131:{f.Locals[0]=f.Pop();f.Pc=132;continue;}
case 132:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

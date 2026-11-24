// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C432{
internal static JClass Build(){var c=new JClass("forge/game/card/Card$1","java/lang/Object",new string[]{},4128);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("$SwitchMap$forge$game$replacement$ReplacementResult","[I",true,JValue.Default("[I"),null));
c.Add(new JField("$SwitchMap$forge$game$card$Card$SplitCMCMode","[I",true,JValue.Default("[I"),null));
c.Add(new JMethod(4843,"forge/game/card/Card$1","<clinit>","()V",8,1,3,new JHandler[]{new JHandler(9,20,23,"java/lang/NoSuchFieldError"),new JHandler(24,35,38,"java/lang/NoSuchFieldError"),new JHandler(39,50,53,"java/lang/NoSuchFieldError"),new JHandler(63,74,77,"java/lang/NoSuchFieldError"),new JHandler(78,89,92,"java/lang/NoSuchFieldError"),new JHandler(93,104,107,"java/lang/NoSuchFieldError")},M4843));
}

internal static JStep M4843(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/game/card/Card$SplitCMCMode","values","()[Lforge/game/card/Card$SplitCMCMode;","invokestatic",3);}
case 3:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/card/Card$1","$SwitchMap$forge$game$card$Card$SplitCMCMode","[I"))return JStep.Continue;rt.PutStatic("forge/game/card/Card$1","$SwitchMap$forge$game$card$Card$SplitCMCMode","[I",f.Pop());f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/game/card/Card$1","$SwitchMap$forge$game$card$Card$SplitCMCMode","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/Card$1","$SwitchMap$forge$game$card$Card$SplitCMCMode","[I"));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/card/Card$SplitCMCMode","CurrentSideCMC","Lforge/game/card/Card$SplitCMCMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/Card$SplitCMCMode","CurrentSideCMC","Lforge/game/card/Card$SplitCMCMode;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card$SplitCMCMode","ordinal","()I","invokevirtual",18);}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Locals[0]=f.Pop();f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/card/Card$1","$SwitchMap$forge$game$card$Card$SplitCMCMode","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/Card$1","$SwitchMap$forge$game$card$Card$SplitCMCMode","[I"));f.Pc=27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/game/card/Card$SplitCMCMode","LeftSplitCMC","Lforge/game/card/Card$SplitCMCMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/Card$SplitCMCMode","LeftSplitCMC","Lforge/game/card/Card$SplitCMCMode;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/Card$SplitCMCMode","ordinal","()I","invokevirtual",33);}
case 33:{f.Push(JValue.I(2));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.Pc=39;continue;}
case 38:{f.Locals[0]=f.Pop();f.Pc=39;continue;}
case 39:{if(!rt.StaticReady(f,"forge/game/card/Card$1","$SwitchMap$forge$game$card$Card$SplitCMCMode","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/Card$1","$SwitchMap$forge$game$card$Card$SplitCMCMode","[I"));f.Pc=42;continue;}
case 42:{if(!rt.StaticReady(f,"forge/game/card/Card$SplitCMCMode","RightSplitCMC","Lforge/game/card/Card$SplitCMCMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/Card$SplitCMCMode","RightSplitCMC","Lforge/game/card/Card$SplitCMCMode;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/Card$SplitCMCMode","ordinal","()I","invokevirtual",48);}
case 48:{f.Push(JValue.I(3));f.Pc=49;continue;}
case 49:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=50;continue;}
case 50:{f.Pc=54;continue;}
case 53:{f.Locals[0]=f.Pop();f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/replacement/ReplacementResult","values","()[Lforge/game/replacement/ReplacementResult;","invokestatic",57);}
case 57:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=60;continue;}
case 60:{if(!rt.StaticReady(f,"forge/game/card/Card$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"))return JStep.Continue;rt.PutStatic("forge/game/card/Card$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I",f.Pop());f.Pc=63;continue;}
case 63:{if(!rt.StaticReady(f,"forge/game/card/Card$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/Card$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"));f.Pc=66;continue;}
case 66:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/replacement/ReplacementResult","ordinal","()I","invokevirtual",72);}
case 72:{f.Push(JValue.I(1));f.Pc=73;continue;}
case 73:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=74;continue;}
case 74:{f.Pc=78;continue;}
case 77:{f.Locals[0]=f.Pop();f.Pc=78;continue;}
case 78:{if(!rt.StaticReady(f,"forge/game/card/Card$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/Card$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"));f.Pc=81;continue;}
case 81:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/replacement/ReplacementResult","ordinal","()I","invokevirtual",87);}
case 87:{f.Push(JValue.I(2));f.Pc=88;continue;}
case 88:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=89;continue;}
case 89:{f.Pc=93;continue;}
case 92:{f.Locals[0]=f.Pop();f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/game/card/Card$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/Card$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"));f.Pc=96;continue;}
case 96:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Replaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Replaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/replacement/ReplacementResult","ordinal","()I","invokevirtual",102);}
case 102:{f.Push(JValue.I(3));f.Pc=103;continue;}
case 103:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=104;continue;}
case 104:{f.Pc=108;continue;}
case 107:{f.Locals[0]=f.Pop();f.Pc=108;continue;}
case 108:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

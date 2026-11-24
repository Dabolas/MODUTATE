// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C235{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ChooseDirectionEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3148,"forge/game/ability/effects/ChooseDirectionEffect","<init>","()V",1,1,1,new JHandler[]{},M3148));
c.Add(new JMethod(3149,"forge/game/ability/effects/ChooseDirectionEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,7,5,new JHandler[]{},M3149));
}

internal static JStep M3148(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3149(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",21);}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",26);}
case 26:{f.Push(JValue.R(rt.String("lblLeftClockwise")));f.Pc=28;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",35);}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",40);}
case 40:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",43);}
case 43:{f.Push(JValue.R(rt.String("lblRightAntiClockwise")));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",52);}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"com/google/common/collect/Lists","reverse","(Ljava/util/List;)Ljava/util/List;","invokestatic",57);}
case 57:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",60);}
case 60:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseDirectionEffect:3149:60:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",65);}
case 65:{f.Locals[5]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",71);}
case 71:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",74);}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[5]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/player/PlayerController","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;)V","invokevirtual",81);}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",85);}
case 85:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",88);}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",92);}
case 92:{f.Push(JValue.R(rt.String("lblChooseDirection")));f.Pc=94;continue;}
case 94:{f.Push(JValue.I(0));f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",101);}
case 101:{if(!rt.StaticReady(f,"forge/game/player/PlayerController$BinaryChoiceType","LeftOrRight","Lforge/game/player/PlayerController$BinaryChoiceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerController$BinaryChoiceType","LeftOrRight","Lforge/game/player/PlayerController$BinaryChoiceType;"));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/player/PlayerController","chooseBinary","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/PlayerController$BinaryChoiceType;)Z","invokevirtual",107);}
case 107:{f.Locals[6]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[2]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[6]);f.Pc=112;continue;}
case 112:{f.Pc=f.Pop().Int==0?121:115;continue;}
case 115:{if(!rt.StaticReady(f,"forge/game/Direction","Left","Lforge/game/Direction;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/Direction","Left","Lforge/game/Direction;"));f.Pc=118;continue;}
case 118:{f.Pc=124;continue;}
case 121:{if(!rt.StaticReady(f,"forge/game/Direction","Right","Lforge/game/Direction;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/Direction","Right","Lforge/game/Direction;"));f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/card/Card","setChosenDirection","(Lforge/game/Direction;)V","invokevirtual",127);}
case 127:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

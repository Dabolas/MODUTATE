// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C236{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ChooseEvenOddEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3150,"forge/game/ability/effects/ChooseEvenOddEffect","<init>","()V",1,1,1,new JHandler[]{},M3150));
c.Add(new JMethod(3151,"forge/game/ability/effects/ChooseEvenOddEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,4,new JHandler[]{},M3151));
c.Add(new JMethod(3152,"forge/game/ability/effects/ChooseEvenOddEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,6,9,new JHandler[]{},M3152));
}

internal static JStep M3150(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3151(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/ChooseEvenOddEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?28:23;continue;}
case 23:{f.Push(JValue.R(rt.String("You choose")));f.Pc=25;continue;}
case 25:{f.Pc=54;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",32);}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",38);}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?47:42;continue;}
case 42:{f.Push(JValue.R(rt.String(" chooses")));f.Pc=44;continue;}
case 44:{f.Pc=49;continue;}
case 47:{f.Push(JValue.R(rt.String(" choose")));f.Pc=49;continue;}
case 49:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseEvenOddEffect:3151:49:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",54);}
case 54:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",57);}
case 57:{f.StackOp("pop");f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String(" even or odd.")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",64);}
case 64:{f.StackOp("pop");f.Pc=65;continue;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",69);}
case 69:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3152(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/ability/effects/ChooseEvenOddEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",9);}
case 9:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?130:22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[4]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int!=0?44:41;continue;}
case 41:{f.Pc=13;continue;}
case 44:{f.Push(f.Locals[4]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",49);}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("odd or even")));f.Pc=52;continue;}
case 52:{if(!rt.StaticReady(f,"forge/game/player/PlayerController$BinaryChoiceType","OddsOrEvens","Lforge/game/player/PlayerController$BinaryChoiceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerController$BinaryChoiceType","OddsOrEvens","Lforge/game/player/PlayerController$BinaryChoiceType;"));f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/player/PlayerController","chooseBinary","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/PlayerController$BinaryChoiceType;)Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int==0?67:61;continue;}
case 61:{if(!rt.StaticReady(f,"forge/game/EvenOdd","Odd","Lforge/game/EvenOdd;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/EvenOdd","Odd","Lforge/game/EvenOdd;"));f.Pc=64;continue;}
case 64:{f.Pc=70;continue;}
case 67:{if(!rt.StaticReady(f,"forge/game/EvenOdd","Even","Lforge/game/EvenOdd;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/EvenOdd","Even","Lforge/game/EvenOdd;"));f.Pc=70;continue;}
case 70:{f.Locals[5]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[2]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[5]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/card/Card","setChosenEvenOdd","(Lforge/game/EvenOdd;)V","invokevirtual",78);}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("Notify")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int==0?127:87;continue;}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",92);}
case 92:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",95);}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",100);}
case 100:{f.Push(JValue.R(rt.String("lblPlayerPickedChosen")));f.Pc=102;continue;}
case 102:{f.Push(JValue.I(2));f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=106;continue;}
case 106:{f.StackOp("dup");f.Pc=107;continue;}
case 107:{f.Push(JValue.I(0));f.Pc=108;continue;}
case 108:{f.Push(f.Locals[4]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",113);}
case 113:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=114;continue;}
case 114:{f.StackOp("dup");f.Pc=115;continue;}
case 115:{f.Push(JValue.I(1));f.Pc=116;continue;}
case 116:{f.Push(f.Locals[5]);f.Pc=118;continue;}
case 118:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",122);}
case 122:{f.Push(f.Locals[4]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",127);}
case 127:{f.Pc=13;continue;}
case 130:{f.Push(f.Locals[2]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",134);}
case 134:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

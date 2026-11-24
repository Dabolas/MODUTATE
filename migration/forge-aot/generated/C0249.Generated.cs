// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C249{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/CloneEffect$1","java/lang/Object",new string[]{"forge/GameCommand"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-78375985476256279L),null));
c.Add(new JField("val$cloneCard","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("val$ts","J",false,JValue.Default("J"),null));
c.Add(new JField("val$clonedImprinted","Ljava/lang/Iterable;",false,JValue.Default("Ljava/lang/Iterable;"),null));
c.Add(new JField("val$clonedRemembered","Ljava/lang/Iterable;",false,JValue.Default("Ljava/lang/Iterable;"),null));
c.Add(new JField("val$game","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JField("this$0","Lforge/game/ability/effects/CloneEffect;",false,JValue.Default("Lforge/game/ability/effects/CloneEffect;"),null));
c.Add(new JMethod(3190,"forge/game/ability/effects/CloneEffect$1","<init>","(Lforge/game/ability/effects/CloneEffect;Lforge/game/card/Card;JLjava/lang/Iterable;Ljava/lang/Iterable;Lforge/game/Game;)V",0,8,3,new JHandler[]{},M3190));
c.Add(new JMethod(3191,"forge/game/ability/effects/CloneEffect$1","run","()V",1,1,4,new JHandler[]{},M3191));
}

internal static JStep M3190(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/CloneEffect$1","this$0","Lforge/game/ability/effects/CloneEffect;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/CloneEffect$1","val$cloneCard","Lforge/game/card/Card;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/CloneEffect$1","val$ts","J",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[5]);f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/CloneEffect$1","val$clonedImprinted","Ljava/lang/Iterable;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[6]);f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/CloneEffect$1","val$clonedRemembered","Ljava/lang/Iterable;",value);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[7]);f.Pc=30;continue;}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/CloneEffect$1","val$game","Lforge/game/Game;",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",37);}
case 37:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3191(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/CloneEffect$1","val$cloneCard","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/CloneEffect$1","val$ts","J"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","removeCloneState","(J)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?108:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/CloneEffect$1","val$cloneCard","Lforge/game/card/Card;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/Card","clearImprintedCards","()V","invokevirtual",21);}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/CloneEffect$1","val$cloneCard","Lforge/game/card/Card;"));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",28);}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/CloneEffect$1","val$cloneCard","Lforge/game/card/Card;"));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/CloneEffect$1","val$clonedImprinted","Ljava/lang/Iterable;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/CardPredicates","ownerLives","()Ljava/util/function/Predicate;","invokestatic",39);}
case 39:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",42);}
case 42:{return rt.Call(f,"forge/game/card/Card","addImprintedCards","(Ljava/lang/Iterable;)V","invokevirtual",45);}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/CloneEffect$1","val$cloneCard","Lforge/game/card/Card;"));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/CloneEffect$1","val$clonedRemembered","Ljava/lang/Iterable;"));f.Pc=53;continue;}
case 53:{f.Push(JValue.R(rt.ClassObject("forge/game/player/Player")));f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/lang/Class;)Ljava/lang/Iterable;","invokestatic",58);}
case 58:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",61);}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/CloneEffect$1","val$cloneCard","Lforge/game/card/Card;"));f.Pc=65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/CloneEffect$1","val$clonedRemembered","Ljava/lang/Iterable;"));f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.ClassObject("forge/game/card/Card")));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/lang/Class;)Ljava/lang/Iterable;","invokestatic",74);}
case 74:{return rt.Call(f,"forge/game/card/CardPredicates","ownerLives","()Ljava/util/function/Predicate;","invokestatic",77);}
case 77:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",80);}
case 80:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",83);}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/CloneEffect$1","val$cloneCard","Lforge/game/card/Card;"));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",90);}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/CloneEffect$1","val$game","Lforge/game/Game;"));f.Pc=94;continue;}
case 94:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/CloneEffect$1","val$cloneCard","Lforge/game/card/Card;"));f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",105);}
case 105:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",108);}
case 108:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

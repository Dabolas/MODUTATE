// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C286{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/DetachedCardEffect","forge/game/card/Card",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("card","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JMethod(3327,"forge/game/ability/effects/DetachedCardEffect","<init>","(Lforge/game/card/Card;Ljava/lang/String;)V",1,3,4,new JHandler[]{},M3327));
c.Add(new JMethod(3328,"forge/game/ability/effects/DetachedCardEffect","<init>","(Lforge/game/player/Player;Ljava/lang/String;)V",1,3,4,new JHandler[]{},M3328));
c.Add(new JMethod(3329,"forge/game/ability/effects/DetachedCardEffect","<init>","(Lforge/game/ability/effects/DetachedCardEffect;Z)V",1,3,4,new JHandler[]{},M3329));
c.Add(new JMethod(3330,"forge/game/ability/effects/DetachedCardEffect","<init>","(Lforge/game/ability/effects/DetachedCardEffect;Lforge/game/Game;Z)V",1,4,4,new JHandler[]{},M3330));
c.Add(new JMethod(3331,"forge/game/ability/effects/DetachedCardEffect","getCardForUi","()Lforge/game/card/Card;",1,1,1,new JHandler[]{},M3331));
}

internal static JStep M3327(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/Game","nextCardId","()I","invokevirtual",11);}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",15);}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",19);}
case 19:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",22);}
case 22:{return rt.Call(f,"forge/game/card/Card","<init>","(ILforge/item/IPaperCard;Lforge/game/Game;)V","invokespecial",25);}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/DetachedCardEffect","card","Lforge/game/card/Card;",value);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/DetachedCardEffect","renderForUi","Z",value);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/ability/effects/DetachedCardEffect","setName","(Ljava/lang/String;)V","invokevirtual",40);}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/game/ability/effects/DetachedCardEffect","setOwner","(Lforge/game/player/Player;)V","invokevirtual",48);}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{if(!rt.StaticReady(f,"forge/card/GamePieceType","EFFECT","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","EFFECT","Lforge/card/GamePieceType;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/ability/effects/DetachedCardEffect","setGamePieceType","(Lforge/card/GamePieceType;)V","invokevirtual",55);}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/ability/effects/DetachedCardEffect","setEffectSource","(Lforge/game/card/Card;)V","invokevirtual",60);}
case 60:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3328(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/Game","nextCardId","()I","invokevirtual",8);}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/card/Card","<init>","(ILforge/item/IPaperCard;Lforge/game/Game;)V","invokespecial",16);}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(null));f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/DetachedCardEffect","card","Lforge/game/card/Card;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/DetachedCardEffect","renderForUi","Z",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/ability/effects/DetachedCardEffect","setName","(Ljava/lang/String;)V","invokevirtual",31);}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/ability/effects/DetachedCardEffect","setOwner","(Lforge/game/player/Player;)V","invokevirtual",36);}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/card/GamePieceType","EFFECT","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","EFFECT","Lforge/card/GamePieceType;"));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/ability/effects/DetachedCardEffect","setGamePieceType","(Lforge/card/GamePieceType;)V","invokevirtual",43);}
case 43:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3329(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/effects/DetachedCardEffect","getGame","()Lforge/game/Game;","invokevirtual",6);}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/ability/effects/DetachedCardEffect","<init>","(Lforge/game/ability/effects/DetachedCardEffect;Lforge/game/Game;Z)V","invokespecial",10);}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3330(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[3]);f.Pc=2;continue;}
case 2:{f.Pc=f.Pop().Int==0?12:5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/Game","nextCardId","()I","invokevirtual",9);}
case 9:{f.Pc=16;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/DetachedCardEffect","id","I"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/ability/effects/DetachedCardEffect","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",20);}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/Card","<init>","(ILforge/item/IPaperCard;Lforge/game/Game;)V","invokespecial",24);}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/DetachedCardEffect","renderForUi","Z"));f.Pc=29;continue;}
case 29:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/DetachedCardEffect","renderForUi","Z",value);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/ability/effects/DetachedCardEffect","getName","()Ljava/lang/String;","invokevirtual",37);}
case 37:{return rt.Call(f,"forge/game/ability/effects/DetachedCardEffect","setName","(Ljava/lang/String;)V","invokevirtual",40);}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{if(!rt.StaticReady(f,"forge/card/GamePieceType","EFFECT","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","EFFECT","Lforge/card/GamePieceType;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/ability/effects/DetachedCardEffect","setGamePieceType","(Lforge/card/GamePieceType;)V","invokevirtual",47);}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/ability/effects/DetachedCardEffect","getGame","()Lforge/game/Game;","invokevirtual",51);}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?71:55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/ability/effects/DetachedCardEffect","getOwner","()Lforge/game/player/Player;","invokevirtual",60);}
case 60:{return rt.Call(f,"forge/game/ability/effects/DetachedCardEffect","setOwner","(Lforge/game/player/Player;)V","invokevirtual",63);}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/ability/effects/DetachedCardEffect","getEffectSource","()Lforge/game/card/Card;","invokevirtual",68);}
case 68:{return rt.Call(f,"forge/game/ability/effects/DetachedCardEffect","setEffectSource","(Lforge/game/card/Card;)V","invokevirtual",71);}
case 71:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3331(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/DetachedCardEffect","card","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1046{
internal static JClass Build(){var c=new JClass("forge/game/zone/PlayerZone","forge/game/zone/Zone",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-5687652485777639176L),null));
c.Add(new JField("player","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JMethod(11093,"forge/game/zone/PlayerZone","alienCardsActivationFilter","(Lforge/game/player/Player;)Ljava/util/function/Predicate;",10,1,1,new JHandler[]{},M11093));
c.Add(new JMethod(11094,"forge/game/zone/PlayerZone","<init>","(Lforge/game/zone/ZoneType;Lforge/game/player/Player;)V",1,3,3,new JHandler[]{},M11094));
c.Add(new JMethod(11095,"forge/game/zone/PlayerZone","onChanged","()V",4,1,2,new JHandler[]{},M11095));
c.Add(new JMethod(11096,"forge/game/zone/PlayerZone","getPlayer","()Lforge/game/player/Player;",17,1,1,new JHandler[]{},M11096));
c.Add(new JMethod(11097,"forge/game/zone/PlayerZone","toString","()Ljava/lang/String;",17,1,3,new JHandler[]{},M11097));
c.Add(new JMethod(11098,"forge/game/zone/PlayerZone","getCardsPlayerCanActivate","(Lforge/game/player/Player;)Ljava/lang/Iterable;",1,5,3,new JHandler[]{},M11098));
c.Add(new JMethod(11099,"forge/game/zone/PlayerZone","lambda$alienCardsActivationFilter$0","(Lforge/game/player/Player;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M11099));
}

internal static JStep M11093(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/zone/PlayerZone:11093:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/player/Player;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11094(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",6);}
case 6:{return rt.Call(f,"forge/game/zone/Zone","<init>","(Lforge/game/zone/ZoneType;Lforge/game/Game;)V","invokespecial",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/PlayerZone","player","Lforge/game/player/Player;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11095(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/zone/PlayerZone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=7;continue;}
case 7:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?27:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/PlayerZone","player","Lforge/game/player/Player;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",17);}
case 17:{return rt.Call(f,"forge/game/player/PlayerController","isOrderedZone","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?27:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/zone/PlayerZone","sort","()V","invokevirtual",27);}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/PlayerZone","player","Lforge/game/player/Player;"));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/player/Player","updateZoneForView","(Lforge/game/zone/PlayerZone;)V","invokevirtual",35);}
case 35:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11096(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/PlayerZone","player","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11097(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",3);}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/PlayerZone","player","Lforge/game/player/Player;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/player/Player","toString","()Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/PlayerZone","zoneType","Lforge/game/zone/ZoneType;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/zone/ZoneType","toString","()Ljava/lang/String;","invokevirtual",17);}
case 17:{return rt.Call(f,"forge/util/Lang","getPossessedObject","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",20);}
case 20:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11098(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","(Z)Lforge/game/card/CardCollectionView;","invokevirtual",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/PlayerZone","player","Lforge/game/player/Player;"));f.Pc=11;continue;}
case 11:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{f.Pc=f.Pop().Int==0?46:24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/zone/PlayerZone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int!=0?44:34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/zone/PlayerZone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int==0?46:44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return JStep.Return(f.Pop());}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/zone/PlayerZone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int==0?62:56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{f.Push(JValue.I(1));f.Pc=58;continue;}
case 58:{return rt.Call(f,"com/google/common/collect/Iterables","limit","(Ljava/lang/Iterable;I)Ljava/lang/Iterable;","invokestatic",61);}
case 61:{f.Locals[2]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{f.Pc=f.Pop().Int==0?77:66;continue;}
case 66:{if(!rt.EnsureInitialized(f,"forge/game/zone/PlayerZone$OwnCardsActivationFilter"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/PlayerZone$OwnCardsActivationFilter")));f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/zone/PlayerZone$OwnCardsActivationFilter","<init>","(Lforge/game/zone/PlayerZone;)V","invokespecial",74);}
case 74:{f.Pc=81;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/zone/PlayerZone","alienCardsActivationFilter","(Lforge/game/player/Player;)Ljava/util/function/Predicate;","invokestatic",81);}
case 81:{f.Locals[4]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[4]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",89);}
case 89:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11099(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","mayPlay","(Lforge/game/player/Player;)Ljava/util/List;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?21:13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card","mayPlayerLook","(Lforge/game/player/Player;)Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?25:21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Pc=26;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

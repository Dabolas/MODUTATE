// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C687{
internal static JClass Build(){var c=new JClass("forge/game/mulligan/HoustonMulligan","forge/game/mulligan/AbstractMulligan",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("TUCK_COUNT","I",true,JValue.I(3),null));
c.Add(new JMethod(7810,"forge/game/mulligan/HoustonMulligan","handSizeAfterNextMulligan","()I",1,1,1,new JHandler[]{},M7810));
c.Add(new JMethod(7811,"forge/game/mulligan/HoustonMulligan","<init>","(Lforge/game/player/Player;Z)V",1,3,3,new JHandler[]{},M7811));
c.Add(new JMethod(7812,"forge/game/mulligan/HoustonMulligan","tuckCardsDuringMulligan","()I",1,1,1,new JHandler[]{},M7812));
c.Add(new JMethod(7813,"forge/game/mulligan/HoustonMulligan","beforeFirstMulligan","()V",1,1,2,new JHandler[]{},M7813));
c.Add(new JMethod(7814,"forge/game/mulligan/HoustonMulligan","keep","()V",1,4,4,new JHandler[]{},M7814));
c.Add(new JMethod(7815,"forge/game/mulligan/HoustonMulligan","canMulligan","()Z",1,1,1,new JHandler[]{},M7815));
}

internal static JStep M7810(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/HoustonMulligan","player","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/Player","getMaxHandSize","()I","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7811(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/mulligan/AbstractMulligan","<init>","(Lforge/game/player/Player;Z)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7812(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(3));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7813(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/HoustonMulligan","player","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(3));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/player/Player","drawCards","(I)Lforge/game/card/CardCollectionView;","invokevirtual",8);}
case 8:{f.StackOp("pop");f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7814(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/mulligan/AbstractMulligan","keep","()V","invokespecial",4);}
case 4:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/HoustonMulligan","player","Lforge/game/player/Player;"));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",21);}
case 21:{f.Locals[1]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/HoustonMulligan","player","Lforge/game/player/Player;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",29);}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/mulligan/HoustonMulligan","tuckCardsDuringMulligan","()I","invokevirtual",34);}
case 34:{return rt.Call(f,"forge/game/player/PlayerController","tuckCardsViaMulligan","(Lforge/game/card/CardCollectionView;I)Lforge/game/card/CardCollectionView;","invokevirtual",37);}
case 37:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",42);}
case 42:{f.Locals[2]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",49);}
case 49:{f.Pc=f.Pop().Int==0?82:52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{f.Locals[3]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/HoustonMulligan","player","Lforge/game/player/Player;"));f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",69);}
case 69:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",72);}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{f.Push(JValue.I(-1));f.Pc=74;continue;}
case 74:{f.Push(JValue.R(null));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{f.Pc=43;continue;}
case 82:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7815(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

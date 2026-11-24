// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C688{
internal static JClass Build(){var c=new JClass("forge/game/mulligan/LondonMulligan","forge/game/mulligan/AbstractMulligan",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(7816,"forge/game/mulligan/LondonMulligan","<init>","(Lforge/game/player/Player;Z)V",1,3,3,new JHandler[]{},M7816));
c.Add(new JMethod(7817,"forge/game/mulligan/LondonMulligan","canMulligan","()Z",1,1,2,new JHandler[]{},M7817));
c.Add(new JMethod(7818,"forge/game/mulligan/LondonMulligan","handSizeAfterNextMulligan","()I",1,1,1,new JHandler[]{},M7818));
c.Add(new JMethod(7819,"forge/game/mulligan/LondonMulligan","mulliganDraw","()V",1,5,4,new JHandler[]{},M7819));
c.Add(new JMethod(7820,"forge/game/mulligan/LondonMulligan","tuckCardsDuringMulligan","()I",1,2,2,new JHandler[]{},M7820));
}

internal static JStep M7816(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/mulligan/AbstractMulligan","<init>","(Lforge/game/player/Player;Z)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7817(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/LondonMulligan","kept","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?25:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/mulligan/LondonMulligan","tuckCardsDuringMulligan","()I","invokevirtual",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/LondonMulligan","player","Lforge/game/player/Player;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/player/Player","getMaxHandSize","()I","invokevirtual",18);}
case 18:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?25:21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Pc=26;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7818(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/LondonMulligan","player","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/Player","getMaxHandSize","()I","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7819(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/LondonMulligan","player","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/mulligan/LondonMulligan","handSizeAfterNextMulligan","()I","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/player/Player","drawCards","(I)Lforge/game/card/CardCollectionView;","invokevirtual",11);}
case 11:{f.StackOp("pop");f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/mulligan/LondonMulligan","tuckCardsDuringMulligan","()I","invokevirtual",16);}
case 16:{f.Locals[1]=f.Pop();f.Pc=17;continue;}
case 17:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/LondonMulligan","player","Lforge/game/player/Player;"));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",34);}
case 34:{f.Locals[2]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/LondonMulligan","player","Lforge/game/player/Player;"));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",42);}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/player/PlayerController","tuckCardsViaMulligan","(Lforge/game/card/CardCollectionView;I)Lforge/game/card/CardCollectionView;","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",52);}
case 52:{f.Locals[3]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",59);}
case 59:{f.Pc=f.Pop().Int==0?94:62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",68);}
case 68:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=71;continue;}
case 71:{f.Locals[4]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/LondonMulligan","player","Lforge/game/player/Player;"));f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",80);}
case 80:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",83);}
case 83:{f.Push(f.Locals[4]);f.Pc=85;continue;}
case 85:{f.Push(JValue.I(-1));f.Pc=86;continue;}
case 86:{f.Push(JValue.R(null));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",90);}
case 90:{f.StackOp("pop");f.Pc=91;continue;}
case 91:{f.Pc=53;continue;}
case 94:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7820(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/LondonMulligan","timesMulliganed","I"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/LondonMulligan","firstMulliganFree","Z"));f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Int==0?20:16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{f.Pc=21;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{f.Locals[1]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/LondonMulligan","timesMulliganed","I"));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

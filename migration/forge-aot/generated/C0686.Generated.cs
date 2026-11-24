// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C686{
internal static JClass Build(){var c=new JClass("forge/game/mulligan/AbstractMulligan","java/lang/Object",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("player","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("timesMulliganed","I",false,JValue.Default("I"),null));
c.Add(new JField("firstMulliganFree","Z",false,JValue.Default("Z"),null));
c.Add(new JField("kept","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(7798,"forge/game/mulligan/AbstractMulligan","<init>","(Lforge/game/player/Player;Z)V",1,3,2,new JHandler[]{},M7798));
c.Add(new JMethod(7799,"forge/game/mulligan/AbstractMulligan","getPlayer","()Lforge/game/player/Player;",1,1,1,new JHandler[]{},M7799));
c.Add(new JMethod(7800,"forge/game/mulligan/AbstractMulligan","beforeFirstMulligan","()V",1,1,0,new JHandler[]{},M7800));
c.Add(new JMethod(7801,"forge/game/mulligan/AbstractMulligan","canMulligan","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7802,"forge/game/mulligan/AbstractMulligan","handSizeAfterNextMulligan","()I",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7803,"forge/game/mulligan/AbstractMulligan","tuckCardsDuringMulligan","()I",1,1,1,new JHandler[]{},M7803));
c.Add(new JMethod(7804,"forge/game/mulligan/AbstractMulligan","mulligan","()V",1,4,4,new JHandler[]{new JHandler(74,80,83,"java/lang/InterruptedException")},M7804));
c.Add(new JMethod(7805,"forge/game/mulligan/AbstractMulligan","keep","()V",1,1,2,new JHandler[]{},M7805));
c.Add(new JMethod(7806,"forge/game/mulligan/AbstractMulligan","hasKept","()Z",1,1,1,new JHandler[]{},M7806));
c.Add(new JMethod(7807,"forge/game/mulligan/AbstractMulligan","revealPreMulligan","(Lforge/game/card/CardCollection;)V",1,2,0,new JHandler[]{},M7807));
c.Add(new JMethod(7808,"forge/game/mulligan/AbstractMulligan","mulliganDraw","()V",1,1,2,new JHandler[]{},M7808));
c.Add(new JMethod(7809,"forge/game/mulligan/AbstractMulligan","afterMulligan","()V",1,1,11,new JHandler[]{},M7809));
}

internal static JStep M7798(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mulligan/AbstractMulligan","timesMulliganed","I",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mulligan/AbstractMulligan","firstMulliganFree","Z",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mulligan/AbstractMulligan","kept","Z",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mulligan/AbstractMulligan","player","Lforge/game/player/Player;",value);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mulligan/AbstractMulligan","firstMulliganFree","Z",value);f.Pc=29;continue;}
case 29:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7799(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/AbstractMulligan","player","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7800(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7803(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7804(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/AbstractMulligan","player","Lforge/game/player/Player;"));f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",17);}
case 17:{f.Locals[1]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?26:25;continue;}
case 25:{return JStep.ReturnVoid;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/mulligan/AbstractMulligan","revealPreMulligan","(Lforge/game/card/CardCollection;)V","invokevirtual",31);}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",35);}
case 35:{f.Locals[2]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int==0?74:45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{f.Locals[3]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/AbstractMulligan","player","Lforge/game/player/Player;"));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",62);}
case 62:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",65);}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(null));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",70);}
case 70:{f.StackOp("pop");f.Pc=71;continue;}
case 71:{f.Pc=36;continue;}
case 74:{f.Push(JValue.L(100L));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/Thread","sleep","(J)V","invokestatic",80);}
case 80:{f.Pc=88;continue;}
case 83:{f.Locals[2]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/InterruptedException","printStackTrace","()V","invokevirtual",88);}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/AbstractMulligan","player","Lforge/game/player/Player;"));f.Pc=92;continue;}
case 92:{f.Push(JValue.R(null));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/player/Player","shuffle","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",96);}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/AbstractMulligan","timesMulliganed","I"));f.Pc=101;continue;}
case 101:{f.Push(JValue.I(1));f.Pc=102;continue;}
case 102:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=103;continue;}
case 103:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mulligan/AbstractMulligan","timesMulliganed","I",value);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[0]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/mulligan/AbstractMulligan","mulliganDraw","()V","invokevirtual",110);}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/AbstractMulligan","player","Lforge/game/player/Player;"));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/player/Player","onMulliganned","()V","invokevirtual",117);}
case 117:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7805(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mulligan/AbstractMulligan","kept","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7806(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/AbstractMulligan","kept","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7807(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7808(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/AbstractMulligan","player","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/mulligan/AbstractMulligan","handSizeAfterNextMulligan","()I","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/player/Player","drawCards","(I)Lforge/game/card/CardCollectionView;","invokevirtual",11);}
case 11:{f.StackOp("pop");f.Pc=12;continue;}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7809(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/AbstractMulligan","player","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","MULLIGAN","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","MULLIGAN","Lforge/game/GameLogEntryType;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",17);}
case 17:{f.Push(JValue.R(rt.String("lblPlayerKeepNCardsHand")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(2));f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/AbstractMulligan","player","Lforge/game/player/Player;"));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",32);}
case 32:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/game/mulligan/AbstractMulligan","player","Lforge/game/player/Player;"));f.Pc=39;continue;}
case 39:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/game/zone/PlayerZone","size","()I","invokevirtual",48);}
case 48:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",51);}
case 51:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",55);}
case 55:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",58);}
case 58:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",61);}
case 61:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
